using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// **参数解释：** 规则引擎配置内容 **约束限制：** 不涉及
    /// </summary>
    public class CreateRuleRequest 
    {

        /// <summary>
        /// **参数解释：** 规则名称 **约束限制：** 不涉及 **取值范围：** 1-50个字符 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 是否开启规则 **约束限制：** 不涉及 **取值范围：** - on: 开启 - off: 关闭 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释：** 规则的优先级，数值越大，优先级越高 **约束限制：** 优先级不能重复 **取值范围：** 1-100 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("conditions", NullValueHandling = NullValueHandling.Ignore)]
        public Conditions Conditions { get; set; }

        /// <summary>
        /// **参数解释：** 满足规则条件后执行的动作 **约束限制：** 不涉及
        /// </summary>
        [JsonProperty("actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Actions> Actions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRuleRequest {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  conditions: ").Append(Conditions).Append("\n");
            sb.Append("  actions: ").Append(Actions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateRuleRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateRuleRequest input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.Conditions != input.Conditions || (this.Conditions != null && !this.Conditions.Equals(input.Conditions))) return false;
            if (this.Actions != input.Actions || (this.Actions != null && input.Actions != null && !this.Actions.SequenceEqual(input.Actions))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.Conditions != null) hashCode = hashCode * 59 + this.Conditions.GetHashCode();
                if (this.Actions != null) hashCode = hashCode * 59 + this.Actions.GetHashCode();
                return hashCode;
            }
        }
    }
}
