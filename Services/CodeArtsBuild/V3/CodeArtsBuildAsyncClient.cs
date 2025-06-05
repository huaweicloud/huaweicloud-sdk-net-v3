using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.CodeArtsBuild.V3.Model;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3
{
    public partial class CodeArtsBuildAsyncClient : Client
    {
        public static ClientBuilder<CodeArtsBuildAsyncClient> NewBuilder()
        {
            return new ClientBuilder<CodeArtsBuildAsyncClient>();
        }

        
        /// <summary>
        /// 查看项目下任务名是否存在
        ///
        /// 查看项目下任务名是否存在
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckJobNameIsExistsResponse> CheckJobNameIsExistsAsync(CheckJobNameIsExistsRequest checkJobNameIsExistsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/job/check/exist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkJobNameIsExistsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<CheckJobNameIsExistsResponse>(response);
        }

        public AsyncInvoker<CheckJobNameIsExistsResponse> CheckJobNameIsExistsAsyncInvoker(CheckJobNameIsExistsRequest checkJobNameIsExistsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/job/check/exist", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkJobNameIsExistsRequest);
            return new AsyncInvoker<CheckJobNameIsExistsResponse>(this, "GET", request, JsonUtils.DeSerialize<CheckJobNameIsExistsResponse>);
        }
        
        /// <summary>
        /// 创建构建任务
        ///
        /// 创建构建任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateBuildJobResponse> CreateBuildJobAsync(CreateBuildJobRequest createBuildJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBuildJobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateBuildJobResponse>(response);
        }

        public AsyncInvoker<CreateBuildJobResponse> CreateBuildJobAsyncInvoker(CreateBuildJobRequest createBuildJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createBuildJobRequest);
            return new AsyncInvoker<CreateBuildJobResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateBuildJobResponse>);
        }
        
        /// <summary>
        /// 创建构建模板
        ///
        /// 创建构建模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTemplatesResponse> CreateTemplatesAsync(CreateTemplatesRequest createTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/templates/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTemplatesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateTemplatesResponse>(response);
        }

        public AsyncInvoker<CreateTemplatesResponse> CreateTemplatesAsyncInvoker(CreateTemplatesRequest createTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/templates/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTemplatesRequest);
            return new AsyncInvoker<CreateTemplatesResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTemplatesResponse>);
        }
        
        /// <summary>
        /// 删除构建任务
        ///
        /// 删除构建任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteBuildJobResponse> DeleteBuildJobAsync(DeleteBuildJobRequest deleteBuildJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", deleteBuildJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBuildJobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DeleteBuildJobResponse>(response);
        }

        public AsyncInvoker<DeleteBuildJobResponse> DeleteBuildJobAsyncInvoker(DeleteBuildJobRequest deleteBuildJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", deleteBuildJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBuildJobRequest);
            return new AsyncInvoker<DeleteBuildJobResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteBuildJobResponse>);
        }
        
        /// <summary>
        /// 删除构建模板
        ///
        /// 删除构建模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTemplatesResponse> DeleteTemplatesAsync(DeleteTemplatesRequest deleteTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("uuid", deleteTemplatesRequest.Uuid.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/templates/{uuid}/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplatesRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteTemplatesResponse>(response);
        }

        public AsyncInvoker<DeleteTemplatesResponse> DeleteTemplatesAsyncInvoker(DeleteTemplatesRequest deleteTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("uuid", deleteTemplatesRequest.Uuid.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/templates/{uuid}/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplatesRequest);
            return new AsyncInvoker<DeleteTemplatesResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteTemplatesResponse>);
        }
        
        /// <summary>
        /// 禁用构建任务
        ///
        /// 禁用构建任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisableBuildJobResponse> DisableBuildJobAsync(DisableBuildJobRequest disableBuildJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", disableBuildJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableBuildJobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DisableBuildJobResponse>(response);
        }

        public AsyncInvoker<DisableBuildJobResponse> DisableBuildJobAsyncInvoker(DisableBuildJobRequest disableBuildJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", disableBuildJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableBuildJobRequest);
            return new AsyncInvoker<DisableBuildJobResponse>(this, "POST", request, JsonUtils.DeSerialize<DisableBuildJobResponse>);
        }
        
        /// <summary>
        /// 取消通知
        ///
        /// 取消通知
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisableNoticeResponse> DisableNoticeAsync(DisableNoticeRequest disableNoticeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", disableNoticeRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/notice/{job_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableNoticeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DisableNoticeResponse>(response);
        }

        public AsyncInvoker<DisableNoticeResponse> DisableNoticeAsyncInvoker(DisableNoticeRequest disableNoticeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", disableNoticeRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/notice/{job_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableNoticeRequest);
            return new AsyncInvoker<DisableNoticeResponse>(this, "POST", request, JsonUtils.DeSerialize<DisableNoticeResponse>);
        }
        
        /// <summary>
        /// 下载全量构建日志
        ///
        /// 下载全量构建日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DownloadBuildLogResponse> DownloadBuildLogAsync(DownloadBuildLogRequest downloadBuildLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("record_id", downloadBuildLogRequest.RecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/{record_id}/download-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadBuildLogRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<DownloadBuildLogResponse>(response);
        }

        public AsyncInvoker<DownloadBuildLogResponse> DownloadBuildLogAsyncInvoker(DownloadBuildLogRequest downloadBuildLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("record_id", downloadBuildLogRequest.RecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/{record_id}/download-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadBuildLogRequest);
            return new AsyncInvoker<DownloadBuildLogResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadBuildLogResponse>);
        }
        
        /// <summary>
        /// KeyStore文件下载
        ///
        /// 下载指定租户下的KeyStore文件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DownloadKeystoreResponse> DownloadKeystoreAsync(DownloadKeystoreRequest downloadKeystoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/keystore", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadKeystoreRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<DownloadKeystoreResponse>(response);
        }

        public AsyncInvoker<DownloadKeystoreResponse> DownloadKeystoreAsyncInvoker(DownloadKeystoreRequest downloadKeystoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/keystore", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadKeystoreRequest);
            return new AsyncInvoker<DownloadKeystoreResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadKeystoreResponse>);
        }
        
        /// <summary>
        /// 文件管理文件下载
        ///
        /// 文件管理文件下载
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DownloadKeystoreByNameResponse> DownloadKeystoreByNameAsync(DownloadKeystoreByNameRequest downloadKeystoreByNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/keystore/download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadKeystoreByNameRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<DownloadKeystoreByNameResponse>(response);
        }

        public AsyncInvoker<DownloadKeystoreByNameResponse> DownloadKeystoreByNameAsyncInvoker(DownloadKeystoreByNameRequest downloadKeystoreByNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/keystore/download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadKeystoreByNameRequest);
            return new AsyncInvoker<DownloadKeystoreByNameResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadKeystoreByNameResponse>);
        }
        
        /// <summary>
        /// 下载构建实时日志
        ///
        /// 下载构建实时日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DownloadRealTimeLogResponse> DownloadRealTimeLogAsync(DownloadRealTimeLogRequest downloadRealTimeLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", downloadRealTimeLogRequest.JobId.ToString());
            urlParam.Add("build_no", downloadRealTimeLogRequest.BuildNo.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/{build_no}/real-time-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadRealTimeLogRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<DownloadRealTimeLogResponse>(response);
        }

        public AsyncInvoker<DownloadRealTimeLogResponse> DownloadRealTimeLogAsyncInvoker(DownloadRealTimeLogRequest downloadRealTimeLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", downloadRealTimeLogRequest.JobId.ToString());
            urlParam.Add("build_no", downloadRealTimeLogRequest.BuildNo.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/{build_no}/real-time-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadRealTimeLogRequest);
            return new AsyncInvoker<DownloadRealTimeLogResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadRealTimeLogResponse>);
        }
        
        /// <summary>
        /// 下载构建步骤日志
        ///
        /// 下载构建步骤日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DownloadTaskLogResponse> DownloadTaskLogAsync(DownloadTaskLogRequest downloadTaskLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("record_id", downloadTaskLogRequest.RecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/{record_id}/task-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadTaskLogRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<DownloadTaskLogResponse>(response);
        }

        public AsyncInvoker<DownloadTaskLogResponse> DownloadTaskLogAsyncInvoker(DownloadTaskLogRequest downloadTaskLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("record_id", downloadTaskLogRequest.RecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/{record_id}/task-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadTaskLogRequest);
            return new AsyncInvoker<DownloadTaskLogResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadTaskLogResponse>);
        }
        
        /// <summary>
        /// 恢复构建任务
        ///
        /// 恢复构建任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EnableBuildJobResponse> EnableBuildJobAsync(EnableBuildJobRequest enableBuildJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", enableBuildJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/recover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableBuildJobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<EnableBuildJobResponse>(response);
        }

        public AsyncInvoker<EnableBuildJobResponse> EnableBuildJobAsyncInvoker(EnableBuildJobRequest enableBuildJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", enableBuildJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/recover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableBuildJobRequest);
            return new AsyncInvoker<EnableBuildJobResponse>(this, "POST", request, JsonUtils.DeSerialize<EnableBuildJobResponse>);
        }
        
        /// <summary>
        /// 获取任务构建记录列表
        ///
        /// 获取任务构建记录列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBuildInfoRecordResponse> ListBuildInfoRecordAsync(ListBuildInfoRecordRequest listBuildInfoRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listBuildInfoRecordRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/build-info-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBuildInfoRecordRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListBuildInfoRecordResponse>(response);
        }

        public AsyncInvoker<ListBuildInfoRecordResponse> ListBuildInfoRecordAsyncInvoker(ListBuildInfoRecordRequest listBuildInfoRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listBuildInfoRecordRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/build-info-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBuildInfoRecordRequest);
            return new AsyncInvoker<ListBuildInfoRecordResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBuildInfoRecordResponse>);
        }
        
        /// <summary>
        /// 获取任务构建记录列表v1
        ///
        /// 获取任务构建记录列表v1
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBuildInfoRecordByJobIdResponse> ListBuildInfoRecordByJobIdAsync(ListBuildInfoRecordByJobIdRequest listBuildInfoRecordByJobIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listBuildInfoRecordByJobIdRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/record/{job_id}/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBuildInfoRecordByJobIdRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListBuildInfoRecordByJobIdResponse>(response);
        }

        public AsyncInvoker<ListBuildInfoRecordByJobIdResponse> ListBuildInfoRecordByJobIdAsyncInvoker(ListBuildInfoRecordByJobIdRequest listBuildInfoRecordByJobIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listBuildInfoRecordByJobIdRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/record/{job_id}/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBuildInfoRecordByJobIdRequest);
            return new AsyncInvoker<ListBuildInfoRecordByJobIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBuildInfoRecordByJobIdResponse>);
        }
        
        /// <summary>
        /// 获取构建任务详情
        ///
        /// 获取构建任务详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListJobConfigResponse> ListJobConfigAsync(ListJobConfigRequest listJobConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listJobConfigRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListJobConfigResponse>(response);
        }

        public AsyncInvoker<ListJobConfigResponse> ListJobConfigAsyncInvoker(ListJobConfigRequest listJobConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listJobConfigRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobConfigRequest);
            return new AsyncInvoker<ListJobConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ListJobConfigResponse>);
        }
        
        /// <summary>
        /// 查询用户可使用文件
        ///
        /// 查询用户可使用文件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListKeystoreResponse> ListKeystoreAsync(ListKeystoreRequest listKeystoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/keystore/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeystoreRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListKeystoreResponse>(response);
        }

        public AsyncInvoker<ListKeystoreResponse> ListKeystoreAsyncInvoker(ListKeystoreRequest listKeystoreRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/keystore/name", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listKeystoreRequest);
            return new AsyncInvoker<ListKeystoreResponse>(this, "GET", request, JsonUtils.DeSerialize<ListKeystoreResponse>);
        }
        
        /// <summary>
        /// 查询通知
        ///
        /// 查询通知
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListNoticeResponse> ListNoticeAsync(ListNoticeRequest listNoticeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listNoticeRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/notice/{job_id}/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNoticeRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListNoticeResponse>(response);
        }

        public AsyncInvoker<ListNoticeResponse> ListNoticeAsyncInvoker(ListNoticeRequest listNoticeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listNoticeRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/notice/{job_id}/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNoticeRequest);
            return new AsyncInvoker<ListNoticeResponse>(this, "GET", request, JsonUtils.DeSerialize<ListNoticeResponse>);
        }
        
        /// <summary>
        /// 查询官方模版
        ///
        /// 查询官方模版
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListOfficialTemplateResponse> ListOfficialTemplateAsync(ListOfficialTemplateRequest listOfficialTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/template/officialtemplates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOfficialTemplateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListOfficialTemplateResponse>(response);
        }

        public AsyncInvoker<ListOfficialTemplateResponse> ListOfficialTemplateAsyncInvoker(ListOfficialTemplateRequest listOfficialTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/template/officialtemplates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOfficialTemplateRequest);
            return new AsyncInvoker<ListOfficialTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOfficialTemplateResponse>);
        }
        
        /// <summary>
        /// 查询项目任务列表
        ///
        /// 查询项目任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProjectJobsResponse> ListProjectJobsAsync(ListProjectJobsRequest listProjectJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listProjectJobsRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/job/{project_id}/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectJobsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListProjectJobsResponse>(response);
        }

        public AsyncInvoker<ListProjectJobsResponse> ListProjectJobsAsyncInvoker(ListProjectJobsRequest listProjectJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", listProjectJobsRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/job/{project_id}/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectJobsRequest);
            return new AsyncInvoker<ListProjectJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProjectJobsResponse>);
        }
        
        /// <summary>
        /// 获取指定工程的构建记录列表
        ///
        /// 获取指定工程的构建记录列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRecordsResponse> ListRecordsAsync(ListRecordsRequest listRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("build_project_id", listRecordsRequest.BuildProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/record/{build_project_id}/records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRecordsResponse>(response);
        }

        public AsyncInvoker<ListRecordsResponse> ListRecordsAsyncInvoker(ListRecordsRequest listRecordsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("build_project_id", listRecordsRequest.BuildProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/record/{build_project_id}/records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordsRequest);
            return new AsyncInvoker<ListRecordsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRecordsResponse>);
        }
        
        /// <summary>
        /// 查看回收站中删除的构建任务列表
        ///
        /// 查看回收站中删除的构建任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRecyclingJobResponse> ListRecyclingJobAsync(ListRecyclingJobRequest listRecyclingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/job/recycling-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecyclingJobRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRecyclingJobResponse>(response);
        }

        public AsyncInvoker<ListRecyclingJobResponse> ListRecyclingJobAsyncInvoker(ListRecyclingJobRequest listRecyclingJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/job/recycling-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecyclingJobRequest);
            return new AsyncInvoker<ListRecyclingJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRecyclingJobResponse>);
        }
        
        /// <summary>
        /// 获取项目列表
        ///
        /// 获取项目列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRelatedProjectInfoResponse> ListRelatedProjectInfoAsync(ListRelatedProjectInfoRequest listRelatedProjectInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/domain/project/related-page", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRelatedProjectInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRelatedProjectInfoResponse>(response);
        }

        public AsyncInvoker<ListRelatedProjectInfoResponse> ListRelatedProjectInfoAsyncInvoker(ListRelatedProjectInfoRequest listRelatedProjectInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/domain/project/related-page", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRelatedProjectInfoRequest);
            return new AsyncInvoker<ListRelatedProjectInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRelatedProjectInfoResponse>);
        }
        
        /// <summary>
        /// 查询构建模板
        ///
        /// 查询构建模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTemplatesResponse> ListTemplatesAsync(ListTemplatesRequest listTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/templates/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTemplatesResponse>(response);
        }

        public AsyncInvoker<ListTemplatesResponse> ListTemplatesAsyncInvoker(ListTemplatesRequest listTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/templates/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplatesRequest);
            return new AsyncInvoker<ListTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTemplatesResponse>);
        }
        
        /// <summary>
        /// 执行构建任务
        ///
        /// 执行构建任务,可传自定义参数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunJobResponse> RunJobAsync(RunJobRequest runJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/build", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runJobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RunJobResponse>(response);
        }

        public AsyncInvoker<RunJobResponse> RunJobAsyncInvoker(RunJobRequest runJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/build", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runJobRequest);
            return new AsyncInvoker<RunJobResponse>(this, "POST", request, JsonUtils.DeSerialize<RunJobResponse>);
        }
        
        /// <summary>
        /// 获取任务构建记录列表
        ///
        /// 获取任务构建记录列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBuildInfoRecordResponse> ShowBuildInfoRecordAsync(ShowBuildInfoRecordRequest showBuildInfoRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showBuildInfoRecordRequest.JobId.ToString());
            urlParam.Add("build_no", showBuildInfoRecordRequest.BuildNo.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/record/{job_id}/{build_no}/build-info-record", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBuildInfoRecordRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowBuildInfoRecordResponse>(response);
        }

        public AsyncInvoker<ShowBuildInfoRecordResponse> ShowBuildInfoRecordAsyncInvoker(ShowBuildInfoRecordRequest showBuildInfoRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showBuildInfoRecordRequest.JobId.ToString());
            urlParam.Add("build_no", showBuildInfoRecordRequest.BuildNo.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/record/{job_id}/{build_no}/build-info-record", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBuildInfoRecordRequest);
            return new AsyncInvoker<ShowBuildInfoRecordResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBuildInfoRecordResponse>);
        }
        
        /// <summary>
        /// 编辑页获取参数类型的接口
        ///
        /// 编辑页获取参数类型的接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBuildParamsListResponse> ShowBuildParamsListAsync(ShowBuildParamsListRequest showBuildParamsListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/job/build-params", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBuildParamsListRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowBuildParamsListResponse>(response);
        }

        public AsyncInvoker<ShowBuildParamsListResponse> ShowBuildParamsListAsyncInvoker(ShowBuildParamsListRequest showBuildParamsListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/job/build-params", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBuildParamsListRequest);
            return new AsyncInvoker<ShowBuildParamsListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBuildParamsListResponse>);
        }
        
        /// <summary>
        /// 查询指定构建记录详情
        ///
        /// 查询指定构建记录详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBuildRecordResponse> ShowBuildRecordAsync(ShowBuildRecordRequest showBuildRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("record_id", showBuildRecordRequest.RecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/record/{record_id}/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBuildRecordRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowBuildRecordResponse>(response);
        }

        public AsyncInvoker<ShowBuildRecordResponse> ShowBuildRecordAsyncInvoker(ShowBuildRecordRequest showBuildRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("record_id", showBuildRecordRequest.RecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/record/{record_id}/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBuildRecordRequest);
            return new AsyncInvoker<ShowBuildRecordResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBuildRecordResponse>);
        }
        
        /// <summary>
        /// 获取构建记录的构建脚本
        ///
        /// 获取构建记录的构建脚本
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBuildRecordBuildScriptResponse> ShowBuildRecordBuildScriptAsync(ShowBuildRecordBuildScriptRequest showBuildRecordBuildScriptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("record_id", showBuildRecordBuildScriptRequest.RecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/record/{record_id}/build-script", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBuildRecordBuildScriptRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowBuildRecordBuildScriptResponse>(response);
        }

        public AsyncInvoker<ShowBuildRecordBuildScriptResponse> ShowBuildRecordBuildScriptAsyncInvoker(ShowBuildRecordBuildScriptRequest showBuildRecordBuildScriptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("record_id", showBuildRecordBuildScriptRequest.RecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/record/{record_id}/build-script", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBuildRecordBuildScriptRequest);
            return new AsyncInvoker<ShowBuildRecordBuildScriptResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBuildRecordBuildScriptResponse>);
        }
        
        /// <summary>
        /// 获取任务各阶段信息
        ///
        /// 获取任务各阶段信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBuildRecordFullStagesResponse> ShowBuildRecordFullStagesAsync(ShowBuildRecordFullStagesRequest showBuildRecordFullStagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("record_id", showBuildRecordFullStagesRequest.RecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/record/{record_id}/full-stages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBuildRecordFullStagesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowBuildRecordFullStagesResponse>(response);
        }

        public AsyncInvoker<ShowBuildRecordFullStagesResponse> ShowBuildRecordFullStagesAsyncInvoker(ShowBuildRecordFullStagesRequest showBuildRecordFullStagesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("record_id", showBuildRecordFullStagesRequest.RecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/record/{record_id}/full-stages", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBuildRecordFullStagesRequest);
            return new AsyncInvoker<ShowBuildRecordFullStagesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBuildRecordFullStagesResponse>);
        }
        
        /// <summary>
        /// 获取编译构建默认参数
        ///
        /// 获取编译构建默认参数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDefaultBuildParametersResponse> ShowDefaultBuildParametersAsync(ShowDefaultBuildParametersRequest showDefaultBuildParametersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/job/default-parameters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDefaultBuildParametersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDefaultBuildParametersResponse>(response);
        }

        public AsyncInvoker<ShowDefaultBuildParametersResponse> ShowDefaultBuildParametersAsyncInvoker(ShowDefaultBuildParametersRequest showDefaultBuildParametersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/job/default-parameters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDefaultBuildParametersRequest);
            return new AsyncInvoker<ShowDefaultBuildParametersResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDefaultBuildParametersResponse>);
        }
        
        /// <summary>
        /// 获取dockerfileTemplate
        ///
        /// 获取dockerfileTemplate
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDockerfileTemplateResponse> ShowDockerfileTemplateAsync(ShowDockerfileTemplateRequest showDockerfileTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/image/dockerfile-template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDockerfileTemplateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDockerfileTemplateResponse>(response);
        }

        public AsyncInvoker<ShowDockerfileTemplateResponse> ShowDockerfileTemplateAsyncInvoker(ShowDockerfileTemplateRequest showDockerfileTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/image/dockerfile-template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDockerfileTemplateRequest);
            return new AsyncInvoker<ShowDockerfileTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDockerfileTemplateResponse>);
        }
        
        /// <summary>
        /// 获取构建历史详情信息接口
        ///
        /// 获取构建历史详情信息接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowHistoryDetailsResponse> ShowHistoryDetailsAsync(ShowHistoryDetailsRequest showHistoryDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showHistoryDetailsRequest.JobId.ToString());
            urlParam.Add("build_number", showHistoryDetailsRequest.BuildNumber.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/{build_number}/history-details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHistoryDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowHistoryDetailsResponse>(response);
        }

        public AsyncInvoker<ShowHistoryDetailsResponse> ShowHistoryDetailsAsyncInvoker(ShowHistoryDetailsRequest showHistoryDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showHistoryDetailsRequest.JobId.ToString());
            urlParam.Add("build_number", showHistoryDetailsRequest.BuildNumber.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/{build_number}/history-details", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHistoryDetailsRequest);
            return new AsyncInvoker<ShowHistoryDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHistoryDetailsResponse>);
        }
        
        /// <summary>
        /// 获取镜像模板列表
        ///
        /// 获取镜像模板列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowImageTemplateListResponse> ShowImageTemplateListAsync(ShowImageTemplateListRequest showImageTemplateListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/image/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showImageTemplateListRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowImageTemplateListResponse>(response);
        }

        public AsyncInvoker<ShowImageTemplateListResponse> ShowImageTemplateListAsyncInvoker(ShowImageTemplateListRequest showImageTemplateListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/image/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showImageTemplateListRequest);
            return new AsyncInvoker<ShowImageTemplateListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowImageTemplateListResponse>);
        }
        
        /// <summary>
        /// 查询构建成功率
        ///
        /// 查询构建成功率
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowJobBuildSuccessRatioResponse> ShowJobBuildSuccessRatioAsync(ShowJobBuildSuccessRatioRequest showJobBuildSuccessRatioRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/report/ratio", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobBuildSuccessRatioRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowJobBuildSuccessRatioResponse>(response);
        }

        public AsyncInvoker<ShowJobBuildSuccessRatioResponse> ShowJobBuildSuccessRatioAsyncInvoker(ShowJobBuildSuccessRatioRequest showJobBuildSuccessRatioRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/report/ratio", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobBuildSuccessRatioRequest);
            return new AsyncInvoker<ShowJobBuildSuccessRatioResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobBuildSuccessRatioResponse>);
        }
        
        /// <summary>
        /// 洞察构建时长
        ///
        /// 洞察构建时长
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowJobBuildTimeResponse> ShowJobBuildTimeAsync(ShowJobBuildTimeRequest showJobBuildTimeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/report/time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobBuildTimeRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowJobBuildTimeResponse>(response);
        }

        public AsyncInvoker<ShowJobBuildTimeResponse> ShowJobBuildTimeAsyncInvoker(ShowJobBuildTimeRequest showJobBuildTimeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/report/time", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobBuildTimeRequest);
            return new AsyncInvoker<ShowJobBuildTimeResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobBuildTimeResponse>);
        }
        
        /// <summary>
        /// 获取构建任务详情
        ///
        /// 获取构建任务详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowJobConfigResponse> ShowJobConfigAsync(ShowJobConfigRequest showJobConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobConfigRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/job/{job_id}/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowJobConfigResponse>(response);
        }

        public AsyncInvoker<ShowJobConfigResponse> ShowJobConfigAsyncInvoker(ShowJobConfigRequest showJobConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobConfigRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/job/{job_id}/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobConfigRequest);
            return new AsyncInvoker<ShowJobConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobConfigResponse>);
        }
        
        /// <summary>
        /// 获取构建任务配置的对比差异
        ///
        /// 获取构建任务配置的对比差异
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowJobConfigDiffResponse> ShowJobConfigDiffAsync(ShowJobConfigDiffRequest showJobConfigDiffRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobConfigDiffRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/job/{job_id}/diff", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobConfigDiffRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowJobConfigDiffResponse>(response);
        }

        public AsyncInvoker<ShowJobConfigDiffResponse> ShowJobConfigDiffAsyncInvoker(ShowJobConfigDiffRequest showJobConfigDiffRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobConfigDiffRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/job/{job_id}/diff", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobConfigDiffRequest);
            return new AsyncInvoker<ShowJobConfigDiffResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobConfigDiffResponse>);
        }
        
        /// <summary>
        /// 查看构建任务构建信息
        ///
        /// 查看构建任务构建信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowJobInfoResponse> ShowJobInfoAsync(ShowJobInfoRequest showJobInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobInfoRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/job/{job_id}/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowJobInfoResponse>(response);
        }

        public AsyncInvoker<ShowJobInfoResponse> ShowJobInfoAsyncInvoker(ShowJobInfoRequest showJobInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobInfoRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/job/{job_id}/info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobInfoRequest);
            return new AsyncInvoker<ShowJobInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobInfoResponse>);
        }
        
        /// <summary>
        /// 查看项目下用户的构建任务列表
        ///
        /// 查看项目下用户的构建任务列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowJobListByProjectIdResponse> ShowJobListByProjectIdAsync(ShowJobListByProjectIdRequest showJobListByProjectIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", showJobListByProjectIdRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobListByProjectIdRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowJobListByProjectIdResponse>(response);
        }

        public AsyncInvoker<ShowJobListByProjectIdResponse> ShowJobListByProjectIdAsyncInvoker(ShowJobListByProjectIdRequest showJobListByProjectIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", showJobListByProjectIdRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobListByProjectIdRequest);
            return new AsyncInvoker<ShowJobListByProjectIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobListByProjectIdResponse>);
        }
        
        /// <summary>
        /// 获取通知信息
        ///
        /// 获取通知信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowJobNoticeConfigInfoResponse> ShowJobNoticeConfigInfoAsync(ShowJobNoticeConfigInfoRequest showJobNoticeConfigInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobNoticeConfigInfoRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/job/{job_id}/notice", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobNoticeConfigInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowJobNoticeConfigInfoResponse>(response);
        }

        public AsyncInvoker<ShowJobNoticeConfigInfoResponse> ShowJobNoticeConfigInfoAsyncInvoker(ShowJobNoticeConfigInfoRequest showJobNoticeConfigInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobNoticeConfigInfoRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/job/{job_id}/notice", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobNoticeConfigInfoRequest);
            return new AsyncInvoker<ShowJobNoticeConfigInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobNoticeConfigInfoResponse>);
        }
        
        /// <summary>
        /// 获取构建任务的角色权限矩阵信息
        ///
        /// 获取构建任务的角色权限矩阵信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowJobRolePermissionResponse> ShowJobRolePermissionAsync(ShowJobRolePermissionRequest showJobRolePermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/job/permission/role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobRolePermissionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowJobRolePermissionResponse>(response);
        }

        public AsyncInvoker<ShowJobRolePermissionResponse> ShowJobRolePermissionAsyncInvoker(ShowJobRolePermissionRequest showJobRolePermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/job/permission/role", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobRolePermissionRequest);
            return new AsyncInvoker<ShowJobRolePermissionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobRolePermissionResponse>);
        }
        
        /// <summary>
        /// 查看任务运行状态
        ///
        /// 查看任务运行状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowJobStatusResponse> ShowJobStatusAsync(ShowJobStatusRequest showJobStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobStatusRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowJobStatusResponse>(response);
        }

        public AsyncInvoker<ShowJobStatusResponse> ShowJobStatusAsyncInvoker(ShowJobStatusRequest showJobStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobStatusRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobStatusRequest);
            return new AsyncInvoker<ShowJobStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobStatusResponse>);
        }
        
        /// <summary>
        /// 根据开始时间和结束时间查看构建任务的构建成功率
        ///
        /// 根据开始时间和结束时间查看构建任务的构建成功率
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowJobSuccessRatioResponse> ShowJobSuccessRatioAsync(ShowJobSuccessRatioRequest showJobSuccessRatioRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobSuccessRatioRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/success-ratio", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobSuccessRatioRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowJobSuccessRatioResponse>(response);
        }

        public AsyncInvoker<ShowJobSuccessRatioResponse> ShowJobSuccessRatioAsyncInvoker(ShowJobSuccessRatioRequest showJobSuccessRatioRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobSuccessRatioRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/success-ratio", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobSuccessRatioRequest);
            return new AsyncInvoker<ShowJobSuccessRatioResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobSuccessRatioResponse>);
        }
        
        /// <summary>
        /// 查看系统预定义参数
        ///
        /// 查看系统预定义参数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowJobSystemParametersResponse> ShowJobSystemParametersAsync(ShowJobSystemParametersRequest showJobSystemParametersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/job/system-parameters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobSystemParametersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowJobSystemParametersResponse>(response);
        }

        public AsyncInvoker<ShowJobSystemParametersResponse> ShowJobSystemParametersAsyncInvoker(ShowJobSystemParametersRequest showJobSystemParametersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/job/system-parameters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobSystemParametersRequest);
            return new AsyncInvoker<ShowJobSystemParametersResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobSystemParametersResponse>);
        }
        
        /// <summary>
        /// 文件管理查询权限
        ///
        /// 文件管理查询权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowKeystorePermissionResponse> ShowKeystorePermissionAsync(ShowKeystorePermissionRequest showKeystorePermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("keystore_id", showKeystorePermissionRequest.KeystoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/keystore/permission/{keystore_id}/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKeystorePermissionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowKeystorePermissionResponse>(response);
        }

        public AsyncInvoker<ShowKeystorePermissionResponse> ShowKeystorePermissionAsyncInvoker(ShowKeystorePermissionRequest showKeystorePermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("keystore_id", showKeystorePermissionRequest.KeystoreId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/keystore/permission/{keystore_id}/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showKeystorePermissionRequest);
            return new AsyncInvoker<ShowKeystorePermissionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowKeystorePermissionResponse>);
        }
        
        /// <summary>
        /// 查询指定代码仓库最近一次成功的构建历史
        ///
        /// 查询指定代码仓库最近一次成功的构建历史
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowLastHistoryResponse> ShowLastHistoryAsync(ShowLastHistoryRequest showLastHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", showLastHistoryRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{project_id}/last-history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLastHistoryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowLastHistoryResponse>(response);
        }

        public AsyncInvoker<ShowLastHistoryResponse> ShowLastHistoryAsyncInvoker(ShowLastHistoryRequest showLastHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("project_id", showLastHistoryRequest.ProjectId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{project_id}/last-history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLastHistoryRequest);
            return new AsyncInvoker<ShowLastHistoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLastHistoryResponse>);
        }
        
        /// <summary>
        /// 查看构建任务的构建历史列表
        ///
        /// 查看构建任务的构建历史列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowListHistoryResponse> ShowListHistoryAsync(ShowListHistoryRequest showListHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showListHistoryRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showListHistoryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowListHistoryResponse>(response);
        }

        public AsyncInvoker<ShowListHistoryResponse> ShowListHistoryAsyncInvoker(ShowListHistoryRequest showListHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showListHistoryRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showListHistoryRequest);
            return new AsyncInvoker<ShowListHistoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowListHistoryResponse>);
        }
        
        /// <summary>
        /// 根据开始时间和结束时间查看构建任务的构建历史列表
        ///
        /// 根据开始时间和结束时间查看构建任务的构建历史列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowListPeriodHistoryResponse> ShowListPeriodHistoryAsync(ShowListPeriodHistoryRequest showListPeriodHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showListPeriodHistoryRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/period-history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showListPeriodHistoryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowListPeriodHistoryResponse>(response);
        }

        public AsyncInvoker<ShowListPeriodHistoryResponse> ShowListPeriodHistoryAsyncInvoker(ShowListPeriodHistoryRequest showListPeriodHistoryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showListPeriodHistoryRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/period-history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showListPeriodHistoryRequest);
            return new AsyncInvoker<ShowListPeriodHistoryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowListPeriodHistoryResponse>);
        }
        
        /// <summary>
        /// 获取构建产物详情信息
        ///
        /// 获取构建产物详情信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowOutputInfoResponse> ShowOutputInfoAsync(ShowOutputInfoRequest showOutputInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showOutputInfoRequest.JobId.ToString());
            urlParam.Add("build_no", showOutputInfoRequest.BuildNo.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/{build_no}/output-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOutputInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowOutputInfoResponse>(response);
        }

        public AsyncInvoker<ShowOutputInfoResponse> ShowOutputInfoAsyncInvoker(ShowOutputInfoRequest showOutputInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showOutputInfoRequest.JobId.ToString());
            urlParam.Add("build_no", showOutputInfoRequest.BuildNo.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/{build_no}/output-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOutputInfoRequest);
            return new AsyncInvoker<ShowOutputInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOutputInfoResponse>);
        }
        
        /// <summary>
        /// 获取用户权限
        ///
        /// 获取用户权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowProjectPermissionResponse> ShowProjectPermissionAsync(ShowProjectPermissionRequest showProjectPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/domain/user-permission", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectPermissionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectPermissionResponse>(response);
        }

        public AsyncInvoker<ShowProjectPermissionResponse> ShowProjectPermissionAsyncInvoker(ShowProjectPermissionRequest showProjectPermissionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/domain/user-permission", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectPermissionRequest);
            return new AsyncInvoker<ShowProjectPermissionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectPermissionResponse>);
        }
        
        /// <summary>
        /// 获取构建记录信息
        ///
        /// 获取构建记录信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRecordDetailResponse> ShowRecordDetailAsync(ShowRecordDetailRequest showRecordDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showRecordDetailRequest.JobId.ToString());
            urlParam.Add("build_no", showRecordDetailRequest.BuildNo.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/jobs/{job_id}/{build_no}/record-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRecordDetailResponse>(response);
        }

        public AsyncInvoker<ShowRecordDetailResponse> ShowRecordDetailAsyncInvoker(ShowRecordDetailRequest showRecordDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showRecordDetailRequest.JobId.ToString());
            urlParam.Add("build_no", showRecordDetailRequest.BuildNo.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v4/jobs/{job_id}/{build_no}/record-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordDetailRequest);
            return new AsyncInvoker<ShowRecordDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecordDetailResponse>);
        }
        
        /// <summary>
        /// 获取当前用户的项目信息列表
        ///
        /// 获取当前用户的项目信息列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRelatedProjectResponse> ShowRelatedProjectAsync(ShowRelatedProjectRequest showRelatedProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/domain/project/related", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRelatedProjectRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRelatedProjectResponse>(response);
        }

        public AsyncInvoker<ShowRelatedProjectResponse> ShowRelatedProjectAsyncInvoker(ShowRelatedProjectRequest showRelatedProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/domain/project/related", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRelatedProjectRequest);
            return new AsyncInvoker<ShowRelatedProjectResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRelatedProjectResponse>);
        }
        
        /// <summary>
        /// 获取覆盖率接口
        ///
        /// 获取覆盖率接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowReportSummaryResponse> ShowReportSummaryAsync(ShowReportSummaryRequest showReportSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showReportSummaryRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/report/{job_id}/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReportSummaryRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowReportSummaryResponse>(response);
        }

        public AsyncInvoker<ShowReportSummaryResponse> ShowReportSummaryAsyncInvoker(ShowReportSummaryRequest showReportSummaryRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showReportSummaryRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/report/{job_id}/summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReportSummaryRequest);
            return new AsyncInvoker<ShowReportSummaryResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowReportSummaryResponse>);
        }
        
        /// <summary>
        /// 查看任务是否在构建
        ///
        /// 查看任务是否在构建
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRunningStatusResponse> ShowRunningStatusAsync(ShowRunningStatusRequest showRunningStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showRunningStatusRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/job/{job_id}/running-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRunningStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRunningStatusResponse>(response);
        }

        public AsyncInvoker<ShowRunningStatusResponse> ShowRunningStatusAsyncInvoker(ShowRunningStatusRequest showRunningStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showRunningStatusRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/job/{job_id}/running-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRunningStatusRequest);
            return new AsyncInvoker<ShowRunningStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRunningStatusResponse>);
        }
        
        /// <summary>
        /// 获取代码化构建默认模板
        ///
        /// 获取代码化构建默认模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowYamlTemplateResponse> ShowYamlTemplateAsync(ShowYamlTemplateRequest showYamlTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showYamlTemplateRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/template/{job_id}/default-template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showYamlTemplateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowYamlTemplateResponse>(response);
        }

        public AsyncInvoker<ShowYamlTemplateResponse> ShowYamlTemplateAsyncInvoker(ShowYamlTemplateRequest showYamlTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showYamlTemplateRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/template/{job_id}/default-template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showYamlTemplateRequest);
            return new AsyncInvoker<ShowYamlTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowYamlTemplateResponse>);
        }
        
        /// <summary>
        /// 停止构建任务
        ///
        /// 停止构建任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StopBuildJobResponse> StopBuildJobAsync(StopBuildJobRequest stopBuildJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", stopBuildJobRequest.JobId.ToString());
            urlParam.Add("build_no", stopBuildJobRequest.BuildNo.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/{build_no}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopBuildJobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StopBuildJobResponse>(response);
        }

        public AsyncInvoker<StopBuildJobResponse> StopBuildJobAsyncInvoker(StopBuildJobRequest stopBuildJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", stopBuildJobRequest.JobId.ToString());
            urlParam.Add("build_no", stopBuildJobRequest.BuildNo.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/{build_no}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopBuildJobRequest);
            return new AsyncInvoker<StopBuildJobResponse>(this, "POST", request, JsonUtils.DeSerialize<StopBuildJobResponse>);
        }
        
        /// <summary>
        /// 更新构建任务
        ///
        /// 更新构建任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateBuildJobResponse> UpdateBuildJobAsync(UpdateBuildJobRequest updateBuildJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBuildJobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateBuildJobResponse>(response);
        }

        public AsyncInvoker<UpdateBuildJobResponse> UpdateBuildJobAsyncInvoker(UpdateBuildJobRequest updateBuildJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBuildJobRequest);
            return new AsyncInvoker<UpdateBuildJobResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateBuildJobResponse>);
        }
        
        /// <summary>
        /// 更新通知
        ///
        /// 更新通知
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateNoticeResponse> UpdateNoticeAsync(UpdateNoticeRequest updateNoticeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", updateNoticeRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/notice/{job_id}/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNoticeRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateNoticeResponse>(response);
        }

        public AsyncInvoker<UpdateNoticeResponse> UpdateNoticeAsyncInvoker(UpdateNoticeRequest updateNoticeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", updateNoticeRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/notice/{job_id}/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNoticeRequest);
            return new AsyncInvoker<UpdateNoticeResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateNoticeResponse>);
        }
        
        /// <summary>
        /// 下载构建日志(待下线)
        ///
        /// 下载构建日志(待下线)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DownloadLogByRecordIdResponse> DownloadLogByRecordIdAsync(DownloadLogByRecordIdRequest downloadLogByRecordIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("record_id", downloadLogByRecordIdRequest.RecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{record_id}/download-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadLogByRecordIdRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<DownloadLogByRecordIdResponse>(response);
        }

        public AsyncInvoker<DownloadLogByRecordIdResponse> DownloadLogByRecordIdAsyncInvoker(DownloadLogByRecordIdRequest downloadLogByRecordIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("record_id", downloadLogByRecordIdRequest.RecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{record_id}/download-log", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadLogByRecordIdRequest);
            return new AsyncInvoker<DownloadLogByRecordIdResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadLogByRecordIdResponse>);
        }
        
        /// <summary>
        /// 获取构建记录的有向无环图(待下线)
        ///
        /// 获取构建记录的有向无环图(待下线)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowFlowGraphResponse> ShowFlowGraphAsync(ShowFlowGraphRequest showFlowGraphRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("build_flow_record_id", showFlowGraphRequest.BuildFlowRecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{build_flow_record_id}/flow-graph", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlowGraphRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowFlowGraphResponse>(response);
        }

        public AsyncInvoker<ShowFlowGraphResponse> ShowFlowGraphAsyncInvoker(ShowFlowGraphRequest showFlowGraphRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("build_flow_record_id", showFlowGraphRequest.BuildFlowRecordId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{build_flow_record_id}/flow-graph", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlowGraphRequest);
            return new AsyncInvoker<ShowFlowGraphResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFlowGraphResponse>);
        }
        
        /// <summary>
        /// 获取构建记录信息(待下线)
        ///
        /// 获取构建记录信息(待下线)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRecordInfoResponse> ShowRecordInfoAsync(ShowRecordInfoRequest showRecordInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showRecordInfoRequest.JobId.ToString());
            urlParam.Add("build_no", showRecordInfoRequest.BuildNo.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/{build_no}/record-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRecordInfoResponse>(response);
        }

        public AsyncInvoker<ShowRecordInfoResponse> ShowRecordInfoAsyncInvoker(ShowRecordInfoRequest showRecordInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showRecordInfoRequest.JobId.ToString());
            urlParam.Add("build_no", showRecordInfoRequest.BuildNo.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/{job_id}/{build_no}/record-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordInfoRequest);
            return new AsyncInvoker<ShowRecordInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecordInfoResponse>);
        }
        
        /// <summary>
        /// 停止构建任务(待下线)
        ///
        /// 停止构建任务(待下线)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StopJobResponse> StopJobAsync(StopJobRequest stopJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopJobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StopJobResponse>(response);
        }

        public AsyncInvoker<StopJobResponse> StopJobAsyncInvoker(StopJobRequest stopJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/jobs/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopJobRequest);
            return new AsyncInvoker<StopJobResponse>(this, "POST", request, JsonUtils.DeSerialize<StopJobResponse>);
        }
        
    }
}