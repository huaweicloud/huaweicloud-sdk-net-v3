using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Aom.V4.Model;

namespace HuaweiCloud.SDK.Aom.V4
{
    public partial class AomAsyncClient : Client
    {
        public static ClientBuilder<AomAsyncClient> NewBuilder()
        {
            return new ClientBuilder<AomAsyncClient>();
        }

        
        /// <summary>
        /// 下发批量安装UniAgent任务
        ///
        /// 该接口用于下发批量安装UniAgent任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchImportAgentResponse> BatchImportAgentAsync(BatchImportAgentRequest batchImportAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/uniagent-console/mainview/batch-import", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchImportAgentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchImportAgentResponse>(response);
        }

        public AsyncInvoker<BatchImportAgentResponse> BatchImportAgentAsyncInvoker(BatchImportAgentRequest batchImportAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/uniagent-console/mainview/batch-import", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchImportAgentRequest);
            return new AsyncInvoker<BatchImportAgentResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchImportAgentResponse>);
        }
        
        /// <summary>
        /// 下发批量升级UniAgent任务
        ///
        /// 该接口用于下发批量升级UniAgent任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUpdateAgentResponse> BatchUpdateAgentAsync(BatchUpdateAgentRequest batchUpdateAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/uniagent-console/upgrade/batch-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateAgentRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchUpdateAgentResponse>(response);
        }

        public AsyncInvoker<BatchUpdateAgentResponse> BatchUpdateAgentAsyncInvoker(BatchUpdateAgentRequest batchUpdateAgentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/uniagent-console/upgrade/batch-upgrade", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateAgentRequest);
            return new AsyncInvoker<BatchUpdateAgentResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchUpdateAgentResponse>);
        }
        
        /// <summary>
        /// 查询UniAgent主机列表信息
        ///
        /// 该接口用于查询执行过安装UniAgent任务的主机列表信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAgentInfosResponse> ShowAgentInfosAsync(ShowAgentInfosRequest showAgentInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/uniagent-console/agent-list/all", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAgentInfosRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShowAgentInfosResponse>(response);
        }

        public AsyncInvoker<ShowAgentInfosResponse> ShowAgentInfosAsyncInvoker(ShowAgentInfosRequest showAgentInfosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/uniagent-console/agent-list/all", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAgentInfosRequest);
            return new AsyncInvoker<ShowAgentInfosResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowAgentInfosResponse>);
        }
        
    }
}