using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Cdn.V2.Model;

namespace HuaweiCloud.SDK.Cdn.V2
{
    public partial class CdnClient : Client
    {
        public static ClientBuilder<CdnClient> NewBuilder()
        {
            return new ClientBuilder<CdnClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 批量域名复制
        ///
        /// 批量域名复制接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCopyDomainResponse BatchCopyDomain(BatchCopyDomainRequest batchCopyDomainRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/batch-copy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCopyDomainRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<BatchCopyDomainResponse>(response);
        }
        
        /// <summary>
        /// 下载区域运营商指标数据表格文件
        ///
        /// - 下载区域运营商指标数据表格文件。
        /// 
        /// - 支持下载90天内的指标数据表格。
        /// 
        /// - 时间跨度不能超过31天。
        /// 
        /// - 起始时间和结束时间，左闭右开。如时间跨度为2022-10-24 00:00:00 到 2022-10-25 00:00:00，表示取 [2022-10-24 00:00:00, 2022-10-25 00:00:00)的统计数据。
        /// 
        /// - 起始时间、结束时间必须传毫秒级时间戳，起始时间和结束时间必须同时指定。
        /// 
        /// - 单租户调用频率：10次/min。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DownloadRegionCarrierExcelResponse DownloadRegionCarrierExcel(DownloadRegionCarrierExcelRequest downloadRegionCarrierExcelRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/region-carrier-excel",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadRegionCarrierExcelRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerializeNull<DownloadRegionCarrierExcelResponse>(response);
        }
        
