using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Versatile.V1.Model;

namespace HuaweiCloud.SDK.Versatile.V1
{
    public partial class VersatileClient : Client
    {
        public static ClientBuilder<VersatileClient> NewBuilder()
        {
            return new ClientBuilder<VersatileClient>();
        }

        
        /// <summary>
        /// 知识库检索
        ///
        /// 提供多知识库并行检索能力，支持语义、关键词、混合及FAQ四种检索模式，并允许自定义相似度阈值与返回结果数量，实现精准高效的信息匹配。
        /// 
        /// **适用场景**：
        /// - 同时从多个知识库或文档集合中搜索相关内容。
        /// - 在预设的问答列表中快速定位最相关的答案（FAQ检索）。
        /// - 通过混合模式或调整阈值，兼顾搜索结果的准确性和全面性。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchKnowledgeBaseResponse SearchKnowledgeBase(SearchKnowledgeBaseRequest searchKnowledgeBaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/knowledge-bases/retrieve", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchKnowledgeBaseRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<SearchKnowledgeBaseResponse>(response);
        }

        public SyncInvoker<SearchKnowledgeBaseResponse> SearchKnowledgeBaseInvoker(SearchKnowledgeBaseRequest searchKnowledgeBaseRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/knowledge-bases/retrieve", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchKnowledgeBaseRequest);
            return new SyncInvoker<SearchKnowledgeBaseResponse>(this, "POST", request, JsonUtils.DeSerialize<SearchKnowledgeBaseResponse>);
        }
        
        /// <summary>
        /// 运行一个智能体
        ///
        /// 运行一个智能体，支持流式和非流式
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunAgentResponse RunAgent(RunAgentRequest runAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runAgentRequest.AgentId, out var valueOfAgentId)) urlParam.Add("agent_id", valueOfAgentId);
            if (StringUtils.TryConvertToNonEmptyString(runAgentRequest.ConversationId, out var valueOfConversationId)) urlParam.Add("conversation_id", valueOfConversationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/agents/{agent_id}/conversations/{conversation_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runAgentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RunAgentResponse>(response);
        }

        public SyncInvoker<RunAgentResponse> RunAgentInvoker(RunAgentRequest runAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runAgentRequest.AgentId, out var valueOfAgentId)) urlParam.Add("agent_id", valueOfAgentId);
            if (StringUtils.TryConvertToNonEmptyString(runAgentRequest.ConversationId, out var valueOfConversationId)) urlParam.Add("conversation_id", valueOfConversationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/agents/{agent_id}/conversations/{conversation_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runAgentRequest);
            return new SyncInvoker<RunAgentResponse>(this, "POST", request, JsonUtils.DeSerialize<RunAgentResponse>);
        }
        
        /// <summary>
        /// 运行一个工作流
        ///
        /// 运行一个工作流，支持流式和非流式
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunWorkflowResponse RunWorkflow(RunWorkflowRequest runWorkflowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runWorkflowRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            if (StringUtils.TryConvertToNonEmptyString(runWorkflowRequest.ConversationId, out var valueOfConversationId)) urlParam.Add("conversation_id", valueOfConversationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/workflows/{workflow_id}/conversations/{conversation_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runWorkflowRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RunWorkflowResponse>(response);
        }

        public SyncInvoker<RunWorkflowResponse> RunWorkflowInvoker(RunWorkflowRequest runWorkflowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runWorkflowRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            if (StringUtils.TryConvertToNonEmptyString(runWorkflowRequest.ConversationId, out var valueOfConversationId)) urlParam.Add("conversation_id", valueOfConversationId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/workflows/{workflow_id}/conversations/{conversation_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runWorkflowRequest);
            return new SyncInvoker<RunWorkflowResponse>(this, "POST", request, JsonUtils.DeSerialize<RunWorkflowResponse>);
        }
        
        /// <summary>
        /// 上传文件
        ///
        /// 上传文件，以供agent或者工作流使用
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UploadAgentFileResponse UploadAgentFile(UploadAgentFileRequest uploadAgentFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/agent-runtime/upload-file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadAgentFileRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UploadAgentFileResponse>(response);
        }

        public SyncInvoker<UploadAgentFileResponse> UploadAgentFileInvoker(UploadAgentFileRequest uploadAgentFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/agent-runtime/upload-file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadAgentFileRequest);
            return new SyncInvoker<UploadAgentFileResponse>(this, "POST", request, JsonUtils.DeSerialize<UploadAgentFileResponse>);
        }
        
    }
}