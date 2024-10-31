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
    public class UpdateDnsServersRequestBodyDnsServer 
    {

        /// <summary>
        /// DNS服务器IP，可通过[查询dns服务器列表接口](ListDnsServers.xml)查询获得，通过返回值中的data.server_ip（.表示各对象之间层级的区分）获得。
        /// </summary>
        [JsonProperty("server_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerIp { get; set; }

        /// <summary>
        /// 是否是用户自定义的dns服务器，0否 1是
        /// </summary>
        [JsonProperty("is_customized", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsCustomized { get; set; }

        /// <summary>
        /// 是否应用，0否 1是
        /// </summary>
        [JsonProperty("is_applied", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsApplied { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDnsServersRequestBodyDnsServer {\n");
            sb.Append("  serverIp: ").Append(ServerIp).Append("\n");
            sb.Append("  isCustomized: ").Append(IsCustomized).Append("\n");
            sb.Append("  isApplied: ").Append(IsApplied).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateDnsServersRequestBodyDnsServer);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateDnsServersRequestBodyDnsServer input)
        {
            if (input == null) return false;
            if (this.ServerIp != input.ServerIp || (this.ServerIp != null && !this.ServerIp.Equals(input.ServerIp))) return false;
            if (this.IsCustomized != input.IsCustomized || (this.IsCustomized != null && !this.IsCustomized.Equals(input.IsCustomized))) return false;
            if (this.IsApplied != input.IsApplied || (this.IsApplied != null && !this.IsApplied.Equals(input.IsApplied))) return false;

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
                if (this.ServerIp != null) hashCode = hashCode * 59 + this.ServerIp.GetHashCode();
                if (this.IsCustomized != null) hashCode = hashCode * 59 + this.IsCustomized.GetHashCode();
                if (this.IsApplied != null) hashCode = hashCode * 59 + this.IsApplied.GetHashCode();
                return hashCode;
            }
        }
    }
}
