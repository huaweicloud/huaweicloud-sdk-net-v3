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
    /// 查询远程SQL Server数据库请求参数。
    /// </summary>
    public class ListRemoteDbRequestBody 
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
        public string ServerPort { get; set; }

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
        /// 索引位置，偏移量。从第一条数据偏移offset条数据后开始查询，默认为0（偏移0条数据，表示从第一条数据开始查询），必须为数字，不能为负数。
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询记录数。默认为10，不能为负数，最小值为1，最大值为100。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRemoteDbRequestBody {\n");
            sb.Append("  serverIp: ").Append(ServerIp).Append("\n");
            sb.Append("  serverPort: ").Append(ServerPort).Append("\n");
            sb.Append("  loginUserName: ").Append(LoginUserName).Append("\n");
            sb.Append("  loginUserPassword: ").Append(LoginUserPassword).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRemoteDbRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRemoteDbRequestBody input)
        {
            if (input == null) return false;
            if (this.ServerIp != input.ServerIp || (this.ServerIp != null && !this.ServerIp.Equals(input.ServerIp))) return false;
            if (this.ServerPort != input.ServerPort || (this.ServerPort != null && !this.ServerPort.Equals(input.ServerPort))) return false;
            if (this.LoginUserName != input.LoginUserName || (this.LoginUserName != null && !this.LoginUserName.Equals(input.LoginUserName))) return false;
            if (this.LoginUserPassword != input.LoginUserPassword || (this.LoginUserPassword != null && !this.LoginUserPassword.Equals(input.LoginUserPassword))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
