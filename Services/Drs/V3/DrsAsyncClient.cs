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
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-transformation",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchChangeDataRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchChangeDataResponse>(response);
        }

        public AsyncInvoker<BatchChangeDataResponse> BatchChangeDataAsyncInvoker(BatchChangeDataRequest batchChangeDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-transformation",urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-precheck",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCheckJobsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchCheckJobsResponse>(response);
        }

        public AsyncInvoker<BatchCheckJobsResponse> BatchCheckJobsAsyncInvoker(BatchCheckJobsRequest batchCheckJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-precheck",urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-precheck-result",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCheckResultsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchCheckResultsResponse>(response);
        }

        public AsyncInvoker<BatchCheckResultsResponse> BatchCheckResultsAsyncInvoker(BatchCheckResultsRequest batchCheckResultsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-precheck-result",urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-creation",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateJobsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchCreateJobsResponse>(response);
        }

        public AsyncInvoker<BatchCreateJobsResponse> BatchCreateJobsAsyncInvoker(BatchCreateJobsRequest batchCreateJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-creation",urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-jobs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteJobsRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<BatchDeleteJobsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteJobsResponse> BatchDeleteJobsAsyncInvoker(BatchDeleteJobsRequest batchDeleteJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-jobs",urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-detail",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListJobDetailsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchListJobDetailsResponse>(response);
        }

        public AsyncInvoker<BatchListJobDetailsResponse> BatchListJobDetailsAsyncInvoker(BatchListJobDetailsRequest batchListJobDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-detail",urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-status",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListJobStatusRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchListJobStatusResponse>(response);
        }

        public AsyncInvoker<BatchListJobStatusResponse> BatchListJobStatusAsyncInvoker(BatchListJobStatusRequest batchListJobStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-status",urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-progress",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListProgressesRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchListProgressesResponse>(response);
        }

        public AsyncInvoker<BatchListProgressesResponse> BatchListProgressesAsyncInvoker(BatchListProgressesRequest batchListProgressesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-progress",urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-rpo-and-rto",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListRposAndRtosRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchListRposAndRtosResponse>(response);
        }

        public AsyncInvoker<BatchListRposAndRtosResponse> BatchListRposAndRtosAsyncInvoker(BatchListRposAndRtosRequest batchListRposAndRtosRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-rpo-and-rto",urlParam);
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
            urlParam.Add("type", batchListStructDetailRequest.Type.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{type}/batch-struct-detail",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListStructDetailRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchListStructDetailResponse>(response);
        }

        public AsyncInvoker<BatchListStructDetailResponse> BatchListStructDetailAsyncInvoker(BatchListStructDetailRequest batchListStructDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("type", batchListStructDetailRequest.Type.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{type}/batch-struct-detail",urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-struct-process",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListStructProcessRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchListStructProcessResponse>(response);
        }

        public AsyncInvoker<BatchListStructProcessResponse> BatchListStructProcessAsyncInvoker(BatchListStructProcessRequest batchListStructProcessRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-struct-process",urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-modify-pwd",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchResetPasswordRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<BatchResetPasswordResponse>(response);
        }

        public AsyncInvoker<BatchResetPasswordResponse> BatchResetPasswordAsyncInvoker(BatchResetPasswordRequest batchResetPasswordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-modify-pwd",urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-retry-task",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRestoreTaskRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchRestoreTaskResponse>(response);
        }

        public AsyncInvoker<BatchRestoreTaskResponse> BatchRestoreTaskAsyncInvoker(BatchRestoreTaskRequest batchRestoreTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-retry-task",urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-replace-definer",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetDefinerRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchSetDefinerResponse>(response);
        }

        public AsyncInvoker<BatchSetDefinerResponse> BatchSetDefinerAsyncInvoker(BatchSetDefinerRequest batchSetDefinerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-replace-definer",urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-select-objects",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetObjectsRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<BatchSetObjectsResponse>(response);
        }

        public AsyncInvoker<BatchSetObjectsResponse> BatchSetObjectsAsyncInvoker(BatchSetObjectsRequest batchSetObjectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-select-objects",urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-sync-policy",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetPolicyRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchSetPolicyResponse>(response);
        }

        public AsyncInvoker<BatchSetPolicyResponse> BatchSetPolicyAsyncInvoker(BatchSetPolicyRequest batchSetPolicyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-sync-policy",urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-set-smn",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetSmnRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchSetSmnResponse>(response);
        }

        public AsyncInvoker<BatchSetSmnResponse> BatchSetSmnAsyncInvoker(BatchSetSmnRequest batchSetSmnRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-set-smn",urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-limit-speed",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetSpeedRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<BatchSetSpeedResponse>(response);
        }

        public AsyncInvoker<BatchSetSpeedResponse> BatchSetSpeedAsyncInvoker(BatchSetSpeedRequest batchSetSpeedRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-limit-speed",urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-get-params",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchShowParamsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchShowParamsResponse>(response);
        }

        public AsyncInvoker<BatchShowParamsResponse> BatchShowParamsAsyncInvoker(BatchShowParamsRequest batchShowParamsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-get-params",urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-starting",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchStartJobsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchStartJobsResponse>(response);
        }

        public AsyncInvoker<BatchStartJobsResponse> BatchStartJobsAsyncInvoker(BatchStartJobsRequest batchStartJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-starting",urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-pause-task",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchStopJobsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchStopJobsResponse>(response);
        }

        public AsyncInvoker<BatchStopJobsResponse> BatchStopJobsAsyncInvoker(BatchStopJobsRequest batchStopJobsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-pause-task",urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-switchover",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSwitchoverRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchSwitchoverResponse>(response);
        }

        public AsyncInvoker<BatchSwitchoverResponse> BatchSwitchoverAsyncInvoker(BatchSwitchoverRequest batchSwitchoverRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-switchover",urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-modification",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateJobRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<BatchUpdateJobResponse>(response);
        }

        public AsyncInvoker<BatchUpdateJobResponse> BatchUpdateJobAsyncInvoker(BatchUpdateJobRequest batchUpdateJobRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-modification",urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-update-user",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateUserRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<BatchUpdateUserResponse>(response);
        }

        public AsyncInvoker<BatchUpdateUserResponse> BatchUpdateUserAsyncInvoker(BatchUpdateUserRequest batchUpdateUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-update-user",urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/cluster/batch-connection",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchValidateClustersConnectionsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchValidateClustersConnectionsResponse>(response);
        }

        public AsyncInvoker<BatchValidateClustersConnectionsResponse> BatchValidateClustersConnectionsAsyncInvoker(BatchValidateClustersConnectionsRequest batchValidateClustersConnectionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/cluster/batch-connection",urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-connection",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchValidateConnectionsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchValidateConnectionsResponse>(response);
        }

        public AsyncInvoker<BatchValidateConnectionsResponse> BatchValidateConnectionsAsyncInvoker(BatchValidateConnectionsRequest batchValidateConnectionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-connection",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchValidateConnectionsRequest);
            return new AsyncInvoker<BatchValidateConnectionsResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchValidateConnectionsResponse>);
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
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/create-compare-task",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCompareTaskRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateCompareTaskResponse>(response);
        }

        public AsyncInvoker<CreateCompareTaskResponse> CreateCompareTaskAsyncInvoker(CreateCompareTaskRequest createCompareTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/create-compare-task",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCompareTaskRequest);
            return new AsyncInvoker<CreateCompareTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCompareTaskResponse>);
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
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/available-zone",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableZoneRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListAvailableZoneResponse>(response);
        }

        public AsyncInvoker<ListAvailableZoneResponse> ListAvailableZoneAsyncInvoker(ListAvailableZoneRequest listAvailableZoneRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/available-zone",urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/query-compare-result",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCompareResultRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListCompareResultResponse>(response);
        }

        public AsyncInvoker<ListCompareResultResponse> ListCompareResultAsyncInvoker(ListCompareResultRequest listCompareResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/query-compare-result",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCompareResultRequest);
            return new AsyncInvoker<ListCompareResultResponse>(this, "POST", request, JsonUtils.DeSerialize<ListCompareResultResponse>);
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
            urlParam.Add("job_id", listUsersRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/get-src-user",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListUsersResponse>(response);
        }

        public AsyncInvoker<ListUsersResponse> ListUsersAsyncInvoker(ListUsersRequest listUsersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listUsersRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/get-src-user",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersRequest);
            return new AsyncInvoker<ListUsersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListUsersResponse>);
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
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobListRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ShowJobListResponse>(response);
        }

        public AsyncInvoker<ShowJobListResponse> ShowJobListAsyncInvoker(ShowJobListRequest showJobListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs",urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/disaster-recovery-monitoring-data",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMonitoringDataRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ShowMonitoringDataResponse>(response);
        }

        public AsyncInvoker<ShowMonitoringDataResponse> ShowMonitoringDataAsyncInvoker(ShowMonitoringDataRequest showMonitoringDataRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/disaster-recovery-monitoring-data",urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/quotas",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotasRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowQuotasResponse>(response);
        }

        public AsyncInvoker<ShowQuotasResponse> ShowQuotasAsyncInvoker(ShowQuotasRequest showQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/quotas",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotasRequest);
            return new AsyncInvoker<ShowQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowQuotasResponse>);
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
            urlParam.Add("job_id", updateParamsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/params",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateParamsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<UpdateParamsResponse>(response);
        }

        public AsyncInvoker<UpdateParamsResponse> UpdateParamsAsyncInvoker(UpdateParamsRequest updateParamsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", updateParamsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/params",urlParam);
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
            urlParam.Add("job_id", updateTuningParamsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/job/{job_id}/tuning-params/modify-params",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTuningParamsRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateTuningParamsResponse>(response);
        }

        public AsyncInvoker<UpdateTuningParamsResponse> UpdateTuningParamsAsyncInvoker(UpdateTuningParamsRequest updateTuningParamsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", updateTuningParamsRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/job/{job_id}/tuning-params/modify-params",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTuningParamsRequest);
            return new AsyncInvoker<UpdateTuningParamsResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateTuningParamsResponse>);
        }
        
    }
}