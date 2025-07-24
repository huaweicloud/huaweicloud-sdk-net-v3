using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 内容对比详情
    /// </summary>
    public class NodeContentCompareDetailResult 
    {

        /// <summary>
        /// 源库名称。
        /// </summary>
        [JsonProperty("source_db", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceDb { get; set; }

        /// <summary>
        /// 目标库名称。
        /// </summary>
        [JsonProperty("target_db", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetDb { get; set; }

        /// <summary>
        /// 源库的表名称。
        /// </summary>
        [JsonProperty("source_table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceTableName { get; set; }

        /// <summary>
        /// 目标库名称。
        /// </summary>
        [JsonProperty("target_table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetTableName { get; set; }

        /// <summary>
        /// 源库表行数。
        /// </summary>
        [JsonProperty("source_row_num", NullValueHandling = NullValueHandling.Ignore)]
        public long? SourceRowNum { get; set; }

        /// <summary>
        /// 目标库表行数。
        /// </summary>
        [JsonProperty("target_row_num", NullValueHandling = NullValueHandling.Ignore)]
        public long? TargetRowNum { get; set; }

        /// <summary>
        /// 源库的表和目标库的表的差异值。
        /// </summary>
        [JsonProperty("difference_row_num", NullValueHandling = NullValueHandling.Ignore)]
        public long? DifferenceRowNum { get; set; }

        /// <summary>
        /// 行对比结果。 - true：一致 - false：不一致
        /// </summary>
        [JsonProperty("line_compare_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LineCompareResult { get; set; }

        /// <summary>
        /// 内容对比结果。 - true：一致 - false：不一致
        /// </summary>
        [JsonProperty("content_compare_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ContentCompareResult { get; set; }

        /// <summary>
        /// 附加信息。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// 行过滤配置条件
        /// </summary>
        [JsonProperty("compare_line_config_filter", NullValueHandling = NullValueHandling.Ignore)]
        public string CompareLineConfigFilter { get; set; }

        /// <summary>
        /// 全量比对状态。 -1：对比中 -2：已完成 -3：待对比 -4：已取消
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 已对比分片数。
        /// </summary>
        [JsonProperty("complete_shard_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? CompleteShardCount { get; set; }

        /// <summary>
        /// 总分片数。
        /// </summary>
        [JsonProperty("total_shard_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalShardCount { get; set; }

        /// <summary>
        /// 比对进度。
        /// </summary>
        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public double? Progress { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeContentCompareDetailResult {\n");
            sb.Append("  sourceDb: ").Append(SourceDb).Append("\n");
            sb.Append("  targetDb: ").Append(TargetDb).Append("\n");
            sb.Append("  sourceTableName: ").Append(SourceTableName).Append("\n");
            sb.Append("  targetTableName: ").Append(TargetTableName).Append("\n");
            sb.Append("  sourceRowNum: ").Append(SourceRowNum).Append("\n");
            sb.Append("  targetRowNum: ").Append(TargetRowNum).Append("\n");
            sb.Append("  differenceRowNum: ").Append(DifferenceRowNum).Append("\n");
            sb.Append("  lineCompareResult: ").Append(LineCompareResult).Append("\n");
            sb.Append("  contentCompareResult: ").Append(ContentCompareResult).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  compareLineConfigFilter: ").Append(CompareLineConfigFilter).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  completeShardCount: ").Append(CompleteShardCount).Append("\n");
            sb.Append("  totalShardCount: ").Append(TotalShardCount).Append("\n");
            sb.Append("  progress: ").Append(Progress).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeContentCompareDetailResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeContentCompareDetailResult input)
        {
            if (input == null) return false;
            if (this.SourceDb != input.SourceDb || (this.SourceDb != null && !this.SourceDb.Equals(input.SourceDb))) return false;
            if (this.TargetDb != input.TargetDb || (this.TargetDb != null && !this.TargetDb.Equals(input.TargetDb))) return false;
            if (this.SourceTableName != input.SourceTableName || (this.SourceTableName != null && !this.SourceTableName.Equals(input.SourceTableName))) return false;
            if (this.TargetTableName != input.TargetTableName || (this.TargetTableName != null && !this.TargetTableName.Equals(input.TargetTableName))) return false;
            if (this.SourceRowNum != input.SourceRowNum || (this.SourceRowNum != null && !this.SourceRowNum.Equals(input.SourceRowNum))) return false;
            if (this.TargetRowNum != input.TargetRowNum || (this.TargetRowNum != null && !this.TargetRowNum.Equals(input.TargetRowNum))) return false;
            if (this.DifferenceRowNum != input.DifferenceRowNum || (this.DifferenceRowNum != null && !this.DifferenceRowNum.Equals(input.DifferenceRowNum))) return false;
            if (this.LineCompareResult != input.LineCompareResult || (this.LineCompareResult != null && !this.LineCompareResult.Equals(input.LineCompareResult))) return false;
            if (this.ContentCompareResult != input.ContentCompareResult || (this.ContentCompareResult != null && !this.ContentCompareResult.Equals(input.ContentCompareResult))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.CompareLineConfigFilter != input.CompareLineConfigFilter || (this.CompareLineConfigFilter != null && !this.CompareLineConfigFilter.Equals(input.CompareLineConfigFilter))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.CompleteShardCount != input.CompleteShardCount || (this.CompleteShardCount != null && !this.CompleteShardCount.Equals(input.CompleteShardCount))) return false;
            if (this.TotalShardCount != input.TotalShardCount || (this.TotalShardCount != null && !this.TotalShardCount.Equals(input.TotalShardCount))) return false;
            if (this.Progress != input.Progress || (this.Progress != null && !this.Progress.Equals(input.Progress))) return false;

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
                if (this.SourceDb != null) hashCode = hashCode * 59 + this.SourceDb.GetHashCode();
                if (this.TargetDb != null) hashCode = hashCode * 59 + this.TargetDb.GetHashCode();
                if (this.SourceTableName != null) hashCode = hashCode * 59 + this.SourceTableName.GetHashCode();
                if (this.TargetTableName != null) hashCode = hashCode * 59 + this.TargetTableName.GetHashCode();
                if (this.SourceRowNum != null) hashCode = hashCode * 59 + this.SourceRowNum.GetHashCode();
                if (this.TargetRowNum != null) hashCode = hashCode * 59 + this.TargetRowNum.GetHashCode();
                if (this.DifferenceRowNum != null) hashCode = hashCode * 59 + this.DifferenceRowNum.GetHashCode();
                if (this.LineCompareResult != null) hashCode = hashCode * 59 + this.LineCompareResult.GetHashCode();
                if (this.ContentCompareResult != null) hashCode = hashCode * 59 + this.ContentCompareResult.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.CompareLineConfigFilter != null) hashCode = hashCode * 59 + this.CompareLineConfigFilter.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CompleteShardCount != null) hashCode = hashCode * 59 + this.CompleteShardCount.GetHashCode();
                if (this.TotalShardCount != null) hashCode = hashCode * 59 + this.TotalShardCount.GetHashCode();
                if (this.Progress != null) hashCode = hashCode * 59 + this.Progress.GetHashCode();
                return hashCode;
            }
        }
    }
}
