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
    /// items
    /// </summary>
    public class RuleAclListResponseDTODataRecords 
    {
        /// <summary>
        /// 规则方向0：外到内1：内到外
        /// </summary>
        /// <value>规则方向0：外到内1：内到外</value>
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

            public static bool operator !=(DirectionEnum a, DirectionEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 规则类型，0：互联网规则，1：vpc规则，2：nat规则
        /// </summary>
        /// <value>规则类型，0：互联网规则，1：vpc规则，2：nat规则</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly TypeEnum NUMBER_0 = new TypeEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly TypeEnum NUMBER_1 = new TypeEnum(1);

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            public static readonly TypeEnum NUMBER_2 = new TypeEnum(2);

            private static readonly Dictionary<int?, TypeEnum> StaticFields =
            new Dictionary<int?, TypeEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
                { 2, NUMBER_2 },
            };

            private int? _value;

            public TypeEnum()
            {

            }

            public TypeEnum(int? value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(int? value)
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
        /// 规则id
        /// </summary>
        [JsonProperty("rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleId { get; set; }

        /// <summary>
        /// 地址类型0 ipv4，1 ipv6
        /// </summary>
        [JsonProperty("address_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? AddressType { get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 规则方向0：外到内1：内到外
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public DirectionEnum Direction { get; set; }
        /// <summary>
        /// 动作0：permit，1：deny
        /// </summary>
        [JsonProperty("action_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ActionType { get; set; }

        /// <summary>
        /// 规则下发状态 0：禁用，1：启用
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 长连接时长
        /// </summary>
        [JsonProperty("long_connect_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? LongConnectTime { get; set; }

        /// <summary>
        /// 长连接支持
        /// </summary>
        [JsonProperty("long_connect_enable", NullValueHandling = NullValueHandling.Ignore)]
        public int? LongConnectEnable { get; set; }

        /// <summary>
        /// 长连接时长对应小时
        /// </summary>
        [JsonProperty("long_connect_time_hour", NullValueHandling = NullValueHandling.Ignore)]
        public long? LongConnectTimeHour { get; set; }

        /// <summary>
        /// 长连接时长对应分钟
        /// </summary>
        [JsonProperty("long_connect_time_minute", NullValueHandling = NullValueHandling.Ignore)]
        public long? LongConnectTimeMinute { get; set; }

        /// <summary>
        /// 长连接时长秒
        /// </summary>
        [JsonProperty("long_connect_time_second", NullValueHandling = NullValueHandling.Ignore)]
        public long? LongConnectTimeSecond { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public RuleAddressDtoForResponse Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("destination", NullValueHandling = NullValueHandling.Ignore)]
        public RuleAddressDtoForResponse Destination { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("service", NullValueHandling = NullValueHandling.Ignore)]
        public RuleServiceDtoForResponse Service { get; set; }

        /// <summary>
        /// 规则类型，0：互联网规则，1：vpc规则，2：nat规则
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 规则创建时间，例如：\&quot;2024-08-12 08:40:00\&quot;
        /// </summary>
        [JsonProperty("created_date", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedDate { get; set; }

        /// <summary>
        /// 规则最后开启时间，例如：\&quot;2024-08-12 08:40:00\&quot;
        /// </summary>
        [JsonProperty("last_open_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastOpenTime { get; set; }

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
            sb.Append("class RuleAclListResponseDTODataRecords {\n");
            sb.Append("  ruleId: ").Append(RuleId).Append("\n");
            sb.Append("  addressType: ").Append(AddressType).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  direction: ").Append(Direction).Append("\n");
            sb.Append("  actionType: ").Append(ActionType).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  longConnectTime: ").Append(LongConnectTime).Append("\n");
            sb.Append("  longConnectEnable: ").Append(LongConnectEnable).Append("\n");
            sb.Append("  longConnectTimeHour: ").Append(LongConnectTimeHour).Append("\n");
            sb.Append("  longConnectTimeMinute: ").Append(LongConnectTimeMinute).Append("\n");
            sb.Append("  longConnectTimeSecond: ").Append(LongConnectTimeSecond).Append("\n");
            sb.Append("  source: ").Append(Source).Append("\n");
            sb.Append("  destination: ").Append(Destination).Append("\n");
            sb.Append("  service: ").Append(Service).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  createdDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  lastOpenTime: ").Append(LastOpenTime).Append("\n");
            sb.Append("  tag: ").Append(Tag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RuleAclListResponseDTODataRecords);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RuleAclListResponseDTODataRecords input)
        {
            if (input == null) return false;
            if (this.RuleId != input.RuleId || (this.RuleId != null && !this.RuleId.Equals(input.RuleId))) return false;
            if (this.AddressType != input.AddressType || (this.AddressType != null && !this.AddressType.Equals(input.AddressType))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Direction != input.Direction) return false;
            if (this.ActionType != input.ActionType || (this.ActionType != null && !this.ActionType.Equals(input.ActionType))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.LongConnectTime != input.LongConnectTime || (this.LongConnectTime != null && !this.LongConnectTime.Equals(input.LongConnectTime))) return false;
            if (this.LongConnectEnable != input.LongConnectEnable || (this.LongConnectEnable != null && !this.LongConnectEnable.Equals(input.LongConnectEnable))) return false;
            if (this.LongConnectTimeHour != input.LongConnectTimeHour || (this.LongConnectTimeHour != null && !this.LongConnectTimeHour.Equals(input.LongConnectTimeHour))) return false;
            if (this.LongConnectTimeMinute != input.LongConnectTimeMinute || (this.LongConnectTimeMinute != null && !this.LongConnectTimeMinute.Equals(input.LongConnectTimeMinute))) return false;
            if (this.LongConnectTimeSecond != input.LongConnectTimeSecond || (this.LongConnectTimeSecond != null && !this.LongConnectTimeSecond.Equals(input.LongConnectTimeSecond))) return false;
            if (this.Source != input.Source || (this.Source != null && !this.Source.Equals(input.Source))) return false;
            if (this.Destination != input.Destination || (this.Destination != null && !this.Destination.Equals(input.Destination))) return false;
            if (this.Service != input.Service || (this.Service != null && !this.Service.Equals(input.Service))) return false;
            if (this.Type != input.Type) return false;
            if (this.CreatedDate != input.CreatedDate || (this.CreatedDate != null && !this.CreatedDate.Equals(input.CreatedDate))) return false;
            if (this.LastOpenTime != input.LastOpenTime || (this.LastOpenTime != null && !this.LastOpenTime.Equals(input.LastOpenTime))) return false;
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
                if (this.RuleId != null) hashCode = hashCode * 59 + this.RuleId.GetHashCode();
                if (this.AddressType != null) hashCode = hashCode * 59 + this.AddressType.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.ActionType != null) hashCode = hashCode * 59 + this.ActionType.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.LongConnectTime != null) hashCode = hashCode * 59 + this.LongConnectTime.GetHashCode();
                if (this.LongConnectEnable != null) hashCode = hashCode * 59 + this.LongConnectEnable.GetHashCode();
                if (this.LongConnectTimeHour != null) hashCode = hashCode * 59 + this.LongConnectTimeHour.GetHashCode();
                if (this.LongConnectTimeMinute != null) hashCode = hashCode * 59 + this.LongConnectTimeMinute.GetHashCode();
                if (this.LongConnectTimeSecond != null) hashCode = hashCode * 59 + this.LongConnectTimeSecond.GetHashCode();
                if (this.Source != null) hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Destination != null) hashCode = hashCode * 59 + this.Destination.GetHashCode();
                if (this.Service != null) hashCode = hashCode * 59 + this.Service.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.CreatedDate != null) hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.LastOpenTime != null) hashCode = hashCode * 59 + this.LastOpenTime.GetHashCode();
                if (this.Tag != null) hashCode = hashCode * 59 + this.Tag.GetHashCode();
                return hashCode;
            }
        }
    }
}
