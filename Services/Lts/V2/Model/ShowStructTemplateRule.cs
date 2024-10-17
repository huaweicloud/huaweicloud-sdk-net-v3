using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 结构化类型。
    /// </summary>
    public class ShowStructTemplateRule 
    {
        /// <summary>
        /// 结构化类型
        /// </summary>
        /// <value>结构化类型</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum JSON for value: json
            /// </summary>
            public static readonly TypeEnum JSON = new TypeEnum("json");

            /// <summary>
            /// Enum SPLIT for value: split
            /// </summary>
            public static readonly TypeEnum SPLIT = new TypeEnum("split");

            /// <summary>
            /// Enum NGINX for value: nginx
            /// </summary>
            public static readonly TypeEnum NGINX = new TypeEnum("nginx");

            /// <summary>
            /// Enum BUILT_IN for value: built_in
            /// </summary>
            public static readonly TypeEnum BUILT_IN = new TypeEnum("built_in");

            /// <summary>
            /// Enum CUSTOM_REGEX for value: custom_regex
            /// </summary>
            public static readonly TypeEnum CUSTOM_REGEX = new TypeEnum("custom_regex");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "json", JSON },
                { "split", SPLIT },
                { "nginx", NGINX },
                { "built_in", BUILT_IN },
                { "custom_regex", CUSTOM_REGEX },
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
        /// 测试
        /// </summary>
        [JsonProperty("param", NullValueHandling = NullValueHandling.Ignore)]
        public string Param { get; set; }

        /// <summary>
        /// 结构化类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowStructTemplateRule {\n");
            sb.Append("  param: ").Append(Param).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowStructTemplateRule);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowStructTemplateRule input)
        {
            if (input == null) return false;
            if (this.Param != input.Param || (this.Param != null && !this.Param.Equals(input.Param))) return false;
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
                if (this.Param != null) hashCode = hashCode * 59 + this.Param.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
