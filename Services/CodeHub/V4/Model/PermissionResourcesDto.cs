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
    public class PermissionResourcesDto 
    {

        /// <summary>
        /// **参数解释：** 资源id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** 资源名称。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 资源中文名称。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("name_cn", NullValueHandling = NullValueHandling.Ignore)]
        public string NameCn { get; set; }

        /// <summary>
        /// **参数解释：** 禁用资源名称。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("resource_name_display", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceNameDisplay { get; set; }

        /// <summary>
        /// **参数解释：** 禁用资源中文名称。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("resource_name_cn_display", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceNameCnDisplay { get; set; }

        /// <summary>
        /// **参数解释：** 权限路径。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// **参数解释：** 资源类型。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public string Scope { get; set; }

        /// <summary>
        /// **参数解释：** 创建时间。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// **参数解释：** 更新时间。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PermissionResourcesDto {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  nameCn: ").Append(NameCn).Append("\n");
            sb.Append("  resourceNameDisplay: ").Append(ResourceNameDisplay).Append("\n");
            sb.Append("  resourceNameCnDisplay: ").Append(ResourceNameCnDisplay).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  scope: ").Append(Scope).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PermissionResourcesDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PermissionResourcesDto input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.NameCn != input.NameCn || (this.NameCn != null && !this.NameCn.Equals(input.NameCn))) return false;
            if (this.ResourceNameDisplay != input.ResourceNameDisplay || (this.ResourceNameDisplay != null && !this.ResourceNameDisplay.Equals(input.ResourceNameDisplay))) return false;
            if (this.ResourceNameCnDisplay != input.ResourceNameCnDisplay || (this.ResourceNameCnDisplay != null && !this.ResourceNameCnDisplay.Equals(input.ResourceNameCnDisplay))) return false;
            if (this.Path != input.Path || (this.Path != null && !this.Path.Equals(input.Path))) return false;
            if (this.Scope != input.Scope || (this.Scope != null && !this.Scope.Equals(input.Scope))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NameCn != null) hashCode = hashCode * 59 + this.NameCn.GetHashCode();
                if (this.ResourceNameDisplay != null) hashCode = hashCode * 59 + this.ResourceNameDisplay.GetHashCode();
                if (this.ResourceNameCnDisplay != null) hashCode = hashCode * 59 + this.ResourceNameCnDisplay.GetHashCode();
                if (this.Path != null) hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Scope != null) hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
