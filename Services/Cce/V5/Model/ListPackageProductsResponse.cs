using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListPackageProductsResponse : SdkResponse
    {

        /// <summary>
        /// 套餐包列表。
        /// </summary>
        [JsonProperty("package_products", NullValueHandling = NullValueHandling.Ignore)]
        public List<PackageProductDetail> PackageProducts { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPackageProductsResponse {\n");
            sb.Append("  packageProducts: ").Append(PackageProducts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPackageProductsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPackageProductsResponse input)
        {
            if (input == null) return false;
            if (this.PackageProducts != input.PackageProducts || (this.PackageProducts != null && input.PackageProducts != null && !this.PackageProducts.SequenceEqual(input.PackageProducts))) return false;

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
                if (this.PackageProducts != null) hashCode = hashCode * 59 + this.PackageProducts.GetHashCode();
                return hashCode;
            }
        }
    }
}
