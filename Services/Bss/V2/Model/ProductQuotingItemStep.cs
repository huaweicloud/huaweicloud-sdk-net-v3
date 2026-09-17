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
    /// 产品报价项阶梯信息
    /// </summary>
    public class ProductQuotingItemStep 
    {

        /// <summary>
        /// 阶梯ID
        /// </summary>
        [JsonProperty("step_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StepId { get; set; }

        /// <summary>
        /// 阶梯编号
        /// </summary>
        [JsonProperty("step_no", NullValueHandling = NullValueHandling.Ignore)]
        public string StepNo { get; set; }

        /// <summary>
        /// 阶梯起始值
        /// </summary>
        [JsonProperty("step_start", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? StepStart { get; set; }

        /// <summary>
        /// 起始值度量单位
        /// </summary>
        [JsonProperty("start_measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartMeasureId { get; set; }

        /// <summary>
        /// 阶梯结束值
        /// </summary>
        [JsonProperty("step_end", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? StepEnd { get; set; }

        /// <summary>
        /// 结束值度量单位（1：元/美元）
        /// </summary>
        [JsonProperty("end_measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? EndMeasureId { get; set; }

        /// <summary>
        /// 优惠方式：0：产品折扣，1：固定单价
        /// </summary>
        [JsonProperty("preferential_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? PreferentialType { get; set; }

        /// <summary>
        /// 固定单价（preferential_type&#x3D;1固定单价时有值）
        /// </summary>
        [JsonProperty("sales_price", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? SalesPrice { get; set; }

        /// <summary>
        /// 折扣率（preferential_type&#x3D;0产品折扣时有值）
        /// </summary>
        [JsonProperty("discount_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? DiscountRatio { get; set; }

        /// <summary>
        /// 计费单位
        /// </summary>
        [JsonProperty("pricing_basis", NullValueHandling = NullValueHandling.Ignore)]
        public string PricingBasis { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductQuotingItemStep {\n");
            sb.Append("  stepId: ").Append(StepId).Append("\n");
            sb.Append("  stepNo: ").Append(StepNo).Append("\n");
            sb.Append("  stepStart: ").Append(StepStart).Append("\n");
            sb.Append("  startMeasureId: ").Append(StartMeasureId).Append("\n");
            sb.Append("  stepEnd: ").Append(StepEnd).Append("\n");
            sb.Append("  endMeasureId: ").Append(EndMeasureId).Append("\n");
            sb.Append("  preferentialType: ").Append(PreferentialType).Append("\n");
            sb.Append("  salesPrice: ").Append(SalesPrice).Append("\n");
            sb.Append("  discountRatio: ").Append(DiscountRatio).Append("\n");
            sb.Append("  pricingBasis: ").Append(PricingBasis).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProductQuotingItemStep);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProductQuotingItemStep input)
        {
            if (input == null) return false;
            if (this.StepId != input.StepId || (this.StepId != null && !this.StepId.Equals(input.StepId))) return false;
            if (this.StepNo != input.StepNo || (this.StepNo != null && !this.StepNo.Equals(input.StepNo))) return false;
            if (this.StepStart != input.StepStart || (this.StepStart != null && !this.StepStart.Equals(input.StepStart))) return false;
            if (this.StartMeasureId != input.StartMeasureId || (this.StartMeasureId != null && !this.StartMeasureId.Equals(input.StartMeasureId))) return false;
            if (this.StepEnd != input.StepEnd || (this.StepEnd != null && !this.StepEnd.Equals(input.StepEnd))) return false;
            if (this.EndMeasureId != input.EndMeasureId || (this.EndMeasureId != null && !this.EndMeasureId.Equals(input.EndMeasureId))) return false;
            if (this.PreferentialType != input.PreferentialType || (this.PreferentialType != null && !this.PreferentialType.Equals(input.PreferentialType))) return false;
            if (this.SalesPrice != input.SalesPrice || (this.SalesPrice != null && !this.SalesPrice.Equals(input.SalesPrice))) return false;
            if (this.DiscountRatio != input.DiscountRatio || (this.DiscountRatio != null && !this.DiscountRatio.Equals(input.DiscountRatio))) return false;
            if (this.PricingBasis != input.PricingBasis || (this.PricingBasis != null && !this.PricingBasis.Equals(input.PricingBasis))) return false;

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
                if (this.StepId != null) hashCode = hashCode * 59 + this.StepId.GetHashCode();
                if (this.StepNo != null) hashCode = hashCode * 59 + this.StepNo.GetHashCode();
                if (this.StepStart != null) hashCode = hashCode * 59 + this.StepStart.GetHashCode();
                if (this.StartMeasureId != null) hashCode = hashCode * 59 + this.StartMeasureId.GetHashCode();
                if (this.StepEnd != null) hashCode = hashCode * 59 + this.StepEnd.GetHashCode();
                if (this.EndMeasureId != null) hashCode = hashCode * 59 + this.EndMeasureId.GetHashCode();
                if (this.PreferentialType != null) hashCode = hashCode * 59 + this.PreferentialType.GetHashCode();
                if (this.SalesPrice != null) hashCode = hashCode * 59 + this.SalesPrice.GetHashCode();
                if (this.DiscountRatio != null) hashCode = hashCode * 59 + this.DiscountRatio.GetHashCode();
                if (this.PricingBasis != null) hashCode = hashCode * 59 + this.PricingBasis.GetHashCode();
                return hashCode;
            }
        }
    }
}
