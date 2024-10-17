using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListDiagnosisTasksResponse : SdkResponse
    {

        /// <summary>
        /// 诊断报告列表
        /// </summary>
        [JsonProperty("diagnosis_report_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<DiagnosisReportInfo> DiagnosisReportList { get; set; }

        /// <summary>
        /// 诊断报告总数
        /// </summary>
        [JsonProperty("total_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDiagnosisTasksResponse {\n");
            sb.Append("  diagnosisReportList: ").Append(DiagnosisReportList).Append("\n");
            sb.Append("  totalNum: ").Append(TotalNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDiagnosisTasksResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDiagnosisTasksResponse input)
        {
            if (input == null) return false;
            if (this.DiagnosisReportList != input.DiagnosisReportList || (this.DiagnosisReportList != null && input.DiagnosisReportList != null && !this.DiagnosisReportList.SequenceEqual(input.DiagnosisReportList))) return false;
            if (this.TotalNum != input.TotalNum || (this.TotalNum != null && !this.TotalNum.Equals(input.TotalNum))) return false;

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
                if (this.DiagnosisReportList != null) hashCode = hashCode * 59 + this.DiagnosisReportList.GetHashCode();
                if (this.TotalNum != null) hashCode = hashCode * 59 + this.TotalNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
