using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListEngineProductsResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 总数。 **取值范围**： 大于等于0。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Total { get; set; }

        /// <summary>
        /// **参数解释**： 下个分页的offset。 **取值范围**： 大于等于0。
        /// </summary>
        [JsonProperty("next_offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? NextOffset { get; set; }

        /// <summary>
        /// **参数解释**： 上个分页的offset。 **取值范围**： 大于等于0。
        /// </summary>
        [JsonProperty("previous_offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? PreviousOffset { get; set; }

        /// <summary>
        /// **参数解释**： 引擎类型。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("engine", NullValueHandling = NullValueHandling.Ignore)]
        public string Engine { get; set; }

        /// <summary>
        /// **参数解释**： 支持的版本。
        /// </summary>
        [JsonProperty("versions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Versions { get; set; }

        /// <summary>
        /// **参数解释**： 产品详情列表。
        /// </summary>
        [JsonProperty("products", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProductEntity> Products { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEngineProductsResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  nextOffset: ").Append(NextOffset).Append("\n");
            sb.Append("  previousOffset: ").Append(PreviousOffset).Append("\n");
            sb.Append("  engine: ").Append(Engine).Append("\n");
            sb.Append("  versions: ").Append(Versions).Append("\n");
            sb.Append("  products: ").Append(Products).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEngineProductsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEngineProductsResponse input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.NextOffset != input.NextOffset || (this.NextOffset != null && !this.NextOffset.Equals(input.NextOffset))) return false;
            if (this.PreviousOffset != input.PreviousOffset || (this.PreviousOffset != null && !this.PreviousOffset.Equals(input.PreviousOffset))) return false;
            if (this.Engine != input.Engine || (this.Engine != null && !this.Engine.Equals(input.Engine))) return false;
            if (this.Versions != input.Versions || (this.Versions != null && input.Versions != null && !this.Versions.SequenceEqual(input.Versions))) return false;
            if (this.Products != input.Products || (this.Products != null && input.Products != null && !this.Products.SequenceEqual(input.Products))) return false;

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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.NextOffset != null) hashCode = hashCode * 59 + this.NextOffset.GetHashCode();
                if (this.PreviousOffset != null) hashCode = hashCode * 59 + this.PreviousOffset.GetHashCode();
                if (this.Engine != null) hashCode = hashCode * 59 + this.Engine.GetHashCode();
                if (this.Versions != null) hashCode = hashCode * 59 + this.Versions.GetHashCode();
                if (this.Products != null) hashCode = hashCode * 59 + this.Products.GetHashCode();
                return hashCode;
            }
        }
    }
}
