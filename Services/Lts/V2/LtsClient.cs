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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/access-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAccessConfigRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAccessConfigResponse>(response);
        }

        public SyncInvoker<CreateAccessConfigResponse> CreateAccessConfigInvoker(CreateAccessConfigRequest createAccessConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/access-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAccessConfigRequest);
            return new SyncInvoker<CreateAccessConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAccessConfigResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboard", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDashBoardRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDashBoardResponse>(response);
        }

        public SyncInvoker<CreateDashBoardResponse> CreateDashBoardInvoker(CreateDashBoardRequest createDashBoardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboard", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDashBoardRequest);
            return new SyncInvoker<CreateDashBoardResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDashBoardResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/dashboard-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDashboardGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDashboardGroupResponse>(response);
        }

        public SyncInvoker<CreateDashboardGroupResponse> CreateDashboardGroupInvoker(CreateDashboardGroupRequest createDashboardGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/dashboard-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDashboardGroupRequest);
            return new SyncInvoker<CreateDashboardGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDashboardGroupResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/host-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createHostGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateHostGroupResponse>(response);
        }

        public SyncInvoker<CreateHostGroupResponse> CreateHostGroupInvoker(CreateHostGroupRequest createHostGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/host-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createHostGroupRequest);
            return new SyncInvoker<CreateHostGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateHostGroupResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/keywords-alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createKeywordsAlarmRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateKeywordsAlarmRuleResponse>(response);
        }

        public SyncInvoker<CreateKeywordsAlarmRuleResponse> CreateKeywordsAlarmRuleInvoker(CreateKeywordsAlarmRuleRequest createKeywordsAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/keywords-alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createKeywordsAlarmRuleRequest);
            return new SyncInvoker<CreateKeywordsAlarmRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateKeywordsAlarmRuleResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/log-dump/obs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLogDumpObsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateLogDumpObsResponse>(response);
        }

        public SyncInvoker<CreateLogDumpObsResponse> CreateLogDumpObsInvoker(CreateLogDumpObsRequest createLogDumpObsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/log-dump/obs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLogDumpObsRequest);
            return new SyncInvoker<CreateLogDumpObsResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateLogDumpObsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLogGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateLogGroupResponse>(response);
        }

        public SyncInvoker<CreateLogGroupResponse> CreateLogGroupInvoker(CreateLogGroupRequest createLogGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLogGroupRequest);
            return new SyncInvoker<CreateLogGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateLogGroupResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id", createLogStreamRequest.LogGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}/streams", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLogStreamRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateLogStreamResponse>(response);
        }

        public SyncInvoker<CreateLogStreamResponse> CreateLogStreamInvoker(CreateLogStreamRequest createLogStreamRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id", createLogStreamRequest.LogGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}/streams", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLogStreamRequest);
            return new SyncInvoker<CreateLogStreamResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateLogStreamResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", createNotificationTemplateRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/events/notification/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createNotificationTemplateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateNotificationTemplateResponse>(response);
        }

        public SyncInvoker<CreateNotificationTemplateResponse> CreateNotificationTemplateInvoker(CreateNotificationTemplateRequest createNotificationTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", createNotificationTemplateRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/events/notification/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createNotificationTemplateRequest);
            return new SyncInvoker<CreateNotificationTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateNotificationTemplateResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", createSearchCriteriasRequest.GroupId.ToString());
            urlParam.Add("topic_id", createSearchCriteriasRequest.TopicId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/groups/{group_id}/topics/{topic_id}/search-criterias", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSearchCriteriasRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateSearchCriteriasResponse>(response);
        }

        public SyncInvoker<CreateSearchCriteriasResponse> CreateSearchCriteriasInvoker(CreateSearchCriteriasRequest createSearchCriteriasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", createSearchCriteriasRequest.GroupId.ToString());
            urlParam.Add("topic_id", createSearchCriteriasRequest.TopicId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/groups/{group_id}/topics/{topic_id}/search-criterias", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSearchCriteriasRequest);
            return new SyncInvoker<CreateSearchCriteriasResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSearchCriteriasResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/struct/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createStructConfigRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateStructConfigResponse>(response);
        }

        public SyncInvoker<CreateStructConfigResponse> CreateStructConfigInvoker(CreateStructConfigRequest createStructConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/struct/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createStructConfigRequest);
            return new SyncInvoker<CreateStructConfigResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateStructConfigResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/struct/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createStructTemplateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateStructTemplateResponse>(response);
        }

        public SyncInvoker<CreateStructTemplateResponse> CreateStructTemplateInvoker(CreateStructTemplateRequest createStructTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/struct/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createStructTemplateRequest);
            return new SyncInvoker<CreateStructTemplateResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateStructTemplateResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", createTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id", createTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/{resource_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateTagsResponse>(response);
        }

        public SyncInvoker<CreateTagsResponse> CreateTagsInvoker(CreateTagsRequest createTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", createTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id", createTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/{resource_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTagsRequest);
            return new SyncInvoker<CreateTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateTagsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/transfers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTransferRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateTransferResponse>(response);
        }

        public SyncInvoker<CreateTransferResponse> CreateTransferInvoker(CreateTransferRequest createTransferRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/transfers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTransferRequest);
            return new SyncInvoker<CreateTransferResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTransferResponse>);
        }
        
        /// <summary>
        /// 创建日志收藏
        ///
        /// 创建日志收藏
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatefavoriteResponse Createfavorite(CreatefavoriteRequest createfavoriteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/lts/favorite", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createfavoriteRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatefavoriteResponse>(response);
        }

        public SyncInvoker<CreatefavoriteResponse> CreatefavoriteInvoker(CreatefavoriteRequest createfavoriteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/lts/favorite", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createfavoriteRequest);
            return new SyncInvoker<CreatefavoriteResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatefavoriteResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/access-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteAccessConfigRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAccessConfigResponse>(response);
        }

        public SyncInvoker<DeleteAccessConfigResponse> DeleteAccessConfigInvoker(DeleteAccessConfigRequest deleteAccessConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/access-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteAccessConfigRequest);
            return new SyncInvoker<DeleteAccessConfigResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAccessConfigResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", deleteActiveAlarmsRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/alarms/sql-alarm/clear", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteActiveAlarmsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteActiveAlarmsResponse>(response);
        }

        public SyncInvoker<DeleteActiveAlarmsResponse> DeleteActiveAlarmsInvoker(DeleteActiveAlarmsRequest deleteActiveAlarmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", deleteActiveAlarmsRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/alarms/sql-alarm/clear", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteActiveAlarmsRequest);
            return new SyncInvoker<DeleteActiveAlarmsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteActiveAlarmsResponse>);
        }
        
        /// <summary>
        /// 删除仪表盘
        ///
        /// 删除仪表盘
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDashboardResponse DeleteDashboard(DeleteDashboardRequest deleteDashboardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboard", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDashboardRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDashboardResponse>(response);
        }

        public SyncInvoker<DeleteDashboardResponse> DeleteDashboardInvoker(DeleteDashboardRequest deleteDashboardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboard", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDashboardRequest);
            return new SyncInvoker<DeleteDashboardResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDashboardResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/host-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteHostGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteHostGroupResponse>(response);
        }

        public SyncInvoker<DeleteHostGroupResponse> DeleteHostGroupInvoker(DeleteHostGroupRequest deleteHostGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/host-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteHostGroupRequest);
            return new SyncInvoker<DeleteHostGroupResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteHostGroupResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("keywords_alarm_rule_id", deleteKeywordsAlarmRuleRequest.KeywordsAlarmRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/keywords-alarm-rule/{keywords_alarm_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKeywordsAlarmRuleRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteKeywordsAlarmRuleResponse>(response);
        }

        public SyncInvoker<DeleteKeywordsAlarmRuleResponse> DeleteKeywordsAlarmRuleInvoker(DeleteKeywordsAlarmRuleRequest deleteKeywordsAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("keywords_alarm_rule_id", deleteKeywordsAlarmRuleRequest.KeywordsAlarmRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/keywords-alarm-rule/{keywords_alarm_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKeywordsAlarmRuleRequest);
            return new SyncInvoker<DeleteKeywordsAlarmRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteKeywordsAlarmRuleResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id", deleteLogGroupRequest.LogGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLogGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteLogGroupResponse>(response);
        }

        public SyncInvoker<DeleteLogGroupResponse> DeleteLogGroupInvoker(DeleteLogGroupRequest deleteLogGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id", deleteLogGroupRequest.LogGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLogGroupRequest);
            return new SyncInvoker<DeleteLogGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteLogGroupResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id", deleteLogStreamRequest.LogGroupId.ToString());
            urlParam.Add("log_stream_id", deleteLogStreamRequest.LogStreamId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}/streams/{log_stream_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLogStreamRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteLogStreamResponse>(response);
        }

        public SyncInvoker<DeleteLogStreamResponse> DeleteLogStreamInvoker(DeleteLogStreamRequest deleteLogStreamRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id", deleteLogStreamRequest.LogGroupId.ToString());
            urlParam.Add("log_stream_id", deleteLogStreamRequest.LogStreamId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}/streams/{log_stream_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLogStreamRequest);
            return new SyncInvoker<DeleteLogStreamResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteLogStreamResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", deleteNotificationTemplateRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/events/notification/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteNotificationTemplateRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteNotificationTemplateResponse>(response);
        }

        public SyncInvoker<DeleteNotificationTemplateResponse> DeleteNotificationTemplateInvoker(DeleteNotificationTemplateRequest deleteNotificationTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", deleteNotificationTemplateRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/events/notification/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteNotificationTemplateRequest);
            return new SyncInvoker<DeleteNotificationTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteNotificationTemplateResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", deleteSearchCriteriasRequest.GroupId.ToString());
            urlParam.Add("topic_id", deleteSearchCriteriasRequest.TopicId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/groups/{group_id}/topics/{topic_id}/search-criterias", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteSearchCriteriasRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSearchCriteriasResponse>(response);
        }

        public SyncInvoker<DeleteSearchCriteriasResponse> DeleteSearchCriteriasInvoker(DeleteSearchCriteriasRequest deleteSearchCriteriasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", deleteSearchCriteriasRequest.GroupId.ToString());
            urlParam.Add("topic_id", deleteSearchCriteriasRequest.TopicId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/groups/{group_id}/topics/{topic_id}/search-criterias", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteSearchCriteriasRequest);
            return new SyncInvoker<DeleteSearchCriteriasResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSearchCriteriasResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/struct/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteStructTemplateRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteStructTemplateResponse>(response);
        }

        public SyncInvoker<DeleteStructTemplateResponse> DeleteStructTemplateInvoker(DeleteStructTemplateRequest deleteStructTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/struct/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteStructTemplateRequest);
            return new SyncInvoker<DeleteStructTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteStructTemplateResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/transfers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTransferRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteTransferResponse>(response);
        }

        public SyncInvoker<DeleteTransferResponse> DeleteTransferInvoker(DeleteTransferRequest deleteTransferRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/transfers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTransferRequest);
            return new SyncInvoker<DeleteTransferResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteTransferResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("fav_res_id", deletefavoriteRequest.FavResId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/lts/favorite/{fav_res_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletefavoriteRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletefavoriteResponse>(response);
        }

        public SyncInvoker<DeletefavoriteResponse> DeletefavoriteInvoker(DeletefavoriteRequest deletefavoriteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("fav_res_id", deletefavoriteRequest.FavResId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/lts/favorite/{fav_res_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletefavoriteRequest);
            return new SyncInvoker<DeletefavoriteResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletefavoriteResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/collection/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableLogCollectionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DisableLogCollectionResponse>(response);
        }

        public SyncInvoker<DisableLogCollectionResponse> DisableLogCollectionInvoker(DisableLogCollectionRequest disableLogCollectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/collection/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableLogCollectionRequest);
            return new SyncInvoker<DisableLogCollectionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DisableLogCollectionResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/collection/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableLogCollectionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<EnableLogCollectionResponse>(response);
        }

        public SyncInvoker<EnableLogCollectionResponse> EnableLogCollectionInvoker(EnableLogCollectionRequest enableLogCollectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/collection/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableLogCollectionRequest);
            return new SyncInvoker<EnableLogCollectionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<EnableLogCollectionResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/access-config-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAccessConfigRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListAccessConfigResponse>(response);
        }

        public SyncInvoker<ListAccessConfigResponse> ListAccessConfigInvoker(ListAccessConfigRequest listAccessConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/access-config-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAccessConfigRequest);
            return new SyncInvoker<ListAccessConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAccessConfigResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", listActiveOrHistoryAlarmsRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/alarms/sql-alarm/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listActiveOrHistoryAlarmsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListActiveOrHistoryAlarmsResponse>(response);
        }

        public SyncInvoker<ListActiveOrHistoryAlarmsResponse> ListActiveOrHistoryAlarmsInvoker(ListActiveOrHistoryAlarmsRequest listActiveOrHistoryAlarmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", listActiveOrHistoryAlarmsRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/alarms/sql-alarm/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listActiveOrHistoryAlarmsRequest);
            return new SyncInvoker<ListActiveOrHistoryAlarmsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListActiveOrHistoryAlarmsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/struct/customtemplate/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBreifStructTemplateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBreifStructTemplateResponse>(response);
        }

        public SyncInvoker<ListBreifStructTemplateResponse> ListBreifStructTemplateInvoker(ListBreifStructTemplateRequest listBreifStructTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/struct/customtemplate/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBreifStructTemplateRequest);
            return new SyncInvoker<ListBreifStructTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBreifStructTemplateResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id", listChartsRequest.LogGroupId.ToString());
            urlParam.Add("log_stream_id", listChartsRequest.LogStreamId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}/streams/{log_stream_id}/charts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listChartsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListChartsResponse>(response);
        }

        public SyncInvoker<ListChartsResponse> ListChartsInvoker(ListChartsRequest listChartsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id", listChartsRequest.LogGroupId.ToString());
            urlParam.Add("log_stream_id", listChartsRequest.LogStreamId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}/streams/{log_stream_id}/charts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listChartsRequest);
            return new SyncInvoker<ListChartsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListChartsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", listCriteriasRequest.GroupId.ToString());
            urlParam.Add("topic_id", listCriteriasRequest.TopicId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/groups/{group_id}/topics/{topic_id}/search-criterias", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCriteriasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCriteriasResponse>(response);
        }

        public SyncInvoker<ListCriteriasResponse> ListCriteriasInvoker(ListCriteriasRequest listCriteriasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", listCriteriasRequest.GroupId.ToString());
            urlParam.Add("topic_id", listCriteriasRequest.TopicId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/groups/{group_id}/topics/{topic_id}/search-criterias", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCriteriasRequest);
            return new SyncInvoker<ListCriteriasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCriteriasResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/history-sql", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHistorySqlRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListHistorySqlResponse>(response);
        }

        public SyncInvoker<ListHistorySqlResponse> ListHistorySqlInvoker(ListHistorySqlRequest listHistorySqlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/history-sql", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHistorySqlRequest);
            return new SyncInvoker<ListHistorySqlResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHistorySqlResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/host-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listHostRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListHostResponse>(response);
        }

        public SyncInvoker<ListHostResponse> ListHostInvoker(ListHostRequest listHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/host-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listHostRequest);
            return new SyncInvoker<ListHostResponse>(this, "POST", request, JsonUtils.DeSerialize<ListHostResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/host-group-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listHostGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListHostGroupResponse>(response);
        }

        public SyncInvoker<ListHostGroupResponse> ListHostGroupInvoker(ListHostGroupRequest listHostGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/host-group-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listHostGroupRequest);
            return new SyncInvoker<ListHostGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<ListHostGroupResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/keywords-alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeywordsAlarmRulesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListKeywordsAlarmRulesResponse>(response);
        }

        public SyncInvoker<ListKeywordsAlarmRulesResponse> ListKeywordsAlarmRulesInvoker(ListKeywordsAlarmRulesRequest listKeywordsAlarmRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/keywords-alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeywordsAlarmRulesRequest);
            return new SyncInvoker<ListKeywordsAlarmRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListKeywordsAlarmRulesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListLogGroupsResponse>(response);
        }

        public SyncInvoker<ListLogGroupsResponse> ListLogGroupsInvoker(ListLogGroupsRequest listLogGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogGroupsRequest);
            return new SyncInvoker<ListLogGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLogGroupsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/keyword-count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listLogHistogramRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListLogHistogramResponse>(response);
        }

        public SyncInvoker<ListLogHistogramResponse> ListLogHistogramInvoker(ListLogHistogramRequest listLogHistogramRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/keyword-count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listLogHistogramRequest);
            return new SyncInvoker<ListLogHistogramResponse>(this, "POST", request, JsonUtils.DeSerialize<ListLogHistogramResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id", listLogStreamRequest.LogGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}/streams", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogStreamRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListLogStreamResponse>(response);
        }

        public SyncInvoker<ListLogStreamResponse> ListLogStreamInvoker(ListLogStreamRequest listLogStreamRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id", listLogStreamRequest.LogGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}/streams", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogStreamRequest);
            return new SyncInvoker<ListLogStreamResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLogStreamResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/log-streams", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogStreamsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListLogStreamsResponse>(response);
        }

        public SyncInvoker<ListLogStreamsResponse> ListLogStreamsInvoker(ListLogStreamsRequest listLogStreamsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/log-streams", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogStreamsRequest);
            return new SyncInvoker<ListLogStreamsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLogStreamsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id", listLogsRequest.LogGroupId.ToString());
            urlParam.Add("log_stream_id", listLogsRequest.LogStreamId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}/streams/{log_stream_id}/content/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListLogsResponse>(response);
        }

        public SyncInvoker<ListLogsResponse> ListLogsInvoker(ListLogsRequest listLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id", listLogsRequest.LogGroupId.ToString());
            urlParam.Add("log_stream_id", listLogsRequest.LogStreamId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}/streams/{log_stream_id}/content/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogsRequest);
            return new SyncInvoker<ListLogsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListLogsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", listNotificationTemplateRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/events/notification/templates/view", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listNotificationTemplateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListNotificationTemplateResponse>(response);
        }

        public SyncInvoker<ListNotificationTemplateResponse> ListNotificationTemplateInvoker(ListNotificationTemplateRequest listNotificationTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", listNotificationTemplateRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/events/notification/templates/view", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listNotificationTemplateRequest);
            return new SyncInvoker<ListNotificationTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<ListNotificationTemplateResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", listNotificationTemplatesRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/events/notification/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotificationTemplatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListNotificationTemplatesResponse>(response);
        }

        public SyncInvoker<ListNotificationTemplatesResponse> ListNotificationTemplatesInvoker(ListNotificationTemplatesRequest listNotificationTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", listNotificationTemplatesRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/events/notification/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotificationTemplatesRequest);
            return new SyncInvoker<ListNotificationTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNotificationTemplatesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/notifications/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotificationTopicsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListNotificationTopicsResponse>(response);
        }

        public SyncInvoker<ListNotificationTopicsResponse> ListNotificationTopicsInvoker(ListNotificationTopicsRequest listNotificationTopicsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/notifications/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotificationTopicsRequest);
            return new SyncInvoker<ListNotificationTopicsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNotificationTopicsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", listQueryAllSearchCriteriasRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/lts/groups/{group_id}/search-criterias", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQueryAllSearchCriteriasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListQueryAllSearchCriteriasResponse>(response);
        }

        public SyncInvoker<ListQueryAllSearchCriteriasResponse> ListQueryAllSearchCriteriasInvoker(ListQueryAllSearchCriteriasRequest listQueryAllSearchCriteriasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", listQueryAllSearchCriteriasRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/lts/groups/{group_id}/search-criterias", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQueryAllSearchCriteriasRequest);
            return new SyncInvoker<ListQueryAllSearchCriteriasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListQueryAllSearchCriteriasResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id", listQueryStructuredLogsRequest.LogGroupId.ToString());
            urlParam.Add("log_stream_id", listQueryStructuredLogsRequest.LogStreamId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}/streams/{log_stream_id}/struct-content/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQueryStructuredLogsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListQueryStructuredLogsResponse>(response);
        }

        public SyncInvoker<ListQueryStructuredLogsResponse> ListQueryStructuredLogsInvoker(ListQueryStructuredLogsRequest listQueryStructuredLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id", listQueryStructuredLogsRequest.LogGroupId.ToString());
            urlParam.Add("log_stream_id", listQueryStructuredLogsRequest.LogStreamId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}/streams/{log_stream_id}/struct-content/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQueryStructuredLogsRequest);
            return new SyncInvoker<ListQueryStructuredLogsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListQueryStructuredLogsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/struct/customtemplate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStructTemplateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListStructTemplateResponse>(response);
        }

        public SyncInvoker<ListStructTemplateResponse> ListStructTemplateInvoker(ListStructTemplateRequest listStructTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/struct/customtemplate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStructTemplateRequest);
            return new SyncInvoker<ListStructTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStructTemplateResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_stream_id", listStructuredLogsWithTimeRangeRequest.LogStreamId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/streams/{log_stream_id}/struct-content/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStructuredLogsWithTimeRangeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListStructuredLogsWithTimeRangeResponse>(response);
        }

        public SyncInvoker<ListStructuredLogsWithTimeRangeResponse> ListStructuredLogsWithTimeRangeInvoker(ListStructuredLogsWithTimeRangeRequest listStructuredLogsWithTimeRangeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_stream_id", listStructuredLogsWithTimeRangeRequest.LogStreamId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/streams/{log_stream_id}/struct-content/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStructuredLogsWithTimeRangeRequest);
            return new SyncInvoker<ListStructuredLogsWithTimeRangeResponse>(this, "POST", request, JsonUtils.DeSerialize<ListStructuredLogsWithTimeRangeResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/timeline-traffic-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listTimeLineTrafficStatisticsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListTimeLineTrafficStatisticsResponse>(response);
        }

        public SyncInvoker<ListTimeLineTrafficStatisticsResponse> ListTimeLineTrafficStatisticsInvoker(ListTimeLineTrafficStatisticsRequest listTimeLineTrafficStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/timeline-traffic-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listTimeLineTrafficStatisticsRequest);
            return new SyncInvoker<ListTimeLineTrafficStatisticsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListTimeLineTrafficStatisticsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/topn-traffic-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listTopnTrafficStatisticsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListTopnTrafficStatisticsResponse>(response);
        }

        public SyncInvoker<ListTopnTrafficStatisticsResponse> ListTopnTrafficStatisticsInvoker(ListTopnTrafficStatisticsRequest listTopnTrafficStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/topn-traffic-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listTopnTrafficStatisticsRequest);
            return new SyncInvoker<ListTopnTrafficStatisticsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListTopnTrafficStatisticsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/transfers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTransfersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTransfersResponse>(response);
        }

        public SyncInvoker<ListTransfersResponse> ListTransfersInvoker(ListTransfersRequest listTransfersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/transfers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTransfersRequest);
            return new SyncInvoker<ListTransfersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTransfersResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/dms/kafka-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", registerDmsKafkaInstanceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RegisterDmsKafkaInstanceResponse>(response);
        }

        public SyncInvoker<RegisterDmsKafkaInstanceResponse> RegisterDmsKafkaInstanceInvoker(RegisterDmsKafkaInstanceRequest registerDmsKafkaInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/dms/kafka-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", registerDmsKafkaInstanceRequest);
            return new SyncInvoker<RegisterDmsKafkaInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RegisterDmsKafkaInstanceResponse>);
        }
        
        /// <summary>
        /// 获取日志汇聚开关
        ///
        /// 只能由管理员或者委托管理员调用    获取日志汇聚开关
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAdminConfigResponse ShowAdminConfig(ShowAdminConfigRequest showAdminConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/lts/log-converge-config/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAdminConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAdminConfigResponse>(response);
        }

        public SyncInvoker<ShowAdminConfigResponse> ShowAdminConfigInvoker(ShowAdminConfigRequest showAdminConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/lts/log-converge-config/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAdminConfigRequest);
            return new SyncInvoker<ShowAdminConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAdminConfigResponse>);
        }
        
        /// <summary>
        /// 获取组织成员汇聚配置
        ///
        /// 只能由组织管理员或者委托管理员调用    获取组织成员汇聚配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowLogConvergeConfigResponse ShowLogConvergeConfig(ShowLogConvergeConfigRequest showLogConvergeConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("member_account_id", showLogConvergeConfigRequest.MemberAccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/lts/log-converge-config/{member_account_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogConvergeConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowLogConvergeConfigResponse>(response);
        }

        public SyncInvoker<ShowLogConvergeConfigResponse> ShowLogConvergeConfigInvoker(ShowLogConvergeConfigRequest showLogConvergeConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("member_account_id", showLogConvergeConfigRequest.MemberAccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/lts/log-converge-config/{member_account_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogConvergeConfigRequest);
            return new SyncInvoker<ShowLogConvergeConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLogConvergeConfigResponse>);
        }
        
        /// <summary>
        /// 获取组织成员日志组日志流
        ///
        /// 只能由管理员或者委托管理员调用，获取组织成员日志组日志流
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMemberGroupAndStreamResponse ShowMemberGroupAndStream(ShowMemberGroupAndStreamRequest showMemberGroupAndStreamRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("member_account_id", showMemberGroupAndStreamRequest.MemberAccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/lts/{member_account_id}/all-streams", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMemberGroupAndStreamRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMemberGroupAndStreamResponse>(response);
        }

        public SyncInvoker<ShowMemberGroupAndStreamResponse> ShowMemberGroupAndStreamInvoker(ShowMemberGroupAndStreamRequest showMemberGroupAndStreamRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("member_account_id", showMemberGroupAndStreamRequest.MemberAccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/lts/{member_account_id}/all-streams", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMemberGroupAndStreamRequest);
            return new SyncInvoker<ShowMemberGroupAndStreamResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMemberGroupAndStreamResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showNotificationTemplateRequest.DomainId.ToString());
            urlParam.Add("template_name", showNotificationTemplateRequest.TemplateName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/events/notification/template/{template_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNotificationTemplateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowNotificationTemplateResponse>(response);
        }

        public SyncInvoker<ShowNotificationTemplateResponse> ShowNotificationTemplateInvoker(ShowNotificationTemplateRequest showNotificationTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showNotificationTemplateRequest.DomainId.ToString());
            urlParam.Add("template_name", showNotificationTemplateRequest.TemplateName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/events/notification/template/{template_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNotificationTemplateRequest);
            return new SyncInvoker<ShowNotificationTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNotificationTemplateResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/struct/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStructTemplateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowStructTemplateResponse>(response);
        }

        public SyncInvoker<ShowStructTemplateResponse> ShowStructTemplateInvoker(ShowStructTemplateRequest showStructTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/struct/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStructTemplateRequest);
            return new SyncInvoker<ShowStructTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStructTemplateResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/access-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAccessConfigRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAccessConfigResponse>(response);
        }

        public SyncInvoker<UpdateAccessConfigResponse> UpdateAccessConfigInvoker(UpdateAccessConfigRequest updateAccessConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/access-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAccessConfigRequest);
            return new SyncInvoker<UpdateAccessConfigResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAccessConfigResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/host-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateHostGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateHostGroupResponse>(response);
        }

        public SyncInvoker<UpdateHostGroupResponse> UpdateHostGroupInvoker(UpdateHostGroupRequest updateHostGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/host-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateHostGroupRequest);
            return new SyncInvoker<UpdateHostGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateHostGroupResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/keywords-alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateKeywordsAlarmRuleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateKeywordsAlarmRuleResponse>(response);
        }

        public SyncInvoker<UpdateKeywordsAlarmRuleResponse> UpdateKeywordsAlarmRuleInvoker(UpdateKeywordsAlarmRuleRequest updateKeywordsAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/keywords-alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateKeywordsAlarmRuleRequest);
            return new SyncInvoker<UpdateKeywordsAlarmRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateKeywordsAlarmRuleResponse>);
        }
        
        /// <summary>
        /// 更新汇聚配置
        ///
        /// 只能由管理员或者委托管理员 ,更新汇聚配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateLogConvergeConfigResponse UpdateLogConvergeConfig(UpdateLogConvergeConfigRequest updateLogConvergeConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/lts/log-converge-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLogConvergeConfigRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateLogConvergeConfigResponse>(response);
        }

        public SyncInvoker<UpdateLogConvergeConfigResponse> UpdateLogConvergeConfigInvoker(UpdateLogConvergeConfigRequest updateLogConvergeConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/lts/log-converge-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLogConvergeConfigRequest);
            return new SyncInvoker<UpdateLogConvergeConfigResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateLogConvergeConfigResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id", updateLogGroupRequest.LogGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLogGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateLogGroupResponse>(response);
        }

        public SyncInvoker<UpdateLogGroupResponse> UpdateLogGroupInvoker(UpdateLogGroupRequest updateLogGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id", updateLogGroupRequest.LogGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLogGroupRequest);
            return new SyncInvoker<UpdateLogGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateLogGroupResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id", updateLogStreamRequest.LogGroupId.ToString());
            urlParam.Add("log_stream_id", updateLogStreamRequest.LogStreamId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}/streams-ttl/{log_stream_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLogStreamRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateLogStreamResponse>(response);
        }

        public SyncInvoker<UpdateLogStreamResponse> UpdateLogStreamInvoker(UpdateLogStreamRequest updateLogStreamRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id", updateLogStreamRequest.LogGroupId.ToString());
            urlParam.Add("log_stream_id", updateLogStreamRequest.LogStreamId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}/streams-ttl/{log_stream_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLogStreamRequest);
            return new SyncInvoker<UpdateLogStreamResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateLogStreamResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateNotificationTemplateRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/events/notification/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateNotificationTemplateRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateNotificationTemplateResponse>(response);
        }

        public SyncInvoker<UpdateNotificationTemplateResponse> UpdateNotificationTemplateInvoker(UpdateNotificationTemplateRequest updateNotificationTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateNotificationTemplateRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/events/notification/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateNotificationTemplateRequest);
            return new SyncInvoker<UpdateNotificationTemplateResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateNotificationTemplateResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/struct/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateStructConfigRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateStructConfigResponse>(response);
        }

        public SyncInvoker<UpdateStructConfigResponse> UpdateStructConfigInvoker(UpdateStructConfigRequest updateStructConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/struct/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateStructConfigRequest);
            return new SyncInvoker<UpdateStructConfigResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateStructConfigResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/struct/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateStructTemplateRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateStructTemplateResponse>(response);
        }

        public SyncInvoker<UpdateStructTemplateResponse> UpdateStructTemplateInvoker(UpdateStructTemplateRequest updateStructTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/struct/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateStructTemplateRequest);
            return new SyncInvoker<UpdateStructTemplateResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateStructTemplateResponse>);
        }
        
        /// <summary>
        /// 修改日志汇聚开关
        ///
        /// 只能由管理员或者委托管理员调用     修改日志汇聚开关
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateSwitchResponse UpdateSwitch(UpdateSwitchRequest updateSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/lts/log-converge-config/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSwitchRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSwitchResponse>(response);
        }

        public SyncInvoker<UpdateSwitchResponse> UpdateSwitchInvoker(UpdateSwitchRequest updateSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/lts/log-converge-config/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSwitchRequest);
            return new SyncInvoker<UpdateSwitchResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSwitchResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/transfers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateTransferRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateTransferResponse>(response);
        }

        public SyncInvoker<UpdateTransferResponse> UpdateTransferInvoker(UpdateTransferRequest updateTransferRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/transfers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateTransferRequest);
            return new SyncInvoker<UpdateTransferResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateTransferResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/aom-mapping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAomMappingRulesRequest);
            var response = DoHttpRequestSync("POST", request);
            var createAomMappingRulesResponse = JsonUtils.DeSerializeNull<CreateAomMappingRulesResponse>(response);
            createAomMappingRulesResponse.Body = JsonUtils.DeSerializeList<AomMappingRuleResp>(response);
            return createAomMappingRulesResponse;
        }

        public SyncInvoker<CreateAomMappingRulesResponse> CreateAomMappingRulesInvoker(CreateAomMappingRulesRequest createAomMappingRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/aom-mapping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAomMappingRulesRequest);
            return new SyncInvoker<CreateAomMappingRulesResponse>(this, "POST", request, response =>
            {
                var createAomMappingRulesResponse = JsonUtils.DeSerializeNull<CreateAomMappingRulesResponse>(response);
                createAomMappingRulesResponse.Body = JsonUtils.DeSerializeList<AomMappingRuleResp>(response);
                return createAomMappingRulesResponse;
            });
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/aom-mapping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAomMappingRulesRequest);
            var response = DoHttpRequestSync("DELETE", request);
            var deleteAomMappingRulesResponse = JsonUtils.DeSerializeNull<DeleteAomMappingRulesResponse>(response);
            deleteAomMappingRulesResponse.Body = JsonUtils.DeSerializeList<string>(response);
            return deleteAomMappingRulesResponse;
        }

        public SyncInvoker<DeleteAomMappingRulesResponse> DeleteAomMappingRulesInvoker(DeleteAomMappingRulesRequest deleteAomMappingRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/aom-mapping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAomMappingRulesRequest);
            return new SyncInvoker<DeleteAomMappingRulesResponse>(this, "DELETE", request, response =>
            {
                var deleteAomMappingRulesResponse = JsonUtils.DeSerializeNull<DeleteAomMappingRulesResponse>(response);
                deleteAomMappingRulesResponse.Body = JsonUtils.DeSerializeList<string>(response);
                return deleteAomMappingRulesResponse;
            });
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id", showAomMappingRuleRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/aom-mapping/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAomMappingRuleRequest);
            var response = DoHttpRequestSync("GET", request);
            var showAomMappingRuleResponse = JsonUtils.DeSerializeNull<ShowAomMappingRuleResponse>(response);
            showAomMappingRuleResponse.Body = JsonUtils.DeSerializeList<AomMappingRuleResp>(response);
            return showAomMappingRuleResponse;
        }

        public SyncInvoker<ShowAomMappingRuleResponse> ShowAomMappingRuleInvoker(ShowAomMappingRuleRequest showAomMappingRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id", showAomMappingRuleRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/aom-mapping/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAomMappingRuleRequest);
            return new SyncInvoker<ShowAomMappingRuleResponse>(this, "GET", request, response =>
            {
                var showAomMappingRuleResponse = JsonUtils.DeSerializeNull<ShowAomMappingRuleResponse>(response);
                showAomMappingRuleResponse.Body = JsonUtils.DeSerializeList<AomMappingRuleResp>(response);
                return showAomMappingRuleResponse;
            });
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/aom-mapping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAomMappingRulesRequest);
            var response = DoHttpRequestSync("GET", request);
            var showAomMappingRulesResponse = JsonUtils.DeSerializeNull<ShowAomMappingRulesResponse>(response);
            showAomMappingRulesResponse.Body = JsonUtils.DeSerializeList<AomMappingRuleResp>(response);
            return showAomMappingRulesResponse;
        }

        public SyncInvoker<ShowAomMappingRulesResponse> ShowAomMappingRulesInvoker(ShowAomMappingRulesRequest showAomMappingRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/aom-mapping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAomMappingRulesRequest);
            return new SyncInvoker<ShowAomMappingRulesResponse>(this, "GET", request, response =>
            {
                var showAomMappingRulesResponse = JsonUtils.DeSerializeNull<ShowAomMappingRulesResponse>(response);
                showAomMappingRulesResponse.Body = JsonUtils.DeSerializeList<AomMappingRuleResp>(response);
                return showAomMappingRulesResponse;
            });
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/aom-mapping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAomMappingRulesRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAomMappingRulesResponse>(response);
        }

        public SyncInvoker<UpdateAomMappingRulesResponse> UpdateAomMappingRulesInvoker(UpdateAomMappingRulesRequest updateAomMappingRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/aom-mapping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAomMappingRulesRequest);
            return new SyncInvoker<UpdateAomMappingRulesResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAomMappingRulesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/sql-alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSqlAlarmRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateSqlAlarmRuleResponse>(response);
        }

        public SyncInvoker<CreateSqlAlarmRuleResponse> CreateSqlAlarmRuleInvoker(CreateSqlAlarmRuleRequest createSqlAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/sql-alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSqlAlarmRuleRequest);
            return new SyncInvoker<CreateSqlAlarmRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSqlAlarmRuleResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("sql_alarm_rule_id", deleteSqlAlarmRuleRequest.SqlAlarmRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/sql-alarm-rule/{sql_alarm_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSqlAlarmRuleRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSqlAlarmRuleResponse>(response);
        }

        public SyncInvoker<DeleteSqlAlarmRuleResponse> DeleteSqlAlarmRuleInvoker(DeleteSqlAlarmRuleRequest deleteSqlAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("sql_alarm_rule_id", deleteSqlAlarmRuleRequest.SqlAlarmRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/sql-alarm-rule/{sql_alarm_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSqlAlarmRuleRequest);
            return new SyncInvoker<DeleteSqlAlarmRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSqlAlarmRuleResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/sql-alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSqlAlarmRulesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSqlAlarmRulesResponse>(response);
        }

        public SyncInvoker<ListSqlAlarmRulesResponse> ListSqlAlarmRulesInvoker(ListSqlAlarmRulesRequest listSqlAlarmRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/sql-alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSqlAlarmRulesRequest);
            return new SyncInvoker<ListSqlAlarmRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSqlAlarmRulesResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAlarmRuleStatusRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateAlarmRuleStatusResponse>(response);
        }

        public SyncInvoker<UpdateAlarmRuleStatusResponse> UpdateAlarmRuleStatusInvoker(UpdateAlarmRuleStatusRequest updateAlarmRuleStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAlarmRuleStatusRequest);
            return new SyncInvoker<UpdateAlarmRuleStatusResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateAlarmRuleStatusResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/sql-alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSqlAlarmRuleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSqlAlarmRuleResponse>(response);
        }

        public SyncInvoker<UpdateSqlAlarmRuleResponse> UpdateSqlAlarmRuleInvoker(UpdateSqlAlarmRuleRequest updateSqlAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/sql-alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSqlAlarmRuleRequest);
            return new SyncInvoker<UpdateSqlAlarmRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSqlAlarmRuleResponse>);
        }
        
    }
}