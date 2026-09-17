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
    /// **参数解释：** 返回结果。 **取值范围：** 不涉及。
    /// </summary>
    public class BatchDeletesResponseResult 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("delete_issue", NullValueHandling = NullValueHandling.Ignore)]
        public BatchDeletesResponseResultDeleteIssue DeleteIssue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeletesResponseResult {\n");
            sb.Append("  deleteIssue: ").Append(DeleteIssue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeletesResponseResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeletesResponseResult input)
        {
            if (input == null) return false;
            if (this.DeleteIssue != input.DeleteIssue || (this.DeleteIssue != null && !this.DeleteIssue.Equals(input.DeleteIssue))) return false;

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
                if (this.DeleteIssue != null) hashCode = hashCode * 59 + this.DeleteIssue.GetHashCode();
                return hashCode;
            }
        }
    }
}
