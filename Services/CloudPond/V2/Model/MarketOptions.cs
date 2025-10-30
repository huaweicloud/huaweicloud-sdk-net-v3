using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudPond.V2.Model
{
    /// <summary>
    /// 计费信息
    /// </summary>
    public class MarketOptions 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ChargeMode? ChargeMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("prepaid_options", NullValueHandling = NullValueHandling.Ignore)]
        public PrepaidOptions PrepaidOptions { get; set; }

        /// <summary>
        /// 销售策略列表
        /// </summary>
        [JsonProperty("strategies", NullValueHandling = NullValueHandling.Ignore)]
        public List<Strategy> Strategies { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MarketOptions {\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("  prepaidOptions: ").Append(PrepaidOptions).Append("\n");
            sb.Append("  strategies: ").Append(Strategies).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MarketOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MarketOptions input)
        {
            if (input == null) return false;
            if (this.ChargeMode != input.ChargeMode || (this.ChargeMode != null && !this.ChargeMode.Equals(input.ChargeMode))) return false;
            if (this.PrepaidOptions != input.PrepaidOptions || (this.PrepaidOptions != null && !this.PrepaidOptions.Equals(input.PrepaidOptions))) return false;
            if (this.Strategies != input.Strategies || (this.Strategies != null && input.Strategies != null && !this.Strategies.SequenceEqual(input.Strategies))) return false;

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
                if (this.ChargeMode != null) hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                if (this.PrepaidOptions != null) hashCode = hashCode * 59 + this.PrepaidOptions.GetHashCode();
                if (this.Strategies != null) hashCode = hashCode * 59 + this.Strategies.GetHashCode();
                return hashCode;
            }
        }
    }
}
