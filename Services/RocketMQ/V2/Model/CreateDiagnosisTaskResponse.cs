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
    public class CreateDiagnosisTaskResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 报告ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("report_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ReportId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDiagnosisTaskResponse {\n");
            sb.Append("  reportId: ").Append(ReportId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDiagnosisTaskResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDiagnosisTaskResponse input)
        {
            if (input == null) return false;
            if (this.ReportId != input.ReportId || (this.ReportId != null && !this.ReportId.Equals(input.ReportId))) return false;

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
                if (this.ReportId != null) hashCode = hashCode * 59 + this.ReportId.GetHashCode();
                return hashCode;
            }
        }
    }
}
