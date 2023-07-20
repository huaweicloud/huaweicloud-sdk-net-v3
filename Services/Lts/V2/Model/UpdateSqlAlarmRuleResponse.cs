using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UpdateSqlAlarmRuleResponse : SdkResponse
    {
        /// <summary>
        /// 告警级别
        /// </summary>
        /// <value>告警级别</value>
        [JsonConverter(typeof(EnumClassConverter<SqlAlarmLevelEnum>))]
        public class SqlAlarmLevelEnum
        {
            /// <summary>
            /// Enum INFO for value: Info
            /// </summary>
            public static readonly SqlAlarmLevelEnum INFO = new SqlAlarmLevelEnum("Info");

            /// <summary>
            /// Enum MINOR for value: Minor
            /// </summary>
            public static readonly SqlAlarmLevelEnum MINOR = new SqlAlarmLevelEnum("Minor");

            /// <summary>
            /// Enum MAJOR for value: Major
            /// </summary>
            public static readonly SqlAlarmLevelEnum MAJOR = new SqlAlarmLevelEnum("Major");

            /// <summary>
            /// Enum CRITICAL for value: CRITICAL
            /// </summary>
            public static readonly SqlAlarmLevelEnum CRITICAL = new SqlAlarmLevelEnum("CRITICAL");

            private static readonly Dictionary<string, SqlAlarmLevelEnum> StaticFields =
            new Dictionary<string, SqlAlarmLevelEnum>()
            {
                { "Info", INFO },
                { "Minor", MINOR },
                { "Major", MAJOR },
                { "CRITICAL", CRITICAL },
            };

            private string _value;

            public SqlAlarmLevelEnum()
            {

            }

            public SqlAlarmLevelEnum(string value)
            {
                _value = value;
            }

            public static SqlAlarmLevelEnum FromValue(string value)
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

                if (this.Equals(obj as SqlAlarmLevelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SqlAlarmLevelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SqlAlarmLevelEnum a, SqlAlarmLevelEnum b)
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

            public static bool operator !=(SqlAlarmLevelEnum a, SqlAlarmLevelEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 测试
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 测试
        /// </summary>
        [JsonProperty("indexId", NullValueHandling = NullValueHandling.Ignore)]
        public string IndexId { get; set; }

        /// <summary>
        /// 测试
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// 测试
        /// </summary>
        [JsonProperty("projectId", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// SQL告警名称
        /// </summary>
        [JsonProperty("sql_alarm_rule_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlAlarmRuleName { get; set; }

        /// <summary>
        /// SQL告警规则id
        /// </summary>
        [JsonProperty("sql_alarm_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlAlarmRuleId { get; set; }

        /// <summary>
        /// SQL告警信息描述
        /// </summary>
        [JsonProperty("sql_alarm_rule_description", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlAlarmRuleDescription { get; set; }

        /// <summary>
        /// SQL详细信息
        /// </summary>
        [JsonProperty("sql_requests", NullValueHandling = NullValueHandling.Ignore)]
        public List<SqlRequest> SqlRequests { get; set; }

        /// <summary>
        /// 告警统计周期
        /// </summary>
        [JsonProperty("frequency", NullValueHandling = NullValueHandling.Ignore)]
        public Frequency Frequency { get; set; }

        /// <summary>
        /// 条件表达式
        /// </summary>
        [JsonProperty("condition_expression", NullValueHandling = NullValueHandling.Ignore)]
        public string ConditionExpression { get; set; }

        /// <summary>
        /// 告警级别
        /// </summary>
        [JsonProperty("sql_alarm_level", NullValueHandling = NullValueHandling.Ignore)]
        public SqlAlarmLevelEnum SqlAlarmLevel { get; set; }
        /// <summary>
        /// 是否发送
        /// </summary>
        [JsonProperty("sql_alarm_send", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SqlAlarmSend { get; set; }

        /// <summary>
        /// domainId
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 创建时间(毫秒时间戳)
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 更新时间(毫秒时间戳)
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// 主题
        /// </summary>
        [JsonProperty("topics", NullValueHandling = NullValueHandling.Ignore)]
        public List<Topics> Topics { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSqlAlarmRuleResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  indexId: ").Append(IndexId).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  sqlAlarmRuleName: ").Append(SqlAlarmRuleName).Append("\n");
            sb.Append("  sqlAlarmRuleId: ").Append(SqlAlarmRuleId).Append("\n");
            sb.Append("  sqlAlarmRuleDescription: ").Append(SqlAlarmRuleDescription).Append("\n");
            sb.Append("  sqlRequests: ").Append(SqlRequests).Append("\n");
            sb.Append("  frequency: ").Append(Frequency).Append("\n");
            sb.Append("  conditionExpression: ").Append(ConditionExpression).Append("\n");
            sb.Append("  sqlAlarmLevel: ").Append(SqlAlarmLevel).Append("\n");
            sb.Append("  sqlAlarmSend: ").Append(SqlAlarmSend).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  topics: ").Append(Topics).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateSqlAlarmRuleResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateSqlAlarmRuleResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IndexId == input.IndexId ||
                    (this.IndexId != null &&
                    this.IndexId.Equals(input.IndexId))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.SqlAlarmRuleName == input.SqlAlarmRuleName ||
                    (this.SqlAlarmRuleName != null &&
                    this.SqlAlarmRuleName.Equals(input.SqlAlarmRuleName))
                ) && 
                (
                    this.SqlAlarmRuleId == input.SqlAlarmRuleId ||
                    (this.SqlAlarmRuleId != null &&
                    this.SqlAlarmRuleId.Equals(input.SqlAlarmRuleId))
                ) && 
                (
                    this.SqlAlarmRuleDescription == input.SqlAlarmRuleDescription ||
                    (this.SqlAlarmRuleDescription != null &&
                    this.SqlAlarmRuleDescription.Equals(input.SqlAlarmRuleDescription))
                ) && 
                (
                    this.SqlRequests == input.SqlRequests ||
                    this.SqlRequests != null &&
                    input.SqlRequests != null &&
                    this.SqlRequests.SequenceEqual(input.SqlRequests)
                ) && 
                (
                    this.Frequency == input.Frequency ||
                    (this.Frequency != null &&
                    this.Frequency.Equals(input.Frequency))
                ) && 
                (
                    this.ConditionExpression == input.ConditionExpression ||
                    (this.ConditionExpression != null &&
                    this.ConditionExpression.Equals(input.ConditionExpression))
                ) && 
                (
                    this.SqlAlarmLevel == input.SqlAlarmLevel ||
                    (this.SqlAlarmLevel != null &&
                    this.SqlAlarmLevel.Equals(input.SqlAlarmLevel))
                ) && 
                (
                    this.SqlAlarmSend == input.SqlAlarmSend ||
                    (this.SqlAlarmSend != null &&
                    this.SqlAlarmSend.Equals(input.SqlAlarmSend))
                ) && 
                (
                    this.DomainId == input.DomainId ||
                    (this.DomainId != null &&
                    this.DomainId.Equals(input.DomainId))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    (this.UpdateTime != null &&
                    this.UpdateTime.Equals(input.UpdateTime))
                ) && 
                (
                    this.Topics == input.Topics ||
                    this.Topics != null &&
                    input.Topics != null &&
                    this.Topics.SequenceEqual(input.Topics)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IndexId != null)
                    hashCode = hashCode * 59 + this.IndexId.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.SqlAlarmRuleName != null)
                    hashCode = hashCode * 59 + this.SqlAlarmRuleName.GetHashCode();
                if (this.SqlAlarmRuleId != null)
                    hashCode = hashCode * 59 + this.SqlAlarmRuleId.GetHashCode();
                if (this.SqlAlarmRuleDescription != null)
                    hashCode = hashCode * 59 + this.SqlAlarmRuleDescription.GetHashCode();
                if (this.SqlRequests != null)
                    hashCode = hashCode * 59 + this.SqlRequests.GetHashCode();
                if (this.Frequency != null)
                    hashCode = hashCode * 59 + this.Frequency.GetHashCode();
                if (this.ConditionExpression != null)
                    hashCode = hashCode * 59 + this.ConditionExpression.GetHashCode();
                if (this.SqlAlarmLevel != null)
                    hashCode = hashCode * 59 + this.SqlAlarmLevel.GetHashCode();
                if (this.SqlAlarmSend != null)
                    hashCode = hashCode * 59 + this.SqlAlarmSend.GetHashCode();
                if (this.DomainId != null)
                    hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.Topics != null)
                    hashCode = hashCode * 59 + this.Topics.GetHashCode();
                return hashCode;
            }
        }
    }
}
