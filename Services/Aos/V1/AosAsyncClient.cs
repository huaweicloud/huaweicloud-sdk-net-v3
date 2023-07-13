using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Aos.V1.Model;

namespace HuaweiCloud.SDK.Aos.V1
{
    public partial class AosAsyncClient : Client
    {
        public static ClientBuilder<AosAsyncClient> NewBuilder()
        {
            return new ClientBuilder<AosAsyncClient>();
        }

        
        /// <summary>
        /// 执行执行计划
        ///
        /// 执行执行计划（ApplyExecutionPlan）
        /// 
        /// 此API用于执行一个执行计划
        /// 
        /// * 当执行请求接受后，执行计划状态将变为&#x60;APPLY_IN_PROGRESS&#x60;，后台会进行异步处理。
        /// * 当执行结束后，执行计划状态将变为&#x60;APPLIED&#x60;。
        /// * 用户可以调用GetStackMetadata查询资源栈的状态（status）来跟踪资源栈部署情况以及确认本次执行结果是否成功。
        /// 
        /// 如果不希望通过执行计划进行部署操作，也可以选择调用DeployStack进行直接部署
        /// 
        /// 关于执行计划的过期失效：
        ///   1. 若指定资源栈下有多个执行计划，则在执行某个执行计划后（无论结果是否成功），剩余所有的执行计划将过期失效；
        ///   2. 若调用ApplyExecutionPlan时，指定的执行计划已经过期失效，则返回403
        /// 
        /// 若资源栈状态处于非终态（即以&#x60;IN_PROGRESS&#x60;结尾，详细见下方）状态时，则不允许执行执行计划，并返回403。非终态状态包括但不限于以下状态：
        ///   * 正在部署（DEPLOYMENT_IN_PROGRESS）
        ///   * 正在删除（DELETION_IN_PROGRESS）
        ///   * 正在回滚（ROLLBACK_IN_PROGRESS）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ApplyExecutionPlanResponse> ApplyExecutionPlanAsync(ApplyExecutionPlanRequest applyExecutionPlanRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , applyExecutionPlanRequest.StackName.ToString());
            urlParam.Add("execution_plan_name" , applyExecutionPlanRequest.ExecutionPlanName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/execution-plans/{execution_plan_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", applyExecutionPlanRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ApplyExecutionPlanResponse>(response);
        }
        
        /// <summary>
        /// 创建执行计划
        ///
        /// 创建执行计划（CreateExecutionPlan）
        /// 
        /// 此API用于在指定的资源栈下生成一个执行计划，执行计划描述了当前资源栈中记录的资源状态和模板描述的目的资源状态之间的区别（如，资源A将以以下配置文件生成，资源B将以下参数从XXX修改成YYY）
        /// 
        /// 调用此API触发创建执行计划之后，可以通过GetExecutionPlanMetadata来跟踪执行计划的状态
        /// 当执行计划状态为&#x60;AVAILABLE&#x60;时，可以通过GetExecutionPlan获取本次执行计划的结果
        /// 
        /// 执行计划不会做过多深层的检查和校验，如用户是否有权限生成、修改资源等
        /// 
        /// **注意：**
        ///   * 若指定资源栈不存在，则返回404
        ///   * 若请求中不含有template_body和template_uri，则返回400
        ///   * 若资源栈进行了某次部署操作，则在该次部署操作前生成的执行计划将全部失效
        ///   * 执行计划只代表生成时刻的结果，若执行计划生成后，用户手动修改资源状态，则执行计划不会自动更新
        ///   * 若资源栈状态处于&#x60;DEPLOYMENT_IN_PROGRESS&#x60;、&#x60;ROLLBACK_IN_PROGRESS&#x60;、&#x60;DELETION_IN_PROGRESS&#x60;等状态时，则不允许创建执行计划，并返回403
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateExecutionPlanResponse> CreateExecutionPlanAsync(CreateExecutionPlanRequest createExecutionPlanRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , createExecutionPlanRequest.StackName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/execution-plans",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createExecutionPlanRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateExecutionPlanResponse>(response);
        }
        
        /// <summary>
        /// 删除执行计划
        ///
        /// 删除执行计划（DeleteExecutionPlan）
        /// 
        /// 删除指定的执行计划
        /// 
        /// 若执行计划状态处于&#x60;CREATION_IN_PROGRESS&#x60;、&#x60;APPLY_IN_PROGRESS&#x60;状态时，则不允许删除并返回403
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteExecutionPlanResponse> DeleteExecutionPlanAsync(DeleteExecutionPlanRequest deleteExecutionPlanRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , deleteExecutionPlanRequest.StackName.ToString());
            urlParam.Add("execution_plan_name" , deleteExecutionPlanRequest.ExecutionPlanName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/execution-plans/{execution_plan_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteExecutionPlanRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteExecutionPlanResponse>(response);
        }
        
        /// <summary>
        /// 预估执行计划价格
        ///
        /// 预估执行计划价格（EstimateExecutionPlanPrice）
        /// 
        /// 此API可以基于一份已有的执行计划中增量的资源进行询价，当前支持询价的计费模式有包周期计费、按需计费、免费，暂不支持其他形式的计费模式，例如竞价计费模式等。
        /// 
        /// 注：
        ///   * 由于某些资源的属性值含有默认值，且该属性和询价参数相关。若用户的模板中描述的资源没有声明这些属性，则询价结果可能存在偏差。
        ///   * 询价结果仅为预估结果，具体请以实际为准。
        ///   * 若用户在模板中使用了depends_on参数，如A资源询价必要字段依赖于B资源的创建，则A资源不支持询价。
        ///   * 暂不支持传入data sources的flavor.id的场景的询价。
        ///   * 暂不支持镜像询价。
        ///   * 模板中询价的资源的个数是有限制的。当前一个模板中最多支持12个包周期计费资源和24个按需计费资源。
        ///   * 支持询价的资源列表和询价必要参数
        ///       * huaweicloud_cce_cluster: 
        ///           * 支持的计费模式：包周期、按需
        ///       * huaweicloud_css_cluster:
        ///           * 支持的计费模式：按需
        ///       * huaweicloud_evs_volume: 
        ///           * 支持的计费模式：包周期、按需
        ///           * 询价必要参数：size（磁盘规格）
        ///       * huaweicloud_compute_instance: 
        ///           * 支持的计费模式：包周期、按需
        ///           * 询价必要参数：flavor_id（规格ID）、flavor_name（规格名称，flavor_id和flavor_name至少给出一个）、system_disk_size（系统磁盘大小）
        ///       * huaweicloud_vpc_bandwidth:
        ///           * 支持的计费模式：按需
        ///           * 询价必要参数：charge_mode仅支持bandwidth
        ///       * huaweicloud_vpc_eip: 
        ///           * 支持的计费模式：包周期、按需
        ///           * 询价必要参数：bandwidth.size（带宽大小）
        ///       * huaweicloud_gaussdb_redis_instance: 
        ///           * 支持的计费模式：包周期、按需
        ///       * huaweicloud_nat_gateway: 
        ///           * 支持的计费模式：按需
        ///       * huaweicloud_rds_instance: 
        ///           * 支持的计费模式：包周期、按需
        ///       * huaweicloud_sfs_turbo: 
        ///           * 支持的计费模式：按需
        ///           * 询价必要参数：share_type（文件系统类型）
        ///       * huaweicloud_dms_kafka_instance: 
        ///           * 支持的计费模式：按需
        ///           * 询价必要参数：flavor_id（规格ID）、product_id（产品ID。flavor_id和product_id至少给出一个。）、storage_space（存储容量）
        ///       * huaweicloud_dcs_instance: 
        ///           * 支持的计费模式：包周期、按需
        ///       * huaweicloud_gaussdb_mysql_instance: 
        ///           * 支持的计费模式：包周期、按需
        ///           * 询价必要参数：proxy_node_number（代理节点数量）、volume_size（挂载卷的存储空间）
        ///       * huaweicloud_vpc: 
        ///           * 支持的计费模式：免费
        ///       * huaweicloud_drs_job: 
        ///           * 支持的计费模式：按需
        ///       * huaweicloud_apig_instance: 
        ///           * 支持的计费模式：按需
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<EstimateExecutionPlanPriceResponse> EstimateExecutionPlanPriceAsync(EstimateExecutionPlanPriceRequest estimateExecutionPlanPriceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , estimateExecutionPlanPriceRequest.StackName.ToString());
            urlParam.Add("execution_plan_name" , estimateExecutionPlanPriceRequest.ExecutionPlanName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/execution-plans/{execution_plan_name}/prices",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", estimateExecutionPlanPriceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<EstimateExecutionPlanPriceResponse>(response);
        }
        
        /// <summary>
        /// 获取执行计划
        ///
        /// 获取执行计划（GetExecutionPlan）
        /// 
        /// 此API用于获取指定执行计划的详细内容（即执行计划项目），用户可通过此API得知指定执行计划在执行后，资源栈中的资源会发生何种变化
        /// 
        /// 若执行计划状态为&#x60;CREATION_IN_PROGRESS&#x60;或&#x60;CREATION_FAILED&#x60;，则不返回执行计划项目列表
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetExecutionPlanResponse> GetExecutionPlanAsync(GetExecutionPlanRequest getExecutionPlanRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , getExecutionPlanRequest.StackName.ToString());
            urlParam.Add("execution_plan_name" , getExecutionPlanRequest.ExecutionPlanName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/execution-plans/{execution_plan_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", getExecutionPlanRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<GetExecutionPlanResponse>(response);
        }
        
        /// <summary>
        /// 获取执行计划元数据
        ///
        /// 获取执行计划元数据（GetExecutionPlanMetadata）
        /// 
        /// 该API可以获取指定执行计划的元数据，包括资源栈ID、资源栈名称、执行计划ID、执行计划名称、执行计划描述、执行计划的创建时间和执行时间、执行计划状态等信息。
        /// 
        /// 具体信息见GetExecutionPlanMetadataResponseBody。
        /// 
        /// 如果需要获取执行计划的具体内容，请调用GetExecutionPlan。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetExecutionPlanMetadataResponse> GetExecutionPlanMetadataAsync(GetExecutionPlanMetadataRequest getExecutionPlanMetadataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , getExecutionPlanMetadataRequest.StackName.ToString());
            urlParam.Add("execution_plan_name" , getExecutionPlanMetadataRequest.ExecutionPlanName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/execution-plans/{execution_plan_name}/metadata",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", getExecutionPlanMetadataRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<GetExecutionPlanMetadataResponse>(response);
        }
        
        /// <summary>
        /// 列举执行计划
        ///
        /// 列举执行计划（ListExecutionPlans）
        /// 
        /// 列举当前局点下用户指定资源栈下所有的执行计划
        /// 
        ///   * 默认按照生成时间排序，最早生成的在最前
        ///   * 注意：目前暂时返回全量执行计划信息，即不支持分页
        ///   * 如果指定的资源栈下没有任何执行计划，则返回空list
        ///   * 如果指定的资源栈不存在，则返回404
        /// 
        /// ListExecutionPlans返回的只有摘要信息（具体摘要信息见ListExecutionPlansResponseBody），如果用户需要详细的执行计划元数据请调用GetExecutionPlanMetadata
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListExecutionPlansResponse> ListExecutionPlansAsync(ListExecutionPlansRequest listExecutionPlansRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , listExecutionPlansRequest.StackName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/execution-plans",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listExecutionPlansRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListExecutionPlansResponse>(response);
        }
        
        /// <summary>
        /// 继续部署资源栈
        ///
        /// 继续部署资源栈（ContinueDeployStack）
        /// 
        /// 此API用于继续部署一个已有的资源栈
        /// 
        /// * 如果资源栈当前可以继续部署，即处于&#x60;DEPLOYMENT_FAILED&#x60;，则返回202与对应生成的deploymentId，否则将不允许继续部署并返回相应的错误码
        /// 
        /// * 继续部署操作依然有可能部署失败，用户可以从ListStackEvents获取对应的log，解决后可再次调用此API触发继续部署
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ContinueDeployStackResponse> ContinueDeployStackAsync(ContinueDeployStackRequest continueDeployStackRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , continueDeployStackRequest.StackName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/continuations",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", continueDeployStackRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ContinueDeployStackResponse>(response);
        }
        
        /// <summary>
        /// 继续回滚资源栈
        ///
        /// 继续回滚资源栈（ContinueRollbackStack）
        /// 
        /// 此API用于继续回滚一个已有的资源栈
        /// 
        /// 如果资源栈开启了自动回滚，在部署失败的时候则会自动回滚。但是自动回滚依然有可能失败，用户可以根据错误信息修复后，调用ContinueRollbackStack触发继续回滚，即重试回滚
        /// 
        /// * 如果资源栈当前可以回滚，即处于&#x60;ROLLBACK_FAILED&#x60;，则返回202与对应生成的deploymentId，否则将不允许回滚并返回响应的错误码
        /// * 继续回滚也有可能会回滚失败。如果失败，用户可以从ListStackEvents获取对应的log，解决后可再次调用ContinueRollbackStack去继续触发回滚
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ContinueRollbackStackResponse> ContinueRollbackStackAsync(ContinueRollbackStackRequest continueRollbackStackRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , continueRollbackStackRequest.StackName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/rollbacks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", continueRollbackStackRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ContinueRollbackStackResponse>(response);
        }
        
        /// <summary>
        /// 创建资源栈
        ///
        /// CreateStack用于生成一个资源栈
        /// 
        /// * 当请求中不含有模板（template）、参数（vars）等信息，将生成一个无任何资源的空资源栈，返回资源栈ID（stack_id）
        /// * 当请求中携带了模板（template）、参数（vars）等信息，则会同时创建并部署资源栈，返回资源栈ID（stack_id）和部署ID（deployment_id）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<CreateStackResponse> CreateStackAsync(CreateStackRequest createStackRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createStackRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateStackResponse>(response);
        }
        
        /// <summary>
        /// 删除资源栈
        ///
        /// 删除资源栈（DeleteStack）
        /// 
        /// 此API用于删除某个资源栈
        /// **请谨慎操作，删除资源栈将会删除与该资源栈相关的所有数据和资源，如：执行计划、资源栈事件、资源栈输出、资源等。**
        /// 
        /// * 此API会触发删除资源栈，并以最终一致性删除所有数据，用户可以调用GetStackMetadata或ListStacks跟踪资源栈删除情况
        /// * 如果资源栈状态处于非终态（状态以&#x60;IN_PROGRESS&#x60;结尾）状态时，则不允许删除。包括但不限于以下状态：
        ///   * 正在部署（DEPLOYMENT_IN_PROGRESS）
        ///   * 正在删除（DELETION_IN_PROGRESS）
        ///   * 正在回滚（ROLLBACK_IN_PROGRESS）
        /// * 如果资源栈开启了删除保护，则不允许删除。用户可调用GetStackMetadata，查看返回中的&#x60;enable_deletion_protection&#x60;字段判断删除保护是否开启。用户可通过调用UpdateStack关闭删除保护。
        /// * 如果资源栈删除失败，可以根据StackEvents提示信息修复当前模板中的错误后，部署成功后再次删除资源栈。有以下两种方式触发部署：
        ///   * 调用CreateExecutionPlan创建执行计划，执行计划创建成功后调用ApplyExecutionPlan部署资源栈。
        ///   * 调用DeployStack部署资源栈
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteStackResponse> DeleteStackAsync(DeleteStackRequest deleteStackRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , deleteStackRequest.StackName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteStackRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteStackResponse>(response);
        }
        
        /// <summary>
        /// 部署资源栈
        ///
        /// 部署资源栈（DeployStack）
        /// 
        /// 此API用于部署一个已有的资源栈
        /// 
        /// * 用户可以使用此API更新模板、参数等并触发一个新的部署
        /// 
        /// * 此API会直接触发部署，如果用户希望先确认部署会发生的时间，请使用执行计划，即使用CreateExecutionPlan以创建执行计划、使用GetExecutionPlan以获取执行计划
        /// 
        /// * 此API为全量API，即用户每次部署都需要给予所想要使用的template、vars的全量
        /// 
        /// * 当触发的部署失败时，如果资源栈开启了自动回滚，会触发自动回滚的流程，否则就会停留在部署失败时的状态
        /// 
        /// * 资源栈状态是DELETION_FAILED时，用户可根据StackEvents信息修复当前模板中的错误后，重新触发部署。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeployStackResponse> DeployStackAsync(DeployStackRequest deployStackRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , deployStackRequest.StackName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/deployments",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deployStackRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DeployStackResponse>(response);
        }
        
        /// <summary>
        /// 获取资源栈元数据
        ///
        /// 获取资源栈元数据（GetStackMetadata）
        /// 
        /// 此API用于获取指定资源栈的元数据，包括资源栈ID、资源栈名称、资源栈描述、创建时间、更新时间、资源栈状态、委托授权等信息。
        /// 
        /// 具体信息见GetStackMetadataResponseBody。
        /// 
        /// 注：
        /// 当资源栈状态处于非终态（即以&#x60;IN_PROGRESS&#x60;结尾，详细见下方）状态时，资源栈的元数据信息处于转变阶段，可能为部署前的状态，也可能为部署后的状态。
        /// 只有当资源栈状态处于终态（即以&#x60;COMPLETE&#x60;或&#x60;FAILED&#x60;结尾，详细见下方）时，资源栈的元数据信息才是部署后的状态
        /// 
        /// 非终态状态包括但不限于以下状态：
        ///   * 正在部署（DEPLOYMENT_IN_PROGRESS）
        ///   * 正在回滚（ROLLBACK_IN_PROGRESS）
        ///   * 正在删除（DELETION_IN_PROGRESS）
        /// 
        /// 终态状态包括但不限于以下状态：
        ///   * 生成空资源栈完成（CREATION_COMPLETE）
        ///   * 部署失败（DEPLOYMENT_FAILED）
        ///   * 部署完成（DEPLOYMENT_COMPLETE）
        ///   * 回滚失败（ROLLBACK_FAILED）
        ///   * 回滚完成（ROLLBACK_COMPLETE）
        ///   * 删除失败（DELETION_FAILED）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetStackMetadataResponse> GetStackMetadataAsync(GetStackMetadataRequest getStackMetadataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , getStackMetadataRequest.StackName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/metadata",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", getStackMetadataRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<GetStackMetadataResponse>(response);
        }
        
