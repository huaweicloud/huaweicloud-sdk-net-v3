using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.CodeArtsPipeline.V2.Model;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2
{
    public partial class CodeArtsPipelineAsyncClient : Client
    {
        public static ClientBuilder<CodeArtsPipelineAsyncClient> NewBuilder()
        {
            return new ClientBuilder<CodeArtsPipelineAsyncClient>();
        }

        
        /// <summary>
        /// 通过人工审核
        ///
        /// 通过人工审核
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<AcceptManualReviewResponse> AcceptManualReviewAsync(AcceptManualReviewRequest acceptManualReviewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(acceptManualReviewRequest.JobRunId, out var valueOfJobRunId)) urlParam.Add("job_run_id", valueOfJobRunId);
            if (StringUtils.TryConvertToNonEmptyString(acceptManualReviewRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(acceptManualReviewRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            if (StringUtils.TryConvertToNonEmptyString(acceptManualReviewRequest.PipelineRunId, out var valueOfPipelineRunId)) urlParam.Add("pipeline_run_id", valueOfPipelineRunId);
            if (StringUtils.TryConvertToNonEmptyString(acceptManualReviewRequest.StepRunId, out var valueOfStepRunId)) urlParam.Add("step_run_id", valueOfStepRunId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/pipeline-runs/{pipeline_run_id}/jobs/{job_run_id}/steps/{step_run_id}/pass", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", acceptManualReviewRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<AcceptManualReviewResponse>(response);
        }

        public AsyncInvoker<AcceptManualReviewResponse> AcceptManualReviewAsyncInvoker(AcceptManualReviewRequest acceptManualReviewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(acceptManualReviewRequest.JobRunId, out var valueOfJobRunId)) urlParam.Add("job_run_id", valueOfJobRunId);
            if (StringUtils.TryConvertToNonEmptyString(acceptManualReviewRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(acceptManualReviewRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            if (StringUtils.TryConvertToNonEmptyString(acceptManualReviewRequest.PipelineRunId, out var valueOfPipelineRunId)) urlParam.Add("pipeline_run_id", valueOfPipelineRunId);
            if (StringUtils.TryConvertToNonEmptyString(acceptManualReviewRequest.StepRunId, out var valueOfStepRunId)) urlParam.Add("step_run_id", valueOfStepRunId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/pipeline-runs/{pipeline_run_id}/jobs/{job_run_id}/steps/{step_run_id}/pass", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", acceptManualReviewRequest);
            return new AsyncInvoker<AcceptManualReviewResponse>(this, "POST", request, JsonUtils.DeSerialize<AcceptManualReviewResponse>);
        }
        
        /// <summary>
        /// 批量把流水线移动到分组下
        ///
        /// 批量把流水线移动到分组下
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchMovePipelineToGroupResponse> BatchMovePipelineToGroupAsync(BatchMovePipelineToGroupRequest batchMovePipelineToGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchMovePipelineToGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipeline-group/pipeline/move", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchMovePipelineToGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            var batchMovePipelineToGroupResponse = JsonUtils.DeSerializeNull<BatchMovePipelineToGroupResponse>(response);
            batchMovePipelineToGroupResponse.Body = JsonUtils.DeSerializeList<PipelineMoveToGroupResponseVo>(response);
            return batchMovePipelineToGroupResponse;
        }

        public AsyncInvoker<BatchMovePipelineToGroupResponse> BatchMovePipelineToGroupAsyncInvoker(BatchMovePipelineToGroupRequest batchMovePipelineToGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchMovePipelineToGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipeline-group/pipeline/move", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchMovePipelineToGroupRequest);
            return new AsyncInvoker<BatchMovePipelineToGroupResponse>(this, "POST", request, response =>
            {
                var batchMovePipelineToGroupResponse = JsonUtils.DeSerializeNull<BatchMovePipelineToGroupResponse>(response);
                batchMovePipelineToGroupResponse.Body = JsonUtils.DeSerializeList<PipelineMoveToGroupResponseVo>(response);
                return batchMovePipelineToGroupResponse;
            });
        }
        
        /// <summary>
        /// 批量获取流水线状态
        ///
        /// 批量获取流水线状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchShowPipelinesLatestStatusResponse> BatchShowPipelinesLatestStatusAsync(BatchShowPipelinesLatestStatusRequest batchShowPipelinesLatestStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchShowPipelinesLatestStatusRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchShowPipelinesLatestStatusRequest);
            var response = await DoHttpRequestAsync("POST", request);
            var batchShowPipelinesLatestStatusResponse = JsonUtils.DeSerializeNull<BatchShowPipelinesLatestStatusResponse>(response);
            batchShowPipelinesLatestStatusResponse.Body = JsonUtils.DeSerializeList<PipelineLatestRun>(response);
            return batchShowPipelinesLatestStatusResponse;
        }

        public AsyncInvoker<BatchShowPipelinesLatestStatusResponse> BatchShowPipelinesLatestStatusAsyncInvoker(BatchShowPipelinesLatestStatusRequest batchShowPipelinesLatestStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchShowPipelinesLatestStatusRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchShowPipelinesLatestStatusRequest);
            return new AsyncInvoker<BatchShowPipelinesLatestStatusResponse>(this, "POST", request, response =>
            {
                var batchShowPipelinesLatestStatusResponse = JsonUtils.DeSerializeNull<BatchShowPipelinesLatestStatusResponse>(response);
                batchShowPipelinesLatestStatusResponse.Body = JsonUtils.DeSerializeList<PipelineLatestRun>(response);
                return batchShowPipelinesLatestStatusResponse;
            });
        }
        
        /// <summary>
        /// 批量获取流水线状态
        ///
        /// 批量获取流水线状态和阶段信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<BatchShowPipelinesStatusResponse> BatchShowPipelinesStatusAsync(BatchShowPipelinesStatusRequest batchShowPipelinesStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/pipelines/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchShowPipelinesStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var batchShowPipelinesStatusResponse = JsonUtils.DeSerializeNull<BatchShowPipelinesStatusResponse>(response);
            batchShowPipelinesStatusResponse.Body = JsonUtils.DeSerializeList<PipelineExecuteStates>(response);
            return batchShowPipelinesStatusResponse;
        }

        public AsyncInvoker<BatchShowPipelinesStatusResponse> BatchShowPipelinesStatusAsyncInvoker(BatchShowPipelinesStatusRequest batchShowPipelinesStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/pipelines/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchShowPipelinesStatusRequest);
            return new AsyncInvoker<BatchShowPipelinesStatusResponse>(this, "GET", request, response =>
            {
                var batchShowPipelinesStatusResponse = JsonUtils.DeSerializeNull<BatchShowPipelinesStatusResponse>(response);
                batchShowPipelinesStatusResponse.Body = JsonUtils.DeSerializeList<PipelineExecuteStates>(response);
                return batchShowPipelinesStatusResponse;
            });
        }
        
        /// <summary>
        /// 创建基础插件
        ///
        /// 创建基础插件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateBasicPluginResponse> CreateBasicPluginAsync(CreateBasicPluginRequest createBasicPluginRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createBasicPluginRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/extension/info/add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createBasicPluginRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreateBasicPluginResponse>(response);
        }

        public AsyncInvoker<CreateBasicPluginResponse> CreateBasicPluginAsyncInvoker(CreateBasicPluginRequest createBasicPluginRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createBasicPluginRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/extension/info/add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createBasicPluginRequest);
            return new AsyncInvoker<CreateBasicPluginResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateBasicPluginResponse>);
        }
        
        /// <summary>
        /// 基于模板快速创建流水线及流水线内任务
        ///
        /// 基于模板快速创建流水线及流水线内任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePipelineByTemplateResponse> CreatePipelineByTemplateAsync(CreatePipelineByTemplateRequest createPipelineByTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/templates/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPipelineByTemplateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePipelineByTemplateResponse>(response);
        }

        public AsyncInvoker<CreatePipelineByTemplateResponse> CreatePipelineByTemplateAsyncInvoker(CreatePipelineByTemplateRequest createPipelineByTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/templates/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPipelineByTemplateRequest);
            return new AsyncInvoker<CreatePipelineByTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePipelineByTemplateResponse>);
        }
        
        /// <summary>
        /// 基于模板创建流水线
        ///
        /// 基于模板创建流水线
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePipelineByTemplateIdResponse> CreatePipelineByTemplateIdAsync(CreatePipelineByTemplateIdRequest createPipelineByTemplateIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPipelineByTemplateIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(createPipelineByTemplateIdRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipeline-templates/{template_id}/create-pipeline", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPipelineByTemplateIdRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePipelineByTemplateIdResponse>(response);
        }

        public AsyncInvoker<CreatePipelineByTemplateIdResponse> CreatePipelineByTemplateIdAsyncInvoker(CreatePipelineByTemplateIdRequest createPipelineByTemplateIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPipelineByTemplateIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(createPipelineByTemplateIdRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipeline-templates/{template_id}/create-pipeline", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPipelineByTemplateIdRequest);
            return new AsyncInvoker<CreatePipelineByTemplateIdResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePipelineByTemplateIdResponse>);
        }
        
        /// <summary>
        /// 新建流水线分组
        ///
        /// 新建流水线分组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePipelineGroupResponse> CreatePipelineGroupAsync(CreatePipelineGroupRequest createPipelineGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPipelineGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipeline-group/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPipelineGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePipelineGroupResponse>(response);
        }

        public AsyncInvoker<CreatePipelineGroupResponse> CreatePipelineGroupAsyncInvoker(CreatePipelineGroupRequest createPipelineGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPipelineGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipeline-group/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPipelineGroupRequest);
            return new AsyncInvoker<CreatePipelineGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePipelineGroupResponse>);
        }
        
        /// <summary>
        /// 创建流水线
        ///
        /// 创建流水线
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePipelineNewResponse> CreatePipelineNewAsync(CreatePipelineNewRequest createPipelineNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPipelineNewRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPipelineNewRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePipelineNewResponse>(response);
        }

        public AsyncInvoker<CreatePipelineNewResponse> CreatePipelineNewAsyncInvoker(CreatePipelineNewRequest createPipelineNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPipelineNewRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPipelineNewRequest);
            return new AsyncInvoker<CreatePipelineNewResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePipelineNewResponse>);
        }
        
        /// <summary>
        /// 创建流水线模板
        ///
        /// 创建流水线模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePipelineTemplateResponse> CreatePipelineTemplateAsync(CreatePipelineTemplateRequest createPipelineTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPipelineTemplateRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{tenant_id}/api/pipeline-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPipelineTemplateRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreatePipelineTemplateResponse>(response);
        }

        public AsyncInvoker<CreatePipelineTemplateResponse> CreatePipelineTemplateAsyncInvoker(CreatePipelineTemplateRequest createPipelineTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPipelineTemplateRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{tenant_id}/api/pipeline-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPipelineTemplateRequest);
            return new AsyncInvoker<CreatePipelineTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePipelineTemplateResponse>);
        }
        
        /// <summary>
        /// 创建插件草稿版本
        ///
        /// 创建插件草稿版本
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePluginDraftResponse> CreatePluginDraftAsync(CreatePluginDraftRequest createPluginDraftRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPluginDraftRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/create-draft", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPluginDraftRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreatePluginDraftResponse>(response);
        }

        public AsyncInvoker<CreatePluginDraftResponse> CreatePluginDraftAsyncInvoker(CreatePluginDraftRequest createPluginDraftRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPluginDraftRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/create-draft", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPluginDraftRequest);
            return new AsyncInvoker<CreatePluginDraftResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreatePluginDraftResponse>);
        }
        
        /// <summary>
        /// 创建插件版本
        ///
        /// 创建插件版本
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePluginVersionResponse> CreatePluginVersionAsync(CreatePluginVersionRequest createPluginVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPluginVersionRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPluginVersionRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreatePluginVersionResponse>(response);
        }

        public AsyncInvoker<CreatePluginVersionResponse> CreatePluginVersionAsyncInvoker(CreatePluginVersionRequest createPluginVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPluginVersionRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPluginVersionRequest);
            return new AsyncInvoker<CreatePluginVersionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreatePluginVersionResponse>);
        }
        
        /// <summary>
        /// 创建发布商
        ///
        /// 创建发布商
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreatePublisherResponse> CreatePublisherAsync(CreatePublisherRequest createPublisherRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPublisherRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/publisher/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPublisherRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<CreatePublisherResponse>(response);
        }

        public AsyncInvoker<CreatePublisherResponse> CreatePublisherAsyncInvoker(CreatePublisherRequest createPublisherRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPublisherRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/publisher/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPublisherRequest);
            return new AsyncInvoker<CreatePublisherResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreatePublisherResponse>);
        }
        
        /// <summary>
        /// 创建规则
        ///
        /// 创建规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateRuleResponse> CreateRuleAsync(CreateRuleRequest createRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRuleRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/rules/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createRuleRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateRuleResponse>(response);
        }

        public AsyncInvoker<CreateRuleResponse> CreateRuleAsyncInvoker(CreateRuleRequest createRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRuleRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/rules/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createRuleRequest);
            return new AsyncInvoker<CreateRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRuleResponse>);
        }
        
        /// <summary>
        /// 创建策略
        ///
        /// 创建策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateStrategyResponse> CreateStrategyAsync(CreateStrategyRequest createStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createStrategyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/tenant/rule-sets/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createStrategyRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<CreateStrategyResponse>(response);
        }

        public AsyncInvoker<CreateStrategyResponse> CreateStrategyAsyncInvoker(CreateStrategyRequest createStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createStrategyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/tenant/rule-sets/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createStrategyRequest);
            return new AsyncInvoker<CreateStrategyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateStrategyResponse>);
        }
        
        /// <summary>
        /// 删除基础插件
        ///
        /// 删除基础插件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteBasicPluginResponse> DeleteBasicPluginAsync(DeleteBasicPluginRequest deleteBasicPluginRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteBasicPluginRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/extension/info/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBasicPluginRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteBasicPluginResponse>(response);
        }

        public AsyncInvoker<DeleteBasicPluginResponse> DeleteBasicPluginAsyncInvoker(DeleteBasicPluginRequest deleteBasicPluginRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteBasicPluginRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/extension/info/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBasicPluginRequest);
            return new AsyncInvoker<DeleteBasicPluginResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteBasicPluginResponse>);
        }
        
        /// <summary>
        /// 删除流水线
        ///
        /// 删除流水线
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePipelineResponse> DeletePipelineAsync(DeletePipelineRequest deletePipelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePipelineRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deletePipelineRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePipelineRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeletePipelineResponse>(response);
        }

        public AsyncInvoker<DeletePipelineResponse> DeletePipelineAsyncInvoker(DeletePipelineRequest deletePipelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePipelineRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deletePipelineRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePipelineRequest);
            return new AsyncInvoker<DeletePipelineResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeletePipelineResponse>);
        }
        
        /// <summary>
        /// 删除流水线分组
        ///
        /// 删除流水线分组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePipelineGroupResponse> DeletePipelineGroupAsync(DeletePipelineGroupRequest deletePipelineGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePipelineGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipeline-group/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePipelineGroupRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeletePipelineGroupResponse>(response);
        }

        public AsyncInvoker<DeletePipelineGroupResponse> DeletePipelineGroupAsyncInvoker(DeletePipelineGroupRequest deletePipelineGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePipelineGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipeline-group/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePipelineGroupRequest);
            return new AsyncInvoker<DeletePipelineGroupResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeletePipelineGroupResponse>);
        }
        
        /// <summary>
        /// 删除流水线模板
        ///
        /// 删除流水线模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePipelineTemplateResponse> DeletePipelineTemplateAsync(DeletePipelineTemplateRequest deletePipelineTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePipelineTemplateRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(deletePipelineTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{tenant_id}/api/pipeline-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePipelineTemplateRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeletePipelineTemplateResponse>(response);
        }

        public AsyncInvoker<DeletePipelineTemplateResponse> DeletePipelineTemplateAsyncInvoker(DeletePipelineTemplateRequest deletePipelineTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePipelineTemplateRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(deletePipelineTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{tenant_id}/api/pipeline-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePipelineTemplateRequest);
            return new AsyncInvoker<DeletePipelineTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeletePipelineTemplateResponse>);
        }
        
        /// <summary>
        /// 删除插件草稿
        ///
        /// 删除插件草稿
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePluginDraftResponse> DeletePluginDraftAsync(DeletePluginDraftRequest deletePluginDraftRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePluginDraftRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/delete-draft", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePluginDraftRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePluginDraftResponse>(response);
        }

        public AsyncInvoker<DeletePluginDraftResponse> DeletePluginDraftAsyncInvoker(DeletePluginDraftRequest deletePluginDraftRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePluginDraftRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/delete-draft", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePluginDraftRequest);
            return new AsyncInvoker<DeletePluginDraftResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePluginDraftResponse>);
        }
        
        /// <summary>
        /// 删除发布商
        ///
        /// 删除发布商
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeletePublisherResponse> DeletePublisherAsync(DeletePublisherRequest deletePublisherRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePublisherRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/publisher/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePublisherRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePublisherResponse>(response);
        }

        public AsyncInvoker<DeletePublisherResponse> DeletePublisherAsyncInvoker(DeletePublisherRequest deletePublisherRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePublisherRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/publisher/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePublisherRequest);
            return new AsyncInvoker<DeletePublisherResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePublisherResponse>);
        }
        
        /// <summary>
        /// 删除规则
        ///
        /// 删除规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteRuleResponse> DeleteRuleAsync(DeleteRuleRequest deleteRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRuleRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(deleteRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/rules/{rule_id}/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRuleRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteRuleResponse>(response);
        }

        public AsyncInvoker<DeleteRuleResponse> DeleteRuleAsyncInvoker(DeleteRuleRequest deleteRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRuleRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(deleteRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/rules/{rule_id}/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRuleRequest);
            return new AsyncInvoker<DeleteRuleResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteRuleResponse>);
        }
        
        /// <summary>
        /// 删除策略
        ///
        /// 删除策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteStrategyResponse> DeleteStrategyAsync(DeleteStrategyRequest deleteStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteStrategyRequest.RuleSetId, out var valueOfRuleSetId)) urlParam.Add("rule_set_id", valueOfRuleSetId);
            if (StringUtils.TryConvertToNonEmptyString(deleteStrategyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/tenant/rule-sets/{rule_set_id}/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteStrategyRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteStrategyResponse>(response);
        }

        public AsyncInvoker<DeleteStrategyResponse> DeleteStrategyAsyncInvoker(DeleteStrategyRequest deleteStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteStrategyRequest.RuleSetId, out var valueOfRuleSetId)) urlParam.Add("rule_set_id", valueOfRuleSetId);
            if (StringUtils.TryConvertToNonEmptyString(deleteStrategyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/tenant/rule-sets/{rule_set_id}/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteStrategyRequest);
            return new AsyncInvoker<DeleteStrategyResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteStrategyResponse>);
        }
        
        /// <summary>
        /// 查询可用发布商
        ///
        /// 查询可用发布商
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListAvailablePublisherResponse> ListAvailablePublisherAsync(ListAvailablePublisherRequest listAvailablePublisherRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAvailablePublisherRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/publisher/optional-publisher", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailablePublisherRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var listAvailablePublisherResponse = JsonUtils.DeSerializeNull<ListAvailablePublisherResponse>(response);
            listAvailablePublisherResponse.Body = JsonUtils.DeSerializeList<PublisherVO>(response);
            return listAvailablePublisherResponse;
        }

        public AsyncInvoker<ListAvailablePublisherResponse> ListAvailablePublisherAsyncInvoker(ListAvailablePublisherRequest listAvailablePublisherRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAvailablePublisherRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/publisher/optional-publisher", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailablePublisherRequest);
            return new AsyncInvoker<ListAvailablePublisherResponse>(this, "GET", request, response =>
            {
                var listAvailablePublisherResponse = JsonUtils.DeSerializeNull<ListAvailablePublisherResponse>(response);
                listAvailablePublisherResponse.Body = JsonUtils.DeSerializeList<PublisherVO>(response);
                return listAvailablePublisherResponse;
            });
        }
        
        /// <summary>
        /// 查询基础插件列表
        ///
        /// 查询基础插件列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBasePluginsResponse> ListBasePluginsAsync(ListBasePluginsRequest listBasePluginsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBasePluginsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/relation/plugin/single", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBasePluginsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListBasePluginsResponse>(response);
        }

        public AsyncInvoker<ListBasePluginsResponse> ListBasePluginsAsyncInvoker(ListBasePluginsRequest listBasePluginsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBasePluginsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/relation/plugin/single", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBasePluginsRequest);
            return new AsyncInvoker<ListBasePluginsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBasePluginsResponse>);
        }
        
        /// <summary>
        /// 分页查询可选插件列表
        ///
        /// 分页查询可选插件列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListBasePluginsNewPostResponse> ListBasePluginsNewPostAsync(ListBasePluginsNewPostRequest listBasePluginsNewPostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBasePluginsNewPostRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/relation/plugins", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listBasePluginsNewPostRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListBasePluginsNewPostResponse>(response);
        }

        public AsyncInvoker<ListBasePluginsNewPostResponse> ListBasePluginsNewPostAsyncInvoker(ListBasePluginsNewPostRequest listBasePluginsNewPostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBasePluginsNewPostRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/relation/plugins", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listBasePluginsNewPostRequest);
            return new AsyncInvoker<ListBasePluginsNewPostResponse>(this, "POST", request, JsonUtils.DeSerialize<ListBasePluginsNewPostResponse>);
        }
        
        /// <summary>
        /// 查询插件所有版本信息
        ///
        /// 查询插件所有版本信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPLuginVersionResponse> ListPLuginVersionAsync(ListPLuginVersionRequest listPLuginVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPLuginVersionRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPLuginVersionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPLuginVersionResponse>(response);
        }

        public AsyncInvoker<ListPLuginVersionResponse> ListPLuginVersionAsyncInvoker(ListPLuginVersionRequest listPLuginVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPLuginVersionRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPLuginVersionRequest);
            return new AsyncInvoker<ListPLuginVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPLuginVersionResponse>);
        }
        
        /// <summary>
        /// 获取流水线执行记录
        ///
        /// 获取流水线执行记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPipelineRunsResponse> ListPipelineRunsAsync(ListPipelineRunsRequest listPipelineRunsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPipelineRunsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listPipelineRunsRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/pipeline-runs/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listPipelineRunsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListPipelineRunsResponse>(response);
        }

        public AsyncInvoker<ListPipelineRunsResponse> ListPipelineRunsAsyncInvoker(ListPipelineRunsRequest listPipelineRunsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPipelineRunsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listPipelineRunsRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/pipeline-runs/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listPipelineRunsRequest);
            return new AsyncInvoker<ListPipelineRunsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListPipelineRunsResponse>);
        }
        
        /// <summary>
        /// 获取流水线列表接口
        ///
        /// 获取流水线列表接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPipelineSimpleInfoResponse> ListPipelineSimpleInfoAsync(ListPipelineSimpleInfoRequest listPipelineSimpleInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/pipelines/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPipelineSimpleInfoRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListPipelineSimpleInfoResponse>(response);
        }

        public AsyncInvoker<ListPipelineSimpleInfoResponse> ListPipelineSimpleInfoAsyncInvoker(ListPipelineSimpleInfoRequest listPipelineSimpleInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/pipelines/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPipelineSimpleInfoRequest);
            return new AsyncInvoker<ListPipelineSimpleInfoResponse>(this, "POST", request, JsonUtils.DeSerialize<ListPipelineSimpleInfoResponse>);
        }
        
        /// <summary>
        /// 查询模板列表
        ///
        /// 查询流水线模板列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPipelineTemplatesResponse> ListPipelineTemplatesAsync(ListPipelineTemplatesRequest listPipelineTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPipelineTemplatesRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{tenant_id}/api/pipeline-templates/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listPipelineTemplatesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListPipelineTemplatesResponse>(response);
        }

        public AsyncInvoker<ListPipelineTemplatesResponse> ListPipelineTemplatesAsyncInvoker(ListPipelineTemplatesRequest listPipelineTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPipelineTemplatesRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{tenant_id}/api/pipeline-templates/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listPipelineTemplatesRequest);
            return new AsyncInvoker<ListPipelineTemplatesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListPipelineTemplatesResponse>);
        }
        
        /// <summary>
        /// 获取流水线列表/获取项目下流水线执行状况
        ///
        /// 获取流水线列表/获取项目下流水线执行状况
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPipelinesResponse> ListPipelinesAsync(ListPipelinesRequest listPipelinesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPipelinesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listPipelinesRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListPipelinesResponse>(response);
        }

        public AsyncInvoker<ListPipelinesResponse> ListPipelinesAsyncInvoker(ListPipelinesRequest listPipelinesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPipelinesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listPipelinesRequest);
            return new AsyncInvoker<ListPipelinesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListPipelinesResponse>);
        }
        
        /// <summary>
        /// 获取项目下流水线执行状况
        ///
        /// 获取项目下流水线执行状况
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPipleineBuildResultResponse> ListPipleineBuildResultAsync(ListPipleineBuildResultRequest listPipleineBuildResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/pipelines/build-result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPipleineBuildResultRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPipleineBuildResultResponse>(response);
        }

        public AsyncInvoker<ListPipleineBuildResultResponse> ListPipleineBuildResultAsyncInvoker(ListPipleineBuildResultRequest listPipleineBuildResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/pipelines/build-result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPipleineBuildResultRequest);
            return new AsyncInvoker<ListPipleineBuildResultResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPipleineBuildResultResponse>);
        }
        
        /// <summary>
        /// 查询插件版本号
        ///
        /// 查询插件版本号
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPluginVersionNumberResponse> ListPluginVersionNumberAsync(ListPluginVersionNumberRequest listPluginVersionNumberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPluginVersionNumberRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/all-version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPluginVersionNumberRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPluginVersionNumberResponse>(response);
        }

        public AsyncInvoker<ListPluginVersionNumberResponse> ListPluginVersionNumberAsyncInvoker(ListPluginVersionNumberRequest listPluginVersionNumberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPluginVersionNumberRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/all-version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPluginVersionNumberRequest);
            return new AsyncInvoker<ListPluginVersionNumberResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPluginVersionNumberResponse>);
        }
        
        /// <summary>
        /// 查询插件列表
        ///
        /// 查询插件列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPluginsResponse> ListPluginsAsync(ListPluginsRequest listPluginsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPluginsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/query-all", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listPluginsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListPluginsResponse>(response);
        }

        public AsyncInvoker<ListPluginsResponse> ListPluginsAsyncInvoker(ListPluginsRequest listPluginsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPluginsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/query-all", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listPluginsRequest);
            return new AsyncInvoker<ListPluginsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListPluginsResponse>);
        }
        
        /// <summary>
        /// 获取规则模板实例列表
        ///
        /// 获取策略列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListProjectStrategyResponse> ListProjectStrategyAsync(ListProjectStrategyRequest listProjectStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectStrategyRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rule-sets/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectStrategyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListProjectStrategyResponse>(response);
        }

        public AsyncInvoker<ListProjectStrategyResponse> ListProjectStrategyAsyncInvoker(ListProjectStrategyRequest listProjectStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectStrategyRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rule-sets/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectStrategyRequest);
            return new AsyncInvoker<ListProjectStrategyResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProjectStrategyResponse>);
        }
        
        /// <summary>
        /// 查询发布商列表
        ///
        /// 查询发布商列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListPublisherResponse> ListPublisherAsync(ListPublisherRequest listPublisherRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPublisherRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/publisher/query-all", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublisherRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListPublisherResponse>(response);
        }

        public AsyncInvoker<ListPublisherResponse> ListPublisherAsyncInvoker(ListPublisherRequest listPublisherRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPublisherRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/publisher/query-all", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublisherRequest);
            return new AsyncInvoker<ListPublisherResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPublisherResponse>);
        }
        
        /// <summary>
        /// 分页获取规则列表
        ///
        /// 分页获取规则列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListRuleResponse> ListRuleAsync(ListRuleRequest listRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRuleRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/rules/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListRuleResponse>(response);
        }

        public AsyncInvoker<ListRuleResponse> ListRuleAsyncInvoker(ListRuleRequest listRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRuleRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/rules/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRuleRequest);
            return new AsyncInvoker<ListRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRuleResponse>);
        }
        
        /// <summary>
        /// 查询可选插件列表
        ///
        /// 查询可选插件列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListStagePluginsResponse> ListStagePluginsAsync(ListStagePluginsRequest listStagePluginsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listStagePluginsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/relation/stage-plugins", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listStagePluginsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListStagePluginsResponse>(response);
        }

        public AsyncInvoker<ListStagePluginsResponse> ListStagePluginsAsyncInvoker(ListStagePluginsRequest listStagePluginsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listStagePluginsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/relation/stage-plugins", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listStagePluginsRequest);
            return new AsyncInvoker<ListStagePluginsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListStagePluginsResponse>);
        }
        
        /// <summary>
        /// 获取策略列表
        ///
        /// 获取策略列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListStrategyResponse> ListStrategyAsync(ListStrategyRequest listStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listStrategyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/tenant/rule-sets/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStrategyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListStrategyResponse>(response);
        }

        public AsyncInvoker<ListStrategyResponse> ListStrategyAsyncInvoker(ListStrategyRequest listStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listStrategyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/tenant/rule-sets/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStrategyRequest);
            return new AsyncInvoker<ListStrategyResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStrategyResponse>);
        }
        
        /// <summary>
        /// 查询模板列表
        ///
        /// 查询模板列表，支持分页查询,支持模板名字模糊查询
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTemplatesResponse> ListTemplatesAsync(ListTemplatesRequest listTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplatesRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ListTemplatesResponse>(response);
        }

        public AsyncInvoker<ListTemplatesResponse> ListTemplatesAsyncInvoker(ListTemplatesRequest listTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplatesRequest);
            return new AsyncInvoker<ListTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTemplatesResponse>);
        }
        
        /// <summary>
        /// 发布插件
        ///
        /// 发布插件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<PublishPluginResponse> PublishPluginAsync(PublishPluginRequest publishPluginRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(publishPluginRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/publish-plugin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", publishPluginRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<PublishPluginResponse>(response);
        }

        public AsyncInvoker<PublishPluginResponse> PublishPluginAsyncInvoker(PublishPluginRequest publishPluginRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(publishPluginRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/publish-plugin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", publishPluginRequest);
            return new AsyncInvoker<PublishPluginResponse>(this, "POST", request, JsonUtils.DeSerializeNull<PublishPluginResponse>);
        }
        
        /// <summary>
        /// 插件绑定发布商
        ///
        /// 插件绑定发布商
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<PublishPluginBindResponse> PublishPluginBindAsync(PublishPluginBindRequest publishPluginBindRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(publishPluginBindRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/publish-plugin-bind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", publishPluginBindRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<PublishPluginBindResponse>(response);
        }

        public AsyncInvoker<PublishPluginBindResponse> PublishPluginBindAsyncInvoker(PublishPluginBindRequest publishPluginBindRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(publishPluginBindRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/publish-plugin-bind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", publishPluginBindRequest);
            return new AsyncInvoker<PublishPluginBindResponse>(this, "POST", request, JsonUtils.DeSerializeNull<PublishPluginBindResponse>);
        }
        
        /// <summary>
        /// 发布插件草稿
        ///
        /// 发布插件草稿
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<PublishPluginDraftResponse> PublishPluginDraftAsync(PublishPluginDraftRequest publishPluginDraftRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(publishPluginDraftRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/publish-draft", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", publishPluginDraftRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<PublishPluginDraftResponse>(response);
        }

        public AsyncInvoker<PublishPluginDraftResponse> PublishPluginDraftAsyncInvoker(PublishPluginDraftRequest publishPluginDraftRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(publishPluginDraftRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/publish-draft", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", publishPluginDraftRequest);
            return new AsyncInvoker<PublishPluginDraftResponse>(this, "POST", request, JsonUtils.DeSerializeNull<PublishPluginDraftResponse>);
        }
        
        /// <summary>
        /// 驳回人工审核
        ///
        /// 驳回人工审核
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RejectManualReviewResponse> RejectManualReviewAsync(RejectManualReviewRequest rejectManualReviewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rejectManualReviewRequest.JobRunId, out var valueOfJobRunId)) urlParam.Add("job_run_id", valueOfJobRunId);
            if (StringUtils.TryConvertToNonEmptyString(rejectManualReviewRequest.StepRunId, out var valueOfStepRunId)) urlParam.Add("step_run_id", valueOfStepRunId);
            if (StringUtils.TryConvertToNonEmptyString(rejectManualReviewRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(rejectManualReviewRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            if (StringUtils.TryConvertToNonEmptyString(rejectManualReviewRequest.PipelineRunId, out var valueOfPipelineRunId)) urlParam.Add("pipeline_run_id", valueOfPipelineRunId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/pipeline-runs/{pipeline_run_id}/jobs/{job_run_id}/steps/{step_run_id}/refuse", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rejectManualReviewRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RejectManualReviewResponse>(response);
        }

        public AsyncInvoker<RejectManualReviewResponse> RejectManualReviewAsyncInvoker(RejectManualReviewRequest rejectManualReviewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rejectManualReviewRequest.JobRunId, out var valueOfJobRunId)) urlParam.Add("job_run_id", valueOfJobRunId);
            if (StringUtils.TryConvertToNonEmptyString(rejectManualReviewRequest.StepRunId, out var valueOfStepRunId)) urlParam.Add("step_run_id", valueOfStepRunId);
            if (StringUtils.TryConvertToNonEmptyString(rejectManualReviewRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(rejectManualReviewRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            if (StringUtils.TryConvertToNonEmptyString(rejectManualReviewRequest.PipelineRunId, out var valueOfPipelineRunId)) urlParam.Add("pipeline_run_id", valueOfPipelineRunId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/pipeline-runs/{pipeline_run_id}/jobs/{job_run_id}/steps/{step_run_id}/refuse", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rejectManualReviewRequest);
            return new AsyncInvoker<RejectManualReviewResponse>(this, "POST", request, JsonUtils.DeSerialize<RejectManualReviewResponse>);
        }
        
        /// <summary>
        /// 删除流水线
        ///
        /// 根据id删除流水线
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RemovePipelineResponse> RemovePipelineAsync(RemovePipelineRequest removePipelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removePipelineRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v3/pipelines/{pipeline_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removePipelineRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<RemovePipelineResponse>(response);
        }

        public AsyncInvoker<RemovePipelineResponse> RemovePipelineAsyncInvoker(RemovePipelineRequest removePipelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removePipelineRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v3/pipelines/{pipeline_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removePipelineRequest);
            return new AsyncInvoker<RemovePipelineResponse>(this, "DELETE", request, JsonUtils.DeSerialize<RemovePipelineResponse>);
        }
        
        /// <summary>
        /// 重试运行流水线
        ///
        /// 重试运行流水线
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RetryPipelineRunResponse> RetryPipelineRunAsync(RetryPipelineRunRequest retryPipelineRunRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(retryPipelineRunRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(retryPipelineRunRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            if (StringUtils.TryConvertToNonEmptyString(retryPipelineRunRequest.PipelineRunId, out var valueOfPipelineRunId)) urlParam.Add("pipeline_run_id", valueOfPipelineRunId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/pipeline-runs/{pipeline_run_id}/retry", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryPipelineRunRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<RetryPipelineRunResponse>(response);
        }

        public AsyncInvoker<RetryPipelineRunResponse> RetryPipelineRunAsyncInvoker(RetryPipelineRunRequest retryPipelineRunRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(retryPipelineRunRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(retryPipelineRunRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            if (StringUtils.TryConvertToNonEmptyString(retryPipelineRunRequest.PipelineRunId, out var valueOfPipelineRunId)) urlParam.Add("pipeline_run_id", valueOfPipelineRunId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/pipeline-runs/{pipeline_run_id}/retry", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryPipelineRunRequest);
            return new AsyncInvoker<RetryPipelineRunResponse>(this, "PUT", request, JsonUtils.DeSerialize<RetryPipelineRunResponse>);
        }
        
        /// <summary>
        /// 启动流水线
        ///
        /// 启动流水线
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunPipelineResponse> RunPipelineAsync(RunPipelineRequest runPipelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runPipelineRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(runPipelineRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/run", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runPipelineRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RunPipelineResponse>(response);
        }

        public AsyncInvoker<RunPipelineResponse> RunPipelineAsyncInvoker(RunPipelineRequest runPipelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runPipelineRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(runPipelineRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/run", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runPipelineRequest);
            return new AsyncInvoker<RunPipelineResponse>(this, "POST", request, JsonUtils.DeSerialize<RunPipelineResponse>);
        }
        
        /// <summary>
        /// 查询基础插件详情
        ///
        /// 查询基础插件详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowBasicPluginResponse> ShowBasicPluginAsync(ShowBasicPluginRequest showBasicPluginRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBasicPluginRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/extension/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBasicPluginRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowBasicPluginResponse>(response);
        }

        public AsyncInvoker<ShowBasicPluginResponse> ShowBasicPluginAsyncInvoker(ShowBasicPluginRequest showBasicPluginRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBasicPluginRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/extension/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBasicPluginRequest);
            return new AsyncInvoker<ShowBasicPluginResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBasicPluginResponse>);
        }
        
        /// <summary>
        /// 检查流水线创建状态
        ///
        /// 检查流水线创建状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowInstanceStatusResponse> ShowInstanceStatusAsync(ShowInstanceStatusRequest showInstanceStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceStatusRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v3/templates/{task_id}/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceStatusResponse>(response);
        }

        public AsyncInvoker<ShowInstanceStatusResponse> ShowInstanceStatusAsyncInvoker(ShowInstanceStatusRequest showInstanceStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceStatusRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v3/templates/{task_id}/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceStatusRequest);
            return new AsyncInvoker<ShowInstanceStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceStatusResponse>);
        }
        
        /// <summary>
        /// 查询流水线上的构建产物
        ///
        /// 查询流水线上的构建产物
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPipelineArtifactsResponse> ShowPipelineArtifactsAsync(ShowPipelineArtifactsRequest showPipelineArtifactsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPipelineArtifactsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showPipelineArtifactsRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            if (StringUtils.TryConvertToNonEmptyString(showPipelineArtifactsRequest.PipelineRunId, out var valueOfPipelineRunId)) urlParam.Add("pipeline_run_id", valueOfPipelineRunId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/pipeline-runs/{pipeline_run_id}/artifacts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPipelineArtifactsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPipelineArtifactsResponse>(response);
        }

        public AsyncInvoker<ShowPipelineArtifactsResponse> ShowPipelineArtifactsAsyncInvoker(ShowPipelineArtifactsRequest showPipelineArtifactsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPipelineArtifactsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showPipelineArtifactsRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            if (StringUtils.TryConvertToNonEmptyString(showPipelineArtifactsRequest.PipelineRunId, out var valueOfPipelineRunId)) urlParam.Add("pipeline_run_id", valueOfPipelineRunId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/pipeline-runs/{pipeline_run_id}/artifacts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPipelineArtifactsRequest);
            return new AsyncInvoker<ShowPipelineArtifactsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPipelineArtifactsResponse>);
        }
        
        /// <summary>
        /// 查询流水线详情
        ///
        /// 查询流水线详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPipelineDetailResponse> ShowPipelineDetailAsync(ShowPipelineDetailRequest showPipelineDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPipelineDetailRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showPipelineDetailRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPipelineDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPipelineDetailResponse>(response);
        }

        public AsyncInvoker<ShowPipelineDetailResponse> ShowPipelineDetailAsyncInvoker(ShowPipelineDetailRequest showPipelineDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPipelineDetailRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showPipelineDetailRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPipelineDetailRequest);
            return new AsyncInvoker<ShowPipelineDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPipelineDetailResponse>);
        }
        
        /// <summary>
        /// 查询流水线分组树
        ///
        /// 查询流水线分组树
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPipelineGroupTreeResponse> ShowPipelineGroupTreeAsync(ShowPipelineGroupTreeRequest showPipelineGroupTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPipelineGroupTreeRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipeline-group/tree", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPipelineGroupTreeRequest);
            var response = await DoHttpRequestAsync("GET", request);
            var showPipelineGroupTreeResponse = JsonUtils.DeSerializeNull<ShowPipelineGroupTreeResponse>(response);
            showPipelineGroupTreeResponse.Body = JsonUtils.DeSerializeList<PipelineGroupVo>(response);
            return showPipelineGroupTreeResponse;
        }

        public AsyncInvoker<ShowPipelineGroupTreeResponse> ShowPipelineGroupTreeAsyncInvoker(ShowPipelineGroupTreeRequest showPipelineGroupTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPipelineGroupTreeRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipeline-group/tree", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPipelineGroupTreeRequest);
            return new AsyncInvoker<ShowPipelineGroupTreeResponse>(this, "GET", request, response =>
            {
                var showPipelineGroupTreeResponse = JsonUtils.DeSerializeNull<ShowPipelineGroupTreeResponse>(response);
                showPipelineGroupTreeResponse.Body = JsonUtils.DeSerializeList<PipelineGroupVo>(response);
                return showPipelineGroupTreeResponse;
            });
        }
        
        /// <summary>
        /// 查询流水线日志
        ///
        /// 查询流水线日志
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPipelineLogResponse> ShowPipelineLogAsync(ShowPipelineLogRequest showPipelineLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPipelineLogRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showPipelineLogRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            if (StringUtils.TryConvertToNonEmptyString(showPipelineLogRequest.PipelineRunId, out var valueOfPipelineRunId)) urlParam.Add("pipeline_run_id", valueOfPipelineRunId);
            if (StringUtils.TryConvertToNonEmptyString(showPipelineLogRequest.JobRunId, out var valueOfJobRunId)) urlParam.Add("job_run_id", valueOfJobRunId);
            if (StringUtils.TryConvertToNonEmptyString(showPipelineLogRequest.StepRunId, out var valueOfStepRunId)) urlParam.Add("step_run_id", valueOfStepRunId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/pipeline-runs/{pipeline_run_id}/jobs/{job_run_id}/steps/{step_run_id}/logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showPipelineLogRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShowPipelineLogResponse>(response);
        }

        public AsyncInvoker<ShowPipelineLogResponse> ShowPipelineLogAsyncInvoker(ShowPipelineLogRequest showPipelineLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPipelineLogRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showPipelineLogRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            if (StringUtils.TryConvertToNonEmptyString(showPipelineLogRequest.PipelineRunId, out var valueOfPipelineRunId)) urlParam.Add("pipeline_run_id", valueOfPipelineRunId);
            if (StringUtils.TryConvertToNonEmptyString(showPipelineLogRequest.JobRunId, out var valueOfJobRunId)) urlParam.Add("job_run_id", valueOfJobRunId);
            if (StringUtils.TryConvertToNonEmptyString(showPipelineLogRequest.StepRunId, out var valueOfStepRunId)) urlParam.Add("step_run_id", valueOfStepRunId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/pipeline-runs/{pipeline_run_id}/jobs/{job_run_id}/steps/{step_run_id}/logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showPipelineLogRequest);
            return new AsyncInvoker<ShowPipelineLogResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowPipelineLogResponse>);
        }
        
        /// <summary>
        /// 获取流水线状态/获取流水线执行详情
        ///
        /// 获取流水线状态/获取流水线执行详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPipelineRunDetailResponse> ShowPipelineRunDetailAsync(ShowPipelineRunDetailRequest showPipelineRunDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPipelineRunDetailRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showPipelineRunDetailRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/pipeline-runs/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPipelineRunDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPipelineRunDetailResponse>(response);
        }

        public AsyncInvoker<ShowPipelineRunDetailResponse> ShowPipelineRunDetailAsyncInvoker(ShowPipelineRunDetailRequest showPipelineRunDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPipelineRunDetailRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showPipelineRunDetailRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/pipeline-runs/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPipelineRunDetailRequest);
            return new AsyncInvoker<ShowPipelineRunDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPipelineRunDetailResponse>);
        }
        
        /// <summary>
        /// 查询模板详情
        ///
        /// 查询模板详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPipelineTemplateDetailResponse> ShowPipelineTemplateDetailAsync(ShowPipelineTemplateDetailRequest showPipelineTemplateDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPipelineTemplateDetailRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(showPipelineTemplateDetailRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{tenant_id}/api/pipeline-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPipelineTemplateDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPipelineTemplateDetailResponse>(response);
        }

        public AsyncInvoker<ShowPipelineTemplateDetailResponse> ShowPipelineTemplateDetailAsyncInvoker(ShowPipelineTemplateDetailRequest showPipelineTemplateDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPipelineTemplateDetailRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(showPipelineTemplateDetailRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{tenant_id}/api/pipeline-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPipelineTemplateDetailRequest);
            return new AsyncInvoker<ShowPipelineTemplateDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPipelineTemplateDetailResponse>);
        }
        
        /// <summary>
        /// 获取流水线状态
        ///
        /// 获取流水线状态,阶段及任务信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPipleineStatusResponse> ShowPipleineStatusAsync(ShowPipleineStatusRequest showPipleineStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPipleineStatusRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v3/pipelines/{pipeline_id}/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPipleineStatusRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPipleineStatusResponse>(response);
        }

        public AsyncInvoker<ShowPipleineStatusResponse> ShowPipleineStatusAsyncInvoker(ShowPipleineStatusRequest showPipleineStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPipleineStatusRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v3/pipelines/{pipeline_id}/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPipleineStatusRequest);
            return new AsyncInvoker<ShowPipleineStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPipleineStatusResponse>);
        }
        
        /// <summary>
        /// 查询插件输入配置
        ///
        /// 查询插件输入配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPluginInputsResponse> ShowPluginInputsAsync(ShowPluginInputsRequest showPluginInputsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPluginInputsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/plugin-input", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showPluginInputsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            var showPluginInputsResponse = JsonUtils.DeSerializeNull<ShowPluginInputsResponse>(response);
            showPluginInputsResponse.Body = JsonUtils.DeSerializeList<PluginPartQueryVOListAgentPluginInputVO>(response);
            return showPluginInputsResponse;
        }

        public AsyncInvoker<ShowPluginInputsResponse> ShowPluginInputsAsyncInvoker(ShowPluginInputsRequest showPluginInputsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPluginInputsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/plugin-input", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showPluginInputsRequest);
            return new AsyncInvoker<ShowPluginInputsResponse>(this, "POST", request, response =>
            {
                var showPluginInputsResponse = JsonUtils.DeSerializeNull<ShowPluginInputsResponse>(response);
                showPluginInputsResponse.Body = JsonUtils.DeSerializeList<PluginPartQueryVOListAgentPluginInputVO>(response);
                return showPluginInputsResponse;
            });
        }
        
        /// <summary>
        /// 查询插件指标配置
        ///
        /// 查询插件指标配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPluginMetricsResponse> ShowPluginMetricsAsync(ShowPluginMetricsRequest showPluginMetricsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPluginMetricsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/plugin-metrics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showPluginMetricsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            var showPluginMetricsResponse = JsonUtils.DeSerializeNull<ShowPluginMetricsResponse>(response);
            showPluginMetricsResponse.Body = JsonUtils.DeSerializeList<PluginPartQueryVOListAgentPluginOutputVO>(response);
            return showPluginMetricsResponse;
        }

        public AsyncInvoker<ShowPluginMetricsResponse> ShowPluginMetricsAsyncInvoker(ShowPluginMetricsRequest showPluginMetricsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPluginMetricsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/plugin-metrics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showPluginMetricsRequest);
            return new AsyncInvoker<ShowPluginMetricsResponse>(this, "POST", request, response =>
            {
                var showPluginMetricsResponse = JsonUtils.DeSerializeNull<ShowPluginMetricsResponse>(response);
                showPluginMetricsResponse.Body = JsonUtils.DeSerializeList<PluginPartQueryVOListAgentPluginOutputVO>(response);
                return showPluginMetricsResponse;
            });
        }
        
        /// <summary>
        /// 查询插件输出配置
        ///
        /// 查询插件输出配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPluginOutputsResponse> ShowPluginOutputsAsync(ShowPluginOutputsRequest showPluginOutputsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPluginOutputsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/plugin-output", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showPluginOutputsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            var showPluginOutputsResponse = JsonUtils.DeSerializeNull<ShowPluginOutputsResponse>(response);
            showPluginOutputsResponse.Body = JsonUtils.DeSerializeList<PluginPartQueryVOListAgentPluginOutputVO>(response);
            return showPluginOutputsResponse;
        }

        public AsyncInvoker<ShowPluginOutputsResponse> ShowPluginOutputsAsyncInvoker(ShowPluginOutputsRequest showPluginOutputsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPluginOutputsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/plugin-output", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showPluginOutputsRequest);
            return new AsyncInvoker<ShowPluginOutputsResponse>(this, "POST", request, response =>
            {
                var showPluginOutputsResponse = JsonUtils.DeSerializeNull<ShowPluginOutputsResponse>(response);
                showPluginOutputsResponse.Body = JsonUtils.DeSerializeList<PluginPartQueryVOListAgentPluginOutputVO>(response);
                return showPluginOutputsResponse;
            });
        }
        
        /// <summary>
        /// 查询插件版本详情
        ///
        /// 查询插件版本详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPluginVersionResponse> ShowPluginVersionAsync(ShowPluginVersionRequest showPluginVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPluginVersionRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPluginVersionRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowPluginVersionResponse>(response);
        }

        public AsyncInvoker<ShowPluginVersionResponse> ShowPluginVersionAsyncInvoker(ShowPluginVersionRequest showPluginVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPluginVersionRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPluginVersionRequest);
            return new AsyncInvoker<ShowPluginVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPluginVersionResponse>);
        }
        
        /// <summary>
        /// 
        ///
        /// 查询项目级策略详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowProjectStrategyResponse> ShowProjectStrategyAsync(ShowProjectStrategyRequest showProjectStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectStrategyRequest.RuleSetId, out var valueOfRuleSetId)) urlParam.Add("rule_set_id", valueOfRuleSetId);
            if (StringUtils.TryConvertToNonEmptyString(showProjectStrategyRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rule-sets/{rule_set_id}/gray/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectStrategyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectStrategyResponse>(response);
        }

        public AsyncInvoker<ShowProjectStrategyResponse> ShowProjectStrategyAsyncInvoker(ShowProjectStrategyRequest showProjectStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectStrategyRequest.RuleSetId, out var valueOfRuleSetId)) urlParam.Add("rule_set_id", valueOfRuleSetId);
            if (StringUtils.TryConvertToNonEmptyString(showProjectStrategyRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rule-sets/{rule_set_id}/gray/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectStrategyRequest);
            return new AsyncInvoker<ShowProjectStrategyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectStrategyResponse>);
        }
        
        /// <summary>
        /// 查询发布商详情
        ///
        /// 查询发布商详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowPublisherResponse> ShowPublisherAsync(ShowPublisherRequest showPublisherRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPublisherRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/publisher/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showPublisherRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ShowPublisherResponse>(response);
        }

        public AsyncInvoker<ShowPublisherResponse> ShowPublisherAsyncInvoker(ShowPublisherRequest showPublisherRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPublisherRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/publisher/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showPublisherRequest);
            return new AsyncInvoker<ShowPublisherResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowPublisherResponse>);
        }
        
        /// <summary>
        /// 获取单条规则详情
        ///
        /// 获取单条规则详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowRuleResponse> ShowRuleAsync(ShowRuleRequest showRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRuleRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(showRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/rules/{rule_id}/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRuleRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowRuleResponse>(response);
        }

        public AsyncInvoker<ShowRuleResponse> ShowRuleAsyncInvoker(ShowRuleRequest showRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRuleRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(showRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/rules/{rule_id}/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRuleRequest);
            return new AsyncInvoker<ShowRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRuleResponse>);
        }
        
        /// <summary>
        /// 获取流水线步骤执行输出
        ///
        /// 获取流水线步骤执行输出
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowStepOutputsResponse> ShowStepOutputsAsync(ShowStepOutputsRequest showStepOutputsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showStepOutputsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showStepOutputsRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            if (StringUtils.TryConvertToNonEmptyString(showStepOutputsRequest.PipelineRunId, out var valueOfPipelineRunId)) urlParam.Add("pipeline_run_id", valueOfPipelineRunId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/pipeline-runs/{pipeline_run_id}/steps/outputs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStepOutputsRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowStepOutputsResponse>(response);
        }

        public AsyncInvoker<ShowStepOutputsResponse> ShowStepOutputsAsyncInvoker(ShowStepOutputsRequest showStepOutputsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showStepOutputsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showStepOutputsRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            if (StringUtils.TryConvertToNonEmptyString(showStepOutputsRequest.PipelineRunId, out var valueOfPipelineRunId)) urlParam.Add("pipeline_run_id", valueOfPipelineRunId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/pipeline-runs/{pipeline_run_id}/steps/outputs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStepOutputsRequest);
            return new AsyncInvoker<ShowStepOutputsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStepOutputsResponse>);
        }
        
        /// <summary>
        /// 获取策略详情
        ///
        /// 获取策略详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowStrategyResponse> ShowStrategyAsync(ShowStrategyRequest showStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showStrategyRequest.RuleSetId, out var valueOfRuleSetId)) urlParam.Add("rule_set_id", valueOfRuleSetId);
            if (StringUtils.TryConvertToNonEmptyString(showStrategyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/tenant/rule-sets/{rule_set_id}/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStrategyRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowStrategyResponse>(response);
        }

        public AsyncInvoker<ShowStrategyResponse> ShowStrategyAsyncInvoker(ShowStrategyRequest showStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showStrategyRequest.RuleSetId, out var valueOfRuleSetId)) urlParam.Add("rule_set_id", valueOfRuleSetId);
            if (StringUtils.TryConvertToNonEmptyString(showStrategyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/tenant/rule-sets/{rule_set_id}/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStrategyRequest);
            return new AsyncInvoker<ShowStrategyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStrategyResponse>);
        }
        
        /// <summary>
        /// 查询模板详情
        ///
        /// 查询模板详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTemplateDetailResponse> ShowTemplateDetailAsync(ShowTemplateDetailRequest showTemplateDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTemplateDetailRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v3/templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTemplateDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowTemplateDetailResponse>(response);
        }

        public AsyncInvoker<ShowTemplateDetailResponse> ShowTemplateDetailAsyncInvoker(ShowTemplateDetailRequest showTemplateDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTemplateDetailRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v3/templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTemplateDetailRequest);
            return new AsyncInvoker<ShowTemplateDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTemplateDetailResponse>);
        }
        
        /// <summary>
        /// 启动流水线
        ///
        /// 启动流水线
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StartNewPipelineResponse> StartNewPipelineAsync(StartNewPipelineRequest startNewPipelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startNewPipelineRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v3/pipelines/{pipeline_id}/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startNewPipelineRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StartNewPipelineResponse>(response);
        }

        public AsyncInvoker<StartNewPipelineResponse> StartNewPipelineAsyncInvoker(StartNewPipelineRequest startNewPipelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startNewPipelineRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v3/pipelines/{pipeline_id}/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startNewPipelineRequest);
            return new AsyncInvoker<StartNewPipelineResponse>(this, "POST", request, JsonUtils.DeSerialize<StartNewPipelineResponse>);
        }
        
        /// <summary>
        /// 停止流水线
        ///
        /// 停止流水线
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StopPipelineNewResponse> StopPipelineNewAsync(StopPipelineNewRequest stopPipelineNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopPipelineNewRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v3/pipelines/{pipeline_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopPipelineNewRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StopPipelineNewResponse>(response);
        }

        public AsyncInvoker<StopPipelineNewResponse> StopPipelineNewAsyncInvoker(StopPipelineNewRequest stopPipelineNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopPipelineNewRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v3/pipelines/{pipeline_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopPipelineNewRequest);
            return new AsyncInvoker<StopPipelineNewResponse>(this, "POST", request, JsonUtils.DeSerialize<StopPipelineNewResponse>);
        }
        
        /// <summary>
        /// 停止流水线
        ///
        /// 停止流水线
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<StopPipelineRunResponse> StopPipelineRunAsync(StopPipelineRunRequest stopPipelineRunRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopPipelineRunRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(stopPipelineRunRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            if (StringUtils.TryConvertToNonEmptyString(stopPipelineRunRequest.PipelineRunId, out var valueOfPipelineRunId)) urlParam.Add("pipeline_run_id", valueOfPipelineRunId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/pipeline-runs/{pipeline_run_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopPipelineRunRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<StopPipelineRunResponse>(response);
        }

        public AsyncInvoker<StopPipelineRunResponse> StopPipelineRunAsyncInvoker(StopPipelineRunRequest stopPipelineRunRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopPipelineRunRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(stopPipelineRunRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            if (StringUtils.TryConvertToNonEmptyString(stopPipelineRunRequest.PipelineRunId, out var valueOfPipelineRunId)) urlParam.Add("pipeline_run_id", valueOfPipelineRunId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/pipeline-runs/{pipeline_run_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopPipelineRunRequest);
            return new AsyncInvoker<StopPipelineRunResponse>(this, "POST", request, JsonUtils.DeSerialize<StopPipelineRunResponse>);
        }
        
        /// <summary>
        /// 开关策略
        ///
        /// 修改策略状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<SwitchStrategyResponse> SwitchStrategyAsync(SwitchStrategyRequest switchStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchStrategyRequest.RuleSetId, out var valueOfRuleSetId)) urlParam.Add("rule_set_id", valueOfRuleSetId);
            if (StringUtils.TryConvertToNonEmptyString(switchStrategyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/tenant/rule-sets/{rule_set_id}/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchStrategyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<SwitchStrategyResponse>(response);
        }

        public AsyncInvoker<SwitchStrategyResponse> SwitchStrategyAsyncInvoker(SwitchStrategyRequest switchStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchStrategyRequest.RuleSetId, out var valueOfRuleSetId)) urlParam.Add("rule_set_id", valueOfRuleSetId);
            if (StringUtils.TryConvertToNonEmptyString(switchStrategyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/tenant/rule-sets/{rule_set_id}/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchStrategyRequest);
            return new AsyncInvoker<SwitchStrategyResponse>(this, "PUT", request, JsonUtils.DeSerialize<SwitchStrategyResponse>);
        }
        
        /// <summary>
        /// 更新基础插件
        ///
        /// 更新基础插件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateBasicPluginResponse> UpdateBasicPluginAsync(UpdateBasicPluginRequest updateBasicPluginRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateBasicPluginRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/extension/info/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateBasicPluginRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateBasicPluginResponse>(response);
        }

        public AsyncInvoker<UpdateBasicPluginResponse> UpdateBasicPluginAsyncInvoker(UpdateBasicPluginRequest updateBasicPluginRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateBasicPluginRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/extension/info/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateBasicPluginRequest);
            return new AsyncInvoker<UpdateBasicPluginResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateBasicPluginResponse>);
        }
        
        /// <summary>
        /// 更新流水线分组
        ///
        /// 更新流水线分组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePipelineGroupResponse> UpdatePipelineGroupAsync(UpdatePipelineGroupRequest updatePipelineGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePipelineGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipeline-group/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePipelineGroupRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<UpdatePipelineGroupResponse>(response);
        }

        public AsyncInvoker<UpdatePipelineGroupResponse> UpdatePipelineGroupAsyncInvoker(UpdatePipelineGroupRequest updatePipelineGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePipelineGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipeline-group/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePipelineGroupRequest);
            return new AsyncInvoker<UpdatePipelineGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdatePipelineGroupResponse>);
        }
        
        /// <summary>
        /// 修改流水线信息
        ///
        /// 修改流水线信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePipelineInfoResponse> UpdatePipelineInfoAsync(UpdatePipelineInfoRequest updatePipelineInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePipelineInfoRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(updatePipelineInfoRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePipelineInfoRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePipelineInfoResponse>(response);
        }

        public AsyncInvoker<UpdatePipelineInfoResponse> UpdatePipelineInfoAsyncInvoker(UpdatePipelineInfoRequest updatePipelineInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePipelineInfoRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(updatePipelineInfoRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePipelineInfoRequest);
            return new AsyncInvoker<UpdatePipelineInfoResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePipelineInfoResponse>);
        }
        
        /// <summary>
        /// 更新流水线模板
        ///
        /// 更新流水线模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePipelineTemplateResponse> UpdatePipelineTemplateAsync(UpdatePipelineTemplateRequest updatePipelineTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePipelineTemplateRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(updatePipelineTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{tenant_id}/api/pipeline-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePipelineTemplateRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePipelineTemplateResponse>(response);
        }

        public AsyncInvoker<UpdatePipelineTemplateResponse> UpdatePipelineTemplateAsyncInvoker(UpdatePipelineTemplateRequest updatePipelineTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePipelineTemplateRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(updatePipelineTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{tenant_id}/api/pipeline-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePipelineTemplateRequest);
            return new AsyncInvoker<UpdatePipelineTemplateResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePipelineTemplateResponse>);
        }
        
        /// <summary>
        /// 更新插件基本信息
        ///
        /// 更新插件基本信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePluginBaseInfoResponse> UpdatePluginBaseInfoAsync(UpdatePluginBaseInfoRequest updatePluginBaseInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePluginBaseInfoRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/update-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePluginBaseInfoRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UpdatePluginBaseInfoResponse>(response);
        }

        public AsyncInvoker<UpdatePluginBaseInfoResponse> UpdatePluginBaseInfoAsyncInvoker(UpdatePluginBaseInfoRequest updatePluginBaseInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePluginBaseInfoRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/update-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePluginBaseInfoRequest);
            return new AsyncInvoker<UpdatePluginBaseInfoResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdatePluginBaseInfoResponse>);
        }
        
        /// <summary>
        /// 更新插件草稿
        ///
        /// 更新插件草稿
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdatePluginDraftResponse> UpdatePluginDraftAsync(UpdatePluginDraftRequest updatePluginDraftRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePluginDraftRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/edit-draft", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePluginDraftRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UpdatePluginDraftResponse>(response);
        }

        public AsyncInvoker<UpdatePluginDraftResponse> UpdatePluginDraftAsyncInvoker(UpdatePluginDraftRequest updatePluginDraftRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePluginDraftRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/edit-draft", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePluginDraftRequest);
            return new AsyncInvoker<UpdatePluginDraftResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdatePluginDraftResponse>);
        }
        
        /// <summary>
        /// 更新规则
        ///
        /// 更新规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateRuleResponse> UpdateRuleAsync(UpdateRuleRequest updateRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRuleRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(updateRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/rules/{rule_id}/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateRuleRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRuleResponse>(response);
        }

        public AsyncInvoker<UpdateRuleResponse> UpdateRuleAsyncInvoker(UpdateRuleRequest updateRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRuleRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(updateRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/rules/{rule_id}/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateRuleRequest);
            return new AsyncInvoker<UpdateRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRuleResponse>);
        }
        
        /// <summary>
        /// 修改策略
        ///
        /// 修改策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateStrategyResponse> UpdateStrategyAsync(UpdateStrategyRequest updateStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateStrategyRequest.RuleSetId, out var valueOfRuleSetId)) urlParam.Add("rule_set_id", valueOfRuleSetId);
            if (StringUtils.TryConvertToNonEmptyString(updateStrategyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/tenant/rule-sets/{rule_set_id}/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateStrategyRequest);
            var response = await DoHttpRequestAsync("PUT", request);
            return JsonUtils.DeSerialize<UpdateStrategyResponse>(response);
        }

        public AsyncInvoker<UpdateStrategyResponse> UpdateStrategyAsyncInvoker(UpdateStrategyRequest updateStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateStrategyRequest.RuleSetId, out var valueOfRuleSetId)) urlParam.Add("rule_set_id", valueOfRuleSetId);
            if (StringUtils.TryConvertToNonEmptyString(updateStrategyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/tenant/rule-sets/{rule_set_id}/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateStrategyRequest);
            return new AsyncInvoker<UpdateStrategyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateStrategyResponse>);
        }
        
        /// <summary>
        /// 上传基础插件
        ///
        /// 上传基础插件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UploadBasicPluginResponse> UploadBasicPluginAsync(UploadBasicPluginRequest uploadBasicPluginRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(uploadBasicPluginRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/extension/upload", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadBasicPluginRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UploadBasicPluginResponse>(response);
        }

        public AsyncInvoker<UploadBasicPluginResponse> UploadBasicPluginAsyncInvoker(UploadBasicPluginRequest uploadBasicPluginRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(uploadBasicPluginRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/extension/upload", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadBasicPluginRequest);
            return new AsyncInvoker<UploadBasicPluginResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UploadBasicPluginResponse>);
        }
        
        /// <summary>
        /// 更新插件图标
        ///
        /// 更新插件图标
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UploadPluginIconResponse> UploadPluginIconAsync(UploadPluginIconRequest uploadPluginIconRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(uploadPluginIconRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/common/upload-plugin-icon", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadPluginIconRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UploadPluginIconResponse>(response);
        }

        public AsyncInvoker<UploadPluginIconResponse> UploadPluginIconAsyncInvoker(UploadPluginIconRequest uploadPluginIconRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(uploadPluginIconRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/common/upload-plugin-icon", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadPluginIconRequest);
            return new AsyncInvoker<UploadPluginIconResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UploadPluginIconResponse>);
        }
        
        /// <summary>
        /// 更新发布商图标
        ///
        /// 更新发布商图标
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UploadPublisherIconResponse> UploadPublisherIconAsync(UploadPublisherIconRequest uploadPublisherIconRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(uploadPublisherIconRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/common/upload-publisher-icon", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadPublisherIconRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerializeNull<UploadPublisherIconResponse>(response);
        }

        public AsyncInvoker<UploadPublisherIconResponse> UploadPublisherIconAsyncInvoker(UploadPublisherIconRequest uploadPublisherIconRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(uploadPublisherIconRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/common/upload-publisher-icon", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadPublisherIconRequest);
            return new AsyncInvoker<UploadPublisherIconResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UploadPublisherIconResponse>);
        }
        
        /// <summary>
        /// 删除gitcode流水线运行详情
        ///
        /// 删除gitcode流水线运行详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteActionsRunPipelineResponse> DeleteActionsRunPipelineAsync(DeleteActionsRunPipelineRequest deleteActionsRunPipelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteActionsRunPipelineRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(deleteActionsRunPipelineRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            if (StringUtils.TryConvertToNonEmptyString(deleteActionsRunPipelineRequest.PipelineRunId, out var valueOfPipelineRunId)) urlParam.Add("pipeline_run_id", valueOfPipelineRunId);
            var urlPath = HttpUtils.AddUrlPath("/v6/{domain_id}/api/pac/pipelines/actions/{pipeline_id}/{pipeline_run_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteActionsRunPipelineRequest);
            var response = await DoHttpRequestAsync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteActionsRunPipelineResponse>(response);
        }

        public AsyncInvoker<DeleteActionsRunPipelineResponse> DeleteActionsRunPipelineAsyncInvoker(DeleteActionsRunPipelineRequest deleteActionsRunPipelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteActionsRunPipelineRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(deleteActionsRunPipelineRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            if (StringUtils.TryConvertToNonEmptyString(deleteActionsRunPipelineRequest.PipelineRunId, out var valueOfPipelineRunId)) urlParam.Add("pipeline_run_id", valueOfPipelineRunId);
            var urlPath = HttpUtils.AddUrlPath("/v6/{domain_id}/api/pac/pipelines/actions/{pipeline_id}/{pipeline_run_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteActionsRunPipelineRequest);
            return new AsyncInvoker<DeleteActionsRunPipelineResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteActionsRunPipelineResponse>);
        }
        
        /// <summary>
        /// 查询gitcode流水线运行记录
        ///
        /// 查询gitcode流水线运行记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListActionsPipelineRunsResponse> ListActionsPipelineRunsAsync(ListActionsPipelineRunsRequest listActionsPipelineRunsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listActionsPipelineRunsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v6/{domain_id}/api/pac/pipelines/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listActionsPipelineRunsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListActionsPipelineRunsResponse>(response);
        }

        public AsyncInvoker<ListActionsPipelineRunsResponse> ListActionsPipelineRunsAsyncInvoker(ListActionsPipelineRunsRequest listActionsPipelineRunsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listActionsPipelineRunsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v6/{domain_id}/api/pac/pipelines/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listActionsPipelineRunsRequest);
            return new AsyncInvoker<ListActionsPipelineRunsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListActionsPipelineRunsResponse>);
        }
        
        /// <summary>
        /// 查询gitcode流水线action列表
        ///
        /// 查询gitcode流水线action列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListActionsPipelineRunsByRunIdsResponse> ListActionsPipelineRunsByRunIdsAsync(ListActionsPipelineRunsByRunIdsRequest listActionsPipelineRunsByRunIdsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listActionsPipelineRunsByRunIdsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v6/{domain_id}/api/pac/pipelines/actions/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listActionsPipelineRunsByRunIdsRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<ListActionsPipelineRunsByRunIdsResponse>(response);
        }

        public AsyncInvoker<ListActionsPipelineRunsByRunIdsResponse> ListActionsPipelineRunsByRunIdsAsyncInvoker(ListActionsPipelineRunsByRunIdsRequest listActionsPipelineRunsByRunIdsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listActionsPipelineRunsByRunIdsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v6/{domain_id}/api/pac/pipelines/actions/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listActionsPipelineRunsByRunIdsRequest);
            return new AsyncInvoker<ListActionsPipelineRunsByRunIdsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListActionsPipelineRunsByRunIdsResponse>);
        }
        
        /// <summary>
        /// 重试运行gitcode流水线
        ///
        /// 重试运行gitcode流水线
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RetryRunActionsPipelineResponse> RetryRunActionsPipelineAsync(RetryRunActionsPipelineRequest retryRunActionsPipelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(retryRunActionsPipelineRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v6/{domain_id}/api/pac/pipelines/actions/rerun", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", retryRunActionsPipelineRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RetryRunActionsPipelineResponse>(response);
        }

        public AsyncInvoker<RetryRunActionsPipelineResponse> RetryRunActionsPipelineAsyncInvoker(RetryRunActionsPipelineRequest retryRunActionsPipelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(retryRunActionsPipelineRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v6/{domain_id}/api/pac/pipelines/actions/rerun", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", retryRunActionsPipelineRequest);
            return new AsyncInvoker<RetryRunActionsPipelineResponse>(this, "POST", request, JsonUtils.DeSerialize<RetryRunActionsPipelineResponse>);
        }
        
        /// <summary>
        /// 运行gitcode流水线
        ///
        /// 运行gitcode流水线
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<RunActionsPipelineResponse> RunActionsPipelineAsync(RunActionsPipelineRequest runActionsPipelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runActionsPipelineRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v6/{domain_id}/api/pac/pipelines/actions/run", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runActionsPipelineRequest);
            var response = await DoHttpRequestAsync("POST", request);
            return JsonUtils.DeSerialize<RunActionsPipelineResponse>(response);
        }

        public AsyncInvoker<RunActionsPipelineResponse> RunActionsPipelineAsyncInvoker(RunActionsPipelineRequest runActionsPipelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runActionsPipelineRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v6/{domain_id}/api/pac/pipelines/actions/run", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runActionsPipelineRequest);
            return new AsyncInvoker<RunActionsPipelineResponse>(this, "POST", request, JsonUtils.DeSerialize<RunActionsPipelineResponse>);
        }
        
        /// <summary>
        /// 查询gitcode流水线运行详情
        ///
        /// 查询gitcode流水线运行详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowActionsRunsDetailResponse> ShowActionsRunsDetailAsync(ShowActionsRunsDetailRequest showActionsRunsDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showActionsRunsDetailRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(showActionsRunsDetailRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            if (StringUtils.TryConvertToNonEmptyString(showActionsRunsDetailRequest.PipelineRunId, out var valueOfPipelineRunId)) urlParam.Add("pipeline_run_id", valueOfPipelineRunId);
            var urlPath = HttpUtils.AddUrlPath("/v6/{domain_id}/api/pac/pipelines/actions/{pipeline_id}/{pipeline_run_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showActionsRunsDetailRequest);
            var response = await DoHttpRequestAsync("GET", request);
            return JsonUtils.DeSerialize<ShowActionsRunsDetailResponse>(response);
        }

        public AsyncInvoker<ShowActionsRunsDetailResponse> ShowActionsRunsDetailAsyncInvoker(ShowActionsRunsDetailRequest showActionsRunsDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showActionsRunsDetailRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(showActionsRunsDetailRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            if (StringUtils.TryConvertToNonEmptyString(showActionsRunsDetailRequest.PipelineRunId, out var valueOfPipelineRunId)) urlParam.Add("pipeline_run_id", valueOfPipelineRunId);
            var urlPath = HttpUtils.AddUrlPath("/v6/{domain_id}/api/pac/pipelines/actions/{pipeline_id}/{pipeline_run_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showActionsRunsDetailRequest);
            return new AsyncInvoker<ShowActionsRunsDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowActionsRunsDetailResponse>);
        }
        
    }
}