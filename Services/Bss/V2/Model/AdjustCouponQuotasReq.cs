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
    public class AdjustCouponQuotasReq 
    {

        /// <summary>
        /// 华为云总经销商发放的代金券额度的ID。获取方法请参见查询优惠券额度。
        /// </summary>
        [JsonProperty("quota_id", NullValueHandling = NullValueHandling.Ignore)]
        public string QuotaId { get; set; }

        /// <summary>
        /// 云经销商ID列表。
        /// </summary>
        [JsonProperty("indirect_partner_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IndirectPartnerIds { get; set; }

        /// <summary>
        /// 华为云总经销商向云经销商发放的代金券额度值。 单位：元。取值大于0且精确到小数点后2位。
        /// </summary>
        [JsonProperty("quota_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? QuotaAmount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdjustCouponQuotasReq {\n");
            sb.Append("  quotaId: ").Append(QuotaId).Append("\n");
            sb.Append("  indirectPartnerIds: ").Append(IndirectPartnerIds).Append("\n");
            sb.Append("  quotaAmount: ").Append(QuotaAmount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AdjustCouponQuotasReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AdjustCouponQuotasReq input)
        {
            if (input == null) return false;
            if (this.QuotaId != input.QuotaId || (this.QuotaId != null && !this.QuotaId.Equals(input.QuotaId))) return false;
            if (this.IndirectPartnerIds != input.IndirectPartnerIds || (this.IndirectPartnerIds != null && input.IndirectPartnerIds != null && !this.IndirectPartnerIds.SequenceEqual(input.IndirectPartnerIds))) return false;
            if (this.QuotaAmount != input.QuotaAmount || (this.QuotaAmount != null && !this.QuotaAmount.Equals(input.QuotaAmount))) return false;

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
                if (this.IndirectPartnerIds != null) hashCode = hashCode * 59 + this.IndirectPartnerIds.GetHashCode();
                if (this.QuotaAmount != null) hashCode = hashCode * 59 + this.QuotaAmount.GetHashCode();
                return hashCode;
            }
        }
    }
}
