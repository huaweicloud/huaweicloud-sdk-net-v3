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
        /// 创建镜像自动同步任务
        /// </summary>
        public async Task<CreateImageSyncRepoResponse> CreateImageSyncRepoAsync(CreateImageSyncRepoRequest createImageSyncRepoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , createImageSyncRepoRequest.Namespace.ToString());
            urlParam.Add("repository" , createImageSyncRepoRequest.Repository.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/sync_repo",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createImageSyncRepoRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateImageSyncRepoResponse>(response);
        }
        
        /// <summary>
        /// 创建组织
        /// </summary>
        public async Task<CreateNamespaceResponse> CreateNamespaceAsync(CreateNamespaceRequest createNamespaceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNamespaceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateNamespaceResponse>(response);
        }
        
        /// <summary>
        /// 创建组织权限
        /// </summary>
        public async Task<CreateNamespaceAuthResponse> CreateNamespaceAuthAsync(CreateNamespaceAuthRequest createNamespaceAuthRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , createNamespaceAuthRequest.Namespace.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/access",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNamespaceAuthRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateNamespaceAuthResponse>(response);
        }
        
        /// <summary>
        /// 创建共享账号
        /// </summary>
        public async Task<CreateRepoDomainsResponse> CreateRepoDomainsAsync(CreateRepoDomainsRequest createRepoDomainsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , createRepoDomainsRequest.Namespace.ToString());
            urlParam.Add("repository" , createRepoDomainsRequest.Repository.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepoDomainsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateRepoDomainsResponse>(response);
        }
        
        /// <summary>
        /// 创建镜像老化规则
        /// </summary>
        public async Task<CreateRetentionResponse> CreateRetentionAsync(CreateRetentionRequest createRetentionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , createRetentionRequest.Namespace.ToString());
            urlParam.Add("repository" , createRetentionRequest.Repository.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRetentionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateRetentionResponse>(response);
        }
        
        /// <summary>
        /// 生成临时登录指令
        /// </summary>
        public async Task<CreateSecretResponse> CreateSecretAsync(CreateSecretRequest createSecretRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/utils/secret",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSecretRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateSecretResponse>(response);
        }
        
        /// <summary>
        /// 创建触发器
        /// </summary>
        public async Task<CreateTriggerResponse> CreateTriggerAsync(CreateTriggerRequest createTriggerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , createTriggerRequest.Namespace.ToString());
            urlParam.Add("repository" , createTriggerRequest.Repository.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTriggerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateTriggerResponse>(response);
        }
        
        /// <summary>
        /// 创建镜像权限
        /// </summary>
        public async Task<CreateUserRepositoryAuthResponse> CreateUserRepositoryAuthAsync(CreateUserRepositoryAuthRequest createUserRepositoryAuthRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , createUserRepositoryAuthRequest.Namespace.ToString());
            urlParam.Add("repository" , createUserRepositoryAuthRequest.Repository.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/access",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createUserRepositoryAuthRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateUserRepositoryAuthResponse>(response);
        }
        
        /// <summary>
        /// 删除镜像自动同步任务
        /// </summary>
        public async Task<DeleteImageSyncRepoResponse> DeleteImageSyncRepoAsync(DeleteImageSyncRepoRequest deleteImageSyncRepoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , deleteImageSyncRepoRequest.Namespace.ToString());
            urlParam.Add("repository" , deleteImageSyncRepoRequest.Repository.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/sync_repo",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteImageSyncRepoRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteImageSyncRepoResponse>(response);
        }
        
        /// <summary>
        /// 删除组织权限
        /// </summary>
        public async Task<DeleteNamespaceAuthResponse> DeleteNamespaceAuthAsync(DeleteNamespaceAuthRequest deleteNamespaceAuthRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , deleteNamespaceAuthRequest.Namespace.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/access",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNamespaceAuthRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteNamespaceAuthResponse>(response);
        }
        
        /// <summary>
        /// 删除组织
        /// </summary>
        public async Task<DeleteNamespacesResponse> DeleteNamespacesAsync(DeleteNamespacesRequest deleteNamespacesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , deleteNamespacesRequest.Namespace.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNamespacesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteNamespacesResponse>(response);
        }
        
        /// <summary>
        /// 删除组织下的镜像仓库
        /// </summary>
        public async Task<DeleteRepoResponse> DeleteRepoAsync(DeleteRepoRequest deleteRepoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , deleteRepoRequest.Namespace.ToString());
            urlParam.Add("repository" , deleteRepoRequest.Repository.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepoRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteRepoResponse>(response);
        }
        
        /// <summary>
        /// 删除共享账号
        /// </summary>
        public async Task<DeleteRepoDomainsResponse> DeleteRepoDomainsAsync(DeleteRepoDomainsRequest deleteRepoDomainsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , deleteRepoDomainsRequest.Namespace.ToString());
            urlParam.Add("repository" , deleteRepoDomainsRequest.Repository.ToString());
            urlParam.Add("access_domain" , deleteRepoDomainsRequest.AccessDomain.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains/{access_domain}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepoDomainsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteRepoDomainsResponse>(response);
        }
        
        /// <summary>
        /// 删除指定tag的镜像
        /// </summary>
        public async Task<DeleteRepoTagResponse> DeleteRepoTagAsync(DeleteRepoTagRequest deleteRepoTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , deleteRepoTagRequest.Namespace.ToString());
            urlParam.Add("repository" , deleteRepoTagRequest.Repository.ToString());
            urlParam.Add("tag" , deleteRepoTagRequest.Tag.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/tags/{tag}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepoTagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteRepoTagResponse>(response);
        }
        
        /// <summary>
        /// 删除镜像老化规则
        /// </summary>
        public async Task<DeleteRetentionResponse> DeleteRetentionAsync(DeleteRetentionRequest deleteRetentionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , deleteRetentionRequest.Namespace.ToString());
            urlParam.Add("repository" , deleteRetentionRequest.Repository.ToString());
            urlParam.Add("retention_id" , deleteRetentionRequest.RetentionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions/{retention_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRetentionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteRetentionResponse>(response);
        }
        
        /// <summary>
        /// 删除触发器
        /// </summary>
        public async Task<DeleteTriggerResponse> DeleteTriggerAsync(DeleteTriggerRequest deleteTriggerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , deleteTriggerRequest.Namespace.ToString());
            urlParam.Add("repository" , deleteTriggerRequest.Repository.ToString());
            urlParam.Add("trigger" , deleteTriggerRequest.Trigger.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers/{trigger}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTriggerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTriggerResponse>(response);
        }
        
        /// <summary>
        /// 删除镜像权限
        /// </summary>
        public async Task<DeleteUserRepositoryAuthResponse> DeleteUserRepositoryAuthAsync(DeleteUserRepositoryAuthRequest deleteUserRepositoryAuthRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , deleteUserRepositoryAuthRequest.Namespace.ToString());
            urlParam.Add("repository" , deleteUserRepositoryAuthRequest.Repository.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/access",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserRepositoryAuthRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteUserRepositoryAuthResponse>(response);
        }
        
        /// <summary>
        /// 获取镜像自动同步任务列表
        /// </summary>
        public async Task<ListImageAutoSyncReposDetailsResponse> ListImageAutoSyncReposDetailsAsync(ListImageAutoSyncReposDetailsRequest listImageAutoSyncReposDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , listImageAutoSyncReposDetailsRequest.Namespace.ToString());
            urlParam.Add("repository" , listImageAutoSyncReposDetailsRequest.Repository.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/sync_repo",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImageAutoSyncReposDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            ListImageAutoSyncReposDetailsResponse listImageAutoSyncReposDetailsResponse = JsonUtils.DeSerializeNull<ListImageAutoSyncReposDetailsResponse>(response);
            listImageAutoSyncReposDetailsResponse.Body = JsonUtils.DeSerializeList<SyncRepo>(response);
            return listImageAutoSyncReposDetailsResponse;
        }
        
        /// <summary>
        /// 查询组织列表
        /// </summary>
        public async Task<ListNamespacesResponse> ListNamespacesAsync(ListNamespacesRequest listNamespacesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNamespacesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListNamespacesResponse>(response);
        }
        
        /// <summary>
        /// 获取共享账号列表
        /// </summary>
        public async Task<ListRepoDomainsResponse> ListRepoDomainsAsync(ListRepoDomainsRequest listRepoDomainsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , listRepoDomainsRequest.Namespace.ToString());
            urlParam.Add("repository" , listRepoDomainsRequest.Repository.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepoDomainsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            ListRepoDomainsResponse listRepoDomainsResponse = JsonUtils.DeSerializeNull<ListRepoDomainsResponse>(response);
            listRepoDomainsResponse.Body = JsonUtils.DeSerializeList<ShowRepoDomainsResponse>(response);
            return listRepoDomainsResponse;
        }
        
        /// <summary>
        /// 查询镜像tag列表
        /// </summary>
        public async Task<ListRepositoryTagsResponse> ListRepositoryTagsAsync(ListRepositoryTagsRequest listRepositoryTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , listRepositoryTagsRequest.Namespace.ToString());
            urlParam.Add("repository" , listRepositoryTagsRequest.Repository.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            ListRepositoryTagsResponse listRepositoryTagsResponse = JsonUtils.DeSerializeNull<ListRepositoryTagsResponse>(response);
            listRepositoryTagsResponse.Body = JsonUtils.DeSerializeList<ShowReposTagResp>(response);
            return listRepositoryTagsResponse;
        }
        
        /// <summary>
        /// 获取镜像老化记录
        /// </summary>
        public async Task<ListRetentionHistoriesResponse> ListRetentionHistoriesAsync(ListRetentionHistoriesRequest listRetentionHistoriesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , listRetentionHistoriesRequest.Namespace.ToString());
            urlParam.Add("repository" , listRetentionHistoriesRequest.Repository.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions/histories",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRetentionHistoriesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListRetentionHistoriesResponse>(response);
        }
        
        /// <summary>
        /// 获取镜像老化规则列表
        /// </summary>
        public async Task<ListRetentionsResponse> ListRetentionsAsync(ListRetentionsRequest listRetentionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , listRetentionsRequest.Namespace.ToString());
            urlParam.Add("repository" , listRetentionsRequest.Repository.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRetentionsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            ListRetentionsResponse listRetentionsResponse = JsonUtils.DeSerializeNull<ListRetentionsResponse>(response);
            listRetentionsResponse.Body = JsonUtils.DeSerializeList<Retention>(response);
            return listRetentionsResponse;
        }
        
        /// <summary>
        /// 获取镜像仓库下的触发器列表
        /// </summary>
        public async Task<ListTriggersDetailsResponse> ListTriggersDetailsAsync(ListTriggersDetailsRequest listTriggersDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , listTriggersDetailsRequest.Namespace.ToString());
            urlParam.Add("repository" , listTriggersDetailsRequest.Repository.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTriggersDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            ListTriggersDetailsResponse listTriggersDetailsResponse = JsonUtils.DeSerializeNull<ListTriggersDetailsResponse>(response);
            listTriggersDetailsResponse.Body = JsonUtils.DeSerializeList<Trigger>(response);
            return listTriggersDetailsResponse;
        }
        
        /// <summary>
        /// 判断共享账号是否存在
        /// </summary>
        public async Task<ShowAccessDomainResponse> ShowAccessDomainAsync(ShowAccessDomainRequest showAccessDomainRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , showAccessDomainRequest.Namespace.ToString());
            urlParam.Add("repository" , showAccessDomainRequest.Repository.ToString());
            urlParam.Add("access_domain" , showAccessDomainRequest.AccessDomain.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains/{access_domain}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAccessDomainRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAccessDomainResponse>(response);
        }
        
        /// <summary>
        /// 获取组织详情
        /// </summary>
        public async Task<ShowNamespaceResponse> ShowNamespaceAsync(ShowNamespaceRequest showNamespaceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , showNamespaceRequest.Namespace.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNamespaceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowNamespaceResponse>(response);
        }
        
        /// <summary>
        /// 查询组织权限
        /// </summary>
        public async Task<ShowNamespaceAuthResponse> ShowNamespaceAuthAsync(ShowNamespaceAuthRequest showNamespaceAuthRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , showNamespaceAuthRequest.Namespace.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/access",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNamespaceAuthRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowNamespaceAuthResponse>(response);
        }
        
        /// <summary>
        /// 查询镜像概要信息
        /// </summary>
        public async Task<ShowRepositoryResponse> ShowRepositoryAsync(ShowRepositoryRequest showRepositoryRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , showRepositoryRequest.Namespace.ToString());
            urlParam.Add("repository" , showRepositoryRequest.Repository.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowRepositoryResponse>(response);
        }
        
        /// <summary>
        /// 获取镜像老化规则记录
        /// </summary>
        public async Task<ShowRetentionResponse> ShowRetentionAsync(ShowRetentionRequest showRetentionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , showRetentionRequest.Namespace.ToString());
            urlParam.Add("repository" , showRetentionRequest.Repository.ToString());
            urlParam.Add("retention_id" , showRetentionRequest.RetentionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions/{retention_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRetentionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowRetentionResponse>(response);
        }
        
        /// <summary>
        /// 获取触发器详情
        /// </summary>
        public async Task<ShowTriggerResponse> ShowTriggerAsync(ShowTriggerRequest showTriggerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , showTriggerRequest.Namespace.ToString());
            urlParam.Add("repository" , showTriggerRequest.Repository.ToString());
            urlParam.Add("trigger" , showTriggerRequest.Trigger.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers/{trigger}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTriggerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowTriggerResponse>(response);
        }
        
        /// <summary>
        /// 查询镜像权限
        /// </summary>
        public async Task<ShowUserRepositoryAuthResponse> ShowUserRepositoryAuthAsync(ShowUserRepositoryAuthRequest showUserRepositoryAuthRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , showUserRepositoryAuthRequest.Namespace.ToString());
            urlParam.Add("repository" , showUserRepositoryAuthRequest.Repository.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/access",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserRepositoryAuthRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowUserRepositoryAuthResponse>(response);
        }
        
        /// <summary>
        /// 更新共享账号
        /// </summary>
        public async Task<UpdateRepoDomainsResponse> UpdateRepoDomainsAsync(UpdateRepoDomainsRequest updateRepoDomainsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , updateRepoDomainsRequest.Namespace.ToString());
            urlParam.Add("repository" , updateRepoDomainsRequest.Repository.ToString());
            urlParam.Add("access_domain" , updateRepoDomainsRequest.AccessDomain.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repositories/{repository}/access-domains/{access_domain}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepoDomainsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PATCH",request);
            return JsonUtils.DeSerializeNull<UpdateRepoDomainsResponse>(response);
        }
        
        /// <summary>
        /// 修改镜像老化规则
        /// </summary>
        public async Task<UpdateRetentionResponse> UpdateRetentionAsync(UpdateRetentionRequest updateRetentionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , updateRetentionRequest.Namespace.ToString());
            urlParam.Add("repository" , updateRetentionRequest.Repository.ToString());
            urlParam.Add("retention_id" , updateRetentionRequest.RetentionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/retentions/{retention_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRetentionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PATCH",request);
            return JsonUtils.DeSerializeNull<UpdateRetentionResponse>(response);
        }
        
        /// <summary>
        /// 更新触发器配置
        /// </summary>
        public async Task<UpdateTriggerResponse> UpdateTriggerAsync(UpdateTriggerRequest updateTriggerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , updateTriggerRequest.Namespace.ToString());
            urlParam.Add("repository" , updateTriggerRequest.Repository.ToString());
            urlParam.Add("trigger" , updateTriggerRequest.Trigger.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/triggers/{trigger}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTriggerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PATCH",request);
            return JsonUtils.DeSerializeNull<UpdateTriggerResponse>(response);
        }
        
        /// <summary>
        /// 更新镜像权限
        /// </summary>
        public async Task<UpdateUserRepositoryAuthResponse> UpdateUserRepositoryAuthAsync(UpdateUserRepositoryAuthRequest updateUserRepositoryAuthRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , updateUserRepositoryAuthRequest.Namespace.ToString());
            urlParam.Add("repository" , updateUserRepositoryAuthRequest.Repository.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/manage/namespaces/{namespace}/repos/{repository}/access",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserRepositoryAuthRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PATCH",request);
            return JsonUtils.DeSerializeNull<UpdateUserRepositoryAuthResponse>(response);
        }
        
        /// <summary>
        /// 查询指定API版本信息
        /// </summary>
        public async Task<ShowApiVersionResponse> ShowApiVersionAsync(ShowApiVersionRequest showApiVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("api_version" , showApiVersionRequest.ApiVersion.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{api_version}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowApiVersionResponse>(response);
        }
        
    }
}