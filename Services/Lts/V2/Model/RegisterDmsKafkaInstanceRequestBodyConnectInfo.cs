using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// kafka连接信息。购买kafka时，SASL_SSL是否配置，如果有，则需要填写账号密码
    /// </summary>
    public class RegisterDmsKafkaInstanceRequestBodyConnectInfo 
    {

        /// <summary>
        /// 账号
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [JsonProperty("pwd", NullValueHandling = NullValueHandling.Ignore)]
        public string Pwd { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegisterDmsKafkaInstanceRequestBodyConnectInfo {\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  pwd: ").Append(Pwd).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RegisterDmsKafkaInstanceRequestBodyConnectInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RegisterDmsKafkaInstanceRequestBodyConnectInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.Pwd == input.Pwd ||
                    (this.Pwd != null &&
                    this.Pwd.Equals(input.Pwd))
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
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.Pwd != null)
                    hashCode = hashCode * 59 + this.Pwd.GetHashCode();
                return hashCode;
            }
        }
    }
}
