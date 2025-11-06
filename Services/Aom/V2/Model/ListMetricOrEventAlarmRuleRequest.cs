using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListMetricOrEventAlarmRuleRequest 
    {
        /// <summary>
        /// 告警规则状态。 - “OK”：正常 - “alarm”：超限阈值 - “Effective”：生效中 - “Invalid”：停用中
        /// </summary>
        /// <value>告警规则状态。 - “OK”：正常 - “alarm”：超限阈值 - “Effective”：生效中 - “Invalid”：停用中</value>
        [JsonConverter(typeof(EnumClassConverter<AlarmRuleStatusEnum>))]
        public class AlarmRuleStatusEnum
        {
            /// <summary>
            /// Enum OK for value: OK
            /// </summary>
            public static readonly AlarmRuleStatusEnum OK = new AlarmRuleStatusEnum("OK");

            /// <summary>
            /// Enum ALARM for value: alarm
            /// </summary>
            public static readonly AlarmRuleStatusEnum ALARM = new AlarmRuleStatusEnum("alarm");

            /// <summary>
            /// Enum EFFECTIVE for value: Effective
            /// </summary>
            public static readonly AlarmRuleStatusEnum EFFECTIVE = new AlarmRuleStatusEnum("Effective");

            /// <summary>
            /// Enum INVALID for value: Invalid
            /// </summary>
            public static readonly AlarmRuleStatusEnum INVALID = new AlarmRuleStatusEnum("Invalid");

            private static readonly Dictionary<string, AlarmRuleStatusEnum> StaticFields =
            new Dictionary<string, AlarmRuleStatusEnum>()
            {
                { "OK", OK },
                { "alarm", ALARM },
                { "Effective", EFFECTIVE },
                { "Invalid", INVALID },
            };

            private string _value;

            public AlarmRuleStatusEnum()
            {

            }

            public AlarmRuleStatusEnum(string value)
            {
                _value = value;
            }

            public static AlarmRuleStatusEnum FromValue(string value)
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

                if (this.Equals(obj as AlarmRuleStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AlarmRuleStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AlarmRuleStatusEnum a, AlarmRuleStatusEnum b)
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

            public static bool operator !=(AlarmRuleStatusEnum a, AlarmRuleStatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 告警规则类型。 - “metric”：指标告警规则 - “event”：事件告警规则
        /// </summary>
        /// <value>告警规则类型。 - “metric”：指标告警规则 - “event”：事件告警规则</value>
        [JsonConverter(typeof(EnumClassConverter<AlarmRuleTypeEnum>))]
        public class AlarmRuleTypeEnum
        {
            /// <summary>
            /// Enum METRIC for value: metric
            /// </summary>
            public static readonly AlarmRuleTypeEnum METRIC = new AlarmRuleTypeEnum("metric");

            /// <summary>
            /// Enum EVENT for value: event
            /// </summary>
            public static readonly AlarmRuleTypeEnum EVENT = new AlarmRuleTypeEnum("event");

            private static readonly Dictionary<string, AlarmRuleTypeEnum> StaticFields =
            new Dictionary<string, AlarmRuleTypeEnum>()
            {
                { "metric", METRIC },
                { "event", EVENT },
            };

            private string _value;

            public AlarmRuleTypeEnum()
            {

            }

            public AlarmRuleTypeEnum(string value)
            {
                _value = value;
            }

            public static AlarmRuleTypeEnum FromValue(string value)
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

                if (this.Equals(obj as AlarmRuleTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AlarmRuleTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AlarmRuleTypeEnum a, AlarmRuleTypeEnum b)
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

            public static bool operator !=(AlarmRuleTypeEnum a, AlarmRuleTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 告警规则名称。
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 用于限制本次返回的结果数据条数。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }

        /// <summary>
        /// 分页查询起始位置，为非负整数。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public string Offset { get; set; }

        /// <summary>
        /// 根据告警规则名称或者告警创建时间排序。 - alarm_rule_name.asc - alarm_create_time.desc
        /// </summary>
        [SDKProperty("sort_by", IsQuery = true)]
        [JsonProperty("sort_by", NullValueHandling = NullValueHandling.Ignore)]
        public string SortBy { get; set; }

        /// <summary>
        /// 事件告警规则事件来源。 - “RDS” - “EVS” - “CCE” - “LTS” - “AOM”
        /// </summary>
        [SDKProperty("event_source", IsQuery = true)]
        [JsonProperty("event_source", NullValueHandling = NullValueHandling.Ignore)]
        public string EventSource { get; set; }

        /// <summary>
        /// 事件告警级别。 - “Critical\&quot; - “Major” - “Minor” - “Info”
        /// </summary>
        [SDKProperty("event_severity", IsQuery = true)]
        [JsonProperty("event_severity", NullValueHandling = NullValueHandling.Ignore)]
        public string EventSeverity { get; set; }

        /// <summary>
        /// 告警规则状态。 - “OK”：正常 - “alarm”：超限阈值 - “Effective”：生效中 - “Invalid”：停用中
        /// </summary>
        [SDKProperty("alarm_rule_status", IsQuery = true)]
        [JsonProperty("alarm_rule_status", NullValueHandling = NullValueHandling.Ignore)]
        public AlarmRuleStatusEnum AlarmRuleStatus { get; set; }
        /// <summary>
        /// 告警规则类型。 - “metric”：指标告警规则 - “event”：事件告警规则
        /// </summary>
        [SDKProperty("alarm_rule_type", IsQuery = true)]
        [JsonProperty("alarm_rule_type", NullValueHandling = NullValueHandling.Ignore)]
        public AlarmRuleTypeEnum AlarmRuleType { get; set; }
        /// <summary>
        /// Prometheus实例id。
        /// </summary>
        [SDKProperty("prom_instance_id", IsQuery = true)]
        [JsonProperty("prom_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PromInstanceId { get; set; }

        /// <summary>
        /// 绑定的告警行动规则名称。
        /// </summary>
        [SDKProperty("bind_notification_rule_id", IsQuery = true)]
        [JsonProperty("bind_notification_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BindNotificationRuleId { get; set; }

        /// <summary>
        /// CCE集群id。
        /// </summary>
        [SDKProperty("related_cce_clusters", IsQuery = true)]
        [JsonProperty("related_cce_clusters", NullValueHandling = NullValueHandling.Ignore)]
        public string RelatedCceClusters { get; set; }

        /// <summary>
        /// 企业项目id。获取方式请参见：[获取企业项目ID](aom_04_0024.xml)。 - 查询单个企业项目下实例，填写企业项目id。  - 查询所有企业项目下实例，填写“all_granted_eps”。
        /// </summary>
        [SDKProperty("Enterprise-Project-Id", IsHeader = true)]
        [JsonProperty("Enterprise-Project-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListMetricOrEventAlarmRuleRequest {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  sortBy: ").Append(SortBy).Append("\n");
            sb.Append("  eventSource: ").Append(EventSource).Append("\n");
            sb.Append("  eventSeverity: ").Append(EventSeverity).Append("\n");
            sb.Append("  alarmRuleStatus: ").Append(AlarmRuleStatus).Append("\n");
            sb.Append("  alarmRuleType: ").Append(AlarmRuleType).Append("\n");
            sb.Append("  promInstanceId: ").Append(PromInstanceId).Append("\n");
            sb.Append("  bindNotificationRuleId: ").Append(BindNotificationRuleId).Append("\n");
            sb.Append("  relatedCceClusters: ").Append(RelatedCceClusters).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListMetricOrEventAlarmRuleRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMetricOrEventAlarmRuleRequest input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.SortBy != input.SortBy || (this.SortBy != null && !this.SortBy.Equals(input.SortBy))) return false;
            if (this.EventSource != input.EventSource || (this.EventSource != null && !this.EventSource.Equals(input.EventSource))) return false;
            if (this.EventSeverity != input.EventSeverity || (this.EventSeverity != null && !this.EventSeverity.Equals(input.EventSeverity))) return false;
            if (this.AlarmRuleStatus != input.AlarmRuleStatus) return false;
            if (this.AlarmRuleType != input.AlarmRuleType) return false;
            if (this.PromInstanceId != input.PromInstanceId || (this.PromInstanceId != null && !this.PromInstanceId.Equals(input.PromInstanceId))) return false;
            if (this.BindNotificationRuleId != input.BindNotificationRuleId || (this.BindNotificationRuleId != null && !this.BindNotificationRuleId.Equals(input.BindNotificationRuleId))) return false;
            if (this.RelatedCceClusters != input.RelatedCceClusters || (this.RelatedCceClusters != null && !this.RelatedCceClusters.Equals(input.RelatedCceClusters))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;

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
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.SortBy != null) hashCode = hashCode * 59 + this.SortBy.GetHashCode();
                if (this.EventSource != null) hashCode = hashCode * 59 + this.EventSource.GetHashCode();
                if (this.EventSeverity != null) hashCode = hashCode * 59 + this.EventSeverity.GetHashCode();
                hashCode = hashCode * 59 + this.AlarmRuleStatus.GetHashCode();
                hashCode = hashCode * 59 + this.AlarmRuleType.GetHashCode();
                if (this.PromInstanceId != null) hashCode = hashCode * 59 + this.PromInstanceId.GetHashCode();
                if (this.BindNotificationRuleId != null) hashCode = hashCode * 59 + this.BindNotificationRuleId.GetHashCode();
                if (this.RelatedCceClusters != null) hashCode = hashCode * 59 + this.RelatedCceClusters.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
