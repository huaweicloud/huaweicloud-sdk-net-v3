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
    /// **参数解释**： 状态变更结果对象，包含不可完成的AR工作项列表。 **约束限制**： 不涉及。
    /// </summary>
    public class StatusChangeResult 
    {

        /// <summary>
        /// **参数解释**： 不可完成的AR工作项列表，当完成发布/迭代时，未完成的AR工作项会列出在此。
        /// </summary>
        [JsonProperty("cannot_finish_ar", NullValueHandling = NullValueHandling.Ignore)]
        public List<WorkItemVO> CannotFinishAr { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatusChangeResult {\n");
            sb.Append("  cannotFinishAr: ").Append(CannotFinishAr).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StatusChangeResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StatusChangeResult input)
        {
            if (input == null) return false;
            if (this.CannotFinishAr != input.CannotFinishAr || (this.CannotFinishAr != null && input.CannotFinishAr != null && !this.CannotFinishAr.SequenceEqual(input.CannotFinishAr))) return false;

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
                if (this.CannotFinishAr != null) hashCode = hashCode * 59 + this.CannotFinishAr.GetHashCode();
                return hashCode;
            }
        }
    }
}
