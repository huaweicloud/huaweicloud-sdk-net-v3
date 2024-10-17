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
    /// 函数网络配置。
    /// </summary>
    public class NetworkControlConfig 
    {

        /// <summary>
        /// 禁止公网访问开关。
        /// </summary>
        [JsonProperty("disable_public_network", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisablePublicNetwork { get; set; }

        /// <summary>
        /// 指定触发函数vpc配置。
        /// </summary>
        [JsonProperty("trigger_access_vpcs", NullValueHandling = NullValueHandling.Ignore)]
        public List<VpcConfig> TriggerAccessVpcs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NetworkControlConfig {\n");
            sb.Append("  disablePublicNetwork: ").Append(DisablePublicNetwork).Append("\n");
            sb.Append("  triggerAccessVpcs: ").Append(TriggerAccessVpcs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NetworkControlConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NetworkControlConfig input)
        {
            if (input == null) return false;
            if (this.DisablePublicNetwork != input.DisablePublicNetwork || (this.DisablePublicNetwork != null && !this.DisablePublicNetwork.Equals(input.DisablePublicNetwork))) return false;
            if (this.TriggerAccessVpcs != input.TriggerAccessVpcs || (this.TriggerAccessVpcs != null && input.TriggerAccessVpcs != null && !this.TriggerAccessVpcs.SequenceEqual(input.TriggerAccessVpcs))) return false;

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
                if (this.DisablePublicNetwork != null) hashCode = hashCode * 59 + this.DisablePublicNetwork.GetHashCode();
                if (this.TriggerAccessVpcs != null) hashCode = hashCode * 59 + this.TriggerAccessVpcs.GetHashCode();
                return hashCode;
            }
        }
    }
}
