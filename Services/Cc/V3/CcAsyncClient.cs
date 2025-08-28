using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Cc.V3.Model;

namespace HuaweiCloud.SDK.Cc.V3
{
    public partial class CcAsyncClient : Client
    {
        public static ClientBuilder<CcAsyncClient> NewBuilder()
        {
            return new ClientBuilder<CcAsyncClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 创建授权
        ///
        /// 网络实例所属租户授予云连接实例所属租户加载其网络实例的权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAuthorisationResponse> CreateAuthorisationAsync(CreateAuthorisationRequest createAuthorisationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/authorisations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAuthorisationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAuthorisationResponse>(response);
        }

        public AsyncInvoker<CreateAuthorisationResponse> CreateAuthorisationAsyncInvoker(CreateAuthorisationRequest createAuthorisationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/authorisations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAuthorisationRequest);
            return new AsyncInvoker<CreateAuthorisationResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAuthorisationResponse>);
        }
        
        /// <summary>
        /// 删除授权
        ///
        /// 网络实例所属租户取消授予云连接实例所属租户加载其网络实例的权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAuthorisationResponse> DeleteAuthorisationAsync(DeleteAuthorisationRequest deleteAuthorisationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteAuthorisationRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/authorisations/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuthorisationRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAuthorisationResponse>(response);
        }

        public AsyncInvoker<DeleteAuthorisationResponse> DeleteAuthorisationAsyncInvoker(DeleteAuthorisationRequest deleteAuthorisationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteAuthorisationRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/authorisations/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuthorisationRequest);
            return new AsyncInvoker<DeleteAuthorisationResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAuthorisationResponse>);
        }
        
        /// <summary>
        /// 查询授权列表
        ///
        /// 网络实例所属租户查看其已经授予其他租户的权限。
        /// 分页查询使用的参数为marker、limit。marker和limit一起使用时才会生效，单独使用无效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuthorisationsResponse> ListAuthorisationsAsync(ListAuthorisationsRequest listAuthorisationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/authorisations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuthorisationsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAuthorisationsResponse>(response);
        }

        public AsyncInvoker<ListAuthorisationsResponse> ListAuthorisationsAsyncInvoker(ListAuthorisationsRequest listAuthorisationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/authorisations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuthorisationsRequest);
            return new AsyncInvoker<ListAuthorisationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuthorisationsResponse>);
        }
        
        /// <summary>
        /// 查询权限列表
        ///
        /// 云连接实例所属租户查询其可加载其他租户的网络实例权限。
        /// 分页查询使用的参数为marker、limit。marker和limit一起使用时才会生效，单独使用无效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPermissionsResponse> ListPermissionsAsync(ListPermissionsRequest listPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermissionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPermissionsResponse>(response);
        }

        public AsyncInvoker<ListPermissionsResponse> ListPermissionsAsyncInvoker(ListPermissionsRequest listPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermissionsRequest);
            return new AsyncInvoker<ListPermissionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPermissionsResponse>);
        }
        
        /// <summary>
        /// 更新授权
        ///
        /// 更新授权实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAuthorisationResponse> UpdateAuthorisationAsync(UpdateAuthorisationRequest updateAuthorisationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateAuthorisationRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/authorisations/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAuthorisationRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAuthorisationResponse>(response);
        }

        public AsyncInvoker<UpdateAuthorisationResponse> UpdateAuthorisationAsyncInvoker(UpdateAuthorisationRequest updateAuthorisationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateAuthorisationRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/authorisations/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAuthorisationRequest);
            return new AsyncInvoker<UpdateAuthorisationResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAuthorisationResponse>);
        }
        
        /// <summary>
        /// 将带宽包实例绑定到云连接实例
        ///
        /// 将带宽包实例绑定到云连接实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociateBandwidthPackageResponse> AssociateBandwidthPackageAsync(AssociateBandwidthPackageRequest associateBandwidthPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", associateBandwidthPackageRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/{id}/associate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateBandwidthPackageRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AssociateBandwidthPackageResponse>(response);
        }

        public AsyncInvoker<AssociateBandwidthPackageResponse> AssociateBandwidthPackageAsyncInvoker(AssociateBandwidthPackageRequest associateBandwidthPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", associateBandwidthPackageRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/{id}/associate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateBandwidthPackageRequest);
            return new AsyncInvoker<AssociateBandwidthPackageResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateBandwidthPackageResponse>);
        }
        
        /// <summary>
        /// 创建带宽包实例
        ///
        /// 创建带宽包实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateBandwidthPackageResponse> CreateBandwidthPackageAsync(CreateBandwidthPackageRequest createBandwidthPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBandwidthPackageRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateBandwidthPackageResponse>(response);
        }

        public AsyncInvoker<CreateBandwidthPackageResponse> CreateBandwidthPackageAsyncInvoker(CreateBandwidthPackageRequest createBandwidthPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBandwidthPackageRequest);
            return new AsyncInvoker<CreateBandwidthPackageResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateBandwidthPackageResponse>);
        }
        
        /// <summary>
        /// 删除带宽包实例
        ///
        /// 删除带宽包实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteBandwidthPackageResponse> DeleteBandwidthPackageAsync(DeleteBandwidthPackageRequest deleteBandwidthPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteBandwidthPackageRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBandwidthPackageRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteBandwidthPackageResponse>(response);
        }

        public AsyncInvoker<DeleteBandwidthPackageResponse> DeleteBandwidthPackageAsyncInvoker(DeleteBandwidthPackageRequest deleteBandwidthPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteBandwidthPackageRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBandwidthPackageRequest);
            return new AsyncInvoker<DeleteBandwidthPackageResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteBandwidthPackageResponse>);
        }
        
        /// <summary>
        /// 解除带宽包实例与云连接实例的绑定
        ///
        /// 解除带宽包实例与云连接实例的绑定。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisassociateBandwidthPackageResponse> DisassociateBandwidthPackageAsync(DisassociateBandwidthPackageRequest disassociateBandwidthPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", disassociateBandwidthPackageRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/{id}/disassociate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateBandwidthPackageRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DisassociateBandwidthPackageResponse>(response);
        }

        public AsyncInvoker<DisassociateBandwidthPackageResponse> DisassociateBandwidthPackageAsyncInvoker(DisassociateBandwidthPackageRequest disassociateBandwidthPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", disassociateBandwidthPackageRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/{id}/disassociate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateBandwidthPackageRequest);
            return new AsyncInvoker<DisassociateBandwidthPackageResponse>(this, "POST", request, JsonUtils.DeSerialize<DisassociateBandwidthPackageResponse>);
        }
        
        /// <summary>
        /// 查询带宽包的标签信息
        ///
        /// 查询带宽包的标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBandwidthPackageTagsResponse> ListBandwidthPackageTagsAsync(ListBandwidthPackageTagsRequest listBandwidthPackageTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthPackageTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListBandwidthPackageTagsResponse>(response);
        }

        public AsyncInvoker<ListBandwidthPackageTagsResponse> ListBandwidthPackageTagsAsyncInvoker(ListBandwidthPackageTagsRequest listBandwidthPackageTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthPackageTagsRequest);
            return new AsyncInvoker<ListBandwidthPackageTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBandwidthPackageTagsResponse>);
        }
        
        /// <summary>
        /// 查询带宽包列表
        ///
        /// 查询带宽包列表。
        /// 分页查询使用的参数为marker、limit。marker和limit一起使用时才会生效，单独使用无效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBandwidthPackagesResponse> ListBandwidthPackagesAsync(ListBandwidthPackagesRequest listBandwidthPackagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthPackagesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListBandwidthPackagesResponse>(response);
        }

        public AsyncInvoker<ListBandwidthPackagesResponse> ListBandwidthPackagesAsyncInvoker(ListBandwidthPackagesRequest listBandwidthPackagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthPackagesRequest);
            return new AsyncInvoker<ListBandwidthPackagesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBandwidthPackagesResponse>);
        }
        
        /// <summary>
        /// 通过标签过滤带宽包实例
        ///
        /// 通过标签过滤带宽包实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBandwidthPackagesByTagsResponse> ListBandwidthPackagesByTagsAsync(ListBandwidthPackagesByTagsRequest listBandwidthPackagesByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthPackagesByTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListBandwidthPackagesByTagsResponse>(response);
        }

        public AsyncInvoker<ListBandwidthPackagesByTagsResponse> ListBandwidthPackagesByTagsAsyncInvoker(ListBandwidthPackagesByTagsRequest listBandwidthPackagesByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthPackagesByTagsRequest);
            return new AsyncInvoker<ListBandwidthPackagesByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListBandwidthPackagesByTagsResponse>);
        }
        
        /// <summary>
        /// 查询带宽包实例
        ///
        /// 查询带宽包实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBandwidthPackageResponse> ShowBandwidthPackageAsync(ShowBandwidthPackageRequest showBandwidthPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showBandwidthPackageRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBandwidthPackageRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowBandwidthPackageResponse>(response);
        }

        public AsyncInvoker<ShowBandwidthPackageResponse> ShowBandwidthPackageAsyncInvoker(ShowBandwidthPackageRequest showBandwidthPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showBandwidthPackageRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBandwidthPackageRequest);
            return new AsyncInvoker<ShowBandwidthPackageResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBandwidthPackageResponse>);
        }
        
        /// <summary>
        /// 创建带宽包标签
        ///
        /// 创建带宽包标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<TagBandwidthPackageResponse> TagBandwidthPackageAsync(TagBandwidthPackageRequest tagBandwidthPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", tagBandwidthPackageRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/{id}/tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", tagBandwidthPackageRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<TagBandwidthPackageResponse>(response);
        }

        public AsyncInvoker<TagBandwidthPackageResponse> TagBandwidthPackageAsyncInvoker(TagBandwidthPackageRequest tagBandwidthPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", tagBandwidthPackageRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/{id}/tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", tagBandwidthPackageRequest);
            return new AsyncInvoker<TagBandwidthPackageResponse>(this, "POST", request, JsonUtils.DeSerializeNull<TagBandwidthPackageResponse>);
        }
        
        /// <summary>
        /// 删除带宽包标签
        ///
        /// 删除带宽包标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UntagBandwidthPackageResponse> UntagBandwidthPackageAsync(UntagBandwidthPackageRequest untagBandwidthPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", untagBandwidthPackageRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/{id}/untag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", untagBandwidthPackageRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UntagBandwidthPackageResponse>(response);
        }

        public AsyncInvoker<UntagBandwidthPackageResponse> UntagBandwidthPackageAsyncInvoker(UntagBandwidthPackageRequest untagBandwidthPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", untagBandwidthPackageRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/{id}/untag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", untagBandwidthPackageRequest);
            return new AsyncInvoker<UntagBandwidthPackageResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UntagBandwidthPackageResponse>);
        }
        
        /// <summary>
        /// 更新带宽包实例
        ///
        /// 更新带宽包实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateBandwidthPackageResponse> UpdateBandwidthPackageAsync(UpdateBandwidthPackageRequest updateBandwidthPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateBandwidthPackageRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBandwidthPackageRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateBandwidthPackageResponse>(response);
        }

        public AsyncInvoker<UpdateBandwidthPackageResponse> UpdateBandwidthPackageAsyncInvoker(UpdateBandwidthPackageRequest updateBandwidthPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateBandwidthPackageRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBandwidthPackageRequest);
            return new AsyncInvoker<UpdateBandwidthPackageResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateBandwidthPackageResponse>);
        }
        
        /// <summary>
        /// 应用中心网络策略
        ///
        /// 应用中心网络策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ApplyCentralNetworkPolicyResponse> ApplyCentralNetworkPolicyAsync(ApplyCentralNetworkPolicyRequest applyCentralNetworkPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", applyCentralNetworkPolicyRequest.PolicyId.ToString());
            urlParam.Add("central_network_id", applyCentralNetworkPolicyRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/policies/{policy_id}/apply", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyCentralNetworkPolicyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ApplyCentralNetworkPolicyResponse>(response);
        }

        public AsyncInvoker<ApplyCentralNetworkPolicyResponse> ApplyCentralNetworkPolicyAsyncInvoker(ApplyCentralNetworkPolicyRequest applyCentralNetworkPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", applyCentralNetworkPolicyRequest.PolicyId.ToString());
            urlParam.Add("central_network_id", applyCentralNetworkPolicyRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/policies/{policy_id}/apply", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyCentralNetworkPolicyRequest);
            return new AsyncInvoker<ApplyCentralNetworkPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<ApplyCentralNetworkPolicyResponse>);
        }
        
        /// <summary>
        /// 创建中心网络
        ///
        /// 创建中心网络。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateCentralNetworkResponse> CreateCentralNetworkAsync(CreateCentralNetworkRequest createCentralNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCentralNetworkRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateCentralNetworkResponse>(response);
        }

        public AsyncInvoker<CreateCentralNetworkResponse> CreateCentralNetworkAsyncInvoker(CreateCentralNetworkRequest createCentralNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCentralNetworkRequest);
            return new AsyncInvoker<CreateCentralNetworkResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCentralNetworkResponse>);
        }
        
        /// <summary>
        /// 创建一个新版本的中心网络策略
        ///
        /// 创建一份只读的中心网络的策略。如果您有策略文档内容改动，需要基于此版本重新创建一个新版本的策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateCentralNetworkPolicyResponse> CreateCentralNetworkPolicyAsync(CreateCentralNetworkPolicyRequest createCentralNetworkPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", createCentralNetworkPolicyRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCentralNetworkPolicyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateCentralNetworkPolicyResponse>(response);
        }

        public AsyncInvoker<CreateCentralNetworkPolicyResponse> CreateCentralNetworkPolicyAsyncInvoker(CreateCentralNetworkPolicyRequest createCentralNetworkPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", createCentralNetworkPolicyRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCentralNetworkPolicyRequest);
            return new AsyncInvoker<CreateCentralNetworkPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCentralNetworkPolicyResponse>);
        }
        
        /// <summary>
        /// 删除中心网络
        ///
        /// 删除中心网络，请先清除附件后再删除中心网络。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteCentralNetworkResponse> DeleteCentralNetworkAsync(DeleteCentralNetworkRequest deleteCentralNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", deleteCentralNetworkRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-networks/{central_network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCentralNetworkRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteCentralNetworkResponse>(response);
        }

        public AsyncInvoker<DeleteCentralNetworkResponse> DeleteCentralNetworkAsyncInvoker(DeleteCentralNetworkRequest deleteCentralNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", deleteCentralNetworkRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-networks/{central_network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCentralNetworkRequest);
            return new AsyncInvoker<DeleteCentralNetworkResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteCentralNetworkResponse>);
        }
        
        /// <summary>
        /// 删除中心网络策略版本
        ///
        /// 删除中心网络策略版本。您无法删除正在被应用的中心策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteCentralNetworkPolicyResponse> DeleteCentralNetworkPolicyAsync(DeleteCentralNetworkPolicyRequest deleteCentralNetworkPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", deleteCentralNetworkPolicyRequest.PolicyId.ToString());
            urlParam.Add("central_network_id", deleteCentralNetworkPolicyRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCentralNetworkPolicyRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteCentralNetworkPolicyResponse>(response);
        }

        public AsyncInvoker<DeleteCentralNetworkPolicyResponse> DeleteCentralNetworkPolicyAsyncInvoker(DeleteCentralNetworkPolicyRequest deleteCentralNetworkPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", deleteCentralNetworkPolicyRequest.PolicyId.ToString());
            urlParam.Add("central_network_id", deleteCentralNetworkPolicyRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCentralNetworkPolicyRequest);
            return new AsyncInvoker<DeleteCentralNetworkPolicyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteCentralNetworkPolicyResponse>);
        }
        
        /// <summary>
        /// 查询所有版本的中心网络策略列表
        ///
        /// 查询所有版本的中心网络策略列表。
        /// 分页查询使用的参数为marker、limit。limit默认值为0，没有指定marker时返回第一条数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCentralNetworkPoliciesResponse> ListCentralNetworkPoliciesAsync(ListCentralNetworkPoliciesRequest listCentralNetworkPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", listCentralNetworkPoliciesRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworkPoliciesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCentralNetworkPoliciesResponse>(response);
        }

        public AsyncInvoker<ListCentralNetworkPoliciesResponse> ListCentralNetworkPoliciesAsyncInvoker(ListCentralNetworkPoliciesRequest listCentralNetworkPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", listCentralNetworkPoliciesRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworkPoliciesRequest);
            return new AsyncInvoker<ListCentralNetworkPoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCentralNetworkPoliciesResponse>);
        }
        
        /// <summary>
        /// 查询中心网络策略变化集
        ///
        /// 查询与当前应用中心网络策略的变化集。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCentralNetworkPolicyChangeSetResponse> ListCentralNetworkPolicyChangeSetAsync(ListCentralNetworkPolicyChangeSetRequest listCentralNetworkPolicyChangeSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", listCentralNetworkPolicyChangeSetRequest.PolicyId.ToString());
            urlParam.Add("central_network_id", listCentralNetworkPolicyChangeSetRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/policies/{policy_id}/change-set", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworkPolicyChangeSetRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCentralNetworkPolicyChangeSetResponse>(response);
        }

        public AsyncInvoker<ListCentralNetworkPolicyChangeSetResponse> ListCentralNetworkPolicyChangeSetAsyncInvoker(ListCentralNetworkPolicyChangeSetRequest listCentralNetworkPolicyChangeSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", listCentralNetworkPolicyChangeSetRequest.PolicyId.ToString());
            urlParam.Add("central_network_id", listCentralNetworkPolicyChangeSetRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/policies/{policy_id}/change-set", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworkPolicyChangeSetRequest);
            return new AsyncInvoker<ListCentralNetworkPolicyChangeSetResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCentralNetworkPolicyChangeSetResponse>);
        }
        
        /// <summary>
        /// 查询中心网络的标签信息
        ///
        /// 查询中心网络的标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCentralNetworkTagsResponse> ListCentralNetworkTagsAsync(ListCentralNetworkTagsRequest listCentralNetworkTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-networks/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworkTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCentralNetworkTagsResponse>(response);
        }

        public AsyncInvoker<ListCentralNetworkTagsResponse> ListCentralNetworkTagsAsyncInvoker(ListCentralNetworkTagsRequest listCentralNetworkTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-networks/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworkTagsRequest);
            return new AsyncInvoker<ListCentralNetworkTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCentralNetworkTagsResponse>);
        }
        
        /// <summary>
        /// 查询中心网络列表
        ///
        /// 查询中心网络列表。
        /// 分页查询使用的参数为marker、limit。limit默认值为0，没有指定marker时返回第一条数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCentralNetworksResponse> ListCentralNetworksAsync(ListCentralNetworksRequest listCentralNetworksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCentralNetworksResponse>(response);
        }

        public AsyncInvoker<ListCentralNetworksResponse> ListCentralNetworksAsyncInvoker(ListCentralNetworksRequest listCentralNetworksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworksRequest);
            return new AsyncInvoker<ListCentralNetworksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCentralNetworksResponse>);
        }
        
        /// <summary>
        /// 通过标签过滤中心网络实例
        ///
        /// 通过标签过滤中心网络实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCentralNetworksByTagsResponse> ListCentralNetworksByTagsAsync(ListCentralNetworksByTagsRequest listCentralNetworksByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-networks/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworksByTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListCentralNetworksByTagsResponse>(response);
        }

        public AsyncInvoker<ListCentralNetworksByTagsResponse> ListCentralNetworksByTagsAsyncInvoker(ListCentralNetworksByTagsRequest listCentralNetworksByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-networks/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworksByTagsRequest);
            return new AsyncInvoker<ListCentralNetworksByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListCentralNetworksByTagsResponse>);
        }
        
        /// <summary>
        /// 查询中心网络详情
        ///
        /// 查询中心网络详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCentralNetworkResponse> ShowCentralNetworkAsync(ShowCentralNetworkRequest showCentralNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", showCentralNetworkRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-networks/{central_network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCentralNetworkRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowCentralNetworkResponse>(response);
        }

        public AsyncInvoker<ShowCentralNetworkResponse> ShowCentralNetworkAsyncInvoker(ShowCentralNetworkRequest showCentralNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", showCentralNetworkRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-networks/{central_network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCentralNetworkRequest);
            return new AsyncInvoker<ShowCentralNetworkResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCentralNetworkResponse>);
        }
        
        /// <summary>
        /// 创建中心网络标签
        ///
        /// 创建中心网络标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<TagCentralNetworkResponse> TagCentralNetworkAsync(TagCentralNetworkRequest tagCentralNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", tagCentralNetworkRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-networks/{central_network_id}/tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", tagCentralNetworkRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<TagCentralNetworkResponse>(response);
        }

        public AsyncInvoker<TagCentralNetworkResponse> TagCentralNetworkAsyncInvoker(TagCentralNetworkRequest tagCentralNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", tagCentralNetworkRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-networks/{central_network_id}/tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", tagCentralNetworkRequest);
            return new AsyncInvoker<TagCentralNetworkResponse>(this, "POST", request, JsonUtils.DeSerializeNull<TagCentralNetworkResponse>);
        }
        
        /// <summary>
        /// 删除中心网络标签
        ///
        /// 删除中心网络标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UntagCentralNetworkResponse> UntagCentralNetworkAsync(UntagCentralNetworkRequest untagCentralNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", untagCentralNetworkRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-networks/{central_network_id}/untag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", untagCentralNetworkRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UntagCentralNetworkResponse>(response);
        }

        public AsyncInvoker<UntagCentralNetworkResponse> UntagCentralNetworkAsyncInvoker(UntagCentralNetworkRequest untagCentralNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", untagCentralNetworkRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-networks/{central_network_id}/untag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", untagCentralNetworkRequest);
            return new AsyncInvoker<UntagCentralNetworkResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UntagCentralNetworkResponse>);
        }
        
        /// <summary>
        /// 更新中心网络详情
        ///
        /// 更新中心网络详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateCentralNetworkResponse> UpdateCentralNetworkAsync(UpdateCentralNetworkRequest updateCentralNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", updateCentralNetworkRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-networks/{central_network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCentralNetworkRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateCentralNetworkResponse>(response);
        }

        public AsyncInvoker<UpdateCentralNetworkResponse> UpdateCentralNetworkAsyncInvoker(UpdateCentralNetworkRequest updateCentralNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", updateCentralNetworkRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-networks/{central_network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCentralNetworkRequest);
            return new AsyncInvoker<UpdateCentralNetworkResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateCentralNetworkResponse>);
        }
        
        /// <summary>
        /// 创建中心网络ER路由表附件
        ///
        /// 创建中心网络的路由表附件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateCentralNetworkErRouteTableAttachmentResponse> CreateCentralNetworkErRouteTableAttachmentAsync(CreateCentralNetworkErRouteTableAttachmentRequest createCentralNetworkErRouteTableAttachmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", createCentralNetworkErRouteTableAttachmentRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/er-route-table-attachments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCentralNetworkErRouteTableAttachmentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateCentralNetworkErRouteTableAttachmentResponse>(response);
        }

        public AsyncInvoker<CreateCentralNetworkErRouteTableAttachmentResponse> CreateCentralNetworkErRouteTableAttachmentAsyncInvoker(CreateCentralNetworkErRouteTableAttachmentRequest createCentralNetworkErRouteTableAttachmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", createCentralNetworkErRouteTableAttachmentRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/er-route-table-attachments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCentralNetworkErRouteTableAttachmentRequest);
            return new AsyncInvoker<CreateCentralNetworkErRouteTableAttachmentResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCentralNetworkErRouteTableAttachmentResponse>);
        }
        
        /// <summary>
        /// 创建中心网络GDGW附件
        ///
        /// 创建中心网络的GDGW附件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateCentralNetworkGdgwAttachmentResponse> CreateCentralNetworkGdgwAttachmentAsync(CreateCentralNetworkGdgwAttachmentRequest createCentralNetworkGdgwAttachmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", createCentralNetworkGdgwAttachmentRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/gdgw-attachments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCentralNetworkGdgwAttachmentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateCentralNetworkGdgwAttachmentResponse>(response);
        }

        public AsyncInvoker<CreateCentralNetworkGdgwAttachmentResponse> CreateCentralNetworkGdgwAttachmentAsyncInvoker(CreateCentralNetworkGdgwAttachmentRequest createCentralNetworkGdgwAttachmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", createCentralNetworkGdgwAttachmentRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/gdgw-attachments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCentralNetworkGdgwAttachmentRequest);
            return new AsyncInvoker<CreateCentralNetworkGdgwAttachmentResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCentralNetworkGdgwAttachmentResponse>);
        }
        
        /// <summary>
        /// 删除中心网络附件
        ///
        /// 删除中心网络附件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteCentralNetworkAttachmentResponse> DeleteCentralNetworkAttachmentAsync(DeleteCentralNetworkAttachmentRequest deleteCentralNetworkAttachmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", deleteCentralNetworkAttachmentRequest.CentralNetworkId.ToString());
            urlParam.Add("attachment_id", deleteCentralNetworkAttachmentRequest.AttachmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/attachments/{attachment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCentralNetworkAttachmentRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteCentralNetworkAttachmentResponse>(response);
        }

        public AsyncInvoker<DeleteCentralNetworkAttachmentResponse> DeleteCentralNetworkAttachmentAsyncInvoker(DeleteCentralNetworkAttachmentRequest deleteCentralNetworkAttachmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", deleteCentralNetworkAttachmentRequest.CentralNetworkId.ToString());
            urlParam.Add("attachment_id", deleteCentralNetworkAttachmentRequest.AttachmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/attachments/{attachment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCentralNetworkAttachmentRequest);
            return new AsyncInvoker<DeleteCentralNetworkAttachmentResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteCentralNetworkAttachmentResponse>);
        }
        
        /// <summary>
        /// 查询中心网络附件列表
        ///
        /// 查询中心网络附件列表，分页查询使用的参数为marker、limit。limit默认值为0，没有指定marker时返回第一条数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCentralNetworkAttachmentsResponse> ListCentralNetworkAttachmentsAsync(ListCentralNetworkAttachmentsRequest listCentralNetworkAttachmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", listCentralNetworkAttachmentsRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/attachments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworkAttachmentsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCentralNetworkAttachmentsResponse>(response);
        }

        public AsyncInvoker<ListCentralNetworkAttachmentsResponse> ListCentralNetworkAttachmentsAsyncInvoker(ListCentralNetworkAttachmentsRequest listCentralNetworkAttachmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", listCentralNetworkAttachmentsRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/attachments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworkAttachmentsRequest);
            return new AsyncInvoker<ListCentralNetworkAttachmentsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCentralNetworkAttachmentsResponse>);
        }
        
        /// <summary>
        /// 查询中心网络ER路由表附件列表
        ///
        /// 查询中心网络ER路由表附件列表。
        /// 分页查询使用的参数为marker、limit。limit默认值为0，没有指定marker时返回第一条数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCentralNetworkErRouteTableAttachmentsResponse> ListCentralNetworkErRouteTableAttachmentsAsync(ListCentralNetworkErRouteTableAttachmentsRequest listCentralNetworkErRouteTableAttachmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", listCentralNetworkErRouteTableAttachmentsRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/er-route-table-attachments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworkErRouteTableAttachmentsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCentralNetworkErRouteTableAttachmentsResponse>(response);
        }

        public AsyncInvoker<ListCentralNetworkErRouteTableAttachmentsResponse> ListCentralNetworkErRouteTableAttachmentsAsyncInvoker(ListCentralNetworkErRouteTableAttachmentsRequest listCentralNetworkErRouteTableAttachmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", listCentralNetworkErRouteTableAttachmentsRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/er-route-table-attachments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworkErRouteTableAttachmentsRequest);
            return new AsyncInvoker<ListCentralNetworkErRouteTableAttachmentsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCentralNetworkErRouteTableAttachmentsResponse>);
        }
        
        /// <summary>
        /// 查询中心网络GDGW附件列表
        ///
        /// 查询中心网络GDGW附件列表。
        /// 分页查询使用的参数为marker、limit。limit默认值为0，没有指定marker时返回第一条数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCentralNetworkGdgwAttachmentsResponse> ListCentralNetworkGdgwAttachmentsAsync(ListCentralNetworkGdgwAttachmentsRequest listCentralNetworkGdgwAttachmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", listCentralNetworkGdgwAttachmentsRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/gdgw-attachments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworkGdgwAttachmentsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCentralNetworkGdgwAttachmentsResponse>(response);
        }

        public AsyncInvoker<ListCentralNetworkGdgwAttachmentsResponse> ListCentralNetworkGdgwAttachmentsAsyncInvoker(ListCentralNetworkGdgwAttachmentsRequest listCentralNetworkGdgwAttachmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", listCentralNetworkGdgwAttachmentsRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/gdgw-attachments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworkGdgwAttachmentsRequest);
            return new AsyncInvoker<ListCentralNetworkGdgwAttachmentsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCentralNetworkGdgwAttachmentsResponse>);
        }
        
        /// <summary>
        /// 查询中心网络ER路由表附件详情
        ///
        /// 查询中心网络ER路由表附件详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCentralNetworkErRouteTableAttachmentResponse> ShowCentralNetworkErRouteTableAttachmentAsync(ShowCentralNetworkErRouteTableAttachmentRequest showCentralNetworkErRouteTableAttachmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", showCentralNetworkErRouteTableAttachmentRequest.CentralNetworkId.ToString());
            urlParam.Add("er_route_table_attachment_id", showCentralNetworkErRouteTableAttachmentRequest.ErRouteTableAttachmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/er-route-table-attachments/{er_route_table_attachment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCentralNetworkErRouteTableAttachmentRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowCentralNetworkErRouteTableAttachmentResponse>(response);
        }

        public AsyncInvoker<ShowCentralNetworkErRouteTableAttachmentResponse> ShowCentralNetworkErRouteTableAttachmentAsyncInvoker(ShowCentralNetworkErRouteTableAttachmentRequest showCentralNetworkErRouteTableAttachmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", showCentralNetworkErRouteTableAttachmentRequest.CentralNetworkId.ToString());
            urlParam.Add("er_route_table_attachment_id", showCentralNetworkErRouteTableAttachmentRequest.ErRouteTableAttachmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/er-route-table-attachments/{er_route_table_attachment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCentralNetworkErRouteTableAttachmentRequest);
            return new AsyncInvoker<ShowCentralNetworkErRouteTableAttachmentResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCentralNetworkErRouteTableAttachmentResponse>);
        }
        
        /// <summary>
        /// 查询中心网络GDGW附件详情
        ///
        /// 查询中心网络GDGW附件详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCentralNetworkGdgwAttachmentResponse> ShowCentralNetworkGdgwAttachmentAsync(ShowCentralNetworkGdgwAttachmentRequest showCentralNetworkGdgwAttachmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", showCentralNetworkGdgwAttachmentRequest.CentralNetworkId.ToString());
            urlParam.Add("gdgw_attachment_id", showCentralNetworkGdgwAttachmentRequest.GdgwAttachmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/gdgw-attachments/{gdgw_attachment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCentralNetworkGdgwAttachmentRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowCentralNetworkGdgwAttachmentResponse>(response);
        }

        public AsyncInvoker<ShowCentralNetworkGdgwAttachmentResponse> ShowCentralNetworkGdgwAttachmentAsyncInvoker(ShowCentralNetworkGdgwAttachmentRequest showCentralNetworkGdgwAttachmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", showCentralNetworkGdgwAttachmentRequest.CentralNetworkId.ToString());
            urlParam.Add("gdgw_attachment_id", showCentralNetworkGdgwAttachmentRequest.GdgwAttachmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/gdgw-attachments/{gdgw_attachment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCentralNetworkGdgwAttachmentRequest);
            return new AsyncInvoker<ShowCentralNetworkGdgwAttachmentResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCentralNetworkGdgwAttachmentResponse>);
        }
        
        /// <summary>
        /// 更新中心网络ER路由表附件
        ///
        /// 更新中心网络ER路由表附件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateCentralNetworkErRouteTableAttachmentResponse> UpdateCentralNetworkErRouteTableAttachmentAsync(UpdateCentralNetworkErRouteTableAttachmentRequest updateCentralNetworkErRouteTableAttachmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", updateCentralNetworkErRouteTableAttachmentRequest.CentralNetworkId.ToString());
            urlParam.Add("er_route_table_attachment_id", updateCentralNetworkErRouteTableAttachmentRequest.ErRouteTableAttachmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/er-route-table-attachments/{er_route_table_attachment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCentralNetworkErRouteTableAttachmentRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateCentralNetworkErRouteTableAttachmentResponse>(response);
        }

        public AsyncInvoker<UpdateCentralNetworkErRouteTableAttachmentResponse> UpdateCentralNetworkErRouteTableAttachmentAsyncInvoker(UpdateCentralNetworkErRouteTableAttachmentRequest updateCentralNetworkErRouteTableAttachmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", updateCentralNetworkErRouteTableAttachmentRequest.CentralNetworkId.ToString());
            urlParam.Add("er_route_table_attachment_id", updateCentralNetworkErRouteTableAttachmentRequest.ErRouteTableAttachmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/er-route-table-attachments/{er_route_table_attachment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCentralNetworkErRouteTableAttachmentRequest);
            return new AsyncInvoker<UpdateCentralNetworkErRouteTableAttachmentResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateCentralNetworkErRouteTableAttachmentResponse>);
        }
        
        /// <summary>
        /// 更新中心网络GDGW附件
        ///
        /// 更新中心网络GDGW附件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateCentralNetworkGdgwAttachmentResponse> UpdateCentralNetworkGdgwAttachmentAsync(UpdateCentralNetworkGdgwAttachmentRequest updateCentralNetworkGdgwAttachmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", updateCentralNetworkGdgwAttachmentRequest.CentralNetworkId.ToString());
            urlParam.Add("gdgw_attachment_id", updateCentralNetworkGdgwAttachmentRequest.GdgwAttachmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/gdgw-attachments/{gdgw_attachment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCentralNetworkGdgwAttachmentRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateCentralNetworkGdgwAttachmentResponse>(response);
        }

        public AsyncInvoker<UpdateCentralNetworkGdgwAttachmentResponse> UpdateCentralNetworkGdgwAttachmentAsyncInvoker(UpdateCentralNetworkGdgwAttachmentRequest updateCentralNetworkGdgwAttachmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", updateCentralNetworkGdgwAttachmentRequest.CentralNetworkId.ToString());
            urlParam.Add("gdgw_attachment_id", updateCentralNetworkGdgwAttachmentRequest.GdgwAttachmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/gdgw-attachments/{gdgw_attachment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCentralNetworkGdgwAttachmentRequest);
            return new AsyncInvoker<UpdateCentralNetworkGdgwAttachmentResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateCentralNetworkGdgwAttachmentResponse>);
        }
        
        /// <summary>
        /// 查询中心网络能力列表
        ///
        /// 查询中心网络能力列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCentralNetworkCapabilitiesResponse> ListCentralNetworkCapabilitiesAsync(ListCentralNetworkCapabilitiesRequest listCentralNetworkCapabilitiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/capabilities", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworkCapabilitiesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCentralNetworkCapabilitiesResponse>(response);
        }

        public AsyncInvoker<ListCentralNetworkCapabilitiesResponse> ListCentralNetworkCapabilitiesAsyncInvoker(ListCentralNetworkCapabilitiesRequest listCentralNetworkCapabilitiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/capabilities", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworkCapabilitiesRequest);
            return new AsyncInvoker<ListCentralNetworkCapabilitiesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCentralNetworkCapabilitiesResponse>);
        }
        
        /// <summary>
        /// 查询中心网络连接列表
        ///
        /// 查询中心网络连接列表接口。
        /// 分页查询使用的参数为marker、limit。limit默认值为0，没有指定marker时返回第一条数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCentralNetworkConnectionsResponse> ListCentralNetworkConnectionsAsync(ListCentralNetworkConnectionsRequest listCentralNetworkConnectionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", listCentralNetworkConnectionsRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/connections", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworkConnectionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCentralNetworkConnectionsResponse>(response);
        }

        public AsyncInvoker<ListCentralNetworkConnectionsResponse> ListCentralNetworkConnectionsAsyncInvoker(ListCentralNetworkConnectionsRequest listCentralNetworkConnectionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", listCentralNetworkConnectionsRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/connections", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworkConnectionsRequest);
            return new AsyncInvoker<ListCentralNetworkConnectionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCentralNetworkConnectionsResponse>);
        }
        
        /// <summary>
        /// 更新中心网络连接接口
        ///
        /// 更新中心网络连接接口（仅支持更新带宽）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateCentralNetworkConnectionResponse> UpdateCentralNetworkConnectionAsync(UpdateCentralNetworkConnectionRequest updateCentralNetworkConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", updateCentralNetworkConnectionRequest.CentralNetworkId.ToString());
            urlParam.Add("connection_id", updateCentralNetworkConnectionRequest.ConnectionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/connections/{connection_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCentralNetworkConnectionRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateCentralNetworkConnectionResponse>(response);
        }

        public AsyncInvoker<UpdateCentralNetworkConnectionResponse> UpdateCentralNetworkConnectionAsyncInvoker(UpdateCentralNetworkConnectionRequest updateCentralNetworkConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", updateCentralNetworkConnectionRequest.CentralNetworkId.ToString());
            urlParam.Add("connection_id", updateCentralNetworkConnectionRequest.ConnectionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/connections/{connection_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCentralNetworkConnectionRequest);
            return new AsyncInvoker<UpdateCentralNetworkConnectionResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateCentralNetworkConnectionResponse>);
        }
        
        /// <summary>
        /// 查询中心网络配额
        ///
        /// 查询中心网络配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCentralNetworkQuotasResponse> ListCentralNetworkQuotasAsync(ListCentralNetworkQuotasRequest listCentralNetworkQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworkQuotasRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCentralNetworkQuotasResponse>(response);
        }

        public AsyncInvoker<ListCentralNetworkQuotasResponse> ListCentralNetworkQuotasAsyncInvoker(ListCentralNetworkQuotasRequest listCentralNetworkQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworkQuotasRequest);
            return new AsyncInvoker<ListCentralNetworkQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCentralNetworkQuotasResponse>);
        }
        
        /// <summary>
        /// 创建云连接实例
        ///
        /// 创建云连接实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateCloudConnectionResponse> CreateCloudConnectionAsync(CreateCloudConnectionRequest createCloudConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connections", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCloudConnectionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateCloudConnectionResponse>(response);
        }

        public AsyncInvoker<CreateCloudConnectionResponse> CreateCloudConnectionAsyncInvoker(CreateCloudConnectionRequest createCloudConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connections", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCloudConnectionRequest);
            return new AsyncInvoker<CreateCloudConnectionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCloudConnectionResponse>);
        }
        
        /// <summary>
        /// 删除云连接实例
        ///
        /// 删除云连接实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteCloudConnectionResponse> DeleteCloudConnectionAsync(DeleteCloudConnectionRequest deleteCloudConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteCloudConnectionRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connections/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCloudConnectionRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteCloudConnectionResponse>(response);
        }

        public AsyncInvoker<DeleteCloudConnectionResponse> DeleteCloudConnectionAsyncInvoker(DeleteCloudConnectionRequest deleteCloudConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteCloudConnectionRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connections/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCloudConnectionRequest);
            return new AsyncInvoker<DeleteCloudConnectionResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteCloudConnectionResponse>);
        }
        
        /// <summary>
        /// 查询云连接实例的标签信息
        ///
        /// 查询云连接实例的标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCloudConnectionTagsResponse> ListCloudConnectionTagsAsync(ListCloudConnectionTagsRequest listCloudConnectionTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connections/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloudConnectionTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCloudConnectionTagsResponse>(response);
        }

        public AsyncInvoker<ListCloudConnectionTagsResponse> ListCloudConnectionTagsAsyncInvoker(ListCloudConnectionTagsRequest listCloudConnectionTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connections/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloudConnectionTagsRequest);
            return new AsyncInvoker<ListCloudConnectionTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCloudConnectionTagsResponse>);
        }
        
        /// <summary>
        /// 查询云连接列表
        ///
        /// 查询云连接列表。
        /// 分页查询使用的参数为marker、limit。marker和limit一起使用时才会生效，单独使用无效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCloudConnectionsResponse> ListCloudConnectionsAsync(ListCloudConnectionsRequest listCloudConnectionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connections", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloudConnectionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCloudConnectionsResponse>(response);
        }

        public AsyncInvoker<ListCloudConnectionsResponse> ListCloudConnectionsAsyncInvoker(ListCloudConnectionsRequest listCloudConnectionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connections", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloudConnectionsRequest);
            return new AsyncInvoker<ListCloudConnectionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCloudConnectionsResponse>);
        }
        
        /// <summary>
        /// 通过标签过滤云连接实例
        ///
        /// 通过标签过滤云连接实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCloudConnectionsByTagsResponse> ListCloudConnectionsByTagsAsync(ListCloudConnectionsByTagsRequest listCloudConnectionsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connections/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloudConnectionsByTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListCloudConnectionsByTagsResponse>(response);
        }

        public AsyncInvoker<ListCloudConnectionsByTagsResponse> ListCloudConnectionsByTagsAsyncInvoker(ListCloudConnectionsByTagsRequest listCloudConnectionsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connections/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloudConnectionsByTagsRequest);
            return new AsyncInvoker<ListCloudConnectionsByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListCloudConnectionsByTagsResponse>);
        }
        
        /// <summary>
        /// 查询云连接实例
        ///
        /// 查询云连接实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCloudConnectionResponse> ShowCloudConnectionAsync(ShowCloudConnectionRequest showCloudConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showCloudConnectionRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connections/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCloudConnectionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowCloudConnectionResponse>(response);
        }

        public AsyncInvoker<ShowCloudConnectionResponse> ShowCloudConnectionAsyncInvoker(ShowCloudConnectionRequest showCloudConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showCloudConnectionRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connections/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCloudConnectionRequest);
            return new AsyncInvoker<ShowCloudConnectionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCloudConnectionResponse>);
        }
        
        /// <summary>
        /// 创建云连接实例标签
        ///
        /// 创建云连接实例标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<TagCloudConnectionResponse> TagCloudConnectionAsync(TagCloudConnectionRequest tagCloudConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", tagCloudConnectionRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connections/{id}/tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", tagCloudConnectionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<TagCloudConnectionResponse>(response);
        }

        public AsyncInvoker<TagCloudConnectionResponse> TagCloudConnectionAsyncInvoker(TagCloudConnectionRequest tagCloudConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", tagCloudConnectionRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connections/{id}/tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", tagCloudConnectionRequest);
            return new AsyncInvoker<TagCloudConnectionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<TagCloudConnectionResponse>);
        }
        
        /// <summary>
        /// 删除云连接实例标签
        ///
        /// 删除云连接实例标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UntagCloudConnectionResponse> UntagCloudConnectionAsync(UntagCloudConnectionRequest untagCloudConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", untagCloudConnectionRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connections/{id}/untag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", untagCloudConnectionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UntagCloudConnectionResponse>(response);
        }

        public AsyncInvoker<UntagCloudConnectionResponse> UntagCloudConnectionAsyncInvoker(UntagCloudConnectionRequest untagCloudConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", untagCloudConnectionRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connections/{id}/untag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", untagCloudConnectionRequest);
            return new AsyncInvoker<UntagCloudConnectionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UntagCloudConnectionResponse>);
        }
        
        /// <summary>
        /// 更新云连接实例
        ///
        /// 更新云连接实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateCloudConnectionResponse> UpdateCloudConnectionAsync(UpdateCloudConnectionRequest updateCloudConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateCloudConnectionRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connections/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCloudConnectionRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateCloudConnectionResponse>(response);
        }

        public AsyncInvoker<UpdateCloudConnectionResponse> UpdateCloudConnectionAsyncInvoker(UpdateCloudConnectionRequest updateCloudConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateCloudConnectionRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connections/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCloudConnectionRequest);
            return new AsyncInvoker<UpdateCloudConnectionResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateCloudConnectionResponse>);
        }
        
        /// <summary>
        /// 查询云连接的能力列表
        ///
        /// 查询云连接的能力列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCloudConnectionCapabilitiesResponse> ListCloudConnectionCapabilitiesAsync(ListCloudConnectionCapabilitiesRequest listCloudConnectionCapabilitiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/capabilities", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloudConnectionCapabilitiesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCloudConnectionCapabilitiesResponse>(response);
        }

        public AsyncInvoker<ListCloudConnectionCapabilitiesResponse> ListCloudConnectionCapabilitiesAsyncInvoker(ListCloudConnectionCapabilitiesRequest listCloudConnectionCapabilitiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/capabilities", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloudConnectionCapabilitiesRequest);
            return new AsyncInvoker<ListCloudConnectionCapabilitiesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCloudConnectionCapabilitiesResponse>);
        }
        
        /// <summary>
        /// 查询云连接配额
        ///
        /// 查询云连接配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCloudConnectionQuotasResponse> ListCloudConnectionQuotasAsync(ListCloudConnectionQuotasRequest listCloudConnectionQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloudConnectionQuotasRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCloudConnectionQuotasResponse>(response);
        }

        public AsyncInvoker<ListCloudConnectionQuotasResponse> ListCloudConnectionQuotasAsyncInvoker(ListCloudConnectionQuotasRequest listCloudConnectionQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloudConnectionQuotasRequest);
            return new AsyncInvoker<ListCloudConnectionQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCloudConnectionQuotasResponse>);
        }
        
        /// <summary>
        /// 查询云连接路由条目列表
        ///
        /// 查询云连接路由条目列表。
        /// 分页查询使用的参数为marker、limit。marker和limit一起使用时才会生效，单独使用无效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCloudConnectionRoutesResponse> ListCloudConnectionRoutesAsync(ListCloudConnectionRoutesRequest listCloudConnectionRoutesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connection-routes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloudConnectionRoutesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCloudConnectionRoutesResponse>(response);
        }

        public AsyncInvoker<ListCloudConnectionRoutesResponse> ListCloudConnectionRoutesAsyncInvoker(ListCloudConnectionRoutesRequest listCloudConnectionRoutesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connection-routes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloudConnectionRoutesRequest);
            return new AsyncInvoker<ListCloudConnectionRoutesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCloudConnectionRoutesResponse>);
        }
        
        /// <summary>
        /// 查询云连接路由条目详情
        ///
        /// 查询云连接路由条目列表。
        /// 分页查询使用的参数为marker、limit。marker和limit一起使用时才会生效，单独使用无效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCloudConnectionRoutesResponse> ShowCloudConnectionRoutesAsync(ShowCloudConnectionRoutesRequest showCloudConnectionRoutesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showCloudConnectionRoutesRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connection-routes/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCloudConnectionRoutesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowCloudConnectionRoutesResponse>(response);
        }

        public AsyncInvoker<ShowCloudConnectionRoutesResponse> ShowCloudConnectionRoutesAsyncInvoker(ShowCloudConnectionRoutesRequest showCloudConnectionRoutesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showCloudConnectionRoutesRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connection-routes/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCloudConnectionRoutesRequest);
            return new AsyncInvoker<ShowCloudConnectionRoutesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCloudConnectionRoutesResponse>);
        }
        
        /// <summary>
        /// 批量添加账户全域互联带宽资源标签
        ///
        /// TMS批量添加资源标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateGcbResourceTagsResponse> BatchCreateGcbResourceTagsAsync(BatchCreateGcbResourceTagsRequest batchCreateGcbResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchCreateGcbResourceTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/gcb/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateGcbResourceTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateGcbResourceTagsResponse>(response);
        }

        public AsyncInvoker<BatchCreateGcbResourceTagsResponse> BatchCreateGcbResourceTagsAsyncInvoker(BatchCreateGcbResourceTagsRequest batchCreateGcbResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchCreateGcbResourceTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/gcb/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateGcbResourceTagsRequest);
            return new AsyncInvoker<BatchCreateGcbResourceTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateGcbResourceTagsResponse>);
        }
        
        /// <summary>
        /// 批量删除账户全域互联带宽资源标签
        ///
        /// 批量删除账户全域互联带宽资源标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteGcbResourceTagsResponse> BatchDeleteGcbResourceTagsAsync(BatchDeleteGcbResourceTagsRequest batchDeleteGcbResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchDeleteGcbResourceTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/gcb/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteGcbResourceTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteGcbResourceTagsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteGcbResourceTagsResponse> BatchDeleteGcbResourceTagsAsyncInvoker(BatchDeleteGcbResourceTagsRequest batchDeleteGcbResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchDeleteGcbResourceTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/gcb/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteGcbResourceTagsRequest);
            return new AsyncInvoker<BatchDeleteGcbResourceTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteGcbResourceTagsResponse>);
        }
        
        /// <summary>
        /// 查询账户全域互联带宽资源标签数量
        ///
        /// 查询账户全域互联带宽资源标签数量
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CountGcbResourceByTagResponse> CountGcbResourceByTagAsync(CountGcbResourceByTagRequest countGcbResourceByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/gcb/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countGcbResourceByTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CountGcbResourceByTagResponse>(response);
        }

        public AsyncInvoker<CountGcbResourceByTagResponse> CountGcbResourceByTagAsyncInvoker(CountGcbResourceByTagRequest countGcbResourceByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/gcb/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countGcbResourceByTagRequest);
            return new AsyncInvoker<CountGcbResourceByTagResponse>(this, "POST", request, JsonUtils.DeSerialize<CountGcbResourceByTagResponse>);
        }
        
        /// <summary>
        /// 添加账户全域互联带宽资源标签
        ///
        /// 添加账户全域互联带宽资源标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateGcbResourceTagResponse> CreateGcbResourceTagAsync(CreateGcbResourceTagRequest createGcbResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", createGcbResourceTagRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/gcb/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGcbResourceTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateGcbResourceTagResponse>(response);
        }

        public AsyncInvoker<CreateGcbResourceTagResponse> CreateGcbResourceTagAsyncInvoker(CreateGcbResourceTagRequest createGcbResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", createGcbResourceTagRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/gcb/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGcbResourceTagRequest);
            return new AsyncInvoker<CreateGcbResourceTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateGcbResourceTagResponse>);
        }
        
        /// <summary>
        /// 删除账户全域互联带宽资源标签
        ///
        /// 删除账户全域互联带宽资源标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteGcbResourceTagResponse> DeleteGcbResourceTagAsync(DeleteGcbResourceTagRequest deleteGcbResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", deleteGcbResourceTagRequest.ResourceId.ToString());
            urlParam.Add("tag_key", deleteGcbResourceTagRequest.TagKey.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/gcb/{resource_id}/tags/{tag_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGcbResourceTagRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteGcbResourceTagResponse>(response);
        }

        public AsyncInvoker<DeleteGcbResourceTagResponse> DeleteGcbResourceTagAsyncInvoker(DeleteGcbResourceTagRequest deleteGcbResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", deleteGcbResourceTagRequest.ResourceId.ToString());
            urlParam.Add("tag_key", deleteGcbResourceTagRequest.TagKey.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/gcb/{resource_id}/tags/{tag_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGcbResourceTagRequest);
            return new AsyncInvoker<DeleteGcbResourceTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteGcbResourceTagResponse>);
        }
        
        /// <summary>
        /// 查询账户全域互联带宽资源实例列表
        ///
        /// 查询账户全域互联带宽资源实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGcbResourceByTagResponse> ListGcbResourceByTagAsync(ListGcbResourceByTagRequest listGcbResourceByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/gcb/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGcbResourceByTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListGcbResourceByTagResponse>(response);
        }

        public AsyncInvoker<ListGcbResourceByTagResponse> ListGcbResourceByTagAsyncInvoker(ListGcbResourceByTagRequest listGcbResourceByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/gcb/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGcbResourceByTagRequest);
            return new AsyncInvoker<ListGcbResourceByTagResponse>(this, "POST", request, JsonUtils.DeSerialize<ListGcbResourceByTagResponse>);
        }
        
        /// <summary>
        /// 查询账户全域互联带宽资源的标签
        ///
        /// 查询账户全域互联带宽资源的标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGcbResourceTagsResponse> ListGcbResourceTagsAsync(ListGcbResourceTagsRequest listGcbResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", listGcbResourceTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/gcb/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGcbResourceTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGcbResourceTagsResponse>(response);
        }

        public AsyncInvoker<ListGcbResourceTagsResponse> ListGcbResourceTagsAsyncInvoker(ListGcbResourceTagsRequest listGcbResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", listGcbResourceTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/gcb/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGcbResourceTagsRequest);
            return new AsyncInvoker<ListGcbResourceTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGcbResourceTagsResponse>);
        }
        
        /// <summary>
        /// 查询账户全域互联带宽所有资源标签
        ///
        /// 查询账户全域互联带宽所有资源标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGcbTenantTagsResponse> ListGcbTenantTagsAsync(ListGcbTenantTagsRequest listGcbTenantTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/gcb/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGcbTenantTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGcbTenantTagsResponse>(response);
        }

        public AsyncInvoker<ListGcbTenantTagsResponse> ListGcbTenantTagsAsyncInvoker(ListGcbTenantTagsRequest listGcbTenantTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/gcb/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGcbTenantTagsRequest);
            return new AsyncInvoker<ListGcbTenantTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGcbTenantTagsResponse>);
        }
        
        /// <summary>
        /// 全域互联带宽绑定实例
        ///
        /// 全域互联带宽绑定实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociateGlobalConnectionBandwidthInstanceResponse> AssociateGlobalConnectionBandwidthInstanceAsync(AssociateGlobalConnectionBandwidthInstanceRequest associateGlobalConnectionBandwidthInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", associateGlobalConnectionBandwidthInstanceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/gcbandwidths/{id}/associate-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateGlobalConnectionBandwidthInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AssociateGlobalConnectionBandwidthInstanceResponse>(response);
        }

        public AsyncInvoker<AssociateGlobalConnectionBandwidthInstanceResponse> AssociateGlobalConnectionBandwidthInstanceAsyncInvoker(AssociateGlobalConnectionBandwidthInstanceRequest associateGlobalConnectionBandwidthInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", associateGlobalConnectionBandwidthInstanceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/gcbandwidths/{id}/associate-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateGlobalConnectionBandwidthInstanceRequest);
            return new AsyncInvoker<AssociateGlobalConnectionBandwidthInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateGlobalConnectionBandwidthInstanceResponse>);
        }
        
        /// <summary>
        /// 创建全域互联带宽
        ///
        /// 创建全域互联带宽。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateGlobalConnectionBandwidthResponse> CreateGlobalConnectionBandwidthAsync(CreateGlobalConnectionBandwidthRequest createGlobalConnectionBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/gcbandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGlobalConnectionBandwidthRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateGlobalConnectionBandwidthResponse>(response);
        }

        public AsyncInvoker<CreateGlobalConnectionBandwidthResponse> CreateGlobalConnectionBandwidthAsyncInvoker(CreateGlobalConnectionBandwidthRequest createGlobalConnectionBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/gcbandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGlobalConnectionBandwidthRequest);
            return new AsyncInvoker<CreateGlobalConnectionBandwidthResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGlobalConnectionBandwidthResponse>);
        }
        
        /// <summary>
        /// 删除全域互联带宽
        ///
        /// 删除全域互联带宽。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteGlobalConnectionBandwidthResponse> DeleteGlobalConnectionBandwidthAsync(DeleteGlobalConnectionBandwidthRequest deleteGlobalConnectionBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteGlobalConnectionBandwidthRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/gcbandwidths/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGlobalConnectionBandwidthRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteGlobalConnectionBandwidthResponse>(response);
        }

        public AsyncInvoker<DeleteGlobalConnectionBandwidthResponse> DeleteGlobalConnectionBandwidthAsyncInvoker(DeleteGlobalConnectionBandwidthRequest deleteGlobalConnectionBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteGlobalConnectionBandwidthRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/gcbandwidths/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGlobalConnectionBandwidthRequest);
            return new AsyncInvoker<DeleteGlobalConnectionBandwidthResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteGlobalConnectionBandwidthResponse>);
        }
        
        /// <summary>
        /// 全域互联带宽解绑实例
        ///
        /// 全域互联带宽解绑实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisassociateGlobalConnectionBandwidthInstanceResponse> DisassociateGlobalConnectionBandwidthInstanceAsync(DisassociateGlobalConnectionBandwidthInstanceRequest disassociateGlobalConnectionBandwidthInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", disassociateGlobalConnectionBandwidthInstanceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/gcbandwidths/{id}/disassociate-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateGlobalConnectionBandwidthInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DisassociateGlobalConnectionBandwidthInstanceResponse>(response);
        }

        public AsyncInvoker<DisassociateGlobalConnectionBandwidthInstanceResponse> DisassociateGlobalConnectionBandwidthInstanceAsyncInvoker(DisassociateGlobalConnectionBandwidthInstanceRequest disassociateGlobalConnectionBandwidthInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", disassociateGlobalConnectionBandwidthInstanceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/gcbandwidths/{id}/disassociate-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateGlobalConnectionBandwidthInstanceRequest);
            return new AsyncInvoker<DisassociateGlobalConnectionBandwidthInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<DisassociateGlobalConnectionBandwidthInstanceResponse>);
        }
        
        /// <summary>
        /// 查询全域互联带宽租户配置信息
        ///
        /// 查询全域互联带宽租户配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGlobalConnectionBandwidthConfigsResponse> ListGlobalConnectionBandwidthConfigsAsync(ListGlobalConnectionBandwidthConfigsRequest listGlobalConnectionBandwidthConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalConnectionBandwidthConfigsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGlobalConnectionBandwidthConfigsResponse>(response);
        }

        public AsyncInvoker<ListGlobalConnectionBandwidthConfigsResponse> ListGlobalConnectionBandwidthConfigsAsyncInvoker(ListGlobalConnectionBandwidthConfigsRequest listGlobalConnectionBandwidthConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalConnectionBandwidthConfigsRequest);
            return new AsyncInvoker<ListGlobalConnectionBandwidthConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGlobalConnectionBandwidthConfigsResponse>);
        }
        
        /// <summary>
        /// 查询线路等级列表
        ///
        /// 查询线路等级列表。
        /// 分页查询使用的参数为marker、limit。marker和limit一起使用时才会生效，单独使用无效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGlobalConnectionBandwidthLineLevelsResponse> ListGlobalConnectionBandwidthLineLevelsAsync(ListGlobalConnectionBandwidthLineLevelsRequest listGlobalConnectionBandwidthLineLevelsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/line-levels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalConnectionBandwidthLineLevelsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGlobalConnectionBandwidthLineLevelsResponse>(response);
        }

        public AsyncInvoker<ListGlobalConnectionBandwidthLineLevelsResponse> ListGlobalConnectionBandwidthLineLevelsAsyncInvoker(ListGlobalConnectionBandwidthLineLevelsRequest listGlobalConnectionBandwidthLineLevelsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/line-levels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalConnectionBandwidthLineLevelsRequest);
            return new AsyncInvoker<ListGlobalConnectionBandwidthLineLevelsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGlobalConnectionBandwidthLineLevelsResponse>);
        }
        
        /// <summary>
        /// 查询站点列表
        ///
        /// 查询站点列表。
        /// 分页查询使用的参数为marker、limit。marker和limit一起使用时才会生效，单独使用无效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGlobalConnectionBandwidthSitesResponse> ListGlobalConnectionBandwidthSitesAsync(ListGlobalConnectionBandwidthSitesRequest listGlobalConnectionBandwidthSitesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/sites", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalConnectionBandwidthSitesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGlobalConnectionBandwidthSitesResponse>(response);
        }

        public AsyncInvoker<ListGlobalConnectionBandwidthSitesResponse> ListGlobalConnectionBandwidthSitesAsyncInvoker(ListGlobalConnectionBandwidthSitesRequest listGlobalConnectionBandwidthSitesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/sites", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalConnectionBandwidthSitesRequest);
            return new AsyncInvoker<ListGlobalConnectionBandwidthSitesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGlobalConnectionBandwidthSitesResponse>);
        }
        
        /// <summary>
        /// 查询线路规格列表
        ///
        /// 查询线路规格列表。租户白名单控制，默认为空。
        /// 分页查询使用的参数为marker、limit。marker和limit一起使用时才会生效，单独使用无效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGlobalConnectionBandwidthSpecCodesResponse> ListGlobalConnectionBandwidthSpecCodesAsync(ListGlobalConnectionBandwidthSpecCodesRequest listGlobalConnectionBandwidthSpecCodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/spec-codes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalConnectionBandwidthSpecCodesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGlobalConnectionBandwidthSpecCodesResponse>(response);
        }

        public AsyncInvoker<ListGlobalConnectionBandwidthSpecCodesResponse> ListGlobalConnectionBandwidthSpecCodesAsyncInvoker(ListGlobalConnectionBandwidthSpecCodesRequest listGlobalConnectionBandwidthSpecCodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/spec-codes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalConnectionBandwidthSpecCodesRequest);
            return new AsyncInvoker<ListGlobalConnectionBandwidthSpecCodesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGlobalConnectionBandwidthSpecCodesResponse>);
        }
        
        /// <summary>
        /// 查询全域互联带宽列表
        ///
        /// 查询全域互联带宽列表。
        /// 分页查询使用的参数为marker、limit。marker和limit一起使用时才会生效，单独使用无效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGlobalConnectionBandwidthsResponse> ListGlobalConnectionBandwidthsAsync(ListGlobalConnectionBandwidthsRequest listGlobalConnectionBandwidthsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/gcbandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalConnectionBandwidthsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGlobalConnectionBandwidthsResponse>(response);
        }

        public AsyncInvoker<ListGlobalConnectionBandwidthsResponse> ListGlobalConnectionBandwidthsAsyncInvoker(ListGlobalConnectionBandwidthsRequest listGlobalConnectionBandwidthsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/gcbandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalConnectionBandwidthsRequest);
            return new AsyncInvoker<ListGlobalConnectionBandwidthsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGlobalConnectionBandwidthsResponse>);
        }
        
        /// <summary>
        /// 查询符合绑定条件的全域互联带宽列表
        ///
        /// 查询符合绑定条件的全域互联带宽列表。
        /// 分页查询使用的参数为marker、limit。marker和limit一起使用时才会生效，单独使用无效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSupportBindingConnectionBandwidthsResponse> ListSupportBindingConnectionBandwidthsAsync(ListSupportBindingConnectionBandwidthsRequest listSupportBindingConnectionBandwidthsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/gcbandwidths/support-bindings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSupportBindingConnectionBandwidthsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSupportBindingConnectionBandwidthsResponse>(response);
        }

        public AsyncInvoker<ListSupportBindingConnectionBandwidthsResponse> ListSupportBindingConnectionBandwidthsAsyncInvoker(ListSupportBindingConnectionBandwidthsRequest listSupportBindingConnectionBandwidthsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/gcbandwidths/support-bindings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSupportBindingConnectionBandwidthsRequest);
            return new AsyncInvoker<ListSupportBindingConnectionBandwidthsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSupportBindingConnectionBandwidthsResponse>);
        }
        
        /// <summary>
        /// 查询全域互联带宽详情
        ///
        /// 查询全域互联带宽详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowGlobalConnectionBandwidthResponse> ShowGlobalConnectionBandwidthAsync(ShowGlobalConnectionBandwidthRequest showGlobalConnectionBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showGlobalConnectionBandwidthRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/gcbandwidths/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGlobalConnectionBandwidthRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowGlobalConnectionBandwidthResponse>(response);
        }

        public AsyncInvoker<ShowGlobalConnectionBandwidthResponse> ShowGlobalConnectionBandwidthAsyncInvoker(ShowGlobalConnectionBandwidthRequest showGlobalConnectionBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showGlobalConnectionBandwidthRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/gcbandwidths/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGlobalConnectionBandwidthRequest);
            return new AsyncInvoker<ShowGlobalConnectionBandwidthResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGlobalConnectionBandwidthResponse>);
        }
        
        /// <summary>
        /// 更新全域互联带宽详情
        ///
        /// 更新全域互联带宽详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateGlobalConnectionBandwidthResponse> UpdateGlobalConnectionBandwidthAsync(UpdateGlobalConnectionBandwidthRequest updateGlobalConnectionBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateGlobalConnectionBandwidthRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/gcbandwidths/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGlobalConnectionBandwidthRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGlobalConnectionBandwidthResponse>(response);
        }

        public AsyncInvoker<UpdateGlobalConnectionBandwidthResponse> UpdateGlobalConnectionBandwidthAsyncInvoker(UpdateGlobalConnectionBandwidthRequest updateGlobalConnectionBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateGlobalConnectionBandwidthRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/gcbandwidths/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGlobalConnectionBandwidthRequest);
            return new AsyncInvoker<UpdateGlobalConnectionBandwidthResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGlobalConnectionBandwidthResponse>);
        }
        
        /// <summary>
        /// 创建域间带宽实例
        ///
        /// 创建域间带宽实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInterRegionBandwidthResponse> CreateInterRegionBandwidthAsync(CreateInterRegionBandwidthRequest createInterRegionBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/inter-region-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInterRegionBandwidthRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateInterRegionBandwidthResponse>(response);
        }

        public AsyncInvoker<CreateInterRegionBandwidthResponse> CreateInterRegionBandwidthAsyncInvoker(CreateInterRegionBandwidthRequest createInterRegionBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/inter-region-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInterRegionBandwidthRequest);
            return new AsyncInvoker<CreateInterRegionBandwidthResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInterRegionBandwidthResponse>);
        }
        
        /// <summary>
        /// 删除域间带宽实例
        ///
        /// 删除域间带宽实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInterRegionBandwidthResponse> DeleteInterRegionBandwidthAsync(DeleteInterRegionBandwidthRequest deleteInterRegionBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteInterRegionBandwidthRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/inter-region-bandwidths/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInterRegionBandwidthRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInterRegionBandwidthResponse>(response);
        }

        public AsyncInvoker<DeleteInterRegionBandwidthResponse> DeleteInterRegionBandwidthAsyncInvoker(DeleteInterRegionBandwidthRequest deleteInterRegionBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteInterRegionBandwidthRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/inter-region-bandwidths/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInterRegionBandwidthRequest);
            return new AsyncInvoker<DeleteInterRegionBandwidthResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInterRegionBandwidthResponse>);
        }
        
        /// <summary>
        /// 查询域间带宽列表
        ///
        /// 查询域间带宽列表。
        /// 分页查询使用的参数为marker、limit。marker和limit一起使用时才会生效，单独使用无效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInterRegionBandwidthsResponse> ListInterRegionBandwidthsAsync(ListInterRegionBandwidthsRequest listInterRegionBandwidthsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/inter-region-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInterRegionBandwidthsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInterRegionBandwidthsResponse>(response);
        }

        public AsyncInvoker<ListInterRegionBandwidthsResponse> ListInterRegionBandwidthsAsyncInvoker(ListInterRegionBandwidthsRequest listInterRegionBandwidthsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/inter-region-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInterRegionBandwidthsRequest);
            return new AsyncInvoker<ListInterRegionBandwidthsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInterRegionBandwidthsResponse>);
        }
        
        /// <summary>
        /// 查询域间带宽实例
        ///
        /// 查询域间带宽实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInterRegionBandwidthResponse> ShowInterRegionBandwidthAsync(ShowInterRegionBandwidthRequest showInterRegionBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showInterRegionBandwidthRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/inter-region-bandwidths/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInterRegionBandwidthRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInterRegionBandwidthResponse>(response);
        }

        public AsyncInvoker<ShowInterRegionBandwidthResponse> ShowInterRegionBandwidthAsyncInvoker(ShowInterRegionBandwidthRequest showInterRegionBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showInterRegionBandwidthRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/inter-region-bandwidths/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInterRegionBandwidthRequest);
            return new AsyncInvoker<ShowInterRegionBandwidthResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInterRegionBandwidthResponse>);
        }
        
        /// <summary>
        /// 更新域间带宽实例
        ///
        /// 更新域间带宽实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInterRegionBandwidthResponse> UpdateInterRegionBandwidthAsync(UpdateInterRegionBandwidthRequest updateInterRegionBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateInterRegionBandwidthRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/inter-region-bandwidths/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInterRegionBandwidthRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInterRegionBandwidthResponse>(response);
        }

        public AsyncInvoker<UpdateInterRegionBandwidthResponse> UpdateInterRegionBandwidthAsyncInvoker(UpdateInterRegionBandwidthRequest updateInterRegionBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateInterRegionBandwidthRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/inter-region-bandwidths/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInterRegionBandwidthRequest);
            return new AsyncInvoker<UpdateInterRegionBandwidthResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInterRegionBandwidthResponse>);
        }
        
        /// <summary>
        /// 创建网络实例
        ///
        /// 创建网络实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateNetworkInstanceResponse> CreateNetworkInstanceAsync(CreateNetworkInstanceRequest createNetworkInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/network-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNetworkInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateNetworkInstanceResponse>(response);
        }

        public AsyncInvoker<CreateNetworkInstanceResponse> CreateNetworkInstanceAsyncInvoker(CreateNetworkInstanceRequest createNetworkInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/network-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNetworkInstanceRequest);
            return new AsyncInvoker<CreateNetworkInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateNetworkInstanceResponse>);
        }
        
        /// <summary>
        /// 删除网络实例
        ///
        /// 删除网络实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteNetworkInstanceResponse> DeleteNetworkInstanceAsync(DeleteNetworkInstanceRequest deleteNetworkInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteNetworkInstanceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/network-instances/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNetworkInstanceRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteNetworkInstanceResponse>(response);
        }

        public AsyncInvoker<DeleteNetworkInstanceResponse> DeleteNetworkInstanceAsyncInvoker(DeleteNetworkInstanceRequest deleteNetworkInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteNetworkInstanceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/network-instances/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNetworkInstanceRequest);
            return new AsyncInvoker<DeleteNetworkInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteNetworkInstanceResponse>);
        }
        
        /// <summary>
        /// 查询网络实例列表
        ///
        /// 查询网络实例列表。
        /// 分页查询使用的参数为marker、limit。marker和limit一起使用时才会生效，单独使用无效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNetworkInstancesResponse> ListNetworkInstancesAsync(ListNetworkInstancesRequest listNetworkInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/network-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNetworkInstancesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListNetworkInstancesResponse>(response);
        }

        public AsyncInvoker<ListNetworkInstancesResponse> ListNetworkInstancesAsyncInvoker(ListNetworkInstancesRequest listNetworkInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/network-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNetworkInstancesRequest);
            return new AsyncInvoker<ListNetworkInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNetworkInstancesResponse>);
        }
        
        /// <summary>
        /// 查询网络实例
        ///
        /// 查询网络实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowNetworkInstanceResponse> ShowNetworkInstanceAsync(ShowNetworkInstanceRequest showNetworkInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showNetworkInstanceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/network-instances/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNetworkInstanceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowNetworkInstanceResponse>(response);
        }

        public AsyncInvoker<ShowNetworkInstanceResponse> ShowNetworkInstanceAsyncInvoker(ShowNetworkInstanceRequest showNetworkInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showNetworkInstanceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/network-instances/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNetworkInstanceRequest);
            return new AsyncInvoker<ShowNetworkInstanceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNetworkInstanceResponse>);
        }
        
        /// <summary>
        /// 更新网络实例
        ///
        /// 更新网络实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateNetworkInstanceResponse> UpdateNetworkInstanceAsync(UpdateNetworkInstanceRequest updateNetworkInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateNetworkInstanceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/network-instances/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNetworkInstanceRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateNetworkInstanceResponse>(response);
        }

        public AsyncInvoker<UpdateNetworkInstanceResponse> UpdateNetworkInstanceAsyncInvoker(UpdateNetworkInstanceRequest updateNetworkInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateNetworkInstanceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/network-instances/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNetworkInstanceRequest);
            return new AsyncInvoker<UpdateNetworkInstanceResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateNetworkInstanceResponse>);
        }
        
        /// <summary>
        /// 关联分支连接带宽
        ///
        /// 关联分支连接带宽。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociateSiteNetworkBandwidthResponse> AssociateSiteNetworkBandwidthAsync(AssociateSiteNetworkBandwidthRequest associateSiteNetworkBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("site_network_id", associateSiteNetworkBandwidthRequest.SiteNetworkId.ToString());
            urlParam.Add("site_connection_id", associateSiteNetworkBandwidthRequest.SiteConnectionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-network/{site_network_id}/connections/{site_connection_id}/associate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateSiteNetworkBandwidthRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AssociateSiteNetworkBandwidthResponse>(response);
        }

        public AsyncInvoker<AssociateSiteNetworkBandwidthResponse> AssociateSiteNetworkBandwidthAsyncInvoker(AssociateSiteNetworkBandwidthRequest associateSiteNetworkBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("site_network_id", associateSiteNetworkBandwidthRequest.SiteNetworkId.ToString());
            urlParam.Add("site_connection_id", associateSiteNetworkBandwidthRequest.SiteConnectionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-network/{site_network_id}/connections/{site_connection_id}/associate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateSiteNetworkBandwidthRequest);
            return new AsyncInvoker<AssociateSiteNetworkBandwidthResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateSiteNetworkBandwidthResponse>);
        }
        
        /// <summary>
        /// 解关联分支连接带宽
        ///
        /// 解关联分支连接带宽。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisassociateSiteNetworkBandwidthResponse> DisassociateSiteNetworkBandwidthAsync(DisassociateSiteNetworkBandwidthRequest disassociateSiteNetworkBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("site_network_id", disassociateSiteNetworkBandwidthRequest.SiteNetworkId.ToString());
            urlParam.Add("site_connection_id", disassociateSiteNetworkBandwidthRequest.SiteConnectionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-network/{site_network_id}/connections/{site_connection_id}/disassociate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateSiteNetworkBandwidthRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DisassociateSiteNetworkBandwidthResponse>(response);
        }

        public AsyncInvoker<DisassociateSiteNetworkBandwidthResponse> DisassociateSiteNetworkBandwidthAsyncInvoker(DisassociateSiteNetworkBandwidthRequest disassociateSiteNetworkBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("site_network_id", disassociateSiteNetworkBandwidthRequest.SiteNetworkId.ToString());
            urlParam.Add("site_connection_id", disassociateSiteNetworkBandwidthRequest.SiteConnectionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-network/{site_network_id}/connections/{site_connection_id}/disassociate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateSiteNetworkBandwidthRequest);
            return new AsyncInvoker<DisassociateSiteNetworkBandwidthResponse>(this, "POST", request, JsonUtils.DeSerialize<DisassociateSiteNetworkBandwidthResponse>);
        }
        
        /// <summary>
        /// 更改分支连接带宽包
        ///
        /// 更改分支连接带宽包。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateSiteNetworkBandwidthResponse> UpdateSiteNetworkBandwidthAsync(UpdateSiteNetworkBandwidthRequest updateSiteNetworkBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("site_network_id", updateSiteNetworkBandwidthRequest.SiteNetworkId.ToString());
            urlParam.Add("site_connection_id", updateSiteNetworkBandwidthRequest.SiteConnectionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-network/{site_network_id}/connections/{site_connection_id}/update-bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSiteNetworkBandwidthRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateSiteNetworkBandwidthResponse>(response);
        }

        public AsyncInvoker<UpdateSiteNetworkBandwidthResponse> UpdateSiteNetworkBandwidthAsyncInvoker(UpdateSiteNetworkBandwidthRequest updateSiteNetworkBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("site_network_id", updateSiteNetworkBandwidthRequest.SiteNetworkId.ToString());
            urlParam.Add("site_connection_id", updateSiteNetworkBandwidthRequest.SiteConnectionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-network/{site_network_id}/connections/{site_connection_id}/update-bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSiteNetworkBandwidthRequest);
            return new AsyncInvoker<UpdateSiteNetworkBandwidthResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateSiteNetworkBandwidthResponse>);
        }
        
        /// <summary>
        /// 更改分支连接带宽大小
        ///
        /// 更改分支连接带宽大小。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateSiteNetworkBandwidthSizeResponse> UpdateSiteNetworkBandwidthSizeAsync(UpdateSiteNetworkBandwidthSizeRequest updateSiteNetworkBandwidthSizeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("site_network_id", updateSiteNetworkBandwidthSizeRequest.SiteNetworkId.ToString());
            urlParam.Add("site_connection_id", updateSiteNetworkBandwidthSizeRequest.SiteConnectionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-network/{site_network_id}/connections/{site_connection_id}/update-bandwidth-size", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSiteNetworkBandwidthSizeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateSiteNetworkBandwidthSizeResponse>(response);
        }

        public AsyncInvoker<UpdateSiteNetworkBandwidthSizeResponse> UpdateSiteNetworkBandwidthSizeAsyncInvoker(UpdateSiteNetworkBandwidthSizeRequest updateSiteNetworkBandwidthSizeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("site_network_id", updateSiteNetworkBandwidthSizeRequest.SiteNetworkId.ToString());
            urlParam.Add("site_connection_id", updateSiteNetworkBandwidthSizeRequest.SiteConnectionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-network/{site_network_id}/connections/{site_connection_id}/update-bandwidth-size", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSiteNetworkBandwidthSizeRequest);
            return new AsyncInvoker<UpdateSiteNetworkBandwidthSizeResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateSiteNetworkBandwidthSizeResponse>);
        }
        
        /// <summary>
        /// 创建P2P类型的分支网络
        ///
        /// 创建P2P类型的分支网络。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateP2PSiteNetworkResponse> CreateP2PSiteNetworkAsync(CreateP2PSiteNetworkRequest createP2PSiteNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/p2p-site-networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createP2PSiteNetworkRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateP2PSiteNetworkResponse>(response);
        }

        public AsyncInvoker<CreateP2PSiteNetworkResponse> CreateP2PSiteNetworkAsyncInvoker(CreateP2PSiteNetworkRequest createP2PSiteNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/p2p-site-networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createP2PSiteNetworkRequest);
            return new AsyncInvoker<CreateP2PSiteNetworkResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateP2PSiteNetworkResponse>);
        }
        
        /// <summary>
        /// 删除分支网络
        ///
        /// 删除分支网络。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSiteNetworkResponse> DeleteSiteNetworkAsync(DeleteSiteNetworkRequest deleteSiteNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("site_network_id", deleteSiteNetworkRequest.SiteNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-networks/{site_network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSiteNetworkRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteSiteNetworkResponse>(response);
        }

        public AsyncInvoker<DeleteSiteNetworkResponse> DeleteSiteNetworkAsyncInvoker(DeleteSiteNetworkRequest deleteSiteNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("site_network_id", deleteSiteNetworkRequest.SiteNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-networks/{site_network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSiteNetworkRequest);
            return new AsyncInvoker<DeleteSiteNetworkResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteSiteNetworkResponse>);
        }
        
        /// <summary>
        /// 查询分支网络列表
        ///
        /// 查询分支网络列表。
        /// 分页查询使用的参数为marker、limit。limit默认值为0，没有指定marker时返回第一条数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSiteNetworksResponse> ListSiteNetworksAsync(ListSiteNetworksRequest listSiteNetworksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSiteNetworksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSiteNetworksResponse>(response);
        }

        public AsyncInvoker<ListSiteNetworksResponse> ListSiteNetworksAsyncInvoker(ListSiteNetworksRequest listSiteNetworksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSiteNetworksRequest);
            return new AsyncInvoker<ListSiteNetworksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSiteNetworksResponse>);
        }
        
        /// <summary>
        /// 查询分支网络详情
        ///
        /// 查询分支网络详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSiteNetworkResponse> ShowSiteNetworkAsync(ShowSiteNetworkRequest showSiteNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("site_network_id", showSiteNetworkRequest.SiteNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-networks/{site_network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSiteNetworkRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSiteNetworkResponse>(response);
        }

        public AsyncInvoker<ShowSiteNetworkResponse> ShowSiteNetworkAsyncInvoker(ShowSiteNetworkRequest showSiteNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("site_network_id", showSiteNetworkRequest.SiteNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-networks/{site_network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSiteNetworkRequest);
            return new AsyncInvoker<ShowSiteNetworkResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSiteNetworkResponse>);
        }
        
        /// <summary>
        /// 更新分支网络详情
        ///
        /// 更新分支网络详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateSiteNetworkResponse> UpdateSiteNetworkAsync(UpdateSiteNetworkRequest updateSiteNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("site_network_id", updateSiteNetworkRequest.SiteNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-networks/{site_network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSiteNetworkRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSiteNetworkResponse>(response);
        }

        public AsyncInvoker<UpdateSiteNetworkResponse> UpdateSiteNetworkAsyncInvoker(UpdateSiteNetworkRequest updateSiteNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("site_network_id", updateSiteNetworkRequest.SiteNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-networks/{site_network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSiteNetworkRequest);
            return new AsyncInvoker<UpdateSiteNetworkResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSiteNetworkResponse>);
        }
        
        /// <summary>
        /// 查询分支网络的能力列表
        ///
        /// 查询分支网络的能力列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSiteNetworkCapabilitiesResponse> ListSiteNetworkCapabilitiesAsync(ListSiteNetworkCapabilitiesRequest listSiteNetworkCapabilitiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-network/capabilities", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSiteNetworkCapabilitiesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSiteNetworkCapabilitiesResponse>(response);
        }

        public AsyncInvoker<ListSiteNetworkCapabilitiesResponse> ListSiteNetworkCapabilitiesAsyncInvoker(ListSiteNetworkCapabilitiesRequest listSiteNetworkCapabilitiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-network/capabilities", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSiteNetworkCapabilitiesRequest);
            return new AsyncInvoker<ListSiteNetworkCapabilitiesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSiteNetworkCapabilitiesResponse>);
        }
        
        /// <summary>
        /// 查询分支网络配额
        ///
        /// 查询分支网络配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSiteNetworkQuotasResponse> ListSiteNetworkQuotasAsync(ListSiteNetworkQuotasRequest listSiteNetworkQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-network/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSiteNetworkQuotasRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSiteNetworkQuotasResponse>(response);
        }

        public AsyncInvoker<ListSiteNetworkQuotasResponse> ListSiteNetworkQuotasAsyncInvoker(ListSiteNetworkQuotasRequest listSiteNetworkQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-network/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSiteNetworkQuotasRequest);
            return new AsyncInvoker<ListSiteNetworkQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSiteNetworkQuotasResponse>);
        }
        
        /// <summary>
        /// 查询大区互通类型的带宽包资源规格列表
        ///
        /// 查询大区互通类型的带宽包资源规格列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAreaBandwidthPackageSpecificationsResponse> ListAreaBandwidthPackageSpecificationsAsync(ListAreaBandwidthPackageSpecificationsRequest listAreaBandwidthPackageSpecificationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/area-specifications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAreaBandwidthPackageSpecificationsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAreaBandwidthPackageSpecificationsResponse>(response);
        }

        public AsyncInvoker<ListAreaBandwidthPackageSpecificationsResponse> ListAreaBandwidthPackageSpecificationsAsyncInvoker(ListAreaBandwidthPackageSpecificationsRequest listAreaBandwidthPackageSpecificationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/area-specifications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAreaBandwidthPackageSpecificationsRequest);
            return new AsyncInvoker<ListAreaBandwidthPackageSpecificationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAreaBandwidthPackageSpecificationsResponse>);
        }
        
        /// <summary>
        /// 查询当前支持的Area列表
        ///
        /// 查询当前支持的大区列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAreasResponse> ListAreasAsync(ListAreasRequest listAreasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/areas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAreasRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAreasResponse>(response);
        }

        public AsyncInvoker<ListAreasResponse> ListAreasAsyncInvoker(ListAreasRequest listAreasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/areas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAreasRequest);
            return new AsyncInvoker<ListAreasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAreasResponse>);
        }
        
        /// <summary>
        /// 查询带宽包等级列表
        ///
        /// 查询带宽包等级列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBandwidthPackageLevelsResponse> ListBandwidthPackageLevelsAsync(ListBandwidthPackageLevelsRequest listBandwidthPackageLevelsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/levels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthPackageLevelsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListBandwidthPackageLevelsResponse>(response);
        }

        public AsyncInvoker<ListBandwidthPackageLevelsResponse> ListBandwidthPackageLevelsAsyncInvoker(ListBandwidthPackageLevelsRequest listBandwidthPackageLevelsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/levels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthPackageLevelsRequest);
            return new AsyncInvoker<ListBandwidthPackageLevelsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBandwidthPackageLevelsResponse>);
        }
        
        /// <summary>
        /// 查询带宽包线路列表
        ///
        /// 查询带宽包线路列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBandwidthPackageLinesResponse> ListBandwidthPackageLinesAsync(ListBandwidthPackageLinesRequest listBandwidthPackageLinesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/lines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthPackageLinesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListBandwidthPackageLinesResponse>(response);
        }

        public AsyncInvoker<ListBandwidthPackageLinesResponse> ListBandwidthPackageLinesAsyncInvoker(ListBandwidthPackageLinesRequest listBandwidthPackageLinesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/lines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthPackageLinesRequest);
            return new AsyncInvoker<ListBandwidthPackageLinesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBandwidthPackageLinesResponse>);
        }
        
        /// <summary>
        /// 查询带宽包站点列表
        ///
        /// 查询带宽包站点列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBandwidthPackageSitesResponse> ListBandwidthPackageSitesAsync(ListBandwidthPackageSitesRequest listBandwidthPackageSitesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/sites", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthPackageSitesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListBandwidthPackageSitesResponse>(response);
        }

        public AsyncInvoker<ListBandwidthPackageSitesResponse> ListBandwidthPackageSitesAsyncInvoker(ListBandwidthPackageSitesRequest listBandwidthPackageSitesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/sites", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthPackageSitesRequest);
            return new AsyncInvoker<ListBandwidthPackageSitesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBandwidthPackageSitesResponse>);
        }
        
        /// <summary>
        /// 查询区域互通类型的带宽包规格列表
        ///
        /// 查询区域互通类型的带宽包规格列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRegionBandwidthPackageSpecificationsResponse> ListRegionBandwidthPackageSpecificationsAsync(ListRegionBandwidthPackageSpecificationsRequest listRegionBandwidthPackageSpecificationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/region-specifications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRegionBandwidthPackageSpecificationsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRegionBandwidthPackageSpecificationsResponse>(response);
        }

        public AsyncInvoker<ListRegionBandwidthPackageSpecificationsResponse> ListRegionBandwidthPackageSpecificationsAsyncInvoker(ListRegionBandwidthPackageSpecificationsRequest listRegionBandwidthPackageSpecificationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/region-specifications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRegionBandwidthPackageSpecificationsRequest);
            return new AsyncInvoker<ListRegionBandwidthPackageSpecificationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRegionBandwidthPackageSpecificationsResponse>);
        }
        
        /// <summary>
        /// 查询当前支持的Region列表
        ///
        /// 查询当前支持的Region列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRegionsResponse> ListRegionsAsync(ListRegionsRequest listRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRegionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRegionsResponse>(response);
        }

        public AsyncInvoker<ListRegionsResponse> ListRegionsAsyncInvoker(ListRegionsRequest listRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRegionsRequest);
            return new AsyncInvoker<ListRegionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRegionsResponse>);
        }
        
    }
}