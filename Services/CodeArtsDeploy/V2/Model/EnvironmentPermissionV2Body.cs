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
    /// 环境修改权限请求体
    /// </summary>
    public class EnvironmentPermissionV2Body 
    {
        /// <summary>
        /// 权限名称，can_view：查看权限；can_edit：编辑权限；can_delete：删除权限；can_deploy：部署权限；can_manage：权限管理权限
        /// </summary>
        /// <value>权限名称，can_view：查看权限；can_edit：编辑权限；can_delete：删除权限；can_deploy：部署权限；can_manage：权限管理权限</value>
        [JsonConverter(typeof(EnumClassConverter<PermissionNameEnum>))]
        public class PermissionNameEnum
        {
            /// <summary>
            /// Enum CAN_VIEW for value: can_view
            /// </summary>
            public static readonly PermissionNameEnum CAN_VIEW = new PermissionNameEnum("can_view");

            /// <summary>
            /// Enum CAN_EDIT for value: can_edit
            /// </summary>
            public static readonly PermissionNameEnum CAN_EDIT = new PermissionNameEnum("can_edit");

            /// <summary>
            /// Enum CAN_DELETE for value: can_delete
            /// </summary>
            public static readonly PermissionNameEnum CAN_DELETE = new PermissionNameEnum("can_delete");

            /// <summary>
            /// Enum CAN_DEPLOY for value: can_deploy
            /// </summary>
            public static readonly PermissionNameEnum CAN_DEPLOY = new PermissionNameEnum("can_deploy");

            /// <summary>
            /// Enum CAN_MANAGE for value: can_manage
            /// </summary>
            public static readonly PermissionNameEnum CAN_MANAGE = new PermissionNameEnum("can_manage");

            private static readonly Dictionary<string, PermissionNameEnum> StaticFields =
            new Dictionary<string, PermissionNameEnum>()
            {
                { "can_view", CAN_VIEW },
                { "can_edit", CAN_EDIT },
                { "can_delete", CAN_DELETE },
                { "can_deploy", CAN_DEPLOY },
                { "can_manage", CAN_MANAGE },
            };

            private string _value;

            public PermissionNameEnum()
            {

            }

            public PermissionNameEnum(string value)
            {
                _value = value;
            }

            public static PermissionNameEnum FromValue(string value)
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

                if (this.Equals(obj as PermissionNameEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PermissionNameEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PermissionNameEnum a, PermissionNameEnum b)
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

            public static bool operator !=(PermissionNameEnum a, PermissionNameEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 角色id
        /// </summary>
        [JsonProperty("role_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleId { get; set; }

        /// <summary>
        /// 权限名称，can_view：查看权限；can_edit：编辑权限；can_delete：删除权限；can_deploy：部署权限；can_manage：权限管理权限
        /// </summary>
        [JsonProperty("permission_name", NullValueHandling = NullValueHandling.Ignore)]
        public PermissionNameEnum PermissionName { get; set; }
        /// <summary>
        /// true 有权限，false 无权限
        /// </summary>
        [JsonProperty("permission_value", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PermissionValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnvironmentPermissionV2Body {\n");
            sb.Append("  roleId: ").Append(RoleId).Append("\n");
            sb.Append("  permissionName: ").Append(PermissionName).Append("\n");
            sb.Append("  permissionValue: ").Append(PermissionValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnvironmentPermissionV2Body);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EnvironmentPermissionV2Body input)
        {
            if (input == null) return false;
            if (this.RoleId != input.RoleId || (this.RoleId != null && !this.RoleId.Equals(input.RoleId))) return false;
            if (this.PermissionName != input.PermissionName) return false;
            if (this.PermissionValue != input.PermissionValue || (this.PermissionValue != null && !this.PermissionValue.Equals(input.PermissionValue))) return false;

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
                hashCode = hashCode * 59 + this.PermissionName.GetHashCode();
                if (this.PermissionValue != null) hashCode = hashCode * 59 + this.PermissionValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
