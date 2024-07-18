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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/area/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAreaDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAreaDetailResponse>(response);
        }

        public SyncInvoker<ListAreaDetailResponse> ListAreaDetailInvoker(ListAreaDetailRequest listAreaDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/area/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAreaDetailRequest);
            return new SyncInvoker<ListAreaDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAreaDetailResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/bandwidth/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBandwidthDetailResponse>(response);
        }

        public SyncInvoker<ListBandwidthDetailResponse> ListBandwidthDetailInvoker(ListBandwidthDetailRequest listBandwidthDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/bandwidth/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthDetailRequest);
            return new SyncInvoker<ListBandwidthDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBandwidthDetailResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/bandwidth/peak", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainBandwidthPeakRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDomainBandwidthPeakResponse>(response);
        }

        public SyncInvoker<ListDomainBandwidthPeakResponse> ListDomainBandwidthPeakInvoker(ListDomainBandwidthPeakRequest listDomainBandwidthPeakRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/bandwidth/peak", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainBandwidthPeakRequest);
            return new SyncInvoker<ListDomainBandwidthPeakResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainBandwidthPeakResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/traffic/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainTrafficDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDomainTrafficDetailResponse>(response);
        }

        public SyncInvoker<ListDomainTrafficDetailResponse> ListDomainTrafficDetailInvoker(ListDomainTrafficDetailRequest listDomainTrafficDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/traffic/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainTrafficDetailRequest);
            return new SyncInvoker<ListDomainTrafficDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainTrafficDetailResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/traffic/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainTrafficSummaryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDomainTrafficSummaryResponse>(response);
        }

        public SyncInvoker<ListDomainTrafficSummaryResponse> ListDomainTrafficSummaryInvoker(ListDomainTrafficSummaryRequest listDomainTrafficSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/traffic/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainTrafficSummaryRequest);
            return new SyncInvoker<ListDomainTrafficSummaryResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainTrafficSummaryResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/history/streams", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHistoryStreamsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListHistoryStreamsResponse>(response);
        }

        public SyncInvoker<ListHistoryStreamsResponse> ListHistoryStreamsInvoker(ListHistoryStreamsRequest listHistoryStreamsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/history/streams", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHistoryStreamsRequest);
            return new SyncInvoker<ListHistoryStreamsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHistoryStreamsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/httpcodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQueryHttpCodeRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListQueryHttpCodeResponse>(response);
        }

        public SyncInvoker<ListQueryHttpCodeResponse> ListQueryHttpCodeInvoker(ListQueryHttpCodeRequest listQueryHttpCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/httpcodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQueryHttpCodeRequest);
            return new SyncInvoker<ListQueryHttpCodeResponse>(this, "GET", request, JsonUtils.DeSerialize<ListQueryHttpCodeResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/record", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordDataRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRecordDataResponse>(response);
        }

        public SyncInvoker<ListRecordDataResponse> ListRecordDataInvoker(ListRecordDataRequest listRecordDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/record", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordDataRequest);
            return new SyncInvoker<ListRecordDataResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRecordDataResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/snapshot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSnapshotDataRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSnapshotDataResponse>(response);
        }

        public SyncInvoker<ListSnapshotDataResponse> ListSnapshotDataInvoker(ListSnapshotDataRequest listSnapshotDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/snapshot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSnapshotDataRequest);
            return new SyncInvoker<ListSnapshotDataResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSnapshotDataResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/transcode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTranscodeDataRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTranscodeDataResponse>(response);
        }

        public SyncInvoker<ListTranscodeDataResponse> ListTranscodeDataInvoker(ListTranscodeDataRequest listTranscodeDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/transcode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTranscodeDataRequest);
            return new SyncInvoker<ListTranscodeDataResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTranscodeDataResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersOfStreamRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUsersOfStreamResponse>(response);
        }

        public SyncInvoker<ListUsersOfStreamResponse> ListUsersOfStreamInvoker(ListUsersOfStreamRequest listUsersOfStreamRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersOfStreamRequest);
            return new SyncInvoker<ListUsersOfStreamResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUsersOfStreamResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/stream-count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStreamCountRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowStreamCountResponse>(response);
        }

        public SyncInvoker<ShowStreamCountResponse> ShowStreamCountInvoker(ShowStreamCountRequest showStreamCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/stream-count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStreamCountRequest);
            return new SyncInvoker<ShowStreamCountResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStreamCountResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/stream-portraits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStreamPortraitRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowStreamPortraitResponse>(response);
        }

        public SyncInvoker<ShowStreamPortraitResponse> ShowStreamPortraitInvoker(ShowStreamPortraitRequest showStreamPortraitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/stream-portraits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStreamPortraitRequest);
            return new SyncInvoker<ShowStreamPortraitResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStreamPortraitResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/up-bandwidth/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpBandwidthRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowUpBandwidthResponse>(response);
        }

        public SyncInvoker<ShowUpBandwidthResponse> ShowUpBandwidthInvoker(ShowUpBandwidthRequest showUpBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/up-bandwidth/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpBandwidthRequest);
            return new SyncInvoker<ShowUpBandwidthResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUpBandwidthResponse>);
        }
        
        /// <summary>
        /// 查询播放域名下的流数据
        ///
        /// 查询播放域名下的监控数据，根据输入时间点，返回查询该时间点所有流的带宽、在线人数、协议。
        /// 
        /// 返回的数据粒度为1分钟。
        /// 
        /// 最大查询周期7天，数据延迟5分钟。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPlayDomainStreamInfoResponse ListPlayDomainStreamInfo(ListPlayDomainStreamInfoRequest listPlayDomainStreamInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/stream/play-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPlayDomainStreamInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPlayDomainStreamInfoResponse>(response);
        }

        public SyncInvoker<ListPlayDomainStreamInfoResponse> ListPlayDomainStreamInfoInvoker(ListPlayDomainStreamInfoRequest listPlayDomainStreamInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/stream/play-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPlayDomainStreamInfoRequest);
            return new SyncInvoker<ListPlayDomainStreamInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPlayDomainStreamInfoResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/stream/bitrate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSingleStreamBitrateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSingleStreamBitrateResponse>(response);
        }

        public SyncInvoker<ListSingleStreamBitrateResponse> ListSingleStreamBitrateInvoker(ListSingleStreamBitrateRequest listSingleStreamBitrateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/stream/bitrate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSingleStreamBitrateRequest);
            return new SyncInvoker<ListSingleStreamBitrateResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSingleStreamBitrateResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/stream-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSingleStreamDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSingleStreamDetailResponse>(response);
        }

        public SyncInvoker<ListSingleStreamDetailResponse> ListSingleStreamDetailInvoker(ListSingleStreamDetailRequest listSingleStreamDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/stream-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSingleStreamDetailRequest);
            return new SyncInvoker<ListSingleStreamDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSingleStreamDetailResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/stream/framerate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSingleStreamFramerateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSingleStreamFramerateResponse>(response);
        }

        public SyncInvoker<ListSingleStreamFramerateResponse> ListSingleStreamFramerateInvoker(ListSingleStreamFramerateRequest listSingleStreamFramerateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/stream/framerate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSingleStreamFramerateRequest);
            return new SyncInvoker<ListSingleStreamFramerateResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSingleStreamFramerateResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/up-stream/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUpStreamDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUpStreamDetailResponse>(response);
        }

        public SyncInvoker<ListUpStreamDetailResponse> ListUpStreamDetailInvoker(ListUpStreamDetailRequest listUpStreamDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/up-stream/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUpStreamDetailRequest);
            return new SyncInvoker<ListUpStreamDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUpStreamDetailResponse>);
        }
        
    }
}