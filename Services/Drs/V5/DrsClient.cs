using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Drs.V5.Model;

namespace HuaweiCloud.SDK.Drs.V5
{
    public partial class DrsClient : Client
    {
        public static ClientBuilder<DrsClient> NewBuilder()
        {
            return new ClientBuilder<DrsClient>();
        }

        
        /// <summary>
        /// 批量异步创建任务
        ///
        /// 批量异步创建任务，根据请求参数不同，可以批量异步创建实时迁移、实时同步、实时灾备等任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateJobsAsyncResponse BatchCreateJobsAsync(BatchCreateJobsAsyncRequest batchCreateJobsAsyncRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/batch-async-create",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateJobsAsyncRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<BatchCreateJobsAsyncResponse>(response);
        }
        
        /// <summary>
        /// 批量删除任务
        ///
        /// 批量删除租户指定ID任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteJobsByIdResponse BatchDeleteJobsById(BatchDeleteJobsByIdRequest batchDeleteJobsByIdRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteJobsByIdRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<BatchDeleteJobsByIdResponse>(response);
        }
        
        /// <summary>
        /// 批量操作指定ID任务
        ///
        /// 批量操作租户指定ID任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchExecuteJobActionsResponse BatchExecuteJobActions(BatchExecuteJobActionsRequest batchExecuteJobActionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchExecuteJobActionsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<BatchExecuteJobActionsResponse>(response);
        }
        
        /// <summary>
        /// 批量结束任务
        ///
        /// 批量结束租户指定ID任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchStopJobsActionResponse BatchStopJobsAction(BatchStopJobsActionRequest batchStopJobsActionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/batch-stop",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchStopJobsActionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<BatchStopJobsActionResponse>(response);
        }
        
        /// <summary>
        /// 批量添加或删除资源标签
        ///
        /// 批量添加删除资源标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchTagActionResponse BatchTagAction(BatchTagActionRequest batchTagActionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , batchTagActionRequest.ResourceType.ToString());
            urlParam.Add("job_id" , batchTagActionRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{resource_type}/{job_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchTagActionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchTagActionResponse>(response);
        }
        
        /// <summary>
        /// 数据过滤规则校验
        ///
        /// 数据过滤规则校验
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CheckDataFilterResponse CheckDataFilter(CheckDataFilterRequest checkDataFilterRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , checkDataFilterRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/job/{job_id}/data-filtering/check",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkDataFilterRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CheckDataFilterResponse>(response);
        }
        
        /// <summary>
        /// 采集指定数据库表的列信息
        ///
        /// 采集指定数据库表的列信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CollectColumnsResponse CollectColumns(CollectColumnsRequest collectColumnsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , collectColumnsRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/job/{job_id}/columns/collect",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectColumnsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CollectColumnsResponse>(response);
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
        public CollectDbObjectsAsyncResponse CollectDbObjectsAsync(CollectDbObjectsAsyncRequest collectDbObjectsAsyncRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , collectDbObjectsAsyncRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-objects/collect",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectDbObjectsAsyncRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CollectDbObjectsAsyncResponse>(response);
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
        public CollectDbObjectsInfoResponse CollectDbObjectsInfo(CollectDbObjectsInfoRequest collectDbObjectsInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , collectDbObjectsInfoRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5.1/{project_id}/jobs/{job_id}/db-objects/collect",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectDbObjectsInfoRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CollectDbObjectsInfoResponse>(response);
        }
        
        /// <summary>
        /// 采集数据库位点信息
        ///
        /// 采集数据库位点信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CollectPositionAsyncResponse CollectPositionAsync(CollectPositionAsyncRequest collectPositionAsyncRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , collectPositionAsyncRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/collect-db-position",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectPositionAsyncRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CollectPositionAsyncResponse>(response);
        }
        
        /// <summary>
        /// 提交批量创建异步任务
        ///
        /// 提交批量创建异步任务，当批量异步任务创建或更新参数后，系统会自动开始进行参数校验，待所有任务成功完成参数校验后并且无报错时，可调用此接口开始创建DRS任务实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CommitAsyncJobResponse CommitAsyncJob(CommitAsyncJobRequest commitAsyncJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("async_job_id" , commitAsyncJobRequest.AsyncJobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/batch-async-jobs/{async_job_id}/commit",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", commitAsyncJobRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CommitAsyncJobResponse>(response);
        }
        
        /// <summary>
        /// 克隆任务
        ///
        /// DRS支持通过克隆功能，快速复制现有同步任务的配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CopyJobResponse CopyJob(CopyJobRequest copyJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/clone",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", copyJobRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CopyJobResponse>(response);
        }
        
        /// <summary>
        /// 创建任务
        ///
        /// 创建单个任务，根据请求参数不同，可以创建单个实时迁移、实时同步、实时灾备等任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateJobResponse CreateJob(CreateJobRequest createJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createJobRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateJobResponse>(response);
        }
        
        /// <summary>
        /// 删除驱动文件
        ///
        /// 删除驱动文件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteJdbcDriverResponse DeleteJdbcDriver(DeleteJdbcDriverRequest deleteJdbcDriverRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jdbc-drivers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteJdbcDriverRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteJdbcDriverResponse>(response);
        }
        
        /// <summary>
        /// 删除指定ID任务
        ///
        /// 删除租户指定ID任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteJobResponse DeleteJob(DeleteJobRequest deleteJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , deleteJobRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteJobRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteJobResponse>(response);
        }
        
        /// <summary>
        /// 下载批量导入任务模板
        ///
        /// 下载批量导入任务模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DownloadBatchCreateTemplateResponse DownloadBatchCreateTemplate(DownloadBatchCreateTemplateRequest downloadBatchCreateTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/template",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadBatchCreateTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<DownloadBatchCreateTemplateResponse>(response);
        }
        
        /// <summary>
        /// 对象选择（文件导入 - 模板下载）
        ///
        /// 对象选择（文件导入 - 模板下载）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DownloadDbObjectTemplateResponse DownloadDbObjectTemplate(DownloadDbObjectTemplateRequest downloadDbObjectTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , downloadDbObjectTemplateRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-object/template",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadDbObjectTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<DownloadDbObjectTemplateResponse>(response);
        }
        
        /// <summary>
        /// 操作指定ID任务
        ///
        /// 操作租户指定ID任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExecuteJobActionResponse ExecuteJobAction(ExecuteJobActionRequest executeJobActionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , executeJobActionRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeJobActionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ExecuteJobActionResponse>(response);
        }
        
        /// <summary>
        /// 导出任务操作统计信息
        ///
        /// 导出指定任务操作统计信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExportOperationInfoResponse ExportOperationInfo(ExportOperationInfoRequest exportOperationInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , exportOperationInfoRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/operation-statistics/export",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportOperationInfoRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            ExportOperationInfoResponse exportOperationInfoResponse = JsonUtils.DeSerializeNull<ExportOperationInfoResponse>(response);
            return exportOperationInfoResponse;
        }
        
        /// <summary>
        /// 批量导入任务
        ///
        /// 批量导入任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ImportBatchCreateJobsResponse ImportBatchCreateJobs(ImportBatchCreateJobsRequest importBatchCreateJobsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/template",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", importBatchCreateJobsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ImportBatchCreateJobsResponse>(response);
        }
        
        /// <summary>
        /// 查询指定ID批量异步任务详情
        ///
        /// 查询租户指定ID批量异步任务详情，默认为任务的“create_time”降序排序获取结果，支持分页查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAsyncJobDetailResponse ListAsyncJobDetail(ListAsyncJobDetailRequest listAsyncJobDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("async_job_id" , listAsyncJobDetailRequest.AsyncJobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/batch-async-jobs/{async_job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAsyncJobDetailRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAsyncJobDetailResponse>(response);
        }
        
        /// <summary>
        /// 查询批量异步创建的任务列表
        ///
        /// 查询租户批量异步创建的任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAsyncJobsResponse ListAsyncJobs(ListAsyncJobsRequest listAsyncJobsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/batch-async-jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAsyncJobsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAsyncJobsResponse>(response);
        }
        
        /// <summary>
        /// 查询数据库对象信息
        ///
        /// 查询数据库对象信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDbObjectsResponse ListDbObjects(ListDbObjectsRequest listDbObjectsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , listDbObjectsRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-objects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbObjectsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListDbObjectsResponse>(response);
        }
        
        /// <summary>
        /// 查询驱动文件列表
        ///
        /// 查询驱动文件列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListJdbcDriversResponse ListJdbcDrivers(ListJdbcDriversRequest listJdbcDriversRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jdbc-drivers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJdbcDriversRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListJdbcDriversResponse>(response);
        }
        
        /// <summary>
        /// 查询任务列表
        ///
        /// 查询租户任务列表，可以根据企业项目，引擎类型，网络类型，任务状态，任务名称，任务ID进行查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListJobsResponse ListJobs(ListJobsRequest listJobsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListJobsResponse>(response);
        }
        
        /// <summary>
        /// 查询可用链路信息
        ///
        /// 根据参数不同，可查询实时迁移、实时同步、实时灾备等可用链路信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLinksResponse ListLinks(ListLinksRequest listLinksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/links",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLinksRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListLinksResponse>(response);
        }
        
        /// <summary>
        /// 查询项目标签
        ///
        /// 查询指定project ID下不同任务类型的所有标签集合。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProjectTagsResponse ListProjectTags(ListProjectTagsRequest listProjectTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , listProjectTagsRequest.ResourceType.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{resource_type}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListProjectTagsResponse>(response);
        }
        
        /// <summary>
        /// 获取指定任务操作信息
        ///
        /// 获取指定任务允许、不允许、当前操作信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowActionsResponse ShowActions(ShowActionsRequest showActionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showActionsRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/actions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showActionsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowActionsResponse>(response);
        }
        
        /// <summary>
        /// 获取指定数据库表列信息
        ///
        /// 获取指定数据库表列信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowColumnInfoResultResponse ShowColumnInfoResult(ShowColumnInfoResultRequest showColumnInfoResultRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showColumnInfoResultRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/job/{job_id}/columns",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showColumnInfoResultRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowColumnInfoResultResponse>(response);
        }
        
        /// <summary>
        /// 查询对比策略
        ///
        /// 查询对比策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowComparePolicyResponse ShowComparePolicy(ShowComparePolicyRequest showComparePolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showComparePolicyRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/compare-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showComparePolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowComparePolicyResponse>(response);
        }
        
        /// <summary>
        /// 获取数据过滤校验结果
        ///
        /// 获取数据过滤校验结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDataFilteringResultResponse ShowDataFilteringResult(ShowDataFilteringResultRequest showDataFilteringResultRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showDataFilteringResultRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/job/{job_id}/data-filtering/result",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDataFilteringResultRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowDataFilteringResultResponse>(response);
        }
        
        /// <summary>
        /// 获取指定任务数据加工规则更新结果
        ///
        /// 获取指定任务数据加工规则更新结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDataProcessingRulesResultResponse ShowDataProcessingRulesResult(ShowDataProcessingRulesResultRequest showDataProcessingRulesResultRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showDataProcessingRulesResultRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/data-processing-rules/result",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDataProcessingRulesResultRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowDataProcessingRulesResultResponse>(response);
        }
        
        /// <summary>
        /// 查询数据加工规则
        ///
        /// 查询数据加工规则:包含数据库表的映射信息、列信息、数据过滤信息、附加列信息、DDL以及DML信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDataProgressResponse ShowDataProgress(ShowDataProgressRequest showDataProgressRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showDataProgressRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/data-processing-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDataProgressRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowDataProgressResponse>(response);
        }
        
        /// <summary>
        /// 获取提交查询数据库对象信息的结果
        ///
        /// 获取提交查询数据库对象信息的结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDbObjectCollectionStatusResponse ShowDbObjectCollectionStatus(ShowDbObjectCollectionStatusRequest showDbObjectCollectionStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showDbObjectCollectionStatusRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-objects/collection-status",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDbObjectCollectionStatusRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowDbObjectCollectionStatusResponse>(response);
        }
        
        /// <summary>
        /// 对象选择（文件导入 - 进度查询）
        ///
        /// 对象选择（文件导入 - 进度查询）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDbObjectTemplateProgressResponse ShowDbObjectTemplateProgress(ShowDbObjectTemplateProgressRequest showDbObjectTemplateProgressRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showDbObjectTemplateProgressRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-object/template/progress",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDbObjectTemplateProgressRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowDbObjectTemplateProgressResponse>(response);
        }
        
        /// <summary>
        /// 对象选择（文件导入 - 获取导入结果）
        ///
        /// 对象选择（文件导入 - 获取导入结果）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDbObjectTemplateResultResponse ShowDbObjectTemplateResult(ShowDbObjectTemplateResultRequest showDbObjectTemplateResultRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showDbObjectTemplateResultRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-object/template/result",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDbObjectTemplateResultRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowDbObjectTemplateResultResponse>(response);
        }
        
        /// <summary>
        /// 查询数据库对象信息
        ///
        /// 查询数据库对象信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDbObjectsListResponse ShowDbObjectsList(ShowDbObjectsListRequest showDbObjectsListRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showDbObjectsListRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5.1/{project_id}/jobs/{job_id}/db-object",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDbObjectsListRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowDbObjectsListResponse>(response);
        }
        
        /// <summary>
        /// 查询异常数据列表
        ///
        /// 查询异常数据列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDirtyDataResponse ShowDirtyData(ShowDirtyDataRequest showDirtyDataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showDirtyDataRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/dirty-data",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDirtyDataRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowDirtyDataResponse>(response);
        }
        
        /// <summary>
        /// 查询企业项目列表
        ///
        /// 查询企业项目列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowEnterpriseProjectResponse ShowEnterpriseProject(ShowEnterpriseProjectRequest showEnterpriseProjectRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/enterprise-projects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEnterpriseProjectRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowEnterpriseProjectResponse>(response);
        }
        
        /// <summary>
        /// 查询健康对比列表
        ///
        /// 查询健康对比列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowHealthCompareJobListResponse ShowHealthCompareJobList(ShowHealthCompareJobListRequest showHealthCompareJobListRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showHealthCompareJobListRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/health-compare-jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHealthCompareJobListRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowHealthCompareJobListResponse>(response);
        }
        
        /// <summary>
        /// 查询增量组件详情
        ///
        /// 查询任务同步的增量组件的详细信息，实时同步任务，任务模式为增量或者全量+增量才支持。具体介绍可以参考：[查询同步进度](https://support.huaweicloud.com/realtimesyn-drs/drs_10_0007.html)
        /// - 支持的引擎：oracle-to-gaussdbv5，oracle-to-gaussdbv5ha，gaussdbv5，gaussdbv5-to-mysql，gaussdbv5-to-gaussdbv5ha，gaussdbv5ha，gaussdbv5ha-to-gaussdbv5，gaussdbv5-to-dws，gaussdbv5ha-to-dws，gaussdbv5-to-oracle，gaussdbv5ha-to-oracle，oracle-to-dws，oracle-to-mysql
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowIncrementComponentsDetailResponse ShowIncrementComponentsDetail(ShowIncrementComponentsDetailRequest showIncrementComponentsDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showIncrementComponentsDetailRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/increment-components-detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIncrementComponentsDetailRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowIncrementComponentsDetailResponse>(response);
        }
        
        /// <summary>
        /// 查询资源标签
        ///
        /// 查询指定实例的标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceTagsResponse ShowInstanceTags(ShowInstanceTagsRequest showInstanceTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , showInstanceTagsRequest.ResourceType.ToString());
            urlParam.Add("job_id" , showInstanceTagsRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{resource_type}/{job_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowInstanceTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询任务详情
        ///
        /// 查询任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowJobDetailResponse ShowJobDetail(ShowJobDetailRequest showJobDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showJobDetailRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobDetailRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowJobDetailResponse>(response);
        }
        
        /// <summary>
        /// 获取任务价格信息
        ///
        /// 获取询价接口的参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMeteringResponse ShowMetering(ShowMeteringRequest showMeteringRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showMeteringRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/metering",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMeteringRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowMeteringResponse>(response);
        }
        
        /// <summary>
        /// 查询监控数据
        ///
        /// 获取任务监控数据。
        /// - Cassandra灾备不支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMonitorDataResponse ShowMonitorData(ShowMonitorDataRequest showMonitorDataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showMonitorDataRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/monitor-data",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMonitorDataRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowMonitorDataResponse>(response);
        }
        
        /// <summary>
        /// 查询同步映射列表
        ///
        /// 查询实时同步映射关系包括对象选择时的库映射、schema映射、表映射和数据加工时的列映射。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowObjectMappingResponse ShowObjectMapping(ShowObjectMappingRequest showObjectMappingRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showObjectMappingRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/object-mappings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showObjectMappingRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ShowObjectMappingResponse>(response);
        }
        
        /// <summary>
        /// 获取查询数据库位点的结果
        ///
        /// 获取查询数据库位点的结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPositionResultResponse ShowPositionResult(ShowPositionResultRequest showPositionResultRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showPositionResultRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-position",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPositionResultRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowPositionResultResponse>(response);
        }
        
        /// <summary>
        /// 查询数据级流式对比列表
        ///
        /// 查询不同迁移对象类型的迁移进度。
        /// 说明：
        /// - 目前仅MySQL-&gt;MySQL、MySQL-&gt;GaussDB(for MySQL)、MongoDB-&gt;DDS、DDS-&gt;MongoDB的迁移支持查看迁移明细。
        /// - 在任务未结束前，不能修改源库和目标库的所有用户、密码和用户权限等。
        /// - 全量、增量完成不代表任务结束，如果存在触发器和事件将会进行迁移。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowProgressDataResponse ShowProgressData(ShowProgressDataRequest showProgressDataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showProgressDataRequest.JobId.ToString());
            urlParam.Add("type" , showProgressDataRequest.Type.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/progress-data/{type}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProgressDataRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowProgressDataResponse>(response);
        }
        
        /// <summary>
        /// 查询是否支持对象选择和列映射
        ///
        /// 查询任务支持的对象选择类型、列映射、支持搜索的对象类型等信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowSupportObjectTypeResponse ShowSupportObjectType(ShowSupportObjectTypeRequest showSupportObjectTypeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showSupportObjectTypeRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/object/support",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSupportObjectTypeRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowSupportObjectTypeResponse>(response);
        }
        
        /// <summary>
        /// 获取对象保存进度
        ///
        /// 获取对象保存进度。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowUpdateObjectSavingStatusResponse ShowUpdateObjectSavingStatus(ShowUpdateObjectSavingStatusRequest showUpdateObjectSavingStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showUpdateObjectSavingStatusRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-objects/saving-status",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpdateObjectSavingStatusRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowUpdateObjectSavingStatusResponse>(response);
        }
        
        /// <summary>
        /// 结束任务
        ///
        /// 结束租户指定ID任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StopJobActionResponse StopJobAction(StopJobActionRequest stopJobActionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , stopJobActionRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/stop",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopJobActionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<StopJobActionResponse>(response);
        }
        
        /// <summary>
        /// 同步驱动文件
        ///
        /// 同步驱动文件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SyncJdbcDriverResponse SyncJdbcDriver(SyncJdbcDriverRequest syncJdbcDriverRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , syncJdbcDriverRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/update-jdbc-driver",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", syncJdbcDriverRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<SyncJdbcDriverResponse>(response);
        }
        
        /// <summary>
        /// 更新指定ID批量异步任务详情
        ///
        /// 更新租户指定ID批量异步任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateBatchAsyncJobsResponse UpdateBatchAsyncJobs(UpdateBatchAsyncJobsRequest updateBatchAsyncJobsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("async_job_id" , updateBatchAsyncJobsRequest.AsyncJobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/batch-async-jobs/{async_job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBatchAsyncJobsRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateBatchAsyncJobsResponse>(response);
        }
        
        /// <summary>
        /// 更新指定任务数据加工规则
        ///
        /// 更新指定任务数据加工规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDataProgressResponse UpdateDataProgress(UpdateDataProgressRequest updateDataProgressRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , updateDataProgressRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/data-processing-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDataProgressRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDataProgressResponse>(response);
        }
        
        /// <summary>
        /// 更新指定ID任务详情
        ///
        /// 更新租户指定ID任务详情。
        /// 当type取值为db_object， 进行异步处理。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateJobResponse UpdateJob(UpdateJobRequest updateJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , updateJobRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateJobRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateJobResponse>(response);
        }
        
        /// <summary>
        /// 更新增量任务启动位点
        ///
        /// 更新增量任务的启动位点。
        /// - 仅engine_type为mysql,mysql-to-dws,mysql-to-taurus,taurus,mysql-to-oracle,taurus-to-oracle,taurus-to-mysql,mysql-to-kafka,taurus-to-kafka,mongodb-to-kafka,mongodb且为单增量实时同步任务支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateStartPositionResponse UpdateStartPosition(UpdateStartPositionRequest updateStartPositionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , updateStartPositionRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/start-position",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateStartPositionRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateStartPositionResponse>(response);
        }
        
        /// <summary>
        /// 对象选择（文件导入 - 模板上传）
        ///
        /// 对象选择（文件导入 - 模板上传）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UploadDbObjectTemplateResponse UploadDbObjectTemplate(UploadDbObjectTemplateRequest uploadDbObjectTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , uploadDbObjectTemplateRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-object/template",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadDbObjectTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<UploadDbObjectTemplateResponse>(response);
        }
        
        /// <summary>
        /// 上传驱动文件
        ///
        /// 上传驱动文件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UploadJdbcDriverResponse UploadJdbcDriver(UploadJdbcDriverRequest uploadJdbcDriverRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jdbc-driver",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadJdbcDriverRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<UploadJdbcDriverResponse>(response);
        }
        
        /// <summary>
        /// 任务名称校验
        ///
        /// 创建任务时对任务名称进行校验。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ValidateJobNameResponse ValidateJobName(ValidateJobNameRequest validateJobNameRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/name-validation",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", validateJobNameRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ValidateJobNameResponse>(response);
        }
        
    }
}