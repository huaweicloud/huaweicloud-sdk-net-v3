using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.CloudRtc.V1.Model;

namespace HuaweiCloud.SDK.CloudRtc.V1
{
    public partial class CloudRtcClient : Client
    {
        public static ClientBuilder<CloudRtcClient> NewBuilder()
        {
            return new ClientBuilder<CloudRtcClient>();
        }

        
        /// <summary>
        /// 查询用户异常体验事件接口
        ///
        /// 查询指定APP下通话的异常明细数据。可查询5天内的数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRtcAbnormalEventResponse ListRtcAbnormalEvent(ListRtcAbnormalEventRequest listRtcAbnormalEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/rtc/client/abnormalevent", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcAbnormalEventRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRtcAbnormalEventResponse>(response);
        }

        public SyncInvoker<ListRtcAbnormalEventResponse> ListRtcAbnormalEventInvoker(ListRtcAbnormalEventRequest listRtcAbnormalEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/rtc/client/abnormalevent", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcAbnormalEventRequest);
            return new SyncInvoker<ListRtcAbnormalEventResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRtcAbnormalEventResponse>);
        }
        
        /// <summary>
        /// 查询详情事件接口
        ///
        /// 查询指定APP下通话的异常明细数据。可查询5天内的数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRtcEventResponse ListRtcEvent(ListRtcEventRequest listRtcEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/rtc/client/event", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcEventRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRtcEventResponse>(response);
        }

        public SyncInvoker<ListRtcEventResponse> ListRtcEventInvoker(ListRtcEventRequest listRtcEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/rtc/client/event", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcEventRequest);
            return new SyncInvoker<ListRtcEventResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRtcEventResponse>);
        }
        
        /// <summary>
        /// 查询异常事件用户分布
        ///
        /// 查询指定APP下指定时间内的通话异常明细数据分布情况。
        /// 
        /// 最大查询跨度1天。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRtcAbnormalEventDimensionResponse ListRtcAbnormalEventDimension(ListRtcAbnormalEventDimensionRequest listRtcAbnormalEventDimensionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/rtc/data/abnormal-event/dimension", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcAbnormalEventDimensionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRtcAbnormalEventDimensionResponse>(response);
        }

        public SyncInvoker<ListRtcAbnormalEventDimensionResponse> ListRtcAbnormalEventDimensionInvoker(ListRtcAbnormalEventDimensionRequest listRtcAbnormalEventDimensionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/rtc/data/abnormal-event/dimension", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcAbnormalEventDimensionRequest);
            return new SyncInvoker<ListRtcAbnormalEventDimensionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRtcAbnormalEventDimensionResponse>);
        }
        
        /// <summary>
        /// 查询用户异常体验事件
        ///
        /// 查询指定APP下通话的异常明细数据。
        /// 
        /// 最大查询跨度1天。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRtcAbnormalEventsResponse ListRtcAbnormalEvents(ListRtcAbnormalEventsRequest listRtcAbnormalEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/rtc/data/abnormal-events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcAbnormalEventsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRtcAbnormalEventsResponse>(response);
        }

        public SyncInvoker<ListRtcAbnormalEventsResponse> ListRtcAbnormalEventsInvoker(ListRtcAbnormalEventsRequest listRtcAbnormalEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/rtc/data/abnormal-events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcAbnormalEventsRequest);
            return new SyncInvoker<ListRtcAbnormalEventsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRtcAbnormalEventsResponse>);
        }
        
        /// <summary>
        /// 查询用户通话指标
        ///
        /// 查询用户通话质量指标数据。
        /// 
        /// 可查询5天内的数据，mid 不为null，查询实时数据时，查询起止时间不超过24个小时，每次查询单个用户时，支持跨天查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRtcClientQosDetailsResponse ListRtcClientQosDetails(ListRtcClientQosDetailsRequest listRtcClientQosDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/rtc/client/qos/details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcClientQosDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRtcClientQosDetailsResponse>(response);
        }

        public SyncInvoker<ListRtcClientQosDetailsResponse> ListRtcClientQosDetailsInvoker(ListRtcClientQosDetailsRequest listRtcClientQosDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/rtc/client/qos/details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcClientQosDetailsRequest);
            return new SyncInvoker<ListRtcClientQosDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRtcClientQosDetailsResponse>);
        }
        
        /// <summary>
        /// 查询历史质量
        ///
        /// 查询质量指标过去每天的体验数据，可查询最近31天的数据。当天未结束，无法查询到当天的体验数据。
        /// 
        /// 最大查询跨度31天。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRtcHistoryQualityResponse ListRtcHistoryQuality(ListRtcHistoryQualityRequest listRtcHistoryQualityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/rtc/history/quality", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcHistoryQualityRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRtcHistoryQualityResponse>(response);
        }

        public SyncInvoker<ListRtcHistoryQualityResponse> ListRtcHistoryQualityInvoker(ListRtcHistoryQualityRequest listRtcHistoryQualityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/rtc/history/quality", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcHistoryQualityRequest);
            return new SyncInvoker<ListRtcHistoryQualityResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRtcHistoryQualityResponse>);
        }
        
        /// <summary>
        /// 查询历史规模
        ///
        /// 查询指标过去每天的规模数量，可查询最近31天的数据。当天未结束，无法查到当天的房间数与用户数。
        /// 
        /// 最大查询跨度31天。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRtcHistoryScaleResponse ListRtcHistoryScale(ListRtcHistoryScaleRequest listRtcHistoryScaleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/rtc/history/scale", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcHistoryScaleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRtcHistoryScaleResponse>(response);
        }

        public SyncInvoker<ListRtcHistoryScaleResponse> ListRtcHistoryScaleInvoker(ListRtcHistoryScaleRequest listRtcHistoryScaleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/rtc/history/scale", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcHistoryScaleRequest);
            return new SyncInvoker<ListRtcHistoryScaleResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRtcHistoryScaleResponse>);
        }
        
        /// <summary>
        /// 查询用量
        ///
        /// 查询过去的某一时间段内各种业务的用量数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRtcHistoryUsageResponse ListRtcHistoryUsage(ListRtcHistoryUsageRequest listRtcHistoryUsageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/rtc/history/usage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcHistoryUsageRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRtcHistoryUsageResponse>(response);
        }

        public SyncInvoker<ListRtcHistoryUsageResponse> ListRtcHistoryUsageInvoker(ListRtcHistoryUsageRequest listRtcHistoryUsageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/rtc/history/usage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcHistoryUsageRequest);
            return new SyncInvoker<ListRtcHistoryUsageResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRtcHistoryUsageResponse>);
        }
        
        /// <summary>
        /// 查询实时网络
        ///
        /// 获取实时网络数据相关指标在某一时间段内每分钟的统计数据。
        /// 
        /// 最大查询跨度1天。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRtcRealtimeNetworkResponse ListRtcRealtimeNetwork(ListRtcRealtimeNetworkRequest listRtcRealtimeNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/rtc/realtime/network", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcRealtimeNetworkRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRtcRealtimeNetworkResponse>(response);
        }

        public SyncInvoker<ListRtcRealtimeNetworkResponse> ListRtcRealtimeNetworkInvoker(ListRtcRealtimeNetworkRequest listRtcRealtimeNetworkRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/rtc/realtime/network", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcRealtimeNetworkRequest);
            return new SyncInvoker<ListRtcRealtimeNetworkResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRtcRealtimeNetworkResponse>);
        }
        
        /// <summary>
        /// 查询实时质量数据
        ///
        /// 获取实时质量数据的相关指标在某一时间段内每分钟的统计数据。
        /// 
        /// 最大查询跨度1天。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRtcRealtimeQualityResponse ListRtcRealtimeQuality(ListRtcRealtimeQualityRequest listRtcRealtimeQualityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/rtc/realtime/quality", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcRealtimeQualityRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRtcRealtimeQualityResponse>(response);
        }

        public SyncInvoker<ListRtcRealtimeQualityResponse> ListRtcRealtimeQualityInvoker(ListRtcRealtimeQualityRequest listRtcRealtimeQualityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/rtc/realtime/quality", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcRealtimeQualityRequest);
            return new SyncInvoker<ListRtcRealtimeQualityResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRtcRealtimeQualityResponse>);
        }
        
        /// <summary>
        /// 查询实时规模
        ///
        /// 获取规模相关的指标在某一时间段内每分钟的统计数据。
        /// 
        /// 最大查询跨度1天。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRtcRealtimeScaleResponse ListRtcRealtimeScale(ListRtcRealtimeScaleRequest listRtcRealtimeScaleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/rtc/realtime/scale", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcRealtimeScaleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRtcRealtimeScaleResponse>(response);
        }

        public SyncInvoker<ListRtcRealtimeScaleResponse> ListRtcRealtimeScaleInvoker(ListRtcRealtimeScaleRequest listRtcRealtimeScaleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/rtc/realtime/scale", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcRealtimeScaleRequest);
            return new SyncInvoker<ListRtcRealtimeScaleResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRtcRealtimeScaleResponse>);
        }
        
        /// <summary>
        /// 查询实时规模分布
        ///
        /// 对规模相关的数据，根据指定维度按在线用户数排名，获取规模相关的指标在指定维度下的统计数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRtcRealtimeScaleDimensionResponse ListRtcRealtimeScaleDimension(ListRtcRealtimeScaleDimensionRequest listRtcRealtimeScaleDimensionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/rtc/realtime/scale/dimension", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcRealtimeScaleDimensionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRtcRealtimeScaleDimensionResponse>(response);
        }

        public SyncInvoker<ListRtcRealtimeScaleDimensionResponse> ListRtcRealtimeScaleDimensionInvoker(ListRtcRealtimeScaleDimensionRequest listRtcRealtimeScaleDimensionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/rtc/realtime/scale/dimension", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcRealtimeScaleDimensionRequest);
            return new SyncInvoker<ListRtcRealtimeScaleDimensionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRtcRealtimeScaleDimensionResponse>);
        }
        
        /// <summary>
        /// 查询房间列表
        ///
        /// 指定事件范围查询这段期间创建的房间列表。
        /// 
        /// 最大查询跨度90天。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRtcRoomListResponse ListRtcRoomList(ListRtcRoomListRequest listRtcRoomListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/rtc/rooms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcRoomListRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRtcRoomListResponse>(response);
        }

        public SyncInvoker<ListRtcRoomListResponse> ListRtcRoomListInvoker(ListRtcRoomListRequest listRtcRoomListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/rtc/rooms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcRoomListRequest);
            return new SyncInvoker<ListRtcRoomListResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRtcRoomListResponse>);
        }
        
        /// <summary>
        /// 查询用户列表
        ///
        /// 指定事件范围查询这段期间加入房间的用户列表。
        /// 
        /// 最大查询跨度90天。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRtcUserListResponse ListRtcUserList(ListRtcUserListRequest listRtcUserListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/rtc/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcUserListRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRtcUserListResponse>(response);
        }

        public SyncInvoker<ListRtcUserListResponse> ListRtcUserListInvoker(ListRtcUserListRequest listRtcUserListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/rtc/users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcUserListRequest);
            return new SyncInvoker<ListRtcUserListResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRtcUserListResponse>);
        }
        
    }
}