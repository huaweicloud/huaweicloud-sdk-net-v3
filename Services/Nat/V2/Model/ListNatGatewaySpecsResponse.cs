using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Nat.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListNatGatewaySpecsResponse : SdkResponse
    {
        /// <summary>
        /// Defines specs
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<SpecsEnum>))]
        public class SpecsEnum
        {
            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            public static readonly SpecsEnum _1 = new SpecsEnum("1");

            /// <summary>
            /// Enum _2 for value: 2
            /// </summary>
            public static readonly SpecsEnum _2 = new SpecsEnum("2");

            /// <summary>
            /// Enum _3 for value: 3
            /// </summary>
            public static readonly SpecsEnum _3 = new SpecsEnum("3");

            /// <summary>
            /// Enum _4 for value: 4
            /// </summary>
            public static readonly SpecsEnum _4 = new SpecsEnum("4");

            /// <summary>
            /// Enum _5 for value: 5
            /// </summary>
            public static readonly SpecsEnum _5 = new SpecsEnum("5");

            private static readonly Dictionary<string, SpecsEnum> StaticFields =
            new Dictionary<string, SpecsEnum>()
            {
                { "1", _1 },
                { "2", _2 },
                { "3", _3 },
                { "4", _4 },
                { "5", _5 },
            };

            private string _value;

            public SpecsEnum()
            {

            }

            public SpecsEnum(string value)
            {
                _value = value;
            }

            public static SpecsEnum FromValue(string value)
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

                if (this.Equals(obj as SpecsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SpecsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SpecsEnum a, SpecsEnum b)
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

            public static bool operator !=(SpecsEnum a, SpecsEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// 可创建的NAT网关实例列表 取值范围： - 1：小型，SNAT最大连接数10000 - 2：中型，SNAT最大连接数50000 - 3：大型，SNAT最大连接数200000 - 4：超大型，SNAT最大连接数1000000 - 5：企业型，SNAT最大连接数10000000 
        /// </summary>
        [JsonProperty("specs", NullValueHandling = NullValueHandling.Ignore)]
        public List<SpecsEnum> Specs { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListNatGatewaySpecsResponse {\n");
            sb.Append("  specs: ").Append(Specs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListNatGatewaySpecsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListNatGatewaySpecsResponse input)
        {
            if (input == null) return false;
            if (this.Specs != input.Specs || (this.Specs != null && input.Specs != null && !this.Specs.SequenceEqual(input.Specs))) return false;

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
                hashCode = hashCode * 59 + this.Specs.GetHashCode();
                return hashCode;
            }
        }
    }
}
