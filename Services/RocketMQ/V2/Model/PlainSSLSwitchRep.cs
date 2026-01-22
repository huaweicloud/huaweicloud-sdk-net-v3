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
    /// 
    /// </summary>
    public class PlainSSLSwitchRep 
    {

        /// <summary>
        /// **参数解释**： 协议模式。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("tls_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string TlsMode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlainSSLSwitchRep {\n");
            sb.Append("  tlsMode: ").Append(TlsMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PlainSSLSwitchRep);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PlainSSLSwitchRep input)
        {
            if (input == null) return false;
            if (this.TlsMode != input.TlsMode || (this.TlsMode != null && !this.TlsMode.Equals(input.TlsMode))) return false;

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
                if (this.TlsMode != null) hashCode = hashCode * 59 + this.TlsMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
