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
    /// **参数解释**： 规则体 **约束限制**： 不涉及
    /// </summary>
    public class AddRuleAclDtoRules 
    {
        /// <summary>
        /// **参数解释**： IP地址的互联网协议类型，用于指定IP地址的互联网协议，由客户指定 **约束限制**： 不涉及 **取值范围**： 0表示IPv4，1表示IPv6 **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： IP地址的互联网协议类型，用于指定IP地址的互联网协议，由客户指定 **约束限制**： 不涉及 **取值范围**： 0表示IPv4，1表示IPv6 **默认取值**： 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<AddressTypeEnum>))]
        public class AddressTypeEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly AddressTypeEnum NUMBER_0 = new AddressTypeEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly AddressTypeEnum NUMBER_1 = new AddressTypeEnum(1);

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            public static readonly AddressTypeEnum NUMBER_2 = new AddressTypeEnum(2);

            private static readonly Dictionary<int?, AddressTypeEnum> StaticFields =
            new Dictionary<int?, AddressTypeEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
                { 2, NUMBER_2 },
            };

            private int? _value;

            public AddressTypeEnum()
            {

            }

            public AddressTypeEnum(int? value)
            {
                _value = value;
            }

            public static AddressTypeEnum FromValue(int? value)
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

                if (this.Equals(obj as AddressTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AddressTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AddressTypeEnum a, AddressTypeEnum b)
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

            public static bool operator !=(AddressTypeEnum a, AddressTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 规则启用状态，用于区分规则是否启用 **约束限制**： 仅能使用数字0和1 **取值范围**： 0表示启用，1表示禁用 **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： 规则启用状态，用于区分规则是否启用 **约束限制**： 仅能使用数字0和1 **取值范围**： 0表示启用，1表示禁用 **默认取值**： 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly StatusEnum NUMBER_0 = new StatusEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly StatusEnum NUMBER_1 = new StatusEnum(1);

            private static readonly Dictionary<int?, StatusEnum> StaticFields =
            new Dictionary<int?, StatusEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
            };

            private int? _value;

            public StatusEnum()
            {

            }

            public StatusEnum(int? value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(int? value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 用于表示是否支持长连接。 **约束限制**： 不涉及 **取值范围**： 0表示不支持，1表示支持 **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： 用于表示是否支持长连接。 **约束限制**： 不涉及 **取值范围**： 0表示不支持，1表示支持 **默认取值**： 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<LongConnectEnableEnum>))]
        public class LongConnectEnableEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly LongConnectEnableEnum NUMBER_0 = new LongConnectEnableEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly LongConnectEnableEnum NUMBER_1 = new LongConnectEnableEnum(1);

            private static readonly Dictionary<int?, LongConnectEnableEnum> StaticFields =
            new Dictionary<int?, LongConnectEnableEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
            };

            private int? _value;

            public LongConnectEnableEnum()
            {

            }

            public LongConnectEnableEnum(int? value)
            {
                _value = value;
            }

            public static LongConnectEnableEnum FromValue(int? value)
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

                if (this.Equals(obj as LongConnectEnableEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LongConnectEnableEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LongConnectEnableEnum a, LongConnectEnableEnum b)
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

            public static bool operator !=(LongConnectEnableEnum a, LongConnectEnableEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 规则方向，用于指定规则是从云上至云下，还是云下至云上 **约束限制**： 当规则type&#x3D;0（互联网规则）或者type&#x3D; 2（NAT规则）时方向值必填 **取值范围**： 0表示外到内（云下到云上），1表示内到外（云上到云下）， **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： 规则方向，用于指定规则是从云上至云下，还是云下至云上 **约束限制**： 当规则type&#x3D;0（互联网规则）或者type&#x3D; 2（NAT规则）时方向值必填 **取值范围**： 0表示外到内（云下到云上），1表示内到外（云上到云下）， **默认取值**： 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<DirectionEnum>))]
        public class DirectionEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly DirectionEnum NUMBER_0 = new DirectionEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly DirectionEnum NUMBER_1 = new DirectionEnum(1);

            private static readonly Dictionary<int?, DirectionEnum> StaticFields =
            new Dictionary<int?, DirectionEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
            };

            private int? _value;

            public DirectionEnum()
            {

            }

            public DirectionEnum(int? value)
            {
                _value = value;
            }

            public static DirectionEnum FromValue(int? value)
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

                if (this.Equals(obj as DirectionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DirectionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DirectionEnum a, DirectionEnum b)
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

            public static bool operator !=(DirectionEnum a, DirectionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 规则名称，由用户定义，用于标识规则 **约束限制**： 字符串长度为0到255 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        public OrderRuleAclDto Sequence { get; set; }

        /// <summary>
        /// **参数解释**： IP地址的互联网协议类型，用于指定IP地址的互联网协议，由客户指定 **约束限制**： 不涉及 **取值范围**： 0表示IPv4，1表示IPv6 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("address_type", NullValueHandling = NullValueHandling.Ignore)]
        public AddressTypeEnum AddressType { get; set; }
        /// <summary>
        /// **参数解释**： 规则动作类型，用于区分规则对流量的动作 **约束限制**： 仅能使用数字0和1 **取值范围**： 0表示允许通行（permit），1表示拒绝通行（deny） **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("action_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ActionType { get; set; }

        /// <summary>
        /// **参数解释**： 规则启用状态，用于区分规则是否启用 **约束限制**： 仅能使用数字0和1 **取值范围**： 0表示启用，1表示禁用 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// **参数解释**： 规则应用协议列表 **约束限制**： 不涉及 **取值范围**： 规则应用类型包括：“HTTP”，\&quot;HTTPS\&quot;，\&quot;TLS1\&quot;，“DNS”，“SSH”，“MYSQL”，“SMTP”，“RDP”，“RDPS”，“VNC”，“POP3”，“IMAP4”，“SMTPS”，“POP3S”，“FTPS”，“ANY”，“BGP”等。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("applications", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Applications { get; set; }

        /// <summary>
        /// **参数解释**： 长连接时长（s），用于表示流量产生会话保持的最大时长。 **约束限制**： 仅能为数字 **取值范围**： 1-86400000。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("long_connect_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? LongConnectTime { get; set; }

        /// <summary>
        /// **参数解释**： 长连接时长对应小时数（h）。 **约束限制**： 仅能为数字 **取值范围**： 0-24000。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("long_connect_time_hour", NullValueHandling = NullValueHandling.Ignore)]
        public long? LongConnectTimeHour { get; set; }

        /// <summary>
        /// **参数解释**： 长连接时长对应分钟数（min）。 **约束限制**： 仅能为数字 **取值范围**： 0-60。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("long_connect_time_minute", NullValueHandling = NullValueHandling.Ignore)]
        public long? LongConnectTimeMinute { get; set; }

        /// <summary>
        /// **参数解释**： 长连接时长对应秒数（s）。 **约束限制**： 仅能为数字 **取值范围**： 0-60。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("long_connect_time_second", NullValueHandling = NullValueHandling.Ignore)]
        public long? LongConnectTimeSecond { get; set; }

        /// <summary>
        /// **参数解释**： 用于表示是否支持长连接。 **约束限制**： 不涉及 **取值范围**： 0表示不支持，1表示支持 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("long_connect_enable", NullValueHandling = NullValueHandling.Ignore)]
        public LongConnectEnableEnum LongConnectEnable { get; set; }
        /// <summary>
        /// **参数解释**： 规则描述，用于描述规则的用途。 **约束限制**： 不涉及 **取值范围**： 长度在0-255之间 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 规则方向，用于指定规则是从云上至云下，还是云下至云上 **约束限制**： 当规则type&#x3D;0（互联网规则）或者type&#x3D; 2（NAT规则）时方向值必填 **取值范围**： 0表示外到内（云下到云上），1表示内到外（云上到云下）， **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public DirectionEnum Direction { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public RuleAddressDtoForRequest Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("destination", NullValueHandling = NullValueHandling.Ignore)]
        public RuleAddressDtoForRequest Destination { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("service", NullValueHandling = NullValueHandling.Ignore)]
        public RuleServiceDto Service { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public TagsVO Tag { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddRuleAclDtoRules {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  sequence: ").Append(Sequence).Append("\n");
            sb.Append("  addressType: ").Append(AddressType).Append("\n");
            sb.Append("  actionType: ").Append(ActionType).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  applications: ").Append(Applications).Append("\n");
            sb.Append("  longConnectTime: ").Append(LongConnectTime).Append("\n");
            sb.Append("  longConnectTimeHour: ").Append(LongConnectTimeHour).Append("\n");
            sb.Append("  longConnectTimeMinute: ").Append(LongConnectTimeMinute).Append("\n");
            sb.Append("  longConnectTimeSecond: ").Append(LongConnectTimeSecond).Append("\n");
            sb.Append("  longConnectEnable: ").Append(LongConnectEnable).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  direction: ").Append(Direction).Append("\n");
            sb.Append("  source: ").Append(Source).Append("\n");
            sb.Append("  destination: ").Append(Destination).Append("\n");
            sb.Append("  service: ").Append(Service).Append("\n");
            sb.Append("  tag: ").Append(Tag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddRuleAclDtoRules);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddRuleAclDtoRules input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Sequence != input.Sequence || (this.Sequence != null && !this.Sequence.Equals(input.Sequence))) return false;
            if (this.AddressType != input.AddressType) return false;
            if (this.ActionType != input.ActionType || (this.ActionType != null && !this.ActionType.Equals(input.ActionType))) return false;
            if (this.Status != input.Status) return false;
            if (this.Applications != input.Applications || (this.Applications != null && input.Applications != null && !this.Applications.SequenceEqual(input.Applications))) return false;
            if (this.LongConnectTime != input.LongConnectTime || (this.LongConnectTime != null && !this.LongConnectTime.Equals(input.LongConnectTime))) return false;
            if (this.LongConnectTimeHour != input.LongConnectTimeHour || (this.LongConnectTimeHour != null && !this.LongConnectTimeHour.Equals(input.LongConnectTimeHour))) return false;
            if (this.LongConnectTimeMinute != input.LongConnectTimeMinute || (this.LongConnectTimeMinute != null && !this.LongConnectTimeMinute.Equals(input.LongConnectTimeMinute))) return false;
            if (this.LongConnectTimeSecond != input.LongConnectTimeSecond || (this.LongConnectTimeSecond != null && !this.LongConnectTimeSecond.Equals(input.LongConnectTimeSecond))) return false;
            if (this.LongConnectEnable != input.LongConnectEnable) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Direction != input.Direction) return false;
            if (this.Source != input.Source || (this.Source != null && !this.Source.Equals(input.Source))) return false;
            if (this.Destination != input.Destination || (this.Destination != null && !this.Destination.Equals(input.Destination))) return false;
            if (this.Service != input.Service || (this.Service != null && !this.Service.Equals(input.Service))) return false;
            if (this.Tag != input.Tag || (this.Tag != null && !this.Tag.Equals(input.Tag))) return false;

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
                if (this.Sequence != null) hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                hashCode = hashCode * 59 + this.AddressType.GetHashCode();
                if (this.ActionType != null) hashCode = hashCode * 59 + this.ActionType.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Applications != null) hashCode = hashCode * 59 + this.Applications.GetHashCode();
                if (this.LongConnectTime != null) hashCode = hashCode * 59 + this.LongConnectTime.GetHashCode();
                if (this.LongConnectTimeHour != null) hashCode = hashCode * 59 + this.LongConnectTimeHour.GetHashCode();
                if (this.LongConnectTimeMinute != null) hashCode = hashCode * 59 + this.LongConnectTimeMinute.GetHashCode();
                if (this.LongConnectTimeSecond != null) hashCode = hashCode * 59 + this.LongConnectTimeSecond.GetHashCode();
                hashCode = hashCode * 59 + this.LongConnectEnable.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.Source != null) hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Destination != null) hashCode = hashCode * 59 + this.Destination.GetHashCode();
                if (this.Service != null) hashCode = hashCode * 59 + this.Service.GetHashCode();
                if (this.Tag != null) hashCode = hashCode * 59 + this.Tag.GetHashCode();
                return hashCode;
            }
        }
    }
}
