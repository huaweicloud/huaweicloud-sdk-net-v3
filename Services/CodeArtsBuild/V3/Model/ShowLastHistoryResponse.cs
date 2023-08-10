using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowLastHistoryResponse : SdkResponse
    {

        /// <summary>
        /// 构建记录id- -唯一key
        /// </summary>
        [JsonProperty("record_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordId { get; set; }

        /// <summary>
        /// 构建任务ID
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 构建任务名称
        /// </summary>
        [JsonProperty("job_name", NullValueHandling = NullValueHandling.Ignore)]
        public string JobName { get; set; }

        /// <summary>
        /// 构建编号
        /// </summary>
        [JsonProperty("build_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? BuildNumber { get; set; }

        /// <summary>
        /// 构建开始时间
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 构建结束时间
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 构建执行结果
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public string Result { get; set; }

        /// <summary>
        /// commitId
        /// </summary>
        [JsonProperty("commit_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowLastHistoryResponse {\n");
            sb.Append("  recordId: ").Append(RecordId).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  jobName: ").Append(JobName).Append("\n");
            sb.Append("  buildNumber: ").Append(BuildNumber).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  commitId: ").Append(CommitId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowLastHistoryResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowLastHistoryResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RecordId == input.RecordId ||
                    (this.RecordId != null &&
                    this.RecordId.Equals(input.RecordId))
                ) && 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.JobName == input.JobName ||
                    (this.JobName != null &&
                    this.JobName.Equals(input.JobName))
                ) && 
                (
                    this.BuildNumber == input.BuildNumber ||
                    (this.BuildNumber != null &&
                    this.BuildNumber.Equals(input.BuildNumber))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
                ) && 
                (
                    this.CommitId == input.CommitId ||
                    (this.CommitId != null &&
                    this.CommitId.Equals(input.CommitId))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.RecordId != null)
                    hashCode = hashCode * 59 + this.RecordId.GetHashCode();
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.JobName != null)
                    hashCode = hashCode * 59 + this.JobName.GetHashCode();
                if (this.BuildNumber != null)
                    hashCode = hashCode * 59 + this.BuildNumber.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.CommitId != null)
                    hashCode = hashCode * 59 + this.CommitId.GetHashCode();
                return hashCode;
            }
        }
    }
}
