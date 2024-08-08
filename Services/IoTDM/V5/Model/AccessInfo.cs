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
    /// 设备接入实例的接入信息。用户可以使用该结构体中的信息将应用服务器和设备接入到物联网平台。 
    /// </summary>
    public class AccessInfo 
    {

        /// <summary>
        /// **参数说明**：接入地址的类型，如应用接入的HTTPS协议的取值为：APP_HTTPS，设备接入的MQTT协议的取值为：DEVICE_MQTT **取值范围**： - APP_HTTPS：应用接入HTTPS协议 - APP_AMQP：应用接入AMQP协议 - APP_MQTT：应用接入MQTT协议 - DEVICE_COAP：设备接入COAP协议 - DEVICE_MQTT：设备接入MQTT协议 - DEVICE_HTTPS：设备接入HTTPS协议 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数说明**：实例的应用/设备的安全接入端口 
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public int? Port { get; set; }

        /// <summary>
        /// **参数说明**：实例的应用/设备的非安全接入端口。返回null时表示该类型的接入地址不支持非安全端口接入。 
        /// </summary>
        [JsonProperty("non_tls_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? NonTlsPort { get; set; }

        /// <summary>
        /// **参数说明**：基于WebSocket的MQTT接入端口。返回null时表示该类型的接入地址不支持WebSocket端口接入。 
        /// </summary>
        [JsonProperty("websocket_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? WebsocketPort { get; set; }

        /// <summary>
        /// **参数说明**：实例的接入域名 
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// **参数说明**：实例的私网接入地址列表 
        /// </summary>
        [JsonProperty("private_addresses", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PrivateAddresses { get; set; }

        /// <summary>
        /// **参数说明**：实例的公网接入地址 
        /// </summary>
        [JsonProperty("public_address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PublicAddress { get; set; }

        /// <summary>
        /// **参数说明**：实例的ipv6接入地址列表 
        /// </summary>
        [JsonProperty("ipv6_address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Ipv6Address { get; set; }

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
            sb.Append("class AccessInfo {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  nonTlsPort: ").Append(NonTlsPort).Append("\n");
            sb.Append("  websocketPort: ").Append(WebsocketPort).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  privateAddresses: ").Append(PrivateAddresses).Append("\n");
            sb.Append("  publicAddress: ").Append(PublicAddress).Append("\n");
            sb.Append("  ipv6Address: ").Append(Ipv6Address).Append("\n");
            sb.Append("  ipWhitelist: ").Append(IpWhitelist).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccessInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AccessInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.NonTlsPort == input.NonTlsPort ||
                    (this.NonTlsPort != null &&
                    this.NonTlsPort.Equals(input.NonTlsPort))
                ) && 
                (
                    this.WebsocketPort == input.WebsocketPort ||
                    (this.WebsocketPort != null &&
                    this.WebsocketPort.Equals(input.WebsocketPort))
                ) && 
                (
                    this.DomainName == input.DomainName ||
                    (this.DomainName != null &&
                    this.DomainName.Equals(input.DomainName))
                ) && 
                (
                    this.PrivateAddresses == input.PrivateAddresses ||
                    this.PrivateAddresses != null &&
                    input.PrivateAddresses != null &&
                    this.PrivateAddresses.SequenceEqual(input.PrivateAddresses)
                ) && 
                (
                    this.PublicAddress == input.PublicAddress ||
                    this.PublicAddress != null &&
                    input.PublicAddress != null &&
                    this.PublicAddress.SequenceEqual(input.PublicAddress)
                ) && 
                (
                    this.Ipv6Address == input.Ipv6Address ||
                    this.Ipv6Address != null &&
                    input.Ipv6Address != null &&
                    this.Ipv6Address.SequenceEqual(input.Ipv6Address)
                ) && 
                (
                    this.IpWhitelist == input.IpWhitelist ||
                    (this.IpWhitelist != null &&
                    this.IpWhitelist.Equals(input.IpWhitelist))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.NonTlsPort != null)
                    hashCode = hashCode * 59 + this.NonTlsPort.GetHashCode();
                if (this.WebsocketPort != null)
                    hashCode = hashCode * 59 + this.WebsocketPort.GetHashCode();
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.PrivateAddresses != null)
                    hashCode = hashCode * 59 + this.PrivateAddresses.GetHashCode();
                if (this.PublicAddress != null)
                    hashCode = hashCode * 59 + this.PublicAddress.GetHashCode();
                if (this.Ipv6Address != null)
                    hashCode = hashCode * 59 + this.Ipv6Address.GetHashCode();
                if (this.IpWhitelist != null)
                    hashCode = hashCode * 59 + this.IpWhitelist.GetHashCode();
                return hashCode;
            }
        }
    }
}
