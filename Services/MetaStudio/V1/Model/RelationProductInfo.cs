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
    /// 关联商品
    /// </summary>
    public class RelationProductInfo 
    {

        /// <summary>
        /// 关联商品ID。如果配置，则段落切换回调中会携带该信息。美团平台对应goodsId
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 关联商品标题/名称。如果配置，则段落切换回调中会携带该信息。美团平台对应goodsTitle
        /// </summary>
        [JsonProperty("product_title", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductTitle { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RelationProductInfo {\n");
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
            return this.Equals(input as RelationProductInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RelationProductInfo input)
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
