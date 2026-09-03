using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateSkillBindingsResponse : SdkResponse
    {

        /// <summary>
        /// 批量绑定操作的 TaskFlow 任务 ID。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 请求总数。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 成功数量。
        /// </summary>
        [JsonProperty("success_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? SuccessCount { get; set; }

        /// <summary>
        /// 失败数量。
        /// </summary>
        [JsonProperty("failed_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FailedCount { get; set; }

        /// <summary>
        /// 失败详情列表。
        /// </summary>
        [JsonProperty("failed_details", NullValueHandling = NullValueHandling.Ignore)]
        public List<BindingFailedDetail> FailedDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Request-Id", IsHeader = true)]
        [JsonProperty("X-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSkillBindingsResponse {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  successCount: ").Append(SuccessCount).Append("\n");
            sb.Append("  failedCount: ").Append(FailedCount).Append("\n");
            sb.Append("  failedDetails: ").Append(FailedDetails).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSkillBindingsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSkillBindingsResponse input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.SuccessCount != input.SuccessCount || (this.SuccessCount != null && !this.SuccessCount.Equals(input.SuccessCount))) return false;
            if (this.FailedCount != input.FailedCount || (this.FailedCount != null && !this.FailedCount.Equals(input.FailedCount))) return false;
            if (this.FailedDetails != input.FailedDetails || (this.FailedDetails != null && input.FailedDetails != null && !this.FailedDetails.SequenceEqual(input.FailedDetails))) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.SuccessCount != null) hashCode = hashCode * 59 + this.SuccessCount.GetHashCode();
                if (this.FailedCount != null) hashCode = hashCode * 59 + this.FailedCount.GetHashCode();
                if (this.FailedDetails != null) hashCode = hashCode * 59 + this.FailedDetails.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
