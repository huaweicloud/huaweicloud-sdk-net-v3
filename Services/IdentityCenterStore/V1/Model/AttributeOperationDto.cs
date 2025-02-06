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
    /// An operation that applies to the requested group. This operation might add, replace, or remove an attribute.
    /// </summary>
    public class AttributeOperationDto 
    {

        /// <summary>
        /// 要更新的属性的字符串表示
        /// </summary>
        [JsonProperty("attribute_path", NullValueHandling = NullValueHandling.Ignore)]
        public string AttributePath { get; set; }

        /// <summary>
        /// 要更新的属性值。当属性为对象类型时，此处填写对象的JSON字符串。为null时表示删除对应属性
        /// </summary>
        [JsonProperty("attribute_value", NullValueHandling = NullValueHandling.Ignore)]
        public string AttributeValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttributeOperationDto {\n");
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
            return this.Equals(input as AttributeOperationDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttributeOperationDto input)
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
