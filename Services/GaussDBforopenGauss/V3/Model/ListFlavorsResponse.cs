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
    public class ListFlavorsResponse : SdkResponse
    {

        /// <summary>
        /// 实例规格信息。
        /// </summary>
        [JsonProperty("flavors", NullValueHandling = NullValueHandling.Ignore)]
        public List<Flavor> Flavors { get; set; }

        /// <summary>
        /// 查询的记录总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFlavorsResponse {\n");
            sb.Append("  flavors: ").Append(Flavors).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListFlavorsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFlavorsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Flavors == input.Flavors ||
                    this.Flavors != null &&
                    input.Flavors != null &&
                    this.Flavors.SequenceEqual(input.Flavors)
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
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
                if (this.Flavors != null)
                    hashCode = hashCode * 59 + this.Flavors.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
