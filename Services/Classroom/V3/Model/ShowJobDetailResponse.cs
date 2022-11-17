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
    /// Response Object
    /// </summary>
    public class ShowJobDetailResponse : SdkResponse
    {

        /// <summary>
        /// 作业下发人数
        /// </summary>
        [JsonProperty("accept_job_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? AcceptJobNum { get; set; }

        /// <summary>
        /// 作业截止时间, 日期格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 作业答案是否公布(unpublish:表示未公布答案, publish:表示已公布答案)
        /// </summary>
        [JsonProperty("is_answer_visibility", NullValueHandling = NullValueHandling.Ignore)]
        public string IsAnswerVisibility { get; set; }

        /// <summary>
        /// 作业成绩是否公布(unpublish:表示未公布成绩, publish:表示已公布成绩)
        /// </summary>
        [JsonProperty("is_score_visibility", NullValueHandling = NullValueHandling.Ignore)]
        public string IsScoreVisibility { get; set; }

        /// <summary>
        /// 作业均分
        /// </summary>
        [JsonProperty("average_score", NullValueHandling = NullValueHandling.Ignore)]
        public string AverageScore { get; set; }

        /// <summary>
        /// 老师手动评分人数
        /// </summary>
        [JsonProperty("score_job_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? ScoreJobNum { get; set; }

        /// <summary>
        /// 作业提交人数
        /// </summary>
        [JsonProperty("submit_job_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubmitJobNum { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowJobDetailResponse {\n");
            sb.Append("  acceptJobNum: ").Append(AcceptJobNum).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  isAnswerVisibility: ").Append(IsAnswerVisibility).Append("\n");
            sb.Append("  isScoreVisibility: ").Append(IsScoreVisibility).Append("\n");
            sb.Append("  averageScore: ").Append(AverageScore).Append("\n");
            sb.Append("  scoreJobNum: ").Append(ScoreJobNum).Append("\n");
            sb.Append("  submitJobNum: ").Append(SubmitJobNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowJobDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowJobDetailResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AcceptJobNum == input.AcceptJobNum ||
                    (this.AcceptJobNum != null &&
                    this.AcceptJobNum.Equals(input.AcceptJobNum))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.IsAnswerVisibility == input.IsAnswerVisibility ||
                    (this.IsAnswerVisibility != null &&
                    this.IsAnswerVisibility.Equals(input.IsAnswerVisibility))
                ) && 
                (
                    this.IsScoreVisibility == input.IsScoreVisibility ||
                    (this.IsScoreVisibility != null &&
                    this.IsScoreVisibility.Equals(input.IsScoreVisibility))
                ) && 
                (
                    this.AverageScore == input.AverageScore ||
                    (this.AverageScore != null &&
                    this.AverageScore.Equals(input.AverageScore))
                ) && 
                (
                    this.ScoreJobNum == input.ScoreJobNum ||
                    (this.ScoreJobNum != null &&
                    this.ScoreJobNum.Equals(input.ScoreJobNum))
                ) && 
                (
                    this.SubmitJobNum == input.SubmitJobNum ||
                    (this.SubmitJobNum != null &&
                    this.SubmitJobNum.Equals(input.SubmitJobNum))
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
                if (this.AcceptJobNum != null)
                    hashCode = hashCode * 59 + this.AcceptJobNum.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.IsAnswerVisibility != null)
                    hashCode = hashCode * 59 + this.IsAnswerVisibility.GetHashCode();
                if (this.IsScoreVisibility != null)
                    hashCode = hashCode * 59 + this.IsScoreVisibility.GetHashCode();
                if (this.AverageScore != null)
                    hashCode = hashCode * 59 + this.AverageScore.GetHashCode();
                if (this.ScoreJobNum != null)
                    hashCode = hashCode * 59 + this.ScoreJobNum.GetHashCode();
                if (this.SubmitJobNum != null)
                    hashCode = hashCode * 59 + this.SubmitJobNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
