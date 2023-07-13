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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/apps",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", createAppRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateAppResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id" , createIndividualStreamJobRequest.AppId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/individual-stream-jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", createIndividualStreamJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateIndividualStreamJobResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id" , createMixJobRequest.AppId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/mix-stream-jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", createMixJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateMixJobResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id" , createRecordRuleRequest.AppId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/record-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", createRecordRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateRecordRuleResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id" , deleteAppRequest.AppId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAppRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteAppResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id" , deleteRecordRuleRequest.AppId.ToString());
            urlParam.Add("rule_id" , deleteRecordRuleRequest.RuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/record-rules/{rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteRecordRuleResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/apps",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAppsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id" , listRecordRulesRequest.AppId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/record-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordRulesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListRecordRulesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id" , removeRoomRequest.AppId.ToString());
            urlParam.Add("room_id" , removeRoomRequest.RoomId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/rooms/{room_id}/dismiss",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeRoomRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<RemoveRoomResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id" , removeUsersRequest.AppId.ToString());
            urlParam.Add("room_id" , removeUsersRequest.RoomId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/rooms/{room_id}/batch-remove-users",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", removeUsersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<RemoveUsersResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id" , showAppRequest.AppId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAppResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id" , showAutoRecordRequest.AppId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/auto-record-mode",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAutoRecordRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAutoRecordResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id" , showIndividualStreamJobRequest.AppId.ToString());
            urlParam.Add("job_id" , showIndividualStreamJobRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/individual-stream-jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIndividualStreamJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowIndividualStreamJobResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id" , showMixJobRequest.AppId.ToString());
            urlParam.Add("job_id" , showMixJobRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/mix-stream-jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMixJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowMixJobResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id" , showRecordCallbackRequest.AppId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/record-callback",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordCallbackRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowRecordCallbackResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id" , showRecordRuleRequest.AppId.ToString());
            urlParam.Add("rule_id" , showRecordRuleRequest.RuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/record-rules/{rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowRecordRuleResponse>(response);
        }
        
        /// <summary>
        /// 查询访问控制参数
        ///
        /// 查询应用鉴权配置参数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowUrlAuthResponse> ShowUrlAuthAsync(ShowUrlAuthRequest showUrlAuthRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id" , showUrlAuthRequest.AppId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/authentication",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUrlAuthRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowUrlAuthResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id" , startAppRequest.AppId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/enable",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", startAppRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<StartAppResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id" , stopAppRequest.AppId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/disable",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopAppRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<StopAppResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id" , stopIndividualStreamJobRequest.AppId.ToString());
            urlParam.Add("job_id" , stopIndividualStreamJobRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/individual-stream-jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopIndividualStreamJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<StopIndividualStreamJobResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id" , stopMixJobRequest.AppId.ToString());
            urlParam.Add("job_id" , stopMixJobRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/mix-stream-jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopMixJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<StopMixJobResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id" , updateAutoRecordRequest.AppId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/auto-record-mode",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", updateAutoRecordRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateAutoRecordResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id" , updateIndividualStreamJobRequest.AppId.ToString());
            urlParam.Add("job_id" , updateIndividualStreamJobRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/individual-stream-jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", updateIndividualStreamJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateIndividualStreamJobResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id" , updateMixJobRequest.AppId.ToString());
            urlParam.Add("job_id" , updateMixJobRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/mix-stream-jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", updateMixJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateMixJobResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id" , updateRecordCallbackRequest.AppId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/record-callback",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", updateRecordCallbackRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateRecordCallbackResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id" , updateRecordRuleRequest.AppId.ToString());
            urlParam.Add("rule_id" , updateRecordRuleRequest.RuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/record-rules/{rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", updateRecordRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateRecordRuleResponse>(response);
        }
        
        /// <summary>
        /// 开关访问控制
        ///
        /// 调用此接口开启或关闭URL鉴权。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateUrlAuthResponse> UpdateUrlAuthAsync(UpdateUrlAuthRequest updateUrlAuthRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("app_id" , updateUrlAuthRequest.AppId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/apps/{app_id}/authentication",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateUrlAuthRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateUrlAuthResponse>(response);
        }
        
    }
}