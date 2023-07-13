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
    /// 创建network对象
    /// </summary>
    public class NeutronCreateNetworkOption 
    {

        /// <summary>
        /// 功能说明：网络名称 取值范围：0-255个字符 约束：不能为admin_external_net
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 功能说明：资源的管理状态 取值范围：true、false 约束：只支持true
        /// </summary>
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 功能说明：是否支持跨租户共享 取值范围：true、false
        /// </summary>
        [JsonProperty("shared", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Shared { get; set; }

        /// <summary>
        /// 功能说明：扩展属性：网络类型。管理员属性，普通租户不可见，允许 geneve类型租户执行操作。 取值范围：vxlan, geneve
        /// </summary>
        [JsonProperty("provider:network_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ProvidernetworkType { get; set; }

        /// <summary>
        /// 功能说明：端口安全使能标记 取值范围：true(启用)、false(禁用) 约束：如果不使能，则network下所有虚机的安全组和dhcp防欺骗不生效
        /// </summary>
        [JsonProperty("port_security_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PortSecurityEnabled { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronCreateNetworkOption {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  shared: ").Append(Shared).Append("\n");
            sb.Append("  providernetworkType: ").Append(ProvidernetworkType).Append("\n");
            sb.Append("  portSecurityEnabled: ").Append(PortSecurityEnabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronCreateNetworkOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronCreateNetworkOption input)
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
                    this.AdminStateUp == input.AdminStateUp ||
                    (this.AdminStateUp != null &&
                    this.AdminStateUp.Equals(input.AdminStateUp))
                ) && 
                (
                    this.Shared == input.Shared ||
                    (this.Shared != null &&
                    this.Shared.Equals(input.Shared))
                ) && 
                (
                    this.ProvidernetworkType == input.ProvidernetworkType ||
                    (this.ProvidernetworkType != null &&
                    this.ProvidernetworkType.Equals(input.ProvidernetworkType))
                ) && 
                (
                    this.PortSecurityEnabled == input.PortSecurityEnabled ||
                    (this.PortSecurityEnabled != null &&
                    this.PortSecurityEnabled.Equals(input.PortSecurityEnabled))
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
                if (this.AdminStateUp != null)
                    hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.Shared != null)
                    hashCode = hashCode * 59 + this.Shared.GetHashCode();
                if (this.ProvidernetworkType != null)
                    hashCode = hashCode * 59 + this.ProvidernetworkType.GetHashCode();
                if (this.PortSecurityEnabled != null)
                    hashCode = hashCode * 59 + this.PortSecurityEnabled.GetHashCode();
                return hashCode;
            }
        }
    }
}
