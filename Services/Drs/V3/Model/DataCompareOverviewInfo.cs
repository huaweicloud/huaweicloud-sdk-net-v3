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
    /// 行数对比总览详情
    /// </summary>
    public class DataCompareOverviewInfo 
    {

        /// <summary>
        /// 源库库名
        /// </summary>
        [JsonProperty("source_db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceDbName { get; set; }

        /// <summary>
        /// 目标库库名
        /// </summary>
        [JsonProperty("target_db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetDbName { get; set; }

        /// <summary>
        /// 对比状态。 - 0：对比不一致 - 2：对比一致 - 3：目标库表不存在 - 4：对比失败 - 5：正在对比中 - 6：等待对比中 - 7：任务已取消 - 8：源库为空 - 9：目标库为空 - 10：源库和目标库都为空 - 11：源表不存在 - 12：目标表不存在 - 13：原表和目标表都不存在 - 14：源数据库连接失败 - 15：目标库数据库连接失败 - 16：源数据库执行SQL超时 - 17：目标数据库执行SQL超时 - 18：源数据库执行SQL错误 - 19：目标数据库执行SQL错误 - 20：源库和目标库都不存在 - 21：源库不存在 - 22：目标库不存在 - 23：行数为亿行，未进行对比 - 27：超时
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 总表数。
        /// </summary>
        [JsonProperty("compare_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? CompareNum { get; set; }

        /// <summary>
        /// 已完成表数。
        /// </summary>
        [JsonProperty("compare_end_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? CompareEndNum { get; set; }

        /// <summary>
        /// 不一致表数。
        /// </summary>
        [JsonProperty("data_inconsistent_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? DataInconsistentNum { get; set; }

        /// <summary>
        /// 无法对比表数。
        /// </summary>
        [JsonProperty("uncomparable_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? UncomparableNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataCompareOverviewInfo {\n");
            sb.Append("  sourceDbName: ").Append(SourceDbName).Append("\n");
            sb.Append("  targetDbName: ").Append(TargetDbName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  compareNum: ").Append(CompareNum).Append("\n");
            sb.Append("  compareEndNum: ").Append(CompareEndNum).Append("\n");
            sb.Append("  dataInconsistentNum: ").Append(DataInconsistentNum).Append("\n");
            sb.Append("  uncomparableNum: ").Append(UncomparableNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DataCompareOverviewInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DataCompareOverviewInfo input)
        {
            if (input == null) return false;
            if (this.SourceDbName != input.SourceDbName || (this.SourceDbName != null && !this.SourceDbName.Equals(input.SourceDbName))) return false;
            if (this.TargetDbName != input.TargetDbName || (this.TargetDbName != null && !this.TargetDbName.Equals(input.TargetDbName))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.CompareNum != input.CompareNum || (this.CompareNum != null && !this.CompareNum.Equals(input.CompareNum))) return false;
            if (this.CompareEndNum != input.CompareEndNum || (this.CompareEndNum != null && !this.CompareEndNum.Equals(input.CompareEndNum))) return false;
            if (this.DataInconsistentNum != input.DataInconsistentNum || (this.DataInconsistentNum != null && !this.DataInconsistentNum.Equals(input.DataInconsistentNum))) return false;
            if (this.UncomparableNum != input.UncomparableNum || (this.UncomparableNum != null && !this.UncomparableNum.Equals(input.UncomparableNum))) return false;

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
                if (this.SourceDbName != null) hashCode = hashCode * 59 + this.SourceDbName.GetHashCode();
                if (this.TargetDbName != null) hashCode = hashCode * 59 + this.TargetDbName.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CompareNum != null) hashCode = hashCode * 59 + this.CompareNum.GetHashCode();
                if (this.CompareEndNum != null) hashCode = hashCode * 59 + this.CompareEndNum.GetHashCode();
                if (this.DataInconsistentNum != null) hashCode = hashCode * 59 + this.DataInconsistentNum.GetHashCode();
                if (this.UncomparableNum != null) hashCode = hashCode * 59 + this.UncomparableNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
