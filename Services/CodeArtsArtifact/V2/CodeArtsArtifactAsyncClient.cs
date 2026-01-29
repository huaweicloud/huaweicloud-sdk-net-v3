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
        /// 彻底删除文件/文件夹
        ///
        /// 根据文件ID彻底删除文件或文件夹，删除后不能恢复，支持批量删除。可使用该接口清理不再需要的文件或文件夹以释放存储空间。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteCompletelyUpdateFileStateResponse> DeleteCompletelyUpdateFileStateAsync(DeleteCompletelyUpdateFileStateRequest deleteCompletelyUpdateFileStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/files/compeletion", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCompletelyUpdateFileStateRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteCompletelyUpdateFileStateResponse>(response);
        }

        public AsyncInvoker<DeleteCompletelyUpdateFileStateResponse> DeleteCompletelyUpdateFileStateAsyncInvoker(DeleteCompletelyUpdateFileStateRequest deleteCompletelyUpdateFileStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/files/compeletion", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCompletelyUpdateFileStateRequest);
            return new AsyncInvoker<DeleteCompletelyUpdateFileStateResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteCompletelyUpdateFileStateResponse>);
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
        /// 查询租户容量消息通知设置信息
        ///
        /// 查询租户容量消息通知设置，包含容量阈值和是否启用邮件通知等信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCapacityMessageSettingResponse> ListCapacityMessageSettingAsync(ListCapacityMessageSettingRequest listCapacityMessageSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/capacity-notice/settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCapacityMessageSettingRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCapacityMessageSettingResponse>(response);
        }

        public AsyncInvoker<ListCapacityMessageSettingResponse> ListCapacityMessageSettingAsyncInvoker(ListCapacityMessageSettingRequest listCapacityMessageSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/capacity-notice/settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCapacityMessageSettingRequest);
            return new AsyncInvoker<ListCapacityMessageSettingResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCapacityMessageSettingResponse>);
        }
        
        /// <summary>
        /// 获取聚合仓下的仓库代理列表
        ///
        /// 根据仓库ID获取指定聚合仓的仓库代理列表，包含仓库状态、类型、地址和访问路径白名单等信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListChildProxyRepositoriesListResponse> ListChildProxyRepositoriesListAsync(ListChildProxyRepositoriesListRequest listChildProxyRepositoriesListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/repositories/proxy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listChildProxyRepositoriesListRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListChildProxyRepositoriesListResponse>(response);
        }

        public AsyncInvoker<ListChildProxyRepositoriesListResponse> ListChildProxyRepositoriesListAsyncInvoker(ListChildProxyRepositoriesListRequest listChildProxyRepositoriesListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/repositories/proxy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listChildProxyRepositoriesListRequest);
            return new AsyncInvoker<ListChildProxyRepositoriesListResponse>(this, "GET", request, JsonUtils.DeSerialize<ListChildProxyRepositoriesListResponse>);
        }
        
        /// <summary>
        /// 查询租户级IP白名单
        ///
        /// 查询租户级IP白名单列表。在IP白名单的IP才能访问制品仓库，未配置IP白名单时，默认所有IP都可访问。该功能可用于保障制品仓库的安全，对访问IP进行严格控制。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDomainIpConfigResponse> ListDomainIpConfigAsync(ListDomainIpConfigRequest listDomainIpConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/domain/ipconfig", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainIpConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDomainIpConfigResponse>(response);
        }

        public AsyncInvoker<ListDomainIpConfigResponse> ListDomainIpConfigAsyncInvoker(ListDomainIpConfigRequest listDomainIpConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/domain/ipconfig", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainIpConfigRequest);
            return new AsyncInvoker<ListDomainIpConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainIpConfigResponse>);
        }
        
        /// <summary>
        /// 分页查询构建归档包列表
        ///
        /// 当归档包数量庞大时，分页查询构建归档包列表，包含文件名、文件大小、下载地址、MD5校验和、构建地址、构建代码分支等信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFileBuildArchivesResponse> ListFileBuildArchivesAsync(ListFileBuildArchivesRequest listFileBuildArchivesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/files/archives", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFileBuildArchivesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListFileBuildArchivesResponse>(response);
        }

        public AsyncInvoker<ListFileBuildArchivesResponse> ListFileBuildArchivesAsyncInvoker(ListFileBuildArchivesRequest listFileBuildArchivesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/files/archives", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFileBuildArchivesRequest);
            return new AsyncInvoker<ListFileBuildArchivesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFileBuildArchivesResponse>);
        }
        
        /// <summary>
        /// 查询文件/项目列表
        ///
        /// 当项目或文件数量庞大时，分页查询项目或文件列表。可根据文件名、文件状态和文件的发布状态等参数进行过滤，从而快速找到所需文件，包含文件名、文件大小和下载地址等信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFilesResponse> ListFilesAsync(ListFilesRequest listFilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/files/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFilesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListFilesResponse>(response);
        }

        public AsyncInvoker<ListFilesResponse> ListFilesAsyncInvoker(ListFilesRequest listFilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/files/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFilesRequest);
            return new AsyncInvoker<ListFilesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListFilesResponse>);
        }
        
        /// <summary>
        /// 查询项目下所有文件的最新版本
        ///
        /// 当项目文件数量庞大时，通过该接口可以分页查询项目下所有文件的最新版本，包含文件名、文件大小、文件状态和发布状态等信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLatestVersionFilesResponse> ListLatestVersionFilesAsync(ListLatestVersionFilesRequest listLatestVersionFilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listLatestVersionFilesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/{project_id}/files/version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLatestVersionFilesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListLatestVersionFilesResponse>(response);
        }

        public AsyncInvoker<ListLatestVersionFilesResponse> ListLatestVersionFilesAsyncInvoker(ListLatestVersionFilesRequest listLatestVersionFilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listLatestVersionFilesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/{project_id}/files/version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLatestVersionFilesRequest);
            return new AsyncInvoker<ListLatestVersionFilesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLatestVersionFilesResponse>);
        }
        
        /// <summary>
        /// 查询Maven仓库列表
        ///
        /// 查询Maven仓库列表，包含仓库状态、类型、地址和访问路径白名单等信息。支持根据项目ID和仓库ID等参数进行过滤。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMavenListResponse> ListMavenListAsync(ListMavenListRequest listMavenListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/maven/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMavenListRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListMavenListResponse>(response);
        }

        public AsyncInvoker<ListMavenListResponse> ListMavenListAsyncInvoker(ListMavenListRequest listMavenListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/maven/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMavenListRequest);
            return new AsyncInvoker<ListMavenListResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMavenListResponse>);
        }
        
        /// <summary>
        /// 查询私有库用户列表
        ///
        /// 分页查询私有库用户列表，包含用户名和用户是否启用等信息。可根据用户名进行过滤。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMavenUserResponse> ListMavenUserAsync(ListMavenUserRequest listMavenUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/repositories/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMavenUserRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListMavenUserResponse>(response);
        }

        public AsyncInvoker<ListMavenUserResponse> ListMavenUserAsyncInvoker(ListMavenUserRequest listMavenUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/repositories/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMavenUserRequest);
            return new AsyncInvoker<ListMavenUserResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMavenUserResponse>);
        }
        
        /// <summary>
        /// 查询网络代理列表
        ///
        /// 查询网络代理列表，返回代理源的访问地址及认证信息等，用于代理外部公开的制品资源。通过网络代理，开发人员可以安全、高效地访问所需的外部资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNetProxyResponse> ListNetProxyAsync(ListNetProxyRequest listNetProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/tree/net/proxy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNetProxyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListNetProxyResponse>(response);
        }

        public AsyncInvoker<ListNetProxyResponse> ListNetProxyAsyncInvoker(ListNetProxyRequest listNetProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/tree/net/proxy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNetProxyRequest);
            return new AsyncInvoker<ListNetProxyResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNetProxyResponse>);
        }
        
        /// <summary>
        /// 查看项目的角色权限设置
        ///
        /// 查看项目的角色权限设置，包含上传下载、创建文件夹、清空或者还原回收站和更改软件包状态等设置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProjectRolePermissionsResponse> ListProjectRolePermissionsAsync(ListProjectRolePermissionsRequest listProjectRolePermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/project-role/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectRolePermissionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListProjectRolePermissionsResponse>(response);
        }

        public AsyncInvoker<ListProjectRolePermissionsResponse> ListProjectRolePermissionsAsyncInvoker(ListProjectRolePermissionsRequest listProjectRolePermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/project-role/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectRolePermissionsRequest);
            return new AsyncInvoker<ListProjectRolePermissionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProjectRolePermissionsResponse>);
        }
        
        /// <summary>
        /// 查询项目下的用户
        ///
        /// 当项目中的用户数量较多时，分页查询指定项目下的用户列表，包含用户名和角色等信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProjectUsersResponse> ListProjectUsersAsync(ListProjectUsersRequest listProjectUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectUsersRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/projects/{project_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectUsersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListProjectUsersResponse>(response);
        }

        public AsyncInvoker<ListProjectUsersResponse> ListProjectUsersAsyncInvoker(ListProjectUsersRequest listProjectUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectUsersRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/projects/{project_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectUsersRequest);
            return new AsyncInvoker<ListProjectUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProjectUsersResponse>);
        }
        
        /// <summary>
        /// 查询制品安全扫描任务列表
        ///
        /// 分页查询制品安全扫描任务列表，包含扫描制品数量、漏洞数量、病毒文件数量和恶意代码文件数量等信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSecGuardListResponse> ListSecGuardListAsync(ListSecGuardListRequest listSecGuardListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/sec-guard/task/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecGuardListRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSecGuardListResponse>(response);
        }

        public AsyncInvoker<ListSecGuardListResponse> ListSecGuardListAsyncInvoker(ListSecGuardListRequest listSecGuardListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/sec-guard/task/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecGuardListRequest);
            return new AsyncInvoker<ListSecGuardListResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSecGuardListResponse>);
        }
        
        /// <summary>
        /// 查询用户权限
        ///
        /// 查询用户在项目下的角色及权限，如创建仓库、编辑仓库、上传、下载、导入和导出等权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListUserPrivilegesResponse> ListUserPrivilegesAsync(ListUserPrivilegesRequest listUserPrivilegesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUserPrivilegesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/user/{project_id}/privileges", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserPrivilegesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListUserPrivilegesResponse>(response);
        }

        public AsyncInvoker<ListUserPrivilegesResponse> ListUserPrivilegesAsyncInvoker(ListUserPrivilegesRequest listUserPrivilegesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUserPrivilegesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/user/{project_id}/privileges", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserPrivilegesRequest);
            return new AsyncInvoker<ListUserPrivilegesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUserPrivilegesResponse>);
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
        /// 查询项目自动删除任务设置
        ///
        /// 查询项目自动删除任务设置，包含文件的过期自动删除时间及删除规则。自动删除任务可以自动执行文件清理任务，减少管理员的工作负担，确保存储资源的有效利用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAutoDeleteJobSettingsResponse> ShowAutoDeleteJobSettingsAsync(ShowAutoDeleteJobSettingsRequest showAutoDeleteJobSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutoDeleteJobSettingsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/release/{project_id}/auto-deletion/settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoDeleteJobSettingsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAutoDeleteJobSettingsResponse>(response);
        }

        public AsyncInvoker<ShowAutoDeleteJobSettingsResponse> ShowAutoDeleteJobSettingsAsyncInvoker(ShowAutoDeleteJobSettingsRequest showAutoDeleteJobSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutoDeleteJobSettingsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/release/{project_id}/auto-deletion/settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoDeleteJobSettingsRequest);
            return new AsyncInvoker<ShowAutoDeleteJobSettingsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutoDeleteJobSettingsResponse>);
        }
        
        /// <summary>
        /// 查询租户发布库存储容量
        ///
        /// 查询租户发布库存储容量，包含已使用存储容量、最大存储容量、套餐类型和仓库数量等信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainReleaseRepoStorageResponse> ShowDomainReleaseRepoStorageAsync(ShowDomainReleaseRepoStorageRequest showDomainReleaseRepoStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/storage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainReleaseRepoStorageRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainReleaseRepoStorageResponse>(response);
        }

        public AsyncInvoker<ShowDomainReleaseRepoStorageResponse> ShowDomainReleaseRepoStorageAsyncInvoker(ShowDomainReleaseRepoStorageRequest showDomainReleaseRepoStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/storage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainReleaseRepoStorageRequest);
            return new AsyncInvoker<ShowDomainReleaseRepoStorageResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainReleaseRepoStorageResponse>);
        }
        
        /// <summary>
        /// 根据文件ID查询文件详情
        ///
        /// 在日常数据管理工作中，根据文件ID查询指定文件详情，包含文件名、文件大小、下载地址、校验和、文件状态和发布状态等信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowFileDetailResponse> ShowFileDetailAsync(ShowFileDetailRequest showFileDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFileDetailRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/files/{id}/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFileDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowFileDetailResponse>(response);
        }

        public AsyncInvoker<ShowFileDetailResponse> ShowFileDetailAsyncInvoker(ShowFileDetailRequest showFileDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFileDetailRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/files/{id}/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFileDetailRequest);
            return new AsyncInvoker<ShowFileDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFileDetailResponse>);
        }
        
        /// <summary>
        /// 根据文件完整路径查询文件详情
        ///
        /// 在日常数据管理工作中，根据文件完整路径查询指定文件详情，包含文件名、文件大小、下载地址、校验和、文件状态和发布状态等信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowFileDetailByFullNameResponse> ShowFileDetailByFullNameAsync(ShowFileDetailByFullNameRequest showFileDetailByFullNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/files/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFileDetailByFullNameRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowFileDetailByFullNameResponse>(response);
        }

        public AsyncInvoker<ShowFileDetailByFullNameResponse> ShowFileDetailByFullNameAsyncInvoker(ShowFileDetailByFullNameRequest showFileDetailByFullNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/files/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFileDetailByFullNameRequest);
            return new AsyncInvoker<ShowFileDetailByFullNameResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFileDetailByFullNameResponse>);
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
        /// 查询项目下所有文件的数量
        ///
        /// 查询项目下所有文件的数量，该接口会识别所有文件的最新版本，从而提供准确的文件数量统计。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowLatestVersionFilesCountResponse> ShowLatestVersionFilesCountAsync(ShowLatestVersionFilesCountRequest showLatestVersionFilesCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLatestVersionFilesCountRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/{project_id}/files/version/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLatestVersionFilesCountRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowLatestVersionFilesCountResponse>(response);
        }

        public AsyncInvoker<ShowLatestVersionFilesCountResponse> ShowLatestVersionFilesCountAsyncInvoker(ShowLatestVersionFilesCountRequest showLatestVersionFilesCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLatestVersionFilesCountRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/{project_id}/files/version/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLatestVersionFilesCountRequest);
            return new AsyncInvoker<ShowLatestVersionFilesCountResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLatestVersionFilesCountResponse>);
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
        /// 查询多角色用户权限
        ///
        /// 查询多角色用户权限，包含上传下载、创建文件夹、清空或者还原回收站和更改软件包状态等权限信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMultiRolesUserPermissionsResponse> ShowMultiRolesUserPermissionsAsync(ShowMultiRolesUserPermissionsRequest showMultiRolesUserPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/user/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMultiRolesUserPermissionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowMultiRolesUserPermissionsResponse>(response);
        }

        public AsyncInvoker<ShowMultiRolesUserPermissionsResponse> ShowMultiRolesUserPermissionsAsyncInvoker(ShowMultiRolesUserPermissionsRequest showMultiRolesUserPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/user/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMultiRolesUserPermissionsRequest);
            return new AsyncInvoker<ShowMultiRolesUserPermissionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMultiRolesUserPermissionsResponse>);
        }
        
        /// <summary>
        /// 查询中心仓是否启用
        ///
        /// 查询中心仓是否启用，用于确定当前局点是否具备中心仓功能，从而确保业务流程的顺利进行。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowOpenSourceEnabledResponse> ShowOpenSourceEnabledAsync(ShowOpenSourceEnabledRequest showOpenSourceEnabledRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/opensource/enabled", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOpenSourceEnabledRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowOpenSourceEnabledResponse>(response);
        }

        public AsyncInvoker<ShowOpenSourceEnabledResponse> ShowOpenSourceEnabledAsyncInvoker(ShowOpenSourceEnabledRequest showOpenSourceEnabledRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/opensource/enabled", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOpenSourceEnabledRequest);
            return new AsyncInvoker<ShowOpenSourceEnabledResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOpenSourceEnabledResponse>);
        }
        
        /// <summary>
        /// 获取当前用户的套餐信息
        ///
        /// 获取当前用户的套餐信息，包含总存储容量和已使用存储容量等信息，以便合理规划资源使用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPackageDataDetailResponse> ShowPackageDataDetailAsync(ShowPackageDataDetailRequest showPackageDataDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/data/package", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPackageDataDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPackageDataDetailResponse>(response);
        }

        public AsyncInvoker<ShowPackageDataDetailResponse> ShowPackageDataDetailAsyncInvoker(ShowPackageDataDetailRequest showPackageDataDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/data/package", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPackageDataDetailRequest);
            return new AsyncInvoker<ShowPackageDataDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPackageDataDetailResponse>);
        }
        
        /// <summary>
        /// 获取当前用户的套餐状态
        ///
        /// 获取当前用户的套餐状态，包含套餐扩展包的容量和流量规格，如资源类型、套餐状态、剩余天数等信息，帮助用户高效管理云资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPackageInfoResponse> ShowPackageInfoAsync(ShowPackageInfoRequest showPackageInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/data/package/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPackageInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPackageInfoResponse>(response);
        }

        public AsyncInvoker<ShowPackageInfoResponse> ShowPackageInfoAsyncInvoker(ShowPackageInfoRequest showPackageInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/data/package/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPackageInfoRequest);
            return new AsyncInvoker<ShowPackageInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPackageInfoResponse>);
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
        /// 查询项目列表
        ///
        /// 调用该接口可以快速查询项目列表信息，包含仓库和项目的关联关系，以便于仓库的管理和协作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowProjectRelatedRepositoryResponse> ShowProjectRelatedRepositoryAsync(ShowProjectRelatedRepositoryRequest showProjectRelatedRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/maven/project/repository", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectRelatedRepositoryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectRelatedRepositoryResponse>(response);
        }

        public AsyncInvoker<ShowProjectRelatedRepositoryResponse> ShowProjectRelatedRepositoryAsyncInvoker(ShowProjectRelatedRepositoryRequest showProjectRelatedRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/maven/project/repository", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectRelatedRepositoryRequest);
            return new AsyncInvoker<ShowProjectRelatedRepositoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectRelatedRepositoryResponse>);
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
        /// 查询项目下的制品存储容量信息
        ///
        /// 查询项目下的制品存储容量，包含已使用存储容量和文件数量等信息。在项目管理中，可以使用该接口监控项目下的制品存储情况，以确保资源的有效利用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowProjectStorageInfoResponse> ShowProjectStorageInfoAsync(ShowProjectStorageInfoRequest showProjectStorageInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectStorageInfoRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/{project_id}/storage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectStorageInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectStorageInfoResponse>(response);
        }

        public AsyncInvoker<ShowProjectStorageInfoResponse> ShowProjectStorageInfoAsyncInvoker(ShowProjectStorageInfoRequest showProjectStorageInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectStorageInfoRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/{project_id}/storage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectStorageInfoRequest);
            return new AsyncInvoker<ShowProjectStorageInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectStorageInfoResponse>);
        }
        
        /// <summary>
        /// 查询项目下的版本数量
        ///
        /// 当发布库版本众多时，用户可根据项目ID查询对应发布库的版本数量，以便于管理和跟踪不同版本的发布情况。该接口支持通过版本名称过滤。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowProjectVersionsCountResponse> ShowProjectVersionsCountAsync(ShowProjectVersionsCountRequest showProjectVersionsCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectVersionsCountRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/versions/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectVersionsCountRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectVersionsCountResponse>(response);
        }

        public AsyncInvoker<ShowProjectVersionsCountResponse> ShowProjectVersionsCountAsyncInvoker(ShowProjectVersionsCountRequest showProjectVersionsCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectVersionsCountRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/versions/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectVersionsCountRequest);
            return new AsyncInvoker<ShowProjectVersionsCountResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectVersionsCountResponse>);
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
        /// 查询租户私有依赖库的账号密码
        ///
        /// 在自动化构建场景，用户可调用该接口查询租户私有依赖库的账号密码，以便进行后续的上传下载操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRepoUserInfoResponse> ShowRepoUserInfoAsync(ShowRepoUserInfoRequest showRepoUserInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/repositories/user/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepoUserInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRepoUserInfoResponse>(response);
        }

        public AsyncInvoker<ShowRepoUserInfoResponse> ShowRepoUserInfoAsyncInvoker(ShowRepoUserInfoRequest showRepoUserInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/repositories/user/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepoUserInfoRequest);
            return new AsyncInvoker<ShowRepoUserInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepoUserInfoResponse>);
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
        /// 查询仓库权限
        ///
        /// 根据仓库ID查询指定仓库的权限，包含各角色对该仓库的权限信息。当用户需要指定仓库的指定权限时，可调用该接口查看需要授权的角色。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRepositoryRolesPrivilegeResponse> ShowRepositoryRolesPrivilegeAsync(ShowRepositoryRolesPrivilegeRequest showRepositoryRolesPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryRolesPrivilegeRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryRolesPrivilegeRequest.RepoId, out var valueOfRepoId)) urlParam.Add("repo_id", valueOfRepoId);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/repositories/{project_id}/{repo_id}/privileges", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryRolesPrivilegeRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRepositoryRolesPrivilegeResponse>(response);
        }

        public AsyncInvoker<ShowRepositoryRolesPrivilegeResponse> ShowRepositoryRolesPrivilegeAsyncInvoker(ShowRepositoryRolesPrivilegeRequest showRepositoryRolesPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryRolesPrivilegeRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryRolesPrivilegeRequest.RepoId, out var valueOfRepoId)) urlParam.Add("repo_id", valueOfRepoId);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/repositories/{project_id}/{repo_id}/privileges", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryRolesPrivilegeRequest);
            return new AsyncInvoker<ShowRepositoryRolesPrivilegeResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepositoryRolesPrivilegeResponse>);
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
        /// 查询用户凭证
        ///
        /// 查询用户凭证，该凭证为IDC用户下载制品时使用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowUserTicketResponse> ShowUserTicketAsync(ShowUserTicketRequest showUserTicketRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/ticket", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserTicketRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowUserTicketResponse>(response);
        }

        public AsyncInvoker<ShowUserTicketResponse> ShowUserTicketAsyncInvoker(ShowUserTicketRequest showUserTicketRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/ticket", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserTicketRequest);
            return new AsyncInvoker<ShowUserTicketResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUserTicketResponse>);
        }
        
        /// <summary>
        /// 查询发布库版本列表
        ///
        /// 当发布库版本众多时，用户可根据项目ID分页查询对应发布库下的版本列表。该接口支持版本名称的模糊搜索。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowVersionListResponse> ShowVersionListAsync(ShowVersionListRequest showVersionListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showVersionListRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionListRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowVersionListResponse>(response);
        }

        public AsyncInvoker<ShowVersionListResponse> ShowVersionListAsyncInvoker(ShowVersionListRequest showVersionListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showVersionListRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionListRequest);
            return new AsyncInvoker<ShowVersionListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVersionListResponse>);
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
        
        /// <summary>
        /// 更新角色权限
        ///
        /// 根据角色ID更新指定角色的权限，如创建仓库、编辑仓库、上传、下载、导入和导出等权限，实现权限的集中管理和自动化分配。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRepoRolesPrivilegeResponse> UpdateRepoRolesPrivilegeAsync(UpdateRepoRolesPrivilegeRequest updateRepoRolesPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepoRolesPrivilegeRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/repositories/{role_id}/privileges", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepoRolesPrivilegeRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRepoRolesPrivilegeResponse>(response);
        }

        public AsyncInvoker<UpdateRepoRolesPrivilegeResponse> UpdateRepoRolesPrivilegeAsyncInvoker(UpdateRepoRolesPrivilegeRequest updateRepoRolesPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepoRolesPrivilegeRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/repositories/{role_id}/privileges", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepoRolesPrivilegeRequest);
            return new AsyncInvoker<UpdateRepoRolesPrivilegeResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRepoRolesPrivilegeResponse>);
        }
        
    }
}