        /// <summary>
        /// 获取资源栈模板
        ///
        /// 获取资源栈模板（GetStackTemplate）
        /// 
        /// 此API用于获取资源栈最近一次部署终态使用的模板。
        /// 
        /// 注：
        /// 当资源栈状态处于非终态（即以&#x60;IN_PROGRESS&#x60;结尾，详细见下方）状态时，资源栈处于转变阶段，此API获取资源栈上一次部署使用的模板。
        /// 只有当资源栈状态处于终态（即以&#x60;COMPLETE&#x60;或&#x60;FAILED&#x60;结尾，详细见下方）时，此API获取当前最新一次部署使用的模板。CREATION_COMPLETE除外，此时资源栈没有模板，返回404，并提示模板不存在
        /// 
        /// 非终态状态包括但不限于以下状态：
        ///   * 正在部署（DEPLOYMENT_IN_PROGRESS）
        ///   * 正在回滚（ROLLBACK_IN_PROGRESS）
        ///   * 正在删除（DELETION_IN_PROGRESS）
        /// 
        /// 终态状态包括但不限于以下状态：
        ///   * 生成空资源栈完成（CREATION_COMPLETE）
        ///   * 部署失败（DEPLOYMENT_FAILED）
        ///   * 部署完成（DEPLOYMENT_COMPLETE）
        ///   * 回滚失败（ROLLBACK_FAILED）
        ///   * 回滚完成（ROLLBACK_COMPLETE）
        ///   * 删除失败（DELETION_FAILED）
        /// 
        /// 如果获取成功，则以临时重定向形式返回模板下载链接（OBS Pre Signed地址，有效期为5分钟），大多数的客户端会进行自动重定向并下载模板；
        /// 若未进行自动重定向，请参考HTTP的重定向规则获取模板下载链接，手动下载模板。
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<GetStackTemplateResponse> GetStackTemplateAsync(GetStackTemplateRequest getStackTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , getStackTemplateRequest.StackName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/templates",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", getStackTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerializeNull<GetStackTemplateResponse>(response);
        }
        
