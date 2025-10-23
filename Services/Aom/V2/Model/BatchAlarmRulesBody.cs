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
    /// 
    /// </summary>
    public class BatchAlarmRulesBody 
    {

        /// <summary>
        /// 当前状态是否启用。
        /// </summary>
        [JsonProperty("alarm_rule_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlarmRuleEnable { get; set; }

        /// <summary>
        /// 告警规则id。
        /// </summary>
        [JsonProperty("alarm_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? AlarmRuleId { get; set; }

        /// <summary>
        /// 告警规则名称。
        /// </summary>
        [JsonProperty("alarm_rule_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmRuleName { get; set; }

        /// <summary>
        /// 告警规则类型。 - metric：Prometheus指标 - event： 事件
        /// </summary>
        [JsonProperty("alarm_rule_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmRuleType { get; set; }

        /// <summary>
        /// 企业项目id。获取方式请参见：[获取企业项目ID](aom_04_0024.xml) 。  批量启停或批量修改单个企业项目下实例，填写企业项目id。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchAlarmRulesBody {\n");
            sb.Append("  alarmRuleEnable: ").Append(AlarmRuleEnable).Append("\n");
            sb.Append("  alarmRuleId: ").Append(AlarmRuleId).Append("\n");
            sb.Append("  alarmRuleName: ").Append(AlarmRuleName).Append("\n");
            sb.Append("  alarmRuleType: ").Append(AlarmRuleType).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchAlarmRulesBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchAlarmRulesBody input)
        {
            if (input == null) return false;
            if (this.AlarmRuleEnable != input.AlarmRuleEnable || (this.AlarmRuleEnable != null && !this.AlarmRuleEnable.Equals(input.AlarmRuleEnable))) return false;
            if (this.AlarmRuleId != input.AlarmRuleId || (this.AlarmRuleId != null && !this.AlarmRuleId.Equals(input.AlarmRuleId))) return false;
            if (this.AlarmRuleName != input.AlarmRuleName || (this.AlarmRuleName != null && !this.AlarmRuleName.Equals(input.AlarmRuleName))) return false;
            if (this.AlarmRuleType != input.AlarmRuleType || (this.AlarmRuleType != null && !this.AlarmRuleType.Equals(input.AlarmRuleType))) return false;
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
                if (this.AlarmRuleEnable != null) hashCode = hashCode * 59 + this.AlarmRuleEnable.GetHashCode();
                if (this.AlarmRuleId != null) hashCode = hashCode * 59 + this.AlarmRuleId.GetHashCode();
                if (this.AlarmRuleName != null) hashCode = hashCode * 59 + this.AlarmRuleName.GetHashCode();
                if (this.AlarmRuleType != null) hashCode = hashCode * 59 + this.AlarmRuleType.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
