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
    /// This is a auto update request Object
    /// </summary>
    public class UpdateUserDetailReq 
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
        /// DDM实例帐号的基础权限，默认值为原DDM帐号权限。  取值为：CREATE、DROP、ALTER、INDEX、INSERT、DELETE、UPDATE、SELECT
        /// </summary>
        [JsonProperty("base_authority", NullValueHandling = NullValueHandling.Ignore)]
        public List<BaseAuthorityEnum> BaseAuthority { get; set; }
        /// <summary>
        /// DDM实例帐号的描述信息，长度不能超过256个字符。  默认值为空。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// DDM实例帐号相关信息的集合。
        /// </summary>
        [JsonProperty("databases", NullValueHandling = NullValueHandling.Ignore)]
        public List<UpdateUsersDatabases> Databases { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateUserDetailReq {\n");
            sb.Append("  baseAuthority: ").Append(BaseAuthority).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  databases: ").Append(Databases).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateUserDetailReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateUserDetailReq input)
        {
            if (input == null) return false;
            if (this.BaseAuthority != input.BaseAuthority || (this.BaseAuthority != null && input.BaseAuthority != null && !this.BaseAuthority.SequenceEqual(input.BaseAuthority))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
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
                if (this.Databases != null) hashCode = hashCode * 59 + this.Databases.GetHashCode();
                return hashCode;
            }
        }
    }
}
