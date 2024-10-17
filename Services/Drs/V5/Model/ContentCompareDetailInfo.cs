using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 内容对比详情信息体。
    /// </summary>
    public class ContentCompareDetailInfo 
    {

        /// <summary>
        /// 源库库名。
        /// </summary>
        [JsonProperty("source_db", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceDb { get; set; }

        /// <summary>
        /// 目标库库名。
        /// </summary>
        [JsonProperty("target_db", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetDb { get; set; }

        /// <summary>
        /// 源库表名。
        /// </summary>
        [JsonProperty("source_table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceTableName { get; set; }

        /// <summary>
        /// 目标库表名。
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
        /// 对比不一致行数。
        /// </summary>
        [JsonProperty("difference_row_num", NullValueHandling = NullValueHandling.Ignore)]
        public long? DifferenceRowNum { get; set; }

        /// <summary>
        /// 行对比结果。取值： - true：一致。 - false：不一致。
        /// </summary>
        [JsonProperty("line_compare_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LineCompareResult { get; set; }

        /// <summary>
        /// 内容对比结果。取值： - true：一致。 - false：不一致。
        /// </summary>
        [JsonProperty("content_compare_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ContentCompareResult { get; set; }

        /// <summary>
        /// 失败原因。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentCompareDetailInfo {\n");
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
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ContentCompareDetailInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ContentCompareDetailInfo input)
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
                return hashCode;
            }
        }
    }
}
