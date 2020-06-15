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
    public class MemberJobCard 
    {

        /// <summary>
        /// 作业名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 作业均分(作业有均分该字段才返回)
        /// </summary>
        [JsonProperty("average_score", NullValueHandling = NullValueHandling.Ignore)]
        public string AverageScore { get; set; }

        /// <summary>
        /// 作业得分(作业有分数该字段才返回)
        /// </summary>
        [JsonProperty("score", NullValueHandling = NullValueHandling.Ignore)]
        public int? Score { get; set; }

        /// <summary>
        /// 作业下发时间, 日期格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("send_time", NullValueHandling = NullValueHandling.Ignore)]
        public string SendTime { get; set; }

        /// <summary>
        /// 作业最后一次提交时间, 日期格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("last_submit_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastSubmitTime { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MemberJobCard {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  averageScore: ").Append(AverageScore).Append("\n");
            sb.Append("  score: ").Append(Score).Append("\n");
            sb.Append("  sendTime: ").Append(SendTime).Append("\n");
            sb.Append("  lastSubmitTime: ").Append(LastSubmitTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MemberJobCard);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MemberJobCard input)
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
                    this.AverageScore == input.AverageScore ||
                    (this.AverageScore != null &&
                    this.AverageScore.Equals(input.AverageScore))
                ) && 
                (
                    this.Score == input.Score ||
                    (this.Score != null &&
                    this.Score.Equals(input.Score))
                ) && 
                (
                    this.SendTime == input.SendTime ||
                    (this.SendTime != null &&
                    this.SendTime.Equals(input.SendTime))
                ) && 
                (
                    this.LastSubmitTime == input.LastSubmitTime ||
                    (this.LastSubmitTime != null &&
                    this.LastSubmitTime.Equals(input.LastSubmitTime))
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
                if (this.AverageScore != null)
                    hashCode = hashCode * 59 + this.AverageScore.GetHashCode();
                if (this.Score != null)
                    hashCode = hashCode * 59 + this.Score.GetHashCode();
                if (this.SendTime != null)
                    hashCode = hashCode * 59 + this.SendTime.GetHashCode();
                if (this.LastSubmitTime != null)
                    hashCode = hashCode * 59 + this.LastSubmitTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
