using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.MetaStudio.V1.Model;

namespace HuaweiCloud.SDK.MetaStudio.V1
{
    public partial class MetaStudioClient : Client
    {
        public static ClientBuilder<MetaStudioClient> NewBuilder()
        {
            return new ClientBuilder<MetaStudioClient>();
        }

        
        /// <summary>
        /// 创建激活码
        ///
        /// 该接口用于创建激活码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateActiveCodeResponse CreateActiveCode(CreateActiveCodeRequest createActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/active-code", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createActiveCodeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateActiveCodeResponse>(response);
        }

        public SyncInvoker<CreateActiveCodeResponse> CreateActiveCodeInvoker(CreateActiveCodeRequest createActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/active-code", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createActiveCodeRequest);
            return new SyncInvoker<CreateActiveCodeResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateActiveCodeResponse>);
        }
        
        /// <summary>
        /// 删除激活码
        ///
        /// 该接口用于删除激活码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteActiveCodeResponse DeleteActiveCode(DeleteActiveCodeRequest deleteActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/active-code/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteActiveCodeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteActiveCodeResponse>(response);
        }

        public SyncInvoker<DeleteActiveCodeResponse> DeleteActiveCodeInvoker(DeleteActiveCodeRequest deleteActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/active-code/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteActiveCodeRequest);
            return new SyncInvoker<DeleteActiveCodeResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteActiveCodeResponse>);
        }
        
        /// <summary>
        /// 查询激活码列表
        ///
        /// 该接口用于查询激活码列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListActiveCodeResponse ListActiveCode(ListActiveCodeRequest listActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/active-code", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listActiveCodeRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListActiveCodeResponse>(response);
        }

        public SyncInvoker<ListActiveCodeResponse> ListActiveCodeInvoker(ListActiveCodeRequest listActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/active-code", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listActiveCodeRequest);
            return new SyncInvoker<ListActiveCodeResponse>(this, "GET", request, JsonUtils.DeSerialize<ListActiveCodeResponse>);
        }
        
        /// <summary>
        /// 重置激活码
        ///
        /// 该接口用于重置激活码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ResetActiveCodeResponse ResetActiveCode(ResetActiveCodeRequest resetActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("active_code_id", resetActiveCodeRequest.ActiveCodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/active-code/{active_code_id}/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetActiveCodeRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ResetActiveCodeResponse>(response);
        }

        public SyncInvoker<ResetActiveCodeResponse> ResetActiveCodeInvoker(ResetActiveCodeRequest resetActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("active_code_id", resetActiveCodeRequest.ActiveCodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/active-code/{active_code_id}/reset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", resetActiveCodeRequest);
            return new SyncInvoker<ResetActiveCodeResponse>(this, "PUT", request, JsonUtils.DeSerialize<ResetActiveCodeResponse>);
        }
        
        /// <summary>
        /// 查询激活码详情
        ///
        /// 该接口用于查询激活码详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowActiveCodeResponse ShowActiveCode(ShowActiveCodeRequest showActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("active_code_id", showActiveCodeRequest.ActiveCodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/active-code/{active_code_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showActiveCodeRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowActiveCodeResponse>(response);
        }

        public SyncInvoker<ShowActiveCodeResponse> ShowActiveCodeInvoker(ShowActiveCodeRequest showActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("active_code_id", showActiveCodeRequest.ActiveCodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/active-code/{active_code_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showActiveCodeRequest);
            return new SyncInvoker<ShowActiveCodeResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowActiveCodeResponse>);
        }
        
        /// <summary>
        /// 修改激活码
        ///
        /// 该接口用于修改激活码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateActiveCodeResponse UpdateActiveCode(UpdateActiveCodeRequest updateActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("active_code_id", updateActiveCodeRequest.ActiveCodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/active-code/{active_code_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateActiveCodeRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateActiveCodeResponse>(response);
        }

        public SyncInvoker<UpdateActiveCodeResponse> UpdateActiveCodeInvoker(UpdateActiveCodeRequest updateActiveCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("active_code_id", updateActiveCodeRequest.ActiveCodeId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/active-code/{active_code_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateActiveCodeRequest);
            return new SyncInvoker<UpdateActiveCodeResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateActiveCodeResponse>);
        }
        
        /// <summary>
        /// 创建委托
        ///
        /// 该接口用于创建委托。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAgencyWithRoleTypeResponse CreateAgencyWithRoleType(CreateAgencyWithRoleTypeRequest createAgencyWithRoleTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("role_type", createAgencyWithRoleTypeRequest.RoleType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/agency/{role_type}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAgencyWithRoleTypeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAgencyWithRoleTypeResponse>(response);
        }

        public SyncInvoker<CreateAgencyWithRoleTypeResponse> CreateAgencyWithRoleTypeInvoker(CreateAgencyWithRoleTypeRequest createAgencyWithRoleTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("role_type", createAgencyWithRoleTypeRequest.RoleType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/agency/{role_type}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAgencyWithRoleTypeRequest);
            return new SyncInvoker<CreateAgencyWithRoleTypeResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAgencyWithRoleTypeResponse>);
        }
        
        /// <summary>
        /// 删除委托
        ///
        /// 该接口用于删除项目下委托。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAgencyWithRoleTypeResponse DeleteAgencyWithRoleType(DeleteAgencyWithRoleTypeRequest deleteAgencyWithRoleTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("role_type", deleteAgencyWithRoleTypeRequest.RoleType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/agency/{role_type}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAgencyWithRoleTypeRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAgencyWithRoleTypeResponse>(response);
        }

        public SyncInvoker<DeleteAgencyWithRoleTypeResponse> DeleteAgencyWithRoleTypeInvoker(DeleteAgencyWithRoleTypeRequest deleteAgencyWithRoleTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("role_type", deleteAgencyWithRoleTypeRequest.RoleType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/agency/{role_type}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAgencyWithRoleTypeRequest);
            return new SyncInvoker<DeleteAgencyWithRoleTypeResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAgencyWithRoleTypeResponse>);
        }
        
        /// <summary>
        /// 查询委托
        ///
        /// 该接口用于查询项目下委托
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAgencyResponse ShowAgency(ShowAgencyRequest showAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/agency", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAgencyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAgencyResponse>(response);
        }

        public SyncInvoker<ShowAgencyResponse> ShowAgencyInvoker(ShowAgencyRequest showAgencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/agency", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAgencyRequest);
            return new SyncInvoker<ShowAgencyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAgencyResponse>);
        }
        
        /// <summary>
        /// 创建对话链接
        ///
        /// 该接口用于创建对话链接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDialogUrlResponse CreateDialogUrl(CreateDialogUrlRequest createDialogUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/create-dialog-url", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDialogUrlRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDialogUrlResponse>(response);
        }

        public SyncInvoker<CreateDialogUrlResponse> CreateDialogUrlInvoker(CreateDialogUrlRequest createDialogUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/create-dialog-url", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDialogUrlRequest);
            return new SyncInvoker<CreateDialogUrlResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDialogUrlResponse>);
        }
        
        /// <summary>
        /// 查询数字人智能交互任务列表
        ///
        /// 该接口用于查询数字人智能交互任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSmartChatJobResponse ListSmartChatJob(ListSmartChatJobRequest listSmartChatJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", listSmartChatJobRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/smart-chat-rooms/{room_id}/smart-chat-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSmartChatJobRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSmartChatJobResponse>(response);
        }

        public SyncInvoker<ListSmartChatJobResponse> ListSmartChatJobInvoker(ListSmartChatJobRequest listSmartChatJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", listSmartChatJobRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/smart-chat-rooms/{room_id}/smart-chat-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSmartChatJobRequest);
            return new SyncInvoker<ListSmartChatJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSmartChatJobResponse>);
        }
        
        /// <summary>
        /// 查询数字人智能交互任务
        ///
        /// 该接口用于查询数字人智能交互任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSmartChatJobResponse ShowSmartChatJob(ShowSmartChatJobRequest showSmartChatJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", showSmartChatJobRequest.RoomId.ToString());
            urlParam.Add("job_id", showSmartChatJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/smart-chat-rooms/{room_id}/smart-chat-jobs/{job_id}/state", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSmartChatJobRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSmartChatJobResponse>(response);
        }

        public SyncInvoker<ShowSmartChatJobResponse> ShowSmartChatJobInvoker(ShowSmartChatJobRequest showSmartChatJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", showSmartChatJobRequest.RoomId.ToString());
            urlParam.Add("job_id", showSmartChatJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/smart-chat-rooms/{room_id}/smart-chat-jobs/{job_id}/state", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSmartChatJobRequest);
            return new SyncInvoker<ShowSmartChatJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSmartChatJobResponse>);
        }
        
        /// <summary>
        /// 启动数字人智能交互任务
        ///
        /// 该接口用于启动数字人智能交互任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StartSmartChatJobResponse StartSmartChatJob(StartSmartChatJobRequest startSmartChatJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", startSmartChatJobRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/smart-chat-rooms/{room_id}/smart-chat-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startSmartChatJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StartSmartChatJobResponse>(response);
        }

        public SyncInvoker<StartSmartChatJobResponse> StartSmartChatJobInvoker(StartSmartChatJobRequest startSmartChatJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", startSmartChatJobRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/smart-chat-rooms/{room_id}/smart-chat-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startSmartChatJobRequest);
            return new SyncInvoker<StartSmartChatJobResponse>(this, "POST", request, JsonUtils.DeSerialize<StartSmartChatJobResponse>);
        }
        
        /// <summary>
        /// 结束数字人智能交互任务
        ///
        /// 该接口用于结束数字人智能交互任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StopSmartChatJobResponse StopSmartChatJob(StopSmartChatJobRequest stopSmartChatJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", stopSmartChatJobRequest.RoomId.ToString());
            urlParam.Add("job_id", stopSmartChatJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/smart-chat-rooms/{room_id}/smart-chat-jobs/{job_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopSmartChatJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<StopSmartChatJobResponse>(response);
        }

        public SyncInvoker<StopSmartChatJobResponse> StopSmartChatJobInvoker(StopSmartChatJobRequest stopSmartChatJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", stopSmartChatJobRequest.RoomId.ToString());
            urlParam.Add("job_id", stopSmartChatJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/smart-chat-rooms/{room_id}/smart-chat-jobs/{job_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopSmartChatJobRequest);
            return new SyncInvoker<StopSmartChatJobResponse>(this, "POST", request, JsonUtils.DeSerializeNull<StopSmartChatJobResponse>);
        }
        
        /// <summary>
        /// 创建对话结果上报配置
        ///
        /// 该接口用于创建对话结果上报配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDialogReportConfigResponse CreateDialogReportConfig(CreateDialogReportConfigRequest createDialogReportConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/dialog-report-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDialogReportConfigRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDialogReportConfigResponse>(response);
        }

        public SyncInvoker<CreateDialogReportConfigResponse> CreateDialogReportConfigInvoker(CreateDialogReportConfigRequest createDialogReportConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/dialog-report-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDialogReportConfigRequest);
            return new SyncInvoker<CreateDialogReportConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDialogReportConfigResponse>);
        }
        
        /// <summary>
        /// 删除对话结果上报配置
        ///
        /// 该接口用于删除对话结果上报配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDialogReportConfigResponse DeleteDialogReportConfig(DeleteDialogReportConfigRequest deleteDialogReportConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/dialog-report-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDialogReportConfigRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDialogReportConfigResponse>(response);
        }

        public SyncInvoker<DeleteDialogReportConfigResponse> DeleteDialogReportConfigInvoker(DeleteDialogReportConfigRequest deleteDialogReportConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/dialog-report-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDialogReportConfigRequest);
            return new SyncInvoker<DeleteDialogReportConfigResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDialogReportConfigResponse>);
        }
        
        /// <summary>
        /// 查询对话结果上报配置
        ///
        /// 该接口用于查询对话结果上报配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDialogReportConfigResponse ShowDialogReportConfig(ShowDialogReportConfigRequest showDialogReportConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/dialog-report-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDialogReportConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDialogReportConfigResponse>(response);
        }

        public SyncInvoker<ShowDialogReportConfigResponse> ShowDialogReportConfigInvoker(ShowDialogReportConfigRequest showDialogReportConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/dialog-report-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDialogReportConfigRequest);
            return new SyncInvoker<ShowDialogReportConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDialogReportConfigResponse>);
        }
        
        /// <summary>
        /// 修改对话结果上报配置
        ///
        /// 该接口用于修改对话结果上报配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDialogReportConfigResponse UpdateDialogReportConfig(UpdateDialogReportConfigRequest updateDialogReportConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/dialog-report-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDialogReportConfigRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDialogReportConfigResponse>(response);
        }

        public SyncInvoker<UpdateDialogReportConfigResponse> UpdateDialogReportConfigInvoker(UpdateDialogReportConfigRequest updateDialogReportConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/dialog-report-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDialogReportConfigRequest);
            return new SyncInvoker<UpdateDialogReportConfigResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDialogReportConfigResponse>);
        }
        
        /// <summary>
        /// 批量资产操作
        ///
        /// 该接口用批量资产操作。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchExecuteAssetActionResponse BatchExecuteAssetAction(BatchExecuteAssetActionRequest batchExecuteAssetActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets/batch-action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchExecuteAssetActionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchExecuteAssetActionResponse>(response);
        }

        public SyncInvoker<BatchExecuteAssetActionResponse> BatchExecuteAssetActionInvoker(BatchExecuteAssetActionRequest batchExecuteAssetActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets/batch-action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchExecuteAssetActionRequest);
            return new SyncInvoker<BatchExecuteAssetActionResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchExecuteAssetActionResponse>);
        }
        
        /// <summary>
        /// 复制资产
        ///
        /// 该接口用于在Region B复制Region A的指定资产。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAssetByReplicationInfoResponse CreateAssetByReplicationInfo(CreateAssetByReplicationInfoRequest createAssetByReplicationInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets-by-replication-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAssetByReplicationInfoRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateAssetByReplicationInfoResponse>(response);
        }

        public SyncInvoker<CreateAssetByReplicationInfoResponse> CreateAssetByReplicationInfoInvoker(CreateAssetByReplicationInfoRequest createAssetByReplicationInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets-by-replication-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAssetByReplicationInfoRequest);
            return new SyncInvoker<CreateAssetByReplicationInfoResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateAssetByReplicationInfoResponse>);
        }
        
        /// <summary>
        /// 创建资产
        ///
        /// 该接口用于在资产库中添加上传新的媒体资产。可上传的资产类型包括：分身数字人模型、背景图片、素材图片、素材视频、PPT等。
        /// &gt; 上传的图片、视频和背景图片，如果需要在视频制作素材中可见，需要设置system_properties。
        /// &gt; - 资产类型是IMAGE时，通过system_properties来区分背景图片（BACKGROUND_IMG）、素材图片（MATERIAL_IMG）。
        /// &gt; - 资产类型是VIDEO时，通过system_properties来区分素材视频（MATERIAL_VIDEO）、名片视频（BUSSINESS_CARD_VIDEO）。
        /// &gt; MetaStudio平台生成的视频，system_properties带CREATED_BY_PLATFORM。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDigitalAssetResponse CreateDigitalAsset(CreateDigitalAssetRequest createDigitalAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDigitalAssetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDigitalAssetResponse>(response);
        }

        public SyncInvoker<CreateDigitalAssetResponse> CreateDigitalAssetInvoker(CreateDigitalAssetRequest createDigitalAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDigitalAssetRequest);
            return new SyncInvoker<CreateDigitalAssetResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDigitalAssetResponse>);
        }
        
        /// <summary>
        /// 删除资产
        ///
        /// 该接口用于删除资产库中的媒体资产。调用该接口删除媒体资产时，媒体资产会放入回收站中，不会彻底删除。如需彻底删除资产，需增加“mode&#x3D;force”参数配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAssetResponse DeleteAsset(DeleteAssetRequest deleteAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("asset_id", deleteAssetRequest.AssetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets/{asset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAssetRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteAssetResponse>(response);
        }

        public SyncInvoker<DeleteAssetResponse> DeleteAssetInvoker(DeleteAssetRequest deleteAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("asset_id", deleteAssetRequest.AssetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets/{asset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAssetRequest);
            return new SyncInvoker<DeleteAssetResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteAssetResponse>);
        }
        
        /// <summary>
        /// 查询资产概要
        ///
        /// 该接口用于查询媒体资产库中指定的多个资产的概要信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAssetSummaryResponse ListAssetSummary(ListAssetSummaryRequest listAssetSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets/summarys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssetSummaryRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListAssetSummaryResponse>(response);
        }

        public SyncInvoker<ListAssetSummaryResponse> ListAssetSummaryInvoker(ListAssetSummaryRequest listAssetSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets/summarys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssetSummaryRequest);
            return new SyncInvoker<ListAssetSummaryResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAssetSummaryResponse>);
        }
        
        /// <summary>
        /// 查询资产列表
        ///
        /// 该接口用于查询资产库中的媒体资产列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAssetsResponse ListAssets(ListAssetsRequest listAssetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssetsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAssetsResponse>(response);
        }

        public SyncInvoker<ListAssetsResponse> ListAssetsInvoker(ListAssetsRequest listAssetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssetsRequest);
            return new SyncInvoker<ListAssetsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAssetsResponse>);
        }
        
        /// <summary>
        /// 恢复被删除的资产
        ///
        /// 该接口用于恢复被删除至回收站的媒体资产。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RestoreAssetResponse RestoreAsset(RestoreAssetRequest restoreAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("asset_id", restoreAssetRequest.AssetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets/{asset_id}/restore", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreAssetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<RestoreAssetResponse>(response);
        }

        public SyncInvoker<RestoreAssetResponse> RestoreAssetInvoker(RestoreAssetRequest restoreAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("asset_id", restoreAssetRequest.AssetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets/{asset_id}/restore", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", restoreAssetRequest);
            return new SyncInvoker<RestoreAssetResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RestoreAssetResponse>);
        }
        
        /// <summary>
        /// 查询资产详情
        ///
        /// 该接口用于查询资产库中指定媒体资产的详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAssetResponse ShowAsset(ShowAssetRequest showAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("asset_id", showAssetRequest.AssetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets/{asset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssetRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAssetResponse>(response);
        }

        public SyncInvoker<ShowAssetResponse> ShowAssetInvoker(ShowAssetRequest showAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("asset_id", showAssetRequest.AssetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets/{asset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssetRequest);
            return new SyncInvoker<ShowAssetResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAssetResponse>);
        }
        
        /// <summary>
        /// 查询资产复制信息
        ///
        /// 当需要将资产从A Region复制到B Region时，先要在A Region调用该接口用于查询资产复制信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAssetReplicationInfoResponse ShowAssetReplicationInfo(ShowAssetReplicationInfoRequest showAssetReplicationInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("asset_id", showAssetReplicationInfoRequest.AssetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets/{asset_id}/replication-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssetReplicationInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAssetReplicationInfoResponse>(response);
        }

        public SyncInvoker<ShowAssetReplicationInfoResponse> ShowAssetReplicationInfoInvoker(ShowAssetReplicationInfoRequest showAssetReplicationInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("asset_id", showAssetReplicationInfoRequest.AssetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets/{asset_id}/replication-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssetReplicationInfoRequest);
            return new SyncInvoker<ShowAssetReplicationInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAssetReplicationInfoResponse>);
        }
        
        /// <summary>
        /// 更新资产
        ///
        /// 该接口用于更新资产库中的媒体资产信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDigitalAssetResponse UpdateDigitalAsset(UpdateDigitalAssetRequest updateDigitalAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("asset_id", updateDigitalAssetRequest.AssetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets/{asset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDigitalAssetRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDigitalAssetResponse>(response);
        }

        public SyncInvoker<UpdateDigitalAssetResponse> UpdateDigitalAssetInvoker(UpdateDigitalAssetRequest updateDigitalAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("asset_id", updateDigitalAssetRequest.AssetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-assets/{asset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDigitalAssetRequest);
            return new SyncInvoker<UpdateDigitalAssetResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDigitalAssetResponse>);
        }
        
        /// <summary>
        /// 创建数字人名片制作
        ///
        /// 该接口用于数字人名片制作任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDigitalHumanBusinessCardResponse CreateDigitalHumanBusinessCard(CreateDigitalHumanBusinessCardRequest createDigitalHumanBusinessCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-business-cards", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDigitalHumanBusinessCardRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDigitalHumanBusinessCardResponse>(response);
        }

        public SyncInvoker<CreateDigitalHumanBusinessCardResponse> CreateDigitalHumanBusinessCardInvoker(CreateDigitalHumanBusinessCardRequest createDigitalHumanBusinessCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-business-cards", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDigitalHumanBusinessCardRequest);
            return new SyncInvoker<CreateDigitalHumanBusinessCardResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDigitalHumanBusinessCardResponse>);
        }
        
        /// <summary>
        /// 删除数字人名片制作任务
        ///
        /// 该接口用于删除数字人名片制作任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDigitalHumanBusinessCardResponse DeleteDigitalHumanBusinessCard(DeleteDigitalHumanBusinessCardRequest deleteDigitalHumanBusinessCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", deleteDigitalHumanBusinessCardRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-business-cards/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDigitalHumanBusinessCardRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDigitalHumanBusinessCardResponse>(response);
        }

        public SyncInvoker<DeleteDigitalHumanBusinessCardResponse> DeleteDigitalHumanBusinessCardInvoker(DeleteDigitalHumanBusinessCardRequest deleteDigitalHumanBusinessCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", deleteDigitalHumanBusinessCardRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-business-cards/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDigitalHumanBusinessCardRequest);
            return new SyncInvoker<DeleteDigitalHumanBusinessCardResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDigitalHumanBusinessCardResponse>);
        }
        
        /// <summary>
        /// 查询数字人名片制作任务列表
        ///
        /// 该接口用于查询数字人名片制作任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDigitalHumanBusinessCardResponse ListDigitalHumanBusinessCard(ListDigitalHumanBusinessCardRequest listDigitalHumanBusinessCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-business-cards", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDigitalHumanBusinessCardRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDigitalHumanBusinessCardResponse>(response);
        }

        public SyncInvoker<ListDigitalHumanBusinessCardResponse> ListDigitalHumanBusinessCardInvoker(ListDigitalHumanBusinessCardRequest listDigitalHumanBusinessCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-business-cards", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDigitalHumanBusinessCardRequest);
            return new SyncInvoker<ListDigitalHumanBusinessCardResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDigitalHumanBusinessCardResponse>);
        }
        
        /// <summary>
        /// 查询数字人名片制作任务详情
        ///
        /// 该接口用于查询数字人名片制作任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDigitalHumanBusinessCardResponse ShowDigitalHumanBusinessCard(ShowDigitalHumanBusinessCardRequest showDigitalHumanBusinessCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDigitalHumanBusinessCardRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-business-cards/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDigitalHumanBusinessCardRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDigitalHumanBusinessCardResponse>(response);
        }

        public SyncInvoker<ShowDigitalHumanBusinessCardResponse> ShowDigitalHumanBusinessCardInvoker(ShowDigitalHumanBusinessCardRequest showDigitalHumanBusinessCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDigitalHumanBusinessCardRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-business-cards/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDigitalHumanBusinessCardRequest);
            return new SyncInvoker<ShowDigitalHumanBusinessCardResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDigitalHumanBusinessCardResponse>);
        }
        
        /// <summary>
        /// 更新数字人名片制作
        ///
        /// 该接口用于更新数字人名片制作任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDigitalHumanBusinessCardResponse UpdateDigitalHumanBusinessCard(UpdateDigitalHumanBusinessCardRequest updateDigitalHumanBusinessCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", updateDigitalHumanBusinessCardRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-business-cards/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDigitalHumanBusinessCardRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDigitalHumanBusinessCardResponse>(response);
        }

        public SyncInvoker<UpdateDigitalHumanBusinessCardResponse> UpdateDigitalHumanBusinessCardInvoker(UpdateDigitalHumanBusinessCardRequest updateDigitalHumanBusinessCardRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", updateDigitalHumanBusinessCardRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-business-cards/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDigitalHumanBusinessCardRequest);
            return new SyncInvoker<UpdateDigitalHumanBusinessCardResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDigitalHumanBusinessCardResponse>);
        }
        
        /// <summary>
        /// 查询视频制作任务列表
        ///
        /// 该接口用于查询视频制作任务列表。可查询分身数字人视频制作列表，照片数字人视频制作列表等。
        /// &gt; - 默认查询最近一个月任务记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDigitalHumanVideoResponse ListDigitalHumanVideo(ListDigitalHumanVideoRequest listDigitalHumanVideoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-videos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDigitalHumanVideoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDigitalHumanVideoResponse>(response);
        }

        public SyncInvoker<ListDigitalHumanVideoResponse> ListDigitalHumanVideoInvoker(ListDigitalHumanVideoRequest listDigitalHumanVideoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-videos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDigitalHumanVideoRequest);
            return new SyncInvoker<ListDigitalHumanVideoResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDigitalHumanVideoResponse>);
        }
        
        /// <summary>
        /// 取消等待中的分身数字人视频制作任务
        ///
        /// 该接口用于取消等待中的分身数字人视频制作任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public Cancel2DDigitalHumanVideoResponse Cancel2DDigitalHumanVideo(Cancel2DDigitalHumanVideoRequest cancel2DDigitalHumanVideoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", cancel2DDigitalHumanVideoRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/2d-digital-human-videos/{job_id}/cancel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancel2DDigitalHumanVideoRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<Cancel2DDigitalHumanVideoResponse>(response);
        }

        public SyncInvoker<Cancel2DDigitalHumanVideoResponse> Cancel2DDigitalHumanVideoInvoker(Cancel2DDigitalHumanVideoRequest cancel2DDigitalHumanVideoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", cancel2DDigitalHumanVideoRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/2d-digital-human-videos/{job_id}/cancel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancel2DDigitalHumanVideoRequest);
            return new SyncInvoker<Cancel2DDigitalHumanVideoResponse>(this, "POST", request, JsonUtils.DeSerializeNull<Cancel2DDigitalHumanVideoResponse>);
        }
        
        /// <summary>
        /// 创建分身数字人视频制作任务
        ///
        /// 该接口用于创建分身数字人视频制作任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public Create2DDigitalHumanVideoResponse Create2DDigitalHumanVideo(Create2DDigitalHumanVideoRequest create2DDigitalHumanVideoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/2d-digital-human-videos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", create2DDigitalHumanVideoRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<Create2DDigitalHumanVideoResponse>(response);
        }

        public SyncInvoker<Create2DDigitalHumanVideoResponse> Create2DDigitalHumanVideoInvoker(Create2DDigitalHumanVideoRequest create2DDigitalHumanVideoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/2d-digital-human-videos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", create2DDigitalHumanVideoRequest);
            return new SyncInvoker<Create2DDigitalHumanVideoResponse>(this, "POST", request, JsonUtils.DeSerialize<Create2DDigitalHumanVideoResponse>);
        }
        
        /// <summary>
        /// 查询分身数字人视频制作任务详情
        ///
        /// 该接口用于查询分身数字人视频制作任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public Show2DDigitalHumanVideoResponse Show2DDigitalHumanVideo(Show2DDigitalHumanVideoRequest show2DDigitalHumanVideoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", show2DDigitalHumanVideoRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/2d-digital-human-videos/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", show2DDigitalHumanVideoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<Show2DDigitalHumanVideoResponse>(response);
        }

        public SyncInvoker<Show2DDigitalHumanVideoResponse> Show2DDigitalHumanVideoInvoker(Show2DDigitalHumanVideoRequest show2DDigitalHumanVideoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", show2DDigitalHumanVideoRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/2d-digital-human-videos/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", show2DDigitalHumanVideoRequest);
            return new SyncInvoker<Show2DDigitalHumanVideoResponse>(this, "GET", request, JsonUtils.DeSerialize<Show2DDigitalHumanVideoResponse>);
        }
        
        /// <summary>
        /// 取消等待中的照片分身数字人视频制作任务
        ///
        /// 该接口用于取消等待中的照片分身数字人视频制作任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CancelPhotoDigitalHumanVideoResponse CancelPhotoDigitalHumanVideo(CancelPhotoDigitalHumanVideoRequest cancelPhotoDigitalHumanVideoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", cancelPhotoDigitalHumanVideoRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/photo-digital-human-videos/{job_id}/cancel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelPhotoDigitalHumanVideoRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CancelPhotoDigitalHumanVideoResponse>(response);
        }

        public SyncInvoker<CancelPhotoDigitalHumanVideoResponse> CancelPhotoDigitalHumanVideoInvoker(CancelPhotoDigitalHumanVideoRequest cancelPhotoDigitalHumanVideoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", cancelPhotoDigitalHumanVideoRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/photo-digital-human-videos/{job_id}/cancel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelPhotoDigitalHumanVideoRequest);
            return new SyncInvoker<CancelPhotoDigitalHumanVideoResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CancelPhotoDigitalHumanVideoResponse>);
        }
        
        /// <summary>
        /// 创建照片检测任务
        ///
        /// 该接口用于创建照片检测任务，检测照片是否满足制作照片数字人的要求。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePhotoDetectionResponse CreatePhotoDetection(CreatePhotoDetectionRequest createPhotoDetectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/photo-detection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPhotoDetectionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePhotoDetectionResponse>(response);
        }

        public SyncInvoker<CreatePhotoDetectionResponse> CreatePhotoDetectionInvoker(CreatePhotoDetectionRequest createPhotoDetectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/photo-detection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPhotoDetectionRequest);
            return new SyncInvoker<CreatePhotoDetectionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePhotoDetectionResponse>);
        }
        
        /// <summary>
        /// 创建照片分身数字人视频制作任务
        ///
        /// 该接口用于创建照片分身数字人视频制作任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePhotoDigitalHumanVideoResponse CreatePhotoDigitalHumanVideo(CreatePhotoDigitalHumanVideoRequest createPhotoDigitalHumanVideoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/photo-digital-human-videos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPhotoDigitalHumanVideoRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePhotoDigitalHumanVideoResponse>(response);
        }

        public SyncInvoker<CreatePhotoDigitalHumanVideoResponse> CreatePhotoDigitalHumanVideoInvoker(CreatePhotoDigitalHumanVideoRequest createPhotoDigitalHumanVideoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/photo-digital-human-videos", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPhotoDigitalHumanVideoRequest);
            return new SyncInvoker<CreatePhotoDigitalHumanVideoResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePhotoDigitalHumanVideoResponse>);
        }
        
        /// <summary>
        /// 查询照片检测任务详情
        ///
        /// 该接口用于查询照片检测任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPhotoDetectionResponse ShowPhotoDetection(ShowPhotoDetectionRequest showPhotoDetectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showPhotoDetectionRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/photo-detection/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPhotoDetectionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPhotoDetectionResponse>(response);
        }

        public SyncInvoker<ShowPhotoDetectionResponse> ShowPhotoDetectionInvoker(ShowPhotoDetectionRequest showPhotoDetectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showPhotoDetectionRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/photo-detection/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPhotoDetectionRequest);
            return new SyncInvoker<ShowPhotoDetectionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPhotoDetectionResponse>);
        }
        
        /// <summary>
        /// 查询照片分身数字人视频制作任务详情
        ///
        /// 该接口用于查询照片分身数字人视频制作任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPhotoDigitalHumanVideoResponse ShowPhotoDigitalHumanVideo(ShowPhotoDigitalHumanVideoRequest showPhotoDigitalHumanVideoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showPhotoDigitalHumanVideoRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/photo-digital-human-videos/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPhotoDigitalHumanVideoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPhotoDigitalHumanVideoResponse>(response);
        }

        public SyncInvoker<ShowPhotoDigitalHumanVideoResponse> ShowPhotoDigitalHumanVideoInvoker(ShowPhotoDigitalHumanVideoRequest showPhotoDigitalHumanVideoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showPhotoDigitalHumanVideoRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/photo-digital-human-videos/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPhotoDigitalHumanVideoRequest);
            return new SyncInvoker<ShowPhotoDigitalHumanVideoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPhotoDigitalHumanVideoResponse>);
        }
        
        /// <summary>
        /// 确认文件已上传
        ///
        /// 资产文件上传完毕后，通过该接口确认上传完成。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ConfirmFileUploadResponse ConfirmFileUpload(ConfirmFileUploadRequest confirmFileUploadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("file_id", confirmFileUploadRequest.FileId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/files/{file_id}/complete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmFileUploadRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ConfirmFileUploadResponse>(response);
        }

        public SyncInvoker<ConfirmFileUploadResponse> ConfirmFileUploadInvoker(ConfirmFileUploadRequest confirmFileUploadRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("file_id", confirmFileUploadRequest.FileId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/files/{file_id}/complete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmFileUploadRequest);
            return new SyncInvoker<ConfirmFileUploadResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ConfirmFileUploadResponse>);
        }
        
        /// <summary>
        /// 创建文件并获取上传URL
        ///
        /// 该接口用于创建文件并获取上传URL。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateFileResponse CreateFile(CreateFileRequest createFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFileRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateFileResponse>(response);
        }

        public SyncInvoker<CreateFileResponse> CreateFileInvoker(CreateFileRequest createFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFileRequest);
            return new SyncInvoker<CreateFileResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateFileResponse>);
        }
        
        /// <summary>
        /// 创建大文件
        ///
        /// 该接口用于创建大文件（超过5G），获取分段上传URL。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateLargeFileResponse CreateLargeFile(CreateLargeFileRequest createLargeFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/large-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLargeFileRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateLargeFileResponse>(response);
        }

        public SyncInvoker<CreateLargeFileResponse> CreateLargeFileInvoker(CreateLargeFileRequest createLargeFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/large-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLargeFileRequest);
            return new SyncInvoker<CreateLargeFileResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateLargeFileResponse>);
        }
        
        /// <summary>
        /// 删除文件
        ///
        /// 该接口用于删除媒体资产库中指定的文件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteFileResponse DeleteFile(DeleteFileRequest deleteFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("file_id", deleteFileRequest.FileId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/files/{file_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFileRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteFileResponse>(response);
        }

        public SyncInvoker<DeleteFileResponse> DeleteFileInvoker(DeleteFileRequest deleteFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("file_id", deleteFileRequest.FileId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/files/{file_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFileRequest);
            return new SyncInvoker<DeleteFileResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteFileResponse>);
        }
        
        /// <summary>
        /// 创建热点问题
        ///
        /// 该接口用于创建热点问题。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateHotQuestionResponse CreateHotQuestion(CreateHotQuestionRequest createHotQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-question", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createHotQuestionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateHotQuestionResponse>(response);
        }

        public SyncInvoker<CreateHotQuestionResponse> CreateHotQuestionInvoker(CreateHotQuestionRequest createHotQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-question", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createHotQuestionRequest);
            return new SyncInvoker<CreateHotQuestionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateHotQuestionResponse>);
        }
        
        /// <summary>
        /// 删除热点问题
        ///
        /// 该接口用于删除热点问题。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteHotQuestionResponse DeleteHotQuestion(DeleteHotQuestionRequest deleteHotQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-question/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHotQuestionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteHotQuestionResponse>(response);
        }

        public SyncInvoker<DeleteHotQuestionResponse> DeleteHotQuestionInvoker(DeleteHotQuestionRequest deleteHotQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-question/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHotQuestionRequest);
            return new SyncInvoker<DeleteHotQuestionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteHotQuestionResponse>);
        }
        
        /// <summary>
        /// 查询热点问题列表
        ///
        /// 该接口用于查询热点问题列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListHotQuestionResponse ListHotQuestion(ListHotQuestionRequest listHotQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-question", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHotQuestionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListHotQuestionResponse>(response);
        }

        public SyncInvoker<ListHotQuestionResponse> ListHotQuestionInvoker(ListHotQuestionRequest listHotQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-question", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHotQuestionRequest);
            return new SyncInvoker<ListHotQuestionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHotQuestionResponse>);
        }
        
        /// <summary>
        /// 查询热点问题详情
        ///
        /// 该接口用于查询热点问题详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowHotQuestionResponse ShowHotQuestion(ShowHotQuestionRequest showHotQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("hot_question_id", showHotQuestionRequest.HotQuestionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-question/{hot_question_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHotQuestionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowHotQuestionResponse>(response);
        }

        public SyncInvoker<ShowHotQuestionResponse> ShowHotQuestionInvoker(ShowHotQuestionRequest showHotQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("hot_question_id", showHotQuestionRequest.HotQuestionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-question/{hot_question_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHotQuestionRequest);
            return new SyncInvoker<ShowHotQuestionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHotQuestionResponse>);
        }
        
        /// <summary>
        /// 修改热点问题
        ///
        /// 该接口用于修改热点问题。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateHotQuestionResponse UpdateHotQuestion(UpdateHotQuestionRequest updateHotQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("hot_question_id", updateHotQuestionRequest.HotQuestionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-question/{hot_question_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHotQuestionRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateHotQuestionResponse>(response);
        }

        public SyncInvoker<UpdateHotQuestionResponse> UpdateHotQuestionInvoker(UpdateHotQuestionRequest updateHotQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("hot_question_id", updateHotQuestionRequest.HotQuestionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-question/{hot_question_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHotQuestionRequest);
            return new SyncInvoker<UpdateHotQuestionResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateHotQuestionResponse>);
        }
        
        /// <summary>
        /// 创建热词记录
        ///
        /// 该接口用于创建热词记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateHotWordsResponse CreateHotWords(CreateHotWordsRequest createHotWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-words", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createHotWordsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateHotWordsResponse>(response);
        }

        public SyncInvoker<CreateHotWordsResponse> CreateHotWordsInvoker(CreateHotWordsRequest createHotWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-words", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createHotWordsRequest);
            return new SyncInvoker<CreateHotWordsResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateHotWordsResponse>);
        }
        
        /// <summary>
        /// 删除热词记录
        ///
        /// 该接口用于删除热词记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteHotWordsResponse DeleteHotWords(DeleteHotWordsRequest deleteHotWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("hot_words_id", deleteHotWordsRequest.HotWordsId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-words/{hot_words_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHotWordsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteHotWordsResponse>(response);
        }

        public SyncInvoker<DeleteHotWordsResponse> DeleteHotWordsInvoker(DeleteHotWordsRequest deleteHotWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("hot_words_id", deleteHotWordsRequest.HotWordsId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-words/{hot_words_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHotWordsRequest);
            return new SyncInvoker<DeleteHotWordsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteHotWordsResponse>);
        }
        
        /// <summary>
        /// 查询热词记录列表
        ///
        /// 该接口用于查询热词记录列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListHotWordsResponse ListHotWords(ListHotWordsRequest listHotWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-words", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHotWordsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListHotWordsResponse>(response);
        }

        public SyncInvoker<ListHotWordsResponse> ListHotWordsInvoker(ListHotWordsRequest listHotWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-words", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHotWordsRequest);
            return new SyncInvoker<ListHotWordsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHotWordsResponse>);
        }
        
        /// <summary>
        /// 查询配置热词记录详情
        ///
        /// 该接口用于查询热词记录详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowHotWordsResponse ShowHotWords(ShowHotWordsRequest showHotWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("hot_words_id", showHotWordsRequest.HotWordsId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-words/{hot_words_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHotWordsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowHotWordsResponse>(response);
        }

        public SyncInvoker<ShowHotWordsResponse> ShowHotWordsInvoker(ShowHotWordsRequest showHotWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("hot_words_id", showHotWordsRequest.HotWordsId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-words/{hot_words_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHotWordsRequest);
            return new SyncInvoker<ShowHotWordsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHotWordsResponse>);
        }
        
        /// <summary>
        /// 查询热词功能开关
        ///
        /// 该接口用于查询热词功能开关。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowHotWordsSwitchResponse ShowHotWordsSwitch(ShowHotWordsSwitchRequest showHotWordsSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-words-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHotWordsSwitchRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowHotWordsSwitchResponse>(response);
        }

        public SyncInvoker<ShowHotWordsSwitchResponse> ShowHotWordsSwitchInvoker(ShowHotWordsSwitchRequest showHotWordsSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-words-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHotWordsSwitchRequest);
            return new SyncInvoker<ShowHotWordsSwitchResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHotWordsSwitchResponse>);
        }
        
        /// <summary>
        /// 修改热词记录
        ///
        /// 该接口用于修改热词记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateHotWordsResponse UpdateHotWords(UpdateHotWordsRequest updateHotWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("hot_words_id", updateHotWordsRequest.HotWordsId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-words/{hot_words_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHotWordsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateHotWordsResponse>(response);
        }

        public SyncInvoker<UpdateHotWordsResponse> UpdateHotWordsInvoker(UpdateHotWordsRequest updateHotWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("hot_words_id", updateHotWordsRequest.HotWordsId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-words/{hot_words_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHotWordsRequest);
            return new SyncInvoker<UpdateHotWordsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateHotWordsResponse>);
        }
        
        /// <summary>
        /// 修改热词功能开关
        ///
        /// 该接口用于修改热词功能开关。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateHotWordsSwitchResponse UpdateHotWordsSwitch(UpdateHotWordsSwitchRequest updateHotWordsSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-words-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHotWordsSwitchRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateHotWordsSwitchResponse>(response);
        }

        public SyncInvoker<UpdateHotWordsSwitchResponse> UpdateHotWordsSwitchInvoker(UpdateHotWordsSwitchRequest updateHotWordsSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/hot-words-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHotWordsSwitchRequest);
            return new SyncInvoker<UpdateHotWordsSwitchResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateHotWordsSwitchResponse>);
        }
        
        /// <summary>
        /// 创建智能直播间互动规则库
        ///
        /// 该接口用于创建智能直播间互动规则库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateInteractionRuleGroupResponse CreateInteractionRuleGroup(CreateInteractionRuleGroupRequest createInteractionRuleGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-interaction-rule-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInteractionRuleGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateInteractionRuleGroupResponse>(response);
        }

        public SyncInvoker<CreateInteractionRuleGroupResponse> CreateInteractionRuleGroupInvoker(CreateInteractionRuleGroupRequest createInteractionRuleGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-interaction-rule-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createInteractionRuleGroupRequest);
            return new SyncInvoker<CreateInteractionRuleGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateInteractionRuleGroupResponse>);
        }
        
        /// <summary>
        /// 删除智能直播间互动规则库
        ///
        /// 该接口用于删除智能直播间互动规则库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteInteractionRuleGroupResponse DeleteInteractionRuleGroup(DeleteInteractionRuleGroupRequest deleteInteractionRuleGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", deleteInteractionRuleGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-interaction-rule-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInteractionRuleGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteInteractionRuleGroupResponse>(response);
        }

        public SyncInvoker<DeleteInteractionRuleGroupResponse> DeleteInteractionRuleGroupInvoker(DeleteInteractionRuleGroupRequest deleteInteractionRuleGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", deleteInteractionRuleGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-interaction-rule-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteInteractionRuleGroupRequest);
            return new SyncInvoker<DeleteInteractionRuleGroupResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteInteractionRuleGroupResponse>);
        }
        
        /// <summary>
        /// 查询智能直播间互动规则库列表
        ///
        /// 该接口用于智能直播间互动规则库列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInteractionRuleGroupsResponse ListInteractionRuleGroups(ListInteractionRuleGroupsRequest listInteractionRuleGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-interaction-rule-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInteractionRuleGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInteractionRuleGroupsResponse>(response);
        }

        public SyncInvoker<ListInteractionRuleGroupsResponse> ListInteractionRuleGroupsInvoker(ListInteractionRuleGroupsRequest listInteractionRuleGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-interaction-rule-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInteractionRuleGroupsRequest);
            return new SyncInvoker<ListInteractionRuleGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInteractionRuleGroupsResponse>);
        }
        
        /// <summary>
        /// 更新智能直播间互动规则库
        ///
        /// 该接口用于更新智能直播间互动规则库。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateInteractionRuleGroupResponse UpdateInteractionRuleGroup(UpdateInteractionRuleGroupRequest updateInteractionRuleGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", updateInteractionRuleGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-interaction-rule-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInteractionRuleGroupRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateInteractionRuleGroupResponse>(response);
        }

        public SyncInvoker<UpdateInteractionRuleGroupResponse> UpdateInteractionRuleGroupInvoker(UpdateInteractionRuleGroupRequest updateInteractionRuleGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("group_id", updateInteractionRuleGroupRequest.GroupId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-interaction-rule-groups/{group_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateInteractionRuleGroupRequest);
            return new SyncInvoker<UpdateInteractionRuleGroupResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateInteractionRuleGroupResponse>);
        }
        
        /// <summary>
        /// 创建知识库意图和问法
        ///
        /// 该接口用于创建知识库意图和问法。一个意图包含一个主题，一个答案，若干个问法等。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateIntentAndQuestionResponse CreateIntentAndQuestion(CreateIntentAndQuestionRequest createIntentAndQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/intent-question", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createIntentAndQuestionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateIntentAndQuestionResponse>(response);
        }

        public SyncInvoker<CreateIntentAndQuestionResponse> CreateIntentAndQuestionInvoker(CreateIntentAndQuestionRequest createIntentAndQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/intent-question", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createIntentAndQuestionRequest);
            return new SyncInvoker<CreateIntentAndQuestionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateIntentAndQuestionResponse>);
        }
        
        /// <summary>
        /// 创建知识库意图
        ///
        /// 该接口用于创建知识库意图。一个意图包含一个主题，一个答案，若干个问法等。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateKnowledgeIntentResponse CreateKnowledgeIntent(CreateKnowledgeIntentRequest createKnowledgeIntentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/intent", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKnowledgeIntentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateKnowledgeIntentResponse>(response);
        }

        public SyncInvoker<CreateKnowledgeIntentResponse> CreateKnowledgeIntentInvoker(CreateKnowledgeIntentRequest createKnowledgeIntentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/intent", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKnowledgeIntentRequest);
            return new SyncInvoker<CreateKnowledgeIntentResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateKnowledgeIntentResponse>);
        }
        
        /// <summary>
        /// 删除知识库意图
        ///
        /// 该接口用于删除知识库意图。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteKnowledgeIntentResponse DeleteKnowledgeIntent(DeleteKnowledgeIntentRequest deleteKnowledgeIntentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/intent/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKnowledgeIntentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteKnowledgeIntentResponse>(response);
        }

        public SyncInvoker<DeleteKnowledgeIntentResponse> DeleteKnowledgeIntentInvoker(DeleteKnowledgeIntentRequest deleteKnowledgeIntentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/intent/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKnowledgeIntentRequest);
            return new SyncInvoker<DeleteKnowledgeIntentResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteKnowledgeIntentResponse>);
        }
        
        /// <summary>
        /// 查询知识库意图列表
        ///
        /// 该接口用于查询知识库意图列表。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListKnowledgeIntentResponse ListKnowledgeIntent(ListKnowledgeIntentRequest listKnowledgeIntentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/intent", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKnowledgeIntentRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListKnowledgeIntentResponse>(response);
        }

        public SyncInvoker<ListKnowledgeIntentResponse> ListKnowledgeIntentInvoker(ListKnowledgeIntentRequest listKnowledgeIntentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/intent", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKnowledgeIntentRequest);
            return new SyncInvoker<ListKnowledgeIntentResponse>(this, "GET", request, JsonUtils.DeSerialize<ListKnowledgeIntentResponse>);
        }
        
        /// <summary>
        /// 查询知识库意图详情
        ///
        /// 该接口用于查询知识库意图详情。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowKnowledgeIntentResponse ShowKnowledgeIntent(ShowKnowledgeIntentRequest showKnowledgeIntentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("intent_id", showKnowledgeIntentRequest.IntentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/intent/{intent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKnowledgeIntentRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowKnowledgeIntentResponse>(response);
        }

        public SyncInvoker<ShowKnowledgeIntentResponse> ShowKnowledgeIntentInvoker(ShowKnowledgeIntentRequest showKnowledgeIntentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("intent_id", showKnowledgeIntentRequest.IntentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/intent/{intent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKnowledgeIntentRequest);
            return new SyncInvoker<ShowKnowledgeIntentResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowKnowledgeIntentResponse>);
        }
        
        /// <summary>
        /// 修改知识库意图
        ///
        /// 该接口用于修改知识库意图。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateKnowledgeIntentResponse UpdateKnowledgeIntent(UpdateKnowledgeIntentRequest updateKnowledgeIntentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("intent_id", updateKnowledgeIntentRequest.IntentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/intent/{intent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateKnowledgeIntentRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateKnowledgeIntentResponse>(response);
        }

        public SyncInvoker<UpdateKnowledgeIntentResponse> UpdateKnowledgeIntentInvoker(UpdateKnowledgeIntentRequest updateKnowledgeIntentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("intent_id", updateKnowledgeIntentRequest.IntentId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/intent/{intent_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateKnowledgeIntentRequest);
            return new SyncInvoker<UpdateKnowledgeIntentResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateKnowledgeIntentResponse>);
        }
        
        /// <summary>
        /// 批量创建知识库问法
        ///
        /// 该接口用于批量创建知识库问法。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateBatchKnowledgeQuestionResponse CreateBatchKnowledgeQuestion(CreateBatchKnowledgeQuestionRequest createBatchKnowledgeQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/question-batch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBatchKnowledgeQuestionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateBatchKnowledgeQuestionResponse>(response);
        }

        public SyncInvoker<CreateBatchKnowledgeQuestionResponse> CreateBatchKnowledgeQuestionInvoker(CreateBatchKnowledgeQuestionRequest createBatchKnowledgeQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/question-batch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBatchKnowledgeQuestionRequest);
            return new SyncInvoker<CreateBatchKnowledgeQuestionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateBatchKnowledgeQuestionResponse>);
        }
        
        /// <summary>
        /// 创建知识库问法
        ///
        /// 该接口用于创建知识库问法。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateKnowledgeQuestionResponse CreateKnowledgeQuestion(CreateKnowledgeQuestionRequest createKnowledgeQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/question", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKnowledgeQuestionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateKnowledgeQuestionResponse>(response);
        }

        public SyncInvoker<CreateKnowledgeQuestionResponse> CreateKnowledgeQuestionInvoker(CreateKnowledgeQuestionRequest createKnowledgeQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/question", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKnowledgeQuestionRequest);
            return new SyncInvoker<CreateKnowledgeQuestionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateKnowledgeQuestionResponse>);
        }
        
        /// <summary>
        /// 删除知识库问法
        ///
        /// 该接口用于删除知识库问法。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteKnowledgeQuestionResponse DeleteKnowledgeQuestion(DeleteKnowledgeQuestionRequest deleteKnowledgeQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/question/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKnowledgeQuestionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteKnowledgeQuestionResponse>(response);
        }

        public SyncInvoker<DeleteKnowledgeQuestionResponse> DeleteKnowledgeQuestionInvoker(DeleteKnowledgeQuestionRequest deleteKnowledgeQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/question/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKnowledgeQuestionRequest);
            return new SyncInvoker<DeleteKnowledgeQuestionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteKnowledgeQuestionResponse>);
        }
        
        /// <summary>
        /// 查询知识库问法列表
        ///
        /// 该接口用于查询知识库问法列表。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListKnowledgeQuestionResponse ListKnowledgeQuestion(ListKnowledgeQuestionRequest listKnowledgeQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/question", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKnowledgeQuestionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListKnowledgeQuestionResponse>(response);
        }

        public SyncInvoker<ListKnowledgeQuestionResponse> ListKnowledgeQuestionInvoker(ListKnowledgeQuestionRequest listKnowledgeQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/question", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKnowledgeQuestionRequest);
            return new SyncInvoker<ListKnowledgeQuestionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListKnowledgeQuestionResponse>);
        }
        
        /// <summary>
        /// 查询知识库问法详情
        ///
        /// 该接口用于查询知识库问法详情。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowKnowledgeQuestionResponse ShowKnowledgeQuestion(ShowKnowledgeQuestionRequest showKnowledgeQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("question_id", showKnowledgeQuestionRequest.QuestionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/question/{question_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKnowledgeQuestionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowKnowledgeQuestionResponse>(response);
        }

        public SyncInvoker<ShowKnowledgeQuestionResponse> ShowKnowledgeQuestionInvoker(ShowKnowledgeQuestionRequest showKnowledgeQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("question_id", showKnowledgeQuestionRequest.QuestionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/question/{question_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKnowledgeQuestionRequest);
            return new SyncInvoker<ShowKnowledgeQuestionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowKnowledgeQuestionResponse>);
        }
        
        /// <summary>
        /// 批量修改知识库问法
        ///
        /// 该接口用于批量修改知识库问法。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateBatchKnowledgeQuestionResponse UpdateBatchKnowledgeQuestion(UpdateBatchKnowledgeQuestionRequest updateBatchKnowledgeQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/question-batch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBatchKnowledgeQuestionRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateBatchKnowledgeQuestionResponse>(response);
        }

        public SyncInvoker<UpdateBatchKnowledgeQuestionResponse> UpdateBatchKnowledgeQuestionInvoker(UpdateBatchKnowledgeQuestionRequest updateBatchKnowledgeQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/question-batch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBatchKnowledgeQuestionRequest);
            return new SyncInvoker<UpdateBatchKnowledgeQuestionResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateBatchKnowledgeQuestionResponse>);
        }
        
        /// <summary>
        /// 修改知识库问法
        ///
        /// 该接口用于修改知识库问法。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateKnowledgeQuestionResponse UpdateKnowledgeQuestion(UpdateKnowledgeQuestionRequest updateKnowledgeQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("question_id", updateKnowledgeQuestionRequest.QuestionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/question/{question_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateKnowledgeQuestionRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateKnowledgeQuestionResponse>(response);
        }

        public SyncInvoker<UpdateKnowledgeQuestionResponse> UpdateKnowledgeQuestionInvoker(UpdateKnowledgeQuestionRequest updateKnowledgeQuestionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("question_id", updateKnowledgeQuestionRequest.QuestionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/question/{question_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateKnowledgeQuestionRequest);
            return new SyncInvoker<UpdateKnowledgeQuestionResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateKnowledgeQuestionResponse>);
        }
        
        /// <summary>
        /// 创建知识库技能
        ///
        /// 该接口用于创建知识库技能。一个技能用于特定场景的交互问答，包含若干个意图等。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateKnowledgeSkillResponse CreateKnowledgeSkill(CreateKnowledgeSkillRequest createKnowledgeSkillRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/skill", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKnowledgeSkillRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateKnowledgeSkillResponse>(response);
        }

        public SyncInvoker<CreateKnowledgeSkillResponse> CreateKnowledgeSkillInvoker(CreateKnowledgeSkillRequest createKnowledgeSkillRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/skill", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKnowledgeSkillRequest);
            return new SyncInvoker<CreateKnowledgeSkillResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateKnowledgeSkillResponse>);
        }
        
        /// <summary>
        /// 删除知识库技能
        ///
        /// 该接口用于删除知识库技能。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteKnowledgeSkillResponse DeleteKnowledgeSkill(DeleteKnowledgeSkillRequest deleteKnowledgeSkillRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/skill/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKnowledgeSkillRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteKnowledgeSkillResponse>(response);
        }

        public SyncInvoker<DeleteKnowledgeSkillResponse> DeleteKnowledgeSkillInvoker(DeleteKnowledgeSkillRequest deleteKnowledgeSkillRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/skill/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteKnowledgeSkillRequest);
            return new SyncInvoker<DeleteKnowledgeSkillResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteKnowledgeSkillResponse>);
        }
        
        /// <summary>
        /// 导出知识库技能
        ///
        /// 该接口用于导出知识库技能。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExportKnowledgeSkillResponse ExportKnowledgeSkill(ExportKnowledgeSkillRequest exportKnowledgeSkillRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("skill_id", exportKnowledgeSkillRequest.SkillId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/skill/{skill_id}/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportKnowledgeSkillRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ExportKnowledgeSkillResponse>(response);
        }

        public SyncInvoker<ExportKnowledgeSkillResponse> ExportKnowledgeSkillInvoker(ExportKnowledgeSkillRequest exportKnowledgeSkillRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("skill_id", exportKnowledgeSkillRequest.SkillId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/skill/{skill_id}/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportKnowledgeSkillRequest);
            return new SyncInvoker<ExportKnowledgeSkillResponse>(this, "GET", request, JsonUtils.DeSerialize<ExportKnowledgeSkillResponse>);
        }
        
        /// <summary>
        /// 查询知识库技能列表
        ///
        /// 该接口用于查询知识库技能列表。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListKnowledgeSkillResponse ListKnowledgeSkill(ListKnowledgeSkillRequest listKnowledgeSkillRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/skill", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKnowledgeSkillRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListKnowledgeSkillResponse>(response);
        }

        public SyncInvoker<ListKnowledgeSkillResponse> ListKnowledgeSkillInvoker(ListKnowledgeSkillRequest listKnowledgeSkillRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/skill", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKnowledgeSkillRequest);
            return new SyncInvoker<ListKnowledgeSkillResponse>(this, "GET", request, JsonUtils.DeSerialize<ListKnowledgeSkillResponse>);
        }
        
        /// <summary>
        /// 查询知识库技能详情
        ///
        /// 该接口用于查询知识库技能详情。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowKnowledgeSkillResponse ShowKnowledgeSkill(ShowKnowledgeSkillRequest showKnowledgeSkillRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("skill_id", showKnowledgeSkillRequest.SkillId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/skill/{skill_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKnowledgeSkillRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowKnowledgeSkillResponse>(response);
        }

        public SyncInvoker<ShowKnowledgeSkillResponse> ShowKnowledgeSkillInvoker(ShowKnowledgeSkillRequest showKnowledgeSkillRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("skill_id", showKnowledgeSkillRequest.SkillId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/skill/{skill_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKnowledgeSkillRequest);
            return new SyncInvoker<ShowKnowledgeSkillResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowKnowledgeSkillResponse>);
        }
        
        /// <summary>
        /// 修改知识库技能
        ///
        /// 该接口用于修改知识库技能。接口使用限制详见[API使用限制](metastudio_02_0000.xml)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateKnowledgeSkillResponse UpdateKnowledgeSkill(UpdateKnowledgeSkillRequest updateKnowledgeSkillRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("skill_id", updateKnowledgeSkillRequest.SkillId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/skill/{skill_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateKnowledgeSkillRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateKnowledgeSkillResponse>(response);
        }

        public SyncInvoker<UpdateKnowledgeSkillResponse> UpdateKnowledgeSkillInvoker(UpdateKnowledgeSkillRequest updateKnowledgeSkillRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("skill_id", updateKnowledgeSkillRequest.SkillId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/knowledge/skill/{skill_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateKnowledgeSkillRequest);
            return new SyncInvoker<UpdateKnowledgeSkillResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateKnowledgeSkillResponse>);
        }
        
        /// <summary>
        /// 创建第三方直播平台
        ///
        /// 该接口用于创建第三方直播平台。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateLivePlatformResponse CreateLivePlatform(CreateLivePlatformRequest createLivePlatformRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-platforms/platforms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLivePlatformRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateLivePlatformResponse>(response);
        }

        public SyncInvoker<CreateLivePlatformResponse> CreateLivePlatformInvoker(CreateLivePlatformRequest createLivePlatformRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-platforms/platforms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createLivePlatformRequest);
            return new SyncInvoker<CreateLivePlatformResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateLivePlatformResponse>);
        }
        
        /// <summary>
        /// 删除第三方直播平台信息
        ///
        /// 该接口用于删除第三方直播平台信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteLivePlatformResponse DeleteLivePlatform(DeleteLivePlatformRequest deleteLivePlatformRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("platform_id", deleteLivePlatformRequest.PlatformId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-platforms/platforms/{platform_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLivePlatformRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteLivePlatformResponse>(response);
        }

        public SyncInvoker<DeleteLivePlatformResponse> DeleteLivePlatformInvoker(DeleteLivePlatformRequest deleteLivePlatformRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("platform_id", deleteLivePlatformRequest.PlatformId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-platforms/platforms/{platform_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLivePlatformRequest);
            return new SyncInvoker<DeleteLivePlatformResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteLivePlatformResponse>);
        }
        
        /// <summary>
        /// 查询第三方直播平台商品列表
        ///
        /// 该接口用于查询第三方直播平台商品列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLivePlatformProductsResponse ListLivePlatformProducts(ListLivePlatformProductsRequest listLivePlatformProductsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-platforms/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLivePlatformProductsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListLivePlatformProductsResponse>(response);
        }

        public SyncInvoker<ListLivePlatformProductsResponse> ListLivePlatformProductsInvoker(ListLivePlatformProductsRequest listLivePlatformProductsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-platforms/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLivePlatformProductsRequest);
            return new SyncInvoker<ListLivePlatformProductsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLivePlatformProductsResponse>);
        }
        
        /// <summary>
        /// 查询直播平台列表
        ///
        /// 该接口用于查询直播平台列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLivePlatformsResponse ListLivePlatforms(ListLivePlatformsRequest listLivePlatformsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-platforms/platforms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLivePlatformsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListLivePlatformsResponse>(response);
        }

        public SyncInvoker<ListLivePlatformsResponse> ListLivePlatformsInvoker(ListLivePlatformsRequest listLivePlatformsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-platforms/platforms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLivePlatformsRequest);
            return new SyncInvoker<ListLivePlatformsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLivePlatformsResponse>);
        }
        
        /// <summary>
        /// 查询第三方直播平台信息
        ///
        /// 该接口用于查询第三方直播平台信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowLivePlatformResponse ShowLivePlatform(ShowLivePlatformRequest showLivePlatformRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("platform_id", showLivePlatformRequest.PlatformId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-platforms/platforms/{platform_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLivePlatformRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowLivePlatformResponse>(response);
        }

        public SyncInvoker<ShowLivePlatformResponse> ShowLivePlatformInvoker(ShowLivePlatformRequest showLivePlatformRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("platform_id", showLivePlatformRequest.PlatformId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-platforms/platforms/{platform_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLivePlatformRequest);
            return new SyncInvoker<ShowLivePlatformResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLivePlatformResponse>);
        }
        
        /// <summary>
        /// 更新第三方直播平台信息
        ///
        /// 该接口用于更新第三方直播平台信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateLivePlatformResponse UpdateLivePlatform(UpdateLivePlatformRequest updateLivePlatformRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("platform_id", updateLivePlatformRequest.PlatformId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-platforms/platforms/{platform_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLivePlatformRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateLivePlatformResponse>(response);
        }

        public SyncInvoker<UpdateLivePlatformResponse> UpdateLivePlatformInvoker(UpdateLivePlatformRequest updateLivePlatformRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("platform_id", updateLivePlatformRequest.PlatformId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/live-platforms/platforms/{platform_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateLivePlatformRequest);
            return new SyncInvoker<UpdateLivePlatformResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateLivePlatformResponse>);
        }
        
        /// <summary>
        /// 创建一次性鉴权码
        ///
        /// 该接口用于创建一次性鉴权码，有效期5分钟，鉴权码只能使用一次，每次使用后需要重新获取。
        /// &gt; 接口只能通过第三方后台调用，不能在浏览器前台直接调用，否则会有跨域问题。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateOnceCodeResponse CreateOnceCode(CreateOnceCodeRequest createOnceCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/once-code", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOnceCodeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateOnceCodeResponse>(response);
        }

        public SyncInvoker<CreateOnceCodeResponse> CreateOnceCodeInvoker(CreateOnceCodeRequest createOnceCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/once-code", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createOnceCodeRequest);
            return new SyncInvoker<CreateOnceCodeResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateOnceCodeResponse>);
        }
        
        /// <summary>
        /// 订购metastudio云服务产品
        ///
        /// 该接口用于订购MetaStudio服务的包周期,一次性,按需套餐包产品
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateMetaStudioOrdersResponse CreateMetaStudioOrders(CreateMetaStudioOrdersRequest createMetaStudioOrdersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/mss/public/orders", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMetaStudioOrdersRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateMetaStudioOrdersResponse>(response);
        }

        public SyncInvoker<CreateMetaStudioOrdersResponse> CreateMetaStudioOrdersInvoker(CreateMetaStudioOrdersRequest createMetaStudioOrdersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/mss/public/orders", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createMetaStudioOrdersRequest);
            return new SyncInvoker<CreateMetaStudioOrdersResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateMetaStudioOrdersResponse>);
        }
        
        /// <summary>
        /// 批量删除安抚话术
        ///
        /// 该接口用于批量删除安抚话术。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeletePacifyWordsResponse BatchDeletePacifyWords(BatchDeletePacifyWordsRequest batchDeletePacifyWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeletePacifyWordsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeletePacifyWordsResponse>(response);
        }

        public SyncInvoker<BatchDeletePacifyWordsResponse> BatchDeletePacifyWordsInvoker(BatchDeletePacifyWordsRequest batchDeletePacifyWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeletePacifyWordsRequest);
            return new SyncInvoker<BatchDeletePacifyWordsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeletePacifyWordsResponse>);
        }
        
        /// <summary>
        /// 创建安抚话术
        ///
        /// 该接口用于创建安抚话术。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePacifyWordsResponse CreatePacifyWords(CreatePacifyWordsRequest createPacifyWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPacifyWordsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePacifyWordsResponse>(response);
        }

        public SyncInvoker<CreatePacifyWordsResponse> CreatePacifyWordsInvoker(CreatePacifyWordsRequest createPacifyWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPacifyWordsRequest);
            return new SyncInvoker<CreatePacifyWordsResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePacifyWordsResponse>);
        }
        
        /// <summary>
        /// 删除安抚话术
        ///
        /// 该接口用于删除安抚话术。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePacifyWordsResponse DeletePacifyWords(DeletePacifyWordsRequest deletePacifyWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pacify_words_id", deletePacifyWordsRequest.PacifyWordsId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words/{pacify_words_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePacifyWordsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePacifyWordsResponse>(response);
        }

        public SyncInvoker<DeletePacifyWordsResponse> DeletePacifyWordsInvoker(DeletePacifyWordsRequest deletePacifyWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pacify_words_id", deletePacifyWordsRequest.PacifyWordsId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words/{pacify_words_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePacifyWordsRequest);
            return new SyncInvoker<DeletePacifyWordsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePacifyWordsResponse>);
        }
        
        /// <summary>
        /// 查询安抚话术列表
        ///
        /// 该接口用于查询安抚话术列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPacifyWordsResponse ListPacifyWords(ListPacifyWordsRequest listPacifyWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPacifyWordsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPacifyWordsResponse>(response);
        }

        public SyncInvoker<ListPacifyWordsResponse> ListPacifyWordsInvoker(ListPacifyWordsRequest listPacifyWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPacifyWordsRequest);
            return new SyncInvoker<ListPacifyWordsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPacifyWordsResponse>);
        }
        
        /// <summary>
        /// 查询安抚话术详情
        ///
        /// 该接口用于查询安抚话术详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPacifyWordsResponse ShowPacifyWords(ShowPacifyWordsRequest showPacifyWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pacify_words_id", showPacifyWordsRequest.PacifyWordsId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words/{pacify_words_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPacifyWordsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPacifyWordsResponse>(response);
        }

        public SyncInvoker<ShowPacifyWordsResponse> ShowPacifyWordsInvoker(ShowPacifyWordsRequest showPacifyWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pacify_words_id", showPacifyWordsRequest.PacifyWordsId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words/{pacify_words_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPacifyWordsRequest);
            return new SyncInvoker<ShowPacifyWordsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPacifyWordsResponse>);
        }
        
        /// <summary>
        /// 查询安抚话术意图
        ///
        /// 该接口用于查询安抚话术意图。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPacifyWordsIntentResponse ShowPacifyWordsIntent(ShowPacifyWordsIntentRequest showPacifyWordsIntentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words-intent", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPacifyWordsIntentRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPacifyWordsIntentResponse>(response);
        }

        public SyncInvoker<ShowPacifyWordsIntentResponse> ShowPacifyWordsIntentInvoker(ShowPacifyWordsIntentRequest showPacifyWordsIntentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words-intent", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPacifyWordsIntentRequest);
            return new SyncInvoker<ShowPacifyWordsIntentResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPacifyWordsIntentResponse>);
        }
        
        /// <summary>
        /// 查询安抚话术功能开关
        ///
        /// 该接口用于查询安抚话术功能开关。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPacifyWordsSwitchResponse ShowPacifyWordsSwitch(ShowPacifyWordsSwitchRequest showPacifyWordsSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPacifyWordsSwitchRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPacifyWordsSwitchResponse>(response);
        }

        public SyncInvoker<ShowPacifyWordsSwitchResponse> ShowPacifyWordsSwitchInvoker(ShowPacifyWordsSwitchRequest showPacifyWordsSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPacifyWordsSwitchRequest);
            return new SyncInvoker<ShowPacifyWordsSwitchResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPacifyWordsSwitchResponse>);
        }
        
        /// <summary>
        /// 查询安抚话术等待触发时长
        ///
        /// 该接口用于查询等待触发时长。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPacifyWordsTriggerTimeResponse ShowPacifyWordsTriggerTime(ShowPacifyWordsTriggerTimeRequest showPacifyWordsTriggerTimeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words-time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPacifyWordsTriggerTimeRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPacifyWordsTriggerTimeResponse>(response);
        }

        public SyncInvoker<ShowPacifyWordsTriggerTimeResponse> ShowPacifyWordsTriggerTimeInvoker(ShowPacifyWordsTriggerTimeRequest showPacifyWordsTriggerTimeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words-time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPacifyWordsTriggerTimeRequest);
            return new SyncInvoker<ShowPacifyWordsTriggerTimeResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPacifyWordsTriggerTimeResponse>);
        }
        
        /// <summary>
        /// 修改安抚话术
        ///
        /// 该接口用于修改安抚话术。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePacifyWordsResponse UpdatePacifyWords(UpdatePacifyWordsRequest updatePacifyWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pacify_words_id", updatePacifyWordsRequest.PacifyWordsId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words/{pacify_words_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePacifyWordsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePacifyWordsResponse>(response);
        }

        public SyncInvoker<UpdatePacifyWordsResponse> UpdatePacifyWordsInvoker(UpdatePacifyWordsRequest updatePacifyWordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("pacify_words_id", updatePacifyWordsRequest.PacifyWordsId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words/{pacify_words_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePacifyWordsRequest);
            return new SyncInvoker<UpdatePacifyWordsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePacifyWordsResponse>);
        }
        
        /// <summary>
        /// 修改安抚话术功能开关
        ///
        /// 该接口用于修改安抚话术功能开关。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePacifyWordsSwitchResponse UpdatePacifyWordsSwitch(UpdatePacifyWordsSwitchRequest updatePacifyWordsSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePacifyWordsSwitchRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdatePacifyWordsSwitchResponse>(response);
        }

        public SyncInvoker<UpdatePacifyWordsSwitchResponse> UpdatePacifyWordsSwitchInvoker(UpdatePacifyWordsSwitchRequest updatePacifyWordsSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePacifyWordsSwitchRequest);
            return new SyncInvoker<UpdatePacifyWordsSwitchResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdatePacifyWordsSwitchResponse>);
        }
        
        /// <summary>
        /// 修改安抚话术等待触发时长
        ///
        /// 该接口用于修改安抚话术等待触发时长。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePacifyWordsTriggerTimeResponse UpdatePacifyWordsTriggerTime(UpdatePacifyWordsTriggerTimeRequest updatePacifyWordsTriggerTimeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words-time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePacifyWordsTriggerTimeRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdatePacifyWordsTriggerTimeResponse>(response);
        }

        public SyncInvoker<UpdatePacifyWordsTriggerTimeResponse> UpdatePacifyWordsTriggerTimeInvoker(UpdatePacifyWordsTriggerTimeRequest updatePacifyWordsTriggerTimeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/pacify-words-time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePacifyWordsTriggerTimeRequest);
            return new SyncInvoker<UpdatePacifyWordsTriggerTimeResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdatePacifyWordsTriggerTimeResponse>);
        }
        
        /// <summary>
        /// 基于图片URL创建照片建模任务
        ///
        /// 该接口用于从URL中获取图片进行照片建模任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePictureModelingByUrlJobResponse CreatePictureModelingByUrlJob(CreatePictureModelingByUrlJobRequest createPictureModelingByUrlJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human/stylized/picture-modelings-by-url", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPictureModelingByUrlJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePictureModelingByUrlJobResponse>(response);
        }

        public SyncInvoker<CreatePictureModelingByUrlJobResponse> CreatePictureModelingByUrlJobInvoker(CreatePictureModelingByUrlJobRequest createPictureModelingByUrlJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human/stylized/picture-modelings-by-url", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPictureModelingByUrlJobRequest);
            return new SyncInvoker<CreatePictureModelingByUrlJobResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePictureModelingByUrlJobResponse>);
        }
        
        /// <summary>
        /// 创建照片建模任务
        ///
        /// 该接口用于创建风格化照片建模任务。通过上传照片，生成风格化数字人模型。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePictureModelingJobResponse CreatePictureModelingJob(CreatePictureModelingJobRequest createPictureModelingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human/stylized/picture-modelings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", createPictureModelingJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePictureModelingJobResponse>(response);
        }

        public SyncInvoker<CreatePictureModelingJobResponse> CreatePictureModelingJobInvoker(CreatePictureModelingJobRequest createPictureModelingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human/stylized/picture-modelings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", createPictureModelingJobRequest);
            return new SyncInvoker<CreatePictureModelingJobResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePictureModelingJobResponse>);
        }
        
        /// <summary>
        /// 照片建模任务列表查询
        ///
        /// 该接口用于查询风格化照片建模任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPictureModelingJobsResponse ListPictureModelingJobs(ListPictureModelingJobsRequest listPictureModelingJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human/stylized/picture-modelings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPictureModelingJobsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPictureModelingJobsResponse>(response);
        }

        public SyncInvoker<ListPictureModelingJobsResponse> ListPictureModelingJobsInvoker(ListPictureModelingJobsRequest listPictureModelingJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human/stylized/picture-modelings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPictureModelingJobsRequest);
            return new SyncInvoker<ListPictureModelingJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPictureModelingJobsResponse>);
        }
        
        /// <summary>
        /// 照片建模任务详情查询
        ///
        /// 该接口用于风格化查询照片建模任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPictureModelingJobResponse ShowPictureModelingJob(ShowPictureModelingJobRequest showPictureModelingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showPictureModelingJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human/stylized/picture-modelings/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPictureModelingJobRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPictureModelingJobResponse>(response);
        }

        public SyncInvoker<ShowPictureModelingJobResponse> ShowPictureModelingJobInvoker(ShowPictureModelingJobRequest showPictureModelingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showPictureModelingJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human/stylized/picture-modelings/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPictureModelingJobRequest);
            return new SyncInvoker<ShowPictureModelingJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPictureModelingJobResponse>);
        }
        
        /// <summary>
        /// 创建商品
        ///
        /// Create product
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateProductResponse CreateProduct(CreateProductRequest createProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProductRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateProductResponse>(response);
        }

        public SyncInvoker<CreateProductResponse> CreateProductInvoker(CreateProductRequest createProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createProductRequest);
            return new SyncInvoker<CreateProductResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateProductResponse>);
        }
        
        /// <summary>
        /// 删除商品
        ///
        /// 删除商品
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteProductResponse DeleteProduct(DeleteProductRequest deleteProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("product_id", deleteProductRequest.ProductId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/products/{product_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProductRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteProductResponse>(response);
        }

        public SyncInvoker<DeleteProductResponse> DeleteProductInvoker(DeleteProductRequest deleteProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("product_id", deleteProductRequest.ProductId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/products/{product_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteProductRequest);
            return new SyncInvoker<DeleteProductResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteProductResponse>);
        }
        
        /// <summary>
        /// 查询商品列表
        ///
        /// 查询商品列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProductsResponse ListProducts(ListProductsRequest listProductsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProductsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListProductsResponse>(response);
        }

        public SyncInvoker<ListProductsResponse> ListProductsInvoker(ListProductsRequest listProductsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/products", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProductsRequest);
            return new SyncInvoker<ListProductsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProductsResponse>);
        }
        
        /// <summary>
        /// 商品资产组合配置
        ///
        /// 商品资产组合配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetProductAssetResponse SetProductAsset(SetProductAssetRequest setProductAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("product_id", setProductAssetRequest.ProductId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/products/{product_id}/assets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setProductAssetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<SetProductAssetResponse>(response);
        }

        public SyncInvoker<SetProductAssetResponse> SetProductAssetInvoker(SetProductAssetRequest setProductAssetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("product_id", setProductAssetRequest.ProductId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/products/{product_id}/assets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setProductAssetRequest);
            return new SyncInvoker<SetProductAssetResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SetProductAssetResponse>);
        }
        
        /// <summary>
        /// 查询商品详情
        ///
        /// Show product
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowProductResponse ShowProduct(ShowProductRequest showProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("product_id", showProductRequest.ProductId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/products/{product_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProductRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowProductResponse>(response);
        }

        public SyncInvoker<ShowProductResponse> ShowProductInvoker(ShowProductRequest showProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("product_id", showProductRequest.ProductId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/products/{product_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProductRequest);
            return new SyncInvoker<ShowProductResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProductResponse>);
        }
        
        /// <summary>
        /// 更新商品
        ///
        /// Update product
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateProductResponse UpdateProduct(UpdateProductRequest updateProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("product_id", updateProductRequest.ProductId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/products/{product_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProductRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateProductResponse>(response);
        }

        public SyncInvoker<UpdateProductResponse> UpdateProductInvoker(UpdateProductRequest updateProductRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("product_id", updateProductRequest.ProductId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/products/{product_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateProductRequest);
            return new SyncInvoker<UpdateProductResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateProductResponse>);
        }
        
        /// <summary>
        /// 创建应用
        ///
        /// 该接口用于创建应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRobotResponse CreateRobot(CreateRobotRequest createRobotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/robot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRobotRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateRobotResponse>(response);
        }

        public SyncInvoker<CreateRobotResponse> CreateRobotInvoker(CreateRobotRequest createRobotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/robot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRobotRequest);
            return new SyncInvoker<CreateRobotResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRobotResponse>);
        }
        
        /// <summary>
        /// 删除应用
        ///
        /// 该接口用于删除应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteRobotResponse DeleteRobot(DeleteRobotRequest deleteRobotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/robot/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRobotRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteRobotResponse>(response);
        }

        public SyncInvoker<DeleteRobotResponse> DeleteRobotInvoker(DeleteRobotRequest deleteRobotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/robot/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRobotRequest);
            return new SyncInvoker<DeleteRobotResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteRobotResponse>);
        }
        
        /// <summary>
        /// 查询应用列表
        ///
        /// 该接口用于查询应用列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRobotResponse ListRobot(ListRobotRequest listRobotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/robot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRobotRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRobotResponse>(response);
        }

        public SyncInvoker<ListRobotResponse> ListRobotInvoker(ListRobotRequest listRobotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/robot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRobotRequest);
            return new SyncInvoker<ListRobotResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRobotResponse>);
        }
        
        /// <summary>
        /// 查询应用详情
        ///
        /// 该接口用于查询应用详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRobotResponse ShowRobot(ShowRobotRequest showRobotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("robot_id", showRobotRequest.RobotId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/robot/{robot_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRobotRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRobotResponse>(response);
        }

        public SyncInvoker<ShowRobotResponse> ShowRobotInvoker(ShowRobotRequest showRobotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("robot_id", showRobotRequest.RobotId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/robot/{robot_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRobotRequest);
            return new SyncInvoker<ShowRobotResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRobotResponse>);
        }
        
        /// <summary>
        /// 修改应用
        ///
        /// 该接口用于修改应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRobotResponse UpdateRobot(UpdateRobotRequest updateRobotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("robot_id", updateRobotRequest.RobotId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/robot/{robot_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRobotRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateRobotResponse>(response);
        }

        public SyncInvoker<UpdateRobotResponse> UpdateRobotInvoker(UpdateRobotRequest updateRobotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("robot_id", updateRobotRequest.RobotId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/robot/{robot_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRobotRequest);
            return new SyncInvoker<UpdateRobotResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateRobotResponse>);
        }
        
        /// <summary>
        /// 校验应用
        ///
        /// 该接口用于校验应用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ValidateRobotResponse ValidateRobot(ValidateRobotRequest validateRobotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/robot/validate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", validateRobotRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ValidateRobotResponse>(response);
        }

        public SyncInvoker<ValidateRobotResponse> ValidateRobotInvoker(ValidateRobotRequest validateRobotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/robot/validate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", validateRobotRequest);
            return new SyncInvoker<ValidateRobotResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ValidateRobotResponse>);
        }
        
        /// <summary>
        /// 创建智能交互对话
        ///
        /// 该接口用于创建智能交互对话。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateSmartChatRoomResponse CreateSmartChatRoom(CreateSmartChatRoomRequest createSmartChatRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-chat-rooms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSmartChatRoomRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateSmartChatRoomResponse>(response);
        }

        public SyncInvoker<CreateSmartChatRoomResponse> CreateSmartChatRoomInvoker(CreateSmartChatRoomRequest createSmartChatRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-chat-rooms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSmartChatRoomRequest);
            return new SyncInvoker<CreateSmartChatRoomResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSmartChatRoomResponse>);
        }
        
        /// <summary>
        /// 删除智能交互对话
        ///
        /// 该接口用于删除智能交互对话。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSmartChatRoomResponse DeleteSmartChatRoom(DeleteSmartChatRoomRequest deleteSmartChatRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", deleteSmartChatRoomRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-chat-rooms/{room_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSmartChatRoomRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSmartChatRoomResponse>(response);
        }

        public SyncInvoker<DeleteSmartChatRoomResponse> DeleteSmartChatRoomInvoker(DeleteSmartChatRoomRequest deleteSmartChatRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", deleteSmartChatRoomRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-chat-rooms/{room_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSmartChatRoomRequest);
            return new SyncInvoker<DeleteSmartChatRoomResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSmartChatRoomResponse>);
        }
        
        /// <summary>
        /// 查询智能交互对话列表
        ///
        /// 该接口用于智能交互对话列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSmartChatRoomsResponse ListSmartChatRooms(ListSmartChatRoomsRequest listSmartChatRoomsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-chat-rooms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSmartChatRoomsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSmartChatRoomsResponse>(response);
        }

        public SyncInvoker<ListSmartChatRoomsResponse> ListSmartChatRoomsInvoker(ListSmartChatRoomsRequest listSmartChatRoomsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-chat-rooms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSmartChatRoomsRequest);
            return new SyncInvoker<ListSmartChatRoomsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSmartChatRoomsResponse>);
        }
        
        /// <summary>
        /// 查询智能交互对话详情
        ///
        /// 该接口用于查询智能交互对话详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSmartChatRoomResponse ShowSmartChatRoom(ShowSmartChatRoomRequest showSmartChatRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", showSmartChatRoomRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-chat-rooms/{room_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSmartChatRoomRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSmartChatRoomResponse>(response);
        }

        public SyncInvoker<ShowSmartChatRoomResponse> ShowSmartChatRoomInvoker(ShowSmartChatRoomRequest showSmartChatRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", showSmartChatRoomRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-chat-rooms/{room_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSmartChatRoomRequest);
            return new SyncInvoker<ShowSmartChatRoomResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSmartChatRoomResponse>);
        }
        
        /// <summary>
        /// 更新智能交互对话信息
        ///
        /// 该接口用于智能交互对话信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateSmartChatRoomResponse UpdateSmartChatRoom(UpdateSmartChatRoomRequest updateSmartChatRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", updateSmartChatRoomRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-chat-rooms/{room_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSmartChatRoomRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSmartChatRoomResponse>(response);
        }

        public SyncInvoker<UpdateSmartChatRoomResponse> UpdateSmartChatRoomInvoker(UpdateSmartChatRoomRequest updateSmartChatRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", updateSmartChatRoomRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-chat-rooms/{room_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSmartChatRoomRequest);
            return new SyncInvoker<UpdateSmartChatRoomResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSmartChatRoomResponse>);
        }
        
        /// <summary>
        /// 批量确认命令
        ///
        /// 该接口用于批量确认命令列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchConfirmLiveCommandsResponse BatchConfirmLiveCommands(BatchConfirmLiveCommandsRequest batchConfirmLiveCommandsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", batchConfirmLiveCommandsRequest.RoomId.ToString());
            urlParam.Add("job_id", batchConfirmLiveCommandsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}/smart-live-jobs/{job_id}/batch-commands-confirm", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchConfirmLiveCommandsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchConfirmLiveCommandsResponse>(response);
        }

        public SyncInvoker<BatchConfirmLiveCommandsResponse> BatchConfirmLiveCommandsInvoker(BatchConfirmLiveCommandsRequest batchConfirmLiveCommandsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", batchConfirmLiveCommandsRequest.RoomId.ToString());
            urlParam.Add("job_id", batchConfirmLiveCommandsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}/smart-live-jobs/{job_id}/batch-commands-confirm", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchConfirmLiveCommandsRequest);
            return new SyncInvoker<BatchConfirmLiveCommandsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchConfirmLiveCommandsResponse>);
        }
        
        /// <summary>
        /// 控制数字人直播过程
        ///
        /// 该接口用于控制数字人直播过程。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExecuteSmartLiveCommandResponse ExecuteSmartLiveCommand(ExecuteSmartLiveCommandRequest executeSmartLiveCommandRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", executeSmartLiveCommandRequest.RoomId.ToString());
            urlParam.Add("job_id", executeSmartLiveCommandRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}/smart-live-jobs/{job_id}/command", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeSmartLiveCommandRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExecuteSmartLiveCommandResponse>(response);
        }

        public SyncInvoker<ExecuteSmartLiveCommandResponse> ExecuteSmartLiveCommandInvoker(ExecuteSmartLiveCommandRequest executeSmartLiveCommandRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", executeSmartLiveCommandRequest.RoomId.ToString());
            urlParam.Add("job_id", executeSmartLiveCommandRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}/smart-live-jobs/{job_id}/command", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeSmartLiveCommandRequest);
            return new SyncInvoker<ExecuteSmartLiveCommandResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteSmartLiveCommandResponse>);
        }
        
        /// <summary>
        /// 查询某个智能直播间下直播任务列表
        ///
        /// 该接口用于查询某个智能直播间的直播任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSmartLiveResponse ListSmartLive(ListSmartLiveRequest listSmartLiveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", listSmartLiveRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}/smart-live-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSmartLiveRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSmartLiveResponse>(response);
        }

        public SyncInvoker<ListSmartLiveResponse> ListSmartLiveInvoker(ListSmartLiveRequest listSmartLiveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", listSmartLiveRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}/smart-live-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSmartLiveRequest);
            return new SyncInvoker<ListSmartLiveResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSmartLiveResponse>);
        }
        
        /// <summary>
        /// 查询租户所有数字人直播任务列表
        ///
        /// 该接口用于查询租户所有数字人智能直播任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSmartLiveJobsResponse ListSmartLiveJobs(ListSmartLiveJobsRequest listSmartLiveJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSmartLiveJobsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSmartLiveJobsResponse>(response);
        }

        public SyncInvoker<ListSmartLiveJobsResponse> ListSmartLiveJobsInvoker(ListSmartLiveJobsRequest listSmartLiveJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSmartLiveJobsRequest);
            return new SyncInvoker<ListSmartLiveJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSmartLiveJobsResponse>);
        }
        
        /// <summary>
        /// 查询租户未确认的互动规则命令列表
        ///
        /// 该接口用于查询租户未确认的互动规则命令列表，仅限于需要做二次确认的特定用户使用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSmartLiveRuleCommandsResponse ListSmartLiveRuleCommands(ListSmartLiveRuleCommandsRequest listSmartLiveRuleCommandsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-command/rule-commands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSmartLiveRuleCommandsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSmartLiveRuleCommandsResponse>(response);
        }

        public SyncInvoker<ListSmartLiveRuleCommandsResponse> ListSmartLiveRuleCommandsInvoker(ListSmartLiveRuleCommandsRequest listSmartLiveRuleCommandsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-command/rule-commands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSmartLiveRuleCommandsRequest);
            return new SyncInvoker<ListSmartLiveRuleCommandsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSmartLiveRuleCommandsResponse>);
        }
        
        /// <summary>
        /// 查询租户未确认的剧本命令列表
        ///
        /// 该接口用于查询租户未确认的剧本命令列表，仅限于需要做二次确认的特定用户使用。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSmartLiveScriptCommandsResponse ListSmartLiveScriptCommands(ListSmartLiveScriptCommandsRequest listSmartLiveScriptCommandsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-command/script-commands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSmartLiveScriptCommandsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSmartLiveScriptCommandsResponse>(response);
        }

        public SyncInvoker<ListSmartLiveScriptCommandsResponse> ListSmartLiveScriptCommandsInvoker(ListSmartLiveScriptCommandsRequest listSmartLiveScriptCommandsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-command/script-commands", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSmartLiveScriptCommandsRequest);
            return new SyncInvoker<ListSmartLiveScriptCommandsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSmartLiveScriptCommandsResponse>);
        }
        
        /// <summary>
        /// 上报直播间事件
        ///
        /// 该接口用于上报直播间事件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public LiveEventReportResponse LiveEventReport(LiveEventReportRequest liveEventReportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", liveEventReportRequest.RoomId.ToString());
            urlParam.Add("job_id", liveEventReportRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}/smart-live-jobs/{job_id}/live-event-report", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", liveEventReportRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<LiveEventReportResponse>(response);
        }

        public SyncInvoker<LiveEventReportResponse> LiveEventReportInvoker(LiveEventReportRequest liveEventReportRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", liveEventReportRequest.RoomId.ToString());
            urlParam.Add("job_id", liveEventReportRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}/smart-live-jobs/{job_id}/live-event-report", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", liveEventReportRequest);
            return new SyncInvoker<LiveEventReportResponse>(this, "POST", request, JsonUtils.DeSerialize<LiveEventReportResponse>);
        }
        
        /// <summary>
        /// 查询数字人智能直播任务详情
        ///
        /// 该接口用于查询数字人智能直播任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSmartLiveResponse ShowSmartLive(ShowSmartLiveRequest showSmartLiveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", showSmartLiveRequest.RoomId.ToString());
            urlParam.Add("job_id", showSmartLiveRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}/smart-live-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSmartLiveRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSmartLiveResponse>(response);
        }

        public SyncInvoker<ShowSmartLiveResponse> ShowSmartLiveInvoker(ShowSmartLiveRequest showSmartLiveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", showSmartLiveRequest.RoomId.ToString());
            urlParam.Add("job_id", showSmartLiveRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}/smart-live-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSmartLiveRequest);
            return new SyncInvoker<ShowSmartLiveResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSmartLiveResponse>);
        }
        
        /// <summary>
        /// 启动数字人智能直播任务
        ///
        /// 该接口用于启动数字人智能直播任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StartSmartLiveResponse StartSmartLive(StartSmartLiveRequest startSmartLiveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", startSmartLiveRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}/smart-live-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startSmartLiveRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StartSmartLiveResponse>(response);
        }

        public SyncInvoker<StartSmartLiveResponse> StartSmartLiveInvoker(StartSmartLiveRequest startSmartLiveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", startSmartLiveRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}/smart-live-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startSmartLiveRequest);
            return new SyncInvoker<StartSmartLiveResponse>(this, "POST", request, JsonUtils.DeSerialize<StartSmartLiveResponse>);
        }
        
        /// <summary>
        /// 结束数字人智能直播任务
        ///
        /// 该接口用于结束数字人智能直播任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StopSmartLiveResponse StopSmartLive(StopSmartLiveRequest stopSmartLiveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", stopSmartLiveRequest.RoomId.ToString());
            urlParam.Add("job_id", stopSmartLiveRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}/smart-live-jobs/{job_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopSmartLiveRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<StopSmartLiveResponse>(response);
        }

        public SyncInvoker<StopSmartLiveResponse> StopSmartLiveInvoker(StopSmartLiveRequest stopSmartLiveRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", stopSmartLiveRequest.RoomId.ToString());
            urlParam.Add("job_id", stopSmartLiveRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}/smart-live-jobs/{job_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopSmartLiveRequest);
            return new SyncInvoker<StopSmartLiveResponse>(this, "POST", request, JsonUtils.DeSerializeNull<StopSmartLiveResponse>);
        }
        
        /// <summary>
        /// 直播间确认
        ///
        /// 该接口用直播间二次确认
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ConfirmSmarLiveRoomResponse ConfirmSmarLiveRoom(ConfirmSmarLiveRoomRequest confirmSmarLiveRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", confirmSmarLiveRoomRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}/confirm", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmSmarLiveRoomRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ConfirmSmarLiveRoomResponse>(response);
        }

        public SyncInvoker<ConfirmSmarLiveRoomResponse> ConfirmSmarLiveRoomInvoker(ConfirmSmarLiveRoomRequest confirmSmarLiveRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", confirmSmarLiveRoomRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}/confirm", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmSmarLiveRoomRequest);
            return new SyncInvoker<ConfirmSmarLiveRoomResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ConfirmSmarLiveRoomResponse>);
        }
        
        /// <summary>
        /// 创建智能直播间
        ///
        /// 该接口用于创建智能直播间。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateSmartLiveRoomResponse CreateSmartLiveRoom(CreateSmartLiveRoomRequest createSmartLiveRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSmartLiveRoomRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateSmartLiveRoomResponse>(response);
        }

        public SyncInvoker<CreateSmartLiveRoomResponse> CreateSmartLiveRoomInvoker(CreateSmartLiveRoomRequest createSmartLiveRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSmartLiveRoomRequest);
            return new SyncInvoker<CreateSmartLiveRoomResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSmartLiveRoomResponse>);
        }
        
        /// <summary>
        /// 删除智能直播间
        ///
        /// 该接口用于删除智能直播间。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSmartLiveRoomResponse DeleteSmartLiveRoom(DeleteSmartLiveRoomRequest deleteSmartLiveRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", deleteSmartLiveRoomRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSmartLiveRoomRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSmartLiveRoomResponse>(response);
        }

        public SyncInvoker<DeleteSmartLiveRoomResponse> DeleteSmartLiveRoomInvoker(DeleteSmartLiveRoomRequest deleteSmartLiveRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", deleteSmartLiveRoomRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSmartLiveRoomRequest);
            return new SyncInvoker<DeleteSmartLiveRoomResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSmartLiveRoomResponse>);
        }
        
        /// <summary>
        /// 查询智能直播间列表
        ///
        /// 该接口用于智能直播间列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSmartLiveRoomsResponse ListSmartLiveRooms(ListSmartLiveRoomsRequest listSmartLiveRoomsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSmartLiveRoomsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSmartLiveRoomsResponse>(response);
        }

        public SyncInvoker<ListSmartLiveRoomsResponse> ListSmartLiveRoomsInvoker(ListSmartLiveRoomsRequest listSmartLiveRoomsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSmartLiveRoomsRequest);
            return new SyncInvoker<ListSmartLiveRoomsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSmartLiveRoomsResponse>);
        }
        
        /// <summary>
        /// 查询智能直播间剧本详情
        ///
        /// 该接口用于查询智能直播间剧本详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSmartLiveRoomResponse ShowSmartLiveRoom(ShowSmartLiveRoomRequest showSmartLiveRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", showSmartLiveRoomRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSmartLiveRoomRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSmartLiveRoomResponse>(response);
        }

        public SyncInvoker<ShowSmartLiveRoomResponse> ShowSmartLiveRoomInvoker(ShowSmartLiveRoomRequest showSmartLiveRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", showSmartLiveRoomRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSmartLiveRoomRequest);
            return new SyncInvoker<ShowSmartLiveRoomResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSmartLiveRoomResponse>);
        }
        
        /// <summary>
        /// 更新智能直播间信息
        ///
        /// 该接口用于智能直播间信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateSmartLiveRoomResponse UpdateSmartLiveRoom(UpdateSmartLiveRoomRequest updateSmartLiveRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", updateSmartLiveRoomRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSmartLiveRoomRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateSmartLiveRoomResponse>(response);
        }

        public SyncInvoker<UpdateSmartLiveRoomResponse> UpdateSmartLiveRoomInvoker(UpdateSmartLiveRoomRequest updateSmartLiveRoomRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("room_id", updateSmartLiveRoomRequest.RoomId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/smart-live-rooms/{room_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSmartLiveRoomRequest);
            return new SyncInvoker<UpdateSmartLiveRoomResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateSmartLiveRoomResponse>);
        }
        
        /// <summary>
        /// 查询数字人风格列表
        ///
        /// 查询数字人风格列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListStylesResponse ListStyles(ListStylesRequest listStylesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/styles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStylesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListStylesResponse>(response);
        }

        public SyncInvoker<ListStylesResponse> ListStylesInvoker(ListStylesRequest listStylesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/styles", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStylesRequest);
            return new SyncInvoker<ListStylesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStylesResponse>);
        }
        
        /// <summary>
        /// 创建分身数字人视频字幕文件
        ///
        /// 该接口用于创建分身数字人视频字幕文件任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateSubtitleFileResponse CreateSubtitleFile(CreateSubtitleFileRequest createSubtitleFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/subtitle-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSubtitleFileRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateSubtitleFileResponse>(response);
        }

        public SyncInvoker<CreateSubtitleFileResponse> CreateSubtitleFileInvoker(CreateSubtitleFileRequest createSubtitleFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/subtitle-files", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSubtitleFileRequest);
            return new SyncInvoker<CreateSubtitleFileResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateSubtitleFileResponse>);
        }
        
        /// <summary>
        /// 查询分身数字人视频字幕文件任务详情
        ///
        /// 该接口用于查询分身数字人视频字幕文件任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSubtitleFileResponse ShowSubtitleFile(ShowSubtitleFileRequest showSubtitleFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showSubtitleFileRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/subtitle-files/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubtitleFileRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSubtitleFileResponse>(response);
        }

        public SyncInvoker<ShowSubtitleFileResponse> ShowSubtitleFileInvoker(ShowSubtitleFileRequest showSubtitleFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showSubtitleFileRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/subtitle-files/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubtitleFileRequest);
            return new SyncInvoker<ShowSubtitleFileResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSubtitleFileResponse>);
        }
        
        /// <summary>
        /// 统计时间段内过期的资源数量
        ///
        /// 统计指定时间段内即将过期的包周期与一次性资源数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CountTenantResourcesResponse CountTenantResources(CountTenantResourcesRequest countTenantResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/tenants/resources-count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countTenantResourcesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CountTenantResourcesResponse>(response);
        }

        public SyncInvoker<CountTenantResourcesResponse> CountTenantResourcesInvoker(CountTenantResourcesRequest countTenantResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/tenants/resources-count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countTenantResourcesRequest);
            return new SyncInvoker<CountTenantResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<CountTenantResourcesResponse>);
        }
        
        /// <summary>
        /// 查看租户资源列表
        ///
        /// 查看租户资源列表。
        ///  &gt; 按需套餐包用量本接口无法查询，需要调用CBC接口查询，详见[按需套餐包用量查询](https://cbc.huaweicloud.com/bm/support/api-apidt/CBCInterface_0001239.html)和[查询资源包信息](https://cbc.huaweicloud.com/bm/support/api-apidt/CBCInterface_0000511.html)。
        /// &gt; 各种资源的计费方式请参考[计费说明](https://support.huaweicloud.com/productdesc-metastudio/metastudio_01_0006.html)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTenantResourcesResponse ListTenantResources(ListTenantResourcesRequest listTenantResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/tenants/resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantResourcesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTenantResourcesResponse>(response);
        }

        public SyncInvoker<ListTenantResourcesResponse> ListTenantResourcesInvoker(ListTenantResourcesRequest listTenantResourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/tenants/resources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTenantResourcesRequest);
            return new SyncInvoker<ListTenantResourcesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTenantResourcesResponse>);
        }
        
        /// <summary>
        /// 查看租户资源用量信息
        ///
        /// 查询租户一次性和包周期（包年/包月）资源用量信息。
        /// &gt; 按需套餐包用量本接口无法查询，需要调用CBC接口查询，详见[按需套餐包用量查询](https://cbc.huaweicloud.com/bm/support/api-apidt/CBCInterface_0001239.html)和[查询资源包信息](https://cbc.huaweicloud.com/bm/support/api-apidt/CBCInterface_0000511.html)。
        /// &gt; 各种资源的计费方式请参考[计费说明](https://support.huaweicloud.com/productdesc-metastudio/metastudio_01_0006.html)。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowResourceUsageResponse ShowResourceUsage(ShowResourceUsageRequest showResourceUsageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/tenants/resources-usage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceUsageRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowResourceUsageResponse>(response);
        }

        public SyncInvoker<ShowResourceUsageResponse> ShowResourceUsageInvoker(ShowResourceUsageRequest showResourceUsageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/tenants/resources-usage", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceUsageRequest);
            return new SyncInvoker<ShowResourceUsageResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceUsageResponse>);
        }
        
        /// <summary>
        /// 提交语音训练任务
        ///
        /// 提交训练任务,执行该接口后,任务会进入审核状态,审核完成后会等待训练。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CommitVoiceTrainingJobResponse CommitVoiceTrainingJob(CommitVoiceTrainingJobRequest commitVoiceTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", commitVoiceTrainingJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", commitVoiceTrainingJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CommitVoiceTrainingJobResponse>(response);
        }

        public SyncInvoker<CommitVoiceTrainingJobResponse> CommitVoiceTrainingJobInvoker(CommitVoiceTrainingJobRequest commitVoiceTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", commitVoiceTrainingJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", commitVoiceTrainingJobRequest);
            return new SyncInvoker<CommitVoiceTrainingJobResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CommitVoiceTrainingJobResponse>);
        }
        
        /// <summary>
        /// 确认在线录音结果
        ///
        /// 确认在线录音结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ConfirmTrainingSegmentResponse ConfirmTrainingSegment(ConfirmTrainingSegmentRequest confirmTrainingSegmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/training-segment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmTrainingSegmentRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ConfirmTrainingSegmentResponse>(response);
        }

        public SyncInvoker<ConfirmTrainingSegmentResponse> ConfirmTrainingSegmentInvoker(ConfirmTrainingSegmentRequest confirmTrainingSegmentRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/training-segment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", confirmTrainingSegmentRequest);
            return new SyncInvoker<ConfirmTrainingSegmentResponse>(this, "POST", request, JsonUtils.DeSerialize<ConfirmTrainingSegmentResponse>);
        }
        
        /// <summary>
        /// 创建高级版语音训练任务
        ///
        /// 用户创建语音训练高级版任务，该接口会返回一个obs上传地址，用于上传语音文件。
        /// 
        /// 语音文件为一段WAV格式的长音频文件，仅支持将语音文件打包成zip压缩格式上传。
        /// 
        /// 文件上传后，调用“提交语音训练任务”接口，启动审核和训练。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTrainingAdvanceJobResponse CreateTrainingAdvanceJob(CreateTrainingAdvanceJobRequest createTrainingAdvanceJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/advance-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTrainingAdvanceJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateTrainingAdvanceJobResponse>(response);
        }

        public SyncInvoker<CreateTrainingAdvanceJobResponse> CreateTrainingAdvanceJobInvoker(CreateTrainingAdvanceJobRequest createTrainingAdvanceJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/advance-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTrainingAdvanceJobRequest);
            return new SyncInvoker<CreateTrainingAdvanceJobResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTrainingAdvanceJobResponse>);
        }
        
        /// <summary>
        /// 创建基础版语音训练任务
        ///
        /// 用户创建语音训练基础版任务，该接口会返回一个obs上传地址，用于上传语音文件。
        /// 
        /// 支持2种方式上传语音文件：
        /// * 语音文件和文本文件打包成zip上传：语音文件已经切分成20个wav文件，每个语音文件对应一个txt文本文件，所有文件打包成zip文件。语音文件命名规则：0.wav~19.wav；文本文件命名规则：0.txt~19.txt。
        /// * 语音文件和文本文件逐句上传：每次上传一句语料的语音文件和文本文件，再调用“确认在线录音结果”接口确认语音和文本内容是否一致。确认成功后再上传和确认下一句。
        /// 
        /// 文件上传后，调用“提交语音训练任务”接口，启动审核和训练。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTrainingBasicJobResponse CreateTrainingBasicJob(CreateTrainingBasicJobRequest createTrainingBasicJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/basic-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTrainingBasicJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateTrainingBasicJobResponse>(response);
        }

        public SyncInvoker<CreateTrainingBasicJobResponse> CreateTrainingBasicJobInvoker(CreateTrainingBasicJobRequest createTrainingBasicJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/basic-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTrainingBasicJobRequest);
            return new SyncInvoker<CreateTrainingBasicJobResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTrainingBasicJobResponse>);
        }
        
        /// <summary>
        /// 创建进阶版语音训练任务
        ///
        /// 用户创建语音训练进阶版任务，该接口会返回一个obs上传地址，用于上传语音文件。
        /// 
        /// 支持2种方式上传语音文件：
        /// * 语音文件和文本文件打包成zip上传：语音文件已经切分成100个wav文件，每个语音文件对应一个txt文本文件，所有文件打包成zip文件。语音文件命名规则：0.wav~99.wav；文本文件命名规则：0.txt~99.txt。
        /// * 语音文件和文本文件逐句上传：每次上传一句语料的语音文件和文本文件，再调用“确认在线录音结果”接口确认语音和文本内容是否一致。确认成功后再上传和确认下一句。
        /// 
        /// 文件上传后，调用“提交语音训练任务”接口，启动审核和训练。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTrainingMiddleJobResponse CreateTrainingMiddleJob(CreateTrainingMiddleJobRequest createTrainingMiddleJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/middle-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTrainingMiddleJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateTrainingMiddleJobResponse>(response);
        }

        public SyncInvoker<CreateTrainingMiddleJobResponse> CreateTrainingMiddleJobInvoker(CreateTrainingMiddleJobRequest createTrainingMiddleJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/middle-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTrainingMiddleJobRequest);
            return new SyncInvoker<CreateTrainingMiddleJobResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTrainingMiddleJobResponse>);
        }
        
        /// <summary>
        /// 删除语音训练任务
        ///
        /// 删除语音训练任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteVoiceTrainingJobResponse DeleteVoiceTrainingJob(DeleteVoiceTrainingJobRequest deleteVoiceTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", deleteVoiceTrainingJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVoiceTrainingJobRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteVoiceTrainingJobResponse>(response);
        }

        public SyncInvoker<DeleteVoiceTrainingJobResponse> DeleteVoiceTrainingJobInvoker(DeleteVoiceTrainingJobRequest deleteVoiceTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", deleteVoiceTrainingJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVoiceTrainingJobRequest);
            return new SyncInvoker<DeleteVoiceTrainingJobResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteVoiceTrainingJobResponse>);
        }
        
        /// <summary>
        /// 查询任务操作日志
        ///
        /// 查询任务操作日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListJobOperationLogResponse ListJobOperationLog(ListJobOperationLogRequest listJobOperationLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listJobOperationLogRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/jobs/{job_id}/op-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobOperationLogRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListJobOperationLogResponse>(response);
        }

        public SyncInvoker<ListJobOperationLogResponse> ListJobOperationLogInvoker(ListJobOperationLogRequest listJobOperationLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listJobOperationLogRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/jobs/{job_id}/op-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobOperationLogRequest);
            return new SyncInvoker<ListJobOperationLogResponse>(this, "GET", request, JsonUtils.DeSerialize<ListJobOperationLogResponse>);
        }
        
        /// <summary>
        /// 查询语音训练任务列表
        ///
        /// 查询语音训练任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListVoiceTrainingJobResponse ListVoiceTrainingJob(ListVoiceTrainingJobRequest listVoiceTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVoiceTrainingJobRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListVoiceTrainingJobResponse>(response);
        }

        public SyncInvoker<ListVoiceTrainingJobResponse> ListVoiceTrainingJobInvoker(ListVoiceTrainingJobRequest listVoiceTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVoiceTrainingJobRequest);
            return new SyncInvoker<ListVoiceTrainingJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVoiceTrainingJobResponse>);
        }
        
        /// <summary>
        /// 设置任务批次
        ///
        /// 用户设置任务批次，该接口用于批量任务管理场景，设置任务的批次
        /// * 需要开通NA租户权限后才能正常调用
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetJobBatchNameResponse SetJobBatchName(SetJobBatchNameRequest setJobBatchNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/batch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setJobBatchNameRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<SetJobBatchNameResponse>(response);
        }

        public SyncInvoker<SetJobBatchNameResponse> SetJobBatchNameInvoker(SetJobBatchNameRequest setJobBatchNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/batch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setJobBatchNameRequest);
            return new SyncInvoker<SetJobBatchNameResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetJobBatchNameResponse>);
        }
        
        /// <summary>
        /// 获取语音训练任务审核结果
        ///
        /// 获取语音训练任务审核结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowJobAuditResultResponse ShowJobAuditResult(ShowJobAuditResultRequest showJobAuditResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobAuditResultRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/jobs/{job_id}/audit-result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobAuditResultRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowJobAuditResultResponse>(response);
        }

        public SyncInvoker<ShowJobAuditResultResponse> ShowJobAuditResultInvoker(ShowJobAuditResultRequest showJobAuditResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobAuditResultRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/jobs/{job_id}/audit-result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobAuditResultRequest);
            return new SyncInvoker<ShowJobAuditResultResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobAuditResultResponse>);
        }
        
        /// <summary>
        /// 获取语音文件上传地址
        ///
        /// 获取语音文件上传地址
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowJobUploadingAddressResponse ShowJobUploadingAddress(ShowJobUploadingAddressRequest showJobUploadingAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobUploadingAddressRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/jobs/{job_id}/uploading-address-url", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobUploadingAddressRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowJobUploadingAddressResponse>(response);
        }

        public SyncInvoker<ShowJobUploadingAddressResponse> ShowJobUploadingAddressInvoker(ShowJobUploadingAddressRequest showJobUploadingAddressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobUploadingAddressRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/jobs/{job_id}/uploading-address-url", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobUploadingAddressRequest);
            return new SyncInvoker<ShowJobUploadingAddressResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobUploadingAddressResponse>);
        }
        
        /// <summary>
        /// 查询用户配置的个性化音频时长
        ///
        /// 查询用户配置的个性化音频时长
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTenantDurationCfgResponse ShowTenantDurationCfg(ShowTenantDurationCfgRequest showTenantDurationCfgRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/tenant-duration-cfg", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTenantDurationCfgRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTenantDurationCfgResponse>(response);
        }

        public SyncInvoker<ShowTenantDurationCfgResponse> ShowTenantDurationCfgInvoker(ShowTenantDurationCfgRequest showTenantDurationCfgRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/tenant-duration-cfg", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTenantDurationCfgRequest);
            return new SyncInvoker<ShowTenantDurationCfgResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTenantDurationCfgResponse>);
        }
        
        /// <summary>
        /// 获取在线录音确认结果
        ///
        /// 获取在线录音确认结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTrainingSegmentInfoResponse ShowTrainingSegmentInfo(ShowTrainingSegmentInfoRequest showTrainingSegmentInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/training-segment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrainingSegmentInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTrainingSegmentInfoResponse>(response);
        }

        public SyncInvoker<ShowTrainingSegmentInfoResponse> ShowTrainingSegmentInfoInvoker(ShowTrainingSegmentInfoRequest showTrainingSegmentInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/training-segment", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTrainingSegmentInfoRequest);
            return new SyncInvoker<ShowTrainingSegmentInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTrainingSegmentInfoResponse>);
        }
        
        /// <summary>
        /// 查询语音训练任务详情
        ///
        /// 查询语音训练任务详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowVoiceTrainingJobResponse ShowVoiceTrainingJob(ShowVoiceTrainingJobRequest showVoiceTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showVoiceTrainingJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVoiceTrainingJobRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowVoiceTrainingJobResponse>(response);
        }

        public SyncInvoker<ShowVoiceTrainingJobResponse> ShowVoiceTrainingJobInvoker(ShowVoiceTrainingJobRequest showVoiceTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showVoiceTrainingJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/voice-training-manage/user/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVoiceTrainingJobRequest);
            return new SyncInvoker<ShowVoiceTrainingJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVoiceTrainingJobResponse>);
        }
        
        /// <summary>
        /// 创建分身数字人模型训练任务
        ///
        /// 该接口用于创建分身数字人模型训练任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public Create2dModelTrainingJobResponse Create2dModelTrainingJob(Create2dModelTrainingJobRequest create2dModelTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-training-manage/user/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", create2dModelTrainingJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<Create2dModelTrainingJobResponse>(response);
        }

        public SyncInvoker<Create2dModelTrainingJobResponse> Create2dModelTrainingJobInvoker(Create2dModelTrainingJobRequest create2dModelTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-training-manage/user/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", create2dModelTrainingJobRequest);
            return new SyncInvoker<Create2dModelTrainingJobResponse>(this, "POST", request, JsonUtils.DeSerialize<Create2dModelTrainingJobResponse>);
        }
        
        /// <summary>
        /// 删除分身数字人模型训练任务
        ///
        /// 该接口用于删除分身数字人模型训练任务。同时需要删除训练任务相关的训练视频、身份证照片、授权文件、模型资产等。
        /// &gt; * 该接口应当在任务处于以下状态时调用：WAIT_FILE_UPLOAD、AUTO_VERIFY_FAILED、MANUAL_VERIFYING、MANUAL_VERIFY_FAILED、TRAINING_DATA_PREPROCESS_FAILED、TRAIN_FAILED、INFERENCE_DATA_PREPROCESS_FAILED、JOB_SUCCESS、WAIT_USER_CONFIRM、JOB_REJECT、JOB_FINISH
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public Delete2dModelTrainingJobResponse Delete2dModelTrainingJob(Delete2dModelTrainingJobRequest delete2dModelTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", delete2dModelTrainingJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-training-manage/user/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", delete2dModelTrainingJobRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<Delete2dModelTrainingJobResponse>(response);
        }

        public SyncInvoker<Delete2dModelTrainingJobResponse> Delete2dModelTrainingJobInvoker(Delete2dModelTrainingJobRequest delete2dModelTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", delete2dModelTrainingJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-training-manage/user/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", delete2dModelTrainingJobRequest);
            return new SyncInvoker<Delete2dModelTrainingJobResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<Delete2dModelTrainingJobResponse>);
        }
        
        /// <summary>
        /// 租户执行分身数字人模型训练任务命令
        ///
        /// 该接口用于租户执行分身数字人模型训练任务命令，如提交训练审核等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public Execute2dModelTrainingCommandByUserResponse Execute2dModelTrainingCommandByUser(Execute2dModelTrainingCommandByUserRequest execute2dModelTrainingCommandByUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", execute2dModelTrainingCommandByUserRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-training-manage/user/jobs/{job_id}/command", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", execute2dModelTrainingCommandByUserRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<Execute2dModelTrainingCommandByUserResponse>(response);
        }

        public SyncInvoker<Execute2dModelTrainingCommandByUserResponse> Execute2dModelTrainingCommandByUserInvoker(Execute2dModelTrainingCommandByUserRequest execute2dModelTrainingCommandByUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", execute2dModelTrainingCommandByUserRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-training-manage/user/jobs/{job_id}/command", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", execute2dModelTrainingCommandByUserRequest);
            return new SyncInvoker<Execute2dModelTrainingCommandByUserResponse>(this, "POST", request, JsonUtils.DeSerialize<Execute2dModelTrainingCommandByUserResponse>);
        }
        
        /// <summary>
        /// 查询分身数字人模型训练任务列表
        ///
        /// 该接口用于查询分身数字人模型训练任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public List2dModelTrainingJobResponse List2dModelTrainingJob(List2dModelTrainingJobRequest list2dModelTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-training-manage/user/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", list2dModelTrainingJobRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<List2dModelTrainingJobResponse>(response);
        }

        public SyncInvoker<List2dModelTrainingJobResponse> List2dModelTrainingJobInvoker(List2dModelTrainingJobRequest list2dModelTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-training-manage/user/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", list2dModelTrainingJobRequest);
            return new SyncInvoker<List2dModelTrainingJobResponse>(this, "GET", request, JsonUtils.DeSerialize<List2dModelTrainingJobResponse>);
        }
        
        /// <summary>
        /// 查询分身数字人模型训练任务详情
        ///
        /// 该接口用于查询分身数字人模型训练任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public Show2dModelTrainingJobResponse Show2dModelTrainingJob(Show2dModelTrainingJobRequest show2dModelTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", show2dModelTrainingJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-training-manage/user/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", show2dModelTrainingJobRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<Show2dModelTrainingJobResponse>(response);
        }

        public SyncInvoker<Show2dModelTrainingJobResponse> Show2dModelTrainingJobInvoker(Show2dModelTrainingJobRequest show2dModelTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", show2dModelTrainingJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-training-manage/user/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", show2dModelTrainingJobRequest);
            return new SyncInvoker<Show2dModelTrainingJobResponse>(this, "GET", request, JsonUtils.DeSerialize<Show2dModelTrainingJobResponse>);
        }
        
        /// <summary>
        /// 更新分身数字人模型训练任务
        ///
        /// 该接口用于更新分身数字人模型训练任务。用于在自动审核或者人工审核不通过情况下，更新训练视频、身份证照片等。
        /// &gt; * 该接口只能在AUTO_VERIFY_FAILED或者MANUAL_VERIFY_FAILED状态下调用
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public Update2dModelTrainingJobResponse Update2dModelTrainingJob(Update2dModelTrainingJobRequest update2dModelTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", update2dModelTrainingJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-training-manage/user/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", update2dModelTrainingJobRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<Update2dModelTrainingJobResponse>(response);
        }

        public SyncInvoker<Update2dModelTrainingJobResponse> Update2dModelTrainingJobInvoker(Update2dModelTrainingJobRequest update2dModelTrainingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", update2dModelTrainingJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-training-manage/user/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", update2dModelTrainingJobRequest);
            return new SyncInvoker<Update2dModelTrainingJobResponse>(this, "PUT", request, JsonUtils.DeSerialize<Update2dModelTrainingJobResponse>);
        }
        
        /// <summary>
        /// 创建语音驱动表情动画任务
        ///
        /// 该接口用于创建驱动数字人表情的任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateFacialAnimationsResponse CreateFacialAnimations(CreateFacialAnimationsRequest createFacialAnimationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsa/fas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", createFacialAnimationsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateFacialAnimationsResponse>(response);
        }

        public SyncInvoker<CreateFacialAnimationsResponse> CreateFacialAnimationsInvoker(CreateFacialAnimationsRequest createFacialAnimationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsa/fas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", createFacialAnimationsRequest);
            return new SyncInvoker<CreateFacialAnimationsResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateFacialAnimationsResponse>);
        }
        
        /// <summary>
        /// 创建语音驱动任务
        ///
        /// 该接口用于创建驱动数字人表情、动作及语音的任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTtsaResponse CreateTtsa(CreateTtsaRequest createTtsaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsa-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTtsaRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateTtsaResponse>(response);
        }

        public SyncInvoker<CreateTtsaResponse> CreateTtsaInvoker(CreateTtsaRequest createTtsaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsa-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTtsaRequest);
            return new SyncInvoker<CreateTtsaResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTtsaResponse>);
        }
        
        /// <summary>
        /// 获取语音驱动表情数据
        ///
        /// 该接口用于获取生成的数字人表情驱动数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFacialAnimationsDataResponse ListFacialAnimationsData(ListFacialAnimationsDataRequest listFacialAnimationsDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listFacialAnimationsDataRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/fas-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFacialAnimationsDataRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFacialAnimationsDataResponse>(response);
        }

        public SyncInvoker<ListFacialAnimationsDataResponse> ListFacialAnimationsDataInvoker(ListFacialAnimationsDataRequest listFacialAnimationsDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listFacialAnimationsDataRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/fas-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFacialAnimationsDataRequest);
            return new SyncInvoker<ListFacialAnimationsDataResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFacialAnimationsDataResponse>);
        }
        
        /// <summary>
        /// 获取语音驱动数据
        ///
        /// 该接口用于获取生成的数字人驱动数据，包括语音、表情、动作等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTtsaDataResponse ListTtsaData(ListTtsaDataRequest listTtsaDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listTtsaDataRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsa-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTtsaDataRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTtsaDataResponse>(response);
        }

        public SyncInvoker<ListTtsaDataResponse> ListTtsaDataInvoker(ListTtsaDataRequest listTtsaDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listTtsaDataRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsa-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTtsaDataRequest);
            return new SyncInvoker<ListTtsaDataResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTtsaDataResponse>);
        }
        
        /// <summary>
        /// 获取语音驱动任务列表
        ///
        /// 该接口用于查询驱动数字人表情、动作及语音的任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTtsaJobsResponse ListTtsaJobs(ListTtsaJobsRequest listTtsaJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsa-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTtsaJobsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTtsaJobsResponse>(response);
        }

        public SyncInvoker<ListTtsaJobsResponse> ListTtsaJobsInvoker(ListTtsaJobsRequest listTtsaJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsa-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTtsaJobsRequest);
            return new SyncInvoker<ListTtsaJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTtsaJobsResponse>);
        }
        
        /// <summary>
        /// 创建TTS异步任务
        ///
        /// 该接口用于对外生成音频文件。每个预置音色的计费标准详见[预置音色计费标准](metastudio_02_0060.xml)。
        /// 
        /// &gt; 使用本接口前，需要在MetaStudio控制台服务概览页面，开通“声音合成”的按需计费。
        /// &gt; 详细操作为：单击“声音合成”卡片中的“去开通”，在弹出的“开通按需计费服务提示”对话框中，勾选同意协议。单击“确定”，开通按需计费。
        /// &gt; 如需使用第三方声音进行语音合成，请购买出门问问声音套餐，操作请参考《用户指南》的“购买出门问问声音套餐”章节。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAsyncTtsJobResponse CreateAsyncTtsJob(CreateAsyncTtsJobRequest createAsyncTtsJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/async-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAsyncTtsJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAsyncTtsJobResponse>(response);
        }

        public SyncInvoker<CreateAsyncTtsJobResponse> CreateAsyncTtsJobInvoker(CreateAsyncTtsJobRequest createAsyncTtsJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/async-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAsyncTtsJobRequest);
            return new SyncInvoker<CreateAsyncTtsJobResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAsyncTtsJobResponse>);
        }
        
        /// <summary>
        /// 创建TTS试听任务
        ///
        /// 该接口用于创建生成播报内容的语音试听文件任务。
        /// 
        /// [第三方音色试听需要收费，收费标准参考：https://marketplace.huaweicloud.com/product/OFFI919400645308506112#productid&#x3D;OFFI919400645308506112](tag:hc)
        /// 
        /// [第三方音色试听需要收费，收费标准参考：https://marketplace.huaweicloud.com/intl/contents/939bf377-3005-472b-a4e2-383911e6102f](tag:hk)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTtsAuditionResponse CreateTtsAudition(CreateTtsAuditionRequest createTtsAuditionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/audition", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTtsAuditionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateTtsAuditionResponse>(response);
        }

        public SyncInvoker<CreateTtsAuditionResponse> CreateTtsAuditionInvoker(CreateTtsAuditionRequest createTtsAuditionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/audition", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTtsAuditionRequest);
            return new SyncInvoker<CreateTtsAuditionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTtsAuditionResponse>);
        }
        
        /// <summary>
        /// 设置TTS租户级自定义读法配置
        ///
        /// 该接口用于设置TTS租户级自定义读法配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTtscVocabularyConfigsResponse CreateTtscVocabularyConfigs(CreateTtscVocabularyConfigsRequest createTtscVocabularyConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/vocabulary-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTtscVocabularyConfigsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateTtscVocabularyConfigsResponse>(response);
        }

        public SyncInvoker<CreateTtscVocabularyConfigsResponse> CreateTtscVocabularyConfigsInvoker(CreateTtscVocabularyConfigsRequest createTtscVocabularyConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/vocabulary-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTtscVocabularyConfigsRequest);
            return new SyncInvoker<CreateTtscVocabularyConfigsResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTtscVocabularyConfigsResponse>);
        }
        
        /// <summary>
        /// 删除TTS租户级自定义读法配置
        ///
        /// 该接口用于删除TTS租户级自定义读法配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTtscVocabularyConfigsResponse DeleteTtscVocabularyConfigs(DeleteTtscVocabularyConfigsRequest deleteTtscVocabularyConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/vocabulary-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTtscVocabularyConfigsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTtscVocabularyConfigsResponse>(response);
        }

        public SyncInvoker<DeleteTtscVocabularyConfigsResponse> DeleteTtscVocabularyConfigsInvoker(DeleteTtscVocabularyConfigsRequest deleteTtscVocabularyConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/vocabulary-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTtscVocabularyConfigsRequest);
            return new SyncInvoker<DeleteTtscVocabularyConfigsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTtscVocabularyConfigsResponse>);
        }
        
        /// <summary>
        /// 获取TTS租户级自定义读法配置
        ///
        /// 该接口用于获取TTS租户级自定义读法配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTtscVocabularyConfigsResponse ListTtscVocabularyConfigs(ListTtscVocabularyConfigsRequest listTtscVocabularyConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/vocabulary-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTtscVocabularyConfigsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTtscVocabularyConfigsResponse>(response);
        }

        public SyncInvoker<ListTtscVocabularyConfigsResponse> ListTtscVocabularyConfigsInvoker(ListTtscVocabularyConfigsRequest listTtscVocabularyConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/vocabulary-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTtscVocabularyConfigsRequest);
            return new SyncInvoker<ListTtscVocabularyConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTtscVocabularyConfigsResponse>);
        }
        
        /// <summary>
        /// 修改TTS租户级自定义读法配置
        ///
        /// 该接口用于修改TTS租户级自定义读法配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SaveTtscVocabularyConfigsResponse SaveTtscVocabularyConfigs(SaveTtscVocabularyConfigsRequest saveTtscVocabularyConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vocabulary_id", saveTtscVocabularyConfigsRequest.VocabularyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/vocabulary-configs/{vocabulary_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", saveTtscVocabularyConfigsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<SaveTtscVocabularyConfigsResponse>(response);
        }

        public SyncInvoker<SaveTtscVocabularyConfigsResponse> SaveTtscVocabularyConfigsInvoker(SaveTtscVocabularyConfigsRequest saveTtscVocabularyConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vocabulary_id", saveTtscVocabularyConfigsRequest.VocabularyId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/vocabulary-configs/{vocabulary_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", saveTtscVocabularyConfigsRequest);
            return new SyncInvoker<SaveTtscVocabularyConfigsResponse>(this, "PUT", request, JsonUtils.DeSerialize<SaveTtscVocabularyConfigsResponse>);
        }
        
        /// <summary>
        /// 获取TTS异步任务
        ///
        /// 该接口用于获取TTS音频文件下载链接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAsyncTtsJobResponse ShowAsyncTtsJob(ShowAsyncTtsJobRequest showAsyncTtsJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showAsyncTtsJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/async-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAsyncTtsJobRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAsyncTtsJobResponse>(response);
        }

        public SyncInvoker<ShowAsyncTtsJobResponse> ShowAsyncTtsJobInvoker(ShowAsyncTtsJobRequest showAsyncTtsJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showAsyncTtsJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/async-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAsyncTtsJobRequest);
            return new SyncInvoker<ShowAsyncTtsJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAsyncTtsJobResponse>);
        }
        
        /// <summary>
        /// 获取TTS试听文件
        ///
        /// 该接口用于获取TTS试听文件下载链接，返回List中包含当前已生产的试听文件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTtsAuditionFileResponse ShowTtsAuditionFile(ShowTtsAuditionFileRequest showTtsAuditionFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showTtsAuditionFileRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/audition-file/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTtsAuditionFileRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTtsAuditionFileResponse>(response);
        }

        public SyncInvoker<ShowTtsAuditionFileResponse> ShowTtsAuditionFileInvoker(ShowTtsAuditionFileRequest showTtsAuditionFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showTtsAuditionFileRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/audition-file/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTtsAuditionFileRequest);
            return new SyncInvoker<ShowTtsAuditionFileResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTtsAuditionFileResponse>);
        }
        
        /// <summary>
        /// 获取英文单词音标
        ///
        /// 根据英文单词返回对应音标列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTtsPhoneticSymbolResponse ShowTtsPhoneticSymbol(ShowTtsPhoneticSymbolRequest showTtsPhoneticSymbolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/phonetic-symbol", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTtsPhoneticSymbolRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTtsPhoneticSymbolResponse>(response);
        }

        public SyncInvoker<ShowTtsPhoneticSymbolResponse> ShowTtsPhoneticSymbolInvoker(ShowTtsPhoneticSymbolRequest showTtsPhoneticSymbolRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ttsc/phonetic-symbol", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTtsPhoneticSymbolRequest);
            return new SyncInvoker<ShowTtsPhoneticSymbolResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTtsPhoneticSymbolResponse>);
        }
        
        /// <summary>
        /// 创建视频驱动任务
        ///
        /// 该接口用于创建视频驱动任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateVideoMotionCaptureJobResponse CreateVideoMotionCaptureJob(CreateVideoMotionCaptureJobRequest createVideoMotionCaptureJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/video-motion-capture-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVideoMotionCaptureJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateVideoMotionCaptureJobResponse>(response);
        }

        public SyncInvoker<CreateVideoMotionCaptureJobResponse> CreateVideoMotionCaptureJobInvoker(CreateVideoMotionCaptureJobRequest createVideoMotionCaptureJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/video-motion-capture-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVideoMotionCaptureJobRequest);
            return new SyncInvoker<CreateVideoMotionCaptureJobResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateVideoMotionCaptureJobResponse>);
        }
        
        /// <summary>
        /// 控制数字人驱动
        ///
        /// 该接口用于控制数字人驱动。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExecuteVideoMotionCaptureCommandResponse ExecuteVideoMotionCaptureCommand(ExecuteVideoMotionCaptureCommandRequest executeVideoMotionCaptureCommandRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", executeVideoMotionCaptureCommandRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/video-motion-capture-jobs/{job_id}/command", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeVideoMotionCaptureCommandRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ExecuteVideoMotionCaptureCommandResponse>(response);
        }

        public SyncInvoker<ExecuteVideoMotionCaptureCommandResponse> ExecuteVideoMotionCaptureCommandInvoker(ExecuteVideoMotionCaptureCommandRequest executeVideoMotionCaptureCommandRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", executeVideoMotionCaptureCommandRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/video-motion-capture-jobs/{job_id}/command", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeVideoMotionCaptureCommandRequest);
            return new SyncInvoker<ExecuteVideoMotionCaptureCommandResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ExecuteVideoMotionCaptureCommandResponse>);
        }
        
        /// <summary>
        /// 查询视频驱动任务列表
        ///
        /// 该接口用于查询视频驱动任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListVideoMotionCaptureJobsResponse ListVideoMotionCaptureJobs(ListVideoMotionCaptureJobsRequest listVideoMotionCaptureJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/video-motion-capture-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVideoMotionCaptureJobsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListVideoMotionCaptureJobsResponse>(response);
        }

        public SyncInvoker<ListVideoMotionCaptureJobsResponse> ListVideoMotionCaptureJobsInvoker(ListVideoMotionCaptureJobsRequest listVideoMotionCaptureJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/video-motion-capture-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVideoMotionCaptureJobsRequest);
            return new SyncInvoker<ListVideoMotionCaptureJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVideoMotionCaptureJobsResponse>);
        }
        
        /// <summary>
        /// 查询视频驱动任务详情
        ///
        /// 该接口用于查询视频驱动任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowVideoMotionCaptureJobResponse ShowVideoMotionCaptureJob(ShowVideoMotionCaptureJobRequest showVideoMotionCaptureJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showVideoMotionCaptureJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/video-motion-capture-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVideoMotionCaptureJobRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowVideoMotionCaptureJobResponse>(response);
        }

        public SyncInvoker<ShowVideoMotionCaptureJobResponse> ShowVideoMotionCaptureJobInvoker(ShowVideoMotionCaptureJobRequest showVideoMotionCaptureJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showVideoMotionCaptureJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/video-motion-capture-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVideoMotionCaptureJobRequest);
            return new SyncInvoker<ShowVideoMotionCaptureJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVideoMotionCaptureJobResponse>);
        }
        
        /// <summary>
        /// 停止视频驱动任务
        ///
        /// 该接口用于停止视频驱动任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StopVideoMotionCaptureJobResponse StopVideoMotionCaptureJob(StopVideoMotionCaptureJobRequest stopVideoMotionCaptureJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", stopVideoMotionCaptureJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/video-motion-capture-jobs/{job_id}/finish", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopVideoMotionCaptureJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<StopVideoMotionCaptureJobResponse>(response);
        }

        public SyncInvoker<StopVideoMotionCaptureJobResponse> StopVideoMotionCaptureJobInvoker(StopVideoMotionCaptureJobRequest stopVideoMotionCaptureJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", stopVideoMotionCaptureJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/video-motion-capture-jobs/{job_id}/finish", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopVideoMotionCaptureJobRequest);
            return new SyncInvoker<StopVideoMotionCaptureJobResponse>(this, "POST", request, JsonUtils.DeSerializeNull<StopVideoMotionCaptureJobResponse>);
        }
        
        /// <summary>
        /// 复制视频制作剧本
        ///
        /// 该接口用于复制视频制作剧本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CopyVideoScriptsResponse CopyVideoScripts(CopyVideoScriptsRequest copyVideoScriptsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("script_id", copyVideoScriptsRequest.ScriptId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-video-scripts/{script_id}/copy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", copyVideoScriptsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CopyVideoScriptsResponse>(response);
        }

        public SyncInvoker<CopyVideoScriptsResponse> CopyVideoScriptsInvoker(CopyVideoScriptsRequest copyVideoScriptsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("script_id", copyVideoScriptsRequest.ScriptId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-video-scripts/{script_id}/copy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", copyVideoScriptsRequest);
            return new SyncInvoker<CopyVideoScriptsResponse>(this, "POST", request, JsonUtils.DeSerialize<CopyVideoScriptsResponse>);
        }
        
        /// <summary>
        /// 创建视频制作剧本
        ///
        /// 该接口用于创建视频制作剧本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateVideoScriptsResponse CreateVideoScripts(CreateVideoScriptsRequest createVideoScriptsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-video-scripts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVideoScriptsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateVideoScriptsResponse>(response);
        }

        public SyncInvoker<CreateVideoScriptsResponse> CreateVideoScriptsInvoker(CreateVideoScriptsRequest createVideoScriptsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-video-scripts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVideoScriptsRequest);
            return new SyncInvoker<CreateVideoScriptsResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateVideoScriptsResponse>);
        }
        
        /// <summary>
        /// 删除视频制作剧本
        ///
        /// 该接口用于删除视频制作剧本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteVideoScriptResponse DeleteVideoScript(DeleteVideoScriptRequest deleteVideoScriptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("script_id", deleteVideoScriptRequest.ScriptId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-video-scripts/{script_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVideoScriptRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteVideoScriptResponse>(response);
        }

        public SyncInvoker<DeleteVideoScriptResponse> DeleteVideoScriptInvoker(DeleteVideoScriptRequest deleteVideoScriptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("script_id", deleteVideoScriptRequest.ScriptId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-video-scripts/{script_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVideoScriptRequest);
            return new SyncInvoker<DeleteVideoScriptResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteVideoScriptResponse>);
        }
        
        /// <summary>
        /// 查询视频制作剧本列表
        ///
        /// 该接口用于查询视频制作剧本列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListVideoScriptsResponse ListVideoScripts(ListVideoScriptsRequest listVideoScriptsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-video-scripts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVideoScriptsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListVideoScriptsResponse>(response);
        }

        public SyncInvoker<ListVideoScriptsResponse> ListVideoScriptsInvoker(ListVideoScriptsRequest listVideoScriptsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-video-scripts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVideoScriptsRequest);
            return new SyncInvoker<ListVideoScriptsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListVideoScriptsResponse>);
        }
        
        /// <summary>
        /// 查询视频制作剧本详情
        ///
        /// 该接口用于查询视频制作剧本详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowVideoScriptResponse ShowVideoScript(ShowVideoScriptRequest showVideoScriptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("script_id", showVideoScriptRequest.ScriptId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-video-scripts/{script_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVideoScriptRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowVideoScriptResponse>(response);
        }

        public SyncInvoker<ShowVideoScriptResponse> ShowVideoScriptInvoker(ShowVideoScriptRequest showVideoScriptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("script_id", showVideoScriptRequest.ScriptId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-video-scripts/{script_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVideoScriptRequest);
            return new SyncInvoker<ShowVideoScriptResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVideoScriptResponse>);
        }
        
        /// <summary>
        /// 更新视频制作剧本
        ///
        /// 该接口用于更新视频制作剧本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateVideoScriptResponse UpdateVideoScript(UpdateVideoScriptRequest updateVideoScriptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("script_id", updateVideoScriptRequest.ScriptId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-video-scripts/{script_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateVideoScriptRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateVideoScriptResponse>(response);
        }

        public SyncInvoker<UpdateVideoScriptResponse> UpdateVideoScriptInvoker(UpdateVideoScriptRequest updateVideoScriptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("script_id", updateVideoScriptRequest.ScriptId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-video-scripts/{script_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateVideoScriptRequest);
            return new SyncInvoker<UpdateVideoScriptResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateVideoScriptResponse>);
        }
        
        /// <summary>
        /// 创建欢迎词
        ///
        /// 该接口用于创建欢迎词。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateWelcomeSpeechResponse CreateWelcomeSpeech(CreateWelcomeSpeechRequest createWelcomeSpeechRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/welcome-speech", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWelcomeSpeechRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateWelcomeSpeechResponse>(response);
        }

        public SyncInvoker<CreateWelcomeSpeechResponse> CreateWelcomeSpeechInvoker(CreateWelcomeSpeechRequest createWelcomeSpeechRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/welcome-speech", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWelcomeSpeechRequest);
            return new SyncInvoker<CreateWelcomeSpeechResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateWelcomeSpeechResponse>);
        }
        
        /// <summary>
        /// 删除欢迎词
        ///
        /// 该接口用于删除欢迎词。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteWelcomeSpeechResponse DeleteWelcomeSpeech(DeleteWelcomeSpeechRequest deleteWelcomeSpeechRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/welcome-speech/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWelcomeSpeechRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DeleteWelcomeSpeechResponse>(response);
        }

        public SyncInvoker<DeleteWelcomeSpeechResponse> DeleteWelcomeSpeechInvoker(DeleteWelcomeSpeechRequest deleteWelcomeSpeechRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/welcome-speech/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteWelcomeSpeechRequest);
            return new SyncInvoker<DeleteWelcomeSpeechResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeleteWelcomeSpeechResponse>);
        }
        
        /// <summary>
        /// 查询欢迎词列表
        ///
        /// 该接口用于查询欢迎词列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListWelcomeSpeechResponse ListWelcomeSpeech(ListWelcomeSpeechRequest listWelcomeSpeechRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/welcome-speech", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWelcomeSpeechRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListWelcomeSpeechResponse>(response);
        }

        public SyncInvoker<ListWelcomeSpeechResponse> ListWelcomeSpeechInvoker(ListWelcomeSpeechRequest listWelcomeSpeechRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/welcome-speech", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWelcomeSpeechRequest);
            return new SyncInvoker<ListWelcomeSpeechResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWelcomeSpeechResponse>);
        }
        
        /// <summary>
        /// 查询欢迎词详情
        ///
        /// 该接口用于查询欢迎词详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowWelcomeSpeechResponse ShowWelcomeSpeech(ShowWelcomeSpeechRequest showWelcomeSpeechRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("welcome_speech_id", showWelcomeSpeechRequest.WelcomeSpeechId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/welcome-speech/{welcome_speech_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWelcomeSpeechRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowWelcomeSpeechResponse>(response);
        }

        public SyncInvoker<ShowWelcomeSpeechResponse> ShowWelcomeSpeechInvoker(ShowWelcomeSpeechRequest showWelcomeSpeechRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("welcome_speech_id", showWelcomeSpeechRequest.WelcomeSpeechId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/welcome-speech/{welcome_speech_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWelcomeSpeechRequest);
            return new SyncInvoker<ShowWelcomeSpeechResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWelcomeSpeechResponse>);
        }
        
        /// <summary>
        /// 查询欢迎词功能开关
        ///
        /// 该接口用于查询欢迎词功能开关。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowWelcomeSpeechSwitchResponse ShowWelcomeSpeechSwitch(ShowWelcomeSpeechSwitchRequest showWelcomeSpeechSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/welcome-speech-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWelcomeSpeechSwitchRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowWelcomeSpeechSwitchResponse>(response);
        }

        public SyncInvoker<ShowWelcomeSpeechSwitchResponse> ShowWelcomeSpeechSwitchInvoker(ShowWelcomeSpeechSwitchRequest showWelcomeSpeechSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/welcome-speech-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWelcomeSpeechSwitchRequest);
            return new SyncInvoker<ShowWelcomeSpeechSwitchResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWelcomeSpeechSwitchResponse>);
        }
        
        /// <summary>
        /// 修改欢迎词
        ///
        /// 该接口用于修改欢迎词。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateWelcomeSpeechResponse UpdateWelcomeSpeech(UpdateWelcomeSpeechRequest updateWelcomeSpeechRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("welcome_speech_id", updateWelcomeSpeechRequest.WelcomeSpeechId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/welcome-speech/{welcome_speech_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWelcomeSpeechRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateWelcomeSpeechResponse>(response);
        }

        public SyncInvoker<UpdateWelcomeSpeechResponse> UpdateWelcomeSpeechInvoker(UpdateWelcomeSpeechRequest updateWelcomeSpeechRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("welcome_speech_id", updateWelcomeSpeechRequest.WelcomeSpeechId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/welcome-speech/{welcome_speech_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWelcomeSpeechRequest);
            return new SyncInvoker<UpdateWelcomeSpeechResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateWelcomeSpeechResponse>);
        }
        
        /// <summary>
        /// 修改欢迎词功能开关
        ///
        /// 该接口用于修改欢迎词功能开关。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateWelcomeSpeechSwitchResponse UpdateWelcomeSpeechSwitch(UpdateWelcomeSpeechSwitchRequest updateWelcomeSpeechSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/welcome-speech-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWelcomeSpeechSwitchRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateWelcomeSpeechSwitchResponse>(response);
        }

        public SyncInvoker<UpdateWelcomeSpeechSwitchResponse> UpdateWelcomeSpeechSwitchInvoker(UpdateWelcomeSpeechSwitchRequest updateWelcomeSpeechSwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/digital-human-chat/welcome-speech-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWelcomeSpeechSwitchRequest);
            return new SyncInvoker<UpdateWelcomeSpeechSwitchResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateWelcomeSpeechSwitchResponse>);
        }
        
    }
}