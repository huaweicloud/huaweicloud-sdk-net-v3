using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.CodeArtsCheck.V2.Model;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2
{
    public partial class CodeArtsCheckAsyncClient : Client
    {
        public static ClientBuilder<CodeArtsCheckAsyncClient> NewBuilder()
        {
            return new ClientBuilder<CodeArtsCheckAsyncClient>();
        }

        
        /// <summary>
        /// 查询任务规则集的检查参数
        ///
        /// 查询任务规则集的检查参数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckParametersResponse> CheckParametersAsync(CheckParametersRequest checkParametersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkParametersRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(checkParametersRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            if (StringUtils.TryConvertToNonEmptyString(checkParametersRequest.RulesetId, out var valueOfRulesetId)) urlParam.Add("ruleset_id", valueOfRulesetId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/ruleset/{ruleset_id}/check-parameters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkParametersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var checkParametersResponse = JsonUtils.DeSerializeNull<CheckParametersResponse>(response);
            checkParametersResponse.Body = JsonUtils.DeSerializeList<TaskCheckParamters>(response);
            return checkParametersResponse;
        }

        public AsyncInvoker<CheckParametersResponse> CheckParametersAsyncInvoker(CheckParametersRequest checkParametersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkParametersRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(checkParametersRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            if (StringUtils.TryConvertToNonEmptyString(checkParametersRequest.RulesetId, out var valueOfRulesetId)) urlParam.Add("ruleset_id", valueOfRulesetId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/ruleset/{ruleset_id}/check-parameters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkParametersRequest);
            return new AsyncInvoker<CheckParametersResponse>(this, "GET", request, response =>
            {
                var checkParametersResponse = JsonUtils.DeSerializeNull<CheckParametersResponse>(response);
                checkParametersResponse.Body = JsonUtils.DeSerializeList<TaskCheckParamters>(response);
                return checkParametersResponse;
            });
        }
        
        /// <summary>
        /// 历史扫描结果查询
        ///
        /// 提供每次扫描的问题数量统计
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckRecordResponse> CheckRecordAsync(CheckRecordRequest checkRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkRecordRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(checkRecordRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/checkrecord", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkRecordRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<CheckRecordResponse>(response);
        }

        public AsyncInvoker<CheckRecordResponse> CheckRecordAsyncInvoker(CheckRecordRequest checkRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkRecordRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(checkRecordRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/checkrecord", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkRecordRequest);
            return new AsyncInvoker<CheckRecordResponse>(this, "GET", request, JsonUtils.DeSerialize<CheckRecordResponse>);
        }
        
        /// <summary>
        /// 查询任务规则集的检查参数
        ///
        /// 查询任务规则集的检查参数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CheckRulesetParametersResponse> CheckRulesetParametersAsync(CheckRulesetParametersRequest checkRulesetParametersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkRulesetParametersRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(checkRulesetParametersRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            if (StringUtils.TryConvertToNonEmptyString(checkRulesetParametersRequest.RulesetId, out var valueOfRulesetId)) urlParam.Add("ruleset_id", valueOfRulesetId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tasks/{task_id}/ruleset/{ruleset_id}/check-parameters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkRulesetParametersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<CheckRulesetParametersResponse>(response);
        }

        public AsyncInvoker<CheckRulesetParametersResponse> CheckRulesetParametersAsyncInvoker(CheckRulesetParametersRequest checkRulesetParametersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkRulesetParametersRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(checkRulesetParametersRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            if (StringUtils.TryConvertToNonEmptyString(checkRulesetParametersRequest.RulesetId, out var valueOfRulesetId)) urlParam.Add("ruleset_id", valueOfRulesetId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tasks/{task_id}/ruleset/{ruleset_id}/check-parameters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkRulesetParametersRequest);
            return new AsyncInvoker<CheckRulesetParametersResponse>(this, "GET", request, JsonUtils.DeSerialize<CheckRulesetParametersResponse>);
        }
        
        /// <summary>
        /// 创建自定义规则集
        ///
        /// 可根据需求灵活的组合规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRulesetResponse> CreateRulesetAsync(CreateRulesetRequest createRulesetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/ruleset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRulesetRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateRulesetResponse>(response);
        }

        public AsyncInvoker<CreateRulesetResponse> CreateRulesetAsyncInvoker(CreateRulesetRequest createRulesetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/ruleset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRulesetRequest);
            return new AsyncInvoker<CreateRulesetResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRulesetResponse>);
        }
        
        /// <summary>
        /// 新建检查任务
        ///
        /// 新建检查任务但是不执行。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTaskResponse> CreateTaskAsync(CreateTaskRequest createTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTaskRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTaskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateTaskResponse>(response);
        }

        public AsyncInvoker<CreateTaskResponse> CreateTaskAsyncInvoker(CreateTaskRequest createTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTaskRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTaskRequest);
            return new AsyncInvoker<CreateTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTaskResponse>);
        }
        
        /// <summary>
        /// 删除自定义规则集
        ///
        /// 删除自定义规则集，正在使用中的或默认规则集不能删除
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRulesetResponse> DeleteRulesetAsync(DeleteRulesetRequest deleteRulesetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRulesetRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deleteRulesetRequest.RulesetId, out var valueOfRulesetId)) urlParam.Add("ruleset_id", valueOfRulesetId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ruleset/{ruleset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRulesetRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRulesetResponse>(response);
        }

        public AsyncInvoker<DeleteRulesetResponse> DeleteRulesetAsyncInvoker(DeleteRulesetRequest deleteRulesetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRulesetRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deleteRulesetRequest.RulesetId, out var valueOfRulesetId)) urlParam.Add("ruleset_id", valueOfRulesetId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ruleset/{ruleset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRulesetRequest);
            return new AsyncInvoker<DeleteRulesetResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRulesetResponse>);
        }
        
        /// <summary>
        /// 删除检查任务
        ///
        /// 删除检查任务，执行中的任务删除无法再查看
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTaskResponse> DeleteTaskAsync(DeleteTaskRequest deleteTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTaskRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTaskResponse>(response);
        }

        public AsyncInvoker<DeleteTaskResponse> DeleteTaskAsyncInvoker(DeleteTaskRequest deleteTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTaskRequest);
            return new AsyncInvoker<DeleteTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTaskResponse>);
        }
        
        /// <summary>
        /// 获取规则列表接口
        ///
        /// 根据语言、问题级别等条件查询规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRulesResponse> ListRulesAsync(ListRulesRequest listRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRulesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRulesResponse>(response);
        }

        public AsyncInvoker<ListRulesResponse> ListRulesAsyncInvoker(ListRulesRequest listRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRulesRequest);
            return new AsyncInvoker<ListRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRulesResponse>);
        }
        
        /// <summary>
        /// 查询规则集列表
        ///
        /// 根据项目ID、语言等条件查询规则集列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRulesetsResponse> ListRulesetsAsync(ListRulesetsRequest listRulesetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRulesetsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rulesets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRulesetsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRulesetsResponse>(response);
        }

        public AsyncInvoker<ListRulesetsResponse> ListRulesetsAsyncInvoker(ListRulesetsRequest listRulesetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRulesetsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rulesets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRulesetsRequest);
            return new AsyncInvoker<ListRulesetsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRulesetsResponse>);
        }
        
        /// <summary>
        /// 任务配置检查参数
        ///
        /// 任务配置检查参数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTaskParameterResponse> ListTaskParameterAsync(ListTaskParameterRequest listTaskParameterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTaskParameterRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listTaskParameterRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/config-parameters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTaskParameterRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ListTaskParameterResponse>(response);
        }

        public AsyncInvoker<ListTaskParameterResponse> ListTaskParameterAsyncInvoker(ListTaskParameterRequest listTaskParameterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTaskParameterRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listTaskParameterRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/config-parameters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTaskParameterRequest);
            return new AsyncInvoker<ListTaskParameterResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ListTaskParameterResponse>);
        }
        
        /// <summary>
        /// 查询任务的已选规则集列表
        ///
        /// 查询任务的已选规则集列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTaskRulesetResponse> ListTaskRulesetAsync(ListTaskRulesetRequest listTaskRulesetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTaskRulesetRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listTaskRulesetRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/rulesets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTaskRulesetRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listTaskRulesetResponse = JsonUtils.DeSerializeNull<ListTaskRulesetResponse>(response);
            listTaskRulesetResponse.Body = JsonUtils.DeSerializeList<TaskRulesetInfo>(response);
            return listTaskRulesetResponse;
        }

        public AsyncInvoker<ListTaskRulesetResponse> ListTaskRulesetAsyncInvoker(ListTaskRulesetRequest listTaskRulesetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTaskRulesetRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listTaskRulesetRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/rulesets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTaskRulesetRequest);
            return new AsyncInvoker<ListTaskRulesetResponse>(this, "GET", request, response =>
            {
                var listTaskRulesetResponse = JsonUtils.DeSerializeNull<ListTaskRulesetResponse>(response);
                listTaskRulesetResponse.Body = JsonUtils.DeSerializeList<TaskRulesetInfo>(response);
                return listTaskRulesetResponse;
            });
        }
        
        /// <summary>
        /// 查看规则集的规则列表
        ///
        /// 根据项目ID、规则集ID等条件查询规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTemplateRulesResponse> ListTemplateRulesAsync(ListTemplateRulesRequest listTemplateRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTemplateRulesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listTemplateRulesRequest.RulesetId, out var valueOfRulesetId)) urlParam.Add("ruleset_id", valueOfRulesetId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ruleset/{ruleset_id}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateRulesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTemplateRulesResponse>(response);
        }

        public AsyncInvoker<ListTemplateRulesResponse> ListTemplateRulesAsyncInvoker(ListTemplateRulesRequest listTemplateRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTemplateRulesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listTemplateRulesRequest.RulesetId, out var valueOfRulesetId)) urlParam.Add("ruleset_id", valueOfRulesetId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ruleset/{ruleset_id}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateRulesRequest);
            return new AsyncInvoker<ListTemplateRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTemplateRulesResponse>);
        }
        
        /// <summary>
        /// 执行检查任务
        ///
        /// 执行检查任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunTaskResponse> RunTaskAsync(RunTaskRequest runTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/run", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runTaskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RunTaskResponse>(response);
        }

        public AsyncInvoker<RunTaskResponse> RunTaskAsyncInvoker(RunTaskRequest runTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/run", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runTaskRequest);
            return new AsyncInvoker<RunTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<RunTaskResponse>);
        }
        
        /// <summary>
        /// 设置每个项目对应语言的默认规则集配置
        ///
        /// 设置每个项目对应语言的默认规则集配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetDefaulTemplateResponse> SetDefaulTemplateAsync(SetDefaulTemplateRequest setDefaulTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setDefaulTemplateRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(setDefaulTemplateRequest.RulesetId, out var valueOfRulesetId)) urlParam.Add("ruleset_id", valueOfRulesetId);
            if (StringUtils.TryConvertToNonEmptyString(setDefaulTemplateRequest.Language, out var valueOfLanguage)) urlParam.Add("language", valueOfLanguage);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ruleset/{ruleset_id}/{language}/default", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setDefaulTemplateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<SetDefaulTemplateResponse>(response);
        }

        public AsyncInvoker<SetDefaulTemplateResponse> SetDefaulTemplateAsyncInvoker(SetDefaulTemplateRequest setDefaulTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setDefaulTemplateRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(setDefaulTemplateRequest.RulesetId, out var valueOfRulesetId)) urlParam.Add("ruleset_id", valueOfRulesetId);
            if (StringUtils.TryConvertToNonEmptyString(setDefaulTemplateRequest.Language, out var valueOfLanguage)) urlParam.Add("language", valueOfLanguage);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ruleset/{ruleset_id}/{language}/default", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setDefaulTemplateRequest);
            return new AsyncInvoker<SetDefaulTemplateResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SetDefaulTemplateResponse>);
        }
        
        /// <summary>
        /// 查询任务执行状态
        ///
        /// 根据任务ID查询任务执行状态。任务状态：0表示检查中，1表示检查失败，2表示检查成功，3表示任务中止。只有正在检查中才有进度的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowProgressDetailResponse> ShowProgressDetailAsync(ShowProgressDetailRequest showProgressDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProgressDetailRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/progress", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProgressDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowProgressDetailResponse>(response);
        }

        public AsyncInvoker<ShowProgressDetailResponse> ShowProgressDetailAsyncInvoker(ShowProgressDetailRequest showProgressDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProgressDetailRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/progress", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProgressDetailRequest);
            return new AsyncInvoker<ShowProgressDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProgressDetailResponse>);
        }
        
        /// <summary>
        /// 查询cmertrics缺陷概要
        ///
        /// 根据检查任务ID查询cmertrics缺陷概要。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTaskCmetricsResponse> ShowTaskCmetricsAsync(ShowTaskCmetricsRequest showTaskCmetricsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTaskCmetricsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showTaskCmetricsRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/metrics-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTaskCmetricsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTaskCmetricsResponse>(response);
        }

        public AsyncInvoker<ShowTaskCmetricsResponse> ShowTaskCmetricsAsyncInvoker(ShowTaskCmetricsRequest showTaskCmetricsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTaskCmetricsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showTaskCmetricsRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/metrics-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTaskCmetricsRequest);
            return new AsyncInvoker<ShowTaskCmetricsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTaskCmetricsResponse>);
        }
        
        /// <summary>
        /// 查询缺陷详情
        ///
        /// 根据检查任务ID分页查询缺陷结果详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTaskDefectsResponse> ShowTaskDefectsAsync(ShowTaskDefectsRequest showTaskDefectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTaskDefectsRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/defects-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTaskDefectsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTaskDefectsResponse>(response);
        }

        public AsyncInvoker<ShowTaskDefectsResponse> ShowTaskDefectsAsyncInvoker(ShowTaskDefectsRequest showTaskDefectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTaskDefectsRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/defects-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTaskDefectsRequest);
            return new AsyncInvoker<ShowTaskDefectsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTaskDefectsResponse>);
        }
        
        /// <summary>
        /// 查询缺陷详情的统计
        ///
        /// 根据检查任务ID查询缺陷详情的统计
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTaskDefectsStatisticResponse> ShowTaskDefectsStatisticAsync(ShowTaskDefectsStatisticRequest showTaskDefectsStatisticRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTaskDefectsStatisticRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/defects-statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTaskDefectsStatisticRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTaskDefectsStatisticResponse>(response);
        }

        public AsyncInvoker<ShowTaskDefectsStatisticResponse> ShowTaskDefectsStatisticAsyncInvoker(ShowTaskDefectsStatisticRequest showTaskDefectsStatisticRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTaskDefectsStatisticRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/defects-statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTaskDefectsStatisticRequest);
            return new AsyncInvoker<ShowTaskDefectsStatisticResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTaskDefectsStatisticResponse>);
        }
        
        /// <summary>
        /// 查询缺陷概要
        ///
        /// 根据检查任务ID查询缺陷结果的概要。包括问题概述、问题状态、圈复杂度、代码重复率等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTaskDetailResponse> ShowTaskDetailAsync(ShowTaskDetailRequest showTaskDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTaskDetailRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/defects-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTaskDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTaskDetailResponse>(response);
        }

        public AsyncInvoker<ShowTaskDetailResponse> ShowTaskDetailAsyncInvoker(ShowTaskDetailRequest showTaskDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTaskDetailRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/defects-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTaskDetailRequest);
            return new AsyncInvoker<ShowTaskDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTaskDetailResponse>);
        }
        
        /// <summary>
        /// 查询任务列表
        ///
        /// 根据DEVCLOUD_PROJECT_UUID查询该项目下的任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTaskListByProjectIdResponse> ShowTaskListByProjectIdAsync(ShowTaskListByProjectIdRequest showTaskListByProjectIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTaskListByProjectIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTaskListByProjectIdRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTaskListByProjectIdResponse>(response);
        }

        public AsyncInvoker<ShowTaskListByProjectIdResponse> ShowTaskListByProjectIdAsyncInvoker(ShowTaskListByProjectIdRequest showTaskListByProjectIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTaskListByProjectIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTaskListByProjectIdRequest);
            return new AsyncInvoker<ShowTaskListByProjectIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTaskListByProjectIdResponse>);
        }
        
        /// <summary>
        /// 获取任务的目录树
        ///
        /// 获取任务的目录树
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTaskPathTreeResponse> ShowTaskPathTreeAsync(ShowTaskPathTreeRequest showTaskPathTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTaskPathTreeRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showTaskPathTreeRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/listpathtree", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTaskPathTreeRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTaskPathTreeResponse>(response);
        }

        public AsyncInvoker<ShowTaskPathTreeResponse> ShowTaskPathTreeAsyncInvoker(ShowTaskPathTreeRequest showTaskPathTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTaskPathTreeRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showTaskPathTreeRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/listpathtree", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTaskPathTreeRequest);
            return new AsyncInvoker<ShowTaskPathTreeResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTaskPathTreeResponse>);
        }
        
        /// <summary>
        /// 查询任务的高级选项
        ///
        /// 查询任务的高级选项
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTaskSettingsResponse> ShowTaskSettingsAsync(ShowTaskSettingsRequest showTaskSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTaskSettingsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showTaskSettingsRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTaskSettingsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTaskSettingsResponse>(response);
        }

        public AsyncInvoker<ShowTaskSettingsResponse> ShowTaskSettingsAsyncInvoker(ShowTaskSettingsRequest showTaskSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTaskSettingsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showTaskSettingsRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTaskSettingsRequest);
            return new AsyncInvoker<ShowTaskSettingsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTaskSettingsResponse>);
        }
        
        /// <summary>
        /// 查询任务检查失败日志
        ///
        /// 查询任务检查失败日志，不传execute_id则查询最近一次的检查日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTasklogResponse> ShowTasklogAsync(ShowTasklogRequest showTasklogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTasklogRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showTasklogRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/log-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTasklogRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTasklogResponse>(response);
        }

        public AsyncInvoker<ShowTasklogResponse> ShowTasklogAsyncInvoker(ShowTasklogRequest showTasklogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTasklogRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showTasklogRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/log-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTasklogRequest);
            return new AsyncInvoker<ShowTasklogResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTasklogResponse>);
        }
        
        /// <summary>
        /// 查询任务的已选规则集列表
        ///
        /// 查询任务的已选规则集列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTasksRulesetsResponse> ShowTasksRulesetsAsync(ShowTasksRulesetsRequest showTasksRulesetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTasksRulesetsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showTasksRulesetsRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tasks/{task_id}/rulesets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTasksRulesetsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTasksRulesetsResponse>(response);
        }

        public AsyncInvoker<ShowTasksRulesetsResponse> ShowTasksRulesetsAsyncInvoker(ShowTasksRulesetsRequest showTasksRulesetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTasksRulesetsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showTasksRulesetsRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tasks/{task_id}/rulesets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTasksRulesetsRequest);
            return new AsyncInvoker<ShowTasksRulesetsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTasksRulesetsResponse>);
        }
        
        /// <summary>
        /// 终止检查任务
        ///
        /// 根据任务ID终止检查任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StopTaskByIdResponse> StopTaskByIdAsync(StopTaskByIdRequest stopTaskByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopTaskByIdRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopTaskByIdRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<StopTaskByIdResponse>(response);
        }

        public AsyncInvoker<StopTaskByIdResponse> StopTaskByIdAsyncInvoker(StopTaskByIdRequest stopTaskByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopTaskByIdRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopTaskByIdRequest);
            return new AsyncInvoker<StopTaskByIdResponse>(this, "POST", request, JsonUtils.DeSerializeNull<StopTaskByIdResponse>);
        }
        
        /// <summary>
        /// 修改缺陷状态
        ///
        /// 修改检查出的缺陷的状态为已解决、已忽略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDefectStatusResponse> UpdateDefectStatusAsync(UpdateDefectStatusRequest updateDefectStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDefectStatusRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/defect-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDefectStatusRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateDefectStatusResponse>(response);
        }

        public AsyncInvoker<UpdateDefectStatusResponse> UpdateDefectStatusAsyncInvoker(UpdateDefectStatusRequest updateDefectStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDefectStatusRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/defect-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDefectStatusRequest);
            return new AsyncInvoker<UpdateDefectStatusResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDefectStatusResponse>);
        }
        
        /// <summary>
        /// 任务配置屏蔽目录
        ///
        /// 任务配置屏蔽目录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateIgnorePathResponse> UpdateIgnorePathAsync(UpdateIgnorePathRequest updateIgnorePathRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateIgnorePathRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(updateIgnorePathRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/config-ignorepath", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateIgnorePathRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateIgnorePathResponse>(response);
        }

        public AsyncInvoker<UpdateIgnorePathResponse> UpdateIgnorePathAsyncInvoker(UpdateIgnorePathRequest updateIgnorePathRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateIgnorePathRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(updateIgnorePathRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/config-ignorepath", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateIgnorePathRequest);
            return new AsyncInvoker<UpdateIgnorePathResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateIgnorePathResponse>);
        }
        
        /// <summary>
        /// 修改任务规则集
        ///
        /// 修改任务规则集。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateTaskRulesetResponse> UpdateTaskRulesetAsync(UpdateTaskRulesetRequest updateTaskRulesetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTaskRulesetRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/ruleset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTaskRulesetRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateTaskRulesetResponse>(response);
        }

        public AsyncInvoker<UpdateTaskRulesetResponse> UpdateTaskRulesetAsyncInvoker(UpdateTaskRulesetRequest updateTaskRulesetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTaskRulesetRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/ruleset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTaskRulesetRequest);
            return new AsyncInvoker<UpdateTaskRulesetResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateTaskRulesetResponse>);
        }
        
        /// <summary>
        /// 任务配置高级选项
        ///
        /// 任务配置高级选项，如自定义镜像
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateTaskSettingsResponse> UpdateTaskSettingsAsync(UpdateTaskSettingsRequest updateTaskSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTaskSettingsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(updateTaskSettingsRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTaskSettingsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateTaskSettingsResponse>(response);
        }

        public AsyncInvoker<UpdateTaskSettingsResponse> UpdateTaskSettingsAsyncInvoker(UpdateTaskSettingsRequest updateTaskSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTaskSettingsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(updateTaskSettingsRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTaskSettingsRequest);
            return new AsyncInvoker<UpdateTaskSettingsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateTaskSettingsResponse>);
        }
        
    }
}