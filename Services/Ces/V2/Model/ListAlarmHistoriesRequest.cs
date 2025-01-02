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
        /// 告警类型，event：查询事件类型告警，metric：查询指标类型告警
        /// </summary>
        /// <value>告警类型，event：查询事件类型告警，metric：查询指标类型告警</value>
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

            public static bool operator !=(AlarmTypeEnum a, AlarmTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 按关键字排序, 默认为update_time, {first_alarm_time: 告警产生时间, update_time: 更新时间, alarm_level: 告警级别, record_id：表记录主键} 
        /// </summary>
        /// <value>按关键字排序, 默认为update_time, {first_alarm_time: 告警产生时间, update_time: 更新时间, alarm_level: 告警级别, record_id：表记录主键} </value>
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

            public static bool operator !=(OrderByEnum a, OrderByEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 告警ID,以al开头，后跟22位由字母或数字组成的字符串
        /// </summary>
        [SDKProperty("alarm_id", IsQuery = true)]
        [JsonProperty("alarm_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmId { get; set; }

        /// <summary>
        /// 告警记录ID,以ah开头，后跟22位由字母或数字组成的字符串
        /// </summary>
        [SDKProperty("record_id", IsQuery = true)]
        [JsonProperty("record_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordId { get; set; }

        /// <summary>
        /// 告警规则名称
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 告警类型，event：查询事件类型告警，metric：查询指标类型告警
        /// </summary>
        [SDKProperty("alarm_type", IsQuery = true)]
        [JsonProperty("alarm_type", NullValueHandling = NullValueHandling.Ignore)]
        public AlarmTypeEnum AlarmType { get; set; }
        /// <summary>
        /// 告警规则状态, ok为正常，alarm为告警，invalid为已失效
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 告警级别, 1为紧急，2为重要，3为次要，4为提示
        /// </summary>
        [SDKProperty("level", IsQuery = true)]
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public int? Level { get; set; }

        /// <summary>
        /// 查询服务的命名空间，各服务命名空间请参考[服务命名空间](https://support.huaweicloud.com/usermanual-ces/zh-cn_topic_0202622212.html)
        /// </summary>
        [SDKProperty("namespace", IsQuery = true)]
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 告警资源ID，多维度情况按字母升序排列并使用逗号分隔
        /// </summary>
        [SDKProperty("resource_id", IsQuery = true)]
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 查询告警记录的起始时间，例如：2022-02-10T10:05:46+08:00
        /// </summary>
        [SDKProperty("from", IsQuery = true)]
        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public string From { get; set; }

        /// <summary>
        /// 查询告警记录的截止时间，例如：2022-02-10T10:05:47+08:00
        /// </summary>
        [SDKProperty("to", IsQuery = true)]
        [JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
        public string To { get; set; }

        /// <summary>
        /// 分页偏移量
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 按关键字排序, 默认为update_time, {first_alarm_time: 告警产生时间, update_time: 更新时间, alarm_level: 告警级别, record_id：表记录主键} 
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
            sb.Append("  alarmType: ").Append(AlarmType).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  level: ").Append(Level).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  from: ").Append(From).Append("\n");
            sb.Append("  to: ").Append(To).Append("\n");
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
            if (this.AlarmId != input.AlarmId || (this.AlarmId != null && !this.AlarmId.Equals(input.AlarmId))) return false;
            if (this.RecordId != input.RecordId || (this.RecordId != null && !this.RecordId.Equals(input.RecordId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.AlarmType != input.AlarmType) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Level != input.Level || (this.Level != null && !this.Level.Equals(input.Level))) return false;
            if (this.Namespace != input.Namespace || (this.Namespace != null && !this.Namespace.Equals(input.Namespace))) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.From != input.From || (this.From != null && !this.From.Equals(input.From))) return false;
            if (this.To != input.To || (this.To != null && !this.To.Equals(input.To))) return false;
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
                hashCode = hashCode * 59 + this.AlarmType.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Level != null) hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.Namespace != null) hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.From != null) hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.To != null) hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                hashCode = hashCode * 59 + this.OrderBy.GetHashCode();
                return hashCode;
            }
        }
    }
}
