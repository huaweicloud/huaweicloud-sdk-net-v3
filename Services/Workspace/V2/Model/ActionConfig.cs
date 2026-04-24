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
    /// 动作配置。
    /// </summary>
    public class ActionConfig 
    {

        /// <summary>
        /// 动作名称。STOP：关机，HIBERNATE：休眠，REBOOT：重启，EXECUTE_SCRIPT：执行脚本。
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// 最小等待时长，单位分钟。如果不填，则使用父级的 min_wait_time。
        /// </summary>
        [JsonProperty("min_wait_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinWaitTime { get; set; }

        /// <summary>
        /// 默认等待时长，单位分钟。如果不填，则使用父级的 default_wait_time。
        /// </summary>
        [JsonProperty("default_wait_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultWaitTime { get; set; }

        /// <summary>
        /// 最小执行周期，单位分钟。如果不填，则使用父级的 min_exec_time。
        /// </summary>
        [JsonProperty("min_exec_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinExecTime { get; set; }

        /// <summary>
        /// 默认执行周期，单位分钟。如果不填，则使用父级的 default_exec_time。
        /// </summary>
        [JsonProperty("default_exec_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultExecTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionConfig {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  minWaitTime: ").Append(MinWaitTime).Append("\n");
            sb.Append("  defaultWaitTime: ").Append(DefaultWaitTime).Append("\n");
            sb.Append("  minExecTime: ").Append(MinExecTime).Append("\n");
            sb.Append("  defaultExecTime: ").Append(DefaultExecTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ActionConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ActionConfig input)
        {
            if (input == null) return false;
            if (this.Action != input.Action || (this.Action != null && !this.Action.Equals(input.Action))) return false;
            if (this.MinWaitTime != input.MinWaitTime || (this.MinWaitTime != null && !this.MinWaitTime.Equals(input.MinWaitTime))) return false;
            if (this.DefaultWaitTime != input.DefaultWaitTime || (this.DefaultWaitTime != null && !this.DefaultWaitTime.Equals(input.DefaultWaitTime))) return false;
            if (this.MinExecTime != input.MinExecTime || (this.MinExecTime != null && !this.MinExecTime.Equals(input.MinExecTime))) return false;
            if (this.DefaultExecTime != input.DefaultExecTime || (this.DefaultExecTime != null && !this.DefaultExecTime.Equals(input.DefaultExecTime))) return false;

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
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.MinWaitTime != null) hashCode = hashCode * 59 + this.MinWaitTime.GetHashCode();
                if (this.DefaultWaitTime != null) hashCode = hashCode * 59 + this.DefaultWaitTime.GetHashCode();
                if (this.MinExecTime != null) hashCode = hashCode * 59 + this.MinExecTime.GetHashCode();
                if (this.DefaultExecTime != null) hashCode = hashCode * 59 + this.DefaultExecTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
