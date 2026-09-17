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
    /// 工作项批量变更操作结果
    /// </summary>
    public class IssueBatchOperateEntitiesResult 
    {

        /// <summary>
        /// **参数解释**： 成功的结果。
        /// </summary>
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public List<IssueOperateResult> Success { get; set; }

        /// <summary>
        /// **参数解释**： 失败的结果。
        /// </summary>
        [JsonProperty("failed", NullValueHandling = NullValueHandling.Ignore)]
        public List<IssueOperateResult> Failed { get; set; }

        /// <summary>
        /// **参数解释**： 删除失败的工作项。 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("undeleted_trees", NullValueHandling = NullValueHandling.Ignore)]
        public List<IssueOperateResult> UndeletedTrees { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueBatchOperateEntitiesResult {\n");
            sb.Append("  success: ").Append(Success).Append("\n");
            sb.Append("  failed: ").Append(Failed).Append("\n");
            sb.Append("  undeletedTrees: ").Append(UndeletedTrees).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IssueBatchOperateEntitiesResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IssueBatchOperateEntitiesResult input)
        {
            if (input == null) return false;
            if (this.Success != input.Success || (this.Success != null && input.Success != null && !this.Success.SequenceEqual(input.Success))) return false;
            if (this.Failed != input.Failed || (this.Failed != null && input.Failed != null && !this.Failed.SequenceEqual(input.Failed))) return false;
            if (this.UndeletedTrees != input.UndeletedTrees || (this.UndeletedTrees != null && input.UndeletedTrees != null && !this.UndeletedTrees.SequenceEqual(input.UndeletedTrees))) return false;

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
                if (this.Success != null) hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.Failed != null) hashCode = hashCode * 59 + this.Failed.GetHashCode();
                if (this.UndeletedTrees != null) hashCode = hashCode * 59 + this.UndeletedTrees.GetHashCode();
                return hashCode;
            }
        }
    }
}
