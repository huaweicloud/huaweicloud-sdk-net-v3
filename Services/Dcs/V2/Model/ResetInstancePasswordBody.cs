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
    public class ResetInstancePasswordBody 
    {

        /// <summary>
        /// 重置的新密码
        /// </summary>
        [JsonProperty("new_password", NullValueHandling = NullValueHandling.Ignore)]
        public string NewPassword { get; set; }

        /// <summary>
        /// 是否重置为免密码访问缓存实例
        /// </summary>
        [JsonProperty("no_password_access", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NoPasswordAccess { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResetInstancePasswordBody {\n");
            sb.Append("  newPassword: ").Append(NewPassword).Append("\n");
            sb.Append("  noPasswordAccess: ").Append(NoPasswordAccess).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResetInstancePasswordBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResetInstancePasswordBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NewPassword == input.NewPassword ||
                    (this.NewPassword != null &&
                    this.NewPassword.Equals(input.NewPassword))
                ) && 
                (
                    this.NoPasswordAccess == input.NoPasswordAccess ||
                    (this.NoPasswordAccess != null &&
                    this.NoPasswordAccess.Equals(input.NoPasswordAccess))
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
                if (this.NoPasswordAccess != null)
                    hashCode = hashCode * 59 + this.NoPasswordAccess.GetHashCode();
                return hashCode;
            }
        }
    }
}
