using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RecyclePolicy 
    {

        /// <summary>
        /// **参数解释：** 打开回收策略。 **约束限制：** 不可关闭。 **取值范围：** true。 **默认取值：** true。
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// **参数解释：** 策略保持时长（1-7天），天数为正整数，不填默认保留7天。 **约束限制：** 正整数。 **取值范围：** 1-7。 **默认取值：** 7。
        /// </summary>
        [JsonProperty("retention_period_in_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetentionPeriodInDays { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecyclePolicy {\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  retentionPeriodInDays: ").Append(RetentionPeriodInDays).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecyclePolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RecyclePolicy input)
        {
            if (input == null) return false;
            if (this.Enabled != input.Enabled || (this.Enabled != null && !this.Enabled.Equals(input.Enabled))) return false;
            if (this.RetentionPeriodInDays != input.RetentionPeriodInDays || (this.RetentionPeriodInDays != null && !this.RetentionPeriodInDays.Equals(input.RetentionPeriodInDays))) return false;

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
                if (this.Enabled != null) hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.RetentionPeriodInDays != null) hashCode = hashCode * 59 + this.RetentionPeriodInDays.GetHashCode();
                return hashCode;
            }
        }
    }
}
