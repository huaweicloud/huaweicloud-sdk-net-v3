using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 委托权限信息。
    /// </summary>
    public class AgenciesPermissionInfo 
    {

        /// <summary>
        /// 委托权限项。
        /// </summary>
        [JsonProperty("system_permission_display_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SystemPermissionDisplayNames { get; set; }

        /// <summary>
        /// 需要委托的权限项。
        /// </summary>
        [JsonProperty("wanted_system_permission_display_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> WantedSystemPermissionDisplayNames { get; set; }

        /// <summary>
        /// 目标委托的权限项。
        /// </summary>
        [JsonProperty("should_have_system_permission_display_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ShouldHaveSystemPermissionDisplayNames { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgenciesPermissionInfo {\n");
            sb.Append("  systemPermissionDisplayNames: ").Append(SystemPermissionDisplayNames).Append("\n");
            sb.Append("  wantedSystemPermissionDisplayNames: ").Append(WantedSystemPermissionDisplayNames).Append("\n");
            sb.Append("  shouldHaveSystemPermissionDisplayNames: ").Append(ShouldHaveSystemPermissionDisplayNames).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AgenciesPermissionInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AgenciesPermissionInfo input)
        {
            if (input == null) return false;
            if (this.SystemPermissionDisplayNames != input.SystemPermissionDisplayNames || (this.SystemPermissionDisplayNames != null && input.SystemPermissionDisplayNames != null && !this.SystemPermissionDisplayNames.SequenceEqual(input.SystemPermissionDisplayNames))) return false;
            if (this.WantedSystemPermissionDisplayNames != input.WantedSystemPermissionDisplayNames || (this.WantedSystemPermissionDisplayNames != null && input.WantedSystemPermissionDisplayNames != null && !this.WantedSystemPermissionDisplayNames.SequenceEqual(input.WantedSystemPermissionDisplayNames))) return false;
            if (this.ShouldHaveSystemPermissionDisplayNames != input.ShouldHaveSystemPermissionDisplayNames || (this.ShouldHaveSystemPermissionDisplayNames != null && input.ShouldHaveSystemPermissionDisplayNames != null && !this.ShouldHaveSystemPermissionDisplayNames.SequenceEqual(input.ShouldHaveSystemPermissionDisplayNames))) return false;

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
                if (this.SystemPermissionDisplayNames != null) hashCode = hashCode * 59 + this.SystemPermissionDisplayNames.GetHashCode();
                if (this.WantedSystemPermissionDisplayNames != null) hashCode = hashCode * 59 + this.WantedSystemPermissionDisplayNames.GetHashCode();
                if (this.ShouldHaveSystemPermissionDisplayNames != null) hashCode = hashCode * 59 + this.ShouldHaveSystemPermissionDisplayNames.GetHashCode();
                return hashCode;
            }
        }
    }
}
