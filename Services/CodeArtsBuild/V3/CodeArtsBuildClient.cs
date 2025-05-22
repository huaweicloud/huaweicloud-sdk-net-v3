using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.CodeArtsBuild.V3.Model;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3
{
    public partial class CodeArtsBuildClient : Client
    {
        public static ClientBuilder<CodeArtsBuildClient> NewBuilder()
        {
            return new ClientBuilder<CodeArtsBuildClient>();
        }

        
        /// <summary>
        /// 创建构建任务
        ///
        /// 创建构建任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateBuildJobResponse CreateBuildJob(CreateBuildJobRequest createBuildJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBuildJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateBuildJobResponse>(response);
        }

        public SyncInvoker<CreateBuildJobResponse> CreateBuildJobInvoker(CreateBuildJobRequest createBuildJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBuildJobRequest);
            return new SyncInvoker<CreateBuildJobResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateBuildJobResponse>);
        }
        
        /// <summary>
        /// 创建构建模板
        ///
        /// 创建构建模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTemplatesResponse CreateTemplates(CreateTemplatesRequest createTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/templates/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTemplatesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateTemplatesResponse>(response);
        }

        public SyncInvoker<CreateTemplatesResponse> CreateTemplatesInvoker(CreateTemplatesRequest createTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/templates/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTemplatesRequest);
            return new SyncInvoker<CreateTemplatesResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTemplatesResponse>);
        }
        
        /// <summary>
        /// 删除构建任务
        ///
        /// 删除构建任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteBuildJobResponse DeleteBuildJob(DeleteBuildJobRequest deleteBuildJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", deleteBuildJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBuildJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DeleteBuildJobResponse>(response);
        }

        public SyncInvoker<DeleteBuildJobResponse> DeleteBuildJobInvoker(DeleteBuildJobRequest deleteBuildJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", deleteBuildJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBuildJobRequest);
            return new SyncInvoker<DeleteBuildJobResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteBuildJobResponse>);
        }
        
        /// <summary>
        /// 删除构建模板
        ///
        /// 删除构建模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTemplatesResponse DeleteTemplates(DeleteTemplatesRequest deleteTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("uuid", deleteTemplatesRequest.Uuid.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/templates/{uuid}/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplatesRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteTemplatesResponse>(response);
        }

        public SyncInvoker<DeleteTemplatesResponse> DeleteTemplatesInvoker(DeleteTemplatesRequest deleteTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("uuid", deleteTemplatesRequest.Uuid.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/templates/{uuid}/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplatesRequest);
            return new SyncInvoker<DeleteTemplatesResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteTemplatesResponse>);
        }
        
        /// <summary>
        /// 禁用构建任务
        ///
        /// 禁用构建任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisableBuildJobResponse DisableBuildJob(DisableBuildJobRequest disableBuildJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", disableBuildJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableBuildJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DisableBuildJobResponse>(response);
        }

        public SyncInvoker<DisableBuildJobResponse> DisableBuildJobInvoker(DisableBuildJobRequest disableBuildJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", disableBuildJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableBuildJobRequest);
            return new SyncInvoker<DisableBuildJobResponse>(this, "POST", request, JsonUtils.DeSerialize<DisableBuildJobResponse>);
        }
        
        /// <summary>
        /// 取消通知
        ///
        /// 取消通知
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisableNoticeResponse DisableNotice(DisableNoticeRequest disableNoticeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", disableNoticeRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/notice/{job_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableNoticeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DisableNoticeResponse>(response);
        }

        public SyncInvoker<DisableNoticeResponse> DisableNoticeInvoker(DisableNoticeRequest disableNoticeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", disableNoticeRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/notice/{job_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableNoticeRequest);
            return new SyncInvoker<DisableNoticeResponse>(this, "POST", request, JsonUtils.DeSerialize<DisableNoticeResponse>);
        }
        
        /// <summary>
        /// 下载全量构建日志
        ///
        /// 下载全量构建日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DownloadBuildLogResponse DownloadBuildLog(DownloadBuildLogRequest downloadBuildLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("record_id", downloadBuildLogRequest.RecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/{record_id}/download-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadBuildLogRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DownloadBuildLogResponse>(response);
        }

        public SyncInvoker<DownloadBuildLogResponse> DownloadBuildLogInvoker(DownloadBuildLogRequest downloadBuildLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("record_id", downloadBuildLogRequest.RecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/{record_id}/download-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadBuildLogRequest);
            return new SyncInvoker<DownloadBuildLogResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadBuildLogResponse>);
        }
        
        /// <summary>
        /// KeyStore文件下载
        ///
        /// 下载指定租户下的KeyStore文件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DownloadKeystoreResponse DownloadKeystore(DownloadKeystoreRequest downloadKeystoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/keystore", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadKeystoreRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DownloadKeystoreResponse>(response);
        }

        public SyncInvoker<DownloadKeystoreResponse> DownloadKeystoreInvoker(DownloadKeystoreRequest downloadKeystoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/keystore", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadKeystoreRequest);
            return new SyncInvoker<DownloadKeystoreResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadKeystoreResponse>);
        }
        
        /// <summary>
        /// 下载构建实时日志
        ///
        /// 下载构建实时日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DownloadRealTimeLogResponse DownloadRealTimeLog(DownloadRealTimeLogRequest downloadRealTimeLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", downloadRealTimeLogRequest.JobId.ToString());
            urlParam.Add("build_no", downloadRealTimeLogRequest.BuildNo.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/{build_no}/real-time-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadRealTimeLogRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DownloadRealTimeLogResponse>(response);
        }

        public SyncInvoker<DownloadRealTimeLogResponse> DownloadRealTimeLogInvoker(DownloadRealTimeLogRequest downloadRealTimeLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", downloadRealTimeLogRequest.JobId.ToString());
            urlParam.Add("build_no", downloadRealTimeLogRequest.BuildNo.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/{build_no}/real-time-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadRealTimeLogRequest);
            return new SyncInvoker<DownloadRealTimeLogResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadRealTimeLogResponse>);
        }
        
        /// <summary>
        /// 下载构建步骤日志
        ///
        /// 下载构建步骤日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DownloadTaskLogResponse DownloadTaskLog(DownloadTaskLogRequest downloadTaskLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("record_id", downloadTaskLogRequest.RecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/{record_id}/task-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadTaskLogRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DownloadTaskLogResponse>(response);
        }

        public SyncInvoker<DownloadTaskLogResponse> DownloadTaskLogInvoker(DownloadTaskLogRequest downloadTaskLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("record_id", downloadTaskLogRequest.RecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/{record_id}/task-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadTaskLogRequest);
            return new SyncInvoker<DownloadTaskLogResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadTaskLogResponse>);
        }
        
        /// <summary>
        /// 恢复构建任务
        ///
        /// 恢复构建任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EnableBuildJobResponse EnableBuildJob(EnableBuildJobRequest enableBuildJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", enableBuildJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/recover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableBuildJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<EnableBuildJobResponse>(response);
        }

        public SyncInvoker<EnableBuildJobResponse> EnableBuildJobInvoker(EnableBuildJobRequest enableBuildJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", enableBuildJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/recover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableBuildJobRequest);
            return new SyncInvoker<EnableBuildJobResponse>(this, "POST", request, JsonUtils.DeSerialize<EnableBuildJobResponse>);
        }
        
        /// <summary>
        /// 获取任务构建记录列表
        ///
        /// 获取任务构建记录列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBuildInfoRecordResponse ListBuildInfoRecord(ListBuildInfoRecordRequest listBuildInfoRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listBuildInfoRecordRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/build-info-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBuildInfoRecordRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBuildInfoRecordResponse>(response);
        }

        public SyncInvoker<ListBuildInfoRecordResponse> ListBuildInfoRecordInvoker(ListBuildInfoRecordRequest listBuildInfoRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listBuildInfoRecordRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/build-info-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBuildInfoRecordRequest);
            return new SyncInvoker<ListBuildInfoRecordResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBuildInfoRecordResponse>);
        }
        
        /// <summary>
        /// 获取构建任务详情
        ///
        /// 获取构建任务详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListJobConfigResponse ListJobConfig(ListJobConfigRequest listJobConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listJobConfigRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListJobConfigResponse>(response);
        }

        public SyncInvoker<ListJobConfigResponse> ListJobConfigInvoker(ListJobConfigRequest listJobConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listJobConfigRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobConfigRequest);
            return new SyncInvoker<ListJobConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ListJobConfigResponse>);
        }
        
        /// <summary>
        /// 查询通知
        ///
        /// 查询通知
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListNoticeResponse ListNotice(ListNoticeRequest listNoticeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listNoticeRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/notice/{job_id}/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNoticeRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListNoticeResponse>(response);
        }

        public SyncInvoker<ListNoticeResponse> ListNoticeInvoker(ListNoticeRequest listNoticeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listNoticeRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/notice/{job_id}/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNoticeRequest);
            return new SyncInvoker<ListNoticeResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNoticeResponse>);
        }
        
        /// <summary>
        /// 查询构建模板
        ///
        /// 查询构建模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTemplatesResponse ListTemplates(ListTemplatesRequest listTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/templates/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTemplatesResponse>(response);
        }

        public SyncInvoker<ListTemplatesResponse> ListTemplatesInvoker(ListTemplatesRequest listTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/templates/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplatesRequest);
            return new SyncInvoker<ListTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTemplatesResponse>);
        }
        
        /// <summary>
        /// 执行构建任务
        ///
        /// 执行构建任务,可传自定义参数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunJobResponse RunJob(RunJobRequest runJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/build", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RunJobResponse>(response);
        }

        public SyncInvoker<RunJobResponse> RunJobInvoker(RunJobRequest runJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/build", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runJobRequest);
            return new SyncInvoker<RunJobResponse>(this, "POST", request, JsonUtils.DeSerialize<RunJobResponse>);
        }
        
        /// <summary>
        /// 获取任务各阶段信息
        ///
        /// 获取任务各阶段信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBuildRecordFullStagesResponse ShowBuildRecordFullStages(ShowBuildRecordFullStagesRequest showBuildRecordFullStagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("record_id", showBuildRecordFullStagesRequest.RecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/record/{record_id}/full-stages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBuildRecordFullStagesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBuildRecordFullStagesResponse>(response);
        }

        public SyncInvoker<ShowBuildRecordFullStagesResponse> ShowBuildRecordFullStagesInvoker(ShowBuildRecordFullStagesRequest showBuildRecordFullStagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("record_id", showBuildRecordFullStagesRequest.RecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/record/{record_id}/full-stages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBuildRecordFullStagesRequest);
            return new SyncInvoker<ShowBuildRecordFullStagesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBuildRecordFullStagesResponse>);
        }
        
        /// <summary>
        /// 获取构建历史详情信息接口
        ///
        /// 获取构建历史详情信息接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowHistoryDetailsResponse ShowHistoryDetails(ShowHistoryDetailsRequest showHistoryDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showHistoryDetailsRequest.JobId.ToString());
            urlParam.Add("build_number", showHistoryDetailsRequest.BuildNumber.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/{build_number}/history-details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHistoryDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowHistoryDetailsResponse>(response);
        }

        public SyncInvoker<ShowHistoryDetailsResponse> ShowHistoryDetailsInvoker(ShowHistoryDetailsRequest showHistoryDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showHistoryDetailsRequest.JobId.ToString());
            urlParam.Add("build_number", showHistoryDetailsRequest.BuildNumber.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/{build_number}/history-details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHistoryDetailsRequest);
            return new SyncInvoker<ShowHistoryDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHistoryDetailsResponse>);
        }
        
        /// <summary>
        /// 查询构建成功率
        ///
        /// 查询构建成功率
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowJobBuildSuccessRatioResponse ShowJobBuildSuccessRatio(ShowJobBuildSuccessRatioRequest showJobBuildSuccessRatioRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/report/ratio", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobBuildSuccessRatioRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowJobBuildSuccessRatioResponse>(response);
        }

        public SyncInvoker<ShowJobBuildSuccessRatioResponse> ShowJobBuildSuccessRatioInvoker(ShowJobBuildSuccessRatioRequest showJobBuildSuccessRatioRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/report/ratio", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobBuildSuccessRatioRequest);
            return new SyncInvoker<ShowJobBuildSuccessRatioResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobBuildSuccessRatioResponse>);
        }
        
        /// <summary>
        /// 查看项目下用户的构建任务列表
        ///
        /// 查看项目下用户的构建任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowJobListByProjectIdResponse ShowJobListByProjectId(ShowJobListByProjectIdRequest showJobListByProjectIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", showJobListByProjectIdRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobListByProjectIdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowJobListByProjectIdResponse>(response);
        }

        public SyncInvoker<ShowJobListByProjectIdResponse> ShowJobListByProjectIdInvoker(ShowJobListByProjectIdRequest showJobListByProjectIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", showJobListByProjectIdRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobListByProjectIdRequest);
            return new SyncInvoker<ShowJobListByProjectIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobListByProjectIdResponse>);
        }
        
        /// <summary>
        /// 查看任务运行状态
        ///
        /// 查看任务运行状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowJobStatusResponse ShowJobStatus(ShowJobStatusRequest showJobStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobStatusRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowJobStatusResponse>(response);
        }

        public SyncInvoker<ShowJobStatusResponse> ShowJobStatusInvoker(ShowJobStatusRequest showJobStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobStatusRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobStatusRequest);
            return new SyncInvoker<ShowJobStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobStatusResponse>);
        }
        
        /// <summary>
        /// 根据开始时间和结束时间查看构建任务的构建成功率
        ///
        /// 根据开始时间和结束时间查看构建任务的构建成功率
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowJobSuccessRatioResponse ShowJobSuccessRatio(ShowJobSuccessRatioRequest showJobSuccessRatioRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobSuccessRatioRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/success-ratio", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobSuccessRatioRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowJobSuccessRatioResponse>(response);
        }

        public SyncInvoker<ShowJobSuccessRatioResponse> ShowJobSuccessRatioInvoker(ShowJobSuccessRatioRequest showJobSuccessRatioRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobSuccessRatioRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/success-ratio", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobSuccessRatioRequest);
            return new SyncInvoker<ShowJobSuccessRatioResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobSuccessRatioResponse>);
        }
        
        /// <summary>
        /// 查询指定代码仓库最近一次成功的构建历史
        ///
        /// 查询指定代码仓库最近一次成功的构建历史
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowLastHistoryResponse ShowLastHistory(ShowLastHistoryRequest showLastHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", showLastHistoryRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{project_id}/last-history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLastHistoryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowLastHistoryResponse>(response);
        }

        public SyncInvoker<ShowLastHistoryResponse> ShowLastHistoryInvoker(ShowLastHistoryRequest showLastHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", showLastHistoryRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{project_id}/last-history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLastHistoryRequest);
            return new SyncInvoker<ShowLastHistoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLastHistoryResponse>);
        }
        
        /// <summary>
        /// 查看构建任务的构建历史列表
        ///
        /// 查看构建任务的构建历史列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowListHistoryResponse ShowListHistory(ShowListHistoryRequest showListHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showListHistoryRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showListHistoryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowListHistoryResponse>(response);
        }

        public SyncInvoker<ShowListHistoryResponse> ShowListHistoryInvoker(ShowListHistoryRequest showListHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showListHistoryRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showListHistoryRequest);
            return new SyncInvoker<ShowListHistoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowListHistoryResponse>);
        }
        
        /// <summary>
        /// 根据开始时间和结束时间查看构建任务的构建历史列表
        ///
        /// 根据开始时间和结束时间查看构建任务的构建历史列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowListPeriodHistoryResponse ShowListPeriodHistory(ShowListPeriodHistoryRequest showListPeriodHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showListPeriodHistoryRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/period-history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showListPeriodHistoryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowListPeriodHistoryResponse>(response);
        }

        public SyncInvoker<ShowListPeriodHistoryResponse> ShowListPeriodHistoryInvoker(ShowListPeriodHistoryRequest showListPeriodHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showListPeriodHistoryRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/period-history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showListPeriodHistoryRequest);
            return new SyncInvoker<ShowListPeriodHistoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowListPeriodHistoryResponse>);
        }
        
        /// <summary>
        /// 获取构建产物详情信息
        ///
        /// 获取构建产物详情信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowOutputInfoResponse ShowOutputInfo(ShowOutputInfoRequest showOutputInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showOutputInfoRequest.JobId.ToString());
            urlParam.Add("build_no", showOutputInfoRequest.BuildNo.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/{build_no}/output-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOutputInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowOutputInfoResponse>(response);
        }

        public SyncInvoker<ShowOutputInfoResponse> ShowOutputInfoInvoker(ShowOutputInfoRequest showOutputInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showOutputInfoRequest.JobId.ToString());
            urlParam.Add("build_no", showOutputInfoRequest.BuildNo.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/{build_no}/output-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOutputInfoRequest);
            return new SyncInvoker<ShowOutputInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOutputInfoResponse>);
        }
        
        /// <summary>
        /// 获取构建记录信息
        ///
        /// 获取构建记录信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRecordDetailResponse ShowRecordDetail(ShowRecordDetailRequest showRecordDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showRecordDetailRequest.JobId.ToString());
            urlParam.Add("build_no", showRecordDetailRequest.BuildNo.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/jobs/{job_id}/{build_no}/record-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRecordDetailResponse>(response);
        }

        public SyncInvoker<ShowRecordDetailResponse> ShowRecordDetailInvoker(ShowRecordDetailRequest showRecordDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showRecordDetailRequest.JobId.ToString());
            urlParam.Add("build_no", showRecordDetailRequest.BuildNo.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/jobs/{job_id}/{build_no}/record-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordDetailRequest);
            return new SyncInvoker<ShowRecordDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecordDetailResponse>);
        }
        
        /// <summary>
        /// 获取覆盖率接口
        ///
        /// 获取覆盖率接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowReportSummaryResponse ShowReportSummary(ShowReportSummaryRequest showReportSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showReportSummaryRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/report/{job_id}/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReportSummaryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowReportSummaryResponse>(response);
        }

        public SyncInvoker<ShowReportSummaryResponse> ShowReportSummaryInvoker(ShowReportSummaryRequest showReportSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showReportSummaryRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/report/{job_id}/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReportSummaryRequest);
            return new SyncInvoker<ShowReportSummaryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowReportSummaryResponse>);
        }
        
        /// <summary>
        /// 查看任务是否在构建
        ///
        /// 查看任务是否在构建
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRunningStatusResponse ShowRunningStatus(ShowRunningStatusRequest showRunningStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showRunningStatusRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/job/{job_id}/running-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRunningStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRunningStatusResponse>(response);
        }

        public SyncInvoker<ShowRunningStatusResponse> ShowRunningStatusInvoker(ShowRunningStatusRequest showRunningStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showRunningStatusRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/job/{job_id}/running-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRunningStatusRequest);
            return new SyncInvoker<ShowRunningStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRunningStatusResponse>);
        }
        
        /// <summary>
        /// 获取代码化构建默认模板
        ///
        /// 获取代码化构建默认模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowYamlTemplateResponse ShowYamlTemplate(ShowYamlTemplateRequest showYamlTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showYamlTemplateRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/template/{job_id}/default-template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showYamlTemplateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowYamlTemplateResponse>(response);
        }

        public SyncInvoker<ShowYamlTemplateResponse> ShowYamlTemplateInvoker(ShowYamlTemplateRequest showYamlTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showYamlTemplateRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/template/{job_id}/default-template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showYamlTemplateRequest);
            return new SyncInvoker<ShowYamlTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowYamlTemplateResponse>);
        }
        
        /// <summary>
        /// 停止构建任务
        ///
        /// 停止构建任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StopBuildJobResponse StopBuildJob(StopBuildJobRequest stopBuildJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", stopBuildJobRequest.JobId.ToString());
            urlParam.Add("build_no", stopBuildJobRequest.BuildNo.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/{build_no}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopBuildJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StopBuildJobResponse>(response);
        }

        public SyncInvoker<StopBuildJobResponse> StopBuildJobInvoker(StopBuildJobRequest stopBuildJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", stopBuildJobRequest.JobId.ToString());
            urlParam.Add("build_no", stopBuildJobRequest.BuildNo.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/{build_no}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopBuildJobRequest);
            return new SyncInvoker<StopBuildJobResponse>(this, "POST", request, JsonUtils.DeSerialize<StopBuildJobResponse>);
        }
        
        /// <summary>
        /// 更新构建任务
        ///
        /// 更新构建任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateBuildJobResponse UpdateBuildJob(UpdateBuildJobRequest updateBuildJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBuildJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateBuildJobResponse>(response);
        }

        public SyncInvoker<UpdateBuildJobResponse> UpdateBuildJobInvoker(UpdateBuildJobRequest updateBuildJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBuildJobRequest);
            return new SyncInvoker<UpdateBuildJobResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateBuildJobResponse>);
        }
        
        /// <summary>
        /// 更新通知
        ///
        /// 更新通知
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateNoticeResponse UpdateNotice(UpdateNoticeRequest updateNoticeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", updateNoticeRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/notice/{job_id}/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNoticeRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateNoticeResponse>(response);
        }

        public SyncInvoker<UpdateNoticeResponse> UpdateNoticeInvoker(UpdateNoticeRequest updateNoticeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", updateNoticeRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/notice/{job_id}/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNoticeRequest);
            return new SyncInvoker<UpdateNoticeResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateNoticeResponse>);
        }
        
        /// <summary>
        /// 下载构建日志(待下线)
        ///
        /// 下载构建日志(待下线)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DownloadLogByRecordIdResponse DownloadLogByRecordId(DownloadLogByRecordIdRequest downloadLogByRecordIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("record_id", downloadLogByRecordIdRequest.RecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{record_id}/download-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadLogByRecordIdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DownloadLogByRecordIdResponse>(response);
        }

        public SyncInvoker<DownloadLogByRecordIdResponse> DownloadLogByRecordIdInvoker(DownloadLogByRecordIdRequest downloadLogByRecordIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("record_id", downloadLogByRecordIdRequest.RecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{record_id}/download-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadLogByRecordIdRequest);
            return new SyncInvoker<DownloadLogByRecordIdResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadLogByRecordIdResponse>);
        }
        
        /// <summary>
        /// 获取构建记录的有向无环图(待下线)
        ///
        /// 获取构建记录的有向无环图(待下线)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowFlowGraphResponse ShowFlowGraph(ShowFlowGraphRequest showFlowGraphRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("build_flow_record_id", showFlowGraphRequest.BuildFlowRecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{build_flow_record_id}/flow-graph", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlowGraphRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowFlowGraphResponse>(response);
        }

        public SyncInvoker<ShowFlowGraphResponse> ShowFlowGraphInvoker(ShowFlowGraphRequest showFlowGraphRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("build_flow_record_id", showFlowGraphRequest.BuildFlowRecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{build_flow_record_id}/flow-graph", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlowGraphRequest);
            return new SyncInvoker<ShowFlowGraphResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFlowGraphResponse>);
        }
        
        /// <summary>
        /// 获取构建记录信息(待下线)
        ///
        /// 获取构建记录信息(待下线)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRecordInfoResponse ShowRecordInfo(ShowRecordInfoRequest showRecordInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showRecordInfoRequest.JobId.ToString());
            urlParam.Add("build_no", showRecordInfoRequest.BuildNo.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/{build_no}/record-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRecordInfoResponse>(response);
        }

        public SyncInvoker<ShowRecordInfoResponse> ShowRecordInfoInvoker(ShowRecordInfoRequest showRecordInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showRecordInfoRequest.JobId.ToString());
            urlParam.Add("build_no", showRecordInfoRequest.BuildNo.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/{build_no}/record-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordInfoRequest);
            return new SyncInvoker<ShowRecordInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecordInfoResponse>);
        }
        
        /// <summary>
        /// 停止构建任务(待下线)
        ///
        /// 停止构建任务(待下线)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StopJobResponse StopJob(StopJobRequest stopJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StopJobResponse>(response);
        }

        public SyncInvoker<StopJobResponse> StopJobInvoker(StopJobRequest stopJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopJobRequest);
            return new SyncInvoker<StopJobResponse>(this, "POST", request, JsonUtils.DeSerialize<StopJobResponse>);
        }
        
    }
}