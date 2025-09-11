using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RemoteInstallHostInfo 
    {

        /// <summary>
        /// **参数解释**: 被远程安装的主机名称 **取值范围**: 数组长度范围为[1,128] 
        /// </summary>
        [JsonProperty("instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }

        /// <summary>
        /// **参数解释**: 被远程安装的主机IP **取值范围**: 仅由数字(0-9)和小数点(.)组成的字符串，字符串长度为[1,15] 
        /// </summary>
        [JsonProperty("remote_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string RemoteIp { get; set; }

        /// <summary>
        /// **参数解释**: 被远程安装的主机的登录用户名 **取值范围**: 数组长度范围为[1,16] 
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// **参数解释**: 被远程安装的主机的登录端口 **取值范围**: 数组长度范围为[1,5] 
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public string Port { get; set; }

        /// <summary>
        /// **参数解释**: 被远程安装的主机的登录密码 **取值范围**: 数组长度范围为[1,3000] 
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// **参数解释**: 被远程安装的主机远程连接是否采用密钥方式（false时为密码方式） **取值范围**: - false: 密码方式 - true: 密钥方式 
        /// </summary>
        [JsonProperty("remote_use_pem", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RemoteUsePem { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemoteInstallHostInfo {\n");
            sb.Append("  instanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  remoteIp: ").Append(RemoteIp).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("  remoteUsePem: ").Append(RemoteUsePem).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RemoteInstallHostInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RemoteInstallHostInfo input)
        {
            if (input == null) return false;
            if (this.InstanceName != input.InstanceName || (this.InstanceName != null && !this.InstanceName.Equals(input.InstanceName))) return false;
            if (this.RemoteIp != input.RemoteIp || (this.RemoteIp != null && !this.RemoteIp.Equals(input.RemoteIp))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.Port != input.Port || (this.Port != null && !this.Port.Equals(input.Port))) return false;
            if (this.Password != input.Password || (this.Password != null && !this.Password.Equals(input.Password))) return false;
            if (this.RemoteUsePem != input.RemoteUsePem || (this.RemoteUsePem != null && !this.RemoteUsePem.Equals(input.RemoteUsePem))) return false;

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
                if (this.InstanceName != null) hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                if (this.RemoteIp != null) hashCode = hashCode * 59 + this.RemoteIp.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.Port != null) hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Password != null) hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.RemoteUsePem != null) hashCode = hashCode * 59 + this.RemoteUsePem.GetHashCode();
                return hashCode;
            }
        }
    }
}
