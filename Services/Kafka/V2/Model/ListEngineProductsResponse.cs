using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListEngineProductsResponse : SdkResponse
    {

        /// <summary>
        /// 分布式消息服务的产品类型。
        /// </summary>
        [JsonProperty("engine", NullValueHandling = NullValueHandling.Ignore)]
        public string Engine { get; set; }

        /// <summary>
        /// 支持的产品版本类型。
        /// </summary>
        [JsonProperty("versions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Versions { get; set; }

        /// <summary>
        /// 产品规格的详细信息。
        /// </summary>
        [JsonProperty("products", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListEngineProductsEntity> Products { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEngineProductsResponse {\n");
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
                if (this.Engine != null) hashCode = hashCode * 59 + this.Engine.GetHashCode();
                if (this.Versions != null) hashCode = hashCode * 59 + this.Versions.GetHashCode();
                if (this.Products != null) hashCode = hashCode * 59 + this.Products.GetHashCode();
                return hashCode;
            }
        }
    }
}
