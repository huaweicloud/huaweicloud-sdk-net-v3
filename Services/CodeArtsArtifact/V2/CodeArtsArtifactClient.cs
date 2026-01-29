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
        /// 彻底删除文件/文件夹
        ///
        /// 根据文件ID彻底删除文件或文件夹，删除后不能恢复，支持批量删除。可使用该接口清理不再需要的文件或文件夹以释放存储空间。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteCompletelyUpdateFileStateResponse DeleteCompletelyUpdateFileState(DeleteCompletelyUpdateFileStateRequest deleteCompletelyUpdateFileStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/files/compeletion", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCompletelyUpdateFileStateRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteCompletelyUpdateFileStateResponse>(response);
        }

        public SyncInvoker<DeleteCompletelyUpdateFileStateResponse> DeleteCompletelyUpdateFileStateInvoker(DeleteCompletelyUpdateFileStateRequest deleteCompletelyUpdateFileStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/files/compeletion", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCompletelyUpdateFileStateRequest);
            return new SyncInvoker<DeleteCompletelyUpdateFileStateResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteCompletelyUpdateFileStateResponse>);
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
        /// 查询租户容量消息通知设置信息
        ///
        /// 查询租户容量消息通知设置，包含容量阈值和是否启用邮件通知等信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCapacityMessageSettingResponse ListCapacityMessageSetting(ListCapacityMessageSettingRequest listCapacityMessageSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/capacity-notice/settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCapacityMessageSettingRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCapacityMessageSettingResponse>(response);
        }

        public SyncInvoker<ListCapacityMessageSettingResponse> ListCapacityMessageSettingInvoker(ListCapacityMessageSettingRequest listCapacityMessageSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/capacity-notice/settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCapacityMessageSettingRequest);
            return new SyncInvoker<ListCapacityMessageSettingResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCapacityMessageSettingResponse>);
        }
        
        /// <summary>
        /// 获取聚合仓下的仓库代理列表
        ///
        /// 根据仓库ID获取指定聚合仓的仓库代理列表，包含仓库状态、类型、地址和访问路径白名单等信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListChildProxyRepositoriesListResponse ListChildProxyRepositoriesList(ListChildProxyRepositoriesListRequest listChildProxyRepositoriesListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/repositories/proxy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listChildProxyRepositoriesListRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListChildProxyRepositoriesListResponse>(response);
        }

        public SyncInvoker<ListChildProxyRepositoriesListResponse> ListChildProxyRepositoriesListInvoker(ListChildProxyRepositoriesListRequest listChildProxyRepositoriesListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/repositories/proxy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listChildProxyRepositoriesListRequest);
            return new SyncInvoker<ListChildProxyRepositoriesListResponse>(this, "GET", request, JsonUtils.DeSerialize<ListChildProxyRepositoriesListResponse>);
        }
        
        /// <summary>
        /// 查询租户级IP白名单
        ///
        /// 查询租户级IP白名单列表。在IP白名单的IP才能访问制品仓库，未配置IP白名单时，默认所有IP都可访问。该功能可用于保障制品仓库的安全，对访问IP进行严格控制。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDomainIpConfigResponse ListDomainIpConfig(ListDomainIpConfigRequest listDomainIpConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/domain/ipconfig", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainIpConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDomainIpConfigResponse>(response);
        }

        public SyncInvoker<ListDomainIpConfigResponse> ListDomainIpConfigInvoker(ListDomainIpConfigRequest listDomainIpConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/domain/ipconfig", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainIpConfigRequest);
            return new SyncInvoker<ListDomainIpConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainIpConfigResponse>);
        }
        
        /// <summary>
        /// 分页查询构建归档包列表
        ///
        /// 当归档包数量庞大时，分页查询构建归档包列表，包含文件名、文件大小、下载地址、MD5校验和、构建地址、构建代码分支等信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFileBuildArchivesResponse ListFileBuildArchives(ListFileBuildArchivesRequest listFileBuildArchivesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/files/archives", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFileBuildArchivesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFileBuildArchivesResponse>(response);
        }

        public SyncInvoker<ListFileBuildArchivesResponse> ListFileBuildArchivesInvoker(ListFileBuildArchivesRequest listFileBuildArchivesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/files/archives", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFileBuildArchivesRequest);
            return new SyncInvoker<ListFileBuildArchivesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFileBuildArchivesResponse>);
        }
        
        /// <summary>
        /// 查询文件/项目列表
        ///
        /// 当项目或文件数量庞大时，分页查询项目或文件列表。可根据文件名、文件状态和文件的发布状态等参数进行过滤，从而快速找到所需文件，包含文件名、文件大小和下载地址等信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFilesResponse ListFiles(ListFilesRequest listFilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/files/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFilesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListFilesResponse>(response);
        }

        public SyncInvoker<ListFilesResponse> ListFilesInvoker(ListFilesRequest listFilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/files/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFilesRequest);
            return new SyncInvoker<ListFilesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListFilesResponse>);
        }
        
        /// <summary>
        /// 查询项目下所有文件的最新版本
        ///
        /// 当项目文件数量庞大时，通过该接口可以分页查询项目下所有文件的最新版本，包含文件名、文件大小、文件状态和发布状态等信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLatestVersionFilesResponse ListLatestVersionFiles(ListLatestVersionFilesRequest listLatestVersionFilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listLatestVersionFilesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/{project_id}/files/version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLatestVersionFilesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListLatestVersionFilesResponse>(response);
        }

        public SyncInvoker<ListLatestVersionFilesResponse> ListLatestVersionFilesInvoker(ListLatestVersionFilesRequest listLatestVersionFilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listLatestVersionFilesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/{project_id}/files/version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLatestVersionFilesRequest);
            return new SyncInvoker<ListLatestVersionFilesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLatestVersionFilesResponse>);
        }
        
        /// <summary>
        /// 查询Maven仓库列表
        ///
        /// 查询Maven仓库列表，包含仓库状态、类型、地址和访问路径白名单等信息。支持根据项目ID和仓库ID等参数进行过滤。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMavenListResponse ListMavenList(ListMavenListRequest listMavenListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/maven/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMavenListRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMavenListResponse>(response);
        }

        public SyncInvoker<ListMavenListResponse> ListMavenListInvoker(ListMavenListRequest listMavenListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/maven/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMavenListRequest);
            return new SyncInvoker<ListMavenListResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMavenListResponse>);
        }
        
        /// <summary>
        /// 查询私有库用户列表
        ///
        /// 分页查询私有库用户列表，包含用户名和用户是否启用等信息。可根据用户名进行过滤。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMavenUserResponse ListMavenUser(ListMavenUserRequest listMavenUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/repositories/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMavenUserRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMavenUserResponse>(response);
        }

        public SyncInvoker<ListMavenUserResponse> ListMavenUserInvoker(ListMavenUserRequest listMavenUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/repositories/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMavenUserRequest);
            return new SyncInvoker<ListMavenUserResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMavenUserResponse>);
        }
        
        /// <summary>
        /// 查询网络代理列表
        ///
        /// 查询网络代理列表，返回代理源的访问地址及认证信息等，用于代理外部公开的制品资源。通过网络代理，开发人员可以安全、高效地访问所需的外部资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListNetProxyResponse ListNetProxy(ListNetProxyRequest listNetProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/tree/net/proxy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNetProxyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListNetProxyResponse>(response);
        }

        public SyncInvoker<ListNetProxyResponse> ListNetProxyInvoker(ListNetProxyRequest listNetProxyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/tree/net/proxy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNetProxyRequest);
            return new SyncInvoker<ListNetProxyResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNetProxyResponse>);
        }
        
        /// <summary>
        /// 查看项目的角色权限设置
        ///
        /// 查看项目的角色权限设置，包含上传下载、创建文件夹、清空或者还原回收站和更改软件包状态等设置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProjectRolePermissionsResponse ListProjectRolePermissions(ListProjectRolePermissionsRequest listProjectRolePermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/project-role/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectRolePermissionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListProjectRolePermissionsResponse>(response);
        }

        public SyncInvoker<ListProjectRolePermissionsResponse> ListProjectRolePermissionsInvoker(ListProjectRolePermissionsRequest listProjectRolePermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/project-role/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectRolePermissionsRequest);
            return new SyncInvoker<ListProjectRolePermissionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProjectRolePermissionsResponse>);
        }
        
        /// <summary>
        /// 查询项目下的用户
        ///
        /// 当项目中的用户数量较多时，分页查询指定项目下的用户列表，包含用户名和角色等信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProjectUsersResponse ListProjectUsers(ListProjectUsersRequest listProjectUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectUsersRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/projects/{project_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectUsersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListProjectUsersResponse>(response);
        }

        public SyncInvoker<ListProjectUsersResponse> ListProjectUsersInvoker(ListProjectUsersRequest listProjectUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectUsersRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/projects/{project_id}/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectUsersRequest);
            return new SyncInvoker<ListProjectUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProjectUsersResponse>);
        }
        
        /// <summary>
        /// 查询制品安全扫描任务列表
        ///
        /// 分页查询制品安全扫描任务列表，包含扫描制品数量、漏洞数量、病毒文件数量和恶意代码文件数量等信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSecGuardListResponse ListSecGuardList(ListSecGuardListRequest listSecGuardListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/sec-guard/task/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecGuardListRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSecGuardListResponse>(response);
        }

        public SyncInvoker<ListSecGuardListResponse> ListSecGuardListInvoker(ListSecGuardListRequest listSecGuardListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/sec-guard/task/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecGuardListRequest);
            return new SyncInvoker<ListSecGuardListResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSecGuardListResponse>);
        }
        
        /// <summary>
        /// 查询用户权限
        ///
        /// 查询用户在项目下的角色及权限，如创建仓库、编辑仓库、上传、下载、导入和导出等权限。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUserPrivilegesResponse ListUserPrivileges(ListUserPrivilegesRequest listUserPrivilegesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUserPrivilegesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/user/{project_id}/privileges", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserPrivilegesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUserPrivilegesResponse>(response);
        }

        public SyncInvoker<ListUserPrivilegesResponse> ListUserPrivilegesInvoker(ListUserPrivilegesRequest listUserPrivilegesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUserPrivilegesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/user/{project_id}/privileges", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserPrivilegesRequest);
            return new SyncInvoker<ListUserPrivilegesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUserPrivilegesResponse>);
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
        /// 查询项目自动删除任务设置
        ///
        /// 查询项目自动删除任务设置，包含文件的过期自动删除时间及删除规则。自动删除任务可以自动执行文件清理任务，减少管理员的工作负担，确保存储资源的有效利用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAutoDeleteJobSettingsResponse ShowAutoDeleteJobSettings(ShowAutoDeleteJobSettingsRequest showAutoDeleteJobSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutoDeleteJobSettingsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/release/{project_id}/auto-deletion/settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoDeleteJobSettingsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAutoDeleteJobSettingsResponse>(response);
        }

        public SyncInvoker<ShowAutoDeleteJobSettingsResponse> ShowAutoDeleteJobSettingsInvoker(ShowAutoDeleteJobSettingsRequest showAutoDeleteJobSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutoDeleteJobSettingsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/release/{project_id}/auto-deletion/settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoDeleteJobSettingsRequest);
            return new SyncInvoker<ShowAutoDeleteJobSettingsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutoDeleteJobSettingsResponse>);
        }
        
        /// <summary>
        /// 查询租户发布库存储容量
        ///
        /// 查询租户发布库存储容量，包含已使用存储容量、最大存储容量、套餐类型和仓库数量等信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDomainReleaseRepoStorageResponse ShowDomainReleaseRepoStorage(ShowDomainReleaseRepoStorageRequest showDomainReleaseRepoStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/storage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainReleaseRepoStorageRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainReleaseRepoStorageResponse>(response);
        }

        public SyncInvoker<ShowDomainReleaseRepoStorageResponse> ShowDomainReleaseRepoStorageInvoker(ShowDomainReleaseRepoStorageRequest showDomainReleaseRepoStorageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/storage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainReleaseRepoStorageRequest);
            return new SyncInvoker<ShowDomainReleaseRepoStorageResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainReleaseRepoStorageResponse>);
        }
        
        /// <summary>
        /// 根据文件ID查询文件详情
        ///
        /// 在日常数据管理工作中，根据文件ID查询指定文件详情，包含文件名、文件大小、下载地址、校验和、文件状态和发布状态等信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowFileDetailResponse ShowFileDetail(ShowFileDetailRequest showFileDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFileDetailRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/files/{id}/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFileDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowFileDetailResponse>(response);
        }

        public SyncInvoker<ShowFileDetailResponse> ShowFileDetailInvoker(ShowFileDetailRequest showFileDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFileDetailRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/files/{id}/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFileDetailRequest);
            return new SyncInvoker<ShowFileDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFileDetailResponse>);
        }
        
        /// <summary>
        /// 根据文件完整路径查询文件详情
        ///
        /// 在日常数据管理工作中，根据文件完整路径查询指定文件详情，包含文件名、文件大小、下载地址、校验和、文件状态和发布状态等信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowFileDetailByFullNameResponse ShowFileDetailByFullName(ShowFileDetailByFullNameRequest showFileDetailByFullNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/files/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFileDetailByFullNameRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowFileDetailByFullNameResponse>(response);
        }

        public SyncInvoker<ShowFileDetailByFullNameResponse> ShowFileDetailByFullNameInvoker(ShowFileDetailByFullNameRequest showFileDetailByFullNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/files/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFileDetailByFullNameRequest);
            return new SyncInvoker<ShowFileDetailByFullNameResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFileDetailByFullNameResponse>);
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
        /// 查询项目下所有文件的数量
        ///
        /// 查询项目下所有文件的数量，该接口会识别所有文件的最新版本，从而提供准确的文件数量统计。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowLatestVersionFilesCountResponse ShowLatestVersionFilesCount(ShowLatestVersionFilesCountRequest showLatestVersionFilesCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLatestVersionFilesCountRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/{project_id}/files/version/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLatestVersionFilesCountRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowLatestVersionFilesCountResponse>(response);
        }

        public SyncInvoker<ShowLatestVersionFilesCountResponse> ShowLatestVersionFilesCountInvoker(ShowLatestVersionFilesCountRequest showLatestVersionFilesCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLatestVersionFilesCountRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/{project_id}/files/version/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLatestVersionFilesCountRequest);
            return new SyncInvoker<ShowLatestVersionFilesCountResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLatestVersionFilesCountResponse>);
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
        /// 查询多角色用户权限
        ///
        /// 查询多角色用户权限，包含上传下载、创建文件夹、清空或者还原回收站和更改软件包状态等权限信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMultiRolesUserPermissionsResponse ShowMultiRolesUserPermissions(ShowMultiRolesUserPermissionsRequest showMultiRolesUserPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/user/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMultiRolesUserPermissionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMultiRolesUserPermissionsResponse>(response);
        }

        public SyncInvoker<ShowMultiRolesUserPermissionsResponse> ShowMultiRolesUserPermissionsInvoker(ShowMultiRolesUserPermissionsRequest showMultiRolesUserPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/user/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMultiRolesUserPermissionsRequest);
            return new SyncInvoker<ShowMultiRolesUserPermissionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMultiRolesUserPermissionsResponse>);
        }
        
        /// <summary>
        /// 查询中心仓是否启用
        ///
        /// 查询中心仓是否启用，用于确定当前局点是否具备中心仓功能，从而确保业务流程的顺利进行。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowOpenSourceEnabledResponse ShowOpenSourceEnabled(ShowOpenSourceEnabledRequest showOpenSourceEnabledRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/opensource/enabled", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOpenSourceEnabledRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowOpenSourceEnabledResponse>(response);
        }

        public SyncInvoker<ShowOpenSourceEnabledResponse> ShowOpenSourceEnabledInvoker(ShowOpenSourceEnabledRequest showOpenSourceEnabledRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/opensource/enabled", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOpenSourceEnabledRequest);
            return new SyncInvoker<ShowOpenSourceEnabledResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOpenSourceEnabledResponse>);
        }
        
        /// <summary>
        /// 获取当前用户的套餐信息
        ///
        /// 获取当前用户的套餐信息，包含总存储容量和已使用存储容量等信息，以便合理规划资源使用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPackageDataDetailResponse ShowPackageDataDetail(ShowPackageDataDetailRequest showPackageDataDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/data/package", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPackageDataDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPackageDataDetailResponse>(response);
        }

        public SyncInvoker<ShowPackageDataDetailResponse> ShowPackageDataDetailInvoker(ShowPackageDataDetailRequest showPackageDataDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/data/package", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPackageDataDetailRequest);
            return new SyncInvoker<ShowPackageDataDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPackageDataDetailResponse>);
        }
        
        /// <summary>
        /// 获取当前用户的套餐状态
        ///
        /// 获取当前用户的套餐状态，包含套餐扩展包的容量和流量规格，如资源类型、套餐状态、剩余天数等信息，帮助用户高效管理云资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPackageInfoResponse ShowPackageInfo(ShowPackageInfoRequest showPackageInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/data/package/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPackageInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPackageInfoResponse>(response);
        }

        public SyncInvoker<ShowPackageInfoResponse> ShowPackageInfoInvoker(ShowPackageInfoRequest showPackageInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/data/package/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPackageInfoRequest);
            return new SyncInvoker<ShowPackageInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPackageInfoResponse>);
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
        /// 查询项目列表
        ///
        /// 调用该接口可以快速查询项目列表信息，包含仓库和项目的关联关系，以便于仓库的管理和协作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowProjectRelatedRepositoryResponse ShowProjectRelatedRepository(ShowProjectRelatedRepositoryRequest showProjectRelatedRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/maven/project/repository", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectRelatedRepositoryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectRelatedRepositoryResponse>(response);
        }

        public SyncInvoker<ShowProjectRelatedRepositoryResponse> ShowProjectRelatedRepositoryInvoker(ShowProjectRelatedRepositoryRequest showProjectRelatedRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/maven/project/repository", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectRelatedRepositoryRequest);
            return new SyncInvoker<ShowProjectRelatedRepositoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectRelatedRepositoryResponse>);
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
        /// 查询项目下的制品存储容量信息
        ///
        /// 查询项目下的制品存储容量，包含已使用存储容量和文件数量等信息。在项目管理中，可以使用该接口监控项目下的制品存储情况，以确保资源的有效利用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowProjectStorageInfoResponse ShowProjectStorageInfo(ShowProjectStorageInfoRequest showProjectStorageInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectStorageInfoRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/{project_id}/storage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectStorageInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectStorageInfoResponse>(response);
        }

        public SyncInvoker<ShowProjectStorageInfoResponse> ShowProjectStorageInfoInvoker(ShowProjectStorageInfoRequest showProjectStorageInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectStorageInfoRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/devreposerver/v5/{project_id}/storage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectStorageInfoRequest);
            return new SyncInvoker<ShowProjectStorageInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectStorageInfoResponse>);
        }
        
        /// <summary>
        /// 查询项目下的版本数量
        ///
        /// 当发布库版本众多时，用户可根据项目ID查询对应发布库的版本数量，以便于管理和跟踪不同版本的发布情况。该接口支持通过版本名称过滤。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowProjectVersionsCountResponse ShowProjectVersionsCount(ShowProjectVersionsCountRequest showProjectVersionsCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectVersionsCountRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/versions/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectVersionsCountRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectVersionsCountResponse>(response);
        }

        public SyncInvoker<ShowProjectVersionsCountResponse> ShowProjectVersionsCountInvoker(ShowProjectVersionsCountRequest showProjectVersionsCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectVersionsCountRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/versions/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectVersionsCountRequest);
            return new SyncInvoker<ShowProjectVersionsCountResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectVersionsCountResponse>);
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
        /// 查询租户私有依赖库的账号密码
        ///
        /// 在自动化构建场景，用户可调用该接口查询租户私有依赖库的账号密码，以便进行后续的上传下载操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRepoUserInfoResponse ShowRepoUserInfo(ShowRepoUserInfoRequest showRepoUserInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/repositories/user/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepoUserInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRepoUserInfoResponse>(response);
        }

        public SyncInvoker<ShowRepoUserInfoResponse> ShowRepoUserInfoInvoker(ShowRepoUserInfoRequest showRepoUserInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/repositories/user/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepoUserInfoRequest);
            return new SyncInvoker<ShowRepoUserInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepoUserInfoResponse>);
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
        /// 查询仓库权限
        ///
        /// 根据仓库ID查询指定仓库的权限，包含各角色对该仓库的权限信息。当用户需要指定仓库的指定权限时，可调用该接口查看需要授权的角色。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRepositoryRolesPrivilegeResponse ShowRepositoryRolesPrivilege(ShowRepositoryRolesPrivilegeRequest showRepositoryRolesPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryRolesPrivilegeRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryRolesPrivilegeRequest.RepoId, out var valueOfRepoId)) urlParam.Add("repo_id", valueOfRepoId);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/repositories/{project_id}/{repo_id}/privileges", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryRolesPrivilegeRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRepositoryRolesPrivilegeResponse>(response);
        }

        public SyncInvoker<ShowRepositoryRolesPrivilegeResponse> ShowRepositoryRolesPrivilegeInvoker(ShowRepositoryRolesPrivilegeRequest showRepositoryRolesPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryRolesPrivilegeRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryRolesPrivilegeRequest.RepoId, out var valueOfRepoId)) urlParam.Add("repo_id", valueOfRepoId);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/repositories/{project_id}/{repo_id}/privileges", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryRolesPrivilegeRequest);
            return new SyncInvoker<ShowRepositoryRolesPrivilegeResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepositoryRolesPrivilegeResponse>);
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
        /// 查询用户凭证
        ///
        /// 查询用户凭证，该凭证为IDC用户下载制品时使用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowUserTicketResponse ShowUserTicket(ShowUserTicketRequest showUserTicketRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/ticket", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserTicketRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowUserTicketResponse>(response);
        }

        public SyncInvoker<ShowUserTicketResponse> ShowUserTicketInvoker(ShowUserTicketRequest showUserTicketRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/ticket", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserTicketRequest);
            return new SyncInvoker<ShowUserTicketResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUserTicketResponse>);
        }
        
        /// <summary>
        /// 查询发布库版本列表
        ///
        /// 当发布库版本众多时，用户可根据项目ID分页查询对应发布库下的版本列表。该接口支持版本名称的模糊搜索。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowVersionListResponse ShowVersionList(ShowVersionListRequest showVersionListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showVersionListRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionListRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowVersionListResponse>(response);
        }

        public SyncInvoker<ShowVersionListResponse> ShowVersionListInvoker(ShowVersionListRequest showVersionListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showVersionListRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionListRequest);
            return new SyncInvoker<ShowVersionListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVersionListResponse>);
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
        
        /// <summary>
        /// 更新角色权限
        ///
        /// 根据角色ID更新指定角色的权限，如创建仓库、编辑仓库、上传、下载、导入和导出等权限，实现权限的集中管理和自动化分配。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRepoRolesPrivilegeResponse UpdateRepoRolesPrivilege(UpdateRepoRolesPrivilegeRequest updateRepoRolesPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepoRolesPrivilegeRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/repositories/{role_id}/privileges", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepoRolesPrivilegeRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRepoRolesPrivilegeResponse>(response);
        }

        public SyncInvoker<UpdateRepoRolesPrivilegeResponse> UpdateRepoRolesPrivilegeInvoker(UpdateRepoRolesPrivilegeRequest updateRepoRolesPrivilegeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepoRolesPrivilegeRequest.RoleId, out var valueOfRoleId)) urlParam.Add("role_id", valueOfRoleId);
            var urlPath = HttpUtils.AddUrlPath("/cloudartifact/v5/repositories/{role_id}/privileges", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepoRolesPrivilegeRequest);
            return new SyncInvoker<UpdateRepoRolesPrivilegeResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRepoRolesPrivilegeResponse>);
        }
        
    }
}