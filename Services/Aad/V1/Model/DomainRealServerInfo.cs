using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V1.Model
{
    /// <summary>
    /// 域名源站信息
    /// </summary>
    public class DomainRealServerInfo 
    {

        /// <summary>
        /// 源站类型
        /// </summary>
        [JsonProperty("real_server_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? RealServerType { get; set; }

        /// <summary>
        /// 源站
        /// </summary>
        [JsonProperty("real_servers", NullValueHandling = NullValueHandling.Ignore)]
        public string RealServers { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainRealServerInfo {\n");
            sb.Append("  realServerType: ").Append(RealServerType).Append("\n");
            sb.Append("  realServers: ").Append(RealServers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DomainRealServerInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DomainRealServerInfo input)
        {
            if (input == null) return false;
            if (this.RealServerType != input.RealServerType || (this.RealServerType != null && !this.RealServerType.Equals(input.RealServerType))) return false;
            if (this.RealServers != input.RealServers || (this.RealServers != null && !this.RealServers.Equals(input.RealServers))) return false;

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
                if (this.RealServerType != null) hashCode = hashCode * 59 + this.RealServerType.GetHashCode();
                if (this.RealServers != null) hashCode = hashCode * 59 + this.RealServers.GetHashCode();
                return hashCode;
            }
        }
    }
}
