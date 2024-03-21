using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Live.V1.Model;

namespace HuaweiCloud.SDK.Live.V1
{
    public partial class LiveClient : Client
    {
        public static ClientBuilder<LiveClient> NewBuilder()
        {
            return new ClientBuilder<LiveClient>();
        }

        
        /// <summary>
        /// 查询IP归属信息
        ///
        /// 查询IP归属信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchShowIpBelongsResponse BatchShowIpBelongs(BatchShowIpBelongsRequest batchShowIpBelongsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cdn/ip-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchShowIpBelongsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<BatchShowIpBelongsResponse>(response);
        }

        public SyncInvoker<BatchShowIpBelongsResponse> BatchShowIpBelongsInvoker(BatchShowIpBelongsRequest batchShowIpBelongsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cdn/ip-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchShowIpBelongsRequest);
            return new SyncInvoker<BatchShowIpBelongsResponse>(this, "GET", request, JsonUtils.DeSerialize<BatchShowIpBelongsResponse>);
        }
        
        /// <summary>
        /// 创建直播域名
        ///
        /// 可单独创建直播播放域名或推流域名，每个租户最多可配置64条域名记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDomainResponse CreateDomain(CreateDomainRequest createDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createDomainRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateDomainResponse>(response);
        }

        public SyncInvoker<CreateDomainResponse> CreateDomainInvoker(CreateDomainRequest createDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createDomainRequest);
            return new SyncInvoker<CreateDomainResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDomainResponse>);
        }
        
        /// <summary>
        /// 域名映射
        ///
        /// 将用户已创建的播放域名和推流域名建立域名映射关系
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateDomainMappingResponse CreateDomainMapping(CreateDomainMappingRequest createDomainMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domains_mapping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createDomainMappingRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<CreateDomainMappingResponse>(response);
        }

        public SyncInvoker<CreateDomainMappingResponse> CreateDomainMappingInvoker(CreateDomainMappingRequest createDomainMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domains_mapping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createDomainMappingRequest);
            return new SyncInvoker<CreateDomainMappingResponse>(this, "PUT", request, JsonUtils.DeSerialize<CreateDomainMappingResponse>);
        }
        
        /// <summary>
        /// 创建录制回调配置
        ///
        /// 创建录制回调配置接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRecordCallbackConfigResponse CreateRecordCallbackConfig(CreateRecordCallbackConfigRequest createRecordCallbackConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/callbacks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createRecordCallbackConfigRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateRecordCallbackConfigResponse>(response);
        }

        public SyncInvoker<CreateRecordCallbackConfigResponse> CreateRecordCallbackConfigInvoker(CreateRecordCallbackConfigRequest createRecordCallbackConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/callbacks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createRecordCallbackConfigRequest);
            return new SyncInvoker<CreateRecordCallbackConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRecordCallbackConfigResponse>);
        }
        
        /// <summary>
        /// 创建录制视频索引文件
        ///
        /// Create Record Index
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRecordIndexResponse CreateRecordIndex(CreateRecordIndexRequest createRecordIndexRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/indexes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createRecordIndexRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateRecordIndexResponse>(response);
        }

        public SyncInvoker<CreateRecordIndexResponse> CreateRecordIndexInvoker(CreateRecordIndexRequest createRecordIndexRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/indexes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createRecordIndexRequest);
            return new SyncInvoker<CreateRecordIndexResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRecordIndexResponse>);
        }
        
        /// <summary>
        /// 创建录制规则
        ///
        /// 创建录制规则接口，录制规则对新推送的流生效，对已经推送中的流不生效
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRecordRuleResponse CreateRecordRule(CreateRecordRuleRequest createRecordRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createRecordRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateRecordRuleResponse>(response);
        }

        public SyncInvoker<CreateRecordRuleResponse> CreateRecordRuleInvoker(CreateRecordRuleRequest createRecordRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createRecordRuleRequest);
            return new SyncInvoker<CreateRecordRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRecordRuleResponse>);
        }
        
        /// <summary>
        /// 创建直播截图配置
        ///
        /// 创建直播截图配置接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateSnapshotConfigResponse CreateSnapshotConfig(CreateSnapshotConfigRequest createSnapshotConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/snapshot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createSnapshotConfigRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateSnapshotConfigResponse>(response);
        }

        public SyncInvoker<CreateSnapshotConfigResponse> CreateSnapshotConfigInvoker(CreateSnapshotConfigRequest createSnapshotConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/snapshot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createSnapshotConfigRequest);
            return new SyncInvoker<CreateSnapshotConfigResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateSnapshotConfigResponse>);
        }
        
        /// <summary>
        /// 禁止直播推流
        ///
        /// 禁止直播推流
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateStreamForbiddenResponse CreateStreamForbidden(CreateStreamForbiddenRequest createStreamForbiddenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/blocks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createStreamForbiddenRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateStreamForbiddenResponse>(response);
        }

        public SyncInvoker<CreateStreamForbiddenResponse> CreateStreamForbiddenInvoker(CreateStreamForbiddenRequest createStreamForbiddenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/blocks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createStreamForbiddenRequest);
            return new SyncInvoker<CreateStreamForbiddenResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateStreamForbiddenResponse>);
        }
        
        /// <summary>
        /// 创建直播转码模板
        ///
        /// 创建直播转码模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateTranscodingsTemplateResponse CreateTranscodingsTemplate(CreateTranscodingsTemplateRequest createTranscodingsTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createTranscodingsTemplateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateTranscodingsTemplateResponse>(response);
        }

        public SyncInvoker<CreateTranscodingsTemplateResponse> CreateTranscodingsTemplateInvoker(CreateTranscodingsTemplateRequest createTranscodingsTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createTranscodingsTemplateRequest);
            return new SyncInvoker<CreateTranscodingsTemplateResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateTranscodingsTemplateResponse>);
        }
        
        /// <summary>
        /// 生成URL鉴权串
        ///
        /// 生成URL鉴权串
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateUrlAuthchainResponse CreateUrlAuthchain(CreateUrlAuthchainRequest createUrlAuthchainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/auth/chain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createUrlAuthchainRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateUrlAuthchainResponse>(response);
        }

        public SyncInvoker<CreateUrlAuthchainResponse> CreateUrlAuthchainInvoker(CreateUrlAuthchainRequest createUrlAuthchainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/auth/chain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createUrlAuthchainRequest);
            return new SyncInvoker<CreateUrlAuthchainResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateUrlAuthchainResponse>);
        }
        
        /// <summary>
        /// 删除直播域名
        ///
        /// 删除域名。只有在域名停用（off）状态时才能删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDomainResponse DeleteDomain(DeleteDomainRequest deleteDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDomainResponse>(response);
        }

        public SyncInvoker<DeleteDomainResponse> DeleteDomainInvoker(DeleteDomainRequest deleteDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainRequest);
            return new SyncInvoker<DeleteDomainResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDomainResponse>);
        }
        
        /// <summary>
        /// 删除指定域名的Key防盗链配置
        ///
        /// 删除指定域名的Key防盗链配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDomainKeyChainResponse DeleteDomainKeyChain(DeleteDomainKeyChainRequest deleteDomainKeyChainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/key-chain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainKeyChainRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDomainKeyChainResponse>(response);
        }

        public SyncInvoker<DeleteDomainKeyChainResponse> DeleteDomainKeyChainInvoker(DeleteDomainKeyChainRequest deleteDomainKeyChainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/key-chain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainKeyChainRequest);
            return new SyncInvoker<DeleteDomainKeyChainResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDomainKeyChainResponse>);
        }
        
        /// <summary>
        /// 删除直播域名映射关系
        ///
        /// 将播放域名和推流域名的域名映射关系删除
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDomainMappingResponse DeleteDomainMapping(DeleteDomainMappingRequest deleteDomainMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domains_mapping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainMappingRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDomainMappingResponse>(response);
        }

        public SyncInvoker<DeleteDomainMappingResponse> DeleteDomainMappingInvoker(DeleteDomainMappingRequest deleteDomainMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domains_mapping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainMappingRequest);
            return new SyncInvoker<DeleteDomainMappingResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDomainMappingResponse>);
        }
        
        /// <summary>
        /// 删除直播推流通知配置
        ///
        /// 删除直播推流通知配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePublishTemplateResponse DeletePublishTemplate(DeletePublishTemplateRequest deletePublishTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notifications/publish", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePublishTemplateRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePublishTemplateResponse>(response);
        }

        public SyncInvoker<DeletePublishTemplateResponse> DeletePublishTemplateInvoker(DeletePublishTemplateRequest deletePublishTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notifications/publish", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePublishTemplateRequest);
            return new SyncInvoker<DeletePublishTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePublishTemplateResponse>);
        }
        
        /// <summary>
        /// 删除录制回调配置
        ///
        /// 删除录制回调配置接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteRecordCallbackConfigResponse DeleteRecordCallbackConfig(DeleteRecordCallbackConfigRequest deleteRecordCallbackConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteRecordCallbackConfigRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/callbacks/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordCallbackConfigRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRecordCallbackConfigResponse>(response);
        }

        public SyncInvoker<DeleteRecordCallbackConfigResponse> DeleteRecordCallbackConfigInvoker(DeleteRecordCallbackConfigRequest deleteRecordCallbackConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteRecordCallbackConfigRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/callbacks/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordCallbackConfigRequest);
            return new SyncInvoker<DeleteRecordCallbackConfigResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRecordCallbackConfigResponse>);
        }
        
        /// <summary>
        /// 删除录制规则
        ///
        /// 删除录制规则接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteRecordRuleResponse DeleteRecordRule(DeleteRecordRuleRequest deleteRecordRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteRecordRuleRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/rules/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordRuleRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRecordRuleResponse>(response);
        }

        public SyncInvoker<DeleteRecordRuleResponse> DeleteRecordRuleInvoker(DeleteRecordRuleRequest deleteRecordRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteRecordRuleRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/rules/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordRuleRequest);
            return new SyncInvoker<DeleteRecordRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRecordRuleResponse>);
        }
        
        /// <summary>
        /// 删除直播截图配置
        ///
        /// 删除直播截图配置接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteSnapshotConfigResponse DeleteSnapshotConfig(DeleteSnapshotConfigRequest deleteSnapshotConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/snapshot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSnapshotConfigRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSnapshotConfigResponse>(response);
        }

        public SyncInvoker<DeleteSnapshotConfigResponse> DeleteSnapshotConfigInvoker(DeleteSnapshotConfigRequest deleteSnapshotConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/snapshot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSnapshotConfigRequest);
            return new SyncInvoker<DeleteSnapshotConfigResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSnapshotConfigResponse>);
        }
        
        /// <summary>
        /// 禁推恢复
        ///
        /// 恢复直播推流接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteStreamForbiddenResponse DeleteStreamForbidden(DeleteStreamForbiddenRequest deleteStreamForbiddenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/blocks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteStreamForbiddenRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteStreamForbiddenResponse>(response);
        }

        public SyncInvoker<DeleteStreamForbiddenResponse> DeleteStreamForbiddenInvoker(DeleteStreamForbiddenRequest deleteStreamForbiddenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/blocks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteStreamForbiddenRequest);
            return new SyncInvoker<DeleteStreamForbiddenResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteStreamForbiddenResponse>);
        }
        
        /// <summary>
        /// 删除直播转码模板
        ///
        /// 删除直播转码模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteTranscodingsTemplateResponse DeleteTranscodingsTemplate(DeleteTranscodingsTemplateRequest deleteTranscodingsTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTranscodingsTemplateRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTranscodingsTemplateResponse>(response);
        }

        public SyncInvoker<DeleteTranscodingsTemplateResponse> DeleteTranscodingsTemplateInvoker(DeleteTranscodingsTemplateRequest deleteTranscodingsTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTranscodingsTemplateRequest);
            return new SyncInvoker<DeleteTranscodingsTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTranscodingsTemplateResponse>);
        }
        
        /// <summary>
        /// 查询播放域名延时配置
        ///
        /// 查询播放域名延时配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListDelayConfigResponse ListDelayConfig(ListDelayConfigRequest listDelayConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/delay", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDelayConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListDelayConfigResponse>(response);
        }

        public SyncInvoker<ListDelayConfigResponse> ListDelayConfigInvoker(ListDelayConfigRequest listDelayConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/delay", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDelayConfigRequest);
            return new SyncInvoker<ListDelayConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDelayConfigResponse>);
        }
        
        /// <summary>
        /// 获取地域限制配置列表
        ///
        /// 查询播放域名的地域限制列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListGeoBlockingConfigResponse ListGeoBlockingConfig(ListGeoBlockingConfigRequest listGeoBlockingConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/geo-blocking", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGeoBlockingConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListGeoBlockingConfigResponse>(response);
        }

        public SyncInvoker<ListGeoBlockingConfigResponse> ListGeoBlockingConfigInvoker(ListGeoBlockingConfigRequest listGeoBlockingConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/geo-blocking", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGeoBlockingConfigRequest);
            return new SyncInvoker<ListGeoBlockingConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGeoBlockingConfigResponse>);
        }
        
        /// <summary>
        /// 查询IP黑/白名单
        ///
        /// 查询推流/播放域名的IP黑/白名单。
        /// - 黑名单模式：禁止指定的IP或网段
        /// - 白名单模式：仅允许指定的IP或网段
        /// - 默认：全放通。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListIpAuthListResponse ListIpAuthList(ListIpAuthListRequest listIpAuthListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpAuthListRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListIpAuthListResponse>(response);
        }

        public SyncInvoker<ListIpAuthListResponse> ListIpAuthListInvoker(ListIpAuthListRequest listIpAuthListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpAuthListRequest);
            return new SyncInvoker<ListIpAuthListResponse>(this, "GET", request, JsonUtils.DeSerialize<ListIpAuthListResponse>);
        }
        
        /// <summary>
        /// 获取直播播放日志
        ///
        /// 获取直播播放日志，基于域名以5分钟粒度进行打包，日志内容以 \&quot;|\&quot; 进行分隔。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLiveSampleLogsResponse ListLiveSampleLogs(ListLiveSampleLogsRequest listLiveSampleLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLiveSampleLogsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListLiveSampleLogsResponse>(response);
        }

        public SyncInvoker<ListLiveSampleLogsResponse> ListLiveSampleLogsInvoker(ListLiveSampleLogsRequest listLiveSampleLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLiveSampleLogsRequest);
            return new SyncInvoker<ListLiveSampleLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLiveSampleLogsResponse>);
        }
        
        /// <summary>
        /// 查询直播中的流信息
        ///
        /// 查询直播中的流信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListLiveStreamsOnlineResponse ListLiveStreamsOnline(ListLiveStreamsOnlineRequest listLiveStreamsOnlineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/realtime/streams", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLiveStreamsOnlineRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListLiveStreamsOnlineResponse>(response);
        }

        public SyncInvoker<ListLiveStreamsOnlineResponse> ListLiveStreamsOnlineInvoker(ListLiveStreamsOnlineRequest listLiveStreamsOnlineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/realtime/streams", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLiveStreamsOnlineRequest);
            return new SyncInvoker<ListLiveStreamsOnlineResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLiveStreamsOnlineResponse>);
        }
        
        /// <summary>
        /// 查询直播推流通知配置
        ///
        /// 查询直播推流通知配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPublishTemplateResponse ListPublishTemplate(ListPublishTemplateRequest listPublishTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notifications/publish", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublishTemplateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPublishTemplateResponse>(response);
        }

        public SyncInvoker<ListPublishTemplateResponse> ListPublishTemplateInvoker(ListPublishTemplateRequest listPublishTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notifications/publish", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublishTemplateRequest);
            return new SyncInvoker<ListPublishTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPublishTemplateResponse>);
        }
        
        /// <summary>
        /// 查询录制回调配置列表
        ///
        /// 查询录制回调配置列表接口。通过指定条件，查询满足条件的配置列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRecordCallbackConfigsResponse ListRecordCallbackConfigs(ListRecordCallbackConfigsRequest listRecordCallbackConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/callbacks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordCallbackConfigsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRecordCallbackConfigsResponse>(response);
        }

        public SyncInvoker<ListRecordCallbackConfigsResponse> ListRecordCallbackConfigsInvoker(ListRecordCallbackConfigsRequest listRecordCallbackConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/callbacks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordCallbackConfigsRequest);
            return new SyncInvoker<ListRecordCallbackConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRecordCallbackConfigsResponse>);
        }
        
        /// <summary>
        /// 录制完成内容的查询
        ///
        /// 录制完成的内容查询
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRecordContentsResponse ListRecordContents(ListRecordContentsRequest listRecordContentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/contents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordContentsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRecordContentsResponse>(response);
        }

        public SyncInvoker<ListRecordContentsResponse> ListRecordContentsInvoker(ListRecordContentsRequest listRecordContentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/contents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordContentsRequest);
            return new SyncInvoker<ListRecordContentsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRecordContentsResponse>);
        }
        
        /// <summary>
        /// 查询录制规则列表
        ///
        /// 查询录制规则列表接口，通过指定条件，查询满足条件的录制规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRecordRulesResponse ListRecordRules(ListRecordRulesRequest listRecordRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordRulesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRecordRulesResponse>(response);
        }

        public SyncInvoker<ListRecordRulesResponse> ListRecordRulesInvoker(ListRecordRulesRequest listRecordRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordRulesRequest);
            return new SyncInvoker<ListRecordRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRecordRulesResponse>);
        }
        
        /// <summary>
        /// 查询直播截图配置
        ///
        /// 查询直播截图配置接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListSnapshotConfigsResponse ListSnapshotConfigs(ListSnapshotConfigsRequest listSnapshotConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/snapshot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSnapshotConfigsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListSnapshotConfigsResponse>(response);
        }

        public SyncInvoker<ListSnapshotConfigsResponse> ListSnapshotConfigsInvoker(ListSnapshotConfigsRequest listSnapshotConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/snapshot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSnapshotConfigsRequest);
            return new SyncInvoker<ListSnapshotConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSnapshotConfigsResponse>);
        }
        
        /// <summary>
        /// 查询禁止直播推流列表
        ///
        /// 查询禁播黑名单列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListStreamForbiddenResponse ListStreamForbidden(ListStreamForbiddenRequest listStreamForbiddenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/blocks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStreamForbiddenRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListStreamForbiddenResponse>(response);
        }

        public SyncInvoker<ListStreamForbiddenResponse> ListStreamForbiddenInvoker(ListStreamForbiddenRequest listStreamForbiddenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/blocks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStreamForbiddenRequest);
            return new SyncInvoker<ListStreamForbiddenResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStreamForbiddenResponse>);
        }
        
        /// <summary>
        /// 提交录制控制命令
        ///
        /// 对单条流的实时录制控制接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunRecordResponse RunRecord(RunRecordRequest runRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/control", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", runRecordRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<RunRecordResponse>(response);
        }

        public SyncInvoker<RunRecordResponse> RunRecordInvoker(RunRecordRequest runRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/control", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", runRecordRequest);
            return new SyncInvoker<RunRecordResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RunRecordResponse>);
        }
        
        /// <summary>
        /// 查询直播域名
        ///
        /// 查询直播域名
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDomainResponse ShowDomain(ShowDomainRequest showDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainResponse>(response);
        }

        public SyncInvoker<ShowDomainResponse> ShowDomainInvoker(ShowDomainRequest showDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainRequest);
            return new SyncInvoker<ShowDomainResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainResponse>);
        }
        
        /// <summary>
        /// 查询指定域名的Key防盗链配置
        ///
        /// 查询指定域名的Key防盗链配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDomainKeyChainResponse ShowDomainKeyChain(ShowDomainKeyChainRequest showDomainKeyChainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/key-chain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainKeyChainRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainKeyChainResponse>(response);
        }

        public SyncInvoker<ShowDomainKeyChainResponse> ShowDomainKeyChainInvoker(ShowDomainKeyChainRequest showDomainKeyChainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/key-chain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainKeyChainRequest);
            return new SyncInvoker<ShowDomainKeyChainResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainKeyChainResponse>);
        }
        
        /// <summary>
        /// 查询直播拉流回源配置
        ///
        /// 查询直播拉流回源配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPullSourcesConfigResponse ShowPullSourcesConfig(ShowPullSourcesConfigRequest showPullSourcesConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/pull-sources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPullSourcesConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPullSourcesConfigResponse>(response);
        }

        public SyncInvoker<ShowPullSourcesConfigResponse> ShowPullSourcesConfigInvoker(ShowPullSourcesConfigRequest showPullSourcesConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/pull-sources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPullSourcesConfigRequest);
            return new SyncInvoker<ShowPullSourcesConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPullSourcesConfigResponse>);
        }
        
        /// <summary>
        /// 查询录制回调配置
        ///
        /// 查询录制回调配置接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRecordCallbackConfigResponse ShowRecordCallbackConfig(ShowRecordCallbackConfigRequest showRecordCallbackConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showRecordCallbackConfigRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/callbacks/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordCallbackConfigRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRecordCallbackConfigResponse>(response);
        }

        public SyncInvoker<ShowRecordCallbackConfigResponse> ShowRecordCallbackConfigInvoker(ShowRecordCallbackConfigRequest showRecordCallbackConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showRecordCallbackConfigRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/callbacks/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordCallbackConfigRequest);
            return new SyncInvoker<ShowRecordCallbackConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecordCallbackConfigResponse>);
        }
        
        /// <summary>
        /// 查询录制规则配置
        ///
        /// 查询录制规则接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRecordRuleResponse ShowRecordRule(ShowRecordRuleRequest showRecordRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showRecordRuleRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/rules/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordRuleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRecordRuleResponse>(response);
        }

        public SyncInvoker<ShowRecordRuleResponse> ShowRecordRuleInvoker(ShowRecordRuleRequest showRecordRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showRecordRuleRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/rules/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordRuleRequest);
            return new SyncInvoker<ShowRecordRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecordRuleResponse>);
        }
        
        /// <summary>
        /// 查询直播转码模板
        ///
        /// 查询直播转码模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTranscodingsTemplateResponse ShowTranscodingsTemplate(ShowTranscodingsTemplateRequest showTranscodingsTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTranscodingsTemplateRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTranscodingsTemplateResponse>(response);
        }

        public SyncInvoker<ShowTranscodingsTemplateResponse> ShowTranscodingsTemplateInvoker(ShowTranscodingsTemplateRequest showTranscodingsTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTranscodingsTemplateRequest);
            return new SyncInvoker<ShowTranscodingsTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTranscodingsTemplateResponse>);
        }
        
        /// <summary>
        /// 修改播放域名延时配置
        ///
        /// 修改播放域名延时配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDelayConfigResponse UpdateDelayConfig(UpdateDelayConfigRequest updateDelayConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/delay", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateDelayConfigRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateDelayConfigResponse>(response);
        }

        public SyncInvoker<UpdateDelayConfigResponse> UpdateDelayConfigInvoker(UpdateDelayConfigRequest updateDelayConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/delay", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateDelayConfigRequest);
            return new SyncInvoker<UpdateDelayConfigResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDelayConfigResponse>);
        }
        
        /// <summary>
        /// 修改直播域名
        ///
        /// 修改直播播放、RTMP推流加速域名相关信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDomainResponse UpdateDomain(UpdateDomainRequest updateDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateDomainRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDomainResponse>(response);
        }

        public SyncInvoker<UpdateDomainResponse> UpdateDomainInvoker(UpdateDomainRequest updateDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateDomainRequest);
            return new SyncInvoker<UpdateDomainResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDomainResponse>);
        }
        
        /// <summary>
        /// 配置域名IPV6开关
        ///
        /// 配置IPV6开关
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDomainIp6SwitchResponse UpdateDomainIp6Switch(UpdateDomainIp6SwitchRequest updateDomainIp6SwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/ipv6-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateDomainIp6SwitchRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateDomainIp6SwitchResponse>(response);
        }

        public SyncInvoker<UpdateDomainIp6SwitchResponse> UpdateDomainIp6SwitchInvoker(UpdateDomainIp6SwitchRequest updateDomainIp6SwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/ipv6-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateDomainIp6SwitchRequest);
            return new SyncInvoker<UpdateDomainIp6SwitchResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDomainIp6SwitchResponse>);
        }
        
        /// <summary>
        /// 更新指定域名的Key防盗链配置
        ///
        /// 更新指定域名的Key防盗链配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDomainKeyChainResponse UpdateDomainKeyChain(UpdateDomainKeyChainRequest updateDomainKeyChainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/key-chain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateDomainKeyChainRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateDomainKeyChainResponse>(response);
        }

        public SyncInvoker<UpdateDomainKeyChainResponse> UpdateDomainKeyChainInvoker(UpdateDomainKeyChainRequest updateDomainKeyChainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/key-chain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateDomainKeyChainRequest);
            return new SyncInvoker<UpdateDomainKeyChainResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDomainKeyChainResponse>);
        }
        
        /// <summary>
        /// 修改地域限制配置
        ///
        /// 修改播放域名的地域限制，选中地域允许接入。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateGeoBlockingConfigResponse UpdateGeoBlockingConfig(UpdateGeoBlockingConfigRequest updateGeoBlockingConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/geo-blocking", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateGeoBlockingConfigRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateGeoBlockingConfigResponse>(response);
        }

        public SyncInvoker<UpdateGeoBlockingConfigResponse> UpdateGeoBlockingConfigInvoker(UpdateGeoBlockingConfigRequest updateGeoBlockingConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/geo-blocking", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateGeoBlockingConfigRequest);
            return new SyncInvoker<UpdateGeoBlockingConfigResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateGeoBlockingConfigResponse>);
        }
        
        /// <summary>
        /// 修改IP黑/白名单
        ///
        /// 修改推流/播放域名的IP黑/白名单，当前仅支持ipv4。
        /// - 黑名单模式：禁止指定的IP或网段
        /// - 白名单模式：仅允许指定的IP或网段
        /// - 默认：全放通。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateIpAuthListResponse UpdateIpAuthList(UpdateIpAuthListRequest updateIpAuthListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateIpAuthListRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateIpAuthListResponse>(response);
        }

        public SyncInvoker<UpdateIpAuthListResponse> UpdateIpAuthListInvoker(UpdateIpAuthListRequest updateIpAuthListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateIpAuthListRequest);
            return new SyncInvoker<UpdateIpAuthListResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateIpAuthListResponse>);
        }
        
        /// <summary>
        /// 新增、覆盖直播推流通知配置
        ///
        /// 新增、覆盖直播推流通知配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePublishTemplateResponse UpdatePublishTemplate(UpdatePublishTemplateRequest updatePublishTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notifications/publish", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updatePublishTemplateRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdatePublishTemplateResponse>(response);
        }

        public SyncInvoker<UpdatePublishTemplateResponse> UpdatePublishTemplateInvoker(UpdatePublishTemplateRequest updatePublishTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notifications/publish", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updatePublishTemplateRequest);
            return new SyncInvoker<UpdatePublishTemplateResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdatePublishTemplateResponse>);
        }
        
        /// <summary>
        /// 修改直播拉流回源配置
        ///
        /// 修改直播拉流回源配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePullSourcesConfigResponse UpdatePullSourcesConfig(UpdatePullSourcesConfigRequest updatePullSourcesConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/pull-sources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updatePullSourcesConfigRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdatePullSourcesConfigResponse>(response);
        }

        public SyncInvoker<UpdatePullSourcesConfigResponse> UpdatePullSourcesConfigInvoker(UpdatePullSourcesConfigRequest updatePullSourcesConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/pull-sources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updatePullSourcesConfigRequest);
            return new SyncInvoker<UpdatePullSourcesConfigResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdatePullSourcesConfigResponse>);
        }
        
        /// <summary>
        /// 修改录制回调配置
        ///
        /// 修改录制回调配置接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRecordCallbackConfigResponse UpdateRecordCallbackConfig(UpdateRecordCallbackConfigRequest updateRecordCallbackConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateRecordCallbackConfigRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/callbacks/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateRecordCallbackConfigRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRecordCallbackConfigResponse>(response);
        }

        public SyncInvoker<UpdateRecordCallbackConfigResponse> UpdateRecordCallbackConfigInvoker(UpdateRecordCallbackConfigRequest updateRecordCallbackConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateRecordCallbackConfigRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/callbacks/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateRecordCallbackConfigRequest);
            return new SyncInvoker<UpdateRecordCallbackConfigResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRecordCallbackConfigResponse>);
        }
        
        /// <summary>
        /// 修改录制规则
        ///
        /// 修改录制规则接口，如果规则修改后，修改后的规则对正在录制的流无效，对新的流有效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRecordRuleResponse UpdateRecordRule(UpdateRecordRuleRequest updateRecordRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateRecordRuleRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/rules/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateRecordRuleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRecordRuleResponse>(response);
        }

        public SyncInvoker<UpdateRecordRuleResponse> UpdateRecordRuleInvoker(UpdateRecordRuleRequest updateRecordRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateRecordRuleRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/rules/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateRecordRuleRequest);
            return new SyncInvoker<UpdateRecordRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRecordRuleResponse>);
        }
        
        /// <summary>
        /// 修改直播截图配置
        ///
        /// 修改直播截图配置接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateSnapshotConfigResponse UpdateSnapshotConfig(UpdateSnapshotConfigRequest updateSnapshotConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/snapshot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateSnapshotConfigRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateSnapshotConfigResponse>(response);
        }

        public SyncInvoker<UpdateSnapshotConfigResponse> UpdateSnapshotConfigInvoker(UpdateSnapshotConfigRequest updateSnapshotConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/snapshot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateSnapshotConfigRequest);
            return new SyncInvoker<UpdateSnapshotConfigResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateSnapshotConfigResponse>);
        }
        
        /// <summary>
        /// 修改禁推属性
        ///
        /// 修改禁推属性
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateStreamForbiddenResponse UpdateStreamForbidden(UpdateStreamForbiddenRequest updateStreamForbiddenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/blocks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateStreamForbiddenRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateStreamForbiddenResponse>(response);
        }

        public SyncInvoker<UpdateStreamForbiddenResponse> UpdateStreamForbiddenInvoker(UpdateStreamForbiddenRequest updateStreamForbiddenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/blocks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateStreamForbiddenRequest);
            return new SyncInvoker<UpdateStreamForbiddenResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateStreamForbiddenResponse>);
        }
        
        /// <summary>
        /// 配置直播转码模板
        ///
        /// 修改直播转码模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateTranscodingsTemplateResponse UpdateTranscodingsTemplate(UpdateTranscodingsTemplateRequest updateTranscodingsTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateTranscodingsTemplateRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateTranscodingsTemplateResponse>(response);
        }

        public SyncInvoker<UpdateTranscodingsTemplateResponse> UpdateTranscodingsTemplateInvoker(UpdateTranscodingsTemplateRequest updateTranscodingsTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateTranscodingsTemplateRequest);
            return new SyncInvoker<UpdateTranscodingsTemplateResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateTranscodingsTemplateResponse>);
        }
        
        /// <summary>
        /// 删除指定域名的https证书配置
        ///
        /// 删除指定域名的https证书配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteDomainHttpsCertResponse DeleteDomainHttpsCert(DeleteDomainHttpsCertRequest deleteDomainHttpsCertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/https-cert", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainHttpsCertRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDomainHttpsCertResponse>(response);
        }

        public SyncInvoker<DeleteDomainHttpsCertResponse> DeleteDomainHttpsCertInvoker(DeleteDomainHttpsCertRequest deleteDomainHttpsCertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/https-cert", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainHttpsCertRequest);
            return new SyncInvoker<DeleteDomainHttpsCertResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDomainHttpsCertResponse>);
        }
        
        /// <summary>
        /// 查询指定域名的https证书配置
        ///
        /// 查询指定域名的https证书配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowDomainHttpsCertResponse ShowDomainHttpsCert(ShowDomainHttpsCertRequest showDomainHttpsCertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/https-cert", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainHttpsCertRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainHttpsCertResponse>(response);
        }

        public SyncInvoker<ShowDomainHttpsCertResponse> ShowDomainHttpsCertInvoker(ShowDomainHttpsCertRequest showDomainHttpsCertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/https-cert", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainHttpsCertRequest);
            return new SyncInvoker<ShowDomainHttpsCertResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainHttpsCertResponse>);
        }
        
        /// <summary>
        /// 修改指定域名的https证书配置
        ///
        /// 修改指定域名的https证书配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateDomainHttpsCertResponse UpdateDomainHttpsCert(UpdateDomainHttpsCertRequest updateDomainHttpsCertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/https-cert", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateDomainHttpsCertRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateDomainHttpsCertResponse>(response);
        }

        public SyncInvoker<UpdateDomainHttpsCertResponse> UpdateDomainHttpsCertInvoker(UpdateDomainHttpsCertRequest updateDomainHttpsCertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/https-cert", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateDomainHttpsCertRequest);
            return new SyncInvoker<UpdateDomainHttpsCertResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDomainHttpsCertResponse>);
        }
        
        /// <summary>
        /// OBS桶授权及取消授权
        ///
        /// OBS桶授权及取消授权
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateObsBucketAuthorityPublicResponse UpdateObsBucketAuthorityPublic(UpdateObsBucketAuthorityPublicRequest updateObsBucketAuthorityPublicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/obs/authority", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateObsBucketAuthorityPublicRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateObsBucketAuthorityPublicResponse>(response);
        }

        public SyncInvoker<UpdateObsBucketAuthorityPublicResponse> UpdateObsBucketAuthorityPublicInvoker(UpdateObsBucketAuthorityPublicRequest updateObsBucketAuthorityPublicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/obs/authority", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateObsBucketAuthorityPublicRequest);
            return new SyncInvoker<UpdateObsBucketAuthorityPublicResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateObsBucketAuthorityPublicResponse>);
        }
        
        /// <summary>
        /// 新建OTT频道
        ///
        /// 创建频道接口，支持创建OTT频道。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateOttChannelInfoResponse CreateOttChannelInfo(CreateOttChannelInfoRequest createOttChannelInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createOttChannelInfoRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateOttChannelInfoResponse>(response);
        }

        public SyncInvoker<CreateOttChannelInfoResponse> CreateOttChannelInfoInvoker(CreateOttChannelInfoRequest createOttChannelInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createOttChannelInfoRequest);
            return new SyncInvoker<CreateOttChannelInfoResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateOttChannelInfoResponse>);
        }
        
        /// <summary>
        /// 删除频道信息
        ///
        /// 删除频道信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteOttChannelInfoResponse DeleteOttChannelInfo(DeleteOttChannelInfoRequest deleteOttChannelInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOttChannelInfoRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteOttChannelInfoResponse>(response);
        }

        public SyncInvoker<DeleteOttChannelInfoResponse> DeleteOttChannelInfoInvoker(DeleteOttChannelInfoRequest deleteOttChannelInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOttChannelInfoRequest);
            return new SyncInvoker<DeleteOttChannelInfoResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteOttChannelInfoResponse>);
        }
        
        /// <summary>
        /// 查询频道信息
        ///
        /// 查询频道信息，支持批量查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListOttChannelInfoResponse ListOttChannelInfo(ListOttChannelInfoRequest listOttChannelInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOttChannelInfoRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListOttChannelInfoResponse>(response);
        }

        public SyncInvoker<ListOttChannelInfoResponse> ListOttChannelInfoInvoker(ListOttChannelInfoRequest listOttChannelInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOttChannelInfoRequest);
            return new SyncInvoker<ListOttChannelInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOttChannelInfoResponse>);
        }
        
        /// <summary>
        /// 修改频道转码模板信息
        ///
        /// 修改频道转码模板信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ModifyOttChannelInfoEncoderSettingsResponse ModifyOttChannelInfoEncoderSettings(ModifyOttChannelInfoEncoderSettingsRequest modifyOttChannelInfoEncoderSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels/encorder-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", modifyOttChannelInfoEncoderSettingsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ModifyOttChannelInfoEncoderSettingsResponse>(response);
        }

        public SyncInvoker<ModifyOttChannelInfoEncoderSettingsResponse> ModifyOttChannelInfoEncoderSettingsInvoker(ModifyOttChannelInfoEncoderSettingsRequest modifyOttChannelInfoEncoderSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels/encorder-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", modifyOttChannelInfoEncoderSettingsRequest);
            return new SyncInvoker<ModifyOttChannelInfoEncoderSettingsResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyOttChannelInfoEncoderSettingsResponse>);
        }
        
        /// <summary>
        /// 修改频道打包信息
        ///
        /// 修改频道打包信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ModifyOttChannelInfoEndPointsResponse ModifyOttChannelInfoEndPoints(ModifyOttChannelInfoEndPointsRequest modifyOttChannelInfoEndPointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels/endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", modifyOttChannelInfoEndPointsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ModifyOttChannelInfoEndPointsResponse>(response);
        }

        public SyncInvoker<ModifyOttChannelInfoEndPointsResponse> ModifyOttChannelInfoEndPointsInvoker(ModifyOttChannelInfoEndPointsRequest modifyOttChannelInfoEndPointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels/endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", modifyOttChannelInfoEndPointsRequest);
            return new SyncInvoker<ModifyOttChannelInfoEndPointsResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyOttChannelInfoEndPointsResponse>);
        }
        
        /// <summary>
        /// 修改频道通用信息
        ///
        /// 修改频道通用信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ModifyOttChannelInfoGeneralResponse ModifyOttChannelInfoGeneral(ModifyOttChannelInfoGeneralRequest modifyOttChannelInfoGeneralRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels/general", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", modifyOttChannelInfoGeneralRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ModifyOttChannelInfoGeneralResponse>(response);
        }

        public SyncInvoker<ModifyOttChannelInfoGeneralResponse> ModifyOttChannelInfoGeneralInvoker(ModifyOttChannelInfoGeneralRequest modifyOttChannelInfoGeneralRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels/general", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", modifyOttChannelInfoGeneralRequest);
            return new SyncInvoker<ModifyOttChannelInfoGeneralResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyOttChannelInfoGeneralResponse>);
        }
        
        /// <summary>
        /// 修改频道入流信息
        ///
        /// 修改频道入流信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ModifyOttChannelInfoInputResponse ModifyOttChannelInfoInput(ModifyOttChannelInfoInputRequest modifyOttChannelInfoInputRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels/input", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", modifyOttChannelInfoInputRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ModifyOttChannelInfoInputResponse>(response);
        }

        public SyncInvoker<ModifyOttChannelInfoInputResponse> ModifyOttChannelInfoInputInvoker(ModifyOttChannelInfoInputRequest modifyOttChannelInfoInputRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels/input", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", modifyOttChannelInfoInputRequest);
            return new SyncInvoker<ModifyOttChannelInfoInputResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyOttChannelInfoInputResponse>);
        }
        
        /// <summary>
        /// 修改频道录制信息
        ///
        /// 修改频道录制信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ModifyOttChannelInfoRecordSettingsResponse ModifyOttChannelInfoRecordSettings(ModifyOttChannelInfoRecordSettingsRequest modifyOttChannelInfoRecordSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels/record-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", modifyOttChannelInfoRecordSettingsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ModifyOttChannelInfoRecordSettingsResponse>(response);
        }

        public SyncInvoker<ModifyOttChannelInfoRecordSettingsResponse> ModifyOttChannelInfoRecordSettingsInvoker(ModifyOttChannelInfoRecordSettingsRequest modifyOttChannelInfoRecordSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels/record-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", modifyOttChannelInfoRecordSettingsRequest);
            return new SyncInvoker<ModifyOttChannelInfoRecordSettingsResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyOttChannelInfoRecordSettingsResponse>);
        }
        
        /// <summary>
        /// 修改频道状态
        ///
        /// 修改频道状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ModifyOttChannelInfoStatsResponse ModifyOttChannelInfoStats(ModifyOttChannelInfoStatsRequest modifyOttChannelInfoStatsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels/state", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", modifyOttChannelInfoStatsRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<ModifyOttChannelInfoStatsResponse>(response);
        }

        public SyncInvoker<ModifyOttChannelInfoStatsResponse> ModifyOttChannelInfoStatsInvoker(ModifyOttChannelInfoStatsRequest modifyOttChannelInfoStatsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels/state", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", modifyOttChannelInfoStatsRequest);
            return new SyncInvoker<ModifyOttChannelInfoStatsResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyOttChannelInfoStatsResponse>);
        }
        
    }
}