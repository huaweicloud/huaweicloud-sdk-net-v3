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
    public class CreateReportProfileDto 
    {
        /// <summary>
        /// **参数解释**： 报告类型 **约束限制**： 不涉及 **取值范围**： daily 日报 weekly 周报 custom 自定义报告 **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： 报告类型 **约束限制**： 不涉及 **取值范围**： daily 日报 weekly 周报 custom 自定义报告 **默认取值**： 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<CategoryEnum>))]
        public class CategoryEnum
        {
            /// <summary>
            /// Enum DAILY for value: daily
            /// </summary>
            public static readonly CategoryEnum DAILY = new CategoryEnum("daily");

            /// <summary>
            /// Enum WEEKLY for value: weekly
            /// </summary>
            public static readonly CategoryEnum WEEKLY = new CategoryEnum("weekly");

            /// <summary>
            /// Enum CUSTOM for value: custom
            /// </summary>
            public static readonly CategoryEnum CUSTOM = new CategoryEnum("custom");

            private static readonly Dictionary<string, CategoryEnum> StaticFields =
            new Dictionary<string, CategoryEnum>()
            {
                { "daily", DAILY },
                { "weekly", WEEKLY },
                { "custom", CUSTOM },
            };

            private string _value;

            public CategoryEnum()
            {

            }

            public CategoryEnum(string value)
            {
                _value = value;
            }

            public static CategoryEnum FromValue(string value)
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

                if (this.Equals(obj as CategoryEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CategoryEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CategoryEnum a, CategoryEnum b)
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

            public static bool operator !=(CategoryEnum a, CategoryEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 启用状态 **约束限制**： 不涉及 **取值范围**： 0 关闭 1 启用 **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： 启用状态 **约束限制**： 不涉及 **取值范围**： 0 关闭 1 启用 **默认取值**： 不涉及</value>
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 通知方式 **约束限制**： 不涉及 **取值范围**： 0 SMN通知方式 1 不需要通知 **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： 通知方式 **约束限制**： 不涉及 **取值范围**： 0 SMN通知方式 1 不需要通知 **默认取值**： 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<SubscriptionTypeEnum>))]
        public class SubscriptionTypeEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly SubscriptionTypeEnum NUMBER_0 = new SubscriptionTypeEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly SubscriptionTypeEnum NUMBER_1 = new SubscriptionTypeEnum(1);

            private static readonly Dictionary<int?, SubscriptionTypeEnum> StaticFields =
            new Dictionary<int?, SubscriptionTypeEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
            };

            private int? _value;

            public SubscriptionTypeEnum()
            {

            }

            public SubscriptionTypeEnum(int? value)
            {
                _value = value;
            }

            public static SubscriptionTypeEnum FromValue(int? value)
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

                if (this.Equals(obj as SubscriptionTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SubscriptionTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SubscriptionTypeEnum a, SubscriptionTypeEnum b)
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

            public static bool operator !=(SubscriptionTypeEnum a, SubscriptionTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 报告类型 **约束限制**： 不涉及 **取值范围**： daily 日报 weekly 周报 custom 自定义报告 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public CategoryEnum Category { get; set; }
        /// <summary>
        /// **参数解释**： 描述信息 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 模板名称 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 发送时间，日报和周报需要设置 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("send_period", NullValueHandling = NullValueHandling.Ignore)]
        public int? SendPeriod { get; set; }

        /// <summary>
        /// **参数解释**： 发送星期，周报需要设置 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("send_week_day", NullValueHandling = NullValueHandling.Ignore)]
        public int? SendWeekDay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("statistic_period", NullValueHandling = NullValueHandling.Ignore)]
        public StatisticPeriod StatisticPeriod { get; set; }

        /// <summary>
        /// **参数解释**： 启用状态 **约束限制**： 不涉及 **取值范围**： 0 关闭 1 启用 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// **参数解释**： 通知群组 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("topic_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicUrn { get; set; }

        /// <summary>
        /// **参数解释**： 通知方式 **约束限制**： 不涉及 **取值范围**： 0 SMN通知方式 1 不需要通知 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("subscription_type", NullValueHandling = NullValueHandling.Ignore)]
        public SubscriptionTypeEnum SubscriptionType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateReportProfileDto {\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  sendPeriod: ").Append(SendPeriod).Append("\n");
            sb.Append("  sendWeekDay: ").Append(SendWeekDay).Append("\n");
            sb.Append("  statisticPeriod: ").Append(StatisticPeriod).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  topicUrn: ").Append(TopicUrn).Append("\n");
            sb.Append("  subscriptionType: ").Append(SubscriptionType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateReportProfileDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateReportProfileDto input)
        {
            if (input == null) return false;
            if (this.Category != input.Category) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.SendPeriod != input.SendPeriod || (this.SendPeriod != null && !this.SendPeriod.Equals(input.SendPeriod))) return false;
            if (this.SendWeekDay != input.SendWeekDay || (this.SendWeekDay != null && !this.SendWeekDay.Equals(input.SendWeekDay))) return false;
            if (this.StatisticPeriod != input.StatisticPeriod || (this.StatisticPeriod != null && !this.StatisticPeriod.Equals(input.StatisticPeriod))) return false;
            if (this.Status != input.Status) return false;
            if (this.TopicUrn != input.TopicUrn || (this.TopicUrn != null && !this.TopicUrn.Equals(input.TopicUrn))) return false;
            if (this.SubscriptionType != input.SubscriptionType) return false;

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
                hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SendPeriod != null) hashCode = hashCode * 59 + this.SendPeriod.GetHashCode();
                if (this.SendWeekDay != null) hashCode = hashCode * 59 + this.SendWeekDay.GetHashCode();
                if (this.StatisticPeriod != null) hashCode = hashCode * 59 + this.StatisticPeriod.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TopicUrn != null) hashCode = hashCode * 59 + this.TopicUrn.GetHashCode();
                hashCode = hashCode * 59 + this.SubscriptionType.GetHashCode();
                return hashCode;
            }
        }
    }
}
