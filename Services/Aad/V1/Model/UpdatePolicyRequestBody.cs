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
    /// 更新策略的请求体
    /// </summary>
    public class UpdatePolicyRequestBody 
    {
        /// <summary>
        /// udp协议设置。block：封禁，unblock：不封禁，limiting：限速
        /// </summary>
        /// <value>udp协议设置。block：封禁，unblock：不封禁，limiting：限速</value>
        [JsonConverter(typeof(EnumClassConverter<UdpEnum>))]
        public class UdpEnum
        {
            /// <summary>
            /// Enum BLOCK for value: block
            /// </summary>
            public static readonly UdpEnum BLOCK = new UdpEnum("block");

            /// <summary>
            /// Enum UNBLOCK for value: unblock
            /// </summary>
            public static readonly UdpEnum UNBLOCK = new UdpEnum("unblock");

            /// <summary>
            /// Enum LIMITING for value: limiting
            /// </summary>
            public static readonly UdpEnum LIMITING = new UdpEnum("limiting");

            private static readonly Dictionary<string, UdpEnum> StaticFields =
            new Dictionary<string, UdpEnum>()
            {
                { "block", BLOCK },
                { "unblock", UNBLOCK },
                { "limiting", LIMITING },
            };

            private string _value;

            public UdpEnum()
            {

            }

            public UdpEnum(string value)
            {
                _value = value;
            }

            public static UdpEnum FromValue(string value)
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

                if (this.Equals(obj as UdpEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(UdpEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(UdpEnum a, UdpEnum b)
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

            public static bool operator !=(UdpEnum a, UdpEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// tcp协议设置。block：封禁，unblock：不封禁，limiting：限速
        /// </summary>
        /// <value>tcp协议设置。block：封禁，unblock：不封禁，limiting：限速</value>
        [JsonConverter(typeof(EnumClassConverter<TcpEnum>))]
        public class TcpEnum
        {
            /// <summary>
            /// Enum BLOCK for value: block
            /// </summary>
            public static readonly TcpEnum BLOCK = new TcpEnum("block");

            /// <summary>
            /// Enum UNBLOCK for value: unblock
            /// </summary>
            public static readonly TcpEnum UNBLOCK = new TcpEnum("unblock");

            /// <summary>
            /// Enum LIMITING for value: limiting
            /// </summary>
            public static readonly TcpEnum LIMITING = new TcpEnum("limiting");

            private static readonly Dictionary<string, TcpEnum> StaticFields =
            new Dictionary<string, TcpEnum>()
            {
                { "block", BLOCK },
                { "unblock", UNBLOCK },
                { "limiting", LIMITING },
            };

            private string _value;

            public TcpEnum()
            {

            }

            public TcpEnum(string value)
            {
                _value = value;
            }

            public static TcpEnum FromValue(string value)
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

                if (this.Equals(obj as TcpEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TcpEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TcpEnum a, TcpEnum b)
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

            public static bool operator !=(TcpEnum a, TcpEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// icmp协议设置。block：封禁，unblock：不封禁，limiting：限速
        /// </summary>
        /// <value>icmp协议设置。block：封禁，unblock：不封禁，limiting：限速</value>
        [JsonConverter(typeof(EnumClassConverter<IcmpEnum>))]
        public class IcmpEnum
        {
            /// <summary>
            /// Enum BLOCK for value: block
            /// </summary>
            public static readonly IcmpEnum BLOCK = new IcmpEnum("block");

            /// <summary>
            /// Enum UNBLOCK for value: unblock
            /// </summary>
            public static readonly IcmpEnum UNBLOCK = new IcmpEnum("unblock");

            /// <summary>
            /// Enum LIMITING for value: limiting
            /// </summary>
            public static readonly IcmpEnum LIMITING = new IcmpEnum("limiting");

            private static readonly Dictionary<string, IcmpEnum> StaticFields =
            new Dictionary<string, IcmpEnum>()
            {
                { "block", BLOCK },
                { "unblock", UNBLOCK },
                { "limiting", LIMITING },
            };

            private string _value;

            public IcmpEnum()
            {

            }

            public IcmpEnum(string value)
            {
                _value = value;
            }

            public static IcmpEnum FromValue(string value)
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

                if (this.Equals(obj as IcmpEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IcmpEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(IcmpEnum a, IcmpEnum b)
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

            public static bool operator !=(IcmpEnum a, IcmpEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// other协议设置。block：封禁，unblock：不封禁，limiting：限速
        /// </summary>
        /// <value>other协议设置。block：封禁，unblock：不封禁，limiting：限速</value>
        [JsonConverter(typeof(EnumClassConverter<OtherEnum>))]
        public class OtherEnum
        {
            /// <summary>
            /// Enum BLOCK for value: block
            /// </summary>
            public static readonly OtherEnum BLOCK = new OtherEnum("block");

            /// <summary>
            /// Enum UNBLOCK for value: unblock
            /// </summary>
            public static readonly OtherEnum UNBLOCK = new OtherEnum("unblock");

            /// <summary>
            /// Enum LIMITING for value: limiting
            /// </summary>
            public static readonly OtherEnum LIMITING = new OtherEnum("limiting");

            private static readonly Dictionary<string, OtherEnum> StaticFields =
            new Dictionary<string, OtherEnum>()
            {
                { "block", BLOCK },
                { "unblock", UNBLOCK },
                { "limiting", LIMITING },
            };

            private string _value;

            public OtherEnum()
            {

            }

            public OtherEnum(string value)
            {
                _value = value;
            }

            public static OtherEnum FromValue(string value)
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

                if (this.Equals(obj as OtherEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OtherEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OtherEnum a, OtherEnum b)
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

            public static bool operator !=(OtherEnum a, OtherEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 策略名
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 清洗阈值
        /// </summary>
        [JsonProperty("threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? Threshold { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// udp协议设置。block：封禁，unblock：不封禁，limiting：限速
        /// </summary>
        [JsonProperty("udp", NullValueHandling = NullValueHandling.Ignore)]
        public UdpEnum Udp { get; set; }
        /// <summary>
        /// tcp协议设置。block：封禁，unblock：不封禁，limiting：限速
        /// </summary>
        [JsonProperty("tcp", NullValueHandling = NullValueHandling.Ignore)]
        public TcpEnum Tcp { get; set; }
        /// <summary>
        /// icmp协议设置。block：封禁，unblock：不封禁，limiting：限速
        /// </summary>
        [JsonProperty("icmp", NullValueHandling = NullValueHandling.Ignore)]
        public IcmpEnum Icmp { get; set; }
        /// <summary>
        /// other协议设置。block：封禁，unblock：不封禁，limiting：限速
        /// </summary>
        [JsonProperty("other", NullValueHandling = NullValueHandling.Ignore)]
        public OtherEnum Other { get; set; }
        /// <summary>
        /// icmp自定义限速值，icmp取值limiting情况下，如果该值为空表示不限速
        /// </summary>
        [JsonProperty("icmp_traffic_limiting", NullValueHandling = NullValueHandling.Ignore)]
        public long? IcmpTrafficLimiting { get; set; }

        /// <summary>
        /// udp自定义限速值，udp取值limiting情况下，如果该值为空表示不限速
        /// </summary>
        [JsonProperty("udp_traffic_limiting", NullValueHandling = NullValueHandling.Ignore)]
        public long? UdpTrafficLimiting { get; set; }

        /// <summary>
        /// udp分片自定义限速值，udp取值limiting情况下，如果该值为空表示不限速
        /// </summary>
        [JsonProperty("udp_fragment_rate_limiting", NullValueHandling = NullValueHandling.Ignore)]
        public long? UdpFragmentRateLimiting { get; set; }

        /// <summary>
        /// other自定义限速值，other取值limiting情况下，如果该值为空表示不限速
        /// </summary>
        [JsonProperty("other_traffic_limiting", NullValueHandling = NullValueHandling.Ignore)]
        public long? OtherTrafficLimiting { get; set; }

        /// <summary>
        /// tcp自定义限速值，tcp取值limiting情况下，如果该值为空表示不限速
        /// </summary>
        [JsonProperty("tcp_traffic_limiting", NullValueHandling = NullValueHandling.Ignore)]
        public long? TcpTrafficLimiting { get; set; }

        /// <summary>
        /// tcp分片自定义限速值，tcp取值limiting情况下，如果该值为空表示不限速
        /// </summary>
        [JsonProperty("tcp_fragment_rate_limiting", NullValueHandling = NullValueHandling.Ignore)]
        public long? TcpFragmentRateLimiting { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePolicyRequestBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  threshold: ").Append(Threshold).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  udp: ").Append(Udp).Append("\n");
            sb.Append("  tcp: ").Append(Tcp).Append("\n");
            sb.Append("  icmp: ").Append(Icmp).Append("\n");
            sb.Append("  other: ").Append(Other).Append("\n");
            sb.Append("  icmpTrafficLimiting: ").Append(IcmpTrafficLimiting).Append("\n");
            sb.Append("  udpTrafficLimiting: ").Append(UdpTrafficLimiting).Append("\n");
            sb.Append("  udpFragmentRateLimiting: ").Append(UdpFragmentRateLimiting).Append("\n");
            sb.Append("  otherTrafficLimiting: ").Append(OtherTrafficLimiting).Append("\n");
            sb.Append("  tcpTrafficLimiting: ").Append(TcpTrafficLimiting).Append("\n");
            sb.Append("  tcpFragmentRateLimiting: ").Append(TcpFragmentRateLimiting).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdatePolicyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdatePolicyRequestBody input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Threshold != input.Threshold || (this.Threshold != null && !this.Threshold.Equals(input.Threshold))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Udp != input.Udp) return false;
            if (this.Tcp != input.Tcp) return false;
            if (this.Icmp != input.Icmp) return false;
            if (this.Other != input.Other) return false;
            if (this.IcmpTrafficLimiting != input.IcmpTrafficLimiting || (this.IcmpTrafficLimiting != null && !this.IcmpTrafficLimiting.Equals(input.IcmpTrafficLimiting))) return false;
            if (this.UdpTrafficLimiting != input.UdpTrafficLimiting || (this.UdpTrafficLimiting != null && !this.UdpTrafficLimiting.Equals(input.UdpTrafficLimiting))) return false;
            if (this.UdpFragmentRateLimiting != input.UdpFragmentRateLimiting || (this.UdpFragmentRateLimiting != null && !this.UdpFragmentRateLimiting.Equals(input.UdpFragmentRateLimiting))) return false;
            if (this.OtherTrafficLimiting != input.OtherTrafficLimiting || (this.OtherTrafficLimiting != null && !this.OtherTrafficLimiting.Equals(input.OtherTrafficLimiting))) return false;
            if (this.TcpTrafficLimiting != input.TcpTrafficLimiting || (this.TcpTrafficLimiting != null && !this.TcpTrafficLimiting.Equals(input.TcpTrafficLimiting))) return false;
            if (this.TcpFragmentRateLimiting != input.TcpFragmentRateLimiting || (this.TcpFragmentRateLimiting != null && !this.TcpFragmentRateLimiting.Equals(input.TcpFragmentRateLimiting))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Threshold != null) hashCode = hashCode * 59 + this.Threshold.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.Udp.GetHashCode();
                hashCode = hashCode * 59 + this.Tcp.GetHashCode();
                hashCode = hashCode * 59 + this.Icmp.GetHashCode();
                hashCode = hashCode * 59 + this.Other.GetHashCode();
                if (this.IcmpTrafficLimiting != null) hashCode = hashCode * 59 + this.IcmpTrafficLimiting.GetHashCode();
                if (this.UdpTrafficLimiting != null) hashCode = hashCode * 59 + this.UdpTrafficLimiting.GetHashCode();
                if (this.UdpFragmentRateLimiting != null) hashCode = hashCode * 59 + this.UdpFragmentRateLimiting.GetHashCode();
                if (this.OtherTrafficLimiting != null) hashCode = hashCode * 59 + this.OtherTrafficLimiting.GetHashCode();
                if (this.TcpTrafficLimiting != null) hashCode = hashCode * 59 + this.TcpTrafficLimiting.GetHashCode();
                if (this.TcpFragmentRateLimiting != null) hashCode = hashCode * 59 + this.TcpFragmentRateLimiting.GetHashCode();
                return hashCode;
            }
        }
    }
}