        /// <summary>
        /// 列举资源栈事件
        ///
        /// 列举资源栈事件（ListStackEvents）
        /// 
        /// 此API用于列举资源栈某一次或全部的部署事件
        /// 
        /// * 若给予deployment_id，则会将deployment_id作为查询条件，返回对应某一次部署的资源栈事件；若不给予deployment_id，则返回全量的资源栈事件
        /// * 若给定的deployment_id对应的部署不存在，则返回404
        /// * 可以使用filter作为过滤器，过滤出指定事件类型（event_type）、资源类型（resource_type）、资源名称（resource_name）的资源栈事件
        /// * 可以使用field选择数据应返回的属性，属性事件类型（event_type）不可配置，一定会返回，可选择的属性有逝去时间（elapsed_seconds）、事件消息（event_message）、 资源ID键（resource_id_key）、资源ID值（resource_id_value）、资源键（resource_key）、资源类型（resource_type）、资源名称（resource_name）和时间戳（timestamp）
        /// * 事件返回将以时间降序排列
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListStackEventsResponse> ListStackEventsAsync(ListStackEventsRequest listStackEventsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , listStackEventsRequest.StackName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/events",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStackEventsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListStackEventsResponse>(response);
        }
        
        /// <summary>
        /// 列举资源栈输出
        ///
        /// 列举资源栈输出（ListStackOutputs）
        /// 
        /// 此API用于列举该资源栈的所有输出
        /// 
        /// 资源栈输出为用户在模板中定义的 output 语句块在部署结束后所产生的返回信息，用户可在部署结束后，调用此API获取其具体的输出信息
        /// 
        /// 当资源栈状态处于非终态（状态以&#x60;IN_PROGRESS&#x60;结尾）状态时，此API将返回空。非终态包括但不限于以下状态：
        ///   * 正在部署（DEPLOYMENT_IN_PROGRESS）
        ///   * 正在删除（DELETION_IN_PROGRESS）
        ///   * 正在回滚（ROLLBACK_IN_PROGRESS）
        /// 
        /// output为HCL官方定义的语法，其返回信息类似于常见编程语言中的返回值，详细定义请参考HCL官方的说明
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListStackOutputsResponse> ListStackOutputsAsync(ListStackOutputsRequest listStackOutputsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , listStackOutputsRequest.StackName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/outputs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStackOutputsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListStackOutputsResponse>(response);
        }
        
