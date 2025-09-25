using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListGroupPermissionResourcesRequest 
    {
        /// <summary>
        /// **参数解释：** 创建资源类型。 **约束限制：** - group 代码组。 - project  项目。 - all 代码组和项目
        /// </summary>
        /// <value>**参数解释：** 创建资源类型。 **约束限制：** - group 代码组。 - project  项目。 - all 代码组和项目</value>
        [JsonConverter(typeof(EnumClassConverter<ScopeEnum>))]
        public class ScopeEnum
        {
            /// <summary>
            /// Enum GROUP for value: group
            /// </summary>
            public static readonly ScopeEnum GROUP = new ScopeEnum("group");

            /// <summary>
            /// Enum PROJECT for value: project
            /// </summary>
            public static readonly ScopeEnum PROJECT = new ScopeEnum("project");

            /// <summary>
            /// Enum ALL for value: all
            /// </summary>
            public static readonly ScopeEnum ALL = new ScopeEnum("all");

            private static readonly Dictionary<string, ScopeEnum> StaticFields =
            new Dictionary<string, ScopeEnum>()
            {
                { "group", GROUP },
                { "project", PROJECT },
                { "all", ALL },
            };

            private string _value;

            public ScopeEnum()
            {

            }

            public ScopeEnum(string value)
            {
                _value = value;
            }

            public static ScopeEnum FromValue(string value)
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

                if (this.Equals(obj as ScopeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ScopeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ScopeEnum a, ScopeEnum b)
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

            public static bool operator !=(ScopeEnum a, ScopeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** 创建资源类型。 **约束限制：** - group 代码组。 - project  项目。 - all 代码组和项目
        /// </summary>
        [SDKProperty("scope", IsQuery = true)]
        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public ScopeEnum Scope { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListGroupPermissionResourcesRequest {\n");
            sb.Append("  scope: ").Append(Scope).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListGroupPermissionResourcesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListGroupPermissionResourcesRequest input)
        {
            if (input == null) return false;
            if (this.Scope != input.Scope) return false;

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
                hashCode = hashCode * 59 + this.Scope.GetHashCode();
                return hashCode;
            }
        }
    }
}