        /// <summary>
        /// 下载统计指标数据表格文件
        ///
        /// - 下载统计指标数据表格文件。
        /// 
        /// - 支持下载90天内的指标数据。
        /// 
        /// - 时间跨度不能超过31天。
        /// 
        /// - 起始时间和结束时间，左闭右开。如时间跨度为2022-10-24 00:00:00 到 2022-10-25 00:00:00，表示取 [2022-10-24 00:00:00, 2022-10-25 00:00:00)的统计数据。
        /// 
        /// - 起始时间、结束时间必须传毫秒级时间戳，起始时间和结束时间必须同时指定。
        /// 
        /// - 单租户调用频率：10次/min。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DownloadStatisticsExcelResponse DownloadStatisticsExcel(DownloadStatisticsExcelRequest downloadStatisticsExcelRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/statistics-excel",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadStatisticsExcelRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerializeNull<DownloadStatisticsExcelResponse>(response);
        }
        
        /// <summary>
        /// 查询加速域名
        ///
        /// 查询加速域名
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        /// 设置用户计费模式
        ///
        /// - 设置用户计费模式。
        /// 
        /// - 服务区域仅支持mainland_china（国内）
        /// 
        /// - 计费模式仅支持设置flux（流量），v2及以上客户支持bw（带宽）
        /// 
        /// - 加速类型仅支持base（基础加速）
        /// 
        /// - 单租户调用频率：10次/min。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetChargeModesResponse SetChargeModes(SetChargeModesRequest setChargeModesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/charge/charge-modes",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", setChargeModesRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<SetChargeModesResponse>(response);
        }
        
        /// <summary>
        /// 查询域名带宽峰值类数据
        ///
        /// - 查询域名带宽峰值类数据。
        /// 
        /// - 支持查询90天内的数据。
        /// 
        /// - 查询时间跨度不能超过31天。
        /// 
        /// - 起始时间和结束时间，左闭右开。如查询2022-10-24 00:00:00 到 2022-10-25 00:00:00 的数据，表示取 [2022-10-24 00:00:00, 2022-10-25 00:00:00)的统计数据。
        /// 
        /// - 起始时间、结束时间必须传毫秒级时间戳，起始时间和结束时间必须同时指定。
        /// 
        /// - 流量类指标单位统一为Byte（字节）、带宽类指标单位统一为bit/s（比特/秒）、峰值类指标单位统一为bps（比特率），请求数类和状态码类指标单位统一为次数。用于查询指定域名、指定统计指标的明细数据。
        /// 
        /// - 单租户调用频率：2次/s。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBandwidthCalcResponse ShowBandwidthCalc(ShowBandwidthCalcRequest showBandwidthCalcRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/bandwidth-calc",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBandwidthCalcRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowBandwidthCalcResponse>(response);
        }
        
        /// <summary>
        /// 查询用户计费模式
        ///
        /// - 查询用户计费模式。
        /// 
        /// - 服务区域仅支持mainland_china（国内，默认）和outside_mainland_china（海外）
        /// 
        /// - 计费模式状态支持active（已生效），upcoming（待生效）两种状态，默认为active(已生效)
        /// 
        /// - 加速类型仅支持base（基础加速）
        /// 
        /// - 单租户调用频率：5次/s。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowChargeModesResponse ShowChargeModes(ShowChargeModesRequest showChargeModesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/charge/charge-modes",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showChargeModesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowChargeModesResponse>(response);
        }
        
        /// <summary>
        /// 查询加速域名详情
        ///
        /// 加速域名详情信息接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDomainDetailByNameResponse ShowDomainDetailByName(ShowDomainDetailByNameRequest showDomainDetailByNameRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name" , showDomainDetailByNameRequest.DomainName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/{domain_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainDetailByNameRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainDetailByNameResponse>(response);
        }
        
        /// <summary>
        /// 查询域名配置接口
        ///
        /// 查询域名配置接口，
        /// 支持查询回源请求头、HTTP header配置、URL鉴权、证书、源站、回源协议、回源跟随、ipv6设置、智能压缩、状态码缓存时间、Range回源、User-Agent黑白名单、改写回源URL、自定义错误页面、缓存规则、IP黑白名单、防盗链、强制跳转、高级回源、回源是否校验Etag、回源超时时间、远程鉴权配置、webSocket配置、视频拖拽、请求限速。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        /// 查询域名统计区域运营商数据
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-location-stats",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainLocationStatsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainLocationStatsResponse>(response);
        }
        
        /// <summary>
        /// 查询域名统计基础数据
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-stats",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainStatsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainStatsResponse>(response);
        }
        
        /// <summary>
        /// 查询TOP域名
        ///
        /// - 查询TOP域名。
        /// 
        /// - 支持查询90天内的数据。
        /// 
        /// - 查询时间跨度不能超过1天。
        /// 
        /// - 起始时间和结束时间，左闭右开，必须同时指定。如查询2022-10-24 00:00:00 到 2022-10-25 00:00:00 的数据，表示取 [2022-10-24 00:00:00, 2022-10-25 00:00:00)的统计数据。
        /// 
        /// - 起始时间、结束时间必须传整点毫秒级时间戳。
        /// 
        /// - 流量类指标单位统一为Byte（字节）、带宽类指标单位统一为bit/s（比特/秒）、请求数类和状态码类指标单位统一为次数。用于查询指定域名、指定统计指标的明细数据。
        /// 
        /// - 单租户调用频率：5次/s。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTopDomainNamesResponse ShowTopDomainNames(ShowTopDomainNamesRequest showTopDomainNamesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cdn/statistics/top-domain-names",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopDomainNamesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowTopDomainNamesResponse>(response);
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
        /// - 起始时间和结束时间，左闭右开，需要同时指定。如查询2021-10-24 00:00:00 到 2021-10-25 00:00:00 的数据，表示取 [2021-10-24 00:00:00, 2021-10-25 00:00:00)的统计数据。
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/top-url",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopUrlRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowTopUrlResponse>(response);
        }
        
        /// <summary>
        /// 修改域名全量配置接口
        ///
        /// 修改域名配置接口，
        /// 支持修改回源请求头、HTTP header配置、URL鉴权、证书、源站、回源协议、回源跟随、ipv6设置、智能压缩、状态码缓存时间、Range回源、User-Agent黑白名单、改写回源URL、自定义错误页面、缓存规则、IP黑白名单、防盗链、强制跳转、高级回源、回源是否校验Etag、回源超时时间、远程鉴权配置、webSocket配置、视频拖拽、请求限速。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
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
        
    }
}