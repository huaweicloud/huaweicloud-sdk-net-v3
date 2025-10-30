using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.CloudPond.V1.Model;

namespace HuaweiCloud.SDK.CloudPond.V1
{
    public partial class CloudPondAsyncClient : Client
    {
        public static ClientBuilder<CloudPondAsyncClient> NewBuilder()
        {
            return new ClientBuilder<CloudPondAsyncClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 创建边缘小站
        ///
        /// 创建边缘小站。
        /// - 一个边缘小站关联一个华为云指定的区域。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateEdgeSiteResponse> CreateEdgeSiteAsync(CreateEdgeSiteRequest createEdgeSiteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/edge-sites", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEdgeSiteRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateEdgeSiteResponse>(response);
        }

        public AsyncInvoker<CreateEdgeSiteResponse> CreateEdgeSiteAsyncInvoker(CreateEdgeSiteRequest createEdgeSiteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/edge-sites", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEdgeSiteRequest);
            return new AsyncInvoker<CreateEdgeSiteResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateEdgeSiteResponse>);
        }
        
        /// <summary>
        /// 删除边缘小站
        ///
        /// 删除指定的边缘小站。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteEdgeSiteResponse> DeleteEdgeSiteAsync(DeleteEdgeSiteRequest deleteEdgeSiteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteEdgeSiteRequest.SiteId, out var valueOfSiteId)) urlParam.Add("site_id", valueOfSiteId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/edge-sites/{site_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEdgeSiteRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteEdgeSiteResponse>(response);
        }

        public AsyncInvoker<DeleteEdgeSiteResponse> DeleteEdgeSiteAsyncInvoker(DeleteEdgeSiteRequest deleteEdgeSiteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteEdgeSiteRequest.SiteId, out var valueOfSiteId)) urlParam.Add("site_id", valueOfSiteId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/edge-sites/{site_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEdgeSiteRequest);
            return new AsyncInvoker<DeleteEdgeSiteResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteEdgeSiteResponse>);
        }
        
        /// <summary>
        /// 查询边缘小站列表
        ///
        /// 查询边缘小站列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEdgeSitesResponse> ListEdgeSitesAsync(ListEdgeSitesRequest listEdgeSitesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/edge-sites", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEdgeSitesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListEdgeSitesResponse>(response);
        }

        public AsyncInvoker<ListEdgeSitesResponse> ListEdgeSitesAsyncInvoker(ListEdgeSitesRequest listEdgeSitesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/edge-sites", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEdgeSitesRequest);
            return new AsyncInvoker<ListEdgeSitesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEdgeSitesResponse>);
        }
        
        /// <summary>
        /// 查询边缘小站详情
        ///
        /// 查询边缘小站详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowEdgeSiteResponse> ShowEdgeSiteAsync(ShowEdgeSiteRequest showEdgeSiteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showEdgeSiteRequest.SiteId, out var valueOfSiteId)) urlParam.Add("site_id", valueOfSiteId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/edge-sites/{site_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEdgeSiteRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowEdgeSiteResponse>(response);
        }

        public AsyncInvoker<ShowEdgeSiteResponse> ShowEdgeSiteAsyncInvoker(ShowEdgeSiteRequest showEdgeSiteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showEdgeSiteRequest.SiteId, out var valueOfSiteId)) urlParam.Add("site_id", valueOfSiteId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/edge-sites/{site_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEdgeSiteRequest);
            return new AsyncInvoker<ShowEdgeSiteResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEdgeSiteResponse>);
        }
        
        /// <summary>
        /// 更新边缘小站
        ///
        /// 更新边缘小站。
        /// - 允许更新边缘小站描述或场地信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateEdgeSiteResponse> UpdateEdgeSiteAsync(UpdateEdgeSiteRequest updateEdgeSiteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateEdgeSiteRequest.SiteId, out var valueOfSiteId)) urlParam.Add("site_id", valueOfSiteId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/edge-sites/{site_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEdgeSiteRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateEdgeSiteResponse>(response);
        }

        public AsyncInvoker<UpdateEdgeSiteResponse> UpdateEdgeSiteAsyncInvoker(UpdateEdgeSiteRequest updateEdgeSiteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateEdgeSiteRequest.SiteId, out var valueOfSiteId)) urlParam.Add("site_id", valueOfSiteId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/edge-sites/{site_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEdgeSiteRequest);
            return new AsyncInvoker<UpdateEdgeSiteResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateEdgeSiteResponse>);
        }
        
        /// <summary>
        /// 查看站点容量信息
        ///
        /// 查看站点容量信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEdgeSiteMetricsResponse> ListEdgeSiteMetricsAsync(ListEdgeSiteMetricsRequest listEdgeSiteMetricsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEdgeSiteMetricsRequest.SiteId, out var valueOfSiteId)) urlParam.Add("site_id", valueOfSiteId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/edge-sites/{site_id}/metric-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEdgeSiteMetricsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListEdgeSiteMetricsResponse>(response);
        }

        public AsyncInvoker<ListEdgeSiteMetricsResponse> ListEdgeSiteMetricsAsyncInvoker(ListEdgeSiteMetricsRequest listEdgeSiteMetricsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEdgeSiteMetricsRequest.SiteId, out var valueOfSiteId)) urlParam.Add("site_id", valueOfSiteId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/edge-sites/{site_id}/metric-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEdgeSiteMetricsRequest);
            return new AsyncInvoker<ListEdgeSiteMetricsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEdgeSiteMetricsResponse>);
        }
        
        /// <summary>
        /// 查询配额
        ///
        /// 查询租户资源配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListQuotasResponse> ListQuotasAsync(ListQuotasRequest listQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotasRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListQuotasResponse>(response);
        }

        public AsyncInvoker<ListQuotasResponse> ListQuotasAsyncInvoker(ListQuotasRequest listQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotasRequest);
            return new AsyncInvoker<ListQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListQuotasResponse>);
        }
        
        /// <summary>
        /// 查询机柜列表
        ///
        /// 查询机柜列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRacksResponse> ListRacksAsync(ListRacksRequest listRacksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/racks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRacksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRacksResponse>(response);
        }

        public AsyncInvoker<ListRacksResponse> ListRacksAsyncInvoker(ListRacksRequest listRacksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/racks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRacksRequest);
            return new AsyncInvoker<ListRacksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRacksResponse>);
        }
        
        /// <summary>
        /// 查询机柜详情
        ///
        /// 查询机柜详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRackResponse> ShowRackAsync(ShowRackRequest showRackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRackRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/racks/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRackRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRackResponse>(response);
        }

        public AsyncInvoker<ShowRackResponse> ShowRackAsyncInvoker(ShowRackRequest showRackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRackRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/racks/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRackRequest);
            return new AsyncInvoker<ShowRackResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRackResponse>);
        }
        
        /// <summary>
        /// 查询支持的区域列表
        ///
        /// 查询支持CloudPond接入的华为云区域（region）列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSupportedRegionsResponse> ListSupportedRegionsAsync(ListSupportedRegionsRequest listSupportedRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSupportedRegionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSupportedRegionsResponse>(response);
        }

        public AsyncInvoker<ListSupportedRegionsResponse> ListSupportedRegionsAsyncInvoker(ListSupportedRegionsRequest listSupportedRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSupportedRegionsRequest);
            return new AsyncInvoker<ListSupportedRegionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSupportedRegionsResponse>);
        }
        
        /// <summary>
        /// 查询存储池列表
        ///
        /// 查询存储池列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListStoragePoolsResponse> ListStoragePoolsAsync(ListStoragePoolsRequest listStoragePoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/storage-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStoragePoolsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListStoragePoolsResponse>(response);
        }

        public AsyncInvoker<ListStoragePoolsResponse> ListStoragePoolsAsyncInvoker(ListStoragePoolsRequest listStoragePoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/storage-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStoragePoolsRequest);
            return new AsyncInvoker<ListStoragePoolsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStoragePoolsResponse>);
        }
        
        /// <summary>
        /// 查询存储池详情
        ///
        /// 查询存储池详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowStoragePoolResponse> ShowStoragePoolAsync(ShowStoragePoolRequest showStoragePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showStoragePoolRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/storage-pools/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStoragePoolRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowStoragePoolResponse>(response);
        }

        public AsyncInvoker<ShowStoragePoolResponse> ShowStoragePoolAsyncInvoker(ShowStoragePoolRequest showStoragePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showStoragePoolRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/storage-pools/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStoragePoolRequest);
            return new AsyncInvoker<ShowStoragePoolResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStoragePoolResponse>);
        }
        
        /// <summary>
        /// 查询支持的地区列表
        ///
        /// 查询支持CloudPond接入的华为云地区列表。
        /// - 该接口支持企业项目细粒度权限的校验，具体细粒度请参见 ies:zone:list
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSupportedZonesResponse> ListSupportedZonesAsync(ListSupportedZonesRequest listSupportedZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSupportedZonesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSupportedZonesResponse>(response);
        }

        public AsyncInvoker<ListSupportedZonesResponse> ListSupportedZonesAsyncInvoker(ListSupportedZonesRequest listSupportedZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSupportedZonesRequest);
            return new AsyncInvoker<ListSupportedZonesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSupportedZonesResponse>);
        }
        
    }
}