using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Geip.V3.Model;

namespace HuaweiCloud.SDK.Geip.V3
{
    public partial class GeipClient : Client
    {
        public static ClientBuilder<GeipClient> NewBuilder()
        {
            return new ClientBuilder<GeipClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 添加全域公网带宽标签
        ///
        /// 添加全域公网带宽标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddInternetBandwidthTagsResponse AddInternetBandwidthTags(AddInternetBandwidthTagsRequest addInternetBandwidthTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", addInternetBandwidthTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/internet-bandwidth/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addInternetBandwidthTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddInternetBandwidthTagsResponse>(response);
        }

        public SyncInvoker<AddInternetBandwidthTagsResponse> AddInternetBandwidthTagsInvoker(AddInternetBandwidthTagsRequest addInternetBandwidthTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", addInternetBandwidthTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/internet-bandwidth/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addInternetBandwidthTagsRequest);
            return new SyncInvoker<AddInternetBandwidthTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<AddInternetBandwidthTagsResponse>);
        }
        
        /// <summary>
        /// 批量创建全域公网带宽
        ///
        /// 批量创建全域公网带宽
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateInternetBandwidthResponse BatchCreateInternetBandwidth(BatchCreateInternetBandwidthRequest batchCreateInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/internet-bandwidths/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateInternetBandwidthRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchCreateInternetBandwidthResponse>(response);
        }

