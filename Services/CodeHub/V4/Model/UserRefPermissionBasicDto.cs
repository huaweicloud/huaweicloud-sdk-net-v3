using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UserRefPermissionBasicDto 
    {

        /// <summary>
        /// **参数解释：** 是否有权限。 **取值范围：** true：有权限，false：没权限
        /// </summary>
        [JsonProperty("has_permission", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasPermission { get; set; }

        /// <summary>
        /// **参数解释：** 是否保护分支。 **取值范围：** true：是保护分支，false：非保护分支
        /// </summary>
        [JsonProperty("is_protect", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsProtect { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserRefPermissionBasicDto {\n");
            sb.Append("  hasPermission: ").Append(HasPermission).Append("\n");
            sb.Append("  isProtect: ").Append(IsProtect).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserRefPermissionBasicDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UserRefPermissionBasicDto input)
        {
            if (input == null) return false;
            if (this.HasPermission != input.HasPermission || (this.HasPermission != null && !this.HasPermission.Equals(input.HasPermission))) return false;
            if (this.IsProtect != input.IsProtect || (this.IsProtect != null && !this.IsProtect.Equals(input.IsProtect))) return false;

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
                if (this.HasPermission != null) hashCode = hashCode * 59 + this.HasPermission.GetHashCode();
                if (this.IsProtect != null) hashCode = hashCode * 59 + this.IsProtect.GetHashCode();
                return hashCode;
            }
        }
    }
}
