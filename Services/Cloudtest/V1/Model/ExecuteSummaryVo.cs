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
    /// 执行阶段信息汇总
    /// </summary>
    public class ExecuteSummaryVo 
    {

        /// <summary>
        /// 已执行用例数
        /// </summary>
        [JsonProperty("execute_case_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExecuteCaseNum { get; set; }

        /// <summary>
        /// 缺陷总数
        /// </summary>
        [JsonProperty("defect_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? DefectNum { get; set; }

        /// <summary>
        /// 已完成缺陷数
        /// </summary>
        [JsonProperty("completed_defect_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? CompletedDefectNum { get; set; }

        /// <summary>
        /// 测试用例通过率
        /// </summary>
        [JsonProperty("case_success_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string CaseSuccessRate { get; set; }

        /// <summary>
        /// 用例执行率
        /// </summary>
        [JsonProperty("case_execution_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string CaseExecutionRate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecuteSummaryVo {\n");
            sb.Append("  executeCaseNum: ").Append(ExecuteCaseNum).Append("\n");
            sb.Append("  defectNum: ").Append(DefectNum).Append("\n");
            sb.Append("  completedDefectNum: ").Append(CompletedDefectNum).Append("\n");
            sb.Append("  caseSuccessRate: ").Append(CaseSuccessRate).Append("\n");
            sb.Append("  caseExecutionRate: ").Append(CaseExecutionRate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExecuteSummaryVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExecuteSummaryVo input)
        {
            if (input == null) return false;
            if (this.ExecuteCaseNum != input.ExecuteCaseNum || (this.ExecuteCaseNum != null && !this.ExecuteCaseNum.Equals(input.ExecuteCaseNum))) return false;
            if (this.DefectNum != input.DefectNum || (this.DefectNum != null && !this.DefectNum.Equals(input.DefectNum))) return false;
            if (this.CompletedDefectNum != input.CompletedDefectNum || (this.CompletedDefectNum != null && !this.CompletedDefectNum.Equals(input.CompletedDefectNum))) return false;
            if (this.CaseSuccessRate != input.CaseSuccessRate || (this.CaseSuccessRate != null && !this.CaseSuccessRate.Equals(input.CaseSuccessRate))) return false;
            if (this.CaseExecutionRate != input.CaseExecutionRate || (this.CaseExecutionRate != null && !this.CaseExecutionRate.Equals(input.CaseExecutionRate))) return false;

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
                if (this.ExecuteCaseNum != null) hashCode = hashCode * 59 + this.ExecuteCaseNum.GetHashCode();
                if (this.DefectNum != null) hashCode = hashCode * 59 + this.DefectNum.GetHashCode();
                if (this.CompletedDefectNum != null) hashCode = hashCode * 59 + this.CompletedDefectNum.GetHashCode();
                if (this.CaseSuccessRate != null) hashCode = hashCode * 59 + this.CaseSuccessRate.GetHashCode();
                if (this.CaseExecutionRate != null) hashCode = hashCode * 59 + this.CaseExecutionRate.GetHashCode();
                return hashCode;
            }
        }
    }
}
