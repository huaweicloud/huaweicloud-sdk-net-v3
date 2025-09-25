using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SetRepoRoleRequestBody 
    {
        /// <summary>
        /// 设置仓库的成员权限，取值范围：20 -&gt; 只读成员 30-&gt;普通成员，40-&gt;管理员
        /// </summary>
        /// <value>设置仓库的成员权限，取值范围：20 -&gt; 只读成员 30-&gt;普通成员，40-&gt;管理员</value>
        [JsonConverter(typeof(EnumClassConverter<RoleEnum>))]
        public class RoleEnum
        {
            /// <summary>
            /// Enum NUMBER_20 for value: 20
            /// </summary>
            public static readonly RoleEnum NUMBER_20 = new RoleEnum(20);

            /// <summary>
            /// Enum NUMBER_30 for value: 30
            /// </summary>
            public static readonly RoleEnum NUMBER_30 = new RoleEnum(30);

            /// <summary>
            /// Enum NUMBER_40 for value: 40
            /// </summary>
            public static readonly RoleEnum NUMBER_40 = new RoleEnum(40);

            private static readonly Dictionary<int?, RoleEnum> StaticFields =
            new Dictionary<int?, RoleEnum>()
            {
                { 20, NUMBER_20 },
                { 30, NUMBER_30 },
                { 40, NUMBER_40 },
            };

            private int? _value;

            public RoleEnum()
            {

            }

            public RoleEnum(int? value)
            {
                _value = value;
            }

            public static RoleEnum FromValue(int? value)
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

            public int? GetValue()
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

                if (this.Equals(obj as RoleEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RoleEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RoleEnum a, RoleEnum b)
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

            public static bool operator !=(RoleEnum a, RoleEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 设置仓库的成员权限，取值范围：20 -&gt; 只读成员 30-&gt;普通成员，40-&gt;管理员
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public RoleEnum Role { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetRepoRoleRequestBody {\n");
            sb.Append("  role: ").Append(Role).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetRepoRoleRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetRepoRoleRequestBody input)
        {
            if (input == null) return false;
            if (this.Role != input.Role) return false;

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
                hashCode = hashCode * 59 + this.Role.GetHashCode();
                return hashCode;
            }
        }
    }
}
