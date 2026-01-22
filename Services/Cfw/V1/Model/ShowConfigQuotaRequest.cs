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
    /// Request Object
    /// </summary>
    public class ShowConfigQuotaRequest 
    {

        /// <summary>
        /// **参数解释**： 防火墙ID，用户创建防火墙实例后产生的唯一ID，配置后可区分不同防火墙，可通过[防火墙ID获取方式](cfw_02_0028.xml)获取 **约束限制**： 不涉及 **取值范围**： 32位UUID **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("fw_instance_id", IsPath = true)]
        [JsonProperty("fw_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FwInstanceId { get; set; }

        /// <summary>
        /// **参数解释**： 防火墙配额类型 **约束限制**： 不涉及 **取值范围**：   ACL：ACL规则配额   DNS_DOMAIN_SET：网络域名组配额   DOMAIN：域名组域名成员配额   DOMAIN_DEVICE：域名设备配额   DNS_DOMAIN_SET_PARSE_IP：网络域名组解析IP配额   APPLICATION_DOMAIN_SET：应用域名组配额   APPLICATION_DOMAIN_SET_ITEM：应用域名组域名成员配额   APPLICATION_DOMAIN_SET_ITEM_DEVICE：应用域名组设备配额   ADDR_SET：地址组配额   ADDR_SET_ITEM：地址组IP地址成员配额   ADDR_SET_ITEM_DEVICE：地址组IP地址设备配额   SERV_SET：服务组配额   SERV_SET_ITEM：服务组服务成员配额   SERV_SET_ITEM_DEVICE：服务组服务设备配额   BLACKLIST：黑名单配额   WHITELIST：白名单配额   PRIVATE_NETWORK_SEGMENT：私网网段配额 **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("config_type", IsQuery = true)]
        [JsonProperty("config_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigType { get; set; }

        /// <summary>
        /// **参数解释**： 组Id，查询IP地址组地址成员配额，域名组域名成员配额，服务组服务成员配额时必传，地址组id，可通过查询地址组列表接口查询获得，通过返回值中的data.records.set_id（.表示各对象之间层级的区分）获得，域名组id，可通过查询域名组列表接口查询获得，通过返回值中的data.records.set_id（.表示各对象之间层级的区分）获得，服务组id，可通过获取服务组列表接口查询获得，通过返回值中的data.records.set_id（.表示各对象之间层级的区分）获得。 **约束限制**： 不涉及 **取值范围**： 32位UUID **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("set_id", IsQuery = true)]
        [JsonProperty("set_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SetId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowConfigQuotaRequest {\n");
            sb.Append("  fwInstanceId: ").Append(FwInstanceId).Append("\n");
            sb.Append("  configType: ").Append(ConfigType).Append("\n");
            sb.Append("  setId: ").Append(SetId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowConfigQuotaRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowConfigQuotaRequest input)
        {
            if (input == null) return false;
            if (this.FwInstanceId != input.FwInstanceId || (this.FwInstanceId != null && !this.FwInstanceId.Equals(input.FwInstanceId))) return false;
            if (this.ConfigType != input.ConfigType || (this.ConfigType != null && !this.ConfigType.Equals(input.ConfigType))) return false;
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
                if (this.FwInstanceId != null) hashCode = hashCode * 59 + this.FwInstanceId.GetHashCode();
                if (this.ConfigType != null) hashCode = hashCode * 59 + this.ConfigType.GetHashCode();
                if (this.SetId != null) hashCode = hashCode * 59 + this.SetId.GetHashCode();
                return hashCode;
            }
        }
    }
}
