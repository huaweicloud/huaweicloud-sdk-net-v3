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
        /// **参数解释**： 域名服务器id **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释**： 域名服务器是否应用 **取值范围**： - 0：否 - 1：是
        /// </summary>
        [JsonProperty("is_applied", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsApplied { get; set; }

        /// <summary>
        /// **参数解释**： 域名服务器是否是用户自定义的dns服务器 **取值范围**： - 0：否 - 1：是
        /// </summary>
        [JsonProperty("is_customized", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsCustomized { get; set; }

        /// <summary>
        /// **参数解释**： DNS服务器IP **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("server_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerIp { get; set; }

        /// <summary>
        /// **参数解释**： dns服务器解析状态 **取值范围**： 0：解析域名的频率正常 1：解析域名的频率缓慢 2：解析域名异常 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// **参数解释**： 健康检查域名 **取值范围**： 不涉及
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
            sb.Append("  status: ").Append(Status).Append("\n");
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
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.HealthCheckDomainName != null) hashCode = hashCode * 59 + this.HealthCheckDomainName.GetHashCode();
                return hashCode;
            }
        }
    }
}
