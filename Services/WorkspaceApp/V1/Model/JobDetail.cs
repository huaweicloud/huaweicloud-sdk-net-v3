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
    /// Job信息详情。
    /// </summary>
    public class JobDetail 
    {

        /// <summary>
        /// 任务ID。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// job类型，固定值1。
        /// </summary>
        [JsonProperty("job_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? JobType { get; set; }

        /// <summary>
        /// job执行状态 - 0：失败。（如果是开通失败，云运营查询到失败状态，直接退费给客户。如果是变更失败，当前是发运维工单，暂时还不是直接退费给客户。） - 1：成功。（处理结果成功。） - 2：处理中。 - 3：正在初始化。
        /// </summary>
        [JsonProperty("job_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? JobStatus { get; set; }

        /// <summary>
        /// 子任务信息。
        /// </summary>
        [JsonProperty("sub_jobs", NullValueHandling = NullValueHandling.Ignore)]
        public List<SubJobInfo> SubJobs { get; set; }

        /// <summary>
        /// Job处理开始时间。
        /// </summary>
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? BeginTime { get; set; }

        /// <summary>
        /// job处理结束时间。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// 云服务预估的Job处理结束时间，只针对job有效，针对子job无效。
        /// </summary>
        [JsonProperty("expected_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExpectedEndTime { get; set; }

        /// <summary>
        /// Job执行结果码
        /// </summary>
        [JsonProperty("execute_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecuteCode { get; set; }

        /// <summary>
        /// Job执行结果描述，以及每个SubJob的执行结果描述。
        /// </summary>
        [JsonProperty("execute_message", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecuteMessage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobDetail {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  jobType: ").Append(JobType).Append("\n");
            sb.Append("  jobStatus: ").Append(JobStatus).Append("\n");
            sb.Append("  subJobs: ").Append(SubJobs).Append("\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  expectedEndTime: ").Append(ExpectedEndTime).Append("\n");
            sb.Append("  executeCode: ").Append(ExecuteCode).Append("\n");
            sb.Append("  executeMessage: ").Append(ExecuteMessage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobDetail input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.JobType != input.JobType || (this.JobType != null && !this.JobType.Equals(input.JobType))) return false;
            if (this.JobStatus != input.JobStatus || (this.JobStatus != null && !this.JobStatus.Equals(input.JobStatus))) return false;
            if (this.SubJobs != input.SubJobs || (this.SubJobs != null && input.SubJobs != null && !this.SubJobs.SequenceEqual(input.SubJobs))) return false;
            if (this.BeginTime != input.BeginTime || (this.BeginTime != null && !this.BeginTime.Equals(input.BeginTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.ExpectedEndTime != input.ExpectedEndTime || (this.ExpectedEndTime != null && !this.ExpectedEndTime.Equals(input.ExpectedEndTime))) return false;
            if (this.ExecuteCode != input.ExecuteCode || (this.ExecuteCode != null && !this.ExecuteCode.Equals(input.ExecuteCode))) return false;
            if (this.ExecuteMessage != input.ExecuteMessage || (this.ExecuteMessage != null && !this.ExecuteMessage.Equals(input.ExecuteMessage))) return false;

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
                if (this.JobType != null) hashCode = hashCode * 59 + this.JobType.GetHashCode();
                if (this.JobStatus != null) hashCode = hashCode * 59 + this.JobStatus.GetHashCode();
                if (this.SubJobs != null) hashCode = hashCode * 59 + this.SubJobs.GetHashCode();
                if (this.BeginTime != null) hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.ExpectedEndTime != null) hashCode = hashCode * 59 + this.ExpectedEndTime.GetHashCode();
                if (this.ExecuteCode != null) hashCode = hashCode * 59 + this.ExecuteCode.GetHashCode();
                if (this.ExecuteMessage != null) hashCode = hashCode * 59 + this.ExecuteMessage.GetHashCode();
                return hashCode;
            }
        }
    }
}
