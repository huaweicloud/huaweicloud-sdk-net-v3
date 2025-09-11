using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Cpcs.V1.Model;

namespace HuaweiCloud.SDK.Cpcs.V1
{
    public partial class CpcsAsyncClient : Client
    {
        public static ClientBuilder<CpcsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<CpcsAsyncClient>();
        }

        
        /// <summary>
        /// 创建密码服务集群与应用绑定关系
        ///
        /// 创建密码服务集群与应用绑定关系
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociateAppsResponse> AssociateAppsAsync(AssociateAppsRequest associateAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/associate-apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateAppsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AssociateAppsResponse>(response);
        }

        public AsyncInvoker<AssociateAppsResponse> AssociateAppsAsyncInvoker(AssociateAppsRequest associateAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/associate-apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateAppsRequest);
            return new AsyncInvoker<AssociateAppsResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateAppsResponse>);
        }
        
        /// <summary>
        /// 密码服务集群授予应用访问密钥的访问权限
        ///
        /// 密码服务集群授予应用访问密钥的访问权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AuthorizeAccessKeysResponse> AuthorizeAccessKeysAsync(AuthorizeAccessKeysRequest authorizeAccessKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(authorizeAccessKeysRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}/authorize-access-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", authorizeAccessKeysRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AuthorizeAccessKeysResponse>(response);
        }

        public AsyncInvoker<AuthorizeAccessKeysResponse> AuthorizeAccessKeysAsyncInvoker(AuthorizeAccessKeysRequest authorizeAccessKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(authorizeAccessKeysRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}/authorize-access-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", authorizeAccessKeysRequest);
            return new AsyncInvoker<AuthorizeAccessKeysResponse>(this, "POST", request, JsonUtils.DeSerialize<AuthorizeAccessKeysResponse>);
        }
        
        /// <summary>
        /// 停用应用的访问密钥
        ///
        /// 停用应用的访问密钥
        /// &gt; 只有当访问密钥处于“启用”状态时，方可调用此接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDisableAccessKeysResponse> BatchDisableAccessKeysAsync(BatchDisableAccessKeysRequest batchDisableAccessKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDisableAccessKeysRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/apps/{app_id}/access-keys/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDisableAccessKeysRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchDisableAccessKeysResponse>(response);
        }

        public AsyncInvoker<BatchDisableAccessKeysResponse> BatchDisableAccessKeysAsyncInvoker(BatchDisableAccessKeysRequest batchDisableAccessKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDisableAccessKeysRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/apps/{app_id}/access-keys/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDisableAccessKeysRequest);
            return new AsyncInvoker<BatchDisableAccessKeysResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDisableAccessKeysResponse>);
        }
        
        /// <summary>
        /// 启用应用的访问密钥
        ///
        /// 启用应用的访问密钥
        /// &gt; 只有当访问密钥处于“停用”状态时，方可调用此接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchEnableAccessKeysResponse> BatchEnableAccessKeysAsync(BatchEnableAccessKeysRequest batchEnableAccessKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchEnableAccessKeysRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/apps/{app_id}/access-keys/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchEnableAccessKeysRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchEnableAccessKeysResponse>(response);
        }

        public AsyncInvoker<BatchEnableAccessKeysResponse> BatchEnableAccessKeysAsyncInvoker(BatchEnableAccessKeysRequest batchEnableAccessKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchEnableAccessKeysRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/apps/{app_id}/access-keys/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchEnableAccessKeysRequest);
            return new AsyncInvoker<BatchEnableAccessKeysResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchEnableAccessKeysResponse>);
        }
        
        /// <summary>
        /// 密码服务集群解除对访问密钥的授权
        ///
        /// 密码服务集群解除对访问密钥的授权
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CancelAuthorizeAccessKeysResponse> CancelAuthorizeAccessKeysAsync(CancelAuthorizeAccessKeysRequest cancelAuthorizeAccessKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(cancelAuthorizeAccessKeysRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}/de-authorize-access-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelAuthorizeAccessKeysRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CancelAuthorizeAccessKeysResponse>(response);
        }

        public AsyncInvoker<CancelAuthorizeAccessKeysResponse> CancelAuthorizeAccessKeysAsyncInvoker(CancelAuthorizeAccessKeysRequest cancelAuthorizeAccessKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(cancelAuthorizeAccessKeysRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}/de-authorize-access-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelAuthorizeAccessKeysRequest);
            return new AsyncInvoker<CancelAuthorizeAccessKeysResponse>(this, "POST", request, JsonUtils.DeSerialize<CancelAuthorizeAccessKeysResponse>);
        }
        
        /// <summary>
        /// 创建应用
        ///
        /// 创建应用
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAppResponse> CreateAppAsync(CreateAppRequest createAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAppResponse>(response);
        }

        public AsyncInvoker<CreateAppResponse> CreateAppAsyncInvoker(CreateAppRequest createAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppRequest);
            return new AsyncInvoker<CreateAppResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAppResponse>);
        }
        
        /// <summary>
        /// 创建访问密钥
        ///
        /// 创建访问密钥
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAppAccessKeyResponse> CreateAppAccessKeyAsync(CreateAppAccessKeyRequest createAppAccessKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAppAccessKeyRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/apps/{app_id}/access-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppAccessKeyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAppAccessKeyResponse>(response);
        }

        public AsyncInvoker<CreateAppAccessKeyResponse> CreateAppAccessKeyAsyncInvoker(CreateAppAccessKeyRequest createAppAccessKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAppAccessKeyRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/apps/{app_id}/access-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppAccessKeyRequest);
            return new AsyncInvoker<CreateAppAccessKeyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAppAccessKeyResponse>);
        }
        
        /// <summary>
        /// 创建密码服务集群
        ///
        /// 创建密码服务集群
        /// &gt; 调用接口之后返回订单ID，需要到“待支付订单里面”支付成功之后才能创建密码服务集群。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest createClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createClusterRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateClusterResponse>(response);
        }

        public AsyncInvoker<CreateClusterResponse> CreateClusterAsyncInvoker(CreateClusterRequest createClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createClusterRequest);
            return new AsyncInvoker<CreateClusterResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateClusterResponse>);
        }
        
        /// <summary>
        /// 删除应用的访问密钥
        ///
        /// 删除应用的访问密钥
        /// &gt; 只有当访问密钥处于“停用”状态时，方可调用此接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAccessKeyResponse> DeleteAccessKeyAsync(DeleteAccessKeyRequest deleteAccessKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAccessKeyRequest.AccessKeyId, out var valueOfAccessKeyId)) urlParam.Add("access_key_id", valueOfAccessKeyId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAccessKeyRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/apps/{app_id}/access-keys/{access_key_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAccessKeyRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAccessKeyResponse>(response);
        }

        public AsyncInvoker<DeleteAccessKeyResponse> DeleteAccessKeyAsyncInvoker(DeleteAccessKeyRequest deleteAccessKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAccessKeyRequest.AccessKeyId, out var valueOfAccessKeyId)) urlParam.Add("access_key_id", valueOfAccessKeyId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAccessKeyRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/apps/{app_id}/access-keys/{access_key_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAccessKeyRequest);
            return new AsyncInvoker<DeleteAccessKeyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAccessKeyResponse>);
        }
        
        /// <summary>
        /// 删除应用
        ///
        /// 删除应用
        /// &gt; 只有当应用与任何其它服务没有绑定关系的情况下，方可进行集群删除操作该操作不可恢复，请谨慎执行
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAppResponse> DeleteAppAsync(DeleteAppRequest deleteAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAppRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAppResponse>(response);
        }

        public AsyncInvoker<DeleteAppResponse> DeleteAppAsyncInvoker(DeleteAppRequest deleteAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAppRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppRequest);
            return new AsyncInvoker<DeleteAppResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAppResponse>);
        }
        
        /// <summary>
        /// 删除密码服务集群
        ///
        /// 删除密码服务集群，即释放密码服务集群所有服务实例以及对应的VSM集群实例，并删除集群相关信息
        /// &gt; 只有当集群与任何应用都没有绑定关系的情况下，且处于“运行中”状态，且退订了集群中所有实例，方可进行集群删除操作，该操作不可恢复，请谨慎执行
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteCcspClusterResponse> DeleteCcspClusterAsync(DeleteCcspClusterRequest deleteCcspClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteCcspClusterRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCcspClusterRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteCcspClusterResponse>(response);
        }

        public AsyncInvoker<DeleteCcspClusterResponse> DeleteCcspClusterAsyncInvoker(DeleteCcspClusterRequest deleteCcspClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteCcspClusterRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCcspClusterRequest);
            return new AsyncInvoker<DeleteCcspClusterResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteCcspClusterResponse>);
        }
        
        /// <summary>
        /// 停用密码服务实例的业务功能
        ///
        /// 停用密码服务实例的业务功能
        /// &gt; 只有当密码服务实例处于“启用”状态时，方可调用此接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisableCcspInstanceResponse> DisableCcspInstanceAsync(DisableCcspInstanceRequest disableCcspInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disableCcspInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/instances/{instance_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableCcspInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DisableCcspInstanceResponse>(response);
        }

        public AsyncInvoker<DisableCcspInstanceResponse> DisableCcspInstanceAsyncInvoker(DisableCcspInstanceRequest disableCcspInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disableCcspInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/instances/{instance_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableCcspInstanceRequest);
            return new AsyncInvoker<DisableCcspInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<DisableCcspInstanceResponse>);
        }
        
        /// <summary>
        /// 解除密码服务集群与应用绑定关系
        ///
        /// 解除密码服务集群与应用绑定关系
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisassociateAppsResponse> DisassociateAppsAsync(DisassociateAppsRequest disassociateAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/disassociate-apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateAppsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DisassociateAppsResponse>(response);
        }

        public AsyncInvoker<DisassociateAppsResponse> DisassociateAppsAsyncInvoker(DisassociateAppsRequest disassociateAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/disassociate-apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateAppsRequest);
            return new AsyncInvoker<DisassociateAppsResponse>(this, "POST", request, JsonUtils.DeSerialize<DisassociateAppsResponse>);
        }
        
        /// <summary>
        /// 启用密码服务实例的业务功能
        ///
        /// 启用密码服务实例的业务功能
        /// &gt; 只有当密码服务实例处于“停用”状态时，方可调用此接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EnableCcspInstanceResponse> EnableCcspInstanceAsync(EnableCcspInstanceRequest enableCcspInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableCcspInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/instances/{instance_id}/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableCcspInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<EnableCcspInstanceResponse>(response);
        }

        public AsyncInvoker<EnableCcspInstanceResponse> EnableCcspInstanceAsyncInvoker(EnableCcspInstanceRequest enableCcspInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableCcspInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/instances/{instance_id}/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableCcspInstanceRequest);
            return new AsyncInvoker<EnableCcspInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<EnableCcspInstanceResponse>);
        }
        
        /// <summary>
        /// 查询密码服务的镜像
        ///
        /// 查询密码服务的镜像
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCcspTenantImagesResponse> ListCcspTenantImagesAsync(ListCcspTenantImagesRequest listCcspTenantImagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/images", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCcspTenantImagesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCcspTenantImagesResponse>(response);
        }

        public AsyncInvoker<ListCcspTenantImagesResponse> ListCcspTenantImagesAsyncInvoker(ListCcspTenantImagesRequest listCcspTenantImagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/images", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCcspTenantImagesRequest);
            return new AsyncInvoker<ListCcspTenantImagesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCcspTenantImagesResponse>);
        }
        
        /// <summary>
        /// 下载访问密钥
        ///
        /// 下载访问密钥且只能下载一次。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAccessKeyResponse> ShowAccessKeyAsync(ShowAccessKeyRequest showAccessKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAccessKeyRequest.AccessKeyId, out var valueOfAccessKeyId)) urlParam.Add("access_key_id", valueOfAccessKeyId);
            if (StringUtils.TryConvertToNonEmptyString(showAccessKeyRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/apps/{app_id}/access-keys/{access_key_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAccessKeyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAccessKeyResponse>(response);
        }

        public AsyncInvoker<ShowAccessKeyResponse> ShowAccessKeyAsyncInvoker(ShowAccessKeyRequest showAccessKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAccessKeyRequest.AccessKeyId, out var valueOfAccessKeyId)) urlParam.Add("access_key_id", valueOfAccessKeyId);
            if (StringUtils.TryConvertToNonEmptyString(showAccessKeyRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/apps/{app_id}/access-keys/{access_key_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAccessKeyRequest);
            return new AsyncInvoker<ShowAccessKeyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAccessKeyResponse>);
        }
        
        /// <summary>
        /// 查询应用的访问密钥列表
        ///
        /// 查询应用的访问密钥列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAppAccessKeyListResponse> ShowAppAccessKeyListAsync(ShowAppAccessKeyListRequest showAppAccessKeyListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAppAccessKeyListRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/apps/{app_id}/access-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppAccessKeyListRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAppAccessKeyListResponse>(response);
        }

        public AsyncInvoker<ShowAppAccessKeyListResponse> ShowAppAccessKeyListAsyncInvoker(ShowAppAccessKeyListRequest showAppAccessKeyListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAppAccessKeyListRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/apps/{app_id}/access-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppAccessKeyListRequest);
            return new AsyncInvoker<ShowAppAccessKeyListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAppAccessKeyListResponse>);
        }
        
        /// <summary>
        /// 查询应用列表
        ///
        /// 查询应用列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAppListResponse> ShowAppListAsync(ShowAppListRequest showAppListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppListRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAppListResponse>(response);
        }

        public AsyncInvoker<ShowAppListResponse> ShowAppListAsyncInvoker(ShowAppListRequest showAppListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppListRequest);
            return new AsyncInvoker<ShowAppListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAppListResponse>);
        }
        
        /// <summary>
        /// 查询密码服务集群与应用的绑定关系列表
        ///
        /// 查询密码服务集群与应用的绑定关系列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAssociationListResponse> ShowAssociationListAsync(ShowAssociationListRequest showAssociationListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/associations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssociationListRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAssociationListResponse>(response);
        }

        public AsyncInvoker<ShowAssociationListResponse> ShowAssociationListAsyncInvoker(ShowAssociationListRequest showAssociationListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/associations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssociationListRequest);
            return new AsyncInvoker<ShowAssociationListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAssociationListResponse>);
        }
        
        /// <summary>
        /// 查询可创建密码服务集群的可用区列表
        ///
        /// 查询可创建密码服务集群的可用区列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAvailableAzResponse> ShowAvailableAzAsync(ShowAvailableAzRequest showAvailableAzRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/az", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAvailableAzRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAvailableAzResponse>(response);
        }

        public AsyncInvoker<ShowAvailableAzResponse> ShowAvailableAzAsyncInvoker(ShowAvailableAzRequest showAvailableAzRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/az", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAvailableAzRequest);
            return new AsyncInvoker<ShowAvailableAzResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAvailableAzResponse>);
        }
        
        /// <summary>
        /// 查询密码服务集群详情
        ///
        /// 查询密码服务集群信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCcspClusterResponse> ShowCcspClusterAsync(ShowCcspClusterRequest showCcspClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCcspClusterRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCcspClusterRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowCcspClusterResponse>(response);
        }

        public AsyncInvoker<ShowCcspClusterResponse> ShowCcspClusterAsyncInvoker(ShowCcspClusterRequest showCcspClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCcspClusterRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCcspClusterRequest);
            return new AsyncInvoker<ShowCcspClusterResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCcspClusterResponse>);
        }
        
        /// <summary>
        /// 查询密码服务集群列表
        ///
        /// 查询密码服务集群列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCcspClusterListResponse> ShowCcspClusterListAsync(ShowCcspClusterListRequest showCcspClusterListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCcspClusterListRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowCcspClusterListResponse>(response);
        }

        public AsyncInvoker<ShowCcspClusterListResponse> ShowCcspClusterListAsyncInvoker(ShowCcspClusterListRequest showCcspClusterListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCcspClusterListRequest);
            return new AsyncInvoker<ShowCcspClusterListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCcspClusterListResponse>);
        }
        
        /// <summary>
        /// 查询密码服务实例列表
        ///
        /// 查询密码服务实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCcspInstanceInfoResponse> ShowCcspInstanceInfoAsync(ShowCcspInstanceInfoRequest showCcspInstanceInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCcspInstanceInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowCcspInstanceInfoResponse>(response);
        }

        public AsyncInvoker<ShowCcspInstanceInfoResponse> ShowCcspInstanceInfoAsyncInvoker(ShowCcspInstanceInfoRequest showCcspInstanceInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCcspInstanceInfoRequest);
            return new AsyncInvoker<ShowCcspInstanceInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCcspInstanceInfoResponse>);
        }
        
        /// <summary>
        /// 查询密码服务集群已授权的访问密钥列表
        ///
        /// 查询密码服务集群已授权的访问密钥列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowClusterAccessKeyListResponse> ShowClusterAccessKeyListAsync(ShowClusterAccessKeyListRequest showClusterAccessKeyListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showClusterAccessKeyListRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}/access-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterAccessKeyListRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowClusterAccessKeyListResponse>(response);
        }

        public AsyncInvoker<ShowClusterAccessKeyListResponse> ShowClusterAccessKeyListAsyncInvoker(ShowClusterAccessKeyListRequest showClusterAccessKeyListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showClusterAccessKeyListRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}/access-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterAccessKeyListRequest);
            return new AsyncInvoker<ShowClusterAccessKeyListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowClusterAccessKeyListResponse>);
        }
        
        /// <summary>
        /// 获取密码服务管理界面URL
        ///
        /// 获取密码服务管理界面URL
        /// &gt; URL存在有效期，URL失效后无法跳转管理界面，需要重新获取URL
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowClusterUriResponse> ShowClusterUriAsync(ShowClusterUriRequest showClusterUriRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showClusterUriRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}/uri", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterUriRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowClusterUriResponse>(response);
        }

        public AsyncInvoker<ShowClusterUriResponse> ShowClusterUriAsyncInvoker(ShowClusterUriRequest showClusterUriRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showClusterUriRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}/uri", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterUriRequest);
            return new AsyncInvoker<ShowClusterUriResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowClusterUriResponse>);
        }
        
        /// <summary>
        /// 查询租户的资源分布信息
        ///
        /// 查询租户的资源分布信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowResourceInfoResponse> ShowResourceInfoAsync(ShowResourceInfoRequest showResourceInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/resource-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowResourceInfoResponse>(response);
        }

        public AsyncInvoker<ShowResourceInfoResponse> ShowResourceInfoAsyncInvoker(ShowResourceInfoRequest showResourceInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/resource-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceInfoRequest);
            return new AsyncInvoker<ShowResourceInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceInfoResponse>);
        }
        
        /// <summary>
        /// 密码资源指标监控
        ///
        /// 获取密码服务实例与虚拟密码机实例的指标（cpu使用率，内存使用率等指标）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowVmMonitorResponse> ShowVmMonitorAsync(ShowVmMonitorRequest showVmMonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/vm-monitor", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVmMonitorRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowVmMonitorResponse>(response);
        }

        public AsyncInvoker<ShowVmMonitorResponse> ShowVmMonitorAsyncInvoker(ShowVmMonitorRequest showVmMonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/vm-monitor", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVmMonitorRequest);
            return new AsyncInvoker<ShowVmMonitorResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVmMonitorResponse>);
        }
        
    }
}