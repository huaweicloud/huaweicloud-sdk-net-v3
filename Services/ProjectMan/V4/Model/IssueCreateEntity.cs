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
    /// 工作项创建对象
    /// </summary>
    public class IssueCreateEntity 
    {

        /// <summary>
        /// **参数解释**： 工作项标题。 **约束限制**：  不涉及。 **取值范围**： 2~256个字符。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// **参数解释**： 工作项描述字段。 **约束限制**： 不涉及。 **取值范围**： 0~500000个字符。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 工作项类型编码。编辑工作项时，此字段必填、值为当前工作项正确的工作项类型，但不会更新此字段。 **约束限制**： 不涉及。 **取值范围**： 支持多种工作项类型，使用英文逗号分隔。 - 系统设备类项目：RR、SF、IR、SR、AR、Task、Bug - 独立软件类项目：RR、SF、IR、US、Task、Bug - 云服务类项目：RR、Epic、FE、US、Task、Bug **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// **参数解释**： 工作项类型层级关系ID，此参数影响工作项的层级显示。通过[获取模型树配置信息](GetModelConfig.xml)获取，根据参数中的category在响应消息体中category_layer_config中找到对应的category_code，和category_code同级的id就是工作项类型层级关系ID。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("category_layer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryLayerId { get; set; }

        /// <summary>
        /// **参数解释**： 父工作项ID。 **约束限制**： 创建子工作项时必填，其他场景非必填。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentId { get; set; }

        /// <summary>
        /// **参数解释**： 工作项状态code。可通过[查询工作项状态](ListIssueStatues.xml)接口获取，响应消息体中的**code**字段的值就是工作项状态code。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("assignee", NullValueHandling = NullValueHandling.Ignore)]
        public UserEntity Assignee { get; set; }

        /// <summary>
        /// **参数解释**： 原始需求承接人。 **约束限制**： 当工作项类型为RR时字段必填，其他工作项类型无此字段。
        /// </summary>
        [JsonProperty("recipient", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserEntity> Recipient { get; set; }

        /// <summary>
        /// **参数解释**： 工作项抄送人，支持多个抄送人。 **约束限制**： 同一工作项最多支持50个抄送人。
        /// </summary>
        [JsonProperty("assigned_cc", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserEntity> AssignedCc { get; set; }

        /// <summary>
        /// **参数解释**： 工作项计划结束日期。 **约束限制**： 0~13个字符的数字字符串，可选负号前缀。 **取值范围**： 时间戳。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("plan_end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanEndDate { get; set; }

        /// <summary>
        /// **参数解释**： 工作项计划工时。 **约束限制**： 不涉及。 **取值范围**： 0~999999999.9中的数字字符串。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("workload", NullValueHandling = NullValueHandling.Ignore)]
        public string Workload { get; set; }

        /// <summary>
        /// **参数解释**： 工作项关联项ID。 **约束限制**： 多个关联项用英文逗号分隔，同一工作项最多支持50个关联项。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("link", NullValueHandling = NullValueHandling.Ignore)]
        public string Link { get; set; }

        /// <summary>
        /// **参数解释**： 工作项标签。 **约束限制**： 不涉及。
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public List<LabelEntity> Labels { get; set; }

        /// <summary>
        /// **参数解释**： 工作项自定义字段映射。用户添加的系统字段也在此列。 **约束限制**： 不涉及。
        /// </summary>
        [JsonProperty("custom_fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<FieldCodeValuePair> CustomFields { get; set; }

        /// <summary>
        /// **参数解释**： IR和SF的关联字段。 **约束限制**： IR可以填写该字段。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("ir2feature", NullValueHandling = NullValueHandling.Ignore)]
        public string Ir2feature { get; set; }

        /// <summary>
        /// **参数解释**： 工作项优先级。 **约束限制**： RR、SF、FE、IR、SR、AR、Task、Bug可以填写该字段。 **取值范围**： - 低：低优先级。 - 中：中优先级。 - 高：高优先级。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public string Priority { get; set; }

        /// <summary>
        /// **参数解释**： 是否涉及网络安全。 **约束限制**： 仅研发需求有此字段。 **取值范围**： - yes：涉及网络安全。 - no：不涉及网络安全。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("related_network_security", NullValueHandling = NullValueHandling.Ignore)]
        public string RelatedNetworkSecurity { get; set; }

        /// <summary>
        /// **参数解释**： 研发需求协同信息，协同任务ID，可通过[查询树状工作项](ShowIpdIssueTree.xml)接口获取，响应消息体中的**collaboratives**字段的值就是研发需求协同信息，协同任务ID。 **约束限制**： 协同任务ID。IR、SR、AR、US有此字段。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("collaboratives", NullValueHandling = NullValueHandling.Ignore)]
        public string Collaboratives { get; set; }

        /// <summary>
        /// **参数解释**： 领域字段。 **约束限制**：  FE、SF、IR、SR、AR、Bug有此字段。 **取值范围**： - software - soft-hardware - hardware - 性能 - 功能 - 运维 - 运营 - 用户体验 - 隐私保护 - 合规 - 韧性(可靠性/可用性) - 韧性(危险检测与相应恢复) - 透明 - 无害 - 安全 - API - 成本 - 可维护性 - 其他DFX - 可用性 - others **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("business_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessDomain { get; set; }

        /// <summary>
        /// **参数解释**： 工作项发布计划ID。 **约束限制**： 默认SR、AR、US、Task、Bug有此字段。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("plan_pi", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanPi { get; set; }

        /// <summary>
        /// **参数解释**： 工作项提出人。 **约束限制**： 仅RR、Bug有此字段。
        /// </summary>
        [JsonProperty("submitted_by", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserEntity> SubmittedBy { get; set; }

        /// <summary>
        /// **参数解释**： IR关联的RR的Id。 **约束限制**： 仅IR有此字段，多选时用英文逗号分隔。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("ir2rr", NullValueHandling = NullValueHandling.Ignore)]
        public string Ir2rr { get; set; }

        /// <summary>
        /// **参数解释**： 特性集ID。 **约束限制**： 仅SF/FE有此字段。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("feature_set", NullValueHandling = NullValueHandling.Ignore)]
        public string FeatureSet { get; set; }

        /// <summary>
        /// **参数解释**： 密级。低密级权限者不能访问高密级的工作项。可以通过[[查询字段列表](ListIpdProjectFields.xml)]接口获取，响应消息体中密级的**option**字段的值就是密级字段的可选值。 **约束限制**： 仅在涉密环境（SM）下存在此字段，非涉密环境下无此字段。涉密环境下必填。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("security_level", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityLevel { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueCreateEntity {\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  categoryLayerId: ").Append(CategoryLayerId).Append("\n");
            sb.Append("  parentId: ").Append(ParentId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  assignee: ").Append(Assignee).Append("\n");
            sb.Append("  recipient: ").Append(Recipient).Append("\n");
            sb.Append("  assignedCc: ").Append(AssignedCc).Append("\n");
            sb.Append("  planEndDate: ").Append(PlanEndDate).Append("\n");
            sb.Append("  workload: ").Append(Workload).Append("\n");
            sb.Append("  link: ").Append(Link).Append("\n");
            sb.Append("  labels: ").Append(Labels).Append("\n");
            sb.Append("  customFields: ").Append(CustomFields).Append("\n");
            sb.Append("  ir2feature: ").Append(Ir2feature).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  relatedNetworkSecurity: ").Append(RelatedNetworkSecurity).Append("\n");
            sb.Append("  collaboratives: ").Append(Collaboratives).Append("\n");
            sb.Append("  businessDomain: ").Append(BusinessDomain).Append("\n");
            sb.Append("  planPi: ").Append(PlanPi).Append("\n");
            sb.Append("  submittedBy: ").Append(SubmittedBy).Append("\n");
            sb.Append("  ir2rr: ").Append(Ir2rr).Append("\n");
            sb.Append("  featureSet: ").Append(FeatureSet).Append("\n");
            sb.Append("  securityLevel: ").Append(SecurityLevel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IssueCreateEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IssueCreateEntity input)
        {
            if (input == null) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.CategoryLayerId != input.CategoryLayerId || (this.CategoryLayerId != null && !this.CategoryLayerId.Equals(input.CategoryLayerId))) return false;
            if (this.ParentId != input.ParentId || (this.ParentId != null && !this.ParentId.Equals(input.ParentId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Assignee != input.Assignee || (this.Assignee != null && !this.Assignee.Equals(input.Assignee))) return false;
            if (this.Recipient != input.Recipient || (this.Recipient != null && input.Recipient != null && !this.Recipient.SequenceEqual(input.Recipient))) return false;
            if (this.AssignedCc != input.AssignedCc || (this.AssignedCc != null && input.AssignedCc != null && !this.AssignedCc.SequenceEqual(input.AssignedCc))) return false;
            if (this.PlanEndDate != input.PlanEndDate || (this.PlanEndDate != null && !this.PlanEndDate.Equals(input.PlanEndDate))) return false;
            if (this.Workload != input.Workload || (this.Workload != null && !this.Workload.Equals(input.Workload))) return false;
            if (this.Link != input.Link || (this.Link != null && !this.Link.Equals(input.Link))) return false;
            if (this.Labels != input.Labels || (this.Labels != null && input.Labels != null && !this.Labels.SequenceEqual(input.Labels))) return false;
            if (this.CustomFields != input.CustomFields || (this.CustomFields != null && input.CustomFields != null && !this.CustomFields.SequenceEqual(input.CustomFields))) return false;
            if (this.Ir2feature != input.Ir2feature || (this.Ir2feature != null && !this.Ir2feature.Equals(input.Ir2feature))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.RelatedNetworkSecurity != input.RelatedNetworkSecurity || (this.RelatedNetworkSecurity != null && !this.RelatedNetworkSecurity.Equals(input.RelatedNetworkSecurity))) return false;
            if (this.Collaboratives != input.Collaboratives || (this.Collaboratives != null && !this.Collaboratives.Equals(input.Collaboratives))) return false;
            if (this.BusinessDomain != input.BusinessDomain || (this.BusinessDomain != null && !this.BusinessDomain.Equals(input.BusinessDomain))) return false;
            if (this.PlanPi != input.PlanPi || (this.PlanPi != null && !this.PlanPi.Equals(input.PlanPi))) return false;
            if (this.SubmittedBy != input.SubmittedBy || (this.SubmittedBy != null && input.SubmittedBy != null && !this.SubmittedBy.SequenceEqual(input.SubmittedBy))) return false;
            if (this.Ir2rr != input.Ir2rr || (this.Ir2rr != null && !this.Ir2rr.Equals(input.Ir2rr))) return false;
            if (this.FeatureSet != input.FeatureSet || (this.FeatureSet != null && !this.FeatureSet.Equals(input.FeatureSet))) return false;
            if (this.SecurityLevel != input.SecurityLevel || (this.SecurityLevel != null && !this.SecurityLevel.Equals(input.SecurityLevel))) return false;

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
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.CategoryLayerId != null) hashCode = hashCode * 59 + this.CategoryLayerId.GetHashCode();
                if (this.ParentId != null) hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Assignee != null) hashCode = hashCode * 59 + this.Assignee.GetHashCode();
                if (this.Recipient != null) hashCode = hashCode * 59 + this.Recipient.GetHashCode();
                if (this.AssignedCc != null) hashCode = hashCode * 59 + this.AssignedCc.GetHashCode();
                if (this.PlanEndDate != null) hashCode = hashCode * 59 + this.PlanEndDate.GetHashCode();
                if (this.Workload != null) hashCode = hashCode * 59 + this.Workload.GetHashCode();
                if (this.Link != null) hashCode = hashCode * 59 + this.Link.GetHashCode();
                if (this.Labels != null) hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.CustomFields != null) hashCode = hashCode * 59 + this.CustomFields.GetHashCode();
                if (this.Ir2feature != null) hashCode = hashCode * 59 + this.Ir2feature.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.RelatedNetworkSecurity != null) hashCode = hashCode * 59 + this.RelatedNetworkSecurity.GetHashCode();
                if (this.Collaboratives != null) hashCode = hashCode * 59 + this.Collaboratives.GetHashCode();
                if (this.BusinessDomain != null) hashCode = hashCode * 59 + this.BusinessDomain.GetHashCode();
                if (this.PlanPi != null) hashCode = hashCode * 59 + this.PlanPi.GetHashCode();
                if (this.SubmittedBy != null) hashCode = hashCode * 59 + this.SubmittedBy.GetHashCode();
                if (this.Ir2rr != null) hashCode = hashCode * 59 + this.Ir2rr.GetHashCode();
                if (this.FeatureSet != null) hashCode = hashCode * 59 + this.FeatureSet.GetHashCode();
                if (this.SecurityLevel != null) hashCode = hashCode * 59 + this.SecurityLevel.GetHashCode();
                return hashCode;
            }
        }
    }
}
