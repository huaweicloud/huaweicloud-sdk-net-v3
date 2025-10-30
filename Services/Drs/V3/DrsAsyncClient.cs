using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Drs.V3.Model;

namespace HuaweiCloud.SDK.Drs.V3
{
    public partial class DrsAsyncClient : Client
    {
        public static ClientBuilder<DrsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<DrsAsyncClient>();
        }

        
        /// <summary>
        /// 批量数据加工
        ///
        /// 数据复制服务支持对同步的对象进行加工，即可以为选择的对象添加规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchChangeDataResponse> BatchChangeDataAsync(BatchChangeDataRequest batchChangeDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-transformation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchChangeDataRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchChangeDataResponse>(response);
        }

        public AsyncInvoker<BatchChangeDataResponse> BatchChangeDataAsyncInvoker(BatchChangeDataRequest batchChangeDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-transformation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchChangeDataRequest);
            return new AsyncInvoker<BatchChangeDataResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchChangeDataResponse>);
        }
        
        /// <summary>
        /// 批量预检查
        ///
        /// 批量预检查，校验是否可进行迁移。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCheckJobsResponse> BatchCheckJobsAsync(BatchCheckJobsRequest batchCheckJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-precheck", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCheckJobsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchCheckJobsResponse>(response);
        }

        public AsyncInvoker<BatchCheckJobsResponse> BatchCheckJobsAsyncInvoker(BatchCheckJobsRequest batchCheckJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-precheck", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCheckJobsRequest);
            return new AsyncInvoker<BatchCheckJobsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCheckJobsResponse>);
        }
        
        /// <summary>
        /// 批量查询预检查结果
        ///
        /// 批量查询任务的预检查结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCheckResultsResponse> BatchCheckResultsAsync(BatchCheckResultsRequest batchCheckResultsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-precheck-result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCheckResultsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchCheckResultsResponse>(response);
        }

        public AsyncInvoker<BatchCheckResultsResponse> BatchCheckResultsAsyncInvoker(BatchCheckResultsRequest batchCheckResultsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-precheck-result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCheckResultsRequest);
            return new AsyncInvoker<BatchCheckResultsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCheckResultsResponse>);
        }
        
        /// <summary>
        /// 批量创建任务
        ///
        /// 根据请求参数不同，可以批量创建实时迁移、实时同步、实时灾备任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCreateJobsResponse> BatchCreateJobsAsync(BatchCreateJobsRequest batchCreateJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-creation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateJobsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchCreateJobsResponse>(response);
        }

        public AsyncInvoker<BatchCreateJobsResponse> BatchCreateJobsAsyncInvoker(BatchCreateJobsRequest batchCreateJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-creation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateJobsRequest);
            return new AsyncInvoker<BatchCreateJobsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCreateJobsResponse>);
        }
        
        /// <summary>
        /// 批量结束任务或删除任务
        ///
        /// 批量结束任务或删除实时迁移、实时同步、实时灾备任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteJobsResponse> BatchDeleteJobsAsync(BatchDeleteJobsRequest batchDeleteJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteJobsRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeleteJobsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteJobsResponse> BatchDeleteJobsAsyncInvoker(BatchDeleteJobsRequest batchDeleteJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteJobsRequest);
            return new AsyncInvoker<BatchDeleteJobsResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteJobsResponse>);
        }
        
        /// <summary>
        /// 批量查询任务详情
        ///
        /// 根据任务ID批量查询任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchListJobDetailsResponse> BatchListJobDetailsAsync(BatchListJobDetailsRequest batchListJobDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListJobDetailsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchListJobDetailsResponse>(response);
        }

        public AsyncInvoker<BatchListJobDetailsResponse> BatchListJobDetailsAsyncInvoker(BatchListJobDetailsRequest batchListJobDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListJobDetailsRequest);
            return new AsyncInvoker<BatchListJobDetailsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchListJobDetailsResponse>);
        }
        
        /// <summary>
        /// 批量查询任务状态
        ///
        /// 根据任务ID批量查询任务状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchListJobStatusResponse> BatchListJobStatusAsync(BatchListJobStatusRequest batchListJobStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListJobStatusRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchListJobStatusResponse>(response);
        }

        public AsyncInvoker<BatchListJobStatusResponse> BatchListJobStatusAsyncInvoker(BatchListJobStatusRequest batchListJobStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListJobStatusRequest);
            return new AsyncInvoker<BatchListJobStatusResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchListJobStatusResponse>);
        }
        
        /// <summary>
        /// 批量查询任务进度
        ///
        /// 根据任务ID批量查询全量进度、增量时延信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchListProgressesResponse> BatchListProgressesAsync(BatchListProgressesRequest batchListProgressesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-progress", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListProgressesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchListProgressesResponse>(response);
        }

        public AsyncInvoker<BatchListProgressesResponse> BatchListProgressesAsyncInvoker(BatchListProgressesRequest batchListProgressesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-progress", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListProgressesRequest);
            return new AsyncInvoker<BatchListProgressesResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchListProgressesResponse>);
        }
        
        /// <summary>
        /// 批量查询RPO和RTO
        ///
        /// 批量查询RPO和RTO。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchListRposAndRtosResponse> BatchListRposAndRtosAsync(BatchListRposAndRtosRequest batchListRposAndRtosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-rpo-and-rto", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListRposAndRtosRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchListRposAndRtosResponse>(response);
        }

        public AsyncInvoker<BatchListRposAndRtosResponse> BatchListRposAndRtosAsyncInvoker(BatchListRposAndRtosRequest batchListRposAndRtosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-rpo-and-rto", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListRposAndRtosRequest);
            return new AsyncInvoker<BatchListRposAndRtosResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchListRposAndRtosResponse>);
        }
        
        /// <summary>
        /// 批量查询灾备初始化对象详情
        ///
        /// 根据任务ID批量查询灾备初始化对象详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchListStructDetailResponse> BatchListStructDetailAsync(BatchListStructDetailRequest batchListStructDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchListStructDetailRequest.Type, out var valueOfType)) urlParam.Add("type", valueOfType);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{type}/batch-struct-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListStructDetailRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchListStructDetailResponse>(response);
        }

        public AsyncInvoker<BatchListStructDetailResponse> BatchListStructDetailAsyncInvoker(BatchListStructDetailRequest batchListStructDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchListStructDetailRequest.Type, out var valueOfType)) urlParam.Add("type", valueOfType);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{type}/batch-struct-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListStructDetailRequest);
            return new AsyncInvoker<BatchListStructDetailResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchListStructDetailResponse>);
        }
        
        /// <summary>
        /// 批量查询灾备初始化进度
        ///
        /// 根据任务ID批量查询灾备初始化进度，虚拟id不支持查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchListStructProcessResponse> BatchListStructProcessAsync(BatchListStructProcessRequest batchListStructProcessRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-struct-process", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListStructProcessRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchListStructProcessResponse>(response);
        }

        public AsyncInvoker<BatchListStructProcessResponse> BatchListStructProcessAsyncInvoker(BatchListStructProcessRequest batchListStructProcessRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-struct-process", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListStructProcessRequest);
            return new AsyncInvoker<BatchListStructProcessResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchListStructProcessResponse>);
        }
        
        /// <summary>
        /// 批量修改源库/目标库密码
        ///
        /// 任务启动之后需要修改源库/目标库密码时调用此接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchResetPasswordResponse> BatchResetPasswordAsync(BatchResetPasswordRequest batchResetPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-modify-pwd", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchResetPasswordRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<BatchResetPasswordResponse>(response);
        }

        public AsyncInvoker<BatchResetPasswordResponse> BatchResetPasswordAsyncInvoker(BatchResetPasswordRequest batchResetPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-modify-pwd", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchResetPasswordRequest);
            return new AsyncInvoker<BatchResetPasswordResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchResetPasswordResponse>);
        }
        
        /// <summary>
        /// 批量续传/重试
        ///
        /// 在迁移过程中由于不确定因素导致迁移任务失败，可通过重试功能，重新提交迁移任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchRestoreTaskResponse> BatchRestoreTaskAsync(BatchRestoreTaskRequest batchRestoreTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-retry-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRestoreTaskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchRestoreTaskResponse>(response);
        }

        public AsyncInvoker<BatchRestoreTaskResponse> BatchRestoreTaskAsyncInvoker(BatchRestoreTaskRequest batchRestoreTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-retry-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRestoreTaskRequest);
            return new AsyncInvoker<BatchRestoreTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchRestoreTaskResponse>);
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
        public async Task<BatchSetDefinerResponse> BatchSetDefinerAsync(BatchSetDefinerRequest batchSetDefinerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-replace-definer", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetDefinerRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchSetDefinerResponse>(response);
        }

        public AsyncInvoker<BatchSetDefinerResponse> BatchSetDefinerAsyncInvoker(BatchSetDefinerRequest batchSetDefinerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-replace-definer", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetDefinerRequest);
            return new AsyncInvoker<BatchSetDefinerResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchSetDefinerResponse>);
        }
        
        /// <summary>
        /// 批量数据库对象选择
        ///
        /// 迁移之前，选择需要迁移的数据库或者表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchSetObjectsResponse> BatchSetObjectsAsync(BatchSetObjectsRequest batchSetObjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-select-objects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetObjectsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<BatchSetObjectsResponse>(response);
        }

        public AsyncInvoker<BatchSetObjectsResponse> BatchSetObjectsAsyncInvoker(BatchSetObjectsRequest batchSetObjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-select-objects", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetObjectsRequest);
            return new AsyncInvoker<BatchSetObjectsResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchSetObjectsResponse>);
        }
        
        /// <summary>
        /// 批量设置同步策略
        ///
        /// - 批量设置同步策略，包括冲突策略、过滤DROP Datase、对象同步范围。
        /// - 设置kafka同步策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchSetPolicyResponse> BatchSetPolicyAsync(BatchSetPolicyRequest batchSetPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-sync-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetPolicyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchSetPolicyResponse>(response);
        }

        public AsyncInvoker<BatchSetPolicyResponse> BatchSetPolicyAsyncInvoker(BatchSetPolicyRequest batchSetPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-sync-policy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetPolicyRequest);
            return new AsyncInvoker<BatchSetPolicyResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchSetPolicyResponse>);
        }
        
        /// <summary>
        /// 批量配置异常通知
        ///
        /// 批量设置异常通知，已结束的任务不支持设置。
        /// - 支持选择已有的SMN主题和手动输入手机号、邮箱两种方式，具体根据自己使用情况选择
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchSetSmnResponse> BatchSetSmnAsync(BatchSetSmnRequest batchSetSmnRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-set-smn", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetSmnRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchSetSmnResponse>(response);
        }

        public AsyncInvoker<BatchSetSmnResponse> BatchSetSmnAsyncInvoker(BatchSetSmnRequest batchSetSmnRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-set-smn", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetSmnRequest);
            return new AsyncInvoker<BatchSetSmnResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchSetSmnResponse>);
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
        public async Task<BatchSetSpeedResponse> BatchSetSpeedAsync(BatchSetSpeedRequest batchSetSpeedRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-limit-speed", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetSpeedRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<BatchSetSpeedResponse>(response);
        }

        public AsyncInvoker<BatchSetSpeedResponse> BatchSetSpeedAsyncInvoker(BatchSetSpeedRequest batchSetSpeedRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-limit-speed", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetSpeedRequest);
            return new AsyncInvoker<BatchSetSpeedResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchSetSpeedResponse>);
        }
        
        /// <summary>
        /// 批量获取数据库参数
        ///
        /// 在进行数据库迁移时，为了确保迁移成功后业务应用的使用不受影响，数据复制服务提供了参数对比功能帮助您进行源库和目标库参数一致性对比，此接口可以获取源库和目标库的数据库参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchShowParamsResponse> BatchShowParamsAsync(BatchShowParamsRequest batchShowParamsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-get-params", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchShowParamsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchShowParamsResponse>(response);
        }

        public AsyncInvoker<BatchShowParamsResponse> BatchShowParamsAsyncInvoker(BatchShowParamsRequest batchShowParamsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-get-params", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchShowParamsRequest);
            return new AsyncInvoker<BatchShowParamsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchShowParamsResponse>);
        }
        
        /// <summary>
        /// 批量启动任务
        ///
        /// 批量启动实时迁移、同步、灾备任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchStartJobsResponse> BatchStartJobsAsync(BatchStartJobsRequest batchStartJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-starting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchStartJobsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchStartJobsResponse>(response);
        }

        public AsyncInvoker<BatchStartJobsResponse> BatchStartJobsAsyncInvoker(BatchStartJobsRequest batchStartJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-starting", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchStartJobsRequest);
            return new AsyncInvoker<BatchStartJobsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchStartJobsResponse>);
        }
        
        /// <summary>
        /// 批量暂停任务
        ///
        /// 批量暂停任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchStopJobsResponse> BatchStopJobsAsync(BatchStopJobsRequest batchStopJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-pause-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchStopJobsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchStopJobsResponse>(response);
        }

        public AsyncInvoker<BatchStopJobsResponse> BatchStopJobsAsyncInvoker(BatchStopJobsRequest batchStopJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-pause-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchStopJobsRequest);
            return new AsyncInvoker<BatchStopJobsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchStopJobsResponse>);
        }
        
        /// <summary>
        /// 批量主备倒换
        ///
        /// 批量主备倒换。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchSwitchoverResponse> BatchSwitchoverAsync(BatchSwitchoverRequest batchSwitchoverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-switchover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSwitchoverRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchSwitchoverResponse>(response);
        }

        public AsyncInvoker<BatchSwitchoverResponse> BatchSwitchoverAsyncInvoker(BatchSwitchoverRequest batchSwitchoverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-switchover", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSwitchoverRequest);
            return new AsyncInvoker<BatchSwitchoverResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchSwitchoverResponse>);
        }
        
        /// <summary>
        /// 批量修改任务
        ///
        /// 批量修改任务名称或描述，设置异常通知信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUpdateJobResponse> BatchUpdateJobAsync(BatchUpdateJobRequest batchUpdateJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-modification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateJobRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<BatchUpdateJobResponse>(response);
        }

        public AsyncInvoker<BatchUpdateJobResponse> BatchUpdateJobAsyncInvoker(BatchUpdateJobRequest batchUpdateJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-modification", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateJobRequest);
            return new AsyncInvoker<BatchUpdateJobResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchUpdateJobResponse>);
        }
        
        /// <summary>
        /// 批量更新迁移用户信息
        ///
        /// 数据库的迁移过程中，迁移用户需要进行单独处理，该接口可以批量设置需要迁移的用户和角色。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUpdateUserResponse> BatchUpdateUserAsync(BatchUpdateUserRequest batchUpdateUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-update-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateUserRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<BatchUpdateUserResponse>(response);
        }

        public AsyncInvoker<BatchUpdateUserResponse> BatchUpdateUserAsyncInvoker(BatchUpdateUserRequest batchUpdateUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-update-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateUserRequest);
            return new AsyncInvoker<BatchUpdateUserResponse>(this, "PUT", request, JsonUtils.DeSerialize<BatchUpdateUserResponse>);
        }
        
        /// <summary>
        /// 批量测试连接-集群模式
        ///
        /// - 批量测试连接（集群模式）。
        /// - 主备任务测试连接
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchValidateClustersConnectionsResponse> BatchValidateClustersConnectionsAsync(BatchValidateClustersConnectionsRequest batchValidateClustersConnectionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/cluster/batch-connection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchValidateClustersConnectionsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchValidateClustersConnectionsResponse>(response);
        }

        public AsyncInvoker<BatchValidateClustersConnectionsResponse> BatchValidateClustersConnectionsAsyncInvoker(BatchValidateClustersConnectionsRequest batchValidateClustersConnectionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/cluster/batch-connection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchValidateClustersConnectionsRequest);
            return new AsyncInvoker<BatchValidateClustersConnectionsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchValidateClustersConnectionsResponse>);
        }
        
        /// <summary>
        /// 批量测试连接
        ///
        /// 批量测试连接。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchValidateConnectionsResponse> BatchValidateConnectionsAsync(BatchValidateConnectionsRequest batchValidateConnectionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-connection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchValidateConnectionsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchValidateConnectionsResponse>(response);
        }

        public AsyncInvoker<BatchValidateConnectionsResponse> BatchValidateConnectionsAsyncInvoker(BatchValidateConnectionsRequest batchValidateConnectionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-connection", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchValidateConnectionsRequest);
            return new AsyncInvoker<BatchValidateConnectionsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchValidateConnectionsResponse>);
        }
        
        /// <summary>
        /// 导出对比任务结果文件
        ///
        /// 导出对比任务结果文件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateCompareResultFileResponse> CreateCompareResultFileAsync(CreateCompareResultFileRequest createCompareResultFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createCompareResultFileRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/compare/result/file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCompareResultFileRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateCompareResultFileResponse>(response);
        }

        public AsyncInvoker<CreateCompareResultFileResponse> CreateCompareResultFileAsyncInvoker(CreateCompareResultFileRequest createCompareResultFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createCompareResultFileRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/compare/result/file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCompareResultFileRequest);
            return new AsyncInvoker<CreateCompareResultFileResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCompareResultFileResponse>);
        }
        
        /// <summary>
        /// 创建对比任务
        ///
        /// 创建对比任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateCompareTaskResponse> CreateCompareTaskAsync(CreateCompareTaskRequest createCompareTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/create-compare-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCompareTaskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateCompareTaskResponse>(response);
        }

        public AsyncInvoker<CreateCompareTaskResponse> CreateCompareTaskAsyncInvoker(CreateCompareTaskRequest createCompareTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/create-compare-task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCompareTaskRequest);
            return new AsyncInvoker<CreateCompareTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCompareTaskResponse>);
        }
        
        /// <summary>
        /// 创建数据级表对比任务
        ///
        /// 创建数据级表对比任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDataLevelTableCompareJobResponse> CreateDataLevelTableCompareJobAsync(CreateDataLevelTableCompareJobRequest createDataLevelTableCompareJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createDataLevelTableCompareJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/table/compare", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDataLevelTableCompareJobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDataLevelTableCompareJobResponse>(response);
        }

        public AsyncInvoker<CreateDataLevelTableCompareJobResponse> CreateDataLevelTableCompareJobAsyncInvoker(CreateDataLevelTableCompareJobRequest createDataLevelTableCompareJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createDataLevelTableCompareJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/table/compare", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDataLevelTableCompareJobRequest);
            return new AsyncInvoker<CreateDataLevelTableCompareJobResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDataLevelTableCompareJobResponse>);
        }
        
        /// <summary>
        /// 创建对象级对比任务
        ///
        /// 创建对象级对比任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateObjectLevelCompareJobResponse> CreateObjectLevelCompareJobAsync(CreateObjectLevelCompareJobRequest createObjectLevelCompareJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createObjectLevelCompareJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/object/compare", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createObjectLevelCompareJobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateObjectLevelCompareJobResponse>(response);
        }

        public AsyncInvoker<CreateObjectLevelCompareJobResponse> CreateObjectLevelCompareJobAsyncInvoker(CreateObjectLevelCompareJobRequest createObjectLevelCompareJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createObjectLevelCompareJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/object/compare", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createObjectLevelCompareJobRequest);
            return new AsyncInvoker<CreateObjectLevelCompareJobResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateObjectLevelCompareJobResponse>);
        }
        
        /// <summary>
        /// 取消对比任务
        ///
        /// 取消对比任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteCompareJobResponse> DeleteCompareJobAsync(DeleteCompareJobRequest deleteCompareJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteCompareJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            if (StringUtils.TryConvertToNonEmptyString(deleteCompareJobRequest.CompareJobId, out var valueOfCompareJobId)) urlParam.Add("compare_job_id", valueOfCompareJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/compare/{compare_job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCompareJobRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteCompareJobResponse>(response);
        }

        public AsyncInvoker<DeleteCompareJobResponse> DeleteCompareJobAsyncInvoker(DeleteCompareJobRequest deleteCompareJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteCompareJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            if (StringUtils.TryConvertToNonEmptyString(deleteCompareJobRequest.CompareJobId, out var valueOfCompareJobId)) urlParam.Add("compare_job_id", valueOfCompareJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/compare/{compare_job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCompareJobRequest);
            return new AsyncInvoker<DeleteCompareJobResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteCompareJobResponse>);
        }
        
        /// <summary>
        /// 下载对比任务结果文件
        ///
        /// 下载对比任务结果文件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DownloadCompareResultFileResponse> DownloadCompareResultFileAsync(DownloadCompareResultFileRequest downloadCompareResultFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadCompareResultFileRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/compare/result/file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadCompareResultFileRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<DownloadCompareResultFileResponse>(response);
        }

        public AsyncInvoker<DownloadCompareResultFileResponse> DownloadCompareResultFileAsyncInvoker(DownloadCompareResultFileRequest downloadCompareResultFileRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(downloadCompareResultFileRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/compare/result/file", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadCompareResultFileRequest);
            return new AsyncInvoker<DownloadCompareResultFileResponse>(this, "GET", request, JsonUtils.DeSerialize<DownloadCompareResultFileResponse>);
        }
        
        /// <summary>
        /// 查询可用的Node规格
        ///
        /// 查询可用的Node规格。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAvailableNodeTypesResponse> ListAvailableNodeTypesAsync(ListAvailableNodeTypesRequest listAvailableNodeTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/node-type", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableNodeTypesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAvailableNodeTypesResponse>(response);
        }

        public AsyncInvoker<ListAvailableNodeTypesResponse> ListAvailableNodeTypesAsyncInvoker(ListAvailableNodeTypesRequest listAvailableNodeTypesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/node-type", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableNodeTypesRequest);
            return new AsyncInvoker<ListAvailableNodeTypesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAvailableNodeTypesResponse>);
        }
        
        /// <summary>
        /// 查询规格未售罄的可用区
        ///
        /// 查询规格未售罄的可用区
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAvailableZoneResponse> ListAvailableZoneAsync(ListAvailableZoneRequest listAvailableZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/available-zone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableZoneRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListAvailableZoneResponse>(response);
        }

        public AsyncInvoker<ListAvailableZoneResponse> ListAvailableZoneAsyncInvoker(ListAvailableZoneRequest listAvailableZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/available-zone", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableZoneRequest);
            return new AsyncInvoker<ListAvailableZoneResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAvailableZoneResponse>);
        }
        
        /// <summary>
        /// 查询对比结果
        ///
        /// 查询对比结果。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCompareResultResponse> ListCompareResultAsync(ListCompareResultRequest listCompareResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/query-compare-result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCompareResultRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListCompareResultResponse>(response);
        }

        public AsyncInvoker<ListCompareResultResponse> ListCompareResultAsyncInvoker(ListCompareResultRequest listCompareResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/query-compare-result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCompareResultRequest);
            return new AsyncInvoker<ListCompareResultResponse>(this, "POST", request, JsonUtils.DeSerialize<ListCompareResultResponse>);
        }
        
        /// <summary>
        /// 查询内容对比详情
        ///
        /// 查询内容对比详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListContentCompareDetailResponse> ListContentCompareDetailAsync(ListContentCompareDetailRequest listContentCompareDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listContentCompareDetailRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            if (StringUtils.TryConvertToNonEmptyString(listContentCompareDetailRequest.CompareJobId, out var valueOfCompareJobId)) urlParam.Add("compare_job_id", valueOfCompareJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/compare/{compare_job_id}/content-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listContentCompareDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListContentCompareDetailResponse>(response);
        }

        public AsyncInvoker<ListContentCompareDetailResponse> ListContentCompareDetailAsyncInvoker(ListContentCompareDetailRequest listContentCompareDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listContentCompareDetailRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            if (StringUtils.TryConvertToNonEmptyString(listContentCompareDetailRequest.CompareJobId, out var valueOfCompareJobId)) urlParam.Add("compare_job_id", valueOfCompareJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/compare/{compare_job_id}/content-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listContentCompareDetailRequest);
            return new AsyncInvoker<ListContentCompareDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListContentCompareDetailResponse>);
        }
        
        /// <summary>
        /// 查询内容对比差异
        ///
        /// 查询内容对比差异。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListContentCompareDifferenceResponse> ListContentCompareDifferenceAsync(ListContentCompareDifferenceRequest listContentCompareDifferenceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listContentCompareDifferenceRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            if (StringUtils.TryConvertToNonEmptyString(listContentCompareDifferenceRequest.CompareJobId, out var valueOfCompareJobId)) urlParam.Add("compare_job_id", valueOfCompareJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/compare/{compare_job_id}/content-difference", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listContentCompareDifferenceRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListContentCompareDifferenceResponse>(response);
        }

        public AsyncInvoker<ListContentCompareDifferenceResponse> ListContentCompareDifferenceAsyncInvoker(ListContentCompareDifferenceRequest listContentCompareDifferenceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listContentCompareDifferenceRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            if (StringUtils.TryConvertToNonEmptyString(listContentCompareDifferenceRequest.CompareJobId, out var valueOfCompareJobId)) urlParam.Add("compare_job_id", valueOfCompareJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/compare/{compare_job_id}/content-difference", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listContentCompareDifferenceRequest);
            return new AsyncInvoker<ListContentCompareDifferenceResponse>(this, "GET", request, JsonUtils.DeSerialize<ListContentCompareDifferenceResponse>);
        }
        
        /// <summary>
        /// 查询内容对比总览
        ///
        /// 查询内容对比总览。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListContentCompareOverviewResponse> ListContentCompareOverviewAsync(ListContentCompareOverviewRequest listContentCompareOverviewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listContentCompareOverviewRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            if (StringUtils.TryConvertToNonEmptyString(listContentCompareOverviewRequest.CompareJobId, out var valueOfCompareJobId)) urlParam.Add("compare_job_id", valueOfCompareJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/compare/{compare_job_id}/content-overview", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listContentCompareOverviewRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListContentCompareOverviewResponse>(response);
        }

        public AsyncInvoker<ListContentCompareOverviewResponse> ListContentCompareOverviewAsyncInvoker(ListContentCompareOverviewRequest listContentCompareOverviewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listContentCompareOverviewRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            if (StringUtils.TryConvertToNonEmptyString(listContentCompareOverviewRequest.CompareJobId, out var valueOfCompareJobId)) urlParam.Add("compare_job_id", valueOfCompareJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/compare/{compare_job_id}/content-overview", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listContentCompareOverviewRequest);
            return new AsyncInvoker<ListContentCompareOverviewResponse>(this, "GET", request, JsonUtils.DeSerialize<ListContentCompareOverviewResponse>);
        }
        
        /// <summary>
        /// 查询行数对比详情
        ///
        /// 查询行数对比详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDataCompareDetailResponse> ListDataCompareDetailAsync(ListDataCompareDetailRequest listDataCompareDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDataCompareDetailRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            if (StringUtils.TryConvertToNonEmptyString(listDataCompareDetailRequest.CompareJobId, out var valueOfCompareJobId)) urlParam.Add("compare_job_id", valueOfCompareJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/compare/{compare_job_id}/line-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDataCompareDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDataCompareDetailResponse>(response);
        }

        public AsyncInvoker<ListDataCompareDetailResponse> ListDataCompareDetailAsyncInvoker(ListDataCompareDetailRequest listDataCompareDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDataCompareDetailRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            if (StringUtils.TryConvertToNonEmptyString(listDataCompareDetailRequest.CompareJobId, out var valueOfCompareJobId)) urlParam.Add("compare_job_id", valueOfCompareJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/compare/{compare_job_id}/line-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDataCompareDetailRequest);
            return new AsyncInvoker<ListDataCompareDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDataCompareDetailResponse>);
        }
        
        /// <summary>
        /// 查询行数对比总览
        ///
        /// 查询行数对比总览。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDataCompareOverviewResponse> ListDataCompareOverviewAsync(ListDataCompareOverviewRequest listDataCompareOverviewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDataCompareOverviewRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            if (StringUtils.TryConvertToNonEmptyString(listDataCompareOverviewRequest.CompareJobId, out var valueOfCompareJobId)) urlParam.Add("compare_job_id", valueOfCompareJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/compare/{compare_job_id}/line-overview", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDataCompareOverviewRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDataCompareOverviewResponse>(response);
        }

        public AsyncInvoker<ListDataCompareOverviewResponse> ListDataCompareOverviewAsyncInvoker(ListDataCompareOverviewRequest listDataCompareOverviewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDataCompareOverviewRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            if (StringUtils.TryConvertToNonEmptyString(listDataCompareOverviewRequest.CompareJobId, out var valueOfCompareJobId)) urlParam.Add("compare_job_id", valueOfCompareJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/compare/{compare_job_id}/line-overview", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDataCompareOverviewRequest);
            return new AsyncInvoker<ListDataCompareOverviewResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDataCompareOverviewResponse>);
        }
        
        /// <summary>
        /// 查询数据级表对比任务列表
        ///
        /// 查询数据级表对比任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDataLevelTableCompareJobsResponse> ListDataLevelTableCompareJobsAsync(ListDataLevelTableCompareJobsRequest listDataLevelTableCompareJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDataLevelTableCompareJobsRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/table/compare", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDataLevelTableCompareJobsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDataLevelTableCompareJobsResponse>(response);
        }

        public AsyncInvoker<ListDataLevelTableCompareJobsResponse> ListDataLevelTableCompareJobsAsyncInvoker(ListDataLevelTableCompareJobsRequest listDataLevelTableCompareJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDataLevelTableCompareJobsRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/table/compare", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDataLevelTableCompareJobsRequest);
            return new AsyncInvoker<ListDataLevelTableCompareJobsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDataLevelTableCompareJobsResponse>);
        }
        
        /// <summary>
        /// 查询对象对比任务详情
        ///
        /// 查询对象对比任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListObejectLevelCompareDetailResponse> ListObejectLevelCompareDetailAsync(ListObejectLevelCompareDetailRequest listObejectLevelCompareDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listObejectLevelCompareDetailRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            if (StringUtils.TryConvertToNonEmptyString(listObejectLevelCompareDetailRequest.CompareType, out var valueOfCompareType)) urlParam.Add("compare_type", valueOfCompareType);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/object/compare/{compare_type}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listObejectLevelCompareDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListObejectLevelCompareDetailResponse>(response);
        }

        public AsyncInvoker<ListObejectLevelCompareDetailResponse> ListObejectLevelCompareDetailAsyncInvoker(ListObejectLevelCompareDetailRequest listObejectLevelCompareDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listObejectLevelCompareDetailRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            if (StringUtils.TryConvertToNonEmptyString(listObejectLevelCompareDetailRequest.CompareType, out var valueOfCompareType)) urlParam.Add("compare_type", valueOfCompareType);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/object/compare/{compare_type}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listObejectLevelCompareDetailRequest);
            return new AsyncInvoker<ListObejectLevelCompareDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ListObejectLevelCompareDetailResponse>);
        }
        
        /// <summary>
        /// 查询对象对比任务概览
        ///
        /// 查询对象对比任务概览。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListObejectLevelCompareOverviewResponse> ListObejectLevelCompareOverviewAsync(ListObejectLevelCompareOverviewRequest listObejectLevelCompareOverviewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listObejectLevelCompareOverviewRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/object/compare", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listObejectLevelCompareOverviewRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListObejectLevelCompareOverviewResponse>(response);
        }

        public AsyncInvoker<ListObejectLevelCompareOverviewResponse> ListObejectLevelCompareOverviewAsyncInvoker(ListObejectLevelCompareOverviewRequest listObejectLevelCompareOverviewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listObejectLevelCompareOverviewRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/object/compare", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listObejectLevelCompareOverviewRequest);
            return new AsyncInvoker<ListObejectLevelCompareOverviewResponse>(this, "GET", request, JsonUtils.DeSerialize<ListObejectLevelCompareOverviewResponse>);
        }
        
        /// <summary>
        /// 获取源库迁移用户列表
        ///
        /// 数据库的迁移过程中，迁移用户需要进行单独处理，该接口可以查询源库的用户信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListUsersResponse> ListUsersAsync(ListUsersRequest listUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUsersRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/get-src-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListUsersResponse>(response);
        }

        public AsyncInvoker<ListUsersResponse> ListUsersAsyncInvoker(ListUsersRequest listUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listUsersRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/get-src-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersRequest);
            return new AsyncInvoker<ListUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUsersResponse>);
        }
        
        /// <summary>
        /// 更新LTS配置
        ///
        /// 更新任务的LTS配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ModifyGroupAndStreamResponse> ModifyGroupAndStreamAsync(ModifyGroupAndStreamRequest modifyGroupAndStreamRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(modifyGroupAndStreamRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/lts-log-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyGroupAndStreamRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ModifyGroupAndStreamResponse>(response);
        }

        public AsyncInvoker<ModifyGroupAndStreamResponse> ModifyGroupAndStreamAsyncInvoker(ModifyGroupAndStreamRequest modifyGroupAndStreamRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(modifyGroupAndStreamRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/lts-log-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyGroupAndStreamRequest);
            return new AsyncInvoker<ModifyGroupAndStreamResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyGroupAndStreamResponse>);
        }
        
        /// <summary>
        /// 查询高级设置参数
        ///
        /// 查询高级设置参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<QueryTuningParamsResponse> QueryTuningParamsAsync(QueryTuningParamsRequest queryTuningParamsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(queryTuningParamsRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/job/{job_id}/tuning-params/query-params", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", queryTuningParamsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<QueryTuningParamsResponse>(response);
        }

        public AsyncInvoker<QueryTuningParamsResponse> QueryTuningParamsAsyncInvoker(QueryTuningParamsRequest queryTuningParamsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(queryTuningParamsRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/job/{job_id}/tuning-params/query-params", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", queryTuningParamsRequest);
            return new AsyncInvoker<QueryTuningParamsResponse>(this, "GET", request, JsonUtils.DeSerialize<QueryTuningParamsResponse>);
        }
        
        /// <summary>
        /// 查询LTS配置
        ///
        /// 查询任务的LTS配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SelectGroupAndStreamResponse> SelectGroupAndStreamAsync(SelectGroupAndStreamRequest selectGroupAndStreamRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(selectGroupAndStreamRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/lts-log-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", selectGroupAndStreamRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<SelectGroupAndStreamResponse>(response);
        }

        public AsyncInvoker<SelectGroupAndStreamResponse> SelectGroupAndStreamAsyncInvoker(SelectGroupAndStreamRequest selectGroupAndStreamRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(selectGroupAndStreamRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/lts-log-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", selectGroupAndStreamRequest);
            return new AsyncInvoker<SelectGroupAndStreamResponse>(this, "GET", request, JsonUtils.DeSerialize<SelectGroupAndStreamResponse>);
        }
        
        /// <summary>
        /// 查询租户任务列表
        ///
        /// 查询租户任务列表，可以根据引擎类型，网络类型，任务状态，任务名称，任务ID进行查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowJobListResponse> ShowJobListAsync(ShowJobListRequest showJobListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobListRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShowJobListResponse>(response);
        }

        public AsyncInvoker<ShowJobListResponse> ShowJobListAsyncInvoker(ShowJobListRequest showJobListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobListRequest);
            return new AsyncInvoker<ShowJobListResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowJobListResponse>);
        }
        
        /// <summary>
        /// 查询容灾监控数据
        ///
        /// 根据任务ID查询容灾监控数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowMonitoringDataResponse> ShowMonitoringDataAsync(ShowMonitoringDataRequest showMonitoringDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/disaster-recovery-monitoring-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMonitoringDataRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShowMonitoringDataResponse>(response);
        }

        public AsyncInvoker<ShowMonitoringDataResponse> ShowMonitoringDataAsyncInvoker(ShowMonitoringDataRequest showMonitoringDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/disaster-recovery-monitoring-data", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMonitoringDataRequest);
            return new AsyncInvoker<ShowMonitoringDataResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowMonitoringDataResponse>);
        }
        
        /// <summary>
        /// 查询配额
        ///
        /// 查询单租户在某一项目下DRS服务下的配额信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowQuotasResponse> ShowQuotasAsync(ShowQuotasRequest showQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotasRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowQuotasResponse>(response);
        }

        public AsyncInvoker<ShowQuotasResponse> ShowQuotasAsyncInvoker(ShowQuotasRequest showQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotasRequest);
            return new AsyncInvoker<ShowQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowQuotasResponse>);
        }
        
        /// <summary>
        /// 立即启动数据级表对比任务
        ///
        /// 立即启动数据级表对比任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StartPromptlyDataLevelTableCompareJobResponse> StartPromptlyDataLevelTableCompareJobAsync(StartPromptlyDataLevelTableCompareJobRequest startPromptlyDataLevelTableCompareJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startPromptlyDataLevelTableCompareJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            if (StringUtils.TryConvertToNonEmptyString(startPromptlyDataLevelTableCompareJobRequest.CompareJobId, out var valueOfCompareJobId)) urlParam.Add("compare_job_id", valueOfCompareJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/table/compare/{compare_job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startPromptlyDataLevelTableCompareJobRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StartPromptlyDataLevelTableCompareJobResponse>(response);
        }

        public AsyncInvoker<StartPromptlyDataLevelTableCompareJobResponse> StartPromptlyDataLevelTableCompareJobAsyncInvoker(StartPromptlyDataLevelTableCompareJobRequest startPromptlyDataLevelTableCompareJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startPromptlyDataLevelTableCompareJobRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            if (StringUtils.TryConvertToNonEmptyString(startPromptlyDataLevelTableCompareJobRequest.CompareJobId, out var valueOfCompareJobId)) urlParam.Add("compare_job_id", valueOfCompareJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/table/compare/{compare_job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startPromptlyDataLevelTableCompareJobRequest);
            return new AsyncInvoker<StartPromptlyDataLevelTableCompareJobResponse>(this, "POST", request, JsonUtils.DeSerialize<StartPromptlyDataLevelTableCompareJobResponse>);
        }
        
        /// <summary>
        /// 修改数据库参数
        ///
        /// 修改数据库参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateParamsResponse> UpdateParamsAsync(UpdateParamsRequest updateParamsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateParamsRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/params", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateParamsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdateParamsResponse>(response);
        }

        public AsyncInvoker<UpdateParamsResponse> UpdateParamsAsyncInvoker(UpdateParamsRequest updateParamsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateParamsRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/params", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateParamsRequest);
            return new AsyncInvoker<UpdateParamsResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdateParamsResponse>);
        }
        
        /// <summary>
        /// 高级设置
        ///
        /// 修改调优参数的值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateTuningParamsResponse> UpdateTuningParamsAsync(UpdateTuningParamsRequest updateTuningParamsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTuningParamsRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/job/{job_id}/tuning-params/modify-params", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTuningParamsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateTuningParamsResponse>(response);
        }

        public AsyncInvoker<UpdateTuningParamsResponse> UpdateTuningParamsAsyncInvoker(UpdateTuningParamsRequest updateTuningParamsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTuningParamsRequest.JobId, out var valueOfJobId)) urlParam.Add("job_id", valueOfJobId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/job/{job_id}/tuning-params/modify-params", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTuningParamsRequest);
            return new AsyncInvoker<UpdateTuningParamsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateTuningParamsResponse>);
        }
        
    }
}