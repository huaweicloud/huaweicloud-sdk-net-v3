using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.AntiDDoS.V1.Model;

namespace HuaweiCloud.SDK.AntiDDoS.V1
{
    public partial class AntiDDoSAsyncClient : Client
    {
        public static ClientBuilder<AntiDDoSAsyncClient> NewBuilder()
        {
            return new ClientBuilder<AntiDDoSAsyncClient>();
        }

        
        /// <summary>
        /// 配置Anti-DDoS默认防护策略
        ///
        /// 配置用户的默认防护策略。配置防护策略后，新购买的资源在自动开启防护时，会按照该默认防护策略进行配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDefaultConfigResponse> CreateDefaultConfigAsync(CreateDefaultConfigRequest createDefaultConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos/default-config",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDefaultConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateDefaultConfigResponse>(response);
        }
        
        /// <summary>
        /// 删除Ani-DDoS默认防护策略
        ///
        /// 删除用户配置的默认防护策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDefaultConfigResponse> DeleteDefaultConfigAsync(DeleteDefaultConfigRequest deleteDefaultConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos/default-config",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDefaultConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteDefaultConfigResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/warnalert/alertconfig/query",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAlertConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAlertConfigResponse>(response);
        }
        
        /// <summary>
        /// 查询Ani-DDoS默认防护策略
        ///
        /// 查询用户配置的默认防护策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDefaultConfigResponse> ShowDefaultConfigAsync(ShowDefaultConfigRequest showDefaultConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos/default-config",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDefaultConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDefaultConfigResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/warnalert/alertconfig/update",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlertConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<UpdateAlertConfigResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDDosStatusRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDDosStatusResponse>(response);
        }
        
        /// <summary>
        /// 查询指定EIP异常事件
        ///
        /// 查询指定EIP在过去24小时之内的异常事件信息，异常事件包括清洗事件和黑洞事件，查询延迟在5分钟之内。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDailyLogResponse> ListDailyLogAsync(ListDailyLogRequest listDailyLogRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("floating_ip_id" , listDailyLogRequest.FloatingIpId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos/{floating_ip_id}/logs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDailyLogRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDailyLogResponse>(response);
        }
        
        /// <summary>
        /// 查询指定EIP防护流量
        ///
        /// 查询指定EIP在过去24小时之内的防护流量信息，流量的间隔时间单位为5分钟。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDailyReportResponse> ListDailyReportAsync(ListDailyReportRequest listDailyReportRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("floating_ip_id" , listDailyReportRequest.FloatingIpId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos/{floating_ip_id}/daily",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDailyReportRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDailyReportResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/antiddos/query-config-list",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNewConfigsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListNewConfigsResponse>(response);
        }
        
        /// <summary>
        /// 查询周防护统计情况
        ///
        /// 查询用户所有Anti-DDoS防护周统计情况，包括一周内DDoS拦截次数和攻击次数、以及按照被攻击次数进行的排名信息等统计数据。系统支持当前时间之前四周的周统计数据查询，超过这个时间的请求是查询不到统计数据的。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListWeeklyReportsResponse> ListWeeklyReportsAsync(ListWeeklyReportsRequest listWeeklyReportsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos/weekly",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWeeklyReportsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListWeeklyReportsResponse>(response);
        }
        
        /// <summary>
        /// 查询Anti-DDoS服务
        ///
        /// 查询配置的Anti-DDoS防护策略，用户可以查询指定EIP的Anti-DDoS防护策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDDosResponse> ShowDDosAsync(ShowDDosRequest showDDosRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("floating_ip_id" , showDDosRequest.FloatingIpId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos/{floating_ip_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDDosRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDDosResponse>(response);
        }
        
        /// <summary>
        /// 查询指定EIP防护状态
        ///
        /// 查询指定EIP的Anti-DDoS防护状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDDosStatusResponse> ShowDDosStatusAsync(ShowDDosStatusRequest showDDosStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("floating_ip_id" , showDDosStatusRequest.FloatingIpId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos/{floating_ip_id}/status",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDDosStatusRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDDosStatusResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/query-task-status",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNewTaskStatusRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowNewTaskStatusResponse>(response);
        }
        
        /// <summary>
        /// 更新Anti-DDoS服务
        ///
        /// 更新指定EIP的Anti-DDoS防护策略配置。调用成功，只是说明服务节点收到了关闭更新配置请求，操作是否成功需要通过任务查询接口查询该任务的执行状态，具体请参考查询Anti-DDoS任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDDosResponse> UpdateDDosAsync(UpdateDDosRequest updateDDosRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("floating_ip_id" , updateDDosRequest.FloatingIpId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos/{floating_ip_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDDosRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDDosResponse>(response);
        }
        
    }
}