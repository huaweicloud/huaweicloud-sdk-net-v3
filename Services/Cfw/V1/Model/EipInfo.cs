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
    public class EipInfo 
    {

        /// <summary>
        /// **参数解释**： 弹性公网ID，可通过调用弹性IP列表查询获取，通过返回值中的data.records.id（.表示各对象之间层级的区分）获得 **约束限制**： 不涉及 **取值范围**： 32位UUID **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("eip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EipId { get; set; }

        /// <summary>
        /// **参数解释**： 防火墙ID，用户创建防火墙实例后产生的唯一ID，配置后可区分不同防火墙，可通过[防火墙ID获取方式](cfw_02_0028.xml)获取 **约束限制**： 不涉及 **取值范围**： 32位UUID **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("fw_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FwInstanceId { get; set; }

        /// <summary>
        /// **参数解释**： 防护对象ID，是创建云防火墙后用于区分互联网边界防护和VPC边界防护的标志ID，可通过调用[查询防火墙实例接口](ListFirewallDetail.xml)获得，通过返回值中的data.records.protect_objects.object_id（.表示各对象之间层级的区分）获得，注意type为0的为互联网边界防护对象ID，type为1的为VPC边界防护对象ID。 **约束限制**： 不涉及 **取值范围**： 32位UUID **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }

        /// <summary>
        /// **参数解释**： IPV4地址  **约束限制**： 不涉及 **取值范围**： 不涉及   **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("public_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIp { get; set; }

        /// <summary>
        /// **参数解释**： IPV6地址  **约束限制**： 不涉及 **取值范围**： 不涉及   **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("public_ipv6", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIpv6 { get; set; }

        /// <summary>
        /// **参数解释**： EIP白名单标志 **约束限制**： 不涉及 **取值范围**： 0表示是EIP白名单，1表示不是EIP白名单 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EipInfo {\n");
            sb.Append("  eipId: ").Append(EipId).Append("\n");
            sb.Append("  fwInstanceId: ").Append(FwInstanceId).Append("\n");
            sb.Append("  objectId: ").Append(ObjectId).Append("\n");
            sb.Append("  publicIp: ").Append(PublicIp).Append("\n");
            sb.Append("  publicIpv6: ").Append(PublicIpv6).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EipInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EipInfo input)
        {
            if (input == null) return false;
            if (this.EipId != input.EipId || (this.EipId != null && !this.EipId.Equals(input.EipId))) return false;
            if (this.FwInstanceId != input.FwInstanceId || (this.FwInstanceId != null && !this.FwInstanceId.Equals(input.FwInstanceId))) return false;
            if (this.ObjectId != input.ObjectId || (this.ObjectId != null && !this.ObjectId.Equals(input.ObjectId))) return false;
            if (this.PublicIp != input.PublicIp || (this.PublicIp != null && !this.PublicIp.Equals(input.PublicIp))) return false;
            if (this.PublicIpv6 != input.PublicIpv6 || (this.PublicIpv6 != null && !this.PublicIpv6.Equals(input.PublicIpv6))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;

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
                if (this.EipId != null) hashCode = hashCode * 59 + this.EipId.GetHashCode();
                if (this.FwInstanceId != null) hashCode = hashCode * 59 + this.FwInstanceId.GetHashCode();
                if (this.ObjectId != null) hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.PublicIp != null) hashCode = hashCode * 59 + this.PublicIp.GetHashCode();
                if (this.PublicIpv6 != null) hashCode = hashCode * 59 + this.PublicIpv6.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
