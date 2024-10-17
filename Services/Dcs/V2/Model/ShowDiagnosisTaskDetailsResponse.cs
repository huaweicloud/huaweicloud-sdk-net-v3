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
    public class ShowDiagnosisTaskDetailsResponse : SdkResponse
    {

        /// <summary>
        /// 诊断结果为异常的诊断项总数
        /// </summary>
        [JsonProperty("abnormal_item_sum", NullValueHandling = NullValueHandling.Ignore)]
        public int? AbnormalItemSum { get; set; }

        /// <summary>
        /// 诊断失败的诊断项总数
        /// </summary>
        [JsonProperty("failed_item_sum", NullValueHandling = NullValueHandling.Ignore)]
        public int? FailedItemSum { get; set; }

        /// <summary>
        /// 节点诊断报告列表
        /// </summary>
        [JsonProperty("diagnosis_node_report_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<DiagnosisNodeReport> DiagnosisNodeReportList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDiagnosisTaskDetailsResponse {\n");
            sb.Append("  abnormalItemSum: ").Append(AbnormalItemSum).Append("\n");
            sb.Append("  failedItemSum: ").Append(FailedItemSum).Append("\n");
            sb.Append("  diagnosisNodeReportList: ").Append(DiagnosisNodeReportList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDiagnosisTaskDetailsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDiagnosisTaskDetailsResponse input)
        {
            if (input == null) return false;
            if (this.AbnormalItemSum != input.AbnormalItemSum || (this.AbnormalItemSum != null && !this.AbnormalItemSum.Equals(input.AbnormalItemSum))) return false;
            if (this.FailedItemSum != input.FailedItemSum || (this.FailedItemSum != null && !this.FailedItemSum.Equals(input.FailedItemSum))) return false;
            if (this.DiagnosisNodeReportList != input.DiagnosisNodeReportList || (this.DiagnosisNodeReportList != null && input.DiagnosisNodeReportList != null && !this.DiagnosisNodeReportList.SequenceEqual(input.DiagnosisNodeReportList))) return false;

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
                if (this.AbnormalItemSum != null) hashCode = hashCode * 59 + this.AbnormalItemSum.GetHashCode();
                if (this.FailedItemSum != null) hashCode = hashCode * 59 + this.FailedItemSum.GetHashCode();
                if (this.DiagnosisNodeReportList != null) hashCode = hashCode * 59 + this.DiagnosisNodeReportList.GetHashCode();
                return hashCode;
            }
        }
    }
}
