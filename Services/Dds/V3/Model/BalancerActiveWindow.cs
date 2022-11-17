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
    /// 活动时间窗设置。
    /// </summary>
    public class BalancerActiveWindow 
    {

        /// <summary>
        /// 活动时间窗开始时间。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 活动时间窗结束时间。
        /// </summary>
        [JsonProperty("stop_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StopTime { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BalancerActiveWindow {\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  stopTime: ").Append(StopTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BalancerActiveWindow);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BalancerActiveWindow input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.StopTime == input.StopTime ||
                    (this.StopTime != null &&
                    this.StopTime.Equals(input.StopTime))
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
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.StopTime != null)
                    hashCode = hashCode * 59 + this.StopTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
