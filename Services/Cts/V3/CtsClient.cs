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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id" , batchCreateResourceTagsRequest.ResourceId.ToString());
            urlParam.Add("resource_type" , batchCreateResourceTagsRequest.ResourceType.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/{resource_type}/{resource_id}/tags/create",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateResourceTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateResourceTagsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_id" , batchDeleteResourceTagsRequest.ResourceId.ToString());
            urlParam.Add("resource_type" , batchDeleteResourceTagsRequest.ResourceType.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/{resource_type}/{resource_id}/tags/delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteResourceTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<BatchDeleteResourceTagsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , checkObsBucketsRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/checkbucket",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", checkObsBucketsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CheckObsBucketsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/notifications",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createNotificationRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
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
        public CreateTrackerResponse CreateTracker(CreateTrackerRequest createTrackerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tracker",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTrackerRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateTrackerResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/notifications",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNotificationRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteNotificationResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/trackers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTrackerRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTrackerResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("notification_type" , listNotificationsRequest.NotificationType.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/notifications/{notification_type}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotificationsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListNotificationsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/operations",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOperationsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListOperationsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotasRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListQuotasResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , listTraceResourcesRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/resources",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTraceResourcesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListTraceResourcesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/traces",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTracesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListTracesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/trackers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTrackersRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListTrackersResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/user-resources",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserResourcesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListUserResourcesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/notifications",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateNotificationRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateNotificationResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tracker",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateTrackerRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateTrackerResponse>(response);
        }
        
    }
}