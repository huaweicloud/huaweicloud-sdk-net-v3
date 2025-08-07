using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListMarketplaceEngineProductsResponse : SdkResponse
    {

        /// <summary>
        /// 云市场引擎商品列表。
        /// </summary>
        [JsonProperty("marketplace_engine_products", NullValueHandling = NullValueHandling.Ignore)]
        public List<MarketplaceEngineProduct> MarketplaceEngineProducts { get; set; }

        /// <summary>
        /// 云市场引擎商品总数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListMarketplaceEngineProductsResponse {\n");
            sb.Append("  marketplaceEngineProducts: ").Append(MarketplaceEngineProducts).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListMarketplaceEngineProductsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMarketplaceEngineProductsResponse input)
        {
            if (input == null) return false;
            if (this.MarketplaceEngineProducts != input.MarketplaceEngineProducts || (this.MarketplaceEngineProducts != null && input.MarketplaceEngineProducts != null && !this.MarketplaceEngineProducts.SequenceEqual(input.MarketplaceEngineProducts))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;

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
                if (this.MarketplaceEngineProducts != null) hashCode = hashCode * 59 + this.MarketplaceEngineProducts.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
