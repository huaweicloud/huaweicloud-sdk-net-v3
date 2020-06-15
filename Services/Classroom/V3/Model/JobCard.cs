using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Classroom.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class JobCard 
    {

        /// <summary>
        /// 作业名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 作业ID
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 作业下发状态(unsend:作业未下发, send:作业已下发)
        /// </summary>
        [JsonProperty("is_send", NullValueHandling = NullValueHandling.Ignore)]
        public string IsSend { get; set; }

        /// <summary>
        /// 作业截止时间, 日期格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 作业均分
        /// </summary>
        [JsonProperty("average_score", NullValueHandling = NullValueHandling.Ignore)]
        public string AverageScore { get; set; }

        /// <summary>
        /// 作业提交人数
        /// </summary>
        [JsonProperty("submit_job_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubmitJobNum { get; set; }

        /// <summary>
        /// 作业创建状态(yes:作业可以下发, no:作业不能下发)
        /// </summary>
        [JsonProperty("create_status", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateStatus { get; set; }

        /// <summary>
        /// 作业下发类型(specific:指定成员下发, all:下发课堂全员)
        /// </summary>
        [JsonProperty("send_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SendType { get; set; }

        /// <summary>
        /// 作业成绩是否公布(unpublish:表示未公布成绩, publish:表示已公布成绩)
        /// </summary>
        [JsonProperty("is_score_visibility", NullValueHandling = NullValueHandling.Ignore)]
        public string IsScoreVisibility { get; set; }

        /// <summary>
        /// 作业下发时间, 日期格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("send_time", NullValueHandling = NullValueHandling.Ignore)]
        public string SendTime { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobCard {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  isSend: ").Append(IsSend).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  averageScore: ").Append(AverageScore).Append("\n");
            sb.Append("  submitJobNum: ").Append(SubmitJobNum).Append("\n");
            sb.Append("  createStatus: ").Append(CreateStatus).Append("\n");
            sb.Append("  sendType: ").Append(SendType).Append("\n");
            sb.Append("  isScoreVisibility: ").Append(IsScoreVisibility).Append("\n");
            sb.Append("  sendTime: ").Append(SendTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobCard);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobCard input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.IsSend == input.IsSend ||
                    (this.IsSend != null &&
                    this.IsSend.Equals(input.IsSend))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.AverageScore == input.AverageScore ||
                    (this.AverageScore != null &&
                    this.AverageScore.Equals(input.AverageScore))
                ) && 
                (
                    this.SubmitJobNum == input.SubmitJobNum ||
                    (this.SubmitJobNum != null &&
                    this.SubmitJobNum.Equals(input.SubmitJobNum))
                ) && 
                (
                    this.CreateStatus == input.CreateStatus ||
                    (this.CreateStatus != null &&
                    this.CreateStatus.Equals(input.CreateStatus))
                ) && 
                (
                    this.SendType == input.SendType ||
                    (this.SendType != null &&
                    this.SendType.Equals(input.SendType))
                ) && 
                (
                    this.IsScoreVisibility == input.IsScoreVisibility ||
                    (this.IsScoreVisibility != null &&
                    this.IsScoreVisibility.Equals(input.IsScoreVisibility))
                ) && 
                (
                    this.SendTime == input.SendTime ||
                    (this.SendTime != null &&
                    this.SendTime.Equals(input.SendTime))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.IsSend != null)
                    hashCode = hashCode * 59 + this.IsSend.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.AverageScore != null)
                    hashCode = hashCode * 59 + this.AverageScore.GetHashCode();
                if (this.SubmitJobNum != null)
                    hashCode = hashCode * 59 + this.SubmitJobNum.GetHashCode();
                if (this.CreateStatus != null)
                    hashCode = hashCode * 59 + this.CreateStatus.GetHashCode();
                if (this.SendType != null)
                    hashCode = hashCode * 59 + this.SendType.GetHashCode();
                if (this.IsScoreVisibility != null)
                    hashCode = hashCode * 59 + this.IsScoreVisibility.GetHashCode();
                if (this.SendTime != null)
                    hashCode = hashCode * 59 + this.SendTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
