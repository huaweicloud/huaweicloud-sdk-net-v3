using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class BatchDeleteDiagnosisReportResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 诊断报告ID列表。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("report_id_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ReportIdList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteDiagnosisReportResponse {\n");
            sb.Append("  reportIdList: ").Append(ReportIdList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteDiagnosisReportResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteDiagnosisReportResponse input)
        {
            if (input == null) return false;
            if (this.ReportIdList != input.ReportIdList || (this.ReportIdList != null && input.ReportIdList != null && !this.ReportIdList.SequenceEqual(input.ReportIdList))) return false;

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
                if (this.ReportIdList != null) hashCode = hashCode * 59 + this.ReportIdList.GetHashCode();
                return hashCode;
            }
        }
    }
}
