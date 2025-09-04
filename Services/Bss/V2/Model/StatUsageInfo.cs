using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bss.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class StatUsageInfo 
    {

        /// <summary>
        /// 统计时间点，UTC时间，格式为YYYY-MM-DDTHH:MM:SSZ。
        /// </summary>
        [JsonProperty("stat_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StatTime { get; set; }

        /// <summary>
        /// 保底带宽。  说明： 该字段为预留值，当前始终为空；当场景为95增强时才返回数值。
        /// </summary>
        [JsonProperty("guaranteed_band_width", NullValueHandling = NullValueHandling.Ignore)]
        public string GuaranteedBandWidth { get; set; }

        /// <summary>
        /// 用量。
        /// </summary>
        [JsonProperty("usage", NullValueHandling = NullValueHandling.Ignore)]
        public string Usage { get; set; }

        /// <summary>
        /// 单位，您可以调用查询度量单位列表接口获取。带宽和用量使用相同的计量单位。
        /// </summary>
        [JsonProperty("measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MeasureId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatUsageInfo {\n");
            sb.Append("  statTime: ").Append(StatTime).Append("\n");
            sb.Append("  guaranteedBandWidth: ").Append(GuaranteedBandWidth).Append("\n");
            sb.Append("  usage: ").Append(Usage).Append("\n");
            sb.Append("  measureId: ").Append(MeasureId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StatUsageInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StatUsageInfo input)
        {
            if (input == null) return false;
            if (this.StatTime != input.StatTime || (this.StatTime != null && !this.StatTime.Equals(input.StatTime))) return false;
            if (this.GuaranteedBandWidth != input.GuaranteedBandWidth || (this.GuaranteedBandWidth != null && !this.GuaranteedBandWidth.Equals(input.GuaranteedBandWidth))) return false;
            if (this.Usage != input.Usage || (this.Usage != null && !this.Usage.Equals(input.Usage))) return false;
            if (this.MeasureId != input.MeasureId || (this.MeasureId != null && !this.MeasureId.Equals(input.MeasureId))) return false;

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
                if (this.StatTime != null) hashCode = hashCode * 59 + this.StatTime.GetHashCode();
                if (this.GuaranteedBandWidth != null) hashCode = hashCode * 59 + this.GuaranteedBandWidth.GetHashCode();
                if (this.Usage != null) hashCode = hashCode * 59 + this.Usage.GetHashCode();
                if (this.MeasureId != null) hashCode = hashCode * 59 + this.MeasureId.GetHashCode();
                return hashCode;
            }
        }
    }
}
