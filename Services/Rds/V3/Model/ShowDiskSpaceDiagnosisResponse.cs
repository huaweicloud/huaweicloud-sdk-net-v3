using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowDiskSpaceDiagnosisResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  诊断结果执行状态。  **约束限制**：  不涉及。  **取值范围**：  -FINISHED (已完成) -RUNNING (诊断中) -UNEXECUTED (未执行诊断)  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**：  各维度诊断信息。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        public List<DiskSpaceDiagnosisResult> Results { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDiskSpaceDiagnosisResponse {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  results: ").Append(Results).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDiskSpaceDiagnosisResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDiskSpaceDiagnosisResponse input)
        {
            if (input == null) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Results != input.Results || (this.Results != null && input.Results != null && !this.Results.SequenceEqual(input.Results))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Results != null) hashCode = hashCode * 59 + this.Results.GetHashCode();
                return hashCode;
            }
        }
    }
}
