using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Drs.V5.Model;

namespace HuaweiCloud.SDK.Drs.V5
{
    public partial class DrsAsyncClient : Client
    {
        public static ClientBuilder<DrsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<DrsAsyncClient>();
        }

        
        /// <summary>
        /// 批量异步创建任务
        ///
        /// 批量异步创建任务，根据请求参数不同，可以批量异步创建实时迁移、实时同步、实时灾备等任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateJobsAsyncResponse> BatchCreateJobsAsyncAsync(BatchCreateJobsAsyncRequest batchCreateJobsAsyncRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/batch-async-create",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateJobsAsyncRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchCreateJobsAsyncResponse>(response);
        }
        
        /// <summary>
        /// 批量删除任务
        ///
        /// 批量删除租户指定ID任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteJobsByIdResponse> BatchDeleteJobsByIdAsync(BatchDeleteJobsByIdRequest batchDeleteJobsByIdRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteJobsByIdRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<BatchDeleteJobsByIdResponse>(response);
        }
        
        /// <summary>
        /// 批量操作指定ID任务
        ///
        /// 批量操作租户指定ID任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchExecuteJobActionsResponse> BatchExecuteJobActionsAsync(BatchExecuteJobActionsRequest batchExecuteJobActionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchExecuteJobActionsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchExecuteJobActionsResponse>(response);
        }
        
        /// <summary>
        /// 提交查询数据库对象信息
        ///
        /// 提交查询数据库对象信息。例如：
        /// - 当type取值为source时，表示查询源库库表信息。
        /// - 当源库库表信息有变化时，则type取值为source，is_refresh取值为true。
        /// - 当已同步到目标库的库表信息过大，需要提前将数据加载到缓存中时，type取值为synchronized。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CollectDbObjectsAsyncResponse> CollectDbObjectsAsyncAsync(CollectDbObjectsAsyncRequest collectDbObjectsAsyncRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , collectDbObjectsAsyncRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-objects/collect",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectDbObjectsAsyncRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CollectDbObjectsAsyncResponse>(response);
        }
        
        /// <summary>
        /// 提交批量创建异步任务
        ///
        /// 提交批量创建异步任务，当批量异步任务创建或更新参数后，系统会自动开始进行参数校验，待所有任务成功完成参数校验后并且无报错时，可调用此接口开始创建DRS任务实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CommitAsyncJobResponse> CommitAsyncJobAsync(CommitAsyncJobRequest commitAsyncJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("async_job_id" , commitAsyncJobRequest.AsyncJobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/batch-async-jobs/{async_job_id}/commit",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", commitAsyncJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CommitAsyncJobResponse>(response);
        }
        
        /// <summary>
        /// 创建任务
        ///
        /// 创建单个任务，根据请求参数不同，可以创建单个实时迁移、实时同步、实时灾备等任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateJobResponse> CreateJobAsync(CreateJobRequest createJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateJobResponse>(response);
        }
        
        /// <summary>
        /// 删除指定ID任务
        ///
        /// 删除租户指定ID任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteJobResponse> DeleteJobAsync(DeleteJobRequest deleteJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , deleteJobRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteJobResponse>(response);
        }
        
        /// <summary>
        /// 对象选择（文件导入 - 模板下载）
        ///
        /// 对象选择（文件导入 - 模板下载）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DownloadDbObjectTemplateResponse> DownloadDbObjectTemplateAsync(DownloadDbObjectTemplateRequest downloadDbObjectTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , downloadDbObjectTemplateRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-object/template",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadDbObjectTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<DownloadDbObjectTemplateResponse>(response);
        }
        
        /// <summary>
        /// 操作指定ID任务
        ///
        /// 操作租户指定ID任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExecuteJobActionResponse> ExecuteJobActionAsync(ExecuteJobActionRequest executeJobActionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , executeJobActionRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeJobActionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ExecuteJobActionResponse>(response);
        }
        
        /// <summary>
        /// 查询指定ID批量异步任务详情
        ///
        /// 查询租户指定ID批量异步任务详情，默认为任务的“create_time”降序排序获取结果，支持分页查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAsyncJobDetailResponse> ListAsyncJobDetailAsync(ListAsyncJobDetailRequest listAsyncJobDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("async_job_id" , listAsyncJobDetailRequest.AsyncJobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/batch-async-jobs/{async_job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAsyncJobDetailRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAsyncJobDetailResponse>(response);
        }
        
        /// <summary>
        /// 查询批量异步创建的任务列表
        ///
        /// 查询租户批量异步创建的任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAsyncJobsResponse> ListAsyncJobsAsync(ListAsyncJobsRequest listAsyncJobsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/batch-async-jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAsyncJobsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAsyncJobsResponse>(response);
        }
        
        /// <summary>
        /// 查询数据库对象信息
        ///
        /// 查询数据库对象信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDbObjectsResponse> ListDbObjectsAsync(ListDbObjectsRequest listDbObjectsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , listDbObjectsRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-objects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbObjectsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDbObjectsResponse>(response);
        }
        
        /// <summary>
        /// 查询任务列表
        ///
        /// 查询租户任务列表，可以根据企业项目，引擎类型，网络类型，任务状态，任务名称，任务ID进行查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListJobsResponse> ListJobsAsync(ListJobsRequest listJobsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListJobsResponse>(response);
        }
        
        /// <summary>
        /// 查询可用链路信息
        ///
        /// 查询可用链路信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLinksResponse> ListLinksAsync(ListLinksRequest listLinksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/links",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLinksRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListLinksResponse>(response);
        }
        
        /// <summary>
        /// 获取提交查询数据库对象信息的结果
        ///
        /// 获取提交查询数据库对象信息的结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDbObjectCollectionStatusResponse> ShowDbObjectCollectionStatusAsync(ShowDbObjectCollectionStatusRequest showDbObjectCollectionStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showDbObjectCollectionStatusRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-objects/collection-status",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDbObjectCollectionStatusRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDbObjectCollectionStatusResponse>(response);
        }
        
        /// <summary>
        /// 对象选择（文件导入 - 进度查询）
        ///
        /// 对象选择（文件导入 - 进度查询）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDbObjectTemplateProgressResponse> ShowDbObjectTemplateProgressAsync(ShowDbObjectTemplateProgressRequest showDbObjectTemplateProgressRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showDbObjectTemplateProgressRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-object/template/progress",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDbObjectTemplateProgressRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDbObjectTemplateProgressResponse>(response);
        }
        
        /// <summary>
        /// 对象选择（文件导入 - 获取导入结果）
        ///
        /// 对象选择（文件导入 - 获取导入结果）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDbObjectTemplateResultResponse> ShowDbObjectTemplateResultAsync(ShowDbObjectTemplateResultRequest showDbObjectTemplateResultRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showDbObjectTemplateResultRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-object/template/result",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDbObjectTemplateResultRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDbObjectTemplateResultResponse>(response);
        }
        
        /// <summary>
        /// 查询任务详情
        ///
        /// 查询任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowJobDetailResponse> ShowJobDetailAsync(ShowJobDetailRequest showJobDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showJobDetailRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobDetailRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowJobDetailResponse>(response);
        }
        
        /// <summary>
        /// 获取对象保存进度
        ///
        /// 获取对象保存进度。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowUpdateObjectSavingStatusResponse> ShowUpdateObjectSavingStatusAsync(ShowUpdateObjectSavingStatusRequest showUpdateObjectSavingStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showUpdateObjectSavingStatusRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-objects/saving-status",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpdateObjectSavingStatusRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowUpdateObjectSavingStatusResponse>(response);
        }
        
        /// <summary>
        /// 更新指定ID批量异步任务详情
        ///
        /// 更新租户指定ID批量异步任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateBatchAsyncJobsResponse> UpdateBatchAsyncJobsAsync(UpdateBatchAsyncJobsRequest updateBatchAsyncJobsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("async_job_id" , updateBatchAsyncJobsRequest.AsyncJobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/batch-async-jobs/{async_job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBatchAsyncJobsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateBatchAsyncJobsResponse>(response);
        }
        
        /// <summary>
        /// 更新指定ID任务详情
        ///
        /// 更新租户指定ID任务详情。
        /// 当type取值为db_object， 进行异步处理。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateJobResponse> UpdateJobAsync(UpdateJobRequest updateJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , updateJobRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateJobResponse>(response);
        }
        
        /// <summary>
        /// 对象选择（文件导入 - 模板上传）
        ///
        /// 对象选择（文件导入 - 模板上传）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UploadDbObjectTemplateResponse> UploadDbObjectTemplateAsync(UploadDbObjectTemplateRequest uploadDbObjectTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , uploadDbObjectTemplateRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-object/template",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadDbObjectTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<UploadDbObjectTemplateResponse>(response);
        }
        
    }
}