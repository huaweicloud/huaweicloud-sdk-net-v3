using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Ces.V3.Model;

namespace HuaweiCloud.SDK.Ces.V3
{
    public partial class CesAsyncClient : Client
    {
        public static ClientBuilder<CesAsyncClient> NewBuilder()
        {
            return new ClientBuilder<CesAsyncClient>();
        }

        
        /// <summary>
        /// 插件状态查询
        ///
        /// 插件状态查询，包括uniagent状态以及插件状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAgentStatusResponse> ListAgentStatusAsync(ListAgentStatusRequest listAgentStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agent-status/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgentStatusRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListAgentStatusResponse>(response);
        }

        public AsyncInvoker<ListAgentStatusResponse> ListAgentStatusAsyncInvoker(ListAgentStatusRequest listAgentStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agent-status/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgentStatusRequest);
            return new AsyncInvoker<ListAgentStatusResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAgentStatusResponse>);
        }
        
        /// <summary>
        /// 批量创建Agent任务
        ///
        /// 批量创建Agent任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateAgentInvocationsResponse> BatchCreateAgentInvocationsAsync(BatchCreateAgentInvocationsRequest batchCreateAgentInvocationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agent-invocations/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateAgentInvocationsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchCreateAgentInvocationsResponse>(response);
        }

        public AsyncInvoker<BatchCreateAgentInvocationsResponse> BatchCreateAgentInvocationsAsyncInvoker(BatchCreateAgentInvocationsRequest batchCreateAgentInvocationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agent-invocations/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateAgentInvocationsRequest);
            return new AsyncInvoker<BatchCreateAgentInvocationsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreateAgentInvocationsResponse>);
        }
        
        /// <summary>
        /// 查询Agent任务列表
        ///
        /// 查询Agent任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAgentInvocationsResponse> ListAgentInvocationsAsync(ListAgentInvocationsRequest listAgentInvocationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agent-invocations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgentInvocationsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAgentInvocationsResponse>(response);
        }

        public AsyncInvoker<ListAgentInvocationsResponse> ListAgentInvocationsAsyncInvoker(ListAgentInvocationsRequest listAgentInvocationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agent-invocations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgentInvocationsRequest);
            return new AsyncInvoker<ListAgentInvocationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAgentInvocationsResponse>);
        }
        
    }
}