using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.cts.v3.Model;

namespace HuaweiCloud.SDK.cts.v3
{
    public partial class ctsAsyncClient : Client
    {
        public static ClientBuilder<ctsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<ctsAsyncClient>();
        }

        
        /// <summary>
        /// 创建关键操作通知
        ///
        /// 配置关键操作通知，可在发生特定操作时，使用预先创建好的SMN主题，向用户手机、邮箱发送消息，也可直接发送http/https消息。常用于实时感知高危操作、触发特定操作或对接用户自有审计分析系统。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateNotificationResponse> CreateNotificationAsync(CreateNotificationRequest createNotificationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/notifications",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createNotificationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateNotificationResponse>(response);
        }
        
        /// <summary>
        /// 创建追踪器
        ///
        /// 云审计服务开通后系统会自动创建一个追踪器，用来关联系统记录的所有操作。目前，一个云账户在一个Region下支持创建一个管理类追踪器和多个数据类追踪器。
        /// 云审计服务支持在管理控制台查询近7天内的操作记录。如需保存更长时间的操作记录，您可以在创建追踪器之后通过对象存储服务（Object Storage Service，以下简称OBS）将操作记录实时保存至OBS桶中。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTrackerResponse> CreateTrackerAsync(CreateTrackerRequest createTrackerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tracker",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTrackerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateTrackerResponse>(response);
        }
        
        /// <summary>
        /// 删除关键操作通知
        ///
        /// 云审计服务支持删除已创建的关键操作通知。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteNotificationResponse> DeleteNotificationAsync(DeleteNotificationRequest deleteNotificationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/notifications",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNotificationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteNotificationResponse>(response);
        }
        
        /// <summary>
        /// 删除追踪器
        ///
        /// 云审计服务目前仅支持删除已创建的数据类追踪器。删除追踪器对已有的操作记录没有影响，当您重新开通云审计服务后，依旧可以查看已有的操作记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTrackerResponse> DeleteTrackerAsync(DeleteTrackerRequest deleteTrackerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/trackers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTrackerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTrackerResponse>(response);
        }
        
        /// <summary>
        /// 查询关键操作通知
        ///
        /// 查询创建的关键操作通知规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNotificationsResponse> ListNotificationsAsync(ListNotificationsRequest listNotificationsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("notification_type" , listNotificationsRequest.NotificationType.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/notifications/{notification_type}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotificationsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListNotificationsResponse>(response);
        }
        
        /// <summary>
        /// 查询租户追踪器配额信息
        ///
        /// 查询租户追踪器配额信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListQuotasResponse> ListQuotasAsync(ListQuotasRequest listQuotasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotasRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListQuotasResponse>(response);
        }
        
        /// <summary>
        /// 查询事件列表
        ///
        /// 通过事件列表查询接口，可以查出系统记录的7天内资源操作记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTracesResponse> ListTracesAsync(ListTracesRequest listTracesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/traces",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTracesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTracesResponse>(response);
        }
        
        /// <summary>
        /// 查询追踪器
        ///
        /// 开通云审计服务成功后，您可以在追踪器信息页面查看追踪器的详细信息。详细信息主要包括追踪器名称，用于存储操作事件的OBS桶名称和OBS桶中的事件文件前缀。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTrackersResponse> ListTrackersAsync(ListTrackersRequest listTrackersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/trackers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrackersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTrackersResponse>(response);
        }
        
        /// <summary>
        /// 修改关键操作通知
        ///
        /// 云审计服务支持修改已创建关键操作通知配置项，通过notification_id的字段匹配修改对象，notification_id必须已经存在。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateNotificationResponse> UpdateNotificationAsync(UpdateNotificationRequest updateNotificationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/notifications",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateNotificationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateNotificationResponse>(response);
        }
        
        /// <summary>
        /// 修改追踪器
        ///
        /// 云审计服务支持修改已创建追踪器的配置项，包括OBS桶转储、关键事件通知、事件转储加密、通过LTS对管理类事件进行检索、事件文件完整性校验以及追踪器启停状态等相关参数，修改追踪器对已有的操作记录没有影响。修改追踪器完成后，系统立即以新的规则开始记录操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateTrackerResponse> UpdateTrackerAsync(UpdateTrackerRequest updateTrackerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tracker",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateTrackerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateTrackerResponse>(response);
        }
        
    }
}