using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomAttributesRule 
    {

        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleId { get; set; }

        /// <summary>
        /// attribute的问题级别，0致命，1严重，2一般，3提示
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// 规则阈值详细
        /// </summary>
        [JsonProperty("rule_config_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<RuleConfig> RuleConfigList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomAttributesRule {\n");
            sb.Append("  ruleId: ").Append(RuleId).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  ruleConfigList: ").Append(RuleConfigList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CustomAttributesRule);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CustomAttributesRule input)
        {
            if (input == null) return false;
            if (this.RuleId != input.RuleId || (this.RuleId != null && !this.RuleId.Equals(input.RuleId))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
            if (this.RuleConfigList != input.RuleConfigList || (this.RuleConfigList != null && input.RuleConfigList != null && !this.RuleConfigList.SequenceEqual(input.RuleConfigList))) return false;

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
                if (this.RuleId != null) hashCode = hashCode * 59 + this.RuleId.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.RuleConfigList != null) hashCode = hashCode * 59 + this.RuleConfigList.GetHashCode();
                return hashCode;
            }
        }
    }
}
