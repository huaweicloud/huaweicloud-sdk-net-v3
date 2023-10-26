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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/fast-execute-script",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFastExecuteScriptRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateFastExecuteScriptResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/workflow",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWorkflowRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateWorkflowResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id" , executeWorkflowRequest.WorkflowId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/workflow/{workflow_id}/executions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", executeWorkflowRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ExecuteWorkflowResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/job/list",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllJobByNameRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListAllJobByNameResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/script/list",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllScriptByNameRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListAllScriptByNameResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/script-version-list",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllVersionByVersionIdRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListAllVersionByVersionIdResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , listTemplateByJobIdRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/template-list/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateByJobIdRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListTemplateByJobIdResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/workflow-list",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWorkflowRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListWorkflowResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id" , listWorkflowExecutionsRequest.WorkflowId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/workflow/{workflow_id}/executions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWorkflowExecutionsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            ListWorkflowExecutionsResponse listWorkflowExecutionsResponse = JsonUtils.DeSerializeNull<ListWorkflowExecutionsResponse>(response);
            listWorkflowExecutionsResponse.Body = JsonUtils.DeSerializeList<WorkflowExecutionBrief>(response);
            return listWorkflowExecutionsResponse;
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("template_id" , searchTemplateByIdRequest.TemplateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/template/{template_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchTemplateByIdRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<SearchTemplateByIdResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id" , searchWorkflowExecutionDetailRequest.WorkflowId.ToString());
            urlParam.Add("execution_id" , searchWorkflowExecutionDetailRequest.ExecutionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/workflow/{workflow_id}/executions/{execution_id}/status",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", searchWorkflowExecutionDetailRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<SearchWorkflowExecutionDetailResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id" , startPausingWorkflowExecutionsRequest.WorkflowId.ToString());
            urlParam.Add("execution_id" , startPausingWorkflowExecutionsRequest.ExecutionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/workflow/{workflow_id}/executions/{execution_id}/operation",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", startPausingWorkflowExecutionsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<StartPausingWorkflowExecutionsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id" , stopExecutionRequest.WorkflowId.ToString());
            urlParam.Add("execution_id" , stopExecutionRequest.ExecutionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/workflow/{workflow_id}/executions/{execution_id}/terminate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopExecutionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            StopExecutionResponse stopExecutionResponse = JsonUtils.DeSerializeNull<StopExecutionResponse>(response);
            return stopExecutionResponse;
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id" , updateWorkflowTriggerStatusRequest.WorkflowId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cms/workflow/{workflow_id}/trigger/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWorkflowTriggerStatusRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            UpdateWorkflowTriggerStatusResponse updateWorkflowTriggerStatusResponse = JsonUtils.DeSerializeNull<UpdateWorkflowTriggerStatusResponse>(response);
            return updateWorkflowTriggerStatusResponse;
        }
        
    }
}