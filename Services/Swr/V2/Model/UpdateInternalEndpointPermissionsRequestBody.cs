using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateInternalEndpointPermissionsRequestBody 
    {
        /// <summary>
        /// 操作类型。取值范围: - add:增加内网白名单操作 - remove:删除内网白名单操作
        /// </summary>
        /// <value>操作类型。取值范围: - add:增加内网白名单操作 - remove:删除内网白名单操作</value>
        [JsonConverter(typeof(EnumClassConverter<ActionEnum>))]
        public class ActionEnum
        {
            /// <summary>
            /// Enum ADD for value: add
            /// </summary>
            public static readonly ActionEnum ADD = new ActionEnum("add");

            /// <summary>
            /// Enum REMOVE for value: remove
            /// </summary>
            public static readonly ActionEnum REMOVE = new ActionEnum("remove");

            private static readonly Dictionary<string, ActionEnum> StaticFields =
            new Dictionary<string, ActionEnum>()
            {
                { "add", ADD },
                { "remove", REMOVE },
            };

            private string _value;

            public ActionEnum()
            {

            }

            public ActionEnum(string value)
            {
                _value = value;
            }

            public static ActionEnum FromValue(string value)
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

                if (this.Equals(obj as ActionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ActionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ActionEnum a, ActionEnum b)
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

            public static bool operator !=(ActionEnum a, ActionEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 权限类型。取值范围: - domainId：基于账户ID配置终端节点服务白名单 - orgPath：基于账户所在组织路径配置终端节点服务白名单
        /// </summary>
        /// <value>权限类型。取值范围: - domainId：基于账户ID配置终端节点服务白名单 - orgPath：基于账户所在组织路径配置终端节点服务白名单</value>
        [JsonConverter(typeof(EnumClassConverter<PermissionTypeEnum>))]
        public class PermissionTypeEnum
        {
            /// <summary>
            /// Enum DOMAINID for value: domainId
            /// </summary>
            public static readonly PermissionTypeEnum DOMAINID = new PermissionTypeEnum("domainId");

            /// <summary>
            /// Enum ORGPATH for value: orgPath
            /// </summary>
            public static readonly PermissionTypeEnum ORGPATH = new PermissionTypeEnum("orgPath");

            private static readonly Dictionary<string, PermissionTypeEnum> StaticFields =
            new Dictionary<string, PermissionTypeEnum>()
            {
                { "domainId", DOMAINID },
                { "orgPath", ORGPATH },
            };

            private string _value;

            public PermissionTypeEnum()
            {

            }

            public PermissionTypeEnum(string value)
            {
                _value = value;
            }

            public static PermissionTypeEnum FromValue(string value)
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

                if (this.Equals(obj as PermissionTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PermissionTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PermissionTypeEnum a, PermissionTypeEnum b)
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

            public static bool operator !=(PermissionTypeEnum a, PermissionTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 权限格式为： - iam:domain::domain_id。其中：\&quot;iam:domain::\&quot;为固定格式，\&quot;domain_id\&quot;为可连接用户的账号ID。domain_id类型支持输入包括\&quot;a~z\&quot;、\&quot;A~Z\&quot;、\&quot;0~9\&quot;或者\&quot;*\&quot;，最大长度可以传64。 - iam:domainName::domain_name_reg。其中：\&quot;iam:domainName::\&quot;为固定格式，\&quot;domain_name_reg\&quot;为可连接用户的账号名。domain_name_reg类型支持输入包括\&quot;a~z\&quot;、\&quot;A~Z\&quot;、\&quot;0~9\&quot;, \&quot;_+*.-?{},\&quot;，最大长度可以传80。 - organizations:orgPath::org_path。其中: \&quot;organizations:orgPath::\&quot;为固定格式，org_path为可连接用户的组织路径。 org_path类型支持\&quot;a~z\&quot;、\&quot;A~Z\&quot;、\&quot;0~9\&quot;、\&quot;/-?\&quot;或者\&quot;*\&quot;，最大长度可以传1024。 - \&quot;*\&quot; (表示所有终端节点可连接)  示例： - iam:domain::6e9dfd51d1124e8d8498dce894923a0dd - iam:domainName::op_svc_vpcep.* - organizations:orgPath::o-3j59d1231uprgk9yuvlidra7zbzfi578/r-rldbu1vmxdw5ahdkknxnvd5rgag77m2z/ou-7tuddd8nh99rebxltawsm6qct5z7rklv/_* - \&quot;*\&quot;（表示所有终端节点可连接）
        /// </summary>
        [JsonProperty("permissions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Permissions { get; set; }

        /// <summary>
        /// 操作类型。取值范围: - add:增加内网白名单操作 - remove:删除内网白名单操作
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// 权限类型。取值范围: - domainId：基于账户ID配置终端节点服务白名单 - orgPath：基于账户所在组织路径配置终端节点服务白名单
        /// </summary>
        [JsonProperty("permission_type", NullValueHandling = NullValueHandling.Ignore)]
        public PermissionTypeEnum PermissionType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateInternalEndpointPermissionsRequestBody {\n");
            sb.Append("  permissions: ").Append(Permissions).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  permissionType: ").Append(PermissionType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateInternalEndpointPermissionsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateInternalEndpointPermissionsRequestBody input)
        {
            if (input == null) return false;
            if (this.Permissions != input.Permissions || (this.Permissions != null && input.Permissions != null && !this.Permissions.SequenceEqual(input.Permissions))) return false;
            if (this.Action != input.Action) return false;
            if (this.PermissionType != input.PermissionType) return false;

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
                if (this.Permissions != null) hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                hashCode = hashCode * 59 + this.PermissionType.GetHashCode();
                return hashCode;
            }
        }
    }
}
