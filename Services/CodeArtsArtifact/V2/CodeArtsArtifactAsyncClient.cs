using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.CodeArtsArtifact.V2.Model;

namespace HuaweiCloud.SDK.CodeArtsArtifact.V2
{
    public partial class CodeArtsArtifactAsyncClient : Client
    {
        public static ClientBuilder<CodeArtsArtifactAsyncClient> NewBuilder()
        {
            return new ClientBuilder<CodeArtsArtifactAsyncClient>();
        }

        
        /// <summary>
        /// 批量删除回收站
        ///
        /// 批量删除回收站
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteTrashesResponse> BatchDeleteTrashesAsync(BatchDeleteTrashesRequest batchDeleteTrashesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/trashes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteTrashesRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeleteTrashesResponse>(response);
        }

        public AsyncInvoker<BatchDeleteTrashesResponse> BatchDeleteTrashesAsyncInvoker(BatchDeleteTrashesRequest batchDeleteTrashesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/trashes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteTrashesRequest);
            return new AsyncInvoker<BatchDeleteTrashesResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteTrashesResponse>);
        }
        
        /// <summary>
        /// 批量还原回收站
        ///
        /// 批量还原回收站
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchRestoreRepoResponse> BatchRestoreRepoAsync(BatchRestoreRepoRequest batchRestoreRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/trashes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRestoreRepoRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<BatchRestoreRepoResponse>(response);
        }

        public AsyncInvoker<BatchRestoreRepoResponse> BatchRestoreRepoAsyncInvoker(BatchRestoreRepoRequest batchRestoreRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/trashes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRestoreRepoRequest);
            return new AsyncInvoker<BatchRestoreRepoResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchRestoreRepoResponse>);
        }
        
        /// <summary>
        /// 创建非maven仓库
        ///
        /// 创建非maven仓库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateArtifactoryResponse> CreateArtifactoryAsync(CreateArtifactoryRequest createArtifactoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/artifact/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createArtifactoryRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateArtifactoryResponse>(response);
        }

        public AsyncInvoker<CreateArtifactoryResponse> CreateArtifactoryAsyncInvoker(CreateArtifactoryRequest createArtifactoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/artifact/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createArtifactoryRequest);
            return new AsyncInvoker<CreateArtifactoryResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateArtifactoryResponse>);
        }
        
        /// <summary>
        /// 关注组件/取消关注组件
        ///
        /// 关注组件/取消关注组件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAttentionResponse> CreateAttentionAsync(CreateAttentionRequest createAttentionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/attention", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAttentionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAttentionResponse>(response);
        }

        public AsyncInvoker<CreateAttentionResponse> CreateAttentionAsyncInvoker(CreateAttentionRequest createAttentionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/attention", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAttentionRequest);
            return new AsyncInvoker<CreateAttentionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAttentionResponse>);
        }
        
        /// <summary>
        /// 创建docker仓库
        ///
        /// 创建docker仓库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDockerRepositoriesResponse> CreateDockerRepositoriesAsync(CreateDockerRepositoriesRequest createDockerRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDockerRepositoriesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDockerRepositoriesResponse>(response);
        }

        public AsyncInvoker<CreateDockerRepositoriesResponse> CreateDockerRepositoriesAsyncInvoker(CreateDockerRepositoriesRequest createDockerRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDockerRepositoriesRequest);
            return new AsyncInvoker<CreateDockerRepositoriesResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDockerRepositoriesResponse>);
        }
        
        /// <summary>
        /// 创建maven仓库
        ///
        /// 创建maven仓库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateMavenRepoResponse> CreateMavenRepoAsync(CreateMavenRepoRequest createMavenRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/maven/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMavenRepoRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateMavenRepoResponse>(response);
        }

        public AsyncInvoker<CreateMavenRepoResponse> CreateMavenRepoAsyncInvoker(CreateMavenRepoRequest createMavenRepoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/maven/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMavenRepoRequest);
            return new AsyncInvoker<CreateMavenRepoResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMavenRepoResponse>);
        }
        
        /// <summary>
        /// 创建项目关联仓库
        ///
        /// 创建项目管理关联仓库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateProjectRelatedRepositoryResponse> CreateProjectRelatedRepositoryAsync(CreateProjectRelatedRepositoryRequest createProjectRelatedRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/maven/project/repository", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProjectRelatedRepositoryRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateProjectRelatedRepositoryResponse>(response);
        }

        public AsyncInvoker<CreateProjectRelatedRepositoryResponse> CreateProjectRelatedRepositoryAsyncInvoker(CreateProjectRelatedRepositoryRequest createProjectRelatedRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/maven/project/repository", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProjectRelatedRepositoryRequest);
            return new AsyncInvoker<CreateProjectRelatedRepositoryResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateProjectRelatedRepositoryResponse>);
        }
        
        /// <summary>
        /// 非maven删除文件
        ///
        /// 非maven删除文件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteArtifactFileResponse> DeleteArtifactFileAsync(DeleteArtifactFileRequest deleteArtifactFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteArtifactFileRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteArtifactFileResponse>(response);
        }

        public AsyncInvoker<DeleteArtifactFileResponse> DeleteArtifactFileAsyncInvoker(DeleteArtifactFileRequest deleteArtifactFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteArtifactFileRequest);
            return new AsyncInvoker<DeleteArtifactFileResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteArtifactFileResponse>);
        }
        
        /// <summary>
        /// 删除仓库到回收站
        ///
        /// 删除仓库到回收站
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRepositoryResponse> DeleteRepositoryAsync(DeleteRepositoryRequest deleteRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepositoryRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteRepositoryResponse>(response);
        }

        public AsyncInvoker<DeleteRepositoryResponse> DeleteRepositoryAsyncInvoker(DeleteRepositoryRequest deleteRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepositoryRequest);
            return new AsyncInvoker<DeleteRepositoryResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteRepositoryResponse>);
        }
        
        /// <summary>
        /// 查询仓库详情，不会去统计仓库下的制品数量
        ///
        /// 查询仓库详情，不会去统计仓库下的制品数量
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAllRepositoriesResponse> ListAllRepositoriesAsync(ListAllRepositoriesRequest listAllRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAllRepositoriesRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(listAllRepositoriesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/{tenant_id}/{project_id}/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllRepositoriesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAllRepositoriesResponse>(response);
        }

        public AsyncInvoker<ListAllRepositoriesResponse> ListAllRepositoriesAsyncInvoker(ListAllRepositoriesRequest listAllRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAllRepositoriesRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(listAllRepositoriesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/{tenant_id}/{project_id}/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllRepositoriesRequest);
            return new AsyncInvoker<ListAllRepositoriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAllRepositoriesResponse>);
        }
        
        /// <summary>
        /// 查询仓库文件详情
        ///
        /// 查询仓库文件详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListArtifactoryComponentResponse> ListArtifactoryComponentAsync(ListArtifactoryComponentRequest listArtifactoryComponentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listArtifactoryComponentRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(listArtifactoryComponentRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listArtifactoryComponentRequest.RepoName, out var valueOfRepoName)) urlParam.Add("repo_name", valueOfRepoName);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/{tenant_id}/{project_id}/{repo_name}/file-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listArtifactoryComponentRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListArtifactoryComponentResponse>(response);
        }

        public AsyncInvoker<ListArtifactoryComponentResponse> ListArtifactoryComponentAsyncInvoker(ListArtifactoryComponentRequest listArtifactoryComponentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listArtifactoryComponentRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(listArtifactoryComponentRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listArtifactoryComponentRequest.RepoName, out var valueOfRepoName)) urlParam.Add("repo_name", valueOfRepoName);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/{tenant_id}/{project_id}/{repo_name}/file-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listArtifactoryComponentRequest);
            return new AsyncInvoker<ListArtifactoryComponentResponse>(this, "GET", request, JsonUtils.DeSerialize<ListArtifactoryComponentResponse>);
        }
        
        /// <summary>
        /// 查询存储容量趋势
        ///
        /// 查询存储容量趋势
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListArtifactoryStorageStatisticResponse> ListArtifactoryStorageStatisticAsync(ListArtifactoryStorageStatisticRequest listArtifactoryStorageStatisticRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listArtifactoryStorageStatisticRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(listArtifactoryStorageStatisticRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/{tenant_id}/{project_id}/storageinfo/statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listArtifactoryStorageStatisticRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListArtifactoryStorageStatisticResponse>(response);
        }

        public AsyncInvoker<ListArtifactoryStorageStatisticResponse> ListArtifactoryStorageStatisticAsyncInvoker(ListArtifactoryStorageStatisticRequest listArtifactoryStorageStatisticRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listArtifactoryStorageStatisticRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(listArtifactoryStorageStatisticRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/{tenant_id}/{project_id}/storageinfo/statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listArtifactoryStorageStatisticRequest);
            return new AsyncInvoker<ListArtifactoryStorageStatisticResponse>(this, "GET", request, JsonUtils.DeSerialize<ListArtifactoryStorageStatisticResponse>);
        }
        
        /// <summary>
        /// 查询关注列表
        ///
        /// 查询关注列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAttentionsResponse> ListAttentionsAsync(ListAttentionsRequest listAttentionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/attention/artifacts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAttentionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAttentionsResponse>(response);
        }

        public AsyncInvoker<ListAttentionsResponse> ListAttentionsAsyncInvoker(ListAttentionsRequest listAttentionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/attention/artifacts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAttentionsRequest);
            return new AsyncInvoker<ListAttentionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAttentionsResponse>);
        }
        
        /// <summary>
        /// 编辑仓库
        ///
        /// 编辑仓库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ModifyRepositoryResponse> ModifyRepositoryAsync(ModifyRepositoryRequest modifyRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(modifyRepositoryRequest.TabId, out var valueOfTabId)) urlParam.Add("tab_id", valueOfTabId);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/repositories/tab/{tab_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyRepositoryRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ModifyRepositoryResponse>(response);
        }

        public AsyncInvoker<ModifyRepositoryResponse> ModifyRepositoryAsyncInvoker(ModifyRepositoryRequest modifyRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(modifyRepositoryRequest.TabId, out var valueOfTabId)) urlParam.Add("tab_id", valueOfTabId);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/repositories/tab/{tab_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyRepositoryRequest);
            return new AsyncInvoker<ModifyRepositoryResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyRepositoryResponse>);
        }
        
        /// <summary>
        /// 重置用户密码
        ///
        /// 重置用户密码
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResetUserPasswordResponse> ResetUserPasswordAsync(ResetUserPasswordRequest resetUserPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/maven/users/me", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetUserPasswordRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ResetUserPasswordResponse>(response);
        }

        public AsyncInvoker<ResetUserPasswordResponse> ResetUserPasswordAsyncInvoker(ResetUserPasswordRequest resetUserPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/maven/users/me", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetUserPasswordRequest);
            return new AsyncInvoker<ResetUserPasswordResponse>(this, "POST", request, JsonUtils.DeSerialize<ResetUserPasswordResponse>);
        }
        
        /// <summary>
        /// 统筹搜索
        ///
        /// 统筹搜索
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchArtifactsResponse> SearchArtifactsAsync(SearchArtifactsRequest searchArtifactsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/tree/repos/artifacts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchArtifactsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SearchArtifactsResponse>(response);
        }

        public AsyncInvoker<SearchArtifactsResponse> SearchArtifactsAsyncInvoker(SearchArtifactsRequest searchArtifactsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/tree/repos/artifacts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchArtifactsRequest);
            return new AsyncInvoker<SearchArtifactsResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchArtifactsResponse>);
        }
        
        /// <summary>
        /// 通过checksum搜索文件
        ///
        /// 通过checksum搜索文件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SearchByChecksumResponse> SearchByChecksumAsync(SearchByChecksumRequest searchByChecksumRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/search/checksum", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchByChecksumRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<SearchByChecksumResponse>(response);
        }

        public AsyncInvoker<SearchByChecksumResponse> SearchByChecksumAsyncInvoker(SearchByChecksumRequest searchByChecksumRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/search/checksum", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchByChecksumRequest);
            return new AsyncInvoker<SearchByChecksumResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchByChecksumResponse>);
        }
        
        /// <summary>
        /// 查询仓库或文件的审计日志信息
        ///
        /// 查询仓库或文件的审计日志信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAuditResponse> ShowAuditAsync(ShowAuditRequest showAuditRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAuditRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(showAuditRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showAuditRequest.Module, out var valueOfModule)) urlParam.Add("module", valueOfModule);
            if (StringUtils.TryConvertToNonEmptyString(showAuditRequest.Repo, out var valueOfRepo)) urlParam.Add("repo", valueOfRepo);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/{tenant_id}/{project_id}/{module}/{repo}/audit", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAuditResponse>(response);
        }

        public AsyncInvoker<ShowAuditResponse> ShowAuditAsyncInvoker(ShowAuditRequest showAuditRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAuditRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(showAuditRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showAuditRequest.Module, out var valueOfModule)) urlParam.Add("module", valueOfModule);
            if (StringUtils.TryConvertToNonEmptyString(showAuditRequest.Repo, out var valueOfRepo)) urlParam.Add("repo", valueOfRepo);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/{tenant_id}/{project_id}/{module}/{repo}/audit", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAuditRequest);
            return new AsyncInvoker<ShowAuditResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAuditResponse>);
        }
        
        /// <summary>
        /// 查询仓库文件夹目录
        ///
        /// 查询仓库文件夹目录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowFileTreeResponse> ShowFileTreeAsync(ShowFileTreeRequest showFileTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFileTreeRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(showFileTreeRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showFileTreeRequest.RepoName, out var valueOfRepoName)) urlParam.Add("repo_name", valueOfRepoName);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/{tenant_id}/{project_id}/{repo_name}/file-tree", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFileTreeRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowFileTreeResponse>(response);
        }

        public AsyncInvoker<ShowFileTreeResponse> ShowFileTreeAsyncInvoker(ShowFileTreeRequest showFileTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFileTreeRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(showFileTreeRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showFileTreeRequest.RepoName, out var valueOfRepoName)) urlParam.Add("repo_name", valueOfRepoName);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/{tenant_id}/{project_id}/{repo_name}/file-tree", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFileTreeRequest);
            return new AsyncInvoker<ShowFileTreeResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFileTreeResponse>);
        }
        
        /// <summary>
        /// 查询租户Maven仓库列表和账号密码
        ///
        /// 查询租户Maven仓库列表和账号密码，支持跨租户
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMavenInfoResponse> ShowMavenInfoAsync(ShowMavenInfoRequest showMavenInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/maven/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMavenInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowMavenInfoResponse>(response);
        }

        public AsyncInvoker<ShowMavenInfoResponse> ShowMavenInfoAsyncInvoker(ShowMavenInfoRequest showMavenInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/maven/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMavenInfoRequest);
            return new AsyncInvoker<ShowMavenInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMavenInfoResponse>);
        }
        
        /// <summary>
        /// 查询项目管理关联仓库
        ///
        /// 查询项目管理关联仓库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowProjectListResponse> ShowProjectListAsync(ShowProjectListRequest showProjectListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/maven/repository/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectListRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectListResponse>(response);
        }

        public AsyncInvoker<ShowProjectListResponse> ShowProjectListAsyncInvoker(ShowProjectListRequest showProjectListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/maven/repository/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectListRequest);
            return new AsyncInvoker<ShowProjectListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectListResponse>);
        }
        
        /// <summary>
        /// 获取项目下文件版本信息列表
        ///
        /// 获取项目下文件版本信息列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowProjectReleaseFilesResponse> ShowProjectReleaseFilesAsync(ShowProjectReleaseFilesRequest showProjectReleaseFilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectReleaseFilesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/release/files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectReleaseFilesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectReleaseFilesResponse>(response);
        }

        public AsyncInvoker<ShowProjectReleaseFilesResponse> ShowProjectReleaseFilesAsyncInvoker(ShowProjectReleaseFilesRequest showProjectReleaseFilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectReleaseFilesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/release/files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectReleaseFilesRequest);
            return new AsyncInvoker<ShowProjectReleaseFilesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectReleaseFilesResponse>);
        }
        
        /// <summary>
        /// 获取项目下文件版本信息列表
        ///
        /// 获取项目下文件版本信息列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<ShowReleaseProjectFilesResponse> ShowReleaseProjectFilesAsync(ShowReleaseProjectFilesRequest showReleaseProjectFilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showReleaseProjectFilesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v2/release/{project_id}/files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReleaseProjectFilesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowReleaseProjectFilesResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<ShowReleaseProjectFilesResponse> ShowReleaseProjectFilesAsyncInvoker(ShowReleaseProjectFilesRequest showReleaseProjectFilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showReleaseProjectFilesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v2/release/{project_id}/files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReleaseProjectFilesRequest);
            return new AsyncInvoker<ShowReleaseProjectFilesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowReleaseProjectFilesResponse>);
        }
        
        /// <summary>
        /// 查询单个仓库详细信息，会去统计仓库下的制品数量
        ///
        /// 查询单个仓库详细信息，会去统计仓库下的制品数量
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRepositoryResponse> ShowRepositoryAsync(ShowRepositoryRequest showRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryRequest.RepoId, out var valueOfRepoId)) urlParam.Add("repo_id", valueOfRepoId);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/{tenant_id}/{project_id}/{repo_id}/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRepositoryResponse>(response);
        }

        public AsyncInvoker<ShowRepositoryResponse> ShowRepositoryAsyncInvoker(ShowRepositoryRequest showRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryRequest.RepoId, out var valueOfRepoId)) urlParam.Add("repo_id", valueOfRepoId);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/{tenant_id}/{project_id}/{repo_id}/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryRequest);
            return new AsyncInvoker<ShowRepositoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepositoryResponse>);
        }
        
        /// <summary>
        /// 查看仓库信息
        ///
        /// 查看仓库信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRepositoryInfoResponse> ShowRepositoryInfoAsync(ShowRepositoryInfoRequest showRepositoryInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryInfoRequest.RepoId, out var valueOfRepoId)) urlParam.Add("repo_id", valueOfRepoId);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/repositories/{repo_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRepositoryInfoResponse>(response);
        }

        public AsyncInvoker<ShowRepositoryInfoResponse> ShowRepositoryInfoAsyncInvoker(ShowRepositoryInfoRequest showRepositoryInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryInfoRequest.RepoId, out var valueOfRepoId)) urlParam.Add("repo_id", valueOfRepoId);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/repositories/{repo_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryInfoRequest);
            return new AsyncInvoker<ShowRepositoryInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepositoryInfoResponse>);
        }
        
        /// <summary>
        /// 仓库用量查询
        ///
        /// 仓库用量查询
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowStorageResponse> ShowStorageAsync(ShowStorageRequest showStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/storage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStorageRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowStorageResponse>(response);
        }

        public AsyncInvoker<ShowStorageResponse> ShowStorageAsyncInvoker(ShowStorageRequest showStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/storage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStorageRequest);
            return new AsyncInvoker<ShowStorageResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStorageResponse>);
        }
        
        /// <summary>
        /// 查询用户在项目下的权限
        ///
        /// 查询用户在项目下的权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowUserPrivilegesResponse> ShowUserPrivilegesAsync(ShowUserPrivilegesRequest showUserPrivilegesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUserPrivilegesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v3/user/{project_id}/privileges", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserPrivilegesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowUserPrivilegesResponse>(response);
        }

        public AsyncInvoker<ShowUserPrivilegesResponse> ShowUserPrivilegesAsyncInvoker(ShowUserPrivilegesRequest showUserPrivilegesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUserPrivilegesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v3/user/{project_id}/privileges", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserPrivilegesRequest);
            return new AsyncInvoker<ShowUserPrivilegesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUserPrivilegesResponse>);
        }
        
        /// <summary>
        /// 编辑非maven仓库信息
        ///
        /// 编辑非maven仓库信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateArtifactoryResponse> UpdateArtifactoryAsync(UpdateArtifactoryRequest updateArtifactoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/artifact/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateArtifactoryRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateArtifactoryResponse>(response);
        }

        public AsyncInvoker<UpdateArtifactoryResponse> UpdateArtifactoryAsyncInvoker(UpdateArtifactoryRequest updateArtifactoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/artifact/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateArtifactoryRequest);
            return new AsyncInvoker<UpdateArtifactoryResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateArtifactoryResponse>);
        }
        
    }
}