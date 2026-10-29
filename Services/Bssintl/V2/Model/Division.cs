using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Division 
    {

        /// <summary>
        /// 阶梯起始值
        /// </summary>
        [JsonProperty("begin_value", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? BeginValue { get; set; }

        /// <summary>
        /// 阶梯结束值
        /// </summary>
        [JsonProperty("end_value", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? EndValue { get; set; }

        /// <summary>
        /// 阶梯起始单位
        /// </summary>
        [JsonProperty("begin_unit", NullValueHandling = NullValueHandling.Ignore)]
        public int? BeginUnit { get; set; }

        /// <summary>
        /// 阶梯结束单位
        /// </summary>
        [JsonProperty("end_unit", NullValueHandling = NullValueHandling.Ignore)]
        public int? EndUnit { get; set; }

        /// <summary>
        /// 阶梯官网价
        /// </summary>
        [JsonProperty("official_price", NullValueHandling = NullValueHandling.Ignore)]
        public string OfficialPrice { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Division {\n");
            sb.Append("  beginValue: ").Append(BeginValue).Append("\n");
            sb.Append("  endValue: ").Append(EndValue).Append("\n");
            sb.Append("  beginUnit: ").Append(BeginUnit).Append("\n");
            sb.Append("  endUnit: ").Append(EndUnit).Append("\n");
            sb.Append("  officialPrice: ").Append(OfficialPrice).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Division);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Division input)
        {
            if (input == null) return false;
            if (this.BeginValue != input.BeginValue || (this.BeginValue != null && !this.BeginValue.Equals(input.BeginValue))) return false;
            if (this.EndValue != input.EndValue || (this.EndValue != null && !this.EndValue.Equals(input.EndValue))) return false;
            if (this.BeginUnit != input.BeginUnit || (this.BeginUnit != null && !this.BeginUnit.Equals(input.BeginUnit))) return false;
            if (this.EndUnit != input.EndUnit || (this.EndUnit != null && !this.EndUnit.Equals(input.EndUnit))) return false;
            if (this.OfficialPrice != input.OfficialPrice || (this.OfficialPrice != null && !this.OfficialPrice.Equals(input.OfficialPrice))) return false;

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
                if (this.BeginValue != null) hashCode = hashCode * 59 + this.BeginValue.GetHashCode();
                if (this.EndValue != null) hashCode = hashCode * 59 + this.EndValue.GetHashCode();
                if (this.BeginUnit != null) hashCode = hashCode * 59 + this.BeginUnit.GetHashCode();
                if (this.EndUnit != null) hashCode = hashCode * 59 + this.EndUnit.GetHashCode();
                if (this.OfficialPrice != null) hashCode = hashCode * 59 + this.OfficialPrice.GetHashCode();
                return hashCode;
            }
        }
    }
}
