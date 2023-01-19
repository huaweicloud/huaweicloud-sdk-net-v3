using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DiffDetails 
    {

        /// <summary>
        /// 参数名称
        /// </summary>
        [JsonProperty("parameter_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ParameterName { get; set; }

        /// <summary>
        /// 比较参数模板的参数值。
        /// </summary>
        [JsonProperty("source_value", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceValue { get; set; }

        /// <summary>
        /// 目标参数模板的参数值。
        /// </summary>
        [JsonProperty("target_value", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiffDetails {\n");
            sb.Append("  parameterName: ").Append(ParameterName).Append("\n");
            sb.Append("  sourceValue: ").Append(SourceValue).Append("\n");
            sb.Append("  targetValue: ").Append(TargetValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DiffDetails);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DiffDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ParameterName == input.ParameterName ||
                    (this.ParameterName != null &&
                    this.ParameterName.Equals(input.ParameterName))
                ) && 
                (
                    this.SourceValue == input.SourceValue ||
                    (this.SourceValue != null &&
                    this.SourceValue.Equals(input.SourceValue))
                ) && 
                (
                    this.TargetValue == input.TargetValue ||
                    (this.TargetValue != null &&
                    this.TargetValue.Equals(input.TargetValue))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ParameterName != null)
                    hashCode = hashCode * 59 + this.ParameterName.GetHashCode();
                if (this.SourceValue != null)
                    hashCode = hashCode * 59 + this.SourceValue.GetHashCode();
                if (this.TargetValue != null)
                    hashCode = hashCode * 59 + this.TargetValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
