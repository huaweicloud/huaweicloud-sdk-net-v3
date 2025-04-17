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
    public class ProductResource 
    {

        /// <summary>
        /// 资源所属的云产品，一般由\&quot;服务命名空间,服务首层维度名称\&quot;组成，如\&quot;SYS.ECS,instance_id\&quot;
        /// </summary>
        [JsonProperty("product_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductName { get; set; }

        /// <summary>
        /// 查询服务的命名空间，各服务命名空间请参考“[服务命名空间](ces_03_0059.xml)”
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 产品实例详情
        /// </summary>
        [JsonProperty("product_instances", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProductInstance> ProductInstances { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductResource {\n");
            sb.Append("  productName: ").Append(ProductName).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  productInstances: ").Append(ProductInstances).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProductResource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProductResource input)
        {
            if (input == null) return false;
            if (this.ProductName != input.ProductName || (this.ProductName != null && !this.ProductName.Equals(input.ProductName))) return false;
            if (this.Namespace != input.Namespace || (this.Namespace != null && !this.Namespace.Equals(input.Namespace))) return false;
            if (this.ProductInstances != input.ProductInstances || (this.ProductInstances != null && input.ProductInstances != null && !this.ProductInstances.SequenceEqual(input.ProductInstances))) return false;

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
                if (this.ProductName != null) hashCode = hashCode * 59 + this.ProductName.GetHashCode();
                if (this.Namespace != null) hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.ProductInstances != null) hashCode = hashCode * 59 + this.ProductInstances.GetHashCode();
                return hashCode;
            }
        }
    }
}
