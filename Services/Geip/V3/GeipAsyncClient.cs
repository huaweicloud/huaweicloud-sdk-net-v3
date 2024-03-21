using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Geip.V3.Model;

namespace HuaweiCloud.SDK.Geip.V3
{
    public partial class GeipAsyncClient : Client
    {
        public static ClientBuilder<GeipAsyncClient> NewBuilder()
        {
            return new ClientBuilder<GeipAsyncClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 添加全域公网带宽标签
        ///
        /// 添加全域公网带宽标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddInternetBandwidthTagsResponse> AddInternetBandwidthTagsAsync(AddInternetBandwidthTagsRequest addInternetBandwidthTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", addInternetBandwidthTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/internet-bandwidth/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addInternetBandwidthTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<AddInternetBandwidthTagsResponse>(response);
        }

        public AsyncInvoker<AddInternetBandwidthTagsResponse> AddInternetBandwidthTagsAsyncInvoker(AddInternetBandwidthTagsRequest addInternetBandwidthTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", addInternetBandwidthTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/internet-bandwidth/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addInternetBandwidthTagsRequest);
            return new AsyncInvoker<AddInternetBandwidthTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddInternetBandwidthTagsResponse>);
        }
        
        /// <summary>
        /// 批量创建全域公网带宽
        ///
        /// 批量创建全域公网带宽
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateInternetBandwidthResponse> BatchCreateInternetBandwidthAsync(BatchCreateInternetBandwidthRequest batchCreateInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/internet-bandwidths/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateInternetBandwidthRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchCreateInternetBandwidthResponse>(response);
        }

