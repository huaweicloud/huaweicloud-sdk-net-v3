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
    public class StatUsageSummaryInfo 
    {

        /// <summary>
        /// 资源ID。
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 有效天数，精度最高返回小数点后20位。  说明： 计算方式为上报的点数/288所得出的值。其中288为一天的点数，5分钟为一个点数单位。计算95费用时，因95费用是按月定价，若实际不足月，则是使用官网价*折扣*actual_days/当月天数，来计算费用明细。
        /// </summary>
        [JsonProperty("actual_days", NullValueHandling = NullValueHandling.Ignore)]
        public string ActualDays { get; set; }

        /// <summary>
        /// 计费带宽的按月汇总。  说明： 每月2日20点后可查询上月数据；若查询当月数据，则为空。
        /// </summary>
        [JsonProperty("band_width", NullValueHandling = NullValueHandling.Ignore)]
        public string BandWidth { get; set; }

        /// <summary>
        /// 月保底带宽的按月汇总。  说明： 每月2日20点后可查询上月数据；若查询当月数据，则为空。该字段为预留值，当前始终为空；当场景为95增强时才返回数值。
        /// </summary>
        [JsonProperty("monthly_guaranteed_band_width", NullValueHandling = NullValueHandling.Ignore)]
        public string MonthlyGuaranteedBandWidth { get; set; }

        /// <summary>
        /// 月峰值带宽。  说明： 每月2日20点后可查询上月数据；若查询当月数据，则为空。该字段为预留值，当前始终为空；当场景为95增强时才返回数值。
        /// </summary>
        [JsonProperty("monthly_peak_band_width", NullValueHandling = NullValueHandling.Ignore)]
        public string MonthlyPeakBandWidth { get; set; }

        /// <summary>
        /// 带宽单位，您可以调用查询度量单位列表接口获取。若所有带宽为空，则该字段为空。
        /// </summary>
        [JsonProperty("band_width_measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? BandWidthMeasureId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatUsageSummaryInfo {\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  actualDays: ").Append(ActualDays).Append("\n");
            sb.Append("  bandWidth: ").Append(BandWidth).Append("\n");
            sb.Append("  monthlyGuaranteedBandWidth: ").Append(MonthlyGuaranteedBandWidth).Append("\n");
            sb.Append("  monthlyPeakBandWidth: ").Append(MonthlyPeakBandWidth).Append("\n");
            sb.Append("  bandWidthMeasureId: ").Append(BandWidthMeasureId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StatUsageSummaryInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StatUsageSummaryInfo input)
        {
            if (input == null) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.ActualDays != input.ActualDays || (this.ActualDays != null && !this.ActualDays.Equals(input.ActualDays))) return false;
            if (this.BandWidth != input.BandWidth || (this.BandWidth != null && !this.BandWidth.Equals(input.BandWidth))) return false;
            if (this.MonthlyGuaranteedBandWidth != input.MonthlyGuaranteedBandWidth || (this.MonthlyGuaranteedBandWidth != null && !this.MonthlyGuaranteedBandWidth.Equals(input.MonthlyGuaranteedBandWidth))) return false;
            if (this.MonthlyPeakBandWidth != input.MonthlyPeakBandWidth || (this.MonthlyPeakBandWidth != null && !this.MonthlyPeakBandWidth.Equals(input.MonthlyPeakBandWidth))) return false;
            if (this.BandWidthMeasureId != input.BandWidthMeasureId || (this.BandWidthMeasureId != null && !this.BandWidthMeasureId.Equals(input.BandWidthMeasureId))) return false;

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
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.ActualDays != null) hashCode = hashCode * 59 + this.ActualDays.GetHashCode();
                if (this.BandWidth != null) hashCode = hashCode * 59 + this.BandWidth.GetHashCode();
                if (this.MonthlyGuaranteedBandWidth != null) hashCode = hashCode * 59 + this.MonthlyGuaranteedBandWidth.GetHashCode();
                if (this.MonthlyPeakBandWidth != null) hashCode = hashCode * 59 + this.MonthlyPeakBandWidth.GetHashCode();
                if (this.BandWidthMeasureId != null) hashCode = hashCode * 59 + this.BandWidthMeasureId.GetHashCode();
                return hashCode;
            }
        }
    }
}
