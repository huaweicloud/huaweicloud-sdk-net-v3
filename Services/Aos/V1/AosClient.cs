using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Aos.V1.Model;

namespace HuaweiCloud.SDK.Aos.V1
{
    public partial class AosClient : Client
    {
        public static ClientBuilder<AosClient> NewBuilder()
        {
            return new ClientBuilder<AosClient>();
        }

        
        /// <summary>
        /// 此命令用于执行已有的执行计划(execution plan)
        ///
        /// 此命令用于执行已有的执行计划(execution plan)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ApplyExecutionPlanResponse ApplyExecutionPlan(ApplyExecutionPlanRequest applyExecutionPlanRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , applyExecutionPlanRequest.StackName.ToString());
            urlParam.Add("execution_plan_name" , applyExecutionPlanRequest.ExecutionPlanName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/execution-plans/{execution_plan_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyExecutionPlanRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ApplyExecutionPlanResponse>(response);
        }
        
        /// <summary>
        /// 此命令用于生成一个执行计划(execution plan)
        ///
        /// 此命令用于生成一个执行计划(execution plan)
        /// * 如果资源栈删除失败，可在修复当前模板中的错误后调用CreateExecutionPlan生成执行计划。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateExecutionPlanResponse CreateExecutionPlan(CreateExecutionPlanRequest createExecutionPlanRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , createExecutionPlanRequest.StackName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/execution-plans",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createExecutionPlanRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateExecutionPlanResponse>(response);
        }
        
