using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Lts.V2.Model;

namespace HuaweiCloud.SDK.Lts.V2
{
    public partial class LtsClient : Client
    {
        public static ClientBuilder<LtsClient> NewBuilder()
        {
            return new ClientBuilder<LtsClient>();
        }

        
        /// <summary>
        /// 创建日志接入
        ///
        /// 创建日志接入
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAccessConfigResponse CreateAccessConfig(CreateAccessConfigRequest createAccessConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/access-config",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAccessConfigRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateAccessConfigResponse>(response);
        }
        
        /// <summary>
        /// 创建仪表盘
        ///
        /// 创建仪表盘
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDashBoardResponse CreateDashBoard(CreateDashBoardRequest createDashBoardRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboard",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDashBoardRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateDashBoardResponse>(response);
        }
        
        /// <summary>
        /// 创建仪表盘分组
        ///
        /// 创建仪表盘分组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDashboardGroupResponse CreateDashboardGroup(CreateDashboardGroupRequest createDashboardGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/dashboard-group",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDashboardGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateDashboardGroupResponse>(response);
        }
        
        /// <summary>
        /// 创建主机组
        ///
        /// 创建主机组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateHostGroupResponse CreateHostGroup(CreateHostGroupRequest createHostGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/host-group",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createHostGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateHostGroupResponse>(response);
        }
        
        /// <summary>
        /// 创建关键词告警规则
        ///
        /// 该接口用于创建关键词告警，目前每个帐户最多可以创建共200个关键词告警与SQL告警。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateKeywordsAlarmRuleResponse CreateKeywordsAlarmRule(CreateKeywordsAlarmRuleRequest createKeywordsAlarmRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/keywords-alarm-rule",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createKeywordsAlarmRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateKeywordsAlarmRuleResponse>(response);
        }
        
        /// <summary>
        /// 创建日志转储（旧版）
        ///
        /// 该接口用于将指定的一个或多个日志流的日志转储到OBS服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateLogDumpObsResponse CreateLogDumpObs(CreateLogDumpObsRequest createLogDumpObsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/log-dump/obs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLogDumpObsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateLogDumpObsResponse>(response);
        }
        
        /// <summary>
        /// 创建日志组
        ///
        /// 该接口用于创建一个日志组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateLogGroupResponse CreateLogGroup(CreateLogGroupRequest createLogGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLogGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateLogGroupResponse>(response);
        }
        
        /// <summary>
        /// 创建日志流
        ///
        /// 该接口用于创建某个指定日志组下的日志流
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateLogStreamResponse CreateLogStream(CreateLogStreamRequest createLogStreamRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id" , createLogStreamRequest.LogGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}/streams",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLogStreamRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateLogStreamResponse>(response);
        }
        
        /// <summary>
        /// 创建消息模板
        ///
        /// 该接口用于创建通知模板，目前每个帐户最多可以创建共100个通知模板，创建后名称不可修改。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateNotificationTemplateResponse CreateNotificationTemplate(CreateNotificationTemplateRequest createNotificationTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , createNotificationTemplateRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/events/notification/templates",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createNotificationTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateNotificationTemplateResponse>(response);
        }
        
        /// <summary>
        /// 添加快速查询
        ///
        /// 添加快速查询
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateSearchCriteriasResponse CreateSearchCriterias(CreateSearchCriteriasRequest createSearchCriteriasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , createSearchCriteriasRequest.GroupId.ToString());
            urlParam.Add("topic_id" , createSearchCriteriasRequest.TopicId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/groups/{group_id}/topics/{topic_id}/search-criterias",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSearchCriteriasRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateSearchCriteriasResponse>(response);
        }
        
        /// <summary>
        /// 通过结构化模板创建结构化配置（新）
        ///
        /// 该接口通过结构化模板创建结构化配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateStructConfigResponse CreateStructConfig(CreateStructConfigRequest createStructConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/struct/template",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createStructConfigRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            CreateStructConfigResponse createStructConfigResponse = JsonUtils.DeSerializeNull<CreateStructConfigResponse>(response);
            return createStructConfigResponse;
        }
        
        /// <summary>
        /// 创建结构化配置
        ///
        /// 该接口用于创建指定日志流下的结构化配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateStructTemplateResponse CreateStructTemplate(CreateStructTemplateRequest createStructTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/struct/template",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createStructTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            CreateStructTemplateResponse createStructTemplateResponse = JsonUtils.DeSerializeNull<CreateStructTemplateResponse>(response);
            return createStructTemplateResponse;
        }
        
        /// <summary>
        /// 
        ///
        /// 添加标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTagsResponse CreateTags(CreateTagsRequest createTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , createTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id" , createTagsRequest.ResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/{resource_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CreateTagsResponse>(response);
        }
        
        /// <summary>
        /// 创建日志转储（新版）
        ///
        /// 该接口用于创建OBS转储，DIS转储，DMS转储。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTransferResponse CreateTransfer(CreateTransferRequest createTransferRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/transfers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTransferRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateTransferResponse>(response);
        }
        
        /// <summary>
        /// 查询Demo
        ///
        /// 创建日志收藏
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatefavoriteResponse Createfavorite(CreatefavoriteRequest createfavoriteRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/lts/favorite",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createfavoriteRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreatefavoriteResponse>(response);
        }
        
        /// <summary>
        /// 删除日志接入
        ///
        /// 删除日志接入
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAccessConfigResponse DeleteAccessConfig(DeleteAccessConfigRequest deleteAccessConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/access-config",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteAccessConfigRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteAccessConfigResponse>(response);
        }
        
        /// <summary>
        /// 删除活动告警
        ///
        /// 该接口用于删除活动告警
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteActiveAlarmsResponse DeleteActiveAlarms(DeleteActiveAlarmsRequest deleteActiveAlarmsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , deleteActiveAlarmsRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/alarms/sql-alarm/clear",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteActiveAlarmsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<DeleteActiveAlarmsResponse>(response);
        }
        
        /// <summary>
        /// 删除主机组
        ///
        /// 删除主机组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteHostGroupResponse DeleteHostGroup(DeleteHostGroupRequest deleteHostGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/host-group",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteHostGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteHostGroupResponse>(response);
        }
        
        /// <summary>
        /// 删除关键词告警规则
        ///
        /// 该接口用于删除关键词告警。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteKeywordsAlarmRuleResponse DeleteKeywordsAlarmRule(DeleteKeywordsAlarmRuleRequest deleteKeywordsAlarmRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("keywords_alarm_rule_id" , deleteKeywordsAlarmRuleRequest.KeywordsAlarmRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/keywords-alarm-rule/{keywords_alarm_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKeywordsAlarmRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteKeywordsAlarmRuleResponse>(response);
        }
        
        /// <summary>
        /// 删除日志组
        ///
        /// 该接口用于删除指定日志组。当日志组中的日志流配置了日志转储，需要取消日志转储后才可删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteLogGroupResponse DeleteLogGroup(DeleteLogGroupRequest deleteLogGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id" , deleteLogGroupRequest.LogGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLogGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            DeleteLogGroupResponse deleteLogGroupResponse = JsonUtils.DeSerializeNull<DeleteLogGroupResponse>(response);
            return deleteLogGroupResponse;
        }
        
        /// <summary>
        /// 删除日志流
        ///
        /// 该接口用于删除指定日志组下的指定日志流。当该日志流配置了日志转储，需要取消日志转储后才可删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteLogStreamResponse DeleteLogStream(DeleteLogStreamRequest deleteLogStreamRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id" , deleteLogStreamRequest.LogGroupId.ToString());
            urlParam.Add("log_stream_id" , deleteLogStreamRequest.LogStreamId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}/streams/{log_stream_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLogStreamRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            DeleteLogStreamResponse deleteLogStreamResponse = JsonUtils.DeSerializeNull<DeleteLogStreamResponse>(response);
            return deleteLogStreamResponse;
        }
        
        /// <summary>
        /// 删除消息模板
        ///
        /// 该接口用于删除通知模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteNotificationTemplateResponse DeleteNotificationTemplate(DeleteNotificationTemplateRequest deleteNotificationTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , deleteNotificationTemplateRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/events/notification/templates",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteNotificationTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteNotificationTemplateResponse>(response);
        }
        
        /// <summary>
        /// 删除快速查询
        ///
        /// 删除快速查询
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSearchCriteriasResponse DeleteSearchCriterias(DeleteSearchCriteriasRequest deleteSearchCriteriasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , deleteSearchCriteriasRequest.GroupId.ToString());
            urlParam.Add("topic_id" , deleteSearchCriteriasRequest.TopicId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/groups/{group_id}/topics/{topic_id}/search-criterias",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteSearchCriteriasRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSearchCriteriasResponse>(response);
        }
        
        /// <summary>
        /// 删除结构化配置
        ///
        /// 该接口用于删除指定日志流下的结构化配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteStructTemplateResponse DeleteStructTemplate(DeleteStructTemplateRequest deleteStructTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/struct/template",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteStructTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            DeleteStructTemplateResponse deleteStructTemplateResponse = JsonUtils.DeSerializeNull<DeleteStructTemplateResponse>(response);
            return deleteStructTemplateResponse;
        }
        
        /// <summary>
        /// 删除日志转储
        ///
        /// 该接口用于删除OBS转储，DIS转储，DMS转储。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTransferResponse DeleteTransfer(DeleteTransferRequest deleteTransferRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/transfers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTransferRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteTransferResponse>(response);
        }
        
        /// <summary>
        /// 取消收藏
        ///
        /// 取消收藏
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletefavoriteResponse Deletefavorite(DeletefavoriteRequest deletefavoriteRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("fav_res_id" , deletefavoriteRequest.FavResId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/lts/favorite/{fav_res_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletefavoriteRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeletefavoriteResponse>(response);
        }
        
        /// <summary>
        /// 关闭超额采集开关
        ///
        /// 该接口用于将超额采集日志功能关闭。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisableLogCollectionResponse DisableLogCollection(DisableLogCollectionRequest disableLogCollectionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/collection/disable",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableLogCollectionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<DisableLogCollectionResponse>(response);
        }
        
        /// <summary>
        /// 打开超额采集开关
        ///
        /// 该接口用于将超额采集日志功能打开。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EnableLogCollectionResponse EnableLogCollection(EnableLogCollectionRequest enableLogCollectionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/collection/enable",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableLogCollectionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<EnableLogCollectionResponse>(response);
        }
        
        /// <summary>
        /// 查询日志接入
        ///
        /// 查询日志接入列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAccessConfigResponse ListAccessConfig(ListAccessConfigRequest listAccessConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/access-config-list",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAccessConfigRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListAccessConfigResponse>(response);
        }
        
        /// <summary>
        /// 查询活动或历史告警列表
        ///
        /// 该接口用于查询告警列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListActiveOrHistoryAlarmsResponse ListActiveOrHistoryAlarms(ListActiveOrHistoryAlarmsRequest listActiveOrHistoryAlarmsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , listActiveOrHistoryAlarmsRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/alarms/sql-alarm/query",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listActiveOrHistoryAlarmsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListActiveOrHistoryAlarmsResponse>(response);
        }
        
        /// <summary>
        /// 查询结构化模板简略列表
        ///
        /// 该接口用于查询结构化模板简略列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBreifStructTemplateResponse ListBreifStructTemplate(ListBreifStructTemplateRequest listBreifStructTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/struct/customtemplate/list",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBreifStructTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListBreifStructTemplateResponse>(response);
        }
        
        /// <summary>
        /// 查询日志流图表
        ///
        /// 该接口用于查询日志流图表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListChartsResponse ListCharts(ListChartsRequest listChartsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id" , listChartsRequest.LogGroupId.ToString());
            urlParam.Add("log_stream_id" , listChartsRequest.LogStreamId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}/streams/{log_stream_id}/charts",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listChartsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListChartsResponse>(response);
        }
        
        /// <summary>
        /// 获取快速查询
        ///
        /// 获取快速查询
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCriteriasResponse ListCriterias(ListCriteriasRequest listCriteriasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , listCriteriasRequest.GroupId.ToString());
            urlParam.Add("topic_id" , listCriteriasRequest.TopicId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/groups/{group_id}/topics/{topic_id}/search-criterias",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCriteriasRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListCriteriasResponse>(response);
        }
        
        /// <summary>
        /// 查询用户历史sql
        ///
        /// 查询用户历史sql
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListHistorySqlResponse ListHistorySql(ListHistorySqlRequest listHistorySqlRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/history-sql",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHistorySqlRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListHistorySqlResponse>(response);
        }
        
        /// <summary>
        /// 查询主机信息
        ///
        /// 查询主机列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListHostResponse ListHost(ListHostRequest listHostRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/host-list",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listHostRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListHostResponse>(response);
        }
        
        /// <summary>
        /// 查询主机组
        ///
        /// 查询主机组列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListHostGroupResponse ListHostGroup(ListHostGroupRequest listHostGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/host-group-list",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listHostGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListHostGroupResponse>(response);
        }
        
        /// <summary>
        /// 查询关键词告警规则
        ///
        /// 该接口用于查询关键词告警。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListKeywordsAlarmRulesResponse ListKeywordsAlarmRules(ListKeywordsAlarmRulesRequest listKeywordsAlarmRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/keywords-alarm-rule",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeywordsAlarmRulesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListKeywordsAlarmRulesResponse>(response);
        }
        
        /// <summary>
        /// 查询账号下所有日志组
        ///
        /// 该接口用于查询账号下所有日志组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLogGroupsResponse ListLogGroups(ListLogGroupsRequest listLogGroupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogGroupsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListLogGroupsResponse>(response);
        }
        
        /// <summary>
        /// 查询日志直方图
        ///
        /// 查询关键词搜索条数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLogHistogramResponse ListLogHistogram(ListLogHistogramRequest listLogHistogramRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/keyword-count",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listLogHistogramRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListLogHistogramResponse>(response);
        }
        
        /// <summary>
        /// 查询指定日志组下的所有日志流
        ///
        /// 该接口用于查询指定日志组下的所有日志流信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLogStreamResponse ListLogStream(ListLogStreamRequest listLogStreamRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id" , listLogStreamRequest.LogGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}/streams",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogStreamRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListLogStreamResponse>(response);
        }
        
        /// <summary>
        /// 查询日志流信息
        ///
        /// 该接口用于查询LTS日志流信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLogStreamsResponse ListLogStreams(ListLogStreamsRequest listLogStreamsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/log-streams",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogStreamsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListLogStreamsResponse>(response);
        }
        
        /// <summary>
        /// 查询日志
        ///
        /// 该接口用于查询指定日志流下的日志内容。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLogsResponse ListLogs(ListLogsRequest listLogsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id" , listLogsRequest.LogGroupId.ToString());
            urlParam.Add("log_stream_id" , listLogsRequest.LogStreamId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}/streams/{log_stream_id}/content/query",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListLogsResponse>(response);
        }
        
        /// <summary>
        /// 预览消息模板邮件格式
        ///
        /// 该接口用于预览通知模板邮件格式
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListNotificationTemplateResponse ListNotificationTemplate(ListNotificationTemplateRequest listNotificationTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , listNotificationTemplateRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/events/notification/templates/view",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listNotificationTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListNotificationTemplateResponse>(response);
        }
        
        /// <summary>
        /// 查询消息模板
        ///
        /// 该接口用于查询通知模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListNotificationTemplatesResponse ListNotificationTemplates(ListNotificationTemplatesRequest listNotificationTemplatesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , listNotificationTemplatesRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/events/notification/templates",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotificationTemplatesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListNotificationTemplatesResponse>(response);
        }
        
        /// <summary>
        /// 查询SMN主题
        ///
        /// 该接口用于查询SMN主题
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListNotificationTopicsResponse ListNotificationTopics(ListNotificationTopicsRequest listNotificationTopicsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/notifications/topics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotificationTopicsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListNotificationTopicsResponse>(response);
        }
        
        /// <summary>
        /// 查询日志组下所有快速查询
        ///
        /// 查询日志组下所有快速查询
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListQueryAllSearchCriteriasResponse ListQueryAllSearchCriterias(ListQueryAllSearchCriteriasRequest listQueryAllSearchCriteriasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id" , listQueryAllSearchCriteriasRequest.GroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/lts/groups/{group_id}/search-criterias",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQueryAllSearchCriteriasRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListQueryAllSearchCriteriasResponse>(response);
        }
        
        /// <summary>
        /// 查询结构化日志
        ///
        /// 该接口用于查询指定日志流下的结构化日志内容。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListQueryStructuredLogsResponse ListQueryStructuredLogs(ListQueryStructuredLogsRequest listQueryStructuredLogsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id" , listQueryStructuredLogsRequest.LogGroupId.ToString());
            urlParam.Add("log_stream_id" , listQueryStructuredLogsRequest.LogStreamId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}/streams/{log_stream_id}/struct-content/query",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQueryStructuredLogsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListQueryStructuredLogsResponse>(response);
        }
        
        /// <summary>
        /// 查询结构化模板
        ///
        /// 该接口用于查询结构化模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListStructTemplateResponse ListStructTemplate(ListStructTemplateRequest listStructTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/struct/customtemplate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStructTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListStructTemplateResponse>(response);
        }
        
        /// <summary>
        /// 查询结构化日志（新版）
        ///
        /// 该接口用于查询指定日志流下的结构化日志内容（新版）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListStructuredLogsWithTimeRangeResponse ListStructuredLogsWithTimeRange(ListStructuredLogsWithTimeRangeRequest listStructuredLogsWithTimeRangeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("log_stream_id" , listStructuredLogsWithTimeRangeRequest.LogStreamId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/streams/{log_stream_id}/struct-content/query",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStructuredLogsWithTimeRangeRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            ListStructuredLogsWithTimeRangeResponse listStructuredLogsWithTimeRangeResponse = JsonUtils.DeSerializeNull<ListStructuredLogsWithTimeRangeResponse>(response);
            listStructuredLogsWithTimeRangeResponse.Body = JsonUtils.DeSerializeMap<string, List<Object>>(response);
            return listStructuredLogsWithTimeRangeResponse;
        }
        
        /// <summary>
        /// 按时间段统计查询资源
        ///
        /// 按时间段统计查询资源
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTimeLineTrafficStatisticsResponse ListTimeLineTrafficStatistics(ListTimeLineTrafficStatisticsRequest listTimeLineTrafficStatisticsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/timeline-traffic-statistics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listTimeLineTrafficStatisticsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListTimeLineTrafficStatisticsResponse>(response);
        }
        
        /// <summary>
        /// 统计top n的日志组或日志流流量
        ///
        /// 统计top n的日志组或日志流流量
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTopnTrafficStatisticsResponse ListTopnTrafficStatistics(ListTopnTrafficStatisticsRequest listTopnTrafficStatisticsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/topn-traffic-statistics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listTopnTrafficStatisticsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListTopnTrafficStatisticsResponse>(response);
        }
        
        /// <summary>
        /// 查询日志转储
        ///
        /// 该接口用于查询OBS转储，DIS转储，DMS转储配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTransfersResponse ListTransfers(ListTransfersRequest listTransfersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/transfers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTransfersRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListTransfersResponse>(response);
        }
        
        /// <summary>
        /// 注册DMS kafka实例
        ///
        /// 该接口用于注册DMS kafka实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RegisterDmsKafkaInstanceResponse RegisterDmsKafkaInstance(RegisterDmsKafkaInstanceRequest registerDmsKafkaInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/dms/kafka-instance",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", registerDmsKafkaInstanceRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RegisterDmsKafkaInstanceResponse>(response);
        }
        
        /// <summary>
        /// 查询单个消息模板
        ///
        /// 该接口用于查询单个通知模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowNotificationTemplateResponse ShowNotificationTemplate(ShowNotificationTemplateRequest showNotificationTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showNotificationTemplateRequest.DomainId.ToString());
            urlParam.Add("template_name" , showNotificationTemplateRequest.TemplateName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/events/notification/template/{template_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNotificationTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowNotificationTemplateResponse>(response);
        }
        
        /// <summary>
        /// 查询结构化配置
        ///
        /// 该接口用于查询指定日志流下的结构化配置内容。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowStructTemplateResponse ShowStructTemplate(ShowStructTemplateRequest showStructTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/struct/template",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStructTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowStructTemplateResponse>(response);
        }
        
        /// <summary>
        /// 修改日志接入
        ///
        /// 修改日志接入
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAccessConfigResponse UpdateAccessConfig(UpdateAccessConfigRequest updateAccessConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/access-config",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAccessConfigRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateAccessConfigResponse>(response);
        }
        
        /// <summary>
        /// 修改主机组
        ///
        /// 修改主机组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateHostGroupResponse UpdateHostGroup(UpdateHostGroupRequest updateHostGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/host-group",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateHostGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateHostGroupResponse>(response);
        }
        
        /// <summary>
        /// 修改关键词告警规则
        ///
        /// 该接口用于修改关键词告警。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateKeywordsAlarmRuleResponse UpdateKeywordsAlarmRule(UpdateKeywordsAlarmRuleRequest updateKeywordsAlarmRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/keywords-alarm-rule",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateKeywordsAlarmRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateKeywordsAlarmRuleResponse>(response);
        }
        
        /// <summary>
        /// 修改日志组
        ///
        /// 该接口用于修改指定日志组下的日志存储时长。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateLogGroupResponse UpdateLogGroup(UpdateLogGroupRequest updateLogGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id" , updateLogGroupRequest.LogGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLogGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<UpdateLogGroupResponse>(response);
        }
        
        /// <summary>
        /// 修改日志流
        ///
        /// 该接口用于修改指定日志流下的日志存储时长。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateLogStreamResponse UpdateLogStream(UpdateLogStreamRequest updateLogStreamRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id" , updateLogStreamRequest.LogGroupId.ToString());
            urlParam.Add("log_stream_id" , updateLogStreamRequest.LogStreamId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}/streams_ttl/{log_stream_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLogStreamRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateLogStreamResponse>(response);
        }
        
        /// <summary>
        /// 修改消息模板
        ///
        /// 该接口用于修改通知模板,根据名称进行修改。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateNotificationTemplateResponse UpdateNotificationTemplate(UpdateNotificationTemplateRequest updateNotificationTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateNotificationTemplateRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/events/notification/templates",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateNotificationTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateNotificationTemplateResponse>(response);
        }
        
        /// <summary>
        /// 通过结构化模板修改结构化配置（新）
        ///
        /// 该接口通过结构化模板修改结构化配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateStructConfigResponse UpdateStructConfig(UpdateStructConfigRequest updateStructConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/struct/template",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateStructConfigRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            UpdateStructConfigResponse updateStructConfigResponse = JsonUtils.DeSerializeNull<UpdateStructConfigResponse>(response);
            return updateStructConfigResponse;
        }
        
        /// <summary>
        /// 修改结构化配置
        ///
        /// 该接口用于修改指定日志流下的结构化配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateStructTemplateResponse UpdateStructTemplate(UpdateStructTemplateRequest updateStructTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/struct/template",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateStructTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            UpdateStructTemplateResponse updateStructTemplateResponse = JsonUtils.DeSerializeNull<UpdateStructTemplateResponse>(response);
            return updateStructTemplateResponse;
        }
        
        /// <summary>
        /// 更新日志转储
        ///
        /// 该接口用于更新OBS转储，DIS转储，DMS转储。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTransferResponse UpdateTransfer(UpdateTransferRequest updateTransferRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/transfers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateTransferRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateTransferResponse>(response);
        }
        
        /// <summary>
        /// 创建接入规则
        ///
        /// 该接口用于创建aom日志接入lts规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAomMappingRulesResponse CreateAomMappingRules(CreateAomMappingRulesRequest createAomMappingRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/aom-mapping",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAomMappingRulesRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            CreateAomMappingRulesResponse createAomMappingRulesResponse = JsonUtils.DeSerializeNull<CreateAomMappingRulesResponse>(response);
            createAomMappingRulesResponse.Body = JsonUtils.DeSerializeList<AomMappingRuleResp>(response);
            return createAomMappingRulesResponse;
        }
        
        /// <summary>
        /// 删除接入规则
        ///
        /// 该接口用于删除lts接入规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAomMappingRulesResponse DeleteAomMappingRules(DeleteAomMappingRulesRequest deleteAomMappingRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/aom-mapping",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAomMappingRulesRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            DeleteAomMappingRulesResponse deleteAomMappingRulesResponse = JsonUtils.DeSerializeNull<DeleteAomMappingRulesResponse>(response);
            deleteAomMappingRulesResponse.Body = JsonUtils.DeSerializeList<string>(response);
            return deleteAomMappingRulesResponse;
        }
        
        /// <summary>
        /// 查询单个接入规则
        ///
        /// 该接口用于查询单个aom日志接入lts
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAomMappingRuleResponse ShowAomMappingRule(ShowAomMappingRuleRequest showAomMappingRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id" , showAomMappingRuleRequest.RuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/aom-mapping/{rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAomMappingRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            ShowAomMappingRuleResponse showAomMappingRuleResponse = JsonUtils.DeSerializeNull<ShowAomMappingRuleResponse>(response);
            showAomMappingRuleResponse.Body = JsonUtils.DeSerializeList<AomMappingRuleResp>(response);
            return showAomMappingRuleResponse;
        }
        
        /// <summary>
        /// 查询所有接入规则
        ///
        /// 该接口用于查询aom日志所有接入lts规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAomMappingRulesResponse ShowAomMappingRules(ShowAomMappingRulesRequest showAomMappingRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/aom-mapping",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAomMappingRulesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            ShowAomMappingRulesResponse showAomMappingRulesResponse = JsonUtils.DeSerializeNull<ShowAomMappingRulesResponse>(response);
            showAomMappingRulesResponse.Body = JsonUtils.DeSerializeList<AomMappingRuleResp>(response);
            return showAomMappingRulesResponse;
        }
        
        /// <summary>
        /// 修改接入规则
        ///
        /// 该接口用于修改接入规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAomMappingRulesResponse UpdateAomMappingRules(UpdateAomMappingRulesRequest updateAomMappingRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/aom-mapping",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAomMappingRulesRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateAomMappingRulesResponse>(response);
        }
        
        /// <summary>
        /// 创建SQL告警规则
        ///
        /// 该接口用于创建SQL告警，目前每个帐户最多可以创建共200个关键词告警与SQL告警
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateSqlAlarmRuleResponse CreateSqlAlarmRule(CreateSqlAlarmRuleRequest createSqlAlarmRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/sql-alarm-rule",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSqlAlarmRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateSqlAlarmRuleResponse>(response);
        }
        
        /// <summary>
        /// 删除SQL告警规则
        ///
        /// 该接口用于删除SQL告警
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSqlAlarmRuleResponse DeleteSqlAlarmRule(DeleteSqlAlarmRuleRequest deleteSqlAlarmRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("sql_alarm_rule_id" , deleteSqlAlarmRuleRequest.SqlAlarmRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/sql-alarm-rule/{sql_alarm_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSqlAlarmRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSqlAlarmRuleResponse>(response);
        }
        
        /// <summary>
        /// 查询SQL告警规则
        ///
        /// 该接口用于查询SQL告警
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSqlAlarmRulesResponse ListSqlAlarmRules(ListSqlAlarmRulesRequest listSqlAlarmRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/sql-alarm-rule",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSqlAlarmRulesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListSqlAlarmRulesResponse>(response);
        }
        
        /// <summary>
        /// 切换告警规则状态
        ///
        /// 改变告警规则状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAlarmRuleStatusResponse UpdateAlarmRuleStatus(UpdateAlarmRuleStatusRequest updateAlarmRuleStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/status",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAlarmRuleStatusRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            UpdateAlarmRuleStatusResponse updateAlarmRuleStatusResponse = JsonUtils.DeSerializeNull<UpdateAlarmRuleStatusResponse>(response);
            return updateAlarmRuleStatusResponse;
        }
        
        /// <summary>
        /// 修改SQL告警规则
        ///
        /// 该接口用于修改SQL告警
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateSqlAlarmRuleResponse UpdateSqlAlarmRule(UpdateSqlAlarmRuleRequest updateSqlAlarmRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/sql-alarm-rule",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSqlAlarmRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateSqlAlarmRuleResponse>(response);
        }
        
    }
}