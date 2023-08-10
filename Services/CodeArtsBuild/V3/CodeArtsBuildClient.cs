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
        /// 执行构建任务
        ///
        /// 执行构建任务,可传自定义参数。
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
        
    }
}