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
    /// 表级别对比结果信息体
    /// </summary>
    public class TableLineCompareResultInfo 
    {

        /// <summary>
        /// 源库表名称
        /// </summary>
        [JsonProperty("source_table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceTableName { get; set; }

        /// <summary>
        /// 源库表行数
        /// </summary>
        [JsonProperty("source_row_num", NullValueHandling = NullValueHandling.Ignore)]
        public long? SourceRowNum { get; set; }

        /// <summary>
        /// 目标库表名称
        /// </summary>
        [JsonProperty("target_table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetTableName { get; set; }

        /// <summary>
        /// 目标库表行数
        /// </summary>
        [JsonProperty("target_row_num", NullValueHandling = NullValueHandling.Ignore)]
        public long? TargetRowNum { get; set; }

        /// <summary>
        /// 行数差异值
        /// </summary>
        [JsonProperty("difference_row_num", NullValueHandling = NullValueHandling.Ignore)]
        public long? DifferenceRowNum { get; set; }

        /// <summary>
        /// 对比状态。 - 0：对比不一致 - 2：对比一致 - 3：目标库表不存在 - 4：对比失败 - 5：正在对比中 - 6：等待对比中 - 7：任务已取消 - 8：源库为空 - 9：目标库为空 - 10：源库和目标库都为空 - 11：源表不存在 - 12：目标表不存在 - 13：原表和目标表都不存在 - 14：源数据库连接失败 - 15：目标库数据库连接失败 - 16：源数据库执行SQL超时 - 17：目标数据库执行SQL超时 - 18：源数据库执行SQL错误 - 19：目标数据库执行SQL错误 - 20：源库和目标库都不存在 - 21：源库不存在 - 22：目标库不存在 - 23：行数为亿行，未进行对比 - 27：超时
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 行过滤配置条件
        /// </summary>
        [JsonProperty("compare_line_config_filter", NullValueHandling = NullValueHandling.Ignore)]
        public string CompareLineConfigFilter { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TableLineCompareResultInfo {\n");
            sb.Append("  sourceTableName: ").Append(SourceTableName).Append("\n");
            sb.Append("  sourceRowNum: ").Append(SourceRowNum).Append("\n");
            sb.Append("  targetTableName: ").Append(TargetTableName).Append("\n");
            sb.Append("  targetRowNum: ").Append(TargetRowNum).Append("\n");
            sb.Append("  differenceRowNum: ").Append(DifferenceRowNum).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  compareLineConfigFilter: ").Append(CompareLineConfigFilter).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TableLineCompareResultInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TableLineCompareResultInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourceTableName == input.SourceTableName ||
                    (this.SourceTableName != null &&
                    this.SourceTableName.Equals(input.SourceTableName))
                ) && 
                (
                    this.SourceRowNum == input.SourceRowNum ||
                    (this.SourceRowNum != null &&
                    this.SourceRowNum.Equals(input.SourceRowNum))
                ) && 
                (
                    this.TargetTableName == input.TargetTableName ||
                    (this.TargetTableName != null &&
                    this.TargetTableName.Equals(input.TargetTableName))
                ) && 
                (
                    this.TargetRowNum == input.TargetRowNum ||
                    (this.TargetRowNum != null &&
                    this.TargetRowNum.Equals(input.TargetRowNum))
                ) && 
                (
                    this.DifferenceRowNum == input.DifferenceRowNum ||
                    (this.DifferenceRowNum != null &&
                    this.DifferenceRowNum.Equals(input.DifferenceRowNum))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.CompareLineConfigFilter == input.CompareLineConfigFilter ||
                    (this.CompareLineConfigFilter != null &&
                    this.CompareLineConfigFilter.Equals(input.CompareLineConfigFilter))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.SourceTableName != null)
                    hashCode = hashCode * 59 + this.SourceTableName.GetHashCode();
                if (this.SourceRowNum != null)
                    hashCode = hashCode * 59 + this.SourceRowNum.GetHashCode();
                if (this.TargetTableName != null)
                    hashCode = hashCode * 59 + this.TargetTableName.GetHashCode();
                if (this.TargetRowNum != null)
                    hashCode = hashCode * 59 + this.TargetRowNum.GetHashCode();
                if (this.DifferenceRowNum != null)
                    hashCode = hashCode * 59 + this.DifferenceRowNum.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CompareLineConfigFilter != null)
                    hashCode = hashCode * 59 + this.CompareLineConfigFilter.GetHashCode();
                return hashCode;
            }
        }
    }
}
