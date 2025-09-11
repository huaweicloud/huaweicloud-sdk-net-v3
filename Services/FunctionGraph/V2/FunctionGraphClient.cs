using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.FunctionGraph.V2.Model;

namespace HuaweiCloud.SDK.FunctionGraph.V2
{
    public partial class FunctionGraphClient : Client
    {
        public static ClientBuilder<FunctionGraphClient> NewBuilder()
        {
            return new ClientBuilder<FunctionGraphClient>();
        }

        
        /// <summary>
        /// 异步执行函数
        ///
        /// 异步执行函数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AsyncInvokeFunctionResponse AsyncInvokeFunction(AsyncInvokeFunctionRequest asyncInvokeFunctionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(asyncInvokeFunctionRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/invocations-async", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", asyncInvokeFunctionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AsyncInvokeFunctionResponse>(response);
        }

        public SyncInvoker<AsyncInvokeFunctionResponse> AsyncInvokeFunctionInvoker(AsyncInvokeFunctionRequest asyncInvokeFunctionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(asyncInvokeFunctionRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/invocations-async", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", asyncInvokeFunctionRequest);
            return new SyncInvoker<AsyncInvokeFunctionResponse>(this, "POST", request, JsonUtils.DeSerialize<AsyncInvokeFunctionResponse>);
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
        public BatchDeleteFunctionTriggersResponse BatchDeleteFunctionTriggers(BatchDeleteFunctionTriggersRequest batchDeleteFunctionTriggersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteFunctionTriggersRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteFunctionTriggersRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<BatchDeleteFunctionTriggersResponse>(response);
        }

        public SyncInvoker<BatchDeleteFunctionTriggersResponse> BatchDeleteFunctionTriggersInvoker(BatchDeleteFunctionTriggersRequest batchDeleteFunctionTriggersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchDeleteFunctionTriggersRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteFunctionTriggersRequest);
            return new SyncInvoker<BatchDeleteFunctionTriggersResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<BatchDeleteFunctionTriggersResponse>);
        }
        
        /// <summary>
        /// 删除函数流
        ///
        /// 删除函数流
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteWorkflowsResponse BatchDeleteWorkflows(BatchDeleteWorkflowsRequest batchDeleteWorkflowsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteWorkflowsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<BatchDeleteWorkflowsResponse>(response);
        }

        public SyncInvoker<BatchDeleteWorkflowsResponse> BatchDeleteWorkflowsInvoker(BatchDeleteWorkflowsRequest batchDeleteWorkflowsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteWorkflowsRequest);
            return new SyncInvoker<BatchDeleteWorkflowsResponse>(this, "DELETE", request, JsonUtils.DeSerialize<BatchDeleteWorkflowsResponse>);
        }
        
        /// <summary>
        /// 停止函数异步调用请求
        ///
        /// -| 当前仅支持参数recursive为false且force为true的函数。 在1：N的函数做并发异步调用的场景下调用停止异步请求接口时，同一函数实例同时在执行的其他请求也会被一并停止并返回4208 function invocation canceled
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CancelAsyncInvocationResponse CancelAsyncInvocation(CancelAsyncInvocationRequest cancelAsyncInvocationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(cancelAsyncInvocationRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/cancel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelAsyncInvocationRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CancelAsyncInvocationResponse>(response);
        }

        public SyncInvoker<CancelAsyncInvocationResponse> CancelAsyncInvocationInvoker(CancelAsyncInvocationRequest cancelAsyncInvocationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(cancelAsyncInvocationRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/cancel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelAsyncInvocationRequest);
            return new SyncInvoker<CancelAsyncInvocationResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CancelAsyncInvocationResponse>);
        }
        
        /// <summary>
        /// 回调工作流
        ///
        /// 回调工作流
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateCallbackWorkflowResponse CreateCallbackWorkflow(CreateCallbackWorkflowRequest createCallbackWorkflowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createCallbackWorkflowRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/callback", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCallbackWorkflowRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateCallbackWorkflowResponse>(response);
        }

        public SyncInvoker<CreateCallbackWorkflowResponse> CreateCallbackWorkflowInvoker(CreateCallbackWorkflowRequest createCallbackWorkflowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createCallbackWorkflowRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/callback", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCallbackWorkflowRequest);
            return new SyncInvoker<CreateCallbackWorkflowResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateCallbackWorkflowResponse>);
        }
        
        /// <summary>
        /// 创建依赖包版本
        ///
        /// 创建依赖包版本
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDependencyVersionResponse CreateDependencyVersion(CreateDependencyVersionRequest createDependencyVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies/version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDependencyVersionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDependencyVersionResponse>(response);
        }

        public SyncInvoker<CreateDependencyVersionResponse> CreateDependencyVersionInvoker(CreateDependencyVersionRequest createDependencyVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies/version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDependencyVersionRequest);
            return new SyncInvoker<CreateDependencyVersionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDependencyVersionResponse>);
        }
        
        /// <summary>
        /// 创建测试事件
        ///
        /// 创建测试事件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateEventResponse CreateEvent(CreateEventRequest createEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createEventRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEventRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateEventResponse>(response);
        }

        public SyncInvoker<CreateEventResponse> CreateEventInvoker(CreateEventRequest createEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createEventRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEventRequest);
            return new SyncInvoker<CreateEventResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateEventResponse>);
        }
        
        /// <summary>
        /// 创建函数
        ///
        /// 创建指定的函数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateFunctionResponse CreateFunction(CreateFunctionRequest createFunctionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFunctionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateFunctionResponse>(response);
        }

        public SyncInvoker<CreateFunctionResponse> CreateFunctionInvoker(CreateFunctionRequest createFunctionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFunctionRequest);
            return new SyncInvoker<CreateFunctionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateFunctionResponse>);
        }
        
        /// <summary>
        /// 创建应用程序
        ///
        /// 创建应用程序（该功能目前仅支持华北-北京四、华东-上海一）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateFunctionAppResponse CreateFunctionApp(CreateFunctionAppRequest createFunctionAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFunctionAppRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateFunctionAppResponse>(response);
        }

        public SyncInvoker<CreateFunctionAppResponse> CreateFunctionAppInvoker(CreateFunctionAppRequest createFunctionAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFunctionAppRequest);
            return new SyncInvoker<CreateFunctionAppResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateFunctionAppResponse>);
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
        public CreateFunctionTriggerResponse CreateFunctionTrigger(CreateFunctionTriggerRequest createFunctionTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createFunctionTriggerRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFunctionTriggerRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateFunctionTriggerResponse>(response);
        }

        public SyncInvoker<CreateFunctionTriggerResponse> CreateFunctionTriggerInvoker(CreateFunctionTriggerRequest createFunctionTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createFunctionTriggerRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFunctionTriggerRequest);
            return new SyncInvoker<CreateFunctionTriggerResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateFunctionTriggerResponse>);
        }
        
        /// <summary>
        /// 发布函数版本
        ///
        /// 发布函数版本。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateFunctionVersionResponse CreateFunctionVersion(CreateFunctionVersionRequest createFunctionVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createFunctionVersionRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFunctionVersionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateFunctionVersionResponse>(response);
        }

        public SyncInvoker<CreateFunctionVersionResponse> CreateFunctionVersionInvoker(CreateFunctionVersionRequest createFunctionVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createFunctionVersionRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFunctionVersionRequest);
            return new SyncInvoker<CreateFunctionVersionResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateFunctionVersionResponse>);
        }
        
        /// <summary>
        /// 创建资源标签
        ///
        /// 创建资源标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTagsResponse CreateTags(CreateTagsRequest createTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(createTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateTagsResponse>(response);
        }

        public SyncInvoker<CreateTagsResponse> CreateTagsInvoker(CreateTagsRequest createTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(createTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagsRequest);
            return new SyncInvoker<CreateTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateTagsResponse>);
        }
        
        /// <summary>
        /// 创建函数版本别名
        ///
        /// 创建函数灰度版本别名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateVersionAliasResponse CreateVersionAlias(CreateVersionAliasRequest createVersionAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createVersionAliasRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/aliases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVersionAliasRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateVersionAliasResponse>(response);
        }

        public SyncInvoker<CreateVersionAliasResponse> CreateVersionAliasInvoker(CreateVersionAliasRequest createVersionAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createVersionAliasRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/aliases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVersionAliasRequest);
            return new SyncInvoker<CreateVersionAliasResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateVersionAliasResponse>);
        }
        
        /// <summary>
        /// 创建下沉入口
        ///
        /// 创建下沉入口。（该功能目前仅支持华北-北京四、华东-上海一、华东-上海二、西南-贵阳一）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateVpcEndpointResponse CreateVpcEndpoint(CreateVpcEndpointRequest createVpcEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/vpc-endpoint", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVpcEndpointRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateVpcEndpointResponse>(response);
        }

        public SyncInvoker<CreateVpcEndpointResponse> CreateVpcEndpointInvoker(CreateVpcEndpointRequest createVpcEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/vpc-endpoint", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVpcEndpointRequest);
            return new SyncInvoker<CreateVpcEndpointResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateVpcEndpointResponse>);
        }
        
        /// <summary>
        /// 创建函数流
        ///
        /// 创建函数流
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateWorkflowResponse CreateWorkflow(CreateWorkflowRequest createWorkflowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWorkflowRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateWorkflowResponse>(response);
        }

        public SyncInvoker<CreateWorkflowResponse> CreateWorkflowInvoker(CreateWorkflowRequest createWorkflowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWorkflowRequest);
            return new SyncInvoker<CreateWorkflowResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateWorkflowResponse>);
        }
        
        /// <summary>
        /// 删除依赖包版本
        ///
        /// 删除依赖包版本
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDependencyVersionResponse DeleteDependencyVersion(DeleteDependencyVersionRequest deleteDependencyVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDependencyVersionRequest.DependId, out var valueOfDependId)) urlParam.Add("depend_id", valueOfDependId);
            if (StringUtils.TryConvertToNonEmptyString(deleteDependencyVersionRequest.Version, out var valueOfVersion)) urlParam.Add("version", valueOfVersion);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies/{depend_id}/version/{version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDependencyVersionRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDependencyVersionResponse>(response);
        }

        public SyncInvoker<DeleteDependencyVersionResponse> DeleteDependencyVersionInvoker(DeleteDependencyVersionRequest deleteDependencyVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDependencyVersionRequest.DependId, out var valueOfDependId)) urlParam.Add("depend_id", valueOfDependId);
            if (StringUtils.TryConvertToNonEmptyString(deleteDependencyVersionRequest.Version, out var valueOfVersion)) urlParam.Add("version", valueOfVersion);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies/{depend_id}/version/{version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDependencyVersionRequest);
            return new SyncInvoker<DeleteDependencyVersionResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDependencyVersionResponse>);
        }
        
        /// <summary>
        /// 删除指定测试事件
        ///
        /// 删除指定测试事件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteEventResponse DeleteEvent(DeleteEventRequest deleteEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteEventRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            if (StringUtils.TryConvertToNonEmptyString(deleteEventRequest.EventId, out var valueOfEventId)) urlParam.Add("event_id", valueOfEventId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/events/{event_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEventRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteEventResponse>(response);
        }

        public SyncInvoker<DeleteEventResponse> DeleteEventInvoker(DeleteEventRequest deleteEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteEventRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            if (StringUtils.TryConvertToNonEmptyString(deleteEventRequest.EventId, out var valueOfEventId)) urlParam.Add("event_id", valueOfEventId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/events/{event_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEventRequest);
            return new SyncInvoker<DeleteEventResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteEventResponse>);
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
        public DeleteFunctionResponse DeleteFunction(DeleteFunctionRequest deleteFunctionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteFunctionRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFunctionRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteFunctionResponse>(response);
        }

        public SyncInvoker<DeleteFunctionResponse> DeleteFunctionInvoker(DeleteFunctionRequest deleteFunctionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteFunctionRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFunctionRequest);
            return new SyncInvoker<DeleteFunctionResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteFunctionResponse>);
        }
        
        /// <summary>
        /// 删除应用程序
        ///
        /// 删除应用程序（该功能目前仅支持华北-北京四、华东-上海一）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteFunctionAppResponse DeleteFunctionApp(DeleteFunctionAppRequest deleteFunctionAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteFunctionAppRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/applications/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFunctionAppRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteFunctionAppResponse>(response);
        }

        public SyncInvoker<DeleteFunctionAppResponse> DeleteFunctionAppInvoker(DeleteFunctionAppRequest deleteFunctionAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteFunctionAppRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/applications/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFunctionAppRequest);
            return new SyncInvoker<DeleteFunctionAppResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteFunctionAppResponse>);
        }
        
        /// <summary>
        /// 删除函数异步配置信息
        ///
        /// 删除函数异步配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteFunctionAsyncInvokeConfigResponse DeleteFunctionAsyncInvokeConfig(DeleteFunctionAsyncInvokeConfigRequest deleteFunctionAsyncInvokeConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteFunctionAsyncInvokeConfigRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/async-invoke-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFunctionAsyncInvokeConfigRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteFunctionAsyncInvokeConfigResponse>(response);
        }

        public SyncInvoker<DeleteFunctionAsyncInvokeConfigResponse> DeleteFunctionAsyncInvokeConfigInvoker(DeleteFunctionAsyncInvokeConfigRequest deleteFunctionAsyncInvokeConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteFunctionAsyncInvokeConfigRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/async-invoke-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFunctionAsyncInvokeConfigRequest);
            return new SyncInvoker<DeleteFunctionAsyncInvokeConfigResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteFunctionAsyncInvokeConfigResponse>);
        }
        
        /// <summary>
        /// 删除触发器
        ///
        /// 删除触发器。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteFunctionTriggerResponse DeleteFunctionTrigger(DeleteFunctionTriggerRequest deleteFunctionTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteFunctionTriggerRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            if (StringUtils.TryConvertToNonEmptyString(deleteFunctionTriggerRequest.TriggerTypeCode, out var valueOfTriggerTypeCode)) urlParam.Add("trigger_type_code", valueOfTriggerTypeCode);
            if (StringUtils.TryConvertToNonEmptyString(deleteFunctionTriggerRequest.TriggerId, out var valueOfTriggerId)) urlParam.Add("trigger_id", valueOfTriggerId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}/{trigger_type_code}/{trigger_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFunctionTriggerRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteFunctionTriggerResponse>(response);
        }

        public SyncInvoker<DeleteFunctionTriggerResponse> DeleteFunctionTriggerInvoker(DeleteFunctionTriggerRequest deleteFunctionTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteFunctionTriggerRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            if (StringUtils.TryConvertToNonEmptyString(deleteFunctionTriggerRequest.TriggerTypeCode, out var valueOfTriggerTypeCode)) urlParam.Add("trigger_type_code", valueOfTriggerTypeCode);
            if (StringUtils.TryConvertToNonEmptyString(deleteFunctionTriggerRequest.TriggerId, out var valueOfTriggerId)) urlParam.Add("trigger_id", valueOfTriggerId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}/{trigger_type_code}/{trigger_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFunctionTriggerRequest);
            return new SyncInvoker<DeleteFunctionTriggerResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteFunctionTriggerResponse>);
        }
        
        /// <summary>
        /// 删除资源标签
        ///
        /// 删除资源标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTagsResponse DeleteTags(DeleteTagsRequest deleteTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(deleteTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTagsResponse>(response);
        }

        public SyncInvoker<DeleteTagsResponse> DeleteTagsInvoker(DeleteTagsRequest deleteTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(deleteTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTagsRequest);
            return new SyncInvoker<DeleteTagsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTagsResponse>);
        }
        
        /// <summary>
        /// 删除函数版本别名
        ///
        /// 删除函数版本别名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteVersionAliasResponse DeleteVersionAlias(DeleteVersionAliasRequest deleteVersionAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteVersionAliasRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            if (StringUtils.TryConvertToNonEmptyString(deleteVersionAliasRequest.AliasName, out var valueOfAliasName)) urlParam.Add("alias_name", valueOfAliasName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/aliases/{alias_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVersionAliasRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteVersionAliasResponse>(response);
        }

        public SyncInvoker<DeleteVersionAliasResponse> DeleteVersionAliasInvoker(DeleteVersionAliasRequest deleteVersionAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteVersionAliasRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            if (StringUtils.TryConvertToNonEmptyString(deleteVersionAliasRequest.AliasName, out var valueOfAliasName)) urlParam.Add("alias_name", valueOfAliasName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/aliases/{alias_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVersionAliasRequest);
            return new SyncInvoker<DeleteVersionAliasResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteVersionAliasResponse>);
        }
        
        /// <summary>
        /// 删除下沉入口
        ///
        /// 删除下沉入口。（该功能目前仅支持华北-北京四、华东-上海一、华东-上海二、西南-贵阳一）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteVpcEndpointResponse DeleteVpcEndpoint(DeleteVpcEndpointRequest deleteVpcEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteVpcEndpointRequest.VpcId, out var valueOfVpcId)) urlParam.Add("vpc_id", valueOfVpcId);
            if (StringUtils.TryConvertToNonEmptyString(deleteVpcEndpointRequest.SubnetId, out var valueOfSubnetId)) urlParam.Add("subnet_id", valueOfSubnetId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/vpc-endpoint/{vpc_id}/{subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVpcEndpointRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteVpcEndpointResponse>(response);
        }

        public SyncInvoker<DeleteVpcEndpointResponse> DeleteVpcEndpointInvoker(DeleteVpcEndpointRequest deleteVpcEndpointRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteVpcEndpointRequest.VpcId, out var valueOfVpcId)) urlParam.Add("vpc_id", valueOfVpcId);
            if (StringUtils.TryConvertToNonEmptyString(deleteVpcEndpointRequest.SubnetId, out var valueOfSubnetId)) urlParam.Add("subnet_id", valueOfSubnetId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/vpc-endpoint/{vpc_id}/{subnet_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVpcEndpointRequest);
            return new SyncInvoker<DeleteVpcEndpointResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteVpcEndpointResponse>);
        }
        
        /// <summary>
        /// 允许异步状态通知
        ///
        /// 允许异步状态通知。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EnableAsyncStatusLogResponse EnableAsyncStatusLog(EnableAsyncStatusLogRequest enableAsyncStatusLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/enable-async-status-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableAsyncStatusLogRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<EnableAsyncStatusLogResponse>(response);
        }

        public SyncInvoker<EnableAsyncStatusLogResponse> EnableAsyncStatusLogInvoker(EnableAsyncStatusLogRequest enableAsyncStatusLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/enable-async-status-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableAsyncStatusLogRequest);
            return new SyncInvoker<EnableAsyncStatusLogResponse>(this, "POST", request, JsonUtils.DeSerializeNull<EnableAsyncStatusLogResponse>);
        }
        
        /// <summary>
        /// 开通lts日志上报功能
        ///
        /// 开通lts日志上报功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EnableLtsLogsResponse EnableLtsLogs(EnableLtsLogsRequest enableLtsLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/enable-lts-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableLtsLogsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<EnableLtsLogsResponse>(response);
        }

        public SyncInvoker<EnableLtsLogsResponse> EnableLtsLogsInvoker(EnableLtsLogsRequest enableLtsLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/enable-lts-logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableLtsLogsRequest);
            return new SyncInvoker<EnableLtsLogsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<EnableLtsLogsResponse>);
        }
        
        /// <summary>
        /// 导出函数
        ///
        /// 导出函数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ExportFunctionResponse ExportFunction(ExportFunctionRequest exportFunctionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(exportFunctionRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportFunctionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerializeNull<ExportFunctionResponse>(response);
        }

        public SyncInvoker<ExportFunctionResponse> ExportFunctionInvoker(ExportFunctionRequest exportFunctionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(exportFunctionRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportFunctionRequest);
            return new SyncInvoker<ExportFunctionResponse>(this, "GET", request, JsonUtils.DeSerializeNull<ExportFunctionResponse>);
        }
        
        /// <summary>
        /// 导入函数
        ///
        /// 导入函数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ImportFunctionResponse ImportFunction(ImportFunctionRequest importFunctionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/import", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", importFunctionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ImportFunctionResponse>(response);
        }

        public SyncInvoker<ImportFunctionResponse> ImportFunctionInvoker(ImportFunctionRequest importFunctionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/import", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", importFunctionRequest);
            return new SyncInvoker<ImportFunctionResponse>(this, "POST", request, JsonUtils.DeSerialize<ImportFunctionResponse>);
        }
        
        /// <summary>
        /// 同步执行函数
        ///
        /// 同步调用指的是客户端请求需要明确等到响应结果，也就是说这样的请求必须得调用到用户的函数，并且等到调用完成才返回。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public InvokeFunctionResponse InvokeFunction(InvokeFunctionRequest invokeFunctionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(invokeFunctionRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/invocations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", invokeFunctionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<InvokeFunctionResponse>(response);
        }

        public SyncInvoker<InvokeFunctionResponse> InvokeFunctionInvoker(InvokeFunctionRequest invokeFunctionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(invokeFunctionRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/invocations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", invokeFunctionRequest);
            return new SyncInvoker<InvokeFunctionResponse>(this, "POST", request, JsonUtils.DeSerialize<InvokeFunctionResponse>);
        }
        
        /// <summary>
        /// 获取函数活跃异步调用请求列表
        ///
        /// 获取函数异步调用活跃请求列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListActiveAsyncInvocationsResponse ListActiveAsyncInvocations(ListActiveAsyncInvocationsRequest listActiveAsyncInvocationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listActiveAsyncInvocationsRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/active-async-invocations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listActiveAsyncInvocationsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListActiveAsyncInvocationsResponse>(response);
        }

        public SyncInvoker<ListActiveAsyncInvocationsResponse> ListActiveAsyncInvocationsInvoker(ListActiveAsyncInvocationsRequest listActiveAsyncInvocationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listActiveAsyncInvocationsRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/active-async-invocations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listActiveAsyncInvocationsRequest);
            return new SyncInvoker<ListActiveAsyncInvocationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListActiveAsyncInvocationsResponse>);
        }
        
        /// <summary>
        /// 查询应用程序模板列表
        ///
        /// 查询应用程序模板列表（该功能目前仅支持华北-北京四、华东-上海一）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAppTemplatesResponse ListAppTemplates(ListAppTemplatesRequest listAppTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/application/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppTemplatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAppTemplatesResponse>(response);
        }

        public SyncInvoker<ListAppTemplatesResponse> ListAppTemplatesInvoker(ListAppTemplatesRequest listAppTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/application/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAppTemplatesRequest);
            return new SyncInvoker<ListAppTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAppTemplatesResponse>);
        }
        
        /// <summary>
        /// 获取函数异步调用请求列表
        ///
        /// 获取函数异步调用请求列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAsyncInvocationsResponse ListAsyncInvocations(ListAsyncInvocationsRequest listAsyncInvocationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAsyncInvocationsRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/async-invocations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAsyncInvocationsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAsyncInvocationsResponse>(response);
        }

        public SyncInvoker<ListAsyncInvocationsResponse> ListAsyncInvocationsInvoker(ListAsyncInvocationsRequest listAsyncInvocationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAsyncInvocationsRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/async-invocations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAsyncInvocationsRequest);
            return new SyncInvoker<ListAsyncInvocationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAsyncInvocationsResponse>);
        }
        
        /// <summary>
        /// 获取指定函数绑定的servicebridge函数列表
        ///
        /// 获取指定函数绑定的servicebridge函数列表信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBridgeFunctionsResponse ListBridgeFunctions(ListBridgeFunctionsRequest listBridgeFunctionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBridgeFunctionsRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/servicebridge/relation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBridgeFunctionsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listBridgeFunctionsResponse = JsonUtils.DeSerializeNull<ListBridgeFunctionsResponse>(response);
            listBridgeFunctionsResponse.Body = JsonUtils.DeSerializeList<ListFunctionResult>(response);
            return listBridgeFunctionsResponse;
        }

        public SyncInvoker<ListBridgeFunctionsResponse> ListBridgeFunctionsInvoker(ListBridgeFunctionsRequest listBridgeFunctionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBridgeFunctionsRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/servicebridge/relation", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBridgeFunctionsRequest);
            return new SyncInvoker<ListBridgeFunctionsResponse>(this, "GET", request, response =>
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
        public ListBridgeVersionsResponse ListBridgeVersions(ListBridgeVersionsRequest listBridgeVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/servicebridge/version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBridgeVersionsRequest);
            var response = DoHttpRequestSync("GET", request);
            var listBridgeVersionsResponse = JsonUtils.DeSerializeNull<ListBridgeVersionsResponse>(response);
            listBridgeVersionsResponse.Body = JsonUtils.DeSerializeList<ServiceBridgeVersion>(response);
            return listBridgeVersionsResponse;
        }

        public SyncInvoker<ListBridgeVersionsResponse> ListBridgeVersionsInvoker(ListBridgeVersionsRequest listBridgeVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/servicebridge/version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBridgeVersionsRequest);
            return new SyncInvoker<ListBridgeVersionsResponse>(this, "GET", request, response =>
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
        public ListDependenciesResponse ListDependencies(ListDependenciesRequest listDependenciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDependenciesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDependenciesResponse>(response);
        }

        public SyncInvoker<ListDependenciesResponse> ListDependenciesInvoker(ListDependenciesRequest listDependenciesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDependenciesRequest);
            return new SyncInvoker<ListDependenciesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDependenciesResponse>);
        }
        
        /// <summary>
        /// 获取依赖包版本列表
        ///
        /// 获取依赖包版本列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDependencyVersionResponse ListDependencyVersion(ListDependencyVersionRequest listDependencyVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDependencyVersionRequest.DependId, out var valueOfDependId)) urlParam.Add("depend_id", valueOfDependId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies/{depend_id}/version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDependencyVersionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDependencyVersionResponse>(response);
        }

        public SyncInvoker<ListDependencyVersionResponse> ListDependencyVersionInvoker(ListDependencyVersionRequest listDependencyVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listDependencyVersionRequest.DependId, out var valueOfDependId)) urlParam.Add("depend_id", valueOfDependId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies/{depend_id}/version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDependencyVersionRequest);
            return new SyncInvoker<ListDependencyVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDependencyVersionResponse>);
        }
        
        /// <summary>
        /// 获取指定函数的测试事件列表
        ///
        /// 获取指定函数的测试事件列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListEventsResponse ListEvents(ListEventsRequest listEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEventsRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEventsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListEventsResponse>(response);
        }

        public SyncInvoker<ListEventsResponse> ListEventsInvoker(ListEventsRequest listEventsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listEventsRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/events", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEventsRequest);
            return new SyncInvoker<ListEventsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListEventsResponse>);
        }
        
        /// <summary>
        /// 查询应用程序列表
        ///
        /// 查询应用程序列表（该功能目前仅支持华北-北京四、华东-上海一）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFunctionApplicationsResponse ListFunctionApplications(ListFunctionApplicationsRequest listFunctionApplicationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionApplicationsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFunctionApplicationsResponse>(response);
        }

        public SyncInvoker<ListFunctionApplicationsResponse> ListFunctionApplicationsInvoker(ListFunctionApplicationsRequest listFunctionApplicationsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/applications", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionApplicationsRequest);
            return new SyncInvoker<ListFunctionApplicationsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFunctionApplicationsResponse>);
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
        public ListFunctionAsMetricResponse ListFunctionAsMetric(ListFunctionAsMetricRequest listFunctionAsMetricRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/function/report", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionAsMetricRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFunctionAsMetricResponse>(response);
        }

        public SyncInvoker<ListFunctionAsMetricResponse> ListFunctionAsMetricInvoker(ListFunctionAsMetricRequest listFunctionAsMetricRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/function/report", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionAsMetricRequest);
            return new SyncInvoker<ListFunctionAsMetricResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFunctionAsMetricResponse>);
        }
        
        /// <summary>
        /// 获取函数异步配置列表
        ///
        /// 获取指定函数所有版本的异步配置列表。。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFunctionAsyncInvokeConfigResponse ListFunctionAsyncInvokeConfig(ListFunctionAsyncInvokeConfigRequest listFunctionAsyncInvokeConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFunctionAsyncInvokeConfigRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/async-invoke-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionAsyncInvokeConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFunctionAsyncInvokeConfigResponse>(response);
        }

        public SyncInvoker<ListFunctionAsyncInvokeConfigResponse> ListFunctionAsyncInvokeConfigInvoker(ListFunctionAsyncInvokeConfigRequest listFunctionAsyncInvokeConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFunctionAsyncInvokeConfigRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/async-invoke-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionAsyncInvokeConfigRequest);
            return new SyncInvoker<ListFunctionAsyncInvokeConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFunctionAsyncInvokeConfigResponse>);
        }
        
        /// <summary>
        /// 获取函数预留实例数量
        ///
        /// 获取函数预留实例数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFunctionReservedInstancesResponse ListFunctionReservedInstances(ListFunctionReservedInstancesRequest listFunctionReservedInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/reservedinstances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionReservedInstancesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFunctionReservedInstancesResponse>(response);
        }

        public SyncInvoker<ListFunctionReservedInstancesResponse> ListFunctionReservedInstancesInvoker(ListFunctionReservedInstancesRequest listFunctionReservedInstancesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/reservedinstances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionReservedInstancesRequest);
            return new SyncInvoker<ListFunctionReservedInstancesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFunctionReservedInstancesResponse>);
        }
        
        /// <summary>
        /// 获取指定时间段的函数运行指标
        ///
        /// 获取指定时间段的函数运行指标。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFunctionStatisticsResponse ListFunctionStatistics(ListFunctionStatisticsRequest listFunctionStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFunctionStatisticsRequest.FuncUrn, out var valueOfFuncUrn)) urlParam.Add("func_urn", valueOfFuncUrn);
            if (StringUtils.TryConvertToNonEmptyString(listFunctionStatisticsRequest.Period, out var valueOfPeriod)) urlParam.Add("period", valueOfPeriod);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{func_urn}/statistics/{period}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionStatisticsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFunctionStatisticsResponse>(response);
        }

        public SyncInvoker<ListFunctionStatisticsResponse> ListFunctionStatisticsInvoker(ListFunctionStatisticsRequest listFunctionStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFunctionStatisticsRequest.FuncUrn, out var valueOfFuncUrn)) urlParam.Add("func_urn", valueOfFuncUrn);
            if (StringUtils.TryConvertToNonEmptyString(listFunctionStatisticsRequest.Period, out var valueOfPeriod)) urlParam.Add("period", valueOfPeriod);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{func_urn}/statistics/{period}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionStatisticsRequest);
            return new SyncInvoker<ListFunctionStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFunctionStatisticsResponse>);
        }
        
        /// <summary>
        /// 查询函数标签列表
        ///
        /// 查询函数标签列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFunctionTagsResponse ListFunctionTags(ListFunctionTagsRequest listFunctionTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFunctionTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(listFunctionTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFunctionTagsResponse>(response);
        }

        public SyncInvoker<ListFunctionTagsResponse> ListFunctionTagsInvoker(ListFunctionTagsRequest listFunctionTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFunctionTagsRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(listFunctionTagsRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionTagsRequest);
            return new SyncInvoker<ListFunctionTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFunctionTagsResponse>);
        }
        
        /// <summary>
        /// 获取函数模板列表
        ///
        /// 获取函数模板列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFunctionTemplateResponse ListFunctionTemplate(ListFunctionTemplateRequest listFunctionTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionTemplateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFunctionTemplateResponse>(response);
        }

        public SyncInvoker<ListFunctionTemplateResponse> ListFunctionTemplateInvoker(ListFunctionTemplateRequest listFunctionTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionTemplateRequest);
            return new SyncInvoker<ListFunctionTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFunctionTemplateResponse>);
        }
        
        /// <summary>
        /// 获取指定函数的所有触发器
        ///
        /// 获取指定函数的所有触发器设置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFunctionTriggersResponse ListFunctionTriggers(ListFunctionTriggersRequest listFunctionTriggersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFunctionTriggersRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionTriggersRequest);
            var response = DoHttpRequestSync("GET", request);
            var listFunctionTriggersResponse = JsonUtils.DeSerializeNull<ListFunctionTriggersResponse>(response);
            listFunctionTriggersResponse.Body = JsonUtils.DeSerializeList<ListFunctionTriggerResult>(response);
            return listFunctionTriggersResponse;
        }

        public SyncInvoker<ListFunctionTriggersResponse> ListFunctionTriggersInvoker(ListFunctionTriggersRequest listFunctionTriggersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFunctionTriggersRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionTriggersRequest);
            return new SyncInvoker<ListFunctionTriggersResponse>(this, "GET", request, response =>
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
        public ListFunctionVersionsResponse ListFunctionVersions(ListFunctionVersionsRequest listFunctionVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFunctionVersionsRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionVersionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFunctionVersionsResponse>(response);
        }

        public SyncInvoker<ListFunctionVersionsResponse> ListFunctionVersionsInvoker(ListFunctionVersionsRequest listFunctionVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listFunctionVersionsRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/versions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionVersionsRequest);
            return new SyncInvoker<ListFunctionVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFunctionVersionsResponse>);
        }
        
        /// <summary>
        /// 获取函数列表
        ///
        /// 获取函数列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListFunctionsResponse ListFunctions(ListFunctionsRequest listFunctionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListFunctionsResponse>(response);
        }

        public SyncInvoker<ListFunctionsResponse> ListFunctionsInvoker(ListFunctionsRequest listFunctionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionsRequest);
            return new SyncInvoker<ListFunctionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFunctionsResponse>);
        }
        
        /// <summary>
        /// 查询租户配额
        ///
        /// 查询租户配额
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListQuotasResponse ListQuotas(ListQuotasRequest listQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListQuotasResponse>(response);
        }

        public SyncInvoker<ListQuotasResponse> ListQuotasInvoker(ListQuotasRequest listQuotasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotasRequest);
            return new SyncInvoker<ListQuotasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListQuotasResponse>);
        }
        
        /// <summary>
        /// 获取函数预留实例配置列表
        ///
        /// 获取函数预留实例配置列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListReservedInstanceConfigsResponse ListReservedInstanceConfigs(ListReservedInstanceConfigsRequest listReservedInstanceConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/reservedinstanceconfigs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReservedInstanceConfigsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListReservedInstanceConfigsResponse>(response);
        }

        public SyncInvoker<ListReservedInstanceConfigsResponse> ListReservedInstanceConfigsInvoker(ListReservedInstanceConfigsRequest listReservedInstanceConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/reservedinstanceconfigs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReservedInstanceConfigsRequest);
            return new SyncInvoker<ListReservedInstanceConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListReservedInstanceConfigsResponse>);
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
        public ListStatisticsResponse ListStatistics(ListStatisticsRequest listStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStatisticsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListStatisticsResponse>(response);
        }

        public SyncInvoker<ListStatisticsResponse> ListStatisticsInvoker(ListStatisticsRequest listStatisticsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/statistics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStatisticsRequest);
            return new SyncInvoker<ListStatisticsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStatisticsResponse>);
        }
        
        /// <summary>
        /// 获取指定函数所有版本别名列表
        ///
        /// 获取函数版本别名列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListVersionAliasesResponse ListVersionAliases(ListVersionAliasesRequest listVersionAliasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listVersionAliasesRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/aliases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionAliasesRequest);
            var response = DoHttpRequestSync("GET", request);
            var listVersionAliasesResponse = JsonUtils.DeSerializeNull<ListVersionAliasesResponse>(response);
            listVersionAliasesResponse.Body = JsonUtils.DeSerializeList<ListVersionAliasResult>(response);
            return listVersionAliasesResponse;
        }

        public SyncInvoker<ListVersionAliasesResponse> ListVersionAliasesInvoker(ListVersionAliasesRequest listVersionAliasesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listVersionAliasesRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/aliases", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionAliasesRequest);
            return new SyncInvoker<ListVersionAliasesResponse>(this, "GET", request, response =>
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
        public ListWorkflowResponse ListWorkflow(ListWorkflowRequest listWorkflowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWorkflowRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListWorkflowResponse>(response);
        }

        public SyncInvoker<ListWorkflowResponse> ListWorkflowInvoker(ListWorkflowRequest listWorkflowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWorkflowRequest);
            return new SyncInvoker<ListWorkflowResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWorkflowResponse>);
        }
        
        /// <summary>
        /// 获取指定函数流执行实例列表
        ///
        /// 获取指定函数流执行实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListWorkflowExecutionsResponse ListWorkflowExecutions(ListWorkflowExecutionsRequest listWorkflowExecutionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listWorkflowExecutionsRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWorkflowExecutionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListWorkflowExecutionsResponse>(response);
        }

        public SyncInvoker<ListWorkflowExecutionsResponse> ListWorkflowExecutionsInvoker(ListWorkflowExecutionsRequest listWorkflowExecutionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listWorkflowExecutionsRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWorkflowExecutionsRequest);
            return new SyncInvoker<ListWorkflowExecutionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListWorkflowExecutionsResponse>);
        }
        
        /// <summary>
        /// 重试函数流
        ///
        /// 重试函数流
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RetryWorkFlowResponse RetryWorkFlow(RetryWorkFlowRequest retryWorkFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(retryWorkFlowRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            if (StringUtils.TryConvertToNonEmptyString(retryWorkFlowRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/executions/{execution_id}/retry", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryWorkFlowRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<RetryWorkFlowResponse>(response);
        }

        public SyncInvoker<RetryWorkFlowResponse> RetryWorkFlowInvoker(RetryWorkFlowRequest retryWorkFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(retryWorkFlowRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            if (StringUtils.TryConvertToNonEmptyString(retryWorkFlowRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/executions/{execution_id}/retry", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryWorkFlowRequest);
            return new SyncInvoker<RetryWorkFlowResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RetryWorkFlowResponse>);
        }
        
        /// <summary>
        /// 查询应用程序模板详情
        ///
        /// 查询应用程序模板详情（该功能目前仅支持华北-北京四、华东-上海一）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAppTemplateResponse ShowAppTemplate(ShowAppTemplateRequest showAppTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAppTemplateRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/application/templates/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppTemplateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAppTemplateResponse>(response);
        }

        public SyncInvoker<ShowAppTemplateResponse> ShowAppTemplateInvoker(ShowAppTemplateRequest showAppTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showAppTemplateRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/application/templates/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppTemplateRequest);
            return new SyncInvoker<ShowAppTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAppTemplateResponse>);
        }
        
        /// <summary>
        /// 获取依赖包版本详情
        ///
        /// 获取依赖包版本详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDependencyVersionResponse ShowDependencyVersion(ShowDependencyVersionRequest showDependencyVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDependencyVersionRequest.DependId, out var valueOfDependId)) urlParam.Add("depend_id", valueOfDependId);
            if (StringUtils.TryConvertToNonEmptyString(showDependencyVersionRequest.Version, out var valueOfVersion)) urlParam.Add("version", valueOfVersion);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies/{depend_id}/version/{version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDependencyVersionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDependencyVersionResponse>(response);
        }

        public SyncInvoker<ShowDependencyVersionResponse> ShowDependencyVersionInvoker(ShowDependencyVersionRequest showDependencyVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDependencyVersionRequest.DependId, out var valueOfDependId)) urlParam.Add("depend_id", valueOfDependId);
            if (StringUtils.TryConvertToNonEmptyString(showDependencyVersionRequest.Version, out var valueOfVersion)) urlParam.Add("version", valueOfVersion);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies/{depend_id}/version/{version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDependencyVersionRequest);
            return new SyncInvoker<ShowDependencyVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDependencyVersionResponse>);
        }
        
        /// <summary>
        /// 获取测试事件详细信息
        ///
        /// 获取测试事件详细信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowEventResponse ShowEvent(ShowEventRequest showEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showEventRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            if (StringUtils.TryConvertToNonEmptyString(showEventRequest.EventId, out var valueOfEventId)) urlParam.Add("event_id", valueOfEventId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/events/{event_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEventRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowEventResponse>(response);
        }

        public SyncInvoker<ShowEventResponse> ShowEventInvoker(ShowEventRequest showEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showEventRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            if (StringUtils.TryConvertToNonEmptyString(showEventRequest.EventId, out var valueOfEventId)) urlParam.Add("event_id", valueOfEventId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/events/{event_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEventRequest);
            return new SyncInvoker<ShowEventResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowEventResponse>);
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
        public ShowFuncReservedInstanceMetricsResponse ShowFuncReservedInstanceMetrics(ShowFuncReservedInstanceMetricsRequest showFuncReservedInstanceMetricsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFuncReservedInstanceMetricsRequest.FuncUrn, out var valueOfFuncUrn)) urlParam.Add("func_urn", valueOfFuncUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{func_urn}/instancereports", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFuncReservedInstanceMetricsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowFuncReservedInstanceMetricsResponse>(response);
        }

        public SyncInvoker<ShowFuncReservedInstanceMetricsResponse> ShowFuncReservedInstanceMetricsInvoker(ShowFuncReservedInstanceMetricsRequest showFuncReservedInstanceMetricsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFuncReservedInstanceMetricsRequest.FuncUrn, out var valueOfFuncUrn)) urlParam.Add("func_urn", valueOfFuncUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{func_urn}/instancereports", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFuncReservedInstanceMetricsRequest);
            return new SyncInvoker<ShowFuncReservedInstanceMetricsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFuncReservedInstanceMetricsResponse>);
        }
        
        /// <summary>
        /// 查询函数快照制作状态
        ///
        /// 查询函数快照制作状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowFuncSnapshotStateResponse ShowFuncSnapshotState(ShowFuncSnapshotStateRequest showFuncSnapshotStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFuncSnapshotStateRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            if (StringUtils.TryConvertToNonEmptyString(showFuncSnapshotStateRequest.Action, out var valueOfAction)) urlParam.Add("action", valueOfAction);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/snapshots/{action}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFuncSnapshotStateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowFuncSnapshotStateResponse>(response);
        }

        public SyncInvoker<ShowFuncSnapshotStateResponse> ShowFuncSnapshotStateInvoker(ShowFuncSnapshotStateRequest showFuncSnapshotStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFuncSnapshotStateRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            if (StringUtils.TryConvertToNonEmptyString(showFuncSnapshotStateRequest.Action, out var valueOfAction)) urlParam.Add("action", valueOfAction);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/snapshots/{action}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFuncSnapshotStateRequest);
            return new SyncInvoker<ShowFuncSnapshotStateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFuncSnapshotStateResponse>);
        }
        
        /// <summary>
        /// 查询应用程序详情
        ///
        /// 查询应用程序详情（该功能目前仅支持华北-北京四、华东-上海一）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowFunctionAppResponse ShowFunctionApp(ShowFunctionAppRequest showFunctionAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFunctionAppRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/applications/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFunctionAppRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowFunctionAppResponse>(response);
        }

        public SyncInvoker<ShowFunctionAppResponse> ShowFunctionAppInvoker(ShowFunctionAppRequest showFunctionAppRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFunctionAppRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/applications/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFunctionAppRequest);
            return new SyncInvoker<ShowFunctionAppResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFunctionAppResponse>);
        }
        
        /// <summary>
        /// 获取函数异步配置信息
        ///
        /// 获取指定函数某一版本的异步配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowFunctionAsyncInvokeConfigResponse ShowFunctionAsyncInvokeConfig(ShowFunctionAsyncInvokeConfigRequest showFunctionAsyncInvokeConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFunctionAsyncInvokeConfigRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/async-invoke-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFunctionAsyncInvokeConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowFunctionAsyncInvokeConfigResponse>(response);
        }

        public SyncInvoker<ShowFunctionAsyncInvokeConfigResponse> ShowFunctionAsyncInvokeConfigInvoker(ShowFunctionAsyncInvokeConfigRequest showFunctionAsyncInvokeConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFunctionAsyncInvokeConfigRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/async-invoke-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFunctionAsyncInvokeConfigRequest);
            return new SyncInvoker<ShowFunctionAsyncInvokeConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFunctionAsyncInvokeConfigResponse>);
        }
        
        /// <summary>
        /// 获取指定函数代码
        ///
        /// 获取指定函数的代码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowFunctionCodeResponse ShowFunctionCode(ShowFunctionCodeRequest showFunctionCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFunctionCodeRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/code", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFunctionCodeRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowFunctionCodeResponse>(response);
        }

        public SyncInvoker<ShowFunctionCodeResponse> ShowFunctionCodeInvoker(ShowFunctionCodeRequest showFunctionCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFunctionCodeRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/code", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFunctionCodeRequest);
            return new SyncInvoker<ShowFunctionCodeResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFunctionCodeResponse>);
        }
        
        /// <summary>
        /// 获取函数的metadata
        ///
        /// 获取指定函数的metadata。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowFunctionConfigResponse ShowFunctionConfig(ShowFunctionConfigRequest showFunctionConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFunctionConfigRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFunctionConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowFunctionConfigResponse>(response);
        }

        public SyncInvoker<ShowFunctionConfigResponse> ShowFunctionConfigInvoker(ShowFunctionConfigRequest showFunctionConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFunctionConfigRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFunctionConfigRequest);
            return new SyncInvoker<ShowFunctionConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFunctionConfigResponse>);
        }
        
        /// <summary>
        /// 查询函数实例流量指标
        ///
        /// 查询函数流量指标。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowFunctionMetricsResponse ShowFunctionMetrics(ShowFunctionMetricsRequest showFunctionMetricsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFunctionMetricsRequest.FuncUrn, out var valueOfFuncUrn)) urlParam.Add("func_urn", valueOfFuncUrn);
            if (StringUtils.TryConvertToNonEmptyString(showFunctionMetricsRequest.Period, out var valueOfPeriod)) urlParam.Add("period", valueOfPeriod);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{func_urn}/slareports/{period}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFunctionMetricsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowFunctionMetricsResponse>(response);
        }

        public SyncInvoker<ShowFunctionMetricsResponse> ShowFunctionMetricsInvoker(ShowFunctionMetricsRequest showFunctionMetricsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFunctionMetricsRequest.FuncUrn, out var valueOfFuncUrn)) urlParam.Add("func_urn", valueOfFuncUrn);
            if (StringUtils.TryConvertToNonEmptyString(showFunctionMetricsRequest.Period, out var valueOfPeriod)) urlParam.Add("period", valueOfPeriod);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{func_urn}/slareports/{period}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFunctionMetricsRequest);
            return new SyncInvoker<ShowFunctionMetricsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFunctionMetricsResponse>);
        }
        
        /// <summary>
        /// 获取指定函数模板
        ///
        /// 获取指定函数模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowFunctionTemplateResponse ShowFunctionTemplate(ShowFunctionTemplateRequest showFunctionTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFunctionTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFunctionTemplateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowFunctionTemplateResponse>(response);
        }

        public SyncInvoker<ShowFunctionTemplateResponse> ShowFunctionTemplateInvoker(ShowFunctionTemplateRequest showFunctionTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFunctionTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFunctionTemplateRequest);
            return new SyncInvoker<ShowFunctionTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFunctionTemplateResponse>);
        }
        
        /// <summary>
        /// 获取指定触发器的信息
        ///
        /// 获取特定触发器的信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowFunctionTriggerResponse ShowFunctionTrigger(ShowFunctionTriggerRequest showFunctionTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFunctionTriggerRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            if (StringUtils.TryConvertToNonEmptyString(showFunctionTriggerRequest.TriggerTypeCode, out var valueOfTriggerTypeCode)) urlParam.Add("trigger_type_code", valueOfTriggerTypeCode);
            if (StringUtils.TryConvertToNonEmptyString(showFunctionTriggerRequest.TriggerId, out var valueOfTriggerId)) urlParam.Add("trigger_id", valueOfTriggerId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}/{trigger_type_code}/{trigger_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFunctionTriggerRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowFunctionTriggerResponse>(response);
        }

        public SyncInvoker<ShowFunctionTriggerResponse> ShowFunctionTriggerInvoker(ShowFunctionTriggerRequest showFunctionTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showFunctionTriggerRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            if (StringUtils.TryConvertToNonEmptyString(showFunctionTriggerRequest.TriggerTypeCode, out var valueOfTriggerTypeCode)) urlParam.Add("trigger_type_code", valueOfTriggerTypeCode);
            if (StringUtils.TryConvertToNonEmptyString(showFunctionTriggerRequest.TriggerId, out var valueOfTriggerId)) urlParam.Add("trigger_id", valueOfTriggerId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}/{trigger_type_code}/{trigger_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFunctionTriggerRequest);
            return new SyncInvoker<ShowFunctionTriggerResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFunctionTriggerResponse>);
        }
        
        /// <summary>
        /// 获取指定函数的lts日志组日志流配置
        ///
        /// 获取指定函数的lts日志组日志流配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowLtsLogDetailsResponse ShowLtsLogDetails(ShowLtsLogDetailsRequest showLtsLogDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLtsLogDetailsRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/lts-log-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLtsLogDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowLtsLogDetailsResponse>(response);
        }

        public SyncInvoker<ShowLtsLogDetailsResponse> ShowLtsLogDetailsInvoker(ShowLtsLogDetailsRequest showLtsLogDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showLtsLogDetailsRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/lts-log-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLtsLogDetailsRequest);
            return new SyncInvoker<ShowLtsLogDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLtsLogDetailsResponse>);
        }
        
        /// <summary>
        /// 查询异步日志详情
        ///
        /// 查询异步日志详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowProjectAsyncStatusLogInfoResponse ShowProjectAsyncStatusLogInfo(ShowProjectAsyncStatusLogInfoRequest showProjectAsyncStatusLogInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/async-status-log-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectAsyncStatusLogInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectAsyncStatusLogInfoResponse>(response);
        }

        public SyncInvoker<ShowProjectAsyncStatusLogInfoResponse> ShowProjectAsyncStatusLogInfoInvoker(ShowProjectAsyncStatusLogInfoRequest showProjectAsyncStatusLogInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/async-status-log-detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectAsyncStatusLogInfoRequest);
            return new SyncInvoker<ShowProjectAsyncStatusLogInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectAsyncStatusLogInfoResponse>);
        }
        
        /// <summary>
        /// 查询资源标签
        ///
        /// 查询资源标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowProjectTagsListResponse ShowProjectTagsList(ShowProjectTagsListRequest showProjectTagsListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectTagsListRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectTagsListRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectTagsListResponse>(response);
        }

        public SyncInvoker<ShowProjectTagsListResponse> ShowProjectTagsListInvoker(ShowProjectTagsListRequest showProjectTagsListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectTagsListRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectTagsListRequest);
            return new SyncInvoker<ShowProjectTagsListResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectTagsListResponse>);
        }
        
        /// <summary>
        /// 查询资源实例
        ///
        /// 查询资源实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowResInstanceInfoResponse ShowResInstanceInfo(ShowResInstanceInfoRequest showResInstanceInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResInstanceInfoRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(showResInstanceInfoRequest.Action, out var valueOfAction)) urlParam.Add("action", valueOfAction);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/resource-instances/{action}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResInstanceInfoRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowResInstanceInfoResponse>(response);
        }

        public SyncInvoker<ShowResInstanceInfoResponse> ShowResInstanceInfoInvoker(ShowResInstanceInfoRequest showResInstanceInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResInstanceInfoRequest.ResourceType, out var valueOfResourceType)) urlParam.Add("resource_type", valueOfResourceType);
            if (StringUtils.TryConvertToNonEmptyString(showResInstanceInfoRequest.Action, out var valueOfAction)) urlParam.Add("action", valueOfAction);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/resource-instances/{action}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResInstanceInfoRequest);
            return new SyncInvoker<ShowResInstanceInfoResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowResInstanceInfoResponse>);
        }
        
        /// <summary>
        /// 获取函数流指标
        ///
        /// 获取函数流指标
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTenantMetricResponse ShowTenantMetric(ShowTenantMetricRequest showTenantMetricRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflow-statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTenantMetricRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTenantMetricResponse>(response);
        }

        public SyncInvoker<ShowTenantMetricResponse> ShowTenantMetricInvoker(ShowTenantMetricRequest showTenantMetricRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflow-statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTenantMetricRequest);
            return new SyncInvoker<ShowTenantMetricResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTenantMetricResponse>);
        }
        
        /// <summary>
        /// 获取函数调用链配置
        ///
        /// 获取函数调用链配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTracingResponse ShowTracing(ShowTracingRequest showTracingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTracingRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/tracing", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTracingRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTracingResponse>(response);
        }

        public SyncInvoker<ShowTracingResponse> ShowTracingInvoker(ShowTracingRequest showTracingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTracingRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/tracing", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTracingRequest);
            return new SyncInvoker<ShowTracingResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTracingResponse>);
        }
        
        /// <summary>
        /// 获取函数版本的指定别名信息
        ///
        /// 获取函数指定的版本别名信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowVersionAliasResponse ShowVersionAlias(ShowVersionAliasRequest showVersionAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showVersionAliasRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            if (StringUtils.TryConvertToNonEmptyString(showVersionAliasRequest.AliasName, out var valueOfAliasName)) urlParam.Add("alias_name", valueOfAliasName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/aliases/{alias_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionAliasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowVersionAliasResponse>(response);
        }

        public SyncInvoker<ShowVersionAliasResponse> ShowVersionAliasInvoker(ShowVersionAliasRequest showVersionAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showVersionAliasRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            if (StringUtils.TryConvertToNonEmptyString(showVersionAliasRequest.AliasName, out var valueOfAliasName)) urlParam.Add("alias_name", valueOfAliasName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/aliases/{alias_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionAliasRequest);
            return new SyncInvoker<ShowVersionAliasResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVersionAliasResponse>);
        }
        
        /// <summary>
        /// 获取指定函数流实例的元数据
        ///
        /// 获取指定函数流实例的元数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowWorkFlowResponse ShowWorkFlow(ShowWorkFlowRequest showWorkFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showWorkFlowRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkFlowRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowWorkFlowResponse>(response);
        }

        public SyncInvoker<ShowWorkFlowResponse> ShowWorkFlowInvoker(ShowWorkFlowRequest showWorkFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showWorkFlowRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkFlowRequest);
            return new SyncInvoker<ShowWorkFlowResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWorkFlowResponse>);
        }
        
        /// <summary>
        /// 获取指定函数流指标
        ///
        /// 获取指定函数流指标
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowWorkFlowMetricResponse ShowWorkFlowMetric(ShowWorkFlowMetricRequest showWorkFlowMetricRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showWorkFlowMetricRequest.WorkflowUrn, out var valueOfWorkflowUrn)) urlParam.Add("workflow_urn", valueOfWorkflowUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflow-statistic/{workflow_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkFlowMetricRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowWorkFlowMetricResponse>(response);
        }

        public SyncInvoker<ShowWorkFlowMetricResponse> ShowWorkFlowMetricInvoker(ShowWorkFlowMetricRequest showWorkFlowMetricRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showWorkFlowMetricRequest.WorkflowUrn, out var valueOfWorkflowUrn)) urlParam.Add("workflow_urn", valueOfWorkflowUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflow-statistic/{workflow_urn}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkFlowMetricRequest);
            return new SyncInvoker<ShowWorkFlowMetricResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWorkFlowMetricResponse>);
        }
        
        /// <summary>
        /// 获取指定函数流执行实例
        ///
        /// 获取指定函数流执行实例。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowWorkflowExecutionResponse ShowWorkflowExecution(ShowWorkflowExecutionRequest showWorkflowExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showWorkflowExecutionRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            if (StringUtils.TryConvertToNonEmptyString(showWorkflowExecutionRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/executions/{execution_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkflowExecutionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowWorkflowExecutionResponse>(response);
        }

        public SyncInvoker<ShowWorkflowExecutionResponse> ShowWorkflowExecutionInvoker(ShowWorkflowExecutionRequest showWorkflowExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showWorkflowExecutionRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            if (StringUtils.TryConvertToNonEmptyString(showWorkflowExecutionRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/executions/{execution_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkflowExecutionRequest);
            return new SyncInvoker<ShowWorkflowExecutionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWorkflowExecutionResponse>);
        }
        
        /// <summary>
        /// 分页获取指定函数流执行实例列表
        ///
        /// 分页获取指定函数流执行实例列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowWorkflowExecutionForPageResponse ShowWorkflowExecutionForPage(ShowWorkflowExecutionForPageRequest showWorkflowExecutionForPageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showWorkflowExecutionForPageRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/executions-history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkflowExecutionForPageRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowWorkflowExecutionForPageResponse>(response);
        }

        public SyncInvoker<ShowWorkflowExecutionForPageResponse> ShowWorkflowExecutionForPageInvoker(ShowWorkflowExecutionForPageRequest showWorkflowExecutionForPageRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showWorkflowExecutionForPageRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/executions-history", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkflowExecutionForPageRequest);
            return new SyncInvoker<ShowWorkflowExecutionForPageResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowWorkflowExecutionForPageResponse>);
        }
        
        /// <summary>
        /// 同步执行函数流
        ///
        /// 以同步执行方式启动函数流（仅快速模式函数流支持）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StartSyncWorkflowExecutionResponse StartSyncWorkflowExecution(StartSyncWorkflowExecutionRequest startSyncWorkflowExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startSyncWorkflowExecutionRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/sync-executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startSyncWorkflowExecutionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StartSyncWorkflowExecutionResponse>(response);
        }

        public SyncInvoker<StartSyncWorkflowExecutionResponse> StartSyncWorkflowExecutionInvoker(StartSyncWorkflowExecutionRequest startSyncWorkflowExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startSyncWorkflowExecutionRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/sync-executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startSyncWorkflowExecutionRequest);
            return new SyncInvoker<StartSyncWorkflowExecutionResponse>(this, "POST", request, JsonUtils.DeSerialize<StartSyncWorkflowExecutionResponse>);
        }
        
        /// <summary>
        /// 开始执行函数流
        ///
        /// 以异步执行方式启动函数流
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StartWorkflowExecutionResponse StartWorkflowExecution(StartWorkflowExecutionRequest startWorkflowExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startWorkflowExecutionRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startWorkflowExecutionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StartWorkflowExecutionResponse>(response);
        }

        public SyncInvoker<StartWorkflowExecutionResponse> StartWorkflowExecutionInvoker(StartWorkflowExecutionRequest startWorkflowExecutionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startWorkflowExecutionRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/executions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startWorkflowExecutionRequest);
            return new SyncInvoker<StartWorkflowExecutionResponse>(this, "POST", request, JsonUtils.DeSerialize<StartWorkflowExecutionResponse>);
        }
        
        /// <summary>
        /// 停止函数流
        ///
        /// 停止函数流
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StopWorkFlowResponse StopWorkFlow(StopWorkFlowRequest stopWorkFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopWorkFlowRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            if (StringUtils.TryConvertToNonEmptyString(stopWorkFlowRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/executions/{execution_id}/terminate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopWorkFlowRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<StopWorkFlowResponse>(response);
        }

        public SyncInvoker<StopWorkFlowResponse> StopWorkFlowInvoker(StopWorkFlowRequest stopWorkFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopWorkFlowRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            if (StringUtils.TryConvertToNonEmptyString(stopWorkFlowRequest.ExecutionId, out var valueOfExecutionId)) urlParam.Add("execution_id", valueOfExecutionId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/executions/{execution_id}/terminate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopWorkFlowRequest);
            return new SyncInvoker<StopWorkFlowResponse>(this, "POST", request, JsonUtils.DeSerializeNull<StopWorkFlowResponse>);
        }
        
        /// <summary>
        /// 更新测试事件详细信息
        ///
        /// 更新测试事件详细信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateEventResponse UpdateEvent(UpdateEventRequest updateEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateEventRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            if (StringUtils.TryConvertToNonEmptyString(updateEventRequest.EventId, out var valueOfEventId)) urlParam.Add("event_id", valueOfEventId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/events/{event_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEventRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateEventResponse>(response);
        }

        public SyncInvoker<UpdateEventResponse> UpdateEventInvoker(UpdateEventRequest updateEventRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateEventRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            if (StringUtils.TryConvertToNonEmptyString(updateEventRequest.EventId, out var valueOfEventId)) urlParam.Add("event_id", valueOfEventId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/events/{event_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEventRequest);
            return new SyncInvoker<UpdateEventResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateEventResponse>);
        }
        
        /// <summary>
        /// 禁用/启动函数快照
        ///
        /// 禁用/启动函数快照，仅支持java运行时函数，且为非latest版本才能开启函数快照功能。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateFuncSnapshotResponse UpdateFuncSnapshot(UpdateFuncSnapshotRequest updateFuncSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateFuncSnapshotRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            if (StringUtils.TryConvertToNonEmptyString(updateFuncSnapshotRequest.Action, out var valueOfAction)) urlParam.Add("action", valueOfAction);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/snapshots/{action}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFuncSnapshotRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateFuncSnapshotResponse>(response);
        }

        public SyncInvoker<UpdateFuncSnapshotResponse> UpdateFuncSnapshotInvoker(UpdateFuncSnapshotRequest updateFuncSnapshotRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateFuncSnapshotRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            if (StringUtils.TryConvertToNonEmptyString(updateFuncSnapshotRequest.Action, out var valueOfAction)) urlParam.Add("action", valueOfAction);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/snapshots/{action}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFuncSnapshotRequest);
            return new SyncInvoker<UpdateFuncSnapshotResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateFuncSnapshotResponse>);
        }
        
        /// <summary>
        /// 设置函数异步配置信息
        ///
        /// 设置函数异步配置信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateFunctionAsyncInvokeConfigResponse UpdateFunctionAsyncInvokeConfig(UpdateFunctionAsyncInvokeConfigRequest updateFunctionAsyncInvokeConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateFunctionAsyncInvokeConfigRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/async-invoke-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFunctionAsyncInvokeConfigRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateFunctionAsyncInvokeConfigResponse>(response);
        }

        public SyncInvoker<UpdateFunctionAsyncInvokeConfigResponse> UpdateFunctionAsyncInvokeConfigInvoker(UpdateFunctionAsyncInvokeConfigRequest updateFunctionAsyncInvokeConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateFunctionAsyncInvokeConfigRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/async-invoke-config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFunctionAsyncInvokeConfigRequest);
            return new SyncInvoker<UpdateFunctionAsyncInvokeConfigResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateFunctionAsyncInvokeConfigResponse>);
        }
        
        /// <summary>
        /// 修改函数代码
        ///
        /// 修改指定的函数的代码。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateFunctionCodeResponse UpdateFunctionCode(UpdateFunctionCodeRequest updateFunctionCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateFunctionCodeRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/code", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFunctionCodeRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateFunctionCodeResponse>(response);
        }

        public SyncInvoker<UpdateFunctionCodeResponse> UpdateFunctionCodeInvoker(UpdateFunctionCodeRequest updateFunctionCodeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateFunctionCodeRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/code", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFunctionCodeRequest);
            return new SyncInvoker<UpdateFunctionCodeResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateFunctionCodeResponse>);
        }
        
        /// <summary>
        /// 更新函数置顶状态
        ///
        /// 更新函数置顶状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateFunctionCollectStateResponse UpdateFunctionCollectState(UpdateFunctionCollectStateRequest updateFunctionCollectStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateFunctionCollectStateRequest.FuncUrn, out var valueOfFuncUrn)) urlParam.Add("func_urn", valueOfFuncUrn);
            if (StringUtils.TryConvertToNonEmptyString(updateFunctionCollectStateRequest.State, out var valueOfState)) urlParam.Add("state", valueOfState);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{func_urn}/collect/{state}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFunctionCollectStateRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateFunctionCollectStateResponse>(response);
        }

        public SyncInvoker<UpdateFunctionCollectStateResponse> UpdateFunctionCollectStateInvoker(UpdateFunctionCollectStateRequest updateFunctionCollectStateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateFunctionCollectStateRequest.FuncUrn, out var valueOfFuncUrn)) urlParam.Add("func_urn", valueOfFuncUrn);
            if (StringUtils.TryConvertToNonEmptyString(updateFunctionCollectStateRequest.State, out var valueOfState)) urlParam.Add("state", valueOfState);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{func_urn}/collect/{state}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFunctionCollectStateRequest);
            return new SyncInvoker<UpdateFunctionCollectStateResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateFunctionCollectStateResponse>);
        }
        
        /// <summary>
        /// 修改函数的metadata信息
        ///
        /// 修改指定的函数的metadata信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateFunctionConfigResponse UpdateFunctionConfig(UpdateFunctionConfigRequest updateFunctionConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateFunctionConfigRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFunctionConfigRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateFunctionConfigResponse>(response);
        }

        public SyncInvoker<UpdateFunctionConfigResponse> UpdateFunctionConfigInvoker(UpdateFunctionConfigRequest updateFunctionConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateFunctionConfigRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/config", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFunctionConfigRequest);
            return new SyncInvoker<UpdateFunctionConfigResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateFunctionConfigResponse>);
        }
        
        /// <summary>
        /// 更新函数最大实例数
        ///
        /// 更新函数最大实例数
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateFunctionMaxInstanceConfigResponse UpdateFunctionMaxInstanceConfig(UpdateFunctionMaxInstanceConfigRequest updateFunctionMaxInstanceConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateFunctionMaxInstanceConfigRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/config-max-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFunctionMaxInstanceConfigRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateFunctionMaxInstanceConfigResponse>(response);
        }

        public SyncInvoker<UpdateFunctionMaxInstanceConfigResponse> UpdateFunctionMaxInstanceConfigInvoker(UpdateFunctionMaxInstanceConfigRequest updateFunctionMaxInstanceConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateFunctionMaxInstanceConfigRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/config-max-instance", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFunctionMaxInstanceConfigRequest);
            return new SyncInvoker<UpdateFunctionMaxInstanceConfigResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateFunctionMaxInstanceConfigResponse>);
        }
        
        /// <summary>
        /// 修改函数预留实例数量
        ///
        /// 修改函数预留实例数量。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateFunctionReservedInstancesCountResponse UpdateFunctionReservedInstancesCount(UpdateFunctionReservedInstancesCountRequest updateFunctionReservedInstancesCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateFunctionReservedInstancesCountRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/reservedinstances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFunctionReservedInstancesCountRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateFunctionReservedInstancesCountResponse>(response);
        }

        public SyncInvoker<UpdateFunctionReservedInstancesCountResponse> UpdateFunctionReservedInstancesCountInvoker(UpdateFunctionReservedInstancesCountRequest updateFunctionReservedInstancesCountRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateFunctionReservedInstancesCountRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/reservedinstances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFunctionReservedInstancesCountRequest);
            return new SyncInvoker<UpdateFunctionReservedInstancesCountResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateFunctionReservedInstancesCountResponse>);
        }
        
        /// <summary>
        /// 修改函数调用链配置
        ///
        /// 修改函数调用链配置,开通/修改传入aksk，关闭aksk传空
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTracingResponse UpdateTracing(UpdateTracingRequest updateTracingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTracingRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/tracing", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTracingRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateTracingResponse>(response);
        }

        public SyncInvoker<UpdateTracingResponse> UpdateTracingInvoker(UpdateTracingRequest updateTracingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTracingRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/tracing", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTracingRequest);
            return new SyncInvoker<UpdateTracingResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateTracingResponse>);
        }
        
        /// <summary>
        /// 更新触发器
        ///
        /// 更新触发器
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTriggerResponse UpdateTrigger(UpdateTriggerRequest updateTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTriggerRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            if (StringUtils.TryConvertToNonEmptyString(updateTriggerRequest.TriggerTypeCode, out var valueOfTriggerTypeCode)) urlParam.Add("trigger_type_code", valueOfTriggerTypeCode);
            if (StringUtils.TryConvertToNonEmptyString(updateTriggerRequest.TriggerId, out var valueOfTriggerId)) urlParam.Add("trigger_id", valueOfTriggerId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}/{trigger_type_code}/{trigger_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTriggerRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateTriggerResponse>(response);
        }

        public SyncInvoker<UpdateTriggerResponse> UpdateTriggerInvoker(UpdateTriggerRequest updateTriggerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateTriggerRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            if (StringUtils.TryConvertToNonEmptyString(updateTriggerRequest.TriggerTypeCode, out var valueOfTriggerTypeCode)) urlParam.Add("trigger_type_code", valueOfTriggerTypeCode);
            if (StringUtils.TryConvertToNonEmptyString(updateTriggerRequest.TriggerId, out var valueOfTriggerId)) urlParam.Add("trigger_id", valueOfTriggerId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}/{trigger_type_code}/{trigger_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTriggerRequest);
            return new SyncInvoker<UpdateTriggerResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateTriggerResponse>);
        }
        
        /// <summary>
        /// 修改函数版本别名信息
        ///
        /// 修改函数版本别名信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateVersionAliasResponse UpdateVersionAlias(UpdateVersionAliasRequest updateVersionAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateVersionAliasRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            if (StringUtils.TryConvertToNonEmptyString(updateVersionAliasRequest.AliasName, out var valueOfAliasName)) urlParam.Add("alias_name", valueOfAliasName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/aliases/{alias_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateVersionAliasRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateVersionAliasResponse>(response);
        }

        public SyncInvoker<UpdateVersionAliasResponse> UpdateVersionAliasInvoker(UpdateVersionAliasRequest updateVersionAliasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateVersionAliasRequest.FunctionUrn, out var valueOfFunctionUrn)) urlParam.Add("function_urn", valueOfFunctionUrn);
            if (StringUtils.TryConvertToNonEmptyString(updateVersionAliasRequest.AliasName, out var valueOfAliasName)) urlParam.Add("alias_name", valueOfAliasName);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/aliases/{alias_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateVersionAliasRequest);
            return new SyncInvoker<UpdateVersionAliasResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateVersionAliasResponse>);
        }
        
        /// <summary>
        /// 修改指定函数流实例的元数据
        ///
        /// 修改指定函数流实例的元数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateWorkFlowResponse UpdateWorkFlow(UpdateWorkFlowRequest updateWorkFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateWorkFlowRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWorkFlowRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateWorkFlowResponse>(response);
        }

        public SyncInvoker<UpdateWorkFlowResponse> UpdateWorkFlowInvoker(UpdateWorkFlowRequest updateWorkFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateWorkFlowRequest.WorkflowId, out var valueOfWorkflowId)) urlParam.Add("workflow_id", valueOfWorkflowId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWorkFlowRequest);
            return new SyncInvoker<UpdateWorkFlowResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateWorkFlowResponse>);
        }
        
    }
}