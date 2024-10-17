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
    /// 主机集群权限类
    /// </summary>
    public class DevUcClusterPermission 
    {
        /// <summary>
        /// 角色类型，project-customized：自定义角色；template-project-customized：系统自定义角色； template-customized-inst：系统角色；cluster-creator：集群创建者；project_admin：项目创建者
        /// </summary>
        /// <value>角色类型，project-customized：自定义角色；template-project-customized：系统自定义角色； template-customized-inst：系统角色；cluster-creator：集群创建者；project_admin：项目创建者</value>
        [JsonConverter(typeof(EnumClassConverter<RoleTypeEnum>))]
        public class RoleTypeEnum
        {
            /// <summary>
            /// Enum PROJECT_CUSTOMIZED for value: project-customized
            /// </summary>
            public static readonly RoleTypeEnum PROJECT_CUSTOMIZED = new RoleTypeEnum("project-customized");

            /// <summary>
            /// Enum TEMPLATE_PROJECT_CUSTOMIZED for value: template-project-customized
            /// </summary>
            public static readonly RoleTypeEnum TEMPLATE_PROJECT_CUSTOMIZED = new RoleTypeEnum("template-project-customized");

            /// <summary>
            /// Enum TEMPLATE_CUSTOMIZED_INST for value: template-customized-inst
            /// </summary>
            public static readonly RoleTypeEnum TEMPLATE_CUSTOMIZED_INST = new RoleTypeEnum("template-customized-inst");

            /// <summary>
            /// Enum CLUSTER_CREATOR for value: cluster-creator
            /// </summary>
            public static readonly RoleTypeEnum CLUSTER_CREATOR = new RoleTypeEnum("cluster-creator");

            /// <summary>
            /// Enum PROJECT_ADMIN for value: project_admin
            /// </summary>
            public static readonly RoleTypeEnum PROJECT_ADMIN = new RoleTypeEnum("project_admin");

            private static readonly Dictionary<string, RoleTypeEnum> StaticFields =
            new Dictionary<string, RoleTypeEnum>()
            {
                { "project-customized", PROJECT_CUSTOMIZED },
                { "template-project-customized", TEMPLATE_PROJECT_CUSTOMIZED },
                { "template-customized-inst", TEMPLATE_CUSTOMIZED_INST },
                { "cluster-creator", CLUSTER_CREATOR },
                { "project_admin", PROJECT_ADMIN },
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
                if (System.Object.ReferenceEquals(a, b))
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
        /// 角色id列表
        /// </summary>
        [JsonProperty("devuc_role_id_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DevucRoleIdList { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 主机集群id
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

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
        /// 是否有添加主机权限
        /// </summary>
        [JsonProperty("can_add_host", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanAddHost { get; set; }

        /// <summary>
        /// 是否有权限管理权限
        /// </summary>
        [JsonProperty("can_manage", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanManage { get; set; }

        /// <summary>
        /// 是否有拷贝权限
        /// </summary>
        [JsonProperty("can_copy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanCopy { get; set; }

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
        /// 角色类型，project-customized：自定义角色；template-project-customized：系统自定义角色； template-customized-inst：系统角色；cluster-creator：集群创建者；project_admin：项目创建者
        /// </summary>
        [JsonProperty("role_type", NullValueHandling = NullValueHandling.Ignore)]
        public RoleTypeEnum RoleType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DevUcClusterPermission {\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  roleId: ").Append(RoleId).Append("\n");
            sb.Append("  devucRoleIdList: ").Append(DevucRoleIdList).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  canView: ").Append(CanView).Append("\n");
            sb.Append("  canEdit: ").Append(CanEdit).Append("\n");
            sb.Append("  canDelete: ").Append(CanDelete).Append("\n");
            sb.Append("  canAddHost: ").Append(CanAddHost).Append("\n");
            sb.Append("  canManage: ").Append(CanManage).Append("\n");
            sb.Append("  canCopy: ").Append(CanCopy).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  roleType: ").Append(RoleType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DevUcClusterPermission);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DevUcClusterPermission input)
        {
            if (input == null) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.RoleId != input.RoleId || (this.RoleId != null && !this.RoleId.Equals(input.RoleId))) return false;
            if (this.DevucRoleIdList != input.DevucRoleIdList || (this.DevucRoleIdList != null && input.DevucRoleIdList != null && !this.DevucRoleIdList.SequenceEqual(input.DevucRoleIdList))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.CanView != input.CanView || (this.CanView != null && !this.CanView.Equals(input.CanView))) return false;
            if (this.CanEdit != input.CanEdit || (this.CanEdit != null && !this.CanEdit.Equals(input.CanEdit))) return false;
            if (this.CanDelete != input.CanDelete || (this.CanDelete != null && !this.CanDelete.Equals(input.CanDelete))) return false;
            if (this.CanAddHost != input.CanAddHost || (this.CanAddHost != null && !this.CanAddHost.Equals(input.CanAddHost))) return false;
            if (this.CanManage != input.CanManage || (this.CanManage != null && !this.CanManage.Equals(input.CanManage))) return false;
            if (this.CanCopy != input.CanCopy || (this.CanCopy != null && !this.CanCopy.Equals(input.CanCopy))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
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
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.RoleId != null) hashCode = hashCode * 59 + this.RoleId.GetHashCode();
                if (this.DevucRoleIdList != null) hashCode = hashCode * 59 + this.DevucRoleIdList.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.CanView != null) hashCode = hashCode * 59 + this.CanView.GetHashCode();
                if (this.CanEdit != null) hashCode = hashCode * 59 + this.CanEdit.GetHashCode();
                if (this.CanDelete != null) hashCode = hashCode * 59 + this.CanDelete.GetHashCode();
                if (this.CanAddHost != null) hashCode = hashCode * 59 + this.CanAddHost.GetHashCode();
                if (this.CanManage != null) hashCode = hashCode * 59 + this.CanManage.GetHashCode();
                if (this.CanCopy != null) hashCode = hashCode * 59 + this.CanCopy.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                hashCode = hashCode * 59 + this.RoleType.GetHashCode();
                return hashCode;
            }
        }
    }
}
