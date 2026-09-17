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
    /// **参数解释：** 删除的工作项。 **取值范围：** 不涉及。
    /// </summary>
    public class BatchDeletesResponseResultDeleteIssue 
    {

        /// <summary>
        /// **参数解释：** 删除的工作项id。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("del_issue_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> DelIssueId { get; set; }

        /// <summary>
        /// **参数解释：** 删除的工作项详情。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("del_issue", NullValueHandling = NullValueHandling.Ignore)]
        public List<BatchDeletesResponseResultDeleteIssueDelIssue> DelIssue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeletesResponseResultDeleteIssue {\n");
            sb.Append("  delIssueId: ").Append(DelIssueId).Append("\n");
            sb.Append("  delIssue: ").Append(DelIssue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeletesResponseResultDeleteIssue);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeletesResponseResultDeleteIssue input)
        {
            if (input == null) return false;
            if (this.DelIssueId != input.DelIssueId || (this.DelIssueId != null && input.DelIssueId != null && !this.DelIssueId.SequenceEqual(input.DelIssueId))) return false;
            if (this.DelIssue != input.DelIssue || (this.DelIssue != null && input.DelIssue != null && !this.DelIssue.SequenceEqual(input.DelIssue))) return false;

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
                if (this.DelIssueId != null) hashCode = hashCode * 59 + this.DelIssueId.GetHashCode();
                if (this.DelIssue != null) hashCode = hashCode * 59 + this.DelIssue.GetHashCode();
                return hashCode;
            }
        }
    }
}
