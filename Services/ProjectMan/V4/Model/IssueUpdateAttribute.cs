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
    /// 工作项更新对象
    /// </summary>
    public class IssueUpdateAttribute 
    {

        /// <summary>
        /// **参数解释**： 工作项类型编码。编辑工作项时，此字段必填、值为当前工作项正确的工作项类型，但不会更新此字段。 **约束限制**： 不涉及。 **取值范围**： 支持多种工作项类型，使用英文逗号分隔。 - 系统设备类项目：RR、SF、IR、SR、AR、Task、Bug - 独立软件类项目：RR、SF、IR、US、Task、Bug - 云服务类项目：RR、Epic、FE、US、Task、Bug **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// **参数解释**： 工作项描述字段，可通过[查询树状工作项](ShowIpdIssueTree.xml)接口获取，响应消息体中的**description**字段的值就是工作项描述字段。 **约束限制**： 不涉及。 **取值范围**： 1~500000个字符。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 父工作项ID，可通过[查询树状工作项](ShowIpdIssueTree.xml)接口获取，响应消息体中的**parent_id**字段的值就是父工作项ID。 **约束限制**： 不涉及。 **取值范围**： 18~19个字符的数字字符串。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentId { get; set; }

        /// <summary>
        /// **参数解释**： 工作项状态code。可通过[查询工作项状态](ListIssueStatues.xml)接口获取，响应消息体中的**code**字段的值就是工作项状态code。 **约束限制**： 不涉及。 **取值范围**： 2~32个字符。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("assignee", NullValueHandling = NullValueHandling.Ignore)]
        public UserUpdateAttribute Assignee { get; set; }

        /// <summary>
        /// **参数解释**： 工作项抄送人，支持多个抄送人。数组元素为UserUpdateAttribute对象。 **约束限制**： 同一工作项最多支持50个抄送人。
        /// </summary>
        [JsonProperty("assigned_cc", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserUpdateAttribute> AssignedCc { get; set; }

        /// <summary>
        /// **参数解释**： 工作项计划结束日期，unix时间戳，单位：毫秒。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("plan_end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanEndDate { get; set; }

        /// <summary>
        /// **参数解释**： 工作项计划工时。 **约束限制**： 保留一位小数。 **取值范围**： 0~999999999.9。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("workload", NullValueHandling = NullValueHandling.Ignore)]
        public string Workload { get; set; }

        /// <summary>
        /// **参数解释**： 工作项关联项ID。 **约束限制**： 多个关联项用英文逗号分隔，同一工作项最多支持50个关联项。 **取值范围**： 0~2048个字符。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("link", NullValueHandling = NullValueHandling.Ignore)]
        public string Link { get; set; }

        /// <summary>
        /// **参数解释**： 工作项标签。数组元素为LabelEntity对象。 **约束限制**： 不涉及。 **取值范围**： 0~50个元素，每个元素为LabelEntity对象。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public List<LabelEntity> Labels { get; set; }

        /// <summary>
        /// **参数解释**： 工作项自定义字段映射，用户添加的系统字段也在此列，格式为{\&quot;code\&quot;:\&quot;字段code\&quot;,\&quot;value\&quot;:\&quot;字段值\&quot;}。数组元素为FieldCodeValuePair对象。 **约束限制**： 不涉及。 **取值范围**： 0~200个元素，每个元素为FieldCodeValuePair对象。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("custom_fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<FieldCodeValuePair> CustomFields { get; set; }

        /// <summary>
        /// **参数解释**： IR和SF的关联字段。 **约束限制**： IR可以填写该字段。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("ir2feature", NullValueHandling = NullValueHandling.Ignore)]
        public string Ir2feature { get; set; }

        /// <summary>
        /// **参数解释**： 工作项是否需要分解。 **约束限制**： 仅可以分解的工作项类型有此字段。 **取值范围**： - yes：需要分解 - no：不需要分解 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("need_break", NullValueHandling = NullValueHandling.Ignore)]
        public string NeedBreak { get; set; }

        /// <summary>
        /// **参数解释**： 工作项基线状态。 **约束限制**： 不涉及。 **取值范围**： - null：未基线 - baselined：已基线 - baseline-reviewing：基线评审中 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("baseline", NullValueHandling = NullValueHandling.Ignore)]
        public string Baseline { get; set; }

        /// <summary>
        /// **参数解释**： 工作项优先级，部分工作项有此字段。 **约束限制**： 不涉及。 **取值范围**： - 低：低优先级。 - 中：中优先级。 - 高：高优先级。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public string Priority { get; set; }

        /// <summary>
        /// **参数解释**： 是否涉及网络安全。 **约束限制**： 预设字段中，仅研发需求类型的工作项有此字段。 **取值范围**： - yes：涉及网络安全。 - no：不涉及网络安全。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("related_network_security", NullValueHandling = NullValueHandling.Ignore)]
        public string RelatedNetworkSecurity { get; set; }

        /// <summary>
        /// **参数解释**： 领域字段。 **约束限制**： 不涉及。 **取值范围**： - software - soft-hardware - hardware - 性能 - 功能 - 运维 - 运营 - 用户体验 - 隐私保护 - 合规 - 韧性(可靠性/可用性) - 韧性(危险检测与相应恢复) - 透明 - 无害 - 安全 - API - 成本 - 可维护性 - 其他DFX - 可用性 - others **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("business_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessDomain { get; set; }

        /// <summary>
        /// **参数解释**： 工作项发布计划ID。通过[发布/迭代计划列表查询](ListPlan.xml)接口查询计划列表，返回参数中PlanVO里面的category&#x3D;PI的对象的**id**字段就是迭代计划的ID。 **约束限制**： 不涉及。 **取值范围**： 18~19个字符的数字字符串。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("plan_pi", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanPi { get; set; }

        /// <summary>
        /// **参数解释**： 工作项完成的迭代计划ID，在Bug中为修复迭代计划ID。通过[发布/迭代计划列表查询](ListPlan.xml)接口查询计划列表，返回参数中PlanVO里面的category&#x3D;Iteration的对象的**id**字段就是迭代计划的ID。 **约束限制**： 18~19个字符的数字字符串。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("plan_iteration", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanIteration { get; set; }

        /// <summary>
        /// **参数解释**： 无需分解原因。 **约束限制**： need_break字段值为“no”时有此字段。 **取值范围**： 0~512个字符。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("no_break_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string NoBreakReason { get; set; }

        /// <summary>
        /// **参数解释**： 工作项提出人。数组元素为UserUpdateAttribute对象。 **约束限制**： 不涉及。
        /// </summary>
        [JsonProperty("submitted_by", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserUpdateAttribute> SubmittedBy { get; set; }

        /// <summary>
        /// **参数解释**： IR关联的RR ID，可以通过[查询工作项列表](ListIpdProjectIssues.xml)或者[查询树状工作项](ShowIpdIssueTree.xml)接口获取，响应消息体中的**id**字段的值就是工作项ID。 **约束限制**： 多个关联项ID使用英文逗号分隔。 **取值范围**： 0~1024个字符。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("ir2rr", NullValueHandling = NullValueHandling.Ignore)]
        public string Ir2rr { get; set; }

        /// <summary>
        /// **参数解释**： 特性集ID，可以通过[查询特性集](ShowBaselineSnapshots.xml)接口获取，响应消息体中的**id**字段的值就是特性集ID。 **约束限制**： 不涉及。 **取值范围**： 18~19个字符的数字字符串。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("feature_set", NullValueHandling = NullValueHandling.Ignore)]
        public string FeatureSet { get; set; }

        /// <summary>
        /// **参数解释**： 期望修复时间。预设字段中，仅Bug有此字段，unix时间戳，单位：毫秒。 **约束限制**： 不涉及。 **取值范围**： 11~19个字符。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("expected_repair_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpectedRepairDate { get; set; }

        /// <summary>
        /// **参数解释**： 缺陷发现发布计划ID，预设字段中，仅Bug有此字段。通过[发布/迭代计划列表查询](ListPlan.xml)接口查询计划列表，返回参数中PlanVO里面的category&#x3D;PI的对象的**id**字段就是迭代计划的ID。 **约束限制**： 不涉及。 **取值范围**： 18~19个字符的数字字符串。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("found_pi", NullValueHandling = NullValueHandling.Ignore)]
        public string FoundPi { get; set; }

        /// <summary>
        /// **参数解释**： 缺陷发现迭代计划ID，预设字段中，仅Bug有此字段。通过[发布/迭代计划列表查询](ListPlan.xml)接口查询计划列表，返回参数中PlanVO里面的category&#x3D;Iteration的对象的**id**字段就是迭代计划的ID。 **约束限制**： 不涉及。 **取值范围**： 18~19个字符的数字字符串。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("found_iteration", NullValueHandling = NullValueHandling.Ignore)]
        public string FoundIteration { get; set; }

        /// <summary>
        /// **参数解释**： 分析原因。 **约束限制**： 预设字段中，仅Bug有此字段。 **取值范围**： 0~50000个字符。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("reason_analysis", NullValueHandling = NullValueHandling.Ignore)]
        public string ReasonAnalysis { get; set; }

        /// <summary>
        /// **参数解释**： 修复方案。预设字段中，仅Bug有此字段。 **约束限制**： 不涉及。 **取值范围**： 0~50000个字符。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("repair_solution", NullValueHandling = NullValueHandling.Ignore)]
        public string RepairSolution { get; set; }

        /// <summary>
        /// **参数解释**： 测试报告。预设字段中，仅Bug有此字段。 **约束限制**： 不涉及。 **取值范围**： 0~50000个字符。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("test_report", NullValueHandling = NullValueHandling.Ignore)]
        public string TestReport { get; set; }

        /// <summary>
        /// **参数解释**： 无需修复原因。预设字段中，仅Bug有此字段。 **约束限制**： 不涉及。 **取值范围**： 0~50000个字符。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("sys_no_repair_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string SysNoRepairReason { get; set; }

        /// <summary>
        /// **参数解释**： 激活原因。预设字段中，仅Bug有此字段。 **约束限制**： 不涉及。 **取值范围**： 0~50000个字符。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("sys_activation_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string SysActivationReason { get; set; }

        /// <summary>
        /// **参数解释**： 退回原因。预设字段中，仅Bug有此字段。 **约束限制**： 不涉及。 **取值范围**： 0~50000个字符。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("sys_return_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string SysReturnReason { get; set; }

        /// <summary>
        /// **参数解释**： 回归不通过次数。预设字段中，仅Bug有此字段。 **约束限制**： 不涉及。 **取值范围**： 0~999999。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("test_failures_times", NullValueHandling = NullValueHandling.Ignore)]
        public int? TestFailuresTimes { get; set; }

        /// <summary>
        /// **参数解释**： 关闭类型。 **约束限制**： 不涉及。 **取值范围**： - problem_solved：问题解决关闭 - problem_to_requirement：问题转需求关闭 - duplicate_problem：重复问题关闭 - not_a_problem：非问题关闭 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("close_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CloseType { get; set; }

        /// <summary>
        /// **参数解释**： 密级。低密级权限者不能访问高密级的工作项。可以通过[查询字段列表](ListIpdProjectFields.xml)接口获取，响应消息体中密级的**option**字段的值就是密级字段的可选值。 **约束限制**： 仅在涉密环境（SM）下存在此字段，非涉密环境下无此字段。涉密环境下必填。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("security_level", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("plan_owner", NullValueHandling = NullValueHandling.Ignore)]
        public UserUpdateAttribute PlanOwner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("doing_owner", NullValueHandling = NullValueHandling.Ignore)]
        public UserUpdateAttribute DoingOwner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("delivered_owner", NullValueHandling = NullValueHandling.Ignore)]
        public UserUpdateAttribute DeliveredOwner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("checking_owner", NullValueHandling = NullValueHandling.Ignore)]
        public UserUpdateAttribute CheckingOwner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("test_owner", NullValueHandling = NullValueHandling.Ignore)]
        public UserUpdateAttribute TestOwner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("develop_owner", NullValueHandling = NullValueHandling.Ignore)]
        public UserUpdateAttribute DevelopOwner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("processing_owner", NullValueHandling = NullValueHandling.Ignore)]
        public UserUpdateAttribute ProcessingOwner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fixed_owner", NullValueHandling = NullValueHandling.Ignore)]
        public UserUpdateAttribute FixedOwner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("researchanddevelop_owner", NullValueHandling = NullValueHandling.Ignore)]
        public UserUpdateAttribute ResearchanddevelopOwner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("analyse_owner", NullValueHandling = NullValueHandling.Ignore)]
        public UserUpdateAttribute AnalyseOwner { get; set; }

        /// <summary>
        /// **参数解释**： 计划开始时间。工作项的计划启动日期，用于项目进度管理和排期。 **约束限制**： 不涉及。 **取值范围**： 11~19个字符的时间戳字符串，单位为毫秒（ms）。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("plan_start_date", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanStartDate { get; set; }

        /// <summary>
        /// **参数解释**： 期望完成时间。工作项的预期交付日期，用于跟踪工作项是否按期完成。 **约束限制**： 不涉及。 **取值范围**： 11~19个字符的时间戳字符串，单位为毫秒（ms）。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("expect_delivery_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpectDeliveryTime { get; set; }

        /// <summary>
        /// **参数解释**： 计划测试结束时间。Bug类型工作项的计划测试完成日期，用于跟踪Bug修复后的测试进度。 **约束限制**： 仅对Bug类型工作项生效，非Bug类型忽略此字段。 **取值范围**： 11~19个字符的时间戳字符串，单位为毫秒（ms）。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("plan_test_end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanTestEndDate { get; set; }

        /// <summary>
        /// **参数解释**： 严重程度。Bug类型工作项的严重级别，用于评估Bug的影响范围和修复优先级。 **约束限制**： 仅对Bug类型工作项生效，非Bug类型忽略此字段。 **取值范围**： - 致命：系统崩溃、数据丢失等严重影响 - 严重：主要功能无法使用 - 一般：次要功能异常，有替代方案 - 提示：界面优化、建议性问题 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public string Severity { get; set; }

        /// <summary>
        /// **参数解释**： 是否承诺。RR（原始需求）类型工作项的承诺状态标识，用于标记需求是否已承诺交付。 **约束限制**： 仅对RR类型工作项生效，非RR类型忽略此字段。 **取值范围**： - yes：已承诺 - no：未承诺 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("promised", NullValueHandling = NullValueHandling.Ignore)]
        public string Promised { get; set; }

        /// <summary>
        /// **参数解释**： 承接人。RR（原始需求）类型工作项的需求承接责任人，负责需求的分析和转化。 **约束限制**： 仅对RR类型工作项生效，非RR类型忽略此字段。
        /// </summary>
        [JsonProperty("recipient", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserUpdateAttribute> Recipient { get; set; }

        /// <summary>
        /// **参数解释**： 无需研发原因。RR（原始需求）类型工作项不需要进行研发的原因说明。 **约束限制**： 仅对RR类型工作项生效，非RR类型忽略此字段。 **取值范围**： 0~50000个字符。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("sys_no_develop_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string SysNoDevelopReason { get; set; }

        /// <summary>
        /// **参数解释**： 价值特性。SF/FE类型工作项对应的业务价值特性描述，用于关联业务价值和技术实现。 **约束限制**： 仅对SF/FE类型工作项生效，其他类型忽略此字段。 **取值范围**： - yes：是 - no：否 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("val_feature", NullValueHandling = NullValueHandling.Ignore)]
        public string ValFeature { get; set; }

        /// <summary>
        /// **参数解释**： 功能场景。SF/FE类型工作项的功能应用场景描述，用于说明特性的使用场景和用户故事。 **约束限制**： 仅对SF/FE类型工作项生效，其他类型忽略此字段。 **取值范围**： 0~512个字符。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("function_scene", NullValueHandling = NullValueHandling.Ignore)]
        public string FunctionScene { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueUpdateAttribute {\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  parentId: ").Append(ParentId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  assignee: ").Append(Assignee).Append("\n");
            sb.Append("  assignedCc: ").Append(AssignedCc).Append("\n");
            sb.Append("  planEndDate: ").Append(PlanEndDate).Append("\n");
            sb.Append("  workload: ").Append(Workload).Append("\n");
            sb.Append("  link: ").Append(Link).Append("\n");
            sb.Append("  labels: ").Append(Labels).Append("\n");
            sb.Append("  customFields: ").Append(CustomFields).Append("\n");
            sb.Append("  ir2feature: ").Append(Ir2feature).Append("\n");
            sb.Append("  needBreak: ").Append(NeedBreak).Append("\n");
            sb.Append("  baseline: ").Append(Baseline).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  relatedNetworkSecurity: ").Append(RelatedNetworkSecurity).Append("\n");
            sb.Append("  businessDomain: ").Append(BusinessDomain).Append("\n");
            sb.Append("  planPi: ").Append(PlanPi).Append("\n");
            sb.Append("  planIteration: ").Append(PlanIteration).Append("\n");
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
            sb.Append("  securityLevel: ").Append(SecurityLevel).Append("\n");
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
            return this.Equals(input as IssueUpdateAttribute);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IssueUpdateAttribute input)
        {
            if (input == null) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.ParentId != input.ParentId || (this.ParentId != null && !this.ParentId.Equals(input.ParentId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Assignee != input.Assignee || (this.Assignee != null && !this.Assignee.Equals(input.Assignee))) return false;
            if (this.AssignedCc != input.AssignedCc || (this.AssignedCc != null && input.AssignedCc != null && !this.AssignedCc.SequenceEqual(input.AssignedCc))) return false;
            if (this.PlanEndDate != input.PlanEndDate || (this.PlanEndDate != null && !this.PlanEndDate.Equals(input.PlanEndDate))) return false;
            if (this.Workload != input.Workload || (this.Workload != null && !this.Workload.Equals(input.Workload))) return false;
            if (this.Link != input.Link || (this.Link != null && !this.Link.Equals(input.Link))) return false;
            if (this.Labels != input.Labels || (this.Labels != null && input.Labels != null && !this.Labels.SequenceEqual(input.Labels))) return false;
            if (this.CustomFields != input.CustomFields || (this.CustomFields != null && input.CustomFields != null && !this.CustomFields.SequenceEqual(input.CustomFields))) return false;
            if (this.Ir2feature != input.Ir2feature || (this.Ir2feature != null && !this.Ir2feature.Equals(input.Ir2feature))) return false;
            if (this.NeedBreak != input.NeedBreak || (this.NeedBreak != null && !this.NeedBreak.Equals(input.NeedBreak))) return false;
            if (this.Baseline != input.Baseline || (this.Baseline != null && !this.Baseline.Equals(input.Baseline))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.RelatedNetworkSecurity != input.RelatedNetworkSecurity || (this.RelatedNetworkSecurity != null && !this.RelatedNetworkSecurity.Equals(input.RelatedNetworkSecurity))) return false;
            if (this.BusinessDomain != input.BusinessDomain || (this.BusinessDomain != null && !this.BusinessDomain.Equals(input.BusinessDomain))) return false;
            if (this.PlanPi != input.PlanPi || (this.PlanPi != null && !this.PlanPi.Equals(input.PlanPi))) return false;
            if (this.PlanIteration != input.PlanIteration || (this.PlanIteration != null && !this.PlanIteration.Equals(input.PlanIteration))) return false;
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
            if (this.SecurityLevel != input.SecurityLevel || (this.SecurityLevel != null && !this.SecurityLevel.Equals(input.SecurityLevel))) return false;
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
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ParentId != null) hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Assignee != null) hashCode = hashCode * 59 + this.Assignee.GetHashCode();
                if (this.AssignedCc != null) hashCode = hashCode * 59 + this.AssignedCc.GetHashCode();
                if (this.PlanEndDate != null) hashCode = hashCode * 59 + this.PlanEndDate.GetHashCode();
                if (this.Workload != null) hashCode = hashCode * 59 + this.Workload.GetHashCode();
                if (this.Link != null) hashCode = hashCode * 59 + this.Link.GetHashCode();
                if (this.Labels != null) hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.CustomFields != null) hashCode = hashCode * 59 + this.CustomFields.GetHashCode();
                if (this.Ir2feature != null) hashCode = hashCode * 59 + this.Ir2feature.GetHashCode();
                if (this.NeedBreak != null) hashCode = hashCode * 59 + this.NeedBreak.GetHashCode();
                if (this.Baseline != null) hashCode = hashCode * 59 + this.Baseline.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.RelatedNetworkSecurity != null) hashCode = hashCode * 59 + this.RelatedNetworkSecurity.GetHashCode();
                if (this.BusinessDomain != null) hashCode = hashCode * 59 + this.BusinessDomain.GetHashCode();
                if (this.PlanPi != null) hashCode = hashCode * 59 + this.PlanPi.GetHashCode();
                if (this.PlanIteration != null) hashCode = hashCode * 59 + this.PlanIteration.GetHashCode();
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
                if (this.SecurityLevel != null) hashCode = hashCode * 59 + this.SecurityLevel.GetHashCode();
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