        public SyncInvoker<BatchCreateInternetBandwidthResponse> BatchCreateInternetBandwidthInvoker(BatchCreateInternetBandwidthRequest batchCreateInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/internet-bandwidths/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateInternetBandwidthRequest);
            return new SyncInvoker<BatchCreateInternetBandwidthResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreateInternetBandwidthResponse>);
        }
        
        /// <summary>
        /// 批量添加全域公网带宽标签
        ///
        /// 批量添加全域公网带宽标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateInternetBandwidthTagsResponse BatchCreateInternetBandwidthTags(BatchCreateInternetBandwidthTagsRequest batchCreateInternetBandwidthTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchCreateInternetBandwidthTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/internet-bandwidth/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateInternetBandwidthTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateInternetBandwidthTagsResponse>(response);
        }

        public SyncInvoker<BatchCreateInternetBandwidthTagsResponse> BatchCreateInternetBandwidthTagsInvoker(BatchCreateInternetBandwidthTagsRequest batchCreateInternetBandwidthTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchCreateInternetBandwidthTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/internet-bandwidth/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateInternetBandwidthTagsRequest);
            return new SyncInvoker<BatchCreateInternetBandwidthTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateInternetBandwidthTagsResponse>);
        }
        
        /// <summary>
        /// 批量删除全域公网带宽标签
        ///
        /// 批量删除全域公网带宽标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteInternetBandwidthTagsResponse BatchDeleteInternetBandwidthTags(BatchDeleteInternetBandwidthTagsRequest batchDeleteInternetBandwidthTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchDeleteInternetBandwidthTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/internet-bandwidth/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteInternetBandwidthTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteInternetBandwidthTagsResponse>(response);
        }

        public SyncInvoker<BatchDeleteInternetBandwidthTagsResponse> BatchDeleteInternetBandwidthTagsInvoker(BatchDeleteInternetBandwidthTagsRequest batchDeleteInternetBandwidthTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchDeleteInternetBandwidthTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/internet-bandwidth/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteInternetBandwidthTagsRequest);
            return new SyncInvoker<BatchDeleteInternetBandwidthTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteInternetBandwidthTagsResponse>);
        }
        
        /// <summary>
        /// 查询全域公网带宽个数
        ///
        /// 查询全域公网带宽个数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CountInternetBandwidthResponse CountInternetBandwidth(CountInternetBandwidthRequest countInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/internet-bandwidths/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countInternetBandwidthRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CountInternetBandwidthResponse>(response);
        }

        public SyncInvoker<CountInternetBandwidthResponse> CountInternetBandwidthInvoker(CountInternetBandwidthRequest countInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/internet-bandwidths/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countInternetBandwidthRequest);
            return new SyncInvoker<CountInternetBandwidthResponse>(this, "GET", request, JsonUtils.DeSerialize<CountInternetBandwidthResponse>);
        }
        
        /// <summary>
        /// 创建全域公网带宽
        ///
        /// 创建全域公网带宽
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateInternetBandwidthResponse CreateInternetBandwidth(CreateInternetBandwidthRequest createInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/internet-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInternetBandwidthRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateInternetBandwidthResponse>(response);
        }

        public SyncInvoker<CreateInternetBandwidthResponse> CreateInternetBandwidthInvoker(CreateInternetBandwidthRequest createInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/internet-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInternetBandwidthRequest);
            return new SyncInvoker<CreateInternetBandwidthResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInternetBandwidthResponse>);
        }
        
        /// <summary>
        /// 创建租户签署免责条款
        ///
        /// 创建租户签署免责条款
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateUserDisclaimerResponse CreateUserDisclaimer(CreateUserDisclaimerRequest createUserDisclaimerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/user-disclaimer-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUserDisclaimerRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateUserDisclaimerResponse>(response);
        }

        public SyncInvoker<CreateUserDisclaimerResponse> CreateUserDisclaimerInvoker(CreateUserDisclaimerRequest createUserDisclaimerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/user-disclaimer-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUserDisclaimerRequest);
            return new SyncInvoker<CreateUserDisclaimerResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateUserDisclaimerResponse>);
        }
        
        /// <summary>
        /// 删除全域公网带宽
        ///
        /// 删除全域公网带宽
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteInternetBandwidthResponse DeleteInternetBandwidth(DeleteInternetBandwidthRequest deleteInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("internet_bandwidth_id", deleteInternetBandwidthRequest.InternetBandwidthId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/internet-bandwidths/{internet_bandwidth_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInternetBandwidthRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInternetBandwidthResponse>(response);
        }

        public SyncInvoker<DeleteInternetBandwidthResponse> DeleteInternetBandwidthInvoker(DeleteInternetBandwidthRequest deleteInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("internet_bandwidth_id", deleteInternetBandwidthRequest.InternetBandwidthId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/internet-bandwidths/{internet_bandwidth_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInternetBandwidthRequest);
            return new SyncInvoker<DeleteInternetBandwidthResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInternetBandwidthResponse>);
        }
        
        /// <summary>
        /// 删除全域公网带宽标签
        ///
        /// 删除全域公网带宽标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteInternetBandwidthTagResponse DeleteInternetBandwidthTag(DeleteInternetBandwidthTagRequest deleteInternetBandwidthTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", deleteInternetBandwidthTagRequest.ResourceId.ToString());
            urlParam.Add("tag_key", deleteInternetBandwidthTagRequest.TagKey.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/internet-bandwidth/{resource_id}/tags/{tag_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInternetBandwidthTagRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInternetBandwidthTagResponse>(response);
        }

        public SyncInvoker<DeleteInternetBandwidthTagResponse> DeleteInternetBandwidthTagInvoker(DeleteInternetBandwidthTagRequest deleteInternetBandwidthTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", deleteInternetBandwidthTagRequest.ResourceId.ToString());
            urlParam.Add("tag_key", deleteInternetBandwidthTagRequest.TagKey.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/internet-bandwidth/{resource_id}/tags/{tag_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInternetBandwidthTagRequest);
            return new SyncInvoker<DeleteInternetBandwidthTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInternetBandwidthTagResponse>);
        }
        
        /// <summary>
        /// 删除租户撤销免责条款
        ///
        /// 删除租户撤销免责条款
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteUserDisclaimerResponse DeleteUserDisclaimer(DeleteUserDisclaimerRequest deleteUserDisclaimerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/user-disclaimer-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserDisclaimerRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteUserDisclaimerResponse>(response);
        }

        public SyncInvoker<DeleteUserDisclaimerResponse> DeleteUserDisclaimerInvoker(DeleteUserDisclaimerRequest deleteUserDisclaimerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/user-disclaimer-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserDisclaimerRequest);
            return new SyncInvoker<DeleteUserDisclaimerResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteUserDisclaimerResponse>);
        }
        
        /// <summary>
        /// 查询接入点列表
        ///
        /// 查询接入点列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAccessSitesResponse ListAccessSites(ListAccessSitesRequest listAccessSitesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/access-sites", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessSitesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAccessSitesResponse>(response);
        }

        public SyncInvoker<ListAccessSitesResponse> ListAccessSitesInvoker(ListAccessSitesRequest listAccessSitesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/access-sites", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessSitesRequest);
            return new SyncInvoker<ListAccessSitesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAccessSitesResponse>);
        }
        
        /// <summary>
        /// 查询租户全域弹性公网IP配额
        ///
        /// 查询租户全域弹性公网IP配额
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGeipResourceQuotasResponse ListGeipResourceQuotas(ListGeipResourceQuotasRequest listGeipResourceQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGeipResourceQuotasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListGeipResourceQuotasResponse>(response);
        }

        public SyncInvoker<ListGeipResourceQuotasResponse> ListGeipResourceQuotasInvoker(ListGeipResourceQuotasRequest listGeipResourceQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGeipResourceQuotasRequest);
            return new SyncInvoker<ListGeipResourceQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGeipResourceQuotasResponse>);
        }
        
        /// <summary>
        /// 查询资源实例列表数目
        ///
        /// 查询资源实例列表数目
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInternetBandwidthCountFilterTagsResponse ListInternetBandwidthCountFilterTags(ListInternetBandwidthCountFilterTagsRequest listInternetBandwidthCountFilterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/internet-bandwidth/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInternetBandwidthCountFilterTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListInternetBandwidthCountFilterTagsResponse>(response);
        }

        public SyncInvoker<ListInternetBandwidthCountFilterTagsResponse> ListInternetBandwidthCountFilterTagsInvoker(ListInternetBandwidthCountFilterTagsRequest listInternetBandwidthCountFilterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/internet-bandwidth/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInternetBandwidthCountFilterTagsRequest);
            return new SyncInvoker<ListInternetBandwidthCountFilterTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListInternetBandwidthCountFilterTagsResponse>);
        }
        
        /// <summary>
        /// 查询全域公网带宽项目标签
        ///
        /// 查询全域公网带宽项目标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInternetBandwidthDomainTagsResponse ListInternetBandwidthDomainTags(ListInternetBandwidthDomainTagsRequest listInternetBandwidthDomainTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/internet-bandwidth/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInternetBandwidthDomainTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInternetBandwidthDomainTagsResponse>(response);
        }

        public SyncInvoker<ListInternetBandwidthDomainTagsResponse> ListInternetBandwidthDomainTagsInvoker(ListInternetBandwidthDomainTagsRequest listInternetBandwidthDomainTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/internet-bandwidth/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInternetBandwidthDomainTagsRequest);
            return new SyncInvoker<ListInternetBandwidthDomainTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInternetBandwidthDomainTagsResponse>);
        }
        
        /// <summary>
        /// 查询资源实例列表
        ///
        /// 查询资源实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInternetBandwidthFilterTagsResponse ListInternetBandwidthFilterTags(ListInternetBandwidthFilterTagsRequest listInternetBandwidthFilterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/internet-bandwidth/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInternetBandwidthFilterTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListInternetBandwidthFilterTagsResponse>(response);
        }

        public SyncInvoker<ListInternetBandwidthFilterTagsResponse> ListInternetBandwidthFilterTagsInvoker(ListInternetBandwidthFilterTagsRequest listInternetBandwidthFilterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/internet-bandwidth/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInternetBandwidthFilterTagsRequest);
            return new SyncInvoker<ListInternetBandwidthFilterTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListInternetBandwidthFilterTagsResponse>);
        }
        
        /// <summary>
        /// 全域公网带宽限制列表
        ///
        /// 查询全域公网带宽限制列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInternetBandwidthLimitsResponse ListInternetBandwidthLimits(ListInternetBandwidthLimitsRequest listInternetBandwidthLimitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/internet-bandwidth-limits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInternetBandwidthLimitsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInternetBandwidthLimitsResponse>(response);
        }

        public SyncInvoker<ListInternetBandwidthLimitsResponse> ListInternetBandwidthLimitsInvoker(ListInternetBandwidthLimitsRequest listInternetBandwidthLimitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/internet-bandwidth-limits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInternetBandwidthLimitsRequest);
            return new SyncInvoker<ListInternetBandwidthLimitsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInternetBandwidthLimitsResponse>);
        }
        
        /// <summary>
        /// 查询全域公网带宽列表
        ///
        /// 查询全域公网带宽列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInternetBandwidthsResponse ListInternetBandwidths(ListInternetBandwidthsRequest listInternetBandwidthsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/internet-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInternetBandwidthsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInternetBandwidthsResponse>(response);
        }

        public SyncInvoker<ListInternetBandwidthsResponse> ListInternetBandwidthsInvoker(ListInternetBandwidthsRequest listInternetBandwidthsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/internet-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInternetBandwidthsRequest);
            return new SyncInvoker<ListInternetBandwidthsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInternetBandwidthsResponse>);
        }
        
        /// <summary>
        /// 查询全域弹性公网IP段支持的掩码列表
        ///
        /// 查询全域弹性公网IP段支持的掩码列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSupportMasksResponse ListSupportMasks(ListSupportMasksRequest listSupportMasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments/support-masks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSupportMasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSupportMasksResponse>(response);
        }

        public SyncInvoker<ListSupportMasksResponse> ListSupportMasksInvoker(ListSupportMasksRequest listSupportMasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments/support-masks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSupportMasksRequest);
            return new SyncInvoker<ListSupportMasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSupportMasksResponse>);
        }
        
        /// <summary>
        /// 查询全域公网带宽详情
        ///
        /// 查询全域公网带宽详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInternetBandwidthResponse ShowInternetBandwidth(ShowInternetBandwidthRequest showInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("internet_bandwidth_id", showInternetBandwidthRequest.InternetBandwidthId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/internet-bandwidths/{internet_bandwidth_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInternetBandwidthRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInternetBandwidthResponse>(response);
        }

        public SyncInvoker<ShowInternetBandwidthResponse> ShowInternetBandwidthInvoker(ShowInternetBandwidthRequest showInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("internet_bandwidth_id", showInternetBandwidthRequest.InternetBandwidthId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/internet-bandwidths/{internet_bandwidth_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInternetBandwidthRequest);
            return new SyncInvoker<ShowInternetBandwidthResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInternetBandwidthResponse>);
        }
        
        /// <summary>
        /// 查询全域公网带宽标签
        ///
        /// 查询全域公网带宽标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInternetBandwidthTagsResponse ShowInternetBandwidthTags(ShowInternetBandwidthTagsRequest showInternetBandwidthTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", showInternetBandwidthTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/internet-bandwidth/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInternetBandwidthTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInternetBandwidthTagsResponse>(response);
        }

        public SyncInvoker<ShowInternetBandwidthTagsResponse> ShowInternetBandwidthTagsInvoker(ShowInternetBandwidthTagsRequest showInternetBandwidthTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", showInternetBandwidthTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/internet-bandwidth/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInternetBandwidthTagsRequest);
            return new SyncInvoker<ShowInternetBandwidthTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInternetBandwidthTagsResponse>);
        }
        
        /// <summary>
        /// 查询租户签署免责条款详情
        ///
        /// 查询租户签署免责条款详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowUserDisclaimerResponse ShowUserDisclaimer(ShowUserDisclaimerRequest showUserDisclaimerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/user-disclaimer-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserDisclaimerRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowUserDisclaimerResponse>(response);
        }

        public SyncInvoker<ShowUserDisclaimerResponse> ShowUserDisclaimerInvoker(ShowUserDisclaimerRequest showUserDisclaimerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/user-disclaimer-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserDisclaimerRequest);
            return new SyncInvoker<ShowUserDisclaimerResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUserDisclaimerResponse>);
        }
        
        /// <summary>
        /// 更新全域公网带宽
        ///
        /// 更新全域公网带宽
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInternetBandwidthResponse UpdateInternetBandwidth(UpdateInternetBandwidthRequest updateInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("internet_bandwidth_id", updateInternetBandwidthRequest.InternetBandwidthId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/internet-bandwidths/{internet_bandwidth_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInternetBandwidthRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInternetBandwidthResponse>(response);
        }

        public SyncInvoker<UpdateInternetBandwidthResponse> UpdateInternetBandwidthInvoker(UpdateInternetBandwidthRequest updateInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("internet_bandwidth_id", updateInternetBandwidthRequest.InternetBandwidthId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/internet-bandwidths/{internet_bandwidth_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInternetBandwidthRequest);
            return new SyncInvoker<UpdateInternetBandwidthResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInternetBandwidthResponse>);
        }
        
        /// <summary>
        /// 添加全域弹性公网IP段标签
        ///
        /// 添加全域弹性公网IP段的标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddGeipSegmentTagsResponse AddGeipSegmentTags(AddGeipSegmentTagsRequest addGeipSegmentTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", addGeipSegmentTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip-segment/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addGeipSegmentTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddGeipSegmentTagsResponse>(response);
        }

        public SyncInvoker<AddGeipSegmentTagsResponse> AddGeipSegmentTagsInvoker(AddGeipSegmentTagsRequest addGeipSegmentTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", addGeipSegmentTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip-segment/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addGeipSegmentTagsRequest);
            return new SyncInvoker<AddGeipSegmentTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<AddGeipSegmentTagsResponse>);
        }
        
        /// <summary>
        /// 添加全域弹性公网IP标签
        ///
        /// 添加全域弹性公网IP的标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddGlobalEipTagsResponse AddGlobalEipTags(AddGlobalEipTagsRequest addGlobalEipTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", addGlobalEipTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addGlobalEipTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddGlobalEipTagsResponse>(response);
        }

        public SyncInvoker<AddGlobalEipTagsResponse> AddGlobalEipTagsInvoker(AddGlobalEipTagsRequest addGlobalEipTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", addGlobalEipTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addGlobalEipTagsRequest);
            return new SyncInvoker<AddGlobalEipTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<AddGlobalEipTagsResponse>);
        }
        
        /// <summary>
        /// 全域弹性公网IP段绑定后端实例
        ///
        /// 全域弹性公网IP段绑定后端实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AssociateGeipSegmentInstanceResponse AssociateGeipSegmentInstance(AssociateGeipSegmentInstanceRequest associateGeipSegmentInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_segment_id", associateGeipSegmentInstanceRequest.GlobalEipSegmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments/{global_eip_segment_id}/associate-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateGeipSegmentInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AssociateGeipSegmentInstanceResponse>(response);
        }

        public SyncInvoker<AssociateGeipSegmentInstanceResponse> AssociateGeipSegmentInstanceInvoker(AssociateGeipSegmentInstanceRequest associateGeipSegmentInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_segment_id", associateGeipSegmentInstanceRequest.GlobalEipSegmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments/{global_eip_segment_id}/associate-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateGeipSegmentInstanceRequest);
            return new SyncInvoker<AssociateGeipSegmentInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateGeipSegmentInstanceResponse>);
        }
        
        /// <summary>
        /// 绑定后端实例
        ///
        /// 绑定后端实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AssociateInstanceResponse AssociateInstance(AssociateInstanceRequest associateInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_id", associateInstanceRequest.GlobalEipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/{global_eip_id}/associate-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AssociateInstanceResponse>(response);
        }

        public SyncInvoker<AssociateInstanceResponse> AssociateInstanceInvoker(AssociateInstanceRequest associateInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_id", associateInstanceRequest.GlobalEipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/{global_eip_id}/associate-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateInstanceRequest);
            return new SyncInvoker<AssociateInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateInstanceResponse>);
        }
        
        /// <summary>
        /// 绑定全域公网带宽
        ///
        /// 绑定全域公网带宽
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AttachInternetBandwidthResponse AttachInternetBandwidth(AttachInternetBandwidthRequest attachInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_id", attachInternetBandwidthRequest.GlobalEipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/{global_eip_id}/attach-internet-bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachInternetBandwidthRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AttachInternetBandwidthResponse>(response);
        }

        public SyncInvoker<AttachInternetBandwidthResponse> AttachInternetBandwidthInvoker(AttachInternetBandwidthRequest attachInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_id", attachInternetBandwidthRequest.GlobalEipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/{global_eip_id}/attach-internet-bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachInternetBandwidthRequest);
            return new SyncInvoker<AttachInternetBandwidthResponse>(this, "POST", request, JsonUtils.DeSerialize<AttachInternetBandwidthResponse>);
        }
        
        /// <summary>
        /// 全域弹性公网IP段批量绑定全域公网带宽
        ///
        /// 全域弹性公网IP段批量绑定全域公网带宽
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchAttachGeipSegmentInternetBandwidthResponse BatchAttachGeipSegmentInternetBandwidth(BatchAttachGeipSegmentInternetBandwidthRequest batchAttachGeipSegmentInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments/batch-attach-internet-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAttachGeipSegmentInternetBandwidthRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchAttachGeipSegmentInternetBandwidthResponse>(response);
        }

        public SyncInvoker<BatchAttachGeipSegmentInternetBandwidthResponse> BatchAttachGeipSegmentInternetBandwidthInvoker(BatchAttachGeipSegmentInternetBandwidthRequest batchAttachGeipSegmentInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments/batch-attach-internet-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAttachGeipSegmentInternetBandwidthRequest);
            return new SyncInvoker<BatchAttachGeipSegmentInternetBandwidthResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchAttachGeipSegmentInternetBandwidthResponse>);
        }
        
        /// <summary>
        /// 批量绑定全域公网带宽
        ///
        /// 批量绑定全域公网带宽
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchAttachInternetBandwidthResponse BatchAttachInternetBandwidth(BatchAttachInternetBandwidthRequest batchAttachInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/batch-attach-internet-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAttachInternetBandwidthRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchAttachInternetBandwidthResponse>(response);
        }

        public SyncInvoker<BatchAttachInternetBandwidthResponse> BatchAttachInternetBandwidthInvoker(BatchAttachInternetBandwidthRequest batchAttachInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/batch-attach-internet-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAttachInternetBandwidthRequest);
            return new SyncInvoker<BatchAttachInternetBandwidthResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchAttachInternetBandwidthResponse>);
        }
        
        /// <summary>
        /// 批量添加全域弹性公网IP段标签
        ///
        /// 批量添加全域弹性公网IP段的标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateGeipSegmentTagsResponse BatchCreateGeipSegmentTags(BatchCreateGeipSegmentTagsRequest batchCreateGeipSegmentTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchCreateGeipSegmentTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip-segment/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateGeipSegmentTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateGeipSegmentTagsResponse>(response);
        }

        public SyncInvoker<BatchCreateGeipSegmentTagsResponse> BatchCreateGeipSegmentTagsInvoker(BatchCreateGeipSegmentTagsRequest batchCreateGeipSegmentTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchCreateGeipSegmentTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip-segment/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateGeipSegmentTagsRequest);
            return new SyncInvoker<BatchCreateGeipSegmentTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateGeipSegmentTagsResponse>);
        }
        
        /// <summary>
        /// 批量创建全域弹性公网IP
        ///
        /// 批量创建全域弹性公网IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateGlobalEipResponse BatchCreateGlobalEip(BatchCreateGlobalEipRequest batchCreateGlobalEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateGlobalEipRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchCreateGlobalEipResponse>(response);
        }

        public SyncInvoker<BatchCreateGlobalEipResponse> BatchCreateGlobalEipInvoker(BatchCreateGlobalEipRequest batchCreateGlobalEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateGlobalEipRequest);
            return new SyncInvoker<BatchCreateGlobalEipResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreateGlobalEipResponse>);
        }
        
        /// <summary>
        /// 批量添加全域弹性公网IP标签
        ///
        /// 批量添加全域弹性公网IP的标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateGlobalEipTagsResponse BatchCreateGlobalEipTags(BatchCreateGlobalEipTagsRequest batchCreateGlobalEipTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchCreateGlobalEipTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateGlobalEipTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateGlobalEipTagsResponse>(response);
        }

        public SyncInvoker<BatchCreateGlobalEipTagsResponse> BatchCreateGlobalEipTagsInvoker(BatchCreateGlobalEipTagsRequest batchCreateGlobalEipTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchCreateGlobalEipTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateGlobalEipTagsRequest);
            return new SyncInvoker<BatchCreateGlobalEipTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateGlobalEipTagsResponse>);
        }
        
        /// <summary>
        /// 批量删除全域弹性公网IP段标签
        ///
        /// 批量删除全域弹性公网IP段的标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteGeipSegmentTagsResponse BatchDeleteGeipSegmentTags(BatchDeleteGeipSegmentTagsRequest batchDeleteGeipSegmentTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchDeleteGeipSegmentTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip-segment/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteGeipSegmentTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteGeipSegmentTagsResponse>(response);
        }

        public SyncInvoker<BatchDeleteGeipSegmentTagsResponse> BatchDeleteGeipSegmentTagsInvoker(BatchDeleteGeipSegmentTagsRequest batchDeleteGeipSegmentTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchDeleteGeipSegmentTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip-segment/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteGeipSegmentTagsRequest);
            return new SyncInvoker<BatchDeleteGeipSegmentTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteGeipSegmentTagsResponse>);
        }
        
        /// <summary>
        /// 批量删除全域弹性公网IP标签
        ///
        /// 批量删除全域弹性公网IP的标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteGlobalEipTagsResponse BatchDeleteGlobalEipTags(BatchDeleteGlobalEipTagsRequest batchDeleteGlobalEipTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchDeleteGlobalEipTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteGlobalEipTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteGlobalEipTagsResponse>(response);
        }

        public SyncInvoker<BatchDeleteGlobalEipTagsResponse> BatchDeleteGlobalEipTagsInvoker(BatchDeleteGlobalEipTagsRequest batchDeleteGlobalEipTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchDeleteGlobalEipTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteGlobalEipTagsRequest);
            return new SyncInvoker<BatchDeleteGlobalEipTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteGlobalEipTagsResponse>);
        }
        
        /// <summary>
        /// 全域弹性公网IP段批量解绑全域公网带宽
        ///
        /// 全域弹性公网IP段批量解绑全域公网带宽
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDetachGeipSegmentInternetBandwidthResponse BatchDetachGeipSegmentInternetBandwidth(BatchDetachGeipSegmentInternetBandwidthRequest batchDetachGeipSegmentInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments/batch-detach-internet-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDetachGeipSegmentInternetBandwidthRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDetachGeipSegmentInternetBandwidthResponse>(response);
        }

        public SyncInvoker<BatchDetachGeipSegmentInternetBandwidthResponse> BatchDetachGeipSegmentInternetBandwidthInvoker(BatchDetachGeipSegmentInternetBandwidthRequest batchDetachGeipSegmentInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments/batch-detach-internet-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDetachGeipSegmentInternetBandwidthRequest);
            return new SyncInvoker<BatchDetachGeipSegmentInternetBandwidthResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDetachGeipSegmentInternetBandwidthResponse>);
        }
        
        /// <summary>
        /// 批量解绑全域公网带宽
        ///
        /// 批量解绑全域公网带宽
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDetachInternetBandwidthResponse BatchDetachInternetBandwidth(BatchDetachInternetBandwidthRequest batchDetachInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/batch-detach-internet-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDetachInternetBandwidthRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDetachInternetBandwidthResponse>(response);
        }

        public SyncInvoker<BatchDetachInternetBandwidthResponse> BatchDetachInternetBandwidthInvoker(BatchDetachInternetBandwidthRequest batchDetachInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/batch-detach-internet-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDetachInternetBandwidthRequest);
            return new SyncInvoker<BatchDetachInternetBandwidthResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDetachInternetBandwidthResponse>);
        }
        
        /// <summary>
        /// 查询全域弹性公网IP段个数
        ///
        /// 查询全域弹性公网IP段个数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CountGlobalEipSegmentResponse CountGlobalEipSegment(CountGlobalEipSegmentRequest countGlobalEipSegmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countGlobalEipSegmentRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CountGlobalEipSegmentResponse>(response);
        }

        public SyncInvoker<CountGlobalEipSegmentResponse> CountGlobalEipSegmentInvoker(CountGlobalEipSegmentRequest countGlobalEipSegmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countGlobalEipSegmentRequest);
            return new SyncInvoker<CountGlobalEipSegmentResponse>(this, "GET", request, JsonUtils.DeSerialize<CountGlobalEipSegmentResponse>);
        }
        
        /// <summary>
        /// 查询全域弹性公网IP个数
        ///
        /// 查询全域弹性公网IP个数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CountGlobalEipsResponse CountGlobalEips(CountGlobalEipsRequest countGlobalEipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countGlobalEipsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CountGlobalEipsResponse>(response);
        }

        public SyncInvoker<CountGlobalEipsResponse> CountGlobalEipsInvoker(CountGlobalEipsRequest countGlobalEipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countGlobalEipsRequest);
            return new SyncInvoker<CountGlobalEipsResponse>(this, "GET", request, JsonUtils.DeSerialize<CountGlobalEipsResponse>);
        }
        
        /// <summary>
        /// 创建全域弹性公网IP
        ///
        /// 创建全域弹性公网IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateGlobalEipResponse CreateGlobalEip(CreateGlobalEipRequest createGlobalEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGlobalEipRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateGlobalEipResponse>(response);
        }

        public SyncInvoker<CreateGlobalEipResponse> CreateGlobalEipInvoker(CreateGlobalEipRequest createGlobalEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGlobalEipRequest);
            return new SyncInvoker<CreateGlobalEipResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGlobalEipResponse>);
        }
        
        /// <summary>
        /// 创建全域弹性公网IP段
        ///
        /// 创建全域弹性公网IP段
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateGlobalEipSegmentResponse CreateGlobalEipSegment(CreateGlobalEipSegmentRequest createGlobalEipSegmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGlobalEipSegmentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateGlobalEipSegmentResponse>(response);
        }

        public SyncInvoker<CreateGlobalEipSegmentResponse> CreateGlobalEipSegmentInvoker(CreateGlobalEipSegmentRequest createGlobalEipSegmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGlobalEipSegmentRequest);
            return new SyncInvoker<CreateGlobalEipSegmentResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGlobalEipSegmentResponse>);
        }
        
        /// <summary>
        /// 删除全域弹性公网IP段标签
        ///
        /// 删除全域弹性公网IP段的标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteGeipSegmentTagResponse DeleteGeipSegmentTag(DeleteGeipSegmentTagRequest deleteGeipSegmentTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", deleteGeipSegmentTagRequest.ResourceId.ToString());
            urlParam.Add("tag_key", deleteGeipSegmentTagRequest.TagKey.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip-segment/{resource_id}/tags/{tag_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGeipSegmentTagRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteGeipSegmentTagResponse>(response);
        }

        public SyncInvoker<DeleteGeipSegmentTagResponse> DeleteGeipSegmentTagInvoker(DeleteGeipSegmentTagRequest deleteGeipSegmentTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", deleteGeipSegmentTagRequest.ResourceId.ToString());
            urlParam.Add("tag_key", deleteGeipSegmentTagRequest.TagKey.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip-segment/{resource_id}/tags/{tag_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGeipSegmentTagRequest);
            return new SyncInvoker<DeleteGeipSegmentTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteGeipSegmentTagResponse>);
        }
        
        /// <summary>
        /// 删除全域弹性公网IP
        ///
        /// 删除全域弹性公网IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteGlobalEipResponse DeleteGlobalEip(DeleteGlobalEipRequest deleteGlobalEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_id", deleteGlobalEipRequest.GlobalEipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/{global_eip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGlobalEipRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteGlobalEipResponse>(response);
        }

        public SyncInvoker<DeleteGlobalEipResponse> DeleteGlobalEipInvoker(DeleteGlobalEipRequest deleteGlobalEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_id", deleteGlobalEipRequest.GlobalEipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/{global_eip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGlobalEipRequest);
            return new SyncInvoker<DeleteGlobalEipResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteGlobalEipResponse>);
        }
        
        /// <summary>
        /// 删除全域弹性公网IP段
        ///
        /// 删除全域弹性公网IP段
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteGlobalEipSegmentResponse DeleteGlobalEipSegment(DeleteGlobalEipSegmentRequest deleteGlobalEipSegmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_segment_id", deleteGlobalEipSegmentRequest.GlobalEipSegmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments/{global_eip_segment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGlobalEipSegmentRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteGlobalEipSegmentResponse>(response);
        }

        public SyncInvoker<DeleteGlobalEipSegmentResponse> DeleteGlobalEipSegmentInvoker(DeleteGlobalEipSegmentRequest deleteGlobalEipSegmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_segment_id", deleteGlobalEipSegmentRequest.GlobalEipSegmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments/{global_eip_segment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGlobalEipSegmentRequest);
            return new SyncInvoker<DeleteGlobalEipSegmentResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteGlobalEipSegmentResponse>);
        }
        
        /// <summary>
        /// 删除全域弹性公网IP标签
        ///
        /// 删除全域弹性公网IP的标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteGlobalEipTagResponse DeleteGlobalEipTag(DeleteGlobalEipTagRequest deleteGlobalEipTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", deleteGlobalEipTagRequest.ResourceId.ToString());
            urlParam.Add("tag_key", deleteGlobalEipTagRequest.TagKey.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip/{resource_id}/tags/{tag_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGlobalEipTagRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteGlobalEipTagResponse>(response);
        }

        public SyncInvoker<DeleteGlobalEipTagResponse> DeleteGlobalEipTagInvoker(DeleteGlobalEipTagRequest deleteGlobalEipTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", deleteGlobalEipTagRequest.ResourceId.ToString());
            urlParam.Add("tag_key", deleteGlobalEipTagRequest.TagKey.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip/{resource_id}/tags/{tag_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGlobalEipTagRequest);
            return new SyncInvoker<DeleteGlobalEipTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteGlobalEipTagResponse>);
        }
        
        /// <summary>
        /// 解绑全域公网带宽
        ///
        /// 解绑全域公网带宽
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DetachInternetBandwidthResponse DetachInternetBandwidth(DetachInternetBandwidthRequest detachInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_id", detachInternetBandwidthRequest.GlobalEipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/{global_eip_id}/detach-internet-bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachInternetBandwidthRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DetachInternetBandwidthResponse>(response);
        }

        public SyncInvoker<DetachInternetBandwidthResponse> DetachInternetBandwidthInvoker(DetachInternetBandwidthRequest detachInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_id", detachInternetBandwidthRequest.GlobalEipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/{global_eip_id}/detach-internet-bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachInternetBandwidthRequest);
            return new SyncInvoker<DetachInternetBandwidthResponse>(this, "POST", request, JsonUtils.DeSerialize<DetachInternetBandwidthResponse>);
        }
        
        /// <summary>
        /// 全域弹性公网IP段解绑后端实例
        ///
        /// 全域弹性公网IP段解绑后端实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisassociateGeipSegmentInstanceResponse DisassociateGeipSegmentInstance(DisassociateGeipSegmentInstanceRequest disassociateGeipSegmentInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_segment_id", disassociateGeipSegmentInstanceRequest.GlobalEipSegmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments/{global_eip_segment_id}/disassociate-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateGeipSegmentInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DisassociateGeipSegmentInstanceResponse>(response);
        }

        public SyncInvoker<DisassociateGeipSegmentInstanceResponse> DisassociateGeipSegmentInstanceInvoker(DisassociateGeipSegmentInstanceRequest disassociateGeipSegmentInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_segment_id", disassociateGeipSegmentInstanceRequest.GlobalEipSegmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments/{global_eip_segment_id}/disassociate-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateGeipSegmentInstanceRequest);
            return new SyncInvoker<DisassociateGeipSegmentInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<DisassociateGeipSegmentInstanceResponse>);
        }
        
        /// <summary>
        /// 解绑后端实例
        ///
        /// 解绑后端实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisassociateInstanceResponse DisassociateInstance(DisassociateInstanceRequest disassociateInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_id", disassociateInstanceRequest.GlobalEipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/{global_eip_id}/disassociate-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DisassociateInstanceResponse>(response);
        }

        public SyncInvoker<DisassociateInstanceResponse> DisassociateInstanceInvoker(DisassociateInstanceRequest disassociateInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_id", disassociateInstanceRequest.GlobalEipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/{global_eip_id}/disassociate-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateInstanceRequest);
            return new SyncInvoker<DisassociateInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<DisassociateInstanceResponse>);
        }
        
        /// <summary>
        /// 查询全域弹性公网IP池列表
        ///
        /// 查询全域弹性公网IP池列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGeipPoolsResponse ListGeipPools(ListGeipPoolsRequest listGeipPoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/geip-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGeipPoolsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListGeipPoolsResponse>(response);
        }

        public SyncInvoker<ListGeipPoolsResponse> ListGeipPoolsInvoker(ListGeipPoolsRequest listGeipPoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/geip-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGeipPoolsRequest);
            return new SyncInvoker<ListGeipPoolsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGeipPoolsResponse>);
        }
        
        /// <summary>
        /// 查询资源实例列表数目
        ///
        /// 查询资源实例列表的数目
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGeipSegmentCountFilterTagsResponse ListGeipSegmentCountFilterTags(ListGeipSegmentCountFilterTagsRequest listGeipSegmentCountFilterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip-segment/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGeipSegmentCountFilterTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListGeipSegmentCountFilterTagsResponse>(response);
        }

        public SyncInvoker<ListGeipSegmentCountFilterTagsResponse> ListGeipSegmentCountFilterTagsInvoker(ListGeipSegmentCountFilterTagsRequest listGeipSegmentCountFilterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip-segment/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGeipSegmentCountFilterTagsRequest);
            return new SyncInvoker<ListGeipSegmentCountFilterTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListGeipSegmentCountFilterTagsResponse>);
        }
        
        /// <summary>
        /// 查询全域弹性公网IP段项目标签
        ///
        /// 查询全域弹性公网IP段的项目标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGeipSegmentDomainTagsResponse ListGeipSegmentDomainTags(ListGeipSegmentDomainTagsRequest listGeipSegmentDomainTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip-segment/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGeipSegmentDomainTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListGeipSegmentDomainTagsResponse>(response);
        }

        public SyncInvoker<ListGeipSegmentDomainTagsResponse> ListGeipSegmentDomainTagsInvoker(ListGeipSegmentDomainTagsRequest listGeipSegmentDomainTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip-segment/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGeipSegmentDomainTagsRequest);
            return new SyncInvoker<ListGeipSegmentDomainTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGeipSegmentDomainTagsResponse>);
        }
        
        /// <summary>
        /// 查询资源实例列表
        ///
        /// 查询资源实例的列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGeipSegmentFilterTagsResponse ListGeipSegmentFilterTags(ListGeipSegmentFilterTagsRequest listGeipSegmentFilterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip-segment/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGeipSegmentFilterTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListGeipSegmentFilterTagsResponse>(response);
        }

        public SyncInvoker<ListGeipSegmentFilterTagsResponse> ListGeipSegmentFilterTagsInvoker(ListGeipSegmentFilterTagsRequest listGeipSegmentFilterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip-segment/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGeipSegmentFilterTagsRequest);
            return new SyncInvoker<ListGeipSegmentFilterTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListGeipSegmentFilterTagsResponse>);
        }
        
        /// <summary>
        /// 查询资源实例列表数目
        ///
        /// 查询资源实例列表数目
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGlobalEipCountFilterTagsResponse ListGlobalEipCountFilterTags(ListGlobalEipCountFilterTagsRequest listGlobalEipCountFilterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalEipCountFilterTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListGlobalEipCountFilterTagsResponse>(response);
        }

        public SyncInvoker<ListGlobalEipCountFilterTagsResponse> ListGlobalEipCountFilterTagsInvoker(ListGlobalEipCountFilterTagsRequest listGlobalEipCountFilterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalEipCountFilterTagsRequest);
            return new SyncInvoker<ListGlobalEipCountFilterTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListGlobalEipCountFilterTagsResponse>);
        }
        
        /// <summary>
        /// 查询全域弹性公网IP项目标签
        ///
        /// 查询全域弹性公网IP的项目标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGlobalEipDomainTagsResponse ListGlobalEipDomainTags(ListGlobalEipDomainTagsRequest listGlobalEipDomainTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalEipDomainTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListGlobalEipDomainTagsResponse>(response);
        }

        public SyncInvoker<ListGlobalEipDomainTagsResponse> ListGlobalEipDomainTagsInvoker(ListGlobalEipDomainTagsRequest listGlobalEipDomainTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalEipDomainTagsRequest);
            return new SyncInvoker<ListGlobalEipDomainTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGlobalEipDomainTagsResponse>);
        }
        
        /// <summary>
        /// 查询资源实例列表
        ///
        /// 查询资源实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGlobalEipFilterTagsResponse ListGlobalEipFilterTags(ListGlobalEipFilterTagsRequest listGlobalEipFilterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalEipFilterTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListGlobalEipFilterTagsResponse>(response);
        }

        public SyncInvoker<ListGlobalEipFilterTagsResponse> ListGlobalEipFilterTagsInvoker(ListGlobalEipFilterTagsRequest listGlobalEipFilterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalEipFilterTagsRequest);
            return new SyncInvoker<ListGlobalEipFilterTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListGlobalEipFilterTagsResponse>);
        }
        
        /// <summary>
        /// 查询全域弹性公网IP段列表
        ///
        /// 查询全域弹性公网IP段列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGlobalEipSegmentsResponse ListGlobalEipSegments(ListGlobalEipSegmentsRequest listGlobalEipSegmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalEipSegmentsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListGlobalEipSegmentsResponse>(response);
        }

        public SyncInvoker<ListGlobalEipSegmentsResponse> ListGlobalEipSegmentsInvoker(ListGlobalEipSegmentsRequest listGlobalEipSegmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalEipSegmentsRequest);
            return new SyncInvoker<ListGlobalEipSegmentsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGlobalEipSegmentsResponse>);
        }
        
        /// <summary>
        /// 查询全域弹性公网IP列表
        ///
        /// 查询全域弹性公网IP列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGlobalEipsResponse ListGlobalEips(ListGlobalEipsRequest listGlobalEipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalEipsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListGlobalEipsResponse>(response);
        }

        public SyncInvoker<ListGlobalEipsResponse> ListGlobalEipsInvoker(ListGlobalEipsRequest listGlobalEipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalEipsRequest);
            return new SyncInvoker<ListGlobalEipsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGlobalEipsResponse>);
        }
        
        /// <summary>
        /// 查询全域弹性公网IP段标签
        ///
        /// 查询全域弹性公网IP段的标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGeipSegmentTagsResponse ShowGeipSegmentTags(ShowGeipSegmentTagsRequest showGeipSegmentTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", showGeipSegmentTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip-segment/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGeipSegmentTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGeipSegmentTagsResponse>(response);
        }

        public SyncInvoker<ShowGeipSegmentTagsResponse> ShowGeipSegmentTagsInvoker(ShowGeipSegmentTagsRequest showGeipSegmentTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", showGeipSegmentTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip-segment/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGeipSegmentTagsRequest);
            return new SyncInvoker<ShowGeipSegmentTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGeipSegmentTagsResponse>);
        }
        
        /// <summary>
        /// 查询全域弹性公网IP详情
        ///
        /// 查询全域弹性公网IP详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGlobalEipResponse ShowGlobalEip(ShowGlobalEipRequest showGlobalEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_id", showGlobalEipRequest.GlobalEipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/{global_eip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGlobalEipRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGlobalEipResponse>(response);
        }

        public SyncInvoker<ShowGlobalEipResponse> ShowGlobalEipInvoker(ShowGlobalEipRequest showGlobalEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_id", showGlobalEipRequest.GlobalEipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/{global_eip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGlobalEipRequest);
            return new SyncInvoker<ShowGlobalEipResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGlobalEipResponse>);
        }
        
        /// <summary>
        /// 查询全域弹性公网IP段详情
        ///
        /// 查询全域弹性公网IP段详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGlobalEipSegmentResponse ShowGlobalEipSegment(ShowGlobalEipSegmentRequest showGlobalEipSegmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_segment_id", showGlobalEipSegmentRequest.GlobalEipSegmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments/{global_eip_segment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGlobalEipSegmentRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGlobalEipSegmentResponse>(response);
        }

        public SyncInvoker<ShowGlobalEipSegmentResponse> ShowGlobalEipSegmentInvoker(ShowGlobalEipSegmentRequest showGlobalEipSegmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_segment_id", showGlobalEipSegmentRequest.GlobalEipSegmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments/{global_eip_segment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGlobalEipSegmentRequest);
            return new SyncInvoker<ShowGlobalEipSegmentResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGlobalEipSegmentResponse>);
        }
        
        /// <summary>
        /// 查询全域弹性公网IP标签
        ///
        /// 查询全域弹性公网IP的标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGlobalEipTagsResponse ShowGlobalEipTags(ShowGlobalEipTagsRequest showGlobalEipTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", showGlobalEipTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGlobalEipTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGlobalEipTagsResponse>(response);
        }

        public SyncInvoker<ShowGlobalEipTagsResponse> ShowGlobalEipTagsInvoker(ShowGlobalEipTagsRequest showGlobalEipTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", showGlobalEipTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGlobalEipTagsRequest);
            return new SyncInvoker<ShowGlobalEipTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGlobalEipTagsResponse>);
        }
        
        /// <summary>
        /// 更新全域弹性公网IP信息
        ///
        /// 更新全域弹性公网IP信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGlobalEipResponse UpdateGlobalEip(UpdateGlobalEipRequest updateGlobalEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_id", updateGlobalEipRequest.GlobalEipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/{global_eip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGlobalEipRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGlobalEipResponse>(response);
        }

        public SyncInvoker<UpdateGlobalEipResponse> UpdateGlobalEipInvoker(UpdateGlobalEipRequest updateGlobalEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_id", updateGlobalEipRequest.GlobalEipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/{global_eip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGlobalEipRequest);
            return new SyncInvoker<UpdateGlobalEipResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGlobalEipResponse>);
        }
        
        /// <summary>
        /// 更新全域弹性公网IP段
        ///
        /// 更新全域弹性公网IP段
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGlobalEipSegmentResponse UpdateGlobalEipSegment(UpdateGlobalEipSegmentRequest updateGlobalEipSegmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_segment_id", updateGlobalEipSegmentRequest.GlobalEipSegmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments/{global_eip_segment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGlobalEipSegmentRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGlobalEipSegmentResponse>(response);
        }

        public SyncInvoker<UpdateGlobalEipSegmentResponse> UpdateGlobalEipSegmentInvoker(UpdateGlobalEipSegmentRequest updateGlobalEipSegmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_segment_id", updateGlobalEipSegmentRequest.GlobalEipSegmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments/{global_eip_segment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGlobalEipSegmentRequest);
            return new SyncInvoker<UpdateGlobalEipSegmentResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGlobalEipSegmentResponse>);
        }
        
        /// <summary>
        /// 查询Job列表
        ///
        /// 查询Job列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListJobsResponse ListJobs(ListJobsRequest listJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListJobsResponse>(response);
        }

        public SyncInvoker<ListJobsResponse> ListJobsInvoker(ListJobsRequest listJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobsRequest);
            return new SyncInvoker<ListJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListJobsResponse>);
        }
        
        /// <summary>
        /// 查询Job详情
        ///
        /// 查询Job详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowJobsResponse ShowJobs(ShowJobsRequest showJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowJobsResponse>(response);
        }

        public SyncInvoker<ShowJobsResponse> ShowJobsInvoker(ShowJobsRequest showJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobsRequest);
            return new SyncInvoker<ShowJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobsResponse>);
        }
        
        /// <summary>
        /// 全域弹性公网IP支持绑定的Region限制
        ///
        /// 全域弹性公网IP支持绑定的Region限制
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSupportRegionsResponse ListSupportRegions(ListSupportRegionsRequest listSupportRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/support-regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSupportRegionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSupportRegionsResponse>(response);
        }

        public SyncInvoker<ListSupportRegionsResponse> ListSupportRegionsInvoker(ListSupportRegionsRequest listSupportRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/support-regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSupportRegionsRequest);
            return new SyncInvoker<ListSupportRegionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSupportRegionsResponse>);
        }
        
        /// <summary>
        /// 查询指定站点允许绑定的Region信息
        ///
        /// console通过此接口获取指定pop点的全域弹性公网IP允许绑定的region实例信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTenantGeipSupportInstancesResponse ListTenantGeipSupportInstances(ListTenantGeipSupportInstancesRequest listTenantGeipSupportInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("access_site", listTenantGeipSupportInstancesRequest.AccessSite.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/support-instances/{access_site}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantGeipSupportInstancesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTenantGeipSupportInstancesResponse>(response);
        }

        public SyncInvoker<ListTenantGeipSupportInstancesResponse> ListTenantGeipSupportInstancesInvoker(ListTenantGeipSupportInstancesRequest listTenantGeipSupportInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("access_site", listTenantGeipSupportInstancesRequest.AccessSite.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/support-instances/{access_site}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantGeipSupportInstancesRequest);
            return new SyncInvoker<ListTenantGeipSupportInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTenantGeipSupportInstancesResponse>);
        }
        
    }
}