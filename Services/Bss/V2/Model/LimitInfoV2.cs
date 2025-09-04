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
    public class LimitInfoV2 
    {

        /// <summary>
        /// 使用限制ID，主键。
        /// </summary>
        [JsonProperty("use_limiti_info_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UseLimitiInfoId { get; set; }

        /// <summary>
        /// 折扣限制，key的取值请参考表5。
        /// </summary>
        [JsonProperty("limit_key", NullValueHandling = NullValueHandling.Ignore)]
        public string LimitKey { get; set; }

        /// <summary>
        /// value1。
        /// </summary>
        [JsonProperty("value1", NullValueHandling = NullValueHandling.Ignore)]
        public string Value1 { get; set; }

        /// <summary>
        /// value2。
        /// </summary>
        [JsonProperty("value2", NullValueHandling = NullValueHandling.Ignore)]
        public string Value2 { get; set; }

        /// <summary>
        /// value单位。
        /// </summary>
        [JsonProperty("value_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string ValueUnit { get; set; }

        /// <summary>
        /// 限制类型。
        /// </summary>
        [JsonProperty("limit_type", NullValueHandling = NullValueHandling.Ignore)]
        public string LimitType { get; set; }

        /// <summary>
        /// 促销计划ID。
        /// </summary>
        [JsonProperty("promotion_plan_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PromotionPlanId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LimitInfoV2 {\n");
            sb.Append("  useLimitiInfoId: ").Append(UseLimitiInfoId).Append("\n");
            sb.Append("  limitKey: ").Append(LimitKey).Append("\n");
            sb.Append("  value1: ").Append(Value1).Append("\n");
            sb.Append("  value2: ").Append(Value2).Append("\n");
            sb.Append("  valueUnit: ").Append(ValueUnit).Append("\n");
            sb.Append("  limitType: ").Append(LimitType).Append("\n");
            sb.Append("  promotionPlanId: ").Append(PromotionPlanId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LimitInfoV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LimitInfoV2 input)
        {
            if (input == null) return false;
            if (this.UseLimitiInfoId != input.UseLimitiInfoId || (this.UseLimitiInfoId != null && !this.UseLimitiInfoId.Equals(input.UseLimitiInfoId))) return false;
            if (this.LimitKey != input.LimitKey || (this.LimitKey != null && !this.LimitKey.Equals(input.LimitKey))) return false;
            if (this.Value1 != input.Value1 || (this.Value1 != null && !this.Value1.Equals(input.Value1))) return false;
            if (this.Value2 != input.Value2 || (this.Value2 != null && !this.Value2.Equals(input.Value2))) return false;
            if (this.ValueUnit != input.ValueUnit || (this.ValueUnit != null && !this.ValueUnit.Equals(input.ValueUnit))) return false;
            if (this.LimitType != input.LimitType || (this.LimitType != null && !this.LimitType.Equals(input.LimitType))) return false;
            if (this.PromotionPlanId != input.PromotionPlanId || (this.PromotionPlanId != null && !this.PromotionPlanId.Equals(input.PromotionPlanId))) return false;

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
                if (this.UseLimitiInfoId != null) hashCode = hashCode * 59 + this.UseLimitiInfoId.GetHashCode();
                if (this.LimitKey != null) hashCode = hashCode * 59 + this.LimitKey.GetHashCode();
                if (this.Value1 != null) hashCode = hashCode * 59 + this.Value1.GetHashCode();
                if (this.Value2 != null) hashCode = hashCode * 59 + this.Value2.GetHashCode();
                if (this.ValueUnit != null) hashCode = hashCode * 59 + this.ValueUnit.GetHashCode();
                if (this.LimitType != null) hashCode = hashCode * 59 + this.LimitType.GetHashCode();
                if (this.PromotionPlanId != null) hashCode = hashCode * 59 + this.PromotionPlanId.GetHashCode();
                return hashCode;
            }
        }
    }
}
