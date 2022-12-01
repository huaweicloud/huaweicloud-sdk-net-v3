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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , asyncInvokeFunctionRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/invocations-async",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", asyncInvokeFunctionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AsyncInvokeFunctionResponse>(response);
        }
        
        /// <summary>
        /// 函数异步执行并返回预留实例ID
        ///
        /// 函数异步执行并返回预留实例ID用于场景指客户端请求执行比较费时任务，不需要同步等待执行完成返回结果，该方法提前返回任务执行对应的预留实例ID, 如果预留实例有异常，可以通过该实例ID把对应实例删除（该接口主要针对白名单用户）。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AsyncInvokeReservedFunctionResponse AsyncInvokeReservedFunction(AsyncInvokeReservedFunctionRequest asyncInvokeReservedFunctionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , asyncInvokeReservedFunctionRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/reserved-invocations",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", asyncInvokeReservedFunctionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AsyncInvokeReservedFunctionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , batchDeleteFunctionTriggersRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteFunctionTriggersRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<BatchDeleteFunctionTriggersResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteWorkflowsRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<BatchDeleteWorkflowsResponse>(response);
        }
        
        /// <summary>
        /// 停止函数异步调用请求
        ///
        /// -| 停止函数异步调用请求 当前仅支持recursive为false且force为true的参数。针对1：N的函数做并发异步调用 停止异步请求时实例同时在执行的其他请求也会被一并停止并返回4208 function invocation canceled 目前仅支持广州和贵阳一
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CancelAsyncInvocationResponse CancelAsyncInvocation(CancelAsyncInvocationRequest cancelAsyncInvocationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , cancelAsyncInvocationRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/cancel",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelAsyncInvocationRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CancelAsyncInvocationResponse>(response);
        }
        
        /// <summary>
        /// 创建依赖包
        ///
        /// 创建依赖包
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDependencyResponse CreateDependency(CreateDependencyRequest createDependencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDependencyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateDependencyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies/version",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDependencyVersionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateDependencyVersionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , createEventRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/events",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEventRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateEventResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFunctionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateFunctionResponse>(response);
        }
        
        /// <summary>
        /// 创建触发器
        ///
        /// 创建触发器。
        /// 
        /// - 可以创建的触发器类型包括TIMER、APIG、CTS、DDS、DMS、DIS、LTS、OBS、SMN、KAFKA。
        /// - DDS和KAFKA触发器创建时默认为DISABLE状态，其他触发器默认为ACTIVE状态。
        /// - TIMER、DDS、DMS、KAFKA、LTS触发器支持禁用，其他触发器不支持。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateFunctionTriggerResponse CreateFunctionTrigger(CreateFunctionTriggerRequest createFunctionTriggerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , createFunctionTriggerRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFunctionTriggerRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateFunctionTriggerResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , createFunctionVersionRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/versions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFunctionVersionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateFunctionVersionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , createVersionAliasRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/aliases",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVersionAliasRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateVersionAliasResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createWorkflowRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateWorkflowResponse>(response);
        }
        
        /// <summary>
        /// 删除指定的依赖包
        ///
        /// 删除指定的依赖包
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDependencyResponse DeleteDependency(DeleteDependencyRequest deleteDependencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("depend_id" , deleteDependencyRequest.DependId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies/{depend_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDependencyRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteDependencyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("depend_id" , deleteDependencyVersionRequest.DependId.ToString());
            urlParam.Add("version" , deleteDependencyVersionRequest.Version.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies/{depend_id}/version/{version}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDependencyVersionRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteDependencyVersionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , deleteEventRequest.FunctionUrn.ToString());
            urlParam.Add("event_id" , deleteEventRequest.EventId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/events/{event_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEventRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteEventResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , deleteFunctionRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFunctionRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteFunctionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , deleteFunctionAsyncInvokeConfigRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/async-invoke-config",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFunctionAsyncInvokeConfigRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteFunctionAsyncInvokeConfigResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , deleteFunctionTriggerRequest.FunctionUrn.ToString());
            urlParam.Add("trigger_type_code" , deleteFunctionTriggerRequest.TriggerTypeCode.ToString());
            urlParam.Add("trigger_id" , deleteFunctionTriggerRequest.TriggerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}/{trigger_type_code}/{trigger_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFunctionTriggerRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteFunctionTriggerResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , deleteVersionAliasRequest.FunctionUrn.ToString());
            urlParam.Add("alias_name" , deleteVersionAliasRequest.AliasName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/aliases/{alias_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVersionAliasRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteVersionAliasResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/enable-lts-logs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableLtsLogsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<EnableLtsLogsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , exportFunctionRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/export",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportFunctionRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerializeNull<ExportFunctionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/import",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", importFunctionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ImportFunctionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , invokeFunctionRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/invocations",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", invokeFunctionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<InvokeFunctionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , listAsyncInvocationsRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/async-invocations",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAsyncInvocationsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAsyncInvocationsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDependenciesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListDependenciesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("depend_id" , listDependencyVersionRequest.DependId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies/{depend_id}/version",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDependencyVersionRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListDependencyVersionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , listEventsRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/events",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEventsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListEventsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/function/report",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionAsMetricRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListFunctionAsMetricResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , listFunctionAsyncInvokeConfigRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/async-invoke-configs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionAsyncInvokeConfigRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListFunctionAsyncInvokeConfigResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/reservedinstances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionReservedInstancesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListFunctionReservedInstancesResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("func_urn" , listFunctionStatisticsRequest.FuncUrn.ToString());
            urlParam.Add("period" , listFunctionStatisticsRequest.Period.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{func_urn}/statistics/{period}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionStatisticsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListFunctionStatisticsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , listFunctionTriggersRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionTriggersRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            ListFunctionTriggersResponse listFunctionTriggersResponse = JsonUtils.DeSerializeNull<ListFunctionTriggersResponse>(response);
            listFunctionTriggersResponse.Body = JsonUtils.DeSerializeList<ListFunctionTriggerResult>(response);
            return listFunctionTriggersResponse;
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , listFunctionVersionsRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/versions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionVersionsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListFunctionVersionsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListFunctionsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotasRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListQuotasResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/reservedinstanceconfigs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listReservedInstanceConfigsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListReservedInstanceConfigsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/statistics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStatisticsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListStatisticsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , listVersionAliasesRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/aliases",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionAliasesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            ListVersionAliasesResponse listVersionAliasesResponse = JsonUtils.DeSerializeNull<ListVersionAliasesResponse>(response);
            listVersionAliasesResponse.Body = JsonUtils.DeSerializeList<ListVersionAliasResult>(response);
            return listVersionAliasesResponse;
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWorkflowRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListWorkflowResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id" , listWorkflowExecutionsRequest.WorkflowId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/executions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listWorkflowExecutionsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListWorkflowExecutionsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id" , retryWorkFlowRequest.WorkflowId.ToString());
            urlParam.Add("execution_id" , retryWorkFlowRequest.ExecutionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/executions/{execution_id}/retry",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryWorkFlowRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<RetryWorkFlowResponse>(response);
        }
        
        /// <summary>
        /// 获取指定依赖包
        ///
        /// 获取指定依赖包
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDependcyResponse ShowDependcy(ShowDependcyRequest showDependcyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("depend_id" , showDependcyRequest.DependId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies/{depend_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDependcyRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowDependcyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("depend_id" , showDependencyVersionRequest.DependId.ToString());
            urlParam.Add("version" , showDependencyVersionRequest.Version.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies/{depend_id}/version/{version}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDependencyVersionRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowDependencyVersionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , showEventRequest.FunctionUrn.ToString());
            urlParam.Add("event_id" , showEventRequest.EventId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/events/{event_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEventRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowEventResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , showFunctionAsyncInvokeConfigRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/async-invoke-config",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFunctionAsyncInvokeConfigRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowFunctionAsyncInvokeConfigResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , showFunctionCodeRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/code",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFunctionCodeRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowFunctionCodeResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , showFunctionConfigRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/config",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFunctionConfigRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowFunctionConfigResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , showFunctionTriggerRequest.FunctionUrn.ToString());
            urlParam.Add("trigger_type_code" , showFunctionTriggerRequest.TriggerTypeCode.ToString());
            urlParam.Add("trigger_id" , showFunctionTriggerRequest.TriggerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}/{trigger_type_code}/{trigger_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFunctionTriggerRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowFunctionTriggerResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , showLtsLogDetailsRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/lts-log-detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLtsLogDetailsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowLtsLogDetailsResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflow-statistic",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTenantMetricRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowTenantMetricResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , showTracingRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/tracing",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTracingRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowTracingResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , showVersionAliasRequest.FunctionUrn.ToString());
            urlParam.Add("alias_name" , showVersionAliasRequest.AliasName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/aliases/{alias_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionAliasRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowVersionAliasResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id" , showWorkFlowRequest.WorkflowId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkFlowRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowWorkFlowResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_urn" , showWorkFlowMetricRequest.WorkflowUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflow-statistic/{workflow_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkFlowMetricRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowWorkFlowMetricResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id" , showWorkflowExecutionRequest.WorkflowId.ToString());
            urlParam.Add("execution_id" , showWorkflowExecutionRequest.ExecutionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/executions/{execution_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkflowExecutionRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowWorkflowExecutionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id" , showWorkflowExecutionForPageRequest.WorkflowId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/executions-history",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showWorkflowExecutionForPageRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowWorkflowExecutionForPageResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id" , startSyncWorkflowExecutionRequest.WorkflowId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/sync-executions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", startSyncWorkflowExecutionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<StartSyncWorkflowExecutionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id" , startWorkflowExecutionRequest.WorkflowId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/executions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", startWorkflowExecutionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<StartWorkflowExecutionResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id" , stopWorkFlowRequest.WorkflowId.ToString());
            urlParam.Add("execution_id" , stopWorkFlowRequest.ExecutionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}/executions/{execution_id}/terminate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopWorkFlowRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<StopWorkFlowResponse>(response);
        }
        
        /// <summary>
        /// 更新指定依赖包
        ///
        /// 更新指定依赖包
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDependcyResponse UpdateDependcy(UpdateDependcyRequest updateDependcyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("depend_id" , updateDependcyRequest.DependId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies/{depend_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDependcyRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDependcyResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , updateEventRequest.FunctionUrn.ToString());
            urlParam.Add("event_id" , updateEventRequest.EventId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/events/{event_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEventRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateEventResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , updateFunctionAsyncInvokeConfigRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/async-invoke-config",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFunctionAsyncInvokeConfigRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateFunctionAsyncInvokeConfigResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , updateFunctionCodeRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/code",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFunctionCodeRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateFunctionCodeResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , updateFunctionConfigRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/config",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFunctionConfigRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateFunctionConfigResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , updateFunctionMaxInstanceConfigRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/config-max-instance",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFunctionMaxInstanceConfigRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateFunctionMaxInstanceConfigResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , updateFunctionReservedInstancesCountRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/reservedinstances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFunctionReservedInstancesCountRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateFunctionReservedInstancesCountResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , updateTracingRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/tracing",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTracingRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateTracingResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , updateTriggerRequest.FunctionUrn.ToString());
            urlParam.Add("trigger_type_code" , updateTriggerRequest.TriggerTypeCode.ToString());
            urlParam.Add("trigger_id" , updateTriggerRequest.TriggerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}/{trigger_type_code}/{trigger_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTriggerRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateTriggerResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , updateVersionAliasRequest.FunctionUrn.ToString());
            urlParam.Add("alias_name" , updateVersionAliasRequest.AliasName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/aliases/{alias_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateVersionAliasRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateVersionAliasResponse>(response);
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
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("workflow_id" , updateWorkFlowRequest.WorkflowId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/workflows/{workflow_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateWorkFlowRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateWorkFlowResponse>(response);
        }
        
    }
}