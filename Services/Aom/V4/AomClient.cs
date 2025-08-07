using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Aom.V4.Model;

namespace HuaweiCloud.SDK.Aom.V4
{
    public partial class AomClient : Client
    {
        public static ClientBuilder<AomClient> NewBuilder()
        {
            return new ClientBuilder<AomClient>();
        }

        
        /// <summary>
        /// 下发批量安装UniAgent任务
        ///
        /// 该接口用于下发批量安装UniAgent任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchImportAgentResponse BatchImportAgent(BatchImportAgentRequest batchImportAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/uniagent-console/mainview/batch-import", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchImportAgentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchImportAgentResponse>(response);
        }

        public SyncInvoker<BatchImportAgentResponse> BatchImportAgentInvoker(BatchImportAgentRequest batchImportAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/uniagent-console/mainview/batch-import", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchImportAgentRequest);
            return new SyncInvoker<BatchImportAgentResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchImportAgentResponse>);
        }
        
        /// <summary>
        /// 下发批量升级UniAgent任务
        ///
        /// 该接口用于下发批量升级UniAgent任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchUpdateAgentResponse BatchUpdateAgent(BatchUpdateAgentRequest batchUpdateAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/uniagent-console/upgrade/batch-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateAgentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchUpdateAgentResponse>(response);
        }

        public SyncInvoker<BatchUpdateAgentResponse> BatchUpdateAgentInvoker(BatchUpdateAgentRequest batchUpdateAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/uniagent-console/upgrade/batch-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateAgentRequest);
            return new SyncInvoker<BatchUpdateAgentResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchUpdateAgentResponse>);
        }
        
        /// <summary>
        /// 查询UniAgent主机列表信息
        ///
        /// 该接口用于查询执行过安装UniAgent任务的主机列表信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAgentInfosResponse ShowAgentInfos(ShowAgentInfosRequest showAgentInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/uniagent-console/agent-list/all", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAgentInfosRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowAgentInfosResponse>(response);
        }

        public SyncInvoker<ShowAgentInfosResponse> ShowAgentInfosInvoker(ShowAgentInfosRequest showAgentInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/uniagent-console/agent-list/all", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAgentInfosRequest);
            return new SyncInvoker<ShowAgentInfosResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowAgentInfosResponse>);
        }
        
    }
}