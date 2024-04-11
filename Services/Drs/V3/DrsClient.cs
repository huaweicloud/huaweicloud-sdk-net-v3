using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Drs.V3.Model;

namespace HuaweiCloud.SDK.Drs.V3
{
    public partial class DrsClient : Client
    {
        public static ClientBuilder<DrsClient> NewBuilder()
        {
            return new ClientBuilder<DrsClient>();
        }

        
        /// <summary>
        /// 批量数据加工
        ///
        /// 数据复制服务支持对同步的对象进行加工，即可以为选择的对象添加规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchChangeDataResponse BatchChangeData(BatchChangeDataRequest batchChangeDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-transformation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchChangeDataRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchChangeDataResponse>(response);
        }

        public SyncInvoker<BatchChangeDataResponse> BatchChangeDataInvoker(BatchChangeDataRequest batchChangeDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-transformation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchChangeDataRequest);
            return new SyncInvoker<BatchChangeDataResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchChangeDataResponse>);
        }
        
        /// <summary>
        /// 批量预检查
        ///
        /// 批量预检查，校验是否可进行迁移。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCheckJobsResponse BatchCheckJobs(BatchCheckJobsRequest batchCheckJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-precheck", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCheckJobsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchCheckJobsResponse>(response);
        }

        public SyncInvoker<BatchCheckJobsResponse> BatchCheckJobsInvoker(BatchCheckJobsRequest batchCheckJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-precheck", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCheckJobsRequest);
            return new SyncInvoker<BatchCheckJobsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCheckJobsResponse>);
        }
        
        /// <summary>
        /// 批量查询预检查结果
        ///
        /// 批量查询任务的预检查结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCheckResultsResponse BatchCheckResults(BatchCheckResultsRequest batchCheckResultsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-precheck-result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCheckResultsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchCheckResultsResponse>(response);
        }

        public SyncInvoker<BatchCheckResultsResponse> BatchCheckResultsInvoker(BatchCheckResultsRequest batchCheckResultsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-precheck-result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCheckResultsRequest);
            return new SyncInvoker<BatchCheckResultsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCheckResultsResponse>);
        }
        
        /// <summary>
        /// 批量创建任务
        ///
        /// 根据请求参数不同，可以批量创建实时迁移、实时同步、实时灾备任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCreateJobsResponse BatchCreateJobs(BatchCreateJobsRequest batchCreateJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-creation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateJobsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchCreateJobsResponse>(response);
        }

        public SyncInvoker<BatchCreateJobsResponse> BatchCreateJobsInvoker(BatchCreateJobsRequest batchCreateJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-creation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateJobsRequest);
            return new SyncInvoker<BatchCreateJobsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreateJobsResponse>);
        }
        
        /// <summary>
        /// 批量结束任务或删除任务
        ///
        /// 批量结束任务或删除实时迁移、实时同步、实时灾备任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteJobsResponse BatchDeleteJobs(BatchDeleteJobsRequest batchDeleteJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteJobsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeleteJobsResponse>(response);
        }

        public SyncInvoker<BatchDeleteJobsResponse> BatchDeleteJobsInvoker(BatchDeleteJobsRequest batchDeleteJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteJobsRequest);
            return new SyncInvoker<BatchDeleteJobsResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteJobsResponse>);
        }
        
        /// <summary>
        /// 批量查询任务详情
        ///
        /// 根据任务ID批量查询任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchListJobDetailsResponse BatchListJobDetails(BatchListJobDetailsRequest batchListJobDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListJobDetailsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchListJobDetailsResponse>(response);
        }

        public SyncInvoker<BatchListJobDetailsResponse> BatchListJobDetailsInvoker(BatchListJobDetailsRequest batchListJobDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListJobDetailsRequest);
            return new SyncInvoker<BatchListJobDetailsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchListJobDetailsResponse>);
        }
        
        /// <summary>
        /// 批量查询任务状态
        ///
        /// 根据任务ID批量查询任务状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchListJobStatusResponse BatchListJobStatus(BatchListJobStatusRequest batchListJobStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListJobStatusRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchListJobStatusResponse>(response);
        }

        public SyncInvoker<BatchListJobStatusResponse> BatchListJobStatusInvoker(BatchListJobStatusRequest batchListJobStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListJobStatusRequest);
            return new SyncInvoker<BatchListJobStatusResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchListJobStatusResponse>);
        }
        
        /// <summary>
        /// 批量查询任务进度
        ///
        /// 根据任务ID批量查询全量进度、增量时延信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchListProgressesResponse BatchListProgresses(BatchListProgressesRequest batchListProgressesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-progress", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListProgressesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchListProgressesResponse>(response);
        }

        public SyncInvoker<BatchListProgressesResponse> BatchListProgressesInvoker(BatchListProgressesRequest batchListProgressesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-progress", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListProgressesRequest);
            return new SyncInvoker<BatchListProgressesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchListProgressesResponse>);
        }
        
        /// <summary>
        /// 批量查询RPO和RTO
        ///
        /// 批量查询RPO和RTO。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchListRposAndRtosResponse BatchListRposAndRtos(BatchListRposAndRtosRequest batchListRposAndRtosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-rpo-and-rto", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListRposAndRtosRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchListRposAndRtosResponse>(response);
        }

        public SyncInvoker<BatchListRposAndRtosResponse> BatchListRposAndRtosInvoker(BatchListRposAndRtosRequest batchListRposAndRtosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-rpo-and-rto", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListRposAndRtosRequest);
            return new SyncInvoker<BatchListRposAndRtosResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchListRposAndRtosResponse>);
        }
        
        /// <summary>
        /// 批量查询灾备初始化对象详情
        ///
        /// 根据任务ID批量查询灾备初始化对象详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchListStructDetailResponse BatchListStructDetail(BatchListStructDetailRequest batchListStructDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("type", batchListStructDetailRequest.Type.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{type}/batch-struct-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListStructDetailRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchListStructDetailResponse>(response);
        }

        public SyncInvoker<BatchListStructDetailResponse> BatchListStructDetailInvoker(BatchListStructDetailRequest batchListStructDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("type", batchListStructDetailRequest.Type.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{type}/batch-struct-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListStructDetailRequest);
            return new SyncInvoker<BatchListStructDetailResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchListStructDetailResponse>);
        }
        
        /// <summary>
        /// 批量查询灾备初始化进度
        ///
        /// 根据任务ID批量查询灾备初始化进度，虚拟id不支持查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchListStructProcessResponse BatchListStructProcess(BatchListStructProcessRequest batchListStructProcessRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-struct-process", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListStructProcessRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchListStructProcessResponse>(response);
        }

        public SyncInvoker<BatchListStructProcessResponse> BatchListStructProcessInvoker(BatchListStructProcessRequest batchListStructProcessRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-struct-process", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListStructProcessRequest);
            return new SyncInvoker<BatchListStructProcessResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchListStructProcessResponse>);
        }
        
        /// <summary>
        /// 批量修改源库/目标库密码
        ///
        /// 任务启动之后需要修改源库/目标库密码时调用此接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchResetPasswordResponse BatchResetPassword(BatchResetPasswordRequest batchResetPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-modify-pwd", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchResetPasswordRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<BatchResetPasswordResponse>(response);
        }

        public SyncInvoker<BatchResetPasswordResponse> BatchResetPasswordInvoker(BatchResetPasswordRequest batchResetPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-modify-pwd", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchResetPasswordRequest);
            return new SyncInvoker<BatchResetPasswordResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchResetPasswordResponse>);
        }
        
        /// <summary>
        /// 批量续传/重试
        ///
        /// 在迁移过程中由于不确定因素导致迁移任务失败，可通过重试功能，重新提交迁移任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchRestoreTaskResponse BatchRestoreTask(BatchRestoreTaskRequest batchRestoreTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-retry-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRestoreTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchRestoreTaskResponse>(response);
        }

        public SyncInvoker<BatchRestoreTaskResponse> BatchRestoreTaskInvoker(BatchRestoreTaskRequest batchRestoreTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-retry-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRestoreTaskRequest);
            return new SyncInvoker<BatchRestoreTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchRestoreTaskResponse>);
        }
        
        /// <summary>
        /// 批量设置definer
        ///
        /// 批量设置Definer迁移是否迁移到到该用户下。
        /// - 选择是：迁移后，所有源数据库对象的Definer都会迁移至该用户下，其他用户需要授权后才具有数据库对象权限。
        /// - 选择否：迁移后，将保持源数据库对象Definer定义不变，选择此选项，需要配合下一步用户权限迁移功能，将源数据库的用户全部迁移，这样才能保持源数据库的权限体系完全不变。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchSetDefinerResponse BatchSetDefiner(BatchSetDefinerRequest batchSetDefinerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-replace-definer", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetDefinerRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchSetDefinerResponse>(response);
        }

        public SyncInvoker<BatchSetDefinerResponse> BatchSetDefinerInvoker(BatchSetDefinerRequest batchSetDefinerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-replace-definer", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetDefinerRequest);
            return new SyncInvoker<BatchSetDefinerResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchSetDefinerResponse>);
        }
        
        /// <summary>
        /// 批量数据库对象选择
        ///
        /// 迁移之前，选择需要迁移的数据库或者表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchSetObjectsResponse BatchSetObjects(BatchSetObjectsRequest batchSetObjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-select-objects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetObjectsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<BatchSetObjectsResponse>(response);
        }

        public SyncInvoker<BatchSetObjectsResponse> BatchSetObjectsInvoker(BatchSetObjectsRequest batchSetObjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-select-objects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetObjectsRequest);
            return new SyncInvoker<BatchSetObjectsResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchSetObjectsResponse>);
        }
        
        /// <summary>
        /// 批量设置同步策略
        ///
        /// - 批量设置同步策略，包括冲突策略、过滤DROP Datase、对象同步范围。
        /// - 设置kafka同步策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchSetPolicyResponse BatchSetPolicy(BatchSetPolicyRequest batchSetPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-sync-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetPolicyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchSetPolicyResponse>(response);
        }

        public SyncInvoker<BatchSetPolicyResponse> BatchSetPolicyInvoker(BatchSetPolicyRequest batchSetPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-sync-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetPolicyRequest);
            return new SyncInvoker<BatchSetPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchSetPolicyResponse>);
        }
        
        /// <summary>
        /// 批量配置异常通知
        ///
        /// 批量设置异常通知，已结束的任务不支持设置。
        /// - 支持选择已有的SMN主题和手动输入手机号、邮箱两种方式，具体根据自己使用情况选择
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchSetSmnResponse BatchSetSmn(BatchSetSmnRequest batchSetSmnRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-set-smn", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetSmnRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchSetSmnResponse>(response);
        }

        public SyncInvoker<BatchSetSmnResponse> BatchSetSmnInvoker(BatchSetSmnRequest batchSetSmnRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-set-smn", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetSmnRequest);
            return new SyncInvoker<BatchSetSmnResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchSetSmnResponse>);
        }
        
        /// <summary>
        /// 批量设置任务限速
        ///
        /// 批量设置任务限速，任务创建成功后默认不限速。
        /// - 限速：自定义的最大迁移速度，迁移过程中的迁移速度将不会超过该速度。
        /// - 不限速：对迁移速度不进行限制，通常会最大化使用源数据库的出口带宽。该流速模式同时会对源数据库造成读消耗，消耗取决于源数据库的出口带宽。比如：源数据库的出口带宽为100MB/s，假设高速模式使用了80%带宽，则迁移对源数据库将造成80MB/s的读操作IO消耗。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchSetSpeedResponse BatchSetSpeed(BatchSetSpeedRequest batchSetSpeedRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-limit-speed", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetSpeedRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<BatchSetSpeedResponse>(response);
        }

        public SyncInvoker<BatchSetSpeedResponse> BatchSetSpeedInvoker(BatchSetSpeedRequest batchSetSpeedRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-limit-speed", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetSpeedRequest);
            return new SyncInvoker<BatchSetSpeedResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchSetSpeedResponse>);
        }
        
        /// <summary>
        /// 批量获取数据库参数
        ///
        /// 在进行数据库迁移时，为了确保迁移成功后业务应用的使用不受影响，数据复制服务提供了参数对比功能帮助您进行源库和目标库参数一致性对比，此接口可以获取源库和目标库的数据库参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchShowParamsResponse BatchShowParams(BatchShowParamsRequest batchShowParamsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-get-params", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchShowParamsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchShowParamsResponse>(response);
        }

        public SyncInvoker<BatchShowParamsResponse> BatchShowParamsInvoker(BatchShowParamsRequest batchShowParamsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-get-params", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchShowParamsRequest);
            return new SyncInvoker<BatchShowParamsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchShowParamsResponse>);
        }
        
        /// <summary>
        /// 批量启动任务
        ///
        /// 批量启动实时迁移、同步、灾备任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchStartJobsResponse BatchStartJobs(BatchStartJobsRequest batchStartJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-starting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchStartJobsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchStartJobsResponse>(response);
        }

        public SyncInvoker<BatchStartJobsResponse> BatchStartJobsInvoker(BatchStartJobsRequest batchStartJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-starting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchStartJobsRequest);
            return new SyncInvoker<BatchStartJobsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchStartJobsResponse>);
        }
        
        /// <summary>
        /// 批量暂停任务
        ///
        /// 批量暂停任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchStopJobsResponse BatchStopJobs(BatchStopJobsRequest batchStopJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-pause-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchStopJobsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchStopJobsResponse>(response);
        }

        public SyncInvoker<BatchStopJobsResponse> BatchStopJobsInvoker(BatchStopJobsRequest batchStopJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-pause-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchStopJobsRequest);
            return new SyncInvoker<BatchStopJobsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchStopJobsResponse>);
        }
        
        /// <summary>
        /// 批量主备倒换
        ///
        /// 批量主备倒换。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchSwitchoverResponse BatchSwitchover(BatchSwitchoverRequest batchSwitchoverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-switchover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSwitchoverRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchSwitchoverResponse>(response);
        }

        public SyncInvoker<BatchSwitchoverResponse> BatchSwitchoverInvoker(BatchSwitchoverRequest batchSwitchoverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-switchover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSwitchoverRequest);
            return new SyncInvoker<BatchSwitchoverResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchSwitchoverResponse>);
        }
        
        /// <summary>
        /// 批量修改任务
        ///
        /// 批量修改任务名称或描述，设置异常通知信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchUpdateJobResponse BatchUpdateJob(BatchUpdateJobRequest batchUpdateJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-modification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateJobRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<BatchUpdateJobResponse>(response);
        }

        public SyncInvoker<BatchUpdateJobResponse> BatchUpdateJobInvoker(BatchUpdateJobRequest batchUpdateJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-modification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateJobRequest);
            return new SyncInvoker<BatchUpdateJobResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchUpdateJobResponse>);
        }
        
        /// <summary>
        /// 批量更新迁移用户信息
        ///
        /// 数据库的迁移过程中，迁移用户需要进行单独处理，该接口可以批量设置需要迁移的用户和角色。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchUpdateUserResponse BatchUpdateUser(BatchUpdateUserRequest batchUpdateUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-update-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateUserRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<BatchUpdateUserResponse>(response);
        }

        public SyncInvoker<BatchUpdateUserResponse> BatchUpdateUserInvoker(BatchUpdateUserRequest batchUpdateUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-update-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateUserRequest);
            return new SyncInvoker<BatchUpdateUserResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchUpdateUserResponse>);
        }
        
        /// <summary>
        /// 批量测试连接-集群模式
        ///
        /// - 批量测试连接（集群模式）。
        /// - 主备任务测试连接
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchValidateClustersConnectionsResponse BatchValidateClustersConnections(BatchValidateClustersConnectionsRequest batchValidateClustersConnectionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/cluster/batch-connection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchValidateClustersConnectionsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchValidateClustersConnectionsResponse>(response);
        }

        public SyncInvoker<BatchValidateClustersConnectionsResponse> BatchValidateClustersConnectionsInvoker(BatchValidateClustersConnectionsRequest batchValidateClustersConnectionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/cluster/batch-connection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchValidateClustersConnectionsRequest);
            return new SyncInvoker<BatchValidateClustersConnectionsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchValidateClustersConnectionsResponse>);
        }
        
        /// <summary>
        /// 批量测试连接
        ///
        /// 批量测试连接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchValidateConnectionsResponse BatchValidateConnections(BatchValidateConnectionsRequest batchValidateConnectionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-connection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchValidateConnectionsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchValidateConnectionsResponse>(response);
        }

        public SyncInvoker<BatchValidateConnectionsResponse> BatchValidateConnectionsInvoker(BatchValidateConnectionsRequest batchValidateConnectionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-connection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchValidateConnectionsRequest);
            return new SyncInvoker<BatchValidateConnectionsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchValidateConnectionsResponse>);
        }
        
        /// <summary>
        /// 创建对比任务
        ///
        /// 创建对比任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateCompareTaskResponse CreateCompareTask(CreateCompareTaskRequest createCompareTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/create-compare-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCompareTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateCompareTaskResponse>(response);
        }

        public SyncInvoker<CreateCompareTaskResponse> CreateCompareTaskInvoker(CreateCompareTaskRequest createCompareTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/create-compare-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCompareTaskRequest);
            return new SyncInvoker<CreateCompareTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCompareTaskResponse>);
        }
        
        /// <summary>
        /// 创建数据级表对比任务
        ///
        /// 创建数据级表对比任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDataLevelTableCompareJobResponse CreateDataLevelTableCompareJob(CreateDataLevelTableCompareJobRequest createDataLevelTableCompareJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", createDataLevelTableCompareJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/table/compare", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDataLevelTableCompareJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDataLevelTableCompareJobResponse>(response);
        }

        public SyncInvoker<CreateDataLevelTableCompareJobResponse> CreateDataLevelTableCompareJobInvoker(CreateDataLevelTableCompareJobRequest createDataLevelTableCompareJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", createDataLevelTableCompareJobRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/table/compare", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDataLevelTableCompareJobRequest);
            return new SyncInvoker<CreateDataLevelTableCompareJobResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDataLevelTableCompareJobResponse>);
        }
        
        /// <summary>
        /// 取消对比任务
        ///
        /// 取消对比任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteCompareJobResponse DeleteCompareJob(DeleteCompareJobRequest deleteCompareJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", deleteCompareJobRequest.JobId.ToString());
            urlParam.Add("compare_job_id", deleteCompareJobRequest.CompareJobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/compare/{compare_job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCompareJobRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteCompareJobResponse>(response);
        }

        public SyncInvoker<DeleteCompareJobResponse> DeleteCompareJobInvoker(DeleteCompareJobRequest deleteCompareJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", deleteCompareJobRequest.JobId.ToString());
            urlParam.Add("compare_job_id", deleteCompareJobRequest.CompareJobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/compare/{compare_job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCompareJobRequest);
            return new SyncInvoker<DeleteCompareJobResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteCompareJobResponse>);
        }
        
        /// <summary>
        /// 查询可用的Node规格
        ///
        /// 查询可用的Node规格。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAvailableNodeTypesResponse ListAvailableNodeTypes(ListAvailableNodeTypesRequest listAvailableNodeTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/node-type", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableNodeTypesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAvailableNodeTypesResponse>(response);
        }

        public SyncInvoker<ListAvailableNodeTypesResponse> ListAvailableNodeTypesInvoker(ListAvailableNodeTypesRequest listAvailableNodeTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/node-type", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableNodeTypesRequest);
            return new SyncInvoker<ListAvailableNodeTypesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAvailableNodeTypesResponse>);
        }
        
        /// <summary>
        /// 查询规格未售罄的可用区
        ///
        /// 查询规格未售罄的可用区
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAvailableZoneResponse ListAvailableZone(ListAvailableZoneRequest listAvailableZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/available-zone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableZoneRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListAvailableZoneResponse>(response);
        }

        public SyncInvoker<ListAvailableZoneResponse> ListAvailableZoneInvoker(ListAvailableZoneRequest listAvailableZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/available-zone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableZoneRequest);
            return new SyncInvoker<ListAvailableZoneResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAvailableZoneResponse>);
        }
        
        /// <summary>
        /// 查询对比结果
        ///
        /// 查询对比结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCompareResultResponse ListCompareResult(ListCompareResultRequest listCompareResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/query-compare-result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCompareResultRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListCompareResultResponse>(response);
        }

        public SyncInvoker<ListCompareResultResponse> ListCompareResultInvoker(ListCompareResultRequest listCompareResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/query-compare-result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCompareResultRequest);
            return new SyncInvoker<ListCompareResultResponse>(this, "POST", request, JsonUtils.DeSerialize<ListCompareResultResponse>);
        }
        
        /// <summary>
        /// 查询内容对比详情
        ///
        /// 查询内容对比详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListContentCompareDetailResponse ListContentCompareDetail(ListContentCompareDetailRequest listContentCompareDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listContentCompareDetailRequest.JobId.ToString());
            urlParam.Add("compare_job_id", listContentCompareDetailRequest.CompareJobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/compare/{compare_job_id}/content-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listContentCompareDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListContentCompareDetailResponse>(response);
        }

        public SyncInvoker<ListContentCompareDetailResponse> ListContentCompareDetailInvoker(ListContentCompareDetailRequest listContentCompareDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listContentCompareDetailRequest.JobId.ToString());
            urlParam.Add("compare_job_id", listContentCompareDetailRequest.CompareJobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/compare/{compare_job_id}/content-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listContentCompareDetailRequest);
            return new SyncInvoker<ListContentCompareDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListContentCompareDetailResponse>);
        }
        
        /// <summary>
        /// 查询内容对比总览
        ///
        /// 查询内容对比总览。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListContentCompareOverviewResponse ListContentCompareOverview(ListContentCompareOverviewRequest listContentCompareOverviewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listContentCompareOverviewRequest.JobId.ToString());
            urlParam.Add("compare_job_id", listContentCompareOverviewRequest.CompareJobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/compare/{compare_job_id}/content-overview", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listContentCompareOverviewRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListContentCompareOverviewResponse>(response);
        }

        public SyncInvoker<ListContentCompareOverviewResponse> ListContentCompareOverviewInvoker(ListContentCompareOverviewRequest listContentCompareOverviewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listContentCompareOverviewRequest.JobId.ToString());
            urlParam.Add("compare_job_id", listContentCompareOverviewRequest.CompareJobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/compare/{compare_job_id}/content-overview", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listContentCompareOverviewRequest);
            return new SyncInvoker<ListContentCompareOverviewResponse>(this, "GET", request, JsonUtils.DeSerialize<ListContentCompareOverviewResponse>);
        }
        
        /// <summary>
        /// 查询行数对比详情
        ///
        /// 查询行数对比详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDataCompareDetailResponse ListDataCompareDetail(ListDataCompareDetailRequest listDataCompareDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listDataCompareDetailRequest.JobId.ToString());
            urlParam.Add("compare_job_id", listDataCompareDetailRequest.CompareJobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/compare/{compare_job_id}/line-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDataCompareDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDataCompareDetailResponse>(response);
        }

        public SyncInvoker<ListDataCompareDetailResponse> ListDataCompareDetailInvoker(ListDataCompareDetailRequest listDataCompareDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listDataCompareDetailRequest.JobId.ToString());
            urlParam.Add("compare_job_id", listDataCompareDetailRequest.CompareJobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/compare/{compare_job_id}/line-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDataCompareDetailRequest);
            return new SyncInvoker<ListDataCompareDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDataCompareDetailResponse>);
        }
        
        /// <summary>
        /// 查询行数对比总览
        ///
        /// 查询行数对比总览。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDataCompareOverviewResponse ListDataCompareOverview(ListDataCompareOverviewRequest listDataCompareOverviewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listDataCompareOverviewRequest.JobId.ToString());
            urlParam.Add("compare_job_id", listDataCompareOverviewRequest.CompareJobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/compare/{compare_job_id}/line-overview", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDataCompareOverviewRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDataCompareOverviewResponse>(response);
        }

        public SyncInvoker<ListDataCompareOverviewResponse> ListDataCompareOverviewInvoker(ListDataCompareOverviewRequest listDataCompareOverviewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listDataCompareOverviewRequest.JobId.ToString());
            urlParam.Add("compare_job_id", listDataCompareOverviewRequest.CompareJobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/compare/{compare_job_id}/line-overview", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDataCompareOverviewRequest);
            return new SyncInvoker<ListDataCompareOverviewResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDataCompareOverviewResponse>);
        }
        
        /// <summary>
        /// 查询数据级表对比任务列表
        ///
        /// 查询数据级表对比任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDataLevelTableCompareJobsResponse ListDataLevelTableCompareJobs(ListDataLevelTableCompareJobsRequest listDataLevelTableCompareJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listDataLevelTableCompareJobsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/table/compare", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDataLevelTableCompareJobsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDataLevelTableCompareJobsResponse>(response);
        }

        public SyncInvoker<ListDataLevelTableCompareJobsResponse> ListDataLevelTableCompareJobsInvoker(ListDataLevelTableCompareJobsRequest listDataLevelTableCompareJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listDataLevelTableCompareJobsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/table/compare", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDataLevelTableCompareJobsRequest);
            return new SyncInvoker<ListDataLevelTableCompareJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDataLevelTableCompareJobsResponse>);
        }
        
        /// <summary>
        /// 获取源库迁移用户列表
        ///
        /// 数据库的迁移过程中，迁移用户需要进行单独处理，该接口可以查询源库的用户信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListUsersResponse ListUsers(ListUsersRequest listUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listUsersRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/get-src-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListUsersResponse>(response);
        }

        public SyncInvoker<ListUsersResponse> ListUsersInvoker(ListUsersRequest listUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listUsersRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/get-src-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersRequest);
            return new SyncInvoker<ListUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUsersResponse>);
        }
        
        /// <summary>
        /// 查询租户任务列表
        ///
        /// 查询租户任务列表，可以根据引擎类型，网络类型，任务状态，任务名称，任务ID进行查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowJobListResponse ShowJobList(ShowJobListRequest showJobListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobListRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowJobListResponse>(response);
        }

        public SyncInvoker<ShowJobListResponse> ShowJobListInvoker(ShowJobListRequest showJobListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobListRequest);
            return new SyncInvoker<ShowJobListResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowJobListResponse>);
        }
        
        /// <summary>
        /// 查询容灾监控数据
        ///
        /// 根据任务ID查询容灾监控数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowMonitoringDataResponse ShowMonitoringData(ShowMonitoringDataRequest showMonitoringDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/disaster-recovery-monitoring-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMonitoringDataRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowMonitoringDataResponse>(response);
        }

        public SyncInvoker<ShowMonitoringDataResponse> ShowMonitoringDataInvoker(ShowMonitoringDataRequest showMonitoringDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/disaster-recovery-monitoring-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMonitoringDataRequest);
            return new SyncInvoker<ShowMonitoringDataResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowMonitoringDataResponse>);
        }
        
        /// <summary>
        /// 查询配额
        ///
        /// 查询单租户在某一项目下DRS服务下的配额信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowQuotasResponse ShowQuotas(ShowQuotasRequest showQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowQuotasResponse>(response);
        }

        public SyncInvoker<ShowQuotasResponse> ShowQuotasInvoker(ShowQuotasRequest showQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotasRequest);
            return new SyncInvoker<ShowQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowQuotasResponse>);
        }
        
        /// <summary>
        /// 立即启动数据级表对比任务
        ///
        /// 立即启动数据级表对比任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StartPromptlyDataLevelTableCompareJobResponse StartPromptlyDataLevelTableCompareJob(StartPromptlyDataLevelTableCompareJobRequest startPromptlyDataLevelTableCompareJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", startPromptlyDataLevelTableCompareJobRequest.JobId.ToString());
            urlParam.Add("compare_job_id", startPromptlyDataLevelTableCompareJobRequest.CompareJobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/table/compare/{compare_job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startPromptlyDataLevelTableCompareJobRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StartPromptlyDataLevelTableCompareJobResponse>(response);
        }

        public SyncInvoker<StartPromptlyDataLevelTableCompareJobResponse> StartPromptlyDataLevelTableCompareJobInvoker(StartPromptlyDataLevelTableCompareJobRequest startPromptlyDataLevelTableCompareJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", startPromptlyDataLevelTableCompareJobRequest.JobId.ToString());
            urlParam.Add("compare_job_id", startPromptlyDataLevelTableCompareJobRequest.CompareJobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/table/compare/{compare_job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startPromptlyDataLevelTableCompareJobRequest);
            return new SyncInvoker<StartPromptlyDataLevelTableCompareJobResponse>(this, "POST", request, JsonUtils.DeSerialize<StartPromptlyDataLevelTableCompareJobResponse>);
        }
        
        /// <summary>
        /// 修改数据库参数
        ///
        /// 修改数据库参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateParamsResponse UpdateParams(UpdateParamsRequest updateParamsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", updateParamsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/params", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateParamsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdateParamsResponse>(response);
        }

        public SyncInvoker<UpdateParamsResponse> UpdateParamsInvoker(UpdateParamsRequest updateParamsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", updateParamsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/params", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateParamsRequest);
            return new SyncInvoker<UpdateParamsResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateParamsResponse>);
        }
        
        /// <summary>
        /// 高级设置
        ///
        /// 修改调优参数的值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTuningParamsResponse UpdateTuningParams(UpdateTuningParamsRequest updateTuningParamsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", updateTuningParamsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/job/{job_id}/tuning-params/modify-params", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTuningParamsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateTuningParamsResponse>(response);
        }

        public SyncInvoker<UpdateTuningParamsResponse> UpdateTuningParamsInvoker(UpdateTuningParamsRequest updateTuningParamsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", updateTuningParamsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/job/{job_id}/tuning-params/modify-params", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTuningParamsRequest);
            return new SyncInvoker<UpdateTuningParamsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateTuningParamsResponse>);
        }
        
    }
}