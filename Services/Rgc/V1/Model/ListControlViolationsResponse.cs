using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rgc.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListControlViolationsResponse : SdkResponse
    {

        /// <summary>
        /// 控制策略合规性。
        /// </summary>
        [JsonProperty("control_violations", NullValueHandling = NullValueHandling.Ignore)]
        public List<ControlViolation> ControlViolations { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListControlViolationsResponse {\n");
            sb.Append("  controlViolations: ").Append(ControlViolations).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListControlViolationsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListControlViolationsResponse input)
        {
            if (input == null) return false;
            if (this.ControlViolations != input.ControlViolations || (this.ControlViolations != null && input.ControlViolations != null && !this.ControlViolations.SequenceEqual(input.ControlViolations))) return false;

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
                if (this.ControlViolations != null) hashCode = hashCode * 59 + this.ControlViolations.GetHashCode();
                return hashCode;
            }
        }
    }
}
