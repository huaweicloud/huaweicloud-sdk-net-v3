using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DNInstance 
    {

        /// <summary>
        /// 实例id。
        /// </summary>
        [JsonProperty("dn_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DnInstanceId { get; set; }

        /// <summary>
        /// 实例账号。
        /// </summary>
        [JsonProperty("admin_user", NullValueHandling = NullValueHandling.Ignore)]
        public string AdminUser { get; set; }

        /// <summary>
        /// 实例密码。
        /// </summary>
        [JsonProperty("admin_password", NullValueHandling = NullValueHandling.Ignore)]
        public string AdminPassword { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DNInstance {\n");
            sb.Append("  dnInstanceId: ").Append(DnInstanceId).Append("\n");
            sb.Append("  adminUser: ").Append(AdminUser).Append("\n");
            sb.Append("  adminPassword: ").Append(AdminPassword).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DNInstance);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DNInstance input)
        {
            if (input == null) return false;
            if (this.DnInstanceId != input.DnInstanceId || (this.DnInstanceId != null && !this.DnInstanceId.Equals(input.DnInstanceId))) return false;
            if (this.AdminUser != input.AdminUser || (this.AdminUser != null && !this.AdminUser.Equals(input.AdminUser))) return false;
            if (this.AdminPassword != input.AdminPassword || (this.AdminPassword != null && !this.AdminPassword.Equals(input.AdminPassword))) return false;

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
                if (this.DnInstanceId != null) hashCode = hashCode * 59 + this.DnInstanceId.GetHashCode();
                if (this.AdminUser != null) hashCode = hashCode * 59 + this.AdminUser.GetHashCode();
                if (this.AdminPassword != null) hashCode = hashCode * 59 + this.AdminPassword.GetHashCode();
                return hashCode;
            }
        }
    }
}
