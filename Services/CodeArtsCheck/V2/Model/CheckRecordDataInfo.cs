using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CheckRecordDataInfo 
    {

        /// <summary>
        /// 检查任务执行开始时间
        /// </summary>
        [JsonProperty("check_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckTime { get; set; }

        /// <summary>
        /// 检查任务执行结束时间
        /// </summary>
        [JsonProperty("check_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckEndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("issue_counts", NullValueHandling = NullValueHandling.Ignore)]
        public CheckRecordIssueCountsInfo IssueCounts { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckRecordDataInfo {\n");
            sb.Append("  checkTime: ").Append(CheckTime).Append("\n");
            sb.Append("  checkEndTime: ").Append(CheckEndTime).Append("\n");
            sb.Append("  issueCounts: ").Append(IssueCounts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckRecordDataInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckRecordDataInfo input)
        {
            if (input == null) return false;
            if (this.CheckTime != input.CheckTime || (this.CheckTime != null && !this.CheckTime.Equals(input.CheckTime))) return false;
            if (this.CheckEndTime != input.CheckEndTime || (this.CheckEndTime != null && !this.CheckEndTime.Equals(input.CheckEndTime))) return false;
            if (this.IssueCounts != input.IssueCounts || (this.IssueCounts != null && !this.IssueCounts.Equals(input.IssueCounts))) return false;

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
                if (this.CheckTime != null) hashCode = hashCode * 59 + this.CheckTime.GetHashCode();
                if (this.CheckEndTime != null) hashCode = hashCode * 59 + this.CheckEndTime.GetHashCode();
                if (this.IssueCounts != null) hashCode = hashCode * 59 + this.IssueCounts.GetHashCode();
                return hashCode;
            }
        }
    }
}
