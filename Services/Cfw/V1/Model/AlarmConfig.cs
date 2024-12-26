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
    public class AlarmConfig 
    {

        /// <summary>
        /// 账号名称
        /// </summary>
        [JsonProperty("account_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// 告警id
        /// </summary>
        [JsonProperty("alarm_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmId { get; set; }

        /// <summary>
        /// 告警周期，0：全天，1：8时到22时
        /// </summary>
        [JsonProperty("alarm_time_period", NullValueHandling = NullValueHandling.Ignore)]
        public int? AlarmTimePeriod { get; set; }

        /// <summary>
        /// 告警类型 0:攻击告警; 1:流量超额预警; 2:EIP未防护告警; 3:威胁情报告警
        /// </summary>
        [JsonProperty("alarm_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? AlarmType { get; set; }

        /// <summary>
        /// 告警状态 0:失效; 1:生效
        /// </summary>
        [JsonProperty("enable_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? EnableStatus { get; set; }

        /// <summary>
        /// 告警触发频次
        /// </summary>
        [JsonProperty("frequency_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FrequencyCount { get; set; }

        /// <summary>
        /// 告警频次时间范围
        /// </summary>
        [JsonProperty("frequency_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? FrequencyTime { get; set; }

        /// <summary>
        /// 告警语言
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// 告警主题名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 告警等级
        /// </summary>
        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public string Severity { get; set; }

        /// <summary>
        /// 告警urn
        /// </summary>
        [JsonProperty("topic_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicUrn { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlarmConfig {\n");
            sb.Append("  accountName: ").Append(AccountName).Append("\n");
            sb.Append("  alarmId: ").Append(AlarmId).Append("\n");
            sb.Append("  alarmTimePeriod: ").Append(AlarmTimePeriod).Append("\n");
            sb.Append("  alarmType: ").Append(AlarmType).Append("\n");
            sb.Append("  enableStatus: ").Append(EnableStatus).Append("\n");
            sb.Append("  frequencyCount: ").Append(FrequencyCount).Append("\n");
            sb.Append("  frequencyTime: ").Append(FrequencyTime).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  severity: ").Append(Severity).Append("\n");
            sb.Append("  topicUrn: ").Append(TopicUrn).Append("\n");
            sb.Append("  username: ").Append(Username).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlarmConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlarmConfig input)
        {
            if (input == null) return false;
            if (this.AccountName != input.AccountName || (this.AccountName != null && !this.AccountName.Equals(input.AccountName))) return false;
            if (this.AlarmId != input.AlarmId || (this.AlarmId != null && !this.AlarmId.Equals(input.AlarmId))) return false;
            if (this.AlarmTimePeriod != input.AlarmTimePeriod || (this.AlarmTimePeriod != null && !this.AlarmTimePeriod.Equals(input.AlarmTimePeriod))) return false;
            if (this.AlarmType != input.AlarmType || (this.AlarmType != null && !this.AlarmType.Equals(input.AlarmType))) return false;
            if (this.EnableStatus != input.EnableStatus || (this.EnableStatus != null && !this.EnableStatus.Equals(input.EnableStatus))) return false;
            if (this.FrequencyCount != input.FrequencyCount || (this.FrequencyCount != null && !this.FrequencyCount.Equals(input.FrequencyCount))) return false;
            if (this.FrequencyTime != input.FrequencyTime || (this.FrequencyTime != null && !this.FrequencyTime.Equals(input.FrequencyTime))) return false;
            if (this.Language != input.Language || (this.Language != null && !this.Language.Equals(input.Language))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Severity != input.Severity || (this.Severity != null && !this.Severity.Equals(input.Severity))) return false;
            if (this.TopicUrn != input.TopicUrn || (this.TopicUrn != null && !this.TopicUrn.Equals(input.TopicUrn))) return false;
            if (this.Username != input.Username || (this.Username != null && !this.Username.Equals(input.Username))) return false;

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
                if (this.AccountName != null) hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.AlarmId != null) hashCode = hashCode * 59 + this.AlarmId.GetHashCode();
                if (this.AlarmTimePeriod != null) hashCode = hashCode * 59 + this.AlarmTimePeriod.GetHashCode();
                if (this.AlarmType != null) hashCode = hashCode * 59 + this.AlarmType.GetHashCode();
                if (this.EnableStatus != null) hashCode = hashCode * 59 + this.EnableStatus.GetHashCode();
                if (this.FrequencyCount != null) hashCode = hashCode * 59 + this.FrequencyCount.GetHashCode();
                if (this.FrequencyTime != null) hashCode = hashCode * 59 + this.FrequencyTime.GetHashCode();
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Severity != null) hashCode = hashCode * 59 + this.Severity.GetHashCode();
                if (this.TopicUrn != null) hashCode = hashCode * 59 + this.TopicUrn.GetHashCode();
                if (this.Username != null) hashCode = hashCode * 59 + this.Username.GetHashCode();
                return hashCode;
            }
        }
    }
}
