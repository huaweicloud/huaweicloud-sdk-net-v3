using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.AntiDDoS.V2.Model;

namespace HuaweiCloud.SDK.AntiDDoS.V2
{
    public partial class AntiDDoSAsyncClient : Client
    {
        public static ClientBuilder<AntiDDoSAsyncClient> NewBuilder()
        {
            return new ClientBuilder<AntiDDoSAsyncClient>();
        }

        
        /// <summary>
        /// 查询告警配置信息
        ///
        /// 查询用户配置信息，用户可以通过此接口查询是否接收某类告警，同时可以配置是手机短信还是电子邮件接收告警信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAlertConfigResponse> ShowAlertConfigAsync(ShowAlertConfigRequest showAlertConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/warnalert/alertconfig/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAlertConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAlertConfigResponse>(response);
        }

        public AsyncInvoker<ShowAlertConfigResponse> ShowAlertConfigAsyncInvoker(ShowAlertConfigRequest showAlertConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/warnalert/alertconfig/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAlertConfigRequest);
            return new AsyncInvoker<ShowAlertConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAlertConfigResponse>);
        }
        
        /// <summary>
        /// 更新告警配置信息
        ///
        /// 更新用户配置信息，用户可以通过此接口更新是否接收某类告警，同时可以配置是手机短信还是电子邮件接收告警信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAlertConfigResponse> UpdateAlertConfigAsync(UpdateAlertConfigRequest updateAlertConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/warnalert/alertconfig/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlertConfigRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateAlertConfigResponse>(response);
        }

        public AsyncInvoker<UpdateAlertConfigResponse> UpdateAlertConfigAsyncInvoker(UpdateAlertConfigRequest updateAlertConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/warnalert/alertconfig/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlertConfigRequest);
            return new AsyncInvoker<UpdateAlertConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateAlertConfigResponse>);
        }
        
        /// <summary>
        /// 查询EIP防护状态列表
        ///
        /// 查询用户所有EIP的Anti-DDoS防护状态信息，用户的EIP无论是否绑定到云服务器，都可以进行查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDDosStatusResponse> ListDDosStatusAsync(ListDDosStatusRequest listDDosStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/antiddos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDDosStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDDosStatusResponse>(response);
        }

        public AsyncInvoker<ListDDosStatusResponse> ListDDosStatusAsyncInvoker(ListDDosStatusRequest listDDosStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/antiddos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDDosStatusRequest);
            return new AsyncInvoker<ListDDosStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDDosStatusResponse>);
        }
        
        /// <summary>
        /// 查询Anti-DDoS配置可选范围
        ///
        /// 查询系统支持的Anti-DDoS防护策略配置的可选范围，用户根据范围列表选择适合自已业务的防护策略进行Anti-DDoS流量清洗。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNewConfigsResponse> ListNewConfigsAsync(ListNewConfigsRequest listNewConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/antiddos/query-config-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNewConfigsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListNewConfigsResponse>(response);
        }

        public AsyncInvoker<ListNewConfigsResponse> ListNewConfigsAsyncInvoker(ListNewConfigsRequest listNewConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/antiddos/query-config-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNewConfigsRequest);
            return new AsyncInvoker<ListNewConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNewConfigsResponse>);
        }
        
        /// <summary>
        /// 查询Anti-DDoS任务
        ///
        /// 用户查询指定的Anti-DDoS防护配置任务，得到任务当前执行的状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowNewTaskStatusResponse> ShowNewTaskStatusAsync(ShowNewTaskStatusRequest showNewTaskStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/query-task-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNewTaskStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowNewTaskStatusResponse>(response);
        }

        public AsyncInvoker<ShowNewTaskStatusResponse> ShowNewTaskStatusAsyncInvoker(ShowNewTaskStatusRequest showNewTaskStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/query-task-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNewTaskStatusRequest);
            return new AsyncInvoker<ShowNewTaskStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNewTaskStatusResponse>);
        }
        
    }
}