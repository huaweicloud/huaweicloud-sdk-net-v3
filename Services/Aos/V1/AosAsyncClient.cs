using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Aos.V1.Model;

namespace HuaweiCloud.SDK.Aos.V1
{
    public partial class AosAsyncClient : Client
    {
        public static ClientBuilder<AosAsyncClient> NewBuilder()
        {
            return new ClientBuilder<AosAsyncClient>();
        }

        
        /// <summary>
        /// 此命令用于执行已有的执行计划(execution plan)
        ///
        /// 此命令用于执行已有的执行计划(execution plan)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ApplyExecutionPlanResponse> ApplyExecutionPlanAsync(ApplyExecutionPlanRequest applyExecutionPlanRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , applyExecutionPlanRequest.StackName.ToString());
            urlParam.Add("execution_plan_name" , applyExecutionPlanRequest.ExecutionPlanName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/execution-plans/{execution_plan_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyExecutionPlanRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ApplyExecutionPlanResponse>(response);
        }
        
        /// <summary>
        /// 此命令用于生成一个执行计划(execution plan)
        ///
        /// 此命令用于生成一个执行计划(execution plan)
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateExecutionPlanResponse> CreateExecutionPlanAsync(CreateExecutionPlanRequest createExecutionPlanRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , createExecutionPlanRequest.StackName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/execution-plans",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createExecutionPlanRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateExecutionPlanResponse>(response);
        }
        
        /// <summary>
        /// 删除堆栈
        ///
        /// 删除堆栈
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteStackResponse> DeleteStackAsync(DeleteStackRequest deleteStackRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , deleteStackRequest.StackName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteStackRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteStackResponse>(response);
        }
        
        /// <summary>
        /// 预估执行计划的价格
        ///
        /// 预估执行计划的价格
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EstimateExecutionPlanPriceResponse> EstimateExecutionPlanPriceAsync(EstimateExecutionPlanPriceRequest estimateExecutionPlanPriceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , estimateExecutionPlanPriceRequest.StackName.ToString());
            urlParam.Add("execution_plan_name" , estimateExecutionPlanPriceRequest.ExecutionPlanName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/execution-plans/{execution_plan_name}/prices",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", estimateExecutionPlanPriceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<EstimateExecutionPlanPriceResponse>(response);
        }
        
        /// <summary>
        /// 获取堆栈模板
        ///
        /// 获取堆栈当前使用的模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetStackTemplateResponse> GetStackTemplateAsync(GetStackTemplateRequest getStackTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , getStackTemplateRequest.StackName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/templates",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", getStackTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerializeNull<GetStackTemplateResponse>(response);
        }
        
        /// <summary>
        /// 列举执行计划
        ///
        /// 列举执行计划
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListExecutionPlansResponse> ListExecutionPlansAsync(ListExecutionPlansRequest listExecutionPlansRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , listExecutionPlansRequest.StackName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/execution-plans",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listExecutionPlansRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListExecutionPlansResponse>(response);
        }
        
        /// <summary>
        /// 获取栈的细节更新状态
        ///
        /// 获取栈的细节更新状态，可以获取整个栈从生成到当前时间点的所有状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListStackEventsResponse> ListStackEventsAsync(ListStackEventsRequest listStackEventsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , listStackEventsRequest.StackName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/events",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStackEventsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListStackEventsResponse>(response);
        }
        
        /// <summary>
        /// 列举堆栈的输出
        ///
        /// 列举堆栈的输出
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListStackOutputsResponse> ListStackOutputsAsync(ListStackOutputsRequest listStackOutputsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , listStackOutputsRequest.StackName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/outputs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStackOutputsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListStackOutputsResponse>(response);
        }
        
        /// <summary>
        /// 获取堆栈的资源列表
        ///
        /// 获取堆栈的资源列表，可以获取整个栈从生成到当前时间点的所有状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListStackResourcesResponse> ListStackResourcesAsync(ListStackResourcesRequest listStackResourcesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , listStackResourcesRequest.StackName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/resources",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStackResourcesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListStackResourcesResponse>(response);
        }
        
        /// <summary>
        /// 此命令用于解析模板参数
        ///
        /// 此命令用于解析模板参数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ParseTemplateVariablesResponse> ParseTemplateVariablesAsync(ParseTemplateVariablesRequest parseTemplateVariablesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template-analyses/variables",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", parseTemplateVariablesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ParseTemplateVariablesResponse>(response);
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
        public async Task<ContinueRollbackStackResponse> ContinueRollbackStackAsync(ContinueRollbackStackRequest continueRollbackStackRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , continueRollbackStackRequest.StackName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/rollbacks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", continueRollbackStackRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
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
        public async Task<CreateStackResponse> CreateStackAsync(CreateStackRequest createStackRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createStackRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateStackResponse>(response);
        }
        
        /// <summary>
        /// 部署一个已有的资源栈
        ///
        /// 部署一个已有的资源栈
        /// 
        /// * 用户可以使用此API更新模板、参数等并触发一个新的部署
        /// 
        /// * 此API会直接触发部署，如果用户希望先确认部署会发生的时间，请使用执行计划，即使用CreateExecutionPlan以创建执行计划、使用GetExecutionPlan以获取执行计划
        /// 
        /// * 此API为全量API，即用户每次部署都需要给予所想要使用的template、vars的全量
        /// 
        /// * 当触发的部署失败时，如果堆栈开启了自动回滚，会触发自动回滚的流程，否则就会停留在部署失败时的状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeployStackResponse> DeployStackAsync(DeployStackRequest deployStackRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , deployStackRequest.StackName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/deployments",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deployStackRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DeployStackResponse>(response);
        }
        
        /// <summary>
        /// 列举堆栈
        ///
        /// ListStacks 列举当前局点下用户所有的堆栈
        /// 
        ///   * 默认按照生成时间排序，最早生成的在最前
        ///   * 注意：目前暂时返回全量堆栈信息，即不支持分页
        ///   * 如果没有任何堆栈，则返回空list
        /// 
        /// ListStacks返回的只有摘要信息（具体摘要信息见ListStacksResponseBody），如果用户需要详细的资源栈元数据请调用GetStackMetadata
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListStacksResponse> ListStacksAsync(ListStacksRequest listStacksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStacksRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListStacksResponse>(response);
        }
        
    }
}