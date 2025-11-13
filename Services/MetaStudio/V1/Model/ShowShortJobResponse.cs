using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowShortJobResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("job_type", NullValueHandling = NullValueHandling.Ignore)]
        public ShortJobType? JobType { get; set; }

        /// <summary>
        /// 任务id。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public JobState? State { get; set; }

        /// <summary>
        /// 当任务失败时呈现,失败错误码。
        /// </summary>
        [JsonProperty("job_failed_code", NullValueHandling = NullValueHandling.Ignore)]
        public string JobFailedCode { get; set; }

        /// <summary>
        /// 当任务失败时呈现,失败原因。
        /// </summary>
        [JsonProperty("job_failed_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string JobFailedReason { get; set; }

        /// <summary>
        /// 任务创建时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 任务状态更新时间。
        /// </summary>
        [JsonProperty("lastupdate_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastupdateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("assess_result", NullValueHandling = NullValueHandling.Ignore)]
        public AssessResult AssessResult { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowShortJobResponse {\n");
            sb.Append("  jobType: ").Append(JobType).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  jobFailedCode: ").Append(JobFailedCode).Append("\n");
            sb.Append("  jobFailedReason: ").Append(JobFailedReason).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  lastupdateTime: ").Append(LastupdateTime).Append("\n");
            sb.Append("  assessResult: ").Append(AssessResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowShortJobResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowShortJobResponse input)
        {
            if (input == null) return false;
            if (this.JobType != input.JobType || (this.JobType != null && !this.JobType.Equals(input.JobType))) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.JobFailedCode != input.JobFailedCode || (this.JobFailedCode != null && !this.JobFailedCode.Equals(input.JobFailedCode))) return false;
            if (this.JobFailedReason != input.JobFailedReason || (this.JobFailedReason != null && !this.JobFailedReason.Equals(input.JobFailedReason))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.LastupdateTime != input.LastupdateTime || (this.LastupdateTime != null && !this.LastupdateTime.Equals(input.LastupdateTime))) return false;
            if (this.AssessResult != input.AssessResult || (this.AssessResult != null && !this.AssessResult.Equals(input.AssessResult))) return false;

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
                if (this.JobType != null) hashCode = hashCode * 59 + this.JobType.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.JobFailedCode != null) hashCode = hashCode * 59 + this.JobFailedCode.GetHashCode();
                if (this.JobFailedReason != null) hashCode = hashCode * 59 + this.JobFailedReason.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.LastupdateTime != null) hashCode = hashCode * 59 + this.LastupdateTime.GetHashCode();
                if (this.AssessResult != null) hashCode = hashCode * 59 + this.AssessResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
