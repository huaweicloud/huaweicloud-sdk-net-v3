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
    public class RestartPolicy 
    {

        /// <summary>
        /// 重启周期配置，在重启周期内的可维护时间窗进行重启，时区为UTC，取值范围： begin: 每月的第一天 middle：每月的15号 end：每月的最后一天 空列表，表示该功能关闭。
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Period { get; set; }

        /// <summary>
        /// 所在时区相较于UTC时间的偏移量，取值范围：格式必须为+hh:mm，或者-hh:mm，例如+08:00。
        /// </summary>
        [JsonProperty("utc_offset", NullValueHandling = NullValueHandling.Ignore)]
        public string UtcOffset { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestartPolicy {\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  utcOffset: ").Append(UtcOffset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestartPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestartPolicy input)
        {
            if (input == null) return false;
            if (this.Period != input.Period || (this.Period != null && input.Period != null && !this.Period.SequenceEqual(input.Period))) return false;
            if (this.UtcOffset != input.UtcOffset || (this.UtcOffset != null && !this.UtcOffset.Equals(input.UtcOffset))) return false;

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
                if (this.UtcOffset != null) hashCode = hashCode * 59 + this.UtcOffset.GetHashCode();
                return hashCode;
            }
        }
    }
}
