using System;
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
            return new ClientBuilder<CdnClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 删除资源标签配置接口
        ///
        /// 用于删除资源标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteTagsResponse BatchDeleteTags(BatchDeleteTagsRequest batchDeleteTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/tags/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteTagsResponse>(response);
        }

        public SyncInvoker<BatchDeleteTagsResponse> BatchDeleteTagsInvoker(BatchDeleteTagsRequest batchDeleteTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/tags/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteTagsRequest);
            return new SyncInvoker<BatchDeleteTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteTagsResponse>);
        }
        
        /// <summary>
        /// 创建加速域名
        ///
        /// 创建加速域名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDomainResponse CreateDomain(CreateDomainRequest createDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDomainRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDomainResponse>(response);
        }

        public SyncInvoker<CreateDomainResponse> CreateDomainInvoker(CreateDomainRequest createDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDomainRequest);
            return new SyncInvoker<CreateDomainResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDomainResponse>);
        }
        
        /// <summary>
        /// 创建预热缓存任务
        ///
        /// 创建预热任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePreheatingTasksResponse CreatePreheatingTasks(CreatePreheatingTasksRequest createPreheatingTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/content/preheating-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPreheatingTasksRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePreheatingTasksResponse>(response);
        }

        public SyncInvoker<CreatePreheatingTasksResponse> CreatePreheatingTasksInvoker(CreatePreheatingTasksRequest createPreheatingTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/content/preheating-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPreheatingTasksRequest);
            return new SyncInvoker<CreatePreheatingTasksResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePreheatingTasksResponse>);
        }
        
        /// <summary>
        /// 创建刷新缓存任务
        ///
        /// 创建刷新缓存任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRefreshTasksResponse CreateRefreshTasks(CreateRefreshTasksRequest createRefreshTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/content/refresh-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRefreshTasksRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateRefreshTasksResponse>(response);
        }

        public SyncInvoker<CreateRefreshTasksResponse> CreateRefreshTasksInvoker(CreateRefreshTasksRequest createRefreshTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/content/refresh-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRefreshTasksRequest);
            return new SyncInvoker<CreateRefreshTasksResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRefreshTasksResponse>);
        }
        
        /// <summary>
        /// 创建资源标签配置接口
        ///
        /// 用于创建资源标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTagsResponse CreateTags(CreateTagsRequest createTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateTagsResponse>(response);
        }

        public SyncInvoker<CreateTagsResponse> CreateTagsInvoker(CreateTagsRequest createTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagsRequest);
            return new SyncInvoker<CreateTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateTagsResponse>);
        }
        
        /// <summary>
        /// 删除加速域名
        ///
        /// 删除加速域名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDomainResponse DeleteDomain(DeleteDomainRequest deleteDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", deleteDomainRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDomainResponse>(response);
        }

        public SyncInvoker<DeleteDomainResponse> DeleteDomainInvoker(DeleteDomainRequest deleteDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", deleteDomainRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainRequest);
            return new SyncInvoker<DeleteDomainResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDomainResponse>);
        }
        
        /// <summary>
        /// 停用加速域名
        ///
        /// 停用加速域名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisableDomainResponse DisableDomain(DisableDomainRequest disableDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", disableDomainRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableDomainRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<DisableDomainResponse>(response);
        }

        public SyncInvoker<DisableDomainResponse> DisableDomainInvoker(DisableDomainRequest disableDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", disableDomainRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableDomainRequest);
            return new SyncInvoker<DisableDomainResponse>(this, "PUT", request, JsonUtils.DeSerialize<DisableDomainResponse>);
        }
        
        /// <summary>
        /// 启用加速域名
        ///
        /// 启用加速域名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EnableDomainResponse EnableDomain(EnableDomainRequest enableDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", enableDomainRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableDomainRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<EnableDomainResponse>(response);
        }

        public SyncInvoker<EnableDomainResponse> EnableDomainInvoker(EnableDomainRequest enableDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", enableDomainRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableDomainRequest);
            return new SyncInvoker<EnableDomainResponse>(this, "PUT", request, JsonUtils.DeSerialize<EnableDomainResponse>);
        }
        
        /// <summary>
        /// 查询加速域名
        ///
        /// 查询加速域名信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDomainsResponse ListDomains(ListDomainsRequest listDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDomainsResponse>(response);
        }

        public SyncInvoker<ListDomainsResponse> ListDomainsInvoker(ListDomainsRequest listDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainsRequest);
            return new SyncInvoker<ListDomainsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainsResponse>);
        }
        
        /// <summary>
        /// 查询IP黑白名单
        ///
        /// 查询域名已经设置的IP黑白名单。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBlackWhiteListResponse ShowBlackWhiteList(ShowBlackWhiteListRequest showBlackWhiteListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showBlackWhiteListRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/ip-acl", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBlackWhiteListRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBlackWhiteListResponse>(response);
        }

        public SyncInvoker<ShowBlackWhiteListResponse> ShowBlackWhiteListInvoker(ShowBlackWhiteListRequest showBlackWhiteListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showBlackWhiteListRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/ip-acl", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBlackWhiteListRequest);
            return new SyncInvoker<ShowBlackWhiteListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBlackWhiteListResponse>);
        }
        
        /// <summary>
        /// 查询缓存规则
        ///
        /// 查询缓存规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowCacheRulesResponse ShowCacheRules(ShowCacheRulesRequest showCacheRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showCacheRulesRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/cache", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCacheRulesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowCacheRulesResponse>(response);
        }

        public SyncInvoker<ShowCacheRulesResponse> ShowCacheRulesInvoker(ShowCacheRulesRequest showCacheRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showCacheRulesRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/cache", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCacheRulesRequest);
            return new SyncInvoker<ShowCacheRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCacheRulesResponse>);
        }
        
        /// <summary>
        /// 查询所有绑定HTTPS证书的域名信息
        ///
        /// 查询所有绑定HTTPS证书的域名信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowCertificatesHttpsInfoResponse ShowCertificatesHttpsInfo(ShowCertificatesHttpsInfoRequest showCertificatesHttpsInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/https-certificate-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCertificatesHttpsInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowCertificatesHttpsInfoResponse>(response);
        }

        public SyncInvoker<ShowCertificatesHttpsInfoResponse> ShowCertificatesHttpsInfoInvoker(ShowCertificatesHttpsInfoRequest showCertificatesHttpsInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/https-certificate-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCertificatesHttpsInfoRequest);
            return new SyncInvoker<ShowCertificatesHttpsInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCertificatesHttpsInfoResponse>);
        }
        
        /// <summary>
        /// 查询加速域名详情
        ///
        /// 查询加速域名详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDomainDetailResponse ShowDomainDetail(ShowDomainDetailRequest showDomainDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showDomainDetailRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainDetailResponse>(response);
        }

        public SyncInvoker<ShowDomainDetailResponse> ShowDomainDetailInvoker(ShowDomainDetailRequest showDomainDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showDomainDetailRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainDetailRequest);
            return new SyncInvoker<ShowDomainDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainDetailResponse>);
        }
        
        /// <summary>
        /// 查询域名配置接口
        ///
        /// 查询域名配置接口，
        /// 支持查询回源请求头、HTTP header配置、URL鉴权、证书、源站、回源协议、强制重定向、智能压缩、IPv6开关、状态码缓存时间、Range回源、User-Agent黑白名单、改写回源URL、自定义错误页面、缓存规则、IP黑白名单、防盗链、强制跳转。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDomainFullConfigResponse ShowDomainFullConfig(ShowDomainFullConfigRequest showDomainFullConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", showDomainFullConfigRequest.DomainName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.1/cdn/configuration/domains/{domain_name}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainFullConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainFullConfigResponse>(response);
        }

        public SyncInvoker<ShowDomainFullConfigResponse> ShowDomainFullConfigInvoker(ShowDomainFullConfigRequest showDomainFullConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", showDomainFullConfigRequest.DomainName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.1/cdn/configuration/domains/{domain_name}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainFullConfigRequest);
            return new SyncInvoker<ShowDomainFullConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainFullConfigResponse>);
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
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDomainItemDetailsResponse ShowDomainItemDetails(ShowDomainItemDetailsRequest showDomainItemDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-item-details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainItemDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainItemDetailsResponse>(response);
        }

        public SyncInvoker<ShowDomainItemDetailsResponse> ShowDomainItemDetailsInvoker(ShowDomainItemDetailsRequest showDomainItemDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-item-details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainItemDetailsRequest);
            return new SyncInvoker<ShowDomainItemDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainItemDetailsResponse>);
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
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDomainItemLocationDetailsResponse ShowDomainItemLocationDetails(ShowDomainItemLocationDetailsRequest showDomainItemLocationDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-item-location-details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainItemLocationDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainItemLocationDetailsResponse>(response);
        }

        public SyncInvoker<ShowDomainItemLocationDetailsResponse> ShowDomainItemLocationDetailsInvoker(ShowDomainItemLocationDetailsRequest showDomainItemLocationDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-item-location-details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainItemLocationDetailsRequest);
            return new SyncInvoker<ShowDomainItemLocationDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainItemLocationDetailsResponse>);
        }
        
        /// <summary>
        /// 按区域运营商查询域名统计数据
        ///
        /// - 支持查询90天内的数据。
        /// 
        /// - 支持多指标同时查询，不超过5个。
        /// 
        /// - 最多同时指定20个域名。
        /// 
        /// - 起始时间和结束时间需要同时指定，左闭右开，毫秒级时间戳，且时间点必须为与查询时间间隔参数匹配的整时刻点。比如查询时间间隔为5分钟时，起始时间和结束时间必须为5分钟整时刻点，如：0分、5分、10分、15分等，如果时间点与时间间隔不匹配，返回数据可能与预期不一致。统一用开始时间表示一个时间段，如：2019-01-24 20:15:00 表示取 [20:15:00, 20:20:00)的统计数据，且左闭右开。
        /// 
        /// - action取值：location_detail,location_summary
        /// 
        /// - 流量类指标单位统一为Byte（字节）、带宽类指标单位统一为bit/s（比特/秒）、请求数类和状态码类指标单位统一为次数。用于查询指定域名、指定统计指标的区域运营商明细数据。
        /// 
        /// - 单租户调用频率：15次/s。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDomainLocationStatsResponse ShowDomainLocationStats(ShowDomainLocationStatsRequest showDomainLocationStatsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-location-stats", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainLocationStatsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainLocationStatsResponse>(response);
        }

        public SyncInvoker<ShowDomainLocationStatsResponse> ShowDomainLocationStatsInvoker(ShowDomainLocationStatsRequest showDomainLocationStatsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-location-stats", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainLocationStatsRequest);
            return new SyncInvoker<ShowDomainLocationStatsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainLocationStatsResponse>);
        }
        
        /// <summary>
        /// 查询域名统计数据
        ///
        /// - 支持查询90天内的数据。
        /// 
        /// - 支持多指标同时查询，不超过5个。
        /// 
        /// - 最多同时指定20个域名。
        /// 
        /// - 起始时间和结束时间需要同时指定，左闭右开，毫秒级时间戳，且时间点必须为与查询时间间隔参数匹配的整时刻点。比如查询时间间隔为5分钟时，起始时间和结束时间必须为5分钟整时刻点，如：0分、5分、10分、15分等，如果时间点与时间间隔不匹配，返回数据可能与预期不一致。统一用开始时间表示一个时间段，如：2019-01-24 20:15:00 表示取 [20:15:00, 20:20:00)的统计数据，且左闭右开。
        /// 
        /// - action取值：detail,summary
        /// 
        /// - 流量类指标单位统一为Byte（字节）、带宽类指标单位统一为bit/s（比特/秒）、请求数类和状态码类指标单位统一为次数。用于查询指定域名、指定统计指标的明细数据。
        /// 
        /// - 单租户调用频率：15次/s。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDomainStatsResponse ShowDomainStats(ShowDomainStatsRequest showDomainStatsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-stats", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainStatsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainStatsResponse>(response);
        }

        public SyncInvoker<ShowDomainStatsResponse> ShowDomainStatsInvoker(ShowDomainStatsRequest showDomainStatsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-stats", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainStatsRequest);
            return new SyncInvoker<ShowDomainStatsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainStatsResponse>);
        }
        
        /// <summary>
        /// 查询刷新预热任务详情
        ///
        /// 查询刷新预热任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowHistoryTaskDetailsResponse ShowHistoryTaskDetails(ShowHistoryTaskDetailsRequest showHistoryTaskDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("history_tasks_id", showHistoryTaskDetailsRequest.HistoryTasksId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/historytasks/{history_tasks_id}/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHistoryTaskDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowHistoryTaskDetailsResponse>(response);
        }

        public SyncInvoker<ShowHistoryTaskDetailsResponse> ShowHistoryTaskDetailsInvoker(ShowHistoryTaskDetailsRequest showHistoryTaskDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("history_tasks_id", showHistoryTaskDetailsRequest.HistoryTasksId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/historytasks/{history_tasks_id}/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHistoryTaskDetailsRequest);
            return new SyncInvoker<ShowHistoryTaskDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHistoryTaskDetailsResponse>);
        }
        
        /// <summary>
        /// 查询刷新预热任务
        ///
        /// 查询刷新预热任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowHistoryTasksResponse ShowHistoryTasks(ShowHistoryTasksRequest showHistoryTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/historytasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHistoryTasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowHistoryTasksResponse>(response);
        }

        public SyncInvoker<ShowHistoryTasksResponse> ShowHistoryTasksInvoker(ShowHistoryTasksRequest showHistoryTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/historytasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHistoryTasksRequest);
            return new SyncInvoker<ShowHistoryTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHistoryTasksResponse>);
        }
        
        /// <summary>
        /// 查询HTTPS配置
        ///
        /// 获取加速域名证书。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowHttpInfoResponse ShowHttpInfo(ShowHttpInfoRequest showHttpInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showHttpInfoRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/https-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHttpInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowHttpInfoResponse>(response);
        }

        public SyncInvoker<ShowHttpInfoResponse> ShowHttpInfoInvoker(ShowHttpInfoRequest showHttpInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showHttpInfoRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/https-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHttpInfoRequest);
            return new SyncInvoker<ShowHttpInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHttpInfoResponse>);
        }
        
        /// <summary>
        /// 查询IP归属信息
        ///
        /// 查询IP归属信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowIpInfoResponse ShowIpInfo(ShowIpInfoRequest showIpInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/ip-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowIpInfoResponse>(response);
        }

        public SyncInvoker<ShowIpInfoResponse> ShowIpInfoInvoker(ShowIpInfoRequest showIpInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/ip-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpInfoRequest);
            return new SyncInvoker<ShowIpInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowIpInfoResponse>);
        }
        
        /// <summary>
        /// 日志查询
        ///
        /// 查询日志下载链接，支持查询30天内的日志信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowLogsResponse ShowLogs(ShowLogsRequest showLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowLogsResponse>(response);
        }

        public SyncInvoker<ShowLogsResponse> ShowLogsInvoker(ShowLogsRequest showLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogsRequest);
            return new SyncInvoker<ShowLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLogsResponse>);
        }
        
        /// <summary>
        /// 查询回源HOST
        ///
        /// 查询回源HOST。回源HOST是CDN节点在回源过程中，在源站访问的站点域名，即http请求头中的host信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowOriginHostResponse ShowOriginHost(ShowOriginHostRequest showOriginHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showOriginHostRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/originhost", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOriginHostRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowOriginHostResponse>(response);
        }

        public SyncInvoker<ShowOriginHostResponse> ShowOriginHostInvoker(ShowOriginHostRequest showOriginHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showOriginHostRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/originhost", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOriginHostRequest);
            return new SyncInvoker<ShowOriginHostResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOriginHostResponse>);
        }
        
        /// <summary>
        /// 查询用户配额
        ///
        /// 查询当前用户域名、刷新文件、刷新目录和预热的配额
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowQuotaResponse ShowQuota(ShowQuotaRequest showQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowQuotaResponse>(response);
        }

        public SyncInvoker<ShowQuotaResponse> ShowQuotaInvoker(ShowQuotaRequest showQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaRequest);
            return new SyncInvoker<ShowQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowQuotaResponse>);
        }
        
        /// <summary>
        /// 查询Referer过滤规则
        ///
        /// 查询Referer过滤规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowReferResponse ShowRefer(ShowReferRequest showReferRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showReferRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/referer", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReferRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowReferResponse>(response);
        }

        public SyncInvoker<ShowReferResponse> ShowReferInvoker(ShowReferRequest showReferRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showReferRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/referer", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReferRequest);
            return new SyncInvoker<ShowReferResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowReferResponse>);
        }
        
        /// <summary>
        /// 查询响应头配置
        ///
        /// 列举header所有配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowResponseHeaderResponse ShowResponseHeader(ShowResponseHeaderRequest showResponseHeaderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showResponseHeaderRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/response-header", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResponseHeaderRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowResponseHeaderResponse>(response);
        }

        public SyncInvoker<ShowResponseHeaderResponse> ShowResponseHeaderInvoker(ShowResponseHeaderRequest showResponseHeaderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showResponseHeaderRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/response-header", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResponseHeaderRequest);
            return new SyncInvoker<ShowResponseHeaderResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResponseHeaderResponse>);
        }
        
        /// <summary>
        /// 查询资源标签列表配置接口
        ///
        /// 用于查询资源标签列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTagsResponse ShowTags(ShowTagsRequest showTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTagsResponse>(response);
        }

        public SyncInvoker<ShowTagsResponse> ShowTagsInvoker(ShowTagsRequest showTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTagsRequest);
            return new SyncInvoker<ShowTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTagsResponse>);
        }
        
        /// <summary>
        /// 查询TOP100 URL明细
        ///
        /// - 查询TOP100 URL明细。
        /// 
        /// - 支持查询90天内的数据。
        /// 
        /// - 查询跨度不能超过31天。
        /// 
        /// - 起始时间和结束时间，左闭右开，需要同时指定。如查询2021-10-24 00:00:00 到 2021-10-25 00:00:00
        /// 的数据，表示取 [2021-10-24 00:00:00, 2021-10-25 00:00:00)的统计数据。
        /// 
        /// - 开始时间、结束时间必须传毫秒级时间戳，且必须为凌晨0点整时刻点，如果传的不是凌晨0点整时刻点，返回数据可能与预期不一致。
        /// 
        /// - 流量类指标单位统一为Byte（字节）、请求数类指标单位统一为次数。用于查询指定域名、指定统计指标的明细数据。
        /// 
        /// - 单租户调用频率：5次/s。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTopUrlResponse ShowTopUrl(ShowTopUrlRequest showTopUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/top-url", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopUrlRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTopUrlResponse>(response);
        }

        public SyncInvoker<ShowTopUrlResponse> ShowTopUrlInvoker(ShowTopUrlRequest showTopUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/top-url", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopUrlRequest);
            return new SyncInvoker<ShowTopUrlResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTopUrlResponse>);
        }
        
        /// <summary>
        /// 查询刷新预热URL记录
        ///
        /// 查询刷新预热URL记录。如需此接口，请提交工单开通。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowUrlTaskInfoResponse ShowUrlTaskInfo(ShowUrlTaskInfoRequest showUrlTaskInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/contentgateway/url-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUrlTaskInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowUrlTaskInfoResponse>(response);
        }

        public SyncInvoker<ShowUrlTaskInfoResponse> ShowUrlTaskInfoInvoker(ShowUrlTaskInfoRequest showUrlTaskInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/contentgateway/url-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUrlTaskInfoRequest);
            return new SyncInvoker<ShowUrlTaskInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUrlTaskInfoResponse>);
        }
        
        /// <summary>
        /// 设置IP黑白名单
        ///
        /// 设置域名的IP黑白名单。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateBlackWhiteListResponse UpdateBlackWhiteList(UpdateBlackWhiteListRequest updateBlackWhiteListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateBlackWhiteListRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/ip-acl", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBlackWhiteListRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateBlackWhiteListResponse>(response);
        }

        public SyncInvoker<UpdateBlackWhiteListResponse> UpdateBlackWhiteListInvoker(UpdateBlackWhiteListRequest updateBlackWhiteListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateBlackWhiteListRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/ip-acl", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBlackWhiteListRequest);
            return new SyncInvoker<UpdateBlackWhiteListResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateBlackWhiteListResponse>);
        }
        
        /// <summary>
        /// 设置缓存规则
        ///
        /// 设置CDN节点上缓存资源的缓存策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateCacheRulesResponse UpdateCacheRules(UpdateCacheRulesRequest updateCacheRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateCacheRulesRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/cache", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCacheRulesRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateCacheRulesResponse>(response);
        }

        public SyncInvoker<UpdateCacheRulesResponse> UpdateCacheRulesInvoker(UpdateCacheRulesRequest updateCacheRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateCacheRulesRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/cache", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCacheRulesRequest);
            return new SyncInvoker<UpdateCacheRulesResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateCacheRulesResponse>);
        }
        
        /// <summary>
        /// 修改域名全量配置接口
        ///
        /// 修改域名配置接口，
        /// 支持修改回源请求头、HTTP header配置、URL鉴权、证书、源站、回源协议、强制重定向、智能压缩、IPv6开关、状态码缓存时间、Range回源、User-Agent黑白名单、改写回源URL、自定义错误页面、缓存规则、IP黑白名单、防盗链、强制跳转。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDomainFullConfigResponse UpdateDomainFullConfig(UpdateDomainFullConfigRequest updateDomainFullConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", updateDomainFullConfigRequest.DomainName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.1/cdn/configuration/domains/{domain_name}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainFullConfigRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateDomainFullConfigResponse>(response);
        }

        public SyncInvoker<UpdateDomainFullConfigResponse> UpdateDomainFullConfigInvoker(UpdateDomainFullConfigRequest updateDomainFullConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", updateDomainFullConfigRequest.DomainName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.1/cdn/configuration/domains/{domain_name}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainFullConfigRequest);
            return new SyncInvoker<UpdateDomainFullConfigResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDomainFullConfigResponse>);
        }
        
        /// <summary>
        /// 一个证书批量设置多个域名
        ///
        /// 一个证书配置多个域名，设置域名强制https回源参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDomainMultiCertificatesResponse UpdateDomainMultiCertificates(UpdateDomainMultiCertificatesRequest updateDomainMultiCertificatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/config-https-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainMultiCertificatesRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDomainMultiCertificatesResponse>(response);
        }

        public SyncInvoker<UpdateDomainMultiCertificatesResponse> UpdateDomainMultiCertificatesInvoker(UpdateDomainMultiCertificatesRequest updateDomainMultiCertificatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/config-https-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainMultiCertificatesRequest);
            return new SyncInvoker<UpdateDomainMultiCertificatesResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDomainMultiCertificatesResponse>);
        }
        
        /// <summary>
        /// 修改源站信息。
        ///
        /// 修改加速域名的源站配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDomainOriginResponse UpdateDomainOrigin(UpdateDomainOriginRequest updateDomainOriginRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateDomainOriginRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/origin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainOriginRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDomainOriginResponse>(response);
        }

        public SyncInvoker<UpdateDomainOriginResponse> UpdateDomainOriginInvoker(UpdateDomainOriginRequest updateDomainOriginRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateDomainOriginRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/origin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainOriginRequest);
            return new SyncInvoker<UpdateDomainOriginResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDomainOriginResponse>);
        }
        
        /// <summary>
        /// 开启/关闭回源跟随
        ///
        /// 开启此项配置后，当CDN节点回源请求源站返回301/302状态码时，CDN节点会先跳转到301/302对应地址获取资源并缓存后再返回给用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateFollow302SwitchResponse UpdateFollow302Switch(UpdateFollow302SwitchRequest updateFollow302SwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateFollow302SwitchRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/follow302-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFollow302SwitchRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateFollow302SwitchResponse>(response);
        }

        public SyncInvoker<UpdateFollow302SwitchResponse> UpdateFollow302SwitchInvoker(UpdateFollow302SwitchRequest updateFollow302SwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateFollow302SwitchRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/follow302-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFollow302SwitchRequest);
            return new SyncInvoker<UpdateFollow302SwitchResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateFollow302SwitchResponse>);
        }
        
        /// <summary>
        /// 配置HTTPS
        ///
        /// 设置加速域名HTTPS。通过配置加速域名的HTTPS证书，并将其部署在全网CDN节点，实现HTTPS安全加速。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateHttpsInfoResponse UpdateHttpsInfo(UpdateHttpsInfoRequest updateHttpsInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateHttpsInfoRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/https-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHttpsInfoRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateHttpsInfoResponse>(response);
        }

        public SyncInvoker<UpdateHttpsInfoResponse> UpdateHttpsInfoInvoker(UpdateHttpsInfoRequest updateHttpsInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateHttpsInfoRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/https-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHttpsInfoRequest);
            return new SyncInvoker<UpdateHttpsInfoResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateHttpsInfoResponse>);
        }
        
        /// <summary>
        /// 修改回源HOST。
        ///
        /// 修改回源HOST。回源HOST是CDN节点在回源过程中，在源站访问的站点域名，即http请求头中的host信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateOriginHostResponse UpdateOriginHost(UpdateOriginHostRequest updateOriginHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateOriginHostRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/originhost", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateOriginHostRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateOriginHostResponse>(response);
        }

        public SyncInvoker<UpdateOriginHostResponse> UpdateOriginHostInvoker(UpdateOriginHostRequest updateOriginHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateOriginHostRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/originhost", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateOriginHostRequest);
            return new SyncInvoker<UpdateOriginHostResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateOriginHostResponse>);
        }
        
        /// <summary>
        /// 修改私有桶开启关闭状态
        ///
        /// 修改私有桶开启关闭状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePrivateBucketAccessResponse UpdatePrivateBucketAccess(UpdatePrivateBucketAccessRequest updatePrivateBucketAccessRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updatePrivateBucketAccessRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/private-bucket-access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateBucketAccessRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePrivateBucketAccessResponse>(response);
        }

        public SyncInvoker<UpdatePrivateBucketAccessResponse> UpdatePrivateBucketAccessInvoker(UpdatePrivateBucketAccessRequest updatePrivateBucketAccessRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updatePrivateBucketAccessRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/private-bucket-access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateBucketAccessRequest);
            return new SyncInvoker<UpdatePrivateBucketAccessResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePrivateBucketAccessResponse>);
        }
        
        /// <summary>
        /// 开启/关闭Range回源
        ///
        /// Range回源是指源站在收到CDN节点回源请求时，根据http请求头中的Range信息返回指定范围的数据给CDN节点。
        /// 
        /// 开启Range回源前需要确认源站是否支持Range请求，若源站不支持Range请求，开启Range回源将导致资源无法缓存。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRangeSwitchResponse UpdateRangeSwitch(UpdateRangeSwitchRequest updateRangeSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateRangeSwitchRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/range-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRangeSwitchRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRangeSwitchResponse>(response);
        }

        public SyncInvoker<UpdateRangeSwitchResponse> UpdateRangeSwitchInvoker(UpdateRangeSwitchRequest updateRangeSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateRangeSwitchRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/range-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRangeSwitchRequest);
            return new SyncInvoker<UpdateRangeSwitchResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRangeSwitchResponse>);
        }
        
        /// <summary>
        /// 设置Referer过滤规则
        ///
        /// 设置Referer过滤规则。通过设置过滤策略，对访问者身份进行识别和过滤，实现限制访问来源的目的。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateReferResponse UpdateRefer(UpdateReferRequest updateReferRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateReferRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/referer", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateReferRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateReferResponse>(response);
        }

        public SyncInvoker<UpdateReferResponse> UpdateReferInvoker(UpdateReferRequest updateReferRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateReferRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/referer", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateReferRequest);
            return new SyncInvoker<UpdateReferResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateReferResponse>);
        }
        
        /// <summary>
        /// 新增/修改响应头配置
        ///
        /// 新增/修改域名响应头配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateResponseHeaderResponse UpdateResponseHeader(UpdateResponseHeaderRequest updateResponseHeaderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateResponseHeaderRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/response-header", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResponseHeaderRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateResponseHeaderResponse>(response);
        }

        public SyncInvoker<UpdateResponseHeaderResponse> UpdateResponseHeaderInvoker(UpdateResponseHeaderRequest updateResponseHeaderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateResponseHeaderRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/response-header", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResponseHeaderRequest);
            return new SyncInvoker<UpdateResponseHeaderResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateResponseHeaderResponse>);
        }
        
    }
}