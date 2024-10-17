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
    /// eip字段数据结构说明
    /// </summary>
    public class Eip 
    {
        /// <summary>
        /// 弹性公网IP地址类型。类型枚举值：5_bgp、5_sbgp详情请参见《虚拟私有云API参考》申请弹性公网IP章节的publicip字段说明。
        /// </summary>
        /// <value>弹性公网IP地址类型。类型枚举值：5_bgp、5_sbgp详情请参见《虚拟私有云API参考》申请弹性公网IP章节的publicip字段说明。</value>
        [JsonConverter(typeof(EnumClassConverter<IptypeEnum>))]
        public class IptypeEnum
        {
            /// <summary>
            /// Enum _5_BGP for value: 5_bgp
            /// </summary>
            public static readonly IptypeEnum _5_BGP = new IptypeEnum("5_bgp");

            /// <summary>
            /// Enum _5_SBGP for value: 5_sbgp
            /// </summary>
            public static readonly IptypeEnum _5_SBGP = new IptypeEnum("5_sbgp");

            private static readonly Dictionary<string, IptypeEnum> StaticFields =
            new Dictionary<string, IptypeEnum>()
            {
                { "5_bgp", _5_BGP },
                { "5_sbgp", _5_SBGP },
            };

            private string _value;

            public IptypeEnum()
            {

            }

            public IptypeEnum(string value)
            {
                _value = value;
            }

            public static IptypeEnum FromValue(string value)
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

                if (this.Equals(obj as IptypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IptypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(IptypeEnum a, IptypeEnum b)
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

            public static bool operator !=(IptypeEnum a, IptypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 弹性公网IP地址类型。类型枚举值：5_bgp、5_sbgp详情请参见《虚拟私有云API参考》申请弹性公网IP章节的publicip字段说明。
        /// </summary>
        [JsonProperty("iptype", NullValueHandling = NullValueHandling.Ignore)]
        public IptypeEnum Iptype { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public BandWidth Bandwidth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extendparam", NullValueHandling = NullValueHandling.Ignore)]
        public ExtendParamEip Extendparam { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Eip {\n");
            sb.Append("  iptype: ").Append(Iptype).Append("\n");
            sb.Append("  bandwidth: ").Append(Bandwidth).Append("\n");
            sb.Append("  extendparam: ").Append(Extendparam).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Eip);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Eip input)
        {
            if (input == null) return false;
            if (this.Iptype != input.Iptype) return false;
            if (this.Bandwidth != input.Bandwidth || (this.Bandwidth != null && !this.Bandwidth.Equals(input.Bandwidth))) return false;
            if (this.Extendparam != input.Extendparam || (this.Extendparam != null && !this.Extendparam.Equals(input.Extendparam))) return false;

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
                hashCode = hashCode * 59 + this.Iptype.GetHashCode();
                if (this.Bandwidth != null) hashCode = hashCode * 59 + this.Bandwidth.GetHashCode();
                if (this.Extendparam != null) hashCode = hashCode * 59 + this.Extendparam.GetHashCode();
                return hashCode;
            }
        }
    }
}
