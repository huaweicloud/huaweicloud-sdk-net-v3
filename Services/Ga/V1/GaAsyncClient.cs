using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Ga.V1.Model;

namespace HuaweiCloud.SDK.Ga.V1
{
    public partial class GaAsyncClient : Client
    {
        public static ClientBuilder<GaAsyncClient> NewBuilder()
        {
            return new ClientBuilder<GaAsyncClient>();
        }

        
        /// <summary>
        /// 创建全球加速器
        ///
        /// 创建全球加速器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAcceleratorResponse> CreateAcceleratorAsync(CreateAcceleratorRequest createAcceleratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/accelerators", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAcceleratorRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAcceleratorResponse>(response);
        }

        public AsyncInvoker<CreateAcceleratorResponse> CreateAcceleratorAsyncInvoker(CreateAcceleratorRequest createAcceleratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/accelerators", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAcceleratorRequest);
            return new AsyncInvoker<CreateAcceleratorResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAcceleratorResponse>);
        }
        
        /// <summary>
        /// 删除全球加速器
        ///
        /// 删除全球加速器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAcceleratorResponse> DeleteAcceleratorAsync(DeleteAcceleratorRequest deleteAcceleratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAcceleratorRequest.AcceleratorId, out var valueOfAcceleratorId)) urlParam.Add("accelerator_id", valueOfAcceleratorId);
            var urlPath = HttpUtils.AddUrlPath("/v1/accelerators/{accelerator_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAcceleratorRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAcceleratorResponse>(response);
        }

        public AsyncInvoker<DeleteAcceleratorResponse> DeleteAcceleratorAsyncInvoker(DeleteAcceleratorRequest deleteAcceleratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAcceleratorRequest.AcceleratorId, out var valueOfAcceleratorId)) urlParam.Add("accelerator_id", valueOfAcceleratorId);
            var urlPath = HttpUtils.AddUrlPath("/v1/accelerators/{accelerator_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAcceleratorRequest);
            return new AsyncInvoker<DeleteAcceleratorResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAcceleratorResponse>);
        }
        
        /// <summary>
        /// 查询全球加速器列表
        ///
        /// 查询全球加速器列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAcceleratorsResponse> ListAcceleratorsAsync(ListAcceleratorsRequest listAcceleratorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/accelerators", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAcceleratorsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAcceleratorsResponse>(response);
        }

        public AsyncInvoker<ListAcceleratorsResponse> ListAcceleratorsAsyncInvoker(ListAcceleratorsRequest listAcceleratorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/accelerators", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAcceleratorsRequest);
            return new AsyncInvoker<ListAcceleratorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAcceleratorsResponse>);
        }
        
        /// <summary>
        /// 查询全球加速器详情
        ///
        /// 查询全球加速器详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAcceleratorResponse> ShowAcceleratorAsync(ShowAcceleratorRequest showAcceleratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAcceleratorRequest.AcceleratorId, out var valueOfAcceleratorId)) urlParam.Add("accelerator_id", valueOfAcceleratorId);
            var urlPath = HttpUtils.AddUrlPath("/v1/accelerators/{accelerator_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAcceleratorRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAcceleratorResponse>(response);
        }

        public AsyncInvoker<ShowAcceleratorResponse> ShowAcceleratorAsyncInvoker(ShowAcceleratorRequest showAcceleratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAcceleratorRequest.AcceleratorId, out var valueOfAcceleratorId)) urlParam.Add("accelerator_id", valueOfAcceleratorId);
            var urlPath = HttpUtils.AddUrlPath("/v1/accelerators/{accelerator_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAcceleratorRequest);
            return new AsyncInvoker<ShowAcceleratorResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAcceleratorResponse>);
        }
        
        /// <summary>
        /// 更新全球加速器
        ///
        /// 更新全球加速器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAcceleratorResponse> UpdateAcceleratorAsync(UpdateAcceleratorRequest updateAcceleratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAcceleratorRequest.AcceleratorId, out var valueOfAcceleratorId)) urlParam.Add("accelerator_id", valueOfAcceleratorId);
            var urlPath = HttpUtils.AddUrlPath("/v1/accelerators/{accelerator_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAcceleratorRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAcceleratorResponse>(response);
        }

        public AsyncInvoker<UpdateAcceleratorResponse> UpdateAcceleratorAsyncInvoker(UpdateAcceleratorRequest updateAcceleratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAcceleratorRequest.AcceleratorId, out var valueOfAcceleratorId)) urlParam.Add("accelerator_id", valueOfAcceleratorId);
            var urlPath = HttpUtils.AddUrlPath("/v1/accelerators/{accelerator_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAcceleratorRequest);
            return new AsyncInvoker<UpdateAcceleratorResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAcceleratorResponse>);
        }
        
        /// <summary>
        /// 查询自带IP地址池列表
        ///
        /// 查询自带IP地址池列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListByoipPoolsResponse> ListByoipPoolsAsync(ListByoipPoolsRequest listByoipPoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/byoip-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listByoipPoolsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListByoipPoolsResponse>(response);
        }

        public AsyncInvoker<ListByoipPoolsResponse> ListByoipPoolsAsyncInvoker(ListByoipPoolsRequest listByoipPoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/byoip-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listByoipPoolsRequest);
            return new AsyncInvoker<ListByoipPoolsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListByoipPoolsResponse>);
        }
        
        /// <summary>
        /// 创建终端节点
        ///
        /// 创建终端节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateEndpointResponse> CreateEndpointAsync(CreateEndpointRequest createEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createEndpointRequest.EndpointGroupId, out var valueOfEndpointGroupId)) urlParam.Add("endpoint_group_id", valueOfEndpointGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups/{endpoint_group_id}/endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEndpointRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateEndpointResponse>(response);
        }

        public AsyncInvoker<CreateEndpointResponse> CreateEndpointAsyncInvoker(CreateEndpointRequest createEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createEndpointRequest.EndpointGroupId, out var valueOfEndpointGroupId)) urlParam.Add("endpoint_group_id", valueOfEndpointGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups/{endpoint_group_id}/endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEndpointRequest);
            return new AsyncInvoker<CreateEndpointResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateEndpointResponse>);
        }
        
        /// <summary>
        /// 删除终端节点
        ///
        /// 删除终端节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteEndpointResponse> DeleteEndpointAsync(DeleteEndpointRequest deleteEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteEndpointRequest.EndpointGroupId, out var valueOfEndpointGroupId)) urlParam.Add("endpoint_group_id", valueOfEndpointGroupId);
            if (StringUtils.TryConvertToNonEmptyString(deleteEndpointRequest.EndpointId, out var valueOfEndpointId)) urlParam.Add("endpoint_id", valueOfEndpointId);
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups/{endpoint_group_id}/endpoints/{endpoint_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEndpointRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteEndpointResponse>(response);
        }

        public AsyncInvoker<DeleteEndpointResponse> DeleteEndpointAsyncInvoker(DeleteEndpointRequest deleteEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteEndpointRequest.EndpointGroupId, out var valueOfEndpointGroupId)) urlParam.Add("endpoint_group_id", valueOfEndpointGroupId);
            if (StringUtils.TryConvertToNonEmptyString(deleteEndpointRequest.EndpointId, out var valueOfEndpointId)) urlParam.Add("endpoint_id", valueOfEndpointId);
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups/{endpoint_group_id}/endpoints/{endpoint_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEndpointRequest);
            return new AsyncInvoker<DeleteEndpointResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteEndpointResponse>);
        }
        
        /// <summary>
        /// 查询终端节点组下终端节点列表
        ///
        /// 查询终端节点组下终端节点列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEndpointsResponse> ListEndpointsAsync(ListEndpointsRequest listEndpointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEndpointsRequest.EndpointGroupId, out var valueOfEndpointGroupId)) urlParam.Add("endpoint_group_id", valueOfEndpointGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups/{endpoint_group_id}/endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListEndpointsResponse>(response);
        }

        public AsyncInvoker<ListEndpointsResponse> ListEndpointsAsyncInvoker(ListEndpointsRequest listEndpointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEndpointsRequest.EndpointGroupId, out var valueOfEndpointGroupId)) urlParam.Add("endpoint_group_id", valueOfEndpointGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups/{endpoint_group_id}/endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointsRequest);
            return new AsyncInvoker<ListEndpointsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEndpointsResponse>);
        }
        
        /// <summary>
        /// 查询终端节点详情
        ///
        /// 查询终端节点详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowEndpointResponse> ShowEndpointAsync(ShowEndpointRequest showEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showEndpointRequest.EndpointGroupId, out var valueOfEndpointGroupId)) urlParam.Add("endpoint_group_id", valueOfEndpointGroupId);
            if (StringUtils.TryConvertToNonEmptyString(showEndpointRequest.EndpointId, out var valueOfEndpointId)) urlParam.Add("endpoint_id", valueOfEndpointId);
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups/{endpoint_group_id}/endpoints/{endpoint_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEndpointRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowEndpointResponse>(response);
        }

        public AsyncInvoker<ShowEndpointResponse> ShowEndpointAsyncInvoker(ShowEndpointRequest showEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showEndpointRequest.EndpointGroupId, out var valueOfEndpointGroupId)) urlParam.Add("endpoint_group_id", valueOfEndpointGroupId);
            if (StringUtils.TryConvertToNonEmptyString(showEndpointRequest.EndpointId, out var valueOfEndpointId)) urlParam.Add("endpoint_id", valueOfEndpointId);
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups/{endpoint_group_id}/endpoints/{endpoint_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEndpointRequest);
            return new AsyncInvoker<ShowEndpointResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEndpointResponse>);
        }
        
        /// <summary>
        /// 更新终端节点
        ///
        /// 更新终端节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateEndpointResponse> UpdateEndpointAsync(UpdateEndpointRequest updateEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateEndpointRequest.EndpointGroupId, out var valueOfEndpointGroupId)) urlParam.Add("endpoint_group_id", valueOfEndpointGroupId);
            if (StringUtils.TryConvertToNonEmptyString(updateEndpointRequest.EndpointId, out var valueOfEndpointId)) urlParam.Add("endpoint_id", valueOfEndpointId);
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups/{endpoint_group_id}/endpoints/{endpoint_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEndpointRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateEndpointResponse>(response);
        }

        public AsyncInvoker<UpdateEndpointResponse> UpdateEndpointAsyncInvoker(UpdateEndpointRequest updateEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateEndpointRequest.EndpointGroupId, out var valueOfEndpointGroupId)) urlParam.Add("endpoint_group_id", valueOfEndpointGroupId);
            if (StringUtils.TryConvertToNonEmptyString(updateEndpointRequest.EndpointId, out var valueOfEndpointId)) urlParam.Add("endpoint_id", valueOfEndpointId);
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups/{endpoint_group_id}/endpoints/{endpoint_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEndpointRequest);
            return new AsyncInvoker<UpdateEndpointResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateEndpointResponse>);
        }
        
        /// <summary>
        /// 创建终端节点组
        ///
        /// 创建终端节点组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateEndpointGroupResponse> CreateEndpointGroupAsync(CreateEndpointGroupRequest createEndpointGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEndpointGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateEndpointGroupResponse>(response);
        }

        public AsyncInvoker<CreateEndpointGroupResponse> CreateEndpointGroupAsyncInvoker(CreateEndpointGroupRequest createEndpointGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEndpointGroupRequest);
            return new AsyncInvoker<CreateEndpointGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateEndpointGroupResponse>);
        }
        
        /// <summary>
        /// 删除终端节点组
        ///
        /// 删除终端节点组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteEndpointGroupResponse> DeleteEndpointGroupAsync(DeleteEndpointGroupRequest deleteEndpointGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteEndpointGroupRequest.EndpointGroupId, out var valueOfEndpointGroupId)) urlParam.Add("endpoint_group_id", valueOfEndpointGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups/{endpoint_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEndpointGroupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteEndpointGroupResponse>(response);
        }

        public AsyncInvoker<DeleteEndpointGroupResponse> DeleteEndpointGroupAsyncInvoker(DeleteEndpointGroupRequest deleteEndpointGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteEndpointGroupRequest.EndpointGroupId, out var valueOfEndpointGroupId)) urlParam.Add("endpoint_group_id", valueOfEndpointGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups/{endpoint_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEndpointGroupRequest);
            return new AsyncInvoker<DeleteEndpointGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteEndpointGroupResponse>);
        }
        
        /// <summary>
        /// 查询终端节点组列表
        ///
        /// 查询终端节点组列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEndpointGroupsResponse> ListEndpointGroupsAsync(ListEndpointGroupsRequest listEndpointGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointGroupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListEndpointGroupsResponse>(response);
        }

        public AsyncInvoker<ListEndpointGroupsResponse> ListEndpointGroupsAsyncInvoker(ListEndpointGroupsRequest listEndpointGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointGroupsRequest);
            return new AsyncInvoker<ListEndpointGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEndpointGroupsResponse>);
        }
        
        /// <summary>
        /// 查询终端节点组详情
        ///
        /// 查询终端节点组详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowEndpointGroupResponse> ShowEndpointGroupAsync(ShowEndpointGroupRequest showEndpointGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showEndpointGroupRequest.EndpointGroupId, out var valueOfEndpointGroupId)) urlParam.Add("endpoint_group_id", valueOfEndpointGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups/{endpoint_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEndpointGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowEndpointGroupResponse>(response);
        }

        public AsyncInvoker<ShowEndpointGroupResponse> ShowEndpointGroupAsyncInvoker(ShowEndpointGroupRequest showEndpointGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showEndpointGroupRequest.EndpointGroupId, out var valueOfEndpointGroupId)) urlParam.Add("endpoint_group_id", valueOfEndpointGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups/{endpoint_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEndpointGroupRequest);
            return new AsyncInvoker<ShowEndpointGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEndpointGroupResponse>);
        }
        
        /// <summary>
        /// 更新终端节点组
        ///
        /// 更新终端节点组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateEndpointGroupResponse> UpdateEndpointGroupAsync(UpdateEndpointGroupRequest updateEndpointGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateEndpointGroupRequest.EndpointGroupId, out var valueOfEndpointGroupId)) urlParam.Add("endpoint_group_id", valueOfEndpointGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups/{endpoint_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEndpointGroupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateEndpointGroupResponse>(response);
        }

        public AsyncInvoker<UpdateEndpointGroupResponse> UpdateEndpointGroupAsyncInvoker(UpdateEndpointGroupRequest updateEndpointGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateEndpointGroupRequest.EndpointGroupId, out var valueOfEndpointGroupId)) urlParam.Add("endpoint_group_id", valueOfEndpointGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups/{endpoint_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEndpointGroupRequest);
            return new AsyncInvoker<UpdateEndpointGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateEndpointGroupResponse>);
        }
        
        /// <summary>
        /// 创建健康检查
        ///
        /// 创建健康检查。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateHealthCheckResponse> CreateHealthCheckAsync(CreateHealthCheckRequest createHealthCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/health-checks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createHealthCheckRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateHealthCheckResponse>(response);
        }

        public AsyncInvoker<CreateHealthCheckResponse> CreateHealthCheckAsyncInvoker(CreateHealthCheckRequest createHealthCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/health-checks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createHealthCheckRequest);
            return new AsyncInvoker<CreateHealthCheckResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateHealthCheckResponse>);
        }
        
        /// <summary>
        /// 删除健康检查
        ///
        /// 删除健康检查。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteHealthCheckResponse> DeleteHealthCheckAsync(DeleteHealthCheckRequest deleteHealthCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteHealthCheckRequest.HealthCheckId, out var valueOfHealthCheckId)) urlParam.Add("health_check_id", valueOfHealthCheckId);
            var urlPath = HttpUtils.AddUrlPath("/v1/health-checks/{health_check_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHealthCheckRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteHealthCheckResponse>(response);
        }

        public AsyncInvoker<DeleteHealthCheckResponse> DeleteHealthCheckAsyncInvoker(DeleteHealthCheckRequest deleteHealthCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteHealthCheckRequest.HealthCheckId, out var valueOfHealthCheckId)) urlParam.Add("health_check_id", valueOfHealthCheckId);
            var urlPath = HttpUtils.AddUrlPath("/v1/health-checks/{health_check_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHealthCheckRequest);
            return new AsyncInvoker<DeleteHealthCheckResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteHealthCheckResponse>);
        }
        
        /// <summary>
        /// 查询健康检查列表
        ///
        /// 查询健康检查列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListHealthChecksResponse> ListHealthChecksAsync(ListHealthChecksRequest listHealthChecksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/health-checks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHealthChecksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListHealthChecksResponse>(response);
        }

        public AsyncInvoker<ListHealthChecksResponse> ListHealthChecksAsyncInvoker(ListHealthChecksRequest listHealthChecksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/health-checks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHealthChecksRequest);
            return new AsyncInvoker<ListHealthChecksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHealthChecksResponse>);
        }
        
        /// <summary>
        /// 查询健康检查详情
        ///
        /// 查询健康检查详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowHealthCheckResponse> ShowHealthCheckAsync(ShowHealthCheckRequest showHealthCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showHealthCheckRequest.HealthCheckId, out var valueOfHealthCheckId)) urlParam.Add("health_check_id", valueOfHealthCheckId);
            var urlPath = HttpUtils.AddUrlPath("/v1/health-checks/{health_check_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHealthCheckRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowHealthCheckResponse>(response);
        }

        public AsyncInvoker<ShowHealthCheckResponse> ShowHealthCheckAsyncInvoker(ShowHealthCheckRequest showHealthCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showHealthCheckRequest.HealthCheckId, out var valueOfHealthCheckId)) urlParam.Add("health_check_id", valueOfHealthCheckId);
            var urlPath = HttpUtils.AddUrlPath("/v1/health-checks/{health_check_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHealthCheckRequest);
            return new AsyncInvoker<ShowHealthCheckResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHealthCheckResponse>);
        }
        
        /// <summary>
        /// 更新健康检查
        ///
        /// 更新健康检查。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateHealthCheckResponse> UpdateHealthCheckAsync(UpdateHealthCheckRequest updateHealthCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateHealthCheckRequest.HealthCheckId, out var valueOfHealthCheckId)) urlParam.Add("health_check_id", valueOfHealthCheckId);
            var urlPath = HttpUtils.AddUrlPath("/v1/health-checks/{health_check_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHealthCheckRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateHealthCheckResponse>(response);
        }

        public AsyncInvoker<UpdateHealthCheckResponse> UpdateHealthCheckAsyncInvoker(UpdateHealthCheckRequest updateHealthCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateHealthCheckRequest.HealthCheckId, out var valueOfHealthCheckId)) urlParam.Add("health_check_id", valueOfHealthCheckId);
            var urlPath = HttpUtils.AddUrlPath("/v1/health-checks/{health_check_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHealthCheckRequest);
            return new AsyncInvoker<UpdateHealthCheckResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateHealthCheckResponse>);
        }
        
        /// <summary>
        /// 添加IP地址组中的IP网段
        ///
        /// 添加IP地址组中的IP网段。
        /// 该接口属于异步接口，接口返回后，后台的添加任务仍在执行；可以使用查询IP地址组详情接口查询状态，当IP地址组状态为ACTIVE时，表示条目添加完成。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddIpGroupIpResponse> AddIpGroupIpAsync(AddIpGroupIpRequest addIpGroupIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addIpGroupIpRequest.IpGroupId, out var valueOfIpGroupId)) urlParam.Add("ip_group_id", valueOfIpGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/ip-groups/{ip_group_id}/add-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addIpGroupIpRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddIpGroupIpResponse>(response);
        }

        public AsyncInvoker<AddIpGroupIpResponse> AddIpGroupIpAsyncInvoker(AddIpGroupIpRequest addIpGroupIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addIpGroupIpRequest.IpGroupId, out var valueOfIpGroupId)) urlParam.Add("ip_group_id", valueOfIpGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/ip-groups/{ip_group_id}/add-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addIpGroupIpRequest);
            return new AsyncInvoker<AddIpGroupIpResponse>(this, "POST", request, JsonUtils.DeSerialize<AddIpGroupIpResponse>);
        }
        
        /// <summary>
        /// 绑定IP地址组与监听器
        ///
        /// 绑定IP地址组与监听器。
        /// 该接口属于异步接口，接口返回后，后台的绑定任务仍在执行；可以使用查询IP地址组详情接口查询状态，当IP地址组状态为ACTIVE时，表示绑定完成。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociateListenerResponse> AssociateListenerAsync(AssociateListenerRequest associateListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateListenerRequest.IpGroupId, out var valueOfIpGroupId)) urlParam.Add("ip_group_id", valueOfIpGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/ip-groups/{ip_group_id}/associate-listener", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateListenerRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AssociateListenerResponse>(response);
        }

        public AsyncInvoker<AssociateListenerResponse> AssociateListenerAsyncInvoker(AssociateListenerRequest associateListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateListenerRequest.IpGroupId, out var valueOfIpGroupId)) urlParam.Add("ip_group_id", valueOfIpGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/ip-groups/{ip_group_id}/associate-listener", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateListenerRequest);
            return new AsyncInvoker<AssociateListenerResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateListenerResponse>);
        }
        
        /// <summary>
        /// 创建IP地址组
        ///
        /// 创建IP地址组。
        /// 该接口属于异步接口，会先返回一个IP地址组ID，但后台的创建任务仍在执行；可以使用查询IP地址组详情接口查询状态，当IP地址组状态为ACTIVE时，表示IP地址组创建完成。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateIpGroupResponse> CreateIpGroupAsync(CreateIpGroupRequest createIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/ip-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createIpGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateIpGroupResponse>(response);
        }

        public AsyncInvoker<CreateIpGroupResponse> CreateIpGroupAsyncInvoker(CreateIpGroupRequest createIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/ip-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createIpGroupRequest);
            return new AsyncInvoker<CreateIpGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateIpGroupResponse>);
        }
        
        /// <summary>
        /// 删除IP地址组
        ///
        /// 删除IP地址组。
        /// 该接口属于异步接口，接口返回后，后台的删除任务仍在执行；可以使用查询IP地址组详情接口查询状态，当查询不到该IP地址组时，表示删除完成；删除IP地址组时，若IP地址组已经绑定了监听器，则需要先解绑IP地址组与监听器，再进行删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteIpGroupResponse> DeleteIpGroupAsync(DeleteIpGroupRequest deleteIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteIpGroupRequest.IpGroupId, out var valueOfIpGroupId)) urlParam.Add("ip_group_id", valueOfIpGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/ip-groups/{ip_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIpGroupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteIpGroupResponse>(response);
        }

        public AsyncInvoker<DeleteIpGroupResponse> DeleteIpGroupAsyncInvoker(DeleteIpGroupRequest deleteIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteIpGroupRequest.IpGroupId, out var valueOfIpGroupId)) urlParam.Add("ip_group_id", valueOfIpGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/ip-groups/{ip_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIpGroupRequest);
            return new AsyncInvoker<DeleteIpGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteIpGroupResponse>);
        }
        
        /// <summary>
        /// 解绑IP地址组与监听器
        ///
        /// 解绑IP地址组与监听器。
        /// 该接口属于异步接口，接口返回后，后台的解绑任务仍在执行；可以使用查询IP地址组详情接口查询状态，当IP地址组状态为ACTIVE时，表示解绑完成。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisassociateListenerResponse> DisassociateListenerAsync(DisassociateListenerRequest disassociateListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disassociateListenerRequest.IpGroupId, out var valueOfIpGroupId)) urlParam.Add("ip_group_id", valueOfIpGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/ip-groups/{ip_group_id}/disassociate-listener", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateListenerRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DisassociateListenerResponse>(response);
        }

        public AsyncInvoker<DisassociateListenerResponse> DisassociateListenerAsyncInvoker(DisassociateListenerRequest disassociateListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disassociateListenerRequest.IpGroupId, out var valueOfIpGroupId)) urlParam.Add("ip_group_id", valueOfIpGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/ip-groups/{ip_group_id}/disassociate-listener", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateListenerRequest);
            return new AsyncInvoker<DisassociateListenerResponse>(this, "POST", request, JsonUtils.DeSerialize<DisassociateListenerResponse>);
        }
        
        /// <summary>
        /// 查询IP地址组列表
        ///
        /// 查询IP地址组列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListIpGroupsResponse> ListIpGroupsAsync(ListIpGroupsRequest listIpGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/ip-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpGroupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListIpGroupsResponse>(response);
        }

        public AsyncInvoker<ListIpGroupsResponse> ListIpGroupsAsyncInvoker(ListIpGroupsRequest listIpGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/ip-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpGroupsRequest);
            return new AsyncInvoker<ListIpGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListIpGroupsResponse>);
        }
        
        /// <summary>
        /// 删除IP地址组中的IP网段
        ///
        /// 删除IP地址组中的IP网段。
        /// 该接口属于异步接口，接口返回后，后台的删除任务仍在执行；可以使用查询IP地址组详情接口查询状态，当IP地址组状态为ACTIVE时，表示条目删除完成。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RemoveIpGroupIpResponse> RemoveIpGroupIpAsync(RemoveIpGroupIpRequest removeIpGroupIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeIpGroupIpRequest.IpGroupId, out var valueOfIpGroupId)) urlParam.Add("ip_group_id", valueOfIpGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/ip-groups/{ip_group_id}/remove-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeIpGroupIpRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RemoveIpGroupIpResponse>(response);
        }

        public AsyncInvoker<RemoveIpGroupIpResponse> RemoveIpGroupIpAsyncInvoker(RemoveIpGroupIpRequest removeIpGroupIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeIpGroupIpRequest.IpGroupId, out var valueOfIpGroupId)) urlParam.Add("ip_group_id", valueOfIpGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/ip-groups/{ip_group_id}/remove-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeIpGroupIpRequest);
            return new AsyncInvoker<RemoveIpGroupIpResponse>(this, "POST", request, JsonUtils.DeSerialize<RemoveIpGroupIpResponse>);
        }
        
        /// <summary>
        /// 查询IP地址组详情
        ///
        /// 查询IP地址组详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowIpGroupResponse> ShowIpGroupAsync(ShowIpGroupRequest showIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showIpGroupRequest.IpGroupId, out var valueOfIpGroupId)) urlParam.Add("ip_group_id", valueOfIpGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/ip-groups/{ip_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowIpGroupResponse>(response);
        }

        public AsyncInvoker<ShowIpGroupResponse> ShowIpGroupAsyncInvoker(ShowIpGroupRequest showIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showIpGroupRequest.IpGroupId, out var valueOfIpGroupId)) urlParam.Add("ip_group_id", valueOfIpGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/ip-groups/{ip_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpGroupRequest);
            return new AsyncInvoker<ShowIpGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowIpGroupResponse>);
        }
        
        /// <summary>
        /// 更新IP地址组
        ///
        /// 更新IP地址组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateIpGroupResponse> UpdateIpGroupAsync(UpdateIpGroupRequest updateIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateIpGroupRequest.IpGroupId, out var valueOfIpGroupId)) urlParam.Add("ip_group_id", valueOfIpGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/ip-groups/{ip_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateIpGroupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateIpGroupResponse>(response);
        }

        public AsyncInvoker<UpdateIpGroupResponse> UpdateIpGroupAsyncInvoker(UpdateIpGroupRequest updateIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateIpGroupRequest.IpGroupId, out var valueOfIpGroupId)) urlParam.Add("ip_group_id", valueOfIpGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/ip-groups/{ip_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateIpGroupRequest);
            return new AsyncInvoker<UpdateIpGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateIpGroupResponse>);
        }
        
        /// <summary>
        /// 创建监听器
        ///
        /// 创建监听器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateListenerResponse> CreateListenerAsync(CreateListenerRequest createListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/listeners", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createListenerRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateListenerResponse>(response);
        }

        public AsyncInvoker<CreateListenerResponse> CreateListenerAsyncInvoker(CreateListenerRequest createListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/listeners", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createListenerRequest);
            return new AsyncInvoker<CreateListenerResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateListenerResponse>);
        }
        
        /// <summary>
        /// 删除监听器
        ///
        /// 删除监听器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteListenerResponse> DeleteListenerAsync(DeleteListenerRequest deleteListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteListenerRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/listeners/{listener_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteListenerRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteListenerResponse>(response);
        }

        public AsyncInvoker<DeleteListenerResponse> DeleteListenerAsyncInvoker(DeleteListenerRequest deleteListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteListenerRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/listeners/{listener_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteListenerRequest);
            return new AsyncInvoker<DeleteListenerResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteListenerResponse>);
        }
        
        /// <summary>
        /// 查询监听器列表
        ///
        /// 查询监听器列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListListenersResponse> ListListenersAsync(ListListenersRequest listListenersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/listeners", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listListenersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListListenersResponse>(response);
        }

        public AsyncInvoker<ListListenersResponse> ListListenersAsyncInvoker(ListListenersRequest listListenersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/listeners", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listListenersRequest);
            return new AsyncInvoker<ListListenersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListListenersResponse>);
        }
        
        /// <summary>
        /// 查询监听器详情
        ///
        /// 查询监听器详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowListenerResponse> ShowListenerAsync(ShowListenerRequest showListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showListenerRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/listeners/{listener_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showListenerRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowListenerResponse>(response);
        }

        public AsyncInvoker<ShowListenerResponse> ShowListenerAsyncInvoker(ShowListenerRequest showListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showListenerRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/listeners/{listener_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showListenerRequest);
            return new AsyncInvoker<ShowListenerResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowListenerResponse>);
        }
        
        /// <summary>
        /// 更新监听器
        ///
        /// 更新监听器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateListenerResponse> UpdateListenerAsync(UpdateListenerRequest updateListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateListenerRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/listeners/{listener_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateListenerRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateListenerResponse>(response);
        }

        public AsyncInvoker<UpdateListenerResponse> UpdateListenerAsyncInvoker(UpdateListenerRequest updateListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateListenerRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/listeners/{listener_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateListenerRequest);
            return new AsyncInvoker<UpdateListenerResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateListenerResponse>);
        }
        
        /// <summary>
        /// 创建云日志
        ///
        /// 创建云日志。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateLogtankResponse> CreateLogtankAsync(CreateLogtankRequest createLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/logtanks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLogtankRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateLogtankResponse>(response);
        }

        public AsyncInvoker<CreateLogtankResponse> CreateLogtankAsyncInvoker(CreateLogtankRequest createLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/logtanks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLogtankRequest);
            return new AsyncInvoker<CreateLogtankResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateLogtankResponse>);
        }
        
        /// <summary>
        /// 删除云日志
        ///
        /// 删除云日志。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteLogtankResponse> DeleteLogtankAsync(DeleteLogtankRequest deleteLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteLogtankRequest.LogtankId, out var valueOfLogtankId)) urlParam.Add("logtank_id", valueOfLogtankId);
            var urlPath = HttpUtils.AddUrlPath("/v1/logtanks/{logtank_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLogtankRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteLogtankResponse>(response);
        }

        public AsyncInvoker<DeleteLogtankResponse> DeleteLogtankAsyncInvoker(DeleteLogtankRequest deleteLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteLogtankRequest.LogtankId, out var valueOfLogtankId)) urlParam.Add("logtank_id", valueOfLogtankId);
            var urlPath = HttpUtils.AddUrlPath("/v1/logtanks/{logtank_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLogtankRequest);
            return new AsyncInvoker<DeleteLogtankResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteLogtankResponse>);
        }
        
        /// <summary>
        /// 查询云日志列表
        ///
        /// 查询云日志列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLogtanksResponse> ListLogtanksAsync(ListLogtanksRequest listLogtanksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/logtanks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogtanksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListLogtanksResponse>(response);
        }

        public AsyncInvoker<ListLogtanksResponse> ListLogtanksAsyncInvoker(ListLogtanksRequest listLogtanksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/logtanks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogtanksRequest);
            return new AsyncInvoker<ListLogtanksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLogtanksResponse>);
        }
        
        /// <summary>
        /// 查询云日志详情
        ///
        /// 查询云日志详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowLogtankResponse> ShowLogtankAsync(ShowLogtankRequest showLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLogtankRequest.LogtankId, out var valueOfLogtankId)) urlParam.Add("logtank_id", valueOfLogtankId);
            var urlPath = HttpUtils.AddUrlPath("/v1/logtanks/{logtank_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogtankRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowLogtankResponse>(response);
        }

        public AsyncInvoker<ShowLogtankResponse> ShowLogtankAsyncInvoker(ShowLogtankRequest showLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLogtankRequest.LogtankId, out var valueOfLogtankId)) urlParam.Add("logtank_id", valueOfLogtankId);
            var urlPath = HttpUtils.AddUrlPath("/v1/logtanks/{logtank_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogtankRequest);
            return new AsyncInvoker<ShowLogtankResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLogtankResponse>);
        }
        
        /// <summary>
        /// 更新云日志
        ///
        /// 更新云日志。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateLogtankResponse> UpdateLogtankAsync(UpdateLogtankRequest updateLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateLogtankRequest.LogtankId, out var valueOfLogtankId)) urlParam.Add("logtank_id", valueOfLogtankId);
            var urlPath = HttpUtils.AddUrlPath("/v1/logtanks/{logtank_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLogtankRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateLogtankResponse>(response);
        }

        public AsyncInvoker<UpdateLogtankResponse> UpdateLogtankAsyncInvoker(UpdateLogtankRequest updateLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateLogtankRequest.LogtankId, out var valueOfLogtankId)) urlParam.Add("logtank_id", valueOfLogtankId);
            var urlPath = HttpUtils.AddUrlPath("/v1/logtanks/{logtank_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLogtankRequest);
            return new AsyncInvoker<UpdateLogtankResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateLogtankResponse>);
        }
        
        /// <summary>
        /// 查询pop列表
        ///
        /// 查询pop列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAllPopsResponse> ListAllPopsAsync(ListAllPopsRequest listAllPopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/pops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllPopsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAllPopsResponse>(response);
        }

        public AsyncInvoker<ListAllPopsResponse> ListAllPopsAsyncInvoker(ListAllPopsRequest listAllPopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/pops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllPopsRequest);
            return new AsyncInvoker<ListAllPopsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAllPopsResponse>);
        }
        
        /// <summary>
        /// 查询配额列表
        ///
        /// 查询配额列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTenantQuotasResponse> ListTenantQuotasAsync(ListTenantQuotasRequest listTenantQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTenantQuotasRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/ga/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantQuotasRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTenantQuotasResponse>(response);
        }

        public AsyncInvoker<ListTenantQuotasResponse> ListTenantQuotasAsyncInvoker(ListTenantQuotasRequest listTenantQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTenantQuotasRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/ga/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantQuotasRequest);
            return new AsyncInvoker<ListTenantQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTenantQuotasResponse>);
        }
        
        /// <summary>
        /// 查询区域列表
        ///
        /// 查询区域列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRegionsResponse> ListRegionsAsync(ListRegionsRequest listRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRegionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRegionsResponse>(response);
        }

        public AsyncInvoker<ListRegionsResponse> ListRegionsAsyncInvoker(ListRegionsRequest listRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRegionsRequest);
            return new AsyncInvoker<ListRegionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRegionsResponse>);
        }
        
        /// <summary>
        /// 通过标签查询资源实例数量
        ///
        /// 通过标签查询资源实例数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CountResourcesByTagResponse> CountResourcesByTagAsync(CountResourcesByTagRequest countResourcesByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countResourcesByTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/{resource_type}/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countResourcesByTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CountResourcesByTagResponse>(response);
        }

        public AsyncInvoker<CountResourcesByTagResponse> CountResourcesByTagAsyncInvoker(CountResourcesByTagRequest countResourcesByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countResourcesByTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/{resource_type}/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countResourcesByTagRequest);
            return new AsyncInvoker<CountResourcesByTagResponse>(this, "POST", request, JsonUtils.DeSerialize<CountResourcesByTagResponse>);
        }
        
        /// <summary>
        /// 创建资源标签
        ///
        /// 创建资源标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest createTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(createTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateTagsResponse>(response);
        }

        public AsyncInvoker<CreateTagsResponse> CreateTagsAsyncInvoker(CreateTagsRequest createTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(createTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagsRequest);
            return new AsyncInvoker<CreateTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTagsResponse>);
        }
        
        /// <summary>
        /// 删除资源标签
        ///
        /// 删除资源标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest deleteTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(deleteTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagsRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteTagsResponse>(response);
        }

        public AsyncInvoker<DeleteTagsResponse> DeleteTagsAsyncInvoker(DeleteTagsRequest deleteTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(deleteTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagsRequest);
            return new AsyncInvoker<DeleteTagsResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteTagsResponse>);
        }
        
        /// <summary>
        /// 通过标签查询资源实例列表
        ///
        /// 通过标签查询资源实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListResourcesByTagResponse> ListResourcesByTagAsync(ListResourcesByTagRequest listResourcesByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourcesByTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/{resource_type}/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourcesByTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListResourcesByTagResponse>(response);
        }

        public AsyncInvoker<ListResourcesByTagResponse> ListResourcesByTagAsyncInvoker(ListResourcesByTagRequest listResourcesByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourcesByTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/{resource_type}/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourcesByTagRequest);
            return new AsyncInvoker<ListResourcesByTagResponse>(this, "POST", request, JsonUtils.DeSerialize<ListResourcesByTagResponse>);
        }
        
        /// <summary>
        /// 查询标签列表
        ///
        /// 查询标签列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTagsResponse> ListTagsAsync(ListTagsRequest listTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTagsResponse>(response);
        }

        public AsyncInvoker<ListTagsResponse> ListTagsAsyncInvoker(ListTagsRequest listTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsRequest);
            return new AsyncInvoker<ListTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTagsResponse>);
        }
        
        /// <summary>
        /// 查询特定资源标签
        ///
        /// 查询特定资源标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowResourceTagsResponse> ShowResourceTagsAsync(ShowResourceTagsRequest showResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(showResourceTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowResourceTagsResponse>(response);
        }

        public AsyncInvoker<ShowResourceTagsResponse> ShowResourceTagsAsyncInvoker(ShowResourceTagsRequest showResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(showResourceTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceTagsRequest);
            return new AsyncInvoker<ShowResourceTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceTagsResponse>);
        }
        
    }
}