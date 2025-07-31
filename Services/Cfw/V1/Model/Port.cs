using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Port 
    {

        /// <summary>
        /// **参数解释**： 端口类型，-1 Any，0 包含，1 排除 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("port_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? PortType { get; set; }

        /// <summary>
        /// **参数解释**： 端口 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("ports", NullValueHandling = NullValueHandling.Ignore)]
        public string Ports { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Port {\n");
            sb.Append("  portType: ").Append(PortType).Append("\n");
            sb.Append("  ports: ").Append(Ports).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Port);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Port input)
        {
            if (input == null) return false;
            if (this.PortType != input.PortType || (this.PortType != null && !this.PortType.Equals(input.PortType))) return false;
            if (this.Ports != input.Ports || (this.Ports != null && !this.Ports.Equals(input.Ports))) return false;

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
                if (this.PortType != null) hashCode = hashCode * 59 + this.PortType.GetHashCode();
                if (this.Ports != null) hashCode = hashCode * 59 + this.Ports.GetHashCode();
                return hashCode;
            }
        }
    }
}
