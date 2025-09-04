using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Cdn.V2.Model;

namespace HuaweiCloud.SDK.Cdn.V2
{
    public partial class CdnClient : Client
    {
        public static ClientBuilder<CdnClient> NewBuilder()
        {
            return new ClientBuilder<CdnClient>("GlobalCredentials");
        }

        
        /// <summary>
        /// 应用域名模板。
        ///
        /// 应用域名模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ApplyDomainTemplateResponse ApplyDomainTemplate(ApplyDomainTemplateRequest applyDomainTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("tml_id", applyDomainTemplateRequest.TmlId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/templates/{tml_id}/apply", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyDomainTemplateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ApplyDomainTemplateResponse>(response);
        }

        public SyncInvoker<ApplyDomainTemplateResponse> ApplyDomainTemplateInvoker(ApplyDomainTemplateRequest applyDomainTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("tml_id", applyDomainTemplateRequest.TmlId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/templates/{tml_id}/apply", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyDomainTemplateRequest);
            return new SyncInvoker<ApplyDomainTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<ApplyDomainTemplateResponse>);
        }
        
        /// <summary>
        /// 批量域名复制
        ///
        /// 批量域名复制接口。
        ///  &gt; 将某个加速域名的配置批量复制到其他域名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchCopyDomainResponse BatchCopyDomain(BatchCopyDomainRequest batchCopyDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/batch-copy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCopyDomainRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<BatchCopyDomainResponse>(response);
        }

        public SyncInvoker<BatchCopyDomainResponse> BatchCopyDomainInvoker(BatchCopyDomainRequest batchCopyDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/batch-copy", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCopyDomainRequest);
            return new SyncInvoker<BatchCopyDomainResponse>(this, "POST", request, JsonUtils.DeSerialize<BatchCopyDomainResponse>);
        }
        
        /// <summary>
        /// 删除资源标签配置接口
        ///
        /// 用于删除资源标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchDeleteTagsResponse BatchDeleteTags(BatchDeleteTagsRequest batchDeleteTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/tags/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchDeleteTagsResponse>(response);
        }

        public SyncInvoker<BatchDeleteTagsResponse> BatchDeleteTagsInvoker(BatchDeleteTagsRequest batchDeleteTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/tags/batch-delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteTagsRequest);
            return new SyncInvoker<BatchDeleteTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchDeleteTagsResponse>);
        }
        
        /// <summary>
        /// 批量更新规则状态及优先级
        ///
        /// 批量更新规则状态及优先级。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchUpdateRuleStatusResponse BatchUpdateRuleStatus(BatchUpdateRuleStatusRequest batchUpdateRuleStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", batchUpdateRuleStatusRequest.DomainName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/{domain_name}/rules/batch-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateRuleStatusRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<BatchUpdateRuleStatusResponse>(response);
        }

        public SyncInvoker<BatchUpdateRuleStatusResponse> BatchUpdateRuleStatusInvoker(BatchUpdateRuleStatusRequest batchUpdateRuleStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", batchUpdateRuleStatusRequest.DomainName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/{domain_name}/rules/batch-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchUpdateRuleStatusRequest);
            return new SyncInvoker<BatchUpdateRuleStatusResponse>(this, "POST", request, JsonUtils.DeSerializeNull<BatchUpdateRuleStatusResponse>);
        }
        
        /// <summary>
        /// 创建加速域名
        ///
        /// 创建加速域名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDomainResponse CreateDomain(CreateDomainRequest createDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDomainRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDomainResponse>(response);
        }

        public SyncInvoker<CreateDomainResponse> CreateDomainInvoker(CreateDomainRequest createDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDomainRequest);
            return new SyncInvoker<CreateDomainResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDomainResponse>);
        }
        
        /// <summary>
        /// 创建域名模板。
        ///
        /// 创建域名模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDomainTemplateResponse CreateDomainTemplate(CreateDomainTemplateRequest createDomainTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDomainTemplateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateDomainTemplateResponse>(response);
        }

        public SyncInvoker<CreateDomainTemplateResponse> CreateDomainTemplateInvoker(CreateDomainTemplateRequest createDomainTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDomainTemplateRequest);
            return new SyncInvoker<CreateDomainTemplateResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateDomainTemplateResponse>);
        }
        
        /// <summary>
        /// 创建预热缓存任务
        ///
        /// 创建预热任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePreheatingTasksResponse CreatePreheatingTasks(CreatePreheatingTasksRequest createPreheatingTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/content/preheating-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPreheatingTasksRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePreheatingTasksResponse>(response);
        }

        public SyncInvoker<CreatePreheatingTasksResponse> CreatePreheatingTasksInvoker(CreatePreheatingTasksRequest createPreheatingTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/content/preheating-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPreheatingTasksRequest);
            return new SyncInvoker<CreatePreheatingTasksResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePreheatingTasksResponse>);
        }
        
        /// <summary>
        /// 创建刷新缓存任务
        ///
        /// 创建刷新缓存任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRefreshTasksResponse CreateRefreshTasks(CreateRefreshTasksRequest createRefreshTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/content/refresh-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRefreshTasksRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateRefreshTasksResponse>(response);
        }

        public SyncInvoker<CreateRefreshTasksResponse> CreateRefreshTasksInvoker(CreateRefreshTasksRequest createRefreshTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/content/refresh-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRefreshTasksRequest);
            return new SyncInvoker<CreateRefreshTasksResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRefreshTasksResponse>);
        }
        
        /// <summary>
        /// 创建规则引擎规则
        ///
        /// 规则引擎功能通过图形化的方式实现各种规则配置，实现更加灵活、细粒度的规则配置。通过限制触发条件，控制当前配置生效的资源范围，满足多种场景的配置需求。
        /// - 请提交工单开通规则引擎功能后再使用当前接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRuleNewResponse CreateRuleNew(CreateRuleNewRequest createRuleNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", createRuleNewRequest.DomainName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/{domain_name}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRuleNewRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateRuleNewResponse>(response);
        }

        public SyncInvoker<CreateRuleNewResponse> CreateRuleNewInvoker(CreateRuleNewRequest createRuleNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", createRuleNewRequest.DomainName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/{domain_name}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRuleNewRequest);
            return new SyncInvoker<CreateRuleNewResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateRuleNewResponse>);
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
        public CreateShareCacheGroupsResponse CreateShareCacheGroups(CreateShareCacheGroupsRequest createShareCacheGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/share-cache-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createShareCacheGroupsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateShareCacheGroupsResponse>(response);
        }

        public SyncInvoker<CreateShareCacheGroupsResponse> CreateShareCacheGroupsInvoker(CreateShareCacheGroupsRequest createShareCacheGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/share-cache-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createShareCacheGroupsRequest);
            return new SyncInvoker<CreateShareCacheGroupsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateShareCacheGroupsResponse>);
        }
        
        /// <summary>
        /// 创建运营报表订阅任务
        ///
        /// create subscription task
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateSubscriptionTaskResponse CreateSubscriptionTask(CreateSubscriptionTaskRequest createSubscriptionTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cdn/statistics/subscription-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSubscriptionTaskRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateSubscriptionTaskResponse>(response);
        }

        public SyncInvoker<CreateSubscriptionTaskResponse> CreateSubscriptionTaskInvoker(CreateSubscriptionTaskRequest createSubscriptionTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cdn/statistics/subscription-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSubscriptionTaskRequest);
            return new SyncInvoker<CreateSubscriptionTaskResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateSubscriptionTaskResponse>);
        }
        
        /// <summary>
        /// 创建资源标签配置接口
        ///
        /// 用于创建资源标签。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTagsResponse CreateTags(CreateTagsRequest createTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateTagsResponse>(response);
        }

        public SyncInvoker<CreateTagsResponse> CreateTagsInvoker(CreateTagsRequest createTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createTagsRequest);
            return new SyncInvoker<CreateTagsResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateTagsResponse>);
        }
        
        /// <summary>
        /// 删除加速域名
        ///
        /// 删除加速域名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDomainResponse DeleteDomain(DeleteDomainRequest deleteDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", deleteDomainRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteDomainResponse>(response);
        }

        public SyncInvoker<DeleteDomainResponse> DeleteDomainInvoker(DeleteDomainRequest deleteDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", deleteDomainRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainRequest);
            return new SyncInvoker<DeleteDomainResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteDomainResponse>);
        }
        
        /// <summary>
        /// 删除域名模板。
        ///
        /// 删除域名模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDomainTemplateResponse DeleteDomainTemplate(DeleteDomainTemplateRequest deleteDomainTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("tml_id", deleteDomainTemplateRequest.TmlId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/templates/{tml_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainTemplateRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDomainTemplateResponse>(response);
        }

        public SyncInvoker<DeleteDomainTemplateResponse> DeleteDomainTemplateInvoker(DeleteDomainTemplateRequest deleteDomainTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("tml_id", deleteDomainTemplateRequest.TmlId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/templates/{tml_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainTemplateRequest);
            return new SyncInvoker<DeleteDomainTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDomainTemplateResponse>);
        }
        
        /// <summary>
        /// 删除规则引擎规则
        ///
        /// 删除规则引擎规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteRuleNewResponse DeleteRuleNew(DeleteRuleNewRequest deleteRuleNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", deleteRuleNewRequest.DomainName.ToString());
            urlParam.Add("rule_id", deleteRuleNewRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/{domain_name}/rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRuleNewRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRuleNewResponse>(response);
        }

        public SyncInvoker<DeleteRuleNewResponse> DeleteRuleNewInvoker(DeleteRuleNewRequest deleteRuleNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", deleteRuleNewRequest.DomainName.ToString());
            urlParam.Add("rule_id", deleteRuleNewRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/{domain_name}/rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRuleNewRequest);
            return new SyncInvoker<DeleteRuleNewResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRuleNewResponse>);
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
        public DeleteShareCacheGroupsResponse DeleteShareCacheGroups(DeleteShareCacheGroupsRequest deleteShareCacheGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteShareCacheGroupsRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/share-cache-groups/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteShareCacheGroupsRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteShareCacheGroupsResponse>(response);
        }

        public SyncInvoker<DeleteShareCacheGroupsResponse> DeleteShareCacheGroupsInvoker(DeleteShareCacheGroupsRequest deleteShareCacheGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteShareCacheGroupsRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/share-cache-groups/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteShareCacheGroupsRequest);
            return new SyncInvoker<DeleteShareCacheGroupsResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteShareCacheGroupsResponse>);
        }
        
        /// <summary>
        /// 删除运营报表订阅任务
        ///
        /// delete subscription task
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSubscriptionTaskResponse DeleteSubscriptionTask(DeleteSubscriptionTaskRequest deleteSubscriptionTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteSubscriptionTaskRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/cdn/statistics/subscription-tasks/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubscriptionTaskRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSubscriptionTaskResponse>(response);
        }

        public SyncInvoker<DeleteSubscriptionTaskResponse> DeleteSubscriptionTaskInvoker(DeleteSubscriptionTaskRequest deleteSubscriptionTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteSubscriptionTaskRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/cdn/statistics/subscription-tasks/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubscriptionTaskRequest);
            return new SyncInvoker<DeleteSubscriptionTaskResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSubscriptionTaskResponse>);
        }
        
        /// <summary>
        /// 停用加速域名
        ///
        /// 停用加速域名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DisableDomainResponse DisableDomain(DisableDomainRequest disableDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", disableDomainRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableDomainRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<DisableDomainResponse>(response);
        }

        public SyncInvoker<DisableDomainResponse> DisableDomainInvoker(DisableDomainRequest disableDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", disableDomainRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/disable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableDomainRequest);
            return new SyncInvoker<DisableDomainResponse>(this, "PUT", request, JsonUtils.DeSerialize<DisableDomainResponse>);
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
        public DownloadRegionCarrierExcelResponse DownloadRegionCarrierExcel(DownloadRegionCarrierExcelRequest downloadRegionCarrierExcelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/region-carrier-excel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadRegionCarrierExcelRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerializeNull<DownloadRegionCarrierExcelResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<DownloadRegionCarrierExcelResponse> DownloadRegionCarrierExcelInvoker(DownloadRegionCarrierExcelRequest downloadRegionCarrierExcelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/region-carrier-excel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadRegionCarrierExcelRequest);
            return new SyncInvoker<DownloadRegionCarrierExcelResponse>(this, "GET", request, JsonUtils.DeSerializeNull<DownloadRegionCarrierExcelResponse>);
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
        public DownloadStatisticsExcelResponse DownloadStatisticsExcel(DownloadStatisticsExcelRequest downloadStatisticsExcelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/statistics-excel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadStatisticsExcelRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerializeNull<DownloadStatisticsExcelResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<DownloadStatisticsExcelResponse> DownloadStatisticsExcelInvoker(DownloadStatisticsExcelRequest downloadStatisticsExcelRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/statistics-excel", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", downloadStatisticsExcelRequest);
            return new SyncInvoker<DownloadStatisticsExcelResponse>(this, "GET", request, JsonUtils.DeSerializeNull<DownloadStatisticsExcelResponse>);
        }
        
        /// <summary>
        /// 启用加速域名
        ///
        /// 启用加速域名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public EnableDomainResponse EnableDomain(EnableDomainRequest enableDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", enableDomainRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableDomainRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<EnableDomainResponse>(response);
        }

        public SyncInvoker<EnableDomainResponse> EnableDomainInvoker(EnableDomainRequest enableDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", enableDomainRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/enable", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableDomainRequest);
            return new SyncInvoker<EnableDomainResponse>(this, "PUT", request, JsonUtils.DeSerialize<EnableDomainResponse>);
        }
        
        /// <summary>
        /// 查询域名top ip统计分析数据
        ///
        /// - 查询域名top ip统计分析数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCdnDomainTopIpsResponse ListCdnDomainTopIps(ListCdnDomainTopIpsRequest listCdnDomainTopIpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/top-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCdnDomainTopIpsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCdnDomainTopIpsResponse>(response);
        }

        public SyncInvoker<ListCdnDomainTopIpsResponse> ListCdnDomainTopIpsInvoker(ListCdnDomainTopIpsRequest listCdnDomainTopIpsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/top-ips", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCdnDomainTopIpsRequest);
            return new SyncInvoker<ListCdnDomainTopIpsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCdnDomainTopIpsResponse>);
        }
        
        /// <summary>
        /// 查询域名top回源URL数据
        ///
        /// - 查询域名top 回源URL数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCdnDomainTopOriginUrlResponse ListCdnDomainTopOriginUrl(ListCdnDomainTopOriginUrlRequest listCdnDomainTopOriginUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/top-origin-urls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCdnDomainTopOriginUrlRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCdnDomainTopOriginUrlResponse>(response);
        }

        public SyncInvoker<ListCdnDomainTopOriginUrlResponse> ListCdnDomainTopOriginUrlInvoker(ListCdnDomainTopOriginUrlRequest listCdnDomainTopOriginUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/top-origin-urls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCdnDomainTopOriginUrlRequest);
            return new SyncInvoker<ListCdnDomainTopOriginUrlResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCdnDomainTopOriginUrlResponse>);
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
        public ListCdnDomainTopRefersResponse ListCdnDomainTopRefers(ListCdnDomainTopRefersRequest listCdnDomainTopRefersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/top-refers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCdnDomainTopRefersRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCdnDomainTopRefersResponse>(response);
        }

        public SyncInvoker<ListCdnDomainTopRefersResponse> ListCdnDomainTopRefersInvoker(ListCdnDomainTopRefersRequest listCdnDomainTopRefersRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/top-refers", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCdnDomainTopRefersRequest);
            return new SyncInvoker<ListCdnDomainTopRefersResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCdnDomainTopRefersResponse>);
        }
        
        /// <summary>
        /// 查询域名top ua统计分析数据
        ///
        /// - 统计分析TOP UA统计数据
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListCdnDomainTopUasResponse ListCdnDomainTopUas(ListCdnDomainTopUasRequest listCdnDomainTopUasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/top-uas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCdnDomainTopUasRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListCdnDomainTopUasResponse>(response);
        }

        public SyncInvoker<ListCdnDomainTopUasResponse> ListCdnDomainTopUasInvoker(ListCdnDomainTopUasRequest listCdnDomainTopUasRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/top-uas", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCdnDomainTopUasRequest);
            return new SyncInvoker<ListCdnDomainTopUasResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCdnDomainTopUasResponse>);
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
        public ListDomainClientStatsResponse ListDomainClientStats(ListDomainClientStatsRequest listDomainClientStatsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-client-stats", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainClientStatsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDomainClientStatsResponse>(response);
        }

        public SyncInvoker<ListDomainClientStatsResponse> ListDomainClientStatsInvoker(ListDomainClientStatsRequest listDomainClientStatsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-client-stats", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainClientStatsRequest);
            return new SyncInvoker<ListDomainClientStatsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainClientStatsResponse>);
        }
        
        /// <summary>
        /// 查询加速域名
        ///
        /// 查询加速域名。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDomainsResponse ListDomains(ListDomainsRequest listDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDomainsResponse>(response);
        }

        public SyncInvoker<ListDomainsResponse> ListDomainsInvoker(ListDomainsRequest listDomainsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainsRequest);
            return new SyncInvoker<ListDomainsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDomainsResponse>);
        }
        
        /// <summary>
        /// 查询规则引擎列表
        ///
        /// 查询规则引擎列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRuleDetailsResponse ListRuleDetails(ListRuleDetailsRequest listRuleDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", listRuleDetailsRequest.DomainName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/{domain_name}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRuleDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRuleDetailsResponse>(response);
        }

        public SyncInvoker<ListRuleDetailsResponse> ListRuleDetailsInvoker(ListRuleDetailsRequest listRuleDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", listRuleDetailsRequest.DomainName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/{domain_name}/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRuleDetailsRequest);
            return new SyncInvoker<ListRuleDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRuleDetailsResponse>);
        }
        
        /// <summary>
        /// 查询共享缓存组列表
        ///
        /// 查询共享缓存组列表。
        /// - 单租户调用频率：5次/s。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListShareCacheGroupsResponse ListShareCacheGroups(ListShareCacheGroupsRequest listShareCacheGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/share-cache-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listShareCacheGroupsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListShareCacheGroupsResponse>(response);
        }

        public SyncInvoker<ListShareCacheGroupsResponse> ListShareCacheGroupsInvoker(ListShareCacheGroupsRequest listShareCacheGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/share-cache-groups", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listShareCacheGroupsRequest);
            return new SyncInvoker<ListShareCacheGroupsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListShareCacheGroupsResponse>);
        }
        
        /// <summary>
        /// 分页查询运营报表订阅任务
        ///
        /// query subscription task
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSubscriptionTasksResponse ListSubscriptionTasks(ListSubscriptionTasksRequest listSubscriptionTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cdn/statistics/subscription-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubscriptionTasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSubscriptionTasksResponse>(response);
        }

        public SyncInvoker<ListSubscriptionTasksResponse> ListSubscriptionTasksInvoker(ListSubscriptionTasksRequest listSubscriptionTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cdn/statistics/subscription-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubscriptionTasksRequest);
            return new SyncInvoker<ListSubscriptionTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSubscriptionTasksResponse>);
        }
        
        /// <summary>
        /// 修改租户配置
        ///
        /// 修改租户配置，当前仅支持开启OBS和SCM委托授权。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ModifyAccountInfoResponse ModifyAccountInfo(ModifyAccountInfoRequest modifyAccountInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/account-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyAccountInfoRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<ModifyAccountInfoResponse>(response);
        }

        public SyncInvoker<ModifyAccountInfoResponse> ModifyAccountInfoInvoker(ModifyAccountInfoRequest modifyAccountInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/account-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyAccountInfoRequest);
            return new SyncInvoker<ModifyAccountInfoResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<ModifyAccountInfoResponse>);
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
        public SetChargeModesResponse SetChargeModes(SetChargeModesRequest setChargeModesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/charge/charge-modes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setChargeModesRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<SetChargeModesResponse>(response);
        }

        public SyncInvoker<SetChargeModesResponse> SetChargeModesInvoker(SetChargeModesRequest setChargeModesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/charge/charge-modes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setChargeModesRequest);
            return new SyncInvoker<SetChargeModesResponse>(this, "PUT", request, JsonUtils.DeSerialize<SetChargeModesResponse>);
        }
        
        /// <summary>
        /// 设置统计配置
        ///
        /// - 设置统计配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SetStatsConfigResponse SetStatsConfig(SetStatsConfigRequest setStatsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cdn/statistics/stats-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setStatsConfigRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<SetStatsConfigResponse>(response);
        }

        public SyncInvoker<SetStatsConfigResponse> SetStatsConfigInvoker(SetStatsConfigRequest setStatsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cdn/statistics/stats-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", setStatsConfigRequest);
            return new SyncInvoker<SetStatsConfigResponse>(this, "POST", request, JsonUtils.DeSerializeNull<SetStatsConfigResponse>);
        }
        
        /// <summary>
        /// 查询域名模板应用记录。
        ///
        /// 查询域名模板应用记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowAppliedTemplateRecordResponse ShowAppliedTemplateRecord(ShowAppliedTemplateRecordRequest showAppliedTemplateRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/tml-apply-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppliedTemplateRecordRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowAppliedTemplateRecordResponse>(response);
        }

        public SyncInvoker<ShowAppliedTemplateRecordResponse> ShowAppliedTemplateRecordInvoker(ShowAppliedTemplateRecordRequest showAppliedTemplateRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/tml-apply-records", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAppliedTemplateRecordRequest);
            return new SyncInvoker<ShowAppliedTemplateRecordResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowAppliedTemplateRecordResponse>);
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
        public ShowBandwidthCalcResponse ShowBandwidthCalc(ShowBandwidthCalcRequest showBandwidthCalcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/bandwidth-calc", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBandwidthCalcRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBandwidthCalcResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<ShowBandwidthCalcResponse> ShowBandwidthCalcInvoker(ShowBandwidthCalcRequest showBandwidthCalcRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/bandwidth-calc", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBandwidthCalcRequest);
            return new SyncInvoker<ShowBandwidthCalcResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBandwidthCalcResponse>);
        }
        
        /// <summary>
        /// 查询所有绑定HTTPS证书的域名信息
        ///
        /// 查询所有绑定HTTPS证书的域名信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowCertificatesHttpsInfoResponse ShowCertificatesHttpsInfo(ShowCertificatesHttpsInfoRequest showCertificatesHttpsInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/https-certificate-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCertificatesHttpsInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowCertificatesHttpsInfoResponse>(response);
        }

        public SyncInvoker<ShowCertificatesHttpsInfoResponse> ShowCertificatesHttpsInfoInvoker(ShowCertificatesHttpsInfoRequest showCertificatesHttpsInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/https-certificate-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCertificatesHttpsInfoRequest);
            return new SyncInvoker<ShowCertificatesHttpsInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowCertificatesHttpsInfoResponse>);
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
        public ShowChargeModesResponse ShowChargeModes(ShowChargeModesRequest showChargeModesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/charge/charge-modes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showChargeModesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowChargeModesResponse>(response);
        }

        public SyncInvoker<ShowChargeModesResponse> ShowChargeModesInvoker(ShowChargeModesRequest showChargeModesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/charge/charge-modes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showChargeModesRequest);
            return new SyncInvoker<ShowChargeModesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowChargeModesResponse>);
        }
        
        /// <summary>
        /// 查询加速域名详情
        ///
        /// 加速域名详情信息接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDomainDetailByNameResponse ShowDomainDetailByName(ShowDomainDetailByNameRequest showDomainDetailByNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", showDomainDetailByNameRequest.DomainName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/{domain_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainDetailByNameRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainDetailByNameResponse>(response);
        }

        public SyncInvoker<ShowDomainDetailByNameResponse> ShowDomainDetailByNameInvoker(ShowDomainDetailByNameRequest showDomainDetailByNameRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", showDomainDetailByNameRequest.DomainName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/{domain_name}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainDetailByNameRequest);
            return new SyncInvoker<ShowDomainDetailByNameResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainDetailByNameResponse>);
        }
        
        /// <summary>
        /// 查询域名配置接口
        ///
        /// 查询域名配置接口，支持查询业务类型、服务范围、备注、IPv6开关、回源方式、回源URL改写、高级回源、Range回源、回源跟随、回源是否校验Etag、回源超时时间、回源请求头、HTTPS配置、TLS版本配置、强制跳转、HSTS、HTTP/2、OCSP Stapling、QUIC、缓存规则、状态码缓存时间、防盗链、IP黑白名单、 Use-Agent黑白名单、URL鉴权配置、远程鉴权配置、IP访问限频、HTTP header配置、自定义错误页面配置、智能压缩、请求限速配置、WebSocket配置、视频拖拽、回源SNI、访问URL重写、浏览器缓存过期时间、区域访问控制。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDomainFullConfigResponse ShowDomainFullConfig(ShowDomainFullConfigRequest showDomainFullConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", showDomainFullConfigRequest.DomainName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.1/cdn/configuration/domains/{domain_name}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainFullConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainFullConfigResponse>(response);
        }

        public SyncInvoker<ShowDomainFullConfigResponse> ShowDomainFullConfigInvoker(ShowDomainFullConfigRequest showDomainFullConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", showDomainFullConfigRequest.DomainName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.1/cdn/configuration/domains/{domain_name}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainFullConfigRequest);
            return new SyncInvoker<ShowDomainFullConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainFullConfigResponse>);
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
        public ShowDomainLocationStatsResponse ShowDomainLocationStats(ShowDomainLocationStatsRequest showDomainLocationStatsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-location-stats", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainLocationStatsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainLocationStatsResponse>(response);
        }

        public SyncInvoker<ShowDomainLocationStatsResponse> ShowDomainLocationStatsInvoker(ShowDomainLocationStatsRequest showDomainLocationStatsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-location-stats", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainLocationStatsRequest);
            return new SyncInvoker<ShowDomainLocationStatsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainLocationStatsResponse>);
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
        public ShowDomainStatsResponse ShowDomainStats(ShowDomainStatsRequest showDomainStatsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-stats", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainStatsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainStatsResponse>(response);
        }

        public SyncInvoker<ShowDomainStatsResponse> ShowDomainStatsInvoker(ShowDomainStatsRequest showDomainStatsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-stats", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainStatsRequest);
            return new SyncInvoker<ShowDomainStatsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainStatsResponse>);
        }
        
        /// <summary>
        /// 查询域名模板列表
        ///
        /// 查询域名模板列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDomainTemplateResponse ShowDomainTemplate(ShowDomainTemplateRequest showDomainTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainTemplateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainTemplateResponse>(response);
        }

        public SyncInvoker<ShowDomainTemplateResponse> ShowDomainTemplateInvoker(ShowDomainTemplateRequest showDomainTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainTemplateRequest);
            return new SyncInvoker<ShowDomainTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainTemplateResponse>);
        }
        
        /// <summary>
        /// 查询刷新预热任务详情
        ///
        /// 查询刷新预热任务详情。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowHistoryTaskDetailsResponse ShowHistoryTaskDetails(ShowHistoryTaskDetailsRequest showHistoryTaskDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("history_tasks_id", showHistoryTaskDetailsRequest.HistoryTasksId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/historytasks/{history_tasks_id}/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHistoryTaskDetailsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowHistoryTaskDetailsResponse>(response);
        }

        public SyncInvoker<ShowHistoryTaskDetailsResponse> ShowHistoryTaskDetailsInvoker(ShowHistoryTaskDetailsRequest showHistoryTaskDetailsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("history_tasks_id", showHistoryTaskDetailsRequest.HistoryTasksId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/historytasks/{history_tasks_id}/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHistoryTaskDetailsRequest);
            return new SyncInvoker<ShowHistoryTaskDetailsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHistoryTaskDetailsResponse>);
        }
        
        /// <summary>
        /// 查询刷新预热任务
        ///
        /// 查询刷新预热任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowHistoryTasksResponse ShowHistoryTasks(ShowHistoryTasksRequest showHistoryTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/historytasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHistoryTasksRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowHistoryTasksResponse>(response);
        }

        public SyncInvoker<ShowHistoryTasksResponse> ShowHistoryTasksInvoker(ShowHistoryTasksRequest showHistoryTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/historytasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHistoryTasksRequest);
            return new SyncInvoker<ShowHistoryTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowHistoryTasksResponse>);
        }
        
        /// <summary>
        /// 查询IP归属信息
        ///
        /// 查询IP归属信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowIpInfoResponse ShowIpInfo(ShowIpInfoRequest showIpInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/ip-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowIpInfoResponse>(response);
        }

        public SyncInvoker<ShowIpInfoResponse> ShowIpInfoInvoker(ShowIpInfoRequest showIpInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/ip-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpInfoRequest);
            return new SyncInvoker<ShowIpInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowIpInfoResponse>);
        }
        
        /// <summary>
        /// 日志查询
        ///
        /// 查询日志下载链接，支持查询30天内的日志信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowLogsResponse ShowLogs(ShowLogsRequest showLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowLogsResponse>(response);
        }

        public SyncInvoker<ShowLogsResponse> ShowLogsInvoker(ShowLogsRequest showLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogsRequest);
            return new SyncInvoker<ShowLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowLogsResponse>);
        }
        
        /// <summary>
        /// 查询用户配额
        ///
        /// 查询当前用户域名、刷新文件、刷新目录和预热的配额
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowQuotaResponse ShowQuota(ShowQuotaRequest showQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowQuotaResponse>(response);
        }

        public SyncInvoker<ShowQuotaResponse> ShowQuotaInvoker(ShowQuotaRequest showQuotaRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/quota", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaRequest);
            return new SyncInvoker<ShowQuotaResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowQuotaResponse>);
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
        public ShowStatsConfigsResponse ShowStatsConfigs(ShowStatsConfigsRequest showStatsConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cdn/statistics/stats-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatsConfigsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowStatsConfigsResponse>(response);
        }

        public SyncInvoker<ShowStatsConfigsResponse> ShowStatsConfigsInvoker(ShowStatsConfigsRequest showStatsConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cdn/statistics/stats-configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStatsConfigsRequest);
            return new SyncInvoker<ShowStatsConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStatsConfigsResponse>);
        }
        
        /// <summary>
        /// 查询资源标签列表配置接口
        ///
        /// 用于查询资源标签列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTagsResponse ShowTags(ShowTagsRequest showTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTagsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTagsResponse>(response);
        }

        public SyncInvoker<ShowTagsResponse> ShowTagsInvoker(ShowTagsRequest showTagsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/tags", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTagsRequest);
            return new SyncInvoker<ShowTagsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTagsResponse>);
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
        public ShowTopDomainNamesResponse ShowTopDomainNames(ShowTopDomainNamesRequest showTopDomainNamesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cdn/statistics/top-domain-names", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopDomainNamesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTopDomainNamesResponse>(response);
        }

        [Obsolete("This method is deprecated and will be removed in the future versions")]
        public SyncInvoker<ShowTopDomainNamesResponse> ShowTopDomainNamesInvoker(ShowTopDomainNamesRequest showTopDomainNamesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/cdn/statistics/top-domain-names", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopDomainNamesRequest);
            return new SyncInvoker<ShowTopDomainNamesResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTopDomainNamesResponse>);
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
        public ShowTopUrlResponse ShowTopUrl(ShowTopUrlRequest showTopUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/top-url", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopUrlRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTopUrlResponse>(response);
        }

        public SyncInvoker<ShowTopUrlResponse> ShowTopUrlInvoker(ShowTopUrlRequest showTopUrlRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/top-url", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopUrlRequest);
            return new SyncInvoker<ShowTopUrlResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTopUrlResponse>);
        }
        
        /// <summary>
        /// 查询刷新预热URL记录
        ///
        /// 查询刷新预热URL记录。如需此接口，请提交工单开通。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowUrlTaskInfoResponse ShowUrlTaskInfo(ShowUrlTaskInfoRequest showUrlTaskInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/contentgateway/url-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUrlTaskInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowUrlTaskInfoResponse>(response);
        }

        public SyncInvoker<ShowUrlTaskInfoResponse> ShowUrlTaskInfoInvoker(ShowUrlTaskInfoRequest showUrlTaskInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/contentgateway/url-tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showUrlTaskInfoRequest);
            return new SyncInvoker<ShowUrlTaskInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowUrlTaskInfoResponse>);
        }
        
        /// <summary>
        /// 查询域名归属校验信息
        ///
        /// 用于查询域名归属校验信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowVerifyDomainOwnerInfoResponse ShowVerifyDomainOwnerInfo(ShowVerifyDomainOwnerInfoRequest showVerifyDomainOwnerInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", showVerifyDomainOwnerInfoRequest.DomainName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/{domain_name}/domain-verifies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVerifyDomainOwnerInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowVerifyDomainOwnerInfoResponse>(response);
        }

        public SyncInvoker<ShowVerifyDomainOwnerInfoResponse> ShowVerifyDomainOwnerInfoInvoker(ShowVerifyDomainOwnerInfoRequest showVerifyDomainOwnerInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", showVerifyDomainOwnerInfoRequest.DomainName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/{domain_name}/domain-verifies", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVerifyDomainOwnerInfoRequest);
            return new SyncInvoker<ShowVerifyDomainOwnerInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowVerifyDomainOwnerInfoResponse>);
        }
        
        /// <summary>
        /// 修改域名全量配置接口
        ///
        /// 修改域名配置接口，支持修改业务类型、服务范围、备注、IPv6开关、回源方式、回源URL改写、高级回源、Range回源、回源跟随、回源是否校验Etag、回源超时时间、回源请求头、HTTPS配置、TLS版本配置、强制跳转、HSTS、HTTP/2、OCSP Stapling、QUIC、缓存规则、状态码缓存时间、防盗链、IP黑白名单、Use-Agent黑白名单、URL鉴权配置、远程鉴权配置、IP访问限频、HTTP header配置、自定义错误页面配置、智能压缩、请求限速配置、WebSocket配置、视频拖拽、回源SNI、访问URL重写、浏览器缓存过期时间、区域访问控制。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDomainFullConfigResponse UpdateDomainFullConfig(UpdateDomainFullConfigRequest updateDomainFullConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", updateDomainFullConfigRequest.DomainName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.1/cdn/configuration/domains/{domain_name}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainFullConfigRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateDomainFullConfigResponse>(response);
        }

        public SyncInvoker<UpdateDomainFullConfigResponse> UpdateDomainFullConfigInvoker(UpdateDomainFullConfigRequest updateDomainFullConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", updateDomainFullConfigRequest.DomainName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.1/cdn/configuration/domains/{domain_name}/configs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainFullConfigRequest);
            return new SyncInvoker<UpdateDomainFullConfigResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDomainFullConfigResponse>);
        }
        
        /// <summary>
        /// 一个证书批量设置多个域名
        ///
        /// 一个证书配置多个域名，设置域名强制https回源参数。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDomainMultiCertificatesResponse UpdateDomainMultiCertificates(UpdateDomainMultiCertificatesRequest updateDomainMultiCertificatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/config-https-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainMultiCertificatesRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDomainMultiCertificatesResponse>(response);
        }

        public SyncInvoker<UpdateDomainMultiCertificatesResponse> UpdateDomainMultiCertificatesInvoker(UpdateDomainMultiCertificatesRequest updateDomainMultiCertificatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/config-https-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainMultiCertificatesRequest);
            return new SyncInvoker<UpdateDomainMultiCertificatesResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDomainMultiCertificatesResponse>);
        }
        
        /// <summary>
        /// 修改域名模板。
        ///
        /// 修改域名模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDomainTemplateResponse UpdateDomainTemplate(UpdateDomainTemplateRequest updateDomainTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("tml_id", updateDomainTemplateRequest.TmlId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/templates/{tml_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainTemplateRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateDomainTemplateResponse>(response);
        }

        public SyncInvoker<UpdateDomainTemplateResponse> UpdateDomainTemplateInvoker(UpdateDomainTemplateRequest updateDomainTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("tml_id", updateDomainTemplateRequest.TmlId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/templates/{tml_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainTemplateRequest);
            return new SyncInvoker<UpdateDomainTemplateResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDomainTemplateResponse>);
        }
        
        /// <summary>
        /// 全量更新规则引擎规则
        ///
        /// 全量更新规则引擎规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateFullRuleResponse UpdateFullRule(UpdateFullRuleRequest updateFullRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", updateFullRuleRequest.DomainName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/{domain_name}/rules/full-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFullRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateFullRuleResponse>(response);
        }

        public SyncInvoker<UpdateFullRuleResponse> UpdateFullRuleInvoker(UpdateFullRuleRequest updateFullRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", updateFullRuleRequest.DomainName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/{domain_name}/rules/full-update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFullRuleRequest);
            return new SyncInvoker<UpdateFullRuleResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateFullRuleResponse>);
        }
        
        /// <summary>
        /// 修改私有桶开启关闭状态
        ///
        /// 修改私有桶开启关闭状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePrivateBucketAccessResponse UpdatePrivateBucketAccess(UpdatePrivateBucketAccessRequest updatePrivateBucketAccessRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updatePrivateBucketAccessRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/private-bucket-access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateBucketAccessRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePrivateBucketAccessResponse>(response);
        }

        public SyncInvoker<UpdatePrivateBucketAccessResponse> UpdatePrivateBucketAccessInvoker(UpdatePrivateBucketAccessRequest updatePrivateBucketAccessRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id", updatePrivateBucketAccessRequest.DomainId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/private-bucket-access", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateBucketAccessRequest);
            return new SyncInvoker<UpdatePrivateBucketAccessResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePrivateBucketAccessResponse>);
        }
        
        /// <summary>
        /// 更新规则引擎规则
        ///
        /// 更新规则引擎规则。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRuleNewResponse UpdateRuleNew(UpdateRuleNewRequest updateRuleNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", updateRuleNewRequest.DomainName.ToString());
            urlParam.Add("rule_id", updateRuleNewRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/{domain_name}/rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRuleNewRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateRuleNewResponse>(response);
        }

        public SyncInvoker<UpdateRuleNewResponse> UpdateRuleNewInvoker(UpdateRuleNewRequest updateRuleNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", updateRuleNewRequest.DomainName.ToString());
            urlParam.Add("rule_id", updateRuleNewRequest.RuleId.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/{domain_name}/rules/{rule_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRuleNewRequest);
            return new SyncInvoker<UpdateRuleNewResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateRuleNewResponse>);
        }
        
        /// <summary>
        /// 更新共享缓存组
        ///
        /// 更新共享缓存组。
        /// - 单租户调用频率：5次/s。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateShareCacheGroupsResponse UpdateShareCacheGroups(UpdateShareCacheGroupsRequest updateShareCacheGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateShareCacheGroupsRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/share-cache-groups/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateShareCacheGroupsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateShareCacheGroupsResponse>(response);
        }

        public SyncInvoker<UpdateShareCacheGroupsResponse> UpdateShareCacheGroupsInvoker(UpdateShareCacheGroupsRequest updateShareCacheGroupsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateShareCacheGroupsRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/share-cache-groups/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateShareCacheGroupsRequest);
            return new SyncInvoker<UpdateShareCacheGroupsResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateShareCacheGroupsResponse>);
        }
        
        /// <summary>
        /// 修改运营报表订阅任务
        ///
        /// modify subscription task
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateSubscriptionTaskResponse UpdateSubscriptionTask(UpdateSubscriptionTaskRequest updateSubscriptionTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateSubscriptionTaskRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/cdn/statistics/subscription-tasks/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSubscriptionTaskRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateSubscriptionTaskResponse>(response);
        }

        public SyncInvoker<UpdateSubscriptionTaskResponse> UpdateSubscriptionTaskInvoker(UpdateSubscriptionTaskRequest updateSubscriptionTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateSubscriptionTaskRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/cdn/statistics/subscription-tasks/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSubscriptionTaskRequest);
            return new SyncInvoker<UpdateSubscriptionTaskResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateSubscriptionTaskResponse>);
        }
        
        /// <summary>
        /// 域名归属校验
        ///
        /// 用于域名归属校验
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public VerifyDomainOwnerResponse VerifyDomainOwner(VerifyDomainOwnerRequest verifyDomainOwnerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", verifyDomainOwnerRequest.DomainName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/{domain_name}/verify-owner", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", verifyDomainOwnerRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<VerifyDomainOwnerResponse>(response);
        }

        public SyncInvoker<VerifyDomainOwnerResponse> VerifyDomainOwnerInvoker(VerifyDomainOwnerRequest verifyDomainOwnerRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name", verifyDomainOwnerRequest.DomainName.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/configuration/domains/{domain_name}/verify-owner", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", verifyDomainOwnerRequest);
            return new SyncInvoker<VerifyDomainOwnerResponse>(this, "POST", request, JsonUtils.DeSerialize<VerifyDomainOwnerResponse>);
        }
        
    }
}