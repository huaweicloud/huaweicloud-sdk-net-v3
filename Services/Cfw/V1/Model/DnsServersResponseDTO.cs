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
    public class DnsServersResponseDTO 
    {

        /// <summary>
        /// 域名服务器id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 域名服务器是否应用，0否 1是
        /// </summary>
        [JsonProperty("is_applied", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsApplied { get; set; }

        /// <summary>
        /// 域名服务器是否是用户自定义的dns服务器，0否 1是
        /// </summary>
        [JsonProperty("is_customized", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsCustomized { get; set; }

        /// <summary>
        /// DNS服务器IP
        /// </summary>
        [JsonProperty("server_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerIp { get; set; }

        /// <summary>
        /// 健康检查域名
        /// </summary>
        [JsonProperty("health_check_domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string HealthCheckDomainName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DnsServersResponseDTO {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  isApplied: ").Append(IsApplied).Append("\n");
            sb.Append("  isCustomized: ").Append(IsCustomized).Append("\n");
            sb.Append("  serverIp: ").Append(ServerIp).Append("\n");
            sb.Append("  healthCheckDomainName: ").Append(HealthCheckDomainName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DnsServersResponseDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DnsServersResponseDTO input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.IsApplied != input.IsApplied || (this.IsApplied != null && !this.IsApplied.Equals(input.IsApplied))) return false;
            if (this.IsCustomized != input.IsCustomized || (this.IsCustomized != null && !this.IsCustomized.Equals(input.IsCustomized))) return false;
            if (this.ServerIp != input.ServerIp || (this.ServerIp != null && !this.ServerIp.Equals(input.ServerIp))) return false;
            if (this.HealthCheckDomainName != input.HealthCheckDomainName || (this.HealthCheckDomainName != null && !this.HealthCheckDomainName.Equals(input.HealthCheckDomainName))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IsApplied != null) hashCode = hashCode * 59 + this.IsApplied.GetHashCode();
                if (this.IsCustomized != null) hashCode = hashCode * 59 + this.IsCustomized.GetHashCode();
                if (this.ServerIp != null) hashCode = hashCode * 59 + this.ServerIp.GetHashCode();
                if (this.HealthCheckDomainName != null) hashCode = hashCode * 59 + this.HealthCheckDomainName.GetHashCode();
                return hashCode;
            }
        }
    }
}
