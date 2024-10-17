using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ImageSearch.V2.Model
{
    /// <summary>
    /// 数值范围参数结构体。
    /// </summary>
    public class RangeParam 
    {

        /// <summary>
        /// 数值下界，默认包含该下界。
        /// </summary>
        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public double? From { get; set; }

        /// <summary>
        /// 数值上界，默认包含该上界。
        /// </summary>
        [JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
        public double? To { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RangeParam {\n");
            sb.Append("  from: ").Append(From).Append("\n");
            sb.Append("  to: ").Append(To).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RangeParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RangeParam input)
        {
            if (input == null) return false;
            if (this.From != input.From || (this.From != null && !this.From.Equals(input.From))) return false;
            if (this.To != input.To || (this.To != null && !this.To.Equals(input.To))) return false;

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
                if (this.From != null) hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.To != null) hashCode = hashCode * 59 + this.To.GetHashCode();
                return hashCode;
            }
        }
    }
}
