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
    /// 实际的数据类型：单个对象，集合或NULL
    /// </summary>
    public class CustomReportListVo 
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
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public ReportFilter Filter { get; set; }

        /// <summary>
        /// 工件类型(用例：case,测试套：task)
        /// </summary>
        [JsonProperty("workpiece_type", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkpieceType { get; set; }

        /// <summary>
        /// 分析维度
        /// </summary>
        [JsonProperty("analysis_dimension", NullValueHandling = NullValueHandling.Ignore)]
        public string AnalysisDimension { get; set; }

        /// <summary>
        /// 对比维度
        /// </summary>
        [JsonProperty("compare_dimension", NullValueHandling = NullValueHandling.Ignore)]
        public string CompareDimension { get; set; }

        /// <summary>
        /// 报表数据
        /// </summary>
        [JsonProperty("chart_data", NullValueHandling = NullValueHandling.Ignore)]
        public List<ReportChartDataVo> ChartData { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomReportListVo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  filter: ").Append(Filter).Append("\n");
            sb.Append("  workpieceType: ").Append(WorkpieceType).Append("\n");
            sb.Append("  analysisDimension: ").Append(AnalysisDimension).Append("\n");
            sb.Append("  compareDimension: ").Append(CompareDimension).Append("\n");
            sb.Append("  chartData: ").Append(ChartData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CustomReportListVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CustomReportListVo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Filter != input.Filter || (this.Filter != null && !this.Filter.Equals(input.Filter))) return false;
            if (this.WorkpieceType != input.WorkpieceType || (this.WorkpieceType != null && !this.WorkpieceType.Equals(input.WorkpieceType))) return false;
            if (this.AnalysisDimension != input.AnalysisDimension || (this.AnalysisDimension != null && !this.AnalysisDimension.Equals(input.AnalysisDimension))) return false;
            if (this.CompareDimension != input.CompareDimension || (this.CompareDimension != null && !this.CompareDimension.Equals(input.CompareDimension))) return false;
            if (this.ChartData != input.ChartData || (this.ChartData != null && input.ChartData != null && !this.ChartData.SequenceEqual(input.ChartData))) return false;

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
                if (this.Filter != null) hashCode = hashCode * 59 + this.Filter.GetHashCode();
                if (this.WorkpieceType != null) hashCode = hashCode * 59 + this.WorkpieceType.GetHashCode();
                if (this.AnalysisDimension != null) hashCode = hashCode * 59 + this.AnalysisDimension.GetHashCode();
                if (this.CompareDimension != null) hashCode = hashCode * 59 + this.CompareDimension.GetHashCode();
                if (this.ChartData != null) hashCode = hashCode * 59 + this.ChartData.GetHashCode();
                return hashCode;
            }
        }
    }
}
