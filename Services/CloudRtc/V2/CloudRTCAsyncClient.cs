using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.CloudRtc.V2.Model;

namespace HuaweiCloud.SDK.CloudRtc.V2
{
    public partial class CloudRtcAsyncClient : Client
    {
        public static ClientBuilder<CloudRtcAsyncClient> NewBuilder()
        {
            return new ClientBuilder<CloudRtcAsyncClient>();
        }

        
        /// <summary>
        /// 创建应用
        ///
        /// 调用此接口创建应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAppResponse> CreateAppAsync(CreateAppRequest createAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", createAppRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAppResponse>(response);
        }

        public AsyncInvoker<CreateAppResponse> CreateAppAsyncInvoker(CreateAppRequest createAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", createAppRequest);
            return new AsyncInvoker<CreateAppResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAppResponse>);
        }
        
        /// <summary>
        /// 启动单流任务
        ///
        /// 调用此接口接口启动单流任务。
        /// 
        /// API触发单流录制流名规则：{jobtype}\\_{jobid}\\_{roomid}\\_{userid}
        /// 
        /// jobtype取值为&#39;s&#39;代表单流录制。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateIndividualStreamJobResponse> CreateIndividualStreamJobAsync(CreateIndividualStreamJobRequest createIndividualStreamJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createIndividualStreamJobRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/individual-stream-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", createIndividualStreamJobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateIndividualStreamJobResponse>(response);
        }

        public AsyncInvoker<CreateIndividualStreamJobResponse> CreateIndividualStreamJobAsyncInvoker(CreateIndividualStreamJobRequest createIndividualStreamJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createIndividualStreamJobRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/individual-stream-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", createIndividualStreamJobRequest);
            return new AsyncInvoker<CreateIndividualStreamJobResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateIndividualStreamJobResponse>);
        }
        
        /// <summary>
        /// 启动合流任务
        ///
        /// 调用此接口创建合流转码任务。
        /// 
        /// 支持纯音频录制和音视频录制：
        /// 
        /// - 纯音频录制
        /// 
        ///   encode_template填audio_only，音频合流会动态选择最大三方的声音。
        /// 
        ///   layout_template、layout_panes以及其他视频相关参数都不填，填就忽略。
        /// 
        /// - 音视频录制（包括共享桌面）
        /// 
        ///   encode_template非audio_only，layout_template、layout_panes必须非空。
        /// 
        ///   音频合流会动态选择最大三方的声音。
        /// 
        ///   API触发合流录制流名规则：{jobtype}\\_{jobid}\\_{roomid}，其中jobtype取值为&#39;m&#39;代表合流录制。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateMixJobResponse> CreateMixJobAsync(CreateMixJobRequest createMixJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMixJobRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/mix-stream-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", createMixJobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateMixJobResponse>(response);
        }

        public AsyncInvoker<CreateMixJobResponse> CreateMixJobAsyncInvoker(CreateMixJobRequest createMixJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createMixJobRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/mix-stream-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", createMixJobRequest);
            return new AsyncInvoker<CreateMixJobResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMixJobResponse>);
        }
        
        /// <summary>
        /// 创建或更新录制规则
        ///
        /// 调用此接口创建或更新录制规则。
        /// 
        /// - 若当前app在请求的location中无录制规则，则会创建新的录制规则
        /// - 若当前app在请求的location中已有录制规则，则会更新原来的录制规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRecordRuleResponse> CreateRecordRuleAsync(CreateRecordRuleRequest createRecordRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRecordRuleRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/record-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", createRecordRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateRecordRuleResponse>(response);
        }

        public AsyncInvoker<CreateRecordRuleResponse> CreateRecordRuleAsyncInvoker(CreateRecordRuleRequest createRecordRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRecordRuleRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/record-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", createRecordRuleRequest);
            return new AsyncInvoker<CreateRecordRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRecordRuleResponse>);
        }
        
        /// <summary>
        /// 删除应用
        ///
        /// 调用此接口删除单个应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAppResponse> DeleteAppAsync(DeleteAppRequest deleteAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAppRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAppResponse>(response);
        }

        public AsyncInvoker<DeleteAppResponse> DeleteAppAsyncInvoker(DeleteAppRequest deleteAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAppRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppRequest);
            return new AsyncInvoker<DeleteAppResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAppResponse>);
        }
        
        /// <summary>
        /// 删除录制规则
        ///
        /// 调用此接口删除录制规则，对于正在使用的录制规则，不允许删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRecordRuleResponse> DeleteRecordRuleAsync(DeleteRecordRuleRequest deleteRecordRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRecordRuleRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            if (StringUtils.TryConvertToNonEmptyString(deleteRecordRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/record-rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordRuleRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRecordRuleResponse>(response);
        }

        public AsyncInvoker<DeleteRecordRuleResponse> DeleteRecordRuleAsyncInvoker(DeleteRecordRuleRequest deleteRecordRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRecordRuleRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            if (StringUtils.TryConvertToNonEmptyString(deleteRecordRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/record-rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordRuleRequest);
            return new AsyncInvoker<DeleteRecordRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRecordRuleResponse>);
        }
        
        /// <summary>
        /// 查询应用列表
        ///
        /// 调用此接口查询应用列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAppsResponse> ListAppsAsync(ListAppsRequest listAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAppsResponse>(response);
        }

        public AsyncInvoker<ListAppsResponse> ListAppsAsyncInvoker(ListAppsRequest listAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppsRequest);
            return new AsyncInvoker<ListAppsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAppsResponse>);
        }
        
        /// <summary>
        /// 查询录制规则列表
        ///
        /// 调用此接口查询录制规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRecordRulesResponse> ListRecordRulesAsync(ListRecordRulesRequest listRecordRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRecordRulesRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/record-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordRulesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRecordRulesResponse>(response);
        }

        public AsyncInvoker<ListRecordRulesResponse> ListRecordRulesAsyncInvoker(ListRecordRulesRequest listRecordRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRecordRulesRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/record-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordRulesRequest);
            return new AsyncInvoker<ListRecordRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRecordRulesResponse>);
        }
        
        /// <summary>
        /// 解散房间
        ///
        /// 调用此接口解散房间，将该房间中所有用户踢出房间。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RemoveRoomResponse> RemoveRoomAsync(RemoveRoomRequest removeRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeRoomRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            if (StringUtils.TryConvertToNonEmptyString(removeRoomRequest.RoomId, out var valueOfRoomId)) urlParam.Add("room_id", valueOfRoomId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/rooms/{room_id}/dismiss", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeRoomRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<RemoveRoomResponse>(response);
        }

        public AsyncInvoker<RemoveRoomResponse> RemoveRoomAsyncInvoker(RemoveRoomRequest removeRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeRoomRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            if (StringUtils.TryConvertToNonEmptyString(removeRoomRequest.RoomId, out var valueOfRoomId)) urlParam.Add("room_id", valueOfRoomId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/rooms/{room_id}/dismiss", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeRoomRequest);
            return new AsyncInvoker<RemoveRoomResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RemoveRoomResponse>);
        }
        
        /// <summary>
        /// 踢除在线用户
        ///
        /// 调用此接口强制用户离开房间。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RemoveUsersResponse> RemoveUsersAsync(RemoveUsersRequest removeUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeUsersRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            if (StringUtils.TryConvertToNonEmptyString(removeUsersRequest.RoomId, out var valueOfRoomId)) urlParam.Add("room_id", valueOfRoomId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/rooms/{room_id}/batch-remove-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", removeUsersRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<RemoveUsersResponse>(response);
        }

        public AsyncInvoker<RemoveUsersResponse> RemoveUsersAsyncInvoker(RemoveUsersRequest removeUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removeUsersRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            if (StringUtils.TryConvertToNonEmptyString(removeUsersRequest.RoomId, out var valueOfRoomId)) urlParam.Add("room_id", valueOfRoomId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/rooms/{room_id}/batch-remove-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", removeUsersRequest);
            return new AsyncInvoker<RemoveUsersResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RemoveUsersResponse>);
        }
        
        /// <summary>
        /// 查询单个应用
        ///
        /// 调用此接口查询单个应用详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAppResponse> ShowAppAsync(ShowAppRequest showAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAppRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAppResponse>(response);
        }

        public AsyncInvoker<ShowAppResponse> ShowAppAsyncInvoker(ShowAppRequest showAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAppRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppRequest);
            return new AsyncInvoker<ShowAppResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAppResponse>);
        }
        
        /// <summary>
        /// 查询自动录制配置
        ///
        /// 调用此接口查询自动录制配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAutoRecordResponse> ShowAutoRecordAsync(ShowAutoRecordRequest showAutoRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutoRecordRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/auto-record-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoRecordRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAutoRecordResponse>(response);
        }

        public AsyncInvoker<ShowAutoRecordResponse> ShowAutoRecordAsyncInvoker(ShowAutoRecordRequest showAutoRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAutoRecordRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/auto-record-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoRecordRequest);
            return new AsyncInvoker<ShowAutoRecordResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutoRecordResponse>);
        }
        
        /// <summary>
        /// 查询单流任务状态
        ///
        /// 调用此接口查询单流任务状态。
        /// 
        /// 租户的OBS桶内的情况，暂不支持查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowIndividualStreamJobResponse> ShowIndividualStreamJobAsync(ShowIndividualStreamJobRequest showIndividualStreamJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showIndividualStreamJobRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            if (StringUtils.TryConvertToNonEmptyString(showIndividualStreamJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/individual-stream-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIndividualStreamJobRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowIndividualStreamJobResponse>(response);
        }

        public AsyncInvoker<ShowIndividualStreamJobResponse> ShowIndividualStreamJobAsyncInvoker(ShowIndividualStreamJobRequest showIndividualStreamJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showIndividualStreamJobRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            if (StringUtils.TryConvertToNonEmptyString(showIndividualStreamJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/individual-stream-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIndividualStreamJobRequest);
            return new AsyncInvoker<ShowIndividualStreamJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowIndividualStreamJobResponse>);
        }
        
        /// <summary>
        /// 查询合流任务
        ///
        /// 调用此接口查询合流转码任务状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMixJobResponse> ShowMixJobAsync(ShowMixJobRequest showMixJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMixJobRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            if (StringUtils.TryConvertToNonEmptyString(showMixJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/mix-stream-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMixJobRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowMixJobResponse>(response);
        }

        public AsyncInvoker<ShowMixJobResponse> ShowMixJobAsyncInvoker(ShowMixJobRequest showMixJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showMixJobRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            if (StringUtils.TryConvertToNonEmptyString(showMixJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/mix-stream-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMixJobRequest);
            return new AsyncInvoker<ShowMixJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMixJobResponse>);
        }
        
        /// <summary>
        /// 查询增值（录制）事件回调配置
        ///
        /// 调用此接口查询增值（录制）事件回调配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRecordCallbackResponse> ShowRecordCallbackAsync(ShowRecordCallbackRequest showRecordCallbackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRecordCallbackRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/record-callback", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordCallbackRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRecordCallbackResponse>(response);
        }

        public AsyncInvoker<ShowRecordCallbackResponse> ShowRecordCallbackAsyncInvoker(ShowRecordCallbackRequest showRecordCallbackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRecordCallbackRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/record-callback", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordCallbackRequest);
            return new AsyncInvoker<ShowRecordCallbackResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecordCallbackResponse>);
        }
        
        /// <summary>
        /// 查询录制规则
        ///
        /// 调用此接口查询指定录制规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRecordRuleResponse> ShowRecordRuleAsync(ShowRecordRuleRequest showRecordRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRecordRuleRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            if (StringUtils.TryConvertToNonEmptyString(showRecordRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/record-rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordRuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRecordRuleResponse>(response);
        }

        public AsyncInvoker<ShowRecordRuleResponse> ShowRecordRuleAsyncInvoker(ShowRecordRuleRequest showRecordRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRecordRuleRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            if (StringUtils.TryConvertToNonEmptyString(showRecordRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/record-rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordRuleRequest);
            return new AsyncInvoker<ShowRecordRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecordRuleResponse>);
        }
        
        /// <summary>
        /// 启用应用
        ///
        /// 调用此接口启用单个应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StartAppResponse> StartAppAsync(StartAppRequest startAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startAppRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startAppRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StartAppResponse>(response);
        }

        public AsyncInvoker<StartAppResponse> StartAppAsyncInvoker(StartAppRequest startAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startAppRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startAppRequest);
            return new AsyncInvoker<StartAppResponse>(this, "POST", request, JsonUtils.DeSerialize<StartAppResponse>);
        }
        
        /// <summary>
        /// 停用应用
        ///
        /// 调用此接口停用单个应用。
        /// 
        /// 应用停用后，新房间无法新增和加入，已加入的房间可以继续使用。合流、录制功能等也不可用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StopAppResponse> StopAppAsync(StopAppRequest stopAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopAppRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopAppRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StopAppResponse>(response);
        }

        public AsyncInvoker<StopAppResponse> StopAppAsyncInvoker(StopAppRequest stopAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopAppRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopAppRequest);
            return new AsyncInvoker<StopAppResponse>(this, "POST", request, JsonUtils.DeSerialize<StopAppResponse>);
        }
        
        /// <summary>
        /// 停止单流任务
        ///
        /// 调用此接口停止单流任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StopIndividualStreamJobResponse> StopIndividualStreamJobAsync(StopIndividualStreamJobRequest stopIndividualStreamJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopIndividualStreamJobRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            if (StringUtils.TryConvertToNonEmptyString(stopIndividualStreamJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/individual-stream-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopIndividualStreamJobRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<StopIndividualStreamJobResponse>(response);
        }

        public AsyncInvoker<StopIndividualStreamJobResponse> StopIndividualStreamJobAsyncInvoker(StopIndividualStreamJobRequest stopIndividualStreamJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopIndividualStreamJobRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            if (StringUtils.TryConvertToNonEmptyString(stopIndividualStreamJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/individual-stream-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopIndividualStreamJobRequest);
            return new AsyncInvoker<StopIndividualStreamJobResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<StopIndividualStreamJobResponse>);
        }
        
        /// <summary>
        /// 停止合流任务
        ///
        /// 调用此接口停止已下发的合流转码任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StopMixJobResponse> StopMixJobAsync(StopMixJobRequest stopMixJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopMixJobRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            if (StringUtils.TryConvertToNonEmptyString(stopMixJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/mix-stream-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopMixJobRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<StopMixJobResponse>(response);
        }

        public AsyncInvoker<StopMixJobResponse> StopMixJobAsyncInvoker(StopMixJobRequest stopMixJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopMixJobRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            if (StringUtils.TryConvertToNonEmptyString(stopMixJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/mix-stream-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopMixJobRequest);
            return new AsyncInvoker<StopMixJobResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<StopMixJobResponse>);
        }
        
        /// <summary>
        /// 更新自动录制配置
        ///
        /// 更新自动录制配置，租户可以开启自动单流录制或者停用自动单流录制。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAutoRecordResponse> UpdateAutoRecordAsync(UpdateAutoRecordRequest updateAutoRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAutoRecordRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/auto-record-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", updateAutoRecordRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAutoRecordResponse>(response);
        }

        public AsyncInvoker<UpdateAutoRecordResponse> UpdateAutoRecordAsyncInvoker(UpdateAutoRecordRequest updateAutoRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateAutoRecordRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/auto-record-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", updateAutoRecordRequest);
            return new AsyncInvoker<UpdateAutoRecordResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAutoRecordResponse>);
        }
        
        /// <summary>
        /// 更新单流任务
        ///
        /// 调用此接口修改单流任务。
        /// 
        /// 仅部分场景支持修改。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateIndividualStreamJobResponse> UpdateIndividualStreamJobAsync(UpdateIndividualStreamJobRequest updateIndividualStreamJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateIndividualStreamJobRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            if (StringUtils.TryConvertToNonEmptyString(updateIndividualStreamJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/individual-stream-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", updateIndividualStreamJobRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateIndividualStreamJobResponse>(response);
        }

        public AsyncInvoker<UpdateIndividualStreamJobResponse> UpdateIndividualStreamJobAsyncInvoker(UpdateIndividualStreamJobRequest updateIndividualStreamJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateIndividualStreamJobRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            if (StringUtils.TryConvertToNonEmptyString(updateIndividualStreamJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/individual-stream-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", updateIndividualStreamJobRequest);
            return new AsyncInvoker<UpdateIndividualStreamJobResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateIndividualStreamJobResponse>);
        }
        
        /// <summary>
        /// 修改合流任务
        ///
        /// 调用此接口更新合流任务布局。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateMixJobResponse> UpdateMixJobAsync(UpdateMixJobRequest updateMixJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMixJobRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            if (StringUtils.TryConvertToNonEmptyString(updateMixJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/mix-stream-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", updateMixJobRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateMixJobResponse>(response);
        }

        public AsyncInvoker<UpdateMixJobResponse> UpdateMixJobAsyncInvoker(UpdateMixJobRequest updateMixJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateMixJobRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            if (StringUtils.TryConvertToNonEmptyString(updateMixJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/mix-stream-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", updateMixJobRequest);
            return new AsyncInvoker<UpdateMixJobResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateMixJobResponse>);
        }
        
        /// <summary>
        /// 配置RTC增值（录制）事件回调
        ///
        /// 调用此接口配置增值（录制）事件上报回调。
        /// 
        /// 当任务发生订阅了的事件时，通过该接口配置的回调地址通知。
        /// 
        /// 回调格式参考/customer-record-notify-url定义。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRecordCallbackResponse> UpdateRecordCallbackAsync(UpdateRecordCallbackRequest updateRecordCallbackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRecordCallbackRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/record-callback", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", updateRecordCallbackRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRecordCallbackResponse>(response);
        }

        public AsyncInvoker<UpdateRecordCallbackResponse> UpdateRecordCallbackAsyncInvoker(UpdateRecordCallbackRequest updateRecordCallbackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRecordCallbackRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/record-callback", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", updateRecordCallbackRequest);
            return new AsyncInvoker<UpdateRecordCallbackResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRecordCallbackResponse>);
        }
        
        /// <summary>
        /// 更新录制规则
        ///
        /// 调用此接口更新录制规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRecordRuleResponse> UpdateRecordRuleAsync(UpdateRecordRuleRequest updateRecordRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRecordRuleRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            if (StringUtils.TryConvertToNonEmptyString(updateRecordRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/record-rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", updateRecordRuleRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRecordRuleResponse>(response);
        }

        public AsyncInvoker<UpdateRecordRuleResponse> UpdateRecordRuleAsyncInvoker(UpdateRecordRuleRequest updateRecordRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRecordRuleRequest.AppId, out var valueOfAppId)) urlParam.Add("app_id", valueOfAppId);
            if (StringUtils.TryConvertToNonEmptyString(updateRecordRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/record-rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", updateRecordRuleRequest);
            return new AsyncInvoker<UpdateRecordRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRecordRuleResponse>);
        }
        
        /// <summary>
        /// 查询OBS桶下对象列表
        ///
        /// 查询OBS桶下对象列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListObsBucketObjectsResponse> ListObsBucketObjectsAsync(ListObsBucketObjectsRequest listObsBucketObjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/rtc-ops/buckets/objects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listObsBucketObjectsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListObsBucketObjectsResponse>(response);
        }

        public AsyncInvoker<ListObsBucketObjectsResponse> ListObsBucketObjectsAsyncInvoker(ListObsBucketObjectsRequest listObsBucketObjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/rtc-ops/buckets/objects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listObsBucketObjectsRequest);
            return new AsyncInvoker<ListObsBucketObjectsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListObsBucketObjectsResponse>);
        }
        
        /// <summary>
        /// 查询OBS桶列表
        ///
        /// 查询OBS桶列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListObsBucketsResponse> ListObsBucketsAsync(ListObsBucketsRequest listObsBucketsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/rtc-ops/buckets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listObsBucketsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListObsBucketsResponse>(response);
        }

        public AsyncInvoker<ListObsBucketsResponse> ListObsBucketsAsyncInvoker(ListObsBucketsRequest listObsBucketsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/rtc-ops/buckets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listObsBucketsRequest);
            return new AsyncInvoker<ListObsBucketsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListObsBucketsResponse>);
        }
        
        /// <summary>
        /// OBS桶授权及取消授权
        ///
        /// OBS桶授权及取消授权
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateObsBucketAuthorityResponse> UpdateObsBucketAuthorityAsync(UpdateObsBucketAuthorityRequest updateObsBucketAuthorityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/rtc-ops/buckets/authentication", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateObsBucketAuthorityRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateObsBucketAuthorityResponse>(response);
        }

        public AsyncInvoker<UpdateObsBucketAuthorityResponse> UpdateObsBucketAuthorityAsyncInvoker(UpdateObsBucketAuthorityRequest updateObsBucketAuthorityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/rtc-ops/buckets/authentication", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateObsBucketAuthorityRequest);
            return new AsyncInvoker<UpdateObsBucketAuthorityResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateObsBucketAuthorityResponse>);
        }
        
    }
}