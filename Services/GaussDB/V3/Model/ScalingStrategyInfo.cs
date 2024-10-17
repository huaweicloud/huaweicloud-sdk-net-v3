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
    /// 自动变配策略。
    /// </summary>
    public class ScalingStrategyInfo 
    {

        /// <summary>
        /// 扩缩规格开关。 - ON：开启。 - OFF：关闭。
        /// </summary>
        [JsonProperty("flavor_switch", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorSwitch { get; set; }

        /// <summary>
        /// 增删只读节点开关。 - ON：开启。 - OFF：关闭。
        /// </summary>
        [JsonProperty("read_only_switch", NullValueHandling = NullValueHandling.Ignore)]
        public string ReadOnlySwitch { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScalingStrategyInfo {\n");
            sb.Append("  flavorSwitch: ").Append(FlavorSwitch).Append("\n");
            sb.Append("  readOnlySwitch: ").Append(ReadOnlySwitch).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScalingStrategyInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScalingStrategyInfo input)
        {
            if (input == null) return false;
            if (this.FlavorSwitch != input.FlavorSwitch || (this.FlavorSwitch != null && !this.FlavorSwitch.Equals(input.FlavorSwitch))) return false;
            if (this.ReadOnlySwitch != input.ReadOnlySwitch || (this.ReadOnlySwitch != null && !this.ReadOnlySwitch.Equals(input.ReadOnlySwitch))) return false;

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
                if (this.FlavorSwitch != null) hashCode = hashCode * 59 + this.FlavorSwitch.GetHashCode();
                if (this.ReadOnlySwitch != null) hashCode = hashCode * 59 + this.ReadOnlySwitch.GetHashCode();
                return hashCode;
            }
        }
    }
}
