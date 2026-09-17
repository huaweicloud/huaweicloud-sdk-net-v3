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
    /// 取消关联工作项请求对象
    /// </summary>
    public class CancelAssociateIssueRequest 
    {

        /// <summary>
        /// **参数解释**： 源项目UUID。标识执行取消关联操作的源工作项所属项目。 **约束限制**： 32位UUID字符串,必填字段。 **取值范围**： 32个字符,由小写字母和数字组成。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("projectUUId", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectUUId { get; set; }

        /// <summary>
        /// **参数解释**： 目标项目UUID。标识被取消关联工作项所属的项目;跨项目取消时必填。 **约束限制**： 32位UUID字符串。 **取值范围**： 32个字符,由小写字母和数字组成。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("attachProjectUUId", NullValueHandling = NullValueHandling.Ignore)]
        public string AttachProjectUUId { get; set; }

        /// <summary>
        /// **参数解释**： 源工作项ID。即需要解除关联关系的工作项唯一ID。 **约束限制**： 工作项必须存在且未被归档。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("issueId", NullValueHandling = NullValueHandling.Ignore)]
        public int? IssueId { get; set; }

        /// <summary>
        /// **参数解释**： 待取消关联的目标工作项ID。 **约束限制**： 必须与源工作项已存在关联关系;不存在则返回错误码DEV_21_400806。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("attachIssueId", NullValueHandling = NullValueHandling.Ignore)]
        public int? AttachIssueId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CancelAssociateIssueRequest {\n");
            sb.Append("  projectUUId: ").Append(ProjectUUId).Append("\n");
            sb.Append("  attachProjectUUId: ").Append(AttachProjectUUId).Append("\n");
            sb.Append("  issueId: ").Append(IssueId).Append("\n");
            sb.Append("  attachIssueId: ").Append(AttachIssueId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CancelAssociateIssueRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CancelAssociateIssueRequest input)
        {
            if (input == null) return false;
            if (this.ProjectUUId != input.ProjectUUId || (this.ProjectUUId != null && !this.ProjectUUId.Equals(input.ProjectUUId))) return false;
            if (this.AttachProjectUUId != input.AttachProjectUUId || (this.AttachProjectUUId != null && !this.AttachProjectUUId.Equals(input.AttachProjectUUId))) return false;
            if (this.IssueId != input.IssueId || (this.IssueId != null && !this.IssueId.Equals(input.IssueId))) return false;
            if (this.AttachIssueId != input.AttachIssueId || (this.AttachIssueId != null && !this.AttachIssueId.Equals(input.AttachIssueId))) return false;

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
                if (this.AttachIssueId != null) hashCode = hashCode * 59 + this.AttachIssueId.GetHashCode();
                return hashCode;
            }
        }
    }
}
