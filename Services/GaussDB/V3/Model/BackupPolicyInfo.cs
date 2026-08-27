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
    /// **参数解释**：  备份策略信息。
    /// </summary>
    public class BackupPolicyInfo 
    {

        /// <summary>
        /// **参数解释**：  指定已生成的备份文件可以保存的天数。  **取值范围**：  1-732。 您也可以联系客服申请开通最大保留天数为3660。
        /// </summary>
        [JsonProperty("retention_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// **参数解释**：  备份周期配置。  **取值范围**：  格式必须为“日期 月份 星期”形式的Cron表达式，时区为UTC时区。 日期支持填写1~31、特殊字符*（表示任意值）、特殊字符L（表示最后一天）。填写1~31或L时支持填写多个，需以逗号隔开。 月份支持填写1~12、特殊字符*（表示任意值）。 星期支持填写1~7，需以逗号隔开。
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }

        /// <summary>
        /// **参数解释**:  自动备份策略类型。  **取值范围**：   - base：表示基础策略。   - sparse：表示稀疏策略。
        /// </summary>
        [JsonProperty("policy_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupPolicyInfo {\n");
            sb.Append("  retentionDays: ").Append(RetentionDays).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  policyType: ").Append(PolicyType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackupPolicyInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackupPolicyInfo input)
        {
            if (input == null) return false;
            if (this.RetentionDays != input.RetentionDays || (this.RetentionDays != null && !this.RetentionDays.Equals(input.RetentionDays))) return false;
            if (this.Period != input.Period || (this.Period != null && !this.Period.Equals(input.Period))) return false;
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
                if (this.RetentionDays != null) hashCode = hashCode * 59 + this.RetentionDays.GetHashCode();
                if (this.Period != null) hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.PolicyType != null) hashCode = hashCode * 59 + this.PolicyType.GetHashCode();
                return hashCode;
            }
        }
    }
}
