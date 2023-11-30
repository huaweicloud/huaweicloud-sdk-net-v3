using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.FunctionGraph.V2.Model;

namespace HuaweiCloud.SDK.FunctionGraph.V2
{
    public partial class FunctionGraphAsyncClient : Client
    {
        public static ClientBuilder<FunctionGraphAsyncClient> NewBuilder()
        {
            return new ClientBuilder<FunctionGraphAsyncClient>();
        }

        
        /// <summary>
        /// 异步执行函数
        ///
        /// 异步执行函数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AsyncInvokeFunctionResponse> AsyncInvokeFunctionAsync(AsyncInvokeFunctionRequest asyncInvokeFunctionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", asyncInvokeFunctionRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/invocations-async",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", asyncInvokeFunctionRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AsyncInvokeFunctionResponse>(response);
        }

        public AsyncInvoker<AsyncInvokeFunctionResponse> AsyncInvokeFunctionAsyncInvoker(AsyncInvokeFunctionRequest asyncInvokeFunctionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", asyncInvokeFunctionRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/invocations-async",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", asyncInvokeFunctionRequest);
            return new AsyncInvoker<AsyncInvokeFunctionResponse>(this, "POST", request, JsonUtils.DeSerialize<AsyncInvokeFunctionResponse>);
        }
        
