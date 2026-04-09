using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// 修改账号的请求对象
    /// </summary>
    public class UpdateUserV3RequestBody 
    {
        /// <summary>
        /// Defines baseAuthority
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<BaseAuthorityEnum>))]
        public class BaseAuthorityEnum
        {
            /// <summary>
            /// Enum CREATE for value: CREATE
            /// </summary>
            public static readonly BaseAuthorityEnum CREATE = new BaseAuthorityEnum("CREATE");

            /// <summary>
            /// Enum DROP for value: DROP
            /// </summary>
            public static readonly BaseAuthorityEnum DROP = new BaseAuthorityEnum("DROP");

            /// <summary>
            /// Enum ALTER for value: ALTER
            /// </summary>
            public static readonly BaseAuthorityEnum ALTER = new BaseAuthorityEnum("ALTER");

            /// <summary>
            /// Enum INDEX for value: INDEX
            /// </summary>
            public static readonly BaseAuthorityEnum INDEX = new BaseAuthorityEnum("INDEX");

            /// <summary>
            /// Enum INSERT for value: INSERT
            /// </summary>
            public static readonly BaseAuthorityEnum INSERT = new BaseAuthorityEnum("INSERT");

            /// <summary>
            /// Enum DELETE for value: DELETE
            /// </summary>
            public static readonly BaseAuthorityEnum DELETE = new BaseAuthorityEnum("DELETE");

            /// <summary>
            /// Enum UPDATE for value: UPDATE
            /// </summary>
            public static readonly BaseAuthorityEnum UPDATE = new BaseAuthorityEnum("UPDATE");

            /// <summary>
            /// Enum SELECT for value: SELECT
            /// </summary>
            public static readonly BaseAuthorityEnum SELECT = new BaseAuthorityEnum("SELECT");

            private static readonly Dictionary<string, BaseAuthorityEnum> StaticFields =
            new Dictionary<string, BaseAuthorityEnum>()
            {
                { "CREATE", CREATE },
                { "DROP", DROP },
                { "ALTER", ALTER },
                { "INDEX", INDEX },
                { "INSERT", INSERT },
                { "DELETE", DELETE },
                { "UPDATE", UPDATE },
                { "SELECT", SELECT },
            };

            private string _value;

            public BaseAuthorityEnum()
            {

            }

            public BaseAuthorityEnum(string value)
            {
                _value = value;
            }

            public static BaseAuthorityEnum FromValue(string value)
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

                if (this.Equals(obj as BaseAuthorityEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(BaseAuthorityEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(BaseAuthorityEnum a, BaseAuthorityEnum b)
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

            public static bool operator !=(BaseAuthorityEnum a, BaseAuthorityEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// **参数解释**：  DDM实例账号的基础权限。  **约束限制**：  无  **取值范围**：  CREATE、DROP、ALTER、INDEX、INSERT、DELETE、UPDATE、SELECT的任意集合  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("base_authority", NullValueHandling = NullValueHandling.Ignore)]
        public List<BaseAuthorityEnum> BaseAuthority { get; set; }
        /// <summary>
        /// **参数解释**：  实例账号的描述信息。  **约束限制**：  - 长度不超过256个字符。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**：  DDM实例账号的密码有效期。  **约束限制**：  不涉及。   **取值范围**：  取值范围为0-65535的整数，单位为天。  0与空表示密码永不过期。  **默认取值**：  默认值为空，永不过期。
        /// </summary>
        [JsonProperty("password_lifetime", NullValueHandling = NullValueHandling.Ignore)]
        public long? PasswordLifetime { get; set; }

        /// <summary>
        /// 关联的逻辑库的集合。 databases字段可以省略，即创建用户时可以不关联逻辑库。
        /// </summary>
        [JsonProperty("databases", NullValueHandling = NullValueHandling.Ignore)]
        public List<UpdateUserRelatedLogicDbV3> Databases { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateUserV3RequestBody {\n");
            sb.Append("  baseAuthority: ").Append(BaseAuthority).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  passwordLifetime: ").Append(PasswordLifetime).Append("\n");
            sb.Append("  databases: ").Append(Databases).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateUserV3RequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateUserV3RequestBody input)
        {
            if (input == null) return false;
            if (this.BaseAuthority != input.BaseAuthority || (this.BaseAuthority != null && input.BaseAuthority != null && !this.BaseAuthority.SequenceEqual(input.BaseAuthority))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.PasswordLifetime != input.PasswordLifetime || (this.PasswordLifetime != null && !this.PasswordLifetime.Equals(input.PasswordLifetime))) return false;
            if (this.Databases != input.Databases || (this.Databases != null && input.Databases != null && !this.Databases.SequenceEqual(input.Databases))) return false;

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
                hashCode = hashCode * 59 + this.BaseAuthority.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.PasswordLifetime != null) hashCode = hashCode * 59 + this.PasswordLifetime.GetHashCode();
                if (this.Databases != null) hashCode = hashCode * 59 + this.Databases.GetHashCode();
                return hashCode;
            }
        }
    }
}
