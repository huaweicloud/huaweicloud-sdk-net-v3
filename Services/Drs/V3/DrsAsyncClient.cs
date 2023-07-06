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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-transformation",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchChangeDataRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchChangeDataResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-precheck",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCheckJobsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchCheckJobsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-precheck-result",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCheckResultsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchCheckResultsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-creation",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateJobsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchCreateJobsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteJobsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<BatchDeleteJobsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListJobDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchListJobDetailsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-status",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListJobStatusRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchListJobStatusResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-progress",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListProgressesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchListProgressesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-rpo-and-rto",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListRposAndRtosRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchListRposAndRtosResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("type" , batchListStructDetailRequest.Type.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{type}/batch-struct-detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListStructDetailRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchListStructDetailResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-struct-process",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchListStructProcessRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchListStructProcessResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-modify-pwd",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchResetPasswordRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<BatchResetPasswordResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-retry-task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchRestoreTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchRestoreTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-replace-definer",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetDefinerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchSetDefinerResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-select-objects",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetObjectsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<BatchSetObjectsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-sync-policy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchSetPolicyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-set-smn",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetSmnRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchSetSmnResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-limit-speed",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSetSpeedRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<BatchSetSpeedResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-get-params",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchShowParamsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchShowParamsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-starting",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchStartJobsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchStartJobsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-pause-task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchStopJobsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchStopJobsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-switchover",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchSwitchoverRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchSwitchoverResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-modification",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<BatchUpdateJobResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-update-user",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateUserRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<BatchUpdateUserResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/cluster/batch-connection",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchValidateClustersConnectionsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchValidateClustersConnectionsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/batch-connection",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchValidateConnectionsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchValidateConnectionsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/create-compare-task",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCompareTaskRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateCompareTaskResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/available-zone",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailableZoneRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListAvailableZoneResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/query-compare-result",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCompareResultRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListCompareResultResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , listUsersRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/get-src-user",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listUsersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListUsersResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobListRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ShowJobListResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/disaster-recovery-monitoring-data",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMonitoringDataRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ShowMonitoringDataResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotasRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowQuotasResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , updateParamsRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/jobs/{job_id}/params",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateParamsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<UpdateParamsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , updateTuningParamsRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/job/{job_id}/tuning-params/modify-params",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTuningParamsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateTuningParamsResponse>(response);
        }
        
    }
}