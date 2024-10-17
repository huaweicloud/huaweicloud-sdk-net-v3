using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 数据加工信息。
    /// </summary>
    public class CreateDataCompareTransformationInfo 
    {

        /// <summary>
        /// 加工规则，值为contentConditionalFilter。
        /// </summary>
        [JsonProperty("transformation_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TransformationType { get; set; }

        /// <summary>
        /// 过滤条件，值为sql条件语句，例如id&gt;100，长度限制256。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDataCompareTransformationInfo {\n");
            sb.Append("  transformationType: ").Append(TransformationType).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDataCompareTransformationInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDataCompareTransformationInfo input)
        {
            if (input == null) return false;
            if (this.TransformationType != input.TransformationType || (this.TransformationType != null && !this.TransformationType.Equals(input.TransformationType))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;

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
                if (this.TransformationType != null) hashCode = hashCode * 59 + this.TransformationType.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }
}
