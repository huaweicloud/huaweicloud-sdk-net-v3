using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Cpcs.V1.Model;

namespace HuaweiCloud.SDK.Cpcs.V1
{
    public partial class CpcsClient : Client
    {
        public static ClientBuilder<CpcsClient> NewBuilder()
        {
            return new ClientBuilder<CpcsClient>();
        }

        
        /// <summary>
        /// 创建密码服务集群与应用绑定关系
        ///
        /// 创建密码服务集群与应用绑定关系
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AssociateAppsResponse AssociateApps(AssociateAppsRequest associateAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/associate-apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateAppsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AssociateAppsResponse>(response);
        }

        public SyncInvoker<AssociateAppsResponse> AssociateAppsInvoker(AssociateAppsRequest associateAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/associate-apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateAppsRequest);
            return new SyncInvoker<AssociateAppsResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateAppsResponse>);
        }
        
        /// <summary>
        /// 密码服务集群授予应用访问密钥的访问权限
        ///
        /// 密码服务集群授予应用访问密钥的访问权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AuthorizeAccessKeysResponse AuthorizeAccessKeys(AuthorizeAccessKeysRequest authorizeAccessKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(authorizeAccessKeysRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}/authorize-access-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", authorizeAccessKeysRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AuthorizeAccessKeysResponse>(response);
        }

        public SyncInvoker<AuthorizeAccessKeysResponse> AuthorizeAccessKeysInvoker(AuthorizeAccessKeysRequest authorizeAccessKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(authorizeAccessKeysRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}/authorize-access-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", authorizeAccessKeysRequest);
            return new SyncInvoker<AuthorizeAccessKeysResponse>(this, "POST", request, JsonUtils.DeSerialize<AuthorizeAccessKeysResponse>);
        }
        
        /// <summary>
        /// 停用应用的访问密钥
        ///
        /// 停用应用的访问密钥
        /// &gt; 只有当访问密钥处于“启用”状态时，方可调用此接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDisableAccessKeysResponse BatchDisableAccessKeys(BatchDisableAccessKeysRequest batchDisableAccessKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDisableAccessKeysRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/apps/{app_id}/access-keys/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDisableAccessKeysRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDisableAccessKeysResponse>(response);
        }

        public SyncInvoker<BatchDisableAccessKeysResponse> BatchDisableAccessKeysInvoker(BatchDisableAccessKeysRequest batchDisableAccessKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDisableAccessKeysRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/apps/{app_id}/access-keys/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDisableAccessKeysRequest);
            return new SyncInvoker<BatchDisableAccessKeysResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDisableAccessKeysResponse>);
        }
        
        /// <summary>
        /// 启用应用的访问密钥
        ///
        /// 启用应用的访问密钥
        /// &gt; 只有当访问密钥处于“停用”状态时，方可调用此接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchEnableAccessKeysResponse BatchEnableAccessKeys(BatchEnableAccessKeysRequest batchEnableAccessKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchEnableAccessKeysRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/apps/{app_id}/access-keys/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchEnableAccessKeysRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchEnableAccessKeysResponse>(response);
        }

        public SyncInvoker<BatchEnableAccessKeysResponse> BatchEnableAccessKeysInvoker(BatchEnableAccessKeysRequest batchEnableAccessKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchEnableAccessKeysRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/apps/{app_id}/access-keys/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchEnableAccessKeysRequest);
            return new SyncInvoker<BatchEnableAccessKeysResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchEnableAccessKeysResponse>);
        }
        
        /// <summary>
        /// 密码服务集群解除对访问密钥的授权
        ///
        /// 密码服务集群解除对访问密钥的授权
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CancelAuthorizeAccessKeysResponse CancelAuthorizeAccessKeys(CancelAuthorizeAccessKeysRequest cancelAuthorizeAccessKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(cancelAuthorizeAccessKeysRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}/de-authorize-access-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelAuthorizeAccessKeysRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CancelAuthorizeAccessKeysResponse>(response);
        }

        public SyncInvoker<CancelAuthorizeAccessKeysResponse> CancelAuthorizeAccessKeysInvoker(CancelAuthorizeAccessKeysRequest cancelAuthorizeAccessKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(cancelAuthorizeAccessKeysRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}/de-authorize-access-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelAuthorizeAccessKeysRequest);
            return new SyncInvoker<CancelAuthorizeAccessKeysResponse>(this, "POST", request, JsonUtils.DeSerialize<CancelAuthorizeAccessKeysResponse>);
        }
        
        /// <summary>
        /// 创建应用
        ///
        /// 创建应用
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAppResponse CreateApp(CreateAppRequest createAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAppResponse>(response);
        }

        public SyncInvoker<CreateAppResponse> CreateAppInvoker(CreateAppRequest createAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppRequest);
            return new SyncInvoker<CreateAppResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAppResponse>);
        }
        
        /// <summary>
        /// 创建访问密钥
        ///
        /// 创建访问密钥
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAppAccessKeyResponse CreateAppAccessKey(CreateAppAccessKeyRequest createAppAccessKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAppAccessKeyRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/apps/{app_id}/access-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppAccessKeyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAppAccessKeyResponse>(response);
        }

        public SyncInvoker<CreateAppAccessKeyResponse> CreateAppAccessKeyInvoker(CreateAppAccessKeyRequest createAppAccessKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAppAccessKeyRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/apps/{app_id}/access-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAppAccessKeyRequest);
            return new SyncInvoker<CreateAppAccessKeyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAppAccessKeyResponse>);
        }
        
        /// <summary>
        /// 创建密码服务集群
        ///
        /// 创建密码服务集群
        /// &gt; 调用接口之后返回订单ID，需要到“待支付订单里面”支付成功之后才能创建密码服务集群。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateClusterResponse CreateCluster(CreateClusterRequest createClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createClusterRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateClusterResponse>(response);
        }

        public SyncInvoker<CreateClusterResponse> CreateClusterInvoker(CreateClusterRequest createClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createClusterRequest);
            return new SyncInvoker<CreateClusterResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateClusterResponse>);
        }
        
        /// <summary>
        /// 删除应用的访问密钥
        ///
        /// 删除应用的访问密钥
        /// &gt; 只有当访问密钥处于“停用”状态时，方可调用此接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAccessKeyResponse DeleteAccessKey(DeleteAccessKeyRequest deleteAccessKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAccessKeyRequest.AccessKeyId, out var valueOfAccessKeyId)) urlParam.Add("access_key_id", valueOfAccessKeyId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAccessKeyRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/apps/{app_id}/access-keys/{access_key_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAccessKeyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAccessKeyResponse>(response);
        }

        public SyncInvoker<DeleteAccessKeyResponse> DeleteAccessKeyInvoker(DeleteAccessKeyRequest deleteAccessKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAccessKeyRequest.AccessKeyId, out var valueOfAccessKeyId)) urlParam.Add("access_key_id", valueOfAccessKeyId);
            if (StringUtils.TryConvertToNonEmptyString(deleteAccessKeyRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/apps/{app_id}/access-keys/{access_key_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAccessKeyRequest);
            return new SyncInvoker<DeleteAccessKeyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAccessKeyResponse>);
        }
        
        /// <summary>
        /// 删除应用
        ///
        /// 删除应用
        /// &gt; 只有当应用与任何其它服务没有绑定关系的情况下，方可进行集群删除操作该操作不可恢复，请谨慎执行
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAppResponse DeleteApp(DeleteAppRequest deleteAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAppRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAppResponse>(response);
        }

        public SyncInvoker<DeleteAppResponse> DeleteAppInvoker(DeleteAppRequest deleteAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAppRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppRequest);
            return new SyncInvoker<DeleteAppResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAppResponse>);
        }
        
        /// <summary>
        /// 删除密码服务集群
        ///
        /// 删除密码服务集群，即释放密码服务集群所有服务实例以及对应的VSM集群实例，并删除集群相关信息
        /// &gt; 只有当集群与任何应用都没有绑定关系的情况下，且处于“运行中”状态，且退订了集群中所有实例，方可进行集群删除操作，该操作不可恢复，请谨慎执行
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteCcspClusterResponse DeleteCcspCluster(DeleteCcspClusterRequest deleteCcspClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteCcspClusterRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCcspClusterRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteCcspClusterResponse>(response);
        }

        public SyncInvoker<DeleteCcspClusterResponse> DeleteCcspClusterInvoker(DeleteCcspClusterRequest deleteCcspClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteCcspClusterRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCcspClusterRequest);
            return new SyncInvoker<DeleteCcspClusterResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteCcspClusterResponse>);
        }
        
        /// <summary>
        /// 停用密码服务实例的业务功能
        ///
        /// 停用密码服务实例的业务功能
        /// &gt; 只有当密码服务实例处于“启用”状态时，方可调用此接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisableCcspInstanceResponse DisableCcspInstance(DisableCcspInstanceRequest disableCcspInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disableCcspInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/instances/{instance_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableCcspInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DisableCcspInstanceResponse>(response);
        }

        public SyncInvoker<DisableCcspInstanceResponse> DisableCcspInstanceInvoker(DisableCcspInstanceRequest disableCcspInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disableCcspInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/instances/{instance_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableCcspInstanceRequest);
            return new SyncInvoker<DisableCcspInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<DisableCcspInstanceResponse>);
        }
        
        /// <summary>
        /// 解除密码服务集群与应用绑定关系
        ///
        /// 解除密码服务集群与应用绑定关系
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisassociateAppsResponse DisassociateApps(DisassociateAppsRequest disassociateAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/disassociate-apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateAppsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DisassociateAppsResponse>(response);
        }

        public SyncInvoker<DisassociateAppsResponse> DisassociateAppsInvoker(DisassociateAppsRequest disassociateAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/disassociate-apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disassociateAppsRequest);
            return new SyncInvoker<DisassociateAppsResponse>(this, "POST", request, JsonUtils.DeSerialize<DisassociateAppsResponse>);
        }
        
        /// <summary>
        /// 启用密码服务实例的业务功能
        ///
        /// 启用密码服务实例的业务功能
        /// &gt; 只有当密码服务实例处于“停用”状态时，方可调用此接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EnableCcspInstanceResponse EnableCcspInstance(EnableCcspInstanceRequest enableCcspInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableCcspInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/instances/{instance_id}/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableCcspInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<EnableCcspInstanceResponse>(response);
        }

        public SyncInvoker<EnableCcspInstanceResponse> EnableCcspInstanceInvoker(EnableCcspInstanceRequest enableCcspInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableCcspInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/instances/{instance_id}/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableCcspInstanceRequest);
            return new SyncInvoker<EnableCcspInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<EnableCcspInstanceResponse>);
        }
        
        /// <summary>
        /// 查询密码服务的镜像
        ///
        /// 查询密码服务的镜像
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCcspTenantImagesResponse ListCcspTenantImages(ListCcspTenantImagesRequest listCcspTenantImagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/images", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCcspTenantImagesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCcspTenantImagesResponse>(response);
        }

        public SyncInvoker<ListCcspTenantImagesResponse> ListCcspTenantImagesInvoker(ListCcspTenantImagesRequest listCcspTenantImagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/images", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCcspTenantImagesRequest);
            return new SyncInvoker<ListCcspTenantImagesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCcspTenantImagesResponse>);
        }
        
        /// <summary>
        /// 下载访问密钥
        ///
        /// 下载访问密钥且只能下载一次。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAccessKeyResponse ShowAccessKey(ShowAccessKeyRequest showAccessKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAccessKeyRequest.AccessKeyId, out var valueOfAccessKeyId)) urlParam.Add("access_key_id", valueOfAccessKeyId);
            if (StringUtils.TryConvertToNonEmptyString(showAccessKeyRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/apps/{app_id}/access-keys/{access_key_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAccessKeyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAccessKeyResponse>(response);
        }

        public SyncInvoker<ShowAccessKeyResponse> ShowAccessKeyInvoker(ShowAccessKeyRequest showAccessKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAccessKeyRequest.AccessKeyId, out var valueOfAccessKeyId)) urlParam.Add("access_key_id", valueOfAccessKeyId);
            if (StringUtils.TryConvertToNonEmptyString(showAccessKeyRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/apps/{app_id}/access-keys/{access_key_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAccessKeyRequest);
            return new SyncInvoker<ShowAccessKeyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAccessKeyResponse>);
        }
        
        /// <summary>
        /// 查询应用的访问密钥列表
        ///
        /// 查询应用的访问密钥列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAppAccessKeyListResponse ShowAppAccessKeyList(ShowAppAccessKeyListRequest showAppAccessKeyListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAppAccessKeyListRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/apps/{app_id}/access-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppAccessKeyListRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAppAccessKeyListResponse>(response);
        }

        public SyncInvoker<ShowAppAccessKeyListResponse> ShowAppAccessKeyListInvoker(ShowAppAccessKeyListRequest showAppAccessKeyListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAppAccessKeyListRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/apps/{app_id}/access-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppAccessKeyListRequest);
            return new SyncInvoker<ShowAppAccessKeyListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAppAccessKeyListResponse>);
        }
        
        /// <summary>
        /// 查询应用列表
        ///
        /// 查询应用列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAppListResponse ShowAppList(ShowAppListRequest showAppListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppListRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAppListResponse>(response);
        }

        public SyncInvoker<ShowAppListResponse> ShowAppListInvoker(ShowAppListRequest showAppListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppListRequest);
            return new SyncInvoker<ShowAppListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAppListResponse>);
        }
        
        /// <summary>
        /// 查询密码服务集群与应用的绑定关系列表
        ///
        /// 查询密码服务集群与应用的绑定关系列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAssociationListResponse ShowAssociationList(ShowAssociationListRequest showAssociationListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/associations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssociationListRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAssociationListResponse>(response);
        }

        public SyncInvoker<ShowAssociationListResponse> ShowAssociationListInvoker(ShowAssociationListRequest showAssociationListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/associations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssociationListRequest);
            return new SyncInvoker<ShowAssociationListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAssociationListResponse>);
        }
        
        /// <summary>
        /// 查询可创建密码服务集群的可用区列表
        ///
        /// 查询可创建密码服务集群的可用区列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAvailableAzResponse ShowAvailableAz(ShowAvailableAzRequest showAvailableAzRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/az", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAvailableAzRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAvailableAzResponse>(response);
        }

        public SyncInvoker<ShowAvailableAzResponse> ShowAvailableAzInvoker(ShowAvailableAzRequest showAvailableAzRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/az", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAvailableAzRequest);
            return new SyncInvoker<ShowAvailableAzResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAvailableAzResponse>);
        }
        
        /// <summary>
        /// 查询密码服务集群详情
        ///
        /// 查询密码服务集群信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowCcspClusterResponse ShowCcspCluster(ShowCcspClusterRequest showCcspClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCcspClusterRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCcspClusterRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowCcspClusterResponse>(response);
        }

        public SyncInvoker<ShowCcspClusterResponse> ShowCcspClusterInvoker(ShowCcspClusterRequest showCcspClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCcspClusterRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCcspClusterRequest);
            return new SyncInvoker<ShowCcspClusterResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCcspClusterResponse>);
        }
        
        /// <summary>
        /// 查询密码服务集群列表
        ///
        /// 查询密码服务集群列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowCcspClusterListResponse ShowCcspClusterList(ShowCcspClusterListRequest showCcspClusterListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCcspClusterListRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowCcspClusterListResponse>(response);
        }

        public SyncInvoker<ShowCcspClusterListResponse> ShowCcspClusterListInvoker(ShowCcspClusterListRequest showCcspClusterListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCcspClusterListRequest);
            return new SyncInvoker<ShowCcspClusterListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCcspClusterListResponse>);
        }
        
        /// <summary>
        /// 查询密码服务实例列表
        ///
        /// 查询密码服务实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowCcspInstanceInfoResponse ShowCcspInstanceInfo(ShowCcspInstanceInfoRequest showCcspInstanceInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCcspInstanceInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowCcspInstanceInfoResponse>(response);
        }

        public SyncInvoker<ShowCcspInstanceInfoResponse> ShowCcspInstanceInfoInvoker(ShowCcspInstanceInfoRequest showCcspInstanceInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCcspInstanceInfoRequest);
            return new SyncInvoker<ShowCcspInstanceInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCcspInstanceInfoResponse>);
        }
        
        /// <summary>
        /// 查询密码服务集群已授权的访问密钥列表
        ///
        /// 查询密码服务集群已授权的访问密钥列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowClusterAccessKeyListResponse ShowClusterAccessKeyList(ShowClusterAccessKeyListRequest showClusterAccessKeyListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showClusterAccessKeyListRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}/access-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterAccessKeyListRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowClusterAccessKeyListResponse>(response);
        }

        public SyncInvoker<ShowClusterAccessKeyListResponse> ShowClusterAccessKeyListInvoker(ShowClusterAccessKeyListRequest showClusterAccessKeyListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showClusterAccessKeyListRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}/access-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterAccessKeyListRequest);
            return new SyncInvoker<ShowClusterAccessKeyListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowClusterAccessKeyListResponse>);
        }
        
        /// <summary>
        /// 获取密码服务管理界面URL
        ///
        /// 获取密码服务管理界面URL
        /// &gt; URL存在有效期，URL失效后无法跳转管理界面，需要重新获取URL
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowClusterUriResponse ShowClusterUri(ShowClusterUriRequest showClusterUriRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showClusterUriRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}/uri", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterUriRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowClusterUriResponse>(response);
        }

        public SyncInvoker<ShowClusterUriResponse> ShowClusterUriInvoker(ShowClusterUriRequest showClusterUriRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showClusterUriRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}/uri", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterUriRequest);
            return new SyncInvoker<ShowClusterUriResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowClusterUriResponse>);
        }
        
        /// <summary>
        /// 查询租户的资源分布信息
        ///
        /// 查询租户的资源分布信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowResourceInfoResponse ShowResourceInfo(ShowResourceInfoRequest showResourceInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/resource-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowResourceInfoResponse>(response);
        }

        public SyncInvoker<ShowResourceInfoResponse> ShowResourceInfoInvoker(ShowResourceInfoRequest showResourceInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/resource-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceInfoRequest);
            return new SyncInvoker<ShowResourceInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceInfoResponse>);
        }
        
        /// <summary>
        /// 密码资源指标监控
        ///
        /// 获取密码服务实例与虚拟密码机实例的指标（cpu使用率，内存使用率等指标）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowVmMonitorResponse ShowVmMonitor(ShowVmMonitorRequest showVmMonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/vm-monitor", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVmMonitorRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowVmMonitorResponse>(response);
        }

        public SyncInvoker<ShowVmMonitorResponse> ShowVmMonitorInvoker(ShowVmMonitorRequest showVmMonitorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/vm-monitor", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVmMonitorRequest);
            return new SyncInvoker<ShowVmMonitorResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVmMonitorResponse>);
        }
        
    }
}