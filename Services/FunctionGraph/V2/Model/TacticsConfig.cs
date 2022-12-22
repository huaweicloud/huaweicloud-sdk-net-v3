using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TacticsConfig 
    {

        /// <summary>
        /// 定时配置列表
        /// </summary>
        [JsonProperty("cron_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<CronConfig> CronConfigs { get; set; }

        /// <summary>
        /// 流量配置列表
        /// </summary>
        [JsonProperty("metric_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<MetricConfig> MetricConfigs { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TacticsConfig {\n");
            sb.Append("  cronConfigs: ").Append(CronConfigs).Append("\n");
            sb.Append("  metricConfigs: ").Append(MetricConfigs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TacticsConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TacticsConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CronConfigs == input.CronConfigs ||
                    this.CronConfigs != null &&
                    input.CronConfigs != null &&
                    this.CronConfigs.SequenceEqual(input.CronConfigs)
                ) && 
                (
                    this.MetricConfigs == input.MetricConfigs ||
                    this.MetricConfigs != null &&
                    input.MetricConfigs != null &&
                    this.MetricConfigs.SequenceEqual(input.MetricConfigs)
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
                if (this.CronConfigs != null)
                    hashCode = hashCode * 59 + this.CronConfigs.GetHashCode();
                if (this.MetricConfigs != null)
                    hashCode = hashCode * 59 + this.MetricConfigs.GetHashCode();
                return hashCode;
            }
        }
    }
}
