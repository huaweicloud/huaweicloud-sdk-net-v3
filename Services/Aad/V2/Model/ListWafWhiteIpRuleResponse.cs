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
    /// Response Object
    /// </summary>
    public class ListWafWhiteIpRuleResponse : SdkResponse
    {

        /// <summary>
        /// total
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// black
        /// </summary>
        [JsonProperty("black", NullValueHandling = NullValueHandling.Ignore)]
        public List<BlackWhiteListRule> Black { get; set; }

        /// <summary>
        /// white
        /// </summary>
        [JsonProperty("white", NullValueHandling = NullValueHandling.Ignore)]
        public List<BlackWhiteListRule> White { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListWafWhiteIpRuleResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  black: ").Append(Black).Append("\n");
            sb.Append("  white: ").Append(White).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListWafWhiteIpRuleResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListWafWhiteIpRuleResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Black == input.Black ||
                    this.Black != null &&
                    input.Black != null &&
                    this.Black.SequenceEqual(input.Black)
                ) && 
                (
                    this.White == input.White ||
                    this.White != null &&
                    input.White != null &&
                    this.White.SequenceEqual(input.White)
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
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Black != null)
                    hashCode = hashCode * 59 + this.Black.GetHashCode();
                if (this.White != null)
                    hashCode = hashCode * 59 + this.White.GetHashCode();
                return hashCode;
            }
        }
    }
}
