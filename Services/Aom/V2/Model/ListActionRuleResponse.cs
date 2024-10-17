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
    /// Response Object
    /// </summary>
    public class ListActionRuleResponse : SdkResponse
    {

        /// <summary>
        /// 告警行动规则列表
        /// </summary>
        [JsonProperty("action_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<ActionRule> ActionRules { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListActionRuleResponse {\n");
            sb.Append("  actionRules: ").Append(ActionRules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListActionRuleResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListActionRuleResponse input)
        {
            if (input == null) return false;
            if (this.ActionRules != input.ActionRules || (this.ActionRules != null && input.ActionRules != null && !this.ActionRules.SequenceEqual(input.ActionRules))) return false;

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
                if (this.ActionRules != null) hashCode = hashCode * 59 + this.ActionRules.GetHashCode();
                return hashCode;
            }
        }
    }
}
