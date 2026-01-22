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
    /// 一键逃生/一键恢复返回数据
    /// </summary>
    public class SwitchFirewallEipProtectionRespData 
    {

        /// <summary>
        /// **参数解释**： 防火墙防护状态，0: 正常状态, 1: bypass进行中, 2: bypass成功, 3: bypass失败, 4: 恢复中, 5: 恢复失败 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("protection_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProtectionStatus { get; set; }

        /// <summary>
        /// **参数解释**： 防火墙ID，用户创建防火墙实例后产生的唯一ID，配置后可区分不同防火墙，可通过[防火墙ID获取方式](cfw_02_0028.xml)获取 **约束限制**： 不涉及 **取值范围**： 32位UUID **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**： 防护对象ID，是创建云防火墙后用于区分互联网边界防护和VPC边界防护的标志id，可通过调用[查询防火墙实例接口](ListFirewallDetail.xml)获得，通过返回值中的data.records.protect_objects.object_id（.表示各对象之间层级的区分）获得，注意type为0的为互联网边界防护对象id，type为1的为VPC边界防护对象id。 **约束限制**： 不涉及 **取值范围**： 32位UUID **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SwitchFirewallEipProtectionRespData {\n");
            sb.Append("  protectionStatus: ").Append(ProtectionStatus).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  objectId: ").Append(ObjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SwitchFirewallEipProtectionRespData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SwitchFirewallEipProtectionRespData input)
        {
            if (input == null) return false;
            if (this.ProtectionStatus != input.ProtectionStatus || (this.ProtectionStatus != null && !this.ProtectionStatus.Equals(input.ProtectionStatus))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ObjectId != input.ObjectId || (this.ObjectId != null && !this.ObjectId.Equals(input.ObjectId))) return false;

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
                if (this.ProtectionStatus != null) hashCode = hashCode * 59 + this.ProtectionStatus.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ObjectId != null) hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
