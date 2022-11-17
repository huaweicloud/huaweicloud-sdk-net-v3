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
        /// id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 是否应用，0否 1是
        /// </summary>
        [JsonProperty("is_applied", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsApplied { get; set; }

        /// <summary>
        /// 是否是用户自定义的dns服务器，0否 1是
        /// </summary>
        [JsonProperty("is_customized", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsCustomized { get; set; }

        /// <summary>
        /// DNS服务器IP
        /// </summary>
        [JsonProperty("server_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerIp { get; set; }


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
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsApplied == input.IsApplied ||
                    (this.IsApplied != null &&
                    this.IsApplied.Equals(input.IsApplied))
                ) && 
                (
                    this.IsCustomized == input.IsCustomized ||
                    (this.IsCustomized != null &&
                    this.IsCustomized.Equals(input.IsCustomized))
                ) && 
                (
                    this.ServerIp == input.ServerIp ||
                    (this.ServerIp != null &&
                    this.ServerIp.Equals(input.ServerIp))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IsApplied != null)
                    hashCode = hashCode * 59 + this.IsApplied.GetHashCode();
                if (this.IsCustomized != null)
                    hashCode = hashCode * 59 + this.IsCustomized.GetHashCode();
                if (this.ServerIp != null)
                    hashCode = hashCode * 59 + this.ServerIp.GetHashCode();
                return hashCode;
            }
        }
    }
}
