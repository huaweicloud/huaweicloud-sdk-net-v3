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
    public class Policy 
    {

        /// <summary>
        /// 备份周期的crontab表达式
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }

        /// <summary>
        /// 保留时长（天）
        /// </summary>
        [JsonProperty("retention_days", NullValueHandling = NullValueHandling.Ignore)]
        public string RetentionDays { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Policy {\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  retentionDays: ").Append(RetentionDays).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Policy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Policy input)
        {
            if (input == null) return false;
            if (this.Period != input.Period || (this.Period != null && !this.Period.Equals(input.Period))) return false;
            if (this.RetentionDays != input.RetentionDays || (this.RetentionDays != null && !this.RetentionDays.Equals(input.RetentionDays))) return false;

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
                if (this.Period != null) hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.RetentionDays != null) hashCode = hashCode * 59 + this.RetentionDays.GetHashCode();
                return hashCode;
            }
        }
    }
}
