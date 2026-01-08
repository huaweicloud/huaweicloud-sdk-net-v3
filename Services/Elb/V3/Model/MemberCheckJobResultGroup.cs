using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// **参数解释**：配置检查。
    /// </summary>
    public class MemberCheckJobResultGroup 
    {

        /// <summary>
        /// **参数解释**：检查结果，true表示检查通过，false为检查不通过。  **取值范围**：不涉及
        /// </summary>
        [JsonProperty("check_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CheckResult { get; set; }

        /// <summary>
        /// **参数解释**：分组检查项汇总。
        /// </summary>
        [JsonProperty("check_items", NullValueHandling = NullValueHandling.Ignore)]
        public List<MemberCheckJobResultItem> CheckItems { get; set; }

        /// <summary>
        /// **参数解释**：processed检查完成，processing检查中，failed检查失败。  **取值范围**：不涉及
        /// </summary>
        [JsonProperty("check_status", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MemberCheckJobResultGroup {\n");
            sb.Append("  checkResult: ").Append(CheckResult).Append("\n");
            sb.Append("  checkItems: ").Append(CheckItems).Append("\n");
            sb.Append("  checkStatus: ").Append(CheckStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MemberCheckJobResultGroup);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MemberCheckJobResultGroup input)
        {
            if (input == null) return false;
            if (this.CheckResult != input.CheckResult || (this.CheckResult != null && !this.CheckResult.Equals(input.CheckResult))) return false;
            if (this.CheckItems != input.CheckItems || (this.CheckItems != null && input.CheckItems != null && !this.CheckItems.SequenceEqual(input.CheckItems))) return false;
            if (this.CheckStatus != input.CheckStatus || (this.CheckStatus != null && !this.CheckStatus.Equals(input.CheckStatus))) return false;

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
                if (this.CheckResult != null) hashCode = hashCode * 59 + this.CheckResult.GetHashCode();
                if (this.CheckItems != null) hashCode = hashCode * 59 + this.CheckItems.GetHashCode();
                if (this.CheckStatus != null) hashCode = hashCode * 59 + this.CheckStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
