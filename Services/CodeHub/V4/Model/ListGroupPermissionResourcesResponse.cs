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
    /// Response Object
    /// </summary>
    public class ListGroupPermissionResourcesResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 是否使用项目权限。
        /// </summary>
        [JsonProperty("use_project_permission", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseProjectPermission { get; set; }

        /// <summary>
        /// **参数解释：** 资源列表。
        /// </summary>
        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<PermissionResourcesDto> Resources { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListGroupPermissionResourcesResponse {\n");
            sb.Append("  useProjectPermission: ").Append(UseProjectPermission).Append("\n");
            sb.Append("  resources: ").Append(Resources).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListGroupPermissionResourcesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListGroupPermissionResourcesResponse input)
        {
            if (input == null) return false;
            if (this.UseProjectPermission != input.UseProjectPermission || (this.UseProjectPermission != null && !this.UseProjectPermission.Equals(input.UseProjectPermission))) return false;
            if (this.Resources != input.Resources || (this.Resources != null && input.Resources != null && !this.Resources.SequenceEqual(input.Resources))) return false;

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
                if (this.UseProjectPermission != null) hashCode = hashCode * 59 + this.UseProjectPermission.GetHashCode();
                if (this.Resources != null) hashCode = hashCode * 59 + this.Resources.GetHashCode();
                return hashCode;
            }
        }
    }
}
