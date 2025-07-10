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
    /// Response Object
    /// </summary>
    public class ShowRuleRestrictionResponse : SdkResponse
    {

        /// <summary>
        /// 应用管控开关，false：关闭，true：打开
        /// </summary>
        [JsonProperty("app_restrict_rule_switch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AppRestrictRuleSwitch { get; set; }

        /// <summary>
        /// 应用管控方式，0：禁止列表应用程序运行
        /// </summary>
        [JsonProperty("app_control_mode", NullValueHandling = NullValueHandling.Ignore)]
        public int? AppControlMode { get; set; }

        /// <summary>
        /// 周期性监控开关，false：关闭，true：打开
        /// </summary>
        [JsonProperty("app_periodic_switch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AppPeriodicSwitch { get; set; }

        /// <summary>
        /// 周期性监控间隔时间，单位分钟
        /// </summary>
        [JsonProperty("app_periodic_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? AppPeriodicInterval { get; set; }

        /// <summary>
        /// 强制kill应用开关，false：关闭，true：打开
        /// </summary>
        [JsonProperty("app_force_kill_proc_switch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AppForceKillProcSwitch { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRuleRestrictionResponse {\n");
            sb.Append("  appRestrictRuleSwitch: ").Append(AppRestrictRuleSwitch).Append("\n");
            sb.Append("  appControlMode: ").Append(AppControlMode).Append("\n");
            sb.Append("  appPeriodicSwitch: ").Append(AppPeriodicSwitch).Append("\n");
            sb.Append("  appPeriodicInterval: ").Append(AppPeriodicInterval).Append("\n");
            sb.Append("  appForceKillProcSwitch: ").Append(AppForceKillProcSwitch).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRuleRestrictionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRuleRestrictionResponse input)
        {
            if (input == null) return false;
            if (this.AppRestrictRuleSwitch != input.AppRestrictRuleSwitch || (this.AppRestrictRuleSwitch != null && !this.AppRestrictRuleSwitch.Equals(input.AppRestrictRuleSwitch))) return false;
            if (this.AppControlMode != input.AppControlMode || (this.AppControlMode != null && !this.AppControlMode.Equals(input.AppControlMode))) return false;
            if (this.AppPeriodicSwitch != input.AppPeriodicSwitch || (this.AppPeriodicSwitch != null && !this.AppPeriodicSwitch.Equals(input.AppPeriodicSwitch))) return false;
            if (this.AppPeriodicInterval != input.AppPeriodicInterval || (this.AppPeriodicInterval != null && !this.AppPeriodicInterval.Equals(input.AppPeriodicInterval))) return false;
            if (this.AppForceKillProcSwitch != input.AppForceKillProcSwitch || (this.AppForceKillProcSwitch != null && !this.AppForceKillProcSwitch.Equals(input.AppForceKillProcSwitch))) return false;

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
                if (this.AppRestrictRuleSwitch != null) hashCode = hashCode * 59 + this.AppRestrictRuleSwitch.GetHashCode();
                if (this.AppControlMode != null) hashCode = hashCode * 59 + this.AppControlMode.GetHashCode();
                if (this.AppPeriodicSwitch != null) hashCode = hashCode * 59 + this.AppPeriodicSwitch.GetHashCode();
                if (this.AppPeriodicInterval != null) hashCode = hashCode * 59 + this.AppPeriodicInterval.GetHashCode();
                if (this.AppForceKillProcSwitch != null) hashCode = hashCode * 59 + this.AppForceKillProcSwitch.GetHashCode();
                return hashCode;
            }
        }
    }
}
