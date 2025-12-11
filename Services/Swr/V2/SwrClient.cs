using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Swr.V2.Model;

namespace HuaweiCloud.SDK.Swr.V2
{
    public partial class SwrClient : Client
    {
        public static ClientBuilder<SwrClient> NewBuilder()
        {
            return new ClientBuilder<SwrClient>();
        }

        
        /// <summary>
        /// 查询委托是否存在
        ///
        /// 检查租户是否已委托SWR服务通过触发器功能调用CCE、CCI服务，一般由前端控制台自动调用，用户无需手动调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CheckAgencyResponse CheckAgency(CheckAgencyRequest checkAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/agency", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkAgencyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CheckAgencyResponse>(response);
        }

        public SyncInvoker<CheckAgencyResponse> CheckAgencyInvoker(CheckAgencyRequest checkAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/agency", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkAgencyRequest);
            return new SyncInvoker<CheckAgencyResponse>(this, "GET", request, JsonUtils.DeSerialize<CheckAgencyResponse>);
        }
        
        /// <summary>
        /// 创建委托
        ///
        /// 租户首次使用SWR服务时创建SWR服务内部委托，一般由前端控制台自动调用，用户无需手动调用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAgencyResponse CreateAgency(CreateAgencyRequest createAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/agency", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAgencyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateAgencyResponse>(response);
        }

        public SyncInvoker<CreateAgencyResponse> CreateAgencyInvoker(CreateAgencyRequest createAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/agency", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAgencyRequest);
            return new SyncInvoker<CreateAgencyResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateAgencyResponse>);
        }
        
        /// <summary>
        /// 生成增强型登录指令(新)
        ///
        /// 调用该接口，通过获取响应消息头的X-Swr-Dockerlogin的值及响应消息体的host值，可生成增强型登录指令,注：此接口只支持IAM新平面的调用方式。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAuthorizationTokenResponse CreateAuthorizationToken(CreateAuthorizationTokenRequest createAuthorizationTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/utils/authorizationtoken", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAuthorizationTokenRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAuthorizationTokenResponse>(response);
        }

        public SyncInvoker<CreateAuthorizationTokenResponse> CreateAuthorizationTokenInvoker(CreateAuthorizationTokenRequest createAuthorizationTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/utils/authorizationtoken", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAuthorizationTokenRequest);
            return new SyncInvoker<CreateAuthorizationTokenResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAuthorizationTokenResponse>);
        }
        
        /// <summary>
        /// 创建镜像自动同步任务
        ///
        /// 创建镜像自动同步任务，帮助您把最新推送的镜像自动同步到其他区域镜像仓库内。 镜像自动同步帮助您把最新推送的镜像自动同步到其他区域镜像仓库内，后期镜像有更新时，目标仓库的镜像也会自动更新，但已有的镜像不会自动同步。已有镜像的同步需要手动操作，详情请参见手动同步镜像。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateImageSyncRepoResponse CreateImageSyncRepo(CreateImageSyncRepoRequest createImageSyncRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createImageSyncRepoRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(createImageSyncRepoRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/sync_repo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createImageSyncRepoRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateImageSyncRepoResponse>(response);
        }

        public SyncInvoker<CreateImageSyncRepoResponse> CreateImageSyncRepoInvoker(CreateImageSyncRepoRequest createImageSyncRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createImageSyncRepoRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(createImageSyncRepoRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/sync_repo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createImageSyncRepoRequest);
            return new SyncInvoker<CreateImageSyncRepoResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateImageSyncRepoResponse>);
        }
        
        /// <summary>
        /// 手动同步镜像
        ///
        /// 对于镜像仓库已有的镜像，如果想在其他区域使用，需要手动触发镜像同步。 判断是否同步成功的方法如下：响应状态码为200，无报错信息，表示同步成功。通过SWR管理控制台或调用查询镜像仓库概要信息接口，在目标区域的目标组织下，若存在所同步的镜像版本表示同步成功。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateManualImageSyncRepoResponse CreateManualImageSyncRepo(CreateManualImageSyncRepoRequest createManualImageSyncRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createManualImageSyncRepoRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(createManualImageSyncRepoRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/sync_images", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createManualImageSyncRepoRequest);
            var response = DoHttpRequestSync("POST", request);
            var createManualImageSyncRepoResponse = JsonUtils.DeSerializeNull<CreateManualImageSyncRepoResponse>(response);
            createManualImageSyncRepoResponse.Body = JsonUtils.DeSerializeList<string>(response);
            return createManualImageSyncRepoResponse;
        }

        public SyncInvoker<CreateManualImageSyncRepoResponse> CreateManualImageSyncRepoInvoker(CreateManualImageSyncRepoRequest createManualImageSyncRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createManualImageSyncRepoRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(createManualImageSyncRepoRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/sync_images", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createManualImageSyncRepoRequest);
            return new SyncInvoker<CreateManualImageSyncRepoResponse>(this, "POST", request, response =>
            {
                var createManualImageSyncRepoResponse = JsonUtils.DeSerializeNull<CreateManualImageSyncRepoResponse>(response);
                createManualImageSyncRepoResponse.Body = JsonUtils.DeSerializeList<string>(response);
                return createManualImageSyncRepoResponse;
            });
        }
        
        /// <summary>
        /// 创建组织
        ///
        /// 创建组织
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateNamespaceResponse CreateNamespace(CreateNamespaceRequest createNamespaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNamespaceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateNamespaceResponse>(response);
        }

        public SyncInvoker<CreateNamespaceResponse> CreateNamespaceInvoker(CreateNamespaceRequest createNamespaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNamespaceRequest);
            return new SyncInvoker<CreateNamespaceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateNamespaceResponse>);
        }
        
        /// <summary>
        /// 创建组织权限
        ///
        /// 创建组织权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateNamespaceAuthResponse CreateNamespaceAuth(CreateNamespaceAuthRequest createNamespaceAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createNamespaceAuthRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNamespaceAuthRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateNamespaceAuthResponse>(response);
        }

        public SyncInvoker<CreateNamespaceAuthResponse> CreateNamespaceAuthInvoker(CreateNamespaceAuthRequest createNamespaceAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createNamespaceAuthRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNamespaceAuthRequest);
            return new SyncInvoker<CreateNamespaceAuthResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateNamespaceAuthResponse>);
        }
        
        /// <summary>
        /// 在组织下创建镜像仓库
        ///
        /// 在组织下创建镜像仓库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRepoResponse CreateRepo(CreateRepoRequest createRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRepoRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepoRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateRepoResponse>(response);
        }

        public SyncInvoker<CreateRepoResponse> CreateRepoInvoker(CreateRepoRequest createRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRepoRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepoRequest);
            return new SyncInvoker<CreateRepoResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateRepoResponse>);
        }
        
        /// <summary>
        /// 创建共享帐号
        ///
        /// 创建共享帐号。镜像上传后，您可以共享私有镜像给其他帐号，并授予下载该镜像的权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRepoDomainsResponse CreateRepoDomains(CreateRepoDomainsRequest createRepoDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRepoDomainsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(createRepoDomainsRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepoDomainsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateRepoDomainsResponse>(response);
        }

        public SyncInvoker<CreateRepoDomainsResponse> CreateRepoDomainsInvoker(CreateRepoDomainsRequest createRepoDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRepoDomainsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(createRepoDomainsRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepoDomainsRequest);
            return new SyncInvoker<CreateRepoDomainsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateRepoDomainsResponse>);
        }
        
        /// <summary>
        /// 创建镜像tag
        ///
        /// 创建镜像tag
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRepoTagResponse CreateRepoTag(CreateRepoTagRequest createRepoTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRepoTagRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(createRepoTagRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepoTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateRepoTagResponse>(response);
        }

        public SyncInvoker<CreateRepoTagResponse> CreateRepoTagInvoker(CreateRepoTagRequest createRepoTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRepoTagRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(createRepoTagRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepoTagRequest);
            return new SyncInvoker<CreateRepoTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateRepoTagResponse>);
        }
        
        /// <summary>
        /// 创建镜像老化规则
        ///
        /// 创建镜像老化规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRetentionResponse CreateRetention(CreateRetentionRequest createRetentionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRetentionRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(createRetentionRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRetentionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateRetentionResponse>(response);
        }

        public SyncInvoker<CreateRetentionResponse> CreateRetentionInvoker(CreateRetentionRequest createRetentionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRetentionRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(createRetentionRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRetentionRequest);
            return new SyncInvoker<CreateRetentionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRetentionResponse>);
        }
        
        /// <summary>
        /// 生成临时登录指令
        ///
        /// 调用该接口，通过获取响应消息头的X-Swr-Dockerlogin的值及响应消息体的host值，可生成临时登录指令。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateSecretResponse CreateSecret(CreateSecretRequest createSecretRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/utils/secret", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSecretRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateSecretResponse>(response);
        }

        public SyncInvoker<CreateSecretResponse> CreateSecretInvoker(CreateSecretRequest createSecretRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/utils/secret", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSecretRequest);
            return new SyncInvoker<CreateSecretResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSecretResponse>);
        }
        
        /// <summary>
        /// 创建触发器
        ///
        /// 创建触发器
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTriggerResponse CreateTrigger(CreateTriggerRequest createTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTriggerRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(createTriggerRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTriggerRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateTriggerResponse>(response);
        }

        public SyncInvoker<CreateTriggerResponse> CreateTriggerInvoker(CreateTriggerRequest createTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTriggerRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(createTriggerRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTriggerRequest);
            return new SyncInvoker<CreateTriggerResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateTriggerResponse>);
        }
        
        /// <summary>
        /// 创建镜像权限
        ///
        /// 创建镜像权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateUserRepositoryAuthResponse CreateUserRepositoryAuth(CreateUserRepositoryAuthRequest createUserRepositoryAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createUserRepositoryAuthRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(createUserRepositoryAuthRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUserRepositoryAuthRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateUserRepositoryAuthResponse>(response);
        }

        public SyncInvoker<CreateUserRepositoryAuthResponse> CreateUserRepositoryAuthInvoker(CreateUserRepositoryAuthRequest createUserRepositoryAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createUserRepositoryAuthRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(createUserRepositoryAuthRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUserRepositoryAuthRequest);
            return new SyncInvoker<CreateUserRepositoryAuthResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateUserRepositoryAuthResponse>);
        }
        
        /// <summary>
        /// 删除镜像自动同步任务
        ///
        /// 根据目标区域、目标组织删除指定的镜像自动同步任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteImageSyncRepoResponse DeleteImageSyncRepo(DeleteImageSyncRepoRequest deleteImageSyncRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteImageSyncRepoRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(deleteImageSyncRepoRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/sync_repo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteImageSyncRepoRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteImageSyncRepoResponse>(response);
        }

        public SyncInvoker<DeleteImageSyncRepoResponse> DeleteImageSyncRepoInvoker(DeleteImageSyncRepoRequest deleteImageSyncRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteImageSyncRepoRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(deleteImageSyncRepoRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/sync_repo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteImageSyncRepoRequest);
            return new SyncInvoker<DeleteImageSyncRepoResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteImageSyncRepoResponse>);
        }
        
        /// <summary>
        /// 删除组织权限
        ///
        /// 删除组织权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteNamespaceAuthResponse DeleteNamespaceAuth(DeleteNamespaceAuthRequest deleteNamespaceAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteNamespaceAuthRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNamespaceAuthRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteNamespaceAuthResponse>(response);
        }

        public SyncInvoker<DeleteNamespaceAuthResponse> DeleteNamespaceAuthInvoker(DeleteNamespaceAuthRequest deleteNamespaceAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteNamespaceAuthRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNamespaceAuthRequest);
            return new SyncInvoker<DeleteNamespaceAuthResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteNamespaceAuthResponse>);
        }
        
        /// <summary>
        /// 删除组织
        ///
        /// 删除组织
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteNamespacesResponse DeleteNamespaces(DeleteNamespacesRequest deleteNamespacesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteNamespacesRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNamespacesRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteNamespacesResponse>(response);
        }

        public SyncInvoker<DeleteNamespacesResponse> DeleteNamespacesInvoker(DeleteNamespacesRequest deleteNamespacesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteNamespacesRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNamespacesRequest);
            return new SyncInvoker<DeleteNamespacesResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteNamespacesResponse>);
        }
        
        /// <summary>
        /// 删除组织下的镜像仓库
        ///
        /// 删除组织下的镜像仓库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteRepoResponse DeleteRepo(DeleteRepoRequest deleteRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepoRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRepoResponse>(response);
        }

        public SyncInvoker<DeleteRepoResponse> DeleteRepoInvoker(DeleteRepoRequest deleteRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepoRequest);
            return new SyncInvoker<DeleteRepoResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRepoResponse>);
        }
        
        /// <summary>
        /// 删除共享帐号
        ///
        /// 删除共享帐号
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteRepoDomainsResponse DeleteRepoDomains(DeleteRepoDomainsRequest deleteRepoDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoDomainsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoDomainsRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoDomainsRequest.AccessDomain, out var valueOfAccessDomain)) urlParam.Add("access_domain", valueOfAccessDomain);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains/{access_domain}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepoDomainsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRepoDomainsResponse>(response);
        }

        public SyncInvoker<DeleteRepoDomainsResponse> DeleteRepoDomainsInvoker(DeleteRepoDomainsRequest deleteRepoDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoDomainsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoDomainsRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoDomainsRequest.AccessDomain, out var valueOfAccessDomain)) urlParam.Add("access_domain", valueOfAccessDomain);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains/{access_domain}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepoDomainsRequest);
            return new SyncInvoker<DeleteRepoDomainsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRepoDomainsResponse>);
        }
        
        /// <summary>
        /// 删除指定tag的镜像
        ///
        /// 删除镜像仓库中指定tag的镜像
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteRepoTagResponse DeleteRepoTag(DeleteRepoTagRequest deleteRepoTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoTagRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoTagRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoTagRequest.Tag, out var valueOfTag)) urlParam.Add("tag", valueOfTag);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/tags/{tag}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepoTagRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRepoTagResponse>(response);
        }

        public SyncInvoker<DeleteRepoTagResponse> DeleteRepoTagInvoker(DeleteRepoTagRequest deleteRepoTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoTagRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoTagRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoTagRequest.Tag, out var valueOfTag)) urlParam.Add("tag", valueOfTag);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/tags/{tag}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepoTagRequest);
            return new SyncInvoker<DeleteRepoTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRepoTagResponse>);
        }
        
        /// <summary>
        /// 删除镜像老化规则
        ///
        /// 删除镜像老化规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteRetentionResponse DeleteRetention(DeleteRetentionRequest deleteRetentionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRetentionRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(deleteRetentionRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(deleteRetentionRequest.RetentionId, out var valueOfRetentionId)) urlParam.Add("retention_id", valueOfRetentionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions/{retention_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRetentionRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRetentionResponse>(response);
        }

        public SyncInvoker<DeleteRetentionResponse> DeleteRetentionInvoker(DeleteRetentionRequest deleteRetentionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRetentionRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(deleteRetentionRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(deleteRetentionRequest.RetentionId, out var valueOfRetentionId)) urlParam.Add("retention_id", valueOfRetentionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions/{retention_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRetentionRequest);
            return new SyncInvoker<DeleteRetentionResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRetentionResponse>);
        }
        
        /// <summary>
        /// 删除触发器
        ///
        /// 删除触发器
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTriggerResponse DeleteTrigger(DeleteTriggerRequest deleteTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTriggerRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(deleteTriggerRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(deleteTriggerRequest.Trigger, out var valueOfTrigger)) urlParam.Add("trigger", valueOfTrigger);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers/{trigger}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTriggerRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTriggerResponse>(response);
        }

        public SyncInvoker<DeleteTriggerResponse> DeleteTriggerInvoker(DeleteTriggerRequest deleteTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTriggerRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(deleteTriggerRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(deleteTriggerRequest.Trigger, out var valueOfTrigger)) urlParam.Add("trigger", valueOfTrigger);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers/{trigger}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTriggerRequest);
            return new SyncInvoker<DeleteTriggerResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTriggerResponse>);
        }
        
        /// <summary>
        /// 删除镜像权限
        ///
        /// 删除镜像权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteUserRepositoryAuthResponse DeleteUserRepositoryAuth(DeleteUserRepositoryAuthRequest deleteUserRepositoryAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteUserRepositoryAuthRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(deleteUserRepositoryAuthRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserRepositoryAuthRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteUserRepositoryAuthResponse>(response);
        }

        public SyncInvoker<DeleteUserRepositoryAuthResponse> DeleteUserRepositoryAuthInvoker(DeleteUserRepositoryAuthRequest deleteUserRepositoryAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteUserRepositoryAuthRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(deleteUserRepositoryAuthRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserRepositoryAuthRequest);
            return new SyncInvoker<DeleteUserRepositoryAuthResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteUserRepositoryAuthResponse>);
        }
        
        /// <summary>
        /// 获取镜像自动同步任务列表
        ///
        /// 获取为当前镜像仓库所创建的所有自动同步任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListImageAutoSyncReposDetailsResponse ListImageAutoSyncReposDetails(ListImageAutoSyncReposDetailsRequest listImageAutoSyncReposDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listImageAutoSyncReposDetailsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(listImageAutoSyncReposDetailsRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/sync_repo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImageAutoSyncReposDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listImageAutoSyncReposDetailsResponse = JsonUtils.DeSerializeNull<ListImageAutoSyncReposDetailsResponse>(response);
            listImageAutoSyncReposDetailsResponse.Body = JsonUtils.DeSerializeList<SyncRepo>(response);
            return listImageAutoSyncReposDetailsResponse;
        }

        public SyncInvoker<ListImageAutoSyncReposDetailsResponse> ListImageAutoSyncReposDetailsInvoker(ListImageAutoSyncReposDetailsRequest listImageAutoSyncReposDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listImageAutoSyncReposDetailsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(listImageAutoSyncReposDetailsRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/sync_repo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImageAutoSyncReposDetailsRequest);
            return new SyncInvoker<ListImageAutoSyncReposDetailsResponse>(this, "GET", request, response =>
            {
                var listImageAutoSyncReposDetailsResponse = JsonUtils.DeSerializeNull<ListImageAutoSyncReposDetailsResponse>(response);
                listImageAutoSyncReposDetailsResponse.Body = JsonUtils.DeSerializeList<SyncRepo>(response);
                return listImageAutoSyncReposDetailsResponse;
            });
        }
        
        /// <summary>
        /// 查询组织列表
        ///
        /// 查询组织列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListNamespacesResponse ListNamespaces(ListNamespacesRequest listNamespacesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNamespacesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListNamespacesResponse>(response);
        }

        public SyncInvoker<ListNamespacesResponse> ListNamespacesInvoker(ListNamespacesRequest listNamespacesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNamespacesRequest);
            return new SyncInvoker<ListNamespacesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNamespacesResponse>);
        }
        
        /// <summary>
        /// 获取配额信息
        ///
        /// 获取配额信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListQuotasResponse ListQuotas(ListQuotasRequest listQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/projects/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListQuotasResponse>(response);
        }

        public SyncInvoker<ListQuotasResponse> ListQuotasInvoker(ListQuotasRequest listQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/projects/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotasRequest);
            return new SyncInvoker<ListQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListQuotasResponse>);
        }
        
        /// <summary>
        /// 查询镜像仓库列表详情
        ///
        /// 查询镜像仓库列表详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRepoDetailsResponse ListRepoDetails(ListRepoDetailsRequest listRepoDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/manage/repos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepoDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRepoDetailsResponse>(response);
        }

        public SyncInvoker<ListRepoDetailsResponse> ListRepoDetailsInvoker(ListRepoDetailsRequest listRepoDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/manage/repos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepoDetailsRequest);
            return new SyncInvoker<ListRepoDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRepoDetailsResponse>);
        }
        
        /// <summary>
        /// 获取共享帐号列表
        ///
        /// 获取共享帐号列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRepoDomainsResponse ListRepoDomains(ListRepoDomainsRequest listRepoDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepoDomainsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(listRepoDomainsRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepoDomainsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listRepoDomainsResponse = JsonUtils.DeSerializeNull<ListRepoDomainsResponse>(response);
            listRepoDomainsResponse.Body = JsonUtils.DeSerializeList<ShowRepoDomainsResponse>(response);
            return listRepoDomainsResponse;
        }

        public SyncInvoker<ListRepoDomainsResponse> ListRepoDomainsInvoker(ListRepoDomainsRequest listRepoDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepoDomainsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(listRepoDomainsRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepoDomainsRequest);
            return new SyncInvoker<ListRepoDomainsResponse>(this, "GET", request, response =>
            {
                var listRepoDomainsResponse = JsonUtils.DeSerializeNull<ListRepoDomainsResponse>(response);
                listRepoDomainsResponse.Body = JsonUtils.DeSerializeList<ShowRepoDomainsResponse>(response);
                return listRepoDomainsResponse;
            });
        }
        
        /// <summary>
        /// 查询镜像仓库列表
        ///
        /// 查询镜像仓库列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListReposDetailsResponse ListReposDetails(ListReposDetailsRequest listReposDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/repos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReposDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listReposDetailsResponse = JsonUtils.DeSerializeNull<ListReposDetailsResponse>(response);
            listReposDetailsResponse.Body = JsonUtils.DeSerializeList<ShowReposResp>(response);
            return listReposDetailsResponse;
        }

        public SyncInvoker<ListReposDetailsResponse> ListReposDetailsInvoker(ListReposDetailsRequest listReposDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/repos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReposDetailsRequest);
            return new SyncInvoker<ListReposDetailsResponse>(this, "GET", request, response =>
            {
                var listReposDetailsResponse = JsonUtils.DeSerializeNull<ListReposDetailsResponse>(response);
                listReposDetailsResponse.Body = JsonUtils.DeSerializeList<ShowReposResp>(response);
                return listReposDetailsResponse;
            });
        }
        
        /// <summary>
        /// 查询镜像tag列表详情
        ///
        /// 查询镜像tag列表详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRepositoryTagResponse ListRepositoryTag(ListRepositoryTagRequest listRepositoryTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryTagRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryTagRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v3/manage/namespaces/{namespace}/repos/{repository}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryTagRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRepositoryTagResponse>(response);
        }

        public SyncInvoker<ListRepositoryTagResponse> ListRepositoryTagInvoker(ListRepositoryTagRequest listRepositoryTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryTagRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryTagRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v3/manage/namespaces/{namespace}/repos/{repository}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryTagRequest);
            return new SyncInvoker<ListRepositoryTagResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRepositoryTagResponse>);
        }
        
        /// <summary>
        /// 查询镜像tag列表
        ///
        /// 查询镜像tag列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRepositoryTagsResponse ListRepositoryTags(ListRepositoryTagsRequest listRepositoryTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryTagsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryTagsRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listRepositoryTagsResponse = JsonUtils.DeSerializeNull<ListRepositoryTagsResponse>(response);
            listRepositoryTagsResponse.Body = JsonUtils.DeSerializeList<ShowReposTagResp>(response);
            return listRepositoryTagsResponse;
        }

        public SyncInvoker<ListRepositoryTagsResponse> ListRepositoryTagsInvoker(ListRepositoryTagsRequest listRepositoryTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryTagsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryTagsRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryTagsRequest);
            return new SyncInvoker<ListRepositoryTagsResponse>(this, "GET", request, response =>
            {
                var listRepositoryTagsResponse = JsonUtils.DeSerializeNull<ListRepositoryTagsResponse>(response);
                listRepositoryTagsResponse.Body = JsonUtils.DeSerializeList<ShowReposTagResp>(response);
                return listRepositoryTagsResponse;
            });
        }
        
        /// <summary>
        /// 获取镜像老化记录
        ///
        /// 获取镜像老化记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRetentionHistoriesResponse ListRetentionHistories(ListRetentionHistoriesRequest listRetentionHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRetentionHistoriesRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(listRetentionHistoriesRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions/histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRetentionHistoriesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRetentionHistoriesResponse>(response);
        }

        public SyncInvoker<ListRetentionHistoriesResponse> ListRetentionHistoriesInvoker(ListRetentionHistoriesRequest listRetentionHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRetentionHistoriesRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(listRetentionHistoriesRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions/histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRetentionHistoriesRequest);
            return new SyncInvoker<ListRetentionHistoriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRetentionHistoriesResponse>);
        }
        
        /// <summary>
        /// 获取镜像老化规则列表
        ///
        /// 获取镜像老化规则列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRetentionsResponse ListRetentions(ListRetentionsRequest listRetentionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRetentionsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(listRetentionsRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRetentionsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listRetentionsResponse = JsonUtils.DeSerializeNull<ListRetentionsResponse>(response);
            listRetentionsResponse.Body = JsonUtils.DeSerializeList<Retention>(response);
            return listRetentionsResponse;
        }

        public SyncInvoker<ListRetentionsResponse> ListRetentionsInvoker(ListRetentionsRequest listRetentionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRetentionsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(listRetentionsRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRetentionsRequest);
            return new SyncInvoker<ListRetentionsResponse>(this, "GET", request, response =>
            {
                var listRetentionsResponse = JsonUtils.DeSerializeNull<ListRetentionsResponse>(response);
                listRetentionsResponse.Body = JsonUtils.DeSerializeList<Retention>(response);
                return listRetentionsResponse;
            });
        }
        
        /// <summary>
        /// 查询共享镜像列表详情
        ///
        /// 查询共享镜像列表详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSharedRepoDetailsResponse ListSharedRepoDetails(ListSharedRepoDetailsRequest listSharedRepoDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/manage/shared-repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSharedRepoDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSharedRepoDetailsResponse>(response);
        }

        public SyncInvoker<ListSharedRepoDetailsResponse> ListSharedRepoDetailsInvoker(ListSharedRepoDetailsRequest listSharedRepoDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/manage/shared-repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSharedRepoDetailsRequest);
            return new SyncInvoker<ListSharedRepoDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSharedRepoDetailsResponse>);
        }
        
        /// <summary>
        /// 查询共享镜像列表
        ///
        /// 查询共享镜像列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSharedReposDetailsResponse ListSharedReposDetails(ListSharedReposDetailsRequest listSharedReposDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/shared-repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSharedReposDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listSharedReposDetailsResponse = JsonUtils.DeSerializeNull<ListSharedReposDetailsResponse>(response);
            listSharedReposDetailsResponse.Body = JsonUtils.DeSerializeList<ShowReposResp>(response);
            return listSharedReposDetailsResponse;
        }

        public SyncInvoker<ListSharedReposDetailsResponse> ListSharedReposDetailsInvoker(ListSharedReposDetailsRequest listSharedReposDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/shared-repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSharedReposDetailsRequest);
            return new SyncInvoker<ListSharedReposDetailsResponse>(this, "GET", request, response =>
            {
                var listSharedReposDetailsResponse = JsonUtils.DeSerializeNull<ListSharedReposDetailsResponse>(response);
                listSharedReposDetailsResponse.Body = JsonUtils.DeSerializeList<ShowReposResp>(response);
                return listSharedReposDetailsResponse;
            });
        }
        
        /// <summary>
        /// 获取可进行镜像同步的区域列表
        ///
        /// 获取可进行镜像同步的区域列表，用户可以将镜像手动或自动同步到此接口返回的区域。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSyncRegionsResponse ListSyncRegions(ListSyncRegionsRequest listSyncRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSyncRegionsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listSyncRegionsResponse = JsonUtils.DeSerializeNull<ListSyncRegionsResponse>(response);
            listSyncRegionsResponse.Body = JsonUtils.DeSerializeList<RegionInfo>(response);
            return listSyncRegionsResponse;
        }

        public SyncInvoker<ListSyncRegionsResponse> ListSyncRegionsInvoker(ListSyncRegionsRequest listSyncRegionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/regions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSyncRegionsRequest);
            return new SyncInvoker<ListSyncRegionsResponse>(this, "GET", request, response =>
            {
                var listSyncRegionsResponse = JsonUtils.DeSerializeNull<ListSyncRegionsResponse>(response);
                listSyncRegionsResponse.Body = JsonUtils.DeSerializeList<RegionInfo>(response);
                return listSyncRegionsResponse;
            });
        }
        
        /// <summary>
        /// 获取镜像仓库下的触发器列表
        ///
        /// 获取镜像仓库下的触发器列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTriggersDetailsResponse ListTriggersDetails(ListTriggersDetailsRequest listTriggersDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTriggersDetailsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(listTriggersDetailsRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTriggersDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listTriggersDetailsResponse = JsonUtils.DeSerializeNull<ListTriggersDetailsResponse>(response);
            listTriggersDetailsResponse.Body = JsonUtils.DeSerializeList<Trigger>(response);
            return listTriggersDetailsResponse;
        }

        public SyncInvoker<ListTriggersDetailsResponse> ListTriggersDetailsInvoker(ListTriggersDetailsRequest listTriggersDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTriggersDetailsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(listTriggersDetailsRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTriggersDetailsRequest);
            return new SyncInvoker<ListTriggersDetailsResponse>(this, "GET", request, response =>
            {
                var listTriggersDetailsResponse = JsonUtils.DeSerializeNull<ListTriggersDetailsResponse>(response);
                listTriggersDetailsResponse.Body = JsonUtils.DeSerializeList<Trigger>(response);
                return listTriggersDetailsResponse;
            });
        }
        
        /// <summary>
        /// 判断共享帐号是否存在
        ///
        /// 判断共享租户是否存在
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAccessDomainResponse ShowAccessDomain(ShowAccessDomainRequest showAccessDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAccessDomainRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(showAccessDomainRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(showAccessDomainRequest.AccessDomain, out var valueOfAccessDomain)) urlParam.Add("access_domain", valueOfAccessDomain);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains/{access_domain}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAccessDomainRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAccessDomainResponse>(response);
        }

        public SyncInvoker<ShowAccessDomainResponse> ShowAccessDomainInvoker(ShowAccessDomainRequest showAccessDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAccessDomainRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(showAccessDomainRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(showAccessDomainRequest.AccessDomain, out var valueOfAccessDomain)) urlParam.Add("access_domain", valueOfAccessDomain);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains/{access_domain}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAccessDomainRequest);
            return new SyncInvoker<ShowAccessDomainResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAccessDomainResponse>);
        }
        
        /// <summary>
        /// 获取租户总览信息
        ///
        /// 获取租户总览信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDomainOverviewResponse ShowDomainOverview(ShowDomainOverviewRequest showDomainOverviewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/overview", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainOverviewRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainOverviewResponse>(response);
        }

        public SyncInvoker<ShowDomainOverviewResponse> ShowDomainOverviewInvoker(ShowDomainOverviewRequest showDomainOverviewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/overview", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainOverviewRequest);
            return new SyncInvoker<ShowDomainOverviewResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainOverviewResponse>);
        }
        
        /// <summary>
        /// 获取租户资源统计信息
        ///
        /// 获取租户资源统计信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDomainResourceReportsResponse ShowDomainResourceReports(ShowDomainResourceReportsRequest showDomainResourceReportsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDomainResourceReportsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(showDomainResourceReportsRequest.Frequency, out var valueOfFrequency)) urlParam.Add("frequency", valueOfFrequency);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/reports/{resource_type}/{frequency}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainResourceReportsRequest);
            var response = DoHttpRequestSync("GET", request);
            var showDomainResourceReportsResponse = JsonUtils.DeSerializeNull<ShowDomainResourceReportsResponse>(response);
            showDomainResourceReportsResponse.Body = JsonUtils.DeSerializeList<ReportData>(response);
            return showDomainResourceReportsResponse;
        }

        public SyncInvoker<ShowDomainResourceReportsResponse> ShowDomainResourceReportsInvoker(ShowDomainResourceReportsRequest showDomainResourceReportsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDomainResourceReportsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(showDomainResourceReportsRequest.Frequency, out var valueOfFrequency)) urlParam.Add("frequency", valueOfFrequency);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/reports/{resource_type}/{frequency}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainResourceReportsRequest);
            return new SyncInvoker<ShowDomainResourceReportsResponse>(this, "GET", request, response =>
            {
                var showDomainResourceReportsResponse = JsonUtils.DeSerializeNull<ShowDomainResourceReportsResponse>(response);
                showDomainResourceReportsResponse.Body = JsonUtils.DeSerializeList<ReportData>(response);
                return showDomainResourceReportsResponse;
            });
        }
        
        /// <summary>
        /// 获取组织详情
        ///
        /// 获取组织详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowNamespaceResponse ShowNamespace(ShowNamespaceRequest showNamespaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNamespaceRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNamespaceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowNamespaceResponse>(response);
        }

        public SyncInvoker<ShowNamespaceResponse> ShowNamespaceInvoker(ShowNamespaceRequest showNamespaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNamespaceRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNamespaceRequest);
            return new SyncInvoker<ShowNamespaceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNamespaceResponse>);
        }
        
        /// <summary>
        /// 查询组织权限
        ///
        /// 查询组织权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowNamespaceAuthResponse ShowNamespaceAuth(ShowNamespaceAuthRequest showNamespaceAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNamespaceAuthRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNamespaceAuthRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowNamespaceAuthResponse>(response);
        }

        public SyncInvoker<ShowNamespaceAuthResponse> ShowNamespaceAuthInvoker(ShowNamespaceAuthRequest showNamespaceAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNamespaceAuthRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNamespaceAuthRequest);
            return new SyncInvoker<ShowNamespaceAuthResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNamespaceAuthResponse>);
        }
        
        /// <summary>
        /// 查询指定tag的镜像详情
        ///
        /// 查询镜像仓库中指定tag的镜像
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRepoTagResponse ShowRepoTag(ShowRepoTagRequest showRepoTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepoTagRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(showRepoTagRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(showRepoTagRequest.Tag, out var valueOfTag)) urlParam.Add("tag", valueOfTag);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/tags/{tag}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepoTagRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRepoTagResponse>(response);
        }

        public SyncInvoker<ShowRepoTagResponse> ShowRepoTagInvoker(ShowRepoTagRequest showRepoTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepoTagRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(showRepoTagRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(showRepoTagRequest.Tag, out var valueOfTag)) urlParam.Add("tag", valueOfTag);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/tags/{tag}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepoTagRequest);
            return new SyncInvoker<ShowRepoTagResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepoTagResponse>);
        }
        
        /// <summary>
        /// 查询镜像仓库概要信息
        ///
        /// 查询镜像仓库概要信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRepositoryResponse ShowRepository(ShowRepositoryRequest showRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRepositoryResponse>(response);
        }

        public SyncInvoker<ShowRepositoryResponse> ShowRepositoryInvoker(ShowRepositoryRequest showRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryRequest);
            return new SyncInvoker<ShowRepositoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepositoryResponse>);
        }
        
        /// <summary>
        /// 获取镜像老化规则记录
        ///
        /// 获取镜像老化规则记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRetentionResponse ShowRetention(ShowRetentionRequest showRetentionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRetentionRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(showRetentionRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(showRetentionRequest.RetentionId, out var valueOfRetentionId)) urlParam.Add("retention_id", valueOfRetentionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions/{retention_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRetentionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRetentionResponse>(response);
        }

        public SyncInvoker<ShowRetentionResponse> ShowRetentionInvoker(ShowRetentionRequest showRetentionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRetentionRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(showRetentionRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(showRetentionRequest.RetentionId, out var valueOfRetentionId)) urlParam.Add("retention_id", valueOfRetentionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions/{retention_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRetentionRequest);
            return new SyncInvoker<ShowRetentionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRetentionResponse>);
        }
        
        /// <summary>
        /// 查询服务特性开关信息
        ///
        /// 查询服务特性开关信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowShareFeatureGatesResponse ShowShareFeatureGates(ShowShareFeatureGatesRequest showShareFeatureGatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/projects/{project_id}/feature-gates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showShareFeatureGatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowShareFeatureGatesResponse>(response);
        }

        public SyncInvoker<ShowShareFeatureGatesResponse> ShowShareFeatureGatesInvoker(ShowShareFeatureGatesRequest showShareFeatureGatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/projects/{project_id}/feature-gates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showShareFeatureGatesRequest);
            return new SyncInvoker<ShowShareFeatureGatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowShareFeatureGatesResponse>);
        }
        
        /// <summary>
        /// 获取镜像自动同步任务信息
        ///
        /// 创建镜像自动同步任务后，可以通过此接口查询该任务的状态，以判断是否同步成功。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSyncJobResponse ShowSyncJob(ShowSyncJobRequest showSyncJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSyncJobRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(showSyncJobRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/sync_job", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSyncJobRequest);
            var response = DoHttpRequestSync("GET", request);
            var showSyncJobResponse = JsonUtils.DeSerializeNull<ShowSyncJobResponse>(response);
            showSyncJobResponse.Body = JsonUtils.DeSerializeList<SyncJob>(response);
            return showSyncJobResponse;
        }

        public SyncInvoker<ShowSyncJobResponse> ShowSyncJobInvoker(ShowSyncJobRequest showSyncJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSyncJobRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(showSyncJobRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/sync_job", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSyncJobRequest);
            return new SyncInvoker<ShowSyncJobResponse>(this, "GET", request, response =>
            {
                var showSyncJobResponse = JsonUtils.DeSerializeNull<ShowSyncJobResponse>(response);
                showSyncJobResponse.Body = JsonUtils.DeSerializeList<SyncJob>(response);
                return showSyncJobResponse;
            });
        }
        
        /// <summary>
        /// 获取触发器详情
        ///
        /// 获取触发器详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTriggerResponse ShowTrigger(ShowTriggerRequest showTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTriggerRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(showTriggerRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(showTriggerRequest.Trigger, out var valueOfTrigger)) urlParam.Add("trigger", valueOfTrigger);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers/{trigger}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTriggerRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTriggerResponse>(response);
        }

        public SyncInvoker<ShowTriggerResponse> ShowTriggerInvoker(ShowTriggerRequest showTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTriggerRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(showTriggerRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(showTriggerRequest.Trigger, out var valueOfTrigger)) urlParam.Add("trigger", valueOfTrigger);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers/{trigger}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTriggerRequest);
            return new SyncInvoker<ShowTriggerResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTriggerResponse>);
        }
        
        /// <summary>
        /// 查询镜像权限
        ///
        /// 查询镜像权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowUserRepositoryAuthResponse ShowUserRepositoryAuth(ShowUserRepositoryAuthRequest showUserRepositoryAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUserRepositoryAuthRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(showUserRepositoryAuthRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserRepositoryAuthRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowUserRepositoryAuthResponse>(response);
        }

        public SyncInvoker<ShowUserRepositoryAuthResponse> ShowUserRepositoryAuthInvoker(ShowUserRepositoryAuthRequest showUserRepositoryAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUserRepositoryAuthRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(showUserRepositoryAuthRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserRepositoryAuthRequest);
            return new SyncInvoker<ShowUserRepositoryAuthResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUserRepositoryAuthResponse>);
        }
        
        /// <summary>
        /// 更新组织权限
        ///
        /// 更新组织权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateNamespaceAuthResponse UpdateNamespaceAuth(UpdateNamespaceAuthRequest updateNamespaceAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateNamespaceAuthRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNamespaceAuthRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerializeNull<UpdateNamespaceAuthResponse>(response);
        }

        public SyncInvoker<UpdateNamespaceAuthResponse> UpdateNamespaceAuthInvoker(UpdateNamespaceAuthRequest updateNamespaceAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateNamespaceAuthRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNamespaceAuthRequest);
            return new SyncInvoker<UpdateNamespaceAuthResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<UpdateNamespaceAuthResponse>);
        }
        
        /// <summary>
        /// 更新镜像仓库的概要信息
        ///
        /// 更新租户组织下的镜像概要信息，包括镜像类型、是否公有、描述信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRepoResponse UpdateRepo(UpdateRepoRequest updateRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepoRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(updateRepoRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepoRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerializeNull<UpdateRepoResponse>(response);
        }

        public SyncInvoker<UpdateRepoResponse> UpdateRepoInvoker(UpdateRepoRequest updateRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepoRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(updateRepoRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepoRequest);
            return new SyncInvoker<UpdateRepoResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<UpdateRepoResponse>);
        }
        
        /// <summary>
        /// 更新共享帐号
        ///
        /// 更新共享帐号
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRepoDomainsResponse UpdateRepoDomains(UpdateRepoDomainsRequest updateRepoDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepoDomainsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(updateRepoDomainsRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(updateRepoDomainsRequest.AccessDomain, out var valueOfAccessDomain)) urlParam.Add("access_domain", valueOfAccessDomain);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains/{access_domain}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepoDomainsRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerializeNull<UpdateRepoDomainsResponse>(response);
        }

        public SyncInvoker<UpdateRepoDomainsResponse> UpdateRepoDomainsInvoker(UpdateRepoDomainsRequest updateRepoDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepoDomainsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(updateRepoDomainsRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(updateRepoDomainsRequest.AccessDomain, out var valueOfAccessDomain)) urlParam.Add("access_domain", valueOfAccessDomain);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains/{access_domain}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepoDomainsRequest);
            return new SyncInvoker<UpdateRepoDomainsResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<UpdateRepoDomainsResponse>);
        }
        
        /// <summary>
        /// 修改镜像老化规则
        ///
        /// 修改镜像老化规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRetentionResponse UpdateRetention(UpdateRetentionRequest updateRetentionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRetentionRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(updateRetentionRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(updateRetentionRequest.RetentionId, out var valueOfRetentionId)) urlParam.Add("retention_id", valueOfRetentionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions/{retention_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRetentionRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerializeNull<UpdateRetentionResponse>(response);
        }

        public SyncInvoker<UpdateRetentionResponse> UpdateRetentionInvoker(UpdateRetentionRequest updateRetentionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRetentionRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(updateRetentionRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(updateRetentionRequest.RetentionId, out var valueOfRetentionId)) urlParam.Add("retention_id", valueOfRetentionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions/{retention_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRetentionRequest);
            return new SyncInvoker<UpdateRetentionResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<UpdateRetentionResponse>);
        }
        
        /// <summary>
        /// 更新触发器配置
        ///
        /// 更新触发器配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTriggerResponse UpdateTrigger(UpdateTriggerRequest updateTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTriggerRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(updateTriggerRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(updateTriggerRequest.Trigger, out var valueOfTrigger)) urlParam.Add("trigger", valueOfTrigger);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers/{trigger}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTriggerRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerializeNull<UpdateTriggerResponse>(response);
        }

        public SyncInvoker<UpdateTriggerResponse> UpdateTriggerInvoker(UpdateTriggerRequest updateTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTriggerRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(updateTriggerRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(updateTriggerRequest.Trigger, out var valueOfTrigger)) urlParam.Add("trigger", valueOfTrigger);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers/{trigger}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTriggerRequest);
            return new SyncInvoker<UpdateTriggerResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<UpdateTriggerResponse>);
        }
        
        /// <summary>
        /// 更新镜像权限
        ///
        /// 更新镜像权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateUserRepositoryAuthResponse UpdateUserRepositoryAuth(UpdateUserRepositoryAuthRequest updateUserRepositoryAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateUserRepositoryAuthRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(updateUserRepositoryAuthRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserRepositoryAuthRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerializeNull<UpdateUserRepositoryAuthResponse>(response);
        }

        public SyncInvoker<UpdateUserRepositoryAuthResponse> UpdateUserRepositoryAuthInvoker(UpdateUserRepositoryAuthRequest updateUserRepositoryAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateUserRepositoryAuthRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(updateUserRepositoryAuthRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserRepositoryAuthRequest);
            return new SyncInvoker<UpdateUserRepositoryAuthResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<UpdateUserRepositoryAuthResponse>);
        }
        
        /// <summary>
        /// 查询所有API版本信息
        ///
        /// 查询所有API版本信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListApiVersionsResponse ListApiVersions(ListApiVersionsRequest listApiVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListApiVersionsResponse>(response);
        }

        public SyncInvoker<ListApiVersionsResponse> ListApiVersionsInvoker(ListApiVersionsRequest listApiVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionsRequest);
            return new SyncInvoker<ListApiVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApiVersionsResponse>);
        }
        
        /// <summary>
        /// 查询指定API版本信息
        ///
        /// 查询指定API版本信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowApiVersionResponse ShowApiVersion(ShowApiVersionRequest showApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showApiVersionRequest.ApiVersion, out var valueOfApiVersion)) urlParam.Add("api_version", valueOfApiVersion);
            var urlPath = HttpUtils.AddUrlPath("/{api_version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowApiVersionResponse>(response);
        }

        public SyncInvoker<ShowApiVersionResponse> ShowApiVersionInvoker(ShowApiVersionRequest showApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showApiVersionRequest.ApiVersion, out var valueOfApiVersion)) urlParam.Add("api_version", valueOfApiVersion);
            var urlPath = HttpUtils.AddUrlPath("/{api_version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            return new SyncInvoker<ShowApiVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowApiVersionResponse>);
        }
        
        /// <summary>
        /// 增加域名
        ///
        /// 增加域名
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddDomainNameResponse AddDomainName(AddDomainNameRequest addDomainNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addDomainNameRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/domainname", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDomainNameRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddDomainNameResponse>(response);
        }

        public SyncInvoker<AddDomainNameResponse> AddDomainNameInvoker(AddDomainNameRequest addDomainNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addDomainNameRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/domainname", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDomainNameRequest);
            return new SyncInvoker<AddDomainNameResponse>(this, "POST", request, JsonUtils.DeSerialize<AddDomainNameResponse>);
        }
        
        /// <summary>
        /// 创建不可变Tag策略
        ///
        /// 创建不可变Tag策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateImmutableRuleResponse CreateImmutableRule(CreateImmutableRuleRequest createImmutableRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createImmutableRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(createImmutableRuleRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/immutabletagrules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createImmutableRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateImmutableRuleResponse>(response);
        }

        public SyncInvoker<CreateImmutableRuleResponse> CreateImmutableRuleInvoker(CreateImmutableRuleRequest createImmutableRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createImmutableRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(createImmutableRuleRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/immutabletagrules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createImmutableRuleRequest);
            return new SyncInvoker<CreateImmutableRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateImmutableRuleResponse>);
        }
        
        /// <summary>
        /// 创建实例
        ///
        /// 创建企业仓库实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateInstanceResponse CreateInstance(CreateInstanceRequest createInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceResponse>(response);
        }

        public SyncInvoker<CreateInstanceResponse> CreateInstanceInvoker(CreateInstanceRequest createInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceRequest);
            return new SyncInvoker<CreateInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceResponse>);
        }
        
        /// <summary>
        /// 开启或关闭公网访问
        ///
        /// 开启或关闭公网访问
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateInstanceEndpointPolicyResponse CreateInstanceEndpointPolicy(CreateInstanceEndpointPolicyRequest createInstanceEndpointPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceEndpointPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/endpoint-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceEndpointPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateInstanceEndpointPolicyResponse>(response);
        }

        public SyncInvoker<CreateInstanceEndpointPolicyResponse> CreateInstanceEndpointPolicyInvoker(CreateInstanceEndpointPolicyRequest createInstanceEndpointPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceEndpointPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/endpoint-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceEndpointPolicyRequest);
            return new SyncInvoker<CreateInstanceEndpointPolicyResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateInstanceEndpointPolicyResponse>);
        }
        
        /// <summary>
        /// 新增内网访问
        ///
        /// 新增内网访问
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateInstanceInternalEndpointResponse CreateInstanceInternalEndpoint(CreateInstanceInternalEndpointRequest createInstanceInternalEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceInternalEndpointRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/internal-endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceInternalEndpointRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceInternalEndpointResponse>(response);
        }

        public SyncInvoker<CreateInstanceInternalEndpointResponse> CreateInstanceInternalEndpointInvoker(CreateInstanceInternalEndpointRequest createInstanceInternalEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceInternalEndpointRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/internal-endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceInternalEndpointRequest);
            return new SyncInvoker<CreateInstanceInternalEndpointResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceInternalEndpointResponse>);
        }
        
        /// <summary>
        /// 创建长期访问凭证
        ///
        /// 创建长期访问凭证
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateInstanceLtCredentialResponse CreateInstanceLtCredential(CreateInstanceLtCredentialRequest createInstanceLtCredentialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceLtCredentialRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/long-term-credential", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceLtCredentialRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceLtCredentialResponse>(response);
        }

        public SyncInvoker<CreateInstanceLtCredentialResponse> CreateInstanceLtCredentialInvoker(CreateInstanceLtCredentialRequest createInstanceLtCredentialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceLtCredentialRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/long-term-credential", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceLtCredentialRequest);
            return new SyncInvoker<CreateInstanceLtCredentialResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceLtCredentialResponse>);
        }
        
        /// <summary>
        /// 创建命名空间
        ///
        /// 创建命名空间
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateInstanceNamespaceResponse CreateInstanceNamespace(CreateInstanceNamespaceRequest createInstanceNamespaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceNamespaceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceNamespaceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceNamespaceResponse>(response);
        }

        public SyncInvoker<CreateInstanceNamespaceResponse> CreateInstanceNamespaceInvoker(CreateInstanceNamespaceRequest createInstanceNamespaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceNamespaceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceNamespaceRequest);
            return new SyncInvoker<CreateInstanceNamespaceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceNamespaceResponse>);
        }
        
        /// <summary>
        /// 创建镜像同步的目标仓库
        ///
        /// 创建镜像同步的目标仓库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateInstanceRegistryResponse CreateInstanceRegistry(CreateInstanceRegistryRequest createInstanceRegistryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceRegistryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/registries", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceRegistryRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceRegistryResponse>(response);
        }

        public SyncInvoker<CreateInstanceRegistryResponse> CreateInstanceRegistryInvoker(CreateInstanceRegistryRequest createInstanceRegistryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceRegistryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/registries", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceRegistryRequest);
            return new SyncInvoker<CreateInstanceRegistryResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceRegistryResponse>);
        }
        
        /// <summary>
        /// 创建镜像同步策略
        ///
        /// 创建镜像同步策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateInstanceReplicationPolicyResponse CreateInstanceReplicationPolicy(CreateInstanceReplicationPolicyRequest createInstanceReplicationPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceReplicationPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceReplicationPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceReplicationPolicyResponse>(response);
        }

        public SyncInvoker<CreateInstanceReplicationPolicyResponse> CreateInstanceReplicationPolicyInvoker(CreateInstanceReplicationPolicyRequest createInstanceReplicationPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceReplicationPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceReplicationPolicyRequest);
            return new SyncInvoker<CreateInstanceReplicationPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceReplicationPolicyResponse>);
        }
        
        /// <summary>
        /// 批量添加资源标签
        ///
        /// 批量添加资源标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateInstanceResourceTagsResponse CreateInstanceResourceTags(CreateInstanceResourceTagsRequest createInstanceResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(createInstanceResourceTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceResourceTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateInstanceResourceTagsResponse>(response);
        }

        public SyncInvoker<CreateInstanceResourceTagsResponse> CreateInstanceResourceTagsInvoker(CreateInstanceResourceTagsRequest createInstanceResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(createInstanceResourceTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceResourceTagsRequest);
            return new SyncInvoker<CreateInstanceResourceTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateInstanceResourceTagsResponse>);
        }
        
        /// <summary>
        /// 创建老化策略
        ///
        /// 创建老化策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateInstanceRetentionPolicyResponse CreateInstanceRetentionPolicy(CreateInstanceRetentionPolicyRequest createInstanceRetentionPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceRetentionPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(createInstanceRetentionPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/retention/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceRetentionPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceRetentionPolicyResponse>(response);
        }

        public SyncInvoker<CreateInstanceRetentionPolicyResponse> CreateInstanceRetentionPolicyInvoker(CreateInstanceRetentionPolicyRequest createInstanceRetentionPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceRetentionPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(createInstanceRetentionPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/retention/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceRetentionPolicyRequest);
            return new SyncInvoker<CreateInstanceRetentionPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceRetentionPolicyResponse>);
        }
        
        /// <summary>
        /// 创建签名策略
        ///
        /// 创建签名策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateInstanceSignPolicyResponse CreateInstanceSignPolicy(CreateInstanceSignPolicyRequest createInstanceSignPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceSignPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(createInstanceSignPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/signature/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceSignPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceSignPolicyResponse>(response);
        }

        public SyncInvoker<CreateInstanceSignPolicyResponse> CreateInstanceSignPolicyInvoker(CreateInstanceSignPolicyRequest createInstanceSignPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceSignPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(createInstanceSignPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/signature/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceSignPolicyRequest);
            return new SyncInvoker<CreateInstanceSignPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceSignPolicyResponse>);
        }
        
        /// <summary>
        /// 获取临时访问凭证
        ///
        /// 获取临时访问凭证
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateInstanceTempCredentialResponse CreateInstanceTempCredential(CreateInstanceTempCredentialRequest createInstanceTempCredentialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceTempCredentialRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/temp-credential", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceTempCredentialRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceTempCredentialResponse>(response);
        }

        public SyncInvoker<CreateInstanceTempCredentialResponse> CreateInstanceTempCredentialInvoker(CreateInstanceTempCredentialRequest createInstanceTempCredentialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceTempCredentialRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/temp-credential", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceTempCredentialRequest);
            return new SyncInvoker<CreateInstanceTempCredentialResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceTempCredentialResponse>);
        }
        
        /// <summary>
        /// 创建触发器
        ///
        /// 创建触发器
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateInstanceWebhookResponse CreateInstanceWebhook(CreateInstanceWebhookRequest createInstanceWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceWebhookRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(createInstanceWebhookRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/webhook/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceWebhookRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceWebhookResponse>(response);
        }

        public SyncInvoker<CreateInstanceWebhookResponse> CreateInstanceWebhookInvoker(CreateInstanceWebhookRequest createInstanceWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceWebhookRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(createInstanceWebhookRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/webhook/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceWebhookRequest);
            return new SyncInvoker<CreateInstanceWebhookResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceWebhookResponse>);
        }
        
        /// <summary>
        /// 批量添加子资源标签
        ///
        /// 批量添加子资源标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateSubResourceTagsResponse CreateSubResourceTags(CreateSubResourceTagsRequest createSubResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createSubResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(createSubResourceTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            if (StringUtils.TryConvertToNonEmptyString(createSubResourceTagsRequest.SubResourceType, out var valueOfSubResourceType)) urlParam.Add("sub_resource_type", valueOfSubResourceType);
            if (StringUtils.TryConvertToNonEmptyString(createSubResourceTagsRequest.SubResourceId, out var valueOfSubResourceId)) urlParam.Add("sub_resource_id", valueOfSubResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/{sub_resource_type}/{sub_resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSubResourceTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateSubResourceTagsResponse>(response);
        }

        public SyncInvoker<CreateSubResourceTagsResponse> CreateSubResourceTagsInvoker(CreateSubResourceTagsRequest createSubResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createSubResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(createSubResourceTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            if (StringUtils.TryConvertToNonEmptyString(createSubResourceTagsRequest.SubResourceType, out var valueOfSubResourceType)) urlParam.Add("sub_resource_type", valueOfSubResourceType);
            if (StringUtils.TryConvertToNonEmptyString(createSubResourceTagsRequest.SubResourceId, out var valueOfSubResourceId)) urlParam.Add("sub_resource_id", valueOfSubResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/{sub_resource_type}/{sub_resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSubResourceTagsRequest);
            return new SyncInvoker<CreateSubResourceTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateSubResourceTagsResponse>);
        }
        
        /// <summary>
        /// 删除域名
        ///
        /// 删除域名，SWR企业仓库的默认域名无法删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDomainNameResponse DeleteDomainName(DeleteDomainNameRequest deleteDomainNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDomainNameRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteDomainNameRequest.DomainnameId, out var valueOfDomainnameId)) urlParam.Add("domainname_id", valueOfDomainnameId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/domainname/{domainname_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainNameRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDomainNameResponse>(response);
        }

        public SyncInvoker<DeleteDomainNameResponse> DeleteDomainNameInvoker(DeleteDomainNameRequest deleteDomainNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDomainNameRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteDomainNameRequest.DomainnameId, out var valueOfDomainnameId)) urlParam.Add("domainname_id", valueOfDomainnameId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/domainname/{domainname_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainNameRequest);
            return new SyncInvoker<DeleteDomainNameResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDomainNameResponse>);
        }
        
        /// <summary>
        /// 删除不可变Tag策略
        ///
        /// 删除不可变Tag策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteImmutableRuleResponse DeleteImmutableRule(DeleteImmutableRuleRequest deleteImmutableRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteImmutableRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteImmutableRuleRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(deleteImmutableRuleRequest.ImmutableRuleId, out var valueOfImmutableRuleId)) urlParam.Add("immutable_rule_id", valueOfImmutableRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/immutabletagrules/{immutable_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteImmutableRuleRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteImmutableRuleResponse>(response);
        }

        public SyncInvoker<DeleteImmutableRuleResponse> DeleteImmutableRuleInvoker(DeleteImmutableRuleRequest deleteImmutableRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteImmutableRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteImmutableRuleRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(deleteImmutableRuleRequest.ImmutableRuleId, out var valueOfImmutableRuleId)) urlParam.Add("immutable_rule_id", valueOfImmutableRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/immutabletagrules/{immutable_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteImmutableRuleRequest);
            return new SyncInvoker<DeleteImmutableRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteImmutableRuleResponse>);
        }
        
        /// <summary>
        /// 删除实例
        ///
        /// 删除实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest deleteInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceResponse>(response);
        }

        public SyncInvoker<DeleteInstanceResponse> DeleteInstanceInvoker(DeleteInstanceRequest deleteInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRequest);
            return new SyncInvoker<DeleteInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceResponse>);
        }
        
        /// <summary>
        /// 删除制品版本
        ///
        /// 删除制品版本
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteInstanceArtifactResponse DeleteInstanceArtifact(DeleteInstanceArtifactRequest deleteInstanceArtifactRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceArtifactRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceArtifactRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceArtifactRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceArtifactRequest.Reference, out var valueOfReference)) urlParam.Add("reference", valueOfReference);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}/artifacts/{reference}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceArtifactRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceArtifactResponse>(response);
        }

        public SyncInvoker<DeleteInstanceArtifactResponse> DeleteInstanceArtifactInvoker(DeleteInstanceArtifactRequest deleteInstanceArtifactRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceArtifactRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceArtifactRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceArtifactRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceArtifactRequest.Reference, out var valueOfReference)) urlParam.Add("reference", valueOfReference);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}/artifacts/{reference}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceArtifactRequest);
            return new SyncInvoker<DeleteInstanceArtifactResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceArtifactResponse>);
        }
        
        /// <summary>
        /// 删除内网访问
        ///
        /// 删除内网访问
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteInstanceInternalEndpointResponse DeleteInstanceInternalEndpoint(DeleteInstanceInternalEndpointRequest deleteInstanceInternalEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceInternalEndpointRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceInternalEndpointRequest.InternalEndpointsId, out var valueOfInternalEndpointsId)) urlParam.Add("internal_endpoints_id", valueOfInternalEndpointsId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/internal-endpoints/{internal_endpoints_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceInternalEndpointRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceInternalEndpointResponse>(response);
        }

        public SyncInvoker<DeleteInstanceInternalEndpointResponse> DeleteInstanceInternalEndpointInvoker(DeleteInstanceInternalEndpointRequest deleteInstanceInternalEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceInternalEndpointRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceInternalEndpointRequest.InternalEndpointsId, out var valueOfInternalEndpointsId)) urlParam.Add("internal_endpoints_id", valueOfInternalEndpointsId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/internal-endpoints/{internal_endpoints_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceInternalEndpointRequest);
            return new SyncInvoker<DeleteInstanceInternalEndpointResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceInternalEndpointResponse>);
        }
        
        /// <summary>
        /// 删除任务
        ///
        /// 删除任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteInstanceJobResponse DeleteInstanceJob(DeleteInstanceJobRequest deleteInstanceJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceJobRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceJobResponse>(response);
        }

        public SyncInvoker<DeleteInstanceJobResponse> DeleteInstanceJobInvoker(DeleteInstanceJobRequest deleteInstanceJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceJobRequest);
            return new SyncInvoker<DeleteInstanceJobResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceJobResponse>);
        }
        
        /// <summary>
        /// 删除长期访问凭证
        ///
        /// 删除长期访问凭证
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteInstanceLtCredentialResponse DeleteInstanceLtCredential(DeleteInstanceLtCredentialRequest deleteInstanceLtCredentialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceLtCredentialRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceLtCredentialRequest.CredentialId, out var valueOfCredentialId)) urlParam.Add("credential_id", valueOfCredentialId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/long-term-credentials/{credential_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceLtCredentialRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceLtCredentialResponse>(response);
        }

        public SyncInvoker<DeleteInstanceLtCredentialResponse> DeleteInstanceLtCredentialInvoker(DeleteInstanceLtCredentialRequest deleteInstanceLtCredentialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceLtCredentialRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceLtCredentialRequest.CredentialId, out var valueOfCredentialId)) urlParam.Add("credential_id", valueOfCredentialId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/long-term-credentials/{credential_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceLtCredentialRequest);
            return new SyncInvoker<DeleteInstanceLtCredentialResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceLtCredentialResponse>);
        }
        
        /// <summary>
        /// 删除命名空间
        ///
        /// 删除命名空间
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteInstanceNamespaceResponse DeleteInstanceNamespace(DeleteInstanceNamespaceRequest deleteInstanceNamespaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceNamespaceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceNamespaceRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceNamespaceRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceNamespaceResponse>(response);
        }

        public SyncInvoker<DeleteInstanceNamespaceResponse> DeleteInstanceNamespaceInvoker(DeleteInstanceNamespaceRequest deleteInstanceNamespaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceNamespaceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceNamespaceRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceNamespaceRequest);
            return new SyncInvoker<DeleteInstanceNamespaceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceNamespaceResponse>);
        }
        
        /// <summary>
        /// 删除镜像同步的目标仓库
        ///
        /// 删除同步仓库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteInstanceRegistryResponse DeleteInstanceRegistry(DeleteInstanceRegistryRequest deleteInstanceRegistryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRegistryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRegistryRequest.RegistryId, out var valueOfRegistryId)) urlParam.Add("registry_id", valueOfRegistryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/registries/{registry_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRegistryRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceRegistryResponse>(response);
        }

        public SyncInvoker<DeleteInstanceRegistryResponse> DeleteInstanceRegistryInvoker(DeleteInstanceRegistryRequest deleteInstanceRegistryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRegistryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRegistryRequest.RegistryId, out var valueOfRegistryId)) urlParam.Add("registry_id", valueOfRegistryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/registries/{registry_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRegistryRequest);
            return new SyncInvoker<DeleteInstanceRegistryResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceRegistryResponse>);
        }
        
        /// <summary>
        /// 删除镜像同步策略
        ///
        /// 删除镜像同步策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteInstanceReplicationPolicyResponse DeleteInstanceReplicationPolicy(DeleteInstanceReplicationPolicyRequest deleteInstanceReplicationPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceReplicationPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceReplicationPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceReplicationPolicyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceReplicationPolicyResponse>(response);
        }

        public SyncInvoker<DeleteInstanceReplicationPolicyResponse> DeleteInstanceReplicationPolicyInvoker(DeleteInstanceReplicationPolicyRequest deleteInstanceReplicationPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceReplicationPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceReplicationPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceReplicationPolicyRequest);
            return new SyncInvoker<DeleteInstanceReplicationPolicyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceReplicationPolicyResponse>);
        }
        
        /// <summary>
        /// 删除制品仓库
        ///
        /// 删除仓库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteInstanceRepositoryResponse DeleteInstanceRepository(DeleteInstanceRepositoryRequest deleteInstanceRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRepositoryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRepositoryRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRepositoryRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRepositoryRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceRepositoryResponse>(response);
        }

        public SyncInvoker<DeleteInstanceRepositoryResponse> DeleteInstanceRepositoryInvoker(DeleteInstanceRepositoryRequest deleteInstanceRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRepositoryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRepositoryRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRepositoryRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRepositoryRequest);
            return new SyncInvoker<DeleteInstanceRepositoryResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceRepositoryResponse>);
        }
        
        /// <summary>
        /// 批量删除资源标签
        ///
        /// 批量删除资源标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteInstanceResourceTagsResponse DeleteInstanceResourceTags(DeleteInstanceResourceTagsRequest deleteInstanceResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceResourceTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceResourceTagsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceResourceTagsResponse>(response);
        }

        public SyncInvoker<DeleteInstanceResourceTagsResponse> DeleteInstanceResourceTagsInvoker(DeleteInstanceResourceTagsRequest deleteInstanceResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceResourceTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceResourceTagsRequest);
            return new SyncInvoker<DeleteInstanceResourceTagsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceResourceTagsResponse>);
        }
        
        /// <summary>
        /// 删除老化策略
        ///
        /// 删除老化策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteInstanceRetentionPolicyResponse DeleteInstanceRetentionPolicy(DeleteInstanceRetentionPolicyRequest deleteInstanceRetentionPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRetentionPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRetentionPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRetentionPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/retention/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRetentionPolicyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceRetentionPolicyResponse>(response);
        }

        public SyncInvoker<DeleteInstanceRetentionPolicyResponse> DeleteInstanceRetentionPolicyInvoker(DeleteInstanceRetentionPolicyRequest deleteInstanceRetentionPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRetentionPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRetentionPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRetentionPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/retention/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRetentionPolicyRequest);
            return new SyncInvoker<DeleteInstanceRetentionPolicyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceRetentionPolicyResponse>);
        }
        
        /// <summary>
        /// 删除签名策略
        ///
        /// 删除签名策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteInstanceSignPolicyResponse DeleteInstanceSignPolicy(DeleteInstanceSignPolicyRequest deleteInstanceSignPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceSignPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceSignPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceSignPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/signature/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceSignPolicyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceSignPolicyResponse>(response);
        }

        public SyncInvoker<DeleteInstanceSignPolicyResponse> DeleteInstanceSignPolicyInvoker(DeleteInstanceSignPolicyRequest deleteInstanceSignPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceSignPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceSignPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceSignPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/signature/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceSignPolicyRequest);
            return new SyncInvoker<DeleteInstanceSignPolicyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceSignPolicyResponse>);
        }
        
        /// <summary>
        /// 删除制品的Tag
        ///
        /// 删除制品Tag
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteInstanceTagResponse DeleteInstanceTag(DeleteInstanceTagRequest deleteInstanceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceTagRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceTagRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceTagRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceTagRequest.TagName, out var valueOfTagName)) urlParam.Add("tag_name", valueOfTagName);
            var urlPath = HttpUtils.AddUrlPath("/v2/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}/tags/{tag_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceTagRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceTagResponse>(response);
        }

        public SyncInvoker<DeleteInstanceTagResponse> DeleteInstanceTagInvoker(DeleteInstanceTagRequest deleteInstanceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceTagRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceTagRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceTagRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceTagRequest.TagName, out var valueOfTagName)) urlParam.Add("tag_name", valueOfTagName);
            var urlPath = HttpUtils.AddUrlPath("/v2/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}/tags/{tag_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceTagRequest);
            return new SyncInvoker<DeleteInstanceTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceTagResponse>);
        }
        
        /// <summary>
        /// 删除触发器
        ///
        /// 删除触发器
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteInstanceWebhookResponse DeleteInstanceWebhook(DeleteInstanceWebhookRequest deleteInstanceWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceWebhookRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceWebhookRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceWebhookRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/webhook/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceWebhookRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceWebhookResponse>(response);
        }

        public SyncInvoker<DeleteInstanceWebhookResponse> DeleteInstanceWebhookInvoker(DeleteInstanceWebhookRequest deleteInstanceWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceWebhookRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceWebhookRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceWebhookRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/webhook/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceWebhookRequest);
            return new SyncInvoker<DeleteInstanceWebhookResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceWebhookResponse>);
        }
        
        /// <summary>
        /// 批量删除子资源标签
        ///
        /// 批量删除子资源标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSubResourceTagsResponse DeleteSubResourceTags(DeleteSubResourceTagsRequest deleteSubResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSubResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(deleteSubResourceTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteSubResourceTagsRequest.SubResourceType, out var valueOfSubResourceType)) urlParam.Add("sub_resource_type", valueOfSubResourceType);
            if (StringUtils.TryConvertToNonEmptyString(deleteSubResourceTagsRequest.SubResourceId, out var valueOfSubResourceId)) urlParam.Add("sub_resource_id", valueOfSubResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/{sub_resource_type}/{sub_resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubResourceTagsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSubResourceTagsResponse>(response);
        }

        public SyncInvoker<DeleteSubResourceTagsResponse> DeleteSubResourceTagsInvoker(DeleteSubResourceTagsRequest deleteSubResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSubResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(deleteSubResourceTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteSubResourceTagsRequest.SubResourceType, out var valueOfSubResourceType)) urlParam.Add("sub_resource_type", valueOfSubResourceType);
            if (StringUtils.TryConvertToNonEmptyString(deleteSubResourceTagsRequest.SubResourceId, out var valueOfSubResourceId)) urlParam.Add("sub_resource_id", valueOfSubResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/{sub_resource_type}/{sub_resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubResourceTagsRequest);
            return new SyncInvoker<DeleteSubResourceTagsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSubResourceTagsResponse>);
        }
        
        /// <summary>
        /// 手动执行镜像同步策略
        ///
        /// 手动执行同步策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExecuteInstanceReplicationPolicyResponse ExecuteInstanceReplicationPolicy(ExecuteInstanceReplicationPolicyRequest executeInstanceReplicationPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeInstanceReplicationPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeInstanceReplicationPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExecuteInstanceReplicationPolicyResponse>(response);
        }

        public SyncInvoker<ExecuteInstanceReplicationPolicyResponse> ExecuteInstanceReplicationPolicyInvoker(ExecuteInstanceReplicationPolicyRequest executeInstanceReplicationPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeInstanceReplicationPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeInstanceReplicationPolicyRequest);
            return new SyncInvoker<ExecuteInstanceReplicationPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteInstanceReplicationPolicyResponse>);
        }
        
        /// <summary>
        /// 执行老化策略
        ///
        /// 执行老化策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExecuteInstanceRetentionPolicyResponse ExecuteInstanceRetentionPolicy(ExecuteInstanceRetentionPolicyRequest executeInstanceRetentionPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeInstanceRetentionPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(executeInstanceRetentionPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(executeInstanceRetentionPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/retention/policies/{policy_id}/executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeInstanceRetentionPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExecuteInstanceRetentionPolicyResponse>(response);
        }

        public SyncInvoker<ExecuteInstanceRetentionPolicyResponse> ExecuteInstanceRetentionPolicyInvoker(ExecuteInstanceRetentionPolicyRequest executeInstanceRetentionPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeInstanceRetentionPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(executeInstanceRetentionPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(executeInstanceRetentionPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/retention/policies/{policy_id}/executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeInstanceRetentionPolicyRequest);
            return new SyncInvoker<ExecuteInstanceRetentionPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteInstanceRetentionPolicyResponse>);
        }
        
        /// <summary>
        /// 手动执行签名策略
        ///
        /// 手动执行签名策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExecuteInstanceSignPolicyResponse ExecuteInstanceSignPolicy(ExecuteInstanceSignPolicyRequest executeInstanceSignPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeInstanceSignPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(executeInstanceSignPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(executeInstanceSignPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/signature/policies/{policy_id}/executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeInstanceSignPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExecuteInstanceSignPolicyResponse>(response);
        }

        public SyncInvoker<ExecuteInstanceSignPolicyResponse> ExecuteInstanceSignPolicyInvoker(ExecuteInstanceSignPolicyRequest executeInstanceSignPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeInstanceSignPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(executeInstanceSignPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(executeInstanceSignPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/signature/policies/{policy_id}/executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeInstanceSignPolicyRequest);
            return new SyncInvoker<ExecuteInstanceSignPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteInstanceSignPolicyResponse>);
        }
        
        /// <summary>
        /// 获取上传下载的相关审计日志列表
        ///
        /// 获取上传下载的相关审计日志列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAuditLogsResponse ListAuditLogs(ListAuditLogsRequest listAuditLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditLogsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/audit-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditLogsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAuditLogsResponse>(response);
        }

        public SyncInvoker<ListAuditLogsResponse> ListAuditLogsInvoker(ListAuditLogsRequest listAuditLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditLogsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/audit-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditLogsRequest);
            return new SyncInvoker<ListAuditLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditLogsResponse>);
        }
        
        /// <summary>
        /// 查询所有域名列表
        ///
        /// 查询当前实例的所有域名
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDomainNamesResponse ListDomainNames(ListDomainNamesRequest listDomainNamesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDomainNamesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/domainname", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainNamesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDomainNamesResponse>(response);
        }

        public SyncInvoker<ListDomainNamesResponse> ListDomainNamesInvoker(ListDomainNamesRequest listDomainNamesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDomainNamesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/domainname", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainNamesRequest);
            return new SyncInvoker<ListDomainNamesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainNamesResponse>);
        }
        
        /// <summary>
        /// 查询特性开关信息
        ///
        /// 查询特性开关信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFeatureGatesResponse ListFeatureGates(ListFeatureGatesRequest listFeatureGatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFeatureGatesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/feature-gates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFeatureGatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFeatureGatesResponse>(response);
        }

        public SyncInvoker<ListFeatureGatesResponse> ListFeatureGatesInvoker(ListFeatureGatesRequest listFeatureGatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFeatureGatesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/feature-gates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFeatureGatesRequest);
            return new SyncInvoker<ListFeatureGatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFeatureGatesResponse>);
        }
        
        /// <summary>
        /// 查询全局特性开关信息
        ///
        /// 查询全局特性开关信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGlobalFeatureGatesResponse ListGlobalFeatureGates(ListGlobalFeatureGatesRequest listGlobalFeatureGatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/feature-gates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalFeatureGatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListGlobalFeatureGatesResponse>(response);
        }

        public SyncInvoker<ListGlobalFeatureGatesResponse> ListGlobalFeatureGatesInvoker(ListGlobalFeatureGatesRequest listGlobalFeatureGatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/feature-gates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalFeatureGatesRequest);
            return new SyncInvoker<ListGlobalFeatureGatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGlobalFeatureGatesResponse>);
        }
        
        /// <summary>
        /// 获取不可变Tag策略列表
        ///
        /// 获取不可变Tag策略列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListImmutableRulesResponse ListImmutableRules(ListImmutableRulesRequest listImmutableRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listImmutableRulesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/immutabletagrules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImmutableRulesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListImmutableRulesResponse>(response);
        }

        public SyncInvoker<ListImmutableRulesResponse> ListImmutableRulesInvoker(ListImmutableRulesRequest listImmutableRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listImmutableRulesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/immutabletagrules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImmutableRulesRequest);
            return new SyncInvoker<ListImmutableRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListImmutableRulesResponse>);
        }
        
        /// <summary>
        /// 查询实例列表
        ///
        /// 查询实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceResponse ListInstance(ListInstanceRequest listInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceResponse>(response);
        }

        public SyncInvoker<ListInstanceResponse> ListInstanceInvoker(ListInstanceRequest listInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceRequest);
            return new SyncInvoker<ListInstanceResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceResponse>);
        }
        
        /// <summary>
        /// 获取制品附件列表
        ///
        /// 获取制品附件列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceAccessoriesResponse ListInstanceAccessories(ListInstanceAccessoriesRequest listInstanceAccessoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceAccessoriesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceAccessoriesRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceAccessoriesRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceAccessoriesRequest.Reference, out var valueOfReference)) urlParam.Add("reference", valueOfReference);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}/artifacts/{reference}/accessories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceAccessoriesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceAccessoriesResponse>(response);
        }

        public SyncInvoker<ListInstanceAccessoriesResponse> ListInstanceAccessoriesInvoker(ListInstanceAccessoriesRequest listInstanceAccessoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceAccessoriesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceAccessoriesRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceAccessoriesRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceAccessoriesRequest.Reference, out var valueOfReference)) urlParam.Add("reference", valueOfReference);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}/artifacts/{reference}/accessories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceAccessoriesRequest);
            return new SyncInvoker<ListInstanceAccessoriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceAccessoriesResponse>);
        }
        
        /// <summary>
        /// 获取仓库实例的所有制品版本列表
        ///
        /// 获取仓库实例的所有制品版本列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceAllArtifactsResponse ListInstanceAllArtifacts(ListInstanceAllArtifactsRequest listInstanceAllArtifactsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceAllArtifactsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/artifacts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceAllArtifactsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceAllArtifactsResponse>(response);
        }

        public SyncInvoker<ListInstanceAllArtifactsResponse> ListInstanceAllArtifactsInvoker(ListInstanceAllArtifactsRequest listInstanceAllArtifactsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceAllArtifactsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/artifacts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceAllArtifactsRequest);
            return new SyncInvoker<ListInstanceAllArtifactsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceAllArtifactsResponse>);
        }
        
        /// <summary>
        /// 获取制品扫描的漏洞信息
        ///
        /// 获取制品扫描的漏洞信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceArtifactVulnerabilitiesResponse ListInstanceArtifactVulnerabilities(ListInstanceArtifactVulnerabilitiesRequest listInstanceArtifactVulnerabilitiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceArtifactVulnerabilitiesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceArtifactVulnerabilitiesRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceArtifactVulnerabilitiesRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceArtifactVulnerabilitiesRequest.Reference, out var valueOfReference)) urlParam.Add("reference", valueOfReference);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}/artifacts/{reference}/vulnerabilities", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceArtifactVulnerabilitiesRequest);
            var response = DoHttpRequestSync("GET", request);
            var listInstanceArtifactVulnerabilitiesResponse = JsonUtils.DeSerializeNull<ListInstanceArtifactVulnerabilitiesResponse>(response);
            listInstanceArtifactVulnerabilitiesResponse.Body = JsonUtils.DeSerializeMap<string, VulnerabilityReports>(response);
            return listInstanceArtifactVulnerabilitiesResponse;
        }

        public SyncInvoker<ListInstanceArtifactVulnerabilitiesResponse> ListInstanceArtifactVulnerabilitiesInvoker(ListInstanceArtifactVulnerabilitiesRequest listInstanceArtifactVulnerabilitiesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceArtifactVulnerabilitiesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceArtifactVulnerabilitiesRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceArtifactVulnerabilitiesRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceArtifactVulnerabilitiesRequest.Reference, out var valueOfReference)) urlParam.Add("reference", valueOfReference);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}/artifacts/{reference}/vulnerabilities", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceArtifactVulnerabilitiesRequest);
            return new SyncInvoker<ListInstanceArtifactVulnerabilitiesResponse>(this, "GET", request, response =>
            {
                var listInstanceArtifactVulnerabilitiesResponse = JsonUtils.DeSerializeNull<ListInstanceArtifactVulnerabilitiesResponse>(response);
                listInstanceArtifactVulnerabilitiesResponse.Body = JsonUtils.DeSerializeMap<string, VulnerabilityReports>(response);
                return listInstanceArtifactVulnerabilitiesResponse;
            });
        }
        
        /// <summary>
        /// 获取制品版本列表
        ///
        /// 获取制品版本列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceArtifactsResponse ListInstanceArtifacts(ListInstanceArtifactsRequest listInstanceArtifactsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceArtifactsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceArtifactsRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceArtifactsRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}/artifacts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceArtifactsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceArtifactsResponse>(response);
        }

        public SyncInvoker<ListInstanceArtifactsResponse> ListInstanceArtifactsInvoker(ListInstanceArtifactsRequest listInstanceArtifactsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceArtifactsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceArtifactsRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceArtifactsRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}/artifacts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceArtifactsRequest);
            return new SyncInvoker<ListInstanceArtifactsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceArtifactsResponse>);
        }
        
        /// <summary>
        /// 获取内网访问列表
        ///
        /// 获取内网访问列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceInternalEndpointsResponse ListInstanceInternalEndpoints(ListInstanceInternalEndpointsRequest listInstanceInternalEndpointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceInternalEndpointsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/internal-endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceInternalEndpointsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceInternalEndpointsResponse>(response);
        }

        public SyncInvoker<ListInstanceInternalEndpointsResponse> ListInstanceInternalEndpointsInvoker(ListInstanceInternalEndpointsRequest listInstanceInternalEndpointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceInternalEndpointsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/internal-endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceInternalEndpointsRequest);
            return new SyncInvoker<ListInstanceInternalEndpointsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceInternalEndpointsResponse>);
        }
        
        /// <summary>
        /// 获取任务列表
        ///
        /// 获取任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceJobsResponse ListInstanceJobs(ListInstanceJobsRequest listInstanceJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceJobsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceJobsResponse>(response);
        }

        public SyncInvoker<ListInstanceJobsResponse> ListInstanceJobsInvoker(ListInstanceJobsRequest listInstanceJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceJobsRequest);
            return new SyncInvoker<ListInstanceJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceJobsResponse>);
        }
        
        /// <summary>
        /// 查询长期访问凭证列表
        ///
        /// 查询长期访问凭证列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceLtCredentialsResponse ListInstanceLtCredentials(ListInstanceLtCredentialsRequest listInstanceLtCredentialsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceLtCredentialsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/long-term-credentials", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceLtCredentialsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceLtCredentialsResponse>(response);
        }

        public SyncInvoker<ListInstanceLtCredentialsResponse> ListInstanceLtCredentialsInvoker(ListInstanceLtCredentialsRequest listInstanceLtCredentialsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceLtCredentialsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/long-term-credentials", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceLtCredentialsRequest);
            return new SyncInvoker<ListInstanceLtCredentialsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceLtCredentialsResponse>);
        }
        
        /// <summary>
        /// 获取命名空间列表
        ///
        /// 获取命名空间列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceNamespacesResponse ListInstanceNamespaces(ListInstanceNamespacesRequest listInstanceNamespacesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceNamespacesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceNamespacesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceNamespacesResponse>(response);
        }

        public SyncInvoker<ListInstanceNamespacesResponse> ListInstanceNamespacesInvoker(ListInstanceNamespacesRequest listInstanceNamespacesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceNamespacesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceNamespacesRequest);
            return new SyncInvoker<ListInstanceNamespacesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceNamespacesResponse>);
        }
        
        /// <summary>
        /// 查询项目下所有实例标签
        ///
        /// 查询项目下所有实例标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceProjectTagsResponse ListInstanceProjectTags(ListInstanceProjectTagsRequest listInstanceProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceProjectTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceProjectTagsResponse>(response);
        }

        public SyncInvoker<ListInstanceProjectTagsResponse> ListInstanceProjectTagsInvoker(ListInstanceProjectTagsRequest listInstanceProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceProjectTagsRequest);
            return new SyncInvoker<ListInstanceProjectTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceProjectTagsResponse>);
        }
        
        /// <summary>
        /// 获取镜像同步的目标仓库列表
        ///
        /// 获取镜像同步的目标仓库列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceRegistriesResponse ListInstanceRegistries(ListInstanceRegistriesRequest listInstanceRegistriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRegistriesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/registries", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceRegistriesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceRegistriesResponse>(response);
        }

        public SyncInvoker<ListInstanceRegistriesResponse> ListInstanceRegistriesInvoker(ListInstanceRegistriesRequest listInstanceRegistriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRegistriesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/registries", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceRegistriesRequest);
            return new SyncInvoker<ListInstanceRegistriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceRegistriesResponse>);
        }
        
        /// <summary>
        /// 获取镜像同步策略列表
        ///
        /// 获取镜像同步策略列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceReplicationPoliciesResponse ListInstanceReplicationPolicies(ListInstanceReplicationPoliciesRequest listInstanceReplicationPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceReplicationPoliciesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceReplicationPoliciesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceReplicationPoliciesResponse>(response);
        }

        public SyncInvoker<ListInstanceReplicationPoliciesResponse> ListInstanceReplicationPoliciesInvoker(ListInstanceReplicationPoliciesRequest listInstanceReplicationPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceReplicationPoliciesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceReplicationPoliciesRequest);
            return new SyncInvoker<ListInstanceReplicationPoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceReplicationPoliciesResponse>);
        }
        
        /// <summary>
        /// 获取镜像同步策略执行任务的镜像版本列表
        ///
        /// 获取镜像同步策略执行任务的镜像版本列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceReplicationPolicyExecSubTasksResponse ListInstanceReplicationPolicyExecSubTasks(ListInstanceReplicationPolicyExecSubTasksRequest listInstanceReplicationPolicyExecSubTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceReplicationPolicyExecSubTasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceReplicationPolicyExecSubTasksRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceReplicationPolicyExecSubTasksRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/executions/{execution_id}/tasks/{task_id}/subtasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceReplicationPolicyExecSubTasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceReplicationPolicyExecSubTasksResponse>(response);
        }

        public SyncInvoker<ListInstanceReplicationPolicyExecSubTasksResponse> ListInstanceReplicationPolicyExecSubTasksInvoker(ListInstanceReplicationPolicyExecSubTasksRequest listInstanceReplicationPolicyExecSubTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceReplicationPolicyExecSubTasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceReplicationPolicyExecSubTasksRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceReplicationPolicyExecSubTasksRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/executions/{execution_id}/tasks/{task_id}/subtasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceReplicationPolicyExecSubTasksRequest);
            return new SyncInvoker<ListInstanceReplicationPolicyExecSubTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceReplicationPolicyExecSubTasksResponse>);
        }
        
        /// <summary>
        /// 获取镜像同步策略执行任务的镜像列表
        ///
        /// 获取镜像同步策略执行任务的镜像列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceReplicationPolicyExecTasksResponse ListInstanceReplicationPolicyExecTasks(ListInstanceReplicationPolicyExecTasksRequest listInstanceReplicationPolicyExecTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceReplicationPolicyExecTasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceReplicationPolicyExecTasksRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/executions/{execution_id}/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceReplicationPolicyExecTasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceReplicationPolicyExecTasksResponse>(response);
        }

        public SyncInvoker<ListInstanceReplicationPolicyExecTasksResponse> ListInstanceReplicationPolicyExecTasksInvoker(ListInstanceReplicationPolicyExecTasksRequest listInstanceReplicationPolicyExecTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceReplicationPolicyExecTasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceReplicationPolicyExecTasksRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/executions/{execution_id}/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceReplicationPolicyExecTasksRequest);
            return new SyncInvoker<ListInstanceReplicationPolicyExecTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceReplicationPolicyExecTasksResponse>);
        }
        
        /// <summary>
        /// 获取镜像同步策略执行记录列表
        ///
        /// 获取镜像同步策略执行记录列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceReplicationPolicyExecutionsResponse ListInstanceReplicationPolicyExecutions(ListInstanceReplicationPolicyExecutionsRequest listInstanceReplicationPolicyExecutionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceReplicationPolicyExecutionsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceReplicationPolicyExecutionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceReplicationPolicyExecutionsResponse>(response);
        }

        public SyncInvoker<ListInstanceReplicationPolicyExecutionsResponse> ListInstanceReplicationPolicyExecutionsInvoker(ListInstanceReplicationPolicyExecutionsRequest listInstanceReplicationPolicyExecutionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceReplicationPolicyExecutionsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceReplicationPolicyExecutionsRequest);
            return new SyncInvoker<ListInstanceReplicationPolicyExecutionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceReplicationPolicyExecutionsResponse>);
        }
        
        /// <summary>
        /// 获取制品仓库列表
        ///
        /// 获取制品仓库列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceRepositoriesResponse ListInstanceRepositories(ListInstanceRepositoriesRequest listInstanceRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRepositoriesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceRepositoriesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceRepositoriesResponse>(response);
        }

        public SyncInvoker<ListInstanceRepositoriesResponse> ListInstanceRepositoriesInvoker(ListInstanceRepositoriesRequest listInstanceRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRepositoriesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceRepositoriesRequest);
            return new SyncInvoker<ListInstanceRepositoriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceRepositoriesResponse>);
        }
        
        /// <summary>
        /// 按照标签检索资源列表
        ///
        /// 按照标签检索资源列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceResourceInstancesResponse ListInstanceResourceInstances(ListInstanceResourceInstancesRequest listInstanceResourceInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceResourceInstancesRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceResourceInstancesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListInstanceResourceInstancesResponse>(response);
        }

        public SyncInvoker<ListInstanceResourceInstancesResponse> ListInstanceResourceInstancesInvoker(ListInstanceResourceInstancesRequest listInstanceResourceInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceResourceInstancesRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceResourceInstancesRequest);
            return new SyncInvoker<ListInstanceResourceInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListInstanceResourceInstancesResponse>);
        }
        
        /// <summary>
        /// 查询资源标签
        ///
        /// 查询资源标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceResourceTagsResponse ListInstanceResourceTags(ListInstanceResourceTagsRequest listInstanceResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceResourceTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceResourceTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceResourceTagsResponse>(response);
        }

        public SyncInvoker<ListInstanceResourceTagsResponse> ListInstanceResourceTagsInvoker(ListInstanceResourceTagsRequest listInstanceResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceResourceTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceResourceTagsRequest);
            return new SyncInvoker<ListInstanceResourceTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceResourceTagsResponse>);
        }
        
        /// <summary>
        /// 获取老化策略列表
        ///
        /// 获取老化策略列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceRetentionPoliciesResponse ListInstanceRetentionPolicies(ListInstanceRetentionPoliciesRequest listInstanceRetentionPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPoliciesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/retention/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceRetentionPoliciesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceRetentionPoliciesResponse>(response);
        }

        public SyncInvoker<ListInstanceRetentionPoliciesResponse> ListInstanceRetentionPoliciesInvoker(ListInstanceRetentionPoliciesRequest listInstanceRetentionPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPoliciesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/retention/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceRetentionPoliciesRequest);
            return new SyncInvoker<ListInstanceRetentionPoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceRetentionPoliciesResponse>);
        }
        
        /// <summary>
        /// 获取老化策略执行任务的镜像版本列表
        ///
        /// 获取老化策略执行任务的镜像版本列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceRetentionPolicyExecSubTasksResponse ListInstanceRetentionPolicyExecSubTasks(ListInstanceRetentionPolicyExecSubTasksRequest listInstanceRetentionPolicyExecSubTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecSubTasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecSubTasksRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecSubTasksRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecSubTasksRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecSubTasksRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/retention/policies/{policy_id}/executions/{execution_id}/tasks/{task_id}/subtasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceRetentionPolicyExecSubTasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceRetentionPolicyExecSubTasksResponse>(response);
        }

        public SyncInvoker<ListInstanceRetentionPolicyExecSubTasksResponse> ListInstanceRetentionPolicyExecSubTasksInvoker(ListInstanceRetentionPolicyExecSubTasksRequest listInstanceRetentionPolicyExecSubTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecSubTasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecSubTasksRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecSubTasksRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecSubTasksRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecSubTasksRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/retention/policies/{policy_id}/executions/{execution_id}/tasks/{task_id}/subtasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceRetentionPolicyExecSubTasksRequest);
            return new SyncInvoker<ListInstanceRetentionPolicyExecSubTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceRetentionPolicyExecSubTasksResponse>);
        }
        
        /// <summary>
        /// 获取老化策略执行任务的镜像列表
        ///
        /// 获取老化策略执行任务的镜像列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceRetentionPolicyExecTasksResponse ListInstanceRetentionPolicyExecTasks(ListInstanceRetentionPolicyExecTasksRequest listInstanceRetentionPolicyExecTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecTasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecTasksRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecTasksRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecTasksRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/retention/policies/{policy_id}/executions/{execution_id}/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceRetentionPolicyExecTasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceRetentionPolicyExecTasksResponse>(response);
        }

        public SyncInvoker<ListInstanceRetentionPolicyExecTasksResponse> ListInstanceRetentionPolicyExecTasksInvoker(ListInstanceRetentionPolicyExecTasksRequest listInstanceRetentionPolicyExecTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecTasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecTasksRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecTasksRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecTasksRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/retention/policies/{policy_id}/executions/{execution_id}/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceRetentionPolicyExecTasksRequest);
            return new SyncInvoker<ListInstanceRetentionPolicyExecTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceRetentionPolicyExecTasksResponse>);
        }
        
        /// <summary>
        /// 获取老化策略执行记录列表
        ///
        /// 获取老化策略执行记录列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceRetentionPolicyExecutionsResponse ListInstanceRetentionPolicyExecutions(ListInstanceRetentionPolicyExecutionsRequest listInstanceRetentionPolicyExecutionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecutionsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecutionsRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecutionsRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/retention/policies/{policy_id}/executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceRetentionPolicyExecutionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceRetentionPolicyExecutionsResponse>(response);
        }

        public SyncInvoker<ListInstanceRetentionPolicyExecutionsResponse> ListInstanceRetentionPolicyExecutionsInvoker(ListInstanceRetentionPolicyExecutionsRequest listInstanceRetentionPolicyExecutionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecutionsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecutionsRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecutionsRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/retention/policies/{policy_id}/executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceRetentionPolicyExecutionsRequest);
            return new SyncInvoker<ListInstanceRetentionPolicyExecutionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceRetentionPolicyExecutionsResponse>);
        }
        
        /// <summary>
        /// 获取签名策略列表
        ///
        /// 获取签名策略列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceSignPoliciesResponse ListInstanceSignPolicies(ListInstanceSignPoliciesRequest listInstanceSignPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignPoliciesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/signature/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceSignPoliciesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceSignPoliciesResponse>(response);
        }

        public SyncInvoker<ListInstanceSignPoliciesResponse> ListInstanceSignPoliciesInvoker(ListInstanceSignPoliciesRequest listInstanceSignPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignPoliciesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/signature/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceSignPoliciesRequest);
            return new SyncInvoker<ListInstanceSignPoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceSignPoliciesResponse>);
        }
        
        /// <summary>
        /// 获取签名执行记录任务的镜像列表
        ///
        /// 获取签名执行记录任务的镜像列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceSignPolicyExecTasksResponse ListInstanceSignPolicyExecTasks(ListInstanceSignPolicyExecTasksRequest listInstanceSignPolicyExecTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignPolicyExecTasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignPolicyExecTasksRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignPolicyExecTasksRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignPolicyExecTasksRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/signature/policies/{policy_id}/executions/{execution_id}/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceSignPolicyExecTasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceSignPolicyExecTasksResponse>(response);
        }

        public SyncInvoker<ListInstanceSignPolicyExecTasksResponse> ListInstanceSignPolicyExecTasksInvoker(ListInstanceSignPolicyExecTasksRequest listInstanceSignPolicyExecTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignPolicyExecTasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignPolicyExecTasksRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignPolicyExecTasksRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignPolicyExecTasksRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/signature/policies/{policy_id}/executions/{execution_id}/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceSignPolicyExecTasksRequest);
            return new SyncInvoker<ListInstanceSignPolicyExecTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceSignPolicyExecTasksResponse>);
        }
        
        /// <summary>
        /// 获取签名执行记录列表
        ///
        /// 获取签名执行记录列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceSignPolicyExecutionsResponse ListInstanceSignPolicyExecutions(ListInstanceSignPolicyExecutionsRequest listInstanceSignPolicyExecutionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignPolicyExecutionsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignPolicyExecutionsRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignPolicyExecutionsRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/signature/policies/{policy_id}/executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceSignPolicyExecutionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceSignPolicyExecutionsResponse>(response);
        }

        public SyncInvoker<ListInstanceSignPolicyExecutionsResponse> ListInstanceSignPolicyExecutionsInvoker(ListInstanceSignPolicyExecutionsRequest listInstanceSignPolicyExecutionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignPolicyExecutionsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignPolicyExecutionsRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignPolicyExecutionsRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/signature/policies/{policy_id}/executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceSignPolicyExecutionsRequest);
            return new SyncInvoker<ListInstanceSignPolicyExecutionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceSignPolicyExecutionsResponse>);
        }
        
        /// <summary>
        /// 获取签名策略执行任务的镜像版本列表
        ///
        /// 获取签名策略执行任务的镜像版本列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceSignatureExecutionSubtasksResponse ListInstanceSignatureExecutionSubtasks(ListInstanceSignatureExecutionSubtasksRequest listInstanceSignatureExecutionSubtasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignatureExecutionSubtasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignatureExecutionSubtasksRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignatureExecutionSubtasksRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignatureExecutionSubtasksRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignatureExecutionSubtasksRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/signature/policies/{policy_id}/executions/{execution_id}/tasks/{task_id}/subtasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceSignatureExecutionSubtasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceSignatureExecutionSubtasksResponse>(response);
        }

        public SyncInvoker<ListInstanceSignatureExecutionSubtasksResponse> ListInstanceSignatureExecutionSubtasksInvoker(ListInstanceSignatureExecutionSubtasksRequest listInstanceSignatureExecutionSubtasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignatureExecutionSubtasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignatureExecutionSubtasksRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignatureExecutionSubtasksRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignatureExecutionSubtasksRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignatureExecutionSubtasksRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/signature/policies/{policy_id}/executions/{execution_id}/tasks/{task_id}/subtasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceSignatureExecutionSubtasksRequest);
            return new SyncInvoker<ListInstanceSignatureExecutionSubtasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceSignatureExecutionSubtasksResponse>);
        }
        
        /// <summary>
        /// 获取实例统计数据
        ///
        /// 获取实例统计数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceStatisticsResponse ListInstanceStatistics(ListInstanceStatisticsRequest listInstanceStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceStatisticsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceStatisticsResponse>(response);
        }

        public SyncInvoker<ListInstanceStatisticsResponse> ListInstanceStatisticsInvoker(ListInstanceStatisticsRequest listInstanceStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceStatisticsRequest);
            return new SyncInvoker<ListInstanceStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceStatisticsResponse>);
        }
        
        /// <summary>
        /// 获取制品仓库的Tag列表
        ///
        /// 获取制品仓库的Tag列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceTagsResponse ListInstanceTags(ListInstanceTagsRequest listInstanceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceTagsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceTagsRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceTagsRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v2/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceTagsResponse>(response);
        }

        public SyncInvoker<ListInstanceTagsResponse> ListInstanceTagsInvoker(ListInstanceTagsRequest listInstanceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceTagsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceTagsRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceTagsRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v2/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceTagsRequest);
            return new SyncInvoker<ListInstanceTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceTagsResponse>);
        }
        
        /// <summary>
        /// 获取触发器执行任务列表
        ///
        /// 获取触发器执行任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceWebhookJobsResponse ListInstanceWebhookJobs(ListInstanceWebhookJobsRequest listInstanceWebhookJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceWebhookJobsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceWebhookJobsRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceWebhookJobsRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/webhook/policies/{policy_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceWebhookJobsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceWebhookJobsResponse>(response);
        }

        public SyncInvoker<ListInstanceWebhookJobsResponse> ListInstanceWebhookJobsInvoker(ListInstanceWebhookJobsRequest listInstanceWebhookJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceWebhookJobsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceWebhookJobsRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceWebhookJobsRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/webhook/policies/{policy_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceWebhookJobsRequest);
            return new SyncInvoker<ListInstanceWebhookJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceWebhookJobsResponse>);
        }
        
        /// <summary>
        /// 获取触发器列表
        ///
        /// 获取触发器列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceWebhooksResponse ListInstanceWebhooks(ListInstanceWebhooksRequest listInstanceWebhooksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceWebhooksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/webhook/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceWebhooksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceWebhooksResponse>(response);
        }

        public SyncInvoker<ListInstanceWebhooksResponse> ListInstanceWebhooksInvoker(ListInstanceWebhooksRequest listInstanceWebhooksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceWebhooksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/webhook/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceWebhooksRequest);
            return new SyncInvoker<ListInstanceWebhooksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceWebhooksResponse>);
        }
        
        /// <summary>
        /// 获取命名空间下所有制品仓库列表
        ///
        /// 获取命名空间下所有制品仓库列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListNamespaceRepositoriesResponse ListNamespaceRepositories(ListNamespaceRepositoriesRequest listNamespaceRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listNamespaceRepositoriesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listNamespaceRepositoriesRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNamespaceRepositoriesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListNamespaceRepositoriesResponse>(response);
        }

        public SyncInvoker<ListNamespaceRepositoriesResponse> ListNamespaceRepositoriesInvoker(ListNamespaceRepositoriesRequest listNamespaceRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listNamespaceRepositoriesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listNamespaceRepositoriesRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNamespaceRepositoriesRequest);
            return new SyncInvoker<ListNamespaceRepositoriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNamespaceRepositoriesResponse>);
        }
        
        /// <summary>
        /// 查询实例下所有命名空间标签
        ///
        /// 查询实例下所有命名空间标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListNamespaceTagsResponse ListNamespaceTags(ListNamespaceTagsRequest listNamespaceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listNamespaceTagsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces-tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNamespaceTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListNamespaceTagsResponse>(response);
        }

        public SyncInvoker<ListNamespaceTagsResponse> ListNamespaceTagsInvoker(ListNamespaceTagsRequest listNamespaceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listNamespaceTagsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces-tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNamespaceTagsRequest);
            return new SyncInvoker<ListNamespaceTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNamespaceTagsResponse>);
        }
        
        /// <summary>
        /// 按照标签检索子资源列表
        ///
        /// 按照标签检索子资源列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSubResourceInstancesResponse ListSubResourceInstances(ListSubResourceInstancesRequest listSubResourceInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSubResourceInstancesRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(listSubResourceInstancesRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            if (StringUtils.TryConvertToNonEmptyString(listSubResourceInstancesRequest.SubResourceType, out var valueOfSubResourceType)) urlParam.Add("sub_resource_type", valueOfSubResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/{sub_resource_type}/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubResourceInstancesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListSubResourceInstancesResponse>(response);
        }

        public SyncInvoker<ListSubResourceInstancesResponse> ListSubResourceInstancesInvoker(ListSubResourceInstancesRequest listSubResourceInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSubResourceInstancesRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(listSubResourceInstancesRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            if (StringUtils.TryConvertToNonEmptyString(listSubResourceInstancesRequest.SubResourceType, out var valueOfSubResourceType)) urlParam.Add("sub_resource_type", valueOfSubResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/{sub_resource_type}/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubResourceInstancesRequest);
            return new SyncInvoker<ListSubResourceInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListSubResourceInstancesResponse>);
        }
        
        /// <summary>
        /// 查询子资源标签
        ///
        /// 查询子资源标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSubResourceTagsResponse ListSubResourceTags(ListSubResourceTagsRequest listSubResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSubResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(listSubResourceTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            if (StringUtils.TryConvertToNonEmptyString(listSubResourceTagsRequest.SubResourceType, out var valueOfSubResourceType)) urlParam.Add("sub_resource_type", valueOfSubResourceType);
            if (StringUtils.TryConvertToNonEmptyString(listSubResourceTagsRequest.SubResourceId, out var valueOfSubResourceId)) urlParam.Add("sub_resource_id", valueOfSubResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/{sub_resource_type}/{sub_resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubResourceTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSubResourceTagsResponse>(response);
        }

        public SyncInvoker<ListSubResourceTagsResponse> ListSubResourceTagsInvoker(ListSubResourceTagsRequest listSubResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSubResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(listSubResourceTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            if (StringUtils.TryConvertToNonEmptyString(listSubResourceTagsRequest.SubResourceType, out var valueOfSubResourceType)) urlParam.Add("sub_resource_type", valueOfSubResourceType);
            if (StringUtils.TryConvertToNonEmptyString(listSubResourceTagsRequest.SubResourceId, out var valueOfSubResourceId)) urlParam.Add("sub_resource_id", valueOfSubResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/{sub_resource_type}/{sub_resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubResourceTagsRequest);
            return new SyncInvoker<ListSubResourceTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSubResourceTagsResponse>);
        }
        
        /// <summary>
        /// 获取实例详情
        ///
        /// 获取实例详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceResponse ShowInstance(ShowInstanceRequest showInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceResponse>(response);
        }

        public SyncInvoker<ShowInstanceResponse> ShowInstanceInvoker(ShowInstanceRequest showInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRequest);
            return new SyncInvoker<ShowInstanceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceResponse>);
        }
        
        /// <summary>
        /// 获取制品版本详情
        ///
        /// 获取制品版本详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceArtifactResponse ShowInstanceArtifact(ShowInstanceArtifactRequest showInstanceArtifactRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceArtifactRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceArtifactRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceArtifactRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceArtifactRequest.Reference, out var valueOfReference)) urlParam.Add("reference", valueOfReference);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}/artifacts/{reference}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceArtifactRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceArtifactResponse>(response);
        }

        public SyncInvoker<ShowInstanceArtifactResponse> ShowInstanceArtifactInvoker(ShowInstanceArtifactRequest showInstanceArtifactRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceArtifactRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceArtifactRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceArtifactRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceArtifactRequest.Reference, out var valueOfReference)) urlParam.Add("reference", valueOfReference);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}/artifacts/{reference}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceArtifactRequest);
            return new SyncInvoker<ShowInstanceArtifactResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceArtifactResponse>);
        }
        
        /// <summary>
        /// 获取制品附加信息
        ///
        /// 获取制品附加信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceArtifactAdditionResponse ShowInstanceArtifactAddition(ShowInstanceArtifactAdditionRequest showInstanceArtifactAdditionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceArtifactAdditionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceArtifactAdditionRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceArtifactAdditionRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceArtifactAdditionRequest.Reference, out var valueOfReference)) urlParam.Add("reference", valueOfReference);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceArtifactAdditionRequest.Addition, out var valueOfAddition)) urlParam.Add("addition", valueOfAddition);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}/artifacts/{reference}/additions/{addition}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceArtifactAdditionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceArtifactAdditionResponse>(response);
        }

        public SyncInvoker<ShowInstanceArtifactAdditionResponse> ShowInstanceArtifactAdditionInvoker(ShowInstanceArtifactAdditionRequest showInstanceArtifactAdditionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceArtifactAdditionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceArtifactAdditionRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceArtifactAdditionRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceArtifactAdditionRequest.Reference, out var valueOfReference)) urlParam.Add("reference", valueOfReference);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceArtifactAdditionRequest.Addition, out var valueOfAddition)) urlParam.Add("addition", valueOfAddition);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}/artifacts/{reference}/additions/{addition}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceArtifactAdditionRequest);
            return new SyncInvoker<ShowInstanceArtifactAdditionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceArtifactAdditionResponse>);
        }
        
        /// <summary>
        /// 查看实例配置
        ///
        /// 查看实例配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceConfigurationResponse ShowInstanceConfiguration(ShowInstanceConfigurationRequest showInstanceConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceConfigurationRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceConfigurationResponse>(response);
        }

        public SyncInvoker<ShowInstanceConfigurationResponse> ShowInstanceConfigurationInvoker(ShowInstanceConfigurationRequest showInstanceConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceConfigurationRequest);
            return new SyncInvoker<ShowInstanceConfigurationResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceConfigurationResponse>);
        }
        
        /// <summary>
        /// 获取公网访问信息
        ///
        /// 获取公网访问信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceEndpointPolicyResponse ShowInstanceEndpointPolicy(ShowInstanceEndpointPolicyRequest showInstanceEndpointPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceEndpointPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/endpoint-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceEndpointPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceEndpointPolicyResponse>(response);
        }

        public SyncInvoker<ShowInstanceEndpointPolicyResponse> ShowInstanceEndpointPolicyInvoker(ShowInstanceEndpointPolicyRequest showInstanceEndpointPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceEndpointPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/endpoint-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceEndpointPolicyRequest);
            return new SyncInvoker<ShowInstanceEndpointPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceEndpointPolicyResponse>);
        }
        
        /// <summary>
        /// 查询内网访问详情
        ///
        /// 查询内网访问详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceInternalEndpointResponse ShowInstanceInternalEndpoint(ShowInstanceInternalEndpointRequest showInstanceInternalEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceInternalEndpointRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceInternalEndpointRequest.InternalEndpointsId, out var valueOfInternalEndpointsId)) urlParam.Add("internal_endpoints_id", valueOfInternalEndpointsId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/internal-endpoints/{internal_endpoints_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceInternalEndpointRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceInternalEndpointResponse>(response);
        }

        public SyncInvoker<ShowInstanceInternalEndpointResponse> ShowInstanceInternalEndpointInvoker(ShowInstanceInternalEndpointRequest showInstanceInternalEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceInternalEndpointRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceInternalEndpointRequest.InternalEndpointsId, out var valueOfInternalEndpointsId)) urlParam.Add("internal_endpoints_id", valueOfInternalEndpointsId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/internal-endpoints/{internal_endpoints_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceInternalEndpointRequest);
            return new SyncInvoker<ShowInstanceInternalEndpointResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceInternalEndpointResponse>);
        }
        
        /// <summary>
        /// 获取任务详情
        ///
        /// 获取任务详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceJobResponse ShowInstanceJob(ShowInstanceJobRequest showInstanceJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceJobRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceJobResponse>(response);
        }

        public SyncInvoker<ShowInstanceJobResponse> ShowInstanceJobInvoker(ShowInstanceJobRequest showInstanceJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceJobRequest);
            return new SyncInvoker<ShowInstanceJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceJobResponse>);
        }
        
        /// <summary>
        /// 获取命名空间详情
        ///
        /// 获取命名空间详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceNamespaceResponse ShowInstanceNamespace(ShowInstanceNamespaceRequest showInstanceNamespaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceNamespaceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceNamespaceRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceNamespaceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceNamespaceResponse>(response);
        }

        public SyncInvoker<ShowInstanceNamespaceResponse> ShowInstanceNamespaceInvoker(ShowInstanceNamespaceRequest showInstanceNamespaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceNamespaceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceNamespaceRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceNamespaceRequest);
            return new SyncInvoker<ShowInstanceNamespaceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceNamespaceResponse>);
        }
        
        /// <summary>
        /// 获取镜像同步的目标仓库详情
        ///
        /// 获取镜像同步的目标仓库详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceRegistryResponse ShowInstanceRegistry(ShowInstanceRegistryRequest showInstanceRegistryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRegistryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRegistryRequest.RegistryId, out var valueOfRegistryId)) urlParam.Add("registry_id", valueOfRegistryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/registries/{registry_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRegistryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceRegistryResponse>(response);
        }

        public SyncInvoker<ShowInstanceRegistryResponse> ShowInstanceRegistryInvoker(ShowInstanceRegistryRequest showInstanceRegistryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRegistryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRegistryRequest.RegistryId, out var valueOfRegistryId)) urlParam.Add("registry_id", valueOfRegistryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/registries/{registry_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRegistryRequest);
            return new SyncInvoker<ShowInstanceRegistryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceRegistryResponse>);
        }
        
        /// <summary>
        /// 获取镜像同步策略详情
        ///
        /// 获取镜像同步策略详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceReplicationPolicyResponse ShowInstanceReplicationPolicy(ShowInstanceReplicationPolicyRequest showInstanceReplicationPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceReplicationPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceReplicationPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceReplicationPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceReplicationPolicyResponse>(response);
        }

        public SyncInvoker<ShowInstanceReplicationPolicyResponse> ShowInstanceReplicationPolicyInvoker(ShowInstanceReplicationPolicyRequest showInstanceReplicationPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceReplicationPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceReplicationPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceReplicationPolicyRequest);
            return new SyncInvoker<ShowInstanceReplicationPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceReplicationPolicyResponse>);
        }
        
        /// <summary>
        /// 获取制品仓库详情
        ///
        /// 获取制品仓库详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceRepositoryResponse ShowInstanceRepository(ShowInstanceRepositoryRequest showInstanceRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRepositoryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRepositoryRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRepositoryRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRepositoryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceRepositoryResponse>(response);
        }

        public SyncInvoker<ShowInstanceRepositoryResponse> ShowInstanceRepositoryInvoker(ShowInstanceRepositoryRequest showInstanceRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRepositoryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRepositoryRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRepositoryRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRepositoryRequest);
            return new SyncInvoker<ShowInstanceRepositoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceRepositoryResponse>);
        }
        
        /// <summary>
        /// 按照标签检索资源数量
        ///
        /// 按照标签检索资源数量
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceResourceInstancesCountResponse ShowInstanceResourceInstancesCount(ShowInstanceResourceInstancesCountRequest showInstanceResourceInstancesCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceResourceInstancesCountRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceResourceInstancesCountRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowInstanceResourceInstancesCountResponse>(response);
        }

        public SyncInvoker<ShowInstanceResourceInstancesCountResponse> ShowInstanceResourceInstancesCountInvoker(ShowInstanceResourceInstancesCountRequest showInstanceResourceInstancesCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceResourceInstancesCountRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceResourceInstancesCountRequest);
            return new SyncInvoker<ShowInstanceResourceInstancesCountResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowInstanceResourceInstancesCountResponse>);
        }
        
        /// <summary>
        /// 获取老化策略详情
        ///
        /// 获取老化策略详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceRetentionPolicyResponse ShowInstanceRetentionPolicy(ShowInstanceRetentionPolicyRequest showInstanceRetentionPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRetentionPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRetentionPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRetentionPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/retention/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRetentionPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceRetentionPolicyResponse>(response);
        }

        public SyncInvoker<ShowInstanceRetentionPolicyResponse> ShowInstanceRetentionPolicyInvoker(ShowInstanceRetentionPolicyRequest showInstanceRetentionPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRetentionPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRetentionPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRetentionPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/retention/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRetentionPolicyRequest);
            return new SyncInvoker<ShowInstanceRetentionPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceRetentionPolicyResponse>);
        }
        
        /// <summary>
        /// 获取签名策略详情
        ///
        /// 获取签名策略详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceSignPolicyResponse ShowInstanceSignPolicy(ShowInstanceSignPolicyRequest showInstanceSignPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceSignPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceSignPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceSignPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/signature/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceSignPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceSignPolicyResponse>(response);
        }

        public SyncInvoker<ShowInstanceSignPolicyResponse> ShowInstanceSignPolicyInvoker(ShowInstanceSignPolicyRequest showInstanceSignPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceSignPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceSignPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceSignPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/signature/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceSignPolicyRequest);
            return new SyncInvoker<ShowInstanceSignPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceSignPolicyResponse>);
        }
        
        /// <summary>
        /// 获取触发器详情
        ///
        /// 获取触发器详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceWebhookResponse ShowInstanceWebhook(ShowInstanceWebhookRequest showInstanceWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceWebhookRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceWebhookRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceWebhookRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/webhook/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceWebhookRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceWebhookResponse>(response);
        }

        public SyncInvoker<ShowInstanceWebhookResponse> ShowInstanceWebhookInvoker(ShowInstanceWebhookRequest showInstanceWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceWebhookRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceWebhookRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceWebhookRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/webhook/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceWebhookRequest);
            return new SyncInvoker<ShowInstanceWebhookResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceWebhookResponse>);
        }
        
        /// <summary>
        /// 按照标签检索子资源数量
        ///
        /// 按照标签检索子资源数量
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSubResourceInstancesCountResponse ShowSubResourceInstancesCount(ShowSubResourceInstancesCountRequest showSubResourceInstancesCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSubResourceInstancesCountRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(showSubResourceInstancesCountRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            if (StringUtils.TryConvertToNonEmptyString(showSubResourceInstancesCountRequest.SubResourceType, out var valueOfSubResourceType)) urlParam.Add("sub_resource_type", valueOfSubResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/{sub_resource_type}/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubResourceInstancesCountRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowSubResourceInstancesCountResponse>(response);
        }

        public SyncInvoker<ShowSubResourceInstancesCountResponse> ShowSubResourceInstancesCountInvoker(ShowSubResourceInstancesCountRequest showSubResourceInstancesCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSubResourceInstancesCountRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(showSubResourceInstancesCountRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            if (StringUtils.TryConvertToNonEmptyString(showSubResourceInstancesCountRequest.SubResourceType, out var valueOfSubResourceType)) urlParam.Add("sub_resource_type", valueOfSubResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/{sub_resource_type}/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubResourceInstancesCountRequest);
            return new SyncInvoker<ShowSubResourceInstancesCountResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowSubResourceInstancesCountResponse>);
        }
        
        /// <summary>
        /// 手动启动制品扫描
        ///
        /// 手动启动制品扫描
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StartManualScanningResponse StartManualScanning(StartManualScanningRequest startManualScanningRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startManualScanningRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(startManualScanningRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(startManualScanningRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            if (StringUtils.TryConvertToNonEmptyString(startManualScanningRequest.Reference, out var valueOfReference)) urlParam.Add("reference", valueOfReference);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}/artifacts/{reference}/scan", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startManualScanningRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<StartManualScanningResponse>(response);
        }

        public SyncInvoker<StartManualScanningResponse> StartManualScanningInvoker(StartManualScanningRequest startManualScanningRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startManualScanningRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(startManualScanningRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(startManualScanningRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            if (StringUtils.TryConvertToNonEmptyString(startManualScanningRequest.Reference, out var valueOfReference)) urlParam.Add("reference", valueOfReference);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}/artifacts/{reference}/scan", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startManualScanningRequest);
            return new SyncInvoker<StartManualScanningResponse>(this, "POST", request, JsonUtils.DeSerializeNull<StartManualScanningResponse>);
        }
        
        /// <summary>
        /// 停止镜像同步任务
        ///
        /// 停止镜像同步任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StopInstanceReplicationPolicyExecutionResponse StopInstanceReplicationPolicyExecution(StopInstanceReplicationPolicyExecutionRequest stopInstanceReplicationPolicyExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopInstanceReplicationPolicyExecutionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(stopInstanceReplicationPolicyExecutionRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/executions/{execution_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopInstanceReplicationPolicyExecutionRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<StopInstanceReplicationPolicyExecutionResponse>(response);
        }

        public SyncInvoker<StopInstanceReplicationPolicyExecutionResponse> StopInstanceReplicationPolicyExecutionInvoker(StopInstanceReplicationPolicyExecutionRequest stopInstanceReplicationPolicyExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopInstanceReplicationPolicyExecutionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(stopInstanceReplicationPolicyExecutionRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/executions/{execution_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopInstanceReplicationPolicyExecutionRequest);
            return new SyncInvoker<StopInstanceReplicationPolicyExecutionResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<StopInstanceReplicationPolicyExecutionResponse>);
        }
        
        /// <summary>
        /// 更新域名
        ///
        /// 更新域名
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDomainNameResponse UpdateDomainName(UpdateDomainNameRequest updateDomainNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDomainNameRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateDomainNameRequest.DomainnameId, out var valueOfDomainnameId)) urlParam.Add("domainname_id", valueOfDomainnameId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/domainname/{domainname_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainNameRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDomainNameResponse>(response);
        }

        public SyncInvoker<UpdateDomainNameResponse> UpdateDomainNameInvoker(UpdateDomainNameRequest updateDomainNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDomainNameRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateDomainNameRequest.DomainnameId, out var valueOfDomainnameId)) urlParam.Add("domainname_id", valueOfDomainnameId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/domainname/{domainname_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainNameRequest);
            return new SyncInvoker<UpdateDomainNameResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDomainNameResponse>);
        }
        
        /// <summary>
        /// 修改不可变Tag策略
        ///
        /// 修改不可变Tag策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateImmutableRuleResponse UpdateImmutableRule(UpdateImmutableRuleRequest updateImmutableRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateImmutableRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateImmutableRuleRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(updateImmutableRuleRequest.ImmutableRuleId, out var valueOfImmutableRuleId)) urlParam.Add("immutable_rule_id", valueOfImmutableRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/immutabletagrules/{immutable_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateImmutableRuleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateImmutableRuleResponse>(response);
        }

        public SyncInvoker<UpdateImmutableRuleResponse> UpdateImmutableRuleInvoker(UpdateImmutableRuleRequest updateImmutableRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateImmutableRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateImmutableRuleRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(updateImmutableRuleRequest.ImmutableRuleId, out var valueOfImmutableRuleId)) urlParam.Add("immutable_rule_id", valueOfImmutableRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/immutabletagrules/{immutable_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateImmutableRuleRequest);
            return new SyncInvoker<UpdateImmutableRuleResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateImmutableRuleResponse>);
        }
        
        /// <summary>
        /// 修改实例配置
        ///
        /// 修改实例配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceConfigurationResponse UpdateInstanceConfiguration(UpdateInstanceConfigurationRequest updateInstanceConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceConfigurationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceConfigurationResponse>(response);
        }

        public SyncInvoker<UpdateInstanceConfigurationResponse> UpdateInstanceConfigurationInvoker(UpdateInstanceConfigurationRequest updateInstanceConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceConfigurationRequest);
            return new SyncInvoker<UpdateInstanceConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceConfigurationResponse>);
        }
        
        /// <summary>
        /// 更新公网访问白名单
        ///
        /// 更新公网访问白名单，更新方式为全量更新方式
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceEndpointPolicyResponse UpdateInstanceEndpointPolicy(UpdateInstanceEndpointPolicyRequest updateInstanceEndpointPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceEndpointPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/endpoint-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceEndpointPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceEndpointPolicyResponse>(response);
        }

        public SyncInvoker<UpdateInstanceEndpointPolicyResponse> UpdateInstanceEndpointPolicyInvoker(UpdateInstanceEndpointPolicyRequest updateInstanceEndpointPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceEndpointPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/endpoint-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceEndpointPolicyRequest);
            return new SyncInvoker<UpdateInstanceEndpointPolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceEndpointPolicyResponse>);
        }
        
        /// <summary>
        /// 启用/停用长期访问凭证
        ///
        /// 启用/停用长期访问凭证
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceLtCredentialResponse UpdateInstanceLtCredential(UpdateInstanceLtCredentialRequest updateInstanceLtCredentialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceLtCredentialRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceLtCredentialRequest.CredentialId, out var valueOfCredentialId)) urlParam.Add("credential_id", valueOfCredentialId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/long-term-credentials/{credential_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceLtCredentialRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceLtCredentialResponse>(response);
        }

        public SyncInvoker<UpdateInstanceLtCredentialResponse> UpdateInstanceLtCredentialInvoker(UpdateInstanceLtCredentialRequest updateInstanceLtCredentialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceLtCredentialRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceLtCredentialRequest.CredentialId, out var valueOfCredentialId)) urlParam.Add("credential_id", valueOfCredentialId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/long-term-credentials/{credential_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceLtCredentialRequest);
            return new SyncInvoker<UpdateInstanceLtCredentialResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceLtCredentialResponse>);
        }
        
        /// <summary>
        /// 修改命名空间
        ///
        /// 修改命名空间
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceNamespaceResponse UpdateInstanceNamespace(UpdateInstanceNamespaceRequest updateInstanceNamespaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceNamespaceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceNamespaceRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceNamespaceRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInstanceNamespaceResponse>(response);
        }

        public SyncInvoker<UpdateInstanceNamespaceResponse> UpdateInstanceNamespaceInvoker(UpdateInstanceNamespaceRequest updateInstanceNamespaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceNamespaceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceNamespaceRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceNamespaceRequest);
            return new SyncInvoker<UpdateInstanceNamespaceResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInstanceNamespaceResponse>);
        }
        
        /// <summary>
        /// 修改镜像同步的目标仓库
        ///
        /// 修改镜像同步的目标仓库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceRegistryResponse UpdateInstanceRegistry(UpdateInstanceRegistryRequest updateInstanceRegistryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceRegistryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceRegistryRequest.RegistryId, out var valueOfRegistryId)) urlParam.Add("registry_id", valueOfRegistryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/registries/{registry_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceRegistryRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceRegistryResponse>(response);
        }

        public SyncInvoker<UpdateInstanceRegistryResponse> UpdateInstanceRegistryInvoker(UpdateInstanceRegistryRequest updateInstanceRegistryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceRegistryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceRegistryRequest.RegistryId, out var valueOfRegistryId)) urlParam.Add("registry_id", valueOfRegistryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/registries/{registry_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceRegistryRequest);
            return new SyncInvoker<UpdateInstanceRegistryResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceRegistryResponse>);
        }
        
        /// <summary>
        /// 修改镜像同步策略
        ///
        /// 修改镜像同步策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceReplicationPolicyResponse UpdateInstanceReplicationPolicy(UpdateInstanceReplicationPolicyRequest updateInstanceReplicationPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceReplicationPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceReplicationPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceReplicationPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceReplicationPolicyResponse>(response);
        }

        public SyncInvoker<UpdateInstanceReplicationPolicyResponse> UpdateInstanceReplicationPolicyInvoker(UpdateInstanceReplicationPolicyRequest updateInstanceReplicationPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceReplicationPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceReplicationPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceReplicationPolicyRequest);
            return new SyncInvoker<UpdateInstanceReplicationPolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceReplicationPolicyResponse>);
        }
        
        /// <summary>
        /// 修改制品仓库
        ///
        /// 修改制品仓库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceRepositoryResponse UpdateInstanceRepository(UpdateInstanceRepositoryRequest updateInstanceRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceRepositoryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceRepositoryRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceRepositoryRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceRepositoryRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceRepositoryResponse>(response);
        }

        public SyncInvoker<UpdateInstanceRepositoryResponse> UpdateInstanceRepositoryInvoker(UpdateInstanceRepositoryRequest updateInstanceRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceRepositoryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceRepositoryRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceRepositoryRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceRepositoryRequest);
            return new SyncInvoker<UpdateInstanceRepositoryResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceRepositoryResponse>);
        }
        
        /// <summary>
        /// 修改老化策略
        ///
        /// 修改老化策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceRetentionPolicyResponse UpdateInstanceRetentionPolicy(UpdateInstanceRetentionPolicyRequest updateInstanceRetentionPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceRetentionPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceRetentionPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceRetentionPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/retention/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceRetentionPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceRetentionPolicyResponse>(response);
        }

        public SyncInvoker<UpdateInstanceRetentionPolicyResponse> UpdateInstanceRetentionPolicyInvoker(UpdateInstanceRetentionPolicyRequest updateInstanceRetentionPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceRetentionPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceRetentionPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceRetentionPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/retention/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceRetentionPolicyRequest);
            return new SyncInvoker<UpdateInstanceRetentionPolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceRetentionPolicyResponse>);
        }
        
        /// <summary>
        /// 修改签名策略
        ///
        /// 修改签名策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceSignPolicyResponse UpdateInstanceSignPolicy(UpdateInstanceSignPolicyRequest updateInstanceSignPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceSignPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceSignPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceSignPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/signature/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceSignPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceSignPolicyResponse>(response);
        }

        public SyncInvoker<UpdateInstanceSignPolicyResponse> UpdateInstanceSignPolicyInvoker(UpdateInstanceSignPolicyRequest updateInstanceSignPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceSignPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceSignPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceSignPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/signature/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceSignPolicyRequest);
            return new SyncInvoker<UpdateInstanceSignPolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceSignPolicyResponse>);
        }
        
        /// <summary>
        /// 修改触发器
        ///
        /// 修改触发器
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInstanceWebhookResponse UpdateInstanceWebhook(UpdateInstanceWebhookRequest updateInstanceWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceWebhookRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceWebhookRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceWebhookRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/webhook/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceWebhookRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceWebhookResponse>(response);
        }

        public SyncInvoker<UpdateInstanceWebhookResponse> UpdateInstanceWebhookInvoker(UpdateInstanceWebhookRequest updateInstanceWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceWebhookRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceWebhookRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceWebhookRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/webhook/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceWebhookRequest);
            return new SyncInvoker<UpdateInstanceWebhookResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceWebhookResponse>);
        }
        
    }
}