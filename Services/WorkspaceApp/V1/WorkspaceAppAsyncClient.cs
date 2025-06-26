using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.WorkspaceApp.V1.Model;

namespace HuaweiCloud.SDK.WorkspaceApp.V1
{
    public partial class WorkspaceAppAsyncClient : Client
    {
        public static ClientBuilder<WorkspaceAppAsyncClient> NewBuilder()
        {
            return new ClientBuilder<WorkspaceAppAsyncClient>();
        }

        
        /// <summary>
        /// 获取上传至OBS桶的临时ak/sk
        ///
        /// 获取上传至OBS桶的临时ak/sk。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AuthorizeObsResponse> AuthorizeObsAsync(AuthorizeObsRequest authorizeObsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-warehouse/action/authorize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", authorizeObsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AuthorizeObsResponse>(response);
        }

        public AsyncInvoker<AuthorizeObsResponse> AuthorizeObsAsyncInvoker(AuthorizeObsRequest authorizeObsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-warehouse/action/authorize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", authorizeObsRequest);
            return new AsyncInvoker<AuthorizeObsResponse>(this, "POST", request, JsonUtils.DeSerialize<AuthorizeObsResponse>);
        }
        
        /// <summary>
        /// 批量删除应用仓库中的指定应用
        ///
        /// 批量删除应用仓库中的指定应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteWarehouseAppResponse> BatchDeleteWarehouseAppAsync(BatchDeleteWarehouseAppRequest batchDeleteWarehouseAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-warehouse/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteWarehouseAppRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteWarehouseAppResponse>(response);
        }

        public AsyncInvoker<BatchDeleteWarehouseAppResponse> BatchDeleteWarehouseAppAsyncInvoker(BatchDeleteWarehouseAppRequest batchDeleteWarehouseAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-warehouse/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteWarehouseAppRequest);
            return new AsyncInvoker<BatchDeleteWarehouseAppResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteWarehouseAppResponse>);
        }
        
        /// <summary>
        /// 添加桶或者桶授权
        ///
        /// 添加桶或者桶授权。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateBucketOrAclResponse> CreateBucketOrAclAsync(CreateBucketOrAclRequest createBucketOrAclRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-warehouse/bucket-and-acl/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBucketOrAclRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateBucketOrAclResponse>(response);
        }

        public AsyncInvoker<CreateBucketOrAclResponse> CreateBucketOrAclAsyncInvoker(CreateBucketOrAclRequest createBucketOrAclRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-warehouse/bucket-and-acl/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBucketOrAclRequest);
            return new AsyncInvoker<CreateBucketOrAclResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateBucketOrAclResponse>);
        }
        
        /// <summary>
        /// 在应用仓库中新增应用
        ///
        /// 在应用仓库中新增应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateWarehouseAppResponse> CreateWarehouseAppAsync(CreateWarehouseAppRequest createWarehouseAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-warehouse/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWarehouseAppRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateWarehouseAppResponse>(response);
        }

        public AsyncInvoker<CreateWarehouseAppResponse> CreateWarehouseAppAsyncInvoker(CreateWarehouseAppRequest createWarehouseAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-warehouse/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWarehouseAppRequest);
            return new AsyncInvoker<CreateWarehouseAppResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateWarehouseAppResponse>);
        }
        
        /// <summary>
        /// 删除应用仓库中的指定应用
        ///
        /// 删除应用仓库中的指定应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteWarehouseAppResponse> DeleteWarehouseAppAsync(DeleteWarehouseAppRequest deleteWarehouseAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteWarehouseAppRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-warehouse/apps/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWarehouseAppRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteWarehouseAppResponse>(response);
        }

        public AsyncInvoker<DeleteWarehouseAppResponse> DeleteWarehouseAppAsyncInvoker(DeleteWarehouseAppRequest deleteWarehouseAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteWarehouseAppRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-warehouse/apps/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWarehouseAppRequest);
            return new AsyncInvoker<DeleteWarehouseAppResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteWarehouseAppResponse>);
        }
        
        /// <summary>
        /// 查询租户应用仓库中的应用列表
        ///
        /// 查询租户应用仓库中的应用列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListWarehouseAppsResponse> ListWarehouseAppsAsync(ListWarehouseAppsRequest listWarehouseAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-warehouse/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWarehouseAppsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListWarehouseAppsResponse>(response);
        }

        public AsyncInvoker<ListWarehouseAppsResponse> ListWarehouseAppsAsyncInvoker(ListWarehouseAppsRequest listWarehouseAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-warehouse/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWarehouseAppsRequest);
            return new AsyncInvoker<ListWarehouseAppsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWarehouseAppsResponse>);
        }
        
        /// <summary>
        /// 修改应用仓库中的指定应用信息
        ///
        /// 修改应用仓库中的指定应用信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateWarehouseAppResponse> UpdateWarehouseAppAsync(UpdateWarehouseAppRequest updateWarehouseAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateWarehouseAppRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-warehouse/apps/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWarehouseAppRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerializeNull<UpdateWarehouseAppResponse>(response);
        }

        public AsyncInvoker<UpdateWarehouseAppResponse> UpdateWarehouseAppAsyncInvoker(UpdateWarehouseAppRequest updateWarehouseAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateWarehouseAppRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-warehouse/apps/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWarehouseAppRequest);
            return new AsyncInvoker<UpdateWarehouseAppResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<UpdateWarehouseAppResponse>);
        }
        
        /// <summary>
        /// 在应用仓库中上传图标文件
        ///
        /// 在应用仓库中上传图标文件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UploadWarehouseAppIconResponse> UploadWarehouseAppIconAsync(UploadWarehouseAppIconRequest uploadWarehouseAppIconRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-warehouse/apps/icon", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadWarehouseAppIconRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UploadWarehouseAppIconResponse>(response);
        }

        public AsyncInvoker<UploadWarehouseAppIconResponse> UploadWarehouseAppIconAsyncInvoker(UploadWarehouseAppIconRequest uploadWarehouseAppIconRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-warehouse/apps/icon", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadWarehouseAppIconRequest);
            return new AsyncInvoker<UploadWarehouseAppIconResponse>(this, "POST", request, JsonUtils.DeSerialize<UploadWarehouseAppIconResponse>);
        }
        
        /// <summary>
        /// 批量禁用应用
        ///
        /// 批量禁用应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDisableAppResponse> BatchDisableAppAsync(BatchDisableAppRequest batchDisableAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_group_id", batchDisableAppRequest.AppGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps/actions/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDisableAppRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDisableAppResponse>(response);
        }

        public AsyncInvoker<BatchDisableAppResponse> BatchDisableAppAsyncInvoker(BatchDisableAppRequest batchDisableAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_group_id", batchDisableAppRequest.AppGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps/actions/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDisableAppRequest);
            return new AsyncInvoker<BatchDisableAppResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDisableAppResponse>);
        }
        
        /// <summary>
        /// 批量启用应用
        ///
        /// 批量启用应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchEnableAppResponse> BatchEnableAppAsync(BatchEnableAppRequest batchEnableAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_group_id", batchEnableAppRequest.AppGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps/actions/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchEnableAppRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchEnableAppResponse>(response);
        }

        public AsyncInvoker<BatchEnableAppResponse> BatchEnableAppAsyncInvoker(BatchEnableAppRequest batchEnableAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_group_id", batchEnableAppRequest.AppGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps/actions/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchEnableAppRequest);
            return new AsyncInvoker<BatchEnableAppResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchEnableAppResponse>);
        }
        
        /// <summary>
        /// 删除自定义应用图标
        ///
        /// 删除自定义应用应用图标，恢复使用默认应用图标，重复执行会按照成功处理(响应200)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAppIconResponse> DeleteAppIconAsync(DeleteAppIconRequest deleteAppIconRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_group_id", deleteAppIconRequest.AppGroupId.ToString());
            urlParam.Add("app_id", deleteAppIconRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps/{app_id}/icon", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppIconRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAppIconResponse>(response);
        }

        public AsyncInvoker<DeleteAppIconResponse> DeleteAppIconAsyncInvoker(DeleteAppIconRequest deleteAppIconRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_group_id", deleteAppIconRequest.AppGroupId.ToString());
            urlParam.Add("app_id", deleteAppIconRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps/{app_id}/icon", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppIconRequest);
            return new AsyncInvoker<DeleteAppIconResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAppIconResponse>);
        }
        
        /// <summary>
        /// 查询已发布应用
        ///
        /// 查询已发布的应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPublishedAppResponse> ListPublishedAppAsync(ListPublishedAppRequest listPublishedAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_group_id", listPublishedAppRequest.AppGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublishedAppRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPublishedAppResponse>(response);
        }

        public AsyncInvoker<ListPublishedAppResponse> ListPublishedAppAsyncInvoker(ListPublishedAppRequest listPublishedAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_group_id", listPublishedAppRequest.AppGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublishedAppRequest);
            return new AsyncInvoker<ListPublishedAppResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPublishedAppResponse>);
        }
        
        /// <summary>
        /// 发布应用
        ///
        /// 批量发布应用，不允许发布同名的应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<PublishAppResponse> PublishAppAsync(PublishAppRequest publishAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_group_id", publishAppRequest.AppGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", publishAppRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<PublishAppResponse>(response);
        }

        public AsyncInvoker<PublishAppResponse> PublishAppAsyncInvoker(PublishAppRequest publishAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_group_id", publishAppRequest.AppGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", publishAppRequest);
            return new AsyncInvoker<PublishAppResponse>(this, "POST", request, JsonUtils.DeSerialize<PublishAppResponse>);
        }
        
        /// <summary>
        /// 查询应用详细信息
        ///
        /// 查询应用详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAppDetailResponse> ShowAppDetailAsync(ShowAppDetailRequest showAppDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_group_id", showAppDetailRequest.AppGroupId.ToString());
            urlParam.Add("app_id", showAppDetailRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAppDetailResponse>(response);
        }

        public AsyncInvoker<ShowAppDetailResponse> ShowAppDetailAsyncInvoker(ShowAppDetailRequest showAppDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_group_id", showAppDetailRequest.AppGroupId.ToString());
            urlParam.Add("app_id", showAppDetailRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppDetailRequest);
            return new AsyncInvoker<ShowAppDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAppDetailResponse>);
        }
        
        /// <summary>
        /// 可发布应用列表
        ///
        /// 查询应用组下可发布的应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPublishableAppResponse> ShowPublishableAppAsync(ShowPublishableAppRequest showPublishableAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_group_id", showPublishableAppRequest.AppGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/publishable-app", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublishableAppRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPublishableAppResponse>(response);
        }

        public AsyncInvoker<ShowPublishableAppResponse> ShowPublishableAppAsyncInvoker(ShowPublishableAppRequest showPublishableAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_group_id", showPublishableAppRequest.AppGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/publishable-app", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublishableAppRequest);
            return new AsyncInvoker<ShowPublishableAppResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPublishableAppResponse>);
        }
        
        /// <summary>
        /// 批量取消应用发布
        ///
        /// 批量取消应用发布。
        /// &gt; - 批量取消应用组下已经发布的应用，应用对应的授权会一起删除，重复执行会按照成功处理(响应200)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UnpublishAppResponse> UnpublishAppAsync(UnpublishAppRequest unpublishAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_group_id", unpublishAppRequest.AppGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps/batch-unpublish", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unpublishAppRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UnpublishAppResponse>(response);
        }

        public AsyncInvoker<UnpublishAppResponse> UnpublishAppAsyncInvoker(UnpublishAppRequest unpublishAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_group_id", unpublishAppRequest.AppGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps/batch-unpublish", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unpublishAppRequest);
            return new AsyncInvoker<UnpublishAppResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UnpublishAppResponse>);
        }
        
        /// <summary>
        /// 修改应用信息
        ///
        /// 编辑修改应用信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAppResponse> UpdateAppAsync(UpdateAppRequest updateAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_group_id", updateAppRequest.AppGroupId.ToString());
            urlParam.Add("app_id", updateAppRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<UpdateAppResponse>(response);
        }

        public AsyncInvoker<UpdateAppResponse> UpdateAppAsyncInvoker(UpdateAppRequest updateAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_group_id", updateAppRequest.AppGroupId.ToString());
            urlParam.Add("app_id", updateAppRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppRequest);
            return new AsyncInvoker<UpdateAppResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpdateAppResponse>);
        }
        
        /// <summary>
        /// 修改自定义应用图标
        ///
        /// 修改自定义应用图标。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UploadAppIconResponse> UploadAppIconAsync(UploadAppIconRequest uploadAppIconRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_group_id", uploadAppIconRequest.AppGroupId.ToString());
            urlParam.Add("app_id", uploadAppIconRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps/{app_id}/icon", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadAppIconRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UploadAppIconResponse>(response);
        }

        public AsyncInvoker<UploadAppIconResponse> UploadAppIconAsyncInvoker(UploadAppIconRequest uploadAppIconRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_group_id", uploadAppIconRequest.AppGroupId.ToString());
            urlParam.Add("app_id", uploadAppIconRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps/{app_id}/icon", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadAppIconRequest);
            return new AsyncInvoker<UploadAppIconResponse>(this, "POST", request, JsonUtils.DeSerialize<UploadAppIconResponse>);
        }
        
        /// <summary>
        /// 租户服务激活、初始化
        ///
        /// 租户服务激活。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<InitializeTenantResponse> InitializeTenantAsync(InitializeTenantRequest initializeTenantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/tenant/action/active", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", initializeTenantRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<InitializeTenantResponse>(response);
        }

        public AsyncInvoker<InitializeTenantResponse> InitializeTenantAsyncInvoker(InitializeTenantRequest initializeTenantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/tenant/action/active", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", initializeTenantRequest);
            return new AsyncInvoker<InitializeTenantResponse>(this, "POST", request, JsonUtils.DeSerialize<InitializeTenantResponse>);
        }
        
        /// <summary>
        /// 查询企业系统配置
        ///
        /// 配置加载顺序： 查询企业级配置- -&gt; 查不到则赋默认阿波罗配置- -&gt; 阿波罗没有则不返回。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCorpConfigInfoResponse> ListCorpConfigInfoAsync(ListCorpConfigInfoRequest listCorpConfigInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/bundles/batch-query-config-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCorpConfigInfoRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListCorpConfigInfoResponse>(response);
        }

        public AsyncInvoker<ListCorpConfigInfoResponse> ListCorpConfigInfoAsyncInvoker(ListCorpConfigInfoRequest listCorpConfigInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/bundles/batch-query-config-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCorpConfigInfoRequest);
            return new AsyncInvoker<ListCorpConfigInfoResponse>(this, "POST", request, JsonUtils.DeSerialize<ListCorpConfigInfoResponse>);
        }
        
        /// <summary>
        /// 查询租户信息
        ///
        /// 查询租户信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTenantProfileResponse> ListTenantProfileAsync(ListTenantProfileRequest listTenantProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/tenant/profile", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantProfileRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTenantProfileResponse>(response);
        }

        public AsyncInvoker<ListTenantProfileResponse> ListTenantProfileAsyncInvoker(ListTenantProfileRequest listTenantProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/tenant/profile", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantProfileRequest);
            return new AsyncInvoker<ListTenantProfileResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTenantProfileResponse>);
        }
        
        /// <summary>
        /// 批量删除应用组
        ///
        /// 批量删除应用组,重复执行会按照成功处理(响应200)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteAppGroupResponse> BatchDeleteAppGroupAsync(BatchDeleteAppGroupRequest batchDeleteAppGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAppGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteAppGroupResponse>(response);
        }

        public AsyncInvoker<BatchDeleteAppGroupResponse> BatchDeleteAppGroupAsyncInvoker(BatchDeleteAppGroupRequest batchDeleteAppGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAppGroupRequest);
            return new AsyncInvoker<BatchDeleteAppGroupResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteAppGroupResponse>);
        }
        
        /// <summary>
        /// 创建应用组
        ///
        /// 该API用于创建应用组。
        /// &gt; - 应用服务器中安装了不同的应用，这些应用可以组成不同的应用组，进行集中的管理和维护，向用户(组)发布。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAppGroupResponse> CreateAppGroupAsync(CreateAppGroupRequest createAppGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAppGroupResponse>(response);
        }

        public AsyncInvoker<CreateAppGroupResponse> CreateAppGroupAsyncInvoker(CreateAppGroupRequest createAppGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppGroupRequest);
            return new AsyncInvoker<CreateAppGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAppGroupResponse>);
        }
        
        /// <summary>
        /// 应用组删除
        ///
        /// 删除指定的应用组,重复执行会按照成功处理(响应200)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAppGroupResponse> DeleteAppGroupAsync(DeleteAppGroupRequest deleteAppGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_group_id", deleteAppGroupRequest.AppGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppGroupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAppGroupResponse>(response);
        }

        public AsyncInvoker<DeleteAppGroupResponse> DeleteAppGroupAsyncInvoker(DeleteAppGroupRequest deleteAppGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_group_id", deleteAppGroupRequest.AppGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppGroupRequest);
            return new AsyncInvoker<DeleteAppGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAppGroupResponse>);
        }
        
        /// <summary>
        /// 解除服务组关联的所有应用组
        ///
        /// 解除服务组关联的所有应用组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisassociateAppGroupResponse> DisassociateAppGroupAsync(DisassociateAppGroupRequest disassociateAppGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/actions/disassociate-app-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateAppGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DisassociateAppGroupResponse>(response);
        }

        public AsyncInvoker<DisassociateAppGroupResponse> DisassociateAppGroupAsyncInvoker(DisassociateAppGroupRequest disassociateAppGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/actions/disassociate-app-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateAppGroupRequest);
            return new AsyncInvoker<DisassociateAppGroupResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DisassociateAppGroupResponse>);
        }
        
        /// <summary>
        /// 查询应用组
        ///
        /// 查询用户创建的应用组，按照名称、授权类型分页查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAppGroupResponse> ListAppGroupAsync(ListAppGroupRequest listAppGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAppGroupResponse>(response);
        }

        public AsyncInvoker<ListAppGroupResponse> ListAppGroupAsyncInvoker(ListAppGroupRequest listAppGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppGroupRequest);
            return new AsyncInvoker<ListAppGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAppGroupResponse>);
        }
        
        /// <summary>
        /// 查询应用组详情
        ///
        /// 查询应用组详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAppGroupDetailResponse> ShowAppGroupDetailAsync(ShowAppGroupDetailRequest showAppGroupDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_group_id", showAppGroupDetailRequest.AppGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppGroupDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAppGroupDetailResponse>(response);
        }

        public AsyncInvoker<ShowAppGroupDetailResponse> ShowAppGroupDetailAsyncInvoker(ShowAppGroupDetailRequest showAppGroupDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_group_id", showAppGroupDetailRequest.AppGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppGroupDetailRequest);
            return new AsyncInvoker<ShowAppGroupDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAppGroupDetailResponse>);
        }
        
        /// <summary>
        /// 修改应用组
        ///
        /// 修改应用组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAppGroupResponse> UpdateAppGroupAsync(UpdateAppGroupRequest updateAppGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_group_id", updateAppGroupRequest.AppGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppGroupRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<UpdateAppGroupResponse>(response);
        }

        public AsyncInvoker<UpdateAppGroupResponse> UpdateAppGroupAsyncInvoker(UpdateAppGroupRequest updateAppGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_group_id", updateAppGroupRequest.AppGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppGroupRequest);
            return new AsyncInvoker<UpdateAppGroupResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpdateAppGroupResponse>);
        }
        
        /// <summary>
        /// 创建订单
        ///
        /// 创建订单。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateOrderResponse> CreateOrderAsync(CreateOrderRequest createOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/bundles/subscribe/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrderRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateOrderResponse>(response);
        }

        public AsyncInvoker<CreateOrderResponse> CreateOrderAsyncInvoker(CreateOrderRequest createOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/bundles/subscribe/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrderRequest);
            return new AsyncInvoker<CreateOrderResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateOrderResponse>);
        }
        
        /// <summary>
        /// 查询云应用套餐
        ///
        /// 查询云应用套餐，按照条件过滤。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProductResponse> ListProductAsync(ListProductRequest listProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/product", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProductRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListProductResponse>(response);
        }

        public AsyncInvoker<ListProductResponse> ListProductAsyncInvoker(ListProductRequest listProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/product", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProductRequest);
            return new AsyncInvoker<ListProductResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProductResponse>);
        }
        
        /// <summary>
        /// 查询会话套餐列表
        ///
        /// 该接口用于查询会话套餐列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSessionTypeResponse> ListSessionTypeAsync(ListSessionTypeRequest listSessionTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/session-type", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSessionTypeRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSessionTypeResponse>(response);
        }

        public AsyncInvoker<ListSessionTypeResponse> ListSessionTypeAsyncInvoker(ListSessionTypeRequest listSessionTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/session-type", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSessionTypeRequest);
            return new AsyncInvoker<ListSessionTypeResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSessionTypeResponse>);
        }
        
        /// <summary>
        /// 查询会话套餐列表
        ///
        /// 该接口用于查询会话套餐列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSessionTypesResponse> ShowSessionTypesAsync(ShowSessionTypesRequest showSessionTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/session-type", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSessionTypesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShowSessionTypesResponse>(response);
        }

        public AsyncInvoker<ShowSessionTypesResponse> ShowSessionTypesAsyncInvoker(ShowSessionTypesRequest showSessionTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/session-type", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSessionTypesRequest);
            return new AsyncInvoker<ShowSessionTypesResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowSessionTypesResponse>);
        }
        
        /// <summary>
        /// 增加应用组授权
        ///
        /// 应用组添加用户授权，授权后用户就获得应用组下所有已发布应用的权限访问。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddAppGroupAuthorizationResponse> AddAppGroupAuthorizationAsync(AddAppGroupAuthorizationRequest addAppGroupAuthorizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/authorizations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAppGroupAuthorizationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<AddAppGroupAuthorizationResponse>(response);
        }

        public AsyncInvoker<AddAppGroupAuthorizationResponse> AddAppGroupAuthorizationAsyncInvoker(AddAppGroupAuthorizationRequest addAppGroupAuthorizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/authorizations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAppGroupAuthorizationRequest);
            return new AsyncInvoker<AddAppGroupAuthorizationResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddAppGroupAuthorizationResponse>);
        }
        
        /// <summary>
        /// 移除应用组授权
        ///
        /// 移除应用组内的指定用户的授权，用户授权删除后，用户将没有权限访问应用组内的任何应用。注意：重复执行会按照操作成功处理。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteAppGroupAuthorizationResponse> BatchDeleteAppGroupAuthorizationAsync(BatchDeleteAppGroupAuthorizationRequest batchDeleteAppGroupAuthorizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/actions/batch-delete-authorization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAppGroupAuthorizationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteAppGroupAuthorizationResponse>(response);
        }

        public AsyncInvoker<BatchDeleteAppGroupAuthorizationResponse> BatchDeleteAppGroupAuthorizationAsyncInvoker(BatchDeleteAppGroupAuthorizationRequest batchDeleteAppGroupAuthorizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/actions/batch-delete-authorization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAppGroupAuthorizationRequest);
            return new AsyncInvoker<BatchDeleteAppGroupAuthorizationResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteAppGroupAuthorizationResponse>);
        }
        
        /// <summary>
        /// 查询应用组授权记录
        ///
        /// 查询应用内已授权的用户列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAppGroupAuthorizationResponse> ListAppGroupAuthorizationAsync(ListAppGroupAuthorizationRequest listAppGroupAuthorizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/actions/list-authorizations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppGroupAuthorizationRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAppGroupAuthorizationResponse>(response);
        }

        public AsyncInvoker<ListAppGroupAuthorizationResponse> ListAppGroupAuthorizationAsyncInvoker(ListAppGroupAuthorizationRequest listAppGroupAuthorizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/actions/list-authorizations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppGroupAuthorizationRequest);
            return new AsyncInvoker<ListAppGroupAuthorizationResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAppGroupAuthorizationResponse>);
        }
        
        /// <summary>
        /// 查询可用分区列表
        ///
        /// 该接口用于查询支持的可用分区列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAvailabilityZoneResponse> ListAvailabilityZoneAsync(ListAvailabilityZoneRequest listAvailabilityZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/availability-zone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailabilityZoneRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAvailabilityZoneResponse>(response);
        }

        public AsyncInvoker<ListAvailabilityZoneResponse> ListAvailabilityZoneAsyncInvoker(ListAvailabilityZoneRequest listAvailabilityZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/availability-zone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailabilityZoneRequest);
            return new AsyncInvoker<ListAvailabilityZoneResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAvailabilityZoneResponse>);
        }
        
        /// <summary>
        /// 查询可用分区列表
        ///
        /// 该接口用于查询支持的可用分区列表，按站点分类。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAzResponse> ListAzAsync(ListAzRequest listAzRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/availability-zone/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAzRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAzResponse>(response);
        }

        public AsyncInvoker<ListAzResponse> ListAzAsyncInvoker(ListAzRequest listAzRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/availability-zone/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAzRequest);
            return new AsyncInvoker<ListAzResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAzResponse>);
        }
        
        /// <summary>
        /// 分发软件信息至镜像实例
        ///
        /// 分发应用软件信息至镜像实例，管理员可以按需下载并安装应用软件。
        /// * 目前只支持来自云应用仓库的软件信息。
        /// * 只允许对状态为 &#x60;实例正常运行&#x60;、&#x60;镜像任务结束&#x60; 的实例分发软件信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AttachImageServerAppResponse> AttachImageServerAppAsync(AttachImageServerAppRequest attachImageServerAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", attachImageServerAppRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-servers/{server_id}/actions/attach-app", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachImageServerAppRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AttachImageServerAppResponse>(response);
        }

        public AsyncInvoker<AttachImageServerAppResponse> AttachImageServerAppAsyncInvoker(AttachImageServerAppRequest attachImageServerAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", attachImageServerAppRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-servers/{server_id}/actions/attach-app", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachImageServerAppRequest);
            return new AsyncInvoker<AttachImageServerAppResponse>(this, "POST", request, JsonUtils.DeSerialize<AttachImageServerAppResponse>);
        }
        
        /// <summary>
        /// 批量删除镜像实例
        ///
        /// 批量删除镜像实例。
        /// * 忽略不存在的镜像实例，响应正常。
        /// * 不允许操作状态为 &#x60;创建中&#x60;、&#x60;镜像创建中&#x60;的实例，响应异常。
        /// * 不支持资源关联发生变化后，请求删除镜像实例关联资源，任务响应异常。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteImageServerResponse> BatchDeleteImageServerAsync(BatchDeleteImageServerRequest batchDeleteImageServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-servers/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteImageServerRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<BatchDeleteImageServerResponse>(response);
        }

        public AsyncInvoker<BatchDeleteImageServerResponse> BatchDeleteImageServerAsyncInvoker(BatchDeleteImageServerRequest batchDeleteImageServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-servers/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteImageServerRequest);
            return new AsyncInvoker<BatchDeleteImageServerResponse>(this, "PATCH", request, JsonUtils.DeSerialize<BatchDeleteImageServerResponse>);
        }
        
        /// <summary>
        /// 创建镜像实例
        ///
        /// 创建镜像实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateImageServerResponse> CreateImageServerAsync(CreateImageServerRequest createImageServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createImageServerRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateImageServerResponse>(response);
        }

        public AsyncInvoker<CreateImageServerResponse> CreateImageServerAsyncInvoker(CreateImageServerRequest createImageServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createImageServerRequest);
            return new AsyncInvoker<CreateImageServerResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateImageServerResponse>);
        }
        
        /// <summary>
        /// 查询镜像实例列表
        ///
        /// 查询镜像实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListImageServersResponse> ListImageServersAsync(ListImageServersRequest listImageServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImageServersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListImageServersResponse>(response);
        }

        public AsyncInvoker<ListImageServersResponse> ListImageServersAsyncInvoker(ListImageServersRequest listImageServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImageServersRequest);
            return new AsyncInvoker<ListImageServersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListImageServersResponse>);
        }
        
        /// <summary>
        /// 查询最近一次分发软件信息列表
        ///
        /// 查询最近一次分发软件信息列表，返回ID列表，不包含具体信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLatestAttachedServerAppResponse> ListLatestAttachedServerAppAsync(ListLatestAttachedServerAppRequest listLatestAttachedServerAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", listLatestAttachedServerAppRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-servers/{server_id}/actions/latest-attached-app", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLatestAttachedServerAppRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListLatestAttachedServerAppResponse>(response);
        }

        public AsyncInvoker<ListLatestAttachedServerAppResponse> ListLatestAttachedServerAppAsyncInvoker(ListLatestAttachedServerAppRequest listLatestAttachedServerAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", listLatestAttachedServerAppRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-servers/{server_id}/actions/latest-attached-app", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLatestAttachedServerAppRequest);
            return new AsyncInvoker<ListLatestAttachedServerAppResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLatestAttachedServerAppResponse>);
        }
        
        /// <summary>
        /// 构建云应用镜像
        ///
        /// 构建云应用镜像。
        /// * 只允许对状态为 &#x60;实例正常运行&#x60;、&#x60;镜像任务结束&#x60; 的实例构建云应用镜像。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RecreateServerImageResponse> RecreateServerImageAsync(RecreateServerImageRequest recreateServerImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", recreateServerImageRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-servers/{server_id}/actions/recreate-image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", recreateServerImageRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RecreateServerImageResponse>(response);
        }

        public AsyncInvoker<RecreateServerImageResponse> RecreateServerImageAsyncInvoker(RecreateServerImageRequest recreateServerImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", recreateServerImageRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-servers/{server_id}/actions/recreate-image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", recreateServerImageRequest);
            return new AsyncInvoker<RecreateServerImageResponse>(this, "POST", request, JsonUtils.DeSerialize<RecreateServerImageResponse>);
        }
        
        /// <summary>
        /// 查询指定镜像实例
        ///
        /// 查询指定的镜像实例当前这个接口的查询数据和list查询的一致
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowImageServerResponse> ShowImageServerAsync(ShowImageServerRequest showImageServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", showImageServerRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-servers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showImageServerRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowImageServerResponse>(response);
        }

        public AsyncInvoker<ShowImageServerResponse> ShowImageServerAsyncInvoker(ShowImageServerRequest showImageServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", showImageServerRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-servers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showImageServerRequest);
            return new AsyncInvoker<ShowImageServerResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowImageServerResponse>);
        }
        
        /// <summary>
        /// 修改镜像实例
        ///
        /// 修改镜像实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateImageServerResponse> UpdateImageServerAsync(UpdateImageServerRequest updateImageServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", updateImageServerRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-servers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateImageServerRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerializeNull<UpdateImageServerResponse>(response);
        }

        public AsyncInvoker<UpdateImageServerResponse> UpdateImageServerAsyncInvoker(UpdateImageServerRequest updateImageServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", updateImageServerRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-servers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateImageServerRequest);
            return new AsyncInvoker<UpdateImageServerResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<UpdateImageServerResponse>);
        }
        
        /// <summary>
        /// 批量删除子任务
        ///
        /// 批量删除子任务，忽略不存在的服务器并且返回成功响应。
        /// 只能删除以下的两种状态：
        /// - SUCCESS：成功。
        /// - FAILED：失败。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteAppSubJobsResponse> BatchDeleteAppSubJobsAsync(BatchDeleteAppSubJobsRequest batchDeleteAppSubJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-sub-jobs/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAppSubJobsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteAppSubJobsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteAppSubJobsResponse> BatchDeleteAppSubJobsAsyncInvoker(BatchDeleteAppSubJobsRequest batchDeleteAppSubJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-sub-jobs/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAppSubJobsRequest);
            return new AsyncInvoker<BatchDeleteAppSubJobsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteAppSubJobsResponse>);
        }
        
        /// <summary>
        /// 批量删除镜像子任务
        ///
        /// 批量删除子任务，忽略不存在的服务器并且返回成功响应。
        /// 只能删除以下的两种状态 SUCCESS：成功。 FAILED：失败
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteImageSubJobsResponse> BatchDeleteImageSubJobsAsync(BatchDeleteImageSubJobsRequest batchDeleteImageSubJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-server-sub-jobs/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteImageSubJobsRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerializeNull<BatchDeleteImageSubJobsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteImageSubJobsResponse> BatchDeleteImageSubJobsAsyncInvoker(BatchDeleteImageSubJobsRequest batchDeleteImageSubJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-server-sub-jobs/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteImageSubJobsRequest);
            return new AsyncInvoker<BatchDeleteImageSubJobsResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<BatchDeleteImageSubJobsResponse>);
        }
        
        /// <summary>
        /// 子任务数量查询
        ///
        /// 该接口用于查询异步子任务数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CountSubJobsResponse> CountSubJobsAsync(CountSubJobsRequest countSubJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-sub-jobs/actions/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countSubJobsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<CountSubJobsResponse>(response);
        }

        public AsyncInvoker<CountSubJobsResponse> CountSubJobsAsyncInvoker(CountSubJobsRequest countSubJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-sub-jobs/actions/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countSubJobsRequest);
            return new AsyncInvoker<CountSubJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<CountSubJobsResponse>);
        }
        
        /// <summary>
        /// 查询租户的镜像任务列表
        ///
        /// 该接口用于查询租户的异步任务执行情况
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListImageJobsResponse> ListImageJobsAsync(ListImageJobsRequest listImageJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-server-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImageJobsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListImageJobsResponse>(response);
        }

        public AsyncInvoker<ListImageJobsResponse> ListImageJobsAsyncInvoker(ListImageJobsRequest listImageJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-server-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImageJobsRequest);
            return new AsyncInvoker<ListImageJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListImageJobsResponse>);
        }
        
        /// <summary>
        /// 镜像子任务查询
        ///
        /// 该接口用于查询异步子任务执行情况,sub_job_ids非空时offset和limit不会生效
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListImageSubJobsResponse> ListImageSubJobsAsync(ListImageSubJobsRequest listImageSubJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-server-sub-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImageSubJobsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListImageSubJobsResponse>(response);
        }

        public AsyncInvoker<ListImageSubJobsResponse> ListImageSubJobsAsyncInvoker(ListImageSubJobsRequest listImageSubJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-server-sub-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImageSubJobsRequest);
            return new AsyncInvoker<ListImageSubJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListImageSubJobsResponse>);
        }
        
        /// <summary>
        /// 子任务查询
        ///
        /// 该接口用于查询异步子任务执行情况,sub_job_ids非空时offset和limit不会生效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSubJobsResponse> ListSubJobsAsync(ListSubJobsRequest listSubJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-sub-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubJobsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSubJobsResponse>(response);
        }

        public AsyncInvoker<ListSubJobsResponse> ListSubJobsAsyncInvoker(ListSubJobsRequest listSubJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-sub-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubJobsRequest);
            return new AsyncInvoker<ListSubJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSubJobsResponse>);
        }
        
        /// <summary>
        /// 查询镜像任务详情
        ///
        /// 该接口用于查询异步任务的执行情况，比如查询创建镜像实例任务的执行状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowImageJobResponse> ShowImageJobAsync(ShowImageJobRequest showImageJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showImageJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-server-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showImageJobRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowImageJobResponse>(response);
        }

        public AsyncInvoker<ShowImageJobResponse> ShowImageJobAsyncInvoker(ShowImageJobRequest showImageJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showImageJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-server-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showImageJobRequest);
            return new AsyncInvoker<ShowImageJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowImageJobResponse>);
        }
        
        /// <summary>
        /// 查询任务的执行状态
        ///
        /// 查询Job的执行状态。
        /// 
        /// 对于创建云应用服务器命令下发后会返回job_id，通过job_id可以查询任务的执行状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowJobResponse> ShowJobAsync(ShowJobRequest showJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/job/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowJobResponse>(response);
        }

        public AsyncInvoker<ShowJobResponse> ShowJobAsyncInvoker(ShowJobRequest showJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/job/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobRequest);
            return new AsyncInvoker<ShowJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobResponse>);
        }
        
        /// <summary>
        /// 查询任务的执行状态
        ///
        /// 查询Job的执行状态。
        /// 
        /// 对于创建云服务器、删除云服务器、重建镜像等异步API，下发命令后会返回job_id，通过job_id可以查询任务的执行状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowJobDetailResponse> ShowJobDetailAsync(ShowJobDetailRequest showJobDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobDetailRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/job/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowJobDetailResponse>(response);
        }

        public AsyncInvoker<ShowJobDetailResponse> ShowJobDetailAsyncInvoker(ShowJobDetailRequest showJobDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobDetailRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/job/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobDetailRequest);
            return new AsyncInvoker<ShowJobDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobDetailResponse>);
        }
        
        /// <summary>
        /// 查询应用组授权邮件发送记录
        ///
        /// 查询应用组授权邮件发送记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuthorizationMailRecordResponse> ListAuthorizationMailRecordAsync(ListAuthorizationMailRecordRequest listAuthorizationMailRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/mails", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuthorizationMailRecordRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAuthorizationMailRecordResponse>(response);
        }

        public AsyncInvoker<ListAuthorizationMailRecordResponse> ListAuthorizationMailRecordAsyncInvoker(ListAuthorizationMailRecordRequest listAuthorizationMailRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/mails", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuthorizationMailRecordRequest);
            return new AsyncInvoker<ListAuthorizationMailRecordResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuthorizationMailRecordResponse>);
        }
        
        /// <summary>
        /// 重发应用组授权邮件（根据授权邮件记录）
        ///
        /// 重发应用组授权邮件（根据授权邮件记录）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SendAuthorizationMailResponse> SendAuthorizationMailAsync(SendAuthorizationMailRequest sendAuthorizationMailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/mails/actions/send", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendAuthorizationMailRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<SendAuthorizationMailResponse>(response);
        }

        public AsyncInvoker<SendAuthorizationMailResponse> SendAuthorizationMailAsyncInvoker(SendAuthorizationMailRequest sendAuthorizationMailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/mails/actions/send", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendAuthorizationMailRequest);
            return new AsyncInvoker<SendAuthorizationMailResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SendAuthorizationMailResponse>);
        }
        
        /// <summary>
        /// 重发应用组授权邮件（根据授权记录）
        ///
        /// 重发应用组授权邮件（根据授权记录）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SendAuthorizedMailResponse> SendAuthorizedMailAsync(SendAuthorizedMailRequest sendAuthorizedMailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/mails/actions/send-by-authorization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendAuthorizedMailRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<SendAuthorizedMailResponse>(response);
        }

        public AsyncInvoker<SendAuthorizedMailResponse> SendAuthorizedMailAsyncInvoker(SendAuthorizedMailRequest sendAuthorizedMailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/mails/actions/send-by-authorization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendAuthorizedMailRequest);
            return new AsyncInvoker<SendAuthorizedMailResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SendAuthorizedMailResponse>);
        }
        
        /// <summary>
        /// 删除WKS存储
        ///
        /// 删除WKS存储。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeletePersistentStorageResponse> BatchDeletePersistentStorageAsync(BatchDeletePersistentStorageRequest batchDeletePersistentStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeletePersistentStorageRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeletePersistentStorageResponse>(response);
        }

        public AsyncInvoker<BatchDeletePersistentStorageResponse> BatchDeletePersistentStorageAsyncInvoker(BatchDeletePersistentStorageRequest batchDeletePersistentStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeletePersistentStorageRequest);
            return new AsyncInvoker<BatchDeletePersistentStorageResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeletePersistentStorageResponse>);
        }
        
        /// <summary>
        /// 新增或更新存储目录访问权限自定义策略
        ///
        /// 新增或更新存储目录访问权限自定义策略(已存在自定义策略时会对已有策略更新)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateOrUpdateStoragePolicyStatementResponse> CreateOrUpdateStoragePolicyStatementAsync(CreateOrUpdateStoragePolicyStatementRequest createOrUpdateStoragePolicyStatementRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/storages-policy/actions/create-statements", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrUpdateStoragePolicyStatementRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<CreateOrUpdateStoragePolicyStatementResponse>(response);
        }

        public AsyncInvoker<CreateOrUpdateStoragePolicyStatementResponse> CreateOrUpdateStoragePolicyStatementAsyncInvoker(CreateOrUpdateStoragePolicyStatementRequest createOrUpdateStoragePolicyStatementRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/storages-policy/actions/create-statements", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrUpdateStoragePolicyStatementRequest);
            return new AsyncInvoker<CreateOrUpdateStoragePolicyStatementResponse>(this, "PUT", request, JsonUtils.DeSerialize<CreateOrUpdateStoragePolicyStatementResponse>);
        }
        
        /// <summary>
        /// 创建WKS存储
        ///
        /// 创建WKS存储，目前仅支持创建 SFS3.0 容量型文件系统。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePersistentStorageResponse> CreatePersistentStorageAsync(CreatePersistentStorageRequest createPersistentStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPersistentStorageRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePersistentStorageResponse>(response);
        }

        public AsyncInvoker<CreatePersistentStorageResponse> CreatePersistentStorageAsyncInvoker(CreatePersistentStorageRequest createPersistentStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPersistentStorageRequest);
            return new AsyncInvoker<CreatePersistentStorageResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePersistentStorageResponse>);
        }
        
        /// <summary>
        /// 创建共享存储目录
        ///
        /// 创建共享存储目录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateShareFolderResponse> CreateShareFolderAsync(CreateShareFolderRequest createShareFolderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("storage_id", createShareFolderRequest.StorageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages/{storage_id}/actions/create-share-folder", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createShareFolderRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateShareFolderResponse>(response);
        }

        public AsyncInvoker<CreateShareFolderResponse> CreateShareFolderAsyncInvoker(CreateShareFolderRequest createShareFolderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("storage_id", createShareFolderRequest.StorageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages/{storage_id}/actions/create-share-folder", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createShareFolderRequest);
            return new AsyncInvoker<CreateShareFolderResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateShareFolderResponse>);
        }
        
        /// <summary>
        /// 删除WKS存储
        ///
        /// 删除共享存储，只会解除NAS与文件系统之间的关联关系，不会删除文件系统和文件系统中的数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePersistentStorageResponse> DeletePersistentStorageAsync(DeletePersistentStorageRequest deletePersistentStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("storage_id", deletePersistentStorageRequest.StorageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages/{storage_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePersistentStorageRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePersistentStorageResponse>(response);
        }

        public AsyncInvoker<DeletePersistentStorageResponse> DeletePersistentStorageAsyncInvoker(DeletePersistentStorageRequest deletePersistentStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("storage_id", deletePersistentStorageRequest.StorageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages/{storage_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePersistentStorageRequest);
            return new AsyncInvoker<DeletePersistentStorageResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePersistentStorageResponse>);
        }
        
        /// <summary>
        /// 删除共享目录
        ///
        /// 删除共享存储目录。
        /// &gt; 需要删除绑定的用户及用户组，才能删除共享文目录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteStorageClaimResponse> DeleteStorageClaimAsync(DeleteStorageClaimRequest deleteStorageClaimRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("storage_id", deleteStorageClaimRequest.StorageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages/{storage_id}/actions/delete-storage-claim", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteStorageClaimRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteStorageClaimResponse>(response);
        }

        public AsyncInvoker<DeleteStorageClaimResponse> DeleteStorageClaimAsyncInvoker(DeleteStorageClaimRequest deleteStorageClaimRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("storage_id", deleteStorageClaimRequest.StorageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages/{storage_id}/actions/delete-storage-claim", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteStorageClaimRequest);
            return new AsyncInvoker<DeleteStorageClaimResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteStorageClaimResponse>);
        }
        
        /// <summary>
        /// 删除个人存储目录
        ///
        /// 删除个人存储目录，个人目录中的数据也将永久删除且无法恢复。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteUserStorageAttachmentResponse> DeleteUserStorageAttachmentAsync(DeleteUserStorageAttachmentRequest deleteUserStorageAttachmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("storage_id", deleteUserStorageAttachmentRequest.StorageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages/{storage_id}/actions/delete-user-attachment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserStorageAttachmentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteUserStorageAttachmentResponse>(response);
        }

        public AsyncInvoker<DeleteUserStorageAttachmentResponse> DeleteUserStorageAttachmentAsyncInvoker(DeleteUserStorageAttachmentRequest deleteUserStorageAttachmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("storage_id", deleteUserStorageAttachmentRequest.StorageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages/{storage_id}/actions/delete-user-attachment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserStorageAttachmentRequest);
            return new AsyncInvoker<DeleteUserStorageAttachmentResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteUserStorageAttachmentResponse>);
        }
        
        /// <summary>
        /// 查询WKS存储
        ///
        /// 查询WKS存储。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPersistentStorageResponse> ListPersistentStorageAsync(ListPersistentStorageRequest listPersistentStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPersistentStorageRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPersistentStorageResponse>(response);
        }

        public AsyncInvoker<ListPersistentStorageResponse> ListPersistentStorageAsyncInvoker(ListPersistentStorageRequest listPersistentStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPersistentStorageRequest);
            return new AsyncInvoker<ListPersistentStorageResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPersistentStorageResponse>);
        }
        
        /// <summary>
        /// 查询SFS3.0存储
        ///
        /// 查询SFS3.0存储。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSfs3StorageResponse> ListSfs3StorageAsync(ListSfs3StorageRequest listSfs3StorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/persistent-storages/actions/list-sfs-storages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSfs3StorageRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSfs3StorageResponse>(response);
        }

        public AsyncInvoker<ListSfs3StorageResponse> ListSfs3StorageAsyncInvoker(ListSfs3StorageRequest listSfs3StorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/persistent-storages/actions/list-sfs-storages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSfs3StorageRequest);
            return new AsyncInvoker<ListSfs3StorageResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSfs3StorageResponse>);
        }
        
        /// <summary>
        /// 查询共享存储目录
        ///
        /// 查询共享存储目录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListShareFolderResponse> ListShareFolderAsync(ListShareFolderRequest listShareFolderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages/actions/list-share-folders", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listShareFolderRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListShareFolderResponse>(response);
        }

        public AsyncInvoker<ListShareFolderResponse> ListShareFolderAsyncInvoker(ListShareFolderRequest listShareFolderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages/actions/list-share-folders", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listShareFolderRequest);
            return new AsyncInvoker<ListShareFolderResponse>(this, "GET", request, JsonUtils.DeSerialize<ListShareFolderResponse>);
        }
        
        /// <summary>
        /// 查询个人存储目录
        ///
        /// 查询个人存储目录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListStorageAssignmentResponse> ListStorageAssignmentAsync(ListStorageAssignmentRequest listStorageAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages/actions/list-attachments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStorageAssignmentRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListStorageAssignmentResponse>(response);
        }

        public AsyncInvoker<ListStorageAssignmentResponse> ListStorageAssignmentAsyncInvoker(ListStorageAssignmentRequest listStorageAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages/actions/list-attachments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStorageAssignmentRequest);
            return new AsyncInvoker<ListStorageAssignmentResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStorageAssignmentResponse>);
        }
        
        /// <summary>
        /// 查询存储目录访问权限策略
        ///
        /// 查询存储目录访问权限策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListStoragePolicyStatementResponse> ListStoragePolicyStatementAsync(ListStoragePolicyStatementRequest listStoragePolicyStatementRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/storages-policy/actions/list-statements", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStoragePolicyStatementRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListStoragePolicyStatementResponse>(response);
        }

        public AsyncInvoker<ListStoragePolicyStatementResponse> ListStoragePolicyStatementAsyncInvoker(ListStoragePolicyStatementRequest listStoragePolicyStatementRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/storages-policy/actions/list-statements", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStoragePolicyStatementRequest);
            return new AsyncInvoker<ListStoragePolicyStatementResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStoragePolicyStatementResponse>);
        }
        
        /// <summary>
        /// 修改共享目录成员
        ///
        /// 批量添加或者移除共享目录成员。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateShareFolderAssignmentResponse> UpdateShareFolderAssignmentAsync(UpdateShareFolderAssignmentRequest updateShareFolderAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("storage_id", updateShareFolderAssignmentRequest.StorageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages/{storage_id}/actions/assign-share-folder", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateShareFolderAssignmentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateShareFolderAssignmentResponse>(response);
        }

        public AsyncInvoker<UpdateShareFolderAssignmentResponse> UpdateShareFolderAssignmentAsyncInvoker(UpdateShareFolderAssignmentRequest updateShareFolderAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("storage_id", updateShareFolderAssignmentRequest.StorageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages/{storage_id}/actions/assign-share-folder", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateShareFolderAssignmentRequest);
            return new AsyncInvoker<UpdateShareFolderAssignmentResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateShareFolderAssignmentResponse>);
        }
        
        /// <summary>
        /// 创建个人存储目录
        ///
        /// 创建个人存储目录，已存在对应目录时，仅更新策略不会重复创建目录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateUserFolderAssignmentResponse> UpdateUserFolderAssignmentAsync(UpdateUserFolderAssignmentRequest updateUserFolderAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("storage_id", updateUserFolderAssignmentRequest.StorageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages/{storage_id}/actions/assign-folder", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserFolderAssignmentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateUserFolderAssignmentResponse>(response);
        }

        public AsyncInvoker<UpdateUserFolderAssignmentResponse> UpdateUserFolderAssignmentAsyncInvoker(UpdateUserFolderAssignmentRequest updateUserFolderAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("storage_id", updateUserFolderAssignmentRequest.StorageId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages/{storage_id}/actions/assign-folder", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserFolderAssignmentRequest);
            return new AsyncInvoker<UpdateUserFolderAssignmentResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateUserFolderAssignmentResponse>);
        }
        
        /// <summary>
        /// 新增策略组
        ///
        /// 新增策略组，通过策略组能灵活的控制客户端访问与接入策略，如：文件、剪切板、会话等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePolicyGroupResponse> CreatePolicyGroupAsync(CreatePolicyGroupRequest createPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPolicyGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePolicyGroupResponse>(response);
        }

        public AsyncInvoker<CreatePolicyGroupResponse> CreatePolicyGroupAsyncInvoker(CreatePolicyGroupRequest createPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPolicyGroupRequest);
            return new AsyncInvoker<CreatePolicyGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePolicyGroupResponse>);
        }
        
        /// <summary>
        /// 新增策略模板
        ///
        /// 新增策略模板。策略模板创建好后，用户在创建策略组的时候，就可以根据已有策略模板按需调整配置，快速完成策略组的创建。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePolicyTemplateResponse> CreatePolicyTemplateAsync(CreatePolicyTemplateRequest createPolicyTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPolicyTemplateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePolicyTemplateResponse>(response);
        }

        public AsyncInvoker<CreatePolicyTemplateResponse> CreatePolicyTemplateAsyncInvoker(CreatePolicyTemplateRequest createPolicyTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPolicyTemplateRequest);
            return new AsyncInvoker<CreatePolicyTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePolicyTemplateResponse>);
        }
        
        /// <summary>
        /// 删除策略组
        ///
        /// 删除指定策略组，包含策略组对应的策略信息以及应用对象信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePolicyGroupResponse> DeletePolicyGroupAsync(DeletePolicyGroupRequest deletePolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_group_id", deletePolicyGroupRequest.PolicyGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-groups/{policy_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyGroupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePolicyGroupResponse>(response);
        }

        public AsyncInvoker<DeletePolicyGroupResponse> DeletePolicyGroupAsyncInvoker(DeletePolicyGroupRequest deletePolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_group_id", deletePolicyGroupRequest.PolicyGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-groups/{policy_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyGroupRequest);
            return new AsyncInvoker<DeletePolicyGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePolicyGroupResponse>);
        }
        
        /// <summary>
        /// 删除策略模板
        ///
        /// 删除指定策略模板，包含策略模板对应的策略信息以及应用对象信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePolicyTemplateResponse> DeletePolicyTemplateAsync(DeletePolicyTemplateRequest deletePolicyTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_template_id", deletePolicyTemplateRequest.PolicyTemplateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-templates/{policy_template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyTemplateRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePolicyTemplateResponse>(response);
        }

        public AsyncInvoker<DeletePolicyTemplateResponse> DeletePolicyTemplateAsyncInvoker(DeletePolicyTemplateRequest deletePolicyTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_template_id", deletePolicyTemplateRequest.PolicyTemplateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-templates/{policy_template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyTemplateRequest);
            return new AsyncInvoker<DeletePolicyTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePolicyTemplateResponse>);
        }
        
        /// <summary>
        /// 查询策略组列表
        ///
        /// 查询策略组概要信息列表,包括应用对象和详细策略项。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPolicyGroupResponse> ListPolicyGroupAsync(ListPolicyGroupRequest listPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPolicyGroupResponse>(response);
        }

        public AsyncInvoker<ListPolicyGroupResponse> ListPolicyGroupAsyncInvoker(ListPolicyGroupRequest listPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyGroupRequest);
            return new AsyncInvoker<ListPolicyGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPolicyGroupResponse>);
        }
        
        /// <summary>
        /// 查询策略组详情列表
        ///
        /// 包含策略信息以及应用对象的信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPolicyGroupDetailInfoResponse> ListPolicyGroupDetailInfoAsync(ListPolicyGroupDetailInfoRequest listPolicyGroupDetailInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-groups/show/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyGroupDetailInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPolicyGroupDetailInfoResponse>(response);
        }

        public AsyncInvoker<ListPolicyGroupDetailInfoResponse> ListPolicyGroupDetailInfoAsyncInvoker(ListPolicyGroupDetailInfoRequest listPolicyGroupDetailInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-groups/show/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyGroupDetailInfoRequest);
            return new AsyncInvoker<ListPolicyGroupDetailInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPolicyGroupDetailInfoResponse>);
        }
        
        /// <summary>
        /// 查询策略组中的策略项
        ///
        /// 查询指定策略组内的策略项。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPolicyOfPolicyGroupResponse> ListPolicyOfPolicyGroupAsync(ListPolicyOfPolicyGroupRequest listPolicyOfPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_group_id", listPolicyOfPolicyGroupRequest.PolicyGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-groups/{policy_group_id}/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyOfPolicyGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPolicyOfPolicyGroupResponse>(response);
        }

        public AsyncInvoker<ListPolicyOfPolicyGroupResponse> ListPolicyOfPolicyGroupAsyncInvoker(ListPolicyOfPolicyGroupRequest listPolicyOfPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_group_id", listPolicyOfPolicyGroupRequest.PolicyGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-groups/{policy_group_id}/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyOfPolicyGroupRequest);
            return new AsyncInvoker<ListPolicyOfPolicyGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPolicyOfPolicyGroupResponse>);
        }
        
        /// <summary>
        /// 查询策略模板列表
        ///
        /// 查询策略模板概要信息列表，包含策略信息以及应用对象信息。用户在创建策略组的时候，可以根据已有策略模板按需调整配置，快速完成策略组的创建。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPolicyTemplateResponse> ListPolicyTemplateAsync(ListPolicyTemplateRequest listPolicyTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyTemplateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPolicyTemplateResponse>(response);
        }

        public AsyncInvoker<ListPolicyTemplateResponse> ListPolicyTemplateAsyncInvoker(ListPolicyTemplateRequest listPolicyTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyTemplateRequest);
            return new AsyncInvoker<ListPolicyTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPolicyTemplateResponse>);
        }
        
        /// <summary>
        /// 查询策略组应用对象
        ///
        /// 查询指定策略组所应用的对象。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTargetsOfPolicyGroupResponse> ListTargetsOfPolicyGroupAsync(ListTargetsOfPolicyGroupRequest listTargetsOfPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_group_id", listTargetsOfPolicyGroupRequest.PolicyGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-groups/{policy_group_id}/target", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTargetsOfPolicyGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTargetsOfPolicyGroupResponse>(response);
        }

        public AsyncInvoker<ListTargetsOfPolicyGroupResponse> ListTargetsOfPolicyGroupAsyncInvoker(ListTargetsOfPolicyGroupRequest listTargetsOfPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_group_id", listTargetsOfPolicyGroupRequest.PolicyGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-groups/{policy_group_id}/target", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTargetsOfPolicyGroupRequest);
            return new AsyncInvoker<ListTargetsOfPolicyGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTargetsOfPolicyGroupResponse>);
        }
        
        /// <summary>
        /// 查询初始策略项
        ///
        /// 查询初始策略项，初始策略项是所有协议策略配置项的默认配置，用户可以在初始策略项的基础上根据需求修改指定的配置，创建新的策略组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowOriginalPolicyInfoResponse> ShowOriginalPolicyInfoAsync(ShowOriginalPolicyInfoRequest showOriginalPolicyInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-groups/actions/list-original-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOriginalPolicyInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowOriginalPolicyInfoResponse>(response);
        }

        public AsyncInvoker<ShowOriginalPolicyInfoResponse> ShowOriginalPolicyInfoAsyncInvoker(ShowOriginalPolicyInfoRequest showOriginalPolicyInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-groups/actions/list-original-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOriginalPolicyInfoRequest);
            return new AsyncInvoker<ShowOriginalPolicyInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOriginalPolicyInfoResponse>);
        }
        
        /// <summary>
        /// 查询策略组详情
        ///
        /// 根据策略组ID查询策略组详细信息，包含策略信息以及应用对象信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPolicyGroupResponse> ShowPolicyGroupAsync(ShowPolicyGroupRequest showPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_group_id", showPolicyGroupRequest.PolicyGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-groups/{policy_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPolicyGroupResponse>(response);
        }

        public AsyncInvoker<ShowPolicyGroupResponse> ShowPolicyGroupAsyncInvoker(ShowPolicyGroupRequest showPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_group_id", showPolicyGroupRequest.PolicyGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-groups/{policy_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyGroupRequest);
            return new AsyncInvoker<ShowPolicyGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPolicyGroupResponse>);
        }
        
        /// <summary>
        /// 修改策略组
        ///
        /// 修改指定策略组的信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePolicyGroupResponse> UpdatePolicyGroupAsync(UpdatePolicyGroupRequest updatePolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_group_id", updatePolicyGroupRequest.PolicyGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-groups/{policy_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyGroupRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<UpdatePolicyGroupResponse>(response);
        }

        public AsyncInvoker<UpdatePolicyGroupResponse> UpdatePolicyGroupAsyncInvoker(UpdatePolicyGroupRequest updatePolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_group_id", updatePolicyGroupRequest.PolicyGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-groups/{policy_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyGroupRequest);
            return new AsyncInvoker<UpdatePolicyGroupResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpdatePolicyGroupResponse>);
        }
        
        /// <summary>
        /// 修改策略模板
        ///
        /// 修改指定策略模板的信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePolicyTemplateResponse> UpdatePolicyTemplateAsync(UpdatePolicyTemplateRequest updatePolicyTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_template_id", updatePolicyTemplateRequest.PolicyTemplateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-templates/{policy_template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyTemplateRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<UpdatePolicyTemplateResponse>(response);
        }

        public AsyncInvoker<UpdatePolicyTemplateResponse> UpdatePolicyTemplateAsyncInvoker(UpdatePolicyTemplateRequest updatePolicyTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_template_id", updatePolicyTemplateRequest.PolicyTemplateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-templates/{policy_template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyTemplateRequest);
            return new AsyncInvoker<UpdatePolicyTemplateResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpdatePolicyTemplateResponse>);
        }
        
        /// <summary>
        /// 配额校验
        ///
        /// 配额校验，购买服务器前可用调用该接口，校验本次创建服务器资源是否足够。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckQuotaResponse> CheckQuotaAsync(CheckQuotaRequest checkQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/check/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkQuotaRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<CheckQuotaResponse>(response);
        }

        public AsyncInvoker<CheckQuotaResponse> CheckQuotaAsyncInvoker(CheckQuotaRequest checkQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/check/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkQuotaRequest);
            return new AsyncInvoker<CheckQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<CheckQuotaResponse>);
        }
        
        /// <summary>
        /// 新增/修改弹性伸缩策略
        ///
        /// 新增/修改弹性伸缩策略,仅按需的服务器支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateOrUpdateScalingPolicyResponse> CreateOrUpdateScalingPolicyAsync(CreateOrUpdateScalingPolicyRequest createOrUpdateScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/scaling-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrUpdateScalingPolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<CreateOrUpdateScalingPolicyResponse>(response);
        }

        public AsyncInvoker<CreateOrUpdateScalingPolicyResponse> CreateOrUpdateScalingPolicyAsyncInvoker(CreateOrUpdateScalingPolicyRequest createOrUpdateScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/scaling-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrUpdateScalingPolicyRequest);
            return new AsyncInvoker<CreateOrUpdateScalingPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<CreateOrUpdateScalingPolicyResponse>);
        }
        
        /// <summary>
        /// 删除弹性伸缩策略
        ///
        /// 删除弹性伸缩策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteScalingPolicyResponse> DeleteScalingPolicyAsync(DeleteScalingPolicyRequest deleteScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/scaling-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScalingPolicyRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteScalingPolicyResponse>(response);
        }

        public AsyncInvoker<DeleteScalingPolicyResponse> DeleteScalingPolicyAsyncInvoker(DeleteScalingPolicyRequest deleteScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/scaling-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScalingPolicyRequest);
            return new AsyncInvoker<DeleteScalingPolicyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteScalingPolicyResponse>);
        }
        
        /// <summary>
        /// 查询服务器组弹性伸缩策略
        ///
        /// 查询服务器组弹性伸缩策略,如果服务器未配置策略时响应默认策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowScalingPolicyResponse> ShowScalingPolicyAsync(ShowScalingPolicyRequest showScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/scaling-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScalingPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowScalingPolicyResponse>(response);
        }

        public AsyncInvoker<ShowScalingPolicyResponse> ShowScalingPolicyAsyncInvoker(ShowScalingPolicyRequest showScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/scaling-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScalingPolicyRequest);
            return new AsyncInvoker<ShowScalingPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowScalingPolicyResponse>);
        }
        
        /// <summary>
        /// 批量删除定时任务
        ///
        /// 批量删除定时任务，忽略不存在的服务器组并且返回成功响应。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteScheduleTaskResponse> BatchDeleteScheduleTaskAsync(BatchDeleteScheduleTaskRequest batchDeleteScheduleTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule-task/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteScheduleTaskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteScheduleTaskResponse>(response);
        }

        public AsyncInvoker<BatchDeleteScheduleTaskResponse> BatchDeleteScheduleTaskAsyncInvoker(BatchDeleteScheduleTaskRequest batchDeleteScheduleTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule-task/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteScheduleTaskRequest);
            return new AsyncInvoker<BatchDeleteScheduleTaskResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteScheduleTaskResponse>);
        }
        
        /// <summary>
        /// 新增定时任务
        ///
        /// 新增定时任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateScheduleTaskResponse> CreateScheduleTaskAsync(CreateScheduleTaskRequest createScheduleTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createScheduleTaskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateScheduleTaskResponse>(response);
        }

        public AsyncInvoker<CreateScheduleTaskResponse> CreateScheduleTaskAsyncInvoker(CreateScheduleTaskRequest createScheduleTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createScheduleTaskRequest);
            return new AsyncInvoker<CreateScheduleTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateScheduleTaskResponse>);
        }
        
        /// <summary>
        /// 删除任务
        ///
        /// 删除任务，忽略不存在的任务并且返回成功响应。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteScheduleTaskResponse> DeleteScheduleTaskAsync(DeleteScheduleTaskRequest deleteScheduleTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", deleteScheduleTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScheduleTaskRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteScheduleTaskResponse>(response);
        }

        public AsyncInvoker<DeleteScheduleTaskResponse> DeleteScheduleTaskAsyncInvoker(DeleteScheduleTaskRequest deleteScheduleTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", deleteScheduleTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScheduleTaskRequest);
            return new AsyncInvoker<DeleteScheduleTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteScheduleTaskResponse>);
        }
        
        /// <summary>
        /// 未来执行的具体时间列表
        ///
        /// 未来执行的具体时间列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFutureExecutionsResponse> ListFutureExecutionsAsync(ListFutureExecutionsRequest listFutureExecutionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule-task/future-executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFutureExecutionsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListFutureExecutionsResponse>(response);
        }

        public AsyncInvoker<ListFutureExecutionsResponse> ListFutureExecutionsAsyncInvoker(ListFutureExecutionsRequest listFutureExecutionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule-task/future-executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFutureExecutionsRequest);
            return new AsyncInvoker<ListFutureExecutionsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListFutureExecutionsResponse>);
        }
        
        /// <summary>
        /// 查询定时任务列表
        ///
        /// 查询定时任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListScheduleTasksResponse> ListScheduleTasksAsync(ListScheduleTasksRequest listScheduleTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduleTasksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListScheduleTasksResponse>(response);
        }

        public AsyncInvoker<ListScheduleTasksResponse> ListScheduleTasksAsyncInvoker(ListScheduleTasksRequest listScheduleTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduleTasksRequest);
            return new AsyncInvoker<ListScheduleTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScheduleTasksResponse>);
        }
        
        /// <summary>
        /// 查询定时任务执行子任务列表
        ///
        /// 查询定时任务执行子任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTaskExecuteDetailResponse> ListTaskExecuteDetailAsync(ListTaskExecuteDetailRequest listTaskExecuteDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("execute_history_id", listTaskExecuteDetailRequest.ExecuteHistoryId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule-task/{execute_history_id}/execute-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTaskExecuteDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTaskExecuteDetailResponse>(response);
        }

        public AsyncInvoker<ListTaskExecuteDetailResponse> ListTaskExecuteDetailAsyncInvoker(ListTaskExecuteDetailRequest listTaskExecuteDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("execute_history_id", listTaskExecuteDetailRequest.ExecuteHistoryId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule-task/{execute_history_id}/execute-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTaskExecuteDetailRequest);
            return new AsyncInvoker<ListTaskExecuteDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTaskExecuteDetailResponse>);
        }
        
        /// <summary>
        /// 查询定时任务执行列表
        ///
        /// 查询定时任务执行列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTaskExecuteHistoryResponse> ListTaskExecuteHistoryAsync(ListTaskExecuteHistoryRequest listTaskExecuteHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", listTaskExecuteHistoryRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule-task/{task_id}/execute-history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTaskExecuteHistoryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTaskExecuteHistoryResponse>(response);
        }

        public AsyncInvoker<ListTaskExecuteHistoryResponse> ListTaskExecuteHistoryAsyncInvoker(ListTaskExecuteHistoryRequest listTaskExecuteHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", listTaskExecuteHistoryRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule-task/{task_id}/execute-history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTaskExecuteHistoryRequest);
            return new AsyncInvoker<ListTaskExecuteHistoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTaskExecuteHistoryResponse>);
        }
        
        /// <summary>
        /// 查询指定定时任务详情
        ///
        /// 查询指定定时任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowScheduleTaskResponse> ShowScheduleTaskAsync(ShowScheduleTaskRequest showScheduleTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", showScheduleTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScheduleTaskRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowScheduleTaskResponse>(response);
        }

        public AsyncInvoker<ShowScheduleTaskResponse> ShowScheduleTaskAsyncInvoker(ShowScheduleTaskRequest showScheduleTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", showScheduleTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScheduleTaskRequest);
            return new AsyncInvoker<ShowScheduleTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowScheduleTaskResponse>);
        }
        
        /// <summary>
        /// 修改定时任务
        ///
        /// 修改定时任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateScheduleTaskResponse> UpdateScheduleTaskAsync(UpdateScheduleTaskRequest updateScheduleTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", updateScheduleTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateScheduleTaskRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<UpdateScheduleTaskResponse>(response);
        }

        public AsyncInvoker<UpdateScheduleTaskResponse> UpdateScheduleTaskAsyncInvoker(UpdateScheduleTaskRequest updateScheduleTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("task_id", updateScheduleTaskRequest.TaskId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateScheduleTaskRequest);
            return new AsyncInvoker<UpdateScheduleTaskResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpdateScheduleTaskResponse>);
        }
        
        /// <summary>
        /// 批量修改服务器的镜像
        ///
        /// 批量修改服务器的镜像。
        /// &gt; - 服务器的镜像和服务器组的镜像不一样时，支持服务器的镜像切换为服务器组的镜像，并且仅允许同等镜像进行切换，例如：同操作系统，免费镜像切换，同源同价的付费镜像切换。如果服务器组的镜像和服务器的镜像为非同等镜像，建议您直接购买新的服务器，删除或者退订老的服务器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchChangeServerImageResponse> BatchChangeServerImageAsync(BatchChangeServerImageRequest batchChangeServerImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/batch-change-image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchChangeServerImageRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchChangeServerImageResponse>(response);
        }

        public AsyncInvoker<BatchChangeServerImageResponse> BatchChangeServerImageAsyncInvoker(BatchChangeServerImageRequest batchChangeServerImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/batch-change-image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchChangeServerImageRequest);
            return new AsyncInvoker<BatchChangeServerImageResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchChangeServerImageResponse>);
        }
        
        /// <summary>
        /// 标记服务器维护状态
        ///
        /// 标记服务器维护状态，处于维护状态中的服务器不再分配流量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchChangeServerMaintainModeResponse> BatchChangeServerMaintainModeAsync(BatchChangeServerMaintainModeRequest batchChangeServerMaintainModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/batch-maint", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchChangeServerMaintainModeRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerializeNull<BatchChangeServerMaintainModeResponse>(response);
        }

        public AsyncInvoker<BatchChangeServerMaintainModeResponse> BatchChangeServerMaintainModeAsyncInvoker(BatchChangeServerMaintainModeRequest batchChangeServerMaintainModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/batch-maint", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchChangeServerMaintainModeRequest);
            return new AsyncInvoker<BatchChangeServerMaintainModeResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<BatchChangeServerMaintainModeResponse>);
        }
        
        /// <summary>
        /// 批量删除服务器
        ///
        /// 批量删除服务器。
        /// &gt; - 仅支持删除按需订购的服务器，包周期订购的服务器需要到Console界面进行退订，订单退订成功后服务器将会自动删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteServerResponse> BatchDeleteServerAsync(BatchDeleteServerRequest batchDeleteServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteServerRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteServerResponse>(response);
        }

        public AsyncInvoker<BatchDeleteServerResponse> BatchDeleteServerAsyncInvoker(BatchDeleteServerRequest batchDeleteServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteServerRequest);
            return new AsyncInvoker<BatchDeleteServerResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteServerResponse>);
        }
        
        /// <summary>
        /// 迁移云办公主机下面的服务器到目标云办公主机
        ///
        /// 迁移云办公主机下面的服务器到目标云办公主机。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchMigrateHostsServerResponse> BatchMigrateHostsServerAsync(BatchMigrateHostsServerRequest batchMigrateHostsServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/hosts/batch-migrate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchMigrateHostsServerRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<BatchMigrateHostsServerResponse>(response);
        }

        public AsyncInvoker<BatchMigrateHostsServerResponse> BatchMigrateHostsServerAsyncInvoker(BatchMigrateHostsServerRequest batchMigrateHostsServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/hosts/batch-migrate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchMigrateHostsServerRequest);
            return new AsyncInvoker<BatchMigrateHostsServerResponse>(this, "PATCH", request, JsonUtils.DeSerialize<BatchMigrateHostsServerResponse>);
        }
        
        /// <summary>
        /// 重启服务器
        ///
        /// 重启服务器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchRebootServerResponse> BatchRebootServerAsync(BatchRebootServerRequest batchRebootServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/batch-reboot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRebootServerRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerializeNull<BatchRebootServerResponse>(response);
        }

        public AsyncInvoker<BatchRebootServerResponse> BatchRebootServerAsyncInvoker(BatchRebootServerRequest batchRebootServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/batch-reboot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRebootServerRequest);
            return new AsyncInvoker<BatchRebootServerResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<BatchRebootServerResponse>);
        }
        
        /// <summary>
        /// 批量重装服务器
        ///
        /// 批量重装服务器。
        /// &gt; - 使用服务器原有的镜像进行重装，当服务器异常无法恢复时或者服务器运行时间久了，性能下降时，可选择重建服务器。注意：重装时系统盘的数据将会被清理掉。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchReinstallServerResponse> BatchReinstallServerAsync(BatchReinstallServerRequest batchReinstallServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/batch-reinstall", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchReinstallServerRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchReinstallServerResponse>(response);
        }

        public AsyncInvoker<BatchReinstallServerResponse> BatchReinstallServerAsyncInvoker(BatchReinstallServerRequest batchReinstallServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/batch-reinstall", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchReinstallServerRequest);
            return new AsyncInvoker<BatchReinstallServerResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchReinstallServerResponse>);
        }
        
        /// <summary>
        /// 批量服务器重新加域
        ///
        /// 批量服务器重新加入AD域，一般用于解决服务器脱域的情况使用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchRejoinDomainResponse> BatchRejoinDomainAsync(BatchRejoinDomainRequest batchRejoinDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/batch-rejoin-domain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRejoinDomainRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<BatchRejoinDomainResponse>(response);
        }

        public AsyncInvoker<BatchRejoinDomainResponse> BatchRejoinDomainAsyncInvoker(BatchRejoinDomainRequest batchRejoinDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/batch-rejoin-domain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRejoinDomainRequest);
            return new AsyncInvoker<BatchRejoinDomainResponse>(this, "PATCH", request, JsonUtils.DeSerialize<BatchRejoinDomainResponse>);
        }
        
        /// <summary>
        /// 启动服务器
        ///
        /// 启动服务器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchStartServerResponse> BatchStartServerAsync(BatchStartServerRequest batchStartServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/batch-start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchStartServerRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerializeNull<BatchStartServerResponse>(response);
        }

        public AsyncInvoker<BatchStartServerResponse> BatchStartServerAsyncInvoker(BatchStartServerRequest batchStartServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/batch-start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchStartServerRequest);
            return new AsyncInvoker<BatchStartServerResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<BatchStartServerResponse>);
        }
        
        /// <summary>
        /// 关闭服务器
        ///
        /// 关闭服务器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchStopServerResponse> BatchStopServerAsync(BatchStopServerRequest batchStopServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/batch-stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchStopServerRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerializeNull<BatchStopServerResponse>(response);
        }

        public AsyncInvoker<BatchStopServerResponse> BatchStopServerAsyncInvoker(BatchStopServerRequest batchStopServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/batch-stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchStopServerRequest);
            return new AsyncInvoker<BatchStopServerResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<BatchStopServerResponse>);
        }
        
        /// <summary>
        /// 批量更新服务器虚拟会话IP配置
        ///
        /// 批量更新服务器虚拟会话IP配置，按需重启机器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUpdateTsviResponse> BatchUpdateTsviAsync(BatchUpdateTsviRequest batchUpdateTsviRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/batch-update-tsvi", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateTsviRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerialize<BatchUpdateTsviResponse>(response);
        }

        public AsyncInvoker<BatchUpdateTsviResponse> BatchUpdateTsviAsyncInvoker(BatchUpdateTsviRequest batchUpdateTsviRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/batch-update-tsvi", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateTsviRequest);
            return new AsyncInvoker<BatchUpdateTsviResponse>(this, "PATCH", request, JsonUtils.DeSerialize<BatchUpdateTsviResponse>);
        }
        
        /// <summary>
        /// 批量升级服务器HDA版本
        ///
        /// 批量升级服务器HDA版本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUpgradeHdaVersionResponse> BatchUpgradeHdaVersionAsync(BatchUpgradeHdaVersionRequest batchUpgradeHdaVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/access-agent/actions/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpgradeHdaVersionRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerializeNull<BatchUpgradeHdaVersionResponse>(response);
        }

        public AsyncInvoker<BatchUpgradeHdaVersionResponse> BatchUpgradeHdaVersionAsyncInvoker(BatchUpgradeHdaVersionRequest batchUpgradeHdaVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/access-agent/actions/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpgradeHdaVersionRequest);
            return new AsyncInvoker<BatchUpgradeHdaVersionResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<BatchUpgradeHdaVersionResponse>);
        }
        
        /// <summary>
        /// 修改服务器的镜像
        ///
        /// 修改服务器的镜像。
        /// &gt; - 服务器的镜像和服务器组的镜像不一样时，支持服务器的镜像切换为服务器组的镜像，并且仅允许同等镜像进行切换，例如：同操作系统，免费镜像切换，同源同价的付费镜像切换。如果服务器组的镜像和服务器的镜像为非同等镜像，建议您直接购买新的服务器，删除或者退订老的服务器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeServerImageResponse> ChangeServerImageAsync(ChangeServerImageRequest changeServerImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", changeServerImageRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/{server_id}/actions/change-image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeServerImageRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ChangeServerImageResponse>(response);
        }

        public AsyncInvoker<ChangeServerImageResponse> ChangeServerImageAsyncInvoker(ChangeServerImageRequest changeServerImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", changeServerImageRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/{server_id}/actions/change-image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeServerImageRequest);
            return new AsyncInvoker<ChangeServerImageResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeServerImageResponse>);
        }
        
        /// <summary>
        /// 创建云服务器
        ///
        /// 创建云服务器接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAppServersResponse> CreateAppServersAsync(CreateAppServersRequest createAppServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppServersRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAppServersResponse>(response);
        }

        public AsyncInvoker<CreateAppServersResponse> CreateAppServersAsyncInvoker(CreateAppServersRequest createAppServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppServersRequest);
            return new AsyncInvoker<CreateAppServersResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAppServersResponse>);
        }
        
        /// <summary>
        /// 删除服务器
        ///
        /// 删除服务器，忽略不存在的服务器并且返回成功响应。订单退订成功后调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteServerResponse> DeleteServerAsync(DeleteServerRequest deleteServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", deleteServerRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServerRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteServerResponse>(response);
        }

        public AsyncInvoker<DeleteServerResponse> DeleteServerAsyncInvoker(DeleteServerRequest deleteServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", deleteServerRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServerRequest);
            return new AsyncInvoker<DeleteServerResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteServerResponse>);
        }
        
        /// <summary>
        /// 查询租户的所有HDA最新版本
        ///
        /// 查询租户的所有HDA最新版本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAccessAgentLatestVersionResponse> ListAccessAgentLatestVersionAsync(ListAccessAgentLatestVersionRequest listAccessAgentLatestVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/access-agent/actions/show-latest-version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessAgentLatestVersionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAccessAgentLatestVersionResponse>(response);
        }

        public AsyncInvoker<ListAccessAgentLatestVersionResponse> ListAccessAgentLatestVersionAsyncInvoker(ListAccessAgentLatestVersionRequest listAccessAgentLatestVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/access-agent/actions/show-latest-version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessAgentLatestVersionRequest);
            return new AsyncInvoker<ListAccessAgentLatestVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAccessAgentLatestVersionResponse>);
        }
        
        /// <summary>
        /// 查询服务器的HDA相关信息
        ///
        /// 查询服务器的HDA相关信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListServerHdaDetailsResponse> ListServerHdaDetailsAsync(ListServerHdaDetailsRequest listServerHdaDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/access-agent/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerHdaDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListServerHdaDetailsResponse>(response);
        }

        public AsyncInvoker<ListServerHdaDetailsResponse> ListServerHdaDetailsAsyncInvoker(ListServerHdaDetailsRequest listServerHdaDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/access-agent/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerHdaDetailsRequest);
            return new AsyncInvoker<ListServerHdaDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServerHdaDetailsResponse>);
        }
        
        /// <summary>
        /// 查询服务器的HDA升级跟踪记录
        ///
        /// 查询服务器的HDA升级跟踪记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListServerHdaUpgradeRecordsResponse> ListServerHdaUpgradeRecordsAsync(ListServerHdaUpgradeRecordsRequest listServerHdaUpgradeRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/access-agent/upgrade-record", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerHdaUpgradeRecordsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListServerHdaUpgradeRecordsResponse>(response);
        }

        public AsyncInvoker<ListServerHdaUpgradeRecordsResponse> ListServerHdaUpgradeRecordsAsyncInvoker(ListServerHdaUpgradeRecordsRequest listServerHdaUpgradeRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/access-agent/upgrade-record", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerHdaUpgradeRecordsRequest);
            return new AsyncInvoker<ListServerHdaUpgradeRecordsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServerHdaUpgradeRecordsResponse>);
        }
        
        /// <summary>
        /// 查询指定时间范围指定指标的指定粒度的监控数据
        ///
        /// 查询指定时间范围指定指标的指定粒度的监控数据，可以通过参数指定需要查询的数据维度。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListServerMetricDataResponse> ListServerMetricDataAsync(ListServerMetricDataRequest listServerMetricDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", listServerMetricDataRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/server-metric-data/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerMetricDataRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListServerMetricDataResponse>(response);
        }

        public AsyncInvoker<ListServerMetricDataResponse> ListServerMetricDataAsyncInvoker(ListServerMetricDataRequest listServerMetricDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", listServerMetricDataRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/server-metric-data/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerMetricDataRequest);
            return new AsyncInvoker<ListServerMetricDataResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServerMetricDataResponse>);
        }
        
        /// <summary>
        /// 查询服务器列表
        ///
        /// 查询服务器列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListServersResponse> ListServersAsync(ListServersRequest listServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListServersResponse>(response);
        }

        public AsyncInvoker<ListServersResponse> ListServersAsyncInvoker(ListServersRequest listServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServersRequest);
            return new AsyncInvoker<ListServersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServersResponse>);
        }
        
        /// <summary>
        /// 重装服务器
        ///
        /// 重装服务器。
        /// &gt; - 使用服务器原有的镜像进行重装，当服务器异常无法恢复时或者服务器运行时间久了，性能下降时，可选择重建服务器。注意：重装时系统盘的数据将会被清理掉。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ReinstallServerResponse> ReinstallServerAsync(ReinstallServerRequest reinstallServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", reinstallServerRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/{server_id}/actions/reinstall", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", reinstallServerRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ReinstallServerResponse>(response);
        }

        public AsyncInvoker<ReinstallServerResponse> ReinstallServerAsyncInvoker(ReinstallServerRequest reinstallServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", reinstallServerRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/{server_id}/actions/reinstall", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", reinstallServerRequest);
            return new AsyncInvoker<ReinstallServerResponse>(this, "POST", request, JsonUtils.DeSerialize<ReinstallServerResponse>);
        }
        
        /// <summary>
        /// 查询租户的HDA最新版本
        ///
        /// 查询租户的HDA最新版本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAccessAgentLatestVersionResponse> ShowAccessAgentLatestVersionAsync(ShowAccessAgentLatestVersionRequest showAccessAgentLatestVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/access-agent/latest-version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAccessAgentLatestVersionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAccessAgentLatestVersionResponse>(response);
        }

        public AsyncInvoker<ShowAccessAgentLatestVersionResponse> ShowAccessAgentLatestVersionAsyncInvoker(ShowAccessAgentLatestVersionRequest showAccessAgentLatestVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/access-agent/latest-version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAccessAgentLatestVersionRequest);
            return new AsyncInvoker<ShowAccessAgentLatestVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAccessAgentLatestVersionResponse>);
        }
        
        /// <summary>
        /// 查询指定服务器
        ///
        /// 查询指定的服务器当前这个接口的查询数据和list查询的一致。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowServerResponse> ShowServerAsync(ShowServerRequest showServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", showServerRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowServerResponse>(response);
        }

        public AsyncInvoker<ShowServerResponse> ShowServerAsyncInvoker(ShowServerRequest showServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", showServerRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerRequest);
            return new AsyncInvoker<ShowServerResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowServerResponse>);
        }
        
        /// <summary>
        /// 查询云应用服务器监控信息
        ///
        /// 该接口可获取某一计算机在一段时间段(范围：1小时到30天)的数据信息（例如CPU占用率、内存占用率、用户的在线时间段等），最长数据保存时间不能超过180天。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowServerMetricDataResponse> ShowServerMetricDataAsync(ShowServerMetricDataRequest showServerMetricDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", showServerMetricDataRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/metric-data/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerMetricDataRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowServerMetricDataResponse>(response);
        }

        public AsyncInvoker<ShowServerMetricDataResponse> ShowServerMetricDataAsyncInvoker(ShowServerMetricDataRequest showServerMetricDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", showServerMetricDataRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/metric-data/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerMetricDataRequest);
            return new AsyncInvoker<ShowServerMetricDataResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowServerMetricDataResponse>);
        }
        
        /// <summary>
        /// 获取VNC远程登录地址
        ///
        /// 获取VNC远程登录地址。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowServerVncResponse> ShowServerVncAsync(ShowServerVncRequest showServerVncRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", showServerVncRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/{server_id}/actions/vnc", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerVncRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowServerVncResponse>(response);
        }

        public AsyncInvoker<ShowServerVncResponse> ShowServerVncAsyncInvoker(ShowServerVncRequest showServerVncRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", showServerVncRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/{server_id}/actions/vnc", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerVncRequest);
            return new AsyncInvoker<ShowServerVncResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowServerVncResponse>);
        }
        
        /// <summary>
        /// 修改服务器
        ///
        /// 修改服务器。
        /// &gt; - 服务器的状态修改为维护模式后，用户打开应用，选择可用的服务器进行接入的时候，会过滤掉处于维护模式的服务器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateServerResponse> UpdateServerAsync(UpdateServerRequest updateServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", updateServerRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateServerRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerializeNull<UpdateServerResponse>(response);
        }

        public AsyncInvoker<UpdateServerResponse> UpdateServerAsyncInvoker(UpdateServerRequest updateServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_id", updateServerRequest.ServerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateServerRequest);
            return new AsyncInvoker<UpdateServerResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<UpdateServerResponse>);
        }
        
        /// <summary>
        /// 创建服务器组
        ///
        /// 创建服务器组。
        /// &gt; - 服务器组是一组相同配置的服务器集合，服务器组内的服务器使用同一镜像创建，配置相同，运行相同的应用程序。用户在打开云应用时，会根据调度规则选取组内的一台可用服务器进行连接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateServerGroupResponse> CreateServerGroupAsync(CreateServerGroupRequest createServerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createServerGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateServerGroupResponse>(response);
        }

        public AsyncInvoker<CreateServerGroupResponse> CreateServerGroupAsyncInvoker(CreateServerGroupRequest createServerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createServerGroupRequest);
            return new AsyncInvoker<CreateServerGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateServerGroupResponse>);
        }
        
        /// <summary>
        /// 删除服务器组
        ///
        /// 删除服务器组。
        /// - &gt; 删除服务器组之前，需要先删除服务器组内的所有服务器。如果传服务器组已被删除，重复执行删除，则返回成功响应。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteServerGroupsResponse> DeleteServerGroupsAsync(DeleteServerGroupsRequest deleteServerGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_group_id", deleteServerGroupsRequest.ServerGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-groups/{server_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServerGroupsRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteServerGroupsResponse>(response);
        }

        public AsyncInvoker<DeleteServerGroupsResponse> DeleteServerGroupsAsyncInvoker(DeleteServerGroupsRequest deleteServerGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_group_id", deleteServerGroupsRequest.ServerGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-groups/{server_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServerGroupsRequest);
            return new AsyncInvoker<DeleteServerGroupsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteServerGroupsResponse>);
        }
        
        /// <summary>
        /// 查询服务器组列表
        ///
        /// 查询服务器组列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListServerGroupsResponse> ListServerGroupsAsync(ListServerGroupsRequest listServerGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerGroupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListServerGroupsResponse>(response);
        }

        public AsyncInvoker<ListServerGroupsResponse> ListServerGroupsAsyncInvoker(ListServerGroupsRequest listServerGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerGroupsRequest);
            return new AsyncInvoker<ListServerGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServerGroupsResponse>);
        }
        
        /// <summary>
        /// 查询租户服务器组基础信息列表
        ///
        /// 查询租户服务器组基础信息列表(用于创建应用组时绑定服务器组)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTenantServerGroupsResponse> ListTenantServerGroupsAsync(ListTenantServerGroupsRequest listTenantServerGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-groups/actions/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantServerGroupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTenantServerGroupsResponse>(response);
        }

        public AsyncInvoker<ListTenantServerGroupsResponse> ListTenantServerGroupsAsyncInvoker(ListTenantServerGroupsRequest listTenantServerGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-groups/actions/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantServerGroupsRequest);
            return new AsyncInvoker<ListTenantServerGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTenantServerGroupsResponse>);
        }
        
        /// <summary>
        /// 查询指定服务器组
        ///
        /// 查询指定的服务器组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowServerGroupResponse> ShowServerGroupAsync(ShowServerGroupRequest showServerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_group_id", showServerGroupRequest.ServerGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-groups/{server_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowServerGroupResponse>(response);
        }

        public AsyncInvoker<ShowServerGroupResponse> ShowServerGroupAsyncInvoker(ShowServerGroupRequest showServerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_group_id", showServerGroupRequest.ServerGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-groups/{server_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerGroupRequest);
            return new AsyncInvoker<ShowServerGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowServerGroupResponse>);
        }
        
        /// <summary>
        /// 指定租户服务器组限制查询
        ///
        /// 指定租户服务器组限制查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowServerGroupRestrictResponse> ShowServerGroupRestrictAsync(ShowServerGroupRestrictRequest showServerGroupRestrictRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-groups/resources/restrict", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerGroupRestrictRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowServerGroupRestrictResponse>(response);
        }

        public AsyncInvoker<ShowServerGroupRestrictResponse> ShowServerGroupRestrictAsyncInvoker(ShowServerGroupRestrictRequest showServerGroupRestrictRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-groups/resources/restrict", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerGroupRestrictRequest);
            return new AsyncInvoker<ShowServerGroupRestrictResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowServerGroupRestrictResponse>);
        }
        
        /// <summary>
        /// 查询指定服务器组内服务器状态
        ///
        /// 查询指定的服务器组内服务器状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowServerGroupStateResponse> ShowServerGroupStateAsync(ShowServerGroupStateRequest showServerGroupStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_group_id", showServerGroupStateRequest.ServerGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-groups/{server_group_id}/state", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerGroupStateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowServerGroupStateResponse>(response);
        }

        public AsyncInvoker<ShowServerGroupStateResponse> ShowServerGroupStateAsyncInvoker(ShowServerGroupStateRequest showServerGroupStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_group_id", showServerGroupStateRequest.ServerGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-groups/{server_group_id}/state", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerGroupStateRequest);
            return new AsyncInvoker<ShowServerGroupStateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowServerGroupStateResponse>);
        }
        
        /// <summary>
        /// 修改服务器组
        ///
        /// 修改服务器组。
        /// - &gt; 修改服务器组的镜像，系统盘大小，OU信息后，已创建的服务器配置不变，新添加的服务器会使用新的配置创建。修改最大会话数后，用户接入服务器组时，会按照最新的配置进行路由计算。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateServerGroupResponse> UpdateServerGroupAsync(UpdateServerGroupRequest updateServerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_group_id", updateServerGroupRequest.ServerGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-groups/{server_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateServerGroupRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerializeNull<UpdateServerGroupResponse>(response);
        }

        public AsyncInvoker<UpdateServerGroupResponse> UpdateServerGroupAsyncInvoker(UpdateServerGroupRequest updateServerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_group_id", updateServerGroupRequest.ServerGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-groups/{server_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateServerGroupRequest);
            return new AsyncInvoker<UpdateServerGroupResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<UpdateServerGroupResponse>);
        }
        
        /// <summary>
        /// 查询应用使用记录
        ///
        /// 查询应用使用记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAppConnectionResponse> ListAppConnectionAsync(ListAppConnectionRequest listAppConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/session/app-connection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppConnectionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListAppConnectionResponse>(response);
        }

        public AsyncInvoker<ListAppConnectionResponse> ListAppConnectionAsyncInvoker(ListAppConnectionRequest listAppConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/session/app-connection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppConnectionRequest);
            return new AsyncInvoker<ListAppConnectionResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAppConnectionResponse>);
        }
        
        /// <summary>
        /// 根据用户名查询当前会话
        ///
        /// 根据用户名查询当前会话。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSessionByUserNameResponse> ListSessionByUserNameAsync(ListSessionByUserNameRequest listSessionByUserNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/session/user-session-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSessionByUserNameRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSessionByUserNameResponse>(response);
        }

        public AsyncInvoker<ListSessionByUserNameResponse> ListSessionByUserNameAsyncInvoker(ListSessionByUserNameRequest listSessionByUserNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/session/user-session-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSessionByUserNameRequest);
            return new AsyncInvoker<ListSessionByUserNameResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSessionByUserNameResponse>);
        }
        
        /// <summary>
        /// 查询用户会话列表
        ///
        /// 查询用户会话列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSessionsResponse> ListSessionsAsync(ListSessionsRequest listSessionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/session/list-sessions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSessionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSessionsResponse>(response);
        }

        public AsyncInvoker<ListSessionsResponse> ListSessionsAsyncInvoker(ListSessionsRequest listSessionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/session/list-sessions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSessionsRequest);
            return new AsyncInvoker<ListSessionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSessionsResponse>);
        }
        
        /// <summary>
        /// 查询用户登录记录
        ///
        /// 查询用户登录记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListUserConnectionResponse> ListUserConnectionAsync(ListUserConnectionRequest listUserConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/session/user-connection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserConnectionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListUserConnectionResponse>(response);
        }

        public AsyncInvoker<ListUserConnectionResponse> ListUserConnectionAsyncInvoker(ListUserConnectionRequest listUserConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/session/user-connection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserConnectionRequest);
            return new AsyncInvoker<ListUserConnectionResponse>(this, "POST", request, JsonUtils.DeSerialize<ListUserConnectionResponse>);
        }
        
        /// <summary>
        /// 用户会话注销
        ///
        /// 用户会话注销。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<LogoffUserSessionResponse> LogoffUserSessionAsync(LogoffUserSessionRequest logoffUserSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/session/logoff", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", logoffUserSessionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<LogoffUserSessionResponse>(response);
        }

        public AsyncInvoker<LogoffUserSessionResponse> LogoffUserSessionAsyncInvoker(LogoffUserSessionRequest logoffUserSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/session/logoff", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", logoffUserSessionRequest);
            return new AsyncInvoker<LogoffUserSessionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<LogoffUserSessionResponse>);
        }
        
        /// <summary>
        /// 批量添加服务器组标签
        ///
        /// 此接口为幂等接口：
        /// 同时对多个服务器组批量添加标签，最大支持100个服务器组，每个服务器组最大20个标签
        /// 创建时如果请求体中存在重复key则报错。        
        /// 创建时，不允许设置重复key数据,如果数据库已存在该key，就覆盖value的值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateServerGroupTagsResponse> BatchCreateServerGroupTagsAsync(BatchCreateServerGroupTagsRequest batchCreateServerGroupTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/server-group/tags/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateServerGroupTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateServerGroupTagsResponse>(response);
        }

        public AsyncInvoker<BatchCreateServerGroupTagsResponse> BatchCreateServerGroupTagsAsyncInvoker(BatchCreateServerGroupTagsRequest batchCreateServerGroupTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/server-group/tags/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateServerGroupTagsRequest);
            return new AsyncInvoker<BatchCreateServerGroupTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateServerGroupTagsResponse>);
        }
        
        /// <summary>
        /// 批量删除服务器组标签
        ///
        /// 此接口为幂等接口：
        /// 同时对多个服务器组批量删除标签，最大支持100个服务器组，每个服务器组最大20个标签。
        /// 删除时，如果删除的标签不存在，默认处理成功，删除时不对标签字符集范围做校验。
        /// 删除时tags结构体不能缺失，key不能为空，或者空字符串。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteServerGroupTagsResponse> BatchDeleteServerGroupTagsAsync(BatchDeleteServerGroupTagsRequest batchDeleteServerGroupTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/server-group/tags/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteServerGroupTagsRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<BatchDeleteServerGroupTagsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteServerGroupTagsResponse> BatchDeleteServerGroupTagsAsyncInvoker(BatchDeleteServerGroupTagsRequest batchDeleteServerGroupTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/server-group/tags/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteServerGroupTagsRequest);
            return new AsyncInvoker<BatchDeleteServerGroupTagsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<BatchDeleteServerGroupTagsResponse>);
        }
        
        /// <summary>
        /// 添加服务器组标签
        ///
        /// 此接口为幂等接口：
        /// 创建时如果请求体中存在重复key则报错。
        /// 创建时，不允许设置重复key数据,如果数据库已存在该key，就覆盖value的值。
        /// 一个服务器组上最多有20个标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateServerGroupTagsResponse> CreateServerGroupTagsAsync(CreateServerGroupTagsRequest createServerGroupTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_group_id", createServerGroupTagsRequest.ServerGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/server-group/{server_group_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createServerGroupTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateServerGroupTagsResponse>(response);
        }

        public AsyncInvoker<CreateServerGroupTagsResponse> CreateServerGroupTagsAsyncInvoker(CreateServerGroupTagsRequest createServerGroupTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_group_id", createServerGroupTagsRequest.ServerGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/server-group/{server_group_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createServerGroupTagsRequest);
            return new AsyncInvoker<CreateServerGroupTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateServerGroupTagsResponse>);
        }
        
        /// <summary>
        /// 删除服务器组标签
        ///
        /// 此接口为幂等接口：
        /// 删除时，如果删除的标签不存在，默认处理成功,删除时不对标签字符集范围做校验。
        /// 删除时tags结构体不能缺失，key不能为空，或者空字符串。
        /// 支持最多每次删除20个标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteServerGroupTagsResponse> DeleteServerGroupTagsAsync(DeleteServerGroupTagsRequest deleteServerGroupTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_group_id", deleteServerGroupTagsRequest.ServerGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/server-group/{server_group_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServerGroupTagsRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteServerGroupTagsResponse>(response);
        }

        public AsyncInvoker<DeleteServerGroupTagsResponse> DeleteServerGroupTagsAsyncInvoker(DeleteServerGroupTagsRequest deleteServerGroupTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_group_id", deleteServerGroupTagsRequest.ServerGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/server-group/{server_group_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServerGroupTagsRequest);
            return new AsyncInvoker<DeleteServerGroupTagsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteServerGroupTagsResponse>);
        }
        
        /// <summary>
        /// 查询租户在所有服务器组上的标签
        ///
        /// 查询租户在所有服务器组上的资源标签集合
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListServerGroupTagResponse> ListServerGroupTagAsync(ListServerGroupTagRequest listServerGroupTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/server-group/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerGroupTagRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListServerGroupTagResponse>(response);
        }

        public AsyncInvoker<ListServerGroupTagResponse> ListServerGroupTagAsyncInvoker(ListServerGroupTagRequest listServerGroupTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/server-group/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerGroupTagRequest);
            return new AsyncInvoker<ListServerGroupTagResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServerGroupTagResponse>);
        }
        
        /// <summary>
        /// 查询服务器组的标签
        ///
        /// 查询指定服务器组的标签信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowServerGroupTagResponse> ShowServerGroupTagAsync(ShowServerGroupTagRequest showServerGroupTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_group_id", showServerGroupTagRequest.ServerGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/server-group/{server_group_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerGroupTagRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowServerGroupTagResponse>(response);
        }

        public AsyncInvoker<ShowServerGroupTagResponse> ShowServerGroupTagAsyncInvoker(ShowServerGroupTagRequest showServerGroupTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("server_group_id", showServerGroupTagRequest.ServerGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/server-group/{server_group_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerGroupTagRequest);
            return new AsyncInvoker<ShowServerGroupTagResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowServerGroupTagResponse>);
        }
        
        /// <summary>
        /// 查询可用磁盘类型
        ///
        /// 该接口用于查询可用磁盘类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListVolumeTypeResponse> ListVolumeTypeAsync(ListVolumeTypeRequest listVolumeTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/volume-type", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVolumeTypeRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListVolumeTypeResponse>(response);
        }

        public AsyncInvoker<ListVolumeTypeResponse> ListVolumeTypeAsyncInvoker(ListVolumeTypeRequest listVolumeTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/volume-type", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVolumeTypeRequest);
            return new AsyncInvoker<ListVolumeTypeResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVolumeTypeResponse>);
        }
        
    }
}