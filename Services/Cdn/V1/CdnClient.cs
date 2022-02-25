using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Cdn.V1.Model;

namespace HuaweiCloud.SDK.Cdn.V1
{
    public partial class CdnClient : Client
    {
        public static ClientBuilder<CdnClient> NewBuilder()
        {
            return new ClientBuilder<CdnClient>();
        }

        
        /// <summary>
        /// 创建加速域名
        /// </summary>
        public CreateDomainResponse CreateDomain(CreateDomainRequest createDomainRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDomainRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateDomainResponse>(response);
        }
        
        /// <summary>
        /// 创建预热缓存任务
        /// </summary>
        public CreatePreheatingTasksResponse CreatePreheatingTasks(CreatePreheatingTasksRequest createPreheatingTasksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/content/preheating-tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPreheatingTasksRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreatePreheatingTasksResponse>(response);
        }
        
        /// <summary>
        /// 创建刷新缓存任务
        /// </summary>
        public CreateRefreshTasksResponse CreateRefreshTasks(CreateRefreshTasksRequest createRefreshTasksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/content/refresh-tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRefreshTasksRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateRefreshTasksResponse>(response);
        }
        
        /// <summary>
        /// 删除加速域名
        /// </summary>
        public DeleteDomainResponse DeleteDomain(DeleteDomainRequest deleteDomainRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , deleteDomainRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteDomainResponse>(response);
        }
        
        /// <summary>
        /// 停用加速域名
        /// </summary>
        public DisableDomainResponse DisableDomain(DisableDomainRequest disableDomainRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , disableDomainRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/disable",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableDomainRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<DisableDomainResponse>(response);
        }
        
        /// <summary>
        /// 启用加速域名
        /// </summary>
        public EnableDomainResponse EnableDomain(EnableDomainRequest enableDomainRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , enableDomainRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/enable",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableDomainRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<EnableDomainResponse>(response);
        }
        
        /// <summary>
        /// 查询加速域名
        /// </summary>
        public ListDomainsResponse ListDomains(ListDomainsRequest listDomainsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListDomainsResponse>(response);
        }
        
        /// <summary>
        /// 查询IP黑白名单
        /// </summary>
        public ShowBlackWhiteListResponse ShowBlackWhiteList(ShowBlackWhiteListRequest showBlackWhiteListRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showBlackWhiteListRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/ip-acl",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBlackWhiteListRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowBlackWhiteListResponse>(response);
        }
        
        /// <summary>
        /// 查询缓存规则
        /// </summary>
        public ShowCacheRulesResponse ShowCacheRules(ShowCacheRulesRequest showCacheRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showCacheRulesRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/cache",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCacheRulesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowCacheRulesResponse>(response);
        }
        
        /// <summary>
        /// 查询所有绑定HTTPS证书的域名信息
        /// </summary>
        public ShowCertificatesHttpsInfoResponse ShowCertificatesHttpsInfo(ShowCertificatesHttpsInfoRequest showCertificatesHttpsInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/https-certificate-info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCertificatesHttpsInfoRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowCertificatesHttpsInfoResponse>(response);
        }
        
        /// <summary>
        /// 查询加速域名详情
        /// </summary>
        public ShowDomainDetailResponse ShowDomainDetail(ShowDomainDetailRequest showDomainDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showDomainDetailRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainDetailRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainDetailResponse>(response);
        }
        
        /// <summary>
        /// 查询域名配置接口
        /// </summary>
        public ShowDomainFullConfigResponse ShowDomainFullConfig(ShowDomainFullConfigRequest showDomainFullConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name" , showDomainFullConfigRequest.DomainName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.1/cdn/configuration/domains/{domain_name}/configs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainFullConfigRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainFullConfigResponse>(response);
        }
        
        /// <summary>
        /// 批量查询域名的统计明细-按域名单独返回
        /// </summary>
        public ShowDomainItemDetailsResponse ShowDomainItemDetails(ShowDomainItemDetailsRequest showDomainItemDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-item-details",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainItemDetailsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainItemDetailsResponse>(response);
        }
        
