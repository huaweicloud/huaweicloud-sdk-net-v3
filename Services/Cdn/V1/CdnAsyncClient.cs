using System;
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
        /// 删除资源标签配置接口
        ///
        /// 用于删除资源标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteTagsResponse> BatchDeleteTagsAsync(BatchDeleteTagsRequest batchDeleteTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/tags/batch-delete",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteTagsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchDeleteTagsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteTagsResponse> BatchDeleteTagsAsyncInvoker(BatchDeleteTagsRequest batchDeleteTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/tags/batch-delete",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteTagsRequest);
            return new AsyncInvoker<BatchDeleteTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteTagsResponse>);
        }
        
        /// <summary>
        /// 创建加速域名
        ///
        /// 创建加速域名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest createDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDomainRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateDomainResponse>(response);
        }

        public AsyncInvoker<CreateDomainResponse> CreateDomainAsyncInvoker(CreateDomainRequest createDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDomainRequest);
            return new AsyncInvoker<CreateDomainResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDomainResponse>);
        }
        
        /// <summary>
        /// 创建预热缓存任务
        ///
        /// 创建预热任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePreheatingTasksResponse> CreatePreheatingTasksAsync(CreatePreheatingTasksRequest createPreheatingTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/content/preheating-tasks",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPreheatingTasksRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreatePreheatingTasksResponse>(response);
        }

        public AsyncInvoker<CreatePreheatingTasksResponse> CreatePreheatingTasksAsyncInvoker(CreatePreheatingTasksRequest createPreheatingTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/content/preheating-tasks",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPreheatingTasksRequest);
            return new AsyncInvoker<CreatePreheatingTasksResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePreheatingTasksResponse>);
        }
        
        /// <summary>
        /// 创建刷新缓存任务
        ///
        /// 创建刷新缓存任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRefreshTasksResponse> CreateRefreshTasksAsync(CreateRefreshTasksRequest createRefreshTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/content/refresh-tasks",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRefreshTasksRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateRefreshTasksResponse>(response);
        }

        public AsyncInvoker<CreateRefreshTasksResponse> CreateRefreshTasksAsyncInvoker(CreateRefreshTasksRequest createRefreshTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/content/refresh-tasks",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRefreshTasksRequest);
            return new AsyncInvoker<CreateRefreshTasksResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRefreshTasksResponse>);
        }
        
        /// <summary>
        /// 创建资源标签配置接口
        ///
        /// 用于创建资源标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest createTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateTagsResponse>(response);
        }

        public AsyncInvoker<CreateTagsResponse> CreateTagsAsyncInvoker(CreateTagsRequest createTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagsRequest);
            return new AsyncInvoker<CreateTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateTagsResponse>);
        }
        
        /// <summary>
        /// 删除加速域名
        ///
        /// 删除加速域名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest deleteDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", deleteDomainRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteDomainResponse>(response);
        }

        public AsyncInvoker<DeleteDomainResponse> DeleteDomainAsyncInvoker(DeleteDomainRequest deleteDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", deleteDomainRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainRequest);
            return new AsyncInvoker<DeleteDomainResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDomainResponse>);
        }
        
        /// <summary>
        /// 停用加速域名
        ///
        /// 停用加速域名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisableDomainResponse> DisableDomainAsync(DisableDomainRequest disableDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", disableDomainRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/disable",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableDomainRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<DisableDomainResponse>(response);
        }

        public AsyncInvoker<DisableDomainResponse> DisableDomainAsyncInvoker(DisableDomainRequest disableDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", disableDomainRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/disable",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableDomainRequest);
            return new AsyncInvoker<DisableDomainResponse>(this, "PUT", request, JsonUtils.DeSerialize<DisableDomainResponse>);
        }
        
        /// <summary>
        /// 启用加速域名
        ///
        /// 启用加速域名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EnableDomainResponse> EnableDomainAsync(EnableDomainRequest enableDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", enableDomainRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/enable",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableDomainRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<EnableDomainResponse>(response);
        }

        public AsyncInvoker<EnableDomainResponse> EnableDomainAsyncInvoker(EnableDomainRequest enableDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", enableDomainRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/enable",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableDomainRequest);
            return new AsyncInvoker<EnableDomainResponse>(this, "PUT", request, JsonUtils.DeSerialize<EnableDomainResponse>);
        }
        
        /// <summary>
        /// 查询加速域名
        ///
        /// 查询加速域名信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest listDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDomainsResponse>(response);
        }

        public AsyncInvoker<ListDomainsResponse> ListDomainsAsyncInvoker(ListDomainsRequest listDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainsRequest);
            return new AsyncInvoker<ListDomainsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainsResponse>);
        }
        
        /// <summary>
        /// 查询IP黑白名单
        ///
        /// 查询域名已经设置的IP黑白名单。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBlackWhiteListResponse> ShowBlackWhiteListAsync(ShowBlackWhiteListRequest showBlackWhiteListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showBlackWhiteListRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/ip-acl",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBlackWhiteListRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowBlackWhiteListResponse>(response);
        }

        public AsyncInvoker<ShowBlackWhiteListResponse> ShowBlackWhiteListAsyncInvoker(ShowBlackWhiteListRequest showBlackWhiteListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showBlackWhiteListRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/ip-acl",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBlackWhiteListRequest);
            return new AsyncInvoker<ShowBlackWhiteListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBlackWhiteListResponse>);
        }
        
        /// <summary>
        /// 查询缓存规则
        ///
        /// 查询缓存规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCacheRulesResponse> ShowCacheRulesAsync(ShowCacheRulesRequest showCacheRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showCacheRulesRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/cache",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCacheRulesRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowCacheRulesResponse>(response);
        }

        public AsyncInvoker<ShowCacheRulesResponse> ShowCacheRulesAsyncInvoker(ShowCacheRulesRequest showCacheRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showCacheRulesRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/cache",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCacheRulesRequest);
            return new AsyncInvoker<ShowCacheRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCacheRulesResponse>);
        }
        
        /// <summary>
        /// 查询所有绑定HTTPS证书的域名信息
        ///
        /// 查询所有绑定HTTPS证书的域名信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCertificatesHttpsInfoResponse> ShowCertificatesHttpsInfoAsync(ShowCertificatesHttpsInfoRequest showCertificatesHttpsInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/https-certificate-info",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCertificatesHttpsInfoRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowCertificatesHttpsInfoResponse>(response);
        }

        public AsyncInvoker<ShowCertificatesHttpsInfoResponse> ShowCertificatesHttpsInfoAsyncInvoker(ShowCertificatesHttpsInfoRequest showCertificatesHttpsInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/https-certificate-info",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCertificatesHttpsInfoRequest);
            return new AsyncInvoker<ShowCertificatesHttpsInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCertificatesHttpsInfoResponse>);
        }
        
        /// <summary>
        /// 查询加速域名详情
        ///
        /// 查询加速域名详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainDetailResponse> ShowDomainDetailAsync(ShowDomainDetailRequest showDomainDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showDomainDetailRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/detail",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainDetailRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainDetailResponse>(response);
        }

        public AsyncInvoker<ShowDomainDetailResponse> ShowDomainDetailAsyncInvoker(ShowDomainDetailRequest showDomainDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showDomainDetailRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/detail",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainDetailRequest);
            return new AsyncInvoker<ShowDomainDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainDetailResponse>);
        }
        
        /// <summary>
        /// 查询域名配置接口
        ///
        /// 查询域名配置接口，
        /// 支持查询回源请求头、HTTP header配置、URL鉴权、证书、源站、回源协议、强制重定向、智能压缩、IPv6开关、状态码缓存时间、Range回源、User-Agent黑白名单、改写回源URL、自定义错误页面、缓存规则、IP黑白名单、防盗链、强制跳转。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainFullConfigResponse> ShowDomainFullConfigAsync(ShowDomainFullConfigRequest showDomainFullConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", showDomainFullConfigRequest.DomainName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.1/cdn/configuration/domains/{domain_name}/configs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainFullConfigRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainFullConfigResponse>(response);
        }

        public AsyncInvoker<ShowDomainFullConfigResponse> ShowDomainFullConfigAsyncInvoker(ShowDomainFullConfigRequest showDomainFullConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", showDomainFullConfigRequest.DomainName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.1/cdn/configuration/domains/{domain_name}/configs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainFullConfigRequest);
            return new AsyncInvoker<ShowDomainFullConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainFullConfigResponse>);
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
        public async Task<ShowDomainItemDetailsResponse> ShowDomainItemDetailsAsync(ShowDomainItemDetailsRequest showDomainItemDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-item-details",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainItemDetailsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainItemDetailsResponse>(response);
        }

        public AsyncInvoker<ShowDomainItemDetailsResponse> ShowDomainItemDetailsAsyncInvoker(ShowDomainItemDetailsRequest showDomainItemDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-item-details",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainItemDetailsRequest);
            return new AsyncInvoker<ShowDomainItemDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainItemDetailsResponse>);
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
        public async Task<ShowDomainItemLocationDetailsResponse> ShowDomainItemLocationDetailsAsync(ShowDomainItemLocationDetailsRequest showDomainItemLocationDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-item-location-details",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainItemLocationDetailsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainItemLocationDetailsResponse>(response);
        }

        public AsyncInvoker<ShowDomainItemLocationDetailsResponse> ShowDomainItemLocationDetailsAsyncInvoker(ShowDomainItemLocationDetailsRequest showDomainItemLocationDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-item-location-details",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainItemLocationDetailsRequest);
            return new AsyncInvoker<ShowDomainItemLocationDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainItemLocationDetailsResponse>);
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
        public async Task<ShowDomainLocationStatsResponse> ShowDomainLocationStatsAsync(ShowDomainLocationStatsRequest showDomainLocationStatsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-location-stats",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainLocationStatsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainLocationStatsResponse>(response);
        }

        public AsyncInvoker<ShowDomainLocationStatsResponse> ShowDomainLocationStatsAsyncInvoker(ShowDomainLocationStatsRequest showDomainLocationStatsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-location-stats",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainLocationStatsRequest);
            return new AsyncInvoker<ShowDomainLocationStatsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainLocationStatsResponse>);
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
        public async Task<ShowDomainStatsResponse> ShowDomainStatsAsync(ShowDomainStatsRequest showDomainStatsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-stats",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainStatsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainStatsResponse>(response);
        }

        public AsyncInvoker<ShowDomainStatsResponse> ShowDomainStatsAsyncInvoker(ShowDomainStatsRequest showDomainStatsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-stats",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainStatsRequest);
            return new AsyncInvoker<ShowDomainStatsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainStatsResponse>);
        }
        
        /// <summary>
        /// 查询刷新预热任务详情
        ///
        /// 查询刷新预热任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowHistoryTaskDetailsResponse> ShowHistoryTaskDetailsAsync(ShowHistoryTaskDetailsRequest showHistoryTaskDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("history_tasks_id", showHistoryTaskDetailsRequest.HistoryTasksId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/historytasks/{history_tasks_id}/detail",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHistoryTaskDetailsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowHistoryTaskDetailsResponse>(response);
        }

        public AsyncInvoker<ShowHistoryTaskDetailsResponse> ShowHistoryTaskDetailsAsyncInvoker(ShowHistoryTaskDetailsRequest showHistoryTaskDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("history_tasks_id", showHistoryTaskDetailsRequest.HistoryTasksId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/historytasks/{history_tasks_id}/detail",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHistoryTaskDetailsRequest);
            return new AsyncInvoker<ShowHistoryTaskDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHistoryTaskDetailsResponse>);
        }
        
        /// <summary>
        /// 查询刷新预热任务
        ///
        /// 查询刷新预热任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowHistoryTasksResponse> ShowHistoryTasksAsync(ShowHistoryTasksRequest showHistoryTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/historytasks",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHistoryTasksRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowHistoryTasksResponse>(response);
        }

        public AsyncInvoker<ShowHistoryTasksResponse> ShowHistoryTasksAsyncInvoker(ShowHistoryTasksRequest showHistoryTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/historytasks",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHistoryTasksRequest);
            return new AsyncInvoker<ShowHistoryTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHistoryTasksResponse>);
        }
        
        /// <summary>
        /// 查询HTTPS配置
        ///
        /// 获取加速域名证书。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowHttpInfoResponse> ShowHttpInfoAsync(ShowHttpInfoRequest showHttpInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showHttpInfoRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/https-info",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHttpInfoRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowHttpInfoResponse>(response);
        }

        public AsyncInvoker<ShowHttpInfoResponse> ShowHttpInfoAsyncInvoker(ShowHttpInfoRequest showHttpInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showHttpInfoRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/https-info",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHttpInfoRequest);
            return new AsyncInvoker<ShowHttpInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHttpInfoResponse>);
        }
        
        /// <summary>
        /// 查询IP归属信息
        ///
        /// 查询IP归属信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowIpInfoResponse> ShowIpInfoAsync(ShowIpInfoRequest showIpInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/ip-info",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpInfoRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowIpInfoResponse>(response);
        }

        public AsyncInvoker<ShowIpInfoResponse> ShowIpInfoAsyncInvoker(ShowIpInfoRequest showIpInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/ip-info",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpInfoRequest);
            return new AsyncInvoker<ShowIpInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowIpInfoResponse>);
        }
        
        /// <summary>
        /// 日志查询
        ///
        /// 查询日志下载链接，支持查询30天内的日志信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowLogsResponse> ShowLogsAsync(ShowLogsRequest showLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/logs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowLogsResponse>(response);
        }

        public AsyncInvoker<ShowLogsResponse> ShowLogsAsyncInvoker(ShowLogsRequest showLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/logs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogsRequest);
            return new AsyncInvoker<ShowLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLogsResponse>);
        }
        
        /// <summary>
        /// 查询回源HOST
        ///
        /// 查询回源HOST。回源HOST是CDN节点在回源过程中，在源站访问的站点域名，即http请求头中的host信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowOriginHostResponse> ShowOriginHostAsync(ShowOriginHostRequest showOriginHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showOriginHostRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/originhost",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOriginHostRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowOriginHostResponse>(response);
        }

        public AsyncInvoker<ShowOriginHostResponse> ShowOriginHostAsyncInvoker(ShowOriginHostRequest showOriginHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showOriginHostRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/originhost",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOriginHostRequest);
            return new AsyncInvoker<ShowOriginHostResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOriginHostResponse>);
        }
        
        /// <summary>
        /// 查询用户配额
        ///
        /// 查询当前用户域名、刷新文件、刷新目录和预热的配额
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowQuotaResponse> ShowQuotaAsync(ShowQuotaRequest showQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/quota",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowQuotaResponse>(response);
        }

        public AsyncInvoker<ShowQuotaResponse> ShowQuotaAsyncInvoker(ShowQuotaRequest showQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/quota",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaRequest);
            return new AsyncInvoker<ShowQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowQuotaResponse>);
        }
        
        /// <summary>
        /// 查询Referer过滤规则
        ///
        /// 查询Referer过滤规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowReferResponse> ShowReferAsync(ShowReferRequest showReferRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showReferRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/referer",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReferRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowReferResponse>(response);
        }

        public AsyncInvoker<ShowReferResponse> ShowReferAsyncInvoker(ShowReferRequest showReferRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showReferRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/referer",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReferRequest);
            return new AsyncInvoker<ShowReferResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowReferResponse>);
        }
        
        /// <summary>
        /// 查询响应头配置
        ///
        /// 列举header所有配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowResponseHeaderResponse> ShowResponseHeaderAsync(ShowResponseHeaderRequest showResponseHeaderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showResponseHeaderRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/response-header",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResponseHeaderRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowResponseHeaderResponse>(response);
        }

        public AsyncInvoker<ShowResponseHeaderResponse> ShowResponseHeaderAsyncInvoker(ShowResponseHeaderRequest showResponseHeaderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showResponseHeaderRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/response-header",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResponseHeaderRequest);
            return new AsyncInvoker<ShowResponseHeaderResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResponseHeaderResponse>);
        }
        
        /// <summary>
        /// 查询资源标签列表配置接口
        ///
        /// 用于查询资源标签列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTagsResponse> ShowTagsAsync(ShowTagsRequest showTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTagsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowTagsResponse>(response);
        }

        public AsyncInvoker<ShowTagsResponse> ShowTagsAsyncInvoker(ShowTagsRequest showTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTagsRequest);
            return new AsyncInvoker<ShowTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTagsResponse>);
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
        public async Task<ShowTopUrlResponse> ShowTopUrlAsync(ShowTopUrlRequest showTopUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/top-url",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopUrlRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowTopUrlResponse>(response);
        }

        public AsyncInvoker<ShowTopUrlResponse> ShowTopUrlAsyncInvoker(ShowTopUrlRequest showTopUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/top-url",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopUrlRequest);
            return new AsyncInvoker<ShowTopUrlResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTopUrlResponse>);
        }
        
        /// <summary>
        /// 查询刷新预热URL记录
        ///
        /// 查询刷新预热URL记录。如需此接口，请提交工单开通。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowUrlTaskInfoResponse> ShowUrlTaskInfoAsync(ShowUrlTaskInfoRequest showUrlTaskInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/contentgateway/url-tasks",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUrlTaskInfoRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowUrlTaskInfoResponse>(response);
        }

        public AsyncInvoker<ShowUrlTaskInfoResponse> ShowUrlTaskInfoAsyncInvoker(ShowUrlTaskInfoRequest showUrlTaskInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/contentgateway/url-tasks",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUrlTaskInfoRequest);
            return new AsyncInvoker<ShowUrlTaskInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUrlTaskInfoResponse>);
        }
        
        /// <summary>
        /// 设置IP黑白名单
        ///
        /// 设置域名的IP黑白名单。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateBlackWhiteListResponse> UpdateBlackWhiteListAsync(UpdateBlackWhiteListRequest updateBlackWhiteListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateBlackWhiteListRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/ip-acl",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBlackWhiteListRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateBlackWhiteListResponse>(response);
        }

        public AsyncInvoker<UpdateBlackWhiteListResponse> UpdateBlackWhiteListAsyncInvoker(UpdateBlackWhiteListRequest updateBlackWhiteListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateBlackWhiteListRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/ip-acl",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBlackWhiteListRequest);
            return new AsyncInvoker<UpdateBlackWhiteListResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateBlackWhiteListResponse>);
        }
        
        /// <summary>
        /// 设置缓存规则
        ///
        /// 设置CDN节点上缓存资源的缓存策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateCacheRulesResponse> UpdateCacheRulesAsync(UpdateCacheRulesRequest updateCacheRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateCacheRulesRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/cache",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCacheRulesRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateCacheRulesResponse>(response);
        }

        public AsyncInvoker<UpdateCacheRulesResponse> UpdateCacheRulesAsyncInvoker(UpdateCacheRulesRequest updateCacheRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateCacheRulesRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/cache",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCacheRulesRequest);
            return new AsyncInvoker<UpdateCacheRulesResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateCacheRulesResponse>);
        }
        
        /// <summary>
        /// 修改域名全量配置接口
        ///
        /// 修改域名配置接口，
        /// 支持修改回源请求头、HTTP header配置、URL鉴权、证书、源站、回源协议、强制重定向、智能压缩、IPv6开关、状态码缓存时间、Range回源、User-Agent黑白名单、改写回源URL、自定义错误页面、缓存规则、IP黑白名单、防盗链、强制跳转。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDomainFullConfigResponse> UpdateDomainFullConfigAsync(UpdateDomainFullConfigRequest updateDomainFullConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", updateDomainFullConfigRequest.DomainName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.1/cdn/configuration/domains/{domain_name}/configs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainFullConfigRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateDomainFullConfigResponse>(response);
        }

        public AsyncInvoker<UpdateDomainFullConfigResponse> UpdateDomainFullConfigAsyncInvoker(UpdateDomainFullConfigRequest updateDomainFullConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", updateDomainFullConfigRequest.DomainName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.1/cdn/configuration/domains/{domain_name}/configs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainFullConfigRequest);
            return new AsyncInvoker<UpdateDomainFullConfigResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDomainFullConfigResponse>);
        }
        
        /// <summary>
        /// 一个证书批量设置多个域名
        ///
        /// 一个证书配置多个域名，设置域名强制https回源参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDomainMultiCertificatesResponse> UpdateDomainMultiCertificatesAsync(UpdateDomainMultiCertificatesRequest updateDomainMultiCertificatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/config-https-info",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainMultiCertificatesRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDomainMultiCertificatesResponse>(response);
        }

        public AsyncInvoker<UpdateDomainMultiCertificatesResponse> UpdateDomainMultiCertificatesAsyncInvoker(UpdateDomainMultiCertificatesRequest updateDomainMultiCertificatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/config-https-info",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainMultiCertificatesRequest);
            return new AsyncInvoker<UpdateDomainMultiCertificatesResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDomainMultiCertificatesResponse>);
        }
        
        /// <summary>
        /// 修改源站信息。
        ///
        /// 修改加速域名的源站配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDomainOriginResponse> UpdateDomainOriginAsync(UpdateDomainOriginRequest updateDomainOriginRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateDomainOriginRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/origin",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainOriginRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDomainOriginResponse>(response);
        }

        public AsyncInvoker<UpdateDomainOriginResponse> UpdateDomainOriginAsyncInvoker(UpdateDomainOriginRequest updateDomainOriginRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateDomainOriginRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/origin",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainOriginRequest);
            return new AsyncInvoker<UpdateDomainOriginResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDomainOriginResponse>);
        }
        
        /// <summary>
        /// 开启/关闭回源跟随
        ///
        /// 开启此项配置后，当CDN节点回源请求源站返回301/302状态码时，CDN节点会先跳转到301/302对应地址获取资源并缓存后再返回给用户。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateFollow302SwitchResponse> UpdateFollow302SwitchAsync(UpdateFollow302SwitchRequest updateFollow302SwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateFollow302SwitchRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/follow302-switch",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFollow302SwitchRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateFollow302SwitchResponse>(response);
        }

        public AsyncInvoker<UpdateFollow302SwitchResponse> UpdateFollow302SwitchAsyncInvoker(UpdateFollow302SwitchRequest updateFollow302SwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateFollow302SwitchRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/follow302-switch",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFollow302SwitchRequest);
            return new AsyncInvoker<UpdateFollow302SwitchResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateFollow302SwitchResponse>);
        }
        
        /// <summary>
        /// 配置HTTPS
        ///
        /// 设置加速域名HTTPS。通过配置加速域名的HTTPS证书，并将其部署在全网CDN节点，实现HTTPS安全加速。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateHttpsInfoResponse> UpdateHttpsInfoAsync(UpdateHttpsInfoRequest updateHttpsInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateHttpsInfoRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/https-info",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHttpsInfoRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateHttpsInfoResponse>(response);
        }

        public AsyncInvoker<UpdateHttpsInfoResponse> UpdateHttpsInfoAsyncInvoker(UpdateHttpsInfoRequest updateHttpsInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateHttpsInfoRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/https-info",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHttpsInfoRequest);
            return new AsyncInvoker<UpdateHttpsInfoResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateHttpsInfoResponse>);
        }
        
        /// <summary>
        /// 修改回源HOST。
        ///
        /// 修改回源HOST。回源HOST是CDN节点在回源过程中，在源站访问的站点域名，即http请求头中的host信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateOriginHostResponse> UpdateOriginHostAsync(UpdateOriginHostRequest updateOriginHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateOriginHostRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/originhost",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateOriginHostRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateOriginHostResponse>(response);
        }

        public AsyncInvoker<UpdateOriginHostResponse> UpdateOriginHostAsyncInvoker(UpdateOriginHostRequest updateOriginHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateOriginHostRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/originhost",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateOriginHostRequest);
            return new AsyncInvoker<UpdateOriginHostResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateOriginHostResponse>);
        }
        
        /// <summary>
        /// 修改私有桶开启关闭状态
        ///
        /// 修改私有桶开启关闭状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePrivateBucketAccessResponse> UpdatePrivateBucketAccessAsync(UpdatePrivateBucketAccessRequest updatePrivateBucketAccessRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updatePrivateBucketAccessRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/private-bucket-access",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateBucketAccessRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePrivateBucketAccessResponse>(response);
        }

        public AsyncInvoker<UpdatePrivateBucketAccessResponse> UpdatePrivateBucketAccessAsyncInvoker(UpdatePrivateBucketAccessRequest updatePrivateBucketAccessRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updatePrivateBucketAccessRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/private-bucket-access",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateBucketAccessRequest);
            return new AsyncInvoker<UpdatePrivateBucketAccessResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePrivateBucketAccessResponse>);
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
        public async Task<UpdateRangeSwitchResponse> UpdateRangeSwitchAsync(UpdateRangeSwitchRequest updateRangeSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateRangeSwitchRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/range-switch",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRangeSwitchRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateRangeSwitchResponse>(response);
        }

        public AsyncInvoker<UpdateRangeSwitchResponse> UpdateRangeSwitchAsyncInvoker(UpdateRangeSwitchRequest updateRangeSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateRangeSwitchRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/range-switch",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRangeSwitchRequest);
            return new AsyncInvoker<UpdateRangeSwitchResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRangeSwitchResponse>);
        }
        
        /// <summary>
        /// 设置Referer过滤规则
        ///
        /// 设置Referer过滤规则。通过设置过滤策略，对访问者身份进行识别和过滤，实现限制访问来源的目的。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateReferResponse> UpdateReferAsync(UpdateReferRequest updateReferRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateReferRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/referer",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateReferRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateReferResponse>(response);
        }

        public AsyncInvoker<UpdateReferResponse> UpdateReferAsyncInvoker(UpdateReferRequest updateReferRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateReferRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/referer",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateReferRequest);
            return new AsyncInvoker<UpdateReferResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateReferResponse>);
        }
        
        /// <summary>
        /// 新增/修改响应头配置
        ///
        /// 新增/修改域名响应头配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateResponseHeaderResponse> UpdateResponseHeaderAsync(UpdateResponseHeaderRequest updateResponseHeaderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateResponseHeaderRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/response-header",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResponseHeaderRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateResponseHeaderResponse>(response);
        }

        public AsyncInvoker<UpdateResponseHeaderResponse> UpdateResponseHeaderAsyncInvoker(UpdateResponseHeaderRequest updateResponseHeaderRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateResponseHeaderRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/response-header",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResponseHeaderRequest);
            return new AsyncInvoker<UpdateResponseHeaderResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateResponseHeaderResponse>);
        }
        
    }
}