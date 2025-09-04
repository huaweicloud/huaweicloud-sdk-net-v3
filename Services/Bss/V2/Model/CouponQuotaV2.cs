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
    public class CouponQuotaV2 
    {

        /// <summary>
        /// 优惠券额度ID。
        /// </summary>
        [JsonProperty("quota_id", NullValueHandling = NullValueHandling.Ignore)]
        public string QuotaId { get; set; }

        /// <summary>
        /// 优惠券额度的类型： 0：代金券额度1：现金券额度
        /// </summary>
        [JsonProperty("quota_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? QuotaType { get; set; }

        /// <summary>
        /// 创建时间。 UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 最后一次更新时间。 UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。
        /// </summary>
        [JsonProperty("last_update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdateTime { get; set; }

        /// <summary>
        /// 优惠券额度的值，精确到小数点后2位。
        /// </summary>
        [JsonProperty("quota_value", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? QuotaValue { get; set; }

        /// <summary>
        /// 优惠券额度的状态： 0：正常3：失效（过期失效和人工设置失效）4：额度调整中（伙伴可以查看该额度，但不能使用该额度发放优惠券）5：冻结
        /// </summary>
        [JsonProperty("quota_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? QuotaStatus { get; set; }

        /// <summary>
        /// 剩余的优惠券额度，精确到小数点后2位。
        /// </summary>
        [JsonProperty("balance", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Balance { get; set; }

        /// <summary>
        /// 面额单位。 1：元。
        /// </summary>
        [JsonProperty("measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MeasureId { get; set; }

        /// <summary>
        /// 币种。 CNY：人民币
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// 生效时间。 UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。
        /// </summary>
        [JsonProperty("effective_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// 失效时间。 UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。
        /// </summary>
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 优惠券额度上的限制属性，具体参见表2。
        /// </summary>
        [JsonProperty("limit_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<QuotaLimitInfo> LimitInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CouponQuotaV2 {\n");
            sb.Append("  quotaId: ").Append(QuotaId).Append("\n");
            sb.Append("  quotaType: ").Append(QuotaType).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  lastUpdateTime: ").Append(LastUpdateTime).Append("\n");
            sb.Append("  quotaValue: ").Append(QuotaValue).Append("\n");
            sb.Append("  quotaStatus: ").Append(QuotaStatus).Append("\n");
            sb.Append("  balance: ").Append(Balance).Append("\n");
            sb.Append("  measureId: ").Append(MeasureId).Append("\n");
            sb.Append("  currency: ").Append(Currency).Append("\n");
            sb.Append("  effectiveTime: ").Append(EffectiveTime).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  limitInfos: ").Append(LimitInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CouponQuotaV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CouponQuotaV2 input)
        {
            if (input == null) return false;
            if (this.QuotaId != input.QuotaId || (this.QuotaId != null && !this.QuotaId.Equals(input.QuotaId))) return false;
            if (this.QuotaType != input.QuotaType || (this.QuotaType != null && !this.QuotaType.Equals(input.QuotaType))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.LastUpdateTime != input.LastUpdateTime || (this.LastUpdateTime != null && !this.LastUpdateTime.Equals(input.LastUpdateTime))) return false;
            if (this.QuotaValue != input.QuotaValue || (this.QuotaValue != null && !this.QuotaValue.Equals(input.QuotaValue))) return false;
            if (this.QuotaStatus != input.QuotaStatus || (this.QuotaStatus != null && !this.QuotaStatus.Equals(input.QuotaStatus))) return false;
            if (this.Balance != input.Balance || (this.Balance != null && !this.Balance.Equals(input.Balance))) return false;
            if (this.MeasureId != input.MeasureId || (this.MeasureId != null && !this.MeasureId.Equals(input.MeasureId))) return false;
            if (this.Currency != input.Currency || (this.Currency != null && !this.Currency.Equals(input.Currency))) return false;
            if (this.EffectiveTime != input.EffectiveTime || (this.EffectiveTime != null && !this.EffectiveTime.Equals(input.EffectiveTime))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;
            if (this.LimitInfos != input.LimitInfos || (this.LimitInfos != null && input.LimitInfos != null && !this.LimitInfos.SequenceEqual(input.LimitInfos))) return false;

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
                if (this.QuotaId != null) hashCode = hashCode * 59 + this.QuotaId.GetHashCode();
                if (this.QuotaType != null) hashCode = hashCode * 59 + this.QuotaType.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.LastUpdateTime != null) hashCode = hashCode * 59 + this.LastUpdateTime.GetHashCode();
                if (this.QuotaValue != null) hashCode = hashCode * 59 + this.QuotaValue.GetHashCode();
                if (this.QuotaStatus != null) hashCode = hashCode * 59 + this.QuotaStatus.GetHashCode();
                if (this.Balance != null) hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.MeasureId != null) hashCode = hashCode * 59 + this.MeasureId.GetHashCode();
                if (this.Currency != null) hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.EffectiveTime != null) hashCode = hashCode * 59 + this.EffectiveTime.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                if (this.LimitInfos != null) hashCode = hashCode * 59 + this.LimitInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
