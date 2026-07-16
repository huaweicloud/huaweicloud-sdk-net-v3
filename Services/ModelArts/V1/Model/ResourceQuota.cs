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
    /// 资源配额参数。
    /// </summary>
    public class ResourceQuota 
    {

        /// <summary>
        /// **参数解释**：资源类型 **取值范围**：可选值如下： -  VPC：虚拟私有云。 -  SUBNET：子网。 -  SECURITY_GROUP：安全组。 -  SECURITY_GROUP_RULE：安全组规则。 -  PUBLIC_IP：公网IP。 -  VPC_PEER：VPC对端链接个数。 -  FIREWALL：防火墙。 -  SHARE_BANDWIDTH：共享带宽。 -  SHARE_BANDWIDTH_IP：共享带宽IP。 -  LOADBALANCER：负载均衡。 -  LISTENER：监听器。 -  PHYSICAL_CONNECT：物理连接。 -  VIRTUAL_INTERFACE：虚拟接口。 -  VPC_CONTAIN_ROUTETABLE：VPC包含的路由表。 -  ROUTETABLE_CONTAIN_ROUTES：路由表包含的路由。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**： 资源配额上限。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("quota", NullValueHandling = NullValueHandling.Ignore)]
        public string Quota { get; set; }

        /// <summary>
        /// **参数解释**： 已使用配额。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("used", NullValueHandling = NullValueHandling.Ignore)]
        public string Used { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceQuota {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  quota: ").Append(Quota).Append("\n");
            sb.Append("  used: ").Append(Used).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceQuota);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceQuota input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Quota != input.Quota || (this.Quota != null && !this.Quota.Equals(input.Quota))) return false;
            if (this.Used != input.Used || (this.Used != null && !this.Used.Equals(input.Used))) return false;

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
                if (this.Quota != null) hashCode = hashCode * 59 + this.Quota.GetHashCode();
                if (this.Used != null) hashCode = hashCode * 59 + this.Used.GetHashCode();
                return hashCode;
            }
        }
    }
}
