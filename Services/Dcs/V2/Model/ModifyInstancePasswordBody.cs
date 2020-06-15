using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ModifyInstancePasswordBody 
    {

        /// <summary>
        /// 旧密码
        /// </summary>
        [JsonProperty("old_password", NullValueHandling = NullValueHandling.Ignore)]
        public string OldPassword { get; set; }

        /// <summary>
        /// 新密码
        /// </summary>
        [JsonProperty("new_password", NullValueHandling = NullValueHandling.Ignore)]
        public string NewPassword { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyInstancePasswordBody {\n");
            sb.Append("  oldPassword: ").Append(OldPassword).Append("\n");
            sb.Append("  newPassword: ").Append(NewPassword).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyInstancePasswordBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyInstancePasswordBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OldPassword == input.OldPassword ||
                    (this.OldPassword != null &&
                    this.OldPassword.Equals(input.OldPassword))
                ) && 
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
                if (this.OldPassword != null)
                    hashCode = hashCode * 59 + this.OldPassword.GetHashCode();
                if (this.NewPassword != null)
                    hashCode = hashCode * 59 + this.NewPassword.GetHashCode();
                return hashCode;
            }
        }
    }
}
