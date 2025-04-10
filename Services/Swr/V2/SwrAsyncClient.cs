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
            urlParam.Add("namespace", createImageSyncRepoRequest.Namespace.ToString());
            urlParam.Add("repository", createImageSyncRepoRequest.Repository.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/sync_repo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createImageSyncRepoRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateImageSyncRepoResponse>(response);
        }

        public AsyncInvoker<CreateImageSyncRepoResponse> CreateImageSyncRepoAsyncInvoker(CreateImageSyncRepoRequest createImageSyncRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", createImageSyncRepoRequest.Namespace.ToString());
            urlParam.Add("repository", createImageSyncRepoRequest.Repository.ToString());
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
            urlParam.Add("namespace", createManualImageSyncRepoRequest.Namespace.ToString());
            urlParam.Add("repository", createManualImageSyncRepoRequest.Repository.ToString());
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
            urlParam.Add("namespace", createManualImageSyncRepoRequest.Namespace.ToString());
            urlParam.Add("repository", createManualImageSyncRepoRequest.Repository.ToString());
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
            urlParam.Add("namespace", createNamespaceAuthRequest.Namespace.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNamespaceAuthRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateNamespaceAuthResponse>(response);
        }

        public AsyncInvoker<CreateNamespaceAuthResponse> CreateNamespaceAuthAsyncInvoker(CreateNamespaceAuthRequest createNamespaceAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", createNamespaceAuthRequest.Namespace.ToString());
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
            urlParam.Add("namespace", createRepoRequest.Namespace.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepoRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateRepoResponse>(response);
        }

        public AsyncInvoker<CreateRepoResponse> CreateRepoAsyncInvoker(CreateRepoRequest createRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", createRepoRequest.Namespace.ToString());
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
            urlParam.Add("namespace", createRepoDomainsRequest.Namespace.ToString());
            urlParam.Add("repository", createRepoDomainsRequest.Repository.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepoDomainsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateRepoDomainsResponse>(response);
        }

        public AsyncInvoker<CreateRepoDomainsResponse> CreateRepoDomainsAsyncInvoker(CreateRepoDomainsRequest createRepoDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", createRepoDomainsRequest.Namespace.ToString());
            urlParam.Add("repository", createRepoDomainsRequest.Repository.ToString());
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
            urlParam.Add("namespace", createRepoTagRequest.Namespace.ToString());
            urlParam.Add("repository", createRepoTagRequest.Repository.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepoTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateRepoTagResponse>(response);
        }

        public AsyncInvoker<CreateRepoTagResponse> CreateRepoTagAsyncInvoker(CreateRepoTagRequest createRepoTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", createRepoTagRequest.Namespace.ToString());
            urlParam.Add("repository", createRepoTagRequest.Repository.ToString());
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
            urlParam.Add("namespace", createRetentionRequest.Namespace.ToString());
            urlParam.Add("repository", createRetentionRequest.Repository.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRetentionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateRetentionResponse>(response);
        }

        public AsyncInvoker<CreateRetentionResponse> CreateRetentionAsyncInvoker(CreateRetentionRequest createRetentionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", createRetentionRequest.Namespace.ToString());
            urlParam.Add("repository", createRetentionRequest.Repository.ToString());
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
            urlParam.Add("namespace", createTriggerRequest.Namespace.ToString());
            urlParam.Add("repository", createTriggerRequest.Repository.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTriggerRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateTriggerResponse>(response);
        }

        public AsyncInvoker<CreateTriggerResponse> CreateTriggerAsyncInvoker(CreateTriggerRequest createTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", createTriggerRequest.Namespace.ToString());
            urlParam.Add("repository", createTriggerRequest.Repository.ToString());
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
            urlParam.Add("namespace", createUserRepositoryAuthRequest.Namespace.ToString());
            urlParam.Add("repository", createUserRepositoryAuthRequest.Repository.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUserRepositoryAuthRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateUserRepositoryAuthResponse>(response);
        }

        public AsyncInvoker<CreateUserRepositoryAuthResponse> CreateUserRepositoryAuthAsyncInvoker(CreateUserRepositoryAuthRequest createUserRepositoryAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", createUserRepositoryAuthRequest.Namespace.ToString());
            urlParam.Add("repository", createUserRepositoryAuthRequest.Repository.ToString());
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
            urlParam.Add("namespace", deleteImageSyncRepoRequest.Namespace.ToString());
            urlParam.Add("repository", deleteImageSyncRepoRequest.Repository.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/sync_repo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteImageSyncRepoRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteImageSyncRepoResponse>(response);
        }

        public AsyncInvoker<DeleteImageSyncRepoResponse> DeleteImageSyncRepoAsyncInvoker(DeleteImageSyncRepoRequest deleteImageSyncRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", deleteImageSyncRepoRequest.Namespace.ToString());
            urlParam.Add("repository", deleteImageSyncRepoRequest.Repository.ToString());
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
            urlParam.Add("namespace", deleteNamespaceAuthRequest.Namespace.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNamespaceAuthRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteNamespaceAuthResponse>(response);
        }

        public AsyncInvoker<DeleteNamespaceAuthResponse> DeleteNamespaceAuthAsyncInvoker(DeleteNamespaceAuthRequest deleteNamespaceAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", deleteNamespaceAuthRequest.Namespace.ToString());
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
            urlParam.Add("namespace", deleteNamespacesRequest.Namespace.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNamespacesRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteNamespacesResponse>(response);
        }

        public AsyncInvoker<DeleteNamespacesResponse> DeleteNamespacesAsyncInvoker(DeleteNamespacesRequest deleteNamespacesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", deleteNamespacesRequest.Namespace.ToString());
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
            urlParam.Add("namespace", deleteRepoRequest.Namespace.ToString());
            urlParam.Add("repository", deleteRepoRequest.Repository.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepoRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRepoResponse>(response);
        }

        public AsyncInvoker<DeleteRepoResponse> DeleteRepoAsyncInvoker(DeleteRepoRequest deleteRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", deleteRepoRequest.Namespace.ToString());
            urlParam.Add("repository", deleteRepoRequest.Repository.ToString());
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
            urlParam.Add("namespace", deleteRepoDomainsRequest.Namespace.ToString());
            urlParam.Add("repository", deleteRepoDomainsRequest.Repository.ToString());
            urlParam.Add("access_domain", deleteRepoDomainsRequest.AccessDomain.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains/{access_domain}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepoDomainsRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRepoDomainsResponse>(response);
        }

        public AsyncInvoker<DeleteRepoDomainsResponse> DeleteRepoDomainsAsyncInvoker(DeleteRepoDomainsRequest deleteRepoDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", deleteRepoDomainsRequest.Namespace.ToString());
            urlParam.Add("repository", deleteRepoDomainsRequest.Repository.ToString());
            urlParam.Add("access_domain", deleteRepoDomainsRequest.AccessDomain.ToString());
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
            urlParam.Add("namespace", deleteRepoTagRequest.Namespace.ToString());
            urlParam.Add("repository", deleteRepoTagRequest.Repository.ToString());
            urlParam.Add("tag", deleteRepoTagRequest.Tag.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/tags/{tag}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepoTagRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRepoTagResponse>(response);
        }

        public AsyncInvoker<DeleteRepoTagResponse> DeleteRepoTagAsyncInvoker(DeleteRepoTagRequest deleteRepoTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", deleteRepoTagRequest.Namespace.ToString());
            urlParam.Add("repository", deleteRepoTagRequest.Repository.ToString());
            urlParam.Add("tag", deleteRepoTagRequest.Tag.ToString());
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
            urlParam.Add("namespace", deleteRetentionRequest.Namespace.ToString());
            urlParam.Add("repository", deleteRetentionRequest.Repository.ToString());
            urlParam.Add("retention_id", deleteRetentionRequest.RetentionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions/{retention_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRetentionRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRetentionResponse>(response);
        }

        public AsyncInvoker<DeleteRetentionResponse> DeleteRetentionAsyncInvoker(DeleteRetentionRequest deleteRetentionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", deleteRetentionRequest.Namespace.ToString());
            urlParam.Add("repository", deleteRetentionRequest.Repository.ToString());
            urlParam.Add("retention_id", deleteRetentionRequest.RetentionId.ToString());
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
            urlParam.Add("namespace", deleteTriggerRequest.Namespace.ToString());
            urlParam.Add("repository", deleteTriggerRequest.Repository.ToString());
            urlParam.Add("trigger", deleteTriggerRequest.Trigger.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers/{trigger}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTriggerRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTriggerResponse>(response);
        }

        public AsyncInvoker<DeleteTriggerResponse> DeleteTriggerAsyncInvoker(DeleteTriggerRequest deleteTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", deleteTriggerRequest.Namespace.ToString());
            urlParam.Add("repository", deleteTriggerRequest.Repository.ToString());
            urlParam.Add("trigger", deleteTriggerRequest.Trigger.ToString());
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
            urlParam.Add("namespace", deleteUserRepositoryAuthRequest.Namespace.ToString());
            urlParam.Add("repository", deleteUserRepositoryAuthRequest.Repository.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserRepositoryAuthRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteUserRepositoryAuthResponse>(response);
        }

        public AsyncInvoker<DeleteUserRepositoryAuthResponse> DeleteUserRepositoryAuthAsyncInvoker(DeleteUserRepositoryAuthRequest deleteUserRepositoryAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", deleteUserRepositoryAuthRequest.Namespace.ToString());
            urlParam.Add("repository", deleteUserRepositoryAuthRequest.Repository.ToString());
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
            urlParam.Add("namespace", listImageAutoSyncReposDetailsRequest.Namespace.ToString());
            urlParam.Add("repository", listImageAutoSyncReposDetailsRequest.Repository.ToString());
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
            urlParam.Add("namespace", listImageAutoSyncReposDetailsRequest.Namespace.ToString());
            urlParam.Add("repository", listImageAutoSyncReposDetailsRequest.Repository.ToString());
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
        /// 获取共享帐号列表
        ///
        /// 获取共享帐号列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRepoDomainsResponse> ListRepoDomainsAsync(ListRepoDomainsRequest listRepoDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", listRepoDomainsRequest.Namespace.ToString());
            urlParam.Add("repository", listRepoDomainsRequest.Repository.ToString());
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
            urlParam.Add("namespace", listRepoDomainsRequest.Namespace.ToString());
            urlParam.Add("repository", listRepoDomainsRequest.Repository.ToString());
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
        /// 查询镜像tag列表
        ///
        /// 查询镜像tag列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRepositoryTagsResponse> ListRepositoryTagsAsync(ListRepositoryTagsRequest listRepositoryTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", listRepositoryTagsRequest.Namespace.ToString());
            urlParam.Add("repository", listRepositoryTagsRequest.Repository.ToString());
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
            urlParam.Add("namespace", listRepositoryTagsRequest.Namespace.ToString());
            urlParam.Add("repository", listRepositoryTagsRequest.Repository.ToString());
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
            urlParam.Add("namespace", listRetentionHistoriesRequest.Namespace.ToString());
            urlParam.Add("repository", listRetentionHistoriesRequest.Repository.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions/histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRetentionHistoriesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRetentionHistoriesResponse>(response);
        }

        public AsyncInvoker<ListRetentionHistoriesResponse> ListRetentionHistoriesAsyncInvoker(ListRetentionHistoriesRequest listRetentionHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", listRetentionHistoriesRequest.Namespace.ToString());
            urlParam.Add("repository", listRetentionHistoriesRequest.Repository.ToString());
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
            urlParam.Add("namespace", listRetentionsRequest.Namespace.ToString());
            urlParam.Add("repository", listRetentionsRequest.Repository.ToString());
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
            urlParam.Add("namespace", listRetentionsRequest.Namespace.ToString());
            urlParam.Add("repository", listRetentionsRequest.Repository.ToString());
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
            urlParam.Add("namespace", listTriggersDetailsRequest.Namespace.ToString());
            urlParam.Add("repository", listTriggersDetailsRequest.Repository.ToString());
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
            urlParam.Add("namespace", listTriggersDetailsRequest.Namespace.ToString());
            urlParam.Add("repository", listTriggersDetailsRequest.Repository.ToString());
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
            urlParam.Add("namespace", showAccessDomainRequest.Namespace.ToString());
            urlParam.Add("repository", showAccessDomainRequest.Repository.ToString());
            urlParam.Add("access_domain", showAccessDomainRequest.AccessDomain.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains/{access_domain}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAccessDomainRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAccessDomainResponse>(response);
        }

        public AsyncInvoker<ShowAccessDomainResponse> ShowAccessDomainAsyncInvoker(ShowAccessDomainRequest showAccessDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", showAccessDomainRequest.Namespace.ToString());
            urlParam.Add("repository", showAccessDomainRequest.Repository.ToString());
            urlParam.Add("access_domain", showAccessDomainRequest.AccessDomain.ToString());
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
            urlParam.Add("resource_type", showDomainResourceReportsRequest.ResourceType.ToString());
            urlParam.Add("frequency", showDomainResourceReportsRequest.Frequency.ToString());
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
            urlParam.Add("resource_type", showDomainResourceReportsRequest.ResourceType.ToString());
            urlParam.Add("frequency", showDomainResourceReportsRequest.Frequency.ToString());
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
            urlParam.Add("namespace", showNamespaceRequest.Namespace.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNamespaceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowNamespaceResponse>(response);
        }

        public AsyncInvoker<ShowNamespaceResponse> ShowNamespaceAsyncInvoker(ShowNamespaceRequest showNamespaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", showNamespaceRequest.Namespace.ToString());
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
            urlParam.Add("namespace", showNamespaceAuthRequest.Namespace.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNamespaceAuthRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowNamespaceAuthResponse>(response);
        }

        public AsyncInvoker<ShowNamespaceAuthResponse> ShowNamespaceAuthAsyncInvoker(ShowNamespaceAuthRequest showNamespaceAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", showNamespaceAuthRequest.Namespace.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNamespaceAuthRequest);
            return new AsyncInvoker<ShowNamespaceAuthResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNamespaceAuthResponse>);
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
            urlParam.Add("namespace", showRepositoryRequest.Namespace.ToString());
            urlParam.Add("repository", showRepositoryRequest.Repository.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRepositoryResponse>(response);
        }

        public AsyncInvoker<ShowRepositoryResponse> ShowRepositoryAsyncInvoker(ShowRepositoryRequest showRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", showRepositoryRequest.Namespace.ToString());
            urlParam.Add("repository", showRepositoryRequest.Repository.ToString());
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
            urlParam.Add("namespace", showRetentionRequest.Namespace.ToString());
            urlParam.Add("repository", showRetentionRequest.Repository.ToString());
            urlParam.Add("retention_id", showRetentionRequest.RetentionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions/{retention_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRetentionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRetentionResponse>(response);
        }

        public AsyncInvoker<ShowRetentionResponse> ShowRetentionAsyncInvoker(ShowRetentionRequest showRetentionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", showRetentionRequest.Namespace.ToString());
            urlParam.Add("repository", showRetentionRequest.Repository.ToString());
            urlParam.Add("retention_id", showRetentionRequest.RetentionId.ToString());
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
            urlParam.Add("namespace", showSyncJobRequest.Namespace.ToString());
            urlParam.Add("repository", showSyncJobRequest.Repository.ToString());
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
            urlParam.Add("namespace", showSyncJobRequest.Namespace.ToString());
            urlParam.Add("repository", showSyncJobRequest.Repository.ToString());
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
            urlParam.Add("namespace", showTriggerRequest.Namespace.ToString());
            urlParam.Add("repository", showTriggerRequest.Repository.ToString());
            urlParam.Add("trigger", showTriggerRequest.Trigger.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers/{trigger}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTriggerRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTriggerResponse>(response);
        }

        public AsyncInvoker<ShowTriggerResponse> ShowTriggerAsyncInvoker(ShowTriggerRequest showTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", showTriggerRequest.Namespace.ToString());
            urlParam.Add("repository", showTriggerRequest.Repository.ToString());
            urlParam.Add("trigger", showTriggerRequest.Trigger.ToString());
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
            urlParam.Add("namespace", showUserRepositoryAuthRequest.Namespace.ToString());
            urlParam.Add("repository", showUserRepositoryAuthRequest.Repository.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserRepositoryAuthRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowUserRepositoryAuthResponse>(response);
        }

        public AsyncInvoker<ShowUserRepositoryAuthResponse> ShowUserRepositoryAuthAsyncInvoker(ShowUserRepositoryAuthRequest showUserRepositoryAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", showUserRepositoryAuthRequest.Namespace.ToString());
            urlParam.Add("repository", showUserRepositoryAuthRequest.Repository.ToString());
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
            urlParam.Add("namespace", updateNamespaceAuthRequest.Namespace.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNamespaceAuthRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerializeNull<UpdateNamespaceAuthResponse>(response);
        }

        public AsyncInvoker<UpdateNamespaceAuthResponse> UpdateNamespaceAuthAsyncInvoker(UpdateNamespaceAuthRequest updateNamespaceAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", updateNamespaceAuthRequest.Namespace.ToString());
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
            urlParam.Add("namespace", updateRepoRequest.Namespace.ToString());
            urlParam.Add("repository", updateRepoRequest.Repository.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepoRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerializeNull<UpdateRepoResponse>(response);
        }

        public AsyncInvoker<UpdateRepoResponse> UpdateRepoAsyncInvoker(UpdateRepoRequest updateRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", updateRepoRequest.Namespace.ToString());
            urlParam.Add("repository", updateRepoRequest.Repository.ToString());
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
            urlParam.Add("namespace", updateRepoDomainsRequest.Namespace.ToString());
            urlParam.Add("repository", updateRepoDomainsRequest.Repository.ToString());
            urlParam.Add("access_domain", updateRepoDomainsRequest.AccessDomain.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains/{access_domain}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepoDomainsRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerializeNull<UpdateRepoDomainsResponse>(response);
        }

        public AsyncInvoker<UpdateRepoDomainsResponse> UpdateRepoDomainsAsyncInvoker(UpdateRepoDomainsRequest updateRepoDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", updateRepoDomainsRequest.Namespace.ToString());
            urlParam.Add("repository", updateRepoDomainsRequest.Repository.ToString());
            urlParam.Add("access_domain", updateRepoDomainsRequest.AccessDomain.ToString());
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
            urlParam.Add("namespace", updateRetentionRequest.Namespace.ToString());
            urlParam.Add("repository", updateRetentionRequest.Repository.ToString());
            urlParam.Add("retention_id", updateRetentionRequest.RetentionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions/{retention_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRetentionRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerializeNull<UpdateRetentionResponse>(response);
        }

        public AsyncInvoker<UpdateRetentionResponse> UpdateRetentionAsyncInvoker(UpdateRetentionRequest updateRetentionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", updateRetentionRequest.Namespace.ToString());
            urlParam.Add("repository", updateRetentionRequest.Repository.ToString());
            urlParam.Add("retention_id", updateRetentionRequest.RetentionId.ToString());
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
            urlParam.Add("namespace", updateTriggerRequest.Namespace.ToString());
            urlParam.Add("repository", updateTriggerRequest.Repository.ToString());
            urlParam.Add("trigger", updateTriggerRequest.Trigger.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers/{trigger}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTriggerRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerializeNull<UpdateTriggerResponse>(response);
        }

        public AsyncInvoker<UpdateTriggerResponse> UpdateTriggerAsyncInvoker(UpdateTriggerRequest updateTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", updateTriggerRequest.Namespace.ToString());
            urlParam.Add("repository", updateTriggerRequest.Repository.ToString());
            urlParam.Add("trigger", updateTriggerRequest.Trigger.ToString());
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
            urlParam.Add("namespace", updateUserRepositoryAuthRequest.Namespace.ToString());
            urlParam.Add("repository", updateUserRepositoryAuthRequest.Repository.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserRepositoryAuthRequest);
            var response = await DoHttpRequestAsync("PATCH", request);
            return JsonUtils.DeSerializeNull<UpdateUserRepositoryAuthResponse>(response);
        }

        public AsyncInvoker<UpdateUserRepositoryAuthResponse> UpdateUserRepositoryAuthAsyncInvoker(UpdateUserRepositoryAuthRequest updateUserRepositoryAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", updateUserRepositoryAuthRequest.Namespace.ToString());
            urlParam.Add("repository", updateUserRepositoryAuthRequest.Repository.ToString());
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
            urlParam.Add("api_version", showApiVersionRequest.ApiVersion.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{api_version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowApiVersionResponse>(response);
        }

        public AsyncInvoker<ShowApiVersionResponse> ShowApiVersionAsyncInvoker(ShowApiVersionRequest showApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("api_version", showApiVersionRequest.ApiVersion.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{api_version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            return new AsyncInvoker<ShowApiVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowApiVersionResponse>);
        }
        
    }
}