using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 定时任务策略。
    /// </summary>
    public class ScheduleTaskPolicy 
    {

        /// <summary>
        /// 当存在会话的时候，是否强制执行，强制执行开关。取值为： * false：表示关闭。 * true：表示开启。
        /// </summary>
        [JsonProperty("enforcement_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnforcementEnable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduleTaskPolicy {\n");
            sb.Append("  enforcementEnable: ").Append(EnforcementEnable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScheduleTaskPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScheduleTaskPolicy input)
        {
            if (input == null) return false;
            if (this.EnforcementEnable != input.EnforcementEnable || (this.EnforcementEnable != null && !this.EnforcementEnable.Equals(input.EnforcementEnable))) return false;

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
                if (this.EnforcementEnable != null) hashCode = hashCode * 59 + this.EnforcementEnable.GetHashCode();
                return hashCode;
            }
        }
    }
}
