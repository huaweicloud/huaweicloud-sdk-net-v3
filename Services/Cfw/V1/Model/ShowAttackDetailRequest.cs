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
    /// Request Object
    /// </summary>
    public class ShowAttackDetailRequest 
    {
        /// <summary>
        /// **参数解释**： 时间范围  **约束限制**： 不涉及 **取值范围**： 0为近一时 1近一天 2近七天   **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： 时间范围  **约束限制**： 不涉及 **取值范围**： 0为近一时 1近一天 2近七天   **默认取值**： 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<RangeEnum>))]
        public class RangeEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly RangeEnum NUMBER_0 = new RangeEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly RangeEnum NUMBER_1 = new RangeEnum(1);

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            public static readonly RangeEnum NUMBER_2 = new RangeEnum(2);

            private static readonly Dictionary<int?, RangeEnum> StaticFields =
            new Dictionary<int?, RangeEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
                { 2, NUMBER_2 },
            };

            private int? _value;

            public RangeEnum()
            {

            }

            public RangeEnum(int? value)
            {
                _value = value;
            }

            public static RangeEnum FromValue(int? value)
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

                if (this.Equals(obj as RangeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RangeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RangeEnum a, RangeEnum b)
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

            public static bool operator !=(RangeEnum a, RangeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 日志类型 **约束限制**： 不涉及 **取值范围**： internet为南北向日志、nat为nat场景日志，vpc为东西向日志，vgw为vgw场景日志 **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： 日志类型 **约束限制**： 不涉及 **取值范围**： internet为南北向日志、nat为nat场景日志，vpc为东西向日志，vgw为vgw场景日志 **默认取值**： 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<LogTypeEnum>))]
        public class LogTypeEnum
        {
            /// <summary>
            /// Enum INTERNET for value: internet
            /// </summary>
            public static readonly LogTypeEnum INTERNET = new LogTypeEnum("internet");

            /// <summary>
            /// Enum NAT for value: nat
            /// </summary>
            public static readonly LogTypeEnum NAT = new LogTypeEnum("nat");

            /// <summary>
            /// Enum VPC for value: vpc
            /// </summary>
            public static readonly LogTypeEnum VPC = new LogTypeEnum("vpc");

            /// <summary>
            /// Enum VGW for value: vgw
            /// </summary>
            public static readonly LogTypeEnum VGW = new LogTypeEnum("vgw");

            private static readonly Dictionary<string, LogTypeEnum> StaticFields =
            new Dictionary<string, LogTypeEnum>()
            {
                { "internet", INTERNET },
                { "nat", NAT },
                { "vpc", VPC },
                { "vgw", VGW },
            };

            private string _value;

            public LogTypeEnum()
            {

            }

            public LogTypeEnum(string value)
            {
                _value = value;
            }

            public static LogTypeEnum FromValue(string value)
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

                if (this.Equals(obj as LogTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LogTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LogTypeEnum a, LogTypeEnum b)
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

            public static bool operator !=(LogTypeEnum a, LogTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 动作 **约束限制**： 不涉及 **取值范围**： 0 全部 1 拦截 **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： 动作 **约束限制**： 不涉及 **取值范围**： 0 全部 1 拦截 **默认取值**： 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<ActionEnum>))]
        public class ActionEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly ActionEnum NUMBER_0 = new ActionEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly ActionEnum NUMBER_1 = new ActionEnum(1);

            private static readonly Dictionary<int?, ActionEnum> StaticFields =
            new Dictionary<int?, ActionEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
            };

            private int? _value;

            public ActionEnum()
            {

            }

            public ActionEnum(int? value)
            {
                _value = value;
            }

            public static ActionEnum FromValue(int? value)
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

                if (this.Equals(obj as ActionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ActionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ActionEnum a, ActionEnum b)
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

            public static bool operator !=(ActionEnum a, ActionEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 聚合类型 **约束限制**： 不涉及 **取值范围**： src_region_id TOP外部攻击来源地区 attack_type 攻击类型 in_src_ip TOP内部攻击来源IP out_src_ip TOP外部攻击来源IP dst_port TOP被攻击端口 dst_ip TOP攻击目的IP attack_rule TOP攻击规则 src_ip TOP攻击来源IP **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： 聚合类型 **约束限制**： 不涉及 **取值范围**： src_region_id TOP外部攻击来源地区 attack_type 攻击类型 in_src_ip TOP内部攻击来源IP out_src_ip TOP外部攻击来源IP dst_port TOP被攻击端口 dst_ip TOP攻击目的IP attack_rule TOP攻击规则 src_ip TOP攻击来源IP **默认取值**： 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<ItemEnum>))]
        public class ItemEnum
        {
            /// <summary>
            /// Enum SRC_REGION_ID for value: src_region_id
            /// </summary>
            public static readonly ItemEnum SRC_REGION_ID = new ItemEnum("src_region_id");

            /// <summary>
            /// Enum ATTACK_TYPE for value: attack_type
            /// </summary>
            public static readonly ItemEnum ATTACK_TYPE = new ItemEnum("attack_type");

            /// <summary>
            /// Enum IN_SRC_IP for value: in_src_ip
            /// </summary>
            public static readonly ItemEnum IN_SRC_IP = new ItemEnum("in_src_ip");

            /// <summary>
            /// Enum OUT_SRC_IP for value: out_src_ip
            /// </summary>
            public static readonly ItemEnum OUT_SRC_IP = new ItemEnum("out_src_ip");

            /// <summary>
            /// Enum DST_PORT for value: dst_port
            /// </summary>
            public static readonly ItemEnum DST_PORT = new ItemEnum("dst_port");

            /// <summary>
            /// Enum DST_IP for value: dst_ip
            /// </summary>
            public static readonly ItemEnum DST_IP = new ItemEnum("dst_ip");

            /// <summary>
            /// Enum ATTACK_RULE for value: attack_rule
            /// </summary>
            public static readonly ItemEnum ATTACK_RULE = new ItemEnum("attack_rule");

            /// <summary>
            /// Enum SRC_IP for value: src_ip
            /// </summary>
            public static readonly ItemEnum SRC_IP = new ItemEnum("src_ip");

            private static readonly Dictionary<string, ItemEnum> StaticFields =
            new Dictionary<string, ItemEnum>()
            {
                { "src_region_id", SRC_REGION_ID },
                { "attack_type", ATTACK_TYPE },
                { "in_src_ip", IN_SRC_IP },
                { "out_src_ip", OUT_SRC_IP },
                { "dst_port", DST_PORT },
                { "dst_ip", DST_IP },
                { "attack_rule", ATTACK_RULE },
                { "src_ip", SRC_IP },
            };

            private string _value;

            public ItemEnum()
            {

            }

            public ItemEnum(string value)
            {
                _value = value;
            }

            public static ItemEnum FromValue(string value)
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

                if (this.Equals(obj as ItemEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ItemEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ItemEnum a, ItemEnum b)
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

            public static bool operator !=(ItemEnum a, ItemEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 防火墙ID，用户创建防火墙实例后产生的唯一ID，配置后可区分不同防火墙，可通过[防火墙ID获取方式](cfw_02_0028.xml)获取 **约束限制**： 不涉及 **取值范围**： 32位UUID **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("fw_instance_id", IsQuery = true)]
        [JsonProperty("fw_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FwInstanceId { get; set; }

        /// <summary>
        /// **参数解释**： 时间范围  **约束限制**： 不涉及 **取值范围**： 0为近一时 1近一天 2近七天   **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("range", IsQuery = true)]
        [JsonProperty("range", NullValueHandling = NullValueHandling.Ignore)]
        public RangeEnum Range { get; set; }
        /// <summary>
        /// **参数解释**： 日志类型 **约束限制**： 不涉及 **取值范围**： internet为南北向日志、nat为nat场景日志，vpc为东西向日志，vgw为vgw场景日志 **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("log_type", IsQuery = true)]
        [JsonProperty("log_type", NullValueHandling = NullValueHandling.Ignore)]
        public LogTypeEnum LogType { get; set; }
        /// <summary>
        /// **参数解释**： 开始时间 **约束限制**： 不涉及 **取值范围**： 毫秒级时间戳 **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("start_time", IsQuery = true)]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTime { get; set; }

        /// <summary>
        /// **参数解释**： 结束时间 **约束限制**： 不涉及 **取值范围**： 毫秒级时间戳 **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }

        /// <summary>
        /// **参数解释**： VGW ID **约束限制**： 不涉及 **取值范围**： 32位UUID **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("vgw_id", IsQuery = true)]
        [JsonProperty("vgw_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VgwId { get; set; }

        /// <summary>
        /// **参数解释**： 动作 **约束限制**： 不涉及 **取值范围**： 0 全部 1 拦截 **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("action", IsQuery = true)]
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// **参数解释**： 聚合类型 **约束限制**： 不涉及 **取值范围**： src_region_id TOP外部攻击来源地区 attack_type 攻击类型 in_src_ip TOP内部攻击来源IP out_src_ip TOP外部攻击来源IP dst_port TOP被攻击端口 dst_ip TOP攻击目的IP attack_rule TOP攻击规则 src_ip TOP攻击来源IP **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("item", IsQuery = true)]
        [JsonProperty("item", NullValueHandling = NullValueHandling.Ignore)]
        public ItemEnum Item { get; set; }
        /// <summary>
        /// **参数解释**： 统计对象 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("value", IsQuery = true)]
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAttackDetailRequest {\n");
            sb.Append("  fwInstanceId: ").Append(FwInstanceId).Append("\n");
            sb.Append("  range: ").Append(Range).Append("\n");
            sb.Append("  logType: ").Append(LogType).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  vgwId: ").Append(VgwId).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  item: ").Append(Item).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAttackDetailRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAttackDetailRequest input)
        {
            if (input == null) return false;
            if (this.FwInstanceId != input.FwInstanceId || (this.FwInstanceId != null && !this.FwInstanceId.Equals(input.FwInstanceId))) return false;
            if (this.Range != input.Range) return false;
            if (this.LogType != input.LogType) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.VgwId != input.VgwId || (this.VgwId != null && input.VgwId != null && !this.VgwId.SequenceEqual(input.VgwId))) return false;
            if (this.Action != input.Action) return false;
            if (this.Item != input.Item) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;

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
                if (this.FwInstanceId != null) hashCode = hashCode * 59 + this.FwInstanceId.GetHashCode();
                hashCode = hashCode * 59 + this.Range.GetHashCode();
                hashCode = hashCode * 59 + this.LogType.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.VgwId != null) hashCode = hashCode * 59 + this.VgwId.GetHashCode();
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                hashCode = hashCode * 59 + this.Item.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }
}
