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
    public class Out2in 
    {

        /// <summary>
        /// **参数解释**： TOP访问目的IP **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("dst_ip", NullValueHandling = NullValueHandling.Ignore)]
        public List<ItemVO> DstIp { get; set; }

        /// <summary>
        /// **参数解释**： TOP开放端口 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("dst_port", NullValueHandling = NullValueHandling.Ignore)]
        public List<ItemVO> DstPort { get; set; }

        /// <summary>
        /// **参数解释**： TOP访问源IP **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("src_ip", NullValueHandling = NullValueHandling.Ignore)]
        public List<ItemVO> SrcIp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Out2in {\n");
            sb.Append("  dstIp: ").Append(DstIp).Append("\n");
            sb.Append("  dstPort: ").Append(DstPort).Append("\n");
            sb.Append("  srcIp: ").Append(SrcIp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Out2in);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Out2in input)
        {
            if (input == null) return false;
            if (this.DstIp != input.DstIp || (this.DstIp != null && input.DstIp != null && !this.DstIp.SequenceEqual(input.DstIp))) return false;
            if (this.DstPort != input.DstPort || (this.DstPort != null && input.DstPort != null && !this.DstPort.SequenceEqual(input.DstPort))) return false;
            if (this.SrcIp != input.SrcIp || (this.SrcIp != null && input.SrcIp != null && !this.SrcIp.SequenceEqual(input.SrcIp))) return false;

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
                if (this.DstIp != null) hashCode = hashCode * 59 + this.DstIp.GetHashCode();
                if (this.DstPort != null) hashCode = hashCode * 59 + this.DstPort.GetHashCode();
                if (this.SrcIp != null) hashCode = hashCode * 59 + this.SrcIp.GetHashCode();
                return hashCode;
            }
        }
    }
}
