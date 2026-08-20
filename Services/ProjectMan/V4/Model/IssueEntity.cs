using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 工作项对象
    /// </summary>
    public class IssueEntity 
    {

        /// <summary>
        /// 需要更新的工作项ID，可通过查询树状工作项接口获取，响应消息体中的id字段的值就是工作项ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 工作项标题，可通过查询树状工作项接口获取，响应消息体中的title字段的值就是工作项标题。
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 工作项描述字段，可通过查询树状工作项接口获取，响应消息体中的description字段的值就是工作项描述字段。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 工作项大分类定义。工作项创建、编辑无此字段，仅作展示用，可通过查询树状工作项接口获取，响应消息体中的type字段的值就是工作项大分类定义。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 工作项编号，可通过查询树状工作项接口获取，响应消息体中的number字段的值就是工作项编号。
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 工作项类型，可通过查询树状工作项接口获取，响应消息体中的category字段的值就是工作项类型。
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// 工作项类型层级关系ID，此参数影响工作项的层级显示。通过获取模型树配置信息获取，根据参数中的category在响应消息体中category_layer_config中找到对应的category_code，和category_code同级的id就是工作项类型层级关系ID。
        /// </summary>
        [JsonProperty("category_layer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryLayerId { get; set; }

        /// <summary>
        /// 父工作项ID，可通过查询树状工作项接口获取，响应消息体中的parent_id字段的值就是父工作项ID。
        /// </summary>
        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentId { get; set; }

        /// <summary>
        /// 项目的32位uuid，项目唯一标识，通过查询IPD项目列表接口获取，响应消息体中的project_id字段的值就是项目ID。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 工作项状态code。可通过查询工作项状态接口获取，响应消息体中的code字段的值就是工作项工作项状态code。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 工作项的生命周期，可选值为“正在工作”，“作废”，可通过查询树状工作项接口获取，响应消息体中的state字段的值就是工作项的生命周期。
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("assignee", NullValueHandling = NullValueHandling.Ignore)]
        public UserEntity Assignee { get; set; }

        /// <summary>
        /// 工作项抄送人，支持多个抄送人。数组元素为UserEntity对象。
        /// </summary>
        [JsonProperty("assigned_cc", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserEntity> AssignedCc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("created_by", NullValueHandling = NullValueHandling.Ignore)]
        public UserEntity CreatedBy { get; set; }

        /// <summary>
        /// 工作项创建时间，unix时间戳，单位：毫秒。
        /// </summary>
        [JsonProperty("created_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("modified_by", NullValueHandling = NullValueHandling.Ignore)]
        public UserEntity ModifiedBy { get; set; }

        /// <summary>
        /// 工作项最近更新时间，unix时间戳，单位：毫秒。
        /// </summary>
        [JsonProperty("modified_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// 工作项计划结束日期，unix时间戳，单位：毫秒。
        /// </summary>
        [JsonProperty("plan_end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanEndDate { get; set; }

        /// <summary>
        /// 工作项关闭时间，unix时间戳，单位：毫秒。
        /// </summary>
        [JsonProperty("close_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CloseTime { get; set; }

        /// <summary>
        /// 工作项计划工时。
        /// </summary>
        [JsonProperty("workload", NullValueHandling = NullValueHandling.Ignore)]
        public string Workload { get; set; }

        /// <summary>
        /// 工作项实际工时。
        /// </summary>
        [JsonProperty("workload_sum", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkloadSum { get; set; }

        /// <summary>
        /// 工作项所属租户ID，可通过查询树状工作项接口获取，响应消息体中的tenant_id字段的值就是工作项所属租户ID。
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 工作项关联项ID。
        /// </summary>
        [JsonProperty("link", NullValueHandling = NullValueHandling.Ignore)]
        public string Link { get; set; }

        /// <summary>
        /// 工作项是否已挂起。
        /// </summary>
        [JsonProperty("suspended", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Suspended { get; set; }

        /// <summary>
        /// 工作项状态改变时间，可用于计算工作项在当前状态停留天数，unix时间戳，单位：毫秒。
        /// </summary>
        [JsonProperty("status_modified_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusModifiedTime { get; set; }

        /// <summary>
        /// 工作项标签。数组元素为LabelEntity对象。
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public List<LabelEntity> Labels { get; set; }

        /// <summary>
        /// 工作项自定义字段映射，用户添加的系统字段也在此列，格式为{\&quot;code\&quot;:\&quot;字段code\&quot;,\&quot;value\&quot;:\&quot;字段值\&quot;}。数组元素为FieldCodeValuePair对象。
        /// </summary>
        [JsonProperty("custom_fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<FieldCodeValuePair> CustomFields { get; set; }

        /// <summary>
        /// 工作项的子工作项集合。数组元素为IssueEntity对象。
        /// </summary>
        [JsonProperty("children", NullValueHandling = NullValueHandling.Ignore)]
        public List<IssueEntity> Children { get; set; }

        /// <summary>
        /// 子工作项的路径。
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// IR和SF的关联字段。
        /// </summary>
        [JsonProperty("ir2feature", NullValueHandling = NullValueHandling.Ignore)]
        public string Ir2feature { get; set; }

        /// <summary>
        /// 工作项是否需要分解。
        /// </summary>
        [JsonProperty("need_break", NullValueHandling = NullValueHandling.Ignore)]
        public string NeedBreak { get; set; }

        /// <summary>
        /// 分解状态。
        /// </summary>
        [JsonProperty("break_status", NullValueHandling = NullValueHandling.Ignore)]
        public string BreakStatus { get; set; }

        /// <summary>
        /// 工作项基线状态。
        /// </summary>
        [JsonProperty("baseline", NullValueHandling = NullValueHandling.Ignore)]
        public string Baseline { get; set; }

        /// <summary>
        /// 工作项优先级，部分工作项有此字段。
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public string Priority { get; set; }

        /// <summary>
        /// 是否涉及网络安全。
        /// </summary>
        [JsonProperty("related_network_security", NullValueHandling = NullValueHandling.Ignore)]
        public string RelatedNetworkSecurity { get; set; }

        /// <summary>
        /// 研发需求协同信息，协同任务ID，可通过查询树状工作项接口获取，响应消息体中的collaboratives字段的值就是研发需求协同信息，协同任务ID。
        /// </summary>
        [JsonProperty("collaboratives", NullValueHandling = NullValueHandling.Ignore)]
        public string Collaboratives { get; set; }

        /// <summary>
        /// 领域字段。
        /// </summary>
        [JsonProperty("business_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessDomain { get; set; }

        /// <summary>
        /// 工作项发布计划ID。通过发布/迭代计划列表查询接口查询计划列表，返回参数中PlanVO里面的category&#x3D;PI的对象的id字段就是迭代计划的ID。
        /// </summary>
        [JsonProperty("plan_pi", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanPi { get; set; }

        /// <summary>
        /// 工作项完成的迭代计划ID，在Bug中为修复迭代计划ID。通过发布/迭代计划列表查询接口查询计划列表，返回参数中PlanVO里面的category&#x3D;Iteration的对象的id字段就是迭代计划的ID。
        /// </summary>
        [JsonProperty("plan_iteration", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanIteration { get; set; }

        /// <summary>
        /// 工作项变更状态。
        /// </summary>
        [JsonProperty("change_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ChangeStatus { get; set; }

        /// <summary>
        /// 无需分解原因。
        /// </summary>
        [JsonProperty("no_break_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string NoBreakReason { get; set; }

        /// <summary>
        /// 工作项提出人。数组元素为UserEntity对象。
        /// </summary>
        [JsonProperty("submitted_by", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserEntity> SubmittedBy { get; set; }

        /// <summary>
        /// IR关联的RR ID，可以通过查询工作项列表或者查询树状工作项接口获取，响应消息体中的id字段的值就是工作项ID。
        /// </summary>
        [JsonProperty("ir2rr", NullValueHandling = NullValueHandling.Ignore)]
        public string Ir2rr { get; set; }

        /// <summary>
        /// 特性集ID，可以通过查询特性集接口获取，响应消息体中的id字段的值就是特性集ID。
        /// </summary>
        [JsonProperty("feature_set", NullValueHandling = NullValueHandling.Ignore)]
        public string FeatureSet { get; set; }

        /// <summary>
        /// 期望修复时间。预设字段中，仅Bug有此字段，unix时间戳，单位：毫秒。
        /// </summary>
        [JsonProperty("expected_repair_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpectedRepairDate { get; set; }

        /// <summary>
        /// 缺陷发现发布计划ID，预设字段中，仅Bug有此字段。通过发布/迭代计划列表查询接口查询计划列表，返回参数中PlanVO里面的category&#x3D;PI的对象的id字段就是迭代计划的ID。
        /// </summary>
        [JsonProperty("found_pi", NullValueHandling = NullValueHandling.Ignore)]
        public string FoundPi { get; set; }

        /// <summary>
        /// 缺陷发现迭代计划ID，预设字段中，仅Bug有此字段。通过发布/迭代计划列表查询接口查询计划列表，返回参数中PlanVO里面的category&#x3D;Iteration的对象的id字段就是迭代计划的ID。
        /// </summary>
        [JsonProperty("found_iteration", NullValueHandling = NullValueHandling.Ignore)]
        public string FoundIteration { get; set; }

        /// <summary>
        /// 分析原因。
        /// </summary>
        [JsonProperty("reason_analysis", NullValueHandling = NullValueHandling.Ignore)]
        public string ReasonAnalysis { get; set; }

        /// <summary>
        /// 修复方案。预设字段中，仅Bug有此字段。
        /// </summary>
        [JsonProperty("repair_solution", NullValueHandling = NullValueHandling.Ignore)]
        public string RepairSolution { get; set; }

        /// <summary>
        /// 测试报告。预设字段中，仅Bug有此字段。
        /// </summary>
        [JsonProperty("test_report", NullValueHandling = NullValueHandling.Ignore)]
        public string TestReport { get; set; }

        /// <summary>
        /// 无需修复原因。预设字段中，仅Bug有此字段。
        /// </summary>
        [JsonProperty("sys_no_repair_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string SysNoRepairReason { get; set; }

        /// <summary>
        /// 激活原因。预设字段中，仅Bug有此字段。
        /// </summary>
        [JsonProperty("sys_activation_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string SysActivationReason { get; set; }

        /// <summary>
        /// 退回原因。预设字段中，仅Bug有此字段。
        /// </summary>
        [JsonProperty("sys_return_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string SysReturnReason { get; set; }

        /// <summary>
        /// 回归不通过次数。预设字段中，仅Bug有此字段。
        /// </summary>
        [JsonProperty("test_failures_times", NullValueHandling = NullValueHandling.Ignore)]
        public int? TestFailuresTimes { get; set; }

        /// <summary>
        /// 关闭类型。
        /// </summary>
        [JsonProperty("close_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CloseType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("plan_owner", NullValueHandling = NullValueHandling.Ignore)]
        public UserEntity PlanOwner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("doing_owner", NullValueHandling = NullValueHandling.Ignore)]
        public UserEntity DoingOwner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("delivered_owner", NullValueHandling = NullValueHandling.Ignore)]
        public UserEntity DeliveredOwner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("checking_owner", NullValueHandling = NullValueHandling.Ignore)]
        public UserEntity CheckingOwner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("test_owner", NullValueHandling = NullValueHandling.Ignore)]
        public UserEntity TestOwner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("develop_owner", NullValueHandling = NullValueHandling.Ignore)]
        public UserEntity DevelopOwner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("processing_owner", NullValueHandling = NullValueHandling.Ignore)]
        public UserEntity ProcessingOwner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fixed_owner", NullValueHandling = NullValueHandling.Ignore)]
        public UserEntity FixedOwner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("researchanddevelop_owner", NullValueHandling = NullValueHandling.Ignore)]
        public UserEntity ResearchanddevelopOwner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("analyse_owner", NullValueHandling = NullValueHandling.Ignore)]
        public UserEntity AnalyseOwner { get; set; }

        /// <summary>
        /// 计划开始时间。工作项的计划启动日期，用于项目进度管理和排期。
        /// </summary>
        [JsonProperty("plan_start_date", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanStartDate { get; set; }

        /// <summary>
        /// 期望完成时间。工作项的预期交付日期，用于跟踪工作项是否按期完成。
        /// </summary>
        [JsonProperty("expect_delivery_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpectDeliveryTime { get; set; }

        /// <summary>
        /// 计划测试结束时间。Bug类型工作项的计划测试完成日期，用于跟踪Bug修复后的测试进度。
        /// </summary>
        [JsonProperty("plan_test_end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanTestEndDate { get; set; }

        /// <summary>
        /// 严重程度。Bug类型工作项的严重级别，用于评估Bug的影响范围和修复优先级。
        /// </summary>
        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public string Severity { get; set; }

        /// <summary>
        /// 是否承诺。RR（原始需求）类型工作项的承诺状态标识，用于标记需求是否已承诺交付。
        /// </summary>
        [JsonProperty("promised", NullValueHandling = NullValueHandling.Ignore)]
        public string Promised { get; set; }

        /// <summary>
        /// 承接人。RR（原始需求）类型工作项的需求承接责任人，负责需求的分析和转化。
        /// </summary>
        [JsonProperty("recipient", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserEntity> Recipient { get; set; }

        /// <summary>
        /// 无需研发原因。RR（原始需求）类型工作项不需要进行研发的原因说明。
        /// </summary>
        [JsonProperty("sys_no_develop_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string SysNoDevelopReason { get; set; }

        /// <summary>
        /// 价值特性。SF/FE类型工作项对应的业务价值特性描述，用于关联业务价值和技术实现。
        /// </summary>
        [JsonProperty("val_feature", NullValueHandling = NullValueHandling.Ignore)]
        public string ValFeature { get; set; }

        /// <summary>
        /// 功能场景。SF/FE类型工作项的功能应用场景描述，用于说明特性的使用场景和用户故事。
        /// </summary>
        [JsonProperty("function_scene", NullValueHandling = NullValueHandling.Ignore)]
        public string FunctionScene { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueEntity {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  categoryLayerId: ").Append(CategoryLayerId).Append("\n");
            sb.Append("  parentId: ").Append(ParentId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  assignee: ").Append(Assignee).Append("\n");
            sb.Append("  assignedCc: ").Append(AssignedCc).Append("\n");
            sb.Append("  createdBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  createdTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  modifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  modifiedTime: ").Append(ModifiedTime).Append("\n");
            sb.Append("  planEndDate: ").Append(PlanEndDate).Append("\n");
            sb.Append("  closeTime: ").Append(CloseTime).Append("\n");
            sb.Append("  workload: ").Append(Workload).Append("\n");
            sb.Append("  workloadSum: ").Append(WorkloadSum).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  link: ").Append(Link).Append("\n");
            sb.Append("  suspended: ").Append(Suspended).Append("\n");
            sb.Append("  statusModifiedTime: ").Append(StatusModifiedTime).Append("\n");
            sb.Append("  labels: ").Append(Labels).Append("\n");
            sb.Append("  customFields: ").Append(CustomFields).Append("\n");
            sb.Append("  children: ").Append(Children).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  ir2feature: ").Append(Ir2feature).Append("\n");
            sb.Append("  needBreak: ").Append(NeedBreak).Append("\n");
            sb.Append("  breakStatus: ").Append(BreakStatus).Append("\n");
            sb.Append("  baseline: ").Append(Baseline).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  relatedNetworkSecurity: ").Append(RelatedNetworkSecurity).Append("\n");
            sb.Append("  collaboratives: ").Append(Collaboratives).Append("\n");
            sb.Append("  businessDomain: ").Append(BusinessDomain).Append("\n");
            sb.Append("  planPi: ").Append(PlanPi).Append("\n");
            sb.Append("  planIteration: ").Append(PlanIteration).Append("\n");
            sb.Append("  changeStatus: ").Append(ChangeStatus).Append("\n");
            sb.Append("  noBreakReason: ").Append(NoBreakReason).Append("\n");
            sb.Append("  submittedBy: ").Append(SubmittedBy).Append("\n");
            sb.Append("  ir2rr: ").Append(Ir2rr).Append("\n");
            sb.Append("  featureSet: ").Append(FeatureSet).Append("\n");
            sb.Append("  expectedRepairDate: ").Append(ExpectedRepairDate).Append("\n");
            sb.Append("  foundPi: ").Append(FoundPi).Append("\n");
            sb.Append("  foundIteration: ").Append(FoundIteration).Append("\n");
            sb.Append("  reasonAnalysis: ").Append(ReasonAnalysis).Append("\n");
            sb.Append("  repairSolution: ").Append(RepairSolution).Append("\n");
            sb.Append("  testReport: ").Append(TestReport).Append("\n");
            sb.Append("  sysNoRepairReason: ").Append(SysNoRepairReason).Append("\n");
            sb.Append("  sysActivationReason: ").Append(SysActivationReason).Append("\n");
            sb.Append("  sysReturnReason: ").Append(SysReturnReason).Append("\n");
            sb.Append("  testFailuresTimes: ").Append(TestFailuresTimes).Append("\n");
            sb.Append("  closeType: ").Append(CloseType).Append("\n");
            sb.Append("  planOwner: ").Append(PlanOwner).Append("\n");
            sb.Append("  doingOwner: ").Append(DoingOwner).Append("\n");
            sb.Append("  deliveredOwner: ").Append(DeliveredOwner).Append("\n");
            sb.Append("  checkingOwner: ").Append(CheckingOwner).Append("\n");
            sb.Append("  testOwner: ").Append(TestOwner).Append("\n");
            sb.Append("  developOwner: ").Append(DevelopOwner).Append("\n");
            sb.Append("  processingOwner: ").Append(ProcessingOwner).Append("\n");
            sb.Append("  fixedOwner: ").Append(FixedOwner).Append("\n");
            sb.Append("  researchanddevelopOwner: ").Append(ResearchanddevelopOwner).Append("\n");
            sb.Append("  analyseOwner: ").Append(AnalyseOwner).Append("\n");
            sb.Append("  planStartDate: ").Append(PlanStartDate).Append("\n");
            sb.Append("  expectDeliveryTime: ").Append(ExpectDeliveryTime).Append("\n");
            sb.Append("  planTestEndDate: ").Append(PlanTestEndDate).Append("\n");
            sb.Append("  severity: ").Append(Severity).Append("\n");
            sb.Append("  promised: ").Append(Promised).Append("\n");
            sb.Append("  recipient: ").Append(Recipient).Append("\n");
            sb.Append("  sysNoDevelopReason: ").Append(SysNoDevelopReason).Append("\n");
            sb.Append("  valFeature: ").Append(ValFeature).Append("\n");
            sb.Append("  functionScene: ").Append(FunctionScene).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IssueEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IssueEntity input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.CategoryLayerId != input.CategoryLayerId || (this.CategoryLayerId != null && !this.CategoryLayerId.Equals(input.CategoryLayerId))) return false;
            if (this.ParentId != input.ParentId || (this.ParentId != null && !this.ParentId.Equals(input.ParentId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.Assignee != input.Assignee || (this.Assignee != null && !this.Assignee.Equals(input.Assignee))) return false;
            if (this.AssignedCc != input.AssignedCc || (this.AssignedCc != null && input.AssignedCc != null && !this.AssignedCc.SequenceEqual(input.AssignedCc))) return false;
            if (this.CreatedBy != input.CreatedBy || (this.CreatedBy != null && !this.CreatedBy.Equals(input.CreatedBy))) return false;
            if (this.CreatedTime != input.CreatedTime || (this.CreatedTime != null && !this.CreatedTime.Equals(input.CreatedTime))) return false;
            if (this.ModifiedBy != input.ModifiedBy || (this.ModifiedBy != null && !this.ModifiedBy.Equals(input.ModifiedBy))) return false;
            if (this.ModifiedTime != input.ModifiedTime || (this.ModifiedTime != null && !this.ModifiedTime.Equals(input.ModifiedTime))) return false;
            if (this.PlanEndDate != input.PlanEndDate || (this.PlanEndDate != null && !this.PlanEndDate.Equals(input.PlanEndDate))) return false;
            if (this.CloseTime != input.CloseTime || (this.CloseTime != null && !this.CloseTime.Equals(input.CloseTime))) return false;
            if (this.Workload != input.Workload || (this.Workload != null && !this.Workload.Equals(input.Workload))) return false;
            if (this.WorkloadSum != input.WorkloadSum || (this.WorkloadSum != null && !this.WorkloadSum.Equals(input.WorkloadSum))) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;
            if (this.Link != input.Link || (this.Link != null && !this.Link.Equals(input.Link))) return false;
            if (this.Suspended != input.Suspended || (this.Suspended != null && !this.Suspended.Equals(input.Suspended))) return false;
            if (this.StatusModifiedTime != input.StatusModifiedTime || (this.StatusModifiedTime != null && !this.StatusModifiedTime.Equals(input.StatusModifiedTime))) return false;
            if (this.Labels != input.Labels || (this.Labels != null && input.Labels != null && !this.Labels.SequenceEqual(input.Labels))) return false;
            if (this.CustomFields != input.CustomFields || (this.CustomFields != null && input.CustomFields != null && !this.CustomFields.SequenceEqual(input.CustomFields))) return false;
            if (this.Children != input.Children || (this.Children != null && input.Children != null && !this.Children.SequenceEqual(input.Children))) return false;
            if (this.Path != input.Path || (this.Path != null && !this.Path.Equals(input.Path))) return false;
            if (this.Ir2feature != input.Ir2feature || (this.Ir2feature != null && !this.Ir2feature.Equals(input.Ir2feature))) return false;
            if (this.NeedBreak != input.NeedBreak || (this.NeedBreak != null && !this.NeedBreak.Equals(input.NeedBreak))) return false;
            if (this.BreakStatus != input.BreakStatus || (this.BreakStatus != null && !this.BreakStatus.Equals(input.BreakStatus))) return false;
            if (this.Baseline != input.Baseline || (this.Baseline != null && !this.Baseline.Equals(input.Baseline))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.RelatedNetworkSecurity != input.RelatedNetworkSecurity || (this.RelatedNetworkSecurity != null && !this.RelatedNetworkSecurity.Equals(input.RelatedNetworkSecurity))) return false;
            if (this.Collaboratives != input.Collaboratives || (this.Collaboratives != null && !this.Collaboratives.Equals(input.Collaboratives))) return false;
            if (this.BusinessDomain != input.BusinessDomain || (this.BusinessDomain != null && !this.BusinessDomain.Equals(input.BusinessDomain))) return false;
            if (this.PlanPi != input.PlanPi || (this.PlanPi != null && !this.PlanPi.Equals(input.PlanPi))) return false;
            if (this.PlanIteration != input.PlanIteration || (this.PlanIteration != null && !this.PlanIteration.Equals(input.PlanIteration))) return false;
            if (this.ChangeStatus != input.ChangeStatus || (this.ChangeStatus != null && !this.ChangeStatus.Equals(input.ChangeStatus))) return false;
            if (this.NoBreakReason != input.NoBreakReason || (this.NoBreakReason != null && !this.NoBreakReason.Equals(input.NoBreakReason))) return false;
            if (this.SubmittedBy != input.SubmittedBy || (this.SubmittedBy != null && input.SubmittedBy != null && !this.SubmittedBy.SequenceEqual(input.SubmittedBy))) return false;
            if (this.Ir2rr != input.Ir2rr || (this.Ir2rr != null && !this.Ir2rr.Equals(input.Ir2rr))) return false;
            if (this.FeatureSet != input.FeatureSet || (this.FeatureSet != null && !this.FeatureSet.Equals(input.FeatureSet))) return false;
            if (this.ExpectedRepairDate != input.ExpectedRepairDate || (this.ExpectedRepairDate != null && !this.ExpectedRepairDate.Equals(input.ExpectedRepairDate))) return false;
            if (this.FoundPi != input.FoundPi || (this.FoundPi != null && !this.FoundPi.Equals(input.FoundPi))) return false;
            if (this.FoundIteration != input.FoundIteration || (this.FoundIteration != null && !this.FoundIteration.Equals(input.FoundIteration))) return false;
            if (this.ReasonAnalysis != input.ReasonAnalysis || (this.ReasonAnalysis != null && !this.ReasonAnalysis.Equals(input.ReasonAnalysis))) return false;
            if (this.RepairSolution != input.RepairSolution || (this.RepairSolution != null && !this.RepairSolution.Equals(input.RepairSolution))) return false;
            if (this.TestReport != input.TestReport || (this.TestReport != null && !this.TestReport.Equals(input.TestReport))) return false;
            if (this.SysNoRepairReason != input.SysNoRepairReason || (this.SysNoRepairReason != null && !this.SysNoRepairReason.Equals(input.SysNoRepairReason))) return false;
            if (this.SysActivationReason != input.SysActivationReason || (this.SysActivationReason != null && !this.SysActivationReason.Equals(input.SysActivationReason))) return false;
            if (this.SysReturnReason != input.SysReturnReason || (this.SysReturnReason != null && !this.SysReturnReason.Equals(input.SysReturnReason))) return false;
            if (this.TestFailuresTimes != input.TestFailuresTimes || (this.TestFailuresTimes != null && !this.TestFailuresTimes.Equals(input.TestFailuresTimes))) return false;
            if (this.CloseType != input.CloseType || (this.CloseType != null && !this.CloseType.Equals(input.CloseType))) return false;
            if (this.PlanOwner != input.PlanOwner || (this.PlanOwner != null && !this.PlanOwner.Equals(input.PlanOwner))) return false;
            if (this.DoingOwner != input.DoingOwner || (this.DoingOwner != null && !this.DoingOwner.Equals(input.DoingOwner))) return false;
            if (this.DeliveredOwner != input.DeliveredOwner || (this.DeliveredOwner != null && !this.DeliveredOwner.Equals(input.DeliveredOwner))) return false;
            if (this.CheckingOwner != input.CheckingOwner || (this.CheckingOwner != null && !this.CheckingOwner.Equals(input.CheckingOwner))) return false;
            if (this.TestOwner != input.TestOwner || (this.TestOwner != null && !this.TestOwner.Equals(input.TestOwner))) return false;
            if (this.DevelopOwner != input.DevelopOwner || (this.DevelopOwner != null && !this.DevelopOwner.Equals(input.DevelopOwner))) return false;
            if (this.ProcessingOwner != input.ProcessingOwner || (this.ProcessingOwner != null && !this.ProcessingOwner.Equals(input.ProcessingOwner))) return false;
            if (this.FixedOwner != input.FixedOwner || (this.FixedOwner != null && !this.FixedOwner.Equals(input.FixedOwner))) return false;
            if (this.ResearchanddevelopOwner != input.ResearchanddevelopOwner || (this.ResearchanddevelopOwner != null && !this.ResearchanddevelopOwner.Equals(input.ResearchanddevelopOwner))) return false;
            if (this.AnalyseOwner != input.AnalyseOwner || (this.AnalyseOwner != null && !this.AnalyseOwner.Equals(input.AnalyseOwner))) return false;
            if (this.PlanStartDate != input.PlanStartDate || (this.PlanStartDate != null && !this.PlanStartDate.Equals(input.PlanStartDate))) return false;
            if (this.ExpectDeliveryTime != input.ExpectDeliveryTime || (this.ExpectDeliveryTime != null && !this.ExpectDeliveryTime.Equals(input.ExpectDeliveryTime))) return false;
            if (this.PlanTestEndDate != input.PlanTestEndDate || (this.PlanTestEndDate != null && !this.PlanTestEndDate.Equals(input.PlanTestEndDate))) return false;
            if (this.Severity != input.Severity || (this.Severity != null && !this.Severity.Equals(input.Severity))) return false;
            if (this.Promised != input.Promised || (this.Promised != null && !this.Promised.Equals(input.Promised))) return false;
            if (this.Recipient != input.Recipient || (this.Recipient != null && input.Recipient != null && !this.Recipient.SequenceEqual(input.Recipient))) return false;
            if (this.SysNoDevelopReason != input.SysNoDevelopReason || (this.SysNoDevelopReason != null && !this.SysNoDevelopReason.Equals(input.SysNoDevelopReason))) return false;
            if (this.ValFeature != input.ValFeature || (this.ValFeature != null && !this.ValFeature.Equals(input.ValFeature))) return false;
            if (this.FunctionScene != input.FunctionScene || (this.FunctionScene != null && !this.FunctionScene.Equals(input.FunctionScene))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.CategoryLayerId != null) hashCode = hashCode * 59 + this.CategoryLayerId.GetHashCode();
                if (this.ParentId != null) hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Assignee != null) hashCode = hashCode * 59 + this.Assignee.GetHashCode();
                if (this.AssignedCc != null) hashCode = hashCode * 59 + this.AssignedCc.GetHashCode();
                if (this.CreatedBy != null) hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedTime != null) hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.ModifiedBy != null) hashCode = hashCode * 59 + this.ModifiedBy.GetHashCode();
                if (this.ModifiedTime != null) hashCode = hashCode * 59 + this.ModifiedTime.GetHashCode();
                if (this.PlanEndDate != null) hashCode = hashCode * 59 + this.PlanEndDate.GetHashCode();
                if (this.CloseTime != null) hashCode = hashCode * 59 + this.CloseTime.GetHashCode();
                if (this.Workload != null) hashCode = hashCode * 59 + this.Workload.GetHashCode();
                if (this.WorkloadSum != null) hashCode = hashCode * 59 + this.WorkloadSum.GetHashCode();
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.Link != null) hashCode = hashCode * 59 + this.Link.GetHashCode();
                if (this.Suspended != null) hashCode = hashCode * 59 + this.Suspended.GetHashCode();
                if (this.StatusModifiedTime != null) hashCode = hashCode * 59 + this.StatusModifiedTime.GetHashCode();
                if (this.Labels != null) hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.CustomFields != null) hashCode = hashCode * 59 + this.CustomFields.GetHashCode();
                if (this.Children != null) hashCode = hashCode * 59 + this.Children.GetHashCode();
                if (this.Path != null) hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Ir2feature != null) hashCode = hashCode * 59 + this.Ir2feature.GetHashCode();
                if (this.NeedBreak != null) hashCode = hashCode * 59 + this.NeedBreak.GetHashCode();
                if (this.BreakStatus != null) hashCode = hashCode * 59 + this.BreakStatus.GetHashCode();
                if (this.Baseline != null) hashCode = hashCode * 59 + this.Baseline.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.RelatedNetworkSecurity != null) hashCode = hashCode * 59 + this.RelatedNetworkSecurity.GetHashCode();
                if (this.Collaboratives != null) hashCode = hashCode * 59 + this.Collaboratives.GetHashCode();
                if (this.BusinessDomain != null) hashCode = hashCode * 59 + this.BusinessDomain.GetHashCode();
                if (this.PlanPi != null) hashCode = hashCode * 59 + this.PlanPi.GetHashCode();
                if (this.PlanIteration != null) hashCode = hashCode * 59 + this.PlanIteration.GetHashCode();
                if (this.ChangeStatus != null) hashCode = hashCode * 59 + this.ChangeStatus.GetHashCode();
                if (this.NoBreakReason != null) hashCode = hashCode * 59 + this.NoBreakReason.GetHashCode();
                if (this.SubmittedBy != null) hashCode = hashCode * 59 + this.SubmittedBy.GetHashCode();
                if (this.Ir2rr != null) hashCode = hashCode * 59 + this.Ir2rr.GetHashCode();
                if (this.FeatureSet != null) hashCode = hashCode * 59 + this.FeatureSet.GetHashCode();
                if (this.ExpectedRepairDate != null) hashCode = hashCode * 59 + this.ExpectedRepairDate.GetHashCode();
                if (this.FoundPi != null) hashCode = hashCode * 59 + this.FoundPi.GetHashCode();
                if (this.FoundIteration != null) hashCode = hashCode * 59 + this.FoundIteration.GetHashCode();
                if (this.ReasonAnalysis != null) hashCode = hashCode * 59 + this.ReasonAnalysis.GetHashCode();
                if (this.RepairSolution != null) hashCode = hashCode * 59 + this.RepairSolution.GetHashCode();
                if (this.TestReport != null) hashCode = hashCode * 59 + this.TestReport.GetHashCode();
                if (this.SysNoRepairReason != null) hashCode = hashCode * 59 + this.SysNoRepairReason.GetHashCode();
                if (this.SysActivationReason != null) hashCode = hashCode * 59 + this.SysActivationReason.GetHashCode();
                if (this.SysReturnReason != null) hashCode = hashCode * 59 + this.SysReturnReason.GetHashCode();
                if (this.TestFailuresTimes != null) hashCode = hashCode * 59 + this.TestFailuresTimes.GetHashCode();
                if (this.CloseType != null) hashCode = hashCode * 59 + this.CloseType.GetHashCode();
                if (this.PlanOwner != null) hashCode = hashCode * 59 + this.PlanOwner.GetHashCode();
                if (this.DoingOwner != null) hashCode = hashCode * 59 + this.DoingOwner.GetHashCode();
                if (this.DeliveredOwner != null) hashCode = hashCode * 59 + this.DeliveredOwner.GetHashCode();
                if (this.CheckingOwner != null) hashCode = hashCode * 59 + this.CheckingOwner.GetHashCode();
                if (this.TestOwner != null) hashCode = hashCode * 59 + this.TestOwner.GetHashCode();
                if (this.DevelopOwner != null) hashCode = hashCode * 59 + this.DevelopOwner.GetHashCode();
                if (this.ProcessingOwner != null) hashCode = hashCode * 59 + this.ProcessingOwner.GetHashCode();
                if (this.FixedOwner != null) hashCode = hashCode * 59 + this.FixedOwner.GetHashCode();
                if (this.ResearchanddevelopOwner != null) hashCode = hashCode * 59 + this.ResearchanddevelopOwner.GetHashCode();
                if (this.AnalyseOwner != null) hashCode = hashCode * 59 + this.AnalyseOwner.GetHashCode();
                if (this.PlanStartDate != null) hashCode = hashCode * 59 + this.PlanStartDate.GetHashCode();
                if (this.ExpectDeliveryTime != null) hashCode = hashCode * 59 + this.ExpectDeliveryTime.GetHashCode();
                if (this.PlanTestEndDate != null) hashCode = hashCode * 59 + this.PlanTestEndDate.GetHashCode();
                if (this.Severity != null) hashCode = hashCode * 59 + this.Severity.GetHashCode();
                if (this.Promised != null) hashCode = hashCode * 59 + this.Promised.GetHashCode();
                if (this.Recipient != null) hashCode = hashCode * 59 + this.Recipient.GetHashCode();
                if (this.SysNoDevelopReason != null) hashCode = hashCode * 59 + this.SysNoDevelopReason.GetHashCode();
                if (this.ValFeature != null) hashCode = hashCode * 59 + this.ValFeature.GetHashCode();
                if (this.FunctionScene != null) hashCode = hashCode * 59 + this.FunctionScene.GetHashCode();
                return hashCode;
            }
        }
    }
}
