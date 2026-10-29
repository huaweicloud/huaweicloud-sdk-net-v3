using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ConditionSelectPattern 
    {

        /// <summary>
        /// 条件类型，SERVICE_HOUR_TIME：时间段 PERIOD_NUM：周期数 PERIOD_TYPE：周期类型，年、月、天、小时 PURCHASE_SCENE：订购场景，订购、续订、变更 NUMBER_OF_PEOPLE：线性大小
        /// </summary>
        [JsonProperty("condition_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ConditionType { get; set; }

        /// <summary>
        /// 条件表达式
        /// </summary>
        [JsonProperty("condition_statement", NullValueHandling = NullValueHandling.Ignore)]
        public string ConditionStatement { get; set; }

        /// <summary>
        /// 定价策略类型，SIMPLE：简单定价 DIVISION：阶梯定价
        /// </summary>
        [JsonProperty("policy_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyMode { get; set; }

        /// <summary>
        /// 阶梯官网价，policy_mode取值为SIMPLE时为官网价，如果取值为DIVISION，则价格在division_pattern中。
        /// </summary>
        [JsonProperty("official_price", NullValueHandling = NullValueHandling.Ignore)]
        public string OfficialPrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("division_pattern", NullValueHandling = NullValueHandling.Ignore)]
        public DivisionPattern DivisionPattern { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConditionSelectPattern {\n");
            sb.Append("  conditionType: ").Append(ConditionType).Append("\n");
            sb.Append("  conditionStatement: ").Append(ConditionStatement).Append("\n");
            sb.Append("  policyMode: ").Append(PolicyMode).Append("\n");
            sb.Append("  officialPrice: ").Append(OfficialPrice).Append("\n");
            sb.Append("  divisionPattern: ").Append(DivisionPattern).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConditionSelectPattern);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConditionSelectPattern input)
        {
            if (input == null) return false;
            if (this.ConditionType != input.ConditionType || (this.ConditionType != null && !this.ConditionType.Equals(input.ConditionType))) return false;
            if (this.ConditionStatement != input.ConditionStatement || (this.ConditionStatement != null && !this.ConditionStatement.Equals(input.ConditionStatement))) return false;
            if (this.PolicyMode != input.PolicyMode || (this.PolicyMode != null && !this.PolicyMode.Equals(input.PolicyMode))) return false;
            if (this.OfficialPrice != input.OfficialPrice || (this.OfficialPrice != null && !this.OfficialPrice.Equals(input.OfficialPrice))) return false;
            if (this.DivisionPattern != input.DivisionPattern || (this.DivisionPattern != null && !this.DivisionPattern.Equals(input.DivisionPattern))) return false;

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
                if (this.ConditionType != null) hashCode = hashCode * 59 + this.ConditionType.GetHashCode();
                if (this.ConditionStatement != null) hashCode = hashCode * 59 + this.ConditionStatement.GetHashCode();
                if (this.PolicyMode != null) hashCode = hashCode * 59 + this.PolicyMode.GetHashCode();
                if (this.OfficialPrice != null) hashCode = hashCode * 59 + this.OfficialPrice.GetHashCode();
                if (this.DivisionPattern != null) hashCode = hashCode * 59 + this.DivisionPattern.GetHashCode();
                return hashCode;
            }
        }
    }
}
