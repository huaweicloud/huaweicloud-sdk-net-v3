using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListMessageDiagnosisReportsResponse : SdkResponse
    {

        /// <summary>
        /// 诊断报告列表
        /// </summary>
        [JsonProperty("report_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<KafkaMessageDiagnosisReportInfoEntity> ReportList { get; set; }

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
            sb.Append("class ListMessageDiagnosisReportsResponse {\n");
            sb.Append("  reportList: ").Append(ReportList).Append("\n");
            sb.Append("  totalNum: ").Append(TotalNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListMessageDiagnosisReportsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMessageDiagnosisReportsResponse input)
        {
            if (input == null) return false;
            if (this.ReportList != input.ReportList || (this.ReportList != null && input.ReportList != null && !this.ReportList.SequenceEqual(input.ReportList))) return false;
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
                if (this.ReportList != null) hashCode = hashCode * 59 + this.ReportList.GetHashCode();
                if (this.TotalNum != null) hashCode = hashCode * 59 + this.TotalNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
