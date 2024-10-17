using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// 用户可以自主修改的属性。
    /// </summary>
    public class AllowUserBody 
    {

        /// <summary>
        /// 是否允许子用户自行管理AK，取值范围true或false。
        /// </summary>
        [JsonProperty("manage_accesskey", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ManageAccesskey { get; set; }

        /// <summary>
        /// 是否允许子用户自己修改邮箱，取值范围true或false。
        /// </summary>
        [JsonProperty("manage_email", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ManageEmail { get; set; }

        /// <summary>
        /// 是否允许子用户自己修改电话，取值范围true或false。
        /// </summary>
        [JsonProperty("manage_mobile", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ManageMobile { get; set; }

        /// <summary>
        /// 是否允许子用户自己修改密码，取值范围true或false。
        /// </summary>
        [JsonProperty("manage_password", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ManagePassword { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AllowUserBody {\n");
            sb.Append("  manageAccesskey: ").Append(ManageAccesskey).Append("\n");
            sb.Append("  manageEmail: ").Append(ManageEmail).Append("\n");
            sb.Append("  manageMobile: ").Append(ManageMobile).Append("\n");
            sb.Append("  managePassword: ").Append(ManagePassword).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AllowUserBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AllowUserBody input)
        {
            if (input == null) return false;
            if (this.ManageAccesskey != input.ManageAccesskey || (this.ManageAccesskey != null && !this.ManageAccesskey.Equals(input.ManageAccesskey))) return false;
            if (this.ManageEmail != input.ManageEmail || (this.ManageEmail != null && !this.ManageEmail.Equals(input.ManageEmail))) return false;
            if (this.ManageMobile != input.ManageMobile || (this.ManageMobile != null && !this.ManageMobile.Equals(input.ManageMobile))) return false;
            if (this.ManagePassword != input.ManagePassword || (this.ManagePassword != null && !this.ManagePassword.Equals(input.ManagePassword))) return false;

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
                if (this.ManageAccesskey != null) hashCode = hashCode * 59 + this.ManageAccesskey.GetHashCode();
                if (this.ManageEmail != null) hashCode = hashCode * 59 + this.ManageEmail.GetHashCode();
                if (this.ManageMobile != null) hashCode = hashCode * 59 + this.ManageMobile.GetHashCode();
                if (this.ManagePassword != null) hashCode = hashCode * 59 + this.ManagePassword.GetHashCode();
                return hashCode;
            }
        }
    }
}
