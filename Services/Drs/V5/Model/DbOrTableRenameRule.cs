using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 库表更名规则  可以在名称添加前后缀， 填写前缀名，会给库表名称前面添加对前缀名，填写后缀名，会给库表名称后面添加对后缀名； 当前缀名和后缀名都写时，会给库表名称前后面添加对字符；
    /// </summary>
    public class DbOrTableRenameRule 
    {
        /// <summary>
        /// 库表映射类型 prefixAndSuffix:前缀、后缀或者前后缀
        /// </summary>
        /// <value>库表映射类型 prefixAndSuffix:前缀、后缀或者前后缀</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum PREFIXANDSUFFIX for value: prefixAndSuffix
            /// </summary>
            public static readonly TypeEnum PREFIXANDSUFFIX = new TypeEnum("prefixAndSuffix");

            /// <summary>
            /// Enum MANYTOONE for value: manyToOne
            /// </summary>
            public static readonly TypeEnum MANYTOONE = new TypeEnum("manyToOne");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "prefixAndSuffix", PREFIXANDSUFFIX },
                { "manyToOne", MANYTOONE },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 前缀名称 当type为prefixAndSuffix， 填写prefix_name，库表名称仅增加前缀，若同时也填写suffix_name, 库表名称增加前后缀
        /// </summary>
        [JsonProperty("prefix_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PrefixName { get; set; }

        /// <summary>
        /// 后缀名称 当type为prefixAndSuffix， 填写suffix_name，库表名称仅增加后缀，若同时也填写prefix_name, 库表名称同时增加前后缀
        /// </summary>
        [JsonProperty("suffix_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SuffixName { get; set; }

        /// <summary>
        /// 库表映射类型 prefixAndSuffix:前缀、后缀或者前后缀
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DbOrTableRenameRule {\n");
            sb.Append("  prefixName: ").Append(PrefixName).Append("\n");
            sb.Append("  suffixName: ").Append(SuffixName).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DbOrTableRenameRule);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DbOrTableRenameRule input)
        {
            if (input == null) return false;
            if (this.PrefixName != input.PrefixName || (this.PrefixName != null && !this.PrefixName.Equals(input.PrefixName))) return false;
            if (this.SuffixName != input.SuffixName || (this.SuffixName != null && !this.SuffixName.Equals(input.SuffixName))) return false;
            if (this.Type != input.Type) return false;

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
                if (this.PrefixName != null) hashCode = hashCode * 59 + this.PrefixName.GetHashCode();
                if (this.SuffixName != null) hashCode = hashCode * 59 + this.SuffixName.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
