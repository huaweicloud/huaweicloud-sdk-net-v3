using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Cdn.V1.Model;

namespace HuaweiCloud.SDK.Cdn.V1
{
    public partial class CdnAsyncClient : Client
    {
        public static ClientBuilder<CdnAsyncClient> NewBuilder()
        {
            return new ClientBuilder<CdnAsyncClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 创建加速域名
        ///
        /// 创建加速域名。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest createDomainRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDomainRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateDomainResponse>(response);
        }
        
        /// <summary>
        /// 创建预热缓存任务
        ///
        /// 创建预热任务。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePreheatingTasksResponse> CreatePreheatingTasksAsync(CreatePreheatingTasksRequest createPreheatingTasksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/content/preheating-tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPreheatingTasksRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreatePreheatingTasksResponse>(response);
        }
        
        /// <summary>
        /// 创建刷新缓存任务
        ///
        /// 创建刷新缓存任务。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRefreshTasksResponse> CreateRefreshTasksAsync(CreateRefreshTasksRequest createRefreshTasksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/content/refresh-tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRefreshTasksRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateRefreshTasksResponse>(response);
        }
        
        /// <summary>
        /// 删除加速域名
        ///
        /// 删除加速域名。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest deleteDomainRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , deleteDomainRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteDomainResponse>(response);
        }
        
        /// <summary>
        /// 停用加速域名
        ///
        /// 停用加速域名。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<DisableDomainResponse> DisableDomainAsync(DisableDomainRequest disableDomainRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , disableDomainRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/disable",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableDomainRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<DisableDomainResponse>(response);
        }
        
        /// <summary>
        /// 启用加速域名
        ///
        /// 启用加速域名。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<EnableDomainResponse> EnableDomainAsync(EnableDomainRequest enableDomainRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , enableDomainRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/enable",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableDomainRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<EnableDomainResponse>(response);
        }
        
        /// <summary>
        /// 查询加速域名
        ///
        /// 查询加速域名信息
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest listDomainsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDomainsResponse>(response);
        }
        
        /// <summary>
        /// 查询IP黑白名单
        ///
        /// 查询域名已经设置的IP黑白名单。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBlackWhiteListResponse> ShowBlackWhiteListAsync(ShowBlackWhiteListRequest showBlackWhiteListRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showBlackWhiteListRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/ip-acl",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBlackWhiteListRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowBlackWhiteListResponse>(response);
        }
        
        /// <summary>
        /// 查询缓存规则
        ///
        /// 查询缓存规则。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCacheRulesResponse> ShowCacheRulesAsync(ShowCacheRulesRequest showCacheRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showCacheRulesRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/cache",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCacheRulesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowCacheRulesResponse>(response);
        }
        
        /// <summary>
        /// 查询所有绑定HTTPS证书的域名信息
        ///
        /// 查询所有绑定HTTPS证书的域名信息
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCertificatesHttpsInfoResponse> ShowCertificatesHttpsInfoAsync(ShowCertificatesHttpsInfoRequest showCertificatesHttpsInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/https-certificate-info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCertificatesHttpsInfoRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowCertificatesHttpsInfoResponse>(response);
        }
        
        /// <summary>
        /// 查询加速域名详情
        ///
        /// 查询加速域名详情。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainDetailResponse> ShowDomainDetailAsync(ShowDomainDetailRequest showDomainDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showDomainDetailRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainDetailRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainDetailResponse>(response);
        }
        
        /// <summary>
        /// 查询域名配置接口
        ///
        /// 查询域名配置接口，支持配置回源请求头、http header配置、url鉴权
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainFullConfigResponse> ShowDomainFullConfigAsync(ShowDomainFullConfigRequest showDomainFullConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name" , showDomainFullConfigRequest.DomainName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.1/cdn/configuration/domains/{domain_name}/configs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainFullConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainFullConfigResponse>(response);
        }
        
        /// <summary>
        /// 批量查询域名的统计明细-按域名单独返回
        ///
        /// - 支持查询90天内的数据。
        /// - 查询跨度不能超过7天。
        /// - 最多同时指定100个域名。
        /// - 起始时间和结束时间，左闭右开，需要同时指定。
        /// - 开始时间、结束时间必须传毫秒级时间戳，且必须为5分钟整时刻点，如：0分、5分、10分、15分等，如果传的不是5分钟时刻点，返回数据可能与预期不一致。
        /// - 统一用开始时间表示一个时间段，如：2019-01-24 20:15:00 表示取 [20:15:00, 20:20:00)的统计数据，且左闭右开。
        /// - 流量类指标单位统一为Byte（字节）、带宽类指标单位统一为bit/s（比特/秒）、请求数类指标单位统一为次数。用于查询指定域名、指定统计指标的明细数据。
        /// - 如果传的是多个域名，则每个域名的数据分开返回。
        /// - 支持同时查询多个指标，不超过10个。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainItemDetailsResponse> ShowDomainItemDetailsAsync(ShowDomainItemDetailsRequest showDomainItemDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-item-details",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainItemDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainItemDetailsResponse>(response);
        }
        
        /// <summary>
        /// 批量查询域名的区域、运营商统计明细-按域名单独返回
        ///
        /// - 支持查询90天内的数据。
        /// - 查询跨度是7天。
        /// - 最多同时指定100个域名。
        /// - 起始时间和结束时间，左闭右开，需要同时指定。
        /// - 开始时间、结束时间必须传毫秒级时间戳，且必须为5分钟整时刻点，如：0分、5分、10分、15分等，如果传的不是5分钟时刻点，返回数据可能与预期不一致。
        /// - 统一用开始时间表示一个时间段，如：2019-01-24 20:15:00 表示取 [20:15:00, 20:20:00)的统计数据，且左闭右开。
        /// - 流量类指标单位统一为Byte（字节）、带宽类指标单位统一为bit/s（比特/秒）、请求数类指标单位统一为次数。
        /// - 用于查询指定域名、指定统计指标的明细数据。
        /// - 如果传的是多个域名，则每个域名的数据分开返回。
        /// - 支持按区域、运营商维度查询统计数据, 回源指标除外。
        /// - 支持同时查询多个指标，不超过10个。
        /// - 域名为海外加速场景不适用。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainItemLocationDetailsResponse> ShowDomainItemLocationDetailsAsync(ShowDomainItemLocationDetailsRequest showDomainItemLocationDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-item-location-details",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainItemLocationDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainItemLocationDetailsResponse>(response);
        }
        
        /// <summary>
        /// 查询域名统计数据-区域运营商
        ///
        /// - 支持查询90天内的数据。
        /// - 支持多指标同时查询，不超过5个。
        /// - 最多同时指定20个域名。
        /// - 起始时间和结束时间需要同时指定，左闭右开，毫秒级时间戳，必须为5分钟整时刻点，如：0分、5分、10分、15分等，如果传的不是5分钟时刻点， 返回数据可能与预期不一致。统一用开始时间表示一个时间段，如：2019-01-24 20:15:00 表示取 [20:15:00, 20:20:00)的统计数据，且左闭右开。
        /// - action取值：location_detail,location_summary
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainLocationStatsResponse> ShowDomainLocationStatsAsync(ShowDomainLocationStatsRequest showDomainLocationStatsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-location-stats",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainLocationStatsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainLocationStatsResponse>(response);
        }
        
        /// <summary>
        /// 查询域名统计数据
        ///
        /// - 支持查询90天内的数据。
        /// - 支持多指标同时查询，不超过5个。
        /// - 最多同时指定20个域名。
        /// - 起始时间和结束时间需要同时指定，左闭右开，毫秒级时间戳，必须为5分钟整时刻点，如：0分、5分、10分、15分等，如果传的不是5分钟时刻点，返回数据可能与预期不一致。统一用开始时间表示一个时间段，如：2019-01-24 20:15:00 表示取 [20:15:00, 20:20:00)的统计数据，且左闭右开。
        /// - action取值：detail,summary
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainStatsResponse> ShowDomainStatsAsync(ShowDomainStatsRequest showDomainStatsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-stats",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainStatsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainStatsResponse>(response);
        }
        
        /// <summary>
        /// 查询刷新预热任务详情
        ///
        /// 查询刷新预热任务详情。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ShowHistoryTaskDetailsResponse> ShowHistoryTaskDetailsAsync(ShowHistoryTaskDetailsRequest showHistoryTaskDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("history_tasks_id" , showHistoryTaskDetailsRequest.HistoryTasksId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/historytasks/{history_tasks_id}/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHistoryTaskDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowHistoryTaskDetailsResponse>(response);
        }
        
        /// <summary>
        /// 查询刷新预热任务
        ///
        /// 查询刷新预热任务。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ShowHistoryTasksResponse> ShowHistoryTasksAsync(ShowHistoryTasksRequest showHistoryTasksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/historytasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHistoryTasksRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowHistoryTasksResponse>(response);
        }
        
        /// <summary>
        /// 查询HTTPS配置
        ///
        /// 获取加速域名证书。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ShowHttpInfoResponse> ShowHttpInfoAsync(ShowHttpInfoRequest showHttpInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showHttpInfoRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/https-info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHttpInfoRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowHttpInfoResponse>(response);
        }
        
        /// <summary>
        /// 查询IP归属信息
        ///
        /// 查询IP归属信息。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ShowIpInfoResponse> ShowIpInfoAsync(ShowIpInfoRequest showIpInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/ip-info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpInfoRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowIpInfoResponse>(response);
        }
        
        /// <summary>
        /// 日志查询
        ///
        /// 日志查询。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ShowLogsResponse> ShowLogsAsync(ShowLogsRequest showLogsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/logs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowLogsResponse>(response);
        }
        
        /// <summary>
        /// 查询回源HOST
        ///
        /// 查询回源HOST。回源HOST是CDN节点在回源过程中，在源站访问的站点域名，即http请求头中的host信息。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ShowOriginHostResponse> ShowOriginHostAsync(ShowOriginHostRequest showOriginHostRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showOriginHostRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/originhost",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOriginHostRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowOriginHostResponse>(response);
        }
        
        /// <summary>
        /// 查询用户配额
        ///
        /// 查询当前用户域名、刷新文件、刷新目录和预热的配额
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ShowQuotaResponse> ShowQuotaAsync(ShowQuotaRequest showQuotaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/quota",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowQuotaResponse>(response);
        }
        
        /// <summary>
        /// 查询Referer过滤规则
        ///
        /// 查询Referer过滤规则。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ShowReferResponse> ShowReferAsync(ShowReferRequest showReferRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showReferRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/referer",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReferRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowReferResponse>(response);
        }
        
        /// <summary>
        /// 查询响应头配置
        ///
        /// 列举header所有配置。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ShowResponseHeaderResponse> ShowResponseHeaderAsync(ShowResponseHeaderRequest showResponseHeaderRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showResponseHeaderRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/response-header",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResponseHeaderRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowResponseHeaderResponse>(response);
        }
        
        /// <summary>
        /// 查询TOP100 URL明细
        ///
        /// - 查询TOP100 URL明细。
        /// - 支持查询90天内的数据。
        /// - 查询跨度不能超过31天。
        /// - 起始时间和结束时间，左闭右开，需要同时指定。如查询2021-10-24 00:00:00 到 2021-10-25 00:00:00 的数据，表示取 [2021-10-24 00:00:00, 2021-10-25 00:00:00)的统计数据。
        /// - 开始时间、结束时间必须传毫秒级时间戳，且必须为凌晨0点整时刻点，如果传的不是凌晨0点整时刻点，返回数据可能与预期不一致。
        /// - 流量类指标单位统一为Byte（字节）、请求数类指标单位统一为次数。用于查询指定域名、指定统计指标的明细数据。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTopUrlResponse> ShowTopUrlAsync(ShowTopUrlRequest showTopUrlRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/top-url",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopUrlRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowTopUrlResponse>(response);
        }
        
        /// <summary>
        /// 设置IP黑白名单
        ///
        /// 设置域名的IP黑白名单。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateBlackWhiteListResponse> UpdateBlackWhiteListAsync(UpdateBlackWhiteListRequest updateBlackWhiteListRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateBlackWhiteListRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/ip-acl",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBlackWhiteListRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateBlackWhiteListResponse>(response);
        }
        
        /// <summary>
        /// 设置缓存规则
        ///
        /// 设置CDN节点上缓存资源的缓存策略。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateCacheRulesResponse> UpdateCacheRulesAsync(UpdateCacheRulesRequest updateCacheRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateCacheRulesRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/cache",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCacheRulesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateCacheRulesResponse>(response);
        }
        
        /// <summary>
        /// 修改域名全量配置接口
        ///
        /// 修改域名全量配置接口，支持配置回源请求头、http header配置、url鉴权
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDomainFullConfigResponse> UpdateDomainFullConfigAsync(UpdateDomainFullConfigRequest updateDomainFullConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name" , updateDomainFullConfigRequest.DomainName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.1/cdn/configuration/domains/{domain_name}/configs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainFullConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateDomainFullConfigResponse>(response);
        }
        
        /// <summary>
        /// 一个证书批量设置多个域名
        ///
        /// 一个证书配置多个域名，设置域名强制https回源参数。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDomainMultiCertificatesResponse> UpdateDomainMultiCertificatesAsync(UpdateDomainMultiCertificatesRequest updateDomainMultiCertificatesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/config-https-info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainMultiCertificatesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDomainMultiCertificatesResponse>(response);
        }
        
        /// <summary>
        /// 修改源站信息
        ///
        /// 修改源站信息。源站IP地址或域名都可以指引CDN节点回源到对应的源站服务器，源站域名不能与加速域名相同。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDomainOriginResponse> UpdateDomainOriginAsync(UpdateDomainOriginRequest updateDomainOriginRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateDomainOriginRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/origin",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainOriginRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDomainOriginResponse>(response);
        }
        
        /// <summary>
        /// 开启/关闭回源跟随
        ///
        /// 开启此项配置后，当CDN节点回源请求源站返回301/302状态码时，CDN节点会先跳转到301/302对应地址获取资源并缓存后再返回给用户。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateFollow302SwitchResponse> UpdateFollow302SwitchAsync(UpdateFollow302SwitchRequest updateFollow302SwitchRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateFollow302SwitchRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/follow302-switch",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFollow302SwitchRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateFollow302SwitchResponse>(response);
        }
        
        /// <summary>
        /// 配置HTTPS
        ///
        /// 设置加速域名HTTPS。通过配置加速域名的HTTPS证书，并将其部署在全网CDN节点，实现HTTPS安全加速。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateHttpsInfoResponse> UpdateHttpsInfoAsync(UpdateHttpsInfoRequest updateHttpsInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateHttpsInfoRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/https-info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHttpsInfoRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateHttpsInfoResponse>(response);
        }
        
        /// <summary>
        /// 修改回源HOST
        ///
        /// 修改回源HOST。回源HOST是CDN节点在回源过程中，在源站访问的站点域名，即http请求头中的host信息。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateOriginHostResponse> UpdateOriginHostAsync(UpdateOriginHostRequest updateOriginHostRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateOriginHostRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/originhost",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateOriginHostRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateOriginHostResponse>(response);
        }
        
        /// <summary>
        /// 修改私有桶开启关闭状态
        ///
        /// 修改私有桶开启关闭状态。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePrivateBucketAccessResponse> UpdatePrivateBucketAccessAsync(UpdatePrivateBucketAccessRequest updatePrivateBucketAccessRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updatePrivateBucketAccessRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/private-bucket-access",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateBucketAccessRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePrivateBucketAccessResponse>(response);
        }
        
        /// <summary>
        /// 开启/关闭Range回源
        ///
        /// Range回源是指源站在收到CDN节点回源请求时，根据http请求头中的Range信息返回指定范围的数据给CDN节点。
        /// 
        /// 开启Range回源前需要确认源站是否支持Range请求，若源站不支持Range请求，开启Range回源将导致资源无法缓存。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRangeSwitchResponse> UpdateRangeSwitchAsync(UpdateRangeSwitchRequest updateRangeSwitchRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateRangeSwitchRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/range-switch",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRangeSwitchRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateRangeSwitchResponse>(response);
        }
        
        /// <summary>
        /// 设置Referer过滤规则
        ///
        /// 设置Referer过滤规则。通过设置过滤策略，对访问者身份进行识别和过滤，实现限制访问来源的目的。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateReferResponse> UpdateReferAsync(UpdateReferRequest updateReferRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateReferRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/referer",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateReferRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateReferResponse>(response);
        }
        
        /// <summary>
        /// 新增/修改响应头配置
        ///
        /// 新增/修改域名响应头配置。
        /// 
        /// 详细说明请参考华为云API Explorer。
        /// Please refer to Huawei cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateResponseHeaderResponse> UpdateResponseHeaderAsync(UpdateResponseHeaderRequest updateResponseHeaderRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateResponseHeaderRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/response-header",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResponseHeaderRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateResponseHeaderResponse>(response);
        }
        
    }
}