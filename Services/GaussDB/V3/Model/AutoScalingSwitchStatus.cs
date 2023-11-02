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
    /// 开关状态。
    /// </summary>
    public class AutoScalingSwitchStatus 
    {

        /// <summary>
        /// 自动变配开关状态。  取值：  - ON：开启。 - OFF：关闭。
        /// </summary>
        [JsonProperty("scaling_switch", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingSwitch { get; set; }

        /// <summary>
        /// 扩缩规格开关状态。  取值：  - ON：开启。 - OFF：关闭。
        /// </summary>
        [JsonProperty("flavor_switch", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorSwitch { get; set; }

        /// <summary>
        /// 增删只读节点开关状态。  取值：  - ON：开启。 - OFF：关闭。
        /// </summary>
        [JsonProperty("read_only_switch", NullValueHandling = NullValueHandling.Ignore)]
        public string ReadOnlySwitch { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutoScalingSwitchStatus {\n");
            sb.Append("  scalingSwitch: ").Append(ScalingSwitch).Append("\n");
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
            return this.Equals(input as AutoScalingSwitchStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AutoScalingSwitchStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScalingSwitch == input.ScalingSwitch ||
                    (this.ScalingSwitch != null &&
                    this.ScalingSwitch.Equals(input.ScalingSwitch))
                ) && 
                (
                    this.FlavorSwitch == input.FlavorSwitch ||
                    (this.FlavorSwitch != null &&
                    this.FlavorSwitch.Equals(input.FlavorSwitch))
                ) && 
                (
                    this.ReadOnlySwitch == input.ReadOnlySwitch ||
                    (this.ReadOnlySwitch != null &&
                    this.ReadOnlySwitch.Equals(input.ReadOnlySwitch))
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
                if (this.ScalingSwitch != null)
                    hashCode = hashCode * 59 + this.ScalingSwitch.GetHashCode();
                if (this.FlavorSwitch != null)
                    hashCode = hashCode * 59 + this.FlavorSwitch.GetHashCode();
                if (this.ReadOnlySwitch != null)
                    hashCode = hashCode * 59 + this.ReadOnlySwitch.GetHashCode();
                return hashCode;
            }
        }
    }
}
