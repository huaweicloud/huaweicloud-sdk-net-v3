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
    /// 
    /// </summary>
    public class ListJunitCoverageSummaryResultUnitSummaryList 
    {

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 构建任务的构建编号，从1开始，每次构建递增1
        /// </summary>
        [JsonProperty("build_no", NullValueHandling = NullValueHandling.Ignore)]
        public int? BuildNo { get; set; }

        /// <summary>
        /// stage名称
        /// </summary>
        [JsonProperty("stage_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StageName { get; set; }

        /// <summary>
        /// 资源ID，下载覆盖率报告时使用
        /// </summary>
        [JsonProperty("root_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RootId { get; set; }

        /// <summary>
        /// 租户所在region
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListJunitCoverageSummaryResultUnitSummaryList {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  buildNo: ").Append(BuildNo).Append("\n");
            sb.Append("  stageName: ").Append(StageName).Append("\n");
            sb.Append("  rootId: ").Append(RootId).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListJunitCoverageSummaryResultUnitSummaryList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListJunitCoverageSummaryResultUnitSummaryList input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.BuildNo != input.BuildNo || (this.BuildNo != null && !this.BuildNo.Equals(input.BuildNo))) return false;
            if (this.StageName != input.StageName || (this.StageName != null && !this.StageName.Equals(input.StageName))) return false;
            if (this.RootId != input.RootId || (this.RootId != null && !this.RootId.Equals(input.RootId))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;

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
                if (this.BuildNo != null) hashCode = hashCode * 59 + this.BuildNo.GetHashCode();
                if (this.StageName != null) hashCode = hashCode * 59 + this.StageName.GetHashCode();
                if (this.RootId != null) hashCode = hashCode * 59 + this.RootId.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                return hashCode;
            }
        }
    }
}
