using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.CloudPond.V2.Model;

namespace HuaweiCloud.SDK.CloudPond.V2
{
    public partial class CloudPondAsyncClient : Client
    {
        public static ClientBuilder<CloudPondAsyncClient> NewBuilder()
        {
            return new ClientBuilder<CloudPondAsyncClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 查询网络设备列表
        ///
        /// 查询网络设备列表。
        /// [- 该接口支持企业项目细粒度权限的校验，具体细粒度请参见 ies:edgeSite:listNetworkDevices](tag:hws)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNetworkDevicesResponse> ListNetworkDevicesAsync(ListNetworkDevicesRequest listNetworkDevicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/network-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNetworkDevicesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListNetworkDevicesResponse>(response);
        }

        public AsyncInvoker<ListNetworkDevicesResponse> ListNetworkDevicesAsyncInvoker(ListNetworkDevicesRequest listNetworkDevicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/network-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNetworkDevicesRequest);
            return new AsyncInvoker<ListNetworkDevicesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNetworkDevicesResponse>);
        }
        
        /// <summary>
        /// 查询网络设备详情
        ///
        /// 查询网络设备详情。
        /// [- 该接口支持企业项目细粒度权限的校验，具体细粒度请参见 ies:edgeSite:getNetworkDevice](tag:hws)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowNetworkDeviceResponse> ShowNetworkDeviceAsync(ShowNetworkDeviceRequest showNetworkDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNetworkDeviceRequest.NetworkDeviceId, out var valueOfNetworkDeviceId)) urlParam.Add("network_device_id", valueOfNetworkDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/network-devices/{network_device_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNetworkDeviceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowNetworkDeviceResponse>(response);
        }

        public AsyncInvoker<ShowNetworkDeviceResponse> ShowNetworkDeviceAsyncInvoker(ShowNetworkDeviceRequest showNetworkDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNetworkDeviceRequest.NetworkDeviceId, out var valueOfNetworkDeviceId)) urlParam.Add("network_device_id", valueOfNetworkDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/network-devices/{network_device_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNetworkDeviceRequest);
            return new AsyncInvoker<ShowNetworkDeviceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNetworkDeviceResponse>);
        }
        
        /// <summary>
        /// 查询网络设备商品列表
        ///
        /// 查询网络设备商品列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNetworkDeviceOfferingsResponse> ListNetworkDeviceOfferingsAsync(ListNetworkDeviceOfferingsRequest listNetworkDeviceOfferingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/network-device-offerings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNetworkDeviceOfferingsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListNetworkDeviceOfferingsResponse>(response);
        }

        public AsyncInvoker<ListNetworkDeviceOfferingsResponse> ListNetworkDeviceOfferingsAsyncInvoker(ListNetworkDeviceOfferingsRequest listNetworkDeviceOfferingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/network-device-offerings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNetworkDeviceOfferingsRequest);
            return new AsyncInvoker<ListNetworkDeviceOfferingsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNetworkDeviceOfferingsResponse>);
        }
        
        /// <summary>
        /// 查询服务器商品列表
        ///
        /// 查询服务器销售商品列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListServerOfferingsResponse> ListServerOfferingsAsync(ListServerOfferingsRequest listServerOfferingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/server-offerings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerOfferingsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListServerOfferingsResponse>(response);
        }

        public AsyncInvoker<ListServerOfferingsResponse> ListServerOfferingsAsyncInvoker(ListServerOfferingsRequest listServerOfferingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/server-offerings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerOfferingsRequest);
            return new AsyncInvoker<ListServerOfferingsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServerOfferingsResponse>);
        }
        
        /// <summary>
        /// 查询可购买的销售周期
        ///
        /// 查询可购买的销售周期
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSaleCyclesResponse> ListSaleCyclesAsync(ListSaleCyclesRequest listSaleCyclesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/sale-cycles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSaleCyclesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSaleCyclesResponse>(response);
        }

        public AsyncInvoker<ListSaleCyclesResponse> ListSaleCyclesAsyncInvoker(ListSaleCyclesRequest listSaleCyclesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/sale-cycles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSaleCyclesRequest);
            return new AsyncInvoker<ListSaleCyclesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSaleCyclesResponse>);
        }
        
        /// <summary>
        /// 查询服务器列表
        ///
        /// 查询服务器列表。
        /// [- 该接口支持企业项目细粒度权限的校验，具体细粒度请参见 ies:edgeSite:listServers](tag:hws)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListServersResponse> ListServersAsync(ListServersRequest listServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListServersResponse>(response);
        }

        public AsyncInvoker<ListServersResponse> ListServersAsyncInvoker(ListServersRequest listServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServersRequest);
            return new AsyncInvoker<ListServersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServersResponse>);
        }
        
        /// <summary>
        /// 查询服务器详情
        ///
        /// 查询服务器详情。
        /// [- 该接口支持企业项目细粒度权限的校验，具体细粒度请参见 ies:edgeSite:getServer](tag:hws)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowServerResponse> ShowServerAsync(ShowServerRequest showServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showServerRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/servers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowServerResponse>(response);
        }

        public AsyncInvoker<ShowServerResponse> ShowServerAsyncInvoker(ShowServerRequest showServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showServerRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/servers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerRequest);
            return new AsyncInvoker<ShowServerResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowServerResponse>);
        }
        
        /// <summary>
        /// 查询存储计费档位
        ///
        /// 该接口仅返回支持的存储计费档位，实际可购买的存储容量单独定义。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListStorageGearsResponse> ListStorageGearsAsync(ListStorageGearsRequest listStorageGearsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/storage-gears", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStorageGearsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListStorageGearsResponse>(response);
        }

        public AsyncInvoker<ListStorageGearsResponse> ListStorageGearsAsyncInvoker(ListStorageGearsRequest listStorageGearsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/storage-gears", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStorageGearsRequest);
            return new AsyncInvoker<ListStorageGearsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStorageGearsResponse>);
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
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/storage-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStoragePoolsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListStoragePoolsResponse>(response);
        }

        public AsyncInvoker<ListStoragePoolsResponse> ListStoragePoolsAsyncInvoker(ListStoragePoolsRequest listStoragePoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/storage-pools", urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/storage-pools/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStoragePoolRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowStoragePoolResponse>(response);
        }

        public AsyncInvoker<ShowStoragePoolResponse> ShowStoragePoolAsyncInvoker(ShowStoragePoolRequest showStoragePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showStoragePoolRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/storage-pools/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStoragePoolRequest);
            return new AsyncInvoker<ShowStoragePoolResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStoragePoolResponse>);
        }
        
        /// <summary>
        /// 查询存储类型列表
        ///
        /// 查询支持的存储类型列表，包括步长等信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListStorageTypesResponse> ListStorageTypesAsync(ListStorageTypesRequest listStorageTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/storage-types", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStorageTypesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListStorageTypesResponse>(response);
        }

        public AsyncInvoker<ListStorageTypesResponse> ListStorageTypesAsyncInvoker(ListStorageTypesRequest listStorageTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/storage-types", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStorageTypesRequest);
            return new AsyncInvoker<ListStorageTypesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStorageTypesResponse>);
        }
        
    }
}