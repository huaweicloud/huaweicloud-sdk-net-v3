using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsArtifact.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Privilege 
    {
        /// <summary>
        /// **参数解释**: 操作权限，多个权限以英文逗号隔开。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 无。 
        /// </summary>
        /// <value>**参数解释**: 操作权限，多个权限以英文逗号隔开。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 无。 </value>
        [JsonConverter(typeof(EnumClassConverter<OperationsEnum>))]
        public class OperationsEnum
        {
            /// <summary>
            /// Enum CREATEREPOSITORY for value: createrepository
            /// </summary>
            public static readonly OperationsEnum CREATEREPOSITORY = new OperationsEnum("createrepository");

            /// <summary>
            /// Enum EDITREPOSITORY for value: editrepository
            /// </summary>
            public static readonly OperationsEnum EDITREPOSITORY = new OperationsEnum("editrepository");

            /// <summary>
            /// Enum RESTORE for value: restore
            /// </summary>
            public static readonly OperationsEnum RESTORE = new OperationsEnum("restore");

            /// <summary>
            /// Enum DELETEREPOSITORY for value: deleterepository
            /// </summary>
            public static readonly OperationsEnum DELETEREPOSITORY = new OperationsEnum("deleterepository");

            /// <summary>
            /// Enum PHYSICDELETE for value: physicdelete
            /// </summary>
            public static readonly OperationsEnum PHYSICDELETE = new OperationsEnum("physicdelete");

            /// <summary>
            /// Enum RESTOREALL for value: restoreall
            /// </summary>
            public static readonly OperationsEnum RESTOREALL = new OperationsEnum("restoreall");

            /// <summary>
            /// Enum CLEARALL for value: clearall
            /// </summary>
            public static readonly OperationsEnum CLEARALL = new OperationsEnum("clearall");

            /// <summary>
            /// Enum DELETEORREDEPLOY for value: deleteorredeploy
            /// </summary>
            public static readonly OperationsEnum DELETEORREDEPLOY = new OperationsEnum("deleteorredeploy");

            /// <summary>
            /// Enum DOWNLOADORVIEW for value: downloadorview
            /// </summary>
            public static readonly OperationsEnum DOWNLOADORVIEW = new OperationsEnum("downloadorview");

            /// <summary>
            /// Enum IMPORT for value: import
            /// </summary>
            public static readonly OperationsEnum IMPORT = new OperationsEnum("import");

            /// <summary>
            /// Enum UPLOAD for value: upload
            /// </summary>
            public static readonly OperationsEnum UPLOAD = new OperationsEnum("upload");

            /// <summary>
            /// Enum EXPORT for value: export
            /// </summary>
            public static readonly OperationsEnum EXPORT = new OperationsEnum("export");

            private static readonly Dictionary<string, OperationsEnum> StaticFields =
            new Dictionary<string, OperationsEnum>()
            {
                { "createrepository", CREATEREPOSITORY },
                { "editrepository", EDITREPOSITORY },
                { "restore", RESTORE },
                { "deleterepository", DELETEREPOSITORY },
                { "physicdelete", PHYSICDELETE },
                { "restoreall", RESTOREALL },
                { "clearall", CLEARALL },
                { "deleteorredeploy", DELETEORREDEPLOY },
                { "downloadorview", DOWNLOADORVIEW },
                { "import", IMPORT },
                { "upload", UPLOAD },
                { "export", EXPORT },
            };

            private string _value;

            public OperationsEnum()
            {

            }

            public OperationsEnum(string value)
            {
                _value = value;
            }

            public static OperationsEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as OperationsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OperationsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OperationsEnum a, OperationsEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(OperationsEnum a, OperationsEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**: 角色id。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 无。 
        /// </summary>
        [JsonProperty("role_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleId { get; set; }

        /// <summary>
        /// **参数解释**: 角色名称。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 无。 
        /// </summary>
        [JsonProperty("role_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleName { get; set; }

        /// <summary>
        /// **参数解释**: 角色中文名。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 无。 
        /// </summary>
        [JsonProperty("role_chinese_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleChineseName { get; set; }

        /// <summary>
        /// **参数解释**: 项目id。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 无。 
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释**: 地域服务id。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 无。 
        /// </summary>
        [JsonProperty("area_service_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AreaServiceId { get; set; }

        /// <summary>
        /// **参数解释**: 授权对象路径。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 无。 
        /// </summary>
        [JsonProperty("granted_object_path", NullValueHandling = NullValueHandling.Ignore)]
        public string GrantedObjectPath { get; set; }

        /// <summary>
        /// **参数解释**: 授权对象id。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 无。 
        /// </summary>
        [JsonProperty("granted_object_type_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GrantedObjectTypeId { get; set; }

        /// <summary>
        /// **参数解释**: 操作权限，多个权限以英文逗号隔开。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 无。 
        /// </summary>
        [JsonProperty("operations", NullValueHandling = NullValueHandling.Ignore)]
        public OperationsEnum Operations { get; set; }
        /// <summary>
        /// **参数解释**: 操作权限索引。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 无。 
        /// </summary>
        [JsonProperty("operations_index", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> OperationsIndex { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Privilege {\n");
            sb.Append("  roleId: ").Append(RoleId).Append("\n");
            sb.Append("  roleName: ").Append(RoleName).Append("\n");
            sb.Append("  roleChineseName: ").Append(RoleChineseName).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  areaServiceId: ").Append(AreaServiceId).Append("\n");
            sb.Append("  grantedObjectPath: ").Append(GrantedObjectPath).Append("\n");
            sb.Append("  grantedObjectTypeId: ").Append(GrantedObjectTypeId).Append("\n");
            sb.Append("  operations: ").Append(Operations).Append("\n");
            sb.Append("  operationsIndex: ").Append(OperationsIndex).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Privilege);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Privilege input)
        {
            if (input == null) return false;
            if (this.RoleId != input.RoleId || (this.RoleId != null && !this.RoleId.Equals(input.RoleId))) return false;
            if (this.RoleName != input.RoleName || (this.RoleName != null && !this.RoleName.Equals(input.RoleName))) return false;
            if (this.RoleChineseName != input.RoleChineseName || (this.RoleChineseName != null && !this.RoleChineseName.Equals(input.RoleChineseName))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.AreaServiceId != input.AreaServiceId || (this.AreaServiceId != null && !this.AreaServiceId.Equals(input.AreaServiceId))) return false;
            if (this.GrantedObjectPath != input.GrantedObjectPath || (this.GrantedObjectPath != null && !this.GrantedObjectPath.Equals(input.GrantedObjectPath))) return false;
            if (this.GrantedObjectTypeId != input.GrantedObjectTypeId || (this.GrantedObjectTypeId != null && !this.GrantedObjectTypeId.Equals(input.GrantedObjectTypeId))) return false;
            if (this.Operations != input.Operations) return false;
            if (this.OperationsIndex != input.OperationsIndex || (this.OperationsIndex != null && input.OperationsIndex != null && !this.OperationsIndex.SequenceEqual(input.OperationsIndex))) return false;

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
                if (this.RoleId != null) hashCode = hashCode * 59 + this.RoleId.GetHashCode();
                if (this.RoleName != null) hashCode = hashCode * 59 + this.RoleName.GetHashCode();
                if (this.RoleChineseName != null) hashCode = hashCode * 59 + this.RoleChineseName.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.AreaServiceId != null) hashCode = hashCode * 59 + this.AreaServiceId.GetHashCode();
                if (this.GrantedObjectPath != null) hashCode = hashCode * 59 + this.GrantedObjectPath.GetHashCode();
                if (this.GrantedObjectTypeId != null) hashCode = hashCode * 59 + this.GrantedObjectTypeId.GetHashCode();
                hashCode = hashCode * 59 + this.Operations.GetHashCode();
                if (this.OperationsIndex != null) hashCode = hashCode * 59 + this.OperationsIndex.GetHashCode();
                return hashCode;
            }
        }
    }
}
