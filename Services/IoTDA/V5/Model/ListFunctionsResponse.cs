using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListFunctionsResponse : SdkResponse
    {

        /// <summary>
        /// **参数说明**：编解码函数列表。
        /// </summary>
        [JsonProperty("product_functions", NullValueHandling = NullValueHandling.Ignore)]
        public List<FunctionDTO> ProductFunctions { get; set; }

        /// <summary>
        /// **参数说明**：满足查询条件的记录总数。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public long? Count { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFunctionsResponse {\n");
            sb.Append("  productFunctions: ").Append(ProductFunctions).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListFunctionsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFunctionsResponse input)
        {
            if (input == null) return false;
            if (this.ProductFunctions != input.ProductFunctions || (this.ProductFunctions != null && input.ProductFunctions != null && !this.ProductFunctions.SequenceEqual(input.ProductFunctions))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;

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
                if (this.ProductFunctions != null) hashCode = hashCode * 59 + this.ProductFunctions.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                return hashCode;
            }
        }
    }
}
