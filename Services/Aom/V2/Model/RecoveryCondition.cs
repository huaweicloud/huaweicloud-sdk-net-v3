using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RecoveryCondition 
    {

        /// <summary>
        /// 告警恢复周期的个数。
        /// </summary>
        [JsonProperty("recovery_timeframe", NullValueHandling = NullValueHandling.Ignore)]
        public int? RecoveryTimeframe { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecoveryCondition {\n");
            sb.Append("  recoveryTimeframe: ").Append(RecoveryTimeframe).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecoveryCondition);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RecoveryCondition input)
        {
            if (input == null) return false;
            if (this.RecoveryTimeframe != input.RecoveryTimeframe || (this.RecoveryTimeframe != null && !this.RecoveryTimeframe.Equals(input.RecoveryTimeframe))) return false;

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
                if (this.RecoveryTimeframe != null) hashCode = hashCode * 59 + this.RecoveryTimeframe.GetHashCode();
                return hashCode;
            }
        }
    }
}
