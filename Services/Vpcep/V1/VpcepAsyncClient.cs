using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Vpcep.V1.Model;

namespace HuaweiCloud.SDK.Vpcep.V1
{
    public partial class VpcepAsyncClient : Client
    {
        public static ClientBuilder<VpcepAsyncClient> NewBuilder()
        {
            return new ClientBuilder<VpcepAsyncClient>();
        }

        
        /// <summary>
        /// 接受或拒绝终端节点的连接
        ///
        /// 接受或者拒绝终端节点连接到当前的终端节点服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AcceptOrRejectEndpointResponse> AcceptOrRejectEndpointAsync(AcceptOrRejectEndpointRequest acceptOrRejectEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", acceptOrRejectEndpointRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/connections/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", acceptOrRejectEndpointRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AcceptOrRejectEndpointResponse>(response);
        }

        public AsyncInvoker<AcceptOrRejectEndpointResponse> AcceptOrRejectEndpointAsyncInvoker(AcceptOrRejectEndpointRequest acceptOrRejectEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", acceptOrRejectEndpointRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/connections/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", acceptOrRejectEndpointRequest);
            return new AsyncInvoker<AcceptOrRejectEndpointResponse>(this, "POST", request, JsonUtils.DeSerialize<AcceptOrRejectEndpointResponse>);
        }
        
        /// <summary>
        /// 批量添加或移除终端节点服务的白名单
        ///
        /// 批量添加或移除当前用户下终端节点服务的白名单。
        /// 说明
        /// 本帐号默认在自身用户的终端节点服务的白名单中。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddOrRemoveServicePermissionsResponse> AddOrRemoveServicePermissionsAsync(AddOrRemoveServicePermissionsRequest addOrRemoveServicePermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", addOrRemoveServicePermissionsRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/permissions/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addOrRemoveServicePermissionsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AddOrRemoveServicePermissionsResponse>(response);
        }

        public AsyncInvoker<AddOrRemoveServicePermissionsResponse> AddOrRemoveServicePermissionsAsyncInvoker(AddOrRemoveServicePermissionsRequest addOrRemoveServicePermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", addOrRemoveServicePermissionsRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/permissions/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addOrRemoveServicePermissionsRequest);
            return new AsyncInvoker<AddOrRemoveServicePermissionsResponse>(this, "POST", request, JsonUtils.DeSerialize<AddOrRemoveServicePermissionsResponse>);
        }
        
        /// <summary>
        /// 批量添加终端节点服务的白名单
        ///
        /// 批量添加当前用户下终端节点服务的白名单，支持添加描述信息。
        /// 说明
        /// 本帐号默认在自身用户的终端节点服务的白名单中。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchAddEndpointServicePermissionsResponse> BatchAddEndpointServicePermissionsAsync(BatchAddEndpointServicePermissionsRequest batchAddEndpointServicePermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", batchAddEndpointServicePermissionsRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/permissions/batch-create",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddEndpointServicePermissionsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchAddEndpointServicePermissionsResponse>(response);
        }

        public AsyncInvoker<BatchAddEndpointServicePermissionsResponse> BatchAddEndpointServicePermissionsAsyncInvoker(BatchAddEndpointServicePermissionsRequest batchAddEndpointServicePermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", batchAddEndpointServicePermissionsRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/permissions/batch-create",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddEndpointServicePermissionsRequest);
            return new AsyncInvoker<BatchAddEndpointServicePermissionsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchAddEndpointServicePermissionsResponse>);
        }
        
        /// <summary>
        /// 批量删除终端节点服务的白名单
        ///
        /// 批量删除当前用户下终端节点服务的白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchRemoveEndpointServicePermissionsResponse> BatchRemoveEndpointServicePermissionsAsync(BatchRemoveEndpointServicePermissionsRequest batchRemoveEndpointServicePermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", batchRemoveEndpointServicePermissionsRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/permissions/batch-delete",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchRemoveEndpointServicePermissionsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchRemoveEndpointServicePermissionsResponse>(response);
        }

        public AsyncInvoker<BatchRemoveEndpointServicePermissionsResponse> BatchRemoveEndpointServicePermissionsAsyncInvoker(BatchRemoveEndpointServicePermissionsRequest batchRemoveEndpointServicePermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", batchRemoveEndpointServicePermissionsRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/permissions/batch-delete",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchRemoveEndpointServicePermissionsRequest);
            return new AsyncInvoker<BatchRemoveEndpointServicePermissionsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchRemoveEndpointServicePermissionsResponse>);
        }
        
        /// <summary>
        /// 创建终端节点
        ///
        /// 创建终端节点，以便访问终端节点服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateEndpointResponse> CreateEndpointAsync(CreateEndpointRequest createEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createEndpointRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateEndpointResponse>(response);
        }

        public AsyncInvoker<CreateEndpointResponse> CreateEndpointAsyncInvoker(CreateEndpointRequest createEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createEndpointRequest);
            return new AsyncInvoker<CreateEndpointResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateEndpointResponse>);
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
        public async Task<CreateEndpointServiceResponse> CreateEndpointServiceAsync(CreateEndpointServiceRequest createEndpointServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createEndpointServiceRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateEndpointServiceResponse>(response);
        }

        public AsyncInvoker<CreateEndpointServiceResponse> CreateEndpointServiceAsyncInvoker(CreateEndpointServiceRequest createEndpointServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createEndpointServiceRequest);
            return new AsyncInvoker<CreateEndpointServiceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateEndpointServiceResponse>);
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
            urlParam.Add("vpc_endpoint_id", deleteEndpointRequest.VpcEndpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints/{vpc_endpoint_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEndpointRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteEndpointResponse>(response);
        }

        public AsyncInvoker<DeleteEndpointResponse> DeleteEndpointAsyncInvoker(DeleteEndpointRequest deleteEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_id", deleteEndpointRequest.VpcEndpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints/{vpc_endpoint_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEndpointRequest);
            return new AsyncInvoker<DeleteEndpointResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteEndpointResponse>);
        }
        
        /// <summary>
        /// 删除网关型终端节点policy
        ///
        /// 删除网关型终端节点policy。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteEndpointPolicyResponse> DeleteEndpointPolicyAsync(DeleteEndpointPolicyRequest deleteEndpointPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_id", deleteEndpointPolicyRequest.VpcEndpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints/{vpc_endpoint_id}/policy",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEndpointPolicyRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteEndpointPolicyResponse>(response);
        }

        public AsyncInvoker<DeleteEndpointPolicyResponse> DeleteEndpointPolicyAsyncInvoker(DeleteEndpointPolicyRequest deleteEndpointPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_id", deleteEndpointPolicyRequest.VpcEndpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints/{vpc_endpoint_id}/policy",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEndpointPolicyRequest);
            return new AsyncInvoker<DeleteEndpointPolicyResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteEndpointPolicyResponse>);
        }
        
        /// <summary>
        /// 删除终端节点服务
        ///
        /// 删除终端节点服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteEndpointServiceResponse> DeleteEndpointServiceAsync(DeleteEndpointServiceRequest deleteEndpointServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", deleteEndpointServiceRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEndpointServiceRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteEndpointServiceResponse>(response);
        }

        public AsyncInvoker<DeleteEndpointServiceResponse> DeleteEndpointServiceAsyncInvoker(DeleteEndpointServiceRequest deleteEndpointServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", deleteEndpointServiceRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEndpointServiceRequest);
            return new AsyncInvoker<DeleteEndpointServiceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteEndpointServiceResponse>);
        }
        
        /// <summary>
        /// 查询终端节点详情
        ///
        /// 查询终端节点的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEndpointInfoDetailsResponse> ListEndpointInfoDetailsAsync(ListEndpointInfoDetailsRequest listEndpointInfoDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_id", listEndpointInfoDetailsRequest.VpcEndpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints/{vpc_endpoint_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointInfoDetailsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListEndpointInfoDetailsResponse>(response);
        }

        public AsyncInvoker<ListEndpointInfoDetailsResponse> ListEndpointInfoDetailsAsyncInvoker(ListEndpointInfoDetailsRequest listEndpointInfoDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_id", listEndpointInfoDetailsRequest.VpcEndpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints/{vpc_endpoint_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointInfoDetailsRequest);
            return new AsyncInvoker<ListEndpointInfoDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEndpointInfoDetailsResponse>);
        }
        
        /// <summary>
        /// 查询终端节点服务列表
        ///
        /// 查询当前用户下的终端节点服务的列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEndpointServiceResponse> ListEndpointServiceAsync(ListEndpointServiceRequest listEndpointServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointServiceRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListEndpointServiceResponse>(response);
        }

        public AsyncInvoker<ListEndpointServiceResponse> ListEndpointServiceAsyncInvoker(ListEndpointServiceRequest listEndpointServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointServiceRequest);
            return new AsyncInvoker<ListEndpointServiceResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEndpointServiceResponse>);
        }
        
        /// <summary>
        /// 查询终端节点列表
        ///
        /// 查询当前用户下的终端节点的列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEndpointsResponse> ListEndpointsAsync(ListEndpointsRequest listEndpointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListEndpointsResponse>(response);
        }

        public AsyncInvoker<ListEndpointsResponse> ListEndpointsAsyncInvoker(ListEndpointsRequest listEndpointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointsRequest);
            return new AsyncInvoker<ListEndpointsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEndpointsResponse>);
        }
        
        /// <summary>
        /// 查询配额
        ///
        /// 查询用户的资源配额，包括终端节点服务和终端节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListQuotaDetailsResponse> ListQuotaDetailsAsync(ListQuotaDetailsRequest listQuotaDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/quotas",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotaDetailsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListQuotaDetailsResponse>(response);
        }

        public AsyncInvoker<ListQuotaDetailsResponse> ListQuotaDetailsAsyncInvoker(ListQuotaDetailsRequest listQuotaDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/quotas",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotaDetailsRequest);
            return new AsyncInvoker<ListQuotaDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListQuotaDetailsResponse>);
        }
        
        /// <summary>
        /// 查询连接终端节点服务的连接列表
        ///
        /// 查询连接当前用户下的某一个终端节点服务的连接列表。marker_id是连接的唯一标识。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListServiceConnectionsResponse> ListServiceConnectionsAsync(ListServiceConnectionsRequest listServiceConnectionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", listServiceConnectionsRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/connections",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceConnectionsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListServiceConnectionsResponse>(response);
        }

        public AsyncInvoker<ListServiceConnectionsResponse> ListServiceConnectionsAsyncInvoker(ListServiceConnectionsRequest listServiceConnectionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", listServiceConnectionsRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/connections",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceConnectionsRequest);
            return new AsyncInvoker<ListServiceConnectionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServiceConnectionsResponse>);
        }
        
        /// <summary>
        /// 查询终端节点服务概要
        ///
        /// 查询终端节点服务的概要信息， 此接口是供创建终端节点的用户来查询需要连接的终端节点服务信息。 此接口既可以方便其他用户查询到您的终端节点服务概要信息, 又可以避免您的终端节点服务的细节信息暴露给其他用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListServiceDescribeDetailsResponse> ListServiceDescribeDetailsAsync(ListServiceDescribeDetailsRequest listServiceDescribeDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/describe",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceDescribeDetailsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListServiceDescribeDetailsResponse>(response);
        }

        public AsyncInvoker<ListServiceDescribeDetailsResponse> ListServiceDescribeDetailsAsyncInvoker(ListServiceDescribeDetailsRequest listServiceDescribeDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/describe",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceDescribeDetailsRequest);
            return new AsyncInvoker<ListServiceDescribeDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServiceDescribeDetailsResponse>);
        }
        
        /// <summary>
        /// 查询终端节点服务详情
        ///
        /// 查询终端节点服务的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListServiceDetailsResponse> ListServiceDetailsAsync(ListServiceDetailsRequest listServiceDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", listServiceDetailsRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceDetailsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListServiceDetailsResponse>(response);
        }

        public AsyncInvoker<ListServiceDetailsResponse> ListServiceDetailsAsyncInvoker(ListServiceDetailsRequest listServiceDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", listServiceDetailsRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceDetailsRequest);
            return new AsyncInvoker<ListServiceDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServiceDetailsResponse>);
        }
        
        /// <summary>
        /// 查询终端节点服务的白名单列表
        ///
        /// 查询当前用户下终端节点服务的白名单列表。
        /// 说明
        /// 本帐号默认在当前用户下终端节点服务的白名单中。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListServicePermissionsDetailsResponse> ListServicePermissionsDetailsAsync(ListServicePermissionsDetailsRequest listServicePermissionsDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", listServicePermissionsDetailsRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/permissions",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServicePermissionsDetailsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListServicePermissionsDetailsResponse>(response);
        }

        public AsyncInvoker<ListServicePermissionsDetailsResponse> ListServicePermissionsDetailsAsyncInvoker(ListServicePermissionsDetailsRequest listServicePermissionsDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", listServicePermissionsDetailsRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/permissions",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServicePermissionsDetailsRequest);
            return new AsyncInvoker<ListServicePermissionsDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServicePermissionsDetailsResponse>);
        }
        
        /// <summary>
        /// 查询公共终端节点服务列表
        ///
        /// 查询公共终端节点服务的列表，公共终端节点服务是所有用户可见且可连接的终端节点服务，
        /// 由运维人员创建，用户可直接使用，但无权创建。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListServicePublicDetailsResponse> ListServicePublicDetailsAsync(ListServicePublicDetailsRequest listServicePublicDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/public",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServicePublicDetailsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListServicePublicDetailsResponse>(response);
        }

        public AsyncInvoker<ListServicePublicDetailsResponse> ListServicePublicDetailsAsyncInvoker(ListServicePublicDetailsRequest listServicePublicDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/public",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServicePublicDetailsRequest);
            return new AsyncInvoker<ListServicePublicDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServicePublicDetailsResponse>);
        }
        
        /// <summary>
        /// 查询指定VPC终端节点接口版本信息
        ///
        /// 查询指定VPC终端节点接口版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSpecifiedVersionDetailsResponse> ListSpecifiedVersionDetailsAsync(ListSpecifiedVersionDetailsRequest listSpecifiedVersionDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("version", listSpecifiedVersionDetailsRequest.Version.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{version}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSpecifiedVersionDetailsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSpecifiedVersionDetailsResponse>(response);
        }

        public AsyncInvoker<ListSpecifiedVersionDetailsResponse> ListSpecifiedVersionDetailsAsyncInvoker(ListSpecifiedVersionDetailsRequest listSpecifiedVersionDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("version", listSpecifiedVersionDetailsRequest.Version.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{version}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSpecifiedVersionDetailsRequest);
            return new AsyncInvoker<ListSpecifiedVersionDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSpecifiedVersionDetailsResponse>);
        }
        
        /// <summary>
        /// 查询VPC终端节点接口版本列表
        ///
        /// 查询VPC终端节点接口版本列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListVersionDetailsResponse> ListVersionDetailsAsync(ListVersionDetailsRequest listVersionDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionDetailsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListVersionDetailsResponse>(response);
        }

        public AsyncInvoker<ListVersionDetailsResponse> ListVersionDetailsAsyncInvoker(ListVersionDetailsRequest listVersionDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionDetailsRequest);
            return new AsyncInvoker<ListVersionDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVersionDetailsResponse>);
        }
        
        /// <summary>
        /// 更新终端节点连接描述
        ///
        /// 更新终端节点服务连接的终端节点的描述。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateEndpointConnectionsDescResponse> UpdateEndpointConnectionsDescAsync(UpdateEndpointConnectionsDescRequest updateEndpointConnectionsDescRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", updateEndpointConnectionsDescRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/connections/description",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEndpointConnectionsDescRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateEndpointConnectionsDescResponse>(response);
        }

        public AsyncInvoker<UpdateEndpointConnectionsDescResponse> UpdateEndpointConnectionsDescAsyncInvoker(UpdateEndpointConnectionsDescRequest updateEndpointConnectionsDescRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", updateEndpointConnectionsDescRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/connections/description",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEndpointConnectionsDescRequest);
            return new AsyncInvoker<UpdateEndpointConnectionsDescResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateEndpointConnectionsDescResponse>);
        }
        
        /// <summary>
        /// 修改网关型终端节点policy
        ///
        /// 修改网关型终端节点policy。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateEndpointPolicyResponse> UpdateEndpointPolicyAsync(UpdateEndpointPolicyRequest updateEndpointPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_id", updateEndpointPolicyRequest.VpcEndpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints/{vpc_endpoint_id}/policy",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEndpointPolicyRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateEndpointPolicyResponse>(response);
        }

        public AsyncInvoker<UpdateEndpointPolicyResponse> UpdateEndpointPolicyAsyncInvoker(UpdateEndpointPolicyRequest updateEndpointPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_id", updateEndpointPolicyRequest.VpcEndpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints/{vpc_endpoint_id}/policy",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEndpointPolicyRequest);
            return new AsyncInvoker<UpdateEndpointPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateEndpointPolicyResponse>);
        }
        
        /// <summary>
        /// 修改终端节点的路由表
        ///
        /// 修改终端节点的路由表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateEndpointRoutetableResponse> UpdateEndpointRoutetableAsync(UpdateEndpointRoutetableRequest updateEndpointRoutetableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_id", updateEndpointRoutetableRequest.VpcEndpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints/{vpc_endpoint_id}/routetables",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEndpointRoutetableRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateEndpointRoutetableResponse>(response);
        }

        public AsyncInvoker<UpdateEndpointRoutetableResponse> UpdateEndpointRoutetableAsyncInvoker(UpdateEndpointRoutetableRequest updateEndpointRoutetableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_id", updateEndpointRoutetableRequest.VpcEndpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints/{vpc_endpoint_id}/routetables",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEndpointRoutetableRequest);
            return new AsyncInvoker<UpdateEndpointRoutetableResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateEndpointRoutetableResponse>);
        }
        
        /// <summary>
        /// 修改终端节点服务
        ///
        /// 修改终端节点服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateEndpointServiceResponse> UpdateEndpointServiceAsync(UpdateEndpointServiceRequest updateEndpointServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", updateEndpointServiceRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEndpointServiceRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateEndpointServiceResponse>(response);
        }

        public AsyncInvoker<UpdateEndpointServiceResponse> UpdateEndpointServiceAsyncInvoker(UpdateEndpointServiceRequest updateEndpointServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", updateEndpointServiceRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEndpointServiceRequest);
            return new AsyncInvoker<UpdateEndpointServiceResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateEndpointServiceResponse>);
        }
        
        /// <summary>
        /// 修改终端节点服务名称
        ///
        /// 修改终端节点服务名称
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateEndpointServiceNameResponse> UpdateEndpointServiceNameAsync(UpdateEndpointServiceNameRequest updateEndpointServiceNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", updateEndpointServiceNameRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/name",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEndpointServiceNameRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateEndpointServiceNameResponse>(response);
        }

        public AsyncInvoker<UpdateEndpointServiceNameResponse> UpdateEndpointServiceNameAsyncInvoker(UpdateEndpointServiceNameRequest updateEndpointServiceNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", updateEndpointServiceNameRequest.VpcEndpointServiceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/name",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEndpointServiceNameRequest);
            return new AsyncInvoker<UpdateEndpointServiceNameResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateEndpointServiceNameResponse>);
        }
        
        /// <summary>
        /// 更新终端节点服务白名单描述
        ///
        /// 更新当前用户下终端节点服务白名单的描述信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateEndpointServicePermissionDescResponse> UpdateEndpointServicePermissionDescAsync(UpdateEndpointServicePermissionDescRequest updateEndpointServicePermissionDescRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", updateEndpointServicePermissionDescRequest.VpcEndpointServiceId.ToString());
            urlParam.Add("permission_id", updateEndpointServicePermissionDescRequest.PermissionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/permissions/{permission_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEndpointServicePermissionDescRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateEndpointServicePermissionDescResponse>(response);
        }

        public AsyncInvoker<UpdateEndpointServicePermissionDescResponse> UpdateEndpointServicePermissionDescAsyncInvoker(UpdateEndpointServicePermissionDescRequest updateEndpointServicePermissionDescRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id", updateEndpointServicePermissionDescRequest.VpcEndpointServiceId.ToString());
            urlParam.Add("permission_id", updateEndpointServicePermissionDescRequest.PermissionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/permissions/{permission_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEndpointServicePermissionDescRequest);
            return new AsyncInvoker<UpdateEndpointServicePermissionDescResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateEndpointServicePermissionDescResponse>);
        }
        
        /// <summary>
        /// 更新终端节点
        ///
        /// 更新或删除允许访问终端节点的白名单。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateEndpointWhiteResponse> UpdateEndpointWhiteAsync(UpdateEndpointWhiteRequest updateEndpointWhiteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_id", updateEndpointWhiteRequest.VpcEndpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints/{vpc_endpoint_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEndpointWhiteRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateEndpointWhiteResponse>(response);
        }

        public AsyncInvoker<UpdateEndpointWhiteResponse> UpdateEndpointWhiteAsyncInvoker(UpdateEndpointWhiteRequest updateEndpointWhiteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_id", updateEndpointWhiteRequest.VpcEndpointId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints/{vpc_endpoint_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEndpointWhiteRequest);
            return new AsyncInvoker<UpdateEndpointWhiteResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateEndpointWhiteResponse>);
        }
        
        /// <summary>
        /// 批量添加或删除资源标签接口
        ///
        /// 为指定Endpoint Service或Endpoint批量添加或删除标签。
        /// ● 一个资源上最多有10个标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchAddOrRemoveResourceInstanceResponse> BatchAddOrRemoveResourceInstanceAsync(BatchAddOrRemoveResourceInstanceRequest batchAddOrRemoveResourceInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", batchAddOrRemoveResourceInstanceRequest.ResourceType.ToString());
            urlParam.Add("resource_id", batchAddOrRemoveResourceInstanceRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/{resource_id}/tags/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddOrRemoveResourceInstanceRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchAddOrRemoveResourceInstanceResponse>(response);
        }

        public AsyncInvoker<BatchAddOrRemoveResourceInstanceResponse> BatchAddOrRemoveResourceInstanceAsyncInvoker(BatchAddOrRemoveResourceInstanceRequest batchAddOrRemoveResourceInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", batchAddOrRemoveResourceInstanceRequest.ResourceType.ToString());
            urlParam.Add("resource_id", batchAddOrRemoveResourceInstanceRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/{resource_id}/tags/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddOrRemoveResourceInstanceRequest);
            return new AsyncInvoker<BatchAddOrRemoveResourceInstanceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchAddOrRemoveResourceInstanceResponse>);
        }
        
        /// <summary>
        /// 查询租户资源标签接口
        ///
        /// 根据租户ID和资源类型，获取租户下资源的标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListQueryProjectResourceTagsResponse> ListQueryProjectResourceTagsAsync(ListQueryProjectResourceTagsRequest listQueryProjectResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listQueryProjectResourceTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQueryProjectResourceTagsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListQueryProjectResourceTagsResponse>(response);
        }

        public AsyncInvoker<ListQueryProjectResourceTagsResponse> ListQueryProjectResourceTagsAsyncInvoker(ListQueryProjectResourceTagsRequest listQueryProjectResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listQueryProjectResourceTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQueryProjectResourceTagsRequest);
            return new AsyncInvoker<ListQueryProjectResourceTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListQueryProjectResourceTagsResponse>);
        }
        
        /// <summary>
        /// 查询资源实例接口
        ///
        /// 使用标签过滤查询租户下资源的实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListResourceInstancesResponse> ListResourceInstancesAsync(ListResourceInstancesRequest listResourceInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listResourceInstancesRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/resource_instances/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listResourceInstancesRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListResourceInstancesResponse>(response);
        }

        public AsyncInvoker<ListResourceInstancesResponse> ListResourceInstancesAsyncInvoker(ListResourceInstancesRequest listResourceInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listResourceInstancesRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/resource_instances/action",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listResourceInstancesRequest);
            return new AsyncInvoker<ListResourceInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListResourceInstancesResponse>);
        }
        
    }
}