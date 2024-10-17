using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V1.Model
{
    /// <summary>
    /// 黑白名单请求体
    /// </summary>
    public class BlackWhiteIpRequestBody 
    {
        /// <summary>
        /// 类型。white：白名单，black：黑名单
        /// </summary>
        /// <value>类型。white：白名单，black：黑名单</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum WHITE for value: white
            /// </summary>
            public static readonly TypeEnum WHITE = new TypeEnum("white");

            /// <summary>
            /// Enum BLACK for value: black
            /// </summary>
            public static readonly TypeEnum BLACK = new TypeEnum("black");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "white", WHITE },
                { "black", BLACK },
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
        /// 类型。white：白名单，black：黑名单
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// ip列表
        /// </summary>
        [JsonProperty("ip_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IpList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BlackWhiteIpRequestBody {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  ipList: ").Append(IpList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BlackWhiteIpRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BlackWhiteIpRequestBody input)
        {
            if (input == null) return false;
            if (this.Type != input.Type) return false;
            if (this.IpList != input.IpList || (this.IpList != null && input.IpList != null && !this.IpList.SequenceEqual(input.IpList))) return false;

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
                if (this.IpList != null) hashCode = hashCode * 59 + this.IpList.GetHashCode();
                return hashCode;
            }
        }
    }
}
