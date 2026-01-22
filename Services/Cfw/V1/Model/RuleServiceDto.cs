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
    /// RuleServiceDto
    /// </summary>
    public class RuleServiceDto 
    {

        /// <summary>
        /// **参数解释**： 服务输入类型，用于明确规则的服务输入类型。 **约束限制**： 不涉及 **取值范围**： 0为手动输入类型，1为自动输入类型 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; }

        /// <summary>
        /// **参数解释**： 服务协议类型，用于明确规则引用服务协议类型。 **约束限制**： type为0（手动类型）时，此处不能为空。 **取值范围**： 协议类型：TCP为6，UDP为17，ICMP为1，ICMPv6为58，Any为-1 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public int? Protocol { get; set; }

        /// <summary>
        /// **参数解释**： 协议列表，用于明确规则引用协议列表。 **约束限制**： type为0（手动类型）时，此处不能为空。 **取值范围**： 协议类型：TCP为6，UDP为17，ICMP为1，ICMPv6为58，Any为-1 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("protocols", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Protocols { get; set; }

        /// <summary>
        /// **参数解释**： 源端口，会话发起方的端口。 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("source_port", NullValueHandling = NullValueHandling.Ignore)]
        public string SourcePort { get; set; }

        /// <summary>
        /// **参数解释**： 目的端口，会话接收方的端口。 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("dest_port", NullValueHandling = NullValueHandling.Ignore)]
        public string DestPort { get; set; }

        /// <summary>
        /// **参数解释**： 服务组ID，用于明确规则引用服务组，可通过[获取服务组列表接口](ListServiceSets.xml)查询获得，通过返回值中的data.records.set_id（.表示各对象之间层级的区分）获得。 **约束限制**： 当address的type为1（关联IP地址组）时，此处不能为空 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("service_set_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceSetId { get; set; }

        /// <summary>
        /// **参数解释**： 服务（协议、源端口、目的端口）组的名称，用于明确规则引用服务组，可通过[获取服务组列表接口](ListServiceSets.xml)查询获得，通过返回值中的data.records.name（.表示各对象之间层级的区分）获得。 **约束限制**： 当address的type为1（关联IP地址组）时，此处不能为空 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("service_set_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceSetName { get; set; }

        /// <summary>
        /// **参数解释**： 自定义服务，用于明确规则引用服务。 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("custom_service", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServiceItem> CustomService { get; set; }

        /// <summary>
        /// **参数解释**： 预定义服务组ID列表，用于明确规则引用预定义服务组。服务组ID可通过[获取服务组列表接口](ListServiceSets.xml)查询获得，通过返回值中的data.records.set_id（.表示各对象之间层级的区分）获得。 **约束限制**： 查询条件中query_service_set_type需要设置为1预定义服务组。 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("predefined_group", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PredefinedGroup { get; set; }

        /// <summary>
        /// **参数解释**： 服务组ID列表，用于明确规则引用服务组。服务组ID可通过[获取服务组列表接口](ListServiceSets.xml)查询获得，通过返回值中的data.records.set_id（.表示各对象之间层级的区分）获得。 **约束限制**： 查询条件中query_service_set_type需要设置为0自定义服务组。 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("service_group", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ServiceGroup { get; set; }

        /// <summary>
        /// **参数解释**： 服务（协议、源端口、目的端口）组的名称。列表。 **约束限制**： 不涉及
        /// </summary>
        [JsonProperty("service_group_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServiceGroupVO> ServiceGroupNames { get; set; }

        /// <summary>
        /// **参数解释**： 服务组类型，用于明确规则引用服务组类型。 **约束限制**： 不涉及 **取值范围**： 0表示自定义服务组，1表示常用Web服务，2表示常用远程登录和PING，3表示常用数据库 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("service_set_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceSetType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleServiceDto {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  protocols: ").Append(Protocols).Append("\n");
            sb.Append("  sourcePort: ").Append(SourcePort).Append("\n");
            sb.Append("  destPort: ").Append(DestPort).Append("\n");
            sb.Append("  serviceSetId: ").Append(ServiceSetId).Append("\n");
            sb.Append("  serviceSetName: ").Append(ServiceSetName).Append("\n");
            sb.Append("  customService: ").Append(CustomService).Append("\n");
            sb.Append("  predefinedGroup: ").Append(PredefinedGroup).Append("\n");
            sb.Append("  serviceGroup: ").Append(ServiceGroup).Append("\n");
            sb.Append("  serviceGroupNames: ").Append(ServiceGroupNames).Append("\n");
            sb.Append("  serviceSetType: ").Append(ServiceSetType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RuleServiceDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RuleServiceDto input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Protocol != input.Protocol || (this.Protocol != null && !this.Protocol.Equals(input.Protocol))) return false;
            if (this.Protocols != input.Protocols || (this.Protocols != null && input.Protocols != null && !this.Protocols.SequenceEqual(input.Protocols))) return false;
            if (this.SourcePort != input.SourcePort || (this.SourcePort != null && !this.SourcePort.Equals(input.SourcePort))) return false;
            if (this.DestPort != input.DestPort || (this.DestPort != null && !this.DestPort.Equals(input.DestPort))) return false;
            if (this.ServiceSetId != input.ServiceSetId || (this.ServiceSetId != null && !this.ServiceSetId.Equals(input.ServiceSetId))) return false;
            if (this.ServiceSetName != input.ServiceSetName || (this.ServiceSetName != null && !this.ServiceSetName.Equals(input.ServiceSetName))) return false;
            if (this.CustomService != input.CustomService || (this.CustomService != null && input.CustomService != null && !this.CustomService.SequenceEqual(input.CustomService))) return false;
            if (this.PredefinedGroup != input.PredefinedGroup || (this.PredefinedGroup != null && input.PredefinedGroup != null && !this.PredefinedGroup.SequenceEqual(input.PredefinedGroup))) return false;
            if (this.ServiceGroup != input.ServiceGroup || (this.ServiceGroup != null && input.ServiceGroup != null && !this.ServiceGroup.SequenceEqual(input.ServiceGroup))) return false;
            if (this.ServiceGroupNames != input.ServiceGroupNames || (this.ServiceGroupNames != null && input.ServiceGroupNames != null && !this.ServiceGroupNames.SequenceEqual(input.ServiceGroupNames))) return false;
            if (this.ServiceSetType != input.ServiceSetType || (this.ServiceSetType != null && !this.ServiceSetType.Equals(input.ServiceSetType))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Protocol != null) hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.Protocols != null) hashCode = hashCode * 59 + this.Protocols.GetHashCode();
                if (this.SourcePort != null) hashCode = hashCode * 59 + this.SourcePort.GetHashCode();
                if (this.DestPort != null) hashCode = hashCode * 59 + this.DestPort.GetHashCode();
                if (this.ServiceSetId != null) hashCode = hashCode * 59 + this.ServiceSetId.GetHashCode();
                if (this.ServiceSetName != null) hashCode = hashCode * 59 + this.ServiceSetName.GetHashCode();
                if (this.CustomService != null) hashCode = hashCode * 59 + this.CustomService.GetHashCode();
                if (this.PredefinedGroup != null) hashCode = hashCode * 59 + this.PredefinedGroup.GetHashCode();
                if (this.ServiceGroup != null) hashCode = hashCode * 59 + this.ServiceGroup.GetHashCode();
                if (this.ServiceGroupNames != null) hashCode = hashCode * 59 + this.ServiceGroupNames.GetHashCode();
                if (this.ServiceSetType != null) hashCode = hashCode * 59 + this.ServiceSetType.GetHashCode();
                return hashCode;
            }
        }
    }
}
