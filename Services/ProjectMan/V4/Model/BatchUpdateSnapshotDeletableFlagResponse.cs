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
    /// Response Object
    /// </summary>
    public class BatchUpdateSnapshotDeletableFlagResponse : SdkResponse
    {

        /// <summary>
        /// 响应信息。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// 响应码。
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// 总数量。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 成功数量。
        /// </summary>
        [JsonProperty("success_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? SuccessCount { get; set; }

        /// <summary>
        /// 失败数量。
        /// </summary>
        [JsonProperty("failure_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FailureCount { get; set; }

        /// <summary>
        /// 失败详情列表。
        /// </summary>
        [JsonProperty("failure_details", NullValueHandling = NullValueHandling.Ignore)]
        public List<FailureDetail> FailureDetails { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchUpdateSnapshotDeletableFlagResponse {\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  successCount: ").Append(SuccessCount).Append("\n");
            sb.Append("  failureCount: ").Append(FailureCount).Append("\n");
            sb.Append("  failureDetails: ").Append(FailureDetails).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchUpdateSnapshotDeletableFlagResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchUpdateSnapshotDeletableFlagResponse input)
        {
            if (input == null) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.SuccessCount != input.SuccessCount || (this.SuccessCount != null && !this.SuccessCount.Equals(input.SuccessCount))) return false;
            if (this.FailureCount != input.FailureCount || (this.FailureCount != null && !this.FailureCount.Equals(input.FailureCount))) return false;
            if (this.FailureDetails != input.FailureDetails || (this.FailureDetails != null && input.FailureDetails != null && !this.FailureDetails.SequenceEqual(input.FailureDetails))) return false;

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
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.SuccessCount != null) hashCode = hashCode * 59 + this.SuccessCount.GetHashCode();
                if (this.FailureCount != null) hashCode = hashCode * 59 + this.FailureCount.GetHashCode();
                if (this.FailureDetails != null) hashCode = hashCode * 59 + this.FailureDetails.GetHashCode();
                return hashCode;
            }
        }
    }
}
