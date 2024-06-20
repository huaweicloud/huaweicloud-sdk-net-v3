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
    /// 批量删除消息积压诊断报告请求
    /// </summary>
    public class BatchDeleteMessageDiagnosisReportsReq 
    {

        /// <summary>
        /// 待删除report id列表
        /// </summary>
        [JsonProperty("report_id_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ReportIdList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteMessageDiagnosisReportsReq {\n");
            sb.Append("  reportIdList: ").Append(ReportIdList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteMessageDiagnosisReportsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteMessageDiagnosisReportsReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReportIdList == input.ReportIdList ||
                    this.ReportIdList != null &&
                    input.ReportIdList != null &&
                    this.ReportIdList.SequenceEqual(input.ReportIdList)
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
                if (this.ReportIdList != null)
                    hashCode = hashCode * 59 + this.ReportIdList.GetHashCode();
                return hashCode;
            }
        }
    }
}
