using System;
using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.CodeArtsPipeline.V2.Model;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2
{
    public partial class CodeArtsPipelineClient : Client
    {
        public static ClientBuilder<CodeArtsPipelineClient> NewBuilder()
        {
            return new ClientBuilder<CodeArtsPipelineClient>();
        }

        
        /// <summary>
        /// 通过人工审核
        ///
        /// 通过人工审核
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public AcceptManualReviewResponse AcceptManualReview(AcceptManualReviewRequest acceptManualReviewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(acceptManualReviewRequest.JobRunId, out var valueOfJobRunId)) urlParam.Add("job_run_id", valueOfJobRunId);
            if (StringUtils.TryConvertToNonEmptyString(acceptManualReviewRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(acceptManualReviewRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            if (StringUtils.TryConvertToNonEmptyString(acceptManualReviewRequest.PipelineRunId, out var valueOfPipelineRunId)) urlParam.Add("pipeline_run_id", valueOfPipelineRunId);
            if (StringUtils.TryConvertToNonEmptyString(acceptManualReviewRequest.StepRunId, out var valueOfStepRunId)) urlParam.Add("step_run_id", valueOfStepRunId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/pipeline-runs/{pipeline_run_id}/jobs/{job_run_id}/steps/{step_run_id}/pass", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", acceptManualReviewRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<AcceptManualReviewResponse>(response);
        }

        public SyncInvoker<AcceptManualReviewResponse> AcceptManualReviewInvoker(AcceptManualReviewRequest acceptManualReviewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(acceptManualReviewRequest.JobRunId, out var valueOfJobRunId)) urlParam.Add("job_run_id", valueOfJobRunId);
            if (StringUtils.TryConvertToNonEmptyString(acceptManualReviewRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(acceptManualReviewRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            if (StringUtils.TryConvertToNonEmptyString(acceptManualReviewRequest.PipelineRunId, out var valueOfPipelineRunId)) urlParam.Add("pipeline_run_id", valueOfPipelineRunId);
            if (StringUtils.TryConvertToNonEmptyString(acceptManualReviewRequest.StepRunId, out var valueOfStepRunId)) urlParam.Add("step_run_id", valueOfStepRunId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/pipeline-runs/{pipeline_run_id}/jobs/{job_run_id}/steps/{step_run_id}/pass", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", acceptManualReviewRequest);
            return new SyncInvoker<AcceptManualReviewResponse>(this, "POST", request, JsonUtils.DeSerialize<AcceptManualReviewResponse>);
        }
        
        /// <summary>
        /// 批量把流水线移动到分组下
        ///
        /// 批量把流水线移动到分组下
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public BatchMovePipelineToGroupResponse BatchMovePipelineToGroup(BatchMovePipelineToGroupRequest batchMovePipelineToGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchMovePipelineToGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipeline-group/pipeline/move", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchMovePipelineToGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            var batchMovePipelineToGroupResponse = JsonUtils.DeSerializeNull<BatchMovePipelineToGroupResponse>(response);
            batchMovePipelineToGroupResponse.Body = JsonUtils.DeSerializeList<PipelineMoveToGroupResponseVo>(response);
            return batchMovePipelineToGroupResponse;
        }

        public SyncInvoker<BatchMovePipelineToGroupResponse> BatchMovePipelineToGroupInvoker(BatchMovePipelineToGroupRequest batchMovePipelineToGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchMovePipelineToGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipeline-group/pipeline/move", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchMovePipelineToGroupRequest);
            return new SyncInvoker<BatchMovePipelineToGroupResponse>(this, "POST", request, response =>
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
        public BatchShowPipelinesLatestStatusResponse BatchShowPipelinesLatestStatus(BatchShowPipelinesLatestStatusRequest batchShowPipelinesLatestStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchShowPipelinesLatestStatusRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchShowPipelinesLatestStatusRequest);
            var response = DoHttpRequestSync("POST", request);
            var batchShowPipelinesLatestStatusResponse = JsonUtils.DeSerializeNull<BatchShowPipelinesLatestStatusResponse>(response);
            batchShowPipelinesLatestStatusResponse.Body = JsonUtils.DeSerializeList<PipelineLatestRun>(response);
            return batchShowPipelinesLatestStatusResponse;
        }

        public SyncInvoker<BatchShowPipelinesLatestStatusResponse> BatchShowPipelinesLatestStatusInvoker(BatchShowPipelinesLatestStatusRequest batchShowPipelinesLatestStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(batchShowPipelinesLatestStatusRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchShowPipelinesLatestStatusRequest);
            return new SyncInvoker<BatchShowPipelinesLatestStatusResponse>(this, "POST", request, response =>
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
        public BatchShowPipelinesStatusResponse BatchShowPipelinesStatus(BatchShowPipelinesStatusRequest batchShowPipelinesStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/pipelines/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchShowPipelinesStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            var batchShowPipelinesStatusResponse = JsonUtils.DeSerializeNull<BatchShowPipelinesStatusResponse>(response);
            batchShowPipelinesStatusResponse.Body = JsonUtils.DeSerializeList<PipelineExecuteStates>(response);
            return batchShowPipelinesStatusResponse;
        }

        public SyncInvoker<BatchShowPipelinesStatusResponse> BatchShowPipelinesStatusInvoker(BatchShowPipelinesStatusRequest batchShowPipelinesStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/pipelines/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchShowPipelinesStatusRequest);
            return new SyncInvoker<BatchShowPipelinesStatusResponse>(this, "GET", request, response =>
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
        public CreateBasicPluginResponse CreateBasicPlugin(CreateBasicPluginRequest createBasicPluginRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createBasicPluginRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/extension/info/add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createBasicPluginRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreateBasicPluginResponse>(response);
        }

        public SyncInvoker<CreateBasicPluginResponse> CreateBasicPluginInvoker(CreateBasicPluginRequest createBasicPluginRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createBasicPluginRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/extension/info/add", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createBasicPluginRequest);
            return new SyncInvoker<CreateBasicPluginResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreateBasicPluginResponse>);
        }
        
        /// <summary>
        /// 基于模板快速创建流水线及流水线内任务
        ///
        /// 基于模板快速创建流水线及流水线内任务
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePipelineByTemplateResponse CreatePipelineByTemplate(CreatePipelineByTemplateRequest createPipelineByTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/templates/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPipelineByTemplateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePipelineByTemplateResponse>(response);
        }

        public SyncInvoker<CreatePipelineByTemplateResponse> CreatePipelineByTemplateInvoker(CreatePipelineByTemplateRequest createPipelineByTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/templates/task", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPipelineByTemplateRequest);
            return new SyncInvoker<CreatePipelineByTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePipelineByTemplateResponse>);
        }
        
        /// <summary>
        /// 基于模板创建流水线
        ///
        /// 基于模板创建流水线
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePipelineByTemplateIdResponse CreatePipelineByTemplateId(CreatePipelineByTemplateIdRequest createPipelineByTemplateIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPipelineByTemplateIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(createPipelineByTemplateIdRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipeline-templates/{template_id}/create-pipeline", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPipelineByTemplateIdRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePipelineByTemplateIdResponse>(response);
        }

        public SyncInvoker<CreatePipelineByTemplateIdResponse> CreatePipelineByTemplateIdInvoker(CreatePipelineByTemplateIdRequest createPipelineByTemplateIdRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPipelineByTemplateIdRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(createPipelineByTemplateIdRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipeline-templates/{template_id}/create-pipeline", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPipelineByTemplateIdRequest);
            return new SyncInvoker<CreatePipelineByTemplateIdResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePipelineByTemplateIdResponse>);
        }
        
        /// <summary>
        /// 新建流水线分组
        ///
        /// 新建流水线分组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePipelineGroupResponse CreatePipelineGroup(CreatePipelineGroupRequest createPipelineGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPipelineGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipeline-group/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPipelineGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePipelineGroupResponse>(response);
        }

        public SyncInvoker<CreatePipelineGroupResponse> CreatePipelineGroupInvoker(CreatePipelineGroupRequest createPipelineGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPipelineGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipeline-group/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPipelineGroupRequest);
            return new SyncInvoker<CreatePipelineGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePipelineGroupResponse>);
        }
        
        /// <summary>
        /// 创建流水线
        ///
        /// 创建流水线
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePipelineNewResponse CreatePipelineNew(CreatePipelineNewRequest createPipelineNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPipelineNewRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPipelineNewRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePipelineNewResponse>(response);
        }

        public SyncInvoker<CreatePipelineNewResponse> CreatePipelineNewInvoker(CreatePipelineNewRequest createPipelineNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPipelineNewRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPipelineNewRequest);
            return new SyncInvoker<CreatePipelineNewResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePipelineNewResponse>);
        }
        
        /// <summary>
        /// 创建流水线模板
        ///
        /// 创建流水线模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePipelineTemplateResponse CreatePipelineTemplate(CreatePipelineTemplateRequest createPipelineTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPipelineTemplateRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{tenant_id}/api/pipeline-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPipelineTemplateRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreatePipelineTemplateResponse>(response);
        }

        public SyncInvoker<CreatePipelineTemplateResponse> CreatePipelineTemplateInvoker(CreatePipelineTemplateRequest createPipelineTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPipelineTemplateRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{tenant_id}/api/pipeline-templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPipelineTemplateRequest);
            return new SyncInvoker<CreatePipelineTemplateResponse>(this, "POST", request, JsonUtils.DeSerialize<CreatePipelineTemplateResponse>);
        }
        
        /// <summary>
        /// 创建插件草稿版本
        ///
        /// 创建插件草稿版本
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePluginDraftResponse CreatePluginDraft(CreatePluginDraftRequest createPluginDraftRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPluginDraftRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/create-draft", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPluginDraftRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreatePluginDraftResponse>(response);
        }

        public SyncInvoker<CreatePluginDraftResponse> CreatePluginDraftInvoker(CreatePluginDraftRequest createPluginDraftRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPluginDraftRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/create-draft", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPluginDraftRequest);
            return new SyncInvoker<CreatePluginDraftResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreatePluginDraftResponse>);
        }
        
        /// <summary>
        /// 创建插件版本
        ///
        /// 创建插件版本
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePluginVersionResponse CreatePluginVersion(CreatePluginVersionRequest createPluginVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPluginVersionRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPluginVersionRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreatePluginVersionResponse>(response);
        }

        public SyncInvoker<CreatePluginVersionResponse> CreatePluginVersionInvoker(CreatePluginVersionRequest createPluginVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPluginVersionRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPluginVersionRequest);
            return new SyncInvoker<CreatePluginVersionResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreatePluginVersionResponse>);
        }
        
        /// <summary>
        /// 创建发布商
        ///
        /// 创建发布商
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreatePublisherResponse CreatePublisher(CreatePublisherRequest createPublisherRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPublisherRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/publisher/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPublisherRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<CreatePublisherResponse>(response);
        }

        public SyncInvoker<CreatePublisherResponse> CreatePublisherInvoker(CreatePublisherRequest createPublisherRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createPublisherRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/publisher/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPublisherRequest);
            return new SyncInvoker<CreatePublisherResponse>(this, "POST", request, JsonUtils.DeSerializeNull<CreatePublisherResponse>);
        }
        
        /// <summary>
        /// 创建规则
        ///
        /// 创建规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateRuleResponse CreateRule(CreateRuleRequest createRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRuleRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/rules/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createRuleRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateRuleResponse>(response);
        }

        public SyncInvoker<CreateRuleResponse> CreateRuleInvoker(CreateRuleRequest createRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createRuleRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/rules/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createRuleRequest);
            return new SyncInvoker<CreateRuleResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateRuleResponse>);
        }
        
        /// <summary>
        /// 创建策略
        ///
        /// 创建策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public CreateStrategyResponse CreateStrategy(CreateStrategyRequest createStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createStrategyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/tenant/rule-sets/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createStrategyRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<CreateStrategyResponse>(response);
        }

        public SyncInvoker<CreateStrategyResponse> CreateStrategyInvoker(CreateStrategyRequest createStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(createStrategyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/tenant/rule-sets/create", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createStrategyRequest);
            return new SyncInvoker<CreateStrategyResponse>(this, "POST", request, JsonUtils.DeSerialize<CreateStrategyResponse>);
        }
        
        /// <summary>
        /// 删除基础插件
        ///
        /// 删除基础插件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteBasicPluginResponse DeleteBasicPlugin(DeleteBasicPluginRequest deleteBasicPluginRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteBasicPluginRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/extension/info/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBasicPluginRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeleteBasicPluginResponse>(response);
        }

        public SyncInvoker<DeleteBasicPluginResponse> DeleteBasicPluginInvoker(DeleteBasicPluginRequest deleteBasicPluginRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteBasicPluginRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/extension/info/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBasicPluginRequest);
            return new SyncInvoker<DeleteBasicPluginResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeleteBasicPluginResponse>);
        }
        
        /// <summary>
        /// 删除流水线
        ///
        /// 删除流水线
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePipelineResponse DeletePipeline(DeletePipelineRequest deletePipelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePipelineRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deletePipelineRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePipelineRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeletePipelineResponse>(response);
        }

        public SyncInvoker<DeletePipelineResponse> DeletePipelineInvoker(DeletePipelineRequest deletePipelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePipelineRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(deletePipelineRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePipelineRequest);
            return new SyncInvoker<DeletePipelineResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeletePipelineResponse>);
        }
        
        /// <summary>
        /// 删除流水线分组
        ///
        /// 删除流水线分组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePipelineGroupResponse DeletePipelineGroup(DeletePipelineGroupRequest deletePipelineGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePipelineGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipeline-group/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePipelineGroupRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeletePipelineGroupResponse>(response);
        }

        public SyncInvoker<DeletePipelineGroupResponse> DeletePipelineGroupInvoker(DeletePipelineGroupRequest deletePipelineGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePipelineGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipeline-group/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePipelineGroupRequest);
            return new SyncInvoker<DeletePipelineGroupResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeletePipelineGroupResponse>);
        }
        
        /// <summary>
        /// 删除流水线模板
        ///
        /// 删除流水线模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePipelineTemplateResponse DeletePipelineTemplate(DeletePipelineTemplateRequest deletePipelineTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePipelineTemplateRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(deletePipelineTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{tenant_id}/api/pipeline-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePipelineTemplateRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeletePipelineTemplateResponse>(response);
        }

        public SyncInvoker<DeletePipelineTemplateResponse> DeletePipelineTemplateInvoker(DeletePipelineTemplateRequest deletePipelineTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePipelineTemplateRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(deletePipelineTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{tenant_id}/api/pipeline-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePipelineTemplateRequest);
            return new SyncInvoker<DeletePipelineTemplateResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeletePipelineTemplateResponse>);
        }
        
        /// <summary>
        /// 删除插件草稿
        ///
        /// 删除插件草稿
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePluginDraftResponse DeletePluginDraft(DeletePluginDraftRequest deletePluginDraftRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePluginDraftRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/delete-draft", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePluginDraftRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePluginDraftResponse>(response);
        }

        public SyncInvoker<DeletePluginDraftResponse> DeletePluginDraftInvoker(DeletePluginDraftRequest deletePluginDraftRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePluginDraftRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/delete-draft", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePluginDraftRequest);
            return new SyncInvoker<DeletePluginDraftResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePluginDraftResponse>);
        }
        
        /// <summary>
        /// 删除发布商
        ///
        /// 删除发布商
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeletePublisherResponse DeletePublisher(DeletePublisherRequest deletePublisherRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePublisherRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/publisher/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePublisherRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerializeNull<DeletePublisherResponse>(response);
        }

        public SyncInvoker<DeletePublisherResponse> DeletePublisherInvoker(DeletePublisherRequest deletePublisherRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deletePublisherRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/publisher/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePublisherRequest);
            return new SyncInvoker<DeletePublisherResponse>(this, "DELETE", request, JsonUtils.DeSerializeNull<DeletePublisherResponse>);
        }
        
        /// <summary>
        /// 删除规则
        ///
        /// 删除规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteRuleResponse DeleteRule(DeleteRuleRequest deleteRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRuleRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(deleteRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/rules/{rule_id}/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRuleRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteRuleResponse>(response);
        }

        public SyncInvoker<DeleteRuleResponse> DeleteRuleInvoker(DeleteRuleRequest deleteRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteRuleRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(deleteRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/rules/{rule_id}/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRuleRequest);
            return new SyncInvoker<DeleteRuleResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteRuleResponse>);
        }
        
        /// <summary>
        /// 删除策略
        ///
        /// 删除策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteStrategyResponse DeleteStrategy(DeleteStrategyRequest deleteStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteStrategyRequest.RuleSetId, out var valueOfRuleSetId)) urlParam.Add("rule_set_id", valueOfRuleSetId);
            if (StringUtils.TryConvertToNonEmptyString(deleteStrategyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/tenant/rule-sets/{rule_set_id}/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteStrategyRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteStrategyResponse>(response);
        }

        public SyncInvoker<DeleteStrategyResponse> DeleteStrategyInvoker(DeleteStrategyRequest deleteStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteStrategyRequest.RuleSetId, out var valueOfRuleSetId)) urlParam.Add("rule_set_id", valueOfRuleSetId);
            if (StringUtils.TryConvertToNonEmptyString(deleteStrategyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/tenant/rule-sets/{rule_set_id}/delete", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteStrategyRequest);
            return new SyncInvoker<DeleteStrategyResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteStrategyResponse>);
        }
        
        /// <summary>
        /// 查询可用发布商
        ///
        /// 查询可用发布商
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListAvailablePublisherResponse ListAvailablePublisher(ListAvailablePublisherRequest listAvailablePublisherRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAvailablePublisherRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/publisher/optional-publisher", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailablePublisherRequest);
            var response = DoHttpRequestSync("GET", request);
            var listAvailablePublisherResponse = JsonUtils.DeSerializeNull<ListAvailablePublisherResponse>(response);
            listAvailablePublisherResponse.Body = JsonUtils.DeSerializeList<PublisherVO>(response);
            return listAvailablePublisherResponse;
        }

        public SyncInvoker<ListAvailablePublisherResponse> ListAvailablePublisherInvoker(ListAvailablePublisherRequest listAvailablePublisherRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listAvailablePublisherRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/publisher/optional-publisher", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailablePublisherRequest);
            return new SyncInvoker<ListAvailablePublisherResponse>(this, "GET", request, response =>
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
        public ListBasePluginsResponse ListBasePlugins(ListBasePluginsRequest listBasePluginsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBasePluginsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/relation/plugin/single", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBasePluginsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListBasePluginsResponse>(response);
        }

        public SyncInvoker<ListBasePluginsResponse> ListBasePluginsInvoker(ListBasePluginsRequest listBasePluginsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBasePluginsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/relation/plugin/single", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBasePluginsRequest);
            return new SyncInvoker<ListBasePluginsResponse>(this, "GET", request, JsonUtils.DeSerialize<ListBasePluginsResponse>);
        }
        
        /// <summary>
        /// 分页查询可选插件列表
        ///
        /// 分页查询可选插件列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListBasePluginsNewPostResponse ListBasePluginsNewPost(ListBasePluginsNewPostRequest listBasePluginsNewPostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBasePluginsNewPostRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/relation/plugins", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listBasePluginsNewPostRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListBasePluginsNewPostResponse>(response);
        }

        public SyncInvoker<ListBasePluginsNewPostResponse> ListBasePluginsNewPostInvoker(ListBasePluginsNewPostRequest listBasePluginsNewPostRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listBasePluginsNewPostRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/relation/plugins", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listBasePluginsNewPostRequest);
            return new SyncInvoker<ListBasePluginsNewPostResponse>(this, "POST", request, JsonUtils.DeSerialize<ListBasePluginsNewPostResponse>);
        }
        
        /// <summary>
        /// 查询插件所有版本信息
        ///
        /// 查询插件所有版本信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPLuginVersionResponse ListPLuginVersion(ListPLuginVersionRequest listPLuginVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPLuginVersionRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPLuginVersionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPLuginVersionResponse>(response);
        }

        public SyncInvoker<ListPLuginVersionResponse> ListPLuginVersionInvoker(ListPLuginVersionRequest listPLuginVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPLuginVersionRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPLuginVersionRequest);
            return new SyncInvoker<ListPLuginVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPLuginVersionResponse>);
        }
        
        /// <summary>
        /// 获取流水线执行记录
        ///
        /// 获取流水线执行记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPipelineRunsResponse ListPipelineRuns(ListPipelineRunsRequest listPipelineRunsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPipelineRunsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listPipelineRunsRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/pipeline-runs/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listPipelineRunsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListPipelineRunsResponse>(response);
        }

        public SyncInvoker<ListPipelineRunsResponse> ListPipelineRunsInvoker(ListPipelineRunsRequest listPipelineRunsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPipelineRunsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(listPipelineRunsRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/pipeline-runs/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listPipelineRunsRequest);
            return new SyncInvoker<ListPipelineRunsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListPipelineRunsResponse>);
        }
        
        /// <summary>
        /// 获取流水线列表接口
        ///
        /// 获取流水线列表接口
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPipelineSimpleInfoResponse ListPipelineSimpleInfo(ListPipelineSimpleInfoRequest listPipelineSimpleInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/pipelines/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPipelineSimpleInfoRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListPipelineSimpleInfoResponse>(response);
        }

        public SyncInvoker<ListPipelineSimpleInfoResponse> ListPipelineSimpleInfoInvoker(ListPipelineSimpleInfoRequest listPipelineSimpleInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/pipelines/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPipelineSimpleInfoRequest);
            return new SyncInvoker<ListPipelineSimpleInfoResponse>(this, "POST", request, JsonUtils.DeSerialize<ListPipelineSimpleInfoResponse>);
        }
        
        /// <summary>
        /// 查询模板列表
        ///
        /// 查询流水线模板列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPipelineTemplatesResponse ListPipelineTemplates(ListPipelineTemplatesRequest listPipelineTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPipelineTemplatesRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{tenant_id}/api/pipeline-templates/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listPipelineTemplatesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListPipelineTemplatesResponse>(response);
        }

        public SyncInvoker<ListPipelineTemplatesResponse> ListPipelineTemplatesInvoker(ListPipelineTemplatesRequest listPipelineTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPipelineTemplatesRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{tenant_id}/api/pipeline-templates/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listPipelineTemplatesRequest);
            return new SyncInvoker<ListPipelineTemplatesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListPipelineTemplatesResponse>);
        }
        
        /// <summary>
        /// 获取流水线列表/获取项目下流水线执行状况
        ///
        /// 获取流水线列表/获取项目下流水线执行状况
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPipelinesResponse ListPipelines(ListPipelinesRequest listPipelinesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPipelinesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listPipelinesRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListPipelinesResponse>(response);
        }

        public SyncInvoker<ListPipelinesResponse> ListPipelinesInvoker(ListPipelinesRequest listPipelinesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPipelinesRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listPipelinesRequest);
            return new SyncInvoker<ListPipelinesResponse>(this, "POST", request, JsonUtils.DeSerialize<ListPipelinesResponse>);
        }
        
        /// <summary>
        /// 获取项目下流水线执行状况
        ///
        /// 获取项目下流水线执行状况
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPipleineBuildResultResponse ListPipleineBuildResult(ListPipleineBuildResultRequest listPipleineBuildResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/pipelines/build-result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPipleineBuildResultRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPipleineBuildResultResponse>(response);
        }

        public SyncInvoker<ListPipleineBuildResultResponse> ListPipleineBuildResultInvoker(ListPipleineBuildResultRequest listPipleineBuildResultRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/pipelines/build-result", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPipleineBuildResultRequest);
            return new SyncInvoker<ListPipleineBuildResultResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPipleineBuildResultResponse>);
        }
        
        /// <summary>
        /// 查询插件版本号
        ///
        /// 查询插件版本号
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPluginVersionNumberResponse ListPluginVersionNumber(ListPluginVersionNumberRequest listPluginVersionNumberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPluginVersionNumberRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/all-version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPluginVersionNumberRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPluginVersionNumberResponse>(response);
        }

        public SyncInvoker<ListPluginVersionNumberResponse> ListPluginVersionNumberInvoker(ListPluginVersionNumberRequest listPluginVersionNumberRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPluginVersionNumberRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/all-version", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPluginVersionNumberRequest);
            return new SyncInvoker<ListPluginVersionNumberResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPluginVersionNumberResponse>);
        }
        
        /// <summary>
        /// 查询插件列表
        ///
        /// 查询插件列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPluginsResponse ListPlugins(ListPluginsRequest listPluginsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPluginsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/query-all", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listPluginsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListPluginsResponse>(response);
        }

        public SyncInvoker<ListPluginsResponse> ListPluginsInvoker(ListPluginsRequest listPluginsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPluginsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/query-all", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listPluginsRequest);
            return new SyncInvoker<ListPluginsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListPluginsResponse>);
        }
        
        /// <summary>
        /// 获取规则模板实例列表
        ///
        /// 获取策略列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListProjectStrategyResponse ListProjectStrategy(ListProjectStrategyRequest listProjectStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectStrategyRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rule-sets/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectStrategyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListProjectStrategyResponse>(response);
        }

        public SyncInvoker<ListProjectStrategyResponse> ListProjectStrategyInvoker(ListProjectStrategyRequest listProjectStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listProjectStrategyRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rule-sets/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectStrategyRequest);
            return new SyncInvoker<ListProjectStrategyResponse>(this, "GET", request, JsonUtils.DeSerialize<ListProjectStrategyResponse>);
        }
        
        /// <summary>
        /// 查询发布商列表
        ///
        /// 查询发布商列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListPublisherResponse ListPublisher(ListPublisherRequest listPublisherRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPublisherRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/publisher/query-all", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublisherRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListPublisherResponse>(response);
        }

        public SyncInvoker<ListPublisherResponse> ListPublisherInvoker(ListPublisherRequest listPublisherRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listPublisherRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/publisher/query-all", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPublisherRequest);
            return new SyncInvoker<ListPublisherResponse>(this, "GET", request, JsonUtils.DeSerialize<ListPublisherResponse>);
        }
        
        /// <summary>
        /// 分页获取规则列表
        ///
        /// 分页获取规则列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListRuleResponse ListRule(ListRuleRequest listRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRuleRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/rules/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRuleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListRuleResponse>(response);
        }

        public SyncInvoker<ListRuleResponse> ListRuleInvoker(ListRuleRequest listRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listRuleRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/rules/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRuleRequest);
            return new SyncInvoker<ListRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ListRuleResponse>);
        }
        
        /// <summary>
        /// 查询可选插件列表
        ///
        /// 查询可选插件列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListStagePluginsResponse ListStagePlugins(ListStagePluginsRequest listStagePluginsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listStagePluginsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/relation/stage-plugins", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listStagePluginsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListStagePluginsResponse>(response);
        }

        public SyncInvoker<ListStagePluginsResponse> ListStagePluginsInvoker(ListStagePluginsRequest listStagePluginsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listStagePluginsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/relation/stage-plugins", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listStagePluginsRequest);
            return new SyncInvoker<ListStagePluginsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListStagePluginsResponse>);
        }
        
        /// <summary>
        /// 获取策略列表
        ///
        /// 获取策略列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListStrategyResponse ListStrategy(ListStrategyRequest listStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listStrategyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/tenant/rule-sets/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStrategyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListStrategyResponse>(response);
        }

        public SyncInvoker<ListStrategyResponse> ListStrategyInvoker(ListStrategyRequest listStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listStrategyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/tenant/rule-sets/query", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStrategyRequest);
            return new SyncInvoker<ListStrategyResponse>(this, "GET", request, JsonUtils.DeSerialize<ListStrategyResponse>);
        }
        
        /// <summary>
        /// 查询模板列表
        ///
        /// 查询模板列表，支持分页查询,支持模板名字模糊查询
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListTemplatesResponse ListTemplates(ListTemplatesRequest listTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplatesRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ListTemplatesResponse>(response);
        }

        public SyncInvoker<ListTemplatesResponse> ListTemplatesInvoker(ListTemplatesRequest listTemplatesRequest)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath("/v3/templates", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplatesRequest);
            return new SyncInvoker<ListTemplatesResponse>(this, "GET", request, JsonUtils.DeSerialize<ListTemplatesResponse>);
        }
        
        /// <summary>
        /// 发布插件
        ///
        /// 发布插件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public PublishPluginResponse PublishPlugin(PublishPluginRequest publishPluginRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(publishPluginRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/publish-plugin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", publishPluginRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<PublishPluginResponse>(response);
        }

        public SyncInvoker<PublishPluginResponse> PublishPluginInvoker(PublishPluginRequest publishPluginRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(publishPluginRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/publish-plugin", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", publishPluginRequest);
            return new SyncInvoker<PublishPluginResponse>(this, "POST", request, JsonUtils.DeSerializeNull<PublishPluginResponse>);
        }
        
        /// <summary>
        /// 插件绑定发布商
        ///
        /// 插件绑定发布商
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public PublishPluginBindResponse PublishPluginBind(PublishPluginBindRequest publishPluginBindRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(publishPluginBindRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/publish-plugin-bind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", publishPluginBindRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<PublishPluginBindResponse>(response);
        }

        public SyncInvoker<PublishPluginBindResponse> PublishPluginBindInvoker(PublishPluginBindRequest publishPluginBindRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(publishPluginBindRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/publish-plugin-bind", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", publishPluginBindRequest);
            return new SyncInvoker<PublishPluginBindResponse>(this, "POST", request, JsonUtils.DeSerializeNull<PublishPluginBindResponse>);
        }
        
        /// <summary>
        /// 发布插件草稿
        ///
        /// 发布插件草稿
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public PublishPluginDraftResponse PublishPluginDraft(PublishPluginDraftRequest publishPluginDraftRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(publishPluginDraftRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/publish-draft", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", publishPluginDraftRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<PublishPluginDraftResponse>(response);
        }

        public SyncInvoker<PublishPluginDraftResponse> PublishPluginDraftInvoker(PublishPluginDraftRequest publishPluginDraftRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(publishPluginDraftRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/publish-draft", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", publishPluginDraftRequest);
            return new SyncInvoker<PublishPluginDraftResponse>(this, "POST", request, JsonUtils.DeSerializeNull<PublishPluginDraftResponse>);
        }
        
        /// <summary>
        /// 驳回人工审核
        ///
        /// 驳回人工审核
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RejectManualReviewResponse RejectManualReview(RejectManualReviewRequest rejectManualReviewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rejectManualReviewRequest.JobRunId, out var valueOfJobRunId)) urlParam.Add("job_run_id", valueOfJobRunId);
            if (StringUtils.TryConvertToNonEmptyString(rejectManualReviewRequest.StepRunId, out var valueOfStepRunId)) urlParam.Add("step_run_id", valueOfStepRunId);
            if (StringUtils.TryConvertToNonEmptyString(rejectManualReviewRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(rejectManualReviewRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            if (StringUtils.TryConvertToNonEmptyString(rejectManualReviewRequest.PipelineRunId, out var valueOfPipelineRunId)) urlParam.Add("pipeline_run_id", valueOfPipelineRunId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/pipeline-runs/{pipeline_run_id}/jobs/{job_run_id}/steps/{step_run_id}/refuse", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rejectManualReviewRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RejectManualReviewResponse>(response);
        }

        public SyncInvoker<RejectManualReviewResponse> RejectManualReviewInvoker(RejectManualReviewRequest rejectManualReviewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(rejectManualReviewRequest.JobRunId, out var valueOfJobRunId)) urlParam.Add("job_run_id", valueOfJobRunId);
            if (StringUtils.TryConvertToNonEmptyString(rejectManualReviewRequest.StepRunId, out var valueOfStepRunId)) urlParam.Add("step_run_id", valueOfStepRunId);
            if (StringUtils.TryConvertToNonEmptyString(rejectManualReviewRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(rejectManualReviewRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            if (StringUtils.TryConvertToNonEmptyString(rejectManualReviewRequest.PipelineRunId, out var valueOfPipelineRunId)) urlParam.Add("pipeline_run_id", valueOfPipelineRunId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/pipeline-runs/{pipeline_run_id}/jobs/{job_run_id}/steps/{step_run_id}/refuse", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", rejectManualReviewRequest);
            return new SyncInvoker<RejectManualReviewResponse>(this, "POST", request, JsonUtils.DeSerialize<RejectManualReviewResponse>);
        }
        
        /// <summary>
        /// 删除流水线
        ///
        /// 根据id删除流水线
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RemovePipelineResponse RemovePipeline(RemovePipelineRequest removePipelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removePipelineRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v3/pipelines/{pipeline_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removePipelineRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<RemovePipelineResponse>(response);
        }

        public SyncInvoker<RemovePipelineResponse> RemovePipelineInvoker(RemovePipelineRequest removePipelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(removePipelineRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v3/pipelines/{pipeline_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", removePipelineRequest);
            return new SyncInvoker<RemovePipelineResponse>(this, "DELETE", request, JsonUtils.DeSerialize<RemovePipelineResponse>);
        }
        
        /// <summary>
        /// 重试运行流水线
        ///
        /// 重试运行流水线
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RetryPipelineRunResponse RetryPipelineRun(RetryPipelineRunRequest retryPipelineRunRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(retryPipelineRunRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(retryPipelineRunRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            if (StringUtils.TryConvertToNonEmptyString(retryPipelineRunRequest.PipelineRunId, out var valueOfPipelineRunId)) urlParam.Add("pipeline_run_id", valueOfPipelineRunId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/pipeline-runs/{pipeline_run_id}/retry", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryPipelineRunRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<RetryPipelineRunResponse>(response);
        }

        public SyncInvoker<RetryPipelineRunResponse> RetryPipelineRunInvoker(RetryPipelineRunRequest retryPipelineRunRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(retryPipelineRunRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(retryPipelineRunRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            if (StringUtils.TryConvertToNonEmptyString(retryPipelineRunRequest.PipelineRunId, out var valueOfPipelineRunId)) urlParam.Add("pipeline_run_id", valueOfPipelineRunId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/pipeline-runs/{pipeline_run_id}/retry", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", retryPipelineRunRequest);
            return new SyncInvoker<RetryPipelineRunResponse>(this, "PUT", request, JsonUtils.DeSerialize<RetryPipelineRunResponse>);
        }
        
        /// <summary>
        /// 启动流水线
        ///
        /// 启动流水线
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunPipelineResponse RunPipeline(RunPipelineRequest runPipelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runPipelineRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(runPipelineRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/run", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runPipelineRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RunPipelineResponse>(response);
        }

        public SyncInvoker<RunPipelineResponse> RunPipelineInvoker(RunPipelineRequest runPipelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runPipelineRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(runPipelineRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/run", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runPipelineRequest);
            return new SyncInvoker<RunPipelineResponse>(this, "POST", request, JsonUtils.DeSerialize<RunPipelineResponse>);
        }
        
        /// <summary>
        /// 查询基础插件详情
        ///
        /// 查询基础插件详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowBasicPluginResponse ShowBasicPlugin(ShowBasicPluginRequest showBasicPluginRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBasicPluginRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/extension/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBasicPluginRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowBasicPluginResponse>(response);
        }

        public SyncInvoker<ShowBasicPluginResponse> ShowBasicPluginInvoker(ShowBasicPluginRequest showBasicPluginRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showBasicPluginRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/extension/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBasicPluginRequest);
            return new SyncInvoker<ShowBasicPluginResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowBasicPluginResponse>);
        }
        
        /// <summary>
        /// 检查流水线创建状态
        ///
        /// 检查流水线创建状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowInstanceStatusResponse ShowInstanceStatus(ShowInstanceStatusRequest showInstanceStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceStatusRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v3/templates/{task_id}/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowInstanceStatusResponse>(response);
        }

        public SyncInvoker<ShowInstanceStatusResponse> ShowInstanceStatusInvoker(ShowInstanceStatusRequest showInstanceStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showInstanceStatusRequest.TaskId, out var valueOfTaskId)) urlParam.Add("task_id", valueOfTaskId);
            var urlPath = HttpUtils.AddUrlPath("/v3/templates/{task_id}/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showInstanceStatusRequest);
            return new SyncInvoker<ShowInstanceStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowInstanceStatusResponse>);
        }
        
        /// <summary>
        /// 查询流水线上的构建产物
        ///
        /// 查询流水线上的构建产物
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPipelineArtifactsResponse ShowPipelineArtifacts(ShowPipelineArtifactsRequest showPipelineArtifactsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPipelineArtifactsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showPipelineArtifactsRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            if (StringUtils.TryConvertToNonEmptyString(showPipelineArtifactsRequest.PipelineRunId, out var valueOfPipelineRunId)) urlParam.Add("pipeline_run_id", valueOfPipelineRunId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/pipeline-runs/{pipeline_run_id}/artifacts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPipelineArtifactsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPipelineArtifactsResponse>(response);
        }

        public SyncInvoker<ShowPipelineArtifactsResponse> ShowPipelineArtifactsInvoker(ShowPipelineArtifactsRequest showPipelineArtifactsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPipelineArtifactsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showPipelineArtifactsRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            if (StringUtils.TryConvertToNonEmptyString(showPipelineArtifactsRequest.PipelineRunId, out var valueOfPipelineRunId)) urlParam.Add("pipeline_run_id", valueOfPipelineRunId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/pipeline-runs/{pipeline_run_id}/artifacts", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPipelineArtifactsRequest);
            return new SyncInvoker<ShowPipelineArtifactsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPipelineArtifactsResponse>);
        }
        
        /// <summary>
        /// 查询流水线详情
        ///
        /// 查询流水线详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPipelineDetailResponse ShowPipelineDetail(ShowPipelineDetailRequest showPipelineDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPipelineDetailRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showPipelineDetailRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPipelineDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPipelineDetailResponse>(response);
        }

        public SyncInvoker<ShowPipelineDetailResponse> ShowPipelineDetailInvoker(ShowPipelineDetailRequest showPipelineDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPipelineDetailRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showPipelineDetailRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPipelineDetailRequest);
            return new SyncInvoker<ShowPipelineDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPipelineDetailResponse>);
        }
        
        /// <summary>
        /// 查询流水线分组树
        ///
        /// 查询流水线分组树
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPipelineGroupTreeResponse ShowPipelineGroupTree(ShowPipelineGroupTreeRequest showPipelineGroupTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPipelineGroupTreeRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipeline-group/tree", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPipelineGroupTreeRequest);
            var response = DoHttpRequestSync("GET", request);
            var showPipelineGroupTreeResponse = JsonUtils.DeSerializeNull<ShowPipelineGroupTreeResponse>(response);
            showPipelineGroupTreeResponse.Body = JsonUtils.DeSerializeList<PipelineGroupVo>(response);
            return showPipelineGroupTreeResponse;
        }

        public SyncInvoker<ShowPipelineGroupTreeResponse> ShowPipelineGroupTreeInvoker(ShowPipelineGroupTreeRequest showPipelineGroupTreeRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPipelineGroupTreeRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipeline-group/tree", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPipelineGroupTreeRequest);
            return new SyncInvoker<ShowPipelineGroupTreeResponse>(this, "GET", request, response =>
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
        public ShowPipelineLogResponse ShowPipelineLog(ShowPipelineLogRequest showPipelineLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPipelineLogRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showPipelineLogRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            if (StringUtils.TryConvertToNonEmptyString(showPipelineLogRequest.PipelineRunId, out var valueOfPipelineRunId)) urlParam.Add("pipeline_run_id", valueOfPipelineRunId);
            if (StringUtils.TryConvertToNonEmptyString(showPipelineLogRequest.JobRunId, out var valueOfJobRunId)) urlParam.Add("job_run_id", valueOfJobRunId);
            if (StringUtils.TryConvertToNonEmptyString(showPipelineLogRequest.StepRunId, out var valueOfStepRunId)) urlParam.Add("step_run_id", valueOfStepRunId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/pipeline-runs/{pipeline_run_id}/jobs/{job_run_id}/steps/{step_run_id}/logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showPipelineLogRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowPipelineLogResponse>(response);
        }

        public SyncInvoker<ShowPipelineLogResponse> ShowPipelineLogInvoker(ShowPipelineLogRequest showPipelineLogRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPipelineLogRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showPipelineLogRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            if (StringUtils.TryConvertToNonEmptyString(showPipelineLogRequest.PipelineRunId, out var valueOfPipelineRunId)) urlParam.Add("pipeline_run_id", valueOfPipelineRunId);
            if (StringUtils.TryConvertToNonEmptyString(showPipelineLogRequest.JobRunId, out var valueOfJobRunId)) urlParam.Add("job_run_id", valueOfJobRunId);
            if (StringUtils.TryConvertToNonEmptyString(showPipelineLogRequest.StepRunId, out var valueOfStepRunId)) urlParam.Add("step_run_id", valueOfStepRunId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/pipeline-runs/{pipeline_run_id}/jobs/{job_run_id}/steps/{step_run_id}/logs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showPipelineLogRequest);
            return new SyncInvoker<ShowPipelineLogResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowPipelineLogResponse>);
        }
        
        /// <summary>
        /// 获取流水线状态/获取流水线执行详情
        ///
        /// 获取流水线状态/获取流水线执行详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPipelineRunDetailResponse ShowPipelineRunDetail(ShowPipelineRunDetailRequest showPipelineRunDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPipelineRunDetailRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showPipelineRunDetailRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/pipeline-runs/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPipelineRunDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPipelineRunDetailResponse>(response);
        }

        public SyncInvoker<ShowPipelineRunDetailResponse> ShowPipelineRunDetailInvoker(ShowPipelineRunDetailRequest showPipelineRunDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPipelineRunDetailRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showPipelineRunDetailRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/pipeline-runs/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPipelineRunDetailRequest);
            return new SyncInvoker<ShowPipelineRunDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPipelineRunDetailResponse>);
        }
        
        /// <summary>
        /// 查询模板详情
        ///
        /// 查询模板详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPipelineTemplateDetailResponse ShowPipelineTemplateDetail(ShowPipelineTemplateDetailRequest showPipelineTemplateDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPipelineTemplateDetailRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(showPipelineTemplateDetailRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{tenant_id}/api/pipeline-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPipelineTemplateDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPipelineTemplateDetailResponse>(response);
        }

        public SyncInvoker<ShowPipelineTemplateDetailResponse> ShowPipelineTemplateDetailInvoker(ShowPipelineTemplateDetailRequest showPipelineTemplateDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPipelineTemplateDetailRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(showPipelineTemplateDetailRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{tenant_id}/api/pipeline-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPipelineTemplateDetailRequest);
            return new SyncInvoker<ShowPipelineTemplateDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPipelineTemplateDetailResponse>);
        }
        
        /// <summary>
        /// 获取流水线状态
        ///
        /// 获取流水线状态,阶段及任务信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPipleineStatusResponse ShowPipleineStatus(ShowPipleineStatusRequest showPipleineStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPipleineStatusRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v3/pipelines/{pipeline_id}/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPipleineStatusRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPipleineStatusResponse>(response);
        }

        public SyncInvoker<ShowPipleineStatusResponse> ShowPipleineStatusInvoker(ShowPipleineStatusRequest showPipleineStatusRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPipleineStatusRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v3/pipelines/{pipeline_id}/status", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPipleineStatusRequest);
            return new SyncInvoker<ShowPipleineStatusResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPipleineStatusResponse>);
        }
        
        /// <summary>
        /// 查询插件输入配置
        ///
        /// 查询插件输入配置
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPluginInputsResponse ShowPluginInputs(ShowPluginInputsRequest showPluginInputsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPluginInputsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/plugin-input", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showPluginInputsRequest);
            var response = DoHttpRequestSync("POST", request);
            var showPluginInputsResponse = JsonUtils.DeSerializeNull<ShowPluginInputsResponse>(response);
            showPluginInputsResponse.Body = JsonUtils.DeSerializeList<PluginPartQueryVOListAgentPluginInputVO>(response);
            return showPluginInputsResponse;
        }

        public SyncInvoker<ShowPluginInputsResponse> ShowPluginInputsInvoker(ShowPluginInputsRequest showPluginInputsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPluginInputsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/plugin-input", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showPluginInputsRequest);
            return new SyncInvoker<ShowPluginInputsResponse>(this, "POST", request, response =>
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
        public ShowPluginMetricsResponse ShowPluginMetrics(ShowPluginMetricsRequest showPluginMetricsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPluginMetricsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/plugin-metrics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showPluginMetricsRequest);
            var response = DoHttpRequestSync("POST", request);
            var showPluginMetricsResponse = JsonUtils.DeSerializeNull<ShowPluginMetricsResponse>(response);
            showPluginMetricsResponse.Body = JsonUtils.DeSerializeList<PluginPartQueryVOListAgentPluginOutputVO>(response);
            return showPluginMetricsResponse;
        }

        public SyncInvoker<ShowPluginMetricsResponse> ShowPluginMetricsInvoker(ShowPluginMetricsRequest showPluginMetricsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPluginMetricsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/plugin-metrics", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showPluginMetricsRequest);
            return new SyncInvoker<ShowPluginMetricsResponse>(this, "POST", request, response =>
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
        public ShowPluginOutputsResponse ShowPluginOutputs(ShowPluginOutputsRequest showPluginOutputsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPluginOutputsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/plugin-output", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showPluginOutputsRequest);
            var response = DoHttpRequestSync("POST", request);
            var showPluginOutputsResponse = JsonUtils.DeSerializeNull<ShowPluginOutputsResponse>(response);
            showPluginOutputsResponse.Body = JsonUtils.DeSerializeList<PluginPartQueryVOListAgentPluginOutputVO>(response);
            return showPluginOutputsResponse;
        }

        public SyncInvoker<ShowPluginOutputsResponse> ShowPluginOutputsInvoker(ShowPluginOutputsRequest showPluginOutputsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPluginOutputsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/plugin-output", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showPluginOutputsRequest);
            return new SyncInvoker<ShowPluginOutputsResponse>(this, "POST", request, response =>
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
        public ShowPluginVersionResponse ShowPluginVersion(ShowPluginVersionRequest showPluginVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPluginVersionRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPluginVersionRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowPluginVersionResponse>(response);
        }

        public SyncInvoker<ShowPluginVersionResponse> ShowPluginVersionInvoker(ShowPluginVersionRequest showPluginVersionRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPluginVersionRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPluginVersionRequest);
            return new SyncInvoker<ShowPluginVersionResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowPluginVersionResponse>);
        }
        
        /// <summary>
        /// 
        ///
        /// 查询项目级策略详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowProjectStrategyResponse ShowProjectStrategy(ShowProjectStrategyRequest showProjectStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectStrategyRequest.RuleSetId, out var valueOfRuleSetId)) urlParam.Add("rule_set_id", valueOfRuleSetId);
            if (StringUtils.TryConvertToNonEmptyString(showProjectStrategyRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rule-sets/{rule_set_id}/gray/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectStrategyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowProjectStrategyResponse>(response);
        }

        public SyncInvoker<ShowProjectStrategyResponse> ShowProjectStrategyInvoker(ShowProjectStrategyRequest showProjectStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showProjectStrategyRequest.RuleSetId, out var valueOfRuleSetId)) urlParam.Add("rule_set_id", valueOfRuleSetId);
            if (StringUtils.TryConvertToNonEmptyString(showProjectStrategyRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/rule-sets/{rule_set_id}/gray/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProjectStrategyRequest);
            return new SyncInvoker<ShowProjectStrategyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowProjectStrategyResponse>);
        }
        
        /// <summary>
        /// 查询发布商详情
        ///
        /// 查询发布商详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowPublisherResponse ShowPublisher(ShowPublisherRequest showPublisherRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPublisherRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/publisher/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showPublisherRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ShowPublisherResponse>(response);
        }

        public SyncInvoker<ShowPublisherResponse> ShowPublisherInvoker(ShowPublisherRequest showPublisherRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showPublisherRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/publisher/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showPublisherRequest);
            return new SyncInvoker<ShowPublisherResponse>(this, "POST", request, JsonUtils.DeSerialize<ShowPublisherResponse>);
        }
        
        /// <summary>
        /// 获取单条规则详情
        ///
        /// 获取单条规则详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowRuleResponse ShowRule(ShowRuleRequest showRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRuleRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(showRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/rules/{rule_id}/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRuleRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowRuleResponse>(response);
        }

        public SyncInvoker<ShowRuleResponse> ShowRuleInvoker(ShowRuleRequest showRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showRuleRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(showRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/rules/{rule_id}/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRuleRequest);
            return new SyncInvoker<ShowRuleResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowRuleResponse>);
        }
        
        /// <summary>
        /// 获取流水线步骤执行输出
        ///
        /// 获取流水线步骤执行输出
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowStepOutputsResponse ShowStepOutputs(ShowStepOutputsRequest showStepOutputsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showStepOutputsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showStepOutputsRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            if (StringUtils.TryConvertToNonEmptyString(showStepOutputsRequest.PipelineRunId, out var valueOfPipelineRunId)) urlParam.Add("pipeline_run_id", valueOfPipelineRunId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/pipeline-runs/{pipeline_run_id}/steps/outputs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStepOutputsRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowStepOutputsResponse>(response);
        }

        public SyncInvoker<ShowStepOutputsResponse> ShowStepOutputsInvoker(ShowStepOutputsRequest showStepOutputsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showStepOutputsRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(showStepOutputsRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            if (StringUtils.TryConvertToNonEmptyString(showStepOutputsRequest.PipelineRunId, out var valueOfPipelineRunId)) urlParam.Add("pipeline_run_id", valueOfPipelineRunId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/pipeline-runs/{pipeline_run_id}/steps/outputs", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStepOutputsRequest);
            return new SyncInvoker<ShowStepOutputsResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStepOutputsResponse>);
        }
        
        /// <summary>
        /// 获取策略详情
        ///
        /// 获取策略详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowStrategyResponse ShowStrategy(ShowStrategyRequest showStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showStrategyRequest.RuleSetId, out var valueOfRuleSetId)) urlParam.Add("rule_set_id", valueOfRuleSetId);
            if (StringUtils.TryConvertToNonEmptyString(showStrategyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/tenant/rule-sets/{rule_set_id}/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStrategyRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowStrategyResponse>(response);
        }

        public SyncInvoker<ShowStrategyResponse> ShowStrategyInvoker(ShowStrategyRequest showStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showStrategyRequest.RuleSetId, out var valueOfRuleSetId)) urlParam.Add("rule_set_id", valueOfRuleSetId);
            if (StringUtils.TryConvertToNonEmptyString(showStrategyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/tenant/rule-sets/{rule_set_id}/detail", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showStrategyRequest);
            return new SyncInvoker<ShowStrategyResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowStrategyResponse>);
        }
        
        /// <summary>
        /// 查询模板详情
        ///
        /// 查询模板详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowTemplateDetailResponse ShowTemplateDetail(ShowTemplateDetailRequest showTemplateDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTemplateDetailRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v3/templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTemplateDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowTemplateDetailResponse>(response);
        }

        public SyncInvoker<ShowTemplateDetailResponse> ShowTemplateDetailInvoker(ShowTemplateDetailRequest showTemplateDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showTemplateDetailRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v3/templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTemplateDetailRequest);
            return new SyncInvoker<ShowTemplateDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowTemplateDetailResponse>);
        }
        
        /// <summary>
        /// 启动流水线
        ///
        /// 启动流水线
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StartNewPipelineResponse StartNewPipeline(StartNewPipelineRequest startNewPipelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startNewPipelineRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v3/pipelines/{pipeline_id}/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startNewPipelineRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StartNewPipelineResponse>(response);
        }

        public SyncInvoker<StartNewPipelineResponse> StartNewPipelineInvoker(StartNewPipelineRequest startNewPipelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(startNewPipelineRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v3/pipelines/{pipeline_id}/start", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", startNewPipelineRequest);
            return new SyncInvoker<StartNewPipelineResponse>(this, "POST", request, JsonUtils.DeSerialize<StartNewPipelineResponse>);
        }
        
        /// <summary>
        /// 停止流水线
        ///
        /// 停止流水线
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StopPipelineNewResponse StopPipelineNew(StopPipelineNewRequest stopPipelineNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopPipelineNewRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v3/pipelines/{pipeline_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopPipelineNewRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StopPipelineNewResponse>(response);
        }

        public SyncInvoker<StopPipelineNewResponse> StopPipelineNewInvoker(StopPipelineNewRequest stopPipelineNewRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopPipelineNewRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v3/pipelines/{pipeline_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopPipelineNewRequest);
            return new SyncInvoker<StopPipelineNewResponse>(this, "POST", request, JsonUtils.DeSerialize<StopPipelineNewResponse>);
        }
        
        /// <summary>
        /// 停止流水线
        ///
        /// 停止流水线
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public StopPipelineRunResponse StopPipelineRun(StopPipelineRunRequest stopPipelineRunRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopPipelineRunRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(stopPipelineRunRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            if (StringUtils.TryConvertToNonEmptyString(stopPipelineRunRequest.PipelineRunId, out var valueOfPipelineRunId)) urlParam.Add("pipeline_run_id", valueOfPipelineRunId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/pipeline-runs/{pipeline_run_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopPipelineRunRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<StopPipelineRunResponse>(response);
        }

        public SyncInvoker<StopPipelineRunResponse> StopPipelineRunInvoker(StopPipelineRunRequest stopPipelineRunRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(stopPipelineRunRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(stopPipelineRunRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            if (StringUtils.TryConvertToNonEmptyString(stopPipelineRunRequest.PipelineRunId, out var valueOfPipelineRunId)) urlParam.Add("pipeline_run_id", valueOfPipelineRunId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}/pipeline-runs/{pipeline_run_id}/stop", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", stopPipelineRunRequest);
            return new SyncInvoker<StopPipelineRunResponse>(this, "POST", request, JsonUtils.DeSerialize<StopPipelineRunResponse>);
        }
        
        /// <summary>
        /// 开关策略
        ///
        /// 修改策略状态
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public SwitchStrategyResponse SwitchStrategy(SwitchStrategyRequest switchStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchStrategyRequest.RuleSetId, out var valueOfRuleSetId)) urlParam.Add("rule_set_id", valueOfRuleSetId);
            if (StringUtils.TryConvertToNonEmptyString(switchStrategyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/tenant/rule-sets/{rule_set_id}/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchStrategyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<SwitchStrategyResponse>(response);
        }

        public SyncInvoker<SwitchStrategyResponse> SwitchStrategyInvoker(SwitchStrategyRequest switchStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(switchStrategyRequest.RuleSetId, out var valueOfRuleSetId)) urlParam.Add("rule_set_id", valueOfRuleSetId);
            if (StringUtils.TryConvertToNonEmptyString(switchStrategyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/tenant/rule-sets/{rule_set_id}/switch", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", switchStrategyRequest);
            return new SyncInvoker<SwitchStrategyResponse>(this, "PUT", request, JsonUtils.DeSerialize<SwitchStrategyResponse>);
        }
        
        /// <summary>
        /// 更新基础插件
        ///
        /// 更新基础插件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateBasicPluginResponse UpdateBasicPlugin(UpdateBasicPluginRequest updateBasicPluginRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateBasicPluginRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/extension/info/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateBasicPluginRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UpdateBasicPluginResponse>(response);
        }

        public SyncInvoker<UpdateBasicPluginResponse> UpdateBasicPluginInvoker(UpdateBasicPluginRequest updateBasicPluginRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateBasicPluginRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/extension/info/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateBasicPluginRequest);
            return new SyncInvoker<UpdateBasicPluginResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdateBasicPluginResponse>);
        }
        
        /// <summary>
        /// 更新流水线分组
        ///
        /// 更新流水线分组
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePipelineGroupResponse UpdatePipelineGroup(UpdatePipelineGroupRequest updatePipelineGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePipelineGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipeline-group/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePipelineGroupRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<UpdatePipelineGroupResponse>(response);
        }

        public SyncInvoker<UpdatePipelineGroupResponse> UpdatePipelineGroupInvoker(UpdatePipelineGroupRequest updatePipelineGroupRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePipelineGroupRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipeline-group/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePipelineGroupRequest);
            return new SyncInvoker<UpdatePipelineGroupResponse>(this, "POST", request, JsonUtils.DeSerialize<UpdatePipelineGroupResponse>);
        }
        
        /// <summary>
        /// 修改流水线信息
        ///
        /// 修改流水线信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePipelineInfoResponse UpdatePipelineInfo(UpdatePipelineInfoRequest updatePipelineInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePipelineInfoRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(updatePipelineInfoRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePipelineInfoRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePipelineInfoResponse>(response);
        }

        public SyncInvoker<UpdatePipelineInfoResponse> UpdatePipelineInfoInvoker(UpdatePipelineInfoRequest updatePipelineInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePipelineInfoRequest.ProjectId, out var valueOfProjectId)) urlParam.Add("project_id", valueOfProjectId);
            if (StringUtils.TryConvertToNonEmptyString(updatePipelineInfoRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{project_id}/api/pipelines/{pipeline_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePipelineInfoRequest);
            return new SyncInvoker<UpdatePipelineInfoResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePipelineInfoResponse>);
        }
        
        /// <summary>
        /// 更新流水线模板
        ///
        /// 更新流水线模板
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePipelineTemplateResponse UpdatePipelineTemplate(UpdatePipelineTemplateRequest updatePipelineTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePipelineTemplateRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(updatePipelineTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{tenant_id}/api/pipeline-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePipelineTemplateRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdatePipelineTemplateResponse>(response);
        }

        public SyncInvoker<UpdatePipelineTemplateResponse> UpdatePipelineTemplateInvoker(UpdatePipelineTemplateRequest updatePipelineTemplateRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePipelineTemplateRequest.TenantId, out var valueOfTenantId)) urlParam.Add("tenant_id", valueOfTenantId);
            if (StringUtils.TryConvertToNonEmptyString(updatePipelineTemplateRequest.TemplateId, out var valueOfTemplateId)) urlParam.Add("template_id", valueOfTemplateId);
            var urlPath = HttpUtils.AddUrlPath("/v5/{tenant_id}/api/pipeline-templates/{template_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePipelineTemplateRequest);
            return new SyncInvoker<UpdatePipelineTemplateResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdatePipelineTemplateResponse>);
        }
        
        /// <summary>
        /// 更新插件基本信息
        ///
        /// 更新插件基本信息
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePluginBaseInfoResponse UpdatePluginBaseInfo(UpdatePluginBaseInfoRequest updatePluginBaseInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePluginBaseInfoRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/update-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePluginBaseInfoRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UpdatePluginBaseInfoResponse>(response);
        }

        public SyncInvoker<UpdatePluginBaseInfoResponse> UpdatePluginBaseInfoInvoker(UpdatePluginBaseInfoRequest updatePluginBaseInfoRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePluginBaseInfoRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/update-info", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePluginBaseInfoRequest);
            return new SyncInvoker<UpdatePluginBaseInfoResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdatePluginBaseInfoResponse>);
        }
        
        /// <summary>
        /// 更新插件草稿
        ///
        /// 更新插件草稿
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdatePluginDraftResponse UpdatePluginDraft(UpdatePluginDraftRequest updatePluginDraftRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePluginDraftRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/edit-draft", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePluginDraftRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UpdatePluginDraftResponse>(response);
        }

        public SyncInvoker<UpdatePluginDraftResponse> UpdatePluginDraftInvoker(UpdatePluginDraftRequest updatePluginDraftRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updatePluginDraftRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/agent-plugin/edit-draft", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePluginDraftRequest);
            return new SyncInvoker<UpdatePluginDraftResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UpdatePluginDraftResponse>);
        }
        
        /// <summary>
        /// 更新规则
        ///
        /// 更新规则
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateRuleResponse UpdateRule(UpdateRuleRequest updateRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRuleRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(updateRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/rules/{rule_id}/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateRuleRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateRuleResponse>(response);
        }

        public SyncInvoker<UpdateRuleResponse> UpdateRuleInvoker(UpdateRuleRequest updateRuleRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateRuleRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(updateRuleRequest.RuleId, out var valueOfRuleId)) urlParam.Add("rule_id", valueOfRuleId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/rules/{rule_id}/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateRuleRequest);
            return new SyncInvoker<UpdateRuleResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateRuleResponse>);
        }
        
        /// <summary>
        /// 修改策略
        ///
        /// 修改策略
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UpdateStrategyResponse UpdateStrategy(UpdateStrategyRequest updateStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateStrategyRequest.RuleSetId, out var valueOfRuleSetId)) urlParam.Add("rule_set_id", valueOfRuleSetId);
            if (StringUtils.TryConvertToNonEmptyString(updateStrategyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/tenant/rule-sets/{rule_set_id}/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateStrategyRequest);
            var response = DoHttpRequestSync("PUT", request);
            return JsonUtils.DeSerialize<UpdateStrategyResponse>(response);
        }

        public SyncInvoker<UpdateStrategyResponse> UpdateStrategyInvoker(UpdateStrategyRequest updateStrategyRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(updateStrategyRequest.RuleSetId, out var valueOfRuleSetId)) urlParam.Add("rule_set_id", valueOfRuleSetId);
            if (StringUtils.TryConvertToNonEmptyString(updateStrategyRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v2/{domain_id}/tenant/rule-sets/{rule_set_id}/update", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateStrategyRequest);
            return new SyncInvoker<UpdateStrategyResponse>(this, "PUT", request, JsonUtils.DeSerialize<UpdateStrategyResponse>);
        }
        
        /// <summary>
        /// 上传基础插件
        ///
        /// 上传基础插件
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UploadBasicPluginResponse UploadBasicPlugin(UploadBasicPluginRequest uploadBasicPluginRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(uploadBasicPluginRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/extension/upload", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadBasicPluginRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UploadBasicPluginResponse>(response);
        }

        public SyncInvoker<UploadBasicPluginResponse> UploadBasicPluginInvoker(UploadBasicPluginRequest uploadBasicPluginRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(uploadBasicPluginRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v3/{domain_id}/extension/upload", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadBasicPluginRequest);
            return new SyncInvoker<UploadBasicPluginResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UploadBasicPluginResponse>);
        }
        
        /// <summary>
        /// 更新插件图标
        ///
        /// 更新插件图标
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UploadPluginIconResponse UploadPluginIcon(UploadPluginIconRequest uploadPluginIconRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(uploadPluginIconRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/common/upload-plugin-icon", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadPluginIconRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UploadPluginIconResponse>(response);
        }

        public SyncInvoker<UploadPluginIconResponse> UploadPluginIconInvoker(UploadPluginIconRequest uploadPluginIconRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(uploadPluginIconRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/common/upload-plugin-icon", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadPluginIconRequest);
            return new SyncInvoker<UploadPluginIconResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UploadPluginIconResponse>);
        }
        
        /// <summary>
        /// 更新发布商图标
        ///
        /// 更新发布商图标
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public UploadPublisherIconResponse UploadPublisherIcon(UploadPublisherIconRequest uploadPublisherIconRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(uploadPublisherIconRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/common/upload-publisher-icon", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadPublisherIconRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerializeNull<UploadPublisherIconResponse>(response);
        }

        public SyncInvoker<UploadPublisherIconResponse> UploadPublisherIconInvoker(UploadPublisherIconRequest uploadPublisherIconRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(uploadPublisherIconRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v1/{domain_id}/common/upload-publisher-icon", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "multipart/form-data", uploadPublisherIconRequest);
            return new SyncInvoker<UploadPublisherIconResponse>(this, "POST", request, JsonUtils.DeSerializeNull<UploadPublisherIconResponse>);
        }
        
        /// <summary>
        /// 删除gitcode流水线运行详情
        ///
        /// 删除gitcode流水线运行详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public DeleteActionsRunPipelineResponse DeleteActionsRunPipeline(DeleteActionsRunPipelineRequest deleteActionsRunPipelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteActionsRunPipelineRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(deleteActionsRunPipelineRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            if (StringUtils.TryConvertToNonEmptyString(deleteActionsRunPipelineRequest.PipelineRunId, out var valueOfPipelineRunId)) urlParam.Add("pipeline_run_id", valueOfPipelineRunId);
            var urlPath = HttpUtils.AddUrlPath("/v6/{domain_id}/api/pac/pipelines/actions/{pipeline_id}/{pipeline_run_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteActionsRunPipelineRequest);
            var response = DoHttpRequestSync("DELETE", request);
            return JsonUtils.DeSerialize<DeleteActionsRunPipelineResponse>(response);
        }

        public SyncInvoker<DeleteActionsRunPipelineResponse> DeleteActionsRunPipelineInvoker(DeleteActionsRunPipelineRequest deleteActionsRunPipelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(deleteActionsRunPipelineRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(deleteActionsRunPipelineRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            if (StringUtils.TryConvertToNonEmptyString(deleteActionsRunPipelineRequest.PipelineRunId, out var valueOfPipelineRunId)) urlParam.Add("pipeline_run_id", valueOfPipelineRunId);
            var urlPath = HttpUtils.AddUrlPath("/v6/{domain_id}/api/pac/pipelines/actions/{pipeline_id}/{pipeline_run_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteActionsRunPipelineRequest);
            return new SyncInvoker<DeleteActionsRunPipelineResponse>(this, "DELETE", request, JsonUtils.DeSerialize<DeleteActionsRunPipelineResponse>);
        }
        
        /// <summary>
        /// 查询gitcode流水线运行记录
        ///
        /// 查询gitcode流水线运行记录
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListActionsPipelineRunsResponse ListActionsPipelineRuns(ListActionsPipelineRunsRequest listActionsPipelineRunsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listActionsPipelineRunsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v6/{domain_id}/api/pac/pipelines/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listActionsPipelineRunsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListActionsPipelineRunsResponse>(response);
        }

        public SyncInvoker<ListActionsPipelineRunsResponse> ListActionsPipelineRunsInvoker(ListActionsPipelineRunsRequest listActionsPipelineRunsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listActionsPipelineRunsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v6/{domain_id}/api/pac/pipelines/actions", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listActionsPipelineRunsRequest);
            return new SyncInvoker<ListActionsPipelineRunsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListActionsPipelineRunsResponse>);
        }
        
        /// <summary>
        /// 查询gitcode流水线action列表
        ///
        /// 查询gitcode流水线action列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ListActionsPipelineRunsByRunIdsResponse ListActionsPipelineRunsByRunIds(ListActionsPipelineRunsByRunIdsRequest listActionsPipelineRunsByRunIdsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listActionsPipelineRunsByRunIdsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v6/{domain_id}/api/pac/pipelines/actions/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listActionsPipelineRunsByRunIdsRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<ListActionsPipelineRunsByRunIdsResponse>(response);
        }

        public SyncInvoker<ListActionsPipelineRunsByRunIdsResponse> ListActionsPipelineRunsByRunIdsInvoker(ListActionsPipelineRunsByRunIdsRequest listActionsPipelineRunsByRunIdsRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(listActionsPipelineRunsByRunIdsRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v6/{domain_id}/api/pac/pipelines/actions/list", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listActionsPipelineRunsByRunIdsRequest);
            return new SyncInvoker<ListActionsPipelineRunsByRunIdsResponse>(this, "POST", request, JsonUtils.DeSerialize<ListActionsPipelineRunsByRunIdsResponse>);
        }
        
        /// <summary>
        /// 重试运行gitcode流水线
        ///
        /// 重试运行gitcode流水线
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RetryRunActionsPipelineResponse RetryRunActionsPipeline(RetryRunActionsPipelineRequest retryRunActionsPipelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(retryRunActionsPipelineRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v6/{domain_id}/api/pac/pipelines/actions/rerun", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", retryRunActionsPipelineRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RetryRunActionsPipelineResponse>(response);
        }

        public SyncInvoker<RetryRunActionsPipelineResponse> RetryRunActionsPipelineInvoker(RetryRunActionsPipelineRequest retryRunActionsPipelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(retryRunActionsPipelineRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v6/{domain_id}/api/pac/pipelines/actions/rerun", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", retryRunActionsPipelineRequest);
            return new SyncInvoker<RetryRunActionsPipelineResponse>(this, "POST", request, JsonUtils.DeSerialize<RetryRunActionsPipelineResponse>);
        }
        
        /// <summary>
        /// 运行gitcode流水线
        ///
        /// 运行gitcode流水线
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public RunActionsPipelineResponse RunActionsPipeline(RunActionsPipelineRequest runActionsPipelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runActionsPipelineRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v6/{domain_id}/api/pac/pipelines/actions/run", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runActionsPipelineRequest);
            var response = DoHttpRequestSync("POST", request);
            return JsonUtils.DeSerialize<RunActionsPipelineResponse>(response);
        }

        public SyncInvoker<RunActionsPipelineResponse> RunActionsPipelineInvoker(RunActionsPipelineRequest runActionsPipelineRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(runActionsPipelineRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            var urlPath = HttpUtils.AddUrlPath("/v6/{domain_id}/api/pac/pipelines/actions/run", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", runActionsPipelineRequest);
            return new SyncInvoker<RunActionsPipelineResponse>(this, "POST", request, JsonUtils.DeSerialize<RunActionsPipelineResponse>);
        }
        
        /// <summary>
        /// 查询gitcode流水线运行详情
        ///
        /// 查询gitcode流水线运行详情
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public ShowActionsRunsDetailResponse ShowActionsRunsDetail(ShowActionsRunsDetailRequest showActionsRunsDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showActionsRunsDetailRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(showActionsRunsDetailRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            if (StringUtils.TryConvertToNonEmptyString(showActionsRunsDetailRequest.PipelineRunId, out var valueOfPipelineRunId)) urlParam.Add("pipeline_run_id", valueOfPipelineRunId);
            var urlPath = HttpUtils.AddUrlPath("/v6/{domain_id}/api/pac/pipelines/actions/{pipeline_id}/{pipeline_run_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showActionsRunsDetailRequest);
            var response = DoHttpRequestSync("GET", request);
            return JsonUtils.DeSerialize<ShowActionsRunsDetailResponse>(response);
        }

        public SyncInvoker<ShowActionsRunsDetailResponse> ShowActionsRunsDetailInvoker(ShowActionsRunsDetailRequest showActionsRunsDetailRequest)
        {
            var urlParam = new Dictionary<string, string>();
            if (StringUtils.TryConvertToNonEmptyString(showActionsRunsDetailRequest.DomainId, out var valueOfDomainId)) urlParam.Add("domain_id", valueOfDomainId);
            if (StringUtils.TryConvertToNonEmptyString(showActionsRunsDetailRequest.PipelineId, out var valueOfPipelineId)) urlParam.Add("pipeline_id", valueOfPipelineId);
            if (StringUtils.TryConvertToNonEmptyString(showActionsRunsDetailRequest.PipelineRunId, out var valueOfPipelineRunId)) urlParam.Add("pipeline_run_id", valueOfPipelineRunId);
            var urlPath = HttpUtils.AddUrlPath("/v6/{domain_id}/api/pac/pipelines/actions/{pipeline_id}/{pipeline_run_id}", urlParam);
            var request = HttpUtils.InitSdkRequest(urlPath, "application/json", showActionsRunsDetailRequest);
            return new SyncInvoker<ShowActionsRunsDetailResponse>(this, "GET", request, JsonUtils.DeSerialize<ShowActionsRunsDetailResponse>);
        }
        
    }
}