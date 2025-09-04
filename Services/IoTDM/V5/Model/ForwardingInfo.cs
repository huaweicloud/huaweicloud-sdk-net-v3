using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDM.V5.Model
{
    /// <summary>
    /// 企业版实例的SNAT配置信息。 
    /// </summary>
    public class ForwardingInfo 
    {

        /// <summary>
        /// **参数说明**：NAT网关绑定的EIP 
        /// </summary>
        [JsonProperty("eip", NullValueHandling = NullValueHandling.Ignore)]
        public string Eip { get; set; }

        /// <summary>
        /// **参数说明**：是否启用SNAT配置。 **取值范围**： - true: SNAT配置已启用 - false: SNAT配置未启用 
        /// </summary>
        [JsonProperty("enable_snat", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableSnat { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForwardingInfo {\n");
            sb.Append("  eip: ").Append(Eip).Append("\n");
            sb.Append("  enableSnat: ").Append(EnableSnat).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ForwardingInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ForwardingInfo input)
        {
            if (input == null) return false;
            if (this.Eip != input.Eip || (this.Eip != null && !this.Eip.Equals(input.Eip))) return false;
            if (this.EnableSnat != input.EnableSnat || (this.EnableSnat != null && !this.EnableSnat.Equals(input.EnableSnat))) return false;

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
                if (this.Eip != null) hashCode = hashCode * 59 + this.Eip.GetHashCode();
                if (this.EnableSnat != null) hashCode = hashCode * 59 + this.EnableSnat.GetHashCode();
                return hashCode;
            }
        }
    }
}
