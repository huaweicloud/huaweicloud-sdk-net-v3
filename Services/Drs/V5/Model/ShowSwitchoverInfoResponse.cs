using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowSwitchoverInfoResponse : SdkResponse
    {

        /// <summary>
        /// 上次倒换完成时间点
        /// </summary>
        [JsonProperty("last_switchover_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastSwitchoverTime { get; set; }

        /// <summary>
        /// 上次倒换任务位点信息
        /// </summary>
        [JsonProperty("increment_check_point", NullValueHandling = NullValueHandling.Ignore)]
        public string IncrementCheckPoint { get; set; }

        /// <summary>
        /// 上次倒换目标库倒换时位点
        /// </summary>
        [JsonProperty("target_safe_point", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetSafePoint { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSwitchoverInfoResponse {\n");
            sb.Append("  lastSwitchoverTime: ").Append(LastSwitchoverTime).Append("\n");
            sb.Append("  incrementCheckPoint: ").Append(IncrementCheckPoint).Append("\n");
            sb.Append("  targetSafePoint: ").Append(TargetSafePoint).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSwitchoverInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSwitchoverInfoResponse input)
        {
            if (input == null) return false;
            if (this.LastSwitchoverTime != input.LastSwitchoverTime || (this.LastSwitchoverTime != null && !this.LastSwitchoverTime.Equals(input.LastSwitchoverTime))) return false;
            if (this.IncrementCheckPoint != input.IncrementCheckPoint || (this.IncrementCheckPoint != null && !this.IncrementCheckPoint.Equals(input.IncrementCheckPoint))) return false;
            if (this.TargetSafePoint != input.TargetSafePoint || (this.TargetSafePoint != null && !this.TargetSafePoint.Equals(input.TargetSafePoint))) return false;

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
                if (this.LastSwitchoverTime != null) hashCode = hashCode * 59 + this.LastSwitchoverTime.GetHashCode();
                if (this.IncrementCheckPoint != null) hashCode = hashCode * 59 + this.IncrementCheckPoint.GetHashCode();
                if (this.TargetSafePoint != null) hashCode = hashCode * 59 + this.TargetSafePoint.GetHashCode();
                return hashCode;
            }
        }
    }
}
