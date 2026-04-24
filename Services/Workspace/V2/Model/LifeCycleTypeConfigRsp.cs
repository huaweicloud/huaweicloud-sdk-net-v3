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
    /// 生命周期类型配置响应。
    /// </summary>
    public class LifeCycleTypeConfigRsp 
    {

        /// <summary>
        /// 最小等待时长，单位分钟。
        /// </summary>
        [JsonProperty("min_wait_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinWaitTime { get; set; }

        /// <summary>
        /// 默认等待时长，单位分钟。
        /// </summary>
        [JsonProperty("default_wait_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultWaitTime { get; set; }

        /// <summary>
        /// 最小执行周期，单位分钟。
        /// </summary>
        [JsonProperty("min_exec_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinExecTime { get; set; }

        /// <summary>
        /// 默认执行周期，单位分钟。
        /// </summary>
        [JsonProperty("default_exec_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultExecTime { get; set; }

        /// <summary>
        /// 是否支持执行周期。
        /// </summary>
        [JsonProperty("support_exec_time", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportExecTime { get; set; }

        /// <summary>
        /// 可执行的动作列表。
        /// </summary>
        [JsonProperty("actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<ActionConfig> Actions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LifeCycleTypeConfigRsp {\n");
            sb.Append("  minWaitTime: ").Append(MinWaitTime).Append("\n");
            sb.Append("  defaultWaitTime: ").Append(DefaultWaitTime).Append("\n");
            sb.Append("  minExecTime: ").Append(MinExecTime).Append("\n");
            sb.Append("  defaultExecTime: ").Append(DefaultExecTime).Append("\n");
            sb.Append("  supportExecTime: ").Append(SupportExecTime).Append("\n");
            sb.Append("  actions: ").Append(Actions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LifeCycleTypeConfigRsp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LifeCycleTypeConfigRsp input)
        {
            if (input == null) return false;
            if (this.MinWaitTime != input.MinWaitTime || (this.MinWaitTime != null && !this.MinWaitTime.Equals(input.MinWaitTime))) return false;
            if (this.DefaultWaitTime != input.DefaultWaitTime || (this.DefaultWaitTime != null && !this.DefaultWaitTime.Equals(input.DefaultWaitTime))) return false;
            if (this.MinExecTime != input.MinExecTime || (this.MinExecTime != null && !this.MinExecTime.Equals(input.MinExecTime))) return false;
            if (this.DefaultExecTime != input.DefaultExecTime || (this.DefaultExecTime != null && !this.DefaultExecTime.Equals(input.DefaultExecTime))) return false;
            if (this.SupportExecTime != input.SupportExecTime || (this.SupportExecTime != null && !this.SupportExecTime.Equals(input.SupportExecTime))) return false;
            if (this.Actions != input.Actions || (this.Actions != null && input.Actions != null && !this.Actions.SequenceEqual(input.Actions))) return false;

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
                if (this.MinWaitTime != null) hashCode = hashCode * 59 + this.MinWaitTime.GetHashCode();
                if (this.DefaultWaitTime != null) hashCode = hashCode * 59 + this.DefaultWaitTime.GetHashCode();
                if (this.MinExecTime != null) hashCode = hashCode * 59 + this.MinExecTime.GetHashCode();
                if (this.DefaultExecTime != null) hashCode = hashCode * 59 + this.DefaultExecTime.GetHashCode();
                if (this.SupportExecTime != null) hashCode = hashCode * 59 + this.SupportExecTime.GetHashCode();
                if (this.Actions != null) hashCode = hashCode * 59 + this.Actions.GetHashCode();
                return hashCode;
            }
        }
    }
}
