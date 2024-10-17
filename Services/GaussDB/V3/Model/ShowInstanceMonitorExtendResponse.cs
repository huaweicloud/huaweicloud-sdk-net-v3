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
    /// Response Object
    /// </summary>
    public class ShowInstanceMonitorExtendResponse : SdkResponse
    {

        /// <summary>
        /// 实例秒级监控开关。  - true，表示开启。 - false，表示关闭。
        /// </summary>
        [JsonProperty("monitor_switch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MonitorSwitch { get; set; }

        /// <summary>
        /// 采集周期，仅在monitor_switch为true时返回。  - 1：采集周期为1s。 - 5：采集周期为5s。
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public int? Period { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowInstanceMonitorExtendResponse {\n");
            sb.Append("  monitorSwitch: ").Append(MonitorSwitch).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowInstanceMonitorExtendResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowInstanceMonitorExtendResponse input)
        {
            if (input == null) return false;
            if (this.MonitorSwitch != input.MonitorSwitch || (this.MonitorSwitch != null && !this.MonitorSwitch.Equals(input.MonitorSwitch))) return false;
            if (this.Period != input.Period || (this.Period != null && !this.Period.Equals(input.Period))) return false;

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
                if (this.MonitorSwitch != null) hashCode = hashCode * 59 + this.MonitorSwitch.GetHashCode();
                if (this.Period != null) hashCode = hashCode * 59 + this.Period.GetHashCode();
                return hashCode;
            }
        }
    }
}
