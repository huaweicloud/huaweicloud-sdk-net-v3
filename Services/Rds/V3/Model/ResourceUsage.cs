using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ResourceUsage 
    {

        /// <summary>
        /// 当前使用量。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public double? Value { get; set; }

        /// <summary>
        /// 总量。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public double? Total { get; set; }

        /// <summary>
        /// 对比值。
        /// </summary>
        [JsonProperty("contrast", NullValueHandling = NullValueHandling.Ignore)]
        public double? Contrast { get; set; }

        /// <summary>
        /// 单位。
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceUsage {\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  contrast: ").Append(Contrast).Append("\n");
            sb.Append("  unit: ").Append(Unit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceUsage);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceUsage input)
        {
            if (input == null) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.Contrast != input.Contrast || (this.Contrast != null && !this.Contrast.Equals(input.Contrast))) return false;
            if (this.Unit != input.Unit || (this.Unit != null && !this.Unit.Equals(input.Unit))) return false;

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
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Contrast != null) hashCode = hashCode * 59 + this.Contrast.GetHashCode();
                if (this.Unit != null) hashCode = hashCode * 59 + this.Unit.GetHashCode();
                return hashCode;
            }
        }
    }
}
