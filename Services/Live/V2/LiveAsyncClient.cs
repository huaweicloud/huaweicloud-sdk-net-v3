using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Live.V2.Model;

namespace HuaweiCloud.SDK.Live.V2
{
    public partial class LiveAsyncClient : Client
    {
        public static ClientBuilder<LiveAsyncClient> NewBuilder()
        {
            return new ClientBuilder<LiveAsyncClient>();
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
        public async Task<ListAreaDetailResponse> ListAreaDetailAsync(ListAreaDetailRequest listAreaDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/area/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAreaDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAreaDetailResponse>(response);
        }

        public AsyncInvoker<ListAreaDetailResponse> ListAreaDetailAsyncInvoker(ListAreaDetailRequest listAreaDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/area/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAreaDetailRequest);
            return new AsyncInvoker<ListAreaDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAreaDetailResponse>);
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
        public async Task<ListBandwidthDetailResponse> ListBandwidthDetailAsync(ListBandwidthDetailRequest listBandwidthDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/bandwidth/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListBandwidthDetailResponse>(response);
        }

        public AsyncInvoker<ListBandwidthDetailResponse> ListBandwidthDetailAsyncInvoker(ListBandwidthDetailRequest listBandwidthDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/bandwidth/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBandwidthDetailRequest);
            return new AsyncInvoker<ListBandwidthDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBandwidthDetailResponse>);
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
        public async Task<ListDomainBandwidthPeakResponse> ListDomainBandwidthPeakAsync(ListDomainBandwidthPeakRequest listDomainBandwidthPeakRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/bandwidth/peak", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainBandwidthPeakRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDomainBandwidthPeakResponse>(response);
        }

        public AsyncInvoker<ListDomainBandwidthPeakResponse> ListDomainBandwidthPeakAsyncInvoker(ListDomainBandwidthPeakRequest listDomainBandwidthPeakRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/bandwidth/peak", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainBandwidthPeakRequest);
            return new AsyncInvoker<ListDomainBandwidthPeakResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainBandwidthPeakResponse>);
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
        public async Task<ListDomainTrafficDetailResponse> ListDomainTrafficDetailAsync(ListDomainTrafficDetailRequest listDomainTrafficDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/traffic/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainTrafficDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDomainTrafficDetailResponse>(response);
        }

