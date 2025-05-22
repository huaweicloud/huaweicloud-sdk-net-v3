using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// **参数解释**： Key类型总数量。 **取值范围**： 不涉及。 
    /// </summary>
    public class KeyTypeNum 
    {
        /// <summary>
        /// **参数解释**： Key的数据类型。 **取值范围**： string list set zset hash 
        /// </summary>
        /// <value>**参数解释**： Key的数据类型。 **取值范围**： string list set zset hash </value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum STRING for value: string
            /// </summary>
            public static readonly TypeEnum STRING = new TypeEnum("string");

            /// <summary>
            /// Enum LIST for value: list
            /// </summary>
            public static readonly TypeEnum LIST = new TypeEnum("list");

            /// <summary>
            /// Enum SET for value: set
            /// </summary>
            public static readonly TypeEnum SET = new TypeEnum("set");

            /// <summary>
            /// Enum ZSET for value: zset
            /// </summary>
            public static readonly TypeEnum ZSET = new TypeEnum("zset");

            /// <summary>
            /// Enum HASH for value: hash
            /// </summary>
            public static readonly TypeEnum HASH = new TypeEnum("hash");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "string", STRING },
                { "list", LIST },
                { "set", SET },
                { "zset", ZSET },
                { "hash", HASH },
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
        /// **参数解释**： Key的数据类型。 **取值范围**： string list set zset hash 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// **参数解释**： Key类型的总数量。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("num", NullValueHandling = NullValueHandling.Ignore)]
        public int? Num { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeyTypeNum {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  num: ").Append(Num).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KeyTypeNum);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KeyTypeNum input)
        {
            if (input == null) return false;
            if (this.Type != input.Type) return false;
            if (this.Num != input.Num || (this.Num != null && !this.Num.Equals(input.Num))) return false;

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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Num != null) hashCode = hashCode * 59 + this.Num.GetHashCode();
                return hashCode;
            }
        }
    }
}
