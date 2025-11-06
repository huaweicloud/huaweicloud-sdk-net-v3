using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowGroupPermissionInheritEnabledResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 使用项目权限配置开关是否开启。
        /// </summary>
        [JsonProperty("permission_inherit_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PermissionInheritEnabled { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowGroupPermissionInheritEnabledResponse {\n");
            sb.Append("  permissionInheritEnabled: ").Append(PermissionInheritEnabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowGroupPermissionInheritEnabledResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowGroupPermissionInheritEnabledResponse input)
        {
            if (input == null) return false;
            if (this.PermissionInheritEnabled != input.PermissionInheritEnabled || (this.PermissionInheritEnabled != null && !this.PermissionInheritEnabled.Equals(input.PermissionInheritEnabled))) return false;

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
                if (this.PermissionInheritEnabled != null) hashCode = hashCode * 59 + this.PermissionInheritEnabled.GetHashCode();
                return hashCode;
            }
        }
    }
}
