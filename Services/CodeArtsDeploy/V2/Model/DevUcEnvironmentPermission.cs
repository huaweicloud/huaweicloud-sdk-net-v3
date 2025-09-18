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
    /// 应用环境鉴权类
    /// </summary>
    public class DevUcEnvironmentPermission 
    {
        /// <summary>
        /// 角色类型， environment-creator： 环境创建者； project： 项目管理员；template-customized-inst：系统角色； template-project-customized、project-customized：自定义角色
        /// </summary>
        /// <value>角色类型， environment-creator： 环境创建者； project： 项目管理员；template-customized-inst：系统角色； template-project-customized、project-customized：自定义角色</value>
        [JsonConverter(typeof(EnumClassConverter<RoleTypeEnum>))]
        public class RoleTypeEnum
        {
            /// <summary>
            /// Enum ENVIRONMENT_CREATOR for value: environment-creator
            /// </summary>
            public static readonly RoleTypeEnum ENVIRONMENT_CREATOR = new RoleTypeEnum("environment-creator");

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
                { "environment-creator", ENVIRONMENT_CREATOR },
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
        /// 权限id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 角色id
        /// </summary>
        [JsonProperty("role_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleId { get; set; }

        /// <summary>
        /// 角色id列表
        /// </summary>
        [JsonProperty("devuc_role_id_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DevucRoleIdList { get; set; }

        /// <summary>
        /// 角色类型， environment-creator： 环境创建者； project： 项目管理员；template-customized-inst：系统角色； template-project-customized、project-customized：自定义角色
        /// </summary>
        [JsonProperty("role_type", NullValueHandling = NullValueHandling.Ignore)]
        public RoleTypeEnum RoleType { get; set; }
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
        /// 环境id
        /// </summary>
        [JsonProperty("environment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// 是否有查看权限
        /// </summary>
        [JsonProperty("can_view", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanView { get; set; }

        /// <summary>
        /// 是否有编辑权限
        /// </summary>
        [JsonProperty("can_edit", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanEdit { get; set; }

        /// <summary>
        /// 是否有删除权限
        /// </summary>
        [JsonProperty("can_delete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanDelete { get; set; }

        /// <summary>
        /// 是否有部署权限
        /// </summary>
        [JsonProperty("can_deploy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanDeploy { get; set; }

        /// <summary>
        /// 是否有权限管理权限
        /// </summary>
        [JsonProperty("can_manage", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanManage { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DevUcEnvironmentPermission {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  roleId: ").Append(RoleId).Append("\n");
            sb.Append("  devucRoleIdList: ").Append(DevucRoleIdList).Append("\n");
            sb.Append("  roleType: ").Append(RoleType).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  environmentId: ").Append(EnvironmentId).Append("\n");
            sb.Append("  canView: ").Append(CanView).Append("\n");
            sb.Append("  canEdit: ").Append(CanEdit).Append("\n");
            sb.Append("  canDelete: ").Append(CanDelete).Append("\n");
            sb.Append("  canDeploy: ").Append(CanDeploy).Append("\n");
            sb.Append("  canManage: ").Append(CanManage).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DevUcEnvironmentPermission);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DevUcEnvironmentPermission input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.RoleId != input.RoleId || (this.RoleId != null && !this.RoleId.Equals(input.RoleId))) return false;
            if (this.DevucRoleIdList != input.DevucRoleIdList || (this.DevucRoleIdList != null && input.DevucRoleIdList != null && !this.DevucRoleIdList.SequenceEqual(input.DevucRoleIdList))) return false;
            if (this.RoleType != input.RoleType) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.EnvironmentId != input.EnvironmentId || (this.EnvironmentId != null && !this.EnvironmentId.Equals(input.EnvironmentId))) return false;
            if (this.CanView != input.CanView || (this.CanView != null && !this.CanView.Equals(input.CanView))) return false;
            if (this.CanEdit != input.CanEdit || (this.CanEdit != null && !this.CanEdit.Equals(input.CanEdit))) return false;
            if (this.CanDelete != input.CanDelete || (this.CanDelete != null && !this.CanDelete.Equals(input.CanDelete))) return false;
            if (this.CanDeploy != input.CanDeploy || (this.CanDeploy != null && !this.CanDeploy.Equals(input.CanDeploy))) return false;
            if (this.CanManage != input.CanManage || (this.CanManage != null && !this.CanManage.Equals(input.CanManage))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;

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
                if (this.RoleId != null) hashCode = hashCode * 59 + this.RoleId.GetHashCode();
                if (this.DevucRoleIdList != null) hashCode = hashCode * 59 + this.DevucRoleIdList.GetHashCode();
                hashCode = hashCode * 59 + this.RoleType.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.EnvironmentId != null) hashCode = hashCode * 59 + this.EnvironmentId.GetHashCode();
                if (this.CanView != null) hashCode = hashCode * 59 + this.CanView.GetHashCode();
                if (this.CanEdit != null) hashCode = hashCode * 59 + this.CanEdit.GetHashCode();
                if (this.CanDelete != null) hashCode = hashCode * 59 + this.CanDelete.GetHashCode();
                if (this.CanDeploy != null) hashCode = hashCode * 59 + this.CanDeploy.GetHashCode();
                if (this.CanManage != null) hashCode = hashCode * 59 + this.CanManage.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
