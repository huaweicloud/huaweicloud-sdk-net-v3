using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class GaussDBListDatabaseRoles 
    {

        /// <summary>
        /// 数据库用户/角色名。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 用户/角色的默认权限。
        /// </summary>
        [JsonProperty("memberof", NullValueHandling = NullValueHandling.Ignore)]
        public string Memberof { get; set; }

        /// <summary>
        /// 用户/角色是否被锁。
        /// </summary>
        [JsonProperty("lock_status", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LockStatus { get; set; }

        /// <summary>
        /// 用户/角色的权限属性。
        /// </summary>
        [JsonProperty("attribute", NullValueHandling = NullValueHandling.Ignore)]
        public Object Attribute { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GaussDBListDatabaseRoles {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  memberof: ").Append(Memberof).Append("\n");
            sb.Append("  lockStatus: ").Append(LockStatus).Append("\n");
            sb.Append("  attribute: ").Append(Attribute).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GaussDBListDatabaseRoles);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GaussDBListDatabaseRoles input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Memberof != input.Memberof || (this.Memberof != null && !this.Memberof.Equals(input.Memberof))) return false;
            if (this.LockStatus != input.LockStatus || (this.LockStatus != null && !this.LockStatus.Equals(input.LockStatus))) return false;
            if (this.Attribute != input.Attribute || (this.Attribute != null && !this.Attribute.Equals(input.Attribute))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Memberof != null) hashCode = hashCode * 59 + this.Memberof.GetHashCode();
                if (this.LockStatus != null) hashCode = hashCode * 59 + this.LockStatus.GetHashCode();
                if (this.Attribute != null) hashCode = hashCode * 59 + this.Attribute.GetHashCode();
                return hashCode;
            }
        }
    }
}
