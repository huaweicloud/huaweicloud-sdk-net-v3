using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.CloudPond.V2.Model;

namespace HuaweiCloud.SDK.CloudPond.V2
{
    public partial class CloudPondClient : Client
    {
        public static ClientBuilder<CloudPondClient> NewBuilder()
        {
            return new ClientBuilder<CloudPondClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 查询网络设备列表
        ///
        /// 查询网络设备列表。
        /// [- 该接口支持企业项目细粒度权限的校验，具体细粒度请参见 ies:edgeSite:listNetworkDevices](tag:hws)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListNetworkDevicesResponse ListNetworkDevices(ListNetworkDevicesRequest listNetworkDevicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/network-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNetworkDevicesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListNetworkDevicesResponse>(response);
        }

        public SyncInvoker<ListNetworkDevicesResponse> ListNetworkDevicesInvoker(ListNetworkDevicesRequest listNetworkDevicesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/network-devices", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNetworkDevicesRequest);
            return new SyncInvoker<ListNetworkDevicesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNetworkDevicesResponse>);
        }
        
        /// <summary>
        /// 查询网络设备详情
        ///
        /// 查询网络设备详情。
        /// [- 该接口支持企业项目细粒度权限的校验，具体细粒度请参见 ies:edgeSite:getNetworkDevice](tag:hws)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowNetworkDeviceResponse ShowNetworkDevice(ShowNetworkDeviceRequest showNetworkDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNetworkDeviceRequest.NetworkDeviceId, out var valueOfNetworkDeviceId)) urlParam.Add("network_device_id", valueOfNetworkDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/network-devices/{network_device_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNetworkDeviceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowNetworkDeviceResponse>(response);
        }

        public SyncInvoker<ShowNetworkDeviceResponse> ShowNetworkDeviceInvoker(ShowNetworkDeviceRequest showNetworkDeviceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNetworkDeviceRequest.NetworkDeviceId, out var valueOfNetworkDeviceId)) urlParam.Add("network_device_id", valueOfNetworkDeviceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/network-devices/{network_device_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNetworkDeviceRequest);
            return new SyncInvoker<ShowNetworkDeviceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNetworkDeviceResponse>);
        }
        
        /// <summary>
        /// 查询网络设备商品列表
        ///
        /// 查询网络设备商品列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListNetworkDeviceOfferingsResponse ListNetworkDeviceOfferings(ListNetworkDeviceOfferingsRequest listNetworkDeviceOfferingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/network-device-offerings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNetworkDeviceOfferingsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListNetworkDeviceOfferingsResponse>(response);
        }

        public SyncInvoker<ListNetworkDeviceOfferingsResponse> ListNetworkDeviceOfferingsInvoker(ListNetworkDeviceOfferingsRequest listNetworkDeviceOfferingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/network-device-offerings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNetworkDeviceOfferingsRequest);
            return new SyncInvoker<ListNetworkDeviceOfferingsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNetworkDeviceOfferingsResponse>);
        }
        
        /// <summary>
        /// 查询服务器商品列表
        ///
        /// 查询服务器销售商品列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListServerOfferingsResponse ListServerOfferings(ListServerOfferingsRequest listServerOfferingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/server-offerings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerOfferingsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListServerOfferingsResponse>(response);
        }

        public SyncInvoker<ListServerOfferingsResponse> ListServerOfferingsInvoker(ListServerOfferingsRequest listServerOfferingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/server-offerings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerOfferingsRequest);
            return new SyncInvoker<ListServerOfferingsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServerOfferingsResponse>);
        }
        
        /// <summary>
        /// 查询可购买的销售周期
        ///
        /// 查询可购买的销售周期
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSaleCyclesResponse ListSaleCycles(ListSaleCyclesRequest listSaleCyclesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/sale-cycles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSaleCyclesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSaleCyclesResponse>(response);
        }

        public SyncInvoker<ListSaleCyclesResponse> ListSaleCyclesInvoker(ListSaleCyclesRequest listSaleCyclesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/sale-cycles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSaleCyclesRequest);
            return new SyncInvoker<ListSaleCyclesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSaleCyclesResponse>);
        }
        
        /// <summary>
        /// 查询服务器列表
        ///
        /// 查询服务器列表。
        /// [- 该接口支持企业项目细粒度权限的校验，具体细粒度请参见 ies:edgeSite:listServers](tag:hws)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListServersResponse ListServers(ListServersRequest listServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListServersResponse>(response);
        }

        public SyncInvoker<ListServersResponse> ListServersInvoker(ListServersRequest listServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServersRequest);
            return new SyncInvoker<ListServersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServersResponse>);
        }
        
        /// <summary>
        /// 查询服务器详情
        ///
        /// 查询服务器详情。
        /// [- 该接口支持企业项目细粒度权限的校验，具体细粒度请参见 ies:edgeSite:getServer](tag:hws)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowServerResponse ShowServer(ShowServerRequest showServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showServerRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/servers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowServerResponse>(response);
        }

        public SyncInvoker<ShowServerResponse> ShowServerInvoker(ShowServerRequest showServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showServerRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/servers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerRequest);
            return new SyncInvoker<ShowServerResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowServerResponse>);
        }
        
        /// <summary>
        /// 查询存储计费档位
        ///
        /// 该接口仅返回支持的存储计费档位，实际可购买的存储容量单独定义。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListStorageGearsResponse ListStorageGears(ListStorageGearsRequest listStorageGearsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/storage-gears", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStorageGearsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListStorageGearsResponse>(response);
        }

        public SyncInvoker<ListStorageGearsResponse> ListStorageGearsInvoker(ListStorageGearsRequest listStorageGearsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/storage-gears", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStorageGearsRequest);
            return new SyncInvoker<ListStorageGearsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStorageGearsResponse>);
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
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/storage-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStoragePoolsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListStoragePoolsResponse>(response);
        }

        public SyncInvoker<ListStoragePoolsResponse> ListStoragePoolsInvoker(ListStoragePoolsRequest listStoragePoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/storage-pools", urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/storage-pools/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStoragePoolRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowStoragePoolResponse>(response);
        }

        public SyncInvoker<ShowStoragePoolResponse> ShowStoragePoolInvoker(ShowStoragePoolRequest showStoragePoolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showStoragePoolRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/storage-pools/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStoragePoolRequest);
            return new SyncInvoker<ShowStoragePoolResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStoragePoolResponse>);
        }
        
        /// <summary>
        /// 查询存储类型列表
        ///
        /// 查询支持的存储类型列表，包括步长等信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListStorageTypesResponse ListStorageTypes(ListStorageTypesRequest listStorageTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/storage-types", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStorageTypesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListStorageTypesResponse>(response);
        }

        public SyncInvoker<ListStorageTypesResponse> ListStorageTypesInvoker(ListStorageTypesRequest listStorageTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/storage-types", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStorageTypesRequest);
            return new SyncInvoker<ListStorageTypesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStorageTypesResponse>);
        }
        
    }
}