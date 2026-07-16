using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 训练作业、算法依赖参数。
    /// </summary>
    public class Parameter 
    {

        /// <summary>
        /// 参数名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 参数值。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// 参数描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("constraint", NullValueHandling = NullValueHandling.Ignore)]
        public ParameterConstraint Constraint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("i18n_description", NullValueHandling = NullValueHandling.Ignore)]
        public ParameterI18nDescription I18nDescription { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Parameter {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  constraint: ").Append(Constraint).Append("\n");
            sb.Append("  i18nDescription: ").Append(I18nDescription).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Parameter);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Parameter input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Constraint != input.Constraint || (this.Constraint != null && !this.Constraint.Equals(input.Constraint))) return false;
            if (this.I18nDescription != input.I18nDescription || (this.I18nDescription != null && !this.I18nDescription.Equals(input.I18nDescription))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Constraint != null) hashCode = hashCode * 59 + this.Constraint.GetHashCode();
                if (this.I18nDescription != null) hashCode = hashCode * 59 + this.I18nDescription.GetHashCode();
                return hashCode;
            }
        }
    }
}
