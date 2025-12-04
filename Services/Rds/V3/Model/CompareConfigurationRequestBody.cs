using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CompareConfigurationRequestBody 
    {

        /// <summary>
        /// **参数解释**：  源参数模板id。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("source_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceId { get; set; }

        /// <summary>
        /// **参数解释**：  目标参数模板id。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("target_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompareConfigurationRequestBody {\n");
            sb.Append("  sourceId: ").Append(SourceId).Append("\n");
            sb.Append("  targetId: ").Append(TargetId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CompareConfigurationRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CompareConfigurationRequestBody input)
        {
            if (input == null) return false;
            if (this.SourceId != input.SourceId || (this.SourceId != null && !this.SourceId.Equals(input.SourceId))) return false;
            if (this.TargetId != input.TargetId || (this.TargetId != null && !this.TargetId.Equals(input.TargetId))) return false;

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
                if (this.SourceId != null) hashCode = hashCode * 59 + this.SourceId.GetHashCode();
                if (this.TargetId != null) hashCode = hashCode * 59 + this.TargetId.GetHashCode();
                return hashCode;
            }
        }
    }
}
