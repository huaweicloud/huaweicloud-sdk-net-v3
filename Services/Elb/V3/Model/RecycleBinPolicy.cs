using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// **参数解释**：回收站的回收配置。
    /// </summary>
    public class RecycleBinPolicy 
    {

        /// <summary>
        /// **参数解释**：允许进入回收站的最小创建时间，不足此时长则删除时不满足进入回收站的条件。  **取值范围**：不涉及
        /// </summary>
        [JsonProperty("recycle_threshold_hour", NullValueHandling = NullValueHandling.Ignore)]
        public int? RecycleThresholdHour { get; set; }

        /// <summary>
        /// **参数解释**：进入回收站的最大保留时长。  **取值范围**：不涉及
        /// </summary>
        [JsonProperty("retention_hour", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetentionHour { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecycleBinPolicy {\n");
            sb.Append("  recycleThresholdHour: ").Append(RecycleThresholdHour).Append("\n");
            sb.Append("  retentionHour: ").Append(RetentionHour).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecycleBinPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RecycleBinPolicy input)
        {
            if (input == null) return false;
            if (this.RecycleThresholdHour != input.RecycleThresholdHour || (this.RecycleThresholdHour != null && !this.RecycleThresholdHour.Equals(input.RecycleThresholdHour))) return false;
            if (this.RetentionHour != input.RetentionHour || (this.RetentionHour != null && !this.RetentionHour.Equals(input.RetentionHour))) return false;

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
                if (this.RecycleThresholdHour != null) hashCode = hashCode * 59 + this.RecycleThresholdHour.GetHashCode();
                if (this.RetentionHour != null) hashCode = hashCode * 59 + this.RetentionHour.GetHashCode();
                return hashCode;
            }
        }
    }
}
