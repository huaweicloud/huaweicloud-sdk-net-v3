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
    public class ResourcePermissionDto 
    {

        /// <summary>
        /// **参数解释：** 记录id。
        /// </summary>
        [JsonProperty("permission_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PermissionId { get; set; }

        /// <summary>
        /// **参数解释：** 操作。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// **参数解释：** 操作名称。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// **参数解释：** 操作中文名称。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("display_name_cn", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayNameCn { get; set; }

        /// <summary>
        /// **参数解释：** 是否开启。
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// **参数解释：** 是否编辑。
        /// </summary>
        [JsonProperty("editable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Editable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourcePermissionDto {\n");
            sb.Append("  permissionId: ").Append(PermissionId).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  displayNameCn: ").Append(DisplayNameCn).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  editable: ").Append(Editable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourcePermissionDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourcePermissionDto input)
        {
            if (input == null) return false;
            if (this.PermissionId != input.PermissionId || (this.PermissionId != null && !this.PermissionId.Equals(input.PermissionId))) return false;
            if (this.Action != input.Action || (this.Action != null && !this.Action.Equals(input.Action))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.DisplayNameCn != input.DisplayNameCn || (this.DisplayNameCn != null && !this.DisplayNameCn.Equals(input.DisplayNameCn))) return false;
            if (this.Enabled != input.Enabled || (this.Enabled != null && !this.Enabled.Equals(input.Enabled))) return false;
            if (this.Editable != input.Editable || (this.Editable != null && !this.Editable.Equals(input.Editable))) return false;

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
                if (this.PermissionId != null) hashCode = hashCode * 59 + this.PermissionId.GetHashCode();
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.DisplayNameCn != null) hashCode = hashCode * 59 + this.DisplayNameCn.GetHashCode();
                if (this.Enabled != null) hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Editable != null) hashCode = hashCode * 59 + this.Editable.GetHashCode();
                return hashCode;
            }
        }
    }
}
