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
    public class ProductInstance 
    {

        /// <summary>
        /// 资源首层维度，如：弹性云服务器，则维度为instance_id；”。
        /// </summary>
        [JsonProperty("first_dimension_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstDimensionName { get; set; }

        /// <summary>
        /// 资源首层维度值，为资源的实例ID，如：4270ff17-aba3-4138-89fa-820594c39755。
        /// </summary>
        [JsonProperty("first_dimension_value", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstDimensionValue { get; set; }

        /// <summary>
        /// 资源名称
        /// </summary>
        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductInstance {\n");
            sb.Append("  firstDimensionName: ").Append(FirstDimensionName).Append("\n");
            sb.Append("  firstDimensionValue: ").Append(FirstDimensionValue).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProductInstance);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProductInstance input)
        {
            if (input == null) return false;
            if (this.FirstDimensionName != input.FirstDimensionName || (this.FirstDimensionName != null && !this.FirstDimensionName.Equals(input.FirstDimensionName))) return false;
            if (this.FirstDimensionValue != input.FirstDimensionValue || (this.FirstDimensionValue != null && !this.FirstDimensionValue.Equals(input.FirstDimensionValue))) return false;
            if (this.ResourceName != input.ResourceName || (this.ResourceName != null && !this.ResourceName.Equals(input.ResourceName))) return false;

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
                if (this.FirstDimensionName != null) hashCode = hashCode * 59 + this.FirstDimensionName.GetHashCode();
                if (this.FirstDimensionValue != null) hashCode = hashCode * 59 + this.FirstDimensionValue.GetHashCode();
                if (this.ResourceName != null) hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                return hashCode;
            }
        }
    }
}
