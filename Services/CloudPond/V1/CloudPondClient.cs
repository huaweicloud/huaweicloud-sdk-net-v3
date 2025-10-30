using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.CloudPond.V1.Model;

namespace HuaweiCloud.SDK.CloudPond.V1
{
    public partial class CloudPondClient : Client
    {
        public static ClientBuilder<CloudPondClient> NewBuilder()
        {
            return new ClientBuilder<CloudPondClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 创建边缘小站
        ///
        /// 创建边缘小站。
        /// - 一个边缘小站关联一个华为云指定的区域。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateEdgeSiteResponse CreateEdgeSite(CreateEdgeSiteRequest createEdgeSiteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/edge-sites", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEdgeSiteRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateEdgeSiteResponse>(response);
        }

        public SyncInvoker<CreateEdgeSiteResponse> CreateEdgeSiteInvoker(CreateEdgeSiteRequest createEdgeSiteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/edge-sites", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEdgeSiteRequest);
            return new SyncInvoker<CreateEdgeSiteResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateEdgeSiteResponse>);
        }
        
        /// <summary>
        /// 删除边缘小站
        ///
        /// 删除指定的边缘小站。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteEdgeSiteResponse DeleteEdgeSite(DeleteEdgeSiteRequest deleteEdgeSiteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteEdgeSiteRequest.SiteId, out var valueOfSiteId)) urlParam.Add("site_id", valueOfSiteId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/edge-sites/{site_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEdgeSiteRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteEdgeSiteResponse>(response);
        }

        public SyncInvoker<DeleteEdgeSiteResponse> DeleteEdgeSiteInvoker(DeleteEdgeSiteRequest deleteEdgeSiteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteEdgeSiteRequest.SiteId, out var valueOfSiteId)) urlParam.Add("site_id", valueOfSiteId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/edge-sites/{site_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEdgeSiteRequest);
            return new SyncInvoker<DeleteEdgeSiteResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteEdgeSiteResponse>);
        }
        
        /// <summary>
        /// 查询边缘小站列表
        ///
        /// 查询边缘小站列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEdgeSitesResponse ListEdgeSites(ListEdgeSitesRequest listEdgeSitesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/edge-sites", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEdgeSitesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEdgeSitesResponse>(response);
        }

        public SyncInvoker<ListEdgeSitesResponse> ListEdgeSitesInvoker(ListEdgeSitesRequest listEdgeSitesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/edge-sites", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEdgeSitesRequest);
            return new SyncInvoker<ListEdgeSitesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEdgeSitesResponse>);
        }
        
        /// <summary>
        /// 查询边缘小站详情
        ///
        /// 查询边缘小站详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowEdgeSiteResponse ShowEdgeSite(ShowEdgeSiteRequest showEdgeSiteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showEdgeSiteRequest.SiteId, out var valueOfSiteId)) urlParam.Add("site_id", valueOfSiteId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/edge-sites/{site_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEdgeSiteRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowEdgeSiteResponse>(response);
        }

        public SyncInvoker<ShowEdgeSiteResponse> ShowEdgeSiteInvoker(ShowEdgeSiteRequest showEdgeSiteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showEdgeSiteRequest.SiteId, out var valueOfSiteId)) urlParam.Add("site_id", valueOfSiteId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/edge-sites/{site_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEdgeSiteRequest);
            return new SyncInvoker<ShowEdgeSiteResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEdgeSiteResponse>);
        }
        
        /// <summary>
        /// 更新边缘小站
        ///
        /// 更新边缘小站。
        /// - 允许更新边缘小站描述或场地信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateEdgeSiteResponse UpdateEdgeSite(UpdateEdgeSiteRequest updateEdgeSiteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateEdgeSiteRequest.SiteId, out var valueOfSiteId)) urlParam.Add("site_id", valueOfSiteId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/edge-sites/{site_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEdgeSiteRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateEdgeSiteResponse>(response);
        }

        public SyncInvoker<UpdateEdgeSiteResponse> UpdateEdgeSiteInvoker(UpdateEdgeSiteRequest updateEdgeSiteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateEdgeSiteRequest.SiteId, out var valueOfSiteId)) urlParam.Add("site_id", valueOfSiteId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/edge-sites/{site_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEdgeSiteRequest);
            return new SyncInvoker<UpdateEdgeSiteResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateEdgeSiteResponse>);
        }
        
        /// <summary>
        /// 查看站点容量信息
        ///
        /// 查看站点容量信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEdgeSiteMetricsResponse ListEdgeSiteMetrics(ListEdgeSiteMetricsRequest listEdgeSiteMetricsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEdgeSiteMetricsRequest.SiteId, out var valueOfSiteId)) urlParam.Add("site_id", valueOfSiteId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/edge-sites/{site_id}/metric-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEdgeSiteMetricsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEdgeSiteMetricsResponse>(response);
        }

        public SyncInvoker<ListEdgeSiteMetricsResponse> ListEdgeSiteMetricsInvoker(ListEdgeSiteMetricsRequest listEdgeSiteMetricsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEdgeSiteMetricsRequest.SiteId, out var valueOfSiteId)) urlParam.Add("site_id", valueOfSiteId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/edge-sites/{site_id}/metric-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEdgeSiteMetricsRequest);
            return new SyncInvoker<ListEdgeSiteMetricsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEdgeSiteMetricsResponse>);
        }
        
        /// <summary>
        /// 查询配额
        ///
        /// 查询租户资源配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListQuotasResponse ListQuotas(ListQuotasRequest listQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListQuotasResponse>(response);
        }

        public SyncInvoker<ListQuotasResponse> ListQuotasInvoker(ListQuotasRequest listQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotasRequest);
            return new SyncInvoker<ListQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListQuotasResponse>);
        }
        
        /// <summary>
        /// 查询机柜列表
        ///
        /// 查询机柜列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRacksResponse ListRacks(ListRacksRequest listRacksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/racks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRacksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRacksResponse>(response);
        }

        public SyncInvoker<ListRacksResponse> ListRacksInvoker(ListRacksRequest listRacksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/racks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRacksRequest);
            return new SyncInvoker<ListRacksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRacksResponse>);
        }
        
        /// <summary>
        /// 查询机柜详情
        ///
        /// 查询机柜详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRackResponse ShowRack(ShowRackRequest showRackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRackRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/racks/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRackRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRackResponse>(response);
        }

        public SyncInvoker<ShowRackResponse> ShowRackInvoker(ShowRackRequest showRackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRackRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/racks/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRackRequest);
            return new SyncInvoker<ShowRackResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRackResponse>);
        }
        
        /// <summary>
        /// 查询支持的区域列表
        ///
        /// 查询支持CloudPond接入的华为云区域（region）列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSupportedRegionsResponse ListSupportedRegions(ListSupportedRegionsRequest listSupportedRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSupportedRegionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSupportedRegionsResponse>(response);
        }

        public SyncInvoker<ListSupportedRegionsResponse> ListSupportedRegionsInvoker(ListSupportedRegionsRequest listSupportedRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSupportedRegionsRequest);
            return new SyncInvoker<ListSupportedRegionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSupportedRegionsResponse>);
        }
        
        /// <summary>
        /// 查询存储池列表
        ///
        /// 查询存储池列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListStoragePoolsResponse ListStoragePools(ListStoragePoolsRequest listStoragePoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/storage-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStoragePoolsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListStoragePoolsResponse>(response);
        }

        public SyncInvoker<ListStoragePoolsResponse> ListStoragePoolsInvoker(ListStoragePoolsRequest listStoragePoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/storage-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStoragePoolsRequest);
            return new SyncInvoker<ListStoragePoolsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStoragePoolsResponse>);
        }
        
        /// <summary>
        /// 查询存储池详情
        ///
        /// 查询存储池详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowStoragePoolResponse ShowStoragePool(ShowStoragePoolRequest showStoragePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showStoragePoolRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/storage-pools/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStoragePoolRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowStoragePoolResponse>(response);
        }

        public SyncInvoker<ShowStoragePoolResponse> ShowStoragePoolInvoker(ShowStoragePoolRequest showStoragePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showStoragePoolRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/storage-pools/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStoragePoolRequest);
            return new SyncInvoker<ShowStoragePoolResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStoragePoolResponse>);
        }
        
        /// <summary>
        /// 查询支持的地区列表
        ///
        /// 查询支持CloudPond接入的华为云地区列表。
        /// - 该接口支持企业项目细粒度权限的校验，具体细粒度请参见 ies:zone:list
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSupportedZonesResponse ListSupportedZones(ListSupportedZonesRequest listSupportedZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSupportedZonesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSupportedZonesResponse>(response);
        }

        public SyncInvoker<ListSupportedZonesResponse> ListSupportedZonesInvoker(ListSupportedZonesRequest listSupportedZonesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/zones", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSupportedZonesRequest);
            return new SyncInvoker<ListSupportedZonesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSupportedZonesResponse>);
        }
        
    }
}