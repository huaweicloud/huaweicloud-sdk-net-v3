using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpcep.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class AddOrRemoveServicePermissionsResponse : SdkResponse
    {
        /// <summary>
        /// 终端节点服务白名单类型。 ● domainId：基于账户ID配置终端节点服务白名单。 ● orgPath：基于账户所在组织路径配置终端节点服务白名单。
        /// </summary>
        /// <value>终端节点服务白名单类型。 ● domainId：基于账户ID配置终端节点服务白名单。 ● orgPath：基于账户所在组织路径配置终端节点服务白名单。</value>
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

            public static bool operator !=(PermissionTypeEnum a, PermissionTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// permission列表。 权限格式为：iam:domain::domain_id或者organizations:orgPath::org_path其中， ● “iam:domain::”和“organizations:orgPath::”为固定格式。 ● “domain_id”为可连接用户的帐号ID，org_path可连接用户的组织路径 domain_id类型支持输入包括“a~z”、“A~Z”、“0~9”或者“*”，org_path类型支持“a~z”、“A~Z”、“0~9”、“/-*?”或者“*”。 “*”表示所有终端节点可连接。 例如：iam:domain::6e9dfd51d1124e8d8498dce894923a0dd或者organizations:orgPath::o-3j59d1231uprgk9yuvlidra7zbzfi578/r-rldbu1vmxdw5ahdkknxnvd5rgag77m2z/ou-7tuddd8nh99rebxltawsm6qct5z7rklv/_*
        /// </summary>
        [JsonProperty("permissions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Permissions { get; set; }

        /// <summary>
        /// 终端节点服务白名单类型。 ● domainId：基于账户ID配置终端节点服务白名单。 ● orgPath：基于账户所在组织路径配置终端节点服务白名单。
        /// </summary>
        [JsonProperty("permission_type", NullValueHandling = NullValueHandling.Ignore)]
        public PermissionTypeEnum PermissionType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddOrRemoveServicePermissionsResponse {\n");
            sb.Append("  permissions: ").Append(Permissions).Append("\n");
            sb.Append("  permissionType: ").Append(PermissionType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddOrRemoveServicePermissionsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddOrRemoveServicePermissionsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Permissions == input.Permissions ||
                    this.Permissions != null &&
                    input.Permissions != null &&
                    this.Permissions.SequenceEqual(input.Permissions)
                ) && 
                (
                    this.PermissionType == input.PermissionType ||
                    (this.PermissionType != null &&
                    this.PermissionType.Equals(input.PermissionType))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                if (this.PermissionType != null)
                    hashCode = hashCode * 59 + this.PermissionType.GetHashCode();
                return hashCode;
            }
        }
    }
}
