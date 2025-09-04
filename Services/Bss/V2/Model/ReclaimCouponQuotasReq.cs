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
    public class ReclaimCouponQuotasReq 
    {

        /// <summary>
        /// 被回收的云经销商的代金券额度ID。获取方法请参见查询优惠券额度。
        /// </summary>
        [JsonProperty("quota_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> QuotaIds { get; set; }

        /// <summary>
        /// 回收时的备注。 此参数不携带或携带值为null时，不赋值；携带值为空串时，赋值空串。
        /// </summary>
        [JsonProperty("remark", NullValueHandling = NullValueHandling.Ignore)]
        public string Remark { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReclaimCouponQuotasReq {\n");
            sb.Append("  quotaIds: ").Append(QuotaIds).Append("\n");
            sb.Append("  remark: ").Append(Remark).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReclaimCouponQuotasReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReclaimCouponQuotasReq input)
        {
            if (input == null) return false;
            if (this.QuotaIds != input.QuotaIds || (this.QuotaIds != null && input.QuotaIds != null && !this.QuotaIds.SequenceEqual(input.QuotaIds))) return false;
            if (this.Remark != input.Remark || (this.Remark != null && !this.Remark.Equals(input.Remark))) return false;

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
                if (this.QuotaIds != null) hashCode = hashCode * 59 + this.QuotaIds.GetHashCode();
                if (this.Remark != null) hashCode = hashCode * 59 + this.Remark.GetHashCode();
                return hashCode;
            }
        }
    }
}
