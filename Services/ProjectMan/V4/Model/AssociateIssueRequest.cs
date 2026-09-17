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
    /// 关联工作项请求对象
    /// </summary>
    public class AssociateIssueRequest 
    {

        /// <summary>
        /// **参数解释**： 源项目UUID。标识执行关联操作的源工作项所属项目。 **约束限制**： 32位UUID字符串,必填字段。 **取值范围**： 32个字符,由小写字母和数字组成。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("projectUUId", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectUUId { get; set; }

        /// <summary>
        /// **参数解释**： 目标项目UUID。标识待关联工作项所属的项目;跨项目关联时必填,同项目关联时可省略。 **约束限制**： 32位UUID字符串;若与projectUUId不同则视为跨项目关联。 **取值范围**： 32个字符,由小写字母和数字组成。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("attachProjectUUId", NullValueHandling = NullValueHandling.Ignore)]
        public string AttachProjectUUId { get; set; }

        /// <summary>
        /// **参数解释**： 源工作项ID。即需要建立关联关系的工作项唯一ID。 **约束限制**： 工作项必须存在且未被归档。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("issueId", NullValueHandling = NullValueHandling.Ignore)]
        public int? IssueId { get; set; }

        /// <summary>
        /// **参数解释**： 待关联工作项ID列表。本次操作需要新增关联关系的目标工作项ID集合。 **约束限制**： 每个元素为字符串形式的工作项ID(服务端自动转换为整数);不能包含issueId自身;单工作项关联总数受系统上限约束。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("associatedIssueIdList", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssociatedIssueIdList { get; set; }

        /// <summary>
        /// **参数解释**： 待取消关联工作项ID列表。本次操作需要解除关联关系的目标工作项ID集合;可在同一次请求中混合使用以支持关联关系调整。 **约束限制**： 每个元素为字符串形式的工作项ID;仅处理已存在的关联关系。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("unassociatedIssueIdList", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UnassociatedIssueIdList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssociateIssueRequest {\n");
            sb.Append("  projectUUId: ").Append(ProjectUUId).Append("\n");
            sb.Append("  attachProjectUUId: ").Append(AttachProjectUUId).Append("\n");
            sb.Append("  issueId: ").Append(IssueId).Append("\n");
            sb.Append("  associatedIssueIdList: ").Append(AssociatedIssueIdList).Append("\n");
            sb.Append("  unassociatedIssueIdList: ").Append(UnassociatedIssueIdList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssociateIssueRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssociateIssueRequest input)
        {
            if (input == null) return false;
            if (this.ProjectUUId != input.ProjectUUId || (this.ProjectUUId != null && !this.ProjectUUId.Equals(input.ProjectUUId))) return false;
            if (this.AttachProjectUUId != input.AttachProjectUUId || (this.AttachProjectUUId != null && !this.AttachProjectUUId.Equals(input.AttachProjectUUId))) return false;
            if (this.IssueId != input.IssueId || (this.IssueId != null && !this.IssueId.Equals(input.IssueId))) return false;
            if (this.AssociatedIssueIdList != input.AssociatedIssueIdList || (this.AssociatedIssueIdList != null && input.AssociatedIssueIdList != null && !this.AssociatedIssueIdList.SequenceEqual(input.AssociatedIssueIdList))) return false;
            if (this.UnassociatedIssueIdList != input.UnassociatedIssueIdList || (this.UnassociatedIssueIdList != null && input.UnassociatedIssueIdList != null && !this.UnassociatedIssueIdList.SequenceEqual(input.UnassociatedIssueIdList))) return false;

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
                if (this.ProjectUUId != null) hashCode = hashCode * 59 + this.ProjectUUId.GetHashCode();
                if (this.AttachProjectUUId != null) hashCode = hashCode * 59 + this.AttachProjectUUId.GetHashCode();
                if (this.IssueId != null) hashCode = hashCode * 59 + this.IssueId.GetHashCode();
                if (this.AssociatedIssueIdList != null) hashCode = hashCode * 59 + this.AssociatedIssueIdList.GetHashCode();
                if (this.UnassociatedIssueIdList != null) hashCode = hashCode * 59 + this.UnassociatedIssueIdList.GetHashCode();
                return hashCode;
            }
        }
    }
}
