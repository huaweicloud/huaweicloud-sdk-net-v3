using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Tms.V1.Model;

namespace HuaweiCloud.SDK.Tms.V1
{
    public partial class TmsClient : Client
    {
        public static ClientBuilder<TmsClient> NewBuilder()
        {
            return new ClientBuilder<TmsClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 开通或关闭关联资源标签继承能力
        ///
        /// 开通或关闭关联资源标签继承能力
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ChangeAssociatedResourceOpenStatusResponse ChangeAssociatedResourceOpenStatus(ChangeAssociatedResourceOpenStatusRequest changeAssociatedResourceOpenStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/tms/associated-resources/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeAssociatedResourceOpenStatusRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ChangeAssociatedResourceOpenStatusResponse>(response);
        }

        public SyncInvoker<ChangeAssociatedResourceOpenStatusResponse> ChangeAssociatedResourceOpenStatusInvoker(ChangeAssociatedResourceOpenStatusRequest changeAssociatedResourceOpenStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/tms/associated-resources/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeAssociatedResourceOpenStatusRequest);
            return new SyncInvoker<ChangeAssociatedResourceOpenStatusResponse>(this, "PUT", request, JsonUtils.DeSerialize<ChangeAssociatedResourceOpenStatusResponse>);
        }
        
        /// <summary>
        /// 批量启用规则
        ///
        /// 按照规则和region来批量启用规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateAssociatedResourceRulesResponse CreateAssociatedResourceRules(CreateAssociatedResourceRulesRequest createAssociatedResourceRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/tms/associated-resources/rules/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAssociatedResourceRulesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateAssociatedResourceRulesResponse>(response);
        }

