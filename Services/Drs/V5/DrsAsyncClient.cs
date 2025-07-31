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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/batch-async-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateJobsAsyncRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchCreateJobsAsyncResponse>(response);
        }

        public AsyncInvoker<BatchCreateJobsAsyncResponse> BatchCreateJobsAsyncAsyncInvoker(BatchCreateJobsAsyncRequest batchCreateJobsAsyncRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/batch-async-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateJobsAsyncRequest);
            return new AsyncInvoker<BatchCreateJobsAsyncResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreateJobsAsyncResponse>);
        }
        
        /// <summary>
        /// 批量添加资源标签
        ///
        /// 批量添加资源标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateTagsResponse> BatchCreateTagsAsync(BatchCreateTagsRequest batchCreateTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", batchCreateTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id", batchCreateTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchCreateTagsResponse>(response);
        }

        public AsyncInvoker<BatchCreateTagsResponse> BatchCreateTagsAsyncInvoker(BatchCreateTagsRequest batchCreateTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", batchCreateTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id", batchCreateTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateTagsRequest);
            return new AsyncInvoker<BatchCreateTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreateTagsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteJobsByIdRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeleteJobsByIdResponse>(response);
        }

        public AsyncInvoker<BatchDeleteJobsByIdResponse> BatchDeleteJobsByIdAsyncInvoker(BatchDeleteJobsByIdRequest batchDeleteJobsByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteJobsByIdRequest);
            return new AsyncInvoker<BatchDeleteJobsByIdResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteJobsByIdResponse>);
        }
        
        /// <summary>
        /// 批量删除资源标签
        ///
        /// 为指定实例批量删除标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteTagsResponse> BatchDeleteTagsAsync(BatchDeleteTagsRequest batchDeleteTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", batchDeleteTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id", batchDeleteTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchDeleteTagsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteTagsResponse> BatchDeleteTagsAsyncInvoker(BatchDeleteTagsRequest batchDeleteTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", batchDeleteTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id", batchDeleteTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteTagsRequest);
            return new AsyncInvoker<BatchDeleteTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchDeleteTagsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchExecuteJobActionsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchExecuteJobActionsResponse>(response);
        }

        public AsyncInvoker<BatchExecuteJobActionsResponse> BatchExecuteJobActionsAsyncInvoker(BatchExecuteJobActionsRequest batchExecuteJobActionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchExecuteJobActionsRequest);
            return new AsyncInvoker<BatchExecuteJobActionsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchExecuteJobActionsResponse>);
        }
        
        /// <summary>
        /// 批量结束任务
        ///
        /// 批量结束租户指定ID任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchStopJobsActionResponse> BatchStopJobsActionAsync(BatchStopJobsActionRequest batchStopJobsActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/batch-stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchStopJobsActionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchStopJobsActionResponse>(response);
        }

        public AsyncInvoker<BatchStopJobsActionResponse> BatchStopJobsActionAsyncInvoker(BatchStopJobsActionRequest batchStopJobsActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/batch-stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchStopJobsActionRequest);
            return new AsyncInvoker<BatchStopJobsActionResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchStopJobsActionResponse>);
        }
        
        /// <summary>
        /// 批量添加或删除资源标签
        ///
        /// 批量添加删除资源标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<BatchTagActionResponse> BatchTagActionAsync(BatchTagActionRequest batchTagActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", batchTagActionRequest.ResourceType.ToString());
            urlParam.Add("job_id", batchTagActionRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{resource_type}/{job_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchTagActionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchTagActionResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<BatchTagActionResponse> BatchTagActionAsyncInvoker(BatchTagActionRequest batchTagActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", batchTagActionRequest.ResourceType.ToString());
            urlParam.Add("job_id", batchTagActionRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{resource_type}/{job_id}/tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchTagActionRequest);
            return new AsyncInvoker<BatchTagActionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchTagActionResponse>);
        }
        
        /// <summary>
        /// 按需转包周期
        ///
        /// DRS同步和灾备任务按需计费转包周期计费。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeToPeriodResponse> ChangeToPeriodAsync(ChangeToPeriodRequest changeToPeriodRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", changeToPeriodRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/job/{job_id}/change-to-period", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeToPeriodRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ChangeToPeriodResponse>(response);
        }

        public AsyncInvoker<ChangeToPeriodResponse> ChangeToPeriodAsyncInvoker(ChangeToPeriodRequest changeToPeriodRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", changeToPeriodRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/job/{job_id}/change-to-period", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", changeToPeriodRequest);
            return new AsyncInvoker<ChangeToPeriodResponse>(this, "POST", request, JsonUtils.DeSerialize<ChangeToPeriodResponse>);
        }
        
        /// <summary>
        /// 数据过滤规则校验
        ///
        /// 数据过滤规则校验
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckDataFilterResponse> CheckDataFilterAsync(CheckDataFilterRequest checkDataFilterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", checkDataFilterRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/job/{job_id}/data-filtering/check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkDataFilterRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CheckDataFilterResponse>(response);
        }

        public AsyncInvoker<CheckDataFilterResponse> CheckDataFilterAsyncInvoker(CheckDataFilterRequest checkDataFilterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", checkDataFilterRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/job/{job_id}/data-filtering/check", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkDataFilterRequest);
            return new AsyncInvoker<CheckDataFilterResponse>(this, "POST", request, JsonUtils.DeSerialize<CheckDataFilterResponse>);
        }
        
        /// <summary>
        /// 清除DDL告警
        ///
        /// 清除DDL告警
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CleanAlarmsResponse> CleanAlarmsAsync(CleanAlarmsRequest cleanAlarmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", cleanAlarmsRequest.JobId.ToString());
            urlParam.Add("alarm_id", cleanAlarmsRequest.AlarmId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/alarms/{alarm_id}/clean", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cleanAlarmsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CleanAlarmsResponse>(response);
        }

        public AsyncInvoker<CleanAlarmsResponse> CleanAlarmsAsyncInvoker(CleanAlarmsRequest cleanAlarmsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", cleanAlarmsRequest.JobId.ToString());
            urlParam.Add("alarm_id", cleanAlarmsRequest.AlarmId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/alarms/{alarm_id}/clean", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cleanAlarmsRequest);
            return new AsyncInvoker<CleanAlarmsResponse>(this, "POST", request, JsonUtils.DeSerialize<CleanAlarmsResponse>);
        }
        
        /// <summary>
        /// 采集指定数据库表的列信息
        ///
        /// 采集指定数据库表的列信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CollectColumnsResponse> CollectColumnsAsync(CollectColumnsRequest collectColumnsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", collectColumnsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/job/{job_id}/columns/collect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectColumnsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CollectColumnsResponse>(response);
        }

        public AsyncInvoker<CollectColumnsResponse> CollectColumnsAsyncInvoker(CollectColumnsRequest collectColumnsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", collectColumnsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/job/{job_id}/columns/collect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectColumnsRequest);
            return new AsyncInvoker<CollectColumnsResponse>(this, "POST", request, JsonUtils.DeSerialize<CollectColumnsResponse>);
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
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<CollectDbObjectsAsyncResponse> CollectDbObjectsAsyncAsync(CollectDbObjectsAsyncRequest collectDbObjectsAsyncRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", collectDbObjectsAsyncRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-objects/collect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectDbObjectsAsyncRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CollectDbObjectsAsyncResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<CollectDbObjectsAsyncResponse> CollectDbObjectsAsyncAsyncInvoker(CollectDbObjectsAsyncRequest collectDbObjectsAsyncRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", collectDbObjectsAsyncRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-objects/collect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectDbObjectsAsyncRequest);
            return new AsyncInvoker<CollectDbObjectsAsyncResponse>(this, "POST", request, JsonUtils.DeSerialize<CollectDbObjectsAsyncResponse>);
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
        public async Task<CollectDbObjectsInfoResponse> CollectDbObjectsInfoAsync(CollectDbObjectsInfoRequest collectDbObjectsInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", collectDbObjectsInfoRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5.1/{project_id}/jobs/{job_id}/db-objects/collect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectDbObjectsInfoRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CollectDbObjectsInfoResponse>(response);
        }

        public AsyncInvoker<CollectDbObjectsInfoResponse> CollectDbObjectsInfoAsyncInvoker(CollectDbObjectsInfoRequest collectDbObjectsInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", collectDbObjectsInfoRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5.1/{project_id}/jobs/{job_id}/db-objects/collect", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectDbObjectsInfoRequest);
            return new AsyncInvoker<CollectDbObjectsInfoResponse>(this, "POST", request, JsonUtils.DeSerialize<CollectDbObjectsInfoResponse>);
        }
        
        /// <summary>
        /// 采集数据库位点信息
        ///
        /// 采集数据库位点信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CollectPositionAsyncResponse> CollectPositionAsyncAsync(CollectPositionAsyncRequest collectPositionAsyncRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", collectPositionAsyncRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/collect-db-position", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectPositionAsyncRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CollectPositionAsyncResponse>(response);
        }

        public AsyncInvoker<CollectPositionAsyncResponse> CollectPositionAsyncAsyncInvoker(CollectPositionAsyncRequest collectPositionAsyncRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", collectPositionAsyncRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/collect-db-position", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", collectPositionAsyncRequest);
            return new AsyncInvoker<CollectPositionAsyncResponse>(this, "POST", request, JsonUtils.DeSerialize<CollectPositionAsyncResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("async_job_id", commitAsyncJobRequest.AsyncJobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/batch-async-jobs/{async_job_id}/commit", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", commitAsyncJobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CommitAsyncJobResponse>(response);
        }

        public AsyncInvoker<CommitAsyncJobResponse> CommitAsyncJobAsyncInvoker(CommitAsyncJobRequest commitAsyncJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("async_job_id", commitAsyncJobRequest.AsyncJobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/batch-async-jobs/{async_job_id}/commit", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", commitAsyncJobRequest);
            return new AsyncInvoker<CommitAsyncJobResponse>(this, "POST", request, JsonUtils.DeSerialize<CommitAsyncJobResponse>);
        }
        
        /// <summary>
        /// 克隆任务
        ///
        /// DRS支持通过克隆功能，快速复制现有同步任务的配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CopyJobResponse> CopyJobAsync(CopyJobRequest copyJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/clone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", copyJobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CopyJobResponse>(response);
        }

        public AsyncInvoker<CopyJobResponse> CopyJobAsyncInvoker(CopyJobRequest copyJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/clone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", copyJobRequest);
            return new AsyncInvoker<CopyJobResponse>(this, "POST", request, JsonUtils.DeSerialize<CopyJobResponse>);
        }
        
        /// <summary>
        /// 查询资源实例数量
        ///
        /// 查询资源实例数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CountInstanceByTagsResponse> CountInstanceByTagsAsync(CountInstanceByTagsRequest countInstanceByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", countInstanceByTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/{resource_type}/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countInstanceByTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CountInstanceByTagsResponse>(response);
        }

        public AsyncInvoker<CountInstanceByTagsResponse> CountInstanceByTagsAsyncInvoker(CountInstanceByTagsRequest countInstanceByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", countInstanceByTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/{resource_type}/resource-instances/count", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", countInstanceByTagsRequest);
            return new AsyncInvoker<CountInstanceByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<CountInstanceByTagsResponse>);
        }
        
        /// <summary>
        /// 创建连接
        ///
        /// 创建单个连接，该连接可以为线下自建库或云上RDS等，目前支持的数据库引擎包括MySQL、PostgreSQL、Oracle和MongoDB。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateConnectionResponse> CreateConnectionAsync(CreateConnectionRequest createConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/connections", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConnectionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateConnectionResponse>(response);
        }

        public AsyncInvoker<CreateConnectionResponse> CreateConnectionAsyncInvoker(CreateConnectionRequest createConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/connections", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createConnectionRequest);
            return new AsyncInvoker<CreateConnectionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateConnectionResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createJobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateJobResponse>(response);
        }

        public AsyncInvoker<CreateJobResponse> CreateJobAsyncInvoker(CreateJobRequest createJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createJobRequest);
            return new AsyncInvoker<CreateJobResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateJobResponse>);
        }
        
        /// <summary>
        /// 创建备份迁移任务
        ///
        /// 该接口主要用于三种常见场景下备份迁移任务的配置。
        /// 备份迁移支持如下的常见场景：
        /// - 通过OBS桶备份文件进行全量数据迁移。
        /// - 通过OBS桶备份文件进行全量+增量数据迁移。
        /// - 通过RDS全量备份进行全量数据迁移。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateReplicationJobResponse> CreateReplicationJobAsync(CreateReplicationJobRequest createReplicationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/backup-migration-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createReplicationJobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateReplicationJobResponse>(response);
        }

        public AsyncInvoker<CreateReplicationJobResponse> CreateReplicationJobAsyncInvoker(CreateReplicationJobRequest createReplicationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/backup-migration-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createReplicationJobRequest);
            return new AsyncInvoker<CreateReplicationJobResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateReplicationJobResponse>);
        }
        
        /// <summary>
        /// 删除连接
        ///
        /// 删除租户指定的连接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteConnectionResponse> DeleteConnectionAsync(DeleteConnectionRequest deleteConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("connection_id", deleteConnectionRequest.ConnectionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/connections/{connection_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConnectionRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteConnectionResponse>(response);
        }

        public AsyncInvoker<DeleteConnectionResponse> DeleteConnectionAsyncInvoker(DeleteConnectionRequest deleteConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("connection_id", deleteConnectionRequest.ConnectionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/connections/{connection_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteConnectionRequest);
            return new AsyncInvoker<DeleteConnectionResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteConnectionResponse>);
        }
        
        /// <summary>
        /// 删除驱动文件（不再推广）
        ///
        /// 删除驱动文件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteJdbcDriverResponse> DeleteJdbcDriverAsync(DeleteJdbcDriverRequest deleteJdbcDriverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jdbc-drivers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteJdbcDriverRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteJdbcDriverResponse>(response);
        }

        public AsyncInvoker<DeleteJdbcDriverResponse> DeleteJdbcDriverAsyncInvoker(DeleteJdbcDriverRequest deleteJdbcDriverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jdbc-drivers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteJdbcDriverRequest);
            return new AsyncInvoker<DeleteJdbcDriverResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteJdbcDriverResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", deleteJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteJobRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteJobResponse>(response);
        }

        public AsyncInvoker<DeleteJobResponse> DeleteJobAsyncInvoker(DeleteJobRequest deleteJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", deleteJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteJobRequest);
            return new AsyncInvoker<DeleteJobResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteJobResponse>);
        }
        
        /// <summary>
        /// 删除备份迁移任务
        ///
        /// 对于已经完成的备份迁移任务，可以选择删除迁移任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteReplicationJobResponse> DeleteReplicationJobAsync(DeleteReplicationJobRequest deleteReplicationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", deleteReplicationJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/backup-migration-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteReplicationJobRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteReplicationJobResponse>(response);
        }

        public AsyncInvoker<DeleteReplicationJobResponse> DeleteReplicationJobAsyncInvoker(DeleteReplicationJobRequest deleteReplicationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", deleteReplicationJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/backup-migration-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteReplicationJobRequest);
            return new AsyncInvoker<DeleteReplicationJobResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteReplicationJobResponse>);
        }
        
        /// <summary>
        /// 删除驱动文件
        ///
        /// 删除驱动文件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteUserJdbcDriverResponse> DeleteUserJdbcDriverAsync(DeleteUserJdbcDriverRequest deleteUserJdbcDriverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/drivers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserJdbcDriverRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteUserJdbcDriverResponse>(response);
        }

        public AsyncInvoker<DeleteUserJdbcDriverResponse> DeleteUserJdbcDriverAsyncInvoker(DeleteUserJdbcDriverRequest deleteUserJdbcDriverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/drivers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteUserJdbcDriverRequest);
            return new AsyncInvoker<DeleteUserJdbcDriverResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteUserJdbcDriverResponse>);
        }
        
        /// <summary>
        /// 下载批量导入任务模板
        ///
        /// 下载批量导入任务模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DownloadBatchCreateTemplateResponse> DownloadBatchCreateTemplateAsync(DownloadBatchCreateTemplateRequest downloadBatchCreateTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadBatchCreateTemplateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<DownloadBatchCreateTemplateResponse>(response);
        }

        public AsyncInvoker<DownloadBatchCreateTemplateResponse> DownloadBatchCreateTemplateAsyncInvoker(DownloadBatchCreateTemplateRequest downloadBatchCreateTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadBatchCreateTemplateRequest);
            return new AsyncInvoker<DownloadBatchCreateTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadBatchCreateTemplateResponse>);
        }
        
        /// <summary>
        /// 下载创建模板
        ///
        /// 下载根据已有任务导出的创建模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DownloadCreateTemplateResponse> DownloadCreateTemplateAsync(DownloadCreateTemplateRequest downloadCreateTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/templates/download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadCreateTemplateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DownloadCreateTemplateResponse>(response);
        }

        public AsyncInvoker<DownloadCreateTemplateResponse> DownloadCreateTemplateAsyncInvoker(DownloadCreateTemplateRequest downloadCreateTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/templates/download", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadCreateTemplateRequest);
            return new AsyncInvoker<DownloadCreateTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<DownloadCreateTemplateResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", downloadDbObjectTemplateRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-object/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadDbObjectTemplateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<DownloadDbObjectTemplateResponse>(response);
        }

        public AsyncInvoker<DownloadDbObjectTemplateResponse> DownloadDbObjectTemplateAsyncInvoker(DownloadDbObjectTemplateRequest downloadDbObjectTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", downloadDbObjectTemplateRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-object/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadDbObjectTemplateRequest);
            return new AsyncInvoker<DownloadDbObjectTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadDbObjectTemplateResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", executeJobActionRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeJobActionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExecuteJobActionResponse>(response);
        }

        public AsyncInvoker<ExecuteJobActionResponse> ExecuteJobActionAsyncInvoker(ExecuteJobActionRequest executeJobActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", executeJobActionRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeJobActionRequest);
            return new AsyncInvoker<ExecuteJobActionResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteJobActionResponse>);
        }
        
        /// <summary>
        /// 导出创建模板
        ///
        /// 根据已有任务导出创建模板。（异步操作，需要调查询导出进度接口查询结果。）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExportCreationTemplateResponse> ExportCreationTemplateAsync(ExportCreationTemplateRequest exportCreationTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/export/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportCreationTemplateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ExportCreationTemplateResponse>(response);
        }

        public AsyncInvoker<ExportCreationTemplateResponse> ExportCreationTemplateAsyncInvoker(ExportCreationTemplateRequest exportCreationTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/export/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportCreationTemplateRequest);
            return new AsyncInvoker<ExportCreationTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<ExportCreationTemplateResponse>);
        }
        
        /// <summary>
        /// 导出任务操作统计信息
        ///
        /// 导出指定任务操作统计信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExportOperationInfoResponse> ExportOperationInfoAsync(ExportOperationInfoRequest exportOperationInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", exportOperationInfoRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/operation-statistics/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportOperationInfoRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ExportOperationInfoResponse>(response);
        }

        public AsyncInvoker<ExportOperationInfoResponse> ExportOperationInfoAsyncInvoker(ExportOperationInfoRequest exportOperationInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", exportOperationInfoRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/operation-statistics/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportOperationInfoRequest);
            return new AsyncInvoker<ExportOperationInfoResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ExportOperationInfoResponse>);
        }
        
        /// <summary>
        /// 批量导入任务
        ///
        /// 批量导入任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ImportBatchCreateJobsResponse> ImportBatchCreateJobsAsync(ImportBatchCreateJobsRequest importBatchCreateJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", importBatchCreateJobsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ImportBatchCreateJobsResponse>(response);
        }

        public AsyncInvoker<ImportBatchCreateJobsResponse> ImportBatchCreateJobsAsyncInvoker(ImportBatchCreateJobsRequest importBatchCreateJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", importBatchCreateJobsRequest);
            return new AsyncInvoker<ImportBatchCreateJobsResponse>(this, "POST", request, JsonUtils.DeSerialize<ImportBatchCreateJobsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("async_job_id", listAsyncJobDetailRequest.AsyncJobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/batch-async-jobs/{async_job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAsyncJobDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAsyncJobDetailResponse>(response);
        }

        public AsyncInvoker<ListAsyncJobDetailResponse> ListAsyncJobDetailAsyncInvoker(ListAsyncJobDetailRequest listAsyncJobDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("async_job_id", listAsyncJobDetailRequest.AsyncJobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/batch-async-jobs/{async_job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAsyncJobDetailRequest);
            return new AsyncInvoker<ListAsyncJobDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAsyncJobDetailResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/batch-async-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAsyncJobsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAsyncJobsResponse>(response);
        }

        public AsyncInvoker<ListAsyncJobsResponse> ListAsyncJobsAsyncInvoker(ListAsyncJobsRequest listAsyncJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/batch-async-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAsyncJobsRequest);
            return new AsyncInvoker<ListAsyncJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAsyncJobsResponse>);
        }
        
        /// <summary>
        /// 查询连接列表
        ///
        /// 查询连接列表，可根据连接类型进行查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListConnectionsResponse> ListConnectionsAsync(ListConnectionsRequest listConnectionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/connections", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConnectionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListConnectionsResponse>(response);
        }

        public AsyncInvoker<ListConnectionsResponse> ListConnectionsAsyncInvoker(ListConnectionsRequest listConnectionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/connections", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listConnectionsRequest);
            return new AsyncInvoker<ListConnectionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListConnectionsResponse>);
        }
        
        /// <summary>
        /// 查询数据库对象信息
        ///
        /// 查询数据库对象信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<ListDbObjectsResponse> ListDbObjectsAsync(ListDbObjectsRequest listDbObjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listDbObjectsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-objects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbObjectsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDbObjectsResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<ListDbObjectsResponse> ListDbObjectsAsyncInvoker(ListDbObjectsRequest listDbObjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listDbObjectsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-objects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDbObjectsRequest);
            return new AsyncInvoker<ListDbObjectsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDbObjectsResponse>);
        }
        
        /// <summary>
        /// 查询资源实例列表
        ///
        /// 查询资源实例列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceByTagsResponse> ListInstanceByTagsAsync(ListInstanceByTagsRequest listInstanceByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listInstanceByTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/{resource_type}/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceByTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListInstanceByTagsResponse>(response);
        }

        public AsyncInvoker<ListInstanceByTagsResponse> ListInstanceByTagsAsyncInvoker(ListInstanceByTagsRequest listInstanceByTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listInstanceByTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/{resource_type}/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceByTagsRequest);
            return new AsyncInvoker<ListInstanceByTagsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListInstanceByTagsResponse>);
        }
        
        /// <summary>
        /// 查询资源标签
        ///
        /// 查询指定实例的标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListInstanceTagsResponse> ListInstanceTagsAsync(ListInstanceTagsRequest listInstanceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listInstanceTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id", listInstanceTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListInstanceTagsResponse>(response);
        }

        public AsyncInvoker<ListInstanceTagsResponse> ListInstanceTagsAsyncInvoker(ListInstanceTagsRequest listInstanceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listInstanceTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id", listInstanceTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listInstanceTagsRequest);
            return new AsyncInvoker<ListInstanceTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListInstanceTagsResponse>);
        }
        
        /// <summary>
        /// 查询驱动文件列表（不再推广）
        ///
        /// 查询驱动文件列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListJdbcDriversResponse> ListJdbcDriversAsync(ListJdbcDriversRequest listJdbcDriversRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jdbc-drivers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJdbcDriversRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListJdbcDriversResponse>(response);
        }

        public AsyncInvoker<ListJdbcDriversResponse> ListJdbcDriversAsyncInvoker(ListJdbcDriversRequest listJdbcDriversRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jdbc-drivers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJdbcDriversRequest);
            return new AsyncInvoker<ListJdbcDriversResponse>(this, "GET", request, JsonUtils.DeSerialize<ListJdbcDriversResponse>);
        }
        
        /// <summary>
        /// 查询增量DDL列表
        ///
        /// 查询增量DDL列表，可根据status查询
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListJobDdlsResponse> ListJobDdlsAsync(ListJobDdlsRequest listJobDdlsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listJobDdlsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/ddl", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobDdlsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListJobDdlsResponse>(response);
        }

        public AsyncInvoker<ListJobDdlsResponse> ListJobDdlsAsyncInvoker(ListJobDdlsRequest listJobDdlsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listJobDdlsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/ddl", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobDdlsRequest);
            return new AsyncInvoker<ListJobDdlsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListJobDdlsResponse>);
        }
        
        /// <summary>
        /// 查询任务的参数配置修改历史
        ///
        /// 查询任务的参数配置修改历史
        /// - 仅engine_type为mysql、mysql-to-pgl、mysql-to-gaussdbv5、mysql-to-gaussdbv5ha、mysql-to-dws、mysql-to-taurus、mysql-to-kafka、mysql-to-elasticsearch、mysql-to-oracle且任务状态只能为配置中、全量中、增量中、全量失败、增量失败、暂停中的实时同步任务支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListJobHistoryParametersResponse> ListJobHistoryParametersAsync(ListJobHistoryParametersRequest listJobHistoryParametersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listJobHistoryParametersRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/configuration-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobHistoryParametersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListJobHistoryParametersResponse>(response);
        }

        public AsyncInvoker<ListJobHistoryParametersResponse> ListJobHistoryParametersAsyncInvoker(ListJobHistoryParametersRequest listJobHistoryParametersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listJobHistoryParametersRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/configuration-histories", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobHistoryParametersRequest);
            return new AsyncInvoker<ListJobHistoryParametersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListJobHistoryParametersResponse>);
        }
        
        /// <summary>
        /// 查询任务参数配置列表
        ///
        /// 查询任务的参数配置列表信息
        /// - 仅engine_type为mysql、mysql-to-pgl、mysql-to-gaussdbv5、mysql-to-gaussdbv5ha、mysql-to-dws、mysql-to-taurus、mysql-to-kafka、mysql-to-elasticsearch、mysql-to-oracle且任务状态只能为配置中、全量中、增量中、全量失败、增量失败、暂停中的实时同步任务支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListJobParametersResponse> ListJobParametersAsync(ListJobParametersRequest listJobParametersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listJobParametersRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobParametersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListJobParametersResponse>(response);
        }

        public AsyncInvoker<ListJobParametersResponse> ListJobParametersAsyncInvoker(ListJobParametersRequest listJobParametersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listJobParametersRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobParametersRequest);
            return new AsyncInvoker<ListJobParametersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListJobParametersResponse>);
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
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListJobsResponse>(response);
        }

        public AsyncInvoker<ListJobsResponse> ListJobsAsyncInvoker(ListJobsRequest listJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listJobsRequest);
            return new AsyncInvoker<ListJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListJobsResponse>);
        }
        
        /// <summary>
        /// 查询可用链路信息
        ///
        /// 根据参数不同，可查询实时迁移、实时同步、实时灾备等可用链路信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLinksResponse> ListLinksAsync(ListLinksRequest listLinksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/links", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLinksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListLinksResponse>(response);
        }

        public AsyncInvoker<ListLinksResponse> ListLinksAsyncInvoker(ListLinksRequest listLinksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/links", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLinksRequest);
            return new AsyncInvoker<ListLinksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLinksResponse>);
        }
        
        /// <summary>
        /// 查询项目标签
        ///
        /// 查询指定project ID下不同任务类型的所有标签集合。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<ListProjectTagsResponse> ListProjectTagsAsync(ListProjectTagsRequest listProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listProjectTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListProjectTagsResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<ListProjectTagsResponse> ListProjectTagsAsyncInvoker(ListProjectTagsRequest listProjectTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listProjectTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectTagsRequest);
            return new AsyncInvoker<ListProjectTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProjectTagsResponse>);
        }
        
        /// <summary>
        /// 查询备份迁移任务列表
        ///
        /// 获取当前备份迁移任务列表，不包含已删除的任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListReplicationJobsResponse> ListReplicationJobsAsync(ListReplicationJobsRequest listReplicationJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/backup-migration-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReplicationJobsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListReplicationJobsResponse>(response);
        }

        public AsyncInvoker<ListReplicationJobsResponse> ListReplicationJobsAsyncInvoker(ListReplicationJobsRequest listReplicationJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/backup-migration-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReplicationJobsRequest);
            return new AsyncInvoker<ListReplicationJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListReplicationJobsResponse>);
        }
        
        /// <summary>
        /// 查询项目标签
        ///
        /// 查询租户在指定Project中实例类型的所有资源标签集合。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTagsResponse> ListTagsAsync(ListTagsRequest listTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTagsResponse>(response);
        }

        public AsyncInvoker<ListTagsResponse> ListTagsAsyncInvoker(ListTagsRequest listTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listTagsRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsRequest);
            return new AsyncInvoker<ListTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTagsResponse>);
        }
        
        /// <summary>
        /// 查询创建模板列表
        ///
        /// 查询批量创建模板列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTemplatesResponse> ListTemplatesAsync(ListTemplatesRequest listTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTemplatesResponse>(response);
        }

        public AsyncInvoker<ListTemplatesResponse> ListTemplatesAsyncInvoker(ListTemplatesRequest listTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplatesRequest);
            return new AsyncInvoker<ListTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTemplatesResponse>);
        }
        
        /// <summary>
        /// 查询驱动文件列表
        ///
        /// 查询驱动文件列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListUserJdbcDriversResponse> ListUserJdbcDriversAsync(ListUserJdbcDriversRequest listUserJdbcDriversRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/drivers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserJdbcDriversRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListUserJdbcDriversResponse>(response);
        }

        public AsyncInvoker<ListUserJdbcDriversResponse> ListUserJdbcDriversAsyncInvoker(ListUserJdbcDriversRequest listUserJdbcDriversRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/drivers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUserJdbcDriversRequest);
            return new AsyncInvoker<ListUserJdbcDriversResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUserJdbcDriversResponse>);
        }
        
        /// <summary>
        /// 查询委托的权限列表
        ///
        /// 根据源库类型，目标库类型，是否自建，获取委托所需要的权限
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListsAgencyPermissionsResponse> ListsAgencyPermissionsAsync(ListsAgencyPermissionsRequest listsAgencyPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/agency/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listsAgencyPermissionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListsAgencyPermissionsResponse>(response);
        }

        public AsyncInvoker<ListsAgencyPermissionsResponse> ListsAgencyPermissionsAsyncInvoker(ListsAgencyPermissionsRequest listsAgencyPermissionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/agency/permissions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listsAgencyPermissionsRequest);
            return new AsyncInvoker<ListsAgencyPermissionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListsAgencyPermissionsResponse>);
        }
        
        /// <summary>
        /// 修改连接
        ///
        /// 修改创建的连接信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ModifyConnectionResponse> ModifyConnectionAsync(ModifyConnectionRequest modifyConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("connection_id", modifyConnectionRequest.ConnectionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/connections/{connection_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyConnectionRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ModifyConnectionResponse>(response);
        }

        public AsyncInvoker<ModifyConnectionResponse> ModifyConnectionAsyncInvoker(ModifyConnectionRequest modifyConnectionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("connection_id", modifyConnectionRequest.ConnectionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/connections/{connection_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyConnectionRequest);
            return new AsyncInvoker<ModifyConnectionResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyConnectionResponse>);
        }
        
        /// <summary>
        /// 获取指定任务操作信息
        ///
        /// 获取指定任务允许、不允许、当前操作信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowActionsResponse> ShowActionsAsync(ShowActionsRequest showActionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showActionsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showActionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowActionsResponse>(response);
        }

        public AsyncInvoker<ShowActionsResponse> ShowActionsAsyncInvoker(ShowActionsRequest showActionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showActionsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showActionsRequest);
            return new AsyncInvoker<ShowActionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowActionsResponse>);
        }
        
        /// <summary>
        /// 查询委托权限详情
        ///
        /// 查询委托权限详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAgencyInfoResponse> ShowAgencyInfoAsync(ShowAgencyInfoRequest showAgencyInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_name", showAgencyInfoRequest.AgencyName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/agency/{agency_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAgencyInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAgencyInfoResponse>(response);
        }

        public AsyncInvoker<ShowAgencyInfoResponse> ShowAgencyInfoAsyncInvoker(ShowAgencyInfoRequest showAgencyInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_name", showAgencyInfoRequest.AgencyName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/agency/{agency_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAgencyInfoRequest);
            return new AsyncInvoker<ShowAgencyInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAgencyInfoResponse>);
        }
        
        /// <summary>
        /// 获取指定数据库表列信息
        ///
        /// 获取指定数据库表列信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowColumnInfoResultResponse> ShowColumnInfoResultAsync(ShowColumnInfoResultRequest showColumnInfoResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showColumnInfoResultRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/job/{job_id}/columns", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showColumnInfoResultRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowColumnInfoResultResponse>(response);
        }

        public AsyncInvoker<ShowColumnInfoResultResponse> ShowColumnInfoResultAsyncInvoker(ShowColumnInfoResultRequest showColumnInfoResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showColumnInfoResultRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/job/{job_id}/columns", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showColumnInfoResultRequest);
            return new AsyncInvoker<ShowColumnInfoResultResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowColumnInfoResultResponse>);
        }
        
        /// <summary>
        /// 查询对比策略
        ///
        /// 查询对比策略。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowComparePolicyResponse> ShowComparePolicyAsync(ShowComparePolicyRequest showComparePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showComparePolicyRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/compare-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showComparePolicyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowComparePolicyResponse>(response);
        }

        public AsyncInvoker<ShowComparePolicyResponse> ShowComparePolicyAsyncInvoker(ShowComparePolicyRequest showComparePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showComparePolicyRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/compare-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showComparePolicyRequest);
            return new AsyncInvoker<ShowComparePolicyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowComparePolicyResponse>);
        }
        
        /// <summary>
        /// 查询对比任务进度
        ///
        /// 查询运行中对比任务的对比进度。
        /// 说明：
        /// - 目前仅MySQL-&gt;MySQL、MySQL-&gt;GaussDB主备、GaussDB分布式-&gt;GaussDB分布式、GaussDB主备-&gt;MySQL、GaussDBv1-&gt;GaussDB主备、GaussDB主备-&gt;GaussDBv1的同步任务与独立校验任务支持查看对比进度。
        /// - 运行中的行对比与内容对比支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCompareProgressResponse> ShowCompareProgressAsync(ShowCompareProgressRequest showCompareProgressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showCompareProgressRequest.JobId.ToString());
            urlParam.Add("compare_job_id", showCompareProgressRequest.CompareJobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/compare-progress/{compare_job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCompareProgressRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowCompareProgressResponse>(response);
        }

        public AsyncInvoker<ShowCompareProgressResponse> ShowCompareProgressAsyncInvoker(ShowCompareProgressRequest showCompareProgressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showCompareProgressRequest.JobId.ToString());
            urlParam.Add("compare_job_id", showCompareProgressRequest.CompareJobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/compare-progress/{compare_job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCompareProgressRequest);
            return new AsyncInvoker<ShowCompareProgressResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCompareProgressResponse>);
        }
        
        /// <summary>
        /// 获取数据过滤校验结果
        ///
        /// 获取数据过滤校验结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDataFilteringResultResponse> ShowDataFilteringResultAsync(ShowDataFilteringResultRequest showDataFilteringResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDataFilteringResultRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/job/{job_id}/data-filtering/result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDataFilteringResultRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDataFilteringResultResponse>(response);
        }

        public AsyncInvoker<ShowDataFilteringResultResponse> ShowDataFilteringResultAsyncInvoker(ShowDataFilteringResultRequest showDataFilteringResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDataFilteringResultRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/job/{job_id}/data-filtering/result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDataFilteringResultRequest);
            return new AsyncInvoker<ShowDataFilteringResultResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDataFilteringResultResponse>);
        }
        
        /// <summary>
        /// 获取指定任务数据加工规则更新结果
        ///
        /// 获取指定任务数据加工规则更新结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDataProcessingRulesResultResponse> ShowDataProcessingRulesResultAsync(ShowDataProcessingRulesResultRequest showDataProcessingRulesResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDataProcessingRulesResultRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/data-processing-rules/result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDataProcessingRulesResultRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDataProcessingRulesResultResponse>(response);
        }

        public AsyncInvoker<ShowDataProcessingRulesResultResponse> ShowDataProcessingRulesResultAsyncInvoker(ShowDataProcessingRulesResultRequest showDataProcessingRulesResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDataProcessingRulesResultRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/data-processing-rules/result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDataProcessingRulesResultRequest);
            return new AsyncInvoker<ShowDataProcessingRulesResultResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDataProcessingRulesResultResponse>);
        }
        
        /// <summary>
        /// 查询数据加工规则
        ///
        /// 查询数据加工规则:包含数据库表的映射信息、列信息、数据过滤信息、附加列信息、DDL以及DML信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDataProgressResponse> ShowDataProgressAsync(ShowDataProgressRequest showDataProgressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDataProgressRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/data-processing-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDataProgressRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDataProgressResponse>(response);
        }

        public AsyncInvoker<ShowDataProgressResponse> ShowDataProgressAsyncInvoker(ShowDataProgressRequest showDataProgressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDataProgressRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/data-processing-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDataProgressRequest);
            return new AsyncInvoker<ShowDataProgressResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDataProgressResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDbObjectCollectionStatusRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-objects/collection-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDbObjectCollectionStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDbObjectCollectionStatusResponse>(response);
        }

        public AsyncInvoker<ShowDbObjectCollectionStatusResponse> ShowDbObjectCollectionStatusAsyncInvoker(ShowDbObjectCollectionStatusRequest showDbObjectCollectionStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDbObjectCollectionStatusRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-objects/collection-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDbObjectCollectionStatusRequest);
            return new AsyncInvoker<ShowDbObjectCollectionStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDbObjectCollectionStatusResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDbObjectTemplateProgressRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-object/template/progress", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDbObjectTemplateProgressRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDbObjectTemplateProgressResponse>(response);
        }

        public AsyncInvoker<ShowDbObjectTemplateProgressResponse> ShowDbObjectTemplateProgressAsyncInvoker(ShowDbObjectTemplateProgressRequest showDbObjectTemplateProgressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDbObjectTemplateProgressRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-object/template/progress", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDbObjectTemplateProgressRequest);
            return new AsyncInvoker<ShowDbObjectTemplateProgressResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDbObjectTemplateProgressResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDbObjectTemplateResultRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-object/template/result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDbObjectTemplateResultRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDbObjectTemplateResultResponse>(response);
        }

        public AsyncInvoker<ShowDbObjectTemplateResultResponse> ShowDbObjectTemplateResultAsyncInvoker(ShowDbObjectTemplateResultRequest showDbObjectTemplateResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDbObjectTemplateResultRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-object/template/result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDbObjectTemplateResultRequest);
            return new AsyncInvoker<ShowDbObjectTemplateResultResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDbObjectTemplateResultResponse>);
        }
        
        /// <summary>
        /// 查询数据库对象信息
        ///
        /// 查询数据库对象信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDbObjectsListResponse> ShowDbObjectsListAsync(ShowDbObjectsListRequest showDbObjectsListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDbObjectsListRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5.1/{project_id}/jobs/{job_id}/db-object", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDbObjectsListRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDbObjectsListResponse>(response);
        }

        public AsyncInvoker<ShowDbObjectsListResponse> ShowDbObjectsListAsyncInvoker(ShowDbObjectsListRequest showDbObjectsListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDbObjectsListRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5.1/{project_id}/jobs/{job_id}/db-object", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDbObjectsListRequest);
            return new AsyncInvoker<ShowDbObjectsListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDbObjectsListResponse>);
        }
        
        /// <summary>
        /// 查询异常数据列表
        ///
        /// 查询异常数据列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDirtyDataResponse> ShowDirtyDataAsync(ShowDirtyDataRequest showDirtyDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDirtyDataRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/dirty-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDirtyDataRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDirtyDataResponse>(response);
        }

        public AsyncInvoker<ShowDirtyDataResponse> ShowDirtyDataAsyncInvoker(ShowDirtyDataRequest showDirtyDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showDirtyDataRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/dirty-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDirtyDataRequest);
            return new AsyncInvoker<ShowDirtyDataResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDirtyDataResponse>);
        }
        
        /// <summary>
        /// 查询企业项目列表
        ///
        /// 查询企业项目列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowEnterpriseProjectResponse> ShowEnterpriseProjectAsync(ShowEnterpriseProjectRequest showEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/enterprise-projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEnterpriseProjectRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowEnterpriseProjectResponse>(response);
        }

        public AsyncInvoker<ShowEnterpriseProjectResponse> ShowEnterpriseProjectAsyncInvoker(ShowEnterpriseProjectRequest showEnterpriseProjectRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/enterprise-projects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEnterpriseProjectRequest);
            return new AsyncInvoker<ShowEnterpriseProjectResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEnterpriseProjectResponse>);
        }
        
        /// <summary>
        /// 查询导出创建模板进度
        ///
        /// 查询导出批量创建模板进度。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowExportProgressResponse> ShowExportProgressAsync(ShowExportProgressRequest showExportProgressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("async_job_id", showExportProgressRequest.AsyncJobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{async_job_id}/export/progress", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showExportProgressRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowExportProgressResponse>(response);
        }

        public AsyncInvoker<ShowExportProgressResponse> ShowExportProgressAsyncInvoker(ShowExportProgressRequest showExportProgressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("async_job_id", showExportProgressRequest.AsyncJobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{async_job_id}/export/progress", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showExportProgressRequest);
            return new AsyncInvoker<ShowExportProgressResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowExportProgressResponse>);
        }
        
        /// <summary>
        /// 查询健康对比任务详情
        ///
        /// 查询健康对比任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowHealthCompareJobDetailResponse> ShowHealthCompareJobDetailAsync(ShowHealthCompareJobDetailRequest showHealthCompareJobDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showHealthCompareJobDetailRequest.JobId.ToString());
            urlParam.Add("compare_job_id", showHealthCompareJobDetailRequest.CompareJobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/health-compare-jobs/{compare_job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHealthCompareJobDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowHealthCompareJobDetailResponse>(response);
        }

        public AsyncInvoker<ShowHealthCompareJobDetailResponse> ShowHealthCompareJobDetailAsyncInvoker(ShowHealthCompareJobDetailRequest showHealthCompareJobDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showHealthCompareJobDetailRequest.JobId.ToString());
            urlParam.Add("compare_job_id", showHealthCompareJobDetailRequest.CompareJobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/health-compare-jobs/{compare_job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHealthCompareJobDetailRequest);
            return new AsyncInvoker<ShowHealthCompareJobDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHealthCompareJobDetailResponse>);
        }
        
        /// <summary>
        /// 查询健康对比列表
        ///
        /// 查询健康对比列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowHealthCompareJobListResponse> ShowHealthCompareJobListAsync(ShowHealthCompareJobListRequest showHealthCompareJobListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showHealthCompareJobListRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/health-compare-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHealthCompareJobListRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowHealthCompareJobListResponse>(response);
        }

        public AsyncInvoker<ShowHealthCompareJobListResponse> ShowHealthCompareJobListAsyncInvoker(ShowHealthCompareJobListRequest showHealthCompareJobListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showHealthCompareJobListRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/health-compare-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHealthCompareJobListRequest);
            return new AsyncInvoker<ShowHealthCompareJobListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHealthCompareJobListResponse>);
        }
        
        /// <summary>
        /// 获取健康对比对象级对比概览
        ///
        /// 获取健康对比对象级对比概览。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowHealthObjectCompareJobOverviewResponse> ShowHealthObjectCompareJobOverviewAsync(ShowHealthObjectCompareJobOverviewRequest showHealthObjectCompareJobOverviewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showHealthObjectCompareJobOverviewRequest.JobId.ToString());
            urlParam.Add("compare_job_id", showHealthObjectCompareJobOverviewRequest.CompareJobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/health-compare-jobs/object/{compare_job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHealthObjectCompareJobOverviewRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowHealthObjectCompareJobOverviewResponse>(response);
        }

        public AsyncInvoker<ShowHealthObjectCompareJobOverviewResponse> ShowHealthObjectCompareJobOverviewAsyncInvoker(ShowHealthObjectCompareJobOverviewRequest showHealthObjectCompareJobOverviewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showHealthObjectCompareJobOverviewRequest.JobId.ToString());
            urlParam.Add("compare_job_id", showHealthObjectCompareJobOverviewRequest.CompareJobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/health-compare-jobs/object/{compare_job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHealthObjectCompareJobOverviewRequest);
            return new AsyncInvoker<ShowHealthObjectCompareJobOverviewResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHealthObjectCompareJobOverviewResponse>);
        }
        
        /// <summary>
        /// 查询增量组件详情
        ///
        /// 查询任务同步的增量组件的详细信息，实时同步任务，任务模式为增量或者全量+增量才支持。具体介绍可以参考：[查询同步进度](https://support.huaweicloud.com/realtimesyn-drs/drs_10_0007.html)
        /// - 支持的引擎：oracle-to-gaussdbv5，oracle-to-gaussdbv5ha，gaussdbv5，gaussdbv5-to-mysql，gaussdbv5-to-gaussdbv5ha，gaussdbv5ha，gaussdbv5ha-to-gaussdbv5，gaussdbv5-to-dws，gaussdbv5ha-to-dws，gaussdbv5-to-oracle，gaussdbv5ha-to-oracle，oracle-to-dws，oracle-to-mysql
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowIncrementComponentsDetailResponse> ShowIncrementComponentsDetailAsync(ShowIncrementComponentsDetailRequest showIncrementComponentsDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showIncrementComponentsDetailRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/increment-components-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIncrementComponentsDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowIncrementComponentsDetailResponse>(response);
        }

        public AsyncInvoker<ShowIncrementComponentsDetailResponse> ShowIncrementComponentsDetailAsyncInvoker(ShowIncrementComponentsDetailRequest showIncrementComponentsDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showIncrementComponentsDetailRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/increment-components-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIncrementComponentsDetailRequest);
            return new AsyncInvoker<ShowIncrementComponentsDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowIncrementComponentsDetailResponse>);
        }
        
        /// <summary>
        /// 查询资源标签
        ///
        /// 查询指定实例的标签信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<ShowInstanceTagsResponse> ShowInstanceTagsAsync(ShowInstanceTagsRequest showInstanceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", showInstanceTagsRequest.ResourceType.ToString());
            urlParam.Add("job_id", showInstanceTagsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{resource_type}/{job_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceTagsResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<ShowInstanceTagsResponse> ShowInstanceTagsAsyncInvoker(ShowInstanceTagsRequest showInstanceTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", showInstanceTagsRequest.ResourceType.ToString());
            urlParam.Add("job_id", showInstanceTagsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{resource_type}/{job_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceTagsRequest);
            return new AsyncInvoker<ShowInstanceTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceTagsResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobDetailRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowJobDetailResponse>(response);
        }

        public AsyncInvoker<ShowJobDetailResponse> ShowJobDetailAsyncInvoker(ShowJobDetailRequest showJobDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showJobDetailRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobDetailRequest);
            return new AsyncInvoker<ShowJobDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowJobDetailResponse>);
        }
        
        /// <summary>
        /// 获取任务价格信息
        ///
        /// 获取询价接口的参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMeteringResponse> ShowMeteringAsync(ShowMeteringRequest showMeteringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showMeteringRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/metering", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMeteringRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowMeteringResponse>(response);
        }

        public AsyncInvoker<ShowMeteringResponse> ShowMeteringAsyncInvoker(ShowMeteringRequest showMeteringRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showMeteringRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/metering", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMeteringRequest);
            return new AsyncInvoker<ShowMeteringResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMeteringResponse>);
        }
        
        /// <summary>
        /// 查询监控数据
        ///
        /// 获取任务监控数据。
        /// - Cassandra灾备不支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMonitorDataResponse> ShowMonitorDataAsync(ShowMonitorDataRequest showMonitorDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showMonitorDataRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/monitor-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMonitorDataRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowMonitorDataResponse>(response);
        }

        public AsyncInvoker<ShowMonitorDataResponse> ShowMonitorDataAsyncInvoker(ShowMonitorDataRequest showMonitorDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showMonitorDataRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/monitor-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMonitorDataRequest);
            return new AsyncInvoker<ShowMonitorDataResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowMonitorDataResponse>);
        }
        
        /// <summary>
        /// 查询同步映射列表
        ///
        /// 查询实时同步映射关系包括对象选择时的库映射、schema映射、表映射和数据加工时的列映射。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowObjectMappingResponse> ShowObjectMappingAsync(ShowObjectMappingRequest showObjectMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showObjectMappingRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/object-mappings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showObjectMappingRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShowObjectMappingResponse>(response);
        }

        public AsyncInvoker<ShowObjectMappingResponse> ShowObjectMappingAsyncInvoker(ShowObjectMappingRequest showObjectMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showObjectMappingRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/object-mappings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showObjectMappingRequest);
            return new AsyncInvoker<ShowObjectMappingResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowObjectMappingResponse>);
        }
        
        /// <summary>
        /// 获取查询数据库位点的结果
        ///
        /// 获取查询数据库位点的结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPositionResultResponse> ShowPositionResultAsync(ShowPositionResultRequest showPositionResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showPositionResultRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-position", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPositionResultRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPositionResultResponse>(response);
        }

        public AsyncInvoker<ShowPositionResultResponse> ShowPositionResultAsyncInvoker(ShowPositionResultRequest showPositionResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showPositionResultRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-position", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPositionResultRequest);
            return new AsyncInvoker<ShowPositionResultResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPositionResultResponse>);
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
        public async Task<ShowProgressDataResponse> ShowProgressDataAsync(ShowProgressDataRequest showProgressDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showProgressDataRequest.JobId.ToString());
            urlParam.Add("type", showProgressDataRequest.Type.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/progress-data/{type}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProgressDataRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowProgressDataResponse>(response);
        }

        public AsyncInvoker<ShowProgressDataResponse> ShowProgressDataAsyncInvoker(ShowProgressDataRequest showProgressDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showProgressDataRequest.JobId.ToString());
            urlParam.Add("type", showProgressDataRequest.Type.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/progress-data/{type}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProgressDataRequest);
            return new AsyncInvoker<ShowProgressDataResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProgressDataResponse>);
        }
        
        /// <summary>
        /// 查询录制回放结果
        ///
        /// 获取录制回放结果数据，包括：回放基于时间维度统计信息，异常SQL及统计结果、慢SQL及统计结果
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowReplayResultsResponse> ShowReplayResultsAsync(ShowReplayResultsRequest showReplayResultsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showReplayResultsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/replay-results", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReplayResultsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowReplayResultsResponse>(response);
        }

        public AsyncInvoker<ShowReplayResultsResponse> ShowReplayResultsAsyncInvoker(ShowReplayResultsRequest showReplayResultsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showReplayResultsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/replay-results", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReplayResultsRequest);
            return new AsyncInvoker<ShowReplayResultsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowReplayResultsResponse>);
        }
        
        /// <summary>
        /// 查询备份迁移任务详细信息
        ///
        /// 获取指定备份迁移任务详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowReplicationJobResponse> ShowReplicationJobAsync(ShowReplicationJobRequest showReplicationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showReplicationJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/backup-migration-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReplicationJobRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowReplicationJobResponse>(response);
        }

        public AsyncInvoker<ShowReplicationJobResponse> ShowReplicationJobAsyncInvoker(ShowReplicationJobRequest showReplicationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showReplicationJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/backup-migration-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReplicationJobRequest);
            return new AsyncInvoker<ShowReplicationJobResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowReplicationJobResponse>);
        }
        
        /// <summary>
        /// 查询是否支持对象选择和列映射
        ///
        /// 查询任务支持的对象选择类型、列映射、支持搜索的对象类型等信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSupportObjectTypeResponse> ShowSupportObjectTypeAsync(ShowSupportObjectTypeRequest showSupportObjectTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showSupportObjectTypeRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/object/support", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSupportObjectTypeRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSupportObjectTypeResponse>(response);
        }

        public AsyncInvoker<ShowSupportObjectTypeResponse> ShowSupportObjectTypeAsyncInvoker(ShowSupportObjectTypeRequest showSupportObjectTypeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showSupportObjectTypeRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/object/support", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSupportObjectTypeRequest);
            return new AsyncInvoker<ShowSupportObjectTypeResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSupportObjectTypeResponse>);
        }
        
        /// <summary>
        /// 展示时间轴
        ///
        /// 指定不同的任务ID可以展示当前任务创建时间、启动时间、重试、重置等操作的时间轴信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTimelineResponse> ShowTimelineAsync(ShowTimelineRequest showTimelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showTimelineRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/timelines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTimelineRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTimelineResponse>(response);
        }

        public AsyncInvoker<ShowTimelineResponse> ShowTimelineAsyncInvoker(ShowTimelineRequest showTimelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showTimelineRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/timelines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTimelineRequest);
            return new AsyncInvoker<ShowTimelineResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTimelineResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showUpdateObjectSavingStatusRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-objects/saving-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpdateObjectSavingStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowUpdateObjectSavingStatusResponse>(response);
        }

        public AsyncInvoker<ShowUpdateObjectSavingStatusResponse> ShowUpdateObjectSavingStatusAsyncInvoker(ShowUpdateObjectSavingStatusRequest showUpdateObjectSavingStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", showUpdateObjectSavingStatusRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-objects/saving-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUpdateObjectSavingStatusRequest);
            return new AsyncInvoker<ShowUpdateObjectSavingStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUpdateObjectSavingStatusResponse>);
        }
        
        /// <summary>
        /// 结束任务
        ///
        /// 结束租户指定ID任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StopJobActionResponse> StopJobActionAsync(StopJobActionRequest stopJobActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", stopJobActionRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopJobActionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StopJobActionResponse>(response);
        }

        public AsyncInvoker<StopJobActionResponse> StopJobActionAsyncInvoker(StopJobActionRequest stopJobActionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", stopJobActionRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopJobActionRequest);
            return new AsyncInvoker<StopJobActionResponse>(this, "POST", request, JsonUtils.DeSerialize<StopJobActionResponse>);
        }
        
        /// <summary>
        /// 同步驱动文件（不再推广）
        ///
        /// 同步驱动文件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SyncJdbcDriverResponse> SyncJdbcDriverAsync(SyncJdbcDriverRequest syncJdbcDriverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", syncJdbcDriverRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/update-jdbc-driver", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", syncJdbcDriverRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<SyncJdbcDriverResponse>(response);
        }

        public AsyncInvoker<SyncJdbcDriverResponse> SyncJdbcDriverAsyncInvoker(SyncJdbcDriverRequest syncJdbcDriverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", syncJdbcDriverRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/update-jdbc-driver", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", syncJdbcDriverRequest);
            return new AsyncInvoker<SyncJdbcDriverResponse>(this, "PUT", request, JsonUtils.DeSerialize<SyncJdbcDriverResponse>);
        }
        
        /// <summary>
        /// 同步驱动文件
        ///
        /// 同步驱动文件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SyncUserJdbcDriverResponse> SyncUserJdbcDriverAsync(SyncUserJdbcDriverRequest syncUserJdbcDriverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", syncUserJdbcDriverRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/update-driver", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", syncUserJdbcDriverRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<SyncUserJdbcDriverResponse>(response);
        }

        public AsyncInvoker<SyncUserJdbcDriverResponse> SyncUserJdbcDriverAsyncInvoker(SyncUserJdbcDriverRequest syncUserJdbcDriverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", syncUserJdbcDriverRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/update-driver", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", syncUserJdbcDriverRequest);
            return new AsyncInvoker<SyncUserJdbcDriverResponse>(this, "PUT", request, JsonUtils.DeSerialize<SyncUserJdbcDriverResponse>);
        }
        
        /// <summary>
        /// 更新委托权限策略
        ///
        /// 更新委托权限策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAgencyPolicyResponse> UpdateAgencyPolicyAsync(UpdateAgencyPolicyRequest updateAgencyPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_name", updateAgencyPolicyRequest.AgencyName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/agency/{agency_name}/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAgencyPolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAgencyPolicyResponse>(response);
        }

        public AsyncInvoker<UpdateAgencyPolicyResponse> UpdateAgencyPolicyAsyncInvoker(UpdateAgencyPolicyRequest updateAgencyPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("agency_name", updateAgencyPolicyRequest.AgencyName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/agency/{agency_name}/policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAgencyPolicyRequest);
            return new AsyncInvoker<UpdateAgencyPolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAgencyPolicyResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("async_job_id", updateBatchAsyncJobsRequest.AsyncJobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/batch-async-jobs/{async_job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBatchAsyncJobsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateBatchAsyncJobsResponse>(response);
        }

        public AsyncInvoker<UpdateBatchAsyncJobsResponse> UpdateBatchAsyncJobsAsyncInvoker(UpdateBatchAsyncJobsRequest updateBatchAsyncJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("async_job_id", updateBatchAsyncJobsRequest.AsyncJobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/batch-async-jobs/{async_job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBatchAsyncJobsRequest);
            return new AsyncInvoker<UpdateBatchAsyncJobsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateBatchAsyncJobsResponse>);
        }
        
        /// <summary>
        /// 修改对比策略
        ///
        /// 修改周期性对比的对比策略，目前仅MySQL-&gt;MySQL、MySQL-&gt;GaussDB(for MySQL)、MySQL-&gt;GaussDB(DWS)、GaussDB(for MySQL)-&gt;MySQL同步任务，MySQL-&gt;MySQL、MySQL-&gt;GaussDB(for MySQL)迁移任务，MySQL-&gt;MySQL、MySQL-&gt;GaussDB(for MySQL)、GaussDB(for MySQL)-&gt;GaussDB(for MySQL)、DDM-&gt;DDM、DDS-DDS灾备任务支持对比策略设置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateComparePolicyResponse> UpdateComparePolicyAsync(UpdateComparePolicyRequest updateComparePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", updateComparePolicyRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/compare-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateComparePolicyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateComparePolicyResponse>(response);
        }

        public AsyncInvoker<UpdateComparePolicyResponse> UpdateComparePolicyAsyncInvoker(UpdateComparePolicyRequest updateComparePolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", updateComparePolicyRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/compare-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateComparePolicyRequest);
            return new AsyncInvoker<UpdateComparePolicyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateComparePolicyResponse>);
        }
        
        /// <summary>
        /// 更新指定任务数据加工规则
        ///
        /// 更新指定任务数据加工规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDataProgressResponse> UpdateDataProgressAsync(UpdateDataProgressRequest updateDataProgressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", updateDataProgressRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/data-processing-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDataProgressRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDataProgressResponse>(response);
        }

        public AsyncInvoker<UpdateDataProgressResponse> UpdateDataProgressAsyncInvoker(UpdateDataProgressRequest updateDataProgressRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", updateDataProgressRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/data-processing-rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDataProgressRequest);
            return new AsyncInvoker<UpdateDataProgressResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDataProgressResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", updateJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateJobRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateJobResponse>(response);
        }

        public AsyncInvoker<UpdateJobResponse> UpdateJobAsyncInvoker(UpdateJobRequest updateJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", updateJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateJobRequest);
            return new AsyncInvoker<UpdateJobResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateJobResponse>);
        }
        
        /// <summary>
        /// 更新任务的参数信息
        ///
        /// 更新任务的参数信息。
        /// - 仅engine_type为mysql、mysql-to-pgl、mysql-to-gaussdbv5、mysql-to-gaussdbv5ha、mysql-to-dws、mysql-to-taurus、mysql-to-kafka、mysql-to-elasticsearch、mysql-to-oracle且任务状态只能为配置中、全量中、增量中、全量失败、增量失败、暂停中的实时同步任务支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateJobConfigurationsResponse> UpdateJobConfigurationsAsync(UpdateJobConfigurationsRequest updateJobConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", updateJobConfigurationsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/modify-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateJobConfigurationsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateJobConfigurationsResponse>(response);
        }

        public AsyncInvoker<UpdateJobConfigurationsResponse> UpdateJobConfigurationsAsyncInvoker(UpdateJobConfigurationsRequest updateJobConfigurationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", updateJobConfigurationsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/modify-configuration", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateJobConfigurationsRequest);
            return new AsyncInvoker<UpdateJobConfigurationsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateJobConfigurationsResponse>);
        }
        
        /// <summary>
        /// 修改备份迁移任务信息
        ///
        /// 修改指定备份迁移任务信息，任务名与任务描述。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateReplicationJobResponse> UpdateReplicationJobAsync(UpdateReplicationJobRequest updateReplicationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", updateReplicationJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/backup-migration-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateReplicationJobRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateReplicationJobResponse>(response);
        }

        public AsyncInvoker<UpdateReplicationJobResponse> UpdateReplicationJobAsyncInvoker(UpdateReplicationJobRequest updateReplicationJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", updateReplicationJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/backup-migration-jobs/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateReplicationJobRequest);
            return new AsyncInvoker<UpdateReplicationJobResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateReplicationJobResponse>);
        }
        
        /// <summary>
        /// 更新增量任务启动位点
        ///
        /// 更新增量任务的启动位点。
        /// - 仅engine_type为mysql,mysql-to-dws,mysql-to-taurus,taurus,mysql-to-oracle,taurus-to-oracle,taurus-to-mysql,mysql-to-kafka,taurus-to-kafka,mongodb-to-kafka,mongodb且为单增量实时同步任务支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateStartPositionResponse> UpdateStartPositionAsync(UpdateStartPositionRequest updateStartPositionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", updateStartPositionRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/start-position", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateStartPositionRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateStartPositionResponse>(response);
        }

        public AsyncInvoker<UpdateStartPositionResponse> UpdateStartPositionAsyncInvoker(UpdateStartPositionRequest updateStartPositionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", updateStartPositionRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/start-position", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateStartPositionRequest);
            return new AsyncInvoker<UpdateStartPositionResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateStartPositionResponse>);
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
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", uploadDbObjectTemplateRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-object/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadDbObjectTemplateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UploadDbObjectTemplateResponse>(response);
        }

        public AsyncInvoker<UploadDbObjectTemplateResponse> UploadDbObjectTemplateAsyncInvoker(UploadDbObjectTemplateRequest uploadDbObjectTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", uploadDbObjectTemplateRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/{job_id}/db-object/template", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadDbObjectTemplateRequest);
            return new AsyncInvoker<UploadDbObjectTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<UploadDbObjectTemplateResponse>);
        }
        
        /// <summary>
        /// 上传驱动文件（不再推广）
        ///
        /// 上传驱动文件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UploadJdbcDriverResponse> UploadJdbcDriverAsync(UploadJdbcDriverRequest uploadJdbcDriverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jdbc-driver", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadJdbcDriverRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UploadJdbcDriverResponse>(response);
        }

        public AsyncInvoker<UploadJdbcDriverResponse> UploadJdbcDriverAsyncInvoker(UploadJdbcDriverRequest uploadJdbcDriverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jdbc-driver", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadJdbcDriverRequest);
            return new AsyncInvoker<UploadJdbcDriverResponse>(this, "POST", request, JsonUtils.DeSerialize<UploadJdbcDriverResponse>);
        }
        
        /// <summary>
        /// 上传驱动文件
        ///
        /// 上传驱动文件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UploadUserJdbcDriverResponse> UploadUserJdbcDriverAsync(UploadUserJdbcDriverRequest uploadUserJdbcDriverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/driver", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadUserJdbcDriverRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UploadUserJdbcDriverResponse>(response);
        }

        public AsyncInvoker<UploadUserJdbcDriverResponse> UploadUserJdbcDriverAsyncInvoker(UploadUserJdbcDriverRequest uploadUserJdbcDriverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/driver", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadUserJdbcDriverRequest);
            return new AsyncInvoker<UploadUserJdbcDriverResponse>(this, "POST", request, JsonUtils.DeSerialize<UploadUserJdbcDriverResponse>);
        }
        
        /// <summary>
        /// 任务名称校验
        ///
        /// 创建任务时对任务名称进行校验。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ValidateJobNameResponse> ValidateJobNameAsync(ValidateJobNameRequest validateJobNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/name-validation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", validateJobNameRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ValidateJobNameResponse>(response);
        }

        public AsyncInvoker<ValidateJobNameResponse> ValidateJobNameAsyncInvoker(ValidateJobNameRequest validateJobNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/jobs/name-validation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", validateJobNameRequest);
            return new AsyncInvoker<ValidateJobNameResponse>(this, "POST", request, JsonUtils.DeSerialize<ValidateJobNameResponse>);
        }
        
    }
}