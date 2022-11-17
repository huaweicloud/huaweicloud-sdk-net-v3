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
    public class JobRecords 
    {

        /// <summary>
        /// 第XX次提交
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 习题判题得分
        /// </summary>
        [JsonProperty("auto_score", NullValueHandling = NullValueHandling.Ignore)]
        public int? AutoScore { get; set; }

        /// <summary>
        /// 习题用例通过数
        /// </summary>
        [JsonProperty("case_pass_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? CasePassCount { get; set; }

        /// <summary>
        /// 习题用例总数
        /// </summary>
        [JsonProperty("exe_case_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExeCaseCount { get; set; }

        /// <summary>
        /// 代码行数
        /// </summary>
        [JsonProperty("code_line", NullValueHandling = NullValueHandling.Ignore)]
        public int? CodeLine { get; set; }

        /// <summary>
        /// 习题提交时间, 日期格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("commit_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitTime { get; set; }

        /// <summary>
        /// 习题圈复杂度
        /// </summary>
        [JsonProperty("complexity_file_avg", NullValueHandling = NullValueHandling.Ignore)]
        public string ComplexityFileAvg { get; set; }

        /// <summary>
        /// 习题判题耗时(毫秒)
        /// </summary>
        [JsonProperty("auto_score_using_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? AutoScoreUsingTime { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobRecords {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  autoScore: ").Append(AutoScore).Append("\n");
            sb.Append("  casePassCount: ").Append(CasePassCount).Append("\n");
            sb.Append("  exeCaseCount: ").Append(ExeCaseCount).Append("\n");
            sb.Append("  codeLine: ").Append(CodeLine).Append("\n");
            sb.Append("  commitTime: ").Append(CommitTime).Append("\n");
            sb.Append("  complexityFileAvg: ").Append(ComplexityFileAvg).Append("\n");
            sb.Append("  autoScoreUsingTime: ").Append(AutoScoreUsingTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobRecords);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobRecords input)
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
                    this.AutoScore == input.AutoScore ||
                    (this.AutoScore != null &&
                    this.AutoScore.Equals(input.AutoScore))
                ) && 
                (
                    this.CasePassCount == input.CasePassCount ||
                    (this.CasePassCount != null &&
                    this.CasePassCount.Equals(input.CasePassCount))
                ) && 
                (
                    this.ExeCaseCount == input.ExeCaseCount ||
                    (this.ExeCaseCount != null &&
                    this.ExeCaseCount.Equals(input.ExeCaseCount))
                ) && 
                (
                    this.CodeLine == input.CodeLine ||
                    (this.CodeLine != null &&
                    this.CodeLine.Equals(input.CodeLine))
                ) && 
                (
                    this.CommitTime == input.CommitTime ||
                    (this.CommitTime != null &&
                    this.CommitTime.Equals(input.CommitTime))
                ) && 
                (
                    this.ComplexityFileAvg == input.ComplexityFileAvg ||
                    (this.ComplexityFileAvg != null &&
                    this.ComplexityFileAvg.Equals(input.ComplexityFileAvg))
                ) && 
                (
                    this.AutoScoreUsingTime == input.AutoScoreUsingTime ||
                    (this.AutoScoreUsingTime != null &&
                    this.AutoScoreUsingTime.Equals(input.AutoScoreUsingTime))
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
                if (this.AutoScore != null)
                    hashCode = hashCode * 59 + this.AutoScore.GetHashCode();
                if (this.CasePassCount != null)
                    hashCode = hashCode * 59 + this.CasePassCount.GetHashCode();
                if (this.ExeCaseCount != null)
                    hashCode = hashCode * 59 + this.ExeCaseCount.GetHashCode();
                if (this.CodeLine != null)
                    hashCode = hashCode * 59 + this.CodeLine.GetHashCode();
                if (this.CommitTime != null)
                    hashCode = hashCode * 59 + this.CommitTime.GetHashCode();
                if (this.ComplexityFileAvg != null)
                    hashCode = hashCode * 59 + this.ComplexityFileAvg.GetHashCode();
                if (this.AutoScoreUsingTime != null)
                    hashCode = hashCode * 59 + this.AutoScoreUsingTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
