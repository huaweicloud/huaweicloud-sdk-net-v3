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
    public class ClassroomMember 
    {

        /// <summary>
        /// 成员ID
        /// </summary>
        [JsonProperty("member_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MemberId { get; set; }

        /// <summary>
        /// 成员名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 成员学号/工号
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 成员所在班级的名字
        /// </summary>
        [JsonProperty("class_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ClassName { get; set; }

        /// <summary>
        /// 成员用户名
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 成员加入课堂时间，日期格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("join_time", NullValueHandling = NullValueHandling.Ignore)]
        public string JoinTime { get; set; }

        /// <summary>
        /// 该成员已接收到的作业数量
        /// </summary>
        [JsonProperty("job_received_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? JobReceivedCount { get; set; }

        /// <summary>
        /// 该成员已完成的作业数量
        /// </summary>
        [JsonProperty("job_finished_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? JobFinishedCount { get; set; }

        /// <summary>
        /// 该成员作业完成率
        /// </summary>
        [JsonProperty("job_finished_rate", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? JobFinishedRate { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClassroomMember {\n");
            sb.Append("  memberId: ").Append(MemberId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  className: ").Append(ClassName).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  joinTime: ").Append(JoinTime).Append("\n");
            sb.Append("  jobReceivedCount: ").Append(JobReceivedCount).Append("\n");
            sb.Append("  jobFinishedCount: ").Append(JobFinishedCount).Append("\n");
            sb.Append("  jobFinishedRate: ").Append(JobFinishedRate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClassroomMember);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClassroomMember input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MemberId == input.MemberId ||
                    (this.MemberId != null &&
                    this.MemberId.Equals(input.MemberId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.ClassName == input.ClassName ||
                    (this.ClassName != null &&
                    this.ClassName.Equals(input.ClassName))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.JoinTime == input.JoinTime ||
                    (this.JoinTime != null &&
                    this.JoinTime.Equals(input.JoinTime))
                ) && 
                (
                    this.JobReceivedCount == input.JobReceivedCount ||
                    (this.JobReceivedCount != null &&
                    this.JobReceivedCount.Equals(input.JobReceivedCount))
                ) && 
                (
                    this.JobFinishedCount == input.JobFinishedCount ||
                    (this.JobFinishedCount != null &&
                    this.JobFinishedCount.Equals(input.JobFinishedCount))
                ) && 
                (
                    this.JobFinishedRate == input.JobFinishedRate ||
                    (this.JobFinishedRate != null &&
                    this.JobFinishedRate.Equals(input.JobFinishedRate))
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
                if (this.MemberId != null)
                    hashCode = hashCode * 59 + this.MemberId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.ClassName != null)
                    hashCode = hashCode * 59 + this.ClassName.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.JoinTime != null)
                    hashCode = hashCode * 59 + this.JoinTime.GetHashCode();
                if (this.JobReceivedCount != null)
                    hashCode = hashCode * 59 + this.JobReceivedCount.GetHashCode();
                if (this.JobFinishedCount != null)
                    hashCode = hashCode * 59 + this.JobFinishedCount.GetHashCode();
                if (this.JobFinishedRate != null)
                    hashCode = hashCode * 59 + this.JobFinishedRate.GetHashCode();
                return hashCode;
            }
        }
    }
}
