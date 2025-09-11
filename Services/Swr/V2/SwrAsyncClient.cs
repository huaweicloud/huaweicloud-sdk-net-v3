using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Swr.V2.Model;

namespace HuaweiCloud.SDK.Swr.V2
{
    public partial class SwrAsyncClient : Client
    {
        public static ClientBuilder<SwrAsyncClient> NewBuilder()
        {
            return new ClientBuilder<SwrAsyncClient>();
        }

        
        /// <summary>
        /// 生成增强型登录指令(新)
        ///
        /// 调用该接口，通过获取响应消息头的X-Swr-Dockerlogin的值及响应消息体的host值，可生成增强型登录指令,注：此接口只支持IAM新平面的调用方式。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAuthorizationTokenResponse> CreateAuthorizationTokenAsync(CreateAuthorizationTokenRequest createAuthorizationTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/utils/authorizationtoken", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAuthorizationTokenRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAuthorizationTokenResponse>(response);
        }

        public AsyncInvoker<CreateAuthorizationTokenResponse> CreateAuthorizationTokenAsyncInvoker(CreateAuthorizationTokenRequest createAuthorizationTokenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/utils/authorizationtoken", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAuthorizationTokenRequest);
            return new AsyncInvoker<CreateAuthorizationTokenResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAuthorizationTokenResponse>);
        }
        
        /// <summary>
        /// 创建镜像自动同步任务
        ///
        /// 创建镜像自动同步任务，帮助您把最新推送的镜像自动同步到其他区域镜像仓库内。 镜像自动同步帮助您把最新推送的镜像自动同步到其他区域镜像仓库内，后期镜像有更新时，目标仓库的镜像也会自动更新，但已有的镜像不会自动同步。已有镜像的同步需要手动操作，详情请参见手动同步镜像。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateImageSyncRepoResponse> CreateImageSyncRepoAsync(CreateImageSyncRepoRequest createImageSyncRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createImageSyncRepoRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(createImageSyncRepoRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/sync_repo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createImageSyncRepoRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateImageSyncRepoResponse>(response);
        }

        public AsyncInvoker<CreateImageSyncRepoResponse> CreateImageSyncRepoAsyncInvoker(CreateImageSyncRepoRequest createImageSyncRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createImageSyncRepoRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(createImageSyncRepoRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/sync_repo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createImageSyncRepoRequest);
            return new AsyncInvoker<CreateImageSyncRepoResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateImageSyncRepoResponse>);
        }
        
        /// <summary>
        /// 手动同步镜像
        ///
        /// 对于镜像仓库已有的镜像，如果想在其他区域使用，需要手动触发镜像同步。 判断是否同步成功的方法如下：响应状态码为200，无报错信息，表示同步成功。通过SWR管理控制台或调用查询镜像仓库概要信息接口，在目标区域的目标组织下，若存在所同步的镜像版本表示同步成功。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateManualImageSyncRepoResponse> CreateManualImageSyncRepoAsync(CreateManualImageSyncRepoRequest createManualImageSyncRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createManualImageSyncRepoRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(createManualImageSyncRepoRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/sync_images", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createManualImageSyncRepoRequest);
            var response = await DoHttpRequestAsync("POST", request);
            var createManualImageSyncRepoResponse = JsonUtils.DeSerializeNull<CreateManualImageSyncRepoResponse>(response);
            createManualImageSyncRepoResponse.Body = JsonUtils.DeSerializeList<string>(response);
            return createManualImageSyncRepoResponse;
        }

        public AsyncInvoker<CreateManualImageSyncRepoResponse> CreateManualImageSyncRepoAsyncInvoker(CreateManualImageSyncRepoRequest createManualImageSyncRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createManualImageSyncRepoRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(createManualImageSyncRepoRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/sync_images", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createManualImageSyncRepoRequest);
            return new AsyncInvoker<CreateManualImageSyncRepoResponse>(this, "POST", request, response =>
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
        public async Task<CreateNamespaceResponse> CreateNamespaceAsync(CreateNamespaceRequest createNamespaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNamespaceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateNamespaceResponse>(response);
        }

        public AsyncInvoker<CreateNamespaceResponse> CreateNamespaceAsyncInvoker(CreateNamespaceRequest createNamespaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNamespaceRequest);
            return new AsyncInvoker<CreateNamespaceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateNamespaceResponse>);
        }
        
        /// <summary>
        /// 创建组织权限
        ///
        /// 创建组织权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateNamespaceAuthResponse> CreateNamespaceAuthAsync(CreateNamespaceAuthRequest createNamespaceAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createNamespaceAuthRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNamespaceAuthRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateNamespaceAuthResponse>(response);
        }

        public AsyncInvoker<CreateNamespaceAuthResponse> CreateNamespaceAuthAsyncInvoker(CreateNamespaceAuthRequest createNamespaceAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createNamespaceAuthRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNamespaceAuthRequest);
            return new AsyncInvoker<CreateNamespaceAuthResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateNamespaceAuthResponse>);
        }
        
        /// <summary>
        /// 在组织下创建镜像仓库
        ///
        /// 在组织下创建镜像仓库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRepoResponse> CreateRepoAsync(CreateRepoRequest createRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRepoRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepoRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateRepoResponse>(response);
        }

        public AsyncInvoker<CreateRepoResponse> CreateRepoAsyncInvoker(CreateRepoRequest createRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRepoRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepoRequest);
            return new AsyncInvoker<CreateRepoResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateRepoResponse>);
        }
        
        /// <summary>
        /// 创建共享帐号
        ///
        /// 创建共享帐号。镜像上传后，您可以共享私有镜像给其他帐号，并授予下载该镜像的权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRepoDomainsResponse> CreateRepoDomainsAsync(CreateRepoDomainsRequest createRepoDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRepoDomainsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(createRepoDomainsRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepoDomainsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateRepoDomainsResponse>(response);
        }

        public AsyncInvoker<CreateRepoDomainsResponse> CreateRepoDomainsAsyncInvoker(CreateRepoDomainsRequest createRepoDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRepoDomainsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(createRepoDomainsRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepoDomainsRequest);
            return new AsyncInvoker<CreateRepoDomainsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateRepoDomainsResponse>);
        }
        
        /// <summary>
        /// 创建镜像tag
        ///
        /// 创建镜像tag
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRepoTagResponse> CreateRepoTagAsync(CreateRepoTagRequest createRepoTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRepoTagRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(createRepoTagRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepoTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateRepoTagResponse>(response);
        }

        public AsyncInvoker<CreateRepoTagResponse> CreateRepoTagAsyncInvoker(CreateRepoTagRequest createRepoTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRepoTagRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(createRepoTagRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepoTagRequest);
            return new AsyncInvoker<CreateRepoTagResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateRepoTagResponse>);
        }
        
        /// <summary>
        /// 创建镜像老化规则
        ///
        /// 创建镜像老化规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRetentionResponse> CreateRetentionAsync(CreateRetentionRequest createRetentionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRetentionRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(createRetentionRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRetentionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateRetentionResponse>(response);
        }

        public AsyncInvoker<CreateRetentionResponse> CreateRetentionAsyncInvoker(CreateRetentionRequest createRetentionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRetentionRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(createRetentionRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRetentionRequest);
            return new AsyncInvoker<CreateRetentionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRetentionResponse>);
        }
        
        /// <summary>
        /// 生成临时登录指令
        ///
        /// 调用该接口，通过获取响应消息头的X-Swr-Dockerlogin的值及响应消息体的host值，可生成临时登录指令。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSecretResponse> CreateSecretAsync(CreateSecretRequest createSecretRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/utils/secret", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSecretRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateSecretResponse>(response);
        }

        public AsyncInvoker<CreateSecretResponse> CreateSecretAsyncInvoker(CreateSecretRequest createSecretRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/utils/secret", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSecretRequest);
            return new AsyncInvoker<CreateSecretResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSecretResponse>);
        }
        
        /// <summary>
        /// 创建触发器
        ///
        /// 创建触发器
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTriggerResponse> CreateTriggerAsync(CreateTriggerRequest createTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTriggerRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(createTriggerRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTriggerRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateTriggerResponse>(response);
        }

        public AsyncInvoker<CreateTriggerResponse> CreateTriggerAsyncInvoker(CreateTriggerRequest createTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTriggerRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(createTriggerRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTriggerRequest);
            return new AsyncInvoker<CreateTriggerResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateTriggerResponse>);
        }
        
        /// <summary>
        /// 创建镜像权限
        ///
        /// 创建镜像权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateUserRepositoryAuthResponse> CreateUserRepositoryAuthAsync(CreateUserRepositoryAuthRequest createUserRepositoryAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createUserRepositoryAuthRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(createUserRepositoryAuthRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUserRepositoryAuthRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateUserRepositoryAuthResponse>(response);
        }

        public AsyncInvoker<CreateUserRepositoryAuthResponse> CreateUserRepositoryAuthAsyncInvoker(CreateUserRepositoryAuthRequest createUserRepositoryAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createUserRepositoryAuthRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(createUserRepositoryAuthRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUserRepositoryAuthRequest);
            return new AsyncInvoker<CreateUserRepositoryAuthResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateUserRepositoryAuthResponse>);
        }
        
        /// <summary>
        /// 删除镜像自动同步任务
        ///
        /// 根据目标区域、目标组织删除指定的镜像自动同步任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteImageSyncRepoResponse> DeleteImageSyncRepoAsync(DeleteImageSyncRepoRequest deleteImageSyncRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteImageSyncRepoRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(deleteImageSyncRepoRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/sync_repo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteImageSyncRepoRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteImageSyncRepoResponse>(response);
        }

        public AsyncInvoker<DeleteImageSyncRepoResponse> DeleteImageSyncRepoAsyncInvoker(DeleteImageSyncRepoRequest deleteImageSyncRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteImageSyncRepoRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(deleteImageSyncRepoRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/sync_repo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteImageSyncRepoRequest);
            return new AsyncInvoker<DeleteImageSyncRepoResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteImageSyncRepoResponse>);
        }
        
        /// <summary>
        /// 删除组织权限
        ///
        /// 删除组织权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteNamespaceAuthResponse> DeleteNamespaceAuthAsync(DeleteNamespaceAuthRequest deleteNamespaceAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteNamespaceAuthRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNamespaceAuthRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteNamespaceAuthResponse>(response);
        }

        public AsyncInvoker<DeleteNamespaceAuthResponse> DeleteNamespaceAuthAsyncInvoker(DeleteNamespaceAuthRequest deleteNamespaceAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteNamespaceAuthRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNamespaceAuthRequest);
            return new AsyncInvoker<DeleteNamespaceAuthResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteNamespaceAuthResponse>);
        }
        
        /// <summary>
        /// 删除组织
        ///
        /// 删除组织
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteNamespacesResponse> DeleteNamespacesAsync(DeleteNamespacesRequest deleteNamespacesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteNamespacesRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNamespacesRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteNamespacesResponse>(response);
        }

        public AsyncInvoker<DeleteNamespacesResponse> DeleteNamespacesAsyncInvoker(DeleteNamespacesRequest deleteNamespacesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteNamespacesRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNamespacesRequest);
            return new AsyncInvoker<DeleteNamespacesResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteNamespacesResponse>);
        }
        
        /// <summary>
        /// 删除组织下的镜像仓库
        ///
        /// 删除组织下的镜像仓库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRepoResponse> DeleteRepoAsync(DeleteRepoRequest deleteRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepoRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRepoResponse>(response);
        }

        public AsyncInvoker<DeleteRepoResponse> DeleteRepoAsyncInvoker(DeleteRepoRequest deleteRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepoRequest);
            return new AsyncInvoker<DeleteRepoResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRepoResponse>);
        }
        
        /// <summary>
        /// 删除共享帐号
        ///
        /// 删除共享帐号
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRepoDomainsResponse> DeleteRepoDomainsAsync(DeleteRepoDomainsRequest deleteRepoDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoDomainsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoDomainsRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoDomainsRequest.AccessDomain, out var valueOfAccessDomain)) urlParam.Add("access_domain", valueOfAccessDomain);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains/{access_domain}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepoDomainsRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRepoDomainsResponse>(response);
        }

        public AsyncInvoker<DeleteRepoDomainsResponse> DeleteRepoDomainsAsyncInvoker(DeleteRepoDomainsRequest deleteRepoDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoDomainsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoDomainsRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoDomainsRequest.AccessDomain, out var valueOfAccessDomain)) urlParam.Add("access_domain", valueOfAccessDomain);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains/{access_domain}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepoDomainsRequest);
            return new AsyncInvoker<DeleteRepoDomainsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRepoDomainsResponse>);
        }
        
        /// <summary>
        /// 删除指定tag的镜像
        ///
        /// 删除镜像仓库中指定tag的镜像
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRepoTagResponse> DeleteRepoTagAsync(DeleteRepoTagRequest deleteRepoTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoTagRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoTagRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoTagRequest.Tag, out var valueOfTag)) urlParam.Add("tag", valueOfTag);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/tags/{tag}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepoTagRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRepoTagResponse>(response);
        }

        public AsyncInvoker<DeleteRepoTagResponse> DeleteRepoTagAsyncInvoker(DeleteRepoTagRequest deleteRepoTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoTagRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoTagRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoTagRequest.Tag, out var valueOfTag)) urlParam.Add("tag", valueOfTag);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/tags/{tag}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepoTagRequest);
            return new AsyncInvoker<DeleteRepoTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRepoTagResponse>);
        }
        
        /// <summary>
        /// 删除镜像老化规则
        ///
        /// 删除镜像老化规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRetentionResponse> DeleteRetentionAsync(DeleteRetentionRequest deleteRetentionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRetentionRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(deleteRetentionRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(deleteRetentionRequest.RetentionId, out var valueOfRetentionId)) urlParam.Add("retention_id", valueOfRetentionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions/{retention_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRetentionRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRetentionResponse>(response);
        }

        public AsyncInvoker<DeleteRetentionResponse> DeleteRetentionAsyncInvoker(DeleteRetentionRequest deleteRetentionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRetentionRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(deleteRetentionRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(deleteRetentionRequest.RetentionId, out var valueOfRetentionId)) urlParam.Add("retention_id", valueOfRetentionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions/{retention_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRetentionRequest);
            return new AsyncInvoker<DeleteRetentionResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRetentionResponse>);
        }
        
        /// <summary>
        /// 删除触发器
        ///
        /// 删除触发器
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTriggerResponse> DeleteTriggerAsync(DeleteTriggerRequest deleteTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTriggerRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(deleteTriggerRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(deleteTriggerRequest.Trigger, out var valueOfTrigger)) urlParam.Add("trigger", valueOfTrigger);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers/{trigger}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTriggerRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTriggerResponse>(response);
        }

        public AsyncInvoker<DeleteTriggerResponse> DeleteTriggerAsyncInvoker(DeleteTriggerRequest deleteTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTriggerRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(deleteTriggerRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(deleteTriggerRequest.Trigger, out var valueOfTrigger)) urlParam.Add("trigger", valueOfTrigger);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers/{trigger}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTriggerRequest);
            return new AsyncInvoker<DeleteTriggerResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTriggerResponse>);
        }
        
        /// <summary>
        /// 删除镜像权限
        ///
        /// 删除镜像权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteUserRepositoryAuthResponse> DeleteUserRepositoryAuthAsync(DeleteUserRepositoryAuthRequest deleteUserRepositoryAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteUserRepositoryAuthRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(deleteUserRepositoryAuthRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserRepositoryAuthRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteUserRepositoryAuthResponse>(response);
        }

        public AsyncInvoker<DeleteUserRepositoryAuthResponse> DeleteUserRepositoryAuthAsyncInvoker(DeleteUserRepositoryAuthRequest deleteUserRepositoryAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteUserRepositoryAuthRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(deleteUserRepositoryAuthRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserRepositoryAuthRequest);
            return new AsyncInvoker<DeleteUserRepositoryAuthResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteUserRepositoryAuthResponse>);
        }
        
        /// <summary>
        /// 获取镜像自动同步任务列表
        ///
        /// 获取为当前镜像仓库所创建的所有自动同步任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListImageAutoSyncReposDetailsResponse> ListImageAutoSyncReposDetailsAsync(ListImageAutoSyncReposDetailsRequest listImageAutoSyncReposDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listImageAutoSyncReposDetailsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(listImageAutoSyncReposDetailsRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/sync_repo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImageAutoSyncReposDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listImageAutoSyncReposDetailsResponse = JsonUtils.DeSerializeNull<ListImageAutoSyncReposDetailsResponse>(response);
            listImageAutoSyncReposDetailsResponse.Body = JsonUtils.DeSerializeList<SyncRepo>(response);
            return listImageAutoSyncReposDetailsResponse;
        }

        public AsyncInvoker<ListImageAutoSyncReposDetailsResponse> ListImageAutoSyncReposDetailsAsyncInvoker(ListImageAutoSyncReposDetailsRequest listImageAutoSyncReposDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listImageAutoSyncReposDetailsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(listImageAutoSyncReposDetailsRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/sync_repo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImageAutoSyncReposDetailsRequest);
            return new AsyncInvoker<ListImageAutoSyncReposDetailsResponse>(this, "GET", request, response =>
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
        public async Task<ListNamespacesResponse> ListNamespacesAsync(ListNamespacesRequest listNamespacesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNamespacesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListNamespacesResponse>(response);
        }

        public AsyncInvoker<ListNamespacesResponse> ListNamespacesAsyncInvoker(ListNamespacesRequest listNamespacesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNamespacesRequest);
            return new AsyncInvoker<ListNamespacesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNamespacesResponse>);
        }
        
        /// <summary>
        /// 获取配额信息
        ///
        /// 获取配额信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListQuotasResponse> ListQuotasAsync(ListQuotasRequest listQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/projects/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotasRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListQuotasResponse>(response);
        }

        public AsyncInvoker<ListQuotasResponse> ListQuotasAsyncInvoker(ListQuotasRequest listQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/projects/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotasRequest);
            return new AsyncInvoker<ListQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListQuotasResponse>);
        }
        
        /// <summary>
        /// 查询镜像仓库列表详情
        ///
        /// 查询镜像仓库列表详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRepoDetailsResponse> ListRepoDetailsAsync(ListRepoDetailsRequest listRepoDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/manage/repos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepoDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRepoDetailsResponse>(response);
        }

        public AsyncInvoker<ListRepoDetailsResponse> ListRepoDetailsAsyncInvoker(ListRepoDetailsRequest listRepoDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/manage/repos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepoDetailsRequest);
            return new AsyncInvoker<ListRepoDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRepoDetailsResponse>);
        }
        
        /// <summary>
        /// 获取共享帐号列表
        ///
        /// 获取共享帐号列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRepoDomainsResponse> ListRepoDomainsAsync(ListRepoDomainsRequest listRepoDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepoDomainsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(listRepoDomainsRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepoDomainsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listRepoDomainsResponse = JsonUtils.DeSerializeNull<ListRepoDomainsResponse>(response);
            listRepoDomainsResponse.Body = JsonUtils.DeSerializeList<ShowRepoDomainsResponse>(response);
            return listRepoDomainsResponse;
        }

        public AsyncInvoker<ListRepoDomainsResponse> ListRepoDomainsAsyncInvoker(ListRepoDomainsRequest listRepoDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepoDomainsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(listRepoDomainsRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepoDomainsRequest);
            return new AsyncInvoker<ListRepoDomainsResponse>(this, "GET", request, response =>
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
        public async Task<ListReposDetailsResponse> ListReposDetailsAsync(ListReposDetailsRequest listReposDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/repos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReposDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listReposDetailsResponse = JsonUtils.DeSerializeNull<ListReposDetailsResponse>(response);
            listReposDetailsResponse.Body = JsonUtils.DeSerializeList<ShowReposResp>(response);
            return listReposDetailsResponse;
        }

        public AsyncInvoker<ListReposDetailsResponse> ListReposDetailsAsyncInvoker(ListReposDetailsRequest listReposDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/repos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReposDetailsRequest);
            return new AsyncInvoker<ListReposDetailsResponse>(this, "GET", request, response =>
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
        public async Task<ListRepositoryTagResponse> ListRepositoryTagAsync(ListRepositoryTagRequest listRepositoryTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryTagRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryTagRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v3/manage/namespaces/{namespace}/repos/{repository}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryTagRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRepositoryTagResponse>(response);
        }

        public AsyncInvoker<ListRepositoryTagResponse> ListRepositoryTagAsyncInvoker(ListRepositoryTagRequest listRepositoryTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryTagRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryTagRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v3/manage/namespaces/{namespace}/repos/{repository}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryTagRequest);
            return new AsyncInvoker<ListRepositoryTagResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRepositoryTagResponse>);
        }
        
        /// <summary>
        /// 查询镜像tag列表
        ///
        /// 查询镜像tag列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRepositoryTagsResponse> ListRepositoryTagsAsync(ListRepositoryTagsRequest listRepositoryTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryTagsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryTagsRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listRepositoryTagsResponse = JsonUtils.DeSerializeNull<ListRepositoryTagsResponse>(response);
            listRepositoryTagsResponse.Body = JsonUtils.DeSerializeList<ShowReposTagResp>(response);
            return listRepositoryTagsResponse;
        }

        public AsyncInvoker<ListRepositoryTagsResponse> ListRepositoryTagsAsyncInvoker(ListRepositoryTagsRequest listRepositoryTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryTagsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryTagsRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryTagsRequest);
            return new AsyncInvoker<ListRepositoryTagsResponse>(this, "GET", request, response =>
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
        public async Task<ListRetentionHistoriesResponse> ListRetentionHistoriesAsync(ListRetentionHistoriesRequest listRetentionHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRetentionHistoriesRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(listRetentionHistoriesRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions/histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRetentionHistoriesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRetentionHistoriesResponse>(response);
        }

        public AsyncInvoker<ListRetentionHistoriesResponse> ListRetentionHistoriesAsyncInvoker(ListRetentionHistoriesRequest listRetentionHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRetentionHistoriesRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(listRetentionHistoriesRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions/histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRetentionHistoriesRequest);
            return new AsyncInvoker<ListRetentionHistoriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRetentionHistoriesResponse>);
        }
        
        /// <summary>
        /// 获取镜像老化规则列表
        ///
        /// 获取镜像老化规则列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRetentionsResponse> ListRetentionsAsync(ListRetentionsRequest listRetentionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRetentionsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(listRetentionsRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRetentionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listRetentionsResponse = JsonUtils.DeSerializeNull<ListRetentionsResponse>(response);
            listRetentionsResponse.Body = JsonUtils.DeSerializeList<Retention>(response);
            return listRetentionsResponse;
        }

        public AsyncInvoker<ListRetentionsResponse> ListRetentionsAsyncInvoker(ListRetentionsRequest listRetentionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRetentionsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(listRetentionsRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRetentionsRequest);
            return new AsyncInvoker<ListRetentionsResponse>(this, "GET", request, response =>
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
        public async Task<ListSharedRepoDetailsResponse> ListSharedRepoDetailsAsync(ListSharedRepoDetailsRequest listSharedRepoDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/manage/shared-repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSharedRepoDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSharedRepoDetailsResponse>(response);
        }

        public AsyncInvoker<ListSharedRepoDetailsResponse> ListSharedRepoDetailsAsyncInvoker(ListSharedRepoDetailsRequest listSharedRepoDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/manage/shared-repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSharedRepoDetailsRequest);
            return new AsyncInvoker<ListSharedRepoDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSharedRepoDetailsResponse>);
        }
        
        /// <summary>
        /// 查询共享镜像列表
        ///
        /// 查询共享镜像列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSharedReposDetailsResponse> ListSharedReposDetailsAsync(ListSharedReposDetailsRequest listSharedReposDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/shared-repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSharedReposDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listSharedReposDetailsResponse = JsonUtils.DeSerializeNull<ListSharedReposDetailsResponse>(response);
            listSharedReposDetailsResponse.Body = JsonUtils.DeSerializeList<ShowReposResp>(response);
            return listSharedReposDetailsResponse;
        }

        public AsyncInvoker<ListSharedReposDetailsResponse> ListSharedReposDetailsAsyncInvoker(ListSharedReposDetailsRequest listSharedReposDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/shared-repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSharedReposDetailsRequest);
            return new AsyncInvoker<ListSharedReposDetailsResponse>(this, "GET", request, response =>
            {
                var listSharedReposDetailsResponse = JsonUtils.DeSerializeNull<ListSharedReposDetailsResponse>(response);
                listSharedReposDetailsResponse.Body = JsonUtils.DeSerializeList<ShowReposResp>(response);
                return listSharedReposDetailsResponse;
            });
        }
        
        /// <summary>
        /// 获取镜像仓库下的触发器列表
        ///
        /// 获取镜像仓库下的触发器列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTriggersDetailsResponse> ListTriggersDetailsAsync(ListTriggersDetailsRequest listTriggersDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTriggersDetailsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(listTriggersDetailsRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTriggersDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listTriggersDetailsResponse = JsonUtils.DeSerializeNull<ListTriggersDetailsResponse>(response);
            listTriggersDetailsResponse.Body = JsonUtils.DeSerializeList<Trigger>(response);
            return listTriggersDetailsResponse;
        }

        public AsyncInvoker<ListTriggersDetailsResponse> ListTriggersDetailsAsyncInvoker(ListTriggersDetailsRequest listTriggersDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTriggersDetailsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(listTriggersDetailsRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTriggersDetailsRequest);
            return new AsyncInvoker<ListTriggersDetailsResponse>(this, "GET", request, response =>
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
        public async Task<ShowAccessDomainResponse> ShowAccessDomainAsync(ShowAccessDomainRequest showAccessDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAccessDomainRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(showAccessDomainRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(showAccessDomainRequest.AccessDomain, out var valueOfAccessDomain)) urlParam.Add("access_domain", valueOfAccessDomain);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains/{access_domain}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAccessDomainRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAccessDomainResponse>(response);
        }

        public AsyncInvoker<ShowAccessDomainResponse> ShowAccessDomainAsyncInvoker(ShowAccessDomainRequest showAccessDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAccessDomainRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(showAccessDomainRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(showAccessDomainRequest.AccessDomain, out var valueOfAccessDomain)) urlParam.Add("access_domain", valueOfAccessDomain);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains/{access_domain}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAccessDomainRequest);
            return new AsyncInvoker<ShowAccessDomainResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAccessDomainResponse>);
        }
        
        /// <summary>
        /// 获取租户总览信息
        ///
        /// 获取租户总览信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainOverviewResponse> ShowDomainOverviewAsync(ShowDomainOverviewRequest showDomainOverviewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/overview", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainOverviewRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainOverviewResponse>(response);
        }

        public AsyncInvoker<ShowDomainOverviewResponse> ShowDomainOverviewAsyncInvoker(ShowDomainOverviewRequest showDomainOverviewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/overview", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainOverviewRequest);
            return new AsyncInvoker<ShowDomainOverviewResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainOverviewResponse>);
        }
        
        /// <summary>
        /// 获取租户资源统计信息
        ///
        /// 获取租户资源统计信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainResourceReportsResponse> ShowDomainResourceReportsAsync(ShowDomainResourceReportsRequest showDomainResourceReportsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDomainResourceReportsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(showDomainResourceReportsRequest.Frequency, out var valueOfFrequency)) urlParam.Add("frequency", valueOfFrequency);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/reports/{resource_type}/{frequency}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainResourceReportsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var showDomainResourceReportsResponse = JsonUtils.DeSerializeNull<ShowDomainResourceReportsResponse>(response);
            showDomainResourceReportsResponse.Body = JsonUtils.DeSerializeList<ReportData>(response);
            return showDomainResourceReportsResponse;
        }

        public AsyncInvoker<ShowDomainResourceReportsResponse> ShowDomainResourceReportsAsyncInvoker(ShowDomainResourceReportsRequest showDomainResourceReportsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDomainResourceReportsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(showDomainResourceReportsRequest.Frequency, out var valueOfFrequency)) urlParam.Add("frequency", valueOfFrequency);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/reports/{resource_type}/{frequency}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainResourceReportsRequest);
            return new AsyncInvoker<ShowDomainResourceReportsResponse>(this, "GET", request, response =>
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
        public async Task<ShowNamespaceResponse> ShowNamespaceAsync(ShowNamespaceRequest showNamespaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNamespaceRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNamespaceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowNamespaceResponse>(response);
        }

        public AsyncInvoker<ShowNamespaceResponse> ShowNamespaceAsyncInvoker(ShowNamespaceRequest showNamespaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNamespaceRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNamespaceRequest);
            return new AsyncInvoker<ShowNamespaceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNamespaceResponse>);
        }
        
        /// <summary>
        /// 查询组织权限
        ///
        /// 查询组织权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowNamespaceAuthResponse> ShowNamespaceAuthAsync(ShowNamespaceAuthRequest showNamespaceAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNamespaceAuthRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNamespaceAuthRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowNamespaceAuthResponse>(response);
        }

        public AsyncInvoker<ShowNamespaceAuthResponse> ShowNamespaceAuthAsyncInvoker(ShowNamespaceAuthRequest showNamespaceAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNamespaceAuthRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNamespaceAuthRequest);
            return new AsyncInvoker<ShowNamespaceAuthResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNamespaceAuthResponse>);
        }
        
        /// <summary>
        /// 查询指定tag的镜像详情
        ///
        /// 查询镜像仓库中指定tag的镜像
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRepoTagResponse> ShowRepoTagAsync(ShowRepoTagRequest showRepoTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepoTagRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(showRepoTagRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(showRepoTagRequest.Tag, out var valueOfTag)) urlParam.Add("tag", valueOfTag);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/tags/{tag}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepoTagRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRepoTagResponse>(response);
        }

        public AsyncInvoker<ShowRepoTagResponse> ShowRepoTagAsyncInvoker(ShowRepoTagRequest showRepoTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepoTagRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(showRepoTagRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(showRepoTagRequest.Tag, out var valueOfTag)) urlParam.Add("tag", valueOfTag);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/tags/{tag}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepoTagRequest);
            return new AsyncInvoker<ShowRepoTagResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepoTagResponse>);
        }
        
        /// <summary>
        /// 查询镜像仓库概要信息
        ///
        /// 查询镜像仓库概要信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRepositoryResponse> ShowRepositoryAsync(ShowRepositoryRequest showRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRepositoryResponse>(response);
        }

        public AsyncInvoker<ShowRepositoryResponse> ShowRepositoryAsyncInvoker(ShowRepositoryRequest showRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryRequest);
            return new AsyncInvoker<ShowRepositoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepositoryResponse>);
        }
        
        /// <summary>
        /// 获取镜像老化规则记录
        ///
        /// 获取镜像老化规则记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRetentionResponse> ShowRetentionAsync(ShowRetentionRequest showRetentionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRetentionRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(showRetentionRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(showRetentionRequest.RetentionId, out var valueOfRetentionId)) urlParam.Add("retention_id", valueOfRetentionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions/{retention_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRetentionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRetentionResponse>(response);
        }

        public AsyncInvoker<ShowRetentionResponse> ShowRetentionAsyncInvoker(ShowRetentionRequest showRetentionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRetentionRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(showRetentionRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(showRetentionRequest.RetentionId, out var valueOfRetentionId)) urlParam.Add("retention_id", valueOfRetentionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions/{retention_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRetentionRequest);
            return new AsyncInvoker<ShowRetentionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRetentionResponse>);
        }
        
        /// <summary>
        /// 查询服务特性开关信息
        ///
        /// 查询服务特性开关信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowShareFeatureGatesResponse> ShowShareFeatureGatesAsync(ShowShareFeatureGatesRequest showShareFeatureGatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/projects/{project_id}/feature-gates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showShareFeatureGatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowShareFeatureGatesResponse>(response);
        }

        public AsyncInvoker<ShowShareFeatureGatesResponse> ShowShareFeatureGatesAsyncInvoker(ShowShareFeatureGatesRequest showShareFeatureGatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/projects/{project_id}/feature-gates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showShareFeatureGatesRequest);
            return new AsyncInvoker<ShowShareFeatureGatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowShareFeatureGatesResponse>);
        }
        
        /// <summary>
        /// 获取镜像自动同步任务信息
        ///
        /// 创建镜像自动同步任务后，可以通过此接口查询该任务的状态，以判断是否同步成功。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSyncJobResponse> ShowSyncJobAsync(ShowSyncJobRequest showSyncJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSyncJobRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(showSyncJobRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/sync_job", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSyncJobRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var showSyncJobResponse = JsonUtils.DeSerializeNull<ShowSyncJobResponse>(response);
            showSyncJobResponse.Body = JsonUtils.DeSerializeList<SyncJob>(response);
            return showSyncJobResponse;
        }

        public AsyncInvoker<ShowSyncJobResponse> ShowSyncJobAsyncInvoker(ShowSyncJobRequest showSyncJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSyncJobRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(showSyncJobRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/sync_job", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSyncJobRequest);
            return new AsyncInvoker<ShowSyncJobResponse>(this, "GET", request, response =>
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
        public async Task<ShowTriggerResponse> ShowTriggerAsync(ShowTriggerRequest showTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTriggerRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(showTriggerRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(showTriggerRequest.Trigger, out var valueOfTrigger)) urlParam.Add("trigger", valueOfTrigger);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers/{trigger}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTriggerRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTriggerResponse>(response);
        }

        public AsyncInvoker<ShowTriggerResponse> ShowTriggerAsyncInvoker(ShowTriggerRequest showTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTriggerRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(showTriggerRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(showTriggerRequest.Trigger, out var valueOfTrigger)) urlParam.Add("trigger", valueOfTrigger);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers/{trigger}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTriggerRequest);
            return new AsyncInvoker<ShowTriggerResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTriggerResponse>);
        }
        
        /// <summary>
        /// 查询镜像权限
        ///
        /// 查询镜像权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowUserRepositoryAuthResponse> ShowUserRepositoryAuthAsync(ShowUserRepositoryAuthRequest showUserRepositoryAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUserRepositoryAuthRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(showUserRepositoryAuthRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserRepositoryAuthRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowUserRepositoryAuthResponse>(response);
        }

        public AsyncInvoker<ShowUserRepositoryAuthResponse> ShowUserRepositoryAuthAsyncInvoker(ShowUserRepositoryAuthRequest showUserRepositoryAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUserRepositoryAuthRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(showUserRepositoryAuthRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserRepositoryAuthRequest);
            return new AsyncInvoker<ShowUserRepositoryAuthResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUserRepositoryAuthResponse>);
        }
        
        /// <summary>
        /// 更新组织权限
        ///
        /// 更新组织权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateNamespaceAuthResponse> UpdateNamespaceAuthAsync(UpdateNamespaceAuthRequest updateNamespaceAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateNamespaceAuthRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNamespaceAuthRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerializeNull<UpdateNamespaceAuthResponse>(response);
        }

        public AsyncInvoker<UpdateNamespaceAuthResponse> UpdateNamespaceAuthAsyncInvoker(UpdateNamespaceAuthRequest updateNamespaceAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateNamespaceAuthRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNamespaceAuthRequest);
            return new AsyncInvoker<UpdateNamespaceAuthResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<UpdateNamespaceAuthResponse>);
        }
        
        /// <summary>
        /// 更新镜像仓库的概要信息
        ///
        /// 更新租户组织下的镜像概要信息，包括镜像类型、是否公有、描述信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRepoResponse> UpdateRepoAsync(UpdateRepoRequest updateRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepoRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(updateRepoRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepoRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerializeNull<UpdateRepoResponse>(response);
        }

        public AsyncInvoker<UpdateRepoResponse> UpdateRepoAsyncInvoker(UpdateRepoRequest updateRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepoRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(updateRepoRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepoRequest);
            return new AsyncInvoker<UpdateRepoResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<UpdateRepoResponse>);
        }
        
        /// <summary>
        /// 更新共享帐号
        ///
        /// 更新共享帐号
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRepoDomainsResponse> UpdateRepoDomainsAsync(UpdateRepoDomainsRequest updateRepoDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepoDomainsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(updateRepoDomainsRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(updateRepoDomainsRequest.AccessDomain, out var valueOfAccessDomain)) urlParam.Add("access_domain", valueOfAccessDomain);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains/{access_domain}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepoDomainsRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerializeNull<UpdateRepoDomainsResponse>(response);
        }

        public AsyncInvoker<UpdateRepoDomainsResponse> UpdateRepoDomainsAsyncInvoker(UpdateRepoDomainsRequest updateRepoDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepoDomainsRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(updateRepoDomainsRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(updateRepoDomainsRequest.AccessDomain, out var valueOfAccessDomain)) urlParam.Add("access_domain", valueOfAccessDomain);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains/{access_domain}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepoDomainsRequest);
            return new AsyncInvoker<UpdateRepoDomainsResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<UpdateRepoDomainsResponse>);
        }
        
        /// <summary>
        /// 修改镜像老化规则
        ///
        /// 修改镜像老化规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRetentionResponse> UpdateRetentionAsync(UpdateRetentionRequest updateRetentionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRetentionRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(updateRetentionRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(updateRetentionRequest.RetentionId, out var valueOfRetentionId)) urlParam.Add("retention_id", valueOfRetentionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions/{retention_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRetentionRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerializeNull<UpdateRetentionResponse>(response);
        }

        public AsyncInvoker<UpdateRetentionResponse> UpdateRetentionAsyncInvoker(UpdateRetentionRequest updateRetentionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRetentionRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(updateRetentionRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(updateRetentionRequest.RetentionId, out var valueOfRetentionId)) urlParam.Add("retention_id", valueOfRetentionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions/{retention_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRetentionRequest);
            return new AsyncInvoker<UpdateRetentionResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<UpdateRetentionResponse>);
        }
        
        /// <summary>
        /// 更新触发器配置
        ///
        /// 更新触发器配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateTriggerResponse> UpdateTriggerAsync(UpdateTriggerRequest updateTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTriggerRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(updateTriggerRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(updateTriggerRequest.Trigger, out var valueOfTrigger)) urlParam.Add("trigger", valueOfTrigger);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers/{trigger}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTriggerRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerializeNull<UpdateTriggerResponse>(response);
        }

        public AsyncInvoker<UpdateTriggerResponse> UpdateTriggerAsyncInvoker(UpdateTriggerRequest updateTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTriggerRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(updateTriggerRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            if (StringUtils.TryConvertToNonEmptyString(updateTriggerRequest.Trigger, out var valueOfTrigger)) urlParam.Add("trigger", valueOfTrigger);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers/{trigger}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTriggerRequest);
            return new AsyncInvoker<UpdateTriggerResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<UpdateTriggerResponse>);
        }
        
        /// <summary>
        /// 更新镜像权限
        ///
        /// 更新镜像权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateUserRepositoryAuthResponse> UpdateUserRepositoryAuthAsync(UpdateUserRepositoryAuthRequest updateUserRepositoryAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateUserRepositoryAuthRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(updateUserRepositoryAuthRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserRepositoryAuthRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerializeNull<UpdateUserRepositoryAuthResponse>(response);
        }

        public AsyncInvoker<UpdateUserRepositoryAuthResponse> UpdateUserRepositoryAuthAsyncInvoker(UpdateUserRepositoryAuthRequest updateUserRepositoryAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateUserRepositoryAuthRequest.Namespace, out var valueOfNamespace)) urlParam.Add("namespace", valueOfNamespace);
            if (StringUtils.TryConvertToNonEmptyString(updateUserRepositoryAuthRequest.Repository, out var valueOfRepository)) urlParam.Add("repository", valueOfRepository);
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserRepositoryAuthRequest);
            return new AsyncInvoker<UpdateUserRepositoryAuthResponse>(this, "PATCH", request, JsonUtils.DeSerializeNull<UpdateUserRepositoryAuthResponse>);
        }
        
        /// <summary>
        /// 查询所有API版本信息
        ///
        /// 查询所有API版本信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListApiVersionsResponse> ListApiVersionsAsync(ListApiVersionsRequest listApiVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListApiVersionsResponse>(response);
        }

        public AsyncInvoker<ListApiVersionsResponse> ListApiVersionsAsyncInvoker(ListApiVersionsRequest listApiVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionsRequest);
            return new AsyncInvoker<ListApiVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApiVersionsResponse>);
        }
        
        /// <summary>
        /// 查询指定API版本信息
        ///
        /// 查询指定API版本信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowApiVersionResponse> ShowApiVersionAsync(ShowApiVersionRequest showApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showApiVersionRequest.ApiVersion, out var valueOfApiVersion)) urlParam.Add("api_version", valueOfApiVersion);
            var urlPath = HttpUtils.AddUrlPath("/{api_version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowApiVersionResponse>(response);
        }

        public AsyncInvoker<ShowApiVersionResponse> ShowApiVersionAsyncInvoker(ShowApiVersionRequest showApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showApiVersionRequest.ApiVersion, out var valueOfApiVersion)) urlParam.Add("api_version", valueOfApiVersion);
            var urlPath = HttpUtils.AddUrlPath("/{api_version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            return new AsyncInvoker<ShowApiVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowApiVersionResponse>);
        }
        
        /// <summary>
        /// 增加域名
        ///
        /// 增加域名
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddDomainNameResponse> AddDomainNameAsync(AddDomainNameRequest addDomainNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addDomainNameRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/domainname", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDomainNameRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddDomainNameResponse>(response);
        }

        public AsyncInvoker<AddDomainNameResponse> AddDomainNameAsyncInvoker(AddDomainNameRequest addDomainNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addDomainNameRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/domainname", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDomainNameRequest);
            return new AsyncInvoker<AddDomainNameResponse>(this, "POST", request, JsonUtils.DeSerialize<AddDomainNameResponse>);
        }
        
        /// <summary>
        /// 创建不可变Tag策略
        ///
        /// 创建不可变Tag策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateImmutableRuleResponse> CreateImmutableRuleAsync(CreateImmutableRuleRequest createImmutableRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createImmutableRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(createImmutableRuleRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/immutabletagrules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createImmutableRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateImmutableRuleResponse>(response);
        }

        public AsyncInvoker<CreateImmutableRuleResponse> CreateImmutableRuleAsyncInvoker(CreateImmutableRuleRequest createImmutableRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createImmutableRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(createImmutableRuleRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/immutabletagrules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createImmutableRuleRequest);
            return new AsyncInvoker<CreateImmutableRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateImmutableRuleResponse>);
        }
        
        /// <summary>
        /// 创建实例
        ///
        /// 创建企业仓库实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest createInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceResponse>(response);
        }

        public AsyncInvoker<CreateInstanceResponse> CreateInstanceAsyncInvoker(CreateInstanceRequest createInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceRequest);
            return new AsyncInvoker<CreateInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceResponse>);
        }
        
        /// <summary>
        /// 开启或关闭公网访问
        ///
        /// 开启或关闭公网访问
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInstanceEndpointPolicyResponse> CreateInstanceEndpointPolicyAsync(CreateInstanceEndpointPolicyRequest createInstanceEndpointPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceEndpointPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/endpoint-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceEndpointPolicyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateInstanceEndpointPolicyResponse>(response);
        }

        public AsyncInvoker<CreateInstanceEndpointPolicyResponse> CreateInstanceEndpointPolicyAsyncInvoker(CreateInstanceEndpointPolicyRequest createInstanceEndpointPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceEndpointPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/endpoint-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceEndpointPolicyRequest);
            return new AsyncInvoker<CreateInstanceEndpointPolicyResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateInstanceEndpointPolicyResponse>);
        }
        
        /// <summary>
        /// 新增内网访问
        ///
        /// 新增内网访问
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInstanceInternalEndpointResponse> CreateInstanceInternalEndpointAsync(CreateInstanceInternalEndpointRequest createInstanceInternalEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceInternalEndpointRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/internal-endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceInternalEndpointRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceInternalEndpointResponse>(response);
        }

        public AsyncInvoker<CreateInstanceInternalEndpointResponse> CreateInstanceInternalEndpointAsyncInvoker(CreateInstanceInternalEndpointRequest createInstanceInternalEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceInternalEndpointRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/internal-endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceInternalEndpointRequest);
            return new AsyncInvoker<CreateInstanceInternalEndpointResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceInternalEndpointResponse>);
        }
        
        /// <summary>
        /// 创建长期访问凭证
        ///
        /// 创建长期访问凭证
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInstanceLtCredentialResponse> CreateInstanceLtCredentialAsync(CreateInstanceLtCredentialRequest createInstanceLtCredentialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceLtCredentialRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/long-term-credential", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceLtCredentialRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceLtCredentialResponse>(response);
        }

        public AsyncInvoker<CreateInstanceLtCredentialResponse> CreateInstanceLtCredentialAsyncInvoker(CreateInstanceLtCredentialRequest createInstanceLtCredentialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceLtCredentialRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/long-term-credential", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceLtCredentialRequest);
            return new AsyncInvoker<CreateInstanceLtCredentialResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceLtCredentialResponse>);
        }
        
        /// <summary>
        /// 创建命名空间
        ///
        /// 创建命名空间
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInstanceNamespaceResponse> CreateInstanceNamespaceAsync(CreateInstanceNamespaceRequest createInstanceNamespaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceNamespaceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceNamespaceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceNamespaceResponse>(response);
        }

        public AsyncInvoker<CreateInstanceNamespaceResponse> CreateInstanceNamespaceAsyncInvoker(CreateInstanceNamespaceRequest createInstanceNamespaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceNamespaceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceNamespaceRequest);
            return new AsyncInvoker<CreateInstanceNamespaceResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceNamespaceResponse>);
        }
        
        /// <summary>
        /// 创建镜像同步的目标仓库
        ///
        /// 创建镜像同步的目标仓库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInstanceRegistryResponse> CreateInstanceRegistryAsync(CreateInstanceRegistryRequest createInstanceRegistryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceRegistryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/registries", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceRegistryRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceRegistryResponse>(response);
        }

        public AsyncInvoker<CreateInstanceRegistryResponse> CreateInstanceRegistryAsyncInvoker(CreateInstanceRegistryRequest createInstanceRegistryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceRegistryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/registries", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceRegistryRequest);
            return new AsyncInvoker<CreateInstanceRegistryResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceRegistryResponse>);
        }
        
        /// <summary>
        /// 创建镜像同步策略
        ///
        /// 创建镜像同步策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInstanceReplicationPolicyResponse> CreateInstanceReplicationPolicyAsync(CreateInstanceReplicationPolicyRequest createInstanceReplicationPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceReplicationPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceReplicationPolicyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceReplicationPolicyResponse>(response);
        }

        public AsyncInvoker<CreateInstanceReplicationPolicyResponse> CreateInstanceReplicationPolicyAsyncInvoker(CreateInstanceReplicationPolicyRequest createInstanceReplicationPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceReplicationPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceReplicationPolicyRequest);
            return new AsyncInvoker<CreateInstanceReplicationPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceReplicationPolicyResponse>);
        }
        
        /// <summary>
        /// 批量添加资源标签
        ///
        /// 批量添加资源标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInstanceResourceTagsResponse> CreateInstanceResourceTagsAsync(CreateInstanceResourceTagsRequest createInstanceResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(createInstanceResourceTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceResourceTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateInstanceResourceTagsResponse>(response);
        }

        public AsyncInvoker<CreateInstanceResourceTagsResponse> CreateInstanceResourceTagsAsyncInvoker(CreateInstanceResourceTagsRequest createInstanceResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(createInstanceResourceTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceResourceTagsRequest);
            return new AsyncInvoker<CreateInstanceResourceTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateInstanceResourceTagsResponse>);
        }
        
        /// <summary>
        /// 创建老化策略
        ///
        /// 创建老化策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInstanceRetentionPolicyResponse> CreateInstanceRetentionPolicyAsync(CreateInstanceRetentionPolicyRequest createInstanceRetentionPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceRetentionPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(createInstanceRetentionPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/retention/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceRetentionPolicyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceRetentionPolicyResponse>(response);
        }

        public AsyncInvoker<CreateInstanceRetentionPolicyResponse> CreateInstanceRetentionPolicyAsyncInvoker(CreateInstanceRetentionPolicyRequest createInstanceRetentionPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceRetentionPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(createInstanceRetentionPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/retention/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceRetentionPolicyRequest);
            return new AsyncInvoker<CreateInstanceRetentionPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceRetentionPolicyResponse>);
        }
        
        /// <summary>
        /// 创建签名策略
        ///
        /// 创建签名策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInstanceSignPolicyResponse> CreateInstanceSignPolicyAsync(CreateInstanceSignPolicyRequest createInstanceSignPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceSignPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(createInstanceSignPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/signature/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceSignPolicyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceSignPolicyResponse>(response);
        }

        public AsyncInvoker<CreateInstanceSignPolicyResponse> CreateInstanceSignPolicyAsyncInvoker(CreateInstanceSignPolicyRequest createInstanceSignPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceSignPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(createInstanceSignPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/signature/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceSignPolicyRequest);
            return new AsyncInvoker<CreateInstanceSignPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceSignPolicyResponse>);
        }
        
        /// <summary>
        /// 获取临时访问凭证
        ///
        /// 获取临时访问凭证
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInstanceTempCredentialResponse> CreateInstanceTempCredentialAsync(CreateInstanceTempCredentialRequest createInstanceTempCredentialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceTempCredentialRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/temp-credential", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceTempCredentialRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceTempCredentialResponse>(response);
        }

        public AsyncInvoker<CreateInstanceTempCredentialResponse> CreateInstanceTempCredentialAsyncInvoker(CreateInstanceTempCredentialRequest createInstanceTempCredentialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceTempCredentialRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/temp-credential", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceTempCredentialRequest);
            return new AsyncInvoker<CreateInstanceTempCredentialResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceTempCredentialResponse>);
        }
        
        /// <summary>
        /// 创建触发器
        ///
        /// 创建触发器
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateInstanceWebhookResponse> CreateInstanceWebhookAsync(CreateInstanceWebhookRequest createInstanceWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceWebhookRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(createInstanceWebhookRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/webhook/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceWebhookRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateInstanceWebhookResponse>(response);
        }

        public AsyncInvoker<CreateInstanceWebhookResponse> CreateInstanceWebhookAsyncInvoker(CreateInstanceWebhookRequest createInstanceWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createInstanceWebhookRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(createInstanceWebhookRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/webhook/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInstanceWebhookRequest);
            return new AsyncInvoker<CreateInstanceWebhookResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInstanceWebhookResponse>);
        }
        
        /// <summary>
        /// 批量添加子资源标签
        ///
        /// 批量添加子资源标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSubResourceTagsResponse> CreateSubResourceTagsAsync(CreateSubResourceTagsRequest createSubResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createSubResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(createSubResourceTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            if (StringUtils.TryConvertToNonEmptyString(createSubResourceTagsRequest.SubResourceType, out var valueOfSubResourceType)) urlParam.Add("sub_resource_type", valueOfSubResourceType);
            if (StringUtils.TryConvertToNonEmptyString(createSubResourceTagsRequest.SubResourceId, out var valueOfSubResourceId)) urlParam.Add("sub_resource_id", valueOfSubResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/{sub_resource_type}/{sub_resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSubResourceTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateSubResourceTagsResponse>(response);
        }

        public AsyncInvoker<CreateSubResourceTagsResponse> CreateSubResourceTagsAsyncInvoker(CreateSubResourceTagsRequest createSubResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createSubResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(createSubResourceTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            if (StringUtils.TryConvertToNonEmptyString(createSubResourceTagsRequest.SubResourceType, out var valueOfSubResourceType)) urlParam.Add("sub_resource_type", valueOfSubResourceType);
            if (StringUtils.TryConvertToNonEmptyString(createSubResourceTagsRequest.SubResourceId, out var valueOfSubResourceId)) urlParam.Add("sub_resource_id", valueOfSubResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/{sub_resource_type}/{sub_resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSubResourceTagsRequest);
            return new AsyncInvoker<CreateSubResourceTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateSubResourceTagsResponse>);
        }
        
        /// <summary>
        /// 删除域名
        ///
        /// 删除域名，SWR企业仓库的默认域名无法删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDomainNameResponse> DeleteDomainNameAsync(DeleteDomainNameRequest deleteDomainNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDomainNameRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteDomainNameRequest.DomainnameId, out var valueOfDomainnameId)) urlParam.Add("domainname_id", valueOfDomainnameId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/domainname/{domainname_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainNameRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDomainNameResponse>(response);
        }

        public AsyncInvoker<DeleteDomainNameResponse> DeleteDomainNameAsyncInvoker(DeleteDomainNameRequest deleteDomainNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDomainNameRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteDomainNameRequest.DomainnameId, out var valueOfDomainnameId)) urlParam.Add("domainname_id", valueOfDomainnameId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/domainname/{domainname_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainNameRequest);
            return new AsyncInvoker<DeleteDomainNameResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDomainNameResponse>);
        }
        
        /// <summary>
        /// 删除不可变Tag策略
        ///
        /// 删除不可变Tag策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteImmutableRuleResponse> DeleteImmutableRuleAsync(DeleteImmutableRuleRequest deleteImmutableRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteImmutableRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteImmutableRuleRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(deleteImmutableRuleRequest.ImmutableRuleId, out var valueOfImmutableRuleId)) urlParam.Add("immutable_rule_id", valueOfImmutableRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/immutabletagrules/{immutable_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteImmutableRuleRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteImmutableRuleResponse>(response);
        }

        public AsyncInvoker<DeleteImmutableRuleResponse> DeleteImmutableRuleAsyncInvoker(DeleteImmutableRuleRequest deleteImmutableRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteImmutableRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteImmutableRuleRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(deleteImmutableRuleRequest.ImmutableRuleId, out var valueOfImmutableRuleId)) urlParam.Add("immutable_rule_id", valueOfImmutableRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/immutabletagrules/{immutable_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteImmutableRuleRequest);
            return new AsyncInvoker<DeleteImmutableRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteImmutableRuleResponse>);
        }
        
        /// <summary>
        /// 删除实例
        ///
        /// 删除实例
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest deleteInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceResponse>(response);
        }

        public AsyncInvoker<DeleteInstanceResponse> DeleteInstanceAsyncInvoker(DeleteInstanceRequest deleteInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRequest);
            return new AsyncInvoker<DeleteInstanceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceResponse>);
        }
        
        /// <summary>
        /// 删除制品版本
        ///
        /// 删除制品版本
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInstanceArtifactResponse> DeleteInstanceArtifactAsync(DeleteInstanceArtifactRequest deleteInstanceArtifactRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceArtifactRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceArtifactRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceArtifactRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceArtifactRequest.Reference, out var valueOfReference)) urlParam.Add("reference", valueOfReference);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}/artifacts/{reference}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceArtifactRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceArtifactResponse>(response);
        }

        public AsyncInvoker<DeleteInstanceArtifactResponse> DeleteInstanceArtifactAsyncInvoker(DeleteInstanceArtifactRequest deleteInstanceArtifactRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceArtifactRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceArtifactRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceArtifactRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceArtifactRequest.Reference, out var valueOfReference)) urlParam.Add("reference", valueOfReference);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}/artifacts/{reference}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceArtifactRequest);
            return new AsyncInvoker<DeleteInstanceArtifactResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceArtifactResponse>);
        }
        
        /// <summary>
        /// 删除内网访问
        ///
        /// 删除内网访问
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInstanceInternalEndpointResponse> DeleteInstanceInternalEndpointAsync(DeleteInstanceInternalEndpointRequest deleteInstanceInternalEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceInternalEndpointRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceInternalEndpointRequest.InternalEndpointsId, out var valueOfInternalEndpointsId)) urlParam.Add("internal_endpoints_id", valueOfInternalEndpointsId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/internal-endpoints/{internal_endpoints_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceInternalEndpointRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceInternalEndpointResponse>(response);
        }

        public AsyncInvoker<DeleteInstanceInternalEndpointResponse> DeleteInstanceInternalEndpointAsyncInvoker(DeleteInstanceInternalEndpointRequest deleteInstanceInternalEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceInternalEndpointRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceInternalEndpointRequest.InternalEndpointsId, out var valueOfInternalEndpointsId)) urlParam.Add("internal_endpoints_id", valueOfInternalEndpointsId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/internal-endpoints/{internal_endpoints_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceInternalEndpointRequest);
            return new AsyncInvoker<DeleteInstanceInternalEndpointResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceInternalEndpointResponse>);
        }
        
        /// <summary>
        /// 删除任务
        ///
        /// 删除任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInstanceJobResponse> DeleteInstanceJobAsync(DeleteInstanceJobRequest deleteInstanceJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceJobRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceJobResponse>(response);
        }

        public AsyncInvoker<DeleteInstanceJobResponse> DeleteInstanceJobAsyncInvoker(DeleteInstanceJobRequest deleteInstanceJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceJobRequest);
            return new AsyncInvoker<DeleteInstanceJobResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceJobResponse>);
        }
        
        /// <summary>
        /// 删除长期访问凭证
        ///
        /// 删除长期访问凭证
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInstanceLtCredentialResponse> DeleteInstanceLtCredentialAsync(DeleteInstanceLtCredentialRequest deleteInstanceLtCredentialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceLtCredentialRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceLtCredentialRequest.CredentialId, out var valueOfCredentialId)) urlParam.Add("credential_id", valueOfCredentialId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/long-term-credentials/{credential_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceLtCredentialRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceLtCredentialResponse>(response);
        }

        public AsyncInvoker<DeleteInstanceLtCredentialResponse> DeleteInstanceLtCredentialAsyncInvoker(DeleteInstanceLtCredentialRequest deleteInstanceLtCredentialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceLtCredentialRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceLtCredentialRequest.CredentialId, out var valueOfCredentialId)) urlParam.Add("credential_id", valueOfCredentialId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/long-term-credentials/{credential_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceLtCredentialRequest);
            return new AsyncInvoker<DeleteInstanceLtCredentialResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceLtCredentialResponse>);
        }
        
        /// <summary>
        /// 删除命名空间
        ///
        /// 删除命名空间
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInstanceNamespaceResponse> DeleteInstanceNamespaceAsync(DeleteInstanceNamespaceRequest deleteInstanceNamespaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceNamespaceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceNamespaceRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceNamespaceRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceNamespaceResponse>(response);
        }

        public AsyncInvoker<DeleteInstanceNamespaceResponse> DeleteInstanceNamespaceAsyncInvoker(DeleteInstanceNamespaceRequest deleteInstanceNamespaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceNamespaceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceNamespaceRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceNamespaceRequest);
            return new AsyncInvoker<DeleteInstanceNamespaceResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceNamespaceResponse>);
        }
        
        /// <summary>
        /// 删除镜像同步的目标仓库
        ///
        /// 删除同步仓库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInstanceRegistryResponse> DeleteInstanceRegistryAsync(DeleteInstanceRegistryRequest deleteInstanceRegistryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRegistryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRegistryRequest.RegistryId, out var valueOfRegistryId)) urlParam.Add("registry_id", valueOfRegistryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/registries/{registry_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRegistryRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceRegistryResponse>(response);
        }

        public AsyncInvoker<DeleteInstanceRegistryResponse> DeleteInstanceRegistryAsyncInvoker(DeleteInstanceRegistryRequest deleteInstanceRegistryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRegistryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRegistryRequest.RegistryId, out var valueOfRegistryId)) urlParam.Add("registry_id", valueOfRegistryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/registries/{registry_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRegistryRequest);
            return new AsyncInvoker<DeleteInstanceRegistryResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceRegistryResponse>);
        }
        
        /// <summary>
        /// 删除镜像同步策略
        ///
        /// 删除镜像同步策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInstanceReplicationPolicyResponse> DeleteInstanceReplicationPolicyAsync(DeleteInstanceReplicationPolicyRequest deleteInstanceReplicationPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceReplicationPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceReplicationPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceReplicationPolicyRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceReplicationPolicyResponse>(response);
        }

        public AsyncInvoker<DeleteInstanceReplicationPolicyResponse> DeleteInstanceReplicationPolicyAsyncInvoker(DeleteInstanceReplicationPolicyRequest deleteInstanceReplicationPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceReplicationPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceReplicationPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceReplicationPolicyRequest);
            return new AsyncInvoker<DeleteInstanceReplicationPolicyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceReplicationPolicyResponse>);
        }
        
        /// <summary>
        /// 删除制品仓库
        ///
        /// 删除仓库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInstanceRepositoryResponse> DeleteInstanceRepositoryAsync(DeleteInstanceRepositoryRequest deleteInstanceRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRepositoryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRepositoryRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRepositoryRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRepositoryRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceRepositoryResponse>(response);
        }

        public AsyncInvoker<DeleteInstanceRepositoryResponse> DeleteInstanceRepositoryAsyncInvoker(DeleteInstanceRepositoryRequest deleteInstanceRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRepositoryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRepositoryRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRepositoryRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRepositoryRequest);
            return new AsyncInvoker<DeleteInstanceRepositoryResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceRepositoryResponse>);
        }
        
        /// <summary>
        /// 批量删除资源标签
        ///
        /// 批量删除资源标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInstanceResourceTagsResponse> DeleteInstanceResourceTagsAsync(DeleteInstanceResourceTagsRequest deleteInstanceResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceResourceTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceResourceTagsRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceResourceTagsResponse>(response);
        }

        public AsyncInvoker<DeleteInstanceResourceTagsResponse> DeleteInstanceResourceTagsAsyncInvoker(DeleteInstanceResourceTagsRequest deleteInstanceResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceResourceTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceResourceTagsRequest);
            return new AsyncInvoker<DeleteInstanceResourceTagsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceResourceTagsResponse>);
        }
        
        /// <summary>
        /// 删除老化策略
        ///
        /// 删除老化策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInstanceRetentionPolicyResponse> DeleteInstanceRetentionPolicyAsync(DeleteInstanceRetentionPolicyRequest deleteInstanceRetentionPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRetentionPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRetentionPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRetentionPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/retention/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRetentionPolicyRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceRetentionPolicyResponse>(response);
        }

        public AsyncInvoker<DeleteInstanceRetentionPolicyResponse> DeleteInstanceRetentionPolicyAsyncInvoker(DeleteInstanceRetentionPolicyRequest deleteInstanceRetentionPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRetentionPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRetentionPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceRetentionPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/retention/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceRetentionPolicyRequest);
            return new AsyncInvoker<DeleteInstanceRetentionPolicyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceRetentionPolicyResponse>);
        }
        
        /// <summary>
        /// 删除签名策略
        ///
        /// 删除签名策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInstanceSignPolicyResponse> DeleteInstanceSignPolicyAsync(DeleteInstanceSignPolicyRequest deleteInstanceSignPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceSignPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceSignPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceSignPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/signature/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceSignPolicyRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceSignPolicyResponse>(response);
        }

        public AsyncInvoker<DeleteInstanceSignPolicyResponse> DeleteInstanceSignPolicyAsyncInvoker(DeleteInstanceSignPolicyRequest deleteInstanceSignPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceSignPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceSignPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceSignPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/signature/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceSignPolicyRequest);
            return new AsyncInvoker<DeleteInstanceSignPolicyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceSignPolicyResponse>);
        }
        
        /// <summary>
        /// 删除制品的Tag
        ///
        /// 删除制品Tag
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInstanceTagResponse> DeleteInstanceTagAsync(DeleteInstanceTagRequest deleteInstanceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceTagRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceTagRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceTagRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceTagRequest.TagName, out var valueOfTagName)) urlParam.Add("tag_name", valueOfTagName);
            var urlPath = HttpUtils.AddUrlPath("/v2/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}/tags/{tag_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceTagRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceTagResponse>(response);
        }

        public AsyncInvoker<DeleteInstanceTagResponse> DeleteInstanceTagAsyncInvoker(DeleteInstanceTagRequest deleteInstanceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceTagRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceTagRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceTagRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceTagRequest.TagName, out var valueOfTagName)) urlParam.Add("tag_name", valueOfTagName);
            var urlPath = HttpUtils.AddUrlPath("/v2/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}/tags/{tag_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceTagRequest);
            return new AsyncInvoker<DeleteInstanceTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceTagResponse>);
        }
        
        /// <summary>
        /// 删除触发器
        ///
        /// 删除触发器
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteInstanceWebhookResponse> DeleteInstanceWebhookAsync(DeleteInstanceWebhookRequest deleteInstanceWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceWebhookRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceWebhookRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceWebhookRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/webhook/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceWebhookRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInstanceWebhookResponse>(response);
        }

        public AsyncInvoker<DeleteInstanceWebhookResponse> DeleteInstanceWebhookAsyncInvoker(DeleteInstanceWebhookRequest deleteInstanceWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceWebhookRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceWebhookRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(deleteInstanceWebhookRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/webhook/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInstanceWebhookRequest);
            return new AsyncInvoker<DeleteInstanceWebhookResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInstanceWebhookResponse>);
        }
        
        /// <summary>
        /// 批量删除子资源标签
        ///
        /// 批量删除子资源标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSubResourceTagsResponse> DeleteSubResourceTagsAsync(DeleteSubResourceTagsRequest deleteSubResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSubResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(deleteSubResourceTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteSubResourceTagsRequest.SubResourceType, out var valueOfSubResourceType)) urlParam.Add("sub_resource_type", valueOfSubResourceType);
            if (StringUtils.TryConvertToNonEmptyString(deleteSubResourceTagsRequest.SubResourceId, out var valueOfSubResourceId)) urlParam.Add("sub_resource_id", valueOfSubResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/{sub_resource_type}/{sub_resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubResourceTagsRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSubResourceTagsResponse>(response);
        }

        public AsyncInvoker<DeleteSubResourceTagsResponse> DeleteSubResourceTagsAsyncInvoker(DeleteSubResourceTagsRequest deleteSubResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSubResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(deleteSubResourceTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            if (StringUtils.TryConvertToNonEmptyString(deleteSubResourceTagsRequest.SubResourceType, out var valueOfSubResourceType)) urlParam.Add("sub_resource_type", valueOfSubResourceType);
            if (StringUtils.TryConvertToNonEmptyString(deleteSubResourceTagsRequest.SubResourceId, out var valueOfSubResourceId)) urlParam.Add("sub_resource_id", valueOfSubResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/{sub_resource_type}/{sub_resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubResourceTagsRequest);
            return new AsyncInvoker<DeleteSubResourceTagsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSubResourceTagsResponse>);
        }
        
        /// <summary>
        /// 手动执行镜像同步策略
        ///
        /// 手动执行同步策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExecuteInstanceReplicationPolicyResponse> ExecuteInstanceReplicationPolicyAsync(ExecuteInstanceReplicationPolicyRequest executeInstanceReplicationPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeInstanceReplicationPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeInstanceReplicationPolicyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExecuteInstanceReplicationPolicyResponse>(response);
        }

        public AsyncInvoker<ExecuteInstanceReplicationPolicyResponse> ExecuteInstanceReplicationPolicyAsyncInvoker(ExecuteInstanceReplicationPolicyRequest executeInstanceReplicationPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeInstanceReplicationPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeInstanceReplicationPolicyRequest);
            return new AsyncInvoker<ExecuteInstanceReplicationPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteInstanceReplicationPolicyResponse>);
        }
        
        /// <summary>
        /// 执行老化策略
        ///
        /// 执行老化策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExecuteInstanceRetentionPolicyResponse> ExecuteInstanceRetentionPolicyAsync(ExecuteInstanceRetentionPolicyRequest executeInstanceRetentionPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeInstanceRetentionPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(executeInstanceRetentionPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(executeInstanceRetentionPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/retention/policies/{policy_id}/executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeInstanceRetentionPolicyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExecuteInstanceRetentionPolicyResponse>(response);
        }

        public AsyncInvoker<ExecuteInstanceRetentionPolicyResponse> ExecuteInstanceRetentionPolicyAsyncInvoker(ExecuteInstanceRetentionPolicyRequest executeInstanceRetentionPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeInstanceRetentionPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(executeInstanceRetentionPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(executeInstanceRetentionPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/retention/policies/{policy_id}/executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeInstanceRetentionPolicyRequest);
            return new AsyncInvoker<ExecuteInstanceRetentionPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteInstanceRetentionPolicyResponse>);
        }
        
        /// <summary>
        /// 手动执行签名策略
        ///
        /// 手动执行签名策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExecuteInstanceSignPolicyResponse> ExecuteInstanceSignPolicyAsync(ExecuteInstanceSignPolicyRequest executeInstanceSignPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeInstanceSignPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(executeInstanceSignPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(executeInstanceSignPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/signature/policies/{policy_id}/executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeInstanceSignPolicyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExecuteInstanceSignPolicyResponse>(response);
        }

        public AsyncInvoker<ExecuteInstanceSignPolicyResponse> ExecuteInstanceSignPolicyAsyncInvoker(ExecuteInstanceSignPolicyRequest executeInstanceSignPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeInstanceSignPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(executeInstanceSignPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(executeInstanceSignPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/signature/policies/{policy_id}/executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeInstanceSignPolicyRequest);
            return new AsyncInvoker<ExecuteInstanceSignPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteInstanceSignPolicyResponse>);
        }
        
        /// <summary>
        /// 获取上传下载的相关审计日志列表
        ///
        /// 获取上传下载的相关审计日志列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAuditLogsResponse> ListAuditLogsAsync(ListAuditLogsRequest listAuditLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditLogsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/audit-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditLogsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAuditLogsResponse>(response);
        }

        public AsyncInvoker<ListAuditLogsResponse> ListAuditLogsAsyncInvoker(ListAuditLogsRequest listAuditLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAuditLogsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/audit-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAuditLogsRequest);
            return new AsyncInvoker<ListAuditLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAuditLogsResponse>);
        }
        
        /// <summary>
        /// 查询所有域名列表
        ///
        /// 查询当前实例的所有域名
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDomainNamesResponse> ListDomainNamesAsync(ListDomainNamesRequest listDomainNamesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDomainNamesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/domainname", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainNamesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDomainNamesResponse>(response);
        }

        public AsyncInvoker<ListDomainNamesResponse> ListDomainNamesAsyncInvoker(ListDomainNamesRequest listDomainNamesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDomainNamesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/domainname", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainNamesRequest);
            return new AsyncInvoker<ListDomainNamesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainNamesResponse>);
        }
        
        /// <summary>
        /// 查询特性开关信息
        ///
        /// 查询特性开关信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFeatureGatesResponse> ListFeatureGatesAsync(ListFeatureGatesRequest listFeatureGatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFeatureGatesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/feature-gates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFeatureGatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListFeatureGatesResponse>(response);
        }

        public AsyncInvoker<ListFeatureGatesResponse> ListFeatureGatesAsyncInvoker(ListFeatureGatesRequest listFeatureGatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFeatureGatesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/feature-gates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFeatureGatesRequest);
            return new AsyncInvoker<ListFeatureGatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFeatureGatesResponse>);
        }
        
        /// <summary>
        /// 查询全局特性开关信息
        ///
        /// 查询全局特性开关信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGlobalFeatureGatesResponse> ListGlobalFeatureGatesAsync(ListGlobalFeatureGatesRequest listGlobalFeatureGatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/feature-gates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalFeatureGatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGlobalFeatureGatesResponse>(response);
        }

        public AsyncInvoker<ListGlobalFeatureGatesResponse> ListGlobalFeatureGatesAsyncInvoker(ListGlobalFeatureGatesRequest listGlobalFeatureGatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/feature-gates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGlobalFeatureGatesRequest);
            return new AsyncInvoker<ListGlobalFeatureGatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGlobalFeatureGatesResponse>);
        }
        
        /// <summary>
        /// 获取不可变Tag策略列表
        ///
        /// 获取不可变Tag策略列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListImmutableRulesResponse> ListImmutableRulesAsync(ListImmutableRulesRequest listImmutableRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listImmutableRulesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/immutabletagrules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImmutableRulesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListImmutableRulesResponse>(response);
        }

        public AsyncInvoker<ListImmutableRulesResponse> ListImmutableRulesAsyncInvoker(ListImmutableRulesRequest listImmutableRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listImmutableRulesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/immutabletagrules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImmutableRulesRequest);
            return new AsyncInvoker<ListImmutableRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListImmutableRulesResponse>);
        }
        
        /// <summary>
        /// 查询实例列表
        ///
        /// 查询实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceResponse> ListInstanceAsync(ListInstanceRequest listInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceResponse>(response);
        }

        public AsyncInvoker<ListInstanceResponse> ListInstanceAsyncInvoker(ListInstanceRequest listInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceRequest);
            return new AsyncInvoker<ListInstanceResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceResponse>);
        }
        
        /// <summary>
        /// 获取制品附件列表
        ///
        /// 获取制品附件列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceAccessoriesResponse> ListInstanceAccessoriesAsync(ListInstanceAccessoriesRequest listInstanceAccessoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceAccessoriesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceAccessoriesRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceAccessoriesRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceAccessoriesRequest.Reference, out var valueOfReference)) urlParam.Add("reference", valueOfReference);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}/artifacts/{reference}/accessories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceAccessoriesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceAccessoriesResponse>(response);
        }

        public AsyncInvoker<ListInstanceAccessoriesResponse> ListInstanceAccessoriesAsyncInvoker(ListInstanceAccessoriesRequest listInstanceAccessoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceAccessoriesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceAccessoriesRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceAccessoriesRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceAccessoriesRequest.Reference, out var valueOfReference)) urlParam.Add("reference", valueOfReference);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}/artifacts/{reference}/accessories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceAccessoriesRequest);
            return new AsyncInvoker<ListInstanceAccessoriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceAccessoriesResponse>);
        }
        
        /// <summary>
        /// 获取仓库实例的所有制品版本列表
        ///
        /// 获取仓库实例的所有制品版本列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceAllArtifactsResponse> ListInstanceAllArtifactsAsync(ListInstanceAllArtifactsRequest listInstanceAllArtifactsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceAllArtifactsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/artifacts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceAllArtifactsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceAllArtifactsResponse>(response);
        }

        public AsyncInvoker<ListInstanceAllArtifactsResponse> ListInstanceAllArtifactsAsyncInvoker(ListInstanceAllArtifactsRequest listInstanceAllArtifactsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceAllArtifactsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/artifacts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceAllArtifactsRequest);
            return new AsyncInvoker<ListInstanceAllArtifactsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceAllArtifactsResponse>);
        }
        
        /// <summary>
        /// 获取制品版本列表
        ///
        /// 获取制品版本列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceArtifactsResponse> ListInstanceArtifactsAsync(ListInstanceArtifactsRequest listInstanceArtifactsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceArtifactsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceArtifactsRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceArtifactsRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}/artifacts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceArtifactsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceArtifactsResponse>(response);
        }

        public AsyncInvoker<ListInstanceArtifactsResponse> ListInstanceArtifactsAsyncInvoker(ListInstanceArtifactsRequest listInstanceArtifactsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceArtifactsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceArtifactsRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceArtifactsRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}/artifacts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceArtifactsRequest);
            return new AsyncInvoker<ListInstanceArtifactsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceArtifactsResponse>);
        }
        
        /// <summary>
        /// 获取内网访问列表
        ///
        /// 获取内网访问列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceInternalEndpointsResponse> ListInstanceInternalEndpointsAsync(ListInstanceInternalEndpointsRequest listInstanceInternalEndpointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceInternalEndpointsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/internal-endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceInternalEndpointsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceInternalEndpointsResponse>(response);
        }

        public AsyncInvoker<ListInstanceInternalEndpointsResponse> ListInstanceInternalEndpointsAsyncInvoker(ListInstanceInternalEndpointsRequest listInstanceInternalEndpointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceInternalEndpointsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/internal-endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceInternalEndpointsRequest);
            return new AsyncInvoker<ListInstanceInternalEndpointsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceInternalEndpointsResponse>);
        }
        
        /// <summary>
        /// 获取任务列表
        ///
        /// 获取任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceJobsResponse> ListInstanceJobsAsync(ListInstanceJobsRequest listInstanceJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceJobsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceJobsResponse>(response);
        }

        public AsyncInvoker<ListInstanceJobsResponse> ListInstanceJobsAsyncInvoker(ListInstanceJobsRequest listInstanceJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceJobsRequest);
            return new AsyncInvoker<ListInstanceJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceJobsResponse>);
        }
        
        /// <summary>
        /// 查询长期访问凭证列表
        ///
        /// 查询长期访问凭证列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceLtCredentialsResponse> ListInstanceLtCredentialsAsync(ListInstanceLtCredentialsRequest listInstanceLtCredentialsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceLtCredentialsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/long-term-credentials", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceLtCredentialsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceLtCredentialsResponse>(response);
        }

        public AsyncInvoker<ListInstanceLtCredentialsResponse> ListInstanceLtCredentialsAsyncInvoker(ListInstanceLtCredentialsRequest listInstanceLtCredentialsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceLtCredentialsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/long-term-credentials", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceLtCredentialsRequest);
            return new AsyncInvoker<ListInstanceLtCredentialsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceLtCredentialsResponse>);
        }
        
        /// <summary>
        /// 获取命名空间列表
        ///
        /// 获取命名空间列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceNamespacesResponse> ListInstanceNamespacesAsync(ListInstanceNamespacesRequest listInstanceNamespacesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceNamespacesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceNamespacesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceNamespacesResponse>(response);
        }

        public AsyncInvoker<ListInstanceNamespacesResponse> ListInstanceNamespacesAsyncInvoker(ListInstanceNamespacesRequest listInstanceNamespacesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceNamespacesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceNamespacesRequest);
            return new AsyncInvoker<ListInstanceNamespacesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceNamespacesResponse>);
        }
        
        /// <summary>
        /// 查询项目下所有实例标签
        ///
        /// 查询项目下所有实例标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceProjectTagsResponse> ListInstanceProjectTagsAsync(ListInstanceProjectTagsRequest listInstanceProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceProjectTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceProjectTagsResponse>(response);
        }

        public AsyncInvoker<ListInstanceProjectTagsResponse> ListInstanceProjectTagsAsyncInvoker(ListInstanceProjectTagsRequest listInstanceProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceProjectTagsRequest);
            return new AsyncInvoker<ListInstanceProjectTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceProjectTagsResponse>);
        }
        
        /// <summary>
        /// 获取镜像同步的目标仓库列表
        ///
        /// 获取镜像同步的目标仓库列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceRegistriesResponse> ListInstanceRegistriesAsync(ListInstanceRegistriesRequest listInstanceRegistriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRegistriesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/registries", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceRegistriesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceRegistriesResponse>(response);
        }

        public AsyncInvoker<ListInstanceRegistriesResponse> ListInstanceRegistriesAsyncInvoker(ListInstanceRegistriesRequest listInstanceRegistriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRegistriesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/registries", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceRegistriesRequest);
            return new AsyncInvoker<ListInstanceRegistriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceRegistriesResponse>);
        }
        
        /// <summary>
        /// 获取镜像同步策略列表
        ///
        /// 获取镜像同步策略列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceReplicationPoliciesResponse> ListInstanceReplicationPoliciesAsync(ListInstanceReplicationPoliciesRequest listInstanceReplicationPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceReplicationPoliciesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceReplicationPoliciesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceReplicationPoliciesResponse>(response);
        }

        public AsyncInvoker<ListInstanceReplicationPoliciesResponse> ListInstanceReplicationPoliciesAsyncInvoker(ListInstanceReplicationPoliciesRequest listInstanceReplicationPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceReplicationPoliciesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceReplicationPoliciesRequest);
            return new AsyncInvoker<ListInstanceReplicationPoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceReplicationPoliciesResponse>);
        }
        
        /// <summary>
        /// 获取镜像同步策略执行任务的镜像版本列表
        ///
        /// 获取镜像同步策略执行任务的镜像版本列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceReplicationPolicyExecSubTasksResponse> ListInstanceReplicationPolicyExecSubTasksAsync(ListInstanceReplicationPolicyExecSubTasksRequest listInstanceReplicationPolicyExecSubTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceReplicationPolicyExecSubTasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceReplicationPolicyExecSubTasksRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceReplicationPolicyExecSubTasksRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/executions/{execution_id}/tasks/{task_id}/subtasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceReplicationPolicyExecSubTasksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceReplicationPolicyExecSubTasksResponse>(response);
        }

        public AsyncInvoker<ListInstanceReplicationPolicyExecSubTasksResponse> ListInstanceReplicationPolicyExecSubTasksAsyncInvoker(ListInstanceReplicationPolicyExecSubTasksRequest listInstanceReplicationPolicyExecSubTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceReplicationPolicyExecSubTasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceReplicationPolicyExecSubTasksRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceReplicationPolicyExecSubTasksRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/executions/{execution_id}/tasks/{task_id}/subtasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceReplicationPolicyExecSubTasksRequest);
            return new AsyncInvoker<ListInstanceReplicationPolicyExecSubTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceReplicationPolicyExecSubTasksResponse>);
        }
        
        /// <summary>
        /// 获取镜像同步策略执行任务的镜像列表
        ///
        /// 获取镜像同步策略执行任务的镜像列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceReplicationPolicyExecTasksResponse> ListInstanceReplicationPolicyExecTasksAsync(ListInstanceReplicationPolicyExecTasksRequest listInstanceReplicationPolicyExecTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceReplicationPolicyExecTasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceReplicationPolicyExecTasksRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/executions/{execution_id}/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceReplicationPolicyExecTasksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceReplicationPolicyExecTasksResponse>(response);
        }

        public AsyncInvoker<ListInstanceReplicationPolicyExecTasksResponse> ListInstanceReplicationPolicyExecTasksAsyncInvoker(ListInstanceReplicationPolicyExecTasksRequest listInstanceReplicationPolicyExecTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceReplicationPolicyExecTasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceReplicationPolicyExecTasksRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/executions/{execution_id}/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceReplicationPolicyExecTasksRequest);
            return new AsyncInvoker<ListInstanceReplicationPolicyExecTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceReplicationPolicyExecTasksResponse>);
        }
        
        /// <summary>
        /// 获取镜像同步策略执行记录列表
        ///
        /// 获取镜像同步策略执行记录列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceReplicationPolicyExecutionsResponse> ListInstanceReplicationPolicyExecutionsAsync(ListInstanceReplicationPolicyExecutionsRequest listInstanceReplicationPolicyExecutionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceReplicationPolicyExecutionsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceReplicationPolicyExecutionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceReplicationPolicyExecutionsResponse>(response);
        }

        public AsyncInvoker<ListInstanceReplicationPolicyExecutionsResponse> ListInstanceReplicationPolicyExecutionsAsyncInvoker(ListInstanceReplicationPolicyExecutionsRequest listInstanceReplicationPolicyExecutionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceReplicationPolicyExecutionsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceReplicationPolicyExecutionsRequest);
            return new AsyncInvoker<ListInstanceReplicationPolicyExecutionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceReplicationPolicyExecutionsResponse>);
        }
        
        /// <summary>
        /// 获取制品仓库列表
        ///
        /// 获取制品仓库列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceRepositoriesResponse> ListInstanceRepositoriesAsync(ListInstanceRepositoriesRequest listInstanceRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRepositoriesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceRepositoriesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceRepositoriesResponse>(response);
        }

        public AsyncInvoker<ListInstanceRepositoriesResponse> ListInstanceRepositoriesAsyncInvoker(ListInstanceRepositoriesRequest listInstanceRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRepositoriesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceRepositoriesRequest);
            return new AsyncInvoker<ListInstanceRepositoriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceRepositoriesResponse>);
        }
        
        /// <summary>
        /// 按照标签检索资源列表
        ///
        /// 按照标签检索资源列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceResourceInstancesResponse> ListInstanceResourceInstancesAsync(ListInstanceResourceInstancesRequest listInstanceResourceInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceResourceInstancesRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceResourceInstancesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListInstanceResourceInstancesResponse>(response);
        }

        public AsyncInvoker<ListInstanceResourceInstancesResponse> ListInstanceResourceInstancesAsyncInvoker(ListInstanceResourceInstancesRequest listInstanceResourceInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceResourceInstancesRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceResourceInstancesRequest);
            return new AsyncInvoker<ListInstanceResourceInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListInstanceResourceInstancesResponse>);
        }
        
        /// <summary>
        /// 查询资源标签
        ///
        /// 查询资源标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceResourceTagsResponse> ListInstanceResourceTagsAsync(ListInstanceResourceTagsRequest listInstanceResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceResourceTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceResourceTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceResourceTagsResponse>(response);
        }

        public AsyncInvoker<ListInstanceResourceTagsResponse> ListInstanceResourceTagsAsyncInvoker(ListInstanceResourceTagsRequest listInstanceResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceResourceTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceResourceTagsRequest);
            return new AsyncInvoker<ListInstanceResourceTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceResourceTagsResponse>);
        }
        
        /// <summary>
        /// 获取老化策略列表
        ///
        /// 获取老化策略列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceRetentionPoliciesResponse> ListInstanceRetentionPoliciesAsync(ListInstanceRetentionPoliciesRequest listInstanceRetentionPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPoliciesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/retention/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceRetentionPoliciesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceRetentionPoliciesResponse>(response);
        }

        public AsyncInvoker<ListInstanceRetentionPoliciesResponse> ListInstanceRetentionPoliciesAsyncInvoker(ListInstanceRetentionPoliciesRequest listInstanceRetentionPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPoliciesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/retention/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceRetentionPoliciesRequest);
            return new AsyncInvoker<ListInstanceRetentionPoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceRetentionPoliciesResponse>);
        }
        
        /// <summary>
        /// 获取老化策略执行任务的镜像版本列表
        ///
        /// 获取老化策略执行任务的镜像版本列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceRetentionPolicyExecSubTasksResponse> ListInstanceRetentionPolicyExecSubTasksAsync(ListInstanceRetentionPolicyExecSubTasksRequest listInstanceRetentionPolicyExecSubTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecSubTasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecSubTasksRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecSubTasksRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecSubTasksRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecSubTasksRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/retention/policies/{policy_id}/executions/{execution_id}/tasks/{task_id}/subtasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceRetentionPolicyExecSubTasksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceRetentionPolicyExecSubTasksResponse>(response);
        }

        public AsyncInvoker<ListInstanceRetentionPolicyExecSubTasksResponse> ListInstanceRetentionPolicyExecSubTasksAsyncInvoker(ListInstanceRetentionPolicyExecSubTasksRequest listInstanceRetentionPolicyExecSubTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecSubTasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecSubTasksRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecSubTasksRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecSubTasksRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecSubTasksRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/retention/policies/{policy_id}/executions/{execution_id}/tasks/{task_id}/subtasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceRetentionPolicyExecSubTasksRequest);
            return new AsyncInvoker<ListInstanceRetentionPolicyExecSubTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceRetentionPolicyExecSubTasksResponse>);
        }
        
        /// <summary>
        /// 获取老化策略执行任务的镜像列表
        ///
        /// 获取老化策略执行任务的镜像列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceRetentionPolicyExecTasksResponse> ListInstanceRetentionPolicyExecTasksAsync(ListInstanceRetentionPolicyExecTasksRequest listInstanceRetentionPolicyExecTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecTasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecTasksRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecTasksRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecTasksRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/retention/policies/{policy_id}/executions/{execution_id}/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceRetentionPolicyExecTasksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceRetentionPolicyExecTasksResponse>(response);
        }

        public AsyncInvoker<ListInstanceRetentionPolicyExecTasksResponse> ListInstanceRetentionPolicyExecTasksAsyncInvoker(ListInstanceRetentionPolicyExecTasksRequest listInstanceRetentionPolicyExecTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecTasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecTasksRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecTasksRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecTasksRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/retention/policies/{policy_id}/executions/{execution_id}/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceRetentionPolicyExecTasksRequest);
            return new AsyncInvoker<ListInstanceRetentionPolicyExecTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceRetentionPolicyExecTasksResponse>);
        }
        
        /// <summary>
        /// 获取老化策略执行记录列表
        ///
        /// 获取老化策略执行记录列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceRetentionPolicyExecutionsResponse> ListInstanceRetentionPolicyExecutionsAsync(ListInstanceRetentionPolicyExecutionsRequest listInstanceRetentionPolicyExecutionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecutionsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecutionsRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecutionsRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/retention/policies/{policy_id}/executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceRetentionPolicyExecutionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceRetentionPolicyExecutionsResponse>(response);
        }

        public AsyncInvoker<ListInstanceRetentionPolicyExecutionsResponse> ListInstanceRetentionPolicyExecutionsAsyncInvoker(ListInstanceRetentionPolicyExecutionsRequest listInstanceRetentionPolicyExecutionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecutionsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecutionsRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceRetentionPolicyExecutionsRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/retention/policies/{policy_id}/executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceRetentionPolicyExecutionsRequest);
            return new AsyncInvoker<ListInstanceRetentionPolicyExecutionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceRetentionPolicyExecutionsResponse>);
        }
        
        /// <summary>
        /// 获取签名策略列表
        ///
        /// 获取签名策略列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceSignPoliciesResponse> ListInstanceSignPoliciesAsync(ListInstanceSignPoliciesRequest listInstanceSignPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignPoliciesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/signature/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceSignPoliciesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceSignPoliciesResponse>(response);
        }

        public AsyncInvoker<ListInstanceSignPoliciesResponse> ListInstanceSignPoliciesAsyncInvoker(ListInstanceSignPoliciesRequest listInstanceSignPoliciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignPoliciesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/signature/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceSignPoliciesRequest);
            return new AsyncInvoker<ListInstanceSignPoliciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceSignPoliciesResponse>);
        }
        
        /// <summary>
        /// 获取签名执行记录任务的镜像列表
        ///
        /// 获取签名执行记录任务的镜像列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceSignPolicyExecTasksResponse> ListInstanceSignPolicyExecTasksAsync(ListInstanceSignPolicyExecTasksRequest listInstanceSignPolicyExecTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignPolicyExecTasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignPolicyExecTasksRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignPolicyExecTasksRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignPolicyExecTasksRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/signature/policies/{policy_id}/executions/{execution_id}/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceSignPolicyExecTasksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceSignPolicyExecTasksResponse>(response);
        }

        public AsyncInvoker<ListInstanceSignPolicyExecTasksResponse> ListInstanceSignPolicyExecTasksAsyncInvoker(ListInstanceSignPolicyExecTasksRequest listInstanceSignPolicyExecTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignPolicyExecTasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignPolicyExecTasksRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignPolicyExecTasksRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignPolicyExecTasksRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/signature/policies/{policy_id}/executions/{execution_id}/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceSignPolicyExecTasksRequest);
            return new AsyncInvoker<ListInstanceSignPolicyExecTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceSignPolicyExecTasksResponse>);
        }
        
        /// <summary>
        /// 获取签名执行记录列表
        ///
        /// 获取签名执行记录列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceSignPolicyExecutionsResponse> ListInstanceSignPolicyExecutionsAsync(ListInstanceSignPolicyExecutionsRequest listInstanceSignPolicyExecutionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignPolicyExecutionsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignPolicyExecutionsRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignPolicyExecutionsRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/signature/policies/{policy_id}/executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceSignPolicyExecutionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceSignPolicyExecutionsResponse>(response);
        }

        public AsyncInvoker<ListInstanceSignPolicyExecutionsResponse> ListInstanceSignPolicyExecutionsAsyncInvoker(ListInstanceSignPolicyExecutionsRequest listInstanceSignPolicyExecutionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignPolicyExecutionsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignPolicyExecutionsRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignPolicyExecutionsRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/signature/policies/{policy_id}/executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceSignPolicyExecutionsRequest);
            return new AsyncInvoker<ListInstanceSignPolicyExecutionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceSignPolicyExecutionsResponse>);
        }
        
        /// <summary>
        /// 获取签名策略执行任务的镜像版本列表
        ///
        /// 获取签名策略执行任务的镜像版本列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceSignatureExecutionSubtasksResponse> ListInstanceSignatureExecutionSubtasksAsync(ListInstanceSignatureExecutionSubtasksRequest listInstanceSignatureExecutionSubtasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignatureExecutionSubtasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignatureExecutionSubtasksRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignatureExecutionSubtasksRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignatureExecutionSubtasksRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignatureExecutionSubtasksRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/signature/policies/{policy_id}/executions/{execution_id}/tasks/{task_id}/subtasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceSignatureExecutionSubtasksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceSignatureExecutionSubtasksResponse>(response);
        }

        public AsyncInvoker<ListInstanceSignatureExecutionSubtasksResponse> ListInstanceSignatureExecutionSubtasksAsyncInvoker(ListInstanceSignatureExecutionSubtasksRequest listInstanceSignatureExecutionSubtasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignatureExecutionSubtasksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignatureExecutionSubtasksRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignatureExecutionSubtasksRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignatureExecutionSubtasksRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceSignatureExecutionSubtasksRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/signature/policies/{policy_id}/executions/{execution_id}/tasks/{task_id}/subtasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceSignatureExecutionSubtasksRequest);
            return new AsyncInvoker<ListInstanceSignatureExecutionSubtasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceSignatureExecutionSubtasksResponse>);
        }
        
        /// <summary>
        /// 获取实例统计数据
        ///
        /// 获取实例统计数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceStatisticsResponse> ListInstanceStatisticsAsync(ListInstanceStatisticsRequest listInstanceStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceStatisticsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceStatisticsResponse>(response);
        }

        public AsyncInvoker<ListInstanceStatisticsResponse> ListInstanceStatisticsAsyncInvoker(ListInstanceStatisticsRequest listInstanceStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceStatisticsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceStatisticsRequest);
            return new AsyncInvoker<ListInstanceStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceStatisticsResponse>);
        }
        
        /// <summary>
        /// 获取制品仓库的Tag列表
        ///
        /// 获取制品仓库的Tag列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceTagsResponse> ListInstanceTagsAsync(ListInstanceTagsRequest listInstanceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceTagsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceTagsRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceTagsRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v2/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceTagsResponse>(response);
        }

        public AsyncInvoker<ListInstanceTagsResponse> ListInstanceTagsAsyncInvoker(ListInstanceTagsRequest listInstanceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceTagsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceTagsRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceTagsRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v2/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceTagsRequest);
            return new AsyncInvoker<ListInstanceTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceTagsResponse>);
        }
        
        /// <summary>
        /// 获取触发器执行任务列表
        ///
        /// 获取触发器执行任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceWebhookJobsResponse> ListInstanceWebhookJobsAsync(ListInstanceWebhookJobsRequest listInstanceWebhookJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceWebhookJobsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceWebhookJobsRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceWebhookJobsRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/webhook/policies/{policy_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceWebhookJobsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceWebhookJobsResponse>(response);
        }

        public AsyncInvoker<ListInstanceWebhookJobsResponse> ListInstanceWebhookJobsAsyncInvoker(ListInstanceWebhookJobsRequest listInstanceWebhookJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceWebhookJobsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceWebhookJobsRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(listInstanceWebhookJobsRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/webhook/policies/{policy_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceWebhookJobsRequest);
            return new AsyncInvoker<ListInstanceWebhookJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceWebhookJobsResponse>);
        }
        
        /// <summary>
        /// 获取触发器列表
        ///
        /// 获取触发器列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceWebhooksResponse> ListInstanceWebhooksAsync(ListInstanceWebhooksRequest listInstanceWebhooksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceWebhooksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/webhook/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceWebhooksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceWebhooksResponse>(response);
        }

        public AsyncInvoker<ListInstanceWebhooksResponse> ListInstanceWebhooksAsyncInvoker(ListInstanceWebhooksRequest listInstanceWebhooksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listInstanceWebhooksRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/webhook/policies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceWebhooksRequest);
            return new AsyncInvoker<ListInstanceWebhooksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceWebhooksResponse>);
        }
        
        /// <summary>
        /// 获取命名空间下所有制品仓库列表
        ///
        /// 获取命名空间下所有制品仓库列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNamespaceRepositoriesResponse> ListNamespaceRepositoriesAsync(ListNamespaceRepositoriesRequest listNamespaceRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listNamespaceRepositoriesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listNamespaceRepositoriesRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNamespaceRepositoriesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListNamespaceRepositoriesResponse>(response);
        }

        public AsyncInvoker<ListNamespaceRepositoriesResponse> ListNamespaceRepositoriesAsyncInvoker(ListNamespaceRepositoriesRequest listNamespaceRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listNamespaceRepositoriesRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(listNamespaceRepositoriesRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNamespaceRepositoriesRequest);
            return new AsyncInvoker<ListNamespaceRepositoriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNamespaceRepositoriesResponse>);
        }
        
        /// <summary>
        /// 查询实例下所有命名空间标签
        ///
        /// 查询实例下所有命名空间标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNamespaceTagsResponse> ListNamespaceTagsAsync(ListNamespaceTagsRequest listNamespaceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listNamespaceTagsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces-tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNamespaceTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListNamespaceTagsResponse>(response);
        }

        public AsyncInvoker<ListNamespaceTagsResponse> ListNamespaceTagsAsyncInvoker(ListNamespaceTagsRequest listNamespaceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listNamespaceTagsRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces-tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNamespaceTagsRequest);
            return new AsyncInvoker<ListNamespaceTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNamespaceTagsResponse>);
        }
        
        /// <summary>
        /// 按照标签检索子资源列表
        ///
        /// 按照标签检索子资源列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSubResourceInstancesResponse> ListSubResourceInstancesAsync(ListSubResourceInstancesRequest listSubResourceInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSubResourceInstancesRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(listSubResourceInstancesRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            if (StringUtils.TryConvertToNonEmptyString(listSubResourceInstancesRequest.SubResourceType, out var valueOfSubResourceType)) urlParam.Add("sub_resource_type", valueOfSubResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/{sub_resource_type}/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubResourceInstancesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListSubResourceInstancesResponse>(response);
        }

        public AsyncInvoker<ListSubResourceInstancesResponse> ListSubResourceInstancesAsyncInvoker(ListSubResourceInstancesRequest listSubResourceInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSubResourceInstancesRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(listSubResourceInstancesRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            if (StringUtils.TryConvertToNonEmptyString(listSubResourceInstancesRequest.SubResourceType, out var valueOfSubResourceType)) urlParam.Add("sub_resource_type", valueOfSubResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/{sub_resource_type}/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubResourceInstancesRequest);
            return new AsyncInvoker<ListSubResourceInstancesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListSubResourceInstancesResponse>);
        }
        
        /// <summary>
        /// 查询子资源标签
        ///
        /// 查询子资源标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSubResourceTagsResponse> ListSubResourceTagsAsync(ListSubResourceTagsRequest listSubResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSubResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(listSubResourceTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            if (StringUtils.TryConvertToNonEmptyString(listSubResourceTagsRequest.SubResourceType, out var valueOfSubResourceType)) urlParam.Add("sub_resource_type", valueOfSubResourceType);
            if (StringUtils.TryConvertToNonEmptyString(listSubResourceTagsRequest.SubResourceId, out var valueOfSubResourceId)) urlParam.Add("sub_resource_id", valueOfSubResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/{sub_resource_type}/{sub_resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubResourceTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSubResourceTagsResponse>(response);
        }

        public AsyncInvoker<ListSubResourceTagsResponse> ListSubResourceTagsAsyncInvoker(ListSubResourceTagsRequest listSubResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSubResourceTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(listSubResourceTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            if (StringUtils.TryConvertToNonEmptyString(listSubResourceTagsRequest.SubResourceType, out var valueOfSubResourceType)) urlParam.Add("sub_resource_type", valueOfSubResourceType);
            if (StringUtils.TryConvertToNonEmptyString(listSubResourceTagsRequest.SubResourceId, out var valueOfSubResourceId)) urlParam.Add("sub_resource_id", valueOfSubResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/{sub_resource_type}/{sub_resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubResourceTagsRequest);
            return new AsyncInvoker<ListSubResourceTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSubResourceTagsResponse>);
        }
        
        /// <summary>
        /// 获取实例详情
        ///
        /// 获取实例详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceResponse> ShowInstanceAsync(ShowInstanceRequest showInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceResponse>(response);
        }

        public AsyncInvoker<ShowInstanceResponse> ShowInstanceAsyncInvoker(ShowInstanceRequest showInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRequest);
            return new AsyncInvoker<ShowInstanceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceResponse>);
        }
        
        /// <summary>
        /// 获取制品版本详情
        ///
        /// 获取制品版本详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceArtifactResponse> ShowInstanceArtifactAsync(ShowInstanceArtifactRequest showInstanceArtifactRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceArtifactRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceArtifactRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceArtifactRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceArtifactRequest.Reference, out var valueOfReference)) urlParam.Add("reference", valueOfReference);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}/artifacts/{reference}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceArtifactRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceArtifactResponse>(response);
        }

        public AsyncInvoker<ShowInstanceArtifactResponse> ShowInstanceArtifactAsyncInvoker(ShowInstanceArtifactRequest showInstanceArtifactRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceArtifactRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceArtifactRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceArtifactRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceArtifactRequest.Reference, out var valueOfReference)) urlParam.Add("reference", valueOfReference);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}/artifacts/{reference}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceArtifactRequest);
            return new AsyncInvoker<ShowInstanceArtifactResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceArtifactResponse>);
        }
        
        /// <summary>
        /// 获取制品附加信息
        ///
        /// 获取制品附加信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceArtifactAdditionResponse> ShowInstanceArtifactAdditionAsync(ShowInstanceArtifactAdditionRequest showInstanceArtifactAdditionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceArtifactAdditionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceArtifactAdditionRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceArtifactAdditionRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceArtifactAdditionRequest.Reference, out var valueOfReference)) urlParam.Add("reference", valueOfReference);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceArtifactAdditionRequest.Addition, out var valueOfAddition)) urlParam.Add("addition", valueOfAddition);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}/artifacts/{reference}/additions/{addition}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceArtifactAdditionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceArtifactAdditionResponse>(response);
        }

        public AsyncInvoker<ShowInstanceArtifactAdditionResponse> ShowInstanceArtifactAdditionAsyncInvoker(ShowInstanceArtifactAdditionRequest showInstanceArtifactAdditionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceArtifactAdditionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceArtifactAdditionRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceArtifactAdditionRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceArtifactAdditionRequest.Reference, out var valueOfReference)) urlParam.Add("reference", valueOfReference);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceArtifactAdditionRequest.Addition, out var valueOfAddition)) urlParam.Add("addition", valueOfAddition);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}/artifacts/{reference}/additions/{addition}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceArtifactAdditionRequest);
            return new AsyncInvoker<ShowInstanceArtifactAdditionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceArtifactAdditionResponse>);
        }
        
        /// <summary>
        /// 查看实例配置
        ///
        /// 查看实例配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceConfigurationResponse> ShowInstanceConfigurationAsync(ShowInstanceConfigurationRequest showInstanceConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceConfigurationRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceConfigurationResponse>(response);
        }

        public AsyncInvoker<ShowInstanceConfigurationResponse> ShowInstanceConfigurationAsyncInvoker(ShowInstanceConfigurationRequest showInstanceConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceConfigurationRequest);
            return new AsyncInvoker<ShowInstanceConfigurationResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceConfigurationResponse>);
        }
        
        /// <summary>
        /// 获取公网访问信息
        ///
        /// 获取公网访问信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceEndpointPolicyResponse> ShowInstanceEndpointPolicyAsync(ShowInstanceEndpointPolicyRequest showInstanceEndpointPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceEndpointPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/endpoint-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceEndpointPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceEndpointPolicyResponse>(response);
        }

        public AsyncInvoker<ShowInstanceEndpointPolicyResponse> ShowInstanceEndpointPolicyAsyncInvoker(ShowInstanceEndpointPolicyRequest showInstanceEndpointPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceEndpointPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/endpoint-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceEndpointPolicyRequest);
            return new AsyncInvoker<ShowInstanceEndpointPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceEndpointPolicyResponse>);
        }
        
        /// <summary>
        /// 查询内网访问详情
        ///
        /// 查询内网访问详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceInternalEndpointResponse> ShowInstanceInternalEndpointAsync(ShowInstanceInternalEndpointRequest showInstanceInternalEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceInternalEndpointRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceInternalEndpointRequest.InternalEndpointsId, out var valueOfInternalEndpointsId)) urlParam.Add("internal_endpoints_id", valueOfInternalEndpointsId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/internal-endpoints/{internal_endpoints_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceInternalEndpointRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceInternalEndpointResponse>(response);
        }

        public AsyncInvoker<ShowInstanceInternalEndpointResponse> ShowInstanceInternalEndpointAsyncInvoker(ShowInstanceInternalEndpointRequest showInstanceInternalEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceInternalEndpointRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceInternalEndpointRequest.InternalEndpointsId, out var valueOfInternalEndpointsId)) urlParam.Add("internal_endpoints_id", valueOfInternalEndpointsId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/internal-endpoints/{internal_endpoints_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceInternalEndpointRequest);
            return new AsyncInvoker<ShowInstanceInternalEndpointResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceInternalEndpointResponse>);
        }
        
        /// <summary>
        /// 获取任务详情
        ///
        /// 获取任务详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceJobResponse> ShowInstanceJobAsync(ShowInstanceJobRequest showInstanceJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceJobRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceJobResponse>(response);
        }

        public AsyncInvoker<ShowInstanceJobResponse> ShowInstanceJobAsyncInvoker(ShowInstanceJobRequest showInstanceJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceJobRequest);
            return new AsyncInvoker<ShowInstanceJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceJobResponse>);
        }
        
        /// <summary>
        /// 获取命名空间详情
        ///
        /// 获取命名空间详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceNamespaceResponse> ShowInstanceNamespaceAsync(ShowInstanceNamespaceRequest showInstanceNamespaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceNamespaceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceNamespaceRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceNamespaceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceNamespaceResponse>(response);
        }

        public AsyncInvoker<ShowInstanceNamespaceResponse> ShowInstanceNamespaceAsyncInvoker(ShowInstanceNamespaceRequest showInstanceNamespaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceNamespaceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceNamespaceRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceNamespaceRequest);
            return new AsyncInvoker<ShowInstanceNamespaceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceNamespaceResponse>);
        }
        
        /// <summary>
        /// 获取镜像同步的目标仓库详情
        ///
        /// 获取镜像同步的目标仓库详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceRegistryResponse> ShowInstanceRegistryAsync(ShowInstanceRegistryRequest showInstanceRegistryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRegistryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRegistryRequest.RegistryId, out var valueOfRegistryId)) urlParam.Add("registry_id", valueOfRegistryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/registries/{registry_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRegistryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceRegistryResponse>(response);
        }

        public AsyncInvoker<ShowInstanceRegistryResponse> ShowInstanceRegistryAsyncInvoker(ShowInstanceRegistryRequest showInstanceRegistryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRegistryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRegistryRequest.RegistryId, out var valueOfRegistryId)) urlParam.Add("registry_id", valueOfRegistryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/registries/{registry_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRegistryRequest);
            return new AsyncInvoker<ShowInstanceRegistryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceRegistryResponse>);
        }
        
        /// <summary>
        /// 获取镜像同步策略详情
        ///
        /// 获取镜像同步策略详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceReplicationPolicyResponse> ShowInstanceReplicationPolicyAsync(ShowInstanceReplicationPolicyRequest showInstanceReplicationPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceReplicationPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceReplicationPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceReplicationPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceReplicationPolicyResponse>(response);
        }

        public AsyncInvoker<ShowInstanceReplicationPolicyResponse> ShowInstanceReplicationPolicyAsyncInvoker(ShowInstanceReplicationPolicyRequest showInstanceReplicationPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceReplicationPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceReplicationPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceReplicationPolicyRequest);
            return new AsyncInvoker<ShowInstanceReplicationPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceReplicationPolicyResponse>);
        }
        
        /// <summary>
        /// 获取制品仓库详情
        ///
        /// 获取制品仓库详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceRepositoryResponse> ShowInstanceRepositoryAsync(ShowInstanceRepositoryRequest showInstanceRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRepositoryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRepositoryRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRepositoryRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRepositoryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceRepositoryResponse>(response);
        }

        public AsyncInvoker<ShowInstanceRepositoryResponse> ShowInstanceRepositoryAsyncInvoker(ShowInstanceRepositoryRequest showInstanceRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRepositoryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRepositoryRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRepositoryRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRepositoryRequest);
            return new AsyncInvoker<ShowInstanceRepositoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceRepositoryResponse>);
        }
        
        /// <summary>
        /// 按照标签检索资源数量
        ///
        /// 按照标签检索资源数量
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceResourceInstancesCountResponse> ShowInstanceResourceInstancesCountAsync(ShowInstanceResourceInstancesCountRequest showInstanceResourceInstancesCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceResourceInstancesCountRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceResourceInstancesCountRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShowInstanceResourceInstancesCountResponse>(response);
        }

        public AsyncInvoker<ShowInstanceResourceInstancesCountResponse> ShowInstanceResourceInstancesCountAsyncInvoker(ShowInstanceResourceInstancesCountRequest showInstanceResourceInstancesCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceResourceInstancesCountRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceResourceInstancesCountRequest);
            return new AsyncInvoker<ShowInstanceResourceInstancesCountResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowInstanceResourceInstancesCountResponse>);
        }
        
        /// <summary>
        /// 获取老化策略详情
        ///
        /// 获取老化策略详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceRetentionPolicyResponse> ShowInstanceRetentionPolicyAsync(ShowInstanceRetentionPolicyRequest showInstanceRetentionPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRetentionPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRetentionPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRetentionPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/retention/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRetentionPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceRetentionPolicyResponse>(response);
        }

        public AsyncInvoker<ShowInstanceRetentionPolicyResponse> ShowInstanceRetentionPolicyAsyncInvoker(ShowInstanceRetentionPolicyRequest showInstanceRetentionPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRetentionPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRetentionPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceRetentionPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/retention/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceRetentionPolicyRequest);
            return new AsyncInvoker<ShowInstanceRetentionPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceRetentionPolicyResponse>);
        }
        
        /// <summary>
        /// 获取签名策略详情
        ///
        /// 获取签名策略详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceSignPolicyResponse> ShowInstanceSignPolicyAsync(ShowInstanceSignPolicyRequest showInstanceSignPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceSignPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceSignPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceSignPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/signature/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceSignPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceSignPolicyResponse>(response);
        }

        public AsyncInvoker<ShowInstanceSignPolicyResponse> ShowInstanceSignPolicyAsyncInvoker(ShowInstanceSignPolicyRequest showInstanceSignPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceSignPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceSignPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceSignPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/signature/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceSignPolicyRequest);
            return new AsyncInvoker<ShowInstanceSignPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceSignPolicyResponse>);
        }
        
        /// <summary>
        /// 获取触发器详情
        ///
        /// 获取触发器详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceWebhookResponse> ShowInstanceWebhookAsync(ShowInstanceWebhookRequest showInstanceWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceWebhookRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceWebhookRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceWebhookRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/webhook/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceWebhookRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceWebhookResponse>(response);
        }

        public AsyncInvoker<ShowInstanceWebhookResponse> ShowInstanceWebhookAsyncInvoker(ShowInstanceWebhookRequest showInstanceWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceWebhookRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceWebhookRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(showInstanceWebhookRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/webhook/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceWebhookRequest);
            return new AsyncInvoker<ShowInstanceWebhookResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceWebhookResponse>);
        }
        
        /// <summary>
        /// 按照标签检索子资源数量
        ///
        /// 按照标签检索子资源数量
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSubResourceInstancesCountResponse> ShowSubResourceInstancesCountAsync(ShowSubResourceInstancesCountRequest showSubResourceInstancesCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSubResourceInstancesCountRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(showSubResourceInstancesCountRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            if (StringUtils.TryConvertToNonEmptyString(showSubResourceInstancesCountRequest.SubResourceType, out var valueOfSubResourceType)) urlParam.Add("sub_resource_type", valueOfSubResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/{sub_resource_type}/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubResourceInstancesCountRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShowSubResourceInstancesCountResponse>(response);
        }

        public AsyncInvoker<ShowSubResourceInstancesCountResponse> ShowSubResourceInstancesCountAsyncInvoker(ShowSubResourceInstancesCountRequest showSubResourceInstancesCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSubResourceInstancesCountRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(showSubResourceInstancesCountRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            if (StringUtils.TryConvertToNonEmptyString(showSubResourceInstancesCountRequest.SubResourceType, out var valueOfSubResourceType)) urlParam.Add("sub_resource_type", valueOfSubResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/{sub_resource_type}/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubResourceInstancesCountRequest);
            return new AsyncInvoker<ShowSubResourceInstancesCountResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowSubResourceInstancesCountResponse>);
        }
        
        /// <summary>
        /// 停止镜像同步任务
        ///
        /// 停止镜像同步任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StopInstanceReplicationPolicyExecutionResponse> StopInstanceReplicationPolicyExecutionAsync(StopInstanceReplicationPolicyExecutionRequest stopInstanceReplicationPolicyExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopInstanceReplicationPolicyExecutionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(stopInstanceReplicationPolicyExecutionRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/executions/{execution_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopInstanceReplicationPolicyExecutionRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<StopInstanceReplicationPolicyExecutionResponse>(response);
        }

        public AsyncInvoker<StopInstanceReplicationPolicyExecutionResponse> StopInstanceReplicationPolicyExecutionAsyncInvoker(StopInstanceReplicationPolicyExecutionRequest stopInstanceReplicationPolicyExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopInstanceReplicationPolicyExecutionRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(stopInstanceReplicationPolicyExecutionRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/executions/{execution_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopInstanceReplicationPolicyExecutionRequest);
            return new AsyncInvoker<StopInstanceReplicationPolicyExecutionResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<StopInstanceReplicationPolicyExecutionResponse>);
        }
        
        /// <summary>
        /// 更新域名
        ///
        /// 更新域名
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDomainNameResponse> UpdateDomainNameAsync(UpdateDomainNameRequest updateDomainNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDomainNameRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateDomainNameRequest.DomainnameId, out var valueOfDomainnameId)) urlParam.Add("domainname_id", valueOfDomainnameId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/domainname/{domainname_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainNameRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDomainNameResponse>(response);
        }

        public AsyncInvoker<UpdateDomainNameResponse> UpdateDomainNameAsyncInvoker(UpdateDomainNameRequest updateDomainNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDomainNameRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateDomainNameRequest.DomainnameId, out var valueOfDomainnameId)) urlParam.Add("domainname_id", valueOfDomainnameId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/domainname/{domainname_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainNameRequest);
            return new AsyncInvoker<UpdateDomainNameResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDomainNameResponse>);
        }
        
        /// <summary>
        /// 修改不可变Tag策略
        ///
        /// 修改不可变Tag策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateImmutableRuleResponse> UpdateImmutableRuleAsync(UpdateImmutableRuleRequest updateImmutableRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateImmutableRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateImmutableRuleRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(updateImmutableRuleRequest.ImmutableRuleId, out var valueOfImmutableRuleId)) urlParam.Add("immutable_rule_id", valueOfImmutableRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/immutabletagrules/{immutable_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateImmutableRuleRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateImmutableRuleResponse>(response);
        }

        public AsyncInvoker<UpdateImmutableRuleResponse> UpdateImmutableRuleAsyncInvoker(UpdateImmutableRuleRequest updateImmutableRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateImmutableRuleRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateImmutableRuleRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(updateImmutableRuleRequest.ImmutableRuleId, out var valueOfImmutableRuleId)) urlParam.Add("immutable_rule_id", valueOfImmutableRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/immutabletagrules/{immutable_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateImmutableRuleRequest);
            return new AsyncInvoker<UpdateImmutableRuleResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateImmutableRuleResponse>);
        }
        
        /// <summary>
        /// 修改实例配置
        ///
        /// 修改实例配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstanceConfigurationResponse> UpdateInstanceConfigurationAsync(UpdateInstanceConfigurationRequest updateInstanceConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceConfigurationRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceConfigurationResponse>(response);
        }

        public AsyncInvoker<UpdateInstanceConfigurationResponse> UpdateInstanceConfigurationAsyncInvoker(UpdateInstanceConfigurationRequest updateInstanceConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceConfigurationRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceConfigurationRequest);
            return new AsyncInvoker<UpdateInstanceConfigurationResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceConfigurationResponse>);
        }
        
        /// <summary>
        /// 更新公网访问白名单
        ///
        /// 更新公网访问白名单，更新方式为全量更新方式
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstanceEndpointPolicyResponse> UpdateInstanceEndpointPolicyAsync(UpdateInstanceEndpointPolicyRequest updateInstanceEndpointPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceEndpointPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/endpoint-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceEndpointPolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceEndpointPolicyResponse>(response);
        }

        public AsyncInvoker<UpdateInstanceEndpointPolicyResponse> UpdateInstanceEndpointPolicyAsyncInvoker(UpdateInstanceEndpointPolicyRequest updateInstanceEndpointPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceEndpointPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/endpoint-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceEndpointPolicyRequest);
            return new AsyncInvoker<UpdateInstanceEndpointPolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceEndpointPolicyResponse>);
        }
        
        /// <summary>
        /// 启用/停用长期访问凭证
        ///
        /// 启用/停用长期访问凭证
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstanceLtCredentialResponse> UpdateInstanceLtCredentialAsync(UpdateInstanceLtCredentialRequest updateInstanceLtCredentialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceLtCredentialRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceLtCredentialRequest.CredentialId, out var valueOfCredentialId)) urlParam.Add("credential_id", valueOfCredentialId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/long-term-credentials/{credential_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceLtCredentialRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceLtCredentialResponse>(response);
        }

        public AsyncInvoker<UpdateInstanceLtCredentialResponse> UpdateInstanceLtCredentialAsyncInvoker(UpdateInstanceLtCredentialRequest updateInstanceLtCredentialRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceLtCredentialRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceLtCredentialRequest.CredentialId, out var valueOfCredentialId)) urlParam.Add("credential_id", valueOfCredentialId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/long-term-credentials/{credential_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceLtCredentialRequest);
            return new AsyncInvoker<UpdateInstanceLtCredentialResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceLtCredentialResponse>);
        }
        
        /// <summary>
        /// 修改命名空间
        ///
        /// 修改命名空间
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstanceNamespaceResponse> UpdateInstanceNamespaceAsync(UpdateInstanceNamespaceRequest updateInstanceNamespaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceNamespaceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceNamespaceRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceNamespaceRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInstanceNamespaceResponse>(response);
        }

        public AsyncInvoker<UpdateInstanceNamespaceResponse> UpdateInstanceNamespaceAsyncInvoker(UpdateInstanceNamespaceRequest updateInstanceNamespaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceNamespaceRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceNamespaceRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceNamespaceRequest);
            return new AsyncInvoker<UpdateInstanceNamespaceResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInstanceNamespaceResponse>);
        }
        
        /// <summary>
        /// 修改镜像同步的目标仓库
        ///
        /// 修改镜像同步的目标仓库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstanceRegistryResponse> UpdateInstanceRegistryAsync(UpdateInstanceRegistryRequest updateInstanceRegistryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceRegistryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceRegistryRequest.RegistryId, out var valueOfRegistryId)) urlParam.Add("registry_id", valueOfRegistryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/registries/{registry_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceRegistryRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceRegistryResponse>(response);
        }

        public AsyncInvoker<UpdateInstanceRegistryResponse> UpdateInstanceRegistryAsyncInvoker(UpdateInstanceRegistryRequest updateInstanceRegistryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceRegistryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceRegistryRequest.RegistryId, out var valueOfRegistryId)) urlParam.Add("registry_id", valueOfRegistryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/registries/{registry_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceRegistryRequest);
            return new AsyncInvoker<UpdateInstanceRegistryResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceRegistryResponse>);
        }
        
        /// <summary>
        /// 修改镜像同步策略
        ///
        /// 修改镜像同步策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstanceReplicationPolicyResponse> UpdateInstanceReplicationPolicyAsync(UpdateInstanceReplicationPolicyRequest updateInstanceReplicationPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceReplicationPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceReplicationPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceReplicationPolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceReplicationPolicyResponse>(response);
        }

        public AsyncInvoker<UpdateInstanceReplicationPolicyResponse> UpdateInstanceReplicationPolicyAsyncInvoker(UpdateInstanceReplicationPolicyRequest updateInstanceReplicationPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceReplicationPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceReplicationPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/replication/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceReplicationPolicyRequest);
            return new AsyncInvoker<UpdateInstanceReplicationPolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceReplicationPolicyResponse>);
        }
        
        /// <summary>
        /// 修改制品仓库
        ///
        /// 修改制品仓库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstanceRepositoryResponse> UpdateInstanceRepositoryAsync(UpdateInstanceRepositoryRequest updateInstanceRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceRepositoryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceRepositoryRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceRepositoryRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceRepositoryRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceRepositoryResponse>(response);
        }

        public AsyncInvoker<UpdateInstanceRepositoryResponse> UpdateInstanceRepositoryAsyncInvoker(UpdateInstanceRepositoryRequest updateInstanceRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceRepositoryRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceRepositoryRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceRepositoryRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/repositories/{repository_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceRepositoryRequest);
            return new AsyncInvoker<UpdateInstanceRepositoryResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceRepositoryResponse>);
        }
        
        /// <summary>
        /// 修改老化策略
        ///
        /// 修改老化策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstanceRetentionPolicyResponse> UpdateInstanceRetentionPolicyAsync(UpdateInstanceRetentionPolicyRequest updateInstanceRetentionPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceRetentionPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceRetentionPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceRetentionPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/retention/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceRetentionPolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceRetentionPolicyResponse>(response);
        }

        public AsyncInvoker<UpdateInstanceRetentionPolicyResponse> UpdateInstanceRetentionPolicyAsyncInvoker(UpdateInstanceRetentionPolicyRequest updateInstanceRetentionPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceRetentionPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceRetentionPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceRetentionPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/retention/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceRetentionPolicyRequest);
            return new AsyncInvoker<UpdateInstanceRetentionPolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceRetentionPolicyResponse>);
        }
        
        /// <summary>
        /// 修改签名策略
        ///
        /// 修改签名策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstanceSignPolicyResponse> UpdateInstanceSignPolicyAsync(UpdateInstanceSignPolicyRequest updateInstanceSignPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceSignPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceSignPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceSignPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/signature/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceSignPolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceSignPolicyResponse>(response);
        }

        public AsyncInvoker<UpdateInstanceSignPolicyResponse> UpdateInstanceSignPolicyAsyncInvoker(UpdateInstanceSignPolicyRequest updateInstanceSignPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceSignPolicyRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceSignPolicyRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceSignPolicyRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/signature/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceSignPolicyRequest);
            return new AsyncInvoker<UpdateInstanceSignPolicyResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceSignPolicyResponse>);
        }
        
        /// <summary>
        /// 修改触发器
        ///
        /// 修改触发器
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateInstanceWebhookResponse> UpdateInstanceWebhookAsync(UpdateInstanceWebhookRequest updateInstanceWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceWebhookRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceWebhookRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceWebhookRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/webhook/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceWebhookRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateInstanceWebhookResponse>(response);
        }

        public AsyncInvoker<UpdateInstanceWebhookResponse> UpdateInstanceWebhookAsyncInvoker(UpdateInstanceWebhookRequest updateInstanceWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceWebhookRequest.InstanceId, out var valueOfInstanceId)) urlParam.Add("instance_id", valueOfInstanceId);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceWebhookRequest.NamespaceName, out var valueOfNamespaceName)) urlParam.Add("namespace_name", valueOfNamespaceName);
            if (StringUtils.TryConvertToNonEmptyString(updateInstanceWebhookRequest.PolicyId, out var valueOfPolicyId)) urlParam.Add("policy_id", valueOfPolicyId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/namespaces/{namespace_name}/webhook/policies/{policy_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInstanceWebhookRequest);
            return new AsyncInvoker<UpdateInstanceWebhookResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateInstanceWebhookResponse>);
        }
        
    }
}