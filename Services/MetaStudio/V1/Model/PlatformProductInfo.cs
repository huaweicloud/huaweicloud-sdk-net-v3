using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 第三方直播平台商品详情
    /// </summary>
    public class PlatformProductInfo 
    {

        /// <summary>
        /// 商品id
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [JsonProperty("product_title", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductTitle { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlatformProductInfo {\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  productTitle: ").Append(ProductTitle).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PlatformProductInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PlatformProductInfo input)
        {
            if (input == null) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.ProductTitle != input.ProductTitle || (this.ProductTitle != null && !this.ProductTitle.Equals(input.ProductTitle))) return false;

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
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.ProductTitle != null) hashCode = hashCode * 59 + this.ProductTitle.GetHashCode();
                return hashCode;
            }
        }
    }
}
