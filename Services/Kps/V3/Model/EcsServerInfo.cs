using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kps.V3.Model
{
    /// <summary>
    /// 需要绑定密钥对的虚拟机信息。
    /// </summary>
    public class EcsServerInfo 
    {

        /// <summary>
        /// 需要绑定(替换或重置)SSH密钥对的虚拟机id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("auth", NullValueHandling = NullValueHandling.Ignore)]
        public Auth Auth { get; set; }

        /// <summary>
        /// - true：禁用虚拟机的ssh登录。 - false：不禁用虚拟机的ssh登录。
        /// </summary>
        [JsonProperty("disable_password", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisablePassword { get; set; }

        /// <summary>
        /// SSH监听端口。
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public long? Port { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EcsServerInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  auth: ").Append(Auth).Append("\n");
            sb.Append("  disablePassword: ").Append(DisablePassword).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EcsServerInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EcsServerInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Auth != input.Auth || (this.Auth != null && !this.Auth.Equals(input.Auth))) return false;
            if (this.DisablePassword != input.DisablePassword || (this.DisablePassword != null && !this.DisablePassword.Equals(input.DisablePassword))) return false;
            if (this.Port != input.Port || (this.Port != null && !this.Port.Equals(input.Port))) return false;

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
                if (this.Auth != null) hashCode = hashCode * 59 + this.Auth.GetHashCode();
                if (this.DisablePassword != null) hashCode = hashCode * 59 + this.DisablePassword.GetHashCode();
                if (this.Port != null) hashCode = hashCode * 59 + this.Port.GetHashCode();
                return hashCode;
            }
        }
    }
}
