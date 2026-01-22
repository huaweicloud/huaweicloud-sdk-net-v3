using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// **参数解释**： 修改规则顺序请求体 **约束限制**： 不涉及
    /// </summary>
    public class OrderRuleAclDto 
    {

        /// <summary>
        /// **参数解释**： 目标规则ID，填写后添加的新规则置位于此规则之后，非置顶时不能为空，置顶时为空，目标规则ID可以通过[查询防护规则接口](ListAclRules.xml)获得，通过返回值中的data.records.rule_id（.表示各对象之间层级的区分）获得。 **约束限制**： 非置顶时目标规则需要存在 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("dest_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DestRuleId { get; set; }

        /// <summary>
        /// **参数解释**： 规则是否置顶，用于确认规则是否置顶 **约束限制**： 不涉及 **取值范围**： 0代表非置顶，1代表置顶 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("top", NullValueHandling = NullValueHandling.Ignore)]
        public int? Top { get; set; }

        /// <summary>
        /// **参数解释**： 规则是否置底，用于确认规则是否置底 **约束限制**： 不涉及 **取值范围**： 0代表非置底，1代表置底 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("bottom", NullValueHandling = NullValueHandling.Ignore)]
        public int? Bottom { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderRuleAclDto {\n");
            sb.Append("  destRuleId: ").Append(DestRuleId).Append("\n");
            sb.Append("  top: ").Append(Top).Append("\n");
            sb.Append("  bottom: ").Append(Bottom).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OrderRuleAclDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OrderRuleAclDto input)
        {
            if (input == null) return false;
            if (this.DestRuleId != input.DestRuleId || (this.DestRuleId != null && !this.DestRuleId.Equals(input.DestRuleId))) return false;
            if (this.Top != input.Top || (this.Top != null && !this.Top.Equals(input.Top))) return false;
            if (this.Bottom != input.Bottom || (this.Bottom != null && !this.Bottom.Equals(input.Bottom))) return false;

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
                if (this.DestRuleId != null) hashCode = hashCode * 59 + this.DestRuleId.GetHashCode();
                if (this.Top != null) hashCode = hashCode * 59 + this.Top.GetHashCode();
                if (this.Bottom != null) hashCode = hashCode * 59 + this.Bottom.GetHashCode();
                return hashCode;
            }
        }
    }
}
