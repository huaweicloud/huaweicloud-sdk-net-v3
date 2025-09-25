using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.CodeHub.V3.Model;

namespace HuaweiCloud.SDK.CodeHub.V3
{
    public partial class CodeHubAsyncClient : Client
    {
        public static ClientBuilder<CodeHubAsyncClient> NewBuilder()
        {
            return new ClientBuilder<CodeHubAsyncClient>();
        }

        
        /// <summary>
        /// 创建提交
        ///
        /// 能够一次提交位于不同目录的多个文件，目录不存在时，能自动创建目录。支持强制覆盖选项，当选择强制覆盖标志为true时，忽略冲突，强制提交。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateCommitResponse> CreateCommitAsync(CreateCommitRequest createCommitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createCommitRequest.RepoId, out var valueOfRepoId)) urlParam.Add("repo_id", valueOfRepoId);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{repo_id}/repository/commits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCommitRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateCommitResponse>(response);
        }

        public AsyncInvoker<CreateCommitResponse> CreateCommitAsyncInvoker(CreateCommitRequest createCommitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createCommitRequest.RepoId, out var valueOfRepoId)) urlParam.Add("repo_id", valueOfRepoId);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{repo_id}/repository/commits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCommitRequest);
            return new AsyncInvoker<CreateCommitResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCommitResponse>);
        }
        
        /// <summary>
        /// 查询某个仓库的提交信息
        ///
        /// 根据仓库短ID获取提交信息，支持根据文件路径，查询这个路径下所有的commits列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCommitsResponse> ListCommitsAsync(ListCommitsRequest listCommitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listCommitsRequest.RepoId, out var valueOfRepoId)) urlParam.Add("repo_id", valueOfRepoId);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{repo_id}/repository/commits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCommitsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCommitsResponse>(response);
        }

        public AsyncInvoker<ListCommitsResponse> ListCommitsAsyncInvoker(ListCommitsRequest listCommitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listCommitsRequest.RepoId, out var valueOfRepoId)) urlParam.Add("repo_id", valueOfRepoId);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{repo_id}/repository/commits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCommitsRequest);
            return new AsyncInvoker<ListCommitsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCommitsResponse>);
        }
        
        /// <summary>
        /// 查询某个仓库的提交差异信息
        ///
        /// 根据commit id查询提交差异信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDiffCommitResponse> ShowDiffCommitAsync(ShowDiffCommitRequest showDiffCommitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDiffCommitRequest.RepoId, out var valueOfRepoId)) urlParam.Add("repo_id", valueOfRepoId);
            if (StringUtils.TryConvertToNonEmptyString(showDiffCommitRequest.Sha, out var valueOfSha)) urlParam.Add("sha", valueOfSha);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{repo_id}/repository/commits/{sha}/diff", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDiffCommitRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDiffCommitResponse>(response);
        }

        public AsyncInvoker<ShowDiffCommitResponse> ShowDiffCommitAsyncInvoker(ShowDiffCommitRequest showDiffCommitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDiffCommitRequest.RepoId, out var valueOfRepoId)) urlParam.Add("repo_id", valueOfRepoId);
            if (StringUtils.TryConvertToNonEmptyString(showDiffCommitRequest.Sha, out var valueOfSha)) urlParam.Add("sha", valueOfSha);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{repo_id}/repository/commits/{sha}/diff", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDiffCommitRequest);
            return new AsyncInvoker<ShowDiffCommitResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDiffCommitResponse>);
        }
        
        /// <summary>
        /// 查询某个仓库的特定提交信息
        ///
        /// 获取由commit id或分支或标记的名称标识的特定提交。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSingleCommitResponse> ShowSingleCommitAsync(ShowSingleCommitRequest showSingleCommitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSingleCommitRequest.RepoId, out var valueOfRepoId)) urlParam.Add("repo_id", valueOfRepoId);
            if (StringUtils.TryConvertToNonEmptyString(showSingleCommitRequest.Sha, out var valueOfSha)) urlParam.Add("sha", valueOfSha);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{repo_id}/repository/commits/{sha}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSingleCommitRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSingleCommitResponse>(response);
        }

        public AsyncInvoker<ShowSingleCommitResponse> ShowSingleCommitAsyncInvoker(ShowSingleCommitRequest showSingleCommitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSingleCommitRequest.RepoId, out var valueOfRepoId)) urlParam.Add("repo_id", valueOfRepoId);
            if (StringUtils.TryConvertToNonEmptyString(showSingleCommitRequest.Sha, out var valueOfSha)) urlParam.Add("sha", valueOfSha);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{repo_id}/repository/commits/{sha}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSingleCommitRequest);
            return new AsyncInvoker<ShowSingleCommitResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSingleCommitResponse>);
        }
        
        /// <summary>
        /// 创建MR检视意见
        ///
        /// 创建MR检视意见
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateMergeRequestDiscussionResponse> CreateMergeRequestDiscussionAsync(CreateMergeRequestDiscussionRequest createMergeRequestDiscussionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/merge_requests/{merge_request_iid}/discussions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMergeRequestDiscussionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateMergeRequestDiscussionResponse>(response);
        }

        public AsyncInvoker<CreateMergeRequestDiscussionResponse> CreateMergeRequestDiscussionAsyncInvoker(CreateMergeRequestDiscussionRequest createMergeRequestDiscussionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/merge_requests/{merge_request_iid}/discussions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMergeRequestDiscussionRequest);
            return new AsyncInvoker<CreateMergeRequestDiscussionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMergeRequestDiscussionResponse>);
        }
        
        /// <summary>
        /// 回复MR检视意见
        ///
        /// 回复MR检视意见
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateMergeRequestDiscussionNoteResponse> CreateMergeRequestDiscussionNoteAsync(CreateMergeRequestDiscussionNoteRequest createMergeRequestDiscussionNoteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionNoteRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionNoteRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionNoteRequest.DiscussionId, out var valueOfDiscussionId)) urlParam.Add("discussion_id", valueOfDiscussionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/merge_requests/{merge_request_iid}/discussions/{discussion_id}/notes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMergeRequestDiscussionNoteRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateMergeRequestDiscussionNoteResponse>(response);
        }

        public AsyncInvoker<CreateMergeRequestDiscussionNoteResponse> CreateMergeRequestDiscussionNoteAsyncInvoker(CreateMergeRequestDiscussionNoteRequest createMergeRequestDiscussionNoteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionNoteRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionNoteRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionNoteRequest.DiscussionId, out var valueOfDiscussionId)) urlParam.Add("discussion_id", valueOfDiscussionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/merge_requests/{merge_request_iid}/discussions/{discussion_id}/notes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMergeRequestDiscussionNoteRequest);
            return new AsyncInvoker<CreateMergeRequestDiscussionNoteResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMergeRequestDiscussionNoteResponse>);
        }
        
        /// <summary>
        /// 获取检视意见设置
        ///
        /// 获取检视意见设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowReviewSettingResponse> ShowReviewSettingAsync(ShowReviewSettingRequest showReviewSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showReviewSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/review_setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReviewSettingRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowReviewSettingResponse>(response);
        }

        public AsyncInvoker<ShowReviewSettingResponse> ShowReviewSettingAsyncInvoker(ShowReviewSettingRequest showReviewSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showReviewSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/review_setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReviewSettingRequest);
            return new AsyncInvoker<ShowReviewSettingResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowReviewSettingResponse>);
        }
        
        /// <summary>
        /// 查询某个仓库的文件信息
        ///
        /// 获取仓库中文件的信息，如名称、大小、内容。请注意，文件内容是Base64编码的。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFilesByQueryResponse> ListFilesByQueryAsync(ListFilesByQueryRequest listFilesByQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFilesByQueryRequest.RepoId, out var valueOfRepoId)) urlParam.Add("repo_id", valueOfRepoId);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{repo_id}/repository/files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFilesByQueryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListFilesByQueryResponse>(response);
        }

        public AsyncInvoker<ListFilesByQueryResponse> ListFilesByQueryAsyncInvoker(ListFilesByQueryRequest listFilesByQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFilesByQueryRequest.RepoId, out var valueOfRepoId)) urlParam.Add("repo_id", valueOfRepoId);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{repo_id}/repository/files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFilesByQueryRequest);
            return new AsyncInvoker<ListFilesByQueryResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFilesByQueryResponse>);
        }
        
        /// <summary>
        /// 查询某个仓库的文件信息
        ///
        /// 获取仓库中文件的信息，如名称、大小、内容。请注意，文件内容是Base64编码的。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<ShowFileResponse> ShowFileAsync(ShowFileRequest showFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFileRequest.RepoId, out var valueOfRepoId)) urlParam.Add("repo_id", valueOfRepoId);
            if (StringUtils.TryConvertToNonEmptyString(showFileRequest.FilePath, out var valueOfFilePath)) urlParam.Add("file_path", valueOfFilePath);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{repo_id}/repository/files/{file_path}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFileRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowFileResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<ShowFileResponse> ShowFileAsyncInvoker(ShowFileRequest showFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFileRequest.RepoId, out var valueOfRepoId)) urlParam.Add("repo_id", valueOfRepoId);
            if (StringUtils.TryConvertToNonEmptyString(showFileRequest.FilePath, out var valueOfFilePath)) urlParam.Add("file_path", valueOfFilePath);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{repo_id}/repository/files/{file_path}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFileRequest);
            return new AsyncInvoker<ShowFileResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFileResponse>);
        }
        
        /// <summary>
        /// 获取项目下所有仓库信息
        ///
        /// 获取仓库列表 模糊查询支持范围,如果未传入project_id，则支持按仓库名或项目名模糊查询，否则，只按仓库名模糊匹配。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<GetAllRepositoryByProjectIdResponse> GetAllRepositoryByProjectIdAsync(GetAllRepositoryByProjectIdRequest getAllRepositoryByProjectIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getAllRepositoryByProjectIdRequest.ProjectUuid, out var valueOfProjectUuid)) urlParam.Add("project_uuid", valueOfProjectUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_uuid}/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getAllRepositoryByProjectIdRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GetAllRepositoryByProjectIdResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<GetAllRepositoryByProjectIdResponse> GetAllRepositoryByProjectIdAsyncInvoker(GetAllRepositoryByProjectIdRequest getAllRepositoryByProjectIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getAllRepositoryByProjectIdRequest.ProjectUuid, out var valueOfProjectUuid)) urlParam.Add("project_uuid", valueOfProjectUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_uuid}/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getAllRepositoryByProjectIdRequest);
            return new AsyncInvoker<GetAllRepositoryByProjectIdResponse>(this, "GET", request, JsonUtils.DeSerialize<GetAllRepositoryByProjectIdResponse>);
        }
        
        /// <summary>
        /// 获取一个项目下可以设置为公开状态的仓库列表
        ///
        /// 获取一个项目下可以设置为公开状态的仓库列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<GetProductTemplatesResponse> GetProductTemplatesAsync(GetProductTemplatesRequest getProductTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getProductTemplatesRequest.ProjectUuid, out var valueOfProjectUuid)) urlParam.Add("project_uuid", valueOfProjectUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_uuid}/repositories/template_status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getProductTemplatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GetProductTemplatesResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<GetProductTemplatesResponse> GetProductTemplatesAsyncInvoker(GetProductTemplatesRequest getProductTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getProductTemplatesRequest.ProjectUuid, out var valueOfProjectUuid)) urlParam.Add("project_uuid", valueOfProjectUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_uuid}/repositories/template_status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getProductTemplatesRequest);
            return new AsyncInvoker<GetProductTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<GetProductTemplatesResponse>);
        }
        
        /// <summary>
        /// 获取一个项目下可以设置为公开状态的仓库列表
        ///
        /// 获取一个项目下可以设置为公开状态的仓库列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProductTwoTemplatesResponse> ListProductTwoTemplatesAsync(ListProductTwoTemplatesRequest listProductTwoTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProductTwoTemplatesRequest.ProjectUuid, out var valueOfProjectUuid)) urlParam.Add("project_uuid", valueOfProjectUuid);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{project_uuid}/repositories/template-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProductTwoTemplatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListProductTwoTemplatesResponse>(response);
        }

        public AsyncInvoker<ListProductTwoTemplatesResponse> ListProductTwoTemplatesAsyncInvoker(ListProductTwoTemplatesRequest listProductTwoTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProductTwoTemplatesRequest.ProjectUuid, out var valueOfProjectUuid)) urlParam.Add("project_uuid", valueOfProjectUuid);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{project_uuid}/repositories/template-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProductTwoTemplatesRequest);
            return new AsyncInvoker<ListProductTwoTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProductTwoTemplatesResponse>);
        }
        
        /// <summary>
        /// 校验指定项目下的仓库名
        ///
        /// 一般创建仓库时调用。通过传入项目ID，获取方式请参见[获取项目ID](codehub_api_0014.xml)。,仓库名，来判断仓库是否重名。仓库存在result:false,仓库不存在result:true。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRepositoryNameExistResponse> ShowRepositoryNameExistAsync(ShowRepositoryNameExistRequest showRepositoryNameExistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryNameExistRequest.ProjectUuid, out var valueOfProjectUuid)) urlParam.Add("project_uuid", valueOfProjectUuid);
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryNameExistRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_uuid}/repositories/validation/{repository_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryNameExistRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRepositoryNameExistResponse>(response);
        }

        public AsyncInvoker<ShowRepositoryNameExistResponse> ShowRepositoryNameExistAsyncInvoker(ShowRepositoryNameExistRequest showRepositoryNameExistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryNameExistRequest.ProjectUuid, out var valueOfProjectUuid)) urlParam.Add("project_uuid", valueOfProjectUuid);
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryNameExistRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_uuid}/repositories/validation/{repository_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryNameExistRequest);
            return new AsyncInvoker<ShowRepositoryNameExistResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepositoryNameExistResponse>);
        }
        
        /// <summary>
        /// 添加仓库成员
        ///
        /// 添加仓库成员。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddRepoMembersResponse> AddRepoMembersAsync(AddRepoMembersRequest addRepoMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addRepoMembersRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addRepoMembersRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddRepoMembersResponse>(response);
        }

        public AsyncInvoker<AddRepoMembersResponse> AddRepoMembersAsyncInvoker(AddRepoMembersRequest addRepoMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addRepoMembersRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addRepoMembersRequest);
            return new AsyncInvoker<AddRepoMembersResponse>(this, "POST", request, JsonUtils.DeSerialize<AddRepoMembersResponse>);
        }
        
        /// <summary>
        /// 删除仓库成员
        ///
        /// 删除仓库成员
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRepoMemberResponse> DeleteRepoMemberAsync(DeleteRepoMemberRequest deleteRepoMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoMemberRequest.MemberId, out var valueOfMemberId)) urlParam.Add("member_id", valueOfMemberId);
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoMemberRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepoMemberRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteRepoMemberResponse>(response);
        }

        public AsyncInvoker<DeleteRepoMemberResponse> DeleteRepoMemberAsyncInvoker(DeleteRepoMemberRequest deleteRepoMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoMemberRequest.MemberId, out var valueOfMemberId)) urlParam.Add("member_id", valueOfMemberId);
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoMemberRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepoMemberRequest);
            return new AsyncInvoker<DeleteRepoMemberResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteRepoMemberResponse>);
        }
        
        /// <summary>
        /// 获取仓库所有成员记录
        ///
        /// 获取仓库成员列表,可通过关键字搜索某成员。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRepoMembersResponse> ListRepoMembersAsync(ListRepoMembersRequest listRepoMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepoMembersRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepoMembersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRepoMembersResponse>(response);
        }

        public AsyncInvoker<ListRepoMembersResponse> ListRepoMembersAsyncInvoker(ListRepoMembersRequest listRepoMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepoMembersRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepoMembersRequest);
            return new AsyncInvoker<ListRepoMembersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRepoMembersResponse>);
        }
        
        /// <summary>
        /// 设置成员在仓库中的角色
        ///
        /// 给仓库中成员设置仓库的操作权限，
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetRepoRoleResponse> SetRepoRoleAsync(SetRepoRoleRequest setRepoRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setRepoRoleRequest.MemberId, out var valueOfMemberId)) urlParam.Add("member_id", valueOfMemberId);
            if (StringUtils.TryConvertToNonEmptyString(setRepoRoleRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRepoRoleRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<SetRepoRoleResponse>(response);
        }

        public AsyncInvoker<SetRepoRoleResponse> SetRepoRoleAsyncInvoker(SetRepoRoleRequest setRepoRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setRepoRoleRequest.MemberId, out var valueOfMemberId)) urlParam.Add("member_id", valueOfMemberId);
            if (StringUtils.TryConvertToNonEmptyString(setRepoRoleRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRepoRoleRequest);
            return new AsyncInvoker<SetRepoRoleResponse>(this, "PUT", request, JsonUtils.DeSerialize<SetRepoRoleResponse>);
        }
        
        /// <summary>
        /// 添加部署密钥
        ///
        /// 添加部署密钥
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<AddDeployKeyResponse> AddDeployKeyAsync(AddDeployKeyRequest addDeployKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addDeployKeyRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_id}/deploy_keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDeployKeyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddDeployKeyResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<AddDeployKeyResponse> AddDeployKeyAsyncInvoker(AddDeployKeyRequest addDeployKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addDeployKeyRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_id}/deploy_keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDeployKeyRequest);
            return new AsyncInvoker<AddDeployKeyResponse>(this, "POST", request, JsonUtils.DeSerialize<AddDeployKeyResponse>);
        }
        
        /// <summary>
        /// 添加部署密钥
        ///
        /// 添加部署密钥
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddDeployKeyV2Response> AddDeployKeyV2Async(AddDeployKeyV2Request addDeployKeyV2Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addDeployKeyV2Request.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/deploy-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDeployKeyV2Request);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddDeployKeyV2Response>(response);
        }

        public AsyncInvoker<AddDeployKeyV2Response> AddDeployKeyV2AsyncInvoker(AddDeployKeyV2Request addDeployKeyV2Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addDeployKeyV2Request.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/deploy-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDeployKeyV2Request);
            return new AsyncInvoker<AddDeployKeyV2Response>(this, "POST", request, JsonUtils.DeSerialize<AddDeployKeyV2Response>);
        }
        
        /// <summary>
        /// 新建保护分支
        ///
        /// 新建保护分支
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddProtectBranchV2Response> AddProtectBranchV2Async(AddProtectBranchV2Request addProtectBranchV2Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addProtectBranchV2Request.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(addProtectBranchV2Request.BranchName, out var valueOfBranchName)) urlParam.Add("branch_name", valueOfBranchName);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/branch/{branch_name}/protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addProtectBranchV2Request);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<AddProtectBranchV2Response>(response);
        }

        public AsyncInvoker<AddProtectBranchV2Response> AddProtectBranchV2AsyncInvoker(AddProtectBranchV2Request addProtectBranchV2Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addProtectBranchV2Request.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(addProtectBranchV2Request.BranchName, out var valueOfBranchName)) urlParam.Add("branch_name", valueOfBranchName);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/branch/{branch_name}/protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addProtectBranchV2Request);
            return new AsyncInvoker<AddProtectBranchV2Response>(this, "PUT", request, JsonUtils.DeSerialize<AddProtectBranchV2Response>);
        }
        
        /// <summary>
        /// 新建标签
        ///
        /// 新建标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddTagV2Response> AddTagV2Async(AddTagV2Request addTagV2Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addTagV2Request.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addTagV2Request);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddTagV2Response>(response);
        }

        public AsyncInvoker<AddTagV2Response> AddTagV2AsyncInvoker(AddTagV2Request addTagV2Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addTagV2Request.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addTagV2Request);
            return new AsyncInvoker<AddTagV2Response>(this, "POST", request, JsonUtils.DeSerialize<AddTagV2Response>);
        }
        
        /// <summary>
        /// 创建仓库
        ///
        /// 用指定的名称在指定项目上创建仓库。传入参数：仓库名、模板id、是否导入项目成员、归属项目
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRepositoryResponse> CreateRepositoryAsync(CreateRepositoryRequest createRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepositoryRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateRepositoryResponse>(response);
        }

        public AsyncInvoker<CreateRepositoryResponse> CreateRepositoryAsyncInvoker(CreateRepositoryRequest createRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepositoryRequest);
            return new AsyncInvoker<CreateRepositoryResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRepositoryResponse>);
        }
        
        /// <summary>
        /// 删除仓库部署密钥
        ///
        /// 删除仓库部署密钥
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<DeleteDeployKeyResponse> DeleteDeployKeyAsync(DeleteDeployKeyRequest deleteDeployKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDeployKeyRequest.KeyId, out var valueOfKeyId)) urlParam.Add("key_id", valueOfKeyId);
            if (StringUtils.TryConvertToNonEmptyString(deleteDeployKeyRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_id}/deploy_keys/{key_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeployKeyRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDeployKeyResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<DeleteDeployKeyResponse> DeleteDeployKeyAsyncInvoker(DeleteDeployKeyRequest deleteDeployKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDeployKeyRequest.KeyId, out var valueOfKeyId)) urlParam.Add("key_id", valueOfKeyId);
            if (StringUtils.TryConvertToNonEmptyString(deleteDeployKeyRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_id}/deploy_keys/{key_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeployKeyRequest);
            return new AsyncInvoker<DeleteDeployKeyResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDeployKeyResponse>);
        }
        
        /// <summary>
        /// 删除仓库部署密钥
        ///
        /// 删除仓库部署密钥
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDeployKeyV2Response> DeleteDeployKeyV2Async(DeleteDeployKeyV2Request deleteDeployKeyV2Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDeployKeyV2Request.KeyId, out var valueOfKeyId)) urlParam.Add("key_id", valueOfKeyId);
            if (StringUtils.TryConvertToNonEmptyString(deleteDeployKeyV2Request.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/deploy-keys/{key_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeployKeyV2Request);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDeployKeyV2Response>(response);
        }

        public AsyncInvoker<DeleteDeployKeyV2Response> DeleteDeployKeyV2AsyncInvoker(DeleteDeployKeyV2Request deleteDeployKeyV2Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDeployKeyV2Request.KeyId, out var valueOfKeyId)) urlParam.Add("key_id", valueOfKeyId);
            if (StringUtils.TryConvertToNonEmptyString(deleteDeployKeyV2Request.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/deploy-keys/{key_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeployKeyV2Request);
            return new AsyncInvoker<DeleteDeployKeyV2Response>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDeployKeyV2Response>);
        }
        
        /// <summary>
        /// 删除仓库
        ///
        /// 根据仓库32位uuid删除指定的仓库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRepositoryResponse> DeleteRepositoryAsync(DeleteRepositoryRequest deleteRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRepositoryRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepositoryRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteRepositoryResponse>(response);
        }

        public AsyncInvoker<DeleteRepositoryResponse> DeleteRepositoryAsyncInvoker(DeleteRepositoryRequest deleteRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRepositoryRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepositoryRequest);
            return new AsyncInvoker<DeleteRepositoryResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteRepositoryResponse>);
        }
        
        /// <summary>
        /// 查询项目下的某个仓库
        ///
        /// 不建议再使用,建议使用/{repository_uuid}/status
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<GetRepositoryByProjectIdResponse> GetRepositoryByProjectIdAsync(GetRepositoryByProjectIdRequest getRepositoryByProjectIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getRepositoryByProjectIdRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getRepositoryByProjectIdRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GetRepositoryByProjectIdResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<GetRepositoryByProjectIdResponse> GetRepositoryByProjectIdAsyncInvoker(GetRepositoryByProjectIdRequest getRepositoryByProjectIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getRepositoryByProjectIdRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getRepositoryByProjectIdRequest);
            return new AsyncInvoker<GetRepositoryByProjectIdResponse>(this, "GET", request, JsonUtils.DeSerialize<GetRepositoryByProjectIdResponse>);
        }
        
        /// <summary>
        /// 获取公开示例模板列表
        ///
        /// 获取公开示例模板列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<GetTemplatesResponse> GetTemplatesAsync(GetTemplatesRequest getTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/repository_templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getTemplatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<GetTemplatesResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<GetTemplatesResponse> GetTemplatesAsyncInvoker(GetTemplatesRequest getTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/repository_templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getTemplatesRequest);
            return new AsyncInvoker<GetTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<GetTemplatesResponse>);
        }
        
        /// <summary>
        /// 获取仓库分支列表
        ///
        /// 获取仓库分支列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBranchesByRepositoryIdResponse> ListBranchesByRepositoryIdAsync(ListBranchesByRepositoryIdRequest listBranchesByRepositoryIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBranchesByRepositoryIdRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBranchesByRepositoryIdRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListBranchesByRepositoryIdResponse>(response);
        }

        public AsyncInvoker<ListBranchesByRepositoryIdResponse> ListBranchesByRepositoryIdAsyncInvoker(ListBranchesByRepositoryIdRequest listBranchesByRepositoryIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBranchesByRepositoryIdRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBranchesByRepositoryIdRequest);
            return new AsyncInvoker<ListBranchesByRepositoryIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBranchesByRepositoryIdResponse>);
        }
        
        /// <summary>
        /// 获取仓库上一次的提交统计信息
        ///
        /// 获取仓库上一次的提交统计信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCommitStatisticsResponse> ListCommitStatisticsAsync(ListCommitStatisticsRequest listCommitStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listCommitStatisticsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_id}/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCommitStatisticsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCommitStatisticsResponse>(response);
        }

        public AsyncInvoker<ListCommitStatisticsResponse> ListCommitStatisticsAsyncInvoker(ListCommitStatisticsRequest listCommitStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listCommitStatisticsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_id}/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCommitStatisticsRequest);
            return new AsyncInvoker<ListCommitStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCommitStatisticsResponse>);
        }
        
        /// <summary>
        /// 获取一个仓库下特定分支指定文件内容
        ///
        /// 获取一个仓库下特定分支指定文件内容
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFilesResponse> ListFilesAsync(ListFilesRequest listFilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFilesRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            if (StringUtils.TryConvertToNonEmptyString(listFilesRequest.BranchName, out var valueOfBranchName)) urlParam.Add("branch_name", valueOfBranchName);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/branch/{branch_name}/file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFilesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListFilesResponse>(response);
        }

        public AsyncInvoker<ListFilesResponse> ListFilesAsyncInvoker(ListFilesRequest listFilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFilesRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            if (StringUtils.TryConvertToNonEmptyString(listFilesRequest.BranchName, out var valueOfBranchName)) urlParam.Add("branch_name", valueOfBranchName);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/branch/{branch_name}/file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFilesRequest);
            return new AsyncInvoker<ListFilesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFilesResponse>);
        }
        
        /// <summary>
        /// 获取变更文件
        ///
        /// 获取变更文件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMergeChangesResponse> ListMergeChangesAsync(ListMergeChangesRequest listMergeChangesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeChangesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeChangesRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/merge-requests/{merge_request_iid}/changes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeChangesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListMergeChangesResponse>(response);
        }

        public AsyncInvoker<ListMergeChangesResponse> ListMergeChangesAsyncInvoker(ListMergeChangesRequest listMergeChangesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeChangesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeChangesRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/merge-requests/{merge_request_iid}/changes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeChangesRequest);
            return new AsyncInvoker<ListMergeChangesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMergeChangesResponse>);
        }
        
        /// <summary>
        /// 获取变更文件列表
        ///
        /// 获取变更文件列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMergeChangesTreesResponse> ListMergeChangesTreesAsync(ListMergeChangesTreesRequest listMergeChangesTreesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeChangesTreesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeChangesTreesRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/merge-requests/{merge_request_iid}/changes-trees", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeChangesTreesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListMergeChangesTreesResponse>(response);
        }

        public AsyncInvoker<ListMergeChangesTreesResponse> ListMergeChangesTreesAsyncInvoker(ListMergeChangesTreesRequest listMergeChangesTreesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeChangesTreesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeChangesTreesRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/merge-requests/{merge_request_iid}/changes-trees", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeChangesTreesRequest);
            return new AsyncInvoker<ListMergeChangesTreesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMergeChangesTreesResponse>);
        }
        
        /// <summary>
        /// 获取仓库合并请求列表
        ///
        /// 获取仓库合并请求列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMergeRequestResponse> ListMergeRequestAsync(ListMergeRequestRequest listMergeRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/merge_request", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListMergeRequestResponse>(response);
        }

        public AsyncInvoker<ListMergeRequestResponse> ListMergeRequestAsyncInvoker(ListMergeRequestRequest listMergeRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/merge_request", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestRequest);
            return new AsyncInvoker<ListMergeRequestResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMergeRequestResponse>);
        }
        
        /// <summary>
        /// 根据仓库短ID和合并请求短ID获取检视人信息
        ///
        /// 根据仓库短ID和合并请求短ID获取检视人信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMergeRequestReviewersResponse> ListMergeRequestReviewersAsync(ListMergeRequestReviewersRequest listMergeRequestReviewersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestReviewersRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestReviewersRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/merge-requests/{merge_request_iid}/approval-reviewers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestReviewersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListMergeRequestReviewersResponse>(response);
        }

        public AsyncInvoker<ListMergeRequestReviewersResponse> ListMergeRequestReviewersAsyncInvoker(ListMergeRequestReviewersRequest listMergeRequestReviewersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestReviewersRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestReviewersRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/merge-requests/{merge_request_iid}/approval-reviewers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestReviewersRequest);
            return new AsyncInvoker<ListMergeRequestReviewersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMergeRequestReviewersResponse>);
        }
        
        /// <summary>
        /// 获取关联工作项信息
        ///
        /// 获取关联工作项信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRelatedCommitsResponse> ListRelatedCommitsAsync(ListRelatedCommitsRequest listRelatedCommitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRelatedCommitsRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_uuid}/related-commits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRelatedCommitsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRelatedCommitsResponse>(response);
        }

        public AsyncInvoker<ListRelatedCommitsResponse> ListRelatedCommitsAsyncInvoker(ListRelatedCommitsRequest listRelatedCommitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRelatedCommitsRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_uuid}/related-commits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRelatedCommitsRequest);
            return new AsyncInvoker<ListRelatedCommitsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRelatedCommitsResponse>);
        }
        
        /// <summary>
        /// 查看仓库的创建状态
        ///
        /// 获取仓库状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRepositoryStatusResponse> ListRepositoryStatusAsync(ListRepositoryStatusRequest listRepositoryStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryStatusRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRepositoryStatusResponse>(response);
        }

        public AsyncInvoker<ListRepositoryStatusResponse> ListRepositoryStatusAsyncInvoker(ListRepositoryStatusRequest listRepositoryStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryStatusRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryStatusRequest);
            return new AsyncInvoker<ListRepositoryStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRepositoryStatusResponse>);
        }
        
        /// <summary>
        /// 获取分支目录下的文件
        ///
        /// 获取分支目录下的文件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSubfilesResponse> ListSubfilesAsync(ListSubfilesRequest listSubfilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSubfilesRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            if (StringUtils.TryConvertToNonEmptyString(listSubfilesRequest.BranchName, out var valueOfBranchName)) urlParam.Add("branch_name", valueOfBranchName);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/branch/{branch_name}/sub-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubfilesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSubfilesResponse>(response);
        }

        public AsyncInvoker<ListSubfilesResponse> ListSubfilesAsyncInvoker(ListSubfilesRequest listSubfilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSubfilesRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            if (StringUtils.TryConvertToNonEmptyString(listSubfilesRequest.BranchName, out var valueOfBranchName)) urlParam.Add("branch_name", valueOfBranchName);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/branch/{branch_name}/sub-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubfilesRequest);
            return new AsyncInvoker<ListSubfilesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSubfilesResponse>);
        }
        
        /// <summary>
        /// 设置仓库是公开状态还是私有状态
        ///
        /// 设置仓库是公开状态还是私有状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTemplatesTwoResponse> ListTemplatesTwoAsync(ListTemplatesTwoRequest listTemplatesTwoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTemplatesTwoRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_uuid}/template-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplatesTwoRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ListTemplatesTwoResponse>(response);
        }

        public AsyncInvoker<ListTemplatesTwoResponse> ListTemplatesTwoAsyncInvoker(ListTemplatesTwoRequest listTemplatesTwoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTemplatesTwoRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_uuid}/template-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplatesTwoRequest);
            return new AsyncInvoker<ListTemplatesTwoResponse>(this, "PUT", request, JsonUtils.DeSerialize<ListTemplatesTwoResponse>);
        }
        
        /// <summary>
        /// 获取公开示例模板列表
        ///
        /// 获取公开示例模板列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTwoTemplatesResponse> ListTwoTemplatesAsync(ListTwoTemplatesRequest listTwoTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/repository-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTwoTemplatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTwoTemplatesResponse>(response);
        }

        public AsyncInvoker<ListTwoTemplatesResponse> ListTwoTemplatesAsyncInvoker(ListTwoTemplatesRequest listTwoTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/repository-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTwoTemplatesRequest);
            return new AsyncInvoker<ListTwoTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTwoTemplatesResponse>);
        }
        
        /// <summary>
        /// 设置仓库是公开状态还是私有状态
        ///
        /// 设置仓库是公开状态还是私有状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<ShareTemplatesResponse> ShareTemplatesAsync(ShareTemplatesRequest shareTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(shareTemplatesRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/template_status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", shareTemplatesRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ShareTemplatesResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<ShareTemplatesResponse> ShareTemplatesAsyncInvoker(ShareTemplatesRequest shareTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(shareTemplatesRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/template_status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", shareTemplatesRequest);
            return new AsyncInvoker<ShareTemplatesResponse>(this, "PUT", request, JsonUtils.DeSerialize<ShareTemplatesResponse>);
        }
        
        /// <summary>
        /// 查询某仓库对应的分支
        ///
        /// 根据仓库id获取指定仓库的分支列表.
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBranchesByRepositoryIdResponse> ShowBranchesByRepositoryIdAsync(ShowBranchesByRepositoryIdRequest showBranchesByRepositoryIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBranchesByRepositoryIdRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_id}/branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBranchesByRepositoryIdRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowBranchesByRepositoryIdResponse>(response);
        }

        public AsyncInvoker<ShowBranchesByRepositoryIdResponse> ShowBranchesByRepositoryIdAsyncInvoker(ShowBranchesByRepositoryIdRequest showBranchesByRepositoryIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBranchesByRepositoryIdRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_id}/branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBranchesByRepositoryIdRequest);
            return new AsyncInvoker<ShowBranchesByRepositoryIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBranchesByRepositoryIdResponse>);
        }
        
        /// <summary>
        /// 查询某仓库的标签列表
        ///
        /// 查询指定仓库对应的分支。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBranchesByTwoRepositoryIdResponse> ShowBranchesByTwoRepositoryIdAsync(ShowBranchesByTwoRepositoryIdRequest showBranchesByTwoRepositoryIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBranchesByTwoRepositoryIdRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBranchesByTwoRepositoryIdRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowBranchesByTwoRepositoryIdResponse>(response);
        }

        public AsyncInvoker<ShowBranchesByTwoRepositoryIdResponse> ShowBranchesByTwoRepositoryIdAsyncInvoker(ShowBranchesByTwoRepositoryIdRequest showBranchesByTwoRepositoryIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBranchesByTwoRepositoryIdRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBranchesByTwoRepositoryIdRequest);
            return new AsyncInvoker<ShowBranchesByTwoRepositoryIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBranchesByTwoRepositoryIdResponse>);
        }
        
        /// <summary>
        /// 根据组名和仓库名查询某仓库某分支对应的提交
        ///
        /// 根据仓库组名、仓库名和分支获取提交列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCommitsByBranchResponse> ShowCommitsByBranchAsync(ShowCommitsByBranchRequest showCommitsByBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCommitsByBranchRequest.GroupName, out var valueOfGroupName)) urlParam.Add("group_name", valueOfGroupName);
            if (StringUtils.TryConvertToNonEmptyString(showCommitsByBranchRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{group_name}/{repository_name}/commits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCommitsByBranchRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowCommitsByBranchResponse>(response);
        }

        public AsyncInvoker<ShowCommitsByBranchResponse> ShowCommitsByBranchAsyncInvoker(ShowCommitsByBranchRequest showCommitsByBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCommitsByBranchRequest.GroupName, out var valueOfGroupName)) urlParam.Add("group_name", valueOfGroupName);
            if (StringUtils.TryConvertToNonEmptyString(showCommitsByBranchRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{group_name}/{repository_name}/commits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCommitsByBranchRequest);
            return new AsyncInvoker<ShowCommitsByBranchResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCommitsByBranchResponse>);
        }
        
        /// <summary>
        /// 根据仓库id查询仓库某分支对应的提交，提供更多可选参数
        ///
        /// 根据仓库id查询仓库某分支对应的提交.
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCommitsByRepoIdResponse> ShowCommitsByRepoIdAsync(ShowCommitsByRepoIdRequest showCommitsByRepoIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCommitsByRepoIdRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_id}/commits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCommitsByRepoIdRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowCommitsByRepoIdResponse>(response);
        }

        public AsyncInvoker<ShowCommitsByRepoIdResponse> ShowCommitsByRepoIdAsyncInvoker(ShowCommitsByRepoIdRequest showCommitsByRepoIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCommitsByRepoIdRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_id}/commits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCommitsByRepoIdRequest);
            return new AsyncInvoker<ShowCommitsByRepoIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCommitsByRepoIdResponse>);
        }
        
        /// <summary>
        /// 修改被流水线引用的仓库状态
        ///
        /// 修改被流水线引用的仓库状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowHasPipelineResponse> ShowHasPipelineAsync(ShowHasPipelineRequest showHasPipelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showHasPipelineRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/pipeline", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHasPipelineRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ShowHasPipelineResponse>(response);
        }

        public AsyncInvoker<ShowHasPipelineResponse> ShowHasPipelineAsyncInvoker(ShowHasPipelineRequest showHasPipelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showHasPipelineRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/pipeline", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHasPipelineRequest);
            return new AsyncInvoker<ShowHasPipelineResponse>(this, "PUT", request, JsonUtils.DeSerialize<ShowHasPipelineResponse>);
        }
        
        /// <summary>
        /// 获取一个仓库下特定分支的图片文件
        ///
        /// 获取一个仓库下特定分支的图片文件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowImageBlobResponse> ShowImageBlobAsync(ShowImageBlobRequest showImageBlobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showImageBlobRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            if (StringUtils.TryConvertToNonEmptyString(showImageBlobRequest.BranchName, out var valueOfBranchName)) urlParam.Add("branch_name", valueOfBranchName);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/branch/{branch_name}/image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showImageBlobRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerializeNull<ShowImageBlobResponse>(response);
        }

        public AsyncInvoker<ShowImageBlobResponse> ShowImageBlobAsyncInvoker(ShowImageBlobRequest showImageBlobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showImageBlobRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            if (StringUtils.TryConvertToNonEmptyString(showImageBlobRequest.BranchName, out var valueOfBranchName)) urlParam.Add("branch_name", valueOfBranchName);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/branch/{branch_name}/image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showImageBlobRequest);
            return new AsyncInvoker<ShowImageBlobResponse>(this, "GET", request, JsonUtils.DeSerializeNull<ShowImageBlobResponse>);
        }
        
        /// <summary>
        /// 判断用户是否有仓库的管理员权限
        ///
        /// 判断用户是否有仓库的管理员权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMasterResponse> ShowMasterAsync(ShowMasterRequest showMasterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMasterRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/master", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMasterRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowMasterResponse>(response);
        }

        public AsyncInvoker<ShowMasterResponse> ShowMasterAsyncInvoker(ShowMasterRequest showMasterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMasterRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/master", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMasterRequest);
            return new AsyncInvoker<ShowMasterResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMasterResponse>);
        }
        
        /// <summary>
        /// 获取仓库合并请求详情
        ///
        /// 获取仓库合并请求详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMergeRequestResponse> ShowMergeRequestAsync(ShowMergeRequestRequest showMergeRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestRequest.MergeRequestId, out var valueOfMergeRequestId)) urlParam.Add("merge_request_id", valueOfMergeRequestId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/merge_request/{merge_request_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMergeRequestRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowMergeRequestResponse>(response);
        }

        public AsyncInvoker<ShowMergeRequestResponse> ShowMergeRequestAsyncInvoker(ShowMergeRequestRequest showMergeRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestRequest.MergeRequestId, out var valueOfMergeRequestId)) urlParam.Add("merge_request_id", valueOfMergeRequestId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/merge_request/{merge_request_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMergeRequestRequest);
            return new AsyncInvoker<ShowMergeRequestResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMergeRequestResponse>);
        }
        
        /// <summary>
        /// 根据仓库名组名获取仓库短id，用以拼接与commitid对应提交详情页面url
        ///
        /// 获取仓库短id,用于获取仓库详情页面url
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRepoIdResponse> ShowRepoIdAsync(ShowRepoIdRequest showRepoIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/repoid", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepoIdRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRepoIdResponse>(response);
        }

        public AsyncInvoker<ShowRepoIdResponse> ShowRepoIdAsyncInvoker(ShowRepoIdRequest showRepoIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/repoid", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepoIdRequest);
            return new AsyncInvoker<ShowRepoIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepoIdResponse>);
        }
        
        /// <summary>
        /// 下载仓库
        ///
        /// 按照指定格式下载仓库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRepositoryArchiveResponse> ShowRepositoryArchiveAsync(ShowRepositoryArchiveRequest showRepositoryArchiveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryArchiveRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_uuid}/archive", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryArchiveRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRepositoryArchiveResponse>(response);
        }

        public AsyncInvoker<ShowRepositoryArchiveResponse> ShowRepositoryArchiveAsyncInvoker(ShowRepositoryArchiveRequest showRepositoryArchiveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryArchiveRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_uuid}/archive", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryArchiveRequest);
            return new AsyncInvoker<ShowRepositoryArchiveResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepositoryArchiveResponse>);
        }
        
        /// <summary>
        /// 查询某个仓库的详细信息
        ///
        /// 根据仓库UUID(由CreateRepository接口返回)获取仓库信息仓库信息。返回 包含id，name，组名，仓库访问URL。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRepositoryByUuidResponse> ShowRepositoryByUuidAsync(ShowRepositoryByUuidRequest showRepositoryByUuidRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryByUuidRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_uuid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryByUuidRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRepositoryByUuidResponse>(response);
        }

        public AsyncInvoker<ShowRepositoryByUuidResponse> ShowRepositoryByUuidAsyncInvoker(ShowRepositoryByUuidRequest showRepositoryByUuidRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryByUuidRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_uuid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryByUuidRequest);
            return new AsyncInvoker<ShowRepositoryByUuidResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepositoryByUuidResponse>);
        }
        
        /// <summary>
        /// 仓库统计
        ///
        /// 根据仓库短id，查询仓库的代码提交记录统计
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRepositoryStatisticsResponse> ShowRepositoryStatisticsAsync(ShowRepositoryStatisticsRequest showRepositoryStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryStatisticsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_id}/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryStatisticsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShowRepositoryStatisticsResponse>(response);
        }

        public AsyncInvoker<ShowRepositoryStatisticsResponse> ShowRepositoryStatisticsAsyncInvoker(ShowRepositoryStatisticsRequest showRepositoryStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryStatisticsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_id}/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryStatisticsRequest);
            return new AsyncInvoker<ShowRepositoryStatisticsResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowRepositoryStatisticsResponse>);
        }
        
        /// <summary>
        /// 获取代码提交行数
        ///
        /// 获取指定日期内代码仓指定分支的代码提交行数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<ShowStatisticCommitResponse> ShowStatisticCommitAsync(ShowStatisticCommitRequest showStatisticCommitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showStatisticCommitRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/commit_lines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatisticCommitRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowStatisticCommitResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<ShowStatisticCommitResponse> ShowStatisticCommitAsyncInvoker(ShowStatisticCommitRequest showStatisticCommitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showStatisticCommitRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/commit_lines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatisticCommitRequest);
            return new AsyncInvoker<ShowStatisticCommitResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStatisticCommitResponse>);
        }
        
        /// <summary>
        /// 获取代码提交行数
        ///
        /// 获取指定日期内代码仓指定分支的代码提交行数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowStatisticCommitV3Response> ShowStatisticCommitV3Async(ShowStatisticCommitV3Request showStatisticCommitV3Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showStatisticCommitV3Request.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v3/repositories/{repository_id}/commit-lines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatisticCommitV3Request);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowStatisticCommitV3Response>(response);
        }

        public AsyncInvoker<ShowStatisticCommitV3Response> ShowStatisticCommitV3AsyncInvoker(ShowStatisticCommitV3Request showStatisticCommitV3Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showStatisticCommitV3Request.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v3/repositories/{repository_id}/commit-lines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatisticCommitV3Request);
            return new AsyncInvoker<ShowStatisticCommitV3Response>(this, "GET", request, JsonUtils.DeSerialize<ShowStatisticCommitV3Response>);
        }
        
        /// <summary>
        /// 获取仓库统计数据
        ///
        /// 获取仓库统计数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowStatisticalDataResponse> ShowStatisticalDataAsync(ShowStatisticalDataRequest showStatisticalDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showStatisticalDataRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/statistic-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatisticalDataRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowStatisticalDataResponse>(response);
        }

        public AsyncInvoker<ShowStatisticalDataResponse> ShowStatisticalDataAsyncInvoker(ShowStatisticalDataRequest showStatisticalDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showStatisticalDataRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/statistic-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatisticalDataRequest);
            return new AsyncInvoker<ShowStatisticalDataResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStatisticalDataResponse>);
        }
        
        /// <summary>
        /// 合并请求代码审核
        ///
        /// 合并请求代码审核
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateMergeRequestApprovalStateResponse> UpdateMergeRequestApprovalStateAsync(UpdateMergeRequestApprovalStateRequest updateMergeRequestApprovalStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestApprovalStateRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestApprovalStateRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/merge-requests/{merge_request_iid}/approval", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestApprovalStateRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateMergeRequestApprovalStateResponse>(response);
        }

        public AsyncInvoker<UpdateMergeRequestApprovalStateResponse> UpdateMergeRequestApprovalStateAsyncInvoker(UpdateMergeRequestApprovalStateRequest updateMergeRequestApprovalStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestApprovalStateRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestApprovalStateRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/merge-requests/{merge_request_iid}/approval", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestApprovalStateRequest);
            return new AsyncInvoker<UpdateMergeRequestApprovalStateResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateMergeRequestApprovalStateResponse>);
        }
        
        /// <summary>
        /// 添加ssh key
        ///
        /// 添加ssh key
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddSshKeyResponse> AddSshKeyAsync(AddSshKeyRequest addSshKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/users/sshkey", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addSshKeyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddSshKeyResponse>(response);
        }

        public AsyncInvoker<AddSshKeyResponse> AddSshKeyAsyncInvoker(AddSshKeyRequest addSshKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/users/sshkey", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addSshKeyRequest);
            return new AsyncInvoker<AddSshKeyResponse>(this, "POST", request, JsonUtils.DeSerialize<AddSshKeyResponse>);
        }
        
        /// <summary>
        /// 删除用户公钥
        ///
        /// 删除用户公钥。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<DeleteSShkeyResponse> DeleteSShkeyAsync(DeleteSShkeyRequest deleteSShkeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSShkeyRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/users/sshkey/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSShkeyRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteSShkeyResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<DeleteSShkeyResponse> DeleteSShkeyAsyncInvoker(DeleteSShkeyRequest deleteSShkeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSShkeyRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/users/sshkey/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSShkeyRequest);
            return new AsyncInvoker<DeleteSShkeyResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteSShkeyResponse>);
        }
        
        /// <summary>
        /// 获取ssh key列表
        ///
        /// 获取ssh key列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSshKeysResponse> ListSshKeysAsync(ListSshKeysRequest listSshKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/users/sshkey", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSshKeysRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSshKeysResponse>(response);
        }

        public AsyncInvoker<ListSshKeysResponse> ListSshKeysAsyncInvoker(ListSshKeysRequest listSshKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/users/sshkey", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSshKeysRequest);
            return new AsyncInvoker<ListSshKeysResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSshKeysResponse>);
        }
        
        /// <summary>
        /// 检验私钥是否有拉取代码的权限
        ///
        /// 检验私钥是否有拉取代码的权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPrivateKeyVerifyResponse> ShowPrivateKeyVerifyAsync(ShowPrivateKeyVerifyRequest showPrivateKeyVerifyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/users/sshkey/privatekey/verify", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateKeyVerifyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShowPrivateKeyVerifyResponse>(response);
        }

        public AsyncInvoker<ShowPrivateKeyVerifyResponse> ShowPrivateKeyVerifyAsyncInvoker(ShowPrivateKeyVerifyRequest showPrivateKeyVerifyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/users/sshkey/privatekey/verify", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateKeyVerifyRequest);
            return new AsyncInvoker<ShowPrivateKeyVerifyResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowPrivateKeyVerifyResponse>);
        }
        
        /// <summary>
        ///  https账号密码校验
        ///
        /// 判断用户使用 https 上传/下载代码时输入的用户名和密码是否合法。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<ValidateHttpsInfoResponse> ValidateHttpsInfoAsync(ValidateHttpsInfoRequest validateHttpsInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(validateHttpsInfoRequest.IamUserUuid, out var valueOfIamUserUuid)) urlParam.Add("iam_user_uuid", valueOfIamUserUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/user/{iam_user_uuid}/validateHttpsInfo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", validateHttpsInfoRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ValidateHttpsInfoResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<ValidateHttpsInfoResponse> ValidateHttpsInfoAsyncInvoker(ValidateHttpsInfoRequest validateHttpsInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(validateHttpsInfoRequest.IamUserUuid, out var valueOfIamUserUuid)) urlParam.Add("iam_user_uuid", valueOfIamUserUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/user/{iam_user_uuid}/validateHttpsInfo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", validateHttpsInfoRequest);
            return new AsyncInvoker<ValidateHttpsInfoResponse>(this, "POST", request, JsonUtils.DeSerialize<ValidateHttpsInfoResponse>);
        }
        
        /// <summary>
        /// https账号密码校验
        ///
        /// 判断用户使用 https 上传/下载代码时输入的用户名和密码是否合法。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ValidateHttpsInfoV2Response> ValidateHttpsInfoV2Async(ValidateHttpsInfoV2Request validateHttpsInfoV2Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(validateHttpsInfoV2Request.IamUserUuid, out var valueOfIamUserUuid)) urlParam.Add("iam_user_uuid", valueOfIamUserUuid);
            var urlPath = HttpUtils.AddUrlPath("/v2/user/{iam_user_uuid}/validate-https-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", validateHttpsInfoV2Request);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ValidateHttpsInfoV2Response>(response);
        }

        public AsyncInvoker<ValidateHttpsInfoV2Response> ValidateHttpsInfoV2AsyncInvoker(ValidateHttpsInfoV2Request validateHttpsInfoV2Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(validateHttpsInfoV2Request.IamUserUuid, out var valueOfIamUserUuid)) urlParam.Add("iam_user_uuid", valueOfIamUserUuid);
            var urlPath = HttpUtils.AddUrlPath("/v2/user/{iam_user_uuid}/validate-https-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", validateHttpsInfoV2Request);
            return new AsyncInvoker<ValidateHttpsInfoV2Response>(this, "POST", request, JsonUtils.DeSerialize<ValidateHttpsInfoV2Response>);
        }
        
        /// <summary>
        /// 创建分支
        ///
        /// 根据仓库id在指定仓库中创建分支
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateNewBranchResponse> CreateNewBranchAsync(CreateNewBranchRequest createNewBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createNewBranchRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNewBranchRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateNewBranchResponse>(response);
        }

        public AsyncInvoker<CreateNewBranchResponse> CreateNewBranchAsyncInvoker(CreateNewBranchRequest createNewBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createNewBranchRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNewBranchRequest);
            return new AsyncInvoker<CreateNewBranchResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateNewBranchResponse>);
        }
        
        /// <summary>
        /// 分支关联工作项
        ///
        /// 分支关联工作项
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociateIssuesResponse> AssociateIssuesAsync(AssociateIssuesRequest associateIssuesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/issues", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateIssuesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AssociateIssuesResponse>(response);
        }

        public AsyncInvoker<AssociateIssuesResponse> AssociateIssuesAsyncInvoker(AssociateIssuesRequest associateIssuesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/issues", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateIssuesRequest);
            return new AsyncInvoker<AssociateIssuesResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateIssuesResponse>);
        }
        
        /// <summary>
        /// 创建项目、仓库
        ///
        /// 创建项目后，创建仓库组由后台生成方式 传入参数：仓库名、模板id、是否导入项目成员、归属项目
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateProjectAndRepositoriesResponse> CreateProjectAndRepositoriesAsync(CreateProjectAndRepositoriesRequest createProjectAndRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProjectAndRepositoriesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateProjectAndRepositoriesResponse>(response);
        }

        public AsyncInvoker<CreateProjectAndRepositoriesResponse> CreateProjectAndRepositoriesAsyncInvoker(CreateProjectAndRepositoriesRequest createProjectAndRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProjectAndRepositoriesRequest);
            return new AsyncInvoker<CreateProjectAndRepositoriesResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateProjectAndRepositoriesResponse>);
        }
        
        /// <summary>
        /// 创建项目并fork仓库
        ///
        /// 创建仓库后fork仓库 传入参数：仓库名、是否导入项目成员、归属项目
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateProjectAndforkRepositoriesResponse> CreateProjectAndforkRepositoriesAsync(CreateProjectAndforkRepositoriesRequest createProjectAndforkRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/repositories/fork", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProjectAndforkRepositoriesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateProjectAndforkRepositoriesResponse>(response);
        }

        public AsyncInvoker<CreateProjectAndforkRepositoriesResponse> CreateProjectAndforkRepositoriesAsyncInvoker(CreateProjectAndforkRepositoriesRequest createProjectAndforkRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/repositories/fork", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProjectAndforkRepositoriesRequest);
            return new AsyncInvoker<CreateProjectAndforkRepositoriesResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateProjectAndforkRepositoriesResponse>);
        }
        
        /// <summary>
        /// 查询用户的所有仓库
        ///
        /// 获取用户的所有仓库信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListUserAllRepositoriesResponse> ListUserAllRepositoriesAsync(ListUserAllRepositoriesRequest listUserAllRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserAllRepositoriesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListUserAllRepositoriesResponse>(response);
        }

        public AsyncInvoker<ListUserAllRepositoriesResponse> ListUserAllRepositoriesAsyncInvoker(ListUserAllRepositoriesRequest listUserAllRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserAllRepositoriesRequest);
            return new AsyncInvoker<ListUserAllRepositoriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUserAllRepositoriesResponse>);
        }
        
        /// <summary>
        /// 查询项目下的所有仓库
        ///
        /// 获取仓库列表,模糊查询支持范围,如果未传入project uuid，则支持按仓库名或项目名模糊查询，否则，只按仓库名模糊匹配
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAllRepositoryByTwoProjectIdResponse> ShowAllRepositoryByTwoProjectIdAsync(ShowAllRepositoryByTwoProjectIdRequest showAllRepositoryByTwoProjectIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAllRepositoryByTwoProjectIdRequest.ProjectUuid, out var valueOfProjectUuid)) urlParam.Add("project_uuid", valueOfProjectUuid);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{project_uuid}/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAllRepositoryByTwoProjectIdRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAllRepositoryByTwoProjectIdResponse>(response);
        }

        public AsyncInvoker<ShowAllRepositoryByTwoProjectIdResponse> ShowAllRepositoryByTwoProjectIdAsyncInvoker(ShowAllRepositoryByTwoProjectIdRequest showAllRepositoryByTwoProjectIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAllRepositoryByTwoProjectIdRequest.ProjectUuid, out var valueOfProjectUuid)) urlParam.Add("project_uuid", valueOfProjectUuid);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{project_uuid}/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAllRepositoryByTwoProjectIdRequest);
            return new AsyncInvoker<ShowAllRepositoryByTwoProjectIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAllRepositoryByTwoProjectIdResponse>);
        }
        
        /// <summary>
        /// 为指定仓库添加hook
        ///
        /// 提交代码自动触发编译构建，添加仓库钩子
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddHooksResponse> AddHooksAsync(AddHooksRequest addHooksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addHooksRequest.GroupName, out var valueOfGroupName)) urlParam.Add("group_name", valueOfGroupName);
            if (StringUtils.TryConvertToNonEmptyString(addHooksRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{group_name}/{repository_name}/hooks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addHooksRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddHooksResponse>(response);
        }

        public AsyncInvoker<AddHooksResponse> AddHooksAsyncInvoker(AddHooksRequest addHooksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addHooksRequest.GroupName, out var valueOfGroupName)) urlParam.Add("group_name", valueOfGroupName);
            if (StringUtils.TryConvertToNonEmptyString(addHooksRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{group_name}/{repository_name}/hooks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addHooksRequest);
            return new AsyncInvoker<AddHooksResponse>(this, "POST", request, JsonUtils.DeSerialize<AddHooksResponse>);
        }
        
        /// <summary>
        /// 删除指定仓库的 hook
        ///
        /// 提交代码自动触发编译构建，删除仓库钩子
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteHooksResponse> DeleteHooksAsync(DeleteHooksRequest deleteHooksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteHooksRequest.GroupName, out var valueOfGroupName)) urlParam.Add("group_name", valueOfGroupName);
            if (StringUtils.TryConvertToNonEmptyString(deleteHooksRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            if (StringUtils.TryConvertToNonEmptyString(deleteHooksRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{group_name}/{repository_name}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHooksRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteHooksResponse>(response);
        }

        public AsyncInvoker<DeleteHooksResponse> DeleteHooksAsyncInvoker(DeleteHooksRequest deleteHooksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteHooksRequest.GroupName, out var valueOfGroupName)) urlParam.Add("group_name", valueOfGroupName);
            if (StringUtils.TryConvertToNonEmptyString(deleteHooksRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            if (StringUtils.TryConvertToNonEmptyString(deleteHooksRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{group_name}/{repository_name}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHooksRequest);
            return new AsyncInvoker<DeleteHooksResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteHooksResponse>);
        }
        
        /// <summary>
        /// 查询指定仓库的webhook
        ///
        /// 获取仓库webhook
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListHooksResponse> ListHooksAsync(ListHooksRequest listHooksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listHooksRequest.GroupName, out var valueOfGroupName)) urlParam.Add("group_name", valueOfGroupName);
            if (StringUtils.TryConvertToNonEmptyString(listHooksRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{group_name}/{repository_name}/hooks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHooksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListHooksResponse>(response);
        }

        public AsyncInvoker<ListHooksResponse> ListHooksAsyncInvoker(ListHooksRequest listHooksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listHooksRequest.GroupName, out var valueOfGroupName)) urlParam.Add("group_name", valueOfGroupName);
            if (StringUtils.TryConvertToNonEmptyString(listHooksRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{group_name}/{repository_name}/hooks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHooksRequest);
            return new AsyncInvoker<ListHooksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHooksResponse>);
        }
        
    }
}