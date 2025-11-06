using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.CodeArtsRepo.V3.Model;

namespace HuaweiCloud.SDK.CodeArtsRepo.V3
{
    public partial class CodeArtsRepoClient : Client
    {
        public static ClientBuilder<CodeArtsRepoClient> NewBuilder()
        {
            return new ClientBuilder<CodeArtsRepoClient>();
        }

        
        /// <summary>
        /// 创建提交
        ///
        /// 能够一次提交位于不同目录的多个文件，目录不存在时，能自动创建目录。支持强制覆盖选项，当选择强制覆盖标志为true时，忽略冲突，强制提交。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateCommitResponse CreateCommit(CreateCommitRequest createCommitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createCommitRequest.RepoId, out var valueOfRepoId)) urlParam.Add("repo_id", valueOfRepoId);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{repo_id}/repository/commits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCommitRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateCommitResponse>(response);
        }

        public SyncInvoker<CreateCommitResponse> CreateCommitInvoker(CreateCommitRequest createCommitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createCommitRequest.RepoId, out var valueOfRepoId)) urlParam.Add("repo_id", valueOfRepoId);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{repo_id}/repository/commits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCommitRequest);
            return new SyncInvoker<CreateCommitResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCommitResponse>);
        }
        
        /// <summary>
        /// 查询某个仓库的提交信息
        ///
        /// 根据仓库短ID获取提交信息，支持根据文件路径，查询这个路径下所有的commits列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCommitsResponse ListCommits(ListCommitsRequest listCommitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listCommitsRequest.RepoId, out var valueOfRepoId)) urlParam.Add("repo_id", valueOfRepoId);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{repo_id}/repository/commits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCommitsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCommitsResponse>(response);
        }

        public SyncInvoker<ListCommitsResponse> ListCommitsInvoker(ListCommitsRequest listCommitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listCommitsRequest.RepoId, out var valueOfRepoId)) urlParam.Add("repo_id", valueOfRepoId);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{repo_id}/repository/commits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCommitsRequest);
            return new SyncInvoker<ListCommitsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCommitsResponse>);
        }
        
        /// <summary>
        /// 查询某个仓库的提交差异信息
        ///
        /// 根据commit id查询提交差异信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDiffCommitResponse ShowDiffCommit(ShowDiffCommitRequest showDiffCommitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDiffCommitRequest.RepoId, out var valueOfRepoId)) urlParam.Add("repo_id", valueOfRepoId);
            if (StringUtils.TryConvertToNonEmptyString(showDiffCommitRequest.Sha, out var valueOfSha)) urlParam.Add("sha", valueOfSha);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{repo_id}/repository/commits/{sha}/diff", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDiffCommitRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDiffCommitResponse>(response);
        }

        public SyncInvoker<ShowDiffCommitResponse> ShowDiffCommitInvoker(ShowDiffCommitRequest showDiffCommitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDiffCommitRequest.RepoId, out var valueOfRepoId)) urlParam.Add("repo_id", valueOfRepoId);
            if (StringUtils.TryConvertToNonEmptyString(showDiffCommitRequest.Sha, out var valueOfSha)) urlParam.Add("sha", valueOfSha);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{repo_id}/repository/commits/{sha}/diff", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDiffCommitRequest);
            return new SyncInvoker<ShowDiffCommitResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDiffCommitResponse>);
        }
        
        /// <summary>
        /// 查询某个仓库的特定提交信息
        ///
        /// 获取由commit id或分支或标记的名称标识的特定提交。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSingleCommitResponse ShowSingleCommit(ShowSingleCommitRequest showSingleCommitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSingleCommitRequest.RepoId, out var valueOfRepoId)) urlParam.Add("repo_id", valueOfRepoId);
            if (StringUtils.TryConvertToNonEmptyString(showSingleCommitRequest.Sha, out var valueOfSha)) urlParam.Add("sha", valueOfSha);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{repo_id}/repository/commits/{sha}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSingleCommitRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSingleCommitResponse>(response);
        }

        public SyncInvoker<ShowSingleCommitResponse> ShowSingleCommitInvoker(ShowSingleCommitRequest showSingleCommitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showSingleCommitRequest.RepoId, out var valueOfRepoId)) urlParam.Add("repo_id", valueOfRepoId);
            if (StringUtils.TryConvertToNonEmptyString(showSingleCommitRequest.Sha, out var valueOfSha)) urlParam.Add("sha", valueOfSha);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{repo_id}/repository/commits/{sha}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSingleCommitRequest);
            return new SyncInvoker<ShowSingleCommitResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSingleCommitResponse>);
        }
        
        /// <summary>
        /// 创建MR检视意见
        ///
        /// 创建MR检视意见
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateMergeRequestDiscussionResponse CreateMergeRequestDiscussion(CreateMergeRequestDiscussionRequest createMergeRequestDiscussionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/merge_requests/{merge_request_iid}/discussions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMergeRequestDiscussionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateMergeRequestDiscussionResponse>(response);
        }

        public SyncInvoker<CreateMergeRequestDiscussionResponse> CreateMergeRequestDiscussionInvoker(CreateMergeRequestDiscussionRequest createMergeRequestDiscussionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/merge_requests/{merge_request_iid}/discussions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMergeRequestDiscussionRequest);
            return new SyncInvoker<CreateMergeRequestDiscussionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMergeRequestDiscussionResponse>);
        }
        
        /// <summary>
        /// 回复MR检视意见
        ///
        /// 回复MR检视意见
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateMergeRequestDiscussionNoteResponse CreateMergeRequestDiscussionNote(CreateMergeRequestDiscussionNoteRequest createMergeRequestDiscussionNoteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionNoteRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionNoteRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionNoteRequest.DiscussionId, out var valueOfDiscussionId)) urlParam.Add("discussion_id", valueOfDiscussionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/merge_requests/{merge_request_iid}/discussions/{discussion_id}/notes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMergeRequestDiscussionNoteRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateMergeRequestDiscussionNoteResponse>(response);
        }

        public SyncInvoker<CreateMergeRequestDiscussionNoteResponse> CreateMergeRequestDiscussionNoteInvoker(CreateMergeRequestDiscussionNoteRequest createMergeRequestDiscussionNoteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionNoteRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionNoteRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionNoteRequest.DiscussionId, out var valueOfDiscussionId)) urlParam.Add("discussion_id", valueOfDiscussionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/merge_requests/{merge_request_iid}/discussions/{discussion_id}/notes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMergeRequestDiscussionNoteRequest);
            return new SyncInvoker<CreateMergeRequestDiscussionNoteResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMergeRequestDiscussionNoteResponse>);
        }
        
        /// <summary>
        /// 获取检视意见设置
        ///
        /// 获取检视意见设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowReviewSettingResponse ShowReviewSetting(ShowReviewSettingRequest showReviewSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showReviewSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/review_setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReviewSettingRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowReviewSettingResponse>(response);
        }

        public SyncInvoker<ShowReviewSettingResponse> ShowReviewSettingInvoker(ShowReviewSettingRequest showReviewSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showReviewSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/review_setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReviewSettingRequest);
            return new SyncInvoker<ShowReviewSettingResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowReviewSettingResponse>);
        }
        
        /// <summary>
        /// 查询某个仓库的文件信息
        ///
        /// 获取仓库中文件的信息，如名称、大小、内容。请注意，文件内容是Base64编码的。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFilesByQueryResponse ListFilesByQuery(ListFilesByQueryRequest listFilesByQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFilesByQueryRequest.RepoId, out var valueOfRepoId)) urlParam.Add("repo_id", valueOfRepoId);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{repo_id}/repository/files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFilesByQueryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFilesByQueryResponse>(response);
        }

        public SyncInvoker<ListFilesByQueryResponse> ListFilesByQueryInvoker(ListFilesByQueryRequest listFilesByQueryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFilesByQueryRequest.RepoId, out var valueOfRepoId)) urlParam.Add("repo_id", valueOfRepoId);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{repo_id}/repository/files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFilesByQueryRequest);
            return new SyncInvoker<ListFilesByQueryResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFilesByQueryResponse>);
        }
        
        /// <summary>
        /// 查询某个仓库的文件信息
        ///
        /// 获取仓库中文件的信息，如名称、大小、内容。请注意，文件内容是Base64编码的。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public ShowFileResponse ShowFile(ShowFileRequest showFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFileRequest.RepoId, out var valueOfRepoId)) urlParam.Add("repo_id", valueOfRepoId);
            if (StringUtils.TryConvertToNonEmptyString(showFileRequest.FilePath, out var valueOfFilePath)) urlParam.Add("file_path", valueOfFilePath);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{repo_id}/repository/files/{file_path}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFileRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowFileResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<ShowFileResponse> ShowFileInvoker(ShowFileRequest showFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFileRequest.RepoId, out var valueOfRepoId)) urlParam.Add("repo_id", valueOfRepoId);
            if (StringUtils.TryConvertToNonEmptyString(showFileRequest.FilePath, out var valueOfFilePath)) urlParam.Add("file_path", valueOfFilePath);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{repo_id}/repository/files/{file_path}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFileRequest);
            return new SyncInvoker<ShowFileResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFileResponse>);
        }
        
        /// <summary>
        /// 获取项目下所有仓库信息
        ///
        /// 获取仓库列表 模糊查询支持范围,如果未传入project_id，则支持按仓库名或项目名模糊查询，否则，只按仓库名模糊匹配。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public GetAllRepositoryByProjectIdResponse GetAllRepositoryByProjectId(GetAllRepositoryByProjectIdRequest getAllRepositoryByProjectIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getAllRepositoryByProjectIdRequest.ProjectUuid, out var valueOfProjectUuid)) urlParam.Add("project_uuid", valueOfProjectUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_uuid}/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getAllRepositoryByProjectIdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<GetAllRepositoryByProjectIdResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<GetAllRepositoryByProjectIdResponse> GetAllRepositoryByProjectIdInvoker(GetAllRepositoryByProjectIdRequest getAllRepositoryByProjectIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getAllRepositoryByProjectIdRequest.ProjectUuid, out var valueOfProjectUuid)) urlParam.Add("project_uuid", valueOfProjectUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_uuid}/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getAllRepositoryByProjectIdRequest);
            return new SyncInvoker<GetAllRepositoryByProjectIdResponse>(this, "GET", request, JsonUtils.DeSerialize<GetAllRepositoryByProjectIdResponse>);
        }
        
        /// <summary>
        /// 获取一个项目下可以设置为公开状态的仓库列表
        ///
        /// 获取一个项目下可以设置为公开状态的仓库列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public GetProductTemplatesResponse GetProductTemplates(GetProductTemplatesRequest getProductTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getProductTemplatesRequest.ProjectUuid, out var valueOfProjectUuid)) urlParam.Add("project_uuid", valueOfProjectUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_uuid}/repositories/template_status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getProductTemplatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<GetProductTemplatesResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<GetProductTemplatesResponse> GetProductTemplatesInvoker(GetProductTemplatesRequest getProductTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getProductTemplatesRequest.ProjectUuid, out var valueOfProjectUuid)) urlParam.Add("project_uuid", valueOfProjectUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_uuid}/repositories/template_status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getProductTemplatesRequest);
            return new SyncInvoker<GetProductTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<GetProductTemplatesResponse>);
        }
        
        /// <summary>
        /// 获取一个项目下可以设置为公开状态的仓库列表
        ///
        /// 获取一个项目下可以设置为公开状态的仓库列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProductTwoTemplatesResponse ListProductTwoTemplates(ListProductTwoTemplatesRequest listProductTwoTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProductTwoTemplatesRequest.ProjectUuid, out var valueOfProjectUuid)) urlParam.Add("project_uuid", valueOfProjectUuid);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{project_uuid}/repositories/template-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProductTwoTemplatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListProductTwoTemplatesResponse>(response);
        }

        public SyncInvoker<ListProductTwoTemplatesResponse> ListProductTwoTemplatesInvoker(ListProductTwoTemplatesRequest listProductTwoTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProductTwoTemplatesRequest.ProjectUuid, out var valueOfProjectUuid)) urlParam.Add("project_uuid", valueOfProjectUuid);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{project_uuid}/repositories/template-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProductTwoTemplatesRequest);
            return new SyncInvoker<ListProductTwoTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProductTwoTemplatesResponse>);
        }
        
        /// <summary>
        /// 校验指定项目下的仓库名
        ///
        /// 一般创建仓库时调用。通过传入项目ID，获取方式请参见[获取项目ID](codehub_api_0014.xml)。,仓库名，来判断仓库是否重名。仓库存在result:false,仓库不存在result:true。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRepositoryNameExistResponse ShowRepositoryNameExist(ShowRepositoryNameExistRequest showRepositoryNameExistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryNameExistRequest.ProjectUuid, out var valueOfProjectUuid)) urlParam.Add("project_uuid", valueOfProjectUuid);
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryNameExistRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_uuid}/repositories/validation/{repository_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryNameExistRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRepositoryNameExistResponse>(response);
        }

        public SyncInvoker<ShowRepositoryNameExistResponse> ShowRepositoryNameExistInvoker(ShowRepositoryNameExistRequest showRepositoryNameExistRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryNameExistRequest.ProjectUuid, out var valueOfProjectUuid)) urlParam.Add("project_uuid", valueOfProjectUuid);
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryNameExistRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v1/projects/{project_uuid}/repositories/validation/{repository_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryNameExistRequest);
            return new SyncInvoker<ShowRepositoryNameExistResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepositoryNameExistResponse>);
        }
        
        /// <summary>
        /// 添加仓库成员
        ///
        /// 添加仓库成员。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddRepoMembersResponse AddRepoMembers(AddRepoMembersRequest addRepoMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addRepoMembersRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addRepoMembersRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddRepoMembersResponse>(response);
        }

        public SyncInvoker<AddRepoMembersResponse> AddRepoMembersInvoker(AddRepoMembersRequest addRepoMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addRepoMembersRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addRepoMembersRequest);
            return new SyncInvoker<AddRepoMembersResponse>(this, "POST", request, JsonUtils.DeSerialize<AddRepoMembersResponse>);
        }
        
        /// <summary>
        /// 删除仓库成员
        ///
        /// 删除仓库成员
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteRepoMemberResponse DeleteRepoMember(DeleteRepoMemberRequest deleteRepoMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoMemberRequest.MemberId, out var valueOfMemberId)) urlParam.Add("member_id", valueOfMemberId);
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoMemberRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepoMemberRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteRepoMemberResponse>(response);
        }

        public SyncInvoker<DeleteRepoMemberResponse> DeleteRepoMemberInvoker(DeleteRepoMemberRequest deleteRepoMemberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoMemberRequest.MemberId, out var valueOfMemberId)) urlParam.Add("member_id", valueOfMemberId);
            if (StringUtils.TryConvertToNonEmptyString(deleteRepoMemberRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepoMemberRequest);
            return new SyncInvoker<DeleteRepoMemberResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteRepoMemberResponse>);
        }
        
        /// <summary>
        /// 获取仓库所有成员记录
        ///
        /// 获取仓库成员列表,可通过关键字搜索某成员。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRepoMembersResponse ListRepoMembers(ListRepoMembersRequest listRepoMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepoMembersRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepoMembersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRepoMembersResponse>(response);
        }

        public SyncInvoker<ListRepoMembersResponse> ListRepoMembersInvoker(ListRepoMembersRequest listRepoMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepoMembersRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepoMembersRequest);
            return new SyncInvoker<ListRepoMembersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRepoMembersResponse>);
        }
        
        /// <summary>
        /// 设置成员在仓库中的角色
        ///
        /// 给仓库中成员设置仓库的操作权限，
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetRepoRoleResponse SetRepoRole(SetRepoRoleRequest setRepoRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setRepoRoleRequest.MemberId, out var valueOfMemberId)) urlParam.Add("member_id", valueOfMemberId);
            if (StringUtils.TryConvertToNonEmptyString(setRepoRoleRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRepoRoleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<SetRepoRoleResponse>(response);
        }

        public SyncInvoker<SetRepoRoleResponse> SetRepoRoleInvoker(SetRepoRoleRequest setRepoRoleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setRepoRoleRequest.MemberId, out var valueOfMemberId)) urlParam.Add("member_id", valueOfMemberId);
            if (StringUtils.TryConvertToNonEmptyString(setRepoRoleRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/members/{member_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setRepoRoleRequest);
            return new SyncInvoker<SetRepoRoleResponse>(this, "PUT", request, JsonUtils.DeSerialize<SetRepoRoleResponse>);
        }
        
        /// <summary>
        /// 添加部署密钥
        ///
        /// 添加部署密钥
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AddDeployKeyResponse AddDeployKey(AddDeployKeyRequest addDeployKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addDeployKeyRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_id}/deploy_keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDeployKeyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddDeployKeyResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<AddDeployKeyResponse> AddDeployKeyInvoker(AddDeployKeyRequest addDeployKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addDeployKeyRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_id}/deploy_keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDeployKeyRequest);
            return new SyncInvoker<AddDeployKeyResponse>(this, "POST", request, JsonUtils.DeSerialize<AddDeployKeyResponse>);
        }
        
        /// <summary>
        /// 添加部署密钥
        ///
        /// 添加部署密钥
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddDeployKeyV2Response AddDeployKeyV2(AddDeployKeyV2Request addDeployKeyV2Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addDeployKeyV2Request.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/deploy-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDeployKeyV2Request);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddDeployKeyV2Response>(response);
        }

        public SyncInvoker<AddDeployKeyV2Response> AddDeployKeyV2Invoker(AddDeployKeyV2Request addDeployKeyV2Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addDeployKeyV2Request.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/deploy-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addDeployKeyV2Request);
            return new SyncInvoker<AddDeployKeyV2Response>(this, "POST", request, JsonUtils.DeSerialize<AddDeployKeyV2Response>);
        }
        
        /// <summary>
        /// 新建保护分支
        ///
        /// 新建保护分支
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddProtectBranchV2Response AddProtectBranchV2(AddProtectBranchV2Request addProtectBranchV2Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addProtectBranchV2Request.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(addProtectBranchV2Request.BranchName, out var valueOfBranchName)) urlParam.Add("branch_name", valueOfBranchName);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/branch/{branch_name}/protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addProtectBranchV2Request);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<AddProtectBranchV2Response>(response);
        }

        public SyncInvoker<AddProtectBranchV2Response> AddProtectBranchV2Invoker(AddProtectBranchV2Request addProtectBranchV2Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addProtectBranchV2Request.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(addProtectBranchV2Request.BranchName, out var valueOfBranchName)) urlParam.Add("branch_name", valueOfBranchName);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/branch/{branch_name}/protect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addProtectBranchV2Request);
            return new SyncInvoker<AddProtectBranchV2Response>(this, "PUT", request, JsonUtils.DeSerialize<AddProtectBranchV2Response>);
        }
        
        /// <summary>
        /// 新建标签
        ///
        /// 新建标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddTagV2Response AddTagV2(AddTagV2Request addTagV2Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addTagV2Request.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addTagV2Request);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddTagV2Response>(response);
        }

        public SyncInvoker<AddTagV2Response> AddTagV2Invoker(AddTagV2Request addTagV2Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addTagV2Request.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addTagV2Request);
            return new SyncInvoker<AddTagV2Response>(this, "POST", request, JsonUtils.DeSerialize<AddTagV2Response>);
        }
        
        /// <summary>
        /// 创建仓库
        ///
        /// 用指定的名称在指定项目上创建仓库。传入参数：仓库名、模板id、是否导入项目成员、归属项目
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRepositoryResponse CreateRepository(CreateRepositoryRequest createRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepositoryRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateRepositoryResponse>(response);
        }

        public SyncInvoker<CreateRepositoryResponse> CreateRepositoryInvoker(CreateRepositoryRequest createRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepositoryRequest);
            return new SyncInvoker<CreateRepositoryResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRepositoryResponse>);
        }
        
        /// <summary>
        /// 删除仓库部署密钥
        ///
        /// 删除仓库部署密钥
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public DeleteDeployKeyResponse DeleteDeployKey(DeleteDeployKeyRequest deleteDeployKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDeployKeyRequest.KeyId, out var valueOfKeyId)) urlParam.Add("key_id", valueOfKeyId);
            if (StringUtils.TryConvertToNonEmptyString(deleteDeployKeyRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_id}/deploy_keys/{key_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeployKeyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDeployKeyResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<DeleteDeployKeyResponse> DeleteDeployKeyInvoker(DeleteDeployKeyRequest deleteDeployKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDeployKeyRequest.KeyId, out var valueOfKeyId)) urlParam.Add("key_id", valueOfKeyId);
            if (StringUtils.TryConvertToNonEmptyString(deleteDeployKeyRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_id}/deploy_keys/{key_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeployKeyRequest);
            return new SyncInvoker<DeleteDeployKeyResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDeployKeyResponse>);
        }
        
        /// <summary>
        /// 删除仓库部署密钥
        ///
        /// 删除仓库部署密钥
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDeployKeyV2Response DeleteDeployKeyV2(DeleteDeployKeyV2Request deleteDeployKeyV2Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDeployKeyV2Request.KeyId, out var valueOfKeyId)) urlParam.Add("key_id", valueOfKeyId);
            if (StringUtils.TryConvertToNonEmptyString(deleteDeployKeyV2Request.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/deploy-keys/{key_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeployKeyV2Request);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDeployKeyV2Response>(response);
        }

        public SyncInvoker<DeleteDeployKeyV2Response> DeleteDeployKeyV2Invoker(DeleteDeployKeyV2Request deleteDeployKeyV2Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDeployKeyV2Request.KeyId, out var valueOfKeyId)) urlParam.Add("key_id", valueOfKeyId);
            if (StringUtils.TryConvertToNonEmptyString(deleteDeployKeyV2Request.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/deploy-keys/{key_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDeployKeyV2Request);
            return new SyncInvoker<DeleteDeployKeyV2Response>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDeployKeyV2Response>);
        }
        
        /// <summary>
        /// 删除仓库
        ///
        /// 根据仓库32位uuid删除指定的仓库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteRepositoryResponse DeleteRepository(DeleteRepositoryRequest deleteRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRepositoryRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepositoryRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteRepositoryResponse>(response);
        }

        public SyncInvoker<DeleteRepositoryResponse> DeleteRepositoryInvoker(DeleteRepositoryRequest deleteRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRepositoryRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepositoryRequest);
            return new SyncInvoker<DeleteRepositoryResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteRepositoryResponse>);
        }
        
        /// <summary>
        /// 查询项目下的某个仓库
        ///
        /// 不建议再使用,建议使用/{repository_uuid}/status
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public GetRepositoryByProjectIdResponse GetRepositoryByProjectId(GetRepositoryByProjectIdRequest getRepositoryByProjectIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getRepositoryByProjectIdRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getRepositoryByProjectIdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<GetRepositoryByProjectIdResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<GetRepositoryByProjectIdResponse> GetRepositoryByProjectIdInvoker(GetRepositoryByProjectIdRequest getRepositoryByProjectIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(getRepositoryByProjectIdRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getRepositoryByProjectIdRequest);
            return new SyncInvoker<GetRepositoryByProjectIdResponse>(this, "GET", request, JsonUtils.DeSerialize<GetRepositoryByProjectIdResponse>);
        }
        
        /// <summary>
        /// 获取公开示例模板列表
        ///
        /// 获取公开示例模板列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public GetTemplatesResponse GetTemplates(GetTemplatesRequest getTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/repository_templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getTemplatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<GetTemplatesResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<GetTemplatesResponse> GetTemplatesInvoker(GetTemplatesRequest getTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/repository_templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", getTemplatesRequest);
            return new SyncInvoker<GetTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<GetTemplatesResponse>);
        }
        
        /// <summary>
        /// 获取仓库分支列表
        ///
        /// 获取仓库分支列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBranchesByRepositoryIdResponse ListBranchesByRepositoryId(ListBranchesByRepositoryIdRequest listBranchesByRepositoryIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBranchesByRepositoryIdRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBranchesByRepositoryIdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBranchesByRepositoryIdResponse>(response);
        }

        public SyncInvoker<ListBranchesByRepositoryIdResponse> ListBranchesByRepositoryIdInvoker(ListBranchesByRepositoryIdRequest listBranchesByRepositoryIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBranchesByRepositoryIdRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBranchesByRepositoryIdRequest);
            return new SyncInvoker<ListBranchesByRepositoryIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBranchesByRepositoryIdResponse>);
        }
        
        /// <summary>
        /// 获取仓库上一次的提交统计信息
        ///
        /// 获取仓库上一次的提交统计信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCommitStatisticsResponse ListCommitStatistics(ListCommitStatisticsRequest listCommitStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listCommitStatisticsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_id}/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCommitStatisticsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCommitStatisticsResponse>(response);
        }

        public SyncInvoker<ListCommitStatisticsResponse> ListCommitStatisticsInvoker(ListCommitStatisticsRequest listCommitStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listCommitStatisticsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_id}/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCommitStatisticsRequest);
            return new SyncInvoker<ListCommitStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCommitStatisticsResponse>);
        }
        
        /// <summary>
        /// 获取一个仓库下特定分支指定文件内容
        ///
        /// 获取一个仓库下特定分支指定文件内容
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFilesResponse ListFiles(ListFilesRequest listFilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFilesRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            if (StringUtils.TryConvertToNonEmptyString(listFilesRequest.BranchName, out var valueOfBranchName)) urlParam.Add("branch_name", valueOfBranchName);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/branch/{branch_name}/file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFilesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFilesResponse>(response);
        }

        public SyncInvoker<ListFilesResponse> ListFilesInvoker(ListFilesRequest listFilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFilesRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            if (StringUtils.TryConvertToNonEmptyString(listFilesRequest.BranchName, out var valueOfBranchName)) urlParam.Add("branch_name", valueOfBranchName);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/branch/{branch_name}/file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFilesRequest);
            return new SyncInvoker<ListFilesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFilesResponse>);
        }
        
        /// <summary>
        /// 获取变更文件
        ///
        /// 获取变更文件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMergeChangesResponse ListMergeChanges(ListMergeChangesRequest listMergeChangesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeChangesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeChangesRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/merge-requests/{merge_request_iid}/changes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeChangesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMergeChangesResponse>(response);
        }

        public SyncInvoker<ListMergeChangesResponse> ListMergeChangesInvoker(ListMergeChangesRequest listMergeChangesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeChangesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeChangesRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/merge-requests/{merge_request_iid}/changes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeChangesRequest);
            return new SyncInvoker<ListMergeChangesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMergeChangesResponse>);
        }
        
        /// <summary>
        /// 获取变更文件列表
        ///
        /// 获取变更文件列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMergeChangesTreesResponse ListMergeChangesTrees(ListMergeChangesTreesRequest listMergeChangesTreesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeChangesTreesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeChangesTreesRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/merge-requests/{merge_request_iid}/changes-trees", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeChangesTreesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMergeChangesTreesResponse>(response);
        }

        public SyncInvoker<ListMergeChangesTreesResponse> ListMergeChangesTreesInvoker(ListMergeChangesTreesRequest listMergeChangesTreesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeChangesTreesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeChangesTreesRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/merge-requests/{merge_request_iid}/changes-trees", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeChangesTreesRequest);
            return new SyncInvoker<ListMergeChangesTreesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMergeChangesTreesResponse>);
        }
        
        /// <summary>
        /// 获取仓库合并请求列表
        ///
        /// 获取仓库合并请求列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMergeRequestResponse ListMergeRequest(ListMergeRequestRequest listMergeRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/merge_request", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMergeRequestResponse>(response);
        }

        public SyncInvoker<ListMergeRequestResponse> ListMergeRequestInvoker(ListMergeRequestRequest listMergeRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/merge_request", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestRequest);
            return new SyncInvoker<ListMergeRequestResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMergeRequestResponse>);
        }
        
        /// <summary>
        /// 根据仓库短ID和合并请求短ID获取检视人信息
        ///
        /// 根据仓库短ID和合并请求短ID获取检视人信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMergeRequestReviewersResponse ListMergeRequestReviewers(ListMergeRequestReviewersRequest listMergeRequestReviewersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestReviewersRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestReviewersRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/merge-requests/{merge_request_iid}/approval-reviewers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestReviewersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMergeRequestReviewersResponse>(response);
        }

        public SyncInvoker<ListMergeRequestReviewersResponse> ListMergeRequestReviewersInvoker(ListMergeRequestReviewersRequest listMergeRequestReviewersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestReviewersRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestReviewersRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/merge-requests/{merge_request_iid}/approval-reviewers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestReviewersRequest);
            return new SyncInvoker<ListMergeRequestReviewersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMergeRequestReviewersResponse>);
        }
        
        /// <summary>
        /// 获取关联工作项信息
        ///
        /// 获取关联工作项信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRelatedCommitsResponse ListRelatedCommits(ListRelatedCommitsRequest listRelatedCommitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRelatedCommitsRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_uuid}/related-commits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRelatedCommitsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRelatedCommitsResponse>(response);
        }

        public SyncInvoker<ListRelatedCommitsResponse> ListRelatedCommitsInvoker(ListRelatedCommitsRequest listRelatedCommitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRelatedCommitsRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_uuid}/related-commits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRelatedCommitsRequest);
            return new SyncInvoker<ListRelatedCommitsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRelatedCommitsResponse>);
        }
        
        /// <summary>
        /// 查看仓库的创建状态
        ///
        /// 获取仓库状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRepositoryStatusResponse ListRepositoryStatus(ListRepositoryStatusRequest listRepositoryStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryStatusRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRepositoryStatusResponse>(response);
        }

        public SyncInvoker<ListRepositoryStatusResponse> ListRepositoryStatusInvoker(ListRepositoryStatusRequest listRepositoryStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryStatusRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryStatusRequest);
            return new SyncInvoker<ListRepositoryStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRepositoryStatusResponse>);
        }
        
        /// <summary>
        /// 获取分支目录下的文件
        ///
        /// 获取分支目录下的文件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSubfilesResponse ListSubfiles(ListSubfilesRequest listSubfilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSubfilesRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            if (StringUtils.TryConvertToNonEmptyString(listSubfilesRequest.BranchName, out var valueOfBranchName)) urlParam.Add("branch_name", valueOfBranchName);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/branch/{branch_name}/sub-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubfilesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSubfilesResponse>(response);
        }

        public SyncInvoker<ListSubfilesResponse> ListSubfilesInvoker(ListSubfilesRequest listSubfilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSubfilesRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            if (StringUtils.TryConvertToNonEmptyString(listSubfilesRequest.BranchName, out var valueOfBranchName)) urlParam.Add("branch_name", valueOfBranchName);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/branch/{branch_name}/sub-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubfilesRequest);
            return new SyncInvoker<ListSubfilesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSubfilesResponse>);
        }
        
        /// <summary>
        /// 设置仓库是公开状态还是私有状态
        ///
        /// 设置仓库是公开状态还是私有状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTemplatesTwoResponse ListTemplatesTwo(ListTemplatesTwoRequest listTemplatesTwoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTemplatesTwoRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_uuid}/template-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplatesTwoRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ListTemplatesTwoResponse>(response);
        }

        public SyncInvoker<ListTemplatesTwoResponse> ListTemplatesTwoInvoker(ListTemplatesTwoRequest listTemplatesTwoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTemplatesTwoRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_uuid}/template-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplatesTwoRequest);
            return new SyncInvoker<ListTemplatesTwoResponse>(this, "PUT", request, JsonUtils.DeSerialize<ListTemplatesTwoResponse>);
        }
        
        /// <summary>
        /// 获取公开示例模板列表
        ///
        /// 获取公开示例模板列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTwoTemplatesResponse ListTwoTemplates(ListTwoTemplatesRequest listTwoTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/repository-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTwoTemplatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTwoTemplatesResponse>(response);
        }

        public SyncInvoker<ListTwoTemplatesResponse> ListTwoTemplatesInvoker(ListTwoTemplatesRequest listTwoTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/repository-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTwoTemplatesRequest);
            return new SyncInvoker<ListTwoTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTwoTemplatesResponse>);
        }
        
        /// <summary>
        /// 设置仓库是公开状态还是私有状态
        ///
        /// 设置仓库是公开状态还是私有状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public ShareTemplatesResponse ShareTemplates(ShareTemplatesRequest shareTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(shareTemplatesRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/template_status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", shareTemplatesRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ShareTemplatesResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<ShareTemplatesResponse> ShareTemplatesInvoker(ShareTemplatesRequest shareTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(shareTemplatesRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/template_status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", shareTemplatesRequest);
            return new SyncInvoker<ShareTemplatesResponse>(this, "PUT", request, JsonUtils.DeSerialize<ShareTemplatesResponse>);
        }
        
        /// <summary>
        /// 查询某仓库对应的分支
        ///
        /// 根据仓库id获取指定仓库的分支列表.
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBranchesByRepositoryIdResponse ShowBranchesByRepositoryId(ShowBranchesByRepositoryIdRequest showBranchesByRepositoryIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBranchesByRepositoryIdRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_id}/branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBranchesByRepositoryIdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBranchesByRepositoryIdResponse>(response);
        }

        public SyncInvoker<ShowBranchesByRepositoryIdResponse> ShowBranchesByRepositoryIdInvoker(ShowBranchesByRepositoryIdRequest showBranchesByRepositoryIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBranchesByRepositoryIdRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_id}/branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBranchesByRepositoryIdRequest);
            return new SyncInvoker<ShowBranchesByRepositoryIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBranchesByRepositoryIdResponse>);
        }
        
        /// <summary>
        /// 查询某仓库的标签列表
        ///
        /// 查询指定仓库对应的分支。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBranchesByTwoRepositoryIdResponse ShowBranchesByTwoRepositoryId(ShowBranchesByTwoRepositoryIdRequest showBranchesByTwoRepositoryIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBranchesByTwoRepositoryIdRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBranchesByTwoRepositoryIdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBranchesByTwoRepositoryIdResponse>(response);
        }

        public SyncInvoker<ShowBranchesByTwoRepositoryIdResponse> ShowBranchesByTwoRepositoryIdInvoker(ShowBranchesByTwoRepositoryIdRequest showBranchesByTwoRepositoryIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBranchesByTwoRepositoryIdRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBranchesByTwoRepositoryIdRequest);
            return new SyncInvoker<ShowBranchesByTwoRepositoryIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBranchesByTwoRepositoryIdResponse>);
        }
        
        /// <summary>
        /// 根据组名和仓库名查询某仓库某分支对应的提交
        ///
        /// 根据仓库组名、仓库名和分支获取提交列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowCommitsByBranchResponse ShowCommitsByBranch(ShowCommitsByBranchRequest showCommitsByBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCommitsByBranchRequest.GroupName, out var valueOfGroupName)) urlParam.Add("group_name", valueOfGroupName);
            if (StringUtils.TryConvertToNonEmptyString(showCommitsByBranchRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{group_name}/{repository_name}/commits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCommitsByBranchRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowCommitsByBranchResponse>(response);
        }

        public SyncInvoker<ShowCommitsByBranchResponse> ShowCommitsByBranchInvoker(ShowCommitsByBranchRequest showCommitsByBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCommitsByBranchRequest.GroupName, out var valueOfGroupName)) urlParam.Add("group_name", valueOfGroupName);
            if (StringUtils.TryConvertToNonEmptyString(showCommitsByBranchRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{group_name}/{repository_name}/commits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCommitsByBranchRequest);
            return new SyncInvoker<ShowCommitsByBranchResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCommitsByBranchResponse>);
        }
        
        /// <summary>
        /// 根据仓库id查询仓库某分支对应的提交，提供更多可选参数
        ///
        /// 根据仓库id查询仓库某分支对应的提交.
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowCommitsByRepoIdResponse ShowCommitsByRepoId(ShowCommitsByRepoIdRequest showCommitsByRepoIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCommitsByRepoIdRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_id}/commits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCommitsByRepoIdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowCommitsByRepoIdResponse>(response);
        }

        public SyncInvoker<ShowCommitsByRepoIdResponse> ShowCommitsByRepoIdInvoker(ShowCommitsByRepoIdRequest showCommitsByRepoIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCommitsByRepoIdRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_id}/commits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCommitsByRepoIdRequest);
            return new SyncInvoker<ShowCommitsByRepoIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCommitsByRepoIdResponse>);
        }
        
        /// <summary>
        /// 修改被流水线引用的仓库状态
        ///
        /// 修改被流水线引用的仓库状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowHasPipelineResponse ShowHasPipeline(ShowHasPipelineRequest showHasPipelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showHasPipelineRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/pipeline", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHasPipelineRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ShowHasPipelineResponse>(response);
        }

        public SyncInvoker<ShowHasPipelineResponse> ShowHasPipelineInvoker(ShowHasPipelineRequest showHasPipelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showHasPipelineRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/pipeline", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHasPipelineRequest);
            return new SyncInvoker<ShowHasPipelineResponse>(this, "PUT", request, JsonUtils.DeSerialize<ShowHasPipelineResponse>);
        }
        
        /// <summary>
        /// 获取一个仓库下特定分支的图片文件
        ///
        /// 获取一个仓库下特定分支的图片文件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowImageBlobResponse ShowImageBlob(ShowImageBlobRequest showImageBlobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showImageBlobRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            if (StringUtils.TryConvertToNonEmptyString(showImageBlobRequest.BranchName, out var valueOfBranchName)) urlParam.Add("branch_name", valueOfBranchName);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/branch/{branch_name}/image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showImageBlobRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerializeNull<ShowImageBlobResponse>(response);
        }

        public SyncInvoker<ShowImageBlobResponse> ShowImageBlobInvoker(ShowImageBlobRequest showImageBlobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showImageBlobRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            if (StringUtils.TryConvertToNonEmptyString(showImageBlobRequest.BranchName, out var valueOfBranchName)) urlParam.Add("branch_name", valueOfBranchName);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/branch/{branch_name}/image", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showImageBlobRequest);
            return new SyncInvoker<ShowImageBlobResponse>(this, "GET", request, JsonUtils.DeSerializeNull<ShowImageBlobResponse>);
        }
        
        /// <summary>
        /// 判断用户是否有仓库的管理员权限
        ///
        /// 判断用户是否有仓库的管理员权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMasterResponse ShowMaster(ShowMasterRequest showMasterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMasterRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/master", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMasterRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMasterResponse>(response);
        }

        public SyncInvoker<ShowMasterResponse> ShowMasterInvoker(ShowMasterRequest showMasterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMasterRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/master", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMasterRequest);
            return new SyncInvoker<ShowMasterResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMasterResponse>);
        }
        
        /// <summary>
        /// 获取仓库合并请求详情
        ///
        /// 获取仓库合并请求详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMergeRequestResponse ShowMergeRequest(ShowMergeRequestRequest showMergeRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestRequest.MergeRequestId, out var valueOfMergeRequestId)) urlParam.Add("merge_request_id", valueOfMergeRequestId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/merge_request/{merge_request_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMergeRequestRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMergeRequestResponse>(response);
        }

        public SyncInvoker<ShowMergeRequestResponse> ShowMergeRequestInvoker(ShowMergeRequestRequest showMergeRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestRequest.MergeRequestId, out var valueOfMergeRequestId)) urlParam.Add("merge_request_id", valueOfMergeRequestId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/merge_request/{merge_request_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMergeRequestRequest);
            return new SyncInvoker<ShowMergeRequestResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMergeRequestResponse>);
        }
        
        /// <summary>
        /// 根据仓库名组名获取仓库短id，用以拼接与commitid对应提交详情页面url
        ///
        /// 获取仓库短id,用于获取仓库详情页面url
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRepoIdResponse ShowRepoId(ShowRepoIdRequest showRepoIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/repoid", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepoIdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRepoIdResponse>(response);
        }

        public SyncInvoker<ShowRepoIdResponse> ShowRepoIdInvoker(ShowRepoIdRequest showRepoIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/repoid", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepoIdRequest);
            return new SyncInvoker<ShowRepoIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepoIdResponse>);
        }
        
        /// <summary>
        /// 下载仓库
        ///
        /// 按照指定格式下载仓库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRepositoryArchiveResponse ShowRepositoryArchive(ShowRepositoryArchiveRequest showRepositoryArchiveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryArchiveRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_uuid}/archive", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryArchiveRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRepositoryArchiveResponse>(response);
        }

        public SyncInvoker<ShowRepositoryArchiveResponse> ShowRepositoryArchiveInvoker(ShowRepositoryArchiveRequest showRepositoryArchiveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryArchiveRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_uuid}/archive", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryArchiveRequest);
            return new SyncInvoker<ShowRepositoryArchiveResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepositoryArchiveResponse>);
        }
        
        /// <summary>
        /// 查询某个仓库的详细信息
        ///
        /// 根据仓库UUID(由CreateRepository接口返回)获取仓库信息仓库信息。返回 包含id，name，组名，仓库访问URL。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRepositoryByUuidResponse ShowRepositoryByUuid(ShowRepositoryByUuidRequest showRepositoryByUuidRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryByUuidRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_uuid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryByUuidRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRepositoryByUuidResponse>(response);
        }

        public SyncInvoker<ShowRepositoryByUuidResponse> ShowRepositoryByUuidInvoker(ShowRepositoryByUuidRequest showRepositoryByUuidRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryByUuidRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_uuid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryByUuidRequest);
            return new SyncInvoker<ShowRepositoryByUuidResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepositoryByUuidResponse>);
        }
        
        /// <summary>
        /// 仓库统计
        ///
        /// 根据仓库短id，查询仓库的代码提交记录统计
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRepositoryStatisticsResponse ShowRepositoryStatistics(ShowRepositoryStatisticsRequest showRepositoryStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryStatisticsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_id}/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryStatisticsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowRepositoryStatisticsResponse>(response);
        }

        public SyncInvoker<ShowRepositoryStatisticsResponse> ShowRepositoryStatisticsInvoker(ShowRepositoryStatisticsRequest showRepositoryStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryStatisticsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_id}/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryStatisticsRequest);
            return new SyncInvoker<ShowRepositoryStatisticsResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowRepositoryStatisticsResponse>);
        }
        
        /// <summary>
        /// 获取代码提交行数
        ///
        /// 获取指定日期内代码仓指定分支的代码提交行数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public ShowStatisticCommitResponse ShowStatisticCommit(ShowStatisticCommitRequest showStatisticCommitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showStatisticCommitRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/commit_lines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatisticCommitRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowStatisticCommitResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<ShowStatisticCommitResponse> ShowStatisticCommitInvoker(ShowStatisticCommitRequest showStatisticCommitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showStatisticCommitRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/commit_lines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatisticCommitRequest);
            return new SyncInvoker<ShowStatisticCommitResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStatisticCommitResponse>);
        }
        
        /// <summary>
        /// 获取代码提交行数
        ///
        /// 获取指定日期内代码仓指定分支的代码提交行数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowStatisticCommitV3Response ShowStatisticCommitV3(ShowStatisticCommitV3Request showStatisticCommitV3Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showStatisticCommitV3Request.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v3/repositories/{repository_id}/commit-lines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatisticCommitV3Request);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowStatisticCommitV3Response>(response);
        }

        public SyncInvoker<ShowStatisticCommitV3Response> ShowStatisticCommitV3Invoker(ShowStatisticCommitV3Request showStatisticCommitV3Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showStatisticCommitV3Request.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v3/repositories/{repository_id}/commit-lines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatisticCommitV3Request);
            return new SyncInvoker<ShowStatisticCommitV3Response>(this, "GET", request, JsonUtils.DeSerialize<ShowStatisticCommitV3Response>);
        }
        
        /// <summary>
        /// 获取仓库统计数据
        ///
        /// 获取仓库统计数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowStatisticalDataResponse ShowStatisticalData(ShowStatisticalDataRequest showStatisticalDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showStatisticalDataRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/statistic-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatisticalDataRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowStatisticalDataResponse>(response);
        }

        public SyncInvoker<ShowStatisticalDataResponse> ShowStatisticalDataInvoker(ShowStatisticalDataRequest showStatisticalDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showStatisticalDataRequest.RepositoryUuid, out var valueOfRepositoryUuid)) urlParam.Add("repository_uuid", valueOfRepositoryUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{repository_uuid}/statistic-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatisticalDataRequest);
            return new SyncInvoker<ShowStatisticalDataResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStatisticalDataResponse>);
        }
        
        /// <summary>
        /// 合并请求代码审核
        ///
        /// 合并请求代码审核
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateMergeRequestApprovalStateResponse UpdateMergeRequestApprovalState(UpdateMergeRequestApprovalStateRequest updateMergeRequestApprovalStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestApprovalStateRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestApprovalStateRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/merge-requests/{merge_request_iid}/approval", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestApprovalStateRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateMergeRequestApprovalStateResponse>(response);
        }

        public SyncInvoker<UpdateMergeRequestApprovalStateResponse> UpdateMergeRequestApprovalStateInvoker(UpdateMergeRequestApprovalStateRequest updateMergeRequestApprovalStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestApprovalStateRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestApprovalStateRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/merge-requests/{merge_request_iid}/approval", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestApprovalStateRequest);
            return new SyncInvoker<UpdateMergeRequestApprovalStateResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateMergeRequestApprovalStateResponse>);
        }
        
        /// <summary>
        /// 添加ssh key
        ///
        /// 添加ssh key
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddSshKeyResponse AddSshKey(AddSshKeyRequest addSshKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/users/sshkey", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addSshKeyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddSshKeyResponse>(response);
        }

        public SyncInvoker<AddSshKeyResponse> AddSshKeyInvoker(AddSshKeyRequest addSshKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/users/sshkey", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addSshKeyRequest);
            return new SyncInvoker<AddSshKeyResponse>(this, "POST", request, JsonUtils.DeSerialize<AddSshKeyResponse>);
        }
        
        /// <summary>
        /// 删除用户公钥
        ///
        /// 删除用户公钥。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public DeleteSShkeyResponse DeleteSShkey(DeleteSShkeyRequest deleteSShkeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSShkeyRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/users/sshkey/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSShkeyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteSShkeyResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<DeleteSShkeyResponse> DeleteSShkeyInvoker(DeleteSShkeyRequest deleteSShkeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSShkeyRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/users/sshkey/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSShkeyRequest);
            return new SyncInvoker<DeleteSShkeyResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteSShkeyResponse>);
        }
        
        /// <summary>
        /// 获取ssh key列表
        ///
        /// 获取ssh key列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSshKeysResponse ListSshKeys(ListSshKeysRequest listSshKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/users/sshkey", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSshKeysRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSshKeysResponse>(response);
        }

        public SyncInvoker<ListSshKeysResponse> ListSshKeysInvoker(ListSshKeysRequest listSshKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/users/sshkey", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSshKeysRequest);
            return new SyncInvoker<ListSshKeysResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSshKeysResponse>);
        }
        
        /// <summary>
        /// 检验私钥是否有拉取代码的权限
        ///
        /// 检验私钥是否有拉取代码的权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPrivateKeyVerifyResponse ShowPrivateKeyVerify(ShowPrivateKeyVerifyRequest showPrivateKeyVerifyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/users/sshkey/privatekey/verify", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateKeyVerifyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowPrivateKeyVerifyResponse>(response);
        }

        public SyncInvoker<ShowPrivateKeyVerifyResponse> ShowPrivateKeyVerifyInvoker(ShowPrivateKeyVerifyRequest showPrivateKeyVerifyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/users/sshkey/privatekey/verify", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateKeyVerifyRequest);
            return new SyncInvoker<ShowPrivateKeyVerifyResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowPrivateKeyVerifyResponse>);
        }
        
        /// <summary>
        ///  https账号密码校验
        ///
        /// 判断用户使用 https 上传/下载代码时输入的用户名和密码是否合法。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public ValidateHttpsInfoResponse ValidateHttpsInfo(ValidateHttpsInfoRequest validateHttpsInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(validateHttpsInfoRequest.IamUserUuid, out var valueOfIamUserUuid)) urlParam.Add("iam_user_uuid", valueOfIamUserUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/user/{iam_user_uuid}/validateHttpsInfo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", validateHttpsInfoRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ValidateHttpsInfoResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<ValidateHttpsInfoResponse> ValidateHttpsInfoInvoker(ValidateHttpsInfoRequest validateHttpsInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(validateHttpsInfoRequest.IamUserUuid, out var valueOfIamUserUuid)) urlParam.Add("iam_user_uuid", valueOfIamUserUuid);
            var urlPath = HttpUtils.AddUrlPath("/v1/user/{iam_user_uuid}/validateHttpsInfo", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", validateHttpsInfoRequest);
            return new SyncInvoker<ValidateHttpsInfoResponse>(this, "POST", request, JsonUtils.DeSerialize<ValidateHttpsInfoResponse>);
        }
        
        /// <summary>
        /// https账号密码校验
        ///
        /// 判断用户使用 https 上传/下载代码时输入的用户名和密码是否合法。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ValidateHttpsInfoV2Response ValidateHttpsInfoV2(ValidateHttpsInfoV2Request validateHttpsInfoV2Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(validateHttpsInfoV2Request.IamUserUuid, out var valueOfIamUserUuid)) urlParam.Add("iam_user_uuid", valueOfIamUserUuid);
            var urlPath = HttpUtils.AddUrlPath("/v2/user/{iam_user_uuid}/validate-https-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", validateHttpsInfoV2Request);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ValidateHttpsInfoV2Response>(response);
        }

        public SyncInvoker<ValidateHttpsInfoV2Response> ValidateHttpsInfoV2Invoker(ValidateHttpsInfoV2Request validateHttpsInfoV2Request)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(validateHttpsInfoV2Request.IamUserUuid, out var valueOfIamUserUuid)) urlParam.Add("iam_user_uuid", valueOfIamUserUuid);
            var urlPath = HttpUtils.AddUrlPath("/v2/user/{iam_user_uuid}/validate-https-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", validateHttpsInfoV2Request);
            return new SyncInvoker<ValidateHttpsInfoV2Response>(this, "POST", request, JsonUtils.DeSerialize<ValidateHttpsInfoV2Response>);
        }
        
        /// <summary>
        /// 创建分支
        ///
        /// 根据仓库id在指定仓库中创建分支
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateNewBranchResponse CreateNewBranch(CreateNewBranchRequest createNewBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createNewBranchRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNewBranchRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateNewBranchResponse>(response);
        }

        public SyncInvoker<CreateNewBranchResponse> CreateNewBranchInvoker(CreateNewBranchRequest createNewBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createNewBranchRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v2/repositories/{repository_id}/branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNewBranchRequest);
            return new SyncInvoker<CreateNewBranchResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateNewBranchResponse>);
        }
        
        /// <summary>
        /// 分支关联工作项
        ///
        /// 分支关联工作项
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AssociateIssuesResponse AssociateIssues(AssociateIssuesRequest associateIssuesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/issues", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateIssuesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AssociateIssuesResponse>(response);
        }

        public SyncInvoker<AssociateIssuesResponse> AssociateIssuesInvoker(AssociateIssuesRequest associateIssuesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/issues", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateIssuesRequest);
            return new SyncInvoker<AssociateIssuesResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateIssuesResponse>);
        }
        
        /// <summary>
        /// 创建项目、仓库
        ///
        /// 创建项目后，创建仓库组由后台生成方式 传入参数：仓库名、模板id、是否导入项目成员、归属项目
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateProjectAndRepositoriesResponse CreateProjectAndRepositories(CreateProjectAndRepositoriesRequest createProjectAndRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProjectAndRepositoriesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateProjectAndRepositoriesResponse>(response);
        }

        public SyncInvoker<CreateProjectAndRepositoriesResponse> CreateProjectAndRepositoriesInvoker(CreateProjectAndRepositoriesRequest createProjectAndRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProjectAndRepositoriesRequest);
            return new SyncInvoker<CreateProjectAndRepositoriesResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateProjectAndRepositoriesResponse>);
        }
        
        /// <summary>
        /// 创建项目并fork仓库
        ///
        /// 创建仓库后fork仓库 传入参数：仓库名、是否导入项目成员、归属项目
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateProjectAndforkRepositoriesResponse CreateProjectAndforkRepositories(CreateProjectAndforkRepositoriesRequest createProjectAndforkRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/repositories/fork", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProjectAndforkRepositoriesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateProjectAndforkRepositoriesResponse>(response);
        }

        public SyncInvoker<CreateProjectAndforkRepositoriesResponse> CreateProjectAndforkRepositoriesInvoker(CreateProjectAndforkRepositoriesRequest createProjectAndforkRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/repositories/fork", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProjectAndforkRepositoriesRequest);
            return new SyncInvoker<CreateProjectAndforkRepositoriesResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateProjectAndforkRepositoriesResponse>);
        }
        
        /// <summary>
        /// 查询用户的所有仓库
        ///
        /// 获取用户的所有仓库信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUserAllRepositoriesResponse ListUserAllRepositories(ListUserAllRepositoriesRequest listUserAllRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserAllRepositoriesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUserAllRepositoriesResponse>(response);
        }

        public SyncInvoker<ListUserAllRepositoriesResponse> ListUserAllRepositoriesInvoker(ListUserAllRepositoriesRequest listUserAllRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserAllRepositoriesRequest);
            return new SyncInvoker<ListUserAllRepositoriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUserAllRepositoriesResponse>);
        }
        
        /// <summary>
        /// 查询项目下的所有仓库
        ///
        /// 获取仓库列表,模糊查询支持范围,如果未传入project uuid，则支持按仓库名或项目名模糊查询，否则，只按仓库名模糊匹配
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAllRepositoryByTwoProjectIdResponse ShowAllRepositoryByTwoProjectId(ShowAllRepositoryByTwoProjectIdRequest showAllRepositoryByTwoProjectIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAllRepositoryByTwoProjectIdRequest.ProjectUuid, out var valueOfProjectUuid)) urlParam.Add("project_uuid", valueOfProjectUuid);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{project_uuid}/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAllRepositoryByTwoProjectIdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAllRepositoryByTwoProjectIdResponse>(response);
        }

        public SyncInvoker<ShowAllRepositoryByTwoProjectIdResponse> ShowAllRepositoryByTwoProjectIdInvoker(ShowAllRepositoryByTwoProjectIdRequest showAllRepositoryByTwoProjectIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAllRepositoryByTwoProjectIdRequest.ProjectUuid, out var valueOfProjectUuid)) urlParam.Add("project_uuid", valueOfProjectUuid);
            var urlPath = HttpUtils.AddUrlPath("/v2/projects/{project_uuid}/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAllRepositoryByTwoProjectIdRequest);
            return new SyncInvoker<ShowAllRepositoryByTwoProjectIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAllRepositoryByTwoProjectIdResponse>);
        }
        
        /// <summary>
        /// 为指定仓库添加hook
        ///
        /// 提交代码自动触发编译构建，添加仓库钩子
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddHooksResponse AddHooks(AddHooksRequest addHooksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addHooksRequest.GroupName, out var valueOfGroupName)) urlParam.Add("group_name", valueOfGroupName);
            if (StringUtils.TryConvertToNonEmptyString(addHooksRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{group_name}/{repository_name}/hooks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addHooksRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddHooksResponse>(response);
        }

        public SyncInvoker<AddHooksResponse> AddHooksInvoker(AddHooksRequest addHooksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addHooksRequest.GroupName, out var valueOfGroupName)) urlParam.Add("group_name", valueOfGroupName);
            if (StringUtils.TryConvertToNonEmptyString(addHooksRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{group_name}/{repository_name}/hooks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addHooksRequest);
            return new SyncInvoker<AddHooksResponse>(this, "POST", request, JsonUtils.DeSerialize<AddHooksResponse>);
        }
        
        /// <summary>
        /// 删除指定仓库的 hook
        ///
        /// 提交代码自动触发编译构建，删除仓库钩子
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteHooksResponse DeleteHooks(DeleteHooksRequest deleteHooksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteHooksRequest.GroupName, out var valueOfGroupName)) urlParam.Add("group_name", valueOfGroupName);
            if (StringUtils.TryConvertToNonEmptyString(deleteHooksRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            if (StringUtils.TryConvertToNonEmptyString(deleteHooksRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{group_name}/{repository_name}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHooksRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteHooksResponse>(response);
        }

        public SyncInvoker<DeleteHooksResponse> DeleteHooksInvoker(DeleteHooksRequest deleteHooksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteHooksRequest.GroupName, out var valueOfGroupName)) urlParam.Add("group_name", valueOfGroupName);
            if (StringUtils.TryConvertToNonEmptyString(deleteHooksRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            if (StringUtils.TryConvertToNonEmptyString(deleteHooksRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{group_name}/{repository_name}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHooksRequest);
            return new SyncInvoker<DeleteHooksResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteHooksResponse>);
        }
        
        /// <summary>
        /// 查询指定仓库的webhook
        ///
        /// 获取仓库webhook
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListHooksResponse ListHooks(ListHooksRequest listHooksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listHooksRequest.GroupName, out var valueOfGroupName)) urlParam.Add("group_name", valueOfGroupName);
            if (StringUtils.TryConvertToNonEmptyString(listHooksRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{group_name}/{repository_name}/hooks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHooksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListHooksResponse>(response);
        }

        public SyncInvoker<ListHooksResponse> ListHooksInvoker(ListHooksRequest listHooksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listHooksRequest.GroupName, out var valueOfGroupName)) urlParam.Add("group_name", valueOfGroupName);
            if (StringUtils.TryConvertToNonEmptyString(listHooksRequest.RepositoryName, out var valueOfRepositoryName)) urlParam.Add("repository_name", valueOfRepositoryName);
            var urlPath = HttpUtils.AddUrlPath("/v1/repositories/{group_name}/{repository_name}/hooks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHooksRequest);
            return new SyncInvoker<ListHooksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHooksResponse>);
        }
        
    }
}