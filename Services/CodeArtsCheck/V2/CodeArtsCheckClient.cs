using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.CodeArtsCheck.V2.Model;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2
{
    public partial class CodeArtsCheckClient : Client
    {
        public static ClientBuilder<CodeArtsCheckClient> NewBuilder()
        {
            return new ClientBuilder<CodeArtsCheckClient>();
        }

        
        /// <summary>
        /// 查询任务规则集的检查参数
        ///
        /// 查询任务规则集的检查参数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CheckParametersResponse CheckParameters(CheckParametersRequest checkParametersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkParametersRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(checkParametersRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            if (StringUtils.TryConvertToNonEmptyString(checkParametersRequest.RulesetId, out var valueOfRulesetId)) urlParam.Add("ruleset_id", valueOfRulesetId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/ruleset/{ruleset_id}/check-parameters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkParametersRequest);
            var response = DoHttpRequestSync("GET", request);
            var checkParametersResponse = JsonUtils.DeSerializeNull<CheckParametersResponse>(response);
            checkParametersResponse.Body = JsonUtils.DeSerializeList<TaskCheckParamters>(response);
            return checkParametersResponse;
        }

        public SyncInvoker<CheckParametersResponse> CheckParametersInvoker(CheckParametersRequest checkParametersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkParametersRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(checkParametersRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            if (StringUtils.TryConvertToNonEmptyString(checkParametersRequest.RulesetId, out var valueOfRulesetId)) urlParam.Add("ruleset_id", valueOfRulesetId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/ruleset/{ruleset_id}/check-parameters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkParametersRequest);
            return new SyncInvoker<CheckParametersResponse>(this, "GET", request, response =>
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
        public CheckRecordResponse CheckRecord(CheckRecordRequest checkRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkRecordRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(checkRecordRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/checkrecord", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkRecordRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CheckRecordResponse>(response);
        }

        public SyncInvoker<CheckRecordResponse> CheckRecordInvoker(CheckRecordRequest checkRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkRecordRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(checkRecordRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/checkrecord", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkRecordRequest);
            return new SyncInvoker<CheckRecordResponse>(this, "GET", request, JsonUtils.DeSerialize<CheckRecordResponse>);
        }
        
        /// <summary>
        /// 查询任务规则集的检查参数
        ///
        /// 查询任务规则集的检查参数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CheckRulesetParametersResponse CheckRulesetParameters(CheckRulesetParametersRequest checkRulesetParametersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkRulesetParametersRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(checkRulesetParametersRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            if (StringUtils.TryConvertToNonEmptyString(checkRulesetParametersRequest.RulesetId, out var valueOfRulesetId)) urlParam.Add("ruleset_id", valueOfRulesetId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tasks/{task_id}/ruleset/{ruleset_id}/check-parameters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkRulesetParametersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<CheckRulesetParametersResponse>(response);
        }

        public SyncInvoker<CheckRulesetParametersResponse> CheckRulesetParametersInvoker(CheckRulesetParametersRequest checkRulesetParametersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(checkRulesetParametersRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(checkRulesetParametersRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            if (StringUtils.TryConvertToNonEmptyString(checkRulesetParametersRequest.RulesetId, out var valueOfRulesetId)) urlParam.Add("ruleset_id", valueOfRulesetId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tasks/{task_id}/ruleset/{ruleset_id}/check-parameters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", checkRulesetParametersRequest);
            return new SyncInvoker<CheckRulesetParametersResponse>(this, "GET", request, JsonUtils.DeSerialize<CheckRulesetParametersResponse>);
        }
        
        /// <summary>
        /// 创建自定义规则集
        ///
        /// 可根据需求灵活的组合规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRulesetResponse CreateRuleset(CreateRulesetRequest createRulesetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/ruleset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRulesetRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateRulesetResponse>(response);
        }

        public SyncInvoker<CreateRulesetResponse> CreateRulesetInvoker(CreateRulesetRequest createRulesetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/ruleset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRulesetRequest);
            return new SyncInvoker<CreateRulesetResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRulesetResponse>);
        }
        
        /// <summary>
        /// 新建检查任务
        ///
        /// 新建检查任务但是不执行。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTaskResponse CreateTask(CreateTaskRequest createTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTaskRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateTaskResponse>(response);
        }

        public SyncInvoker<CreateTaskResponse> CreateTaskInvoker(CreateTaskRequest createTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTaskRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTaskRequest);
            return new SyncInvoker<CreateTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateTaskResponse>);
        }
        
        /// <summary>
        /// 删除自定义规则集
        ///
        /// 删除自定义规则集，正在使用中的或默认规则集不能删除
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteRulesetResponse DeleteRuleset(DeleteRulesetRequest deleteRulesetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRulesetRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deleteRulesetRequest.RulesetId, out var valueOfRulesetId)) urlParam.Add("ruleset_id", valueOfRulesetId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ruleset/{ruleset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRulesetRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRulesetResponse>(response);
        }

        public SyncInvoker<DeleteRulesetResponse> DeleteRulesetInvoker(DeleteRulesetRequest deleteRulesetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRulesetRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deleteRulesetRequest.RulesetId, out var valueOfRulesetId)) urlParam.Add("ruleset_id", valueOfRulesetId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ruleset/{ruleset_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRulesetRequest);
            return new SyncInvoker<DeleteRulesetResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRulesetResponse>);
        }
        
        /// <summary>
        /// 删除检查任务
        ///
        /// 删除检查任务，执行中的任务删除无法再查看
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTaskResponse DeleteTask(DeleteTaskRequest deleteTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTaskResponse>(response);
        }

        public SyncInvoker<DeleteTaskResponse> DeleteTaskInvoker(DeleteTaskRequest deleteTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTaskRequest);
            return new SyncInvoker<DeleteTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTaskResponse>);
        }
        
        /// <summary>
        /// 获取规则列表接口
        ///
        /// 根据语言、问题级别等条件查询规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRulesResponse ListRules(ListRulesRequest listRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRulesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRulesResponse>(response);
        }

        public SyncInvoker<ListRulesResponse> ListRulesInvoker(ListRulesRequest listRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRulesRequest);
            return new SyncInvoker<ListRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRulesResponse>);
        }
        
        /// <summary>
        /// 查询规则集列表
        ///
        /// 根据项目ID、语言等条件查询规则集列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRulesetsResponse ListRulesets(ListRulesetsRequest listRulesetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRulesetsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rulesets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRulesetsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRulesetsResponse>(response);
        }

        public SyncInvoker<ListRulesetsResponse> ListRulesetsInvoker(ListRulesetsRequest listRulesetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRulesetsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rulesets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRulesetsRequest);
            return new SyncInvoker<ListRulesetsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRulesetsResponse>);
        }
        
        /// <summary>
        /// 任务配置检查参数
        ///
        /// 任务配置检查参数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTaskParameterResponse ListTaskParameter(ListTaskParameterRequest listTaskParameterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTaskParameterRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listTaskParameterRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/config-parameters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTaskParameterRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<ListTaskParameterResponse>(response);
        }

        public SyncInvoker<ListTaskParameterResponse> ListTaskParameterInvoker(ListTaskParameterRequest listTaskParameterRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTaskParameterRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listTaskParameterRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/config-parameters", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTaskParameterRequest);
            return new SyncInvoker<ListTaskParameterResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ListTaskParameterResponse>);
        }
        
        /// <summary>
        /// 查询任务的已选规则集列表
        ///
        /// 查询任务的已选规则集列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTaskRulesetResponse ListTaskRuleset(ListTaskRulesetRequest listTaskRulesetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTaskRulesetRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listTaskRulesetRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/rulesets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTaskRulesetRequest);
            var response = DoHttpRequestSync("GET", request);
            var listTaskRulesetResponse = JsonUtils.DeSerializeNull<ListTaskRulesetResponse>(response);
            listTaskRulesetResponse.Body = JsonUtils.DeSerializeList<TaskRulesetInfo>(response);
            return listTaskRulesetResponse;
        }

        public SyncInvoker<ListTaskRulesetResponse> ListTaskRulesetInvoker(ListTaskRulesetRequest listTaskRulesetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTaskRulesetRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listTaskRulesetRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/rulesets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTaskRulesetRequest);
            return new SyncInvoker<ListTaskRulesetResponse>(this, "GET", request, response =>
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
        public ListTemplateRulesResponse ListTemplateRules(ListTemplateRulesRequest listTemplateRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTemplateRulesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listTemplateRulesRequest.RulesetId, out var valueOfRulesetId)) urlParam.Add("ruleset_id", valueOfRulesetId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ruleset/{ruleset_id}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateRulesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTemplateRulesResponse>(response);
        }

        public SyncInvoker<ListTemplateRulesResponse> ListTemplateRulesInvoker(ListTemplateRulesRequest listTemplateRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listTemplateRulesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listTemplateRulesRequest.RulesetId, out var valueOfRulesetId)) urlParam.Add("ruleset_id", valueOfRulesetId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ruleset/{ruleset_id}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateRulesRequest);
            return new SyncInvoker<ListTemplateRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTemplateRulesResponse>);
        }
        
        /// <summary>
        /// 执行检查任务
        ///
        /// 执行检查任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunTaskResponse RunTask(RunTaskRequest runTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/run", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RunTaskResponse>(response);
        }

        public SyncInvoker<RunTaskResponse> RunTaskInvoker(RunTaskRequest runTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runTaskRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/run", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", runTaskRequest);
            return new SyncInvoker<RunTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<RunTaskResponse>);
        }
        
        /// <summary>
        /// 设置每个项目对应语言的默认规则集配置
        ///
        /// 设置每个项目对应语言的默认规则集配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetDefaulTemplateResponse SetDefaulTemplate(SetDefaulTemplateRequest setDefaulTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setDefaulTemplateRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(setDefaulTemplateRequest.RulesetId, out var valueOfRulesetId)) urlParam.Add("ruleset_id", valueOfRulesetId);
            if (StringUtils.TryConvertToNonEmptyString(setDefaulTemplateRequest.Language, out var valueOfLanguage)) urlParam.Add("language", valueOfLanguage);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ruleset/{ruleset_id}/{language}/default", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setDefaulTemplateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<SetDefaulTemplateResponse>(response);
        }

        public SyncInvoker<SetDefaulTemplateResponse> SetDefaulTemplateInvoker(SetDefaulTemplateRequest setDefaulTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(setDefaulTemplateRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(setDefaulTemplateRequest.RulesetId, out var valueOfRulesetId)) urlParam.Add("ruleset_id", valueOfRulesetId);
            if (StringUtils.TryConvertToNonEmptyString(setDefaulTemplateRequest.Language, out var valueOfLanguage)) urlParam.Add("language", valueOfLanguage);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/ruleset/{ruleset_id}/{language}/default", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setDefaulTemplateRequest);
            return new SyncInvoker<SetDefaulTemplateResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SetDefaulTemplateResponse>);
        }
        
        /// <summary>
        /// 查询任务执行状态
        ///
        /// 根据任务ID查询任务执行状态。任务状态：0表示检查中，1表示检查失败，2表示检查成功，3表示任务中止。只有正在检查中才有进度的详细信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowProgressDetailResponse ShowProgressDetail(ShowProgressDetailRequest showProgressDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProgressDetailRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/progress", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProgressDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowProgressDetailResponse>(response);
        }

        public SyncInvoker<ShowProgressDetailResponse> ShowProgressDetailInvoker(ShowProgressDetailRequest showProgressDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProgressDetailRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/progress", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProgressDetailRequest);
            return new SyncInvoker<ShowProgressDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProgressDetailResponse>);
        }
        
        /// <summary>
        /// 查询cmertrics缺陷概要
        ///
        /// 根据检查任务ID查询cmertrics缺陷概要。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTaskCmetricsResponse ShowTaskCmetrics(ShowTaskCmetricsRequest showTaskCmetricsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTaskCmetricsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showTaskCmetricsRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/metrics-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTaskCmetricsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTaskCmetricsResponse>(response);
        }

        public SyncInvoker<ShowTaskCmetricsResponse> ShowTaskCmetricsInvoker(ShowTaskCmetricsRequest showTaskCmetricsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTaskCmetricsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showTaskCmetricsRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/metrics-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTaskCmetricsRequest);
            return new SyncInvoker<ShowTaskCmetricsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTaskCmetricsResponse>);
        }
        
        /// <summary>
        /// 查询缺陷详情
        ///
        /// 根据检查任务ID分页查询缺陷结果详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTaskDefectsResponse ShowTaskDefects(ShowTaskDefectsRequest showTaskDefectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTaskDefectsRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/defects-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTaskDefectsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTaskDefectsResponse>(response);
        }

        public SyncInvoker<ShowTaskDefectsResponse> ShowTaskDefectsInvoker(ShowTaskDefectsRequest showTaskDefectsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTaskDefectsRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/defects-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTaskDefectsRequest);
            return new SyncInvoker<ShowTaskDefectsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTaskDefectsResponse>);
        }
        
        /// <summary>
        /// 查询缺陷详情的统计
        ///
        /// 根据检查任务ID查询缺陷详情的统计
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTaskDefectsStatisticResponse ShowTaskDefectsStatistic(ShowTaskDefectsStatisticRequest showTaskDefectsStatisticRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTaskDefectsStatisticRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/defects-statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTaskDefectsStatisticRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTaskDefectsStatisticResponse>(response);
        }

        public SyncInvoker<ShowTaskDefectsStatisticResponse> ShowTaskDefectsStatisticInvoker(ShowTaskDefectsStatisticRequest showTaskDefectsStatisticRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTaskDefectsStatisticRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/defects-statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTaskDefectsStatisticRequest);
            return new SyncInvoker<ShowTaskDefectsStatisticResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTaskDefectsStatisticResponse>);
        }
        
        /// <summary>
        /// 查询缺陷概要
        ///
        /// 根据检查任务ID查询缺陷结果的概要。包括问题概述、问题状态、圈复杂度、代码重复率等。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTaskDetailResponse ShowTaskDetail(ShowTaskDetailRequest showTaskDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTaskDetailRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/defects-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTaskDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTaskDetailResponse>(response);
        }

        public SyncInvoker<ShowTaskDetailResponse> ShowTaskDetailInvoker(ShowTaskDetailRequest showTaskDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTaskDetailRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/defects-summary", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTaskDetailRequest);
            return new SyncInvoker<ShowTaskDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTaskDetailResponse>);
        }
        
        /// <summary>
        /// 查询任务列表
        ///
        /// 根据DEVCLOUD_PROJECT_UUID查询该项目下的任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTaskListByProjectIdResponse ShowTaskListByProjectId(ShowTaskListByProjectIdRequest showTaskListByProjectIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTaskListByProjectIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTaskListByProjectIdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTaskListByProjectIdResponse>(response);
        }

        public SyncInvoker<ShowTaskListByProjectIdResponse> ShowTaskListByProjectIdInvoker(ShowTaskListByProjectIdRequest showTaskListByProjectIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTaskListByProjectIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTaskListByProjectIdRequest);
            return new SyncInvoker<ShowTaskListByProjectIdResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTaskListByProjectIdResponse>);
        }
        
        /// <summary>
        /// 获取任务的目录树
        ///
        /// 获取任务的目录树
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTaskPathTreeResponse ShowTaskPathTree(ShowTaskPathTreeRequest showTaskPathTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTaskPathTreeRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showTaskPathTreeRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/listpathtree", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTaskPathTreeRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTaskPathTreeResponse>(response);
        }

        public SyncInvoker<ShowTaskPathTreeResponse> ShowTaskPathTreeInvoker(ShowTaskPathTreeRequest showTaskPathTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTaskPathTreeRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showTaskPathTreeRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/listpathtree", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTaskPathTreeRequest);
            return new SyncInvoker<ShowTaskPathTreeResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTaskPathTreeResponse>);
        }
        
        /// <summary>
        /// 查询任务的高级选项
        ///
        /// 查询任务的高级选项
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTaskSettingsResponse ShowTaskSettings(ShowTaskSettingsRequest showTaskSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTaskSettingsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showTaskSettingsRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTaskSettingsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTaskSettingsResponse>(response);
        }

        public SyncInvoker<ShowTaskSettingsResponse> ShowTaskSettingsInvoker(ShowTaskSettingsRequest showTaskSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTaskSettingsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showTaskSettingsRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTaskSettingsRequest);
            return new SyncInvoker<ShowTaskSettingsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTaskSettingsResponse>);
        }
        
        /// <summary>
        /// 查询任务检查失败日志
        ///
        /// 查询任务检查失败日志，不传execute_id则查询最近一次的检查日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTasklogResponse ShowTasklog(ShowTasklogRequest showTasklogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTasklogRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showTasklogRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/log-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTasklogRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTasklogResponse>(response);
        }

        public SyncInvoker<ShowTasklogResponse> ShowTasklogInvoker(ShowTasklogRequest showTasklogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTasklogRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showTasklogRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/log-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTasklogRequest);
            return new SyncInvoker<ShowTasklogResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTasklogResponse>);
        }
        
        /// <summary>
        /// 查询任务的已选规则集列表
        ///
        /// 查询任务的已选规则集列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTasksRulesetsResponse ShowTasksRulesets(ShowTasksRulesetsRequest showTasksRulesetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTasksRulesetsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showTasksRulesetsRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tasks/{task_id}/rulesets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTasksRulesetsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTasksRulesetsResponse>(response);
        }

        public SyncInvoker<ShowTasksRulesetsResponse> ShowTasksRulesetsInvoker(ShowTasksRulesetsRequest showTasksRulesetsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTasksRulesetsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showTasksRulesetsRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/tasks/{task_id}/rulesets", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTasksRulesetsRequest);
            return new SyncInvoker<ShowTasksRulesetsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTasksRulesetsResponse>);
        }
        
        /// <summary>
        /// 终止检查任务
        ///
        /// 根据任务ID终止检查任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StopTaskByIdResponse StopTaskById(StopTaskByIdRequest stopTaskByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopTaskByIdRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopTaskByIdRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<StopTaskByIdResponse>(response);
        }

        public SyncInvoker<StopTaskByIdResponse> StopTaskByIdInvoker(StopTaskByIdRequest stopTaskByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopTaskByIdRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopTaskByIdRequest);
            return new SyncInvoker<StopTaskByIdResponse>(this, "POST", request, JsonUtils.DeSerializeNull<StopTaskByIdResponse>);
        }
        
        /// <summary>
        /// 修改缺陷状态
        ///
        /// 修改检查出的缺陷的状态为已解决、已忽略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDefectStatusResponse UpdateDefectStatus(UpdateDefectStatusRequest updateDefectStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDefectStatusRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/defect-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDefectStatusRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateDefectStatusResponse>(response);
        }

        public SyncInvoker<UpdateDefectStatusResponse> UpdateDefectStatusInvoker(UpdateDefectStatusRequest updateDefectStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDefectStatusRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/defect-status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDefectStatusRequest);
            return new SyncInvoker<UpdateDefectStatusResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDefectStatusResponse>);
        }
        
        /// <summary>
        /// 任务配置屏蔽目录
        ///
        /// 任务配置屏蔽目录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateIgnorePathResponse UpdateIgnorePath(UpdateIgnorePathRequest updateIgnorePathRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateIgnorePathRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(updateIgnorePathRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/config-ignorepath", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateIgnorePathRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateIgnorePathResponse>(response);
        }

        public SyncInvoker<UpdateIgnorePathResponse> UpdateIgnorePathInvoker(UpdateIgnorePathRequest updateIgnorePathRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateIgnorePathRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(updateIgnorePathRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/config-ignorepath", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateIgnorePathRequest);
            return new SyncInvoker<UpdateIgnorePathResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateIgnorePathResponse>);
        }
        
        /// <summary>
        /// 修改任务规则集
        ///
        /// 修改任务规则集。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTaskRulesetResponse UpdateTaskRuleset(UpdateTaskRulesetRequest updateTaskRulesetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTaskRulesetRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/ruleset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTaskRulesetRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateTaskRulesetResponse>(response);
        }

        public SyncInvoker<UpdateTaskRulesetResponse> UpdateTaskRulesetInvoker(UpdateTaskRulesetRequest updateTaskRulesetRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTaskRulesetRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/tasks/{task_id}/ruleset", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTaskRulesetRequest);
            return new SyncInvoker<UpdateTaskRulesetResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateTaskRulesetResponse>);
        }
        
        /// <summary>
        /// 任务配置高级选项
        ///
        /// 任务配置高级选项，如自定义镜像
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTaskSettingsResponse UpdateTaskSettings(UpdateTaskSettingsRequest updateTaskSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTaskSettingsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(updateTaskSettingsRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTaskSettingsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateTaskSettingsResponse>(response);
        }

        public SyncInvoker<UpdateTaskSettingsResponse> UpdateTaskSettingsInvoker(UpdateTaskSettingsRequest updateTaskSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTaskSettingsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(updateTaskSettingsRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/tasks/{task_id}/settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTaskSettingsRequest);
            return new SyncInvoker<UpdateTaskSettingsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateTaskSettingsResponse>);
        }
        
    }
}