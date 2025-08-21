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
    public class ReportProfileInfoVO 
    {

        /// <summary>
        /// **参数解释**： 报告类型 **取值范围**： daily 日报 weekly 周报 custom 自定义报告
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// **参数解释**： 描述信息 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 模板名称 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 发送时间 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("send_period", NullValueHandling = NullValueHandling.Ignore)]
        public int? SendPeriod { get; set; }

        /// <summary>
        /// **参数解释**： 发送星期 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("send_week_day", NullValueHandling = NullValueHandling.Ignore)]
        public int? SendWeekDay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("statistic_period", NullValueHandling = NullValueHandling.Ignore)]
        public StatisticPeriod StatisticPeriod { get; set; }

        /// <summary>
        /// **参数解释**： 启用状态 **取值范围**：  0 关闭 1 启用
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// **参数解释**： 通知主题名称 **取值范围**：  不涉及
        /// </summary>
        [JsonProperty("topic_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicName { get; set; }

        /// <summary>
        /// **参数解释**： 通知主题urn **取值范围**：  不涉及
        /// </summary>
        [JsonProperty("topic_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicUrn { get; set; }

        /// <summary>
        /// **参数解释**： 通知方式 **取值范围**： 0 SMN通知方式 1 不需要通知
        /// </summary>
        [JsonProperty("subscription_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportProfileInfoVO {\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  sendPeriod: ").Append(SendPeriod).Append("\n");
            sb.Append("  sendWeekDay: ").Append(SendWeekDay).Append("\n");
            sb.Append("  statisticPeriod: ").Append(StatisticPeriod).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  topicName: ").Append(TopicName).Append("\n");
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
            return this.Equals(input as ReportProfileInfoVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReportProfileInfoVO input)
        {
            if (input == null) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.SendPeriod != input.SendPeriod || (this.SendPeriod != null && !this.SendPeriod.Equals(input.SendPeriod))) return false;
            if (this.SendWeekDay != input.SendWeekDay || (this.SendWeekDay != null && !this.SendWeekDay.Equals(input.SendWeekDay))) return false;
            if (this.StatisticPeriod != input.StatisticPeriod || (this.StatisticPeriod != null && !this.StatisticPeriod.Equals(input.StatisticPeriod))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.TopicName != input.TopicName || (this.TopicName != null && !this.TopicName.Equals(input.TopicName))) return false;
            if (this.TopicUrn != input.TopicUrn || (this.TopicUrn != null && !this.TopicUrn.Equals(input.TopicUrn))) return false;
            if (this.SubscriptionType != input.SubscriptionType || (this.SubscriptionType != null && !this.SubscriptionType.Equals(input.SubscriptionType))) return false;

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
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SendPeriod != null) hashCode = hashCode * 59 + this.SendPeriod.GetHashCode();
                if (this.SendWeekDay != null) hashCode = hashCode * 59 + this.SendWeekDay.GetHashCode();
                if (this.StatisticPeriod != null) hashCode = hashCode * 59 + this.StatisticPeriod.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TopicName != null) hashCode = hashCode * 59 + this.TopicName.GetHashCode();
                if (this.TopicUrn != null) hashCode = hashCode * 59 + this.TopicUrn.GetHashCode();
                if (this.SubscriptionType != null) hashCode = hashCode * 59 + this.SubscriptionType.GetHashCode();
                return hashCode;
            }
        }
    }
}
