using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowConnectorResourceInfoResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 是否售罄。 **取值范围**： - true：售罄。 - false：未售罄。
        /// </summary>
        [JsonProperty("soldOut", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SoldOut { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowConnectorResourceInfoResponse {\n");
            sb.Append("  soldOut: ").Append(SoldOut).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowConnectorResourceInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowConnectorResourceInfoResponse input)
        {
            if (input == null) return false;
            if (this.SoldOut != input.SoldOut || (this.SoldOut != null && !this.SoldOut.Equals(input.SoldOut))) return false;

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
                if (this.SoldOut != null) hashCode = hashCode * 59 + this.SoldOut.GetHashCode();
                return hashCode;
            }
        }
    }
}
