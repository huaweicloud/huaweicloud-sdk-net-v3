using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AttachDevServerPortsRequestBody 
    {

        /// <summary>
        /// **参数解释**：网卡ID，填该参数时，表明挂载已有网卡，其他参数不用填。 **约束限制**：^[0-9a-f]{8}-[0-9a-f]{4}-[1-5][0-9a-f]{3}-[89ab][0-9a-f]{3}-[0-9a-f]{12}$。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("port_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PortId { get; set; }

        /// <summary>
        /// **参数解释**：网卡名称。 **约束限制**：不涉及。 **取值范围**：默认为空，最大长度不超过255。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：端口子网ID。 **约束限制**：参数port_id未填时，需要新建网卡进行挂载，此时network_id为必填项。 **取值范围**：必须是UUID格式的字符串。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("network_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkId { get; set; }

        /// <summary>
        /// **参数解释**：端口IP地址。 **约束限制**：不支持更新。 **取值范围**：所属网络网段。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string IpAddress { get; set; }

        /// <summary>
        /// **参数解释**：关联安全组ID列表。 **约束限制**：一个端口默认最多吃吃100个安全组。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("security_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SecurityGroups { get; set; }

        /// <summary>
        /// **参数解释**：是否使能efi。 **约束限制**：不涉及。 **取值范围**： - true：启用efi - false：不启用efi  **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("enable_efi", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableEfi { get; set; }

        /// <summary>
        /// **参数解释**：efi 协议。 **约束限制**：不涉及。 **取值范围**：1 - 64字符。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("efi_protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string EfiProtocol { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachDevServerPortsRequestBody {\n");
            sb.Append("  portId: ").Append(PortId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  networkId: ").Append(NetworkId).Append("\n");
            sb.Append("  ipAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  securityGroups: ").Append(SecurityGroups).Append("\n");
            sb.Append("  enableEfi: ").Append(EnableEfi).Append("\n");
            sb.Append("  efiProtocol: ").Append(EfiProtocol).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttachDevServerPortsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttachDevServerPortsRequestBody input)
        {
            if (input == null) return false;
            if (this.PortId != input.PortId || (this.PortId != null && !this.PortId.Equals(input.PortId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.NetworkId != input.NetworkId || (this.NetworkId != null && !this.NetworkId.Equals(input.NetworkId))) return false;
            if (this.IpAddress != input.IpAddress || (this.IpAddress != null && !this.IpAddress.Equals(input.IpAddress))) return false;
            if (this.SecurityGroups != input.SecurityGroups || (this.SecurityGroups != null && input.SecurityGroups != null && !this.SecurityGroups.SequenceEqual(input.SecurityGroups))) return false;
            if (this.EnableEfi != input.EnableEfi || (this.EnableEfi != null && !this.EnableEfi.Equals(input.EnableEfi))) return false;
            if (this.EfiProtocol != input.EfiProtocol || (this.EfiProtocol != null && !this.EfiProtocol.Equals(input.EfiProtocol))) return false;

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
                if (this.PortId != null) hashCode = hashCode * 59 + this.PortId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NetworkId != null) hashCode = hashCode * 59 + this.NetworkId.GetHashCode();
                if (this.IpAddress != null) hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.SecurityGroups != null) hashCode = hashCode * 59 + this.SecurityGroups.GetHashCode();
                if (this.EnableEfi != null) hashCode = hashCode * 59 + this.EnableEfi.GetHashCode();
                if (this.EfiProtocol != null) hashCode = hashCode * 59 + this.EfiProtocol.GetHashCode();
                return hashCode;
            }
        }
    }
}
