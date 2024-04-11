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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/batch-async-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateJobsAsyncRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchCreateJobsAsyncResponse>(response);
        }

        public SyncInvoker<BatchCreateJobsAsyncResponse> BatchCreateJobsAsyncInvoker(BatchCreateJobsAsyncRequest batchCreateJobsAsyncRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/batch-async-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateJobsAsyncRequest);
            return new SyncInvoker<BatchCreateJobsAsyncResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreateJobsAsyncResponse>);
        }
        
        /// <summary>
        /// 批量添加资源标签
        ///
        /// 批量添加资源标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateTagsResponse BatchCreateTags(BatchCreateTagsRequest batchCreateTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", batchCreateTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id", batchCreateTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchCreateTagsResponse>(response);
        }

        public SyncInvoker<BatchCreateTagsResponse> BatchCreateTagsInvoker(BatchCreateTagsRequest batchCreateTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", batchCreateTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id", batchCreateTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateTagsRequest);
            return new SyncInvoker<BatchCreateTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreateTagsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteJobsByIdRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeleteJobsByIdResponse>(response);
        }

        public SyncInvoker<BatchDeleteJobsByIdResponse> BatchDeleteJobsByIdInvoker(BatchDeleteJobsByIdRequest batchDeleteJobsByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteJobsByIdRequest);
            return new SyncInvoker<BatchDeleteJobsByIdResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteJobsByIdResponse>);
        }
        
        /// <summary>
        /// 批量删除资源标签
        ///
        /// 为指定实例批量删除标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteTagsResponse BatchDeleteTags(BatchDeleteTagsRequest batchDeleteTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", batchDeleteTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id", batchDeleteTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteTagsResponse>(response);
        }

        public SyncInvoker<BatchDeleteTagsResponse> BatchDeleteTagsInvoker(BatchDeleteTagsRequest batchDeleteTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", batchDeleteTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id", batchDeleteTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteTagsRequest);
            return new SyncInvoker<BatchDeleteTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteTagsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchExecuteJobActionsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchExecuteJobActionsResponse>(response);
        }

        public SyncInvoker<BatchExecuteJobActionsResponse> BatchExecuteJobActionsInvoker(BatchExecuteJobActionsRequest batchExecuteJobActionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchExecuteJobActionsRequest);
            return new SyncInvoker<BatchExecuteJobActionsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchExecuteJobActionsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/batch-stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchStopJobsActionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchStopJobsActionResponse>(response);
        }

        public SyncInvoker<BatchStopJobsActionResponse> BatchStopJobsActionInvoker(BatchStopJobsActionRequest batchStopJobsActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/batch-stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchStopJobsActionRequest);
            return new SyncInvoker<BatchStopJobsActionResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchStopJobsActionResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", batchTagActionRequest.ResourceType.ToString());
            urlParam.Add("job_id", batchTagActionRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{resource_type}/{job_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchTagActionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchTagActionResponse>(response);
        }

        public SyncInvoker<BatchTagActionResponse> BatchTagActionInvoker(BatchTagActionRequest batchTagActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", batchTagActionRequest.ResourceType.ToString());
            urlParam.Add("job_id", batchTagActionRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{resource_type}/{job_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchTagActionRequest);
            return new SyncInvoker<BatchTagActionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchTagActionResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", checkDataFilterRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/job/{job_id}/data-filtering/check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkDataFilterRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CheckDataFilterResponse>(response);
        }

        public SyncInvoker<CheckDataFilterResponse> CheckDataFilterInvoker(CheckDataFilterRequest checkDataFilterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", checkDataFilterRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/job/{job_id}/data-filtering/check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkDataFilterRequest);
            return new SyncInvoker<CheckDataFilterResponse>(this, "POST", request, JsonUtils.DeSerialize<CheckDataFilterResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", collectColumnsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/job/{job_id}/columns/collect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectColumnsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CollectColumnsResponse>(response);
        }

        public SyncInvoker<CollectColumnsResponse> CollectColumnsInvoker(CollectColumnsRequest collectColumnsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", collectColumnsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/job/{job_id}/columns/collect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectColumnsRequest);
            return new SyncInvoker<CollectColumnsResponse>(this, "POST", request, JsonUtils.DeSerialize<CollectColumnsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", collectDbObjectsAsyncRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-objects/collect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectDbObjectsAsyncRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CollectDbObjectsAsyncResponse>(response);
        }

        public SyncInvoker<CollectDbObjectsAsyncResponse> CollectDbObjectsAsyncInvoker(CollectDbObjectsAsyncRequest collectDbObjectsAsyncRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", collectDbObjectsAsyncRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-objects/collect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectDbObjectsAsyncRequest);
            return new SyncInvoker<CollectDbObjectsAsyncResponse>(this, "POST", request, JsonUtils.DeSerialize<CollectDbObjectsAsyncResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", collectDbObjectsInfoRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5.1/{project_id}/jobs/{job_id}/db-objects/collect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectDbObjectsInfoRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CollectDbObjectsInfoResponse>(response);
        }

        public SyncInvoker<CollectDbObjectsInfoResponse> CollectDbObjectsInfoInvoker(CollectDbObjectsInfoRequest collectDbObjectsInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", collectDbObjectsInfoRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5.1/{project_id}/jobs/{job_id}/db-objects/collect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectDbObjectsInfoRequest);
            return new SyncInvoker<CollectDbObjectsInfoResponse>(this, "POST", request, JsonUtils.DeSerialize<CollectDbObjectsInfoResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", collectPositionAsyncRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/collect-db-position", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectPositionAsyncRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CollectPositionAsyncResponse>(response);
        }

        public SyncInvoker<CollectPositionAsyncResponse> CollectPositionAsyncInvoker(CollectPositionAsyncRequest collectPositionAsyncRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", collectPositionAsyncRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/collect-db-position", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectPositionAsyncRequest);
            return new SyncInvoker<CollectPositionAsyncResponse>(this, "POST", request, JsonUtils.DeSerialize<CollectPositionAsyncResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("async_job_id", commitAsyncJobRequest.AsyncJobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/batch-async-jobs/{async_job_id}/commit", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", commitAsyncJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CommitAsyncJobResponse>(response);
        }

        public SyncInvoker<CommitAsyncJobResponse> CommitAsyncJobInvoker(CommitAsyncJobRequest commitAsyncJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("async_job_id", commitAsyncJobRequest.AsyncJobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/batch-async-jobs/{async_job_id}/commit", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", commitAsyncJobRequest);
            return new SyncInvoker<CommitAsyncJobResponse>(this, "POST", request, JsonUtils.DeSerialize<CommitAsyncJobResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/clone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", copyJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CopyJobResponse>(response);
        }

        public SyncInvoker<CopyJobResponse> CopyJobInvoker(CopyJobRequest copyJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/clone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", copyJobRequest);
            return new SyncInvoker<CopyJobResponse>(this, "POST", request, JsonUtils.DeSerialize<CopyJobResponse>);
        }
        
        /// <summary>
        /// 查询资源实例数量
        ///
        /// 查询资源实例数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CountInstanceByTagsResponse CountInstanceByTags(CountInstanceByTagsRequest countInstanceByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", countInstanceByTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/{resource_type}/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countInstanceByTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CountInstanceByTagsResponse>(response);
        }

        public SyncInvoker<CountInstanceByTagsResponse> CountInstanceByTagsInvoker(CountInstanceByTagsRequest countInstanceByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", countInstanceByTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/{resource_type}/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countInstanceByTagsRequest);
            return new SyncInvoker<CountInstanceByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<CountInstanceByTagsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateJobResponse>(response);
        }

        public SyncInvoker<CreateJobResponse> CreateJobInvoker(CreateJobRequest createJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createJobRequest);
            return new SyncInvoker<CreateJobResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateJobResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jdbc-drivers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteJdbcDriverRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteJdbcDriverResponse>(response);
        }

        public SyncInvoker<DeleteJdbcDriverResponse> DeleteJdbcDriverInvoker(DeleteJdbcDriverRequest deleteJdbcDriverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jdbc-drivers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteJdbcDriverRequest);
            return new SyncInvoker<DeleteJdbcDriverResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteJdbcDriverResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", deleteJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteJobRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteJobResponse>(response);
        }

        public SyncInvoker<DeleteJobResponse> DeleteJobInvoker(DeleteJobRequest deleteJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", deleteJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteJobRequest);
            return new SyncInvoker<DeleteJobResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteJobResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadBatchCreateTemplateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DownloadBatchCreateTemplateResponse>(response);
        }

        public SyncInvoker<DownloadBatchCreateTemplateResponse> DownloadBatchCreateTemplateInvoker(DownloadBatchCreateTemplateRequest downloadBatchCreateTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadBatchCreateTemplateRequest);
            return new SyncInvoker<DownloadBatchCreateTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadBatchCreateTemplateResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", downloadDbObjectTemplateRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-object/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadDbObjectTemplateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<DownloadDbObjectTemplateResponse>(response);
        }

        public SyncInvoker<DownloadDbObjectTemplateResponse> DownloadDbObjectTemplateInvoker(DownloadDbObjectTemplateRequest downloadDbObjectTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", downloadDbObjectTemplateRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-object/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadDbObjectTemplateRequest);
            return new SyncInvoker<DownloadDbObjectTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadDbObjectTemplateResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", executeJobActionRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeJobActionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExecuteJobActionResponse>(response);
        }

        public SyncInvoker<ExecuteJobActionResponse> ExecuteJobActionInvoker(ExecuteJobActionRequest executeJobActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", executeJobActionRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeJobActionRequest);
            return new SyncInvoker<ExecuteJobActionResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteJobActionResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", exportOperationInfoRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/operation-statistics/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportOperationInfoRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ExportOperationInfoResponse>(response);
        }

        public SyncInvoker<ExportOperationInfoResponse> ExportOperationInfoInvoker(ExportOperationInfoRequest exportOperationInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", exportOperationInfoRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/operation-statistics/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportOperationInfoRequest);
            return new SyncInvoker<ExportOperationInfoResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ExportOperationInfoResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", importBatchCreateJobsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ImportBatchCreateJobsResponse>(response);
        }

        public SyncInvoker<ImportBatchCreateJobsResponse> ImportBatchCreateJobsInvoker(ImportBatchCreateJobsRequest importBatchCreateJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", importBatchCreateJobsRequest);
            return new SyncInvoker<ImportBatchCreateJobsResponse>(this, "POST", request, JsonUtils.DeSerialize<ImportBatchCreateJobsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("async_job_id", listAsyncJobDetailRequest.AsyncJobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/batch-async-jobs/{async_job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAsyncJobDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAsyncJobDetailResponse>(response);
        }

        public SyncInvoker<ListAsyncJobDetailResponse> ListAsyncJobDetailInvoker(ListAsyncJobDetailRequest listAsyncJobDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("async_job_id", listAsyncJobDetailRequest.AsyncJobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/batch-async-jobs/{async_job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAsyncJobDetailRequest);
            return new SyncInvoker<ListAsyncJobDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAsyncJobDetailResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/batch-async-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAsyncJobsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAsyncJobsResponse>(response);
        }

        public SyncInvoker<ListAsyncJobsResponse> ListAsyncJobsInvoker(ListAsyncJobsRequest listAsyncJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/batch-async-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAsyncJobsRequest);
            return new SyncInvoker<ListAsyncJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAsyncJobsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listDbObjectsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-objects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbObjectsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDbObjectsResponse>(response);
        }

        public SyncInvoker<ListDbObjectsResponse> ListDbObjectsInvoker(ListDbObjectsRequest listDbObjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listDbObjectsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-objects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbObjectsRequest);
            return new SyncInvoker<ListDbObjectsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDbObjectsResponse>);
        }
        
        /// <summary>
        /// 查询资源实例列表
        ///
        /// 查询资源实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceByTagsResponse ListInstanceByTags(ListInstanceByTagsRequest listInstanceByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listInstanceByTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/{resource_type}/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceByTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListInstanceByTagsResponse>(response);
        }

        public SyncInvoker<ListInstanceByTagsResponse> ListInstanceByTagsInvoker(ListInstanceByTagsRequest listInstanceByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listInstanceByTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/{resource_type}/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceByTagsRequest);
            return new SyncInvoker<ListInstanceByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListInstanceByTagsResponse>);
        }
        
        /// <summary>
        /// 查询资源标签
        ///
        /// 查询指定实例的标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListInstanceTagsResponse ListInstanceTags(ListInstanceTagsRequest listInstanceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listInstanceTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id", listInstanceTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceTagsResponse>(response);
        }

        public SyncInvoker<ListInstanceTagsResponse> ListInstanceTagsInvoker(ListInstanceTagsRequest listInstanceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listInstanceTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id", listInstanceTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceTagsRequest);
            return new SyncInvoker<ListInstanceTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceTagsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jdbc-drivers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJdbcDriversRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListJdbcDriversResponse>(response);
        }

        public SyncInvoker<ListJdbcDriversResponse> ListJdbcDriversInvoker(ListJdbcDriversRequest listJdbcDriversRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jdbc-drivers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJdbcDriversRequest);
            return new SyncInvoker<ListJdbcDriversResponse>(this, "GET", request, JsonUtils.DeSerialize<ListJdbcDriversResponse>);
        }
        
        /// <summary>
        /// 查询任务的参数配置修改历史
        ///
        /// 查询任务的参数配置修改历史
        /// - 仅engine_type为mysql、mysql-to-pgl、mysql-to-gaussdbv5、mysql-to-gaussdbv5ha、mysql-to-dws、mysql-to-taurus、mysql-to-kafka、mysql-to-elasticsearch、mysql-to-oracle且任务状态只能为配置中、全量中、增量中、全量失败、增量失败、暂停中的实时同步任务支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListJobHistoryParametersResponse ListJobHistoryParameters(ListJobHistoryParametersRequest listJobHistoryParametersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listJobHistoryParametersRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/configuration-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobHistoryParametersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListJobHistoryParametersResponse>(response);
        }

        public SyncInvoker<ListJobHistoryParametersResponse> ListJobHistoryParametersInvoker(ListJobHistoryParametersRequest listJobHistoryParametersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listJobHistoryParametersRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/configuration-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobHistoryParametersRequest);
            return new SyncInvoker<ListJobHistoryParametersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListJobHistoryParametersResponse>);
        }
        
        /// <summary>
        /// 查询任务参数配置列表
        ///
        /// 查询任务的参数配置列表信息
        /// - 仅engine_type为mysql、mysql-to-pgl、mysql-to-gaussdbv5、mysql-to-gaussdbv5ha、mysql-to-dws、mysql-to-taurus、mysql-to-kafka、mysql-to-elasticsearch、mysql-to-oracle且任务状态只能为配置中、全量中、增量中、全量失败、增量失败、暂停中的实时同步任务支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListJobParametersResponse ListJobParameters(ListJobParametersRequest listJobParametersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listJobParametersRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobParametersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListJobParametersResponse>(response);
        }

        public SyncInvoker<ListJobParametersResponse> ListJobParametersInvoker(ListJobParametersRequest listJobParametersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listJobParametersRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobParametersRequest);
            return new SyncInvoker<ListJobParametersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListJobParametersResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListJobsResponse>(response);
        }

        public SyncInvoker<ListJobsResponse> ListJobsInvoker(ListJobsRequest listJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobsRequest);
            return new SyncInvoker<ListJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListJobsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/links", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLinksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListLinksResponse>(response);
        }

        public SyncInvoker<ListLinksResponse> ListLinksInvoker(ListLinksRequest listLinksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/links", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLinksRequest);
            return new SyncInvoker<ListLinksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLinksResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listProjectTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListProjectTagsResponse>(response);
        }

        public SyncInvoker<ListProjectTagsResponse> ListProjectTagsInvoker(ListProjectTagsRequest listProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listProjectTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectTagsRequest);
            return new SyncInvoker<ListProjectTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProjectTagsResponse>);
        }
        
        /// <summary>
        /// 查询项目标签
        ///
        /// 查询租户在指定Project中实例类型的所有资源标签集合。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTagsResponse ListTags(ListTagsRequest listTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTagsResponse>(response);
        }

        public SyncInvoker<ListTagsResponse> ListTagsInvoker(ListTagsRequest listTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsRequest);
            return new SyncInvoker<ListTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTagsResponse>);
        }
        
        /// <summary>
        /// 查询委托的权限列表
        ///
        /// 根据源库类型，目标库类型，是否自建，获取委托所需要的权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListsAgencyPermissionsResponse ListsAgencyPermissions(ListsAgencyPermissionsRequest listsAgencyPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/agency/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listsAgencyPermissionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListsAgencyPermissionsResponse>(response);
        }

        public SyncInvoker<ListsAgencyPermissionsResponse> ListsAgencyPermissionsInvoker(ListsAgencyPermissionsRequest listsAgencyPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/agency/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listsAgencyPermissionsRequest);
            return new SyncInvoker<ListsAgencyPermissionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListsAgencyPermissionsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showActionsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showActionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowActionsResponse>(response);
        }

        public SyncInvoker<ShowActionsResponse> ShowActionsInvoker(ShowActionsRequest showActionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showActionsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showActionsRequest);
            return new SyncInvoker<ShowActionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowActionsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showColumnInfoResultRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/job/{job_id}/columns", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showColumnInfoResultRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowColumnInfoResultResponse>(response);
        }

        public SyncInvoker<ShowColumnInfoResultResponse> ShowColumnInfoResultInvoker(ShowColumnInfoResultRequest showColumnInfoResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showColumnInfoResultRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/job/{job_id}/columns", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showColumnInfoResultRequest);
            return new SyncInvoker<ShowColumnInfoResultResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowColumnInfoResultResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showComparePolicyRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/compare-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showComparePolicyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowComparePolicyResponse>(response);
        }

        public SyncInvoker<ShowComparePolicyResponse> ShowComparePolicyInvoker(ShowComparePolicyRequest showComparePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showComparePolicyRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/compare-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showComparePolicyRequest);
            return new SyncInvoker<ShowComparePolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowComparePolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDataFilteringResultRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/job/{job_id}/data-filtering/result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDataFilteringResultRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDataFilteringResultResponse>(response);
        }

        public SyncInvoker<ShowDataFilteringResultResponse> ShowDataFilteringResultInvoker(ShowDataFilteringResultRequest showDataFilteringResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDataFilteringResultRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/job/{job_id}/data-filtering/result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDataFilteringResultRequest);
            return new SyncInvoker<ShowDataFilteringResultResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDataFilteringResultResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDataProcessingRulesResultRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/data-processing-rules/result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDataProcessingRulesResultRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDataProcessingRulesResultResponse>(response);
        }

        public SyncInvoker<ShowDataProcessingRulesResultResponse> ShowDataProcessingRulesResultInvoker(ShowDataProcessingRulesResultRequest showDataProcessingRulesResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDataProcessingRulesResultRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/data-processing-rules/result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDataProcessingRulesResultRequest);
            return new SyncInvoker<ShowDataProcessingRulesResultResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDataProcessingRulesResultResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDataProgressRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/data-processing-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDataProgressRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDataProgressResponse>(response);
        }

        public SyncInvoker<ShowDataProgressResponse> ShowDataProgressInvoker(ShowDataProgressRequest showDataProgressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDataProgressRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/data-processing-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDataProgressRequest);
            return new SyncInvoker<ShowDataProgressResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDataProgressResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDbObjectCollectionStatusRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-objects/collection-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDbObjectCollectionStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDbObjectCollectionStatusResponse>(response);
        }

        public SyncInvoker<ShowDbObjectCollectionStatusResponse> ShowDbObjectCollectionStatusInvoker(ShowDbObjectCollectionStatusRequest showDbObjectCollectionStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDbObjectCollectionStatusRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-objects/collection-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDbObjectCollectionStatusRequest);
            return new SyncInvoker<ShowDbObjectCollectionStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDbObjectCollectionStatusResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDbObjectTemplateProgressRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-object/template/progress", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDbObjectTemplateProgressRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDbObjectTemplateProgressResponse>(response);
        }

        public SyncInvoker<ShowDbObjectTemplateProgressResponse> ShowDbObjectTemplateProgressInvoker(ShowDbObjectTemplateProgressRequest showDbObjectTemplateProgressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDbObjectTemplateProgressRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-object/template/progress", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDbObjectTemplateProgressRequest);
            return new SyncInvoker<ShowDbObjectTemplateProgressResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDbObjectTemplateProgressResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDbObjectTemplateResultRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-object/template/result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDbObjectTemplateResultRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDbObjectTemplateResultResponse>(response);
        }

        public SyncInvoker<ShowDbObjectTemplateResultResponse> ShowDbObjectTemplateResultInvoker(ShowDbObjectTemplateResultRequest showDbObjectTemplateResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDbObjectTemplateResultRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-object/template/result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDbObjectTemplateResultRequest);
            return new SyncInvoker<ShowDbObjectTemplateResultResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDbObjectTemplateResultResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDbObjectsListRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5.1/{project_id}/jobs/{job_id}/db-object", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDbObjectsListRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDbObjectsListResponse>(response);
        }

        public SyncInvoker<ShowDbObjectsListResponse> ShowDbObjectsListInvoker(ShowDbObjectsListRequest showDbObjectsListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDbObjectsListRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5.1/{project_id}/jobs/{job_id}/db-object", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDbObjectsListRequest);
            return new SyncInvoker<ShowDbObjectsListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDbObjectsListResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDirtyDataRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/dirty-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDirtyDataRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDirtyDataResponse>(response);
        }

        public SyncInvoker<ShowDirtyDataResponse> ShowDirtyDataInvoker(ShowDirtyDataRequest showDirtyDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDirtyDataRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/dirty-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDirtyDataRequest);
            return new SyncInvoker<ShowDirtyDataResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDirtyDataResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/enterprise-projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEnterpriseProjectRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowEnterpriseProjectResponse>(response);
        }

        public SyncInvoker<ShowEnterpriseProjectResponse> ShowEnterpriseProjectInvoker(ShowEnterpriseProjectRequest showEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/enterprise-projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEnterpriseProjectRequest);
            return new SyncInvoker<ShowEnterpriseProjectResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEnterpriseProjectResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showHealthCompareJobListRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/health-compare-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHealthCompareJobListRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowHealthCompareJobListResponse>(response);
        }

        public SyncInvoker<ShowHealthCompareJobListResponse> ShowHealthCompareJobListInvoker(ShowHealthCompareJobListRequest showHealthCompareJobListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showHealthCompareJobListRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/health-compare-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHealthCompareJobListRequest);
            return new SyncInvoker<ShowHealthCompareJobListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHealthCompareJobListResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showIncrementComponentsDetailRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/increment-components-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIncrementComponentsDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowIncrementComponentsDetailResponse>(response);
        }

        public SyncInvoker<ShowIncrementComponentsDetailResponse> ShowIncrementComponentsDetailInvoker(ShowIncrementComponentsDetailRequest showIncrementComponentsDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showIncrementComponentsDetailRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/increment-components-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIncrementComponentsDetailRequest);
            return new SyncInvoker<ShowIncrementComponentsDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowIncrementComponentsDetailResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", showInstanceTagsRequest.ResourceType.ToString());
            urlParam.Add("job_id", showInstanceTagsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{resource_type}/{job_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceTagsResponse>(response);
        }

        public SyncInvoker<ShowInstanceTagsResponse> ShowInstanceTagsInvoker(ShowInstanceTagsRequest showInstanceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", showInstanceTagsRequest.ResourceType.ToString());
            urlParam.Add("job_id", showInstanceTagsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{resource_type}/{job_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceTagsRequest);
            return new SyncInvoker<ShowInstanceTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceTagsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobDetailRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowJobDetailResponse>(response);
        }

        public SyncInvoker<ShowJobDetailResponse> ShowJobDetailInvoker(ShowJobDetailRequest showJobDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobDetailRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobDetailRequest);
            return new SyncInvoker<ShowJobDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobDetailResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showMeteringRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/metering", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMeteringRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMeteringResponse>(response);
        }

        public SyncInvoker<ShowMeteringResponse> ShowMeteringInvoker(ShowMeteringRequest showMeteringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showMeteringRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/metering", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMeteringRequest);
            return new SyncInvoker<ShowMeteringResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMeteringResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showMonitorDataRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/monitor-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMonitorDataRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowMonitorDataResponse>(response);
        }

        public SyncInvoker<ShowMonitorDataResponse> ShowMonitorDataInvoker(ShowMonitorDataRequest showMonitorDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showMonitorDataRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/monitor-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMonitorDataRequest);
            return new SyncInvoker<ShowMonitorDataResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMonitorDataResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showObjectMappingRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/object-mappings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showObjectMappingRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowObjectMappingResponse>(response);
        }

        public SyncInvoker<ShowObjectMappingResponse> ShowObjectMappingInvoker(ShowObjectMappingRequest showObjectMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showObjectMappingRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/object-mappings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showObjectMappingRequest);
            return new SyncInvoker<ShowObjectMappingResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowObjectMappingResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showPositionResultRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-position", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPositionResultRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPositionResultResponse>(response);
        }

        public SyncInvoker<ShowPositionResultResponse> ShowPositionResultInvoker(ShowPositionResultRequest showPositionResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showPositionResultRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-position", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPositionResultRequest);
            return new SyncInvoker<ShowPositionResultResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPositionResultResponse>);
        }
        
        /// <summary>
        /// 查询数据级流式对比列表
        ///
        /// 查询不同迁移对象类型的迁移进度。
        /// 说明：
        /// - 目前仅MySQL-&gt;MySQL、MySQL-&gt;GaussDB(for MySQL)、MongoDB-&gt;DDS、DDS-&gt;MongoDB的实时迁移和所有实时同步链路支持查看迁移明细。
        /// - 在任务未结束前，不能修改源库和目标库的所有用户、密码和用户权限等。
        /// - 全量、增量完成不代表任务结束，如果存在触发器和事件将会进行迁移。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowProgressDataResponse ShowProgressData(ShowProgressDataRequest showProgressDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showProgressDataRequest.JobId.ToString());
            urlParam.Add("type", showProgressDataRequest.Type.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/progress-data/{type}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProgressDataRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowProgressDataResponse>(response);
        }

        public SyncInvoker<ShowProgressDataResponse> ShowProgressDataInvoker(ShowProgressDataRequest showProgressDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showProgressDataRequest.JobId.ToString());
            urlParam.Add("type", showProgressDataRequest.Type.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/progress-data/{type}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProgressDataRequest);
            return new SyncInvoker<ShowProgressDataResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProgressDataResponse>);
        }
        
        /// <summary>
        /// 查询录制回放结果
        ///
        /// 获取录制回放结果数据，包括：回放基于时间维度统计信息，异常SQL及统计结果、慢SQL及统计结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowReplayResultsResponse ShowReplayResults(ShowReplayResultsRequest showReplayResultsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showReplayResultsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/replay-results", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReplayResultsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowReplayResultsResponse>(response);
        }

        public SyncInvoker<ShowReplayResultsResponse> ShowReplayResultsInvoker(ShowReplayResultsRequest showReplayResultsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showReplayResultsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/replay-results", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReplayResultsRequest);
            return new SyncInvoker<ShowReplayResultsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowReplayResultsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showSupportObjectTypeRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/object/support", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSupportObjectTypeRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowSupportObjectTypeResponse>(response);
        }

        public SyncInvoker<ShowSupportObjectTypeResponse> ShowSupportObjectTypeInvoker(ShowSupportObjectTypeRequest showSupportObjectTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showSupportObjectTypeRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/object/support", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSupportObjectTypeRequest);
            return new SyncInvoker<ShowSupportObjectTypeResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSupportObjectTypeResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showUpdateObjectSavingStatusRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-objects/saving-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpdateObjectSavingStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowUpdateObjectSavingStatusResponse>(response);
        }

        public SyncInvoker<ShowUpdateObjectSavingStatusResponse> ShowUpdateObjectSavingStatusInvoker(ShowUpdateObjectSavingStatusRequest showUpdateObjectSavingStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showUpdateObjectSavingStatusRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-objects/saving-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpdateObjectSavingStatusRequest);
            return new SyncInvoker<ShowUpdateObjectSavingStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUpdateObjectSavingStatusResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", stopJobActionRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopJobActionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StopJobActionResponse>(response);
        }

        public SyncInvoker<StopJobActionResponse> StopJobActionInvoker(StopJobActionRequest stopJobActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", stopJobActionRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopJobActionRequest);
            return new SyncInvoker<StopJobActionResponse>(this, "POST", request, JsonUtils.DeSerialize<StopJobActionResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", syncJdbcDriverRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/update-jdbc-driver", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", syncJdbcDriverRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<SyncJdbcDriverResponse>(response);
        }

        public SyncInvoker<SyncJdbcDriverResponse> SyncJdbcDriverInvoker(SyncJdbcDriverRequest syncJdbcDriverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", syncJdbcDriverRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/update-jdbc-driver", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", syncJdbcDriverRequest);
            return new SyncInvoker<SyncJdbcDriverResponse>(this, "PUT", request, JsonUtils.DeSerialize<SyncJdbcDriverResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("async_job_id", updateBatchAsyncJobsRequest.AsyncJobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/batch-async-jobs/{async_job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBatchAsyncJobsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateBatchAsyncJobsResponse>(response);
        }

        public SyncInvoker<UpdateBatchAsyncJobsResponse> UpdateBatchAsyncJobsInvoker(UpdateBatchAsyncJobsRequest updateBatchAsyncJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("async_job_id", updateBatchAsyncJobsRequest.AsyncJobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/batch-async-jobs/{async_job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBatchAsyncJobsRequest);
            return new SyncInvoker<UpdateBatchAsyncJobsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateBatchAsyncJobsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", updateDataProgressRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/data-processing-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDataProgressRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDataProgressResponse>(response);
        }

        public SyncInvoker<UpdateDataProgressResponse> UpdateDataProgressInvoker(UpdateDataProgressRequest updateDataProgressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", updateDataProgressRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/data-processing-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDataProgressRequest);
            return new SyncInvoker<UpdateDataProgressResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDataProgressResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", updateJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateJobRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateJobResponse>(response);
        }

        public SyncInvoker<UpdateJobResponse> UpdateJobInvoker(UpdateJobRequest updateJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", updateJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateJobRequest);
            return new SyncInvoker<UpdateJobResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateJobResponse>);
        }
        
        /// <summary>
        /// 更新任务的参数信息
        ///
        /// 更新任务的参数信息。
        /// - 仅engine_type为mysql、mysql-to-pgl、mysql-to-gaussdbv5、mysql-to-gaussdbv5ha、mysql-to-dws、mysql-to-taurus、mysql-to-kafka、mysql-to-elasticsearch、mysql-to-oracle且任务状态只能为配置中、全量中、增量中、全量失败、增量失败、暂停中的实时同步任务支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateJobConfigurationsResponse UpdateJobConfigurations(UpdateJobConfigurationsRequest updateJobConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", updateJobConfigurationsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/modify-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateJobConfigurationsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateJobConfigurationsResponse>(response);
        }

        public SyncInvoker<UpdateJobConfigurationsResponse> UpdateJobConfigurationsInvoker(UpdateJobConfigurationsRequest updateJobConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", updateJobConfigurationsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/modify-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateJobConfigurationsRequest);
            return new SyncInvoker<UpdateJobConfigurationsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateJobConfigurationsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", updateStartPositionRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/start-position", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateStartPositionRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateStartPositionResponse>(response);
        }

        public SyncInvoker<UpdateStartPositionResponse> UpdateStartPositionInvoker(UpdateStartPositionRequest updateStartPositionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", updateStartPositionRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/start-position", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateStartPositionRequest);
            return new SyncInvoker<UpdateStartPositionResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateStartPositionResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", uploadDbObjectTemplateRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-object/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadDbObjectTemplateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UploadDbObjectTemplateResponse>(response);
        }

        public SyncInvoker<UploadDbObjectTemplateResponse> UploadDbObjectTemplateInvoker(UploadDbObjectTemplateRequest uploadDbObjectTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", uploadDbObjectTemplateRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-object/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadDbObjectTemplateRequest);
            return new SyncInvoker<UploadDbObjectTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<UploadDbObjectTemplateResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jdbc-driver", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadJdbcDriverRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UploadJdbcDriverResponse>(response);
        }

        public SyncInvoker<UploadJdbcDriverResponse> UploadJdbcDriverInvoker(UploadJdbcDriverRequest uploadJdbcDriverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jdbc-driver", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadJdbcDriverRequest);
            return new SyncInvoker<UploadJdbcDriverResponse>(this, "POST", request, JsonUtils.DeSerialize<UploadJdbcDriverResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/name-validation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", validateJobNameRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ValidateJobNameResponse>(response);
        }

        public SyncInvoker<ValidateJobNameResponse> ValidateJobNameInvoker(ValidateJobNameRequest validateJobNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/name-validation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", validateJobNameRequest);
            return new SyncInvoker<ValidateJobNameResponse>(this, "POST", request, JsonUtils.DeSerialize<ValidateJobNameResponse>);
        }
        
    }
}