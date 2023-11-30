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
        /// 创建镜像自动同步任务
        ///
        /// 创建镜像自动同步任务，帮助您把最新推送的镜像自动同步到其他区域镜像仓库内。 镜像自动同步帮助您把最新推送的镜像自动同步到其他区域镜像仓库内，后期镜像有更新时，目标仓库的镜像也会自动更新，但已有的镜像不会自动同步。已有镜像的同步需要手动操作，详情请参见手动同步镜像。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateImageSyncRepoResponse CreateImageSyncRepo(CreateImageSyncRepoRequest createImageSyncRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", createImageSyncRepoRequest.Namespace.ToString());
            urlParam.Add("repository", createImageSyncRepoRequest.Repository.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/sync_repo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createImageSyncRepoRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateImageSyncRepoResponse>(response);
        }

        public SyncInvoker<CreateImageSyncRepoResponse> CreateImageSyncRepoInvoker(CreateImageSyncRepoRequest createImageSyncRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", createImageSyncRepoRequest.Namespace.ToString());
            urlParam.Add("repository", createImageSyncRepoRequest.Repository.ToString());
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
            urlParam.Add("namespace", createManualImageSyncRepoRequest.Namespace.ToString());
            urlParam.Add("repository", createManualImageSyncRepoRequest.Repository.ToString());
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
            urlParam.Add("namespace", createManualImageSyncRepoRequest.Namespace.ToString());
            urlParam.Add("repository", createManualImageSyncRepoRequest.Repository.ToString());
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
            urlParam.Add("namespace", createNamespaceAuthRequest.Namespace.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNamespaceAuthRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateNamespaceAuthResponse>(response);
        }

        public SyncInvoker<CreateNamespaceAuthResponse> CreateNamespaceAuthInvoker(CreateNamespaceAuthRequest createNamespaceAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", createNamespaceAuthRequest.Namespace.ToString());
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
            urlParam.Add("namespace", createRepoRequest.Namespace.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepoRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateRepoResponse>(response);
        }

        public SyncInvoker<CreateRepoResponse> CreateRepoInvoker(CreateRepoRequest createRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", createRepoRequest.Namespace.ToString());
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
            urlParam.Add("namespace", createRepoDomainsRequest.Namespace.ToString());
            urlParam.Add("repository", createRepoDomainsRequest.Repository.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepoDomainsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateRepoDomainsResponse>(response);
        }

        public SyncInvoker<CreateRepoDomainsResponse> CreateRepoDomainsInvoker(CreateRepoDomainsRequest createRepoDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", createRepoDomainsRequest.Namespace.ToString());
            urlParam.Add("repository", createRepoDomainsRequest.Repository.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepoDomainsRequest);
            return new SyncInvoker<CreateRepoDomainsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateRepoDomainsResponse>);
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
            urlParam.Add("namespace", createRetentionRequest.Namespace.ToString());
            urlParam.Add("repository", createRetentionRequest.Repository.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRetentionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateRetentionResponse>(response);
        }

        public SyncInvoker<CreateRetentionResponse> CreateRetentionInvoker(CreateRetentionRequest createRetentionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", createRetentionRequest.Namespace.ToString());
            urlParam.Add("repository", createRetentionRequest.Repository.ToString());
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
            urlParam.Add("namespace", createTriggerRequest.Namespace.ToString());
            urlParam.Add("repository", createTriggerRequest.Repository.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTriggerRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateTriggerResponse>(response);
        }

        public SyncInvoker<CreateTriggerResponse> CreateTriggerInvoker(CreateTriggerRequest createTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", createTriggerRequest.Namespace.ToString());
            urlParam.Add("repository", createTriggerRequest.Repository.ToString());
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
            urlParam.Add("namespace", createUserRepositoryAuthRequest.Namespace.ToString());
            urlParam.Add("repository", createUserRepositoryAuthRequest.Repository.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUserRepositoryAuthRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateUserRepositoryAuthResponse>(response);
        }

        public SyncInvoker<CreateUserRepositoryAuthResponse> CreateUserRepositoryAuthInvoker(CreateUserRepositoryAuthRequest createUserRepositoryAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", createUserRepositoryAuthRequest.Namespace.ToString());
            urlParam.Add("repository", createUserRepositoryAuthRequest.Repository.ToString());
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
            urlParam.Add("namespace", deleteImageSyncRepoRequest.Namespace.ToString());
            urlParam.Add("repository", deleteImageSyncRepoRequest.Repository.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/sync_repo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteImageSyncRepoRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteImageSyncRepoResponse>(response);
        }

        public SyncInvoker<DeleteImageSyncRepoResponse> DeleteImageSyncRepoInvoker(DeleteImageSyncRepoRequest deleteImageSyncRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", deleteImageSyncRepoRequest.Namespace.ToString());
            urlParam.Add("repository", deleteImageSyncRepoRequest.Repository.ToString());
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
            urlParam.Add("namespace", deleteNamespaceAuthRequest.Namespace.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNamespaceAuthRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteNamespaceAuthResponse>(response);
        }

        public SyncInvoker<DeleteNamespaceAuthResponse> DeleteNamespaceAuthInvoker(DeleteNamespaceAuthRequest deleteNamespaceAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", deleteNamespaceAuthRequest.Namespace.ToString());
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
            urlParam.Add("namespace", deleteNamespacesRequest.Namespace.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNamespacesRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteNamespacesResponse>(response);
        }

        public SyncInvoker<DeleteNamespacesResponse> DeleteNamespacesInvoker(DeleteNamespacesRequest deleteNamespacesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", deleteNamespacesRequest.Namespace.ToString());
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
            urlParam.Add("namespace", deleteRepoRequest.Namespace.ToString());
            urlParam.Add("repository", deleteRepoRequest.Repository.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepoRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRepoResponse>(response);
        }

        public SyncInvoker<DeleteRepoResponse> DeleteRepoInvoker(DeleteRepoRequest deleteRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", deleteRepoRequest.Namespace.ToString());
            urlParam.Add("repository", deleteRepoRequest.Repository.ToString());
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
            urlParam.Add("namespace", deleteRepoDomainsRequest.Namespace.ToString());
            urlParam.Add("repository", deleteRepoDomainsRequest.Repository.ToString());
            urlParam.Add("access_domain", deleteRepoDomainsRequest.AccessDomain.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains/{access_domain}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepoDomainsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRepoDomainsResponse>(response);
        }

        public SyncInvoker<DeleteRepoDomainsResponse> DeleteRepoDomainsInvoker(DeleteRepoDomainsRequest deleteRepoDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", deleteRepoDomainsRequest.Namespace.ToString());
            urlParam.Add("repository", deleteRepoDomainsRequest.Repository.ToString());
            urlParam.Add("access_domain", deleteRepoDomainsRequest.AccessDomain.ToString());
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
            urlParam.Add("namespace", deleteRepoTagRequest.Namespace.ToString());
            urlParam.Add("repository", deleteRepoTagRequest.Repository.ToString());
            urlParam.Add("tag", deleteRepoTagRequest.Tag.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/tags/{tag}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepoTagRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRepoTagResponse>(response);
        }

        public SyncInvoker<DeleteRepoTagResponse> DeleteRepoTagInvoker(DeleteRepoTagRequest deleteRepoTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", deleteRepoTagRequest.Namespace.ToString());
            urlParam.Add("repository", deleteRepoTagRequest.Repository.ToString());
            urlParam.Add("tag", deleteRepoTagRequest.Tag.ToString());
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
            urlParam.Add("namespace", deleteRetentionRequest.Namespace.ToString());
            urlParam.Add("repository", deleteRetentionRequest.Repository.ToString());
            urlParam.Add("retention_id", deleteRetentionRequest.RetentionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions/{retention_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRetentionRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRetentionResponse>(response);
        }

        public SyncInvoker<DeleteRetentionResponse> DeleteRetentionInvoker(DeleteRetentionRequest deleteRetentionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", deleteRetentionRequest.Namespace.ToString());
            urlParam.Add("repository", deleteRetentionRequest.Repository.ToString());
            urlParam.Add("retention_id", deleteRetentionRequest.RetentionId.ToString());
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
            urlParam.Add("namespace", deleteTriggerRequest.Namespace.ToString());
            urlParam.Add("repository", deleteTriggerRequest.Repository.ToString());
            urlParam.Add("trigger", deleteTriggerRequest.Trigger.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers/{trigger}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTriggerRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTriggerResponse>(response);
        }

        public SyncInvoker<DeleteTriggerResponse> DeleteTriggerInvoker(DeleteTriggerRequest deleteTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", deleteTriggerRequest.Namespace.ToString());
            urlParam.Add("repository", deleteTriggerRequest.Repository.ToString());
            urlParam.Add("trigger", deleteTriggerRequest.Trigger.ToString());
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
            urlParam.Add("namespace", deleteUserRepositoryAuthRequest.Namespace.ToString());
            urlParam.Add("repository", deleteUserRepositoryAuthRequest.Repository.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserRepositoryAuthRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteUserRepositoryAuthResponse>(response);
        }

        public SyncInvoker<DeleteUserRepositoryAuthResponse> DeleteUserRepositoryAuthInvoker(DeleteUserRepositoryAuthRequest deleteUserRepositoryAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", deleteUserRepositoryAuthRequest.Namespace.ToString());
            urlParam.Add("repository", deleteUserRepositoryAuthRequest.Repository.ToString());
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
            urlParam.Add("namespace", listImageAutoSyncReposDetailsRequest.Namespace.ToString());
            urlParam.Add("repository", listImageAutoSyncReposDetailsRequest.Repository.ToString());
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
            urlParam.Add("namespace", listImageAutoSyncReposDetailsRequest.Namespace.ToString());
            urlParam.Add("repository", listImageAutoSyncReposDetailsRequest.Repository.ToString());
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
        /// 获取共享帐号列表
        ///
        /// 获取共享帐号列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRepoDomainsResponse ListRepoDomains(ListRepoDomainsRequest listRepoDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", listRepoDomainsRequest.Namespace.ToString());
            urlParam.Add("repository", listRepoDomainsRequest.Repository.ToString());
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
            urlParam.Add("namespace", listRepoDomainsRequest.Namespace.ToString());
            urlParam.Add("repository", listRepoDomainsRequest.Repository.ToString());
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
        /// 查询镜像tag列表
        ///
        /// 查询镜像tag列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRepositoryTagsResponse ListRepositoryTags(ListRepositoryTagsRequest listRepositoryTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", listRepositoryTagsRequest.Namespace.ToString());
            urlParam.Add("repository", listRepositoryTagsRequest.Repository.ToString());
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
            urlParam.Add("namespace", listRepositoryTagsRequest.Namespace.ToString());
            urlParam.Add("repository", listRepositoryTagsRequest.Repository.ToString());
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
            urlParam.Add("namespace", listRetentionHistoriesRequest.Namespace.ToString());
            urlParam.Add("repository", listRetentionHistoriesRequest.Repository.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions/histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRetentionHistoriesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRetentionHistoriesResponse>(response);
        }

        public SyncInvoker<ListRetentionHistoriesResponse> ListRetentionHistoriesInvoker(ListRetentionHistoriesRequest listRetentionHistoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", listRetentionHistoriesRequest.Namespace.ToString());
            urlParam.Add("repository", listRetentionHistoriesRequest.Repository.ToString());
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
            urlParam.Add("namespace", listRetentionsRequest.Namespace.ToString());
            urlParam.Add("repository", listRetentionsRequest.Repository.ToString());
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
            urlParam.Add("namespace", listRetentionsRequest.Namespace.ToString());
            urlParam.Add("repository", listRetentionsRequest.Repository.ToString());
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
        /// 获取镜像仓库下的触发器列表
        ///
        /// 获取镜像仓库下的触发器列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTriggersDetailsResponse ListTriggersDetails(ListTriggersDetailsRequest listTriggersDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", listTriggersDetailsRequest.Namespace.ToString());
            urlParam.Add("repository", listTriggersDetailsRequest.Repository.ToString());
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
            urlParam.Add("namespace", listTriggersDetailsRequest.Namespace.ToString());
            urlParam.Add("repository", listTriggersDetailsRequest.Repository.ToString());
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
            urlParam.Add("namespace", showAccessDomainRequest.Namespace.ToString());
            urlParam.Add("repository", showAccessDomainRequest.Repository.ToString());
            urlParam.Add("access_domain", showAccessDomainRequest.AccessDomain.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains/{access_domain}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAccessDomainRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAccessDomainResponse>(response);
        }

        public SyncInvoker<ShowAccessDomainResponse> ShowAccessDomainInvoker(ShowAccessDomainRequest showAccessDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", showAccessDomainRequest.Namespace.ToString());
            urlParam.Add("repository", showAccessDomainRequest.Repository.ToString());
            urlParam.Add("access_domain", showAccessDomainRequest.AccessDomain.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains/{access_domain}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAccessDomainRequest);
            return new SyncInvoker<ShowAccessDomainResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAccessDomainResponse>);
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
            urlParam.Add("namespace", showNamespaceRequest.Namespace.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNamespaceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowNamespaceResponse>(response);
        }

        public SyncInvoker<ShowNamespaceResponse> ShowNamespaceInvoker(ShowNamespaceRequest showNamespaceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", showNamespaceRequest.Namespace.ToString());
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
            urlParam.Add("namespace", showNamespaceAuthRequest.Namespace.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNamespaceAuthRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowNamespaceAuthResponse>(response);
        }

        public SyncInvoker<ShowNamespaceAuthResponse> ShowNamespaceAuthInvoker(ShowNamespaceAuthRequest showNamespaceAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", showNamespaceAuthRequest.Namespace.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNamespaceAuthRequest);
            return new SyncInvoker<ShowNamespaceAuthResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNamespaceAuthResponse>);
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
            urlParam.Add("namespace", showRepositoryRequest.Namespace.ToString());
            urlParam.Add("repository", showRepositoryRequest.Repository.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRepositoryResponse>(response);
        }

        public SyncInvoker<ShowRepositoryResponse> ShowRepositoryInvoker(ShowRepositoryRequest showRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", showRepositoryRequest.Namespace.ToString());
            urlParam.Add("repository", showRepositoryRequest.Repository.ToString());
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
            urlParam.Add("namespace", showRetentionRequest.Namespace.ToString());
            urlParam.Add("repository", showRetentionRequest.Repository.ToString());
            urlParam.Add("retention_id", showRetentionRequest.RetentionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions/{retention_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRetentionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRetentionResponse>(response);
        }

        public SyncInvoker<ShowRetentionResponse> ShowRetentionInvoker(ShowRetentionRequest showRetentionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", showRetentionRequest.Namespace.ToString());
            urlParam.Add("repository", showRetentionRequest.Repository.ToString());
            urlParam.Add("retention_id", showRetentionRequest.RetentionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions/{retention_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRetentionRequest);
            return new SyncInvoker<ShowRetentionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRetentionResponse>);
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
            urlParam.Add("namespace", showSyncJobRequest.Namespace.ToString());
            urlParam.Add("repository", showSyncJobRequest.Repository.ToString());
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
            urlParam.Add("namespace", showSyncJobRequest.Namespace.ToString());
            urlParam.Add("repository", showSyncJobRequest.Repository.ToString());
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
            urlParam.Add("namespace", showTriggerRequest.Namespace.ToString());
            urlParam.Add("repository", showTriggerRequest.Repository.ToString());
            urlParam.Add("trigger", showTriggerRequest.Trigger.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers/{trigger}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTriggerRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTriggerResponse>(response);
        }

        public SyncInvoker<ShowTriggerResponse> ShowTriggerInvoker(ShowTriggerRequest showTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", showTriggerRequest.Namespace.ToString());
            urlParam.Add("repository", showTriggerRequest.Repository.ToString());
            urlParam.Add("trigger", showTriggerRequest.Trigger.ToString());
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
            urlParam.Add("namespace", showUserRepositoryAuthRequest.Namespace.ToString());
            urlParam.Add("repository", showUserRepositoryAuthRequest.Repository.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserRepositoryAuthRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowUserRepositoryAuthResponse>(response);
        }

        public SyncInvoker<ShowUserRepositoryAuthResponse> ShowUserRepositoryAuthInvoker(ShowUserRepositoryAuthRequest showUserRepositoryAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", showUserRepositoryAuthRequest.Namespace.ToString());
            urlParam.Add("repository", showUserRepositoryAuthRequest.Repository.ToString());
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
            urlParam.Add("namespace", updateNamespaceAuthRequest.Namespace.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNamespaceAuthRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerializeNull<UpdateNamespaceAuthResponse>(response);
        }

        public SyncInvoker<UpdateNamespaceAuthResponse> UpdateNamespaceAuthInvoker(UpdateNamespaceAuthRequest updateNamespaceAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", updateNamespaceAuthRequest.Namespace.ToString());
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
            urlParam.Add("namespace", updateRepoRequest.Namespace.ToString());
            urlParam.Add("repository", updateRepoRequest.Repository.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepoRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerializeNull<UpdateRepoResponse>(response);
        }

        public SyncInvoker<UpdateRepoResponse> UpdateRepoInvoker(UpdateRepoRequest updateRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", updateRepoRequest.Namespace.ToString());
            urlParam.Add("repository", updateRepoRequest.Repository.ToString());
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
            urlParam.Add("namespace", updateRepoDomainsRequest.Namespace.ToString());
            urlParam.Add("repository", updateRepoDomainsRequest.Repository.ToString());
            urlParam.Add("access_domain", updateRepoDomainsRequest.AccessDomain.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains/{access_domain}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepoDomainsRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerializeNull<UpdateRepoDomainsResponse>(response);
        }

        public SyncInvoker<UpdateRepoDomainsResponse> UpdateRepoDomainsInvoker(UpdateRepoDomainsRequest updateRepoDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", updateRepoDomainsRequest.Namespace.ToString());
            urlParam.Add("repository", updateRepoDomainsRequest.Repository.ToString());
            urlParam.Add("access_domain", updateRepoDomainsRequest.AccessDomain.ToString());
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
            urlParam.Add("namespace", updateRetentionRequest.Namespace.ToString());
            urlParam.Add("repository", updateRetentionRequest.Repository.ToString());
            urlParam.Add("retention_id", updateRetentionRequest.RetentionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions/{retention_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRetentionRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerializeNull<UpdateRetentionResponse>(response);
        }

        public SyncInvoker<UpdateRetentionResponse> UpdateRetentionInvoker(UpdateRetentionRequest updateRetentionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", updateRetentionRequest.Namespace.ToString());
            urlParam.Add("repository", updateRetentionRequest.Repository.ToString());
            urlParam.Add("retention_id", updateRetentionRequest.RetentionId.ToString());
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
            urlParam.Add("namespace", updateTriggerRequest.Namespace.ToString());
            urlParam.Add("repository", updateTriggerRequest.Repository.ToString());
            urlParam.Add("trigger", updateTriggerRequest.Trigger.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers/{trigger}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTriggerRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerializeNull<UpdateTriggerResponse>(response);
        }

        public SyncInvoker<UpdateTriggerResponse> UpdateTriggerInvoker(UpdateTriggerRequest updateTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", updateTriggerRequest.Namespace.ToString());
            urlParam.Add("repository", updateTriggerRequest.Repository.ToString());
            urlParam.Add("trigger", updateTriggerRequest.Trigger.ToString());
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
            urlParam.Add("namespace", updateUserRepositoryAuthRequest.Namespace.ToString());
            urlParam.Add("repository", updateUserRepositoryAuthRequest.Repository.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserRepositoryAuthRequest);
            var response = DoHttpRequestSync("PATCH", request);
            return JsonUtils.DeSerializeNull<UpdateUserRepositoryAuthResponse>(response);
        }

        public SyncInvoker<UpdateUserRepositoryAuthResponse> UpdateUserRepositoryAuthInvoker(UpdateUserRepositoryAuthRequest updateUserRepositoryAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace", updateUserRepositoryAuthRequest.Namespace.ToString());
            urlParam.Add("repository", updateUserRepositoryAuthRequest.Repository.ToString());
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
            urlParam.Add("api_version", showApiVersionRequest.ApiVersion.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{api_version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowApiVersionResponse>(response);
        }

        public SyncInvoker<ShowApiVersionResponse> ShowApiVersionInvoker(ShowApiVersionRequest showApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("api_version", showApiVersionRequest.ApiVersion.ToString());
            var urlPath = HttpUtils.AddUrlPath("/{api_version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            return new SyncInvoker<ShowApiVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowApiVersionResponse>);
        }
        
    }
}