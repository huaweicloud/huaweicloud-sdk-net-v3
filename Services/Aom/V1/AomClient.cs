using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Aom.V1.Model;

namespace HuaweiCloud.SDK.Aom.V1
{
    public partial class AomClient : Client
    {
        public static ClientBuilder<AomClient> NewBuilder()
        {
            return new ClientBuilder<AomClient>();
        }

        
        /// <summary>
        /// 快速创建并执行脚本
        ///
        /// 该接口用于创建快速执行脚本的任务，可以指定脚本类型，执行用户，脚本参数，执行机器，脚本内容，在用户指定的机器上执行脚本。（注：接口目前开放的region为：华东-苏州二零一）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateFastExecuteScriptResponse CreateFastExecuteScript(CreateFastExecuteScriptRequest createFastExecuteScriptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/fast-execute-script", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFastExecuteScriptRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateFastExecuteScriptResponse>(response);
        }

        public SyncInvoker<CreateFastExecuteScriptResponse> CreateFastExecuteScriptInvoker(CreateFastExecuteScriptRequest createFastExecuteScriptRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/fast-execute-script", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFastExecuteScriptRequest);
            return new SyncInvoker<CreateFastExecuteScriptResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateFastExecuteScriptResponse>);
        }
        
        /// <summary>
        /// 创建任务
        ///
        /// 该接口用于创建工作流（任务），返回工作流详情。任务类型取决于模板名称和&#39;input&#39;参数。（注：接口目前开放的region为：华北-北京四,华东-上海一,华东-上海二,华南-广州）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateWorkflowResponse CreateWorkflow(CreateWorkflowRequest createWorkflowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/workflow", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWorkflowRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateWorkflowResponse>(response);
        }

        public SyncInvoker<CreateWorkflowResponse> CreateWorkflowInvoker(CreateWorkflowRequest createWorkflowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/workflow", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWorkflowRequest);
            return new SyncInvoker<CreateWorkflowResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateWorkflowResponse>);
        }
        
        /// <summary>
        /// 执行工作流
        ///
        /// 该接口可下发执行指定的任务。（注：接口目前开放的region为：华北-北京四,华东-上海一,华东-上海二,华南-广州）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExecuteWorkflowResponse ExecuteWorkflow(ExecuteWorkflowRequest executeWorkflowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id", executeWorkflowRequest.WorkflowId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/workflow/{workflow_id}/executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeWorkflowRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ExecuteWorkflowResponse>(response);
        }

        public SyncInvoker<ExecuteWorkflowResponse> ExecuteWorkflowInvoker(ExecuteWorkflowRequest executeWorkflowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id", executeWorkflowRequest.WorkflowId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/workflow/{workflow_id}/executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeWorkflowRequest);
            return new SyncInvoker<ExecuteWorkflowResponse>(this, "POST", request, JsonUtils.DeSerialize<ExecuteWorkflowResponse>);
        }
        
        /// <summary>
        /// 作业管理主页模糊查询
        ///
        /// 该接口可查询已创建的作业，可指定作业名称和作业创建人去精确查询，返回作业列表信息。（注：接口目前开放的region为：华北-北京四,华东-上海一,华东-上海二,华南-广州）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAllJobByNameResponse ListAllJobByName(ListAllJobByNameRequest listAllJobByNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/job/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllJobByNameRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListAllJobByNameResponse>(response);
        }

        public SyncInvoker<ListAllJobByNameResponse> ListAllJobByNameInvoker(ListAllJobByNameRequest listAllJobByNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/job/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllJobByNameRequest);
            return new SyncInvoker<ListAllJobByNameResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAllJobByNameResponse>);
        }
        
        /// <summary>
        /// 脚本查询
        ///
        /// 该接口是脚本主页查询，可指定脚本名称和脚本创建人进行精确查询，返回包含脚本基本信息的列表数据。（注：接口目前开放的region为：华北-北京四,华东-上海一,华东-上海二,华南-广州）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAllScriptByNameResponse ListAllScriptByName(ListAllScriptByNameRequest listAllScriptByNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/script/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllScriptByNameRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListAllScriptByNameResponse>(response);
        }

        public SyncInvoker<ListAllScriptByNameResponse> ListAllScriptByNameInvoker(ListAllScriptByNameRequest listAllScriptByNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/script/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllScriptByNameRequest);
            return new SyncInvoker<ListAllScriptByNameResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAllScriptByNameResponse>);
        }
        
        /// <summary>
        /// 脚本版本查询
        ///
        /// 该接口可查询指定脚本ID下的所有版本，返回该名称的脚本版本列表信息。（注：接口目前开放的region为：华北-北京四,华东-上海一,华东-上海二,华南-广州）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAllVersionByVersionIdResponse ListAllVersionByVersionId(ListAllVersionByVersionIdRequest listAllVersionByVersionIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/script-version-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllVersionByVersionIdRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListAllVersionByVersionIdResponse>(response);
        }

        public SyncInvoker<ListAllVersionByVersionIdResponse> ListAllVersionByVersionIdInvoker(ListAllVersionByVersionIdRequest listAllVersionByVersionIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/script-version-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllVersionByVersionIdRequest);
            return new SyncInvoker<ListAllVersionByVersionIdResponse>(this, "POST", request, JsonUtils.DeSerialize<ListAllVersionByVersionIdResponse>);
        }
        
        /// <summary>
        /// 根据作业id查询方案(自定义模板)列表
        ///
        /// 该接口可根据作业ID查询执行方案，分页返回执行方案列表。（注：接口目前开放的region为：华北-北京四,华东-上海一,华东-上海二,华南-广州）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTemplateByJobIdResponse ListTemplateByJobId(ListTemplateByJobIdRequest listTemplateByJobIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listTemplateByJobIdRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/template-list/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateByJobIdRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListTemplateByJobIdResponse>(response);
        }

        public SyncInvoker<ListTemplateByJobIdResponse> ListTemplateByJobIdInvoker(ListTemplateByJobIdRequest listTemplateByJobIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id", listTemplateByJobIdRequest.JobId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/template-list/{job_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateByJobIdRequest);
            return new SyncInvoker<ListTemplateByJobIdResponse>(this, "POST", request, JsonUtils.DeSerialize<ListTemplateByJobIdResponse>);
        }
        
        /// <summary>
        /// 查询任务列表
        ///
        /// 该接口可返回已经创建的任务列表，可按任务名称，任务状态，任务类型，执行人，更新时间为查询条件分页查询任务。（注：接口目前开放的region为：华北-北京四,华东-上海一,华东-上海二,华南-广州）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListWorkflowResponse ListWorkflow(ListWorkflowRequest listWorkflowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/workflow-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWorkflowRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListWorkflowResponse>(response);
        }

        public SyncInvoker<ListWorkflowResponse> ListWorkflowInvoker(ListWorkflowRequest listWorkflowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/workflow-list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWorkflowRequest);
            return new SyncInvoker<ListWorkflowResponse>(this, "POST", request, JsonUtils.DeSerialize<ListWorkflowResponse>);
        }
        
        /// <summary>
        /// 获取任务执行历史
        ///
        /// 该接口可获取执行任务的执行历史。（注：接口目前开放的region为：华北-北京四,华东-上海一,华东-上海二,华南-广州）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListWorkflowExecutionsResponse ListWorkflowExecutions(ListWorkflowExecutionsRequest listWorkflowExecutionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id", listWorkflowExecutionsRequest.WorkflowId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/workflow/{workflow_id}/executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWorkflowExecutionsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listWorkflowExecutionsResponse = JsonUtils.DeSerializeNull<ListWorkflowExecutionsResponse>(response);
            listWorkflowExecutionsResponse.Body = JsonUtils.DeSerializeList<WorkflowExecutionBrief>(response);
            return listWorkflowExecutionsResponse;
        }

        public SyncInvoker<ListWorkflowExecutionsResponse> ListWorkflowExecutionsInvoker(ListWorkflowExecutionsRequest listWorkflowExecutionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id", listWorkflowExecutionsRequest.WorkflowId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/workflow/{workflow_id}/executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWorkflowExecutionsRequest);
            return new SyncInvoker<ListWorkflowExecutionsResponse>(this, "GET", request, response =>
            {
                var listWorkflowExecutionsResponse = JsonUtils.DeSerializeNull<ListWorkflowExecutionsResponse>(response);
                listWorkflowExecutionsResponse.Body = JsonUtils.DeSerializeList<WorkflowExecutionBrief>(response);
                return listWorkflowExecutionsResponse;
            });
        }
        
        /// <summary>
        /// 获取方案信息
        ///
        /// 该接口可根据执行方案id查询执行方案详情。（注：接口目前开放的region为：华北-北京四,华东-上海一,华东-上海二,华南-广州）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchTemplateByIdResponse SearchTemplateById(SearchTemplateByIdRequest searchTemplateByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("template_id", searchTemplateByIdRequest.TemplateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/template/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchTemplateByIdRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SearchTemplateByIdResponse>(response);
        }

        public SyncInvoker<SearchTemplateByIdResponse> SearchTemplateByIdInvoker(SearchTemplateByIdRequest searchTemplateByIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("template_id", searchTemplateByIdRequest.TemplateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/template/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchTemplateByIdRequest);
            return new SyncInvoker<SearchTemplateByIdResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchTemplateByIdResponse>);
        }
        
        /// <summary>
        /// 获取工作流执行中的执行详情
        ///
        /// 该接口可获取任务的执行详情，可指定工作流ID和执行ID去查询对应的任务，返回任务执行详情。（注：接口目前开放的region为：华北-北京四,华东-上海一,华东-上海二,华南-广州）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SearchWorkflowExecutionDetailResponse SearchWorkflowExecutionDetail(SearchWorkflowExecutionDetailRequest searchWorkflowExecutionDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id", searchWorkflowExecutionDetailRequest.WorkflowId.ToString());
            urlParam.Add("execution_id", searchWorkflowExecutionDetailRequest.ExecutionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/workflow/{workflow_id}/executions/{execution_id}/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchWorkflowExecutionDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<SearchWorkflowExecutionDetailResponse>(response);
        }

        public SyncInvoker<SearchWorkflowExecutionDetailResponse> SearchWorkflowExecutionDetailInvoker(SearchWorkflowExecutionDetailRequest searchWorkflowExecutionDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id", searchWorkflowExecutionDetailRequest.WorkflowId.ToString());
            urlParam.Add("execution_id", searchWorkflowExecutionDetailRequest.ExecutionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/workflow/{workflow_id}/executions/{execution_id}/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchWorkflowExecutionDetailRequest);
            return new SyncInvoker<SearchWorkflowExecutionDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<SearchWorkflowExecutionDetailResponse>);
        }
        
        /// <summary>
        /// 对暂停中的任务进行操作
        ///
        /// 该接口可对任务进行失败重试、失败跳过、暂停继续操作，返回操作结果。（注：接口目前开放的region为：华北-北京四,华东-上海一,华东-上海二,华南-广州）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StartPausingWorkflowExecutionsResponse StartPausingWorkflowExecutions(StartPausingWorkflowExecutionsRequest startPausingWorkflowExecutionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id", startPausingWorkflowExecutionsRequest.WorkflowId.ToString());
            urlParam.Add("execution_id", startPausingWorkflowExecutionsRequest.ExecutionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/workflow/{workflow_id}/executions/{execution_id}/operation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startPausingWorkflowExecutionsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StartPausingWorkflowExecutionsResponse>(response);
        }

        public SyncInvoker<StartPausingWorkflowExecutionsResponse> StartPausingWorkflowExecutionsInvoker(StartPausingWorkflowExecutionsRequest startPausingWorkflowExecutionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id", startPausingWorkflowExecutionsRequest.WorkflowId.ToString());
            urlParam.Add("execution_id", startPausingWorkflowExecutionsRequest.ExecutionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/workflow/{workflow_id}/executions/{execution_id}/operation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startPausingWorkflowExecutionsRequest);
            return new SyncInvoker<StartPausingWorkflowExecutionsResponse>(this, "POST", request, JsonUtils.DeSerialize<StartPausingWorkflowExecutionsResponse>);
        }
        
        /// <summary>
        /// 终止任务执行
        ///
        /// 该接口可终止正在执行的任务，指定工作流ID和执行ID去终止对应的任务，返回终止操作状态。（注：接口目前开放的region为：华北-北京四,华东-上海一,华东-上海二,华南-广州）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StopExecutionResponse StopExecution(StopExecutionRequest stopExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id", stopExecutionRequest.WorkflowId.ToString());
            urlParam.Add("execution_id", stopExecutionRequest.ExecutionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/workflow/{workflow_id}/executions/{execution_id}/terminate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopExecutionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<StopExecutionResponse>(response);
        }

        public SyncInvoker<StopExecutionResponse> StopExecutionInvoker(StopExecutionRequest stopExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id", stopExecutionRequest.WorkflowId.ToString());
            urlParam.Add("execution_id", stopExecutionRequest.ExecutionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/workflow/{workflow_id}/executions/{execution_id}/terminate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopExecutionRequest);
            return new SyncInvoker<StopExecutionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<StopExecutionResponse>);
        }
        
        /// <summary>
        /// 更新任务
        ///
        /// 更新定时任务的启停状态，可启动定时任务或停止定时任务，返回操作任务结果。（注：接口目前开放的region为：华北-北京四,华东-上海一,华东-上海二,华南-广州）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateWorkflowTriggerStatusResponse UpdateWorkflowTriggerStatus(UpdateWorkflowTriggerStatusRequest updateWorkflowTriggerStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id", updateWorkflowTriggerStatusRequest.WorkflowId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/workflow/{workflow_id}/trigger/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWorkflowTriggerStatusRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateWorkflowTriggerStatusResponse>(response);
        }

        public SyncInvoker<UpdateWorkflowTriggerStatusResponse> UpdateWorkflowTriggerStatusInvoker(UpdateWorkflowTriggerStatusRequest updateWorkflowTriggerStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id", updateWorkflowTriggerStatusRequest.WorkflowId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/workflow/{workflow_id}/trigger/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWorkflowTriggerStatusRequest);
            return new SyncInvoker<UpdateWorkflowTriggerStatusResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateWorkflowTriggerStatusResponse>);
        }
        
    }
}