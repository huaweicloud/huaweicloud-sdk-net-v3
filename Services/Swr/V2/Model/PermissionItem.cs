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
    public class PermissionItem 
    {
        /// <summary>
        /// 权限类型。取值范围： - domainId：基于账户ID配置终端节点服务白名单 - orgPath：基于账户所在组织路径配置终端节点服务白名单
        /// </summary>
        /// <value>权限类型。取值范围： - domainId：基于账户ID配置终端节点服务白名单 - orgPath：基于账户所在组织路径配置终端节点服务白名单</value>
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
        /// 权限uuid
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 权限内容。权限格式为： - iam:domain::domain_id。其中：\&quot;iam:domain::\&quot;为固定格式，\&quot;domain_id\&quot;为可连接用户的账号ID。domain_id类型支持输入包括\&quot;a~z\&quot;、\&quot;A~Z\&quot;、\&quot;0~9\&quot;或者\&quot;*\&quot;，最大长度可以传64。 - iam:domainName::domain_name_reg。其中：\&quot;iam:domainName::\&quot;为固定格式，\&quot;domain_name_reg\&quot;为可连接用户的账号名。domain_name_reg类型支持输入包括\&quot;a~z\&quot;、\&quot;A~Z\&quot;、\&quot;0~9\&quot;, \&quot;_+*.-?{},\&quot;，最大长度可以传80。 - organizations:orgPath::org_path。其中: \&quot;organizations:orgPath::\&quot;为固定格式，org_path为可连接用户的组织路径。 org_path类型支持\&quot;a~z\&quot;、\&quot;A~Z\&quot;、\&quot;0~9\&quot;、\&quot;/-?\&quot;或者\&quot;*\&quot;，最大长度可以传1024。 - \&quot;*\&quot; (表示所有终端节点可连接)  示例： - iam:domain::6e9dfd51d1124e8d8498dce894923a0dd - iam:domainName::op_svc_vpcep.* - organizations:orgPath::o-3j59d1231uprgk9yuvlidra7zbzfi578/r-rldbu1vmxdw5ahdkknxnvd5rgag77m2z/ou-7tuddd8nh99rebxltawsm6qct5z7rklv/_* - \&quot;*\&quot; (表示所有终端节点可连接)
        /// </summary>
        [JsonProperty("permission", NullValueHandling = NullValueHandling.Ignore)]
        public string Permission { get; set; }

        /// <summary>
        /// 权限类型。取值范围： - domainId：基于账户ID配置终端节点服务白名单 - orgPath：基于账户所在组织路径配置终端节点服务白名单
        /// </summary>
        [JsonProperty("permission_type", NullValueHandling = NullValueHandling.Ignore)]
        public PermissionTypeEnum PermissionType { get; set; }
        /// <summary>
        /// 白名单的添加时间。采用UTC时间格式，格式为：YYYY-MM-DDTHH:MM:SSZ
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 是否为保护内网访问白名单；如果为true则不允许添加或者移除
        /// </summary>
        [JsonProperty("protected", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Protected { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PermissionItem {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  permission: ").Append(Permission).Append("\n");
            sb.Append("  permissionType: ").Append(PermissionType).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Protected: ").Append(Protected).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PermissionItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PermissionItem input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Permission != input.Permission || (this.Permission != null && !this.Permission.Equals(input.Permission))) return false;
            if (this.PermissionType != input.PermissionType) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.Protected != input.Protected || (this.Protected != null && !this.Protected.Equals(input.Protected))) return false;

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
                if (this.Permission != null) hashCode = hashCode * 59 + this.Permission.GetHashCode();
                hashCode = hashCode * 59 + this.PermissionType.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Protected != null) hashCode = hashCode * 59 + this.Protected.GetHashCode();
                return hashCode;
            }
        }
    }
}