        public AsyncInvoker<ListDomainTrafficDetailResponse> ListDomainTrafficDetailAsyncInvoker(ListDomainTrafficDetailRequest listDomainTrafficDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/traffic/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainTrafficDetailRequest);
            return new AsyncInvoker<ListDomainTrafficDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainTrafficDetailResponse>);
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
        public async Task<ListDomainTrafficSummaryResponse> ListDomainTrafficSummaryAsync(ListDomainTrafficSummaryRequest listDomainTrafficSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/traffic/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainTrafficSummaryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDomainTrafficSummaryResponse>(response);
        }

        public AsyncInvoker<ListDomainTrafficSummaryResponse> ListDomainTrafficSummaryAsyncInvoker(ListDomainTrafficSummaryRequest listDomainTrafficSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/traffic/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainTrafficSummaryRequest);
            return new AsyncInvoker<ListDomainTrafficSummaryResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainTrafficSummaryResponse>);
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
        public async Task<ListHistoryStreamsResponse> ListHistoryStreamsAsync(ListHistoryStreamsRequest listHistoryStreamsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/history/streams", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHistoryStreamsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListHistoryStreamsResponse>(response);
        }

        public AsyncInvoker<ListHistoryStreamsResponse> ListHistoryStreamsAsyncInvoker(ListHistoryStreamsRequest listHistoryStreamsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/history/streams", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHistoryStreamsRequest);
            return new AsyncInvoker<ListHistoryStreamsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHistoryStreamsResponse>);
        }
        
        /// <summary>
        /// 查询播放域名下的流数据
        ///
        /// 查询播放域名下的监控数据，根据输入时间点，返回查询该时间点所有流的带宽、在线人数、协议。
        /// 返回的数据粒度为1分钟。
        /// 最大查询周期7天，数据延迟5分钟。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPlayDomainStreamInfoResponse> ListPlayDomainStreamInfoAsync(ListPlayDomainStreamInfoRequest listPlayDomainStreamInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/stream/play-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPlayDomainStreamInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPlayDomainStreamInfoResponse>(response);
        }

        public AsyncInvoker<ListPlayDomainStreamInfoResponse> ListPlayDomainStreamInfoAsyncInvoker(ListPlayDomainStreamInfoRequest listPlayDomainStreamInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/stream/play-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPlayDomainStreamInfoRequest);
            return new AsyncInvoker<ListPlayDomainStreamInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPlayDomainStreamInfoResponse>);
        }
        
        /// <summary>
        /// 查询直播拉流HTTP状态码接口
        ///
        /// 查询直播拉流HTTP状态码接口。  获取加速域名1分钟粒度的HTTP返回码  最大查询跨度不能超过24小时，最大查询周期7天。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListQueryHttpCodeResponse> ListQueryHttpCodeAsync(ListQueryHttpCodeRequest listQueryHttpCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/httpcodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQueryHttpCodeRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListQueryHttpCodeResponse>(response);
        }

        public AsyncInvoker<ListQueryHttpCodeResponse> ListQueryHttpCodeAsyncInvoker(ListQueryHttpCodeRequest listQueryHttpCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/httpcodes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQueryHttpCodeRequest);
            return new AsyncInvoker<ListQueryHttpCodeResponse>(this, "GET", request, JsonUtils.DeSerialize<ListQueryHttpCodeResponse>);
        }
        
        /// <summary>
        /// 查询录制用量接口
        ///
        /// 查询直播租户每小时录制的最大并发数，计算1小时内每分钟的并发总路数，取最大值做为统计值。  最大查询跨度31天，最大查询周期90天。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRecordDataResponse> ListRecordDataAsync(ListRecordDataRequest listRecordDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/record", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordDataRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRecordDataResponse>(response);
        }

        public AsyncInvoker<ListRecordDataResponse> ListRecordDataAsyncInvoker(ListRecordDataRequest listRecordDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/record", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordDataRequest);
            return new AsyncInvoker<ListRecordDataResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRecordDataResponse>);
        }
        
        /// <summary>
        /// 查询截图用量接口
        ///
        /// 查询直播域名每小时的截图数量。  最大查询跨度31天，最大查询周期90天。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSnapshotDataResponse> ListSnapshotDataAsync(ListSnapshotDataRequest listSnapshotDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/snapshot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSnapshotDataRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSnapshotDataResponse>(response);
        }

        public AsyncInvoker<ListSnapshotDataResponse> ListSnapshotDataAsyncInvoker(ListSnapshotDataRequest listSnapshotDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/snapshot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSnapshotDataRequest);
            return new AsyncInvoker<ListSnapshotDataResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSnapshotDataResponse>);
        }
        
        /// <summary>
        /// 查询推流域名转码路数
        ///
        /// 查询推流域名下的转码路数，根据输入时间点和时间粒度，返回转码路数。
        /// 最大查询跨度1天，最大查询周期90天，数据延迟5分钟。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTranscodeConcurrencyNumResponse> ListTranscodeConcurrencyNumAsync(ListTranscodeConcurrencyNumRequest listTranscodeConcurrencyNumRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/transcode/concurrency", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTranscodeConcurrencyNumRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTranscodeConcurrencyNumResponse>(response);
        }

        public AsyncInvoker<ListTranscodeConcurrencyNumResponse> ListTranscodeConcurrencyNumAsyncInvoker(ListTranscodeConcurrencyNumRequest listTranscodeConcurrencyNumRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/transcode/concurrency", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTranscodeConcurrencyNumRequest);
            return new AsyncInvoker<ListTranscodeConcurrencyNumResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTranscodeConcurrencyNumResponse>);
        }
        
        /// <summary>
        /// 查询转码用量接口
        ///
        /// 查询直播域名每小时的转码时长数据。  最大查询跨度31天，最大查询周期90天。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTranscodeDataResponse> ListTranscodeDataAsync(ListTranscodeDataRequest listTranscodeDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/transcode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTranscodeDataRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTranscodeDataResponse>(response);
        }

        public AsyncInvoker<ListTranscodeDataResponse> ListTranscodeDataAsyncInvoker(ListTranscodeDataRequest listTranscodeDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/transcode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTranscodeDataRequest);
            return new AsyncInvoker<ListTranscodeDataResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTranscodeDataResponse>);
        }
        
        /// <summary>
        /// 查询转码明细
        ///
        /// 查询流粒度转码明细，包含流名、模版、格式、时长。
        /// 最大查询跨度1天，最大查询周期14天。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTranscodeTaskDetailResponse> ListTranscodeTaskDetailAsync(ListTranscodeTaskDetailRequest listTranscodeTaskDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/transcode/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTranscodeTaskDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTranscodeTaskDetailResponse>(response);
        }

        public AsyncInvoker<ListTranscodeTaskDetailResponse> ListTranscodeTaskDetailAsyncInvoker(ListTranscodeTaskDetailRequest listTranscodeTaskDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/transcode/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTranscodeTaskDetailRequest);
            return new AsyncInvoker<ListTranscodeTaskDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTranscodeTaskDetailResponse>);
        }
        
        /// <summary>
        /// 查询观众趋势接口
        ///
        /// 查询观众趋势。  最大查询跨度31天，最大查询周期一年。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListUsersOfStreamResponse> ListUsersOfStreamAsync(ListUsersOfStreamRequest listUsersOfStreamRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersOfStreamRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListUsersOfStreamResponse>(response);
        }

        public AsyncInvoker<ListUsersOfStreamResponse> ListUsersOfStreamAsyncInvoker(ListUsersOfStreamRequest listUsersOfStreamRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersOfStreamRequest);
            return new AsyncInvoker<ListUsersOfStreamResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUsersOfStreamResponse>);
        }
        
        /// <summary>
        /// 查询域名维度推流路数接口
        ///
        /// 查询域名维度推流路数接口。  最大查询跨度31天，最大查询周期1年。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowStreamCountResponse> ShowStreamCountAsync(ShowStreamCountRequest showStreamCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/stream-count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStreamCountRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowStreamCountResponse>(response);
        }

        public AsyncInvoker<ShowStreamCountResponse> ShowStreamCountAsyncInvoker(ShowStreamCountRequest showStreamCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/stream-count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStreamCountRequest);
            return new AsyncInvoker<ShowStreamCountResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStreamCountResponse>);
        }
        
        /// <summary>
        /// 查询播放画像信息接口
        ///
        /// 查询播放画像信息。  最大查询跨度1天，最大查询周期31天。
        /// 不统计协议为HLS的播放时长（play_duration）信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowStreamPortraitResponse> ShowStreamPortraitAsync(ShowStreamPortraitRequest showStreamPortraitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/stream-portraits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStreamPortraitRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowStreamPortraitResponse>(response);
        }

        public AsyncInvoker<ShowStreamPortraitResponse> ShowStreamPortraitAsyncInvoker(ShowStreamPortraitRequest showStreamPortraitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/stream-portraits", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStreamPortraitRequest);
            return new AsyncInvoker<ShowStreamPortraitResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStreamPortraitResponse>);
        }
        
        /// <summary>
        /// 查询上行带宽数据接口
        ///
        /// 查询上行带宽数据。  最大查询跨度31天，最大查询周期1年。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowUpBandwidthResponse> ShowUpBandwidthAsync(ShowUpBandwidthRequest showUpBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/up-bandwidth/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpBandwidthRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowUpBandwidthResponse>(response);
        }

        public AsyncInvoker<ShowUpBandwidthResponse> ShowUpBandwidthAsyncInvoker(ShowUpBandwidthRequest showUpBandwidthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/up-bandwidth/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpBandwidthRequest);
            return new AsyncInvoker<ShowUpBandwidthResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUpBandwidthResponse>);
        }
        
        /// <summary>
        /// 查询轮播任务监控数据接口
        ///
        /// 查询轮播任务监控数据接口，包括轮播任务帧率码率情况。
        /// 
        /// 最大查询跨度3小时，最大查询周期7天。
        /// 
        /// 返回的帧率码率数据列表粒度为1秒钟。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCarouselTaskDetailResponse> ListCarouselTaskDetailAsync(ListCarouselTaskDetailRequest listCarouselTaskDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/carousel-task/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCarouselTaskDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCarouselTaskDetailResponse>(response);
        }

        public AsyncInvoker<ListCarouselTaskDetailResponse> ListCarouselTaskDetailAsyncInvoker(ListCarouselTaskDetailRequest listCarouselTaskDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/carousel-task/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCarouselTaskDetailRequest);
            return new AsyncInvoker<ListCarouselTaskDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCarouselTaskDetailResponse>);
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
        public async Task<ListSingleStreamBitrateResponse> ListSingleStreamBitrateAsync(ListSingleStreamBitrateRequest listSingleStreamBitrateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/stream/bitrate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSingleStreamBitrateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSingleStreamBitrateResponse>(response);
        }

        public AsyncInvoker<ListSingleStreamBitrateResponse> ListSingleStreamBitrateAsyncInvoker(ListSingleStreamBitrateRequest listSingleStreamBitrateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/stream/bitrate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSingleStreamBitrateRequest);
            return new AsyncInvoker<ListSingleStreamBitrateResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSingleStreamBitrateResponse>);
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
        public async Task<ListSingleStreamDetailResponse> ListSingleStreamDetailAsync(ListSingleStreamDetailRequest listSingleStreamDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/stream-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSingleStreamDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSingleStreamDetailResponse>(response);
        }

        public AsyncInvoker<ListSingleStreamDetailResponse> ListSingleStreamDetailAsyncInvoker(ListSingleStreamDetailRequest listSingleStreamDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/stream-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSingleStreamDetailRequest);
            return new AsyncInvoker<ListSingleStreamDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSingleStreamDetailResponse>);
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
        public async Task<ListSingleStreamFramerateResponse> ListSingleStreamFramerateAsync(ListSingleStreamFramerateRequest listSingleStreamFramerateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/stream/framerate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSingleStreamFramerateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSingleStreamFramerateResponse>(response);
        }

        public AsyncInvoker<ListSingleStreamFramerateResponse> ListSingleStreamFramerateAsyncInvoker(ListSingleStreamFramerateRequest listSingleStreamFramerateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/stream/framerate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSingleStreamFramerateRequest);
            return new AsyncInvoker<ListSingleStreamFramerateResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSingleStreamFramerateResponse>);
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
        public async Task<ListUpStreamDetailResponse> ListUpStreamDetailAsync(ListUpStreamDetailRequest listUpStreamDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/up-stream/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUpStreamDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListUpStreamDetailResponse>(response);
        }

        public AsyncInvoker<ListUpStreamDetailResponse> ListUpStreamDetailAsyncInvoker(ListUpStreamDetailRequest listUpStreamDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/stats/up-stream/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUpStreamDetailRequest);
            return new AsyncInvoker<ListUpStreamDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUpStreamDetailResponse>);
        }
        
    }
}