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
        /// 创建集群模式端口
        ///
        /// 创建集群模式端口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddClusterPortResponse> AddClusterPortAsync(AddClusterPortRequest addClusterPortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addClusterPortRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}/port", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addClusterPortRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddClusterPortResponse>(response);
        }

        public AsyncInvoker<AddClusterPortResponse> AddClusterPortAsyncInvoker(AddClusterPortRequest addClusterPortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addClusterPortRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}/port", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addClusterPortRequest);
            return new AsyncInvoker<AddClusterPortResponse>(this, "POST", request, JsonUtils.DeSerialize<AddClusterPortResponse>);
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
        /// 检测集群模式端口是否正常
        ///
        /// 检测该端口关联的监听器、后端服务器组是否正确无误。
        /// &gt; 该接口调用后会根据实际情况，更新检查结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckClusterPortResponse> CheckClusterPortAsync(CheckClusterPortRequest checkClusterPortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkClusterPortRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(checkClusterPortRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}/port/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkClusterPortRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<CheckClusterPortResponse>(response);
        }

        public AsyncInvoker<CheckClusterPortResponse> CheckClusterPortAsyncInvoker(CheckClusterPortRequest checkClusterPortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkClusterPortRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(checkClusterPortRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}/port/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkClusterPortRequest);
            return new AsyncInvoker<CheckClusterPortResponse>(this, "PUT", request, JsonUtils.DeSerialize<CheckClusterPortResponse>);
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
        /// 删除集群模式端口
        ///
        /// 删除集群模式端口。
        /// &gt; 由于端口可能被租户二次修改过，并用于其他业务,所以删除会有几个不同选项，具体查看参数说明。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteClusterPortResponse> DeleteClusterPortAsync(DeleteClusterPortRequest deleteClusterPortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteClusterPortRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(deleteClusterPortRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}/port/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteClusterPortRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteClusterPortResponse>(response);
        }

        public AsyncInvoker<DeleteClusterPortResponse> DeleteClusterPortAsyncInvoker(DeleteClusterPortRequest deleteClusterPortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteClusterPortRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            if (StringUtils.TryConvertToNonEmptyString(deleteClusterPortRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}/port/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteClusterPortRequest);
            return new AsyncInvoker<DeleteClusterPortResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteClusterPortResponse>);
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
        /// 查询集群模式端口列表
        ///
        /// 列出当前集群下的所有集群模式端口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListClusterPortResponse> ListClusterPortAsync(ListClusterPortRequest listClusterPortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listClusterPortRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}/port", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClusterPortRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListClusterPortResponse>(response);
        }

        public AsyncInvoker<ListClusterPortResponse> ListClusterPortAsyncInvoker(ListClusterPortRequest listClusterPortRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listClusterPortRequest.ClusterId, out var valueOfClusterId)) urlParam.Add("cluster_id", valueOfClusterId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/{cluster_id}/port", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClusterPortRequest);
            return new AsyncInvoker<ListClusterPortResponse>(this, "GET", request, JsonUtils.DeSerialize<ListClusterPortResponse>);
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
        /// 查询平台审计日志
        ///
        /// 查询平台审计日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAuditLogResponse> ShowAuditLogAsync(ShowAuditLogRequest showAuditLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/platform/audit-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditLogRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAuditLogResponse>(response);
        }

        public AsyncInvoker<ShowAuditLogResponse> ShowAuditLogAsyncInvoker(ShowAuditLogRequest showAuditLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/platform/audit-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditLogRequest);
            return new AsyncInvoker<ShowAuditLogResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuditLogResponse>);
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
        /// 获取AK详情
        ///
        /// 获取所监控或者统计的AK详情列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowResourceDetailAccessKeyResponse> ShowResourceDetailAccessKeyAsync(ShowResourceDetailAccessKeyRequest showResourceDetailAccessKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/resource/access-key", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceDetailAccessKeyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowResourceDetailAccessKeyResponse>(response);
        }

        public AsyncInvoker<ShowResourceDetailAccessKeyResponse> ShowResourceDetailAccessKeyAsyncInvoker(ShowResourceDetailAccessKeyRequest showResourceDetailAccessKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/resource/access-key", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceDetailAccessKeyRequest);
            return new AsyncInvoker<ShowResourceDetailAccessKeyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceDetailAccessKeyResponse>);
        }
        
        /// <summary>
        /// 获取证书详情
        ///
        /// 获取所监控或者统计的证书详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowResourceDetailCertificateResponse> ShowResourceDetailCertificateAsync(ShowResourceDetailCertificateRequest showResourceDetailCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/resource/certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceDetailCertificateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowResourceDetailCertificateResponse>(response);
        }

        public AsyncInvoker<ShowResourceDetailCertificateResponse> ShowResourceDetailCertificateAsyncInvoker(ShowResourceDetailCertificateRequest showResourceDetailCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/resource/certificates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceDetailCertificateRequest);
            return new AsyncInvoker<ShowResourceDetailCertificateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceDetailCertificateResponse>);
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
        /// 获取证书分布统计信息
        ///
        /// 获取CPCS中证书分布统计信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowStatisticCertificateResponse> ShowStatisticCertificateAsync(ShowStatisticCertificateRequest showStatisticCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/certificate/statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatisticCertificateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowStatisticCertificateResponse>(response);
        }

        public AsyncInvoker<ShowStatisticCertificateResponse> ShowStatisticCertificateAsyncInvoker(ShowStatisticCertificateRequest showStatisticCertificateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/certificate/statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatisticCertificateRequest);
            return new AsyncInvoker<ShowStatisticCertificateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStatisticCertificateResponse>);
        }
        
        /// <summary>
        /// 获取接口调用统计信息
        ///
        /// 获取CPCS中接口调用统计信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowStatisticInterfaceResponse> ShowStatisticInterfaceAsync(ShowStatisticInterfaceRequest showStatisticInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/interface/statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatisticInterfaceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowStatisticInterfaceResponse>(response);
        }

        public AsyncInvoker<ShowStatisticInterfaceResponse> ShowStatisticInterfaceAsyncInvoker(ShowStatisticInterfaceRequest showStatisticInterfaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/interface/statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatisticInterfaceRequest);
            return new AsyncInvoker<ShowStatisticInterfaceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStatisticInterfaceResponse>);
        }
        
        /// <summary>
        /// 获取资源总量统计信息
        ///
        /// 获取CPCS中\\资源总量统计信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowStatisticResourceResponse> ShowStatisticResourceAsync(ShowStatisticResourceRequest showStatisticResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/resource/statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatisticResourceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowStatisticResourceResponse>(response);
        }

        public AsyncInvoker<ShowStatisticResourceResponse> ShowStatisticResourceAsyncInvoker(ShowStatisticResourceRequest showStatisticResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/resource/statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatisticResourceRequest);
            return new AsyncInvoker<ShowStatisticResourceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStatisticResourceResponse>);
        }
        
        /// <summary>
        /// 获取密钥分布统计信息
        ///
        /// 获取CPCS中密钥分布统计信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowStatisticSecretKeyResponse> ShowStatisticSecretKeyAsync(ShowStatisticSecretKeyRequest showStatisticSecretKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/secret-key/statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatisticSecretKeyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowStatisticSecretKeyResponse>(response);
        }

        public AsyncInvoker<ShowStatisticSecretKeyResponse> ShowStatisticSecretKeyAsyncInvoker(ShowStatisticSecretKeyRequest showStatisticSecretKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/secret-key/statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatisticSecretKeyRequest);
            return new AsyncInvoker<ShowStatisticSecretKeyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStatisticSecretKeyResponse>);
        }
        
        /// <summary>
        /// 获取应用状态监控
        ///
        /// CPCS服务创建的应用状态监控
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowStatusAppResponse> ShowStatusAppAsync(ShowStatusAppRequest showStatusAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/app/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatusAppRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowStatusAppResponse>(response);
        }

        public AsyncInvoker<ShowStatusAppResponse> ShowStatusAppAsyncInvoker(ShowStatusAppRequest showStatusAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/app/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatusAppRequest);
            return new AsyncInvoker<ShowStatusAppResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStatusAppResponse>);
        }
        
        /// <summary>
        /// 获取集群监控信息
        ///
        /// CPCS服务创建的集群的状态监控
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowStatusClusterResponse> ShowStatusClusterAsync(ShowStatusClusterRequest showStatusClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatusClusterRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowStatusClusterResponse>(response);
        }

        public AsyncInvoker<ShowStatusClusterResponse> ShowStatusClusterAsyncInvoker(ShowStatusClusterRequest showStatusClusterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/cluster/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatusClusterRequest);
            return new AsyncInvoker<ShowStatusClusterResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStatusClusterResponse>);
        }
        
        /// <summary>
        /// 获取实例监控信息
        ///
        /// CPCS服务创建的密码服务实例的状态监控
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowStatusInstanceResponse> ShowStatusInstanceAsync(ShowStatusInstanceRequest showStatusInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/instance/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatusInstanceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowStatusInstanceResponse>(response);
        }

        public AsyncInvoker<ShowStatusInstanceResponse> ShowStatusInstanceAsyncInvoker(ShowStatusInstanceRequest showStatusInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/instance/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatusInstanceRequest);
            return new AsyncInvoker<ShowStatusInstanceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStatusInstanceResponse>);
        }
        
        /// <summary>
        /// 获取服务监控信息
        ///
        /// CPCS服务的状态监控
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowStatusServiceResponse> ShowStatusServiceAsync(ShowStatusServiceRequest showStatusServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/service/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatusServiceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowStatusServiceResponse>(response);
        }

        public AsyncInvoker<ShowStatusServiceResponse> ShowStatusServiceAsyncInvoker(ShowStatusServiceRequest showStatusServiceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/service/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatusServiceRequest);
            return new AsyncInvoker<ShowStatusServiceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStatusServiceResponse>);
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
        
        /// <summary>
        /// AK/SK 换取Cpcs token
        ///
        /// 使用aksk换取cpcs token
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchCpcsTokenResponse> SwitchCpcsTokenAsync(SwitchCpcsTokenRequest switchCpcsTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/token/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchCpcsTokenRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SwitchCpcsTokenResponse>(response);
        }

        public AsyncInvoker<SwitchCpcsTokenResponse> SwitchCpcsTokenAsyncInvoker(SwitchCpcsTokenRequest switchCpcsTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/dew/cpcs/token/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", switchCpcsTokenRequest);
            return new AsyncInvoker<SwitchCpcsTokenResponse>(this, "POST", request, JsonUtils.DeSerialize<SwitchCpcsTokenResponse>);
        }
        
    }
}