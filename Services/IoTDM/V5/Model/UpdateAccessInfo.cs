using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDM.V5.Model
{
    /// <summary>
    /// 设备接入实例的接入信息。用户可以使用该结构体中的信息将应用服务器和设备接入到物联网平台。 约束：只有企业版实例支持自定义接入信息。 
    /// </summary>
    public class UpdateAccessInfo 
    {

        /// <summary>
        /// **参数说明**：接入地址的类型，如应用接入的HTTPS协议的取值为：APP_HTTPS，设备接入的MQTT协议的取值为：DEVICE_MQTT。 **取值范围**： - APP_HTTPS：应用接入HTTPS协议 - APP_AMQP：应用接入AMQP协议 - APP_MQTT：应用接入MQTT协议 - DEVICE_COAP：设备接入COAP协议 - DEVICE_MQTT：设备接入MQTT协议 - DEVICE_HTTPS：设备接入HTTPS协议 
        /// </summary>
        [JsonProperty("access_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessType { get; set; }

        /// <summary>
        /// **参数说明**：接入域名，如果需要更新域名，则携带该字段。 
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// **参数说明**：是否配置公网接入地址。约束：access_type为APP_HTTPS/APP_AMQP/APP_MQTT的公网地址会同时被解绑或绑定。access_type为DEVICE_MQTT/DEVICE_HTTPS的公网地址会同时被解绑或绑定。 **取值范围**： - true：配置公网接入地址，平台将自动分配公网接入地址。 - false: 解绑公网接入地址，解绑公网地址不会被删除，再次配置公网地址将绑定原来的公网地址。 
        /// </summary>
        [JsonProperty("public_addresses_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PublicAddressesEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ip_whitelist", NullValueHandling = NullValueHandling.Ignore)]
        public IPWhiteList IpWhitelist { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAccessInfo {\n");
            sb.Append("  accessType: ").Append(AccessType).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  publicAddressesEnable: ").Append(PublicAddressesEnable).Append("\n");
            sb.Append("  ipWhitelist: ").Append(IpWhitelist).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateAccessInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateAccessInfo input)
        {
            if (input == null) return false;
            if (this.AccessType != input.AccessType || (this.AccessType != null && !this.AccessType.Equals(input.AccessType))) return false;
            if (this.DomainName != input.DomainName || (this.DomainName != null && !this.DomainName.Equals(input.DomainName))) return false;
            if (this.PublicAddressesEnable != input.PublicAddressesEnable || (this.PublicAddressesEnable != null && !this.PublicAddressesEnable.Equals(input.PublicAddressesEnable))) return false;
            if (this.IpWhitelist != input.IpWhitelist || (this.IpWhitelist != null && !this.IpWhitelist.Equals(input.IpWhitelist))) return false;

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
                if (this.AccessType != null) hashCode = hashCode * 59 + this.AccessType.GetHashCode();
                if (this.DomainName != null) hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.PublicAddressesEnable != null) hashCode = hashCode * 59 + this.PublicAddressesEnable.GetHashCode();
                if (this.IpWhitelist != null) hashCode = hashCode * 59 + this.IpWhitelist.GetHashCode();
                return hashCode;
            }
        }
    }
}
