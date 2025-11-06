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
    /// 
    /// </summary>
    public class NamespaceBasicDto 
    {

        /// <summary>
        /// **参数解释：** 命名空间ID。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** 命名空间名称。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 路径。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// **参数解释：** 开发模式。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("develop_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string DevelopMode { get; set; }

        /// <summary>
        /// **参数解释：** 类型。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public string Kind { get; set; }

        /// <summary>
        /// **参数解释：** 完整路径。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("full_path", NullValueHandling = NullValueHandling.Ignore)]
        public string FullPath { get; set; }

        /// <summary>
        /// **参数解释：** 完整名称。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("full_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FullName { get; set; }

        /// <summary>
        /// **参数解释：** 父级ID。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ParentId { get; set; }

        /// <summary>
        /// **参数解释：** 可见级别。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("visibility_level", NullValueHandling = NullValueHandling.Ignore)]
        public int? VisibilityLevel { get; set; }

        /// <summary>
        /// **参数解释：** 开启文件权限控制。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("enable_file_control", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableFileControl { get; set; }

        /// <summary>
        /// **参数解释：** 所有人ID。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("owner_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? OwnerId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NamespaceBasicDto {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  developMode: ").Append(DevelopMode).Append("\n");
            sb.Append("  kind: ").Append(Kind).Append("\n");
            sb.Append("  fullPath: ").Append(FullPath).Append("\n");
            sb.Append("  fullName: ").Append(FullName).Append("\n");
            sb.Append("  parentId: ").Append(ParentId).Append("\n");
            sb.Append("  visibilityLevel: ").Append(VisibilityLevel).Append("\n");
            sb.Append("  enableFileControl: ").Append(EnableFileControl).Append("\n");
            sb.Append("  ownerId: ").Append(OwnerId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NamespaceBasicDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NamespaceBasicDto input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Path != input.Path || (this.Path != null && !this.Path.Equals(input.Path))) return false;
            if (this.DevelopMode != input.DevelopMode || (this.DevelopMode != null && !this.DevelopMode.Equals(input.DevelopMode))) return false;
            if (this.Kind != input.Kind || (this.Kind != null && !this.Kind.Equals(input.Kind))) return false;
            if (this.FullPath != input.FullPath || (this.FullPath != null && !this.FullPath.Equals(input.FullPath))) return false;
            if (this.FullName != input.FullName || (this.FullName != null && !this.FullName.Equals(input.FullName))) return false;
            if (this.ParentId != input.ParentId || (this.ParentId != null && !this.ParentId.Equals(input.ParentId))) return false;
            if (this.VisibilityLevel != input.VisibilityLevel || (this.VisibilityLevel != null && !this.VisibilityLevel.Equals(input.VisibilityLevel))) return false;
            if (this.EnableFileControl != input.EnableFileControl || (this.EnableFileControl != null && !this.EnableFileControl.Equals(input.EnableFileControl))) return false;
            if (this.OwnerId != input.OwnerId || (this.OwnerId != null && !this.OwnerId.Equals(input.OwnerId))) return false;

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
                if (this.Path != null) hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.DevelopMode != null) hashCode = hashCode * 59 + this.DevelopMode.GetHashCode();
                if (this.Kind != null) hashCode = hashCode * 59 + this.Kind.GetHashCode();
                if (this.FullPath != null) hashCode = hashCode * 59 + this.FullPath.GetHashCode();
                if (this.FullName != null) hashCode = hashCode * 59 + this.FullName.GetHashCode();
                if (this.ParentId != null) hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.VisibilityLevel != null) hashCode = hashCode * 59 + this.VisibilityLevel.GetHashCode();
                if (this.EnableFileControl != null) hashCode = hashCode * 59 + this.EnableFileControl.GetHashCode();
                if (this.OwnerId != null) hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
                return hashCode;
            }
        }
    }
}