        /// <summary>
        /// 此命令用于删除已有的执行计划(execution plan)
        ///
        /// 此命令用于删除已有的执行计划(execution plan)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteExecutionPlanResponse DeleteExecutionPlan(DeleteExecutionPlanRequest deleteExecutionPlanRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , deleteExecutionPlanRequest.StackName.ToString());
            urlParam.Add("execution_plan_name" , deleteExecutionPlanRequest.ExecutionPlanName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/execution-plans/{execution_plan_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteExecutionPlanRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteExecutionPlanResponse>(response);
        }
        
        /// <summary>
        /// 描述执行计划当前的状态，返回执行计划的元数据
        ///
        /// 描述执行计划当前的状态，返回执行计划的元数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DescribeExecutionPlanResponse DescribeExecutionPlan(DescribeExecutionPlanRequest describeExecutionPlanRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , describeExecutionPlanRequest.StackName.ToString());
            urlParam.Add("execution_plan_name" , describeExecutionPlanRequest.ExecutionPlanName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/execution-plans/{execution_plan_name}/metadata",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", describeExecutionPlanRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<DescribeExecutionPlanResponse>(response);
        }
        
        /// <summary>
        /// 预估执行计划的价格
        ///
        /// 预估执行计划的价格
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EstimateExecutionPlanPriceResponse EstimateExecutionPlanPrice(EstimateExecutionPlanPriceRequest estimateExecutionPlanPriceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , estimateExecutionPlanPriceRequest.StackName.ToString());
            urlParam.Add("execution_plan_name" , estimateExecutionPlanPriceRequest.ExecutionPlanName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/execution-plans/{execution_plan_name}/prices",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", estimateExecutionPlanPriceRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<EstimateExecutionPlanPriceResponse>(response);
        }
        
        /// <summary>
        /// 此接口用于获取执行计划的详细内容
        ///
        /// 此接口用于获取执行计划的详细内容
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetExecutionPlanResponse GetExecutionPlan(GetExecutionPlanRequest getExecutionPlanRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , getExecutionPlanRequest.StackName.ToString());
            urlParam.Add("execution_plan_name" , getExecutionPlanRequest.ExecutionPlanName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/execution-plans/{execution_plan_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", getExecutionPlanRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<GetExecutionPlanResponse>(response);
        }
        
        /// <summary>
        /// 列举执行计划
        ///
        /// 列举执行计划
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListExecutionPlansResponse ListExecutionPlans(ListExecutionPlansRequest listExecutionPlansRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , listExecutionPlansRequest.StackName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/execution-plans",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listExecutionPlansRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListExecutionPlansResponse>(response);
        }
        
        /// <summary>
        /// 继续回滚资源栈
        ///
        /// 如果资源栈开启了自动回滚，在部署失败的时候则会自动回滚。但是自动回滚依然有可能失败，用户可以根据错误信息修复后，调用ContinueRollbackStack触发继续回滚，即重试回滚
        /// 
        /// * 如果资源栈当前可以回滚，即处于&#x60;ROLLBACK_FAILED&#x60;，则返回202与对应生成的deploymentId，否则将不允许回滚并返回响应的错误码
        /// * 继续回滚也有可能会回滚失败。如果失败，用户可以从ListStackEvents获取对应的log，解决后可再次调用ContinueRollbackStack去继续触发回滚
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ContinueRollbackStackResponse ContinueRollbackStack(ContinueRollbackStackRequest continueRollbackStackRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , continueRollbackStackRequest.StackName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/rollbacks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", continueRollbackStackRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ContinueRollbackStackResponse>(response);
        }
        
        /// <summary>
        /// 创建资源栈
        ///
        /// CreateStack用于生成一个资源栈
        /// 
        /// * 当请求中不含有模板（template）、参数（vars）等信息，将生成一个无任何资源的空资源栈，返回资源栈ID（stack_id）
        /// * 当请求中携带了模板（template）、参数（vars）等信息，则会同时创建并部署资源栈，返回资源栈ID（stack_id）和部署ID（deployment_id）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateStackResponse CreateStack(CreateStackRequest createStackRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createStackRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateStackResponse>(response);
        }
        
        /// <summary>
        /// 删除资源栈
        ///
        /// 删除某个资源栈
        /// **请谨慎操作，删除资源栈将会删除与该资源栈相关的所有数据和资源，如：执行计划、资源栈事件、资源栈输出、资源等。**
        /// 
        /// * 此API会触发删除资源栈，并以最终一致性删除所有数据，用户可以调用GetStackMetadata或ListStacks跟踪资源栈删除情况
        /// * 如果资源栈状态处于非终态（状态以&#x60;IN_PROGRESS&#x60;结尾）状态时，则不允许删除。包括但不限于以下状态：
        ///   * 正在部署（DEPLOYMENT_IN_PROGRESS）
        ///   * 正在删除（DELETION_IN_PROGRESS）
        ///   * 正在回滚（ROLLBACK_IN_PROGRESS）
        /// * 如果资源栈开启了删除保护，则不允许删除。用户可调用GetStackMetadata，查看返回中的&#x60;enable_deletion_protection&#x60;字段判断删除保护是否开启。用户可通过调用UpdateStack关闭删除保护。
        /// * 如果资源栈删除失败，可以根据StackEvents提示信息修复当前模板中的错误后，部署成功后再次删除资源栈。有以下两种方式触发部署：
        ///   * 调用CreateExecutionPlan创建执行计划，执行计划创建成功后调用ApplyExecutionPlan部署资源栈。
        ///   * 调用DeployStack部署资源栈
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteStackResponse DeleteStack(DeleteStackRequest deleteStackRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , deleteStackRequest.StackName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteStackRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteStackResponse>(response);
        }
        
        /// <summary>
        /// 部署资源栈
        ///
        /// 部署一个已有的资源栈
        /// 
        /// * 用户可以使用此API更新模板、参数等并触发一个新的部署
        /// 
        /// * 此API会直接触发部署，如果用户希望先确认部署会发生的时间，请使用执行计划，即使用CreateExecutionPlan以创建执行计划、使用GetExecutionPlan以获取执行计划
        /// 
        /// * 此API为全量API，即用户每次部署都需要给予所想要使用的template、vars的全量
        /// 
        /// * 当触发的部署失败时，如果资源栈开启了自动回滚，会触发自动回滚的流程，否则就会停留在部署失败时的状态
        /// 
        /// * 资源栈状态是DELETION_FAILED时，用户可根据StackEvents信息修复当前模板中的错误后，重新触发部署。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeployStackResponse DeployStack(DeployStackRequest deployStackRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , deployStackRequest.StackName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/deployments",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deployStackRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DeployStackResponse>(response);
        }
        
        /// <summary>
        /// 获取资源栈的元数据
        ///
        /// 获取资源栈的元数据，包括资源栈ID、资源栈名称、资源栈描述、创建时间、更新时间、资源栈状态、委托授权等信息。
        /// 
        /// 具体信息见GetStackMetadataResponseBody。
        /// 
        /// 注：
        /// 当资源栈状态处于非终态（即以&#x60;IN_PROGRESS&#x60;结尾，详细见下方）状态时，资源栈的元数据信息处于转变阶段，可能为部署前的状态，也可能为部署后的状态。
        /// 只有当资源栈状态处于终态（即以&#x60;COMPLETE&#x60;或&#x60;FAILED&#x60;结尾，详细见下方）时，资源栈的元数据信息才是部署后的状态
        /// 
        /// 非终态状态包括但不限于以下状态：
        ///   * 正在部署（DEPLOYMENT_IN_PROGRESS）
        ///   * 正在回滚（ROLLBACK_IN_PROGRESS）
        ///   * 正在删除（DELETION_IN_PROGRESS）
        /// 
        /// 终态状态包括但不限于以下状态：
        ///   * 生成空资源栈完成（CREATION_COMPLETE）
        ///   * 部署失败（DEPLOYMENT_FAILED）
        ///   * 部署完成（DEPLOYMENT_COMPLETE）
        ///   * 回滚失败（ROLLBACK_FAILED）
        ///   * 回滚完成（ROLLBACK_COMPLETE）
        ///   * 删除失败（DELETION_FAILED）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetStackMetadataResponse GetStackMetadata(GetStackMetadataRequest getStackMetadataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , getStackMetadataRequest.StackName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/metadata",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", getStackMetadataRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<GetStackMetadataResponse>(response);
        }
        
