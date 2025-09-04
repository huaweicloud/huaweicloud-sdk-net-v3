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
    public class FreeResourceDetail 
    {

        /// <summary>
        /// 资源项ID，一个资源包中会含有多个资源项，一个使用量类型对应一个资源项。
        /// </summary>
        [JsonProperty("free_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FreeResourceId { get; set; }

        /// <summary>
        /// 资源项类型名称。
        /// </summary>
        [JsonProperty("free_resource_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FreeResourceTypeName { get; set; }

        /// <summary>
        /// 重置周期，只有quota_reuse_mode为可重置，该字段才有意义。 1：小时2：天3：周4：月5：年
        /// </summary>
        [JsonProperty("quota_reuse_cycle", NullValueHandling = NullValueHandling.Ignore)]
        public int? QuotaReuseCycle { get; set; }

        /// <summary>
        /// 重置周期类别，只有quota_reuse_mode为可重置，该字段才有意义。 1：按自然周期重置是指重置周期是按照自然月/年来重置，例如如果周期是月，按自然周期重置，表示每个月的1号重置。 2：按订购周期重置。是指重置周期是按照订购时间来重置，例如如果周期是月，按订购周期重置，15号订购了该套餐，表示每个月的15号重置。
        /// </summary>
        [JsonProperty("quota_reuse_cycle_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? QuotaReuseCycleType { get; set; }

        /// <summary>
        /// 使用量类型名称。
        /// </summary>
        [JsonProperty("usage_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UsageTypeName { get; set; }

        /// <summary>
        /// 开始时间，格式UTC。 如果quota_reuse_mode为可重置，则此时间为当前时间所在的重置周期的开始时间。如果quota_reuse_mode为不可重置，则此时间为订购实例的生效时间。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间，格式UTC。 如果quota_reuse_mode为可重置，则此时间为当前时间所在的重置周期的结束时间。如果quota_reuse_mode为不可重置，则此时间为订购实例的失效时间。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 资源剩余额度，针对可重置资源包，是指当前重置周期内的剩余量。
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// 资源原始额度，针对可重置资源包，是指每个重置周期内的总量。
        /// </summary>
        [JsonProperty("original_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? OriginalAmount { get; set; }

        /// <summary>
        /// 度量单位，免费资源套餐额度度量单位。您可以调用查询度量单位列表接口获取。
        /// </summary>
        [JsonProperty("measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MeasureId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FreeResourceDetail {\n");
            sb.Append("  freeResourceId: ").Append(FreeResourceId).Append("\n");
            sb.Append("  freeResourceTypeName: ").Append(FreeResourceTypeName).Append("\n");
            sb.Append("  quotaReuseCycle: ").Append(QuotaReuseCycle).Append("\n");
            sb.Append("  quotaReuseCycleType: ").Append(QuotaReuseCycleType).Append("\n");
            sb.Append("  usageTypeName: ").Append(UsageTypeName).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  amount: ").Append(Amount).Append("\n");
            sb.Append("  originalAmount: ").Append(OriginalAmount).Append("\n");
            sb.Append("  measureId: ").Append(MeasureId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FreeResourceDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FreeResourceDetail input)
        {
            if (input == null) return false;
            if (this.FreeResourceId != input.FreeResourceId || (this.FreeResourceId != null && !this.FreeResourceId.Equals(input.FreeResourceId))) return false;
            if (this.FreeResourceTypeName != input.FreeResourceTypeName || (this.FreeResourceTypeName != null && !this.FreeResourceTypeName.Equals(input.FreeResourceTypeName))) return false;
            if (this.QuotaReuseCycle != input.QuotaReuseCycle || (this.QuotaReuseCycle != null && !this.QuotaReuseCycle.Equals(input.QuotaReuseCycle))) return false;
            if (this.QuotaReuseCycleType != input.QuotaReuseCycleType || (this.QuotaReuseCycleType != null && !this.QuotaReuseCycleType.Equals(input.QuotaReuseCycleType))) return false;
            if (this.UsageTypeName != input.UsageTypeName || (this.UsageTypeName != null && !this.UsageTypeName.Equals(input.UsageTypeName))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Amount != input.Amount || (this.Amount != null && !this.Amount.Equals(input.Amount))) return false;
            if (this.OriginalAmount != input.OriginalAmount || (this.OriginalAmount != null && !this.OriginalAmount.Equals(input.OriginalAmount))) return false;
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
                if (this.FreeResourceId != null) hashCode = hashCode * 59 + this.FreeResourceId.GetHashCode();
                if (this.FreeResourceTypeName != null) hashCode = hashCode * 59 + this.FreeResourceTypeName.GetHashCode();
                if (this.QuotaReuseCycle != null) hashCode = hashCode * 59 + this.QuotaReuseCycle.GetHashCode();
                if (this.QuotaReuseCycleType != null) hashCode = hashCode * 59 + this.QuotaReuseCycleType.GetHashCode();
                if (this.UsageTypeName != null) hashCode = hashCode * 59 + this.UsageTypeName.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Amount != null) hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.OriginalAmount != null) hashCode = hashCode * 59 + this.OriginalAmount.GetHashCode();
                if (this.MeasureId != null) hashCode = hashCode * 59 + this.MeasureId.GetHashCode();
                return hashCode;
            }
        }
    }
}
