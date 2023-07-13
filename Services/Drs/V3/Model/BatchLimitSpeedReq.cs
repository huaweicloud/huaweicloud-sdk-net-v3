using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BatchLimitSpeedReq 
    {

        /// <summary>
        /// 灾备限速设置信息
        /// </summary>
        [JsonProperty("speed_limits", NullValueHandling = NullValueHandling.Ignore)]
        public List<LimitSpeedReq> SpeedLimits { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchLimitSpeedReq {\n");
            sb.Append("  speedLimits: ").Append(SpeedLimits).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchLimitSpeedReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchLimitSpeedReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SpeedLimits == input.SpeedLimits ||
                    this.SpeedLimits != null &&
                    input.SpeedLimits != null &&
                    this.SpeedLimits.SequenceEqual(input.SpeedLimits)
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
                if (this.SpeedLimits != null)
                    hashCode = hashCode * 59 + this.SpeedLimits.GetHashCode();
                return hashCode;
            }
        }
    }
}
