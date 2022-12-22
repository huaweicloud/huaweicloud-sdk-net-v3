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
    /// Response Object
    /// </summary>
    public class UpdateFunctionReservedInstancesCountResponse : SdkResponse
    {

        /// <summary>
        /// 预留实例个数
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 是否开启闲置模式配置
        /// </summary>
        [JsonProperty("idle_mode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IdleMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tactics_config", NullValueHandling = NullValueHandling.Ignore)]
        public TacticsConfig TacticsConfig { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateFunctionReservedInstancesCountResponse {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  idleMode: ").Append(IdleMode).Append("\n");
            sb.Append("  tacticsConfig: ").Append(TacticsConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateFunctionReservedInstancesCountResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateFunctionReservedInstancesCountResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.IdleMode == input.IdleMode ||
                    (this.IdleMode != null &&
                    this.IdleMode.Equals(input.IdleMode))
                ) && 
                (
                    this.TacticsConfig == input.TacticsConfig ||
                    (this.TacticsConfig != null &&
                    this.TacticsConfig.Equals(input.TacticsConfig))
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
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.IdleMode != null)
                    hashCode = hashCode * 59 + this.IdleMode.GetHashCode();
                if (this.TacticsConfig != null)
                    hashCode = hashCode * 59 + this.TacticsConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
