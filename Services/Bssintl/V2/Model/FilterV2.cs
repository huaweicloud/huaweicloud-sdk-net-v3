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
    /// 
    /// </summary>
    public class FilterV2 
    {

        /// <summary>
        /// 运算符，0：仅包含1：仅排除 此参数不携带或携带值为null时，不作为筛选条件。
        /// </summary>
        [JsonProperty("operator", NullValueHandling = NullValueHandling.Ignore)]
        public int? Operator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("filter_factor", NullValueHandling = NullValueHandling.Ignore)]
        public FilterFactor FilterFactor { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FilterV2 {\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  filterFactor: ").Append(FilterFactor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FilterV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FilterV2 input)
        {
            if (input == null) return false;
            if (this.Operator != input.Operator || (this.Operator != null && !this.Operator.Equals(input.Operator))) return false;
            if (this.FilterFactor != input.FilterFactor || (this.FilterFactor != null && !this.FilterFactor.Equals(input.FilterFactor))) return false;

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
                if (this.Operator != null) hashCode = hashCode * 59 + this.Operator.GetHashCode();
                if (this.FilterFactor != null) hashCode = hashCode * 59 + this.FilterFactor.GetHashCode();
                return hashCode;
            }
        }
    }
}
