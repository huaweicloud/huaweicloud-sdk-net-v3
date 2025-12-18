using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V5.Model
{
    /// <summary>
    /// 授权项。
    /// </summary>
    public class Action 
    {
        /// <summary>
        /// 在策略中使用此授权项时授予的访问级别。
        /// </summary>
        /// <value>在策略中使用此授权项时授予的访问级别。</value>
        [JsonConverter(typeof(EnumClassConverter<AccessLevelEnum>))]
        public class AccessLevelEnum
        {
            /// <summary>
            /// Enum LIST for value: list
            /// </summary>
            public static readonly AccessLevelEnum LIST = new AccessLevelEnum("list");

            /// <summary>
            /// Enum READ for value: read
            /// </summary>
            public static readonly AccessLevelEnum READ = new AccessLevelEnum("read");

            /// <summary>
            /// Enum WRITE for value: write
            /// </summary>
            public static readonly AccessLevelEnum WRITE = new AccessLevelEnum("write");

            /// <summary>
            /// Enum PERMISSION_MANAGEMENT for value: permission_management
            /// </summary>
            public static readonly AccessLevelEnum PERMISSION_MANAGEMENT = new AccessLevelEnum("permission_management");

            /// <summary>
            /// Enum TAGGING for value: tagging
            /// </summary>
            public static readonly AccessLevelEnum TAGGING = new AccessLevelEnum("tagging");

            private static readonly Dictionary<string, AccessLevelEnum> StaticFields =
            new Dictionary<string, AccessLevelEnum>()
            {
                { "list", LIST },
                { "read", READ },
                { "write", WRITE },
                { "permission_management", PERMISSION_MANAGEMENT },
                { "tagging", TAGGING },
            };

            private string _value;

            public AccessLevelEnum()
            {

            }

            public AccessLevelEnum(string value)
            {
                _value = value;
            }

            public static AccessLevelEnum FromValue(string value)
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

                if (this.Equals(obj as AccessLevelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AccessLevelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AccessLevelEnum a, AccessLevelEnum b)
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

            public static bool operator !=(AccessLevelEnum a, AccessLevelEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 三段式的授权项名称，例如\&quot;iam:policies:createV5\&quot;。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 在策略中使用此授权项时授予的访问级别。
        /// </summary>
        [JsonProperty("access_level", NullValueHandling = NullValueHandling.Ignore)]
        public AccessLevelEnum AccessLevel { get; set; }
        /// <summary>
        /// 该授权项是否仅作为权限点，不对应任何操作。
        /// </summary>
        [JsonProperty("permission_only", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PermissionOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public Description Description { get; set; }

        /// <summary>
        /// 授权项别名列表，用以兼容授权项改名或者拆分新授权项的场景。
        /// </summary>
        [JsonProperty("aliases", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Aliases { get; set; }

        /// <summary>
        /// 与该授权项关联的资源列表，用于定义授权项的资源级权限。
        /// </summary>
        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<ActionAssociatedResource> Resources { get; set; }

        /// <summary>
        /// 该授权项支持的，且与资源无关的服务自定义条件属性以及部分全局属性。
        /// </summary>
        [JsonProperty("condition_keys", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ConditionKeys { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Action {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  accessLevel: ").Append(AccessLevel).Append("\n");
            sb.Append("  permissionOnly: ").Append(PermissionOnly).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  aliases: ").Append(Aliases).Append("\n");
            sb.Append("  resources: ").Append(Resources).Append("\n");
            sb.Append("  conditionKeys: ").Append(ConditionKeys).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Action);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Action input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.AccessLevel != input.AccessLevel) return false;
            if (this.PermissionOnly != input.PermissionOnly || (this.PermissionOnly != null && !this.PermissionOnly.Equals(input.PermissionOnly))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Aliases != input.Aliases || (this.Aliases != null && input.Aliases != null && !this.Aliases.SequenceEqual(input.Aliases))) return false;
            if (this.Resources != input.Resources || (this.Resources != null && input.Resources != null && !this.Resources.SequenceEqual(input.Resources))) return false;
            if (this.ConditionKeys != input.ConditionKeys || (this.ConditionKeys != null && input.ConditionKeys != null && !this.ConditionKeys.SequenceEqual(input.ConditionKeys))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.AccessLevel.GetHashCode();
                if (this.PermissionOnly != null) hashCode = hashCode * 59 + this.PermissionOnly.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Aliases != null) hashCode = hashCode * 59 + this.Aliases.GetHashCode();
                if (this.Resources != null) hashCode = hashCode * 59 + this.Resources.GetHashCode();
                if (this.ConditionKeys != null) hashCode = hashCode * 59 + this.ConditionKeys.GetHashCode();
                return hashCode;
            }
        }
    }
}
