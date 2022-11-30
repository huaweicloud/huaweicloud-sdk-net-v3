using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class OptionalFlavorsInfo 
    {

        /// <summary>
        /// 扩容节点时可用的规格列表。
        /// </summary>
        [JsonProperty("optional_flavor_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ComputeFlavor> OptionalFlavorList { get; set; }

        /// <summary>
        /// 总记录数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptionalFlavorsInfo {\n");
            sb.Append("  optionalFlavorList: ").Append(OptionalFlavorList).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OptionalFlavorsInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OptionalFlavorsInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OptionalFlavorList == input.OptionalFlavorList ||
                    this.OptionalFlavorList != null &&
                    input.OptionalFlavorList != null &&
                    this.OptionalFlavorList.SequenceEqual(input.OptionalFlavorList)
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
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
                if (this.OptionalFlavorList != null)
                    hashCode = hashCode * 59 + this.OptionalFlavorList.GetHashCode();
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
