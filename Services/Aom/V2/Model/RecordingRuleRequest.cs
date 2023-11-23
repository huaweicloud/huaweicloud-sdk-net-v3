using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RecordingRuleRequest 
    {

        /// <summary>
        /// recordingRule
        /// </summary>
        [JsonProperty("recording_rule", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordingRule { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordingRuleRequest {\n");
            sb.Append("  recordingRule: ").Append(RecordingRule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecordingRuleRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RecordingRuleRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RecordingRule == input.RecordingRule ||
                    (this.RecordingRule != null &&
                    this.RecordingRule.Equals(input.RecordingRule))
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
                if (this.RecordingRule != null)
                    hashCode = hashCode * 59 + this.RecordingRule.GetHashCode();
                return hashCode;
            }
        }
    }
}
