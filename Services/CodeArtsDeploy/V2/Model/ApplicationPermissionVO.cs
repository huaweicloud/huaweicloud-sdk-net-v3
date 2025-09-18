using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsDeploy.V2.Model
{
    /// <summary>
    /// 角色应用权限
    /// </summary>
    public class ApplicationPermissionVO 
    {
        /// <summary>
        /// 角色类型， app-creator： 应用创建者； project： 项目管理员；template-customized-inst：系统角色； template-project-customized、project-customized：自定义角色
        /// </summary>
        /// <value>角色类型， app-creator： 应用创建者； project： 项目管理员；template-customized-inst：系统角色； template-project-customized、project-customized：自定义角色</value>
        [JsonConverter(typeof(EnumClassConverter<RoleTypeEnum>))]
        public class RoleTypeEnum
        {
            /// <summary>
            /// Enum APP_CREATOR for value: app-creator
            /// </summary>
            public static readonly RoleTypeEnum APP_CREATOR = new RoleTypeEnum("app-creator");

            /// <summary>
            /// Enum PROJECT for value: project
            /// </summary>
            public static readonly RoleTypeEnum PROJECT = new RoleTypeEnum("project");

            /// <summary>
            /// Enum TEMPLATE_CUSTOMIZED_INST for value: template-customized-inst
            /// </summary>
            public static readonly RoleTypeEnum TEMPLATE_CUSTOMIZED_INST = new RoleTypeEnum("template-customized-inst");

            /// <summary>
            /// Enum TEMPLATE_PROJECT_CUSTOMIZED for value: template-project-customized
            /// </summary>
            public static readonly RoleTypeEnum TEMPLATE_PROJECT_CUSTOMIZED = new RoleTypeEnum("template-project-customized");

            /// <summary>
            /// Enum PROJECT_CUSTOMIZED for value: project-customized
            /// </summary>
            public static readonly RoleTypeEnum PROJECT_CUSTOMIZED = new RoleTypeEnum("project-customized");

            private static readonly Dictionary<string, RoleTypeEnum> StaticFields =
            new Dictionary<string, RoleTypeEnum>()
            {
                { "app-creator", APP_CREATOR },
                { "project", PROJECT },
                { "template-customized-inst", TEMPLATE_CUSTOMIZED_INST },
                { "template-project-customized", TEMPLATE_PROJECT_CUSTOMIZED },
                { "project-customized", PROJECT_CUSTOMIZED },
            };

            private string _value;

            public RoleTypeEnum()
            {

            }

            public RoleTypeEnum(string value)
            {
                _value = value;
            }

            public static RoleTypeEnum FromValue(string value)
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

                if (this.Equals(obj as RoleTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RoleTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RoleTypeEnum a, RoleTypeEnum b)
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

            public static bool operator !=(RoleTypeEnum a, RoleTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 是否有编辑权限
        /// </summary>
        [JsonProperty("can_modify", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanModify { get; set; }

        /// <summary>
        /// 是否有删除的权限
        /// </summary>
        [JsonProperty("can_delete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanDelete { get; set; }

        /// <summary>
        /// 是否有查看权限
        /// </summary>
        [JsonProperty("can_view", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanView { get; set; }

        /// <summary>
        /// 是否有执行权限
        /// </summary>
        [JsonProperty("can_execute", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanExecute { get; set; }

        /// <summary>
        /// 是否有复制权限
        /// </summary>
        [JsonProperty("can_copy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanCopy { get; set; }

        /// <summary>
        /// 是否有管理权限，包含增删改查执行以及权限修改
        /// </summary>
        [JsonProperty("can_manage", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanManage { get; set; }

        /// <summary>
        /// 是否有新建环境权限
        /// </summary>
        [JsonProperty("can_create_env", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanCreateEnv { get; set; }

        /// <summary>
        /// 是否有禁用权限
        /// </summary>
        [JsonProperty("can_disable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanDisable { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 局点信息
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 角色id
        /// </summary>
        [JsonProperty("role_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleId { get; set; }

        /// <summary>
        /// 角色类型， app-creator： 应用创建者； project： 项目管理员；template-customized-inst：系统角色； template-project-customized、project-customized：自定义角色
        /// </summary>
        [JsonProperty("role_type", NullValueHandling = NullValueHandling.Ignore)]
        public RoleTypeEnum RoleType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationPermissionVO {\n");
            sb.Append("  canModify: ").Append(CanModify).Append("\n");
            sb.Append("  canDelete: ").Append(CanDelete).Append("\n");
            sb.Append("  canView: ").Append(CanView).Append("\n");
            sb.Append("  canExecute: ").Append(CanExecute).Append("\n");
            sb.Append("  canCopy: ").Append(CanCopy).Append("\n");
            sb.Append("  canManage: ").Append(CanManage).Append("\n");
            sb.Append("  canCreateEnv: ").Append(CanCreateEnv).Append("\n");
            sb.Append("  canDisable: ").Append(CanDisable).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  roleId: ").Append(RoleId).Append("\n");
            sb.Append("  roleType: ").Append(RoleType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApplicationPermissionVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ApplicationPermissionVO input)
        {
            if (input == null) return false;
            if (this.CanModify != input.CanModify || (this.CanModify != null && !this.CanModify.Equals(input.CanModify))) return false;
            if (this.CanDelete != input.CanDelete || (this.CanDelete != null && !this.CanDelete.Equals(input.CanDelete))) return false;
            if (this.CanView != input.CanView || (this.CanView != null && !this.CanView.Equals(input.CanView))) return false;
            if (this.CanExecute != input.CanExecute || (this.CanExecute != null && !this.CanExecute.Equals(input.CanExecute))) return false;
            if (this.CanCopy != input.CanCopy || (this.CanCopy != null && !this.CanCopy.Equals(input.CanCopy))) return false;
            if (this.CanManage != input.CanManage || (this.CanManage != null && !this.CanManage.Equals(input.CanManage))) return false;
            if (this.CanCreateEnv != input.CanCreateEnv || (this.CanCreateEnv != null && !this.CanCreateEnv.Equals(input.CanCreateEnv))) return false;
            if (this.CanDisable != input.CanDisable || (this.CanDisable != null && !this.CanDisable.Equals(input.CanDisable))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.RoleId != input.RoleId || (this.RoleId != null && !this.RoleId.Equals(input.RoleId))) return false;
            if (this.RoleType != input.RoleType) return false;

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
                if (this.CanModify != null) hashCode = hashCode * 59 + this.CanModify.GetHashCode();
                if (this.CanDelete != null) hashCode = hashCode * 59 + this.CanDelete.GetHashCode();
                if (this.CanView != null) hashCode = hashCode * 59 + this.CanView.GetHashCode();
                if (this.CanExecute != null) hashCode = hashCode * 59 + this.CanExecute.GetHashCode();
                if (this.CanCopy != null) hashCode = hashCode * 59 + this.CanCopy.GetHashCode();
                if (this.CanManage != null) hashCode = hashCode * 59 + this.CanManage.GetHashCode();
                if (this.CanCreateEnv != null) hashCode = hashCode * 59 + this.CanCreateEnv.GetHashCode();
                if (this.CanDisable != null) hashCode = hashCode * 59 + this.CanDisable.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.RoleId != null) hashCode = hashCode * 59 + this.RoleId.GetHashCode();
                hashCode = hashCode * 59 + this.RoleType.GetHashCode();
                return hashCode;
            }
        }
    }
}
