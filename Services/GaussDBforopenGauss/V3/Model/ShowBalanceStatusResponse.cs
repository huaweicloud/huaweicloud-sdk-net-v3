using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowBalanceStatusResponse : SdkResponse
    {

        /// <summary>
        /// 平衡状态。
        /// </summary>
        [JsonProperty("balanced", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Balanced { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBalanceStatusResponse {\n");
            sb.Append("  balanced: ").Append(Balanced).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowBalanceStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowBalanceStatusResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Balanced == input.Balanced ||
                    (this.Balanced != null &&
                    this.Balanced.Equals(input.Balanced))
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
                if (this.Balanced != null)
                    hashCode = hashCode * 59 + this.Balanced.GetHashCode();
                return hashCode;
            }
        }
    }
}
