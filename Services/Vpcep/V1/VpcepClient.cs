using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Vpcep.V1.Model;

namespace HuaweiCloud.SDK.Vpcep.V1
{
    public partial class VpcepClient : Client
    {
        public static ClientBuilder<VpcepClient> NewBuilder()
        {
            return new ClientBuilder<VpcepClient>();
        }

        
        /// <summary>
        /// 接受或拒绝终端节点的连接
        ///
        /// 接受或者拒绝终端节点连接到当前的终端节点服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AcceptOrRejectEndpointResponse AcceptOrRejectEndpoint(AcceptOrRejectEndpointRequest acceptOrRejectEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", acceptOrRejectEndpointRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/connections/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", acceptOrRejectEndpointRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AcceptOrRejectEndpointResponse>(response);
        }

        public SyncInvoker<AcceptOrRejectEndpointResponse> AcceptOrRejectEndpointInvoker(AcceptOrRejectEndpointRequest acceptOrRejectEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", acceptOrRejectEndpointRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/connections/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", acceptOrRejectEndpointRequest);
            return new SyncInvoker<AcceptOrRejectEndpointResponse>(this, "POST", request, JsonUtils.DeSerialize<AcceptOrRejectEndpointResponse>);
        }
        
        /// <summary>
        /// 批量添加或移除终端节点服务的白名单
        ///
        /// 批量添加或移除当前用户下终端节点服务的白名单。
        /// 说明
        /// 本账号默认在自身用户的终端节点服务的白名单中。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddOrRemoveServicePermissionsResponse AddOrRemoveServicePermissions(AddOrRemoveServicePermissionsRequest addOrRemoveServicePermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", addOrRemoveServicePermissionsRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/permissions/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addOrRemoveServicePermissionsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddOrRemoveServicePermissionsResponse>(response);
        }

        public SyncInvoker<AddOrRemoveServicePermissionsResponse> AddOrRemoveServicePermissionsInvoker(AddOrRemoveServicePermissionsRequest addOrRemoveServicePermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", addOrRemoveServicePermissionsRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/permissions/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addOrRemoveServicePermissionsRequest);
            return new SyncInvoker<AddOrRemoveServicePermissionsResponse>(this, "POST", request, JsonUtils.DeSerialize<AddOrRemoveServicePermissionsResponse>);
        }
        
        /// <summary>
        /// 批量添加终端节点服务的白名单
        ///
        /// 批量添加当前用户下终端节点服务的白名单，支持添加描述信息。
        /// 说明
        /// 本账号默认在自身用户的终端节点服务的白名单中。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchAddEndpointServicePermissionsResponse BatchAddEndpointServicePermissions(BatchAddEndpointServicePermissionsRequest batchAddEndpointServicePermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", batchAddEndpointServicePermissionsRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/permissions/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddEndpointServicePermissionsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchAddEndpointServicePermissionsResponse>(response);
        }

        public SyncInvoker<BatchAddEndpointServicePermissionsResponse> BatchAddEndpointServicePermissionsInvoker(BatchAddEndpointServicePermissionsRequest batchAddEndpointServicePermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", batchAddEndpointServicePermissionsRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/permissions/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddEndpointServicePermissionsRequest);
            return new SyncInvoker<BatchAddEndpointServicePermissionsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchAddEndpointServicePermissionsResponse>);
        }
        
        /// <summary>
        /// 批量删除终端节点服务的白名单
        ///
        /// 批量删除当前用户下终端节点服务的白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchRemoveEndpointServicePermissionsResponse BatchRemoveEndpointServicePermissions(BatchRemoveEndpointServicePermissionsRequest batchRemoveEndpointServicePermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", batchRemoveEndpointServicePermissionsRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/permissions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchRemoveEndpointServicePermissionsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchRemoveEndpointServicePermissionsResponse>(response);
        }

        public SyncInvoker<BatchRemoveEndpointServicePermissionsResponse> BatchRemoveEndpointServicePermissionsInvoker(BatchRemoveEndpointServicePermissionsRequest batchRemoveEndpointServicePermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", batchRemoveEndpointServicePermissionsRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/permissions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchRemoveEndpointServicePermissionsRequest);
            return new SyncInvoker<BatchRemoveEndpointServicePermissionsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchRemoveEndpointServicePermissionsResponse>);
        }
        
        /// <summary>
        /// 创建终端节点
        ///
        /// 创建终端节点，以便访问终端节点服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateEndpointResponse CreateEndpoint(CreateEndpointRequest createEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createEndpointRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateEndpointResponse>(response);
        }

        public SyncInvoker<CreateEndpointResponse> CreateEndpointInvoker(CreateEndpointRequest createEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createEndpointRequest);
            return new SyncInvoker<CreateEndpointResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateEndpointResponse>);
        }
        
        /// <summary>
        /// 创建终端节点服务
        ///
        /// 创建终端节点服务，允许其他用户创建终端节点连接您创建的终端节点服务，
        /// 使用您所提供的服务。
        /// 说明
        /// 该接口为异步接口，调用成功会返回200状态码，说明请求已正常下发。
        /// 通常创建终端节点服务需要1~2分钟，可以通过查询终端节点服务详情查看创建结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateEndpointServiceResponse CreateEndpointService(CreateEndpointServiceRequest createEndpointServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createEndpointServiceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateEndpointServiceResponse>(response);
        }

        public SyncInvoker<CreateEndpointServiceResponse> CreateEndpointServiceInvoker(CreateEndpointServiceRequest createEndpointServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createEndpointServiceRequest);
            return new SyncInvoker<CreateEndpointServiceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateEndpointServiceResponse>);
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
            urlParam.Add("vpc_endpoint_id", deleteEndpointRequest.VpcEndpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints/{vpc_endpoint_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEndpointRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteEndpointResponse>(response);
        }

        public SyncInvoker<DeleteEndpointResponse> DeleteEndpointInvoker(DeleteEndpointRequest deleteEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_id", deleteEndpointRequest.VpcEndpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints/{vpc_endpoint_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEndpointRequest);
            return new SyncInvoker<DeleteEndpointResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteEndpointResponse>);
        }
        
        /// <summary>
        /// 删除网关型终端节点policy
        ///
        /// 删除网关型终端节点policy。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteEndpointPolicyResponse DeleteEndpointPolicy(DeleteEndpointPolicyRequest deleteEndpointPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_id", deleteEndpointPolicyRequest.VpcEndpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints/{vpc_endpoint_id}/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEndpointPolicyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteEndpointPolicyResponse>(response);
        }

        public SyncInvoker<DeleteEndpointPolicyResponse> DeleteEndpointPolicyInvoker(DeleteEndpointPolicyRequest deleteEndpointPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_id", deleteEndpointPolicyRequest.VpcEndpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints/{vpc_endpoint_id}/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEndpointPolicyRequest);
            return new SyncInvoker<DeleteEndpointPolicyResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteEndpointPolicyResponse>);
        }
        
        /// <summary>
        /// 删除终端节点服务
        ///
        /// 删除终端节点服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteEndpointServiceResponse DeleteEndpointService(DeleteEndpointServiceRequest deleteEndpointServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", deleteEndpointServiceRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEndpointServiceRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteEndpointServiceResponse>(response);
        }

        public SyncInvoker<DeleteEndpointServiceResponse> DeleteEndpointServiceInvoker(DeleteEndpointServiceRequest deleteEndpointServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", deleteEndpointServiceRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEndpointServiceRequest);
            return new SyncInvoker<DeleteEndpointServiceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteEndpointServiceResponse>);
        }
        
        /// <summary>
        /// 查询终端节点详情
        ///
        /// 查询终端节点的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEndpointInfoDetailsResponse ListEndpointInfoDetails(ListEndpointInfoDetailsRequest listEndpointInfoDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_id", listEndpointInfoDetailsRequest.VpcEndpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints/{vpc_endpoint_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointInfoDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEndpointInfoDetailsResponse>(response);
        }

        public SyncInvoker<ListEndpointInfoDetailsResponse> ListEndpointInfoDetailsInvoker(ListEndpointInfoDetailsRequest listEndpointInfoDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_id", listEndpointInfoDetailsRequest.VpcEndpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints/{vpc_endpoint_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointInfoDetailsRequest);
            return new SyncInvoker<ListEndpointInfoDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEndpointInfoDetailsResponse>);
        }
        
        /// <summary>
        /// 查询终端节点服务列表
        ///
        /// 查询当前用户下的终端节点服务的列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEndpointServiceResponse ListEndpointService(ListEndpointServiceRequest listEndpointServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointServiceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEndpointServiceResponse>(response);
        }

        public SyncInvoker<ListEndpointServiceResponse> ListEndpointServiceInvoker(ListEndpointServiceRequest listEndpointServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointServiceRequest);
            return new SyncInvoker<ListEndpointServiceResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEndpointServiceResponse>);
        }
        
        /// <summary>
        /// 查询终端节点列表
        ///
        /// 查询当前用户下的终端节点的列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEndpointsResponse ListEndpoints(ListEndpointsRequest listEndpointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEndpointsResponse>(response);
        }

        public SyncInvoker<ListEndpointsResponse> ListEndpointsInvoker(ListEndpointsRequest listEndpointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointsRequest);
            return new SyncInvoker<ListEndpointsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEndpointsResponse>);
        }
        
        /// <summary>
        /// 查询配额
        ///
        /// 查询用户的资源配额，包括终端节点服务和终端节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListQuotaDetailsResponse ListQuotaDetails(ListQuotaDetailsRequest listQuotaDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotaDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListQuotaDetailsResponse>(response);
        }

        public SyncInvoker<ListQuotaDetailsResponse> ListQuotaDetailsInvoker(ListQuotaDetailsRequest listQuotaDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotaDetailsRequest);
            return new SyncInvoker<ListQuotaDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListQuotaDetailsResponse>);
        }
        
        /// <summary>
        /// 查询连接终端节点服务的连接列表
        ///
        /// 查询连接当前用户下的某一个终端节点服务的连接列表。marker_id是连接的唯一标识。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListServiceConnectionsResponse ListServiceConnections(ListServiceConnectionsRequest listServiceConnectionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", listServiceConnectionsRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/connections", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceConnectionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListServiceConnectionsResponse>(response);
        }

        public SyncInvoker<ListServiceConnectionsResponse> ListServiceConnectionsInvoker(ListServiceConnectionsRequest listServiceConnectionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", listServiceConnectionsRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/connections", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceConnectionsRequest);
            return new SyncInvoker<ListServiceConnectionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServiceConnectionsResponse>);
        }
        
        /// <summary>
        /// 查询终端节点服务概要
        ///
        /// 查询终端节点服务的概要信息， 此接口是供创建终端节点的用户来查询需要连接的终端节点服务信息。 此接口既可以方便其他用户查询到您的终端节点服务概要信息, 又可以避免您的终端节点服务的细节信息暴露给其他用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListServiceDescribeDetailsResponse ListServiceDescribeDetails(ListServiceDescribeDetailsRequest listServiceDescribeDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/describe", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceDescribeDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListServiceDescribeDetailsResponse>(response);
        }

        public SyncInvoker<ListServiceDescribeDetailsResponse> ListServiceDescribeDetailsInvoker(ListServiceDescribeDetailsRequest listServiceDescribeDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/describe", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceDescribeDetailsRequest);
            return new SyncInvoker<ListServiceDescribeDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServiceDescribeDetailsResponse>);
        }
        
        /// <summary>
        /// 查询终端节点服务详情
        ///
        /// 查询终端节点服务的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListServiceDetailsResponse ListServiceDetails(ListServiceDetailsRequest listServiceDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", listServiceDetailsRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListServiceDetailsResponse>(response);
        }

        public SyncInvoker<ListServiceDetailsResponse> ListServiceDetailsInvoker(ListServiceDetailsRequest listServiceDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", listServiceDetailsRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceDetailsRequest);
            return new SyncInvoker<ListServiceDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServiceDetailsResponse>);
        }
        
        /// <summary>
        /// 查询终端节点服务的白名单列表
        ///
        /// 查询当前用户下终端节点服务的白名单列表。
        /// 说明
        /// 本账号默认在当前用户下终端节点服务的白名单中。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListServicePermissionsDetailsResponse ListServicePermissionsDetails(ListServicePermissionsDetailsRequest listServicePermissionsDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", listServicePermissionsDetailsRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServicePermissionsDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListServicePermissionsDetailsResponse>(response);
        }

        public SyncInvoker<ListServicePermissionsDetailsResponse> ListServicePermissionsDetailsInvoker(ListServicePermissionsDetailsRequest listServicePermissionsDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", listServicePermissionsDetailsRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServicePermissionsDetailsRequest);
            return new SyncInvoker<ListServicePermissionsDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServicePermissionsDetailsResponse>);
        }
        
        /// <summary>
        /// 查询公共终端节点服务列表
        ///
        /// 查询公共终端节点服务的列表，公共终端节点服务是所有用户可见且可连接的终端节点服务，
        /// 由运维人员创建，用户可直接使用，但无权创建。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListServicePublicDetailsResponse ListServicePublicDetails(ListServicePublicDetailsRequest listServicePublicDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/public", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServicePublicDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListServicePublicDetailsResponse>(response);
        }

        public SyncInvoker<ListServicePublicDetailsResponse> ListServicePublicDetailsInvoker(ListServicePublicDetailsRequest listServicePublicDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/public", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServicePublicDetailsRequest);
            return new SyncInvoker<ListServicePublicDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServicePublicDetailsResponse>);
        }
        
        /// <summary>
        /// 查询指定VPC终端节点接口版本信息
        ///
        /// 查询指定VPC终端节点接口版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSpecifiedVersionDetailsResponse ListSpecifiedVersionDetails(ListSpecifiedVersionDetailsRequest listSpecifiedVersionDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("version", listSpecifiedVersionDetailsRequest.Version.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSpecifiedVersionDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSpecifiedVersionDetailsResponse>(response);
        }

        public SyncInvoker<ListSpecifiedVersionDetailsResponse> ListSpecifiedVersionDetailsInvoker(ListSpecifiedVersionDetailsRequest listSpecifiedVersionDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("version", listSpecifiedVersionDetailsRequest.Version.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSpecifiedVersionDetailsRequest);
            return new SyncInvoker<ListSpecifiedVersionDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSpecifiedVersionDetailsResponse>);
        }
        
        /// <summary>
        /// 查询VPC终端节点接口版本列表
        ///
        /// 查询VPC终端节点接口版本列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListVersionDetailsResponse ListVersionDetails(ListVersionDetailsRequest listVersionDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListVersionDetailsResponse>(response);
        }

        public SyncInvoker<ListVersionDetailsResponse> ListVersionDetailsInvoker(ListVersionDetailsRequest listVersionDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionDetailsRequest);
            return new SyncInvoker<ListVersionDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVersionDetailsResponse>);
        }
        
        /// <summary>
        /// 更新终端节点连接描述
        ///
        /// 更新终端节点服务连接的终端节点的描述。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateEndpointConnectionsDescResponse UpdateEndpointConnectionsDesc(UpdateEndpointConnectionsDescRequest updateEndpointConnectionsDescRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", updateEndpointConnectionsDescRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/connections/description", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEndpointConnectionsDescRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateEndpointConnectionsDescResponse>(response);
        }

        public SyncInvoker<UpdateEndpointConnectionsDescResponse> UpdateEndpointConnectionsDescInvoker(UpdateEndpointConnectionsDescRequest updateEndpointConnectionsDescRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", updateEndpointConnectionsDescRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/connections/description", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEndpointConnectionsDescRequest);
            return new SyncInvoker<UpdateEndpointConnectionsDescResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateEndpointConnectionsDescResponse>);
        }
        
        /// <summary>
        /// 修改网关型终端节点policy
        ///
        /// 修改网关型终端节点policy。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateEndpointPolicyResponse UpdateEndpointPolicy(UpdateEndpointPolicyRequest updateEndpointPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_id", updateEndpointPolicyRequest.VpcEndpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints/{vpc_endpoint_id}/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEndpointPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateEndpointPolicyResponse>(response);
        }

        public SyncInvoker<UpdateEndpointPolicyResponse> UpdateEndpointPolicyInvoker(UpdateEndpointPolicyRequest updateEndpointPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_id", updateEndpointPolicyRequest.VpcEndpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints/{vpc_endpoint_id}/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEndpointPolicyRequest);
            return new SyncInvoker<UpdateEndpointPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateEndpointPolicyResponse>);
        }
        
        /// <summary>
        /// 修改终端节点的路由表
        ///
        /// 修改终端节点的路由表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateEndpointRoutetableResponse UpdateEndpointRoutetable(UpdateEndpointRoutetableRequest updateEndpointRoutetableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_id", updateEndpointRoutetableRequest.VpcEndpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints/{vpc_endpoint_id}/routetables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEndpointRoutetableRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateEndpointRoutetableResponse>(response);
        }

        public SyncInvoker<UpdateEndpointRoutetableResponse> UpdateEndpointRoutetableInvoker(UpdateEndpointRoutetableRequest updateEndpointRoutetableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_id", updateEndpointRoutetableRequest.VpcEndpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints/{vpc_endpoint_id}/routetables", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEndpointRoutetableRequest);
            return new SyncInvoker<UpdateEndpointRoutetableResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateEndpointRoutetableResponse>);
        }
        
        /// <summary>
        /// 修改终端节点服务
        ///
        /// 修改终端节点服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateEndpointServiceResponse UpdateEndpointService(UpdateEndpointServiceRequest updateEndpointServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", updateEndpointServiceRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEndpointServiceRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateEndpointServiceResponse>(response);
        }

        public SyncInvoker<UpdateEndpointServiceResponse> UpdateEndpointServiceInvoker(UpdateEndpointServiceRequest updateEndpointServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", updateEndpointServiceRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEndpointServiceRequest);
            return new SyncInvoker<UpdateEndpointServiceResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateEndpointServiceResponse>);
        }
        
        /// <summary>
        /// 修改终端节点服务名称
        ///
        /// 修改终端节点服务名称
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateEndpointServiceNameResponse UpdateEndpointServiceName(UpdateEndpointServiceNameRequest updateEndpointServiceNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", updateEndpointServiceNameRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEndpointServiceNameRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateEndpointServiceNameResponse>(response);
        }

        public SyncInvoker<UpdateEndpointServiceNameResponse> UpdateEndpointServiceNameInvoker(UpdateEndpointServiceNameRequest updateEndpointServiceNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", updateEndpointServiceNameRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEndpointServiceNameRequest);
            return new SyncInvoker<UpdateEndpointServiceNameResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateEndpointServiceNameResponse>);
        }
        
        /// <summary>
        /// 更新终端节点服务白名单描述
        ///
        /// 更新当前用户下终端节点服务白名单的描述信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateEndpointServicePermissionDescResponse UpdateEndpointServicePermissionDesc(UpdateEndpointServicePermissionDescRequest updateEndpointServicePermissionDescRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", updateEndpointServicePermissionDescRequest.VpcEndpointServiceId.ToString());
            urlParam.Add("permission_id", updateEndpointServicePermissionDescRequest.PermissionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/permissions/{permission_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEndpointServicePermissionDescRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateEndpointServicePermissionDescResponse>(response);
        }

        public SyncInvoker<UpdateEndpointServicePermissionDescResponse> UpdateEndpointServicePermissionDescInvoker(UpdateEndpointServicePermissionDescRequest updateEndpointServicePermissionDescRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", updateEndpointServicePermissionDescRequest.VpcEndpointServiceId.ToString());
            urlParam.Add("permission_id", updateEndpointServicePermissionDescRequest.PermissionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/permissions/{permission_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEndpointServicePermissionDescRequest);
            return new SyncInvoker<UpdateEndpointServicePermissionDescResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateEndpointServicePermissionDescResponse>);
        }
        
        /// <summary>
        /// 更新终端节点
        ///
        /// 更新或删除允许访问终端节点的白名单。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateEndpointWhiteResponse UpdateEndpointWhite(UpdateEndpointWhiteRequest updateEndpointWhiteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_id", updateEndpointWhiteRequest.VpcEndpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints/{vpc_endpoint_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEndpointWhiteRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateEndpointWhiteResponse>(response);
        }

        public SyncInvoker<UpdateEndpointWhiteResponse> UpdateEndpointWhiteInvoker(UpdateEndpointWhiteRequest updateEndpointWhiteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_id", updateEndpointWhiteRequest.VpcEndpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints/{vpc_endpoint_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEndpointWhiteRequest);
            return new SyncInvoker<UpdateEndpointWhiteResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateEndpointWhiteResponse>);
        }
        
        /// <summary>
        /// 批量添加或删除资源标签接口
        ///
        /// 为指定Endpoint Service或Endpoint批量添加或删除标签。
        ///  - 一个资源上最多有10个标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchAddOrRemoveResourceInstanceResponse BatchAddOrRemoveResourceInstance(BatchAddOrRemoveResourceInstanceRequest batchAddOrRemoveResourceInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", batchAddOrRemoveResourceInstanceRequest.ResourceType.ToString());
            urlParam.Add("resource_id", batchAddOrRemoveResourceInstanceRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/{resource_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddOrRemoveResourceInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchAddOrRemoveResourceInstanceResponse>(response);
        }

        public SyncInvoker<BatchAddOrRemoveResourceInstanceResponse> BatchAddOrRemoveResourceInstanceInvoker(BatchAddOrRemoveResourceInstanceRequest batchAddOrRemoveResourceInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", batchAddOrRemoveResourceInstanceRequest.ResourceType.ToString());
            urlParam.Add("resource_id", batchAddOrRemoveResourceInstanceRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/{resource_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddOrRemoveResourceInstanceRequest);
            return new SyncInvoker<BatchAddOrRemoveResourceInstanceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchAddOrRemoveResourceInstanceResponse>);
        }
        
        /// <summary>
        /// 查询租户资源标签接口
        ///
        /// 根据租户ID和资源类型，获取租户下资源的标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListQueryProjectResourceTagsResponse ListQueryProjectResourceTags(ListQueryProjectResourceTagsRequest listQueryProjectResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listQueryProjectResourceTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQueryProjectResourceTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListQueryProjectResourceTagsResponse>(response);
        }

        public SyncInvoker<ListQueryProjectResourceTagsResponse> ListQueryProjectResourceTagsInvoker(ListQueryProjectResourceTagsRequest listQueryProjectResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listQueryProjectResourceTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQueryProjectResourceTagsRequest);
            return new SyncInvoker<ListQueryProjectResourceTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListQueryProjectResourceTagsResponse>);
        }
        
        /// <summary>
        /// 查询资源实例接口
        ///
        /// 使用标签过滤查询租户下资源的实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListResourceInstancesResponse ListResourceInstances(ListResourceInstancesRequest listResourceInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listResourceInstancesRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listResourceInstancesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListResourceInstancesResponse>(response);
        }

        public SyncInvoker<ListResourceInstancesResponse> ListResourceInstancesInvoker(ListResourceInstancesRequest listResourceInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listResourceInstancesRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/resource_instances/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listResourceInstancesRequest);
            return new SyncInvoker<ListResourceInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListResourceInstancesResponse>);
        }
        
    }
}