using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UpdateBranchNameResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 旧分支名称。  **约束限制：** 不支持以 - . refs/heads/ refs/remotes/ 开头，不支持空格 [ \\ &lt; ~ ^ : ? * ! ( ) &#39; \&quot; | 等特殊字符，不支持以. / .lock结尾。  **取值范围：** 字符串长度不少于1，不超过200。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("old_branch_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OldBranchName { get; set; }

        /// <summary>
        /// **参数解释：** 旧分支最新提交ID。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("old_branch_commit_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OldBranchCommitId { get; set; }

        /// <summary>
        /// **参数解释：** 新分支名称。  **约束限制：** 不支持以 - . refs/heads/ refs/remotes/ 开头，不支持空格 [ \\ &lt; ~ ^ : ? * ! ( ) &#39; \&quot; | 等特殊字符，不支持以. / .lock结尾。  **取值范围：** 字符串长度不少于1，不超过200。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("new_branch_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NewBranchName { get; set; }

        /// <summary>
        /// **参数解释：** 新分支最新提交ID。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("new_branch_commit_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NewBranchCommitId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateBranchNameResponse {\n");
            sb.Append("  oldBranchName: ").Append(OldBranchName).Append("\n");
            sb.Append("  oldBranchCommitId: ").Append(OldBranchCommitId).Append("\n");
            sb.Append("  newBranchName: ").Append(NewBranchName).Append("\n");
            sb.Append("  newBranchCommitId: ").Append(NewBranchCommitId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateBranchNameResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateBranchNameResponse input)
        {
            if (input == null) return false;
            if (this.OldBranchName != input.OldBranchName || (this.OldBranchName != null && !this.OldBranchName.Equals(input.OldBranchName))) return false;
            if (this.OldBranchCommitId != input.OldBranchCommitId || (this.OldBranchCommitId != null && !this.OldBranchCommitId.Equals(input.OldBranchCommitId))) return false;
            if (this.NewBranchName != input.NewBranchName || (this.NewBranchName != null && !this.NewBranchName.Equals(input.NewBranchName))) return false;
            if (this.NewBranchCommitId != input.NewBranchCommitId || (this.NewBranchCommitId != null && !this.NewBranchCommitId.Equals(input.NewBranchCommitId))) return false;

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
                if (this.OldBranchName != null) hashCode = hashCode * 59 + this.OldBranchName.GetHashCode();
                if (this.OldBranchCommitId != null) hashCode = hashCode * 59 + this.OldBranchCommitId.GetHashCode();
                if (this.NewBranchName != null) hashCode = hashCode * 59 + this.NewBranchName.GetHashCode();
                if (this.NewBranchCommitId != null) hashCode = hashCode * 59 + this.NewBranchCommitId.GetHashCode();
                return hashCode;
            }
        }
    }
}
