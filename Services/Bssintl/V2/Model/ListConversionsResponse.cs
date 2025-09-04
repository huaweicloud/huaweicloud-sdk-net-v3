using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListConversionsResponse : SdkResponse
    {

        /// <summary>
        /// 度量单位的换算信息，具体参见表3。
        /// </summary>
        [JsonProperty("conversions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Conversion> Conversions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListConversionsResponse {\n");
            sb.Append("  conversions: ").Append(Conversions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListConversionsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListConversionsResponse input)
        {
            if (input == null) return false;
            if (this.Conversions != input.Conversions || (this.Conversions != null && input.Conversions != null && !this.Conversions.SequenceEqual(input.Conversions))) return false;

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
                if (this.Conversions != null) hashCode = hashCode * 59 + this.Conversions.GetHashCode();
                return hashCode;
            }
        }
    }
}
