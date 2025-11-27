using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RequiredInput 
    {

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("USERNAME", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        /// <summary>
        /// 控制节点1IP地址
        /// </summary>
        [JsonProperty("MASTER-1", NullValueHandling = NullValueHandling.Ignore)]
        public string Master1 { get; set; }

        /// <summary>
        /// 控制节点2IP地址
        /// </summary>
        [JsonProperty("MASTER-2", NullValueHandling = NullValueHandling.Ignore)]
        public string Master2 { get; set; }

        /// <summary>
        /// 控制节点3IP地址
        /// </summary>
        [JsonProperty("MASTER-3", NullValueHandling = NullValueHandling.Ignore)]
        public string Master3 { get; set; }

        /// <summary>
        /// 是否启用外部负载均衡器
        /// </summary>
        [JsonProperty("ACCESS_EXTERNAL_LOAD_BALANCE", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AccessExternalLoadBalance { get; set; }

        /// <summary>
        /// Cilium网络组件的IPv4地址池CIDR
        /// </summary>
        [JsonProperty("CILIUM_IPV4POOL_CIDR", NullValueHandling = NullValueHandling.Ignore)]
        public string CiliumIpv4poolCidr { get; set; }

        /// <summary>
        /// 容器网络的CIDR范围
        /// </summary>
        [JsonProperty("NETWORK_CIDR", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkCidr { get; set; }

        /// <summary>
        /// DNS服务器IP地址
        /// </summary>
        [JsonProperty("DNS_SERVER_IP", NullValueHandling = NullValueHandling.Ignore)]
        public string DnsServerIp { get; set; }

        /// <summary>
        /// NTP服务器IP地址
        /// </summary>
        [JsonProperty("NTP_SERVER_IP", NullValueHandling = NullValueHandling.Ignore)]
        public string NtpServerIp { get; set; }

        /// <summary>
        /// IAM域ID
        /// </summary>
        [JsonProperty("IAM_DOMAIN_ID", NullValueHandling = NullValueHandling.Ignore)]
        public string IamDomainId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequiredInput {\n");
            sb.Append("  username: ").Append(Username).Append("\n");
            sb.Append("  master1: ").Append(Master1).Append("\n");
            sb.Append("  master2: ").Append(Master2).Append("\n");
            sb.Append("  master3: ").Append(Master3).Append("\n");
            sb.Append("  accessExternalLoadBalance: ").Append(AccessExternalLoadBalance).Append("\n");
            sb.Append("  ciliumIpv4poolCidr: ").Append(CiliumIpv4poolCidr).Append("\n");
            sb.Append("  networkCidr: ").Append(NetworkCidr).Append("\n");
            sb.Append("  dnsServerIp: ").Append(DnsServerIp).Append("\n");
            sb.Append("  ntpServerIp: ").Append(NtpServerIp).Append("\n");
            sb.Append("  iamDomainId: ").Append(IamDomainId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RequiredInput);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RequiredInput input)
        {
            if (input == null) return false;
            if (this.Username != input.Username || (this.Username != null && !this.Username.Equals(input.Username))) return false;
            if (this.Master1 != input.Master1 || (this.Master1 != null && !this.Master1.Equals(input.Master1))) return false;
            if (this.Master2 != input.Master2 || (this.Master2 != null && !this.Master2.Equals(input.Master2))) return false;
            if (this.Master3 != input.Master3 || (this.Master3 != null && !this.Master3.Equals(input.Master3))) return false;
            if (this.AccessExternalLoadBalance != input.AccessExternalLoadBalance || (this.AccessExternalLoadBalance != null && !this.AccessExternalLoadBalance.Equals(input.AccessExternalLoadBalance))) return false;
            if (this.CiliumIpv4poolCidr != input.CiliumIpv4poolCidr || (this.CiliumIpv4poolCidr != null && !this.CiliumIpv4poolCidr.Equals(input.CiliumIpv4poolCidr))) return false;
            if (this.NetworkCidr != input.NetworkCidr || (this.NetworkCidr != null && !this.NetworkCidr.Equals(input.NetworkCidr))) return false;
            if (this.DnsServerIp != input.DnsServerIp || (this.DnsServerIp != null && !this.DnsServerIp.Equals(input.DnsServerIp))) return false;
            if (this.NtpServerIp != input.NtpServerIp || (this.NtpServerIp != null && !this.NtpServerIp.Equals(input.NtpServerIp))) return false;
            if (this.IamDomainId != input.IamDomainId || (this.IamDomainId != null && !this.IamDomainId.Equals(input.IamDomainId))) return false;

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
                if (this.Username != null) hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Master1 != null) hashCode = hashCode * 59 + this.Master1.GetHashCode();
                if (this.Master2 != null) hashCode = hashCode * 59 + this.Master2.GetHashCode();
                if (this.Master3 != null) hashCode = hashCode * 59 + this.Master3.GetHashCode();
                if (this.AccessExternalLoadBalance != null) hashCode = hashCode * 59 + this.AccessExternalLoadBalance.GetHashCode();
                if (this.CiliumIpv4poolCidr != null) hashCode = hashCode * 59 + this.CiliumIpv4poolCidr.GetHashCode();
                if (this.NetworkCidr != null) hashCode = hashCode * 59 + this.NetworkCidr.GetHashCode();
                if (this.DnsServerIp != null) hashCode = hashCode * 59 + this.DnsServerIp.GetHashCode();
                if (this.NtpServerIp != null) hashCode = hashCode * 59 + this.NtpServerIp.GetHashCode();
                if (this.IamDomainId != null) hashCode = hashCode * 59 + this.IamDomainId.GetHashCode();
                return hashCode;
            }
        }
    }
}
