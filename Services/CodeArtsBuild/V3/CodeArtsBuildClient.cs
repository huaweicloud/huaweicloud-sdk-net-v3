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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/jobs/create",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBuildJobRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateBuildJobResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/templates/create",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTemplatesRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateTemplatesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , deleteBuildJobRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBuildJobRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DeleteBuildJobResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("uuid" , deleteTemplatesRequest.Uuid.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/templates/{uuid}/delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplatesRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteTemplatesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , disableBuildJobRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/disable",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableBuildJobRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DisableBuildJobResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , disableNoticeRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/jobs/notice/{job_id}/disable",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableNoticeRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DisableNoticeResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("record_id" , downloadBuildLogRequest.RecordId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/{record_id}/download-log",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadBuildLogRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<DownloadBuildLogResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/keystore",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadKeystoreRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<DownloadKeystoreResponse>(response);
        }
        
        /// <summary>
        /// 下载全量构建步骤日志
        ///
        /// 下载全量构建步骤日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DownloadTaskLogResponse DownloadTaskLog(DownloadTaskLogRequest downloadTaskLogRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("record_id" , downloadTaskLogRequest.RecordId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/{record_id}/task-log",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadTaskLogRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<DownloadTaskLogResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , enableBuildJobRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/recover",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableBuildJobRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<EnableBuildJobResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , listJobConfigRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/query",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobConfigRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListJobConfigResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , listNoticeRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/jobs/notice/{job_id}/query",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNoticeRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListNoticeResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/templates/query",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplatesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListTemplatesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/jobs/build",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", runJobRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RunJobResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showHistoryDetailsRequest.JobId.ToString());
            urlParam.Add("build_number" , showHistoryDetailsRequest.BuildNumber.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/{build_number}/history-details",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHistoryDetailsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowHistoryDetailsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , showJobListByProjectIdRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobListByProjectIdRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowJobListByProjectIdResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showJobStatusRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/status",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobStatusRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowJobStatusResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showJobSuccessRatioRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/success-ratio",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobSuccessRatioRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowJobSuccessRatioResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id" , showLastHistoryRequest.ProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/jobs/{project_id}/last-history",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLastHistoryRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowLastHistoryResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showListHistoryRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/history",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showListHistoryRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowListHistoryResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showListPeriodHistoryRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/period-history",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showListPeriodHistoryRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowListPeriodHistoryResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showOutputInfoRequest.JobId.ToString());
            urlParam.Add("build_no" , showOutputInfoRequest.BuildNo.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/{build_no}/output-info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOutputInfoRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowOutputInfoResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showRecordDetailRequest.JobId.ToString());
            urlParam.Add("build_no" , showRecordDetailRequest.BuildNo.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v4/jobs/{job_id}/{build_no}/record-info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordDetailRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowRecordDetailResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , stopBuildJobRequest.JobId.ToString());
            urlParam.Add("build_no" , stopBuildJobRequest.BuildNo.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/{build_no}/stop",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopBuildJobRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<StopBuildJobResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/jobs/update",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBuildJobRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<UpdateBuildJobResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , updateNoticeRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/jobs/notice/{job_id}/update",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNoticeRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<UpdateNoticeResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("record_id" , downloadLogByRecordIdRequest.RecordId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{record_id}/download-log",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadLogByRecordIdRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<DownloadLogByRecordIdResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("build_flow_record_id" , showFlowGraphRequest.BuildFlowRecordId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{build_flow_record_id}/flow-graph",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlowGraphRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowFlowGraphResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showRecordInfoRequest.JobId.ToString());
            urlParam.Add("build_no" , showRecordInfoRequest.BuildNo.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/{build_no}/record-info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordInfoRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowRecordInfoResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/jobs/stop",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopJobRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<StopJobResponse>(response);
        }
        
    }
}