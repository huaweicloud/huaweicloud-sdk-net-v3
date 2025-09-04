using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Ram.V1.Model;

namespace HuaweiCloud.SDK.Ram.V1
{
    public partial class RamAsyncClient : Client
    {
        public static ClientBuilder<RamAsyncClient> NewBuilder()
        {
            return new ClientBuilder<RamAsyncClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 绑定或替换共享资源权限
        ///
        /// 为资源共享实例中包含的资源类型绑定或替换共享资源权限。 对于资源共享实例中的每一种资源类型，您可以设置唯一权限。仅当资源共享实例中当前没有该资源类型的资源时，您才能绑定新的共享资源权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociateResourceSharePermissionResponse> AssociateResourceSharePermissionAsync(AssociateResourceSharePermissionRequest associateResourceSharePermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_share_id", associateResourceSharePermissionRequest.ResourceShareId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/{resource_share_id}/associate-permission", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateResourceSharePermissionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<AssociateResourceSharePermissionResponse>(response);
        }

        public AsyncInvoker<AssociateResourceSharePermissionResponse> AssociateResourceSharePermissionAsyncInvoker(AssociateResourceSharePermissionRequest associateResourceSharePermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_share_id", associateResourceSharePermissionRequest.ResourceShareId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/{resource_share_id}/associate-permission", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateResourceSharePermissionRequest);
            return new AsyncInvoker<AssociateResourceSharePermissionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AssociateResourceSharePermissionResponse>);
        }
        
        /// <summary>
        /// 移除共享资源权限
        ///
        /// 移除资源共享实例绑定的共享资源权限。权限更改立即生效。只有当目前资源共享实例中没有绑定相关资源类型时，您才能从资源共享实例中移除共享资源权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisassociateResourceSharePermissionResponse> DisassociateResourceSharePermissionAsync(DisassociateResourceSharePermissionRequest disassociateResourceSharePermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_share_id", disassociateResourceSharePermissionRequest.ResourceShareId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/{resource_share_id}/disassociate-permission", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateResourceSharePermissionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DisassociateResourceSharePermissionResponse>(response);
        }

        public AsyncInvoker<DisassociateResourceSharePermissionResponse> DisassociateResourceSharePermissionAsyncInvoker(DisassociateResourceSharePermissionRequest disassociateResourceSharePermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_share_id", disassociateResourceSharePermissionRequest.ResourceShareId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/{resource_share_id}/disassociate-permission", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateResourceSharePermissionRequest);
            return new AsyncInvoker<DisassociateResourceSharePermissionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DisassociateResourceSharePermissionResponse>);
        }
        
        /// <summary>
        /// 检索绑定的共享资源权限
        ///
        /// 检索资源共享实例关联的共享资源权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListResourceSharePermissionsResponse> ListResourceSharePermissionsAsync(ListResourceSharePermissionsRequest listResourceSharePermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_share_id", listResourceSharePermissionsRequest.ResourceShareId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/{resource_share_id}/associated-permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceSharePermissionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListResourceSharePermissionsResponse>(response);
        }

        public AsyncInvoker<ListResourceSharePermissionsResponse> ListResourceSharePermissionsAsyncInvoker(ListResourceSharePermissionsRequest listResourceSharePermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_share_id", listResourceSharePermissionsRequest.ResourceShareId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/{resource_share_id}/associated-permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceSharePermissionsRequest);
            return new AsyncInvoker<ListResourceSharePermissionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListResourceSharePermissionsResponse>);
        }
        
        /// <summary>
        /// 查询资源共享的配额
        ///
        /// 查询当前账号的资源共享配额信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListQuotaResponse> ListQuotaAsync(ListQuotaRequest listQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotaRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListQuotaResponse>(response);
        }

        public AsyncInvoker<ListQuotaResponse> ListQuotaAsyncInvoker(ListQuotaRequest listQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotaRequest);
            return new AsyncInvoker<ListQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ListQuotaResponse>);
        }
        
        /// <summary>
        /// 检索云服务资源类型
        ///
        /// 查询已对接云服务的资源类型和区域等信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListResourceTypesResponse> ListResourceTypesAsync(ListResourceTypesRequest listResourceTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-types", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceTypesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListResourceTypesResponse>(response);
        }

        public AsyncInvoker<ListResourceTypesResponse> ListResourceTypesAsyncInvoker(ListResourceTypesRequest listResourceTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-types", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceTypesRequest);
            return new AsyncInvoker<ListResourceTypesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListResourceTypesResponse>);
        }
        
        /// <summary>
        /// 关闭与组织共享
        ///
        /// 关闭与组织共享资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisableOrganizationShareResponse> DisableOrganizationShareAsync(DisableOrganizationShareRequest disableOrganizationShareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organization-share/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableOrganizationShareRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DisableOrganizationShareResponse>(response);
        }

        public AsyncInvoker<DisableOrganizationShareResponse> DisableOrganizationShareAsyncInvoker(DisableOrganizationShareRequest disableOrganizationShareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organization-share/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableOrganizationShareRequest);
            return new AsyncInvoker<DisableOrganizationShareResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DisableOrganizationShareResponse>);
        }
        
        /// <summary>
        /// 启用与组织共享
        ///
        /// 启用与组织共享资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EnableOrganizationShareResponse> EnableOrganizationShareAsync(EnableOrganizationShareRequest enableOrganizationShareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organization-share/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableOrganizationShareRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<EnableOrganizationShareResponse>(response);
        }

        public AsyncInvoker<EnableOrganizationShareResponse> EnableOrganizationShareAsyncInvoker(EnableOrganizationShareRequest enableOrganizationShareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organization-share/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableOrganizationShareRequest);
            return new AsyncInvoker<EnableOrganizationShareResponse>(this, "POST", request, JsonUtils.DeSerializeNull<EnableOrganizationShareResponse>);
        }
        
        /// <summary>
        /// 检索是否启用与组织共享
        ///
        /// 检索是否启用与组织共享资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowOrganizationShareResponse> ShowOrganizationShareAsync(ShowOrganizationShareRequest showOrganizationShareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organization-share", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrganizationShareRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowOrganizationShareResponse>(response);
        }

        public AsyncInvoker<ShowOrganizationShareResponse> ShowOrganizationShareAsyncInvoker(ShowOrganizationShareRequest showOrganizationShareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/organization-share", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOrganizationShareRequest);
            return new AsyncInvoker<ShowOrganizationShareResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOrganizationShareResponse>);
        }
        
        /// <summary>
        /// 获取权限的所有版本
        ///
        /// 获取权限的所有版本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPermissionVersionsResponse> ListPermissionVersionsAsync(ListPermissionVersionsRequest listPermissionVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("permission_id", listPermissionVersionsRequest.PermissionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/permissions/{permission_id}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermissionVersionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPermissionVersionsResponse>(response);
        }

        public AsyncInvoker<ListPermissionVersionsResponse> ListPermissionVersionsAsyncInvoker(ListPermissionVersionsRequest listPermissionVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("permission_id", listPermissionVersionsRequest.PermissionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/permissions/{permission_id}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermissionVersionsRequest);
            return new AsyncInvoker<ListPermissionVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPermissionVersionsResponse>);
        }
        
        /// <summary>
        /// 检索共享资源权限列表
        ///
        /// 检索指定资源类型的共享资源权限列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPermissionsResponse> ListPermissionsAsync(ListPermissionsRequest listPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermissionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPermissionsResponse>(response);
        }

        public AsyncInvoker<ListPermissionsResponse> ListPermissionsAsyncInvoker(ListPermissionsRequest listPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPermissionsRequest);
            return new AsyncInvoker<ListPermissionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPermissionsResponse>);
        }
        
        /// <summary>
        /// 检索资源共享权限内容
        ///
        /// 检索指定资源类型的共享资源指定版本的权限内容，如果不指定权限版本，则返回默认版本的权限内容。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPermissionResponse> ShowPermissionAsync(ShowPermissionRequest showPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("permission_id", showPermissionRequest.PermissionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/permissions/{permission_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPermissionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPermissionResponse>(response);
        }

        public AsyncInvoker<ShowPermissionResponse> ShowPermissionAsyncInvoker(ShowPermissionRequest showPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("permission_id", showPermissionRequest.PermissionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/permissions/{permission_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPermissionRequest);
            return new AsyncInvoker<ShowPermissionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPermissionResponse>);
        }
        
        /// <summary>
        /// 检索不同的资源使用者或者资源所有者
        ///
        /// 检索您正在共享资源的不同使用者或共享给您的不同资源所有者。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchDistinctPrincipalsResponse> SearchDistinctPrincipalsAsync(SearchDistinctPrincipalsRequest searchDistinctPrincipalsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/shared-principals/search-distinct-principal", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchDistinctPrincipalsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SearchDistinctPrincipalsResponse>(response);
        }

        public AsyncInvoker<SearchDistinctPrincipalsResponse> SearchDistinctPrincipalsAsyncInvoker(SearchDistinctPrincipalsRequest searchDistinctPrincipalsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/shared-principals/search-distinct-principal", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchDistinctPrincipalsRequest);
            return new AsyncInvoker<SearchDistinctPrincipalsResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchDistinctPrincipalsResponse>);
        }
        
        /// <summary>
        /// 检索资源使用者或者资源所有者
        ///
        /// 检索共享资源的使用者或者共享给您的资源所有者。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchSharedPrincipalsResponse> SearchSharedPrincipalsAsync(SearchSharedPrincipalsRequest searchSharedPrincipalsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/shared-principals/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchSharedPrincipalsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SearchSharedPrincipalsResponse>(response);
        }

        public AsyncInvoker<SearchSharedPrincipalsResponse> SearchSharedPrincipalsAsyncInvoker(SearchSharedPrincipalsRequest searchSharedPrincipalsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/shared-principals/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchSharedPrincipalsRequest);
            return new AsyncInvoker<SearchSharedPrincipalsResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchSharedPrincipalsResponse>);
        }
        
        /// <summary>
        /// 检索共享的不同资源
        ///
        /// 检索您添加到资源共享或被共享给您的不同资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchDistinctSharedResourcesResponse> SearchDistinctSharedResourcesAsync(SearchDistinctSharedResourcesRequest searchDistinctSharedResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/shared-resources/search-distinct-resource", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchDistinctSharedResourcesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SearchDistinctSharedResourcesResponse>(response);
        }

        public AsyncInvoker<SearchDistinctSharedResourcesResponse> SearchDistinctSharedResourcesAsyncInvoker(SearchDistinctSharedResourcesRequest searchDistinctSharedResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/shared-resources/search-distinct-resource", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchDistinctSharedResourcesRequest);
            return new AsyncInvoker<SearchDistinctSharedResourcesResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchDistinctSharedResourcesResponse>);
        }
        
        /// <summary>
        /// 检索共享的资源
        ///
        /// 检索您共享的或共享给您的资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchSharedResourcesResponse> SearchSharedResourcesAsync(SearchSharedResourcesRequest searchSharedResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/shared-resources/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchSharedResourcesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SearchSharedResourcesResponse>(response);
        }

        public AsyncInvoker<SearchSharedResourcesResponse> SearchSharedResourcesAsyncInvoker(SearchSharedResourcesRequest searchSharedResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/shared-resources/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchSharedResourcesRequest);
            return new AsyncInvoker<SearchSharedResourcesResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchSharedResourcesResponse>);
        }
        
        /// <summary>
        /// 创建资源共享实例
        ///
        /// 创建一个资源共享实例。您可以指定需要共享的资源列表，资源使用者列表，以及授予资源使用者的权限列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateResourceShareResponse> CreateResourceShareAsync(CreateResourceShareRequest createResourceShareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createResourceShareRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateResourceShareResponse>(response);
        }

        public AsyncInvoker<CreateResourceShareResponse> CreateResourceShareAsyncInvoker(CreateResourceShareRequest createResourceShareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createResourceShareRequest);
            return new AsyncInvoker<CreateResourceShareResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateResourceShareResponse>);
        }
        
        /// <summary>
        /// 删除资源共享实例
        ///
        /// 删除指定的资源共享实例。此操作不会删除实体资源，仅停止向其他账号共享资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteResourceShareResponse> DeleteResourceShareAsync(DeleteResourceShareRequest deleteResourceShareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_share_id", deleteResourceShareRequest.ResourceShareId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/{resource_share_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResourceShareRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteResourceShareResponse>(response);
        }

        public AsyncInvoker<DeleteResourceShareResponse> DeleteResourceShareAsyncInvoker(DeleteResourceShareRequest deleteResourceShareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_share_id", deleteResourceShareRequest.ResourceShareId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/{resource_share_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResourceShareRequest);
            return new AsyncInvoker<DeleteResourceShareResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteResourceShareResponse>);
        }
        
        /// <summary>
        /// 检索资源共享实例
        ///
        /// 检索您创建的或者共享给您的资源共享实例详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchResourceSharesResponse> SearchResourceSharesAsync(SearchResourceSharesRequest searchResourceSharesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchResourceSharesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SearchResourceSharesResponse>(response);
        }

        public AsyncInvoker<SearchResourceSharesResponse> SearchResourceSharesAsyncInvoker(SearchResourceSharesRequest searchResourceSharesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchResourceSharesRequest);
            return new AsyncInvoker<SearchResourceSharesResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchResourceSharesResponse>);
        }
        
        /// <summary>
        /// 更新资源共享实例
        ///
        /// 修改资源共享实例的特定属性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateResourceShareResponse> UpdateResourceShareAsync(UpdateResourceShareRequest updateResourceShareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_share_id", updateResourceShareRequest.ResourceShareId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/{resource_share_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResourceShareRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateResourceShareResponse>(response);
        }

        public AsyncInvoker<UpdateResourceShareResponse> UpdateResourceShareAsyncInvoker(UpdateResourceShareRequest updateResourceShareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_share_id", updateResourceShareRequest.ResourceShareId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/{resource_share_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResourceShareRequest);
            return new AsyncInvoker<UpdateResourceShareResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateResourceShareResponse>);
        }
        
        /// <summary>
        /// 绑定资源使用者和共享资源
        ///
        /// 向资源共享实例绑定指定的资源使用者列表或共享资源列表。对于新增的共享资源，有权访问此资源共享实例的资源使用者获得该共享资源的访问权限。对于新增的资源使用者，获得对此资源共享实例中共享资源的访问权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociateResourceShareResponse> AssociateResourceShareAsync(AssociateResourceShareRequest associateResourceShareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_share_id", associateResourceShareRequest.ResourceShareId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/{resource_share_id}/associate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateResourceShareRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AssociateResourceShareResponse>(response);
        }

        public AsyncInvoker<AssociateResourceShareResponse> AssociateResourceShareAsyncInvoker(AssociateResourceShareRequest associateResourceShareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_share_id", associateResourceShareRequest.ResourceShareId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/{resource_share_id}/associate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateResourceShareRequest);
            return new AsyncInvoker<AssociateResourceShareResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateResourceShareResponse>);
        }
        
        /// <summary>
        /// 移除资源使用者或共享资源
        ///
        /// 将指定的资源使用者或共享资源从指定的资源共享实例中移除。资源使用者也可以从指定的资源共享实例中主动退出。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisassociateResourceShareResponse> DisassociateResourceShareAsync(DisassociateResourceShareRequest disassociateResourceShareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_share_id", disassociateResourceShareRequest.ResourceShareId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/{resource_share_id}/disassociate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateResourceShareRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DisassociateResourceShareResponse>(response);
        }

        public AsyncInvoker<DisassociateResourceShareResponse> DisassociateResourceShareAsyncInvoker(DisassociateResourceShareRequest disassociateResourceShareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_share_id", disassociateResourceShareRequest.ResourceShareId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/{resource_share_id}/disassociate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateResourceShareRequest);
            return new AsyncInvoker<DisassociateResourceShareResponse>(this, "POST", request, JsonUtils.DeSerialize<DisassociateResourceShareResponse>);
        }
        
        /// <summary>
        /// 检索绑定的资源使用者和共享资源
        ///
        /// 检索您拥有的资源共享实例中绑定的共享资源和资源使用者。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchResourceShareAssociationsResponse> SearchResourceShareAssociationsAsync(SearchResourceShareAssociationsRequest searchResourceShareAssociationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-share-associations/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchResourceShareAssociationsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SearchResourceShareAssociationsResponse>(response);
        }

        public AsyncInvoker<SearchResourceShareAssociationsResponse> SearchResourceShareAssociationsAsyncInvoker(SearchResourceShareAssociationsRequest searchResourceShareAssociationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-share-associations/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchResourceShareAssociationsRequest);
            return new AsyncInvoker<SearchResourceShareAssociationsResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchResourceShareAssociationsResponse>);
        }
        
        /// <summary>
        /// 接受共享邀请
        ///
        /// 接受来自其他账号的资源共享邀请。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AcceptResourceShareInvitationResponse> AcceptResourceShareInvitationAsync(AcceptResourceShareInvitationRequest acceptResourceShareInvitationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_share_invitation_id", acceptResourceShareInvitationRequest.ResourceShareInvitationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-share-invitations/{resource_share_invitation_id}/accept", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", acceptResourceShareInvitationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AcceptResourceShareInvitationResponse>(response);
        }

        public AsyncInvoker<AcceptResourceShareInvitationResponse> AcceptResourceShareInvitationAsyncInvoker(AcceptResourceShareInvitationRequest acceptResourceShareInvitationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_share_invitation_id", acceptResourceShareInvitationRequest.ResourceShareInvitationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-share-invitations/{resource_share_invitation_id}/accept", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", acceptResourceShareInvitationRequest);
            return new AsyncInvoker<AcceptResourceShareInvitationResponse>(this, "POST", request, JsonUtils.DeSerialize<AcceptResourceShareInvitationResponse>);
        }
        
        /// <summary>
        /// 拒绝共享邀请
        ///
        /// 拒绝来自其他账号的资源共享邀请。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RejectResourceShareInvitationResponse> RejectResourceShareInvitationAsync(RejectResourceShareInvitationRequest rejectResourceShareInvitationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_share_invitation_id", rejectResourceShareInvitationRequest.ResourceShareInvitationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-share-invitations/{resource_share_invitation_id}/reject", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rejectResourceShareInvitationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RejectResourceShareInvitationResponse>(response);
        }

        public AsyncInvoker<RejectResourceShareInvitationResponse> RejectResourceShareInvitationAsyncInvoker(RejectResourceShareInvitationRequest rejectResourceShareInvitationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_share_invitation_id", rejectResourceShareInvitationRequest.ResourceShareInvitationId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-share-invitations/{resource_share_invitation_id}/reject", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rejectResourceShareInvitationRequest);
            return new AsyncInvoker<RejectResourceShareInvitationResponse>(this, "POST", request, JsonUtils.DeSerialize<RejectResourceShareInvitationResponse>);
        }
        
        /// <summary>
        /// 检索共享邀请
        ///
        /// 通过条件检索资源共享邀请。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchResourceShareInvitationResponse> SearchResourceShareInvitationAsync(SearchResourceShareInvitationRequest searchResourceShareInvitationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-share-invitations/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchResourceShareInvitationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SearchResourceShareInvitationResponse>(response);
        }

        public AsyncInvoker<SearchResourceShareInvitationResponse> SearchResourceShareInvitationAsyncInvoker(SearchResourceShareInvitationRequest searchResourceShareInvitationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-share-invitations/search", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchResourceShareInvitationRequest);
            return new AsyncInvoker<SearchResourceShareInvitationResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchResourceShareInvitationResponse>);
        }
        
        /// <summary>
        /// 资源共享实例增加标签
        ///
        /// 资源共享实例增加标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateResourceShareTagsResponse> BatchCreateResourceShareTagsAsync(BatchCreateResourceShareTagsRequest batchCreateResourceShareTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_share_id", batchCreateResourceShareTagsRequest.ResourceShareId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/{resource_share_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateResourceShareTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateResourceShareTagsResponse>(response);
        }

        public AsyncInvoker<BatchCreateResourceShareTagsResponse> BatchCreateResourceShareTagsAsyncInvoker(BatchCreateResourceShareTagsRequest batchCreateResourceShareTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_share_id", batchCreateResourceShareTagsRequest.ResourceShareId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/{resource_share_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateResourceShareTagsRequest);
            return new AsyncInvoker<BatchCreateResourceShareTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateResourceShareTagsResponse>);
        }
        
        /// <summary>
        /// 删除资源共享实例的标签
        ///
        /// 删除资源共享实例指定的标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteResourceShareTagsResponse> BatchDeleteResourceShareTagsAsync(BatchDeleteResourceShareTagsRequest batchDeleteResourceShareTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_share_id", batchDeleteResourceShareTagsRequest.ResourceShareId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/{resource_share_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteResourceShareTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteResourceShareTagsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteResourceShareTagsResponse> BatchDeleteResourceShareTagsAsyncInvoker(BatchDeleteResourceShareTagsRequest batchDeleteResourceShareTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_share_id", batchDeleteResourceShareTagsRequest.ResourceShareId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/{resource_share_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteResourceShareTagsRequest);
            return new AsyncInvoker<BatchDeleteResourceShareTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteResourceShareTagsResponse>);
        }
        
        /// <summary>
        /// 查询已使用的标签列表
        ///
        /// 查询资源共享实例已使用标签的列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListResourceShareTagsResponse> ListResourceShareTagsAsync(ListResourceShareTagsRequest listResourceShareTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceShareTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListResourceShareTagsResponse>(response);
        }

        public AsyncInvoker<ListResourceShareTagsResponse> ListResourceShareTagsAsyncInvoker(ListResourceShareTagsRequest listResourceShareTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceShareTagsRequest);
            return new AsyncInvoker<ListResourceShareTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListResourceShareTagsResponse>);
        }
        
        /// <summary>
        /// 根据标签信息查询实例列表
        ///
        /// 根据标签信息查询资源共享实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListResourceSharesByTagsResponse> ListResourceSharesByTagsAsync(ListResourceSharesByTagsRequest listResourceSharesByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceSharesByTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListResourceSharesByTagsResponse>(response);
        }

        public AsyncInvoker<ListResourceSharesByTagsResponse> ListResourceSharesByTagsAsyncInvoker(ListResourceSharesByTagsRequest listResourceSharesByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceSharesByTagsRequest);
            return new AsyncInvoker<ListResourceSharesByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListResourceSharesByTagsResponse>);
        }
        
        /// <summary>
        /// 根据标签信息查询实例数量
        ///
        /// 根据标签信息查询资源共享实例数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchResourceShareCountByTagsResponse> SearchResourceShareCountByTagsAsync(SearchResourceShareCountByTagsRequest searchResourceShareCountByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchResourceShareCountByTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SearchResourceShareCountByTagsResponse>(response);
        }

        public AsyncInvoker<SearchResourceShareCountByTagsResponse> SearchResourceShareCountByTagsAsyncInvoker(SearchResourceShareCountByTagsRequest searchResourceShareCountByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/resource-shares/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchResourceShareCountByTagsRequest);
            return new AsyncInvoker<SearchResourceShareCountByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchResourceShareCountByTagsResponse>);
        }
        
    }
}