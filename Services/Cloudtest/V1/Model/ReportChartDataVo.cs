using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 报表数据
    /// </summary>
    public class ReportChartDataVo 
    {

        /// <summary>
        /// 报表id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 报表名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("analyze_dim", NullValueHandling = NullValueHandling.Ignore)]
        public ReportDimVo AnalyzeDim { get; set; }

        /// <summary>
        /// 对比维度数据
        /// </summary>
        [JsonProperty("compare_dim", NullValueHandling = NullValueHandling.Ignore)]
        public List<ReportDimVo> CompareDim { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportChartDataVo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  analyzeDim: ").Append(AnalyzeDim).Append("\n");
            sb.Append("  compareDim: ").Append(CompareDim).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReportChartDataVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReportChartDataVo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.AnalyzeDim != input.AnalyzeDim || (this.AnalyzeDim != null && !this.AnalyzeDim.Equals(input.AnalyzeDim))) return false;
            if (this.CompareDim != input.CompareDim || (this.CompareDim != null && input.CompareDim != null && !this.CompareDim.SequenceEqual(input.CompareDim))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AnalyzeDim != null) hashCode = hashCode * 59 + this.AnalyzeDim.GetHashCode();
                if (this.CompareDim != null) hashCode = hashCode * 59 + this.CompareDim.GetHashCode();
                return hashCode;
            }
        }
    }
}
