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
    public class ShowLogsCountRequest 
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

            public static bool operator !=(RangeEnum a, RangeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 聚合类型 **约束限制**： 不涉及 **取值范围**： risk_ip 访问风险IP数量 risk_host 访问风险域名数量  open_port 开放端口的数量 **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： 聚合类型 **约束限制**： 不涉及 **取值范围**： risk_ip 访问风险IP数量 risk_host 访问风险域名数量  open_port 开放端口的数量 **默认取值**： 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<ItemEnum>))]
        public class ItemEnum
        {
            /// <summary>
            /// Enum RISK_IP for value: risk_ip
            /// </summary>
            public static readonly ItemEnum RISK_IP = new ItemEnum("risk_ip");

            /// <summary>
            /// Enum RISK_HOST for value: risk_host
            /// </summary>
            public static readonly ItemEnum RISK_HOST = new ItemEnum("risk_host");

            /// <summary>
            /// Enum OPEN_PORT for value: open_port
            /// </summary>
            public static readonly ItemEnum OPEN_PORT = new ItemEnum("open_port");

            private static readonly Dictionary<string, ItemEnum> StaticFields =
            new Dictionary<string, ItemEnum>()
            {
                { "risk_ip", RISK_IP },
                { "risk_host", RISK_HOST },
                { "open_port", OPEN_PORT },
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
        /// **参数解释**： 聚合类型 **约束限制**： 不涉及 **取值范围**： risk_ip 访问风险IP数量 risk_host 访问风险域名数量  open_port 开放端口的数量 **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("item", IsQuery = true)]
        [JsonProperty("item", NullValueHandling = NullValueHandling.Ignore)]
        public ItemEnum Item { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowLogsCountRequest {\n");
            sb.Append("  fwInstanceId: ").Append(FwInstanceId).Append("\n");
            sb.Append("  range: ").Append(Range).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  vgwId: ").Append(VgwId).Append("\n");
            sb.Append("  item: ").Append(Item).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowLogsCountRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowLogsCountRequest input)
        {
            if (input == null) return false;
            if (this.FwInstanceId != input.FwInstanceId || (this.FwInstanceId != null && !this.FwInstanceId.Equals(input.FwInstanceId))) return false;
            if (this.Range != input.Range) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.VgwId != input.VgwId || (this.VgwId != null && input.VgwId != null && !this.VgwId.SequenceEqual(input.VgwId))) return false;
            if (this.Item != input.Item) return false;

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
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.VgwId != null) hashCode = hashCode * 59 + this.VgwId.GetHashCode();
                hashCode = hashCode * 59 + this.Item.GetHashCode();
                return hashCode;
            }
        }
    }
}
