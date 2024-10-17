using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// entities字段数据结构说明
    /// </summary>
    public class Entities 
    {

        /// <summary>
        /// 子任务数量。没有子任务时为0
        /// </summary>
        [JsonProperty("sub_jobs_total", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubJobsTotal { get; set; }

        /// <summary>
        /// 每个子任务的执行信息。没有子任务时为空列表
        /// </summary>
        [JsonProperty("sub_jobs", NullValueHandling = NullValueHandling.Ignore)]
        public List<SubJobs> SubJobs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Entities {\n");
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
            return this.Equals(input as Entities);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Entities input)
        {
            if (input == null) return false;
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
                if (this.SubJobsTotal != null) hashCode = hashCode * 59 + this.SubJobsTotal.GetHashCode();
                if (this.SubJobs != null) hashCode = hashCode * 59 + this.SubJobs.GetHashCode();
                return hashCode;
            }
        }
    }
}
