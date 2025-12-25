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
        /// **参数解释** 当资源添加方式为手动创建、资源层级为子维度时，删除资源分组中的资源只需传递删除的资源信息 **约束限制** 包含的资源对象个数为1到1000 
        /// </summary>
        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<Resource> Resources { get; set; }

        /// <summary>
        /// **参数解释** 当资源添加方式为手动创建、资源层级为子维度时，删除资源分组中的资源只需传递删除的资源信息 **约束限制** 包含的资源个数为1到50个 
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
