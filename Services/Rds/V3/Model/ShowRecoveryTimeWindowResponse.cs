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
    /// Response Object
    /// </summary>
    public class ShowRecoveryTimeWindowResponse : SdkResponse
    {

        /// <summary>
        /// 恢复时间窗左边界（不包含）
        /// </summary>
        [JsonProperty("recovery_min_time", NullValueHandling = NullValueHandling.Ignore)]
        public string RecoveryMinTime { get; set; }

        /// <summary>
        /// 恢复时间窗右边界（包含）
        /// </summary>
        [JsonProperty("recovery_max_time", NullValueHandling = NullValueHandling.Ignore)]
        public string RecoveryMaxTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRecoveryTimeWindowResponse {\n");
            sb.Append("  recoveryMinTime: ").Append(RecoveryMinTime).Append("\n");
            sb.Append("  recoveryMaxTime: ").Append(RecoveryMaxTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRecoveryTimeWindowResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRecoveryTimeWindowResponse input)
        {
            if (input == null) return false;
            if (this.RecoveryMinTime != input.RecoveryMinTime || (this.RecoveryMinTime != null && !this.RecoveryMinTime.Equals(input.RecoveryMinTime))) return false;
            if (this.RecoveryMaxTime != input.RecoveryMaxTime || (this.RecoveryMaxTime != null && !this.RecoveryMaxTime.Equals(input.RecoveryMaxTime))) return false;

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
                if (this.RecoveryMinTime != null) hashCode = hashCode * 59 + this.RecoveryMinTime.GetHashCode();
                if (this.RecoveryMaxTime != null) hashCode = hashCode * 59 + this.RecoveryMaxTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
