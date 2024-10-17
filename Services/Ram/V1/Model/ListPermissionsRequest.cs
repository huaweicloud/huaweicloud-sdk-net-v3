using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ram.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListPermissionsRequest 
    {
        /// <summary>
        /// 权限类型。RAM_MANAGED表示RAM托管的权限，CUSTOMER_MANAGED表示租户创建的自定义的权限，ALL表示所有的权限。
        /// </summary>
        /// <value>权限类型。RAM_MANAGED表示RAM托管的权限，CUSTOMER_MANAGED表示租户创建的自定义的权限，ALL表示所有的权限。</value>
        [JsonConverter(typeof(EnumClassConverter<PermissionTypeEnum>))]
        public class PermissionTypeEnum
        {
            /// <summary>
            /// Enum RAM_MANAGED for value: RAM_MANAGED
            /// </summary>
            public static readonly PermissionTypeEnum RAM_MANAGED = new PermissionTypeEnum("RAM_MANAGED");

            /// <summary>
            /// Enum CUSTOMER_MANAGED for value: CUSTOMER_MANAGED
            /// </summary>
            public static readonly PermissionTypeEnum CUSTOMER_MANAGED = new PermissionTypeEnum("CUSTOMER_MANAGED");

            /// <summary>
            /// Enum ALL for value: ALL
            /// </summary>
            public static readonly PermissionTypeEnum ALL = new PermissionTypeEnum("ALL");

            private static readonly Dictionary<string, PermissionTypeEnum> StaticFields =
            new Dictionary<string, PermissionTypeEnum>()
            {
                { "RAM_MANAGED", RAM_MANAGED },
                { "CUSTOMER_MANAGED", CUSTOMER_MANAGED },
                { "ALL", ALL },
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
        /// 分页页面的最大值。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 页面标记。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 资源类型的名称。
        /// </summary>
        [SDKProperty("resource_type", IsQuery = true)]
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 权限类型。RAM_MANAGED表示RAM托管的权限，CUSTOMER_MANAGED表示租户创建的自定义的权限，ALL表示所有的权限。
        /// </summary>
        [SDKProperty("permission_type", IsQuery = true)]
        [JsonProperty("permission_type", NullValueHandling = NullValueHandling.Ignore)]
        public PermissionTypeEnum PermissionType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPermissionsRequest {\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  permissionType: ").Append(PermissionType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPermissionsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPermissionsRequest input)
        {
            if (input == null) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
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
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                hashCode = hashCode * 59 + this.PermissionType.GetHashCode();
                return hashCode;
            }
        }
    }
}
