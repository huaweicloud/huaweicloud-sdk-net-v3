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
    public class ServiceGroupVO 
    {

        /// <summary>
        /// **参数解释**： 服务（协议、源端口、目的端口）组的名称。 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 协议列表 **约束限制**： 不涉及 **取值范围**： - 6：TCP - 17：UDP - 1：ICMP - 58：ICMPV6 - -1：Any **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("protocols", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Protocols { get; set; }

        /// <summary>
        /// **参数解释**： 服务（协议、源端口、目的端口）组的类型 **约束限制**： 不涉及 **取值范围**： 0表示自定义服务组，1表示预定义服务组 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("service_set_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceSetType { get; set; }

        /// <summary>
        /// **参数解释**： 服务组ID，可通过[获取服务组列表接口](ListServiceSets.xml)查询获得，通过返回值中的data.records.set_id（.表示各对象之间层级的区分）获得。 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("set_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SetId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceGroupVO {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  protocols: ").Append(Protocols).Append("\n");
            sb.Append("  serviceSetType: ").Append(ServiceSetType).Append("\n");
            sb.Append("  setId: ").Append(SetId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServiceGroupVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServiceGroupVO input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Protocols != input.Protocols || (this.Protocols != null && input.Protocols != null && !this.Protocols.SequenceEqual(input.Protocols))) return false;
            if (this.ServiceSetType != input.ServiceSetType || (this.ServiceSetType != null && !this.ServiceSetType.Equals(input.ServiceSetType))) return false;
            if (this.SetId != input.SetId || (this.SetId != null && !this.SetId.Equals(input.SetId))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Protocols != null) hashCode = hashCode * 59 + this.Protocols.GetHashCode();
                if (this.ServiceSetType != null) hashCode = hashCode * 59 + this.ServiceSetType.GetHashCode();
                if (this.SetId != null) hashCode = hashCode * 59 + this.SetId.GetHashCode();
                return hashCode;
            }
        }
    }
}
