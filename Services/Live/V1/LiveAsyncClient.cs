using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Live.V1.Model;

namespace HuaweiCloud.SDK.Live.V1
{
    public partial class LiveAsyncClient : Client
    {
        public static ClientBuilder<LiveAsyncClient> NewBuilder()
        {
            return new ClientBuilder<LiveAsyncClient>();
        }

        
        /// <summary>
        /// 查询IP归属信息
        ///
        /// 查询IP归属信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchShowIpBelongsResponse> BatchShowIpBelongsAsync(BatchShowIpBelongsRequest batchShowIpBelongsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cdn/ip-info",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchShowIpBelongsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<BatchShowIpBelongsResponse>(response);
        }

        public AsyncInvoker<BatchShowIpBelongsResponse> BatchShowIpBelongsAsyncInvoker(BatchShowIpBelongsRequest batchShowIpBelongsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cdn/ip-info",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchShowIpBelongsRequest);
            return new AsyncInvoker<BatchShowIpBelongsResponse>(this, "GET", request, JsonUtils.DeSerialize<BatchShowIpBelongsResponse>);
        }
        
        /// <summary>
        /// 创建直播域名
        ///
        /// 可单独创建直播播放域名或推流域名，每个租户最多可配置64条域名记录。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest createDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createDomainRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateDomainResponse>(response);
        }

        public AsyncInvoker<CreateDomainResponse> CreateDomainAsyncInvoker(CreateDomainRequest createDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createDomainRequest);
            return new AsyncInvoker<CreateDomainResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateDomainResponse>);
        }
        
        /// <summary>
        /// 域名映射
        ///
        /// 将用户已创建的播放域名和推流域名建立域名映射关系
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateDomainMappingResponse> CreateDomainMappingAsync(CreateDomainMappingRequest createDomainMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domains_mapping",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createDomainMappingRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<CreateDomainMappingResponse>(response);
        }

        public AsyncInvoker<CreateDomainMappingResponse> CreateDomainMappingAsyncInvoker(CreateDomainMappingRequest createDomainMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domains_mapping",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createDomainMappingRequest);
            return new AsyncInvoker<CreateDomainMappingResponse>(this, "PUT", request, JsonUtils.DeSerialize<CreateDomainMappingResponse>);
        }
        
        /// <summary>
        /// 创建录制回调配置
        ///
        /// 创建录制回调配置接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRecordCallbackConfigResponse> CreateRecordCallbackConfigAsync(CreateRecordCallbackConfigRequest createRecordCallbackConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/callbacks",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createRecordCallbackConfigRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateRecordCallbackConfigResponse>(response);
        }

        public AsyncInvoker<CreateRecordCallbackConfigResponse> CreateRecordCallbackConfigAsyncInvoker(CreateRecordCallbackConfigRequest createRecordCallbackConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/callbacks",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createRecordCallbackConfigRequest);
            return new AsyncInvoker<CreateRecordCallbackConfigResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRecordCallbackConfigResponse>);
        }
        
        /// <summary>
        /// 创建录制视频索引文件
        ///
        /// Create Record Index
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRecordIndexResponse> CreateRecordIndexAsync(CreateRecordIndexRequest createRecordIndexRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/indexes",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createRecordIndexRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateRecordIndexResponse>(response);
        }

        public AsyncInvoker<CreateRecordIndexResponse> CreateRecordIndexAsyncInvoker(CreateRecordIndexRequest createRecordIndexRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/indexes",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createRecordIndexRequest);
            return new AsyncInvoker<CreateRecordIndexResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRecordIndexResponse>);
        }
        
        /// <summary>
        /// 创建录制规则
        ///
        /// 创建录制规则接口，录制规则对新推送的流生效，对已经推送中的流不生效
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRecordRuleResponse> CreateRecordRuleAsync(CreateRecordRuleRequest createRecordRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/rules",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createRecordRuleRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateRecordRuleResponse>(response);
        }

        public AsyncInvoker<CreateRecordRuleResponse> CreateRecordRuleAsyncInvoker(CreateRecordRuleRequest createRecordRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/rules",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createRecordRuleRequest);
            return new AsyncInvoker<CreateRecordRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRecordRuleResponse>);
        }
        
        /// <summary>
        /// 创建直播截图配置
        ///
        /// 创建直播截图配置接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateSnapshotConfigResponse> CreateSnapshotConfigAsync(CreateSnapshotConfigRequest createSnapshotConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/snapshot",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createSnapshotConfigRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateSnapshotConfigResponse>(response);
        }

        public AsyncInvoker<CreateSnapshotConfigResponse> CreateSnapshotConfigAsyncInvoker(CreateSnapshotConfigRequest createSnapshotConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/snapshot",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createSnapshotConfigRequest);
            return new AsyncInvoker<CreateSnapshotConfigResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateSnapshotConfigResponse>);
        }
        
        /// <summary>
        /// 禁止直播推流
        ///
        /// 禁止直播推流
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateStreamForbiddenResponse> CreateStreamForbiddenAsync(CreateStreamForbiddenRequest createStreamForbiddenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/blocks",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createStreamForbiddenRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateStreamForbiddenResponse>(response);
        }

        public AsyncInvoker<CreateStreamForbiddenResponse> CreateStreamForbiddenAsyncInvoker(CreateStreamForbiddenRequest createStreamForbiddenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/blocks",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createStreamForbiddenRequest);
            return new AsyncInvoker<CreateStreamForbiddenResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateStreamForbiddenResponse>);
        }
        
        /// <summary>
        /// 创建直播转码模板
        ///
        /// 创建直播转码模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateTranscodingsTemplateResponse> CreateTranscodingsTemplateAsync(CreateTranscodingsTemplateRequest createTranscodingsTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createTranscodingsTemplateRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateTranscodingsTemplateResponse>(response);
        }

        public AsyncInvoker<CreateTranscodingsTemplateResponse> CreateTranscodingsTemplateAsyncInvoker(CreateTranscodingsTemplateRequest createTranscodingsTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createTranscodingsTemplateRequest);
            return new AsyncInvoker<CreateTranscodingsTemplateResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateTranscodingsTemplateResponse>);
        }
        
        /// <summary>
        /// 删除直播域名
        ///
        /// 删除域名。只有在域名停用（off）状态时才能删除。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest deleteDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteDomainResponse>(response);
        }

        public AsyncInvoker<DeleteDomainResponse> DeleteDomainAsyncInvoker(DeleteDomainRequest deleteDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainRequest);
            return new AsyncInvoker<DeleteDomainResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDomainResponse>);
        }
        
        /// <summary>
        /// 删除指定域名的Key防盗链配置
        ///
        /// 删除指定域名的Key防盗链配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDomainKeyChainResponse> DeleteDomainKeyChainAsync(DeleteDomainKeyChainRequest deleteDomainKeyChainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/key-chain",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainKeyChainRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteDomainKeyChainResponse>(response);
        }

        public AsyncInvoker<DeleteDomainKeyChainResponse> DeleteDomainKeyChainAsyncInvoker(DeleteDomainKeyChainRequest deleteDomainKeyChainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/key-chain",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainKeyChainRequest);
            return new AsyncInvoker<DeleteDomainKeyChainResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDomainKeyChainResponse>);
        }
        
        /// <summary>
        /// 删除直播域名映射关系
        ///
        /// 将播放域名和推流域名的域名映射关系删除
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDomainMappingResponse> DeleteDomainMappingAsync(DeleteDomainMappingRequest deleteDomainMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domains_mapping",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainMappingRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteDomainMappingResponse>(response);
        }

        public AsyncInvoker<DeleteDomainMappingResponse> DeleteDomainMappingAsyncInvoker(DeleteDomainMappingRequest deleteDomainMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domains_mapping",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainMappingRequest);
            return new AsyncInvoker<DeleteDomainMappingResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDomainMappingResponse>);
        }
        
        /// <summary>
        /// 删除录制回调配置
        ///
        /// 删除录制回调配置接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRecordCallbackConfigResponse> DeleteRecordCallbackConfigAsync(DeleteRecordCallbackConfigRequest deleteRecordCallbackConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteRecordCallbackConfigRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/callbacks/{id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordCallbackConfigRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteRecordCallbackConfigResponse>(response);
        }

        public AsyncInvoker<DeleteRecordCallbackConfigResponse> DeleteRecordCallbackConfigAsyncInvoker(DeleteRecordCallbackConfigRequest deleteRecordCallbackConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteRecordCallbackConfigRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/callbacks/{id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordCallbackConfigRequest);
            return new AsyncInvoker<DeleteRecordCallbackConfigResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRecordCallbackConfigResponse>);
        }
        
        /// <summary>
        /// 删除录制规则
        ///
        /// 删除录制规则接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRecordRuleResponse> DeleteRecordRuleAsync(DeleteRecordRuleRequest deleteRecordRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteRecordRuleRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/rules/{id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordRuleRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteRecordRuleResponse>(response);
        }

        public AsyncInvoker<DeleteRecordRuleResponse> DeleteRecordRuleAsyncInvoker(DeleteRecordRuleRequest deleteRecordRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", deleteRecordRuleRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/rules/{id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordRuleRequest);
            return new AsyncInvoker<DeleteRecordRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRecordRuleResponse>);
        }
        
        /// <summary>
        /// 删除直播截图配置
        ///
        /// 删除直播截图配置接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteSnapshotConfigResponse> DeleteSnapshotConfigAsync(DeleteSnapshotConfigRequest deleteSnapshotConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/snapshot",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSnapshotConfigRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSnapshotConfigResponse>(response);
        }

        public AsyncInvoker<DeleteSnapshotConfigResponse> DeleteSnapshotConfigAsyncInvoker(DeleteSnapshotConfigRequest deleteSnapshotConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/snapshot",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSnapshotConfigRequest);
            return new AsyncInvoker<DeleteSnapshotConfigResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteSnapshotConfigResponse>);
        }
        
        /// <summary>
        /// 禁推恢复
        ///
        /// 恢复直播推流接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteStreamForbiddenResponse> DeleteStreamForbiddenAsync(DeleteStreamForbiddenRequest deleteStreamForbiddenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/blocks",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteStreamForbiddenRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteStreamForbiddenResponse>(response);
        }

        public AsyncInvoker<DeleteStreamForbiddenResponse> DeleteStreamForbiddenAsyncInvoker(DeleteStreamForbiddenRequest deleteStreamForbiddenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/blocks",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteStreamForbiddenRequest);
            return new AsyncInvoker<DeleteStreamForbiddenResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteStreamForbiddenResponse>);
        }
        
        /// <summary>
        /// 删除直播转码模板
        ///
        /// 删除直播转码模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTranscodingsTemplateResponse> DeleteTranscodingsTemplateAsync(DeleteTranscodingsTemplateRequest deleteTranscodingsTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTranscodingsTemplateRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTranscodingsTemplateResponse>(response);
        }

        public AsyncInvoker<DeleteTranscodingsTemplateResponse> DeleteTranscodingsTemplateAsyncInvoker(DeleteTranscodingsTemplateRequest deleteTranscodingsTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTranscodingsTemplateRequest);
            return new AsyncInvoker<DeleteTranscodingsTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTranscodingsTemplateResponse>);
        }
        
        /// <summary>
        /// 获取直播播放日志
        ///
        /// 获取直播播放日志，基于域名以5分钟粒度进行打包，日志内容以 \&quot;|\&quot; 进行分隔。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLiveSampleLogsResponse> ListLiveSampleLogsAsync(ListLiveSampleLogsRequest listLiveSampleLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/logs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLiveSampleLogsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListLiveSampleLogsResponse>(response);
        }

        public AsyncInvoker<ListLiveSampleLogsResponse> ListLiveSampleLogsAsyncInvoker(ListLiveSampleLogsRequest listLiveSampleLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/logs",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLiveSampleLogsRequest);
            return new AsyncInvoker<ListLiveSampleLogsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLiveSampleLogsResponse>);
        }
        
        /// <summary>
        /// 查询直播中的流信息
        ///
        /// 查询直播中的流信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListLiveStreamsOnlineResponse> ListLiveStreamsOnlineAsync(ListLiveStreamsOnlineRequest listLiveStreamsOnlineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/realtime/streams",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLiveStreamsOnlineRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListLiveStreamsOnlineResponse>(response);
        }

        public AsyncInvoker<ListLiveStreamsOnlineResponse> ListLiveStreamsOnlineAsyncInvoker(ListLiveStreamsOnlineRequest listLiveStreamsOnlineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/realtime/streams",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLiveStreamsOnlineRequest);
            return new AsyncInvoker<ListLiveStreamsOnlineResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLiveStreamsOnlineResponse>);
        }
        
        /// <summary>
        /// 查询录制回调配置列表
        ///
        /// 查询录制回调配置列表接口。通过指定条件，查询满足条件的配置列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRecordCallbackConfigsResponse> ListRecordCallbackConfigsAsync(ListRecordCallbackConfigsRequest listRecordCallbackConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/callbacks",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordCallbackConfigsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListRecordCallbackConfigsResponse>(response);
        }

        public AsyncInvoker<ListRecordCallbackConfigsResponse> ListRecordCallbackConfigsAsyncInvoker(ListRecordCallbackConfigsRequest listRecordCallbackConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/callbacks",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordCallbackConfigsRequest);
            return new AsyncInvoker<ListRecordCallbackConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRecordCallbackConfigsResponse>);
        }
        
        /// <summary>
        /// 录制完成内容的查询
        ///
        /// 录制完成的内容查询
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRecordContentsResponse> ListRecordContentsAsync(ListRecordContentsRequest listRecordContentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/contents",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordContentsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListRecordContentsResponse>(response);
        }

        public AsyncInvoker<ListRecordContentsResponse> ListRecordContentsAsyncInvoker(ListRecordContentsRequest listRecordContentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/contents",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordContentsRequest);
            return new AsyncInvoker<ListRecordContentsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRecordContentsResponse>);
        }
        
        /// <summary>
        /// 查询录制规则列表
        ///
        /// 查询录制规则列表接口，通过指定条件，查询满足条件的录制规则列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRecordRulesResponse> ListRecordRulesAsync(ListRecordRulesRequest listRecordRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/rules",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordRulesRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListRecordRulesResponse>(response);
        }

        public AsyncInvoker<ListRecordRulesResponse> ListRecordRulesAsyncInvoker(ListRecordRulesRequest listRecordRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/rules",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordRulesRequest);
            return new AsyncInvoker<ListRecordRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRecordRulesResponse>);
        }
        
        /// <summary>
        /// 查询直播截图配置
        ///
        /// 查询直播截图配置接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListSnapshotConfigsResponse> ListSnapshotConfigsAsync(ListSnapshotConfigsRequest listSnapshotConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/snapshot",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSnapshotConfigsRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSnapshotConfigsResponse>(response);
        }

        public AsyncInvoker<ListSnapshotConfigsResponse> ListSnapshotConfigsAsyncInvoker(ListSnapshotConfigsRequest listSnapshotConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/snapshot",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSnapshotConfigsRequest);
            return new AsyncInvoker<ListSnapshotConfigsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListSnapshotConfigsResponse>);
        }
        
        /// <summary>
        /// 查询禁止直播推流列表
        ///
        /// 查询禁播黑名单列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListStreamForbiddenResponse> ListStreamForbiddenAsync(ListStreamForbiddenRequest listStreamForbiddenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/blocks",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStreamForbiddenRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListStreamForbiddenResponse>(response);
        }

        public AsyncInvoker<ListStreamForbiddenResponse> ListStreamForbiddenAsyncInvoker(ListStreamForbiddenRequest listStreamForbiddenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/blocks",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStreamForbiddenRequest);
            return new AsyncInvoker<ListStreamForbiddenResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStreamForbiddenResponse>);
        }
        
        /// <summary>
        /// 提交录制控制命令
        ///
        /// 对单条流的实时录制控制接口。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunRecordResponse> RunRecordAsync(RunRecordRequest runRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/control",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", runRecordRequest);
            var response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<RunRecordResponse>(response);
        }

        public AsyncInvoker<RunRecordResponse> RunRecordAsyncInvoker(RunRecordRequest runRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/control",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", runRecordRequest);
            return new AsyncInvoker<RunRecordResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RunRecordResponse>);
        }
        
        /// <summary>
        /// 查询直播域名
        ///
        /// 查询直播域名
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainResponse> ShowDomainAsync(ShowDomainRequest showDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainResponse>(response);
        }

        public AsyncInvoker<ShowDomainResponse> ShowDomainAsyncInvoker(ShowDomainRequest showDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainRequest);
            return new AsyncInvoker<ShowDomainResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainResponse>);
        }
        
        /// <summary>
        /// 查询指定域名的Key防盗链配置
        ///
        /// 查询指定域名的Key防盗链配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainKeyChainResponse> ShowDomainKeyChainAsync(ShowDomainKeyChainRequest showDomainKeyChainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/key-chain",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainKeyChainRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainKeyChainResponse>(response);
        }

        public AsyncInvoker<ShowDomainKeyChainResponse> ShowDomainKeyChainAsyncInvoker(ShowDomainKeyChainRequest showDomainKeyChainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/key-chain",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainKeyChainRequest);
            return new AsyncInvoker<ShowDomainKeyChainResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainKeyChainResponse>);
        }
        
        /// <summary>
        /// 查询录制回调配置
        ///
        /// 查询录制回调配置接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRecordCallbackConfigResponse> ShowRecordCallbackConfigAsync(ShowRecordCallbackConfigRequest showRecordCallbackConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showRecordCallbackConfigRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/callbacks/{id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordCallbackConfigRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowRecordCallbackConfigResponse>(response);
        }

        public AsyncInvoker<ShowRecordCallbackConfigResponse> ShowRecordCallbackConfigAsyncInvoker(ShowRecordCallbackConfigRequest showRecordCallbackConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showRecordCallbackConfigRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/callbacks/{id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordCallbackConfigRequest);
            return new AsyncInvoker<ShowRecordCallbackConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecordCallbackConfigResponse>);
        }
        
        /// <summary>
        /// 查询录制规则配置
        ///
        /// 查询录制规则接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRecordRuleResponse> ShowRecordRuleAsync(ShowRecordRuleRequest showRecordRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showRecordRuleRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/rules/{id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordRuleRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowRecordRuleResponse>(response);
        }

        public AsyncInvoker<ShowRecordRuleResponse> ShowRecordRuleAsyncInvoker(ShowRecordRuleRequest showRecordRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", showRecordRuleRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/rules/{id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordRuleRequest);
            return new AsyncInvoker<ShowRecordRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecordRuleResponse>);
        }
        
        /// <summary>
        /// 查询直播转码模板
        ///
        /// 查询直播转码模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTranscodingsTemplateResponse> ShowTranscodingsTemplateAsync(ShowTranscodingsTemplateRequest showTranscodingsTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTranscodingsTemplateRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowTranscodingsTemplateResponse>(response);
        }

        public AsyncInvoker<ShowTranscodingsTemplateResponse> ShowTranscodingsTemplateAsyncInvoker(ShowTranscodingsTemplateRequest showTranscodingsTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTranscodingsTemplateRequest);
            return new AsyncInvoker<ShowTranscodingsTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTranscodingsTemplateResponse>);
        }
        
        /// <summary>
        /// 修改直播域名
        ///
        /// 修改直播播放、RTMP推流加速域名相关信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDomainResponse> UpdateDomainAsync(UpdateDomainRequest updateDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateDomainRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDomainResponse>(response);
        }

        public AsyncInvoker<UpdateDomainResponse> UpdateDomainAsyncInvoker(UpdateDomainRequest updateDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateDomainRequest);
            return new AsyncInvoker<UpdateDomainResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateDomainResponse>);
        }
        
        /// <summary>
        /// 配置域名IPV6开关
        ///
        /// 配置IPV6开关
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDomainIp6SwitchResponse> UpdateDomainIp6SwitchAsync(UpdateDomainIp6SwitchRequest updateDomainIp6SwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/ipv6-switch",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateDomainIp6SwitchRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateDomainIp6SwitchResponse>(response);
        }

        public AsyncInvoker<UpdateDomainIp6SwitchResponse> UpdateDomainIp6SwitchAsyncInvoker(UpdateDomainIp6SwitchRequest updateDomainIp6SwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/ipv6-switch",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateDomainIp6SwitchRequest);
            return new AsyncInvoker<UpdateDomainIp6SwitchResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDomainIp6SwitchResponse>);
        }
        
        /// <summary>
        /// 更新指定域名的Key防盗链配置
        ///
        /// 更新指定域名的Key防盗链配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDomainKeyChainResponse> UpdateDomainKeyChainAsync(UpdateDomainKeyChainRequest updateDomainKeyChainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/key-chain",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateDomainKeyChainRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateDomainKeyChainResponse>(response);
        }

        public AsyncInvoker<UpdateDomainKeyChainResponse> UpdateDomainKeyChainAsyncInvoker(UpdateDomainKeyChainRequest updateDomainKeyChainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/key-chain",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateDomainKeyChainRequest);
            return new AsyncInvoker<UpdateDomainKeyChainResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDomainKeyChainResponse>);
        }
        
        /// <summary>
        /// 修改录制回调配置
        ///
        /// 修改录制回调配置接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRecordCallbackConfigResponse> UpdateRecordCallbackConfigAsync(UpdateRecordCallbackConfigRequest updateRecordCallbackConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateRecordCallbackConfigRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/callbacks/{id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateRecordCallbackConfigRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateRecordCallbackConfigResponse>(response);
        }

        public AsyncInvoker<UpdateRecordCallbackConfigResponse> UpdateRecordCallbackConfigAsyncInvoker(UpdateRecordCallbackConfigRequest updateRecordCallbackConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateRecordCallbackConfigRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/callbacks/{id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateRecordCallbackConfigRequest);
            return new AsyncInvoker<UpdateRecordCallbackConfigResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRecordCallbackConfigResponse>);
        }
        
        /// <summary>
        /// 修改录制规则
        ///
        /// 修改录制规则接口，如果规则修改后，修改后的规则对正在录制的流无效，对新的流有效。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRecordRuleResponse> UpdateRecordRuleAsync(UpdateRecordRuleRequest updateRecordRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateRecordRuleRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/rules/{id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateRecordRuleRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateRecordRuleResponse>(response);
        }

        public AsyncInvoker<UpdateRecordRuleResponse> UpdateRecordRuleAsyncInvoker(UpdateRecordRuleRequest updateRecordRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            urlParam.Add("id", updateRecordRuleRequest.Id.ToString());
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/rules/{id}",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateRecordRuleRequest);
            return new AsyncInvoker<UpdateRecordRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRecordRuleResponse>);
        }
        
        /// <summary>
        /// 修改直播截图配置
        ///
        /// 修改直播截图配置接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateSnapshotConfigResponse> UpdateSnapshotConfigAsync(UpdateSnapshotConfigRequest updateSnapshotConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/snapshot",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateSnapshotConfigRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateSnapshotConfigResponse>(response);
        }

        public AsyncInvoker<UpdateSnapshotConfigResponse> UpdateSnapshotConfigAsyncInvoker(UpdateSnapshotConfigRequest updateSnapshotConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/snapshot",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateSnapshotConfigRequest);
            return new AsyncInvoker<UpdateSnapshotConfigResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateSnapshotConfigResponse>);
        }
        
        /// <summary>
        /// 修改禁推属性
        ///
        /// 修改禁推属性
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateStreamForbiddenResponse> UpdateStreamForbiddenAsync(UpdateStreamForbiddenRequest updateStreamForbiddenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/blocks",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateStreamForbiddenRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateStreamForbiddenResponse>(response);
        }

        public AsyncInvoker<UpdateStreamForbiddenResponse> UpdateStreamForbiddenAsyncInvoker(UpdateStreamForbiddenRequest updateStreamForbiddenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/blocks",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateStreamForbiddenRequest);
            return new AsyncInvoker<UpdateStreamForbiddenResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateStreamForbiddenResponse>);
        }
        
        /// <summary>
        /// 配置直播转码模板
        ///
        /// 修改直播转码模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateTranscodingsTemplateResponse> UpdateTranscodingsTemplateAsync(UpdateTranscodingsTemplateRequest updateTranscodingsTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateTranscodingsTemplateRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateTranscodingsTemplateResponse>(response);
        }

        public AsyncInvoker<UpdateTranscodingsTemplateResponse> UpdateTranscodingsTemplateAsyncInvoker(UpdateTranscodingsTemplateRequest updateTranscodingsTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateTranscodingsTemplateRequest);
            return new AsyncInvoker<UpdateTranscodingsTemplateResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateTranscodingsTemplateResponse>);
        }
        
        /// <summary>
        /// 删除指定域名的https证书配置
        ///
        /// 删除指定域名的https证书配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteDomainHttpsCertResponse> DeleteDomainHttpsCertAsync(DeleteDomainHttpsCertRequest deleteDomainHttpsCertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/https-cert",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainHttpsCertRequest);
            var response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteDomainHttpsCertResponse>(response);
        }

        public AsyncInvoker<DeleteDomainHttpsCertResponse> DeleteDomainHttpsCertAsyncInvoker(DeleteDomainHttpsCertRequest deleteDomainHttpsCertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/https-cert",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainHttpsCertRequest);
            return new AsyncInvoker<DeleteDomainHttpsCertResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDomainHttpsCertResponse>);
        }
        
        /// <summary>
        /// 查询指定域名的https证书配置
        ///
        /// 查询指定域名的https证书配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowDomainHttpsCertResponse> ShowDomainHttpsCertAsync(ShowDomainHttpsCertRequest showDomainHttpsCertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/https-cert",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainHttpsCertRequest);
            var response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainHttpsCertResponse>(response);
        }

        public AsyncInvoker<ShowDomainHttpsCertResponse> ShowDomainHttpsCertAsyncInvoker(ShowDomainHttpsCertRequest showDomainHttpsCertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/https-cert",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainHttpsCertRequest);
            return new AsyncInvoker<ShowDomainHttpsCertResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainHttpsCertResponse>);
        }
        
        /// <summary>
        /// 修改指定域名的https证书配置
        ///
        /// 修改指定域名的https证书配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDomainHttpsCertResponse> UpdateDomainHttpsCertAsync(UpdateDomainHttpsCertRequest updateDomainHttpsCertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/https-cert",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateDomainHttpsCertRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateDomainHttpsCertResponse>(response);
        }

        public AsyncInvoker<UpdateDomainHttpsCertResponse> UpdateDomainHttpsCertAsyncInvoker(UpdateDomainHttpsCertRequest updateDomainHttpsCertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/https-cert",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateDomainHttpsCertRequest);
            return new AsyncInvoker<UpdateDomainHttpsCertResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDomainHttpsCertResponse>);
        }
        
        /// <summary>
        /// OBS桶授权及取消授权
        ///
        /// OBS桶授权及取消授权
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateObsBucketAuthorityPublicResponse> UpdateObsBucketAuthorityPublicAsync(UpdateObsBucketAuthorityPublicRequest updateObsBucketAuthorityPublicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/obs/authority",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateObsBucketAuthorityPublicRequest);
            var response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateObsBucketAuthorityPublicResponse>(response);
        }

        public AsyncInvoker<UpdateObsBucketAuthorityPublicResponse> UpdateObsBucketAuthorityPublicAsyncInvoker(UpdateObsBucketAuthorityPublicRequest updateObsBucketAuthorityPublicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/obs/authority",urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateObsBucketAuthorityPublicRequest);
            return new AsyncInvoker<UpdateObsBucketAuthorityPublicResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateObsBucketAuthorityPublicResponse>);
        }
        
    }
}