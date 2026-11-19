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
    public class ShowTaurusDbSlowProcessThresholdResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**:  慢会话阈值，单位为秒。  **取值范围**：  1-86400。 
        /// </summary>
        [JsonProperty("slow_process_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? SlowProcessThreshold { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTaurusDbSlowProcessThresholdResponse {\n");
            sb.Append("  slowProcessThreshold: ").Append(SlowProcessThreshold).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTaurusDbSlowProcessThresholdResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTaurusDbSlowProcessThresholdResponse input)
        {
            if (input == null) return false;
            if (this.SlowProcessThreshold != input.SlowProcessThreshold || (this.SlowProcessThreshold != null && !this.SlowProcessThreshold.Equals(input.SlowProcessThreshold))) return false;

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
                if (this.SlowProcessThreshold != null) hashCode = hashCode * 59 + this.SlowProcessThreshold.GetHashCode();
                return hashCode;
            }
        }
    }
}
