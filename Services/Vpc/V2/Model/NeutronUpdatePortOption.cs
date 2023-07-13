using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class NeutronUpdatePortOption 
    {

        /// <summary>
        /// 功能说明：网络的名称 取值范围：0-255个字符
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 功能说明：扩展属性：安全组的UUID 例如：\&quot;security_groups\&quot;: [\&quot;a0608cbf-d047-4f54-8b28-cd7b59853fff\&quot;] 约束：不支持更新为空
        /// </summary>
        [JsonProperty("security_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SecurityGroups { get; set; }

        /// <summary>
        /// 功能说明：扩展属性：IP/Mac对列表，allow_address_pair参见“allow_address_pair对象”表 约束：  - IP地址不允许为 “0.0.0.0”  - 如果allowed_address_pairs配置地址池较大的CIDR（掩码小于24位），建议为该port配置一个单独的安全组  - 硬件SDN环境不支持ip_address属性配置为CIDR格式  - 为虚拟IP配置后端ECS场景，allowed_address_pairs中配置的IP地址，必须为ECS网卡已有的IP地址，否则可能会导致虚拟IP通信异常。
        /// </summary>
        [JsonProperty("allowed_address_pairs", NullValueHandling = NullValueHandling.Ignore)]
        public List<AllowedAddressPair> AllowedAddressPairs { get; set; }

        /// <summary>
        /// 扩展属性：DHCP的扩展Option
        /// </summary>
        [JsonProperty("extra_dhcp_opts", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExtraDhcpOpt> ExtraDhcpOpts { get; set; }

        /// <summary>
        /// 功能说明：端口安全使能标记，如果不使能则安全组和dhcp防欺骗不生效，默认为true
        /// </summary>
        [JsonProperty("port_security_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PortSecurityEnabled { get; set; }

        /// <summary>
        /// 绑定的vNIC类型  - normal: 软交换
        /// </summary>
        [JsonProperty("binding:vnic_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BindingvnicType { get; set; }

        /// <summary>
        /// 功能说明：扩展属性，提供用户设置自定义信息  - internal_elb字段，布尔类型，普通租户可见。只有在创建内网ELB的虚拟IP的网卡时设置为true。普通租户没有权限更改该字段，由系统维护。 举例：{\&quot;internal_elb\&quot;: true}  - disable_security_groups字段，布尔类型，普通租户可见。默认为false，高性能通信场景下，允许指定为true。仅支持创建port和读取时指定。当前仅支持指定为true，不支持指定为false。 举例：{\&quot;disable_security_groups\&quot;：true }，当前仅支持指定为true，不支持指定为false，指定为true时，FWaaS功能不生效。
        /// </summary>
        [JsonProperty("binding:profile", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> Bindingprofile { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronUpdatePortOption {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  securityGroups: ").Append(SecurityGroups).Append("\n");
            sb.Append("  allowedAddressPairs: ").Append(AllowedAddressPairs).Append("\n");
            sb.Append("  extraDhcpOpts: ").Append(ExtraDhcpOpts).Append("\n");
            sb.Append("  portSecurityEnabled: ").Append(PortSecurityEnabled).Append("\n");
            sb.Append("  bindingvnicType: ").Append(BindingvnicType).Append("\n");
            sb.Append("  bindingprofile: ").Append(Bindingprofile).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronUpdatePortOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronUpdatePortOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SecurityGroups == input.SecurityGroups ||
                    this.SecurityGroups != null &&
                    input.SecurityGroups != null &&
                    this.SecurityGroups.SequenceEqual(input.SecurityGroups)
                ) && 
                (
                    this.AllowedAddressPairs == input.AllowedAddressPairs ||
                    this.AllowedAddressPairs != null &&
                    input.AllowedAddressPairs != null &&
                    this.AllowedAddressPairs.SequenceEqual(input.AllowedAddressPairs)
                ) && 
                (
                    this.ExtraDhcpOpts == input.ExtraDhcpOpts ||
                    this.ExtraDhcpOpts != null &&
                    input.ExtraDhcpOpts != null &&
                    this.ExtraDhcpOpts.SequenceEqual(input.ExtraDhcpOpts)
                ) && 
                (
                    this.PortSecurityEnabled == input.PortSecurityEnabled ||
                    (this.PortSecurityEnabled != null &&
                    this.PortSecurityEnabled.Equals(input.PortSecurityEnabled))
                ) && 
                (
                    this.BindingvnicType == input.BindingvnicType ||
                    (this.BindingvnicType != null &&
                    this.BindingvnicType.Equals(input.BindingvnicType))
                ) && 
                (
                    this.Bindingprofile == input.Bindingprofile ||
                    this.Bindingprofile != null &&
                    input.Bindingprofile != null &&
                    this.Bindingprofile.SequenceEqual(input.Bindingprofile)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SecurityGroups != null)
                    hashCode = hashCode * 59 + this.SecurityGroups.GetHashCode();
                if (this.AllowedAddressPairs != null)
                    hashCode = hashCode * 59 + this.AllowedAddressPairs.GetHashCode();
                if (this.ExtraDhcpOpts != null)
                    hashCode = hashCode * 59 + this.ExtraDhcpOpts.GetHashCode();
                if (this.PortSecurityEnabled != null)
                    hashCode = hashCode * 59 + this.PortSecurityEnabled.GetHashCode();
                if (this.BindingvnicType != null)
                    hashCode = hashCode * 59 + this.BindingvnicType.GetHashCode();
                if (this.Bindingprofile != null)
                    hashCode = hashCode * 59 + this.Bindingprofile.GetHashCode();
                return hashCode;
            }
        }
    }
}
