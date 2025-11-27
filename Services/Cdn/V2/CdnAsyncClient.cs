using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Cdn.V2.Model;

namespace HuaweiCloud.SDK.Cdn.V2
{
    public partial class CdnAsyncClient : Client
    {
        public static ClientBuilder<CdnAsyncClient> NewBuilder()
        {
            return new ClientBuilder<CdnAsyncClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 应用域名模板。
        ///
        /// 应用域名模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ApplyDomainTemplateResponse> ApplyDomainTemplateAsync(ApplyDomainTemplateRequest applyDomainTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(applyDomainTemplateRequest.TmlId, out var valueOfTmlId)) urlParam.Add("tml_id", valueOfTmlId);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/templates/{tml_id}/apply", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyDomainTemplateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ApplyDomainTemplateResponse>(response);
        }

        public AsyncInvoker<ApplyDomainTemplateResponse> ApplyDomainTemplateAsyncInvoker(ApplyDomainTemplateRequest applyDomainTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(applyDomainTemplateRequest.TmlId, out var valueOfTmlId)) urlParam.Add("tml_id", valueOfTmlId);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/templates/{tml_id}/apply", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyDomainTemplateRequest);
            return new AsyncInvoker<ApplyDomainTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<ApplyDomainTemplateResponse>);
        }
        
        /// <summary>
        /// 批量域名复制
        ///
        /// 批量域名复制接口。
        ///  &gt; 将某个加速域名的配置批量复制到其他域名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchCopyDomainResponse> BatchCopyDomainAsync(BatchCopyDomainRequest batchCopyDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/batch-copy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCopyDomainRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<BatchCopyDomainResponse>(response);
        }

        public AsyncInvoker<BatchCopyDomainResponse> BatchCopyDomainAsyncInvoker(BatchCopyDomainRequest batchCopyDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/batch-copy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCopyDomainRequest);
            return new AsyncInvoker<BatchCopyDomainResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCopyDomainResponse>);
        }
        
        /// <summary>
        /// 删除资源标签配置接口
        ///
        /// 用于删除资源标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchDeleteTagsResponse> BatchDeleteTagsAsync(BatchDeleteTagsRequest batchDeleteTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/tags/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteTagsResponse>(response);
        }

        public AsyncInvoker<BatchDeleteTagsResponse> BatchDeleteTagsAsyncInvoker(BatchDeleteTagsRequest batchDeleteTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/tags/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteTagsRequest);
            return new AsyncInvoker<BatchDeleteTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteTagsResponse>);
        }
        
        /// <summary>
        /// 批量更新规则状态及优先级
        ///
        /// 批量更新规则状态及优先级。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchUpdateRuleStatusResponse> BatchUpdateRuleStatusAsync(BatchUpdateRuleStatusRequest batchUpdateRuleStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateRuleStatusRequest.DomainName, out var valueOfDomainName)) urlParam.Add("domain_name", valueOfDomainName);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/{domain_name}/rules/batch-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateRuleStatusRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<BatchUpdateRuleStatusResponse>(response);
        }

        public AsyncInvoker<BatchUpdateRuleStatusResponse> BatchUpdateRuleStatusAsyncInvoker(BatchUpdateRuleStatusRequest batchUpdateRuleStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchUpdateRuleStatusRequest.DomainName, out var valueOfDomainName)) urlParam.Add("domain_name", valueOfDomainName);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/{domain_name}/rules/batch-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateRuleStatusRequest);
            return new AsyncInvoker<BatchUpdateRuleStatusResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchUpdateRuleStatusResponse>);
        }
        
        /// <summary>
        /// 创建封禁/解禁URL任务
        ///
        /// 创建封禁/解禁URL任务，如需使用本接口，请提交工单申请。
        /// - 单租户调用频率：10次/s。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateAccessControlTaskResponse> CreateAccessControlTaskAsync(CreateAccessControlTaskRequest createAccessControlTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAccessControlTaskRequest.Action, out var valueOfAction)) urlParam.Add("action", valueOfAction);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/content/access-control-urls/{action}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAccessControlTaskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateAccessControlTaskResponse>(response);
        }

        public AsyncInvoker<CreateAccessControlTaskResponse> CreateAccessControlTaskAsyncInvoker(CreateAccessControlTaskRequest createAccessControlTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createAccessControlTaskRequest.Action, out var valueOfAction)) urlParam.Add("action", valueOfAction);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/content/access-control-urls/{action}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAccessControlTaskRequest);
            return new AsyncInvoker<CreateAccessControlTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateAccessControlTaskResponse>);
        }
        
        /// <summary>
        /// 创建加速域名
        ///
        /// 创建加速域名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest createDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDomainRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDomainResponse>(response);
        }

        public AsyncInvoker<CreateDomainResponse> CreateDomainAsyncInvoker(CreateDomainRequest createDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDomainRequest);
            return new AsyncInvoker<CreateDomainResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDomainResponse>);
        }
        
        /// <summary>
        /// 复制配置到新添加域名
        ///
        /// 将存量加速域名的配置复制给新添加的域名。
        /// - 已开通CDN服务。
        /// - 如果加速域名的服务范围包含中国大陆，加速域名需要已完成备案。
        /// - 单租户调用频率：20次/min。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDomainByDuplicateResponse> CreateDomainByDuplicateAsync(CreateDomainByDuplicateRequest createDomainByDuplicateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/duplicate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDomainByDuplicateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateDomainByDuplicateResponse>(response);
        }

        public AsyncInvoker<CreateDomainByDuplicateResponse> CreateDomainByDuplicateAsyncInvoker(CreateDomainByDuplicateRequest createDomainByDuplicateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/duplicate", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDomainByDuplicateRequest);
            return new AsyncInvoker<CreateDomainByDuplicateResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateDomainByDuplicateResponse>);
        }
        
        /// <summary>
        /// 创建域名模板。
        ///
        /// 创建域名模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDomainTemplateResponse> CreateDomainTemplateAsync(CreateDomainTemplateRequest createDomainTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDomainTemplateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateDomainTemplateResponse>(response);
        }

        public AsyncInvoker<CreateDomainTemplateResponse> CreateDomainTemplateAsyncInvoker(CreateDomainTemplateRequest createDomainTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDomainTemplateRequest);
            return new AsyncInvoker<CreateDomainTemplateResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateDomainTemplateResponse>);
        }
        
        /// <summary>
        /// 创建统计数据异步导出任务
        ///
        /// 创建统计数据异步导出任务，目前支持话单数据导出、top url导出
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateExportTaskResponse> CreateExportTaskAsync(CreateExportTaskRequest createExportTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cdn/statistics/export-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createExportTaskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateExportTaskResponse>(response);
        }

        public AsyncInvoker<CreateExportTaskResponse> CreateExportTaskAsyncInvoker(CreateExportTaskRequest createExportTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cdn/statistics/export-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createExportTaskRequest);
            return new AsyncInvoker<CreateExportTaskResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateExportTaskResponse>);
        }
        
        /// <summary>
        /// 创建预热缓存任务
        ///
        /// 创建预热任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePreheatingTasksResponse> CreatePreheatingTasksAsync(CreatePreheatingTasksRequest createPreheatingTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/content/preheating-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPreheatingTasksRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePreheatingTasksResponse>(response);
        }

        public AsyncInvoker<CreatePreheatingTasksResponse> CreatePreheatingTasksAsyncInvoker(CreatePreheatingTasksRequest createPreheatingTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/content/preheating-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPreheatingTasksRequest);
            return new AsyncInvoker<CreatePreheatingTasksResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePreheatingTasksResponse>);
        }
        
        /// <summary>
        /// 创建刷新缓存任务
        ///
        /// 创建刷新缓存任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRefreshTasksResponse> CreateRefreshTasksAsync(CreateRefreshTasksRequest createRefreshTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/content/refresh-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRefreshTasksRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateRefreshTasksResponse>(response);
        }

        public AsyncInvoker<CreateRefreshTasksResponse> CreateRefreshTasksAsyncInvoker(CreateRefreshTasksRequest createRefreshTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/content/refresh-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRefreshTasksRequest);
            return new AsyncInvoker<CreateRefreshTasksResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRefreshTasksResponse>);
        }
        
        /// <summary>
        /// 创建规则引擎规则
        ///
        /// 规则引擎功能通过图形化的方式实现各种规则配置，实现更加灵活、细粒度的规则配置。通过限制触发条件，控制当前配置生效的资源范围，满足多种场景的配置需求。
        /// - 请提交工单开通规则引擎功能后再使用当前接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRuleNewResponse> CreateRuleNewAsync(CreateRuleNewRequest createRuleNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRuleNewRequest.DomainName, out var valueOfDomainName)) urlParam.Add("domain_name", valueOfDomainName);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/{domain_name}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRuleNewRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateRuleNewResponse>(response);
        }

        public AsyncInvoker<CreateRuleNewResponse> CreateRuleNewAsyncInvoker(CreateRuleNewRequest createRuleNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRuleNewRequest.DomainName, out var valueOfDomainName)) urlParam.Add("domain_name", valueOfDomainName);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/{domain_name}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRuleNewRequest);
            return new AsyncInvoker<CreateRuleNewResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateRuleNewResponse>);
        }
        
        /// <summary>
        /// 创建共享缓存组
        ///
        /// 配置共享缓存组，将一个域名设置为主域名，组内其他域名共享该域名的缓存，提高缓存命中率。
        /// - 只有缓存规则中“URL参数”的配置为“忽略参数”或者“不忽略参数”的域名才能加入共享缓存组。
        /// - 每个账号最多配置500个共享缓存组。
        /// - 单租户调用频率：5次/s。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateShareCacheGroupsResponse> CreateShareCacheGroupsAsync(CreateShareCacheGroupsRequest createShareCacheGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/share-cache-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createShareCacheGroupsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateShareCacheGroupsResponse>(response);
        }

        public AsyncInvoker<CreateShareCacheGroupsResponse> CreateShareCacheGroupsAsyncInvoker(CreateShareCacheGroupsRequest createShareCacheGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/share-cache-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createShareCacheGroupsRequest);
            return new AsyncInvoker<CreateShareCacheGroupsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateShareCacheGroupsResponse>);
        }
        
        /// <summary>
        /// 创建运营报表订阅任务
        ///
        /// create subscription task
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSubscriptionTaskResponse> CreateSubscriptionTaskAsync(CreateSubscriptionTaskRequest createSubscriptionTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cdn/statistics/subscription-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSubscriptionTaskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateSubscriptionTaskResponse>(response);
        }

        public AsyncInvoker<CreateSubscriptionTaskResponse> CreateSubscriptionTaskAsyncInvoker(CreateSubscriptionTaskRequest createSubscriptionTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cdn/statistics/subscription-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSubscriptionTaskRequest);
            return new AsyncInvoker<CreateSubscriptionTaskResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateSubscriptionTaskResponse>);
        }
        
        /// <summary>
        /// 创建资源标签配置接口
        ///
        /// 用于创建资源标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest createTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateTagsResponse>(response);
        }

        public AsyncInvoker<CreateTagsResponse> CreateTagsAsyncInvoker(CreateTagsRequest createTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagsRequest);
            return new AsyncInvoker<CreateTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateTagsResponse>);
        }
        
        /// <summary>
        /// 删除加速域名
        ///
        /// 删除加速域名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest deleteDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDomainRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDomainResponse>(response);
        }

        public AsyncInvoker<DeleteDomainResponse> DeleteDomainAsyncInvoker(DeleteDomainRequest deleteDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDomainRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainRequest);
            return new AsyncInvoker<DeleteDomainResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDomainResponse>);
        }
        
        /// <summary>
        /// 删除域名模板。
        ///
        /// 删除域名模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDomainTemplateResponse> DeleteDomainTemplateAsync(DeleteDomainTemplateRequest deleteDomainTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDomainTemplateRequest.TmlId, out var valueOfTmlId)) urlParam.Add("tml_id", valueOfTmlId);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/templates/{tml_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainTemplateRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDomainTemplateResponse>(response);
        }

        public AsyncInvoker<DeleteDomainTemplateResponse> DeleteDomainTemplateAsyncInvoker(DeleteDomainTemplateRequest deleteDomainTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteDomainTemplateRequest.TmlId, out var valueOfTmlId)) urlParam.Add("tml_id", valueOfTmlId);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/templates/{tml_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainTemplateRequest);
            return new AsyncInvoker<DeleteDomainTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDomainTemplateResponse>);
        }
        
        /// <summary>
        /// 删除规则引擎规则
        ///
        /// 删除规则引擎规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRuleNewResponse> DeleteRuleNewAsync(DeleteRuleNewRequest deleteRuleNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRuleNewRequest.DomainName, out var valueOfDomainName)) urlParam.Add("domain_name", valueOfDomainName);
            if (StringUtils.TryConvertToNonEmptyString(deleteRuleNewRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/{domain_name}/rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRuleNewRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRuleNewResponse>(response);
        }

        public AsyncInvoker<DeleteRuleNewResponse> DeleteRuleNewAsyncInvoker(DeleteRuleNewRequest deleteRuleNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRuleNewRequest.DomainName, out var valueOfDomainName)) urlParam.Add("domain_name", valueOfDomainName);
            if (StringUtils.TryConvertToNonEmptyString(deleteRuleNewRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/{domain_name}/rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRuleNewRequest);
            return new AsyncInvoker<DeleteRuleNewResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRuleNewResponse>);
        }
        
        /// <summary>
        /// 删除共享缓存组
        ///
        /// 删除新共享缓存组。
        /// - 共享缓存组内不包含关联域名时才可以删除。
        /// - 单租户调用频率：5次/s。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteShareCacheGroupsResponse> DeleteShareCacheGroupsAsync(DeleteShareCacheGroupsRequest deleteShareCacheGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteShareCacheGroupsRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/share-cache-groups/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteShareCacheGroupsRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteShareCacheGroupsResponse>(response);
        }

        public AsyncInvoker<DeleteShareCacheGroupsResponse> DeleteShareCacheGroupsAsyncInvoker(DeleteShareCacheGroupsRequest deleteShareCacheGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteShareCacheGroupsRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/share-cache-groups/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteShareCacheGroupsRequest);
            return new AsyncInvoker<DeleteShareCacheGroupsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteShareCacheGroupsResponse>);
        }
        
        /// <summary>
        /// 删除运营报表订阅任务
        ///
        /// delete subscription task
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSubscriptionTaskResponse> DeleteSubscriptionTaskAsync(DeleteSubscriptionTaskRequest deleteSubscriptionTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSubscriptionTaskRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/cdn/statistics/subscription-tasks/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubscriptionTaskRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSubscriptionTaskResponse>(response);
        }

        public AsyncInvoker<DeleteSubscriptionTaskResponse> DeleteSubscriptionTaskAsyncInvoker(DeleteSubscriptionTaskRequest deleteSubscriptionTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteSubscriptionTaskRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/cdn/statistics/subscription-tasks/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubscriptionTaskRequest);
            return new AsyncInvoker<DeleteSubscriptionTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSubscriptionTaskResponse>);
        }
        
        /// <summary>
        /// 停用加速域名
        ///
        /// 停用加速域名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DisableDomainResponse> DisableDomainAsync(DisableDomainRequest disableDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disableDomainRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableDomainRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<DisableDomainResponse>(response);
        }

        public AsyncInvoker<DisableDomainResponse> DisableDomainAsyncInvoker(DisableDomainRequest disableDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(disableDomainRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableDomainRequest);
            return new AsyncInvoker<DisableDomainResponse>(this, "PUT", request, JsonUtils.DeSerialize<DisableDomainResponse>);
        }
        
        /// <summary>
        /// 下载区域运营商指标数据表格文件
        ///
        /// - 下载区域运营商指标数据表格文件。
        /// 
        /// - 支持下载90天内的指标数据表格。
        /// 
        /// - 时间跨度不能超过31天。
        /// 
        /// - 起始时间和结束时间，左闭右开。如时间跨度为2022-10-24 00:00:00 到 2022-10-25 00:00:00，表示取 [2022-10-24 00:00:00, 2022-10-25 00:00:00)的统计数据。
        /// 
        /// - 起始时间、结束时间必须传毫秒级时间戳，起始时间和结束时间必须同时指定。
        /// 
        /// - 单租户调用频率：10次/min。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<DownloadRegionCarrierExcelResponse> DownloadRegionCarrierExcelAsync(DownloadRegionCarrierExcelRequest downloadRegionCarrierExcelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/region-carrier-excel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadRegionCarrierExcelRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerializeNull<DownloadRegionCarrierExcelResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<DownloadRegionCarrierExcelResponse> DownloadRegionCarrierExcelAsyncInvoker(DownloadRegionCarrierExcelRequest downloadRegionCarrierExcelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/region-carrier-excel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadRegionCarrierExcelRequest);
            return new AsyncInvoker<DownloadRegionCarrierExcelResponse>(this, "GET", request, JsonUtils.DeSerializeNull<DownloadRegionCarrierExcelResponse>);
        }
        
        /// <summary>
        /// 下载统计指标数据表格文件
        ///
        /// - 下载统计指标数据表格文件。
        /// 
        /// - 支持下载90天内的指标数据。
        /// 
        /// - 时间跨度不能超过31天。
        /// 
        /// - 起始时间和结束时间，左闭右开。如时间跨度为2022-10-24 00:00:00 到 2022-10-25 00:00:00，表示取 [2022-10-24 00:00:00, 2022-10-25 00:00:00)的统计数据。
        /// 
        /// - 起始时间、结束时间必须传毫秒级时间戳，起始时间和结束时间必须同时指定。
        /// 
        /// - 单租户调用频率：10次/min。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<DownloadStatisticsExcelResponse> DownloadStatisticsExcelAsync(DownloadStatisticsExcelRequest downloadStatisticsExcelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/statistics-excel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadStatisticsExcelRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerializeNull<DownloadStatisticsExcelResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<DownloadStatisticsExcelResponse> DownloadStatisticsExcelAsyncInvoker(DownloadStatisticsExcelRequest downloadStatisticsExcelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/statistics-excel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadStatisticsExcelRequest);
            return new AsyncInvoker<DownloadStatisticsExcelResponse>(this, "GET", request, JsonUtils.DeSerializeNull<DownloadStatisticsExcelResponse>);
        }
        
        /// <summary>
        /// 启用加速域名
        ///
        /// 启用加速域名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EnableDomainResponse> EnableDomainAsync(EnableDomainRequest enableDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableDomainRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableDomainRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<EnableDomainResponse>(response);
        }

        public AsyncInvoker<EnableDomainResponse> EnableDomainAsyncInvoker(EnableDomainRequest enableDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(enableDomainRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableDomainRequest);
            return new AsyncInvoker<EnableDomainResponse>(this, "PUT", request, JsonUtils.DeSerialize<EnableDomainResponse>);
        }
        
        /// <summary>
        /// CDN数据导出
        ///
        /// CDN数据导出
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ExportStatsOpenResponse> ExportStatsOpenAsync(ExportStatsOpenRequest exportStatsOpenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/stats/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportStatsOpenRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<ExportStatsOpenResponse>(response);
        }

        public AsyncInvoker<ExportStatsOpenResponse> ExportStatsOpenAsyncInvoker(ExportStatsOpenRequest exportStatsOpenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/stats/export", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", exportStatsOpenRequest);
            return new AsyncInvoker<ExportStatsOpenResponse>(this, "POST", request, JsonUtils.DeSerializeNull<ExportStatsOpenResponse>);
        }
        
        /// <summary>
        /// 查询封禁/解禁URL任务
        ///
        /// 查询封禁/解禁URL任务，如需使用本接口，请提交工单申请。
        /// - 单租户调用频率：30次/s。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAccessControlTaskResponse> ListAccessControlTaskAsync(ListAccessControlTaskRequest listAccessControlTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/content/access-control-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessControlTaskRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListAccessControlTaskResponse>(response);
        }

        public AsyncInvoker<ListAccessControlTaskResponse> ListAccessControlTaskAsyncInvoker(ListAccessControlTaskRequest listAccessControlTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/content/access-control-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAccessControlTaskRequest);
            return new AsyncInvoker<ListAccessControlTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListAccessControlTaskResponse>);
        }
        
        /// <summary>
        /// 查询已封禁的URL
        ///
        /// 查询已封禁的URL，如需使用本接口，请提交工单申请。
        /// - 单租户调用频率：30次/s。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBanUrlResponse> ListBanUrlAsync(ListBanUrlRequest listBanUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/content/ban-urls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBanUrlRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListBanUrlResponse>(response);
        }

        public AsyncInvoker<ListBanUrlResponse> ListBanUrlAsyncInvoker(ListBanUrlRequest listBanUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/content/ban-urls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBanUrlRequest);
            return new AsyncInvoker<ListBanUrlResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBanUrlResponse>);
        }
        
        /// <summary>
        /// 查询域名top ip统计分析数据
        ///
        /// - 查询域名top ip统计分析数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCdnDomainTopIpsResponse> ListCdnDomainTopIpsAsync(ListCdnDomainTopIpsRequest listCdnDomainTopIpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/top-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCdnDomainTopIpsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCdnDomainTopIpsResponse>(response);
        }

        public AsyncInvoker<ListCdnDomainTopIpsResponse> ListCdnDomainTopIpsAsyncInvoker(ListCdnDomainTopIpsRequest listCdnDomainTopIpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/top-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCdnDomainTopIpsRequest);
            return new AsyncInvoker<ListCdnDomainTopIpsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCdnDomainTopIpsResponse>);
        }
        
        /// <summary>
        /// 查询域名top回源URL数据
        ///
        /// - 查询域名top 回源URL数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCdnDomainTopOriginUrlResponse> ListCdnDomainTopOriginUrlAsync(ListCdnDomainTopOriginUrlRequest listCdnDomainTopOriginUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/top-origin-urls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCdnDomainTopOriginUrlRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCdnDomainTopOriginUrlResponse>(response);
        }

        public AsyncInvoker<ListCdnDomainTopOriginUrlResponse> ListCdnDomainTopOriginUrlAsyncInvoker(ListCdnDomainTopOriginUrlRequest listCdnDomainTopOriginUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/top-origin-urls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCdnDomainTopOriginUrlRequest);
            return new AsyncInvoker<ListCdnDomainTopOriginUrlResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCdnDomainTopOriginUrlResponse>);
        }
        
        /// <summary>
        /// 查询 TOP Path明细
        ///
        /// 查询 TOP Path明细
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCdnDomainTopPathResponse> ListCdnDomainTopPathAsync(ListCdnDomainTopPathRequest listCdnDomainTopPathRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/top-path", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCdnDomainTopPathRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCdnDomainTopPathResponse>(response);
        }

        public AsyncInvoker<ListCdnDomainTopPathResponse> ListCdnDomainTopPathAsyncInvoker(ListCdnDomainTopPathRequest listCdnDomainTopPathRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/top-path", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCdnDomainTopPathRequest);
            return new AsyncInvoker<ListCdnDomainTopPathResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCdnDomainTopPathResponse>);
        }
        
        /// <summary>
        /// 查询统计TOP100 referer数据明细
        ///
        /// - 查询TOP100 referer数据。
        /// 
        /// - 支持查询90天内的数据。
        /// 
        /// - 查询跨度不能超过31天。
        /// 
        /// - 单租户调用频率：2次/s。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCdnDomainTopRefersResponse> ListCdnDomainTopRefersAsync(ListCdnDomainTopRefersRequest listCdnDomainTopRefersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/top-refers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCdnDomainTopRefersRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCdnDomainTopRefersResponse>(response);
        }

        public AsyncInvoker<ListCdnDomainTopRefersResponse> ListCdnDomainTopRefersAsyncInvoker(ListCdnDomainTopRefersRequest listCdnDomainTopRefersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/top-refers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCdnDomainTopRefersRequest);
            return new AsyncInvoker<ListCdnDomainTopRefersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCdnDomainTopRefersResponse>);
        }
        
        /// <summary>
        /// 查询域名top ua统计分析数据
        ///
        /// - 统计分析TOP UA统计数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCdnDomainTopUasResponse> ListCdnDomainTopUasAsync(ListCdnDomainTopUasRequest listCdnDomainTopUasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/top-uas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCdnDomainTopUasRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCdnDomainTopUasResponse>(response);
        }

        public AsyncInvoker<ListCdnDomainTopUasResponse> ListCdnDomainTopUasAsyncInvoker(ListCdnDomainTopUasRequest listCdnDomainTopUasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/top-uas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCdnDomainTopUasRequest);
            return new AsyncInvoker<ListCdnDomainTopUasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCdnDomainTopUasResponse>);
        }
        
        /// <summary>
        /// 按域名维度查询每天客户端访问详情统计
        ///
        /// - 按域名维度查询每天客户端访问详情统计。
        /// - 支持查询90天内的数据。
        /// - ip_num查询跨度只支持1天,uv查询跨度只支持5分钟。
        /// - 起始时间和结束时间，左闭右开，需要同时指定。如查询2022-07-12 00:00:00 到 2022-07-13 00:00:00 的数据，表示取 [2022-07-12 00:00:00, 2022-07-13 00:00:00)的统计数据。
        /// - ip_num开始时间、结束时间必须传毫秒级时间戳，必须为凌晨0点整时刻点，如果传的不是凌晨0点整时刻点，返回数据可能与预期不一致。
        /// - uv必须为5分钟整时刻点，如：0分、5分、10分、15分等，如果传的不是5分钟时刻点，返回数据可能与预期不一致
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDomainClientStatsResponse> ListDomainClientStatsAsync(ListDomainClientStatsRequest listDomainClientStatsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-client-stats", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainClientStatsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDomainClientStatsResponse>(response);
        }

        public AsyncInvoker<ListDomainClientStatsResponse> ListDomainClientStatsAsyncInvoker(ListDomainClientStatsRequest listDomainClientStatsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-client-stats", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainClientStatsRequest);
            return new AsyncInvoker<ListDomainClientStatsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainClientStatsResponse>);
        }
        
        /// <summary>
        /// 查询加速域名基础信息
        ///
        /// 查询加速域名的基础信息，包含cname状态、加速域名是否支持复制配置。
        /// - 单租户调用频率：5次/s。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDomainConfigsResponse> ListDomainConfigsAsync(ListDomainConfigsRequest listDomainConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainConfigsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDomainConfigsResponse>(response);
        }

        public AsyncInvoker<ListDomainConfigsResponse> ListDomainConfigsAsyncInvoker(ListDomainConfigsRequest listDomainConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainConfigsRequest);
            return new AsyncInvoker<ListDomainConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainConfigsResponse>);
        }
        
        /// <summary>
        /// 查询加速域名
        ///
        /// 查询加速域名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest listDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDomainsResponse>(response);
        }

        public AsyncInvoker<ListDomainsResponse> ListDomainsAsyncInvoker(ListDomainsRequest listDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainsRequest);
            return new AsyncInvoker<ListDomainsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainsResponse>);
        }
        
        /// <summary>
        /// 分页查询统计数据异步导出
        ///
        /// 分页查询统计数据异步导出任务，按修改时间降序排列，当任务状态为success时，返回参数中会包含download_link
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListExportTasksResponse> ListExportTasksAsync(ListExportTasksRequest listExportTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cdn/statistics/export-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listExportTasksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListExportTasksResponse>(response);
        }

        public AsyncInvoker<ListExportTasksResponse> ListExportTasksAsyncInvoker(ListExportTasksRequest listExportTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cdn/statistics/export-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listExportTasksRequest);
            return new AsyncInvoker<ListExportTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListExportTasksResponse>);
        }
        
        /// <summary>
        /// 查询规则引擎列表
        ///
        /// 查询规则引擎列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRuleDetailsResponse> ListRuleDetailsAsync(ListRuleDetailsRequest listRuleDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRuleDetailsRequest.DomainName, out var valueOfDomainName)) urlParam.Add("domain_name", valueOfDomainName);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/{domain_name}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRuleDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRuleDetailsResponse>(response);
        }

        public AsyncInvoker<ListRuleDetailsResponse> ListRuleDetailsAsyncInvoker(ListRuleDetailsRequest listRuleDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRuleDetailsRequest.DomainName, out var valueOfDomainName)) urlParam.Add("domain_name", valueOfDomainName);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/{domain_name}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRuleDetailsRequest);
            return new AsyncInvoker<ListRuleDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRuleDetailsResponse>);
        }
        
        /// <summary>
        /// 查询共享缓存组列表
        ///
        /// 查询共享缓存组列表。
        /// - 单租户调用频率：5次/s。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListShareCacheGroupsResponse> ListShareCacheGroupsAsync(ListShareCacheGroupsRequest listShareCacheGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/share-cache-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listShareCacheGroupsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListShareCacheGroupsResponse>(response);
        }

        public AsyncInvoker<ListShareCacheGroupsResponse> ListShareCacheGroupsAsyncInvoker(ListShareCacheGroupsRequest listShareCacheGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/share-cache-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listShareCacheGroupsRequest);
            return new AsyncInvoker<ListShareCacheGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListShareCacheGroupsResponse>);
        }
        
        /// <summary>
        /// 查询加速域名的特殊配置
        ///
        /// 查询加速域名的特殊配置，当前支持查询备忘录信息。
        /// - 单租户调用频率：15次/s。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSpecialConfigurationResponse> ListSpecialConfigurationAsync(ListSpecialConfigurationRequest listSpecialConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/special-configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSpecialConfigurationRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSpecialConfigurationResponse>(response);
        }

        public AsyncInvoker<ListSpecialConfigurationResponse> ListSpecialConfigurationAsyncInvoker(ListSpecialConfigurationRequest listSpecialConfigurationRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/special-configurations", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSpecialConfigurationRequest);
            return new AsyncInvoker<ListSpecialConfigurationResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSpecialConfigurationResponse>);
        }
        
        /// <summary>
        /// 分页查询运营报表订阅任务
        ///
        /// query subscription task
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSubscriptionTasksResponse> ListSubscriptionTasksAsync(ListSubscriptionTasksRequest listSubscriptionTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cdn/statistics/subscription-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubscriptionTasksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSubscriptionTasksResponse>(response);
        }

        public AsyncInvoker<ListSubscriptionTasksResponse> ListSubscriptionTasksAsyncInvoker(ListSubscriptionTasksRequest listSubscriptionTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cdn/statistics/subscription-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubscriptionTasksRequest);
            return new AsyncInvoker<ListSubscriptionTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSubscriptionTasksResponse>);
        }
        
        /// <summary>
        /// 修改租户配置
        ///
        /// 修改租户配置，当前仅支持开启OBS和SCM委托授权。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ModifyAccountInfoResponse> ModifyAccountInfoAsync(ModifyAccountInfoRequest modifyAccountInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/account-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyAccountInfoRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<ModifyAccountInfoResponse>(response);
        }

        public AsyncInvoker<ModifyAccountInfoResponse> ModifyAccountInfoAsyncInvoker(ModifyAccountInfoRequest modifyAccountInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/account-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyAccountInfoRequest);
            return new AsyncInvoker<ModifyAccountInfoResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ModifyAccountInfoResponse>);
        }
        
        /// <summary>
        /// 设置用户计费模式
        ///
        /// - 设置用户计费模式。
        /// 
        /// - 服务区域仅支持mainland_china（国内）
        /// 
        /// - 计费模式仅支持设置flux（流量），v2及以上客户支持bw（带宽）
        /// 
        /// - 加速类型仅支持base（基础加速）
        /// 
        /// - 单租户调用频率：10次/min。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetChargeModesResponse> SetChargeModesAsync(SetChargeModesRequest setChargeModesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/charge/charge-modes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setChargeModesRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<SetChargeModesResponse>(response);
        }

        public AsyncInvoker<SetChargeModesResponse> SetChargeModesAsyncInvoker(SetChargeModesRequest setChargeModesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/charge/charge-modes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setChargeModesRequest);
            return new AsyncInvoker<SetChargeModesResponse>(this, "PUT", request, JsonUtils.DeSerialize<SetChargeModesResponse>);
        }
        
        /// <summary>
        /// 设置统计配置
        ///
        /// - 设置统计配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetStatsConfigResponse> SetStatsConfigAsync(SetStatsConfigRequest setStatsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cdn/statistics/stats-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setStatsConfigRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<SetStatsConfigResponse>(response);
        }

        public AsyncInvoker<SetStatsConfigResponse> SetStatsConfigAsyncInvoker(SetStatsConfigRequest setStatsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cdn/statistics/stats-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setStatsConfigRequest);
            return new AsyncInvoker<SetStatsConfigResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SetStatsConfigResponse>);
        }
        
        /// <summary>
        /// 查询域名模板应用记录。
        ///
        /// 查询域名模板应用记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowAppliedTemplateRecordResponse> ShowAppliedTemplateRecordAsync(ShowAppliedTemplateRecordRequest showAppliedTemplateRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/tml-apply-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppliedTemplateRecordRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowAppliedTemplateRecordResponse>(response);
        }

        public AsyncInvoker<ShowAppliedTemplateRecordResponse> ShowAppliedTemplateRecordAsyncInvoker(ShowAppliedTemplateRecordRequest showAppliedTemplateRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/tml-apply-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppliedTemplateRecordRequest);
            return new AsyncInvoker<ShowAppliedTemplateRecordResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAppliedTemplateRecordResponse>);
        }
        
        /// <summary>
        /// 查询域名带宽峰值类数据
        ///
        /// - 查询域名带宽峰值类数据。
        /// 
        /// - 支持查询90天内的数据。
        /// 
        /// - 查询时间跨度不能超过31天。
        /// 
        /// - 起始时间和结束时间，左闭右开。如查询2022-10-24 00:00:00 到 2022-10-25 00:00:00 的数据，表示取 [2022-10-24 00:00:00, 2022-10-25 00:00:00)的统计数据。
        /// 
        /// - 起始时间、结束时间必须传毫秒级时间戳，起始时间和结束时间必须同时指定。
        /// 
        /// - 流量类指标单位统一为Byte（字节）、带宽类指标单位统一为bit/s（比特/秒）、峰值类指标单位统一为bps（比特率），请求数类和状态码类指标单位统一为次数。用于查询指定域名、指定统计指标的明细数据。
        /// 
        /// - 单租户调用频率：2次/s。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<ShowBandwidthCalcResponse> ShowBandwidthCalcAsync(ShowBandwidthCalcRequest showBandwidthCalcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/bandwidth-calc", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBandwidthCalcRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowBandwidthCalcResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<ShowBandwidthCalcResponse> ShowBandwidthCalcAsyncInvoker(ShowBandwidthCalcRequest showBandwidthCalcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/bandwidth-calc", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBandwidthCalcRequest);
            return new AsyncInvoker<ShowBandwidthCalcResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBandwidthCalcResponse>);
        }
        
        /// <summary>
        /// 查询所有绑定HTTPS证书的域名信息
        ///
        /// 查询所有绑定HTTPS证书的域名信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowCertificatesHttpsInfoResponse> ShowCertificatesHttpsInfoAsync(ShowCertificatesHttpsInfoRequest showCertificatesHttpsInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/https-certificate-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCertificatesHttpsInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowCertificatesHttpsInfoResponse>(response);
        }

        public AsyncInvoker<ShowCertificatesHttpsInfoResponse> ShowCertificatesHttpsInfoAsyncInvoker(ShowCertificatesHttpsInfoRequest showCertificatesHttpsInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/https-certificate-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCertificatesHttpsInfoRequest);
            return new AsyncInvoker<ShowCertificatesHttpsInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCertificatesHttpsInfoResponse>);
        }
        
        /// <summary>
        /// 查询用户计费模式
        ///
        /// - 查询用户计费模式。
        /// 
        /// - 服务区域仅支持mainland_china（国内，默认）和outside_mainland_china（海外）
        /// 
        /// - 计费模式状态支持active（已生效），upcoming（待生效）两种状态，默认为active(已生效)
        /// 
        /// - 加速类型仅支持base（基础加速）
        /// 
        /// - 单租户调用频率：5次/s。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowChargeModesResponse> ShowChargeModesAsync(ShowChargeModesRequest showChargeModesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/charge/charge-modes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showChargeModesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowChargeModesResponse>(response);
        }

        public AsyncInvoker<ShowChargeModesResponse> ShowChargeModesAsyncInvoker(ShowChargeModesRequest showChargeModesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/charge/charge-modes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showChargeModesRequest);
            return new AsyncInvoker<ShowChargeModesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowChargeModesResponse>);
        }
        
        /// <summary>
        /// CDN查询域名的国家统计数据
        ///
        /// CDN查询域名的国家统计数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainCountryStatResponse> ShowDomainCountryStatAsync(ShowDomainCountryStatRequest showDomainCountryStatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-country-stats", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainCountryStatRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainCountryStatResponse>(response);
        }

        public AsyncInvoker<ShowDomainCountryStatResponse> ShowDomainCountryStatAsyncInvoker(ShowDomainCountryStatRequest showDomainCountryStatRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-country-stats", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainCountryStatRequest);
            return new AsyncInvoker<ShowDomainCountryStatResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainCountryStatResponse>);
        }
        
        /// <summary>
        /// 查询加速域名详情
        ///
        /// 加速域名详情信息接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainDetailByNameResponse> ShowDomainDetailByNameAsync(ShowDomainDetailByNameRequest showDomainDetailByNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDomainDetailByNameRequest.DomainName, out var valueOfDomainName)) urlParam.Add("domain_name", valueOfDomainName);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/{domain_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainDetailByNameRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainDetailByNameResponse>(response);
        }

        public AsyncInvoker<ShowDomainDetailByNameResponse> ShowDomainDetailByNameAsyncInvoker(ShowDomainDetailByNameRequest showDomainDetailByNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDomainDetailByNameRequest.DomainName, out var valueOfDomainName)) urlParam.Add("domain_name", valueOfDomainName);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/{domain_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainDetailByNameRequest);
            return new AsyncInvoker<ShowDomainDetailByNameResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainDetailByNameResponse>);
        }
        
        /// <summary>
        /// 查询域名配置接口
        ///
        /// 查询域名配置接口，支持查询业务类型、服务范围、备注、IPv6开关、回源方式、回源URL改写、高级回源、Range回源、回源跟随、回源是否校验Etag、回源超时时间、回源请求头、HTTPS配置、TLS版本配置、强制跳转、HSTS、HTTP/2、OCSP Stapling、QUIC、缓存规则、状态码缓存时间、防盗链、IP黑白名单、 Use-Agent黑白名单、URL鉴权配置、远程鉴权配置、IP访问限频、HTTP header配置、自定义错误页面配置、智能压缩、请求限速配置、WebSocket配置、视频拖拽、回源SNI、访问URL重写、浏览器缓存过期时间、区域访问控制。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainFullConfigResponse> ShowDomainFullConfigAsync(ShowDomainFullConfigRequest showDomainFullConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDomainFullConfigRequest.DomainName, out var valueOfDomainName)) urlParam.Add("domain_name", valueOfDomainName);
            var urlPath = HttpUtils.AddUrlPath("/v1.1/cdn/configuration/domains/{domain_name}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainFullConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainFullConfigResponse>(response);
        }

        public AsyncInvoker<ShowDomainFullConfigResponse> ShowDomainFullConfigAsyncInvoker(ShowDomainFullConfigRequest showDomainFullConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showDomainFullConfigRequest.DomainName, out var valueOfDomainName)) urlParam.Add("domain_name", valueOfDomainName);
            var urlPath = HttpUtils.AddUrlPath("/v1.1/cdn/configuration/domains/{domain_name}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainFullConfigRequest);
            return new AsyncInvoker<ShowDomainFullConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainFullConfigResponse>);
        }
        
        /// <summary>
        /// 按区域运营商查询域名统计数据
        ///
        /// - 支持查询90天内的数据。
        /// 
        /// - 支持多指标同时查询，不超过5个。
        /// 
        /// - 最多同时指定20个域名。
        /// 
        /// - 起始时间和结束时间需要同时指定，左闭右开，毫秒级时间戳，且时间点必须为与查询时间间隔参数匹配的整时刻点。比如查询时间间隔为5分钟时，起始时间和结束时间必须为5分钟整时刻点，如：0分、5分、10分、15分等，如果时间点与时间间隔不匹配，返回数据可能与预期不一致。统一用开始时间表示一个时间段，如：2019-01-24 20:15:00 表示取 [20:15:00, 20:20:00)的统计数据，且左闭右开。
        /// 
        /// - action取值：location_detail,location_summary
        /// 
        /// - 流量类指标单位统一为Byte（字节）、带宽类指标单位统一为bit/s（比特/秒）、请求数类和状态码类指标单位统一为次数。用于查询指定域名、指定统计指标的区域运营商明细数据。
        /// 
        /// - 单租户调用频率：15次/s。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainLocationStatsResponse> ShowDomainLocationStatsAsync(ShowDomainLocationStatsRequest showDomainLocationStatsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-location-stats", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainLocationStatsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainLocationStatsResponse>(response);
        }

        public AsyncInvoker<ShowDomainLocationStatsResponse> ShowDomainLocationStatsAsyncInvoker(ShowDomainLocationStatsRequest showDomainLocationStatsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-location-stats", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainLocationStatsRequest);
            return new AsyncInvoker<ShowDomainLocationStatsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainLocationStatsResponse>);
        }
        
        /// <summary>
        /// 查询域名统计数据
        ///
        /// - 支持查询90天内的数据。
        /// 
        /// - 支持多指标同时查询，不超过5个。
        /// 
        /// - 最多同时指定20个域名。
        /// 
        /// - 起始时间和结束时间需要同时指定，左闭右开，毫秒级时间戳，且时间点必须为与查询时间间隔参数匹配的整时刻点。比如查询时间间隔为5分钟时，起始时间和结束时间必须为5分钟整时刻点，如：0分、5分、10分、15分等，如果时间点与时间间隔不匹配，返回数据可能与预期不一致。统一用开始时间表示一个时间段，如：2019-01-24 20:15:00 表示取 [20:15:00, 20:20:00)的统计数据，且左闭右开。
        /// 
        /// - action取值：detail,summary
        /// 
        /// - 流量类指标单位统一为Byte（字节）、带宽类指标单位统一为bit/s（比特/秒）、请求数类和状态码类指标单位统一为次数。用于查询指定域名、指定统计指标的明细数据。
        /// 
        /// - 单租户调用频率：15次/s。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainStatsResponse> ShowDomainStatsAsync(ShowDomainStatsRequest showDomainStatsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-stats", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainStatsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainStatsResponse>(response);
        }

        public AsyncInvoker<ShowDomainStatsResponse> ShowDomainStatsAsyncInvoker(ShowDomainStatsRequest showDomainStatsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-stats", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainStatsRequest);
            return new AsyncInvoker<ShowDomainStatsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainStatsResponse>);
        }
        
        /// <summary>
        /// 查询域名模板列表
        ///
        /// 查询域名模板列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainTemplateResponse> ShowDomainTemplateAsync(ShowDomainTemplateRequest showDomainTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainTemplateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainTemplateResponse>(response);
        }

        public AsyncInvoker<ShowDomainTemplateResponse> ShowDomainTemplateAsyncInvoker(ShowDomainTemplateRequest showDomainTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainTemplateRequest);
            return new AsyncInvoker<ShowDomainTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainTemplateResponse>);
        }
        
        /// <summary>
        /// 查询刷新预热任务详情
        ///
        /// 查询刷新预热任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowHistoryTaskDetailsResponse> ShowHistoryTaskDetailsAsync(ShowHistoryTaskDetailsRequest showHistoryTaskDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showHistoryTaskDetailsRequest.HistoryTasksId, out var valueOfHistoryTasksId)) urlParam.Add("history_tasks_id", valueOfHistoryTasksId);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/historytasks/{history_tasks_id}/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHistoryTaskDetailsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowHistoryTaskDetailsResponse>(response);
        }

        public AsyncInvoker<ShowHistoryTaskDetailsResponse> ShowHistoryTaskDetailsAsyncInvoker(ShowHistoryTaskDetailsRequest showHistoryTaskDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showHistoryTaskDetailsRequest.HistoryTasksId, out var valueOfHistoryTasksId)) urlParam.Add("history_tasks_id", valueOfHistoryTasksId);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/historytasks/{history_tasks_id}/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHistoryTaskDetailsRequest);
            return new AsyncInvoker<ShowHistoryTaskDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHistoryTaskDetailsResponse>);
        }
        
        /// <summary>
        /// 查询刷新预热任务
        ///
        /// 查询刷新预热任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowHistoryTasksResponse> ShowHistoryTasksAsync(ShowHistoryTasksRequest showHistoryTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/historytasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHistoryTasksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowHistoryTasksResponse>(response);
        }

        public AsyncInvoker<ShowHistoryTasksResponse> ShowHistoryTasksAsyncInvoker(ShowHistoryTasksRequest showHistoryTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/historytasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHistoryTasksRequest);
            return new AsyncInvoker<ShowHistoryTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHistoryTasksResponse>);
        }
        
        /// <summary>
        /// 查询IP归属信息
        ///
        /// 查询IP归属信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowIpInfoResponse> ShowIpInfoAsync(ShowIpInfoRequest showIpInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/ip-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowIpInfoResponse>(response);
        }

        public AsyncInvoker<ShowIpInfoResponse> ShowIpInfoAsyncInvoker(ShowIpInfoRequest showIpInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/ip-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpInfoRequest);
            return new AsyncInvoker<ShowIpInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowIpInfoResponse>);
        }
        
        /// <summary>
        /// 日志查询
        ///
        /// 查询日志下载链接，支持查询30天内的日志信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowLogsResponse> ShowLogsAsync(ShowLogsRequest showLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowLogsResponse>(response);
        }

        public AsyncInvoker<ShowLogsResponse> ShowLogsAsyncInvoker(ShowLogsRequest showLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogsRequest);
            return new AsyncInvoker<ShowLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLogsResponse>);
        }
        
        /// <summary>
        /// 查询用户配额
        ///
        /// 查询当前用户域名、刷新文件、刷新目录和预热的配额
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowQuotaResponse> ShowQuotaAsync(ShowQuotaRequest showQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowQuotaResponse>(response);
        }

        public AsyncInvoker<ShowQuotaResponse> ShowQuotaAsyncInvoker(ShowQuotaRequest showQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaRequest);
            return new AsyncInvoker<ShowQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowQuotaResponse>);
        }
        
        /// <summary>
        /// 查询CDN特殊用户接口
        ///
        /// 查询CDN特殊用户接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowSpecialUserResponse> ShowSpecialUserAsync(ShowSpecialUserRequest showSpecialUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/special-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSpecialUserRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowSpecialUserResponse>(response);
        }

        public AsyncInvoker<ShowSpecialUserResponse> ShowSpecialUserAsyncInvoker(ShowSpecialUserRequest showSpecialUserRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/special-user", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSpecialUserRequest);
            return new AsyncInvoker<ShowSpecialUserResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowSpecialUserResponse>);
        }
        
        /// <summary>
        /// 查询统计配置
        ///
        /// - 配置类型：目前支持，
        /// - 0：热点统计。
        /// - 1：ces上报。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowStatsConfigsResponse> ShowStatsConfigsAsync(ShowStatsConfigsRequest showStatsConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cdn/statistics/stats-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatsConfigsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowStatsConfigsResponse>(response);
        }

        public AsyncInvoker<ShowStatsConfigsResponse> ShowStatsConfigsAsyncInvoker(ShowStatsConfigsRequest showStatsConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cdn/statistics/stats-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatsConfigsRequest);
            return new AsyncInvoker<ShowStatsConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStatsConfigsResponse>);
        }
        
        /// <summary>
        /// 查询资源标签列表配置接口
        ///
        /// 用于查询资源标签列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTagsResponse> ShowTagsAsync(ShowTagsRequest showTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTagsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTagsResponse>(response);
        }

        public AsyncInvoker<ShowTagsResponse> ShowTagsAsyncInvoker(ShowTagsRequest showTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTagsRequest);
            return new AsyncInvoker<ShowTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTagsResponse>);
        }
        
        /// <summary>
        /// 查询TOP域名
        ///
        /// - 查询TOP域名。
        /// 
        /// - 支持查询90天内的数据。
        /// 
        /// - 查询时间跨度不能超过1天。
        /// 
        /// - 起始时间和结束时间，左闭右开，必须同时指定。如查询2022-10-24 00:00:00 到 2022-10-25 00:00:00 的数据，表示取 [2022-10-24 00:00:00, 2022-10-25 00:00:00)的统计数据。
        /// 
        /// - 起始时间、结束时间必须传整点毫秒级时间戳。
        /// 
        /// - 流量类指标单位统一为Byte（字节）、带宽类指标单位统一为bit/s（比特/秒）、请求数类和状态码类指标单位统一为次数。用于查询指定域名、指定统计指标的明细数据。
        /// 
        /// - 单租户调用频率：5次/s。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public async Task<ShowTopDomainNamesResponse> ShowTopDomainNamesAsync(ShowTopDomainNamesRequest showTopDomainNamesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cdn/statistics/top-domain-names", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopDomainNamesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTopDomainNamesResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public AsyncInvoker<ShowTopDomainNamesResponse> ShowTopDomainNamesAsyncInvoker(ShowTopDomainNamesRequest showTopDomainNamesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cdn/statistics/top-domain-names", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopDomainNamesRequest);
            return new AsyncInvoker<ShowTopDomainNamesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTopDomainNamesResponse>);
        }
        
        /// <summary>
        /// 查询TOP100 URL明细
        ///
        /// - 查询TOP100 URL明细。
        /// 
        /// - 支持查询90天内的数据。
        /// 
        /// - 查询跨度不能超过31天。
        /// 
        /// - 起始时间和结束时间，左闭右开，需要同时指定。如查询2021-10-24 00:00:00 到 2021-10-25 00:00:00 的数据，表示取 [2021-10-24 00:00:00, 2021-10-25 00:00:00)的统计数据。
        /// 
        /// - 开始时间、结束时间必须传毫秒级时间戳，且必须为凌晨0点整时刻点，如果传的不是凌晨0点整时刻点，返回数据可能与预期不一致。
        /// 
        /// - 流量类指标单位统一为Byte（字节）、请求数类指标单位统一为次数。用于查询指定域名、指定统计指标的明细数据。
        /// 
        /// - 单租户调用频率：5次/s。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTopUrlResponse> ShowTopUrlAsync(ShowTopUrlRequest showTopUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/top-url", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopUrlRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTopUrlResponse>(response);
        }

        public AsyncInvoker<ShowTopUrlResponse> ShowTopUrlAsyncInvoker(ShowTopUrlRequest showTopUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/top-url", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopUrlRequest);
            return new AsyncInvoker<ShowTopUrlResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTopUrlResponse>);
        }
        
        /// <summary>
        /// 查询刷新预热URL记录
        ///
        /// 查询刷新预热URL记录。如需此接口，请提交工单开通。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowUrlTaskInfoResponse> ShowUrlTaskInfoAsync(ShowUrlTaskInfoRequest showUrlTaskInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/contentgateway/url-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUrlTaskInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowUrlTaskInfoResponse>(response);
        }

        public AsyncInvoker<ShowUrlTaskInfoResponse> ShowUrlTaskInfoAsyncInvoker(ShowUrlTaskInfoRequest showUrlTaskInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/contentgateway/url-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUrlTaskInfoRequest);
            return new AsyncInvoker<ShowUrlTaskInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUrlTaskInfoResponse>);
        }
        
        /// <summary>
        /// 查询域名归属校验信息
        ///
        /// 用于查询域名归属校验信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowVerifyDomainOwnerInfoResponse> ShowVerifyDomainOwnerInfoAsync(ShowVerifyDomainOwnerInfoRequest showVerifyDomainOwnerInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showVerifyDomainOwnerInfoRequest.DomainName, out var valueOfDomainName)) urlParam.Add("domain_name", valueOfDomainName);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/{domain_name}/domain-verifies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVerifyDomainOwnerInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowVerifyDomainOwnerInfoResponse>(response);
        }

        public AsyncInvoker<ShowVerifyDomainOwnerInfoResponse> ShowVerifyDomainOwnerInfoAsyncInvoker(ShowVerifyDomainOwnerInfoRequest showVerifyDomainOwnerInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showVerifyDomainOwnerInfoRequest.DomainName, out var valueOfDomainName)) urlParam.Add("domain_name", valueOfDomainName);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/{domain_name}/domain-verifies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVerifyDomainOwnerInfoRequest);
            return new AsyncInvoker<ShowVerifyDomainOwnerInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVerifyDomainOwnerInfoResponse>);
        }
        
        /// <summary>
        /// 修改域名全量配置接口
        ///
        /// 修改域名配置接口，支持修改业务类型、服务范围、备注、IPv6开关、回源方式、回源URL改写、高级回源、Range回源、回源跟随、回源是否校验Etag、回源超时时间、回源请求头、HTTPS配置、TLS版本配置、强制跳转、HSTS、HTTP/2、OCSP Stapling、QUIC、缓存规则、状态码缓存时间、防盗链、IP黑白名单、Use-Agent黑白名单、URL鉴权配置、远程鉴权配置、IP访问限频、HTTP header配置、自定义错误页面配置、智能压缩、请求限速配置、WebSocket配置、视频拖拽、回源SNI、访问URL重写、浏览器缓存过期时间、区域访问控制。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDomainFullConfigResponse> UpdateDomainFullConfigAsync(UpdateDomainFullConfigRequest updateDomainFullConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDomainFullConfigRequest.DomainName, out var valueOfDomainName)) urlParam.Add("domain_name", valueOfDomainName);
            var urlPath = HttpUtils.AddUrlPath("/v1.1/cdn/configuration/domains/{domain_name}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainFullConfigRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateDomainFullConfigResponse>(response);
        }

        public AsyncInvoker<UpdateDomainFullConfigResponse> UpdateDomainFullConfigAsyncInvoker(UpdateDomainFullConfigRequest updateDomainFullConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDomainFullConfigRequest.DomainName, out var valueOfDomainName)) urlParam.Add("domain_name", valueOfDomainName);
            var urlPath = HttpUtils.AddUrlPath("/v1.1/cdn/configuration/domains/{domain_name}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainFullConfigRequest);
            return new AsyncInvoker<UpdateDomainFullConfigResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDomainFullConfigResponse>);
        }
        
        /// <summary>
        /// 一个证书批量设置多个域名
        ///
        /// 一个证书配置多个域名，设置域名强制https回源参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDomainMultiCertificatesResponse> UpdateDomainMultiCertificatesAsync(UpdateDomainMultiCertificatesRequest updateDomainMultiCertificatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/config-https-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainMultiCertificatesRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDomainMultiCertificatesResponse>(response);
        }

        public AsyncInvoker<UpdateDomainMultiCertificatesResponse> UpdateDomainMultiCertificatesAsyncInvoker(UpdateDomainMultiCertificatesRequest updateDomainMultiCertificatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/config-https-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainMultiCertificatesRequest);
            return new AsyncInvoker<UpdateDomainMultiCertificatesResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDomainMultiCertificatesResponse>);
        }
        
        /// <summary>
        /// 修改域名模板。
        ///
        /// 修改域名模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDomainTemplateResponse> UpdateDomainTemplateAsync(UpdateDomainTemplateRequest updateDomainTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDomainTemplateRequest.TmlId, out var valueOfTmlId)) urlParam.Add("tml_id", valueOfTmlId);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/templates/{tml_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainTemplateRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateDomainTemplateResponse>(response);
        }

        public AsyncInvoker<UpdateDomainTemplateResponse> UpdateDomainTemplateAsyncInvoker(UpdateDomainTemplateRequest updateDomainTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateDomainTemplateRequest.TmlId, out var valueOfTmlId)) urlParam.Add("tml_id", valueOfTmlId);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/templates/{tml_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainTemplateRequest);
            return new AsyncInvoker<UpdateDomainTemplateResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDomainTemplateResponse>);
        }
        
        /// <summary>
        /// 全量更新规则引擎规则
        ///
        /// 全量更新规则引擎规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateFullRuleResponse> UpdateFullRuleAsync(UpdateFullRuleRequest updateFullRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateFullRuleRequest.DomainName, out var valueOfDomainName)) urlParam.Add("domain_name", valueOfDomainName);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/{domain_name}/rules/full-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFullRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateFullRuleResponse>(response);
        }

        public AsyncInvoker<UpdateFullRuleResponse> UpdateFullRuleAsyncInvoker(UpdateFullRuleRequest updateFullRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateFullRuleRequest.DomainName, out var valueOfDomainName)) urlParam.Add("domain_name", valueOfDomainName);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/{domain_name}/rules/full-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFullRuleRequest);
            return new AsyncInvoker<UpdateFullRuleResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateFullRuleResponse>);
        }
        
        /// <summary>
        /// 修改私有桶开启关闭状态
        ///
        /// 修改私有桶开启关闭状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePrivateBucketAccessResponse> UpdatePrivateBucketAccessAsync(UpdatePrivateBucketAccessRequest updatePrivateBucketAccessRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePrivateBucketAccessRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/private-bucket-access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateBucketAccessRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePrivateBucketAccessResponse>(response);
        }

        public AsyncInvoker<UpdatePrivateBucketAccessResponse> UpdatePrivateBucketAccessAsyncInvoker(UpdatePrivateBucketAccessRequest updatePrivateBucketAccessRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePrivateBucketAccessRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/private-bucket-access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateBucketAccessRequest);
            return new AsyncInvoker<UpdatePrivateBucketAccessResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePrivateBucketAccessResponse>);
        }
        
        /// <summary>
        /// 更新规则引擎规则
        ///
        /// 更新规则引擎规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRuleNewResponse> UpdateRuleNewAsync(UpdateRuleNewRequest updateRuleNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRuleNewRequest.DomainName, out var valueOfDomainName)) urlParam.Add("domain_name", valueOfDomainName);
            if (StringUtils.TryConvertToNonEmptyString(updateRuleNewRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/{domain_name}/rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRuleNewRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateRuleNewResponse>(response);
        }

        public AsyncInvoker<UpdateRuleNewResponse> UpdateRuleNewAsyncInvoker(UpdateRuleNewRequest updateRuleNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRuleNewRequest.DomainName, out var valueOfDomainName)) urlParam.Add("domain_name", valueOfDomainName);
            if (StringUtils.TryConvertToNonEmptyString(updateRuleNewRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/{domain_name}/rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRuleNewRequest);
            return new AsyncInvoker<UpdateRuleNewResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateRuleNewResponse>);
        }
        
        /// <summary>
        /// 更新共享缓存组
        ///
        /// 更新共享缓存组。
        /// - 单租户调用频率：5次/s。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateShareCacheGroupsResponse> UpdateShareCacheGroupsAsync(UpdateShareCacheGroupsRequest updateShareCacheGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateShareCacheGroupsRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/share-cache-groups/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateShareCacheGroupsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateShareCacheGroupsResponse>(response);
        }

        public AsyncInvoker<UpdateShareCacheGroupsResponse> UpdateShareCacheGroupsAsyncInvoker(UpdateShareCacheGroupsRequest updateShareCacheGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateShareCacheGroupsRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/share-cache-groups/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateShareCacheGroupsRequest);
            return new AsyncInvoker<UpdateShareCacheGroupsResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateShareCacheGroupsResponse>);
        }
        
        /// <summary>
        /// 修改运营报表订阅任务
        ///
        /// modify subscription task
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateSubscriptionTaskResponse> UpdateSubscriptionTaskAsync(UpdateSubscriptionTaskRequest updateSubscriptionTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSubscriptionTaskRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/cdn/statistics/subscription-tasks/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSubscriptionTaskRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateSubscriptionTaskResponse>(response);
        }

        public AsyncInvoker<UpdateSubscriptionTaskResponse> UpdateSubscriptionTaskAsyncInvoker(UpdateSubscriptionTaskRequest updateSubscriptionTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateSubscriptionTaskRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/cdn/statistics/subscription-tasks/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSubscriptionTaskRequest);
            return new AsyncInvoker<UpdateSubscriptionTaskResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateSubscriptionTaskResponse>);
        }
        
        /// <summary>
        /// 域名归属校验
        ///
        /// 用于域名归属校验
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<VerifyDomainOwnerResponse> VerifyDomainOwnerAsync(VerifyDomainOwnerRequest verifyDomainOwnerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(verifyDomainOwnerRequest.DomainName, out var valueOfDomainName)) urlParam.Add("domain_name", valueOfDomainName);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/{domain_name}/verify-owner", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", verifyDomainOwnerRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<VerifyDomainOwnerResponse>(response);
        }

        public AsyncInvoker<VerifyDomainOwnerResponse> VerifyDomainOwnerAsyncInvoker(VerifyDomainOwnerRequest verifyDomainOwnerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(verifyDomainOwnerRequest.DomainName, out var valueOfDomainName)) urlParam.Add("domain_name", valueOfDomainName);
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/{domain_name}/verify-owner", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", verifyDomainOwnerRequest);
            return new AsyncInvoker<VerifyDomainOwnerResponse>(this, "POST", request, JsonUtils.DeSerialize<VerifyDomainOwnerResponse>);
        }
        
    }
}