        public SyncInvoker<CreateAssociatedResourceRulesResponse> CreateAssociatedResourceRulesInvoker(CreateAssociatedResourceRulesRequest createAssociatedResourceRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/tms/associated-resources/rules/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createAssociatedResourceRulesRequest);
            return new SyncInvoker<CreateAssociatedResourceRulesResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAssociatedResourceRulesResponse>);
        }
        
        /// <summary>
        /// 创建预定义标签
        ///
        /// 用于创建预定标签。用户创建预定义标签后，可以使用预定义标签来给资源创建标签。该接口支持幂等特性和处理批量数据。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePredefineTagsResponse CreatePredefineTags(CreatePredefineTagsRequest createPredefineTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/predefine_tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPredefineTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreatePredefineTagsResponse>(response);
        }

        public SyncInvoker<CreatePredefineTagsResponse> CreatePredefineTagsInvoker(CreatePredefineTagsRequest createPredefineTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/predefine_tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPredefineTagsRequest);
            return new SyncInvoker<CreatePredefineTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreatePredefineTagsResponse>);
        }
        
        /// <summary>
        /// 批量添加标签
        ///
        /// 用于给云服务的多个资源添加标签，每个资源最多可添加10个标签，每次最多支持批量操作20个资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateResourceTagResponse CreateResourceTag(CreateResourceTagRequest createResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/resource-tags/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createResourceTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateResourceTagResponse>(response);
        }

        public SyncInvoker<CreateResourceTagResponse> CreateResourceTagInvoker(CreateResourceTagRequest createResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/resource-tags/batch-create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createResourceTagRequest);
            return new SyncInvoker<CreateResourceTagResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateResourceTagResponse>);
        }
        
        /// <summary>
        /// 关闭规则
        ///
        /// 通过指定setting_name和region_id来关闭指定的规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteAssociatedResourceRuleResponse DeleteAssociatedResourceRule(DeleteAssociatedResourceRuleRequest deleteAssociatedResourceRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAssociatedResourceRuleRequest.SettingName, out var valueOfSettingName)) urlParam.Add("setting_name", valueOfSettingName);
            var urlPath = HttpUtils.AddUrlPath("/v2/tms/associated-resources/rules/{setting_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAssociatedResourceRuleRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteAssociatedResourceRuleResponse>(response);
        }

        public SyncInvoker<DeleteAssociatedResourceRuleResponse> DeleteAssociatedResourceRuleInvoker(DeleteAssociatedResourceRuleRequest deleteAssociatedResourceRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteAssociatedResourceRuleRequest.SettingName, out var valueOfSettingName)) urlParam.Add("setting_name", valueOfSettingName);
            var urlPath = HttpUtils.AddUrlPath("/v2/tms/associated-resources/rules/{setting_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAssociatedResourceRuleRequest);
            return new SyncInvoker<DeleteAssociatedResourceRuleResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteAssociatedResourceRuleResponse>);
        }
        
        /// <summary>
        /// 删除预定义标签
        ///
        /// 用于删除预定标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePredefineTagsResponse DeletePredefineTags(DeletePredefineTagsRequest deletePredefineTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/predefine_tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deletePredefineTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<DeletePredefineTagsResponse>(response);
        }

        public SyncInvoker<DeletePredefineTagsResponse> DeletePredefineTagsInvoker(DeletePredefineTagsRequest deletePredefineTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/predefine_tags/action", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deletePredefineTagsRequest);
            return new SyncInvoker<DeletePredefineTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<DeletePredefineTagsResponse>);
        }
        
        /// <summary>
        /// 批量移除标签
        ///
        /// 用于批量移除云服务多个资源的标签，每个资源最多支持移除10个标签，每次最多支持批量操作20个资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteResourceTagResponse DeleteResourceTag(DeleteResourceTagRequest deleteResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/resource-tags/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteResourceTagRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<DeleteResourceTagResponse>(response);
        }

        public SyncInvoker<DeleteResourceTagResponse> DeleteResourceTagInvoker(DeleteResourceTagRequest deleteResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/resource-tags/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", deleteResourceTagRequest);
            return new SyncInvoker<DeleteResourceTagResponse>(this, "POST", request, JsonUtils.DeSerialize<DeleteResourceTagResponse>);
        }
        
        /// <summary>
        /// 查询API版本列表
        ///
        /// 查询标签管理服务的API版本列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListApiVersionsResponse ListApiVersions(ListApiVersionsRequest listApiVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListApiVersionsResponse>(response);
        }

        public SyncInvoker<ListApiVersionsResponse> ListApiVersionsInvoker(ListApiVersionsRequest listApiVersionsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionsRequest);
            return new SyncInvoker<ListApiVersionsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListApiVersionsResponse>);
        }
        
        /// <summary>
        /// 查询当前规则列表
        ///
        /// 查询当前规则列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAssociatedResourceRulesResponse ListAssociatedResourceRules(ListAssociatedResourceRulesRequest listAssociatedResourceRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/tms/associated-resources/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssociatedResourceRulesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAssociatedResourceRulesResponse>(response);
        }

        public SyncInvoker<ListAssociatedResourceRulesResponse> ListAssociatedResourceRulesInvoker(ListAssociatedResourceRulesRequest listAssociatedResourceRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/tms/associated-resources/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssociatedResourceRulesRequest);
            return new SyncInvoker<ListAssociatedResourceRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAssociatedResourceRulesResponse>);
        }
        
        /// <summary>
        /// 查询当前规则的配置列表
        ///
        /// 查询当前规则的配置列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAssociatedResourceSettingsResponse ListAssociatedResourceSettings(ListAssociatedResourceSettingsRequest listAssociatedResourceSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/tms/associated-resources/settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssociatedResourceSettingsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListAssociatedResourceSettingsResponse>(response);
        }

        public SyncInvoker<ListAssociatedResourceSettingsResponse> ListAssociatedResourceSettingsInvoker(ListAssociatedResourceSettingsRequest listAssociatedResourceSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/tms/associated-resources/settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAssociatedResourceSettingsRequest);
            return new SyncInvoker<ListAssociatedResourceSettingsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAssociatedResourceSettingsResponse>);
        }
        
        /// <summary>
        /// 查询预定义标签列表
        ///
        /// 用于查询预定义标签列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPredefineTagsResponse ListPredefineTags(ListPredefineTagsRequest listPredefineTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/predefine_tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPredefineTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPredefineTagsResponse>(response);
        }

        public SyncInvoker<ListPredefineTagsResponse> ListPredefineTagsInvoker(ListPredefineTagsRequest listPredefineTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/predefine_tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPredefineTagsRequest);
            return new SyncInvoker<ListPredefineTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPredefineTagsResponse>);
        }
        
        /// <summary>
        /// 查询标签管理支持的服务
        ///
        /// 查询标签管理支持的服务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProvidersResponse ListProviders(ListProvidersRequest listProvidersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/tms/providers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProvidersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListProvidersResponse>(response);
        }

        public SyncInvoker<ListProvidersResponse> ListProvidersInvoker(ListProvidersRequest listProvidersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/tms/providers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProvidersRequest);
            return new SyncInvoker<ListProvidersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProvidersResponse>);
        }
        
        /// <summary>
        /// 根据标签过滤资源
        ///
        /// 根据标签过滤资源。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListResourceResponse ListResource(ListResourceRequest listResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listResourceRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListResourceResponse>(response);
        }

        public SyncInvoker<ListResourceResponse> ListResourceInvoker(ListResourceRequest listResourceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/resource-instances/filter", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listResourceRequest);
            return new SyncInvoker<ListResourceResponse>(this, "POST", request, JsonUtils.DeSerialize<ListResourceResponse>);
        }
        
        /// <summary>
        /// 查询标签键列表
        ///
        /// 查询指定区域的所有标签键.
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTagKeysResponse ListTagKeys(ListTagKeysRequest listTagKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/tag-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagKeysRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTagKeysResponse>(response);
        }

        public SyncInvoker<ListTagKeysResponse> ListTagKeysInvoker(ListTagKeysRequest listTagKeysRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/tag-keys", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagKeysRequest);
            return new SyncInvoker<ListTagKeysResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTagKeysResponse>);
        }
        
        /// <summary>
        /// 查询标签值列表
        ///
        /// 查询指定区域的标签键下的所有标签值。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTagValuesResponse ListTagValues(ListTagValuesRequest listTagValuesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/tag-values", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagValuesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTagValuesResponse>(response);
        }

        public SyncInvoker<ListTagValuesResponse> ListTagValuesInvoker(ListTagValuesRequest listTagValuesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/tag-values", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagValuesRequest);
            return new SyncInvoker<ListTagValuesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTagValuesResponse>);
        }
        
        /// <summary>
        /// 查询标签列表
        ///
        /// 查询指定区域和实例类型中租户的所有标签
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTagsResponse ListTags(ListTagsRequest listTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTagsResponse>(response);
        }

        public SyncInvoker<ListTagsResponse> ListTagsInvoker(ListTagsRequest listTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsRequest);
            return new SyncInvoker<ListTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTagsResponse>);
        }
        
        /// <summary>
        /// 查询API版本号详情
        ///
        /// 查询指定的标签管理服务API版本号详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowApiVersionResponse ShowApiVersion(ShowApiVersionRequest showApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showApiVersionRequest.ApiVersion, out var valueOfApiVersion)) urlParam.Add("api_version", valueOfApiVersion);
            var urlPath = HttpUtils.AddUrlPath("/{api_version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowApiVersionResponse>(response);
        }

        public SyncInvoker<ShowApiVersionResponse> ShowApiVersionInvoker(ShowApiVersionRequest showApiVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showApiVersionRequest.ApiVersion, out var valueOfApiVersion)) urlParam.Add("api_version", valueOfApiVersion);
            var urlPath = HttpUtils.AddUrlPath("/{api_version}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showApiVersionRequest);
            return new SyncInvoker<ShowApiVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowApiVersionResponse>);
        }
        
        /// <summary>
        /// 查询当前用户的关联资源标签继承能力的开通状态
        ///
        /// 查询当前用户的关联资源标签继承能力的开通状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAssociatedResourceOpenStatusResponse ShowAssociatedResourceOpenStatus(ShowAssociatedResourceOpenStatusRequest showAssociatedResourceOpenStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/tms/associated-resources/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssociatedResourceOpenStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAssociatedResourceOpenStatusResponse>(response);
        }

        public SyncInvoker<ShowAssociatedResourceOpenStatusResponse> ShowAssociatedResourceOpenStatusInvoker(ShowAssociatedResourceOpenStatusRequest showAssociatedResourceOpenStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/tms/associated-resources/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAssociatedResourceOpenStatusRequest);
            return new SyncInvoker<ShowAssociatedResourceOpenStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAssociatedResourceOpenStatusResponse>);
        }
        
        /// <summary>
        /// 查询资源标签
        ///
        /// 查询单个资源上的标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowResourceTagResponse ShowResourceTag(ShowResourceTagRequest showResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/resources/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceTagRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowResourceTagResponse>(response);
        }

        public SyncInvoker<ShowResourceTagResponse> ShowResourceTagInvoker(ShowResourceTagRequest showResourceTagRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showResourceTagRequest.ResourceId, out var valueOfResourceId)) urlParam.Add("resource_id", valueOfResourceId);
            var urlPath = HttpUtils.AddUrlPath("/v2.0/resources/{resource_id}/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResourceTagRequest);
            return new SyncInvoker<ShowResourceTagResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowResourceTagResponse>);
        }
        
        /// <summary>
        /// 查询标签配额
        ///
        /// 查询标签的配额信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTagQuotaResponse ShowTagQuota(ShowTagQuotaRequest showTagQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/tms/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTagQuotaRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTagQuotaResponse>(response);
        }

        public SyncInvoker<ShowTagQuotaResponse> ShowTagQuotaInvoker(ShowTagQuotaRequest showTagQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/tms/quotas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTagQuotaRequest);
            return new SyncInvoker<ShowTagQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTagQuotaResponse>);
        }
        
        /// <summary>
        /// 更新规则
        ///
        /// 更新规则。规则更新的信息会覆盖原有内容
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateAssociatedResourceRulesResponse UpdateAssociatedResourceRules(UpdateAssociatedResourceRulesRequest updateAssociatedResourceRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/tms/associated-resources/rules/batch-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAssociatedResourceRulesRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateAssociatedResourceRulesResponse>(response);
        }

        public SyncInvoker<UpdateAssociatedResourceRulesResponse> UpdateAssociatedResourceRulesInvoker(UpdateAssociatedResourceRulesRequest updateAssociatedResourceRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v2/tms/associated-resources/rules/batch-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateAssociatedResourceRulesRequest);
            return new SyncInvoker<UpdateAssociatedResourceRulesResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateAssociatedResourceRulesResponse>);
        }
        
        /// <summary>
        /// 修改预定义标签
        ///
        /// 修改预定义标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePredefineTagsResponse UpdatePredefineTags(UpdatePredefineTagsRequest updatePredefineTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/predefine_tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePredefineTagsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdatePredefineTagsResponse>(response);
        }

        public SyncInvoker<UpdatePredefineTagsResponse> UpdatePredefineTagsInvoker(UpdatePredefineTagsRequest updatePredefineTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/predefine_tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePredefineTagsRequest);
            return new SyncInvoker<UpdatePredefineTagsResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdatePredefineTagsResponse>);
        }
        
    }
}