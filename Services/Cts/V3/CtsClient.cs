using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Cts.V3.Model;

namespace HuaweiCloud.SDK.Cts.V3
{
    public partial class CtsClient : Client
    {
        public static ClientBuilder<CtsClient> NewBuilder()
        {
            return new ClientBuilder<CtsClient>();
        }

        
        /// <summary>
        /// 批量添加CTS资源标签
        ///
        /// 批量添加CTS资源标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateResourceTagsResponse BatchCreateResourceTags(BatchCreateResourceTagsRequest batchCreateResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchCreateResourceTagsRequest.ResourceId.ToString());
            urlParam.Add("resource_type", batchCreateResourceTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateResourceTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchCreateResourceTagsResponse>(response);
        }

        public SyncInvoker<BatchCreateResourceTagsResponse> BatchCreateResourceTagsInvoker(BatchCreateResourceTagsRequest batchCreateResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchCreateResourceTagsRequest.ResourceId.ToString());
            urlParam.Add("resource_type", batchCreateResourceTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateResourceTagsRequest);
            return new SyncInvoker<BatchCreateResourceTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchCreateResourceTagsResponse>);
        }
        
        /// <summary>
        /// 批量删除CTS资源标签
        ///
        /// 批量删除CTS资源标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteResourceTagsResponse BatchDeleteResourceTags(BatchDeleteResourceTagsRequest batchDeleteResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchDeleteResourceTagsRequest.ResourceId.ToString());
            urlParam.Add("resource_type", batchDeleteResourceTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteResourceTagsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<BatchDeleteResourceTagsResponse>(response);
        }

        public SyncInvoker<BatchDeleteResourceTagsResponse> BatchDeleteResourceTagsInvoker(BatchDeleteResourceTagsRequest batchDeleteResourceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id", batchDeleteResourceTagsRequest.ResourceId.ToString());
            urlParam.Add("resource_type", batchDeleteResourceTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteResourceTagsRequest);
            return new SyncInvoker<BatchDeleteResourceTagsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<BatchDeleteResourceTagsResponse>);
        }
        
        /// <summary>
        /// 检查已经配置OBS桶是否可以成功转储
        ///
        /// 检查已经配置OBS桶是否可以成功转储。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CheckObsBucketsResponse CheckObsBuckets(CheckObsBucketsRequest checkObsBucketsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", checkObsBucketsRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/checkbucket", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", checkObsBucketsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CheckObsBucketsResponse>(response);
        }

        public SyncInvoker<CheckObsBucketsResponse> CheckObsBucketsInvoker(CheckObsBucketsRequest checkObsBucketsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", checkObsBucketsRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/checkbucket", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", checkObsBucketsRequest);
            return new SyncInvoker<CheckObsBucketsResponse>(this, "POST", request, JsonUtils.DeSerialize<CheckObsBucketsResponse>);
        }
        
        /// <summary>
        /// 创建关键操作通知
        ///
        /// 配置关键操作通知，可在发生特定操作时，使用预先创建好的SMN主题，向用户手机、邮箱发送消息，也可直接发送http/https消息。常用于实时感知高危操作、触发特定操作或对接用户自有审计分析系统。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateNotificationResponse CreateNotification(CreateNotificationRequest createNotificationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/notifications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createNotificationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateNotificationResponse>(response);
        }

        public SyncInvoker<CreateNotificationResponse> CreateNotificationInvoker(CreateNotificationRequest createNotificationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/notifications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createNotificationRequest);
            return new SyncInvoker<CreateNotificationResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateNotificationResponse>);
        }
        
        /// <summary>
        /// 创建追踪器
        ///
        /// 云审计服务开通后系统会自动创建一个追踪器，用来关联系统记录的所有操作。目前，一个云账户在一个Region下支持创建一个管理类追踪器和多个数据类追踪器。
        /// 云审计服务支持在管理控制台查询近7天内的操作记录。如需保存更长时间的操作记录，您可以在创建追踪器之后通过对象存储服务（Object Storage Service，以下简称OBS）将操作记录实时保存至OBS桶中。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTrackerResponse CreateTracker(CreateTrackerRequest createTrackerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tracker", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTrackerRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateTrackerResponse>(response);
        }

        public SyncInvoker<CreateTrackerResponse> CreateTrackerInvoker(CreateTrackerRequest createTrackerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tracker", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTrackerRequest);
            return new SyncInvoker<CreateTrackerResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTrackerResponse>);
        }
        
        /// <summary>
        /// 删除关键操作通知
        ///
        /// 云审计服务支持删除已创建的关键操作通知。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteNotificationResponse DeleteNotification(DeleteNotificationRequest deleteNotificationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/notifications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNotificationRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteNotificationResponse>(response);
        }

        public SyncInvoker<DeleteNotificationResponse> DeleteNotificationInvoker(DeleteNotificationRequest deleteNotificationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/notifications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNotificationRequest);
            return new SyncInvoker<DeleteNotificationResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteNotificationResponse>);
        }
        
        /// <summary>
        /// 删除追踪器
        ///
        /// 云审计服务目前仅支持删除已创建的数据类追踪器。删除追踪器对已有的操作记录没有影响，当您重新开通云审计服务后，依旧可以查看已有的操作记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTrackerResponse DeleteTracker(DeleteTrackerRequest deleteTrackerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/trackers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTrackerRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTrackerResponse>(response);
        }

        public SyncInvoker<DeleteTrackerResponse> DeleteTrackerInvoker(DeleteTrackerRequest deleteTrackerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/trackers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTrackerRequest);
            return new SyncInvoker<DeleteTrackerResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTrackerResponse>);
        }
        
        /// <summary>
        /// 查询关键操作通知
        ///
        /// 查询创建的关键操作通知规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListNotificationsResponse ListNotifications(ListNotificationsRequest listNotificationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("notification_type", listNotificationsRequest.NotificationType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/notifications/{notification_type}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotificationsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListNotificationsResponse>(response);
        }

        public SyncInvoker<ListNotificationsResponse> ListNotificationsInvoker(ListNotificationsRequest listNotificationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("notification_type", listNotificationsRequest.NotificationType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/notifications/{notification_type}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotificationsRequest);
            return new SyncInvoker<ListNotificationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNotificationsResponse>);
        }
        
        /// <summary>
        /// 查询云服务的全量操作列表
        ///
        /// 查询云服务的全量操作列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListOperationsResponse ListOperations(ListOperationsRequest listOperationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/operations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOperationsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListOperationsResponse>(response);
        }

        public SyncInvoker<ListOperationsResponse> ListOperationsInvoker(ListOperationsRequest listOperationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/operations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOperationsRequest);
            return new SyncInvoker<ListOperationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOperationsResponse>);
        }
        
        /// <summary>
        /// 查询租户追踪器配额信息
        ///
        /// 查询租户追踪器配额信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListQuotasResponse ListQuotas(ListQuotasRequest listQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListQuotasResponse>(response);
        }

        public SyncInvoker<ListQuotasResponse> ListQuotasInvoker(ListQuotasRequest listQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotasRequest);
            return new SyncInvoker<ListQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListQuotasResponse>);
        }
        
        /// <summary>
        /// 查询事件的资源类型列表
        ///
        /// 查询事件的资源类型列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTraceResourcesResponse ListTraceResources(ListTraceResourcesRequest listTraceResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", listTraceResourcesRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTraceResourcesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTraceResourcesResponse>(response);
        }

        public SyncInvoker<ListTraceResourcesResponse> ListTraceResourcesInvoker(ListTraceResourcesRequest listTraceResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", listTraceResourcesRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTraceResourcesRequest);
            return new SyncInvoker<ListTraceResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTraceResourcesResponse>);
        }
        
        /// <summary>
        /// 查询事件列表
        ///
        /// 通过事件列表查询接口，可以查出系统记录的7天内资源操作记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTracesResponse ListTraces(ListTracesRequest listTracesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/traces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTracesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTracesResponse>(response);
        }

        public SyncInvoker<ListTracesResponse> ListTracesInvoker(ListTracesRequest listTracesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/traces", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTracesRequest);
            return new SyncInvoker<ListTracesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTracesResponse>);
        }
        
        /// <summary>
        /// 查询追踪器
        ///
        /// 开通云审计服务成功后，您可以在追踪器信息页面查看追踪器的详细信息。详细信息主要包括追踪器名称，用于存储操作事件的OBS桶名称和OBS桶中的事件文件前缀。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTrackersResponse ListTrackers(ListTrackersRequest listTrackersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/trackers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrackersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTrackersResponse>(response);
        }

        public SyncInvoker<ListTrackersResponse> ListTrackersInvoker(ListTrackersRequest listTrackersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/trackers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrackersRequest);
            return new SyncInvoker<ListTrackersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTrackersResponse>);
        }
        
        /// <summary>
        /// 查询30天事件的操作用户列表
        ///
        /// 查询30天事件的操作用户列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUserResourcesResponse ListUserResources(ListUserResourcesRequest listUserResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/user-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserResourcesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUserResourcesResponse>(response);
        }

        public SyncInvoker<ListUserResourcesResponse> ListUserResourcesInvoker(ListUserResourcesRequest listUserResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/user-resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserResourcesRequest);
            return new SyncInvoker<ListUserResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUserResourcesResponse>);
        }
        
        /// <summary>
        /// 修改关键操作通知
        ///
        /// 云审计服务支持修改已创建关键操作通知配置项，通过notification_id的字段匹配修改对象，notification_id必须已经存在。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateNotificationResponse UpdateNotification(UpdateNotificationRequest updateNotificationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/notifications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateNotificationRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateNotificationResponse>(response);
        }

        public SyncInvoker<UpdateNotificationResponse> UpdateNotificationInvoker(UpdateNotificationRequest updateNotificationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/notifications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateNotificationRequest);
            return new SyncInvoker<UpdateNotificationResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateNotificationResponse>);
        }
        
        /// <summary>
        /// 修改追踪器
        ///
        /// 云审计服务支持修改已创建追踪器的配置项，包括OBS桶转储、关键事件通知、事件转储加密、通过LTS对管理类事件进行检索、事件文件完整性校验以及追踪器启停状态等相关参数，修改追踪器对已有的操作记录没有影响。修改追踪器完成后，系统立即以新的规则开始记录操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTrackerResponse UpdateTracker(UpdateTrackerRequest updateTrackerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tracker", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateTrackerRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateTrackerResponse>(response);
        }

        public SyncInvoker<UpdateTrackerResponse> UpdateTrackerInvoker(UpdateTrackerRequest updateTrackerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tracker", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateTrackerRequest);
            return new SyncInvoker<UpdateTrackerResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateTrackerResponse>);
        }
        
    }
}