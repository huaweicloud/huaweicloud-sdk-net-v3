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
    public class QuotaReclaim 
    {

        /// <summary>
        /// 被回收的云经销商的代金券额度ID。
        /// </summary>
        [JsonProperty("quota_id", NullValueHandling = NullValueHandling.Ignore)]
        public string QuotaId { get; set; }

        /// <summary>
        /// 被回收额度后的代金券额度余额。单位：元。
        /// </summary>
        [JsonProperty("quota_balance", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? QuotaBalance { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuotaReclaim {\n");
            sb.Append("  quotaId: ").Append(QuotaId).Append("\n");
            sb.Append("  quotaBalance: ").Append(QuotaBalance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QuotaReclaim);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QuotaReclaim input)
        {
            if (input == null) return false;
            if (this.QuotaId != input.QuotaId || (this.QuotaId != null && !this.QuotaId.Equals(input.QuotaId))) return false;
            if (this.QuotaBalance != input.QuotaBalance || (this.QuotaBalance != null && !this.QuotaBalance.Equals(input.QuotaBalance))) return false;

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
                if (this.QuotaBalance != null) hashCode = hashCode * 59 + this.QuotaBalance.GetHashCode();
                return hashCode;
            }
        }
    }
}
