using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Chart 
    {

        /// <summary>
        /// 统计时间
        /// </summary>
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public string Date { get; set; }

        /// <summary>
        /// 完成story工单
        /// </summary>
        [JsonProperty("finished_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? FinishedNum { get; set; }

        /// <summary>
        /// 迭代id
        /// </summary>
        [JsonProperty("iteration_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? IterationId { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("project_num_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProjectNumId { get; set; }

        /// <summary>
        /// 未完成story数
        /// </summary>
        [JsonProperty("remaining_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? RemainingNum { get; set; }

        /// <summary>
        /// 总story数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Chart {\n");
            sb.Append("  date: ").Append(Date).Append("\n");
            sb.Append("  finishedNum: ").Append(FinishedNum).Append("\n");
            sb.Append("  iterationId: ").Append(IterationId).Append("\n");
            sb.Append("  projectNumId: ").Append(ProjectNumId).Append("\n");
            sb.Append("  remainingNum: ").Append(RemainingNum).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Chart);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Chart input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.FinishedNum == input.FinishedNum ||
                    (this.FinishedNum != null &&
                    this.FinishedNum.Equals(input.FinishedNum))
                ) && 
                (
                    this.IterationId == input.IterationId ||
                    (this.IterationId != null &&
                    this.IterationId.Equals(input.IterationId))
                ) && 
                (
                    this.ProjectNumId == input.ProjectNumId ||
                    (this.ProjectNumId != null &&
                    this.ProjectNumId.Equals(input.ProjectNumId))
                ) && 
                (
                    this.RemainingNum == input.RemainingNum ||
                    (this.RemainingNum != null &&
                    this.RemainingNum.Equals(input.RemainingNum))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
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
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.FinishedNum != null)
                    hashCode = hashCode * 59 + this.FinishedNum.GetHashCode();
                if (this.IterationId != null)
                    hashCode = hashCode * 59 + this.IterationId.GetHashCode();
                if (this.ProjectNumId != null)
                    hashCode = hashCode * 59 + this.ProjectNumId.GetHashCode();
                if (this.RemainingNum != null)
                    hashCode = hashCode * 59 + this.RemainingNum.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
