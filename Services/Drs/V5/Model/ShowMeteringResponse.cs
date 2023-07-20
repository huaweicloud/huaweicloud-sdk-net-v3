using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowMeteringResponse : SdkResponse
    {

        /// <summary>
        /// 资源信息列表。
        /// </summary>
        [JsonProperty("product_info_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProductInfo> ProductInfoList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowMeteringResponse {\n");
            sb.Append("  productInfoList: ").Append(ProductInfoList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowMeteringResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowMeteringResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProductInfoList == input.ProductInfoList ||
                    this.ProductInfoList != null &&
                    input.ProductInfoList != null &&
                    this.ProductInfoList.SequenceEqual(input.ProductInfoList)
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
                if (this.ProductInfoList != null)
                    hashCode = hashCode * 59 + this.ProductInfoList.GetHashCode();
                return hashCode;
            }
        }
    }
}
