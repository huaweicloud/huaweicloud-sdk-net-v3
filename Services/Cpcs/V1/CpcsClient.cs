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
        /// 创建集群模式端口
        ///
        /// 创建集群模式端口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddClusterPortResponse AddClusterPort(AddClusterPortRequest addClusterPortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addClusterPortRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}/port", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addClusterPortRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddClusterPortResponse>(response);
        }

        public SyncInvoker<AddClusterPortResponse> AddClusterPortInvoker(AddClusterPortRequest addClusterPortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addClusterPortRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}/port", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addClusterPortRequest);
            return new SyncInvoker<AddClusterPortResponse>(this, "POST", request, JsonUtils.DeSerialize<AddClusterPortResponse>);
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
        /// 检测集群模式端口是否正常
        ///
        /// 检测该端口关联的监听器、后端服务器组是否正确无误。
        /// &gt; 该接口调用后会根据实际情况，更新检查结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CheckClusterPortResponse CheckClusterPort(CheckClusterPortRequest checkClusterPortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkClusterPortRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(checkClusterPortRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}/port/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkClusterPortRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<CheckClusterPortResponse>(response);
        }

        public SyncInvoker<CheckClusterPortResponse> CheckClusterPortInvoker(CheckClusterPortRequest checkClusterPortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkClusterPortRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(checkClusterPortRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}/port/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkClusterPortRequest);
            return new SyncInvoker<CheckClusterPortResponse>(this, "PUT", request, JsonUtils.DeSerialize<CheckClusterPortResponse>);
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
        /// 删除集群模式端口
        ///
        /// 删除集群模式端口。
        /// &gt; 由于端口可能被租户二次修改过，并用于其他业务,所以删除会有几个不同选项，具体查看参数说明。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteClusterPortResponse DeleteClusterPort(DeleteClusterPortRequest deleteClusterPortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteClusterPortRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(deleteClusterPortRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}/port/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteClusterPortRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteClusterPortResponse>(response);
        }

        public SyncInvoker<DeleteClusterPortResponse> DeleteClusterPortInvoker(DeleteClusterPortRequest deleteClusterPortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteClusterPortRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(deleteClusterPortRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}/port/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteClusterPortRequest);
            return new SyncInvoker<DeleteClusterPortResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteClusterPortResponse>);
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
        /// 查询集群模式端口列表
        ///
        /// 列出当前集群下的所有集群模式端口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListClusterPortResponse ListClusterPort(ListClusterPortRequest listClusterPortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listClusterPortRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}/port", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClusterPortRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListClusterPortResponse>(response);
        }

        public SyncInvoker<ListClusterPortResponse> ListClusterPortInvoker(ListClusterPortRequest listClusterPortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listClusterPortRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}/port", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClusterPortRequest);
            return new SyncInvoker<ListClusterPortResponse>(this, "GET", request, JsonUtils.DeSerialize<ListClusterPortResponse>);
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
        /// 查询平台审计日志
        ///
        /// 查询平台审计日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAuditLogResponse ShowAuditLog(ShowAuditLogRequest showAuditLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/platform/audit-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditLogRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAuditLogResponse>(response);
        }

        public SyncInvoker<ShowAuditLogResponse> ShowAuditLogInvoker(ShowAuditLogRequest showAuditLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/platform/audit-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditLogRequest);
            return new SyncInvoker<ShowAuditLogResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuditLogResponse>);
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
        /// 获取AK详情
        ///
        /// 获取所监控或者统计的AK详情列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowResourceDetailAccessKeyResponse ShowResourceDetailAccessKey(ShowResourceDetailAccessKeyRequest showResourceDetailAccessKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/resource/access-key", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceDetailAccessKeyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowResourceDetailAccessKeyResponse>(response);
        }

        public SyncInvoker<ShowResourceDetailAccessKeyResponse> ShowResourceDetailAccessKeyInvoker(ShowResourceDetailAccessKeyRequest showResourceDetailAccessKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/resource/access-key", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceDetailAccessKeyRequest);
            return new SyncInvoker<ShowResourceDetailAccessKeyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceDetailAccessKeyResponse>);
        }
        
        /// <summary>
        /// 获取证书详情
        ///
        /// 获取所监控或者统计的证书详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowResourceDetailCertificateResponse ShowResourceDetailCertificate(ShowResourceDetailCertificateRequest showResourceDetailCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/resource/certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceDetailCertificateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowResourceDetailCertificateResponse>(response);
        }

        public SyncInvoker<ShowResourceDetailCertificateResponse> ShowResourceDetailCertificateInvoker(ShowResourceDetailCertificateRequest showResourceDetailCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/resource/certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceDetailCertificateRequest);
            return new SyncInvoker<ShowResourceDetailCertificateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceDetailCertificateResponse>);
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
        /// 获取证书分布统计信息
        ///
        /// 获取CPCS中证书分布统计信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowStatisticCertificateResponse ShowStatisticCertificate(ShowStatisticCertificateRequest showStatisticCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/certificate/statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatisticCertificateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowStatisticCertificateResponse>(response);
        }

        public SyncInvoker<ShowStatisticCertificateResponse> ShowStatisticCertificateInvoker(ShowStatisticCertificateRequest showStatisticCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/certificate/statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatisticCertificateRequest);
            return new SyncInvoker<ShowStatisticCertificateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStatisticCertificateResponse>);
        }
        
        /// <summary>
        /// 获取接口调用统计信息
        ///
        /// 获取CPCS中接口调用统计信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowStatisticInterfaceResponse ShowStatisticInterface(ShowStatisticInterfaceRequest showStatisticInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/interface/statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatisticInterfaceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowStatisticInterfaceResponse>(response);
        }

        public SyncInvoker<ShowStatisticInterfaceResponse> ShowStatisticInterfaceInvoker(ShowStatisticInterfaceRequest showStatisticInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/interface/statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatisticInterfaceRequest);
            return new SyncInvoker<ShowStatisticInterfaceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStatisticInterfaceResponse>);
        }
        
        /// <summary>
        /// 获取资源总量统计信息
        ///
        /// 获取CPCS中\\资源总量统计信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowStatisticResourceResponse ShowStatisticResource(ShowStatisticResourceRequest showStatisticResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/resource/statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatisticResourceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowStatisticResourceResponse>(response);
        }

        public SyncInvoker<ShowStatisticResourceResponse> ShowStatisticResourceInvoker(ShowStatisticResourceRequest showStatisticResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/resource/statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatisticResourceRequest);
            return new SyncInvoker<ShowStatisticResourceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStatisticResourceResponse>);
        }
        
        /// <summary>
        /// 获取密钥分布统计信息
        ///
        /// 获取CPCS中密钥分布统计信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowStatisticSecretKeyResponse ShowStatisticSecretKey(ShowStatisticSecretKeyRequest showStatisticSecretKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/secret-key/statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatisticSecretKeyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowStatisticSecretKeyResponse>(response);
        }

        public SyncInvoker<ShowStatisticSecretKeyResponse> ShowStatisticSecretKeyInvoker(ShowStatisticSecretKeyRequest showStatisticSecretKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/secret-key/statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatisticSecretKeyRequest);
            return new SyncInvoker<ShowStatisticSecretKeyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStatisticSecretKeyResponse>);
        }
        
        /// <summary>
        /// 获取应用状态监控
        ///
        /// CPCS服务创建的应用状态监控
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowStatusAppResponse ShowStatusApp(ShowStatusAppRequest showStatusAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/app/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatusAppRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowStatusAppResponse>(response);
        }

        public SyncInvoker<ShowStatusAppResponse> ShowStatusAppInvoker(ShowStatusAppRequest showStatusAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/app/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatusAppRequest);
            return new SyncInvoker<ShowStatusAppResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStatusAppResponse>);
        }
        
        /// <summary>
        /// 获取集群监控信息
        ///
        /// CPCS服务创建的集群的状态监控
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowStatusClusterResponse ShowStatusCluster(ShowStatusClusterRequest showStatusClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatusClusterRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowStatusClusterResponse>(response);
        }

        public SyncInvoker<ShowStatusClusterResponse> ShowStatusClusterInvoker(ShowStatusClusterRequest showStatusClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatusClusterRequest);
            return new SyncInvoker<ShowStatusClusterResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStatusClusterResponse>);
        }
        
        /// <summary>
        /// 获取实例监控信息
        ///
        /// CPCS服务创建的密码服务实例的状态监控
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowStatusInstanceResponse ShowStatusInstance(ShowStatusInstanceRequest showStatusInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/instance/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatusInstanceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowStatusInstanceResponse>(response);
        }

        public SyncInvoker<ShowStatusInstanceResponse> ShowStatusInstanceInvoker(ShowStatusInstanceRequest showStatusInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/instance/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatusInstanceRequest);
            return new SyncInvoker<ShowStatusInstanceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStatusInstanceResponse>);
        }
        
        /// <summary>
        /// 获取服务监控信息
        ///
        /// CPCS服务的状态监控
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowStatusServiceResponse ShowStatusService(ShowStatusServiceRequest showStatusServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/service/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatusServiceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowStatusServiceResponse>(response);
        }

        public SyncInvoker<ShowStatusServiceResponse> ShowStatusServiceInvoker(ShowStatusServiceRequest showStatusServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/service/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatusServiceRequest);
            return new SyncInvoker<ShowStatusServiceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStatusServiceResponse>);
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
        
        /// <summary>
        /// AK/SK 换取Cpcs token
        ///
        /// 使用aksk换取cpcs token
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchCpcsTokenResponse SwitchCpcsToken(SwitchCpcsTokenRequest switchCpcsTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/token/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchCpcsTokenRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SwitchCpcsTokenResponse>(response);
        }

        public SyncInvoker<SwitchCpcsTokenResponse> SwitchCpcsTokenInvoker(SwitchCpcsTokenRequest switchCpcsTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/token/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchCpcsTokenRequest);
            return new SyncInvoker<SwitchCpcsTokenResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchCpcsTokenResponse>);
        }
        
    }
}