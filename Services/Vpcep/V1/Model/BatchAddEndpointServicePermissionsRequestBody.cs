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
    /// 批量添加终端节点服务白名单列表。
    /// </summary>
    public class BatchAddEndpointServicePermissionsRequestBody 
    {
        /// <summary>
        /// 终端节点服务白名单类型。  - domainId：基于账户ID配置终端节点服务白名单。  - orgPath：基于账户所在组织路径配置终端节点服务白名单。
        /// </summary>
        /// <value>终端节点服务白名单类型。  - domainId：基于账户ID配置终端节点服务白名单。  - orgPath：基于账户所在组织路径配置终端节点服务白名单。</value>
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
        /// 终端节点服务白名单列表
        /// </summary>
        [JsonProperty("permissions", NullValueHandling = NullValueHandling.Ignore)]
        public List<EpsAddPermissionRequest> Permissions { get; set; }

        /// <summary>
        /// 终端节点服务白名单类型。  - domainId：基于账户ID配置终端节点服务白名单。  - orgPath：基于账户所在组织路径配置终端节点服务白名单。
        /// </summary>
        [JsonProperty("permission_type", NullValueHandling = NullValueHandling.Ignore)]
        public PermissionTypeEnum PermissionType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchAddEndpointServicePermissionsRequestBody {\n");
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
            return this.Equals(input as BatchAddEndpointServicePermissionsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchAddEndpointServicePermissionsRequestBody input)
        {
            if (input == null) return false;
            if (this.Permissions != input.Permissions || (this.Permissions != null && input.Permissions != null && !this.Permissions.SequenceEqual(input.Permissions))) return false;
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
                hashCode = hashCode * 59 + this.PermissionType.GetHashCode();
                return hashCode;
            }
        }
    }
}