        /// <summary>
        /// 函数异步执行并返回预留实例ID
        ///
        /// 函数异步执行并返回预留实例ID用于场景指客户端请求执行比较费时任务，不需要同步等待执行完成返回结果，该方法提前返回任务执行对应的预留实例ID, 如果预留实例有异常，可以通过该实例ID把对应实例删除（该接口主要针对白名单用户）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AsyncInvokeReservedFunctionResponse> AsyncInvokeReservedFunctionAsync(AsyncInvokeReservedFunctionRequest asyncInvokeReservedFunctionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", asyncInvokeReservedFunctionRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/reserved-invocations",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", asyncInvokeReservedFunctionRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AsyncInvokeReservedFunctionResponse>(response);
        }

        public AsyncInvoker<AsyncInvokeReservedFunctionResponse> AsyncInvokeReservedFunctionAsyncInvoker(AsyncInvokeReservedFunctionRequest asyncInvokeReservedFunctionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", asyncInvokeReservedFunctionRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/reserved-invocations",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", asyncInvokeReservedFunctionRequest);
            return new AsyncInvoker<AsyncInvokeReservedFunctionResponse>(this, "POST", request, JsonUtils.DeSerialize<AsyncInvokeReservedFunctionResponse>);
        }
        
        /// <summary>
        /// 删除指定函数的所有触发器
        ///
        /// 删除指定函数所有触发器设置。
        /// 
        /// 在提供函数版本且非latest的情况下，删除对应函数版本的触发器。
        /// 在提供函数别名的情况下，删除对应函数别名的触发器。
        /// 在不提供函数版本（也不提供别名）或版本为latest的情况下，删除该函数所有的触发器（包括所有版本和别名）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteFunctionTriggersResponse> BatchDeleteFunctionTriggersAsync(BatchDeleteFunctionTriggersRequest batchDeleteFunctionTriggersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", batchDeleteFunctionTriggersRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteFunctionTriggersRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<BatchDeleteFunctionTriggersResponse>(response);
        }

        public AsyncInvoker<BatchDeleteFunctionTriggersResponse> BatchDeleteFunctionTriggersAsyncInvoker(BatchDeleteFunctionTriggersRequest batchDeleteFunctionTriggersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", batchDeleteFunctionTriggersRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteFunctionTriggersRequest);
            return new AsyncInvoker<BatchDeleteFunctionTriggersResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<BatchDeleteFunctionTriggersResponse>);
        }
        
        /// <summary>
        /// 删除函数流
        ///
        /// 删除函数流
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteWorkflowsResponse> BatchDeleteWorkflowsAsync(BatchDeleteWorkflowsRequest batchDeleteWorkflowsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteWorkflowsRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<BatchDeleteWorkflowsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteWorkflowsResponse> BatchDeleteWorkflowsAsyncInvoker(BatchDeleteWorkflowsRequest batchDeleteWorkflowsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteWorkflowsRequest);
            return new AsyncInvoker<BatchDeleteWorkflowsResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteWorkflowsResponse>);
        }
        
        /// <summary>
        /// 停止函数异步调用请求
        ///
        /// -| 当前仅支持参数recursive为false且force为true的函数。 在1：N的函数做并发异步调用的场景下调用停止异步请求接口时，同一函数实例同时在执行的其他请求也会被一并停止并返回4208 function invocation canceled
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CancelAsyncInvocationResponse> CancelAsyncInvocationAsync(CancelAsyncInvocationRequest cancelAsyncInvocationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", cancelAsyncInvocationRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/cancel",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelAsyncInvocationRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CancelAsyncInvocationResponse>(response);
        }

        public AsyncInvoker<CancelAsyncInvocationResponse> CancelAsyncInvocationAsyncInvoker(CancelAsyncInvocationRequest cancelAsyncInvocationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", cancelAsyncInvocationRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/cancel",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelAsyncInvocationRequest);
            return new AsyncInvoker<CancelAsyncInvocationResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CancelAsyncInvocationResponse>);
        }
        
        /// <summary>
        /// 回调工作流
        ///
        /// 回调工作流
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateCallbackWorkflowResponse> CreateCallbackWorkflowAsync(CreateCallbackWorkflowRequest createCallbackWorkflowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id", createCallbackWorkflowRequest.WorkflowId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/callback",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCallbackWorkflowRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateCallbackWorkflowResponse>(response);
        }

        public AsyncInvoker<CreateCallbackWorkflowResponse> CreateCallbackWorkflowAsyncInvoker(CreateCallbackWorkflowRequest createCallbackWorkflowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id", createCallbackWorkflowRequest.WorkflowId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/callback",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCallbackWorkflowRequest);
            return new AsyncInvoker<CreateCallbackWorkflowResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCallbackWorkflowResponse>);
        }
        
        /// <summary>
        /// 创建依赖包
        ///
        /// 创建依赖包
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDependencyResponse> CreateDependencyAsync(CreateDependencyRequest createDependencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDependencyRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateDependencyResponse>(response);
        }

        public AsyncInvoker<CreateDependencyResponse> CreateDependencyAsyncInvoker(CreateDependencyRequest createDependencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDependencyRequest);
            return new AsyncInvoker<CreateDependencyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDependencyResponse>);
        }
        
        /// <summary>
        /// 创建依赖包版本
        ///
        /// 创建依赖包版本
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDependencyVersionResponse> CreateDependencyVersionAsync(CreateDependencyVersionRequest createDependencyVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies/version",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDependencyVersionRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateDependencyVersionResponse>(response);
        }

        public AsyncInvoker<CreateDependencyVersionResponse> CreateDependencyVersionAsyncInvoker(CreateDependencyVersionRequest createDependencyVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies/version",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDependencyVersionRequest);
            return new AsyncInvoker<CreateDependencyVersionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDependencyVersionResponse>);
        }
        
        /// <summary>
        /// 创建测试事件
        ///
        /// 创建测试事件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateEventResponse> CreateEventAsync(CreateEventRequest createEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", createEventRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/events",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEventRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateEventResponse>(response);
        }

        public AsyncInvoker<CreateEventResponse> CreateEventAsyncInvoker(CreateEventRequest createEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", createEventRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/events",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEventRequest);
            return new AsyncInvoker<CreateEventResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateEventResponse>);
        }
        
        /// <summary>
        /// 创建函数
        ///
        /// 创建指定的函数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateFunctionResponse> CreateFunctionAsync(CreateFunctionRequest createFunctionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFunctionRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateFunctionResponse>(response);
        }

        public AsyncInvoker<CreateFunctionResponse> CreateFunctionAsyncInvoker(CreateFunctionRequest createFunctionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFunctionRequest);
            return new AsyncInvoker<CreateFunctionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateFunctionResponse>);
        }
        
        /// <summary>
        /// 创建应用程序
        ///
        /// 创建应用程序
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateFunctionAppResponse> CreateFunctionAppAsync(CreateFunctionAppRequest createFunctionAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/applications",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFunctionAppRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateFunctionAppResponse>(response);
        }

        public AsyncInvoker<CreateFunctionAppResponse> CreateFunctionAppAsyncInvoker(CreateFunctionAppRequest createFunctionAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/applications",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFunctionAppRequest);
            return new AsyncInvoker<CreateFunctionAppResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateFunctionAppResponse>);
        }
        
        /// <summary>
        /// 创建触发器
        ///
        /// 创建触发器。
        /// 
        /// - 可以创建的触发器类型包括TIMER、APIG、CTS、DDS、DMS、DIS、LTS、OBS、SMN、KAFKA。
        /// - DDS和KAFKA触发器创建时默认为DISABLED状态，其他触发器默认为ACTIVE状态。
        /// - TIMER、DDS、DMS、KAFKA、LTS触发器支持禁用，其他触发器不支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateFunctionTriggerResponse> CreateFunctionTriggerAsync(CreateFunctionTriggerRequest createFunctionTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", createFunctionTriggerRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFunctionTriggerRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateFunctionTriggerResponse>(response);
        }

        public AsyncInvoker<CreateFunctionTriggerResponse> CreateFunctionTriggerAsyncInvoker(CreateFunctionTriggerRequest createFunctionTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", createFunctionTriggerRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFunctionTriggerRequest);
            return new AsyncInvoker<CreateFunctionTriggerResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateFunctionTriggerResponse>);
        }
        
        /// <summary>
        /// 发布函数版本
        ///
        /// 发布函数版本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateFunctionVersionResponse> CreateFunctionVersionAsync(CreateFunctionVersionRequest createFunctionVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", createFunctionVersionRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/versions",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFunctionVersionRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateFunctionVersionResponse>(response);
        }

        public AsyncInvoker<CreateFunctionVersionResponse> CreateFunctionVersionAsyncInvoker(CreateFunctionVersionRequest createFunctionVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", createFunctionVersionRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/versions",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFunctionVersionRequest);
            return new AsyncInvoker<CreateFunctionVersionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateFunctionVersionResponse>);
        }
        
        /// <summary>
        /// 创建资源标签
        ///
        /// 创建资源标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest createTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", createTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id", createTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/create",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateTagsResponse>(response);
        }

        public AsyncInvoker<CreateTagsResponse> CreateTagsAsyncInvoker(CreateTagsRequest createTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", createTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id", createTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/create",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagsRequest);
            return new AsyncInvoker<CreateTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateTagsResponse>);
        }
        
        /// <summary>
        /// 创建函数版本别名
        ///
        /// 创建函数灰度版本别名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateVersionAliasResponse> CreateVersionAliasAsync(CreateVersionAliasRequest createVersionAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", createVersionAliasRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/aliases",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVersionAliasRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateVersionAliasResponse>(response);
        }

        public AsyncInvoker<CreateVersionAliasResponse> CreateVersionAliasAsyncInvoker(CreateVersionAliasRequest createVersionAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", createVersionAliasRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/aliases",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVersionAliasRequest);
            return new AsyncInvoker<CreateVersionAliasResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateVersionAliasResponse>);
        }
        
        /// <summary>
        /// 创建下沉入口
        ///
        /// 创建下沉入口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateVpcEndpointResponse> CreateVpcEndpointAsync(CreateVpcEndpointRequest createVpcEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/vpc-endpoint",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVpcEndpointRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateVpcEndpointResponse>(response);
        }

        public AsyncInvoker<CreateVpcEndpointResponse> CreateVpcEndpointAsyncInvoker(CreateVpcEndpointRequest createVpcEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/vpc-endpoint",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVpcEndpointRequest);
            return new AsyncInvoker<CreateVpcEndpointResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateVpcEndpointResponse>);
        }
        
        /// <summary>
        /// 创建函数流
        ///
        /// 创建函数流
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateWorkflowResponse> CreateWorkflowAsync(CreateWorkflowRequest createWorkflowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWorkflowRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateWorkflowResponse>(response);
        }

        public AsyncInvoker<CreateWorkflowResponse> CreateWorkflowAsyncInvoker(CreateWorkflowRequest createWorkflowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWorkflowRequest);
            return new AsyncInvoker<CreateWorkflowResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateWorkflowResponse>);
        }
        
        /// <summary>
        /// 删除指定的依赖包
        ///
        /// 删除指定的依赖包
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDependencyResponse> DeleteDependencyAsync(DeleteDependencyRequest deleteDependencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("depend_id", deleteDependencyRequest.DependId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies/{depend_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDependencyRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteDependencyResponse>(response);
        }

        public AsyncInvoker<DeleteDependencyResponse> DeleteDependencyAsyncInvoker(DeleteDependencyRequest deleteDependencyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("depend_id", deleteDependencyRequest.DependId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies/{depend_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDependencyRequest);
            return new AsyncInvoker<DeleteDependencyResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDependencyResponse>);
        }
        
        /// <summary>
        /// 删除依赖包版本
        ///
        /// 删除依赖包版本
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDependencyVersionResponse> DeleteDependencyVersionAsync(DeleteDependencyVersionRequest deleteDependencyVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("depend_id", deleteDependencyVersionRequest.DependId.ToString());
            urlParam.Add("version", deleteDependencyVersionRequest.Version.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies/{depend_id}/version/{version}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDependencyVersionRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteDependencyVersionResponse>(response);
        }

        public AsyncInvoker<DeleteDependencyVersionResponse> DeleteDependencyVersionAsyncInvoker(DeleteDependencyVersionRequest deleteDependencyVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("depend_id", deleteDependencyVersionRequest.DependId.ToString());
            urlParam.Add("version", deleteDependencyVersionRequest.Version.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies/{depend_id}/version/{version}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDependencyVersionRequest);
            return new AsyncInvoker<DeleteDependencyVersionResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDependencyVersionResponse>);
        }
        
        /// <summary>
        /// 删除指定测试事件
        ///
        /// 删除指定测试事件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteEventResponse> DeleteEventAsync(DeleteEventRequest deleteEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", deleteEventRequest.FunctionUrn.ToString());
            urlParam.Add("event_id", deleteEventRequest.EventId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/events/{event_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEventRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteEventResponse>(response);
        }

        public AsyncInvoker<DeleteEventResponse> DeleteEventAsyncInvoker(DeleteEventRequest deleteEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", deleteEventRequest.FunctionUrn.ToString());
            urlParam.Add("event_id", deleteEventRequest.EventId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/events/{event_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEventRequest);
            return new AsyncInvoker<DeleteEventResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteEventResponse>);
        }
        
        /// <summary>
        /// 删除函数/版本
        ///
        /// 删除指定的函数或者特定的版本（不允许删除latest版本）。
        /// 
        /// 如果URN中包含函数版本或者别名，则删除特定的函数版本或者别名指向的版本以及该版本关联的trigger。
        /// 如果URN中不包含版本或者别名，则删除整个函数，包含所有版本以及别名，触发器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteFunctionResponse> DeleteFunctionAsync(DeleteFunctionRequest deleteFunctionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", deleteFunctionRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFunctionRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteFunctionResponse>(response);
        }

        public AsyncInvoker<DeleteFunctionResponse> DeleteFunctionAsyncInvoker(DeleteFunctionRequest deleteFunctionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", deleteFunctionRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFunctionRequest);
            return new AsyncInvoker<DeleteFunctionResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteFunctionResponse>);
        }
        
        /// <summary>
        /// 删除应用程序
        ///
        /// 删除应用程序
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteFunctionAppResponse> DeleteFunctionAppAsync(DeleteFunctionAppRequest deleteFunctionAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteFunctionAppRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/applications/{id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFunctionAppRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteFunctionAppResponse>(response);
        }

        public AsyncInvoker<DeleteFunctionAppResponse> DeleteFunctionAppAsyncInvoker(DeleteFunctionAppRequest deleteFunctionAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteFunctionAppRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/applications/{id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFunctionAppRequest);
            return new AsyncInvoker<DeleteFunctionAppResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteFunctionAppResponse>);
        }
        
        /// <summary>
        /// 删除函数异步配置信息
        ///
        /// 删除函数异步配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteFunctionAsyncInvokeConfigResponse> DeleteFunctionAsyncInvokeConfigAsync(DeleteFunctionAsyncInvokeConfigRequest deleteFunctionAsyncInvokeConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", deleteFunctionAsyncInvokeConfigRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/async-invoke-config",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFunctionAsyncInvokeConfigRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteFunctionAsyncInvokeConfigResponse>(response);
        }

        public AsyncInvoker<DeleteFunctionAsyncInvokeConfigResponse> DeleteFunctionAsyncInvokeConfigAsyncInvoker(DeleteFunctionAsyncInvokeConfigRequest deleteFunctionAsyncInvokeConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", deleteFunctionAsyncInvokeConfigRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/async-invoke-config",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFunctionAsyncInvokeConfigRequest);
            return new AsyncInvoker<DeleteFunctionAsyncInvokeConfigResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteFunctionAsyncInvokeConfigResponse>);
        }
        
        /// <summary>
        /// 删除触发器
        ///
        /// 删除触发器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteFunctionTriggerResponse> DeleteFunctionTriggerAsync(DeleteFunctionTriggerRequest deleteFunctionTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", deleteFunctionTriggerRequest.FunctionUrn.ToString());
            urlParam.Add("trigger_type_code", deleteFunctionTriggerRequest.TriggerTypeCode.ToString());
            urlParam.Add("trigger_id", deleteFunctionTriggerRequest.TriggerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}/{trigger_type_code}/{trigger_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFunctionTriggerRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteFunctionTriggerResponse>(response);
        }

        public AsyncInvoker<DeleteFunctionTriggerResponse> DeleteFunctionTriggerAsyncInvoker(DeleteFunctionTriggerRequest deleteFunctionTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", deleteFunctionTriggerRequest.FunctionUrn.ToString());
            urlParam.Add("trigger_type_code", deleteFunctionTriggerRequest.TriggerTypeCode.ToString());
            urlParam.Add("trigger_id", deleteFunctionTriggerRequest.TriggerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}/{trigger_type_code}/{trigger_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFunctionTriggerRequest);
            return new AsyncInvoker<DeleteFunctionTriggerResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteFunctionTriggerResponse>);
        }
        
        /// <summary>
        /// 删除资源标签
        ///
        /// 删除资源标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest deleteTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", deleteTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id", deleteTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/delete",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagsRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTagsResponse>(response);
        }

        public AsyncInvoker<DeleteTagsResponse> DeleteTagsAsyncInvoker(DeleteTagsRequest deleteTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", deleteTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id", deleteTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/delete",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagsRequest);
            return new AsyncInvoker<DeleteTagsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTagsResponse>);
        }
        
        /// <summary>
        /// 删除函数版本别名
        ///
        /// 删除函数版本别名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteVersionAliasResponse> DeleteVersionAliasAsync(DeleteVersionAliasRequest deleteVersionAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", deleteVersionAliasRequest.FunctionUrn.ToString());
            urlParam.Add("alias_name", deleteVersionAliasRequest.AliasName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/aliases/{alias_name}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVersionAliasRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteVersionAliasResponse>(response);
        }

        public AsyncInvoker<DeleteVersionAliasResponse> DeleteVersionAliasAsyncInvoker(DeleteVersionAliasRequest deleteVersionAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", deleteVersionAliasRequest.FunctionUrn.ToString());
            urlParam.Add("alias_name", deleteVersionAliasRequest.AliasName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/aliases/{alias_name}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVersionAliasRequest);
            return new AsyncInvoker<DeleteVersionAliasResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteVersionAliasResponse>);
        }
        
        /// <summary>
        /// 删除下沉入口
        ///
        /// 删除下沉入口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteVpcEndpointResponse> DeleteVpcEndpointAsync(DeleteVpcEndpointRequest deleteVpcEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", deleteVpcEndpointRequest.VpcId.ToString());
            urlParam.Add("subnet_id", deleteVpcEndpointRequest.SubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/vpc-endpoint/{vpc_id}/{subnet_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVpcEndpointRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteVpcEndpointResponse>(response);
        }

        public AsyncInvoker<DeleteVpcEndpointResponse> DeleteVpcEndpointAsyncInvoker(DeleteVpcEndpointRequest deleteVpcEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id", deleteVpcEndpointRequest.VpcId.ToString());
            urlParam.Add("subnet_id", deleteVpcEndpointRequest.SubnetId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/vpc-endpoint/{vpc_id}/{subnet_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVpcEndpointRequest);
            return new AsyncInvoker<DeleteVpcEndpointResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteVpcEndpointResponse>);
        }
        
        /// <summary>
        /// 允许异步状态通知
        ///
        /// 允许异步状态通知。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EnableAsyncStatusLogResponse> EnableAsyncStatusLogAsync(EnableAsyncStatusLogRequest enableAsyncStatusLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/enable-async-status-logs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableAsyncStatusLogRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<EnableAsyncStatusLogResponse>(response);
        }

        public AsyncInvoker<EnableAsyncStatusLogResponse> EnableAsyncStatusLogAsyncInvoker(EnableAsyncStatusLogRequest enableAsyncStatusLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/enable-async-status-logs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableAsyncStatusLogRequest);
            return new AsyncInvoker<EnableAsyncStatusLogResponse>(this, "POST", request, JsonUtils.DeSerializeNull<EnableAsyncStatusLogResponse>);
        }
        
        /// <summary>
        /// 开通lts日志上报功能
        ///
        /// 开通lts日志上报功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EnableLtsLogsResponse> EnableLtsLogsAsync(EnableLtsLogsRequest enableLtsLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/enable-lts-logs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableLtsLogsRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<EnableLtsLogsResponse>(response);
        }

        public AsyncInvoker<EnableLtsLogsResponse> EnableLtsLogsAsyncInvoker(EnableLtsLogsRequest enableLtsLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/enable-lts-logs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableLtsLogsRequest);
            return new AsyncInvoker<EnableLtsLogsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<EnableLtsLogsResponse>);
        }
        
        /// <summary>
        /// 导出函数
        ///
        /// 导出函数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExportFunctionResponse> ExportFunctionAsync(ExportFunctionRequest exportFunctionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", exportFunctionRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/export",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportFunctionRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerializeNull<ExportFunctionResponse>(response);
        }

        public AsyncInvoker<ExportFunctionResponse> ExportFunctionAsyncInvoker(ExportFunctionRequest exportFunctionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", exportFunctionRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/export",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportFunctionRequest);
            return new AsyncInvoker<ExportFunctionResponse>(this, "GET", request, JsonUtils.DeSerializeNull<ExportFunctionResponse>);
        }
        
        /// <summary>
        /// 导入函数
        ///
        /// 导入函数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ImportFunctionResponse> ImportFunctionAsync(ImportFunctionRequest importFunctionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/import",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", importFunctionRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ImportFunctionResponse>(response);
        }

        public AsyncInvoker<ImportFunctionResponse> ImportFunctionAsyncInvoker(ImportFunctionRequest importFunctionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/import",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", importFunctionRequest);
            return new AsyncInvoker<ImportFunctionResponse>(this, "POST", request, JsonUtils.DeSerialize<ImportFunctionResponse>);
        }
        
        /// <summary>
        /// 同步执行函数
        ///
        /// 同步调用指的是客户端请求需要明确等到响应结果，也就是说这样的请求必须得调用到用户的函数，并且等到调用完成才返回。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<InvokeFunctionResponse> InvokeFunctionAsync(InvokeFunctionRequest invokeFunctionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", invokeFunctionRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/invocations",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", invokeFunctionRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<InvokeFunctionResponse>(response);
        }

        public AsyncInvoker<InvokeFunctionResponse> InvokeFunctionAsyncInvoker(InvokeFunctionRequest invokeFunctionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", invokeFunctionRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/invocations",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", invokeFunctionRequest);
            return new AsyncInvoker<InvokeFunctionResponse>(this, "POST", request, JsonUtils.DeSerialize<InvokeFunctionResponse>);
        }
        
        /// <summary>
        /// 获取函数活跃异步调用请求列表
        ///
        /// 获取函数异步调用活跃请求列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListActiveAsyncInvocationsResponse> ListActiveAsyncInvocationsAsync(ListActiveAsyncInvocationsRequest listActiveAsyncInvocationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", listActiveAsyncInvocationsRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/active-async-invocations",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listActiveAsyncInvocationsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListActiveAsyncInvocationsResponse>(response);
        }

        public AsyncInvoker<ListActiveAsyncInvocationsResponse> ListActiveAsyncInvocationsAsyncInvoker(ListActiveAsyncInvocationsRequest listActiveAsyncInvocationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", listActiveAsyncInvocationsRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/active-async-invocations",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listActiveAsyncInvocationsRequest);
            return new AsyncInvoker<ListActiveAsyncInvocationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListActiveAsyncInvocationsResponse>);
        }
        
        /// <summary>
        /// 查询应用程序模板列表
        ///
        /// 查询应用程序模板列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAppTemplatesResponse> ListAppTemplatesAsync(ListAppTemplatesRequest listAppTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/application/templates",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppTemplatesRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAppTemplatesResponse>(response);
        }

        public AsyncInvoker<ListAppTemplatesResponse> ListAppTemplatesAsyncInvoker(ListAppTemplatesRequest listAppTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/application/templates",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppTemplatesRequest);
            return new AsyncInvoker<ListAppTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAppTemplatesResponse>);
        }
        
        /// <summary>
        /// 获取函数异步调用请求列表
        ///
        /// 获取函数异步调用请求列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAsyncInvocationsResponse> ListAsyncInvocationsAsync(ListAsyncInvocationsRequest listAsyncInvocationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", listAsyncInvocationsRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/async-invocations",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAsyncInvocationsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAsyncInvocationsResponse>(response);
        }

        public AsyncInvoker<ListAsyncInvocationsResponse> ListAsyncInvocationsAsyncInvoker(ListAsyncInvocationsRequest listAsyncInvocationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", listAsyncInvocationsRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/async-invocations",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAsyncInvocationsRequest);
            return new AsyncInvoker<ListAsyncInvocationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAsyncInvocationsResponse>);
        }
        
        /// <summary>
        /// 获取指定函数绑定的servicebridge函数列表
        ///
        /// 获取指定函数绑定的servicebridge函数列表信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBridgeFunctionsResponse> ListBridgeFunctionsAsync(ListBridgeFunctionsRequest listBridgeFunctionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", listBridgeFunctionsRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/servicebridge/relation",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBridgeFunctionsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            var listBridgeFunctionsResponse = JsonUtils.DeSerializeNull<ListBridgeFunctionsResponse>(response);
            listBridgeFunctionsResponse.Body = JsonUtils.DeSerializeList<ListFunctionResult>(response);
            return listBridgeFunctionsResponse;
        }

        public AsyncInvoker<ListBridgeFunctionsResponse> ListBridgeFunctionsAsyncInvoker(ListBridgeFunctionsRequest listBridgeFunctionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", listBridgeFunctionsRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/servicebridge/relation",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBridgeFunctionsRequest);
            return new AsyncInvoker<ListBridgeFunctionsResponse>(this, "GET", request, response =>
            {
                var listBridgeFunctionsResponse = JsonUtils.DeSerializeNull<ListBridgeFunctionsResponse>(response);
                listBridgeFunctionsResponse.Body = JsonUtils.DeSerializeList<ListFunctionResult>(response);
                return listBridgeFunctionsResponse;
            });
        }
        
        /// <summary>
        /// 获取servicebridge可用的版本
        ///
        /// 获取servicebridge可用的版本
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBridgeVersionsResponse> ListBridgeVersionsAsync(ListBridgeVersionsRequest listBridgeVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/servicebridge/version",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBridgeVersionsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            var listBridgeVersionsResponse = JsonUtils.DeSerializeNull<ListBridgeVersionsResponse>(response);
            listBridgeVersionsResponse.Body = JsonUtils.DeSerializeList<ServiceBridgeVersion>(response);
            return listBridgeVersionsResponse;
        }

        public AsyncInvoker<ListBridgeVersionsResponse> ListBridgeVersionsAsyncInvoker(ListBridgeVersionsRequest listBridgeVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/servicebridge/version",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBridgeVersionsRequest);
            return new AsyncInvoker<ListBridgeVersionsResponse>(this, "GET", request, response =>
            {
                var listBridgeVersionsResponse = JsonUtils.DeSerializeNull<ListBridgeVersionsResponse>(response);
                listBridgeVersionsResponse.Body = JsonUtils.DeSerializeList<ServiceBridgeVersion>(response);
                return listBridgeVersionsResponse;
            });
        }
        
        /// <summary>
        /// 获取依赖包列表
        ///
        /// 获取依赖包列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDependenciesResponse> ListDependenciesAsync(ListDependenciesRequest listDependenciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDependenciesRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDependenciesResponse>(response);
        }

        public AsyncInvoker<ListDependenciesResponse> ListDependenciesAsyncInvoker(ListDependenciesRequest listDependenciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDependenciesRequest);
            return new AsyncInvoker<ListDependenciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDependenciesResponse>);
        }
        
        /// <summary>
        /// 获取依赖包版本列表
        ///
        /// 获取依赖包版本列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDependencyVersionResponse> ListDependencyVersionAsync(ListDependencyVersionRequest listDependencyVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("depend_id", listDependencyVersionRequest.DependId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies/{depend_id}/version",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDependencyVersionRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDependencyVersionResponse>(response);
        }

        public AsyncInvoker<ListDependencyVersionResponse> ListDependencyVersionAsyncInvoker(ListDependencyVersionRequest listDependencyVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("depend_id", listDependencyVersionRequest.DependId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies/{depend_id}/version",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDependencyVersionRequest);
            return new AsyncInvoker<ListDependencyVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDependencyVersionResponse>);
        }
        
        /// <summary>
        /// 获取指定函数的测试事件列表
        ///
        /// 获取指定函数的测试事件列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListEventsResponse> ListEventsAsync(ListEventsRequest listEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", listEventsRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/events",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEventsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListEventsResponse>(response);
        }

        public AsyncInvoker<ListEventsResponse> ListEventsAsyncInvoker(ListEventsRequest listEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", listEventsRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/events",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEventsRequest);
            return new AsyncInvoker<ListEventsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEventsResponse>);
        }
        
        /// <summary>
        /// 查询应用程序列表
        ///
        /// 查询应用程序列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFunctionApplicationsResponse> ListFunctionApplicationsAsync(ListFunctionApplicationsRequest listFunctionApplicationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/applications",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionApplicationsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListFunctionApplicationsResponse>(response);
        }

        public AsyncInvoker<ListFunctionApplicationsResponse> ListFunctionApplicationsAsyncInvoker(ListFunctionApplicationsRequest listFunctionApplicationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/applications",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionApplicationsRequest);
            return new AsyncInvoker<ListFunctionApplicationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFunctionApplicationsResponse>);
        }
        
        /// <summary>
        /// 获取按指定指标排序的函数列表
        ///
        /// 按指定指标排序的函数列表。
        /// 
        /// 默认统计按错误次数指标统计最近一天失败次数最多的前10个函数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFunctionAsMetricResponse> ListFunctionAsMetricAsync(ListFunctionAsMetricRequest listFunctionAsMetricRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/function/report",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionAsMetricRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListFunctionAsMetricResponse>(response);
        }

        public AsyncInvoker<ListFunctionAsMetricResponse> ListFunctionAsMetricAsyncInvoker(ListFunctionAsMetricRequest listFunctionAsMetricRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/function/report",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionAsMetricRequest);
            return new AsyncInvoker<ListFunctionAsMetricResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFunctionAsMetricResponse>);
        }
        
        /// <summary>
        /// 获取函数异步配置列表
        ///
        /// 获取指定函数所有版本的异步配置列表。。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFunctionAsyncInvokeConfigResponse> ListFunctionAsyncInvokeConfigAsync(ListFunctionAsyncInvokeConfigRequest listFunctionAsyncInvokeConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", listFunctionAsyncInvokeConfigRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/async-invoke-configs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionAsyncInvokeConfigRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListFunctionAsyncInvokeConfigResponse>(response);
        }

        public AsyncInvoker<ListFunctionAsyncInvokeConfigResponse> ListFunctionAsyncInvokeConfigAsyncInvoker(ListFunctionAsyncInvokeConfigRequest listFunctionAsyncInvokeConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", listFunctionAsyncInvokeConfigRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/async-invoke-configs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionAsyncInvokeConfigRequest);
            return new AsyncInvoker<ListFunctionAsyncInvokeConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFunctionAsyncInvokeConfigResponse>);
        }
        
        /// <summary>
        /// 获取函数预留实例数量
        ///
        /// 获取函数预留实例数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFunctionReservedInstancesResponse> ListFunctionReservedInstancesAsync(ListFunctionReservedInstancesRequest listFunctionReservedInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/reservedinstances",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionReservedInstancesRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListFunctionReservedInstancesResponse>(response);
        }

        public AsyncInvoker<ListFunctionReservedInstancesResponse> ListFunctionReservedInstancesAsyncInvoker(ListFunctionReservedInstancesRequest listFunctionReservedInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/reservedinstances",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionReservedInstancesRequest);
            return new AsyncInvoker<ListFunctionReservedInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFunctionReservedInstancesResponse>);
        }
        
        /// <summary>
        /// 获取指定时间段的函数运行指标
        ///
        /// 获取指定时间段的函数运行指标。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFunctionStatisticsResponse> ListFunctionStatisticsAsync(ListFunctionStatisticsRequest listFunctionStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("func_urn", listFunctionStatisticsRequest.FuncUrn.ToString());
            urlParam.Add("period", listFunctionStatisticsRequest.Period.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{func_urn}/statistics/{period}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionStatisticsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListFunctionStatisticsResponse>(response);
        }

        public AsyncInvoker<ListFunctionStatisticsResponse> ListFunctionStatisticsAsyncInvoker(ListFunctionStatisticsRequest listFunctionStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("func_urn", listFunctionStatisticsRequest.FuncUrn.ToString());
            urlParam.Add("period", listFunctionStatisticsRequest.Period.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{func_urn}/statistics/{period}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionStatisticsRequest);
            return new AsyncInvoker<ListFunctionStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFunctionStatisticsResponse>);
        }
        
        /// <summary>
        /// 查询函数标签列表
        ///
        /// 查询函数标签列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFunctionTagsResponse> ListFunctionTagsAsync(ListFunctionTagsRequest listFunctionTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listFunctionTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id", listFunctionTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionTagsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListFunctionTagsResponse>(response);
        }

        public AsyncInvoker<ListFunctionTagsResponse> ListFunctionTagsAsyncInvoker(ListFunctionTagsRequest listFunctionTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", listFunctionTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id", listFunctionTagsRequest.ResourceId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionTagsRequest);
            return new AsyncInvoker<ListFunctionTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFunctionTagsResponse>);
        }
        
        /// <summary>
        /// 获取函数模板列表
        ///
        /// 获取函数模板列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFunctionTemplateResponse> ListFunctionTemplateAsync(ListFunctionTemplateRequest listFunctionTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/templates",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionTemplateRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListFunctionTemplateResponse>(response);
        }

        public AsyncInvoker<ListFunctionTemplateResponse> ListFunctionTemplateAsyncInvoker(ListFunctionTemplateRequest listFunctionTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/templates",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionTemplateRequest);
            return new AsyncInvoker<ListFunctionTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFunctionTemplateResponse>);
        }
        
        /// <summary>
        /// 获取指定函数的所有触发器
        ///
        /// 获取指定函数的所有触发器设置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFunctionTriggersResponse> ListFunctionTriggersAsync(ListFunctionTriggersRequest listFunctionTriggersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", listFunctionTriggersRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionTriggersRequest);
            var response = await DoHttpRequestAsync("GET",request);
            var listFunctionTriggersResponse = JsonUtils.DeSerializeNull<ListFunctionTriggersResponse>(response);
            listFunctionTriggersResponse.Body = JsonUtils.DeSerializeList<ListFunctionTriggerResult>(response);
            return listFunctionTriggersResponse;
        }

        public AsyncInvoker<ListFunctionTriggersResponse> ListFunctionTriggersAsyncInvoker(ListFunctionTriggersRequest listFunctionTriggersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", listFunctionTriggersRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionTriggersRequest);
            return new AsyncInvoker<ListFunctionTriggersResponse>(this, "GET", request, response =>
            {
                var listFunctionTriggersResponse = JsonUtils.DeSerializeNull<ListFunctionTriggersResponse>(response);
                listFunctionTriggersResponse.Body = JsonUtils.DeSerializeList<ListFunctionTriggerResult>(response);
                return listFunctionTriggersResponse;
            });
        }
        
        /// <summary>
        /// 获取指定函数的版本列表
        ///
        /// 获取指定函数的版本列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFunctionVersionsResponse> ListFunctionVersionsAsync(ListFunctionVersionsRequest listFunctionVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", listFunctionVersionsRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/versions",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionVersionsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListFunctionVersionsResponse>(response);
        }

        public AsyncInvoker<ListFunctionVersionsResponse> ListFunctionVersionsAsyncInvoker(ListFunctionVersionsRequest listFunctionVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", listFunctionVersionsRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/versions",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionVersionsRequest);
            return new AsyncInvoker<ListFunctionVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFunctionVersionsResponse>);
        }
        
        /// <summary>
        /// 获取函数列表
        ///
        /// 获取函数列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFunctionsResponse> ListFunctionsAsync(ListFunctionsRequest listFunctionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListFunctionsResponse>(response);
        }

        public AsyncInvoker<ListFunctionsResponse> ListFunctionsAsyncInvoker(ListFunctionsRequest listFunctionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionsRequest);
            return new AsyncInvoker<ListFunctionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFunctionsResponse>);
        }
        
        /// <summary>
        /// 查询租户配额
        ///
        /// 查询租户配额
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListQuotasResponse> ListQuotasAsync(ListQuotasRequest listQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/quotas",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotasRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListQuotasResponse>(response);
        }

        public AsyncInvoker<ListQuotasResponse> ListQuotasAsyncInvoker(ListQuotasRequest listQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/quotas",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotasRequest);
            return new AsyncInvoker<ListQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListQuotasResponse>);
        }
        
        /// <summary>
        /// 获取函数预留实例配置列表
        ///
        /// 获取函数预留实例配置列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListReservedInstanceConfigsResponse> ListReservedInstanceConfigsAsync(ListReservedInstanceConfigsRequest listReservedInstanceConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/reservedinstanceconfigs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReservedInstanceConfigsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListReservedInstanceConfigsResponse>(response);
        }

        public AsyncInvoker<ListReservedInstanceConfigsResponse> ListReservedInstanceConfigsAsyncInvoker(ListReservedInstanceConfigsRequest listReservedInstanceConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/reservedinstanceconfigs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReservedInstanceConfigsRequest);
            return new AsyncInvoker<ListReservedInstanceConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListReservedInstanceConfigsResponse>);
        }
        
        /// <summary>
        /// 租户函数统计信息
        ///
        /// 租户函数统计信息。
        /// 
        /// 返回三类的统计信息，函数格式和大小使用情况包括配额和使用量，流量报告。
        /// 通过查询参数filter可以进行过滤，查询参数period可以指定返回的时间段。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListStatisticsResponse> ListStatisticsAsync(ListStatisticsRequest listStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/statistics",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStatisticsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListStatisticsResponse>(response);
        }

        public AsyncInvoker<ListStatisticsResponse> ListStatisticsAsyncInvoker(ListStatisticsRequest listStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/statistics",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStatisticsRequest);
            return new AsyncInvoker<ListStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStatisticsResponse>);
        }
        
        /// <summary>
        /// 获取指定函数所有版本别名列表
        ///
        /// 获取函数版本别名列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListVersionAliasesResponse> ListVersionAliasesAsync(ListVersionAliasesRequest listVersionAliasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", listVersionAliasesRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/aliases",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionAliasesRequest);
            var response = await DoHttpRequestAsync("GET",request);
            var listVersionAliasesResponse = JsonUtils.DeSerializeNull<ListVersionAliasesResponse>(response);
            listVersionAliasesResponse.Body = JsonUtils.DeSerializeList<ListVersionAliasResult>(response);
            return listVersionAliasesResponse;
        }

        public AsyncInvoker<ListVersionAliasesResponse> ListVersionAliasesAsyncInvoker(ListVersionAliasesRequest listVersionAliasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", listVersionAliasesRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/aliases",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionAliasesRequest);
            return new AsyncInvoker<ListVersionAliasesResponse>(this, "GET", request, response =>
            {
                var listVersionAliasesResponse = JsonUtils.DeSerializeNull<ListVersionAliasesResponse>(response);
                listVersionAliasesResponse.Body = JsonUtils.DeSerializeList<ListVersionAliasResult>(response);
                return listVersionAliasesResponse;
            });
        }
        
        /// <summary>
        /// 查询函数流
        ///
        /// 查询函数流
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListWorkflowResponse> ListWorkflowAsync(ListWorkflowRequest listWorkflowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWorkflowRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListWorkflowResponse>(response);
        }

        public AsyncInvoker<ListWorkflowResponse> ListWorkflowAsyncInvoker(ListWorkflowRequest listWorkflowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWorkflowRequest);
            return new AsyncInvoker<ListWorkflowResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWorkflowResponse>);
        }
        
        /// <summary>
        /// 获取指定函数流执行实例列表
        ///
        /// 获取指定函数流执行实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListWorkflowExecutionsResponse> ListWorkflowExecutionsAsync(ListWorkflowExecutionsRequest listWorkflowExecutionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id", listWorkflowExecutionsRequest.WorkflowId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/executions",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWorkflowExecutionsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListWorkflowExecutionsResponse>(response);
        }

        public AsyncInvoker<ListWorkflowExecutionsResponse> ListWorkflowExecutionsAsyncInvoker(ListWorkflowExecutionsRequest listWorkflowExecutionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id", listWorkflowExecutionsRequest.WorkflowId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/executions",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWorkflowExecutionsRequest);
            return new AsyncInvoker<ListWorkflowExecutionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWorkflowExecutionsResponse>);
        }
        
        /// <summary>
        /// 重试函数流
        ///
        /// 重试函数流
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RetryWorkFlowResponse> RetryWorkFlowAsync(RetryWorkFlowRequest retryWorkFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id", retryWorkFlowRequest.WorkflowId.ToString());
            urlParam.Add("execution_id", retryWorkFlowRequest.ExecutionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/executions/{execution_id}/retry",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryWorkFlowRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<RetryWorkFlowResponse>(response);
        }

        public AsyncInvoker<RetryWorkFlowResponse> RetryWorkFlowAsyncInvoker(RetryWorkFlowRequest retryWorkFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id", retryWorkFlowRequest.WorkflowId.ToString());
            urlParam.Add("execution_id", retryWorkFlowRequest.ExecutionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/executions/{execution_id}/retry",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryWorkFlowRequest);
            return new AsyncInvoker<RetryWorkFlowResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RetryWorkFlowResponse>);
        }
        
        /// <summary>
        /// 查询应用程序模板详情
        ///
        /// 查询应用程序模板详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAppTemplateResponse> ShowAppTemplateAsync(ShowAppTemplateRequest showAppTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showAppTemplateRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/application/templates/{id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppTemplateRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAppTemplateResponse>(response);
        }

        public AsyncInvoker<ShowAppTemplateResponse> ShowAppTemplateAsyncInvoker(ShowAppTemplateRequest showAppTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showAppTemplateRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/application/templates/{id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppTemplateRequest);
            return new AsyncInvoker<ShowAppTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAppTemplateResponse>);
        }
        
        /// <summary>
        /// 获取指定依赖包
        ///
        /// 获取指定依赖包
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDependcyResponse> ShowDependcyAsync(ShowDependcyRequest showDependcyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("depend_id", showDependcyRequest.DependId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies/{depend_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDependcyRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDependcyResponse>(response);
        }

        public AsyncInvoker<ShowDependcyResponse> ShowDependcyAsyncInvoker(ShowDependcyRequest showDependcyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("depend_id", showDependcyRequest.DependId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies/{depend_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDependcyRequest);
            return new AsyncInvoker<ShowDependcyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDependcyResponse>);
        }
        
        /// <summary>
        /// 获取依赖包版本详情
        ///
        /// 获取依赖包版本详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDependencyVersionResponse> ShowDependencyVersionAsync(ShowDependencyVersionRequest showDependencyVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("depend_id", showDependencyVersionRequest.DependId.ToString());
            urlParam.Add("version", showDependencyVersionRequest.Version.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies/{depend_id}/version/{version}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDependencyVersionRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDependencyVersionResponse>(response);
        }

        public AsyncInvoker<ShowDependencyVersionResponse> ShowDependencyVersionAsyncInvoker(ShowDependencyVersionRequest showDependencyVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("depend_id", showDependencyVersionRequest.DependId.ToString());
            urlParam.Add("version", showDependencyVersionRequest.Version.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies/{depend_id}/version/{version}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDependencyVersionRequest);
            return new AsyncInvoker<ShowDependencyVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDependencyVersionResponse>);
        }
        
        /// <summary>
        /// 获取测试事件详细信息
        ///
        /// 获取测试事件详细信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowEventResponse> ShowEventAsync(ShowEventRequest showEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", showEventRequest.FunctionUrn.ToString());
            urlParam.Add("event_id", showEventRequest.EventId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/events/{event_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEventRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowEventResponse>(response);
        }

        public AsyncInvoker<ShowEventResponse> ShowEventAsyncInvoker(ShowEventRequest showEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", showEventRequest.FunctionUrn.ToString());
            urlParam.Add("event_id", showEventRequest.EventId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/events/{event_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEventRequest);
            return new AsyncInvoker<ShowEventResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEventResponse>);
        }
        
        /// <summary>
        /// 查询函数实例使用情况指标
        ///
        /// 查询函数实例使用情况指标。
        /// 
        /// - 指标单位为分钟：
        ///     当查询时间范围小于1小时,指标周期为1分钟
        ///     当查询时间范围小于1天,指标周期为30分钟
        ///     当查询时间范围大于1天,指标周期为180分钟
        /// - 指标分为如下几类：reservedinstancenum（预留实例使用）、concurrency（实例使用/并发）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowFuncReservedInstanceMetricsResponse> ShowFuncReservedInstanceMetricsAsync(ShowFuncReservedInstanceMetricsRequest showFuncReservedInstanceMetricsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("func_urn", showFuncReservedInstanceMetricsRequest.FuncUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{func_urn}/instancereports",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFuncReservedInstanceMetricsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowFuncReservedInstanceMetricsResponse>(response);
        }

        public AsyncInvoker<ShowFuncReservedInstanceMetricsResponse> ShowFuncReservedInstanceMetricsAsyncInvoker(ShowFuncReservedInstanceMetricsRequest showFuncReservedInstanceMetricsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("func_urn", showFuncReservedInstanceMetricsRequest.FuncUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{func_urn}/instancereports",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFuncReservedInstanceMetricsRequest);
            return new AsyncInvoker<ShowFuncReservedInstanceMetricsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFuncReservedInstanceMetricsResponse>);
        }
        
        /// <summary>
        /// 查询函数快照制作状态
        ///
        /// 查询函数快照制作状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowFuncSnapshotStateResponse> ShowFuncSnapshotStateAsync(ShowFuncSnapshotStateRequest showFuncSnapshotStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", showFuncSnapshotStateRequest.FunctionUrn.ToString());
            urlParam.Add("action", showFuncSnapshotStateRequest.Action.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/snapshots/{action}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFuncSnapshotStateRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowFuncSnapshotStateResponse>(response);
        }

        public AsyncInvoker<ShowFuncSnapshotStateResponse> ShowFuncSnapshotStateAsyncInvoker(ShowFuncSnapshotStateRequest showFuncSnapshotStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", showFuncSnapshotStateRequest.FunctionUrn.ToString());
            urlParam.Add("action", showFuncSnapshotStateRequest.Action.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/snapshots/{action}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFuncSnapshotStateRequest);
            return new AsyncInvoker<ShowFuncSnapshotStateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFuncSnapshotStateResponse>);
        }
        
        /// <summary>
        /// 查询应用程序详情
        ///
        /// 查询应用程序详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowFunctionAppResponse> ShowFunctionAppAsync(ShowFunctionAppRequest showFunctionAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showFunctionAppRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/applications/{id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFunctionAppRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowFunctionAppResponse>(response);
        }

        public AsyncInvoker<ShowFunctionAppResponse> ShowFunctionAppAsyncInvoker(ShowFunctionAppRequest showFunctionAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showFunctionAppRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/applications/{id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFunctionAppRequest);
            return new AsyncInvoker<ShowFunctionAppResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFunctionAppResponse>);
        }
        
        /// <summary>
        /// 获取函数异步配置信息
        ///
        /// 获取指定函数某一版本的异步配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowFunctionAsyncInvokeConfigResponse> ShowFunctionAsyncInvokeConfigAsync(ShowFunctionAsyncInvokeConfigRequest showFunctionAsyncInvokeConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", showFunctionAsyncInvokeConfigRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/async-invoke-config",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFunctionAsyncInvokeConfigRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowFunctionAsyncInvokeConfigResponse>(response);
        }

        public AsyncInvoker<ShowFunctionAsyncInvokeConfigResponse> ShowFunctionAsyncInvokeConfigAsyncInvoker(ShowFunctionAsyncInvokeConfigRequest showFunctionAsyncInvokeConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", showFunctionAsyncInvokeConfigRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/async-invoke-config",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFunctionAsyncInvokeConfigRequest);
            return new AsyncInvoker<ShowFunctionAsyncInvokeConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFunctionAsyncInvokeConfigResponse>);
        }
        
        /// <summary>
        /// 获取指定函数代码
        ///
        /// 获取指定函数的代码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowFunctionCodeResponse> ShowFunctionCodeAsync(ShowFunctionCodeRequest showFunctionCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", showFunctionCodeRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/code",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFunctionCodeRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowFunctionCodeResponse>(response);
        }

        public AsyncInvoker<ShowFunctionCodeResponse> ShowFunctionCodeAsyncInvoker(ShowFunctionCodeRequest showFunctionCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", showFunctionCodeRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/code",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFunctionCodeRequest);
            return new AsyncInvoker<ShowFunctionCodeResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFunctionCodeResponse>);
        }
        
        /// <summary>
        /// 获取函数的metadata
        ///
        /// 获取指定函数的metadata。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowFunctionConfigResponse> ShowFunctionConfigAsync(ShowFunctionConfigRequest showFunctionConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", showFunctionConfigRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/config",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFunctionConfigRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowFunctionConfigResponse>(response);
        }

        public AsyncInvoker<ShowFunctionConfigResponse> ShowFunctionConfigAsyncInvoker(ShowFunctionConfigRequest showFunctionConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", showFunctionConfigRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/config",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFunctionConfigRequest);
            return new AsyncInvoker<ShowFunctionConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFunctionConfigResponse>);
        }
        
        /// <summary>
        /// 查询函数实例流量指标
        ///
        /// 查询函数流量指标。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowFunctionMetricsResponse> ShowFunctionMetricsAsync(ShowFunctionMetricsRequest showFunctionMetricsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("func_urn", showFunctionMetricsRequest.FuncUrn.ToString());
            urlParam.Add("period", showFunctionMetricsRequest.Period.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{func_urn}/slareports/{period}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFunctionMetricsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowFunctionMetricsResponse>(response);
        }

        public AsyncInvoker<ShowFunctionMetricsResponse> ShowFunctionMetricsAsyncInvoker(ShowFunctionMetricsRequest showFunctionMetricsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("func_urn", showFunctionMetricsRequest.FuncUrn.ToString());
            urlParam.Add("period", showFunctionMetricsRequest.Period.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{func_urn}/slareports/{period}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFunctionMetricsRequest);
            return new AsyncInvoker<ShowFunctionMetricsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFunctionMetricsResponse>);
        }
        
        /// <summary>
        /// 获取指定函数模板
        ///
        /// 获取指定函数模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowFunctionTemplateResponse> ShowFunctionTemplateAsync(ShowFunctionTemplateRequest showFunctionTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("template_id", showFunctionTemplateRequest.TemplateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/templates/{template_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFunctionTemplateRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowFunctionTemplateResponse>(response);
        }

        public AsyncInvoker<ShowFunctionTemplateResponse> ShowFunctionTemplateAsyncInvoker(ShowFunctionTemplateRequest showFunctionTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("template_id", showFunctionTemplateRequest.TemplateId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/templates/{template_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFunctionTemplateRequest);
            return new AsyncInvoker<ShowFunctionTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFunctionTemplateResponse>);
        }
        
        /// <summary>
        /// 获取指定触发器的信息
        ///
        /// 获取特定触发器的信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowFunctionTriggerResponse> ShowFunctionTriggerAsync(ShowFunctionTriggerRequest showFunctionTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", showFunctionTriggerRequest.FunctionUrn.ToString());
            urlParam.Add("trigger_type_code", showFunctionTriggerRequest.TriggerTypeCode.ToString());
            urlParam.Add("trigger_id", showFunctionTriggerRequest.TriggerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}/{trigger_type_code}/{trigger_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFunctionTriggerRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowFunctionTriggerResponse>(response);
        }

        public AsyncInvoker<ShowFunctionTriggerResponse> ShowFunctionTriggerAsyncInvoker(ShowFunctionTriggerRequest showFunctionTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", showFunctionTriggerRequest.FunctionUrn.ToString());
            urlParam.Add("trigger_type_code", showFunctionTriggerRequest.TriggerTypeCode.ToString());
            urlParam.Add("trigger_id", showFunctionTriggerRequest.TriggerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}/{trigger_type_code}/{trigger_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFunctionTriggerRequest);
            return new AsyncInvoker<ShowFunctionTriggerResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFunctionTriggerResponse>);
        }
        
        /// <summary>
        /// 获取指定函数的lts日志组日志流配置
        ///
        /// 获取指定函数的lts日志组日志流配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowLtsLogDetailsResponse> ShowLtsLogDetailsAsync(ShowLtsLogDetailsRequest showLtsLogDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", showLtsLogDetailsRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/lts-log-detail",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLtsLogDetailsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowLtsLogDetailsResponse>(response);
        }

        public AsyncInvoker<ShowLtsLogDetailsResponse> ShowLtsLogDetailsAsyncInvoker(ShowLtsLogDetailsRequest showLtsLogDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", showLtsLogDetailsRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/lts-log-detail",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLtsLogDetailsRequest);
            return new AsyncInvoker<ShowLtsLogDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLtsLogDetailsResponse>);
        }
        
        /// <summary>
        /// 查询异步日志详情
        ///
        /// 查询异步日志详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowProjectAsyncStatusLogInfoResponse> ShowProjectAsyncStatusLogInfoAsync(ShowProjectAsyncStatusLogInfoRequest showProjectAsyncStatusLogInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/async-status-log-detail",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectAsyncStatusLogInfoRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowProjectAsyncStatusLogInfoResponse>(response);
        }

        public AsyncInvoker<ShowProjectAsyncStatusLogInfoResponse> ShowProjectAsyncStatusLogInfoAsyncInvoker(ShowProjectAsyncStatusLogInfoRequest showProjectAsyncStatusLogInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/async-status-log-detail",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectAsyncStatusLogInfoRequest);
            return new AsyncInvoker<ShowProjectAsyncStatusLogInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectAsyncStatusLogInfoResponse>);
        }
        
        /// <summary>
        /// 查询资源标签
        ///
        /// 查询资源标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowProjectTagsListResponse> ShowProjectTagsListAsync(ShowProjectTagsListRequest showProjectTagsListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", showProjectTagsListRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectTagsListRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowProjectTagsListResponse>(response);
        }

        public AsyncInvoker<ShowProjectTagsListResponse> ShowProjectTagsListAsyncInvoker(ShowProjectTagsListRequest showProjectTagsListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", showProjectTagsListRequest.ResourceType.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/tags",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectTagsListRequest);
            return new AsyncInvoker<ShowProjectTagsListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectTagsListResponse>);
        }
        
        /// <summary>
        /// 查询资源实例
        ///
        /// 查询资源实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowResInstanceInfoResponse> ShowResInstanceInfoAsync(ShowResInstanceInfoRequest showResInstanceInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", showResInstanceInfoRequest.ResourceType.ToString());
            urlParam.Add("action", showResInstanceInfoRequest.Action.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/resource-instances/{action}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResInstanceInfoRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ShowResInstanceInfoResponse>(response);
        }

        public AsyncInvoker<ShowResInstanceInfoResponse> ShowResInstanceInfoAsyncInvoker(ShowResInstanceInfoRequest showResInstanceInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type", showResInstanceInfoRequest.ResourceType.ToString());
            urlParam.Add("action", showResInstanceInfoRequest.Action.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/resource-instances/{action}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResInstanceInfoRequest);
            return new AsyncInvoker<ShowResInstanceInfoResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowResInstanceInfoResponse>);
        }
        
        /// <summary>
        /// 获取函数流指标
        ///
        /// 获取函数流指标
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTenantMetricResponse> ShowTenantMetricAsync(ShowTenantMetricRequest showTenantMetricRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflow-statistic",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTenantMetricRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowTenantMetricResponse>(response);
        }

        public AsyncInvoker<ShowTenantMetricResponse> ShowTenantMetricAsyncInvoker(ShowTenantMetricRequest showTenantMetricRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflow-statistic",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTenantMetricRequest);
            return new AsyncInvoker<ShowTenantMetricResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTenantMetricResponse>);
        }
        
        /// <summary>
        /// 获取函数调用链配置
        ///
        /// 获取函数调用链配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTracingResponse> ShowTracingAsync(ShowTracingRequest showTracingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", showTracingRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/tracing",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTracingRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowTracingResponse>(response);
        }

        public AsyncInvoker<ShowTracingResponse> ShowTracingAsyncInvoker(ShowTracingRequest showTracingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", showTracingRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/tracing",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTracingRequest);
            return new AsyncInvoker<ShowTracingResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTracingResponse>);
        }
        
        /// <summary>
        /// 获取函数版本的指定别名信息
        ///
        /// 获取函数指定的版本别名信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowVersionAliasResponse> ShowVersionAliasAsync(ShowVersionAliasRequest showVersionAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", showVersionAliasRequest.FunctionUrn.ToString());
            urlParam.Add("alias_name", showVersionAliasRequest.AliasName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/aliases/{alias_name}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionAliasRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowVersionAliasResponse>(response);
        }

        public AsyncInvoker<ShowVersionAliasResponse> ShowVersionAliasAsyncInvoker(ShowVersionAliasRequest showVersionAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", showVersionAliasRequest.FunctionUrn.ToString());
            urlParam.Add("alias_name", showVersionAliasRequest.AliasName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/aliases/{alias_name}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionAliasRequest);
            return new AsyncInvoker<ShowVersionAliasResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVersionAliasResponse>);
        }
        
        /// <summary>
        /// 获取指定函数流实例的元数据
        ///
        /// 获取指定函数流实例的元数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowWorkFlowResponse> ShowWorkFlowAsync(ShowWorkFlowRequest showWorkFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id", showWorkFlowRequest.WorkflowId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkFlowRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowWorkFlowResponse>(response);
        }

        public AsyncInvoker<ShowWorkFlowResponse> ShowWorkFlowAsyncInvoker(ShowWorkFlowRequest showWorkFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id", showWorkFlowRequest.WorkflowId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkFlowRequest);
            return new AsyncInvoker<ShowWorkFlowResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWorkFlowResponse>);
        }
        
        /// <summary>
        /// 获取指定函数流指标
        ///
        /// 获取指定函数流指标
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowWorkFlowMetricResponse> ShowWorkFlowMetricAsync(ShowWorkFlowMetricRequest showWorkFlowMetricRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_urn", showWorkFlowMetricRequest.WorkflowUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflow-statistic/{workflow_urn}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkFlowMetricRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowWorkFlowMetricResponse>(response);
        }

        public AsyncInvoker<ShowWorkFlowMetricResponse> ShowWorkFlowMetricAsyncInvoker(ShowWorkFlowMetricRequest showWorkFlowMetricRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_urn", showWorkFlowMetricRequest.WorkflowUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflow-statistic/{workflow_urn}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkFlowMetricRequest);
            return new AsyncInvoker<ShowWorkFlowMetricResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWorkFlowMetricResponse>);
        }
        
        /// <summary>
        /// 获取指定函数流执行实例
        ///
        /// 获取指定函数流执行实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowWorkflowExecutionResponse> ShowWorkflowExecutionAsync(ShowWorkflowExecutionRequest showWorkflowExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id", showWorkflowExecutionRequest.WorkflowId.ToString());
            urlParam.Add("execution_id", showWorkflowExecutionRequest.ExecutionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/executions/{execution_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkflowExecutionRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowWorkflowExecutionResponse>(response);
        }

        public AsyncInvoker<ShowWorkflowExecutionResponse> ShowWorkflowExecutionAsyncInvoker(ShowWorkflowExecutionRequest showWorkflowExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id", showWorkflowExecutionRequest.WorkflowId.ToString());
            urlParam.Add("execution_id", showWorkflowExecutionRequest.ExecutionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/executions/{execution_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkflowExecutionRequest);
            return new AsyncInvoker<ShowWorkflowExecutionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWorkflowExecutionResponse>);
        }
        
        /// <summary>
        /// 分页获取指定函数流执行实例列表
        ///
        /// 分页获取指定函数流执行实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowWorkflowExecutionForPageResponse> ShowWorkflowExecutionForPageAsync(ShowWorkflowExecutionForPageRequest showWorkflowExecutionForPageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id", showWorkflowExecutionForPageRequest.WorkflowId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/executions-history",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkflowExecutionForPageRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowWorkflowExecutionForPageResponse>(response);
        }

        public AsyncInvoker<ShowWorkflowExecutionForPageResponse> ShowWorkflowExecutionForPageAsyncInvoker(ShowWorkflowExecutionForPageRequest showWorkflowExecutionForPageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id", showWorkflowExecutionForPageRequest.WorkflowId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/executions-history",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkflowExecutionForPageRequest);
            return new AsyncInvoker<ShowWorkflowExecutionForPageResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWorkflowExecutionForPageResponse>);
        }
        
        /// <summary>
        /// 同步执行函数流
        ///
        /// 以同步执行方式启动函数流（仅快速模式函数流支持）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StartSyncWorkflowExecutionResponse> StartSyncWorkflowExecutionAsync(StartSyncWorkflowExecutionRequest startSyncWorkflowExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id", startSyncWorkflowExecutionRequest.WorkflowId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/sync-executions",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startSyncWorkflowExecutionRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<StartSyncWorkflowExecutionResponse>(response);
        }

        public AsyncInvoker<StartSyncWorkflowExecutionResponse> StartSyncWorkflowExecutionAsyncInvoker(StartSyncWorkflowExecutionRequest startSyncWorkflowExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id", startSyncWorkflowExecutionRequest.WorkflowId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/sync-executions",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startSyncWorkflowExecutionRequest);
            return new AsyncInvoker<StartSyncWorkflowExecutionResponse>(this, "POST", request, JsonUtils.DeSerialize<StartSyncWorkflowExecutionResponse>);
        }
        
        /// <summary>
        /// 开始执行函数流
        ///
        /// 以异步执行方式启动函数流
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StartWorkflowExecutionResponse> StartWorkflowExecutionAsync(StartWorkflowExecutionRequest startWorkflowExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id", startWorkflowExecutionRequest.WorkflowId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/executions",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startWorkflowExecutionRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<StartWorkflowExecutionResponse>(response);
        }

        public AsyncInvoker<StartWorkflowExecutionResponse> StartWorkflowExecutionAsyncInvoker(StartWorkflowExecutionRequest startWorkflowExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id", startWorkflowExecutionRequest.WorkflowId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/executions",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startWorkflowExecutionRequest);
            return new AsyncInvoker<StartWorkflowExecutionResponse>(this, "POST", request, JsonUtils.DeSerialize<StartWorkflowExecutionResponse>);
        }
        
        /// <summary>
        /// 停止函数流
        ///
        /// 停止函数流
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StopWorkFlowResponse> StopWorkFlowAsync(StopWorkFlowRequest stopWorkFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id", stopWorkFlowRequest.WorkflowId.ToString());
            urlParam.Add("execution_id", stopWorkFlowRequest.ExecutionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/executions/{execution_id}/terminate",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopWorkFlowRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<StopWorkFlowResponse>(response);
        }

        public AsyncInvoker<StopWorkFlowResponse> StopWorkFlowAsyncInvoker(StopWorkFlowRequest stopWorkFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id", stopWorkFlowRequest.WorkflowId.ToString());
            urlParam.Add("execution_id", stopWorkFlowRequest.ExecutionId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/executions/{execution_id}/terminate",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopWorkFlowRequest);
            return new AsyncInvoker<StopWorkFlowResponse>(this, "POST", request, JsonUtils.DeSerializeNull<StopWorkFlowResponse>);
        }
        
        /// <summary>
        /// 更新指定依赖包
        ///
        /// 更新指定依赖包
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDependcyResponse> UpdateDependcyAsync(UpdateDependcyRequest updateDependcyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("depend_id", updateDependcyRequest.DependId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies/{depend_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDependcyRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDependcyResponse>(response);
        }

        public AsyncInvoker<UpdateDependcyResponse> UpdateDependcyAsyncInvoker(UpdateDependcyRequest updateDependcyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("depend_id", updateDependcyRequest.DependId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies/{depend_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDependcyRequest);
            return new AsyncInvoker<UpdateDependcyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDependcyResponse>);
        }
        
        /// <summary>
        /// 更新测试事件详细信息
        ///
        /// 更新测试事件详细信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateEventResponse> UpdateEventAsync(UpdateEventRequest updateEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", updateEventRequest.FunctionUrn.ToString());
            urlParam.Add("event_id", updateEventRequest.EventId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/events/{event_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEventRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateEventResponse>(response);
        }

        public AsyncInvoker<UpdateEventResponse> UpdateEventAsyncInvoker(UpdateEventRequest updateEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", updateEventRequest.FunctionUrn.ToString());
            urlParam.Add("event_id", updateEventRequest.EventId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/events/{event_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEventRequest);
            return new AsyncInvoker<UpdateEventResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateEventResponse>);
        }
        
        /// <summary>
        /// 禁用/启动函数快照
        ///
        /// 禁用/启动函数快照，仅支持java运行时函数，且为非latest版本才能开启函数快照功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateFuncSnapshotResponse> UpdateFuncSnapshotAsync(UpdateFuncSnapshotRequest updateFuncSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("action", updateFuncSnapshotRequest.Action.ToString());
            urlParam.Add("function_urn", updateFuncSnapshotRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/snapshots/{action}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFuncSnapshotRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<UpdateFuncSnapshotResponse>(response);
        }

        public AsyncInvoker<UpdateFuncSnapshotResponse> UpdateFuncSnapshotAsyncInvoker(UpdateFuncSnapshotRequest updateFuncSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("action", updateFuncSnapshotRequest.Action.ToString());
            urlParam.Add("function_urn", updateFuncSnapshotRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/snapshots/{action}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFuncSnapshotRequest);
            return new AsyncInvoker<UpdateFuncSnapshotResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateFuncSnapshotResponse>);
        }
        
        /// <summary>
        /// 设置函数异步配置信息
        ///
        /// 设置函数异步配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateFunctionAsyncInvokeConfigResponse> UpdateFunctionAsyncInvokeConfigAsync(UpdateFunctionAsyncInvokeConfigRequest updateFunctionAsyncInvokeConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", updateFunctionAsyncInvokeConfigRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/async-invoke-config",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFunctionAsyncInvokeConfigRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateFunctionAsyncInvokeConfigResponse>(response);
        }

        public AsyncInvoker<UpdateFunctionAsyncInvokeConfigResponse> UpdateFunctionAsyncInvokeConfigAsyncInvoker(UpdateFunctionAsyncInvokeConfigRequest updateFunctionAsyncInvokeConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", updateFunctionAsyncInvokeConfigRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/async-invoke-config",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFunctionAsyncInvokeConfigRequest);
            return new AsyncInvoker<UpdateFunctionAsyncInvokeConfigResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateFunctionAsyncInvokeConfigResponse>);
        }
        
        /// <summary>
        /// 修改函数代码
        ///
        /// 修改指定的函数的代码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateFunctionCodeResponse> UpdateFunctionCodeAsync(UpdateFunctionCodeRequest updateFunctionCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", updateFunctionCodeRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/code",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFunctionCodeRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateFunctionCodeResponse>(response);
        }

        public AsyncInvoker<UpdateFunctionCodeResponse> UpdateFunctionCodeAsyncInvoker(UpdateFunctionCodeRequest updateFunctionCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", updateFunctionCodeRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/code",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFunctionCodeRequest);
            return new AsyncInvoker<UpdateFunctionCodeResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateFunctionCodeResponse>);
        }
        
        /// <summary>
        /// 更新函数置顶状态
        ///
        /// 更新函数置顶状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateFunctionCollectStateResponse> UpdateFunctionCollectStateAsync(UpdateFunctionCollectStateRequest updateFunctionCollectStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("func_urn", updateFunctionCollectStateRequest.FuncUrn.ToString());
            urlParam.Add("state", updateFunctionCollectStateRequest.State.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{func_urn}/collect/{state}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFunctionCollectStateRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateFunctionCollectStateResponse>(response);
        }

        public AsyncInvoker<UpdateFunctionCollectStateResponse> UpdateFunctionCollectStateAsyncInvoker(UpdateFunctionCollectStateRequest updateFunctionCollectStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("func_urn", updateFunctionCollectStateRequest.FuncUrn.ToString());
            urlParam.Add("state", updateFunctionCollectStateRequest.State.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{func_urn}/collect/{state}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFunctionCollectStateRequest);
            return new AsyncInvoker<UpdateFunctionCollectStateResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateFunctionCollectStateResponse>);
        }
        
        /// <summary>
        /// 修改函数的metadata信息
        ///
        /// 修改指定的函数的metadata信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateFunctionConfigResponse> UpdateFunctionConfigAsync(UpdateFunctionConfigRequest updateFunctionConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", updateFunctionConfigRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/config",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFunctionConfigRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateFunctionConfigResponse>(response);
        }

        public AsyncInvoker<UpdateFunctionConfigResponse> UpdateFunctionConfigAsyncInvoker(UpdateFunctionConfigRequest updateFunctionConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", updateFunctionConfigRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/config",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFunctionConfigRequest);
            return new AsyncInvoker<UpdateFunctionConfigResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateFunctionConfigResponse>);
        }
        
        /// <summary>
        /// 更新函数最大实例数
        ///
        /// 更新函数最大实例数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateFunctionMaxInstanceConfigResponse> UpdateFunctionMaxInstanceConfigAsync(UpdateFunctionMaxInstanceConfigRequest updateFunctionMaxInstanceConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", updateFunctionMaxInstanceConfigRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/config-max-instance",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFunctionMaxInstanceConfigRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateFunctionMaxInstanceConfigResponse>(response);
        }

        public AsyncInvoker<UpdateFunctionMaxInstanceConfigResponse> UpdateFunctionMaxInstanceConfigAsyncInvoker(UpdateFunctionMaxInstanceConfigRequest updateFunctionMaxInstanceConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", updateFunctionMaxInstanceConfigRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/config-max-instance",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFunctionMaxInstanceConfigRequest);
            return new AsyncInvoker<UpdateFunctionMaxInstanceConfigResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateFunctionMaxInstanceConfigResponse>);
        }
        
        /// <summary>
        /// 修改函数预留实例数量
        ///
        /// 修改函数预留实例数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateFunctionReservedInstancesCountResponse> UpdateFunctionReservedInstancesCountAsync(UpdateFunctionReservedInstancesCountRequest updateFunctionReservedInstancesCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", updateFunctionReservedInstancesCountRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/reservedinstances",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFunctionReservedInstancesCountRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateFunctionReservedInstancesCountResponse>(response);
        }

        public AsyncInvoker<UpdateFunctionReservedInstancesCountResponse> UpdateFunctionReservedInstancesCountAsyncInvoker(UpdateFunctionReservedInstancesCountRequest updateFunctionReservedInstancesCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", updateFunctionReservedInstancesCountRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/reservedinstances",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFunctionReservedInstancesCountRequest);
            return new AsyncInvoker<UpdateFunctionReservedInstancesCountResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateFunctionReservedInstancesCountResponse>);
        }
        
        /// <summary>
        /// 修改函数调用链配置
        ///
        /// 修改函数调用链配置,开通/修改传入aksk，关闭aksk传空
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateTracingResponse> UpdateTracingAsync(UpdateTracingRequest updateTracingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", updateTracingRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/tracing",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTracingRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateTracingResponse>(response);
        }

        public AsyncInvoker<UpdateTracingResponse> UpdateTracingAsyncInvoker(UpdateTracingRequest updateTracingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", updateTracingRequest.FunctionUrn.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/tracing",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTracingRequest);
            return new AsyncInvoker<UpdateTracingResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateTracingResponse>);
        }
        
        /// <summary>
        /// 更新触发器
        ///
        /// 更新触发器
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateTriggerResponse> UpdateTriggerAsync(UpdateTriggerRequest updateTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", updateTriggerRequest.FunctionUrn.ToString());
            urlParam.Add("trigger_type_code", updateTriggerRequest.TriggerTypeCode.ToString());
            urlParam.Add("trigger_id", updateTriggerRequest.TriggerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}/{trigger_type_code}/{trigger_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTriggerRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateTriggerResponse>(response);
        }

        public AsyncInvoker<UpdateTriggerResponse> UpdateTriggerAsyncInvoker(UpdateTriggerRequest updateTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", updateTriggerRequest.FunctionUrn.ToString());
            urlParam.Add("trigger_type_code", updateTriggerRequest.TriggerTypeCode.ToString());
            urlParam.Add("trigger_id", updateTriggerRequest.TriggerId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}/{trigger_type_code}/{trigger_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTriggerRequest);
            return new AsyncInvoker<UpdateTriggerResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateTriggerResponse>);
        }
        
        /// <summary>
        /// 修改函数版本别名信息
        ///
        /// 修改函数版本别名信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateVersionAliasResponse> UpdateVersionAliasAsync(UpdateVersionAliasRequest updateVersionAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", updateVersionAliasRequest.FunctionUrn.ToString());
            urlParam.Add("alias_name", updateVersionAliasRequest.AliasName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/aliases/{alias_name}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateVersionAliasRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateVersionAliasResponse>(response);
        }

        public AsyncInvoker<UpdateVersionAliasResponse> UpdateVersionAliasAsyncInvoker(UpdateVersionAliasRequest updateVersionAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn", updateVersionAliasRequest.FunctionUrn.ToString());
            urlParam.Add("alias_name", updateVersionAliasRequest.AliasName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/aliases/{alias_name}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateVersionAliasRequest);
            return new AsyncInvoker<UpdateVersionAliasResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateVersionAliasResponse>);
        }
        
        /// <summary>
        /// 修改指定函数流实例的元数据
        ///
        /// 修改指定函数流实例的元数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateWorkFlowResponse> UpdateWorkFlowAsync(UpdateWorkFlowRequest updateWorkFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id", updateWorkFlowRequest.WorkflowId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWorkFlowRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateWorkFlowResponse>(response);
        }

        public AsyncInvoker<UpdateWorkFlowResponse> UpdateWorkFlowAsyncInvoker(UpdateWorkFlowRequest updateWorkFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id", updateWorkFlowRequest.WorkflowId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWorkFlowRequest);
            return new AsyncInvoker<UpdateWorkFlowResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateWorkFlowResponse>);
        }
        
    }
}