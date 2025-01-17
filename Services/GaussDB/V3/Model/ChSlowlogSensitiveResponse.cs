using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ChSlowlogSensitiveResponse 
    {

        /// <summary>
        /// 慢日志脱敏开关。
        /// </summary>
        [JsonProperty("open_slow_log_switch", NullValueHandling = NullValueHandling.Ignore)]
        public string OpenSlowLogSwitch { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChSlowlogSensitiveResponse {\n");
            sb.Append("  openSlowLogSwitch: ").Append(OpenSlowLogSwitch).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChSlowlogSensitiveResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChSlowlogSensitiveResponse input)
        {
            if (input == null) return false;
            if (this.OpenSlowLogSwitch != input.OpenSlowLogSwitch || (this.OpenSlowLogSwitch != null && !this.OpenSlowLogSwitch.Equals(input.OpenSlowLogSwitch))) return false;

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
                if (this.OpenSlowLogSwitch != null) hashCode = hashCode * 59 + this.OpenSlowLogSwitch.GetHashCode();
                return hashCode;
            }
        }
    }
}
