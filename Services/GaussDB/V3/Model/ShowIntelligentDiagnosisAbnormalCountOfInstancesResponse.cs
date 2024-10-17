using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowIntelligentDiagnosisAbnormalCountOfInstancesResponse : SdkResponse
    {

        /// <summary>
        /// 诊断信息列表。
        /// </summary>
        [JsonProperty("diagnosis_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<DiagnosisInfo> DiagnosisInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowIntelligentDiagnosisAbnormalCountOfInstancesResponse {\n");
            sb.Append("  diagnosisInfo: ").Append(DiagnosisInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowIntelligentDiagnosisAbnormalCountOfInstancesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowIntelligentDiagnosisAbnormalCountOfInstancesResponse input)
        {
            if (input == null) return false;
            if (this.DiagnosisInfo != input.DiagnosisInfo || (this.DiagnosisInfo != null && input.DiagnosisInfo != null && !this.DiagnosisInfo.SequenceEqual(input.DiagnosisInfo))) return false;

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
                if (this.DiagnosisInfo != null) hashCode = hashCode * 59 + this.DiagnosisInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
