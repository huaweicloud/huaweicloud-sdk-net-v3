using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.PanguLargeModels.V1.Model;

namespace HuaweiCloud.SDK.PanguLargeModels.V1
{
    public partial class PanguLargeModelsAsyncClient : Client
    {
        public static ClientBuilder<PanguLargeModelsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<PanguLargeModelsAsyncClient>();
        }

        
        /// <summary>
        /// 对话问答
        ///
        /// 基于对话问答功能，用户可以与模型进行自然而流畅的对话和交流。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExecuteChatCompletionResponse> ExecuteChatCompletionAsync(ExecuteChatCompletionRequest executeChatCompletionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("deployment_id", executeChatCompletionRequest.DeploymentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/deployments/{deployment_id}/chat/completions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeChatCompletionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExecuteChatCompletionResponse>(response);
        }

        public AsyncInvoker<ExecuteChatCompletionResponse> ExecuteChatCompletionAsyncInvoker(ExecuteChatCompletionRequest executeChatCompletionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("deployment_id", executeChatCompletionRequest.DeploymentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/deployments/{deployment_id}/chat/completions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeChatCompletionRequest);
            return new AsyncInvoker<ExecuteChatCompletionResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteChatCompletionResponse>);
        }
        
        /// <summary>
        /// 通用文本
        ///
        /// 给定一个提示和一些参数，模型会根据这些信息生成一个或多个预测的补全，还可以返回每个位置上不同词语的概率。它可以用来做文本生成、自动写作、代码补全等任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExecuteTextCompletionResponse> ExecuteTextCompletionAsync(ExecuteTextCompletionRequest executeTextCompletionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("deployment_id", executeTextCompletionRequest.DeploymentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/deployments/{deployment_id}/text/completions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeTextCompletionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExecuteTextCompletionResponse>(response);
        }

        public AsyncInvoker<ExecuteTextCompletionResponse> ExecuteTextCompletionAsyncInvoker(ExecuteTextCompletionRequest executeTextCompletionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("deployment_id", executeTextCompletionRequest.DeploymentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/deployments/{deployment_id}/text/completions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeTextCompletionRequest);
            return new AsyncInvoker<ExecuteTextCompletionResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteTextCompletionResponse>);
        }
        
    }
}