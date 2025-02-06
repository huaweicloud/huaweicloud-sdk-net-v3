using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterStore.V1.Model
{
    /// <summary>
    /// An entity attribute that&#39;s unique to a specific entity.
    /// </summary>
    public class UniqueAttributeDto 
    {

        /// <summary>
        /// 属性路径
        /// </summary>
        [JsonProperty("attribute_path", NullValueHandling = NullValueHandling.Ignore)]
        public string AttributePath { get; set; }

        /// <summary>
        /// 属性的值
        /// </summary>
        [JsonProperty("attribute_value", NullValueHandling = NullValueHandling.Ignore)]
        public string AttributeValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UniqueAttributeDto {\n");
            sb.Append("  attributePath: ").Append(AttributePath).Append("\n");
            sb.Append("  attributeValue: ").Append(AttributeValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UniqueAttributeDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UniqueAttributeDto input)
        {
            if (input == null) return false;
            if (this.AttributePath != input.AttributePath || (this.AttributePath != null && !this.AttributePath.Equals(input.AttributePath))) return false;
            if (this.AttributeValue != input.AttributeValue || (this.AttributeValue != null && !this.AttributeValue.Equals(input.AttributeValue))) return false;

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
                if (this.AttributePath != null) hashCode = hashCode * 59 + this.AttributePath.GetHashCode();
                if (this.AttributeValue != null) hashCode = hashCode * 59 + this.AttributeValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
