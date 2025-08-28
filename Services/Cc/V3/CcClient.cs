using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Cc.V3.Model;

namespace HuaweiCloud.SDK.Cc.V3
{
    public partial class CcClient : Client
    {
        public static ClientBuilder<CcClient> NewBuilder()
        {
            return new ClientBuilder<CcClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 创建授权
        ///
        /// 网络实例所属租户授予云连接实例所属租户加载其网络实例的权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAuthorisationResponse CreateAuthorisation(CreateAuthorisationRequest createAuthorisationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/authorisations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAuthorisationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAuthorisationResponse>(response);
        }

        public SyncInvoker<CreateAuthorisationResponse> CreateAuthorisationInvoker(CreateAuthorisationRequest createAuthorisationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/authorisations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAuthorisationRequest);
            return new SyncInvoker<CreateAuthorisationResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAuthorisationResponse>);
        }
        
        /// <summary>
        /// 删除授权
        ///
        /// 网络实例所属租户取消授予云连接实例所属租户加载其网络实例的权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAuthorisationResponse DeleteAuthorisation(DeleteAuthorisationRequest deleteAuthorisationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteAuthorisationRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/authorisations/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuthorisationRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAuthorisationResponse>(response);
        }

        public SyncInvoker<DeleteAuthorisationResponse> DeleteAuthorisationInvoker(DeleteAuthorisationRequest deleteAuthorisationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteAuthorisationRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/authorisations/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAuthorisationRequest);
            return new SyncInvoker<DeleteAuthorisationResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAuthorisationResponse>);
        }
        
        /// <summary>
        /// 查询授权列表
        ///
        /// 网络实例所属租户查看其已经授予其他租户的权限。
        /// 分页查询使用的参数为marker、limit。marker和limit一起使用时才会生效，单独使用无效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuthorisationsResponse ListAuthorisations(ListAuthorisationsRequest listAuthorisationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/authorisations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuthorisationsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAuthorisationsResponse>(response);
        }

        public SyncInvoker<ListAuthorisationsResponse> ListAuthorisationsInvoker(ListAuthorisationsRequest listAuthorisationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/authorisations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuthorisationsRequest);
            return new SyncInvoker<ListAuthorisationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuthorisationsResponse>);
        }
        
        /// <summary>
        /// 查询权限列表
        ///
        /// 云连接实例所属租户查询其可加载其他租户的网络实例权限。
        /// 分页查询使用的参数为marker、limit。marker和limit一起使用时才会生效，单独使用无效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPermissionsResponse ListPermissions(ListPermissionsRequest listPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermissionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPermissionsResponse>(response);
        }

        public SyncInvoker<ListPermissionsResponse> ListPermissionsInvoker(ListPermissionsRequest listPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermissionsRequest);
            return new SyncInvoker<ListPermissionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPermissionsResponse>);
        }
        
        /// <summary>
        /// 更新授权
        ///
        /// 更新授权实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAuthorisationResponse UpdateAuthorisation(UpdateAuthorisationRequest updateAuthorisationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateAuthorisationRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/authorisations/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAuthorisationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAuthorisationResponse>(response);
        }

        public SyncInvoker<UpdateAuthorisationResponse> UpdateAuthorisationInvoker(UpdateAuthorisationRequest updateAuthorisationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateAuthorisationRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/authorisations/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAuthorisationRequest);
            return new SyncInvoker<UpdateAuthorisationResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAuthorisationResponse>);
        }
        
        /// <summary>
        /// 将带宽包实例绑定到云连接实例
        ///
        /// 将带宽包实例绑定到云连接实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AssociateBandwidthPackageResponse AssociateBandwidthPackage(AssociateBandwidthPackageRequest associateBandwidthPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", associateBandwidthPackageRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/{id}/associate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateBandwidthPackageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AssociateBandwidthPackageResponse>(response);
        }

        public SyncInvoker<AssociateBandwidthPackageResponse> AssociateBandwidthPackageInvoker(AssociateBandwidthPackageRequest associateBandwidthPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", associateBandwidthPackageRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/{id}/associate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateBandwidthPackageRequest);
            return new SyncInvoker<AssociateBandwidthPackageResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateBandwidthPackageResponse>);
        }
        
        /// <summary>
        /// 创建带宽包实例
        ///
        /// 创建带宽包实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateBandwidthPackageResponse CreateBandwidthPackage(CreateBandwidthPackageRequest createBandwidthPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBandwidthPackageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateBandwidthPackageResponse>(response);
        }

        public SyncInvoker<CreateBandwidthPackageResponse> CreateBandwidthPackageInvoker(CreateBandwidthPackageRequest createBandwidthPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBandwidthPackageRequest);
            return new SyncInvoker<CreateBandwidthPackageResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateBandwidthPackageResponse>);
        }
        
        /// <summary>
        /// 删除带宽包实例
        ///
        /// 删除带宽包实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteBandwidthPackageResponse DeleteBandwidthPackage(DeleteBandwidthPackageRequest deleteBandwidthPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteBandwidthPackageRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBandwidthPackageRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteBandwidthPackageResponse>(response);
        }

        public SyncInvoker<DeleteBandwidthPackageResponse> DeleteBandwidthPackageInvoker(DeleteBandwidthPackageRequest deleteBandwidthPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteBandwidthPackageRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBandwidthPackageRequest);
            return new SyncInvoker<DeleteBandwidthPackageResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteBandwidthPackageResponse>);
        }
        
        /// <summary>
        /// 解除带宽包实例与云连接实例的绑定
        ///
        /// 解除带宽包实例与云连接实例的绑定。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisassociateBandwidthPackageResponse DisassociateBandwidthPackage(DisassociateBandwidthPackageRequest disassociateBandwidthPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", disassociateBandwidthPackageRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/{id}/disassociate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateBandwidthPackageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DisassociateBandwidthPackageResponse>(response);
        }

        public SyncInvoker<DisassociateBandwidthPackageResponse> DisassociateBandwidthPackageInvoker(DisassociateBandwidthPackageRequest disassociateBandwidthPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", disassociateBandwidthPackageRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/{id}/disassociate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateBandwidthPackageRequest);
            return new SyncInvoker<DisassociateBandwidthPackageResponse>(this, "POST", request, JsonUtils.DeSerialize<DisassociateBandwidthPackageResponse>);
        }
        
        /// <summary>
        /// 查询带宽包的标签信息
        ///
        /// 查询带宽包的标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBandwidthPackageTagsResponse ListBandwidthPackageTags(ListBandwidthPackageTagsRequest listBandwidthPackageTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthPackageTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBandwidthPackageTagsResponse>(response);
        }

        public SyncInvoker<ListBandwidthPackageTagsResponse> ListBandwidthPackageTagsInvoker(ListBandwidthPackageTagsRequest listBandwidthPackageTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthPackageTagsRequest);
            return new SyncInvoker<ListBandwidthPackageTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBandwidthPackageTagsResponse>);
        }
        
        /// <summary>
        /// 查询带宽包列表
        ///
        /// 查询带宽包列表。
        /// 分页查询使用的参数为marker、limit。marker和limit一起使用时才会生效，单独使用无效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBandwidthPackagesResponse ListBandwidthPackages(ListBandwidthPackagesRequest listBandwidthPackagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthPackagesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBandwidthPackagesResponse>(response);
        }

        public SyncInvoker<ListBandwidthPackagesResponse> ListBandwidthPackagesInvoker(ListBandwidthPackagesRequest listBandwidthPackagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthPackagesRequest);
            return new SyncInvoker<ListBandwidthPackagesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBandwidthPackagesResponse>);
        }
        
        /// <summary>
        /// 通过标签过滤带宽包实例
        ///
        /// 通过标签过滤带宽包实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBandwidthPackagesByTagsResponse ListBandwidthPackagesByTags(ListBandwidthPackagesByTagsRequest listBandwidthPackagesByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthPackagesByTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListBandwidthPackagesByTagsResponse>(response);
        }

        public SyncInvoker<ListBandwidthPackagesByTagsResponse> ListBandwidthPackagesByTagsInvoker(ListBandwidthPackagesByTagsRequest listBandwidthPackagesByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthPackagesByTagsRequest);
            return new SyncInvoker<ListBandwidthPackagesByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListBandwidthPackagesByTagsResponse>);
        }
        
        /// <summary>
        /// 查询带宽包实例
        ///
        /// 查询带宽包实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBandwidthPackageResponse ShowBandwidthPackage(ShowBandwidthPackageRequest showBandwidthPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showBandwidthPackageRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBandwidthPackageRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBandwidthPackageResponse>(response);
        }

        public SyncInvoker<ShowBandwidthPackageResponse> ShowBandwidthPackageInvoker(ShowBandwidthPackageRequest showBandwidthPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showBandwidthPackageRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBandwidthPackageRequest);
            return new SyncInvoker<ShowBandwidthPackageResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBandwidthPackageResponse>);
        }
        
        /// <summary>
        /// 创建带宽包标签
        ///
        /// 创建带宽包标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public TagBandwidthPackageResponse TagBandwidthPackage(TagBandwidthPackageRequest tagBandwidthPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", tagBandwidthPackageRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/{id}/tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", tagBandwidthPackageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<TagBandwidthPackageResponse>(response);
        }

        public SyncInvoker<TagBandwidthPackageResponse> TagBandwidthPackageInvoker(TagBandwidthPackageRequest tagBandwidthPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", tagBandwidthPackageRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/{id}/tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", tagBandwidthPackageRequest);
            return new SyncInvoker<TagBandwidthPackageResponse>(this, "POST", request, JsonUtils.DeSerializeNull<TagBandwidthPackageResponse>);
        }
        
        /// <summary>
        /// 删除带宽包标签
        ///
        /// 删除带宽包标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UntagBandwidthPackageResponse UntagBandwidthPackage(UntagBandwidthPackageRequest untagBandwidthPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", untagBandwidthPackageRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/{id}/untag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", untagBandwidthPackageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UntagBandwidthPackageResponse>(response);
        }

        public SyncInvoker<UntagBandwidthPackageResponse> UntagBandwidthPackageInvoker(UntagBandwidthPackageRequest untagBandwidthPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", untagBandwidthPackageRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/{id}/untag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", untagBandwidthPackageRequest);
            return new SyncInvoker<UntagBandwidthPackageResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UntagBandwidthPackageResponse>);
        }
        
        /// <summary>
        /// 更新带宽包实例
        ///
        /// 更新带宽包实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateBandwidthPackageResponse UpdateBandwidthPackage(UpdateBandwidthPackageRequest updateBandwidthPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateBandwidthPackageRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBandwidthPackageRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateBandwidthPackageResponse>(response);
        }

        public SyncInvoker<UpdateBandwidthPackageResponse> UpdateBandwidthPackageInvoker(UpdateBandwidthPackageRequest updateBandwidthPackageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateBandwidthPackageRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBandwidthPackageRequest);
            return new SyncInvoker<UpdateBandwidthPackageResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateBandwidthPackageResponse>);
        }
        
        /// <summary>
        /// 应用中心网络策略
        ///
        /// 应用中心网络策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ApplyCentralNetworkPolicyResponse ApplyCentralNetworkPolicy(ApplyCentralNetworkPolicyRequest applyCentralNetworkPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", applyCentralNetworkPolicyRequest.PolicyId.ToString());
            urlParam.Add("central_network_id", applyCentralNetworkPolicyRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/policies/{policy_id}/apply", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyCentralNetworkPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ApplyCentralNetworkPolicyResponse>(response);
        }

        public SyncInvoker<ApplyCentralNetworkPolicyResponse> ApplyCentralNetworkPolicyInvoker(ApplyCentralNetworkPolicyRequest applyCentralNetworkPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", applyCentralNetworkPolicyRequest.PolicyId.ToString());
            urlParam.Add("central_network_id", applyCentralNetworkPolicyRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/policies/{policy_id}/apply", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyCentralNetworkPolicyRequest);
            return new SyncInvoker<ApplyCentralNetworkPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<ApplyCentralNetworkPolicyResponse>);
        }
        
        /// <summary>
        /// 创建中心网络
        ///
        /// 创建中心网络。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateCentralNetworkResponse CreateCentralNetwork(CreateCentralNetworkRequest createCentralNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCentralNetworkRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateCentralNetworkResponse>(response);
        }

        public SyncInvoker<CreateCentralNetworkResponse> CreateCentralNetworkInvoker(CreateCentralNetworkRequest createCentralNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCentralNetworkRequest);
            return new SyncInvoker<CreateCentralNetworkResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCentralNetworkResponse>);
        }
        
        /// <summary>
        /// 创建一个新版本的中心网络策略
        ///
        /// 创建一份只读的中心网络的策略。如果您有策略文档内容改动，需要基于此版本重新创建一个新版本的策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateCentralNetworkPolicyResponse CreateCentralNetworkPolicy(CreateCentralNetworkPolicyRequest createCentralNetworkPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", createCentralNetworkPolicyRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCentralNetworkPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateCentralNetworkPolicyResponse>(response);
        }

        public SyncInvoker<CreateCentralNetworkPolicyResponse> CreateCentralNetworkPolicyInvoker(CreateCentralNetworkPolicyRequest createCentralNetworkPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", createCentralNetworkPolicyRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCentralNetworkPolicyRequest);
            return new SyncInvoker<CreateCentralNetworkPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCentralNetworkPolicyResponse>);
        }
        
        /// <summary>
        /// 删除中心网络
        ///
        /// 删除中心网络，请先清除附件后再删除中心网络。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteCentralNetworkResponse DeleteCentralNetwork(DeleteCentralNetworkRequest deleteCentralNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", deleteCentralNetworkRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-networks/{central_network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCentralNetworkRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteCentralNetworkResponse>(response);
        }

        public SyncInvoker<DeleteCentralNetworkResponse> DeleteCentralNetworkInvoker(DeleteCentralNetworkRequest deleteCentralNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", deleteCentralNetworkRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-networks/{central_network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCentralNetworkRequest);
            return new SyncInvoker<DeleteCentralNetworkResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteCentralNetworkResponse>);
        }
        
        /// <summary>
        /// 删除中心网络策略版本
        ///
        /// 删除中心网络策略版本。您无法删除正在被应用的中心策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteCentralNetworkPolicyResponse DeleteCentralNetworkPolicy(DeleteCentralNetworkPolicyRequest deleteCentralNetworkPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", deleteCentralNetworkPolicyRequest.PolicyId.ToString());
            urlParam.Add("central_network_id", deleteCentralNetworkPolicyRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCentralNetworkPolicyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteCentralNetworkPolicyResponse>(response);
        }

        public SyncInvoker<DeleteCentralNetworkPolicyResponse> DeleteCentralNetworkPolicyInvoker(DeleteCentralNetworkPolicyRequest deleteCentralNetworkPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", deleteCentralNetworkPolicyRequest.PolicyId.ToString());
            urlParam.Add("central_network_id", deleteCentralNetworkPolicyRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCentralNetworkPolicyRequest);
            return new SyncInvoker<DeleteCentralNetworkPolicyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteCentralNetworkPolicyResponse>);
        }
        
        /// <summary>
        /// 查询所有版本的中心网络策略列表
        ///
        /// 查询所有版本的中心网络策略列表。
        /// 分页查询使用的参数为marker、limit。limit默认值为0，没有指定marker时返回第一条数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCentralNetworkPoliciesResponse ListCentralNetworkPolicies(ListCentralNetworkPoliciesRequest listCentralNetworkPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", listCentralNetworkPoliciesRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworkPoliciesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCentralNetworkPoliciesResponse>(response);
        }

        public SyncInvoker<ListCentralNetworkPoliciesResponse> ListCentralNetworkPoliciesInvoker(ListCentralNetworkPoliciesRequest listCentralNetworkPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", listCentralNetworkPoliciesRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworkPoliciesRequest);
            return new SyncInvoker<ListCentralNetworkPoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCentralNetworkPoliciesResponse>);
        }
        
        /// <summary>
        /// 查询中心网络策略变化集
        ///
        /// 查询与当前应用中心网络策略的变化集。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCentralNetworkPolicyChangeSetResponse ListCentralNetworkPolicyChangeSet(ListCentralNetworkPolicyChangeSetRequest listCentralNetworkPolicyChangeSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", listCentralNetworkPolicyChangeSetRequest.PolicyId.ToString());
            urlParam.Add("central_network_id", listCentralNetworkPolicyChangeSetRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/policies/{policy_id}/change-set", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworkPolicyChangeSetRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCentralNetworkPolicyChangeSetResponse>(response);
        }

        public SyncInvoker<ListCentralNetworkPolicyChangeSetResponse> ListCentralNetworkPolicyChangeSetInvoker(ListCentralNetworkPolicyChangeSetRequest listCentralNetworkPolicyChangeSetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id", listCentralNetworkPolicyChangeSetRequest.PolicyId.ToString());
            urlParam.Add("central_network_id", listCentralNetworkPolicyChangeSetRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/policies/{policy_id}/change-set", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworkPolicyChangeSetRequest);
            return new SyncInvoker<ListCentralNetworkPolicyChangeSetResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCentralNetworkPolicyChangeSetResponse>);
        }
        
        /// <summary>
        /// 查询中心网络的标签信息
        ///
        /// 查询中心网络的标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCentralNetworkTagsResponse ListCentralNetworkTags(ListCentralNetworkTagsRequest listCentralNetworkTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-networks/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworkTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCentralNetworkTagsResponse>(response);
        }

        public SyncInvoker<ListCentralNetworkTagsResponse> ListCentralNetworkTagsInvoker(ListCentralNetworkTagsRequest listCentralNetworkTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-networks/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworkTagsRequest);
            return new SyncInvoker<ListCentralNetworkTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCentralNetworkTagsResponse>);
        }
        
        /// <summary>
        /// 查询中心网络列表
        ///
        /// 查询中心网络列表。
        /// 分页查询使用的参数为marker、limit。limit默认值为0，没有指定marker时返回第一条数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCentralNetworksResponse ListCentralNetworks(ListCentralNetworksRequest listCentralNetworksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCentralNetworksResponse>(response);
        }

        public SyncInvoker<ListCentralNetworksResponse> ListCentralNetworksInvoker(ListCentralNetworksRequest listCentralNetworksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworksRequest);
            return new SyncInvoker<ListCentralNetworksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCentralNetworksResponse>);
        }
        
        /// <summary>
        /// 通过标签过滤中心网络实例
        ///
        /// 通过标签过滤中心网络实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCentralNetworksByTagsResponse ListCentralNetworksByTags(ListCentralNetworksByTagsRequest listCentralNetworksByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-networks/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworksByTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListCentralNetworksByTagsResponse>(response);
        }

        public SyncInvoker<ListCentralNetworksByTagsResponse> ListCentralNetworksByTagsInvoker(ListCentralNetworksByTagsRequest listCentralNetworksByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-networks/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworksByTagsRequest);
            return new SyncInvoker<ListCentralNetworksByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListCentralNetworksByTagsResponse>);
        }
        
        /// <summary>
        /// 查询中心网络详情
        ///
        /// 查询中心网络详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowCentralNetworkResponse ShowCentralNetwork(ShowCentralNetworkRequest showCentralNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", showCentralNetworkRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-networks/{central_network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCentralNetworkRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowCentralNetworkResponse>(response);
        }

        public SyncInvoker<ShowCentralNetworkResponse> ShowCentralNetworkInvoker(ShowCentralNetworkRequest showCentralNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", showCentralNetworkRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-networks/{central_network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCentralNetworkRequest);
            return new SyncInvoker<ShowCentralNetworkResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCentralNetworkResponse>);
        }
        
        /// <summary>
        /// 创建中心网络标签
        ///
        /// 创建中心网络标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public TagCentralNetworkResponse TagCentralNetwork(TagCentralNetworkRequest tagCentralNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", tagCentralNetworkRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-networks/{central_network_id}/tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", tagCentralNetworkRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<TagCentralNetworkResponse>(response);
        }

        public SyncInvoker<TagCentralNetworkResponse> TagCentralNetworkInvoker(TagCentralNetworkRequest tagCentralNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", tagCentralNetworkRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-networks/{central_network_id}/tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", tagCentralNetworkRequest);
            return new SyncInvoker<TagCentralNetworkResponse>(this, "POST", request, JsonUtils.DeSerializeNull<TagCentralNetworkResponse>);
        }
        
        /// <summary>
        /// 删除中心网络标签
        ///
        /// 删除中心网络标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UntagCentralNetworkResponse UntagCentralNetwork(UntagCentralNetworkRequest untagCentralNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", untagCentralNetworkRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-networks/{central_network_id}/untag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", untagCentralNetworkRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UntagCentralNetworkResponse>(response);
        }

        public SyncInvoker<UntagCentralNetworkResponse> UntagCentralNetworkInvoker(UntagCentralNetworkRequest untagCentralNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", untagCentralNetworkRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-networks/{central_network_id}/untag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", untagCentralNetworkRequest);
            return new SyncInvoker<UntagCentralNetworkResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UntagCentralNetworkResponse>);
        }
        
        /// <summary>
        /// 更新中心网络详情
        ///
        /// 更新中心网络详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateCentralNetworkResponse UpdateCentralNetwork(UpdateCentralNetworkRequest updateCentralNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", updateCentralNetworkRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-networks/{central_network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCentralNetworkRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateCentralNetworkResponse>(response);
        }

        public SyncInvoker<UpdateCentralNetworkResponse> UpdateCentralNetworkInvoker(UpdateCentralNetworkRequest updateCentralNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", updateCentralNetworkRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-networks/{central_network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCentralNetworkRequest);
            return new SyncInvoker<UpdateCentralNetworkResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateCentralNetworkResponse>);
        }
        
        /// <summary>
        /// 创建中心网络ER路由表附件
        ///
        /// 创建中心网络的路由表附件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateCentralNetworkErRouteTableAttachmentResponse CreateCentralNetworkErRouteTableAttachment(CreateCentralNetworkErRouteTableAttachmentRequest createCentralNetworkErRouteTableAttachmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", createCentralNetworkErRouteTableAttachmentRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/er-route-table-attachments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCentralNetworkErRouteTableAttachmentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateCentralNetworkErRouteTableAttachmentResponse>(response);
        }

        public SyncInvoker<CreateCentralNetworkErRouteTableAttachmentResponse> CreateCentralNetworkErRouteTableAttachmentInvoker(CreateCentralNetworkErRouteTableAttachmentRequest createCentralNetworkErRouteTableAttachmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", createCentralNetworkErRouteTableAttachmentRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/er-route-table-attachments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCentralNetworkErRouteTableAttachmentRequest);
            return new SyncInvoker<CreateCentralNetworkErRouteTableAttachmentResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCentralNetworkErRouteTableAttachmentResponse>);
        }
        
        /// <summary>
        /// 创建中心网络GDGW附件
        ///
        /// 创建中心网络的GDGW附件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateCentralNetworkGdgwAttachmentResponse CreateCentralNetworkGdgwAttachment(CreateCentralNetworkGdgwAttachmentRequest createCentralNetworkGdgwAttachmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", createCentralNetworkGdgwAttachmentRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/gdgw-attachments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCentralNetworkGdgwAttachmentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateCentralNetworkGdgwAttachmentResponse>(response);
        }

        public SyncInvoker<CreateCentralNetworkGdgwAttachmentResponse> CreateCentralNetworkGdgwAttachmentInvoker(CreateCentralNetworkGdgwAttachmentRequest createCentralNetworkGdgwAttachmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", createCentralNetworkGdgwAttachmentRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/gdgw-attachments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCentralNetworkGdgwAttachmentRequest);
            return new SyncInvoker<CreateCentralNetworkGdgwAttachmentResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCentralNetworkGdgwAttachmentResponse>);
        }
        
        /// <summary>
        /// 删除中心网络附件
        ///
        /// 删除中心网络附件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteCentralNetworkAttachmentResponse DeleteCentralNetworkAttachment(DeleteCentralNetworkAttachmentRequest deleteCentralNetworkAttachmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", deleteCentralNetworkAttachmentRequest.CentralNetworkId.ToString());
            urlParam.Add("attachment_id", deleteCentralNetworkAttachmentRequest.AttachmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/attachments/{attachment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCentralNetworkAttachmentRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteCentralNetworkAttachmentResponse>(response);
        }

        public SyncInvoker<DeleteCentralNetworkAttachmentResponse> DeleteCentralNetworkAttachmentInvoker(DeleteCentralNetworkAttachmentRequest deleteCentralNetworkAttachmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", deleteCentralNetworkAttachmentRequest.CentralNetworkId.ToString());
            urlParam.Add("attachment_id", deleteCentralNetworkAttachmentRequest.AttachmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/attachments/{attachment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCentralNetworkAttachmentRequest);
            return new SyncInvoker<DeleteCentralNetworkAttachmentResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteCentralNetworkAttachmentResponse>);
        }
        
        /// <summary>
        /// 查询中心网络附件列表
        ///
        /// 查询中心网络附件列表，分页查询使用的参数为marker、limit。limit默认值为0，没有指定marker时返回第一条数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCentralNetworkAttachmentsResponse ListCentralNetworkAttachments(ListCentralNetworkAttachmentsRequest listCentralNetworkAttachmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", listCentralNetworkAttachmentsRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/attachments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworkAttachmentsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCentralNetworkAttachmentsResponse>(response);
        }

        public SyncInvoker<ListCentralNetworkAttachmentsResponse> ListCentralNetworkAttachmentsInvoker(ListCentralNetworkAttachmentsRequest listCentralNetworkAttachmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", listCentralNetworkAttachmentsRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/attachments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworkAttachmentsRequest);
            return new SyncInvoker<ListCentralNetworkAttachmentsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCentralNetworkAttachmentsResponse>);
        }
        
        /// <summary>
        /// 查询中心网络ER路由表附件列表
        ///
        /// 查询中心网络ER路由表附件列表。
        /// 分页查询使用的参数为marker、limit。limit默认值为0，没有指定marker时返回第一条数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCentralNetworkErRouteTableAttachmentsResponse ListCentralNetworkErRouteTableAttachments(ListCentralNetworkErRouteTableAttachmentsRequest listCentralNetworkErRouteTableAttachmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", listCentralNetworkErRouteTableAttachmentsRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/er-route-table-attachments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworkErRouteTableAttachmentsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCentralNetworkErRouteTableAttachmentsResponse>(response);
        }

        public SyncInvoker<ListCentralNetworkErRouteTableAttachmentsResponse> ListCentralNetworkErRouteTableAttachmentsInvoker(ListCentralNetworkErRouteTableAttachmentsRequest listCentralNetworkErRouteTableAttachmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", listCentralNetworkErRouteTableAttachmentsRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/er-route-table-attachments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworkErRouteTableAttachmentsRequest);
            return new SyncInvoker<ListCentralNetworkErRouteTableAttachmentsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCentralNetworkErRouteTableAttachmentsResponse>);
        }
        
        /// <summary>
        /// 查询中心网络GDGW附件列表
        ///
        /// 查询中心网络GDGW附件列表。
        /// 分页查询使用的参数为marker、limit。limit默认值为0，没有指定marker时返回第一条数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCentralNetworkGdgwAttachmentsResponse ListCentralNetworkGdgwAttachments(ListCentralNetworkGdgwAttachmentsRequest listCentralNetworkGdgwAttachmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", listCentralNetworkGdgwAttachmentsRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/gdgw-attachments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworkGdgwAttachmentsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCentralNetworkGdgwAttachmentsResponse>(response);
        }

        public SyncInvoker<ListCentralNetworkGdgwAttachmentsResponse> ListCentralNetworkGdgwAttachmentsInvoker(ListCentralNetworkGdgwAttachmentsRequest listCentralNetworkGdgwAttachmentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", listCentralNetworkGdgwAttachmentsRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/gdgw-attachments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworkGdgwAttachmentsRequest);
            return new SyncInvoker<ListCentralNetworkGdgwAttachmentsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCentralNetworkGdgwAttachmentsResponse>);
        }
        
        /// <summary>
        /// 查询中心网络ER路由表附件详情
        ///
        /// 查询中心网络ER路由表附件详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowCentralNetworkErRouteTableAttachmentResponse ShowCentralNetworkErRouteTableAttachment(ShowCentralNetworkErRouteTableAttachmentRequest showCentralNetworkErRouteTableAttachmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", showCentralNetworkErRouteTableAttachmentRequest.CentralNetworkId.ToString());
            urlParam.Add("er_route_table_attachment_id", showCentralNetworkErRouteTableAttachmentRequest.ErRouteTableAttachmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/er-route-table-attachments/{er_route_table_attachment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCentralNetworkErRouteTableAttachmentRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowCentralNetworkErRouteTableAttachmentResponse>(response);
        }

        public SyncInvoker<ShowCentralNetworkErRouteTableAttachmentResponse> ShowCentralNetworkErRouteTableAttachmentInvoker(ShowCentralNetworkErRouteTableAttachmentRequest showCentralNetworkErRouteTableAttachmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", showCentralNetworkErRouteTableAttachmentRequest.CentralNetworkId.ToString());
            urlParam.Add("er_route_table_attachment_id", showCentralNetworkErRouteTableAttachmentRequest.ErRouteTableAttachmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/er-route-table-attachments/{er_route_table_attachment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCentralNetworkErRouteTableAttachmentRequest);
            return new SyncInvoker<ShowCentralNetworkErRouteTableAttachmentResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCentralNetworkErRouteTableAttachmentResponse>);
        }
        
        /// <summary>
        /// 查询中心网络GDGW附件详情
        ///
        /// 查询中心网络GDGW附件详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowCentralNetworkGdgwAttachmentResponse ShowCentralNetworkGdgwAttachment(ShowCentralNetworkGdgwAttachmentRequest showCentralNetworkGdgwAttachmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", showCentralNetworkGdgwAttachmentRequest.CentralNetworkId.ToString());
            urlParam.Add("gdgw_attachment_id", showCentralNetworkGdgwAttachmentRequest.GdgwAttachmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/gdgw-attachments/{gdgw_attachment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCentralNetworkGdgwAttachmentRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowCentralNetworkGdgwAttachmentResponse>(response);
        }

        public SyncInvoker<ShowCentralNetworkGdgwAttachmentResponse> ShowCentralNetworkGdgwAttachmentInvoker(ShowCentralNetworkGdgwAttachmentRequest showCentralNetworkGdgwAttachmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", showCentralNetworkGdgwAttachmentRequest.CentralNetworkId.ToString());
            urlParam.Add("gdgw_attachment_id", showCentralNetworkGdgwAttachmentRequest.GdgwAttachmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/gdgw-attachments/{gdgw_attachment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCentralNetworkGdgwAttachmentRequest);
            return new SyncInvoker<ShowCentralNetworkGdgwAttachmentResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCentralNetworkGdgwAttachmentResponse>);
        }
        
        /// <summary>
        /// 更新中心网络ER路由表附件
        ///
        /// 更新中心网络ER路由表附件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateCentralNetworkErRouteTableAttachmentResponse UpdateCentralNetworkErRouteTableAttachment(UpdateCentralNetworkErRouteTableAttachmentRequest updateCentralNetworkErRouteTableAttachmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", updateCentralNetworkErRouteTableAttachmentRequest.CentralNetworkId.ToString());
            urlParam.Add("er_route_table_attachment_id", updateCentralNetworkErRouteTableAttachmentRequest.ErRouteTableAttachmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/er-route-table-attachments/{er_route_table_attachment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCentralNetworkErRouteTableAttachmentRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateCentralNetworkErRouteTableAttachmentResponse>(response);
        }

        public SyncInvoker<UpdateCentralNetworkErRouteTableAttachmentResponse> UpdateCentralNetworkErRouteTableAttachmentInvoker(UpdateCentralNetworkErRouteTableAttachmentRequest updateCentralNetworkErRouteTableAttachmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", updateCentralNetworkErRouteTableAttachmentRequest.CentralNetworkId.ToString());
            urlParam.Add("er_route_table_attachment_id", updateCentralNetworkErRouteTableAttachmentRequest.ErRouteTableAttachmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/er-route-table-attachments/{er_route_table_attachment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCentralNetworkErRouteTableAttachmentRequest);
            return new SyncInvoker<UpdateCentralNetworkErRouteTableAttachmentResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateCentralNetworkErRouteTableAttachmentResponse>);
        }
        
        /// <summary>
        /// 更新中心网络GDGW附件
        ///
        /// 更新中心网络GDGW附件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateCentralNetworkGdgwAttachmentResponse UpdateCentralNetworkGdgwAttachment(UpdateCentralNetworkGdgwAttachmentRequest updateCentralNetworkGdgwAttachmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", updateCentralNetworkGdgwAttachmentRequest.CentralNetworkId.ToString());
            urlParam.Add("gdgw_attachment_id", updateCentralNetworkGdgwAttachmentRequest.GdgwAttachmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/gdgw-attachments/{gdgw_attachment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCentralNetworkGdgwAttachmentRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateCentralNetworkGdgwAttachmentResponse>(response);
        }

        public SyncInvoker<UpdateCentralNetworkGdgwAttachmentResponse> UpdateCentralNetworkGdgwAttachmentInvoker(UpdateCentralNetworkGdgwAttachmentRequest updateCentralNetworkGdgwAttachmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", updateCentralNetworkGdgwAttachmentRequest.CentralNetworkId.ToString());
            urlParam.Add("gdgw_attachment_id", updateCentralNetworkGdgwAttachmentRequest.GdgwAttachmentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/gdgw-attachments/{gdgw_attachment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCentralNetworkGdgwAttachmentRequest);
            return new SyncInvoker<UpdateCentralNetworkGdgwAttachmentResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateCentralNetworkGdgwAttachmentResponse>);
        }
        
        /// <summary>
        /// 查询中心网络能力列表
        ///
        /// 查询中心网络能力列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCentralNetworkCapabilitiesResponse ListCentralNetworkCapabilities(ListCentralNetworkCapabilitiesRequest listCentralNetworkCapabilitiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/capabilities", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworkCapabilitiesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCentralNetworkCapabilitiesResponse>(response);
        }

        public SyncInvoker<ListCentralNetworkCapabilitiesResponse> ListCentralNetworkCapabilitiesInvoker(ListCentralNetworkCapabilitiesRequest listCentralNetworkCapabilitiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/capabilities", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworkCapabilitiesRequest);
            return new SyncInvoker<ListCentralNetworkCapabilitiesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCentralNetworkCapabilitiesResponse>);
        }
        
        /// <summary>
        /// 查询中心网络连接列表
        ///
        /// 查询中心网络连接列表接口。
        /// 分页查询使用的参数为marker、limit。limit默认值为0，没有指定marker时返回第一条数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCentralNetworkConnectionsResponse ListCentralNetworkConnections(ListCentralNetworkConnectionsRequest listCentralNetworkConnectionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", listCentralNetworkConnectionsRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/connections", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworkConnectionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCentralNetworkConnectionsResponse>(response);
        }

        public SyncInvoker<ListCentralNetworkConnectionsResponse> ListCentralNetworkConnectionsInvoker(ListCentralNetworkConnectionsRequest listCentralNetworkConnectionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", listCentralNetworkConnectionsRequest.CentralNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/connections", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworkConnectionsRequest);
            return new SyncInvoker<ListCentralNetworkConnectionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCentralNetworkConnectionsResponse>);
        }
        
        /// <summary>
        /// 更新中心网络连接接口
        ///
        /// 更新中心网络连接接口（仅支持更新带宽）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateCentralNetworkConnectionResponse UpdateCentralNetworkConnection(UpdateCentralNetworkConnectionRequest updateCentralNetworkConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", updateCentralNetworkConnectionRequest.CentralNetworkId.ToString());
            urlParam.Add("connection_id", updateCentralNetworkConnectionRequest.ConnectionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/connections/{connection_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCentralNetworkConnectionRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateCentralNetworkConnectionResponse>(response);
        }

        public SyncInvoker<UpdateCentralNetworkConnectionResponse> UpdateCentralNetworkConnectionInvoker(UpdateCentralNetworkConnectionRequest updateCentralNetworkConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("central_network_id", updateCentralNetworkConnectionRequest.CentralNetworkId.ToString());
            urlParam.Add("connection_id", updateCentralNetworkConnectionRequest.ConnectionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/central-network/{central_network_id}/connections/{connection_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCentralNetworkConnectionRequest);
            return new SyncInvoker<UpdateCentralNetworkConnectionResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateCentralNetworkConnectionResponse>);
        }
        
        /// <summary>
        /// 查询中心网络配额
        ///
        /// 查询中心网络配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCentralNetworkQuotasResponse ListCentralNetworkQuotas(ListCentralNetworkQuotasRequest listCentralNetworkQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworkQuotasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCentralNetworkQuotasResponse>(response);
        }

        public SyncInvoker<ListCentralNetworkQuotasResponse> ListCentralNetworkQuotasInvoker(ListCentralNetworkQuotasRequest listCentralNetworkQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcn/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCentralNetworkQuotasRequest);
            return new SyncInvoker<ListCentralNetworkQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCentralNetworkQuotasResponse>);
        }
        
        /// <summary>
        /// 创建云连接实例
        ///
        /// 创建云连接实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateCloudConnectionResponse CreateCloudConnection(CreateCloudConnectionRequest createCloudConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connections", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCloudConnectionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateCloudConnectionResponse>(response);
        }

        public SyncInvoker<CreateCloudConnectionResponse> CreateCloudConnectionInvoker(CreateCloudConnectionRequest createCloudConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connections", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCloudConnectionRequest);
            return new SyncInvoker<CreateCloudConnectionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCloudConnectionResponse>);
        }
        
        /// <summary>
        /// 删除云连接实例
        ///
        /// 删除云连接实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteCloudConnectionResponse DeleteCloudConnection(DeleteCloudConnectionRequest deleteCloudConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteCloudConnectionRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connections/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCloudConnectionRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteCloudConnectionResponse>(response);
        }

        public SyncInvoker<DeleteCloudConnectionResponse> DeleteCloudConnectionInvoker(DeleteCloudConnectionRequest deleteCloudConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteCloudConnectionRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connections/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCloudConnectionRequest);
            return new SyncInvoker<DeleteCloudConnectionResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteCloudConnectionResponse>);
        }
        
        /// <summary>
        /// 查询云连接实例的标签信息
        ///
        /// 查询云连接实例的标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCloudConnectionTagsResponse ListCloudConnectionTags(ListCloudConnectionTagsRequest listCloudConnectionTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connections/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloudConnectionTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCloudConnectionTagsResponse>(response);
        }

        public SyncInvoker<ListCloudConnectionTagsResponse> ListCloudConnectionTagsInvoker(ListCloudConnectionTagsRequest listCloudConnectionTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connections/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloudConnectionTagsRequest);
            return new SyncInvoker<ListCloudConnectionTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCloudConnectionTagsResponse>);
        }
        
        /// <summary>
        /// 查询云连接列表
        ///
        /// 查询云连接列表。
        /// 分页查询使用的参数为marker、limit。marker和limit一起使用时才会生效，单独使用无效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCloudConnectionsResponse ListCloudConnections(ListCloudConnectionsRequest listCloudConnectionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connections", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloudConnectionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCloudConnectionsResponse>(response);
        }

        public SyncInvoker<ListCloudConnectionsResponse> ListCloudConnectionsInvoker(ListCloudConnectionsRequest listCloudConnectionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connections", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloudConnectionsRequest);
            return new SyncInvoker<ListCloudConnectionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCloudConnectionsResponse>);
        }
        
        /// <summary>
        /// 通过标签过滤云连接实例
        ///
        /// 通过标签过滤云连接实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCloudConnectionsByTagsResponse ListCloudConnectionsByTags(ListCloudConnectionsByTagsRequest listCloudConnectionsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connections/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloudConnectionsByTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListCloudConnectionsByTagsResponse>(response);
        }

        public SyncInvoker<ListCloudConnectionsByTagsResponse> ListCloudConnectionsByTagsInvoker(ListCloudConnectionsByTagsRequest listCloudConnectionsByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connections/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloudConnectionsByTagsRequest);
            return new SyncInvoker<ListCloudConnectionsByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListCloudConnectionsByTagsResponse>);
        }
        
        /// <summary>
        /// 查询云连接实例
        ///
        /// 查询云连接实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowCloudConnectionResponse ShowCloudConnection(ShowCloudConnectionRequest showCloudConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showCloudConnectionRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connections/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCloudConnectionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowCloudConnectionResponse>(response);
        }

        public SyncInvoker<ShowCloudConnectionResponse> ShowCloudConnectionInvoker(ShowCloudConnectionRequest showCloudConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showCloudConnectionRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connections/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCloudConnectionRequest);
            return new SyncInvoker<ShowCloudConnectionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCloudConnectionResponse>);
        }
        
        /// <summary>
        /// 创建云连接实例标签
        ///
        /// 创建云连接实例标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public TagCloudConnectionResponse TagCloudConnection(TagCloudConnectionRequest tagCloudConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", tagCloudConnectionRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connections/{id}/tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", tagCloudConnectionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<TagCloudConnectionResponse>(response);
        }

        public SyncInvoker<TagCloudConnectionResponse> TagCloudConnectionInvoker(TagCloudConnectionRequest tagCloudConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", tagCloudConnectionRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connections/{id}/tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", tagCloudConnectionRequest);
            return new SyncInvoker<TagCloudConnectionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<TagCloudConnectionResponse>);
        }
        
        /// <summary>
        /// 删除云连接实例标签
        ///
        /// 删除云连接实例标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UntagCloudConnectionResponse UntagCloudConnection(UntagCloudConnectionRequest untagCloudConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", untagCloudConnectionRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connections/{id}/untag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", untagCloudConnectionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UntagCloudConnectionResponse>(response);
        }

        public SyncInvoker<UntagCloudConnectionResponse> UntagCloudConnectionInvoker(UntagCloudConnectionRequest untagCloudConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", untagCloudConnectionRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connections/{id}/untag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", untagCloudConnectionRequest);
            return new SyncInvoker<UntagCloudConnectionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UntagCloudConnectionResponse>);
        }
        
        /// <summary>
        /// 更新云连接实例
        ///
        /// 更新云连接实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateCloudConnectionResponse UpdateCloudConnection(UpdateCloudConnectionRequest updateCloudConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateCloudConnectionRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connections/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCloudConnectionRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateCloudConnectionResponse>(response);
        }

        public SyncInvoker<UpdateCloudConnectionResponse> UpdateCloudConnectionInvoker(UpdateCloudConnectionRequest updateCloudConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateCloudConnectionRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connections/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCloudConnectionRequest);
            return new SyncInvoker<UpdateCloudConnectionResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateCloudConnectionResponse>);
        }
        
        /// <summary>
        /// 查询云连接的能力列表
        ///
        /// 查询云连接的能力列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCloudConnectionCapabilitiesResponse ListCloudConnectionCapabilities(ListCloudConnectionCapabilitiesRequest listCloudConnectionCapabilitiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/capabilities", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloudConnectionCapabilitiesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCloudConnectionCapabilitiesResponse>(response);
        }

        public SyncInvoker<ListCloudConnectionCapabilitiesResponse> ListCloudConnectionCapabilitiesInvoker(ListCloudConnectionCapabilitiesRequest listCloudConnectionCapabilitiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/capabilities", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloudConnectionCapabilitiesRequest);
            return new SyncInvoker<ListCloudConnectionCapabilitiesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCloudConnectionCapabilitiesResponse>);
        }
        
        /// <summary>
        /// 查询云连接配额
        ///
        /// 查询云连接配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCloudConnectionQuotasResponse ListCloudConnectionQuotas(ListCloudConnectionQuotasRequest listCloudConnectionQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloudConnectionQuotasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCloudConnectionQuotasResponse>(response);
        }

        public SyncInvoker<ListCloudConnectionQuotasResponse> ListCloudConnectionQuotasInvoker(ListCloudConnectionQuotasRequest listCloudConnectionQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloudConnectionQuotasRequest);
            return new SyncInvoker<ListCloudConnectionQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCloudConnectionQuotasResponse>);
        }
        
        /// <summary>
        /// 查询云连接路由条目列表
        ///
        /// 查询云连接路由条目列表。
        /// 分页查询使用的参数为marker、limit。marker和limit一起使用时才会生效，单独使用无效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCloudConnectionRoutesResponse ListCloudConnectionRoutes(ListCloudConnectionRoutesRequest listCloudConnectionRoutesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connection-routes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloudConnectionRoutesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCloudConnectionRoutesResponse>(response);
        }

        public SyncInvoker<ListCloudConnectionRoutesResponse> ListCloudConnectionRoutesInvoker(ListCloudConnectionRoutesRequest listCloudConnectionRoutesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connection-routes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloudConnectionRoutesRequest);
            return new SyncInvoker<ListCloudConnectionRoutesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCloudConnectionRoutesResponse>);
        }
        
        /// <summary>
        /// 查询云连接路由条目详情
        ///
        /// 查询云连接路由条目列表。
        /// 分页查询使用的参数为marker、limit。marker和limit一起使用时才会生效，单独使用无效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowCloudConnectionRoutesResponse ShowCloudConnectionRoutes(ShowCloudConnectionRoutesRequest showCloudConnectionRoutesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showCloudConnectionRoutesRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connection-routes/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCloudConnectionRoutesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowCloudConnectionRoutesResponse>(response);
        }

        public SyncInvoker<ShowCloudConnectionRoutesResponse> ShowCloudConnectionRoutesInvoker(ShowCloudConnectionRoutesRequest showCloudConnectionRoutesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showCloudConnectionRoutesRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/cloud-connection-routes/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCloudConnectionRoutesRequest);
            return new SyncInvoker<ShowCloudConnectionRoutesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCloudConnectionRoutesResponse>);
        }
        
        /// <summary>
        /// 批量添加账户全域互联带宽资源标签
        ///
        /// TMS批量添加资源标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateGcbResourceTagsResponse BatchCreateGcbResourceTags(BatchCreateGcbResourceTagsRequest batchCreateGcbResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchCreateGcbResourceTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/gcb/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateGcbResourceTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateGcbResourceTagsResponse>(response);
        }

        public SyncInvoker<BatchCreateGcbResourceTagsResponse> BatchCreateGcbResourceTagsInvoker(BatchCreateGcbResourceTagsRequest batchCreateGcbResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchCreateGcbResourceTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/gcb/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateGcbResourceTagsRequest);
            return new SyncInvoker<BatchCreateGcbResourceTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateGcbResourceTagsResponse>);
        }
        
        /// <summary>
        /// 批量删除账户全域互联带宽资源标签
        ///
        /// 批量删除账户全域互联带宽资源标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteGcbResourceTagsResponse BatchDeleteGcbResourceTags(BatchDeleteGcbResourceTagsRequest batchDeleteGcbResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchDeleteGcbResourceTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/gcb/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteGcbResourceTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteGcbResourceTagsResponse>(response);
        }

        public SyncInvoker<BatchDeleteGcbResourceTagsResponse> BatchDeleteGcbResourceTagsInvoker(BatchDeleteGcbResourceTagsRequest batchDeleteGcbResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchDeleteGcbResourceTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/gcb/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteGcbResourceTagsRequest);
            return new SyncInvoker<BatchDeleteGcbResourceTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteGcbResourceTagsResponse>);
        }
        
        /// <summary>
        /// 查询账户全域互联带宽资源标签数量
        ///
        /// 查询账户全域互联带宽资源标签数量
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CountGcbResourceByTagResponse CountGcbResourceByTag(CountGcbResourceByTagRequest countGcbResourceByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/gcb/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countGcbResourceByTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CountGcbResourceByTagResponse>(response);
        }

        public SyncInvoker<CountGcbResourceByTagResponse> CountGcbResourceByTagInvoker(CountGcbResourceByTagRequest countGcbResourceByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/gcb/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countGcbResourceByTagRequest);
            return new SyncInvoker<CountGcbResourceByTagResponse>(this, "POST", request, JsonUtils.DeSerialize<CountGcbResourceByTagResponse>);
        }
        
        /// <summary>
        /// 添加账户全域互联带宽资源标签
        ///
        /// 添加账户全域互联带宽资源标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateGcbResourceTagResponse CreateGcbResourceTag(CreateGcbResourceTagRequest createGcbResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", createGcbResourceTagRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/gcb/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGcbResourceTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateGcbResourceTagResponse>(response);
        }

        public SyncInvoker<CreateGcbResourceTagResponse> CreateGcbResourceTagInvoker(CreateGcbResourceTagRequest createGcbResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", createGcbResourceTagRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/gcb/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGcbResourceTagRequest);
            return new SyncInvoker<CreateGcbResourceTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateGcbResourceTagResponse>);
        }
        
        /// <summary>
        /// 删除账户全域互联带宽资源标签
        ///
        /// 删除账户全域互联带宽资源标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteGcbResourceTagResponse DeleteGcbResourceTag(DeleteGcbResourceTagRequest deleteGcbResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", deleteGcbResourceTagRequest.ResourceId.ToString());
            urlParam.Add("tag_key", deleteGcbResourceTagRequest.TagKey.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/gcb/{resource_id}/tags/{tag_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGcbResourceTagRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteGcbResourceTagResponse>(response);
        }

        public SyncInvoker<DeleteGcbResourceTagResponse> DeleteGcbResourceTagInvoker(DeleteGcbResourceTagRequest deleteGcbResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", deleteGcbResourceTagRequest.ResourceId.ToString());
            urlParam.Add("tag_key", deleteGcbResourceTagRequest.TagKey.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/gcb/{resource_id}/tags/{tag_key}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGcbResourceTagRequest);
            return new SyncInvoker<DeleteGcbResourceTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteGcbResourceTagResponse>);
        }
        
        /// <summary>
        /// 查询账户全域互联带宽资源实例列表
        ///
        /// 查询账户全域互联带宽资源实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGcbResourceByTagResponse ListGcbResourceByTag(ListGcbResourceByTagRequest listGcbResourceByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/gcb/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGcbResourceByTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListGcbResourceByTagResponse>(response);
        }

        public SyncInvoker<ListGcbResourceByTagResponse> ListGcbResourceByTagInvoker(ListGcbResourceByTagRequest listGcbResourceByTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/gcb/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGcbResourceByTagRequest);
            return new SyncInvoker<ListGcbResourceByTagResponse>(this, "POST", request, JsonUtils.DeSerialize<ListGcbResourceByTagResponse>);
        }
        
        /// <summary>
        /// 查询账户全域互联带宽资源的标签
        ///
        /// 查询账户全域互联带宽资源的标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGcbResourceTagsResponse ListGcbResourceTags(ListGcbResourceTagsRequest listGcbResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", listGcbResourceTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/gcb/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGcbResourceTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListGcbResourceTagsResponse>(response);
        }

        public SyncInvoker<ListGcbResourceTagsResponse> ListGcbResourceTagsInvoker(ListGcbResourceTagsRequest listGcbResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", listGcbResourceTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/gcb/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGcbResourceTagsRequest);
            return new SyncInvoker<ListGcbResourceTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGcbResourceTagsResponse>);
        }
        
        /// <summary>
        /// 查询账户全域互联带宽所有资源标签
        ///
        /// 查询账户全域互联带宽所有资源标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGcbTenantTagsResponse ListGcbTenantTags(ListGcbTenantTagsRequest listGcbTenantTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/gcb/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGcbTenantTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListGcbTenantTagsResponse>(response);
        }

        public SyncInvoker<ListGcbTenantTagsResponse> ListGcbTenantTagsInvoker(ListGcbTenantTagsRequest listGcbTenantTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/gcb/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGcbTenantTagsRequest);
            return new SyncInvoker<ListGcbTenantTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGcbTenantTagsResponse>);
        }
        
        /// <summary>
        /// 全域互联带宽绑定实例
        ///
        /// 全域互联带宽绑定实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AssociateGlobalConnectionBandwidthInstanceResponse AssociateGlobalConnectionBandwidthInstance(AssociateGlobalConnectionBandwidthInstanceRequest associateGlobalConnectionBandwidthInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", associateGlobalConnectionBandwidthInstanceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/gcbandwidths/{id}/associate-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateGlobalConnectionBandwidthInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AssociateGlobalConnectionBandwidthInstanceResponse>(response);
        }

        public SyncInvoker<AssociateGlobalConnectionBandwidthInstanceResponse> AssociateGlobalConnectionBandwidthInstanceInvoker(AssociateGlobalConnectionBandwidthInstanceRequest associateGlobalConnectionBandwidthInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", associateGlobalConnectionBandwidthInstanceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/gcbandwidths/{id}/associate-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateGlobalConnectionBandwidthInstanceRequest);
            return new SyncInvoker<AssociateGlobalConnectionBandwidthInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateGlobalConnectionBandwidthInstanceResponse>);
        }
        
        /// <summary>
        /// 创建全域互联带宽
        ///
        /// 创建全域互联带宽。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateGlobalConnectionBandwidthResponse CreateGlobalConnectionBandwidth(CreateGlobalConnectionBandwidthRequest createGlobalConnectionBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/gcbandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGlobalConnectionBandwidthRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateGlobalConnectionBandwidthResponse>(response);
        }

        public SyncInvoker<CreateGlobalConnectionBandwidthResponse> CreateGlobalConnectionBandwidthInvoker(CreateGlobalConnectionBandwidthRequest createGlobalConnectionBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/gcbandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGlobalConnectionBandwidthRequest);
            return new SyncInvoker<CreateGlobalConnectionBandwidthResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGlobalConnectionBandwidthResponse>);
        }
        
        /// <summary>
        /// 删除全域互联带宽
        ///
        /// 删除全域互联带宽。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteGlobalConnectionBandwidthResponse DeleteGlobalConnectionBandwidth(DeleteGlobalConnectionBandwidthRequest deleteGlobalConnectionBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteGlobalConnectionBandwidthRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/gcbandwidths/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGlobalConnectionBandwidthRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteGlobalConnectionBandwidthResponse>(response);
        }

        public SyncInvoker<DeleteGlobalConnectionBandwidthResponse> DeleteGlobalConnectionBandwidthInvoker(DeleteGlobalConnectionBandwidthRequest deleteGlobalConnectionBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteGlobalConnectionBandwidthRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/gcbandwidths/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGlobalConnectionBandwidthRequest);
            return new SyncInvoker<DeleteGlobalConnectionBandwidthResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteGlobalConnectionBandwidthResponse>);
        }
        
        /// <summary>
        /// 全域互联带宽解绑实例
        ///
        /// 全域互联带宽解绑实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisassociateGlobalConnectionBandwidthInstanceResponse DisassociateGlobalConnectionBandwidthInstance(DisassociateGlobalConnectionBandwidthInstanceRequest disassociateGlobalConnectionBandwidthInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", disassociateGlobalConnectionBandwidthInstanceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/gcbandwidths/{id}/disassociate-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateGlobalConnectionBandwidthInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DisassociateGlobalConnectionBandwidthInstanceResponse>(response);
        }

        public SyncInvoker<DisassociateGlobalConnectionBandwidthInstanceResponse> DisassociateGlobalConnectionBandwidthInstanceInvoker(DisassociateGlobalConnectionBandwidthInstanceRequest disassociateGlobalConnectionBandwidthInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", disassociateGlobalConnectionBandwidthInstanceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/gcbandwidths/{id}/disassociate-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateGlobalConnectionBandwidthInstanceRequest);
            return new SyncInvoker<DisassociateGlobalConnectionBandwidthInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<DisassociateGlobalConnectionBandwidthInstanceResponse>);
        }
        
        /// <summary>
        /// 查询全域互联带宽租户配置信息
        ///
        /// 查询全域互联带宽租户配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGlobalConnectionBandwidthConfigsResponse ListGlobalConnectionBandwidthConfigs(ListGlobalConnectionBandwidthConfigsRequest listGlobalConnectionBandwidthConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalConnectionBandwidthConfigsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListGlobalConnectionBandwidthConfigsResponse>(response);
        }

        public SyncInvoker<ListGlobalConnectionBandwidthConfigsResponse> ListGlobalConnectionBandwidthConfigsInvoker(ListGlobalConnectionBandwidthConfigsRequest listGlobalConnectionBandwidthConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalConnectionBandwidthConfigsRequest);
            return new SyncInvoker<ListGlobalConnectionBandwidthConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGlobalConnectionBandwidthConfigsResponse>);
        }
        
        /// <summary>
        /// 查询线路等级列表
        ///
        /// 查询线路等级列表。
        /// 分页查询使用的参数为marker、limit。marker和limit一起使用时才会生效，单独使用无效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGlobalConnectionBandwidthLineLevelsResponse ListGlobalConnectionBandwidthLineLevels(ListGlobalConnectionBandwidthLineLevelsRequest listGlobalConnectionBandwidthLineLevelsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/line-levels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalConnectionBandwidthLineLevelsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListGlobalConnectionBandwidthLineLevelsResponse>(response);
        }

        public SyncInvoker<ListGlobalConnectionBandwidthLineLevelsResponse> ListGlobalConnectionBandwidthLineLevelsInvoker(ListGlobalConnectionBandwidthLineLevelsRequest listGlobalConnectionBandwidthLineLevelsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/line-levels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalConnectionBandwidthLineLevelsRequest);
            return new SyncInvoker<ListGlobalConnectionBandwidthLineLevelsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGlobalConnectionBandwidthLineLevelsResponse>);
        }
        
        /// <summary>
        /// 查询站点列表
        ///
        /// 查询站点列表。
        /// 分页查询使用的参数为marker、limit。marker和limit一起使用时才会生效，单独使用无效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGlobalConnectionBandwidthSitesResponse ListGlobalConnectionBandwidthSites(ListGlobalConnectionBandwidthSitesRequest listGlobalConnectionBandwidthSitesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/sites", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalConnectionBandwidthSitesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListGlobalConnectionBandwidthSitesResponse>(response);
        }

        public SyncInvoker<ListGlobalConnectionBandwidthSitesResponse> ListGlobalConnectionBandwidthSitesInvoker(ListGlobalConnectionBandwidthSitesRequest listGlobalConnectionBandwidthSitesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/sites", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalConnectionBandwidthSitesRequest);
            return new SyncInvoker<ListGlobalConnectionBandwidthSitesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGlobalConnectionBandwidthSitesResponse>);
        }
        
        /// <summary>
        /// 查询线路规格列表
        ///
        /// 查询线路规格列表。租户白名单控制，默认为空。
        /// 分页查询使用的参数为marker、limit。marker和limit一起使用时才会生效，单独使用无效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGlobalConnectionBandwidthSpecCodesResponse ListGlobalConnectionBandwidthSpecCodes(ListGlobalConnectionBandwidthSpecCodesRequest listGlobalConnectionBandwidthSpecCodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/spec-codes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalConnectionBandwidthSpecCodesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListGlobalConnectionBandwidthSpecCodesResponse>(response);
        }

        public SyncInvoker<ListGlobalConnectionBandwidthSpecCodesResponse> ListGlobalConnectionBandwidthSpecCodesInvoker(ListGlobalConnectionBandwidthSpecCodesRequest listGlobalConnectionBandwidthSpecCodesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/spec-codes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalConnectionBandwidthSpecCodesRequest);
            return new SyncInvoker<ListGlobalConnectionBandwidthSpecCodesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGlobalConnectionBandwidthSpecCodesResponse>);
        }
        
        /// <summary>
        /// 查询全域互联带宽列表
        ///
        /// 查询全域互联带宽列表。
        /// 分页查询使用的参数为marker、limit。marker和limit一起使用时才会生效，单独使用无效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGlobalConnectionBandwidthsResponse ListGlobalConnectionBandwidths(ListGlobalConnectionBandwidthsRequest listGlobalConnectionBandwidthsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/gcbandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalConnectionBandwidthsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListGlobalConnectionBandwidthsResponse>(response);
        }

        public SyncInvoker<ListGlobalConnectionBandwidthsResponse> ListGlobalConnectionBandwidthsInvoker(ListGlobalConnectionBandwidthsRequest listGlobalConnectionBandwidthsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/gcbandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalConnectionBandwidthsRequest);
            return new SyncInvoker<ListGlobalConnectionBandwidthsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGlobalConnectionBandwidthsResponse>);
        }
        
        /// <summary>
        /// 查询符合绑定条件的全域互联带宽列表
        ///
        /// 查询符合绑定条件的全域互联带宽列表。
        /// 分页查询使用的参数为marker、limit。marker和limit一起使用时才会生效，单独使用无效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSupportBindingConnectionBandwidthsResponse ListSupportBindingConnectionBandwidths(ListSupportBindingConnectionBandwidthsRequest listSupportBindingConnectionBandwidthsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/gcbandwidths/support-bindings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSupportBindingConnectionBandwidthsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSupportBindingConnectionBandwidthsResponse>(response);
        }

        public SyncInvoker<ListSupportBindingConnectionBandwidthsResponse> ListSupportBindingConnectionBandwidthsInvoker(ListSupportBindingConnectionBandwidthsRequest listSupportBindingConnectionBandwidthsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/gcbandwidths/support-bindings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSupportBindingConnectionBandwidthsRequest);
            return new SyncInvoker<ListSupportBindingConnectionBandwidthsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSupportBindingConnectionBandwidthsResponse>);
        }
        
        /// <summary>
        /// 查询全域互联带宽详情
        ///
        /// 查询全域互联带宽详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGlobalConnectionBandwidthResponse ShowGlobalConnectionBandwidth(ShowGlobalConnectionBandwidthRequest showGlobalConnectionBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showGlobalConnectionBandwidthRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/gcbandwidths/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGlobalConnectionBandwidthRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGlobalConnectionBandwidthResponse>(response);
        }

        public SyncInvoker<ShowGlobalConnectionBandwidthResponse> ShowGlobalConnectionBandwidthInvoker(ShowGlobalConnectionBandwidthRequest showGlobalConnectionBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showGlobalConnectionBandwidthRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/gcbandwidths/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGlobalConnectionBandwidthRequest);
            return new SyncInvoker<ShowGlobalConnectionBandwidthResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGlobalConnectionBandwidthResponse>);
        }
        
        /// <summary>
        /// 更新全域互联带宽详情
        ///
        /// 更新全域互联带宽详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGlobalConnectionBandwidthResponse UpdateGlobalConnectionBandwidth(UpdateGlobalConnectionBandwidthRequest updateGlobalConnectionBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateGlobalConnectionBandwidthRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/gcbandwidths/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGlobalConnectionBandwidthRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGlobalConnectionBandwidthResponse>(response);
        }

        public SyncInvoker<UpdateGlobalConnectionBandwidthResponse> UpdateGlobalConnectionBandwidthInvoker(UpdateGlobalConnectionBandwidthRequest updateGlobalConnectionBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateGlobalConnectionBandwidthRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/gcb/gcbandwidths/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGlobalConnectionBandwidthRequest);
            return new SyncInvoker<UpdateGlobalConnectionBandwidthResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGlobalConnectionBandwidthResponse>);
        }
        
        /// <summary>
        /// 创建域间带宽实例
        ///
        /// 创建域间带宽实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateInterRegionBandwidthResponse CreateInterRegionBandwidth(CreateInterRegionBandwidthRequest createInterRegionBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/inter-region-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInterRegionBandwidthRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateInterRegionBandwidthResponse>(response);
        }

        public SyncInvoker<CreateInterRegionBandwidthResponse> CreateInterRegionBandwidthInvoker(CreateInterRegionBandwidthRequest createInterRegionBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/inter-region-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInterRegionBandwidthRequest);
            return new SyncInvoker<CreateInterRegionBandwidthResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInterRegionBandwidthResponse>);
        }
        
        /// <summary>
        /// 删除域间带宽实例
        ///
        /// 删除域间带宽实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteInterRegionBandwidthResponse DeleteInterRegionBandwidth(DeleteInterRegionBandwidthRequest deleteInterRegionBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteInterRegionBandwidthRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/inter-region-bandwidths/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInterRegionBandwidthRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInterRegionBandwidthResponse>(response);
        }

        public SyncInvoker<DeleteInterRegionBandwidthResponse> DeleteInterRegionBandwidthInvoker(DeleteInterRegionBandwidthRequest deleteInterRegionBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteInterRegionBandwidthRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/inter-region-bandwidths/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInterRegionBandwidthRequest);
            return new SyncInvoker<DeleteInterRegionBandwidthResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInterRegionBandwidthResponse>);
        }
        
        /// <summary>
        /// 查询域间带宽列表
        ///
        /// 查询域间带宽列表。
        /// 分页查询使用的参数为marker、limit。marker和limit一起使用时才会生效，单独使用无效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInterRegionBandwidthsResponse ListInterRegionBandwidths(ListInterRegionBandwidthsRequest listInterRegionBandwidthsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/inter-region-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInterRegionBandwidthsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInterRegionBandwidthsResponse>(response);
        }

        public SyncInvoker<ListInterRegionBandwidthsResponse> ListInterRegionBandwidthsInvoker(ListInterRegionBandwidthsRequest listInterRegionBandwidthsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/inter-region-bandwidths", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInterRegionBandwidthsRequest);
            return new SyncInvoker<ListInterRegionBandwidthsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInterRegionBandwidthsResponse>);
        }
        
        /// <summary>
        /// 查询域间带宽实例
        ///
        /// 查询域间带宽实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInterRegionBandwidthResponse ShowInterRegionBandwidth(ShowInterRegionBandwidthRequest showInterRegionBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showInterRegionBandwidthRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/inter-region-bandwidths/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInterRegionBandwidthRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInterRegionBandwidthResponse>(response);
        }

        public SyncInvoker<ShowInterRegionBandwidthResponse> ShowInterRegionBandwidthInvoker(ShowInterRegionBandwidthRequest showInterRegionBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showInterRegionBandwidthRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/inter-region-bandwidths/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInterRegionBandwidthRequest);
            return new SyncInvoker<ShowInterRegionBandwidthResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInterRegionBandwidthResponse>);
        }
        
        /// <summary>
        /// 更新域间带宽实例
        ///
        /// 更新域间带宽实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInterRegionBandwidthResponse UpdateInterRegionBandwidth(UpdateInterRegionBandwidthRequest updateInterRegionBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateInterRegionBandwidthRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/inter-region-bandwidths/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInterRegionBandwidthRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInterRegionBandwidthResponse>(response);
        }

        public SyncInvoker<UpdateInterRegionBandwidthResponse> UpdateInterRegionBandwidthInvoker(UpdateInterRegionBandwidthRequest updateInterRegionBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateInterRegionBandwidthRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/inter-region-bandwidths/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInterRegionBandwidthRequest);
            return new SyncInvoker<UpdateInterRegionBandwidthResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInterRegionBandwidthResponse>);
        }
        
        /// <summary>
        /// 创建网络实例
        ///
        /// 创建网络实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateNetworkInstanceResponse CreateNetworkInstance(CreateNetworkInstanceRequest createNetworkInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/network-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNetworkInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateNetworkInstanceResponse>(response);
        }

        public SyncInvoker<CreateNetworkInstanceResponse> CreateNetworkInstanceInvoker(CreateNetworkInstanceRequest createNetworkInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/network-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNetworkInstanceRequest);
            return new SyncInvoker<CreateNetworkInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateNetworkInstanceResponse>);
        }
        
        /// <summary>
        /// 删除网络实例
        ///
        /// 删除网络实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteNetworkInstanceResponse DeleteNetworkInstance(DeleteNetworkInstanceRequest deleteNetworkInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteNetworkInstanceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/network-instances/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNetworkInstanceRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteNetworkInstanceResponse>(response);
        }

        public SyncInvoker<DeleteNetworkInstanceResponse> DeleteNetworkInstanceInvoker(DeleteNetworkInstanceRequest deleteNetworkInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteNetworkInstanceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/network-instances/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNetworkInstanceRequest);
            return new SyncInvoker<DeleteNetworkInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteNetworkInstanceResponse>);
        }
        
        /// <summary>
        /// 查询网络实例列表
        ///
        /// 查询网络实例列表。
        /// 分页查询使用的参数为marker、limit。marker和limit一起使用时才会生效，单独使用无效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListNetworkInstancesResponse ListNetworkInstances(ListNetworkInstancesRequest listNetworkInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/network-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNetworkInstancesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListNetworkInstancesResponse>(response);
        }

        public SyncInvoker<ListNetworkInstancesResponse> ListNetworkInstancesInvoker(ListNetworkInstancesRequest listNetworkInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/network-instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNetworkInstancesRequest);
            return new SyncInvoker<ListNetworkInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNetworkInstancesResponse>);
        }
        
        /// <summary>
        /// 查询网络实例
        ///
        /// 查询网络实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowNetworkInstanceResponse ShowNetworkInstance(ShowNetworkInstanceRequest showNetworkInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showNetworkInstanceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/network-instances/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNetworkInstanceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowNetworkInstanceResponse>(response);
        }

        public SyncInvoker<ShowNetworkInstanceResponse> ShowNetworkInstanceInvoker(ShowNetworkInstanceRequest showNetworkInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showNetworkInstanceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/network-instances/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNetworkInstanceRequest);
            return new SyncInvoker<ShowNetworkInstanceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNetworkInstanceResponse>);
        }
        
        /// <summary>
        /// 更新网络实例
        ///
        /// 更新网络实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateNetworkInstanceResponse UpdateNetworkInstance(UpdateNetworkInstanceRequest updateNetworkInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateNetworkInstanceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/network-instances/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNetworkInstanceRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateNetworkInstanceResponse>(response);
        }

        public SyncInvoker<UpdateNetworkInstanceResponse> UpdateNetworkInstanceInvoker(UpdateNetworkInstanceRequest updateNetworkInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateNetworkInstanceRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/network-instances/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNetworkInstanceRequest);
            return new SyncInvoker<UpdateNetworkInstanceResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateNetworkInstanceResponse>);
        }
        
        /// <summary>
        /// 关联分支连接带宽
        ///
        /// 关联分支连接带宽。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AssociateSiteNetworkBandwidthResponse AssociateSiteNetworkBandwidth(AssociateSiteNetworkBandwidthRequest associateSiteNetworkBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("site_network_id", associateSiteNetworkBandwidthRequest.SiteNetworkId.ToString());
            urlParam.Add("site_connection_id", associateSiteNetworkBandwidthRequest.SiteConnectionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-network/{site_network_id}/connections/{site_connection_id}/associate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateSiteNetworkBandwidthRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AssociateSiteNetworkBandwidthResponse>(response);
        }

        public SyncInvoker<AssociateSiteNetworkBandwidthResponse> AssociateSiteNetworkBandwidthInvoker(AssociateSiteNetworkBandwidthRequest associateSiteNetworkBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("site_network_id", associateSiteNetworkBandwidthRequest.SiteNetworkId.ToString());
            urlParam.Add("site_connection_id", associateSiteNetworkBandwidthRequest.SiteConnectionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-network/{site_network_id}/connections/{site_connection_id}/associate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateSiteNetworkBandwidthRequest);
            return new SyncInvoker<AssociateSiteNetworkBandwidthResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateSiteNetworkBandwidthResponse>);
        }
        
        /// <summary>
        /// 解关联分支连接带宽
        ///
        /// 解关联分支连接带宽。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisassociateSiteNetworkBandwidthResponse DisassociateSiteNetworkBandwidth(DisassociateSiteNetworkBandwidthRequest disassociateSiteNetworkBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("site_network_id", disassociateSiteNetworkBandwidthRequest.SiteNetworkId.ToString());
            urlParam.Add("site_connection_id", disassociateSiteNetworkBandwidthRequest.SiteConnectionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-network/{site_network_id}/connections/{site_connection_id}/disassociate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateSiteNetworkBandwidthRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DisassociateSiteNetworkBandwidthResponse>(response);
        }

        public SyncInvoker<DisassociateSiteNetworkBandwidthResponse> DisassociateSiteNetworkBandwidthInvoker(DisassociateSiteNetworkBandwidthRequest disassociateSiteNetworkBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("site_network_id", disassociateSiteNetworkBandwidthRequest.SiteNetworkId.ToString());
            urlParam.Add("site_connection_id", disassociateSiteNetworkBandwidthRequest.SiteConnectionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-network/{site_network_id}/connections/{site_connection_id}/disassociate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateSiteNetworkBandwidthRequest);
            return new SyncInvoker<DisassociateSiteNetworkBandwidthResponse>(this, "POST", request, JsonUtils.DeSerialize<DisassociateSiteNetworkBandwidthResponse>);
        }
        
        /// <summary>
        /// 更改分支连接带宽包
        ///
        /// 更改分支连接带宽包。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateSiteNetworkBandwidthResponse UpdateSiteNetworkBandwidth(UpdateSiteNetworkBandwidthRequest updateSiteNetworkBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("site_network_id", updateSiteNetworkBandwidthRequest.SiteNetworkId.ToString());
            urlParam.Add("site_connection_id", updateSiteNetworkBandwidthRequest.SiteConnectionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-network/{site_network_id}/connections/{site_connection_id}/update-bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSiteNetworkBandwidthRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateSiteNetworkBandwidthResponse>(response);
        }

        public SyncInvoker<UpdateSiteNetworkBandwidthResponse> UpdateSiteNetworkBandwidthInvoker(UpdateSiteNetworkBandwidthRequest updateSiteNetworkBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("site_network_id", updateSiteNetworkBandwidthRequest.SiteNetworkId.ToString());
            urlParam.Add("site_connection_id", updateSiteNetworkBandwidthRequest.SiteConnectionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-network/{site_network_id}/connections/{site_connection_id}/update-bandwidth", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSiteNetworkBandwidthRequest);
            return new SyncInvoker<UpdateSiteNetworkBandwidthResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateSiteNetworkBandwidthResponse>);
        }
        
        /// <summary>
        /// 更改分支连接带宽大小
        ///
        /// 更改分支连接带宽大小。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateSiteNetworkBandwidthSizeResponse UpdateSiteNetworkBandwidthSize(UpdateSiteNetworkBandwidthSizeRequest updateSiteNetworkBandwidthSizeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("site_network_id", updateSiteNetworkBandwidthSizeRequest.SiteNetworkId.ToString());
            urlParam.Add("site_connection_id", updateSiteNetworkBandwidthSizeRequest.SiteConnectionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-network/{site_network_id}/connections/{site_connection_id}/update-bandwidth-size", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSiteNetworkBandwidthSizeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateSiteNetworkBandwidthSizeResponse>(response);
        }

        public SyncInvoker<UpdateSiteNetworkBandwidthSizeResponse> UpdateSiteNetworkBandwidthSizeInvoker(UpdateSiteNetworkBandwidthSizeRequest updateSiteNetworkBandwidthSizeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("site_network_id", updateSiteNetworkBandwidthSizeRequest.SiteNetworkId.ToString());
            urlParam.Add("site_connection_id", updateSiteNetworkBandwidthSizeRequest.SiteConnectionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-network/{site_network_id}/connections/{site_connection_id}/update-bandwidth-size", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSiteNetworkBandwidthSizeRequest);
            return new SyncInvoker<UpdateSiteNetworkBandwidthSizeResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateSiteNetworkBandwidthSizeResponse>);
        }
        
        /// <summary>
        /// 创建P2P类型的分支网络
        ///
        /// 创建P2P类型的分支网络。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateP2PSiteNetworkResponse CreateP2PSiteNetwork(CreateP2PSiteNetworkRequest createP2PSiteNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/p2p-site-networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createP2PSiteNetworkRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateP2PSiteNetworkResponse>(response);
        }

        public SyncInvoker<CreateP2PSiteNetworkResponse> CreateP2PSiteNetworkInvoker(CreateP2PSiteNetworkRequest createP2PSiteNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/p2p-site-networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createP2PSiteNetworkRequest);
            return new SyncInvoker<CreateP2PSiteNetworkResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateP2PSiteNetworkResponse>);
        }
        
        /// <summary>
        /// 删除分支网络
        ///
        /// 删除分支网络。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSiteNetworkResponse DeleteSiteNetwork(DeleteSiteNetworkRequest deleteSiteNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("site_network_id", deleteSiteNetworkRequest.SiteNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-networks/{site_network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSiteNetworkRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteSiteNetworkResponse>(response);
        }

        public SyncInvoker<DeleteSiteNetworkResponse> DeleteSiteNetworkInvoker(DeleteSiteNetworkRequest deleteSiteNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("site_network_id", deleteSiteNetworkRequest.SiteNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-networks/{site_network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSiteNetworkRequest);
            return new SyncInvoker<DeleteSiteNetworkResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteSiteNetworkResponse>);
        }
        
        /// <summary>
        /// 查询分支网络列表
        ///
        /// 查询分支网络列表。
        /// 分页查询使用的参数为marker、limit。limit默认值为0，没有指定marker时返回第一条数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSiteNetworksResponse ListSiteNetworks(ListSiteNetworksRequest listSiteNetworksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSiteNetworksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSiteNetworksResponse>(response);
        }

        public SyncInvoker<ListSiteNetworksResponse> ListSiteNetworksInvoker(ListSiteNetworksRequest listSiteNetworksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-networks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSiteNetworksRequest);
            return new SyncInvoker<ListSiteNetworksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSiteNetworksResponse>);
        }
        
        /// <summary>
        /// 查询分支网络详情
        ///
        /// 查询分支网络详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSiteNetworkResponse ShowSiteNetwork(ShowSiteNetworkRequest showSiteNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("site_network_id", showSiteNetworkRequest.SiteNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-networks/{site_network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSiteNetworkRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSiteNetworkResponse>(response);
        }

        public SyncInvoker<ShowSiteNetworkResponse> ShowSiteNetworkInvoker(ShowSiteNetworkRequest showSiteNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("site_network_id", showSiteNetworkRequest.SiteNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-networks/{site_network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSiteNetworkRequest);
            return new SyncInvoker<ShowSiteNetworkResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSiteNetworkResponse>);
        }
        
        /// <summary>
        /// 更新分支网络详情
        ///
        /// 更新分支网络详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateSiteNetworkResponse UpdateSiteNetwork(UpdateSiteNetworkRequest updateSiteNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("site_network_id", updateSiteNetworkRequest.SiteNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-networks/{site_network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSiteNetworkRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSiteNetworkResponse>(response);
        }

        public SyncInvoker<UpdateSiteNetworkResponse> UpdateSiteNetworkInvoker(UpdateSiteNetworkRequest updateSiteNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("site_network_id", updateSiteNetworkRequest.SiteNetworkId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-networks/{site_network_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSiteNetworkRequest);
            return new SyncInvoker<UpdateSiteNetworkResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSiteNetworkResponse>);
        }
        
        /// <summary>
        /// 查询分支网络的能力列表
        ///
        /// 查询分支网络的能力列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSiteNetworkCapabilitiesResponse ListSiteNetworkCapabilities(ListSiteNetworkCapabilitiesRequest listSiteNetworkCapabilitiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-network/capabilities", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSiteNetworkCapabilitiesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSiteNetworkCapabilitiesResponse>(response);
        }

        public SyncInvoker<ListSiteNetworkCapabilitiesResponse> ListSiteNetworkCapabilitiesInvoker(ListSiteNetworkCapabilitiesRequest listSiteNetworkCapabilitiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-network/capabilities", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSiteNetworkCapabilitiesRequest);
            return new SyncInvoker<ListSiteNetworkCapabilitiesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSiteNetworkCapabilitiesResponse>);
        }
        
        /// <summary>
        /// 查询分支网络配额
        ///
        /// 查询分支网络配额。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSiteNetworkQuotasResponse ListSiteNetworkQuotas(ListSiteNetworkQuotasRequest listSiteNetworkQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-network/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSiteNetworkQuotasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSiteNetworkQuotasResponse>(response);
        }

        public SyncInvoker<ListSiteNetworkQuotasResponse> ListSiteNetworkQuotasInvoker(ListSiteNetworkQuotasRequest listSiteNetworkQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/dcaas/site-network/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSiteNetworkQuotasRequest);
            return new SyncInvoker<ListSiteNetworkQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSiteNetworkQuotasResponse>);
        }
        
        /// <summary>
        /// 查询大区互通类型的带宽包资源规格列表
        ///
        /// 查询大区互通类型的带宽包资源规格列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAreaBandwidthPackageSpecificationsResponse ListAreaBandwidthPackageSpecifications(ListAreaBandwidthPackageSpecificationsRequest listAreaBandwidthPackageSpecificationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/area-specifications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAreaBandwidthPackageSpecificationsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAreaBandwidthPackageSpecificationsResponse>(response);
        }

        public SyncInvoker<ListAreaBandwidthPackageSpecificationsResponse> ListAreaBandwidthPackageSpecificationsInvoker(ListAreaBandwidthPackageSpecificationsRequest listAreaBandwidthPackageSpecificationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/area-specifications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAreaBandwidthPackageSpecificationsRequest);
            return new SyncInvoker<ListAreaBandwidthPackageSpecificationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAreaBandwidthPackageSpecificationsResponse>);
        }
        
        /// <summary>
        /// 查询当前支持的Area列表
        ///
        /// 查询当前支持的大区列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAreasResponse ListAreas(ListAreasRequest listAreasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/areas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAreasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAreasResponse>(response);
        }

        public SyncInvoker<ListAreasResponse> ListAreasInvoker(ListAreasRequest listAreasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/areas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAreasRequest);
            return new SyncInvoker<ListAreasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAreasResponse>);
        }
        
        /// <summary>
        /// 查询带宽包等级列表
        ///
        /// 查询带宽包等级列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBandwidthPackageLevelsResponse ListBandwidthPackageLevels(ListBandwidthPackageLevelsRequest listBandwidthPackageLevelsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/levels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthPackageLevelsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBandwidthPackageLevelsResponse>(response);
        }

        public SyncInvoker<ListBandwidthPackageLevelsResponse> ListBandwidthPackageLevelsInvoker(ListBandwidthPackageLevelsRequest listBandwidthPackageLevelsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/levels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthPackageLevelsRequest);
            return new SyncInvoker<ListBandwidthPackageLevelsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBandwidthPackageLevelsResponse>);
        }
        
        /// <summary>
        /// 查询带宽包线路列表
        ///
        /// 查询带宽包线路列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBandwidthPackageLinesResponse ListBandwidthPackageLines(ListBandwidthPackageLinesRequest listBandwidthPackageLinesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/lines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthPackageLinesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBandwidthPackageLinesResponse>(response);
        }

        public SyncInvoker<ListBandwidthPackageLinesResponse> ListBandwidthPackageLinesInvoker(ListBandwidthPackageLinesRequest listBandwidthPackageLinesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/lines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthPackageLinesRequest);
            return new SyncInvoker<ListBandwidthPackageLinesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBandwidthPackageLinesResponse>);
        }
        
        /// <summary>
        /// 查询带宽包站点列表
        ///
        /// 查询带宽包站点列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBandwidthPackageSitesResponse ListBandwidthPackageSites(ListBandwidthPackageSitesRequest listBandwidthPackageSitesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/sites", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthPackageSitesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBandwidthPackageSitesResponse>(response);
        }

        public SyncInvoker<ListBandwidthPackageSitesResponse> ListBandwidthPackageSitesInvoker(ListBandwidthPackageSitesRequest listBandwidthPackageSitesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/sites", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthPackageSitesRequest);
            return new SyncInvoker<ListBandwidthPackageSitesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBandwidthPackageSitesResponse>);
        }
        
        /// <summary>
        /// 查询区域互通类型的带宽包规格列表
        ///
        /// 查询区域互通类型的带宽包规格列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRegionBandwidthPackageSpecificationsResponse ListRegionBandwidthPackageSpecifications(ListRegionBandwidthPackageSpecificationsRequest listRegionBandwidthPackageSpecificationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/region-specifications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRegionBandwidthPackageSpecificationsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRegionBandwidthPackageSpecificationsResponse>(response);
        }

        public SyncInvoker<ListRegionBandwidthPackageSpecificationsResponse> ListRegionBandwidthPackageSpecificationsInvoker(ListRegionBandwidthPackageSpecificationsRequest listRegionBandwidthPackageSpecificationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/bandwidth-packages/region-specifications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRegionBandwidthPackageSpecificationsRequest);
            return new SyncInvoker<ListRegionBandwidthPackageSpecificationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRegionBandwidthPackageSpecificationsResponse>);
        }
        
        /// <summary>
        /// 查询当前支持的Region列表
        ///
        /// 查询当前支持的Region列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRegionsResponse ListRegions(ListRegionsRequest listRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRegionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRegionsResponse>(response);
        }

        public SyncInvoker<ListRegionsResponse> ListRegionsInvoker(ListRegionsRequest listRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/ccaas/regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRegionsRequest);
            return new SyncInvoker<ListRegionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRegionsResponse>);
        }
        
    }
}