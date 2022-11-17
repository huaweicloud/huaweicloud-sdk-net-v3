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
        /// 打开回收策略，不可关闭 - true 打开回收策略
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 策略保持时长（1-7天），天数为正整数，不填默认保留7天
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
            if (input == null)
                return false;

            return 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.RetentionPeriodInDays == input.RetentionPeriodInDays ||
                    (this.RetentionPeriodInDays != null &&
                    this.RetentionPeriodInDays.Equals(input.RetentionPeriodInDays))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.RetentionPeriodInDays != null)
                    hashCode = hashCode * 59 + this.RetentionPeriodInDays.GetHashCode();
                return hashCode;
            }
        }
    }
}
