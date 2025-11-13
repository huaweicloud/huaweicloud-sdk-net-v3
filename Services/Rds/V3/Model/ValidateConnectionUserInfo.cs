using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 连接测试用户登录信息。
    /// </summary>
    public class ValidateConnectionUserInfo 
    {

        /// <summary>
        /// 服务器ip。
        /// </summary>
        [JsonProperty("server_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerIp { get; set; }

        /// <summary>
        /// 端口号。
        /// </summary>
        [JsonProperty("server_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? ServerPort { get; set; }

        /// <summary>
        /// 登录名。
        /// </summary>
        [JsonProperty("login_user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LoginUserName { get; set; }

        /// <summary>
        /// 登录密码。要求密码长度在5~64位之间。
        /// </summary>
        [JsonProperty("login_user_password", NullValueHandling = NullValueHandling.Ignore)]
        public string LoginUserPassword { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidateConnectionUserInfo {\n");
            sb.Append("  serverIp: ").Append(ServerIp).Append("\n");
            sb.Append("  serverPort: ").Append(ServerPort).Append("\n");
            sb.Append("  loginUserName: ").Append(LoginUserName).Append("\n");
            sb.Append("  loginUserPassword: ").Append(LoginUserPassword).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ValidateConnectionUserInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ValidateConnectionUserInfo input)
        {
            if (input == null) return false;
            if (this.ServerIp != input.ServerIp || (this.ServerIp != null && !this.ServerIp.Equals(input.ServerIp))) return false;
            if (this.ServerPort != input.ServerPort || (this.ServerPort != null && !this.ServerPort.Equals(input.ServerPort))) return false;
            if (this.LoginUserName != input.LoginUserName || (this.LoginUserName != null && !this.LoginUserName.Equals(input.LoginUserName))) return false;
            if (this.LoginUserPassword != input.LoginUserPassword || (this.LoginUserPassword != null && !this.LoginUserPassword.Equals(input.LoginUserPassword))) return false;

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
                if (this.ServerPort != null) hashCode = hashCode * 59 + this.ServerPort.GetHashCode();
                if (this.LoginUserName != null) hashCode = hashCode * 59 + this.LoginUserName.GetHashCode();
                if (this.LoginUserPassword != null) hashCode = hashCode * 59 + this.LoginUserPassword.GetHashCode();
                return hashCode;
            }
        }
    }
}
