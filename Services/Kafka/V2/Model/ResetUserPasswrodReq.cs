using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ResetUserPasswrodReq 
    {

        /// <summary>
        /// 用户新密码。
        /// </summary>
        [JsonProperty("new_password", NullValueHandling = NullValueHandling.Ignore)]
        public string NewPassword { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResetUserPasswrodReq {\n");
            sb.Append("  newPassword: ").Append(NewPassword).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResetUserPasswrodReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResetUserPasswrodReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NewPassword == input.NewPassword ||
                    (this.NewPassword != null &&
                    this.NewPassword.Equals(input.NewPassword))
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
                if (this.NewPassword != null)
                    hashCode = hashCode * 59 + this.NewPassword.GetHashCode();
                return hashCode;
            }
        }
    }
}
