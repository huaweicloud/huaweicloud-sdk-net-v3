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
    public class ShowJobBuildTimeResult 
    {

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 平均构建时长
        /// </summary>
        [JsonProperty("avg_build_time", NullValueHandling = NullValueHandling.Ignore)]
        public double? AvgBuildTime { get; set; }

        /// <summary>
        /// 最长时间
        /// </summary>
        [JsonProperty("max_build_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxBuildTime { get; set; }

        /// <summary>
        /// 最短时间
        /// </summary>
        [JsonProperty("min_build_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? MinBuildTime { get; set; }

        /// <summary>
        /// 每日构建数据
        /// </summary>
        [JsonProperty("chart", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowJobBuildTimeResultChart> Chart { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowJobBuildTimeResult {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  avgBuildTime: ").Append(AvgBuildTime).Append("\n");
            sb.Append("  maxBuildTime: ").Append(MaxBuildTime).Append("\n");
            sb.Append("  minBuildTime: ").Append(MinBuildTime).Append("\n");
            sb.Append("  chart: ").Append(Chart).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowJobBuildTimeResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowJobBuildTimeResult input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.AvgBuildTime != input.AvgBuildTime || (this.AvgBuildTime != null && !this.AvgBuildTime.Equals(input.AvgBuildTime))) return false;
            if (this.MaxBuildTime != input.MaxBuildTime || (this.MaxBuildTime != null && !this.MaxBuildTime.Equals(input.MaxBuildTime))) return false;
            if (this.MinBuildTime != input.MinBuildTime || (this.MinBuildTime != null && !this.MinBuildTime.Equals(input.MinBuildTime))) return false;
            if (this.Chart != input.Chart || (this.Chart != null && input.Chart != null && !this.Chart.SequenceEqual(input.Chart))) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.AvgBuildTime != null) hashCode = hashCode * 59 + this.AvgBuildTime.GetHashCode();
                if (this.MaxBuildTime != null) hashCode = hashCode * 59 + this.MaxBuildTime.GetHashCode();
                if (this.MinBuildTime != null) hashCode = hashCode * 59 + this.MinBuildTime.GetHashCode();
                if (this.Chart != null) hashCode = hashCode * 59 + this.Chart.GetHashCode();
                return hashCode;
            }
        }
    }
}
