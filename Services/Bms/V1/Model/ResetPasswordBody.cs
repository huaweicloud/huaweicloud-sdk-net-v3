using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// 一键重置裸金属服务器密码接口请求结构体
    /// </summary>
    public class ResetPasswordBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("reset-password", NullValueHandling = NullValueHandling.Ignore)]
        public ResetPassword ResetPassword { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResetPasswordBody {\n");
            sb.Append("  resetPassword: ").Append(ResetPassword).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResetPasswordBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResetPasswordBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResetPassword == input.ResetPassword ||
                    (this.ResetPassword != null &&
                    this.ResetPassword.Equals(input.ResetPassword))
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
                if (this.ResetPassword != null)
                    hashCode = hashCode * 59 + this.ResetPassword.GetHashCode();
                return hashCode;
            }
        }
    }
}
