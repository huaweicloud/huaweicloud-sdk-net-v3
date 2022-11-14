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
    /// 
    /// </summary>
    public class DurationStrategies 
    {

        /// <summary>
        /// 升级策略 - minimized_interrupt_time，表示最短中断时间 - minimized_upgrade_time，最短升级时长
        /// </summary>
        [JsonProperty("strategy", NullValueHandling = NullValueHandling.Ignore)]
        public string Strategy { get; set; }

        /// <summary>
        /// 升级时长，单位为分钟
        /// </summary>
        [JsonProperty("estimated_upgrade_duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? EstimatedUpgradeDuration { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DurationStrategies {\n");
            sb.Append("  strategy: ").Append(Strategy).Append("\n");
            sb.Append("  estimatedUpgradeDuration: ").Append(EstimatedUpgradeDuration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DurationStrategies);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DurationStrategies input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Strategy == input.Strategy ||
                    (this.Strategy != null &&
                    this.Strategy.Equals(input.Strategy))
                ) && 
                (
                    this.EstimatedUpgradeDuration == input.EstimatedUpgradeDuration ||
                    (this.EstimatedUpgradeDuration != null &&
                    this.EstimatedUpgradeDuration.Equals(input.EstimatedUpgradeDuration))
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
                if (this.Strategy != null)
                    hashCode = hashCode * 59 + this.Strategy.GetHashCode();
                if (this.EstimatedUpgradeDuration != null)
                    hashCode = hashCode * 59 + this.EstimatedUpgradeDuration.GetHashCode();
                return hashCode;
            }
        }
    }
}
