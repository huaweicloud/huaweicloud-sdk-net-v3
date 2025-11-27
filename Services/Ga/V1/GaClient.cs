using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Ga.V1.Model;

namespace HuaweiCloud.SDK.Ga.V1
{
    public partial class GaClient : Client
    {
        public static ClientBuilder<GaClient> NewBuilder()
        {
            return new ClientBuilder<GaClient>();
        }

        
        /// <summary>
        /// 创建全球加速器
        ///
        /// 创建全球加速器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAcceleratorResponse CreateAccelerator(CreateAcceleratorRequest createAcceleratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/accelerators", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAcceleratorRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAcceleratorResponse>(response);
        }

        public SyncInvoker<CreateAcceleratorResponse> CreateAcceleratorInvoker(CreateAcceleratorRequest createAcceleratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/accelerators", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAcceleratorRequest);
            return new SyncInvoker<CreateAcceleratorResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAcceleratorResponse>);
        }
        
        /// <summary>
        /// 删除全球加速器
        ///
        /// 删除全球加速器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAcceleratorResponse DeleteAccelerator(DeleteAcceleratorRequest deleteAcceleratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAcceleratorRequest.AcceleratorId, out var valueOfAcceleratorId)) urlParam.Add("accelerator_id", valueOfAcceleratorId);
            var urlPath = HttpUtils.AddUrlPath("/v1/accelerators/{accelerator_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAcceleratorRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAcceleratorResponse>(response);
        }

        public SyncInvoker<DeleteAcceleratorResponse> DeleteAcceleratorInvoker(DeleteAcceleratorRequest deleteAcceleratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAcceleratorRequest.AcceleratorId, out var valueOfAcceleratorId)) urlParam.Add("accelerator_id", valueOfAcceleratorId);
            var urlPath = HttpUtils.AddUrlPath("/v1/accelerators/{accelerator_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAcceleratorRequest);
            return new SyncInvoker<DeleteAcceleratorResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAcceleratorResponse>);
        }
        
        /// <summary>
        /// 查询全球加速器列表
        ///
        /// 查询全球加速器列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAcceleratorsResponse ListAccelerators(ListAcceleratorsRequest listAcceleratorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/accelerators", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAcceleratorsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAcceleratorsResponse>(response);
        }

        public SyncInvoker<ListAcceleratorsResponse> ListAcceleratorsInvoker(ListAcceleratorsRequest listAcceleratorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/accelerators", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAcceleratorsRequest);
            return new SyncInvoker<ListAcceleratorsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAcceleratorsResponse>);
        }
        
        /// <summary>
        /// 查询全球加速器详情
        ///
        /// 查询全球加速器详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAcceleratorResponse ShowAccelerator(ShowAcceleratorRequest showAcceleratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAcceleratorRequest.AcceleratorId, out var valueOfAcceleratorId)) urlParam.Add("accelerator_id", valueOfAcceleratorId);
            var urlPath = HttpUtils.AddUrlPath("/v1/accelerators/{accelerator_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAcceleratorRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAcceleratorResponse>(response);
        }

        public SyncInvoker<ShowAcceleratorResponse> ShowAcceleratorInvoker(ShowAcceleratorRequest showAcceleratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAcceleratorRequest.AcceleratorId, out var valueOfAcceleratorId)) urlParam.Add("accelerator_id", valueOfAcceleratorId);
            var urlPath = HttpUtils.AddUrlPath("/v1/accelerators/{accelerator_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAcceleratorRequest);
            return new SyncInvoker<ShowAcceleratorResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAcceleratorResponse>);
        }
        
        /// <summary>
        /// 更新全球加速器
        ///
        /// 更新全球加速器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAcceleratorResponse UpdateAccelerator(UpdateAcceleratorRequest updateAcceleratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAcceleratorRequest.AcceleratorId, out var valueOfAcceleratorId)) urlParam.Add("accelerator_id", valueOfAcceleratorId);
            var urlPath = HttpUtils.AddUrlPath("/v1/accelerators/{accelerator_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAcceleratorRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAcceleratorResponse>(response);
        }

        public SyncInvoker<UpdateAcceleratorResponse> UpdateAcceleratorInvoker(UpdateAcceleratorRequest updateAcceleratorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAcceleratorRequest.AcceleratorId, out var valueOfAcceleratorId)) urlParam.Add("accelerator_id", valueOfAcceleratorId);
            var urlPath = HttpUtils.AddUrlPath("/v1/accelerators/{accelerator_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAcceleratorRequest);
            return new SyncInvoker<UpdateAcceleratorResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAcceleratorResponse>);
        }
        
        /// <summary>
        /// 查询自带IP地址池列表
        ///
        /// 查询自带IP地址池列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListByoipPoolsResponse ListByoipPools(ListByoipPoolsRequest listByoipPoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/byoip-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listByoipPoolsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListByoipPoolsResponse>(response);
        }

        public SyncInvoker<ListByoipPoolsResponse> ListByoipPoolsInvoker(ListByoipPoolsRequest listByoipPoolsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/byoip-pools", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listByoipPoolsRequest);
            return new SyncInvoker<ListByoipPoolsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListByoipPoolsResponse>);
        }
        
        /// <summary>
        /// 创建终端节点
        ///
        /// 创建终端节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateEndpointResponse CreateEndpoint(CreateEndpointRequest createEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createEndpointRequest.EndpointGroupId, out var valueOfEndpointGroupId)) urlParam.Add("endpoint_group_id", valueOfEndpointGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups/{endpoint_group_id}/endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEndpointRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateEndpointResponse>(response);
        }

        public SyncInvoker<CreateEndpointResponse> CreateEndpointInvoker(CreateEndpointRequest createEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createEndpointRequest.EndpointGroupId, out var valueOfEndpointGroupId)) urlParam.Add("endpoint_group_id", valueOfEndpointGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups/{endpoint_group_id}/endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEndpointRequest);
            return new SyncInvoker<CreateEndpointResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateEndpointResponse>);
        }
        
        /// <summary>
        /// 删除终端节点
        ///
        /// 删除终端节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest deleteEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteEndpointRequest.EndpointGroupId, out var valueOfEndpointGroupId)) urlParam.Add("endpoint_group_id", valueOfEndpointGroupId);
            if (StringUtils.TryConvertToNonEmptyString(deleteEndpointRequest.EndpointId, out var valueOfEndpointId)) urlParam.Add("endpoint_id", valueOfEndpointId);
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups/{endpoint_group_id}/endpoints/{endpoint_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEndpointRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteEndpointResponse>(response);
        }

        public SyncInvoker<DeleteEndpointResponse> DeleteEndpointInvoker(DeleteEndpointRequest deleteEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteEndpointRequest.EndpointGroupId, out var valueOfEndpointGroupId)) urlParam.Add("endpoint_group_id", valueOfEndpointGroupId);
            if (StringUtils.TryConvertToNonEmptyString(deleteEndpointRequest.EndpointId, out var valueOfEndpointId)) urlParam.Add("endpoint_id", valueOfEndpointId);
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups/{endpoint_group_id}/endpoints/{endpoint_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEndpointRequest);
            return new SyncInvoker<DeleteEndpointResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteEndpointResponse>);
        }
        
        /// <summary>
        /// 查询终端节点组下终端节点列表
        ///
        /// 查询终端节点组下终端节点列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEndpointsResponse ListEndpoints(ListEndpointsRequest listEndpointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEndpointsRequest.EndpointGroupId, out var valueOfEndpointGroupId)) urlParam.Add("endpoint_group_id", valueOfEndpointGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups/{endpoint_group_id}/endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEndpointsResponse>(response);
        }

        public SyncInvoker<ListEndpointsResponse> ListEndpointsInvoker(ListEndpointsRequest listEndpointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEndpointsRequest.EndpointGroupId, out var valueOfEndpointGroupId)) urlParam.Add("endpoint_group_id", valueOfEndpointGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups/{endpoint_group_id}/endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointsRequest);
            return new SyncInvoker<ListEndpointsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEndpointsResponse>);
        }
        
        /// <summary>
        /// 查询终端节点详情
        ///
        /// 查询终端节点详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowEndpointResponse ShowEndpoint(ShowEndpointRequest showEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showEndpointRequest.EndpointGroupId, out var valueOfEndpointGroupId)) urlParam.Add("endpoint_group_id", valueOfEndpointGroupId);
            if (StringUtils.TryConvertToNonEmptyString(showEndpointRequest.EndpointId, out var valueOfEndpointId)) urlParam.Add("endpoint_id", valueOfEndpointId);
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups/{endpoint_group_id}/endpoints/{endpoint_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEndpointRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowEndpointResponse>(response);
        }

        public SyncInvoker<ShowEndpointResponse> ShowEndpointInvoker(ShowEndpointRequest showEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showEndpointRequest.EndpointGroupId, out var valueOfEndpointGroupId)) urlParam.Add("endpoint_group_id", valueOfEndpointGroupId);
            if (StringUtils.TryConvertToNonEmptyString(showEndpointRequest.EndpointId, out var valueOfEndpointId)) urlParam.Add("endpoint_id", valueOfEndpointId);
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups/{endpoint_group_id}/endpoints/{endpoint_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEndpointRequest);
            return new SyncInvoker<ShowEndpointResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEndpointResponse>);
        }
        
        /// <summary>
        /// 更新终端节点
        ///
        /// 更新终端节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateEndpointResponse UpdateEndpoint(UpdateEndpointRequest updateEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateEndpointRequest.EndpointGroupId, out var valueOfEndpointGroupId)) urlParam.Add("endpoint_group_id", valueOfEndpointGroupId);
            if (StringUtils.TryConvertToNonEmptyString(updateEndpointRequest.EndpointId, out var valueOfEndpointId)) urlParam.Add("endpoint_id", valueOfEndpointId);
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups/{endpoint_group_id}/endpoints/{endpoint_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEndpointRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateEndpointResponse>(response);
        }

        public SyncInvoker<UpdateEndpointResponse> UpdateEndpointInvoker(UpdateEndpointRequest updateEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateEndpointRequest.EndpointGroupId, out var valueOfEndpointGroupId)) urlParam.Add("endpoint_group_id", valueOfEndpointGroupId);
            if (StringUtils.TryConvertToNonEmptyString(updateEndpointRequest.EndpointId, out var valueOfEndpointId)) urlParam.Add("endpoint_id", valueOfEndpointId);
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups/{endpoint_group_id}/endpoints/{endpoint_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEndpointRequest);
            return new SyncInvoker<UpdateEndpointResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateEndpointResponse>);
        }
        
        /// <summary>
        /// 创建终端节点组
        ///
        /// 创建终端节点组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateEndpointGroupResponse CreateEndpointGroup(CreateEndpointGroupRequest createEndpointGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEndpointGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateEndpointGroupResponse>(response);
        }

        public SyncInvoker<CreateEndpointGroupResponse> CreateEndpointGroupInvoker(CreateEndpointGroupRequest createEndpointGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEndpointGroupRequest);
            return new SyncInvoker<CreateEndpointGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateEndpointGroupResponse>);
        }
        
        /// <summary>
        /// 删除终端节点组
        ///
        /// 删除终端节点组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteEndpointGroupResponse DeleteEndpointGroup(DeleteEndpointGroupRequest deleteEndpointGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteEndpointGroupRequest.EndpointGroupId, out var valueOfEndpointGroupId)) urlParam.Add("endpoint_group_id", valueOfEndpointGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups/{endpoint_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEndpointGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteEndpointGroupResponse>(response);
        }

        public SyncInvoker<DeleteEndpointGroupResponse> DeleteEndpointGroupInvoker(DeleteEndpointGroupRequest deleteEndpointGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteEndpointGroupRequest.EndpointGroupId, out var valueOfEndpointGroupId)) urlParam.Add("endpoint_group_id", valueOfEndpointGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups/{endpoint_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEndpointGroupRequest);
            return new SyncInvoker<DeleteEndpointGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteEndpointGroupResponse>);
        }
        
        /// <summary>
        /// 查询终端节点组列表
        ///
        /// 查询终端节点组列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEndpointGroupsResponse ListEndpointGroups(ListEndpointGroupsRequest listEndpointGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEndpointGroupsResponse>(response);
        }

        public SyncInvoker<ListEndpointGroupsResponse> ListEndpointGroupsInvoker(ListEndpointGroupsRequest listEndpointGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointGroupsRequest);
            return new SyncInvoker<ListEndpointGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEndpointGroupsResponse>);
        }
        
        /// <summary>
        /// 查询终端节点组详情
        ///
        /// 查询终端节点组详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowEndpointGroupResponse ShowEndpointGroup(ShowEndpointGroupRequest showEndpointGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showEndpointGroupRequest.EndpointGroupId, out var valueOfEndpointGroupId)) urlParam.Add("endpoint_group_id", valueOfEndpointGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups/{endpoint_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEndpointGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowEndpointGroupResponse>(response);
        }

        public SyncInvoker<ShowEndpointGroupResponse> ShowEndpointGroupInvoker(ShowEndpointGroupRequest showEndpointGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showEndpointGroupRequest.EndpointGroupId, out var valueOfEndpointGroupId)) urlParam.Add("endpoint_group_id", valueOfEndpointGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups/{endpoint_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEndpointGroupRequest);
            return new SyncInvoker<ShowEndpointGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEndpointGroupResponse>);
        }
        
        /// <summary>
        /// 更新终端节点组
        ///
        /// 更新终端节点组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateEndpointGroupResponse UpdateEndpointGroup(UpdateEndpointGroupRequest updateEndpointGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateEndpointGroupRequest.EndpointGroupId, out var valueOfEndpointGroupId)) urlParam.Add("endpoint_group_id", valueOfEndpointGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups/{endpoint_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEndpointGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateEndpointGroupResponse>(response);
        }

        public SyncInvoker<UpdateEndpointGroupResponse> UpdateEndpointGroupInvoker(UpdateEndpointGroupRequest updateEndpointGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateEndpointGroupRequest.EndpointGroupId, out var valueOfEndpointGroupId)) urlParam.Add("endpoint_group_id", valueOfEndpointGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/endpoint-groups/{endpoint_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEndpointGroupRequest);
            return new SyncInvoker<UpdateEndpointGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateEndpointGroupResponse>);
        }
        
        /// <summary>
        /// 创建健康检查
        ///
        /// 创建健康检查。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateHealthCheckResponse CreateHealthCheck(CreateHealthCheckRequest createHealthCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/health-checks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createHealthCheckRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateHealthCheckResponse>(response);
        }

        public SyncInvoker<CreateHealthCheckResponse> CreateHealthCheckInvoker(CreateHealthCheckRequest createHealthCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/health-checks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createHealthCheckRequest);
            return new SyncInvoker<CreateHealthCheckResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateHealthCheckResponse>);
        }
        
        /// <summary>
        /// 删除健康检查
        ///
        /// 删除健康检查。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteHealthCheckResponse DeleteHealthCheck(DeleteHealthCheckRequest deleteHealthCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteHealthCheckRequest.HealthCheckId, out var valueOfHealthCheckId)) urlParam.Add("health_check_id", valueOfHealthCheckId);
            var urlPath = HttpUtils.AddUrlPath("/v1/health-checks/{health_check_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHealthCheckRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteHealthCheckResponse>(response);
        }

        public SyncInvoker<DeleteHealthCheckResponse> DeleteHealthCheckInvoker(DeleteHealthCheckRequest deleteHealthCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteHealthCheckRequest.HealthCheckId, out var valueOfHealthCheckId)) urlParam.Add("health_check_id", valueOfHealthCheckId);
            var urlPath = HttpUtils.AddUrlPath("/v1/health-checks/{health_check_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHealthCheckRequest);
            return new SyncInvoker<DeleteHealthCheckResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteHealthCheckResponse>);
        }
        
        /// <summary>
        /// 查询健康检查列表
        ///
        /// 查询健康检查列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListHealthChecksResponse ListHealthChecks(ListHealthChecksRequest listHealthChecksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/health-checks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHealthChecksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListHealthChecksResponse>(response);
        }

        public SyncInvoker<ListHealthChecksResponse> ListHealthChecksInvoker(ListHealthChecksRequest listHealthChecksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/health-checks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHealthChecksRequest);
            return new SyncInvoker<ListHealthChecksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHealthChecksResponse>);
        }
        
        /// <summary>
        /// 查询健康检查详情
        ///
        /// 查询健康检查详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowHealthCheckResponse ShowHealthCheck(ShowHealthCheckRequest showHealthCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showHealthCheckRequest.HealthCheckId, out var valueOfHealthCheckId)) urlParam.Add("health_check_id", valueOfHealthCheckId);
            var urlPath = HttpUtils.AddUrlPath("/v1/health-checks/{health_check_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHealthCheckRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowHealthCheckResponse>(response);
        }

        public SyncInvoker<ShowHealthCheckResponse> ShowHealthCheckInvoker(ShowHealthCheckRequest showHealthCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showHealthCheckRequest.HealthCheckId, out var valueOfHealthCheckId)) urlParam.Add("health_check_id", valueOfHealthCheckId);
            var urlPath = HttpUtils.AddUrlPath("/v1/health-checks/{health_check_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHealthCheckRequest);
            return new SyncInvoker<ShowHealthCheckResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHealthCheckResponse>);
        }
        
        /// <summary>
        /// 更新健康检查
        ///
        /// 更新健康检查。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateHealthCheckResponse UpdateHealthCheck(UpdateHealthCheckRequest updateHealthCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateHealthCheckRequest.HealthCheckId, out var valueOfHealthCheckId)) urlParam.Add("health_check_id", valueOfHealthCheckId);
            var urlPath = HttpUtils.AddUrlPath("/v1/health-checks/{health_check_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHealthCheckRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateHealthCheckResponse>(response);
        }

        public SyncInvoker<UpdateHealthCheckResponse> UpdateHealthCheckInvoker(UpdateHealthCheckRequest updateHealthCheckRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateHealthCheckRequest.HealthCheckId, out var valueOfHealthCheckId)) urlParam.Add("health_check_id", valueOfHealthCheckId);
            var urlPath = HttpUtils.AddUrlPath("/v1/health-checks/{health_check_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHealthCheckRequest);
            return new SyncInvoker<UpdateHealthCheckResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateHealthCheckResponse>);
        }
        
        /// <summary>
        /// 添加IP地址组中的IP网段
        ///
        /// 添加IP地址组中的IP网段。
        /// 该接口属于异步接口，接口返回后，后台的添加任务仍在执行；可以使用查询IP地址组详情接口查询状态，当IP地址组状态为ACTIVE时，表示条目添加完成。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddIpGroupIpResponse AddIpGroupIp(AddIpGroupIpRequest addIpGroupIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addIpGroupIpRequest.IpGroupId, out var valueOfIpGroupId)) urlParam.Add("ip_group_id", valueOfIpGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/ip-groups/{ip_group_id}/add-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addIpGroupIpRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddIpGroupIpResponse>(response);
        }

        public SyncInvoker<AddIpGroupIpResponse> AddIpGroupIpInvoker(AddIpGroupIpRequest addIpGroupIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addIpGroupIpRequest.IpGroupId, out var valueOfIpGroupId)) urlParam.Add("ip_group_id", valueOfIpGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/ip-groups/{ip_group_id}/add-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addIpGroupIpRequest);
            return new SyncInvoker<AddIpGroupIpResponse>(this, "POST", request, JsonUtils.DeSerialize<AddIpGroupIpResponse>);
        }
        
        /// <summary>
        /// 绑定IP地址组与监听器
        ///
        /// 绑定IP地址组与监听器。
        /// 该接口属于异步接口，接口返回后，后台的绑定任务仍在执行；可以使用查询IP地址组详情接口查询状态，当IP地址组状态为ACTIVE时，表示绑定完成。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AssociateListenerResponse AssociateListener(AssociateListenerRequest associateListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateListenerRequest.IpGroupId, out var valueOfIpGroupId)) urlParam.Add("ip_group_id", valueOfIpGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/ip-groups/{ip_group_id}/associate-listener", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateListenerRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AssociateListenerResponse>(response);
        }

        public SyncInvoker<AssociateListenerResponse> AssociateListenerInvoker(AssociateListenerRequest associateListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateListenerRequest.IpGroupId, out var valueOfIpGroupId)) urlParam.Add("ip_group_id", valueOfIpGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/ip-groups/{ip_group_id}/associate-listener", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateListenerRequest);
            return new SyncInvoker<AssociateListenerResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateListenerResponse>);
        }
        
        /// <summary>
        /// 创建IP地址组
        ///
        /// 创建IP地址组。
        /// 该接口属于异步接口，会先返回一个IP地址组ID，但后台的创建任务仍在执行；可以使用查询IP地址组详情接口查询状态，当IP地址组状态为ACTIVE时，表示IP地址组创建完成。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateIpGroupResponse CreateIpGroup(CreateIpGroupRequest createIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/ip-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createIpGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateIpGroupResponse>(response);
        }

        public SyncInvoker<CreateIpGroupResponse> CreateIpGroupInvoker(CreateIpGroupRequest createIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/ip-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createIpGroupRequest);
            return new SyncInvoker<CreateIpGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateIpGroupResponse>);
        }
        
        /// <summary>
        /// 删除IP地址组
        ///
        /// 删除IP地址组。
        /// 该接口属于异步接口，接口返回后，后台的删除任务仍在执行；可以使用查询IP地址组详情接口查询状态，当查询不到该IP地址组时，表示删除完成；删除IP地址组时，若IP地址组已经绑定了监听器，则需要先解绑IP地址组与监听器，再进行删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteIpGroupResponse DeleteIpGroup(DeleteIpGroupRequest deleteIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteIpGroupRequest.IpGroupId, out var valueOfIpGroupId)) urlParam.Add("ip_group_id", valueOfIpGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/ip-groups/{ip_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIpGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteIpGroupResponse>(response);
        }

        public SyncInvoker<DeleteIpGroupResponse> DeleteIpGroupInvoker(DeleteIpGroupRequest deleteIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteIpGroupRequest.IpGroupId, out var valueOfIpGroupId)) urlParam.Add("ip_group_id", valueOfIpGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/ip-groups/{ip_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIpGroupRequest);
            return new SyncInvoker<DeleteIpGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteIpGroupResponse>);
        }
        
        /// <summary>
        /// 解绑IP地址组与监听器
        ///
        /// 解绑IP地址组与监听器。
        /// 该接口属于异步接口，接口返回后，后台的解绑任务仍在执行；可以使用查询IP地址组详情接口查询状态，当IP地址组状态为ACTIVE时，表示解绑完成。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisassociateListenerResponse DisassociateListener(DisassociateListenerRequest disassociateListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disassociateListenerRequest.IpGroupId, out var valueOfIpGroupId)) urlParam.Add("ip_group_id", valueOfIpGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/ip-groups/{ip_group_id}/disassociate-listener", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateListenerRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DisassociateListenerResponse>(response);
        }

        public SyncInvoker<DisassociateListenerResponse> DisassociateListenerInvoker(DisassociateListenerRequest disassociateListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disassociateListenerRequest.IpGroupId, out var valueOfIpGroupId)) urlParam.Add("ip_group_id", valueOfIpGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/ip-groups/{ip_group_id}/disassociate-listener", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateListenerRequest);
            return new SyncInvoker<DisassociateListenerResponse>(this, "POST", request, JsonUtils.DeSerialize<DisassociateListenerResponse>);
        }
        
        /// <summary>
        /// 查询IP地址组列表
        ///
        /// 查询IP地址组列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListIpGroupsResponse ListIpGroups(ListIpGroupsRequest listIpGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/ip-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListIpGroupsResponse>(response);
        }

        public SyncInvoker<ListIpGroupsResponse> ListIpGroupsInvoker(ListIpGroupsRequest listIpGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/ip-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpGroupsRequest);
            return new SyncInvoker<ListIpGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListIpGroupsResponse>);
        }
        
        /// <summary>
        /// 删除IP地址组中的IP网段
        ///
        /// 删除IP地址组中的IP网段。
        /// 该接口属于异步接口，接口返回后，后台的删除任务仍在执行；可以使用查询IP地址组详情接口查询状态，当IP地址组状态为ACTIVE时，表示条目删除完成。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RemoveIpGroupIpResponse RemoveIpGroupIp(RemoveIpGroupIpRequest removeIpGroupIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeIpGroupIpRequest.IpGroupId, out var valueOfIpGroupId)) urlParam.Add("ip_group_id", valueOfIpGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/ip-groups/{ip_group_id}/remove-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeIpGroupIpRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RemoveIpGroupIpResponse>(response);
        }

        public SyncInvoker<RemoveIpGroupIpResponse> RemoveIpGroupIpInvoker(RemoveIpGroupIpRequest removeIpGroupIpRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeIpGroupIpRequest.IpGroupId, out var valueOfIpGroupId)) urlParam.Add("ip_group_id", valueOfIpGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/ip-groups/{ip_group_id}/remove-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeIpGroupIpRequest);
            return new SyncInvoker<RemoveIpGroupIpResponse>(this, "POST", request, JsonUtils.DeSerialize<RemoveIpGroupIpResponse>);
        }
        
        /// <summary>
        /// 查询IP地址组详情
        ///
        /// 查询IP地址组详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowIpGroupResponse ShowIpGroup(ShowIpGroupRequest showIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showIpGroupRequest.IpGroupId, out var valueOfIpGroupId)) urlParam.Add("ip_group_id", valueOfIpGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/ip-groups/{ip_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowIpGroupResponse>(response);
        }

        public SyncInvoker<ShowIpGroupResponse> ShowIpGroupInvoker(ShowIpGroupRequest showIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showIpGroupRequest.IpGroupId, out var valueOfIpGroupId)) urlParam.Add("ip_group_id", valueOfIpGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/ip-groups/{ip_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpGroupRequest);
            return new SyncInvoker<ShowIpGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowIpGroupResponse>);
        }
        
        /// <summary>
        /// 更新IP地址组
        ///
        /// 更新IP地址组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateIpGroupResponse UpdateIpGroup(UpdateIpGroupRequest updateIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateIpGroupRequest.IpGroupId, out var valueOfIpGroupId)) urlParam.Add("ip_group_id", valueOfIpGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/ip-groups/{ip_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateIpGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateIpGroupResponse>(response);
        }

        public SyncInvoker<UpdateIpGroupResponse> UpdateIpGroupInvoker(UpdateIpGroupRequest updateIpGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateIpGroupRequest.IpGroupId, out var valueOfIpGroupId)) urlParam.Add("ip_group_id", valueOfIpGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/ip-groups/{ip_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateIpGroupRequest);
            return new SyncInvoker<UpdateIpGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateIpGroupResponse>);
        }
        
        /// <summary>
        /// 创建监听器
        ///
        /// 创建监听器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateListenerResponse CreateListener(CreateListenerRequest createListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/listeners", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createListenerRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateListenerResponse>(response);
        }

        public SyncInvoker<CreateListenerResponse> CreateListenerInvoker(CreateListenerRequest createListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/listeners", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createListenerRequest);
            return new SyncInvoker<CreateListenerResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateListenerResponse>);
        }
        
        /// <summary>
        /// 删除监听器
        ///
        /// 删除监听器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteListenerResponse DeleteListener(DeleteListenerRequest deleteListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteListenerRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/listeners/{listener_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteListenerRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteListenerResponse>(response);
        }

        public SyncInvoker<DeleteListenerResponse> DeleteListenerInvoker(DeleteListenerRequest deleteListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteListenerRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/listeners/{listener_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteListenerRequest);
            return new SyncInvoker<DeleteListenerResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteListenerResponse>);
        }
        
        /// <summary>
        /// 查询监听器列表
        ///
        /// 查询监听器列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListListenersResponse ListListeners(ListListenersRequest listListenersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/listeners", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listListenersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListListenersResponse>(response);
        }

        public SyncInvoker<ListListenersResponse> ListListenersInvoker(ListListenersRequest listListenersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/listeners", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listListenersRequest);
            return new SyncInvoker<ListListenersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListListenersResponse>);
        }
        
        /// <summary>
        /// 查询监听器详情
        ///
        /// 查询监听器详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowListenerResponse ShowListener(ShowListenerRequest showListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showListenerRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/listeners/{listener_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showListenerRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowListenerResponse>(response);
        }

        public SyncInvoker<ShowListenerResponse> ShowListenerInvoker(ShowListenerRequest showListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showListenerRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/listeners/{listener_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showListenerRequest);
            return new SyncInvoker<ShowListenerResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowListenerResponse>);
        }
        
        /// <summary>
        /// 更新监听器
        ///
        /// 更新监听器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateListenerResponse UpdateListener(UpdateListenerRequest updateListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateListenerRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/listeners/{listener_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateListenerRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateListenerResponse>(response);
        }

        public SyncInvoker<UpdateListenerResponse> UpdateListenerInvoker(UpdateListenerRequest updateListenerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateListenerRequest.ListenerId, out var valueOfListenerId)) urlParam.Add("listener_id", valueOfListenerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/listeners/{listener_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateListenerRequest);
            return new SyncInvoker<UpdateListenerResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateListenerResponse>);
        }
        
        /// <summary>
        /// 创建云日志
        ///
        /// 创建云日志。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateLogtankResponse CreateLogtank(CreateLogtankRequest createLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/logtanks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLogtankRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateLogtankResponse>(response);
        }

        public SyncInvoker<CreateLogtankResponse> CreateLogtankInvoker(CreateLogtankRequest createLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/logtanks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLogtankRequest);
            return new SyncInvoker<CreateLogtankResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateLogtankResponse>);
        }
        
        /// <summary>
        /// 删除云日志
        ///
        /// 删除云日志。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteLogtankResponse DeleteLogtank(DeleteLogtankRequest deleteLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteLogtankRequest.LogtankId, out var valueOfLogtankId)) urlParam.Add("logtank_id", valueOfLogtankId);
            var urlPath = HttpUtils.AddUrlPath("/v1/logtanks/{logtank_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLogtankRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteLogtankResponse>(response);
        }

        public SyncInvoker<DeleteLogtankResponse> DeleteLogtankInvoker(DeleteLogtankRequest deleteLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteLogtankRequest.LogtankId, out var valueOfLogtankId)) urlParam.Add("logtank_id", valueOfLogtankId);
            var urlPath = HttpUtils.AddUrlPath("/v1/logtanks/{logtank_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLogtankRequest);
            return new SyncInvoker<DeleteLogtankResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteLogtankResponse>);
        }
        
        /// <summary>
        /// 查询云日志列表
        ///
        /// 查询云日志列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLogtanksResponse ListLogtanks(ListLogtanksRequest listLogtanksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/logtanks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogtanksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListLogtanksResponse>(response);
        }

        public SyncInvoker<ListLogtanksResponse> ListLogtanksInvoker(ListLogtanksRequest listLogtanksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/logtanks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogtanksRequest);
            return new SyncInvoker<ListLogtanksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLogtanksResponse>);
        }
        
        /// <summary>
        /// 查询云日志详情
        ///
        /// 查询云日志详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowLogtankResponse ShowLogtank(ShowLogtankRequest showLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLogtankRequest.LogtankId, out var valueOfLogtankId)) urlParam.Add("logtank_id", valueOfLogtankId);
            var urlPath = HttpUtils.AddUrlPath("/v1/logtanks/{logtank_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogtankRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowLogtankResponse>(response);
        }

        public SyncInvoker<ShowLogtankResponse> ShowLogtankInvoker(ShowLogtankRequest showLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLogtankRequest.LogtankId, out var valueOfLogtankId)) urlParam.Add("logtank_id", valueOfLogtankId);
            var urlPath = HttpUtils.AddUrlPath("/v1/logtanks/{logtank_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogtankRequest);
            return new SyncInvoker<ShowLogtankResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLogtankResponse>);
        }
        
        /// <summary>
        /// 更新云日志
        ///
        /// 更新云日志。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateLogtankResponse UpdateLogtank(UpdateLogtankRequest updateLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateLogtankRequest.LogtankId, out var valueOfLogtankId)) urlParam.Add("logtank_id", valueOfLogtankId);
            var urlPath = HttpUtils.AddUrlPath("/v1/logtanks/{logtank_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLogtankRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateLogtankResponse>(response);
        }

        public SyncInvoker<UpdateLogtankResponse> UpdateLogtankInvoker(UpdateLogtankRequest updateLogtankRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateLogtankRequest.LogtankId, out var valueOfLogtankId)) urlParam.Add("logtank_id", valueOfLogtankId);
            var urlPath = HttpUtils.AddUrlPath("/v1/logtanks/{logtank_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLogtankRequest);
            return new SyncInvoker<UpdateLogtankResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateLogtankResponse>);
        }
        
        /// <summary>
        /// 查询pop列表
        ///
        /// 查询pop列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAllPopsResponse ListAllPops(ListAllPopsRequest listAllPopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/pops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllPopsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAllPopsResponse>(response);
        }

        public SyncInvoker<ListAllPopsResponse> ListAllPopsInvoker(ListAllPopsRequest listAllPopsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/pops", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllPopsRequest);
            return new SyncInvoker<ListAllPopsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAllPopsResponse>);
        }
        
        /// <summary>
        /// 查询配额列表
        ///
        /// 查询配额列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTenantQuotasResponse ListTenantQuotas(ListTenantQuotasRequest listTenantQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTenantQuotasRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/ga/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantQuotasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTenantQuotasResponse>(response);
        }

        public SyncInvoker<ListTenantQuotasResponse> ListTenantQuotasInvoker(ListTenantQuotasRequest listTenantQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTenantQuotasRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/ga/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantQuotasRequest);
            return new SyncInvoker<ListTenantQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTenantQuotasResponse>);
        }
        
        /// <summary>
        /// 查询区域列表
        ///
        /// 查询区域列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRegionsResponse ListRegions(ListRegionsRequest listRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRegionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRegionsResponse>(response);
        }

        public SyncInvoker<ListRegionsResponse> ListRegionsInvoker(ListRegionsRequest listRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRegionsRequest);
            return new SyncInvoker<ListRegionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRegionsResponse>);
        }
        
        /// <summary>
        /// 通过标签查询资源实例数量
        ///
        /// 通过标签查询资源实例数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CountResourcesByTagResponse CountResourcesByTag(CountResourcesByTagRequest countResourcesByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countResourcesByTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/{resource_type}/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countResourcesByTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CountResourcesByTagResponse>(response);
        }

        public SyncInvoker<CountResourcesByTagResponse> CountResourcesByTagInvoker(CountResourcesByTagRequest countResourcesByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(countResourcesByTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/{resource_type}/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countResourcesByTagRequest);
            return new SyncInvoker<CountResourcesByTagResponse>(this, "POST", request, JsonUtils.DeSerialize<CountResourcesByTagResponse>);
        }
        
        /// <summary>
        /// 创建资源标签
        ///
        /// 创建资源标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTagsResponse CreateTags(CreateTagsRequest createTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(createTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateTagsResponse>(response);
        }

        public SyncInvoker<CreateTagsResponse> CreateTagsInvoker(CreateTagsRequest createTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(createTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagsRequest);
            return new SyncInvoker<CreateTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTagsResponse>);
        }
        
        /// <summary>
        /// 删除资源标签
        ///
        /// 删除资源标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTagsResponse DeleteTags(DeleteTagsRequest deleteTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(deleteTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteTagsResponse>(response);
        }

        public SyncInvoker<DeleteTagsResponse> DeleteTagsInvoker(DeleteTagsRequest deleteTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(deleteTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagsRequest);
            return new SyncInvoker<DeleteTagsResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteTagsResponse>);
        }
        
        /// <summary>
        /// 通过标签查询资源实例列表
        ///
        /// 通过标签查询资源实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListResourcesByTagResponse ListResourcesByTag(ListResourcesByTagRequest listResourcesByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourcesByTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/{resource_type}/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourcesByTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListResourcesByTagResponse>(response);
        }

        public SyncInvoker<ListResourcesByTagResponse> ListResourcesByTagInvoker(ListResourcesByTagRequest listResourcesByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourcesByTagRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/{resource_type}/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourcesByTagRequest);
            return new SyncInvoker<ListResourcesByTagResponse>(this, "POST", request, JsonUtils.DeSerialize<ListResourcesByTagResponse>);
        }
        
        /// <summary>
        /// 查询标签列表
        ///
        /// 查询标签列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTagsResponse ListTags(ListTagsRequest listTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTagsResponse>(response);
        }

        public SyncInvoker<ListTagsResponse> ListTagsInvoker(ListTagsRequest listTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v1/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsRequest);
            return new SyncInvoker<ListTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTagsResponse>);
        }
        
        /// <summary>
        /// 查询特定资源标签
        ///
        /// 查询特定资源标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowResourceTagsResponse ShowResourceTags(ShowResourceTagsRequest showResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(showResourceTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowResourceTagsResponse>(response);
        }

        public SyncInvoker<ShowResourceTagsResponse> ShowResourceTagsInvoker(ShowResourceTagsRequest showResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(showResourceTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceTagsRequest);
            return new SyncInvoker<ShowResourceTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceTagsResponse>);
        }
        
    }
}