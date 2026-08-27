using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Policy 
    {

        /// <summary>
        /// **参数解释**：  备份周期配置。  **约束限制**：  格式必须为“日期 月份 星期”形式的Cron表达式，时区为UTC时区。  **取值范围**：  日期支持填写1~31、特殊字符*（表示任意值）、特殊字符L（表示最后一天）。填写1~31或L时支持填写多个，需以逗号隔开。 月份支持填写1~12、特殊字符*（表示任意值）。 星期支持填写1~7（1表示星期一，2表示星期二，依次类推）、特殊字符*（表示任意值）。填写1~7数字时支持填写多个，需以逗号隔开。  取值示例： - \\* \\* 6 表示每周六执行任务，适用于周策略。 - \\* \\* 1,2,3 表示每周一、二、三执行任务，适用于周策略。 - 1,2 * * 表示每月1号、2号执行任务，适用于月策略。 - L * * 表示每月的最后一天执行任务，适用于月策略。 - 15 3 * 表示每年的3月15日执行任务，适用于年策略。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }

        /// <summary>
        /// **参数解释**：  备份文件的保留天数，单位为天。  **约束限制**：  不涉及。  **取值范围**：  1~732天。 您也可以联系客服申请开通最大保留天数为3660。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("retention_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// **参数解释**：  备份策略类型。  **约束限制**：  不涉及。  **取值范围**：    - base：表示基础策略。    - sparse：表示稀疏策略。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("policy_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Policy {\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  retentionDays: ").Append(RetentionDays).Append("\n");
            sb.Append("  policyType: ").Append(PolicyType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Policy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Policy input)
        {
            if (input == null) return false;
            if (this.Period != input.Period || (this.Period != null && !this.Period.Equals(input.Period))) return false;
            if (this.RetentionDays != input.RetentionDays || (this.RetentionDays != null && !this.RetentionDays.Equals(input.RetentionDays))) return false;
            if (this.PolicyType != input.PolicyType || (this.PolicyType != null && !this.PolicyType.Equals(input.PolicyType))) return false;

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
                if (this.Period != null) hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.RetentionDays != null) hashCode = hashCode * 59 + this.RetentionDays.GetHashCode();
                if (this.PolicyType != null) hashCode = hashCode * 59 + this.PolicyType.GetHashCode();
                return hashCode;
            }
        }
    }
}
