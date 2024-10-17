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
    /// service item
    /// </summary>
    public class AddServiceItemsUsingPOSTRequestBodyServiceItems 
    {

        /// <summary>
        /// 协议类型:TCP为6，UDP为17，ICMP为1，ICMPV6为58，ANY为-1，手动类型不为空，自动类型为空
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public int? Protocol { get; set; }

        /// <summary>
        /// 源端口
        /// </summary>
        [JsonProperty("source_port", NullValueHandling = NullValueHandling.Ignore)]
        public string SourcePort { get; set; }

        /// <summary>
        /// 目的端口
        /// </summary>
        [JsonProperty("dest_port", NullValueHandling = NullValueHandling.Ignore)]
        public string DestPort { get; set; }

        /// <summary>
        /// 服务成员描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddServiceItemsUsingPOSTRequestBodyServiceItems {\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  sourcePort: ").Append(SourcePort).Append("\n");
            sb.Append("  destPort: ").Append(DestPort).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddServiceItemsUsingPOSTRequestBodyServiceItems);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddServiceItemsUsingPOSTRequestBodyServiceItems input)
        {
            if (input == null) return false;
            if (this.Protocol != input.Protocol || (this.Protocol != null && !this.Protocol.Equals(input.Protocol))) return false;
            if (this.SourcePort != input.SourcePort || (this.SourcePort != null && !this.SourcePort.Equals(input.SourcePort))) return false;
            if (this.DestPort != input.DestPort || (this.DestPort != null && !this.DestPort.Equals(input.DestPort))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                if (this.Protocol != null) hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.SourcePort != null) hashCode = hashCode * 59 + this.SourcePort.GetHashCode();
                if (this.DestPort != null) hashCode = hashCode * 59 + this.DestPort.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
