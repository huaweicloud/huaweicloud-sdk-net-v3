using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// eip信息
    /// </summary>
    public class EipResult 
    {
        /// <summary>
        /// IP地址类型。
        /// </summary>
        /// <value>IP地址类型。</value>
        [JsonConverter(typeof(EnumClassConverter<IpTypeEnum>))]
        public class IpTypeEnum
        {
            /// <summary>
            /// Enum _5_BGP for value: 5_bgp
            /// </summary>
            public static readonly IpTypeEnum _5_BGP = new IpTypeEnum("5_bgp");

            /// <summary>
            /// Enum _5_SBGP for value: 5_sbgp
            /// </summary>
            public static readonly IpTypeEnum _5_SBGP = new IpTypeEnum("5_sbgp");

            /// <summary>
            /// Enum _5_TELCOM for value: 5_telcom
            /// </summary>
            public static readonly IpTypeEnum _5_TELCOM = new IpTypeEnum("5_telcom");

            /// <summary>
            /// Enum _5_UNION for value: 5_union
            /// </summary>
            public static readonly IpTypeEnum _5_UNION = new IpTypeEnum("5_union");

            private static readonly Dictionary<string, IpTypeEnum> StaticFields =
            new Dictionary<string, IpTypeEnum>()
            {
                { "5_bgp", _5_BGP },
                { "5_sbgp", _5_SBGP },
                { "5_telcom", _5_TELCOM },
                { "5_union", _5_UNION },
            };

            private string _value;

            public IpTypeEnum()
            {

            }

            public IpTypeEnum(string value)
            {
                _value = value;
            }

            public static IpTypeEnum FromValue(string value)
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

                if (this.Equals(obj as IpTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IpTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(IpTypeEnum a, IpTypeEnum b)
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

            public static bool operator !=(IpTypeEnum a, IpTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// IP地址类型。
        /// </summary>
        [JsonProperty("ip_type", NullValueHandling = NullValueHandling.Ignore)]
        public IpTypeEnum IpType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public BandwidthResult Bandwidth { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EipResult {\n");
            sb.Append("  ipType: ").Append(IpType).Append("\n");
            sb.Append("  bandwidth: ").Append(Bandwidth).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EipResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EipResult input)
        {
            if (input == null) return false;
            if (this.IpType != input.IpType) return false;
            if (this.Bandwidth != input.Bandwidth || (this.Bandwidth != null && !this.Bandwidth.Equals(input.Bandwidth))) return false;

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
                hashCode = hashCode * 59 + this.IpType.GetHashCode();
                if (this.Bandwidth != null) hashCode = hashCode * 59 + this.Bandwidth.GetHashCode();
                return hashCode;
            }
        }
    }
}
