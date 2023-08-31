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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agent-status/batch-query",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgentStatusRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListAgentStatusResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agent-invocations/batch-create",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateAgentInvocationsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<BatchCreateAgentInvocationsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/agent-invocations",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgentInvocationsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAgentInvocationsResponse>(response);
        }
        
    }
}