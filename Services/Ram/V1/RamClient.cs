using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Ram.V1.Model;

namespace HuaweiCloud.SDK.Ram.V1
{
    public partial class RamClient : Client
    {
        public static ClientBuilder<RamClient> NewBuilder()
        {
            return new ClientBuilder<RamClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 绑定或替换共享资源权限
        ///
        /// 为资源共享实例中包含的资源类型绑定或替换共享资源权限。 对于资源共享实例中的每一种资源类型，您可以设置唯一权限。仅当资源共享实例中当前没有该资源类型的资源时，您才能绑定新的共享资源权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AssociateResourceSharePermissionResponse AssociateResourceSharePermission(AssociateResourceSharePermissionRequest associateResourceSharePermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateResourceSharePermissionRequest.ResourceShareId, out var valueOfResourceShareId)) urlParam.Add("resource_share_id", valueOfResourceShareId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/{resource_share_id}/associate-permission", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateResourceSharePermissionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<AssociateResourceSharePermissionResponse>(response);
        }

        public SyncInvoker<AssociateResourceSharePermissionResponse> AssociateResourceSharePermissionInvoker(AssociateResourceSharePermissionRequest associateResourceSharePermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateResourceSharePermissionRequest.ResourceShareId, out var valueOfResourceShareId)) urlParam.Add("resource_share_id", valueOfResourceShareId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/{resource_share_id}/associate-permission", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateResourceSharePermissionRequest);
            return new SyncInvoker<AssociateResourceSharePermissionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AssociateResourceSharePermissionResponse>);
        }
        
        /// <summary>
        /// 移除共享资源权限
        ///
        /// 移除资源共享实例绑定的共享资源权限。权限更改立即生效。只有当目前资源共享实例中没有绑定相关资源类型时，您才能从资源共享实例中移除共享资源权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisassociateResourceSharePermissionResponse DisassociateResourceSharePermission(DisassociateResourceSharePermissionRequest disassociateResourceSharePermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disassociateResourceSharePermissionRequest.ResourceShareId, out var valueOfResourceShareId)) urlParam.Add("resource_share_id", valueOfResourceShareId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/{resource_share_id}/disassociate-permission", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateResourceSharePermissionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DisassociateResourceSharePermissionResponse>(response);
        }

        public SyncInvoker<DisassociateResourceSharePermissionResponse> DisassociateResourceSharePermissionInvoker(DisassociateResourceSharePermissionRequest disassociateResourceSharePermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disassociateResourceSharePermissionRequest.ResourceShareId, out var valueOfResourceShareId)) urlParam.Add("resource_share_id", valueOfResourceShareId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/{resource_share_id}/disassociate-permission", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateResourceSharePermissionRequest);
            return new SyncInvoker<DisassociateResourceSharePermissionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DisassociateResourceSharePermissionResponse>);
        }
        
        /// <summary>
        /// 检索绑定的共享资源权限
        ///
        /// 检索资源共享实例关联的共享资源权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListResourceSharePermissionsResponse ListResourceSharePermissions(ListResourceSharePermissionsRequest listResourceSharePermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourceSharePermissionsRequest.ResourceShareId, out var valueOfResourceShareId)) urlParam.Add("resource_share_id", valueOfResourceShareId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/{resource_share_id}/associated-permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceSharePermissionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListResourceSharePermissionsResponse>(response);
        }

        public SyncInvoker<ListResourceSharePermissionsResponse> ListResourceSharePermissionsInvoker(ListResourceSharePermissionsRequest listResourceSharePermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listResourceSharePermissionsRequest.ResourceShareId, out var valueOfResourceShareId)) urlParam.Add("resource_share_id", valueOfResourceShareId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/{resource_share_id}/associated-permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceSharePermissionsRequest);
            return new SyncInvoker<ListResourceSharePermissionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListResourceSharePermissionsResponse>);
        }
        
        /// <summary>
        /// 查询资源共享的配额
        ///
        /// 查询当前账号的资源共享配额信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListQuotaResponse ListQuota(ListQuotaRequest listQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotaRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListQuotaResponse>(response);
        }

        public SyncInvoker<ListQuotaResponse> ListQuotaInvoker(ListQuotaRequest listQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotaRequest);
            return new SyncInvoker<ListQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ListQuotaResponse>);
        }
        
        /// <summary>
        /// 检索云服务资源类型
        ///
        /// 查询已对接云服务的资源类型和区域等信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListResourceTypesResponse ListResourceTypes(ListResourceTypesRequest listResourceTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-types", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceTypesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListResourceTypesResponse>(response);
        }

        public SyncInvoker<ListResourceTypesResponse> ListResourceTypesInvoker(ListResourceTypesRequest listResourceTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-types", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceTypesRequest);
            return new SyncInvoker<ListResourceTypesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListResourceTypesResponse>);
        }
        
        /// <summary>
        /// 关闭与组织共享
        ///
        /// 关闭与组织共享资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisableOrganizationShareResponse DisableOrganizationShare(DisableOrganizationShareRequest disableOrganizationShareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organization-share/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableOrganizationShareRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DisableOrganizationShareResponse>(response);
        }

        public SyncInvoker<DisableOrganizationShareResponse> DisableOrganizationShareInvoker(DisableOrganizationShareRequest disableOrganizationShareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organization-share/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableOrganizationShareRequest);
            return new SyncInvoker<DisableOrganizationShareResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DisableOrganizationShareResponse>);
        }
        
        /// <summary>
        /// 启用与组织共享
        ///
        /// 启用与组织共享资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EnableOrganizationShareResponse EnableOrganizationShare(EnableOrganizationShareRequest enableOrganizationShareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organization-share/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableOrganizationShareRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<EnableOrganizationShareResponse>(response);
        }

        public SyncInvoker<EnableOrganizationShareResponse> EnableOrganizationShareInvoker(EnableOrganizationShareRequest enableOrganizationShareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organization-share/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableOrganizationShareRequest);
            return new SyncInvoker<EnableOrganizationShareResponse>(this, "POST", request, JsonUtils.DeSerializeNull<EnableOrganizationShareResponse>);
        }
        
        /// <summary>
        /// 检索是否启用与组织共享
        ///
        /// 检索是否启用与组织共享资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowOrganizationShareResponse ShowOrganizationShare(ShowOrganizationShareRequest showOrganizationShareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organization-share", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrganizationShareRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowOrganizationShareResponse>(response);
        }

        public SyncInvoker<ShowOrganizationShareResponse> ShowOrganizationShareInvoker(ShowOrganizationShareRequest showOrganizationShareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organization-share", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrganizationShareRequest);
            return new SyncInvoker<ShowOrganizationShareResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOrganizationShareResponse>);
        }
        
        /// <summary>
        /// 获取权限的所有版本
        ///
        /// 获取权限的所有版本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPermissionVersionsResponse ListPermissionVersions(ListPermissionVersionsRequest listPermissionVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPermissionVersionsRequest.PermissionId, out var valueOfPermissionId)) urlParam.Add("permission_id", valueOfPermissionId);
            var urlPath = HttpUtils.AddUrlPath("/v1/permissions/{permission_id}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermissionVersionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPermissionVersionsResponse>(response);
        }

        public SyncInvoker<ListPermissionVersionsResponse> ListPermissionVersionsInvoker(ListPermissionVersionsRequest listPermissionVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPermissionVersionsRequest.PermissionId, out var valueOfPermissionId)) urlParam.Add("permission_id", valueOfPermissionId);
            var urlPath = HttpUtils.AddUrlPath("/v1/permissions/{permission_id}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermissionVersionsRequest);
            return new SyncInvoker<ListPermissionVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPermissionVersionsResponse>);
        }
        
        /// <summary>
        /// 检索共享资源权限列表
        ///
        /// 检索指定资源类型的共享资源权限列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPermissionsResponse ListPermissions(ListPermissionsRequest listPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermissionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPermissionsResponse>(response);
        }

        public SyncInvoker<ListPermissionsResponse> ListPermissionsInvoker(ListPermissionsRequest listPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermissionsRequest);
            return new SyncInvoker<ListPermissionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPermissionsResponse>);
        }
        
        /// <summary>
        /// 检索资源共享权限内容
        ///
        /// 检索指定资源类型的共享资源指定版本的权限内容，如果不指定权限版本，则返回默认版本的权限内容。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPermissionResponse ShowPermission(ShowPermissionRequest showPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPermissionRequest.PermissionId, out var valueOfPermissionId)) urlParam.Add("permission_id", valueOfPermissionId);
            var urlPath = HttpUtils.AddUrlPath("/v1/permissions/{permission_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPermissionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPermissionResponse>(response);
        }

        public SyncInvoker<ShowPermissionResponse> ShowPermissionInvoker(ShowPermissionRequest showPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPermissionRequest.PermissionId, out var valueOfPermissionId)) urlParam.Add("permission_id", valueOfPermissionId);
            var urlPath = HttpUtils.AddUrlPath("/v1/permissions/{permission_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPermissionRequest);
            return new SyncInvoker<ShowPermissionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPermissionResponse>);
        }
        
        /// <summary>
        /// 检索不同的资源使用者或者资源所有者
        ///
        /// 检索您正在共享资源的不同使用者或共享给您的不同资源所有者。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchDistinctPrincipalsResponse SearchDistinctPrincipals(SearchDistinctPrincipalsRequest searchDistinctPrincipalsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/shared-principals/search-distinct-principal", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchDistinctPrincipalsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SearchDistinctPrincipalsResponse>(response);
        }

        public SyncInvoker<SearchDistinctPrincipalsResponse> SearchDistinctPrincipalsInvoker(SearchDistinctPrincipalsRequest searchDistinctPrincipalsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/shared-principals/search-distinct-principal", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchDistinctPrincipalsRequest);
            return new SyncInvoker<SearchDistinctPrincipalsResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchDistinctPrincipalsResponse>);
        }
        
        /// <summary>
        /// 检索资源使用者或者资源所有者
        ///
        /// 检索共享资源的使用者或者共享给您的资源所有者。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchSharedPrincipalsResponse SearchSharedPrincipals(SearchSharedPrincipalsRequest searchSharedPrincipalsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/shared-principals/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchSharedPrincipalsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SearchSharedPrincipalsResponse>(response);
        }

        public SyncInvoker<SearchSharedPrincipalsResponse> SearchSharedPrincipalsInvoker(SearchSharedPrincipalsRequest searchSharedPrincipalsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/shared-principals/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchSharedPrincipalsRequest);
            return new SyncInvoker<SearchSharedPrincipalsResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchSharedPrincipalsResponse>);
        }
        
        /// <summary>
        /// 检索共享的不同资源
        ///
        /// 检索您添加到资源共享或被共享给您的不同资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchDistinctSharedResourcesResponse SearchDistinctSharedResources(SearchDistinctSharedResourcesRequest searchDistinctSharedResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/shared-resources/search-distinct-resource", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchDistinctSharedResourcesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SearchDistinctSharedResourcesResponse>(response);
        }

        public SyncInvoker<SearchDistinctSharedResourcesResponse> SearchDistinctSharedResourcesInvoker(SearchDistinctSharedResourcesRequest searchDistinctSharedResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/shared-resources/search-distinct-resource", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchDistinctSharedResourcesRequest);
            return new SyncInvoker<SearchDistinctSharedResourcesResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchDistinctSharedResourcesResponse>);
        }
        
        /// <summary>
        /// 检索共享的资源
        ///
        /// 检索您共享的或共享给您的资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchSharedResourcesResponse SearchSharedResources(SearchSharedResourcesRequest searchSharedResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/shared-resources/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchSharedResourcesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SearchSharedResourcesResponse>(response);
        }

        public SyncInvoker<SearchSharedResourcesResponse> SearchSharedResourcesInvoker(SearchSharedResourcesRequest searchSharedResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/shared-resources/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchSharedResourcesRequest);
            return new SyncInvoker<SearchSharedResourcesResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchSharedResourcesResponse>);
        }
        
        /// <summary>
        /// 创建资源共享实例
        ///
        /// 创建一个资源共享实例。您可以指定需要共享的资源列表，资源使用者列表，以及授予资源使用者的权限列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateResourceShareResponse CreateResourceShare(CreateResourceShareRequest createResourceShareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createResourceShareRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateResourceShareResponse>(response);
        }

        public SyncInvoker<CreateResourceShareResponse> CreateResourceShareInvoker(CreateResourceShareRequest createResourceShareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createResourceShareRequest);
            return new SyncInvoker<CreateResourceShareResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateResourceShareResponse>);
        }
        
        /// <summary>
        /// 删除资源共享实例
        ///
        /// 删除指定的资源共享实例。此操作不会删除实体资源，仅停止向其他账号共享资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteResourceShareResponse DeleteResourceShare(DeleteResourceShareRequest deleteResourceShareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteResourceShareRequest.ResourceShareId, out var valueOfResourceShareId)) urlParam.Add("resource_share_id", valueOfResourceShareId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/{resource_share_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResourceShareRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteResourceShareResponse>(response);
        }

        public SyncInvoker<DeleteResourceShareResponse> DeleteResourceShareInvoker(DeleteResourceShareRequest deleteResourceShareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteResourceShareRequest.ResourceShareId, out var valueOfResourceShareId)) urlParam.Add("resource_share_id", valueOfResourceShareId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/{resource_share_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResourceShareRequest);
            return new SyncInvoker<DeleteResourceShareResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteResourceShareResponse>);
        }
        
        /// <summary>
        /// 检索资源共享实例
        ///
        /// 检索您创建的或者共享给您的资源共享实例详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchResourceSharesResponse SearchResourceShares(SearchResourceSharesRequest searchResourceSharesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchResourceSharesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SearchResourceSharesResponse>(response);
        }

        public SyncInvoker<SearchResourceSharesResponse> SearchResourceSharesInvoker(SearchResourceSharesRequest searchResourceSharesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchResourceSharesRequest);
            return new SyncInvoker<SearchResourceSharesResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchResourceSharesResponse>);
        }
        
        /// <summary>
        /// 更新资源共享实例
        ///
        /// 修改资源共享实例的特定属性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateResourceShareResponse UpdateResourceShare(UpdateResourceShareRequest updateResourceShareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateResourceShareRequest.ResourceShareId, out var valueOfResourceShareId)) urlParam.Add("resource_share_id", valueOfResourceShareId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/{resource_share_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResourceShareRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateResourceShareResponse>(response);
        }

        public SyncInvoker<UpdateResourceShareResponse> UpdateResourceShareInvoker(UpdateResourceShareRequest updateResourceShareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateResourceShareRequest.ResourceShareId, out var valueOfResourceShareId)) urlParam.Add("resource_share_id", valueOfResourceShareId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/{resource_share_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResourceShareRequest);
            return new SyncInvoker<UpdateResourceShareResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateResourceShareResponse>);
        }
        
        /// <summary>
        /// 绑定资源使用者和共享资源
        ///
        /// 向资源共享实例绑定指定的资源使用者列表或共享资源列表。对于新增的共享资源，有权访问此资源共享实例的资源使用者获得该共享资源的访问权限。对于新增的资源使用者，获得对此资源共享实例中共享资源的访问权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AssociateResourceShareResponse AssociateResourceShare(AssociateResourceShareRequest associateResourceShareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateResourceShareRequest.ResourceShareId, out var valueOfResourceShareId)) urlParam.Add("resource_share_id", valueOfResourceShareId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/{resource_share_id}/associate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateResourceShareRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AssociateResourceShareResponse>(response);
        }

        public SyncInvoker<AssociateResourceShareResponse> AssociateResourceShareInvoker(AssociateResourceShareRequest associateResourceShareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateResourceShareRequest.ResourceShareId, out var valueOfResourceShareId)) urlParam.Add("resource_share_id", valueOfResourceShareId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/{resource_share_id}/associate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateResourceShareRequest);
            return new SyncInvoker<AssociateResourceShareResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateResourceShareResponse>);
        }
        
        /// <summary>
        /// 移除资源使用者或共享资源
        ///
        /// 将指定的资源使用者或共享资源从指定的资源共享实例中移除。资源使用者也可以从指定的资源共享实例中主动退出。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisassociateResourceShareResponse DisassociateResourceShare(DisassociateResourceShareRequest disassociateResourceShareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disassociateResourceShareRequest.ResourceShareId, out var valueOfResourceShareId)) urlParam.Add("resource_share_id", valueOfResourceShareId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/{resource_share_id}/disassociate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateResourceShareRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DisassociateResourceShareResponse>(response);
        }

        public SyncInvoker<DisassociateResourceShareResponse> DisassociateResourceShareInvoker(DisassociateResourceShareRequest disassociateResourceShareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disassociateResourceShareRequest.ResourceShareId, out var valueOfResourceShareId)) urlParam.Add("resource_share_id", valueOfResourceShareId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/{resource_share_id}/disassociate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateResourceShareRequest);
            return new SyncInvoker<DisassociateResourceShareResponse>(this, "POST", request, JsonUtils.DeSerialize<DisassociateResourceShareResponse>);
        }
        
        /// <summary>
        /// 检索绑定的资源使用者和共享资源
        ///
        /// 检索您拥有的资源共享实例中绑定的共享资源和资源使用者。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchResourceShareAssociationsResponse SearchResourceShareAssociations(SearchResourceShareAssociationsRequest searchResourceShareAssociationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-share-associations/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchResourceShareAssociationsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SearchResourceShareAssociationsResponse>(response);
        }

        public SyncInvoker<SearchResourceShareAssociationsResponse> SearchResourceShareAssociationsInvoker(SearchResourceShareAssociationsRequest searchResourceShareAssociationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-share-associations/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchResourceShareAssociationsRequest);
            return new SyncInvoker<SearchResourceShareAssociationsResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchResourceShareAssociationsResponse>);
        }
        
        /// <summary>
        /// 接受共享邀请
        ///
        /// 接受来自其他账号的资源共享邀请。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AcceptResourceShareInvitationResponse AcceptResourceShareInvitation(AcceptResourceShareInvitationRequest acceptResourceShareInvitationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(acceptResourceShareInvitationRequest.ResourceShareInvitationId, out var valueOfResourceShareInvitationId)) urlParam.Add("resource_share_invitation_id", valueOfResourceShareInvitationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-share-invitations/{resource_share_invitation_id}/accept", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", acceptResourceShareInvitationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AcceptResourceShareInvitationResponse>(response);
        }

        public SyncInvoker<AcceptResourceShareInvitationResponse> AcceptResourceShareInvitationInvoker(AcceptResourceShareInvitationRequest acceptResourceShareInvitationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(acceptResourceShareInvitationRequest.ResourceShareInvitationId, out var valueOfResourceShareInvitationId)) urlParam.Add("resource_share_invitation_id", valueOfResourceShareInvitationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-share-invitations/{resource_share_invitation_id}/accept", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", acceptResourceShareInvitationRequest);
            return new SyncInvoker<AcceptResourceShareInvitationResponse>(this, "POST", request, JsonUtils.DeSerialize<AcceptResourceShareInvitationResponse>);
        }
        
        /// <summary>
        /// 拒绝共享邀请
        ///
        /// 拒绝来自其他账号的资源共享邀请。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RejectResourceShareInvitationResponse RejectResourceShareInvitation(RejectResourceShareInvitationRequest rejectResourceShareInvitationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rejectResourceShareInvitationRequest.ResourceShareInvitationId, out var valueOfResourceShareInvitationId)) urlParam.Add("resource_share_invitation_id", valueOfResourceShareInvitationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-share-invitations/{resource_share_invitation_id}/reject", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rejectResourceShareInvitationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RejectResourceShareInvitationResponse>(response);
        }

        public SyncInvoker<RejectResourceShareInvitationResponse> RejectResourceShareInvitationInvoker(RejectResourceShareInvitationRequest rejectResourceShareInvitationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rejectResourceShareInvitationRequest.ResourceShareInvitationId, out var valueOfResourceShareInvitationId)) urlParam.Add("resource_share_invitation_id", valueOfResourceShareInvitationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-share-invitations/{resource_share_invitation_id}/reject", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rejectResourceShareInvitationRequest);
            return new SyncInvoker<RejectResourceShareInvitationResponse>(this, "POST", request, JsonUtils.DeSerialize<RejectResourceShareInvitationResponse>);
        }
        
        /// <summary>
        /// 检索共享邀请
        ///
        /// 通过条件检索资源共享邀请。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchResourceShareInvitationResponse SearchResourceShareInvitation(SearchResourceShareInvitationRequest searchResourceShareInvitationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-share-invitations/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchResourceShareInvitationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SearchResourceShareInvitationResponse>(response);
        }

        public SyncInvoker<SearchResourceShareInvitationResponse> SearchResourceShareInvitationInvoker(SearchResourceShareInvitationRequest searchResourceShareInvitationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-share-invitations/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchResourceShareInvitationRequest);
            return new SyncInvoker<SearchResourceShareInvitationResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchResourceShareInvitationResponse>);
        }
        
        /// <summary>
        /// 资源共享实例增加标签
        ///
        /// 资源共享实例增加标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateResourceShareTagsResponse BatchCreateResourceShareTags(BatchCreateResourceShareTagsRequest batchCreateResourceShareTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateResourceShareTagsRequest.ResourceShareId, out var valueOfResourceShareId)) urlParam.Add("resource_share_id", valueOfResourceShareId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/{resource_share_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateResourceShareTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateResourceShareTagsResponse>(response);
        }

        public SyncInvoker<BatchCreateResourceShareTagsResponse> BatchCreateResourceShareTagsInvoker(BatchCreateResourceShareTagsRequest batchCreateResourceShareTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateResourceShareTagsRequest.ResourceShareId, out var valueOfResourceShareId)) urlParam.Add("resource_share_id", valueOfResourceShareId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/{resource_share_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateResourceShareTagsRequest);
            return new SyncInvoker<BatchCreateResourceShareTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateResourceShareTagsResponse>);
        }
        
        /// <summary>
        /// 删除资源共享实例的标签
        ///
        /// 删除资源共享实例指定的标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteResourceShareTagsResponse BatchDeleteResourceShareTags(BatchDeleteResourceShareTagsRequest batchDeleteResourceShareTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteResourceShareTagsRequest.ResourceShareId, out var valueOfResourceShareId)) urlParam.Add("resource_share_id", valueOfResourceShareId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/{resource_share_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteResourceShareTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteResourceShareTagsResponse>(response);
        }

        public SyncInvoker<BatchDeleteResourceShareTagsResponse> BatchDeleteResourceShareTagsInvoker(BatchDeleteResourceShareTagsRequest batchDeleteResourceShareTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteResourceShareTagsRequest.ResourceShareId, out var valueOfResourceShareId)) urlParam.Add("resource_share_id", valueOfResourceShareId);
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/{resource_share_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteResourceShareTagsRequest);
            return new SyncInvoker<BatchDeleteResourceShareTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteResourceShareTagsResponse>);
        }
        
        /// <summary>
        /// 查询已使用的标签列表
        ///
        /// 查询资源共享实例已使用标签的列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListResourceShareTagsResponse ListResourceShareTags(ListResourceShareTagsRequest listResourceShareTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceShareTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListResourceShareTagsResponse>(response);
        }

        public SyncInvoker<ListResourceShareTagsResponse> ListResourceShareTagsInvoker(ListResourceShareTagsRequest listResourceShareTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceShareTagsRequest);
            return new SyncInvoker<ListResourceShareTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListResourceShareTagsResponse>);
        }
        
        /// <summary>
        /// 根据标签信息查询实例列表
        ///
        /// 根据标签信息查询资源共享实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListResourceSharesByTagsResponse ListResourceSharesByTags(ListResourceSharesByTagsRequest listResourceSharesByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceSharesByTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListResourceSharesByTagsResponse>(response);
        }

        public SyncInvoker<ListResourceSharesByTagsResponse> ListResourceSharesByTagsInvoker(ListResourceSharesByTagsRequest listResourceSharesByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceSharesByTagsRequest);
            return new SyncInvoker<ListResourceSharesByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListResourceSharesByTagsResponse>);
        }
        
        /// <summary>
        /// 根据标签信息查询实例数量
        ///
        /// 根据标签信息查询资源共享实例数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchResourceShareCountByTagsResponse SearchResourceShareCountByTags(SearchResourceShareCountByTagsRequest searchResourceShareCountByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchResourceShareCountByTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SearchResourceShareCountByTagsResponse>(response);
        }

        public SyncInvoker<SearchResourceShareCountByTagsResponse> SearchResourceShareCountByTagsInvoker(SearchResourceShareCountByTagsRequest searchResourceShareCountByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchResourceShareCountByTagsRequest);
            return new SyncInvoker<SearchResourceShareCountByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchResourceShareCountByTagsResponse>);
        }
        
    }
}