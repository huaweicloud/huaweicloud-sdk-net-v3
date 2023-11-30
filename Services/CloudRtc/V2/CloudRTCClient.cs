using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.CloudRtc.V2.Model;

namespace HuaweiCloud.SDK.CloudRtc.V2
{
    public partial class CloudRtcClient : Client
    {
        public static ClientBuilder<CloudRtcClient> NewBuilder()
        {
            return new ClientBuilder<CloudRtcClient>();
        }

        
        /// <summary>
        /// 创建应用
        ///
        /// 调用此接口创建应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAppResponse CreateApp(CreateAppRequest createAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", createAppRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAppResponse>(response);
        }

        public SyncInvoker<CreateAppResponse> CreateAppInvoker(CreateAppRequest createAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", createAppRequest);
            return new SyncInvoker<CreateAppResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAppResponse>);
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
        public CreateIndividualStreamJobResponse CreateIndividualStreamJob(CreateIndividualStreamJobRequest createIndividualStreamJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", createIndividualStreamJobRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/individual-stream-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", createIndividualStreamJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateIndividualStreamJobResponse>(response);
        }

        public SyncInvoker<CreateIndividualStreamJobResponse> CreateIndividualStreamJobInvoker(CreateIndividualStreamJobRequest createIndividualStreamJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", createIndividualStreamJobRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/individual-stream-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", createIndividualStreamJobRequest);
            return new SyncInvoker<CreateIndividualStreamJobResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateIndividualStreamJobResponse>);
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
        public CreateMixJobResponse CreateMixJob(CreateMixJobRequest createMixJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", createMixJobRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/mix-stream-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", createMixJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateMixJobResponse>(response);
        }

        public SyncInvoker<CreateMixJobResponse> CreateMixJobInvoker(CreateMixJobRequest createMixJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", createMixJobRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/mix-stream-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", createMixJobRequest);
            return new SyncInvoker<CreateMixJobResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMixJobResponse>);
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
        public CreateRecordRuleResponse CreateRecordRule(CreateRecordRuleRequest createRecordRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", createRecordRuleRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/record-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", createRecordRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateRecordRuleResponse>(response);
        }

        public SyncInvoker<CreateRecordRuleResponse> CreateRecordRuleInvoker(CreateRecordRuleRequest createRecordRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", createRecordRuleRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/record-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", createRecordRuleRequest);
            return new SyncInvoker<CreateRecordRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRecordRuleResponse>);
        }
        
        /// <summary>
        /// 删除应用
        ///
        /// 调用此接口删除单个应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAppResponse DeleteApp(DeleteAppRequest deleteAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", deleteAppRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAppResponse>(response);
        }

        public SyncInvoker<DeleteAppResponse> DeleteAppInvoker(DeleteAppRequest deleteAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", deleteAppRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppRequest);
            return new SyncInvoker<DeleteAppResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAppResponse>);
        }
        
        /// <summary>
        /// 删除录制规则
        ///
        /// 调用此接口删除录制规则，对于正在使用的录制规则，不允许删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteRecordRuleResponse DeleteRecordRule(DeleteRecordRuleRequest deleteRecordRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", deleteRecordRuleRequest.AppId.ToString());
            urlParam.Add("rule_id", deleteRecordRuleRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/record-rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordRuleRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRecordRuleResponse>(response);
        }

        public SyncInvoker<DeleteRecordRuleResponse> DeleteRecordRuleInvoker(DeleteRecordRuleRequest deleteRecordRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", deleteRecordRuleRequest.AppId.ToString());
            urlParam.Add("rule_id", deleteRecordRuleRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/record-rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordRuleRequest);
            return new SyncInvoker<DeleteRecordRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRecordRuleResponse>);
        }
        
        /// <summary>
        /// 查询应用列表
        ///
        /// 调用此接口查询应用列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAppsResponse ListApps(ListAppsRequest listAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAppsResponse>(response);
        }

        public SyncInvoker<ListAppsResponse> ListAppsInvoker(ListAppsRequest listAppsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/apps", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppsRequest);
            return new SyncInvoker<ListAppsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAppsResponse>);
        }
        
        /// <summary>
        /// 查询录制规则列表
        ///
        /// 调用此接口查询录制规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRecordRulesResponse ListRecordRules(ListRecordRulesRequest listRecordRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", listRecordRulesRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/record-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordRulesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRecordRulesResponse>(response);
        }

        public SyncInvoker<ListRecordRulesResponse> ListRecordRulesInvoker(ListRecordRulesRequest listRecordRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", listRecordRulesRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/record-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordRulesRequest);
            return new SyncInvoker<ListRecordRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRecordRulesResponse>);
        }
        
        /// <summary>
        /// 解散房间
        ///
        /// 调用此接口解散房间，将该房间中所有用户踢出房间。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RemoveRoomResponse RemoveRoom(RemoveRoomRequest removeRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", removeRoomRequest.AppId.ToString());
            urlParam.Add("room_id", removeRoomRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/rooms/{room_id}/dismiss", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeRoomRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<RemoveRoomResponse>(response);
        }

        public SyncInvoker<RemoveRoomResponse> RemoveRoomInvoker(RemoveRoomRequest removeRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", removeRoomRequest.AppId.ToString());
            urlParam.Add("room_id", removeRoomRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/rooms/{room_id}/dismiss", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeRoomRequest);
            return new SyncInvoker<RemoveRoomResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RemoveRoomResponse>);
        }
        
        /// <summary>
        /// 踢除在线用户
        ///
        /// 调用此接口强制用户离开房间。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RemoveUsersResponse RemoveUsers(RemoveUsersRequest removeUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", removeUsersRequest.AppId.ToString());
            urlParam.Add("room_id", removeUsersRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/rooms/{room_id}/batch-remove-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", removeUsersRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<RemoveUsersResponse>(response);
        }

        public SyncInvoker<RemoveUsersResponse> RemoveUsersInvoker(RemoveUsersRequest removeUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", removeUsersRequest.AppId.ToString());
            urlParam.Add("room_id", removeUsersRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/rooms/{room_id}/batch-remove-users", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", removeUsersRequest);
            return new SyncInvoker<RemoveUsersResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RemoveUsersResponse>);
        }
        
        /// <summary>
        /// 查询单个应用
        ///
        /// 调用此接口查询单个应用详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAppResponse ShowApp(ShowAppRequest showAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", showAppRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAppResponse>(response);
        }

        public SyncInvoker<ShowAppResponse> ShowAppInvoker(ShowAppRequest showAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", showAppRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppRequest);
            return new SyncInvoker<ShowAppResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAppResponse>);
        }
        
        /// <summary>
        /// 查询自动录制配置
        ///
        /// 调用此接口查询自动录制配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAutoRecordResponse ShowAutoRecord(ShowAutoRecordRequest showAutoRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", showAutoRecordRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/auto-record-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoRecordRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAutoRecordResponse>(response);
        }

        public SyncInvoker<ShowAutoRecordResponse> ShowAutoRecordInvoker(ShowAutoRecordRequest showAutoRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", showAutoRecordRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/auto-record-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoRecordRequest);
            return new SyncInvoker<ShowAutoRecordResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAutoRecordResponse>);
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
        public ShowIndividualStreamJobResponse ShowIndividualStreamJob(ShowIndividualStreamJobRequest showIndividualStreamJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", showIndividualStreamJobRequest.AppId.ToString());
            urlParam.Add("job_id", showIndividualStreamJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/individual-stream-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIndividualStreamJobRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowIndividualStreamJobResponse>(response);
        }

        public SyncInvoker<ShowIndividualStreamJobResponse> ShowIndividualStreamJobInvoker(ShowIndividualStreamJobRequest showIndividualStreamJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", showIndividualStreamJobRequest.AppId.ToString());
            urlParam.Add("job_id", showIndividualStreamJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/individual-stream-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIndividualStreamJobRequest);
            return new SyncInvoker<ShowIndividualStreamJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowIndividualStreamJobResponse>);
        }
        
        /// <summary>
        /// 查询合流任务
        ///
        /// 调用此接口查询合流转码任务状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMixJobResponse ShowMixJob(ShowMixJobRequest showMixJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", showMixJobRequest.AppId.ToString());
            urlParam.Add("job_id", showMixJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/mix-stream-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMixJobRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMixJobResponse>(response);
        }

        public SyncInvoker<ShowMixJobResponse> ShowMixJobInvoker(ShowMixJobRequest showMixJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", showMixJobRequest.AppId.ToString());
            urlParam.Add("job_id", showMixJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/mix-stream-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMixJobRequest);
            return new SyncInvoker<ShowMixJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMixJobResponse>);
        }
        
        /// <summary>
        /// 查询增值（录制）事件回调配置
        ///
        /// 调用此接口查询增值（录制）事件回调配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRecordCallbackResponse ShowRecordCallback(ShowRecordCallbackRequest showRecordCallbackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", showRecordCallbackRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/record-callback", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordCallbackRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRecordCallbackResponse>(response);
        }

        public SyncInvoker<ShowRecordCallbackResponse> ShowRecordCallbackInvoker(ShowRecordCallbackRequest showRecordCallbackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", showRecordCallbackRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/record-callback", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordCallbackRequest);
            return new SyncInvoker<ShowRecordCallbackResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecordCallbackResponse>);
        }
        
        /// <summary>
        /// 查询录制规则
        ///
        /// 调用此接口查询指定录制规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRecordRuleResponse ShowRecordRule(ShowRecordRuleRequest showRecordRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", showRecordRuleRequest.AppId.ToString());
            urlParam.Add("rule_id", showRecordRuleRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/record-rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordRuleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRecordRuleResponse>(response);
        }

        public SyncInvoker<ShowRecordRuleResponse> ShowRecordRuleInvoker(ShowRecordRuleRequest showRecordRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", showRecordRuleRequest.AppId.ToString());
            urlParam.Add("rule_id", showRecordRuleRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/record-rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordRuleRequest);
            return new SyncInvoker<ShowRecordRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecordRuleResponse>);
        }
        
        /// <summary>
        /// 查询访问控制参数
        ///
        /// 查询应用鉴权配置参数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowUrlAuthResponse ShowUrlAuth(ShowUrlAuthRequest showUrlAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", showUrlAuthRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/authentication", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUrlAuthRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowUrlAuthResponse>(response);
        }

        public SyncInvoker<ShowUrlAuthResponse> ShowUrlAuthInvoker(ShowUrlAuthRequest showUrlAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", showUrlAuthRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/authentication", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUrlAuthRequest);
            return new SyncInvoker<ShowUrlAuthResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUrlAuthResponse>);
        }
        
        /// <summary>
        /// 启用应用
        ///
        /// 调用此接口启用单个应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StartAppResponse StartApp(StartAppRequest startAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", startAppRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startAppRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StartAppResponse>(response);
        }

        public SyncInvoker<StartAppResponse> StartAppInvoker(StartAppRequest startAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", startAppRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startAppRequest);
            return new SyncInvoker<StartAppResponse>(this, "POST", request, JsonUtils.DeSerialize<StartAppResponse>);
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
        public StopAppResponse StopApp(StopAppRequest stopAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", stopAppRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopAppRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StopAppResponse>(response);
        }

        public SyncInvoker<StopAppResponse> StopAppInvoker(StopAppRequest stopAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", stopAppRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopAppRequest);
            return new SyncInvoker<StopAppResponse>(this, "POST", request, JsonUtils.DeSerialize<StopAppResponse>);
        }
        
        /// <summary>
        /// 停止单流任务
        ///
        /// 调用此接口停止单流任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StopIndividualStreamJobResponse StopIndividualStreamJob(StopIndividualStreamJobRequest stopIndividualStreamJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", stopIndividualStreamJobRequest.AppId.ToString());
            urlParam.Add("job_id", stopIndividualStreamJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/individual-stream-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopIndividualStreamJobRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<StopIndividualStreamJobResponse>(response);
        }

        public SyncInvoker<StopIndividualStreamJobResponse> StopIndividualStreamJobInvoker(StopIndividualStreamJobRequest stopIndividualStreamJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", stopIndividualStreamJobRequest.AppId.ToString());
            urlParam.Add("job_id", stopIndividualStreamJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/individual-stream-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopIndividualStreamJobRequest);
            return new SyncInvoker<StopIndividualStreamJobResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<StopIndividualStreamJobResponse>);
        }
        
        /// <summary>
        /// 停止合流任务
        ///
        /// 调用此接口停止已下发的合流转码任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StopMixJobResponse StopMixJob(StopMixJobRequest stopMixJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", stopMixJobRequest.AppId.ToString());
            urlParam.Add("job_id", stopMixJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/mix-stream-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopMixJobRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<StopMixJobResponse>(response);
        }

        public SyncInvoker<StopMixJobResponse> StopMixJobInvoker(StopMixJobRequest stopMixJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", stopMixJobRequest.AppId.ToString());
            urlParam.Add("job_id", stopMixJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/mix-stream-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopMixJobRequest);
            return new SyncInvoker<StopMixJobResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<StopMixJobResponse>);
        }
        
        /// <summary>
        /// 更新自动录制配置
        ///
        /// 更新自动录制配置，租户可以开启自动单流录制或者停用自动单流录制。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAutoRecordResponse UpdateAutoRecord(UpdateAutoRecordRequest updateAutoRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", updateAutoRecordRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/auto-record-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", updateAutoRecordRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAutoRecordResponse>(response);
        }

        public SyncInvoker<UpdateAutoRecordResponse> UpdateAutoRecordInvoker(UpdateAutoRecordRequest updateAutoRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", updateAutoRecordRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/auto-record-mode", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", updateAutoRecordRequest);
            return new SyncInvoker<UpdateAutoRecordResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAutoRecordResponse>);
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
        public UpdateIndividualStreamJobResponse UpdateIndividualStreamJob(UpdateIndividualStreamJobRequest updateIndividualStreamJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", updateIndividualStreamJobRequest.AppId.ToString());
            urlParam.Add("job_id", updateIndividualStreamJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/individual-stream-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", updateIndividualStreamJobRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateIndividualStreamJobResponse>(response);
        }

        public SyncInvoker<UpdateIndividualStreamJobResponse> UpdateIndividualStreamJobInvoker(UpdateIndividualStreamJobRequest updateIndividualStreamJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", updateIndividualStreamJobRequest.AppId.ToString());
            urlParam.Add("job_id", updateIndividualStreamJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/individual-stream-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", updateIndividualStreamJobRequest);
            return new SyncInvoker<UpdateIndividualStreamJobResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateIndividualStreamJobResponse>);
        }
        
        /// <summary>
        /// 修改合流任务
        ///
        /// 调用此接口更新合流任务布局。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateMixJobResponse UpdateMixJob(UpdateMixJobRequest updateMixJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", updateMixJobRequest.AppId.ToString());
            urlParam.Add("job_id", updateMixJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/mix-stream-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", updateMixJobRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateMixJobResponse>(response);
        }

        public SyncInvoker<UpdateMixJobResponse> UpdateMixJobInvoker(UpdateMixJobRequest updateMixJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", updateMixJobRequest.AppId.ToString());
            urlParam.Add("job_id", updateMixJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/mix-stream-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", updateMixJobRequest);
            return new SyncInvoker<UpdateMixJobResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateMixJobResponse>);
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
        public UpdateRecordCallbackResponse UpdateRecordCallback(UpdateRecordCallbackRequest updateRecordCallbackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", updateRecordCallbackRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/record-callback", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", updateRecordCallbackRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRecordCallbackResponse>(response);
        }

        public SyncInvoker<UpdateRecordCallbackResponse> UpdateRecordCallbackInvoker(UpdateRecordCallbackRequest updateRecordCallbackRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", updateRecordCallbackRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/record-callback", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", updateRecordCallbackRequest);
            return new SyncInvoker<UpdateRecordCallbackResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRecordCallbackResponse>);
        }
        
        /// <summary>
        /// 更新录制规则
        ///
        /// 调用此接口更新录制规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRecordRuleResponse UpdateRecordRule(UpdateRecordRuleRequest updateRecordRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", updateRecordRuleRequest.AppId.ToString());
            urlParam.Add("rule_id", updateRecordRuleRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/record-rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", updateRecordRuleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRecordRuleResponse>(response);
        }

        public SyncInvoker<UpdateRecordRuleResponse> UpdateRecordRuleInvoker(UpdateRecordRuleRequest updateRecordRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", updateRecordRuleRequest.AppId.ToString());
            urlParam.Add("rule_id", updateRecordRuleRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/record-rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", updateRecordRuleRequest);
            return new SyncInvoker<UpdateRecordRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRecordRuleResponse>);
        }
        
        /// <summary>
        /// 开关访问控制
        ///
        /// 调用此接口开启或关闭URL鉴权。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateUrlAuthResponse UpdateUrlAuth(UpdateUrlAuthRequest updateUrlAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", updateUrlAuthRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/authentication", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUrlAuthRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateUrlAuthResponse>(response);
        }

        public SyncInvoker<UpdateUrlAuthResponse> UpdateUrlAuthInvoker(UpdateUrlAuthRequest updateUrlAuthRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id", updateUrlAuthRequest.AppId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/authentication", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUrlAuthRequest);
            return new SyncInvoker<UpdateUrlAuthResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateUrlAuthResponse>);
        }
        
        /// <summary>
        /// 查询OBS桶下对象列表
        ///
        /// 查询OBS桶下对象列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListObsBucketObjectsResponse ListObsBucketObjects(ListObsBucketObjectsRequest listObsBucketObjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/rtc-ops/buckets/objects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listObsBucketObjectsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListObsBucketObjectsResponse>(response);
        }

        public SyncInvoker<ListObsBucketObjectsResponse> ListObsBucketObjectsInvoker(ListObsBucketObjectsRequest listObsBucketObjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/rtc-ops/buckets/objects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listObsBucketObjectsRequest);
            return new SyncInvoker<ListObsBucketObjectsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListObsBucketObjectsResponse>);
        }
        
        /// <summary>
        /// 查询OBS桶列表
        ///
        /// 查询OBS桶列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListObsBucketsResponse ListObsBuckets(ListObsBucketsRequest listObsBucketsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/rtc-ops/buckets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listObsBucketsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListObsBucketsResponse>(response);
        }

        public SyncInvoker<ListObsBucketsResponse> ListObsBucketsInvoker(ListObsBucketsRequest listObsBucketsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/rtc-ops/buckets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listObsBucketsRequest);
            return new SyncInvoker<ListObsBucketsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListObsBucketsResponse>);
        }
        
        /// <summary>
        /// OBS桶授权及取消授权
        ///
        /// OBS桶授权及取消授权
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateObsBucketAuthorityResponse UpdateObsBucketAuthority(UpdateObsBucketAuthorityRequest updateObsBucketAuthorityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/rtc-ops/buckets/authentication", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateObsBucketAuthorityRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateObsBucketAuthorityResponse>(response);
        }

        public SyncInvoker<UpdateObsBucketAuthorityResponse> UpdateObsBucketAuthorityInvoker(UpdateObsBucketAuthorityRequest updateObsBucketAuthorityRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/rtc-ops/buckets/authentication", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateObsBucketAuthorityRequest);
            return new SyncInvoker<UpdateObsBucketAuthorityResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateObsBucketAuthorityResponse>);
        }
        
    }
}