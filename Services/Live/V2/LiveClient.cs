using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Live.V2.Model;

namespace HuaweiCloud.SDK.Live.V2
{
    public partial class LiveClient : Client
    {
        public static ClientBuilder<LiveClient> NewBuilder()
        {
            return new ClientBuilder<LiveClient>();
        }

        
        /// <summary>
        /// 查询直播各区域指标分布接口
        ///
        /// 查询直播全球区域维度的详细数据接口。
        /// 
        /// 如果不传入域名，则查询租户下所有播放域名的详细数据。
        /// 
        /// 当查询租户级别数据时，参数app、stream不生效。
        /// 
        /// 最大查询跨度1天，最大查询周期90天。
        /// 
        /// 支持查询当天，当前数据延时少于5分钟。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAreaDetailResponse ListAreaDetail(ListAreaDetailRequest listAreaDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/area/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAreaDetailRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAreaDetailResponse>(response);
        }
        
        /// <summary>
        /// 查询播放带宽趋势接口
        ///
        /// 查询播放域名带宽数据。
        /// 
        /// 如果不传入域名，则查询租户下所有播放域名的带宽数据。
        /// 
        /// 当查询租户级别带宽数据时，参数app、stream不生效。
        /// 
        /// 最大查询跨度31天，最大查询周期一年。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBandwidthDetailResponse ListBandwidthDetail(ListBandwidthDetailRequest listBandwidthDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/bandwidth/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthDetailRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListBandwidthDetailResponse>(response);
        }
        
        /// <summary>
        /// 查询播放带宽峰值接口
        ///
        /// 查询指定时间范围内播放带宽峰值。
        /// 
        /// 如果不传入域名，则查询租户下所有播放域名的带宽峰值。
        /// 
        /// 当查询租户级别带宽数据时，参数app、stream不生效。
        /// 
        /// 最大查询跨度31天，最大查询周期一年。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDomainBandwidthPeakResponse ListDomainBandwidthPeak(ListDomainBandwidthPeakRequest listDomainBandwidthPeakRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/bandwidth/peak",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainBandwidthPeakRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListDomainBandwidthPeakResponse>(response);
        }
        
        /// <summary>
        /// 查询播放流量趋势接口
        ///
        /// 查询播放域名流量数据。
        /// 
        /// 如果不传入域名，则查询租户下所有播放域名的流量数据。
        /// 
        /// 当查询租户级别流量数据时，参数app、stream不生效。
        /// 
        /// 最大查询跨度31天，最大查询周期一年。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDomainTrafficDetailResponse ListDomainTrafficDetail(ListDomainTrafficDetailRequest listDomainTrafficDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/traffic/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainTrafficDetailRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListDomainTrafficDetailResponse>(response);
        }
        
        /// <summary>
        /// 查询播放流量汇总接口
        ///
        /// 查询指定时间范围内流量汇总量。
        /// 
        /// 如果不传入域名，则查询租户下所有播放域名的流量汇总量。
        /// 
        /// 当查询租户级别流量数据时，参数app、stream不生效。
        /// 
        /// 最大查询跨度31天，最大查询周期一年。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDomainTrafficSummaryResponse ListDomainTrafficSummary(ListDomainTrafficSummaryRequest listDomainTrafficSummaryRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/traffic/summary",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainTrafficSummaryRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListDomainTrafficSummaryResponse>(response);
        }
        
        /// <summary>
        /// 查询历史推流列表接口
        ///
        /// 查询历史推流列表。
        /// 
        /// 不能查询现推流。
        /// 
        /// 最大查询跨度1天。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListHistoryStreamsResponse ListHistoryStreams(ListHistoryStreamsRequest listHistoryStreamsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/history/streams",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHistoryStreamsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListHistoryStreamsResponse>(response);
        }
        
        /// <summary>
        /// 查询直播拉流HTTP状态码接口
        ///
        /// 查询直播拉流HTTP状态码接口。  获取加速域名1分钟粒度的HTTP返回码  最大查询跨度不能超过24小时，最大查询周期7天。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListQueryHttpCodeResponse ListQueryHttpCode(ListQueryHttpCodeRequest listQueryHttpCodeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/httpcodes",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQueryHttpCodeRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListQueryHttpCodeResponse>(response);
        }
        
        /// <summary>
        /// 查询录制用量接口
        ///
        /// 查询直播租户每小时录制的最大并发数，计算1小时内每分钟的并发总路数，取最大值做为统计值。  最大查询跨度31天，最大查询周期90天。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRecordDataResponse ListRecordData(ListRecordDataRequest listRecordDataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/record",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordDataRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListRecordDataResponse>(response);
        }
        
        /// <summary>
        /// 查询截图用量接口
        ///
        /// 查询直播域名每小时的截图数量。  最大查询跨度31天，最大查询周期90天。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSnapshotDataResponse ListSnapshotData(ListSnapshotDataRequest listSnapshotDataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/snapshot",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSnapshotDataRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListSnapshotDataResponse>(response);
        }
        
        /// <summary>
        /// 查询转码用量接口
        ///
        /// 查询直播域名每小时的转码时长数据。  最大查询跨度31天，最大查询周期90天。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTranscodeDataResponse ListTranscodeData(ListTranscodeDataRequest listTranscodeDataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/transcode",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTranscodeDataRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListTranscodeDataResponse>(response);
        }
        
        /// <summary>
        /// 查询观众趋势接口
        ///
        /// 查询观众趋势。  最大查询跨度31天，最大查询周期一年。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUsersOfStreamResponse ListUsersOfStream(ListUsersOfStreamRequest listUsersOfStreamRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/user",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersOfStreamRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListUsersOfStreamResponse>(response);
        }
        
        /// <summary>
        /// 查询域名维度推流路数接口
        ///
        /// 查询域名维度推流路数接口。  最大查询跨度31天，最大查询周期1年。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowStreamCountResponse ShowStreamCount(ShowStreamCountRequest showStreamCountRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/stream-count",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStreamCountRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowStreamCountResponse>(response);
        }
        
        /// <summary>
        /// 查询播放画像信息接口
        ///
        /// 查询播放画像信息。  最大查询跨度1天，最大查询周期31天。
        /// 不统计协议为HLS的播放时长（play_duration）信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowStreamPortraitResponse ShowStreamPortrait(ShowStreamPortraitRequest showStreamPortraitRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/stream-portraits",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStreamPortraitRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowStreamPortraitResponse>(response);
        }
        
        /// <summary>
        /// 查询上行带宽数据接口
        ///
        /// 查询上行带宽数据。  最大查询跨度31天，最大查询周期1年。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowUpBandwidthResponse ShowUpBandwidth(ShowUpBandwidthRequest showUpBandwidthRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/up-bandwidth/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpBandwidthRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowUpBandwidthResponse>(response);
        }
        
        /// <summary>
        /// 查询推流码率数据接口
        ///
        /// 查询推流监控码率数据接口。
        /// 
        /// 最大查询跨度1天，最大查询周期1个月。
        /// 
        /// 返回的码率数据列表粒度为1秒钟。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSingleStreamBitrateResponse ListSingleStreamBitrate(ListSingleStreamBitrateRequest listSingleStreamBitrateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/stream/bitrate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSingleStreamBitrateRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListSingleStreamBitrateResponse>(response);
        }
        
        /// <summary>
        /// 查询推流监控数据接口
        ///
        /// 查询流监控数据接口，包括帧率码率断流情况。
        /// 
        /// 最大查询跨度1天，最大查询周期1个月。
        /// 
        /// 返回的码率数据列表粒度为1秒钟。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSingleStreamDetailResponse ListSingleStreamDetail(ListSingleStreamDetailRequest listSingleStreamDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/stream-detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSingleStreamDetailRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListSingleStreamDetailResponse>(response);
        }
        
        /// <summary>
        /// 查询推流帧率数据接口
        ///
        /// 查询推流帧率数据接口。
        /// 
        /// 最大查询跨度1天，最大查询周期1个月。
        /// 
        /// 返回的帧率数据列表粒度为1秒钟。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSingleStreamFramerateResponse ListSingleStreamFramerate(ListSingleStreamFramerateRequest listSingleStreamFramerateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/stream/framerate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSingleStreamFramerateRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListSingleStreamFramerateResponse>(response);
        }
        
        /// <summary>
        /// 查询CDN上行推流质量数据接口
        ///
        /// 查询CDN上行推流质量数据。
        /// 
        /// 最大查询跨度1天，最大查询周期7天。
        /// 
        /// 返回的CDN上行推流质量数据列表粒度为1分钟。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUpStreamDetailResponse ListUpStreamDetail(ListUpStreamDetailRequest listUpStreamDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/up-stream/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUpStreamDetailRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListUpStreamDetailResponse>(response);
        }
        
    }
}