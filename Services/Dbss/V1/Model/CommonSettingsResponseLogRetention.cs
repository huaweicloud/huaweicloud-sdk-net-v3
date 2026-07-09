using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// 日志保留设置
    /// </summary>
    public class CommonSettingsResponseLogRetention 
    {

        /// <summary>
        /// 设定的审计日志保存时间
        /// </summary>
        [JsonProperty("retention_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// 审计日志保存时间设置最小时间
        /// </summary>
        [JsonProperty("range_days_min", NullValueHandling = NullValueHandling.Ignore)]
        public int? RangeDaysMin { get; set; }

        /// <summary>
        /// 审计日志保存时间设置最大时间
        /// </summary>
        [JsonProperty("range_days_max", NullValueHandling = NullValueHandling.Ignore)]
        public int? RangeDaysMax { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonSettingsResponseLogRetention {\n");
            sb.Append("  retentionDays: ").Append(RetentionDays).Append("\n");
            sb.Append("  rangeDaysMin: ").Append(RangeDaysMin).Append("\n");
            sb.Append("  rangeDaysMax: ").Append(RangeDaysMax).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CommonSettingsResponseLogRetention);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CommonSettingsResponseLogRetention input)
        {
            if (input == null) return false;
            if (this.RetentionDays != input.RetentionDays || (this.RetentionDays != null && !this.RetentionDays.Equals(input.RetentionDays))) return false;
            if (this.RangeDaysMin != input.RangeDaysMin || (this.RangeDaysMin != null && !this.RangeDaysMin.Equals(input.RangeDaysMin))) return false;
            if (this.RangeDaysMax != input.RangeDaysMax || (this.RangeDaysMax != null && !this.RangeDaysMax.Equals(input.RangeDaysMax))) return false;

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
                if (this.RetentionDays != null) hashCode = hashCode * 59 + this.RetentionDays.GetHashCode();
                if (this.RangeDaysMin != null) hashCode = hashCode * 59 + this.RangeDaysMin.GetHashCode();
                if (this.RangeDaysMax != null) hashCode = hashCode * 59 + this.RangeDaysMax.GetHashCode();
                return hashCode;
            }
        }
    }
}
