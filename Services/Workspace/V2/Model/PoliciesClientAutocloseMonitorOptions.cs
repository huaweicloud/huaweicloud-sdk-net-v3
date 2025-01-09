using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 自动关闭显示器控制的选项。
    /// </summary>
    public class PoliciesClientAutocloseMonitorOptions 
    {

        /// <summary>
        /// 自动关闭显示器等待时间。取值范围为[10-600000]。默认：300。
        /// </summary>
        [JsonProperty("autoclose_monitor_wait_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? AutocloseMonitorWaitTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesClientAutocloseMonitorOptions {\n");
            sb.Append("  autocloseMonitorWaitTime: ").Append(AutocloseMonitorWaitTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesClientAutocloseMonitorOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesClientAutocloseMonitorOptions input)
        {
            if (input == null) return false;
            if (this.AutocloseMonitorWaitTime != input.AutocloseMonitorWaitTime || (this.AutocloseMonitorWaitTime != null && !this.AutocloseMonitorWaitTime.Equals(input.AutocloseMonitorWaitTime))) return false;

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
                if (this.AutocloseMonitorWaitTime != null) hashCode = hashCode * 59 + this.AutocloseMonitorWaitTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
