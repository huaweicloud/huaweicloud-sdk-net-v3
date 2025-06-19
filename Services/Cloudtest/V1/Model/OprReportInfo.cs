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
    /// 
    /// </summary>
    public class OprReportInfo 
    {

        /// <summary>
        /// 报表名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 报表类型 1：首页用例库， 2：质量报告
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; }

        /// <summary>
        /// 工件类型(用例：case,测试套：suite)
        /// </summary>
        [JsonProperty("workpiece_type", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkpieceType { get; set; }

        /// <summary>
        /// 分析维度
        /// </summary>
        [JsonProperty("analysis_dim_row", NullValueHandling = NullValueHandling.Ignore)]
        public string AnalysisDimRow { get; set; }

        /// <summary>
        /// 对比维度
        /// </summary>
        [JsonProperty("compare_dim_column", NullValueHandling = NullValueHandling.Ignore)]
        public string CompareDimColumn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public ReportFilter Filter { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OprReportInfo {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  workpieceType: ").Append(WorkpieceType).Append("\n");
            sb.Append("  analysisDimRow: ").Append(AnalysisDimRow).Append("\n");
            sb.Append("  compareDimColumn: ").Append(CompareDimColumn).Append("\n");
            sb.Append("  filter: ").Append(Filter).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OprReportInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OprReportInfo input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.WorkpieceType != input.WorkpieceType || (this.WorkpieceType != null && !this.WorkpieceType.Equals(input.WorkpieceType))) return false;
            if (this.AnalysisDimRow != input.AnalysisDimRow || (this.AnalysisDimRow != null && !this.AnalysisDimRow.Equals(input.AnalysisDimRow))) return false;
            if (this.CompareDimColumn != input.CompareDimColumn || (this.CompareDimColumn != null && !this.CompareDimColumn.Equals(input.CompareDimColumn))) return false;
            if (this.Filter != input.Filter || (this.Filter != null && !this.Filter.Equals(input.Filter))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.WorkpieceType != null) hashCode = hashCode * 59 + this.WorkpieceType.GetHashCode();
                if (this.AnalysisDimRow != null) hashCode = hashCode * 59 + this.AnalysisDimRow.GetHashCode();
                if (this.CompareDimColumn != null) hashCode = hashCode * 59 + this.CompareDimColumn.GetHashCode();
                if (this.Filter != null) hashCode = hashCode * 59 + this.Filter.GetHashCode();
                return hashCode;
            }
        }
    }
}