        public AsyncInvoker<BatchCreateInternetBandwidthResponse> BatchCreateInternetBandwidthAsyncInvoker(BatchCreateInternetBandwidthRequest batchCreateInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/internet-bandwidths/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateInternetBandwidthRequest);
            return new AsyncInvoker<BatchCreateInternetBandwidthResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreateInternetBandwidthResponse>);
        }
        
        /// <summary>
        /// 批量添加全域公网带宽标签
        ///
        /// 批量添加全域公网带宽标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateInternetBandwidthTagsResponse> BatchCreateInternetBandwidthTagsAsync(BatchCreateInternetBandwidthTagsRequest batchCreateInternetBandwidthTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchCreateInternetBandwidthTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/internet-bandwidth/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateInternetBandwidthTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateInternetBandwidthTagsResponse>(response);
        }

        public AsyncInvoker<BatchCreateInternetBandwidthTagsResponse> BatchCreateInternetBandwidthTagsAsyncInvoker(BatchCreateInternetBandwidthTagsRequest batchCreateInternetBandwidthTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchCreateInternetBandwidthTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/internet-bandwidth/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateInternetBandwidthTagsRequest);
            return new AsyncInvoker<BatchCreateInternetBandwidthTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateInternetBandwidthTagsResponse>);
        }
        
        /// <summary>
        /// 批量删除全域公网带宽标签
        ///
        /// 批量删除全域公网带宽标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteInternetBandwidthTagsResponse> BatchDeleteInternetBandwidthTagsAsync(BatchDeleteInternetBandwidthTagsRequest batchDeleteInternetBandwidthTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchDeleteInternetBandwidthTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/internet-bandwidth/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteInternetBandwidthTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteInternetBandwidthTagsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteInternetBandwidthTagsResponse> BatchDeleteInternetBandwidthTagsAsyncInvoker(BatchDeleteInternetBandwidthTagsRequest batchDeleteInternetBandwidthTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchDeleteInternetBandwidthTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/internet-bandwidth/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteInternetBandwidthTagsRequest);
            return new AsyncInvoker<BatchDeleteInternetBandwidthTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteInternetBandwidthTagsResponse>);
        }
        
        /// <summary>
        /// 查询全域公网带宽个数
        ///
        /// 查询全域公网带宽个数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CountInternetBandwidthResponse> CountInternetBandwidthAsync(CountInternetBandwidthRequest countInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/internet-bandwidths/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countInternetBandwidthRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<CountInternetBandwidthResponse>(response);
        }

        public AsyncInvoker<CountInternetBandwidthResponse> CountInternetBandwidthAsyncInvoker(CountInternetBandwidthRequest countInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/internet-bandwidths/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countInternetBandwidthRequest);
            return new AsyncInvoker<CountInternetBandwidthResponse>(this, "GET", request, JsonUtils.DeSerialize<CountInternetBandwidthResponse>);
        }
        
        /// <summary>
        /// 创建全域公网带宽
        ///
        /// 创建全域公网带宽
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInternetBandwidthResponse> CreateInternetBandwidthAsync(CreateInternetBandwidthRequest createInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/internet-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInternetBandwidthRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateInternetBandwidthResponse>(response);
        }

        public AsyncInvoker<CreateInternetBandwidthResponse> CreateInternetBandwidthAsyncInvoker(CreateInternetBandwidthRequest createInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/internet-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInternetBandwidthRequest);
            return new AsyncInvoker<CreateInternetBandwidthResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInternetBandwidthResponse>);
        }
        
        /// <summary>
        /// 创建租户签署免责条款
        ///
        /// 创建租户签署免责条款
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateUserDisclaimerResponse> CreateUserDisclaimerAsync(CreateUserDisclaimerRequest createUserDisclaimerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/user-disclaimer-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUserDisclaimerRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateUserDisclaimerResponse>(response);
        }

        public AsyncInvoker<CreateUserDisclaimerResponse> CreateUserDisclaimerAsyncInvoker(CreateUserDisclaimerRequest createUserDisclaimerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/user-disclaimer-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUserDisclaimerRequest);
            return new AsyncInvoker<CreateUserDisclaimerResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateUserDisclaimerResponse>);
        }
        
        /// <summary>
        /// 删除全域公网带宽
        ///
        /// 删除全域公网带宽
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInternetBandwidthResponse> DeleteInternetBandwidthAsync(DeleteInternetBandwidthRequest deleteInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("internet_bandwidth_id", deleteInternetBandwidthRequest.InternetBandwidthId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/internet-bandwidths/{internet_bandwidth_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInternetBandwidthRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInternetBandwidthResponse>(response);
        }

        public AsyncInvoker<DeleteInternetBandwidthResponse> DeleteInternetBandwidthAsyncInvoker(DeleteInternetBandwidthRequest deleteInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("internet_bandwidth_id", deleteInternetBandwidthRequest.InternetBandwidthId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/internet-bandwidths/{internet_bandwidth_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInternetBandwidthRequest);
            return new AsyncInvoker<DeleteInternetBandwidthResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInternetBandwidthResponse>);
        }
        
        /// <summary>
        /// 删除全域公网带宽标签
        ///
        /// 删除全域公网带宽标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInternetBandwidthTagResponse> DeleteInternetBandwidthTagAsync(DeleteInternetBandwidthTagRequest deleteInternetBandwidthTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", deleteInternetBandwidthTagRequest.ResourceId.ToString());
            urlParam.Add("tag_key", deleteInternetBandwidthTagRequest.TagKey.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/internet-bandwidth/{resource_id}/tags/{tag_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInternetBandwidthTagRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInternetBandwidthTagResponse>(response);
        }

        public AsyncInvoker<DeleteInternetBandwidthTagResponse> DeleteInternetBandwidthTagAsyncInvoker(DeleteInternetBandwidthTagRequest deleteInternetBandwidthTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", deleteInternetBandwidthTagRequest.ResourceId.ToString());
            urlParam.Add("tag_key", deleteInternetBandwidthTagRequest.TagKey.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/internet-bandwidth/{resource_id}/tags/{tag_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInternetBandwidthTagRequest);
            return new AsyncInvoker<DeleteInternetBandwidthTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInternetBandwidthTagResponse>);
        }
        
        /// <summary>
        /// 删除租户撤销免责条款
        ///
        /// 删除租户撤销免责条款
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteUserDisclaimerResponse> DeleteUserDisclaimerAsync(DeleteUserDisclaimerRequest deleteUserDisclaimerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/user-disclaimer-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserDisclaimerRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteUserDisclaimerResponse>(response);
        }

        public AsyncInvoker<DeleteUserDisclaimerResponse> DeleteUserDisclaimerAsyncInvoker(DeleteUserDisclaimerRequest deleteUserDisclaimerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/user-disclaimer-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserDisclaimerRequest);
            return new AsyncInvoker<DeleteUserDisclaimerResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteUserDisclaimerResponse>);
        }
        
        /// <summary>
        /// 查询接入点列表
        ///
        /// 查询接入点列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAccessSitesResponse> ListAccessSitesAsync(ListAccessSitesRequest listAccessSitesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/access-sites", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessSitesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAccessSitesResponse>(response);
        }

        public AsyncInvoker<ListAccessSitesResponse> ListAccessSitesAsyncInvoker(ListAccessSitesRequest listAccessSitesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/access-sites", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessSitesRequest);
            return new AsyncInvoker<ListAccessSitesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAccessSitesResponse>);
        }
        
        /// <summary>
        /// 查询租户全域弹性公网IP配额
        ///
        /// 查询租户全域弹性公网IP配额
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGeipResourceQuotasResponse> ListGeipResourceQuotasAsync(ListGeipResourceQuotasRequest listGeipResourceQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGeipResourceQuotasRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGeipResourceQuotasResponse>(response);
        }

        public AsyncInvoker<ListGeipResourceQuotasResponse> ListGeipResourceQuotasAsyncInvoker(ListGeipResourceQuotasRequest listGeipResourceQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGeipResourceQuotasRequest);
            return new AsyncInvoker<ListGeipResourceQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGeipResourceQuotasResponse>);
        }
        
        /// <summary>
        /// 查询资源实例列表数目
        ///
        /// 查询资源实例列表数目
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInternetBandwidthCountFilterTagsResponse> ListInternetBandwidthCountFilterTagsAsync(ListInternetBandwidthCountFilterTagsRequest listInternetBandwidthCountFilterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/internet-bandwidth/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInternetBandwidthCountFilterTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListInternetBandwidthCountFilterTagsResponse>(response);
        }

        public AsyncInvoker<ListInternetBandwidthCountFilterTagsResponse> ListInternetBandwidthCountFilterTagsAsyncInvoker(ListInternetBandwidthCountFilterTagsRequest listInternetBandwidthCountFilterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/internet-bandwidth/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInternetBandwidthCountFilterTagsRequest);
            return new AsyncInvoker<ListInternetBandwidthCountFilterTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListInternetBandwidthCountFilterTagsResponse>);
        }
        
        /// <summary>
        /// 查询全域公网带宽项目标签
        ///
        /// 查询全域公网带宽项目标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInternetBandwidthDomainTagsResponse> ListInternetBandwidthDomainTagsAsync(ListInternetBandwidthDomainTagsRequest listInternetBandwidthDomainTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/internet-bandwidth/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInternetBandwidthDomainTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInternetBandwidthDomainTagsResponse>(response);
        }

        public AsyncInvoker<ListInternetBandwidthDomainTagsResponse> ListInternetBandwidthDomainTagsAsyncInvoker(ListInternetBandwidthDomainTagsRequest listInternetBandwidthDomainTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/internet-bandwidth/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInternetBandwidthDomainTagsRequest);
            return new AsyncInvoker<ListInternetBandwidthDomainTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInternetBandwidthDomainTagsResponse>);
        }
        
        /// <summary>
        /// 查询资源实例列表
        ///
        /// 查询资源实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInternetBandwidthFilterTagsResponse> ListInternetBandwidthFilterTagsAsync(ListInternetBandwidthFilterTagsRequest listInternetBandwidthFilterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/internet-bandwidth/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInternetBandwidthFilterTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListInternetBandwidthFilterTagsResponse>(response);
        }

        public AsyncInvoker<ListInternetBandwidthFilterTagsResponse> ListInternetBandwidthFilterTagsAsyncInvoker(ListInternetBandwidthFilterTagsRequest listInternetBandwidthFilterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/internet-bandwidth/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInternetBandwidthFilterTagsRequest);
            return new AsyncInvoker<ListInternetBandwidthFilterTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListInternetBandwidthFilterTagsResponse>);
        }
        
        /// <summary>
        /// 全域公网带宽限制列表
        ///
        /// 查询全域公网带宽限制列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInternetBandwidthLimitsResponse> ListInternetBandwidthLimitsAsync(ListInternetBandwidthLimitsRequest listInternetBandwidthLimitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/internet-bandwidth-limits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInternetBandwidthLimitsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInternetBandwidthLimitsResponse>(response);
        }

        public AsyncInvoker<ListInternetBandwidthLimitsResponse> ListInternetBandwidthLimitsAsyncInvoker(ListInternetBandwidthLimitsRequest listInternetBandwidthLimitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/internet-bandwidth-limits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInternetBandwidthLimitsRequest);
            return new AsyncInvoker<ListInternetBandwidthLimitsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInternetBandwidthLimitsResponse>);
        }
        
        /// <summary>
        /// 查询全域公网带宽列表
        ///
        /// 查询全域公网带宽列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInternetBandwidthsResponse> ListInternetBandwidthsAsync(ListInternetBandwidthsRequest listInternetBandwidthsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/internet-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInternetBandwidthsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInternetBandwidthsResponse>(response);
        }

        public AsyncInvoker<ListInternetBandwidthsResponse> ListInternetBandwidthsAsyncInvoker(ListInternetBandwidthsRequest listInternetBandwidthsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/internet-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInternetBandwidthsRequest);
            return new AsyncInvoker<ListInternetBandwidthsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInternetBandwidthsResponse>);
        }
        
        /// <summary>
        /// 查询全域弹性公网IP段支持的掩码列表
        ///
        /// 查询全域弹性公网IP段支持的掩码列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSupportMasksResponse> ListSupportMasksAsync(ListSupportMasksRequest listSupportMasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments/support-masks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSupportMasksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSupportMasksResponse>(response);
        }

        public AsyncInvoker<ListSupportMasksResponse> ListSupportMasksAsyncInvoker(ListSupportMasksRequest listSupportMasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments/support-masks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSupportMasksRequest);
            return new AsyncInvoker<ListSupportMasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSupportMasksResponse>);
        }
        
        /// <summary>
        /// 查询全域公网带宽详情
        ///
        /// 查询全域公网带宽详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInternetBandwidthResponse> ShowInternetBandwidthAsync(ShowInternetBandwidthRequest showInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("internet_bandwidth_id", showInternetBandwidthRequest.InternetBandwidthId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/internet-bandwidths/{internet_bandwidth_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInternetBandwidthRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInternetBandwidthResponse>(response);
        }

        public AsyncInvoker<ShowInternetBandwidthResponse> ShowInternetBandwidthAsyncInvoker(ShowInternetBandwidthRequest showInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("internet_bandwidth_id", showInternetBandwidthRequest.InternetBandwidthId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/internet-bandwidths/{internet_bandwidth_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInternetBandwidthRequest);
            return new AsyncInvoker<ShowInternetBandwidthResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInternetBandwidthResponse>);
        }
        
        /// <summary>
        /// 查询全域公网带宽标签
        ///
        /// 查询全域公网带宽标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInternetBandwidthTagsResponse> ShowInternetBandwidthTagsAsync(ShowInternetBandwidthTagsRequest showInternetBandwidthTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", showInternetBandwidthTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/internet-bandwidth/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInternetBandwidthTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInternetBandwidthTagsResponse>(response);
        }

        public AsyncInvoker<ShowInternetBandwidthTagsResponse> ShowInternetBandwidthTagsAsyncInvoker(ShowInternetBandwidthTagsRequest showInternetBandwidthTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", showInternetBandwidthTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/internet-bandwidth/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInternetBandwidthTagsRequest);
            return new AsyncInvoker<ShowInternetBandwidthTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInternetBandwidthTagsResponse>);
        }
        
        /// <summary>
        /// 查询租户签署免责条款详情
        ///
        /// 查询租户签署免责条款详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowUserDisclaimerResponse> ShowUserDisclaimerAsync(ShowUserDisclaimerRequest showUserDisclaimerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/user-disclaimer-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserDisclaimerRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowUserDisclaimerResponse>(response);
        }

        public AsyncInvoker<ShowUserDisclaimerResponse> ShowUserDisclaimerAsyncInvoker(ShowUserDisclaimerRequest showUserDisclaimerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/user-disclaimer-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserDisclaimerRequest);
            return new AsyncInvoker<ShowUserDisclaimerResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUserDisclaimerResponse>);
        }
        
        /// <summary>
        /// 更新全域公网带宽
        ///
        /// 更新全域公网带宽
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInternetBandwidthResponse> UpdateInternetBandwidthAsync(UpdateInternetBandwidthRequest updateInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("internet_bandwidth_id", updateInternetBandwidthRequest.InternetBandwidthId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/internet-bandwidths/{internet_bandwidth_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInternetBandwidthRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInternetBandwidthResponse>(response);
        }

        public AsyncInvoker<UpdateInternetBandwidthResponse> UpdateInternetBandwidthAsyncInvoker(UpdateInternetBandwidthRequest updateInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("internet_bandwidth_id", updateInternetBandwidthRequest.InternetBandwidthId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/internet-bandwidths/{internet_bandwidth_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInternetBandwidthRequest);
            return new AsyncInvoker<UpdateInternetBandwidthResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInternetBandwidthResponse>);
        }
        
        /// <summary>
        /// 添加全域弹性公网IP段标签
        ///
        /// 添加全域弹性公网IP段的标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddGeipSegmentTagsResponse> AddGeipSegmentTagsAsync(AddGeipSegmentTagsRequest addGeipSegmentTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", addGeipSegmentTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip-segment/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addGeipSegmentTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<AddGeipSegmentTagsResponse>(response);
        }

        public AsyncInvoker<AddGeipSegmentTagsResponse> AddGeipSegmentTagsAsyncInvoker(AddGeipSegmentTagsRequest addGeipSegmentTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", addGeipSegmentTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip-segment/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addGeipSegmentTagsRequest);
            return new AsyncInvoker<AddGeipSegmentTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddGeipSegmentTagsResponse>);
        }
        
        /// <summary>
        /// 添加全域弹性公网IP标签
        ///
        /// 添加全域弹性公网IP的标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddGlobalEipTagsResponse> AddGlobalEipTagsAsync(AddGlobalEipTagsRequest addGlobalEipTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", addGlobalEipTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addGlobalEipTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<AddGlobalEipTagsResponse>(response);
        }

        public AsyncInvoker<AddGlobalEipTagsResponse> AddGlobalEipTagsAsyncInvoker(AddGlobalEipTagsRequest addGlobalEipTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", addGlobalEipTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addGlobalEipTagsRequest);
            return new AsyncInvoker<AddGlobalEipTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddGlobalEipTagsResponse>);
        }
        
        /// <summary>
        /// 全域弹性公网IP段绑定后端实例
        ///
        /// 全域弹性公网IP段绑定后端实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociateGeipSegmentInstanceResponse> AssociateGeipSegmentInstanceAsync(AssociateGeipSegmentInstanceRequest associateGeipSegmentInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_segment_id", associateGeipSegmentInstanceRequest.GlobalEipSegmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments/{global_eip_segment_id}/associate-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateGeipSegmentInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AssociateGeipSegmentInstanceResponse>(response);
        }

        public AsyncInvoker<AssociateGeipSegmentInstanceResponse> AssociateGeipSegmentInstanceAsyncInvoker(AssociateGeipSegmentInstanceRequest associateGeipSegmentInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_segment_id", associateGeipSegmentInstanceRequest.GlobalEipSegmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments/{global_eip_segment_id}/associate-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateGeipSegmentInstanceRequest);
            return new AsyncInvoker<AssociateGeipSegmentInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateGeipSegmentInstanceResponse>);
        }
        
        /// <summary>
        /// 绑定后端实例
        ///
        /// 绑定后端实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociateInstanceResponse> AssociateInstanceAsync(AssociateInstanceRequest associateInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_id", associateInstanceRequest.GlobalEipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/{global_eip_id}/associate-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AssociateInstanceResponse>(response);
        }

        public AsyncInvoker<AssociateInstanceResponse> AssociateInstanceAsyncInvoker(AssociateInstanceRequest associateInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_id", associateInstanceRequest.GlobalEipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/{global_eip_id}/associate-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateInstanceRequest);
            return new AsyncInvoker<AssociateInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateInstanceResponse>);
        }
        
        /// <summary>
        /// 绑定全域公网带宽
        ///
        /// 绑定全域公网带宽
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AttachInternetBandwidthResponse> AttachInternetBandwidthAsync(AttachInternetBandwidthRequest attachInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_id", attachInternetBandwidthRequest.GlobalEipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/{global_eip_id}/attach-internet-bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachInternetBandwidthRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AttachInternetBandwidthResponse>(response);
        }

        public AsyncInvoker<AttachInternetBandwidthResponse> AttachInternetBandwidthAsyncInvoker(AttachInternetBandwidthRequest attachInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_id", attachInternetBandwidthRequest.GlobalEipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/{global_eip_id}/attach-internet-bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachInternetBandwidthRequest);
            return new AsyncInvoker<AttachInternetBandwidthResponse>(this, "POST", request, JsonUtils.DeSerialize<AttachInternetBandwidthResponse>);
        }
        
        /// <summary>
        /// 全域弹性公网IP段批量绑定全域公网带宽
        ///
        /// 全域弹性公网IP段批量绑定全域公网带宽
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchAttachGeipSegmentInternetBandwidthResponse> BatchAttachGeipSegmentInternetBandwidthAsync(BatchAttachGeipSegmentInternetBandwidthRequest batchAttachGeipSegmentInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments/batch-attach-internet-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAttachGeipSegmentInternetBandwidthRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchAttachGeipSegmentInternetBandwidthResponse>(response);
        }

        public AsyncInvoker<BatchAttachGeipSegmentInternetBandwidthResponse> BatchAttachGeipSegmentInternetBandwidthAsyncInvoker(BatchAttachGeipSegmentInternetBandwidthRequest batchAttachGeipSegmentInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments/batch-attach-internet-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAttachGeipSegmentInternetBandwidthRequest);
            return new AsyncInvoker<BatchAttachGeipSegmentInternetBandwidthResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchAttachGeipSegmentInternetBandwidthResponse>);
        }
        
        /// <summary>
        /// 批量绑定全域公网带宽
        ///
        /// 批量绑定全域公网带宽
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchAttachInternetBandwidthResponse> BatchAttachInternetBandwidthAsync(BatchAttachInternetBandwidthRequest batchAttachInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/batch-attach-internet-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAttachInternetBandwidthRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchAttachInternetBandwidthResponse>(response);
        }

        public AsyncInvoker<BatchAttachInternetBandwidthResponse> BatchAttachInternetBandwidthAsyncInvoker(BatchAttachInternetBandwidthRequest batchAttachInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/batch-attach-internet-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchAttachInternetBandwidthRequest);
            return new AsyncInvoker<BatchAttachInternetBandwidthResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchAttachInternetBandwidthResponse>);
        }
        
        /// <summary>
        /// 批量添加全域弹性公网IP段标签
        ///
        /// 批量添加全域弹性公网IP段的标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateGeipSegmentTagsResponse> BatchCreateGeipSegmentTagsAsync(BatchCreateGeipSegmentTagsRequest batchCreateGeipSegmentTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchCreateGeipSegmentTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip-segment/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateGeipSegmentTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateGeipSegmentTagsResponse>(response);
        }

        public AsyncInvoker<BatchCreateGeipSegmentTagsResponse> BatchCreateGeipSegmentTagsAsyncInvoker(BatchCreateGeipSegmentTagsRequest batchCreateGeipSegmentTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchCreateGeipSegmentTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip-segment/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateGeipSegmentTagsRequest);
            return new AsyncInvoker<BatchCreateGeipSegmentTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateGeipSegmentTagsResponse>);
        }
        
        /// <summary>
        /// 批量创建全域弹性公网IP
        ///
        /// 批量创建全域弹性公网IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateGlobalEipResponse> BatchCreateGlobalEipAsync(BatchCreateGlobalEipRequest batchCreateGlobalEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateGlobalEipRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchCreateGlobalEipResponse>(response);
        }

        public AsyncInvoker<BatchCreateGlobalEipResponse> BatchCreateGlobalEipAsyncInvoker(BatchCreateGlobalEipRequest batchCreateGlobalEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateGlobalEipRequest);
            return new AsyncInvoker<BatchCreateGlobalEipResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreateGlobalEipResponse>);
        }
        
        /// <summary>
        /// 批量添加全域弹性公网IP标签
        ///
        /// 批量添加全域弹性公网IP的标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateGlobalEipTagsResponse> BatchCreateGlobalEipTagsAsync(BatchCreateGlobalEipTagsRequest batchCreateGlobalEipTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchCreateGlobalEipTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateGlobalEipTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateGlobalEipTagsResponse>(response);
        }

        public AsyncInvoker<BatchCreateGlobalEipTagsResponse> BatchCreateGlobalEipTagsAsyncInvoker(BatchCreateGlobalEipTagsRequest batchCreateGlobalEipTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchCreateGlobalEipTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateGlobalEipTagsRequest);
            return new AsyncInvoker<BatchCreateGlobalEipTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateGlobalEipTagsResponse>);
        }
        
        /// <summary>
        /// 批量删除全域弹性公网IP段标签
        ///
        /// 批量删除全域弹性公网IP段的标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteGeipSegmentTagsResponse> BatchDeleteGeipSegmentTagsAsync(BatchDeleteGeipSegmentTagsRequest batchDeleteGeipSegmentTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchDeleteGeipSegmentTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip-segment/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteGeipSegmentTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteGeipSegmentTagsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteGeipSegmentTagsResponse> BatchDeleteGeipSegmentTagsAsyncInvoker(BatchDeleteGeipSegmentTagsRequest batchDeleteGeipSegmentTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchDeleteGeipSegmentTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip-segment/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteGeipSegmentTagsRequest);
            return new AsyncInvoker<BatchDeleteGeipSegmentTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteGeipSegmentTagsResponse>);
        }
        
        /// <summary>
        /// 批量删除全域弹性公网IP标签
        ///
        /// 批量删除全域弹性公网IP的标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteGlobalEipTagsResponse> BatchDeleteGlobalEipTagsAsync(BatchDeleteGlobalEipTagsRequest batchDeleteGlobalEipTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchDeleteGlobalEipTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteGlobalEipTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteGlobalEipTagsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteGlobalEipTagsResponse> BatchDeleteGlobalEipTagsAsyncInvoker(BatchDeleteGlobalEipTagsRequest batchDeleteGlobalEipTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchDeleteGlobalEipTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteGlobalEipTagsRequest);
            return new AsyncInvoker<BatchDeleteGlobalEipTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteGlobalEipTagsResponse>);
        }
        
        /// <summary>
        /// 全域弹性公网IP段批量解绑全域公网带宽
        ///
        /// 全域弹性公网IP段批量解绑全域公网带宽
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDetachGeipSegmentInternetBandwidthResponse> BatchDetachGeipSegmentInternetBandwidthAsync(BatchDetachGeipSegmentInternetBandwidthRequest batchDetachGeipSegmentInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments/batch-detach-internet-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDetachGeipSegmentInternetBandwidthRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchDetachGeipSegmentInternetBandwidthResponse>(response);
        }

        public AsyncInvoker<BatchDetachGeipSegmentInternetBandwidthResponse> BatchDetachGeipSegmentInternetBandwidthAsyncInvoker(BatchDetachGeipSegmentInternetBandwidthRequest batchDetachGeipSegmentInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments/batch-detach-internet-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDetachGeipSegmentInternetBandwidthRequest);
            return new AsyncInvoker<BatchDetachGeipSegmentInternetBandwidthResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDetachGeipSegmentInternetBandwidthResponse>);
        }
        
        /// <summary>
        /// 批量解绑全域公网带宽
        ///
        /// 批量解绑全域公网带宽
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDetachInternetBandwidthResponse> BatchDetachInternetBandwidthAsync(BatchDetachInternetBandwidthRequest batchDetachInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/batch-detach-internet-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDetachInternetBandwidthRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDetachInternetBandwidthResponse>(response);
        }

        public AsyncInvoker<BatchDetachInternetBandwidthResponse> BatchDetachInternetBandwidthAsyncInvoker(BatchDetachInternetBandwidthRequest batchDetachInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/batch-detach-internet-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDetachInternetBandwidthRequest);
            return new AsyncInvoker<BatchDetachInternetBandwidthResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDetachInternetBandwidthResponse>);
        }
        
        /// <summary>
        /// 查询全域弹性公网IP段个数
        ///
        /// 查询全域弹性公网IP段个数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CountGlobalEipSegmentResponse> CountGlobalEipSegmentAsync(CountGlobalEipSegmentRequest countGlobalEipSegmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countGlobalEipSegmentRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<CountGlobalEipSegmentResponse>(response);
        }

        public AsyncInvoker<CountGlobalEipSegmentResponse> CountGlobalEipSegmentAsyncInvoker(CountGlobalEipSegmentRequest countGlobalEipSegmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countGlobalEipSegmentRequest);
            return new AsyncInvoker<CountGlobalEipSegmentResponse>(this, "GET", request, JsonUtils.DeSerialize<CountGlobalEipSegmentResponse>);
        }
        
        /// <summary>
        /// 查询全域弹性公网IP个数
        ///
        /// 查询全域弹性公网IP个数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CountGlobalEipsResponse> CountGlobalEipsAsync(CountGlobalEipsRequest countGlobalEipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countGlobalEipsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<CountGlobalEipsResponse>(response);
        }

        public AsyncInvoker<CountGlobalEipsResponse> CountGlobalEipsAsyncInvoker(CountGlobalEipsRequest countGlobalEipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countGlobalEipsRequest);
            return new AsyncInvoker<CountGlobalEipsResponse>(this, "GET", request, JsonUtils.DeSerialize<CountGlobalEipsResponse>);
        }
        
        /// <summary>
        /// 创建全域弹性公网IP
        ///
        /// 创建全域弹性公网IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateGlobalEipResponse> CreateGlobalEipAsync(CreateGlobalEipRequest createGlobalEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGlobalEipRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateGlobalEipResponse>(response);
        }

        public AsyncInvoker<CreateGlobalEipResponse> CreateGlobalEipAsyncInvoker(CreateGlobalEipRequest createGlobalEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGlobalEipRequest);
            return new AsyncInvoker<CreateGlobalEipResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGlobalEipResponse>);
        }
        
        /// <summary>
        /// 创建全域弹性公网IP段
        ///
        /// 创建全域弹性公网IP段
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateGlobalEipSegmentResponse> CreateGlobalEipSegmentAsync(CreateGlobalEipSegmentRequest createGlobalEipSegmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGlobalEipSegmentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateGlobalEipSegmentResponse>(response);
        }

        public AsyncInvoker<CreateGlobalEipSegmentResponse> CreateGlobalEipSegmentAsyncInvoker(CreateGlobalEipSegmentRequest createGlobalEipSegmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGlobalEipSegmentRequest);
            return new AsyncInvoker<CreateGlobalEipSegmentResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGlobalEipSegmentResponse>);
        }
        
        /// <summary>
        /// 删除全域弹性公网IP段标签
        ///
        /// 删除全域弹性公网IP段的标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteGeipSegmentTagResponse> DeleteGeipSegmentTagAsync(DeleteGeipSegmentTagRequest deleteGeipSegmentTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", deleteGeipSegmentTagRequest.ResourceId.ToString());
            urlParam.Add("tag_key", deleteGeipSegmentTagRequest.TagKey.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip-segment/{resource_id}/tags/{tag_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGeipSegmentTagRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteGeipSegmentTagResponse>(response);
        }

        public AsyncInvoker<DeleteGeipSegmentTagResponse> DeleteGeipSegmentTagAsyncInvoker(DeleteGeipSegmentTagRequest deleteGeipSegmentTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", deleteGeipSegmentTagRequest.ResourceId.ToString());
            urlParam.Add("tag_key", deleteGeipSegmentTagRequest.TagKey.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip-segment/{resource_id}/tags/{tag_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGeipSegmentTagRequest);
            return new AsyncInvoker<DeleteGeipSegmentTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteGeipSegmentTagResponse>);
        }
        
        /// <summary>
        /// 删除全域弹性公网IP
        ///
        /// 删除全域弹性公网IP
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteGlobalEipResponse> DeleteGlobalEipAsync(DeleteGlobalEipRequest deleteGlobalEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_id", deleteGlobalEipRequest.GlobalEipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/{global_eip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGlobalEipRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteGlobalEipResponse>(response);
        }

        public AsyncInvoker<DeleteGlobalEipResponse> DeleteGlobalEipAsyncInvoker(DeleteGlobalEipRequest deleteGlobalEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_id", deleteGlobalEipRequest.GlobalEipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/{global_eip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGlobalEipRequest);
            return new AsyncInvoker<DeleteGlobalEipResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteGlobalEipResponse>);
        }
        
        /// <summary>
        /// 删除全域弹性公网IP段
        ///
        /// 删除全域弹性公网IP段
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteGlobalEipSegmentResponse> DeleteGlobalEipSegmentAsync(DeleteGlobalEipSegmentRequest deleteGlobalEipSegmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_segment_id", deleteGlobalEipSegmentRequest.GlobalEipSegmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments/{global_eip_segment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGlobalEipSegmentRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteGlobalEipSegmentResponse>(response);
        }

        public AsyncInvoker<DeleteGlobalEipSegmentResponse> DeleteGlobalEipSegmentAsyncInvoker(DeleteGlobalEipSegmentRequest deleteGlobalEipSegmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_segment_id", deleteGlobalEipSegmentRequest.GlobalEipSegmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments/{global_eip_segment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGlobalEipSegmentRequest);
            return new AsyncInvoker<DeleteGlobalEipSegmentResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteGlobalEipSegmentResponse>);
        }
        
        /// <summary>
        /// 删除全域弹性公网IP标签
        ///
        /// 删除全域弹性公网IP的标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteGlobalEipTagResponse> DeleteGlobalEipTagAsync(DeleteGlobalEipTagRequest deleteGlobalEipTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", deleteGlobalEipTagRequest.ResourceId.ToString());
            urlParam.Add("tag_key", deleteGlobalEipTagRequest.TagKey.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip/{resource_id}/tags/{tag_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGlobalEipTagRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteGlobalEipTagResponse>(response);
        }

        public AsyncInvoker<DeleteGlobalEipTagResponse> DeleteGlobalEipTagAsyncInvoker(DeleteGlobalEipTagRequest deleteGlobalEipTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", deleteGlobalEipTagRequest.ResourceId.ToString());
            urlParam.Add("tag_key", deleteGlobalEipTagRequest.TagKey.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip/{resource_id}/tags/{tag_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGlobalEipTagRequest);
            return new AsyncInvoker<DeleteGlobalEipTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteGlobalEipTagResponse>);
        }
        
        /// <summary>
        /// 解绑全域公网带宽
        ///
        /// 解绑全域公网带宽
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DetachInternetBandwidthResponse> DetachInternetBandwidthAsync(DetachInternetBandwidthRequest detachInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_id", detachInternetBandwidthRequest.GlobalEipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/{global_eip_id}/detach-internet-bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachInternetBandwidthRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DetachInternetBandwidthResponse>(response);
        }

        public AsyncInvoker<DetachInternetBandwidthResponse> DetachInternetBandwidthAsyncInvoker(DetachInternetBandwidthRequest detachInternetBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_id", detachInternetBandwidthRequest.GlobalEipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/{global_eip_id}/detach-internet-bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", detachInternetBandwidthRequest);
            return new AsyncInvoker<DetachInternetBandwidthResponse>(this, "POST", request, JsonUtils.DeSerialize<DetachInternetBandwidthResponse>);
        }
        
        /// <summary>
        /// 全域弹性公网IP段解绑后端实例
        ///
        /// 全域弹性公网IP段解绑后端实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisassociateGeipSegmentInstanceResponse> DisassociateGeipSegmentInstanceAsync(DisassociateGeipSegmentInstanceRequest disassociateGeipSegmentInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_segment_id", disassociateGeipSegmentInstanceRequest.GlobalEipSegmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments/{global_eip_segment_id}/disassociate-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateGeipSegmentInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DisassociateGeipSegmentInstanceResponse>(response);
        }

        public AsyncInvoker<DisassociateGeipSegmentInstanceResponse> DisassociateGeipSegmentInstanceAsyncInvoker(DisassociateGeipSegmentInstanceRequest disassociateGeipSegmentInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_segment_id", disassociateGeipSegmentInstanceRequest.GlobalEipSegmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments/{global_eip_segment_id}/disassociate-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateGeipSegmentInstanceRequest);
            return new AsyncInvoker<DisassociateGeipSegmentInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<DisassociateGeipSegmentInstanceResponse>);
        }
        
        /// <summary>
        /// 解绑后端实例
        ///
        /// 解绑后端实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisassociateInstanceResponse> DisassociateInstanceAsync(DisassociateInstanceRequest disassociateInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_id", disassociateInstanceRequest.GlobalEipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/{global_eip_id}/disassociate-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DisassociateInstanceResponse>(response);
        }

        public AsyncInvoker<DisassociateInstanceResponse> DisassociateInstanceAsyncInvoker(DisassociateInstanceRequest disassociateInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_id", disassociateInstanceRequest.GlobalEipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/{global_eip_id}/disassociate-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateInstanceRequest);
            return new AsyncInvoker<DisassociateInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<DisassociateInstanceResponse>);
        }
        
        /// <summary>
        /// 查询全域弹性公网IP池列表
        ///
        /// 查询全域弹性公网IP池列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGeipPoolsResponse> ListGeipPoolsAsync(ListGeipPoolsRequest listGeipPoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/geip-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGeipPoolsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGeipPoolsResponse>(response);
        }

        public AsyncInvoker<ListGeipPoolsResponse> ListGeipPoolsAsyncInvoker(ListGeipPoolsRequest listGeipPoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/geip-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGeipPoolsRequest);
            return new AsyncInvoker<ListGeipPoolsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGeipPoolsResponse>);
        }
        
        /// <summary>
        /// 查询资源实例列表数目
        ///
        /// 查询资源实例列表的数目
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGeipSegmentCountFilterTagsResponse> ListGeipSegmentCountFilterTagsAsync(ListGeipSegmentCountFilterTagsRequest listGeipSegmentCountFilterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip-segment/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGeipSegmentCountFilterTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListGeipSegmentCountFilterTagsResponse>(response);
        }

        public AsyncInvoker<ListGeipSegmentCountFilterTagsResponse> ListGeipSegmentCountFilterTagsAsyncInvoker(ListGeipSegmentCountFilterTagsRequest listGeipSegmentCountFilterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip-segment/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGeipSegmentCountFilterTagsRequest);
            return new AsyncInvoker<ListGeipSegmentCountFilterTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListGeipSegmentCountFilterTagsResponse>);
        }
        
        /// <summary>
        /// 查询全域弹性公网IP段项目标签
        ///
        /// 查询全域弹性公网IP段的项目标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGeipSegmentDomainTagsResponse> ListGeipSegmentDomainTagsAsync(ListGeipSegmentDomainTagsRequest listGeipSegmentDomainTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip-segment/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGeipSegmentDomainTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGeipSegmentDomainTagsResponse>(response);
        }

        public AsyncInvoker<ListGeipSegmentDomainTagsResponse> ListGeipSegmentDomainTagsAsyncInvoker(ListGeipSegmentDomainTagsRequest listGeipSegmentDomainTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip-segment/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGeipSegmentDomainTagsRequest);
            return new AsyncInvoker<ListGeipSegmentDomainTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGeipSegmentDomainTagsResponse>);
        }
        
        /// <summary>
        /// 查询资源实例列表
        ///
        /// 查询资源实例的列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGeipSegmentFilterTagsResponse> ListGeipSegmentFilterTagsAsync(ListGeipSegmentFilterTagsRequest listGeipSegmentFilterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip-segment/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGeipSegmentFilterTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListGeipSegmentFilterTagsResponse>(response);
        }

        public AsyncInvoker<ListGeipSegmentFilterTagsResponse> ListGeipSegmentFilterTagsAsyncInvoker(ListGeipSegmentFilterTagsRequest listGeipSegmentFilterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip-segment/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGeipSegmentFilterTagsRequest);
            return new AsyncInvoker<ListGeipSegmentFilterTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListGeipSegmentFilterTagsResponse>);
        }
        
        /// <summary>
        /// 查询资源实例列表数目
        ///
        /// 查询资源实例列表数目
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGlobalEipCountFilterTagsResponse> ListGlobalEipCountFilterTagsAsync(ListGlobalEipCountFilterTagsRequest listGlobalEipCountFilterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalEipCountFilterTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListGlobalEipCountFilterTagsResponse>(response);
        }

        public AsyncInvoker<ListGlobalEipCountFilterTagsResponse> ListGlobalEipCountFilterTagsAsyncInvoker(ListGlobalEipCountFilterTagsRequest listGlobalEipCountFilterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalEipCountFilterTagsRequest);
            return new AsyncInvoker<ListGlobalEipCountFilterTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListGlobalEipCountFilterTagsResponse>);
        }
        
        /// <summary>
        /// 查询全域弹性公网IP项目标签
        ///
        /// 查询全域弹性公网IP的项目标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGlobalEipDomainTagsResponse> ListGlobalEipDomainTagsAsync(ListGlobalEipDomainTagsRequest listGlobalEipDomainTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalEipDomainTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGlobalEipDomainTagsResponse>(response);
        }

        public AsyncInvoker<ListGlobalEipDomainTagsResponse> ListGlobalEipDomainTagsAsyncInvoker(ListGlobalEipDomainTagsRequest listGlobalEipDomainTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalEipDomainTagsRequest);
            return new AsyncInvoker<ListGlobalEipDomainTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGlobalEipDomainTagsResponse>);
        }
        
        /// <summary>
        /// 查询资源实例列表
        ///
        /// 查询资源实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGlobalEipFilterTagsResponse> ListGlobalEipFilterTagsAsync(ListGlobalEipFilterTagsRequest listGlobalEipFilterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalEipFilterTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListGlobalEipFilterTagsResponse>(response);
        }

        public AsyncInvoker<ListGlobalEipFilterTagsResponse> ListGlobalEipFilterTagsAsyncInvoker(ListGlobalEipFilterTagsRequest listGlobalEipFilterTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalEipFilterTagsRequest);
            return new AsyncInvoker<ListGlobalEipFilterTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListGlobalEipFilterTagsResponse>);
        }
        
        /// <summary>
        /// 查询全域弹性公网IP段列表
        ///
        /// 查询全域弹性公网IP段列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGlobalEipSegmentsResponse> ListGlobalEipSegmentsAsync(ListGlobalEipSegmentsRequest listGlobalEipSegmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalEipSegmentsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGlobalEipSegmentsResponse>(response);
        }

        public AsyncInvoker<ListGlobalEipSegmentsResponse> ListGlobalEipSegmentsAsyncInvoker(ListGlobalEipSegmentsRequest listGlobalEipSegmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalEipSegmentsRequest);
            return new AsyncInvoker<ListGlobalEipSegmentsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGlobalEipSegmentsResponse>);
        }
        
        /// <summary>
        /// 查询全域弹性公网IP列表
        ///
        /// 查询全域弹性公网IP列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGlobalEipsResponse> ListGlobalEipsAsync(ListGlobalEipsRequest listGlobalEipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalEipsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGlobalEipsResponse>(response);
        }

        public AsyncInvoker<ListGlobalEipsResponse> ListGlobalEipsAsyncInvoker(ListGlobalEipsRequest listGlobalEipsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalEipsRequest);
            return new AsyncInvoker<ListGlobalEipsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGlobalEipsResponse>);
        }
        
        /// <summary>
        /// 查询全域弹性公网IP段标签
        ///
        /// 查询全域弹性公网IP段的标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowGeipSegmentTagsResponse> ShowGeipSegmentTagsAsync(ShowGeipSegmentTagsRequest showGeipSegmentTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", showGeipSegmentTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip-segment/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGeipSegmentTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowGeipSegmentTagsResponse>(response);
        }

        public AsyncInvoker<ShowGeipSegmentTagsResponse> ShowGeipSegmentTagsAsyncInvoker(ShowGeipSegmentTagsRequest showGeipSegmentTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", showGeipSegmentTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip-segment/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGeipSegmentTagsRequest);
            return new AsyncInvoker<ShowGeipSegmentTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGeipSegmentTagsResponse>);
        }
        
        /// <summary>
        /// 查询全域弹性公网IP详情
        ///
        /// 查询全域弹性公网IP详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowGlobalEipResponse> ShowGlobalEipAsync(ShowGlobalEipRequest showGlobalEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_id", showGlobalEipRequest.GlobalEipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/{global_eip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGlobalEipRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowGlobalEipResponse>(response);
        }

        public AsyncInvoker<ShowGlobalEipResponse> ShowGlobalEipAsyncInvoker(ShowGlobalEipRequest showGlobalEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_id", showGlobalEipRequest.GlobalEipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/{global_eip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGlobalEipRequest);
            return new AsyncInvoker<ShowGlobalEipResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGlobalEipResponse>);
        }
        
        /// <summary>
        /// 查询全域弹性公网IP段详情
        ///
        /// 查询全域弹性公网IP段详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowGlobalEipSegmentResponse> ShowGlobalEipSegmentAsync(ShowGlobalEipSegmentRequest showGlobalEipSegmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_segment_id", showGlobalEipSegmentRequest.GlobalEipSegmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments/{global_eip_segment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGlobalEipSegmentRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowGlobalEipSegmentResponse>(response);
        }

        public AsyncInvoker<ShowGlobalEipSegmentResponse> ShowGlobalEipSegmentAsyncInvoker(ShowGlobalEipSegmentRequest showGlobalEipSegmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_segment_id", showGlobalEipSegmentRequest.GlobalEipSegmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments/{global_eip_segment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGlobalEipSegmentRequest);
            return new AsyncInvoker<ShowGlobalEipSegmentResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGlobalEipSegmentResponse>);
        }
        
        /// <summary>
        /// 查询全域弹性公网IP标签
        ///
        /// 查询全域弹性公网IP的标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowGlobalEipTagsResponse> ShowGlobalEipTagsAsync(ShowGlobalEipTagsRequest showGlobalEipTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", showGlobalEipTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGlobalEipTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowGlobalEipTagsResponse>(response);
        }

        public AsyncInvoker<ShowGlobalEipTagsResponse> ShowGlobalEipTagsAsyncInvoker(ShowGlobalEipTagsRequest showGlobalEipTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", showGlobalEipTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/global-eip/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGlobalEipTagsRequest);
            return new AsyncInvoker<ShowGlobalEipTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGlobalEipTagsResponse>);
        }
        
        /// <summary>
        /// 更新全域弹性公网IP信息
        ///
        /// 更新全域弹性公网IP信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateGlobalEipResponse> UpdateGlobalEipAsync(UpdateGlobalEipRequest updateGlobalEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_id", updateGlobalEipRequest.GlobalEipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/{global_eip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGlobalEipRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGlobalEipResponse>(response);
        }

        public AsyncInvoker<UpdateGlobalEipResponse> UpdateGlobalEipAsyncInvoker(UpdateGlobalEipRequest updateGlobalEipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_id", updateGlobalEipRequest.GlobalEipId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/{global_eip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGlobalEipRequest);
            return new AsyncInvoker<UpdateGlobalEipResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGlobalEipResponse>);
        }
        
        /// <summary>
        /// 更新全域弹性公网IP段
        ///
        /// 更新全域弹性公网IP段
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateGlobalEipSegmentResponse> UpdateGlobalEipSegmentAsync(UpdateGlobalEipSegmentRequest updateGlobalEipSegmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_segment_id", updateGlobalEipSegmentRequest.GlobalEipSegmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments/{global_eip_segment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGlobalEipSegmentRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGlobalEipSegmentResponse>(response);
        }

        public AsyncInvoker<UpdateGlobalEipSegmentResponse> UpdateGlobalEipSegmentAsyncInvoker(UpdateGlobalEipSegmentRequest updateGlobalEipSegmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("global_eip_segment_id", updateGlobalEipSegmentRequest.GlobalEipSegmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eip-segments/{global_eip_segment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGlobalEipSegmentRequest);
            return new AsyncInvoker<UpdateGlobalEipSegmentResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGlobalEipSegmentResponse>);
        }
        
        /// <summary>
        /// 查询Job列表
        ///
        /// 查询Job列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListJobsResponse> ListJobsAsync(ListJobsRequest listJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListJobsResponse>(response);
        }

        public AsyncInvoker<ListJobsResponse> ListJobsAsyncInvoker(ListJobsRequest listJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobsRequest);
            return new AsyncInvoker<ListJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListJobsResponse>);
        }
        
        /// <summary>
        /// 查询Job详情
        ///
        /// 查询Job详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowJobsResponse> ShowJobsAsync(ShowJobsRequest showJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowJobsResponse>(response);
        }

        public AsyncInvoker<ShowJobsResponse> ShowJobsAsyncInvoker(ShowJobsRequest showJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobsRequest);
            return new AsyncInvoker<ShowJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobsResponse>);
        }
        
        /// <summary>
        /// 全域弹性公网IP支持绑定的Region限制
        ///
        /// 全域弹性公网IP支持绑定的Region限制
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSupportRegionsResponse> ListSupportRegionsAsync(ListSupportRegionsRequest listSupportRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/support-regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSupportRegionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSupportRegionsResponse>(response);
        }

        public AsyncInvoker<ListSupportRegionsResponse> ListSupportRegionsAsyncInvoker(ListSupportRegionsRequest listSupportRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/geip/support-regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSupportRegionsRequest);
            return new AsyncInvoker<ListSupportRegionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSupportRegionsResponse>);
        }
        
        /// <summary>
        /// 查询指定站点允许绑定的Region信息
        ///
        /// console通过此接口获取指定pop点的全域弹性公网IP允许绑定的region实例信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTenantGeipSupportInstancesResponse> ListTenantGeipSupportInstancesAsync(ListTenantGeipSupportInstancesRequest listTenantGeipSupportInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("access_site", listTenantGeipSupportInstancesRequest.AccessSite.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/support-instances/{access_site}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantGeipSupportInstancesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTenantGeipSupportInstancesResponse>(response);
        }

        public AsyncInvoker<ListTenantGeipSupportInstancesResponse> ListTenantGeipSupportInstancesAsyncInvoker(ListTenantGeipSupportInstancesRequest listTenantGeipSupportInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("access_site", listTenantGeipSupportInstancesRequest.AccessSite.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/global-eips/support-instances/{access_site}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantGeipSupportInstancesRequest);
            return new AsyncInvoker<ListTenantGeipSupportInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTenantGeipSupportInstancesResponse>);
        }
        
    }
}