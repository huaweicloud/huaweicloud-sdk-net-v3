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
    /// used_rds参数说明
    /// </summary>
    public class DatabaseInstabcesParam 
    {

        /// <summary>
        /// 逻辑库关联的RDS的id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 关联RDS实例的用户。
        /// </summary>
        [JsonProperty("adminUser", NullValueHandling = NullValueHandling.Ignore)]
        public string AdminUser { get; set; }

        /// <summary>
        /// 关联RDS实例的密码。
        /// </summary>
        [JsonProperty("adminPassword", NullValueHandling = NullValueHandling.Ignore)]
        public string AdminPassword { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatabaseInstabcesParam {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
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
            return this.Equals(input as DatabaseInstabcesParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DatabaseInstabcesParam input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.AdminUser != null) hashCode = hashCode * 59 + this.AdminUser.GetHashCode();
                if (this.AdminPassword != null) hashCode = hashCode * 59 + this.AdminPassword.GetHashCode();
                return hashCode;
            }
        }
    }
}
