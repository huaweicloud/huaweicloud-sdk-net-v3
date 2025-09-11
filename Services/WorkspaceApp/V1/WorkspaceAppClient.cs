using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.WorkspaceApp.V1.Model;

namespace HuaweiCloud.SDK.WorkspaceApp.V1
{
    public partial class WorkspaceAppClient : Client
    {
        public static ClientBuilder<WorkspaceAppClient> NewBuilder()
        {
            return new ClientBuilder<WorkspaceAppClient>();
        }

        
        /// <summary>
        /// 获取上传至OBS桶的临时ak/sk
        ///
        /// 获取上传至OBS桶的临时ak/sk。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AuthorizeObsResponse AuthorizeObs(AuthorizeObsRequest authorizeObsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-warehouse/action/authorize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", authorizeObsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AuthorizeObsResponse>(response);
        }

        public SyncInvoker<AuthorizeObsResponse> AuthorizeObsInvoker(AuthorizeObsRequest authorizeObsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-warehouse/action/authorize", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", authorizeObsRequest);
            return new SyncInvoker<AuthorizeObsResponse>(this, "POST", request, JsonUtils.DeSerialize<AuthorizeObsResponse>);
        }
        
        /// <summary>
        /// 批量删除应用仓库中的指定应用
        ///
        /// 批量删除应用仓库中的指定应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteWarehouseAppResponse BatchDeleteWarehouseApp(BatchDeleteWarehouseAppRequest batchDeleteWarehouseAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-warehouse/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteWarehouseAppRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteWarehouseAppResponse>(response);
        }

        public SyncInvoker<BatchDeleteWarehouseAppResponse> BatchDeleteWarehouseAppInvoker(BatchDeleteWarehouseAppRequest batchDeleteWarehouseAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-warehouse/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteWarehouseAppRequest);
            return new SyncInvoker<BatchDeleteWarehouseAppResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteWarehouseAppResponse>);
        }
        
        /// <summary>
        /// 添加用户应用仓库桶及桶授权
        ///
        /// 添加用户应用仓库桶及桶授权。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BindAppWarehouseBucketResponse BindAppWarehouseBucket(BindAppWarehouseBucketRequest bindAppWarehouseBucketRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-warehouse/bucket", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", bindAppWarehouseBucketRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BindAppWarehouseBucketResponse>(response);
        }

        public SyncInvoker<BindAppWarehouseBucketResponse> BindAppWarehouseBucketInvoker(BindAppWarehouseBucketRequest bindAppWarehouseBucketRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-warehouse/bucket", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", bindAppWarehouseBucketRequest);
            return new SyncInvoker<BindAppWarehouseBucketResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BindAppWarehouseBucketResponse>);
        }
        
        /// <summary>
        /// 添加桶或者桶授权
        ///
        /// 添加桶或者桶授权。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateBucketOrAclResponse CreateBucketOrAcl(CreateBucketOrAclRequest createBucketOrAclRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-warehouse/bucket-and-acl/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBucketOrAclRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateBucketOrAclResponse>(response);
        }

        public SyncInvoker<CreateBucketOrAclResponse> CreateBucketOrAclInvoker(CreateBucketOrAclRequest createBucketOrAclRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-warehouse/bucket-and-acl/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBucketOrAclRequest);
            return new SyncInvoker<CreateBucketOrAclResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateBucketOrAclResponse>);
        }
        
        /// <summary>
        /// 在应用仓库中新增应用
        ///
        /// 在应用仓库中新增应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateWarehouseAppResponse CreateWarehouseApp(CreateWarehouseAppRequest createWarehouseAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-warehouse/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWarehouseAppRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateWarehouseAppResponse>(response);
        }

        public SyncInvoker<CreateWarehouseAppResponse> CreateWarehouseAppInvoker(CreateWarehouseAppRequest createWarehouseAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-warehouse/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWarehouseAppRequest);
            return new SyncInvoker<CreateWarehouseAppResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateWarehouseAppResponse>);
        }
        
        /// <summary>
        /// 删除应用仓库中的指定应用
        ///
        /// 删除应用仓库中的指定应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteWarehouseAppResponse DeleteWarehouseApp(DeleteWarehouseAppRequest deleteWarehouseAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteWarehouseAppRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-warehouse/apps/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWarehouseAppRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteWarehouseAppResponse>(response);
        }

        public SyncInvoker<DeleteWarehouseAppResponse> DeleteWarehouseAppInvoker(DeleteWarehouseAppRequest deleteWarehouseAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteWarehouseAppRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-warehouse/apps/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWarehouseAppRequest);
            return new SyncInvoker<DeleteWarehouseAppResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteWarehouseAppResponse>);
        }
        
        /// <summary>
        /// 查询租户应用仓库中的应用列表
        ///
        /// 查询租户应用仓库中的应用列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListWarehouseAppsResponse ListWarehouseApps(ListWarehouseAppsRequest listWarehouseAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-warehouse/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWarehouseAppsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListWarehouseAppsResponse>(response);
        }

        public SyncInvoker<ListWarehouseAppsResponse> ListWarehouseAppsInvoker(ListWarehouseAppsRequest listWarehouseAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-warehouse/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWarehouseAppsRequest);
            return new SyncInvoker<ListWarehouseAppsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWarehouseAppsResponse>);
        }
        
        /// <summary>
        /// 查询用户应用仓库桶
        ///
        /// 查询用户应用仓库桶
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAppWarehouseBucketResponse ShowAppWarehouseBucket(ShowAppWarehouseBucketRequest showAppWarehouseBucketRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-warehouse/bucket", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppWarehouseBucketRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAppWarehouseBucketResponse>(response);
        }

        public SyncInvoker<ShowAppWarehouseBucketResponse> ShowAppWarehouseBucketInvoker(ShowAppWarehouseBucketRequest showAppWarehouseBucketRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-warehouse/bucket", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppWarehouseBucketRequest);
            return new SyncInvoker<ShowAppWarehouseBucketResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAppWarehouseBucketResponse>);
        }
        
        /// <summary>
        /// 修改应用仓库中的指定应用信息
        ///
        /// 修改应用仓库中的指定应用信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateWarehouseAppResponse UpdateWarehouseApp(UpdateWarehouseAppRequest updateWarehouseAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateWarehouseAppRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-warehouse/apps/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWarehouseAppRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerializeNull<UpdateWarehouseAppResponse>(response);
        }

        public SyncInvoker<UpdateWarehouseAppResponse> UpdateWarehouseAppInvoker(UpdateWarehouseAppRequest updateWarehouseAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateWarehouseAppRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-warehouse/apps/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWarehouseAppRequest);
            return new SyncInvoker<UpdateWarehouseAppResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<UpdateWarehouseAppResponse>);
        }
        
        /// <summary>
        /// 在应用仓库中上传图标文件
        ///
        /// 在应用仓库中上传图标文件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UploadWarehouseAppIconResponse UploadWarehouseAppIcon(UploadWarehouseAppIconRequest uploadWarehouseAppIconRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-warehouse/apps/icon", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadWarehouseAppIconRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UploadWarehouseAppIconResponse>(response);
        }

        public SyncInvoker<UploadWarehouseAppIconResponse> UploadWarehouseAppIconInvoker(UploadWarehouseAppIconRequest uploadWarehouseAppIconRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-warehouse/apps/icon", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadWarehouseAppIconRequest);
            return new SyncInvoker<UploadWarehouseAppIconResponse>(this, "POST", request, JsonUtils.DeSerialize<UploadWarehouseAppIconResponse>);
        }
        
        /// <summary>
        /// 批量禁用应用
        ///
        /// 批量禁用应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDisableAppResponse BatchDisableApp(BatchDisableAppRequest batchDisableAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDisableAppRequest.AppGroupId, out var valueOfAppGroupId)) urlParam.Add("app_group_id", valueOfAppGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps/actions/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDisableAppRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDisableAppResponse>(response);
        }

        public SyncInvoker<BatchDisableAppResponse> BatchDisableAppInvoker(BatchDisableAppRequest batchDisableAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDisableAppRequest.AppGroupId, out var valueOfAppGroupId)) urlParam.Add("app_group_id", valueOfAppGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps/actions/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDisableAppRequest);
            return new SyncInvoker<BatchDisableAppResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDisableAppResponse>);
        }
        
        /// <summary>
        /// 批量启用应用
        ///
        /// 批量启用应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchEnableAppResponse BatchEnableApp(BatchEnableAppRequest batchEnableAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchEnableAppRequest.AppGroupId, out var valueOfAppGroupId)) urlParam.Add("app_group_id", valueOfAppGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps/actions/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchEnableAppRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchEnableAppResponse>(response);
        }

        public SyncInvoker<BatchEnableAppResponse> BatchEnableAppInvoker(BatchEnableAppRequest batchEnableAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchEnableAppRequest.AppGroupId, out var valueOfAppGroupId)) urlParam.Add("app_group_id", valueOfAppGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps/actions/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchEnableAppRequest);
            return new SyncInvoker<BatchEnableAppResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchEnableAppResponse>);
        }
        
        /// <summary>
        /// 删除自定义应用图标
        ///
        /// 删除自定义应用应用图标，恢复使用默认应用图标，重复执行会按照成功处理(响应200)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAppIconResponse DeleteAppIcon(DeleteAppIconRequest deleteAppIconRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAppIconRequest.AppGroupId, out var valueOfAppGroupId)) urlParam.Add("app_group_id", valueOfAppGroupId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAppIconRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps/{app_id}/icon", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppIconRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAppIconResponse>(response);
        }

        public SyncInvoker<DeleteAppIconResponse> DeleteAppIconInvoker(DeleteAppIconRequest deleteAppIconRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAppIconRequest.AppGroupId, out var valueOfAppGroupId)) urlParam.Add("app_group_id", valueOfAppGroupId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAppIconRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps/{app_id}/icon", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppIconRequest);
            return new SyncInvoker<DeleteAppIconResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAppIconResponse>);
        }
        
        /// <summary>
        /// 查询已发布应用
        ///
        /// 查询已发布的应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPublishedAppResponse ListPublishedApp(ListPublishedAppRequest listPublishedAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPublishedAppRequest.AppGroupId, out var valueOfAppGroupId)) urlParam.Add("app_group_id", valueOfAppGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublishedAppRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPublishedAppResponse>(response);
        }

        public SyncInvoker<ListPublishedAppResponse> ListPublishedAppInvoker(ListPublishedAppRequest listPublishedAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPublishedAppRequest.AppGroupId, out var valueOfAppGroupId)) urlParam.Add("app_group_id", valueOfAppGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublishedAppRequest);
            return new SyncInvoker<ListPublishedAppResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPublishedAppResponse>);
        }
        
        /// <summary>
        /// 发布应用
        ///
        /// 批量发布应用，不允许发布同名的应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public PublishAppResponse PublishApp(PublishAppRequest publishAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(publishAppRequest.AppGroupId, out var valueOfAppGroupId)) urlParam.Add("app_group_id", valueOfAppGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", publishAppRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<PublishAppResponse>(response);
        }

        public SyncInvoker<PublishAppResponse> PublishAppInvoker(PublishAppRequest publishAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(publishAppRequest.AppGroupId, out var valueOfAppGroupId)) urlParam.Add("app_group_id", valueOfAppGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", publishAppRequest);
            return new SyncInvoker<PublishAppResponse>(this, "POST", request, JsonUtils.DeSerialize<PublishAppResponse>);
        }
        
        /// <summary>
        /// 查询应用详细信息
        ///
        /// 查询应用详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAppDetailResponse ShowAppDetail(ShowAppDetailRequest showAppDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAppDetailRequest.AppGroupId, out var valueOfAppGroupId)) urlParam.Add("app_group_id", valueOfAppGroupId);
            if (StringUtils.TryConvertToNonEmptyString(showAppDetailRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAppDetailResponse>(response);
        }

        public SyncInvoker<ShowAppDetailResponse> ShowAppDetailInvoker(ShowAppDetailRequest showAppDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAppDetailRequest.AppGroupId, out var valueOfAppGroupId)) urlParam.Add("app_group_id", valueOfAppGroupId);
            if (StringUtils.TryConvertToNonEmptyString(showAppDetailRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppDetailRequest);
            return new SyncInvoker<ShowAppDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAppDetailResponse>);
        }
        
        /// <summary>
        /// 可发布应用列表
        ///
        /// 查询应用组下可发布的应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPublishableAppResponse ShowPublishableApp(ShowPublishableAppRequest showPublishableAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPublishableAppRequest.AppGroupId, out var valueOfAppGroupId)) urlParam.Add("app_group_id", valueOfAppGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/publishable-app", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublishableAppRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPublishableAppResponse>(response);
        }

        public SyncInvoker<ShowPublishableAppResponse> ShowPublishableAppInvoker(ShowPublishableAppRequest showPublishableAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPublishableAppRequest.AppGroupId, out var valueOfAppGroupId)) urlParam.Add("app_group_id", valueOfAppGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/publishable-app", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPublishableAppRequest);
            return new SyncInvoker<ShowPublishableAppResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPublishableAppResponse>);
        }
        
        /// <summary>
        /// 批量取消应用发布
        ///
        /// 批量取消应用发布。
        /// &gt; - 批量取消应用组下已经发布的应用，应用对应的授权会一起删除，重复执行会按照成功处理(响应200)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UnpublishAppResponse UnpublishApp(UnpublishAppRequest unpublishAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(unpublishAppRequest.AppGroupId, out var valueOfAppGroupId)) urlParam.Add("app_group_id", valueOfAppGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps/batch-unpublish", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unpublishAppRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UnpublishAppResponse>(response);
        }

        public SyncInvoker<UnpublishAppResponse> UnpublishAppInvoker(UnpublishAppRequest unpublishAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(unpublishAppRequest.AppGroupId, out var valueOfAppGroupId)) urlParam.Add("app_group_id", valueOfAppGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps/batch-unpublish", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unpublishAppRequest);
            return new SyncInvoker<UnpublishAppResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UnpublishAppResponse>);
        }
        
        /// <summary>
        /// 修改应用信息
        ///
        /// 编辑修改应用信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAppResponse UpdateApp(UpdateAppRequest updateAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAppRequest.AppGroupId, out var valueOfAppGroupId)) urlParam.Add("app_group_id", valueOfAppGroupId);
            if (StringUtils.TryConvertToNonEmptyString(updateAppRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerialize<UpdateAppResponse>(response);
        }

        public SyncInvoker<UpdateAppResponse> UpdateAppInvoker(UpdateAppRequest updateAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAppRequest.AppGroupId, out var valueOfAppGroupId)) urlParam.Add("app_group_id", valueOfAppGroupId);
            if (StringUtils.TryConvertToNonEmptyString(updateAppRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppRequest);
            return new SyncInvoker<UpdateAppResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpdateAppResponse>);
        }
        
        /// <summary>
        /// 批量设置应用预启动
        ///
        /// 批量设置应用预启动。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePreBootPolicyResponse UpdatePreBootPolicy(UpdatePreBootPolicyRequest updatePreBootPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePreBootPolicyRequest.AppGroupId, out var valueOfAppGroupId)) urlParam.Add("app_group_id", valueOfAppGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps/pre-boot-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePreBootPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UpdatePreBootPolicyResponse>(response);
        }

        public SyncInvoker<UpdatePreBootPolicyResponse> UpdatePreBootPolicyInvoker(UpdatePreBootPolicyRequest updatePreBootPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePreBootPolicyRequest.AppGroupId, out var valueOfAppGroupId)) urlParam.Add("app_group_id", valueOfAppGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps/pre-boot-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePreBootPolicyRequest);
            return new SyncInvoker<UpdatePreBootPolicyResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdatePreBootPolicyResponse>);
        }
        
        /// <summary>
        /// 修改自定义应用图标
        ///
        /// 修改自定义应用图标。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UploadAppIconResponse UploadAppIcon(UploadAppIconRequest uploadAppIconRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(uploadAppIconRequest.AppGroupId, out var valueOfAppGroupId)) urlParam.Add("app_group_id", valueOfAppGroupId);
            if (StringUtils.TryConvertToNonEmptyString(uploadAppIconRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps/{app_id}/icon", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadAppIconRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UploadAppIconResponse>(response);
        }

        public SyncInvoker<UploadAppIconResponse> UploadAppIconInvoker(UploadAppIconRequest uploadAppIconRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(uploadAppIconRequest.AppGroupId, out var valueOfAppGroupId)) urlParam.Add("app_group_id", valueOfAppGroupId);
            if (StringUtils.TryConvertToNonEmptyString(uploadAppIconRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}/apps/{app_id}/icon", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadAppIconRequest);
            return new SyncInvoker<UploadAppIconResponse>(this, "POST", request, JsonUtils.DeSerialize<UploadAppIconResponse>);
        }
        
        /// <summary>
        /// 租户服务激活、初始化
        ///
        /// 租户服务激活。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public InitializeTenantResponse InitializeTenant(InitializeTenantRequest initializeTenantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/tenant/action/active", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", initializeTenantRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<InitializeTenantResponse>(response);
        }

        public SyncInvoker<InitializeTenantResponse> InitializeTenantInvoker(InitializeTenantRequest initializeTenantRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/tenant/action/active", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", initializeTenantRequest);
            return new SyncInvoker<InitializeTenantResponse>(this, "POST", request, JsonUtils.DeSerialize<InitializeTenantResponse>);
        }
        
        /// <summary>
        /// 查询企业系统配置
        ///
        /// 配置加载顺序： 查询企业级配置- -&gt; 查不到则赋默认阿波罗配置- -&gt; 阿波罗没有则不返回。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCorpConfigInfoResponse ListCorpConfigInfo(ListCorpConfigInfoRequest listCorpConfigInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/bundles/batch-query-config-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCorpConfigInfoRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListCorpConfigInfoResponse>(response);
        }

        public SyncInvoker<ListCorpConfigInfoResponse> ListCorpConfigInfoInvoker(ListCorpConfigInfoRequest listCorpConfigInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/bundles/batch-query-config-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCorpConfigInfoRequest);
            return new SyncInvoker<ListCorpConfigInfoResponse>(this, "POST", request, JsonUtils.DeSerialize<ListCorpConfigInfoResponse>);
        }
        
        /// <summary>
        /// 查询租户信息
        ///
        /// 查询租户信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTenantProfileResponse ListTenantProfile(ListTenantProfileRequest listTenantProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/tenant/profile", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantProfileRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTenantProfileResponse>(response);
        }

        public SyncInvoker<ListTenantProfileResponse> ListTenantProfileInvoker(ListTenantProfileRequest listTenantProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/tenant/profile", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantProfileRequest);
            return new SyncInvoker<ListTenantProfileResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTenantProfileResponse>);
        }
        
        /// <summary>
        /// 批量删除应用组
        ///
        /// 批量删除应用组,重复执行会按照成功处理(响应200)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteAppGroupResponse BatchDeleteAppGroup(BatchDeleteAppGroupRequest batchDeleteAppGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAppGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteAppGroupResponse>(response);
        }

        public SyncInvoker<BatchDeleteAppGroupResponse> BatchDeleteAppGroupInvoker(BatchDeleteAppGroupRequest batchDeleteAppGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAppGroupRequest);
            return new SyncInvoker<BatchDeleteAppGroupResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteAppGroupResponse>);
        }
        
        /// <summary>
        /// 校验应用组
        ///
        /// 校验应用组是否符合指定的规则。
        /// 1. 校验应用组名称是否符合规则。
        /// 2. 校验应用组名称是否重复。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CheckAppGroupResponse CheckAppGroup(CheckAppGroupRequest checkAppGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/rules/validate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkAppGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CheckAppGroupResponse>(response);
        }

        public SyncInvoker<CheckAppGroupResponse> CheckAppGroupInvoker(CheckAppGroupRequest checkAppGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/rules/validate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkAppGroupRequest);
            return new SyncInvoker<CheckAppGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CheckAppGroupResponse>);
        }
        
        /// <summary>
        /// 创建应用组
        ///
        /// 该API用于创建应用组。
        /// &gt; - 应用服务器中安装了不同的应用，这些应用可以组成不同的应用组，进行集中的管理和维护，向用户(组)发布。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAppGroupResponse CreateAppGroup(CreateAppGroupRequest createAppGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAppGroupResponse>(response);
        }

        public SyncInvoker<CreateAppGroupResponse> CreateAppGroupInvoker(CreateAppGroupRequest createAppGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppGroupRequest);
            return new SyncInvoker<CreateAppGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAppGroupResponse>);
        }
        
        /// <summary>
        /// 应用组删除
        ///
        /// 删除指定的应用组,重复执行会按照成功处理(响应200)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAppGroupResponse DeleteAppGroup(DeleteAppGroupRequest deleteAppGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAppGroupRequest.AppGroupId, out var valueOfAppGroupId)) urlParam.Add("app_group_id", valueOfAppGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAppGroupResponse>(response);
        }

        public SyncInvoker<DeleteAppGroupResponse> DeleteAppGroupInvoker(DeleteAppGroupRequest deleteAppGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAppGroupRequest.AppGroupId, out var valueOfAppGroupId)) urlParam.Add("app_group_id", valueOfAppGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppGroupRequest);
            return new SyncInvoker<DeleteAppGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAppGroupResponse>);
        }
        
        /// <summary>
        /// 解除服务组关联的所有应用组
        ///
        /// 解除服务组关联的所有应用组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisassociateAppGroupResponse DisassociateAppGroup(DisassociateAppGroupRequest disassociateAppGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/actions/disassociate-app-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateAppGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DisassociateAppGroupResponse>(response);
        }

        public SyncInvoker<DisassociateAppGroupResponse> DisassociateAppGroupInvoker(DisassociateAppGroupRequest disassociateAppGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/actions/disassociate-app-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateAppGroupRequest);
            return new SyncInvoker<DisassociateAppGroupResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DisassociateAppGroupResponse>);
        }
        
        /// <summary>
        /// 查询应用组
        ///
        /// 查询用户创建的应用组，按照名称、授权类型分页查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAppGroupResponse ListAppGroup(ListAppGroupRequest listAppGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAppGroupResponse>(response);
        }

        public SyncInvoker<ListAppGroupResponse> ListAppGroupInvoker(ListAppGroupRequest listAppGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppGroupRequest);
            return new SyncInvoker<ListAppGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAppGroupResponse>);
        }
        
        /// <summary>
        /// 查询应用组详情
        ///
        /// 查询应用组详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAppGroupDetailResponse ShowAppGroupDetail(ShowAppGroupDetailRequest showAppGroupDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAppGroupDetailRequest.AppGroupId, out var valueOfAppGroupId)) urlParam.Add("app_group_id", valueOfAppGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppGroupDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAppGroupDetailResponse>(response);
        }

        public SyncInvoker<ShowAppGroupDetailResponse> ShowAppGroupDetailInvoker(ShowAppGroupDetailRequest showAppGroupDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAppGroupDetailRequest.AppGroupId, out var valueOfAppGroupId)) urlParam.Add("app_group_id", valueOfAppGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppGroupDetailRequest);
            return new SyncInvoker<ShowAppGroupDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAppGroupDetailResponse>);
        }
        
        /// <summary>
        /// 修改应用组
        ///
        /// 修改应用组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAppGroupResponse UpdateAppGroup(UpdateAppGroupRequest updateAppGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAppGroupRequest.AppGroupId, out var valueOfAppGroupId)) urlParam.Add("app_group_id", valueOfAppGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppGroupRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerialize<UpdateAppGroupResponse>(response);
        }

        public SyncInvoker<UpdateAppGroupResponse> UpdateAppGroupInvoker(UpdateAppGroupRequest updateAppGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAppGroupRequest.AppGroupId, out var valueOfAppGroupId)) urlParam.Add("app_group_id", valueOfAppGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/{app_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAppGroupRequest);
            return new SyncInvoker<UpdateAppGroupResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpdateAppGroupResponse>);
        }
        
        /// <summary>
        /// 创建订单
        ///
        /// 创建订单。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateOrderResponse CreateOrder(CreateOrderRequest createOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/bundles/subscribe/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrderRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateOrderResponse>(response);
        }

        public SyncInvoker<CreateOrderResponse> CreateOrderInvoker(CreateOrderRequest createOrderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/bundles/subscribe/order", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrderRequest);
            return new SyncInvoker<CreateOrderResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateOrderResponse>);
        }
        
        /// <summary>
        /// 查询云应用套餐
        ///
        /// 查询云应用套餐，按照条件过滤。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProductResponse ListProduct(ListProductRequest listProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/product", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProductRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListProductResponse>(response);
        }

        public SyncInvoker<ListProductResponse> ListProductInvoker(ListProductRequest listProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/product", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProductRequest);
            return new SyncInvoker<ListProductResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProductResponse>);
        }
        
        /// <summary>
        /// 查询会话套餐列表
        ///
        /// 该接口用于查询会话套餐列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSessionTypeResponse ListSessionType(ListSessionTypeRequest listSessionTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/session-type", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSessionTypeRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSessionTypeResponse>(response);
        }

        public SyncInvoker<ListSessionTypeResponse> ListSessionTypeInvoker(ListSessionTypeRequest listSessionTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/session-type", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSessionTypeRequest);
            return new SyncInvoker<ListSessionTypeResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSessionTypeResponse>);
        }
        
        /// <summary>
        /// 查询会话套餐列表（已废弃）
        ///
        /// 该接口用于查询会话套餐列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSessionTypesResponse ShowSessionTypes(ShowSessionTypesRequest showSessionTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/session-type", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSessionTypesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowSessionTypesResponse>(response);
        }

        public SyncInvoker<ShowSessionTypesResponse> ShowSessionTypesInvoker(ShowSessionTypesRequest showSessionTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/session-type", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSessionTypesRequest);
            return new SyncInvoker<ShowSessionTypesResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowSessionTypesResponse>);
        }
        
        /// <summary>
        /// 增加应用组授权
        ///
        /// 应用组添加用户授权，授权后用户就获得应用组下所有已发布应用的权限访问。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddAppGroupAuthorizationResponse AddAppGroupAuthorization(AddAppGroupAuthorizationRequest addAppGroupAuthorizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/authorizations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAppGroupAuthorizationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<AddAppGroupAuthorizationResponse>(response);
        }

        public SyncInvoker<AddAppGroupAuthorizationResponse> AddAppGroupAuthorizationInvoker(AddAppGroupAuthorizationRequest addAppGroupAuthorizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/authorizations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAppGroupAuthorizationRequest);
            return new SyncInvoker<AddAppGroupAuthorizationResponse>(this, "POST", request, JsonUtils.DeSerializeNull<AddAppGroupAuthorizationResponse>);
        }
        
        /// <summary>
        /// 移除应用组授权
        ///
        /// 移除应用组内的指定用户的授权，用户授权删除后，用户将没有权限访问应用组内的任何应用。注意：重复执行会按照操作成功处理。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteAppGroupAuthorizationResponse BatchDeleteAppGroupAuthorization(BatchDeleteAppGroupAuthorizationRequest batchDeleteAppGroupAuthorizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/actions/batch-delete-authorization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAppGroupAuthorizationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteAppGroupAuthorizationResponse>(response);
        }

        public SyncInvoker<BatchDeleteAppGroupAuthorizationResponse> BatchDeleteAppGroupAuthorizationInvoker(BatchDeleteAppGroupAuthorizationRequest batchDeleteAppGroupAuthorizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/actions/batch-delete-authorization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAppGroupAuthorizationRequest);
            return new SyncInvoker<BatchDeleteAppGroupAuthorizationResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteAppGroupAuthorizationResponse>);
        }
        
        /// <summary>
        /// 查询应用组授权记录
        ///
        /// 查询应用内已授权的用户列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAppGroupAuthorizationResponse ListAppGroupAuthorization(ListAppGroupAuthorizationRequest listAppGroupAuthorizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/actions/list-authorizations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppGroupAuthorizationRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAppGroupAuthorizationResponse>(response);
        }

        public SyncInvoker<ListAppGroupAuthorizationResponse> ListAppGroupAuthorizationInvoker(ListAppGroupAuthorizationRequest listAppGroupAuthorizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-groups/actions/list-authorizations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppGroupAuthorizationRequest);
            return new SyncInvoker<ListAppGroupAuthorizationResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAppGroupAuthorizationResponse>);
        }
        
        /// <summary>
        /// 查询可用分区列表
        ///
        /// 该接口用于查询支持的可用分区列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAvailabilityZoneResponse ListAvailabilityZone(ListAvailabilityZoneRequest listAvailabilityZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/availability-zone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailabilityZoneRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAvailabilityZoneResponse>(response);
        }

        public SyncInvoker<ListAvailabilityZoneResponse> ListAvailabilityZoneInvoker(ListAvailabilityZoneRequest listAvailabilityZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/availability-zone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailabilityZoneRequest);
            return new SyncInvoker<ListAvailabilityZoneResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAvailabilityZoneResponse>);
        }
        
        /// <summary>
        /// 查询可用分区列表
        ///
        /// [该接口用于查询支持的可用分区列表，按站点分类。](tag:HW)[该接口用于查询支持的可用分区列表。](tag:HCS)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAzResponse ListAz(ListAzRequest listAzRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/availability-zone/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAzRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAzResponse>(response);
        }

        public SyncInvoker<ListAzResponse> ListAzInvoker(ListAzRequest listAzRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/availability-zone/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAzRequest);
            return new SyncInvoker<ListAzResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAzResponse>);
        }
        
        /// <summary>
        /// 批量删除云存储
        ///
        /// 批量删除云存储。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteCloudStorageResponse BatchDeleteCloudStorage(BatchDeleteCloudStorageRequest batchDeleteCloudStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloud-storages/actions/batch-delete-cloud-storages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteCloudStorageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteCloudStorageResponse>(response);
        }

        public SyncInvoker<BatchDeleteCloudStorageResponse> BatchDeleteCloudStorageInvoker(BatchDeleteCloudStorageRequest batchDeleteCloudStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloud-storages/actions/batch-delete-cloud-storages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteCloudStorageRequest);
            return new SyncInvoker<BatchDeleteCloudStorageResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteCloudStorageResponse>);
        }
        
        /// <summary>
        /// 创建项目配置关联
        ///
        /// 创建项目配置关联，目前仅支持关联项目配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateCloudStorageResponse CreateCloudStorage(CreateCloudStorageRequest createCloudStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloud-storages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCloudStorageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateCloudStorageResponse>(response);
        }

        public SyncInvoker<CreateCloudStorageResponse> CreateCloudStorageInvoker(CreateCloudStorageRequest createCloudStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloud-storages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCloudStorageRequest);
            return new SyncInvoker<CreateCloudStorageResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateCloudStorageResponse>);
        }
        
        /// <summary>
        /// 创建个人文件夹
        ///
        /// 创建个人文件夹，已存在对应目录时，仅更新策略不会重复创建目录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateUserFolderAssignmentResponse CreateUserFolderAssignment(CreateUserFolderAssignmentRequest createUserFolderAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createUserFolderAssignmentRequest.StorageId, out var valueOfStorageId)) urlParam.Add("storage_id", valueOfStorageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloud-storages/{storage_id}/actions/create-folder", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUserFolderAssignmentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateUserFolderAssignmentResponse>(response);
        }

        public SyncInvoker<CreateUserFolderAssignmentResponse> CreateUserFolderAssignmentInvoker(CreateUserFolderAssignmentRequest createUserFolderAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createUserFolderAssignmentRequest.StorageId, out var valueOfStorageId)) urlParam.Add("storage_id", valueOfStorageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloud-storages/{storage_id}/actions/create-folder", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUserFolderAssignmentRequest);
            return new SyncInvoker<CreateUserFolderAssignmentResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateUserFolderAssignmentResponse>);
        }
        
        /// <summary>
        /// 删除云存储
        ///
        /// 删除共享存储，只会解除NAS与项目配置之间的关联关系。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteCloudStorageResponse DeleteCloudStorage(DeleteCloudStorageRequest deleteCloudStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteCloudStorageRequest.StorageId, out var valueOfStorageId)) urlParam.Add("storage_id", valueOfStorageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloud-storages/{storage_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCloudStorageRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteCloudStorageResponse>(response);
        }

        public SyncInvoker<DeleteCloudStorageResponse> DeleteCloudStorageInvoker(DeleteCloudStorageRequest deleteCloudStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteCloudStorageRequest.StorageId, out var valueOfStorageId)) urlParam.Add("storage_id", valueOfStorageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloud-storages/{storage_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCloudStorageRequest);
            return new SyncInvoker<DeleteCloudStorageResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteCloudStorageResponse>);
        }
        
        /// <summary>
        /// 删除个人文件夹
        ///
        /// 删除个人存储目录，个人目录中的数据也将永久删除且无法恢复。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteCloudStorageAttachmentResponse DeleteCloudStorageAttachment(DeleteCloudStorageAttachmentRequest deleteCloudStorageAttachmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteCloudStorageAttachmentRequest.StorageId, out var valueOfStorageId)) urlParam.Add("storage_id", valueOfStorageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloud-storages/{storage_id}/actions/delete-folder", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCloudStorageAttachmentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteCloudStorageAttachmentResponse>(response);
        }

        public SyncInvoker<DeleteCloudStorageAttachmentResponse> DeleteCloudStorageAttachmentInvoker(DeleteCloudStorageAttachmentRequest deleteCloudStorageAttachmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteCloudStorageAttachmentRequest.StorageId, out var valueOfStorageId)) urlParam.Add("storage_id", valueOfStorageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloud-storages/{storage_id}/actions/delete-folder", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCloudStorageAttachmentRequest);
            return new SyncInvoker<DeleteCloudStorageAttachmentResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteCloudStorageAttachmentResponse>);
        }
        
        /// <summary>
        /// 查询云存储
        ///
        /// 查询云存储。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCloudStorageResponse ListCloudStorage(ListCloudStorageRequest listCloudStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloud-storages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloudStorageRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCloudStorageResponse>(response);
        }

        public SyncInvoker<ListCloudStorageResponse> ListCloudStorageInvoker(ListCloudStorageRequest listCloudStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloud-storages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloudStorageRequest);
            return new SyncInvoker<ListCloudStorageResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCloudStorageResponse>);
        }
        
        /// <summary>
        /// 查询个人文件夹列表
        ///
        /// 查询个人文件夹列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCloudStorageAssignmentResponse ListCloudStorageAssignment(ListCloudStorageAssignmentRequest listCloudStorageAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloud-storages/actions/list-folders", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloudStorageAssignmentRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCloudStorageAssignmentResponse>(response);
        }

        public SyncInvoker<ListCloudStorageAssignmentResponse> ListCloudStorageAssignmentInvoker(ListCloudStorageAssignmentRequest listCloudStorageAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloud-storages/actions/list-folders", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCloudStorageAssignmentRequest);
            return new SyncInvoker<ListCloudStorageAssignmentResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCloudStorageAssignmentResponse>);
        }
        
        /// <summary>
        /// 查询文件夹和文件信息
        ///
        /// 查询指定目录下文件夹和文件信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFoldersAndFilesResponse ListFoldersAndFiles(ListFoldersAndFilesRequest listFoldersAndFilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloud-storages/actions/list-folder-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFoldersAndFilesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFoldersAndFilesResponse>(response);
        }

        public SyncInvoker<ListFoldersAndFilesResponse> ListFoldersAndFilesInvoker(ListFoldersAndFilesRequest listFoldersAndFilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloud-storages/actions/list-folder-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFoldersAndFilesRequest);
            return new SyncInvoker<ListFoldersAndFilesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFoldersAndFilesResponse>);
        }
        
        /// <summary>
        /// 查询项目配置列表
        ///
        /// 查询项目配置列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProjectConfigsResponse ListProjectConfigs(ListProjectConfigsRequest listProjectConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloud-storages/actions/list-project-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectConfigsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListProjectConfigsResponse>(response);
        }

        public SyncInvoker<ListProjectConfigsResponse> ListProjectConfigsInvoker(ListProjectConfigsRequest listProjectConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloud-storages/actions/list-project-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectConfigsRequest);
            return new SyncInvoker<ListProjectConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProjectConfigsResponse>);
        }
        
        /// <summary>
        /// 重置userprofile
        ///
        /// 重置userprofile，初始化或重置并备份userprofile。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetUserProfileResponse ResetUserProfile(ResetUserProfileRequest resetUserProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloud-storages/actions/reset-userprofile", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetUserProfileRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ResetUserProfileResponse>(response);
        }

        public SyncInvoker<ResetUserProfileResponse> ResetUserProfileInvoker(ResetUserProfileRequest resetUserProfileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloud-storages/actions/reset-userprofile", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetUserProfileRequest);
            return new SyncInvoker<ResetUserProfileResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ResetUserProfileResponse>);
        }
        
        /// <summary>
        /// 查询项目配置信息
        ///
        /// 查询项目配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowProjectConfigResponse ShowProjectConfig(ShowProjectConfigRequest showProjectConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectConfigRequest.CloudStorageId, out var valueOfCloudStorageId)) urlParam.Add("cloud_storage_id", valueOfCloudStorageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloud-storages/actions/project-config/{cloud_storage_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectConfigResponse>(response);
        }

        public SyncInvoker<ShowProjectConfigResponse> ShowProjectConfigInvoker(ShowProjectConfigRequest showProjectConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectConfigRequest.CloudStorageId, out var valueOfCloudStorageId)) urlParam.Add("cloud_storage_id", valueOfCloudStorageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloud-storages/actions/project-config/{cloud_storage_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectConfigRequest);
            return new SyncInvoker<ShowProjectConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectConfigResponse>);
        }
        
        /// <summary>
        /// 文件流转
        ///
        /// 云存储文件流转与分享
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public TransferFileResponse TransferFile(TransferFileRequest transferFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloud-storages/actions/transfer-file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", transferFileRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<TransferFileResponse>(response);
        }

        public SyncInvoker<TransferFileResponse> TransferFileInvoker(TransferFileRequest transferFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloud-storages/actions/transfer-file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", transferFileRequest);
            return new SyncInvoker<TransferFileResponse>(this, "POST", request, JsonUtils.DeSerialize<TransferFileResponse>);
        }
        
        /// <summary>
        /// 文件预流转
        ///
        /// 文件预流转，在接收方接收文件前返回可用的文件路径
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public TransferFilePreResponse TransferFilePre(TransferFilePreRequest transferFilePreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloud-storages/actions/pre-transfer-file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", transferFilePreRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<TransferFilePreResponse>(response);
        }

        public SyncInvoker<TransferFilePreResponse> TransferFilePreInvoker(TransferFilePreRequest transferFilePreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloud-storages/actions/pre-transfer-file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", transferFilePreRequest);
            return new SyncInvoker<TransferFilePreResponse>(this, "POST", request, JsonUtils.DeSerialize<TransferFilePreResponse>);
        }
        
        /// <summary>
        /// 修改个人文件夹
        ///
        /// 创建个人文件夹。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateCloudUserFolderAssignmentResponse UpdateCloudUserFolderAssignment(UpdateCloudUserFolderAssignmentRequest updateCloudUserFolderAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateCloudUserFolderAssignmentRequest.StorageId, out var valueOfStorageId)) urlParam.Add("storage_id", valueOfStorageId);
            if (StringUtils.TryConvertToNonEmptyString(updateCloudUserFolderAssignmentRequest.CloudAssignmentId, out var valueOfCloudAssignmentId)) urlParam.Add("cloud_assignment_id", valueOfCloudAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloud-storages/{storage_id}/actions/update-folder/{cloud_assignment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCloudUserFolderAssignmentRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerializeNull<UpdateCloudUserFolderAssignmentResponse>(response);
        }

        public SyncInvoker<UpdateCloudUserFolderAssignmentResponse> UpdateCloudUserFolderAssignmentInvoker(UpdateCloudUserFolderAssignmentRequest updateCloudUserFolderAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateCloudUserFolderAssignmentRequest.StorageId, out var valueOfStorageId)) urlParam.Add("storage_id", valueOfStorageId);
            if (StringUtils.TryConvertToNonEmptyString(updateCloudUserFolderAssignmentRequest.CloudAssignmentId, out var valueOfCloudAssignmentId)) urlParam.Add("cloud_assignment_id", valueOfCloudAssignmentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cloud-storages/{storage_id}/actions/update-folder/{cloud_assignment_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCloudUserFolderAssignmentRequest);
            return new SyncInvoker<UpdateCloudUserFolderAssignmentResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<UpdateCloudUserFolderAssignmentResponse>);
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
        public AttachImageServerAppResponse AttachImageServerApp(AttachImageServerAppRequest attachImageServerAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(attachImageServerAppRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-servers/{server_id}/actions/attach-app", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachImageServerAppRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AttachImageServerAppResponse>(response);
        }

        public SyncInvoker<AttachImageServerAppResponse> AttachImageServerAppInvoker(AttachImageServerAppRequest attachImageServerAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(attachImageServerAppRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-servers/{server_id}/actions/attach-app", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", attachImageServerAppRequest);
            return new SyncInvoker<AttachImageServerAppResponse>(this, "POST", request, JsonUtils.DeSerialize<AttachImageServerAppResponse>);
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
        public BatchDeleteImageServerResponse BatchDeleteImageServer(BatchDeleteImageServerRequest batchDeleteImageServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-servers/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteImageServerRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerialize<BatchDeleteImageServerResponse>(response);
        }

        public SyncInvoker<BatchDeleteImageServerResponse> BatchDeleteImageServerInvoker(BatchDeleteImageServerRequest batchDeleteImageServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-servers/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteImageServerRequest);
            return new SyncInvoker<BatchDeleteImageServerResponse>(this, "PATCH", request, JsonUtils.DeSerialize<BatchDeleteImageServerResponse>);
        }
        
        /// <summary>
        /// 创建镜像实例
        ///
        /// 创建镜像实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateImageServerResponse CreateImageServer(CreateImageServerRequest createImageServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createImageServerRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateImageServerResponse>(response);
        }

        public SyncInvoker<CreateImageServerResponse> CreateImageServerInvoker(CreateImageServerRequest createImageServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createImageServerRequest);
            return new SyncInvoker<CreateImageServerResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateImageServerResponse>);
        }
        
        /// <summary>
        /// 查询镜像实例列表
        ///
        /// 查询镜像实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListImageServersResponse ListImageServers(ListImageServersRequest listImageServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImageServersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListImageServersResponse>(response);
        }

        public SyncInvoker<ListImageServersResponse> ListImageServersInvoker(ListImageServersRequest listImageServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImageServersRequest);
            return new SyncInvoker<ListImageServersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListImageServersResponse>);
        }
        
        /// <summary>
        /// 查询最近一次分发软件信息列表
        ///
        /// 查询最近一次分发软件信息列表，返回ID列表，不包含具体信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLatestAttachedServerAppResponse ListLatestAttachedServerApp(ListLatestAttachedServerAppRequest listLatestAttachedServerAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listLatestAttachedServerAppRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-servers/{server_id}/actions/latest-attached-app", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLatestAttachedServerAppRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListLatestAttachedServerAppResponse>(response);
        }

        public SyncInvoker<ListLatestAttachedServerAppResponse> ListLatestAttachedServerAppInvoker(ListLatestAttachedServerAppRequest listLatestAttachedServerAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listLatestAttachedServerAppRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-servers/{server_id}/actions/latest-attached-app", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLatestAttachedServerAppRequest);
            return new SyncInvoker<ListLatestAttachedServerAppResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLatestAttachedServerAppResponse>);
        }
        
        /// <summary>
        /// 构建云应用镜像
        ///
        /// 构建云应用镜像。
        /// * 只允许对状态为 &#x60;实例正常运行&#x60;、&#x60;镜像任务结束&#x60; 的实例构建云应用镜像。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RecreateServerImageResponse RecreateServerImage(RecreateServerImageRequest recreateServerImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(recreateServerImageRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-servers/{server_id}/actions/recreate-image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", recreateServerImageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RecreateServerImageResponse>(response);
        }

        public SyncInvoker<RecreateServerImageResponse> RecreateServerImageInvoker(RecreateServerImageRequest recreateServerImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(recreateServerImageRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-servers/{server_id}/actions/recreate-image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", recreateServerImageRequest);
            return new SyncInvoker<RecreateServerImageResponse>(this, "POST", request, JsonUtils.DeSerialize<RecreateServerImageResponse>);
        }
        
        /// <summary>
        /// 查询指定镜像实例
        ///
        /// 查询指定的镜像实例当前这个接口的查询数据和list查询的一致。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowImageServerResponse ShowImageServer(ShowImageServerRequest showImageServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showImageServerRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-servers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showImageServerRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowImageServerResponse>(response);
        }

        public SyncInvoker<ShowImageServerResponse> ShowImageServerInvoker(ShowImageServerRequest showImageServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showImageServerRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-servers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showImageServerRequest);
            return new SyncInvoker<ShowImageServerResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowImageServerResponse>);
        }
        
        /// <summary>
        /// 修改镜像实例
        ///
        /// 修改镜像实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateImageServerResponse UpdateImageServer(UpdateImageServerRequest updateImageServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateImageServerRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-servers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateImageServerRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerializeNull<UpdateImageServerResponse>(response);
        }

        public SyncInvoker<UpdateImageServerResponse> UpdateImageServerInvoker(UpdateImageServerRequest updateImageServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateImageServerRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-servers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateImageServerRequest);
            return new SyncInvoker<UpdateImageServerResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<UpdateImageServerResponse>);
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
        public BatchDeleteAppSubJobsResponse BatchDeleteAppSubJobs(BatchDeleteAppSubJobsRequest batchDeleteAppSubJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-sub-jobs/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAppSubJobsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteAppSubJobsResponse>(response);
        }

        public SyncInvoker<BatchDeleteAppSubJobsResponse> BatchDeleteAppSubJobsInvoker(BatchDeleteAppSubJobsRequest batchDeleteAppSubJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-sub-jobs/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAppSubJobsRequest);
            return new SyncInvoker<BatchDeleteAppSubJobsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteAppSubJobsResponse>);
        }
        
        /// <summary>
        /// 批量删除镜像子任务
        ///
        /// 批量删除子任务，忽略不存在的服务器并且返回成功响应。
        /// 只能删除以下的两种状态 SUCCESS：成功。 FAILED：失败
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteImageSubJobsResponse BatchDeleteImageSubJobs(BatchDeleteImageSubJobsRequest batchDeleteImageSubJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-server-sub-jobs/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteImageSubJobsRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerializeNull<BatchDeleteImageSubJobsResponse>(response);
        }

        public SyncInvoker<BatchDeleteImageSubJobsResponse> BatchDeleteImageSubJobsInvoker(BatchDeleteImageSubJobsRequest batchDeleteImageSubJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-server-sub-jobs/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteImageSubJobsRequest);
            return new SyncInvoker<BatchDeleteImageSubJobsResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<BatchDeleteImageSubJobsResponse>);
        }
        
        /// <summary>
        /// 镜像子任务数量查询
        ///
        /// 该接口用于查询异步子任务数量,job_type未传递时,
        /// 则查询JobType为CREATE_SERVER|DELETE_SERVER|REJOIN_DOMAIN|CHANGE_SERVER_IMAGE|REINSTALL_OS的子任务总数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CountImageSubJobsResponse CountImageSubJobs(CountImageSubJobsRequest countImageSubJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-server-sub-jobs/actions/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countImageSubJobsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CountImageSubJobsResponse>(response);
        }

        public SyncInvoker<CountImageSubJobsResponse> CountImageSubJobsInvoker(CountImageSubJobsRequest countImageSubJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-server-sub-jobs/actions/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countImageSubJobsRequest);
            return new SyncInvoker<CountImageSubJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<CountImageSubJobsResponse>);
        }
        
        /// <summary>
        /// 子任务数量查询
        ///
        /// 该接口用于查询异步子任务数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CountSubJobsResponse CountSubJobs(CountSubJobsRequest countSubJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-sub-jobs/actions/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countSubJobsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CountSubJobsResponse>(response);
        }

        public SyncInvoker<CountSubJobsResponse> CountSubJobsInvoker(CountSubJobsRequest countSubJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-sub-jobs/actions/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countSubJobsRequest);
            return new SyncInvoker<CountSubJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<CountSubJobsResponse>);
        }
        
        /// <summary>
        /// 查询租户的镜像任务列表
        ///
        /// 该接口用于查询租户的异步任务执行情况。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListImageJobsResponse ListImageJobs(ListImageJobsRequest listImageJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-server-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImageJobsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListImageJobsResponse>(response);
        }

        public SyncInvoker<ListImageJobsResponse> ListImageJobsInvoker(ListImageJobsRequest listImageJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-server-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImageJobsRequest);
            return new SyncInvoker<ListImageJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListImageJobsResponse>);
        }
        
        /// <summary>
        /// 镜像子任务查询
        ///
        /// 该接口用于查询异步子任务执行情况,sub_job_ids非空时offset和limit不会生效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListImageSubJobsResponse ListImageSubJobs(ListImageSubJobsRequest listImageSubJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-server-sub-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImageSubJobsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListImageSubJobsResponse>(response);
        }

        public SyncInvoker<ListImageSubJobsResponse> ListImageSubJobsInvoker(ListImageSubJobsRequest listImageSubJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-server-sub-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImageSubJobsRequest);
            return new SyncInvoker<ListImageSubJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListImageSubJobsResponse>);
        }
        
        /// <summary>
        /// 子任务查询
        ///
        /// 该接口用于查询异步子任务执行情况,sub_job_ids非空时offset和limit不会生效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSubJobsResponse ListSubJobs(ListSubJobsRequest listSubJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-sub-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubJobsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSubJobsResponse>(response);
        }

        public SyncInvoker<ListSubJobsResponse> ListSubJobsInvoker(ListSubJobsRequest listSubJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-sub-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubJobsRequest);
            return new SyncInvoker<ListSubJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSubJobsResponse>);
        }
        
        /// <summary>
        /// 查询镜像任务详情
        ///
        /// 该接口用于查询异步任务的执行情况，比如查询创建镜像实例任务的执行状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowImageJobResponse ShowImageJob(ShowImageJobRequest showImageJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showImageJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-server-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showImageJobRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowImageJobResponse>(response);
        }

        public SyncInvoker<ShowImageJobResponse> ShowImageJobInvoker(ShowImageJobRequest showImageJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showImageJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/image-server-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showImageJobRequest);
            return new SyncInvoker<ShowImageJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowImageJobResponse>);
        }
        
        /// <summary>
        /// 查询任务的执行状态（已废弃）
        ///
        /// 查询Job的执行状态。
        /// 
        /// 对于创建云应用服务器命令下发后会返回job_id，通过job_id可以查询任务的执行状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowJobResponse ShowJob(ShowJobRequest showJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/job/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowJobResponse>(response);
        }

        public SyncInvoker<ShowJobResponse> ShowJobInvoker(ShowJobRequest showJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/job/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobRequest);
            return new SyncInvoker<ShowJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobResponse>);
        }
        
        /// <summary>
        /// 查询任务的执行状态详情
        ///
        /// 查询Job的执行状态。
        /// 
        /// 对于创建云服务器、删除云服务器、重建镜像等异步API，下发命令后会返回job_id，通过job_id可以查询任务的执行状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowJobDetailResponse ShowJobDetail(ShowJobDetailRequest showJobDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showJobDetailRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/job/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowJobDetailResponse>(response);
        }

        public SyncInvoker<ShowJobDetailResponse> ShowJobDetailInvoker(ShowJobDetailRequest showJobDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showJobDetailRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/job/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobDetailRequest);
            return new SyncInvoker<ShowJobDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobDetailResponse>);
        }
        
        /// <summary>
        /// 查询应用组授权邮件发送记录
        ///
        /// 查询应用组授权邮件发送记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuthorizationMailRecordResponse ListAuthorizationMailRecord(ListAuthorizationMailRecordRequest listAuthorizationMailRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/mails", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuthorizationMailRecordRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAuthorizationMailRecordResponse>(response);
        }

        public SyncInvoker<ListAuthorizationMailRecordResponse> ListAuthorizationMailRecordInvoker(ListAuthorizationMailRecordRequest listAuthorizationMailRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/mails", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuthorizationMailRecordRequest);
            return new SyncInvoker<ListAuthorizationMailRecordResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuthorizationMailRecordResponse>);
        }
        
        /// <summary>
        /// 重发应用组授权邮件（根据授权邮件记录）
        ///
        /// 重发应用组授权邮件（根据授权邮件记录）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SendAuthorizationMailResponse SendAuthorizationMail(SendAuthorizationMailRequest sendAuthorizationMailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/mails/actions/send", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendAuthorizationMailRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<SendAuthorizationMailResponse>(response);
        }

        public SyncInvoker<SendAuthorizationMailResponse> SendAuthorizationMailInvoker(SendAuthorizationMailRequest sendAuthorizationMailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/mails/actions/send", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendAuthorizationMailRequest);
            return new SyncInvoker<SendAuthorizationMailResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SendAuthorizationMailResponse>);
        }
        
        /// <summary>
        /// 重发应用组授权邮件（根据授权记录）
        ///
        /// 重发应用组授权邮件（根据授权记录）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SendAuthorizedMailResponse SendAuthorizedMail(SendAuthorizedMailRequest sendAuthorizedMailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/mails/actions/send-by-authorization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendAuthorizedMailRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<SendAuthorizedMailResponse>(response);
        }

        public SyncInvoker<SendAuthorizedMailResponse> SendAuthorizedMailInvoker(SendAuthorizedMailRequest sendAuthorizedMailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/mails/actions/send-by-authorization", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendAuthorizedMailRequest);
            return new SyncInvoker<SendAuthorizedMailResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SendAuthorizedMailResponse>);
        }
        
        /// <summary>
        /// 批量删除WKS存储
        ///
        /// 批量删除WKS存储。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeletePersistentStorageResponse BatchDeletePersistentStorage(BatchDeletePersistentStorageRequest batchDeletePersistentStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeletePersistentStorageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeletePersistentStorageResponse>(response);
        }

        public SyncInvoker<BatchDeletePersistentStorageResponse> BatchDeletePersistentStorageInvoker(BatchDeletePersistentStorageRequest batchDeletePersistentStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeletePersistentStorageRequest);
            return new SyncInvoker<BatchDeletePersistentStorageResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeletePersistentStorageResponse>);
        }
        
        /// <summary>
        /// 新增或更新存储目录访问权限自定义策略
        ///
        /// 新增或更新存储目录访问权限自定义策略(已存在自定义策略时会对已有策略更新)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateOrUpdateStoragePolicyStatementResponse CreateOrUpdateStoragePolicyStatement(CreateOrUpdateStoragePolicyStatementRequest createOrUpdateStoragePolicyStatementRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/storages-policy/actions/create-statements", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrUpdateStoragePolicyStatementRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<CreateOrUpdateStoragePolicyStatementResponse>(response);
        }

        public SyncInvoker<CreateOrUpdateStoragePolicyStatementResponse> CreateOrUpdateStoragePolicyStatementInvoker(CreateOrUpdateStoragePolicyStatementRequest createOrUpdateStoragePolicyStatementRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/storages-policy/actions/create-statements", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrUpdateStoragePolicyStatementRequest);
            return new SyncInvoker<CreateOrUpdateStoragePolicyStatementResponse>(this, "PUT", request, JsonUtils.DeSerialize<CreateOrUpdateStoragePolicyStatementResponse>);
        }
        
        /// <summary>
        /// 创建WKS存储
        ///
        /// 创建WKS存储，目前仅支持创建 SFS3.0 容量型文件系统。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePersistentStorageResponse CreatePersistentStorage(CreatePersistentStorageRequest createPersistentStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPersistentStorageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePersistentStorageResponse>(response);
        }

        public SyncInvoker<CreatePersistentStorageResponse> CreatePersistentStorageInvoker(CreatePersistentStorageRequest createPersistentStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPersistentStorageRequest);
            return new SyncInvoker<CreatePersistentStorageResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePersistentStorageResponse>);
        }
        
        /// <summary>
        /// 创建共享存储目录
        ///
        /// 创建共享存储目录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateShareFolderResponse CreateShareFolder(CreateShareFolderRequest createShareFolderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createShareFolderRequest.StorageId, out var valueOfStorageId)) urlParam.Add("storage_id", valueOfStorageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages/{storage_id}/actions/create-share-folder", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createShareFolderRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateShareFolderResponse>(response);
        }

        public SyncInvoker<CreateShareFolderResponse> CreateShareFolderInvoker(CreateShareFolderRequest createShareFolderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createShareFolderRequest.StorageId, out var valueOfStorageId)) urlParam.Add("storage_id", valueOfStorageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages/{storage_id}/actions/create-share-folder", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createShareFolderRequest);
            return new SyncInvoker<CreateShareFolderResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateShareFolderResponse>);
        }
        
        /// <summary>
        /// 删除WKS存储
        ///
        /// 删除共享存储，只会解除NAS与文件系统之间的关联关系，不会删除文件系统和文件系统中的数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePersistentStorageResponse DeletePersistentStorage(DeletePersistentStorageRequest deletePersistentStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePersistentStorageRequest.StorageId, out var valueOfStorageId)) urlParam.Add("storage_id", valueOfStorageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages/{storage_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePersistentStorageRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePersistentStorageResponse>(response);
        }

        public SyncInvoker<DeletePersistentStorageResponse> DeletePersistentStorageInvoker(DeletePersistentStorageRequest deletePersistentStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePersistentStorageRequest.StorageId, out var valueOfStorageId)) urlParam.Add("storage_id", valueOfStorageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages/{storage_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePersistentStorageRequest);
            return new SyncInvoker<DeletePersistentStorageResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePersistentStorageResponse>);
        }
        
        /// <summary>
        /// 删除共享目录
        ///
        /// 删除共享存储目录。
        /// &gt; 需要删除绑定的用户及用户组，才能删除共享文目录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteStorageClaimResponse DeleteStorageClaim(DeleteStorageClaimRequest deleteStorageClaimRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteStorageClaimRequest.StorageId, out var valueOfStorageId)) urlParam.Add("storage_id", valueOfStorageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages/{storage_id}/actions/delete-storage-claim", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteStorageClaimRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteStorageClaimResponse>(response);
        }

        public SyncInvoker<DeleteStorageClaimResponse> DeleteStorageClaimInvoker(DeleteStorageClaimRequest deleteStorageClaimRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteStorageClaimRequest.StorageId, out var valueOfStorageId)) urlParam.Add("storage_id", valueOfStorageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages/{storage_id}/actions/delete-storage-claim", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteStorageClaimRequest);
            return new SyncInvoker<DeleteStorageClaimResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteStorageClaimResponse>);
        }
        
        /// <summary>
        /// 删除个人存储目录
        ///
        /// 删除个人存储目录，个人目录中的数据也将永久删除且无法恢复。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteUserStorageAttachmentResponse DeleteUserStorageAttachment(DeleteUserStorageAttachmentRequest deleteUserStorageAttachmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteUserStorageAttachmentRequest.StorageId, out var valueOfStorageId)) urlParam.Add("storage_id", valueOfStorageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages/{storage_id}/actions/delete-user-attachment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserStorageAttachmentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteUserStorageAttachmentResponse>(response);
        }

        public SyncInvoker<DeleteUserStorageAttachmentResponse> DeleteUserStorageAttachmentInvoker(DeleteUserStorageAttachmentRequest deleteUserStorageAttachmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteUserStorageAttachmentRequest.StorageId, out var valueOfStorageId)) urlParam.Add("storage_id", valueOfStorageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages/{storage_id}/actions/delete-user-attachment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserStorageAttachmentRequest);
            return new SyncInvoker<DeleteUserStorageAttachmentResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteUserStorageAttachmentResponse>);
        }
        
        /// <summary>
        /// 查询WKS存储
        ///
        /// 查询WKS存储。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPersistentStorageResponse ListPersistentStorage(ListPersistentStorageRequest listPersistentStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPersistentStorageRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPersistentStorageResponse>(response);
        }

        public SyncInvoker<ListPersistentStorageResponse> ListPersistentStorageInvoker(ListPersistentStorageRequest listPersistentStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPersistentStorageRequest);
            return new SyncInvoker<ListPersistentStorageResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPersistentStorageResponse>);
        }
        
        /// <summary>
        /// 查询SFS3.0存储
        ///
        /// 查询SFS3.0存储。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSfs3StorageResponse ListSfs3Storage(ListSfs3StorageRequest listSfs3StorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/persistent-storages/actions/list-sfs-storages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSfs3StorageRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSfs3StorageResponse>(response);
        }

        public SyncInvoker<ListSfs3StorageResponse> ListSfs3StorageInvoker(ListSfs3StorageRequest listSfs3StorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/persistent-storages/actions/list-sfs-storages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSfs3StorageRequest);
            return new SyncInvoker<ListSfs3StorageResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSfs3StorageResponse>);
        }
        
        /// <summary>
        /// 查询共享存储目录
        ///
        /// 查询共享存储目录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListShareFolderResponse ListShareFolder(ListShareFolderRequest listShareFolderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages/actions/list-share-folders", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listShareFolderRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListShareFolderResponse>(response);
        }

        public SyncInvoker<ListShareFolderResponse> ListShareFolderInvoker(ListShareFolderRequest listShareFolderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages/actions/list-share-folders", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listShareFolderRequest);
            return new SyncInvoker<ListShareFolderResponse>(this, "GET", request, JsonUtils.DeSerialize<ListShareFolderResponse>);
        }
        
        /// <summary>
        /// 查询个人存储目录
        ///
        /// 查询个人存储目录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListStorageAssignmentResponse ListStorageAssignment(ListStorageAssignmentRequest listStorageAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages/actions/list-attachments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStorageAssignmentRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListStorageAssignmentResponse>(response);
        }

        public SyncInvoker<ListStorageAssignmentResponse> ListStorageAssignmentInvoker(ListStorageAssignmentRequest listStorageAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages/actions/list-attachments", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStorageAssignmentRequest);
            return new SyncInvoker<ListStorageAssignmentResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStorageAssignmentResponse>);
        }
        
        /// <summary>
        /// 查询存储目录访问权限策略
        ///
        /// 查询存储目录访问权限策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListStoragePolicyStatementResponse ListStoragePolicyStatement(ListStoragePolicyStatementRequest listStoragePolicyStatementRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/storages-policy/actions/list-statements", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStoragePolicyStatementRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListStoragePolicyStatementResponse>(response);
        }

        public SyncInvoker<ListStoragePolicyStatementResponse> ListStoragePolicyStatementInvoker(ListStoragePolicyStatementRequest listStoragePolicyStatementRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/storages-policy/actions/list-statements", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStoragePolicyStatementRequest);
            return new SyncInvoker<ListStoragePolicyStatementResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStoragePolicyStatementResponse>);
        }
        
        /// <summary>
        /// 修改共享目录成员
        ///
        /// 批量添加或者移除共享目录成员。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateShareFolderAssignmentResponse UpdateShareFolderAssignment(UpdateShareFolderAssignmentRequest updateShareFolderAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateShareFolderAssignmentRequest.StorageId, out var valueOfStorageId)) urlParam.Add("storage_id", valueOfStorageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages/{storage_id}/actions/assign-share-folder", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateShareFolderAssignmentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateShareFolderAssignmentResponse>(response);
        }

        public SyncInvoker<UpdateShareFolderAssignmentResponse> UpdateShareFolderAssignmentInvoker(UpdateShareFolderAssignmentRequest updateShareFolderAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateShareFolderAssignmentRequest.StorageId, out var valueOfStorageId)) urlParam.Add("storage_id", valueOfStorageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages/{storage_id}/actions/assign-share-folder", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateShareFolderAssignmentRequest);
            return new SyncInvoker<UpdateShareFolderAssignmentResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateShareFolderAssignmentResponse>);
        }
        
        /// <summary>
        /// 创建个人存储目录
        ///
        /// 创建个人存储目录，已存在对应目录时，仅更新策略不会重复创建目录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateUserFolderAssignmentResponse UpdateUserFolderAssignment(UpdateUserFolderAssignmentRequest updateUserFolderAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateUserFolderAssignmentRequest.StorageId, out var valueOfStorageId)) urlParam.Add("storage_id", valueOfStorageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages/{storage_id}/actions/assign-folder", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserFolderAssignmentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateUserFolderAssignmentResponse>(response);
        }

        public SyncInvoker<UpdateUserFolderAssignmentResponse> UpdateUserFolderAssignmentInvoker(UpdateUserFolderAssignmentRequest updateUserFolderAssignmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateUserFolderAssignmentRequest.StorageId, out var valueOfStorageId)) urlParam.Add("storage_id", valueOfStorageId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/persistent-storages/{storage_id}/actions/assign-folder", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserFolderAssignmentRequest);
            return new SyncInvoker<UpdateUserFolderAssignmentResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateUserFolderAssignmentResponse>);
        }
        
        /// <summary>
        /// 新增策略组
        ///
        /// 新增策略组，通过策略组能灵活的控制客户端访问与接入策略，如：文件、剪切板、会话等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePolicyGroupResponse CreatePolicyGroup(CreatePolicyGroupRequest createPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPolicyGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePolicyGroupResponse>(response);
        }

        public SyncInvoker<CreatePolicyGroupResponse> CreatePolicyGroupInvoker(CreatePolicyGroupRequest createPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPolicyGroupRequest);
            return new SyncInvoker<CreatePolicyGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePolicyGroupResponse>);
        }
        
        /// <summary>
        /// 新增策略模板
        ///
        /// 新增策略模板。策略模板创建好后，用户在创建策略组的时候，就可以根据已有策略模板按需调整配置，快速完成策略组的创建。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePolicyTemplateResponse CreatePolicyTemplate(CreatePolicyTemplateRequest createPolicyTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPolicyTemplateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePolicyTemplateResponse>(response);
        }

        public SyncInvoker<CreatePolicyTemplateResponse> CreatePolicyTemplateInvoker(CreatePolicyTemplateRequest createPolicyTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPolicyTemplateRequest);
            return new SyncInvoker<CreatePolicyTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePolicyTemplateResponse>);
        }
        
        /// <summary>
        /// 删除策略组
        ///
        /// 删除指定策略组，包含策略组对应的策略信息以及应用对象信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePolicyGroupResponse DeletePolicyGroup(DeletePolicyGroupRequest deletePolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePolicyGroupRequest.PolicyGroupId, out var valueOfPolicyGroupId)) urlParam.Add("policy_group_id", valueOfPolicyGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-groups/{policy_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePolicyGroupResponse>(response);
        }

        public SyncInvoker<DeletePolicyGroupResponse> DeletePolicyGroupInvoker(DeletePolicyGroupRequest deletePolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePolicyGroupRequest.PolicyGroupId, out var valueOfPolicyGroupId)) urlParam.Add("policy_group_id", valueOfPolicyGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-groups/{policy_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyGroupRequest);
            return new SyncInvoker<DeletePolicyGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePolicyGroupResponse>);
        }
        
        /// <summary>
        /// 删除策略模板
        ///
        /// 删除指定策略模板，包含策略模板对应的策略信息以及应用对象信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePolicyTemplateResponse DeletePolicyTemplate(DeletePolicyTemplateRequest deletePolicyTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePolicyTemplateRequest.PolicyTemplateId, out var valueOfPolicyTemplateId)) urlParam.Add("policy_template_id", valueOfPolicyTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-templates/{policy_template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyTemplateRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePolicyTemplateResponse>(response);
        }

        public SyncInvoker<DeletePolicyTemplateResponse> DeletePolicyTemplateInvoker(DeletePolicyTemplateRequest deletePolicyTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePolicyTemplateRequest.PolicyTemplateId, out var valueOfPolicyTemplateId)) urlParam.Add("policy_template_id", valueOfPolicyTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-templates/{policy_template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyTemplateRequest);
            return new SyncInvoker<DeletePolicyTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePolicyTemplateResponse>);
        }
        
        /// <summary>
        /// 查询策略组列表
        ///
        /// 查询策略组概要信息列表,包括应用对象和详细策略项。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPolicyGroupResponse ListPolicyGroup(ListPolicyGroupRequest listPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPolicyGroupResponse>(response);
        }

        public SyncInvoker<ListPolicyGroupResponse> ListPolicyGroupInvoker(ListPolicyGroupRequest listPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyGroupRequest);
            return new SyncInvoker<ListPolicyGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPolicyGroupResponse>);
        }
        
        /// <summary>
        /// 查询策略组详情列表
        ///
        /// 包含策略信息以及应用对象的信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPolicyGroupDetailInfoResponse ListPolicyGroupDetailInfo(ListPolicyGroupDetailInfoRequest listPolicyGroupDetailInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-groups/show/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyGroupDetailInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPolicyGroupDetailInfoResponse>(response);
        }

        public SyncInvoker<ListPolicyGroupDetailInfoResponse> ListPolicyGroupDetailInfoInvoker(ListPolicyGroupDetailInfoRequest listPolicyGroupDetailInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-groups/show/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyGroupDetailInfoRequest);
            return new SyncInvoker<ListPolicyGroupDetailInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPolicyGroupDetailInfoResponse>);
        }
        
        /// <summary>
        /// 查询策略组中的策略项
        ///
        /// 查询指定策略组内的策略项。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPolicyOfPolicyGroupResponse ListPolicyOfPolicyGroup(ListPolicyOfPolicyGroupRequest listPolicyOfPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPolicyOfPolicyGroupRequest.PolicyGroupId, out var valueOfPolicyGroupId)) urlParam.Add("policy_group_id", valueOfPolicyGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-groups/{policy_group_id}/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyOfPolicyGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPolicyOfPolicyGroupResponse>(response);
        }

        public SyncInvoker<ListPolicyOfPolicyGroupResponse> ListPolicyOfPolicyGroupInvoker(ListPolicyOfPolicyGroupRequest listPolicyOfPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPolicyOfPolicyGroupRequest.PolicyGroupId, out var valueOfPolicyGroupId)) urlParam.Add("policy_group_id", valueOfPolicyGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-groups/{policy_group_id}/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyOfPolicyGroupRequest);
            return new SyncInvoker<ListPolicyOfPolicyGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPolicyOfPolicyGroupResponse>);
        }
        
        /// <summary>
        /// 查询策略模板列表
        ///
        /// 查询策略模板概要信息列表，包含策略信息以及应用对象信息。用户在创建策略组的时候，可以根据已有策略模板按需调整配置，快速完成策略组的创建。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPolicyTemplateResponse ListPolicyTemplate(ListPolicyTemplateRequest listPolicyTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyTemplateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPolicyTemplateResponse>(response);
        }

        public SyncInvoker<ListPolicyTemplateResponse> ListPolicyTemplateInvoker(ListPolicyTemplateRequest listPolicyTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPolicyTemplateRequest);
            return new SyncInvoker<ListPolicyTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPolicyTemplateResponse>);
        }
        
        /// <summary>
        /// 查询策略组应用对象
        ///
        /// 查询指定策略组所应用的对象。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTargetsOfPolicyGroupResponse ListTargetsOfPolicyGroup(ListTargetsOfPolicyGroupRequest listTargetsOfPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTargetsOfPolicyGroupRequest.PolicyGroupId, out var valueOfPolicyGroupId)) urlParam.Add("policy_group_id", valueOfPolicyGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-groups/{policy_group_id}/target", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTargetsOfPolicyGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTargetsOfPolicyGroupResponse>(response);
        }

        public SyncInvoker<ListTargetsOfPolicyGroupResponse> ListTargetsOfPolicyGroupInvoker(ListTargetsOfPolicyGroupRequest listTargetsOfPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTargetsOfPolicyGroupRequest.PolicyGroupId, out var valueOfPolicyGroupId)) urlParam.Add("policy_group_id", valueOfPolicyGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-groups/{policy_group_id}/target", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTargetsOfPolicyGroupRequest);
            return new SyncInvoker<ListTargetsOfPolicyGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTargetsOfPolicyGroupResponse>);
        }
        
        /// <summary>
        /// 查询初始策略项
        ///
        /// 查询初始策略项，初始策略项是所有协议策略配置项的默认配置，用户可以在初始策略项的基础上根据需求修改指定的配置，创建新的策略组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowOriginalPolicyInfoResponse ShowOriginalPolicyInfo(ShowOriginalPolicyInfoRequest showOriginalPolicyInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-groups/actions/list-original-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOriginalPolicyInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowOriginalPolicyInfoResponse>(response);
        }

        public SyncInvoker<ShowOriginalPolicyInfoResponse> ShowOriginalPolicyInfoInvoker(ShowOriginalPolicyInfoRequest showOriginalPolicyInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-groups/actions/list-original-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOriginalPolicyInfoRequest);
            return new SyncInvoker<ShowOriginalPolicyInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOriginalPolicyInfoResponse>);
        }
        
        /// <summary>
        /// 查询策略组详情
        ///
        /// 根据策略组ID查询策略组详细信息，包含策略信息以及应用对象信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPolicyGroupResponse ShowPolicyGroup(ShowPolicyGroupRequest showPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPolicyGroupRequest.PolicyGroupId, out var valueOfPolicyGroupId)) urlParam.Add("policy_group_id", valueOfPolicyGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-groups/{policy_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPolicyGroupResponse>(response);
        }

        public SyncInvoker<ShowPolicyGroupResponse> ShowPolicyGroupInvoker(ShowPolicyGroupRequest showPolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPolicyGroupRequest.PolicyGroupId, out var valueOfPolicyGroupId)) urlParam.Add("policy_group_id", valueOfPolicyGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-groups/{policy_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyGroupRequest);
            return new SyncInvoker<ShowPolicyGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPolicyGroupResponse>);
        }
        
        /// <summary>
        /// 修改策略组
        ///
        /// 修改指定策略组的信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePolicyGroupResponse UpdatePolicyGroup(UpdatePolicyGroupRequest updatePolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePolicyGroupRequest.PolicyGroupId, out var valueOfPolicyGroupId)) urlParam.Add("policy_group_id", valueOfPolicyGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-groups/{policy_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyGroupRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerialize<UpdatePolicyGroupResponse>(response);
        }

        public SyncInvoker<UpdatePolicyGroupResponse> UpdatePolicyGroupInvoker(UpdatePolicyGroupRequest updatePolicyGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePolicyGroupRequest.PolicyGroupId, out var valueOfPolicyGroupId)) urlParam.Add("policy_group_id", valueOfPolicyGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-groups/{policy_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyGroupRequest);
            return new SyncInvoker<UpdatePolicyGroupResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpdatePolicyGroupResponse>);
        }
        
        /// <summary>
        /// 修改策略模板
        ///
        /// 修改指定策略模板的信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePolicyTemplateResponse UpdatePolicyTemplate(UpdatePolicyTemplateRequest updatePolicyTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePolicyTemplateRequest.PolicyTemplateId, out var valueOfPolicyTemplateId)) urlParam.Add("policy_template_id", valueOfPolicyTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-templates/{policy_template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyTemplateRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerialize<UpdatePolicyTemplateResponse>(response);
        }

        public SyncInvoker<UpdatePolicyTemplateResponse> UpdatePolicyTemplateInvoker(UpdatePolicyTemplateRequest updatePolicyTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePolicyTemplateRequest.PolicyTemplateId, out var valueOfPolicyTemplateId)) urlParam.Add("policy_template_id", valueOfPolicyTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/policy-templates/{policy_template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePolicyTemplateRequest);
            return new SyncInvoker<UpdatePolicyTemplateResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpdatePolicyTemplateResponse>);
        }
        
        /// <summary>
        /// 查询最新版本的隐私声明
        ///
        /// 查询最新版本的隐私声明。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPrivacyStatementResponse ShowPrivacyStatement(ShowPrivacyStatementRequest showPrivacyStatementRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/privacy-statement", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivacyStatementRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPrivacyStatementResponse>(response);
        }

        public SyncInvoker<ShowPrivacyStatementResponse> ShowPrivacyStatementInvoker(ShowPrivacyStatementRequest showPrivacyStatementRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/privacy-statement", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivacyStatementRequest);
            return new SyncInvoker<ShowPrivacyStatementResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPrivacyStatementResponse>);
        }
        
        /// <summary>
        /// 签署隐私声明
        ///
        /// 签署隐私声明。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SignPrivacyStatementResponse SignPrivacyStatement(SignPrivacyStatementRequest signPrivacyStatementRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/privacy-statement", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", signPrivacyStatementRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<SignPrivacyStatementResponse>(response);
        }

        public SyncInvoker<SignPrivacyStatementResponse> SignPrivacyStatementInvoker(SignPrivacyStatementRequest signPrivacyStatementRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/privacy-statement", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", signPrivacyStatementRequest);
            return new SyncInvoker<SignPrivacyStatementResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SignPrivacyStatementResponse>);
        }
        
        /// <summary>
        /// 配额校验
        ///
        /// 配额校验，购买服务器前可用调用该接口，校验本次创建服务器资源是否足够。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CheckQuotaResponse CheckQuota(CheckQuotaRequest checkQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/check/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkQuotaRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CheckQuotaResponse>(response);
        }

        public SyncInvoker<CheckQuotaResponse> CheckQuotaInvoker(CheckQuotaRequest checkQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/check/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkQuotaRequest);
            return new SyncInvoker<CheckQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<CheckQuotaResponse>);
        }
        
        /// <summary>
        /// 新增/修改弹性伸缩策略
        ///
        /// 新增/修改弹性伸缩策略,仅按需的服务器支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateOrUpdateScalingPolicyResponse CreateOrUpdateScalingPolicy(CreateOrUpdateScalingPolicyRequest createOrUpdateScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/scaling-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrUpdateScalingPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<CreateOrUpdateScalingPolicyResponse>(response);
        }

        public SyncInvoker<CreateOrUpdateScalingPolicyResponse> CreateOrUpdateScalingPolicyInvoker(CreateOrUpdateScalingPolicyRequest createOrUpdateScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/scaling-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOrUpdateScalingPolicyRequest);
            return new SyncInvoker<CreateOrUpdateScalingPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<CreateOrUpdateScalingPolicyResponse>);
        }
        
        /// <summary>
        /// 删除弹性伸缩策略
        ///
        /// 删除弹性伸缩策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteScalingPolicyResponse DeleteScalingPolicy(DeleteScalingPolicyRequest deleteScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/scaling-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScalingPolicyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteScalingPolicyResponse>(response);
        }

        public SyncInvoker<DeleteScalingPolicyResponse> DeleteScalingPolicyInvoker(DeleteScalingPolicyRequest deleteScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/scaling-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScalingPolicyRequest);
            return new SyncInvoker<DeleteScalingPolicyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteScalingPolicyResponse>);
        }
        
        /// <summary>
        /// 查询服务器组弹性伸缩策略
        ///
        /// 查询服务器组弹性伸缩策略,如果服务器未配置策略时响应默认策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowScalingPolicyResponse ShowScalingPolicy(ShowScalingPolicyRequest showScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/scaling-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScalingPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowScalingPolicyResponse>(response);
        }

        public SyncInvoker<ShowScalingPolicyResponse> ShowScalingPolicyInvoker(ShowScalingPolicyRequest showScalingPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/scaling-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScalingPolicyRequest);
            return new SyncInvoker<ShowScalingPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowScalingPolicyResponse>);
        }
        
        /// <summary>
        /// 批量删除定时任务
        ///
        /// 批量删除定时任务，忽略不存在的服务器组并且返回成功响应。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteScheduleTaskResponse BatchDeleteScheduleTask(BatchDeleteScheduleTaskRequest batchDeleteScheduleTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule-task/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteScheduleTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteScheduleTaskResponse>(response);
        }

        public SyncInvoker<BatchDeleteScheduleTaskResponse> BatchDeleteScheduleTaskInvoker(BatchDeleteScheduleTaskRequest batchDeleteScheduleTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule-task/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteScheduleTaskRequest);
            return new SyncInvoker<BatchDeleteScheduleTaskResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteScheduleTaskResponse>);
        }
        
        /// <summary>
        /// 新增定时任务
        ///
        /// 新增定时任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateScheduleTaskResponse CreateScheduleTask(CreateScheduleTaskRequest createScheduleTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createScheduleTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateScheduleTaskResponse>(response);
        }

        public SyncInvoker<CreateScheduleTaskResponse> CreateScheduleTaskInvoker(CreateScheduleTaskRequest createScheduleTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createScheduleTaskRequest);
            return new SyncInvoker<CreateScheduleTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateScheduleTaskResponse>);
        }
        
        /// <summary>
        /// 删除任务
        ///
        /// 删除任务，忽略不存在的任务并且返回成功响应。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteScheduleTaskResponse DeleteScheduleTask(DeleteScheduleTaskRequest deleteScheduleTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteScheduleTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScheduleTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteScheduleTaskResponse>(response);
        }

        public SyncInvoker<DeleteScheduleTaskResponse> DeleteScheduleTaskInvoker(DeleteScheduleTaskRequest deleteScheduleTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteScheduleTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScheduleTaskRequest);
            return new SyncInvoker<DeleteScheduleTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteScheduleTaskResponse>);
        }
        
        /// <summary>
        /// 未来执行的具体时间列表
        ///
        /// 未来执行的具体时间列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFutureExecutionsResponse ListFutureExecutions(ListFutureExecutionsRequest listFutureExecutionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule-task/future-executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFutureExecutionsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListFutureExecutionsResponse>(response);
        }

        public SyncInvoker<ListFutureExecutionsResponse> ListFutureExecutionsInvoker(ListFutureExecutionsRequest listFutureExecutionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule-task/future-executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFutureExecutionsRequest);
            return new SyncInvoker<ListFutureExecutionsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListFutureExecutionsResponse>);
        }
        
        /// <summary>
        /// 查询定时任务列表
        ///
        /// 查询定时任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListScheduleTasksResponse ListScheduleTasks(ListScheduleTasksRequest listScheduleTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduleTasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListScheduleTasksResponse>(response);
        }

        public SyncInvoker<ListScheduleTasksResponse> ListScheduleTasksInvoker(ListScheduleTasksRequest listScheduleTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduleTasksRequest);
            return new SyncInvoker<ListScheduleTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScheduleTasksResponse>);
        }
        
        /// <summary>
        /// 查询定时任务执行子任务列表
        ///
        /// 查询定时任务执行子任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTaskExecuteDetailResponse ListTaskExecuteDetail(ListTaskExecuteDetailRequest listTaskExecuteDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTaskExecuteDetailRequest.ExecuteHistoryId, out var valueOfExecuteHistoryId)) urlParam.Add("execute_history_id", valueOfExecuteHistoryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule-task/{execute_history_id}/execute-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTaskExecuteDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTaskExecuteDetailResponse>(response);
        }

        public SyncInvoker<ListTaskExecuteDetailResponse> ListTaskExecuteDetailInvoker(ListTaskExecuteDetailRequest listTaskExecuteDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTaskExecuteDetailRequest.ExecuteHistoryId, out var valueOfExecuteHistoryId)) urlParam.Add("execute_history_id", valueOfExecuteHistoryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule-task/{execute_history_id}/execute-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTaskExecuteDetailRequest);
            return new SyncInvoker<ListTaskExecuteDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTaskExecuteDetailResponse>);
        }
        
        /// <summary>
        /// 查询定时任务执行列表
        ///
        /// 查询定时任务执行列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTaskExecuteHistoryResponse ListTaskExecuteHistory(ListTaskExecuteHistoryRequest listTaskExecuteHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTaskExecuteHistoryRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule-task/{task_id}/execute-history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTaskExecuteHistoryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTaskExecuteHistoryResponse>(response);
        }

        public SyncInvoker<ListTaskExecuteHistoryResponse> ListTaskExecuteHistoryInvoker(ListTaskExecuteHistoryRequest listTaskExecuteHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTaskExecuteHistoryRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule-task/{task_id}/execute-history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTaskExecuteHistoryRequest);
            return new SyncInvoker<ListTaskExecuteHistoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTaskExecuteHistoryResponse>);
        }
        
        /// <summary>
        /// 查询指定定时任务详情
        ///
        /// 查询指定定时任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowScheduleTaskResponse ShowScheduleTask(ShowScheduleTaskRequest showScheduleTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showScheduleTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScheduleTaskRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowScheduleTaskResponse>(response);
        }

        public SyncInvoker<ShowScheduleTaskResponse> ShowScheduleTaskInvoker(ShowScheduleTaskRequest showScheduleTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showScheduleTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showScheduleTaskRequest);
            return new SyncInvoker<ShowScheduleTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowScheduleTaskResponse>);
        }
        
        /// <summary>
        /// 修改定时任务
        ///
        /// 修改定时任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateScheduleTaskResponse UpdateScheduleTask(UpdateScheduleTaskRequest updateScheduleTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateScheduleTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateScheduleTaskRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerialize<UpdateScheduleTaskResponse>(response);
        }

        public SyncInvoker<UpdateScheduleTaskResponse> UpdateScheduleTaskInvoker(UpdateScheduleTaskRequest updateScheduleTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateScheduleTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule-task/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateScheduleTaskRequest);
            return new SyncInvoker<UpdateScheduleTaskResponse>(this, "PATCH", request, JsonUtils.DeSerialize<UpdateScheduleTaskResponse>);
        }
        
        /// <summary>
        /// 批量修改服务器的镜像
        ///
        /// 批量修改服务器的镜像。
        /// &gt; - 服务器的镜像和服务器组的镜像不一样时，支持服务器的镜像切换为服务器组的镜像，并且仅允许同等镜像进行切换，例如：同操作系统，免费镜像切换，同源同价的付费镜像切换。如果服务器组的镜像和服务器的镜像为非同等镜像，建议您直接购买新的服务器，删除或者退订老的服务器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchChangeServerImageResponse BatchChangeServerImage(BatchChangeServerImageRequest batchChangeServerImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/batch-change-image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchChangeServerImageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchChangeServerImageResponse>(response);
        }

        public SyncInvoker<BatchChangeServerImageResponse> BatchChangeServerImageInvoker(BatchChangeServerImageRequest batchChangeServerImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/batch-change-image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchChangeServerImageRequest);
            return new SyncInvoker<BatchChangeServerImageResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchChangeServerImageResponse>);
        }
        
        /// <summary>
        /// 标记服务器维护状态
        ///
        /// 标记服务器维护状态，处于维护状态中的服务器不再分配流量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchChangeServerMaintainModeResponse BatchChangeServerMaintainMode(BatchChangeServerMaintainModeRequest batchChangeServerMaintainModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/batch-maint", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchChangeServerMaintainModeRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerializeNull<BatchChangeServerMaintainModeResponse>(response);
        }

        public SyncInvoker<BatchChangeServerMaintainModeResponse> BatchChangeServerMaintainModeInvoker(BatchChangeServerMaintainModeRequest batchChangeServerMaintainModeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/batch-maint", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchChangeServerMaintainModeRequest);
            return new SyncInvoker<BatchChangeServerMaintainModeResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<BatchChangeServerMaintainModeResponse>);
        }
        
        /// <summary>
        /// 批量删除服务器
        ///
        /// 批量删除服务器。
        /// &gt; - [仅支持删除按需订购的服务器，包周期订购的服务器需要到Console界面进行退订，订单退订成功后服务器将会自动删除。](tag:HW)[批量删除服务器。](tag:HCS)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteServerResponse BatchDeleteServer(BatchDeleteServerRequest batchDeleteServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteServerRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteServerResponse>(response);
        }

        public SyncInvoker<BatchDeleteServerResponse> BatchDeleteServerInvoker(BatchDeleteServerRequest batchDeleteServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteServerRequest);
            return new SyncInvoker<BatchDeleteServerResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteServerResponse>);
        }
        
        /// <summary>
        /// 迁移云办公主机下面的服务器到目标云办公主机
        ///
        /// 迁移云办公主机下面的服务器到目标云办公主机。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchMigrateHostsServerResponse BatchMigrateHostsServer(BatchMigrateHostsServerRequest batchMigrateHostsServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/hosts/batch-migrate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchMigrateHostsServerRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerialize<BatchMigrateHostsServerResponse>(response);
        }

        public SyncInvoker<BatchMigrateHostsServerResponse> BatchMigrateHostsServerInvoker(BatchMigrateHostsServerRequest batchMigrateHostsServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/hosts/batch-migrate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchMigrateHostsServerRequest);
            return new SyncInvoker<BatchMigrateHostsServerResponse>(this, "PATCH", request, JsonUtils.DeSerialize<BatchMigrateHostsServerResponse>);
        }
        
        /// <summary>
        /// 重启服务器
        ///
        /// 重启服务器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchRebootServerResponse BatchRebootServer(BatchRebootServerRequest batchRebootServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/batch-reboot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRebootServerRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerializeNull<BatchRebootServerResponse>(response);
        }

        public SyncInvoker<BatchRebootServerResponse> BatchRebootServerInvoker(BatchRebootServerRequest batchRebootServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/batch-reboot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRebootServerRequest);
            return new SyncInvoker<BatchRebootServerResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<BatchRebootServerResponse>);
        }
        
        /// <summary>
        /// 批量重装服务器
        ///
        /// 批量重装服务器。
        /// &gt; - 使用服务器原有的镜像进行重装，当服务器异常无法恢复时或者服务器运行时间久了，性能下降时，可选择重建服务器。注意：重装时系统盘的数据将会被清理掉。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchReinstallServerResponse BatchReinstallServer(BatchReinstallServerRequest batchReinstallServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/batch-reinstall", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchReinstallServerRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchReinstallServerResponse>(response);
        }

        public SyncInvoker<BatchReinstallServerResponse> BatchReinstallServerInvoker(BatchReinstallServerRequest batchReinstallServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/batch-reinstall", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchReinstallServerRequest);
            return new SyncInvoker<BatchReinstallServerResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchReinstallServerResponse>);
        }
        
        /// <summary>
        /// 批量服务器重新加域
        ///
        /// 批量服务器重新加入AD域，一般用于解决服务器脱域的情况使用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchRejoinDomainResponse BatchRejoinDomain(BatchRejoinDomainRequest batchRejoinDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/batch-rejoin-domain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRejoinDomainRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerialize<BatchRejoinDomainResponse>(response);
        }

        public SyncInvoker<BatchRejoinDomainResponse> BatchRejoinDomainInvoker(BatchRejoinDomainRequest batchRejoinDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/batch-rejoin-domain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRejoinDomainRequest);
            return new SyncInvoker<BatchRejoinDomainResponse>(this, "PATCH", request, JsonUtils.DeSerialize<BatchRejoinDomainResponse>);
        }
        
        /// <summary>
        /// 启动服务器
        ///
        /// 启动服务器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchStartServerResponse BatchStartServer(BatchStartServerRequest batchStartServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/batch-start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchStartServerRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerializeNull<BatchStartServerResponse>(response);
        }

        public SyncInvoker<BatchStartServerResponse> BatchStartServerInvoker(BatchStartServerRequest batchStartServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/batch-start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchStartServerRequest);
            return new SyncInvoker<BatchStartServerResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<BatchStartServerResponse>);
        }
        
        /// <summary>
        /// 关闭服务器
        ///
        /// 关闭服务器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchStopServerResponse BatchStopServer(BatchStopServerRequest batchStopServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/batch-stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchStopServerRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerializeNull<BatchStopServerResponse>(response);
        }

        public SyncInvoker<BatchStopServerResponse> BatchStopServerInvoker(BatchStopServerRequest batchStopServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/batch-stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchStopServerRequest);
            return new SyncInvoker<BatchStopServerResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<BatchStopServerResponse>);
        }
        
        /// <summary>
        /// 批量更新服务器虚拟会话IP配置
        ///
        /// 批量更新服务器虚拟会话IP配置，按需重启机器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchUpdateTsviResponse BatchUpdateTsvi(BatchUpdateTsviRequest batchUpdateTsviRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/batch-update-tsvi", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateTsviRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerialize<BatchUpdateTsviResponse>(response);
        }

        public SyncInvoker<BatchUpdateTsviResponse> BatchUpdateTsviInvoker(BatchUpdateTsviRequest batchUpdateTsviRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/batch-update-tsvi", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateTsviRequest);
            return new SyncInvoker<BatchUpdateTsviResponse>(this, "PATCH", request, JsonUtils.DeSerialize<BatchUpdateTsviResponse>);
        }
        
        /// <summary>
        /// 批量升级服务器HDA版本
        ///
        /// 批量升级服务器HDA版本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchUpgradeHdaVersionResponse BatchUpgradeHdaVersion(BatchUpgradeHdaVersionRequest batchUpgradeHdaVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/access-agent/actions/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpgradeHdaVersionRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerializeNull<BatchUpgradeHdaVersionResponse>(response);
        }

        public SyncInvoker<BatchUpgradeHdaVersionResponse> BatchUpgradeHdaVersionInvoker(BatchUpgradeHdaVersionRequest batchUpgradeHdaVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/access-agent/actions/upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpgradeHdaVersionRequest);
            return new SyncInvoker<BatchUpgradeHdaVersionResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<BatchUpgradeHdaVersionResponse>);
        }
        
        /// <summary>
        /// 修改服务器的镜像
        ///
        /// 修改服务器的镜像。
        /// &gt; - 服务器的镜像和服务器组的镜像不一样时，支持服务器的镜像切换为服务器组的镜像，并且仅允许同等镜像进行切换，例如：同操作系统，免费镜像切换，同源同价的付费镜像切换。如果服务器组的镜像和服务器的镜像为非同等镜像，建议您直接购买新的服务器，删除或者退订老的服务器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeServerImageResponse ChangeServerImage(ChangeServerImageRequest changeServerImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeServerImageRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/{server_id}/actions/change-image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeServerImageRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ChangeServerImageResponse>(response);
        }

        public SyncInvoker<ChangeServerImageResponse> ChangeServerImageInvoker(ChangeServerImageRequest changeServerImageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(changeServerImageRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/{server_id}/actions/change-image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeServerImageRequest);
            return new SyncInvoker<ChangeServerImageResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeServerImageResponse>);
        }
        
        /// <summary>
        /// 创建云服务器
        ///
        /// 创建云服务器接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAppServersResponse CreateAppServers(CreateAppServersRequest createAppServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppServersRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAppServersResponse>(response);
        }

        public SyncInvoker<CreateAppServersResponse> CreateAppServersInvoker(CreateAppServersRequest createAppServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/actions/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppServersRequest);
            return new SyncInvoker<CreateAppServersResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAppServersResponse>);
        }
        
        /// <summary>
        /// 删除服务器
        ///
        /// 删除服务器，忽略不存在的服务器并且返回成功响应。订单退订成功后调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteServerResponse DeleteServer(DeleteServerRequest deleteServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteServerRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServerRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteServerResponse>(response);
        }

        public SyncInvoker<DeleteServerResponse> DeleteServerInvoker(DeleteServerRequest deleteServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteServerRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServerRequest);
            return new SyncInvoker<DeleteServerResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteServerResponse>);
        }
        
        /// <summary>
        /// 查询租户的所有HDA最新版本
        ///
        /// 查询租户的所有HDA最新版本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAccessAgentLatestVersionResponse ListAccessAgentLatestVersion(ListAccessAgentLatestVersionRequest listAccessAgentLatestVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/access-agent/actions/show-latest-version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessAgentLatestVersionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAccessAgentLatestVersionResponse>(response);
        }

        public SyncInvoker<ListAccessAgentLatestVersionResponse> ListAccessAgentLatestVersionInvoker(ListAccessAgentLatestVersionRequest listAccessAgentLatestVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/access-agent/actions/show-latest-version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessAgentLatestVersionRequest);
            return new SyncInvoker<ListAccessAgentLatestVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAccessAgentLatestVersionResponse>);
        }
        
        /// <summary>
        /// 查询服务器的HDA相关信息
        ///
        /// 查询服务器的HDA相关信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListServerHdaDetailsResponse ListServerHdaDetails(ListServerHdaDetailsRequest listServerHdaDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/access-agent/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerHdaDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListServerHdaDetailsResponse>(response);
        }

        public SyncInvoker<ListServerHdaDetailsResponse> ListServerHdaDetailsInvoker(ListServerHdaDetailsRequest listServerHdaDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/access-agent/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerHdaDetailsRequest);
            return new SyncInvoker<ListServerHdaDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServerHdaDetailsResponse>);
        }
        
        /// <summary>
        /// 查询服务器的HDA升级跟踪记录
        ///
        /// 查询服务器的HDA升级跟踪记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListServerHdaUpgradeRecordsResponse ListServerHdaUpgradeRecords(ListServerHdaUpgradeRecordsRequest listServerHdaUpgradeRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/access-agent/upgrade-record", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerHdaUpgradeRecordsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListServerHdaUpgradeRecordsResponse>(response);
        }

        public SyncInvoker<ListServerHdaUpgradeRecordsResponse> ListServerHdaUpgradeRecordsInvoker(ListServerHdaUpgradeRecordsRequest listServerHdaUpgradeRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/access-agent/upgrade-record", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerHdaUpgradeRecordsRequest);
            return new SyncInvoker<ListServerHdaUpgradeRecordsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServerHdaUpgradeRecordsResponse>);
        }
        
        /// <summary>
        /// 查询指定时间范围指定指标的指定粒度的监控数据
        ///
        /// 查询指定时间范围指定指标的指定粒度的监控数据，可以通过参数指定需要查询的数据维度。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListServerMetricDataResponse ListServerMetricData(ListServerMetricDataRequest listServerMetricDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listServerMetricDataRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/server-metric-data/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerMetricDataRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListServerMetricDataResponse>(response);
        }

        public SyncInvoker<ListServerMetricDataResponse> ListServerMetricDataInvoker(ListServerMetricDataRequest listServerMetricDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listServerMetricDataRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/server-metric-data/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerMetricDataRequest);
            return new SyncInvoker<ListServerMetricDataResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServerMetricDataResponse>);
        }
        
        /// <summary>
        /// 查询服务器列表
        ///
        /// 查询服务器列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListServersResponse ListServers(ListServersRequest listServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListServersResponse>(response);
        }

        public SyncInvoker<ListServersResponse> ListServersInvoker(ListServersRequest listServersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServersRequest);
            return new SyncInvoker<ListServersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServersResponse>);
        }
        
        /// <summary>
        /// 重装服务器
        ///
        /// 重装服务器。
        /// &gt; - 使用服务器原有的镜像进行重装，当服务器异常无法恢复时或者服务器运行时间久了，性能下降时，可选择重建服务器。注意：重装时系统盘的数据将会被清理掉。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ReinstallServerResponse ReinstallServer(ReinstallServerRequest reinstallServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(reinstallServerRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/{server_id}/actions/reinstall", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", reinstallServerRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ReinstallServerResponse>(response);
        }

        public SyncInvoker<ReinstallServerResponse> ReinstallServerInvoker(ReinstallServerRequest reinstallServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(reinstallServerRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/{server_id}/actions/reinstall", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", reinstallServerRequest);
            return new SyncInvoker<ReinstallServerResponse>(this, "POST", request, JsonUtils.DeSerialize<ReinstallServerResponse>);
        }
        
        /// <summary>
        /// 查询租户的HDA最新版本
        ///
        /// 查询租户的HDA最新版本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAccessAgentLatestVersionResponse ShowAccessAgentLatestVersion(ShowAccessAgentLatestVersionRequest showAccessAgentLatestVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/access-agent/latest-version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAccessAgentLatestVersionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAccessAgentLatestVersionResponse>(response);
        }

        public SyncInvoker<ShowAccessAgentLatestVersionResponse> ShowAccessAgentLatestVersionInvoker(ShowAccessAgentLatestVersionRequest showAccessAgentLatestVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/access-agent/latest-version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAccessAgentLatestVersionRequest);
            return new SyncInvoker<ShowAccessAgentLatestVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAccessAgentLatestVersionResponse>);
        }
        
        /// <summary>
        /// 查询HDA升级提醒标识
        ///
        /// 查询HDA升级提醒标识(仅内部访问使用)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowHdaUpgradeFlagResponse ShowHdaUpgradeFlag(ShowHdaUpgradeFlagRequest showHdaUpgradeFlagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/access-agent/upgrade-flag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHdaUpgradeFlagRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowHdaUpgradeFlagResponse>(response);
        }

        public SyncInvoker<ShowHdaUpgradeFlagResponse> ShowHdaUpgradeFlagInvoker(ShowHdaUpgradeFlagRequest showHdaUpgradeFlagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/access-agent/upgrade-flag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHdaUpgradeFlagRequest);
            return new SyncInvoker<ShowHdaUpgradeFlagResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHdaUpgradeFlagResponse>);
        }
        
        /// <summary>
        /// 查询指定服务器
        ///
        /// 查询指定的服务器当前这个接口的查询数据和list查询的一致。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowServerResponse ShowServer(ShowServerRequest showServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showServerRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowServerResponse>(response);
        }

        public SyncInvoker<ShowServerResponse> ShowServerInvoker(ShowServerRequest showServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showServerRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerRequest);
            return new SyncInvoker<ShowServerResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowServerResponse>);
        }
        
        /// <summary>
        /// 查询云应用服务器监控信息
        ///
        /// 该接口可获取某一计算机在一段时间段(范围：1小时到30天)的数据信息（例如CPU占用率、内存占用率、用户的在线时间段等），最长数据保存时间不能超过180天。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowServerMetricDataResponse ShowServerMetricData(ShowServerMetricDataRequest showServerMetricDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showServerMetricDataRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/metric-data/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerMetricDataRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowServerMetricDataResponse>(response);
        }

        public SyncInvoker<ShowServerMetricDataResponse> ShowServerMetricDataInvoker(ShowServerMetricDataRequest showServerMetricDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showServerMetricDataRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/metric-data/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerMetricDataRequest);
            return new SyncInvoker<ShowServerMetricDataResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowServerMetricDataResponse>);
        }
        
        /// <summary>
        /// 获取VNC远程登录地址
        ///
        /// 获取VNC远程登录地址。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowServerVncResponse ShowServerVnc(ShowServerVncRequest showServerVncRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showServerVncRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/{server_id}/actions/vnc", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerVncRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowServerVncResponse>(response);
        }

        public SyncInvoker<ShowServerVncResponse> ShowServerVncInvoker(ShowServerVncRequest showServerVncRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showServerVncRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/{server_id}/actions/vnc", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerVncRequest);
            return new SyncInvoker<ShowServerVncResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowServerVncResponse>);
        }
        
        /// <summary>
        /// 修改服务器
        ///
        /// 修改服务器。
        /// &gt; - 服务器的状态修改为维护模式后，用户打开应用，选择可用的服务器进行接入的时候，会过滤掉处于维护模式的服务器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateServerResponse UpdateServer(UpdateServerRequest updateServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateServerRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateServerRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerializeNull<UpdateServerResponse>(response);
        }

        public SyncInvoker<UpdateServerResponse> UpdateServerInvoker(UpdateServerRequest updateServerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateServerRequest.ServerId, out var valueOfServerId)) urlParam.Add("server_id", valueOfServerId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-servers/{server_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateServerRequest);
            return new SyncInvoker<UpdateServerResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<UpdateServerResponse>);
        }
        
        /// <summary>
        /// 创建服务器组
        ///
        /// 创建服务器组。
        /// &gt; - 服务器组是一组相同配置的服务器集合，服务器组内的服务器使用同一镜像创建，配置相同，运行相同的应用程序。用户在打开云应用时，会根据调度规则选取组内的一台可用服务器进行连接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateServerGroupResponse CreateServerGroup(CreateServerGroupRequest createServerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createServerGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateServerGroupResponse>(response);
        }

        public SyncInvoker<CreateServerGroupResponse> CreateServerGroupInvoker(CreateServerGroupRequest createServerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createServerGroupRequest);
            return new SyncInvoker<CreateServerGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateServerGroupResponse>);
        }
        
        /// <summary>
        /// 删除服务器组
        ///
        /// 删除服务器组。
        /// - &gt; 删除服务器组之前，需要先删除服务器组内的所有服务器。如果传服务器组已被删除，重复执行删除，则返回成功响应。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteServerGroupsResponse DeleteServerGroups(DeleteServerGroupsRequest deleteServerGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteServerGroupsRequest.ServerGroupId, out var valueOfServerGroupId)) urlParam.Add("server_group_id", valueOfServerGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-groups/{server_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServerGroupsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteServerGroupsResponse>(response);
        }

        public SyncInvoker<DeleteServerGroupsResponse> DeleteServerGroupsInvoker(DeleteServerGroupsRequest deleteServerGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteServerGroupsRequest.ServerGroupId, out var valueOfServerGroupId)) urlParam.Add("server_group_id", valueOfServerGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-groups/{server_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServerGroupsRequest);
            return new SyncInvoker<DeleteServerGroupsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteServerGroupsResponse>);
        }
        
        /// <summary>
        /// 查询服务器组列表
        ///
        /// 查询服务器组列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListServerGroupsResponse ListServerGroups(ListServerGroupsRequest listServerGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListServerGroupsResponse>(response);
        }

        public SyncInvoker<ListServerGroupsResponse> ListServerGroupsInvoker(ListServerGroupsRequest listServerGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerGroupsRequest);
            return new SyncInvoker<ListServerGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServerGroupsResponse>);
        }
        
        /// <summary>
        /// 查询租户服务器组基础信息列表
        ///
        /// 查询租户服务器组基础信息列表(用于创建应用组时绑定服务器组)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTenantServerGroupsResponse ListTenantServerGroups(ListTenantServerGroupsRequest listTenantServerGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-groups/actions/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantServerGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTenantServerGroupsResponse>(response);
        }

        public SyncInvoker<ListTenantServerGroupsResponse> ListTenantServerGroupsInvoker(ListTenantServerGroupsRequest listTenantServerGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-groups/actions/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantServerGroupsRequest);
            return new SyncInvoker<ListTenantServerGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTenantServerGroupsResponse>);
        }
        
        /// <summary>
        /// 查询指定服务器组
        ///
        /// 查询指定的服务器组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowServerGroupResponse ShowServerGroup(ShowServerGroupRequest showServerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showServerGroupRequest.ServerGroupId, out var valueOfServerGroupId)) urlParam.Add("server_group_id", valueOfServerGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-groups/{server_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowServerGroupResponse>(response);
        }

        public SyncInvoker<ShowServerGroupResponse> ShowServerGroupInvoker(ShowServerGroupRequest showServerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showServerGroupRequest.ServerGroupId, out var valueOfServerGroupId)) urlParam.Add("server_group_id", valueOfServerGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-groups/{server_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerGroupRequest);
            return new SyncInvoker<ShowServerGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowServerGroupResponse>);
        }
        
        /// <summary>
        /// 指定租户服务器组限制查询
        ///
        /// 指定租户服务器组限制查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowServerGroupRestrictResponse ShowServerGroupRestrict(ShowServerGroupRestrictRequest showServerGroupRestrictRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-groups/resources/restrict", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerGroupRestrictRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowServerGroupRestrictResponse>(response);
        }

        public SyncInvoker<ShowServerGroupRestrictResponse> ShowServerGroupRestrictInvoker(ShowServerGroupRestrictRequest showServerGroupRestrictRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-groups/resources/restrict", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerGroupRestrictRequest);
            return new SyncInvoker<ShowServerGroupRestrictResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowServerGroupRestrictResponse>);
        }
        
        /// <summary>
        /// 查询指定服务器组内服务器状态
        ///
        /// 查询指定的服务器组内服务器状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowServerGroupStateResponse ShowServerGroupState(ShowServerGroupStateRequest showServerGroupStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showServerGroupStateRequest.ServerGroupId, out var valueOfServerGroupId)) urlParam.Add("server_group_id", valueOfServerGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-groups/{server_group_id}/state", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerGroupStateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowServerGroupStateResponse>(response);
        }

        public SyncInvoker<ShowServerGroupStateResponse> ShowServerGroupStateInvoker(ShowServerGroupStateRequest showServerGroupStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showServerGroupStateRequest.ServerGroupId, out var valueOfServerGroupId)) urlParam.Add("server_group_id", valueOfServerGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-groups/{server_group_id}/state", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerGroupStateRequest);
            return new SyncInvoker<ShowServerGroupStateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowServerGroupStateResponse>);
        }
        
        /// <summary>
        /// 修改服务器组
        ///
        /// 修改服务器组。
        /// - &gt; 修改服务器组的镜像，系统盘大小，OU信息后，已创建的服务器配置不变，新添加的服务器会使用新的配置创建。修改最大会话数后，用户接入服务器组时，会按照最新的配置进行路由计算。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateServerGroupResponse UpdateServerGroup(UpdateServerGroupRequest updateServerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateServerGroupRequest.ServerGroupId, out var valueOfServerGroupId)) urlParam.Add("server_group_id", valueOfServerGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-groups/{server_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateServerGroupRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerializeNull<UpdateServerGroupResponse>(response);
        }

        public SyncInvoker<UpdateServerGroupResponse> UpdateServerGroupInvoker(UpdateServerGroupRequest updateServerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateServerGroupRequest.ServerGroupId, out var valueOfServerGroupId)) urlParam.Add("server_group_id", valueOfServerGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-groups/{server_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateServerGroupRequest);
            return new SyncInvoker<UpdateServerGroupResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<UpdateServerGroupResponse>);
        }
        
        /// <summary>
        /// 校验服务器组
        ///
        /// 校验服务器组是否符合指定的规则。
        /// 1. 校验服务器组名称是否符合规则。
        /// 2. 校验服务器组名称是否重复。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ValidateServerGroupResponse ValidateServerGroup(ValidateServerGroupRequest validateServerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-groups/rules/validate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", validateServerGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ValidateServerGroupResponse>(response);
        }

        public SyncInvoker<ValidateServerGroupResponse> ValidateServerGroupInvoker(ValidateServerGroupRequest validateServerGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/app-server-groups/rules/validate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", validateServerGroupRequest);
            return new SyncInvoker<ValidateServerGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<ValidateServerGroupResponse>);
        }
        
        /// <summary>
        /// 导出应用使用记录
        ///
        /// 导出应用使用记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExportAppConnectionResponse ExportAppConnection(ExportAppConnectionRequest exportAppConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/session/app-connection/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportAppConnectionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExportAppConnectionResponse>(response);
        }

        public SyncInvoker<ExportAppConnectionResponse> ExportAppConnectionInvoker(ExportAppConnectionRequest exportAppConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/session/app-connection/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportAppConnectionRequest);
            return new SyncInvoker<ExportAppConnectionResponse>(this, "POST", request, JsonUtils.DeSerialize<ExportAppConnectionResponse>);
        }
        
        /// <summary>
        /// 导出用户会话列表
        ///
        /// 导出用户会话列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExportSessionsResponse ExportSessions(ExportSessionsRequest exportSessionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/session/list-sessions/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportSessionsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExportSessionsResponse>(response);
        }

        public SyncInvoker<ExportSessionsResponse> ExportSessionsInvoker(ExportSessionsRequest exportSessionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/session/list-sessions/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportSessionsRequest);
            return new SyncInvoker<ExportSessionsResponse>(this, "POST", request, JsonUtils.DeSerialize<ExportSessionsResponse>);
        }
        
        /// <summary>
        /// 导出用户登录记录
        ///
        /// 导出用户登录记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExportUserConnectionResponse ExportUserConnection(ExportUserConnectionRequest exportUserConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/session/user-connection/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportUserConnectionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExportUserConnectionResponse>(response);
        }

        public SyncInvoker<ExportUserConnectionResponse> ExportUserConnectionInvoker(ExportUserConnectionRequest exportUserConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/session/user-connection/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportUserConnectionRequest);
            return new SyncInvoker<ExportUserConnectionResponse>(this, "POST", request, JsonUtils.DeSerialize<ExportUserConnectionResponse>);
        }
        
        /// <summary>
        /// 查询应用使用记录
        ///
        /// 查询应用使用记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAppConnectionResponse ListAppConnection(ListAppConnectionRequest listAppConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/session/app-connection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppConnectionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListAppConnectionResponse>(response);
        }

        public SyncInvoker<ListAppConnectionResponse> ListAppConnectionInvoker(ListAppConnectionRequest listAppConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/session/app-connection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppConnectionRequest);
            return new SyncInvoker<ListAppConnectionResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAppConnectionResponse>);
        }
        
        /// <summary>
        /// 根据用户名查询当前会话
        ///
        /// 根据用户名查询当前会话。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSessionByUserNameResponse ListSessionByUserName(ListSessionByUserNameRequest listSessionByUserNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/session/user-session-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSessionByUserNameRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSessionByUserNameResponse>(response);
        }

        public SyncInvoker<ListSessionByUserNameResponse> ListSessionByUserNameInvoker(ListSessionByUserNameRequest listSessionByUserNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/session/user-session-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSessionByUserNameRequest);
            return new SyncInvoker<ListSessionByUserNameResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSessionByUserNameResponse>);
        }
        
        /// <summary>
        /// 查询用户会话列表
        ///
        /// 查询用户会话列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSessionsResponse ListSessions(ListSessionsRequest listSessionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/session/list-sessions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSessionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSessionsResponse>(response);
        }

        public SyncInvoker<ListSessionsResponse> ListSessionsInvoker(ListSessionsRequest listSessionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/session/list-sessions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSessionsRequest);
            return new SyncInvoker<ListSessionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSessionsResponse>);
        }
        
        /// <summary>
        /// 查询用户登录记录
        ///
        /// 查询用户登录记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUserConnectionResponse ListUserConnection(ListUserConnectionRequest listUserConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/session/user-connection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserConnectionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListUserConnectionResponse>(response);
        }

        public SyncInvoker<ListUserConnectionResponse> ListUserConnectionInvoker(ListUserConnectionRequest listUserConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/session/user-connection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserConnectionRequest);
            return new SyncInvoker<ListUserConnectionResponse>(this, "POST", request, JsonUtils.DeSerialize<ListUserConnectionResponse>);
        }
        
        /// <summary>
        /// 用户会话注销
        ///
        /// 用户会话注销。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public LogoffUserSessionResponse LogoffUserSession(LogoffUserSessionRequest logoffUserSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/session/logoff", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", logoffUserSessionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<LogoffUserSessionResponse>(response);
        }

        public SyncInvoker<LogoffUserSessionResponse> LogoffUserSessionInvoker(LogoffUserSessionRequest logoffUserSessionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/session/logoff", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", logoffUserSessionRequest);
            return new SyncInvoker<LogoffUserSessionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<LogoffUserSessionResponse>);
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
        public BatchCreateServerGroupTagsResponse BatchCreateServerGroupTags(BatchCreateServerGroupTagsRequest batchCreateServerGroupTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/server-group/tags/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateServerGroupTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateServerGroupTagsResponse>(response);
        }

        public SyncInvoker<BatchCreateServerGroupTagsResponse> BatchCreateServerGroupTagsInvoker(BatchCreateServerGroupTagsRequest batchCreateServerGroupTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/server-group/tags/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateServerGroupTagsRequest);
            return new SyncInvoker<BatchCreateServerGroupTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateServerGroupTagsResponse>);
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
        public BatchDeleteServerGroupTagsResponse BatchDeleteServerGroupTags(BatchDeleteServerGroupTagsRequest batchDeleteServerGroupTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/server-group/tags/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteServerGroupTagsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<BatchDeleteServerGroupTagsResponse>(response);
        }

        public SyncInvoker<BatchDeleteServerGroupTagsResponse> BatchDeleteServerGroupTagsInvoker(BatchDeleteServerGroupTagsRequest batchDeleteServerGroupTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/server-group/tags/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteServerGroupTagsRequest);
            return new SyncInvoker<BatchDeleteServerGroupTagsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<BatchDeleteServerGroupTagsResponse>);
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
        public CreateServerGroupTagsResponse CreateServerGroupTags(CreateServerGroupTagsRequest createServerGroupTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createServerGroupTagsRequest.ServerGroupId, out var valueOfServerGroupId)) urlParam.Add("server_group_id", valueOfServerGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/server-group/{server_group_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createServerGroupTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateServerGroupTagsResponse>(response);
        }

        public SyncInvoker<CreateServerGroupTagsResponse> CreateServerGroupTagsInvoker(CreateServerGroupTagsRequest createServerGroupTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createServerGroupTagsRequest.ServerGroupId, out var valueOfServerGroupId)) urlParam.Add("server_group_id", valueOfServerGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/server-group/{server_group_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createServerGroupTagsRequest);
            return new SyncInvoker<CreateServerGroupTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateServerGroupTagsResponse>);
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
        public DeleteServerGroupTagsResponse DeleteServerGroupTags(DeleteServerGroupTagsRequest deleteServerGroupTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteServerGroupTagsRequest.ServerGroupId, out var valueOfServerGroupId)) urlParam.Add("server_group_id", valueOfServerGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/server-group/{server_group_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServerGroupTagsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteServerGroupTagsResponse>(response);
        }

        public SyncInvoker<DeleteServerGroupTagsResponse> DeleteServerGroupTagsInvoker(DeleteServerGroupTagsRequest deleteServerGroupTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteServerGroupTagsRequest.ServerGroupId, out var valueOfServerGroupId)) urlParam.Add("server_group_id", valueOfServerGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/server-group/{server_group_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteServerGroupTagsRequest);
            return new SyncInvoker<DeleteServerGroupTagsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteServerGroupTagsResponse>);
        }
        
        /// <summary>
        /// 查询租户在所有服务器组上的标签
        ///
        /// 查询租户在所有服务器组上的资源标签集合。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListServerGroupTagResponse ListServerGroupTag(ListServerGroupTagRequest listServerGroupTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/server-group/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerGroupTagRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListServerGroupTagResponse>(response);
        }

        public SyncInvoker<ListServerGroupTagResponse> ListServerGroupTagInvoker(ListServerGroupTagRequest listServerGroupTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/server-group/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listServerGroupTagRequest);
            return new SyncInvoker<ListServerGroupTagResponse>(this, "GET", request, JsonUtils.DeSerialize<ListServerGroupTagResponse>);
        }
        
        /// <summary>
        /// 查询服务器组的标签
        ///
        /// 查询指定服务器组的标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowServerGroupTagResponse ShowServerGroupTag(ShowServerGroupTagRequest showServerGroupTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showServerGroupTagRequest.ServerGroupId, out var valueOfServerGroupId)) urlParam.Add("server_group_id", valueOfServerGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/server-group/{server_group_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerGroupTagRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowServerGroupTagResponse>(response);
        }

        public SyncInvoker<ShowServerGroupTagResponse> ShowServerGroupTagInvoker(ShowServerGroupTagRequest showServerGroupTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showServerGroupTagRequest.ServerGroupId, out var valueOfServerGroupId)) urlParam.Add("server_group_id", valueOfServerGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/server-group/{server_group_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showServerGroupTagRequest);
            return new SyncInvoker<ShowServerGroupTagResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowServerGroupTagResponse>);
        }
        
        /// <summary>
        /// 查询可用磁盘类型
        ///
        /// 该接口用于查询可用磁盘类型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListVolumeTypeResponse ListVolumeType(ListVolumeTypeRequest listVolumeTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/volume-type", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVolumeTypeRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListVolumeTypeResponse>(response);
        }

        public SyncInvoker<ListVolumeTypeResponse> ListVolumeTypeInvoker(ListVolumeTypeRequest listVolumeTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/volume-type", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVolumeTypeRequest);
            return new SyncInvoker<ListVolumeTypeResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVolumeTypeResponse>);
        }
        
    }
}