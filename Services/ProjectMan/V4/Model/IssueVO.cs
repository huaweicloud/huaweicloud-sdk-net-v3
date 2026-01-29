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
    public class IssueVO 
    {

        /// <summary>
        /// **参数解释：**  分析结论，通常在接纳RR时填写。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("sys_analysis_conclusion", NullValueHandling = NullValueHandling.Ignore)]
        public string SysAnalysisConclusion { get; set; }

        /// <summary>
        /// **参数解释：**  备注。通常在提交验收RR时填写。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("sys_remark", NullValueHandling = NullValueHandling.Ignore)]
        public string SysRemark { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("promised", NullValueHandling = NullValueHandling.Ignore)]
        public OptionVO Promised { get; set; }

        /// <summary>
        /// **参数解释：**  工作项的分类。 **取值范围：**  - requirement - raw requirement - bug - task - feature
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释：**  标识工作项是否跨项目提交。 **取值范围：**  - 1：跨项目提交工作项。 - 0：非跨项目提交工作项。
        /// </summary>
        [JsonProperty("belong_inside", NullValueHandling = NullValueHandling.Ignore)]
        public string BelongInside { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("src_domain", NullValueHandling = NullValueHandling.Ignore)]
        public DomainVO SrcDomain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public DomainVO DomainId { get; set; }

        /// <summary>
        /// **参数解释：**  原始需求的协同上游需求Id。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("send_from", NullValueHandling = NullValueHandling.Ignore)]
        public string SendFrom { get; set; }

        /// <summary>
        /// **参数解释：**  工作项编号，由工作项类型+年月日+6位随机数组成。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// **参数解释：**  原始需求的协同下游需求Id。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("send_to", NullValueHandling = NullValueHandling.Ignore)]
        public string SendTo { get; set; }

        /// <summary>
        /// **参数解释：**  工作项父子挂载路径关系。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// **参数解释：**  工作项计划工时。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("workload_man_day", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkloadManDay { get; set; }

        /// <summary>
        /// **参数解释：**  验收结论。通常是验收RR时填写。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("sys_check_conclusion", NullValueHandling = NullValueHandling.Ignore)]
        public string SysCheckConclusion { get; set; }

        /// <summary>
        /// **参数解释：**  工作项唯一Id。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释：**  工作项生命周期。 **取值范围：**  - 正在工作：可正常操作的工作项； - 作废：软删除后的工作项，可在回收站恢复； - 删除：彻底删除后的工作项，无法恢复。
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// **参数解释：**  工作项在当前状态的停留天数。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("stay_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? StayDays { get; set; }

        /// <summary>
        /// **参数解释：**  抄送人。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("assigned_cc", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserVO> AssignedCc { get; set; }

        /// <summary>
        /// **参数解释：**  工作项提交时间，指工作项进入工作流的时间，而不是创建时间。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("submit_time", NullValueHandling = NullValueHandling.Ignore)]
        public string SubmitTime { get; set; }

        /// <summary>
        /// **参数解释：**  工作项标签。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("workitem2label", NullValueHandling = NullValueHandling.Ignore)]
        public List<WorkItemLabelVO> Workitem2label { get; set; }

        /// <summary>
        /// **参数解释：**  退回原因。通常为退回RR/Bug时填写。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("sys_return_conclusion", NullValueHandling = NullValueHandling.Ignore)]
        public string SysReturnConclusion { get; set; }

        /// <summary>
        /// **参数解释：**  工作项完成时间。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("close_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CloseTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public OptionVO Priority { get; set; }

        /// <summary>
        /// **参数解释：**  工作项最新修改时间。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("modified_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("created_by", NullValueHandling = NullValueHandling.Ignore)]
        public UserVO CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("break_status", NullValueHandling = NullValueHandling.Ignore)]
        public OptionVO BreakStatus { get; set; }

        /// <summary>
        /// **参数解释：**  工作项上一次流转状态的时间，可用于计算停留天数。unix时间戳，单位为毫秒。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("status_modified_date", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusModifiedDate { get; set; }

        /// <summary>
        /// **参数解释：**  期望完成时间。Unix时间戳，单位为毫秒。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("expect_delivery_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpectDeliveryTime { get; set; }

        /// <summary>
        /// **参数解释：**  工作项的父工作项Id。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("assignee", NullValueHandling = NullValueHandling.Ignore)]
        public UserVO Assignee { get; set; }

        /// <summary>
        /// **参数解释：**  工作项所属租户的域。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public AlmStatus Status { get; set; }

        /// <summary>
        /// **参数解释：**  工作项所属租户Id。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("plan_pi", NullValueHandling = NullValueHandling.Ignore)]
        public PlanVO PlanPi { get; set; }

        /// <summary>
        /// **参数解释：**  关联工作项的关系字段。多值使用英文逗号分隔。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("link", NullValueHandling = NullValueHandling.Ignore)]
        public string Link { get; set; }

        /// <summary>
        /// **参数解释：**  工作项描述，最多支持50w字符。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("is_suspended", NullValueHandling = NullValueHandling.Ignore)]
        public OptionVO IsSuspended { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("change_status", NullValueHandling = NullValueHandling.Ignore)]
        public OptionVO ChangeStatus { get; set; }

        /// <summary>
        /// **参数解释：**  工作项标题。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// **参数解释：**  工作项实际工时。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("sum_workload_man_day", NullValueHandling = NullValueHandling.Ignore)]
        public string SumWorkloadManDay { get; set; }

        /// <summary>
        /// **参数解释：**  工作项关闭原因。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("sys_close_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string SysCloseReason { get; set; }

        /// <summary>
        /// **参数解释：**  重新提交原因，通常用于RR/Bug退回后重新提交。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("sys_resubmit_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string SysResubmitReason { get; set; }

        /// <summary>
        /// **参数解释：**  工作项计划完成时间。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("plan_end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanEndDate { get; set; }

        /// <summary>
        /// **参数解释：**  RR的子IR的id。多值使用英文逗号分隔。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("rr2ir", NullValueHandling = NullValueHandling.Ignore)]
        public string Rr2ir { get; set; }

        /// <summary>
        /// **参数解释：**  工作项类型层级id。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("category_layer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryLayerId { get; set; }

        /// <summary>
        /// **参数解释：**  工作项提交人。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("submitted_by", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserVO> SubmittedBy { get; set; }

        /// <summary>
        /// **参数解释：**  RR的子US的id，多值使用英文逗号分隔。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("rr2us", NullValueHandling = NullValueHandling.Ignore)]
        public string Rr2us { get; set; }

        /// <summary>
        /// **参数解释：**  工作项无需开发原因。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("sys_no_develop_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string SysNoDevelopReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("plan_iteration", NullValueHandling = NullValueHandling.Ignore)]
        public PlanVO PlanIteration { get; set; }

        /// <summary>
        /// **参数解释：**  退回原因。通常用于RR/bug退回。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("sys_return_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string SysReturnReason { get; set; }

        /// <summary>
        /// **参数解释：**  是否级联删除标记。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("cascade_delete", NullValueHandling = NullValueHandling.Ignore)]
        public string CascadeDelete { get; set; }

        /// <summary>
        /// **参数解释：**  承接人。通常用于RR。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("recipient", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserVO> Recipient { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("modified_by", NullValueHandling = NullValueHandling.Ignore)]
        public UserVO ModifiedBy { get; set; }

        /// <summary>
        /// **参数解释：**  工作项创建时间。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("created_date", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedDate { get; set; }

        /// <summary>
        /// **参数解释：**  工作项类型。 **取值范围：**  - 系统设备类项目：RR/SF/IR/SR/AR/Task/Bug。 - 独立软件类项目：RR/SF/IR/US/Task/Bug。 - 云服务类项目：RR/Epic/FE/US/Task/Bug。
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// **参数解释：**  研发需求协同需求状态。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("collaborative_status", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CollaborativeStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("project", NullValueHandling = NullValueHandling.Ignore)]
        public DomainVO Project { get; set; }

        /// <summary>
        /// **参数解释：**  子工作项列表。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("child_issues", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, IssueVO> ChildIssues { get; set; }

        /// <summary>
        /// **参数解释：**  激活次数。Bug激活时自动赋值。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("activate_times", NullValueHandling = NullValueHandling.Ignore)]
        public int? ActivateTimes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("baseline", NullValueHandling = NullValueHandling.Ignore)]
        public OptionVO Baseline { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("business_domain", NullValueHandling = NullValueHandling.Ignore)]
        public OptionVO BusinessDomain { get; set; }

        /// <summary>
        /// **参数解释：**  子工作项Id，多值使用英文逗号分隔。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("children", NullValueHandling = NullValueHandling.Ignore)]
        public string Children { get; set; }

        /// <summary>
        /// **参数解释：**  协同需求的状态变化历史记录，内容为Json字符串。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("collaborative_history", NullValueHandling = NullValueHandling.Ignore)]
        public string CollaborativeHistory { get; set; }

        /// <summary>
        /// **参数解释：**  协同需求中的记录Id。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("collaboratives", NullValueHandling = NullValueHandling.Ignore)]
        public string Collaboratives { get; set; }

        /// <summary>
        /// **参数解释：**  卷积实际工时。父工作项中将子工作项/协同工作项的实际工时卷积得到。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("convolution_actual_hours", NullValueHandling = NullValueHandling.Ignore)]
        public string ConvolutionActualHours { get; set; }

        /// <summary>
        /// **参数解释：**  卷积计划工时。父工作项中将子工作项/协同工作项的计划工时卷积得到。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("convolution_plan_hours", NullValueHandling = NullValueHandling.Ignore)]
        public string ConvolutionPlanHours { get; set; }

        /// <summary>
        /// **参数解释：**  开发责任人。通常用于“开发”状态节点责任人。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("develop_owner", NullValueHandling = NullValueHandling.Ignore)]
        public string DevelopOwner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("done_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public OptionVO DoneRatio { get; set; }

        /// <summary>
        /// **参数解释：**  期望修复时间。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("expected_repair_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpectedRepairDate { get; set; }

        /// <summary>
        /// **参数解释：**  SF的子IR的id。多值使用英文逗号分隔。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("feature2ir", NullValueHandling = NullValueHandling.Ignore)]
        public string Feature2ir { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("feature_set", NullValueHandling = NullValueHandling.Ignore)]
        public OptionVO FeatureSet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("found_env", NullValueHandling = NullValueHandling.Ignore)]
        public OptionVO FoundEnv { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("found_iteration", NullValueHandling = NullValueHandling.Ignore)]
        public PlanVO FoundIteration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("found_pi", NullValueHandling = NullValueHandling.Ignore)]
        public PlanVO FoundPi { get; set; }

        /// <summary>
        /// **参数解释：**  功能场景。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("function_scene", NullValueHandling = NullValueHandling.Ignore)]
        public string FunctionScene { get; set; }

        /// <summary>
        /// **参数解释：**  IR关联的SF的Id，一个IR仅能关联一个SF。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("ir2feature", NullValueHandling = NullValueHandling.Ignore)]
        public string Ir2feature { get; set; }

        /// <summary>
        /// **参数解释：**  IR关联父RR的Id，多值使用英文逗号分隔。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("ir2rr", NullValueHandling = NullValueHandling.Ignore)]
        public string Ir2rr { get; set; }

        /// <summary>
        /// **参数解释：**  工作项关联的决策意见Id。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("issue_opinion_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueOpinionId { get; set; }

        /// <summary>
        /// **参数解释：**  工作项关联的评审意见Id。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("issue_review_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueReviewId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("module", NullValueHandling = NullValueHandling.Ignore)]
        public OptionVO Module { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("need_break", NullValueHandling = NullValueHandling.Ignore)]
        public OptionVO NeedBreak { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("need_develop", NullValueHandling = NullValueHandling.Ignore)]
        public OptionVO NeedDevelop { get; set; }

        /// <summary>
        /// **参数解释：**  无需分解原因。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("no_break_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string NoBreakReason { get; set; }

        /// <summary>
        /// **参数解释：**  无需开发原因。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("no_develop_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string NoDevelopReason { get; set; }

        /// <summary>
        /// **参数解释：**  优先级顺序。 **取值范围：**  1~100。
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public string Order { get; set; }

        /// <summary>
        /// **参数解释：**  计划开发结束时间。通常用于“开发”状态节点，Unix时间戳，单位为毫秒。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("plan_dev_end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanDevEndDate { get; set; }

        /// <summary>
        /// **参数解释：**  计划处理中结束时间。通常用于“处理中”状态节点，Unix时间戳，单位为毫秒。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("plan_processing_end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanProcessingEndDate { get; set; }

        /// <summary>
        /// **参数解释：**  计划研发结束时间。通常用于“研发”状态节点，Unix时间戳，单位为毫秒。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("plan_researchanddevelop_end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanResearchanddevelopEndDate { get; set; }

        /// <summary>
        /// **参数解释：**  计划测试结束时间。通常用于“测试”状态节点，Unix时间戳，单位为毫秒。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("plan_test_end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanTestEndDate { get; set; }

        /// <summary>
        /// **参数解释：**  标识工作项在列表中初始排序位置。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("position_float", NullValueHandling = NullValueHandling.Ignore)]
        public string PositionFloat { get; set; }

        /// <summary>
        /// **参数解释：**  处理中责任人。通常用于“处理中”状态节点。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("processing_owner", NullValueHandling = NullValueHandling.Ignore)]
        public string ProcessingOwner { get; set; }

        /// <summary>
        /// **参数解释：**  分析原因。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("reason_analysis", NullValueHandling = NullValueHandling.Ignore)]
        public string ReasonAnalysis { get; set; }

        /// <summary>
        /// **参数解释：**  回归不通过次数。缺陷测试不通过时自动赋值。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("regression_failure_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? RegressionFailureNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("related_network_security", NullValueHandling = NullValueHandling.Ignore)]
        public OptionVO RelatedNetworkSecurity { get; set; }

        /// <summary>
        /// **参数解释：**  修复方案。常用于修复缺陷时。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("repair_solution", NullValueHandling = NullValueHandling.Ignore)]
        public string RepairSolution { get; set; }

        /// <summary>
        /// **参数解释：**  研发责任人。通常用于“研发”状态节点。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("researchanddevelop_owner", NullValueHandling = NullValueHandling.Ignore)]
        public string ResearchanddevelopOwner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public OptionVO Severity { get; set; }

        /// <summary>
        /// **参数解释：**  严重程度。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("sys_activation_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string SysActivationReason { get; set; }

        /// <summary>
        /// **参数解释：**  无需修复原因。通常用于在缺陷无需修复时。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("sys_no_repair_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string SysNoRepairReason { get; set; }

        /// <summary>
        /// **参数解释：**  测试不通过次数。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("test_failures_times", NullValueHandling = NullValueHandling.Ignore)]
        public int? TestFailuresTimes { get; set; }

        /// <summary>
        /// **参数解释：**  测试责任人。通常用于“测试”状态节点。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("test_owner", NullValueHandling = NullValueHandling.Ignore)]
        public string TestOwner { get; set; }

        /// <summary>
        /// **参数解释：**  测试报告。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("test_report", NullValueHandling = NullValueHandling.Ignore)]
        public string TestReport { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("val_feature", NullValueHandling = NullValueHandling.Ignore)]
        public OptionVO ValFeature { get; set; }

        /// <summary>
        /// **参数解释：**  工作项关联的甘特图Id。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("workitem2ganttchart", NullValueHandling = NullValueHandling.Ignore)]
        public string Workitem2ganttchart { get; set; }

        /// <summary>
        /// **参数解释：**  工作项关联的思维导图Id。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("workitem2mindmap", NullValueHandling = NullValueHandling.Ignore)]
        public string Workitem2mindmap { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueVO {\n");
            sb.Append("  sysAnalysisConclusion: ").Append(SysAnalysisConclusion).Append("\n");
            sb.Append("  sysRemark: ").Append(SysRemark).Append("\n");
            sb.Append("  promised: ").Append(Promised).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  belongInside: ").Append(BelongInside).Append("\n");
            sb.Append("  srcDomain: ").Append(SrcDomain).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  sendFrom: ").Append(SendFrom).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  sendTo: ").Append(SendTo).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  workloadManDay: ").Append(WorkloadManDay).Append("\n");
            sb.Append("  sysCheckConclusion: ").Append(SysCheckConclusion).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  stayDays: ").Append(StayDays).Append("\n");
            sb.Append("  assignedCc: ").Append(AssignedCc).Append("\n");
            sb.Append("  submitTime: ").Append(SubmitTime).Append("\n");
            sb.Append("  workitem2label: ").Append(Workitem2label).Append("\n");
            sb.Append("  sysReturnConclusion: ").Append(SysReturnConclusion).Append("\n");
            sb.Append("  closeTime: ").Append(CloseTime).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  modifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  createdBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  breakStatus: ").Append(BreakStatus).Append("\n");
            sb.Append("  statusModifiedDate: ").Append(StatusModifiedDate).Append("\n");
            sb.Append("  expectDeliveryTime: ").Append(ExpectDeliveryTime).Append("\n");
            sb.Append("  parentId: ").Append(ParentId).Append("\n");
            sb.Append("  assignee: ").Append(Assignee).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  planPi: ").Append(PlanPi).Append("\n");
            sb.Append("  link: ").Append(Link).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  isSuspended: ").Append(IsSuspended).Append("\n");
            sb.Append("  changeStatus: ").Append(ChangeStatus).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  sumWorkloadManDay: ").Append(SumWorkloadManDay).Append("\n");
            sb.Append("  sysCloseReason: ").Append(SysCloseReason).Append("\n");
            sb.Append("  sysResubmitReason: ").Append(SysResubmitReason).Append("\n");
            sb.Append("  planEndDate: ").Append(PlanEndDate).Append("\n");
            sb.Append("  rr2ir: ").Append(Rr2ir).Append("\n");
            sb.Append("  categoryLayerId: ").Append(CategoryLayerId).Append("\n");
            sb.Append("  submittedBy: ").Append(SubmittedBy).Append("\n");
            sb.Append("  rr2us: ").Append(Rr2us).Append("\n");
            sb.Append("  sysNoDevelopReason: ").Append(SysNoDevelopReason).Append("\n");
            sb.Append("  planIteration: ").Append(PlanIteration).Append("\n");
            sb.Append("  sysReturnReason: ").Append(SysReturnReason).Append("\n");
            sb.Append("  cascadeDelete: ").Append(CascadeDelete).Append("\n");
            sb.Append("  recipient: ").Append(Recipient).Append("\n");
            sb.Append("  modifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  createdDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  collaborativeStatus: ").Append(CollaborativeStatus).Append("\n");
            sb.Append("  project: ").Append(Project).Append("\n");
            sb.Append("  childIssues: ").Append(ChildIssues).Append("\n");
            sb.Append("  activateTimes: ").Append(ActivateTimes).Append("\n");
            sb.Append("  baseline: ").Append(Baseline).Append("\n");
            sb.Append("  businessDomain: ").Append(BusinessDomain).Append("\n");
            sb.Append("  children: ").Append(Children).Append("\n");
            sb.Append("  collaborativeHistory: ").Append(CollaborativeHistory).Append("\n");
            sb.Append("  collaboratives: ").Append(Collaboratives).Append("\n");
            sb.Append("  convolutionActualHours: ").Append(ConvolutionActualHours).Append("\n");
            sb.Append("  convolutionPlanHours: ").Append(ConvolutionPlanHours).Append("\n");
            sb.Append("  developOwner: ").Append(DevelopOwner).Append("\n");
            sb.Append("  doneRatio: ").Append(DoneRatio).Append("\n");
            sb.Append("  expectedRepairDate: ").Append(ExpectedRepairDate).Append("\n");
            sb.Append("  feature2ir: ").Append(Feature2ir).Append("\n");
            sb.Append("  featureSet: ").Append(FeatureSet).Append("\n");
            sb.Append("  foundEnv: ").Append(FoundEnv).Append("\n");
            sb.Append("  foundIteration: ").Append(FoundIteration).Append("\n");
            sb.Append("  foundPi: ").Append(FoundPi).Append("\n");
            sb.Append("  functionScene: ").Append(FunctionScene).Append("\n");
            sb.Append("  ir2feature: ").Append(Ir2feature).Append("\n");
            sb.Append("  ir2rr: ").Append(Ir2rr).Append("\n");
            sb.Append("  issueOpinionId: ").Append(IssueOpinionId).Append("\n");
            sb.Append("  issueReviewId: ").Append(IssueReviewId).Append("\n");
            sb.Append("  module: ").Append(Module).Append("\n");
            sb.Append("  needBreak: ").Append(NeedBreak).Append("\n");
            sb.Append("  needDevelop: ").Append(NeedDevelop).Append("\n");
            sb.Append("  noBreakReason: ").Append(NoBreakReason).Append("\n");
            sb.Append("  noDevelopReason: ").Append(NoDevelopReason).Append("\n");
            sb.Append("  order: ").Append(Order).Append("\n");
            sb.Append("  planDevEndDate: ").Append(PlanDevEndDate).Append("\n");
            sb.Append("  planProcessingEndDate: ").Append(PlanProcessingEndDate).Append("\n");
            sb.Append("  planResearchanddevelopEndDate: ").Append(PlanResearchanddevelopEndDate).Append("\n");
            sb.Append("  planTestEndDate: ").Append(PlanTestEndDate).Append("\n");
            sb.Append("  positionFloat: ").Append(PositionFloat).Append("\n");
            sb.Append("  processingOwner: ").Append(ProcessingOwner).Append("\n");
            sb.Append("  reasonAnalysis: ").Append(ReasonAnalysis).Append("\n");
            sb.Append("  regressionFailureNumber: ").Append(RegressionFailureNumber).Append("\n");
            sb.Append("  relatedNetworkSecurity: ").Append(RelatedNetworkSecurity).Append("\n");
            sb.Append("  repairSolution: ").Append(RepairSolution).Append("\n");
            sb.Append("  researchanddevelopOwner: ").Append(ResearchanddevelopOwner).Append("\n");
            sb.Append("  severity: ").Append(Severity).Append("\n");
            sb.Append("  sysActivationReason: ").Append(SysActivationReason).Append("\n");
            sb.Append("  sysNoRepairReason: ").Append(SysNoRepairReason).Append("\n");
            sb.Append("  testFailuresTimes: ").Append(TestFailuresTimes).Append("\n");
            sb.Append("  testOwner: ").Append(TestOwner).Append("\n");
            sb.Append("  testReport: ").Append(TestReport).Append("\n");
            sb.Append("  valFeature: ").Append(ValFeature).Append("\n");
            sb.Append("  workitem2ganttchart: ").Append(Workitem2ganttchart).Append("\n");
            sb.Append("  workitem2mindmap: ").Append(Workitem2mindmap).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IssueVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IssueVO input)
        {
            if (input == null) return false;
            if (this.SysAnalysisConclusion != input.SysAnalysisConclusion || (this.SysAnalysisConclusion != null && !this.SysAnalysisConclusion.Equals(input.SysAnalysisConclusion))) return false;
            if (this.SysRemark != input.SysRemark || (this.SysRemark != null && !this.SysRemark.Equals(input.SysRemark))) return false;
            if (this.Promised != input.Promised || (this.Promised != null && !this.Promised.Equals(input.Promised))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.BelongInside != input.BelongInside || (this.BelongInside != null && !this.BelongInside.Equals(input.BelongInside))) return false;
            if (this.SrcDomain != input.SrcDomain || (this.SrcDomain != null && !this.SrcDomain.Equals(input.SrcDomain))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.SendFrom != input.SendFrom || (this.SendFrom != null && !this.SendFrom.Equals(input.SendFrom))) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.SendTo != input.SendTo || (this.SendTo != null && !this.SendTo.Equals(input.SendTo))) return false;
            if (this.Path != input.Path || (this.Path != null && !this.Path.Equals(input.Path))) return false;
            if (this.WorkloadManDay != input.WorkloadManDay || (this.WorkloadManDay != null && !this.WorkloadManDay.Equals(input.WorkloadManDay))) return false;
            if (this.SysCheckConclusion != input.SysCheckConclusion || (this.SysCheckConclusion != null && !this.SysCheckConclusion.Equals(input.SysCheckConclusion))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.StayDays != input.StayDays || (this.StayDays != null && !this.StayDays.Equals(input.StayDays))) return false;
            if (this.AssignedCc != input.AssignedCc || (this.AssignedCc != null && input.AssignedCc != null && !this.AssignedCc.SequenceEqual(input.AssignedCc))) return false;
            if (this.SubmitTime != input.SubmitTime || (this.SubmitTime != null && !this.SubmitTime.Equals(input.SubmitTime))) return false;
            if (this.Workitem2label != input.Workitem2label || (this.Workitem2label != null && input.Workitem2label != null && !this.Workitem2label.SequenceEqual(input.Workitem2label))) return false;
            if (this.SysReturnConclusion != input.SysReturnConclusion || (this.SysReturnConclusion != null && !this.SysReturnConclusion.Equals(input.SysReturnConclusion))) return false;
            if (this.CloseTime != input.CloseTime || (this.CloseTime != null && !this.CloseTime.Equals(input.CloseTime))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.ModifiedDate != input.ModifiedDate || (this.ModifiedDate != null && !this.ModifiedDate.Equals(input.ModifiedDate))) return false;
            if (this.CreatedBy != input.CreatedBy || (this.CreatedBy != null && !this.CreatedBy.Equals(input.CreatedBy))) return false;
            if (this.BreakStatus != input.BreakStatus || (this.BreakStatus != null && !this.BreakStatus.Equals(input.BreakStatus))) return false;
            if (this.StatusModifiedDate != input.StatusModifiedDate || (this.StatusModifiedDate != null && !this.StatusModifiedDate.Equals(input.StatusModifiedDate))) return false;
            if (this.ExpectDeliveryTime != input.ExpectDeliveryTime || (this.ExpectDeliveryTime != null && !this.ExpectDeliveryTime.Equals(input.ExpectDeliveryTime))) return false;
            if (this.ParentId != input.ParentId || (this.ParentId != null && !this.ParentId.Equals(input.ParentId))) return false;
            if (this.Assignee != input.Assignee || (this.Assignee != null && !this.Assignee.Equals(input.Assignee))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;
            if (this.PlanPi != input.PlanPi || (this.PlanPi != null && !this.PlanPi.Equals(input.PlanPi))) return false;
            if (this.Link != input.Link || (this.Link != null && !this.Link.Equals(input.Link))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.IsSuspended != input.IsSuspended || (this.IsSuspended != null && !this.IsSuspended.Equals(input.IsSuspended))) return false;
            if (this.ChangeStatus != input.ChangeStatus || (this.ChangeStatus != null && !this.ChangeStatus.Equals(input.ChangeStatus))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.SumWorkloadManDay != input.SumWorkloadManDay || (this.SumWorkloadManDay != null && !this.SumWorkloadManDay.Equals(input.SumWorkloadManDay))) return false;
            if (this.SysCloseReason != input.SysCloseReason || (this.SysCloseReason != null && !this.SysCloseReason.Equals(input.SysCloseReason))) return false;
            if (this.SysResubmitReason != input.SysResubmitReason || (this.SysResubmitReason != null && !this.SysResubmitReason.Equals(input.SysResubmitReason))) return false;
            if (this.PlanEndDate != input.PlanEndDate || (this.PlanEndDate != null && !this.PlanEndDate.Equals(input.PlanEndDate))) return false;
            if (this.Rr2ir != input.Rr2ir || (this.Rr2ir != null && !this.Rr2ir.Equals(input.Rr2ir))) return false;
            if (this.CategoryLayerId != input.CategoryLayerId || (this.CategoryLayerId != null && !this.CategoryLayerId.Equals(input.CategoryLayerId))) return false;
            if (this.SubmittedBy != input.SubmittedBy || (this.SubmittedBy != null && input.SubmittedBy != null && !this.SubmittedBy.SequenceEqual(input.SubmittedBy))) return false;
            if (this.Rr2us != input.Rr2us || (this.Rr2us != null && !this.Rr2us.Equals(input.Rr2us))) return false;
            if (this.SysNoDevelopReason != input.SysNoDevelopReason || (this.SysNoDevelopReason != null && !this.SysNoDevelopReason.Equals(input.SysNoDevelopReason))) return false;
            if (this.PlanIteration != input.PlanIteration || (this.PlanIteration != null && !this.PlanIteration.Equals(input.PlanIteration))) return false;
            if (this.SysReturnReason != input.SysReturnReason || (this.SysReturnReason != null && !this.SysReturnReason.Equals(input.SysReturnReason))) return false;
            if (this.CascadeDelete != input.CascadeDelete || (this.CascadeDelete != null && !this.CascadeDelete.Equals(input.CascadeDelete))) return false;
            if (this.Recipient != input.Recipient || (this.Recipient != null && input.Recipient != null && !this.Recipient.SequenceEqual(input.Recipient))) return false;
            if (this.ModifiedBy != input.ModifiedBy || (this.ModifiedBy != null && !this.ModifiedBy.Equals(input.ModifiedBy))) return false;
            if (this.CreatedDate != input.CreatedDate || (this.CreatedDate != null && !this.CreatedDate.Equals(input.CreatedDate))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.CollaborativeStatus != input.CollaborativeStatus || (this.CollaborativeStatus != null && input.CollaborativeStatus != null && !this.CollaborativeStatus.SequenceEqual(input.CollaborativeStatus))) return false;
            if (this.Project != input.Project || (this.Project != null && !this.Project.Equals(input.Project))) return false;
            if (this.ChildIssues != input.ChildIssues || (this.ChildIssues != null && input.ChildIssues != null && !this.ChildIssues.SequenceEqual(input.ChildIssues))) return false;
            if (this.ActivateTimes != input.ActivateTimes || (this.ActivateTimes != null && !this.ActivateTimes.Equals(input.ActivateTimes))) return false;
            if (this.Baseline != input.Baseline || (this.Baseline != null && !this.Baseline.Equals(input.Baseline))) return false;
            if (this.BusinessDomain != input.BusinessDomain || (this.BusinessDomain != null && !this.BusinessDomain.Equals(input.BusinessDomain))) return false;
            if (this.Children != input.Children || (this.Children != null && !this.Children.Equals(input.Children))) return false;
            if (this.CollaborativeHistory != input.CollaborativeHistory || (this.CollaborativeHistory != null && !this.CollaborativeHistory.Equals(input.CollaborativeHistory))) return false;
            if (this.Collaboratives != input.Collaboratives || (this.Collaboratives != null && !this.Collaboratives.Equals(input.Collaboratives))) return false;
            if (this.ConvolutionActualHours != input.ConvolutionActualHours || (this.ConvolutionActualHours != null && !this.ConvolutionActualHours.Equals(input.ConvolutionActualHours))) return false;
            if (this.ConvolutionPlanHours != input.ConvolutionPlanHours || (this.ConvolutionPlanHours != null && !this.ConvolutionPlanHours.Equals(input.ConvolutionPlanHours))) return false;
            if (this.DevelopOwner != input.DevelopOwner || (this.DevelopOwner != null && !this.DevelopOwner.Equals(input.DevelopOwner))) return false;
            if (this.DoneRatio != input.DoneRatio || (this.DoneRatio != null && !this.DoneRatio.Equals(input.DoneRatio))) return false;
            if (this.ExpectedRepairDate != input.ExpectedRepairDate || (this.ExpectedRepairDate != null && !this.ExpectedRepairDate.Equals(input.ExpectedRepairDate))) return false;
            if (this.Feature2ir != input.Feature2ir || (this.Feature2ir != null && !this.Feature2ir.Equals(input.Feature2ir))) return false;
            if (this.FeatureSet != input.FeatureSet || (this.FeatureSet != null && !this.FeatureSet.Equals(input.FeatureSet))) return false;
            if (this.FoundEnv != input.FoundEnv || (this.FoundEnv != null && !this.FoundEnv.Equals(input.FoundEnv))) return false;
            if (this.FoundIteration != input.FoundIteration || (this.FoundIteration != null && !this.FoundIteration.Equals(input.FoundIteration))) return false;
            if (this.FoundPi != input.FoundPi || (this.FoundPi != null && !this.FoundPi.Equals(input.FoundPi))) return false;
            if (this.FunctionScene != input.FunctionScene || (this.FunctionScene != null && !this.FunctionScene.Equals(input.FunctionScene))) return false;
            if (this.Ir2feature != input.Ir2feature || (this.Ir2feature != null && !this.Ir2feature.Equals(input.Ir2feature))) return false;
            if (this.Ir2rr != input.Ir2rr || (this.Ir2rr != null && !this.Ir2rr.Equals(input.Ir2rr))) return false;
            if (this.IssueOpinionId != input.IssueOpinionId || (this.IssueOpinionId != null && !this.IssueOpinionId.Equals(input.IssueOpinionId))) return false;
            if (this.IssueReviewId != input.IssueReviewId || (this.IssueReviewId != null && !this.IssueReviewId.Equals(input.IssueReviewId))) return false;
            if (this.Module != input.Module || (this.Module != null && !this.Module.Equals(input.Module))) return false;
            if (this.NeedBreak != input.NeedBreak || (this.NeedBreak != null && !this.NeedBreak.Equals(input.NeedBreak))) return false;
            if (this.NeedDevelop != input.NeedDevelop || (this.NeedDevelop != null && !this.NeedDevelop.Equals(input.NeedDevelop))) return false;
            if (this.NoBreakReason != input.NoBreakReason || (this.NoBreakReason != null && !this.NoBreakReason.Equals(input.NoBreakReason))) return false;
            if (this.NoDevelopReason != input.NoDevelopReason || (this.NoDevelopReason != null && !this.NoDevelopReason.Equals(input.NoDevelopReason))) return false;
            if (this.Order != input.Order || (this.Order != null && !this.Order.Equals(input.Order))) return false;
            if (this.PlanDevEndDate != input.PlanDevEndDate || (this.PlanDevEndDate != null && !this.PlanDevEndDate.Equals(input.PlanDevEndDate))) return false;
            if (this.PlanProcessingEndDate != input.PlanProcessingEndDate || (this.PlanProcessingEndDate != null && !this.PlanProcessingEndDate.Equals(input.PlanProcessingEndDate))) return false;
            if (this.PlanResearchanddevelopEndDate != input.PlanResearchanddevelopEndDate || (this.PlanResearchanddevelopEndDate != null && !this.PlanResearchanddevelopEndDate.Equals(input.PlanResearchanddevelopEndDate))) return false;
            if (this.PlanTestEndDate != input.PlanTestEndDate || (this.PlanTestEndDate != null && !this.PlanTestEndDate.Equals(input.PlanTestEndDate))) return false;
            if (this.PositionFloat != input.PositionFloat || (this.PositionFloat != null && !this.PositionFloat.Equals(input.PositionFloat))) return false;
            if (this.ProcessingOwner != input.ProcessingOwner || (this.ProcessingOwner != null && !this.ProcessingOwner.Equals(input.ProcessingOwner))) return false;
            if (this.ReasonAnalysis != input.ReasonAnalysis || (this.ReasonAnalysis != null && !this.ReasonAnalysis.Equals(input.ReasonAnalysis))) return false;
            if (this.RegressionFailureNumber != input.RegressionFailureNumber || (this.RegressionFailureNumber != null && !this.RegressionFailureNumber.Equals(input.RegressionFailureNumber))) return false;
            if (this.RelatedNetworkSecurity != input.RelatedNetworkSecurity || (this.RelatedNetworkSecurity != null && !this.RelatedNetworkSecurity.Equals(input.RelatedNetworkSecurity))) return false;
            if (this.RepairSolution != input.RepairSolution || (this.RepairSolution != null && !this.RepairSolution.Equals(input.RepairSolution))) return false;
            if (this.ResearchanddevelopOwner != input.ResearchanddevelopOwner || (this.ResearchanddevelopOwner != null && !this.ResearchanddevelopOwner.Equals(input.ResearchanddevelopOwner))) return false;
            if (this.Severity != input.Severity || (this.Severity != null && !this.Severity.Equals(input.Severity))) return false;
            if (this.SysActivationReason != input.SysActivationReason || (this.SysActivationReason != null && !this.SysActivationReason.Equals(input.SysActivationReason))) return false;
            if (this.SysNoRepairReason != input.SysNoRepairReason || (this.SysNoRepairReason != null && !this.SysNoRepairReason.Equals(input.SysNoRepairReason))) return false;
            if (this.TestFailuresTimes != input.TestFailuresTimes || (this.TestFailuresTimes != null && !this.TestFailuresTimes.Equals(input.TestFailuresTimes))) return false;
            if (this.TestOwner != input.TestOwner || (this.TestOwner != null && !this.TestOwner.Equals(input.TestOwner))) return false;
            if (this.TestReport != input.TestReport || (this.TestReport != null && !this.TestReport.Equals(input.TestReport))) return false;
            if (this.ValFeature != input.ValFeature || (this.ValFeature != null && !this.ValFeature.Equals(input.ValFeature))) return false;
            if (this.Workitem2ganttchart != input.Workitem2ganttchart || (this.Workitem2ganttchart != null && !this.Workitem2ganttchart.Equals(input.Workitem2ganttchart))) return false;
            if (this.Workitem2mindmap != input.Workitem2mindmap || (this.Workitem2mindmap != null && !this.Workitem2mindmap.Equals(input.Workitem2mindmap))) return false;

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
                if (this.SysAnalysisConclusion != null) hashCode = hashCode * 59 + this.SysAnalysisConclusion.GetHashCode();
                if (this.SysRemark != null) hashCode = hashCode * 59 + this.SysRemark.GetHashCode();
                if (this.Promised != null) hashCode = hashCode * 59 + this.Promised.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.BelongInside != null) hashCode = hashCode * 59 + this.BelongInside.GetHashCode();
                if (this.SrcDomain != null) hashCode = hashCode * 59 + this.SrcDomain.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.SendFrom != null) hashCode = hashCode * 59 + this.SendFrom.GetHashCode();
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.SendTo != null) hashCode = hashCode * 59 + this.SendTo.GetHashCode();
                if (this.Path != null) hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.WorkloadManDay != null) hashCode = hashCode * 59 + this.WorkloadManDay.GetHashCode();
                if (this.SysCheckConclusion != null) hashCode = hashCode * 59 + this.SysCheckConclusion.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.StayDays != null) hashCode = hashCode * 59 + this.StayDays.GetHashCode();
                if (this.AssignedCc != null) hashCode = hashCode * 59 + this.AssignedCc.GetHashCode();
                if (this.SubmitTime != null) hashCode = hashCode * 59 + this.SubmitTime.GetHashCode();
                if (this.Workitem2label != null) hashCode = hashCode * 59 + this.Workitem2label.GetHashCode();
                if (this.SysReturnConclusion != null) hashCode = hashCode * 59 + this.SysReturnConclusion.GetHashCode();
                if (this.CloseTime != null) hashCode = hashCode * 59 + this.CloseTime.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.ModifiedDate != null) hashCode = hashCode * 59 + this.ModifiedDate.GetHashCode();
                if (this.CreatedBy != null) hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.BreakStatus != null) hashCode = hashCode * 59 + this.BreakStatus.GetHashCode();
                if (this.StatusModifiedDate != null) hashCode = hashCode * 59 + this.StatusModifiedDate.GetHashCode();
                if (this.ExpectDeliveryTime != null) hashCode = hashCode * 59 + this.ExpectDeliveryTime.GetHashCode();
                if (this.ParentId != null) hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.Assignee != null) hashCode = hashCode * 59 + this.Assignee.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.PlanPi != null) hashCode = hashCode * 59 + this.PlanPi.GetHashCode();
                if (this.Link != null) hashCode = hashCode * 59 + this.Link.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IsSuspended != null) hashCode = hashCode * 59 + this.IsSuspended.GetHashCode();
                if (this.ChangeStatus != null) hashCode = hashCode * 59 + this.ChangeStatus.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.SumWorkloadManDay != null) hashCode = hashCode * 59 + this.SumWorkloadManDay.GetHashCode();
                if (this.SysCloseReason != null) hashCode = hashCode * 59 + this.SysCloseReason.GetHashCode();
                if (this.SysResubmitReason != null) hashCode = hashCode * 59 + this.SysResubmitReason.GetHashCode();
                if (this.PlanEndDate != null) hashCode = hashCode * 59 + this.PlanEndDate.GetHashCode();
                if (this.Rr2ir != null) hashCode = hashCode * 59 + this.Rr2ir.GetHashCode();
                if (this.CategoryLayerId != null) hashCode = hashCode * 59 + this.CategoryLayerId.GetHashCode();
                if (this.SubmittedBy != null) hashCode = hashCode * 59 + this.SubmittedBy.GetHashCode();
                if (this.Rr2us != null) hashCode = hashCode * 59 + this.Rr2us.GetHashCode();
                if (this.SysNoDevelopReason != null) hashCode = hashCode * 59 + this.SysNoDevelopReason.GetHashCode();
                if (this.PlanIteration != null) hashCode = hashCode * 59 + this.PlanIteration.GetHashCode();
                if (this.SysReturnReason != null) hashCode = hashCode * 59 + this.SysReturnReason.GetHashCode();
                if (this.CascadeDelete != null) hashCode = hashCode * 59 + this.CascadeDelete.GetHashCode();
                if (this.Recipient != null) hashCode = hashCode * 59 + this.Recipient.GetHashCode();
                if (this.ModifiedBy != null) hashCode = hashCode * 59 + this.ModifiedBy.GetHashCode();
                if (this.CreatedDate != null) hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.CollaborativeStatus != null) hashCode = hashCode * 59 + this.CollaborativeStatus.GetHashCode();
                if (this.Project != null) hashCode = hashCode * 59 + this.Project.GetHashCode();
                if (this.ChildIssues != null) hashCode = hashCode * 59 + this.ChildIssues.GetHashCode();
                if (this.ActivateTimes != null) hashCode = hashCode * 59 + this.ActivateTimes.GetHashCode();
                if (this.Baseline != null) hashCode = hashCode * 59 + this.Baseline.GetHashCode();
                if (this.BusinessDomain != null) hashCode = hashCode * 59 + this.BusinessDomain.GetHashCode();
                if (this.Children != null) hashCode = hashCode * 59 + this.Children.GetHashCode();
                if (this.CollaborativeHistory != null) hashCode = hashCode * 59 + this.CollaborativeHistory.GetHashCode();
                if (this.Collaboratives != null) hashCode = hashCode * 59 + this.Collaboratives.GetHashCode();
                if (this.ConvolutionActualHours != null) hashCode = hashCode * 59 + this.ConvolutionActualHours.GetHashCode();
                if (this.ConvolutionPlanHours != null) hashCode = hashCode * 59 + this.ConvolutionPlanHours.GetHashCode();
                if (this.DevelopOwner != null) hashCode = hashCode * 59 + this.DevelopOwner.GetHashCode();
                if (this.DoneRatio != null) hashCode = hashCode * 59 + this.DoneRatio.GetHashCode();
                if (this.ExpectedRepairDate != null) hashCode = hashCode * 59 + this.ExpectedRepairDate.GetHashCode();
                if (this.Feature2ir != null) hashCode = hashCode * 59 + this.Feature2ir.GetHashCode();
                if (this.FeatureSet != null) hashCode = hashCode * 59 + this.FeatureSet.GetHashCode();
                if (this.FoundEnv != null) hashCode = hashCode * 59 + this.FoundEnv.GetHashCode();
                if (this.FoundIteration != null) hashCode = hashCode * 59 + this.FoundIteration.GetHashCode();
                if (this.FoundPi != null) hashCode = hashCode * 59 + this.FoundPi.GetHashCode();
                if (this.FunctionScene != null) hashCode = hashCode * 59 + this.FunctionScene.GetHashCode();
                if (this.Ir2feature != null) hashCode = hashCode * 59 + this.Ir2feature.GetHashCode();
                if (this.Ir2rr != null) hashCode = hashCode * 59 + this.Ir2rr.GetHashCode();
                if (this.IssueOpinionId != null) hashCode = hashCode * 59 + this.IssueOpinionId.GetHashCode();
                if (this.IssueReviewId != null) hashCode = hashCode * 59 + this.IssueReviewId.GetHashCode();
                if (this.Module != null) hashCode = hashCode * 59 + this.Module.GetHashCode();
                if (this.NeedBreak != null) hashCode = hashCode * 59 + this.NeedBreak.GetHashCode();
                if (this.NeedDevelop != null) hashCode = hashCode * 59 + this.NeedDevelop.GetHashCode();
                if (this.NoBreakReason != null) hashCode = hashCode * 59 + this.NoBreakReason.GetHashCode();
                if (this.NoDevelopReason != null) hashCode = hashCode * 59 + this.NoDevelopReason.GetHashCode();
                if (this.Order != null) hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.PlanDevEndDate != null) hashCode = hashCode * 59 + this.PlanDevEndDate.GetHashCode();
                if (this.PlanProcessingEndDate != null) hashCode = hashCode * 59 + this.PlanProcessingEndDate.GetHashCode();
                if (this.PlanResearchanddevelopEndDate != null) hashCode = hashCode * 59 + this.PlanResearchanddevelopEndDate.GetHashCode();
                if (this.PlanTestEndDate != null) hashCode = hashCode * 59 + this.PlanTestEndDate.GetHashCode();
                if (this.PositionFloat != null) hashCode = hashCode * 59 + this.PositionFloat.GetHashCode();
                if (this.ProcessingOwner != null) hashCode = hashCode * 59 + this.ProcessingOwner.GetHashCode();
                if (this.ReasonAnalysis != null) hashCode = hashCode * 59 + this.ReasonAnalysis.GetHashCode();
                if (this.RegressionFailureNumber != null) hashCode = hashCode * 59 + this.RegressionFailureNumber.GetHashCode();
                if (this.RelatedNetworkSecurity != null) hashCode = hashCode * 59 + this.RelatedNetworkSecurity.GetHashCode();
                if (this.RepairSolution != null) hashCode = hashCode * 59 + this.RepairSolution.GetHashCode();
                if (this.ResearchanddevelopOwner != null) hashCode = hashCode * 59 + this.ResearchanddevelopOwner.GetHashCode();
                if (this.Severity != null) hashCode = hashCode * 59 + this.Severity.GetHashCode();
                if (this.SysActivationReason != null) hashCode = hashCode * 59 + this.SysActivationReason.GetHashCode();
                if (this.SysNoRepairReason != null) hashCode = hashCode * 59 + this.SysNoRepairReason.GetHashCode();
                if (this.TestFailuresTimes != null) hashCode = hashCode * 59 + this.TestFailuresTimes.GetHashCode();
                if (this.TestOwner != null) hashCode = hashCode * 59 + this.TestOwner.GetHashCode();
                if (this.TestReport != null) hashCode = hashCode * 59 + this.TestReport.GetHashCode();
                if (this.ValFeature != null) hashCode = hashCode * 59 + this.ValFeature.GetHashCode();
                if (this.Workitem2ganttchart != null) hashCode = hashCode * 59 + this.Workitem2ganttchart.GetHashCode();
                if (this.Workitem2mindmap != null) hashCode = hashCode * 59 + this.Workitem2mindmap.GetHashCode();
                return hashCode;
            }
        }
    }
}
