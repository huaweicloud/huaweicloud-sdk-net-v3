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
        /// 获取项目列表
        ///
        /// 获取项目列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRelatedProjectInfoResponse ListRelatedProjectInfo(ListRelatedProjectInfoRequest listRelatedProjectInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/domain/project/related-page", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRelatedProjectInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRelatedProjectInfoResponse>(response);
        }

        public SyncInvoker<ListRelatedProjectInfoResponse> ListRelatedProjectInfoInvoker(ListRelatedProjectInfoRequest listRelatedProjectInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/domain/project/related-page", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRelatedProjectInfoRequest);
            return new SyncInvoker<ListRelatedProjectInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRelatedProjectInfoResponse>);
        }
        
        /// <summary>
        /// 获取用户权限
        ///
        /// 获取用户权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowProjectPermissionResponse ShowProjectPermission(ShowProjectPermissionRequest showProjectPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/domain/user-permission", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectPermissionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectPermissionResponse>(response);
        }

        public SyncInvoker<ShowProjectPermissionResponse> ShowProjectPermissionInvoker(ShowProjectPermissionRequest showProjectPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/domain/user-permission", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectPermissionRequest);
            return new SyncInvoker<ShowProjectPermissionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectPermissionResponse>);
        }
        
        /// <summary>
        /// 获取当前用户的项目信息列表
        ///
        /// 获取当前用户的项目信息列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRelatedProjectResponse ShowRelatedProject(ShowRelatedProjectRequest showRelatedProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/domain/project/related", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRelatedProjectRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRelatedProjectResponse>(response);
        }

        public SyncInvoker<ShowRelatedProjectResponse> ShowRelatedProjectInvoker(ShowRelatedProjectRequest showRelatedProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/domain/project/related", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRelatedProjectRequest);
            return new SyncInvoker<ShowRelatedProjectResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRelatedProjectResponse>);
        }
        
        /// <summary>
        /// 获取租户任务总数和成功率接口
        ///
        /// 获取租户任务总数和成功率接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSummaryBuildJobInfoResponse ShowSummaryBuildJobInfo(ShowSummaryBuildJobInfoRequest showSummaryBuildJobInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/domain/job-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSummaryBuildJobInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSummaryBuildJobInfoResponse>(response);
        }

        public SyncInvoker<ShowSummaryBuildJobInfoResponse> ShowSummaryBuildJobInfoInvoker(ShowSummaryBuildJobInfoRequest showSummaryBuildJobInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/domain/job-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSummaryBuildJobInfoRequest);
            return new SyncInvoker<ShowSummaryBuildJobInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSummaryBuildJobInfoResponse>);
        }
        
        /// <summary>
        /// 当前用户所在项目所属租户的包周期每月时长是否超额
        ///
        /// 当前用户所在项目所属租户的包周期每月时长是否超额
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowUserOverPackageQuotaResponse ShowUserOverPackageQuota(ShowUserOverPackageQuotaRequest showUserOverPackageQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/domain/package/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserOverPackageQuotaRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowUserOverPackageQuotaResponse>(response);
        }

        public SyncInvoker<ShowUserOverPackageQuotaResponse> ShowUserOverPackageQuotaInvoker(ShowUserOverPackageQuotaRequest showUserOverPackageQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/domain/package/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUserOverPackageQuotaRequest);
            return new SyncInvoker<ShowUserOverPackageQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUserOverPackageQuotaResponse>);
        }
        
        /// <summary>
        /// 获取dockerfileTemplate
        ///
        /// 获取dockerfileTemplate
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDockerfileTemplateResponse ShowDockerfileTemplate(ShowDockerfileTemplateRequest showDockerfileTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/image/dockerfile-template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDockerfileTemplateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDockerfileTemplateResponse>(response);
        }

        public SyncInvoker<ShowDockerfileTemplateResponse> ShowDockerfileTemplateInvoker(ShowDockerfileTemplateRequest showDockerfileTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/image/dockerfile-template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDockerfileTemplateRequest);
            return new SyncInvoker<ShowDockerfileTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDockerfileTemplateResponse>);
        }
        
        /// <summary>
        /// 获取镜像模板列表
        ///
        /// 获取镜像模板列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowImageTemplateListResponse ShowImageTemplateList(ShowImageTemplateListRequest showImageTemplateListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/image/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showImageTemplateListRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowImageTemplateListResponse>(response);
        }

        public SyncInvoker<ShowImageTemplateListResponse> ShowImageTemplateListInvoker(ShowImageTemplateListRequest showImageTemplateListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/image/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showImageTemplateListRequest);
            return new SyncInvoker<ShowImageTemplateListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowImageTemplateListResponse>);
        }
        
        /// <summary>
        /// 检查任务数量是否上限
        ///
        /// 检查任务数量是否上限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CheckJobCountIsTopLimitResponse CheckJobCountIsTopLimit(CheckJobCountIsTopLimitRequest checkJobCountIsTopLimitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/job/check/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkJobCountIsTopLimitRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CheckJobCountIsTopLimitResponse>(response);
        }

        public SyncInvoker<CheckJobCountIsTopLimitResponse> CheckJobCountIsTopLimitInvoker(CheckJobCountIsTopLimitRequest checkJobCountIsTopLimitRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/job/check/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkJobCountIsTopLimitRequest);
            return new SyncInvoker<CheckJobCountIsTopLimitResponse>(this, "GET", request, JsonUtils.DeSerialize<CheckJobCountIsTopLimitResponse>);
        }
        
        /// <summary>
        /// 查看项目下任务名是否存在
        ///
        /// 查看项目下任务名是否存在
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CheckJobNameIsExistsResponse CheckJobNameIsExists(CheckJobNameIsExistsRequest checkJobNameIsExistsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/job/check/exist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkJobNameIsExistsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CheckJobNameIsExistsResponse>(response);
        }

        public SyncInvoker<CheckJobNameIsExistsResponse> CheckJobNameIsExistsInvoker(CheckJobNameIsExistsRequest checkJobNameIsExistsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/job/check/exist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkJobNameIsExistsRequest);
            return new SyncInvoker<CheckJobNameIsExistsResponse>(this, "GET", request, JsonUtils.DeSerialize<CheckJobNameIsExistsResponse>);
        }
        
        /// <summary>
        /// 详情页获取构建参数
        ///
        /// 详情页获取构建参数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBuildParameterResponse ListBuildParameter(ListBuildParameterRequest listBuildParameterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listBuildParameterRequest.JobId.ToString());
            urlParam.Add("build_no", listBuildParameterRequest.BuildNo.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/job/{job_id}/{build_no}/history-parameters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBuildParameterRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBuildParameterResponse>(response);
        }

        public SyncInvoker<ListBuildParameterResponse> ListBuildParameterInvoker(ListBuildParameterRequest listBuildParameterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listBuildParameterRequest.JobId.ToString());
            urlParam.Add("build_no", listBuildParameterRequest.BuildNo.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/job/{job_id}/{build_no}/history-parameters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBuildParameterRequest);
            return new SyncInvoker<ListBuildParameterResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBuildParameterResponse>);
        }
        
        /// <summary>
        /// 查看用户全部的构建任务列表
        ///
        /// 查看用户全部的构建任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListJobResponse ListJob(ListJobRequest listJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/job/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListJobResponse>(response);
        }

        public SyncInvoker<ListJobResponse> ListJobInvoker(ListJobRequest listJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/job/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobRequest);
            return new SyncInvoker<ListJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ListJobResponse>);
        }
        
        /// <summary>
        /// 查询项目任务列表
        ///
        /// 查询项目任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProjectJobsResponse ListProjectJobs(ListProjectJobsRequest listProjectJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listProjectJobsRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/job/{project_id}/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectJobsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListProjectJobsResponse>(response);
        }

        public SyncInvoker<ListProjectJobsResponse> ListProjectJobsInvoker(ListProjectJobsRequest listProjectJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listProjectJobsRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/job/{project_id}/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectJobsRequest);
            return new SyncInvoker<ListProjectJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProjectJobsResponse>);
        }
        
        /// <summary>
        /// 查看回收站中删除的构建任务列表
        ///
        /// 查看回收站中删除的构建任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRecyclingJobResponse ListRecyclingJob(ListRecyclingJobRequest listRecyclingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/job/recycling-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecyclingJobRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRecyclingJobResponse>(response);
        }

        public SyncInvoker<ListRecyclingJobResponse> ListRecyclingJobInvoker(ListRecyclingJobRequest listRecyclingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/job/recycling-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecyclingJobRequest);
            return new SyncInvoker<ListRecyclingJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRecyclingJobResponse>);
        }
        
        /// <summary>
        /// 获取修改历史
        ///
        /// 获取修改历史
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUpdateJobHistoryResponse ListUpdateJobHistory(ListUpdateJobHistoryRequest listUpdateJobHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listUpdateJobHistoryRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/job/{job_id}/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUpdateJobHistoryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUpdateJobHistoryResponse>(response);
        }

        public SyncInvoker<ListUpdateJobHistoryResponse> ListUpdateJobHistoryInvoker(ListUpdateJobHistoryRequest listUpdateJobHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listUpdateJobHistoryRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/job/{job_id}/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUpdateJobHistoryRequest);
            return new SyncInvoker<ListUpdateJobHistoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUpdateJobHistoryResponse>);
        }
        
        /// <summary>
        /// 编辑页获取参数类型的接口
        ///
        /// 编辑页获取参数类型的接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBuildParamsListResponse ShowBuildParamsList(ShowBuildParamsListRequest showBuildParamsListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/job/build-params", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBuildParamsListRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBuildParamsListResponse>(response);
        }

        public SyncInvoker<ShowBuildParamsListResponse> ShowBuildParamsListInvoker(ShowBuildParamsListRequest showBuildParamsListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/job/build-params", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBuildParamsListRequest);
            return new SyncInvoker<ShowBuildParamsListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBuildParamsListResponse>);
        }
        
        /// <summary>
        /// 复制任务名
        ///
        /// 复制任务名
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowCopyNameResponse ShowCopyName(ShowCopyNameRequest showCopyNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showCopyNameRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/job/{job_id}/copy-name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCopyNameRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowCopyNameResponse>(response);
        }

        public SyncInvoker<ShowCopyNameResponse> ShowCopyNameInvoker(ShowCopyNameRequest showCopyNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showCopyNameRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/job/{job_id}/copy-name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCopyNameRequest);
            return new SyncInvoker<ShowCopyNameResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCopyNameResponse>);
        }
        
        /// <summary>
        /// 获取编译构建默认参数
        ///
        /// 获取编译构建默认参数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDefaultBuildParametersResponse ShowDefaultBuildParameters(ShowDefaultBuildParametersRequest showDefaultBuildParametersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/job/default-parameters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDefaultBuildParametersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDefaultBuildParametersResponse>(response);
        }

        public SyncInvoker<ShowDefaultBuildParametersResponse> ShowDefaultBuildParametersInvoker(ShowDefaultBuildParametersRequest showDefaultBuildParametersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/job/default-parameters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDefaultBuildParametersRequest);
            return new SyncInvoker<ShowDefaultBuildParametersResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDefaultBuildParametersResponse>);
        }
        
        /// <summary>
        /// 获取当前项目默认角色权限矩阵信息
        ///
        /// 获取当前项目默认角色权限矩阵信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDefaultProjectPermissionResponse ShowDefaultProjectPermission(ShowDefaultProjectPermissionRequest showDefaultProjectPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/job/project/default-permission", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDefaultProjectPermissionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDefaultProjectPermissionResponse>(response);
        }

        public SyncInvoker<ShowDefaultProjectPermissionResponse> ShowDefaultProjectPermissionInvoker(ShowDefaultProjectPermissionRequest showDefaultProjectPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/job/project/default-permission", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDefaultProjectPermissionRequest);
            return new SyncInvoker<ShowDefaultProjectPermissionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDefaultProjectPermissionResponse>);
        }
        
        /// <summary>
        /// 查询任务是否已禁用
        ///
        /// 查询任务是否已禁用
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDisableResponse ShowDisable(ShowDisableRequest showDisableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDisableRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/job/{job_id}/check/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDisableRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDisableResponse>(response);
        }

        public SyncInvoker<ShowDisableResponse> ShowDisableInvoker(ShowDisableRequest showDisableRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDisableRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/job/{job_id}/check/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDisableRequest);
            return new SyncInvoker<ShowDisableResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDisableResponse>);
        }
        
        /// <summary>
        /// 获取构建任务详情
        ///
        /// 获取构建任务详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowJobConfigResponse ShowJobConfig(ShowJobConfigRequest showJobConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobConfigRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/job/{job_id}/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowJobConfigResponse>(response);
        }

        public SyncInvoker<ShowJobConfigResponse> ShowJobConfigInvoker(ShowJobConfigRequest showJobConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobConfigRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/job/{job_id}/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobConfigRequest);
            return new SyncInvoker<ShowJobConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobConfigResponse>);
        }
        
        /// <summary>
        /// 获取构建任务配置的对比差异
        ///
        /// 获取构建任务配置的对比差异
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowJobConfigDiffResponse ShowJobConfigDiff(ShowJobConfigDiffRequest showJobConfigDiffRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobConfigDiffRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/job/{job_id}/diff", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobConfigDiffRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowJobConfigDiffResponse>(response);
        }

        public SyncInvoker<ShowJobConfigDiffResponse> ShowJobConfigDiffInvoker(ShowJobConfigDiffRequest showJobConfigDiffRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobConfigDiffRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/job/{job_id}/diff", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobConfigDiffRequest);
            return new SyncInvoker<ShowJobConfigDiffResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobConfigDiffResponse>);
        }
        
        /// <summary>
        /// 查看构建任务构建信息
        ///
        /// 查看构建任务构建信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowJobInfoResponse ShowJobInfo(ShowJobInfoRequest showJobInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobInfoRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/job/{job_id}/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowJobInfoResponse>(response);
        }

        public SyncInvoker<ShowJobInfoResponse> ShowJobInfoInvoker(ShowJobInfoRequest showJobInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobInfoRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/job/{job_id}/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobInfoRequest);
            return new SyncInvoker<ShowJobInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobInfoResponse>);
        }
        
        /// <summary>
        /// 获取通知信息
        ///
        /// 获取通知信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowJobNoticeConfigInfoResponse ShowJobNoticeConfigInfo(ShowJobNoticeConfigInfoRequest showJobNoticeConfigInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobNoticeConfigInfoRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/job/{job_id}/notice", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobNoticeConfigInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowJobNoticeConfigInfoResponse>(response);
        }

        public SyncInvoker<ShowJobNoticeConfigInfoResponse> ShowJobNoticeConfigInfoInvoker(ShowJobNoticeConfigInfoRequest showJobNoticeConfigInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobNoticeConfigInfoRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/job/{job_id}/notice", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobNoticeConfigInfoRequest);
            return new SyncInvoker<ShowJobNoticeConfigInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobNoticeConfigInfoResponse>);
        }
        
        /// <summary>
        /// 获取构建任务的角色权限矩阵信息
        ///
        /// 获取构建任务的角色权限矩阵信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowJobRolePermissionResponse ShowJobRolePermission(ShowJobRolePermissionRequest showJobRolePermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/job/permission/role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobRolePermissionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowJobRolePermissionResponse>(response);
        }

        public SyncInvoker<ShowJobRolePermissionResponse> ShowJobRolePermissionInvoker(ShowJobRolePermissionRequest showJobRolePermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/job/permission/role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobRolePermissionRequest);
            return new SyncInvoker<ShowJobRolePermissionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobRolePermissionResponse>);
        }
        
        /// <summary>
        /// 查询任务状态
        ///
        /// 查询任务状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowJobStepStatusResponse ShowJobStepStatus(ShowJobStepStatusRequest showJobStepStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobStepStatusRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/job/{job_id}/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobStepStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowJobStepStatusResponse>(response);
        }

        public SyncInvoker<ShowJobStepStatusResponse> ShowJobStepStatusInvoker(ShowJobStepStatusRequest showJobStepStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobStepStatusRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/job/{job_id}/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobStepStatusRequest);
            return new SyncInvoker<ShowJobStepStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobStepStatusResponse>);
        }
        
        /// <summary>
        /// 查看系统预定义参数
        ///
        /// 查看系统预定义参数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowJobSystemParametersResponse ShowJobSystemParameters(ShowJobSystemParametersRequest showJobSystemParametersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/job/system-parameters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobSystemParametersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowJobSystemParametersResponse>(response);
        }

        public SyncInvoker<ShowJobSystemParametersResponse> ShowJobSystemParametersInvoker(ShowJobSystemParametersRequest showJobSystemParametersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/job/system-parameters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobSystemParametersRequest);
            return new SyncInvoker<ShowJobSystemParametersResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobSystemParametersResponse>);
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
        /// 文件管理文件下载
        ///
        /// 文件管理文件下载
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DownloadKeystoreByNameResponse DownloadKeystoreByName(DownloadKeystoreByNameRequest downloadKeystoreByNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/keystore/download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadKeystoreByNameRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DownloadKeystoreByNameResponse>(response);
        }

        public SyncInvoker<DownloadKeystoreByNameResponse> DownloadKeystoreByNameInvoker(DownloadKeystoreByNameRequest downloadKeystoreByNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/keystore/download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadKeystoreByNameRequest);
            return new SyncInvoker<DownloadKeystoreByNameResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadKeystoreByNameResponse>);
        }
        
        /// <summary>
        /// 查询用户可使用文件
        ///
        /// 查询用户可使用文件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListKeystoreResponse ListKeystore(ListKeystoreRequest listKeystoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/keystore/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeystoreRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListKeystoreResponse>(response);
        }

        public SyncInvoker<ListKeystoreResponse> ListKeystoreInvoker(ListKeystoreRequest listKeystoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/keystore/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeystoreRequest);
            return new SyncInvoker<ListKeystoreResponse>(this, "GET", request, JsonUtils.DeSerialize<ListKeystoreResponse>);
        }
        
        /// <summary>
        /// 查询租户下文件列表
        ///
        /// 查询租户下文件列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListKeystoreSearchResponse ListKeystoreSearch(ListKeystoreSearchRequest listKeystoreSearchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/keystore/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeystoreSearchRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListKeystoreSearchResponse>(response);
        }

        public SyncInvoker<ListKeystoreSearchResponse> ListKeystoreSearchInvoker(ListKeystoreSearchRequest listKeystoreSearchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/keystore/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeystoreSearchRequest);
            return new SyncInvoker<ListKeystoreSearchResponse>(this, "GET", request, JsonUtils.DeSerialize<ListKeystoreSearchResponse>);
        }
        
        /// <summary>
        /// 文件管理查询权限
        ///
        /// 文件管理查询权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowKeystorePermissionResponse ShowKeystorePermission(ShowKeystorePermissionRequest showKeystorePermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("keystore_id", showKeystorePermissionRequest.KeystoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/keystore/permission/{keystore_id}/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKeystorePermissionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowKeystorePermissionResponse>(response);
        }

        public SyncInvoker<ShowKeystorePermissionResponse> ShowKeystorePermissionInvoker(ShowKeystorePermissionRequest showKeystorePermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("keystore_id", showKeystorePermissionRequest.KeystoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/keystore/permission/{keystore_id}/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKeystorePermissionRequest);
            return new SyncInvoker<ShowKeystorePermissionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowKeystorePermissionResponse>);
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
        
        /// <summary>
        /// 获取任务构建记录列表v1
        ///
        /// 获取任务构建记录列表v1
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBuildInfoRecordByJobIdResponse ListBuildInfoRecordByJobId(ListBuildInfoRecordByJobIdRequest listBuildInfoRecordByJobIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listBuildInfoRecordByJobIdRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/record/{job_id}/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBuildInfoRecordByJobIdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBuildInfoRecordByJobIdResponse>(response);
        }

        public SyncInvoker<ListBuildInfoRecordByJobIdResponse> ListBuildInfoRecordByJobIdInvoker(ListBuildInfoRecordByJobIdRequest listBuildInfoRecordByJobIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listBuildInfoRecordByJobIdRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/record/{job_id}/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBuildInfoRecordByJobIdRequest);
            return new SyncInvoker<ListBuildInfoRecordByJobIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBuildInfoRecordByJobIdResponse>);
        }
        
        /// <summary>
        /// 获取指定工程的构建记录列表
        ///
        /// 获取指定工程的构建记录列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRecordsResponse ListRecords(ListRecordsRequest listRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("build_project_id", listRecordsRequest.BuildProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/record/{build_project_id}/records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRecordsResponse>(response);
        }

        public SyncInvoker<ListRecordsResponse> ListRecordsInvoker(ListRecordsRequest listRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("build_project_id", listRecordsRequest.BuildProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/record/{build_project_id}/records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordsRequest);
            return new SyncInvoker<ListRecordsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRecordsResponse>);
        }
        
        /// <summary>
        /// 获取任务构建记录列表
        ///
        /// 获取任务构建记录列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBuildInfoRecordResponse ShowBuildInfoRecord(ShowBuildInfoRecordRequest showBuildInfoRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showBuildInfoRecordRequest.JobId.ToString());
            urlParam.Add("build_no", showBuildInfoRecordRequest.BuildNo.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/record/{job_id}/{build_no}/build-info-record", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBuildInfoRecordRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBuildInfoRecordResponse>(response);
        }

        public SyncInvoker<ShowBuildInfoRecordResponse> ShowBuildInfoRecordInvoker(ShowBuildInfoRecordRequest showBuildInfoRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showBuildInfoRecordRequest.JobId.ToString());
            urlParam.Add("build_no", showBuildInfoRecordRequest.BuildNo.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/record/{job_id}/{build_no}/build-info-record", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBuildInfoRecordRequest);
            return new SyncInvoker<ShowBuildInfoRecordResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBuildInfoRecordResponse>);
        }
        
        /// <summary>
        /// 查询指定构建记录详情
        ///
        /// 查询指定构建记录详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBuildRecordResponse ShowBuildRecord(ShowBuildRecordRequest showBuildRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("record_id", showBuildRecordRequest.RecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/record/{record_id}/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBuildRecordRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBuildRecordResponse>(response);
        }

        public SyncInvoker<ShowBuildRecordResponse> ShowBuildRecordInvoker(ShowBuildRecordRequest showBuildRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("record_id", showBuildRecordRequest.RecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/record/{record_id}/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBuildRecordRequest);
            return new SyncInvoker<ShowBuildRecordResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBuildRecordResponse>);
        }
        
        /// <summary>
        /// 获取构建记录的构建脚本
        ///
        /// 获取构建记录的构建脚本
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBuildRecordBuildScriptResponse ShowBuildRecordBuildScript(ShowBuildRecordBuildScriptRequest showBuildRecordBuildScriptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("record_id", showBuildRecordBuildScriptRequest.RecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/record/{record_id}/build-script", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBuildRecordBuildScriptRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBuildRecordBuildScriptResponse>(response);
        }

        public SyncInvoker<ShowBuildRecordBuildScriptResponse> ShowBuildRecordBuildScriptInvoker(ShowBuildRecordBuildScriptRequest showBuildRecordBuildScriptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("record_id", showBuildRecordBuildScriptRequest.RecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/record/{record_id}/build-script", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBuildRecordBuildScriptRequest);
            return new SyncInvoker<ShowBuildRecordBuildScriptResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBuildRecordBuildScriptResponse>);
        }
        
        /// <summary>
        /// 获取构建记录的有向无环图
        ///
        /// 获取构建记录的有向无环图
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBuildRecordFlowGraphResponse ShowBuildRecordFlowGraph(ShowBuildRecordFlowGraphRequest showBuildRecordFlowGraphRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("build_flow_record_id", showBuildRecordFlowGraphRequest.BuildFlowRecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/record/{build_flow_record_id}/flow-graph", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBuildRecordFlowGraphRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBuildRecordFlowGraphResponse>(response);
        }

        public SyncInvoker<ShowBuildRecordFlowGraphResponse> ShowBuildRecordFlowGraphInvoker(ShowBuildRecordFlowGraphRequest showBuildRecordFlowGraphRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("build_flow_record_id", showBuildRecordFlowGraphRequest.BuildFlowRecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/record/{build_flow_record_id}/flow-graph", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBuildRecordFlowGraphRequest);
            return new SyncInvoker<ShowBuildRecordFlowGraphResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBuildRecordFlowGraphResponse>);
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
        /// 获取构建记录信息
        ///
        /// 获取构建记录信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowJobBuildRecordDetailResponse ShowJobBuildRecordDetail(ShowJobBuildRecordDetailRequest showJobBuildRecordDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobBuildRecordDetailRequest.JobId.ToString());
            urlParam.Add("build_no", showJobBuildRecordDetailRequest.BuildNo.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/record/{job_id}/{build_no}/record-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobBuildRecordDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowJobBuildRecordDetailResponse>(response);
        }

        public SyncInvoker<ShowJobBuildRecordDetailResponse> ShowJobBuildRecordDetailInvoker(ShowJobBuildRecordDetailRequest showJobBuildRecordDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobBuildRecordDetailRequest.JobId.ToString());
            urlParam.Add("build_no", showJobBuildRecordDetailRequest.BuildNo.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/record/{job_id}/{build_no}/record-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobBuildRecordDetailRequest);
            return new SyncInvoker<ShowJobBuildRecordDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobBuildRecordDetailResponse>);
        }
        
        /// <summary>
        /// 构建历史页获取构建次数
        ///
        /// 构建历史页获取构建次数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowJobTotalResponse ShowJobTotal(ShowJobTotalRequest showJobTotalRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("build_project_id", showJobTotalRequest.BuildProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/record/{build_project_id}/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobTotalRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowJobTotalResponse>(response);
        }

        public SyncInvoker<ShowJobTotalResponse> ShowJobTotalInvoker(ShowJobTotalRequest showJobTotalRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("build_project_id", showJobTotalRequest.BuildProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/record/{build_project_id}/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobTotalRequest);
            return new SyncInvoker<ShowJobTotalResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobTotalResponse>);
        }
        
        /// <summary>
        /// 获取单元测试覆盖率报告压缩包
        ///
        /// 获取单元测试覆盖率报告压缩包
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DownloadJunitCoverageZipResponse DownloadJunitCoverageZip(DownloadJunitCoverageZipRequest downloadJunitCoverageZipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/report/junit/coverage/download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadJunitCoverageZipRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DownloadJunitCoverageZipResponse>(response);
        }

        public SyncInvoker<DownloadJunitCoverageZipResponse> DownloadJunitCoverageZipInvoker(DownloadJunitCoverageZipRequest downloadJunitCoverageZipRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/report/junit/coverage/download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadJunitCoverageZipRequest);
            return new SyncInvoker<DownloadJunitCoverageZipResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadJunitCoverageZipResponse>);
        }
        
        /// <summary>
        /// 获取单元测试覆盖率报告列表
        ///
        /// 获取单元测试覆盖率报告列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListJunitCoverageSummaryResponse ListJunitCoverageSummary(ListJunitCoverageSummaryRequest listJunitCoverageSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/report/junit/coverage/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJunitCoverageSummaryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListJunitCoverageSummaryResponse>(response);
        }

        public SyncInvoker<ListJunitCoverageSummaryResponse> ListJunitCoverageSummaryInvoker(ListJunitCoverageSummaryRequest listJunitCoverageSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/report/junit/coverage/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJunitCoverageSummaryRequest);
            return new SyncInvoker<ListJunitCoverageSummaryResponse>(this, "GET", request, JsonUtils.DeSerialize<ListJunitCoverageSummaryResponse>);
        }
        
        /// <summary>
        /// 获取该任务所有分支信息
        ///
        /// 获取该任务所有分支信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRepoBranchResponse ListRepoBranch(ListRepoBranchRequest listRepoBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/report/branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepoBranchRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRepoBranchResponse>(response);
        }

        public SyncInvoker<ListRepoBranchResponse> ListRepoBranchInvoker(ListRepoBranchRequest listRepoBranchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/report/branches", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepoBranchRequest);
            return new SyncInvoker<ListRepoBranchResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRepoBranchResponse>);
        }
        
        /// <summary>
        /// 查看仓库
        ///
        /// 查看仓库
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRepositoryResponse ListRepository(ListRepositoryRequest listRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listRepositoryRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/report/{job_id}/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRepositoryResponse>(response);
        }

        public SyncInvoker<ListRepositoryResponse> ListRepositoryInvoker(ListRepositoryRequest listRepositoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listRepositoryRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/report/{job_id}/repositories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRepositoryRequest);
            return new SyncInvoker<ListRepositoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRepositoryResponse>);
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
        /// 洞察构建时长
        ///
        /// 洞察构建时长
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowJobBuildTimeResponse ShowJobBuildTime(ShowJobBuildTimeRequest showJobBuildTimeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/report/time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobBuildTimeRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowJobBuildTimeResponse>(response);
        }

        public SyncInvoker<ShowJobBuildTimeResponse> ShowJobBuildTimeInvoker(ShowJobBuildTimeRequest showJobBuildTimeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/report/time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobBuildTimeRequest);
            return new SyncInvoker<ShowJobBuildTimeResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobBuildTimeResponse>);
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
        /// 根据条件查询特定模板
        ///
        /// 根据条件查询特定模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCustomTemplateResponse ListCustomTemplate(ListCustomTemplateRequest listCustomTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/template/custom", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCustomTemplateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCustomTemplateResponse>(response);
        }

        public SyncInvoker<ListCustomTemplateResponse> ListCustomTemplateInvoker(ListCustomTemplateRequest listCustomTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/template/custom", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCustomTemplateRequest);
            return new SyncInvoker<ListCustomTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCustomTemplateResponse>);
        }
        
        /// <summary>
        /// 查询官方模版
        ///
        /// 查询官方模版
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListOfficialTemplateResponse ListOfficialTemplate(ListOfficialTemplateRequest listOfficialTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/template/officialtemplates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOfficialTemplateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListOfficialTemplateResponse>(response);
        }

        public SyncInvoker<ListOfficialTemplateResponse> ListOfficialTemplateInvoker(ListOfficialTemplateRequest listOfficialTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/template/officialtemplates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOfficialTemplateRequest);
            return new SyncInvoker<ListOfficialTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOfficialTemplateResponse>);
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
        
    }
}