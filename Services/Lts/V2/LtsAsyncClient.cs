using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Lts.V2.Model;

namespace HuaweiCloud.SDK.Lts.V2
{
    public partial class LtsAsyncClient : Client
    {
        public static ClientBuilder<LtsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<LtsAsyncClient>();
        }

        
        /// <summary>
        /// 创建日志接入
        ///
        /// 创建日志接入
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAccessConfigResponse> CreateAccessConfigAsync(CreateAccessConfigRequest createAccessConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/access-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAccessConfigRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAccessConfigResponse>(response);
        }

        public AsyncInvoker<CreateAccessConfigResponse> CreateAccessConfigAsyncInvoker(CreateAccessConfigRequest createAccessConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/access-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAccessConfigRequest);
            return new AsyncInvoker<CreateAccessConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAccessConfigResponse>);
        }
        
        /// <summary>
        /// 创建仪表盘
        ///
        /// 创建仪表盘
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDashBoardResponse> CreateDashBoardAsync(CreateDashBoardRequest createDashBoardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboard", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDashBoardRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDashBoardResponse>(response);
        }

        public AsyncInvoker<CreateDashBoardResponse> CreateDashBoardAsyncInvoker(CreateDashBoardRequest createDashBoardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboard", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDashBoardRequest);
            return new AsyncInvoker<CreateDashBoardResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDashBoardResponse>);
        }
        
        /// <summary>
        /// 创建仪表盘分组
        ///
        /// 创建仪表盘分组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDashboardGroupResponse> CreateDashboardGroupAsync(CreateDashboardGroupRequest createDashboardGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/dashboard-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDashboardGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDashboardGroupResponse>(response);
        }

        public AsyncInvoker<CreateDashboardGroupResponse> CreateDashboardGroupAsyncInvoker(CreateDashboardGroupRequest createDashboardGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/dashboard-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDashboardGroupRequest);
            return new AsyncInvoker<CreateDashboardGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDashboardGroupResponse>);
        }
        
        /// <summary>
        /// 创建主机组
        ///
        /// 创建主机组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateHostGroupResponse> CreateHostGroupAsync(CreateHostGroupRequest createHostGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/host-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createHostGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateHostGroupResponse>(response);
        }

        public AsyncInvoker<CreateHostGroupResponse> CreateHostGroupAsyncInvoker(CreateHostGroupRequest createHostGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/host-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createHostGroupRequest);
            return new AsyncInvoker<CreateHostGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateHostGroupResponse>);
        }
        
        /// <summary>
        /// 创建关键词告警规则
        ///
        /// 该接口用于创建关键词告警，目前每个帐户最多可以创建共200个关键词告警与SQL告警。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateKeywordsAlarmRuleResponse> CreateKeywordsAlarmRuleAsync(CreateKeywordsAlarmRuleRequest createKeywordsAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/keywords-alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createKeywordsAlarmRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateKeywordsAlarmRuleResponse>(response);
        }

        public AsyncInvoker<CreateKeywordsAlarmRuleResponse> CreateKeywordsAlarmRuleAsyncInvoker(CreateKeywordsAlarmRuleRequest createKeywordsAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/keywords-alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createKeywordsAlarmRuleRequest);
            return new AsyncInvoker<CreateKeywordsAlarmRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateKeywordsAlarmRuleResponse>);
        }
        
        /// <summary>
        /// 创建日志转储（旧版）
        ///
        /// 该接口用于将指定的一个或多个日志流的日志转储到OBS服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateLogDumpObsResponse> CreateLogDumpObsAsync(CreateLogDumpObsRequest createLogDumpObsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/log-dump/obs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLogDumpObsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateLogDumpObsResponse>(response);
        }

        public AsyncInvoker<CreateLogDumpObsResponse> CreateLogDumpObsAsyncInvoker(CreateLogDumpObsRequest createLogDumpObsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/log-dump/obs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLogDumpObsRequest);
            return new AsyncInvoker<CreateLogDumpObsResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateLogDumpObsResponse>);
        }
        
        /// <summary>
        /// 创建日志组
        ///
        /// 该接口用于创建一个日志组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateLogGroupResponse> CreateLogGroupAsync(CreateLogGroupRequest createLogGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLogGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateLogGroupResponse>(response);
        }

        public AsyncInvoker<CreateLogGroupResponse> CreateLogGroupAsyncInvoker(CreateLogGroupRequest createLogGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLogGroupRequest);
            return new AsyncInvoker<CreateLogGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateLogGroupResponse>);
        }
        
        /// <summary>
        /// 创建日志流
        ///
        /// 该接口用于创建某个指定日志组下的日志流
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateLogStreamResponse> CreateLogStreamAsync(CreateLogStreamRequest createLogStreamRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id", createLogStreamRequest.LogGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}/streams", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLogStreamRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateLogStreamResponse>(response);
        }

        public AsyncInvoker<CreateLogStreamResponse> CreateLogStreamAsyncInvoker(CreateLogStreamRequest createLogStreamRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id", createLogStreamRequest.LogGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}/streams", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLogStreamRequest);
            return new AsyncInvoker<CreateLogStreamResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateLogStreamResponse>);
        }
        
        /// <summary>
        /// 创建消息模板
        ///
        /// 该接口用于创建通知模板，目前每个帐户最多可以创建共100个通知模板，创建后名称不可修改。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateNotificationTemplateResponse> CreateNotificationTemplateAsync(CreateNotificationTemplateRequest createNotificationTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", createNotificationTemplateRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/events/notification/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createNotificationTemplateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateNotificationTemplateResponse>(response);
        }

        public AsyncInvoker<CreateNotificationTemplateResponse> CreateNotificationTemplateAsyncInvoker(CreateNotificationTemplateRequest createNotificationTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", createNotificationTemplateRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/events/notification/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createNotificationTemplateRequest);
            return new AsyncInvoker<CreateNotificationTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateNotificationTemplateResponse>);
        }
        
        /// <summary>
        /// 添加快速查询
        ///
        /// 添加快速查询
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSearchCriteriasResponse> CreateSearchCriteriasAsync(CreateSearchCriteriasRequest createSearchCriteriasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", createSearchCriteriasRequest.GroupId.ToString());
            urlParam.Add("topic_id", createSearchCriteriasRequest.TopicId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/groups/{group_id}/topics/{topic_id}/search-criterias", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSearchCriteriasRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateSearchCriteriasResponse>(response);
        }

        public AsyncInvoker<CreateSearchCriteriasResponse> CreateSearchCriteriasAsyncInvoker(CreateSearchCriteriasRequest createSearchCriteriasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", createSearchCriteriasRequest.GroupId.ToString());
            urlParam.Add("topic_id", createSearchCriteriasRequest.TopicId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/groups/{group_id}/topics/{topic_id}/search-criterias", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSearchCriteriasRequest);
            return new AsyncInvoker<CreateSearchCriteriasResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSearchCriteriasResponse>);
        }
        
        /// <summary>
        /// 通过结构化模板创建结构化配置（新）
        ///
        /// 该接口通过结构化模板创建结构化配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateStructConfigResponse> CreateStructConfigAsync(CreateStructConfigRequest createStructConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/struct/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createStructConfigRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateStructConfigResponse>(response);
        }

        public AsyncInvoker<CreateStructConfigResponse> CreateStructConfigAsyncInvoker(CreateStructConfigRequest createStructConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/struct/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createStructConfigRequest);
            return new AsyncInvoker<CreateStructConfigResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateStructConfigResponse>);
        }
        
        /// <summary>
        /// 创建结构化配置
        ///
        /// 该接口用于创建指定日志流下的结构化配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateStructTemplateResponse> CreateStructTemplateAsync(CreateStructTemplateRequest createStructTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/struct/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createStructTemplateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateStructTemplateResponse>(response);
        }

        public AsyncInvoker<CreateStructTemplateResponse> CreateStructTemplateAsyncInvoker(CreateStructTemplateRequest createStructTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/struct/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createStructTemplateRequest);
            return new AsyncInvoker<CreateStructTemplateResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateStructTemplateResponse>);
        }
        
        /// <summary>
        /// 
        ///
        /// 添加标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest createTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", createTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id", createTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/{resource_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateTagsResponse>(response);
        }

        public AsyncInvoker<CreateTagsResponse> CreateTagsAsyncInvoker(CreateTagsRequest createTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", createTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id", createTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/{resource_type}/{resource_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTagsRequest);
            return new AsyncInvoker<CreateTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateTagsResponse>);
        }
        
        /// <summary>
        /// 创建日志转储（新版）
        ///
        /// 该接口用于创建OBS转储，DIS转储，DMS转储。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTransferResponse> CreateTransferAsync(CreateTransferRequest createTransferRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/transfers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTransferRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateTransferResponse>(response);
        }

        public AsyncInvoker<CreateTransferResponse> CreateTransferAsyncInvoker(CreateTransferRequest createTransferRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/transfers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTransferRequest);
            return new AsyncInvoker<CreateTransferResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTransferResponse>);
        }
        
        /// <summary>
        /// 创建日志收藏
        ///
        /// 创建日志收藏
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatefavoriteResponse> CreatefavoriteAsync(CreatefavoriteRequest createfavoriteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/lts/favorite", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createfavoriteRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatefavoriteResponse>(response);
        }

        public AsyncInvoker<CreatefavoriteResponse> CreatefavoriteAsyncInvoker(CreatefavoriteRequest createfavoriteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/lts/favorite", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createfavoriteRequest);
            return new AsyncInvoker<CreatefavoriteResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatefavoriteResponse>);
        }
        
        /// <summary>
        /// 删除日志接入
        ///
        /// 删除日志接入
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAccessConfigResponse> DeleteAccessConfigAsync(DeleteAccessConfigRequest deleteAccessConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/access-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteAccessConfigRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAccessConfigResponse>(response);
        }

        public AsyncInvoker<DeleteAccessConfigResponse> DeleteAccessConfigAsyncInvoker(DeleteAccessConfigRequest deleteAccessConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/access-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteAccessConfigRequest);
            return new AsyncInvoker<DeleteAccessConfigResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAccessConfigResponse>);
        }
        
        /// <summary>
        /// 删除活动告警
        ///
        /// 该接口用于删除活动告警
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteActiveAlarmsResponse> DeleteActiveAlarmsAsync(DeleteActiveAlarmsRequest deleteActiveAlarmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", deleteActiveAlarmsRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/alarms/sql-alarm/clear", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteActiveAlarmsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteActiveAlarmsResponse>(response);
        }

        public AsyncInvoker<DeleteActiveAlarmsResponse> DeleteActiveAlarmsAsyncInvoker(DeleteActiveAlarmsRequest deleteActiveAlarmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", deleteActiveAlarmsRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/alarms/sql-alarm/clear", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteActiveAlarmsRequest);
            return new AsyncInvoker<DeleteActiveAlarmsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteActiveAlarmsResponse>);
        }
        
        /// <summary>
        /// 删除仪表盘
        ///
        /// 删除仪表盘
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDashboardResponse> DeleteDashboardAsync(DeleteDashboardRequest deleteDashboardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboard", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDashboardRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDashboardResponse>(response);
        }

        public AsyncInvoker<DeleteDashboardResponse> DeleteDashboardAsyncInvoker(DeleteDashboardRequest deleteDashboardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/dashboard", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDashboardRequest);
            return new AsyncInvoker<DeleteDashboardResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDashboardResponse>);
        }
        
        /// <summary>
        /// 删除主机组
        ///
        /// 删除主机组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteHostGroupResponse> DeleteHostGroupAsync(DeleteHostGroupRequest deleteHostGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/host-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteHostGroupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteHostGroupResponse>(response);
        }

        public AsyncInvoker<DeleteHostGroupResponse> DeleteHostGroupAsyncInvoker(DeleteHostGroupRequest deleteHostGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/host-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteHostGroupRequest);
            return new AsyncInvoker<DeleteHostGroupResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteHostGroupResponse>);
        }
        
        /// <summary>
        /// 删除关键词告警规则
        ///
        /// 该接口用于删除关键词告警。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteKeywordsAlarmRuleResponse> DeleteKeywordsAlarmRuleAsync(DeleteKeywordsAlarmRuleRequest deleteKeywordsAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("keywords_alarm_rule_id", deleteKeywordsAlarmRuleRequest.KeywordsAlarmRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/keywords-alarm-rule/{keywords_alarm_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKeywordsAlarmRuleRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteKeywordsAlarmRuleResponse>(response);
        }

        public AsyncInvoker<DeleteKeywordsAlarmRuleResponse> DeleteKeywordsAlarmRuleAsyncInvoker(DeleteKeywordsAlarmRuleRequest deleteKeywordsAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("keywords_alarm_rule_id", deleteKeywordsAlarmRuleRequest.KeywordsAlarmRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/keywords-alarm-rule/{keywords_alarm_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKeywordsAlarmRuleRequest);
            return new AsyncInvoker<DeleteKeywordsAlarmRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteKeywordsAlarmRuleResponse>);
        }
        
        /// <summary>
        /// 删除日志组
        ///
        /// 该接口用于删除指定日志组。当日志组中的日志流配置了日志转储，需要取消日志转储后才可删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteLogGroupResponse> DeleteLogGroupAsync(DeleteLogGroupRequest deleteLogGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id", deleteLogGroupRequest.LogGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLogGroupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteLogGroupResponse>(response);
        }

        public AsyncInvoker<DeleteLogGroupResponse> DeleteLogGroupAsyncInvoker(DeleteLogGroupRequest deleteLogGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id", deleteLogGroupRequest.LogGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLogGroupRequest);
            return new AsyncInvoker<DeleteLogGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteLogGroupResponse>);
        }
        
        /// <summary>
        /// 删除日志流
        ///
        /// 该接口用于删除指定日志组下的指定日志流。当该日志流配置了日志转储，需要取消日志转储后才可删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteLogStreamResponse> DeleteLogStreamAsync(DeleteLogStreamRequest deleteLogStreamRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id", deleteLogStreamRequest.LogGroupId.ToString());
            urlParam.Add("log_stream_id", deleteLogStreamRequest.LogStreamId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}/streams/{log_stream_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLogStreamRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteLogStreamResponse>(response);
        }

        public AsyncInvoker<DeleteLogStreamResponse> DeleteLogStreamAsyncInvoker(DeleteLogStreamRequest deleteLogStreamRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id", deleteLogStreamRequest.LogGroupId.ToString());
            urlParam.Add("log_stream_id", deleteLogStreamRequest.LogStreamId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}/streams/{log_stream_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLogStreamRequest);
            return new AsyncInvoker<DeleteLogStreamResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteLogStreamResponse>);
        }
        
        /// <summary>
        /// 删除消息模板
        ///
        /// 该接口用于删除通知模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteNotificationTemplateResponse> DeleteNotificationTemplateAsync(DeleteNotificationTemplateRequest deleteNotificationTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", deleteNotificationTemplateRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/events/notification/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteNotificationTemplateRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteNotificationTemplateResponse>(response);
        }

        public AsyncInvoker<DeleteNotificationTemplateResponse> DeleteNotificationTemplateAsyncInvoker(DeleteNotificationTemplateRequest deleteNotificationTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", deleteNotificationTemplateRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/events/notification/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteNotificationTemplateRequest);
            return new AsyncInvoker<DeleteNotificationTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteNotificationTemplateResponse>);
        }
        
        /// <summary>
        /// 删除快速查询
        ///
        /// 删除快速查询
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSearchCriteriasResponse> DeleteSearchCriteriasAsync(DeleteSearchCriteriasRequest deleteSearchCriteriasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", deleteSearchCriteriasRequest.GroupId.ToString());
            urlParam.Add("topic_id", deleteSearchCriteriasRequest.TopicId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/groups/{group_id}/topics/{topic_id}/search-criterias", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteSearchCriteriasRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSearchCriteriasResponse>(response);
        }

        public AsyncInvoker<DeleteSearchCriteriasResponse> DeleteSearchCriteriasAsyncInvoker(DeleteSearchCriteriasRequest deleteSearchCriteriasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", deleteSearchCriteriasRequest.GroupId.ToString());
            urlParam.Add("topic_id", deleteSearchCriteriasRequest.TopicId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/groups/{group_id}/topics/{topic_id}/search-criterias", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteSearchCriteriasRequest);
            return new AsyncInvoker<DeleteSearchCriteriasResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSearchCriteriasResponse>);
        }
        
        /// <summary>
        /// 删除结构化配置
        ///
        /// 该接口用于删除指定日志流下的结构化配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteStructTemplateResponse> DeleteStructTemplateAsync(DeleteStructTemplateRequest deleteStructTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/struct/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteStructTemplateRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteStructTemplateResponse>(response);
        }

        public AsyncInvoker<DeleteStructTemplateResponse> DeleteStructTemplateAsyncInvoker(DeleteStructTemplateRequest deleteStructTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/struct/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteStructTemplateRequest);
            return new AsyncInvoker<DeleteStructTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteStructTemplateResponse>);
        }
        
        /// <summary>
        /// 删除日志转储
        ///
        /// 该接口用于删除OBS转储，DIS转储，DMS转储。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTransferResponse> DeleteTransferAsync(DeleteTransferRequest deleteTransferRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/transfers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTransferRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteTransferResponse>(response);
        }

        public AsyncInvoker<DeleteTransferResponse> DeleteTransferAsyncInvoker(DeleteTransferRequest deleteTransferRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/transfers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTransferRequest);
            return new AsyncInvoker<DeleteTransferResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteTransferResponse>);
        }
        
        /// <summary>
        /// 取消收藏
        ///
        /// 取消收藏
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletefavoriteResponse> DeletefavoriteAsync(DeletefavoriteRequest deletefavoriteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("fav_res_id", deletefavoriteRequest.FavResId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/lts/favorite/{fav_res_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletefavoriteRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletefavoriteResponse>(response);
        }

        public AsyncInvoker<DeletefavoriteResponse> DeletefavoriteAsyncInvoker(DeletefavoriteRequest deletefavoriteRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("fav_res_id", deletefavoriteRequest.FavResId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/lts/favorite/{fav_res_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletefavoriteRequest);
            return new AsyncInvoker<DeletefavoriteResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletefavoriteResponse>);
        }
        
        /// <summary>
        /// 关闭超额采集开关
        ///
        /// 该接口用于将超额采集日志功能关闭。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisableLogCollectionResponse> DisableLogCollectionAsync(DisableLogCollectionRequest disableLogCollectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/collection/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableLogCollectionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DisableLogCollectionResponse>(response);
        }

        public AsyncInvoker<DisableLogCollectionResponse> DisableLogCollectionAsyncInvoker(DisableLogCollectionRequest disableLogCollectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/collection/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableLogCollectionRequest);
            return new AsyncInvoker<DisableLogCollectionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DisableLogCollectionResponse>);
        }
        
        /// <summary>
        /// 打开超额采集开关
        ///
        /// 该接口用于将超额采集日志功能打开。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EnableLogCollectionResponse> EnableLogCollectionAsync(EnableLogCollectionRequest enableLogCollectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/collection/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableLogCollectionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<EnableLogCollectionResponse>(response);
        }

        public AsyncInvoker<EnableLogCollectionResponse> EnableLogCollectionAsyncInvoker(EnableLogCollectionRequest enableLogCollectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/collection/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableLogCollectionRequest);
            return new AsyncInvoker<EnableLogCollectionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<EnableLogCollectionResponse>);
        }
        
        /// <summary>
        /// 查询日志接入
        ///
        /// 查询日志接入列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAccessConfigResponse> ListAccessConfigAsync(ListAccessConfigRequest listAccessConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/access-config-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAccessConfigRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListAccessConfigResponse>(response);
        }

        public AsyncInvoker<ListAccessConfigResponse> ListAccessConfigAsyncInvoker(ListAccessConfigRequest listAccessConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/access-config-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listAccessConfigRequest);
            return new AsyncInvoker<ListAccessConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAccessConfigResponse>);
        }
        
        /// <summary>
        /// 查询活动或历史告警列表
        ///
        /// 该接口用于查询告警列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListActiveOrHistoryAlarmsResponse> ListActiveOrHistoryAlarmsAsync(ListActiveOrHistoryAlarmsRequest listActiveOrHistoryAlarmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", listActiveOrHistoryAlarmsRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/alarms/sql-alarm/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listActiveOrHistoryAlarmsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListActiveOrHistoryAlarmsResponse>(response);
        }

        public AsyncInvoker<ListActiveOrHistoryAlarmsResponse> ListActiveOrHistoryAlarmsAsyncInvoker(ListActiveOrHistoryAlarmsRequest listActiveOrHistoryAlarmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", listActiveOrHistoryAlarmsRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/alarms/sql-alarm/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listActiveOrHistoryAlarmsRequest);
            return new AsyncInvoker<ListActiveOrHistoryAlarmsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListActiveOrHistoryAlarmsResponse>);
        }
        
        /// <summary>
        /// 查询结构化模板简略列表
        ///
        /// 该接口用于查询结构化模板简略列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBreifStructTemplateResponse> ListBreifStructTemplateAsync(ListBreifStructTemplateRequest listBreifStructTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/struct/customtemplate/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBreifStructTemplateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListBreifStructTemplateResponse>(response);
        }

        public AsyncInvoker<ListBreifStructTemplateResponse> ListBreifStructTemplateAsyncInvoker(ListBreifStructTemplateRequest listBreifStructTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/struct/customtemplate/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBreifStructTemplateRequest);
            return new AsyncInvoker<ListBreifStructTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBreifStructTemplateResponse>);
        }
        
        /// <summary>
        /// 查询日志流图表
        ///
        /// 该接口用于查询日志流图表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListChartsResponse> ListChartsAsync(ListChartsRequest listChartsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id", listChartsRequest.LogGroupId.ToString());
            urlParam.Add("log_stream_id", listChartsRequest.LogStreamId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}/streams/{log_stream_id}/charts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listChartsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListChartsResponse>(response);
        }

        public AsyncInvoker<ListChartsResponse> ListChartsAsyncInvoker(ListChartsRequest listChartsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id", listChartsRequest.LogGroupId.ToString());
            urlParam.Add("log_stream_id", listChartsRequest.LogStreamId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}/streams/{log_stream_id}/charts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listChartsRequest);
            return new AsyncInvoker<ListChartsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListChartsResponse>);
        }
        
        /// <summary>
        /// 获取快速查询
        ///
        /// 获取快速查询
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCriteriasResponse> ListCriteriasAsync(ListCriteriasRequest listCriteriasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", listCriteriasRequest.GroupId.ToString());
            urlParam.Add("topic_id", listCriteriasRequest.TopicId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/groups/{group_id}/topics/{topic_id}/search-criterias", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCriteriasRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCriteriasResponse>(response);
        }

        public AsyncInvoker<ListCriteriasResponse> ListCriteriasAsyncInvoker(ListCriteriasRequest listCriteriasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", listCriteriasRequest.GroupId.ToString());
            urlParam.Add("topic_id", listCriteriasRequest.TopicId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/groups/{group_id}/topics/{topic_id}/search-criterias", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCriteriasRequest);
            return new AsyncInvoker<ListCriteriasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCriteriasResponse>);
        }
        
        /// <summary>
        /// 查询用户历史sql
        ///
        /// 查询用户历史sql
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListHistorySqlResponse> ListHistorySqlAsync(ListHistorySqlRequest listHistorySqlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/history-sql", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHistorySqlRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListHistorySqlResponse>(response);
        }

        public AsyncInvoker<ListHistorySqlResponse> ListHistorySqlAsyncInvoker(ListHistorySqlRequest listHistorySqlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/history-sql", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHistorySqlRequest);
            return new AsyncInvoker<ListHistorySqlResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHistorySqlResponse>);
        }
        
        /// <summary>
        /// 查询主机信息
        ///
        /// 查询主机列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListHostResponse> ListHostAsync(ListHostRequest listHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/host-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listHostRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListHostResponse>(response);
        }

        public AsyncInvoker<ListHostResponse> ListHostAsyncInvoker(ListHostRequest listHostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/host-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listHostRequest);
            return new AsyncInvoker<ListHostResponse>(this, "POST", request, JsonUtils.DeSerialize<ListHostResponse>);
        }
        
        /// <summary>
        /// 查询主机组
        ///
        /// 查询主机组列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListHostGroupResponse> ListHostGroupAsync(ListHostGroupRequest listHostGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/host-group-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listHostGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListHostGroupResponse>(response);
        }

        public AsyncInvoker<ListHostGroupResponse> ListHostGroupAsyncInvoker(ListHostGroupRequest listHostGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/host-group-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listHostGroupRequest);
            return new AsyncInvoker<ListHostGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<ListHostGroupResponse>);
        }
        
        /// <summary>
        /// 查询关键词告警规则
        ///
        /// 该接口用于查询关键词告警。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListKeywordsAlarmRulesResponse> ListKeywordsAlarmRulesAsync(ListKeywordsAlarmRulesRequest listKeywordsAlarmRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/keywords-alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeywordsAlarmRulesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListKeywordsAlarmRulesResponse>(response);
        }

        public AsyncInvoker<ListKeywordsAlarmRulesResponse> ListKeywordsAlarmRulesAsyncInvoker(ListKeywordsAlarmRulesRequest listKeywordsAlarmRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/keywords-alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeywordsAlarmRulesRequest);
            return new AsyncInvoker<ListKeywordsAlarmRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListKeywordsAlarmRulesResponse>);
        }
        
        /// <summary>
        /// 查询账号下所有日志组
        ///
        /// 该接口用于查询账号下所有日志组。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLogGroupsResponse> ListLogGroupsAsync(ListLogGroupsRequest listLogGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogGroupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListLogGroupsResponse>(response);
        }

        public AsyncInvoker<ListLogGroupsResponse> ListLogGroupsAsyncInvoker(ListLogGroupsRequest listLogGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogGroupsRequest);
            return new AsyncInvoker<ListLogGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLogGroupsResponse>);
        }
        
        /// <summary>
        /// 查询日志直方图
        ///
        /// 查询关键词搜索条数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLogHistogramResponse> ListLogHistogramAsync(ListLogHistogramRequest listLogHistogramRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/keyword-count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listLogHistogramRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListLogHistogramResponse>(response);
        }

        public AsyncInvoker<ListLogHistogramResponse> ListLogHistogramAsyncInvoker(ListLogHistogramRequest listLogHistogramRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/keyword-count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listLogHistogramRequest);
            return new AsyncInvoker<ListLogHistogramResponse>(this, "POST", request, JsonUtils.DeSerialize<ListLogHistogramResponse>);
        }
        
        /// <summary>
        /// 查询指定日志组下的所有日志流
        ///
        /// 该接口用于查询指定日志组下的所有日志流信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLogStreamResponse> ListLogStreamAsync(ListLogStreamRequest listLogStreamRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id", listLogStreamRequest.LogGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}/streams", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogStreamRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListLogStreamResponse>(response);
        }

        public AsyncInvoker<ListLogStreamResponse> ListLogStreamAsyncInvoker(ListLogStreamRequest listLogStreamRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id", listLogStreamRequest.LogGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}/streams", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogStreamRequest);
            return new AsyncInvoker<ListLogStreamResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLogStreamResponse>);
        }
        
        /// <summary>
        /// 查询日志流信息
        ///
        /// 该接口用于查询LTS日志流信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLogStreamsResponse> ListLogStreamsAsync(ListLogStreamsRequest listLogStreamsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/log-streams", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogStreamsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListLogStreamsResponse>(response);
        }

        public AsyncInvoker<ListLogStreamsResponse> ListLogStreamsAsyncInvoker(ListLogStreamsRequest listLogStreamsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/log-streams", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogStreamsRequest);
            return new AsyncInvoker<ListLogStreamsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLogStreamsResponse>);
        }
        
        /// <summary>
        /// 查询日志
        ///
        /// 该接口用于查询指定日志流下的日志内容。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLogsResponse> ListLogsAsync(ListLogsRequest listLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id", listLogsRequest.LogGroupId.ToString());
            urlParam.Add("log_stream_id", listLogsRequest.LogStreamId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}/streams/{log_stream_id}/content/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListLogsResponse>(response);
        }

        public AsyncInvoker<ListLogsResponse> ListLogsAsyncInvoker(ListLogsRequest listLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id", listLogsRequest.LogGroupId.ToString());
            urlParam.Add("log_stream_id", listLogsRequest.LogStreamId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}/streams/{log_stream_id}/content/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogsRequest);
            return new AsyncInvoker<ListLogsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListLogsResponse>);
        }
        
        /// <summary>
        /// 预览消息模板邮件格式
        ///
        /// 该接口用于预览通知模板邮件格式
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNotificationTemplateResponse> ListNotificationTemplateAsync(ListNotificationTemplateRequest listNotificationTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", listNotificationTemplateRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/events/notification/templates/view", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listNotificationTemplateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListNotificationTemplateResponse>(response);
        }

        public AsyncInvoker<ListNotificationTemplateResponse> ListNotificationTemplateAsyncInvoker(ListNotificationTemplateRequest listNotificationTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", listNotificationTemplateRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/events/notification/templates/view", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listNotificationTemplateRequest);
            return new AsyncInvoker<ListNotificationTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<ListNotificationTemplateResponse>);
        }
        
        /// <summary>
        /// 查询消息模板
        ///
        /// 该接口用于查询通知模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNotificationTemplatesResponse> ListNotificationTemplatesAsync(ListNotificationTemplatesRequest listNotificationTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", listNotificationTemplatesRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/events/notification/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotificationTemplatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListNotificationTemplatesResponse>(response);
        }

        public AsyncInvoker<ListNotificationTemplatesResponse> ListNotificationTemplatesAsyncInvoker(ListNotificationTemplatesRequest listNotificationTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", listNotificationTemplatesRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/events/notification/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotificationTemplatesRequest);
            return new AsyncInvoker<ListNotificationTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNotificationTemplatesResponse>);
        }
        
        /// <summary>
        /// 查询SMN主题
        ///
        /// 该接口用于查询SMN主题
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNotificationTopicsResponse> ListNotificationTopicsAsync(ListNotificationTopicsRequest listNotificationTopicsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/notifications/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotificationTopicsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListNotificationTopicsResponse>(response);
        }

        public AsyncInvoker<ListNotificationTopicsResponse> ListNotificationTopicsAsyncInvoker(ListNotificationTopicsRequest listNotificationTopicsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/notifications/topics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNotificationTopicsRequest);
            return new AsyncInvoker<ListNotificationTopicsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNotificationTopicsResponse>);
        }
        
        /// <summary>
        /// 查询日志组下所有快速查询
        ///
        /// 查询日志组下所有快速查询
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListQueryAllSearchCriteriasResponse> ListQueryAllSearchCriteriasAsync(ListQueryAllSearchCriteriasRequest listQueryAllSearchCriteriasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", listQueryAllSearchCriteriasRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/lts/groups/{group_id}/search-criterias", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQueryAllSearchCriteriasRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListQueryAllSearchCriteriasResponse>(response);
        }

        public AsyncInvoker<ListQueryAllSearchCriteriasResponse> ListQueryAllSearchCriteriasAsyncInvoker(ListQueryAllSearchCriteriasRequest listQueryAllSearchCriteriasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", listQueryAllSearchCriteriasRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/{project_id}/lts/groups/{group_id}/search-criterias", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQueryAllSearchCriteriasRequest);
            return new AsyncInvoker<ListQueryAllSearchCriteriasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListQueryAllSearchCriteriasResponse>);
        }
        
        /// <summary>
        /// 查询结构化日志
        ///
        /// 该接口用于查询指定日志流下的结构化日志内容。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListQueryStructuredLogsResponse> ListQueryStructuredLogsAsync(ListQueryStructuredLogsRequest listQueryStructuredLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id", listQueryStructuredLogsRequest.LogGroupId.ToString());
            urlParam.Add("log_stream_id", listQueryStructuredLogsRequest.LogStreamId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}/streams/{log_stream_id}/struct-content/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQueryStructuredLogsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListQueryStructuredLogsResponse>(response);
        }

        public AsyncInvoker<ListQueryStructuredLogsResponse> ListQueryStructuredLogsAsyncInvoker(ListQueryStructuredLogsRequest listQueryStructuredLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id", listQueryStructuredLogsRequest.LogGroupId.ToString());
            urlParam.Add("log_stream_id", listQueryStructuredLogsRequest.LogStreamId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}/streams/{log_stream_id}/struct-content/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQueryStructuredLogsRequest);
            return new AsyncInvoker<ListQueryStructuredLogsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListQueryStructuredLogsResponse>);
        }
        
        /// <summary>
        /// 查询结构化模板
        ///
        /// 该接口用于查询结构化模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListStructTemplateResponse> ListStructTemplateAsync(ListStructTemplateRequest listStructTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/struct/customtemplate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStructTemplateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListStructTemplateResponse>(response);
        }

        public AsyncInvoker<ListStructTemplateResponse> ListStructTemplateAsyncInvoker(ListStructTemplateRequest listStructTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/struct/customtemplate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStructTemplateRequest);
            return new AsyncInvoker<ListStructTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStructTemplateResponse>);
        }
        
        /// <summary>
        /// 查询结构化日志（新版）
        ///
        /// 该接口用于查询指定日志流下的结构化日志内容（新版）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListStructuredLogsWithTimeRangeResponse> ListStructuredLogsWithTimeRangeAsync(ListStructuredLogsWithTimeRangeRequest listStructuredLogsWithTimeRangeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_stream_id", listStructuredLogsWithTimeRangeRequest.LogStreamId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/streams/{log_stream_id}/struct-content/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStructuredLogsWithTimeRangeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListStructuredLogsWithTimeRangeResponse>(response);
        }

        public AsyncInvoker<ListStructuredLogsWithTimeRangeResponse> ListStructuredLogsWithTimeRangeAsyncInvoker(ListStructuredLogsWithTimeRangeRequest listStructuredLogsWithTimeRangeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_stream_id", listStructuredLogsWithTimeRangeRequest.LogStreamId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/streams/{log_stream_id}/struct-content/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStructuredLogsWithTimeRangeRequest);
            return new AsyncInvoker<ListStructuredLogsWithTimeRangeResponse>(this, "POST", request, JsonUtils.DeSerialize<ListStructuredLogsWithTimeRangeResponse>);
        }
        
        /// <summary>
        /// 按时间段统计查询资源
        ///
        /// 按时间段统计查询资源
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTimeLineTrafficStatisticsResponse> ListTimeLineTrafficStatisticsAsync(ListTimeLineTrafficStatisticsRequest listTimeLineTrafficStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/timeline-traffic-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listTimeLineTrafficStatisticsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListTimeLineTrafficStatisticsResponse>(response);
        }

        public AsyncInvoker<ListTimeLineTrafficStatisticsResponse> ListTimeLineTrafficStatisticsAsyncInvoker(ListTimeLineTrafficStatisticsRequest listTimeLineTrafficStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/timeline-traffic-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listTimeLineTrafficStatisticsRequest);
            return new AsyncInvoker<ListTimeLineTrafficStatisticsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListTimeLineTrafficStatisticsResponse>);
        }
        
        /// <summary>
        /// 统计top n的日志组或日志流流量
        ///
        /// 统计top n的日志组或日志流流量
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTopnTrafficStatisticsResponse> ListTopnTrafficStatisticsAsync(ListTopnTrafficStatisticsRequest listTopnTrafficStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/topn-traffic-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listTopnTrafficStatisticsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListTopnTrafficStatisticsResponse>(response);
        }

        public AsyncInvoker<ListTopnTrafficStatisticsResponse> ListTopnTrafficStatisticsAsyncInvoker(ListTopnTrafficStatisticsRequest listTopnTrafficStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/topn-traffic-statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listTopnTrafficStatisticsRequest);
            return new AsyncInvoker<ListTopnTrafficStatisticsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListTopnTrafficStatisticsResponse>);
        }
        
        /// <summary>
        /// 查询日志转储
        ///
        /// 该接口用于查询OBS转储，DIS转储，DMS转储配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTransfersResponse> ListTransfersAsync(ListTransfersRequest listTransfersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/transfers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTransfersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTransfersResponse>(response);
        }

        public AsyncInvoker<ListTransfersResponse> ListTransfersAsyncInvoker(ListTransfersRequest listTransfersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/transfers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTransfersRequest);
            return new AsyncInvoker<ListTransfersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTransfersResponse>);
        }
        
        /// <summary>
        /// 注册DMS kafka实例
        ///
        /// 该接口用于注册DMS kafka实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RegisterDmsKafkaInstanceResponse> RegisterDmsKafkaInstanceAsync(RegisterDmsKafkaInstanceRequest registerDmsKafkaInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/dms/kafka-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", registerDmsKafkaInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RegisterDmsKafkaInstanceResponse>(response);
        }

        public AsyncInvoker<RegisterDmsKafkaInstanceResponse> RegisterDmsKafkaInstanceAsyncInvoker(RegisterDmsKafkaInstanceRequest registerDmsKafkaInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/dms/kafka-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", registerDmsKafkaInstanceRequest);
            return new AsyncInvoker<RegisterDmsKafkaInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<RegisterDmsKafkaInstanceResponse>);
        }
        
        /// <summary>
        /// 获取日志汇聚开关
        ///
        /// 只能由管理员或者委托管理员调用    获取日志汇聚开关
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAdminConfigResponse> ShowAdminConfigAsync(ShowAdminConfigRequest showAdminConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/lts/log-converge-config/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAdminConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAdminConfigResponse>(response);
        }

        public AsyncInvoker<ShowAdminConfigResponse> ShowAdminConfigAsyncInvoker(ShowAdminConfigRequest showAdminConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/lts/log-converge-config/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAdminConfigRequest);
            return new AsyncInvoker<ShowAdminConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAdminConfigResponse>);
        }
        
        /// <summary>
        /// 获取组织成员汇聚配置
        ///
        /// 只能由组织管理员或者委托管理员调用    获取组织成员汇聚配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowLogConvergeConfigResponse> ShowLogConvergeConfigAsync(ShowLogConvergeConfigRequest showLogConvergeConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("member_account_id", showLogConvergeConfigRequest.MemberAccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/lts/log-converge-config/{member_account_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogConvergeConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowLogConvergeConfigResponse>(response);
        }

        public AsyncInvoker<ShowLogConvergeConfigResponse> ShowLogConvergeConfigAsyncInvoker(ShowLogConvergeConfigRequest showLogConvergeConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("member_account_id", showLogConvergeConfigRequest.MemberAccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/lts/log-converge-config/{member_account_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogConvergeConfigRequest);
            return new AsyncInvoker<ShowLogConvergeConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLogConvergeConfigResponse>);
        }
        
        /// <summary>
        /// 获取组织成员日志组日志流
        ///
        /// 只能由管理员或者委托管理员调用，获取组织成员日志组日志流
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMemberGroupAndStreamResponse> ShowMemberGroupAndStreamAsync(ShowMemberGroupAndStreamRequest showMemberGroupAndStreamRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("member_account_id", showMemberGroupAndStreamRequest.MemberAccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/lts/{member_account_id}/all-streams", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMemberGroupAndStreamRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowMemberGroupAndStreamResponse>(response);
        }

        public AsyncInvoker<ShowMemberGroupAndStreamResponse> ShowMemberGroupAndStreamAsyncInvoker(ShowMemberGroupAndStreamRequest showMemberGroupAndStreamRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("member_account_id", showMemberGroupAndStreamRequest.MemberAccountId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/lts/{member_account_id}/all-streams", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMemberGroupAndStreamRequest);
            return new AsyncInvoker<ShowMemberGroupAndStreamResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMemberGroupAndStreamResponse>);
        }
        
        /// <summary>
        /// 查询单个消息模板
        ///
        /// 该接口用于查询单个通知模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowNotificationTemplateResponse> ShowNotificationTemplateAsync(ShowNotificationTemplateRequest showNotificationTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showNotificationTemplateRequest.DomainId.ToString());
            urlParam.Add("template_name", showNotificationTemplateRequest.TemplateName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/events/notification/template/{template_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNotificationTemplateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowNotificationTemplateResponse>(response);
        }

        public AsyncInvoker<ShowNotificationTemplateResponse> ShowNotificationTemplateAsyncInvoker(ShowNotificationTemplateRequest showNotificationTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", showNotificationTemplateRequest.DomainId.ToString());
            urlParam.Add("template_name", showNotificationTemplateRequest.TemplateName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/events/notification/template/{template_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNotificationTemplateRequest);
            return new AsyncInvoker<ShowNotificationTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowNotificationTemplateResponse>);
        }
        
        /// <summary>
        /// 查询结构化配置
        ///
        /// 该接口用于查询指定日志流下的结构化配置内容。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowStructTemplateResponse> ShowStructTemplateAsync(ShowStructTemplateRequest showStructTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/struct/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStructTemplateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowStructTemplateResponse>(response);
        }

        public AsyncInvoker<ShowStructTemplateResponse> ShowStructTemplateAsyncInvoker(ShowStructTemplateRequest showStructTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/struct/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStructTemplateRequest);
            return new AsyncInvoker<ShowStructTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStructTemplateResponse>);
        }
        
        /// <summary>
        /// 修改日志接入
        ///
        /// 修改日志接入
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAccessConfigResponse> UpdateAccessConfigAsync(UpdateAccessConfigRequest updateAccessConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/access-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAccessConfigRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAccessConfigResponse>(response);
        }

        public AsyncInvoker<UpdateAccessConfigResponse> UpdateAccessConfigAsyncInvoker(UpdateAccessConfigRequest updateAccessConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/access-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAccessConfigRequest);
            return new AsyncInvoker<UpdateAccessConfigResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAccessConfigResponse>);
        }
        
        /// <summary>
        /// 修改主机组
        ///
        /// 修改主机组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateHostGroupResponse> UpdateHostGroupAsync(UpdateHostGroupRequest updateHostGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/host-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateHostGroupRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateHostGroupResponse>(response);
        }

        public AsyncInvoker<UpdateHostGroupResponse> UpdateHostGroupAsyncInvoker(UpdateHostGroupRequest updateHostGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/host-group", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateHostGroupRequest);
            return new AsyncInvoker<UpdateHostGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateHostGroupResponse>);
        }
        
        /// <summary>
        /// 修改关键词告警规则
        ///
        /// 该接口用于修改关键词告警。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateKeywordsAlarmRuleResponse> UpdateKeywordsAlarmRuleAsync(UpdateKeywordsAlarmRuleRequest updateKeywordsAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/keywords-alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateKeywordsAlarmRuleRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateKeywordsAlarmRuleResponse>(response);
        }

        public AsyncInvoker<UpdateKeywordsAlarmRuleResponse> UpdateKeywordsAlarmRuleAsyncInvoker(UpdateKeywordsAlarmRuleRequest updateKeywordsAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/keywords-alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateKeywordsAlarmRuleRequest);
            return new AsyncInvoker<UpdateKeywordsAlarmRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateKeywordsAlarmRuleResponse>);
        }
        
        /// <summary>
        /// 更新汇聚配置
        ///
        /// 只能由管理员或者委托管理员 ,更新汇聚配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateLogConvergeConfigResponse> UpdateLogConvergeConfigAsync(UpdateLogConvergeConfigRequest updateLogConvergeConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/lts/log-converge-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLogConvergeConfigRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateLogConvergeConfigResponse>(response);
        }

        public AsyncInvoker<UpdateLogConvergeConfigResponse> UpdateLogConvergeConfigAsyncInvoker(UpdateLogConvergeConfigRequest updateLogConvergeConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/lts/log-converge-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLogConvergeConfigRequest);
            return new AsyncInvoker<UpdateLogConvergeConfigResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateLogConvergeConfigResponse>);
        }
        
        /// <summary>
        /// 修改日志组
        ///
        /// 该接口用于修改指定日志组下的日志存储时长。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateLogGroupResponse> UpdateLogGroupAsync(UpdateLogGroupRequest updateLogGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id", updateLogGroupRequest.LogGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLogGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateLogGroupResponse>(response);
        }

        public AsyncInvoker<UpdateLogGroupResponse> UpdateLogGroupAsyncInvoker(UpdateLogGroupRequest updateLogGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id", updateLogGroupRequest.LogGroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLogGroupRequest);
            return new AsyncInvoker<UpdateLogGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateLogGroupResponse>);
        }
        
        /// <summary>
        /// 修改日志流
        ///
        /// 该接口用于修改指定日志流下的日志存储时长。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateLogStreamResponse> UpdateLogStreamAsync(UpdateLogStreamRequest updateLogStreamRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id", updateLogStreamRequest.LogGroupId.ToString());
            urlParam.Add("log_stream_id", updateLogStreamRequest.LogStreamId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}/streams-ttl/{log_stream_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLogStreamRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateLogStreamResponse>(response);
        }

        public AsyncInvoker<UpdateLogStreamResponse> UpdateLogStreamAsyncInvoker(UpdateLogStreamRequest updateLogStreamRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("log_group_id", updateLogStreamRequest.LogGroupId.ToString());
            urlParam.Add("log_stream_id", updateLogStreamRequest.LogStreamId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/groups/{log_group_id}/streams-ttl/{log_stream_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLogStreamRequest);
            return new AsyncInvoker<UpdateLogStreamResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateLogStreamResponse>);
        }
        
        /// <summary>
        /// 修改消息模板
        ///
        /// 该接口用于修改通知模板,根据名称进行修改。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateNotificationTemplateResponse> UpdateNotificationTemplateAsync(UpdateNotificationTemplateRequest updateNotificationTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateNotificationTemplateRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/events/notification/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateNotificationTemplateRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateNotificationTemplateResponse>(response);
        }

        public AsyncInvoker<UpdateNotificationTemplateResponse> UpdateNotificationTemplateAsyncInvoker(UpdateNotificationTemplateRequest updateNotificationTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updateNotificationTemplateRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{domain_id}/lts/events/notification/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateNotificationTemplateRequest);
            return new AsyncInvoker<UpdateNotificationTemplateResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateNotificationTemplateResponse>);
        }
        
        /// <summary>
        /// 通过结构化模板修改结构化配置（新）
        ///
        /// 该接口通过结构化模板修改结构化配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateStructConfigResponse> UpdateStructConfigAsync(UpdateStructConfigRequest updateStructConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/struct/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateStructConfigRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateStructConfigResponse>(response);
        }

        public AsyncInvoker<UpdateStructConfigResponse> UpdateStructConfigAsyncInvoker(UpdateStructConfigRequest updateStructConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/lts/struct/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateStructConfigRequest);
            return new AsyncInvoker<UpdateStructConfigResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateStructConfigResponse>);
        }
        
        /// <summary>
        /// 修改结构化配置
        ///
        /// 该接口用于修改指定日志流下的结构化配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateStructTemplateResponse> UpdateStructTemplateAsync(UpdateStructTemplateRequest updateStructTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/struct/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateStructTemplateRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateStructTemplateResponse>(response);
        }

        public AsyncInvoker<UpdateStructTemplateResponse> UpdateStructTemplateAsyncInvoker(UpdateStructTemplateRequest updateStructTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/struct/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateStructTemplateRequest);
            return new AsyncInvoker<UpdateStructTemplateResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateStructTemplateResponse>);
        }
        
        /// <summary>
        /// 修改日志汇聚开关
        ///
        /// 只能由管理员或者委托管理员调用     修改日志汇聚开关
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateSwitchResponse> UpdateSwitchAsync(UpdateSwitchRequest updateSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/lts/log-converge-config/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSwitchRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSwitchResponse>(response);
        }

        public AsyncInvoker<UpdateSwitchResponse> UpdateSwitchAsyncInvoker(UpdateSwitchRequest updateSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/lts/log-converge-config/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSwitchRequest);
            return new AsyncInvoker<UpdateSwitchResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSwitchResponse>);
        }
        
        /// <summary>
        /// 更新日志转储
        ///
        /// 该接口用于更新OBS转储，DIS转储，DMS转储。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateTransferResponse> UpdateTransferAsync(UpdateTransferRequest updateTransferRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/transfers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateTransferRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateTransferResponse>(response);
        }

        public AsyncInvoker<UpdateTransferResponse> UpdateTransferAsyncInvoker(UpdateTransferRequest updateTransferRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/transfers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateTransferRequest);
            return new AsyncInvoker<UpdateTransferResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateTransferResponse>);
        }
        
        /// <summary>
        /// 创建接入规则
        ///
        /// 该接口用于创建aom日志接入lts规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAomMappingRulesResponse> CreateAomMappingRulesAsync(CreateAomMappingRulesRequest createAomMappingRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/aom-mapping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAomMappingRulesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            var createAomMappingRulesResponse = JsonUtils.DeSerializeNull<CreateAomMappingRulesResponse>(response);
            createAomMappingRulesResponse.Body = JsonUtils.DeSerializeList<AomMappingRuleResp>(response);
            return createAomMappingRulesResponse;
        }

        public AsyncInvoker<CreateAomMappingRulesResponse> CreateAomMappingRulesAsyncInvoker(CreateAomMappingRulesRequest createAomMappingRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/aom-mapping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAomMappingRulesRequest);
            return new AsyncInvoker<CreateAomMappingRulesResponse>(this, "POST", request, response =>
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
        public async Task<DeleteAomMappingRulesResponse> DeleteAomMappingRulesAsync(DeleteAomMappingRulesRequest deleteAomMappingRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/aom-mapping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAomMappingRulesRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            var deleteAomMappingRulesResponse = JsonUtils.DeSerializeNull<DeleteAomMappingRulesResponse>(response);
            deleteAomMappingRulesResponse.Body = JsonUtils.DeSerializeList<string>(response);
            return deleteAomMappingRulesResponse;
        }

        public AsyncInvoker<DeleteAomMappingRulesResponse> DeleteAomMappingRulesAsyncInvoker(DeleteAomMappingRulesRequest deleteAomMappingRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/aom-mapping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAomMappingRulesRequest);
            return new AsyncInvoker<DeleteAomMappingRulesResponse>(this, "DELETE", request, response =>
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
        public async Task<ShowAomMappingRuleResponse> ShowAomMappingRuleAsync(ShowAomMappingRuleRequest showAomMappingRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id", showAomMappingRuleRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/aom-mapping/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAomMappingRuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var showAomMappingRuleResponse = JsonUtils.DeSerializeNull<ShowAomMappingRuleResponse>(response);
            showAomMappingRuleResponse.Body = JsonUtils.DeSerializeList<AomMappingRuleResp>(response);
            return showAomMappingRuleResponse;
        }

        public AsyncInvoker<ShowAomMappingRuleResponse> ShowAomMappingRuleAsyncInvoker(ShowAomMappingRuleRequest showAomMappingRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("rule_id", showAomMappingRuleRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/aom-mapping/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAomMappingRuleRequest);
            return new AsyncInvoker<ShowAomMappingRuleResponse>(this, "GET", request, response =>
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
        public async Task<ShowAomMappingRulesResponse> ShowAomMappingRulesAsync(ShowAomMappingRulesRequest showAomMappingRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/aom-mapping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAomMappingRulesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var showAomMappingRulesResponse = JsonUtils.DeSerializeNull<ShowAomMappingRulesResponse>(response);
            showAomMappingRulesResponse.Body = JsonUtils.DeSerializeList<AomMappingRuleResp>(response);
            return showAomMappingRulesResponse;
        }

        public AsyncInvoker<ShowAomMappingRulesResponse> ShowAomMappingRulesAsyncInvoker(ShowAomMappingRulesRequest showAomMappingRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/aom-mapping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAomMappingRulesRequest);
            return new AsyncInvoker<ShowAomMappingRulesResponse>(this, "GET", request, response =>
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
        public async Task<UpdateAomMappingRulesResponse> UpdateAomMappingRulesAsync(UpdateAomMappingRulesRequest updateAomMappingRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/aom-mapping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAomMappingRulesRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAomMappingRulesResponse>(response);
        }

        public AsyncInvoker<UpdateAomMappingRulesResponse> UpdateAomMappingRulesAsyncInvoker(UpdateAomMappingRulesRequest updateAomMappingRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/aom-mapping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAomMappingRulesRequest);
            return new AsyncInvoker<UpdateAomMappingRulesResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAomMappingRulesResponse>);
        }
        
        /// <summary>
        /// 创建SQL告警规则
        ///
        /// 该接口用于创建SQL告警，目前每个帐户最多可以创建共200个关键词告警与SQL告警
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSqlAlarmRuleResponse> CreateSqlAlarmRuleAsync(CreateSqlAlarmRuleRequest createSqlAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/sql-alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSqlAlarmRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateSqlAlarmRuleResponse>(response);
        }

        public AsyncInvoker<CreateSqlAlarmRuleResponse> CreateSqlAlarmRuleAsyncInvoker(CreateSqlAlarmRuleRequest createSqlAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/sql-alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSqlAlarmRuleRequest);
            return new AsyncInvoker<CreateSqlAlarmRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSqlAlarmRuleResponse>);
        }
        
        /// <summary>
        /// 删除SQL告警规则
        ///
        /// 该接口用于删除SQL告警
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSqlAlarmRuleResponse> DeleteSqlAlarmRuleAsync(DeleteSqlAlarmRuleRequest deleteSqlAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("sql_alarm_rule_id", deleteSqlAlarmRuleRequest.SqlAlarmRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/sql-alarm-rule/{sql_alarm_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSqlAlarmRuleRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSqlAlarmRuleResponse>(response);
        }

        public AsyncInvoker<DeleteSqlAlarmRuleResponse> DeleteSqlAlarmRuleAsyncInvoker(DeleteSqlAlarmRuleRequest deleteSqlAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("sql_alarm_rule_id", deleteSqlAlarmRuleRequest.SqlAlarmRuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/sql-alarm-rule/{sql_alarm_rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSqlAlarmRuleRequest);
            return new AsyncInvoker<DeleteSqlAlarmRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSqlAlarmRuleResponse>);
        }
        
        /// <summary>
        /// 查询SQL告警规则
        ///
        /// 该接口用于查询SQL告警
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSqlAlarmRulesResponse> ListSqlAlarmRulesAsync(ListSqlAlarmRulesRequest listSqlAlarmRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/sql-alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSqlAlarmRulesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSqlAlarmRulesResponse>(response);
        }

        public AsyncInvoker<ListSqlAlarmRulesResponse> ListSqlAlarmRulesAsyncInvoker(ListSqlAlarmRulesRequest listSqlAlarmRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/sql-alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSqlAlarmRulesRequest);
            return new AsyncInvoker<ListSqlAlarmRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSqlAlarmRulesResponse>);
        }
        
        /// <summary>
        /// 切换告警规则状态
        ///
        /// 改变告警规则状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAlarmRuleStatusResponse> UpdateAlarmRuleStatusAsync(UpdateAlarmRuleStatusRequest updateAlarmRuleStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAlarmRuleStatusRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateAlarmRuleStatusResponse>(response);
        }

        public AsyncInvoker<UpdateAlarmRuleStatusResponse> UpdateAlarmRuleStatusAsyncInvoker(UpdateAlarmRuleStatusRequest updateAlarmRuleStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAlarmRuleStatusRequest);
            return new AsyncInvoker<UpdateAlarmRuleStatusResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateAlarmRuleStatusResponse>);
        }
        
        /// <summary>
        /// 修改SQL告警规则
        ///
        /// 该接口用于修改SQL告警
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateSqlAlarmRuleResponse> UpdateSqlAlarmRuleAsync(UpdateSqlAlarmRuleRequest updateSqlAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/sql-alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSqlAlarmRuleRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSqlAlarmRuleResponse>(response);
        }

        public AsyncInvoker<UpdateSqlAlarmRuleResponse> UpdateSqlAlarmRuleAsyncInvoker(UpdateSqlAlarmRuleRequest updateSqlAlarmRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/lts/alarms/sql-alarm-rule", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSqlAlarmRuleRequest);
            return new AsyncInvoker<UpdateSqlAlarmRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSqlAlarmRuleResponse>);
        }
        
    }
}