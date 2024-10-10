using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class WafPolicyOptions 
    {

        /// <summary>
        /// 是否开启CC（频率控制）
        /// </summary>
        [JsonProperty("cc", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Cc { get; set; }

        /// <summary>
        /// 是否开启精准访问防护
        /// </summary>
        [JsonProperty("custom", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Custom { get; set; }

        /// <summary>
        /// 是否开启区域封禁防护
        /// </summary>
        [JsonProperty("geoip", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Geoip { get; set; }

        /// <summary>
        /// 是否开启黑白名单防护
        /// </summary>
        [JsonProperty("whiteblackip", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Whiteblackip { get; set; }

        /// <summary>
        /// 是否开启智能CC防护
        /// </summary>
        [JsonProperty("modulex_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ModulexEnabled { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WafPolicyOptions {\n");
            sb.Append("  cc: ").Append(Cc).Append("\n");
            sb.Append("  custom: ").Append(Custom).Append("\n");
            sb.Append("  geoip: ").Append(Geoip).Append("\n");
            sb.Append("  whiteblackip: ").Append(Whiteblackip).Append("\n");
            sb.Append("  modulexEnabled: ").Append(ModulexEnabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WafPolicyOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WafPolicyOptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cc == input.Cc ||
                    (this.Cc != null &&
                    this.Cc.Equals(input.Cc))
                ) && 
                (
                    this.Custom == input.Custom ||
                    (this.Custom != null &&
                    this.Custom.Equals(input.Custom))
                ) && 
                (
                    this.Geoip == input.Geoip ||
                    (this.Geoip != null &&
                    this.Geoip.Equals(input.Geoip))
                ) && 
                (
                    this.Whiteblackip == input.Whiteblackip ||
                    (this.Whiteblackip != null &&
                    this.Whiteblackip.Equals(input.Whiteblackip))
                ) && 
                (
                    this.ModulexEnabled == input.ModulexEnabled ||
                    (this.ModulexEnabled != null &&
                    this.ModulexEnabled.Equals(input.ModulexEnabled))
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
                if (this.Cc != null)
                    hashCode = hashCode * 59 + this.Cc.GetHashCode();
                if (this.Custom != null)
                    hashCode = hashCode * 59 + this.Custom.GetHashCode();
                if (this.Geoip != null)
                    hashCode = hashCode * 59 + this.Geoip.GetHashCode();
                if (this.Whiteblackip != null)
                    hashCode = hashCode * 59 + this.Whiteblackip.GetHashCode();
                if (this.ModulexEnabled != null)
                    hashCode = hashCode * 59 + this.ModulexEnabled.GetHashCode();
                return hashCode;
            }
        }
    }
}
