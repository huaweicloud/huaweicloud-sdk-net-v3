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
    /// 返回结果
    /// </summary>
    public class ListJobResult 
    {

        /// <summary>
        /// 任务总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 任务列表
        /// </summary>
        [JsonProperty("job_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListJobResultJobList> JobList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListJobResult {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  jobList: ").Append(JobList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListJobResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListJobResult input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.JobList != input.JobList || (this.JobList != null && input.JobList != null && !this.JobList.SequenceEqual(input.JobList))) return false;

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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.JobList != null) hashCode = hashCode * 59 + this.JobList.GetHashCode();
                return hashCode;
            }
        }
    }
}
