using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// 虚拟私有云ID字段数据结构说明
    /// </summary>
    public class Address 
    {
        /// <summary>
        /// IP地址版本。4：代表IPv4。6：代表IPv6。
        /// </summary>
        /// <value>IP地址版本。4：代表IPv4。6：代表IPv6。</value>
        [JsonConverter(typeof(EnumClassConverter<VersionEnum>))]
        public class VersionEnum
        {
            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            public static readonly VersionEnum NUMBER_4 = new VersionEnum(4);

            /// <summary>
            /// Enum NUMBER_6 for value: 6
            /// </summary>
            public static readonly VersionEnum NUMBER_6 = new VersionEnum(6);

            private static readonly Dictionary<int?, VersionEnum> StaticFields =
            new Dictionary<int?, VersionEnum>()
            {
                { 4, NUMBER_4 },
                { 6, NUMBER_6 },
            };

            private int? _value;

            public VersionEnum()
            {

            }

            public VersionEnum(int? value)
            {
                _value = value;
            }

            public static VersionEnum FromValue(int? value)
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

                if (this.Equals(obj as VersionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(VersionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(VersionEnum a, VersionEnum b)
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

            public static bool operator !=(VersionEnum a, VersionEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// IP地址类型。fixed：代表私有IP地址。floating：代表浮动IP地址。
        /// </summary>
        /// <value>IP地址类型。fixed：代表私有IP地址。floating：代表浮动IP地址。</value>
        [JsonConverter(typeof(EnumClassConverter<OSEXTIPStypeEnum>))]
        public class OSEXTIPStypeEnum
        {
            /// <summary>
            /// Enum FIXED for value: fixed
            /// </summary>
            public static readonly OSEXTIPStypeEnum FIXED = new OSEXTIPStypeEnum("fixed");

            /// <summary>
            /// Enum FLOATING for value: floating
            /// </summary>
            public static readonly OSEXTIPStypeEnum FLOATING = new OSEXTIPStypeEnum("floating");

            private static readonly Dictionary<string, OSEXTIPStypeEnum> StaticFields =
            new Dictionary<string, OSEXTIPStypeEnum>()
            {
                { "fixed", FIXED },
                { "floating", FLOATING },
            };

            private string _value;

            public OSEXTIPStypeEnum()
            {

            }

            public OSEXTIPStypeEnum(string value)
            {
                _value = value;
            }

            public static OSEXTIPStypeEnum FromValue(string value)
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

                if (this.Equals(obj as OSEXTIPStypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OSEXTIPStypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OSEXTIPStypeEnum a, OSEXTIPStypeEnum b)
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

            public static bool operator !=(OSEXTIPStypeEnum a, OSEXTIPStypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// IP地址版本。4：代表IPv4。6：代表IPv6。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public VersionEnum Version { get; set; }
        /// <summary>
        /// IP地址
        /// </summary>
        [JsonProperty("addr", NullValueHandling = NullValueHandling.Ignore)]
        public string Addr { get; set; }

        /// <summary>
        /// IP地址类型。fixed：代表私有IP地址。floating：代表浮动IP地址。
        /// </summary>
        [JsonProperty("OS-EXT-IPS:type", NullValueHandling = NullValueHandling.Ignore)]
        public OSEXTIPStypeEnum OSEXTIPStype { get; set; }
        /// <summary>
        /// MAC地址
        /// </summary>
        [JsonProperty("OS-EXT-IPS-MAC:mac_addr", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTIPSMACmacAddr { get; set; }

        /// <summary>
        /// IP地址对应的端口ID
        /// </summary>
        [JsonProperty("OS-EXT-IPS:port_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OSEXTIPSportId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Address {\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  addr: ").Append(Addr).Append("\n");
            sb.Append("  oSEXTIPStype: ").Append(OSEXTIPStype).Append("\n");
            sb.Append("  oSEXTIPSMACmacAddr: ").Append(OSEXTIPSMACmacAddr).Append("\n");
            sb.Append("  oSEXTIPSportId: ").Append(OSEXTIPSportId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Address);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Address input)
        {
            if (input == null) return false;
            if (this.Version != input.Version) return false;
            if (this.Addr != input.Addr || (this.Addr != null && !this.Addr.Equals(input.Addr))) return false;
            if (this.OSEXTIPStype != input.OSEXTIPStype) return false;
            if (this.OSEXTIPSMACmacAddr != input.OSEXTIPSMACmacAddr || (this.OSEXTIPSMACmacAddr != null && !this.OSEXTIPSMACmacAddr.Equals(input.OSEXTIPSMACmacAddr))) return false;
            if (this.OSEXTIPSportId != input.OSEXTIPSportId || (this.OSEXTIPSportId != null && !this.OSEXTIPSportId.Equals(input.OSEXTIPSportId))) return false;

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
                hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Addr != null) hashCode = hashCode * 59 + this.Addr.GetHashCode();
                hashCode = hashCode * 59 + this.OSEXTIPStype.GetHashCode();
                if (this.OSEXTIPSMACmacAddr != null) hashCode = hashCode * 59 + this.OSEXTIPSMACmacAddr.GetHashCode();
                if (this.OSEXTIPSportId != null) hashCode = hashCode * 59 + this.OSEXTIPSportId.GetHashCode();
                return hashCode;
            }
        }
    }
}
