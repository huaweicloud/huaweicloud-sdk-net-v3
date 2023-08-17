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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/rtc/client/abnormalevent",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcAbnormalEventRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListRtcAbnormalEventResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/rtc/client/event",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcEventRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListRtcEventResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/rtc/data/abnormal-event/dimension",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcAbnormalEventDimensionRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListRtcAbnormalEventDimensionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/rtc/data/abnormal-events",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcAbnormalEventsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListRtcAbnormalEventsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/rtc/client/qos/details",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcClientQosDetailsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListRtcClientQosDetailsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/rtc/history/quality",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcHistoryQualityRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListRtcHistoryQualityResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/rtc/history/scale",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcHistoryScaleRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListRtcHistoryScaleResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/rtc/history/usage",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcHistoryUsageRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListRtcHistoryUsageResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/rtc/realtime/network",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcRealtimeNetworkRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListRtcRealtimeNetworkResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/rtc/realtime/quality",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcRealtimeQualityRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListRtcRealtimeQualityResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/rtc/realtime/scale",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcRealtimeScaleRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListRtcRealtimeScaleResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/rtc/realtime/scale/dimension",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcRealtimeScaleDimensionRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListRtcRealtimeScaleDimensionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/rtc/rooms",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcRoomListRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListRtcRoomListResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/rtc/users",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRtcUserListRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListRtcUserListResponse>(response);
        }
        
    }
}