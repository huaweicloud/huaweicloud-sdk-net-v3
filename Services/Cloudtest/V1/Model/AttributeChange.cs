using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 对象，包括编号与名称
    /// </summary>
    public class AttributeChange 
    {

        /// <summary>
        /// 变更后的取值
        /// </summary>
        [JsonProperty("new_value", NullValueHandling = NullValueHandling.Ignore)]
        public string NewValue { get; set; }

        /// <summary>
        /// 变更前的取值
        /// </summary>
        [JsonProperty("old_value", NullValueHandling = NullValueHandling.Ignore)]
        public string OldValue { get; set; }

        /// <summary>
        /// 发生变更的测试计划属性
        /// </summary>
        [JsonProperty("attribute_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AttributeType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttributeChange {\n");
            sb.Append("  newValue: ").Append(NewValue).Append("\n");
            sb.Append("  oldValue: ").Append(OldValue).Append("\n");
            sb.Append("  attributeType: ").Append(AttributeType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttributeChange);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttributeChange input)
        {
            if (input == null) return false;
            if (this.NewValue != input.NewValue || (this.NewValue != null && !this.NewValue.Equals(input.NewValue))) return false;
            if (this.OldValue != input.OldValue || (this.OldValue != null && !this.OldValue.Equals(input.OldValue))) return false;
            if (this.AttributeType != input.AttributeType || (this.AttributeType != null && !this.AttributeType.Equals(input.AttributeType))) return false;

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
                if (this.NewValue != null) hashCode = hashCode * 59 + this.NewValue.GetHashCode();
                if (this.OldValue != null) hashCode = hashCode * 59 + this.OldValue.GetHashCode();
                if (this.AttributeType != null) hashCode = hashCode * 59 + this.AttributeType.GetHashCode();
                return hashCode;
            }
        }
    }
}
