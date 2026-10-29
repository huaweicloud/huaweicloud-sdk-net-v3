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
        /// **参数解释:** 规则ID。可调用[[获取规则列表接口](https://support.huaweicloud.com/api-codecheck/ListRules.html)](tag:hws)[[获取规则列表接口](https://support.huaweicloud.com/intl/zh-cn/api-codecheck/ListRules.html)](tag:hws_hk)[获取规则列表接口](tag:hcs,hcs_sm,hcs_site,hcs_sitesm,fcs)获取。 **约束限制:** 不涉及。 **取值范围:** 32位项目ID。 **默认取值:** 不涉及。
        /// </summary>
        [JsonProperty("rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleId { get; set; }

        /// <summary>
        /// **参数解释:** attribute的告警等级。 **约束限制:** 不涉及。 **取值范围:** - 0：致命。 - 1：严重。 - 2：一般。 - 3：提示。 **默认取值:** 不涉及。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// **参数解释:** 规则阈值详细。
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
