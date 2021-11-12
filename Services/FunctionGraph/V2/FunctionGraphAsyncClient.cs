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
        /// 异步执行函数。
        /// </summary>
        public async Task<AsyncInvokeFunctionResponse> AsyncInvokeFunctionAsync(AsyncInvokeFunctionRequest asyncInvokeFunctionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , asyncInvokeFunctionRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/invocations-async",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", asyncInvokeFunctionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AsyncInvokeFunctionResponse>(response);
        }
        
        /// <summary>
        /// 函数异步执行并返回预留实例ID。
        /// </summary>
        public async Task<AsyncInvokeReservedFunctionResponse> AsyncInvokeReservedFunctionAsync(AsyncInvokeReservedFunctionRequest asyncInvokeReservedFunctionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , asyncInvokeReservedFunctionRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/reserved-invocations",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", asyncInvokeReservedFunctionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AsyncInvokeReservedFunctionResponse>(response);
        }
        
        /// <summary>
        /// 创建依赖包
        /// </summary>
        public async Task<CreateDependencyResponse> CreateDependencyAsync(CreateDependencyRequest createDependencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDependencyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateDependencyResponse>(response);
        }
        
        /// <summary>
        /// 创建测试事件
        /// </summary>
        public async Task<CreateEventResponse> CreateEventAsync(CreateEventRequest createEventRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , createEventRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/events",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createEventRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateEventResponse>(response);
        }
        
        /// <summary>
        /// 创建函数。
        /// </summary>
        public async Task<CreateFunctionResponse> CreateFunctionAsync(CreateFunctionRequest createFunctionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFunctionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateFunctionResponse>(response);
        }
        
        /// <summary>
        /// 发布函数版本。
        /// </summary>
        public async Task<CreateFunctionVersionResponse> CreateFunctionVersionAsync(CreateFunctionVersionRequest createFunctionVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , createFunctionVersionRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/versions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFunctionVersionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateFunctionVersionResponse>(response);
        }
        
        /// <summary>
        /// 创建函数版本别名。
        /// </summary>
        public async Task<CreateVersionAliasResponse> CreateVersionAliasAsync(CreateVersionAliasRequest createVersionAliasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , createVersionAliasRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/aliases",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVersionAliasRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateVersionAliasResponse>(response);
        }
        
        /// <summary>
        /// 删除依赖包
        /// </summary>
        public async Task<DeleteDependencyResponse> DeleteDependencyAsync(DeleteDependencyRequest deleteDependencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("depend_id" , deleteDependencyRequest.DependId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies/{depend_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDependencyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteDependencyResponse>(response);
        }
        
        /// <summary>
        /// 删除测试事件
        /// </summary>
        public async Task<DeleteEventResponse> DeleteEventAsync(DeleteEventRequest deleteEventRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("event_id" , deleteEventRequest.EventId.ToString());
            urlParam.Add("function_urn" , deleteEventRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/events/{event_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteEventRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteEventResponse>(response);
        }
        
        /// <summary>
        /// 删除函数/版本。
        /// </summary>
        public async Task<DeleteFunctionResponse> DeleteFunctionAsync(DeleteFunctionRequest deleteFunctionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , deleteFunctionRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFunctionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteFunctionResponse>(response);
        }
        
        /// <summary>
        /// 删除函数异步配置信息。
        /// </summary>
        public async Task<DeleteFunctionAsyncInvokeConfigResponse> DeleteFunctionAsyncInvokeConfigAsync(DeleteFunctionAsyncInvokeConfigRequest deleteFunctionAsyncInvokeConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , deleteFunctionAsyncInvokeConfigRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/async-invoke-config",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFunctionAsyncInvokeConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteFunctionAsyncInvokeConfigResponse>(response);
        }
        
        /// <summary>
        /// 删除函数版本别名。
        /// </summary>
        public async Task<DeleteVersionAliasResponse> DeleteVersionAliasAsync(DeleteVersionAliasRequest deleteVersionAliasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , deleteVersionAliasRequest.FunctionUrn.ToString());
            urlParam.Add("alias_name" , deleteVersionAliasRequest.AliasName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/aliases/{alias_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVersionAliasRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteVersionAliasResponse>(response);
        }
        
        /// <summary>
        /// 开通lts日志上报功能。
        /// </summary>
        public async Task<EnableLtsLogsResponse> EnableLtsLogsAsync(EnableLtsLogsRequest enableLtsLogsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/enable-lts-logs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableLtsLogsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<EnableLtsLogsResponse>(response);
        }
        
        /// <summary>
        /// 导出函数。
        /// </summary>
        public async Task<ExportFunctionResponse> ExportFunctionAsync(ExportFunctionRequest exportFunctionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , exportFunctionRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/export",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportFunctionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerializeNull<ExportFunctionResponse>(response);
        }
        
        /// <summary>
        /// 导入函数。
        /// </summary>
        public async Task<ImportFunctionResponse> ImportFunctionAsync(ImportFunctionRequest importFunctionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/import",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", importFunctionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ImportFunctionResponse>(response);
        }
        
        /// <summary>
        /// 同步执行函数。
        /// </summary>
        public async Task<InvokeFunctionResponse> InvokeFunctionAsync(InvokeFunctionRequest invokeFunctionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , invokeFunctionRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/invocations",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", invokeFunctionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<InvokeFunctionResponse>(response);
        }
        
        /// <summary>
        /// 获取依赖包列表
        /// </summary>
        public async Task<ListDependenciesResponse> ListDependenciesAsync(ListDependenciesRequest listDependenciesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDependenciesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListDependenciesResponse>(response);
        }
        
        /// <summary>
        /// 获取测试事件列表
        /// </summary>
        public async Task<ListEventsResponse> ListEventsAsync(ListEventsRequest listEventsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , listEventsRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/events",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listEventsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListEventsResponse>(response);
        }
        
        /// <summary>
        /// 获取函数异步配置列表
        /// </summary>
        public async Task<ListFunctionAsyncInvokeConfigResponse> ListFunctionAsyncInvokeConfigAsync(ListFunctionAsyncInvokeConfigRequest listFunctionAsyncInvokeConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , listFunctionAsyncInvokeConfigRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/async-invoke-configs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionAsyncInvokeConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListFunctionAsyncInvokeConfigResponse>(response);
        }
        
        /// <summary>
        /// 获取指定时间段的函数运行指标
        /// </summary>
        public async Task<ListFunctionStatisticsResponse> ListFunctionStatisticsAsync(ListFunctionStatisticsRequest listFunctionStatisticsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("func_urn" , listFunctionStatisticsRequest.FuncUrn.ToString());
            urlParam.Add("period" , listFunctionStatisticsRequest.Period.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{func_urn}/statistics/{period}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionStatisticsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListFunctionStatisticsResponse>(response);
        }
        
        /// <summary>
        /// 获取指定函数的版本列表。
        /// </summary>
        public async Task<ListFunctionVersionsResponse> ListFunctionVersionsAsync(ListFunctionVersionsRequest listFunctionVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , listFunctionVersionsRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/versions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionVersionsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListFunctionVersionsResponse>(response);
        }
        
        /// <summary>
        /// 获取函数列表
        /// </summary>
        public async Task<ListFunctionsResponse> ListFunctionsAsync(ListFunctionsRequest listFunctionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListFunctionsResponse>(response);
        }
        
        /// <summary>
        /// 查询租户配额
        /// </summary>
        public async Task<ListQuotasResponse> ListQuotasAsync(ListQuotasRequest listQuotasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotasRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListQuotasResponse>(response);
        }
        
        /// <summary>
        /// 租户函数统计信息
        /// </summary>
        public async Task<ListStatisticsResponse> ListStatisticsAsync(ListStatisticsRequest listStatisticsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/statistics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStatisticsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListStatisticsResponse>(response);
        }
        
        /// <summary>
        /// 获取指定函数所有版本别名列表。
        /// </summary>
        public async Task<ListVersionAliasesResponse> ListVersionAliasesAsync(ListVersionAliasesRequest listVersionAliasesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , listVersionAliasesRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/aliases",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionAliasesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            ListVersionAliasesResponse listVersionAliasesResponse = JsonUtils.DeSerializeNull<ListVersionAliasesResponse>(response);
            listVersionAliasesResponse.Body = JsonUtils.DeSerializeList<ListVersionAliasResult>(response);
            return listVersionAliasesResponse;
        }
        
        /// <summary>
        /// 获取指定依赖包
        /// </summary>
        public async Task<ShowDependencyResponse> ShowDependencyAsync(ShowDependencyRequest showDependencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("depend_id" , showDependencyRequest.DependId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies/{depend_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDependencyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDependencyResponse>(response);
        }
        
        /// <summary>
        /// 获取测试事件详细信息
        /// </summary>
        public async Task<ShowEventResponse> ShowEventAsync(ShowEventRequest showEventRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("event_id" , showEventRequest.EventId.ToString());
            urlParam.Add("function_urn" , showEventRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/events/{event_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showEventRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowEventResponse>(response);
        }
        
        /// <summary>
        /// 获取函数异步配置信息。
        /// </summary>
        public async Task<ShowFunctionAsyncInvokeConfigResponse> ShowFunctionAsyncInvokeConfigAsync(ShowFunctionAsyncInvokeConfigRequest showFunctionAsyncInvokeConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , showFunctionAsyncInvokeConfigRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/async-invoke-config",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFunctionAsyncInvokeConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowFunctionAsyncInvokeConfigResponse>(response);
        }
        
        /// <summary>
        /// 获取指定函数代码。
        /// </summary>
        public async Task<ShowFunctionCodeResponse> ShowFunctionCodeAsync(ShowFunctionCodeRequest showFunctionCodeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , showFunctionCodeRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/code",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFunctionCodeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowFunctionCodeResponse>(response);
        }
        
        /// <summary>
        /// 获取函数的metadata。
        /// </summary>
        public async Task<ShowFunctionConfigResponse> ShowFunctionConfigAsync(ShowFunctionConfigRequest showFunctionConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , showFunctionConfigRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/config",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFunctionConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowFunctionConfigResponse>(response);
        }
        
        /// <summary>
        /// 获取指定函数的lts日志组日志流配置。
        /// </summary>
        public async Task<ShowLtsLogDetailsResponse> ShowLtsLogDetailsAsync(ShowLtsLogDetailsRequest showLtsLogDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , showLtsLogDetailsRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/lts-log-detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLtsLogDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowLtsLogDetailsResponse>(response);
        }
        
        /// <summary>
        /// 获取函数调用链配置
        /// </summary>
        public async Task<ShowTracingResponse> ShowTracingAsync(ShowTracingRequest showTracingRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , showTracingRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/tracing",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTracingRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowTracingResponse>(response);
        }
        
        /// <summary>
        /// 获取函数版本的指定别名信息。
        /// </summary>
        public async Task<ShowVersionAliasResponse> ShowVersionAliasAsync(ShowVersionAliasRequest showVersionAliasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , showVersionAliasRequest.FunctionUrn.ToString());
            urlParam.Add("alias_name" , showVersionAliasRequest.AliasName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/aliases/{alias_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionAliasRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowVersionAliasResponse>(response);
        }
        
        /// <summary>
        /// 更新依赖包指定依赖包
        /// </summary>
        public async Task<UpdateDependencyResponse> UpdateDependencyAsync(UpdateDependencyRequest updateDependencyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("depend_id" , updateDependencyRequest.DependId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/dependencies/{depend_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDependencyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDependencyResponse>(response);
        }
        
        /// <summary>
        /// 更新测试事件
        /// </summary>
        public async Task<UpdateEventResponse> UpdateEventAsync(UpdateEventRequest updateEventRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("event_id" , updateEventRequest.EventId.ToString());
            urlParam.Add("function_urn" , updateEventRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/events/{event_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateEventRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateEventResponse>(response);
        }
        
        /// <summary>
        /// 设置函数异步配置信息。
        /// </summary>
        public async Task<UpdateFunctionAsyncInvokeConfigResponse> UpdateFunctionAsyncInvokeConfigAsync(UpdateFunctionAsyncInvokeConfigRequest updateFunctionAsyncInvokeConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , updateFunctionAsyncInvokeConfigRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/async-invoke-config",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFunctionAsyncInvokeConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateFunctionAsyncInvokeConfigResponse>(response);
        }
        
        /// <summary>
        /// 修改函数代码。
        /// </summary>
        public async Task<UpdateFunctionCodeResponse> UpdateFunctionCodeAsync(UpdateFunctionCodeRequest updateFunctionCodeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , updateFunctionCodeRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/code",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFunctionCodeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateFunctionCodeResponse>(response);
        }
        
        /// <summary>
        /// 修改函数的metadata信息。
        /// </summary>
        public async Task<UpdateFunctionConfigResponse> UpdateFunctionConfigAsync(UpdateFunctionConfigRequest updateFunctionConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , updateFunctionConfigRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/config",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFunctionConfigRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateFunctionConfigResponse>(response);
        }
        
        /// <summary>
        /// 更新函数预留实例个数
        /// </summary>
        public async Task<UpdateFunctionReservedInstancesResponse> UpdateFunctionReservedInstancesAsync(UpdateFunctionReservedInstancesRequest updateFunctionReservedInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , updateFunctionReservedInstancesRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/reservedinstances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFunctionReservedInstancesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateFunctionReservedInstancesResponse>(response);
        }
        
        /// <summary>
        /// 修改函数调用链配置
        /// </summary>
        public async Task<UpdateTracingResponse> UpdateTracingAsync(UpdateTracingRequest updateTracingRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , updateTracingRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/tracing",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTracingRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateTracingResponse>(response);
        }
        
        /// <summary>
        /// 修改函数版本别名信息。
        /// </summary>
        public async Task<UpdateVersionAliasResponse> UpdateVersionAliasAsync(UpdateVersionAliasRequest updateVersionAliasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , updateVersionAliasRequest.FunctionUrn.ToString());
            urlParam.Add("alias_name" , updateVersionAliasRequest.AliasName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/functions/{function_urn}/aliases/{alias_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateVersionAliasRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateVersionAliasResponse>(response);
        }
        
        /// <summary>
        /// 删除指定函数的所有触发器。
        /// </summary>
        public async Task<BatchDeleteFunctionTriggersResponse> BatchDeleteFunctionTriggersAsync(BatchDeleteFunctionTriggersRequest batchDeleteFunctionTriggersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , batchDeleteFunctionTriggersRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteFunctionTriggersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<BatchDeleteFunctionTriggersResponse>(response);
        }
        
        /// <summary>
        /// 创建触发器。
        /// </summary>
        public async Task<CreateFunctionTriggerResponse> CreateFunctionTriggerAsync(CreateFunctionTriggerRequest createFunctionTriggerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , createFunctionTriggerRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createFunctionTriggerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateFunctionTriggerResponse>(response);
        }
        
        /// <summary>
        /// 删除触发器。
        /// </summary>
        public async Task<DeleteFunctionTriggerResponse> DeleteFunctionTriggerAsync(DeleteFunctionTriggerRequest deleteFunctionTriggerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , deleteFunctionTriggerRequest.FunctionUrn.ToString());
            urlParam.Add("trigger_type_code" , deleteFunctionTriggerRequest.TriggerTypeCode.ToString());
            urlParam.Add("trigger_id" , deleteFunctionTriggerRequest.TriggerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}/{trigger_type_code}/{trigger_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFunctionTriggerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteFunctionTriggerResponse>(response);
        }
        
        /// <summary>
        /// 获取指定函数的所有触发器。
        /// </summary>
        public async Task<ListFunctionTriggersResponse> ListFunctionTriggersAsync(ListFunctionTriggersRequest listFunctionTriggersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , listFunctionTriggersRequest.FunctionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFunctionTriggersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            ListFunctionTriggersResponse listFunctionTriggersResponse = JsonUtils.DeSerializeNull<ListFunctionTriggersResponse>(response);
            listFunctionTriggersResponse.Body = JsonUtils.DeSerializeList<ListFunctionTriggerResult>(response);
            return listFunctionTriggersResponse;
        }
        
        /// <summary>
        /// 获取指定触发器的信息。
        /// </summary>
        public async Task<ShowFunctionTriggerResponse> ShowFunctionTriggerAsync(ShowFunctionTriggerRequest showFunctionTriggerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , showFunctionTriggerRequest.FunctionUrn.ToString());
            urlParam.Add("trigger_type_code" , showFunctionTriggerRequest.TriggerTypeCode.ToString());
            urlParam.Add("trigger_id" , showFunctionTriggerRequest.TriggerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}/{trigger_type_code}/{trigger_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFunctionTriggerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowFunctionTriggerResponse>(response);
        }
        
        /// <summary>
        /// 更新触发器
        /// </summary>
        public async Task<UpdateTriggerResponse> UpdateTriggerAsync(UpdateTriggerRequest updateTriggerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("function_urn" , updateTriggerRequest.FunctionUrn.ToString());
            urlParam.Add("trigger_type_code" , updateTriggerRequest.TriggerTypeCode.ToString());
            urlParam.Add("trigger_id" , updateTriggerRequest.TriggerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/fgs/triggers/{function_urn}/{trigger_type_code}/{trigger_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTriggerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateTriggerResponse>(response);
        }
        
    }
}