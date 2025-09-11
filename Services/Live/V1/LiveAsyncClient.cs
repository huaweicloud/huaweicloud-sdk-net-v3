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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cdn/ip-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchShowIpBelongsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<BatchShowIpBelongsResponse>(response);
        }

        public AsyncInvoker<BatchShowIpBelongsResponse> BatchShowIpBelongsAsyncInvoker(BatchShowIpBelongsRequest batchShowIpBelongsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/cdn/ip-info", urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createDomainRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateDomainResponse>(response);
        }

        public AsyncInvoker<CreateDomainResponse> CreateDomainAsyncInvoker(CreateDomainRequest createDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain", urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domains_mapping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createDomainMappingRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<CreateDomainMappingResponse>(response);
        }

        public AsyncInvoker<CreateDomainMappingResponse> CreateDomainMappingAsyncInvoker(CreateDomainMappingRequest createDomainMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domains_mapping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createDomainMappingRequest);
            return new AsyncInvoker<CreateDomainMappingResponse>(this, "PUT", request, JsonUtils.DeSerialize<CreateDomainMappingResponse>);
        }
        
        /// <summary>
        /// 创建转推输出
        ///
        /// 创建转推输出
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateFlowOutputResponse> CreateFlowOutputAsync(CreateFlowOutputRequest createFlowOutputRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/flows/outputs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", createFlowOutputRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateFlowOutputResponse>(response);
        }

        public AsyncInvoker<CreateFlowOutputResponse> CreateFlowOutputAsyncInvoker(CreateFlowOutputRequest createFlowOutputRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/flows/outputs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", createFlowOutputRequest);
            return new AsyncInvoker<CreateFlowOutputResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateFlowOutputResponse>);
        }
        
        /// <summary>
        /// 创建流
        ///
        /// 创建流
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateFlowsResponse> CreateFlowsAsync(CreateFlowsRequest createFlowsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/flows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", createFlowsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateFlowsResponse>(response);
        }

        public AsyncInvoker<CreateFlowsResponse> CreateFlowsAsyncInvoker(CreateFlowsRequest createFlowsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/flows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", createFlowsRequest);
            return new AsyncInvoker<CreateFlowsResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateFlowsResponse>);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/callbacks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createRecordCallbackConfigRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateRecordCallbackConfigResponse>(response);
        }

        public AsyncInvoker<CreateRecordCallbackConfigResponse> CreateRecordCallbackConfigAsyncInvoker(CreateRecordCallbackConfigRequest createRecordCallbackConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/callbacks", urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/indexes", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createRecordIndexRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateRecordIndexResponse>(response);
        }

        public AsyncInvoker<CreateRecordIndexResponse> CreateRecordIndexAsyncInvoker(CreateRecordIndexRequest createRecordIndexRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/indexes", urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createRecordRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateRecordRuleResponse>(response);
        }

        public AsyncInvoker<CreateRecordRuleResponse> CreateRecordRuleAsyncInvoker(CreateRecordRuleRequest createRecordRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createRecordRuleRequest);
            return new AsyncInvoker<CreateRecordRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRecordRuleResponse>);
        }
        
        /// <summary>
        /// 创建计划录制任务
        ///
        /// 通过使用指定录制模板ID对应的配置创建一个在指定时间启动、结束的录制任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateScheduleRecordTasksResponse> CreateScheduleRecordTasksAsync(CreateScheduleRecordTasksRequest createScheduleRecordTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule/record/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createScheduleRecordTasksRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateScheduleRecordTasksResponse>(response);
        }

        public AsyncInvoker<CreateScheduleRecordTasksResponse> CreateScheduleRecordTasksAsyncInvoker(CreateScheduleRecordTasksRequest createScheduleRecordTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule/record/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createScheduleRecordTasksRequest);
            return new AsyncInvoker<CreateScheduleRecordTasksResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateScheduleRecordTasksResponse>);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/snapshot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createSnapshotConfigRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateSnapshotConfigResponse>(response);
        }

        public AsyncInvoker<CreateSnapshotConfigResponse> CreateSnapshotConfigAsyncInvoker(CreateSnapshotConfigRequest createSnapshotConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/snapshot", urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/blocks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createStreamForbiddenRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateStreamForbiddenResponse>(response);
        }

        public AsyncInvoker<CreateStreamForbiddenResponse> CreateStreamForbiddenAsyncInvoker(CreateStreamForbiddenRequest createStreamForbiddenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/blocks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createStreamForbiddenRequest);
            return new AsyncInvoker<CreateStreamForbiddenResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateStreamForbiddenResponse>);
        }
        
        /// <summary>
        /// 禁推闪断
        ///
        /// 直播推流闪断接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateStreamForbiddenOnceResponse> CreateStreamForbiddenOnceAsync(CreateStreamForbiddenOnceRequest createStreamForbiddenOnceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/block-once", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createStreamForbiddenOnceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateStreamForbiddenOnceResponse>(response);
        }

        public AsyncInvoker<CreateStreamForbiddenOnceResponse> CreateStreamForbiddenOnceAsyncInvoker(CreateStreamForbiddenOnceRequest createStreamForbiddenOnceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/block-once", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createStreamForbiddenOnceRequest);
            return new AsyncInvoker<CreateStreamForbiddenOnceResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateStreamForbiddenOnceResponse>);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createTranscodingsTemplateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateTranscodingsTemplateResponse>(response);
        }

        public AsyncInvoker<CreateTranscodingsTemplateResponse> CreateTranscodingsTemplateAsyncInvoker(CreateTranscodingsTemplateRequest createTranscodingsTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createTranscodingsTemplateRequest);
            return new AsyncInvoker<CreateTranscodingsTemplateResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateTranscodingsTemplateResponse>);
        }
        
        /// <summary>
        /// 生成URL鉴权串
        ///
        /// 生成URL鉴权串
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateUrlAuthchainResponse> CreateUrlAuthchainAsync(CreateUrlAuthchainRequest createUrlAuthchainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/auth/chain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createUrlAuthchainRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateUrlAuthchainResponse>(response);
        }

        public AsyncInvoker<CreateUrlAuthchainResponse> CreateUrlAuthchainAsyncInvoker(CreateUrlAuthchainRequest createUrlAuthchainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/auth/chain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createUrlAuthchainRequest);
            return new AsyncInvoker<CreateUrlAuthchainResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateUrlAuthchainResponse>);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDomainResponse>(response);
        }

        public AsyncInvoker<DeleteDomainResponse> DeleteDomainAsyncInvoker(DeleteDomainRequest deleteDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain", urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/key-chain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainKeyChainRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDomainKeyChainResponse>(response);
        }

        public AsyncInvoker<DeleteDomainKeyChainResponse> DeleteDomainKeyChainAsyncInvoker(DeleteDomainKeyChainRequest deleteDomainKeyChainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/key-chain", urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domains_mapping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainMappingRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDomainMappingResponse>(response);
        }

        public AsyncInvoker<DeleteDomainMappingResponse> DeleteDomainMappingAsyncInvoker(DeleteDomainMappingRequest deleteDomainMappingRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domains_mapping", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainMappingRequest);
            return new AsyncInvoker<DeleteDomainMappingResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteDomainMappingResponse>);
        }
        
        /// <summary>
        /// 删除流
        ///
        /// 删除流
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteFlowResponse> DeleteFlowAsync(DeleteFlowRequest deleteFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/flows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFlowRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteFlowResponse>(response);
        }

        public AsyncInvoker<DeleteFlowResponse> DeleteFlowAsyncInvoker(DeleteFlowRequest deleteFlowRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/flows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFlowRequest);
            return new AsyncInvoker<DeleteFlowResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteFlowResponse>);
        }
        
        /// <summary>
        /// 删除转推输出
        ///
        /// 删除转推输出
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteFlowOutputResponse> DeleteFlowOutputAsync(DeleteFlowOutputRequest deleteFlowOutputRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/flows/outputs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFlowOutputRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteFlowOutputResponse>(response);
        }

        public AsyncInvoker<DeleteFlowOutputResponse> DeleteFlowOutputAsyncInvoker(DeleteFlowOutputRequest deleteFlowOutputRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/flows/outputs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteFlowOutputRequest);
            return new AsyncInvoker<DeleteFlowOutputResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteFlowOutputResponse>);
        }
        
        /// <summary>
        /// 删除直播推流通知配置
        ///
        /// 删除直播推流通知配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePublishTemplateResponse> DeletePublishTemplateAsync(DeletePublishTemplateRequest deletePublishTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notifications/publish", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePublishTemplateRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePublishTemplateResponse>(response);
        }

        public AsyncInvoker<DeletePublishTemplateResponse> DeletePublishTemplateAsyncInvoker(DeletePublishTemplateRequest deletePublishTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notifications/publish", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePublishTemplateRequest);
            return new AsyncInvoker<DeletePublishTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePublishTemplateResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(deleteRecordCallbackConfigRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/callbacks/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordCallbackConfigRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRecordCallbackConfigResponse>(response);
        }

        public AsyncInvoker<DeleteRecordCallbackConfigResponse> DeleteRecordCallbackConfigAsyncInvoker(DeleteRecordCallbackConfigRequest deleteRecordCallbackConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRecordCallbackConfigRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/callbacks/{id}", urlParam);
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
            if (StringUtils.TryConvertToNonEmptyString(deleteRecordRuleRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/rules/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordRuleRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRecordRuleResponse>(response);
        }

        public AsyncInvoker<DeleteRecordRuleResponse> DeleteRecordRuleAsyncInvoker(DeleteRecordRuleRequest deleteRecordRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRecordRuleRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/rules/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRecordRuleRequest);
            return new AsyncInvoker<DeleteRecordRuleResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRecordRuleResponse>);
        }
        
        /// <summary>
        /// 删除Referer防盗链黑白名单
        ///
        /// 删除Referer防盗链黑白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRefererChainResponse> DeleteRefererChainAsync(DeleteRefererChainRequest deleteRefererChainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/referer-chain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRefererChainRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteRefererChainResponse>(response);
        }

        public AsyncInvoker<DeleteRefererChainResponse> DeleteRefererChainAsyncInvoker(DeleteRefererChainRequest deleteRefererChainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/referer-chain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRefererChainRequest);
            return new AsyncInvoker<DeleteRefererChainResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteRefererChainResponse>);
        }
        
        /// <summary>
        /// 停止计划录制任务
        ///
        /// 停止计划录制任务，当前的录制任务会中止并生产录制文件。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteScheduleRecordTasksResponse> DeleteScheduleRecordTasksAsync(DeleteScheduleRecordTasksRequest deleteScheduleRecordTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule/record/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScheduleRecordTasksRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteScheduleRecordTasksResponse>(response);
        }

        public AsyncInvoker<DeleteScheduleRecordTasksResponse> DeleteScheduleRecordTasksAsyncInvoker(DeleteScheduleRecordTasksRequest deleteScheduleRecordTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule/record/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteScheduleRecordTasksRequest);
            return new AsyncInvoker<DeleteScheduleRecordTasksResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteScheduleRecordTasksResponse>);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/snapshot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSnapshotConfigRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteSnapshotConfigResponse>(response);
        }

        public AsyncInvoker<DeleteSnapshotConfigResponse> DeleteSnapshotConfigAsyncInvoker(DeleteSnapshotConfigRequest deleteSnapshotConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/snapshot", urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/blocks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteStreamForbiddenRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteStreamForbiddenResponse>(response);
        }

        public AsyncInvoker<DeleteStreamForbiddenResponse> DeleteStreamForbiddenAsyncInvoker(DeleteStreamForbiddenRequest deleteStreamForbiddenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/blocks", urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTranscodingsTemplateRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteTranscodingsTemplateResponse>(response);
        }

        public AsyncInvoker<DeleteTranscodingsTemplateResponse> DeleteTranscodingsTemplateAsyncInvoker(DeleteTranscodingsTemplateRequest deleteTranscodingsTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTranscodingsTemplateRequest);
            return new AsyncInvoker<DeleteTranscodingsTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteTranscodingsTemplateResponse>);
        }
        
        /// <summary>
        /// 查询播放域名延时配置
        ///
        /// 查询播放域名延时配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListDelayConfigResponse> ListDelayConfigAsync(ListDelayConfigRequest listDelayConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/delay", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDelayConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListDelayConfigResponse>(response);
        }

        public AsyncInvoker<ListDelayConfigResponse> ListDelayConfigAsyncInvoker(ListDelayConfigRequest listDelayConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/delay", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDelayConfigRequest);
            return new AsyncInvoker<ListDelayConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ListDelayConfigResponse>);
        }
        
        /// <summary>
        /// 获取流列表
        ///
        /// 获取流列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListFlowsResponse> ListFlowsAsync(ListFlowsRequest listFlowsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/flows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlowsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListFlowsResponse>(response);
        }

        public AsyncInvoker<ListFlowsResponse> ListFlowsAsyncInvoker(ListFlowsRequest listFlowsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/flows", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlowsRequest);
            return new AsyncInvoker<ListFlowsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListFlowsResponse>);
        }
        
        /// <summary>
        /// 获取地域限制配置列表
        ///
        /// 查询播放域名的地域限制列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListGeoBlockingConfigResponse> ListGeoBlockingConfigAsync(ListGeoBlockingConfigRequest listGeoBlockingConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/geo-blocking", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGeoBlockingConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListGeoBlockingConfigResponse>(response);
        }

        public AsyncInvoker<ListGeoBlockingConfigResponse> ListGeoBlockingConfigAsyncInvoker(ListGeoBlockingConfigRequest listGeoBlockingConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/geo-blocking", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listGeoBlockingConfigRequest);
            return new AsyncInvoker<ListGeoBlockingConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ListGeoBlockingConfigResponse>);
        }
        
        /// <summary>
        /// 查询域名HLS配置
        ///
        /// 查询域名HLS配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListHlsConfigResponse> ListHlsConfigAsync(ListHlsConfigRequest listHlsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/hls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHlsConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListHlsConfigResponse>(response);
        }

        public AsyncInvoker<ListHlsConfigResponse> ListHlsConfigAsyncInvoker(ListHlsConfigRequest listHlsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/hls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHlsConfigRequest);
            return new AsyncInvoker<ListHlsConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHlsConfigResponse>);
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
        public async Task<ListIpAuthListResponse> ListIpAuthListAsync(ListIpAuthListRequest listIpAuthListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpAuthListRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListIpAuthListResponse>(response);
        }

        public AsyncInvoker<ListIpAuthListResponse> ListIpAuthListAsyncInvoker(ListIpAuthListRequest listIpAuthListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpAuthListRequest);
            return new AsyncInvoker<ListIpAuthListResponse>(this, "GET", request, JsonUtils.DeSerialize<ListIpAuthListResponse>);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLiveSampleLogsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListLiveSampleLogsResponse>(response);
        }

        public AsyncInvoker<ListLiveSampleLogsResponse> ListLiveSampleLogsAsyncInvoker(ListLiveSampleLogsRequest listLiveSampleLogsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/logs", urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/realtime/streams", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLiveStreamsOnlineRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListLiveStreamsOnlineResponse>(response);
        }

        public AsyncInvoker<ListLiveStreamsOnlineResponse> ListLiveStreamsOnlineAsyncInvoker(ListLiveStreamsOnlineRequest listLiveStreamsOnlineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/realtime/streams", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLiveStreamsOnlineRequest);
            return new AsyncInvoker<ListLiveStreamsOnlineResponse>(this, "GET", request, JsonUtils.DeSerialize<ListLiveStreamsOnlineResponse>);
        }
        
        /// <summary>
        /// 查询直播推流通知配置
        ///
        /// 查询直播推流通知配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPublishTemplateResponse> ListPublishTemplateAsync(ListPublishTemplateRequest listPublishTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notifications/publish", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublishTemplateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPublishTemplateResponse>(response);
        }

        public AsyncInvoker<ListPublishTemplateResponse> ListPublishTemplateAsyncInvoker(ListPublishTemplateRequest listPublishTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notifications/publish", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublishTemplateRequest);
            return new AsyncInvoker<ListPublishTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPublishTemplateResponse>);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/callbacks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordCallbackConfigsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRecordCallbackConfigsResponse>(response);
        }

        public AsyncInvoker<ListRecordCallbackConfigsResponse> ListRecordCallbackConfigsAsyncInvoker(ListRecordCallbackConfigsRequest listRecordCallbackConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/callbacks", urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/contents", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordContentsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRecordContentsResponse>(response);
        }

        public AsyncInvoker<ListRecordContentsResponse> ListRecordContentsAsyncInvoker(ListRecordContentsRequest listRecordContentsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/contents", urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordRulesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRecordRulesResponse>(response);
        }

        public AsyncInvoker<ListRecordRulesResponse> ListRecordRulesAsyncInvoker(ListRecordRulesRequest listRecordRulesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/rules", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRecordRulesRequest);
            return new AsyncInvoker<ListRecordRulesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRecordRulesResponse>);
        }
        
        /// <summary>
        /// 查询计划录制任务
        ///
        /// 查询指定时间范围内启动和结束的计划录制任务列表。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListScheduleRecordTasksResponse> ListScheduleRecordTasksAsync(ListScheduleRecordTasksRequest listScheduleRecordTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule/record/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduleRecordTasksRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListScheduleRecordTasksResponse>(response);
        }

        public AsyncInvoker<ListScheduleRecordTasksResponse> ListScheduleRecordTasksAsyncInvoker(ListScheduleRecordTasksRequest listScheduleRecordTasksRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/schedule/record/tasks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listScheduleRecordTasksRequest);
            return new AsyncInvoker<ListScheduleRecordTasksResponse>(this, "GET", request, JsonUtils.DeSerialize<ListScheduleRecordTasksResponse>);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/snapshot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSnapshotConfigsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListSnapshotConfigsResponse>(response);
        }

        public AsyncInvoker<ListSnapshotConfigsResponse> ListSnapshotConfigsAsyncInvoker(ListSnapshotConfigsRequest listSnapshotConfigsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/snapshot", urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/blocks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStreamForbiddenRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListStreamForbiddenResponse>(response);
        }

        public AsyncInvoker<ListStreamForbiddenResponse> ListStreamForbiddenAsyncInvoker(ListStreamForbiddenRequest listStreamForbiddenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/blocks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStreamForbiddenRequest);
            return new AsyncInvoker<ListStreamForbiddenResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStreamForbiddenResponse>);
        }
        
        /// <summary>
        /// 更新转推输出
        ///
        /// 更新转推输出
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ModifyFlowOutputResponse> ModifyFlowOutputAsync(ModifyFlowOutputRequest modifyFlowOutputRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/flows/outputs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", modifyFlowOutputRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ModifyFlowOutputResponse>(response);
        }

        public AsyncInvoker<ModifyFlowOutputResponse> ModifyFlowOutputAsyncInvoker(ModifyFlowOutputRequest modifyFlowOutputRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/flows/outputs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", modifyFlowOutputRequest);
            return new AsyncInvoker<ModifyFlowOutputResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyFlowOutputResponse>);
        }
        
        /// <summary>
        /// 修改流来源
        ///
        /// 修改流来源
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ModifyFlowSourcesResponse> ModifyFlowSourcesAsync(ModifyFlowSourcesRequest modifyFlowSourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/flows/sources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", modifyFlowSourcesRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ModifyFlowSourcesResponse>(response);
        }

        public AsyncInvoker<ModifyFlowSourcesResponse> ModifyFlowSourcesAsyncInvoker(ModifyFlowSourcesRequest modifyFlowSourcesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/flows/sources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=utf-8", modifyFlowSourcesRequest);
            return new AsyncInvoker<ModifyFlowSourcesResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyFlowSourcesResponse>);
        }
        
        /// <summary>
        /// 启动流任务
        ///
        /// 启动流任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ModifyFlowStartResponse> ModifyFlowStartAsync(ModifyFlowStartRequest modifyFlowStartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/flows/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyFlowStartRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ModifyFlowStartResponse>(response);
        }

        public AsyncInvoker<ModifyFlowStartResponse> ModifyFlowStartAsyncInvoker(ModifyFlowStartRequest modifyFlowStartRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/flows/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyFlowStartRequest);
            return new AsyncInvoker<ModifyFlowStartResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyFlowStartResponse>);
        }
        
        /// <summary>
        /// 停止流任务
        ///
        /// 停止流任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ModifyFlowStopResponse> ModifyFlowStopAsync(ModifyFlowStopRequest modifyFlowStopRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/flows/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyFlowStopRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ModifyFlowStopResponse>(response);
        }

        public AsyncInvoker<ModifyFlowStopResponse> ModifyFlowStopAsyncInvoker(ModifyFlowStopRequest modifyFlowStopRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/flows/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", modifyFlowStopRequest);
            return new AsyncInvoker<ModifyFlowStopResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyFlowStopResponse>);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/control", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", runRecordRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<RunRecordResponse>(response);
        }

        public AsyncInvoker<RunRecordResponse> RunRecordAsyncInvoker(RunRecordRequest runRecordRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/control", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", runRecordRequest);
            return new AsyncInvoker<RunRecordResponse>(this, "POST", request, JsonUtils.DeSerializeNull<RunRecordResponse>);
        }
        
        /// <summary>
        /// 设置Referer防盗链黑白名单
        ///
        /// 设置Referer黑白名单，直播服务会根据配置的referer黑白名单，对访问者的身份进行识别和过滤，符合规则的可以顺利访问到该内容。如果不符合规则，该访问请求将会被禁止。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SetRefererChainResponse> SetRefererChainAsync(SetRefererChainRequest setRefererChainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/referer-chain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", setRefererChainRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<SetRefererChainResponse>(response);
        }

        public AsyncInvoker<SetRefererChainResponse> SetRefererChainAsyncInvoker(SetRefererChainRequest setRefererChainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/referer-chain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", setRefererChainRequest);
            return new AsyncInvoker<SetRefererChainResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<SetRefererChainResponse>);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainResponse>(response);
        }

        public AsyncInvoker<ShowDomainResponse> ShowDomainAsyncInvoker(ShowDomainRequest showDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain", urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/key-chain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainKeyChainRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainKeyChainResponse>(response);
        }

        public AsyncInvoker<ShowDomainKeyChainResponse> ShowDomainKeyChainAsyncInvoker(ShowDomainKeyChainRequest showDomainKeyChainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/key-chain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainKeyChainRequest);
            return new AsyncInvoker<ShowDomainKeyChainResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowDomainKeyChainResponse>);
        }
        
        /// <summary>
        /// 获取流详情
        ///
        /// 获取流详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowFlowDetailResponse> ShowFlowDetailAsync(ShowFlowDetailRequest showFlowDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/flows/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlowDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowFlowDetailResponse>(response);
        }

        public AsyncInvoker<ShowFlowDetailResponse> ShowFlowDetailAsyncInvoker(ShowFlowDetailRequest showFlowDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/flows/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlowDetailRequest);
            return new AsyncInvoker<ShowFlowDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowFlowDetailResponse>);
        }
        
        /// <summary>
        /// 查询转推输出
        ///
        /// 查询转推输出
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowOutputInfoResponse> ShowOutputInfoAsync(ShowOutputInfoRequest showOutputInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/flows/outputs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOutputInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowOutputInfoResponse>(response);
        }

        public AsyncInvoker<ShowOutputInfoResponse> ShowOutputInfoAsyncInvoker(ShowOutputInfoRequest showOutputInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/flows/outputs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOutputInfoRequest);
            return new AsyncInvoker<ShowOutputInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowOutputInfoResponse>);
        }
        
        /// <summary>
        /// 查询直播拉流回源配置
        ///
        /// 查询直播拉流回源配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPullSourcesConfigResponse> ShowPullSourcesConfigAsync(ShowPullSourcesConfigRequest showPullSourcesConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/pull-sources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPullSourcesConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPullSourcesConfigResponse>(response);
        }

        public AsyncInvoker<ShowPullSourcesConfigResponse> ShowPullSourcesConfigAsyncInvoker(ShowPullSourcesConfigRequest showPullSourcesConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/pull-sources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPullSourcesConfigRequest);
            return new AsyncInvoker<ShowPullSourcesConfigResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPullSourcesConfigResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(showRecordCallbackConfigRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/callbacks/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordCallbackConfigRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRecordCallbackConfigResponse>(response);
        }

        public AsyncInvoker<ShowRecordCallbackConfigResponse> ShowRecordCallbackConfigAsyncInvoker(ShowRecordCallbackConfigRequest showRecordCallbackConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRecordCallbackConfigRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/callbacks/{id}", urlParam);
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
            if (StringUtils.TryConvertToNonEmptyString(showRecordRuleRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/rules/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordRuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRecordRuleResponse>(response);
        }

        public AsyncInvoker<ShowRecordRuleResponse> ShowRecordRuleAsyncInvoker(ShowRecordRuleRequest showRecordRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRecordRuleRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/rules/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRecordRuleRequest);
            return new AsyncInvoker<ShowRecordRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRecordRuleResponse>);
        }
        
        /// <summary>
        /// 查询Referer防盗链黑白名单
        ///
        /// 查询Referer防盗链黑白名单
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRefererChainResponse> ShowRefererChainAsync(ShowRefererChainRequest showRefererChainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/referer-chain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRefererChainRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRefererChainResponse>(response);
        }

        public AsyncInvoker<ShowRefererChainResponse> ShowRefererChainAsyncInvoker(ShowRefererChainRequest showRefererChainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/referer-chain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRefererChainRequest);
            return new AsyncInvoker<ShowRefererChainResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRefererChainResponse>);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTranscodingsTemplateRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTranscodingsTemplateResponse>(response);
        }

        public AsyncInvoker<ShowTranscodingsTemplateResponse> ShowTranscodingsTemplateAsyncInvoker(ShowTranscodingsTemplateRequest showTranscodingsTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTranscodingsTemplateRequest);
            return new AsyncInvoker<ShowTranscodingsTemplateResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTranscodingsTemplateResponse>);
        }
        
        /// <summary>
        /// 修改播放域名延时配置
        ///
        /// 修改播放域名延时配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateDelayConfigResponse> UpdateDelayConfigAsync(UpdateDelayConfigRequest updateDelayConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/delay", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateDelayConfigRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateDelayConfigResponse>(response);
        }

        public AsyncInvoker<UpdateDelayConfigResponse> UpdateDelayConfigAsyncInvoker(UpdateDelayConfigRequest updateDelayConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/delay", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateDelayConfigRequest);
            return new AsyncInvoker<UpdateDelayConfigResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDelayConfigResponse>);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateDomainRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateDomainResponse>(response);
        }

        public AsyncInvoker<UpdateDomainResponse> UpdateDomainAsyncInvoker(UpdateDomainRequest updateDomainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain", urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/ipv6-switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateDomainIp6SwitchRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateDomainIp6SwitchResponse>(response);
        }

        public AsyncInvoker<UpdateDomainIp6SwitchResponse> UpdateDomainIp6SwitchAsyncInvoker(UpdateDomainIp6SwitchRequest updateDomainIp6SwitchRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/ipv6-switch", urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/key-chain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateDomainKeyChainRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateDomainKeyChainResponse>(response);
        }

        public AsyncInvoker<UpdateDomainKeyChainResponse> UpdateDomainKeyChainAsyncInvoker(UpdateDomainKeyChainRequest updateDomainKeyChainRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/key-chain", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateDomainKeyChainRequest);
            return new AsyncInvoker<UpdateDomainKeyChainResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDomainKeyChainResponse>);
        }
        
        /// <summary>
        /// 修改地域限制配置
        ///
        /// 修改播放域名的地域限制，选中地域允许接入。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateGeoBlockingConfigResponse> UpdateGeoBlockingConfigAsync(UpdateGeoBlockingConfigRequest updateGeoBlockingConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/geo-blocking", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateGeoBlockingConfigRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateGeoBlockingConfigResponse>(response);
        }

        public AsyncInvoker<UpdateGeoBlockingConfigResponse> UpdateGeoBlockingConfigAsyncInvoker(UpdateGeoBlockingConfigRequest updateGeoBlockingConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/geo-blocking", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateGeoBlockingConfigRequest);
            return new AsyncInvoker<UpdateGeoBlockingConfigResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateGeoBlockingConfigResponse>);
        }
        
        /// <summary>
        /// 修改域名HLS配置
        ///
        /// 修改域名HLS配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateHlsConfigResponse> UpdateHlsConfigAsync(UpdateHlsConfigRequest updateHlsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/hls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateHlsConfigRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateHlsConfigResponse>(response);
        }

        public AsyncInvoker<UpdateHlsConfigResponse> UpdateHlsConfigAsyncInvoker(UpdateHlsConfigRequest updateHlsConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/hls", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateHlsConfigRequest);
            return new AsyncInvoker<UpdateHlsConfigResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateHlsConfigResponse>);
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
        public async Task<UpdateIpAuthListResponse> UpdateIpAuthListAsync(UpdateIpAuthListRequest updateIpAuthListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateIpAuthListRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateIpAuthListResponse>(response);
        }

        public AsyncInvoker<UpdateIpAuthListResponse> UpdateIpAuthListAsyncInvoker(UpdateIpAuthListRequest updateIpAuthListRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/ip", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateIpAuthListRequest);
            return new AsyncInvoker<UpdateIpAuthListResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateIpAuthListResponse>);
        }
        
        /// <summary>
        /// 新增、覆盖直播推流通知配置
        ///
        /// 新增、覆盖直播推流通知配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePublishTemplateResponse> UpdatePublishTemplateAsync(UpdatePublishTemplateRequest updatePublishTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notifications/publish", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updatePublishTemplateRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdatePublishTemplateResponse>(response);
        }

        public AsyncInvoker<UpdatePublishTemplateResponse> UpdatePublishTemplateAsyncInvoker(UpdatePublishTemplateRequest updatePublishTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/notifications/publish", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updatePublishTemplateRequest);
            return new AsyncInvoker<UpdatePublishTemplateResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdatePublishTemplateResponse>);
        }
        
        /// <summary>
        /// 修改直播拉流回源配置
        ///
        /// 修改直播拉流回源配置。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePullSourcesConfigResponse> UpdatePullSourcesConfigAsync(UpdatePullSourcesConfigRequest updatePullSourcesConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/pull-sources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updatePullSourcesConfigRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdatePullSourcesConfigResponse>(response);
        }

        public AsyncInvoker<UpdatePullSourcesConfigResponse> UpdatePullSourcesConfigAsyncInvoker(UpdatePullSourcesConfigRequest updatePullSourcesConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/domain/pull-sources", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updatePullSourcesConfigRequest);
            return new AsyncInvoker<UpdatePullSourcesConfigResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdatePullSourcesConfigResponse>);
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
            if (StringUtils.TryConvertToNonEmptyString(updateRecordCallbackConfigRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/callbacks/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateRecordCallbackConfigRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRecordCallbackConfigResponse>(response);
        }

        public AsyncInvoker<UpdateRecordCallbackConfigResponse> UpdateRecordCallbackConfigAsyncInvoker(UpdateRecordCallbackConfigRequest updateRecordCallbackConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRecordCallbackConfigRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/callbacks/{id}", urlParam);
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
            if (StringUtils.TryConvertToNonEmptyString(updateRecordRuleRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/rules/{id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateRecordRuleRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRecordRuleResponse>(response);
        }

        public AsyncInvoker<UpdateRecordRuleResponse> UpdateRecordRuleAsyncInvoker(UpdateRecordRuleRequest updateRecordRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRecordRuleRequest.Id, out var valueOfId)) urlParam.Add("id", valueOfId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/record/rules/{id}", urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/snapshot", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateSnapshotConfigRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateSnapshotConfigResponse>(response);
        }

        public AsyncInvoker<UpdateSnapshotConfigResponse> UpdateSnapshotConfigAsyncInvoker(UpdateSnapshotConfigRequest updateSnapshotConfigRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/snapshot", urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/blocks", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateStreamForbiddenRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateStreamForbiddenResponse>(response);
        }

        public AsyncInvoker<UpdateStreamForbiddenResponse> UpdateStreamForbiddenAsyncInvoker(UpdateStreamForbiddenRequest updateStreamForbiddenRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stream/blocks", urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateTranscodingsTemplateRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateTranscodingsTemplateResponse>(response);
        }

        public AsyncInvoker<UpdateTranscodingsTemplateResponse> UpdateTranscodingsTemplateAsyncInvoker(UpdateTranscodingsTemplateRequest updateTranscodingsTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template/transcodings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateTranscodingsTemplateRequest);
            return new AsyncInvoker<UpdateTranscodingsTemplateResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateTranscodingsTemplateResponse>);
        }
        
        /// <summary>
        /// 维度配置信息查询
        ///
        /// 新增维度配置信息查询API
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCesDimsInfoResponse> ListCesDimsInfoAsync(ListCesDimsInfoRequest listCesDimsInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/dims-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCesDimsInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListCesDimsInfoResponse>(response);
        }

        public AsyncInvoker<ListCesDimsInfoResponse> ListCesDimsInfoAsyncInvoker(ListCesDimsInfoRequest listCesDimsInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/dims-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCesDimsInfoRequest);
            return new AsyncInvoker<ListCesDimsInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ListCesDimsInfoResponse>);
        }
        
        /// <summary>
        /// 实例查询
        ///
        /// 新增实例查询API
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListCesInstanceResponse> ListCesInstanceAsync(ListCesInstanceRequest listCesInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", listCesInstanceRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListCesInstanceResponse>(response);
        }

        public AsyncInvoker<ListCesInstanceResponse> ListCesInstanceAsyncInvoker(ListCesInstanceRequest listCesInstanceRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/instances", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", listCesInstanceRequest);
            return new AsyncInvoker<ListCesInstanceResponse>(this, "POST", request, JsonUtils.DeSerialize<ListCesInstanceResponse>);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/https-cert", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainHttpsCertRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteDomainHttpsCertResponse>(response);
        }

        public AsyncInvoker<DeleteDomainHttpsCertResponse> DeleteDomainHttpsCertAsyncInvoker(DeleteDomainHttpsCertRequest deleteDomainHttpsCertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/https-cert", urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/https-cert", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainHttpsCertRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowDomainHttpsCertResponse>(response);
        }

        public AsyncInvoker<ShowDomainHttpsCertResponse> ShowDomainHttpsCertAsyncInvoker(ShowDomainHttpsCertRequest showDomainHttpsCertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/https-cert", urlParam);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/https-cert", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateDomainHttpsCertRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateDomainHttpsCertResponse>(response);
        }

        public AsyncInvoker<UpdateDomainHttpsCertResponse> UpdateDomainHttpsCertAsyncInvoker(UpdateDomainHttpsCertRequest updateDomainHttpsCertRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/guard/https-cert", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateDomainHttpsCertRequest);
            return new AsyncInvoker<UpdateDomainHttpsCertResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateDomainHttpsCertResponse>);
        }
        
        /// <summary>
        /// 创建Live2VOD任务
        ///
        /// 创建Live2VOD任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateHarvestTaskResponse> CreateHarvestTaskAsync(CreateHarvestTaskRequest createHarvestTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/harvest/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createHarvestTaskRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateHarvestTaskResponse>(response);
        }

        public AsyncInvoker<CreateHarvestTaskResponse> CreateHarvestTaskAsyncInvoker(CreateHarvestTaskRequest createHarvestTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/harvest/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createHarvestTaskRequest);
            return new AsyncInvoker<CreateHarvestTaskResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateHarvestTaskResponse>);
        }
        
        /// <summary>
        /// 删除Live2VOD任务
        ///
        /// 删除Live2VOD任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteHarvestTaskResponse> DeleteHarvestTaskAsync(DeleteHarvestTaskRequest deleteHarvestTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/harvest/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHarvestTaskRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteHarvestTaskResponse>(response);
        }

        public AsyncInvoker<DeleteHarvestTaskResponse> DeleteHarvestTaskAsyncInvoker(DeleteHarvestTaskRequest deleteHarvestTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/harvest/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHarvestTaskRequest);
            return new AsyncInvoker<DeleteHarvestTaskResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteHarvestTaskResponse>);
        }
        
        /// <summary>
        /// 查询Live2VOD任务
        ///
        /// 查询Live2VOD任务，支持批量查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListHarvestTaskResponse> ListHarvestTaskAsync(ListHarvestTaskRequest listHarvestTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/harvest/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHarvestTaskRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListHarvestTaskResponse>(response);
        }

        public AsyncInvoker<ListHarvestTaskResponse> ListHarvestTaskAsyncInvoker(ListHarvestTaskRequest listHarvestTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/harvest/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHarvestTaskRequest);
            return new AsyncInvoker<ListHarvestTaskResponse>(this, "GET", request, JsonUtils.DeSerialize<ListHarvestTaskResponse>);
        }
        
        /// <summary>
        /// 修改Live2VOD任务
        ///
        /// 修改Live2VOD任务。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ModifyHarvestTaskResponse> ModifyHarvestTaskAsync(ModifyHarvestTaskRequest modifyHarvestTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/harvest/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", modifyHarvestTaskRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ModifyHarvestTaskResponse>(response);
        }

        public AsyncInvoker<ModifyHarvestTaskResponse> ModifyHarvestTaskAsyncInvoker(ModifyHarvestTaskRequest modifyHarvestTaskRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/harvest/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", modifyHarvestTaskRequest);
            return new AsyncInvoker<ModifyHarvestTaskResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyHarvestTaskResponse>);
        }
        
        /// <summary>
        /// 修改Live2VOD任务状态
        ///
        /// 修改Live2VOD任务状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateHarvestJobStatusResponse> UpdateHarvestJobStatusAsync(UpdateHarvestJobStatusRequest updateHarvestJobStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/harvest/task/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateHarvestJobStatusRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateHarvestJobStatusResponse>(response);
        }

        public AsyncInvoker<UpdateHarvestJobStatusResponse> UpdateHarvestJobStatusAsyncInvoker(UpdateHarvestJobStatusRequest updateHarvestJobStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/harvest/task/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateHarvestJobStatusRequest);
            return new AsyncInvoker<UpdateHarvestJobStatusResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateHarvestJobStatusResponse>);
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
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/obs/authority", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateObsBucketAuthorityPublicRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerializeNull<UpdateObsBucketAuthorityPublicResponse>(response);
        }

        public AsyncInvoker<UpdateObsBucketAuthorityPublicResponse> UpdateObsBucketAuthorityPublicAsyncInvoker(UpdateObsBucketAuthorityPublicRequest updateObsBucketAuthorityPublicRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/obs/authority", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", updateObsBucketAuthorityPublicRequest);
            return new AsyncInvoker<UpdateObsBucketAuthorityPublicResponse>(this, "PUT", request, JsonUtils.DeSerializeNull<UpdateObsBucketAuthorityPublicResponse>);
        }
        
        /// <summary>
        /// 新建OTT频道
        ///
        /// 创建频道接口，支持创建OTT频道。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateOttChannelInfoResponse> CreateOttChannelInfoAsync(CreateOttChannelInfoRequest createOttChannelInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createOttChannelInfoRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateOttChannelInfoResponse>(response);
        }

        public AsyncInvoker<CreateOttChannelInfoResponse> CreateOttChannelInfoAsyncInvoker(CreateOttChannelInfoRequest createOttChannelInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", createOttChannelInfoRequest);
            return new AsyncInvoker<CreateOttChannelInfoResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateOttChannelInfoResponse>);
        }
        
        /// <summary>
        /// 删除频道信息
        ///
        /// 删除频道信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteOttChannelInfoResponse> DeleteOttChannelInfoAsync(DeleteOttChannelInfoRequest deleteOttChannelInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOttChannelInfoRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteOttChannelInfoResponse>(response);
        }

        public AsyncInvoker<DeleteOttChannelInfoResponse> DeleteOttChannelInfoAsyncInvoker(DeleteOttChannelInfoRequest deleteOttChannelInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteOttChannelInfoRequest);
            return new AsyncInvoker<DeleteOttChannelInfoResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteOttChannelInfoResponse>);
        }
        
        /// <summary>
        /// 查询频道信息
        ///
        /// 查询频道信息，支持批量查询。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListOttChannelInfoResponse> ListOttChannelInfoAsync(ListOttChannelInfoRequest listOttChannelInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOttChannelInfoRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListOttChannelInfoResponse>(response);
        }

        public AsyncInvoker<ListOttChannelInfoResponse> ListOttChannelInfoAsyncInvoker(ListOttChannelInfoRequest listOttChannelInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOttChannelInfoRequest);
            return new AsyncInvoker<ListOttChannelInfoResponse>(this, "GET", request, JsonUtils.DeSerialize<ListOttChannelInfoResponse>);
        }
        
        /// <summary>
        /// 修改频道转码模板信息
        ///
        /// 修改频道转码模板信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ModifyOttChannelInfoEncoderSettingsResponse> ModifyOttChannelInfoEncoderSettingsAsync(ModifyOttChannelInfoEncoderSettingsRequest modifyOttChannelInfoEncoderSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels/encorder-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", modifyOttChannelInfoEncoderSettingsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ModifyOttChannelInfoEncoderSettingsResponse>(response);
        }

        public AsyncInvoker<ModifyOttChannelInfoEncoderSettingsResponse> ModifyOttChannelInfoEncoderSettingsAsyncInvoker(ModifyOttChannelInfoEncoderSettingsRequest modifyOttChannelInfoEncoderSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels/encorder-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", modifyOttChannelInfoEncoderSettingsRequest);
            return new AsyncInvoker<ModifyOttChannelInfoEncoderSettingsResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyOttChannelInfoEncoderSettingsResponse>);
        }
        
        /// <summary>
        /// 修改频道打包信息
        ///
        /// 修改频道打包信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ModifyOttChannelInfoEndPointsResponse> ModifyOttChannelInfoEndPointsAsync(ModifyOttChannelInfoEndPointsRequest modifyOttChannelInfoEndPointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels/endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", modifyOttChannelInfoEndPointsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ModifyOttChannelInfoEndPointsResponse>(response);
        }

        public AsyncInvoker<ModifyOttChannelInfoEndPointsResponse> ModifyOttChannelInfoEndPointsAsyncInvoker(ModifyOttChannelInfoEndPointsRequest modifyOttChannelInfoEndPointsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels/endpoints", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", modifyOttChannelInfoEndPointsRequest);
            return new AsyncInvoker<ModifyOttChannelInfoEndPointsResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyOttChannelInfoEndPointsResponse>);
        }
        
        /// <summary>
        /// 修改频道通用信息
        ///
        /// 修改频道通用信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ModifyOttChannelInfoGeneralResponse> ModifyOttChannelInfoGeneralAsync(ModifyOttChannelInfoGeneralRequest modifyOttChannelInfoGeneralRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels/general", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", modifyOttChannelInfoGeneralRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ModifyOttChannelInfoGeneralResponse>(response);
        }

        public AsyncInvoker<ModifyOttChannelInfoGeneralResponse> ModifyOttChannelInfoGeneralAsyncInvoker(ModifyOttChannelInfoGeneralRequest modifyOttChannelInfoGeneralRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels/general", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", modifyOttChannelInfoGeneralRequest);
            return new AsyncInvoker<ModifyOttChannelInfoGeneralResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyOttChannelInfoGeneralResponse>);
        }
        
        /// <summary>
        /// 修改频道入流信息
        ///
        /// 修改频道入流信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ModifyOttChannelInfoInputResponse> ModifyOttChannelInfoInputAsync(ModifyOttChannelInfoInputRequest modifyOttChannelInfoInputRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels/input", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", modifyOttChannelInfoInputRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ModifyOttChannelInfoInputResponse>(response);
        }

        public AsyncInvoker<ModifyOttChannelInfoInputResponse> ModifyOttChannelInfoInputAsyncInvoker(ModifyOttChannelInfoInputRequest modifyOttChannelInfoInputRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels/input", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", modifyOttChannelInfoInputRequest);
            return new AsyncInvoker<ModifyOttChannelInfoInputResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyOttChannelInfoInputResponse>);
        }
        
        /// <summary>
        /// 修改频道录制信息
        ///
        /// 修改频道录制信息。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ModifyOttChannelInfoRecordSettingsResponse> ModifyOttChannelInfoRecordSettingsAsync(ModifyOttChannelInfoRecordSettingsRequest modifyOttChannelInfoRecordSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels/record-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", modifyOttChannelInfoRecordSettingsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ModifyOttChannelInfoRecordSettingsResponse>(response);
        }

        public AsyncInvoker<ModifyOttChannelInfoRecordSettingsResponse> ModifyOttChannelInfoRecordSettingsAsyncInvoker(ModifyOttChannelInfoRecordSettingsRequest modifyOttChannelInfoRecordSettingsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels/record-settings", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", modifyOttChannelInfoRecordSettingsRequest);
            return new AsyncInvoker<ModifyOttChannelInfoRecordSettingsResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyOttChannelInfoRecordSettingsResponse>);
        }
        
        /// <summary>
        /// 修改频道状态
        ///
        /// 修改频道状态。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ModifyOttChannelInfoStatsResponse> ModifyOttChannelInfoStatsAsync(ModifyOttChannelInfoStatsRequest modifyOttChannelInfoStatsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels/state", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", modifyOttChannelInfoStatsRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<ModifyOttChannelInfoStatsResponse>(response);
        }

        public AsyncInvoker<ModifyOttChannelInfoStatsResponse> ModifyOttChannelInfoStatsAsyncInvoker(ModifyOttChannelInfoStatsRequest modifyOttChannelInfoStatsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels/state", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", modifyOttChannelInfoStatsRequest);
            return new AsyncInvoker<ModifyOttChannelInfoStatsResponse>(this, "PUT", request, JsonUtils.DeSerialize<ModifyOttChannelInfoStatsResponse>);
        }
        
        /// <summary>
        /// 查询频道统计信息
        ///
        /// 查询频道的统计信息（入流scte35信号）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowChannelStatisticResponse> ShowChannelStatisticAsync(ShowChannelStatisticRequest showChannelStatisticRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels/statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", showChannelStatisticRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShowChannelStatisticResponse>(response);
        }

        public AsyncInvoker<ShowChannelStatisticResponse> ShowChannelStatisticAsyncInvoker(ShowChannelStatisticRequest showChannelStatisticRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ott/channels/statistic", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json; charset=UTF-8", showChannelStatisticRequest);
            return new AsyncInvoker<ShowChannelStatisticResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowChannelStatisticResponse>);
        }
        
    }
}