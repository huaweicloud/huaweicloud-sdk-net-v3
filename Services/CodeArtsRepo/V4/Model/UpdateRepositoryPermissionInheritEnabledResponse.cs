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
    public class UpdateRepositoryPermissionInheritEnabledResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 权限继承设置。 **约束限制：** 不涉及。 **取值范围：** - true，使用上层权限配置，如果上层是代码组使用代码组权限配置，如果上层是项目使用项目权限配置。 - false，使用仓库权限配置。 
        /// </summary>
        [JsonProperty("inherit_parent_permission", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InheritParentPermission { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateRepositoryPermissionInheritEnabledResponse {\n");
            sb.Append("  inheritParentPermission: ").Append(InheritParentPermission).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateRepositoryPermissionInheritEnabledResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateRepositoryPermissionInheritEnabledResponse input)
        {
            if (input == null) return false;
            if (this.InheritParentPermission != input.InheritParentPermission || (this.InheritParentPermission != null && !this.InheritParentPermission.Equals(input.InheritParentPermission))) return false;

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
                if (this.InheritParentPermission != null) hashCode = hashCode * 59 + this.InheritParentPermission.GetHashCode();
                return hashCode;
            }
        }
    }
}