        /// <summary>
        /// 获取资源栈模板
        ///
        /// 获取资源栈最近的一次部署使用的模板。
        /// 
        /// 如果获取成功，则以临时重定向形式返回模板下载链接，大多数的客户端会进行自动重定向并下载模板；若未进行自动重定向，请参考HTTP的重定向规则获取模板下载链接，手动下载模板
        /// 
        /// 如果资源栈当前没有模板，则返回404，并提示模板不存在
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public GetStackTemplateResponse GetStackTemplate(GetStackTemplateRequest getStackTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , getStackTemplateRequest.StackName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/templates",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", getStackTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerializeNull<GetStackTemplateResponse>(response);
        }
        
        /// <summary>
        /// 列举资源栈事件
        ///
        /// 列举资源栈某一次或全部的部署事件
        /// 
        /// * 若给予deployment_id，则会将deployment_id作为查询条件，返回对应某一次部署的资源栈事件；若不给予deployment_id，则返回全量的资源栈事件
        /// * 若给定的deployment_id对应的部署不存在，则返回404
        /// * 可以使用filter作为过滤器，过滤出指定事件类型（event_type）、资源类型（resource_type）、资源名称（resource_name）的资源栈事件
        /// * 可以使用field选择数据应返回的属性，属性事件类型（event_type）不可配置，一定会返回，可选择的属性有逝去时间（elapsed_seconds）、事件消息（event_message）、 资源ID键（resource_id_key）、资源ID值（resource_id_value）、资源键（resource_key）、资源类型（resource_type）、资源名称（resource_name）和时间戳（timestamp）
        /// * 事件返回将以时间降序排列
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListStackEventsResponse ListStackEvents(ListStackEventsRequest listStackEventsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , listStackEventsRequest.StackName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/events",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStackEventsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListStackEventsResponse>(response);
        }
        
        /// <summary>
        /// 列举资源栈输出
        ///
        /// 列举该资源栈的所有输出
        /// 
        /// 资源栈输出为用户在模板中定义的 output 语句块在部署结束后所产生的返回信息，用户可在部署结束后，调用此API获取其具体的输出信息
        /// 
        /// output为HCL官方定义的语法，其返回信息类似于常见编程语言中的返回值，详细定义请参考HCL官方的说明
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListStackOutputsResponse ListStackOutputs(ListStackOutputsRequest listStackOutputsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , listStackOutputsRequest.StackName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/outputs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStackOutputsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListStackOutputsResponse>(response);
        }
        
        /// <summary>
        /// 列举资源栈资源
        ///
        /// 列举资源栈中当前管理的所有资源的信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListStackResourcesResponse ListStackResources(ListStackResourcesRequest listStackResourcesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , listStackResourcesRequest.StackName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/resources",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStackResourcesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListStackResourcesResponse>(response);
        }
        
        /// <summary>
        /// 列举资源栈
        ///
        /// ListStacks 列举当前局点下用户所有的资源栈
        /// 
        ///   * 默认按照生成时间排序，最早生成的在最前
        ///   * 注意：目前暂时返回全量资源栈信息，即不支持分页
        ///   * 如果没有任何资源栈，则返回空list
        /// 
        /// ListStacks返回的只有摘要信息（具体摘要信息见ListStacksResponseBody），如果用户需要详细的资源栈元数据请调用GetStackMetadata
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListStacksResponse ListStacks(ListStacksRequest listStacksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStacksRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListStacksResponse>(response);
        }
        
        /// <summary>
        /// 更新资源栈
        ///
        /// 更新资源栈的“description”、“enable_deletion_protection”、\&quot;enable_auto_rollback\&quot;、\&quot;agencies\&quot;四个属性字段中的一个或多个
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateStackResponse UpdateStack(UpdateStackRequest updateStackRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , updateStackRequest.StackName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateStackRequest);
            HttpResponseMessage response = DoHttpRequestSync("PATCH",request);
            return JsonUtils.DeSerializeNull<UpdateStackResponse>(response);
        }
        
        /// <summary>
        /// 此命令用于解析模板参数
        ///
        /// 此命令用于解析模板参数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ParseTemplateVariablesResponse ParseTemplateVariables(ParseTemplateVariablesRequest parseTemplateVariablesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template-analyses/variables",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", parseTemplateVariablesRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ParseTemplateVariablesResponse>(response);
        }
        
    }
}