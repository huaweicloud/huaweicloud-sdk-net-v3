using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BlackWhiteInfo 
    {
        /// <summary>
        /// **参数解释**： 协议类型 **约束限制**： 不涉及  **取值范围**： -1：ANY 1：ICMP 6：TCP 17：UDP 58：ICMPV6 132：SCTP 手动类型不为空，自动类型为空 **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： 协议类型 **约束限制**： 不涉及  **取值范围**： -1：ANY 1：ICMP 6：TCP 17：UDP 58：ICMPV6 132：SCTP 手动类型不为空，自动类型为空 **默认取值**： 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<ProtocolEnum>))]
        public class ProtocolEnum
        {
            /// <summary>
            /// Enum NUMBER_6 for value: 6
            /// </summary>
            public static readonly ProtocolEnum NUMBER_6 = new ProtocolEnum(6);

            /// <summary>
            /// Enum NUMBER_17 for value: 17
            /// </summary>
            public static readonly ProtocolEnum NUMBER_17 = new ProtocolEnum(17);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly ProtocolEnum NUMBER_1 = new ProtocolEnum(1);

            /// <summary>
            /// Enum NUMBER_58 for value: 58
            /// </summary>
            public static readonly ProtocolEnum NUMBER_58 = new ProtocolEnum(58);

            /// <summary>
            /// Enum NUMBER_MINUS_1 for value: -1
            /// </summary>
            public static readonly ProtocolEnum NUMBER_MINUS_1 = new ProtocolEnum(-1);

            /// <summary>
            /// Enum NUMBER_132 for value: 132
            /// </summary>
            public static readonly ProtocolEnum NUMBER_132 = new ProtocolEnum(132);

            private static readonly Dictionary<int?, ProtocolEnum> StaticFields =
            new Dictionary<int?, ProtocolEnum>()
            {
                { 6, NUMBER_6 },
                { 17, NUMBER_17 },
                { 1, NUMBER_1 },
                { 58, NUMBER_58 },
                { -1, NUMBER_MINUS_1 },
                { 132, NUMBER_132 },
            };

            private int? _value;

            public ProtocolEnum()
            {

            }

            public ProtocolEnum(int? value)
            {
                _value = value;
            }

            public static ProtocolEnum FromValue(int? value)
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

                if (this.Equals(obj as ProtocolEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ProtocolEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ProtocolEnum a, ProtocolEnum b)
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

            public static bool operator !=(ProtocolEnum a, ProtocolEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： IP地址 **约束限制**： 不涉及  **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// **参数解释**： IP地址类型 **约束限制**： 不涉及  **取值范围**：  0：IPV4  1：IPV6 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("address_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? AddressType { get; set; }

        /// <summary>
        /// **参数解释**： 描述 **约束限制**： 不涉及  **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 地址方向 **约束限制**： 不涉及  **取值范围**： 0：源地址 1：目的地址 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public int? Direction { get; set; }

        /// <summary>
        /// **参数解释**： 端口 **约束限制**： 不涉及  **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public string Port { get; set; }

        /// <summary>
        /// **参数解释**： 协议类型 **约束限制**： 不涉及  **取值范围**： -1：ANY 1：ICMP 6：TCP 17：UDP 58：ICMPV6 132：SCTP 手动类型不为空，自动类型为空 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public ProtocolEnum Protocol { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BlackWhiteInfo {\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  addressType: ").Append(AddressType).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  direction: ").Append(Direction).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BlackWhiteInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BlackWhiteInfo input)
        {
            if (input == null) return false;
            if (this.Address != input.Address || (this.Address != null && !this.Address.Equals(input.Address))) return false;
            if (this.AddressType != input.AddressType || (this.AddressType != null && !this.AddressType.Equals(input.AddressType))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Direction != input.Direction || (this.Direction != null && !this.Direction.Equals(input.Direction))) return false;
            if (this.Port != input.Port || (this.Port != null && !this.Port.Equals(input.Port))) return false;
            if (this.Protocol != input.Protocol) return false;

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
                if (this.Address != null) hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.AddressType != null) hashCode = hashCode * 59 + this.AddressType.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Direction != null) hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.Port != null) hashCode = hashCode * 59 + this.Port.GetHashCode();
                hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                return hashCode;
            }
        }
    }
}
