using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowImageJobResponse : SdkResponse
    {

        /// <summary>
        /// 任务ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("job_type", NullValueHandling = NullValueHandling.Ignore)]
        public ImageJobType? JobType { get; set; }

        /// <summary>
        /// 任务创建时间。
        /// </summary>
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? BeginTime { get; set; }

        /// <summary>
        /// 任务结束时间。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public ImageJobStatus? Status { get; set; }

        /// <summary>
        /// 子任务总数。
        /// </summary>
        [JsonProperty("sub_jobs_total", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubJobsTotal { get; set; }

        /// <summary>
        /// 子任务列表。
        /// </summary>
        [JsonProperty("sub_jobs", NullValueHandling = NullValueHandling.Ignore)]
        public List<ImageJobDetailInfo> SubJobs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowImageJobResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  jobType: ").Append(JobType).Append("\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  subJobsTotal: ").Append(SubJobsTotal).Append("\n");
            sb.Append("  subJobs: ").Append(SubJobs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowImageJobResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowImageJobResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.JobType != input.JobType || (this.JobType != null && !this.JobType.Equals(input.JobType))) return false;
            if (this.BeginTime != input.BeginTime || (this.BeginTime != null && !this.BeginTime.Equals(input.BeginTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.SubJobsTotal != input.SubJobsTotal || (this.SubJobsTotal != null && !this.SubJobsTotal.Equals(input.SubJobsTotal))) return false;
            if (this.SubJobs != input.SubJobs || (this.SubJobs != null && input.SubJobs != null && !this.SubJobs.SequenceEqual(input.SubJobs))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.JobType != null) hashCode = hashCode * 59 + this.JobType.GetHashCode();
                if (this.BeginTime != null) hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SubJobsTotal != null) hashCode = hashCode * 59 + this.SubJobsTotal.GetHashCode();
                if (this.SubJobs != null) hashCode = hashCode * 59 + this.SubJobs.GetHashCode();
                return hashCode;
            }
        }
    }
}
