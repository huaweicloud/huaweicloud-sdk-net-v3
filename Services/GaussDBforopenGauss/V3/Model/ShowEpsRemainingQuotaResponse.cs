using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowEpsRemainingQuotaResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: 剩余企业项目配额组。
        /// </summary>
        [JsonProperty("eps_quota_remaining", NullValueHandling = NullValueHandling.Ignore)]
        public List<EpsRemainingQuotaResult> EpsQuotaRemaining { get; set; }

        /// <summary>
        /// **参数解释**: 任务ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// **参数解释**: 返回的企业项目个数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowEpsRemainingQuotaResponse {\n");
            sb.Append("  epsQuotaRemaining: ").Append(EpsQuotaRemaining).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowEpsRemainingQuotaResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowEpsRemainingQuotaResponse input)
        {
            if (input == null) return false;
            if (this.EpsQuotaRemaining != input.EpsQuotaRemaining || (this.EpsQuotaRemaining != null && input.EpsQuotaRemaining != null && !this.EpsQuotaRemaining.SequenceEqual(input.EpsQuotaRemaining))) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;

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
                if (this.EpsQuotaRemaining != null) hashCode = hashCode * 59 + this.EpsQuotaRemaining.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
