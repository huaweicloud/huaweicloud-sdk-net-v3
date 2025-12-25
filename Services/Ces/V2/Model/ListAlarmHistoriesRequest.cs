using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListAlarmHistoriesRequest 
    {
        /// <summary>
        /// Defines status
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum OK for value: ok
            /// </summary>
            public static readonly StatusEnum OK = new StatusEnum("ok");

            /// <summary>
            /// Enum ALARM for value: alarm
            /// </summary>
            public static readonly StatusEnum ALARM = new StatusEnum("alarm");

            /// <summary>
            /// Enum INVALID for value: invalid
            /// </summary>
            public static readonly StatusEnum INVALID = new StatusEnum("invalid");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "ok", OK },
                { "alarm", ALARM },
                { "invalid", INVALID },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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
        /// **参数解释**： 告警类型。 **约束限制**： 不涉及。 **取值范围**： 枚举值 - event: 查询事件类型告警 - metric: 查询指标类型告警。 **默认取值**： 不涉及。 
        /// </summary>
        /// <value>**参数解释**： 告警类型。 **约束限制**： 不涉及。 **取值范围**： 枚举值 - event: 查询事件类型告警 - metric: 查询指标类型告警。 **默认取值**： 不涉及。 </value>
        [JsonConverter(typeof(EnumClassConverter<AlarmTypeEnum>))]
        public class AlarmTypeEnum
        {
            /// <summary>
            /// Enum EVENT for value: event
            /// </summary>
            public static readonly AlarmTypeEnum EVENT = new AlarmTypeEnum("event");

            /// <summary>
            /// Enum METRIC for value: metric
            /// </summary>
            public static readonly AlarmTypeEnum METRIC = new AlarmTypeEnum("metric");

            private static readonly Dictionary<string, AlarmTypeEnum> StaticFields =
            new Dictionary<string, AlarmTypeEnum>()
            {
                { "event", EVENT },
                { "metric", METRIC },
            };

            private string _value;

            public AlarmTypeEnum()
            {

            }

            public AlarmTypeEnum(string value)
            {
                _value = value;
            }

            public static AlarmTypeEnum FromValue(string value)
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

                if (this.Equals(obj as AlarmTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AlarmTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AlarmTypeEnum a, AlarmTypeEnum b)
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

            public static bool operator !=(AlarmTypeEnum a, AlarmTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 按关键字排序。 **约束限制**： 不涉及。 **取值范围**： 枚举值。 - first_alarm_time: 告警产生时间 - update_time: 更新时间 - alarm_level: 告警级别 - record_id: 表记录主键 **默认取值**： update_time 
        /// </summary>
        /// <value>**参数解释**： 按关键字排序。 **约束限制**： 不涉及。 **取值范围**： 枚举值。 - first_alarm_time: 告警产生时间 - update_time: 更新时间 - alarm_level: 告警级别 - record_id: 表记录主键 **默认取值**： update_time </value>
        [JsonConverter(typeof(EnumClassConverter<OrderByEnum>))]
        public class OrderByEnum
        {
            /// <summary>
            /// Enum FIRST_ALARM_TIME for value: first_alarm_time
            /// </summary>
            public static readonly OrderByEnum FIRST_ALARM_TIME = new OrderByEnum("first_alarm_time");

            /// <summary>
            /// Enum UPDATE_TIME for value: update_time
            /// </summary>
            public static readonly OrderByEnum UPDATE_TIME = new OrderByEnum("update_time");

            /// <summary>
            /// Enum ALARM_LEVEL for value: alarm_level
            /// </summary>
            public static readonly OrderByEnum ALARM_LEVEL = new OrderByEnum("alarm_level");

            /// <summary>
            /// Enum RECORD_ID for value: record_id
            /// </summary>
            public static readonly OrderByEnum RECORD_ID = new OrderByEnum("record_id");

            private static readonly Dictionary<string, OrderByEnum> StaticFields =
            new Dictionary<string, OrderByEnum>()
            {
                { "first_alarm_time", FIRST_ALARM_TIME },
                { "update_time", UPDATE_TIME },
                { "alarm_level", ALARM_LEVEL },
                { "record_id", RECORD_ID },
            };

            private string _value;

            public OrderByEnum()
            {

            }

            public OrderByEnum(string value)
            {
                _value = value;
            }

            public static OrderByEnum FromValue(string value)
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

                if (this.Equals(obj as OrderByEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OrderByEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OrderByEnum a, OrderByEnum b)
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

            public static bool operator !=(OrderByEnum a, OrderByEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 告警ID列表。告警ID：以al开头，后跟22位由字母或数字组成的字符串。 **约束限制**： 列表最大长度为50。 
        /// </summary>
        [SDKProperty("alarm_id", IsQuery = true)]
        [JsonProperty("alarm_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AlarmId { get; set; }

        /// <summary>
        /// **参数解释**： 告警记录ID。 **约束限制**： 不涉及。 **取值范围**： 以ah开头，后跟22位由字母或数字组成的字符串，字符串长度为24。 **默认取值**： 不涉及。 
        /// </summary>
        [SDKProperty("record_id", IsQuery = true)]
        [JsonProperty("record_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordId { get; set; }

        /// <summary>
        /// **参数解释**： 告警规则名称。 **约束限制**： 不涉及。 **取值范围**： 最大128字符长度。 **默认取值**： 不涉及。 
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 告警规则状态列表。告警规则状态：枚举值，ok为正常，alarm为告警，invalid为已失效。 **约束限制**： 列表长度最大为3。 
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public List<StatusEnum> Status { get; set; }
        /// <summary>
        /// **参数解释**： 告警级别。 **约束限制**： 不涉及。 **取值范围**： 枚举值。 - 1：紧急 - 2：重要 - 3：次要 - 4：提示 **默认取值**： 不涉及。 
        /// </summary>
        [SDKProperty("level", IsQuery = true)]
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public int? Level { get; set; }

        /// <summary>
        /// **参数解释**： 查询服务的命名空间，各服务命名空间请参考“[服务命名空间](ces_03_0059.xml)”。 **约束限制**： 不涉及。 **取值范围**： 格式为service.item；service和item必须是字符串，必须以字母开头，只能包含0-9/a-z/A-Z/_。字符串的长度必须在 3 到 32个字符之间。 **默认取值**： 不涉及。 
        /// </summary>
        [SDKProperty("namespace", IsQuery = true)]
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// **参数解释**： 告警资源ID。 **约束限制**： 不涉及。 **取值范围**： 多维度情况按字母升序排列并使用逗号分隔。长度为[0,2048]个字符。 **默认取值**： 不涉及。 
        /// </summary>
        [SDKProperty("resource_id", IsQuery = true)]
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// **参数解释**： 查询告警记录的起始更新时间，例如：2022-02-10T10:05:46+08:00。 **约束限制**： 不涉及。 **取值范围**： 长度为[0,64]个字符。 **默认取值**： 不涉及。 
        /// </summary>
        [SDKProperty("from", IsQuery = true)]
        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public string From { get; set; }

        /// <summary>
        /// **参数解释**： 查询告警记录的截止更新时间，例如：2022-02-10T10:05:47+08:00。 **约束限制**： 不涉及。 **取值范围**： 长度为[0,64]个字符。 **默认取值**： 不涉及。 
        /// </summary>
        [SDKProperty("to", IsQuery = true)]
        [JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
        public string To { get; set; }

        /// <summary>
        /// **参数解释**： 告警类型。 **约束限制**： 不涉及。 **取值范围**： 枚举值 - event: 查询事件类型告警 - metric: 查询指标类型告警。 **默认取值**： 不涉及。 
        /// </summary>
        [SDKProperty("alarm_type", IsQuery = true)]
        [JsonProperty("alarm_type", NullValueHandling = NullValueHandling.Ignore)]
        public AlarmTypeEnum AlarmType { get; set; }
        /// <summary>
        /// **参数解释**： 查询告警记录的起始创建时间，例如：2022-02-10T10:05:46+08:00。 **约束限制**： 不涉及。 **取值范围**： 长度为[0,64]个字符。 **默认取值**： 不涉及。 
        /// </summary>
        [SDKProperty("create_time_from", IsQuery = true)]
        [JsonProperty("create_time_from", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTimeFrom { get; set; }

        /// <summary>
        /// **参数解释**： 查询告警记录的截止创建时间，例如：2022-02-10T10:05:47+08:00。 **约束限制**： 不涉及。 **取值范围**： 长度为[0,64]个字符。 **默认取值**： 不涉及。 
        /// </summary>
        [SDKProperty("create_time_to", IsQuery = true)]
        [JsonProperty("create_time_to", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTimeTo { get; set; }

        /// <summary>
        /// **参数解释**： 分页偏移量。 **约束限制**： 不涉及。 **取值范围**： 整数，最小值为0，最大值为1000000000 **默认取值**： 0 
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// **参数解释**： 分页偏移量。 **约束限制**： 不涉及。 **取值范围**： 整数，最小值为1，最大值为100 **默认取值**： 100 
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// **参数解释**： 按关键字排序。 **约束限制**： 不涉及。 **取值范围**： 枚举值。 - first_alarm_time: 告警产生时间 - update_time: 更新时间 - alarm_level: 告警级别 - record_id: 表记录主键 **默认取值**： update_time 
        /// </summary>
        [SDKProperty("order_by", IsQuery = true)]
        [JsonProperty("order_by", NullValueHandling = NullValueHandling.Ignore)]
        public OrderByEnum OrderBy { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAlarmHistoriesRequest {\n");
            sb.Append("  alarmId: ").Append(AlarmId).Append("\n");
            sb.Append("  recordId: ").Append(RecordId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  level: ").Append(Level).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  from: ").Append(From).Append("\n");
            sb.Append("  to: ").Append(To).Append("\n");
            sb.Append("  alarmType: ").Append(AlarmType).Append("\n");
            sb.Append("  createTimeFrom: ").Append(CreateTimeFrom).Append("\n");
            sb.Append("  createTimeTo: ").Append(CreateTimeTo).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  orderBy: ").Append(OrderBy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAlarmHistoriesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAlarmHistoriesRequest input)
        {
            if (input == null) return false;
            if (this.AlarmId != input.AlarmId || (this.AlarmId != null && input.AlarmId != null && !this.AlarmId.SequenceEqual(input.AlarmId))) return false;
            if (this.RecordId != input.RecordId || (this.RecordId != null && !this.RecordId.Equals(input.RecordId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Status != input.Status || (this.Status != null && input.Status != null && !this.Status.SequenceEqual(input.Status))) return false;
            if (this.Level != input.Level || (this.Level != null && !this.Level.Equals(input.Level))) return false;
            if (this.Namespace != input.Namespace || (this.Namespace != null && !this.Namespace.Equals(input.Namespace))) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.From != input.From || (this.From != null && !this.From.Equals(input.From))) return false;
            if (this.To != input.To || (this.To != null && !this.To.Equals(input.To))) return false;
            if (this.AlarmType != input.AlarmType) return false;
            if (this.CreateTimeFrom != input.CreateTimeFrom || (this.CreateTimeFrom != null && !this.CreateTimeFrom.Equals(input.CreateTimeFrom))) return false;
            if (this.CreateTimeTo != input.CreateTimeTo || (this.CreateTimeTo != null && !this.CreateTimeTo.Equals(input.CreateTimeTo))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.OrderBy != input.OrderBy) return false;

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
                if (this.AlarmId != null) hashCode = hashCode * 59 + this.AlarmId.GetHashCode();
                if (this.RecordId != null) hashCode = hashCode * 59 + this.RecordId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Level != null) hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.Namespace != null) hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.From != null) hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.To != null) hashCode = hashCode * 59 + this.To.GetHashCode();
                hashCode = hashCode * 59 + this.AlarmType.GetHashCode();
                if (this.CreateTimeFrom != null) hashCode = hashCode * 59 + this.CreateTimeFrom.GetHashCode();
                if (this.CreateTimeTo != null) hashCode = hashCode * 59 + this.CreateTimeTo.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                hashCode = hashCode * 59 + this.OrderBy.GetHashCode();
                return hashCode;
            }
        }
    }
}
