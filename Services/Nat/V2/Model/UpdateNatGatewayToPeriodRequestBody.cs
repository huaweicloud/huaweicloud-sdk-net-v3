using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Nat.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateNatGatewayToPeriodRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("prepaid_options", NullValueHandling = NullValueHandling.Ignore)]
        public PrepaidOptions PrepaidOptions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateNatGatewayToPeriodRequestBody {\n");
            sb.Append("  prepaidOptions: ").Append(PrepaidOptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateNatGatewayToPeriodRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateNatGatewayToPeriodRequestBody input)
        {
            if (input == null) return false;
            if (this.PrepaidOptions != input.PrepaidOptions || (this.PrepaidOptions != null && !this.PrepaidOptions.Equals(input.PrepaidOptions))) return false;

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
                if (this.PrepaidOptions != null) hashCode = hashCode * 59 + this.PrepaidOptions.GetHashCode();
                return hashCode;
            }
        }
    }
}
