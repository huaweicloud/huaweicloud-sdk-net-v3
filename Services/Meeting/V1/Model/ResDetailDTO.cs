using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ResDetailDTO 
    {

        /// <summary>
        /// 总数。
        /// </summary>
        [JsonProperty("sumCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? SumCount { get; set; }

        /// <summary>
        /// 赠送数量。
        /// </summary>
        [JsonProperty("trialCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? TrialCount { get; set; }

        /// <summary>
        /// 到期数量。
        /// </summary>
        [JsonProperty("expiredCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpiredCount { get; set; }

        /// <summary>
        /// 即将到期数量，到期时间在30天内。
        /// </summary>
        [JsonProperty("expiringCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpiringCount { get; set; }

        /// <summary>
        /// 已使用数（录播存储空间、会议并发、推流并发方数暂无法查询）。
        /// </summary>
        [JsonProperty("usedCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? UsedCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResDetailDTO {\n");
            sb.Append("  sumCount: ").Append(SumCount).Append("\n");
            sb.Append("  trialCount: ").Append(TrialCount).Append("\n");
            sb.Append("  expiredCount: ").Append(ExpiredCount).Append("\n");
            sb.Append("  expiringCount: ").Append(ExpiringCount).Append("\n");
            sb.Append("  usedCount: ").Append(UsedCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResDetailDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResDetailDTO input)
        {
            if (input == null) return false;
            if (this.SumCount != input.SumCount || (this.SumCount != null && !this.SumCount.Equals(input.SumCount))) return false;
            if (this.TrialCount != input.TrialCount || (this.TrialCount != null && !this.TrialCount.Equals(input.TrialCount))) return false;
            if (this.ExpiredCount != input.ExpiredCount || (this.ExpiredCount != null && !this.ExpiredCount.Equals(input.ExpiredCount))) return false;
            if (this.ExpiringCount != input.ExpiringCount || (this.ExpiringCount != null && !this.ExpiringCount.Equals(input.ExpiringCount))) return false;
            if (this.UsedCount != input.UsedCount || (this.UsedCount != null && !this.UsedCount.Equals(input.UsedCount))) return false;

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
                if (this.SumCount != null) hashCode = hashCode * 59 + this.SumCount.GetHashCode();
                if (this.TrialCount != null) hashCode = hashCode * 59 + this.TrialCount.GetHashCode();
                if (this.ExpiredCount != null) hashCode = hashCode * 59 + this.ExpiredCount.GetHashCode();
                if (this.ExpiringCount != null) hashCode = hashCode * 59 + this.ExpiringCount.GetHashCode();
                if (this.UsedCount != null) hashCode = hashCode * 59 + this.UsedCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
