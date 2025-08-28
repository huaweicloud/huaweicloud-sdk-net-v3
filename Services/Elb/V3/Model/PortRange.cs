using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PortRange 
    {

        /// <summary>
        /// **参数解释**：起始端口。  **约束限制**：不涉及  **取值范围**：1-65535  **默认取值：不涉及
        /// </summary>
        [JsonProperty("start_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartPort { get; set; }

        /// <summary>
        /// **参数解释**：结束端口，需大于等于起始端口  **约束限制**：不涉及  **取值范围**：1-65535  **默认取值：不涉及
        /// </summary>
        [JsonProperty("end_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? EndPort { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PortRange {\n");
            sb.Append("  startPort: ").Append(StartPort).Append("\n");
            sb.Append("  endPort: ").Append(EndPort).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PortRange);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PortRange input)
        {
            if (input == null) return false;
            if (this.StartPort != input.StartPort || (this.StartPort != null && !this.StartPort.Equals(input.StartPort))) return false;
            if (this.EndPort != input.EndPort || (this.EndPort != null && !this.EndPort.Equals(input.EndPort))) return false;

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
                if (this.StartPort != null) hashCode = hashCode * 59 + this.StartPort.GetHashCode();
                if (this.EndPort != null) hashCode = hashCode * 59 + this.EndPort.GetHashCode();
                return hashCode;
            }
        }
    }
}
