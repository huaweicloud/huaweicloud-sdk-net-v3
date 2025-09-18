using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.CodeArtsArtifact.V2.Model;

namespace HuaweiCloud.SDK.CodeArtsArtifact.V2
{
    public partial class CodeArtsArtifactClient : Client
    {
        public static ClientBuilder<CodeArtsArtifactClient> NewBuilder()
        {
            return new ClientBuilder<CodeArtsArtifactClient>();
        }

        
        /// <summary>
        /// 批量删除回收站
        ///
        /// 批量删除回收站
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteTrashesResponse BatchDeleteTrashes(BatchDeleteTrashesRequest batchDeleteTrashesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/trashes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteTrashesRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeleteTrashesResponse>(response);
        }

        public SyncInvoker<BatchDeleteTrashesResponse> BatchDeleteTrashesInvoker(BatchDeleteTrashesRequest batchDeleteTrashesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/trashes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteTrashesRequest);
            return new SyncInvoker<BatchDeleteTrashesResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteTrashesResponse>);
        }
        
        /// <summary>
        /// 批量还原回收站
        ///
        /// 批量还原回收站
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchRestoreRepoResponse BatchRestoreRepo(BatchRestoreRepoRequest batchRestoreRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/trashes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRestoreRepoRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<BatchRestoreRepoResponse>(response);
        }

        public SyncInvoker<BatchRestoreRepoResponse> BatchRestoreRepoInvoker(BatchRestoreRepoRequest batchRestoreRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/trashes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRestoreRepoRequest);
            return new SyncInvoker<BatchRestoreRepoResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchRestoreRepoResponse>);
        }
        
        /// <summary>
        /// 创建非maven仓库
        ///
        /// 创建非maven仓库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateArtifactoryResponse CreateArtifactory(CreateArtifactoryRequest createArtifactoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/artifact/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createArtifactoryRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateArtifactoryResponse>(response);
        }

        public SyncInvoker<CreateArtifactoryResponse> CreateArtifactoryInvoker(CreateArtifactoryRequest createArtifactoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/artifact/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createArtifactoryRequest);
            return new SyncInvoker<CreateArtifactoryResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateArtifactoryResponse>);
        }
        
        /// <summary>
        /// 关注组件/取消关注组件
        ///
        /// 关注组件/取消关注组件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAttentionResponse CreateAttention(CreateAttentionRequest createAttentionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/attention", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAttentionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAttentionResponse>(response);
        }

        public SyncInvoker<CreateAttentionResponse> CreateAttentionInvoker(CreateAttentionRequest createAttentionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/attention", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAttentionRequest);
            return new SyncInvoker<CreateAttentionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAttentionResponse>);
        }
        
        /// <summary>
        /// 创建docker仓库
        ///
        /// 创建docker仓库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDockerRepositoriesResponse CreateDockerRepositories(CreateDockerRepositoriesRequest createDockerRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDockerRepositoriesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDockerRepositoriesResponse>(response);
        }

        public SyncInvoker<CreateDockerRepositoriesResponse> CreateDockerRepositoriesInvoker(CreateDockerRepositoriesRequest createDockerRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDockerRepositoriesRequest);
            return new SyncInvoker<CreateDockerRepositoriesResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDockerRepositoriesResponse>);
        }
        
        /// <summary>
        /// 创建maven仓库
        ///
        /// 创建maven仓库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateMavenRepoResponse CreateMavenRepo(CreateMavenRepoRequest createMavenRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/maven/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMavenRepoRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateMavenRepoResponse>(response);
        }

        public SyncInvoker<CreateMavenRepoResponse> CreateMavenRepoInvoker(CreateMavenRepoRequest createMavenRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/maven/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMavenRepoRequest);
            return new SyncInvoker<CreateMavenRepoResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMavenRepoResponse>);
        }
        
        /// <summary>
        /// 创建项目关联仓库
        ///
        /// 创建项目管理关联仓库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateProjectRelatedRepositoryResponse CreateProjectRelatedRepository(CreateProjectRelatedRepositoryRequest createProjectRelatedRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/maven/project/repository", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProjectRelatedRepositoryRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateProjectRelatedRepositoryResponse>(response);
        }

        public SyncInvoker<CreateProjectRelatedRepositoryResponse> CreateProjectRelatedRepositoryInvoker(CreateProjectRelatedRepositoryRequest createProjectRelatedRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/maven/project/repository", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProjectRelatedRepositoryRequest);
            return new SyncInvoker<CreateProjectRelatedRepositoryResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateProjectRelatedRepositoryResponse>);
        }
        
        /// <summary>
        /// 非maven删除文件
        ///
        /// 非maven删除文件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteArtifactFileResponse DeleteArtifactFile(DeleteArtifactFileRequest deleteArtifactFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteArtifactFileRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteArtifactFileResponse>(response);
        }

        public SyncInvoker<DeleteArtifactFileResponse> DeleteArtifactFileInvoker(DeleteArtifactFileRequest deleteArtifactFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteArtifactFileRequest);
            return new SyncInvoker<DeleteArtifactFileResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteArtifactFileResponse>);
        }
        
        /// <summary>
        /// 删除仓库到回收站
        ///
        /// 删除仓库到回收站
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteRepositoryResponse DeleteRepository(DeleteRepositoryRequest deleteRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepositoryRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteRepositoryResponse>(response);
        }

        public SyncInvoker<DeleteRepositoryResponse> DeleteRepositoryInvoker(DeleteRepositoryRequest deleteRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepositoryRequest);
            return new SyncInvoker<DeleteRepositoryResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteRepositoryResponse>);
        }
        
        /// <summary>
        /// 查询仓库详情，不会去统计仓库下的制品数量
        ///
        /// 查询仓库详情，不会去统计仓库下的制品数量
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAllRepositoriesResponse ListAllRepositories(ListAllRepositoriesRequest listAllRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAllRepositoriesRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(listAllRepositoriesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/{tenant_id}/{project_id}/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllRepositoriesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAllRepositoriesResponse>(response);
        }

        public SyncInvoker<ListAllRepositoriesResponse> ListAllRepositoriesInvoker(ListAllRepositoriesRequest listAllRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAllRepositoriesRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(listAllRepositoriesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/{tenant_id}/{project_id}/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllRepositoriesRequest);
            return new SyncInvoker<ListAllRepositoriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAllRepositoriesResponse>);
        }
        
        /// <summary>
        /// 查询仓库文件详情
        ///
        /// 查询仓库文件详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListArtifactoryComponentResponse ListArtifactoryComponent(ListArtifactoryComponentRequest listArtifactoryComponentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listArtifactoryComponentRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(listArtifactoryComponentRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listArtifactoryComponentRequest.RepoName, out var valueOfRepoName)) urlParam.Add("repo_name", valueOfRepoName);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/{tenant_id}/{project_id}/{repo_name}/file-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listArtifactoryComponentRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListArtifactoryComponentResponse>(response);
        }

        public SyncInvoker<ListArtifactoryComponentResponse> ListArtifactoryComponentInvoker(ListArtifactoryComponentRequest listArtifactoryComponentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listArtifactoryComponentRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(listArtifactoryComponentRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listArtifactoryComponentRequest.RepoName, out var valueOfRepoName)) urlParam.Add("repo_name", valueOfRepoName);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/{tenant_id}/{project_id}/{repo_name}/file-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listArtifactoryComponentRequest);
            return new SyncInvoker<ListArtifactoryComponentResponse>(this, "GET", request, JsonUtils.DeSerialize<ListArtifactoryComponentResponse>);
        }
        
        /// <summary>
        /// 查询存储容量趋势
        ///
        /// 查询存储容量趋势
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListArtifactoryStorageStatisticResponse ListArtifactoryStorageStatistic(ListArtifactoryStorageStatisticRequest listArtifactoryStorageStatisticRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listArtifactoryStorageStatisticRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(listArtifactoryStorageStatisticRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/{tenant_id}/{project_id}/storageinfo/statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listArtifactoryStorageStatisticRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListArtifactoryStorageStatisticResponse>(response);
        }

        public SyncInvoker<ListArtifactoryStorageStatisticResponse> ListArtifactoryStorageStatisticInvoker(ListArtifactoryStorageStatisticRequest listArtifactoryStorageStatisticRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listArtifactoryStorageStatisticRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(listArtifactoryStorageStatisticRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/{tenant_id}/{project_id}/storageinfo/statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listArtifactoryStorageStatisticRequest);
            return new SyncInvoker<ListArtifactoryStorageStatisticResponse>(this, "GET", request, JsonUtils.DeSerialize<ListArtifactoryStorageStatisticResponse>);
        }
        
        /// <summary>
        /// 查询关注列表
        ///
        /// 查询关注列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAttentionsResponse ListAttentions(ListAttentionsRequest listAttentionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/attention/artifacts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAttentionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAttentionsResponse>(response);
        }

        public SyncInvoker<ListAttentionsResponse> ListAttentionsInvoker(ListAttentionsRequest listAttentionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/attention/artifacts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAttentionsRequest);
            return new SyncInvoker<ListAttentionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAttentionsResponse>);
        }
        
        /// <summary>
        /// 编辑仓库
        ///
        /// 编辑仓库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ModifyRepositoryResponse ModifyRepository(ModifyRepositoryRequest modifyRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(modifyRepositoryRequest.TabId, out var valueOfTabId)) urlParam.Add("tab_id", valueOfTabId);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/repositories/tab/{tab_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyRepositoryRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ModifyRepositoryResponse>(response);
        }

        public SyncInvoker<ModifyRepositoryResponse> ModifyRepositoryInvoker(ModifyRepositoryRequest modifyRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(modifyRepositoryRequest.TabId, out var valueOfTabId)) urlParam.Add("tab_id", valueOfTabId);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/repositories/tab/{tab_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyRepositoryRequest);
            return new SyncInvoker<ModifyRepositoryResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyRepositoryResponse>);
        }
        
        /// <summary>
        /// 重置用户密码
        ///
        /// 重置用户密码
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetUserPasswordResponse ResetUserPassword(ResetUserPasswordRequest resetUserPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/maven/users/me", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetUserPasswordRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ResetUserPasswordResponse>(response);
        }

        public SyncInvoker<ResetUserPasswordResponse> ResetUserPasswordInvoker(ResetUserPasswordRequest resetUserPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/maven/users/me", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetUserPasswordRequest);
            return new SyncInvoker<ResetUserPasswordResponse>(this, "POST", request, JsonUtils.DeSerialize<ResetUserPasswordResponse>);
        }
        
        /// <summary>
        /// 统筹搜索
        ///
        /// 统筹搜索
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchArtifactsResponse SearchArtifacts(SearchArtifactsRequest searchArtifactsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/tree/repos/artifacts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchArtifactsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SearchArtifactsResponse>(response);
        }

        public SyncInvoker<SearchArtifactsResponse> SearchArtifactsInvoker(SearchArtifactsRequest searchArtifactsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/tree/repos/artifacts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchArtifactsRequest);
            return new SyncInvoker<SearchArtifactsResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchArtifactsResponse>);
        }
        
        /// <summary>
        /// 通过checksum搜索文件
        ///
        /// 通过checksum搜索文件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchByChecksumResponse SearchByChecksum(SearchByChecksumRequest searchByChecksumRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/search/checksum", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchByChecksumRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SearchByChecksumResponse>(response);
        }

        public SyncInvoker<SearchByChecksumResponse> SearchByChecksumInvoker(SearchByChecksumRequest searchByChecksumRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/search/checksum", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchByChecksumRequest);
            return new SyncInvoker<SearchByChecksumResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchByChecksumResponse>);
        }
        
        /// <summary>
        /// 查询仓库或文件的审计日志信息
        ///
        /// 查询仓库或文件的审计日志信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAuditResponse ShowAudit(ShowAuditRequest showAuditRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAuditRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(showAuditRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showAuditRequest.Module, out var valueOfModule)) urlParam.Add("module", valueOfModule);
            if (StringUtils.TryConvertToNonEmptyString(showAuditRequest.Repo, out var valueOfRepo)) urlParam.Add("repo", valueOfRepo);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/{tenant_id}/{project_id}/{module}/{repo}/audit", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAuditResponse>(response);
        }

        public SyncInvoker<ShowAuditResponse> ShowAuditInvoker(ShowAuditRequest showAuditRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAuditRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(showAuditRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showAuditRequest.Module, out var valueOfModule)) urlParam.Add("module", valueOfModule);
            if (StringUtils.TryConvertToNonEmptyString(showAuditRequest.Repo, out var valueOfRepo)) urlParam.Add("repo", valueOfRepo);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/{tenant_id}/{project_id}/{module}/{repo}/audit", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditRequest);
            return new SyncInvoker<ShowAuditResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuditResponse>);
        }
        
        /// <summary>
        /// 查询仓库文件夹目录
        ///
        /// 查询仓库文件夹目录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowFileTreeResponse ShowFileTree(ShowFileTreeRequest showFileTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFileTreeRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(showFileTreeRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showFileTreeRequest.RepoName, out var valueOfRepoName)) urlParam.Add("repo_name", valueOfRepoName);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/{tenant_id}/{project_id}/{repo_name}/file-tree", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFileTreeRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowFileTreeResponse>(response);
        }

        public SyncInvoker<ShowFileTreeResponse> ShowFileTreeInvoker(ShowFileTreeRequest showFileTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFileTreeRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(showFileTreeRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showFileTreeRequest.RepoName, out var valueOfRepoName)) urlParam.Add("repo_name", valueOfRepoName);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/{tenant_id}/{project_id}/{repo_name}/file-tree", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFileTreeRequest);
            return new SyncInvoker<ShowFileTreeResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFileTreeResponse>);
        }
        
        /// <summary>
        /// 查询租户Maven仓库列表和账号密码
        ///
        /// 查询租户Maven仓库列表和账号密码，支持跨租户
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMavenInfoResponse ShowMavenInfo(ShowMavenInfoRequest showMavenInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/maven/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMavenInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMavenInfoResponse>(response);
        }

        public SyncInvoker<ShowMavenInfoResponse> ShowMavenInfoInvoker(ShowMavenInfoRequest showMavenInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/maven/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMavenInfoRequest);
            return new SyncInvoker<ShowMavenInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMavenInfoResponse>);
        }
        
        /// <summary>
        /// 查询项目管理关联仓库
        ///
        /// 查询项目管理关联仓库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowProjectListResponse ShowProjectList(ShowProjectListRequest showProjectListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/maven/repository/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectListRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectListResponse>(response);
        }

        public SyncInvoker<ShowProjectListResponse> ShowProjectListInvoker(ShowProjectListRequest showProjectListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/maven/repository/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectListRequest);
            return new SyncInvoker<ShowProjectListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectListResponse>);
        }
        
        /// <summary>
        /// 获取项目下文件版本信息列表
        ///
        /// 获取项目下文件版本信息列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowProjectReleaseFilesResponse ShowProjectReleaseFiles(ShowProjectReleaseFilesRequest showProjectReleaseFilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectReleaseFilesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/release/files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectReleaseFilesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectReleaseFilesResponse>(response);
        }

        public SyncInvoker<ShowProjectReleaseFilesResponse> ShowProjectReleaseFilesInvoker(ShowProjectReleaseFilesRequest showProjectReleaseFilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectReleaseFilesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/release/files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectReleaseFilesRequest);
            return new SyncInvoker<ShowProjectReleaseFilesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectReleaseFilesResponse>);
        }
        
        /// <summary>
        /// 获取项目下文件版本信息列表
        ///
        /// 获取项目下文件版本信息列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public ShowReleaseProjectFilesResponse ShowReleaseProjectFiles(ShowReleaseProjectFilesRequest showReleaseProjectFilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showReleaseProjectFilesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v2/release/{project_id}/files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReleaseProjectFilesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowReleaseProjectFilesResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<ShowReleaseProjectFilesResponse> ShowReleaseProjectFilesInvoker(ShowReleaseProjectFilesRequest showReleaseProjectFilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showReleaseProjectFilesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v2/release/{project_id}/files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReleaseProjectFilesRequest);
            return new SyncInvoker<ShowReleaseProjectFilesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowReleaseProjectFilesResponse>);
        }
        
        /// <summary>
        /// 查询单个仓库详细信息，会去统计仓库下的制品数量
        ///
        /// 查询单个仓库详细信息，会去统计仓库下的制品数量
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRepositoryResponse ShowRepository(ShowRepositoryRequest showRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryRequest.RepoId, out var valueOfRepoId)) urlParam.Add("repo_id", valueOfRepoId);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/{tenant_id}/{project_id}/{repo_id}/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRepositoryResponse>(response);
        }

        public SyncInvoker<ShowRepositoryResponse> ShowRepositoryInvoker(ShowRepositoryRequest showRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryRequest.RepoId, out var valueOfRepoId)) urlParam.Add("repo_id", valueOfRepoId);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/{tenant_id}/{project_id}/{repo_id}/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryRequest);
            return new SyncInvoker<ShowRepositoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepositoryResponse>);
        }
        
        /// <summary>
        /// 查看仓库信息
        ///
        /// 查看仓库信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRepositoryInfoResponse ShowRepositoryInfo(ShowRepositoryInfoRequest showRepositoryInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryInfoRequest.RepoId, out var valueOfRepoId)) urlParam.Add("repo_id", valueOfRepoId);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/repositories/{repo_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRepositoryInfoResponse>(response);
        }

        public SyncInvoker<ShowRepositoryInfoResponse> ShowRepositoryInfoInvoker(ShowRepositoryInfoRequest showRepositoryInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryInfoRequest.RepoId, out var valueOfRepoId)) urlParam.Add("repo_id", valueOfRepoId);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/repositories/{repo_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryInfoRequest);
            return new SyncInvoker<ShowRepositoryInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepositoryInfoResponse>);
        }
        
        /// <summary>
        /// 仓库用量查询
        ///
        /// 仓库用量查询
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowStorageResponse ShowStorage(ShowStorageRequest showStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/storage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStorageRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowStorageResponse>(response);
        }

        public SyncInvoker<ShowStorageResponse> ShowStorageInvoker(ShowStorageRequest showStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/storage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStorageRequest);
            return new SyncInvoker<ShowStorageResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStorageResponse>);
        }
        
        /// <summary>
        /// 查询用户在项目下的权限
        ///
        /// 查询用户在项目下的权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowUserPrivilegesResponse ShowUserPrivileges(ShowUserPrivilegesRequest showUserPrivilegesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUserPrivilegesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v3/user/{project_id}/privileges", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserPrivilegesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowUserPrivilegesResponse>(response);
        }

        public SyncInvoker<ShowUserPrivilegesResponse> ShowUserPrivilegesInvoker(ShowUserPrivilegesRequest showUserPrivilegesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUserPrivilegesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v3/user/{project_id}/privileges", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserPrivilegesRequest);
            return new SyncInvoker<ShowUserPrivilegesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUserPrivilegesResponse>);
        }
        
        /// <summary>
        /// 编辑非maven仓库信息
        ///
        /// 编辑非maven仓库信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateArtifactoryResponse UpdateArtifactory(UpdateArtifactoryRequest updateArtifactoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/artifact/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateArtifactoryRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateArtifactoryResponse>(response);
        }

        public SyncInvoker<UpdateArtifactoryResponse> UpdateArtifactoryInvoker(UpdateArtifactoryRequest updateArtifactoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/artifact/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateArtifactoryRequest);
            return new SyncInvoker<UpdateArtifactoryResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateArtifactoryResponse>);
        }
        
    }
}