using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ReviewUpdateBodyV2 
    {

        /// <summary>
        /// 评审单更新前状态。 0~32个字符。
        /// </summary>
        [JsonProperty("old_status", NullValueHandling = NullValueHandling.Ignore)]
        public string OldStatus { get; set; }

        /// <summary>
        /// 评审单目标流转状态。 0~32个字符。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 计划完成时间，unix时间戳，单位：毫秒，示例：\&quot;1759420799999\&quot;。
        /// </summary>
        [JsonProperty("plan_end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanEndDate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReviewUpdateBodyV2 {\n");
            sb.Append("  oldStatus: ").Append(OldStatus).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  planEndDate: ").Append(PlanEndDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReviewUpdateBodyV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReviewUpdateBodyV2 input)
        {
            if (input == null) return false;
            if (this.OldStatus != input.OldStatus || (this.OldStatus != null && !this.OldStatus.Equals(input.OldStatus))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.PlanEndDate != input.PlanEndDate || (this.PlanEndDate != null && !this.PlanEndDate.Equals(input.PlanEndDate))) return false;

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
                if (this.OldStatus != null) hashCode = hashCode * 59 + this.OldStatus.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.PlanEndDate != null) hashCode = hashCode * 59 + this.PlanEndDate.GetHashCode();
                return hashCode;
            }
        }
    }
}
