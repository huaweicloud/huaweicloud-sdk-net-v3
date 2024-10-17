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
    /// 回收策略。
    /// </summary>
    public class RecyclePolicy 
    {

        /// <summary>
        /// 保留时间，设置已删除实例保留天数，支持整数，可设置范围为1~7天。  当“retention_period_in_days”为空，保留时间默认是7天。
        /// </summary>
        [JsonProperty("retention_period_in_days", NullValueHandling = NullValueHandling.Ignore)]
        public string RetentionPeriodInDays { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecyclePolicy {\n");
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
                if (this.RetentionPeriodInDays != null) hashCode = hashCode * 59 + this.RetentionPeriodInDays.GetHashCode();
                return hashCode;
            }
        }
    }
}
