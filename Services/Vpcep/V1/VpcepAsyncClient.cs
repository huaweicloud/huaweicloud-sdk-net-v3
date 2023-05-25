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
        /// 功能介绍
        /// 接受或者拒绝终端节点连接到当前的终端节点服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AcceptOrRejectEndpointResponse> AcceptOrRejectEndpointAsync(AcceptOrRejectEndpointRequest acceptOrRejectEndpointRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id" , acceptOrRejectEndpointRequest.VpcEndpointServiceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/connections/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", acceptOrRejectEndpointRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AcceptOrRejectEndpointResponse>(response);
        }
        
        /// <summary>
        /// 批量添加或移除终端节点服务的白名单
        ///
        /// 功能介绍
        /// 批量添加或移除当前用户下终端节点服务的白名单。
        /// 说明
        /// 本帐号默认在自身用户的终端节点服务的白名单中。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddOrRemoveServicePermissionsResponse> AddOrRemoveServicePermissionsAsync(AddOrRemoveServicePermissionsRequest addOrRemoveServicePermissionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id" , addOrRemoveServicePermissionsRequest.VpcEndpointServiceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/permissions/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addOrRemoveServicePermissionsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AddOrRemoveServicePermissionsResponse>(response);
        }
        
        /// <summary>
        /// 批量添加终端节点服务的白名单
        ///
        /// 功能介绍
        /// 批量添加当前用户下终端节点服务的白名单，支持添加描述信息。
        /// 说明
        /// 本帐号默认在自身用户的终端节点服务的白名单中。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchAddEndpointServicePermissionsResponse> BatchAddEndpointServicePermissionsAsync(BatchAddEndpointServicePermissionsRequest batchAddEndpointServicePermissionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id" , batchAddEndpointServicePermissionsRequest.VpcEndpointServiceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/permissions/batch-create",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddEndpointServicePermissionsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchAddEndpointServicePermissionsResponse>(response);
        }
        
        /// <summary>
        /// 批量删除终端节点服务的白名单
        ///
        /// 功能介绍
        /// 批量删除当前用户下终端节点服务的白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchRemoveEndpointServicePermissionsResponse> BatchRemoveEndpointServicePermissionsAsync(BatchRemoveEndpointServicePermissionsRequest batchRemoveEndpointServicePermissionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id" , batchRemoveEndpointServicePermissionsRequest.VpcEndpointServiceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/permissions/batch-delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchRemoveEndpointServicePermissionsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchRemoveEndpointServicePermissionsResponse>(response);
        }
        
        /// <summary>
        /// 创建终端节点
        ///
        /// 功能介绍
        /// 创建终端节点，以便访问终端节点服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateEndpointResponse> CreateEndpointAsync(CreateEndpointRequest createEndpointRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createEndpointRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateEndpointResponse>(response);
        }
        
        /// <summary>
        /// 创建终端节点服务
        ///
        /// 功能介绍
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createEndpointServiceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateEndpointServiceResponse>(response);
        }
        
        /// <summary>
        /// 删除终端节点
        ///
        /// 功能介绍
        /// 删除终端节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteEndpointResponse> DeleteEndpointAsync(DeleteEndpointRequest deleteEndpointRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_id" , deleteEndpointRequest.VpcEndpointId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints/{vpc_endpoint_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEndpointRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteEndpointResponse>(response);
        }
        
        /// <summary>
        /// 删除网关型终端节点policy
        ///
        /// 功能介绍
        /// 删除网关型终端节点policy。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteEndpointPolicyResponse> DeleteEndpointPolicyAsync(DeleteEndpointPolicyRequest deleteEndpointPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_id" , deleteEndpointPolicyRequest.VpcEndpointId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints/{vpc_endpoint_id}/policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEndpointPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteEndpointPolicyResponse>(response);
        }
        
        /// <summary>
        /// 删除终端节点服务
        ///
        /// 功能介绍
        /// 删除终端节点服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteEndpointServiceResponse> DeleteEndpointServiceAsync(DeleteEndpointServiceRequest deleteEndpointServiceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id" , deleteEndpointServiceRequest.VpcEndpointServiceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEndpointServiceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteEndpointServiceResponse>(response);
        }
        
        /// <summary>
        /// 查询终端节点详情
        ///
        /// 功能介绍
        /// 查询终端节点的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEndpointInfoDetailsResponse> ListEndpointInfoDetailsAsync(ListEndpointInfoDetailsRequest listEndpointInfoDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_id" , listEndpointInfoDetailsRequest.VpcEndpointId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints/{vpc_endpoint_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointInfoDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListEndpointInfoDetailsResponse>(response);
        }
        
        /// <summary>
        /// 查询终端节点服务列表
        ///
        /// 功能介绍
        /// 查询当前用户下的终端节点服务的列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEndpointServiceResponse> ListEndpointServiceAsync(ListEndpointServiceRequest listEndpointServiceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointServiceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListEndpointServiceResponse>(response);
        }
        
        /// <summary>
        /// 查询终端节点列表
        ///
        /// 功能介绍
        /// 查询当前用户下的终端节点的列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEndpointsResponse> ListEndpointsAsync(ListEndpointsRequest listEndpointsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEndpointsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListEndpointsResponse>(response);
        }
        
        /// <summary>
        /// 查询配额
        ///
        /// 功能介绍
        /// 查询用户的资源配额，包括终端节点服务和终端节点。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListQuotaDetailsResponse> ListQuotaDetailsAsync(ListQuotaDetailsRequest listQuotaDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotaDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListQuotaDetailsResponse>(response);
        }
        
        /// <summary>
        /// 查询连接终端节点服务的连接列表
        ///
        /// 功能介绍
        /// 查询连接当前用户下的某一个终端节点服务的连接列表。marker_id是连接的唯一标识。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListServiceConnectionsResponse> ListServiceConnectionsAsync(ListServiceConnectionsRequest listServiceConnectionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id" , listServiceConnectionsRequest.VpcEndpointServiceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/connections",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceConnectionsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListServiceConnectionsResponse>(response);
        }
        
        /// <summary>
        /// 查询终端节点服务概要
        ///
        /// 功能介绍查询终端节点服务的概要信息， 此接口是供创建终端节点的用户来查询需要连接的终端节点服务信息。 此接口既可以方便其他用户查询到您的终端节点服务概要信息, 又可以避免您的终端节点服务的细节信息暴露给其他用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListServiceDescribeDetailsResponse> ListServiceDescribeDetailsAsync(ListServiceDescribeDetailsRequest listServiceDescribeDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/describe",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceDescribeDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListServiceDescribeDetailsResponse>(response);
        }
        
        /// <summary>
        /// 查询终端节点服务详情
        ///
        /// 功能介绍
        /// 查询终端节点服务的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListServiceDetailsResponse> ListServiceDetailsAsync(ListServiceDetailsRequest listServiceDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id" , listServiceDetailsRequest.VpcEndpointServiceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServiceDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListServiceDetailsResponse>(response);
        }
        
        /// <summary>
        /// 查询终端节点服务的白名单列表
        ///
        /// 功能介绍
        /// 查询当前用户下终端节点服务的白名单列表。
        /// 说明
        /// 本帐号默认在当前用户下终端节点服务的白名单中。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListServicePermissionsDetailsResponse> ListServicePermissionsDetailsAsync(ListServicePermissionsDetailsRequest listServicePermissionsDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id" , listServicePermissionsDetailsRequest.VpcEndpointServiceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/permissions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServicePermissionsDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListServicePermissionsDetailsResponse>(response);
        }
        
        /// <summary>
        /// 查询公共终端节点服务列表
        ///
        /// 功能介绍
        /// 查询公共终端节点服务的列表，公共终端节点服务是所有用户可见且可连接的终端节点服务，
        /// 由运维人员创建，用户可直接使用，但无权创建。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListServicePublicDetailsResponse> ListServicePublicDetailsAsync(ListServicePublicDetailsRequest listServicePublicDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/public",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServicePublicDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListServicePublicDetailsResponse>(response);
        }
        
        /// <summary>
        /// 查询指定VPC终端节点接口版本信息
        ///
        /// 功能介绍
        /// 查询指定VPC终端节点接口版本信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSpecifiedVersionDetailsResponse> ListSpecifiedVersionDetailsAsync(ListSpecifiedVersionDetailsRequest listSpecifiedVersionDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version" , listSpecifiedVersionDetailsRequest.Version.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSpecifiedVersionDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSpecifiedVersionDetailsResponse>(response);
        }
        
        /// <summary>
        /// 查询VPC终端节点接口版本列表
        ///
        /// 功能介绍
        /// 查询VPC终端节点接口版本列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListVersionDetailsResponse> ListVersionDetailsAsync(ListVersionDetailsRequest listVersionDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListVersionDetailsResponse>(response);
        }
        
        /// <summary>
        /// 更新终端节点连接描述
        ///
        /// 功能介绍：
        ///      更新终端节点服务连接的终端节点的描述。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateEndpointConnectionsDescResponse> UpdateEndpointConnectionsDescAsync(UpdateEndpointConnectionsDescRequest updateEndpointConnectionsDescRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id" , updateEndpointConnectionsDescRequest.VpcEndpointServiceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/connections/description",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEndpointConnectionsDescRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateEndpointConnectionsDescResponse>(response);
        }
        
        /// <summary>
        /// 修改网关型终端节点policy
        ///
        /// 功能介绍
        /// 修改网关型终端节点policy。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateEndpointPolicyResponse> UpdateEndpointPolicyAsync(UpdateEndpointPolicyRequest updateEndpointPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_id" , updateEndpointPolicyRequest.VpcEndpointId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints/{vpc_endpoint_id}/policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEndpointPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateEndpointPolicyResponse>(response);
        }
        
        /// <summary>
        /// 修改终端节点的路由表
        ///
        /// 功能介绍
        /// 修改终端节点的路由表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateEndpointRoutetableResponse> UpdateEndpointRoutetableAsync(UpdateEndpointRoutetableRequest updateEndpointRoutetableRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_id" , updateEndpointRoutetableRequest.VpcEndpointId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints/{vpc_endpoint_id}/routetables",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEndpointRoutetableRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateEndpointRoutetableResponse>(response);
        }
        
        /// <summary>
        /// 修改终端节点服务
        ///
        /// 功能介绍
        /// 修改终端节点服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateEndpointServiceResponse> UpdateEndpointServiceAsync(UpdateEndpointServiceRequest updateEndpointServiceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id" , updateEndpointServiceRequest.VpcEndpointServiceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEndpointServiceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateEndpointServiceResponse>(response);
        }
        
        /// <summary>
        /// 修改终端节点服务名称
        ///
        /// 功能介绍
        /// 修改终端节点服务名称
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateEndpointServiceNameResponse> UpdateEndpointServiceNameAsync(UpdateEndpointServiceNameRequest updateEndpointServiceNameRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id" , updateEndpointServiceNameRequest.VpcEndpointServiceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/name",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEndpointServiceNameRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateEndpointServiceNameResponse>(response);
        }
        
        /// <summary>
        /// 更新终端节点服务白名单描述
        ///
        /// 功能介绍
        /// 更新当前用户下终端节点服务白名单的描述信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateEndpointServicePermissionDescResponse> UpdateEndpointServicePermissionDescAsync(UpdateEndpointServicePermissionDescRequest updateEndpointServicePermissionDescRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_service_id" , updateEndpointServicePermissionDescRequest.VpcEndpointServiceId.ToString());
            urlParam.Add("permission_id" , updateEndpointServicePermissionDescRequest.PermissionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoint-services/{vpc_endpoint_service_id}/permissions/{permission_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEndpointServicePermissionDescRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateEndpointServicePermissionDescResponse>(response);
        }
        
        /// <summary>
        /// 更新终端节点
        ///
        /// 功能介绍
        /// 更新或删除允许访问终端节点的白名单。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateEndpointWhiteResponse> UpdateEndpointWhiteAsync(UpdateEndpointWhiteRequest updateEndpointWhiteRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_endpoint_id" , updateEndpointWhiteRequest.VpcEndpointId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpc-endpoints/{vpc_endpoint_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateEndpointWhiteRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateEndpointWhiteResponse>(response);
        }
        
        /// <summary>
        /// 批量添加或删除资源标签接口
        ///
        /// 功能介绍
        /// 为指定Endpoint Service或Endpoint批量添加或删除标签。
        /// ● 一个资源上最多有10个标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchAddOrRemoveResourceInstanceResponse> BatchAddOrRemoveResourceInstanceAsync(BatchAddOrRemoveResourceInstanceRequest batchAddOrRemoveResourceInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , batchAddOrRemoveResourceInstanceRequest.ResourceType.ToString());
            urlParam.Add("resource_id" , batchAddOrRemoveResourceInstanceRequest.ResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/{resource_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddOrRemoveResourceInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchAddOrRemoveResourceInstanceResponse>(response);
        }
        
        /// <summary>
        /// 查询租户资源标签接口
        ///
        /// 功能介绍
        /// 根据租户ID和资源类型，获取租户下资源的标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListQueryProjectResourceTagsResponse> ListQueryProjectResourceTagsAsync(ListQueryProjectResourceTagsRequest listQueryProjectResourceTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , listQueryProjectResourceTagsRequest.ResourceType.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQueryProjectResourceTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListQueryProjectResourceTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询资源实例接口
        ///
        /// 功能介绍
        /// 使用标签过滤查询租户下资源的实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListResourceInstancesResponse> ListResourceInstancesAsync(ListResourceInstancesRequest listResourceInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , listResourceInstancesRequest.ResourceType.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/resource_instances/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listResourceInstancesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListResourceInstancesResponse>(response);
        }
        
    }
}