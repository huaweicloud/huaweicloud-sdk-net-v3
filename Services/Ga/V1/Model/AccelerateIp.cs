using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ga.V1.Model
{
    /// <summary>
    /// accelerate Ip
    /// </summary>
    public class AccelerateIp 
    {
        /// <summary>
        /// IP地址类型。 取值范围：IPV4、IPV6
        /// </summary>
        /// <value>IP地址类型。 取值范围：IPV4、IPV6</value>
        [JsonConverter(typeof(EnumClassConverter<IpTypeEnum>))]
        public class IpTypeEnum
        {
            /// <summary>
            /// Enum IPV4 for value: IPV4
            /// </summary>
            public static readonly IpTypeEnum IPV4 = new IpTypeEnum("IPV4");

            /// <summary>
            /// Enum IPV6 for value: IPV6
            /// </summary>
            public static readonly IpTypeEnum IPV6 = new IpTypeEnum("IPV6");

            private static readonly Dictionary<string, IpTypeEnum> StaticFields =
            new Dictionary<string, IpTypeEnum>()
            {
                { "IPV4", IPV4 },
                { "IPV6", IPV6 },
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
        /// IP地址类型。 取值范围：IPV4、IPV6
        /// </summary>
        [JsonProperty("ip_type", NullValueHandling = NullValueHandling.Ignore)]
        public IpTypeEnum IpType { get; set; }
        /// <summary>
        /// IP地址。
        /// </summary>
        [JsonProperty("ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string IpAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("area", NullValueHandling = NullValueHandling.Ignore)]
        public Area? Area { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccelerateIp {\n");
            sb.Append("  ipType: ").Append(IpType).Append("\n");
            sb.Append("  ipAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  area: ").Append(Area).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccelerateIp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AccelerateIp input)
        {
            if (input == null) return false;
            if (this.IpType != input.IpType) return false;
            if (this.IpAddress != input.IpAddress || (this.IpAddress != null && !this.IpAddress.Equals(input.IpAddress))) return false;
            if (this.Area != input.Area || (this.Area != null && !this.Area.Equals(input.Area))) return false;

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
                if (this.IpAddress != null) hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.Area != null) hashCode = hashCode * 59 + this.Area.GetHashCode();
                return hashCode;
            }
        }
    }
}
