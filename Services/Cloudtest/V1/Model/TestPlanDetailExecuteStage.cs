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
    /// 测试计划执行阶段信息
    /// </summary>
    public class TestPlanDetailExecuteStage 
    {

        /// <summary>
        /// 缺陷个数
        /// </summary>
        [JsonProperty("defect_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? DefectCount { get; set; }

        /// <summary>
        /// 已完成缺陷个数
        /// </summary>
        [JsonProperty("completed_defect_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? CompletedDefectCount { get; set; }

        /// <summary>
        /// 用例通过率,按用例结果计算
        /// </summary>
        [JsonProperty("case_pass_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string CasePassRate { get; set; }

        /// <summary>
        /// 已执行用例数, 按用例状态统计
        /// </summary>
        [JsonProperty("executed_case_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExecutedCaseCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestPlanDetailExecuteStage {\n");
            sb.Append("  defectCount: ").Append(DefectCount).Append("\n");
            sb.Append("  completedDefectCount: ").Append(CompletedDefectCount).Append("\n");
            sb.Append("  casePassRate: ").Append(CasePassRate).Append("\n");
            sb.Append("  executedCaseCount: ").Append(ExecutedCaseCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TestPlanDetailExecuteStage);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TestPlanDetailExecuteStage input)
        {
            if (input == null) return false;
            if (this.DefectCount != input.DefectCount || (this.DefectCount != null && !this.DefectCount.Equals(input.DefectCount))) return false;
            if (this.CompletedDefectCount != input.CompletedDefectCount || (this.CompletedDefectCount != null && !this.CompletedDefectCount.Equals(input.CompletedDefectCount))) return false;
            if (this.CasePassRate != input.CasePassRate || (this.CasePassRate != null && !this.CasePassRate.Equals(input.CasePassRate))) return false;
            if (this.ExecutedCaseCount != input.ExecutedCaseCount || (this.ExecutedCaseCount != null && !this.ExecutedCaseCount.Equals(input.ExecutedCaseCount))) return false;

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
                if (this.DefectCount != null) hashCode = hashCode * 59 + this.DefectCount.GetHashCode();
                if (this.CompletedDefectCount != null) hashCode = hashCode * 59 + this.CompletedDefectCount.GetHashCode();
                if (this.CasePassRate != null) hashCode = hashCode * 59 + this.CasePassRate.GetHashCode();
                if (this.ExecutedCaseCount != null) hashCode = hashCode * 59 + this.ExecutedCaseCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
