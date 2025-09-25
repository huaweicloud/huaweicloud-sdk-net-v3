using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.CodeHub.V4.Model;

namespace HuaweiCloud.SDK.CodeHub.V4
{
    public partial class CodeHubAsyncClient : Client
    {
        public static ClientBuilder<CodeHubAsyncClient> NewBuilder()
        {
            return new ClientBuilder<CodeHubAsyncClient>();
        }

        
        /// <summary>
        /// 创建分支
        ///
        /// 创建分支
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateBranchResponse> CreateBranchAsync(CreateBranchRequest createBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createBranchRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBranchRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateBranchResponse>(response);
        }

        public AsyncInvoker<CreateBranchResponse> CreateBranchAsyncInvoker(CreateBranchRequest createBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createBranchRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBranchRequest);
            return new AsyncInvoker<CreateBranchResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateBranchResponse>);
        }
        
        /// <summary>
        /// 删除分支
        ///
        /// 删除分支
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteBranchResponse> DeleteBranchAsync(DeleteBranchRequest deleteBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteBranchRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/branch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBranchRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteBranchResponse>(response);
        }

        public AsyncInvoker<DeleteBranchResponse> DeleteBranchAsyncInvoker(DeleteBranchRequest deleteBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteBranchRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/branch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBranchRequest);
            return new AsyncInvoker<DeleteBranchResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteBranchResponse>);
        }
        
        /// <summary>
        /// 获取分支列表
        ///
        /// 获取分支列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBranchesResponse> ListBranchesAsync(ListBranchesRequest listBranchesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBranchesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBranchesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listBranchesResponse = JsonUtils.DeSerializeNull<ListBranchesResponse>(response);
            listBranchesResponse.Body = JsonUtils.DeSerializeList<BranchSimpleDto>(response);
            return listBranchesResponse;
        }

        public AsyncInvoker<ListBranchesResponse> ListBranchesAsyncInvoker(ListBranchesRequest listBranchesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBranchesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBranchesRequest);
            return new AsyncInvoker<ListBranchesResponse>(this, "GET", request, response =>
            {
                var listBranchesResponse = JsonUtils.DeSerializeNull<ListBranchesResponse>(response);
                listBranchesResponse.Body = JsonUtils.DeSerializeList<BranchSimpleDto>(response);
                return listBranchesResponse;
            });
        }
        
        /// <summary>
        /// 获取分支详情
        ///
        /// 获取分支详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBranchResponse> ShowBranchAsync(ShowBranchRequest showBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBranchRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/branch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBranchRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowBranchResponse>(response);
        }

        public AsyncInvoker<ShowBranchResponse> ShowBranchAsyncInvoker(ShowBranchRequest showBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBranchRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/branch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBranchRequest);
            return new AsyncInvoker<ShowBranchResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBranchResponse>);
        }
        
        /// <summary>
        /// 分支重命名
        ///
        /// 分支重命名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateBranchNameResponse> UpdateBranchNameAsync(UpdateBranchNameRequest updateBranchNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateBranchNameRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/branch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBranchNameRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateBranchNameResponse>(response);
        }

        public AsyncInvoker<UpdateBranchNameResponse> UpdateBranchNameAsyncInvoker(UpdateBranchNameRequest updateBranchNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateBranchNameRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/branch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBranchNameRequest);
            return new AsyncInvoker<UpdateBranchNameResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateBranchNameResponse>);
        }
        
        /// <summary>
        /// 创建提交信息
        ///
        /// 创建提交信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateCommitResponse> CreateCommitAsync(CreateCommitRequest createCommitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createCommitRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/commits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCommitRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateCommitResponse>(response);
        }

        public AsyncInvoker<CreateCommitResponse> CreateCommitAsyncInvoker(CreateCommitRequest createCommitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createCommitRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/commits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCommitRequest);
            return new AsyncInvoker<CreateCommitResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCommitResponse>);
        }
        
        /// <summary>
        /// 回退提交
        ///
        /// 回退提交
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateCommitRevertResponse> CreateCommitRevertAsync(CreateCommitRevertRequest createCommitRevertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createCommitRevertRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(createCommitRevertRequest.Sha, out var valueOfSha)) urlParam.Add("sha", valueOfSha);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/commits/{sha}/revert", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCommitRevertRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateCommitRevertResponse>(response);
        }

        public AsyncInvoker<CreateCommitRevertResponse> CreateCommitRevertAsyncInvoker(CreateCommitRevertRequest createCommitRevertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createCommitRevertRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(createCommitRevertRequest.Sha, out var valueOfSha)) urlParam.Add("sha", valueOfSha);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/commits/{sha}/revert", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCommitRevertRequest);
            return new AsyncInvoker<CreateCommitRevertResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCommitRevertResponse>);
        }
        
        /// <summary>
        /// 根据提交ID查询分支、标签列表
        ///
        /// 根据提交ID查询分支、标签列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCommitAssociatedRefsResponse> ListCommitAssociatedRefsAsync(ListCommitAssociatedRefsRequest listCommitAssociatedRefsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listCommitAssociatedRefsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listCommitAssociatedRefsRequest.Sha, out var valueOfSha)) urlParam.Add("sha", valueOfSha);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/commits/{sha}/refs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCommitAssociatedRefsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listCommitAssociatedRefsResponse = JsonUtils.DeSerializeNull<ListCommitAssociatedRefsResponse>(response);
            listCommitAssociatedRefsResponse.Body = JsonUtils.DeSerializeList<string>(response);
            return listCommitAssociatedRefsResponse;
        }

        public AsyncInvoker<ListCommitAssociatedRefsResponse> ListCommitAssociatedRefsAsyncInvoker(ListCommitAssociatedRefsRequest listCommitAssociatedRefsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listCommitAssociatedRefsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listCommitAssociatedRefsRequest.Sha, out var valueOfSha)) urlParam.Add("sha", valueOfSha);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/commits/{sha}/refs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCommitAssociatedRefsRequest);
            return new AsyncInvoker<ListCommitAssociatedRefsResponse>(this, "GET", request, response =>
            {
                var listCommitAssociatedRefsResponse = JsonUtils.DeSerializeNull<ListCommitAssociatedRefsResponse>(response);
                listCommitAssociatedRefsResponse.Body = JsonUtils.DeSerializeList<string>(response);
                return listCommitAssociatedRefsResponse;
            });
        }
        
        /// <summary>
        /// 获取特定提交信息
        ///
        /// 获取特定提交信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCommitResponse> ShowCommitAsync(ShowCommitRequest showCommitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCommitRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/commits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCommitRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowCommitResponse>(response);
        }

        public AsyncInvoker<ShowCommitResponse> ShowCommitAsyncInvoker(ShowCommitRequest showCommitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCommitRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/commits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCommitRequest);
            return new AsyncInvoker<ShowCommitResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCommitResponse>);
        }
        
        /// <summary>
        /// 获取commit引入的文件变更元数据
        ///
        /// 获取commit引入的文件变更元数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCommitDiffMetadataResponse> ShowCommitDiffMetadataAsync(ShowCommitDiffMetadataRequest showCommitDiffMetadataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCommitDiffMetadataRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/commits/diff-metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCommitDiffMetadataRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowCommitDiffMetadataResponse>(response);
        }

        public AsyncInvoker<ShowCommitDiffMetadataResponse> ShowCommitDiffMetadataAsyncInvoker(ShowCommitDiffMetadataRequest showCommitDiffMetadataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCommitDiffMetadataRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/commits/diff-metadata", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCommitDiffMetadataRequest);
            return new AsyncInvoker<ShowCommitDiffMetadataResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCommitDiffMetadataResponse>);
        }
        
        /// <summary>
        /// 获取commit引入的指定文件的变更内容
        ///
        /// 获取commit引入的指定文件的变更内容
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCommitFileDiffResponse> ShowCommitFileDiffAsync(ShowCommitFileDiffRequest showCommitFileDiffRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCommitFileDiffRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/commits/file-diff", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCommitFileDiffRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var showCommitFileDiffResponse = JsonUtils.DeSerializeNull<ShowCommitFileDiffResponse>(response);
            showCommitFileDiffResponse.Body = JsonUtils.DeSerializeList<FileDiffDto>(response);
            return showCommitFileDiffResponse;
        }

        public AsyncInvoker<ShowCommitFileDiffResponse> ShowCommitFileDiffAsyncInvoker(ShowCommitFileDiffRequest showCommitFileDiffRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCommitFileDiffRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/commits/file-diff", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCommitFileDiffRequest);
            return new AsyncInvoker<ShowCommitFileDiffResponse>(this, "GET", request, response =>
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
        public async Task<ShowDiffCommitResponse> ShowDiffCommitAsync(ShowDiffCommitRequest showDiffCommitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDiffCommitRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/commits/diff", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDiffCommitRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDiffCommitResponse>(response);
        }

        public AsyncInvoker<ShowDiffCommitResponse> ShowDiffCommitAsyncInvoker(ShowDiffCommitRequest showDiffCommitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDiffCommitRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/commits/diff", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDiffCommitRequest);
            return new AsyncInvoker<ShowDiffCommitResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDiffCommitResponse>);
        }
        
        /// <summary>
        /// 创建合并请求检视意见
        ///
        /// 创建合并请求检视意见
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateMergeRequestDiscussionResponse> CreateMergeRequestDiscussionAsync(CreateMergeRequestDiscussionRequest createMergeRequestDiscussionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/discussions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMergeRequestDiscussionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateMergeRequestDiscussionResponse>(response);
        }

        public AsyncInvoker<CreateMergeRequestDiscussionResponse> CreateMergeRequestDiscussionAsyncInvoker(CreateMergeRequestDiscussionRequest createMergeRequestDiscussionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/discussions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMergeRequestDiscussionRequest);
            return new AsyncInvoker<CreateMergeRequestDiscussionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMergeRequestDiscussionResponse>);
        }
        
        /// <summary>
        /// 回复合并请求检视意见
        ///
        /// 回复合并请求检视意见
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateMergeRequestDiscussionResponseResponse> CreateMergeRequestDiscussionResponseAsync(CreateMergeRequestDiscussionResponseRequest createMergeRequestDiscussionResponseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionResponseRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionResponseRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionResponseRequest.DiscussionId, out var valueOfDiscussionId)) urlParam.Add("discussion_id", valueOfDiscussionId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/discussions/{discussion_id}/notes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMergeRequestDiscussionResponseRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateMergeRequestDiscussionResponseResponse>(response);
        }

        public AsyncInvoker<CreateMergeRequestDiscussionResponseResponse> CreateMergeRequestDiscussionResponseAsyncInvoker(CreateMergeRequestDiscussionResponseRequest createMergeRequestDiscussionResponseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionResponseRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionResponseRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestDiscussionResponseRequest.DiscussionId, out var valueOfDiscussionId)) urlParam.Add("discussion_id", valueOfDiscussionId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/discussions/{discussion_id}/notes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMergeRequestDiscussionResponseRequest);
            return new AsyncInvoker<CreateMergeRequestDiscussionResponseResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMergeRequestDiscussionResponseResponse>);
        }
        
        /// <summary>
        /// 创建/更新检视意见设置
        ///
        /// 创建/更新检视意见设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateReviewSettingResponse> CreateReviewSettingAsync(CreateReviewSettingRequest createReviewSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createReviewSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/review-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createReviewSettingRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateReviewSettingResponse>(response);
        }

        public AsyncInvoker<CreateReviewSettingResponse> CreateReviewSettingAsyncInvoker(CreateReviewSettingRequest createReviewSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createReviewSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/review-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createReviewSettingRequest);
            return new AsyncInvoker<CreateReviewSettingResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateReviewSettingResponse>);
        }
        
        /// <summary>
        /// 获取默认的检视意见分类
        ///
        /// 获取默认的检视意见分类
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDefaultReviewCategoriesResponse> ListDefaultReviewCategoriesAsync(ListDefaultReviewCategoriesRequest listDefaultReviewCategoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/default-review-categories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDefaultReviewCategoriesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDefaultReviewCategoriesResponse>(response);
        }

        public AsyncInvoker<ListDefaultReviewCategoriesResponse> ListDefaultReviewCategoriesAsyncInvoker(ListDefaultReviewCategoriesRequest listDefaultReviewCategoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/default-review-categories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDefaultReviewCategoriesRequest);
            return new AsyncInvoker<ListDefaultReviewCategoriesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDefaultReviewCategoriesResponse>);
        }
        
        /// <summary>
        /// 获取合并请求检视意见列表
        ///
        /// 获取合并请求检视意见列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMergeRequestDiscussionsResponse> ListMergeRequestDiscussionsAsync(ListMergeRequestDiscussionsRequest listMergeRequestDiscussionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestDiscussionsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestDiscussionsRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/discussions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestDiscussionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listMergeRequestDiscussionsResponse = JsonUtils.DeSerializeNull<ListMergeRequestDiscussionsResponse>(response);
            listMergeRequestDiscussionsResponse.Body = JsonUtils.DeSerializeList<MergeRequestDiscussionDto>(response);
            return listMergeRequestDiscussionsResponse;
        }

        public AsyncInvoker<ListMergeRequestDiscussionsResponse> ListMergeRequestDiscussionsAsyncInvoker(ListMergeRequestDiscussionsRequest listMergeRequestDiscussionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestDiscussionsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestDiscussionsRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/discussions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestDiscussionsRequest);
            return new AsyncInvoker<ListMergeRequestDiscussionsResponse>(this, "GET", request, response =>
            {
                var listMergeRequestDiscussionsResponse = JsonUtils.DeSerializeNull<ListMergeRequestDiscussionsResponse>(response);
                listMergeRequestDiscussionsResponse.Body = JsonUtils.DeSerializeList<MergeRequestDiscussionDto>(response);
                return listMergeRequestDiscussionsResponse;
            });
        }
        
        /// <summary>
        /// 获取项目检视意见必填项
        ///
        /// 获取项目检视意见必填项
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProjectNoteRequiredAttributesResponse> ListProjectNoteRequiredAttributesAsync(ListProjectNoteRequiredAttributesRequest listProjectNoteRequiredAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectNoteRequiredAttributesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/setting/note-required-attributes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectNoteRequiredAttributesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListProjectNoteRequiredAttributesResponse>(response);
        }

        public AsyncInvoker<ListProjectNoteRequiredAttributesResponse> ListProjectNoteRequiredAttributesAsyncInvoker(ListProjectNoteRequiredAttributesRequest listProjectNoteRequiredAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectNoteRequiredAttributesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/setting/note-required-attributes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectNoteRequiredAttributesRequest);
            return new AsyncInvoker<ListProjectNoteRequiredAttributesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProjectNoteRequiredAttributesResponse>);
        }
        
        /// <summary>
        /// 获取仓库下检视意见作者列表
        ///
        /// 获取仓库下检视意见作者列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRepositoryReviewAuthorsResponse> ListRepositoryReviewAuthorsAsync(ListRepositoryReviewAuthorsRequest listRepositoryReviewAuthorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryReviewAuthorsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/review-authors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryReviewAuthorsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listRepositoryReviewAuthorsResponse = JsonUtils.DeSerializeNull<ListRepositoryReviewAuthorsResponse>(response);
            listRepositoryReviewAuthorsResponse.Body = JsonUtils.DeSerializeList<UserBasicDto>(response);
            return listRepositoryReviewAuthorsResponse;
        }

        public AsyncInvoker<ListRepositoryReviewAuthorsResponse> ListRepositoryReviewAuthorsAsyncInvoker(ListRepositoryReviewAuthorsRequest listRepositoryReviewAuthorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryReviewAuthorsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/review-authors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryReviewAuthorsRequest);
            return new AsyncInvoker<ListRepositoryReviewAuthorsResponse>(this, "GET", request, response =>
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
        public async Task<ListRepositoryReviewsResponse> ListRepositoryReviewsAsync(ListRepositoryReviewsRequest listRepositoryReviewsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryReviewsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/reviews", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryReviewsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listRepositoryReviewsResponse = JsonUtils.DeSerializeNull<ListRepositoryReviewsResponse>(response);
            listRepositoryReviewsResponse.Body = JsonUtils.DeSerializeList<ReviewDto>(response);
            return listRepositoryReviewsResponse;
        }

        public AsyncInvoker<ListRepositoryReviewsResponse> ListRepositoryReviewsAsyncInvoker(ListRepositoryReviewsRequest listRepositoryReviewsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryReviewsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/reviews", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryReviewsRequest);
            return new AsyncInvoker<ListRepositoryReviewsResponse>(this, "GET", request, response =>
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
        public async Task<ShowGroupNoteRequiredAttributesResponse> ShowGroupNoteRequiredAttributesAsync(ShowGroupNoteRequiredAttributesRequest showGroupNoteRequiredAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupNoteRequiredAttributesRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/setting/note-required-attributes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupNoteRequiredAttributesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var showGroupNoteRequiredAttributesResponse = JsonUtils.DeSerializeNull<ShowGroupNoteRequiredAttributesResponse>(response);
            showGroupNoteRequiredAttributesResponse.Body = JsonUtils.DeSerializeList<NoteRequiredAttributeDto>(response);
            return showGroupNoteRequiredAttributesResponse;
        }

        public AsyncInvoker<ShowGroupNoteRequiredAttributesResponse> ShowGroupNoteRequiredAttributesAsyncInvoker(ShowGroupNoteRequiredAttributesRequest showGroupNoteRequiredAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupNoteRequiredAttributesRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/setting/note-required-attributes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupNoteRequiredAttributesRequest);
            return new AsyncInvoker<ShowGroupNoteRequiredAttributesResponse>(this, "GET", request, response =>
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
        public async Task<ShowGroupReviewSettingsResponse> ShowGroupReviewSettingsAsync(ShowGroupReviewSettingsRequest showGroupReviewSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupReviewSettingsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/review-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupReviewSettingsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowGroupReviewSettingsResponse>(response);
        }

        public AsyncInvoker<ShowGroupReviewSettingsResponse> ShowGroupReviewSettingsAsyncInvoker(ShowGroupReviewSettingsRequest showGroupReviewSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupReviewSettingsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/review-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupReviewSettingsRequest);
            return new AsyncInvoker<ShowGroupReviewSettingsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGroupReviewSettingsResponse>);
        }
        
        /// <summary>
        /// 根据discussion_id获取合并请求检视意见
        ///
        /// 根据discussion_id获取合并请求检视意见
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMergeRequestDiscussionResponse> ShowMergeRequestDiscussionAsync(ShowMergeRequestDiscussionRequest showMergeRequestDiscussionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestDiscussionRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestDiscussionRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestDiscussionRequest.DiscussionId, out var valueOfDiscussionId)) urlParam.Add("discussion_id", valueOfDiscussionId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/discussions/{discussion_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMergeRequestDiscussionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowMergeRequestDiscussionResponse>(response);
        }

        public AsyncInvoker<ShowMergeRequestDiscussionResponse> ShowMergeRequestDiscussionAsyncInvoker(ShowMergeRequestDiscussionRequest showMergeRequestDiscussionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestDiscussionRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestDiscussionRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestDiscussionRequest.DiscussionId, out var valueOfDiscussionId)) urlParam.Add("discussion_id", valueOfDiscussionId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/discussions/{discussion_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMergeRequestDiscussionRequest);
            return new AsyncInvoker<ShowMergeRequestDiscussionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMergeRequestDiscussionResponse>);
        }
        
        /// <summary>
        /// 获取仓库检视意见必填项
        ///
        /// 获取仓库检视意见必填项
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowNoteRequiredAttributesResponse> ShowNoteRequiredAttributesAsync(ShowNoteRequiredAttributesRequest showNoteRequiredAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNoteRequiredAttributesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/setting/note-required-attributes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNoteRequiredAttributesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var showNoteRequiredAttributesResponse = JsonUtils.DeSerializeNull<ShowNoteRequiredAttributesResponse>(response);
            showNoteRequiredAttributesResponse.Body = JsonUtils.DeSerializeList<NoteRequiredAttributeDto>(response);
            return showNoteRequiredAttributesResponse;
        }

        public AsyncInvoker<ShowNoteRequiredAttributesResponse> ShowNoteRequiredAttributesAsyncInvoker(ShowNoteRequiredAttributesRequest showNoteRequiredAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNoteRequiredAttributesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/setting/note-required-attributes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNoteRequiredAttributesRequest);
            return new AsyncInvoker<ShowNoteRequiredAttributesResponse>(this, "GET", request, response =>
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
        public async Task<ShowProjectReviewSettingsResponse> ShowProjectReviewSettingsAsync(ShowProjectReviewSettingsRequest showProjectReviewSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectReviewSettingsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/review-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectReviewSettingsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectReviewSettingsResponse>(response);
        }

        public AsyncInvoker<ShowProjectReviewSettingsResponse> ShowProjectReviewSettingsAsyncInvoker(ShowProjectReviewSettingsRequest showProjectReviewSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectReviewSettingsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/review-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectReviewSettingsRequest);
            return new AsyncInvoker<ShowProjectReviewSettingsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectReviewSettingsResponse>);
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
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/review-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReviewSettingRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowReviewSettingResponse>(response);
        }

        public AsyncInvoker<ShowReviewSettingResponse> ShowReviewSettingAsyncInvoker(ShowReviewSettingRequest showReviewSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showReviewSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/review-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReviewSettingRequest);
            return new AsyncInvoker<ShowReviewSettingResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowReviewSettingResponse>);
        }
        
        /// <summary>
        /// 创建/更新代码组检视意见必填项
        ///
        /// 创建/更新代码组检视意见必填项
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateGroupNoteRequiredAttributesResponse> UpdateGroupNoteRequiredAttributesAsync(UpdateGroupNoteRequiredAttributesRequest updateGroupNoteRequiredAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateGroupNoteRequiredAttributesRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/setting/note-required-attributes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGroupNoteRequiredAttributesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateGroupNoteRequiredAttributesResponse>(response);
        }

        public AsyncInvoker<UpdateGroupNoteRequiredAttributesResponse> UpdateGroupNoteRequiredAttributesAsyncInvoker(UpdateGroupNoteRequiredAttributesRequest updateGroupNoteRequiredAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateGroupNoteRequiredAttributesRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/setting/note-required-attributes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGroupNoteRequiredAttributesRequest);
            return new AsyncInvoker<UpdateGroupNoteRequiredAttributesResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateGroupNoteRequiredAttributesResponse>);
        }
        
        /// <summary>
        /// 创建/更新代码组检视意见设置(不含必填项)
        ///
        /// 创建/更新代码组检视意见设置(不含必填项)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateGroupReviewSettingsResponse> UpdateGroupReviewSettingsAsync(UpdateGroupReviewSettingsRequest updateGroupReviewSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateGroupReviewSettingsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/review-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGroupReviewSettingsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateGroupReviewSettingsResponse>(response);
        }

        public AsyncInvoker<UpdateGroupReviewSettingsResponse> UpdateGroupReviewSettingsAsyncInvoker(UpdateGroupReviewSettingsRequest updateGroupReviewSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateGroupReviewSettingsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/review-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGroupReviewSettingsRequest);
            return new AsyncInvoker<UpdateGroupReviewSettingsResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateGroupReviewSettingsResponse>);
        }
        
        /// <summary>
        /// 更新合并请求检视意见
        ///
        /// 更新合并请求检视意见
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateMergeRequestDiscussionResponse> UpdateMergeRequestDiscussionAsync(UpdateMergeRequestDiscussionRequest updateMergeRequestDiscussionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestDiscussionRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestDiscussionRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestDiscussionRequest.DiscussionId, out var valueOfDiscussionId)) urlParam.Add("discussion_id", valueOfDiscussionId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestDiscussionRequest.NoteId, out var valueOfNoteId)) urlParam.Add("note_id", valueOfNoteId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/discussions/{discussion_id}/notes/{note_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestDiscussionRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateMergeRequestDiscussionResponse>(response);
        }

        public AsyncInvoker<UpdateMergeRequestDiscussionResponse> UpdateMergeRequestDiscussionAsyncInvoker(UpdateMergeRequestDiscussionRequest updateMergeRequestDiscussionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestDiscussionRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestDiscussionRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestDiscussionRequest.DiscussionId, out var valueOfDiscussionId)) urlParam.Add("discussion_id", valueOfDiscussionId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestDiscussionRequest.NoteId, out var valueOfNoteId)) urlParam.Add("note_id", valueOfNoteId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/discussions/{discussion_id}/notes/{note_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestDiscussionRequest);
            return new AsyncInvoker<UpdateMergeRequestDiscussionResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateMergeRequestDiscussionResponse>);
        }
        
        /// <summary>
        /// 创建/更新仓库检视意见必填项
        ///
        /// 创建/更新仓库检视意见必填项
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateNoteRequiredAttributesResponse> UpdateNoteRequiredAttributesAsync(UpdateNoteRequiredAttributesRequest updateNoteRequiredAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateNoteRequiredAttributesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/setting/note-required-attributes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNoteRequiredAttributesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateNoteRequiredAttributesResponse>(response);
        }

        public AsyncInvoker<UpdateNoteRequiredAttributesResponse> UpdateNoteRequiredAttributesAsyncInvoker(UpdateNoteRequiredAttributesRequest updateNoteRequiredAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateNoteRequiredAttributesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/setting/note-required-attributes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNoteRequiredAttributesRequest);
            return new AsyncInvoker<UpdateNoteRequiredAttributesResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateNoteRequiredAttributesResponse>);
        }
        
        /// <summary>
        /// 创建/更新项目检视意见必填项
        ///
        /// 创建/更新项目检视意见必填项
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateProjectNoteRequiredAttributesResponse> UpdateProjectNoteRequiredAttributesAsync(UpdateProjectNoteRequiredAttributesRequest updateProjectNoteRequiredAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProjectNoteRequiredAttributesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/setting/note-required-attributes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProjectNoteRequiredAttributesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateProjectNoteRequiredAttributesResponse>(response);
        }

        public AsyncInvoker<UpdateProjectNoteRequiredAttributesResponse> UpdateProjectNoteRequiredAttributesAsyncInvoker(UpdateProjectNoteRequiredAttributesRequest updateProjectNoteRequiredAttributesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProjectNoteRequiredAttributesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/setting/note-required-attributes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProjectNoteRequiredAttributesRequest);
            return new AsyncInvoker<UpdateProjectNoteRequiredAttributesResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateProjectNoteRequiredAttributesResponse>);
        }
        
        /// <summary>
        /// 创建/更新项目检视意见设置(不含必填项)
        ///
        /// 创建/更新项目检视意见设置(不含必填项)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateProjectReviewSettingsResponse> UpdateProjectReviewSettingsAsync(UpdateProjectReviewSettingsRequest updateProjectReviewSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProjectReviewSettingsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/review-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProjectReviewSettingsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateProjectReviewSettingsResponse>(response);
        }

        public AsyncInvoker<UpdateProjectReviewSettingsResponse> UpdateProjectReviewSettingsAsyncInvoker(UpdateProjectReviewSettingsRequest updateProjectReviewSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProjectReviewSettingsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/review-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProjectReviewSettingsRequest);
            return new AsyncInvoker<UpdateProjectReviewSettingsResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateProjectReviewSettingsResponse>);
        }
        
        /// <summary>
        /// 创建文件
        ///
        /// 创建文件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateFileResponse> CreateFileAsync(CreateFileRequest createFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createFileRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFileRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateFileResponse>(response);
        }

        public AsyncInvoker<CreateFileResponse> CreateFileAsyncInvoker(CreateFileRequest createFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createFileRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFileRequest);
            return new AsyncInvoker<CreateFileResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateFileResponse>);
        }
        
        /// <summary>
        /// 删除文件
        ///
        /// 删除文件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteFileResponse> DeleteFileAsync(DeleteFileRequest deleteFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteFileRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFileRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteFileResponse>(response);
        }

        public AsyncInvoker<DeleteFileResponse> DeleteFileAsyncInvoker(DeleteFileRequest deleteFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteFileRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFileRequest);
            return new AsyncInvoker<DeleteFileResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteFileResponse>);
        }
        
        /// <summary>
        /// 获取仓库单个文件内容(下载单个文件)
        ///
        /// 获取仓库单个文件内容(下载单个文件)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DownloadBlobsRawResponse> DownloadBlobsRawAsync(DownloadBlobsRawRequest downloadBlobsRawRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadBlobsRawRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(downloadBlobsRawRequest.BlobId, out var valueOfBlobId)) urlParam.Add("blob_id", valueOfBlobId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/blobs/{blob_id}/raw", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadBlobsRawRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<DownloadBlobsRawResponse>(response);
        }

        public AsyncInvoker<DownloadBlobsRawResponse> DownloadBlobsRawAsyncInvoker(DownloadBlobsRawRequest downloadBlobsRawRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadBlobsRawRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(downloadBlobsRawRequest.BlobId, out var valueOfBlobId)) urlParam.Add("blob_id", valueOfBlobId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/blobs/{blob_id}/raw", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadBlobsRawRequest);
            return new AsyncInvoker<DownloadBlobsRawResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadBlobsRawResponse>);
        }
        
        /// <summary>
        /// 获取文件追溯信息
        ///
        /// 获取文件追溯信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFileBlameLinesResponse> ListFileBlameLinesAsync(ListFileBlameLinesRequest listFileBlameLinesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFileBlameLinesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/blame", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFileBlameLinesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listFileBlameLinesResponse = JsonUtils.DeSerializeNull<ListFileBlameLinesResponse>(response);
            listFileBlameLinesResponse.Body = JsonUtils.DeSerializeList<BlameDto>(response);
            return listFileBlameLinesResponse;
        }

        public AsyncInvoker<ListFileBlameLinesResponse> ListFileBlameLinesAsyncInvoker(ListFileBlameLinesRequest listFileBlameLinesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFileBlameLinesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/blame", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFileBlameLinesRequest);
            return new AsyncInvoker<ListFileBlameLinesResponse>(this, "GET", request, response =>
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
        public async Task<ListFileUpperTreeEntriesResponse> ListFileUpperTreeEntriesAsync(ListFileUpperTreeEntriesRequest listFileUpperTreeEntriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFileUpperTreeEntriesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/upper-files-tree", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFileUpperTreeEntriesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listFileUpperTreeEntriesResponse = JsonUtils.DeSerializeNull<ListFileUpperTreeEntriesResponse>(response);
            listFileUpperTreeEntriesResponse.Body = JsonUtils.DeSerializeList<TreeDto>(response);
            return listFileUpperTreeEntriesResponse;
        }

        public AsyncInvoker<ListFileUpperTreeEntriesResponse> ListFileUpperTreeEntriesAsyncInvoker(ListFileUpperTreeEntriesRequest listFileUpperTreeEntriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFileUpperTreeEntriesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/upper-files-tree", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFileUpperTreeEntriesRequest);
            return new AsyncInvoker<ListFileUpperTreeEntriesResponse>(this, "GET", request, response =>
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
        public async Task<ListFilesResponse> ListFilesAsync(ListFilesRequest listFilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFilesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/file-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFilesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listFilesResponse = JsonUtils.DeSerializeNull<ListFilesResponse>(response);
            listFilesResponse.Body = JsonUtils.DeSerializeList<string>(response);
            return listFilesResponse;
        }

        public AsyncInvoker<ListFilesResponse> ListFilesAsyncInvoker(ListFilesRequest listFilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFilesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/file-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFilesRequest);
            return new AsyncInvoker<ListFilesResponse>(this, "GET", request, response =>
            {
                var listFilesResponse = JsonUtils.DeSerializeNull<ListFilesResponse>(response);
                listFilesResponse.Body = JsonUtils.DeSerializeList<string>(response);
                return listFilesResponse;
            });
        }
        
        /// <summary>
        /// 查看文件属性与内容
        ///
        /// 查看文件属性与内容
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowFileResponse> ShowFileAsync(ShowFileRequest showFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFileRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFileRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowFileResponse>(response);
        }

        public AsyncInvoker<ShowFileResponse> ShowFileAsyncInvoker(ShowFileRequest showFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFileRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFileRequest);
            return new AsyncInvoker<ShowFileResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFileResponse>);
        }
        
        /// <summary>
        /// 获取文件内容
        ///
        /// 获取文件内容
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowFileContentResponse> ShowFileContentAsync(ShowFileContentRequest showFileContentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFileContentRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/file-content", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFileContentRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowFileContentResponse>(response);
        }

        public AsyncInvoker<ShowFileContentResponse> ShowFileContentAsyncInvoker(ShowFileContentRequest showFileContentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFileContentRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/file-content", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFileContentRequest);
            return new AsyncInvoker<ShowFileContentResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFileContentResponse>);
        }
        
        /// <summary>
        /// 获取仓库默认分支的Readme文件内容
        ///
        /// 获取仓库默认分支的Readme文件内容
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowReadmeFileResponse> ShowReadmeFileAsync(ShowReadmeFileRequest showReadmeFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showReadmeFileRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/readme-file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReadmeFileRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowReadmeFileResponse>(response);
        }

        public AsyncInvoker<ShowReadmeFileResponse> ShowReadmeFileAsyncInvoker(ShowReadmeFileRequest showReadmeFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showReadmeFileRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/readme-file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReadmeFileRequest);
            return new AsyncInvoker<ShowReadmeFileResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowReadmeFileResponse>);
        }
        
        /// <summary>
        /// 更新文件内容
        ///
        /// 修改仓库ip白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateFileResponse> UpdateFileAsync(UpdateFileRequest updateFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateFileRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFileRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateFileResponse>(response);
        }

        public AsyncInvoker<UpdateFileResponse> UpdateFileAsyncInvoker(UpdateFileRequest updateFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateFileRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFileRequest);
            return new AsyncInvoker<UpdateFileResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateFileResponse>);
        }
        
        /// <summary>
        /// 批量删除仓库文件推送权限
        ///
        /// 批量删除仓库文件推送权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteRepositoryFilePushPermissionsResponse> BatchDeleteRepositoryFilePushPermissionsAsync(BatchDeleteRepositoryFilePushPermissionsRequest batchDeleteRepositoryFilePushPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteRepositoryFilePushPermissionsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/file-push-permissions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteRepositoryFilePushPermissionsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteRepositoryFilePushPermissionsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteRepositoryFilePushPermissionsResponse> BatchDeleteRepositoryFilePushPermissionsAsyncInvoker(BatchDeleteRepositoryFilePushPermissionsRequest batchDeleteRepositoryFilePushPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteRepositoryFilePushPermissionsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/file-push-permissions/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteRepositoryFilePushPermissionsRequest);
            return new AsyncInvoker<BatchDeleteRepositoryFilePushPermissionsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteRepositoryFilePushPermissionsResponse>);
        }
        
        /// <summary>
        /// 批量更新仓库文件推送权限
        ///
        /// 批量更新仓库文件推送权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUpdateRepositoryFilePushPermissionsResponse> BatchUpdateRepositoryFilePushPermissionsAsync(BatchUpdateRepositoryFilePushPermissionsRequest batchUpdateRepositoryFilePushPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateRepositoryFilePushPermissionsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/file-push-permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateRepositoryFilePushPermissionsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            var batchUpdateRepositoryFilePushPermissionsResponse = JsonUtils.DeSerializeNull<BatchUpdateRepositoryFilePushPermissionsResponse>(response);
            batchUpdateRepositoryFilePushPermissionsResponse.Body = JsonUtils.DeSerializeList<RepositoryFilePushPermissionDto>(response);
            return batchUpdateRepositoryFilePushPermissionsResponse;
        }

        public AsyncInvoker<BatchUpdateRepositoryFilePushPermissionsResponse> BatchUpdateRepositoryFilePushPermissionsAsyncInvoker(BatchUpdateRepositoryFilePushPermissionsRequest batchUpdateRepositoryFilePushPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateRepositoryFilePushPermissionsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/file-push-permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateRepositoryFilePushPermissionsRequest);
            return new AsyncInvoker<BatchUpdateRepositoryFilePushPermissionsResponse>(this, "PUT", request, response =>
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
        public async Task<CreateFilePushPermissionResponse> CreateFilePushPermissionAsync(CreateFilePushPermissionRequest createFilePushPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createFilePushPermissionRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/file-push-permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFilePushPermissionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateFilePushPermissionResponse>(response);
        }

        public AsyncInvoker<CreateFilePushPermissionResponse> CreateFilePushPermissionAsyncInvoker(CreateFilePushPermissionRequest createFilePushPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createFilePushPermissionRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/file-push-permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFilePushPermissionRequest);
            return new AsyncInvoker<CreateFilePushPermissionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateFilePushPermissionResponse>);
        }
        
        /// <summary>
        /// 获取仓库文件推送权限列表
        ///
        /// 获取仓库文件推送权限列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRepositoryFilePushPermissionsResponse> ListRepositoryFilePushPermissionsAsync(ListRepositoryFilePushPermissionsRequest listRepositoryFilePushPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryFilePushPermissionsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/file-push-permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryFilePushPermissionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listRepositoryFilePushPermissionsResponse = JsonUtils.DeSerializeNull<ListRepositoryFilePushPermissionsResponse>(response);
            listRepositoryFilePushPermissionsResponse.Body = JsonUtils.DeSerializeList<RepositoryFilePushPermissionDto>(response);
            return listRepositoryFilePushPermissionsResponse;
        }

        public AsyncInvoker<ListRepositoryFilePushPermissionsResponse> ListRepositoryFilePushPermissionsAsyncInvoker(ListRepositoryFilePushPermissionsRequest listRepositoryFilePushPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryFilePushPermissionsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/file-push-permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryFilePushPermissionsRequest);
            return new AsyncInvoker<ListRepositoryFilePushPermissionsResponse>(this, "GET", request, response =>
            {
                var listRepositoryFilePushPermissionsResponse = JsonUtils.DeSerializeNull<ListRepositoryFilePushPermissionsResponse>(response);
                listRepositoryFilePushPermissionsResponse.Body = JsonUtils.DeSerializeList<RepositoryFilePushPermissionDto>(response);
                return listRepositoryFilePushPermissionsResponse;
            });
        }
        
        /// <summary>
        /// 关联代码组与成员组
        ///
        /// 关联代码组与成员组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociateGroupUserGroupResponse> AssociateGroupUserGroupAsync(AssociateGroupUserGroupRequest associateGroupUserGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateGroupUserGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(associateGroupUserGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(associateGroupUserGroupRequest.UserGroupId, out var valueOfUserGroupId)) urlParam.Add("user_group_id", valueOfUserGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/groups/{group_id}/user-group/{user_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateGroupUserGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AssociateGroupUserGroupResponse>(response);
        }

        public AsyncInvoker<AssociateGroupUserGroupResponse> AssociateGroupUserGroupAsyncInvoker(AssociateGroupUserGroupRequest associateGroupUserGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateGroupUserGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(associateGroupUserGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(associateGroupUserGroupRequest.UserGroupId, out var valueOfUserGroupId)) urlParam.Add("user_group_id", valueOfUserGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/groups/{group_id}/user-group/{user_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateGroupUserGroupRequest);
            return new AsyncInvoker<AssociateGroupUserGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateGroupUserGroupResponse>);
        }
        
        /// <summary>
        /// 创建代码组
        ///
        /// 创建代码组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest createGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateGroupResponse>(response);
        }

        public AsyncInvoker<CreateGroupResponse> CreateGroupAsyncInvoker(CreateGroupRequest createGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGroupRequest);
            return new AsyncInvoker<CreateGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGroupResponse>);
        }
        
        /// <summary>
        /// 删除代码组
        ///
        /// 删除代码组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest deleteGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGroupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteGroupResponse>(response);
        }

        public AsyncInvoker<DeleteGroupResponse> DeleteGroupAsyncInvoker(DeleteGroupRequest deleteGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGroupRequest);
            return new AsyncInvoker<DeleteGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteGroupResponse>);
        }
        
        /// <summary>
        /// 获取代码组下可添加的成员列表
        ///
        /// 获取代码组下可添加的成员列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGroupAddableMembersResponse> ListGroupAddableMembersAsync(ListGroupAddableMembersRequest listGroupAddableMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupAddableMembersRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/members/addable-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupAddableMembersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listGroupAddableMembersResponse = JsonUtils.DeSerializeNull<ListGroupAddableMembersResponse>(response);
            listGroupAddableMembersResponse.Body = JsonUtils.DeSerializeList<GroupBatchAddMemberDto>(response);
            return listGroupAddableMembersResponse;
        }

        public AsyncInvoker<ListGroupAddableMembersResponse> ListGroupAddableMembersAsyncInvoker(ListGroupAddableMembersRequest listGroupAddableMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupAddableMembersRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/members/addable-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupAddableMembersRequest);
            return new AsyncInvoker<ListGroupAddableMembersResponse>(this, "GET", request, response =>
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
        public async Task<ListGroupAddableUserGroupsResponse> ListGroupAddableUserGroupsAsync(ListGroupAddableUserGroupsRequest listGroupAddableUserGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupAddableUserGroupsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/user-groups/addable-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupAddableUserGroupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listGroupAddableUserGroupsResponse = JsonUtils.DeSerializeNull<ListGroupAddableUserGroupsResponse>(response);
            listGroupAddableUserGroupsResponse.Body = JsonUtils.DeSerializeList<UserGroupDto>(response);
            return listGroupAddableUserGroupsResponse;
        }

        public AsyncInvoker<ListGroupAddableUserGroupsResponse> ListGroupAddableUserGroupsAsyncInvoker(ListGroupAddableUserGroupsRequest listGroupAddableUserGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupAddableUserGroupsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/user-groups/addable-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupAddableUserGroupsRequest);
            return new AsyncInvoker<ListGroupAddableUserGroupsResponse>(this, "GET", request, response =>
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
        public async Task<ListGroupMembersResponse> ListGroupMembersAsync(ListGroupMembersRequest listGroupMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupMembersRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/members/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupMembersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listGroupMembersResponse = JsonUtils.DeSerializeNull<ListGroupMembersResponse>(response);
            listGroupMembersResponse.Body = JsonUtils.DeSerializeList<GroupMemberDetailDto>(response);
            return listGroupMembersResponse;
        }

        public AsyncInvoker<ListGroupMembersResponse> ListGroupMembersAsyncInvoker(ListGroupMembersRequest listGroupMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupMembersRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/members/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupMembersRequest);
            return new AsyncInvoker<ListGroupMembersResponse>(this, "GET", request, response =>
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
        public async Task<ListGroupPermissionResourcesResponse> ListGroupPermissionResourcesAsync(ListGroupPermissionResourcesRequest listGroupPermissionResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/permissions/resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupPermissionResourcesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGroupPermissionResourcesResponse>(response);
        }

        public AsyncInvoker<ListGroupPermissionResourcesResponse> ListGroupPermissionResourcesAsyncInvoker(ListGroupPermissionResourcesRequest listGroupPermissionResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/permissions/resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupPermissionResourcesRequest);
            return new AsyncInvoker<ListGroupPermissionResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGroupPermissionResourcesResponse>);
        }
        
        /// <summary>
        /// 获取代码组下的子代码组和仓库列表
        ///
        /// 获取代码组下的子代码组和仓库列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGroupSubgroupsAndRepositoriesResponse> ListGroupSubgroupsAndRepositoriesAsync(ListGroupSubgroupsAndRepositoriesRequest listGroupSubgroupsAndRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupSubgroupsAndRepositoriesRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/subgroups-and-repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupSubgroupsAndRepositoriesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listGroupSubgroupsAndRepositoriesResponse = JsonUtils.DeSerializeNull<ListGroupSubgroupsAndRepositoriesResponse>(response);
            listGroupSubgroupsAndRepositoriesResponse.Body = JsonUtils.DeSerializeList<SubgroupAndProjectBaseDto>(response);
            return listGroupSubgroupsAndRepositoriesResponse;
        }

        public AsyncInvoker<ListGroupSubgroupsAndRepositoriesResponse> ListGroupSubgroupsAndRepositoriesAsyncInvoker(ListGroupSubgroupsAndRepositoriesRequest listGroupSubgroupsAndRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupSubgroupsAndRepositoriesRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/subgroups-and-repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupSubgroupsAndRepositoriesRequest);
            return new AsyncInvoker<ListGroupSubgroupsAndRepositoriesResponse>(this, "GET", request, response =>
            {
                var listGroupSubgroupsAndRepositoriesResponse = JsonUtils.DeSerializeNull<ListGroupSubgroupsAndRepositoriesResponse>(response);
                listGroupSubgroupsAndRepositoriesResponse.Body = JsonUtils.DeSerializeList<SubgroupAndProjectBaseDto>(response);
                return listGroupSubgroupsAndRepositoriesResponse;
            });
        }
        
        /// <summary>
        /// 获取代码组列表
        ///
        /// 获取代码组列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest listGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listGroupsResponse = JsonUtils.DeSerializeNull<ListGroupsResponse>(response);
            listGroupsResponse.Body = JsonUtils.DeSerializeList<GroupBaseDto>(response);
            return listGroupsResponse;
        }

        public AsyncInvoker<ListGroupsResponse> ListGroupsAsyncInvoker(ListGroupsRequest listGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupsRequest);
            return new AsyncInvoker<ListGroupsResponse>(this, "GET", request, response =>
            {
                var listGroupsResponse = JsonUtils.DeSerializeNull<ListGroupsResponse>(response);
                listGroupsResponse.Body = JsonUtils.DeSerializeList<GroupBaseDto>(response);
                return listGroupsResponse;
            });
        }
        
        /// <summary>
        /// 获取用户的个人访问令牌
        ///
        /// 获取用户的个人访问令牌
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListImpersonationTokensResponse> ListImpersonationTokensAsync(ListImpersonationTokensRequest listImpersonationTokensRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listImpersonationTokensRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/users/impersonation-tokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImpersonationTokensRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listImpersonationTokensResponse = JsonUtils.DeSerializeNull<ListImpersonationTokensResponse>(response);
            listImpersonationTokensResponse.Body = JsonUtils.DeSerializeList<ImpersonationToken>(response);
            return listImpersonationTokensResponse;
        }

        public AsyncInvoker<ListImpersonationTokensResponse> ListImpersonationTokensAsyncInvoker(ListImpersonationTokensRequest listImpersonationTokensRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listImpersonationTokensRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/users/impersonation-tokens", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImpersonationTokensRequest);
            return new AsyncInvoker<ListImpersonationTokensResponse>(this, "GET", request, response =>
            {
                var listImpersonationTokensResponse = JsonUtils.DeSerializeNull<ListImpersonationTokensResponse>(response);
                listImpersonationTokensResponse.Body = JsonUtils.DeSerializeList<ImpersonationToken>(response);
                return listImpersonationTokensResponse;
            });
        }
        
        /// <summary>
        /// 获取项目下成员列表
        ///
        /// 获取项目下成员列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProductPermissionResourcesGrantedUsersResponse> ListProductPermissionResourcesGrantedUsersAsync(ListProductPermissionResourcesGrantedUsersRequest listProductPermissionResourcesGrantedUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProductPermissionResourcesGrantedUsersRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProductPermissionResourcesGrantedUsersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listProductPermissionResourcesGrantedUsersResponse = JsonUtils.DeSerializeNull<ListProductPermissionResourcesGrantedUsersResponse>(response);
            listProductPermissionResourcesGrantedUsersResponse.Body = JsonUtils.DeSerializeList<GrantedUsersDto>(response);
            return listProductPermissionResourcesGrantedUsersResponse;
        }

        public AsyncInvoker<ListProductPermissionResourcesGrantedUsersResponse> ListProductPermissionResourcesGrantedUsersAsyncInvoker(ListProductPermissionResourcesGrantedUsersRequest listProductPermissionResourcesGrantedUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProductPermissionResourcesGrantedUsersRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProductPermissionResourcesGrantedUsersRequest);
            return new AsyncInvoker<ListProductPermissionResourcesGrantedUsersResponse>(this, "GET", request, response =>
            {
                var listProductPermissionResourcesGrantedUsersResponse = JsonUtils.DeSerializeNull<ListProductPermissionResourcesGrantedUsersResponse>(response);
                listProductPermissionResourcesGrantedUsersResponse.Body = JsonUtils.DeSerializeList<GrantedUsersDto>(response);
                return listProductPermissionResourcesGrantedUsersResponse;
            });
        }
        
        /// <summary>
        /// 获取项目下的代码组和仓库列表
        ///
        /// 获取项目下的代码组和仓库列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProjectSubgroupsAndRepositoriesResponse> ListProjectSubgroupsAndRepositoriesAsync(ListProjectSubgroupsAndRepositoriesRequest listProjectSubgroupsAndRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectSubgroupsAndRepositoriesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/subgroups-and-repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectSubgroupsAndRepositoriesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listProjectSubgroupsAndRepositoriesResponse = JsonUtils.DeSerializeNull<ListProjectSubgroupsAndRepositoriesResponse>(response);
            listProjectSubgroupsAndRepositoriesResponse.Body = JsonUtils.DeSerializeList<SubgroupAndProjectBaseDto>(response);
            return listProjectSubgroupsAndRepositoriesResponse;
        }

        public AsyncInvoker<ListProjectSubgroupsAndRepositoriesResponse> ListProjectSubgroupsAndRepositoriesAsyncInvoker(ListProjectSubgroupsAndRepositoriesRequest listProjectSubgroupsAndRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectSubgroupsAndRepositoriesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/subgroups-and-repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectSubgroupsAndRepositoriesRequest);
            return new AsyncInvoker<ListProjectSubgroupsAndRepositoriesResponse>(this, "GET", request, response =>
            {
                var listProjectSubgroupsAndRepositoriesResponse = JsonUtils.DeSerializeNull<ListProjectSubgroupsAndRepositoriesResponse>(response);
                listProjectSubgroupsAndRepositoriesResponse.Body = JsonUtils.DeSerializeList<SubgroupAndProjectBaseDto>(response);
                return listProjectSubgroupsAndRepositoriesResponse;
            });
        }
        
        /// <summary>
        /// 获取代码组信息
        ///
        /// 获取代码组信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowGroupResponse> ShowGroupAsync(ShowGroupRequest showGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowGroupResponse>(response);
        }

        public AsyncInvoker<ShowGroupResponse> ShowGroupAsyncInvoker(ShowGroupRequest showGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupRequest);
            return new AsyncInvoker<ShowGroupResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGroupResponse>);
        }
        
        /// <summary>
        /// 获取指定代码组的基本设置信息
        ///
        /// 获取指定代码组的基本设置信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowGroupGeneralPolicyResponse> ShowGroupGeneralPolicyAsync(ShowGroupGeneralPolicyRequest showGroupGeneralPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupGeneralPolicyRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/policies/general", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupGeneralPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowGroupGeneralPolicyResponse>(response);
        }

        public AsyncInvoker<ShowGroupGeneralPolicyResponse> ShowGroupGeneralPolicyAsyncInvoker(ShowGroupGeneralPolicyRequest showGroupGeneralPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupGeneralPolicyRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/policies/general", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupGeneralPolicyRequest);
            return new AsyncInvoker<ShowGroupGeneralPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGroupGeneralPolicyResponse>);
        }
        
        /// <summary>
        /// 获取代码组继承权限设置开关
        ///
        /// 获取代码组继承权限设置开关
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowGroupPermissionInheritEnabledResponse> ShowGroupPermissionInheritEnabledAsync(ShowGroupPermissionInheritEnabledRequest showGroupPermissionInheritEnabledRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupPermissionInheritEnabledRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/permission-inherit-enabled", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupPermissionInheritEnabledRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowGroupPermissionInheritEnabledResponse>(response);
        }

        public AsyncInvoker<ShowGroupPermissionInheritEnabledResponse> ShowGroupPermissionInheritEnabledAsyncInvoker(ShowGroupPermissionInheritEnabledRequest showGroupPermissionInheritEnabledRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupPermissionInheritEnabledRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/permission-inherit-enabled", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupPermissionInheritEnabledRequest);
            return new AsyncInvoker<ShowGroupPermissionInheritEnabledResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGroupPermissionInheritEnabledResponse>);
        }
        
        /// <summary>
        /// 获取代码组继承设置项
        ///
        /// 获取代码组继承设置项
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowGroupSettingsInheritCfgResponse> ShowGroupSettingsInheritCfgAsync(ShowGroupSettingsInheritCfgRequest showGroupSettingsInheritCfgRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupSettingsInheritCfgRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/settings-inherit-cfg", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupSettingsInheritCfgRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowGroupSettingsInheritCfgResponse>(response);
        }

        public AsyncInvoker<ShowGroupSettingsInheritCfgResponse> ShowGroupSettingsInheritCfgAsyncInvoker(ShowGroupSettingsInheritCfgRequest showGroupSettingsInheritCfgRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupSettingsInheritCfgRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/settings-inherit-cfg", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupSettingsInheritCfgRequest);
            return new AsyncInvoker<ShowGroupSettingsInheritCfgResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGroupSettingsInheritCfgResponse>);
        }
        
        /// <summary>
        /// 获取代码组水印设置
        ///
        /// 获取代码组水印设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowGroupWatermarkResponse> ShowGroupWatermarkAsync(ShowGroupWatermarkRequest showGroupWatermarkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupWatermarkRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupWatermarkRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowGroupWatermarkResponse>(response);
        }

        public AsyncInvoker<ShowGroupWatermarkResponse> ShowGroupWatermarkAsyncInvoker(ShowGroupWatermarkRequest showGroupWatermarkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupWatermarkRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupWatermarkRequest);
            return new AsyncInvoker<ShowGroupWatermarkResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGroupWatermarkResponse>);
        }
        
        /// <summary>
        /// 获取代码组的继承设置
        ///
        /// 获取代码组的继承设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowGroupsInheritResponse> ShowGroupsInheritAsync(ShowGroupsInheritRequest showGroupsInheritRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupsInheritRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/inherit", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupsInheritRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowGroupsInheritResponse>(response);
        }

        public AsyncInvoker<ShowGroupsInheritResponse> ShowGroupsInheritAsyncInvoker(ShowGroupsInheritRequest showGroupsInheritRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupsInheritRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/inherit", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupsInheritRequest);
            return new AsyncInvoker<ShowGroupsInheritResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGroupsInheritResponse>);
        }
        
        /// <summary>
        /// 获取指定项目的基本设置信息
        ///
        /// 获取指定项目的基本设置信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowProjectGeneralPolicyResponse> ShowProjectGeneralPolicyAsync(ShowProjectGeneralPolicyRequest showProjectGeneralPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectGeneralPolicyRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/policies/general", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectGeneralPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectGeneralPolicyResponse>(response);
        }

        public AsyncInvoker<ShowProjectGeneralPolicyResponse> ShowProjectGeneralPolicyAsyncInvoker(ShowProjectGeneralPolicyRequest showProjectGeneralPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectGeneralPolicyRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/policies/general", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectGeneralPolicyRequest);
            return new AsyncInvoker<ShowProjectGeneralPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectGeneralPolicyResponse>);
        }
        
        /// <summary>
        /// 获取项目成员设置
        ///
        /// 获取项目成员设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowProjectMemberSettingResponse> ShowProjectMemberSettingAsync(ShowProjectMemberSettingRequest showProjectMemberSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectMemberSettingRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/member-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectMemberSettingRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectMemberSettingResponse>(response);
        }

        public AsyncInvoker<ShowProjectMemberSettingResponse> ShowProjectMemberSettingAsyncInvoker(ShowProjectMemberSettingRequest showProjectMemberSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectMemberSettingRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/member-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectMemberSettingRequest);
            return new AsyncInvoker<ShowProjectMemberSettingResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectMemberSettingResponse>);
        }
        
        /// <summary>
        /// 获取资源点对应的角色和权限
        ///
        /// 获取资源点对应的角色和权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowResourcePermissionsResponse> ShowResourcePermissionsAsync(ShowResourcePermissionsRequest showResourcePermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourcePermissionsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(showResourcePermissionsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/permissions-resources/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourcePermissionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var showResourcePermissionsResponse = JsonUtils.DeSerializeNull<ShowResourcePermissionsResponse>(response);
            showResourcePermissionsResponse.Body = JsonUtils.DeSerializeList<PermissionDto>(response);
            return showResourcePermissionsResponse;
        }

        public AsyncInvoker<ShowResourcePermissionsResponse> ShowResourcePermissionsAsyncInvoker(ShowResourcePermissionsRequest showResourcePermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourcePermissionsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(showResourcePermissionsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/permissions-resources/{resource_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourcePermissionsRequest);
            return new AsyncInvoker<ShowResourcePermissionsResponse>(this, "GET", request, response =>
            {
                var showResourcePermissionsResponse = JsonUtils.DeSerializeNull<ShowResourcePermissionsResponse>(response);
                showResourcePermissionsResponse.Body = JsonUtils.DeSerializeList<PermissionDto>(response);
                return showResourcePermissionsResponse;
            });
        }
        
        /// <summary>
        /// 移交代码组
        ///
        /// 移交代码组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<TransferGroupResponse> TransferGroupAsync(TransferGroupRequest transferGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(transferGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/transfer", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", transferGroupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<TransferGroupResponse>(response);
        }

        public AsyncInvoker<TransferGroupResponse> TransferGroupAsyncInvoker(TransferGroupRequest transferGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(transferGroupRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/transfer", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", transferGroupRequest);
            return new AsyncInvoker<TransferGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<TransferGroupResponse>);
        }
        
        /// <summary>
        /// 更新代码组水印设置
        ///
        /// 更新代码组水印设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateGroupWatermarkResponse> UpdateGroupWatermarkAsync(UpdateGroupWatermarkRequest updateGroupWatermarkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateGroupWatermarkRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGroupWatermarkRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGroupWatermarkResponse>(response);
        }

        public AsyncInvoker<UpdateGroupWatermarkResponse> UpdateGroupWatermarkAsyncInvoker(UpdateGroupWatermarkRequest updateGroupWatermarkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateGroupWatermarkRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGroupWatermarkRequest);
            return new AsyncInvoker<UpdateGroupWatermarkResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGroupWatermarkResponse>);
        }
        
        /// <summary>
        /// 创建仓库标签
        ///
        /// 创建仓库标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRepositoryLabelResponse> CreateRepositoryLabelAsync(CreateRepositoryLabelRequest createRepositoryLabelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRepositoryLabelRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/labels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepositoryLabelRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateRepositoryLabelResponse>(response);
        }

        public AsyncInvoker<CreateRepositoryLabelResponse> CreateRepositoryLabelAsyncInvoker(CreateRepositoryLabelRequest createRepositoryLabelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRepositoryLabelRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/labels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepositoryLabelRequest);
            return new AsyncInvoker<CreateRepositoryLabelResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRepositoryLabelResponse>);
        }
        
        /// <summary>
        /// 创建仓库系统标签
        ///
        /// 创建仓库系统标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRepositorySystemLabelsResponse> CreateRepositorySystemLabelsAsync(CreateRepositorySystemLabelsRequest createRepositorySystemLabelsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRepositorySystemLabelsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/system-labels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepositorySystemLabelsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            var createRepositorySystemLabelsResponse = JsonUtils.DeSerializeNull<CreateRepositorySystemLabelsResponse>(response);
            createRepositorySystemLabelsResponse.Body = JsonUtils.DeSerializeList<LabelDetailDto>(response);
            return createRepositorySystemLabelsResponse;
        }

        public AsyncInvoker<CreateRepositorySystemLabelsResponse> CreateRepositorySystemLabelsAsyncInvoker(CreateRepositorySystemLabelsRequest createRepositorySystemLabelsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRepositorySystemLabelsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/system-labels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRepositorySystemLabelsRequest);
            return new AsyncInvoker<CreateRepositorySystemLabelsResponse>(this, "POST", request, response =>
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
        public async Task<DeleteRepositoryLabelResponse> DeleteRepositoryLabelAsync(DeleteRepositoryLabelRequest deleteRepositoryLabelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRepositoryLabelRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/label", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepositoryLabelRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRepositoryLabelResponse>(response);
        }

        public AsyncInvoker<DeleteRepositoryLabelResponse> DeleteRepositoryLabelAsyncInvoker(DeleteRepositoryLabelRequest deleteRepositoryLabelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRepositoryLabelRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/label", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRepositoryLabelRequest);
            return new AsyncInvoker<DeleteRepositoryLabelResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRepositoryLabelResponse>);
        }
        
        /// <summary>
        /// 获取仓库标签列表
        ///
        /// 获取仓库标签列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRepositoryLabelsResponse> ListRepositoryLabelsAsync(ListRepositoryLabelsRequest listRepositoryLabelsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryLabelsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/labels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryLabelsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listRepositoryLabelsResponse = JsonUtils.DeSerializeNull<ListRepositoryLabelsResponse>(response);
            listRepositoryLabelsResponse.Body = JsonUtils.DeSerializeList<LabelBasicDto>(response);
            return listRepositoryLabelsResponse;
        }

        public AsyncInvoker<ListRepositoryLabelsResponse> ListRepositoryLabelsAsyncInvoker(ListRepositoryLabelsRequest listRepositoryLabelsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryLabelsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/labels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryLabelsRequest);
            return new AsyncInvoker<ListRepositoryLabelsResponse>(this, "GET", request, response =>
            {
                var listRepositoryLabelsResponse = JsonUtils.DeSerializeNull<ListRepositoryLabelsResponse>(response);
                listRepositoryLabelsResponse.Body = JsonUtils.DeSerializeList<LabelBasicDto>(response);
                return listRepositoryLabelsResponse;
            });
        }
        
        /// <summary>
        /// 修改仓库标签
        ///
        /// 修改仓库标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRepositoryLabelResponse> UpdateRepositoryLabelAsync(UpdateRepositoryLabelRequest updateRepositoryLabelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryLabelRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/label", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepositoryLabelRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRepositoryLabelResponse>(response);
        }

        public AsyncInvoker<UpdateRepositoryLabelResponse> UpdateRepositoryLabelAsyncInvoker(UpdateRepositoryLabelRequest updateRepositoryLabelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryLabelRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/label", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepositoryLabelRequest);
            return new AsyncInvoker<UpdateRepositoryLabelResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRepositoryLabelResponse>);
        }
        
        /// <summary>
        /// 批量添加仓库成员
        ///
        /// 批量添加仓库成员
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddRepositoryMembersResponse> AddRepositoryMembersAsync(AddRepositoryMembersRequest addRepositoryMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addRepositoryMembersRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addRepositoryMembersRequest);
            var response = await DoHttpRequestAsync("POST", request);
            var addRepositoryMembersResponse = JsonUtils.DeSerializeNull<AddRepositoryMembersResponse>(response);
            addRepositoryMembersResponse.Body = JsonUtils.DeSerializeList<BatchCreateRepositoryMemberDto>(response);
            return addRepositoryMembersResponse;
        }

        public AsyncInvoker<AddRepositoryMembersResponse> AddRepositoryMembersAsyncInvoker(AddRepositoryMembersRequest addRepositoryMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addRepositoryMembersRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addRepositoryMembersRequest);
            return new AsyncInvoker<AddRepositoryMembersResponse>(this, "POST", request, response =>
            {
                var addRepositoryMembersResponse = JsonUtils.DeSerializeNull<AddRepositoryMembersResponse>(response);
                addRepositoryMembersResponse.Body = JsonUtils.DeSerializeList<BatchCreateRepositoryMemberDto>(response);
                return addRepositoryMembersResponse;
            });
        }
        
        /// <summary>
        /// 获取仓库成员列表
        ///
        /// 获取仓库成员列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMembersResponse> ListMembersAsync(ListMembersRequest listMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMembersRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMembersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listMembersResponse = JsonUtils.DeSerializeNull<ListMembersResponse>(response);
            listMembersResponse.Body = JsonUtils.DeSerializeList<RepositoryMemberDto>(response);
            return listMembersResponse;
        }

        public AsyncInvoker<ListMembersResponse> ListMembersAsyncInvoker(ListMembersRequest listMembersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMembersRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/members", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMembersRequest);
            return new AsyncInvoker<ListMembersResponse>(this, "GET", request, response =>
            {
                var listMembersResponse = JsonUtils.DeSerializeNull<ListMembersResponse>(response);
                listMembersResponse.Body = JsonUtils.DeSerializeList<RepositoryMemberDto>(response);
                return listMembersResponse;
            });
        }
        
        /// <summary>
        /// 获取成员组列表
        ///
        /// 获取成员组列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRepositoryUserGroupsResponse> ListRepositoryUserGroupsAsync(ListRepositoryUserGroupsRequest listRepositoryUserGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryUserGroupsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/user-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryUserGroupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listRepositoryUserGroupsResponse = JsonUtils.DeSerializeNull<ListRepositoryUserGroupsResponse>(response);
            listRepositoryUserGroupsResponse.Body = JsonUtils.DeSerializeList<RepositoryUserGroupDto>(response);
            return listRepositoryUserGroupsResponse;
        }

        public AsyncInvoker<ListRepositoryUserGroupsResponse> ListRepositoryUserGroupsAsyncInvoker(ListRepositoryUserGroupsRequest listRepositoryUserGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryUserGroupsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/user-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryUserGroupsRequest);
            return new AsyncInvoker<ListRepositoryUserGroupsResponse>(this, "GET", request, response =>
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
        public async Task<ApprovalMergeRequestResponse> ApprovalMergeRequestAsync(ApprovalMergeRequestRequest approvalMergeRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(approvalMergeRequestRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(approvalMergeRequestRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/approval", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", approvalMergeRequestRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            var approvalMergeRequestResponse = JsonUtils.DeSerializeNull<ApprovalMergeRequestResponse>(response);
            approvalMergeRequestResponse.Body = JsonUtils.DeSerializeList<ApproverBasicDto>(response);
            return approvalMergeRequestResponse;
        }

        public AsyncInvoker<ApprovalMergeRequestResponse> ApprovalMergeRequestAsyncInvoker(ApprovalMergeRequestRequest approvalMergeRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(approvalMergeRequestRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(approvalMergeRequestRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/approval", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", approvalMergeRequestRequest);
            return new AsyncInvoker<ApprovalMergeRequestResponse>(this, "PUT", request, response =>
            {
                var approvalMergeRequestResponse = JsonUtils.DeSerializeNull<ApprovalMergeRequestResponse>(response);
                approvalMergeRequestResponse.Body = JsonUtils.DeSerializeList<ApproverBasicDto>(response);
                return approvalMergeRequestResponse;
            });
        }
        
        /// <summary>
        /// 创建代码组合并请求审核设置
        ///
        /// 创建代码组合并请求审核设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateGroupMergeRequestApproverSettingResponse> CreateGroupMergeRequestApproverSettingAsync(CreateGroupMergeRequestApproverSettingRequest createGroupMergeRequestApproverSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createGroupMergeRequestApproverSettingRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/approver-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGroupMergeRequestApproverSettingRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateGroupMergeRequestApproverSettingResponse>(response);
        }

        public AsyncInvoker<CreateGroupMergeRequestApproverSettingResponse> CreateGroupMergeRequestApproverSettingAsyncInvoker(CreateGroupMergeRequestApproverSettingRequest createGroupMergeRequestApproverSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createGroupMergeRequestApproverSettingRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/approver-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createGroupMergeRequestApproverSettingRequest);
            return new AsyncInvoker<CreateGroupMergeRequestApproverSettingResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateGroupMergeRequestApproverSettingResponse>);
        }
        
        /// <summary>
        /// 创建合并请求
        ///
        /// 创建合并请求
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateMergeRequestResponse> CreateMergeRequestAsync(CreateMergeRequestRequest createMergeRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMergeRequestRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateMergeRequestResponse>(response);
        }

        public AsyncInvoker<CreateMergeRequestResponse> CreateMergeRequestAsyncInvoker(CreateMergeRequestRequest createMergeRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMergeRequestRequest);
            return new AsyncInvoker<CreateMergeRequestResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMergeRequestResponse>);
        }
        
        /// <summary>
        /// 创建合并请求审核设置
        ///
        /// 创建合并请求审核设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateMergeRequestApproverSettingResponse> CreateMergeRequestApproverSettingAsync(CreateMergeRequestApproverSettingRequest createMergeRequestApproverSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestApproverSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/approver-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMergeRequestApproverSettingRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateMergeRequestApproverSettingResponse>(response);
        }

        public AsyncInvoker<CreateMergeRequestApproverSettingResponse> CreateMergeRequestApproverSettingAsyncInvoker(CreateMergeRequestApproverSettingRequest createMergeRequestApproverSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestApproverSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/approver-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMergeRequestApproverSettingRequest);
            return new AsyncInvoker<CreateMergeRequestApproverSettingResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMergeRequestApproverSettingResponse>);
        }
        
        /// <summary>
        /// 创建合并请求模板
        ///
        /// 创建合并请求模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateMergeRequestTemplateResponse> CreateMergeRequestTemplateAsync(CreateMergeRequestTemplateRequest createMergeRequestTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestTemplateRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMergeRequestTemplateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateMergeRequestTemplateResponse>(response);
        }

        public AsyncInvoker<CreateMergeRequestTemplateResponse> CreateMergeRequestTemplateAsyncInvoker(CreateMergeRequestTemplateRequest createMergeRequestTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMergeRequestTemplateRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMergeRequestTemplateRequest);
            return new AsyncInvoker<CreateMergeRequestTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMergeRequestTemplateResponse>);
        }
        
        /// <summary>
        /// 创建项目合并请求审核设置
        ///
        /// 创建项目合并请求审核设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateProjectMergeRequestApproverSettingResponse> CreateProjectMergeRequestApproverSettingAsync(CreateProjectMergeRequestApproverSettingRequest createProjectMergeRequestApproverSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createProjectMergeRequestApproverSettingRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/approver-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProjectMergeRequestApproverSettingRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateProjectMergeRequestApproverSettingResponse>(response);
        }

        public AsyncInvoker<CreateProjectMergeRequestApproverSettingResponse> CreateProjectMergeRequestApproverSettingAsyncInvoker(CreateProjectMergeRequestApproverSettingRequest createProjectMergeRequestApproverSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createProjectMergeRequestApproverSettingRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/approver-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProjectMergeRequestApproverSettingRequest);
            return new AsyncInvoker<CreateProjectMergeRequestApproverSettingResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateProjectMergeRequestApproverSettingResponse>);
        }
        
        /// <summary>
        /// 删除代码组合并请求审核配置
        ///
        /// 删除代码组合并请求审核配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteGroupMergeRequestApproverSettingResponse> DeleteGroupMergeRequestApproverSettingAsync(DeleteGroupMergeRequestApproverSettingRequest deleteGroupMergeRequestApproverSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupMergeRequestApproverSettingRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupMergeRequestApproverSettingRequest.SettingId, out var valueOfSettingId)) urlParam.Add("setting_id", valueOfSettingId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/approver-settings/{setting_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGroupMergeRequestApproverSettingRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteGroupMergeRequestApproverSettingResponse>(response);
        }

        public AsyncInvoker<DeleteGroupMergeRequestApproverSettingResponse> DeleteGroupMergeRequestApproverSettingAsyncInvoker(DeleteGroupMergeRequestApproverSettingRequest deleteGroupMergeRequestApproverSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupMergeRequestApproverSettingRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(deleteGroupMergeRequestApproverSettingRequest.SettingId, out var valueOfSettingId)) urlParam.Add("setting_id", valueOfSettingId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/approver-settings/{setting_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteGroupMergeRequestApproverSettingRequest);
            return new AsyncInvoker<DeleteGroupMergeRequestApproverSettingResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteGroupMergeRequestApproverSettingResponse>);
        }
        
        /// <summary>
        /// 删除合并请求审核配置
        ///
        /// 删除合并请求审核配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteMergeRequestApproverSettingResponse> DeleteMergeRequestApproverSettingAsync(DeleteMergeRequestApproverSettingRequest deleteMergeRequestApproverSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteMergeRequestApproverSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(deleteMergeRequestApproverSettingRequest.SettingId, out var valueOfSettingId)) urlParam.Add("setting_id", valueOfSettingId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/approver-settings/{setting_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMergeRequestApproverSettingRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteMergeRequestApproverSettingResponse>(response);
        }

        public AsyncInvoker<DeleteMergeRequestApproverSettingResponse> DeleteMergeRequestApproverSettingAsyncInvoker(DeleteMergeRequestApproverSettingRequest deleteMergeRequestApproverSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteMergeRequestApproverSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(deleteMergeRequestApproverSettingRequest.SettingId, out var valueOfSettingId)) urlParam.Add("setting_id", valueOfSettingId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/approver-settings/{setting_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMergeRequestApproverSettingRequest);
            return new AsyncInvoker<DeleteMergeRequestApproverSettingResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteMergeRequestApproverSettingResponse>);
        }
        
        /// <summary>
        /// 删除合并请求模板
        ///
        /// 删除合并请求模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteMergeRequestTemplateResponse> DeleteMergeRequestTemplateAsync(DeleteMergeRequestTemplateRequest deleteMergeRequestTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteMergeRequestTemplateRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(deleteMergeRequestTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/template/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMergeRequestTemplateRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteMergeRequestTemplateResponse>(response);
        }

        public AsyncInvoker<DeleteMergeRequestTemplateResponse> DeleteMergeRequestTemplateAsyncInvoker(DeleteMergeRequestTemplateRequest deleteMergeRequestTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteMergeRequestTemplateRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(deleteMergeRequestTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/template/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMergeRequestTemplateRequest);
            return new AsyncInvoker<DeleteMergeRequestTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteMergeRequestTemplateResponse>);
        }
        
        /// <summary>
        /// 删除合并请求打分
        ///
        /// 删除合并请求打分
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteMergeRequestVoteResponse> DeleteMergeRequestVoteAsync(DeleteMergeRequestVoteRequest deleteMergeRequestVoteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteMergeRequestVoteRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(deleteMergeRequestVoteRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/vote", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMergeRequestVoteRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteMergeRequestVoteResponse>(response);
        }

        public AsyncInvoker<DeleteMergeRequestVoteResponse> DeleteMergeRequestVoteAsyncInvoker(DeleteMergeRequestVoteRequest deleteMergeRequestVoteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteMergeRequestVoteRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(deleteMergeRequestVoteRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/vote", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMergeRequestVoteRequest);
            return new AsyncInvoker<DeleteMergeRequestVoteResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteMergeRequestVoteResponse>);
        }
        
        /// <summary>
        /// 删除项目合并请求审核配置
        ///
        /// 删除项目合并请求审核配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteProjectMergeRequestApproverSettingResponse> DeleteProjectMergeRequestApproverSettingAsync(DeleteProjectMergeRequestApproverSettingRequest deleteProjectMergeRequestApproverSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteProjectMergeRequestApproverSettingRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deleteProjectMergeRequestApproverSettingRequest.SettingId, out var valueOfSettingId)) urlParam.Add("setting_id", valueOfSettingId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/approver-settings/{setting_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProjectMergeRequestApproverSettingRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteProjectMergeRequestApproverSettingResponse>(response);
        }

        public AsyncInvoker<DeleteProjectMergeRequestApproverSettingResponse> DeleteProjectMergeRequestApproverSettingAsyncInvoker(DeleteProjectMergeRequestApproverSettingRequest deleteProjectMergeRequestApproverSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteProjectMergeRequestApproverSettingRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deleteProjectMergeRequestApproverSettingRequest.SettingId, out var valueOfSettingId)) urlParam.Add("setting_id", valueOfSettingId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/approver-settings/{setting_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProjectMergeRequestApproverSettingRequest);
            return new AsyncInvoker<DeleteProjectMergeRequestApproverSettingResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteProjectMergeRequestApproverSettingResponse>);
        }
        
        /// <summary>
        /// 导入合并请求
        ///
        /// 导入合并请求
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ImportMergeRequestResponse> ImportMergeRequestAsync(ImportMergeRequestRequest importMergeRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(importMergeRequestRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/import-merge-requests", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", importMergeRequestRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ImportMergeRequestResponse>(response);
        }

        public AsyncInvoker<ImportMergeRequestResponse> ImportMergeRequestAsyncInvoker(ImportMergeRequestRequest importMergeRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(importMergeRequestRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/import-merge-requests", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", importMergeRequestRequest);
            return new AsyncInvoker<ImportMergeRequestResponse>(this, "POST", request, JsonUtils.DeSerialize<ImportMergeRequestResponse>);
        }
        
        /// <summary>
        /// 获取检视意见模板列表
        ///
        /// 获取检视意见模板列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDiscussionTemplatesResponse> ListDiscussionTemplatesAsync(ListDiscussionTemplatesRequest listDiscussionTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDiscussionTemplatesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/discussion/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDiscussionTemplatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listDiscussionTemplatesResponse = JsonUtils.DeSerializeNull<ListDiscussionTemplatesResponse>(response);
            listDiscussionTemplatesResponse.Body = JsonUtils.DeSerializeList<DiscussionTemplateDto>(response);
            return listDiscussionTemplatesResponse;
        }

        public AsyncInvoker<ListDiscussionTemplatesResponse> ListDiscussionTemplatesAsyncInvoker(ListDiscussionTemplatesRequest listDiscussionTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDiscussionTemplatesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/discussion/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDiscussionTemplatesRequest);
            return new AsyncInvoker<ListDiscussionTemplatesResponse>(this, "GET", request, response =>
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
        public async Task<ListGroupMergeRequestApproverSettingsResponse> ListGroupMergeRequestApproverSettingsAsync(ListGroupMergeRequestApproverSettingsRequest listGroupMergeRequestApproverSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupMergeRequestApproverSettingsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/approver-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupMergeRequestApproverSettingsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listGroupMergeRequestApproverSettingsResponse = JsonUtils.DeSerializeNull<ListGroupMergeRequestApproverSettingsResponse>(response);
            listGroupMergeRequestApproverSettingsResponse.Body = JsonUtils.DeSerializeList<MergeRequestApproverSettingResultDto>(response);
            return listGroupMergeRequestApproverSettingsResponse;
        }

        public AsyncInvoker<ListGroupMergeRequestApproverSettingsResponse> ListGroupMergeRequestApproverSettingsAsyncInvoker(ListGroupMergeRequestApproverSettingsRequest listGroupMergeRequestApproverSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupMergeRequestApproverSettingsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/approver-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupMergeRequestApproverSettingsRequest);
            return new AsyncInvoker<ListGroupMergeRequestApproverSettingsResponse>(this, "GET", request, response =>
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
        public async Task<ListGroupMergeRequestCanBeAssignedReviewersResponse> ListGroupMergeRequestCanBeAssignedReviewersAsync(ListGroupMergeRequestCanBeAssignedReviewersRequest listGroupMergeRequestCanBeAssignedReviewersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupMergeRequestCanBeAssignedReviewersRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/merge-requests/reviewers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupMergeRequestCanBeAssignedReviewersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGroupMergeRequestCanBeAssignedReviewersResponse>(response);
        }

        public AsyncInvoker<ListGroupMergeRequestCanBeAssignedReviewersResponse> ListGroupMergeRequestCanBeAssignedReviewersAsyncInvoker(ListGroupMergeRequestCanBeAssignedReviewersRequest listGroupMergeRequestCanBeAssignedReviewersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupMergeRequestCanBeAssignedReviewersRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/merge-requests/reviewers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupMergeRequestCanBeAssignedReviewersRequest);
            return new AsyncInvoker<ListGroupMergeRequestCanBeAssignedReviewersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGroupMergeRequestCanBeAssignedReviewersResponse>);
        }
        
        /// <summary>
        /// 获取代码组审核人或合并人
        ///
        /// 获取代码组审核人或合并人
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGroupMergeRequestValidAssignedCandidatesResponse> ListGroupMergeRequestValidAssignedCandidatesAsync(ListGroupMergeRequestValidAssignedCandidatesRequest listGroupMergeRequestValidAssignedCandidatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupMergeRequestValidAssignedCandidatesRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/merge-requests/assignee-candidates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupMergeRequestValidAssignedCandidatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listGroupMergeRequestValidAssignedCandidatesResponse = JsonUtils.DeSerializeNull<ListGroupMergeRequestValidAssignedCandidatesResponse>(response);
            listGroupMergeRequestValidAssignedCandidatesResponse.Body = JsonUtils.DeSerializeList<MergeRequestVoteReviewerDto>(response);
            return listGroupMergeRequestValidAssignedCandidatesResponse;
        }

        public AsyncInvoker<ListGroupMergeRequestValidAssignedCandidatesResponse> ListGroupMergeRequestValidAssignedCandidatesAsyncInvoker(ListGroupMergeRequestValidAssignedCandidatesRequest listGroupMergeRequestValidAssignedCandidatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupMergeRequestValidAssignedCandidatesRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/merge-requests/assignee-candidates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupMergeRequestValidAssignedCandidatesRequest);
            return new AsyncInvoker<ListGroupMergeRequestValidAssignedCandidatesResponse>(this, "GET", request, response =>
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
        public async Task<ListMergeRequestApproverSettingsResponse> ListMergeRequestApproverSettingsAsync(ListMergeRequestApproverSettingsRequest listMergeRequestApproverSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestApproverSettingsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/approver-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestApproverSettingsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listMergeRequestApproverSettingsResponse = JsonUtils.DeSerializeNull<ListMergeRequestApproverSettingsResponse>(response);
            listMergeRequestApproverSettingsResponse.Body = JsonUtils.DeSerializeList<MergeRequestApproverSettingResultDto>(response);
            return listMergeRequestApproverSettingsResponse;
        }

        public AsyncInvoker<ListMergeRequestApproverSettingsResponse> ListMergeRequestApproverSettingsAsyncInvoker(ListMergeRequestApproverSettingsRequest listMergeRequestApproverSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestApproverSettingsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/approver-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestApproverSettingsRequest);
            return new AsyncInvoker<ListMergeRequestApproverSettingsResponse>(this, "GET", request, response =>
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
        public async Task<ListMergeRequestApproversResponse> ListMergeRequestApproversAsync(ListMergeRequestApproversRequest listMergeRequestApproversRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestApproversRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/approval-approvers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestApproversRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListMergeRequestApproversResponse>(response);
        }

        public AsyncInvoker<ListMergeRequestApproversResponse> ListMergeRequestApproversAsyncInvoker(ListMergeRequestApproversRequest listMergeRequestApproversRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestApproversRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/approval-approvers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestApproversRequest);
            return new AsyncInvoker<ListMergeRequestApproversResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMergeRequestApproversResponse>);
        }
        
        /// <summary>
        /// 获取合并请求文件变更列表
        ///
        /// 获取合并请求文件变更列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMergeRequestChangesResponse> ListMergeRequestChangesAsync(ListMergeRequestChangesRequest listMergeRequestChangesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestChangesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestChangesRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/changes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestChangesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listMergeRequestChangesResponse = JsonUtils.DeSerializeNull<ListMergeRequestChangesResponse>(response);
            listMergeRequestChangesResponse.Body = JsonUtils.DeSerializeList<SimpleMergeRequestChangesDto>(response);
            return listMergeRequestChangesResponse;
        }

        public AsyncInvoker<ListMergeRequestChangesResponse> ListMergeRequestChangesAsyncInvoker(ListMergeRequestChangesRequest listMergeRequestChangesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestChangesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestChangesRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/changes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestChangesRequest);
            return new AsyncInvoker<ListMergeRequestChangesResponse>(this, "GET", request, response =>
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
        public async Task<ListMergeRequestChangesTreesResponse> ListMergeRequestChangesTreesAsync(ListMergeRequestChangesTreesRequest listMergeRequestChangesTreesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestChangesTreesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestChangesTreesRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/changes-trees", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestChangesTreesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listMergeRequestChangesTreesResponse = JsonUtils.DeSerializeNull<ListMergeRequestChangesTreesResponse>(response);
            listMergeRequestChangesTreesResponse.Body = JsonUtils.DeSerializeList<ChangesTreeDto>(response);
            return listMergeRequestChangesTreesResponse;
        }

        public AsyncInvoker<ListMergeRequestChangesTreesResponse> ListMergeRequestChangesTreesAsyncInvoker(ListMergeRequestChangesTreesRequest listMergeRequestChangesTreesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestChangesTreesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestChangesTreesRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/changes-trees", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestChangesTreesRequest);
            return new AsyncInvoker<ListMergeRequestChangesTreesResponse>(this, "GET", request, response =>
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
        public async Task<ListMergeRequestCommitsResponse> ListMergeRequestCommitsAsync(ListMergeRequestCommitsRequest listMergeRequestCommitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestCommitsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestCommitsRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/commits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestCommitsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listMergeRequestCommitsResponse = JsonUtils.DeSerializeNull<ListMergeRequestCommitsResponse>(response);
            listMergeRequestCommitsResponse.Body = JsonUtils.DeSerializeList<MergeRequestCommitDto>(response);
            return listMergeRequestCommitsResponse;
        }

        public AsyncInvoker<ListMergeRequestCommitsResponse> ListMergeRequestCommitsAsyncInvoker(ListMergeRequestCommitsRequest listMergeRequestCommitsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestCommitsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestCommitsRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/commits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestCommitsRequest);
            return new AsyncInvoker<ListMergeRequestCommitsResponse>(this, "GET", request, response =>
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
        public async Task<ListMergeRequestConflictFilesResponse> ListMergeRequestConflictFilesAsync(ListMergeRequestConflictFilesRequest listMergeRequestConflictFilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestConflictFilesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestConflictFilesRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/conflict-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestConflictFilesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listMergeRequestConflictFilesResponse = JsonUtils.DeSerializeNull<ListMergeRequestConflictFilesResponse>(response);
            listMergeRequestConflictFilesResponse.Body = JsonUtils.DeSerializeList<MRConflictFileDto>(response);
            return listMergeRequestConflictFilesResponse;
        }

        public AsyncInvoker<ListMergeRequestConflictFilesResponse> ListMergeRequestConflictFilesAsyncInvoker(ListMergeRequestConflictFilesRequest listMergeRequestConflictFilesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestConflictFilesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestConflictFilesRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/conflict-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestConflictFilesRequest);
            return new AsyncInvoker<ListMergeRequestConflictFilesResponse>(this, "GET", request, response =>
            {
                var listMergeRequestConflictFilesResponse = JsonUtils.DeSerializeNull<ListMergeRequestConflictFilesResponse>(response);
                listMergeRequestConflictFilesResponse.Body = JsonUtils.DeSerializeList<MRConflictFileDto>(response);
                return listMergeRequestConflictFilesResponse;
            });
        }
        
        /// <summary>
        /// 获取合并请求检视人列表
        ///
        /// 获取合并请求检视人列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMergeRequestReviewersResponse> ListMergeRequestReviewersAsync(ListMergeRequestReviewersRequest listMergeRequestReviewersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestReviewersRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/approval-reviewers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestReviewersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListMergeRequestReviewersResponse>(response);
        }

        public AsyncInvoker<ListMergeRequestReviewersResponse> ListMergeRequestReviewersAsyncInvoker(ListMergeRequestReviewersRequest listMergeRequestReviewersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestReviewersRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/approval-reviewers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestReviewersRequest);
            return new AsyncInvoker<ListMergeRequestReviewersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListMergeRequestReviewersResponse>);
        }
        
        /// <summary>
        /// 获取合并请求模板列表
        ///
        /// 获取合并请求模板列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMergeRequestTemplatesResponse> ListMergeRequestTemplatesAsync(ListMergeRequestTemplatesRequest listMergeRequestTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestTemplatesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestTemplatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listMergeRequestTemplatesResponse = JsonUtils.DeSerializeNull<ListMergeRequestTemplatesResponse>(response);
            listMergeRequestTemplatesResponse.Body = JsonUtils.DeSerializeList<MergeRequestTemplateDto>(response);
            return listMergeRequestTemplatesResponse;
        }

        public AsyncInvoker<ListMergeRequestTemplatesResponse> ListMergeRequestTemplatesAsyncInvoker(ListMergeRequestTemplatesRequest listMergeRequestTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestTemplatesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestTemplatesRequest);
            return new AsyncInvoker<ListMergeRequestTemplatesResponse>(this, "GET", request, response =>
            {
                var listMergeRequestTemplatesResponse = JsonUtils.DeSerializeNull<ListMergeRequestTemplatesResponse>(response);
                listMergeRequestTemplatesResponse.Body = JsonUtils.DeSerializeList<MergeRequestTemplateDto>(response);
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
        public async Task<ListMergeRequestValidAssignedCandidatesResponse> ListMergeRequestValidAssignedCandidatesAsync(ListMergeRequestValidAssignedCandidatesRequest listMergeRequestValidAssignedCandidatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestValidAssignedCandidatesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/assignee-candidates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestValidAssignedCandidatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listMergeRequestValidAssignedCandidatesResponse = JsonUtils.DeSerializeNull<ListMergeRequestValidAssignedCandidatesResponse>(response);
            listMergeRequestValidAssignedCandidatesResponse.Body = JsonUtils.DeSerializeList<MRVoteReviewerDto>(response);
            return listMergeRequestValidAssignedCandidatesResponse;
        }

        public AsyncInvoker<ListMergeRequestValidAssignedCandidatesResponse> ListMergeRequestValidAssignedCandidatesAsyncInvoker(ListMergeRequestValidAssignedCandidatesRequest listMergeRequestValidAssignedCandidatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestValidAssignedCandidatesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/assignee-candidates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestValidAssignedCandidatesRequest);
            return new AsyncInvoker<ListMergeRequestValidAssignedCandidatesResponse>(this, "GET", request, response =>
            {
                var listMergeRequestValidAssignedCandidatesResponse = JsonUtils.DeSerializeNull<ListMergeRequestValidAssignedCandidatesResponse>(response);
                listMergeRequestValidAssignedCandidatesResponse.Body = JsonUtils.DeSerializeList<MRVoteReviewerDto>(response);
                return listMergeRequestValidAssignedCandidatesResponse;
            });
        }
        
        /// <summary>
        /// 获取项目合并请求审核设置列表
        ///
        /// 获取项目合并请求审核设置列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProjectMergeRequestApproverSettingsResponse> ListProjectMergeRequestApproverSettingsAsync(ListProjectMergeRequestApproverSettingsRequest listProjectMergeRequestApproverSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectMergeRequestApproverSettingsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/approver-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectMergeRequestApproverSettingsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listProjectMergeRequestApproverSettingsResponse = JsonUtils.DeSerializeNull<ListProjectMergeRequestApproverSettingsResponse>(response);
            listProjectMergeRequestApproverSettingsResponse.Body = JsonUtils.DeSerializeList<MergeRequestApproverSettingResultDto>(response);
            return listProjectMergeRequestApproverSettingsResponse;
        }

        public AsyncInvoker<ListProjectMergeRequestApproverSettingsResponse> ListProjectMergeRequestApproverSettingsAsyncInvoker(ListProjectMergeRequestApproverSettingsRequest listProjectMergeRequestApproverSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectMergeRequestApproverSettingsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/approver-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectMergeRequestApproverSettingsRequest);
            return new AsyncInvoker<ListProjectMergeRequestApproverSettingsResponse>(this, "GET", request, response =>
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
        public async Task<ListProjectMergeRequestCanBeAssignedReviewersResponse> ListProjectMergeRequestCanBeAssignedReviewersAsync(ListProjectMergeRequestCanBeAssignedReviewersRequest listProjectMergeRequestCanBeAssignedReviewersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectMergeRequestCanBeAssignedReviewersRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/merge-requests/reviewers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectMergeRequestCanBeAssignedReviewersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listProjectMergeRequestCanBeAssignedReviewersResponse = JsonUtils.DeSerializeNull<ListProjectMergeRequestCanBeAssignedReviewersResponse>(response);
            listProjectMergeRequestCanBeAssignedReviewersResponse.Body = JsonUtils.DeSerializeList<MergeRequestVoteReviewerDto>(response);
            return listProjectMergeRequestCanBeAssignedReviewersResponse;
        }

        public AsyncInvoker<ListProjectMergeRequestCanBeAssignedReviewersResponse> ListProjectMergeRequestCanBeAssignedReviewersAsyncInvoker(ListProjectMergeRequestCanBeAssignedReviewersRequest listProjectMergeRequestCanBeAssignedReviewersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectMergeRequestCanBeAssignedReviewersRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/merge-requests/reviewers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectMergeRequestCanBeAssignedReviewersRequest);
            return new AsyncInvoker<ListProjectMergeRequestCanBeAssignedReviewersResponse>(this, "GET", request, response =>
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
        public async Task<ListProjectMergeRequestCanBeAssignedUsersResponse> ListProjectMergeRequestCanBeAssignedUsersAsync(ListProjectMergeRequestCanBeAssignedUsersRequest listProjectMergeRequestCanBeAssignedUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectMergeRequestCanBeAssignedUsersRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/merge-requests/assignee-candidates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectMergeRequestCanBeAssignedUsersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listProjectMergeRequestCanBeAssignedUsersResponse = JsonUtils.DeSerializeNull<ListProjectMergeRequestCanBeAssignedUsersResponse>(response);
            listProjectMergeRequestCanBeAssignedUsersResponse.Body = JsonUtils.DeSerializeList<MergeRequestVoteReviewerDto>(response);
            return listProjectMergeRequestCanBeAssignedUsersResponse;
        }

        public AsyncInvoker<ListProjectMergeRequestCanBeAssignedUsersResponse> ListProjectMergeRequestCanBeAssignedUsersAsyncInvoker(ListProjectMergeRequestCanBeAssignedUsersRequest listProjectMergeRequestCanBeAssignedUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectMergeRequestCanBeAssignedUsersRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/merge-requests/assignee-candidates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectMergeRequestCanBeAssignedUsersRequest);
            return new AsyncInvoker<ListProjectMergeRequestCanBeAssignedUsersResponse>(this, "GET", request, response =>
            {
                var listProjectMergeRequestCanBeAssignedUsersResponse = JsonUtils.DeSerializeNull<ListProjectMergeRequestCanBeAssignedUsersResponse>(response);
                listProjectMergeRequestCanBeAssignedUsersResponse.Body = JsonUtils.DeSerializeList<MergeRequestVoteReviewerDto>(response);
                return listProjectMergeRequestCanBeAssignedUsersResponse;
            });
        }
        
        /// <summary>
        /// 获取仓库MR列表
        ///
        /// 获取仓库MR列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRepositoryMergeRequestsResponse> ListRepositoryMergeRequestsAsync(ListRepositoryMergeRequestsRequest listRepositoryMergeRequestsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryMergeRequestsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryMergeRequestsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listRepositoryMergeRequestsResponse = JsonUtils.DeSerializeNull<ListRepositoryMergeRequestsResponse>(response);
            listRepositoryMergeRequestsResponse.Body = JsonUtils.DeSerializeList<MergeRequestListBasicDto>(response);
            return listRepositoryMergeRequestsResponse;
        }

        public AsyncInvoker<ListRepositoryMergeRequestsResponse> ListRepositoryMergeRequestsAsyncInvoker(ListRepositoryMergeRequestsRequest listRepositoryMergeRequestsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryMergeRequestsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryMergeRequestsRequest);
            return new AsyncInvoker<ListRepositoryMergeRequestsResponse>(this, "GET", request, response =>
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
        public async Task<MergeMergeRequestResponse> MergeMergeRequestAsync(MergeMergeRequestRequest mergeMergeRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(mergeMergeRequestRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(mergeMergeRequestRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/merge", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", mergeMergeRequestRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<MergeMergeRequestResponse>(response);
        }

        public AsyncInvoker<MergeMergeRequestResponse> MergeMergeRequestAsyncInvoker(MergeMergeRequestRequest mergeMergeRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(mergeMergeRequestRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(mergeMergeRequestRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/merge", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", mergeMergeRequestRequest);
            return new AsyncInvoker<MergeMergeRequestResponse>(this, "PUT", request, JsonUtils.DeSerialize<MergeMergeRequestResponse>);
        }
        
        /// <summary>
        /// 变基合并请求
        ///
        /// 变基合并请求
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RebaseMergeRequestForOpenApiResponse> RebaseMergeRequestForOpenApiAsync(RebaseMergeRequestForOpenApiRequest rebaseMergeRequestForOpenApiRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rebaseMergeRequestForOpenApiRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(rebaseMergeRequestForOpenApiRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/rebase", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rebaseMergeRequestForOpenApiRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<RebaseMergeRequestForOpenApiResponse>(response);
        }

        public AsyncInvoker<RebaseMergeRequestForOpenApiResponse> RebaseMergeRequestForOpenApiAsyncInvoker(RebaseMergeRequestForOpenApiRequest rebaseMergeRequestForOpenApiRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rebaseMergeRequestForOpenApiRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(rebaseMergeRequestForOpenApiRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/rebase", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rebaseMergeRequestForOpenApiRequest);
            return new AsyncInvoker<RebaseMergeRequestForOpenApiResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<RebaseMergeRequestForOpenApiResponse>);
        }
        
        /// <summary>
        /// 在线解决合并请求冲突
        ///
        /// 在线解决合并请求冲突
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ResolveMergeRequestConflictsResponse> ResolveMergeRequestConflictsAsync(ResolveMergeRequestConflictsRequest resolveMergeRequestConflictsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resolveMergeRequestConflictsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(resolveMergeRequestConflictsRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/resolve-conflicts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resolveMergeRequestConflictsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ResolveMergeRequestConflictsResponse>(response);
        }

        public AsyncInvoker<ResolveMergeRequestConflictsResponse> ResolveMergeRequestConflictsAsyncInvoker(ResolveMergeRequestConflictsRequest resolveMergeRequestConflictsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(resolveMergeRequestConflictsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(resolveMergeRequestConflictsRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/resolve-conflicts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resolveMergeRequestConflictsRequest);
            return new AsyncInvoker<ResolveMergeRequestConflictsResponse>(this, "PUT", request, JsonUtils.DeSerialize<ResolveMergeRequestConflictsResponse>);
        }
        
        /// <summary>
        /// 检视合并请求
        ///
        /// 检视合并请求
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ReviewMergeRequestResponse> ReviewMergeRequestAsync(ReviewMergeRequestRequest reviewMergeRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(reviewMergeRequestRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(reviewMergeRequestRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/approval-review", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", reviewMergeRequestRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            var reviewMergeRequestResponse = JsonUtils.DeSerializeNull<ReviewMergeRequestResponse>(response);
            reviewMergeRequestResponse.Body = JsonUtils.DeSerializeList<ApproverBasicDto>(response);
            return reviewMergeRequestResponse;
        }

        public AsyncInvoker<ReviewMergeRequestResponse> ReviewMergeRequestAsyncInvoker(ReviewMergeRequestRequest reviewMergeRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(reviewMergeRequestRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(reviewMergeRequestRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/approval-review", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", reviewMergeRequestRequest);
            return new AsyncInvoker<ReviewMergeRequestResponse>(this, "PUT", request, response =>
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
        public async Task<ShowActualHeadPipelineResponse> ShowActualHeadPipelineAsync(ShowActualHeadPipelineRequest showActualHeadPipelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showActualHeadPipelineRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showActualHeadPipelineRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/actual-head-pipeline", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showActualHeadPipelineRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowActualHeadPipelineResponse>(response);
        }

        public AsyncInvoker<ShowActualHeadPipelineResponse> ShowActualHeadPipelineAsyncInvoker(ShowActualHeadPipelineRequest showActualHeadPipelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showActualHeadPipelineRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showActualHeadPipelineRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/actual-head-pipeline", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showActualHeadPipelineRequest);
            return new AsyncInvoker<ShowActualHeadPipelineResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowActualHeadPipelineResponse>);
        }
        
        /// <summary>
        /// 获取合并请求的平均评价
        ///
        /// 获取合并请求的平均评价
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAverageEvaluationResponse> ShowAverageEvaluationAsync(ShowAverageEvaluationRequest showAverageEvaluationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAverageEvaluationRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showAverageEvaluationRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/average-evaluation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAverageEvaluationRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAverageEvaluationResponse>(response);
        }

        public AsyncInvoker<ShowAverageEvaluationResponse> ShowAverageEvaluationAsyncInvoker(ShowAverageEvaluationRequest showAverageEvaluationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAverageEvaluationRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showAverageEvaluationRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/average-evaluation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAverageEvaluationRequest);
            return new AsyncInvoker<ShowAverageEvaluationResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAverageEvaluationResponse>);
        }
        
        /// <summary>
        /// 获取分支代码冲突
        ///
        /// 获取分支代码冲突
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBranchConflictResponse> ShowBranchConflictAsync(ShowBranchConflictRequest showBranchConflictRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBranchConflictRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/conflict", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBranchConflictRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowBranchConflictResponse>(response);
        }

        public AsyncInvoker<ShowBranchConflictResponse> ShowBranchConflictAsyncInvoker(ShowBranchConflictRequest showBranchConflictRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBranchConflictRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/conflict", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBranchConflictRequest);
            return new AsyncInvoker<ShowBranchConflictResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBranchConflictResponse>);
        }
        
        /// <summary>
        /// 获取代码组合并请求设置
        ///
        /// 获取代码组合并请求设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowGroupMergeRequestSettingResponse> ShowGroupMergeRequestSettingAsync(ShowGroupMergeRequestSettingRequest showGroupMergeRequestSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupMergeRequestSettingRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/merge-requests/setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupMergeRequestSettingRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowGroupMergeRequestSettingResponse>(response);
        }

        public AsyncInvoker<ShowGroupMergeRequestSettingResponse> ShowGroupMergeRequestSettingAsyncInvoker(ShowGroupMergeRequestSettingRequest showGroupMergeRequestSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupMergeRequestSettingRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/merge-requests/setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupMergeRequestSettingRequest);
            return new AsyncInvoker<ShowGroupMergeRequestSettingResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGroupMergeRequestSettingResponse>);
        }
        
        /// <summary>
        /// 获取合并请求文件变更页单个文件下的检视意见
        ///
        /// 获取合并请求文件变更页单个文件下的检视意见
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMergeRequestCommentsByLineResponse> ShowMergeRequestCommentsByLineAsync(ShowMergeRequestCommentsByLineRequest showMergeRequestCommentsByLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestCommentsByLineRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestCommentsByLineRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/comments-by-line", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMergeRequestCommentsByLineRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var showMergeRequestCommentsByLineResponse = JsonUtils.DeSerializeNull<ShowMergeRequestCommentsByLineResponse>(response);
            showMergeRequestCommentsByLineResponse.Body = JsonUtils.DeSerializeList<CommentPathDto>(response);
            return showMergeRequestCommentsByLineResponse;
        }

        public AsyncInvoker<ShowMergeRequestCommentsByLineResponse> ShowMergeRequestCommentsByLineAsyncInvoker(ShowMergeRequestCommentsByLineRequest showMergeRequestCommentsByLineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestCommentsByLineRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestCommentsByLineRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/comments-by-line", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMergeRequestCommentsByLineRequest);
            return new AsyncInvoker<ShowMergeRequestCommentsByLineResponse>(this, "GET", request, response =>
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
        public async Task<ShowMergeRequestDetailResponse> ShowMergeRequestDetailAsync(ShowMergeRequestDetailRequest showMergeRequestDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestDetailRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestDetailRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMergeRequestDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowMergeRequestDetailResponse>(response);
        }

        public AsyncInvoker<ShowMergeRequestDetailResponse> ShowMergeRequestDetailAsyncInvoker(ShowMergeRequestDetailRequest showMergeRequestDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestDetailRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestDetailRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMergeRequestDetailRequest);
            return new AsyncInvoker<ShowMergeRequestDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMergeRequestDetailResponse>);
        }
        
        /// <summary>
        /// 获取仓库合并请求设置
        ///
        /// 获取仓库合并请求设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMergeRequestSettingResponse> ShowMergeRequestSettingAsync(ShowMergeRequestSettingRequest showMergeRequestSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMergeRequestSettingRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowMergeRequestSettingResponse>(response);
        }

        public AsyncInvoker<ShowMergeRequestSettingResponse> ShowMergeRequestSettingAsyncInvoker(ShowMergeRequestSettingRequest showMergeRequestSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMergeRequestSettingRequest);
            return new AsyncInvoker<ShowMergeRequestSettingResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMergeRequestSettingResponse>);
        }
        
        /// <summary>
        /// 获取单个合并请求模板
        ///
        /// 获取单个合并请求模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMergeRequestTemplateResponse> ShowMergeRequestTemplateAsync(ShowMergeRequestTemplateRequest showMergeRequestTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestTemplateRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/template/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMergeRequestTemplateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowMergeRequestTemplateResponse>(response);
        }

        public AsyncInvoker<ShowMergeRequestTemplateResponse> ShowMergeRequestTemplateAsyncInvoker(ShowMergeRequestTemplateRequest showMergeRequestTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestTemplateRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/template/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMergeRequestTemplateRequest);
            return new AsyncInvoker<ShowMergeRequestTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMergeRequestTemplateResponse>);
        }
        
        /// <summary>
        /// 获取合并请求打分
        ///
        /// 获取合并请求打分
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMergeRequestVotesDetailResponse> ShowMergeRequestVotesDetailAsync(ShowMergeRequestVotesDetailRequest showMergeRequestVotesDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestVotesDetailRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestVotesDetailRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/votes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMergeRequestVotesDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowMergeRequestVotesDetailResponse>(response);
        }

        public AsyncInvoker<ShowMergeRequestVotesDetailResponse> ShowMergeRequestVotesDetailAsyncInvoker(ShowMergeRequestVotesDetailRequest showMergeRequestVotesDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestVotesDetailRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showMergeRequestVotesDetailRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/votes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMergeRequestVotesDetailRequest);
            return new AsyncInvoker<ShowMergeRequestVotesDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMergeRequestVotesDetailResponse>);
        }
        
        /// <summary>
        /// 获取合并请求的可合入状态。
        ///
        /// 获取合并请求的可合入状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMergeableStateOuterResponse> ShowMergeableStateOuterAsync(ShowMergeableStateOuterRequest showMergeableStateOuterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMergeableStateOuterRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showMergeableStateOuterRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/mergeable-state-out", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMergeableStateOuterRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowMergeableStateOuterResponse>(response);
        }

        public AsyncInvoker<ShowMergeableStateOuterResponse> ShowMergeableStateOuterAsyncInvoker(ShowMergeableStateOuterRequest showMergeableStateOuterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMergeableStateOuterRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showMergeableStateOuterRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/mergeable-state-out", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMergeableStateOuterRequest);
            return new AsyncInvoker<ShowMergeableStateOuterResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMergeableStateOuterResponse>);
        }
        
        /// <summary>
        /// 获取项目合并请求设置
        ///
        /// 获取项目合并请求设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowProjectMergeRequestSettingResponse> ShowProjectMergeRequestSettingAsync(ShowProjectMergeRequestSettingRequest showProjectMergeRequestSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectMergeRequestSettingRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/merge-requests/setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectMergeRequestSettingRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectMergeRequestSettingResponse>(response);
        }

        public AsyncInvoker<ShowProjectMergeRequestSettingResponse> ShowProjectMergeRequestSettingAsyncInvoker(ShowProjectMergeRequestSettingRequest showProjectMergeRequestSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectMergeRequestSettingRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/merge-requests/setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectMergeRequestSettingRequest);
            return new AsyncInvoker<ShowProjectMergeRequestSettingResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectMergeRequestSettingResponse>);
        }
        
        /// <summary>
        /// 更新代码组合并请求审核设置
        ///
        /// 更新代码组合并请求审核设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateGroupMergeRequestApproverSettingResponse> UpdateGroupMergeRequestApproverSettingAsync(UpdateGroupMergeRequestApproverSettingRequest updateGroupMergeRequestApproverSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateGroupMergeRequestApproverSettingRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(updateGroupMergeRequestApproverSettingRequest.SettingId, out var valueOfSettingId)) urlParam.Add("setting_id", valueOfSettingId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/approver-settings/{setting_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGroupMergeRequestApproverSettingRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGroupMergeRequestApproverSettingResponse>(response);
        }

        public AsyncInvoker<UpdateGroupMergeRequestApproverSettingResponse> UpdateGroupMergeRequestApproverSettingAsyncInvoker(UpdateGroupMergeRequestApproverSettingRequest updateGroupMergeRequestApproverSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateGroupMergeRequestApproverSettingRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(updateGroupMergeRequestApproverSettingRequest.SettingId, out var valueOfSettingId)) urlParam.Add("setting_id", valueOfSettingId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/approver-settings/{setting_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGroupMergeRequestApproverSettingRequest);
            return new AsyncInvoker<UpdateGroupMergeRequestApproverSettingResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGroupMergeRequestApproverSettingResponse>);
        }
        
        /// <summary>
        /// 更新合并请求
        ///
        /// 更新合并请求
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateMergeRequestResponse> UpdateMergeRequestAsync(UpdateMergeRequestRequest updateMergeRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateMergeRequestResponse>(response);
        }

        public AsyncInvoker<UpdateMergeRequestResponse> UpdateMergeRequestAsyncInvoker(UpdateMergeRequestRequest updateMergeRequestRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestRequest);
            return new AsyncInvoker<UpdateMergeRequestResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateMergeRequestResponse>);
        }
        
        /// <summary>
        /// 更新合并请求审核设置
        ///
        /// 更新合并请求审核设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateMergeRequestApproverSettingResponse> UpdateMergeRequestApproverSettingAsync(UpdateMergeRequestApproverSettingRequest updateMergeRequestApproverSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestApproverSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestApproverSettingRequest.SettingId, out var valueOfSettingId)) urlParam.Add("setting_id", valueOfSettingId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/approver-settings/{setting_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestApproverSettingRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateMergeRequestApproverSettingResponse>(response);
        }

        public AsyncInvoker<UpdateMergeRequestApproverSettingResponse> UpdateMergeRequestApproverSettingAsyncInvoker(UpdateMergeRequestApproverSettingRequest updateMergeRequestApproverSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestApproverSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestApproverSettingRequest.SettingId, out var valueOfSettingId)) urlParam.Add("setting_id", valueOfSettingId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/approver-settings/{setting_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestApproverSettingRequest);
            return new AsyncInvoker<UpdateMergeRequestApproverSettingResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateMergeRequestApproverSettingResponse>);
        }
        
        /// <summary>
        /// 更新合并请求的审核人列表
        ///
        /// 更新合并请求的审核人列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateMergeRequestApproversResponse> UpdateMergeRequestApproversAsync(UpdateMergeRequestApproversRequest updateMergeRequestApproversRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestApproversRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestApproversRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/approval-approvers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestApproversRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            var updateMergeRequestApproversResponse = JsonUtils.DeSerializeNull<UpdateMergeRequestApproversResponse>(response);
            updateMergeRequestApproversResponse.Body = JsonUtils.DeSerializeList<ApproverBasicDto>(response);
            return updateMergeRequestApproversResponse;
        }

        public AsyncInvoker<UpdateMergeRequestApproversResponse> UpdateMergeRequestApproversAsyncInvoker(UpdateMergeRequestApproversRequest updateMergeRequestApproversRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestApproversRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestApproversRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/approval-approvers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestApproversRequest);
            return new AsyncInvoker<UpdateMergeRequestApproversResponse>(this, "PUT", request, response =>
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
        public async Task<UpdateMergeRequestReviewersResponse> UpdateMergeRequestReviewersAsync(UpdateMergeRequestReviewersRequest updateMergeRequestReviewersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestReviewersRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestReviewersRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/approval-reviewers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestReviewersRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            var updateMergeRequestReviewersResponse = JsonUtils.DeSerializeNull<UpdateMergeRequestReviewersResponse>(response);
            updateMergeRequestReviewersResponse.Body = JsonUtils.DeSerializeList<ApproverBasicDto>(response);
            return updateMergeRequestReviewersResponse;
        }

        public AsyncInvoker<UpdateMergeRequestReviewersResponse> UpdateMergeRequestReviewersAsyncInvoker(UpdateMergeRequestReviewersRequest updateMergeRequestReviewersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestReviewersRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestReviewersRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/approval-reviewers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestReviewersRequest);
            return new AsyncInvoker<UpdateMergeRequestReviewersResponse>(this, "PUT", request, response =>
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
        public async Task<UpdateMergeRequestSettingResponse> UpdateMergeRequestSettingAsync(UpdateMergeRequestSettingRequest updateMergeRequestSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestSettingRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateMergeRequestSettingResponse>(response);
        }

        public AsyncInvoker<UpdateMergeRequestSettingResponse> UpdateMergeRequestSettingAsyncInvoker(UpdateMergeRequestSettingRequest updateMergeRequestSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestSettingRequest);
            return new AsyncInvoker<UpdateMergeRequestSettingResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateMergeRequestSettingResponse>);
        }
        
        /// <summary>
        /// 更新合并请求模板
        ///
        /// 更新合并请求模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateMergeRequestTemplateResponse> UpdateMergeRequestTemplateAsync(UpdateMergeRequestTemplateRequest updateMergeRequestTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestTemplateRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/template/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestTemplateRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateMergeRequestTemplateResponse>(response);
        }

        public AsyncInvoker<UpdateMergeRequestTemplateResponse> UpdateMergeRequestTemplateAsyncInvoker(UpdateMergeRequestTemplateRequest updateMergeRequestTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestTemplateRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/template/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestTemplateRequest);
            return new AsyncInvoker<UpdateMergeRequestTemplateResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateMergeRequestTemplateResponse>);
        }
        
        /// <summary>
        /// 更新合并请求打分
        ///
        /// 更新合并请求打分
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateMergeRequestVoteResponse> UpdateMergeRequestVoteAsync(UpdateMergeRequestVoteRequest updateMergeRequestVoteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestVoteRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestVoteRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/vote", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestVoteRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateMergeRequestVoteResponse>(response);
        }

        public AsyncInvoker<UpdateMergeRequestVoteResponse> UpdateMergeRequestVoteAsyncInvoker(UpdateMergeRequestVoteRequest updateMergeRequestVoteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestVoteRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateMergeRequestVoteRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/vote", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateMergeRequestVoteRequest);
            return new AsyncInvoker<UpdateMergeRequestVoteResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateMergeRequestVoteResponse>);
        }
        
        /// <summary>
        /// 更新项目合并请求审核设置
        ///
        /// 更新项目合并请求审核设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateProjectMergeRequestApproverSettingResponse> UpdateProjectMergeRequestApproverSettingAsync(UpdateProjectMergeRequestApproverSettingRequest updateProjectMergeRequestApproverSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProjectMergeRequestApproverSettingRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(updateProjectMergeRequestApproverSettingRequest.SettingId, out var valueOfSettingId)) urlParam.Add("setting_id", valueOfSettingId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/approver-settings/{setting_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProjectMergeRequestApproverSettingRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateProjectMergeRequestApproverSettingResponse>(response);
        }

        public AsyncInvoker<UpdateProjectMergeRequestApproverSettingResponse> UpdateProjectMergeRequestApproverSettingAsyncInvoker(UpdateProjectMergeRequestApproverSettingRequest updateProjectMergeRequestApproverSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProjectMergeRequestApproverSettingRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(updateProjectMergeRequestApproverSettingRequest.SettingId, out var valueOfSettingId)) urlParam.Add("setting_id", valueOfSettingId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/approver-settings/{setting_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProjectMergeRequestApproverSettingRequest);
            return new AsyncInvoker<UpdateProjectMergeRequestApproverSettingResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateProjectMergeRequestApproverSettingResponse>);
        }
        
        /// <summary>
        /// 获取提交关联的合并请求
        ///
        /// 获取提交关联的合并请求
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCommitAssociatedMergeRequestsResponse> ListCommitAssociatedMergeRequestsAsync(ListCommitAssociatedMergeRequestsRequest listCommitAssociatedMergeRequestsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listCommitAssociatedMergeRequestsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listCommitAssociatedMergeRequestsRequest.Sha, out var valueOfSha)) urlParam.Add("sha", valueOfSha);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/commits/{sha}/merge-requests", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCommitAssociatedMergeRequestsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listCommitAssociatedMergeRequestsResponse = JsonUtils.DeSerializeNull<ListCommitAssociatedMergeRequestsResponse>(response);
            listCommitAssociatedMergeRequestsResponse.Body = JsonUtils.DeSerializeList<CommitMergeRequestDto>(response);
            return listCommitAssociatedMergeRequestsResponse;
        }

        public AsyncInvoker<ListCommitAssociatedMergeRequestsResponse> ListCommitAssociatedMergeRequestsAsyncInvoker(ListCommitAssociatedMergeRequestsRequest listCommitAssociatedMergeRequestsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listCommitAssociatedMergeRequestsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listCommitAssociatedMergeRequestsRequest.Sha, out var valueOfSha)) urlParam.Add("sha", valueOfSha);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/commits/{sha}/merge-requests", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCommitAssociatedMergeRequestsRequest);
            return new AsyncInvoker<ListCommitAssociatedMergeRequestsResponse>(this, "GET", request, response =>
            {
                var listCommitAssociatedMergeRequestsResponse = JsonUtils.DeSerializeNull<ListCommitAssociatedMergeRequestsResponse>(response);
                listCommitAssociatedMergeRequestsResponse.Body = JsonUtils.DeSerializeList<CommitMergeRequestDto>(response);
                return listCommitAssociatedMergeRequestsResponse;
            });
        }
        
        /// <summary>
        /// 获取仓库合并请求统计数据
        ///
        /// 获取仓库合并请求统计数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRepositoryMergeRequestsStatisticResponse> ShowRepositoryMergeRequestsStatisticAsync(ShowRepositoryMergeRequestsStatisticRequest showRepositoryMergeRequestsStatisticRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryMergeRequestsStatisticRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryMergeRequestsStatisticRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var showRepositoryMergeRequestsStatisticResponse = JsonUtils.DeSerializeNull<ShowRepositoryMergeRequestsStatisticResponse>(response);
            showRepositoryMergeRequestsStatisticResponse.Body = JsonUtils.DeSerializeList<MergeRequestStatisticDto>(response);
            return showRepositoryMergeRequestsStatisticResponse;
        }

        public AsyncInvoker<ShowRepositoryMergeRequestsStatisticResponse> ShowRepositoryMergeRequestsStatisticAsyncInvoker(ShowRepositoryMergeRequestsStatisticRequest showRepositoryMergeRequestsStatisticRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryMergeRequestsStatisticRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryMergeRequestsStatisticRequest);
            return new AsyncInvoker<ShowRepositoryMergeRequestsStatisticResponse>(this, "GET", request, response =>
            {
                var showRepositoryMergeRequestsStatisticResponse = JsonUtils.DeSerializeNull<ShowRepositoryMergeRequestsStatisticResponse>(response);
                showRepositoryMergeRequestsStatisticResponse.Body = JsonUtils.DeSerializeList<MergeRequestStatisticDto>(response);
                return showRepositoryMergeRequestsStatisticResponse;
            });
        }
        
        /// <summary>
        /// 获取合并请求参与者
        ///
        /// 获取合并请求参与者
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListMergeRequestParticipantsResponse> ListMergeRequestParticipantsAsync(ListMergeRequestParticipantsRequest listMergeRequestParticipantsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestParticipantsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestParticipantsRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/participants", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestParticipantsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listMergeRequestParticipantsResponse = JsonUtils.DeSerializeNull<ListMergeRequestParticipantsResponse>(response);
            listMergeRequestParticipantsResponse.Body = JsonUtils.DeSerializeList<UserBasicDto>(response);
            return listMergeRequestParticipantsResponse;
        }

        public AsyncInvoker<ListMergeRequestParticipantsResponse> ListMergeRequestParticipantsAsyncInvoker(ListMergeRequestParticipantsRequest listMergeRequestParticipantsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestParticipantsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listMergeRequestParticipantsRequest.MergeRequestIid, out var valueOfMergeRequestIid)) urlParam.Add("merge_request_iid", valueOfMergeRequestIid);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/merge-requests/{merge_request_iid}/participants", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMergeRequestParticipantsRequest);
            return new AsyncInvoker<ListMergeRequestParticipantsResponse>(this, "GET", request, response =>
            {
                var listMergeRequestParticipantsResponse = JsonUtils.DeSerializeNull<ListMergeRequestParticipantsResponse>(response);
                listMergeRequestParticipantsResponse.Body = JsonUtils.DeSerializeList<UserBasicDto>(response);
                return listMergeRequestParticipantsResponse;
            });
        }
        
        /// <summary>
        /// 查询仓库权限配置信息
        ///
        /// 查询仓库权限配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRepositoryPermissionInheritEnabledResponse> ShowRepositoryPermissionInheritEnabledAsync(ShowRepositoryPermissionInheritEnabledRequest showRepositoryPermissionInheritEnabledRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryPermissionInheritEnabledRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/permission-inherit-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryPermissionInheritEnabledRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRepositoryPermissionInheritEnabledResponse>(response);
        }

        public AsyncInvoker<ShowRepositoryPermissionInheritEnabledResponse> ShowRepositoryPermissionInheritEnabledAsyncInvoker(ShowRepositoryPermissionInheritEnabledRequest showRepositoryPermissionInheritEnabledRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryPermissionInheritEnabledRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/permission-inherit-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryPermissionInheritEnabledRequest);
            return new AsyncInvoker<ShowRepositoryPermissionInheritEnabledResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepositoryPermissionInheritEnabledResponse>);
        }
        
        /// <summary>
        /// 更新仓库权限继承配置
        ///
        /// 更新仓库权限继承配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRepositoryPermissionInheritEnabledResponse> UpdateRepositoryPermissionInheritEnabledAsync(UpdateRepositoryPermissionInheritEnabledRequest updateRepositoryPermissionInheritEnabledRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryPermissionInheritEnabledRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/permission-inherit-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepositoryPermissionInheritEnabledRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRepositoryPermissionInheritEnabledResponse>(response);
        }

        public AsyncInvoker<UpdateRepositoryPermissionInheritEnabledResponse> UpdateRepositoryPermissionInheritEnabledAsyncInvoker(UpdateRepositoryPermissionInheritEnabledRequest updateRepositoryPermissionInheritEnabledRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryPermissionInheritEnabledRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/permission-inherit-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepositoryPermissionInheritEnabledRequest);
            return new AsyncInvoker<UpdateRepositoryPermissionInheritEnabledResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRepositoryPermissionInheritEnabledResponse>);
        }
        
        /// <summary>
        /// 获取流水线的关联的最新任务
        ///
        /// 获取流水线的关联的最新任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLatestPipelineJobsResponse> ListLatestPipelineJobsAsync(ListLatestPipelineJobsRequest listLatestPipelineJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listLatestPipelineJobsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listLatestPipelineJobsRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/pipelines/{pipeline_id}/latest-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLatestPipelineJobsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListLatestPipelineJobsResponse>(response);
        }

        public AsyncInvoker<ListLatestPipelineJobsResponse> ListLatestPipelineJobsAsyncInvoker(ListLatestPipelineJobsRequest listLatestPipelineJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listLatestPipelineJobsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listLatestPipelineJobsRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/pipelines/{pipeline_id}/latest-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLatestPipelineJobsRequest);
            return new AsyncInvoker<ListLatestPipelineJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLatestPipelineJobsResponse>);
        }
        
        /// <summary>
        /// 获取流水线的关联的任务列表
        ///
        /// 获取流水线的关联的任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPipelineJobsResponse> ListPipelineJobsAsync(ListPipelineJobsRequest listPipelineJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPipelineJobsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listPipelineJobsRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/pipelines/{pipeline_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPipelineJobsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listPipelineJobsResponse = JsonUtils.DeSerializeNull<ListPipelineJobsResponse>(response);
            listPipelineJobsResponse.Body = JsonUtils.DeSerializeList<JobWithStageDto>(response);
            return listPipelineJobsResponse;
        }

        public AsyncInvoker<ListPipelineJobsResponse> ListPipelineJobsAsyncInvoker(ListPipelineJobsRequest listPipelineJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPipelineJobsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listPipelineJobsRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/pipelines/{pipeline_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPipelineJobsRequest);
            return new AsyncInvoker<ListPipelineJobsResponse>(this, "GET", request, response =>
            {
                var listPipelineJobsResponse = JsonUtils.DeSerializeNull<ListPipelineJobsResponse>(response);
                listPipelineJobsResponse.Body = JsonUtils.DeSerializeList<JobWithStageDto>(response);
                return listPipelineJobsResponse;
            });
        }
        
        /// <summary>
        /// 获取项目继承设置项
        ///
        /// 获取项目继承设置项
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowProjectSettingsInheritCfgResponse> ShowProjectSettingsInheritCfgAsync(ShowProjectSettingsInheritCfgRequest showProjectSettingsInheritCfgRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectSettingsInheritCfgRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/settings-inherit-cfg", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectSettingsInheritCfgRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var showProjectSettingsInheritCfgResponse = JsonUtils.DeSerializeNull<ShowProjectSettingsInheritCfgResponse>(response);
            showProjectSettingsInheritCfgResponse.Body = JsonUtils.DeSerializeList<ProjectSettingsInheritCfgDto>(response);
            return showProjectSettingsInheritCfgResponse;
        }

        public AsyncInvoker<ShowProjectSettingsInheritCfgResponse> ShowProjectSettingsInheritCfgAsyncInvoker(ShowProjectSettingsInheritCfgRequest showProjectSettingsInheritCfgRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectSettingsInheritCfgRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/settings-inherit-cfg", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectSettingsInheritCfgRequest);
            return new AsyncInvoker<ShowProjectSettingsInheritCfgResponse>(this, "GET", request, response =>
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
        public async Task<ShowProjectWatermarkResponse> ShowProjectWatermarkAsync(ShowProjectWatermarkRequest showProjectWatermarkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectWatermarkRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectWatermarkRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectWatermarkResponse>(response);
        }

        public AsyncInvoker<ShowProjectWatermarkResponse> ShowProjectWatermarkAsyncInvoker(ShowProjectWatermarkRequest showProjectWatermarkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectWatermarkRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectWatermarkRequest);
            return new AsyncInvoker<ShowProjectWatermarkResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectWatermarkResponse>);
        }
        
        /// <summary>
        /// 更新项目继承设置项
        ///
        /// 更新项目继承设置项
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateProjectSettingsInheritCfgResponse> UpdateProjectSettingsInheritCfgAsync(UpdateProjectSettingsInheritCfgRequest updateProjectSettingsInheritCfgRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProjectSettingsInheritCfgRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/settings-inherit-cfg", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProjectSettingsInheritCfgRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            var updateProjectSettingsInheritCfgResponse = JsonUtils.DeSerializeNull<UpdateProjectSettingsInheritCfgResponse>(response);
            updateProjectSettingsInheritCfgResponse.Body = JsonUtils.DeSerializeList<ProjectSettingsInheritCfgDto>(response);
            return updateProjectSettingsInheritCfgResponse;
        }

        public AsyncInvoker<UpdateProjectSettingsInheritCfgResponse> UpdateProjectSettingsInheritCfgAsyncInvoker(UpdateProjectSettingsInheritCfgRequest updateProjectSettingsInheritCfgRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProjectSettingsInheritCfgRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/settings-inherit-cfg", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProjectSettingsInheritCfgRequest);
            return new AsyncInvoker<UpdateProjectSettingsInheritCfgResponse>(this, "PUT", request, response =>
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
        public async Task<UpdateProjectWatermarkResponse> UpdateProjectWatermarkAsync(UpdateProjectWatermarkRequest updateProjectWatermarkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProjectWatermarkRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProjectWatermarkRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateProjectWatermarkResponse>(response);
        }

        public AsyncInvoker<UpdateProjectWatermarkResponse> UpdateProjectWatermarkAsyncInvoker(UpdateProjectWatermarkRequest updateProjectWatermarkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProjectWatermarkRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProjectWatermarkRequest);
            return new AsyncInvoker<UpdateProjectWatermarkResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateProjectWatermarkResponse>);
        }
        
        /// <summary>
        /// 批量创建仓库保护分支
        ///
        /// 批量创建仓库保护分支
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateProtectedBranchResponse> BatchCreateProtectedBranchAsync(BatchCreateProtectedBranchRequest batchCreateProtectedBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateProtectedBranchRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateProtectedBranchRequest);
            var response = await DoHttpRequestAsync("POST", request);
            var batchCreateProtectedBranchResponse = JsonUtils.DeSerializeNull<BatchCreateProtectedBranchResponse>(response);
            batchCreateProtectedBranchResponse.Body = JsonUtils.DeSerializeList<RepositoryProtectedBranchDto>(response);
            return batchCreateProtectedBranchResponse;
        }

        public AsyncInvoker<BatchCreateProtectedBranchResponse> BatchCreateProtectedBranchAsyncInvoker(BatchCreateProtectedBranchRequest batchCreateProtectedBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateProtectedBranchRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateProtectedBranchRequest);
            return new AsyncInvoker<BatchCreateProtectedBranchResponse>(this, "POST", request, response =>
            {
                var batchCreateProtectedBranchResponse = JsonUtils.DeSerializeNull<BatchCreateProtectedBranchResponse>(response);
                batchCreateProtectedBranchResponse.Body = JsonUtils.DeSerializeList<RepositoryProtectedBranchDto>(response);
                return batchCreateProtectedBranchResponse;
            });
        }
        
        /// <summary>
        /// 批量删除仓库保护分支
        ///
        /// 批量删除仓库保护分支
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteProtectedBranchesResponse> BatchDeleteProtectedBranchesAsync(BatchDeleteProtectedBranchesRequest batchDeleteProtectedBranchesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteProtectedBranchesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-branches/bulk-deletion", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteProtectedBranchesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteProtectedBranchesResponse>(response);
        }

        public AsyncInvoker<BatchDeleteProtectedBranchesResponse> BatchDeleteProtectedBranchesAsyncInvoker(BatchDeleteProtectedBranchesRequest batchDeleteProtectedBranchesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteProtectedBranchesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-branches/bulk-deletion", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteProtectedBranchesRequest);
            return new AsyncInvoker<BatchDeleteProtectedBranchesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteProtectedBranchesResponse>);
        }
        
        /// <summary>
        /// 批量更新仓库保护分支
        ///
        /// 批量更新仓库保护分支
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUpdateProtectedBranchesResponse> BatchUpdateProtectedBranchesAsync(BatchUpdateProtectedBranchesRequest batchUpdateProtectedBranchesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateProtectedBranchesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateProtectedBranchesRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            var batchUpdateProtectedBranchesResponse = JsonUtils.DeSerializeNull<BatchUpdateProtectedBranchesResponse>(response);
            batchUpdateProtectedBranchesResponse.Body = JsonUtils.DeSerializeList<RepositoryProtectedBranchDto>(response);
            return batchUpdateProtectedBranchesResponse;
        }

        public AsyncInvoker<BatchUpdateProtectedBranchesResponse> BatchUpdateProtectedBranchesAsyncInvoker(BatchUpdateProtectedBranchesRequest batchUpdateProtectedBranchesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateProtectedBranchesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateProtectedBranchesRequest);
            return new AsyncInvoker<BatchUpdateProtectedBranchesResponse>(this, "PUT", request, response =>
            {
                var batchUpdateProtectedBranchesResponse = JsonUtils.DeSerializeNull<BatchUpdateProtectedBranchesResponse>(response);
                batchUpdateProtectedBranchesResponse.Body = JsonUtils.DeSerializeList<RepositoryProtectedBranchDto>(response);
                return batchUpdateProtectedBranchesResponse;
            });
        }
        
        /// <summary>
        /// 创建项目下保护分支
        ///
        /// 创建项目下保护分支
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateProjectProtectedBranchesResponse> CreateProjectProtectedBranchesAsync(CreateProjectProtectedBranchesRequest createProjectProtectedBranchesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createProjectProtectedBranchesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/protected-branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProjectProtectedBranchesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateProjectProtectedBranchesResponse>(response);
        }

        public AsyncInvoker<CreateProjectProtectedBranchesResponse> CreateProjectProtectedBranchesAsyncInvoker(CreateProjectProtectedBranchesRequest createProjectProtectedBranchesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createProjectProtectedBranchesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/protected-branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProjectProtectedBranchesRequest);
            return new AsyncInvoker<CreateProjectProtectedBranchesResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateProjectProtectedBranchesResponse>);
        }
        
        /// <summary>
        /// 删除仓库保护分支
        ///
        /// 删除仓库保护分支
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteProtectedBranchResponse> DeleteProtectedBranchAsync(DeleteProtectedBranchRequest deleteProtectedBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteProtectedBranchRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-branch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProtectedBranchRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteProtectedBranchResponse>(response);
        }

        public AsyncInvoker<DeleteProtectedBranchResponse> DeleteProtectedBranchAsyncInvoker(DeleteProtectedBranchRequest deleteProtectedBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteProtectedBranchRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-branch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProtectedBranchRequest);
            return new AsyncInvoker<DeleteProtectedBranchResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteProtectedBranchResponse>);
        }
        
        /// <summary>
        /// 获取项目下保护分支列表
        ///
        /// 获取项目下保护分支列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProjectProtectedBranchesResponse> ListProjectProtectedBranchesAsync(ListProjectProtectedBranchesRequest listProjectProtectedBranchesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectProtectedBranchesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/protected-branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectProtectedBranchesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listProjectProtectedBranchesResponse = JsonUtils.DeSerializeNull<ListProjectProtectedBranchesResponse>(response);
            listProjectProtectedBranchesResponse.Body = JsonUtils.DeSerializeList<ProjectProtectedBranchApiDto>(response);
            return listProjectProtectedBranchesResponse;
        }

        public AsyncInvoker<ListProjectProtectedBranchesResponse> ListProjectProtectedBranchesAsyncInvoker(ListProjectProtectedBranchesRequest listProjectProtectedBranchesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectProtectedBranchesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/protected-branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectProtectedBranchesRequest);
            return new AsyncInvoker<ListProjectProtectedBranchesResponse>(this, "GET", request, response =>
            {
                var listProjectProtectedBranchesResponse = JsonUtils.DeSerializeNull<ListProjectProtectedBranchesResponse>(response);
                listProjectProtectedBranchesResponse.Body = JsonUtils.DeSerializeList<ProjectProtectedBranchApiDto>(response);
                return listProjectProtectedBranchesResponse;
            });
        }
        
        /// <summary>
        /// 获取仓库保护分支列表
        ///
        /// 获取仓库保护分支列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProtectedBranchesResponse> ListProtectedBranchesAsync(ListProtectedBranchesRequest listProtectedBranchesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProtectedBranchesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProtectedBranchesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listProtectedBranchesResponse = JsonUtils.DeSerializeNull<ListProtectedBranchesResponse>(response);
            listProtectedBranchesResponse.Body = JsonUtils.DeSerializeList<RepositoryProtectedBranchDto>(response);
            return listProtectedBranchesResponse;
        }

        public AsyncInvoker<ListProtectedBranchesResponse> ListProtectedBranchesAsyncInvoker(ListProtectedBranchesRequest listProtectedBranchesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProtectedBranchesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProtectedBranchesRequest);
            return new AsyncInvoker<ListProtectedBranchesResponse>(this, "GET", request, response =>
            {
                var listProtectedBranchesResponse = JsonUtils.DeSerializeNull<ListProtectedBranchesResponse>(response);
                listProtectedBranchesResponse.Body = JsonUtils.DeSerializeList<RepositoryProtectedBranchDto>(response);
                return listProtectedBranchesResponse;
            });
        }
        
        /// <summary>
        /// 获取仓库保护分支
        ///
        /// 获取仓库保护分支
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowProtectedBranchResponse> ShowProtectedBranchAsync(ShowProtectedBranchRequest showProtectedBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProtectedBranchRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-branch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProtectedBranchRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowProtectedBranchResponse>(response);
        }

        public AsyncInvoker<ShowProtectedBranchResponse> ShowProtectedBranchAsyncInvoker(ShowProtectedBranchRequest showProtectedBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProtectedBranchRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-branch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProtectedBranchRequest);
            return new AsyncInvoker<ShowProtectedBranchResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProtectedBranchResponse>);
        }
        
        /// <summary>
        /// 更新仓库保护分支
        ///
        /// 更新仓库保护分支
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateProtectedBranchResponse> UpdateProtectedBranchAsync(UpdateProtectedBranchRequest updateProtectedBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProtectedBranchRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-branch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProtectedBranchRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateProtectedBranchResponse>(response);
        }

        public AsyncInvoker<UpdateProtectedBranchResponse> UpdateProtectedBranchAsyncInvoker(UpdateProtectedBranchRequest updateProtectedBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProtectedBranchRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-branch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProtectedBranchRequest);
            return new AsyncInvoker<UpdateProtectedBranchResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateProtectedBranchResponse>);
        }
        
        /// <summary>
        /// 批量创建仓库保护Tag
        ///
        /// 批量创建仓库保护Tag
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateProtectedTagsResponse> BatchCreateProtectedTagsAsync(BatchCreateProtectedTagsRequest batchCreateProtectedTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateProtectedTagsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateProtectedTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            var batchCreateProtectedTagsResponse = JsonUtils.DeSerializeNull<BatchCreateProtectedTagsResponse>(response);
            batchCreateProtectedTagsResponse.Body = JsonUtils.DeSerializeList<RepositoryProtectedTagDto>(response);
            return batchCreateProtectedTagsResponse;
        }

        public AsyncInvoker<BatchCreateProtectedTagsResponse> BatchCreateProtectedTagsAsyncInvoker(BatchCreateProtectedTagsRequest batchCreateProtectedTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchCreateProtectedTagsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateProtectedTagsRequest);
            return new AsyncInvoker<BatchCreateProtectedTagsResponse>(this, "POST", request, response =>
            {
                var batchCreateProtectedTagsResponse = JsonUtils.DeSerializeNull<BatchCreateProtectedTagsResponse>(response);
                batchCreateProtectedTagsResponse.Body = JsonUtils.DeSerializeList<RepositoryProtectedTagDto>(response);
                return batchCreateProtectedTagsResponse;
            });
        }
        
        /// <summary>
        /// 批量删除仓库保护Tag
        ///
        /// 批量删除仓库保护Tag
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteProtectedTagsResponse> BatchDeleteProtectedTagsAsync(BatchDeleteProtectedTagsRequest batchDeleteProtectedTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteProtectedTagsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-tags/bulk-deletion", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteProtectedTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteProtectedTagsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteProtectedTagsResponse> BatchDeleteProtectedTagsAsyncInvoker(BatchDeleteProtectedTagsRequest batchDeleteProtectedTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteProtectedTagsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-tags/bulk-deletion", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteProtectedTagsRequest);
            return new AsyncInvoker<BatchDeleteProtectedTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteProtectedTagsResponse>);
        }
        
        /// <summary>
        /// 批量更新仓库保护Tag
        ///
        /// 批量更新仓库保护Tag
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUpdateProtectedTagsResponse> BatchUpdateProtectedTagsAsync(BatchUpdateProtectedTagsRequest batchUpdateProtectedTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateProtectedTagsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateProtectedTagsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            var batchUpdateProtectedTagsResponse = JsonUtils.DeSerializeNull<BatchUpdateProtectedTagsResponse>(response);
            batchUpdateProtectedTagsResponse.Body = JsonUtils.DeSerializeList<RepositoryProtectedTagDto>(response);
            return batchUpdateProtectedTagsResponse;
        }

        public AsyncInvoker<BatchUpdateProtectedTagsResponse> BatchUpdateProtectedTagsAsyncInvoker(BatchUpdateProtectedTagsRequest batchUpdateProtectedTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateProtectedTagsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateProtectedTagsRequest);
            return new AsyncInvoker<BatchUpdateProtectedTagsResponse>(this, "PUT", request, response =>
            {
                var batchUpdateProtectedTagsResponse = JsonUtils.DeSerializeNull<BatchUpdateProtectedTagsResponse>(response);
                batchUpdateProtectedTagsResponse.Body = JsonUtils.DeSerializeList<RepositoryProtectedTagDto>(response);
                return batchUpdateProtectedTagsResponse;
            });
        }
        
        /// <summary>
        /// 删除仓库保护Tag
        ///
        /// 删除仓库保护Tag
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteProtectedTagResponse> DeleteProtectedTagAsync(DeleteProtectedTagRequest deleteProtectedTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteProtectedTagRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProtectedTagRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteProtectedTagResponse>(response);
        }

        public AsyncInvoker<DeleteProtectedTagResponse> DeleteProtectedTagAsyncInvoker(DeleteProtectedTagRequest deleteProtectedTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteProtectedTagRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProtectedTagRequest);
            return new AsyncInvoker<DeleteProtectedTagResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteProtectedTagResponse>);
        }
        
        /// <summary>
        /// 获取仓库保护Tag列表
        ///
        /// 获取仓库保护Tag列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProtectedTagsResponse> ListProtectedTagsAsync(ListProtectedTagsRequest listProtectedTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProtectedTagsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProtectedTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listProtectedTagsResponse = JsonUtils.DeSerializeNull<ListProtectedTagsResponse>(response);
            listProtectedTagsResponse.Body = JsonUtils.DeSerializeList<RepositoryProtectedTagDto>(response);
            return listProtectedTagsResponse;
        }

        public AsyncInvoker<ListProtectedTagsResponse> ListProtectedTagsAsyncInvoker(ListProtectedTagsRequest listProtectedTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProtectedTagsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProtectedTagsRequest);
            return new AsyncInvoker<ListProtectedTagsResponse>(this, "GET", request, response =>
            {
                var listProtectedTagsResponse = JsonUtils.DeSerializeNull<ListProtectedTagsResponse>(response);
                listProtectedTagsResponse.Body = JsonUtils.DeSerializeList<RepositoryProtectedTagDto>(response);
                return listProtectedTagsResponse;
            });
        }
        
        /// <summary>
        /// 获取仓库保护Tag
        ///
        /// 获取仓库保护Tag
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowProtectedTagResponse> ShowProtectedTagAsync(ShowProtectedTagRequest showProtectedTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProtectedTagRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProtectedTagRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowProtectedTagResponse>(response);
        }

        public AsyncInvoker<ShowProtectedTagResponse> ShowProtectedTagAsyncInvoker(ShowProtectedTagRequest showProtectedTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProtectedTagRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProtectedTagRequest);
            return new AsyncInvoker<ShowProtectedTagResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProtectedTagResponse>);
        }
        
        /// <summary>
        /// 更新仓库保护Tag
        ///
        /// 更新仓库保护Tag
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateProtectedTagResponse> UpdateProtectedTagAsync(UpdateProtectedTagRequest updateProtectedTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProtectedTagRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProtectedTagRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateProtectedTagResponse>(response);
        }

        public AsyncInvoker<UpdateProtectedTagResponse> UpdateProtectedTagAsyncInvoker(UpdateProtectedTagRequest updateProtectedTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProtectedTagRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/protected-tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProtectedTagRequest);
            return new AsyncInvoker<UpdateProtectedTagResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateProtectedTagResponse>);
        }
        
        /// <summary>
        /// 创建子模块
        ///
        /// 创建子模块
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddSubmoduleResponse> AddSubmoduleAsync(AddSubmoduleRequest addSubmoduleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addSubmoduleRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/submodules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addSubmoduleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddSubmoduleResponse>(response);
        }

        public AsyncInvoker<AddSubmoduleResponse> AddSubmoduleAsyncInvoker(AddSubmoduleRequest addSubmoduleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addSubmoduleRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/submodules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addSubmoduleRequest);
            return new AsyncInvoker<AddSubmoduleResponse>(this, "POST", request, JsonUtils.DeSerialize<AddSubmoduleResponse>);
        }
        
        /// <summary>
        /// 添加仓库ip白名单
        ///
        /// 添加仓库ip白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddTrustedIpAddressResponse> AddTrustedIpAddressAsync(AddTrustedIpAddressRequest addTrustedIpAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addTrustedIpAddressRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{id}/trusted-ip-addresses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addTrustedIpAddressRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddTrustedIpAddressResponse>(response);
        }

        public AsyncInvoker<AddTrustedIpAddressResponse> AddTrustedIpAddressAsyncInvoker(AddTrustedIpAddressRequest addTrustedIpAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addTrustedIpAddressRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{id}/trusted-ip-addresses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addTrustedIpAddressRequest);
            return new AsyncInvoker<AddTrustedIpAddressResponse>(this, "POST", request, JsonUtils.DeSerialize<AddTrustedIpAddressResponse>);
        }
        
        /// <summary>
        /// 将普通仓库与远程镜像关联
        ///
        /// 将普通仓库与远程镜像关联
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociateRemoteMirrorResponse> AssociateRemoteMirrorAsync(AssociateRemoteMirrorRequest associateRemoteMirrorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateRemoteMirrorRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/remote-mirror/associate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateRemoteMirrorRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AssociateRemoteMirrorResponse>(response);
        }

        public AsyncInvoker<AssociateRemoteMirrorResponse> AssociateRemoteMirrorAsyncInvoker(AssociateRemoteMirrorRequest associateRemoteMirrorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateRemoteMirrorRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/remote-mirror/associate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateRemoteMirrorRequest);
            return new AsyncInvoker<AssociateRemoteMirrorResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateRemoteMirrorResponse>);
        }
        
        /// <summary>
        /// 关联仓库与成员组
        ///
        /// 关联仓库与成员组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AssociateRepositoryUserGroupResponse> AssociateRepositoryUserGroupAsync(AssociateRepositoryUserGroupRequest associateRepositoryUserGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateRepositoryUserGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(associateRepositoryUserGroupRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(associateRepositoryUserGroupRequest.UserGroupId, out var valueOfUserGroupId)) urlParam.Add("user_group_id", valueOfUserGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/repositories/{repository_id}/user-group/{user_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateRepositoryUserGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AssociateRepositoryUserGroupResponse>(response);
        }

        public AsyncInvoker<AssociateRepositoryUserGroupResponse> AssociateRepositoryUserGroupAsyncInvoker(AssociateRepositoryUserGroupRequest associateRepositoryUserGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(associateRepositoryUserGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(associateRepositoryUserGroupRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(associateRepositoryUserGroupRequest.UserGroupId, out var valueOfUserGroupId)) urlParam.Add("user_group_id", valueOfUserGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/repositories/{repository_id}/user-group/{user_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", associateRepositoryUserGroupRequest);
            return new AsyncInvoker<AssociateRepositoryUserGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<AssociateRepositoryUserGroupResponse>);
        }
        
        /// <summary>
        /// 创建指定分支下的目录
        ///
        /// 创建指定分支下的目录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDirResponse> CreateDirAsync(CreateDirRequest createDirRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createDirRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/dir", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDirRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateDirResponse>(response);
        }

        public AsyncInvoker<CreateDirResponse> CreateDirAsyncInvoker(CreateDirRequest createDirRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createDirRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/dir", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDirRequest);
            return new AsyncInvoker<CreateDirResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateDirResponse>);
        }
        
        /// <summary>
        /// 删除仓库ip白名单
        ///
        /// 删除仓库ip白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTrustedIpAddressResponse> DeleteTrustedIpAddressAsync(DeleteTrustedIpAddressRequest deleteTrustedIpAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTrustedIpAddressRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            if (StringUtils.TryConvertToNonEmptyString(deleteTrustedIpAddressRequest.IpId, out var valueOfIpId)) urlParam.Add("ip_id", valueOfIpId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{id}/trusted-ip-addresses/{ip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTrustedIpAddressRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteTrustedIpAddressResponse>(response);
        }

        public AsyncInvoker<DeleteTrustedIpAddressResponse> DeleteTrustedIpAddressAsyncInvoker(DeleteTrustedIpAddressRequest deleteTrustedIpAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTrustedIpAddressRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            if (StringUtils.TryConvertToNonEmptyString(deleteTrustedIpAddressRequest.IpId, out var valueOfIpId)) urlParam.Add("ip_id", valueOfIpId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{id}/trusted-ip-addresses/{ip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTrustedIpAddressRequest);
            return new AsyncInvoker<DeleteTrustedIpAddressResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteTrustedIpAddressResponse>);
        }
        
        /// <summary>
        /// 仓库下载
        ///
        /// 仓库下载
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DownloadArchiveResponse> DownloadArchiveAsync(DownloadArchiveRequest downloadArchiveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadArchiveRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/archive", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadArchiveRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<DownloadArchiveResponse>(response);
        }

        public AsyncInvoker<DownloadArchiveResponse> DownloadArchiveAsyncInvoker(DownloadArchiveRequest downloadArchiveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadArchiveRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/archive", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadArchiveRequest);
            return new AsyncInvoker<DownloadArchiveResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadArchiveResponse>);
        }
        
        /// <summary>
        /// 获取当前登录用户仓库
        ///
        /// 获取当前登录用户仓库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCurrentUserRepositoriesResponse> ListCurrentUserRepositoriesAsync(ListCurrentUserRepositoriesRequest listCurrentUserRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listCurrentUserRepositoriesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/user/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCurrentUserRepositoriesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listCurrentUserRepositoriesResponse = JsonUtils.DeSerializeNull<ListCurrentUserRepositoriesResponse>(response);
            listCurrentUserRepositoriesResponse.Body = JsonUtils.DeSerializeList<RepositorySimplestDto>(response);
            return listCurrentUserRepositoriesResponse;
        }

        public AsyncInvoker<ListCurrentUserRepositoriesResponse> ListCurrentUserRepositoriesAsyncInvoker(ListCurrentUserRepositoriesRequest listCurrentUserRepositoriesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listCurrentUserRepositoriesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/user/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCurrentUserRepositoriesRequest);
            return new AsyncInvoker<ListCurrentUserRepositoriesResponse>(this, "GET", request, response =>
            {
                var listCurrentUserRepositoriesResponse = JsonUtils.DeSerializeNull<ListCurrentUserRepositoriesResponse>(response);
                listCurrentUserRepositoriesResponse.Body = JsonUtils.DeSerializeList<RepositorySimplestDto>(response);
                return listCurrentUserRepositoriesResponse;
            });
        }
        
        /// <summary>
        /// 获取项目下当前用户有管理权限的代码组列表
        ///
        /// 获取项目下当前用户有管理权限的代码组列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListManageableGroupsResponse> ListManageableGroupsAsync(ListManageableGroupsRequest listManageableGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listManageableGroupsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/manageable-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listManageableGroupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listManageableGroupsResponse = JsonUtils.DeSerializeNull<ListManageableGroupsResponse>(response);
            listManageableGroupsResponse.Body = JsonUtils.DeSerializeList<ManageableGroupDto>(response);
            return listManageableGroupsResponse;
        }

        public AsyncInvoker<ListManageableGroupsResponse> ListManageableGroupsAsyncInvoker(ListManageableGroupsRequest listManageableGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listManageableGroupsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/manageable-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listManageableGroupsRequest);
            return new AsyncInvoker<ListManageableGroupsResponse>(this, "GET", request, response =>
            {
                var listManageableGroupsResponse = JsonUtils.DeSerializeNull<ListManageableGroupsResponse>(response);
                listManageableGroupsResponse.Body = JsonUtils.DeSerializeList<ManageableGroupDto>(response);
                return listManageableGroupsResponse;
            });
        }
        
        /// <summary>
        /// 查看当前用户仓库导入任务列表
        ///
        /// 查看当前用户仓库导入任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPersonalRepositoryImportRecordsResponse> ListPersonalRepositoryImportRecordsAsync(ListPersonalRepositoryImportRecordsRequest listPersonalRepositoryImportRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/repository-import-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPersonalRepositoryImportRecordsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listPersonalRepositoryImportRecordsResponse = JsonUtils.DeSerializeNull<ListPersonalRepositoryImportRecordsResponse>(response);
            listPersonalRepositoryImportRecordsResponse.Body = JsonUtils.DeSerializeList<RepositoryImportRecordDto>(response);
            return listPersonalRepositoryImportRecordsResponse;
        }

        public AsyncInvoker<ListPersonalRepositoryImportRecordsResponse> ListPersonalRepositoryImportRecordsAsyncInvoker(ListPersonalRepositoryImportRecordsRequest listPersonalRepositoryImportRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/repository-import-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPersonalRepositoryImportRecordsRequest);
            return new AsyncInvoker<ListPersonalRepositoryImportRecordsResponse>(this, "GET", request, response =>
            {
                var listPersonalRepositoryImportRecordsResponse = JsonUtils.DeSerializeNull<ListPersonalRepositoryImportRecordsResponse>(response);
                listPersonalRepositoryImportRecordsResponse.Body = JsonUtils.DeSerializeList<RepositoryImportRecordDto>(response);
                return listPersonalRepositoryImportRecordsResponse;
            });
        }
        
        /// <summary>
        /// 查看仓库提交规则
        ///
        /// 查看仓库提交规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRepositoryCommitRulesResponse> ListRepositoryCommitRulesAsync(ListRepositoryCommitRulesRequest listRepositoryCommitRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryCommitRulesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/commit-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryCommitRulesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listRepositoryCommitRulesResponse = JsonUtils.DeSerializeNull<ListRepositoryCommitRulesResponse>(response);
            listRepositoryCommitRulesResponse.Body = JsonUtils.DeSerializeList<CommitRuleDto>(response);
            return listRepositoryCommitRulesResponse;
        }

        public AsyncInvoker<ListRepositoryCommitRulesResponse> ListRepositoryCommitRulesAsyncInvoker(ListRepositoryCommitRulesRequest listRepositoryCommitRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryCommitRulesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/commit-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryCommitRulesRequest);
            return new AsyncInvoker<ListRepositoryCommitRulesResponse>(this, "GET", request, response =>
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
        public async Task<ListRepositoryContributorsResponse> ListRepositoryContributorsAsync(ListRepositoryContributorsRequest listRepositoryContributorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryContributorsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/contributors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryContributorsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listRepositoryContributorsResponse = JsonUtils.DeSerializeNull<ListRepositoryContributorsResponse>(response);
            listRepositoryContributorsResponse.Body = JsonUtils.DeSerializeList<ContributorDto>(response);
            return listRepositoryContributorsResponse;
        }

        public AsyncInvoker<ListRepositoryContributorsResponse> ListRepositoryContributorsAsyncInvoker(ListRepositoryContributorsRequest listRepositoryContributorsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryContributorsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/contributors", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryContributorsRequest);
            return new AsyncInvoker<ListRepositoryContributorsResponse>(this, "GET", request, response =>
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
        public async Task<ListRepositoryEventsResponse> ListRepositoryEventsAsync(ListRepositoryEventsRequest listRepositoryEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryEventsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryEventsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listRepositoryEventsResponse = JsonUtils.DeSerializeNull<ListRepositoryEventsResponse>(response);
            listRepositoryEventsResponse.Body = JsonUtils.DeSerializeList<RepositoryPushEventDto>(response);
            return listRepositoryEventsResponse;
        }

        public AsyncInvoker<ListRepositoryEventsResponse> ListRepositoryEventsAsyncInvoker(ListRepositoryEventsRequest listRepositoryEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryEventsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryEventsRequest);
            return new AsyncInvoker<ListRepositoryEventsResponse>(this, "GET", request, response =>
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
        public async Task<ListRepositoryForksResponse> ListRepositoryForksAsync(ListRepositoryForksRequest listRepositoryForksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryForksRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/forks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryForksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listRepositoryForksResponse = JsonUtils.DeSerializeNull<ListRepositoryForksResponse>(response);
            listRepositoryForksResponse.Body = JsonUtils.DeSerializeList<ForkRepositoryDto>(response);
            return listRepositoryForksResponse;
        }

        public AsyncInvoker<ListRepositoryForksResponse> ListRepositoryForksAsyncInvoker(ListRepositoryForksRequest listRepositoryForksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryForksRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/forks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryForksRequest);
            return new AsyncInvoker<ListRepositoryForksResponse>(this, "GET", request, response =>
            {
                var listRepositoryForksResponse = JsonUtils.DeSerializeNull<ListRepositoryForksResponse>(response);
                listRepositoryForksResponse.Body = JsonUtils.DeSerializeList<ForkRepositoryDto>(response);
                return listRepositoryForksResponse;
            });
        }
        
        /// <summary>
        /// 获取仓库默认分支语言统计
        ///
        /// 获取仓库默认分支语言统计
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRepositoryLanguagesResponse> ListRepositoryLanguagesAsync(ListRepositoryLanguagesRequest listRepositoryLanguagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryLanguagesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/languages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryLanguagesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRepositoryLanguagesResponse>(response);
        }

        public AsyncInvoker<ListRepositoryLanguagesResponse> ListRepositoryLanguagesAsyncInvoker(ListRepositoryLanguagesRequest listRepositoryLanguagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryLanguagesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/languages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryLanguagesRequest);
            return new AsyncInvoker<ListRepositoryLanguagesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRepositoryLanguagesResponse>);
        }
        
        /// <summary>
        /// 模板仓列表
        ///
        /// 模板仓列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRepositoryTemplatesResponse> ListRepositoryTemplatesAsync(ListRepositoryTemplatesRequest listRepositoryTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/repository-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryTemplatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listRepositoryTemplatesResponse = JsonUtils.DeSerializeNull<ListRepositoryTemplatesResponse>(response);
            listRepositoryTemplatesResponse.Body = JsonUtils.DeSerializeList<RepositoryTemplateDto>(response);
            return listRepositoryTemplatesResponse;
        }

        public AsyncInvoker<ListRepositoryTemplatesResponse> ListRepositoryTemplatesAsyncInvoker(ListRepositoryTemplatesRequest listRepositoryTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/repository-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryTemplatesRequest);
            return new AsyncInvoker<ListRepositoryTemplatesResponse>(this, "GET", request, response =>
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
        public async Task<ListSubmodulesResponse> ListSubmodulesAsync(ListSubmodulesRequest listSubmodulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSubmodulesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/submodules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubmodulesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listSubmodulesResponse = JsonUtils.DeSerializeNull<ListSubmodulesResponse>(response);
            listSubmodulesResponse.Body = JsonUtils.DeSerializeList<SubmoduleDto>(response);
            return listSubmodulesResponse;
        }

        public AsyncInvoker<ListSubmodulesResponse> ListSubmodulesAsyncInvoker(ListSubmodulesRequest listSubmodulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listSubmodulesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/submodules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubmodulesRequest);
            return new AsyncInvoker<ListSubmodulesResponse>(this, "GET", request, response =>
            {
                var listSubmodulesResponse = JsonUtils.DeSerializeNull<ListSubmodulesResponse>(response);
                listSubmodulesResponse.Body = JsonUtils.DeSerializeList<SubmoduleDto>(response);
                return listSubmodulesResponse;
            });
        }
        
        /// <summary>
        /// 查看分支文件列表
        ///
        /// 查看分支文件列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTreesResponse> ListTreesAsync(ListTreesRequest listTreesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTreesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/trees", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTreesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listTreesResponse = JsonUtils.DeSerializeNull<ListTreesResponse>(response);
            listTreesResponse.Body = JsonUtils.DeSerializeList<TreeObjectDto>(response);
            return listTreesResponse;
        }

        public AsyncInvoker<ListTreesResponse> ListTreesAsyncInvoker(ListTreesRequest listTreesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTreesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/trees", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTreesRequest);
            return new AsyncInvoker<ListTreesResponse>(this, "GET", request, response =>
            {
                var listTreesResponse = JsonUtils.DeSerializeNull<ListTreesResponse>(response);
                listTreesResponse.Body = JsonUtils.DeSerializeList<TreeObjectDto>(response);
                return listTreesResponse;
            });
        }
        
        /// <summary>
        /// 获取仓库ip白名单
        ///
        /// 获取仓库ip白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTrustedIpAddressesResponse> ListTrustedIpAddressesAsync(ListTrustedIpAddressesRequest listTrustedIpAddressesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTrustedIpAddressesRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{id}/trusted-ip-addresses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrustedIpAddressesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listTrustedIpAddressesResponse = JsonUtils.DeSerializeNull<ListTrustedIpAddressesResponse>(response);
            listTrustedIpAddressesResponse.Body = JsonUtils.DeSerializeList<TrustedIpAddressDto>(response);
            return listTrustedIpAddressesResponse;
        }

        public AsyncInvoker<ListTrustedIpAddressesResponse> ListTrustedIpAddressesAsyncInvoker(ListTrustedIpAddressesRequest listTrustedIpAddressesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTrustedIpAddressesRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{id}/trusted-ip-addresses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrustedIpAddressesRequest);
            return new AsyncInvoker<ListTrustedIpAddressesResponse>(this, "GET", request, response =>
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
        public async Task<LockRepositoryResponse> LockRepositoryAsync(LockRepositoryRequest lockRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(lockRepositoryRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(lockRepositoryRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/repositories/{repository_id}/lock", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", lockRepositoryRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<LockRepositoryResponse>(response);
        }

        public AsyncInvoker<LockRepositoryResponse> LockRepositoryAsyncInvoker(LockRepositoryRequest lockRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(lockRepositoryRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(lockRepositoryRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/repositories/{repository_id}/lock", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", lockRepositoryRequest);
            return new AsyncInvoker<LockRepositoryResponse>(this, "POST", request, JsonUtils.DeSerialize<LockRepositoryResponse>);
        }
        
        /// <summary>
        /// 删除仓库部署秘钥
        ///
        /// 删除仓库部署秘钥
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RemoveDeployKeyResponse> RemoveDeployKeyAsync(RemoveDeployKeyRequest removeDeployKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeDeployKeyRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(removeDeployKeyRequest.KeyId, out var valueOfKeyId)) urlParam.Add("key_id", valueOfKeyId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/deploy-keys/{key_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeDeployKeyRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<RemoveDeployKeyResponse>(response);
        }

        public AsyncInvoker<RemoveDeployKeyResponse> RemoveDeployKeyAsyncInvoker(RemoveDeployKeyRequest removeDeployKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeDeployKeyRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(removeDeployKeyRequest.KeyId, out var valueOfKeyId)) urlParam.Add("key_id", valueOfKeyId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/deploy-keys/{key_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeDeployKeyRequest);
            return new AsyncInvoker<RemoveDeployKeyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<RemoveDeployKeyResponse>);
        }
        
        /// <summary>
        /// 获取文件内容
        ///
        /// 获取文件内容
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBlobsResponse> ShowBlobsAsync(ShowBlobsRequest showBlobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBlobsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/blobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBlobsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowBlobsResponse>(response);
        }

        public AsyncInvoker<ShowBlobsResponse> ShowBlobsAsyncInvoker(ShowBlobsRequest showBlobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBlobsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/blobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBlobsRequest);
            return new AsyncInvoker<ShowBlobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBlobsResponse>);
        }
        
        /// <summary>
        /// 获取仓库指定分支的提交统计信息
        ///
        /// 获取仓库指定分支的提交统计信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCommitStatisticsResponse> ShowCommitStatisticsAsync(ShowCommitStatisticsRequest showCommitStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCommitStatisticsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/commit-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCommitStatisticsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowCommitStatisticsResponse>(response);
        }

        public AsyncInvoker<ShowCommitStatisticsResponse> ShowCommitStatisticsAsyncInvoker(ShowCommitStatisticsRequest showCommitStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showCommitStatisticsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/commit-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCommitStatisticsRequest);
            return new AsyncInvoker<ShowCommitStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCommitStatisticsResponse>);
        }
        
        /// <summary>
        /// 按行数查询提交文件内容
        ///
        /// 按行数查询提交文件内容，最大显示行数为1000行
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDiffLinesResponse> ShowDiffLinesAsync(ShowDiffLinesRequest showDiffLinesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDiffLinesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/diff-lines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDiffLinesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDiffLinesResponse>(response);
        }

        public AsyncInvoker<ShowDiffLinesResponse> ShowDiffLinesAsyncInvoker(ShowDiffLinesRequest showDiffLinesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDiffLinesRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/diff-lines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDiffLinesRequest);
            return new AsyncInvoker<ShowDiffLinesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDiffLinesResponse>);
        }
        
        /// <summary>
        /// 获取仓库最近推送事件
        ///
        /// 获取仓库最近推送事件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowLastPushEventInRepositoryResponse> ShowLastPushEventInRepositoryAsync(ShowLastPushEventInRepositoryRequest showLastPushEventInRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLastPushEventInRepositoryRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/last-push-event", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLastPushEventInRepositoryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowLastPushEventInRepositoryResponse>(response);
        }

        public AsyncInvoker<ShowLastPushEventInRepositoryResponse> ShowLastPushEventInRepositoryAsyncInvoker(ShowLastPushEventInRepositoryRequest showLastPushEventInRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLastPushEventInRepositoryRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/last-push-event", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLastPushEventInRepositoryRequest);
            return new AsyncInvoker<ShowLastPushEventInRepositoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLastPushEventInRepositoryResponse>);
        }
        
        /// <summary>
        /// 获取仓库通知设置
        ///
        /// 获取仓库通知设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowNotificationSubscriptionResponse> ShowNotificationSubscriptionAsync(ShowNotificationSubscriptionRequest showNotificationSubscriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNotificationSubscriptionRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/notification-subscriptions/subscription", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNotificationSubscriptionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowNotificationSubscriptionResponse>(response);
        }

        public AsyncInvoker<ShowNotificationSubscriptionResponse> ShowNotificationSubscriptionAsyncInvoker(ShowNotificationSubscriptionRequest showNotificationSubscriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNotificationSubscriptionRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/notification-subscriptions/subscription", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNotificationSubscriptionRequest);
            return new AsyncInvoker<ShowNotificationSubscriptionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNotificationSubscriptionResponse>);
        }
        
        /// <summary>
        /// 获取仓库通知设置启用状态
        ///
        /// 获取仓库通知设置启用状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowNotificationSubscriptionsStatusResponse> ShowNotificationSubscriptionsStatusAsync(ShowNotificationSubscriptionsStatusRequest showNotificationSubscriptionsStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNotificationSubscriptionsStatusRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/notification-subscriptions/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNotificationSubscriptionsStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowNotificationSubscriptionsStatusResponse>(response);
        }

        public AsyncInvoker<ShowNotificationSubscriptionsStatusResponse> ShowNotificationSubscriptionsStatusAsyncInvoker(ShowNotificationSubscriptionsStatusRequest showNotificationSubscriptionsStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showNotificationSubscriptionsStatusRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/notification-subscriptions/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNotificationSubscriptionsStatusRequest);
            return new AsyncInvoker<ShowNotificationSubscriptionsStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNotificationSubscriptionsStatusResponse>);
        }
        
        /// <summary>
        /// 分支、tags、提交对比
        ///
        /// 分支、tags、提交对比
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRefCompareResponse> ShowRefCompareAsync(ShowRefCompareRequest showRefCompareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRefCompareRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/compare", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRefCompareRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRefCompareResponse>(response);
        }

        public AsyncInvoker<ShowRefCompareResponse> ShowRefCompareAsyncInvoker(ShowRefCompareRequest showRefCompareRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRefCompareRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/compare", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRefCompareRequest);
            return new AsyncInvoker<ShowRefCompareResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRefCompareResponse>);
        }
        
        /// <summary>
        /// 获取仓库镜像详情
        ///
        /// 获取仓库镜像详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRemoteMirrorResponse> ShowRemoteMirrorAsync(ShowRemoteMirrorRequest showRemoteMirrorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRemoteMirrorRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/remote-mirror", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRemoteMirrorRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRemoteMirrorResponse>(response);
        }

        public AsyncInvoker<ShowRemoteMirrorResponse> ShowRemoteMirrorAsyncInvoker(ShowRemoteMirrorRequest showRemoteMirrorRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRemoteMirrorRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/remote-mirror", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRemoteMirrorRequest);
            return new AsyncInvoker<ShowRemoteMirrorResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRemoteMirrorResponse>);
        }
        
        /// <summary>
        /// 获取仓库详情
        ///
        /// 获取仓库详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRepositoryResponse> ShowRepositoryAsync(ShowRepositoryRequest showRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRepositoryResponse>(response);
        }

        public AsyncInvoker<ShowRepositoryResponse> ShowRepositoryAsyncInvoker(ShowRepositoryRequest showRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryRequest);
            return new AsyncInvoker<ShowRepositoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepositoryResponse>);
        }
        
        /// <summary>
        /// 查看仓库通用提交规则
        ///
        /// 查看仓库通用提交规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRepositoryGeneralCommitRuleResponse> ShowRepositoryGeneralCommitRuleAsync(ShowRepositoryGeneralCommitRuleRequest showRepositoryGeneralCommitRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryGeneralCommitRuleRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/general-commit-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryGeneralCommitRuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRepositoryGeneralCommitRuleResponse>(response);
        }

        public AsyncInvoker<ShowRepositoryGeneralCommitRuleResponse> ShowRepositoryGeneralCommitRuleAsyncInvoker(ShowRepositoryGeneralCommitRuleRequest showRepositoryGeneralCommitRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryGeneralCommitRuleRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/general-commit-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryGeneralCommitRuleRequest);
            return new AsyncInvoker<ShowRepositoryGeneralCommitRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepositoryGeneralCommitRuleResponse>);
        }
        
        /// <summary>
        /// 查看仓库通用策略
        ///
        /// 查看仓库通用策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRepositoryGeneralPolicyResponse> ShowRepositoryGeneralPolicyAsync(ShowRepositoryGeneralPolicyRequest showRepositoryGeneralPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryGeneralPolicyRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/general-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryGeneralPolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRepositoryGeneralPolicyResponse>(response);
        }

        public AsyncInvoker<ShowRepositoryGeneralPolicyResponse> ShowRepositoryGeneralPolicyAsyncInvoker(ShowRepositoryGeneralPolicyRequest showRepositoryGeneralPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryGeneralPolicyRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/general-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryGeneralPolicyRequest);
            return new AsyncInvoker<ShowRepositoryGeneralPolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepositoryGeneralPolicyResponse>);
        }
        
        /// <summary>
        /// 查看仓库继承设置
        ///
        /// 查看仓库继承设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRepositoryInheritSettingResponse> ShowRepositoryInheritSettingAsync(ShowRepositoryInheritSettingRequest showRepositoryInheritSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryInheritSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/inherit-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryInheritSettingRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var showRepositoryInheritSettingResponse = JsonUtils.DeSerializeNull<ShowRepositoryInheritSettingResponse>(response);
            showRepositoryInheritSettingResponse.Body = JsonUtils.DeSerializeList<RepositoryInheritSettingDto>(response);
            return showRepositoryInheritSettingResponse;
        }

        public AsyncInvoker<ShowRepositoryInheritSettingResponse> ShowRepositoryInheritSettingAsyncInvoker(ShowRepositoryInheritSettingRequest showRepositoryInheritSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryInheritSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/inherit-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryInheritSettingRequest);
            return new AsyncInvoker<ShowRepositoryInheritSettingResponse>(this, "GET", request, response =>
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
        public async Task<ShowRepositoryInheritSettingSourceResponse> ShowRepositoryInheritSettingSourceAsync(ShowRepositoryInheritSettingSourceRequest showRepositoryInheritSettingSourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryInheritSettingSourceRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/inherit-setting-source", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryInheritSettingSourceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRepositoryInheritSettingSourceResponse>(response);
        }

        public AsyncInvoker<ShowRepositoryInheritSettingSourceResponse> ShowRepositoryInheritSettingSourceAsyncInvoker(ShowRepositoryInheritSettingSourceRequest showRepositoryInheritSettingSourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryInheritSettingSourceRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/inherit-setting-source", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryInheritSettingSourceRequest);
            return new AsyncInvoker<ShowRepositoryInheritSettingSourceResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepositoryInheritSettingSourceResponse>);
        }
        
        /// <summary>
        /// 获取仓库统计任务状态
        ///
        /// 获取仓库统计任务状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRepositoryStatisticsStatusResponse> ShowRepositoryStatisticsStatusAsync(ShowRepositoryStatisticsStatusRequest showRepositoryStatisticsStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryStatisticsStatusRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/statistics-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryStatisticsStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRepositoryStatisticsStatusResponse>(response);
        }

        public AsyncInvoker<ShowRepositoryStatisticsStatusResponse> ShowRepositoryStatisticsStatusAsyncInvoker(ShowRepositoryStatisticsStatusRequest showRepositoryStatisticsStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryStatisticsStatusRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/statistics-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryStatisticsStatusRequest);
            return new AsyncInvoker<ShowRepositoryStatisticsStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepositoryStatisticsStatusResponse>);
        }
        
        /// <summary>
        /// 获取仓库统计摘要
        ///
        /// 获取仓库统计摘要
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRepositoryStatisticsSummaryResponse> ShowRepositoryStatisticsSummaryAsync(ShowRepositoryStatisticsSummaryRequest showRepositoryStatisticsSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryStatisticsSummaryRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/statistics-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryStatisticsSummaryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRepositoryStatisticsSummaryResponse>(response);
        }

        public AsyncInvoker<ShowRepositoryStatisticsSummaryResponse> ShowRepositoryStatisticsSummaryAsyncInvoker(ShowRepositoryStatisticsSummaryRequest showRepositoryStatisticsSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryStatisticsSummaryRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/statistics-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryStatisticsSummaryRequest);
            return new AsyncInvoker<ShowRepositoryStatisticsSummaryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepositoryStatisticsSummaryResponse>);
        }
        
        /// <summary>
        /// 获取仓库水印设置
        ///
        /// 获取仓库水印设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRepositoryWatermarkResponse> ShowRepositoryWatermarkAsync(ShowRepositoryWatermarkRequest showRepositoryWatermarkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryWatermarkRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryWatermarkRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRepositoryWatermarkResponse>(response);
        }

        public AsyncInvoker<ShowRepositoryWatermarkResponse> ShowRepositoryWatermarkAsyncInvoker(ShowRepositoryWatermarkRequest showRepositoryWatermarkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryWatermarkRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryWatermarkRequest);
            return new AsyncInvoker<ShowRepositoryWatermarkResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepositoryWatermarkResponse>);
        }
        
        /// <summary>
        /// 获取CR仓库用户分支或标签级权限
        ///
        /// 获取CR仓库用户分支或标签级权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowUserRefPermissionResponse> ShowUserRefPermissionAsync(ShowUserRefPermissionRequest showUserRefPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUserRefPermissionRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/user-ref-permission", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserRefPermissionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowUserRefPermissionResponse>(response);
        }

        public AsyncInvoker<ShowUserRefPermissionResponse> ShowUserRefPermissionAsyncInvoker(ShowUserRefPermissionRequest showUserRefPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showUserRefPermissionRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/user-ref-permission", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserRefPermissionRequest);
            return new AsyncInvoker<ShowUserRefPermissionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUserRefPermissionResponse>);
        }
        
        /// <summary>
        /// 启动仓库镜像同步
        ///
        /// 启动仓库镜像同步
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StartRemoteMirrorSynchronizationResponse> StartRemoteMirrorSynchronizationAsync(StartRemoteMirrorSynchronizationRequest startRemoteMirrorSynchronizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startRemoteMirrorSynchronizationRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/remote-mirror", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startRemoteMirrorSynchronizationRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StartRemoteMirrorSynchronizationResponse>(response);
        }

        public AsyncInvoker<StartRemoteMirrorSynchronizationResponse> StartRemoteMirrorSynchronizationAsyncInvoker(StartRemoteMirrorSynchronizationRequest startRemoteMirrorSynchronizationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startRemoteMirrorSynchronizationRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/remote-mirror", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startRemoteMirrorSynchronizationRequest);
            return new AsyncInvoker<StartRemoteMirrorSynchronizationResponse>(this, "POST", request, JsonUtils.DeSerialize<StartRemoteMirrorSynchronizationResponse>);
        }
        
        /// <summary>
        /// 解锁仓库
        ///
        /// 解锁仓库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UnlockRepositoryResponse> UnlockRepositoryAsync(UnlockRepositoryRequest unlockRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(unlockRepositoryRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(unlockRepositoryRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/repositories/{repository_id}/unlock", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unlockRepositoryRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UnlockRepositoryResponse>(response);
        }

        public AsyncInvoker<UnlockRepositoryResponse> UnlockRepositoryAsyncInvoker(UnlockRepositoryRequest unlockRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(unlockRepositoryRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(unlockRepositoryRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/{project_id}/repositories/{repository_id}/unlock", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", unlockRepositoryRequest);
            return new AsyncInvoker<UnlockRepositoryResponse>(this, "POST", request, JsonUtils.DeSerialize<UnlockRepositoryResponse>);
        }
        
        /// <summary>
        /// 修改仓库通知设置
        ///
        /// 修改仓库通知设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateNotificationSubscriptionResponse> UpdateNotificationSubscriptionAsync(UpdateNotificationSubscriptionRequest updateNotificationSubscriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateNotificationSubscriptionRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/notification-subscriptions/subscription", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNotificationSubscriptionRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateNotificationSubscriptionResponse>(response);
        }

        public AsyncInvoker<UpdateNotificationSubscriptionResponse> UpdateNotificationSubscriptionAsyncInvoker(UpdateNotificationSubscriptionRequest updateNotificationSubscriptionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateNotificationSubscriptionRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/notification-subscriptions/subscription", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNotificationSubscriptionRequest);
            return new AsyncInvoker<UpdateNotificationSubscriptionResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateNotificationSubscriptionResponse>);
        }
        
        /// <summary>
        /// 修改仓库通用策略
        ///
        /// 修改仓库通用策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRepositoryGeneralPolicyResponse> UpdateRepositoryGeneralPolicyAsync(UpdateRepositoryGeneralPolicyRequest updateRepositoryGeneralPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryGeneralPolicyRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/general-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepositoryGeneralPolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRepositoryGeneralPolicyResponse>(response);
        }

        public AsyncInvoker<UpdateRepositoryGeneralPolicyResponse> UpdateRepositoryGeneralPolicyAsyncInvoker(UpdateRepositoryGeneralPolicyRequest updateRepositoryGeneralPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryGeneralPolicyRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/general-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepositoryGeneralPolicyRequest);
            return new AsyncInvoker<UpdateRepositoryGeneralPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRepositoryGeneralPolicyResponse>);
        }
        
        /// <summary>
        /// 修改仓库继承设置
        ///
        /// 修改仓库继承设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRepositoryInheritSettingResponse> UpdateRepositoryInheritSettingAsync(UpdateRepositoryInheritSettingRequest updateRepositoryInheritSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryInheritSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/inherit-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepositoryInheritSettingRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            var updateRepositoryInheritSettingResponse = JsonUtils.DeSerializeNull<UpdateRepositoryInheritSettingResponse>(response);
            updateRepositoryInheritSettingResponse.Body = JsonUtils.DeSerializeList<RepositoryInheritSettingDto>(response);
            return updateRepositoryInheritSettingResponse;
        }

        public AsyncInvoker<UpdateRepositoryInheritSettingResponse> UpdateRepositoryInheritSettingAsyncInvoker(UpdateRepositoryInheritSettingRequest updateRepositoryInheritSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryInheritSettingRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/inherit-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepositoryInheritSettingRequest);
            return new AsyncInvoker<UpdateRepositoryInheritSettingResponse>(this, "PUT", request, response =>
            {
                var updateRepositoryInheritSettingResponse = JsonUtils.DeSerializeNull<UpdateRepositoryInheritSettingResponse>(response);
                updateRepositoryInheritSettingResponse.Body = JsonUtils.DeSerializeList<RepositoryInheritSettingDto>(response);
                return updateRepositoryInheritSettingResponse;
            });
        }
        
        /// <summary>
        /// 更新仓库水印设置
        ///
        /// 更新仓库水印设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRepositoryWatermarkResponse> UpdateRepositoryWatermarkAsync(UpdateRepositoryWatermarkRequest updateRepositoryWatermarkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryWatermarkRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepositoryWatermarkRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRepositoryWatermarkResponse>(response);
        }

        public AsyncInvoker<UpdateRepositoryWatermarkResponse> UpdateRepositoryWatermarkAsyncInvoker(UpdateRepositoryWatermarkRequest updateRepositoryWatermarkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryWatermarkRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/watermark", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepositoryWatermarkRequest);
            return new AsyncInvoker<UpdateRepositoryWatermarkResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRepositoryWatermarkResponse>);
        }
        
        /// <summary>
        /// 修改仓库ip白名单
        ///
        /// 修改仓库ip白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateTrustedIpAddressResponse> UpdateTrustedIpAddressAsync(UpdateTrustedIpAddressRequest updateTrustedIpAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTrustedIpAddressRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            if (StringUtils.TryConvertToNonEmptyString(updateTrustedIpAddressRequest.IpId, out var valueOfIpId)) urlParam.Add("ip_id", valueOfIpId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{id}/trusted-ip-addresses/{ip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTrustedIpAddressRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateTrustedIpAddressResponse>(response);
        }

        public AsyncInvoker<UpdateTrustedIpAddressResponse> UpdateTrustedIpAddressAsyncInvoker(UpdateTrustedIpAddressRequest updateTrustedIpAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTrustedIpAddressRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            if (StringUtils.TryConvertToNonEmptyString(updateTrustedIpAddressRequest.IpId, out var valueOfIpId)) urlParam.Add("ip_id", valueOfIpId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{id}/trusted-ip-addresses/{ip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTrustedIpAddressRequest);
            return new AsyncInvoker<UpdateTrustedIpAddressResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateTrustedIpAddressResponse>);
        }
        
        /// <summary>
        /// 创建标签
        ///
        /// 创建标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTagResponse> CreateTagAsync(CreateTagRequest createTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTagRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateTagResponse>(response);
        }

        public AsyncInvoker<CreateTagResponse> CreateTagAsyncInvoker(CreateTagRequest createTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTagRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagRequest);
            return new AsyncInvoker<CreateTagResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTagResponse>);
        }
        
        /// <summary>
        /// 删除标签
        ///
        /// 删除标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTagResponse> DeleteTagAsync(DeleteTagRequest deleteTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTagRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTagResponse>(response);
        }

        public AsyncInvoker<DeleteTagResponse> DeleteTagAsyncInvoker(DeleteTagRequest deleteTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTagRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagRequest);
            return new AsyncInvoker<DeleteTagResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTagResponse>);
        }
        
        /// <summary>
        /// 获取标签列表
        ///
        /// 获取标签列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTagsResponse> ListTagsAsync(ListTagsRequest listTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTagsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listTagsResponse = JsonUtils.DeSerializeNull<ListTagsResponse>(response);
            listTagsResponse.Body = JsonUtils.DeSerializeList<SimpleTagDto>(response);
            return listTagsResponse;
        }

        public AsyncInvoker<ListTagsResponse> ListTagsAsyncInvoker(ListTagsRequest listTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTagsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsRequest);
            return new AsyncInvoker<ListTagsResponse>(this, "GET", request, response =>
            {
                var listTagsResponse = JsonUtils.DeSerializeNull<ListTagsResponse>(response);
                listTagsResponse.Body = JsonUtils.DeSerializeList<SimpleTagDto>(response);
                return listTagsResponse;
            });
        }
        
        /// <summary>
        /// 查看标签详情
        ///
        /// 查看标签详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTagResponse> ShowTagAsync(ShowTagRequest showTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTagRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTagRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTagResponse>(response);
        }

        public AsyncInvoker<ShowTagResponse> ShowTagAsyncInvoker(ShowTagRequest showTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTagRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/repository/tag", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTagRequest);
            return new AsyncInvoker<ShowTagResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTagResponse>);
        }
        
        /// <summary>
        /// 添加租户ip白名单
        ///
        /// 添加租户ip白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddTenantTrustedIpAddressResponse> AddTenantTrustedIpAddressAsync(AddTenantTrustedIpAddressRequest addTenantTrustedIpAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/tenant/trusted-ip-addresses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addTenantTrustedIpAddressRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddTenantTrustedIpAddressResponse>(response);
        }

        public AsyncInvoker<AddTenantTrustedIpAddressResponse> AddTenantTrustedIpAddressAsyncInvoker(AddTenantTrustedIpAddressRequest addTenantTrustedIpAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/tenant/trusted-ip-addresses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addTenantTrustedIpAddressRequest);
            return new AsyncInvoker<AddTenantTrustedIpAddressResponse>(this, "POST", request, JsonUtils.DeSerialize<AddTenantTrustedIpAddressResponse>);
        }
        
        /// <summary>
        /// 删除租户ip白名单
        ///
        /// 删除租户ip白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTenantTrustedIpAddressResponse> DeleteTenantTrustedIpAddressAsync(DeleteTenantTrustedIpAddressRequest deleteTenantTrustedIpAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTenantTrustedIpAddressRequest.IpId, out var valueOfIpId)) urlParam.Add("ip_id", valueOfIpId);
            var urlPath = HttpUtils.AddUrlPath("/v4/tenant/trusted-ip-addresses/{ip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTenantTrustedIpAddressRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteTenantTrustedIpAddressResponse>(response);
        }

        public AsyncInvoker<DeleteTenantTrustedIpAddressResponse> DeleteTenantTrustedIpAddressAsyncInvoker(DeleteTenantTrustedIpAddressRequest deleteTenantTrustedIpAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTenantTrustedIpAddressRequest.IpId, out var valueOfIpId)) urlParam.Add("ip_id", valueOfIpId);
            var urlPath = HttpUtils.AddUrlPath("/v4/tenant/trusted-ip-addresses/{ip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTenantTrustedIpAddressRequest);
            return new AsyncInvoker<DeleteTenantTrustedIpAddressResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteTenantTrustedIpAddressResponse>);
        }
        
        /// <summary>
        /// 获取租户ip白名单
        ///
        /// 获取租户ip白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTenantTrustedIpAddressesResponse> ListTenantTrustedIpAddressesAsync(ListTenantTrustedIpAddressesRequest listTenantTrustedIpAddressesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/tenant/trusted-ip-addresses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantTrustedIpAddressesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listTenantTrustedIpAddressesResponse = JsonUtils.DeSerializeNull<ListTenantTrustedIpAddressesResponse>(response);
            listTenantTrustedIpAddressesResponse.Body = JsonUtils.DeSerializeList<TenantTrustedIpAddressDto>(response);
            return listTenantTrustedIpAddressesResponse;
        }

        public AsyncInvoker<ListTenantTrustedIpAddressesResponse> ListTenantTrustedIpAddressesAsyncInvoker(ListTenantTrustedIpAddressesRequest listTenantTrustedIpAddressesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/tenant/trusted-ip-addresses", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantTrustedIpAddressesRequest);
            return new AsyncInvoker<ListTenantTrustedIpAddressesResponse>(this, "GET", request, response =>
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
        public async Task<UpdateTenantTrustedIpAddressResponse> UpdateTenantTrustedIpAddressAsync(UpdateTenantTrustedIpAddressRequest updateTenantTrustedIpAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTenantTrustedIpAddressRequest.IpId, out var valueOfIpId)) urlParam.Add("ip_id", valueOfIpId);
            var urlPath = HttpUtils.AddUrlPath("/v4/tenant/trusted-ip-addresses/{ip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTenantTrustedIpAddressRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateTenantTrustedIpAddressResponse>(response);
        }

        public AsyncInvoker<UpdateTenantTrustedIpAddressResponse> UpdateTenantTrustedIpAddressAsyncInvoker(UpdateTenantTrustedIpAddressRequest updateTenantTrustedIpAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTenantTrustedIpAddressRequest.IpId, out var valueOfIpId)) urlParam.Add("ip_id", valueOfIpId);
            var urlPath = HttpUtils.AddUrlPath("/v4/tenant/trusted-ip-addresses/{ip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTenantTrustedIpAddressRequest);
            return new AsyncInvoker<UpdateTenantTrustedIpAddressResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateTenantTrustedIpAddressResponse>);
        }
        
        /// <summary>
        /// 校验部署秘钥在上层代码组或项目是否配置
        ///
        /// 校验部署秘钥在上层代码组或项目是否配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckDeployKeyResponse> CheckDeployKeyAsync(CheckDeployKeyRequest checkDeployKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkDeployKeyRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/deploy-keys/check-key", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkDeployKeyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CheckDeployKeyResponse>(response);
        }

        public AsyncInvoker<CheckDeployKeyResponse> CheckDeployKeyAsyncInvoker(CheckDeployKeyRequest checkDeployKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkDeployKeyRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/deploy-keys/check-key", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkDeployKeyRequest);
            return new AsyncInvoker<CheckDeployKeyResponse>(this, "POST", request, JsonUtils.DeSerialize<CheckDeployKeyResponse>);
        }
        
        /// <summary>
        /// 校验代码组部署秘钥在上层代码组或项目是否配置
        ///
        /// 校验代码组部署秘钥在上层代码组或项目是否配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckGroupDeployKeyResponse> CheckGroupDeployKeyAsync(CheckGroupDeployKeyRequest checkGroupDeployKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkGroupDeployKeyRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/deploy-keys/check-key", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkGroupDeployKeyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CheckGroupDeployKeyResponse>(response);
        }

        public AsyncInvoker<CheckGroupDeployKeyResponse> CheckGroupDeployKeyAsyncInvoker(CheckGroupDeployKeyRequest checkGroupDeployKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkGroupDeployKeyRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/deploy-keys/check-key", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkGroupDeployKeyRequest);
            return new AsyncInvoker<CheckGroupDeployKeyResponse>(this, "POST", request, JsonUtils.DeSerialize<CheckGroupDeployKeyResponse>);
        }
        
        /// <summary>
        /// 获取仓库下指定分支的关联工作项列表
        ///
        /// 获取仓库下指定分支的关联工作项列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBranchRelatedWorkItemsResponse> ListBranchRelatedWorkItemsAsync(ListBranchRelatedWorkItemsRequest listBranchRelatedWorkItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBranchRelatedWorkItemsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/branch/work-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBranchRelatedWorkItemsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listBranchRelatedWorkItemsResponse = JsonUtils.DeSerializeNull<ListBranchRelatedWorkItemsResponse>(response);
            listBranchRelatedWorkItemsResponse.Body = JsonUtils.DeSerializeList<WorkItemSimpleDto>(response);
            return listBranchRelatedWorkItemsResponse;
        }

        public AsyncInvoker<ListBranchRelatedWorkItemsResponse> ListBranchRelatedWorkItemsAsyncInvoker(ListBranchRelatedWorkItemsRequest listBranchRelatedWorkItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBranchRelatedWorkItemsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/branch/work-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBranchRelatedWorkItemsRequest);
            return new AsyncInvoker<ListBranchRelatedWorkItemsResponse>(this, "GET", request, response =>
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
        public async Task<ListGroupDeployKeysResponse> ListGroupDeployKeysAsync(ListGroupDeployKeysRequest listGroupDeployKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupDeployKeysRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/deploy-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupDeployKeysRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listGroupDeployKeysResponse = JsonUtils.DeSerializeNull<ListGroupDeployKeysResponse>(response);
            listGroupDeployKeysResponse.Body = JsonUtils.DeSerializeList<DeployKeyDto>(response);
            return listGroupDeployKeysResponse;
        }

        public AsyncInvoker<ListGroupDeployKeysResponse> ListGroupDeployKeysAsyncInvoker(ListGroupDeployKeysRequest listGroupDeployKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupDeployKeysRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/deploy-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupDeployKeysRequest);
            return new AsyncInvoker<ListGroupDeployKeysResponse>(this, "GET", request, response =>
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
        public async Task<ListProjectDeployKeysResponse> ListProjectDeployKeysAsync(ListProjectDeployKeysRequest listProjectDeployKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectDeployKeysRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/deploy-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectDeployKeysRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listProjectDeployKeysResponse = JsonUtils.DeSerializeNull<ListProjectDeployKeysResponse>(response);
            listProjectDeployKeysResponse.Body = JsonUtils.DeSerializeList<DeployKeyDto>(response);
            return listProjectDeployKeysResponse;
        }

        public AsyncInvoker<ListProjectDeployKeysResponse> ListProjectDeployKeysAsyncInvoker(ListProjectDeployKeysRequest listProjectDeployKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectDeployKeysRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/deploy-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectDeployKeysRequest);
            return new AsyncInvoker<ListProjectDeployKeysResponse>(this, "GET", request, response =>
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
        public async Task<ListRepositoryDeployKeysResponse> ListRepositoryDeployKeysAsync(ListRepositoryDeployKeysRequest listRepositoryDeployKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryDeployKeysRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/deploy-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryDeployKeysRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listRepositoryDeployKeysResponse = JsonUtils.DeSerializeNull<ListRepositoryDeployKeysResponse>(response);
            listRepositoryDeployKeysResponse.Body = JsonUtils.DeSerializeList<DeployKeyDto>(response);
            return listRepositoryDeployKeysResponse;
        }

        public AsyncInvoker<ListRepositoryDeployKeysResponse> ListRepositoryDeployKeysAsyncInvoker(ListRepositoryDeployKeysRequest listRepositoryDeployKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryDeployKeysRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/deploy-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryDeployKeysRequest);
            return new AsyncInvoker<ListRepositoryDeployKeysResponse>(this, "GET", request, response =>
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
        public async Task<ListRepositoryWorkItemsResponse> ListRepositoryWorkItemsAsync(ListRepositoryWorkItemsRequest listRepositoryWorkItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryWorkItemsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/work-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryWorkItemsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listRepositoryWorkItemsResponse = JsonUtils.DeSerializeNull<ListRepositoryWorkItemsResponse>(response);
            listRepositoryWorkItemsResponse.Body = JsonUtils.DeSerializeList<ReqWorkItemDto>(response);
            return listRepositoryWorkItemsResponse;
        }

        public AsyncInvoker<ListRepositoryWorkItemsResponse> ListRepositoryWorkItemsAsyncInvoker(ListRepositoryWorkItemsRequest listRepositoryWorkItemsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryWorkItemsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/work-items", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryWorkItemsRequest);
            return new AsyncInvoker<ListRepositoryWorkItemsResponse>(this, "GET", request, response =>
            {
                var listRepositoryWorkItemsResponse = JsonUtils.DeSerializeNull<ListRepositoryWorkItemsResponse>(response);
                listRepositoryWorkItemsResponse.Body = JsonUtils.DeSerializeList<ReqWorkItemDto>(response);
                return listRepositoryWorkItemsResponse;
            });
        }
        
        /// <summary>
        /// 添加ssh公钥
        ///
        /// 添加ssh公钥
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddSshKeyResponse> AddSshKeyAsync(AddSshKeyRequest addSshKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addSshKeyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddSshKeyResponse>(response);
        }

        public AsyncInvoker<AddSshKeyResponse> AddSshKeyAsyncInvoker(AddSshKeyRequest addSshKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addSshKeyRequest);
            return new AsyncInvoker<AddSshKeyResponse>(this, "POST", request, JsonUtils.DeSerialize<AddSshKeyResponse>);
        }
        
        /// <summary>
        /// 删除ssh公钥
        ///
        /// 删除ssh公钥
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSshKeyResponse> DeleteSshKeyAsync(DeleteSshKeyRequest deleteSshKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSshKeyRequest.KeyId, out var valueOfKeyId)) urlParam.Add("key_id", valueOfKeyId);
            var urlPath = HttpUtils.AddUrlPath("/v4/user/keys/{key_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSshKeyRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSshKeyResponse>(response);
        }

        public AsyncInvoker<DeleteSshKeyResponse> DeleteSshKeyAsyncInvoker(DeleteSshKeyRequest deleteSshKeyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSshKeyRequest.KeyId, out var valueOfKeyId)) urlParam.Add("key_id", valueOfKeyId);
            var urlPath = HttpUtils.AddUrlPath("/v4/user/keys/{key_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSshKeyRequest);
            return new AsyncInvoker<DeleteSshKeyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSshKeyResponse>);
        }
        
        /// <summary>
        /// 获取当前用户的gpg_key列表
        ///
        /// 获取当前用户的gpg_key列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListUserGpgKeysResponse> ListUserGpgKeysAsync(ListUserGpgKeysRequest listUserGpgKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/gpg-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserGpgKeysRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListUserGpgKeysResponse>(response);
        }

        public AsyncInvoker<ListUserGpgKeysResponse> ListUserGpgKeysAsyncInvoker(ListUserGpgKeysRequest listUserGpgKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/gpg-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserGpgKeysRequest);
            return new AsyncInvoker<ListUserGpgKeysResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUserGpgKeysResponse>);
        }
        
        /// <summary>
        /// 获取当前用户的秘钥列表
        ///
        /// 获取当前用户的秘钥列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListUserKeysResponse> ListUserKeysAsync(ListUserKeysRequest listUserKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserKeysRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListUserKeysResponse>(response);
        }

        public AsyncInvoker<ListUserKeysResponse> ListUserKeysAsyncInvoker(ListUserKeysRequest listUserKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserKeysRequest);
            return new AsyncInvoker<ListUserKeysResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUserKeysResponse>);
        }
        
        /// <summary>
        /// 发送邮箱验证码
        ///
        /// 发送邮箱验证码
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SendUserEmailVerifyCodeResponse> SendUserEmailVerifyCodeAsync(SendUserEmailVerifyCodeRequest sendUserEmailVerifyCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/email-verify-code", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendUserEmailVerifyCodeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<SendUserEmailVerifyCodeResponse>(response);
        }

        public AsyncInvoker<SendUserEmailVerifyCodeResponse> SendUserEmailVerifyCodeAsyncInvoker(SendUserEmailVerifyCodeRequest sendUserEmailVerifyCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/email-verify-code", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", sendUserEmailVerifyCodeRequest);
            return new AsyncInvoker<SendUserEmailVerifyCodeResponse>(this, "POST", request, JsonUtils.DeSerialize<SendUserEmailVerifyCodeResponse>);
        }
        
        /// <summary>
        /// 获取https的验证方式
        ///
        /// 获取https的验证方式
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowHttpsPasswordSettingResponse> ShowHttpsPasswordSettingAsync(ShowHttpsPasswordSettingRequest showHttpsPasswordSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/https-password-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHttpsPasswordSettingRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerializeNull<ShowHttpsPasswordSettingResponse>(response);
        }

        public AsyncInvoker<ShowHttpsPasswordSettingResponse> ShowHttpsPasswordSettingAsyncInvoker(ShowHttpsPasswordSettingRequest showHttpsPasswordSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/https-password-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHttpsPasswordSettingRequest);
            return new AsyncInvoker<ShowHttpsPasswordSettingResponse>(this, "GET", request, JsonUtils.DeSerializeNull<ShowHttpsPasswordSettingResponse>);
        }
        
        /// <summary>
        /// 获取用户相关邮箱信息
        ///
        /// 获取用户相关邮箱信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowUserEmailsResponse> ShowUserEmailsAsync(ShowUserEmailsRequest showUserEmailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/emails", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserEmailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowUserEmailsResponse>(response);
        }

        public AsyncInvoker<ShowUserEmailsResponse> ShowUserEmailsAsyncInvoker(ShowUserEmailsRequest showUserEmailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/emails", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserEmailsRequest);
            return new AsyncInvoker<ShowUserEmailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUserEmailsResponse>);
        }
        
        /// <summary>
        /// 修改https的验证方式
        ///
        /// 修改https的验证方式
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateHttpsPasswordSettingResponse> UpdateHttpsPasswordSettingAsync(UpdateHttpsPasswordSettingRequest updateHttpsPasswordSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/https-password-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHttpsPasswordSettingRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateHttpsPasswordSettingResponse>(response);
        }

        public AsyncInvoker<UpdateHttpsPasswordSettingResponse> UpdateHttpsPasswordSettingAsyncInvoker(UpdateHttpsPasswordSettingRequest updateHttpsPasswordSettingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/https-password-setting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHttpsPasswordSettingRequest);
            return new AsyncInvoker<UpdateHttpsPasswordSettingResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateHttpsPasswordSettingResponse>);
        }
        
        /// <summary>
        /// 更新邮箱
        ///
        /// 更新邮箱
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateUserEmailsResponse> UpdateUserEmailsAsync(UpdateUserEmailsRequest updateUserEmailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/emails", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserEmailsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateUserEmailsResponse>(response);
        }

        public AsyncInvoker<UpdateUserEmailsResponse> UpdateUserEmailsAsyncInvoker(UpdateUserEmailsRequest updateUserEmailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v4/user/emails", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUserEmailsRequest);
            return new AsyncInvoker<UpdateUserEmailsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateUserEmailsResponse>);
        }
        
        /// <summary>
        /// 添加代码组下Webhook
        ///
        /// 添加代码组下Webhook
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddGroupWebhookResponse> AddGroupWebhookAsync(AddGroupWebhookRequest addGroupWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addGroupWebhookRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/hooks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addGroupWebhookRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddGroupWebhookResponse>(response);
        }

        public AsyncInvoker<AddGroupWebhookResponse> AddGroupWebhookAsyncInvoker(AddGroupWebhookRequest addGroupWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addGroupWebhookRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/hooks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addGroupWebhookRequest);
            return new AsyncInvoker<AddGroupWebhookResponse>(this, "POST", request, JsonUtils.DeSerialize<AddGroupWebhookResponse>);
        }
        
        /// <summary>
        /// 添加项目下Webhook
        ///
        /// 添加项目下Webhook
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddProjectWebhookResponse> AddProjectWebhookAsync(AddProjectWebhookRequest addProjectWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addProjectWebhookRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/hooks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addProjectWebhookRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddProjectWebhookResponse>(response);
        }

        public AsyncInvoker<AddProjectWebhookResponse> AddProjectWebhookAsyncInvoker(AddProjectWebhookRequest addProjectWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addProjectWebhookRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/hooks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addProjectWebhookRequest);
            return new AsyncInvoker<AddProjectWebhookResponse>(this, "POST", request, JsonUtils.DeSerialize<AddProjectWebhookResponse>);
        }
        
        /// <summary>
        /// 添加仓库下Webhook
        ///
        /// 添加仓库下Webhook
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AddRepositoryWebhookResponse> AddRepositoryWebhookAsync(AddRepositoryWebhookRequest addRepositoryWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addRepositoryWebhookRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/hooks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addRepositoryWebhookRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AddRepositoryWebhookResponse>(response);
        }

        public AsyncInvoker<AddRepositoryWebhookResponse> AddRepositoryWebhookAsyncInvoker(AddRepositoryWebhookRequest addRepositoryWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(addRepositoryWebhookRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/hooks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", addRepositoryWebhookRequest);
            return new AsyncInvoker<AddRepositoryWebhookResponse>(this, "POST", request, JsonUtils.DeSerialize<AddRepositoryWebhookResponse>);
        }
        
        /// <summary>
        /// 获取代码组下指定Webhook的日志列表
        ///
        /// 获取代码组下指定Webhook的日志列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGroupWebhookLogsResponse> ListGroupWebhookLogsAsync(ListGroupWebhookLogsRequest listGroupWebhookLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupWebhookLogsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(listGroupWebhookLogsRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/hooks/{hook_id}/logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupWebhookLogsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listGroupWebhookLogsResponse = JsonUtils.DeSerializeNull<ListGroupWebhookLogsResponse>(response);
            listGroupWebhookLogsResponse.Body = JsonUtils.DeSerializeList<WebhookLogExtendDto>(response);
            return listGroupWebhookLogsResponse;
        }

        public AsyncInvoker<ListGroupWebhookLogsResponse> ListGroupWebhookLogsAsyncInvoker(ListGroupWebhookLogsRequest listGroupWebhookLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupWebhookLogsRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(listGroupWebhookLogsRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/hooks/{hook_id}/logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupWebhookLogsRequest);
            return new AsyncInvoker<ListGroupWebhookLogsResponse>(this, "GET", request, response =>
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
        public async Task<ListGroupWebhooksResponse> ListGroupWebhooksAsync(ListGroupWebhooksRequest listGroupWebhooksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupWebhooksRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/hooks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupWebhooksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listGroupWebhooksResponse = JsonUtils.DeSerializeNull<ListGroupWebhooksResponse>(response);
            listGroupWebhooksResponse.Body = JsonUtils.DeSerializeList<WebhookDto>(response);
            return listGroupWebhooksResponse;
        }

        public AsyncInvoker<ListGroupWebhooksResponse> ListGroupWebhooksAsyncInvoker(ListGroupWebhooksRequest listGroupWebhooksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listGroupWebhooksRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/hooks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGroupWebhooksRequest);
            return new AsyncInvoker<ListGroupWebhooksResponse>(this, "GET", request, response =>
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
        public async Task<ListProjectWebhookLogsResponse> ListProjectWebhookLogsAsync(ListProjectWebhookLogsRequest listProjectWebhookLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectWebhookLogsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listProjectWebhookLogsRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/hooks/{hook_id}/logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectWebhookLogsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listProjectWebhookLogsResponse = JsonUtils.DeSerializeNull<ListProjectWebhookLogsResponse>(response);
            listProjectWebhookLogsResponse.Body = JsonUtils.DeSerializeList<WebhookLogExtendDto>(response);
            return listProjectWebhookLogsResponse;
        }

        public AsyncInvoker<ListProjectWebhookLogsResponse> ListProjectWebhookLogsAsyncInvoker(ListProjectWebhookLogsRequest listProjectWebhookLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectWebhookLogsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listProjectWebhookLogsRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/hooks/{hook_id}/logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectWebhookLogsRequest);
            return new AsyncInvoker<ListProjectWebhookLogsResponse>(this, "GET", request, response =>
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
        public async Task<ListProjectWebhooksResponse> ListProjectWebhooksAsync(ListProjectWebhooksRequest listProjectWebhooksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectWebhooksRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/hooks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectWebhooksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listProjectWebhooksResponse = JsonUtils.DeSerializeNull<ListProjectWebhooksResponse>(response);
            listProjectWebhooksResponse.Body = JsonUtils.DeSerializeList<WebhookDto>(response);
            return listProjectWebhooksResponse;
        }

        public AsyncInvoker<ListProjectWebhooksResponse> ListProjectWebhooksAsyncInvoker(ListProjectWebhooksRequest listProjectWebhooksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectWebhooksRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/hooks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectWebhooksRequest);
            return new AsyncInvoker<ListProjectWebhooksResponse>(this, "GET", request, response =>
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
        public async Task<ListRepositoryWebhookLogsResponse> ListRepositoryWebhookLogsAsync(ListRepositoryWebhookLogsRequest listRepositoryWebhookLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryWebhookLogsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryWebhookLogsRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/hooks/{hook_id}/logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryWebhookLogsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listRepositoryWebhookLogsResponse = JsonUtils.DeSerializeNull<ListRepositoryWebhookLogsResponse>(response);
            listRepositoryWebhookLogsResponse.Body = JsonUtils.DeSerializeList<WebhookLogDto>(response);
            return listRepositoryWebhookLogsResponse;
        }

        public AsyncInvoker<ListRepositoryWebhookLogsResponse> ListRepositoryWebhookLogsAsyncInvoker(ListRepositoryWebhookLogsRequest listRepositoryWebhookLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryWebhookLogsRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryWebhookLogsRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/hooks/{hook_id}/logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryWebhookLogsRequest);
            return new AsyncInvoker<ListRepositoryWebhookLogsResponse>(this, "GET", request, response =>
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
        public async Task<ListRepositoryWebhooksResponse> ListRepositoryWebhooksAsync(ListRepositoryWebhooksRequest listRepositoryWebhooksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryWebhooksRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/hooks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryWebhooksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listRepositoryWebhooksResponse = JsonUtils.DeSerializeNull<ListRepositoryWebhooksResponse>(response);
            listRepositoryWebhooksResponse.Body = JsonUtils.DeSerializeList<WebhookDto>(response);
            return listRepositoryWebhooksResponse;
        }

        public AsyncInvoker<ListRepositoryWebhooksResponse> ListRepositoryWebhooksAsyncInvoker(ListRepositoryWebhooksRequest listRepositoryWebhooksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRepositoryWebhooksRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/hooks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryWebhooksRequest);
            return new AsyncInvoker<ListRepositoryWebhooksResponse>(this, "GET", request, response =>
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
        public async Task<RemoveGroupWebhookResponse> RemoveGroupWebhookAsync(RemoveGroupWebhookRequest removeGroupWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeGroupWebhookRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(removeGroupWebhookRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeGroupWebhookRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<RemoveGroupWebhookResponse>(response);
        }

        public AsyncInvoker<RemoveGroupWebhookResponse> RemoveGroupWebhookAsyncInvoker(RemoveGroupWebhookRequest removeGroupWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeGroupWebhookRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(removeGroupWebhookRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeGroupWebhookRequest);
            return new AsyncInvoker<RemoveGroupWebhookResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<RemoveGroupWebhookResponse>);
        }
        
        /// <summary>
        /// 删除项目下单个Webhook
        ///
        /// 删除项目下单个Webhook
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RemoveProjectWebhookResponse> RemoveProjectWebhookAsync(RemoveProjectWebhookRequest removeProjectWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeProjectWebhookRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(removeProjectWebhookRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeProjectWebhookRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<RemoveProjectWebhookResponse>(response);
        }

        public AsyncInvoker<RemoveProjectWebhookResponse> RemoveProjectWebhookAsyncInvoker(RemoveProjectWebhookRequest removeProjectWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeProjectWebhookRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(removeProjectWebhookRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeProjectWebhookRequest);
            return new AsyncInvoker<RemoveProjectWebhookResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<RemoveProjectWebhookResponse>);
        }
        
        /// <summary>
        /// 删除仓库下单个Webhook
        ///
        /// 删除仓库下单个Webhook
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RemoveRepositoryWebhookResponse> RemoveRepositoryWebhookAsync(RemoveRepositoryWebhookRequest removeRepositoryWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeRepositoryWebhookRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(removeRepositoryWebhookRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeRepositoryWebhookRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<RemoveRepositoryWebhookResponse>(response);
        }

        public AsyncInvoker<RemoveRepositoryWebhookResponse> RemoveRepositoryWebhookAsyncInvoker(RemoveRepositoryWebhookRequest removeRepositoryWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeRepositoryWebhookRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(removeRepositoryWebhookRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeRepositoryWebhookRequest);
            return new AsyncInvoker<RemoveRepositoryWebhookResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<RemoveRepositoryWebhookResponse>);
        }
        
        /// <summary>
        /// 获取代码组下单个Webhook数据
        ///
        /// 获取代码组下单个Webhook数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowGroupWebhookResponse> ShowGroupWebhookAsync(ShowGroupWebhookRequest showGroupWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupWebhookRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(showGroupWebhookRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupWebhookRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowGroupWebhookResponse>(response);
        }

        public AsyncInvoker<ShowGroupWebhookResponse> ShowGroupWebhookAsyncInvoker(ShowGroupWebhookRequest showGroupWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupWebhookRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(showGroupWebhookRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupWebhookRequest);
            return new AsyncInvoker<ShowGroupWebhookResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGroupWebhookResponse>);
        }
        
        /// <summary>
        /// 获取代码组下指定Webhook的指定日志详情
        ///
        /// 获取代码组下指定Webhook的指定日志详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowGroupWebhookLogResponse> ShowGroupWebhookLogAsync(ShowGroupWebhookLogRequest showGroupWebhookLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupWebhookLogRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(showGroupWebhookLogRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            if (StringUtils.TryConvertToNonEmptyString(showGroupWebhookLogRequest.LogId, out var valueOfLogId)) urlParam.Add("log_id", valueOfLogId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/hooks/{hook_id}/logs/{log_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupWebhookLogRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowGroupWebhookLogResponse>(response);
        }

        public AsyncInvoker<ShowGroupWebhookLogResponse> ShowGroupWebhookLogAsyncInvoker(ShowGroupWebhookLogRequest showGroupWebhookLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showGroupWebhookLogRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(showGroupWebhookLogRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            if (StringUtils.TryConvertToNonEmptyString(showGroupWebhookLogRequest.LogId, out var valueOfLogId)) urlParam.Add("log_id", valueOfLogId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/hooks/{hook_id}/logs/{log_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showGroupWebhookLogRequest);
            return new AsyncInvoker<ShowGroupWebhookLogResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowGroupWebhookLogResponse>);
        }
        
        /// <summary>
        /// 获取项目下单个Webhook数据
        ///
        /// 获取项目下单个Webhook数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowProjectWebhookResponse> ShowProjectWebhookAsync(ShowProjectWebhookRequest showProjectWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectWebhookRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showProjectWebhookRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectWebhookRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectWebhookResponse>(response);
        }

        public AsyncInvoker<ShowProjectWebhookResponse> ShowProjectWebhookAsyncInvoker(ShowProjectWebhookRequest showProjectWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectWebhookRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showProjectWebhookRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectWebhookRequest);
            return new AsyncInvoker<ShowProjectWebhookResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectWebhookResponse>);
        }
        
        /// <summary>
        /// 获取项目下指定Webhook的指定日志详情
        ///
        /// 获取项目下指定Webhook的指定日志详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowProjectWebhookLogResponse> ShowProjectWebhookLogAsync(ShowProjectWebhookLogRequest showProjectWebhookLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectWebhookLogRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showProjectWebhookLogRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            if (StringUtils.TryConvertToNonEmptyString(showProjectWebhookLogRequest.LogId, out var valueOfLogId)) urlParam.Add("log_id", valueOfLogId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/hooks/{hook_id}/logs/{log_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectWebhookLogRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectWebhookLogResponse>(response);
        }

        public AsyncInvoker<ShowProjectWebhookLogResponse> ShowProjectWebhookLogAsyncInvoker(ShowProjectWebhookLogRequest showProjectWebhookLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectWebhookLogRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showProjectWebhookLogRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            if (StringUtils.TryConvertToNonEmptyString(showProjectWebhookLogRequest.LogId, out var valueOfLogId)) urlParam.Add("log_id", valueOfLogId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/hooks/{hook_id}/logs/{log_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectWebhookLogRequest);
            return new AsyncInvoker<ShowProjectWebhookLogResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectWebhookLogResponse>);
        }
        
        /// <summary>
        /// 获取仓库下单个Webhook数据
        ///
        /// 获取仓库下单个Webhook数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRepositoryWebhookResponse> ShowRepositoryWebhookAsync(ShowRepositoryWebhookRequest showRepositoryWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryWebhookRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryWebhookRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryWebhookRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRepositoryWebhookResponse>(response);
        }

        public AsyncInvoker<ShowRepositoryWebhookResponse> ShowRepositoryWebhookAsyncInvoker(ShowRepositoryWebhookRequest showRepositoryWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryWebhookRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryWebhookRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryWebhookRequest);
            return new AsyncInvoker<ShowRepositoryWebhookResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepositoryWebhookResponse>);
        }
        
        /// <summary>
        /// 获取仓库下指定Webhook的指定日志详情
        ///
        /// 获取仓库下指定Webhook的指定日志详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRepositoryWebhookLogResponse> ShowRepositoryWebhookLogAsync(ShowRepositoryWebhookLogRequest showRepositoryWebhookLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryWebhookLogRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryWebhookLogRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryWebhookLogRequest.LogId, out var valueOfLogId)) urlParam.Add("log_id", valueOfLogId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/hooks/{hook_id}/logs/{log_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryWebhookLogRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRepositoryWebhookLogResponse>(response);
        }

        public AsyncInvoker<ShowRepositoryWebhookLogResponse> ShowRepositoryWebhookLogAsyncInvoker(ShowRepositoryWebhookLogRequest showRepositoryWebhookLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryWebhookLogRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryWebhookLogRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            if (StringUtils.TryConvertToNonEmptyString(showRepositoryWebhookLogRequest.LogId, out var valueOfLogId)) urlParam.Add("log_id", valueOfLogId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/hooks/{hook_id}/logs/{log_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRepositoryWebhookLogRequest);
            return new AsyncInvoker<ShowRepositoryWebhookLogResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRepositoryWebhookLogResponse>);
        }
        
        /// <summary>
        /// 更新代码组下单个Webhook数据
        ///
        /// 更新代码组下单个Webhook数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateGroupWebhookResponse> UpdateGroupWebhookAsync(UpdateGroupWebhookRequest updateGroupWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateGroupWebhookRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(updateGroupWebhookRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGroupWebhookRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateGroupWebhookResponse>(response);
        }

        public AsyncInvoker<UpdateGroupWebhookResponse> UpdateGroupWebhookAsyncInvoker(UpdateGroupWebhookRequest updateGroupWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateGroupWebhookRequest.GroupId, out var valueOfGroupId)) urlParam.Add("group_id", valueOfGroupId);
            if (StringUtils.TryConvertToNonEmptyString(updateGroupWebhookRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/groups/{group_id}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateGroupWebhookRequest);
            return new AsyncInvoker<UpdateGroupWebhookResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateGroupWebhookResponse>);
        }
        
        /// <summary>
        /// 更新项目下单个Webhook数据
        ///
        /// 更新项目下单个Webhook数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateProjectWebhookResponse> UpdateProjectWebhookAsync(UpdateProjectWebhookRequest updateProjectWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProjectWebhookRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(updateProjectWebhookRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProjectWebhookRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateProjectWebhookResponse>(response);
        }

        public AsyncInvoker<UpdateProjectWebhookResponse> UpdateProjectWebhookAsyncInvoker(UpdateProjectWebhookRequest updateProjectWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateProjectWebhookRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(updateProjectWebhookRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/projects/{project_id}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProjectWebhookRequest);
            return new AsyncInvoker<UpdateProjectWebhookResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateProjectWebhookResponse>);
        }
        
        /// <summary>
        /// 更新仓库下单个Webhook数据
        ///
        /// 更新仓库下单个Webhook数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRepositoryWebhookResponse> UpdateRepositoryWebhookAsync(UpdateRepositoryWebhookRequest updateRepositoryWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryWebhookRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryWebhookRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepositoryWebhookRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRepositoryWebhookResponse>(response);
        }

        public AsyncInvoker<UpdateRepositoryWebhookResponse> UpdateRepositoryWebhookAsyncInvoker(UpdateRepositoryWebhookRequest updateRepositoryWebhookRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryWebhookRequest.RepositoryId, out var valueOfRepositoryId)) urlParam.Add("repository_id", valueOfRepositoryId);
            if (StringUtils.TryConvertToNonEmptyString(updateRepositoryWebhookRequest.HookId, out var valueOfHookId)) urlParam.Add("hook_id", valueOfHookId);
            var urlPath = HttpUtils.AddUrlPath("/v4/repositories/{repository_id}/hooks/{hook_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRepositoryWebhookRequest);
            return new AsyncInvoker<UpdateRepositoryWebhookResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRepositoryWebhookResponse>);
        }
        
    }
}