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
    /// **参数解释**： 被取消的关联关系记录详情,包含关联关系的所有属性信息。
    /// </summary>
    public class CancelAssociateIssueResponseResult 
    {

        /// <summary>
        /// **参数解释**： 关联关系唯一标识。 **取值范围**： 32个字符,由小写字母和数字组成。
        /// </summary>
        [JsonProperty("identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string Identifier { get; set; }

        /// <summary>
        /// **参数解释**： 源工作项ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("issueId", NullValueHandling = NullValueHandling.Ignore)]
        public int? IssueId { get; set; }

        /// <summary>
        /// **参数解释**： 源项目数字ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("projectId", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProjectId { get; set; }

        /// <summary>
        /// **参数解释**： 关联类型。 **取值范围**： - associate：关联工作项。
        /// </summary>
        [JsonProperty("associateType", NullValueHandling = NullValueHandling.Ignore)]
        public string AssociateType { get; set; }

        /// <summary>
        /// **参数解释**： 被关联工作项ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("associateIssueId", NullValueHandling = NullValueHandling.Ignore)]
        public int? AssociateIssueId { get; set; }

        /// <summary>
        /// **参数解释**： 被关联项目数字ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("associateProjectId", NullValueHandling = NullValueHandling.Ignore)]
        public int? AssociateProjectId { get; set; }

        /// <summary>
        /// **参数解释**： 关联关系创建时间。 **取值范围**： 格式为yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [JsonProperty("createdOn", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// **参数解释**： 创建该关联关系的用户ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("authorId", NullValueHandling = NullValueHandling.Ignore)]
        public int? AuthorId { get; set; }

        /// <summary>
        /// **参数解释**： 关联关系有效标识。 **取值范围**： - true：关联有效。 - false：关联已失效。
        /// </summary>
        [JsonProperty("flag", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Flag { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CancelAssociateIssueResponseResult {\n");
            sb.Append("  identifier: ").Append(Identifier).Append("\n");
            sb.Append("  issueId: ").Append(IssueId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  associateType: ").Append(AssociateType).Append("\n");
            sb.Append("  associateIssueId: ").Append(AssociateIssueId).Append("\n");
            sb.Append("  associateProjectId: ").Append(AssociateProjectId).Append("\n");
            sb.Append("  createdOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  authorId: ").Append(AuthorId).Append("\n");
            sb.Append("  flag: ").Append(Flag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CancelAssociateIssueResponseResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CancelAssociateIssueResponseResult input)
        {
            if (input == null) return false;
            if (this.Identifier != input.Identifier || (this.Identifier != null && !this.Identifier.Equals(input.Identifier))) return false;
            if (this.IssueId != input.IssueId || (this.IssueId != null && !this.IssueId.Equals(input.IssueId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.AssociateType != input.AssociateType || (this.AssociateType != null && !this.AssociateType.Equals(input.AssociateType))) return false;
            if (this.AssociateIssueId != input.AssociateIssueId || (this.AssociateIssueId != null && !this.AssociateIssueId.Equals(input.AssociateIssueId))) return false;
            if (this.AssociateProjectId != input.AssociateProjectId || (this.AssociateProjectId != null && !this.AssociateProjectId.Equals(input.AssociateProjectId))) return false;
            if (this.CreatedOn != input.CreatedOn || (this.CreatedOn != null && !this.CreatedOn.Equals(input.CreatedOn))) return false;
            if (this.AuthorId != input.AuthorId || (this.AuthorId != null && !this.AuthorId.Equals(input.AuthorId))) return false;
            if (this.Flag != input.Flag || (this.Flag != null && !this.Flag.Equals(input.Flag))) return false;

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
                if (this.Identifier != null) hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.IssueId != null) hashCode = hashCode * 59 + this.IssueId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.AssociateType != null) hashCode = hashCode * 59 + this.AssociateType.GetHashCode();
                if (this.AssociateIssueId != null) hashCode = hashCode * 59 + this.AssociateIssueId.GetHashCode();
                if (this.AssociateProjectId != null) hashCode = hashCode * 59 + this.AssociateProjectId.GetHashCode();
                if (this.CreatedOn != null) hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.AuthorId != null) hashCode = hashCode * 59 + this.AuthorId.GetHashCode();
                if (this.Flag != null) hashCode = hashCode * 59 + this.Flag.GetHashCode();
                return hashCode;
            }
        }
    }
}
