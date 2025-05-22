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
    /// 结果
    /// </summary>
    public class ListBuildInfoRecordBodyResult 
    {

        /// <summary>
        /// 健康度
        /// </summary>
        [JsonProperty("health_score", NullValueHandling = NullValueHandling.Ignore)]
        public string HealthScore { get; set; }

        /// <summary>
        /// 分页页数
        /// </summary>
        [JsonProperty("page_index", NullValueHandling = NullValueHandling.Ignore)]
        public string PageIndex { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [JsonProperty("total_page", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalPage { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [JsonProperty("total_record", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalRecord { get; set; }

        /// <summary>
        /// 构建历史详情列表
        /// </summary>
        [JsonProperty("job_build_states", NullValueHandling = NullValueHandling.Ignore)]
        public List<BuildInfoRecord> JobBuildStates { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListBuildInfoRecordBodyResult {\n");
            sb.Append("  healthScore: ").Append(HealthScore).Append("\n");
            sb.Append("  pageIndex: ").Append(PageIndex).Append("\n");
            sb.Append("  totalPage: ").Append(TotalPage).Append("\n");
            sb.Append("  totalRecord: ").Append(TotalRecord).Append("\n");
            sb.Append("  jobBuildStates: ").Append(JobBuildStates).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListBuildInfoRecordBodyResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListBuildInfoRecordBodyResult input)
        {
            if (input == null) return false;
            if (this.HealthScore != input.HealthScore || (this.HealthScore != null && !this.HealthScore.Equals(input.HealthScore))) return false;
            if (this.PageIndex != input.PageIndex || (this.PageIndex != null && !this.PageIndex.Equals(input.PageIndex))) return false;
            if (this.TotalPage != input.TotalPage || (this.TotalPage != null && !this.TotalPage.Equals(input.TotalPage))) return false;
            if (this.TotalRecord != input.TotalRecord || (this.TotalRecord != null && !this.TotalRecord.Equals(input.TotalRecord))) return false;
            if (this.JobBuildStates != input.JobBuildStates || (this.JobBuildStates != null && input.JobBuildStates != null && !this.JobBuildStates.SequenceEqual(input.JobBuildStates))) return false;

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
                if (this.HealthScore != null) hashCode = hashCode * 59 + this.HealthScore.GetHashCode();
                if (this.PageIndex != null) hashCode = hashCode * 59 + this.PageIndex.GetHashCode();
                if (this.TotalPage != null) hashCode = hashCode * 59 + this.TotalPage.GetHashCode();
                if (this.TotalRecord != null) hashCode = hashCode * 59 + this.TotalRecord.GetHashCode();
                if (this.JobBuildStates != null) hashCode = hashCode * 59 + this.JobBuildStates.GetHashCode();
                return hashCode;
            }
        }
    }
}