        /// <summary>
        /// 列举资源栈资源
        ///
        /// 列举资源栈资源（ListStackResources）
        /// 
        /// 此API用于列举资源栈中当前管理的所有资源的信息
        /// 
        /// 当资源栈处于非终态时，仅输出资源栈下资源的简要信息，包含逻辑资源名称（logical_resource_name），逻辑资源类型（logical_resource_type），物理资源id（physical_resource_id），物理资源名称（physical_resource_name），资源状态（status）等信息；当资源栈处于终态时，将额外输出具体信息，如资源属性（resource_attributes）
        /// 
        /// 非终态包括但不限于以下状态：
        ///   * 正在部署（DEPLOYMENT_IN_PROGRESS）
        ///   * 正在删除（DELETION_IN_PROGRESS）
        ///   * 正在回滚（ROLLBACK_IN_PROGRESS）
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListStackResourcesResponse> ListStackResourcesAsync(ListStackResourcesRequest listStackResourcesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , listStackResourcesRequest.StackName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}/resources",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStackResourcesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListStackResourcesResponse>(response);
        }
        
        /// <summary>
        /// 列举资源栈
        ///
        /// 列举资源栈（ListStacks）
        /// 
        /// 此API用于列举当前局点下用户所有的资源栈
        /// 
        ///   * 默认按照生成时间排序，最早生成的在最前
        ///   * 注意：目前暂时返回全量资源栈信息，即不支持分页
        ///   * 如果没有任何资源栈，则返回空list
        /// 
        /// ListStacks返回的只有摘要信息（具体摘要信息见ListStacksResponseBody），如果用户需要详细的资源栈元数据请调用GetStackMetadata
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListStacksResponse> ListStacksAsync(ListStacksRequest listStacksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listStacksRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListStacksResponse>(response);
        }
        
