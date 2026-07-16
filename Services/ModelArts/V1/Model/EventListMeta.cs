using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 事件列表元信息。
    /// </summary>
    public class EventListMeta 
    {

        /// <summary>
        /// **参数描述**：分页标记。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("continue", NullValueHandling = NullValueHandling.Ignore)]
        public string Continue { get; set; }

        /// <summary>
        /// **参数描述**：分页剩余数量。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("remainingItemCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? RemainingItemCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventListMeta {\n");
            sb.Append("  Continue: ").Append(Continue).Append("\n");
            sb.Append("  remainingItemCount: ").Append(RemainingItemCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EventListMeta);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EventListMeta input)
        {
            if (input == null) return false;
            if (this.Continue != input.Continue || (this.Continue != null && !this.Continue.Equals(input.Continue))) return false;
            if (this.RemainingItemCount != input.RemainingItemCount || (this.RemainingItemCount != null && !this.RemainingItemCount.Equals(input.RemainingItemCount))) return false;

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
                if (this.Continue != null) hashCode = hashCode * 59 + this.Continue.GetHashCode();
                if (this.RemainingItemCount != null) hashCode = hashCode * 59 + this.RemainingItemCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
