using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SaveMonitorItemParam 
    {

        /// <summary>
        /// 监控项id。
        /// </summary>
        [JsonProperty("monitor_item_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? MonitorItemId { get; set; }

        /// <summary>
        /// 采集间隔。
        /// </summary>
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? Interval { get; set; }

        /// <summary>
        /// 环境id。
        /// </summary>
        [JsonProperty("env_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? EnvId { get; set; }

        /// <summary>
        /// 配置项列表。
        /// </summary>
        [JsonProperty("config_value_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ConfigItem> ConfigValueList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SaveMonitorItemParam {\n");
            sb.Append("  monitorItemId: ").Append(MonitorItemId).Append("\n");
            sb.Append("  interval: ").Append(Interval).Append("\n");
            sb.Append("  envId: ").Append(EnvId).Append("\n");
            sb.Append("  configValueList: ").Append(ConfigValueList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SaveMonitorItemParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SaveMonitorItemParam input)
        {
            if (input == null) return false;
            if (this.MonitorItemId != input.MonitorItemId || (this.MonitorItemId != null && !this.MonitorItemId.Equals(input.MonitorItemId))) return false;
            if (this.Interval != input.Interval || (this.Interval != null && !this.Interval.Equals(input.Interval))) return false;
            if (this.EnvId != input.EnvId || (this.EnvId != null && !this.EnvId.Equals(input.EnvId))) return false;
            if (this.ConfigValueList != input.ConfigValueList || (this.ConfigValueList != null && input.ConfigValueList != null && !this.ConfigValueList.SequenceEqual(input.ConfigValueList))) return false;

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
                if (this.MonitorItemId != null) hashCode = hashCode * 59 + this.MonitorItemId.GetHashCode();
                if (this.Interval != null) hashCode = hashCode * 59 + this.Interval.GetHashCode();
                if (this.EnvId != null) hashCode = hashCode * 59 + this.EnvId.GetHashCode();
                if (this.ConfigValueList != null) hashCode = hashCode * 59 + this.ConfigValueList.GetHashCode();
                return hashCode;
            }
        }
    }
}
