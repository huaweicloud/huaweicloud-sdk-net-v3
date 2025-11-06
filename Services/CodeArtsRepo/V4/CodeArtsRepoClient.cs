using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.CodeArtsRepo.V4.Model;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4
{
    public partial class CodeArtsRepoClient : Client
    {
        public static ClientBuilder<CodeArtsRepoClient> NewBuilder()
        {
            return new ClientBuilder<CodeArtsRepoClient>();
        }

        
        /// <summary>
        /// 创建提交信息
        ///
        /// 创建提交信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateCommitResponse CreateCommit(CreateCommitRequest createCommitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createCommitRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/commits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCommitRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateCommitResponse>(response);
        }

        public SyncInvoker<CreateCommitResponse> CreateCommitInvoker(CreateCommitRequest createCommitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createCommitRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/commits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCommitRequest);
            return new SyncInvoker<CreateCommitResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCommitResponse>);
        }
        
        /// <summary>
        /// 回退提交
        ///
        /// 回退提交
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateCommitRevertResponse CreateCommitRevert(CreateCommitRevertRequest createCommitRevertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createCommitRevertRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(createCommitRevertRequest.Sha, out var valueOfSha)) urlParam.Add("sha", valueOfSha);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/commits/{sha}/revert", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCommitRevertRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateCommitRevertResponse>(response);
        }

        public SyncInvoker<CreateCommitRevertResponse> CreateCommitRevertInvoker(CreateCommitRevertRequest createCommitRevertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createCommitRevertRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(createCommitRevertRequest.Sha, out var valueOfSha)) urlParam.Add("sha", valueOfSha);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/commits/{sha}/revert", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCommitRevertRequest);
            return new SyncInvoker<CreateCommitRevertResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCommitRevertResponse>);
        }
        
        /// <summary>
        /// 根据提交ID查询分支、标签列表
        ///
        /// 根据提交ID查询分支、标签列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCommitAssociatedRefsResponse ListCommitAssociatedRefs(ListCommitAssociatedRefsRequest listCommitAssociatedRefsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listCommitAssociatedRefsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listCommitAssociatedRefsRequest.Sha, out var valueOfSha)) urlParam.Add("sha", valueOfSha);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/commits/{sha}/refs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCommitAssociatedRefsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listCommitAssociatedRefsResponse = JsonUtils.DeSerializeNull<ListCommitAssociatedRefsResponse>(response);
            listCommitAssociatedRefsResponse.Body = JsonUtils.DeSerializeList<string>(response);
            return listCommitAssociatedRefsResponse;
        }

        public SyncInvoker<ListCommitAssociatedRefsResponse> ListCommitAssociatedRefsInvoker(ListCommitAssociatedRefsRequest listCommitAssociatedRefsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listCommitAssociatedRefsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listCommitAssociatedRefsRequest.Sha, out var valueOfSha)) urlParam.Add("sha", valueOfSha);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/commits/{sha}/refs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCommitAssociatedRefsRequest);
            return new SyncInvoker<ListCommitAssociatedRefsResponse>(this, "GET", request, response =>
            {
                var listCommitAssociatedRefsResponse = JsonUtils.DeSerializeNull<ListCommitAssociatedRefsResponse>(response);
                listCommitAssociatedRefsResponse.Body = JsonUtils.DeSerializeList<string>(response);
                return listCommitAssociatedRefsResponse;
            });
        }
        
        /// <summary>
        /// 查看提交列表
        ///
        /// 查看提交列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCommitsResponse ListCommits(ListCommitsRequest listCommitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listCommitsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/commit-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCommitsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCommitsResponse>(response);
        }

        public SyncInvoker<ListCommitsResponse> ListCommitsInvoker(ListCommitsRequest listCommitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listCommitsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/commit-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCommitsRequest);
            return new SyncInvoker<ListCommitsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCommitsResponse>);
        }
        
        /// <summary>
        /// 获取特定提交信息
        ///
        /// 获取特定提交信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowCommitResponse ShowCommit(ShowCommitRequest showCommitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCommitRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/commits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCommitRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowCommitResponse>(response);
        }

        public SyncInvoker<ShowCommitResponse> ShowCommitInvoker(ShowCommitRequest showCommitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCommitRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/commits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCommitRequest);
            return new SyncInvoker<ShowCommitResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCommitResponse>);
        }
        
        /// <summary>
        /// 获取commit引入的文件变更元数据
        ///
        /// 获取commit引入的文件变更元数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowCommitDiffMetadataResponse ShowCommitDiffMetadata(ShowCommitDiffMetadataRequest showCommitDiffMetadataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCommitDiffMetadataRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/commits/diff-metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCommitDiffMetadataRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowCommitDiffMetadataResponse>(response);
        }

        public SyncInvoker<ShowCommitDiffMetadataResponse> ShowCommitDiffMetadataInvoker(ShowCommitDiffMetadataRequest showCommitDiffMetadataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCommitDiffMetadataRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/commits/diff-metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCommitDiffMetadataRequest);
            return new SyncInvoker<ShowCommitDiffMetadataResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCommitDiffMetadataResponse>);
        }
        
        /// <summary>
        /// 获取commit引入的指定文件的变更内容
        ///
        /// 获取commit引入的指定文件的变更内容
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowCommitFileDiffResponse ShowCommitFileDiff(ShowCommitFileDiffRequest showCommitFileDiffRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCommitFileDiffRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/commits/file-diff", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCommitFileDiffRequest);
            var response = DoHttpRequestSync("GET", request);
            var showCommitFileDiffResponse = JsonUtils.DeSerializeNull<ShowCommitFileDiffResponse>(response);
            showCommitFileDiffResponse.Body = JsonUtils.DeSerializeList<FileDiffDto>(response);
            return showCommitFileDiffResponse;
        }

        public SyncInvoker<ShowCommitFileDiffResponse> ShowCommitFileDiffInvoker(ShowCommitFileDiffRequest showCommitFileDiffRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCommitFileDiffRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/commits/file-diff", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCommitFileDiffRequest);
            return new SyncInvoker<ShowCommitFileDiffResponse>(this, "GET", request, response =>
            {
                var showCommitFileDiffResponse = JsonUtils.DeSerializeNull<ShowCommitFileDiffResponse>(response);
                showCommitFileDiffResponse.Body = JsonUtils.DeSerializeList<FileDiffDto>(response);
                return showCommitFileDiffResponse;
            });
        }
        
        /// <summary>
        /// 获取提交差异
        ///
        /// 获取提交差异
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDiffCommitResponse ShowDiffCommit(ShowDiffCommitRequest showDiffCommitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDiffCommitRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/commits/diff", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDiffCommitRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDiffCommitResponse>(response);
        }

        public SyncInvoker<ShowDiffCommitResponse> ShowDiffCommitInvoker(ShowDiffCommitRequest showDiffCommitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDiffCommitRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/commits/diff", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDiffCommitRequest);
            return new SyncInvoker<ShowDiffCommitResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDiffCommitResponse>);
        }
        
        /// <summary>
        /// 创建合并请求检视意见
        ///
        /// 创建合并请求检视意见
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateMergeRequestDiscussionResponse CreateMergeRequestDiscussion(CreateMergeRequestDiscussionRequest createMergeRequestDiscussionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/discussions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMergeRequestDiscussionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateMergeRequestDiscussionResponse>(response);
        }

        public SyncInvoker<CreateMergeRequestDiscussionResponse> CreateMergeRequestDiscussionInvoker(CreateMergeRequestDiscussionRequest createMergeRequestDiscussionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/discussions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMergeRequestDiscussionRequest);
            return new SyncInvoker<CreateMergeRequestDiscussionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMergeRequestDiscussionResponse>);
        }
        
        /// <summary>
        /// 回复合并请求检视意见
        ///
        /// 回复合并请求检视意见
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateMergeRequestDiscussionResponseResponse CreateMergeRequestDiscussionResponse(CreateMergeRequestDiscussionResponseRequest createMergeRequestDiscussionResponseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionResponseRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionResponseRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionResponseRequest.DiscussionId, out var valueOfDiscussionId)) urlParam.Add("discussion_id", valueOfDiscussionId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/discussions/{discussion_id}/notes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMergeRequestDiscussionResponseRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateMergeRequestDiscussionResponseResponse>(response);
        }

        public SyncInvoker<CreateMergeRequestDiscussionResponseResponse> CreateMergeRequestDiscussionResponseInvoker(CreateMergeRequestDiscussionResponseRequest createMergeRequestDiscussionResponseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionResponseRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionResponseRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionResponseRequest.DiscussionId, out var valueOfDiscussionId)) urlParam.Add("discussion_id", valueOfDiscussionId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/discussions/{discussion_id}/notes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMergeRequestDiscussionResponseRequest);
            return new SyncInvoker<CreateMergeRequestDiscussionResponseResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMergeRequestDiscussionResponseResponse>);
        }
        
        /// <summary>
        /// 创建/更新检视意见设置
        ///
        /// 创建/更新检视意见设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateReviewSettingResponse CreateReviewSetting(CreateReviewSettingRequest createReviewSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createReviewSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/review-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createReviewSettingRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateReviewSettingResponse>(response);
        }

        public SyncInvoker<CreateReviewSettingResponse> CreateReviewSettingInvoker(CreateReviewSettingRequest createReviewSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createReviewSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/review-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createReviewSettingRequest);
            return new SyncInvoker<CreateReviewSettingResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateReviewSettingResponse>);
        }
        
        /// <summary>
        /// 删除合并请求检视意见
        ///
        /// 删除合并请求检视意见
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteMergeRequestDiscussionResponse DeleteMergeRequestDiscussion(DeleteMergeRequestDiscussionRequest deleteMergeRequestDiscussionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteMergeRequestDiscussionRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(deleteMergeRequestDiscussionRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            if (StringUtils.TryConvertToNonEmptyString(deleteMergeRequestDiscussionRequest.DiscussionId, out var valueOfDiscussionId)) urlParam.Add("discussion_id", valueOfDiscussionId);
            if (StringUtils.TryConvertToNonEmptyString(deleteMergeRequestDiscussionRequest.NoteId, out var valueOfNoteId)) urlParam.Add("note_id", valueOfNoteId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/discussions/{discussion_id}/notes/{note_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMergeRequestDiscussionRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteMergeRequestDiscussionResponse>(response);
        }

        public SyncInvoker<DeleteMergeRequestDiscussionResponse> DeleteMergeRequestDiscussionInvoker(DeleteMergeRequestDiscussionRequest deleteMergeRequestDiscussionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteMergeRequestDiscussionRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(deleteMergeRequestDiscussionRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            if (StringUtils.TryConvertToNonEmptyString(deleteMergeRequestDiscussionRequest.DiscussionId, out var valueOfDiscussionId)) urlParam.Add("discussion_id", valueOfDiscussionId);
            if (StringUtils.TryConvertToNonEmptyString(deleteMergeRequestDiscussionRequest.NoteId, out var valueOfNoteId)) urlParam.Add("note_id", valueOfNoteId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/discussions/{discussion_id}/notes/{note_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMergeRequestDiscussionRequest);
            return new SyncInvoker<DeleteMergeRequestDiscussionResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteMergeRequestDiscussionResponse>);
        }
        
        /// <summary>
        /// 获取代码页单个提交下检视意见列表
        ///
        /// 获取代码页单个提交下检视意见列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCommitDiscussionsResponse ListCommitDiscussions(ListCommitDiscussionsRequest listCommitDiscussionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listCommitDiscussionsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listCommitDiscussionsRequest.Sha, out var valueOfSha)) urlParam.Add("sha", valueOfSha);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/commits/{sha}/discussions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCommitDiscussionsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listCommitDiscussionsResponse = JsonUtils.DeSerializeNull<ListCommitDiscussionsResponse>(response);
            listCommitDiscussionsResponse.Body = JsonUtils.DeSerializeList<CommitDiscussionDto>(response);
            return listCommitDiscussionsResponse;
        }

        public SyncInvoker<ListCommitDiscussionsResponse> ListCommitDiscussionsInvoker(ListCommitDiscussionsRequest listCommitDiscussionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listCommitDiscussionsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listCommitDiscussionsRequest.Sha, out var valueOfSha)) urlParam.Add("sha", valueOfSha);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/commits/{sha}/discussions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCommitDiscussionsRequest);
            return new SyncInvoker<ListCommitDiscussionsResponse>(this, "GET", request, response =>
            {
                var listCommitDiscussionsResponse = JsonUtils.DeSerializeNull<ListCommitDiscussionsResponse>(response);
                listCommitDiscussionsResponse.Body = JsonUtils.DeSerializeList<CommitDiscussionDto>(response);
                return listCommitDiscussionsResponse;
            });
        }
        
        /// <summary>
        /// 获取默认的检视意见分类
        ///
        /// 获取默认的检视意见分类
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDefaultReviewCategoriesResponse ListDefaultReviewCategories(ListDefaultReviewCategoriesRequest listDefaultReviewCategoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/default-review-categories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDefaultReviewCategoriesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDefaultReviewCategoriesResponse>(response);
        }

        public SyncInvoker<ListDefaultReviewCategoriesResponse> ListDefaultReviewCategoriesInvoker(ListDefaultReviewCategoriesRequest listDefaultReviewCategoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/default-review-categories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDefaultReviewCategoriesRequest);
            return new SyncInvoker<ListDefaultReviewCategoriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDefaultReviewCategoriesResponse>);
        }
        
        /// <summary>
        /// 获取合并请求检视意见列表
        ///
        /// 获取合并请求检视意见列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMergeRequestDiscussionsResponse ListMergeRequestDiscussions(ListMergeRequestDiscussionsRequest listMergeRequestDiscussionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestDiscussionsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestDiscussionsRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/discussions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestDiscussionsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listMergeRequestDiscussionsResponse = JsonUtils.DeSerializeNull<ListMergeRequestDiscussionsResponse>(response);
            listMergeRequestDiscussionsResponse.Body = JsonUtils.DeSerializeList<MergeRequestDiscussionDto>(response);
            return listMergeRequestDiscussionsResponse;
        }

        public SyncInvoker<ListMergeRequestDiscussionsResponse> ListMergeRequestDiscussionsInvoker(ListMergeRequestDiscussionsRequest listMergeRequestDiscussionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestDiscussionsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestDiscussionsRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/discussions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestDiscussionsRequest);
            return new SyncInvoker<ListMergeRequestDiscussionsResponse>(this, "GET", request, response =>
            {
                var listMergeRequestDiscussionsResponse = JsonUtils.DeSerializeNull<ListMergeRequestDiscussionsResponse>(response);
                listMergeRequestDiscussionsResponse.Body = JsonUtils.DeSerializeList<MergeRequestDiscussionDto>(response);
                return listMergeRequestDiscussionsResponse;
            });
        }
        
        /// <summary>
        /// 获取合并请求动态列表
        ///
        /// 获取合并请求动态列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMergeRequestSystemNotesResponse ListMergeRequestSystemNotes(ListMergeRequestSystemNotesRequest listMergeRequestSystemNotesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestSystemNotesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestSystemNotesRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/system-notes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestSystemNotesRequest);
            var response = DoHttpRequestSync("GET", request);
            var listMergeRequestSystemNotesResponse = JsonUtils.DeSerializeNull<ListMergeRequestSystemNotesResponse>(response);
            listMergeRequestSystemNotesResponse.Body = JsonUtils.DeSerializeList<NoteDto>(response);
            return listMergeRequestSystemNotesResponse;
        }

        public SyncInvoker<ListMergeRequestSystemNotesResponse> ListMergeRequestSystemNotesInvoker(ListMergeRequestSystemNotesRequest listMergeRequestSystemNotesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestSystemNotesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestSystemNotesRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/system-notes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestSystemNotesRequest);
            return new SyncInvoker<ListMergeRequestSystemNotesResponse>(this, "GET", request, response =>
            {
                var listMergeRequestSystemNotesResponse = JsonUtils.DeSerializeNull<ListMergeRequestSystemNotesResponse>(response);
                listMergeRequestSystemNotesResponse.Body = JsonUtils.DeSerializeList<NoteDto>(response);
                return listMergeRequestSystemNotesResponse;
            });
        }
        
        /// <summary>
        /// 获取项目检视意见必填项
        ///
        /// 获取项目检视意见必填项
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProjectNoteRequiredAttributesResponse ListProjectNoteRequiredAttributes(ListProjectNoteRequiredAttributesRequest listProjectNoteRequiredAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectNoteRequiredAttributesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/setting/note-required-attributes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectNoteRequiredAttributesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListProjectNoteRequiredAttributesResponse>(response);
        }

        public SyncInvoker<ListProjectNoteRequiredAttributesResponse> ListProjectNoteRequiredAttributesInvoker(ListProjectNoteRequiredAttributesRequest listProjectNoteRequiredAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectNoteRequiredAttributesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/setting/note-required-attributes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectNoteRequiredAttributesRequest);
            return new SyncInvoker<ListProjectNoteRequiredAttributesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProjectNoteRequiredAttributesResponse>);
        }
        
        /// <summary>
        /// 获取仓库下检视意见作者列表
        ///
        /// 获取仓库下检视意见作者列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRepositoryReviewAuthorsResponse ListRepositoryReviewAuthors(ListRepositoryReviewAuthorsRequest listRepositoryReviewAuthorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryReviewAuthorsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/review-authors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryReviewAuthorsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listRepositoryReviewAuthorsResponse = JsonUtils.DeSerializeNull<ListRepositoryReviewAuthorsResponse>(response);
            listRepositoryReviewAuthorsResponse.Body = JsonUtils.DeSerializeList<UserBasicDto>(response);
            return listRepositoryReviewAuthorsResponse;
        }

        public SyncInvoker<ListRepositoryReviewAuthorsResponse> ListRepositoryReviewAuthorsInvoker(ListRepositoryReviewAuthorsRequest listRepositoryReviewAuthorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryReviewAuthorsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/review-authors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryReviewAuthorsRequest);
            return new SyncInvoker<ListRepositoryReviewAuthorsResponse>(this, "GET", request, response =>
            {
                var listRepositoryReviewAuthorsResponse = JsonUtils.DeSerializeNull<ListRepositoryReviewAuthorsResponse>(response);
                listRepositoryReviewAuthorsResponse.Body = JsonUtils.DeSerializeList<UserBasicDto>(response);
                return listRepositoryReviewAuthorsResponse;
            });
        }
        
        /// <summary>
        /// 获取仓库检视意见列表
        ///
        /// 获取仓库检视意见列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRepositoryReviewsResponse ListRepositoryReviews(ListRepositoryReviewsRequest listRepositoryReviewsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryReviewsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/reviews", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryReviewsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listRepositoryReviewsResponse = JsonUtils.DeSerializeNull<ListRepositoryReviewsResponse>(response);
            listRepositoryReviewsResponse.Body = JsonUtils.DeSerializeList<ReviewDto>(response);
            return listRepositoryReviewsResponse;
        }

        public SyncInvoker<ListRepositoryReviewsResponse> ListRepositoryReviewsInvoker(ListRepositoryReviewsRequest listRepositoryReviewsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryReviewsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/reviews", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryReviewsRequest);
            return new SyncInvoker<ListRepositoryReviewsResponse>(this, "GET", request, response =>
            {
                var listRepositoryReviewsResponse = JsonUtils.DeSerializeNull<ListRepositoryReviewsResponse>(response);
                listRepositoryReviewsResponse.Body = JsonUtils.DeSerializeList<ReviewDto>(response);
                return listRepositoryReviewsResponse;
            });
        }
        
        /// <summary>
        /// 获取代码组检视意见必填项
        ///
        /// 获取代码组检视意见必填项
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGroupNoteRequiredAttributesResponse ShowGroupNoteRequiredAttributes(ShowGroupNoteRequiredAttributesRequest showGroupNoteRequiredAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupNoteRequiredAttributesRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/setting/note-required-attributes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupNoteRequiredAttributesRequest);
            var response = DoHttpRequestSync("GET", request);
            var showGroupNoteRequiredAttributesResponse = JsonUtils.DeSerializeNull<ShowGroupNoteRequiredAttributesResponse>(response);
            showGroupNoteRequiredAttributesResponse.Body = JsonUtils.DeSerializeList<NoteRequiredAttributeDto>(response);
            return showGroupNoteRequiredAttributesResponse;
        }

        public SyncInvoker<ShowGroupNoteRequiredAttributesResponse> ShowGroupNoteRequiredAttributesInvoker(ShowGroupNoteRequiredAttributesRequest showGroupNoteRequiredAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupNoteRequiredAttributesRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/setting/note-required-attributes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupNoteRequiredAttributesRequest);
            return new SyncInvoker<ShowGroupNoteRequiredAttributesResponse>(this, "GET", request, response =>
            {
                var showGroupNoteRequiredAttributesResponse = JsonUtils.DeSerializeNull<ShowGroupNoteRequiredAttributesResponse>(response);
                showGroupNoteRequiredAttributesResponse.Body = JsonUtils.DeSerializeList<NoteRequiredAttributeDto>(response);
                return showGroupNoteRequiredAttributesResponse;
            });
        }
        
        /// <summary>
        /// 获取代码组检视意见设置(不含必填项)
        ///
        /// 获取代码组检视意见设置(不含必填项)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGroupReviewSettingsResponse ShowGroupReviewSettings(ShowGroupReviewSettingsRequest showGroupReviewSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupReviewSettingsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/review-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupReviewSettingsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGroupReviewSettingsResponse>(response);
        }

        public SyncInvoker<ShowGroupReviewSettingsResponse> ShowGroupReviewSettingsInvoker(ShowGroupReviewSettingsRequest showGroupReviewSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupReviewSettingsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/review-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupReviewSettingsRequest);
            return new SyncInvoker<ShowGroupReviewSettingsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGroupReviewSettingsResponse>);
        }
        
        /// <summary>
        /// 根据discussion_id获取合并请求检视意见
        ///
        /// 根据discussion_id获取合并请求检视意见
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMergeRequestDiscussionResponse ShowMergeRequestDiscussion(ShowMergeRequestDiscussionRequest showMergeRequestDiscussionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestDiscussionRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestDiscussionRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestDiscussionRequest.DiscussionId, out var valueOfDiscussionId)) urlParam.Add("discussion_id", valueOfDiscussionId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/discussions/{discussion_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMergeRequestDiscussionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMergeRequestDiscussionResponse>(response);
        }

        public SyncInvoker<ShowMergeRequestDiscussionResponse> ShowMergeRequestDiscussionInvoker(ShowMergeRequestDiscussionRequest showMergeRequestDiscussionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestDiscussionRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestDiscussionRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestDiscussionRequest.DiscussionId, out var valueOfDiscussionId)) urlParam.Add("discussion_id", valueOfDiscussionId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/discussions/{discussion_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMergeRequestDiscussionRequest);
            return new SyncInvoker<ShowMergeRequestDiscussionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMergeRequestDiscussionResponse>);
        }
        
        /// <summary>
        /// 获取仓库检视意见必填项
        ///
        /// 获取仓库检视意见必填项
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowNoteRequiredAttributesResponse ShowNoteRequiredAttributes(ShowNoteRequiredAttributesRequest showNoteRequiredAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNoteRequiredAttributesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/setting/note-required-attributes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNoteRequiredAttributesRequest);
            var response = DoHttpRequestSync("GET", request);
            var showNoteRequiredAttributesResponse = JsonUtils.DeSerializeNull<ShowNoteRequiredAttributesResponse>(response);
            showNoteRequiredAttributesResponse.Body = JsonUtils.DeSerializeList<NoteRequiredAttributeDto>(response);
            return showNoteRequiredAttributesResponse;
        }

        public SyncInvoker<ShowNoteRequiredAttributesResponse> ShowNoteRequiredAttributesInvoker(ShowNoteRequiredAttributesRequest showNoteRequiredAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNoteRequiredAttributesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/setting/note-required-attributes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNoteRequiredAttributesRequest);
            return new SyncInvoker<ShowNoteRequiredAttributesResponse>(this, "GET", request, response =>
            {
                var showNoteRequiredAttributesResponse = JsonUtils.DeSerializeNull<ShowNoteRequiredAttributesResponse>(response);
                showNoteRequiredAttributesResponse.Body = JsonUtils.DeSerializeList<NoteRequiredAttributeDto>(response);
                return showNoteRequiredAttributesResponse;
            });
        }
        
        /// <summary>
        /// 获取项目检视意见设置(不含必填项)
        ///
        /// 获取项目检视意见设置(不含必填项)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowProjectReviewSettingsResponse ShowProjectReviewSettings(ShowProjectReviewSettingsRequest showProjectReviewSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectReviewSettingsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/review-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectReviewSettingsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectReviewSettingsResponse>(response);
        }

        public SyncInvoker<ShowProjectReviewSettingsResponse> ShowProjectReviewSettingsInvoker(ShowProjectReviewSettingsRequest showProjectReviewSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectReviewSettingsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/review-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectReviewSettingsRequest);
            return new SyncInvoker<ShowProjectReviewSettingsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectReviewSettingsResponse>);
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
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/review-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReviewSettingRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowReviewSettingResponse>(response);
        }

        public SyncInvoker<ShowReviewSettingResponse> ShowReviewSettingInvoker(ShowReviewSettingRequest showReviewSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showReviewSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/review-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReviewSettingRequest);
            return new SyncInvoker<ShowReviewSettingResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowReviewSettingResponse>);
        }
        
        /// <summary>
        /// 创建/更新代码组检视意见必填项
        ///
        /// 创建/更新代码组检视意见必填项
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGroupNoteRequiredAttributesResponse UpdateGroupNoteRequiredAttributes(UpdateGroupNoteRequiredAttributesRequest updateGroupNoteRequiredAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateGroupNoteRequiredAttributesRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/setting/note-required-attributes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGroupNoteRequiredAttributesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateGroupNoteRequiredAttributesResponse>(response);
        }

        public SyncInvoker<UpdateGroupNoteRequiredAttributesResponse> UpdateGroupNoteRequiredAttributesInvoker(UpdateGroupNoteRequiredAttributesRequest updateGroupNoteRequiredAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateGroupNoteRequiredAttributesRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/setting/note-required-attributes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGroupNoteRequiredAttributesRequest);
            return new SyncInvoker<UpdateGroupNoteRequiredAttributesResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateGroupNoteRequiredAttributesResponse>);
        }
        
        /// <summary>
        /// 创建/更新代码组检视意见设置(不含必填项)
        ///
        /// 创建/更新代码组检视意见设置(不含必填项)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGroupReviewSettingsResponse UpdateGroupReviewSettings(UpdateGroupReviewSettingsRequest updateGroupReviewSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateGroupReviewSettingsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/review-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGroupReviewSettingsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateGroupReviewSettingsResponse>(response);
        }

        public SyncInvoker<UpdateGroupReviewSettingsResponse> UpdateGroupReviewSettingsInvoker(UpdateGroupReviewSettingsRequest updateGroupReviewSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateGroupReviewSettingsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/review-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGroupReviewSettingsRequest);
            return new SyncInvoker<UpdateGroupReviewSettingsResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateGroupReviewSettingsResponse>);
        }
        
        /// <summary>
        /// 更新合并请求检视意见
        ///
        /// 更新合并请求检视意见
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateMergeRequestDiscussionResponse UpdateMergeRequestDiscussion(UpdateMergeRequestDiscussionRequest updateMergeRequestDiscussionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestDiscussionRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestDiscussionRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestDiscussionRequest.DiscussionId, out var valueOfDiscussionId)) urlParam.Add("discussion_id", valueOfDiscussionId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestDiscussionRequest.NoteId, out var valueOfNoteId)) urlParam.Add("note_id", valueOfNoteId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/discussions/{discussion_id}/notes/{note_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestDiscussionRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateMergeRequestDiscussionResponse>(response);
        }

        public SyncInvoker<UpdateMergeRequestDiscussionResponse> UpdateMergeRequestDiscussionInvoker(UpdateMergeRequestDiscussionRequest updateMergeRequestDiscussionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestDiscussionRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestDiscussionRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestDiscussionRequest.DiscussionId, out var valueOfDiscussionId)) urlParam.Add("discussion_id", valueOfDiscussionId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestDiscussionRequest.NoteId, out var valueOfNoteId)) urlParam.Add("note_id", valueOfNoteId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/discussions/{discussion_id}/notes/{note_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestDiscussionRequest);
            return new SyncInvoker<UpdateMergeRequestDiscussionResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateMergeRequestDiscussionResponse>);
        }
        
        /// <summary>
        /// 更新合并请求检视意见中除评论内容以外的信息
        ///
        /// 更新合并请求检视意见中除评论内容以外的信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateMergeRequestDiscussionInfoResponse UpdateMergeRequestDiscussionInfo(UpdateMergeRequestDiscussionInfoRequest updateMergeRequestDiscussionInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestDiscussionInfoRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestDiscussionInfoRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestDiscussionInfoRequest.DiscussionId, out var valueOfDiscussionId)) urlParam.Add("discussion_id", valueOfDiscussionId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/discussions/{discussion_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestDiscussionInfoRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateMergeRequestDiscussionInfoResponse>(response);
        }

        public SyncInvoker<UpdateMergeRequestDiscussionInfoResponse> UpdateMergeRequestDiscussionInfoInvoker(UpdateMergeRequestDiscussionInfoRequest updateMergeRequestDiscussionInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestDiscussionInfoRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestDiscussionInfoRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestDiscussionInfoRequest.DiscussionId, out var valueOfDiscussionId)) urlParam.Add("discussion_id", valueOfDiscussionId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/discussions/{discussion_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestDiscussionInfoRequest);
            return new SyncInvoker<UpdateMergeRequestDiscussionInfoResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateMergeRequestDiscussionInfoResponse>);
        }
        
        /// <summary>
        /// 创建/更新仓库检视意见必填项
        ///
        /// 创建/更新仓库检视意见必填项
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateNoteRequiredAttributesResponse UpdateNoteRequiredAttributes(UpdateNoteRequiredAttributesRequest updateNoteRequiredAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateNoteRequiredAttributesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/setting/note-required-attributes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNoteRequiredAttributesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateNoteRequiredAttributesResponse>(response);
        }

        public SyncInvoker<UpdateNoteRequiredAttributesResponse> UpdateNoteRequiredAttributesInvoker(UpdateNoteRequiredAttributesRequest updateNoteRequiredAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateNoteRequiredAttributesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/setting/note-required-attributes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNoteRequiredAttributesRequest);
            return new SyncInvoker<UpdateNoteRequiredAttributesResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateNoteRequiredAttributesResponse>);
        }
        
        /// <summary>
        /// 创建/更新项目检视意见必填项
        ///
        /// 创建/更新项目检视意见必填项
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateProjectNoteRequiredAttributesResponse UpdateProjectNoteRequiredAttributes(UpdateProjectNoteRequiredAttributesRequest updateProjectNoteRequiredAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProjectNoteRequiredAttributesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/setting/note-required-attributes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProjectNoteRequiredAttributesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateProjectNoteRequiredAttributesResponse>(response);
        }

        public SyncInvoker<UpdateProjectNoteRequiredAttributesResponse> UpdateProjectNoteRequiredAttributesInvoker(UpdateProjectNoteRequiredAttributesRequest updateProjectNoteRequiredAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProjectNoteRequiredAttributesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/setting/note-required-attributes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProjectNoteRequiredAttributesRequest);
            return new SyncInvoker<UpdateProjectNoteRequiredAttributesResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateProjectNoteRequiredAttributesResponse>);
        }
        
        /// <summary>
        /// 创建/更新项目检视意见设置(不含必填项)
        ///
        /// 创建/更新项目检视意见设置(不含必填项)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateProjectReviewSettingsResponse UpdateProjectReviewSettings(UpdateProjectReviewSettingsRequest updateProjectReviewSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProjectReviewSettingsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/review-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProjectReviewSettingsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateProjectReviewSettingsResponse>(response);
        }

        public SyncInvoker<UpdateProjectReviewSettingsResponse> UpdateProjectReviewSettingsInvoker(UpdateProjectReviewSettingsRequest updateProjectReviewSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProjectReviewSettingsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/review-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProjectReviewSettingsRequest);
            return new SyncInvoker<UpdateProjectReviewSettingsResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateProjectReviewSettingsResponse>);
        }
        
        /// <summary>
        /// 创建文件
        ///
        /// 创建文件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateFileResponse CreateFile(CreateFileRequest createFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createFileRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFileRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateFileResponse>(response);
        }

        public SyncInvoker<CreateFileResponse> CreateFileInvoker(CreateFileRequest createFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createFileRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFileRequest);
            return new SyncInvoker<CreateFileResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateFileResponse>);
        }
        
        /// <summary>
        /// 删除文件
        ///
        /// 删除文件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteFileResponse DeleteFile(DeleteFileRequest deleteFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteFileRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFileRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteFileResponse>(response);
        }

        public SyncInvoker<DeleteFileResponse> DeleteFileInvoker(DeleteFileRequest deleteFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteFileRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFileRequest);
            return new SyncInvoker<DeleteFileResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteFileResponse>);
        }
        
        /// <summary>
        /// 获取仓库单个文件内容(下载单个文件)
        ///
        /// 获取仓库单个文件内容(下载单个文件)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DownloadBlobsRawResponse DownloadBlobsRaw(DownloadBlobsRawRequest downloadBlobsRawRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadBlobsRawRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(downloadBlobsRawRequest.BlobId, out var valueOfBlobId)) urlParam.Add("blob_id", valueOfBlobId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/blobs/{blob_id}/raw", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadBlobsRawRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DownloadBlobsRawResponse>(response);
        }

        public SyncInvoker<DownloadBlobsRawResponse> DownloadBlobsRawInvoker(DownloadBlobsRawRequest downloadBlobsRawRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadBlobsRawRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(downloadBlobsRawRequest.BlobId, out var valueOfBlobId)) urlParam.Add("blob_id", valueOfBlobId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/blobs/{blob_id}/raw", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadBlobsRawRequest);
            return new SyncInvoker<DownloadBlobsRawResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadBlobsRawResponse>);
        }
        
        /// <summary>
        /// 获取文件追溯信息
        ///
        /// 获取文件追溯信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFileBlameLinesResponse ListFileBlameLines(ListFileBlameLinesRequest listFileBlameLinesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFileBlameLinesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/blame", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFileBlameLinesRequest);
            var response = DoHttpRequestSync("GET", request);
            var listFileBlameLinesResponse = JsonUtils.DeSerializeNull<ListFileBlameLinesResponse>(response);
            listFileBlameLinesResponse.Body = JsonUtils.DeSerializeList<BlameDto>(response);
            return listFileBlameLinesResponse;
        }

        public SyncInvoker<ListFileBlameLinesResponse> ListFileBlameLinesInvoker(ListFileBlameLinesRequest listFileBlameLinesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFileBlameLinesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/blame", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFileBlameLinesRequest);
            return new SyncInvoker<ListFileBlameLinesResponse>(this, "GET", request, response =>
            {
                var listFileBlameLinesResponse = JsonUtils.DeSerializeNull<ListFileBlameLinesResponse>(response);
                listFileBlameLinesResponse.Body = JsonUtils.DeSerializeList<BlameDto>(response);
                return listFileBlameLinesResponse;
            });
        }
        
        /// <summary>
        /// 获取当前文件上级树结构
        ///
        /// 获取当前文件上级树结构
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFileUpperTreeEntriesResponse ListFileUpperTreeEntries(ListFileUpperTreeEntriesRequest listFileUpperTreeEntriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFileUpperTreeEntriesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/upper-files-tree", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFileUpperTreeEntriesRequest);
            var response = DoHttpRequestSync("GET", request);
            var listFileUpperTreeEntriesResponse = JsonUtils.DeSerializeNull<ListFileUpperTreeEntriesResponse>(response);
            listFileUpperTreeEntriesResponse.Body = JsonUtils.DeSerializeList<TreeDto>(response);
            return listFileUpperTreeEntriesResponse;
        }

        public SyncInvoker<ListFileUpperTreeEntriesResponse> ListFileUpperTreeEntriesInvoker(ListFileUpperTreeEntriesRequest listFileUpperTreeEntriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFileUpperTreeEntriesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/upper-files-tree", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFileUpperTreeEntriesRequest);
            return new SyncInvoker<ListFileUpperTreeEntriesResponse>(this, "GET", request, response =>
            {
                var listFileUpperTreeEntriesResponse = JsonUtils.DeSerializeNull<ListFileUpperTreeEntriesResponse>(response);
                listFileUpperTreeEntriesResponse.Body = JsonUtils.DeSerializeList<TreeDto>(response);
                return listFileUpperTreeEntriesResponse;
            });
        }
        
        /// <summary>
        /// 获取指定分支下所有的文件列表
        ///
        /// 获取指定分支下所有的文件列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFilesResponse ListFiles(ListFilesRequest listFilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFilesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/file-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFilesRequest);
            var response = DoHttpRequestSync("GET", request);
            var listFilesResponse = JsonUtils.DeSerializeNull<ListFilesResponse>(response);
            listFilesResponse.Body = JsonUtils.DeSerializeList<string>(response);
            return listFilesResponse;
        }

        public SyncInvoker<ListFilesResponse> ListFilesInvoker(ListFilesRequest listFilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFilesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/file-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFilesRequest);
            return new SyncInvoker<ListFilesResponse>(this, "GET", request, response =>
            {
                var listFilesResponse = JsonUtils.DeSerializeNull<ListFilesResponse>(response);
                listFilesResponse.Body = JsonUtils.DeSerializeList<string>(response);
                return listFilesResponse;
            });
        }
        
        /// <summary>
        /// 查看文件树
        ///
        /// 查看文件树
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLogsTreeResponse ListLogsTree(ListLogsTreeRequest listLogsTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listLogsTreeRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/logs-tree", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogsTreeRequest);
            var response = DoHttpRequestSync("GET", request);
            var listLogsTreeResponse = JsonUtils.DeSerializeNull<ListLogsTreeResponse>(response);
            listLogsTreeResponse.Body = JsonUtils.DeSerializeList<LogTreeDto>(response);
            return listLogsTreeResponse;
        }

        public SyncInvoker<ListLogsTreeResponse> ListLogsTreeInvoker(ListLogsTreeRequest listLogsTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listLogsTreeRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/logs-tree", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogsTreeRequest);
            return new SyncInvoker<ListLogsTreeResponse>(this, "GET", request, response =>
            {
                var listLogsTreeResponse = JsonUtils.DeSerializeNull<ListLogsTreeResponse>(response);
                listLogsTreeResponse.Body = JsonUtils.DeSerializeList<LogTreeDto>(response);
                return listLogsTreeResponse;
            });
        }
        
        /// <summary>
        /// 查看分支文件列表
        ///
        /// 查看分支文件列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTreesResponse ListTrees(ListTreesRequest listTreesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTreesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/trees", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTreesRequest);
            var response = DoHttpRequestSync("GET", request);
            var listTreesResponse = JsonUtils.DeSerializeNull<ListTreesResponse>(response);
            listTreesResponse.Body = JsonUtils.DeSerializeList<TreeObjectDto>(response);
            return listTreesResponse;
        }

        public SyncInvoker<ListTreesResponse> ListTreesInvoker(ListTreesRequest listTreesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTreesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/trees", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTreesRequest);
            return new SyncInvoker<ListTreesResponse>(this, "GET", request, response =>
            {
                var listTreesResponse = JsonUtils.DeSerializeNull<ListTreesResponse>(response);
                listTreesResponse.Body = JsonUtils.DeSerializeList<TreeObjectDto>(response);
                return listTreesResponse;
            });
        }
        
        /// <summary>
        /// 文件重命名
        ///
        /// 文件重命名
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RenameFileResponse RenameFile(RenameFileRequest renameFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(renameFileRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/rename-file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", renameFileRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<RenameFileResponse>(response);
        }

        public SyncInvoker<RenameFileResponse> RenameFileInvoker(RenameFileRequest renameFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(renameFileRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/rename-file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", renameFileRequest);
            return new SyncInvoker<RenameFileResponse>(this, "PUT", request, JsonUtils.DeSerialize<RenameFileResponse>);
        }
        
        /// <summary>
        /// 查看文件属性与内容
        ///
        /// 查看文件属性与内容
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowFileResponse ShowFile(ShowFileRequest showFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFileRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFileRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowFileResponse>(response);
        }

        public SyncInvoker<ShowFileResponse> ShowFileInvoker(ShowFileRequest showFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFileRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFileRequest);
            return new SyncInvoker<ShowFileResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFileResponse>);
        }
        
        /// <summary>
        /// 获取文件内容
        ///
        /// 获取文件内容
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowFileContentResponse ShowFileContent(ShowFileContentRequest showFileContentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFileContentRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/file-content", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFileContentRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowFileContentResponse>(response);
        }

        public SyncInvoker<ShowFileContentResponse> ShowFileContentInvoker(ShowFileContentRequest showFileContentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFileContentRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/file-content", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFileContentRequest);
            return new SyncInvoker<ShowFileContentResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFileContentResponse>);
        }
        
        /// <summary>
        /// 获取仓库单个文件内容
        ///
        /// 获取仓库单个文件内容
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowFileRawResponse ShowFileRaw(ShowFileRawRequest showFileRawRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFileRawRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/files/raw", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFileRawRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowFileRawResponse>(response);
        }

        public SyncInvoker<ShowFileRawResponse> ShowFileRawInvoker(ShowFileRawRequest showFileRawRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFileRawRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/files/raw", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFileRawRequest);
            return new SyncInvoker<ShowFileRawResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFileRawResponse>);
        }
        
        /// <summary>
        /// 获取仓库默认分支的Readme文件内容
        ///
        /// 获取仓库默认分支的Readme文件内容
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowReadmeFileResponse ShowReadmeFile(ShowReadmeFileRequest showReadmeFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showReadmeFileRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/readme-file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReadmeFileRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowReadmeFileResponse>(response);
        }

        public SyncInvoker<ShowReadmeFileResponse> ShowReadmeFileInvoker(ShowReadmeFileRequest showReadmeFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showReadmeFileRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/readme-file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReadmeFileRequest);
            return new SyncInvoker<ShowReadmeFileResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowReadmeFileResponse>);
        }
        
        /// <summary>
        /// 更新文件内容
        ///
        /// 修改仓库ip白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateFileResponse UpdateFile(UpdateFileRequest updateFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateFileRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFileRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateFileResponse>(response);
        }

        public SyncInvoker<UpdateFileResponse> UpdateFileInvoker(UpdateFileRequest updateFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateFileRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFileRequest);
            return new SyncInvoker<UpdateFileResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateFileResponse>);
        }
        
        /// <summary>
        /// 关联代码组与成员组
        ///
        /// 关联代码组与成员组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AssociateGroupUserGroupResponse AssociateGroupUserGroup(AssociateGroupUserGroupRequest associateGroupUserGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateGroupUserGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(associateGroupUserGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(associateGroupUserGroupRequest.UserGroupId, out var valueOfUserGroupId)) urlParam.Add("user_group_id", valueOfUserGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/groups/{group_id}/user-group/{user_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateGroupUserGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AssociateGroupUserGroupResponse>(response);
        }

        public SyncInvoker<AssociateGroupUserGroupResponse> AssociateGroupUserGroupInvoker(AssociateGroupUserGroupRequest associateGroupUserGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateGroupUserGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(associateGroupUserGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(associateGroupUserGroupRequest.UserGroupId, out var valueOfUserGroupId)) urlParam.Add("user_group_id", valueOfUserGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/groups/{group_id}/user-group/{user_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateGroupUserGroupRequest);
            return new SyncInvoker<AssociateGroupUserGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateGroupUserGroupResponse>);
        }
        
        /// <summary>
        /// 创建代码组
        ///
        /// 创建代码组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateGroupResponse CreateGroup(CreateGroupRequest createGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateGroupResponse>(response);
        }

        public SyncInvoker<CreateGroupResponse> CreateGroupInvoker(CreateGroupRequest createGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGroupRequest);
            return new SyncInvoker<CreateGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGroupResponse>);
        }
        
        /// <summary>
        /// 删除代码组
        ///
        /// 删除代码组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteGroupResponse DeleteGroup(DeleteGroupRequest deleteGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteGroupResponse>(response);
        }

        public SyncInvoker<DeleteGroupResponse> DeleteGroupInvoker(DeleteGroupRequest deleteGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGroupRequest);
            return new SyncInvoker<DeleteGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteGroupResponse>);
        }
        
        /// <summary>
        /// 获取代码组下可添加的成员列表
        ///
        /// 获取代码组下可添加的成员列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGroupAddableMembersResponse ListGroupAddableMembers(ListGroupAddableMembersRequest listGroupAddableMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupAddableMembersRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/members/addable-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupAddableMembersRequest);
            var response = DoHttpRequestSync("GET", request);
            var listGroupAddableMembersResponse = JsonUtils.DeSerializeNull<ListGroupAddableMembersResponse>(response);
            listGroupAddableMembersResponse.Body = JsonUtils.DeSerializeList<GroupBatchAddMemberDto>(response);
            return listGroupAddableMembersResponse;
        }

        public SyncInvoker<ListGroupAddableMembersResponse> ListGroupAddableMembersInvoker(ListGroupAddableMembersRequest listGroupAddableMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupAddableMembersRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/members/addable-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupAddableMembersRequest);
            return new SyncInvoker<ListGroupAddableMembersResponse>(this, "GET", request, response =>
            {
                var listGroupAddableMembersResponse = JsonUtils.DeSerializeNull<ListGroupAddableMembersResponse>(response);
                listGroupAddableMembersResponse.Body = JsonUtils.DeSerializeList<GroupBatchAddMemberDto>(response);
                return listGroupAddableMembersResponse;
            });
        }
        
        /// <summary>
        /// 获取代码组下可添加的成员组
        ///
        /// 获取代码组下可添加的成员组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGroupAddableUserGroupsResponse ListGroupAddableUserGroups(ListGroupAddableUserGroupsRequest listGroupAddableUserGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupAddableUserGroupsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/user-groups/addable-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupAddableUserGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listGroupAddableUserGroupsResponse = JsonUtils.DeSerializeNull<ListGroupAddableUserGroupsResponse>(response);
            listGroupAddableUserGroupsResponse.Body = JsonUtils.DeSerializeList<UserGroupDto>(response);
            return listGroupAddableUserGroupsResponse;
        }

        public SyncInvoker<ListGroupAddableUserGroupsResponse> ListGroupAddableUserGroupsInvoker(ListGroupAddableUserGroupsRequest listGroupAddableUserGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupAddableUserGroupsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/user-groups/addable-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupAddableUserGroupsRequest);
            return new SyncInvoker<ListGroupAddableUserGroupsResponse>(this, "GET", request, response =>
            {
                var listGroupAddableUserGroupsResponse = JsonUtils.DeSerializeNull<ListGroupAddableUserGroupsResponse>(response);
                listGroupAddableUserGroupsResponse.Body = JsonUtils.DeSerializeList<UserGroupDto>(response);
                return listGroupAddableUserGroupsResponse;
            });
        }
        
        /// <summary>
        /// 获取代码组下可添加的成员列表
        ///
        /// 获取代码组下可添加的成员列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGroupMembersResponse ListGroupMembers(ListGroupMembersRequest listGroupMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupMembersRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/members/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupMembersRequest);
            var response = DoHttpRequestSync("GET", request);
            var listGroupMembersResponse = JsonUtils.DeSerializeNull<ListGroupMembersResponse>(response);
            listGroupMembersResponse.Body = JsonUtils.DeSerializeList<GroupMemberDetailDto>(response);
            return listGroupMembersResponse;
        }

        public SyncInvoker<ListGroupMembersResponse> ListGroupMembersInvoker(ListGroupMembersRequest listGroupMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupMembersRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/members/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupMembersRequest);
            return new SyncInvoker<ListGroupMembersResponse>(this, "GET", request, response =>
            {
                var listGroupMembersResponse = JsonUtils.DeSerializeNull<ListGroupMembersResponse>(response);
                listGroupMembersResponse.Body = JsonUtils.DeSerializeList<GroupMemberDetailDto>(response);
                return listGroupMembersResponse;
            });
        }
        
        /// <summary>
        /// 获取代码组权限资源点列表
        ///
        /// 获取代码组权限资源点列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGroupPermissionResourcesResponse ListGroupPermissionResources(ListGroupPermissionResourcesRequest listGroupPermissionResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/permissions/resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupPermissionResourcesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListGroupPermissionResourcesResponse>(response);
        }

        public SyncInvoker<ListGroupPermissionResourcesResponse> ListGroupPermissionResourcesInvoker(ListGroupPermissionResourcesRequest listGroupPermissionResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/permissions/resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupPermissionResourcesRequest);
            return new SyncInvoker<ListGroupPermissionResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGroupPermissionResourcesResponse>);
        }
        
        /// <summary>
        /// 获取代码组下的子代码组和仓库列表
        ///
        /// 获取代码组下的子代码组和仓库列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGroupSubgroupsAndRepositoriesResponse ListGroupSubgroupsAndRepositories(ListGroupSubgroupsAndRepositoriesRequest listGroupSubgroupsAndRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupSubgroupsAndRepositoriesRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/subgroups-and-repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupSubgroupsAndRepositoriesRequest);
            var response = DoHttpRequestSync("GET", request);
            var listGroupSubgroupsAndRepositoriesResponse = JsonUtils.DeSerializeNull<ListGroupSubgroupsAndRepositoriesResponse>(response);
            listGroupSubgroupsAndRepositoriesResponse.Body = JsonUtils.DeSerializeList<SubgroupAndProjectBaseDto>(response);
            return listGroupSubgroupsAndRepositoriesResponse;
        }

        public SyncInvoker<ListGroupSubgroupsAndRepositoriesResponse> ListGroupSubgroupsAndRepositoriesInvoker(ListGroupSubgroupsAndRepositoriesRequest listGroupSubgroupsAndRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupSubgroupsAndRepositoriesRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/subgroups-and-repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupSubgroupsAndRepositoriesRequest);
            return new SyncInvoker<ListGroupSubgroupsAndRepositoriesResponse>(this, "GET", request, response =>
            {
                var listGroupSubgroupsAndRepositoriesResponse = JsonUtils.DeSerializeNull<ListGroupSubgroupsAndRepositoriesResponse>(response);
                listGroupSubgroupsAndRepositoriesResponse.Body = JsonUtils.DeSerializeList<SubgroupAndProjectBaseDto>(response);
                return listGroupSubgroupsAndRepositoriesResponse;
            });
        }
        
        /// <summary>
        /// 组织下查询成员组列表
        ///
        /// 组织下查询成员组列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGroupUserGroupsResponse ListGroupUserGroups(ListGroupUserGroupsRequest listGroupUserGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupUserGroupsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/user-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupUserGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listGroupUserGroupsResponse = JsonUtils.DeSerializeNull<ListGroupUserGroupsResponse>(response);
            listGroupUserGroupsResponse.Body = JsonUtils.DeSerializeList<ProjectUserGroupDto>(response);
            return listGroupUserGroupsResponse;
        }

        public SyncInvoker<ListGroupUserGroupsResponse> ListGroupUserGroupsInvoker(ListGroupUserGroupsRequest listGroupUserGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupUserGroupsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/user-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupUserGroupsRequest);
            return new SyncInvoker<ListGroupUserGroupsResponse>(this, "GET", request, response =>
            {
                var listGroupUserGroupsResponse = JsonUtils.DeSerializeNull<ListGroupUserGroupsResponse>(response);
                listGroupUserGroupsResponse.Body = JsonUtils.DeSerializeList<ProjectUserGroupDto>(response);
                return listGroupUserGroupsResponse;
            });
        }
        
        /// <summary>
        /// 获取代码组列表
        ///
        /// 获取代码组列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGroupsResponse ListGroups(ListGroupsRequest listGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listGroupsResponse = JsonUtils.DeSerializeNull<ListGroupsResponse>(response);
            listGroupsResponse.Body = JsonUtils.DeSerializeList<GroupBaseDto>(response);
            return listGroupsResponse;
        }

        public SyncInvoker<ListGroupsResponse> ListGroupsInvoker(ListGroupsRequest listGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupsRequest);
            return new SyncInvoker<ListGroupsResponse>(this, "GET", request, response =>
            {
                var listGroupsResponse = JsonUtils.DeSerializeNull<ListGroupsResponse>(response);
                listGroupsResponse.Body = JsonUtils.DeSerializeList<GroupBaseDto>(response);
                return listGroupsResponse;
            });
        }
        
        /// <summary>
        /// 获取项目下当前用户有管理权限的代码组列表
        ///
        /// 获取项目下当前用户有管理权限的代码组列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListManageableGroupsResponse ListManageableGroups(ListManageableGroupsRequest listManageableGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listManageableGroupsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/manageable-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listManageableGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listManageableGroupsResponse = JsonUtils.DeSerializeNull<ListManageableGroupsResponse>(response);
            listManageableGroupsResponse.Body = JsonUtils.DeSerializeList<ManageableGroupDto>(response);
            return listManageableGroupsResponse;
        }

        public SyncInvoker<ListManageableGroupsResponse> ListManageableGroupsInvoker(ListManageableGroupsRequest listManageableGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listManageableGroupsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/manageable-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listManageableGroupsRequest);
            return new SyncInvoker<ListManageableGroupsResponse>(this, "GET", request, response =>
            {
                var listManageableGroupsResponse = JsonUtils.DeSerializeNull<ListManageableGroupsResponse>(response);
                listManageableGroupsResponse.Body = JsonUtils.DeSerializeList<ManageableGroupDto>(response);
                return listManageableGroupsResponse;
            });
        }
        
        /// <summary>
        /// 获取代码组信息
        ///
        /// 获取代码组信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGroupResponse ShowGroup(ShowGroupRequest showGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGroupResponse>(response);
        }

        public SyncInvoker<ShowGroupResponse> ShowGroupInvoker(ShowGroupRequest showGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupRequest);
            return new SyncInvoker<ShowGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGroupResponse>);
        }
        
        /// <summary>
        /// 获取指定代码组的基本设置信息
        ///
        /// 获取指定代码组的基本设置信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGroupGeneralPolicyResponse ShowGroupGeneralPolicy(ShowGroupGeneralPolicyRequest showGroupGeneralPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupGeneralPolicyRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/policies/general", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupGeneralPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGroupGeneralPolicyResponse>(response);
        }

        public SyncInvoker<ShowGroupGeneralPolicyResponse> ShowGroupGeneralPolicyInvoker(ShowGroupGeneralPolicyRequest showGroupGeneralPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupGeneralPolicyRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/policies/general", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupGeneralPolicyRequest);
            return new SyncInvoker<ShowGroupGeneralPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGroupGeneralPolicyResponse>);
        }
        
        /// <summary>
        /// 获取代码组继承设置项
        ///
        /// 获取代码组继承设置项
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGroupInheritSettingResponse ShowGroupInheritSetting(ShowGroupInheritSettingRequest showGroupInheritSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupInheritSettingRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/inherit-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupInheritSettingRequest);
            var response = DoHttpRequestSync("GET", request);
            var showGroupInheritSettingResponse = JsonUtils.DeSerializeNull<ShowGroupInheritSettingResponse>(response);
            showGroupInheritSettingResponse.Body = JsonUtils.DeSerializeList<ProjectSettingsInheritCfgDto>(response);
            return showGroupInheritSettingResponse;
        }

        public SyncInvoker<ShowGroupInheritSettingResponse> ShowGroupInheritSettingInvoker(ShowGroupInheritSettingRequest showGroupInheritSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupInheritSettingRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/inherit-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupInheritSettingRequest);
            return new SyncInvoker<ShowGroupInheritSettingResponse>(this, "GET", request, response =>
            {
                var showGroupInheritSettingResponse = JsonUtils.DeSerializeNull<ShowGroupInheritSettingResponse>(response);
                showGroupInheritSettingResponse.Body = JsonUtils.DeSerializeList<ProjectSettingsInheritCfgDto>(response);
                return showGroupInheritSettingResponse;
            });
        }
        
        /// <summary>
        /// 获取代码组继承权限设置开关
        ///
        /// 获取代码组继承权限设置开关
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGroupPermissionInheritEnabledResponse ShowGroupPermissionInheritEnabled(ShowGroupPermissionInheritEnabledRequest showGroupPermissionInheritEnabledRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupPermissionInheritEnabledRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/permission-inherit-enabled", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupPermissionInheritEnabledRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGroupPermissionInheritEnabledResponse>(response);
        }

        public SyncInvoker<ShowGroupPermissionInheritEnabledResponse> ShowGroupPermissionInheritEnabledInvoker(ShowGroupPermissionInheritEnabledRequest showGroupPermissionInheritEnabledRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupPermissionInheritEnabledRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/permission-inherit-enabled", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupPermissionInheritEnabledRequest);
            return new SyncInvoker<ShowGroupPermissionInheritEnabledResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGroupPermissionInheritEnabledResponse>);
        }
        
        /// <summary>
        /// 获取代码组继承设置项
        ///
        /// 获取代码组继承设置项
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGroupSettingsInheritCfgResponse ShowGroupSettingsInheritCfg(ShowGroupSettingsInheritCfgRequest showGroupSettingsInheritCfgRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupSettingsInheritCfgRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/settings-inherit-cfg", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupSettingsInheritCfgRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGroupSettingsInheritCfgResponse>(response);
        }

        public SyncInvoker<ShowGroupSettingsInheritCfgResponse> ShowGroupSettingsInheritCfgInvoker(ShowGroupSettingsInheritCfgRequest showGroupSettingsInheritCfgRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupSettingsInheritCfgRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/settings-inherit-cfg", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupSettingsInheritCfgRequest);
            return new SyncInvoker<ShowGroupSettingsInheritCfgResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGroupSettingsInheritCfgResponse>);
        }
        
        /// <summary>
        /// 获取代码组水印设置
        ///
        /// 获取代码组水印设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGroupWatermarkResponse ShowGroupWatermark(ShowGroupWatermarkRequest showGroupWatermarkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupWatermarkRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupWatermarkRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGroupWatermarkResponse>(response);
        }

        public SyncInvoker<ShowGroupWatermarkResponse> ShowGroupWatermarkInvoker(ShowGroupWatermarkRequest showGroupWatermarkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupWatermarkRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupWatermarkRequest);
            return new SyncInvoker<ShowGroupWatermarkResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGroupWatermarkResponse>);
        }
        
        /// <summary>
        /// 获取指定代码组的基本设置信息
        ///
        /// 获取指定代码组的基本设置信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGroupsGeneralPolicyResponse ShowGroupsGeneralPolicy(ShowGroupsGeneralPolicyRequest showGroupsGeneralPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupsGeneralPolicyRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/general-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupsGeneralPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGroupsGeneralPolicyResponse>(response);
        }

        public SyncInvoker<ShowGroupsGeneralPolicyResponse> ShowGroupsGeneralPolicyInvoker(ShowGroupsGeneralPolicyRequest showGroupsGeneralPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupsGeneralPolicyRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/general-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupsGeneralPolicyRequest);
            return new SyncInvoker<ShowGroupsGeneralPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGroupsGeneralPolicyResponse>);
        }
        
        /// <summary>
        /// 获取代码组的继承设置
        ///
        /// 获取代码组的继承设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGroupsInheritResponse ShowGroupsInherit(ShowGroupsInheritRequest showGroupsInheritRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupsInheritRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/inherit", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupsInheritRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGroupsInheritResponse>(response);
        }

        public SyncInvoker<ShowGroupsInheritResponse> ShowGroupsInheritInvoker(ShowGroupsInheritRequest showGroupsInheritRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupsInheritRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/inherit", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupsInheritRequest);
            return new SyncInvoker<ShowGroupsInheritResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGroupsInheritResponse>);
        }
        
        /// <summary>
        /// 移交代码组
        ///
        /// 移交代码组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public TransferGroupResponse TransferGroup(TransferGroupRequest transferGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(transferGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/transfer", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", transferGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<TransferGroupResponse>(response);
        }

        public SyncInvoker<TransferGroupResponse> TransferGroupInvoker(TransferGroupRequest transferGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(transferGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/transfer", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", transferGroupRequest);
            return new SyncInvoker<TransferGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<TransferGroupResponse>);
        }
        
        /// <summary>
        /// 更新代码组的基本设置信息
        ///
        /// 更新代码组的基本设置信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGroupGeneralPolicyResponse UpdateGroupGeneralPolicy(UpdateGroupGeneralPolicyRequest updateGroupGeneralPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateGroupGeneralPolicyRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/general-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGroupGeneralPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGroupGeneralPolicyResponse>(response);
        }

        public SyncInvoker<UpdateGroupGeneralPolicyResponse> UpdateGroupGeneralPolicyInvoker(UpdateGroupGeneralPolicyRequest updateGroupGeneralPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateGroupGeneralPolicyRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/general-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGroupGeneralPolicyRequest);
            return new SyncInvoker<UpdateGroupGeneralPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGroupGeneralPolicyResponse>);
        }
        
        /// <summary>
        /// 更新代码组水印设置
        ///
        /// 更新代码组水印设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGroupWatermarkResponse UpdateGroupWatermark(UpdateGroupWatermarkRequest updateGroupWatermarkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateGroupWatermarkRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGroupWatermarkRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGroupWatermarkResponse>(response);
        }

        public SyncInvoker<UpdateGroupWatermarkResponse> UpdateGroupWatermarkInvoker(UpdateGroupWatermarkRequest updateGroupWatermarkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateGroupWatermarkRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGroupWatermarkRequest);
            return new SyncInvoker<UpdateGroupWatermarkResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGroupWatermarkResponse>);
        }
        
        /// <summary>
        /// 批量添加仓库成员
        ///
        /// 批量添加仓库成员
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddRepositoryMembersResponse AddRepositoryMembers(AddRepositoryMembersRequest addRepositoryMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addRepositoryMembersRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addRepositoryMembersRequest);
            var response = DoHttpRequestSync("POST", request);
            var addRepositoryMembersResponse = JsonUtils.DeSerializeNull<AddRepositoryMembersResponse>(response);
            addRepositoryMembersResponse.Body = JsonUtils.DeSerializeList<BatchCreateRepositoryMemberDto>(response);
            return addRepositoryMembersResponse;
        }

        public SyncInvoker<AddRepositoryMembersResponse> AddRepositoryMembersInvoker(AddRepositoryMembersRequest addRepositoryMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addRepositoryMembersRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addRepositoryMembersRequest);
            return new SyncInvoker<AddRepositoryMembersResponse>(this, "POST", request, response =>
            {
                var addRepositoryMembersResponse = JsonUtils.DeSerializeNull<AddRepositoryMembersResponse>(response);
                addRepositoryMembersResponse.Body = JsonUtils.DeSerializeList<BatchCreateRepositoryMemberDto>(response);
                return addRepositoryMembersResponse;
            });
        }
        
        /// <summary>
        /// 获取代码组下成员组列表
        ///
        /// 获取代码组下成员组列表(保护分支保护Tags设置中使用)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGroupProtectedRefsUserGroupsResponse ListGroupProtectedRefsUserGroups(ListGroupProtectedRefsUserGroupsRequest listGroupProtectedRefsUserGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupProtectedRefsUserGroupsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/protected-refs/user-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupProtectedRefsUserGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listGroupProtectedRefsUserGroupsResponse = JsonUtils.DeSerializeNull<ListGroupProtectedRefsUserGroupsResponse>(response);
            listGroupProtectedRefsUserGroupsResponse.Body = JsonUtils.DeSerializeList<ProtectedRefsUserGroupBasicDto>(response);
            return listGroupProtectedRefsUserGroupsResponse;
        }

        public SyncInvoker<ListGroupProtectedRefsUserGroupsResponse> ListGroupProtectedRefsUserGroupsInvoker(ListGroupProtectedRefsUserGroupsRequest listGroupProtectedRefsUserGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupProtectedRefsUserGroupsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/protected-refs/user-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupProtectedRefsUserGroupsRequest);
            return new SyncInvoker<ListGroupProtectedRefsUserGroupsResponse>(this, "GET", request, response =>
            {
                var listGroupProtectedRefsUserGroupsResponse = JsonUtils.DeSerializeNull<ListGroupProtectedRefsUserGroupsResponse>(response);
                listGroupProtectedRefsUserGroupsResponse.Body = JsonUtils.DeSerializeList<ProtectedRefsUserGroupBasicDto>(response);
                return listGroupProtectedRefsUserGroupsResponse;
            });
        }
        
        /// <summary>
        /// 获取仓库成员列表
        ///
        /// 获取仓库成员列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMembersResponse ListMembers(ListMembersRequest listMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMembersRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMembersRequest);
            var response = DoHttpRequestSync("GET", request);
            var listMembersResponse = JsonUtils.DeSerializeNull<ListMembersResponse>(response);
            listMembersResponse.Body = JsonUtils.DeSerializeList<RepositoryMemberDto>(response);
            return listMembersResponse;
        }

        public SyncInvoker<ListMembersResponse> ListMembersInvoker(ListMembersRequest listMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMembersRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMembersRequest);
            return new SyncInvoker<ListMembersResponse>(this, "GET", request, response =>
            {
                var listMembersResponse = JsonUtils.DeSerializeNull<ListMembersResponse>(response);
                listMembersResponse.Body = JsonUtils.DeSerializeList<RepositoryMemberDto>(response);
                return listMembersResponse;
            });
        }
        
        /// <summary>
        /// 获取项目下成员列表
        ///
        /// 获取项目下成员列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProductPermissionResourcesGrantedUsersResponse ListProductPermissionResourcesGrantedUsers(ListProductPermissionResourcesGrantedUsersRequest listProductPermissionResourcesGrantedUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProductPermissionResourcesGrantedUsersRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProductPermissionResourcesGrantedUsersRequest);
            var response = DoHttpRequestSync("GET", request);
            var listProductPermissionResourcesGrantedUsersResponse = JsonUtils.DeSerializeNull<ListProductPermissionResourcesGrantedUsersResponse>(response);
            listProductPermissionResourcesGrantedUsersResponse.Body = JsonUtils.DeSerializeList<GrantedUsersDto>(response);
            return listProductPermissionResourcesGrantedUsersResponse;
        }

        public SyncInvoker<ListProductPermissionResourcesGrantedUsersResponse> ListProductPermissionResourcesGrantedUsersInvoker(ListProductPermissionResourcesGrantedUsersRequest listProductPermissionResourcesGrantedUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProductPermissionResourcesGrantedUsersRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProductPermissionResourcesGrantedUsersRequest);
            return new SyncInvoker<ListProductPermissionResourcesGrantedUsersResponse>(this, "GET", request, response =>
            {
                var listProductPermissionResourcesGrantedUsersResponse = JsonUtils.DeSerializeNull<ListProductPermissionResourcesGrantedUsersResponse>(response);
                listProductPermissionResourcesGrantedUsersResponse.Body = JsonUtils.DeSerializeList<GrantedUsersDto>(response);
                return listProductPermissionResourcesGrantedUsersResponse;
            });
        }
        
        /// <summary>
        /// 获取项目下成员组列表
        ///
        /// 获取项目下成员组列表(保护分支保护Tags设置中使用)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProjectProtectedRefsUserGroupsResponse ListProjectProtectedRefsUserGroups(ListProjectProtectedRefsUserGroupsRequest listProjectProtectedRefsUserGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectProtectedRefsUserGroupsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/protected-refs/user-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectProtectedRefsUserGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listProjectProtectedRefsUserGroupsResponse = JsonUtils.DeSerializeNull<ListProjectProtectedRefsUserGroupsResponse>(response);
            listProjectProtectedRefsUserGroupsResponse.Body = JsonUtils.DeSerializeList<ProtectedRefsUserGroupBasicDto>(response);
            return listProjectProtectedRefsUserGroupsResponse;
        }

        public SyncInvoker<ListProjectProtectedRefsUserGroupsResponse> ListProjectProtectedRefsUserGroupsInvoker(ListProjectProtectedRefsUserGroupsRequest listProjectProtectedRefsUserGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectProtectedRefsUserGroupsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/protected-refs/user-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectProtectedRefsUserGroupsRequest);
            return new SyncInvoker<ListProjectProtectedRefsUserGroupsResponse>(this, "GET", request, response =>
            {
                var listProjectProtectedRefsUserGroupsResponse = JsonUtils.DeSerializeNull<ListProjectProtectedRefsUserGroupsResponse>(response);
                listProjectProtectedRefsUserGroupsResponse.Body = JsonUtils.DeSerializeList<ProtectedRefsUserGroupBasicDto>(response);
                return listProjectProtectedRefsUserGroupsResponse;
            });
        }
        
        /// <summary>
        /// 获取仓库下成员组列表
        ///
        /// 获取仓库下成员组列表(保护分支保护Tags设置中使用)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRepositoryProtectedRefsUserGroupsResponse ListRepositoryProtectedRefsUserGroups(ListRepositoryProtectedRefsUserGroupsRequest listRepositoryProtectedRefsUserGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryProtectedRefsUserGroupsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-refs/user-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryProtectedRefsUserGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listRepositoryProtectedRefsUserGroupsResponse = JsonUtils.DeSerializeNull<ListRepositoryProtectedRefsUserGroupsResponse>(response);
            listRepositoryProtectedRefsUserGroupsResponse.Body = JsonUtils.DeSerializeList<ProtectedRefsUserGroupBasicDto>(response);
            return listRepositoryProtectedRefsUserGroupsResponse;
        }

        public SyncInvoker<ListRepositoryProtectedRefsUserGroupsResponse> ListRepositoryProtectedRefsUserGroupsInvoker(ListRepositoryProtectedRefsUserGroupsRequest listRepositoryProtectedRefsUserGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryProtectedRefsUserGroupsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-refs/user-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryProtectedRefsUserGroupsRequest);
            return new SyncInvoker<ListRepositoryProtectedRefsUserGroupsResponse>(this, "GET", request, response =>
            {
                var listRepositoryProtectedRefsUserGroupsResponse = JsonUtils.DeSerializeNull<ListRepositoryProtectedRefsUserGroupsResponse>(response);
                listRepositoryProtectedRefsUserGroupsResponse.Body = JsonUtils.DeSerializeList<ProtectedRefsUserGroupBasicDto>(response);
                return listRepositoryProtectedRefsUserGroupsResponse;
            });
        }
        
        /// <summary>
        /// 获取成员组列表
        ///
        /// 获取成员组列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRepositoryUserGroupsResponse ListRepositoryUserGroups(ListRepositoryUserGroupsRequest listRepositoryUserGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryUserGroupsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/user-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryUserGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listRepositoryUserGroupsResponse = JsonUtils.DeSerializeNull<ListRepositoryUserGroupsResponse>(response);
            listRepositoryUserGroupsResponse.Body = JsonUtils.DeSerializeList<RepositoryUserGroupDto>(response);
            return listRepositoryUserGroupsResponse;
        }

        public SyncInvoker<ListRepositoryUserGroupsResponse> ListRepositoryUserGroupsInvoker(ListRepositoryUserGroupsRequest listRepositoryUserGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryUserGroupsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/user-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryUserGroupsRequest);
            return new SyncInvoker<ListRepositoryUserGroupsResponse>(this, "GET", request, response =>
            {
                var listRepositoryUserGroupsResponse = JsonUtils.DeSerializeNull<ListRepositoryUserGroupsResponse>(response);
                listRepositoryUserGroupsResponse.Body = JsonUtils.DeSerializeList<RepositoryUserGroupDto>(response);
                return listRepositoryUserGroupsResponse;
            });
        }
        
        /// <summary>
        /// 审核合并请求
        ///
        /// 审核合并请求
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ApprovalMergeRequestResponse ApprovalMergeRequest(ApprovalMergeRequestRequest approvalMergeRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(approvalMergeRequestRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(approvalMergeRequestRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/approval", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", approvalMergeRequestRequest);
            var response = DoHttpRequestSync("PUT", request);
            var approvalMergeRequestResponse = JsonUtils.DeSerializeNull<ApprovalMergeRequestResponse>(response);
            approvalMergeRequestResponse.Body = JsonUtils.DeSerializeList<ApproverBasicDto>(response);
            return approvalMergeRequestResponse;
        }

        public SyncInvoker<ApprovalMergeRequestResponse> ApprovalMergeRequestInvoker(ApprovalMergeRequestRequest approvalMergeRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(approvalMergeRequestRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(approvalMergeRequestRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/approval", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", approvalMergeRequestRequest);
            return new SyncInvoker<ApprovalMergeRequestResponse>(this, "PUT", request, response =>
            {
                var approvalMergeRequestResponse = JsonUtils.DeSerializeNull<ApprovalMergeRequestResponse>(response);
                approvalMergeRequestResponse.Body = JsonUtils.DeSerializeList<ApproverBasicDto>(response);
                return approvalMergeRequestResponse;
            });
        }
        
        /// <summary>
        /// Cherry pick合并请求
        ///
        /// Cherry pick合并请求
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateCherryPickMergeRequestResponse CreateCherryPickMergeRequest(CreateCherryPickMergeRequestRequest createCherryPickMergeRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createCherryPickMergeRequestRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(createCherryPickMergeRequestRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/cherry-pick", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCherryPickMergeRequestRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateCherryPickMergeRequestResponse>(response);
        }

        public SyncInvoker<CreateCherryPickMergeRequestResponse> CreateCherryPickMergeRequestInvoker(CreateCherryPickMergeRequestRequest createCherryPickMergeRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createCherryPickMergeRequestRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(createCherryPickMergeRequestRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/cherry-pick", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCherryPickMergeRequestRequest);
            return new SyncInvoker<CreateCherryPickMergeRequestResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCherryPickMergeRequestResponse>);
        }
        
        /// <summary>
        /// 创建代码组合并请求审核设置
        ///
        /// 创建代码组合并请求审核设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateGroupMergeRequestApproverSettingResponse CreateGroupMergeRequestApproverSetting(CreateGroupMergeRequestApproverSettingRequest createGroupMergeRequestApproverSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createGroupMergeRequestApproverSettingRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/approver-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGroupMergeRequestApproverSettingRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateGroupMergeRequestApproverSettingResponse>(response);
        }

        public SyncInvoker<CreateGroupMergeRequestApproverSettingResponse> CreateGroupMergeRequestApproverSettingInvoker(CreateGroupMergeRequestApproverSettingRequest createGroupMergeRequestApproverSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createGroupMergeRequestApproverSettingRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/approver-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGroupMergeRequestApproverSettingRequest);
            return new SyncInvoker<CreateGroupMergeRequestApproverSettingResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGroupMergeRequestApproverSettingResponse>);
        }
        
        /// <summary>
        /// 创建代码组合并请求模板
        ///
        /// 创建代码组合并请求模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateGroupMergeRequestTemplateResponse CreateGroupMergeRequestTemplate(CreateGroupMergeRequestTemplateRequest createGroupMergeRequestTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createGroupMergeRequestTemplateRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/merge-requests/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGroupMergeRequestTemplateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateGroupMergeRequestTemplateResponse>(response);
        }

        public SyncInvoker<CreateGroupMergeRequestTemplateResponse> CreateGroupMergeRequestTemplateInvoker(CreateGroupMergeRequestTemplateRequest createGroupMergeRequestTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createGroupMergeRequestTemplateRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/merge-requests/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGroupMergeRequestTemplateRequest);
            return new SyncInvoker<CreateGroupMergeRequestTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGroupMergeRequestTemplateResponse>);
        }
        
        /// <summary>
        /// 创建合并请求
        ///
        /// 创建合并请求
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateMergeRequestResponse CreateMergeRequest(CreateMergeRequestRequest createMergeRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMergeRequestRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateMergeRequestResponse>(response);
        }

        public SyncInvoker<CreateMergeRequestResponse> CreateMergeRequestInvoker(CreateMergeRequestRequest createMergeRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMergeRequestRequest);
            return new SyncInvoker<CreateMergeRequestResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMergeRequestResponse>);
        }
        
        /// <summary>
        /// 创建合并请求审核设置
        ///
        /// 创建合并请求审核设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateMergeRequestApproverSettingResponse CreateMergeRequestApproverSetting(CreateMergeRequestApproverSettingRequest createMergeRequestApproverSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestApproverSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/approver-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMergeRequestApproverSettingRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateMergeRequestApproverSettingResponse>(response);
        }

        public SyncInvoker<CreateMergeRequestApproverSettingResponse> CreateMergeRequestApproverSettingInvoker(CreateMergeRequestApproverSettingRequest createMergeRequestApproverSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestApproverSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/approver-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMergeRequestApproverSettingRequest);
            return new SyncInvoker<CreateMergeRequestApproverSettingResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMergeRequestApproverSettingResponse>);
        }
        
        /// <summary>
        /// 创建合并请求模板
        ///
        /// 创建合并请求模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateMergeRequestTemplateResponse CreateMergeRequestTemplate(CreateMergeRequestTemplateRequest createMergeRequestTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestTemplateRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMergeRequestTemplateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateMergeRequestTemplateResponse>(response);
        }

        public SyncInvoker<CreateMergeRequestTemplateResponse> CreateMergeRequestTemplateInvoker(CreateMergeRequestTemplateRequest createMergeRequestTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestTemplateRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMergeRequestTemplateRequest);
            return new SyncInvoker<CreateMergeRequestTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMergeRequestTemplateResponse>);
        }
        
        /// <summary>
        /// 创建项目合并请求审核设置
        ///
        /// 创建项目合并请求审核设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateProjectMergeRequestApproverSettingResponse CreateProjectMergeRequestApproverSetting(CreateProjectMergeRequestApproverSettingRequest createProjectMergeRequestApproverSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createProjectMergeRequestApproverSettingRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/approver-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProjectMergeRequestApproverSettingRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateProjectMergeRequestApproverSettingResponse>(response);
        }

        public SyncInvoker<CreateProjectMergeRequestApproverSettingResponse> CreateProjectMergeRequestApproverSettingInvoker(CreateProjectMergeRequestApproverSettingRequest createProjectMergeRequestApproverSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createProjectMergeRequestApproverSettingRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/approver-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProjectMergeRequestApproverSettingRequest);
            return new SyncInvoker<CreateProjectMergeRequestApproverSettingResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateProjectMergeRequestApproverSettingResponse>);
        }
        
        /// <summary>
        /// 创建项目合并请求模板
        ///
        /// 创建项目合并请求模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateProjectMergeRequestTemplateResponse CreateProjectMergeRequestTemplate(CreateProjectMergeRequestTemplateRequest createProjectMergeRequestTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createProjectMergeRequestTemplateRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/merge-requests/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProjectMergeRequestTemplateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateProjectMergeRequestTemplateResponse>(response);
        }

        public SyncInvoker<CreateProjectMergeRequestTemplateResponse> CreateProjectMergeRequestTemplateInvoker(CreateProjectMergeRequestTemplateRequest createProjectMergeRequestTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createProjectMergeRequestTemplateRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/merge-requests/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProjectMergeRequestTemplateRequest);
            return new SyncInvoker<CreateProjectMergeRequestTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateProjectMergeRequestTemplateResponse>);
        }
        
        /// <summary>
        /// 删除代码组合并请求审核配置
        ///
        /// 删除代码组合并请求审核配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteGroupMergeRequestApproverSettingResponse DeleteGroupMergeRequestApproverSetting(DeleteGroupMergeRequestApproverSettingRequest deleteGroupMergeRequestApproverSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupMergeRequestApproverSettingRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupMergeRequestApproverSettingRequest.SettingId, out var valueOfSettingId)) urlParam.Add("setting_id", valueOfSettingId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/approver-settings/{setting_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGroupMergeRequestApproverSettingRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteGroupMergeRequestApproverSettingResponse>(response);
        }

        public SyncInvoker<DeleteGroupMergeRequestApproverSettingResponse> DeleteGroupMergeRequestApproverSettingInvoker(DeleteGroupMergeRequestApproverSettingRequest deleteGroupMergeRequestApproverSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupMergeRequestApproverSettingRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupMergeRequestApproverSettingRequest.SettingId, out var valueOfSettingId)) urlParam.Add("setting_id", valueOfSettingId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/approver-settings/{setting_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGroupMergeRequestApproverSettingRequest);
            return new SyncInvoker<DeleteGroupMergeRequestApproverSettingResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteGroupMergeRequestApproverSettingResponse>);
        }
        
        /// <summary>
        /// 删除代码组合并请求模板
        ///
        /// 删除代码组合并请求模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteGroupMergeRequestTemplateResponse DeleteGroupMergeRequestTemplate(DeleteGroupMergeRequestTemplateRequest deleteGroupMergeRequestTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupMergeRequestTemplateRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupMergeRequestTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/merge-requests/template/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGroupMergeRequestTemplateRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteGroupMergeRequestTemplateResponse>(response);
        }

        public SyncInvoker<DeleteGroupMergeRequestTemplateResponse> DeleteGroupMergeRequestTemplateInvoker(DeleteGroupMergeRequestTemplateRequest deleteGroupMergeRequestTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupMergeRequestTemplateRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupMergeRequestTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/merge-requests/template/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGroupMergeRequestTemplateRequest);
            return new SyncInvoker<DeleteGroupMergeRequestTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteGroupMergeRequestTemplateResponse>);
        }
        
        /// <summary>
        /// 删除合并请求审核配置
        ///
        /// 删除合并请求审核配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteMergeRequestApproverSettingResponse DeleteMergeRequestApproverSetting(DeleteMergeRequestApproverSettingRequest deleteMergeRequestApproverSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteMergeRequestApproverSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(deleteMergeRequestApproverSettingRequest.SettingId, out var valueOfSettingId)) urlParam.Add("setting_id", valueOfSettingId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/approver-settings/{setting_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMergeRequestApproverSettingRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteMergeRequestApproverSettingResponse>(response);
        }

        public SyncInvoker<DeleteMergeRequestApproverSettingResponse> DeleteMergeRequestApproverSettingInvoker(DeleteMergeRequestApproverSettingRequest deleteMergeRequestApproverSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteMergeRequestApproverSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(deleteMergeRequestApproverSettingRequest.SettingId, out var valueOfSettingId)) urlParam.Add("setting_id", valueOfSettingId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/approver-settings/{setting_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMergeRequestApproverSettingRequest);
            return new SyncInvoker<DeleteMergeRequestApproverSettingResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteMergeRequestApproverSettingResponse>);
        }
        
        /// <summary>
        /// 删除合并请求模板
        ///
        /// 删除合并请求模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteMergeRequestTemplateResponse DeleteMergeRequestTemplate(DeleteMergeRequestTemplateRequest deleteMergeRequestTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteMergeRequestTemplateRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(deleteMergeRequestTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/template/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMergeRequestTemplateRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteMergeRequestTemplateResponse>(response);
        }

        public SyncInvoker<DeleteMergeRequestTemplateResponse> DeleteMergeRequestTemplateInvoker(DeleteMergeRequestTemplateRequest deleteMergeRequestTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteMergeRequestTemplateRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(deleteMergeRequestTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/template/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMergeRequestTemplateRequest);
            return new SyncInvoker<DeleteMergeRequestTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteMergeRequestTemplateResponse>);
        }
        
        /// <summary>
        /// 删除合并请求打分
        ///
        /// 删除合并请求打分
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteMergeRequestVoteResponse DeleteMergeRequestVote(DeleteMergeRequestVoteRequest deleteMergeRequestVoteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteMergeRequestVoteRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(deleteMergeRequestVoteRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/vote", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMergeRequestVoteRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteMergeRequestVoteResponse>(response);
        }

        public SyncInvoker<DeleteMergeRequestVoteResponse> DeleteMergeRequestVoteInvoker(DeleteMergeRequestVoteRequest deleteMergeRequestVoteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteMergeRequestVoteRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(deleteMergeRequestVoteRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/vote", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMergeRequestVoteRequest);
            return new SyncInvoker<DeleteMergeRequestVoteResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteMergeRequestVoteResponse>);
        }
        
        /// <summary>
        /// 删除项目合并请求审核配置
        ///
        /// 删除项目合并请求审核配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteProjectMergeRequestApproverSettingResponse DeleteProjectMergeRequestApproverSetting(DeleteProjectMergeRequestApproverSettingRequest deleteProjectMergeRequestApproverSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteProjectMergeRequestApproverSettingRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deleteProjectMergeRequestApproverSettingRequest.SettingId, out var valueOfSettingId)) urlParam.Add("setting_id", valueOfSettingId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/approver-settings/{setting_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProjectMergeRequestApproverSettingRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteProjectMergeRequestApproverSettingResponse>(response);
        }

        public SyncInvoker<DeleteProjectMergeRequestApproverSettingResponse> DeleteProjectMergeRequestApproverSettingInvoker(DeleteProjectMergeRequestApproverSettingRequest deleteProjectMergeRequestApproverSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteProjectMergeRequestApproverSettingRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deleteProjectMergeRequestApproverSettingRequest.SettingId, out var valueOfSettingId)) urlParam.Add("setting_id", valueOfSettingId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/approver-settings/{setting_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProjectMergeRequestApproverSettingRequest);
            return new SyncInvoker<DeleteProjectMergeRequestApproverSettingResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteProjectMergeRequestApproverSettingResponse>);
        }
        
        /// <summary>
        /// 删除项目合并请求模板
        ///
        /// 删除项目合并请求模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteProjectMergeRequestTemplateResponse DeleteProjectMergeRequestTemplate(DeleteProjectMergeRequestTemplateRequest deleteProjectMergeRequestTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteProjectMergeRequestTemplateRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deleteProjectMergeRequestTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/merge-requests/template/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProjectMergeRequestTemplateRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteProjectMergeRequestTemplateResponse>(response);
        }

        public SyncInvoker<DeleteProjectMergeRequestTemplateResponse> DeleteProjectMergeRequestTemplateInvoker(DeleteProjectMergeRequestTemplateRequest deleteProjectMergeRequestTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteProjectMergeRequestTemplateRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deleteProjectMergeRequestTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/merge-requests/template/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProjectMergeRequestTemplateRequest);
            return new SyncInvoker<DeleteProjectMergeRequestTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteProjectMergeRequestTemplateResponse>);
        }
        
        /// <summary>
        /// 导入合并请求
        ///
        /// 导入合并请求
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ImportMergeRequestResponse ImportMergeRequest(ImportMergeRequestRequest importMergeRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(importMergeRequestRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/import-merge-requests", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", importMergeRequestRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ImportMergeRequestResponse>(response);
        }

        public SyncInvoker<ImportMergeRequestResponse> ImportMergeRequestInvoker(ImportMergeRequestRequest importMergeRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(importMergeRequestRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/import-merge-requests", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", importMergeRequestRequest);
            return new SyncInvoker<ImportMergeRequestResponse>(this, "POST", request, JsonUtils.DeSerialize<ImportMergeRequestResponse>);
        }
        
        /// <summary>
        /// 获取提交关联的合并请求
        ///
        /// 获取提交关联的合并请求
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCommitAssociatedMergeRequestsResponse ListCommitAssociatedMergeRequests(ListCommitAssociatedMergeRequestsRequest listCommitAssociatedMergeRequestsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listCommitAssociatedMergeRequestsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listCommitAssociatedMergeRequestsRequest.Sha, out var valueOfSha)) urlParam.Add("sha", valueOfSha);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/commits/{sha}/merge-requests", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCommitAssociatedMergeRequestsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listCommitAssociatedMergeRequestsResponse = JsonUtils.DeSerializeNull<ListCommitAssociatedMergeRequestsResponse>(response);
            listCommitAssociatedMergeRequestsResponse.Body = JsonUtils.DeSerializeList<CommitMergeRequestDto>(response);
            return listCommitAssociatedMergeRequestsResponse;
        }

        public SyncInvoker<ListCommitAssociatedMergeRequestsResponse> ListCommitAssociatedMergeRequestsInvoker(ListCommitAssociatedMergeRequestsRequest listCommitAssociatedMergeRequestsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listCommitAssociatedMergeRequestsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listCommitAssociatedMergeRequestsRequest.Sha, out var valueOfSha)) urlParam.Add("sha", valueOfSha);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/commits/{sha}/merge-requests", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCommitAssociatedMergeRequestsRequest);
            return new SyncInvoker<ListCommitAssociatedMergeRequestsResponse>(this, "GET", request, response =>
            {
                var listCommitAssociatedMergeRequestsResponse = JsonUtils.DeSerializeNull<ListCommitAssociatedMergeRequestsResponse>(response);
                listCommitAssociatedMergeRequestsResponse.Body = JsonUtils.DeSerializeList<CommitMergeRequestDto>(response);
                return listCommitAssociatedMergeRequestsResponse;
            });
        }
        
        /// <summary>
        /// 获取检视意见模板列表
        ///
        /// 获取检视意见模板列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDiscussionTemplatesResponse ListDiscussionTemplates(ListDiscussionTemplatesRequest listDiscussionTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDiscussionTemplatesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/discussion/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDiscussionTemplatesRequest);
            var response = DoHttpRequestSync("GET", request);
            var listDiscussionTemplatesResponse = JsonUtils.DeSerializeNull<ListDiscussionTemplatesResponse>(response);
            listDiscussionTemplatesResponse.Body = JsonUtils.DeSerializeList<DiscussionTemplateDto>(response);
            return listDiscussionTemplatesResponse;
        }

        public SyncInvoker<ListDiscussionTemplatesResponse> ListDiscussionTemplatesInvoker(ListDiscussionTemplatesRequest listDiscussionTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDiscussionTemplatesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/discussion/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDiscussionTemplatesRequest);
            return new SyncInvoker<ListDiscussionTemplatesResponse>(this, "GET", request, response =>
            {
                var listDiscussionTemplatesResponse = JsonUtils.DeSerializeNull<ListDiscussionTemplatesResponse>(response);
                listDiscussionTemplatesResponse.Body = JsonUtils.DeSerializeList<DiscussionTemplateDto>(response);
                return listDiscussionTemplatesResponse;
            });
        }
        
        /// <summary>
        /// 获取代码组合并请求审核设置列表
        ///
        /// 获取代码组合并请求审核设置列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGroupMergeRequestApproverSettingsResponse ListGroupMergeRequestApproverSettings(ListGroupMergeRequestApproverSettingsRequest listGroupMergeRequestApproverSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupMergeRequestApproverSettingsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/approver-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupMergeRequestApproverSettingsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listGroupMergeRequestApproverSettingsResponse = JsonUtils.DeSerializeNull<ListGroupMergeRequestApproverSettingsResponse>(response);
            listGroupMergeRequestApproverSettingsResponse.Body = JsonUtils.DeSerializeList<MergeRequestApproverSettingResultDto>(response);
            return listGroupMergeRequestApproverSettingsResponse;
        }

        public SyncInvoker<ListGroupMergeRequestApproverSettingsResponse> ListGroupMergeRequestApproverSettingsInvoker(ListGroupMergeRequestApproverSettingsRequest listGroupMergeRequestApproverSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupMergeRequestApproverSettingsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/approver-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupMergeRequestApproverSettingsRequest);
            return new SyncInvoker<ListGroupMergeRequestApproverSettingsResponse>(this, "GET", request, response =>
            {
                var listGroupMergeRequestApproverSettingsResponse = JsonUtils.DeSerializeNull<ListGroupMergeRequestApproverSettingsResponse>(response);
                listGroupMergeRequestApproverSettingsResponse.Body = JsonUtils.DeSerializeList<MergeRequestApproverSettingResultDto>(response);
                return listGroupMergeRequestApproverSettingsResponse;
            });
        }
        
        /// <summary>
        /// 获取代码组检视人
        ///
        /// 获取代码组检视人
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGroupMergeRequestCanBeAssignedReviewersResponse ListGroupMergeRequestCanBeAssignedReviewers(ListGroupMergeRequestCanBeAssignedReviewersRequest listGroupMergeRequestCanBeAssignedReviewersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupMergeRequestCanBeAssignedReviewersRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/merge-requests/reviewers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupMergeRequestCanBeAssignedReviewersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListGroupMergeRequestCanBeAssignedReviewersResponse>(response);
        }

        public SyncInvoker<ListGroupMergeRequestCanBeAssignedReviewersResponse> ListGroupMergeRequestCanBeAssignedReviewersInvoker(ListGroupMergeRequestCanBeAssignedReviewersRequest listGroupMergeRequestCanBeAssignedReviewersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupMergeRequestCanBeAssignedReviewersRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/merge-requests/reviewers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupMergeRequestCanBeAssignedReviewersRequest);
            return new SyncInvoker<ListGroupMergeRequestCanBeAssignedReviewersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGroupMergeRequestCanBeAssignedReviewersResponse>);
        }
        
        /// <summary>
        /// 获取代码组合并请求模板列表
        ///
        /// 获取代码组合并请求模板列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGroupMergeRequestTemplatesResponse ListGroupMergeRequestTemplates(ListGroupMergeRequestTemplatesRequest listGroupMergeRequestTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupMergeRequestTemplatesRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/merge-requests/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupMergeRequestTemplatesRequest);
            var response = DoHttpRequestSync("GET", request);
            var listGroupMergeRequestTemplatesResponse = JsonUtils.DeSerializeNull<ListGroupMergeRequestTemplatesResponse>(response);
            listGroupMergeRequestTemplatesResponse.Body = JsonUtils.DeSerializeList<GroupMergeRequestTemplateDto>(response);
            return listGroupMergeRequestTemplatesResponse;
        }

        public SyncInvoker<ListGroupMergeRequestTemplatesResponse> ListGroupMergeRequestTemplatesInvoker(ListGroupMergeRequestTemplatesRequest listGroupMergeRequestTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupMergeRequestTemplatesRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/merge-requests/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupMergeRequestTemplatesRequest);
            return new SyncInvoker<ListGroupMergeRequestTemplatesResponse>(this, "GET", request, response =>
            {
                var listGroupMergeRequestTemplatesResponse = JsonUtils.DeSerializeNull<ListGroupMergeRequestTemplatesResponse>(response);
                listGroupMergeRequestTemplatesResponse.Body = JsonUtils.DeSerializeList<GroupMergeRequestTemplateDto>(response);
                return listGroupMergeRequestTemplatesResponse;
            });
        }
        
        /// <summary>
        /// 获取代码组审核人或合并人
        ///
        /// 获取代码组审核人或合并人
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGroupMergeRequestValidAssignedCandidatesResponse ListGroupMergeRequestValidAssignedCandidates(ListGroupMergeRequestValidAssignedCandidatesRequest listGroupMergeRequestValidAssignedCandidatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupMergeRequestValidAssignedCandidatesRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/merge-requests/assignee-candidates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupMergeRequestValidAssignedCandidatesRequest);
            var response = DoHttpRequestSync("GET", request);
            var listGroupMergeRequestValidAssignedCandidatesResponse = JsonUtils.DeSerializeNull<ListGroupMergeRequestValidAssignedCandidatesResponse>(response);
            listGroupMergeRequestValidAssignedCandidatesResponse.Body = JsonUtils.DeSerializeList<MergeRequestVoteReviewerDto>(response);
            return listGroupMergeRequestValidAssignedCandidatesResponse;
        }

        public SyncInvoker<ListGroupMergeRequestValidAssignedCandidatesResponse> ListGroupMergeRequestValidAssignedCandidatesInvoker(ListGroupMergeRequestValidAssignedCandidatesRequest listGroupMergeRequestValidAssignedCandidatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupMergeRequestValidAssignedCandidatesRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/merge-requests/assignee-candidates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupMergeRequestValidAssignedCandidatesRequest);
            return new SyncInvoker<ListGroupMergeRequestValidAssignedCandidatesResponse>(this, "GET", request, response =>
            {
                var listGroupMergeRequestValidAssignedCandidatesResponse = JsonUtils.DeSerializeNull<ListGroupMergeRequestValidAssignedCandidatesResponse>(response);
                listGroupMergeRequestValidAssignedCandidatesResponse.Body = JsonUtils.DeSerializeList<MergeRequestVoteReviewerDto>(response);
                return listGroupMergeRequestValidAssignedCandidatesResponse;
            });
        }
        
        /// <summary>
        /// 获取合并请求审核设置列表
        ///
        /// 获取合并请求审核设置列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMergeRequestApproverSettingsResponse ListMergeRequestApproverSettings(ListMergeRequestApproverSettingsRequest listMergeRequestApproverSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestApproverSettingsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/approver-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestApproverSettingsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listMergeRequestApproverSettingsResponse = JsonUtils.DeSerializeNull<ListMergeRequestApproverSettingsResponse>(response);
            listMergeRequestApproverSettingsResponse.Body = JsonUtils.DeSerializeList<MergeRequestApproverSettingResultDto>(response);
            return listMergeRequestApproverSettingsResponse;
        }

        public SyncInvoker<ListMergeRequestApproverSettingsResponse> ListMergeRequestApproverSettingsInvoker(ListMergeRequestApproverSettingsRequest listMergeRequestApproverSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestApproverSettingsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/approver-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestApproverSettingsRequest);
            return new SyncInvoker<ListMergeRequestApproverSettingsResponse>(this, "GET", request, response =>
            {
                var listMergeRequestApproverSettingsResponse = JsonUtils.DeSerializeNull<ListMergeRequestApproverSettingsResponse>(response);
                listMergeRequestApproverSettingsResponse.Body = JsonUtils.DeSerializeList<MergeRequestApproverSettingResultDto>(response);
                return listMergeRequestApproverSettingsResponse;
            });
        }
        
        /// <summary>
        /// 获取合并请求审核人列表
        ///
        /// 获取合并请求审核人列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMergeRequestApproversResponse ListMergeRequestApprovers(ListMergeRequestApproversRequest listMergeRequestApproversRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestApproversRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/approval-approvers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestApproversRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMergeRequestApproversResponse>(response);
        }

        public SyncInvoker<ListMergeRequestApproversResponse> ListMergeRequestApproversInvoker(ListMergeRequestApproversRequest listMergeRequestApproversRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestApproversRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/approval-approvers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestApproversRequest);
            return new SyncInvoker<ListMergeRequestApproversResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMergeRequestApproversResponse>);
        }
        
        /// <summary>
        /// 获取合并请求文件变更列表
        ///
        /// 获取合并请求文件变更列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMergeRequestChangesResponse ListMergeRequestChanges(ListMergeRequestChangesRequest listMergeRequestChangesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestChangesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestChangesRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/changes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestChangesRequest);
            var response = DoHttpRequestSync("GET", request);
            var listMergeRequestChangesResponse = JsonUtils.DeSerializeNull<ListMergeRequestChangesResponse>(response);
            listMergeRequestChangesResponse.Body = JsonUtils.DeSerializeList<SimpleMergeRequestChangesDto>(response);
            return listMergeRequestChangesResponse;
        }

        public SyncInvoker<ListMergeRequestChangesResponse> ListMergeRequestChangesInvoker(ListMergeRequestChangesRequest listMergeRequestChangesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestChangesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestChangesRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/changes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestChangesRequest);
            return new SyncInvoker<ListMergeRequestChangesResponse>(this, "GET", request, response =>
            {
                var listMergeRequestChangesResponse = JsonUtils.DeSerializeNull<ListMergeRequestChangesResponse>(response);
                listMergeRequestChangesResponse.Body = JsonUtils.DeSerializeList<SimpleMergeRequestChangesDto>(response);
                return listMergeRequestChangesResponse;
            });
        }
        
        /// <summary>
        /// 获取合并请求文件变更列表树
        ///
        /// 获取合并请求文件变更列表树
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMergeRequestChangesTreesResponse ListMergeRequestChangesTrees(ListMergeRequestChangesTreesRequest listMergeRequestChangesTreesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestChangesTreesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestChangesTreesRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/changes-trees", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestChangesTreesRequest);
            var response = DoHttpRequestSync("GET", request);
            var listMergeRequestChangesTreesResponse = JsonUtils.DeSerializeNull<ListMergeRequestChangesTreesResponse>(response);
            listMergeRequestChangesTreesResponse.Body = JsonUtils.DeSerializeList<ChangesTreeDto>(response);
            return listMergeRequestChangesTreesResponse;
        }

        public SyncInvoker<ListMergeRequestChangesTreesResponse> ListMergeRequestChangesTreesInvoker(ListMergeRequestChangesTreesRequest listMergeRequestChangesTreesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestChangesTreesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestChangesTreesRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/changes-trees", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestChangesTreesRequest);
            return new SyncInvoker<ListMergeRequestChangesTreesResponse>(this, "GET", request, response =>
            {
                var listMergeRequestChangesTreesResponse = JsonUtils.DeSerializeNull<ListMergeRequestChangesTreesResponse>(response);
                listMergeRequestChangesTreesResponse.Body = JsonUtils.DeSerializeList<ChangesTreeDto>(response);
                return listMergeRequestChangesTreesResponse;
            });
        }
        
        /// <summary>
        /// 获取合并请求commit列表
        ///
        /// 获取合并请求commit列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMergeRequestCommitsResponse ListMergeRequestCommits(ListMergeRequestCommitsRequest listMergeRequestCommitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestCommitsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestCommitsRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/commits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestCommitsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listMergeRequestCommitsResponse = JsonUtils.DeSerializeNull<ListMergeRequestCommitsResponse>(response);
            listMergeRequestCommitsResponse.Body = JsonUtils.DeSerializeList<MergeRequestCommitDto>(response);
            return listMergeRequestCommitsResponse;
        }

        public SyncInvoker<ListMergeRequestCommitsResponse> ListMergeRequestCommitsInvoker(ListMergeRequestCommitsRequest listMergeRequestCommitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestCommitsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestCommitsRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/commits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestCommitsRequest);
            return new SyncInvoker<ListMergeRequestCommitsResponse>(this, "GET", request, response =>
            {
                var listMergeRequestCommitsResponse = JsonUtils.DeSerializeNull<ListMergeRequestCommitsResponse>(response);
                listMergeRequestCommitsResponse.Body = JsonUtils.DeSerializeList<MergeRequestCommitDto>(response);
                return listMergeRequestCommitsResponse;
            });
        }
        
        /// <summary>
        /// 获取所有的冲突文件
        ///
        /// 获取所有的冲突文件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMergeRequestConflictFilesResponse ListMergeRequestConflictFiles(ListMergeRequestConflictFilesRequest listMergeRequestConflictFilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestConflictFilesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestConflictFilesRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/conflict-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestConflictFilesRequest);
            var response = DoHttpRequestSync("GET", request);
            var listMergeRequestConflictFilesResponse = JsonUtils.DeSerializeNull<ListMergeRequestConflictFilesResponse>(response);
            listMergeRequestConflictFilesResponse.Body = JsonUtils.DeSerializeList<MRConflictFileDto>(response);
            return listMergeRequestConflictFilesResponse;
        }

        public SyncInvoker<ListMergeRequestConflictFilesResponse> ListMergeRequestConflictFilesInvoker(ListMergeRequestConflictFilesRequest listMergeRequestConflictFilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestConflictFilesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestConflictFilesRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/conflict-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestConflictFilesRequest);
            return new SyncInvoker<ListMergeRequestConflictFilesResponse>(this, "GET", request, response =>
            {
                var listMergeRequestConflictFilesResponse = JsonUtils.DeSerializeNull<ListMergeRequestConflictFilesResponse>(response);
                listMergeRequestConflictFilesResponse.Body = JsonUtils.DeSerializeList<MRConflictFileDto>(response);
                return listMergeRequestConflictFilesResponse;
            });
        }
        
        /// <summary>
        /// 获取合并请求评价列表
        ///
        /// 获取合并请求评价列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMergeRequestEvaluationsResponse ListMergeRequestEvaluations(ListMergeRequestEvaluationsRequest listMergeRequestEvaluationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestEvaluationsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestEvaluationsRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/evaluations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestEvaluationsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMergeRequestEvaluationsResponse>(response);
        }

        public SyncInvoker<ListMergeRequestEvaluationsResponse> ListMergeRequestEvaluationsInvoker(ListMergeRequestEvaluationsRequest listMergeRequestEvaluationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestEvaluationsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestEvaluationsRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/evaluations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestEvaluationsRequest);
            return new SyncInvoker<ListMergeRequestEvaluationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMergeRequestEvaluationsResponse>);
        }
        
        /// <summary>
        /// 获取合并请求参与者
        ///
        /// 获取合并请求参与者
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMergeRequestParticipantsResponse ListMergeRequestParticipants(ListMergeRequestParticipantsRequest listMergeRequestParticipantsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestParticipantsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestParticipantsRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/participants", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestParticipantsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listMergeRequestParticipantsResponse = JsonUtils.DeSerializeNull<ListMergeRequestParticipantsResponse>(response);
            listMergeRequestParticipantsResponse.Body = JsonUtils.DeSerializeList<UserBasicDto>(response);
            return listMergeRequestParticipantsResponse;
        }

        public SyncInvoker<ListMergeRequestParticipantsResponse> ListMergeRequestParticipantsInvoker(ListMergeRequestParticipantsRequest listMergeRequestParticipantsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestParticipantsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestParticipantsRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/participants", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestParticipantsRequest);
            return new SyncInvoker<ListMergeRequestParticipantsResponse>(this, "GET", request, response =>
            {
                var listMergeRequestParticipantsResponse = JsonUtils.DeSerializeNull<ListMergeRequestParticipantsResponse>(response);
                listMergeRequestParticipantsResponse.Body = JsonUtils.DeSerializeList<UserBasicDto>(response);
                return listMergeRequestParticipantsResponse;
            });
        }
        
        /// <summary>
        /// 获取合并请求检视人列表
        ///
        /// 获取合并请求检视人列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMergeRequestReviewersResponse ListMergeRequestReviewers(ListMergeRequestReviewersRequest listMergeRequestReviewersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestReviewersRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/approval-reviewers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestReviewersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMergeRequestReviewersResponse>(response);
        }

        public SyncInvoker<ListMergeRequestReviewersResponse> ListMergeRequestReviewersInvoker(ListMergeRequestReviewersRequest listMergeRequestReviewersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestReviewersRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/approval-reviewers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestReviewersRequest);
            return new SyncInvoker<ListMergeRequestReviewersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMergeRequestReviewersResponse>);
        }
        
        /// <summary>
        /// 获取合并请求模板列表
        ///
        /// 获取合并请求模板列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMergeRequestTemplatesResponse ListMergeRequestTemplates(ListMergeRequestTemplatesRequest listMergeRequestTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestTemplatesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestTemplatesRequest);
            var response = DoHttpRequestSync("GET", request);
            var listMergeRequestTemplatesResponse = JsonUtils.DeSerializeNull<ListMergeRequestTemplatesResponse>(response);
            listMergeRequestTemplatesResponse.Body = JsonUtils.DeSerializeList<RepositoryMergeRequestTemplateDto>(response);
            return listMergeRequestTemplatesResponse;
        }

        public SyncInvoker<ListMergeRequestTemplatesResponse> ListMergeRequestTemplatesInvoker(ListMergeRequestTemplatesRequest listMergeRequestTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestTemplatesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestTemplatesRequest);
            return new SyncInvoker<ListMergeRequestTemplatesResponse>(this, "GET", request, response =>
            {
                var listMergeRequestTemplatesResponse = JsonUtils.DeSerializeNull<ListMergeRequestTemplatesResponse>(response);
                listMergeRequestTemplatesResponse.Body = JsonUtils.DeSerializeList<RepositoryMergeRequestTemplateDto>(response);
                return listMergeRequestTemplatesResponse;
            });
        }
        
        /// <summary>
        /// 获取可选的合并请求检视人
        ///
        /// 获取可选的合并请求检视人
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMergeRequestValidAssignedCandidatesResponse ListMergeRequestValidAssignedCandidates(ListMergeRequestValidAssignedCandidatesRequest listMergeRequestValidAssignedCandidatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestValidAssignedCandidatesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/assignee-candidates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestValidAssignedCandidatesRequest);
            var response = DoHttpRequestSync("GET", request);
            var listMergeRequestValidAssignedCandidatesResponse = JsonUtils.DeSerializeNull<ListMergeRequestValidAssignedCandidatesResponse>(response);
            listMergeRequestValidAssignedCandidatesResponse.Body = JsonUtils.DeSerializeList<MRVoteReviewerDto>(response);
            return listMergeRequestValidAssignedCandidatesResponse;
        }

        public SyncInvoker<ListMergeRequestValidAssignedCandidatesResponse> ListMergeRequestValidAssignedCandidatesInvoker(ListMergeRequestValidAssignedCandidatesRequest listMergeRequestValidAssignedCandidatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestValidAssignedCandidatesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/assignee-candidates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestValidAssignedCandidatesRequest);
            return new SyncInvoker<ListMergeRequestValidAssignedCandidatesResponse>(this, "GET", request, response =>
            {
                var listMergeRequestValidAssignedCandidatesResponse = JsonUtils.DeSerializeNull<ListMergeRequestValidAssignedCandidatesResponse>(response);
                listMergeRequestValidAssignedCandidatesResponse.Body = JsonUtils.DeSerializeList<MRVoteReviewerDto>(response);
                return listMergeRequestValidAssignedCandidatesResponse;
            });
        }
        
        /// <summary>
        /// 获取文件变更历史版本列表
        ///
        /// 获取文件变更历史版本列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListMergeRequestVersionsResponse ListMergeRequestVersions(ListMergeRequestVersionsRequest listMergeRequestVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestVersionsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestVersionsRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestVersionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListMergeRequestVersionsResponse>(response);
        }

        public SyncInvoker<ListMergeRequestVersionsResponse> ListMergeRequestVersionsInvoker(ListMergeRequestVersionsRequest listMergeRequestVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestVersionsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestVersionsRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestVersionsRequest);
            return new SyncInvoker<ListMergeRequestVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMergeRequestVersionsResponse>);
        }
        
        /// <summary>
        /// 获取个人首页mr列表
        ///
        /// 获取个人首页mr列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPersonalMergeRequestsResponse ListPersonalMergeRequests(ListPersonalMergeRequestsRequest listPersonalMergeRequestsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/merge-requests", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPersonalMergeRequestsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listPersonalMergeRequestsResponse = JsonUtils.DeSerializeNull<ListPersonalMergeRequestsResponse>(response);
            listPersonalMergeRequestsResponse.Body = JsonUtils.DeSerializeList<MergeRequestListBasicDto>(response);
            return listPersonalMergeRequestsResponse;
        }

        public SyncInvoker<ListPersonalMergeRequestsResponse> ListPersonalMergeRequestsInvoker(ListPersonalMergeRequestsRequest listPersonalMergeRequestsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/merge-requests", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPersonalMergeRequestsRequest);
            return new SyncInvoker<ListPersonalMergeRequestsResponse>(this, "GET", request, response =>
            {
                var listPersonalMergeRequestsResponse = JsonUtils.DeSerializeNull<ListPersonalMergeRequestsResponse>(response);
                listPersonalMergeRequestsResponse.Body = JsonUtils.DeSerializeList<MergeRequestListBasicDto>(response);
                return listPersonalMergeRequestsResponse;
            });
        }
        
        /// <summary>
        /// 获取项目合并请求审核设置列表
        ///
        /// 获取项目合并请求审核设置列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProjectMergeRequestApproverSettingsResponse ListProjectMergeRequestApproverSettings(ListProjectMergeRequestApproverSettingsRequest listProjectMergeRequestApproverSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectMergeRequestApproverSettingsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/approver-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectMergeRequestApproverSettingsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listProjectMergeRequestApproverSettingsResponse = JsonUtils.DeSerializeNull<ListProjectMergeRequestApproverSettingsResponse>(response);
            listProjectMergeRequestApproverSettingsResponse.Body = JsonUtils.DeSerializeList<MergeRequestApproverSettingResultDto>(response);
            return listProjectMergeRequestApproverSettingsResponse;
        }

        public SyncInvoker<ListProjectMergeRequestApproverSettingsResponse> ListProjectMergeRequestApproverSettingsInvoker(ListProjectMergeRequestApproverSettingsRequest listProjectMergeRequestApproverSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectMergeRequestApproverSettingsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/approver-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectMergeRequestApproverSettingsRequest);
            return new SyncInvoker<ListProjectMergeRequestApproverSettingsResponse>(this, "GET", request, response =>
            {
                var listProjectMergeRequestApproverSettingsResponse = JsonUtils.DeSerializeNull<ListProjectMergeRequestApproverSettingsResponse>(response);
                listProjectMergeRequestApproverSettingsResponse.Body = JsonUtils.DeSerializeList<MergeRequestApproverSettingResultDto>(response);
                return listProjectMergeRequestApproverSettingsResponse;
            });
        }
        
        /// <summary>
        /// 获取项目检视人
        ///
        /// 获取代码组检视人
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProjectMergeRequestCanBeAssignedReviewersResponse ListProjectMergeRequestCanBeAssignedReviewers(ListProjectMergeRequestCanBeAssignedReviewersRequest listProjectMergeRequestCanBeAssignedReviewersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectMergeRequestCanBeAssignedReviewersRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/merge-requests/reviewers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectMergeRequestCanBeAssignedReviewersRequest);
            var response = DoHttpRequestSync("GET", request);
            var listProjectMergeRequestCanBeAssignedReviewersResponse = JsonUtils.DeSerializeNull<ListProjectMergeRequestCanBeAssignedReviewersResponse>(response);
            listProjectMergeRequestCanBeAssignedReviewersResponse.Body = JsonUtils.DeSerializeList<MergeRequestVoteReviewerDto>(response);
            return listProjectMergeRequestCanBeAssignedReviewersResponse;
        }

        public SyncInvoker<ListProjectMergeRequestCanBeAssignedReviewersResponse> ListProjectMergeRequestCanBeAssignedReviewersInvoker(ListProjectMergeRequestCanBeAssignedReviewersRequest listProjectMergeRequestCanBeAssignedReviewersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectMergeRequestCanBeAssignedReviewersRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/merge-requests/reviewers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectMergeRequestCanBeAssignedReviewersRequest);
            return new SyncInvoker<ListProjectMergeRequestCanBeAssignedReviewersResponse>(this, "GET", request, response =>
            {
                var listProjectMergeRequestCanBeAssignedReviewersResponse = JsonUtils.DeSerializeNull<ListProjectMergeRequestCanBeAssignedReviewersResponse>(response);
                listProjectMergeRequestCanBeAssignedReviewersResponse.Body = JsonUtils.DeSerializeList<MergeRequestVoteReviewerDto>(response);
                return listProjectMergeRequestCanBeAssignedReviewersResponse;
            });
        }
        
        /// <summary>
        /// 获取项目审核人或合并人
        ///
        /// 获取代码组审核人或合并人
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProjectMergeRequestCanBeAssignedUsersResponse ListProjectMergeRequestCanBeAssignedUsers(ListProjectMergeRequestCanBeAssignedUsersRequest listProjectMergeRequestCanBeAssignedUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectMergeRequestCanBeAssignedUsersRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/merge-requests/assignee-candidates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectMergeRequestCanBeAssignedUsersRequest);
            var response = DoHttpRequestSync("GET", request);
            var listProjectMergeRequestCanBeAssignedUsersResponse = JsonUtils.DeSerializeNull<ListProjectMergeRequestCanBeAssignedUsersResponse>(response);
            listProjectMergeRequestCanBeAssignedUsersResponse.Body = JsonUtils.DeSerializeList<MergeRequestVoteReviewerDto>(response);
            return listProjectMergeRequestCanBeAssignedUsersResponse;
        }

        public SyncInvoker<ListProjectMergeRequestCanBeAssignedUsersResponse> ListProjectMergeRequestCanBeAssignedUsersInvoker(ListProjectMergeRequestCanBeAssignedUsersRequest listProjectMergeRequestCanBeAssignedUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectMergeRequestCanBeAssignedUsersRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/merge-requests/assignee-candidates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectMergeRequestCanBeAssignedUsersRequest);
            return new SyncInvoker<ListProjectMergeRequestCanBeAssignedUsersResponse>(this, "GET", request, response =>
            {
                var listProjectMergeRequestCanBeAssignedUsersResponse = JsonUtils.DeSerializeNull<ListProjectMergeRequestCanBeAssignedUsersResponse>(response);
                listProjectMergeRequestCanBeAssignedUsersResponse.Body = JsonUtils.DeSerializeList<MergeRequestVoteReviewerDto>(response);
                return listProjectMergeRequestCanBeAssignedUsersResponse;
            });
        }
        
        /// <summary>
        /// 获取项目合并请求模板列表
        ///
        /// 获取项目合并请求模板列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProjectMergeRequestTemplatesResponse ListProjectMergeRequestTemplates(ListProjectMergeRequestTemplatesRequest listProjectMergeRequestTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectMergeRequestTemplatesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/merge-requests/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectMergeRequestTemplatesRequest);
            var response = DoHttpRequestSync("GET", request);
            var listProjectMergeRequestTemplatesResponse = JsonUtils.DeSerializeNull<ListProjectMergeRequestTemplatesResponse>(response);
            listProjectMergeRequestTemplatesResponse.Body = JsonUtils.DeSerializeList<ProjectMergeRequestTemplateDto>(response);
            return listProjectMergeRequestTemplatesResponse;
        }

        public SyncInvoker<ListProjectMergeRequestTemplatesResponse> ListProjectMergeRequestTemplatesInvoker(ListProjectMergeRequestTemplatesRequest listProjectMergeRequestTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectMergeRequestTemplatesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/merge-requests/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectMergeRequestTemplatesRequest);
            return new SyncInvoker<ListProjectMergeRequestTemplatesResponse>(this, "GET", request, response =>
            {
                var listProjectMergeRequestTemplatesResponse = JsonUtils.DeSerializeNull<ListProjectMergeRequestTemplatesResponse>(response);
                listProjectMergeRequestTemplatesResponse.Body = JsonUtils.DeSerializeList<ProjectMergeRequestTemplateDto>(response);
                return listProjectMergeRequestTemplatesResponse;
            });
        }
        
        /// <summary>
        /// 获取仓库MR列表
        ///
        /// 获取仓库MR列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRepositoryMergeRequestsResponse ListRepositoryMergeRequests(ListRepositoryMergeRequestsRequest listRepositoryMergeRequestsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryMergeRequestsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryMergeRequestsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listRepositoryMergeRequestsResponse = JsonUtils.DeSerializeNull<ListRepositoryMergeRequestsResponse>(response);
            listRepositoryMergeRequestsResponse.Body = JsonUtils.DeSerializeList<MergeRequestListBasicDto>(response);
            return listRepositoryMergeRequestsResponse;
        }

        public SyncInvoker<ListRepositoryMergeRequestsResponse> ListRepositoryMergeRequestsInvoker(ListRepositoryMergeRequestsRequest listRepositoryMergeRequestsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryMergeRequestsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryMergeRequestsRequest);
            return new SyncInvoker<ListRepositoryMergeRequestsResponse>(this, "GET", request, response =>
            {
                var listRepositoryMergeRequestsResponse = JsonUtils.DeSerializeNull<ListRepositoryMergeRequestsResponse>(response);
                listRepositoryMergeRequestsResponse.Body = JsonUtils.DeSerializeList<MergeRequestListBasicDto>(response);
                return listRepositoryMergeRequestsResponse;
            });
        }
        
        /// <summary>
        /// 合入合并请求
        ///
        /// 合入合并请求
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public MergeMergeRequestResponse MergeMergeRequest(MergeMergeRequestRequest mergeMergeRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(mergeMergeRequestRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(mergeMergeRequestRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/merge", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", mergeMergeRequestRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<MergeMergeRequestResponse>(response);
        }

        public SyncInvoker<MergeMergeRequestResponse> MergeMergeRequestInvoker(MergeMergeRequestRequest mergeMergeRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(mergeMergeRequestRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(mergeMergeRequestRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/merge", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", mergeMergeRequestRequest);
            return new SyncInvoker<MergeMergeRequestResponse>(this, "PUT", request, JsonUtils.DeSerialize<MergeMergeRequestResponse>);
        }
        
        /// <summary>
        /// 变基合并请求
        ///
        /// 变基合并请求
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RebaseMergeRequestForOpenApiResponse RebaseMergeRequestForOpenApi(RebaseMergeRequestForOpenApiRequest rebaseMergeRequestForOpenApiRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rebaseMergeRequestForOpenApiRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(rebaseMergeRequestForOpenApiRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/rebase", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rebaseMergeRequestForOpenApiRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<RebaseMergeRequestForOpenApiResponse>(response);
        }

        public SyncInvoker<RebaseMergeRequestForOpenApiResponse> RebaseMergeRequestForOpenApiInvoker(RebaseMergeRequestForOpenApiRequest rebaseMergeRequestForOpenApiRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rebaseMergeRequestForOpenApiRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(rebaseMergeRequestForOpenApiRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/rebase", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rebaseMergeRequestForOpenApiRequest);
            return new SyncInvoker<RebaseMergeRequestForOpenApiResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<RebaseMergeRequestForOpenApiResponse>);
        }
        
        /// <summary>
        /// 在线解决合并请求冲突
        ///
        /// 在线解决合并请求冲突
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResolveMergeRequestConflictsResponse ResolveMergeRequestConflicts(ResolveMergeRequestConflictsRequest resolveMergeRequestConflictsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resolveMergeRequestConflictsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(resolveMergeRequestConflictsRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/resolve-conflicts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resolveMergeRequestConflictsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ResolveMergeRequestConflictsResponse>(response);
        }

        public SyncInvoker<ResolveMergeRequestConflictsResponse> ResolveMergeRequestConflictsInvoker(ResolveMergeRequestConflictsRequest resolveMergeRequestConflictsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resolveMergeRequestConflictsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(resolveMergeRequestConflictsRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/resolve-conflicts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resolveMergeRequestConflictsRequest);
            return new SyncInvoker<ResolveMergeRequestConflictsResponse>(this, "PUT", request, JsonUtils.DeSerialize<ResolveMergeRequestConflictsResponse>);
        }
        
        /// <summary>
        /// 检视合并请求
        ///
        /// 检视合并请求
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ReviewMergeRequestResponse ReviewMergeRequest(ReviewMergeRequestRequest reviewMergeRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(reviewMergeRequestRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(reviewMergeRequestRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/approval-review", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", reviewMergeRequestRequest);
            var response = DoHttpRequestSync("PUT", request);
            var reviewMergeRequestResponse = JsonUtils.DeSerializeNull<ReviewMergeRequestResponse>(response);
            reviewMergeRequestResponse.Body = JsonUtils.DeSerializeList<ApproverBasicDto>(response);
            return reviewMergeRequestResponse;
        }

        public SyncInvoker<ReviewMergeRequestResponse> ReviewMergeRequestInvoker(ReviewMergeRequestRequest reviewMergeRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(reviewMergeRequestRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(reviewMergeRequestRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/approval-review", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", reviewMergeRequestRequest);
            return new SyncInvoker<ReviewMergeRequestResponse>(this, "PUT", request, response =>
            {
                var reviewMergeRequestResponse = JsonUtils.DeSerializeNull<ReviewMergeRequestResponse>(response);
                reviewMergeRequestResponse.Body = JsonUtils.DeSerializeList<ApproverBasicDto>(response);
                return reviewMergeRequestResponse;
            });
        }
        
        /// <summary>
        /// 获取合并请求关联的最新流水线
        ///
        /// 获取合并请求关联的最新流水线
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowActualHeadPipelineResponse ShowActualHeadPipeline(ShowActualHeadPipelineRequest showActualHeadPipelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showActualHeadPipelineRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showActualHeadPipelineRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/actual-head-pipeline", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showActualHeadPipelineRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowActualHeadPipelineResponse>(response);
        }

        public SyncInvoker<ShowActualHeadPipelineResponse> ShowActualHeadPipelineInvoker(ShowActualHeadPipelineRequest showActualHeadPipelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showActualHeadPipelineRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showActualHeadPipelineRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/actual-head-pipeline", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showActualHeadPipelineRequest);
            return new SyncInvoker<ShowActualHeadPipelineResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowActualHeadPipelineResponse>);
        }
        
        /// <summary>
        /// 获取合并请求的平均评价
        ///
        /// 获取合并请求的平均评价
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAverageEvaluationResponse ShowAverageEvaluation(ShowAverageEvaluationRequest showAverageEvaluationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAverageEvaluationRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showAverageEvaluationRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/average-evaluation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAverageEvaluationRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAverageEvaluationResponse>(response);
        }

        public SyncInvoker<ShowAverageEvaluationResponse> ShowAverageEvaluationInvoker(ShowAverageEvaluationRequest showAverageEvaluationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAverageEvaluationRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showAverageEvaluationRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/average-evaluation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAverageEvaluationRequest);
            return new SyncInvoker<ShowAverageEvaluationResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAverageEvaluationResponse>);
        }
        
        /// <summary>
        /// 获取分支代码冲突
        ///
        /// 获取分支代码冲突
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBranchConflictResponse ShowBranchConflict(ShowBranchConflictRequest showBranchConflictRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBranchConflictRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/conflict", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBranchConflictRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBranchConflictResponse>(response);
        }

        public SyncInvoker<ShowBranchConflictResponse> ShowBranchConflictInvoker(ShowBranchConflictRequest showBranchConflictRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBranchConflictRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/conflict", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBranchConflictRequest);
            return new SyncInvoker<ShowBranchConflictResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBranchConflictResponse>);
        }
        
        /// <summary>
        /// 获取代码页单个提交下文件的检视意见
        ///
        /// 获取代码页单个提交下文件的检视意见
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowCommitCommentsByLineResponse ShowCommitCommentsByLine(ShowCommitCommentsByLineRequest showCommitCommentsByLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCommitCommentsByLineRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showCommitCommentsByLineRequest.Sha, out var valueOfSha)) urlParam.Add("sha", valueOfSha);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/commits/{sha}/comments-by-line", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCommitCommentsByLineRequest);
            var response = DoHttpRequestSync("GET", request);
            var showCommitCommentsByLineResponse = JsonUtils.DeSerializeNull<ShowCommitCommentsByLineResponse>(response);
            showCommitCommentsByLineResponse.Body = JsonUtils.DeSerializeList<CommentPathDto>(response);
            return showCommitCommentsByLineResponse;
        }

        public SyncInvoker<ShowCommitCommentsByLineResponse> ShowCommitCommentsByLineInvoker(ShowCommitCommentsByLineRequest showCommitCommentsByLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCommitCommentsByLineRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showCommitCommentsByLineRequest.Sha, out var valueOfSha)) urlParam.Add("sha", valueOfSha);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/commits/{sha}/comments-by-line", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCommitCommentsByLineRequest);
            return new SyncInvoker<ShowCommitCommentsByLineResponse>(this, "GET", request, response =>
            {
                var showCommitCommentsByLineResponse = JsonUtils.DeSerializeNull<ShowCommitCommentsByLineResponse>(response);
                showCommitCommentsByLineResponse.Body = JsonUtils.DeSerializeList<CommentPathDto>(response);
                return showCommitCommentsByLineResponse;
            });
        }
        
        /// <summary>
        /// 获取代码组合并请求设置
        ///
        /// 获取代码组合并请求设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGroupMergeRequestSettingResponse ShowGroupMergeRequestSetting(ShowGroupMergeRequestSettingRequest showGroupMergeRequestSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupMergeRequestSettingRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/merge-requests/setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupMergeRequestSettingRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGroupMergeRequestSettingResponse>(response);
        }

        public SyncInvoker<ShowGroupMergeRequestSettingResponse> ShowGroupMergeRequestSettingInvoker(ShowGroupMergeRequestSettingRequest showGroupMergeRequestSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupMergeRequestSettingRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/merge-requests/setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupMergeRequestSettingRequest);
            return new SyncInvoker<ShowGroupMergeRequestSettingResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGroupMergeRequestSettingResponse>);
        }
        
        /// <summary>
        /// 获取合并请求文件变更页单个文件下的检视意见
        ///
        /// 获取合并请求文件变更页单个文件下的检视意见
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMergeRequestCommentsByLineResponse ShowMergeRequestCommentsByLine(ShowMergeRequestCommentsByLineRequest showMergeRequestCommentsByLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestCommentsByLineRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestCommentsByLineRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/comments-by-line", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMergeRequestCommentsByLineRequest);
            var response = DoHttpRequestSync("GET", request);
            var showMergeRequestCommentsByLineResponse = JsonUtils.DeSerializeNull<ShowMergeRequestCommentsByLineResponse>(response);
            showMergeRequestCommentsByLineResponse.Body = JsonUtils.DeSerializeList<CommentPathDto>(response);
            return showMergeRequestCommentsByLineResponse;
        }

        public SyncInvoker<ShowMergeRequestCommentsByLineResponse> ShowMergeRequestCommentsByLineInvoker(ShowMergeRequestCommentsByLineRequest showMergeRequestCommentsByLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestCommentsByLineRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestCommentsByLineRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/comments-by-line", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMergeRequestCommentsByLineRequest);
            return new SyncInvoker<ShowMergeRequestCommentsByLineResponse>(this, "GET", request, response =>
            {
                var showMergeRequestCommentsByLineResponse = JsonUtils.DeSerializeNull<ShowMergeRequestCommentsByLineResponse>(response);
                showMergeRequestCommentsByLineResponse.Body = JsonUtils.DeSerializeList<CommentPathDto>(response);
                return showMergeRequestCommentsByLineResponse;
            });
        }
        
        /// <summary>
        /// 获取MR详情
        ///
        /// 获取MR详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMergeRequestDetailResponse ShowMergeRequestDetail(ShowMergeRequestDetailRequest showMergeRequestDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestDetailRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestDetailRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMergeRequestDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMergeRequestDetailResponse>(response);
        }

        public SyncInvoker<ShowMergeRequestDetailResponse> ShowMergeRequestDetailInvoker(ShowMergeRequestDetailRequest showMergeRequestDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestDetailRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestDetailRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMergeRequestDetailRequest);
            return new SyncInvoker<ShowMergeRequestDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMergeRequestDetailResponse>);
        }
        
        /// <summary>
        /// 获取仓库合并请求设置
        ///
        /// 获取仓库合并请求设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMergeRequestSettingResponse ShowMergeRequestSetting(ShowMergeRequestSettingRequest showMergeRequestSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMergeRequestSettingRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMergeRequestSettingResponse>(response);
        }

        public SyncInvoker<ShowMergeRequestSettingResponse> ShowMergeRequestSettingInvoker(ShowMergeRequestSettingRequest showMergeRequestSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMergeRequestSettingRequest);
            return new SyncInvoker<ShowMergeRequestSettingResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMergeRequestSettingResponse>);
        }
        
        /// <summary>
        /// 获取单个合并请求模板
        ///
        /// 获取单个合并请求模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMergeRequestTemplateResponse ShowMergeRequestTemplate(ShowMergeRequestTemplateRequest showMergeRequestTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestTemplateRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/template/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMergeRequestTemplateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMergeRequestTemplateResponse>(response);
        }

        public SyncInvoker<ShowMergeRequestTemplateResponse> ShowMergeRequestTemplateInvoker(ShowMergeRequestTemplateRequest showMergeRequestTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestTemplateRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/template/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMergeRequestTemplateRequest);
            return new SyncInvoker<ShowMergeRequestTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMergeRequestTemplateResponse>);
        }
        
        /// <summary>
        /// 获取合并请求打分
        ///
        /// 获取合并请求打分
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMergeRequestVotesDetailResponse ShowMergeRequestVotesDetail(ShowMergeRequestVotesDetailRequest showMergeRequestVotesDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestVotesDetailRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestVotesDetailRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/votes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMergeRequestVotesDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMergeRequestVotesDetailResponse>(response);
        }

        public SyncInvoker<ShowMergeRequestVotesDetailResponse> ShowMergeRequestVotesDetailInvoker(ShowMergeRequestVotesDetailRequest showMergeRequestVotesDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestVotesDetailRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestVotesDetailRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/votes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMergeRequestVotesDetailRequest);
            return new SyncInvoker<ShowMergeRequestVotesDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMergeRequestVotesDetailResponse>);
        }
        
        /// <summary>
        /// 获取合并请求的可合入状态。
        ///
        /// 获取合并请求的可合入状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMergeableStateOuterResponse ShowMergeableStateOuter(ShowMergeableStateOuterRequest showMergeableStateOuterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMergeableStateOuterRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showMergeableStateOuterRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/mergeable-state-out", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMergeableStateOuterRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMergeableStateOuterResponse>(response);
        }

        public SyncInvoker<ShowMergeableStateOuterResponse> ShowMergeableStateOuterInvoker(ShowMergeableStateOuterRequest showMergeableStateOuterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMergeableStateOuterRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showMergeableStateOuterRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/mergeable-state-out", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMergeableStateOuterRequest);
            return new SyncInvoker<ShowMergeableStateOuterResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMergeableStateOuterResponse>);
        }
        
        /// <summary>
        /// 获取项目合并请求设置
        ///
        /// 获取项目合并请求设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowProjectMergeRequestSettingResponse ShowProjectMergeRequestSetting(ShowProjectMergeRequestSettingRequest showProjectMergeRequestSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectMergeRequestSettingRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/merge-requests/setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectMergeRequestSettingRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectMergeRequestSettingResponse>(response);
        }

        public SyncInvoker<ShowProjectMergeRequestSettingResponse> ShowProjectMergeRequestSettingInvoker(ShowProjectMergeRequestSettingRequest showProjectMergeRequestSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectMergeRequestSettingRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/merge-requests/setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectMergeRequestSettingRequest);
            return new SyncInvoker<ShowProjectMergeRequestSettingResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectMergeRequestSettingResponse>);
        }
        
        /// <summary>
        /// 获取仓库合并请求统计数据
        ///
        /// 获取仓库合并请求统计数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRepositoryMergeRequestsStatisticResponse ShowRepositoryMergeRequestsStatistic(ShowRepositoryMergeRequestsStatisticRequest showRepositoryMergeRequestsStatisticRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryMergeRequestsStatisticRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryMergeRequestsStatisticRequest);
            var response = DoHttpRequestSync("GET", request);
            var showRepositoryMergeRequestsStatisticResponse = JsonUtils.DeSerializeNull<ShowRepositoryMergeRequestsStatisticResponse>(response);
            showRepositoryMergeRequestsStatisticResponse.Body = JsonUtils.DeSerializeList<MergeRequestStatisticDto>(response);
            return showRepositoryMergeRequestsStatisticResponse;
        }

        public SyncInvoker<ShowRepositoryMergeRequestsStatisticResponse> ShowRepositoryMergeRequestsStatisticInvoker(ShowRepositoryMergeRequestsStatisticRequest showRepositoryMergeRequestsStatisticRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryMergeRequestsStatisticRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryMergeRequestsStatisticRequest);
            return new SyncInvoker<ShowRepositoryMergeRequestsStatisticResponse>(this, "GET", request, response =>
            {
                var showRepositoryMergeRequestsStatisticResponse = JsonUtils.DeSerializeNull<ShowRepositoryMergeRequestsStatisticResponse>(response);
                showRepositoryMergeRequestsStatisticResponse.Body = JsonUtils.DeSerializeList<MergeRequestStatisticDto>(response);
                return showRepositoryMergeRequestsStatisticResponse;
            });
        }
        
        /// <summary>
        /// 更新代码组合并请求审核设置
        ///
        /// 更新代码组合并请求审核设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGroupMergeRequestApproverSettingResponse UpdateGroupMergeRequestApproverSetting(UpdateGroupMergeRequestApproverSettingRequest updateGroupMergeRequestApproverSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateGroupMergeRequestApproverSettingRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(updateGroupMergeRequestApproverSettingRequest.SettingId, out var valueOfSettingId)) urlParam.Add("setting_id", valueOfSettingId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/approver-settings/{setting_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGroupMergeRequestApproverSettingRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGroupMergeRequestApproverSettingResponse>(response);
        }

        public SyncInvoker<UpdateGroupMergeRequestApproverSettingResponse> UpdateGroupMergeRequestApproverSettingInvoker(UpdateGroupMergeRequestApproverSettingRequest updateGroupMergeRequestApproverSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateGroupMergeRequestApproverSettingRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(updateGroupMergeRequestApproverSettingRequest.SettingId, out var valueOfSettingId)) urlParam.Add("setting_id", valueOfSettingId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/approver-settings/{setting_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGroupMergeRequestApproverSettingRequest);
            return new SyncInvoker<UpdateGroupMergeRequestApproverSettingResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGroupMergeRequestApproverSettingResponse>);
        }
        
        /// <summary>
        /// 更新代码组合并请求模板
        ///
        /// 更新代码组合并请求模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGroupMergeRequestTemplateResponse UpdateGroupMergeRequestTemplate(UpdateGroupMergeRequestTemplateRequest updateGroupMergeRequestTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateGroupMergeRequestTemplateRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(updateGroupMergeRequestTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/merge-requests/template/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGroupMergeRequestTemplateRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGroupMergeRequestTemplateResponse>(response);
        }

        public SyncInvoker<UpdateGroupMergeRequestTemplateResponse> UpdateGroupMergeRequestTemplateInvoker(UpdateGroupMergeRequestTemplateRequest updateGroupMergeRequestTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateGroupMergeRequestTemplateRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(updateGroupMergeRequestTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/merge-requests/template/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGroupMergeRequestTemplateRequest);
            return new SyncInvoker<UpdateGroupMergeRequestTemplateResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGroupMergeRequestTemplateResponse>);
        }
        
        /// <summary>
        /// 更新合并请求
        ///
        /// 更新合并请求
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateMergeRequestResponse UpdateMergeRequest(UpdateMergeRequestRequest updateMergeRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateMergeRequestResponse>(response);
        }

        public SyncInvoker<UpdateMergeRequestResponse> UpdateMergeRequestInvoker(UpdateMergeRequestRequest updateMergeRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestRequest);
            return new SyncInvoker<UpdateMergeRequestResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateMergeRequestResponse>);
        }
        
        /// <summary>
        /// 更新合并请求审核设置
        ///
        /// 更新合并请求审核设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateMergeRequestApproverSettingResponse UpdateMergeRequestApproverSetting(UpdateMergeRequestApproverSettingRequest updateMergeRequestApproverSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestApproverSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestApproverSettingRequest.SettingId, out var valueOfSettingId)) urlParam.Add("setting_id", valueOfSettingId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/approver-settings/{setting_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestApproverSettingRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateMergeRequestApproverSettingResponse>(response);
        }

        public SyncInvoker<UpdateMergeRequestApproverSettingResponse> UpdateMergeRequestApproverSettingInvoker(UpdateMergeRequestApproverSettingRequest updateMergeRequestApproverSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestApproverSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestApproverSettingRequest.SettingId, out var valueOfSettingId)) urlParam.Add("setting_id", valueOfSettingId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/approver-settings/{setting_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestApproverSettingRequest);
            return new SyncInvoker<UpdateMergeRequestApproverSettingResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateMergeRequestApproverSettingResponse>);
        }
        
        /// <summary>
        /// 更新合并请求的审核人列表
        ///
        /// 更新合并请求的审核人列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateMergeRequestApproversResponse UpdateMergeRequestApprovers(UpdateMergeRequestApproversRequest updateMergeRequestApproversRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestApproversRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestApproversRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/approval-approvers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestApproversRequest);
            var response = DoHttpRequestSync("PUT", request);
            var updateMergeRequestApproversResponse = JsonUtils.DeSerializeNull<UpdateMergeRequestApproversResponse>(response);
            updateMergeRequestApproversResponse.Body = JsonUtils.DeSerializeList<ApproverBasicDto>(response);
            return updateMergeRequestApproversResponse;
        }

        public SyncInvoker<UpdateMergeRequestApproversResponse> UpdateMergeRequestApproversInvoker(UpdateMergeRequestApproversRequest updateMergeRequestApproversRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestApproversRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestApproversRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/approval-approvers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestApproversRequest);
            return new SyncInvoker<UpdateMergeRequestApproversResponse>(this, "PUT", request, response =>
            {
                var updateMergeRequestApproversResponse = JsonUtils.DeSerializeNull<UpdateMergeRequestApproversResponse>(response);
                updateMergeRequestApproversResponse.Body = JsonUtils.DeSerializeList<ApproverBasicDto>(response);
                return updateMergeRequestApproversResponse;
            });
        }
        
        /// <summary>
        /// 更新合并请求的检视人列表
        ///
        /// 更新合并请求的检视人列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateMergeRequestReviewersResponse UpdateMergeRequestReviewers(UpdateMergeRequestReviewersRequest updateMergeRequestReviewersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestReviewersRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestReviewersRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/approval-reviewers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestReviewersRequest);
            var response = DoHttpRequestSync("PUT", request);
            var updateMergeRequestReviewersResponse = JsonUtils.DeSerializeNull<UpdateMergeRequestReviewersResponse>(response);
            updateMergeRequestReviewersResponse.Body = JsonUtils.DeSerializeList<ApproverBasicDto>(response);
            return updateMergeRequestReviewersResponse;
        }

        public SyncInvoker<UpdateMergeRequestReviewersResponse> UpdateMergeRequestReviewersInvoker(UpdateMergeRequestReviewersRequest updateMergeRequestReviewersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestReviewersRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestReviewersRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/approval-reviewers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestReviewersRequest);
            return new SyncInvoker<UpdateMergeRequestReviewersResponse>(this, "PUT", request, response =>
            {
                var updateMergeRequestReviewersResponse = JsonUtils.DeSerializeNull<UpdateMergeRequestReviewersResponse>(response);
                updateMergeRequestReviewersResponse.Body = JsonUtils.DeSerializeList<ApproverBasicDto>(response);
                return updateMergeRequestReviewersResponse;
            });
        }
        
        /// <summary>
        /// 更新仓库合并请求设置
        ///
        /// 更新仓库合并请求设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateMergeRequestSettingResponse UpdateMergeRequestSetting(UpdateMergeRequestSettingRequest updateMergeRequestSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestSettingRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateMergeRequestSettingResponse>(response);
        }

        public SyncInvoker<UpdateMergeRequestSettingResponse> UpdateMergeRequestSettingInvoker(UpdateMergeRequestSettingRequest updateMergeRequestSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestSettingRequest);
            return new SyncInvoker<UpdateMergeRequestSettingResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateMergeRequestSettingResponse>);
        }
        
        /// <summary>
        /// 更新合并请求模板
        ///
        /// 更新合并请求模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateMergeRequestTemplateResponse UpdateMergeRequestTemplate(UpdateMergeRequestTemplateRequest updateMergeRequestTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestTemplateRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/template/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestTemplateRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateMergeRequestTemplateResponse>(response);
        }

        public SyncInvoker<UpdateMergeRequestTemplateResponse> UpdateMergeRequestTemplateInvoker(UpdateMergeRequestTemplateRequest updateMergeRequestTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestTemplateRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/template/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestTemplateRequest);
            return new SyncInvoker<UpdateMergeRequestTemplateResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateMergeRequestTemplateResponse>);
        }
        
        /// <summary>
        /// 更新合并请求打分
        ///
        /// 更新合并请求打分
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateMergeRequestVoteResponse UpdateMergeRequestVote(UpdateMergeRequestVoteRequest updateMergeRequestVoteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestVoteRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestVoteRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/vote", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestVoteRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateMergeRequestVoteResponse>(response);
        }

        public SyncInvoker<UpdateMergeRequestVoteResponse> UpdateMergeRequestVoteInvoker(UpdateMergeRequestVoteRequest updateMergeRequestVoteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestVoteRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestVoteRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/vote", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestVoteRequest);
            return new SyncInvoker<UpdateMergeRequestVoteResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateMergeRequestVoteResponse>);
        }
        
        /// <summary>
        /// 更新项目合并请求审核设置
        ///
        /// 更新项目合并请求审核设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateProjectMergeRequestApproverSettingResponse UpdateProjectMergeRequestApproverSetting(UpdateProjectMergeRequestApproverSettingRequest updateProjectMergeRequestApproverSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProjectMergeRequestApproverSettingRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(updateProjectMergeRequestApproverSettingRequest.SettingId, out var valueOfSettingId)) urlParam.Add("setting_id", valueOfSettingId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/approver-settings/{setting_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProjectMergeRequestApproverSettingRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateProjectMergeRequestApproverSettingResponse>(response);
        }

        public SyncInvoker<UpdateProjectMergeRequestApproverSettingResponse> UpdateProjectMergeRequestApproverSettingInvoker(UpdateProjectMergeRequestApproverSettingRequest updateProjectMergeRequestApproverSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProjectMergeRequestApproverSettingRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(updateProjectMergeRequestApproverSettingRequest.SettingId, out var valueOfSettingId)) urlParam.Add("setting_id", valueOfSettingId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/approver-settings/{setting_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProjectMergeRequestApproverSettingRequest);
            return new SyncInvoker<UpdateProjectMergeRequestApproverSettingResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateProjectMergeRequestApproverSettingResponse>);
        }
        
        /// <summary>
        /// 更新项目合并请求模板
        ///
        /// 更新项目合并请求模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateProjectMergeRequestTemplateResponse UpdateProjectMergeRequestTemplate(UpdateProjectMergeRequestTemplateRequest updateProjectMergeRequestTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProjectMergeRequestTemplateRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(updateProjectMergeRequestTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/merge-requests/template/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProjectMergeRequestTemplateRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateProjectMergeRequestTemplateResponse>(response);
        }

        public SyncInvoker<UpdateProjectMergeRequestTemplateResponse> UpdateProjectMergeRequestTemplateInvoker(UpdateProjectMergeRequestTemplateRequest updateProjectMergeRequestTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProjectMergeRequestTemplateRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(updateProjectMergeRequestTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/merge-requests/template/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProjectMergeRequestTemplateRequest);
            return new SyncInvoker<UpdateProjectMergeRequestTemplateResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateProjectMergeRequestTemplateResponse>);
        }
        
        /// <summary>
        /// 批量删除仓库文件推送权限
        ///
        /// 批量删除仓库文件推送权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteRepositoryFilePushPermissionsResponse BatchDeleteRepositoryFilePushPermissions(BatchDeleteRepositoryFilePushPermissionsRequest batchDeleteRepositoryFilePushPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteRepositoryFilePushPermissionsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/file-push-permissions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteRepositoryFilePushPermissionsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteRepositoryFilePushPermissionsResponse>(response);
        }

        public SyncInvoker<BatchDeleteRepositoryFilePushPermissionsResponse> BatchDeleteRepositoryFilePushPermissionsInvoker(BatchDeleteRepositoryFilePushPermissionsRequest batchDeleteRepositoryFilePushPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteRepositoryFilePushPermissionsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/file-push-permissions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteRepositoryFilePushPermissionsRequest);
            return new SyncInvoker<BatchDeleteRepositoryFilePushPermissionsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteRepositoryFilePushPermissionsResponse>);
        }
        
        /// <summary>
        /// 批量更新仓库文件推送权限
        ///
        /// 批量更新仓库文件推送权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchUpdateRepositoryFilePushPermissionsResponse BatchUpdateRepositoryFilePushPermissions(BatchUpdateRepositoryFilePushPermissionsRequest batchUpdateRepositoryFilePushPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateRepositoryFilePushPermissionsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/file-push-permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateRepositoryFilePushPermissionsRequest);
            var response = DoHttpRequestSync("PUT", request);
            var batchUpdateRepositoryFilePushPermissionsResponse = JsonUtils.DeSerializeNull<BatchUpdateRepositoryFilePushPermissionsResponse>(response);
            batchUpdateRepositoryFilePushPermissionsResponse.Body = JsonUtils.DeSerializeList<RepositoryFilePushPermissionDto>(response);
            return batchUpdateRepositoryFilePushPermissionsResponse;
        }

        public SyncInvoker<BatchUpdateRepositoryFilePushPermissionsResponse> BatchUpdateRepositoryFilePushPermissionsInvoker(BatchUpdateRepositoryFilePushPermissionsRequest batchUpdateRepositoryFilePushPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateRepositoryFilePushPermissionsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/file-push-permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateRepositoryFilePushPermissionsRequest);
            return new SyncInvoker<BatchUpdateRepositoryFilePushPermissionsResponse>(this, "PUT", request, response =>
            {
                var batchUpdateRepositoryFilePushPermissionsResponse = JsonUtils.DeSerializeNull<BatchUpdateRepositoryFilePushPermissionsResponse>(response);
                batchUpdateRepositoryFilePushPermissionsResponse.Body = JsonUtils.DeSerializeList<RepositoryFilePushPermissionDto>(response);
                return batchUpdateRepositoryFilePushPermissionsResponse;
            });
        }
        
        /// <summary>
        /// 创建仓库文件推送权限
        ///
        /// 创建仓库文件推送权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateFilePushPermissionResponse CreateFilePushPermission(CreateFilePushPermissionRequest createFilePushPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createFilePushPermissionRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/file-push-permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFilePushPermissionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateFilePushPermissionResponse>(response);
        }

        public SyncInvoker<CreateFilePushPermissionResponse> CreateFilePushPermissionInvoker(CreateFilePushPermissionRequest createFilePushPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createFilePushPermissionRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/file-push-permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFilePushPermissionRequest);
            return new SyncInvoker<CreateFilePushPermissionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateFilePushPermissionResponse>);
        }
        
        /// <summary>
        /// 获取仓库文件推送权限列表
        ///
        /// 获取仓库文件推送权限列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRepositoryFilePushPermissionsResponse ListRepositoryFilePushPermissions(ListRepositoryFilePushPermissionsRequest listRepositoryFilePushPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryFilePushPermissionsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/file-push-permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryFilePushPermissionsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listRepositoryFilePushPermissionsResponse = JsonUtils.DeSerializeNull<ListRepositoryFilePushPermissionsResponse>(response);
            listRepositoryFilePushPermissionsResponse.Body = JsonUtils.DeSerializeList<RepositoryFilePushPermissionDto>(response);
            return listRepositoryFilePushPermissionsResponse;
        }

        public SyncInvoker<ListRepositoryFilePushPermissionsResponse> ListRepositoryFilePushPermissionsInvoker(ListRepositoryFilePushPermissionsRequest listRepositoryFilePushPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryFilePushPermissionsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/file-push-permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryFilePushPermissionsRequest);
            return new SyncInvoker<ListRepositoryFilePushPermissionsResponse>(this, "GET", request, response =>
            {
                var listRepositoryFilePushPermissionsResponse = JsonUtils.DeSerializeNull<ListRepositoryFilePushPermissionsResponse>(response);
                listRepositoryFilePushPermissionsResponse.Body = JsonUtils.DeSerializeList<RepositoryFilePushPermissionDto>(response);
                return listRepositoryFilePushPermissionsResponse;
            });
        }
        
        /// <summary>
        /// 查询仓库权限矩阵配置
        ///
        /// 查询仓库权限矩阵配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRepositoryResourcePermissionsResponse ListRepositoryResourcePermissions(ListRepositoryResourcePermissionsRequest listRepositoryResourcePermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryResourcePermissionsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryResourcePermissionsRequest.ResourceName, out var valueOfResourceName)) urlParam.Add("resource_name", valueOfResourceName);
            var urlPath = HttpUtils.AddUrlPath("/v4/repository/{repository_id}/permissions/{resource_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryResourcePermissionsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listRepositoryResourcePermissionsResponse = JsonUtils.DeSerializeNull<ListRepositoryResourcePermissionsResponse>(response);
            listRepositoryResourcePermissionsResponse.Body = JsonUtils.DeSerializeList<ResponsePermissionInfo>(response);
            return listRepositoryResourcePermissionsResponse;
        }

        public SyncInvoker<ListRepositoryResourcePermissionsResponse> ListRepositoryResourcePermissionsInvoker(ListRepositoryResourcePermissionsRequest listRepositoryResourcePermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryResourcePermissionsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryResourcePermissionsRequest.ResourceName, out var valueOfResourceName)) urlParam.Add("resource_name", valueOfResourceName);
            var urlPath = HttpUtils.AddUrlPath("/v4/repository/{repository_id}/permissions/{resource_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryResourcePermissionsRequest);
            return new SyncInvoker<ListRepositoryResourcePermissionsResponse>(this, "GET", request, response =>
            {
                var listRepositoryResourcePermissionsResponse = JsonUtils.DeSerializeNull<ListRepositoryResourcePermissionsResponse>(response);
                listRepositoryResourcePermissionsResponse.Body = JsonUtils.DeSerializeList<ResponsePermissionInfo>(response);
                return listRepositoryResourcePermissionsResponse;
            });
        }
        
        /// <summary>
        /// 查询仓库权限配置信息
        ///
        /// 查询仓库权限配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRepositoryPermissionInheritEnabledResponse ShowRepositoryPermissionInheritEnabled(ShowRepositoryPermissionInheritEnabledRequest showRepositoryPermissionInheritEnabledRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryPermissionInheritEnabledRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/permission-inherit-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryPermissionInheritEnabledRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRepositoryPermissionInheritEnabledResponse>(response);
        }

        public SyncInvoker<ShowRepositoryPermissionInheritEnabledResponse> ShowRepositoryPermissionInheritEnabledInvoker(ShowRepositoryPermissionInheritEnabledRequest showRepositoryPermissionInheritEnabledRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryPermissionInheritEnabledRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/permission-inherit-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryPermissionInheritEnabledRequest);
            return new SyncInvoker<ShowRepositoryPermissionInheritEnabledResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepositoryPermissionInheritEnabledResponse>);
        }
        
        /// <summary>
        /// 更新仓库权限继承配置
        ///
        /// 更新仓库权限继承配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRepositoryPermissionInheritEnabledResponse UpdateRepositoryPermissionInheritEnabled(UpdateRepositoryPermissionInheritEnabledRequest updateRepositoryPermissionInheritEnabledRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryPermissionInheritEnabledRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/permission-inherit-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepositoryPermissionInheritEnabledRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRepositoryPermissionInheritEnabledResponse>(response);
        }

        public SyncInvoker<UpdateRepositoryPermissionInheritEnabledResponse> UpdateRepositoryPermissionInheritEnabledInvoker(UpdateRepositoryPermissionInheritEnabledRequest updateRepositoryPermissionInheritEnabledRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryPermissionInheritEnabledRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/permission-inherit-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepositoryPermissionInheritEnabledRequest);
            return new SyncInvoker<UpdateRepositoryPermissionInheritEnabledResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRepositoryPermissionInheritEnabledResponse>);
        }
        
        /// <summary>
        /// 更新仓库权限矩阵配置
        ///
        /// 更新仓库权限矩阵配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRepositoryResourcePermissionsResponse UpdateRepositoryResourcePermissions(UpdateRepositoryResourcePermissionsRequest updateRepositoryResourcePermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryResourcePermissionsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryResourcePermissionsRequest.ResourceName, out var valueOfResourceName)) urlParam.Add("resource_name", valueOfResourceName);
            var urlPath = HttpUtils.AddUrlPath("/v4/repository/{repository_id}/permissions/{resource_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepositoryResourcePermissionsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRepositoryResourcePermissionsResponse>(response);
        }

        public SyncInvoker<UpdateRepositoryResourcePermissionsResponse> UpdateRepositoryResourcePermissionsInvoker(UpdateRepositoryResourcePermissionsRequest updateRepositoryResourcePermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryResourcePermissionsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryResourcePermissionsRequest.ResourceName, out var valueOfResourceName)) urlParam.Add("resource_name", valueOfResourceName);
            var urlPath = HttpUtils.AddUrlPath("/v4/repository/{repository_id}/permissions/{resource_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepositoryResourcePermissionsRequest);
            return new SyncInvoker<UpdateRepositoryResourcePermissionsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRepositoryResourcePermissionsResponse>);
        }
        
        /// <summary>
        /// 获取流水线的关联的最新任务
        ///
        /// 获取流水线的关联的最新任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLatestPipelineJobsResponse ListLatestPipelineJobs(ListLatestPipelineJobsRequest listLatestPipelineJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listLatestPipelineJobsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listLatestPipelineJobsRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/pipelines/{pipeline_id}/latest-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLatestPipelineJobsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListLatestPipelineJobsResponse>(response);
        }

        public SyncInvoker<ListLatestPipelineJobsResponse> ListLatestPipelineJobsInvoker(ListLatestPipelineJobsRequest listLatestPipelineJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listLatestPipelineJobsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listLatestPipelineJobsRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/pipelines/{pipeline_id}/latest-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLatestPipelineJobsRequest);
            return new SyncInvoker<ListLatestPipelineJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLatestPipelineJobsResponse>);
        }
        
        /// <summary>
        /// 获取流水线的关联的任务列表
        ///
        /// 获取流水线的关联的任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPipelineJobsResponse ListPipelineJobs(ListPipelineJobsRequest listPipelineJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPipelineJobsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listPipelineJobsRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/pipelines/{pipeline_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPipelineJobsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listPipelineJobsResponse = JsonUtils.DeSerializeNull<ListPipelineJobsResponse>(response);
            listPipelineJobsResponse.Body = JsonUtils.DeSerializeList<JobWithStageDto>(response);
            return listPipelineJobsResponse;
        }

        public SyncInvoker<ListPipelineJobsResponse> ListPipelineJobsInvoker(ListPipelineJobsRequest listPipelineJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPipelineJobsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listPipelineJobsRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/pipelines/{pipeline_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPipelineJobsRequest);
            return new SyncInvoker<ListPipelineJobsResponse>(this, "GET", request, response =>
            {
                var listPipelineJobsResponse = JsonUtils.DeSerializeNull<ListPipelineJobsResponse>(response);
                listPipelineJobsResponse.Body = JsonUtils.DeSerializeList<JobWithStageDto>(response);
                return listPipelineJobsResponse;
            });
        }
        
        /// <summary>
        /// 工作项关联的提交信息
        ///
        /// 工作项关联的提交信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListItemCommitsResponse ListItemCommits(ListItemCommitsRequest listItemCommitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listItemCommitsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listItemCommitsRequest.ItemId, out var valueOfItemId)) urlParam.Add("item_id", valueOfItemId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/items/{item_id}/commits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listItemCommitsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listItemCommitsResponse = JsonUtils.DeSerializeNull<ListItemCommitsResponse>(response);
            listItemCommitsResponse.Body = JsonUtils.DeSerializeList<ItemCommitDto>(response);
            return listItemCommitsResponse;
        }

        public SyncInvoker<ListItemCommitsResponse> ListItemCommitsInvoker(ListItemCommitsRequest listItemCommitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listItemCommitsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listItemCommitsRequest.ItemId, out var valueOfItemId)) urlParam.Add("item_id", valueOfItemId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/items/{item_id}/commits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listItemCommitsRequest);
            return new SyncInvoker<ListItemCommitsResponse>(this, "GET", request, response =>
            {
                var listItemCommitsResponse = JsonUtils.DeSerializeNull<ListItemCommitsResponse>(response);
                listItemCommitsResponse.Body = JsonUtils.DeSerializeList<ItemCommitDto>(response);
                return listItemCommitsResponse;
            });
        }
        
        /// <summary>
        /// 获取项目下的代码组和仓库列表
        ///
        /// 获取项目下的代码组和仓库列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProjectSubgroupsAndRepositoriesResponse ListProjectSubgroupsAndRepositories(ListProjectSubgroupsAndRepositoriesRequest listProjectSubgroupsAndRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectSubgroupsAndRepositoriesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/subgroups-and-repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectSubgroupsAndRepositoriesRequest);
            var response = DoHttpRequestSync("GET", request);
            var listProjectSubgroupsAndRepositoriesResponse = JsonUtils.DeSerializeNull<ListProjectSubgroupsAndRepositoriesResponse>(response);
            listProjectSubgroupsAndRepositoriesResponse.Body = JsonUtils.DeSerializeList<SubgroupAndProjectBaseDto>(response);
            return listProjectSubgroupsAndRepositoriesResponse;
        }

        public SyncInvoker<ListProjectSubgroupsAndRepositoriesResponse> ListProjectSubgroupsAndRepositoriesInvoker(ListProjectSubgroupsAndRepositoriesRequest listProjectSubgroupsAndRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectSubgroupsAndRepositoriesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/subgroups-and-repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectSubgroupsAndRepositoriesRequest);
            return new SyncInvoker<ListProjectSubgroupsAndRepositoriesResponse>(this, "GET", request, response =>
            {
                var listProjectSubgroupsAndRepositoriesResponse = JsonUtils.DeSerializeNull<ListProjectSubgroupsAndRepositoriesResponse>(response);
                listProjectSubgroupsAndRepositoriesResponse.Body = JsonUtils.DeSerializeList<SubgroupAndProjectBaseDto>(response);
                return listProjectSubgroupsAndRepositoriesResponse;
            });
        }
        
        /// <summary>
        /// 获取指定项目的基本设置信息
        ///
        /// 获取指定项目的基本设置信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowProjectGeneralPolicyResponse ShowProjectGeneralPolicy(ShowProjectGeneralPolicyRequest showProjectGeneralPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectGeneralPolicyRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/policies/general", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectGeneralPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectGeneralPolicyResponse>(response);
        }

        public SyncInvoker<ShowProjectGeneralPolicyResponse> ShowProjectGeneralPolicyInvoker(ShowProjectGeneralPolicyRequest showProjectGeneralPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectGeneralPolicyRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/policies/general", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectGeneralPolicyRequest);
            return new SyncInvoker<ShowProjectGeneralPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectGeneralPolicyResponse>);
        }
        
        /// <summary>
        /// 获取项目成员设置
        ///
        /// 获取项目成员设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowProjectMemberSettingResponse ShowProjectMemberSetting(ShowProjectMemberSettingRequest showProjectMemberSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectMemberSettingRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/member-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectMemberSettingRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectMemberSettingResponse>(response);
        }

        public SyncInvoker<ShowProjectMemberSettingResponse> ShowProjectMemberSettingInvoker(ShowProjectMemberSettingRequest showProjectMemberSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectMemberSettingRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/member-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectMemberSettingRequest);
            return new SyncInvoker<ShowProjectMemberSettingResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectMemberSettingResponse>);
        }
        
        /// <summary>
        /// 获取项目继承设置项
        ///
        /// 获取项目继承设置项
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowProjectSettingsInheritCfgResponse ShowProjectSettingsInheritCfg(ShowProjectSettingsInheritCfgRequest showProjectSettingsInheritCfgRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectSettingsInheritCfgRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/settings-inherit-cfg", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectSettingsInheritCfgRequest);
            var response = DoHttpRequestSync("GET", request);
            var showProjectSettingsInheritCfgResponse = JsonUtils.DeSerializeNull<ShowProjectSettingsInheritCfgResponse>(response);
            showProjectSettingsInheritCfgResponse.Body = JsonUtils.DeSerializeList<ProjectSettingsInheritCfgDto>(response);
            return showProjectSettingsInheritCfgResponse;
        }

        public SyncInvoker<ShowProjectSettingsInheritCfgResponse> ShowProjectSettingsInheritCfgInvoker(ShowProjectSettingsInheritCfgRequest showProjectSettingsInheritCfgRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectSettingsInheritCfgRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/settings-inherit-cfg", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectSettingsInheritCfgRequest);
            return new SyncInvoker<ShowProjectSettingsInheritCfgResponse>(this, "GET", request, response =>
            {
                var showProjectSettingsInheritCfgResponse = JsonUtils.DeSerializeNull<ShowProjectSettingsInheritCfgResponse>(response);
                showProjectSettingsInheritCfgResponse.Body = JsonUtils.DeSerializeList<ProjectSettingsInheritCfgDto>(response);
                return showProjectSettingsInheritCfgResponse;
            });
        }
        
        /// <summary>
        /// 获取项目水印设置
        ///
        /// 获取项目水印设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowProjectWatermarkResponse ShowProjectWatermark(ShowProjectWatermarkRequest showProjectWatermarkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectWatermarkRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectWatermarkRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectWatermarkResponse>(response);
        }

        public SyncInvoker<ShowProjectWatermarkResponse> ShowProjectWatermarkInvoker(ShowProjectWatermarkRequest showProjectWatermarkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectWatermarkRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectWatermarkRequest);
            return new SyncInvoker<ShowProjectWatermarkResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectWatermarkResponse>);
        }
        
        /// <summary>
        /// 获取指定项目的基本设置信息
        ///
        /// 获取指定项目的基本设置信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowProjectsGeneralPolicyResponse ShowProjectsGeneralPolicy(ShowProjectsGeneralPolicyRequest showProjectsGeneralPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectsGeneralPolicyRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/general-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectsGeneralPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectsGeneralPolicyResponse>(response);
        }

        public SyncInvoker<ShowProjectsGeneralPolicyResponse> ShowProjectsGeneralPolicyInvoker(ShowProjectsGeneralPolicyRequest showProjectsGeneralPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectsGeneralPolicyRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/general-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectsGeneralPolicyRequest);
            return new SyncInvoker<ShowProjectsGeneralPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectsGeneralPolicyResponse>);
        }
        
        /// <summary>
        /// 获取资源点对应的角色和权限
        ///
        /// 获取资源点对应的角色和权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowResourcePermissionsResponse ShowResourcePermissions(ShowResourcePermissionsRequest showResourcePermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourcePermissionsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(showResourcePermissionsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/permissions-resources/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourcePermissionsRequest);
            var response = DoHttpRequestSync("GET", request);
            var showResourcePermissionsResponse = JsonUtils.DeSerializeNull<ShowResourcePermissionsResponse>(response);
            showResourcePermissionsResponse.Body = JsonUtils.DeSerializeList<PermissionDto>(response);
            return showResourcePermissionsResponse;
        }

        public SyncInvoker<ShowResourcePermissionsResponse> ShowResourcePermissionsInvoker(ShowResourcePermissionsRequest showResourcePermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourcePermissionsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(showResourcePermissionsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/permissions-resources/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourcePermissionsRequest);
            return new SyncInvoker<ShowResourcePermissionsResponse>(this, "GET", request, response =>
            {
                var showResourcePermissionsResponse = JsonUtils.DeSerializeNull<ShowResourcePermissionsResponse>(response);
                showResourcePermissionsResponse.Body = JsonUtils.DeSerializeList<PermissionDto>(response);
                return showResourcePermissionsResponse;
            });
        }
        
        /// <summary>
        /// 更新项目的基本设置信息
        ///
        /// 更新项目的基本设置信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateProjectGeneralPolicyResponse UpdateProjectGeneralPolicy(UpdateProjectGeneralPolicyRequest updateProjectGeneralPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProjectGeneralPolicyRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/general-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProjectGeneralPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateProjectGeneralPolicyResponse>(response);
        }

        public SyncInvoker<UpdateProjectGeneralPolicyResponse> UpdateProjectGeneralPolicyInvoker(UpdateProjectGeneralPolicyRequest updateProjectGeneralPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProjectGeneralPolicyRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/general-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProjectGeneralPolicyRequest);
            return new SyncInvoker<UpdateProjectGeneralPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateProjectGeneralPolicyResponse>);
        }
        
        /// <summary>
        /// 更新项目继承设置项
        ///
        /// 更新项目继承设置项
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateProjectSettingsInheritCfgResponse UpdateProjectSettingsInheritCfg(UpdateProjectSettingsInheritCfgRequest updateProjectSettingsInheritCfgRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProjectSettingsInheritCfgRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/settings-inherit-cfg", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProjectSettingsInheritCfgRequest);
            var response = DoHttpRequestSync("PUT", request);
            var updateProjectSettingsInheritCfgResponse = JsonUtils.DeSerializeNull<UpdateProjectSettingsInheritCfgResponse>(response);
            updateProjectSettingsInheritCfgResponse.Body = JsonUtils.DeSerializeList<ProjectSettingsInheritCfgDto>(response);
            return updateProjectSettingsInheritCfgResponse;
        }

        public SyncInvoker<UpdateProjectSettingsInheritCfgResponse> UpdateProjectSettingsInheritCfgInvoker(UpdateProjectSettingsInheritCfgRequest updateProjectSettingsInheritCfgRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProjectSettingsInheritCfgRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/settings-inherit-cfg", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProjectSettingsInheritCfgRequest);
            return new SyncInvoker<UpdateProjectSettingsInheritCfgResponse>(this, "PUT", request, response =>
            {
                var updateProjectSettingsInheritCfgResponse = JsonUtils.DeSerializeNull<UpdateProjectSettingsInheritCfgResponse>(response);
                updateProjectSettingsInheritCfgResponse.Body = JsonUtils.DeSerializeList<ProjectSettingsInheritCfgDto>(response);
                return updateProjectSettingsInheritCfgResponse;
            });
        }
        
        /// <summary>
        /// 更新项目水印设置
        ///
        /// 更新项目水印设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateProjectWatermarkResponse UpdateProjectWatermark(UpdateProjectWatermarkRequest updateProjectWatermarkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProjectWatermarkRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProjectWatermarkRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateProjectWatermarkResponse>(response);
        }

        public SyncInvoker<UpdateProjectWatermarkResponse> UpdateProjectWatermarkInvoker(UpdateProjectWatermarkRequest updateProjectWatermarkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProjectWatermarkRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProjectWatermarkRequest);
            return new SyncInvoker<UpdateProjectWatermarkResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateProjectWatermarkResponse>);
        }
        
        /// <summary>
        /// 批量创建仓库保护分支
        ///
        /// 批量创建仓库保护分支
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateProtectedBranchResponse BatchCreateProtectedBranch(BatchCreateProtectedBranchRequest batchCreateProtectedBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateProtectedBranchRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateProtectedBranchRequest);
            var response = DoHttpRequestSync("POST", request);
            var batchCreateProtectedBranchResponse = JsonUtils.DeSerializeNull<BatchCreateProtectedBranchResponse>(response);
            batchCreateProtectedBranchResponse.Body = JsonUtils.DeSerializeList<RepositoryProtectedBranchDto>(response);
            return batchCreateProtectedBranchResponse;
        }

        public SyncInvoker<BatchCreateProtectedBranchResponse> BatchCreateProtectedBranchInvoker(BatchCreateProtectedBranchRequest batchCreateProtectedBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateProtectedBranchRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateProtectedBranchRequest);
            return new SyncInvoker<BatchCreateProtectedBranchResponse>(this, "POST", request, response =>
            {
                var batchCreateProtectedBranchResponse = JsonUtils.DeSerializeNull<BatchCreateProtectedBranchResponse>(response);
                batchCreateProtectedBranchResponse.Body = JsonUtils.DeSerializeList<RepositoryProtectedBranchDto>(response);
                return batchCreateProtectedBranchResponse;
            });
        }
        
        /// <summary>
        /// 批量创建仓库保护Tag
        ///
        /// 批量创建仓库保护Tag
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateProtectedTagsResponse BatchCreateProtectedTags(BatchCreateProtectedTagsRequest batchCreateProtectedTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateProtectedTagsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateProtectedTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            var batchCreateProtectedTagsResponse = JsonUtils.DeSerializeNull<BatchCreateProtectedTagsResponse>(response);
            batchCreateProtectedTagsResponse.Body = JsonUtils.DeSerializeList<RepositoryProtectedTagDto>(response);
            return batchCreateProtectedTagsResponse;
        }

        public SyncInvoker<BatchCreateProtectedTagsResponse> BatchCreateProtectedTagsInvoker(BatchCreateProtectedTagsRequest batchCreateProtectedTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateProtectedTagsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateProtectedTagsRequest);
            return new SyncInvoker<BatchCreateProtectedTagsResponse>(this, "POST", request, response =>
            {
                var batchCreateProtectedTagsResponse = JsonUtils.DeSerializeNull<BatchCreateProtectedTagsResponse>(response);
                batchCreateProtectedTagsResponse.Body = JsonUtils.DeSerializeList<RepositoryProtectedTagDto>(response);
                return batchCreateProtectedTagsResponse;
            });
        }
        
        /// <summary>
        /// 批量删除仓库保护分支
        ///
        /// 批量删除仓库保护分支
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteProtectedBranchesResponse BatchDeleteProtectedBranches(BatchDeleteProtectedBranchesRequest batchDeleteProtectedBranchesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteProtectedBranchesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-branches/bulk-deletion", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteProtectedBranchesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteProtectedBranchesResponse>(response);
        }

        public SyncInvoker<BatchDeleteProtectedBranchesResponse> BatchDeleteProtectedBranchesInvoker(BatchDeleteProtectedBranchesRequest batchDeleteProtectedBranchesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteProtectedBranchesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-branches/bulk-deletion", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteProtectedBranchesRequest);
            return new SyncInvoker<BatchDeleteProtectedBranchesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteProtectedBranchesResponse>);
        }
        
        /// <summary>
        /// 批量删除仓库保护Tag
        ///
        /// 批量删除仓库保护Tag
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteProtectedTagsResponse BatchDeleteProtectedTags(BatchDeleteProtectedTagsRequest batchDeleteProtectedTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteProtectedTagsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-tags/bulk-deletion", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteProtectedTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteProtectedTagsResponse>(response);
        }

        public SyncInvoker<BatchDeleteProtectedTagsResponse> BatchDeleteProtectedTagsInvoker(BatchDeleteProtectedTagsRequest batchDeleteProtectedTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteProtectedTagsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-tags/bulk-deletion", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteProtectedTagsRequest);
            return new SyncInvoker<BatchDeleteProtectedTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteProtectedTagsResponse>);
        }
        
        /// <summary>
        /// 批量更新仓库保护分支
        ///
        /// 批量更新仓库保护分支
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchUpdateProtectedBranchesResponse BatchUpdateProtectedBranches(BatchUpdateProtectedBranchesRequest batchUpdateProtectedBranchesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateProtectedBranchesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateProtectedBranchesRequest);
            var response = DoHttpRequestSync("PUT", request);
            var batchUpdateProtectedBranchesResponse = JsonUtils.DeSerializeNull<BatchUpdateProtectedBranchesResponse>(response);
            batchUpdateProtectedBranchesResponse.Body = JsonUtils.DeSerializeList<RepositoryProtectedBranchDto>(response);
            return batchUpdateProtectedBranchesResponse;
        }

        public SyncInvoker<BatchUpdateProtectedBranchesResponse> BatchUpdateProtectedBranchesInvoker(BatchUpdateProtectedBranchesRequest batchUpdateProtectedBranchesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateProtectedBranchesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateProtectedBranchesRequest);
            return new SyncInvoker<BatchUpdateProtectedBranchesResponse>(this, "PUT", request, response =>
            {
                var batchUpdateProtectedBranchesResponse = JsonUtils.DeSerializeNull<BatchUpdateProtectedBranchesResponse>(response);
                batchUpdateProtectedBranchesResponse.Body = JsonUtils.DeSerializeList<RepositoryProtectedBranchDto>(response);
                return batchUpdateProtectedBranchesResponse;
            });
        }
        
        /// <summary>
        /// 批量更新仓库保护Tag
        ///
        /// 批量更新仓库保护Tag
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchUpdateProtectedTagsResponse BatchUpdateProtectedTags(BatchUpdateProtectedTagsRequest batchUpdateProtectedTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateProtectedTagsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateProtectedTagsRequest);
            var response = DoHttpRequestSync("PUT", request);
            var batchUpdateProtectedTagsResponse = JsonUtils.DeSerializeNull<BatchUpdateProtectedTagsResponse>(response);
            batchUpdateProtectedTagsResponse.Body = JsonUtils.DeSerializeList<RepositoryProtectedTagDto>(response);
            return batchUpdateProtectedTagsResponse;
        }

        public SyncInvoker<BatchUpdateProtectedTagsResponse> BatchUpdateProtectedTagsInvoker(BatchUpdateProtectedTagsRequest batchUpdateProtectedTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateProtectedTagsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateProtectedTagsRequest);
            return new SyncInvoker<BatchUpdateProtectedTagsResponse>(this, "PUT", request, response =>
            {
                var batchUpdateProtectedTagsResponse = JsonUtils.DeSerializeNull<BatchUpdateProtectedTagsResponse>(response);
                batchUpdateProtectedTagsResponse.Body = JsonUtils.DeSerializeList<RepositoryProtectedTagDto>(response);
                return batchUpdateProtectedTagsResponse;
            });
        }
        
        /// <summary>
        /// 创建项目下保护分支
        ///
        /// 创建项目下保护分支
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateProjectProtectedBranchesResponse CreateProjectProtectedBranches(CreateProjectProtectedBranchesRequest createProjectProtectedBranchesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createProjectProtectedBranchesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/protected-branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProjectProtectedBranchesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateProjectProtectedBranchesResponse>(response);
        }

        public SyncInvoker<CreateProjectProtectedBranchesResponse> CreateProjectProtectedBranchesInvoker(CreateProjectProtectedBranchesRequest createProjectProtectedBranchesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createProjectProtectedBranchesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/protected-branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProjectProtectedBranchesRequest);
            return new SyncInvoker<CreateProjectProtectedBranchesResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateProjectProtectedBranchesResponse>);
        }
        
        /// <summary>
        /// 创建项目下的保护tag
        ///
        /// 创建项目下的保护tag
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateProjectProtectedTagsResponse CreateProjectProtectedTags(CreateProjectProtectedTagsRequest createProjectProtectedTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createProjectProtectedTagsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/protected-tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProjectProtectedTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateProjectProtectedTagsResponse>(response);
        }

        public SyncInvoker<CreateProjectProtectedTagsResponse> CreateProjectProtectedTagsInvoker(CreateProjectProtectedTagsRequest createProjectProtectedTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createProjectProtectedTagsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/protected-tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProjectProtectedTagsRequest);
            return new SyncInvoker<CreateProjectProtectedTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateProjectProtectedTagsResponse>);
        }
        
        /// <summary>
        /// 删除仓库保护分支
        ///
        /// 删除仓库保护分支
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteProtectedBranchResponse DeleteProtectedBranch(DeleteProtectedBranchRequest deleteProtectedBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteProtectedBranchRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-branch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProtectedBranchRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteProtectedBranchResponse>(response);
        }

        public SyncInvoker<DeleteProtectedBranchResponse> DeleteProtectedBranchInvoker(DeleteProtectedBranchRequest deleteProtectedBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteProtectedBranchRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-branch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProtectedBranchRequest);
            return new SyncInvoker<DeleteProtectedBranchResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteProtectedBranchResponse>);
        }
        
        /// <summary>
        /// 删除仓库保护Tag
        ///
        /// 删除仓库保护Tag
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteProtectedTagResponse DeleteProtectedTag(DeleteProtectedTagRequest deleteProtectedTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteProtectedTagRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProtectedTagRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteProtectedTagResponse>(response);
        }

        public SyncInvoker<DeleteProtectedTagResponse> DeleteProtectedTagInvoker(DeleteProtectedTagRequest deleteProtectedTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteProtectedTagRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProtectedTagRequest);
            return new SyncInvoker<DeleteProtectedTagResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteProtectedTagResponse>);
        }
        
        /// <summary>
        /// 获取项目下保护分支列表
        ///
        /// 获取项目下保护分支列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProjectProtectedBranchesResponse ListProjectProtectedBranches(ListProjectProtectedBranchesRequest listProjectProtectedBranchesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectProtectedBranchesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/protected-branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectProtectedBranchesRequest);
            var response = DoHttpRequestSync("GET", request);
            var listProjectProtectedBranchesResponse = JsonUtils.DeSerializeNull<ListProjectProtectedBranchesResponse>(response);
            listProjectProtectedBranchesResponse.Body = JsonUtils.DeSerializeList<ProjectProtectedBranchApiDto>(response);
            return listProjectProtectedBranchesResponse;
        }

        public SyncInvoker<ListProjectProtectedBranchesResponse> ListProjectProtectedBranchesInvoker(ListProjectProtectedBranchesRequest listProjectProtectedBranchesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectProtectedBranchesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/protected-branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectProtectedBranchesRequest);
            return new SyncInvoker<ListProjectProtectedBranchesResponse>(this, "GET", request, response =>
            {
                var listProjectProtectedBranchesResponse = JsonUtils.DeSerializeNull<ListProjectProtectedBranchesResponse>(response);
                listProjectProtectedBranchesResponse.Body = JsonUtils.DeSerializeList<ProjectProtectedBranchApiDto>(response);
                return listProjectProtectedBranchesResponse;
            });
        }
        
        /// <summary>
        /// 获取指定项目的保护tag详情
        ///
        /// 获取指定项目的保护tag详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProjectProtectedTagsResponse ListProjectProtectedTags(ListProjectProtectedTagsRequest listProjectProtectedTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectProtectedTagsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/protected-tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectProtectedTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listProjectProtectedTagsResponse = JsonUtils.DeSerializeNull<ListProjectProtectedTagsResponse>(response);
            listProjectProtectedTagsResponse.Body = JsonUtils.DeSerializeList<ProjectProtectedTagPo>(response);
            return listProjectProtectedTagsResponse;
        }

        public SyncInvoker<ListProjectProtectedTagsResponse> ListProjectProtectedTagsInvoker(ListProjectProtectedTagsRequest listProjectProtectedTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectProtectedTagsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/protected-tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectProtectedTagsRequest);
            return new SyncInvoker<ListProjectProtectedTagsResponse>(this, "GET", request, response =>
            {
                var listProjectProtectedTagsResponse = JsonUtils.DeSerializeNull<ListProjectProtectedTagsResponse>(response);
                listProjectProtectedTagsResponse.Body = JsonUtils.DeSerializeList<ProjectProtectedTagPo>(response);
                return listProjectProtectedTagsResponse;
            });
        }
        
        /// <summary>
        /// 获取仓库保护分支列表
        ///
        /// 获取仓库保护分支列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProtectedBranchesResponse ListProtectedBranches(ListProtectedBranchesRequest listProtectedBranchesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProtectedBranchesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProtectedBranchesRequest);
            var response = DoHttpRequestSync("GET", request);
            var listProtectedBranchesResponse = JsonUtils.DeSerializeNull<ListProtectedBranchesResponse>(response);
            listProtectedBranchesResponse.Body = JsonUtils.DeSerializeList<RepositoryProtectedBranchDto>(response);
            return listProtectedBranchesResponse;
        }

        public SyncInvoker<ListProtectedBranchesResponse> ListProtectedBranchesInvoker(ListProtectedBranchesRequest listProtectedBranchesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProtectedBranchesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProtectedBranchesRequest);
            return new SyncInvoker<ListProtectedBranchesResponse>(this, "GET", request, response =>
            {
                var listProtectedBranchesResponse = JsonUtils.DeSerializeNull<ListProtectedBranchesResponse>(response);
                listProtectedBranchesResponse.Body = JsonUtils.DeSerializeList<RepositoryProtectedBranchDto>(response);
                return listProtectedBranchesResponse;
            });
        }
        
        /// <summary>
        /// 获取仓库保护Tag列表
        ///
        /// 获取仓库保护Tag列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProtectedTagsResponse ListProtectedTags(ListProtectedTagsRequest listProtectedTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProtectedTagsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProtectedTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listProtectedTagsResponse = JsonUtils.DeSerializeNull<ListProtectedTagsResponse>(response);
            listProtectedTagsResponse.Body = JsonUtils.DeSerializeList<RepositoryProtectedTagDto>(response);
            return listProtectedTagsResponse;
        }

        public SyncInvoker<ListProtectedTagsResponse> ListProtectedTagsInvoker(ListProtectedTagsRequest listProtectedTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProtectedTagsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProtectedTagsRequest);
            return new SyncInvoker<ListProtectedTagsResponse>(this, "GET", request, response =>
            {
                var listProtectedTagsResponse = JsonUtils.DeSerializeNull<ListProtectedTagsResponse>(response);
                listProtectedTagsResponse.Body = JsonUtils.DeSerializeList<RepositoryProtectedTagDto>(response);
                return listProtectedTagsResponse;
            });
        }
        
        /// <summary>
        /// 获取仓库保护分支
        ///
        /// 获取仓库保护分支
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowProtectedBranchResponse ShowProtectedBranch(ShowProtectedBranchRequest showProtectedBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProtectedBranchRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-branch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProtectedBranchRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowProtectedBranchResponse>(response);
        }

        public SyncInvoker<ShowProtectedBranchResponse> ShowProtectedBranchInvoker(ShowProtectedBranchRequest showProtectedBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProtectedBranchRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-branch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProtectedBranchRequest);
            return new SyncInvoker<ShowProtectedBranchResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProtectedBranchResponse>);
        }
        
        /// <summary>
        /// 获取仓库保护Tag
        ///
        /// 获取仓库保护Tag
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowProtectedTagResponse ShowProtectedTag(ShowProtectedTagRequest showProtectedTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProtectedTagRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProtectedTagRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowProtectedTagResponse>(response);
        }

        public SyncInvoker<ShowProtectedTagResponse> ShowProtectedTagInvoker(ShowProtectedTagRequest showProtectedTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProtectedTagRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProtectedTagRequest);
            return new SyncInvoker<ShowProtectedTagResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProtectedTagResponse>);
        }
        
        /// <summary>
        /// 更新仓库保护分支
        ///
        /// 更新仓库保护分支
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateProtectedBranchResponse UpdateProtectedBranch(UpdateProtectedBranchRequest updateProtectedBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProtectedBranchRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-branch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProtectedBranchRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateProtectedBranchResponse>(response);
        }

        public SyncInvoker<UpdateProtectedBranchResponse> UpdateProtectedBranchInvoker(UpdateProtectedBranchRequest updateProtectedBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProtectedBranchRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-branch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProtectedBranchRequest);
            return new SyncInvoker<UpdateProtectedBranchResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateProtectedBranchResponse>);
        }
        
        /// <summary>
        /// 更新仓库保护Tag
        ///
        /// 更新仓库保护Tag
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateProtectedTagResponse UpdateProtectedTag(UpdateProtectedTagRequest updateProtectedTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProtectedTagRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProtectedTagRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateProtectedTagResponse>(response);
        }

        public SyncInvoker<UpdateProtectedTagResponse> UpdateProtectedTagInvoker(UpdateProtectedTagRequest updateProtectedTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProtectedTagRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProtectedTagRequest);
            return new SyncInvoker<UpdateProtectedTagResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateProtectedTagResponse>);
        }
        
        /// <summary>
        /// 批量删除分支
        ///
        /// 批量删除分支
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteBranchResponse BatchDeleteBranch(BatchDeleteBranchRequest batchDeleteBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteBranchRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/branches/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteBranchRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteBranchResponse>(response);
        }

        public SyncInvoker<BatchDeleteBranchResponse> BatchDeleteBranchInvoker(BatchDeleteBranchRequest batchDeleteBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteBranchRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/branches/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteBranchRequest);
            return new SyncInvoker<BatchDeleteBranchResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteBranchResponse>);
        }
        
        /// <summary>
        /// 创建分支
        ///
        /// 创建分支
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateBranchResponse CreateBranch(CreateBranchRequest createBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createBranchRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBranchRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateBranchResponse>(response);
        }

        public SyncInvoker<CreateBranchResponse> CreateBranchInvoker(CreateBranchRequest createBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createBranchRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBranchRequest);
            return new SyncInvoker<CreateBranchResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateBranchResponse>);
        }
        
        /// <summary>
        /// 创建标签
        ///
        /// 创建标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTagResponse CreateTag(CreateTagRequest createTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTagRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateTagResponse>(response);
        }

        public SyncInvoker<CreateTagResponse> CreateTagInvoker(CreateTagRequest createTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTagRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagRequest);
            return new SyncInvoker<CreateTagResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTagResponse>);
        }
        
        /// <summary>
        /// 删除分支
        ///
        /// 删除分支
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteBranchResponse DeleteBranch(DeleteBranchRequest deleteBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteBranchRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/branch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBranchRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteBranchResponse>(response);
        }

        public SyncInvoker<DeleteBranchResponse> DeleteBranchInvoker(DeleteBranchRequest deleteBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteBranchRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/branch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBranchRequest);
            return new SyncInvoker<DeleteBranchResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteBranchResponse>);
        }
        
        /// <summary>
        /// 删除标签
        ///
        /// 删除标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTagResponse DeleteTag(DeleteTagRequest deleteTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTagRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTagResponse>(response);
        }

        public SyncInvoker<DeleteTagResponse> DeleteTagInvoker(DeleteTagRequest deleteTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTagRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagRequest);
            return new SyncInvoker<DeleteTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTagResponse>);
        }
        
        /// <summary>
        /// 获取分支列表
        ///
        /// 获取分支列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBranchesResponse ListBranches(ListBranchesRequest listBranchesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBranchesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBranchesRequest);
            var response = DoHttpRequestSync("GET", request);
            var listBranchesResponse = JsonUtils.DeSerializeNull<ListBranchesResponse>(response);
            listBranchesResponse.Body = JsonUtils.DeSerializeList<BranchSimpleDto>(response);
            return listBranchesResponse;
        }

        public SyncInvoker<ListBranchesResponse> ListBranchesInvoker(ListBranchesRequest listBranchesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBranchesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBranchesRequest);
            return new SyncInvoker<ListBranchesResponse>(this, "GET", request, response =>
            {
                var listBranchesResponse = JsonUtils.DeSerializeNull<ListBranchesResponse>(response);
                listBranchesResponse.Body = JsonUtils.DeSerializeList<BranchSimpleDto>(response);
                return listBranchesResponse;
            });
        }
        
        /// <summary>
        /// 查看分支/tag列表
        ///
        /// 查看分支/tag列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRefsListResponse ListRefsList(ListRefsListRequest listRefsListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRefsListRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/refs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRefsListRequest);
            var response = DoHttpRequestSync("GET", request);
            var listRefsListResponse = JsonUtils.DeSerializeNull<ListRefsListResponse>(response);
            listRefsListResponse.Body = JsonUtils.DeSerializeList<string>(response);
            return listRefsListResponse;
        }

        public SyncInvoker<ListRefsListResponse> ListRefsListInvoker(ListRefsListRequest listRefsListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRefsListRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/refs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRefsListRequest);
            return new SyncInvoker<ListRefsListResponse>(this, "GET", request, response =>
            {
                var listRefsListResponse = JsonUtils.DeSerializeNull<ListRefsListResponse>(response);
                listRefsListResponse.Body = JsonUtils.DeSerializeList<string>(response);
                return listRefsListResponse;
            });
        }
        
        /// <summary>
        /// 获取标签列表
        ///
        /// 获取标签列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTagsResponse ListTags(ListTagsRequest listTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTagsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listTagsResponse = JsonUtils.DeSerializeNull<ListTagsResponse>(response);
            listTagsResponse.Body = JsonUtils.DeSerializeList<SimpleTagDto>(response);
            return listTagsResponse;
        }

        public SyncInvoker<ListTagsResponse> ListTagsInvoker(ListTagsRequest listTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTagsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsRequest);
            return new SyncInvoker<ListTagsResponse>(this, "GET", request, response =>
            {
                var listTagsResponse = JsonUtils.DeSerializeNull<ListTagsResponse>(response);
                listTagsResponse.Body = JsonUtils.DeSerializeList<SimpleTagDto>(response);
                return listTagsResponse;
            });
        }
        
        /// <summary>
        /// 获取分支详情
        ///
        /// 获取分支详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBranchResponse ShowBranch(ShowBranchRequest showBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBranchRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/branch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBranchRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBranchResponse>(response);
        }

        public SyncInvoker<ShowBranchResponse> ShowBranchInvoker(ShowBranchRequest showBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBranchRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/branch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBranchRequest);
            return new SyncInvoker<ShowBranchResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBranchResponse>);
        }
        
        /// <summary>
        /// 查看标签详情
        ///
        /// 查看标签详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTagResponse ShowTag(ShowTagRequest showTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTagRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTagRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTagResponse>(response);
        }

        public SyncInvoker<ShowTagResponse> ShowTagInvoker(ShowTagRequest showTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTagRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTagRequest);
            return new SyncInvoker<ShowTagResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTagResponse>);
        }
        
        /// <summary>
        /// 分支重命名
        ///
        /// 分支重命名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateBranchNameResponse UpdateBranchName(UpdateBranchNameRequest updateBranchNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateBranchNameRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/branch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBranchNameRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateBranchNameResponse>(response);
        }

        public SyncInvoker<UpdateBranchNameResponse> UpdateBranchNameInvoker(UpdateBranchNameRequest updateBranchNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateBranchNameRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/branch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBranchNameRequest);
            return new SyncInvoker<UpdateBranchNameResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateBranchNameResponse>);
        }
        
        /// <summary>
        /// 创建子模块
        ///
        /// 创建子模块
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddSubmoduleResponse AddSubmodule(AddSubmoduleRequest addSubmoduleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addSubmoduleRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/submodules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addSubmoduleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddSubmoduleResponse>(response);
        }

        public SyncInvoker<AddSubmoduleResponse> AddSubmoduleInvoker(AddSubmoduleRequest addSubmoduleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addSubmoduleRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/submodules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addSubmoduleRequest);
            return new SyncInvoker<AddSubmoduleResponse>(this, "POST", request, JsonUtils.DeSerialize<AddSubmoduleResponse>);
        }
        
        /// <summary>
        /// 添加仓库ip白名单
        ///
        /// 添加仓库ip白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddTrustedIpAddressResponse AddTrustedIpAddress(AddTrustedIpAddressRequest addTrustedIpAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addTrustedIpAddressRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{id}/trusted-ip-addresses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addTrustedIpAddressRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddTrustedIpAddressResponse>(response);
        }

        public SyncInvoker<AddTrustedIpAddressResponse> AddTrustedIpAddressInvoker(AddTrustedIpAddressRequest addTrustedIpAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addTrustedIpAddressRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{id}/trusted-ip-addresses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addTrustedIpAddressRequest);
            return new SyncInvoker<AddTrustedIpAddressResponse>(this, "POST", request, JsonUtils.DeSerialize<AddTrustedIpAddressResponse>);
        }
        
        /// <summary>
        /// 将普通仓库与远程镜像关联
        ///
        /// 将普通仓库与远程镜像关联
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AssociateRemoteMirrorResponse AssociateRemoteMirror(AssociateRemoteMirrorRequest associateRemoteMirrorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateRemoteMirrorRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/remote-mirror/associate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateRemoteMirrorRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AssociateRemoteMirrorResponse>(response);
        }

        public SyncInvoker<AssociateRemoteMirrorResponse> AssociateRemoteMirrorInvoker(AssociateRemoteMirrorRequest associateRemoteMirrorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateRemoteMirrorRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/remote-mirror/associate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateRemoteMirrorRequest);
            return new SyncInvoker<AssociateRemoteMirrorResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateRemoteMirrorResponse>);
        }
        
        /// <summary>
        /// 关联仓库与成员组
        ///
        /// 关联仓库与成员组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AssociateRepositoryUserGroupResponse AssociateRepositoryUserGroup(AssociateRepositoryUserGroupRequest associateRepositoryUserGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateRepositoryUserGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(associateRepositoryUserGroupRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(associateRepositoryUserGroupRequest.UserGroupId, out var valueOfUserGroupId)) urlParam.Add("user_group_id", valueOfUserGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/repositories/{repository_id}/user-group/{user_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateRepositoryUserGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AssociateRepositoryUserGroupResponse>(response);
        }

        public SyncInvoker<AssociateRepositoryUserGroupResponse> AssociateRepositoryUserGroupInvoker(AssociateRepositoryUserGroupRequest associateRepositoryUserGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateRepositoryUserGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(associateRepositoryUserGroupRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(associateRepositoryUserGroupRequest.UserGroupId, out var valueOfUserGroupId)) urlParam.Add("user_group_id", valueOfUserGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/repositories/{repository_id}/user-group/{user_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateRepositoryUserGroupRequest);
            return new SyncInvoker<AssociateRepositoryUserGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateRepositoryUserGroupResponse>);
        }
        
        /// <summary>
        /// 批量检查仓库名
        ///
        /// 批量检查仓库名
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchValidateRepoNamesResponse BatchValidateRepoNames(BatchValidateRepoNamesRequest batchValidateRepoNamesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/repository-names/validations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchValidateRepoNamesRequest);
            var response = DoHttpRequestSync("POST", request);
            var batchValidateRepoNamesResponse = JsonUtils.DeSerializeNull<BatchValidateRepoNamesResponse>(response);
            batchValidateRepoNamesResponse.Body = JsonUtils.DeSerializeList<ValidateRepoNameResultDto>(response);
            return batchValidateRepoNamesResponse;
        }

        public SyncInvoker<BatchValidateRepoNamesResponse> BatchValidateRepoNamesInvoker(BatchValidateRepoNamesRequest batchValidateRepoNamesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/repository-names/validations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchValidateRepoNamesRequest);
            return new SyncInvoker<BatchValidateRepoNamesResponse>(this, "POST", request, response =>
            {
                var batchValidateRepoNamesResponse = JsonUtils.DeSerializeNull<BatchValidateRepoNamesResponse>(response);
                batchValidateRepoNamesResponse.Body = JsonUtils.DeSerializeList<ValidateRepoNameResultDto>(response);
                return batchValidateRepoNamesResponse;
            });
        }
        
        /// <summary>
        /// 创建指定分支下的目录
        ///
        /// 创建指定分支下的目录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDirResponse CreateDir(CreateDirRequest createDirRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createDirRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/dir", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDirRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateDirResponse>(response);
        }

        public SyncInvoker<CreateDirResponse> CreateDirInvoker(CreateDirRequest createDirRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createDirRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/dir", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDirRequest);
            return new SyncInvoker<CreateDirResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateDirResponse>);
        }
        
        /// <summary>
        /// 创建仓库提交规则
        ///
        /// 创建仓库提交规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRepositoryCommitRuleResponse CreateRepositoryCommitRule(CreateRepositoryCommitRuleRequest createRepositoryCommitRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRepositoryCommitRuleRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/commit-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepositoryCommitRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateRepositoryCommitRuleResponse>(response);
        }

        public SyncInvoker<CreateRepositoryCommitRuleResponse> CreateRepositoryCommitRuleInvoker(CreateRepositoryCommitRuleRequest createRepositoryCommitRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRepositoryCommitRuleRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/commit-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepositoryCommitRuleRequest);
            return new SyncInvoker<CreateRepositoryCommitRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRepositoryCommitRuleResponse>);
        }
        
        /// <summary>
        /// 创建仓库标签
        ///
        /// 创建仓库标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRepositoryLabelResponse CreateRepositoryLabel(CreateRepositoryLabelRequest createRepositoryLabelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRepositoryLabelRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/labels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepositoryLabelRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateRepositoryLabelResponse>(response);
        }

        public SyncInvoker<CreateRepositoryLabelResponse> CreateRepositoryLabelInvoker(CreateRepositoryLabelRequest createRepositoryLabelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRepositoryLabelRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/labels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepositoryLabelRequest);
            return new SyncInvoker<CreateRepositoryLabelResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRepositoryLabelResponse>);
        }
        
        /// <summary>
        /// 创建仓库系统标签
        ///
        /// 创建仓库系统标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRepositorySystemLabelsResponse CreateRepositorySystemLabels(CreateRepositorySystemLabelsRequest createRepositorySystemLabelsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRepositorySystemLabelsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/system-labels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepositorySystemLabelsRequest);
            var response = DoHttpRequestSync("POST", request);
            var createRepositorySystemLabelsResponse = JsonUtils.DeSerializeNull<CreateRepositorySystemLabelsResponse>(response);
            createRepositorySystemLabelsResponse.Body = JsonUtils.DeSerializeList<LabelDetailDto>(response);
            return createRepositorySystemLabelsResponse;
        }

        public SyncInvoker<CreateRepositorySystemLabelsResponse> CreateRepositorySystemLabelsInvoker(CreateRepositorySystemLabelsRequest createRepositorySystemLabelsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRepositorySystemLabelsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/system-labels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepositorySystemLabelsRequest);
            return new SyncInvoker<CreateRepositorySystemLabelsResponse>(this, "POST", request, response =>
            {
                var createRepositorySystemLabelsResponse = JsonUtils.DeSerializeNull<CreateRepositorySystemLabelsResponse>(response);
                createRepositorySystemLabelsResponse.Body = JsonUtils.DeSerializeList<LabelDetailDto>(response);
                return createRepositorySystemLabelsResponse;
            });
        }
        
        /// <summary>
        /// 删除仓库标签
        ///
        /// 删除仓库标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteRepositoryLabelResponse DeleteRepositoryLabel(DeleteRepositoryLabelRequest deleteRepositoryLabelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRepositoryLabelRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/label", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepositoryLabelRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRepositoryLabelResponse>(response);
        }

        public SyncInvoker<DeleteRepositoryLabelResponse> DeleteRepositoryLabelInvoker(DeleteRepositoryLabelRequest deleteRepositoryLabelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRepositoryLabelRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/label", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepositoryLabelRequest);
            return new SyncInvoker<DeleteRepositoryLabelResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRepositoryLabelResponse>);
        }
        
        /// <summary>
        /// 删除仓库ip白名单
        ///
        /// 删除仓库ip白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTrustedIpAddressResponse DeleteTrustedIpAddress(DeleteTrustedIpAddressRequest deleteTrustedIpAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTrustedIpAddressRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            if (StringUtils.TryConvertToNonEmptyString(deleteTrustedIpAddressRequest.IpId, out var valueOfIpId)) urlParam.Add("ip_id", valueOfIpId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{id}/trusted-ip-addresses/{ip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTrustedIpAddressRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteTrustedIpAddressResponse>(response);
        }

        public SyncInvoker<DeleteTrustedIpAddressResponse> DeleteTrustedIpAddressInvoker(DeleteTrustedIpAddressRequest deleteTrustedIpAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTrustedIpAddressRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            if (StringUtils.TryConvertToNonEmptyString(deleteTrustedIpAddressRequest.IpId, out var valueOfIpId)) urlParam.Add("ip_id", valueOfIpId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{id}/trusted-ip-addresses/{ip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTrustedIpAddressRequest);
            return new SyncInvoker<DeleteTrustedIpAddressResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteTrustedIpAddressResponse>);
        }
        
        /// <summary>
        /// 仓库下载
        ///
        /// 仓库下载
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DownloadArchiveResponse DownloadArchive(DownloadArchiveRequest downloadArchiveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadArchiveRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/archive", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadArchiveRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DownloadArchiveResponse>(response);
        }

        public SyncInvoker<DownloadArchiveResponse> DownloadArchiveInvoker(DownloadArchiveRequest downloadArchiveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadArchiveRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/archive", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadArchiveRequest);
            return new SyncInvoker<DownloadArchiveResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadArchiveResponse>);
        }
        
        /// <summary>
        /// 触发仓库统计任务
        ///
        /// 触发仓库统计任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExecuteRepositoryStatisticsResponse ExecuteRepositoryStatistics(ExecuteRepositoryStatisticsRequest executeRepositoryStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeRepositoryStatisticsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeRepositoryStatisticsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ExecuteRepositoryStatisticsResponse>(response);
        }

        public SyncInvoker<ExecuteRepositoryStatisticsResponse> ExecuteRepositoryStatisticsInvoker(ExecuteRepositoryStatisticsRequest executeRepositoryStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeRepositoryStatisticsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeRepositoryStatisticsRequest);
            return new SyncInvoker<ExecuteRepositoryStatisticsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ExecuteRepositoryStatisticsResponse>);
        }
        
        /// <summary>
        /// 获取当前登录用户仓库
        ///
        /// 获取当前登录用户仓库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCurrentUserRepositoriesResponse ListCurrentUserRepositories(ListCurrentUserRepositoriesRequest listCurrentUserRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCurrentUserRepositoriesRequest);
            var response = DoHttpRequestSync("GET", request);
            var listCurrentUserRepositoriesResponse = JsonUtils.DeSerializeNull<ListCurrentUserRepositoriesResponse>(response);
            listCurrentUserRepositoriesResponse.Body = JsonUtils.DeSerializeList<RepositorySimplestDto>(response);
            return listCurrentUserRepositoriesResponse;
        }

        public SyncInvoker<ListCurrentUserRepositoriesResponse> ListCurrentUserRepositoriesInvoker(ListCurrentUserRepositoriesRequest listCurrentUserRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCurrentUserRepositoriesRequest);
            return new SyncInvoker<ListCurrentUserRepositoriesResponse>(this, "GET", request, response =>
            {
                var listCurrentUserRepositoriesResponse = JsonUtils.DeSerializeNull<ListCurrentUserRepositoriesResponse>(response);
                listCurrentUserRepositoriesResponse.Body = JsonUtils.DeSerializeList<RepositorySimplestDto>(response);
                return listCurrentUserRepositoriesResponse;
            });
        }
        
        /// <summary>
        /// 获取代码组下仓库列表
        ///
        /// 获取代码组下仓库列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGroupRepositoriesResponse ListGroupRepositories(ListGroupRepositoriesRequest listGroupRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupRepositoriesRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupRepositoriesRequest);
            var response = DoHttpRequestSync("GET", request);
            var listGroupRepositoriesResponse = JsonUtils.DeSerializeNull<ListGroupRepositoriesResponse>(response);
            listGroupRepositoriesResponse.Body = JsonUtils.DeSerializeList<BasicRepositoryDto>(response);
            return listGroupRepositoriesResponse;
        }

        public SyncInvoker<ListGroupRepositoriesResponse> ListGroupRepositoriesInvoker(ListGroupRepositoriesRequest listGroupRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupRepositoriesRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupRepositoriesRequest);
            return new SyncInvoker<ListGroupRepositoriesResponse>(this, "GET", request, response =>
            {
                var listGroupRepositoriesResponse = JsonUtils.DeSerializeNull<ListGroupRepositoriesResponse>(response);
                listGroupRepositoriesResponse.Body = JsonUtils.DeSerializeList<BasicRepositoryDto>(response);
                return listGroupRepositoriesResponse;
            });
        }
        
        /// <summary>
        /// 获取当前用户最近提交动态列表
        ///
        /// 查询当前最近前N条提交动态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPersonalRecentPushEventsResponse ListPersonalRecentPushEvents(ListPersonalRecentPushEventsRequest listPersonalRecentPushEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/recent-push-events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPersonalRecentPushEventsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listPersonalRecentPushEventsResponse = JsonUtils.DeSerializeNull<ListPersonalRecentPushEventsResponse>(response);
            listPersonalRecentPushEventsResponse.Body = JsonUtils.DeSerializeList<PersonalPushEventDto>(response);
            return listPersonalRecentPushEventsResponse;
        }

        public SyncInvoker<ListPersonalRecentPushEventsResponse> ListPersonalRecentPushEventsInvoker(ListPersonalRecentPushEventsRequest listPersonalRecentPushEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/recent-push-events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPersonalRecentPushEventsRequest);
            return new SyncInvoker<ListPersonalRecentPushEventsResponse>(this, "GET", request, response =>
            {
                var listPersonalRecentPushEventsResponse = JsonUtils.DeSerializeNull<ListPersonalRecentPushEventsResponse>(response);
                listPersonalRecentPushEventsResponse.Body = JsonUtils.DeSerializeList<PersonalPushEventDto>(response);
                return listPersonalRecentPushEventsResponse;
            });
        }
        
        /// <summary>
        /// 查看当前用户仓库导入任务列表
        ///
        /// 查看当前用户仓库导入任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPersonalRepositoryImportRecordsResponse ListPersonalRepositoryImportRecords(ListPersonalRepositoryImportRecordsRequest listPersonalRepositoryImportRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/repository-import-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPersonalRepositoryImportRecordsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listPersonalRepositoryImportRecordsResponse = JsonUtils.DeSerializeNull<ListPersonalRepositoryImportRecordsResponse>(response);
            listPersonalRepositoryImportRecordsResponse.Body = JsonUtils.DeSerializeList<RepositoryImportRecordDto>(response);
            return listPersonalRepositoryImportRecordsResponse;
        }

        public SyncInvoker<ListPersonalRepositoryImportRecordsResponse> ListPersonalRepositoryImportRecordsInvoker(ListPersonalRepositoryImportRecordsRequest listPersonalRepositoryImportRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/repository-import-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPersonalRepositoryImportRecordsRequest);
            return new SyncInvoker<ListPersonalRepositoryImportRecordsResponse>(this, "GET", request, response =>
            {
                var listPersonalRepositoryImportRecordsResponse = JsonUtils.DeSerializeNull<ListPersonalRepositoryImportRecordsResponse>(response);
                listPersonalRepositoryImportRecordsResponse.Body = JsonUtils.DeSerializeList<RepositoryImportRecordDto>(response);
                return listPersonalRepositoryImportRecordsResponse;
            });
        }
        
        /// <summary>
        /// 获取项目下仓库列表
        ///
        /// 获取项目下仓库列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProjectRepositoriesResponse ListProjectRepositories(ListProjectRepositoriesRequest listProjectRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectRepositoriesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectRepositoriesRequest);
            var response = DoHttpRequestSync("GET", request);
            var listProjectRepositoriesResponse = JsonUtils.DeSerializeNull<ListProjectRepositoriesResponse>(response);
            listProjectRepositoriesResponse.Body = JsonUtils.DeSerializeList<BasicRepositoryDto>(response);
            return listProjectRepositoriesResponse;
        }

        public SyncInvoker<ListProjectRepositoriesResponse> ListProjectRepositoriesInvoker(ListProjectRepositoriesRequest listProjectRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectRepositoriesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectRepositoriesRequest);
            return new SyncInvoker<ListProjectRepositoriesResponse>(this, "GET", request, response =>
            {
                var listProjectRepositoriesResponse = JsonUtils.DeSerializeNull<ListProjectRepositoriesResponse>(response);
                listProjectRepositoriesResponse.Body = JsonUtils.DeSerializeList<BasicRepositoryDto>(response);
                return listProjectRepositoriesResponse;
            });
        }
        
        /// <summary>
        /// 查看仓库提交规则
        ///
        /// 查看仓库提交规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRepositoryCommitRulesResponse ListRepositoryCommitRules(ListRepositoryCommitRulesRequest listRepositoryCommitRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryCommitRulesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/commit-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryCommitRulesRequest);
            var response = DoHttpRequestSync("GET", request);
            var listRepositoryCommitRulesResponse = JsonUtils.DeSerializeNull<ListRepositoryCommitRulesResponse>(response);
            listRepositoryCommitRulesResponse.Body = JsonUtils.DeSerializeList<CommitRuleDto>(response);
            return listRepositoryCommitRulesResponse;
        }

        public SyncInvoker<ListRepositoryCommitRulesResponse> ListRepositoryCommitRulesInvoker(ListRepositoryCommitRulesRequest listRepositoryCommitRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryCommitRulesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/commit-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryCommitRulesRequest);
            return new SyncInvoker<ListRepositoryCommitRulesResponse>(this, "GET", request, response =>
            {
                var listRepositoryCommitRulesResponse = JsonUtils.DeSerializeNull<ListRepositoryCommitRulesResponse>(response);
                listRepositoryCommitRulesResponse.Body = JsonUtils.DeSerializeList<CommitRuleDto>(response);
                return listRepositoryCommitRulesResponse;
            });
        }
        
        /// <summary>
        /// 获取仓库贡献者列表
        ///
        /// 获取仓库贡献者列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRepositoryContributorsResponse ListRepositoryContributors(ListRepositoryContributorsRequest listRepositoryContributorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryContributorsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/contributors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryContributorsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listRepositoryContributorsResponse = JsonUtils.DeSerializeNull<ListRepositoryContributorsResponse>(response);
            listRepositoryContributorsResponse.Body = JsonUtils.DeSerializeList<ContributorDto>(response);
            return listRepositoryContributorsResponse;
        }

        public SyncInvoker<ListRepositoryContributorsResponse> ListRepositoryContributorsInvoker(ListRepositoryContributorsRequest listRepositoryContributorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryContributorsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/contributors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryContributorsRequest);
            return new SyncInvoker<ListRepositoryContributorsResponse>(this, "GET", request, response =>
            {
                var listRepositoryContributorsResponse = JsonUtils.DeSerializeNull<ListRepositoryContributorsResponse>(response);
                listRepositoryContributorsResponse.Body = JsonUtils.DeSerializeList<ContributorDto>(response);
                return listRepositoryContributorsResponse;
            });
        }
        
        /// <summary>
        /// 获取仓库动态
        ///
        /// 获取仓库动态（当前仅开放推送动态）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRepositoryEventsResponse ListRepositoryEvents(ListRepositoryEventsRequest listRepositoryEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryEventsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryEventsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listRepositoryEventsResponse = JsonUtils.DeSerializeNull<ListRepositoryEventsResponse>(response);
            listRepositoryEventsResponse.Body = JsonUtils.DeSerializeList<RepositoryPushEventDto>(response);
            return listRepositoryEventsResponse;
        }

        public SyncInvoker<ListRepositoryEventsResponse> ListRepositoryEventsInvoker(ListRepositoryEventsRequest listRepositoryEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryEventsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryEventsRequest);
            return new SyncInvoker<ListRepositoryEventsResponse>(this, "GET", request, response =>
            {
                var listRepositoryEventsResponse = JsonUtils.DeSerializeNull<ListRepositoryEventsResponse>(response);
                listRepositoryEventsResponse.Body = JsonUtils.DeSerializeList<RepositoryPushEventDto>(response);
                return listRepositoryEventsResponse;
            });
        }
        
        /// <summary>
        /// 获取仓库Fork列表
        ///
        /// 获取仓库Fork列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRepositoryForksResponse ListRepositoryForks(ListRepositoryForksRequest listRepositoryForksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryForksRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/forks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryForksRequest);
            var response = DoHttpRequestSync("GET", request);
            var listRepositoryForksResponse = JsonUtils.DeSerializeNull<ListRepositoryForksResponse>(response);
            listRepositoryForksResponse.Body = JsonUtils.DeSerializeList<ForkRepositoryDto>(response);
            return listRepositoryForksResponse;
        }

        public SyncInvoker<ListRepositoryForksResponse> ListRepositoryForksInvoker(ListRepositoryForksRequest listRepositoryForksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryForksRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/forks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryForksRequest);
            return new SyncInvoker<ListRepositoryForksResponse>(this, "GET", request, response =>
            {
                var listRepositoryForksResponse = JsonUtils.DeSerializeNull<ListRepositoryForksResponse>(response);
                listRepositoryForksResponse.Body = JsonUtils.DeSerializeList<ForkRepositoryDto>(response);
                return listRepositoryForksResponse;
            });
        }
        
        /// <summary>
        /// 获取仓库标签列表
        ///
        /// 获取仓库标签列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRepositoryLabelsResponse ListRepositoryLabels(ListRepositoryLabelsRequest listRepositoryLabelsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryLabelsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/labels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryLabelsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listRepositoryLabelsResponse = JsonUtils.DeSerializeNull<ListRepositoryLabelsResponse>(response);
            listRepositoryLabelsResponse.Body = JsonUtils.DeSerializeList<LabelBasicDto>(response);
            return listRepositoryLabelsResponse;
        }

        public SyncInvoker<ListRepositoryLabelsResponse> ListRepositoryLabelsInvoker(ListRepositoryLabelsRequest listRepositoryLabelsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryLabelsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/labels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryLabelsRequest);
            return new SyncInvoker<ListRepositoryLabelsResponse>(this, "GET", request, response =>
            {
                var listRepositoryLabelsResponse = JsonUtils.DeSerializeNull<ListRepositoryLabelsResponse>(response);
                listRepositoryLabelsResponse.Body = JsonUtils.DeSerializeList<LabelBasicDto>(response);
                return listRepositoryLabelsResponse;
            });
        }
        
        /// <summary>
        /// 获取仓库默认分支语言统计
        ///
        /// 获取仓库默认分支语言统计
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRepositoryLanguagesResponse ListRepositoryLanguages(ListRepositoryLanguagesRequest listRepositoryLanguagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryLanguagesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/languages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryLanguagesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRepositoryLanguagesResponse>(response);
        }

        public SyncInvoker<ListRepositoryLanguagesResponse> ListRepositoryLanguagesInvoker(ListRepositoryLanguagesRequest listRepositoryLanguagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryLanguagesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/languages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryLanguagesRequest);
            return new SyncInvoker<ListRepositoryLanguagesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRepositoryLanguagesResponse>);
        }
        
        /// <summary>
        /// 模板仓列表
        ///
        /// 模板仓列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRepositoryTemplatesResponse ListRepositoryTemplates(ListRepositoryTemplatesRequest listRepositoryTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/repository-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryTemplatesRequest);
            var response = DoHttpRequestSync("GET", request);
            var listRepositoryTemplatesResponse = JsonUtils.DeSerializeNull<ListRepositoryTemplatesResponse>(response);
            listRepositoryTemplatesResponse.Body = JsonUtils.DeSerializeList<RepositoryTemplateDto>(response);
            return listRepositoryTemplatesResponse;
        }

        public SyncInvoker<ListRepositoryTemplatesResponse> ListRepositoryTemplatesInvoker(ListRepositoryTemplatesRequest listRepositoryTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/repository-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryTemplatesRequest);
            return new SyncInvoker<ListRepositoryTemplatesResponse>(this, "GET", request, response =>
            {
                var listRepositoryTemplatesResponse = JsonUtils.DeSerializeNull<ListRepositoryTemplatesResponse>(response);
                listRepositoryTemplatesResponse.Body = JsonUtils.DeSerializeList<RepositoryTemplateDto>(response);
                return listRepositoryTemplatesResponse;
            });
        }
        
        /// <summary>
        /// 获取仓库指定分支或者标签子模块列表
        ///
        /// 获取仓库指定分支或者标签子模块列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSubmodulesResponse ListSubmodules(ListSubmodulesRequest listSubmodulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSubmodulesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/submodules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubmodulesRequest);
            var response = DoHttpRequestSync("GET", request);
            var listSubmodulesResponse = JsonUtils.DeSerializeNull<ListSubmodulesResponse>(response);
            listSubmodulesResponse.Body = JsonUtils.DeSerializeList<SubmoduleDto>(response);
            return listSubmodulesResponse;
        }

        public SyncInvoker<ListSubmodulesResponse> ListSubmodulesInvoker(ListSubmodulesRequest listSubmodulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSubmodulesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/submodules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubmodulesRequest);
            return new SyncInvoker<ListSubmodulesResponse>(this, "GET", request, response =>
            {
                var listSubmodulesResponse = JsonUtils.DeSerializeNull<ListSubmodulesResponse>(response);
                listSubmodulesResponse.Body = JsonUtils.DeSerializeList<SubmoduleDto>(response);
                return listSubmodulesResponse;
            });
        }
        
        /// <summary>
        /// 获取仓库ip白名单
        ///
        /// 获取仓库ip白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTrustedIpAddressesResponse ListTrustedIpAddresses(ListTrustedIpAddressesRequest listTrustedIpAddressesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTrustedIpAddressesRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{id}/trusted-ip-addresses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrustedIpAddressesRequest);
            var response = DoHttpRequestSync("GET", request);
            var listTrustedIpAddressesResponse = JsonUtils.DeSerializeNull<ListTrustedIpAddressesResponse>(response);
            listTrustedIpAddressesResponse.Body = JsonUtils.DeSerializeList<TrustedIpAddressDto>(response);
            return listTrustedIpAddressesResponse;
        }

        public SyncInvoker<ListTrustedIpAddressesResponse> ListTrustedIpAddressesInvoker(ListTrustedIpAddressesRequest listTrustedIpAddressesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTrustedIpAddressesRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{id}/trusted-ip-addresses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrustedIpAddressesRequest);
            return new SyncInvoker<ListTrustedIpAddressesResponse>(this, "GET", request, response =>
            {
                var listTrustedIpAddressesResponse = JsonUtils.DeSerializeNull<ListTrustedIpAddressesResponse>(response);
                listTrustedIpAddressesResponse.Body = JsonUtils.DeSerializeList<TrustedIpAddressDto>(response);
                return listTrustedIpAddressesResponse;
            });
        }
        
        /// <summary>
        /// 锁定仓库
        ///
        /// 锁定仓库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public LockRepositoryResponse LockRepository(LockRepositoryRequest lockRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(lockRepositoryRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(lockRepositoryRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/repositories/{repository_id}/lock", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", lockRepositoryRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<LockRepositoryResponse>(response);
        }

        public SyncInvoker<LockRepositoryResponse> LockRepositoryInvoker(LockRepositoryRequest lockRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(lockRepositoryRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(lockRepositoryRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/repositories/{repository_id}/lock", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", lockRepositoryRequest);
            return new SyncInvoker<LockRepositoryResponse>(this, "POST", request, JsonUtils.DeSerialize<LockRepositoryResponse>);
        }
        
        /// <summary>
        /// 删除仓库部署密钥
        ///
        /// 删除仓库部署密钥
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RemoveDeployKeyResponse RemoveDeployKey(RemoveDeployKeyRequest removeDeployKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeDeployKeyRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(removeDeployKeyRequest.KeyId, out var valueOfKeyId)) urlParam.Add("key_id", valueOfKeyId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/deploy-keys/{key_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeDeployKeyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<RemoveDeployKeyResponse>(response);
        }

        public SyncInvoker<RemoveDeployKeyResponse> RemoveDeployKeyInvoker(RemoveDeployKeyRequest removeDeployKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeDeployKeyRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(removeDeployKeyRequest.KeyId, out var valueOfKeyId)) urlParam.Add("key_id", valueOfKeyId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/deploy-keys/{key_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeDeployKeyRequest);
            return new SyncInvoker<RemoveDeployKeyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<RemoveDeployKeyResponse>);
        }
        
        /// <summary>
        /// 删除子仓库部署密钥
        ///
        /// 将该该仓库的部署密钥从子模组中删除
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RemoveDeployKeyFromSubmodulesResponse RemoveDeployKeyFromSubmodules(RemoveDeployKeyFromSubmodulesRequest removeDeployKeyFromSubmodulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeDeployKeyFromSubmodulesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(removeDeployKeyFromSubmodulesRequest.KeyId, out var valueOfKeyId)) urlParam.Add("key_id", valueOfKeyId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/deploy-keys/{key_id}/submodules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeDeployKeyFromSubmodulesRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<RemoveDeployKeyFromSubmodulesResponse>(response);
        }

        public SyncInvoker<RemoveDeployKeyFromSubmodulesResponse> RemoveDeployKeyFromSubmodulesInvoker(RemoveDeployKeyFromSubmodulesRequest removeDeployKeyFromSubmodulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeDeployKeyFromSubmodulesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(removeDeployKeyFromSubmodulesRequest.KeyId, out var valueOfKeyId)) urlParam.Add("key_id", valueOfKeyId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/deploy-keys/{key_id}/submodules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeDeployKeyFromSubmodulesRequest);
            return new SyncInvoker<RemoveDeployKeyFromSubmodulesResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<RemoveDeployKeyFromSubmodulesResponse>);
        }
        
        /// <summary>
        /// 获取文件内容
        ///
        /// 获取文件内容
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBlobsResponse ShowBlobs(ShowBlobsRequest showBlobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBlobsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/blobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBlobsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBlobsResponse>(response);
        }

        public SyncInvoker<ShowBlobsResponse> ShowBlobsInvoker(ShowBlobsRequest showBlobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBlobsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/blobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBlobsRequest);
            return new SyncInvoker<ShowBlobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBlobsResponse>);
        }
        
        /// <summary>
        /// 获取仓库指定分支的提交统计信息
        ///
        /// 获取仓库指定分支的提交统计信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowCommitStatisticsResponse ShowCommitStatistics(ShowCommitStatisticsRequest showCommitStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCommitStatisticsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/commit-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCommitStatisticsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowCommitStatisticsResponse>(response);
        }

        public SyncInvoker<ShowCommitStatisticsResponse> ShowCommitStatisticsInvoker(ShowCommitStatisticsRequest showCommitStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCommitStatisticsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/commit-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCommitStatisticsRequest);
            return new SyncInvoker<ShowCommitStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCommitStatisticsResponse>);
        }
        
        /// <summary>
        /// 按行数查询提交文件内容
        ///
        /// 按行数查询提交文件内容，最大显示行数为1000行
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDiffLinesResponse ShowDiffLines(ShowDiffLinesRequest showDiffLinesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDiffLinesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/diff-lines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDiffLinesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDiffLinesResponse>(response);
        }

        public SyncInvoker<ShowDiffLinesResponse> ShowDiffLinesInvoker(ShowDiffLinesRequest showDiffLinesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDiffLinesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/diff-lines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDiffLinesRequest);
            return new SyncInvoker<ShowDiffLinesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDiffLinesResponse>);
        }
        
        /// <summary>
        /// 获取仓库最近推送事件
        ///
        /// 获取仓库最近推送事件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowLastPushEventInRepositoryResponse ShowLastPushEventInRepository(ShowLastPushEventInRepositoryRequest showLastPushEventInRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLastPushEventInRepositoryRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/last-push-event", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLastPushEventInRepositoryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowLastPushEventInRepositoryResponse>(response);
        }

        public SyncInvoker<ShowLastPushEventInRepositoryResponse> ShowLastPushEventInRepositoryInvoker(ShowLastPushEventInRepositoryRequest showLastPushEventInRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLastPushEventInRepositoryRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/last-push-event", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLastPushEventInRepositoryRequest);
            return new SyncInvoker<ShowLastPushEventInRepositoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLastPushEventInRepositoryResponse>);
        }
        
        /// <summary>
        /// 获取仓库通知设置
        ///
        /// 获取仓库通知设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowNotificationSubscriptionResponse ShowNotificationSubscription(ShowNotificationSubscriptionRequest showNotificationSubscriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNotificationSubscriptionRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/notification-subscriptions/subscription", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNotificationSubscriptionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowNotificationSubscriptionResponse>(response);
        }

        public SyncInvoker<ShowNotificationSubscriptionResponse> ShowNotificationSubscriptionInvoker(ShowNotificationSubscriptionRequest showNotificationSubscriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNotificationSubscriptionRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/notification-subscriptions/subscription", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNotificationSubscriptionRequest);
            return new SyncInvoker<ShowNotificationSubscriptionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNotificationSubscriptionResponse>);
        }
        
        /// <summary>
        /// 获取仓库通知设置启用状态
        ///
        /// 获取仓库通知设置启用状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowNotificationSubscriptionsStatusResponse ShowNotificationSubscriptionsStatus(ShowNotificationSubscriptionsStatusRequest showNotificationSubscriptionsStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNotificationSubscriptionsStatusRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/notification-subscriptions/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNotificationSubscriptionsStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowNotificationSubscriptionsStatusResponse>(response);
        }

        public SyncInvoker<ShowNotificationSubscriptionsStatusResponse> ShowNotificationSubscriptionsStatusInvoker(ShowNotificationSubscriptionsStatusRequest showNotificationSubscriptionsStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNotificationSubscriptionsStatusRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/notification-subscriptions/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNotificationSubscriptionsStatusRequest);
            return new SyncInvoker<ShowNotificationSubscriptionsStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNotificationSubscriptionsStatusResponse>);
        }
        
        /// <summary>
        /// 分支、tags、提交对比
        ///
        /// 分支、tags、提交对比
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRefCompareResponse ShowRefCompare(ShowRefCompareRequest showRefCompareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRefCompareRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/compare", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRefCompareRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRefCompareResponse>(response);
        }

        public SyncInvoker<ShowRefCompareResponse> ShowRefCompareInvoker(ShowRefCompareRequest showRefCompareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRefCompareRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/compare", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRefCompareRequest);
            return new SyncInvoker<ShowRefCompareResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRefCompareResponse>);
        }
        
        /// <summary>
        /// 获取仓库镜像详情
        ///
        /// 获取仓库镜像详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRemoteMirrorResponse ShowRemoteMirror(ShowRemoteMirrorRequest showRemoteMirrorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRemoteMirrorRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/remote-mirror", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRemoteMirrorRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRemoteMirrorResponse>(response);
        }

        public SyncInvoker<ShowRemoteMirrorResponse> ShowRemoteMirrorInvoker(ShowRemoteMirrorRequest showRemoteMirrorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRemoteMirrorRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/remote-mirror", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRemoteMirrorRequest);
            return new SyncInvoker<ShowRemoteMirrorResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRemoteMirrorResponse>);
        }
        
        /// <summary>
        /// 获取仓库详情
        ///
        /// 获取仓库详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRepositoryResponse ShowRepository(ShowRepositoryRequest showRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRepositoryResponse>(response);
        }

        public SyncInvoker<ShowRepositoryResponse> ShowRepositoryInvoker(ShowRepositoryRequest showRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryRequest);
            return new SyncInvoker<ShowRepositoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepositoryResponse>);
        }
        
        /// <summary>
        /// 查看仓库通用提交规则
        ///
        /// 查看仓库通用提交规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRepositoryGeneralCommitRuleResponse ShowRepositoryGeneralCommitRule(ShowRepositoryGeneralCommitRuleRequest showRepositoryGeneralCommitRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryGeneralCommitRuleRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/general-commit-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryGeneralCommitRuleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRepositoryGeneralCommitRuleResponse>(response);
        }

        public SyncInvoker<ShowRepositoryGeneralCommitRuleResponse> ShowRepositoryGeneralCommitRuleInvoker(ShowRepositoryGeneralCommitRuleRequest showRepositoryGeneralCommitRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryGeneralCommitRuleRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/general-commit-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryGeneralCommitRuleRequest);
            return new SyncInvoker<ShowRepositoryGeneralCommitRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepositoryGeneralCommitRuleResponse>);
        }
        
        /// <summary>
        /// 查看仓库通用策略
        ///
        /// 查看仓库通用策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRepositoryGeneralPolicyResponse ShowRepositoryGeneralPolicy(ShowRepositoryGeneralPolicyRequest showRepositoryGeneralPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryGeneralPolicyRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/general-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryGeneralPolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRepositoryGeneralPolicyResponse>(response);
        }

        public SyncInvoker<ShowRepositoryGeneralPolicyResponse> ShowRepositoryGeneralPolicyInvoker(ShowRepositoryGeneralPolicyRequest showRepositoryGeneralPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryGeneralPolicyRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/general-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryGeneralPolicyRequest);
            return new SyncInvoker<ShowRepositoryGeneralPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepositoryGeneralPolicyResponse>);
        }
        
        /// <summary>
        /// 查看仓库继承设置
        ///
        /// 查看仓库继承设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRepositoryInheritSettingResponse ShowRepositoryInheritSetting(ShowRepositoryInheritSettingRequest showRepositoryInheritSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryInheritSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/inherit-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryInheritSettingRequest);
            var response = DoHttpRequestSync("GET", request);
            var showRepositoryInheritSettingResponse = JsonUtils.DeSerializeNull<ShowRepositoryInheritSettingResponse>(response);
            showRepositoryInheritSettingResponse.Body = JsonUtils.DeSerializeList<RepositoryInheritSettingDto>(response);
            return showRepositoryInheritSettingResponse;
        }

        public SyncInvoker<ShowRepositoryInheritSettingResponse> ShowRepositoryInheritSettingInvoker(ShowRepositoryInheritSettingRequest showRepositoryInheritSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryInheritSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/inherit-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryInheritSettingRequest);
            return new SyncInvoker<ShowRepositoryInheritSettingResponse>(this, "GET", request, response =>
            {
                var showRepositoryInheritSettingResponse = JsonUtils.DeSerializeNull<ShowRepositoryInheritSettingResponse>(response);
                showRepositoryInheritSettingResponse.Body = JsonUtils.DeSerializeList<RepositoryInheritSettingDto>(response);
                return showRepositoryInheritSettingResponse;
            });
        }
        
        /// <summary>
        /// 查看仓库继承设置源
        ///
        /// 查看仓库继承设置源
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRepositoryInheritSettingSourceResponse ShowRepositoryInheritSettingSource(ShowRepositoryInheritSettingSourceRequest showRepositoryInheritSettingSourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryInheritSettingSourceRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/inherit-setting-source", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryInheritSettingSourceRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRepositoryInheritSettingSourceResponse>(response);
        }

        public SyncInvoker<ShowRepositoryInheritSettingSourceResponse> ShowRepositoryInheritSettingSourceInvoker(ShowRepositoryInheritSettingSourceRequest showRepositoryInheritSettingSourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryInheritSettingSourceRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/inherit-setting-source", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryInheritSettingSourceRequest);
            return new SyncInvoker<ShowRepositoryInheritSettingSourceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepositoryInheritSettingSourceResponse>);
        }
        
        /// <summary>
        /// 获取仓库统计任务状态
        ///
        /// 获取仓库统计任务状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRepositoryStatisticsStatusResponse ShowRepositoryStatisticsStatus(ShowRepositoryStatisticsStatusRequest showRepositoryStatisticsStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryStatisticsStatusRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/statistics-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryStatisticsStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRepositoryStatisticsStatusResponse>(response);
        }

        public SyncInvoker<ShowRepositoryStatisticsStatusResponse> ShowRepositoryStatisticsStatusInvoker(ShowRepositoryStatisticsStatusRequest showRepositoryStatisticsStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryStatisticsStatusRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/statistics-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryStatisticsStatusRequest);
            return new SyncInvoker<ShowRepositoryStatisticsStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepositoryStatisticsStatusResponse>);
        }
        
        /// <summary>
        /// 获取仓库统计摘要
        ///
        /// 获取仓库统计摘要
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRepositoryStatisticsSummaryResponse ShowRepositoryStatisticsSummary(ShowRepositoryStatisticsSummaryRequest showRepositoryStatisticsSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryStatisticsSummaryRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/statistics-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryStatisticsSummaryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRepositoryStatisticsSummaryResponse>(response);
        }

        public SyncInvoker<ShowRepositoryStatisticsSummaryResponse> ShowRepositoryStatisticsSummaryInvoker(ShowRepositoryStatisticsSummaryRequest showRepositoryStatisticsSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryStatisticsSummaryRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/statistics-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryStatisticsSummaryRequest);
            return new SyncInvoker<ShowRepositoryStatisticsSummaryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepositoryStatisticsSummaryResponse>);
        }
        
        /// <summary>
        /// 获取仓库水印设置
        ///
        /// 获取仓库水印设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRepositoryWatermarkResponse ShowRepositoryWatermark(ShowRepositoryWatermarkRequest showRepositoryWatermarkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryWatermarkRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryWatermarkRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRepositoryWatermarkResponse>(response);
        }

        public SyncInvoker<ShowRepositoryWatermarkResponse> ShowRepositoryWatermarkInvoker(ShowRepositoryWatermarkRequest showRepositoryWatermarkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryWatermarkRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryWatermarkRequest);
            return new SyncInvoker<ShowRepositoryWatermarkResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepositoryWatermarkResponse>);
        }
        
        /// <summary>
        /// 获取CR仓库用户分支或标签级权限
        ///
        /// 获取CR仓库用户分支或标签级权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowUserRefPermissionResponse ShowUserRefPermission(ShowUserRefPermissionRequest showUserRefPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUserRefPermissionRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/user-ref-permission", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserRefPermissionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowUserRefPermissionResponse>(response);
        }

        public SyncInvoker<ShowUserRefPermissionResponse> ShowUserRefPermissionInvoker(ShowUserRefPermissionRequest showUserRefPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUserRefPermissionRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/user-ref-permission", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserRefPermissionRequest);
            return new SyncInvoker<ShowUserRefPermissionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUserRefPermissionResponse>);
        }
        
        /// <summary>
        /// 启动仓库加速
        ///
        /// 启动仓库加速
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StartHouseKeepingResponse StartHouseKeeping(StartHouseKeepingRequest startHouseKeepingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startHouseKeepingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/housekeeping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startHouseKeepingRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<StartHouseKeepingResponse>(response);
        }

        public SyncInvoker<StartHouseKeepingResponse> StartHouseKeepingInvoker(StartHouseKeepingRequest startHouseKeepingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startHouseKeepingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/housekeeping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startHouseKeepingRequest);
            return new SyncInvoker<StartHouseKeepingResponse>(this, "POST", request, JsonUtils.DeSerializeNull<StartHouseKeepingResponse>);
        }
        
        /// <summary>
        /// 启动仓库镜像同步
        ///
        /// 启动仓库镜像同步
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StartRemoteMirrorSynchronizationResponse StartRemoteMirrorSynchronization(StartRemoteMirrorSynchronizationRequest startRemoteMirrorSynchronizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startRemoteMirrorSynchronizationRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/remote-mirror", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startRemoteMirrorSynchronizationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StartRemoteMirrorSynchronizationResponse>(response);
        }

        public SyncInvoker<StartRemoteMirrorSynchronizationResponse> StartRemoteMirrorSynchronizationInvoker(StartRemoteMirrorSynchronizationRequest startRemoteMirrorSynchronizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startRemoteMirrorSynchronizationRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/remote-mirror", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startRemoteMirrorSynchronizationRequest);
            return new SyncInvoker<StartRemoteMirrorSynchronizationResponse>(this, "POST", request, JsonUtils.DeSerialize<StartRemoteMirrorSynchronizationResponse>);
        }
        
        /// <summary>
        /// 仓库部署密钥同步到子仓
        ///
        /// 将该仓库的部署密钥同步到所有的子模组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SyncDeployKeyToSubmodulesResponse SyncDeployKeyToSubmodules(SyncDeployKeyToSubmodulesRequest syncDeployKeyToSubmodulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(syncDeployKeyToSubmodulesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(syncDeployKeyToSubmodulesRequest.KeyId, out var valueOfKeyId)) urlParam.Add("key_id", valueOfKeyId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/deploy-keys/{key_id}/submodules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", syncDeployKeyToSubmodulesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<SyncDeployKeyToSubmodulesResponse>(response);
        }

        public SyncInvoker<SyncDeployKeyToSubmodulesResponse> SyncDeployKeyToSubmodulesInvoker(SyncDeployKeyToSubmodulesRequest syncDeployKeyToSubmodulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(syncDeployKeyToSubmodulesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(syncDeployKeyToSubmodulesRequest.KeyId, out var valueOfKeyId)) urlParam.Add("key_id", valueOfKeyId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/deploy-keys/{key_id}/submodules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", syncDeployKeyToSubmodulesRequest);
            return new SyncInvoker<SyncDeployKeyToSubmodulesResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SyncDeployKeyToSubmodulesResponse>);
        }
        
        /// <summary>
        /// 解锁仓库
        ///
        /// 解锁仓库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UnlockRepositoryResponse UnlockRepository(UnlockRepositoryRequest unlockRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(unlockRepositoryRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(unlockRepositoryRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/repositories/{repository_id}/unlock", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unlockRepositoryRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UnlockRepositoryResponse>(response);
        }

        public SyncInvoker<UnlockRepositoryResponse> UnlockRepositoryInvoker(UnlockRepositoryRequest unlockRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(unlockRepositoryRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(unlockRepositoryRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/repositories/{repository_id}/unlock", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unlockRepositoryRequest);
            return new SyncInvoker<UnlockRepositoryResponse>(this, "POST", request, JsonUtils.DeSerialize<UnlockRepositoryResponse>);
        }
        
        /// <summary>
        /// 修改仓库通知设置
        ///
        /// 修改仓库通知设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateNotificationSubscriptionResponse UpdateNotificationSubscription(UpdateNotificationSubscriptionRequest updateNotificationSubscriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateNotificationSubscriptionRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/notification-subscriptions/subscription", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNotificationSubscriptionRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateNotificationSubscriptionResponse>(response);
        }

        public SyncInvoker<UpdateNotificationSubscriptionResponse> UpdateNotificationSubscriptionInvoker(UpdateNotificationSubscriptionRequest updateNotificationSubscriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateNotificationSubscriptionRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/notification-subscriptions/subscription", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNotificationSubscriptionRequest);
            return new SyncInvoker<UpdateNotificationSubscriptionResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateNotificationSubscriptionResponse>);
        }
        
        /// <summary>
        /// 修改仓库提交规则
        ///
        /// 修改仓库提交规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRepositoryCommitRuleResponse UpdateRepositoryCommitRule(UpdateRepositoryCommitRuleRequest updateRepositoryCommitRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryCommitRuleRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryCommitRuleRequest.CommitRuleId, out var valueOfCommitRuleId)) urlParam.Add("commit_rule_id", valueOfCommitRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/commit-rules/{commit_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepositoryCommitRuleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRepositoryCommitRuleResponse>(response);
        }

        public SyncInvoker<UpdateRepositoryCommitRuleResponse> UpdateRepositoryCommitRuleInvoker(UpdateRepositoryCommitRuleRequest updateRepositoryCommitRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryCommitRuleRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryCommitRuleRequest.CommitRuleId, out var valueOfCommitRuleId)) urlParam.Add("commit_rule_id", valueOfCommitRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/commit-rules/{commit_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepositoryCommitRuleRequest);
            return new SyncInvoker<UpdateRepositoryCommitRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRepositoryCommitRuleResponse>);
        }
        
        /// <summary>
        /// 修改仓库通用提交规则
        ///
        /// 修改仓库通用提交规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRepositoryGeneralCommitRuleResponse UpdateRepositoryGeneralCommitRule(UpdateRepositoryGeneralCommitRuleRequest updateRepositoryGeneralCommitRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryGeneralCommitRuleRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/general-commit-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepositoryGeneralCommitRuleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRepositoryGeneralCommitRuleResponse>(response);
        }

        public SyncInvoker<UpdateRepositoryGeneralCommitRuleResponse> UpdateRepositoryGeneralCommitRuleInvoker(UpdateRepositoryGeneralCommitRuleRequest updateRepositoryGeneralCommitRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryGeneralCommitRuleRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/general-commit-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepositoryGeneralCommitRuleRequest);
            return new SyncInvoker<UpdateRepositoryGeneralCommitRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRepositoryGeneralCommitRuleResponse>);
        }
        
        /// <summary>
        /// 修改仓库通用策略
        ///
        /// 修改仓库通用策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRepositoryGeneralPolicyResponse UpdateRepositoryGeneralPolicy(UpdateRepositoryGeneralPolicyRequest updateRepositoryGeneralPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryGeneralPolicyRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/general-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepositoryGeneralPolicyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRepositoryGeneralPolicyResponse>(response);
        }

        public SyncInvoker<UpdateRepositoryGeneralPolicyResponse> UpdateRepositoryGeneralPolicyInvoker(UpdateRepositoryGeneralPolicyRequest updateRepositoryGeneralPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryGeneralPolicyRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/general-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepositoryGeneralPolicyRequest);
            return new SyncInvoker<UpdateRepositoryGeneralPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRepositoryGeneralPolicyResponse>);
        }
        
        /// <summary>
        /// 修改仓库继承设置
        ///
        /// 修改仓库继承设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRepositoryInheritSettingResponse UpdateRepositoryInheritSetting(UpdateRepositoryInheritSettingRequest updateRepositoryInheritSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryInheritSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/inherit-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepositoryInheritSettingRequest);
            var response = DoHttpRequestSync("PUT", request);
            var updateRepositoryInheritSettingResponse = JsonUtils.DeSerializeNull<UpdateRepositoryInheritSettingResponse>(response);
            updateRepositoryInheritSettingResponse.Body = JsonUtils.DeSerializeList<RepositoryInheritSettingDto>(response);
            return updateRepositoryInheritSettingResponse;
        }

        public SyncInvoker<UpdateRepositoryInheritSettingResponse> UpdateRepositoryInheritSettingInvoker(UpdateRepositoryInheritSettingRequest updateRepositoryInheritSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryInheritSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/inherit-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepositoryInheritSettingRequest);
            return new SyncInvoker<UpdateRepositoryInheritSettingResponse>(this, "PUT", request, response =>
            {
                var updateRepositoryInheritSettingResponse = JsonUtils.DeSerializeNull<UpdateRepositoryInheritSettingResponse>(response);
                updateRepositoryInheritSettingResponse.Body = JsonUtils.DeSerializeList<RepositoryInheritSettingDto>(response);
                return updateRepositoryInheritSettingResponse;
            });
        }
        
        /// <summary>
        /// 修改仓库标签
        ///
        /// 修改仓库标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRepositoryLabelResponse UpdateRepositoryLabel(UpdateRepositoryLabelRequest updateRepositoryLabelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryLabelRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/label", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepositoryLabelRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRepositoryLabelResponse>(response);
        }

        public SyncInvoker<UpdateRepositoryLabelResponse> UpdateRepositoryLabelInvoker(UpdateRepositoryLabelRequest updateRepositoryLabelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryLabelRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/label", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepositoryLabelRequest);
            return new SyncInvoker<UpdateRepositoryLabelResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRepositoryLabelResponse>);
        }
        
        /// <summary>
        /// 更新仓库镜像信息
        ///
        /// 更新仓库镜像信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRepositoryRemoteMirrorResponse UpdateRepositoryRemoteMirror(UpdateRepositoryRemoteMirrorRequest updateRepositoryRemoteMirrorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryRemoteMirrorRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/remote-mirror", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepositoryRemoteMirrorRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRepositoryRemoteMirrorResponse>(response);
        }

        public SyncInvoker<UpdateRepositoryRemoteMirrorResponse> UpdateRepositoryRemoteMirrorInvoker(UpdateRepositoryRemoteMirrorRequest updateRepositoryRemoteMirrorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryRemoteMirrorRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/remote-mirror", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepositoryRemoteMirrorRequest);
            return new SyncInvoker<UpdateRepositoryRemoteMirrorResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRepositoryRemoteMirrorResponse>);
        }
        
        /// <summary>
        /// 更新仓库水印设置
        ///
        /// 更新仓库水印设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRepositoryWatermarkResponse UpdateRepositoryWatermark(UpdateRepositoryWatermarkRequest updateRepositoryWatermarkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryWatermarkRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepositoryWatermarkRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRepositoryWatermarkResponse>(response);
        }

        public SyncInvoker<UpdateRepositoryWatermarkResponse> UpdateRepositoryWatermarkInvoker(UpdateRepositoryWatermarkRequest updateRepositoryWatermarkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryWatermarkRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepositoryWatermarkRequest);
            return new SyncInvoker<UpdateRepositoryWatermarkResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRepositoryWatermarkResponse>);
        }
        
        /// <summary>
        /// 修改仓库ip白名单
        ///
        /// 修改仓库ip白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTrustedIpAddressResponse UpdateTrustedIpAddress(UpdateTrustedIpAddressRequest updateTrustedIpAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTrustedIpAddressRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            if (StringUtils.TryConvertToNonEmptyString(updateTrustedIpAddressRequest.IpId, out var valueOfIpId)) urlParam.Add("ip_id", valueOfIpId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{id}/trusted-ip-addresses/{ip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTrustedIpAddressRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateTrustedIpAddressResponse>(response);
        }

        public SyncInvoker<UpdateTrustedIpAddressResponse> UpdateTrustedIpAddressInvoker(UpdateTrustedIpAddressRequest updateTrustedIpAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTrustedIpAddressRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            if (StringUtils.TryConvertToNonEmptyString(updateTrustedIpAddressRequest.IpId, out var valueOfIpId)) urlParam.Add("ip_id", valueOfIpId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{id}/trusted-ip-addresses/{ip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTrustedIpAddressRequest);
            return new SyncInvoker<UpdateTrustedIpAddressResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateTrustedIpAddressResponse>);
        }
        
        /// <summary>
        /// 添加租户ip白名单
        ///
        /// 添加租户ip白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddTenantTrustedIpAddressResponse AddTenantTrustedIpAddress(AddTenantTrustedIpAddressRequest addTenantTrustedIpAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/tenant/trusted-ip-addresses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addTenantTrustedIpAddressRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddTenantTrustedIpAddressResponse>(response);
        }

        public SyncInvoker<AddTenantTrustedIpAddressResponse> AddTenantTrustedIpAddressInvoker(AddTenantTrustedIpAddressRequest addTenantTrustedIpAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/tenant/trusted-ip-addresses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addTenantTrustedIpAddressRequest);
            return new SyncInvoker<AddTenantTrustedIpAddressResponse>(this, "POST", request, JsonUtils.DeSerialize<AddTenantTrustedIpAddressResponse>);
        }
        
        /// <summary>
        /// 删除租户ip白名单
        ///
        /// 删除租户ip白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTenantTrustedIpAddressResponse DeleteTenantTrustedIpAddress(DeleteTenantTrustedIpAddressRequest deleteTenantTrustedIpAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTenantTrustedIpAddressRequest.IpId, out var valueOfIpId)) urlParam.Add("ip_id", valueOfIpId);
            var urlPath = HttpUtils.AddUrlPath("/v4/tenant/trusted-ip-addresses/{ip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTenantTrustedIpAddressRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteTenantTrustedIpAddressResponse>(response);
        }

        public SyncInvoker<DeleteTenantTrustedIpAddressResponse> DeleteTenantTrustedIpAddressInvoker(DeleteTenantTrustedIpAddressRequest deleteTenantTrustedIpAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTenantTrustedIpAddressRequest.IpId, out var valueOfIpId)) urlParam.Add("ip_id", valueOfIpId);
            var urlPath = HttpUtils.AddUrlPath("/v4/tenant/trusted-ip-addresses/{ip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTenantTrustedIpAddressRequest);
            return new SyncInvoker<DeleteTenantTrustedIpAddressResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteTenantTrustedIpAddressResponse>);
        }
        
        /// <summary>
        /// 租户仓库列表
        ///
        /// 租户下所有占用资源的仓库列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExportTenantRepositoriesResponse ExportTenantRepositories(ExportTenantRepositoriesRequest exportTenantRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/tenant/repositories/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportTenantRepositoriesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExportTenantRepositoriesResponse>(response);
        }

        public SyncInvoker<ExportTenantRepositoriesResponse> ExportTenantRepositoriesInvoker(ExportTenantRepositoriesRequest exportTenantRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/tenant/repositories/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportTenantRepositoriesRequest);
            return new SyncInvoker<ExportTenantRepositoriesResponse>(this, "POST", request, JsonUtils.DeSerialize<ExportTenantRepositoriesResponse>);
        }
        
        /// <summary>
        /// 租户仓库列表
        ///
        /// 租户下所有占用资源的仓库列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTenantRepositoriesResponse ListTenantRepositories(ListTenantRepositoriesRequest listTenantRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/tenant/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantRepositoriesRequest);
            var response = DoHttpRequestSync("GET", request);
            var listTenantRepositoriesResponse = JsonUtils.DeSerializeNull<ListTenantRepositoriesResponse>(response);
            listTenantRepositoriesResponse.Body = JsonUtils.DeSerializeList<TenantRepositoryDto>(response);
            return listTenantRepositoriesResponse;
        }

        public SyncInvoker<ListTenantRepositoriesResponse> ListTenantRepositoriesInvoker(ListTenantRepositoriesRequest listTenantRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/tenant/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantRepositoriesRequest);
            return new SyncInvoker<ListTenantRepositoriesResponse>(this, "GET", request, response =>
            {
                var listTenantRepositoriesResponse = JsonUtils.DeSerializeNull<ListTenantRepositoriesResponse>(response);
                listTenantRepositoriesResponse.Body = JsonUtils.DeSerializeList<TenantRepositoryDto>(response);
                return listTenantRepositoriesResponse;
            });
        }
        
        /// <summary>
        /// 获取租户ip白名单
        ///
        /// 获取租户ip白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTenantTrustedIpAddressesResponse ListTenantTrustedIpAddresses(ListTenantTrustedIpAddressesRequest listTenantTrustedIpAddressesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/tenant/trusted-ip-addresses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantTrustedIpAddressesRequest);
            var response = DoHttpRequestSync("GET", request);
            var listTenantTrustedIpAddressesResponse = JsonUtils.DeSerializeNull<ListTenantTrustedIpAddressesResponse>(response);
            listTenantTrustedIpAddressesResponse.Body = JsonUtils.DeSerializeList<TenantTrustedIpAddressDto>(response);
            return listTenantTrustedIpAddressesResponse;
        }

        public SyncInvoker<ListTenantTrustedIpAddressesResponse> ListTenantTrustedIpAddressesInvoker(ListTenantTrustedIpAddressesRequest listTenantTrustedIpAddressesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/tenant/trusted-ip-addresses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantTrustedIpAddressesRequest);
            return new SyncInvoker<ListTenantTrustedIpAddressesResponse>(this, "GET", request, response =>
            {
                var listTenantTrustedIpAddressesResponse = JsonUtils.DeSerializeNull<ListTenantTrustedIpAddressesResponse>(response);
                listTenantTrustedIpAddressesResponse.Body = JsonUtils.DeSerializeList<TenantTrustedIpAddressDto>(response);
                return listTenantTrustedIpAddressesResponse;
            });
        }
        
        /// <summary>
        /// 修改租户ip白名单
        ///
        /// 修改租户ip白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTenantTrustedIpAddressResponse UpdateTenantTrustedIpAddress(UpdateTenantTrustedIpAddressRequest updateTenantTrustedIpAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTenantTrustedIpAddressRequest.IpId, out var valueOfIpId)) urlParam.Add("ip_id", valueOfIpId);
            var urlPath = HttpUtils.AddUrlPath("/v4/tenant/trusted-ip-addresses/{ip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTenantTrustedIpAddressRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateTenantTrustedIpAddressResponse>(response);
        }

        public SyncInvoker<UpdateTenantTrustedIpAddressResponse> UpdateTenantTrustedIpAddressInvoker(UpdateTenantTrustedIpAddressRequest updateTenantTrustedIpAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTenantTrustedIpAddressRequest.IpId, out var valueOfIpId)) urlParam.Add("ip_id", valueOfIpId);
            var urlPath = HttpUtils.AddUrlPath("/v4/tenant/trusted-ip-addresses/{ip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTenantTrustedIpAddressRequest);
            return new SyncInvoker<UpdateTenantTrustedIpAddressResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateTenantTrustedIpAddressResponse>);
        }
        
        /// <summary>
        /// 校验部署密钥在上层代码组或项目是否配置
        ///
        /// 校验部署密钥在上层代码组或项目是否配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CheckDeployKeyResponse CheckDeployKey(CheckDeployKeyRequest checkDeployKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkDeployKeyRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/deploy-keys/check-key", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkDeployKeyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CheckDeployKeyResponse>(response);
        }

        public SyncInvoker<CheckDeployKeyResponse> CheckDeployKeyInvoker(CheckDeployKeyRequest checkDeployKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkDeployKeyRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/deploy-keys/check-key", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkDeployKeyRequest);
            return new SyncInvoker<CheckDeployKeyResponse>(this, "POST", request, JsonUtils.DeSerialize<CheckDeployKeyResponse>);
        }
        
        /// <summary>
        /// 校验代码组部署密钥在上层代码组或项目是否配置
        ///
        /// 校验代码组部署密钥在上层代码组或项目是否配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CheckGroupDeployKeyResponse CheckGroupDeployKey(CheckGroupDeployKeyRequest checkGroupDeployKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkGroupDeployKeyRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/deploy-keys/check-key", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkGroupDeployKeyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CheckGroupDeployKeyResponse>(response);
        }

        public SyncInvoker<CheckGroupDeployKeyResponse> CheckGroupDeployKeyInvoker(CheckGroupDeployKeyRequest checkGroupDeployKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkGroupDeployKeyRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/deploy-keys/check-key", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkGroupDeployKeyRequest);
            return new SyncInvoker<CheckGroupDeployKeyResponse>(this, "POST", request, JsonUtils.DeSerialize<CheckGroupDeployKeyResponse>);
        }
        
        /// <summary>
        /// 获取仓库下指定分支的关联工作项列表
        ///
        /// 获取仓库下指定分支的关联工作项列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBranchRelatedWorkItemsResponse ListBranchRelatedWorkItems(ListBranchRelatedWorkItemsRequest listBranchRelatedWorkItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBranchRelatedWorkItemsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/branch/work-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBranchRelatedWorkItemsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listBranchRelatedWorkItemsResponse = JsonUtils.DeSerializeNull<ListBranchRelatedWorkItemsResponse>(response);
            listBranchRelatedWorkItemsResponse.Body = JsonUtils.DeSerializeList<WorkItemSimpleDto>(response);
            return listBranchRelatedWorkItemsResponse;
        }

        public SyncInvoker<ListBranchRelatedWorkItemsResponse> ListBranchRelatedWorkItemsInvoker(ListBranchRelatedWorkItemsRequest listBranchRelatedWorkItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBranchRelatedWorkItemsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/branch/work-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBranchRelatedWorkItemsRequest);
            return new SyncInvoker<ListBranchRelatedWorkItemsResponse>(this, "GET", request, response =>
            {
                var listBranchRelatedWorkItemsResponse = JsonUtils.DeSerializeNull<ListBranchRelatedWorkItemsResponse>(response);
                listBranchRelatedWorkItemsResponse.Body = JsonUtils.DeSerializeList<WorkItemSimpleDto>(response);
                return listBranchRelatedWorkItemsResponse;
            });
        }
        
        /// <summary>
        /// 获取代码组下部署密钥列表
        ///
        /// 获取代码组下部署密钥列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGroupDeployKeysResponse ListGroupDeployKeys(ListGroupDeployKeysRequest listGroupDeployKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupDeployKeysRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/deploy-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupDeployKeysRequest);
            var response = DoHttpRequestSync("GET", request);
            var listGroupDeployKeysResponse = JsonUtils.DeSerializeNull<ListGroupDeployKeysResponse>(response);
            listGroupDeployKeysResponse.Body = JsonUtils.DeSerializeList<DeployKeyDto>(response);
            return listGroupDeployKeysResponse;
        }

        public SyncInvoker<ListGroupDeployKeysResponse> ListGroupDeployKeysInvoker(ListGroupDeployKeysRequest listGroupDeployKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupDeployKeysRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/deploy-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupDeployKeysRequest);
            return new SyncInvoker<ListGroupDeployKeysResponse>(this, "GET", request, response =>
            {
                var listGroupDeployKeysResponse = JsonUtils.DeSerializeNull<ListGroupDeployKeysResponse>(response);
                listGroupDeployKeysResponse.Body = JsonUtils.DeSerializeList<DeployKeyDto>(response);
                return listGroupDeployKeysResponse;
            });
        }
        
        /// <summary>
        /// 获取项目下部署密钥列表
        ///
        /// 获取项目下部署密钥列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProjectDeployKeysResponse ListProjectDeployKeys(ListProjectDeployKeysRequest listProjectDeployKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectDeployKeysRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/deploy-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectDeployKeysRequest);
            var response = DoHttpRequestSync("GET", request);
            var listProjectDeployKeysResponse = JsonUtils.DeSerializeNull<ListProjectDeployKeysResponse>(response);
            listProjectDeployKeysResponse.Body = JsonUtils.DeSerializeList<DeployKeyDto>(response);
            return listProjectDeployKeysResponse;
        }

        public SyncInvoker<ListProjectDeployKeysResponse> ListProjectDeployKeysInvoker(ListProjectDeployKeysRequest listProjectDeployKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectDeployKeysRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/deploy-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectDeployKeysRequest);
            return new SyncInvoker<ListProjectDeployKeysResponse>(this, "GET", request, response =>
            {
                var listProjectDeployKeysResponse = JsonUtils.DeSerializeNull<ListProjectDeployKeysResponse>(response);
                listProjectDeployKeysResponse.Body = JsonUtils.DeSerializeList<DeployKeyDto>(response);
                return listProjectDeployKeysResponse;
            });
        }
        
        /// <summary>
        /// 获取仓库下部署密钥列表
        ///
        /// 获取仓库下部署密钥列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRepositoryDeployKeysResponse ListRepositoryDeployKeys(ListRepositoryDeployKeysRequest listRepositoryDeployKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryDeployKeysRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/deploy-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryDeployKeysRequest);
            var response = DoHttpRequestSync("GET", request);
            var listRepositoryDeployKeysResponse = JsonUtils.DeSerializeNull<ListRepositoryDeployKeysResponse>(response);
            listRepositoryDeployKeysResponse.Body = JsonUtils.DeSerializeList<DeployKeyDto>(response);
            return listRepositoryDeployKeysResponse;
        }

        public SyncInvoker<ListRepositoryDeployKeysResponse> ListRepositoryDeployKeysInvoker(ListRepositoryDeployKeysRequest listRepositoryDeployKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryDeployKeysRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/deploy-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryDeployKeysRequest);
            return new SyncInvoker<ListRepositoryDeployKeysResponse>(this, "GET", request, response =>
            {
                var listRepositoryDeployKeysResponse = JsonUtils.DeSerializeNull<ListRepositoryDeployKeysResponse>(response);
                listRepositoryDeployKeysResponse.Body = JsonUtils.DeSerializeList<DeployKeyDto>(response);
                return listRepositoryDeployKeysResponse;
            });
        }
        
        /// <summary>
        /// 获取仓库下工作项列表
        ///
        /// 获取仓库下工作项列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRepositoryWorkItemsResponse ListRepositoryWorkItems(ListRepositoryWorkItemsRequest listRepositoryWorkItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryWorkItemsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/work-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryWorkItemsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listRepositoryWorkItemsResponse = JsonUtils.DeSerializeNull<ListRepositoryWorkItemsResponse>(response);
            listRepositoryWorkItemsResponse.Body = JsonUtils.DeSerializeList<ReqWorkItemDto>(response);
            return listRepositoryWorkItemsResponse;
        }

        public SyncInvoker<ListRepositoryWorkItemsResponse> ListRepositoryWorkItemsInvoker(ListRepositoryWorkItemsRequest listRepositoryWorkItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryWorkItemsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/work-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryWorkItemsRequest);
            return new SyncInvoker<ListRepositoryWorkItemsResponse>(this, "GET", request, response =>
            {
                var listRepositoryWorkItemsResponse = JsonUtils.DeSerializeNull<ListRepositoryWorkItemsResponse>(response);
                listRepositoryWorkItemsResponse.Body = JsonUtils.DeSerializeList<ReqWorkItemDto>(response);
                return listRepositoryWorkItemsResponse;
            });
        }
        
        /// <summary>
        /// 获取代码组下E2E设置信息
        ///
        /// 获取代码组下E2E设置信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGroupE2eSettingResponse ShowGroupE2eSetting(ShowGroupE2eSettingRequest showGroupE2eSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupE2eSettingRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/e2e-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupE2eSettingRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGroupE2eSettingResponse>(response);
        }

        public SyncInvoker<ShowGroupE2eSettingResponse> ShowGroupE2eSettingInvoker(ShowGroupE2eSettingRequest showGroupE2eSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupE2eSettingRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/e2e-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupE2eSettingRequest);
            return new SyncInvoker<ShowGroupE2eSettingResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGroupE2eSettingResponse>);
        }
        
        /// <summary>
        /// 获取项目下E2E设置信息
        ///
        /// 获取项目下E2E设置信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowProjectE2eSettingResponse ShowProjectE2eSetting(ShowProjectE2eSettingRequest showProjectE2eSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectE2eSettingRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/e2e-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectE2eSettingRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectE2eSettingResponse>(response);
        }

        public SyncInvoker<ShowProjectE2eSettingResponse> ShowProjectE2eSettingInvoker(ShowProjectE2eSettingRequest showProjectE2eSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectE2eSettingRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/e2e-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectE2eSettingRequest);
            return new SyncInvoker<ShowProjectE2eSettingResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectE2eSettingResponse>);
        }
        
        /// <summary>
        /// 获取仓库下E2E设置信息
        ///
        /// 获取仓库下E2E设置信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRepositoryE2eSettingResponse ShowRepositoryE2eSetting(ShowRepositoryE2eSettingRequest showRepositoryE2eSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryE2eSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/e2e-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryE2eSettingRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRepositoryE2eSettingResponse>(response);
        }

        public SyncInvoker<ShowRepositoryE2eSettingResponse> ShowRepositoryE2eSettingInvoker(ShowRepositoryE2eSettingRequest showRepositoryE2eSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryE2eSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/e2e-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryE2eSettingRequest);
            return new SyncInvoker<ShowRepositoryE2eSettingResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepositoryE2eSettingResponse>);
        }
        
        /// <summary>
        /// 添加ssh公钥
        ///
        /// 添加ssh公钥
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddSshKeyResponse AddSshKey(AddSshKeyRequest addSshKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addSshKeyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddSshKeyResponse>(response);
        }

        public SyncInvoker<AddSshKeyResponse> AddSshKeyInvoker(AddSshKeyRequest addSshKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addSshKeyRequest);
            return new SyncInvoker<AddSshKeyResponse>(this, "POST", request, JsonUtils.DeSerialize<AddSshKeyResponse>);
        }
        
        /// <summary>
        /// 获取当前用户指定的代码组列表中的权限
        ///
        /// 获取当前用户指定的代码组列表中的权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchValidateUserGroupPermissionsResponse BatchValidateUserGroupPermissions(BatchValidateUserGroupPermissionsRequest batchValidateUserGroupPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/groups/group-permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchValidateUserGroupPermissionsRequest);
            var response = DoHttpRequestSync("POST", request);
            var batchValidateUserGroupPermissionsResponse = JsonUtils.DeSerializeNull<BatchValidateUserGroupPermissionsResponse>(response);
            batchValidateUserGroupPermissionsResponse.Body = JsonUtils.DeSerializeList<UserGroupPermissionDto>(response);
            return batchValidateUserGroupPermissionsResponse;
        }

        public SyncInvoker<BatchValidateUserGroupPermissionsResponse> BatchValidateUserGroupPermissionsInvoker(BatchValidateUserGroupPermissionsRequest batchValidateUserGroupPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/groups/group-permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchValidateUserGroupPermissionsRequest);
            return new SyncInvoker<BatchValidateUserGroupPermissionsResponse>(this, "POST", request, response =>
            {
                var batchValidateUserGroupPermissionsResponse = JsonUtils.DeSerializeNull<BatchValidateUserGroupPermissionsResponse>(response);
                batchValidateUserGroupPermissionsResponse.Body = JsonUtils.DeSerializeList<UserGroupPermissionDto>(response);
                return batchValidateUserGroupPermissionsResponse;
            });
        }
        
        /// <summary>
        /// 删除ssh公钥
        ///
        /// 删除ssh公钥
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSshKeyResponse DeleteSshKey(DeleteSshKeyRequest deleteSshKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSshKeyRequest.KeyId, out var valueOfKeyId)) urlParam.Add("key_id", valueOfKeyId);
            var urlPath = HttpUtils.AddUrlPath("/v4/user/keys/{key_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSshKeyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSshKeyResponse>(response);
        }

        public SyncInvoker<DeleteSshKeyResponse> DeleteSshKeyInvoker(DeleteSshKeyRequest deleteSshKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSshKeyRequest.KeyId, out var valueOfKeyId)) urlParam.Add("key_id", valueOfKeyId);
            var urlPath = HttpUtils.AddUrlPath("/v4/user/keys/{key_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSshKeyRequest);
            return new SyncInvoker<DeleteSshKeyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSshKeyResponse>);
        }
        
        /// <summary>
        /// 获取用户的个人访问令牌
        ///
        /// 获取用户的个人访问令牌
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListImpersonationTokensResponse ListImpersonationTokens(ListImpersonationTokensRequest listImpersonationTokensRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listImpersonationTokensRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/users/impersonation-tokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImpersonationTokensRequest);
            var response = DoHttpRequestSync("GET", request);
            var listImpersonationTokensResponse = JsonUtils.DeSerializeNull<ListImpersonationTokensResponse>(response);
            listImpersonationTokensResponse.Body = JsonUtils.DeSerializeList<ImpersonationToken>(response);
            return listImpersonationTokensResponse;
        }

        public SyncInvoker<ListImpersonationTokensResponse> ListImpersonationTokensInvoker(ListImpersonationTokensRequest listImpersonationTokensRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listImpersonationTokensRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/users/impersonation-tokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImpersonationTokensRequest);
            return new SyncInvoker<ListImpersonationTokensResponse>(this, "GET", request, response =>
            {
                var listImpersonationTokensResponse = JsonUtils.DeSerializeNull<ListImpersonationTokensResponse>(response);
                listImpersonationTokensResponse.Body = JsonUtils.DeSerializeList<ImpersonationToken>(response);
                return listImpersonationTokensResponse;
            });
        }
        
        /// <summary>
        /// 获取当前用户的gpg_key列表
        ///
        /// 获取当前用户的gpg_key列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUserGpgKeysResponse ListUserGpgKeys(ListUserGpgKeysRequest listUserGpgKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/gpg-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserGpgKeysRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUserGpgKeysResponse>(response);
        }

        public SyncInvoker<ListUserGpgKeysResponse> ListUserGpgKeysInvoker(ListUserGpgKeysRequest listUserGpgKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/gpg-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserGpgKeysRequest);
            return new SyncInvoker<ListUserGpgKeysResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUserGpgKeysResponse>);
        }
        
        /// <summary>
        /// 获取当前用户的密钥列表
        ///
        /// 获取当前用户的密钥列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUserKeysResponse ListUserKeys(ListUserKeysRequest listUserKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserKeysRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUserKeysResponse>(response);
        }

        public SyncInvoker<ListUserKeysResponse> ListUserKeysInvoker(ListUserKeysRequest listUserKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserKeysRequest);
            return new SyncInvoker<ListUserKeysResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUserKeysResponse>);
        }
        
        /// <summary>
        /// 发送邮箱验证码
        ///
        /// 发送邮箱验证码
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SendUserEmailVerifyCodeResponse SendUserEmailVerifyCode(SendUserEmailVerifyCodeRequest sendUserEmailVerifyCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/email-verify-code", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendUserEmailVerifyCodeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SendUserEmailVerifyCodeResponse>(response);
        }

        public SyncInvoker<SendUserEmailVerifyCodeResponse> SendUserEmailVerifyCodeInvoker(SendUserEmailVerifyCodeRequest sendUserEmailVerifyCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/email-verify-code", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendUserEmailVerifyCodeRequest);
            return new SyncInvoker<SendUserEmailVerifyCodeResponse>(this, "POST", request, JsonUtils.DeSerialize<SendUserEmailVerifyCodeResponse>);
        }
        
        /// <summary>
        /// 获取https的验证方式
        ///
        /// 获取https的验证方式
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowHttpsPasswordSettingResponse ShowHttpsPasswordSetting(ShowHttpsPasswordSettingRequest showHttpsPasswordSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/https-password-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHttpsPasswordSettingRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerializeNull<ShowHttpsPasswordSettingResponse>(response);
        }

        public SyncInvoker<ShowHttpsPasswordSettingResponse> ShowHttpsPasswordSettingInvoker(ShowHttpsPasswordSettingRequest showHttpsPasswordSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/https-password-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHttpsPasswordSettingRequest);
            return new SyncInvoker<ShowHttpsPasswordSettingResponse>(this, "GET", request, JsonUtils.DeSerializeNull<ShowHttpsPasswordSettingResponse>);
        }
        
        /// <summary>
        /// 获取用户相关邮箱信息
        ///
        /// 获取用户相关邮箱信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowUserEmailsResponse ShowUserEmails(ShowUserEmailsRequest showUserEmailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/emails", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserEmailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowUserEmailsResponse>(response);
        }

        public SyncInvoker<ShowUserEmailsResponse> ShowUserEmailsInvoker(ShowUserEmailsRequest showUserEmailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/emails", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserEmailsRequest);
            return new SyncInvoker<ShowUserEmailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUserEmailsResponse>);
        }
        
        /// <summary>
        /// 修改https的验证方式
        ///
        /// 修改https的验证方式
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateHttpsPasswordSettingResponse UpdateHttpsPasswordSetting(UpdateHttpsPasswordSettingRequest updateHttpsPasswordSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/https-password-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHttpsPasswordSettingRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateHttpsPasswordSettingResponse>(response);
        }

        public SyncInvoker<UpdateHttpsPasswordSettingResponse> UpdateHttpsPasswordSettingInvoker(UpdateHttpsPasswordSettingRequest updateHttpsPasswordSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/https-password-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHttpsPasswordSettingRequest);
            return new SyncInvoker<UpdateHttpsPasswordSettingResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateHttpsPasswordSettingResponse>);
        }
        
        /// <summary>
        /// 更新邮箱
        ///
        /// 更新邮箱
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateUserEmailsResponse UpdateUserEmails(UpdateUserEmailsRequest updateUserEmailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/emails", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserEmailsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateUserEmailsResponse>(response);
        }

        public SyncInvoker<UpdateUserEmailsResponse> UpdateUserEmailsInvoker(UpdateUserEmailsRequest updateUserEmailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/emails", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserEmailsRequest);
            return new SyncInvoker<UpdateUserEmailsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateUserEmailsResponse>);
        }
        
        /// <summary>
        /// 添加代码组下Webhook
        ///
        /// 添加代码组下Webhook
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddGroupWebhookResponse AddGroupWebhook(AddGroupWebhookRequest addGroupWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addGroupWebhookRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/hooks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addGroupWebhookRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddGroupWebhookResponse>(response);
        }

        public SyncInvoker<AddGroupWebhookResponse> AddGroupWebhookInvoker(AddGroupWebhookRequest addGroupWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addGroupWebhookRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/hooks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addGroupWebhookRequest);
            return new SyncInvoker<AddGroupWebhookResponse>(this, "POST", request, JsonUtils.DeSerialize<AddGroupWebhookResponse>);
        }
        
        /// <summary>
        /// 添加项目下Webhook
        ///
        /// 添加项目下Webhook
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddProjectWebhookResponse AddProjectWebhook(AddProjectWebhookRequest addProjectWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addProjectWebhookRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/hooks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addProjectWebhookRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddProjectWebhookResponse>(response);
        }

        public SyncInvoker<AddProjectWebhookResponse> AddProjectWebhookInvoker(AddProjectWebhookRequest addProjectWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addProjectWebhookRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/hooks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addProjectWebhookRequest);
            return new SyncInvoker<AddProjectWebhookResponse>(this, "POST", request, JsonUtils.DeSerialize<AddProjectWebhookResponse>);
        }
        
        /// <summary>
        /// 添加仓库下Webhook
        ///
        /// 添加仓库下Webhook
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AddRepositoryWebhookResponse AddRepositoryWebhook(AddRepositoryWebhookRequest addRepositoryWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addRepositoryWebhookRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/hooks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addRepositoryWebhookRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AddRepositoryWebhookResponse>(response);
        }

        public SyncInvoker<AddRepositoryWebhookResponse> AddRepositoryWebhookInvoker(AddRepositoryWebhookRequest addRepositoryWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addRepositoryWebhookRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/hooks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addRepositoryWebhookRequest);
            return new SyncInvoker<AddRepositoryWebhookResponse>(this, "POST", request, JsonUtils.DeSerialize<AddRepositoryWebhookResponse>);
        }
        
        /// <summary>
        /// 获取代码组下指定Webhook的日志列表
        ///
        /// 获取代码组下指定Webhook的日志列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGroupWebhookLogsResponse ListGroupWebhookLogs(ListGroupWebhookLogsRequest listGroupWebhookLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupWebhookLogsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(listGroupWebhookLogsRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/hooks/{hook_id}/logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupWebhookLogsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listGroupWebhookLogsResponse = JsonUtils.DeSerializeNull<ListGroupWebhookLogsResponse>(response);
            listGroupWebhookLogsResponse.Body = JsonUtils.DeSerializeList<WebhookLogExtendDto>(response);
            return listGroupWebhookLogsResponse;
        }

        public SyncInvoker<ListGroupWebhookLogsResponse> ListGroupWebhookLogsInvoker(ListGroupWebhookLogsRequest listGroupWebhookLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupWebhookLogsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(listGroupWebhookLogsRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/hooks/{hook_id}/logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupWebhookLogsRequest);
            return new SyncInvoker<ListGroupWebhookLogsResponse>(this, "GET", request, response =>
            {
                var listGroupWebhookLogsResponse = JsonUtils.DeSerializeNull<ListGroupWebhookLogsResponse>(response);
                listGroupWebhookLogsResponse.Body = JsonUtils.DeSerializeList<WebhookLogExtendDto>(response);
                return listGroupWebhookLogsResponse;
            });
        }
        
        /// <summary>
        /// 获取代码组下Webhook列表
        ///
        /// 获取代码组下Webhook列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGroupWebhooksResponse ListGroupWebhooks(ListGroupWebhooksRequest listGroupWebhooksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupWebhooksRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/hooks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupWebhooksRequest);
            var response = DoHttpRequestSync("GET", request);
            var listGroupWebhooksResponse = JsonUtils.DeSerializeNull<ListGroupWebhooksResponse>(response);
            listGroupWebhooksResponse.Body = JsonUtils.DeSerializeList<WebhookDto>(response);
            return listGroupWebhooksResponse;
        }

        public SyncInvoker<ListGroupWebhooksResponse> ListGroupWebhooksInvoker(ListGroupWebhooksRequest listGroupWebhooksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupWebhooksRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/hooks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupWebhooksRequest);
            return new SyncInvoker<ListGroupWebhooksResponse>(this, "GET", request, response =>
            {
                var listGroupWebhooksResponse = JsonUtils.DeSerializeNull<ListGroupWebhooksResponse>(response);
                listGroupWebhooksResponse.Body = JsonUtils.DeSerializeList<WebhookDto>(response);
                return listGroupWebhooksResponse;
            });
        }
        
        /// <summary>
        /// 获取项目下指定Webhook的日志列表
        ///
        /// 获取项目下指定Webhook的日志列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProjectWebhookLogsResponse ListProjectWebhookLogs(ListProjectWebhookLogsRequest listProjectWebhookLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectWebhookLogsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listProjectWebhookLogsRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/hooks/{hook_id}/logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectWebhookLogsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listProjectWebhookLogsResponse = JsonUtils.DeSerializeNull<ListProjectWebhookLogsResponse>(response);
            listProjectWebhookLogsResponse.Body = JsonUtils.DeSerializeList<WebhookLogExtendDto>(response);
            return listProjectWebhookLogsResponse;
        }

        public SyncInvoker<ListProjectWebhookLogsResponse> ListProjectWebhookLogsInvoker(ListProjectWebhookLogsRequest listProjectWebhookLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectWebhookLogsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listProjectWebhookLogsRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/hooks/{hook_id}/logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectWebhookLogsRequest);
            return new SyncInvoker<ListProjectWebhookLogsResponse>(this, "GET", request, response =>
            {
                var listProjectWebhookLogsResponse = JsonUtils.DeSerializeNull<ListProjectWebhookLogsResponse>(response);
                listProjectWebhookLogsResponse.Body = JsonUtils.DeSerializeList<WebhookLogExtendDto>(response);
                return listProjectWebhookLogsResponse;
            });
        }
        
        /// <summary>
        /// 获取项目下Webhook列表
        ///
        /// 获取项目下Webhook列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProjectWebhooksResponse ListProjectWebhooks(ListProjectWebhooksRequest listProjectWebhooksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectWebhooksRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/hooks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectWebhooksRequest);
            var response = DoHttpRequestSync("GET", request);
            var listProjectWebhooksResponse = JsonUtils.DeSerializeNull<ListProjectWebhooksResponse>(response);
            listProjectWebhooksResponse.Body = JsonUtils.DeSerializeList<WebhookDto>(response);
            return listProjectWebhooksResponse;
        }

        public SyncInvoker<ListProjectWebhooksResponse> ListProjectWebhooksInvoker(ListProjectWebhooksRequest listProjectWebhooksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectWebhooksRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/hooks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectWebhooksRequest);
            return new SyncInvoker<ListProjectWebhooksResponse>(this, "GET", request, response =>
            {
                var listProjectWebhooksResponse = JsonUtils.DeSerializeNull<ListProjectWebhooksResponse>(response);
                listProjectWebhooksResponse.Body = JsonUtils.DeSerializeList<WebhookDto>(response);
                return listProjectWebhooksResponse;
            });
        }
        
        /// <summary>
        /// 获取仓库下指定Webhook的日志列表
        ///
        /// 获取仓库下指定Webhook的日志列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRepositoryWebhookLogsResponse ListRepositoryWebhookLogs(ListRepositoryWebhookLogsRequest listRepositoryWebhookLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryWebhookLogsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryWebhookLogsRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/hooks/{hook_id}/logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryWebhookLogsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listRepositoryWebhookLogsResponse = JsonUtils.DeSerializeNull<ListRepositoryWebhookLogsResponse>(response);
            listRepositoryWebhookLogsResponse.Body = JsonUtils.DeSerializeList<WebhookLogDto>(response);
            return listRepositoryWebhookLogsResponse;
        }

        public SyncInvoker<ListRepositoryWebhookLogsResponse> ListRepositoryWebhookLogsInvoker(ListRepositoryWebhookLogsRequest listRepositoryWebhookLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryWebhookLogsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryWebhookLogsRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/hooks/{hook_id}/logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryWebhookLogsRequest);
            return new SyncInvoker<ListRepositoryWebhookLogsResponse>(this, "GET", request, response =>
            {
                var listRepositoryWebhookLogsResponse = JsonUtils.DeSerializeNull<ListRepositoryWebhookLogsResponse>(response);
                listRepositoryWebhookLogsResponse.Body = JsonUtils.DeSerializeList<WebhookLogDto>(response);
                return listRepositoryWebhookLogsResponse;
            });
        }
        
        /// <summary>
        /// 获取仓库下Webhook列表
        ///
        /// 获取仓库下Webhook列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRepositoryWebhooksResponse ListRepositoryWebhooks(ListRepositoryWebhooksRequest listRepositoryWebhooksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryWebhooksRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/hooks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryWebhooksRequest);
            var response = DoHttpRequestSync("GET", request);
            var listRepositoryWebhooksResponse = JsonUtils.DeSerializeNull<ListRepositoryWebhooksResponse>(response);
            listRepositoryWebhooksResponse.Body = JsonUtils.DeSerializeList<WebhookDto>(response);
            return listRepositoryWebhooksResponse;
        }

        public SyncInvoker<ListRepositoryWebhooksResponse> ListRepositoryWebhooksInvoker(ListRepositoryWebhooksRequest listRepositoryWebhooksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryWebhooksRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/hooks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryWebhooksRequest);
            return new SyncInvoker<ListRepositoryWebhooksResponse>(this, "GET", request, response =>
            {
                var listRepositoryWebhooksResponse = JsonUtils.DeSerializeNull<ListRepositoryWebhooksResponse>(response);
                listRepositoryWebhooksResponse.Body = JsonUtils.DeSerializeList<WebhookDto>(response);
                return listRepositoryWebhooksResponse;
            });
        }
        
        /// <summary>
        /// 删除代码组下单个Webhook
        ///
        /// 删除代码组下单个Webhook
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RemoveGroupWebhookResponse RemoveGroupWebhook(RemoveGroupWebhookRequest removeGroupWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeGroupWebhookRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(removeGroupWebhookRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeGroupWebhookRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<RemoveGroupWebhookResponse>(response);
        }

        public SyncInvoker<RemoveGroupWebhookResponse> RemoveGroupWebhookInvoker(RemoveGroupWebhookRequest removeGroupWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeGroupWebhookRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(removeGroupWebhookRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeGroupWebhookRequest);
            return new SyncInvoker<RemoveGroupWebhookResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<RemoveGroupWebhookResponse>);
        }
        
        /// <summary>
        /// 删除项目下单个Webhook
        ///
        /// 删除项目下单个Webhook
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RemoveProjectWebhookResponse RemoveProjectWebhook(RemoveProjectWebhookRequest removeProjectWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeProjectWebhookRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(removeProjectWebhookRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeProjectWebhookRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<RemoveProjectWebhookResponse>(response);
        }

        public SyncInvoker<RemoveProjectWebhookResponse> RemoveProjectWebhookInvoker(RemoveProjectWebhookRequest removeProjectWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeProjectWebhookRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(removeProjectWebhookRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeProjectWebhookRequest);
            return new SyncInvoker<RemoveProjectWebhookResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<RemoveProjectWebhookResponse>);
        }
        
        /// <summary>
        /// 删除仓库下单个Webhook
        ///
        /// 删除仓库下单个Webhook
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RemoveRepositoryWebhookResponse RemoveRepositoryWebhook(RemoveRepositoryWebhookRequest removeRepositoryWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeRepositoryWebhookRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(removeRepositoryWebhookRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeRepositoryWebhookRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<RemoveRepositoryWebhookResponse>(response);
        }

        public SyncInvoker<RemoveRepositoryWebhookResponse> RemoveRepositoryWebhookInvoker(RemoveRepositoryWebhookRequest removeRepositoryWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeRepositoryWebhookRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(removeRepositoryWebhookRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeRepositoryWebhookRequest);
            return new SyncInvoker<RemoveRepositoryWebhookResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<RemoveRepositoryWebhookResponse>);
        }
        
        /// <summary>
        /// 获取代码组下单个Webhook数据
        ///
        /// 获取代码组下单个Webhook数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGroupWebhookResponse ShowGroupWebhook(ShowGroupWebhookRequest showGroupWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupWebhookRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(showGroupWebhookRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupWebhookRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGroupWebhookResponse>(response);
        }

        public SyncInvoker<ShowGroupWebhookResponse> ShowGroupWebhookInvoker(ShowGroupWebhookRequest showGroupWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupWebhookRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(showGroupWebhookRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupWebhookRequest);
            return new SyncInvoker<ShowGroupWebhookResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGroupWebhookResponse>);
        }
        
        /// <summary>
        /// 获取代码组下指定Webhook的指定日志详情
        ///
        /// 获取代码组下指定Webhook的指定日志详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowGroupWebhookLogResponse ShowGroupWebhookLog(ShowGroupWebhookLogRequest showGroupWebhookLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupWebhookLogRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(showGroupWebhookLogRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            if (StringUtils.TryConvertToNonEmptyString(showGroupWebhookLogRequest.LogId, out var valueOfLogId)) urlParam.Add("log_id", valueOfLogId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/hooks/{hook_id}/logs/{log_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupWebhookLogRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowGroupWebhookLogResponse>(response);
        }

        public SyncInvoker<ShowGroupWebhookLogResponse> ShowGroupWebhookLogInvoker(ShowGroupWebhookLogRequest showGroupWebhookLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupWebhookLogRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(showGroupWebhookLogRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            if (StringUtils.TryConvertToNonEmptyString(showGroupWebhookLogRequest.LogId, out var valueOfLogId)) urlParam.Add("log_id", valueOfLogId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/hooks/{hook_id}/logs/{log_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupWebhookLogRequest);
            return new SyncInvoker<ShowGroupWebhookLogResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGroupWebhookLogResponse>);
        }
        
        /// <summary>
        /// 获取项目下单个Webhook数据
        ///
        /// 获取项目下单个Webhook数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowProjectWebhookResponse ShowProjectWebhook(ShowProjectWebhookRequest showProjectWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectWebhookRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showProjectWebhookRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectWebhookRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectWebhookResponse>(response);
        }

        public SyncInvoker<ShowProjectWebhookResponse> ShowProjectWebhookInvoker(ShowProjectWebhookRequest showProjectWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectWebhookRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showProjectWebhookRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectWebhookRequest);
            return new SyncInvoker<ShowProjectWebhookResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectWebhookResponse>);
        }
        
        /// <summary>
        /// 获取项目下指定Webhook的指定日志详情
        ///
        /// 获取项目下指定Webhook的指定日志详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowProjectWebhookLogResponse ShowProjectWebhookLog(ShowProjectWebhookLogRequest showProjectWebhookLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectWebhookLogRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showProjectWebhookLogRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            if (StringUtils.TryConvertToNonEmptyString(showProjectWebhookLogRequest.LogId, out var valueOfLogId)) urlParam.Add("log_id", valueOfLogId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/hooks/{hook_id}/logs/{log_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectWebhookLogRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectWebhookLogResponse>(response);
        }

        public SyncInvoker<ShowProjectWebhookLogResponse> ShowProjectWebhookLogInvoker(ShowProjectWebhookLogRequest showProjectWebhookLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectWebhookLogRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showProjectWebhookLogRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            if (StringUtils.TryConvertToNonEmptyString(showProjectWebhookLogRequest.LogId, out var valueOfLogId)) urlParam.Add("log_id", valueOfLogId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/hooks/{hook_id}/logs/{log_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectWebhookLogRequest);
            return new SyncInvoker<ShowProjectWebhookLogResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectWebhookLogResponse>);
        }
        
        /// <summary>
        /// 获取仓库下单个Webhook数据
        ///
        /// 获取仓库下单个Webhook数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRepositoryWebhookResponse ShowRepositoryWebhook(ShowRepositoryWebhookRequest showRepositoryWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryWebhookRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryWebhookRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryWebhookRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRepositoryWebhookResponse>(response);
        }

        public SyncInvoker<ShowRepositoryWebhookResponse> ShowRepositoryWebhookInvoker(ShowRepositoryWebhookRequest showRepositoryWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryWebhookRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryWebhookRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryWebhookRequest);
            return new SyncInvoker<ShowRepositoryWebhookResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepositoryWebhookResponse>);
        }
        
        /// <summary>
        /// 获取仓库下指定Webhook的指定日志详情
        ///
        /// 获取仓库下指定Webhook的指定日志详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRepositoryWebhookLogResponse ShowRepositoryWebhookLog(ShowRepositoryWebhookLogRequest showRepositoryWebhookLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryWebhookLogRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryWebhookLogRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryWebhookLogRequest.LogId, out var valueOfLogId)) urlParam.Add("log_id", valueOfLogId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/hooks/{hook_id}/logs/{log_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryWebhookLogRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRepositoryWebhookLogResponse>(response);
        }

        public SyncInvoker<ShowRepositoryWebhookLogResponse> ShowRepositoryWebhookLogInvoker(ShowRepositoryWebhookLogRequest showRepositoryWebhookLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryWebhookLogRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryWebhookLogRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryWebhookLogRequest.LogId, out var valueOfLogId)) urlParam.Add("log_id", valueOfLogId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/hooks/{hook_id}/logs/{log_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryWebhookLogRequest);
            return new SyncInvoker<ShowRepositoryWebhookLogResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepositoryWebhookLogResponse>);
        }
        
        /// <summary>
        /// 更新代码组下单个Webhook数据
        ///
        /// 更新代码组下单个Webhook数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGroupWebhookResponse UpdateGroupWebhook(UpdateGroupWebhookRequest updateGroupWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateGroupWebhookRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(updateGroupWebhookRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGroupWebhookRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGroupWebhookResponse>(response);
        }

        public SyncInvoker<UpdateGroupWebhookResponse> UpdateGroupWebhookInvoker(UpdateGroupWebhookRequest updateGroupWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateGroupWebhookRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(updateGroupWebhookRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGroupWebhookRequest);
            return new SyncInvoker<UpdateGroupWebhookResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGroupWebhookResponse>);
        }
        
        /// <summary>
        /// 更新项目下单个Webhook数据
        ///
        /// 更新项目下单个Webhook数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateProjectWebhookResponse UpdateProjectWebhook(UpdateProjectWebhookRequest updateProjectWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProjectWebhookRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(updateProjectWebhookRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProjectWebhookRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateProjectWebhookResponse>(response);
        }

        public SyncInvoker<UpdateProjectWebhookResponse> UpdateProjectWebhookInvoker(UpdateProjectWebhookRequest updateProjectWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProjectWebhookRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(updateProjectWebhookRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProjectWebhookRequest);
            return new SyncInvoker<UpdateProjectWebhookResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateProjectWebhookResponse>);
        }
        
        /// <summary>
        /// 更新仓库下单个Webhook数据
        ///
        /// 更新仓库下单个Webhook数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRepositoryWebhookResponse UpdateRepositoryWebhook(UpdateRepositoryWebhookRequest updateRepositoryWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryWebhookRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryWebhookRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepositoryWebhookRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRepositoryWebhookResponse>(response);
        }

        public SyncInvoker<UpdateRepositoryWebhookResponse> UpdateRepositoryWebhookInvoker(UpdateRepositoryWebhookRequest updateRepositoryWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryWebhookRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryWebhookRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepositoryWebhookRequest);
            return new SyncInvoker<UpdateRepositoryWebhookResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRepositoryWebhookResponse>);
        }
        
    }
}