        /// <summary>
        /// 批量查询域名的区域、运营商统计明细-按域名单独返回
        /// </summary>
        public ShowDomainItemLocationDetailsResponse ShowDomainItemLocationDetails(ShowDomainItemLocationDetailsRequest showDomainItemLocationDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-item-location-details",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainItemLocationDetailsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainItemLocationDetailsResponse>(response);
        }
        
        /// <summary>
        /// 查询域名统计数据-区域运营商
        /// </summary>
        public ShowDomainLocationStatsResponse ShowDomainLocationStats(ShowDomainLocationStatsRequest showDomainLocationStatsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-location-stats",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainLocationStatsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainLocationStatsResponse>(response);
        }
        
        /// <summary>
        /// 查询域名统计数据-非区域运营商
        /// </summary>
        public ShowDomainStatsResponse ShowDomainStats(ShowDomainStatsRequest showDomainStatsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-stats",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainStatsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainStatsResponse>(response);
        }
        
        /// <summary>
        /// 查询刷新预热任务详情
        /// </summary>
        public ShowHistoryTaskDetailsResponse ShowHistoryTaskDetails(ShowHistoryTaskDetailsRequest showHistoryTaskDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("history_tasks_id" , showHistoryTaskDetailsRequest.HistoryTasksId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/historytasks/{history_tasks_id}/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHistoryTaskDetailsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowHistoryTaskDetailsResponse>(response);
        }
        
        /// <summary>
        /// 查询刷新预热任务
        /// </summary>
        public ShowHistoryTasksResponse ShowHistoryTasks(ShowHistoryTasksRequest showHistoryTasksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/historytasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHistoryTasksRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowHistoryTasksResponse>(response);
        }
        
        /// <summary>
        /// 查询HTTPS配置
        /// </summary>
        public ShowHttpInfoResponse ShowHttpInfo(ShowHttpInfoRequest showHttpInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showHttpInfoRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/https-info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHttpInfoRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowHttpInfoResponse>(response);
        }
        
        /// <summary>
        /// 查询IP归属信息
        /// </summary>
        public ShowIpInfoResponse ShowIpInfo(ShowIpInfoRequest showIpInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/ip-info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpInfoRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowIpInfoResponse>(response);
        }
        
        /// <summary>
        /// 日志查询
        /// </summary>
        public ShowLogsResponse ShowLogs(ShowLogsRequest showLogsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/logs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowLogsResponse>(response);
        }
        
        /// <summary>
        /// 查询回源HOST
        /// </summary>
        public ShowOriginHostResponse ShowOriginHost(ShowOriginHostRequest showOriginHostRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showOriginHostRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/originhost",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOriginHostRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowOriginHostResponse>(response);
        }
        
        /// <summary>
        /// 查询用户配额
        /// </summary>
        public ShowQuotaResponse ShowQuota(ShowQuotaRequest showQuotaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/quota",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowQuotaResponse>(response);
        }
        
        /// <summary>
        /// 查询Referer过滤规则
        /// </summary>
        public ShowReferResponse ShowRefer(ShowReferRequest showReferRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showReferRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/referer",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReferRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowReferResponse>(response);
        }
        
        /// <summary>
        /// 查询响应头配置
        /// </summary>
        public ShowResponseHeaderResponse ShowResponseHeader(ShowResponseHeaderRequest showResponseHeaderRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showResponseHeaderRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/response-header",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResponseHeaderRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowResponseHeaderResponse>(response);
        }
        
        /// <summary>
        /// 查询TOP100 URL明细
        /// </summary>
        public ShowTopUrlResponse ShowTopUrl(ShowTopUrlRequest showTopUrlRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/top-url",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopUrlRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowTopUrlResponse>(response);
        }
        
        /// <summary>
        /// 设置IP黑白名单
        /// </summary>
        public UpdateBlackWhiteListResponse UpdateBlackWhiteList(UpdateBlackWhiteListRequest updateBlackWhiteListRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateBlackWhiteListRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/ip-acl",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBlackWhiteListRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateBlackWhiteListResponse>(response);
        }
        
        /// <summary>
        /// 设置缓存规则
        /// </summary>
        public UpdateCacheRulesResponse UpdateCacheRules(UpdateCacheRulesRequest updateCacheRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateCacheRulesRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/cache",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCacheRulesRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateCacheRulesResponse>(response);
        }
        
        /// <summary>
        /// 修改域名全量配置接口
        /// </summary>
        public UpdateDomainFullConfigResponse UpdateDomainFullConfig(UpdateDomainFullConfigRequest updateDomainFullConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name" , updateDomainFullConfigRequest.DomainName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.1/cdn/configuration/domains/{domain_name}/configs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainFullConfigRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateDomainFullConfigResponse>(response);
        }
        
        /// <summary>
        /// 一个证书批量设置多个域名
        /// </summary>
        public UpdateDomainMultiCertificatesResponse UpdateDomainMultiCertificates(UpdateDomainMultiCertificatesRequest updateDomainMultiCertificatesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/config-https-info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainMultiCertificatesRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDomainMultiCertificatesResponse>(response);
        }
        
        /// <summary>
        /// 修改源站信息
        /// </summary>
        public UpdateDomainOriginResponse UpdateDomainOrigin(UpdateDomainOriginRequest updateDomainOriginRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateDomainOriginRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/origin",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainOriginRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDomainOriginResponse>(response);
        }
        
        /// <summary>
        /// 开启/关闭回源跟随
        /// </summary>
        public UpdateFollow302SwitchResponse UpdateFollow302Switch(UpdateFollow302SwitchRequest updateFollow302SwitchRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateFollow302SwitchRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/follow302-switch",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFollow302SwitchRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateFollow302SwitchResponse>(response);
        }
        
        /// <summary>
        /// 配置HTTPS
        /// </summary>
        public UpdateHttpsInfoResponse UpdateHttpsInfo(UpdateHttpsInfoRequest updateHttpsInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateHttpsInfoRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/https-info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHttpsInfoRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateHttpsInfoResponse>(response);
        }
        
        /// <summary>
        /// 修改回源HOST
        /// </summary>
        public UpdateOriginHostResponse UpdateOriginHost(UpdateOriginHostRequest updateOriginHostRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateOriginHostRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/originhost",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateOriginHostRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateOriginHostResponse>(response);
        }
        
        /// <summary>
        /// 修改私有桶开启关闭状态
        /// </summary>
        public UpdatePrivateBucketAccessResponse UpdatePrivateBucketAccess(UpdatePrivateBucketAccessRequest updatePrivateBucketAccessRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updatePrivateBucketAccessRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/private-bucket-access",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateBucketAccessRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePrivateBucketAccessResponse>(response);
        }
        
        /// <summary>
        /// 开启/关闭Range回源
        /// </summary>
        public UpdateRangeSwitchResponse UpdateRangeSwitch(UpdateRangeSwitchRequest updateRangeSwitchRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateRangeSwitchRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/range-switch",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRangeSwitchRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateRangeSwitchResponse>(response);
        }
        
        /// <summary>
        /// 设置Referer过滤规则
        /// </summary>
        public UpdateReferResponse UpdateRefer(UpdateReferRequest updateReferRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateReferRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/referer",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateReferRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateReferResponse>(response);
        }
        
        /// <summary>
        /// 新增/修改响应头配置
        /// </summary>
        public UpdateResponseHeaderResponse UpdateResponseHeader(UpdateResponseHeaderRequest updateResponseHeaderRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateResponseHeaderRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/response-header",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResponseHeaderRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateResponseHeaderResponse>(response);
        }
        
    }
}