using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DelResourcesReq 
    {

        /// <summary>
        /// 手动创建，选择资源层级为子维度时的资源信息。只需要传递删除的资源
        /// </summary>
        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<Resource> Resources { get; set; }

        /// <summary>
        /// 手动创建，选择资源层级为云产品时的资源详情。只需要传递删除的资源
        /// </summary>
        [JsonProperty("product_resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProductResource> ProductResources { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DelResourcesReq {\n");
            sb.Append("  resources: ").Append(Resources).Append("\n");
            sb.Append("  productResources: ").Append(ProductResources).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DelResourcesReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DelResourcesReq input)
        {
            if (input == null) return false;
            if (this.Resources != input.Resources || (this.Resources != null && input.Resources != null && !this.Resources.SequenceEqual(input.Resources))) return false;
            if (this.ProductResources != input.ProductResources || (this.ProductResources != null && input.ProductResources != null && !this.ProductResources.SequenceEqual(input.ProductResources))) return false;

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
                if (this.Resources != null) hashCode = hashCode * 59 + this.Resources.GetHashCode();
                if (this.ProductResources != null) hashCode = hashCode * 59 + this.ProductResources.GetHashCode();
                return hashCode;
            }
        }
    }
}