        /// <summary>
        /// 更新资源栈
        ///
        /// 更新资源栈的属性，该API可以根据用户给予的信息对资源栈的属性进行更新，可以更新资源栈的“description”、“enable_deletion_protection”、\&quot;enable_auto_rollback\&quot;、\&quot;agencies\&quot;四个属性中的一个或多个
        /// 
        /// 该API只会更新用户给予的信息中所涉及的字段；若某字段未给予，则不会对该资源栈属性进行更新
        /// 
        /// 注：所有属性的更新都是覆盖式更新。即，所给予的参数将被完全覆盖至资源栈已有的属性上
        /// 
        /// 例如，若要新增agencies，请通过GetStackMetadata获取该资源栈原有的agencies信息，将新旧agencies信息进行整合后再调用UpdateStack
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateStackResponse> UpdateStackAsync(UpdateStackRequest updateStackRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("stack_name" , updateStackRequest.StackName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/stacks/{stack_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateStackRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PATCH",request);
            return JsonUtils.DeSerializeNull<UpdateStackResponse>(response);
        }
        
        /// <summary>
        /// 解析模板参数
        ///
        /// 解析模板参数（ParseTemplateVariables）
        /// 
        /// 此API用于解析用户输入的模板中的参数（variable），将解析模板中的所有variable块并返回
        /// 
        /// * 若用户传入的模板中定义了variable参数，则返回200和所有variable
        /// * 若用户传入的模板中没有定义variable参数，则返回200和空对象
        /// * 若用户请求非法或传入的模板非法，则返回400
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ParseTemplateVariablesResponse> ParseTemplateVariablesAsync(ParseTemplateVariablesRequest parseTemplateVariablesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/template-analyses/variables",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", parseTemplateVariablesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ParseTemplateVariablesResponse>(response);
        }
        
        /// <summary>
        /// 删除模板
        ///
        /// 删除模板（DeleteTemplate）
        /// 
        /// 此API用于删除某个模板以及模板下的全部模板版本
        /// **请谨慎操作，删除模板将会删除模板下的所有模板版本。**
        /// 
        ///   * tempate_id是模板的唯一Id。此Id由资源编排服务在生成模板的时候生成，为UUID。由于模板名仅仅在同一时间下唯一，即用户允许先生成一个叫HelloWorld的模板，删除，再重新创建一个同名模板。对于团队并行开发，用户可能希望确保，当前我操作的模板就是我认为的那个，而不是其他队友删除后创建的同名模板。因此，使用ID就可以做到强匹配。资源编排服务保证每次创建的模板所对应的ID都不相同，更新不会影响ID。如果给与的template_id和当前模板管理的ID不一致，则返回400
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTemplateResponse> DeleteTemplateAsync(DeleteTemplateRequest deleteTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("template_name" , deleteTemplateRequest.TemplateName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/templates/{template_name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTemplateResponse>(response);
        }
        
        /// <summary>
        /// 删除模板版本
        ///
        /// 删除模板版本（DeleteTemplateVersion）
        /// 
        /// 此API用于删除某个模板版本
        /// 
        ///   * tempate_id是模板的唯一Id。此Id由资源编排服务在生成模板的时候生成，为UUID。由于模板名仅仅在同一时间下唯一，即用户允许先生成一个叫HelloWorld的模板，删除，再重新创建一个同名模板。对于团队并行开发，用户可能希望确保，当前我操作的模板就是我认为的那个，而不是其他队友删除后创建的同名模板。因此，使用ID就可以做到强匹配。资源编排服务保证每次创建的模板所对应的ID都不相同，更新不会影响ID。如果给与的template_id和当前模板管理的ID不一致，则返回400
        ///   * 若模板下只存在唯一模板版本，此模板版本将无法被删除，如果需要删除此模板版本，请调用DeleteTemplate。模板服务不允许存在没有模板版本的模板
        /// 
        /// **请谨慎操作**
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<DeleteTemplateVersionResponse> DeleteTemplateVersionAsync(DeleteTemplateVersionRequest deleteTemplateVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("template_name" , deleteTemplateVersionRequest.TemplateName.ToString());
            urlParam.Add("version_id" , deleteTemplateVersionRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/templates/{template_name}/versions/{version_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTemplateVersionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteTemplateVersionResponse>(response);
        }
        
        /// <summary>
        /// 列举模板版本
        ///
        /// 列举模板版本信息（ListTemplateVersions）
        /// 
        /// 此API用于列举模板下所有的模板版本信息
        /// 
        ///   * 默认按照生成时间排序，最早生成的模板排列在最前面
        ///   * 注意：目前返回全量模板版本信息，即不支持分页
        ///   * 如果没有任何模板版本，则返回空list
        ///   * tempate_id是模板的唯一Id。此Id由资源编排服务在生成模板的时候生成，为UUID。由于模板名仅仅在同一时间下唯一，即用户允许先生成一个叫HelloWorld的模板，删除，再重新创建一个同名模板。对于团队并行开发，用户可能希望确保，当前我操作的模板就是我认为的那个，而不是其他队友删除后创建的同名模板。因此，使用ID就可以做到强匹配。资源编排服务保证每次创建的模板所对应的ID都不相同，更新不会影响ID。如果给与的template_id和当前模板管理的ID不一致，则返回400
        ///   * 若模板不存在则返回404
        /// 
        /// ListTemplateVersions返回的信息只包含模板版本摘要信息（具体摘要信息见ListTemplateVersionsResponseBody），若用户需要了解模板版本内容，请调用ShowTemplateVersionContent
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTemplateVersionsResponse> ListTemplateVersionsAsync(ListTemplateVersionsRequest listTemplateVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("template_name" , listTemplateVersionsRequest.TemplateName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/templates/{template_name}/versions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplateVersionsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTemplateVersionsResponse>(response);
        }
        
        /// <summary>
        /// 列举模板
        ///
        /// 列举模板（ListTemplates）
        /// 
        /// 此API用于列举当前局点下用户所有的模板
        /// 
        ///   * 默认按照生成时间排序，最早生成的模板排列在最前面
        ///   * 注意：目前返回全量模板信息，即不支持分页
        ///   * 如果没有任何模板，则返回空list
        ///   * 若用户需要详细的模板版本信息，请调用ListTemplateVersions
        /// 
        /// ListTemplates返回的信息只包含模板摘要信息（具体摘要信息见ListTemplatesResponseBody），若用户需要详细的某个模板信息，请调用ShowTemplateMetadata
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ListTemplatesResponse> ListTemplatesAsync(ListTemplatesRequest listTemplatesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/templates",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTemplatesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTemplatesResponse>(response);
        }
        
        /// <summary>
        /// 获取模板元数据
        ///
        /// 获取模板元数据（ShowTemplateMetadata）
        /// 
        /// 此API用于获取当前模板的元数据信息
        /// 
        /// 具体信息见ShowTemplateMetadataResponseBody，若想查看模板下全部模板版本，请调用ListTemplateVersions。
        /// 
        ///   * tempate_id是模板的唯一Id。此Id由资源编排服务在生成模板的时候生成，为UUID。由于模板名仅仅在同一时间下唯一，即用户允许先生成一个叫HelloWorld的模板，删除，再重新创建一个同名模板。对于团队并行开发，用户可能希望确保，当前我操作的模板就是我认为的那个，而不是其他队友删除后创建的同名模板。因此，使用ID就可以做到强匹配。资源编排服务保证每次创建的模板所对应的ID都不相同，更新不会影响ID。如果给与的template_id和当前模板管理的ID不一致，则返回400
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTemplateMetadataResponse> ShowTemplateMetadataAsync(ShowTemplateMetadataRequest showTemplateMetadataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("template_name" , showTemplateMetadataRequest.TemplateName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/templates/{template_name}/metadata",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTemplateMetadataRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowTemplateMetadataResponse>(response);
        }
        
        /// <summary>
        /// 获取模板版本内容
        ///
        /// 获取模板版本内容（ShowTemplateVersionContent）
        /// 
        /// 此API用于获取用户的模板版本内容
        /// 
        ///   * tempate_id是模板的唯一Id。此Id由资源编排服务在生成模板的时候生成，为UUID。由于模板名仅仅在同一时间下唯一，即用户允许先生成一个叫HelloWorld的模板，删除，再重新创建一个同名模板。对于团队并行开发，用户可能希望确保，当前我操作的模板就是我认为的那个，而不是其他队友删除后创建的同名模板。因此，使用ID就可以做到强匹配。资源编排服务保证每次创建的模板所对应的ID都不相同，更新不会影响ID。如果给与的template_id和当前模板管理的ID不一致，则返回400
        ///   * 此api会以临时重定向形式返回模板内容的下载链接，用户通过下载获取模板版本内容（OBS Pre Signed地址，有效期为5分钟）
        /// 
        /// ShowTemplateVersionContent返回的信息只包含模板版本内容，若想知道模板版本的元数据，请调用ShowTemplateVersionMetadata
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTemplateVersionContentResponse> ShowTemplateVersionContentAsync(ShowTemplateVersionContentRequest showTemplateVersionContentRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("template_name" , showTemplateVersionContentRequest.TemplateName.ToString());
            urlParam.Add("version_id" , showTemplateVersionContentRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/templates/{template_name}/versions/{version_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTemplateVersionContentRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerializeNull<ShowTemplateVersionContentResponse>(response);
        }
        
        /// <summary>
        /// 获取模板版本元数据
        ///
        /// 获取模板版本元数据（ShowTemplateVersionMetadata）
        /// 
        /// 此API用于展示某一版本模板的元数据
        /// 
        ///   * tempate_id是模板的唯一Id。此Id由资源编排服务在生成模板的时候生成，为UUID。由于模板名仅仅在同一时间下唯一，即用户允许先生成一个叫HelloWorld的模板，删除，再重新创建一个同名模板。对于团队并行开发，用户可能希望确保，当前我操作的模板就是我认为的那个，而不是其他队友删除后创建的同名模板。因此，使用ID就可以做到强匹配。资源编排服务保证每次创建的模板所对应的ID都不相同，更新不会影响ID。如果给与的template_id和当前模板管理的ID不一致，则返回400
        /// 
        /// ShowTemplateVersionMetadata返回的信息只包含模板版本元数据信息（具体摘要信息见ShowTemplateVersionMetadataResponseBody），若用户需要了解模板版本内容，请调用ShowTemplateVersionContent
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<ShowTemplateVersionMetadataResponse> ShowTemplateVersionMetadataAsync(ShowTemplateVersionMetadataRequest showTemplateVersionMetadataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("template_name" , showTemplateVersionMetadataRequest.TemplateName.ToString());
            urlParam.Add("version_id" , showTemplateVersionMetadataRequest.VersionId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/templates/{template_name}/versions/{version_id}/metadata",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTemplateVersionMetadataRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowTemplateVersionMetadataResponse>(response);
        }
        
        /// <summary>
        /// 更新模板元数据
        ///
        /// 更新模板元数据（UpdateTemplateMetadata）
        /// 
        /// 此API用于更新模板元数据
        /// 
        /// * 此api只支持更新模板描述
        /// 
        /// Please refer to HUAWEI cloud API Explorer for details.
        /// </summary>
        public async Task<UpdateTemplateMetadataResponse> UpdateTemplateMetadataAsync(UpdateTemplateMetadataRequest updateTemplateMetadataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("template_name" , updateTemplateMetadataRequest.TemplateName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/templates/{template_name}/metadata",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateTemplateMetadataRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PATCH",request);
            return JsonUtils.DeSerializeNull<UpdateTemplateMetadataResponse>(response);
        }
        
    }
}