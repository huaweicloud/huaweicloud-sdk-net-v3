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
    public class Cost 
    {

        /// <summary>
        /// 时间维度值。 如按天维度，该值为yyyy-mm-dd如按月维度，该值为yyyy-mm
        /// </summary>
        [JsonProperty("time_dimension_value", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeDimensionValue { get; set; }

        /// <summary>
        /// 时间单位。 1：天2：月
        /// </summary>
        [JsonProperty("time_measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? TimeMeasureId { get; set; }

        /// <summary>
        /// 应付或实付的成本金额或均摊金额，具体取决于请求参数。
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        /// 官网价金额。
        /// </summary>
        [JsonProperty("official_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string OfficialAmount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Cost {\n");
            sb.Append("  timeDimensionValue: ").Append(TimeDimensionValue).Append("\n");
            sb.Append("  timeMeasureId: ").Append(TimeMeasureId).Append("\n");
            sb.Append("  amount: ").Append(Amount).Append("\n");
            sb.Append("  officialAmount: ").Append(OfficialAmount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Cost);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Cost input)
        {
            if (input == null) return false;
            if (this.TimeDimensionValue != input.TimeDimensionValue || (this.TimeDimensionValue != null && !this.TimeDimensionValue.Equals(input.TimeDimensionValue))) return false;
            if (this.TimeMeasureId != input.TimeMeasureId || (this.TimeMeasureId != null && !this.TimeMeasureId.Equals(input.TimeMeasureId))) return false;
            if (this.Amount != input.Amount || (this.Amount != null && !this.Amount.Equals(input.Amount))) return false;
            if (this.OfficialAmount != input.OfficialAmount || (this.OfficialAmount != null && !this.OfficialAmount.Equals(input.OfficialAmount))) return false;

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
                if (this.TimeDimensionValue != null) hashCode = hashCode * 59 + this.TimeDimensionValue.GetHashCode();
                if (this.TimeMeasureId != null) hashCode = hashCode * 59 + this.TimeMeasureId.GetHashCode();
                if (this.Amount != null) hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.OfficialAmount != null) hashCode = hashCode * 59 + this.OfficialAmount.GetHashCode();
                return hashCode;
            }
        }
    }
}
