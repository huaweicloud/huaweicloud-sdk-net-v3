using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Ces.V3.Model;

namespace HuaweiCloud.SDK.Ces.V3
{
    public partial class CesClient : Client
    {
        public static ClientBuilder<CesClient> NewBuilder()
        {
            return new ClientBuilder<CesClient>();
        }

        
        /// <summary>
        /// 插件状态查询
        ///
        /// 插件状态查询，包括uniagent状态以及插件状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAgentStatusResponse ListAgentStatus(ListAgentStatusRequest listAgentStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agent-status/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgentStatusRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListAgentStatusResponse>(response);
        }

        public SyncInvoker<ListAgentStatusResponse> ListAgentStatusInvoker(ListAgentStatusRequest listAgentStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agent-status/batch-query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgentStatusRequest);
            return new SyncInvoker<ListAgentStatusResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAgentStatusResponse>);
        }
        
        /// <summary>
        /// 批量创建Agent任务
        ///
        /// 批量创建Agent任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateAgentInvocationsResponse BatchCreateAgentInvocations(BatchCreateAgentInvocationsRequest batchCreateAgentInvocationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agent-invocations/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateAgentInvocationsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchCreateAgentInvocationsResponse>(response);
        }

        public SyncInvoker<BatchCreateAgentInvocationsResponse> BatchCreateAgentInvocationsInvoker(BatchCreateAgentInvocationsRequest batchCreateAgentInvocationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agent-invocations/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateAgentInvocationsRequest);
            return new SyncInvoker<BatchCreateAgentInvocationsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreateAgentInvocationsResponse>);
        }
        
        /// <summary>
        /// 查询Agent任务列表
        ///
        /// 查询Agent任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAgentInvocationsResponse ListAgentInvocations(ListAgentInvocationsRequest listAgentInvocationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agent-invocations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgentInvocationsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAgentInvocationsResponse>(response);
        }

        public SyncInvoker<ListAgentInvocationsResponse> ListAgentInvocationsInvoker(ListAgentInvocationsRequest listAgentInvocationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agent-invocations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgentInvocationsRequest);
            return new SyncInvoker<ListAgentInvocationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAgentInvocationsResponse>);
        }
        
    }
}