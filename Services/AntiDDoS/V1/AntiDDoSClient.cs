using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.AntiDDoS.V1.Model;

namespace HuaweiCloud.SDK.AntiDDoS.V1
{
    public partial class AntiDDoSClient : Client
    {
        public static ClientBuilder<AntiDDoSClient> NewBuilder()
        {
            return new ClientBuilder<AntiDDoSClient>();
        }

        
        /// <summary>
        /// 配置Anti-DDoS默认防护策略
        ///
        /// 配置用户的默认防护策略。配置防护策略后，新购买的资源在自动开启防护时，会按照该默认防护策略进行配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDefaultConfigResponse CreateDefaultConfig(CreateDefaultConfigRequest createDefaultConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos/default-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDefaultConfigRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDefaultConfigResponse>(response);
        }

        public SyncInvoker<CreateDefaultConfigResponse> CreateDefaultConfigInvoker(CreateDefaultConfigRequest createDefaultConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos/default-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDefaultConfigRequest);
            return new SyncInvoker<CreateDefaultConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDefaultConfigResponse>);
        }
        
        /// <summary>
        /// 删除Ani-DDoS默认防护策略
        ///
        /// 删除用户配置的默认防护策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDefaultConfigResponse DeleteDefaultConfig(DeleteDefaultConfigRequest deleteDefaultConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos/default-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDefaultConfigRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDefaultConfigResponse>(response);
        }

        public SyncInvoker<DeleteDefaultConfigResponse> DeleteDefaultConfigInvoker(DeleteDefaultConfigRequest deleteDefaultConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos/default-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDefaultConfigRequest);
            return new SyncInvoker<DeleteDefaultConfigResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDefaultConfigResponse>);
        }
        
        /// <summary>
        /// 查询Ani-DDoS默认防护策略
        ///
        /// 查询用户配置的默认防护策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDefaultConfigResponse ShowDefaultConfig(ShowDefaultConfigRequest showDefaultConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos/default-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDefaultConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDefaultConfigResponse>(response);
        }

        public SyncInvoker<ShowDefaultConfigResponse> ShowDefaultConfigInvoker(ShowDefaultConfigRequest showDefaultConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos/default-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDefaultConfigRequest);
            return new SyncInvoker<ShowDefaultConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDefaultConfigResponse>);
        }
        
        /// <summary>
        /// 开通DDoS服务
        ///
        /// 开通DDoS服务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EnableDefensePolicyResponse EnableDefensePolicy(EnableDefensePolicyRequest enableDefensePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableDefensePolicyRequest.FloatingIpId, out var valueOfFloatingIpId)) urlParam.Add("floating_ip_id", valueOfFloatingIpId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos/{floating_ip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableDefensePolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<EnableDefensePolicyResponse>(response);
        }

        public SyncInvoker<EnableDefensePolicyResponse> EnableDefensePolicyInvoker(EnableDefensePolicyRequest enableDefensePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableDefensePolicyRequest.FloatingIpId, out var valueOfFloatingIpId)) urlParam.Add("floating_ip_id", valueOfFloatingIpId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos/{floating_ip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableDefensePolicyRequest);
            return new SyncInvoker<EnableDefensePolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<EnableDefensePolicyResponse>);
        }
        
        /// <summary>
        /// 查询EIP防护状态列表
        ///
        /// 查询用户所有EIP的Anti-DDoS防护状态信息，用户的EIP无论是否绑定到云服务器，都可以进行查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDDosStatusResponse ListDDosStatus(ListDDosStatusRequest listDDosStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDDosStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDDosStatusResponse>(response);
        }

        public SyncInvoker<ListDDosStatusResponse> ListDDosStatusInvoker(ListDDosStatusRequest listDDosStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDDosStatusRequest);
            return new SyncInvoker<ListDDosStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDDosStatusResponse>);
        }
        
        /// <summary>
        /// 查询指定EIP异常事件
        ///
        /// 查询指定EIP在过去24小时之内的异常事件信息，异常事件包括清洗事件和黑洞事件，查询延迟在5分钟之内。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDailyLogResponse ListDailyLog(ListDailyLogRequest listDailyLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDailyLogRequest.FloatingIpId, out var valueOfFloatingIpId)) urlParam.Add("floating_ip_id", valueOfFloatingIpId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos/{floating_ip_id}/logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDailyLogRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDailyLogResponse>(response);
        }

        public SyncInvoker<ListDailyLogResponse> ListDailyLogInvoker(ListDailyLogRequest listDailyLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDailyLogRequest.FloatingIpId, out var valueOfFloatingIpId)) urlParam.Add("floating_ip_id", valueOfFloatingIpId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos/{floating_ip_id}/logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDailyLogRequest);
            return new SyncInvoker<ListDailyLogResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDailyLogResponse>);
        }
        
        /// <summary>
        /// 查询指定EIP防护流量
        ///
        /// 查询指定EIP在过去24小时之内的防护流量信息，流量的间隔时间单位为5分钟。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDailyReportResponse ListDailyReport(ListDailyReportRequest listDailyReportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDailyReportRequest.FloatingIpId, out var valueOfFloatingIpId)) urlParam.Add("floating_ip_id", valueOfFloatingIpId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos/{floating_ip_id}/daily", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDailyReportRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDailyReportResponse>(response);
        }

        public SyncInvoker<ListDailyReportResponse> ListDailyReportInvoker(ListDailyReportRequest listDailyReportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDailyReportRequest.FloatingIpId, out var valueOfFloatingIpId)) urlParam.Add("floating_ip_id", valueOfFloatingIpId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos/{floating_ip_id}/daily", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDailyReportRequest);
            return new SyncInvoker<ListDailyReportResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDailyReportResponse>);
        }
        
        /// <summary>
        /// 查询配额
        ///
        /// 查询配额
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListQuotaResponse ListQuota(ListQuotaRequest listQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotaRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListQuotaResponse>(response);
        }

        public SyncInvoker<ListQuotaResponse> ListQuotaInvoker(ListQuotaRequest listQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotaRequest);
            return new SyncInvoker<ListQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ListQuotaResponse>);
        }
        
        /// <summary>
        /// 查询周防护统计情况
        ///
        /// 查询用户所有Anti-DDoS防护周统计情况，包括一周内DDoS拦截次数和攻击次数、以及按照被攻击次数进行的排名信息等统计数据。系统支持当前时间之前四周的周统计数据查询，超过这个时间的请求是查询不到统计数据的。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListWeeklyReportsResponse ListWeeklyReports(ListWeeklyReportsRequest listWeeklyReportsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos/weekly", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWeeklyReportsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListWeeklyReportsResponse>(response);
        }

        public SyncInvoker<ListWeeklyReportsResponse> ListWeeklyReportsInvoker(ListWeeklyReportsRequest listWeeklyReportsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos/weekly", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWeeklyReportsRequest);
            return new SyncInvoker<ListWeeklyReportsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWeeklyReportsResponse>);
        }
        
        /// <summary>
        /// 查询Anti-DDoS服务
        ///
        /// 查询配置的Anti-DDoS防护策略，用户可以查询指定EIP的Anti-DDoS防护策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDDosResponse ShowDDos(ShowDDosRequest showDDosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDDosRequest.FloatingIpId, out var valueOfFloatingIpId)) urlParam.Add("floating_ip_id", valueOfFloatingIpId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos/{floating_ip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDDosRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDDosResponse>(response);
        }

        public SyncInvoker<ShowDDosResponse> ShowDDosInvoker(ShowDDosRequest showDDosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDDosRequest.FloatingIpId, out var valueOfFloatingIpId)) urlParam.Add("floating_ip_id", valueOfFloatingIpId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos/{floating_ip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDDosRequest);
            return new SyncInvoker<ShowDDosResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDDosResponse>);
        }
        
        /// <summary>
        /// 查询指定EIP防护状态
        ///
        /// 查询指定EIP的Anti-DDoS防护状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDDosStatusResponse ShowDDosStatus(ShowDDosStatusRequest showDDosStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDDosStatusRequest.FloatingIpId, out var valueOfFloatingIpId)) urlParam.Add("floating_ip_id", valueOfFloatingIpId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos/{floating_ip_id}/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDDosStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDDosStatusResponse>(response);
        }

        public SyncInvoker<ShowDDosStatusResponse> ShowDDosStatusInvoker(ShowDDosStatusRequest showDDosStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDDosStatusRequest.FloatingIpId, out var valueOfFloatingIpId)) urlParam.Add("floating_ip_id", valueOfFloatingIpId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos/{floating_ip_id}/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDDosStatusRequest);
            return new SyncInvoker<ShowDDosStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDDosStatusResponse>);
        }
        
        /// <summary>
        /// 查询全量日志设置
        ///
        /// 查询全量日志设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowLogConfigResponse ShowLogConfig(ShowLogConfigRequest showLogConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos/lts-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowLogConfigResponse>(response);
        }

        public SyncInvoker<ShowLogConfigResponse> ShowLogConfigInvoker(ShowLogConfigRequest showLogConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos/lts-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogConfigRequest);
            return new SyncInvoker<ShowLogConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLogConfigResponse>);
        }
        
        /// <summary>
        /// 更新Anti-DDoS服务
        ///
        /// 更新指定EIP的Anti-DDoS防护策略配置。调用成功，只是说明服务节点收到了关闭更新配置请求，操作是否成功需要通过任务查询接口查询该任务的执行状态，具体请参考查询Anti-DDoS任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDDosResponse UpdateDDos(UpdateDDosRequest updateDDosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDDosRequest.FloatingIpId, out var valueOfFloatingIpId)) urlParam.Add("floating_ip_id", valueOfFloatingIpId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos/{floating_ip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDDosRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDDosResponse>(response);
        }

        public SyncInvoker<UpdateDDosResponse> UpdateDDosInvoker(UpdateDDosRequest updateDDosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDDosRequest.FloatingIpId, out var valueOfFloatingIpId)) urlParam.Add("floating_ip_id", valueOfFloatingIpId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos/{floating_ip_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDDosRequest);
            return new SyncInvoker<UpdateDDosResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDDosResponse>);
        }
        
        /// <summary>
        /// 更新用户全量日志设置
        ///
        /// 更新用户全量日志设置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateLogConfigResponse UpdateLogConfig(UpdateLogConfigRequest updateLogConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos/lts-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLogConfigRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateLogConfigResponse>(response);
        }

        public SyncInvoker<UpdateLogConfigResponse> UpdateLogConfigInvoker(UpdateLogConfigRequest updateLogConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/antiddos/lts-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLogConfigRequest);
            return new SyncInvoker<UpdateLogConfigResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateLogConfigResponse>);
        }
        
    }
}