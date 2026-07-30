using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Tms.V1.Model;

namespace HuaweiCloud.SDK.Tms.V1
{
    public partial class TmsAsyncClient : Client
    {
        public static ClientBuilder<TmsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<TmsAsyncClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 开通或关闭关联资源标签继承能力
        ///
        /// 开通或关闭关联资源标签继承能力
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ChangeAssociatedResourceOpenStatusResponse> ChangeAssociatedResourceOpenStatusAsync(ChangeAssociatedResourceOpenStatusRequest changeAssociatedResourceOpenStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/tms/associated-resources/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeAssociatedResourceOpenStatusRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ChangeAssociatedResourceOpenStatusResponse>(response);
        }

        public AsyncInvoker<ChangeAssociatedResourceOpenStatusResponse> ChangeAssociatedResourceOpenStatusAsyncInvoker(ChangeAssociatedResourceOpenStatusRequest changeAssociatedResourceOpenStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/tms/associated-resources/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeAssociatedResourceOpenStatusRequest);
            return new AsyncInvoker<ChangeAssociatedResourceOpenStatusResponse>(this, "PUT", request, JsonUtils.DeSerialize<ChangeAssociatedResourceOpenStatusResponse>);
        }
        
        /// <summary>
        /// 批量启用规则
        ///
        /// 按照规则和region来批量启用规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAssociatedResourceRulesResponse> CreateAssociatedResourceRulesAsync(CreateAssociatedResourceRulesRequest createAssociatedResourceRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/tms/associated-resources/rules/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAssociatedResourceRulesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAssociatedResourceRulesResponse>(response);
        }

        public AsyncInvoker<CreateAssociatedResourceRulesResponse> CreateAssociatedResourceRulesAsyncInvoker(CreateAssociatedResourceRulesRequest createAssociatedResourceRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/tms/associated-resources/rules/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAssociatedResourceRulesRequest);
            return new AsyncInvoker<CreateAssociatedResourceRulesResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAssociatedResourceRulesResponse>);
        }
        
        /// <summary>
        /// 创建预定义标签
        ///
        /// 用于创建预定标签。用户创建预定义标签后，可以使用预定义标签来给资源创建标签。该接口支持幂等特性和处理批量数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePredefineTagsResponse> CreatePredefineTagsAsync(CreatePredefineTagsRequest createPredefineTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/predefine_tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPredefineTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreatePredefineTagsResponse>(response);
        }

        public AsyncInvoker<CreatePredefineTagsResponse> CreatePredefineTagsAsyncInvoker(CreatePredefineTagsRequest createPredefineTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/predefine_tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPredefineTagsRequest);
            return new AsyncInvoker<CreatePredefineTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreatePredefineTagsResponse>);
        }
        
        /// <summary>
        /// 批量添加标签
        ///
        /// 用于给云服务的多个资源添加标签，每个资源最多可添加10个标签，每次最多支持批量操作20个资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateResourceTagResponse> CreateResourceTagAsync(CreateResourceTagRequest createResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/resource-tags/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createResourceTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateResourceTagResponse>(response);
        }

        public AsyncInvoker<CreateResourceTagResponse> CreateResourceTagAsyncInvoker(CreateResourceTagRequest createResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/resource-tags/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createResourceTagRequest);
            return new AsyncInvoker<CreateResourceTagResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateResourceTagResponse>);
        }
        
        /// <summary>
        /// 关闭规则
        ///
        /// 通过指定setting_name和region_id来关闭指定的规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteAssociatedResourceRuleResponse> DeleteAssociatedResourceRuleAsync(DeleteAssociatedResourceRuleRequest deleteAssociatedResourceRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAssociatedResourceRuleRequest.SettingName, out var valueOfSettingName)) urlParam.Add("setting_name", valueOfSettingName);
            var urlPath = HttpUtils.AddUrlPath("/v2/tms/associated-resources/rules/{setting_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAssociatedResourceRuleRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAssociatedResourceRuleResponse>(response);
        }

        public AsyncInvoker<DeleteAssociatedResourceRuleResponse> DeleteAssociatedResourceRuleAsyncInvoker(DeleteAssociatedResourceRuleRequest deleteAssociatedResourceRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAssociatedResourceRuleRequest.SettingName, out var valueOfSettingName)) urlParam.Add("setting_name", valueOfSettingName);
            var urlPath = HttpUtils.AddUrlPath("/v2/tms/associated-resources/rules/{setting_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAssociatedResourceRuleRequest);
            return new AsyncInvoker<DeleteAssociatedResourceRuleResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAssociatedResourceRuleResponse>);
        }
        
        /// <summary>
        /// 删除预定义标签
        ///
        /// 用于删除预定标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePredefineTagsResponse> DeletePredefineTagsAsync(DeletePredefineTagsRequest deletePredefineTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/predefine_tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deletePredefineTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<DeletePredefineTagsResponse>(response);
        }

        public AsyncInvoker<DeletePredefineTagsResponse> DeletePredefineTagsAsyncInvoker(DeletePredefineTagsRequest deletePredefineTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/predefine_tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deletePredefineTagsRequest);
            return new AsyncInvoker<DeletePredefineTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeletePredefineTagsResponse>);
        }
        
        /// <summary>
        /// 批量移除标签
        ///
        /// 用于批量移除云服务多个资源的标签，每个资源最多支持移除10个标签，每次最多支持批量操作20个资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteResourceTagResponse> DeleteResourceTagAsync(DeleteResourceTagRequest deleteResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/resource-tags/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteResourceTagRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<DeleteResourceTagResponse>(response);
        }

        public AsyncInvoker<DeleteResourceTagResponse> DeleteResourceTagAsyncInvoker(DeleteResourceTagRequest deleteResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/resource-tags/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteResourceTagRequest);
            return new AsyncInvoker<DeleteResourceTagResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteResourceTagResponse>);
        }
        
        /// <summary>
        /// 查询API版本列表
        ///
        /// 查询标签管理服务的API版本列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListApiVersionsResponse> ListApiVersionsAsync(ListApiVersionsRequest listApiVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListApiVersionsResponse>(response);
        }

        public AsyncInvoker<ListApiVersionsResponse> ListApiVersionsAsyncInvoker(ListApiVersionsRequest listApiVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionsRequest);
            return new AsyncInvoker<ListApiVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApiVersionsResponse>);
        }
        
        /// <summary>
        /// 查询当前规则列表
        ///
        /// 查询当前规则列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAssociatedResourceRulesResponse> ListAssociatedResourceRulesAsync(ListAssociatedResourceRulesRequest listAssociatedResourceRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/tms/associated-resources/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssociatedResourceRulesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAssociatedResourceRulesResponse>(response);
        }

        public AsyncInvoker<ListAssociatedResourceRulesResponse> ListAssociatedResourceRulesAsyncInvoker(ListAssociatedResourceRulesRequest listAssociatedResourceRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/tms/associated-resources/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssociatedResourceRulesRequest);
            return new AsyncInvoker<ListAssociatedResourceRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAssociatedResourceRulesResponse>);
        }
        
        /// <summary>
        /// 查询当前规则的配置列表
        ///
        /// 查询当前规则的配置列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAssociatedResourceSettingsResponse> ListAssociatedResourceSettingsAsync(ListAssociatedResourceSettingsRequest listAssociatedResourceSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/tms/associated-resources/settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssociatedResourceSettingsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAssociatedResourceSettingsResponse>(response);
        }

        public AsyncInvoker<ListAssociatedResourceSettingsResponse> ListAssociatedResourceSettingsAsyncInvoker(ListAssociatedResourceSettingsRequest listAssociatedResourceSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/tms/associated-resources/settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssociatedResourceSettingsRequest);
            return new AsyncInvoker<ListAssociatedResourceSettingsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAssociatedResourceSettingsResponse>);
        }
        
        /// <summary>
        /// 查询预定义标签列表
        ///
        /// 用于查询预定义标签列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPredefineTagsResponse> ListPredefineTagsAsync(ListPredefineTagsRequest listPredefineTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/predefine_tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPredefineTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPredefineTagsResponse>(response);
        }

        public AsyncInvoker<ListPredefineTagsResponse> ListPredefineTagsAsyncInvoker(ListPredefineTagsRequest listPredefineTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/predefine_tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPredefineTagsRequest);
            return new AsyncInvoker<ListPredefineTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPredefineTagsResponse>);
        }
        
        /// <summary>
        /// 查询标签管理支持的服务
        ///
        /// 查询标签管理支持的服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProvidersResponse> ListProvidersAsync(ListProvidersRequest listProvidersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/tms/providers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProvidersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListProvidersResponse>(response);
        }

        public AsyncInvoker<ListProvidersResponse> ListProvidersAsyncInvoker(ListProvidersRequest listProvidersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/tms/providers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProvidersRequest);
            return new AsyncInvoker<ListProvidersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProvidersResponse>);
        }
        
        /// <summary>
        /// 根据标签过滤资源
        ///
        /// 根据标签过滤资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListResourceResponse> ListResourceAsync(ListResourceRequest listResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listResourceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListResourceResponse>(response);
        }

        public AsyncInvoker<ListResourceResponse> ListResourceAsyncInvoker(ListResourceRequest listResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listResourceRequest);
            return new AsyncInvoker<ListResourceResponse>(this, "POST", request, JsonUtils.DeSerialize<ListResourceResponse>);
        }
        
        /// <summary>
        /// 查询标签键列表
        ///
        /// 查询指定区域的所有标签键.
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTagKeysResponse> ListTagKeysAsync(ListTagKeysRequest listTagKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/tag-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagKeysRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTagKeysResponse>(response);
        }

        public AsyncInvoker<ListTagKeysResponse> ListTagKeysAsyncInvoker(ListTagKeysRequest listTagKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/tag-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagKeysRequest);
            return new AsyncInvoker<ListTagKeysResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTagKeysResponse>);
        }
        
        /// <summary>
        /// 查询标签值列表
        ///
        /// 查询指定区域的标签键下的所有标签值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTagValuesResponse> ListTagValuesAsync(ListTagValuesRequest listTagValuesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/tag-values", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagValuesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTagValuesResponse>(response);
        }

        public AsyncInvoker<ListTagValuesResponse> ListTagValuesAsyncInvoker(ListTagValuesRequest listTagValuesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/tag-values", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagValuesRequest);
            return new AsyncInvoker<ListTagValuesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTagValuesResponse>);
        }
        
        /// <summary>
        /// 查询标签列表
        ///
        /// 查询指定区域和实例类型中租户的所有标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTagsResponse> ListTagsAsync(ListTagsRequest listTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTagsResponse>(response);
        }

        public AsyncInvoker<ListTagsResponse> ListTagsAsyncInvoker(ListTagsRequest listTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsRequest);
            return new AsyncInvoker<ListTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTagsResponse>);
        }
        
        /// <summary>
        /// 查询API版本号详情
        ///
        /// 查询指定的标签管理服务API版本号详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowApiVersionResponse> ShowApiVersionAsync(ShowApiVersionRequest showApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showApiVersionRequest.ApiVersion, out var valueOfApiVersion)) urlParam.Add("api_version", valueOfApiVersion);
            var urlPath = HttpUtils.AddUrlPath("/{api_version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowApiVersionResponse>(response);
        }

        public AsyncInvoker<ShowApiVersionResponse> ShowApiVersionAsyncInvoker(ShowApiVersionRequest showApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showApiVersionRequest.ApiVersion, out var valueOfApiVersion)) urlParam.Add("api_version", valueOfApiVersion);
            var urlPath = HttpUtils.AddUrlPath("/{api_version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            return new AsyncInvoker<ShowApiVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowApiVersionResponse>);
        }
        
        /// <summary>
        /// 查询当前用户的关联资源标签继承能力的开通状态
        ///
        /// 查询当前用户的关联资源标签继承能力的开通状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAssociatedResourceOpenStatusResponse> ShowAssociatedResourceOpenStatusAsync(ShowAssociatedResourceOpenStatusRequest showAssociatedResourceOpenStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/tms/associated-resources/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssociatedResourceOpenStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAssociatedResourceOpenStatusResponse>(response);
        }

        public AsyncInvoker<ShowAssociatedResourceOpenStatusResponse> ShowAssociatedResourceOpenStatusAsyncInvoker(ShowAssociatedResourceOpenStatusRequest showAssociatedResourceOpenStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/tms/associated-resources/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssociatedResourceOpenStatusRequest);
            return new AsyncInvoker<ShowAssociatedResourceOpenStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAssociatedResourceOpenStatusResponse>);
        }
        
        /// <summary>
        /// 查询资源标签
        ///
        /// 查询单个资源上的标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowResourceTagResponse> ShowResourceTagAsync(ShowResourceTagRequest showResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/resources/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceTagRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowResourceTagResponse>(response);
        }

        public AsyncInvoker<ShowResourceTagResponse> ShowResourceTagAsyncInvoker(ShowResourceTagRequest showResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/resources/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceTagRequest);
            return new AsyncInvoker<ShowResourceTagResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceTagResponse>);
        }
        
        /// <summary>
        /// 查询标签配额
        ///
        /// 查询标签的配额信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTagQuotaResponse> ShowTagQuotaAsync(ShowTagQuotaRequest showTagQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/tms/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTagQuotaRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTagQuotaResponse>(response);
        }

        public AsyncInvoker<ShowTagQuotaResponse> ShowTagQuotaAsyncInvoker(ShowTagQuotaRequest showTagQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/tms/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTagQuotaRequest);
            return new AsyncInvoker<ShowTagQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTagQuotaResponse>);
        }
        
        /// <summary>
        /// 更新规则
        ///
        /// 更新规则。规则更新的信息会覆盖原有内容
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateAssociatedResourceRulesResponse> UpdateAssociatedResourceRulesAsync(UpdateAssociatedResourceRulesRequest updateAssociatedResourceRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/tms/associated-resources/rules/batch-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAssociatedResourceRulesRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAssociatedResourceRulesResponse>(response);
        }

        public AsyncInvoker<UpdateAssociatedResourceRulesResponse> UpdateAssociatedResourceRulesAsyncInvoker(UpdateAssociatedResourceRulesRequest updateAssociatedResourceRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/tms/associated-resources/rules/batch-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAssociatedResourceRulesRequest);
            return new AsyncInvoker<UpdateAssociatedResourceRulesResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAssociatedResourceRulesResponse>);
        }
        
        /// <summary>
        /// 修改预定义标签
        ///
        /// 修改预定义标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePredefineTagsResponse> UpdatePredefineTagsAsync(UpdatePredefineTagsRequest updatePredefineTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/predefine_tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePredefineTagsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdatePredefineTagsResponse>(response);
        }

        public AsyncInvoker<UpdatePredefineTagsResponse> UpdatePredefineTagsAsyncInvoker(UpdatePredefineTagsRequest updatePredefineTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/predefine_tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePredefineTagsRequest);
            return new AsyncInvoker<UpdatePredefineTagsResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdatePredefineTagsResponse>);
        }
        
    }
}