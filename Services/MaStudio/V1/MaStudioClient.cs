using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.MaStudio.V1.Model;

namespace HuaweiCloud.SDK.MaStudio.V1
{
    public partial class MaStudioClient : Client
    {
        public static ClientBuilder<MaStudioClient> NewBuilder()
        {
            return new ClientBuilder<MaStudioClient>();
        }

        
        /// <summary>
        /// 对话问答
        ///
        /// 基于对话问答功能，用户可以与模型进行自然而流畅的对话和交流。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExecuteChatCompletionResponse ExecuteChatCompletion(ExecuteChatCompletionRequest executeChatCompletionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeChatCompletionRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/deployments/{deployment_id}/chat/completions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeChatCompletionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExecuteChatCompletionResponse>(response);
        }

        public SyncInvoker<ExecuteChatCompletionResponse> ExecuteChatCompletionInvoker(ExecuteChatCompletionRequest executeChatCompletionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeChatCompletionRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/deployments/{deployment_id}/chat/completions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeChatCompletionRequest);
            return new SyncInvoker<ExecuteChatCompletionResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteChatCompletionResponse>);
        }
        
        /// <summary>
        /// 通用文本
        ///
        /// 给定一个提示和一些参数，模型会根据这些信息生成一个或多个预测的补全，还可以返回每个位置上不同词语的概率。它可以用来做文本生成、自动写作、代码补全等任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExecuteTextCompletionResponse ExecuteTextCompletion(ExecuteTextCompletionRequest executeTextCompletionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeTextCompletionRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/deployments/{deployment_id}/text/completions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeTextCompletionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExecuteTextCompletionResponse>(response);
        }

        public SyncInvoker<ExecuteTextCompletionResponse> ExecuteTextCompletionInvoker(ExecuteTextCompletionRequest executeTextCompletionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(executeTextCompletionRequest.DeploymentId, out var valueOfDeploymentId)) urlParam.Add("deployment_id", valueOfDeploymentId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/deployments/{deployment_id}/text/completions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeTextCompletionRequest);
            return new SyncInvoker<ExecuteTextCompletionResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteTextCompletionResponse>);
        }
        
    }
}