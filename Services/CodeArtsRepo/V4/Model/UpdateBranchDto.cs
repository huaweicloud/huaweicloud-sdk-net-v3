using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateBranchDto 
    {

        /// <summary>
        /// **参数解释：** 新分支名称。  **约束限制：** 不支持以 - . refs/heads/ refs/remotes/ 开头，不支持空格 [ \\ &lt; ~ ^ : ? * ! ( ) &#39; \&quot; | 等特殊字符，不支持以. / .lock结尾。  **取值范围：** 字符串长度不少于1，不超过200。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("new_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string NewBranch { get; set; }

        /// <summary>
        /// **参数解释：** 基于分支名称。  **约束限制：** 不支持以 - . refs/heads/ refs/remotes/ 开头，不支持空格 [ \\ &lt; ~ ^ : ? * ! ( ) &#39; \&quot; | 等特殊字符，不支持以. / .lock结尾。  **取值范围：** 字符串长度不少于1，不超过200。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("old_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string OldBranch { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateBranchDto {\n");
            sb.Append("  newBranch: ").Append(NewBranch).Append("\n");
            sb.Append("  oldBranch: ").Append(OldBranch).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateBranchDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateBranchDto input)
        {
            if (input == null) return false;
            if (this.NewBranch != input.NewBranch || (this.NewBranch != null && !this.NewBranch.Equals(input.NewBranch))) return false;
            if (this.OldBranch != input.OldBranch || (this.OldBranch != null && !this.OldBranch.Equals(input.OldBranch))) return false;

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
                if (this.NewBranch != null) hashCode = hashCode * 59 + this.NewBranch.GetHashCode();
                if (this.OldBranch != null) hashCode = hashCode * 59 + this.OldBranch.GetHashCode();
                return hashCode;
            }
        }
    }
}
