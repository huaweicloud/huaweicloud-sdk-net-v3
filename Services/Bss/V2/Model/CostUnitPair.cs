using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bss.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CostUnitPair 
    {

        /// <summary>
        /// 成本单元名称。
        /// </summary>
        [JsonProperty("cost_unit_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CostUnitName { get; set; }

        /// <summary>
        /// 成本单元规则值。
        /// </summary>
        [JsonProperty("cost_unit_rule_value", NullValueHandling = NullValueHandling.Ignore)]
        public string CostUnitRuleValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CostUnitPair {\n");
            sb.Append("  costUnitName: ").Append(CostUnitName).Append("\n");
            sb.Append("  costUnitRuleValue: ").Append(CostUnitRuleValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CostUnitPair);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CostUnitPair input)
        {
            if (input == null) return false;
            if (this.CostUnitName != input.CostUnitName || (this.CostUnitName != null && !this.CostUnitName.Equals(input.CostUnitName))) return false;
            if (this.CostUnitRuleValue != input.CostUnitRuleValue || (this.CostUnitRuleValue != null && !this.CostUnitRuleValue.Equals(input.CostUnitRuleValue))) return false;

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
                if (this.CostUnitName != null) hashCode = hashCode * 59 + this.CostUnitName.GetHashCode();
                if (this.CostUnitRuleValue != null) hashCode = hashCode * 59 + this.CostUnitRuleValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
