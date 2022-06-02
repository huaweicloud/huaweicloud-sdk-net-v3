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
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public CreateImageSyncRepoResponse CreateImageSyncRepo(CreateImageSyncRepoRequest createImageSyncRepoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , createImageSyncRepoRequest.Namespace.ToString());
            urlParam.Add("repository" , createImageSyncRepoRequest.Repository.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/sync_repo",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createImageSyncRepoRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CreateImageSyncRepoResponse>(response);
        }
        
        /// <summary>
        /// 手动同步镜像
        ///
        /// 对于镜像仓库已有的镜像，如果想在其他区域使用，需要手动触发镜像同步。 判断是否同步成功的方法如下：响应状态码为200，无报错信息，表示同步成功。通过SWR管理控制台或调用查询镜像仓库概要信息接口，在目标区域的目标组织下，若存在所同步的镜像版本表示同步成功。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public CreateManualImageSyncRepoResponse CreateManualImageSyncRepo(CreateManualImageSyncRepoRequest createManualImageSyncRepoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , createManualImageSyncRepoRequest.Namespace.ToString());
            urlParam.Add("repository" , createManualImageSyncRepoRequest.Repository.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/sync_images",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createManualImageSyncRepoRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            CreateManualImageSyncRepoResponse createManualImageSyncRepoResponse = JsonUtils.DeSerializeNull<CreateManualImageSyncRepoResponse>(response);
            createManualImageSyncRepoResponse.Body = JsonUtils.DeSerializeList<string>(response);
            return createManualImageSyncRepoResponse;
        }
        
        /// <summary>
        /// 创建组织
        ///
        /// 创建组织
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public CreateNamespaceResponse CreateNamespace(CreateNamespaceRequest createNamespaceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNamespaceRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CreateNamespaceResponse>(response);
        }
        
        /// <summary>
        /// 创建组织权限
        ///
        /// 创建组织权限
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public CreateNamespaceAuthResponse CreateNamespaceAuth(CreateNamespaceAuthRequest createNamespaceAuthRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , createNamespaceAuthRequest.Namespace.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/access",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNamespaceAuthRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CreateNamespaceAuthResponse>(response);
        }
        
        /// <summary>
        /// 在组织下创建镜像仓库
        ///
        /// 在组织下创建镜像仓库。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public CreateRepoResponse CreateRepo(CreateRepoRequest createRepoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , createRepoRequest.Namespace.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepoRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CreateRepoResponse>(response);
        }
        
        /// <summary>
        /// 创建共享帐号
        ///
        /// 创建共享帐号。镜像上传后，您可以共享私有镜像给其他帐号，并授予下载该镜像的权限。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public CreateRepoDomainsResponse CreateRepoDomains(CreateRepoDomainsRequest createRepoDomainsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , createRepoDomainsRequest.Namespace.ToString());
            urlParam.Add("repository" , createRepoDomainsRequest.Repository.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepoDomainsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CreateRepoDomainsResponse>(response);
        }
        
        /// <summary>
        /// 创建镜像老化规则
        ///
        /// 创建镜像老化规则
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public CreateRetentionResponse CreateRetention(CreateRetentionRequest createRetentionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , createRetentionRequest.Namespace.ToString());
            urlParam.Add("repository" , createRetentionRequest.Repository.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRetentionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateRetentionResponse>(response);
        }
        
        /// <summary>
        /// 生成临时登录指令
        ///
        /// 调用该接口，通过获取响应消息头的X-Swr-Dockerlogin的值及响应消息体的host值，可生成临时登录指令。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public CreateSecretResponse CreateSecret(CreateSecretRequest createSecretRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/utils/secret",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSecretRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateSecretResponse>(response);
        }
        
        /// <summary>
        /// 创建触发器
        ///
        /// 创建触发器
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public CreateTriggerResponse CreateTrigger(CreateTriggerRequest createTriggerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , createTriggerRequest.Namespace.ToString());
            urlParam.Add("repository" , createTriggerRequest.Repository.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTriggerRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CreateTriggerResponse>(response);
        }
        
        /// <summary>
        /// 创建镜像权限
        ///
        /// 创建镜像权限
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public CreateUserRepositoryAuthResponse CreateUserRepositoryAuth(CreateUserRepositoryAuthRequest createUserRepositoryAuthRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , createUserRepositoryAuthRequest.Namespace.ToString());
            urlParam.Add("repository" , createUserRepositoryAuthRequest.Repository.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/access",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUserRepositoryAuthRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CreateUserRepositoryAuthResponse>(response);
        }
        
        /// <summary>
        /// 删除镜像自动同步任务
        ///
        /// 根据目标区域、目标组织删除指定的镜像自动同步任务。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public DeleteImageSyncRepoResponse DeleteImageSyncRepo(DeleteImageSyncRepoRequest deleteImageSyncRepoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , deleteImageSyncRepoRequest.Namespace.ToString());
            urlParam.Add("repository" , deleteImageSyncRepoRequest.Repository.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/sync_repo",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteImageSyncRepoRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteImageSyncRepoResponse>(response);
        }
        
        /// <summary>
        /// 删除组织权限
        ///
        /// 删除组织权限
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public DeleteNamespaceAuthResponse DeleteNamespaceAuth(DeleteNamespaceAuthRequest deleteNamespaceAuthRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , deleteNamespaceAuthRequest.Namespace.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/access",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNamespaceAuthRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteNamespaceAuthResponse>(response);
        }
        
        /// <summary>
        /// 删除组织
        ///
        /// 删除组织
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public DeleteNamespacesResponse DeleteNamespaces(DeleteNamespacesRequest deleteNamespacesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , deleteNamespacesRequest.Namespace.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNamespacesRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteNamespacesResponse>(response);
        }
        
        /// <summary>
        /// 删除组织下的镜像仓库
        ///
        /// 删除组织下的镜像仓库。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public DeleteRepoResponse DeleteRepo(DeleteRepoRequest deleteRepoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , deleteRepoRequest.Namespace.ToString());
            urlParam.Add("repository" , deleteRepoRequest.Repository.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepoRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteRepoResponse>(response);
        }
        
        /// <summary>
        /// 删除共享帐号
        ///
        /// 删除共享帐号
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public DeleteRepoDomainsResponse DeleteRepoDomains(DeleteRepoDomainsRequest deleteRepoDomainsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , deleteRepoDomainsRequest.Namespace.ToString());
            urlParam.Add("repository" , deleteRepoDomainsRequest.Repository.ToString());
            urlParam.Add("access_domain" , deleteRepoDomainsRequest.AccessDomain.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains/{access_domain}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepoDomainsRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteRepoDomainsResponse>(response);
        }
        
        /// <summary>
        /// 删除指定tag的镜像
        ///
        /// 删除镜像仓库中指定tag的镜像
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public DeleteRepoTagResponse DeleteRepoTag(DeleteRepoTagRequest deleteRepoTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , deleteRepoTagRequest.Namespace.ToString());
            urlParam.Add("repository" , deleteRepoTagRequest.Repository.ToString());
            urlParam.Add("tag" , deleteRepoTagRequest.Tag.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/tags/{tag}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepoTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteRepoTagResponse>(response);
        }
        
        /// <summary>
        /// 删除镜像老化规则
        ///
        /// 删除镜像老化规则
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public DeleteRetentionResponse DeleteRetention(DeleteRetentionRequest deleteRetentionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , deleteRetentionRequest.Namespace.ToString());
            urlParam.Add("repository" , deleteRetentionRequest.Repository.ToString());
            urlParam.Add("retention_id" , deleteRetentionRequest.RetentionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions/{retention_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRetentionRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteRetentionResponse>(response);
        }
        
        /// <summary>
        /// 删除触发器
        ///
        /// 删除触发器
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public DeleteTriggerResponse DeleteTrigger(DeleteTriggerRequest deleteTriggerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , deleteTriggerRequest.Namespace.ToString());
            urlParam.Add("repository" , deleteTriggerRequest.Repository.ToString());
            urlParam.Add("trigger" , deleteTriggerRequest.Trigger.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers/{trigger}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTriggerRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTriggerResponse>(response);
        }
        
        /// <summary>
        /// 删除镜像权限
        ///
        /// 删除镜像权限
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public DeleteUserRepositoryAuthResponse DeleteUserRepositoryAuth(DeleteUserRepositoryAuthRequest deleteUserRepositoryAuthRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , deleteUserRepositoryAuthRequest.Namespace.ToString());
            urlParam.Add("repository" , deleteUserRepositoryAuthRequest.Repository.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/access",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserRepositoryAuthRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteUserRepositoryAuthResponse>(response);
        }
        
        /// <summary>
        /// 获取镜像自动同步任务列表
        ///
        /// 获取为当前镜像仓库所创建的所有自动同步任务。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ListImageAutoSyncReposDetailsResponse ListImageAutoSyncReposDetails(ListImageAutoSyncReposDetailsRequest listImageAutoSyncReposDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , listImageAutoSyncReposDetailsRequest.Namespace.ToString());
            urlParam.Add("repository" , listImageAutoSyncReposDetailsRequest.Repository.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/sync_repo",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImageAutoSyncReposDetailsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            ListImageAutoSyncReposDetailsResponse listImageAutoSyncReposDetailsResponse = JsonUtils.DeSerializeNull<ListImageAutoSyncReposDetailsResponse>(response);
            listImageAutoSyncReposDetailsResponse.Body = JsonUtils.DeSerializeList<SyncRepo>(response);
            return listImageAutoSyncReposDetailsResponse;
        }
        
        /// <summary>
        /// 查询组织列表
        ///
        /// 查询组织列表
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ListNamespacesResponse ListNamespaces(ListNamespacesRequest listNamespacesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNamespacesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListNamespacesResponse>(response);
        }
        
        /// <summary>
        /// 获取配额信息
        ///
        /// 获取配额信息
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ListQuotasResponse ListQuotas(ListQuotasRequest listQuotasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/projects/{project_id}/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotasRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListQuotasResponse>(response);
        }
        
        /// <summary>
        /// 获取共享帐号列表
        ///
        /// 获取共享帐号列表
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ListRepoDomainsResponse ListRepoDomains(ListRepoDomainsRequest listRepoDomainsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , listRepoDomainsRequest.Namespace.ToString());
            urlParam.Add("repository" , listRepoDomainsRequest.Repository.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepoDomainsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            ListRepoDomainsResponse listRepoDomainsResponse = JsonUtils.DeSerializeNull<ListRepoDomainsResponse>(response);
            listRepoDomainsResponse.Body = JsonUtils.DeSerializeList<ShowRepoDomainsResponse>(response);
            return listRepoDomainsResponse;
        }
        
        /// <summary>
        /// 查询镜像仓库列表
        ///
        /// 查询镜像仓库列表
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ListReposDetailsResponse ListReposDetails(ListReposDetailsRequest listReposDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/repos",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReposDetailsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            ListReposDetailsResponse listReposDetailsResponse = JsonUtils.DeSerializeNull<ListReposDetailsResponse>(response);
            listReposDetailsResponse.Body = JsonUtils.DeSerializeList<ShowReposResp>(response);
            return listReposDetailsResponse;
        }
        
        /// <summary>
        /// 查询镜像tag列表
        ///
        /// 查询镜像tag列表
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ListRepositoryTagsResponse ListRepositoryTags(ListRepositoryTagsRequest listRepositoryTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , listRepositoryTagsRequest.Namespace.ToString());
            urlParam.Add("repository" , listRepositoryTagsRequest.Repository.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            ListRepositoryTagsResponse listRepositoryTagsResponse = JsonUtils.DeSerializeNull<ListRepositoryTagsResponse>(response);
            listRepositoryTagsResponse.Body = JsonUtils.DeSerializeList<ShowReposTagResp>(response);
            return listRepositoryTagsResponse;
        }
        
        /// <summary>
        /// 获取镜像老化记录
        ///
        /// 获取镜像老化记录
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ListRetentionHistoriesResponse ListRetentionHistories(ListRetentionHistoriesRequest listRetentionHistoriesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , listRetentionHistoriesRequest.Namespace.ToString());
            urlParam.Add("repository" , listRetentionHistoriesRequest.Repository.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions/histories",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRetentionHistoriesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListRetentionHistoriesResponse>(response);
        }
        
        /// <summary>
        /// 获取镜像老化规则列表
        ///
        /// 获取镜像老化规则列表
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ListRetentionsResponse ListRetentions(ListRetentionsRequest listRetentionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , listRetentionsRequest.Namespace.ToString());
            urlParam.Add("repository" , listRetentionsRequest.Repository.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRetentionsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            ListRetentionsResponse listRetentionsResponse = JsonUtils.DeSerializeNull<ListRetentionsResponse>(response);
            listRetentionsResponse.Body = JsonUtils.DeSerializeList<Retention>(response);
            return listRetentionsResponse;
        }
        
        /// <summary>
        /// 查询共享镜像列表
        ///
        /// 查询共享镜像列表
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ListSharedReposDetailsResponse ListSharedReposDetails(ListSharedReposDetailsRequest listSharedReposDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/shared-repositories",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSharedReposDetailsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            ListSharedReposDetailsResponse listSharedReposDetailsResponse = JsonUtils.DeSerializeNull<ListSharedReposDetailsResponse>(response);
            listSharedReposDetailsResponse.Body = JsonUtils.DeSerializeList<ShowReposResp>(response);
            return listSharedReposDetailsResponse;
        }
        
        /// <summary>
        /// 获取镜像仓库下的触发器列表
        ///
        /// 获取镜像仓库下的触发器列表
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ListTriggersDetailsResponse ListTriggersDetails(ListTriggersDetailsRequest listTriggersDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , listTriggersDetailsRequest.Namespace.ToString());
            urlParam.Add("repository" , listTriggersDetailsRequest.Repository.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTriggersDetailsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            ListTriggersDetailsResponse listTriggersDetailsResponse = JsonUtils.DeSerializeNull<ListTriggersDetailsResponse>(response);
            listTriggersDetailsResponse.Body = JsonUtils.DeSerializeList<Trigger>(response);
            return listTriggersDetailsResponse;
        }
        
        /// <summary>
        /// 判断共享帐号是否存在
        ///
        /// 判断共享租户是否存在
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ShowAccessDomainResponse ShowAccessDomain(ShowAccessDomainRequest showAccessDomainRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , showAccessDomainRequest.Namespace.ToString());
            urlParam.Add("repository" , showAccessDomainRequest.Repository.ToString());
            urlParam.Add("access_domain" , showAccessDomainRequest.AccessDomain.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains/{access_domain}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAccessDomainRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowAccessDomainResponse>(response);
        }
        
        /// <summary>
        /// 获取组织详情
        ///
        /// 获取组织详情
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ShowNamespaceResponse ShowNamespace(ShowNamespaceRequest showNamespaceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , showNamespaceRequest.Namespace.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNamespaceRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowNamespaceResponse>(response);
        }
        
        /// <summary>
        /// 查询组织权限
        ///
        /// 查询组织权限
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ShowNamespaceAuthResponse ShowNamespaceAuth(ShowNamespaceAuthRequest showNamespaceAuthRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , showNamespaceAuthRequest.Namespace.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/access",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNamespaceAuthRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowNamespaceAuthResponse>(response);
        }
        
        /// <summary>
        /// 查询镜像仓库概要信息
        ///
        /// 查询镜像仓库概要信息
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ShowRepositoryResponse ShowRepository(ShowRepositoryRequest showRepositoryRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , showRepositoryRequest.Namespace.ToString());
            urlParam.Add("repository" , showRepositoryRequest.Repository.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowRepositoryResponse>(response);
        }
        
        /// <summary>
        /// 获取镜像老化规则记录
        ///
        /// 获取镜像老化规则记录
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ShowRetentionResponse ShowRetention(ShowRetentionRequest showRetentionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , showRetentionRequest.Namespace.ToString());
            urlParam.Add("repository" , showRetentionRequest.Repository.ToString());
            urlParam.Add("retention_id" , showRetentionRequest.RetentionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions/{retention_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRetentionRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowRetentionResponse>(response);
        }
        
        /// <summary>
        /// 获取镜像自动同步任务信息
        ///
        /// 创建镜像自动同步任务后，可以通过此接口查询该任务的状态，以判断是否同步成功。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ShowSyncJobResponse ShowSyncJob(ShowSyncJobRequest showSyncJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , showSyncJobRequest.Namespace.ToString());
            urlParam.Add("repository" , showSyncJobRequest.Repository.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/sync_job",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSyncJobRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            ShowSyncJobResponse showSyncJobResponse = JsonUtils.DeSerializeNull<ShowSyncJobResponse>(response);
            showSyncJobResponse.Body = JsonUtils.DeSerializeList<SyncJob>(response);
            return showSyncJobResponse;
        }
        
        /// <summary>
        /// 获取触发器详情
        ///
        /// 获取触发器详情
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ShowTriggerResponse ShowTrigger(ShowTriggerRequest showTriggerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , showTriggerRequest.Namespace.ToString());
            urlParam.Add("repository" , showTriggerRequest.Repository.ToString());
            urlParam.Add("trigger" , showTriggerRequest.Trigger.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers/{trigger}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTriggerRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowTriggerResponse>(response);
        }
        
        /// <summary>
        /// 查询镜像权限
        ///
        /// 查询镜像权限
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ShowUserRepositoryAuthResponse ShowUserRepositoryAuth(ShowUserRepositoryAuthRequest showUserRepositoryAuthRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , showUserRepositoryAuthRequest.Namespace.ToString());
            urlParam.Add("repository" , showUserRepositoryAuthRequest.Repository.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/access",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserRepositoryAuthRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowUserRepositoryAuthResponse>(response);
        }
        
        /// <summary>
        /// 更新组织权限
        ///
        /// 更新组织权限
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public UpdateNamespaceAuthResponse UpdateNamespaceAuth(UpdateNamespaceAuthRequest updateNamespaceAuthRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , updateNamespaceAuthRequest.Namespace.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/access",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNamespaceAuthRequest);
            HttpResponseMessage response = DoHttpRequestSync("PATCH",request);
            return JsonUtils.DeSerializeNull<UpdateNamespaceAuthResponse>(response);
        }
        
        /// <summary>
        /// 更新镜像仓库的概要信息
        ///
        /// 更新租户命名空间下的镜像概要信息，包括镜像类型、是否公有、描述信息
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public UpdateRepoResponse UpdateRepo(UpdateRepoRequest updateRepoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , updateRepoRequest.Namespace.ToString());
            urlParam.Add("repository" , updateRepoRequest.Repository.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepoRequest);
            HttpResponseMessage response = DoHttpRequestSync("PATCH",request);
            return JsonUtils.DeSerializeNull<UpdateRepoResponse>(response);
        }
        
        /// <summary>
        /// 更新共享帐号
        ///
        /// 更新共享帐号
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public UpdateRepoDomainsResponse UpdateRepoDomains(UpdateRepoDomainsRequest updateRepoDomainsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , updateRepoDomainsRequest.Namespace.ToString());
            urlParam.Add("repository" , updateRepoDomainsRequest.Repository.ToString());
            urlParam.Add("access_domain" , updateRepoDomainsRequest.AccessDomain.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains/{access_domain}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepoDomainsRequest);
            HttpResponseMessage response = DoHttpRequestSync("PATCH",request);
            return JsonUtils.DeSerializeNull<UpdateRepoDomainsResponse>(response);
        }
        
        /// <summary>
        /// 修改镜像老化规则
        ///
        /// 修改镜像老化规则
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public UpdateRetentionResponse UpdateRetention(UpdateRetentionRequest updateRetentionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , updateRetentionRequest.Namespace.ToString());
            urlParam.Add("repository" , updateRetentionRequest.Repository.ToString());
            urlParam.Add("retention_id" , updateRetentionRequest.RetentionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions/{retention_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRetentionRequest);
            HttpResponseMessage response = DoHttpRequestSync("PATCH",request);
            return JsonUtils.DeSerializeNull<UpdateRetentionResponse>(response);
        }
        
        /// <summary>
        /// 更新触发器配置
        ///
        /// 更新触发器配置
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public UpdateTriggerResponse UpdateTrigger(UpdateTriggerRequest updateTriggerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , updateTriggerRequest.Namespace.ToString());
            urlParam.Add("repository" , updateTriggerRequest.Repository.ToString());
            urlParam.Add("trigger" , updateTriggerRequest.Trigger.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers/{trigger}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTriggerRequest);
            HttpResponseMessage response = DoHttpRequestSync("PATCH",request);
            return JsonUtils.DeSerializeNull<UpdateTriggerResponse>(response);
        }
        
        /// <summary>
        /// 更新镜像权限
        ///
        /// 更新镜像权限
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public UpdateUserRepositoryAuthResponse UpdateUserRepositoryAuth(UpdateUserRepositoryAuthRequest updateUserRepositoryAuthRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , updateUserRepositoryAuthRequest.Namespace.ToString());
            urlParam.Add("repository" , updateUserRepositoryAuthRequest.Repository.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/access",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserRepositoryAuthRequest);
            HttpResponseMessage response = DoHttpRequestSync("PATCH",request);
            return JsonUtils.DeSerializeNull<UpdateUserRepositoryAuthResponse>(response);
        }
        
        /// <summary>
        /// 查询所有API版本信息
        ///
        /// 查询所有API版本信息
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ListApiVersionsResponse ListApiVersions(ListApiVersionsRequest listApiVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListApiVersionsResponse>(response);
        }
        
        /// <summary>
        /// 查询指定API版本信息
        ///
        /// 查询指定API版本信息
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public ShowApiVersionResponse ShowApiVersion(ShowApiVersionRequest showApiVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("api_version" , showApiVersionRequest.ApiVersion.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{api_version}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowApiVersionResponse>(response);
        }
        
    }
}